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
using Krypton.Toolkit.Suite.Extended.Error.Reporting;

namespace Examples
{
    /// <summary>Demonstrates the Error.Reporting module: showing an exception report for a caught exception.</summary>
    public partial class ErrorReportingExample : KryptonForm
    {
        public ErrorReportingExample()
        {
            InitializeComponent();
        }

        private void kbtnShowReport_Click(object sender, EventArgs e)
        {
            try
            {
                ThrowDemonstrationException();
            }
            catch (Exception exception)
            {
                var reporter = new ExceptionReporter();

                // Display only — no mail is sent unless the user presses the email button.
                reporter.Show(exception);
            }
        }

        private static void ThrowDemonstrationException() =>
            throw new InvalidOperationException("This demonstration exception was thrown deliberately so that the exception report view has something to display.");
    }
}
