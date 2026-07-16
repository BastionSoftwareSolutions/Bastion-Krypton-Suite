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
    partial class OutlookGridExample
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
            this.kogbGroupBox = new Krypton.Toolkit.Suite.Extended.Outlook.Grid.KryptonOutlookGridGroupBox();
            this.kogGrid = new Krypton.Toolkit.Suite.Extended.Outlook.Grid.KryptonOutlookGrid();
            ((System.ComponentModel.ISupportInitialize)(this.kogGrid)).BeginInit();
            this.SuspendLayout();
            //
            // kogbGroupBox
            //
            this.kogbGroupBox.Dock = System.Windows.Forms.DockStyle.Top;
            this.kogbGroupBox.Location = new System.Drawing.Point(0, 0);
            this.kogbGroupBox.Name = "kogbGroupBox";
            this.kogbGroupBox.Size = new System.Drawing.Size(704, 46);
            this.kogbGroupBox.TabIndex = 0;
            //
            // kogGrid
            //
            this.kogGrid.Dock = System.Windows.Forms.DockStyle.Fill;
            this.kogGrid.Location = new System.Drawing.Point(0, 46);
            this.kogGrid.Name = "kogGrid";
            this.kogGrid.Size = new System.Drawing.Size(704, 365);
            this.kogGrid.TabIndex = 1;
            //
            // OutlookGridExample
            //
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(704, 411);
            this.Controls.Add(this.kogGrid);
            this.Controls.Add(this.kogbGroupBox);
            this.Name = "OutlookGridExample";
            this.Text = "Outlook Grid Example";
            this.Load += new System.EventHandler(this.OutlookGridExample_Load);
            ((System.ComponentModel.ISupportInitialize)(this.kogGrid)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private Krypton.Toolkit.Suite.Extended.Outlook.Grid.KryptonOutlookGridGroupBox kogbGroupBox;
        private Krypton.Toolkit.Suite.Extended.Outlook.Grid.KryptonOutlookGrid kogGrid;
    }
}
