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
    partial class ComboBoxExample
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
            this.klblComboBoxTree = new Krypton.Toolkit.KryptonLabel();
            this.kcbtNavigation = new Krypton.Toolkit.Suite.Extended.ComboBox.KryptonComboBoxTree();
            this.klblEnumerationComboBox = new Krypton.Toolkit.KryptonLabel();
            this.kecbDayOfWeek = new Krypton.Toolkit.Suite.Extended.ComboBox.KryptonEnumerationComboBox();
            ((System.ComponentModel.ISupportInitialize)(this.kryptonPanel1)).BeginInit();
            this.kryptonPanel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.kecbDayOfWeek)).BeginInit();
            this.SuspendLayout();
            //
            // kryptonPanel1
            //
            this.kryptonPanel1.Controls.Add(this.klblComboBoxTree);
            this.kryptonPanel1.Controls.Add(this.kcbtNavigation);
            this.kryptonPanel1.Controls.Add(this.klblEnumerationComboBox);
            this.kryptonPanel1.Controls.Add(this.kecbDayOfWeek);
            this.kryptonPanel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.kryptonPanel1.Location = new System.Drawing.Point(0, 0);
            this.kryptonPanel1.Name = "kryptonPanel1";
            this.kryptonPanel1.Size = new System.Drawing.Size(384, 141);
            this.kryptonPanel1.TabIndex = 0;
            //
            // klblComboBoxTree
            //
            this.klblComboBoxTree.Location = new System.Drawing.Point(13, 13);
            this.klblComboBoxTree.Name = "klblComboBoxTree";
            this.klblComboBoxTree.Size = new System.Drawing.Size(140, 20);
            this.klblComboBoxTree.TabIndex = 0;
            this.klblComboBoxTree.Values.Text = "KryptonComboBoxTree:";
            //
            // kcbtNavigation
            //
            this.kcbtNavigation.BranchSeparator = "/";
            this.kcbtNavigation.Location = new System.Drawing.Point(180, 13);
            this.kcbtNavigation.Name = "kcbtNavigation";
            this.kcbtNavigation.Size = new System.Drawing.Size(190, 23);
            this.kcbtNavigation.TabIndex = 1;
            //
            // klblEnumerationComboBox
            //
            this.klblEnumerationComboBox.Location = new System.Drawing.Point(13, 55);
            this.klblEnumerationComboBox.Name = "klblEnumerationComboBox";
            this.klblEnumerationComboBox.Size = new System.Drawing.Size(161, 20);
            this.klblEnumerationComboBox.TabIndex = 2;
            this.klblEnumerationComboBox.Values.Text = "KryptonEnumerationComboBox:";
            //
            // kecbDayOfWeek
            //
            this.kecbDayOfWeek.DropDownWidth = 190;
            this.kecbDayOfWeek.Location = new System.Drawing.Point(180, 55);
            this.kecbDayOfWeek.Name = "kecbDayOfWeek";
            this.kecbDayOfWeek.Size = new System.Drawing.Size(190, 22);
            this.kecbDayOfWeek.TabIndex = 3;
            //
            // ComboBoxExample
            //
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(384, 141);
            this.Controls.Add(this.kryptonPanel1);
            this.Name = "ComboBoxExample";
            this.Text = "ComboBox Examples";
            this.Load += new System.EventHandler(this.ComboBoxExample_Load);
            ((System.ComponentModel.ISupportInitialize)(this.kryptonPanel1)).EndInit();
            this.kryptonPanel1.ResumeLayout(false);
            this.kryptonPanel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.kecbDayOfWeek)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private Krypton.Toolkit.KryptonPanel kryptonPanel1;
        private Krypton.Toolkit.KryptonLabel klblComboBoxTree;
        private Krypton.Toolkit.Suite.Extended.ComboBox.KryptonComboBoxTree kcbtNavigation;
        private Krypton.Toolkit.KryptonLabel klblEnumerationComboBox;
        private Krypton.Toolkit.Suite.Extended.ComboBox.KryptonEnumerationComboBox kecbDayOfWeek;
    }
}
