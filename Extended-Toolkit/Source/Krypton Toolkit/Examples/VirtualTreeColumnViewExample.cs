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
using Krypton.Toolkit.Suite.Extended.VirtualTreeColumnView;

namespace Examples
{
    /// <summary>Demonstrates the VirtualTreeColumnView module: a multi-column virtual tree.</summary>
    public partial class VirtualTreeColumnViewExample : KryptonForm
    {
        public VirtualTreeColumnViewExample()
        {
            InitializeComponent();
        }

        private void VirtualTreeColumnViewExample_Load(object sender, EventArgs e)
        {
            kvtcvTree.Header.Columns.Add(new VirtualTreeColumn { Name = "Component", Width = 220 });

            kvtcvTree.Header.Columns.Add(new VirtualTreeColumn { Name = "Status", Width = 120 });

            kvtcvTree.Header.Columns.Add(new VirtualTreeColumn { Name = "Notes", Width = 160, Fill = true });

            // The control is virtual: cell text is supplied on demand from each node's Tag.
            kvtcvTree.OnGetRowNodeCellText = (node, columnIndex) =>
            {
                var cells = (string[])node.Tag;

                return columnIndex < cells.Length ? cells[columnIndex] : string.Empty;
            };

            kvtcvTree.BeginUpdate();

            var toolkit = kvtcvTree.Add(null, NodeAttachPlacement.AddChildLast, new[] { "Standard Toolkit", "Stable", "Core control set" });

            kvtcvTree.Add(toolkit, NodeAttachPlacement.AddChildLast, new[] { "KryptonButton", "Stable", "Push button" });

            kvtcvTree.Add(toolkit, NodeAttachPlacement.AddChildLast, new[] { "KryptonDataGridView", "Stable", "Data grid" });

            var extended = kvtcvTree.Add(null, NodeAttachPlacement.AddChildLast, new[] { "Extended Toolkit", "Stable", "Module libraries" });

            kvtcvTree.Add(extended, NodeAttachPlacement.AddChildLast, new[] { "Outlook Grid", "Stable", "Grouped grid" });

            kvtcvTree.Add(extended, NodeAttachPlacement.AddChildLast, new[] { "Wizard", "Stable", "Multi-page wizard" });

            kvtcvTree.EndUpdate();

            kvtcvTree.ExpandAll();
        }
    }
}
