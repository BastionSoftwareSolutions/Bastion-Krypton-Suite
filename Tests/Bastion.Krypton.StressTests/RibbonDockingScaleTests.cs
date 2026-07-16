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
using System.Text;
using System.Windows.Forms;
using System.Xml;

using Bastion.Krypton.UnitTests.Infrastructure;

using Krypton.Docking;

using Krypton.Navigator;

using Krypton.Ribbon;

using Krypton.Toolkit;

using Krypton.Workspace;

using NUnit.Framework;

namespace Bastion.Krypton.StressTests
{
    /// <summary>
    /// Spec §6.3 attack 6 — ribbon/docking scale: 300 ribbon tabs with groups, deeply nested
    /// docking/workspace layouts, docking + workspace layout-XML round-trips, and
    /// deliberately corrupted layout XML (truncated, wrong root, invalid attribute values,
    /// seeded random byte flips) which must fail gracefully — a catchable exception, never a
    /// crash or hang.
    /// </summary>
    [TestFixture]
    [Category("Adversarial")]
    public class RibbonDockingScaleTests : UiTestBase
    {
        /// <summary>Fixed seed for the byte-flip corruptions — reproducible by contract.</summary>
        private const int CorruptionSeed = 12345;

        // ------------------------------------------------------------------ ribbon scale

        /// <summary>300 ribbon tabs × groups on a live form; selection sweep; clean dispose.</summary>
        [Test]
        public void Ribbon_300TabsWithGroups_BuildsSelectsAndDisposes()
        {
            List<AttackFailure> failures = AttackHarness.Run("ribbon-scale", collected =>
            {
                var host = new KryptonForm
                {
                    StartPosition = FormStartPosition.Manual,
                    Location = new Point(0, 0),
                    ClientSize = new Size(1000, 600),
                    ShowInTaskbar = false,
                    Text = "Bastion 5c ribbon scale"
                };
                var ribbon = new KryptonRibbon();
                try
                {
                    for (var i = 0; i < 300; i++)
                    {
                        var tab = new KryptonRibbonTab { Text = $"Tab {i}" };
                        var group = new KryptonRibbonGroup { TextLine1 = $"Group {i}" };
                        var triple = new KryptonRibbonGroupTriple();
                        triple.Items!.Add(new KryptonRibbonGroupButton { TextLine1 = $"A{i}" });
                        triple.Items!.Add(new KryptonRibbonGroupButton { TextLine1 = $"B{i}" });
                        group.Items.Add(triple);
                        tab.Groups.Add(group);
                        ribbon.RibbonTabs.Add(tab);
                    }

                    host.Controls.Add(ribbon);
                    host.Show();
                    StaMessagePump.Pump(250);

                    // Selection sweep across the scale — first, last and strides between.
                    foreach (int index in new[] { 0, 299, 150, 25, 275, 75, 225 })
                    {
                        int captured = index;
                        AttackHarness.Attack(collected, "ribbon-select", "SelectedTab", $"index {captured}", () =>
                        {
                            ribbon.SelectedTab = ribbon.RibbonTabs[captured];
                            StaMessagePump.Pump(25);
                        });
                    }

                    AttackHarness.Attack(collected, "ribbon-minimize", "MinimizedMode", "toggle", () =>
                    {
                        ribbon.MinimizedMode = true;
                        StaMessagePump.Pump(40);
                        ribbon.MinimizedMode = false;
                        StaMessagePump.Pump(40);
                    });
                }
                finally
                {
                    ribbon.Dispose();
                    host.Dispose();
                    StaMessagePump.Pump(50);
                }
            }, timeoutMs: 300_000);

            AttackHarness.AssertClean("ribbon-scale", failures);
        }

        // ------------------------------------------------------------------ nested layouts

        /// <summary>Deeply nested workspace layout (12 sequence levels) shows and round-trips.</summary>
        [Test]
        public void Workspace_DeeplyNestedLayout_ShowsAndRoundTrips()
        {
            List<AttackFailure> failures = AttackHarness.Run("workspace-nesting", collected =>
            {
                var host = new KryptonForm
                {
                    StartPosition = FormStartPosition.Manual,
                    Location = new Point(0, 0),
                    ClientSize = new Size(900, 650),
                    ShowInTaskbar = false,
                    Text = "Bastion 5c nested workspace"
                };
                var workspace = new KryptonWorkspace { Dock = DockStyle.Fill };
                try
                {
                    // Build 12 nested sequences, alternating orientation, one cell + page each.
                    KryptonWorkspaceSequence parent = workspace.Root;
                    for (var depth = 0; depth < 12; depth++)
                    {
                        var cell = new KryptonWorkspaceCell();
                        cell.Pages.Add(NewPage($"Depth {depth}", depth));
                        parent.Children!.Add(cell);

                        var nested = new KryptonWorkspaceSequence(
                            depth % 2 == 0 ? Orientation.Vertical : Orientation.Horizontal);
                        parent.Children!.Add(nested);
                        parent = nested;
                    }

                    var leaf = new KryptonWorkspaceCell();
                    leaf.Pages.Add(NewPage("Leaf", 12));
                    parent.Children!.Add(leaf);

                    host.Controls.Add(workspace);
                    host.Show();
                    StaMessagePump.Pump(250);

                    byte[]? saved = null;
                    AttackHarness.Attack(collected, "workspace-save", "SaveLayoutToArray", "-",
                        () => saved = workspace.SaveLayoutToArray());
                    Assert.That(saved, Is.Not.Null.And.Not.Empty, "Nested workspace layout must serialise.");

                    AttackHarness.Attack(collected, "workspace-load", "LoadLayoutFromArray", "self round-trip", () =>
                    {
                        workspace.LoadLayoutFromArray(saved!);
                        StaMessagePump.Pump(150);
                    });

                    byte[]? resaved = null;
                    AttackHarness.Attack(collected, "workspace-resave", "SaveLayoutToArray", "-",
                        () => resaved = workspace.SaveLayoutToArray());

                    if (resaved != null)
                    {
                        Assert.That(CountElements(resaved, "WC"), Is.EqualTo(CountElements(saved!, "WC")),
                            "Cell count changed across the workspace layout round-trip.");
                        Assert.That(CountElements(resaved, "KP"), Is.EqualTo(CountElements(saved!, "KP")),
                            "Page count changed across the workspace layout round-trip.");
                    }
                }
                finally
                {
                    workspace.Dispose();
                    host.Dispose();
                    StaMessagePump.Pump(50);
                }
            }, timeoutMs: 300_000);

            AttackHarness.AssertClean("workspace-nesting", failures);
        }

        /// <summary>
        /// Docking layout with pages docked on all four edges, auto-hidden groups, floating
        /// window and workspace fillers — saved, re-loaded, re-saved; the page universe must
        /// survive the round-trip.
        /// </summary>
        [Test]
        public void Docking_ComplexLayout_ConfigRoundTrips()
        {
            List<AttackFailure> failures = AttackHarness.Run("docking-roundtrip", collected =>
            {
                RunDockingScenario(collected, (manager, _, _) =>
                {
                    byte[]? saved = null;
                    AttackHarness.Attack(collected, "docking-save", "SaveConfigToArray", "-",
                        () => saved = manager.SaveConfigToArray());
                    Assert.That(saved, Is.Not.Null.And.Not.Empty, "Docking config must serialise.");

                    AttackHarness.Attack(collected, "docking-load", "LoadConfigFromArray", "self round-trip", () =>
                    {
                        manager.LoadConfigFromArray(saved!);
                        StaMessagePump.Pump(200);
                    });

                    byte[]? resaved = null;
                    AttackHarness.Attack(collected, "docking-resave", "SaveConfigToArray", "-",
                        () => resaved = manager.SaveConfigToArray());

                    if (resaved != null)
                    {
                        List<string> beforeNames = PageNames(saved!);
                        List<string> afterNames = PageNames(resaved);
                        Assert.That(afterNames, Is.EquivalentTo(beforeNames),
                            "The set of persisted pages changed across the docking config round-trip.");
                    }
                });
            }, timeoutMs: 300_000);

            AttackHarness.AssertClean("docking-roundtrip", failures);
        }

        // ------------------------------------------------------------------ corrupted XML

        /// <summary>The §6.3.6 corruption battery for the docking config loader.</summary>
        [Test]
        public void Docking_CorruptedConfig_FailsGracefully()
        {
            var outcomes = new List<string>();
            List<AttackFailure> failures = AttackHarness.Run("docking-corruption", collected =>
            {
                byte[] pristine = Array.Empty<byte>();
                RunDockingScenario(collected, (manager, _, _) => pristine = manager.SaveConfigToArray());
                Assert.That(pristine, Is.Not.Empty, "Need a pristine config to corrupt.");

                foreach ((string label, byte[] corrupt) in CorruptVariants(pristine))
                {
                    string capturedLabel = label;
                    byte[] capturedBytes = corrupt;
                    RunDockingScenario(collected, (manager, _, _) =>
                    {
                        try
                        {
                            manager.LoadConfigFromArray(capturedBytes);
                            StaMessagePump.Pump(100);
                            outcomes.Add($"{capturedLabel}: accepted (loader tolerated the damage)");
                        }
                        catch (Exception ex) when (!AttackHarness.IsDefectClass(ex))
                        {
                            outcomes.Add($"{capturedLabel}: graceful {ex.GetType().Name}");
                        }
                        catch (Exception ex)
                        {
                            outcomes.Add($"{capturedLabel}: DEFECT {ex.GetType().Name}");
                            collected.Add(new AttackFailure("docking-corrupt", "LoadConfigFromArray", capturedLabel, ex));
                        }
                    });
                }
            }, timeoutMs: 600_000);

            TestContext.Out.WriteLine("Corruption outcomes:\n  " + string.Join("\n  ", outcomes));
            AttackHarness.AssertClean("docking-corruption", failures);
        }

        /// <summary>The §6.3.6 corruption battery for the workspace layout loader.</summary>
        [Test]
        public void Workspace_CorruptedLayout_FailsGracefully()
        {
            var outcomes = new List<string>();
            List<AttackFailure> failures = AttackHarness.Run("workspace-corruption", collected =>
            {
                byte[] pristine = Array.Empty<byte>();
                RunWorkspaceScenario(collected, workspace => pristine = workspace.SaveLayoutToArray());
                Assert.That(pristine, Is.Not.Empty, "Need a pristine layout to corrupt.");

                foreach ((string label, byte[] corrupt) in CorruptVariants(pristine))
                {
                    string capturedLabel = label;
                    byte[] capturedBytes = corrupt;
                    RunWorkspaceScenario(collected, workspace =>
                    {
                        try
                        {
                            workspace.LoadLayoutFromArray(capturedBytes);
                            StaMessagePump.Pump(100);
                            outcomes.Add($"{capturedLabel}: accepted (loader tolerated the damage)");
                        }
                        catch (Exception ex) when (!AttackHarness.IsDefectClass(ex))
                        {
                            outcomes.Add($"{capturedLabel}: graceful {ex.GetType().Name}");
                        }
                        catch (Exception ex)
                        {
                            outcomes.Add($"{capturedLabel}: DEFECT {ex.GetType().Name}");
                            collected.Add(new AttackFailure("workspace-corrupt", "LoadLayoutFromArray", capturedLabel, ex));
                        }
                    });
                }
            }, timeoutMs: 600_000);

            TestContext.Out.WriteLine("Corruption outcomes:\n  " + string.Join("\n  ", outcomes));
            AttackHarness.AssertClean("workspace-corruption", failures);
        }

        // ------------------------------------------------------------------ scenario builders

        /// <summary>
        /// Builds the standard docking scenario — panel-managed control, filler workspace,
        /// four docked edges, an auto-hidden group and workspace pages — and hands the live
        /// manager to the action, disposing everything afterwards.
        /// </summary>
        private static void RunDockingScenario(
            List<AttackFailure> failures,
            Action<KryptonDockingManager, KryptonForm, KryptonDockableWorkspace> action)
        {
            var host = new KryptonForm
            {
                StartPosition = FormStartPosition.Manual,
                Location = new Point(0, 0),
                ClientSize = new Size(1000, 700),
                ShowInTaskbar = false,
                Text = "Bastion 5c docking"
            };
            var workspace = new KryptonDockableWorkspace { Dock = DockStyle.Fill };
            var manager = new KryptonDockingManager();
            try
            {
                host.Controls.Add(workspace);
                host.Show();
                StaMessagePump.Pump(100);

                KryptonDockingWorkspace dockingWorkspace = manager.ManageWorkspace("Workspace", workspace);
                manager.ManageControl("Control", host, dockingWorkspace);
                manager.ManageFloating("Floating", host);

                manager.AddDockspace("Control", DockingEdge.Left, new[] { NewPage("Left A", 0), NewPage("Left B", 1) });
                manager.AddDockspace("Control", DockingEdge.Right, new[] { NewPage("Right A", 2) });
                manager.AddDockspace("Control", DockingEdge.Top, new[] { NewPage("Top A", 3) });
                manager.AddDockspace("Control", DockingEdge.Bottom, new[] { NewPage("Bottom A", 4) });
                manager.AddAutoHiddenGroup("Control", DockingEdge.Left, new[] { NewPage("Hidden A", 5) });
                manager.AddToWorkspace("Workspace", new[] { NewPage("Filler A", 6), NewPage("Filler B", 7) });
                StaMessagePump.Pump(200);

                action(manager, host, workspace);
            }
            catch (Exception ex) when (!(ex is AssertionException))
            {
                failures.Add(new AttackFailure("docking-scenario", "build/run", "-", ex));
            }
            finally
            {
                manager.Dispose();
                workspace.Dispose();
                host.Dispose();
                StaMessagePump.Pump(80);
            }
        }

        /// <summary>Builds a modest live workspace and hands it to the action.</summary>
        private static void RunWorkspaceScenario(List<AttackFailure> failures, Action<KryptonWorkspace> action)
        {
            var host = new KryptonForm
            {
                StartPosition = FormStartPosition.Manual,
                Location = new Point(0, 0),
                ClientSize = new Size(800, 600),
                ShowInTaskbar = false,
                Text = "Bastion 5c workspace"
            };
            var workspace = new KryptonWorkspace { Dock = DockStyle.Fill };
            try
            {
                var cellA = new KryptonWorkspaceCell();
                cellA.Pages.Add(NewPage("One", 0));
                cellA.Pages.Add(NewPage("Two", 1));
                var cellB = new KryptonWorkspaceCell();
                cellB.Pages.Add(NewPage("Three", 2));
                workspace.Root.Children!.Add(cellA);
                workspace.Root.Children!.Add(cellB);

                host.Controls.Add(workspace);
                host.Show();
                StaMessagePump.Pump(120);

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
                StaMessagePump.Pump(80);
            }
        }

        private static KryptonPage NewPage(string title, int unique) =>
            new KryptonPage
            {
                Text = title,
                TextTitle = title,
                UniqueName = $"Page{unique}-{title.Replace(" ", string.Empty)}"
            };

        // ------------------------------------------------------------------ corruption battery

        /// <summary>
        /// The §6.3.6 corruption variants: truncations, wrong root element, invalid attribute
        /// values, and ten seeded random byte flips (seed <see cref="CorruptionSeed"/>).
        /// </summary>
        internal static IEnumerable<(string Label, byte[] Bytes)> CorruptVariants(byte[] pristine)
        {
            // Truncations.
            yield return ("truncated-50%", pristine.Take(pristine.Length / 2).ToArray());
            yield return ("truncated-90%", pristine.Take(pristine.Length * 9 / 10).ToArray());
            yield return ("empty", Array.Empty<byte>());

            // Textual corruptions run on the decoded XML (the arrays are Unicode XML text).
            string text = Encoding.Unicode.GetString(pristine);

            string wrongRoot = ReplaceFirst(text, "<KD", "<XX");
            wrongRoot = ReplaceFirst(wrongRoot, "<KW", "<XX");
            yield return ("wrong-root", Encoding.Unicode.GetBytes(wrongRoot));

            yield return ("invalid-attribute-int", Encoding.Unicode.GetBytes(
                ReplaceFirst(text, "V=\"1\"", "V=\"NotANumber\"")));
            yield return ("invalid-attribute-size", Encoding.Unicode.GetBytes(
                CorruptFirstNumericAttribute(text)));
            yield return ("not-xml", Encoding.Unicode.GetBytes("This is not XML at all { ] >"));

            // Seeded random byte flips: 10 variants × 16 flips each, reproducible.
            var random = new Random(CorruptionSeed);
            for (var variant = 0; variant < 10; variant++)
            {
                var flipped = (byte[])pristine.Clone();
                for (var flip = 0; flip < 16; flip++)
                {
                    int offset = random.Next(flipped.Length);
                    flipped[offset] ^= (byte)(1 << random.Next(8));
                }

                yield return ($"byte-flip-{variant}", flipped);
            }
        }

        private static string ReplaceFirst(string text, string find, string replace)
        {
            int index = text.IndexOf(find, StringComparison.Ordinal);
            return index < 0 ? text : text.Substring(0, index) + replace + text.Substring(index + find.Length);
        }

        /// <summary>Replaces the first numeric attribute value found with a hostile value.</summary>
        private static string CorruptFirstNumericAttribute(string text)
        {
            for (var i = 0; i < text.Length - 3; i++)
            {
                if (text[i] == '=' && text[i + 1] == '"' && char.IsDigit(text[i + 2]))
                {
                    int end = text.IndexOf('"', i + 2);
                    if (end > 0)
                    {
                        return text.Substring(0, i + 2) + "-99999999999999999999" + text.Substring(end);
                    }
                }
            }

            return text;
        }

        // ------------------------------------------------------------------ XML helpers

        private static int CountElements(byte[] unicodeXml, string elementName)
        {
            var count = 0;
            using var reader = XmlReader.Create(new MemoryStream(unicodeXml));
            while (reader.Read())
            {
                if (reader.NodeType == XmlNodeType.Element &&
                    string.Equals(reader.LocalName, elementName, StringComparison.Ordinal))
                {
                    count++;
                }
            }

            return count;
        }

        /// <summary>Collects the persisted page unique names of a docking config array.</summary>
        private static List<string> PageNames(byte[] unicodeXml)
        {
            var names = new List<string>();
            using var reader = XmlReader.Create(new MemoryStream(unicodeXml));
            while (reader.Read())
            {
                if (reader.NodeType == XmlNodeType.Element && reader.LocalName == "KP")
                {
                    string? name = reader.GetAttribute("UN");
                    if (name != null)
                    {
                        names.Add(name);
                    }
                }
            }

            return names;
        }
    }
}
