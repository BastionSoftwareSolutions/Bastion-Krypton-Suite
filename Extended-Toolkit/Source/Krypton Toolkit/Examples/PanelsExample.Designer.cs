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
    partial class PanelsExample
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
            this.kryptonPanel1 = new Krypton.Toolkit.KryptonPanel();
            this.kpeRounded = new Krypton.Toolkit.Suite.Extended.Panels.KryptonPanelExtended();
            this.klblRounded = new Krypton.Toolkit.KryptonLabel();
            this.kbpButtonPanel = new Krypton.Toolkit.Suite.Extended.Panels.KryptonButtonPanel();
            this.kbtnOk = new Krypton.Toolkit.KryptonButton();
            this.kbtnCancel = new Krypton.Toolkit.KryptonButton();
            ((System.ComponentModel.ISupportInitialize)(this.kryptonPanel1)).BeginInit();
            this.kryptonPanel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.kpeRounded)).BeginInit();
            this.kpeRounded.SuspendLayout();
            this.kbpButtonPanel.SuspendLayout();
            this.SuspendLayout();
            //
            // kryptonPanel1
            //
            this.kryptonPanel1.Controls.Add(this.kpeRounded);
            this.kryptonPanel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.kryptonPanel1.Location = new System.Drawing.Point(0, 0);
            this.kryptonPanel1.Name = "kryptonPanel1";
            this.kryptonPanel1.Size = new System.Drawing.Size(484, 161);
            this.kryptonPanel1.TabIndex = 1;
            //
            // kpeRounded
            //
            this.kpeRounded.BorderColour = System.Drawing.Color.SteelBlue;
            this.kpeRounded.CornerRadius = 16;
            this.kpeRounded.Controls.Add(this.klblRounded);
            this.kpeRounded.Location = new System.Drawing.Point(13, 13);
            this.kpeRounded.Name = "kpeRounded";
            this.kpeRounded.PanelBackStyle = Krypton.Toolkit.PaletteBackStyle.PanelAlternate;
            this.kpeRounded.Size = new System.Drawing.Size(458, 90);
            this.kpeRounded.TabIndex = 0;
            //
            // klblRounded
            //
            this.klblRounded.Location = new System.Drawing.Point(24, 34);
            this.klblRounded.Name = "klblRounded";
            this.klblRounded.Size = new System.Drawing.Size(320, 20);
            this.klblRounded.TabIndex = 0;
            this.klblRounded.Values.Text = "KryptonPanelExtended with a 16px rounded corner border.";
            //
            // kbpButtonPanel
            //
            this.kbpButtonPanel.Controls.Add(this.kbtnOk);
            this.kbpButtonPanel.Controls.Add(this.kbtnCancel);
            this.kbpButtonPanel.Controls.SetChildIndex(this.kbtnCancel, 0);
            this.kbpButtonPanel.Controls.SetChildIndex(this.kbtnOk, 0);
            this.kbpButtonPanel.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.kbpButtonPanel.Location = new System.Drawing.Point(0, 111);
            this.kbpButtonPanel.Name = "kbpButtonPanel";
            this.kbpButtonPanel.Size = new System.Drawing.Size(484, 50);
            this.kbpButtonPanel.TabIndex = 0;
            //
            // kbtnOk
            //
            this.kbtnOk.Location = new System.Drawing.Point(287, 14);
            this.kbtnOk.Name = "kbtnOk";
            this.kbtnOk.Size = new System.Drawing.Size(90, 25);
            this.kbtnOk.TabIndex = 0;
            this.kbtnOk.Values.Text = "OK";
            //
            // kbtnCancel
            //
            this.kbtnCancel.Location = new System.Drawing.Point(383, 14);
            this.kbtnCancel.Name = "kbtnCancel";
            this.kbtnCancel.Size = new System.Drawing.Size(90, 25);
            this.kbtnCancel.TabIndex = 1;
            this.kbtnCancel.Values.Text = "Cancel";
            //
            // PanelsExample
            //
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(484, 161);
            this.Controls.Add(this.kbpButtonPanel);
            this.Controls.Add(this.kryptonPanel1);
            this.Name = "PanelsExample";
            this.Text = "Panels Example";
            ((System.ComponentModel.ISupportInitialize)(this.kryptonPanel1)).EndInit();
            this.kryptonPanel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.kpeRounded)).EndInit();
            this.kpeRounded.ResumeLayout(false);
            this.kpeRounded.PerformLayout();
            this.kbpButtonPanel.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private Krypton.Toolkit.KryptonPanel kryptonPanel1;
        private Krypton.Toolkit.Suite.Extended.Panels.KryptonPanelExtended kpeRounded;
        private Krypton.Toolkit.KryptonLabel klblRounded;
        private Krypton.Toolkit.Suite.Extended.Panels.KryptonButtonPanel kbpButtonPanel;
        private Krypton.Toolkit.KryptonButton kbtnOk;
        private Krypton.Toolkit.KryptonButton kbtnCancel;
    }
}
