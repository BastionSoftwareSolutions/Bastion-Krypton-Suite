#region BSD License
/*
 * New (Bastion) file in a work derived from BSD-3-Clause licensed code:
 * © Component Factory Pty Ltd, 2006 - 2016. Then modifications by Peter Wagner (aka Wagnerp),
 * Simon Coghlan (aka Smurf-IV), Giduac, Ahmed Abdelhameed, Lesandro & tobitege et al. 2017 - 2026.
 * © Bastion Software Solutions Ltd 2026. All rights reserved.
 */
#endregion

// Extended-module attacks are compiled for net48 + net8.0-windows only (scoping decision
// recorded in Tests\README.md: the Extended Bin dependency closures — WindowsAPICodePack,
// per-TFM support assemblies — make an 11-TFM reference matrix disproportionate; net48 and
// net8.0-windows are the Framework/modern mainline pair the Extended smoke matrix targets).
#if BASTION_EXTENDED

using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Drawing;
using System.Windows.Forms;

using Bastion.Krypton.UnitTests.Infrastructure;

using Krypton.Toolkit;

using Krypton.Toolkit.Suite.Extended.Outlook.Grid;

using NUnit.Framework;

namespace Bastion.Krypton.StressTests.Extended
{
    /// <summary>
    /// Spec §6.3 attack 7 (v1.1) — KryptonOutlookGrid at scale: bulk rows, grouping/
    /// ungrouping and sorting churn, and live row mutation during paint. 10k rows in the
    /// default category; the full 100k-row torture is [Category("Endurance")].
    /// </summary>
    [TestFixture]
    [Category("Adversarial")]
    public class ExtendedOutlookGridTests : UiTestBase
    {
        /// <summary>10k rows: scale smoke in the default category.</summary>
        [Test]
        public void OutlookGrid_10kRows_GroupingChurnAndPaintMutation() => RunGridTorture(10_000);

        /// <summary>The full spec figure: 100k rows with the same churn.</summary>
        [Test]
        [Category("Endurance")]
        public void OutlookGrid_100kRows_GroupingChurnAndPaintMutation() => RunGridTorture(100_000);

        private static void RunGridTorture(int rowCount)
        {
            var stopwatch = Stopwatch.StartNew();
            List<AttackFailure> failures = AttackHarness.Run("outlook-grid", collected =>
            {
                var host = new KryptonForm
                {
                    StartPosition = FormStartPosition.Manual,
                    Location = new Point(0, 0),
                    ClientSize = new Size(1000, 700),
                    ShowInTaskbar = false,
                    Text = $"Bastion 5c outlook grid — {rowCount} rows"
                };
                var grid = new KryptonOutlookGrid { Dock = DockStyle.Fill };
                try
                {
                    var colCategory = new KryptonDataGridViewTextBoxColumn
                    {
                        Name = "Category", HeaderText = "Category",
                        SortMode = DataGridViewColumnSortMode.Programmatic, Width = 120
                    };
                    var colName = new KryptonDataGridViewTextBoxColumn
                    {
                        Name = "Name", HeaderText = "Name",
                        SortMode = DataGridViewColumnSortMode.Programmatic, Width = 240
                    };
                    var colWhen = new KryptonDataGridViewTextBoxColumn
                    {
                        Name = "When", HeaderText = "When",
                        SortMode = DataGridViewColumnSortMode.Programmatic, Width = 120
                    };
                    grid.Columns.AddRange(new DataGridViewColumn[] { colCategory, colName, colWhen });
                    grid.AddInternalColumn(colCategory, new OutlookGridDefaultGroup(null), SortOrder.None, -1, -1);
                    grid.AddInternalColumn(colName, new OutlookGridAlphabeticGroup(null), SortOrder.None, -1, -1);
                    grid.AddInternalColumn(colWhen, new OutlookGridDateTimeGroup(null), SortOrder.None, -1, -1);

                    host.Controls.Add(grid);
                    host.Show();
                    StaMessagePump.Pump(100);

                    List<OutlookGridRow> rows = BuildRows(grid, rowCount);
                    AttackHarness.Attack(collected, "grid-assign", "AssignRows+Fill", $"{rowCount} rows", () =>
                    {
                        grid.AssignRows(rows);
                        grid.Fill();
                        StaMessagePump.Pump(150);
                    });

                    // Grouping churn across all three group kinds, then ungroup.
                    foreach (string column in new[] { "Category", "Name", "When" })
                    {
                        string captured = column;
                        AttackHarness.Attack(collected, "grid-group", "GroupColumn", captured, () =>
                        {
                            grid.GroupColumn(captured, SortOrder.Ascending, null);
                            grid.Fill();
                            StaMessagePump.Pump(100);
                        });
                        AttackHarness.Attack(collected, "grid-collapse", "CollapseAll/ExpandAll", captured, () =>
                        {
                            grid.CollapseAll();
                            StaMessagePump.Pump(50);
                            grid.ExpandAll();
                            StaMessagePump.Pump(50);
                        });
                        AttackHarness.Attack(collected, "grid-ungroup", "UnGroupColumn", captured, () =>
                        {
                            grid.UnGroupColumn(captured);
                            grid.Fill();
                            StaMessagePump.Pump(100);
                        });
                    }

                    // Sorting churn.
                    AttackHarness.Attack(collected, "grid-sort", "SortColumn", "Name asc/desc", () =>
                    {
                        OutlookGridColumn? sortable = grid.FindFromColumnName("Name");
                        if (sortable != null)
                        {
                            grid.SortColumn(sortable, SortOrder.Ascending);
                            grid.Fill();
                            StaMessagePump.Pump(80);
                            grid.SortColumn(sortable, SortOrder.Descending);
                            grid.Fill();
                            StaMessagePump.Pump(80);
                        }
                    });

                    // Live mutation during paint: on the next paint of the grid, rows are
                    // removed and added from inside the Paint event.
                    var mutated = false;
                    grid.Paint += (_, _) =>
                    {
                        if (mutated)
                        {
                            return;
                        }

                        mutated = true;
                        AttackHarness.Attack(collected, "grid-mutate-during-paint", "Rows add/remove in Paint", "-", () =>
                        {
                            if (grid.Rows.Count > 10)
                            {
                                grid.Rows.RemoveAt(0);
                                grid.Rows.RemoveAt(grid.Rows.Count - 1);
                            }

                            var row = new OutlookGridRow();
                            row.CreateCells(grid, "Mutated", "Injected during paint", DateTime.Today);
                            grid.Rows.Add(row);
                        });
                    };
                    grid.Invalidate();
                    StaMessagePump.Pump(200);

                    if (!mutated)
                    {
                        grid.Refresh();
                        StaMessagePump.Pump(100);
                    }
                }
                finally
                {
                    grid.Dispose();
                    host.Dispose();
                    StaMessagePump.Pump(60);
                }
            }, timeoutMs: rowCount >= 100_000 ? 3_600_000 : 900_000);

            stopwatch.Stop();
            TestContext.Out.WriteLine($"Outlook grid torture: {rowCount} rows in {stopwatch.Elapsed}.");
            AttackHarness.AssertClean("outlook-grid", failures);
        }

        private static List<OutlookGridRow> BuildRows(KryptonOutlookGrid grid, int count)
        {
            string[] categories = { "Red", "Green", "Blue", "Amber", "Violet" };
            var baseDate = new DateTime(2026, 1, 1);
            var rows = new List<OutlookGridRow>(count);
            for (var i = 0; i < count; i++)
            {
                var row = new OutlookGridRow();
                row.CreateCells(grid, categories[i % categories.Length], $"Item {i:D6}", baseDate.AddDays(i % 365));
                rows.Add(row);
            }

            return rows;
        }
    }
}

#endif
