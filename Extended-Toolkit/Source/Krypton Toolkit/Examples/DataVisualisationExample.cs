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
namespace Examples
{
    /// <summary>Demonstrates the Data.Visualisation module: a FormsPlot scatter and signal chart.</summary>
    public partial class DataVisualisationExample : KryptonForm
    {
        public DataVisualisationExample()
        {
            InitializeComponent();
        }

        private void DataVisualisationExample_Load(object sender, EventArgs e)
        {
            const int pointCount = 100;

            double[] xs = new double[pointCount];

            double[] sine = new double[pointCount];

            double[] cosine = new double[pointCount];

            for (int i = 0; i < pointCount; i++)
            {
                xs[i] = i * 0.1;

                sine[i] = Math.Sin(xs[i]);

                cosine[i] = Math.Cos(xs[i]);
            }

            formsPlot.Plot.Add.Scatter(xs, sine);

            formsPlot.Plot.Add.Scatter(xs, cosine);

            formsPlot.Refresh();
        }
    }
}
