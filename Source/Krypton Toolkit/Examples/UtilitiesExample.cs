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
using Krypton.Toolkit.Suite.Extended.Utilities.System.Synthesis;

namespace Examples
{
    /// <summary>Demonstrates the Utilities module: the managed SAPI speech synthesis facade.</summary>
    public partial class UtilitiesExample : KryptonForm
    {
        private SpeechSynthesizer? _synthesizer;

        public UtilitiesExample()
        {
            InitializeComponent();
        }

        private void kbtnSpeak_Click(object sender, EventArgs e)
        {
            try
            {
                _synthesizer ??= new SpeechSynthesizer();

                _synthesizer.SpeakAsyncCancelAll();

                _synthesizer.SpeakAsync(ktxtSpeechText.Text);
            }
            catch (Exception exception)
            {
                // Speech requires an installed SAPI voice.
                KryptonMessageBox.Show(this, exception.Message, "Text To Speech", KryptonMessageBoxButtons.OK, KryptonMessageBoxIcon.Error);
            }
        }

        private void kbtnStop_Click(object sender, EventArgs e)
        {
            _synthesizer?.SpeakAsyncCancelAll();
        }

        private void UtilitiesExample_FormClosed(object sender, FormClosedEventArgs e)
        {
            _synthesizer?.Dispose();

            _synthesizer = null;
        }
    }
}
