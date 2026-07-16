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
using System.Linq;
using System.Windows.Forms;

using Bastion.Krypton.FunctionalTests;

using Bastion.Krypton.UnitTests.Infrastructure;

using Krypton.Toolkit;

using NUnit.Framework;

namespace Bastion.Krypton.StressTests
{
    /// <summary>
    /// Spec §6.3 attack 3 — theme-switch storm: one form hosting every instantiable hosted
    /// control of the five core assemblies, cycled through every concrete palette mode while
    /// being resized. Asserts: no paint exceptions, stable GDI/USER handle counts, and a
    /// bounded working set across GC.Collect cycles (fails when growth is monotonic across
    /// the last N samples and material in size).
    /// </summary>
    [TestFixture]
    [Category("Adversarial")]
    public class ThemeSwitchStormTests : UiTestBase
    {
        /// <summary>Working-set samples inspected for persistent monotonic growth.</summary>
        private const int LeakWindow = 10;

        /// <summary>Minimum net growth across the leak window treated as material (bytes).</summary>
        private const long LeakThresholdBytes = 24L * 1024 * 1024;

        /// <summary>Short storm in the default category: proves the machinery on every run.</summary>
        [Test]
        public void EveryControlForm_ThemeStorm_3Rounds() => RunStorm(rounds: 3);

        /// <summary>
        /// The spec §6.3.3 storm: every palette cycled while resizing, at the official
        /// endurance count of 25 rounds (1,550 palette switches). The spec's 100-round
        /// figure was reduced: one round costs ~25 s (net8) / ~55 s (net48) on the reference
        /// machine, so 100 rounds exceeds the net48 test watchdog itself; 25 rounds still
        /// exercises the 10-sample leak window 2.5x over. Decision recorded in Tests\README.md.
        /// </summary>
        [Test]
        [Category("Endurance")]
        public void EveryControlForm_ThemeStorm_25Rounds() => RunStorm(rounds: 25);

        private static void RunStorm(int rounds)
        {
            PaletteMode[] modes = AttackHarness.AllConcretePaletteModes;
            var workingSetSamples = new List<long>();
            var stopwatch = Stopwatch.StartNew();

            List<AttackFailure> failures = AttackHarness.Run("theme-storm", collected =>
            {
                using var manager = new KryptonManager();
                using KryptonForm host = CreateEveryControlForm(collected);
                host.Show();
                StaMessagePump.Pump(200);

                // Warm-up: one full palette cycle populates every per-palette static cache
                // (fonts, images, renderers) so the measured phase sees genuine growth only.
                foreach (PaletteMode mode in modes)
                {
                    SwitchPalette(manager, mode, collected);
                }

                CollectAndSettle();
                HandleSnapshot before = HandleCounter.Snapshot();

                for (var round = 0; round < rounds; round++)
                {
                    foreach (PaletteMode mode in modes)
                    {
                        SwitchPalette(manager, mode, collected);
                    }

                    // Resize while the storm runs (alternate growth/shrink).
                    Size size = (round & 1) == 0 ? new Size(1100, 760) : new Size(820, 560);
                    AttackHarness.Attack(collected, "storm-resize", "host.Size", size.ToString(), () =>
                    {
                        host.Size = size;
                        StaMessagePump.Pump(15);
                    });

                    CollectAndSettle();
                    workingSetSamples.Add(Process.GetCurrentProcess().WorkingSet64);
                }

                // Handle stability across the storm.
                try
                {
                    HandleCounter.AssertStable(before, gdiSlack: 96, userSlack: 48);
                }
                catch (AssertionException handleFailure)
                {
                    collected.Add(new AttackFailure("storm-handles", "GDI/USER", $"{rounds} rounds", handleFailure));
                }

                // Bounded working set: growth must not be persistently monotonic AND material
                // over the last N samples (one-off cache fills settle; genuine leaks keep
                // climbing every round despite the per-round full GC).
                if (workingSetSamples.Count >= LeakWindow)
                {
                    List<long> window = workingSetSamples.Skip(workingSetSamples.Count - LeakWindow).ToList();
                    bool monotonic = true;
                    for (var i = 1; i < window.Count; i++)
                    {
                        if (window[i] <= window[i - 1])
                        {
                            monotonic = false;
                            break;
                        }
                    }

                    long growth = window[window.Count - 1] - window[0];
                    if (monotonic && growth > LeakThresholdBytes)
                    {
                        collected.Add(new AttackFailure("storm-memory", "WorkingSet64",
                            $"last {LeakWindow} samples strictly increasing, +{growth / (1024 * 1024)} MB",
                            new InvalidOperationException(
                                $"Working set grew monotonically across the final {LeakWindow} GC-settled samples: " +
                                string.Join(" -> ", window.Select(static w => (w / (1024 * 1024)) + "MB")))));
                    }
                }
            }, timeoutMs: rounds >= 25 ? 3_600_000 : 600_000);

            stopwatch.Stop();
            TestContext.Out.WriteLine(
                $"Theme storm: {rounds} rounds x {modes.Length} palettes in {stopwatch.Elapsed}; " +
                $"working-set samples (MB): {string.Join(", ", workingSetSamples.Select(static w => w / (1024 * 1024)))}");

            AttackHarness.AssertClean("theme-storm", failures);
        }

        private static void SwitchPalette(KryptonManager manager, PaletteMode mode, List<AttackFailure> failures)
        {
            AttackHarness.Attack(failures, "storm-switch", "GlobalPaletteMode", mode.ToString(), () =>
            {
                manager.GlobalPaletteMode = mode;
                StaMessagePump.Pump(10);
            });
        }

        private static void CollectAndSettle()
        {
            GC.Collect();
            GC.WaitForPendingFinalizers();
            GC.Collect();
            StaMessagePump.Pump(10);
        }

        /// <summary>
        /// Builds the storm form: every instantiable hosted control of the five core
        /// assemblies placed in a grid (the spec's "form containing every control").
        /// Types that refuse instantiation or parenting are recorded as failures — the
        /// storm must genuinely host the full catalogue.
        /// </summary>
        private static KryptonForm CreateEveryControlForm(List<AttackFailure> failures)
        {
            var host = new KryptonForm
            {
                StartPosition = FormStartPosition.Manual,
                Location = new Point(0, 0),
                ClientSize = new Size(1000, 700),
                ShowInTaskbar = false,
                Text = "Bastion 5c theme storm — every hosted control",
                AutoScroll = true
            };

            const int CellWidth = 120;
            const int CellHeight = 48;
            const int Columns = 8;
            var index = 0;

            foreach (CoverageCatalogue.Entry entry in CoverageCatalogue.Entries
                         .Where(static e => e.Kind == SweepKind.HostedControl))
            {
                try
                {
                    var control = (Control)Activator.CreateInstance(entry.Type)!;
                    control.Location = new Point(4 + (index % Columns) * CellWidth, 4 + (index / Columns) * CellHeight);
                    control.Size = new Size(CellWidth - 8, CellHeight - 8);
                    host.Controls.Add(control);
                    index++;
                }
                catch (Exception ex)
                {
                    failures.Add(new AttackFailure("storm-build", entry.Type.Name, "-", ex));
                }
            }

            return host;
        }
    }
}
