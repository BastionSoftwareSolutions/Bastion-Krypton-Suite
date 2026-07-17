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
    partial class FileCopierExample
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
            this.kflListing = new Krypton.Toolkit.Suite.Extended.File.Copier.KryptonFileListing();
            this.kbtnFileCopier = new Krypton.Toolkit.KryptonButton();
            this.kbtnFileMonitor = new Krypton.Toolkit.KryptonButton();
            ((System.ComponentModel.ISupportInitialize)(this.kryptonPanel1)).BeginInit();
            this.kryptonPanel1.SuspendLayout();
            this.SuspendLayout();
            //
            // kryptonPanel1
            //
            this.kryptonPanel1.Controls.Add(this.kflListing);
            this.kryptonPanel1.Controls.Add(this.kbtnFileCopier);
            this.kryptonPanel1.Controls.Add(this.kbtnFileMonitor);
            this.kryptonPanel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.kryptonPanel1.Location = new System.Drawing.Point(0, 0);
            this.kryptonPanel1.Name = "kryptonPanel1";
            this.kryptonPanel1.Size = new System.Drawing.Size(554, 351);
            this.kryptonPanel1.TabIndex = 0;
            //
            // kflListing
            //
            this.kflListing.Location = new System.Drawing.Point(13, 13);
            this.kflListing.Name = "kflListing";
            this.kflListing.PromptText = "Choose a directory to list its files";
            this.kflListing.Size = new System.Drawing.Size(528, 280);
            this.kflListing.TabIndex = 0;
            //
            // kbtnFileCopier
            //
            this.kbtnFileCopier.Location = new System.Drawing.Point(13, 306);
            this.kbtnFileCopier.Name = "kbtnFileCopier";
            this.kbtnFileCopier.Size = new System.Drawing.Size(180, 25);
            this.kbtnFileCopier.TabIndex = 1;
            this.kbtnFileCopier.Values.Text = "Open File Copier";
            this.kbtnFileCopier.Click += new System.EventHandler(this.kbtnFileCopier_Click);
            //
            // kbtnFileMonitor
            //
            this.kbtnFileMonitor.Location = new System.Drawing.Point(211, 306);
            this.kbtnFileMonitor.Name = "kbtnFileMonitor";
            this.kbtnFileMonitor.Size = new System.Drawing.Size(180, 25);
            this.kbtnFileMonitor.TabIndex = 2;
            this.kbtnFileMonitor.Values.Text = "Open File Monitor";
            this.kbtnFileMonitor.Click += new System.EventHandler(this.kbtnFileMonitor_Click);
            //
            // FileCopierExample
            //
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(554, 351);
            this.Controls.Add(this.kryptonPanel1);
            this.Name = "FileCopierExample";
            this.Text = "File Copier Example";
            ((System.ComponentModel.ISupportInitialize)(this.kryptonPanel1)).EndInit();
            this.kryptonPanel1.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private Krypton.Toolkit.KryptonPanel kryptonPanel1;
        private Krypton.Toolkit.Suite.Extended.File.Copier.KryptonFileListing kflListing;
        private Krypton.Toolkit.KryptonButton kbtnFileCopier;
        private Krypton.Toolkit.KryptonButton kbtnFileMonitor;
    }
}
