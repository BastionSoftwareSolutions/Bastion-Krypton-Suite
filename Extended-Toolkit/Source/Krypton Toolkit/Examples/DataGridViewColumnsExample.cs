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
using Krypton.Toolkit.Suite.Extended.DataGridView;

namespace Examples
{
    /// <summary>Demonstrates the DataGridView module: the specialised percentage, rating, token and text-and-image columns.</summary>
    public partial class DataGridViewColumnsExample : KryptonForm
    {
        public DataGridViewColumnsExample()
        {
            InitializeComponent();
        }

        private void DataGridViewColumnsExample_Load(object sender, EventArgs e)
        {
            Image ownerImage = SystemIcons.Information.ToBitmap();

            kdgvColumns.Rows.Add("Design the landing page", 0.85, 9,
                new Token("High", Color.Firebrick, Color.White), new TextAndImage("Alice", ownerImage));

            kdgvColumns.Rows.Add("Write the user guide", 0.4, 6,
                new Token("Medium", Color.DarkOrange, Color.White), new TextAndImage("Bob", ownerImage));

            kdgvColumns.Rows.Add("Tidy the backlog", 0.1, 3,
                new Token("Low", Color.SeaGreen, Color.White), new TextAndImage("Carol", ownerImage));
        }
    }
}
