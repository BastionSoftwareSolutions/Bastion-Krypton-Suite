#region MIT License

/*
 * MIT License
 *
 * © Bastion Software Solutions Ltd. New file for the Bastion Krypton Suite,
 * a derived work from the MIT-licensed Krypton Toolkit Suite Extended
 * (Copyright (c) 2017 - 2024 Krypton Suite).
 *
 * Permission is hereby granted, free of charge, to any person obtaining a copy
 * of this software and associated documentation files (the "Software"), to deal
 * in the Software without restriction, including without limitation the rights
 * to use, copy, modify, merge, publish, distribute, sublicense, and/or sell
 * copies of the Software, and to permit persons to whom the Software is
 * furnished to do so, subject to the following conditions:
 *
 * The above copyright notice and this permission notice shall be included in all
 * copies or substantial portions of the Software.
 *
 * THE SOFTWARE IS PROVIDED "AS IS", WITHOUT WARRANTY OF ANY KIND, EXPRESS OR
 * IMPLIED, INCLUDING BUT NOT LIMITED TO THE WARRANTIES OF MERCHANTABILITY,
 * FITNESS FOR A PARTICULAR PURPOSE AND NONINFRINGEMENT. IN NO EVENT SHALL THE
 * AUTHORS OR COPYRIGHT HOLDERS BE LIABLE FOR ANY CLAIM, DAMAGES OR OTHER
 * LIABILITY, WHETHER IN AN ACTION OF CONTRACT, TORT OR OTHERWISE, ARISING FROM,
 * OUT OF OR IN CONNECTION WITH THE SOFTWARE OR THE USE OR OTHER DEALINGS IN THE
 * SOFTWARE.
 *
 */

#endregion
using Krypton.Toolkit.Suite.Extended.Outlook.Grid;

namespace Examples
{
    /// <summary>Demonstrates the Outlook.Grid module: a grouped KryptonOutlookGrid with its drag-to-group box.</summary>
    public partial class OutlookGridExample : KryptonForm
    {
        public OutlookGridExample()
        {
            InitializeComponent();
        }

        private void OutlookGridExample_Load(object sender, EventArgs e)
        {
            kogGrid.GroupBox = kogbGroupBox;

            kogGrid.HideColumnOnGrouping = false;

            kogGrid.ShowLines = true;

            var colCategory = new KryptonDataGridViewTextBoxColumn { Name = "Category", HeaderText = "Category", SortMode = DataGridViewColumnSortMode.Programmatic, Width = 120 };

            var colTask = new KryptonDataGridViewTextBoxColumn { Name = "Task", HeaderText = "Task", SortMode = DataGridViewColumnSortMode.Programmatic, Width = 260 };

            var colAssignee = new KryptonDataGridViewTextBoxColumn { Name = "Assignee", HeaderText = "Assignee", SortMode = DataGridViewColumnSortMode.Programmatic, Width = 110 };

            var colDueDate = new KryptonDataGridViewTextBoxColumn { Name = "DueDate", HeaderText = "Due Date", SortMode = DataGridViewColumnSortMode.Programmatic, Width = 110 };

            kogGrid.Columns.AddRange(new DataGridViewColumn[] { colCategory, colTask, colAssignee, colDueDate });

            kogGrid.AddInternalColumn(colCategory, new OutlookGridDefaultGroup(null), SortOrder.None, -1, -1);

            kogGrid.AddInternalColumn(colTask, new OutlookGridDefaultGroup(null), SortOrder.None, -1, -1);

            kogGrid.AddInternalColumn(colAssignee, new OutlookGridAlphabeticGroup(null), SortOrder.None, -1, -1);

            kogGrid.AddInternalColumn(colDueDate, new OutlookGridDateTimeGroup(null), SortOrder.None, -1, -1);

            var rows = new List<OutlookGridRow>();

            AddRow(rows, "Documentation", "Write the theming guide", "Alice", new DateTime(2026, 8, 3));

            AddRow(rows, "Documentation", "Update the API reference", "Bob", new DateTime(2026, 8, 10));

            AddRow(rows, "Development", "Port the wizard control", "Carol", new DateTime(2026, 7, 24));

            AddRow(rows, "Development", "Fix the docking splitter", "Alice", new DateTime(2026, 7, 31));

            AddRow(rows, "Development", "Add dark mode palettes", "Dan", new DateTime(2026, 9, 1));

            AddRow(rows, "Testing", "Smoke test the samples", "Bob", new DateTime(2026, 7, 20));

            AddRow(rows, "Testing", "Stress test the grids", "Carol", new DateTime(2026, 8, 17));

            kogGrid.AssignRows(rows);

            kogGrid.RegisterGroupBoxEvents();

            // Group by category, then rebuild the grid and the group box display.
            kogGrid.GroupColumn("Category", SortOrder.Ascending, null);

            kogGrid.ForceRefreshGroupBox();

            kogGrid.Fill();
        }

        private void AddRow(List<OutlookGridRow> rows, string category, string task, string assignee, DateTime dueDate)
        {
            var row = new OutlookGridRow();

            row.CreateCells(kogGrid, category, task, assignee, dueDate);

            rows.Add(row);
        }
    }
}
