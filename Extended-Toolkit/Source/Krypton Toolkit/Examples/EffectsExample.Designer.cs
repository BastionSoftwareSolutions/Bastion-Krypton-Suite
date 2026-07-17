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
    partial class EffectsExample
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.fadeManager = new Krypton.Toolkit.Suite.Extended.Effects.FadeManager();
            this.kryptonPanel1 = new Krypton.Toolkit.KryptonPanel();
            this.klblDescription = new Krypton.Toolkit.KryptonLabel();
            this.kbtnFadeOutAndIn = new Krypton.Toolkit.KryptonButton();
            this.kbtnFadeOutAndClose = new Krypton.Toolkit.KryptonButton();
            ((System.ComponentModel.ISupportInitialize)(this.kryptonPanel1)).BeginInit();
            this.kryptonPanel1.SuspendLayout();
            this.SuspendLayout();
            //
            // kryptonPanel1
            //
            this.kryptonPanel1.Controls.Add(this.klblDescription);
            this.kryptonPanel1.Controls.Add(this.kbtnFadeOutAndIn);
            this.kryptonPanel1.Controls.Add(this.kbtnFadeOutAndClose);
            this.kryptonPanel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.kryptonPanel1.Location = new System.Drawing.Point(0, 0);
            this.kryptonPanel1.Name = "kryptonPanel1";
            this.kryptonPanel1.Size = new System.Drawing.Size(404, 111);
            this.kryptonPanel1.TabIndex = 0;
            //
            // klblDescription
            //
            this.klblDescription.Location = new System.Drawing.Point(13, 13);
            this.klblDescription.Name = "klblDescription";
            this.klblDescription.Size = new System.Drawing.Size(280, 20);
            this.klblDescription.TabIndex = 0;
            this.klblDescription.Values.Text = "FadeManager fades this window in and out.";
            //
            // kbtnFadeOutAndIn
            //
            this.kbtnFadeOutAndIn.Location = new System.Drawing.Point(13, 52);
            this.kbtnFadeOutAndIn.Name = "kbtnFadeOutAndIn";
            this.kbtnFadeOutAndIn.Size = new System.Drawing.Size(180, 25);
            this.kbtnFadeOutAndIn.TabIndex = 1;
            this.kbtnFadeOutAndIn.Values.Text = "Fade Out, Then Back In";
            this.kbtnFadeOutAndIn.Click += new System.EventHandler(this.kbtnFadeOutAndIn_Click);
            //
            // kbtnFadeOutAndClose
            //
            this.kbtnFadeOutAndClose.Location = new System.Drawing.Point(211, 52);
            this.kbtnFadeOutAndClose.Name = "kbtnFadeOutAndClose";
            this.kbtnFadeOutAndClose.Size = new System.Drawing.Size(180, 25);
            this.kbtnFadeOutAndClose.TabIndex = 2;
            this.kbtnFadeOutAndClose.Values.Text = "Fade Out && Close";
            this.kbtnFadeOutAndClose.Click += new System.EventHandler(this.kbtnFadeOutAndClose_Click);
            //
            // EffectsExample
            //
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(404, 111);
            this.Controls.Add(this.kryptonPanel1);
            this.Name = "EffectsExample";
            this.Text = "Effects Example";
            this.Load += new System.EventHandler(this.EffectsExample_Load);
            ((System.ComponentModel.ISupportInitialize)(this.kryptonPanel1)).EndInit();
            this.kryptonPanel1.ResumeLayout(false);
            this.kryptonPanel1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private Krypton.Toolkit.Suite.Extended.Effects.FadeManager fadeManager;
        private Krypton.Toolkit.KryptonPanel kryptonPanel1;
        private Krypton.Toolkit.KryptonLabel klblDescription;
        private Krypton.Toolkit.KryptonButton kbtnFadeOutAndIn;
        private Krypton.Toolkit.KryptonButton kbtnFadeOutAndClose;
    }
}
