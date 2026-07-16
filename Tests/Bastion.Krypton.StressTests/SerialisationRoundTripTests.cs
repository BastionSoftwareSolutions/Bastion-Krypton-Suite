#region BSD License
/*
 * New (Bastion) file in a work derived from BSD-3-Clause licensed code:
 * © Component Factory Pty Ltd, 2006 - 2016. Then modifications by Peter Wagner (aka Wagnerp),
 * Simon Coghlan (aka Smurf-IV), Giduac, Ahmed Abdelhameed, Lesandro & tobitege et al. 2017 - 2026.
 * © Bastion Software Solutions Ltd 2026. All rights reserved.
 */
#endregion

using System;
using System.Collections.Generic;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Windows.Forms;
using System.Xml;

using Bastion.Krypton.UnitTests.Infrastructure;

using Krypton.Navigator;

using Krypton.Toolkit;

using Krypton.Workspace;

using NUnit.Framework;

namespace Bastion.Krypton.StressTests
{
    /// <summary>
    /// Spec §6.3 attack 8 — serialisation round-trips through the components' own
    /// persistence APIs: the custom-palette Export/Import XML pipeline and the workspace
    /// layout XML pipeline (state → XML → fresh instance → XML must be stable). The full
    /// CodeDom designer-serialisation round-trip is deliberately deferred: it needs the
    /// designer host/loader stack (IDesignerHost, CodeDomComponentSerializationService and a
    /// compiler round-trip), which is a VS-designer integration scenario, not something a
    /// headless NUnit process can execute faithfully across 11 TFMs — see Tests\README.md.
    /// (Docking-config XML round-trips are covered in <see cref="RibbonDockingScaleTests"/>.)
    /// </summary>
    [TestFixture]
    [Category("Adversarial")]
    public class SerialisationRoundTripTests : UiTestBase
    {
        /// <summary>
        /// Custom palette export → import into a fresh palette → re-export: the two exported
        /// documents must be identical after normalising volatile metadata (export date).
        /// </summary>
        [Test]
        public void CustomPalette_ExportImportReExport_IsStable()
        {
            List<AttackFailure> failures = AttackHarness.Run("palette-roundtrip", collected =>
            {
                using var source = new KryptonCustomPaletteBase();
                // Give the palette non-default state so the round-trip carries real payload.
                source.ButtonStyles.ButtonCommon.StateCommon.Back.Color1 = Color.DarkOrchid;
                source.ButtonStyles.ButtonCommon.StateCommon.Content.ShortText.Color1 = Color.Gold;
                source.ToolMenuStatus.UseRoundedEdges = InheritBool.False;

                byte[]? first = null;
                AttackHarness.Attack(collected, "palette-export", "Export(ignoreDefaults:false,silent:true)", "-",
                    () => first = source.Export(false, true));
                Assert.That(first, Is.Not.Null.And.Not.Empty, "Palette export produced nothing.");

                using var destination = new KryptonCustomPaletteBase();
                AttackHarness.Attack(collected, "palette-import", "Import(byte[],silent:true)", "-",
                    () => destination.Import(first!, true));

                byte[]? second = null;
                AttackHarness.Attack(collected, "palette-reexport", "Export(ignoreDefaults:false,silent:true)", "-",
                    () => second = destination.Export(false, true));

                if (first != null && second != null)
                {
                    string a = NormalisePaletteXml(first);
                    string b = NormalisePaletteXml(second);
                    Assert.That(b, Is.EqualTo(a),
                        "Palette state changed across the export → import → export round-trip.");
                }
            });

            AttackHarness.AssertClean("palette-roundtrip", failures);
        }

        /// <summary>
        /// Corrupted palette XML (the same battery as the docking/workspace loaders) must
        /// fail gracefully in the silent import path — a catchable exception, never a
        /// defect-class crash or a hang.
        /// </summary>
        [Test]
        public void CustomPalette_CorruptedImport_FailsGracefully()
        {
            var outcomes = new List<string>();
            List<AttackFailure> failures = AttackHarness.Run("palette-corruption", collected =>
            {
                using var source = new KryptonCustomPaletteBase();
                byte[] pristine = source.Export(false, true) ?? Array.Empty<byte>();
                Assert.That(pristine, Is.Not.Empty, "Need a pristine palette export to corrupt.");

                foreach ((string label, byte[] corrupt) in RibbonDockingScaleTests.CorruptVariants(pristine))
                {
                    using var victim = new KryptonCustomPaletteBase();
                    try
                    {
                        victim.Import(corrupt, true);
                        outcomes.Add($"{label}: accepted (loader tolerated the damage)");
                    }
                    catch (Exception ex) when (!AttackHarness.IsDefectClass(ex))
                    {
                        outcomes.Add($"{label}: graceful {ex.GetType().Name}");
                    }
                    catch (Exception ex)
                    {
                        outcomes.Add($"{label}: DEFECT {ex.GetType().Name}");
                        collected.Add(new AttackFailure("palette-corrupt", "Import(byte[],silent:true)", label, ex));
                    }
                }
            }, timeoutMs: 300_000);

            TestContext.Out.WriteLine("Corruption outcomes:\n  " + string.Join("\n  ", outcomes));
            AttackHarness.AssertClean("palette-corruption", failures);
        }

        /// <summary>
        /// Workspace layout serialised from a live workspace, loaded into a completely fresh
        /// workspace (new control, new form), re-serialised: the persisted topology (cells,
        /// sequences, page unique names) must be identical.
        /// </summary>
        [Test]
        public void WorkspaceLayout_RoundTripsIntoFreshInstance()
        {
            List<AttackFailure> failures = AttackHarness.Run("workspace-fresh-roundtrip", collected =>
            {
                byte[]? saved = null;

                // Source workspace with a non-trivial topology.
                WithShownWorkspace(collected, workspace =>
                {
                    var cellA = new KryptonWorkspaceCell();
                    cellA.Pages.Add(NewPage("Alpha", 0));
                    cellA.Pages.Add(NewPage("Beta", 1));
                    var nested = new KryptonWorkspaceSequence(Orientation.Vertical);
                    var cellB = new KryptonWorkspaceCell();
                    cellB.Pages.Add(NewPage("Gamma", 2));
                    nested.Children!.Add(cellB);
                    workspace.Root.Children!.Add(cellA);
                    workspace.Root.Children!.Add(nested);
                    StaMessagePump.Pump(100);

                    saved = workspace.SaveLayoutToArray();
                });

                Assert.That(saved, Is.Not.Null.And.Not.Empty, "Workspace layout must serialise.");

                // Fresh workspace: load and re-save. Pages host arbitrary controls, so the
                // loader cannot resurrect them from XML by itself — by design a fresh
                // instance must supply each page through the RecreateLoadingPage event
                // (with no subscriber and no existing pages the loader skips the page and
                // the emptied cells are compacted away). The subscription below is the
                // documented consumer contract, not a workaround.
                byte[]? resaved = null;
                WithShownWorkspace(collected, workspace =>
                {
                    workspace.RecreateLoadingPage += (_, e) =>
                        e.Page = new KryptonPage { UniqueName = e.UniqueName };
                    workspace.LoadLayoutFromArray(saved!);
                    StaMessagePump.Pump(100);
                    resaved = workspace.SaveLayoutToArray();
                });

                Assert.That(resaved, Is.Not.Null.And.Not.Empty, "Reloaded workspace layout must serialise.");
                Assert.That(TopologySignature(resaved!), Is.EqualTo(TopologySignature(saved!)),
                    "Workspace topology changed when the layout was loaded into a fresh instance.");
            });

            AttackHarness.AssertClean("workspace-fresh-roundtrip", failures);
        }

        // ------------------------------------------------------------------ helpers

        private static void WithShownWorkspace(List<AttackFailure> failures, Action<KryptonWorkspace> action)
        {
            var host = new KryptonForm
            {
                StartPosition = FormStartPosition.Manual,
                Location = new Point(0, 0),
                ClientSize = new Size(800, 600),
                ShowInTaskbar = false,
                Text = "Bastion 5c workspace round-trip"
            };
            var workspace = new KryptonWorkspace { Dock = DockStyle.Fill };
            try
            {
                host.Controls.Add(workspace);
                host.Show();
                StaMessagePump.Pump(100);
                action(workspace);
            }
            catch (Exception ex) when (!(ex is AssertionException))
            {
                failures.Add(new AttackFailure("workspace-scenario", "build/run", "-", ex));
            }
            finally
            {
                workspace.Dispose();
                host.Dispose();
                StaMessagePump.Pump(60);
            }
        }

        private static KryptonPage NewPage(string title, int unique) =>
            new KryptonPage
            {
                Text = title,
                TextTitle = title,
                UniqueName = $"RtPage{unique}-{title}"
            };

        /// <summary>
        /// A structural signature of a workspace layout: the element tree of cells/sequences
        /// with page unique names, ignoring volatile attributes.
        /// </summary>
        private static string TopologySignature(byte[] unicodeXml)
        {
            var parts = new List<string>();
            using var reader = XmlReader.Create(new MemoryStream(unicodeXml));
            var depth = 0;
            while (reader.Read())
            {
                if (reader.NodeType == XmlNodeType.Element)
                {
                    depth = reader.Depth;
                    switch (reader.LocalName)
                    {
                        case "WC":
                            parts.Add($"{depth}:cell");
                            break;
                        case "WS":
                            parts.Add($"{depth}:seq");
                            break;
                        case "KP":
                            parts.Add($"{depth}:page={reader.GetAttribute("UN")}");
                            break;
                    }
                }
            }

            return string.Join("|", parts);
        }

        /// <summary>Decodes a palette export and strips volatile metadata attributes (dates).</summary>
        private static string NormalisePaletteXml(byte[] exported)
        {
            var document = new XmlDocument();
            using (var stream = new MemoryStream(exported))
            {
                document.Load(stream);
            }

            foreach (XmlElement element in document.SelectNodes("//*")!.OfType<XmlElement>())
            {
                foreach (string volatileAttribute in new[] { "Date", "Generated", "DateCreated" })
                {
                    if (element.HasAttribute(volatileAttribute))
                    {
                        element.RemoveAttribute(volatileAttribute);
                    }
                }
            }

            return document.OuterXml;
        }
    }
}
