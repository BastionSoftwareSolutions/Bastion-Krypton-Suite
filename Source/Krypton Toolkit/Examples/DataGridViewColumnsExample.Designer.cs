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
    partial class DataGridViewColumnsExample
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
            this.kdgvColumns = new Krypton.Toolkit.KryptonDataGridView();
            this.colTask = new Krypton.Toolkit.KryptonDataGridViewTextBoxColumn();
            this.colProgress = new Krypton.Toolkit.Suite.Extended.DataGridView.KryptonDataGridViewPercentageColumn();
            this.colRating = new Krypton.Toolkit.Suite.Extended.DataGridView.KryptonDataGridViewRatingColumn();
            this.colPriority = new Krypton.Toolkit.Suite.Extended.DataGridView.KryptonDataGridViewTokenColumn();
            this.colOwner = new Krypton.Toolkit.Suite.Extended.DataGridView.KryptonDataGridViewTextAndImageColumn();
            ((System.ComponentModel.ISupportInitialize)(this.kryptonPanel1)).BeginInit();
            this.kryptonPanel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.kdgvColumns)).BeginInit();
            this.SuspendLayout();
            //
            // kryptonPanel1
            //
            this.kryptonPanel1.Controls.Add(this.kdgvColumns);
            this.kryptonPanel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.kryptonPanel1.Location = new System.Drawing.Point(0, 0);
            this.kryptonPanel1.Name = "kryptonPanel1";
            this.kryptonPanel1.Padding = new System.Windows.Forms.Padding(10);
            this.kryptonPanel1.Size = new System.Drawing.Size(684, 311);
            this.kryptonPanel1.TabIndex = 0;
            //
            // kdgvColumns
            //
            this.kdgvColumns.AllowUserToAddRows = false;
            this.kdgvColumns.AllowUserToDeleteRows = false;
            this.kdgvColumns.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.kdgvColumns.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.colTask,
            this.colProgress,
            this.colRating,
            this.colPriority,
            this.colOwner});
            this.kdgvColumns.Dock = System.Windows.Forms.DockStyle.Fill;
            this.kdgvColumns.Location = new System.Drawing.Point(10, 10);
            this.kdgvColumns.Name = "kdgvColumns";
            this.kdgvColumns.Size = new System.Drawing.Size(664, 291);
            this.kdgvColumns.TabIndex = 0;
            //
            // colTask
            //
            this.colTask.HeaderText = "Task";
            this.colTask.Name = "colTask";
            this.colTask.Width = 220;
            //
            // colProgress
            //
            this.colProgress.HeaderText = "Progress";
            this.colProgress.Name = "colProgress";
            this.colProgress.Width = 90;
            //
            // colRating
            //
            this.colRating.HeaderText = "Rating";
            this.colRating.Name = "colRating";
            this.colRating.Width = 90;
            //
            // colPriority
            //
            this.colPriority.HeaderText = "Priority";
            this.colPriority.Name = "colPriority";
            this.colPriority.Width = 90;
            //
            // colOwner
            //
            this.colOwner.HeaderText = "Owner";
            this.colOwner.Name = "colOwner";
            this.colOwner.Width = 120;
            //
            // DataGridViewColumnsExample
            //
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(684, 311);
            this.Controls.Add(this.kryptonPanel1);
            this.Name = "DataGridViewColumnsExample";
            this.Text = "DataGridView Column Examples";
            this.Load += new System.EventHandler(this.DataGridViewColumnsExample_Load);
            ((System.ComponentModel.ISupportInitialize)(this.kryptonPanel1)).EndInit();
            this.kryptonPanel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.kdgvColumns)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private Krypton.Toolkit.KryptonPanel kryptonPanel1;
        private Krypton.Toolkit.KryptonDataGridView kdgvColumns;
        private Krypton.Toolkit.KryptonDataGridViewTextBoxColumn colTask;
        private Krypton.Toolkit.Suite.Extended.DataGridView.KryptonDataGridViewPercentageColumn colProgress;
        private Krypton.Toolkit.Suite.Extended.DataGridView.KryptonDataGridViewRatingColumn colRating;
        private Krypton.Toolkit.Suite.Extended.DataGridView.KryptonDataGridViewTokenColumn colPriority;
        private Krypton.Toolkit.Suite.Extended.DataGridView.KryptonDataGridViewTextAndImageColumn colOwner;
    }
}
