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
    partial class DrawingUtilitiesExample
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
            this.cemManager = new Krypton.Toolkit.Suite.Extended.Drawing.Utilities.ColourEditorManager();
            this.kryptonPanel1 = new Krypton.Toolkit.KryptonPanel();
            this.ceEditor = new Krypton.Toolkit.Suite.Extended.Drawing.Utilities.ColourEditor();
            this.cwcWheel = new Krypton.Toolkit.Suite.Extended.Drawing.Utilities.ColourWheelControl();
            this.scpcPicker = new Krypton.Toolkit.Suite.Extended.Drawing.Utilities.ScreenColourPickerControl();
            this.klblPicker = new Krypton.Toolkit.KryptonLabel();
            this.kcbeColourButton = new Krypton.Toolkit.Suite.Extended.Drawing.Utilities.KryptonColourButtonExtended();
            this.kpnlPreview = new Krypton.Toolkit.KryptonPanel();
            ((System.ComponentModel.ISupportInitialize)(this.kryptonPanel1)).BeginInit();
            this.kryptonPanel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.kpnlPreview)).BeginInit();
            this.SuspendLayout();
            //
            // cemManager
            //
            this.cemManager.ColourEditor = this.ceEditor;
            this.cemManager.ColourWheel = this.cwcWheel;
            this.cemManager.ScreenColourPicker = this.scpcPicker;
            this.cemManager.ColourChanged += new System.EventHandler(this.cemManager_ColourChanged);
            //
            // kryptonPanel1
            //
            this.kryptonPanel1.Controls.Add(this.ceEditor);
            this.kryptonPanel1.Controls.Add(this.cwcWheel);
            this.kryptonPanel1.Controls.Add(this.scpcPicker);
            this.kryptonPanel1.Controls.Add(this.klblPicker);
            this.kryptonPanel1.Controls.Add(this.kcbeColourButton);
            this.kryptonPanel1.Controls.Add(this.kpnlPreview);
            this.kryptonPanel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.kryptonPanel1.Location = new System.Drawing.Point(0, 0);
            this.kryptonPanel1.Name = "kryptonPanel1";
            this.kryptonPanel1.Size = new System.Drawing.Size(684, 391);
            this.kryptonPanel1.TabIndex = 0;
            //
            // ceEditor
            //
            this.ceEditor.Location = new System.Drawing.Point(13, 13);
            this.ceEditor.Name = "ceEditor";
            this.ceEditor.Size = new System.Drawing.Size(261, 359);
            this.ceEditor.TabIndex = 0;
            //
            // cwcWheel
            //
            this.cwcWheel.Location = new System.Drawing.Point(290, 13);
            this.cwcWheel.Name = "cwcWheel";
            this.cwcWheel.Size = new System.Drawing.Size(170, 160);
            this.cwcWheel.TabIndex = 1;
            //
            // scpcPicker
            //
            this.scpcPicker.Location = new System.Drawing.Point(290, 205);
            this.scpcPicker.Name = "scpcPicker";
            this.scpcPicker.Size = new System.Drawing.Size(170, 130);
            this.scpcPicker.TabIndex = 2;
            //
            // klblPicker
            //
            this.klblPicker.Location = new System.Drawing.Point(290, 179);
            this.klblPicker.Name = "klblPicker";
            this.klblPicker.Size = new System.Drawing.Size(180, 20);
            this.klblPicker.TabIndex = 3;
            this.klblPicker.Values.Text = "Drag from here to pick a colour:";
            //
            // kcbeColourButton
            //
            this.kcbeColourButton.Location = new System.Drawing.Point(480, 13);
            this.kcbeColourButton.Name = "kcbeColourButton";
            this.kcbeColourButton.Size = new System.Drawing.Size(190, 25);
            this.kcbeColourButton.TabIndex = 4;
            this.kcbeColourButton.Values.Text = "Colour Button";
            //
            // kpnlPreview
            //
            this.kpnlPreview.Location = new System.Drawing.Point(480, 52);
            this.kpnlPreview.Name = "kpnlPreview";
            this.kpnlPreview.Size = new System.Drawing.Size(190, 80);
            this.kpnlPreview.TabIndex = 5;
            //
            // DrawingUtilitiesExample
            //
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(684, 391);
            this.Controls.Add(this.kryptonPanel1);
            this.Name = "DrawingUtilitiesExample";
            this.Text = "Drawing Utilities Example";
            ((System.ComponentModel.ISupportInitialize)(this.kryptonPanel1)).EndInit();
            this.kryptonPanel1.ResumeLayout(false);
            this.kryptonPanel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.kpnlPreview)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private Krypton.Toolkit.Suite.Extended.Drawing.Utilities.ColourEditorManager cemManager;
        private Krypton.Toolkit.KryptonPanel kryptonPanel1;
        private Krypton.Toolkit.Suite.Extended.Drawing.Utilities.ColourEditor ceEditor;
        private Krypton.Toolkit.Suite.Extended.Drawing.Utilities.ColourWheelControl cwcWheel;
        private Krypton.Toolkit.Suite.Extended.Drawing.Utilities.ScreenColourPickerControl scpcPicker;
        private Krypton.Toolkit.KryptonLabel klblPicker;
        private Krypton.Toolkit.Suite.Extended.Drawing.Utilities.KryptonColourButtonExtended kcbeColourButton;
        private Krypton.Toolkit.KryptonPanel kpnlPreview;
    }
}
