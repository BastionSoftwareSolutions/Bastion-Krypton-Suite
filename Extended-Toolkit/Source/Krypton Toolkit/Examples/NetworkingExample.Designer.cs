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
    partial class NetworkingExample
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
            this.kbtnNetworkScanner = new Krypton.Toolkit.KryptonButton();
            this.kbtnNodePicker = new Krypton.Toolkit.KryptonButton();
            this.kbtnNodeViewer = new Krypton.Toolkit.KryptonButton();
            this.kbtnNetworkUtility = new Krypton.Toolkit.KryptonButton();
            this.kbtnNetworkDriveOptions = new Krypton.Toolkit.KryptonButton();
            ((System.ComponentModel.ISupportInitialize)(this.kryptonPanel1)).BeginInit();
            this.kryptonPanel1.SuspendLayout();
            this.SuspendLayout();
            //
            // kryptonPanel1
            //
            this.kryptonPanel1.Controls.Add(this.kbtnNetworkScanner);
            this.kryptonPanel1.Controls.Add(this.kbtnNodePicker);
            this.kryptonPanel1.Controls.Add(this.kbtnNodeViewer);
            this.kryptonPanel1.Controls.Add(this.kbtnNetworkUtility);
            this.kryptonPanel1.Controls.Add(this.kbtnNetworkDriveOptions);
            this.kryptonPanel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.kryptonPanel1.Location = new System.Drawing.Point(0, 0);
            this.kryptonPanel1.Name = "kryptonPanel1";
            this.kryptonPanel1.Size = new System.Drawing.Size(404, 133);
            this.kryptonPanel1.TabIndex = 0;
            //
            // kbtnNetworkScanner
            //
            this.kbtnNetworkScanner.Location = new System.Drawing.Point(13, 13);
            this.kbtnNetworkScanner.Name = "kbtnNetworkScanner";
            this.kbtnNetworkScanner.Size = new System.Drawing.Size(180, 25);
            this.kbtnNetworkScanner.TabIndex = 0;
            this.kbtnNetworkScanner.Values.Text = "Network Scanner";
            this.kbtnNetworkScanner.Click += new System.EventHandler(this.kbtnNetworkScanner_Click);
            //
            // kbtnNodePicker
            //
            this.kbtnNodePicker.Location = new System.Drawing.Point(211, 13);
            this.kbtnNodePicker.Name = "kbtnNodePicker";
            this.kbtnNodePicker.Size = new System.Drawing.Size(180, 25);
            this.kbtnNodePicker.TabIndex = 1;
            this.kbtnNodePicker.Values.Text = "Network Node Picker";
            this.kbtnNodePicker.Click += new System.EventHandler(this.kbtnNodePicker_Click);
            //
            // kbtnNodeViewer
            //
            this.kbtnNodeViewer.Location = new System.Drawing.Point(13, 44);
            this.kbtnNodeViewer.Name = "kbtnNodeViewer";
            this.kbtnNodeViewer.Size = new System.Drawing.Size(180, 25);
            this.kbtnNodeViewer.TabIndex = 2;
            this.kbtnNodeViewer.Values.Text = "Node Viewer";
            this.kbtnNodeViewer.Click += new System.EventHandler(this.kbtnNodeViewer_Click);
            //
            // kbtnNetworkUtility
            //
            this.kbtnNetworkUtility.Location = new System.Drawing.Point(211, 44);
            this.kbtnNetworkUtility.Name = "kbtnNetworkUtility";
            this.kbtnNetworkUtility.Size = new System.Drawing.Size(180, 25);
            this.kbtnNetworkUtility.TabIndex = 3;
            this.kbtnNetworkUtility.Values.Text = "Network Utility";
            this.kbtnNetworkUtility.Click += new System.EventHandler(this.kbtnNetworkUtility_Click);
            //
            // kbtnNetworkDriveOptions
            //
            this.kbtnNetworkDriveOptions.Location = new System.Drawing.Point(13, 75);
            this.kbtnNetworkDriveOptions.Name = "kbtnNetworkDriveOptions";
            this.kbtnNetworkDriveOptions.Size = new System.Drawing.Size(180, 25);
            this.kbtnNetworkDriveOptions.TabIndex = 4;
            this.kbtnNetworkDriveOptions.Values.Text = "Network Drive Options";
            this.kbtnNetworkDriveOptions.Click += new System.EventHandler(this.kbtnNetworkDriveOptions_Click);
            //
            // NetworkingExample
            //
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(404, 133);
            this.Controls.Add(this.kryptonPanel1);
            this.Name = "NetworkingExample";
            this.Text = "Networking Examples";
            ((System.ComponentModel.ISupportInitialize)(this.kryptonPanel1)).EndInit();
            this.kryptonPanel1.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private Krypton.Toolkit.KryptonPanel kryptonPanel1;
        private Krypton.Toolkit.KryptonButton kbtnNetworkScanner;
        private Krypton.Toolkit.KryptonButton kbtnNodePicker;
        private Krypton.Toolkit.KryptonButton kbtnNodeViewer;
        private Krypton.Toolkit.KryptonButton kbtnNetworkUtility;
        private Krypton.Toolkit.KryptonButton kbtnNetworkDriveOptions;
    }
}
