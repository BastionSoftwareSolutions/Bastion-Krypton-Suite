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
using System.Diagnostics;
using System.Drawing;
using System.Windows.Forms;

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
    /// Spec §6.3 attack 9 — rapid create/show/dispose cycles per component family, asserting
    /// stable GDI/USER handle counts. The cycle count is parameterised: a 500-cycle smoke
    /// variant runs in the default (Adversarial) category; the 2,500-cycle variant is
    /// [Category("Endurance")] (the spec's 10,000 figure reduced — see EnduranceCycles).
    /// </summary>
    [TestFixture]
    [Category("Adversarial")]
    public class RapidCreateDestroyTests : UiTestBase
    {
        private const int SmokeCycles = 500;

        /// <summary>
        /// Official endurance count — reduced from the spec §6.3.9 figure of 10,000: at the
        /// measured 53–133 ms/cycle a 10,000-cycle run costs 9–22 minutes per family
        /// (≈55–85 minutes per TFM), disproportionate for the assertion power gained. At
        /// 2,500 cycles any leak of one handle per ~39 cycles still breaches the 64-handle
        /// slack (the ShadowManager leak this fixture found was 4 per cycle). Decision
        /// recorded in Tests\README.md.
        /// </summary>
        private const int EnduranceCycles = 2_500;

        private const int WarmupCycles = 25;

        /// <summary>One representative create/show/dispose scenario per component family.</summary>
        private static readonly (string Family, Func<Form> Factory)[] Families =
        {
            ("Toolkit", static () =>
            {
                var form = NewShellForm("Toolkit");
                form.Controls.Add(new KryptonButton { Text = "B", Location = new Point(4, 4) });
                form.Controls.Add(new KryptonTextBox { Text = "T", Location = new Point(4, 40) });
                form.Controls.Add(new KryptonPanel { Location = new Point(4, 76), Size = new Size(120, 40) });
                return form;
            }),
            ("Ribbon", static () =>
            {
                var form = NewShellForm("Ribbon");
                var ribbon = new KryptonRibbon();
                for (var i = 0; i < 3; i++)
                {
                    var tab = new KryptonRibbonTab { Text = $"Tab {i}" };
                    var group = new KryptonRibbonGroup();
                    var triple = new KryptonRibbonGroupTriple();
                    triple.Items!.Add(new KryptonRibbonGroupButton { TextLine1 = $"B{i}" });
                    group.Items.Add(triple);
                    tab.Groups.Add(group);
                    ribbon.RibbonTabs.Add(tab);
                }

                form.Controls.Add(ribbon);
                return form;
            }),
            ("Navigator", static () =>
            {
                var form = NewShellForm("Navigator");
                var navigator = new KryptonNavigator { Dock = DockStyle.Fill };
                for (var i = 0; i < 3; i++)
                {
                    navigator.Pages.Add(new KryptonPage { Text = $"Page {i}", UniqueName = $"Rapid{i}" });
                }

                form.Controls.Add(navigator);
                return form;
            }),
            ("Workspace", static () =>
            {
                var form = NewShellForm("Workspace");
                var workspace = new KryptonWorkspace { Dock = DockStyle.Fill };
                var cell = new KryptonWorkspaceCell();
                cell.Pages.Add(new KryptonPage { Text = "One", UniqueName = "RapidWs0" });
                workspace.Root.Children!.Add(cell);
                form.Controls.Add(workspace);
                return form;
            }),
            ("Docking", static () =>
            {
                var form = NewShellForm("Docking");
                var workspace = new KryptonDockableWorkspace { Dock = DockStyle.Fill };
                form.Controls.Add(workspace);
                var manager = new KryptonDockingManager();
                KryptonDockingWorkspace dockingWorkspace = manager.ManageWorkspace("Workspace", workspace);
                manager.ManageControl("Control", form, dockingWorkspace);
                manager.AddDockspace("Control", DockingEdge.Left,
                    new[] { new KryptonPage { Text = "Dock", UniqueName = "RapidDock0" } });
                // Tie the manager's lifetime to the form so each cycle disposes it.
                form.Disposed += (_, _) => manager.Dispose();
                return form;
            }),
        };

        /// <summary>Default-category smoke: 500 cycles per family.</summary>
        public static IEnumerable<TestCaseData> SmokeCases
        {
            get
            {
                foreach ((string family, Func<Form> factory) in Families)
                {
                    yield return new TestCaseData(family, factory, SmokeCycles)
                        .SetName($"RapidCycle.{family}.{SmokeCycles}");
                }
            }
        }

        /// <summary>Endurance: 2,500 cycles per family (reduced spec §6.3.9 figure — see above).</summary>
        public static IEnumerable<TestCaseData> EnduranceCases
        {
            get
            {
                foreach ((string family, Func<Form> factory) in Families)
                {
                    yield return new TestCaseData(family, factory, EnduranceCycles)
                        .SetName($"RapidCycle.Endurance.{family}.{EnduranceCycles}");
                }
            }
        }

        /// <summary>500-cycle smoke variant (default category).</summary>
        [TestCaseSource(nameof(SmokeCases))]
        public void Family_RapidCreateShowDispose_Smoke(string family, Func<Form> factory, int cycles) =>
            RunCycles(family, factory, cycles, timeoutMs: 900_000);

        /// <summary>The endurance variant (official reduced count, see EnduranceCycles).</summary>
        [TestCaseSource(nameof(EnduranceCases))]
        [Category("Endurance")]
        public void Family_RapidCreateShowDispose_Endurance(string family, Func<Form> factory, int cycles) =>
            RunCycles(family, factory, cycles, timeoutMs: 3_600_000);

        private static void RunCycles(string family, Func<Form> factory, int cycles, int timeoutMs)
        {
            var stopwatch = Stopwatch.StartNew();
            List<AttackFailure> failures = AttackHarness.Run(family, collected =>
            {
                // Warm-up cycles populate the toolkit's static caches.
                for (var i = 0; i < WarmupCycles; i++)
                {
                    OneCycle(factory);
                }

                GC.Collect();
                GC.WaitForPendingFinalizers();
                GC.Collect();
                StaMessagePump.Pump(50);
                HandleSnapshot before = HandleCounter.Snapshot();

                for (var i = 0; i < cycles; i++)
                {
                    try
                    {
                        OneCycle(factory);
                    }
                    catch (Exception ex)
                    {
                        collected.Add(new AttackFailure("cycle", family, $"cycle {i}", ex));
                        break; // One diagnosis is enough; do not spam identical failures.
                    }

                    if ((i & 63) == 0)
                    {
                        StaMessagePump.Pump(1); // Drain any queued messages periodically.
                    }
                }

                GC.Collect();
                GC.WaitForPendingFinalizers();
                GC.Collect();
                StaMessagePump.Pump(80);

                try
                {
                    HandleCounter.AssertStable(before, gdiSlack: 64, userSlack: 48);
                }
                catch (AssertionException handleFailure)
                {
                    collected.Add(new AttackFailure("cycle-handles", family, $"{cycles} cycles", handleFailure));
                }
            }, timeoutMs);

            stopwatch.Stop();
            TestContext.Out.WriteLine($"Rapid create/destroy [{family}]: {cycles} cycles in {stopwatch.Elapsed} " +
                                      $"({stopwatch.Elapsed.TotalMilliseconds / cycles:0.00} ms/cycle).");
            AttackHarness.AssertClean(family, failures);
        }

        private static void OneCycle(Func<Form> factory)
        {
            using (Form form = factory())
            {
                form.Show();
                form.Dispose();
            }
        }

        private static KryptonForm NewShellForm(string family) =>
            new KryptonForm
            {
                StartPosition = FormStartPosition.Manual,
                Location = new Point(0, 0),
                ClientSize = new Size(420, 300),
                ShowInTaskbar = false,
                Text = $"Bastion 5c rapid cycle — {family}"
            };
    }
}
