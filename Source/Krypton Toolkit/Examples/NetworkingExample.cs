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
using Krypton.Toolkit.Suite.Extended.Networking;

namespace Examples
{
    /// <summary>
    /// Demonstrates the Networking module. Each form is opened by an explicit click only,
    /// because several of them enumerate the network when they load.
    /// </summary>
    public partial class NetworkingExample : KryptonForm
    {
        public NetworkingExample()
        {
            InitializeComponent();
        }

        private void kbtnNetworkScanner_Click(object sender, EventArgs e)
        {
            new KryptonNetworkScanner().Show();
        }

        private void kbtnNodePicker_Click(object sender, EventArgs e)
        {
            new KryptonNetworkNodePicker().Show();
        }

        private void kbtnNodeViewer_Click(object sender, EventArgs e)
        {
            // Enumerates network nodes while loading; this can take a few seconds.
            new KryptonNodeViewer().Show();
        }

        private void kbtnNetworkUtility_Click(object sender, EventArgs e)
        {
            try
            {
                new KryptonNetworkUtility().Show();
            }
            catch (Exception exception)
            {
                // The utility requires at least one active network adapter.
                KryptonMessageBox.Show(this, exception.Message, "Network Utility", KryptonMessageBoxButtons.OK, KryptonMessageBoxIcon.Error);
            }
        }

        private void kbtnNetworkDriveOptions_Click(object sender, EventArgs e)
        {
            new KryptonNetworkDriveOptions(new NetworkUtilities().GetAvailableDriveLetters()).Show();
        }
    }
}
