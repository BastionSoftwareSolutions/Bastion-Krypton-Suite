#region BSD License
/*
 * New (Bastion) file in a work derived from BSD-3-Clause licensed code:
 * © Component Factory Pty Ltd, 2006 - 2016. Then modifications by Peter Wagner (aka Wagnerp),
 * Simon Coghlan (aka Smurf-IV), Giduac, Ahmed Abdelhameed, Lesandro & tobitege et al. 2017 - 2026.
 * © Bastion Software Solutions Ltd 2026. All rights reserved.
 */
#endregion

// Extended-module attacks: net48 + net8.0-windows only (scope note in Tests\README.md).
#if BASTION_EXTENDED

using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Drawing;
using System.Windows.Forms;

using Bastion.Krypton.UnitTests.Infrastructure;

using Krypton.Toolkit;

using Krypton.Toolkit.Suite.Extended.DataGridView;

using Krypton.Toolkit.Suite.Extended.TreeGridView;

using NUnit.Framework;

namespace Bastion.Krypton.StressTests.Extended
{
    /// <summary>
    /// Spec §6.3 attack 7 (v1.1) — KryptonTreeGridView with bulk nested nodes plus
    /// expand/collapse churn, and the DataGridView module's speciality cell types
    /// (rating/percentage) under bulk rows, sort churn and mutation during paint.
    /// (The module's Master/Detail composite views require designer-bound master-detail
    /// DataSets; the cell-type torture below is the attack surface reachable headless.)
    /// </summary>
    [TestFixture]
    [Category("Adversarial")]
    public class ExtendedTreeAndDataGridTests : UiTestBase
    {
        // ------------------------------------------------------------------ tree grid view

        /// <summary>Default category: 10k nodes (1k parents × 9 children).</summary>
        [Test]
        public void TreeGridView_10kNodes_ExpandCollapseChurn() => RunTreeTorture(1_000, 9);

        /// <summary>Endurance: 100k nodes (2k parents × 49 children).</summary>
        [Test]
        [Category("Endurance")]
        public void TreeGridView_100kNodes_ExpandCollapseChurn() => RunTreeTorture(2_000, 49);

        private static void RunTreeTorture(int parents, int childrenPerParent)
        {
            int total = parents * (1 + childrenPerParent);
            var stopwatch = Stopwatch.StartNew();
            List<AttackFailure> failures = AttackHarness.Run("tree-grid", collected =>
            {
                var host = new KryptonForm
                {
                    StartPosition = FormStartPosition.Manual,
                    Location = new Point(0, 0),
                    ClientSize = new Size(900, 650),
                    ShowInTaskbar = false,
                    Text = $"Bastion 5c tree grid — {total} nodes"
                };
                var tree = new KryptonTreeGridView { Dock = DockStyle.Fill };
                try
                {
                    tree.Columns.Add(new KryptonTreeGridColumn { HeaderText = "Node", Name = "Node" });
                    tree.Columns.Add(new KryptonDataGridViewTextBoxColumn { HeaderText = "Value", Name = "Value" });

                    host.Controls.Add(tree);
                    host.Show();
                    StaMessagePump.Pump(100);

                    AttackHarness.Attack(collected, "tree-build", "GridNodes.Add", $"{total} nodes", () =>
                    {
                        for (var p = 0; p < parents; p++)
                        {
                            KryptonTreeGridNodeRow parent = tree.GridNodes.Add($"Parent {p:D5}", p)!;
                            for (var c = 0; c < childrenPerParent; c++)
                            {
                                parent.Nodes.Add($"Child {p:D5}.{c:D2}", c);
                            }
                        }

                        StaMessagePump.Pump(150);
                    });

                    AttackHarness.Attack(collected, "tree-churn", "ExpandAll/CollapseAll", "3 cycles", () =>
                    {
                        for (var cycle = 0; cycle < 3; cycle++)
                        {
                            tree.ExpandAll();
                            StaMessagePump.Pump(100);
                            tree.CollapseAll();
                            StaMessagePump.Pump(100);
                        }
                    });

                    AttackHarness.Attack(collected, "tree-mutate", "remove/insert while expanded", "-", () =>
                    {
                        tree.ExpandAll();
                        StaMessagePump.Pump(80);
                        tree.GridNodes.RemoveAt(0);
                        KryptonTreeGridNodeRow injected = tree.GridNodes.Add("Injected", -1)!;
                        injected.Nodes.Add("Injected child", -2);
                        StaMessagePump.Pump(80);
                    });
                }
                finally
                {
                    tree.Dispose();
                    host.Dispose();
                    StaMessagePump.Pump(60);
                }
            }, timeoutMs: total >= 100_000 ? 3_600_000 : 900_000);

            stopwatch.Stop();
            TestContext.Out.WriteLine($"Tree grid torture: {total} nodes in {stopwatch.Elapsed}.");
            AttackHarness.AssertClean("tree-grid", failures);
        }

        // ------------------------------------------------------------------ data grid module cells

        /// <summary>Default category: 10k rows over the module's speciality cell types.</summary>
        [Test]
        public void DataGridModuleCells_10kRows_SortChurnAndPaintMutation() => RunCellTorture(10_000);

        /// <summary>Endurance: the full 100k rows.</summary>
        [Test]
        [Category("Endurance")]
        public void DataGridModuleCells_100kRows_SortChurnAndPaintMutation() => RunCellTorture(100_000);

        private static void RunCellTorture(int rowCount)
        {
            var stopwatch = Stopwatch.StartNew();
            List<AttackFailure> failures = AttackHarness.Run("datagrid-module", collected =>
            {
                var host = new KryptonForm
                {
                    StartPosition = FormStartPosition.Manual,
                    Location = new Point(0, 0),
                    ClientSize = new Size(1000, 700),
                    ShowInTaskbar = false,
                    Text = $"Bastion 5c data grid module — {rowCount} rows"
                };
                var grid = new KryptonDataGridView { Dock = DockStyle.Fill, AllowUserToAddRows = false };
                try
                {
                    grid.Columns.Add(new KryptonDataGridViewTextBoxColumn { HeaderText = "Name", Name = "Name", SortMode = DataGridViewColumnSortMode.Automatic });
                    // Fully qualified: the core toolkit gained same-named column types, and the
                    // module's are the ones under attack here.
                    grid.Columns.Add(new global::Krypton.Toolkit.Suite.Extended.DataGridView.KryptonDataGridViewRatingColumn { HeaderText = "Rating", Name = "Rating" });
                    grid.Columns.Add(new global::Krypton.Toolkit.Suite.Extended.DataGridView.KryptonDataGridViewPercentageColumn { HeaderText = "Progress", Name = "Progress" });

                    host.Controls.Add(grid);
                    host.Show();
                    StaMessagePump.Pump(100);

                    AttackHarness.Attack(collected, "cells-build", "Rows.Add", $"{rowCount} rows", () =>
                    {
                        var buffer = new List<DataGridViewRow>(rowCount);
                        for (var i = 0; i < rowCount; i++)
                        {
                            var row = new DataGridViewRow();
                            row.CreateCells(grid, $"Row {i:D6}", i % 6, (i % 101) / 100.0);
                            buffer.Add(row);
                        }

                        grid.Rows.AddRange(buffer.ToArray());
                        StaMessagePump.Pump(150);
                    });

                    AttackHarness.Attack(collected, "cells-sort", "Sort Name asc/desc", "-", () =>
                    {
                        grid.Sort(grid.Columns["Name"]!, System.ComponentModel.ListSortDirection.Ascending);
                        StaMessagePump.Pump(100);
                        grid.Sort(grid.Columns["Name"]!, System.ComponentModel.ListSortDirection.Descending);
                        StaMessagePump.Pump(100);
                    });

                    var mutated = false;
                    grid.Paint += (_, _) =>
                    {
                        if (mutated)
                        {
                            return;
                        }

                        mutated = true;
                        AttackHarness.Attack(collected, "cells-mutate-during-paint", "Rows add/remove in Paint", "-", () =>
                        {
                            if (grid.Rows.Count > 10)
                            {
                                grid.Rows.RemoveAt(0);
                            }

                            var row = new DataGridViewRow();
                            row.CreateCells(grid, "Injected during paint", 3, 0.5);
                            grid.Rows.Add(row);
                        });
                    };
                    grid.Invalidate();
                    StaMessagePump.Pump(200);
                }
                finally
                {
                    grid.Dispose();
                    host.Dispose();
                    StaMessagePump.Pump(60);
                }
            }, timeoutMs: rowCount >= 100_000 ? 3_600_000 : 900_000);

            stopwatch.Stop();
            TestContext.Out.WriteLine($"Data grid module cell torture: {rowCount} rows in {stopwatch.Elapsed}.");
            AttackHarness.AssertClean("datagrid-module", failures);
        }
    }
}

#endif
