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
    partial class NotificationsExample
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
            this.ktnpPopUp = new Krypton.Toolkit.Suite.Extended.Notifications.KryptonToastNotificationPopup();
            this.kryptonPanel1 = new Krypton.Toolkit.KryptonPanel();
            this.kbtnSuccessAlert = new Krypton.Toolkit.KryptonButton();
            this.kbtnInformationAlert = new Krypton.Toolkit.KryptonButton();
            this.kbtnWarningAlert = new Krypton.Toolkit.KryptonButton();
            this.kbtnErrorAlert = new Krypton.Toolkit.KryptonButton();
            this.kbtnPopUpNotification = new Krypton.Toolkit.KryptonButton();
            this.kbtnToastNotification = new Krypton.Toolkit.KryptonButton();
            ((System.ComponentModel.ISupportInitialize)(this.kryptonPanel1)).BeginInit();
            this.kryptonPanel1.SuspendLayout();
            this.SuspendLayout();
            //
            // ktnpPopUp
            //
            this.ktnpPopUp.ContentText = "This pop-up notification slides in from the bottom-right of the screen.";
            this.ktnpPopUp.TitleText = "Bastion Krypton Suite";
            //
            // kryptonPanel1
            //
            this.kryptonPanel1.Controls.Add(this.kbtnSuccessAlert);
            this.kryptonPanel1.Controls.Add(this.kbtnInformationAlert);
            this.kryptonPanel1.Controls.Add(this.kbtnWarningAlert);
            this.kryptonPanel1.Controls.Add(this.kbtnErrorAlert);
            this.kryptonPanel1.Controls.Add(this.kbtnPopUpNotification);
            this.kryptonPanel1.Controls.Add(this.kbtnToastNotification);
            this.kryptonPanel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.kryptonPanel1.Location = new System.Drawing.Point(0, 0);
            this.kryptonPanel1.Name = "kryptonPanel1";
            this.kryptonPanel1.Size = new System.Drawing.Size(404, 133);
            this.kryptonPanel1.TabIndex = 0;
            //
            // kbtnSuccessAlert
            //
            this.kbtnSuccessAlert.Location = new System.Drawing.Point(13, 13);
            this.kbtnSuccessAlert.Name = "kbtnSuccessAlert";
            this.kbtnSuccessAlert.Size = new System.Drawing.Size(180, 25);
            this.kbtnSuccessAlert.TabIndex = 0;
            this.kbtnSuccessAlert.Values.Text = "Success Alert";
            this.kbtnSuccessAlert.Click += new System.EventHandler(this.kbtnSuccessAlert_Click);
            //
            // kbtnInformationAlert
            //
            this.kbtnInformationAlert.Location = new System.Drawing.Point(211, 13);
            this.kbtnInformationAlert.Name = "kbtnInformationAlert";
            this.kbtnInformationAlert.Size = new System.Drawing.Size(180, 25);
            this.kbtnInformationAlert.TabIndex = 1;
            this.kbtnInformationAlert.Values.Text = "Information Alert";
            this.kbtnInformationAlert.Click += new System.EventHandler(this.kbtnInformationAlert_Click);
            //
            // kbtnWarningAlert
            //
            this.kbtnWarningAlert.Location = new System.Drawing.Point(13, 44);
            this.kbtnWarningAlert.Name = "kbtnWarningAlert";
            this.kbtnWarningAlert.Size = new System.Drawing.Size(180, 25);
            this.kbtnWarningAlert.TabIndex = 2;
            this.kbtnWarningAlert.Values.Text = "Warning Alert";
            this.kbtnWarningAlert.Click += new System.EventHandler(this.kbtnWarningAlert_Click);
            //
            // kbtnErrorAlert
            //
            this.kbtnErrorAlert.Location = new System.Drawing.Point(211, 44);
            this.kbtnErrorAlert.Name = "kbtnErrorAlert";
            this.kbtnErrorAlert.Size = new System.Drawing.Size(180, 25);
            this.kbtnErrorAlert.TabIndex = 3;
            this.kbtnErrorAlert.Values.Text = "Error Alert";
            this.kbtnErrorAlert.Click += new System.EventHandler(this.kbtnErrorAlert_Click);
            //
            // kbtnPopUpNotification
            //
            this.kbtnPopUpNotification.Location = new System.Drawing.Point(13, 75);
            this.kbtnPopUpNotification.Name = "kbtnPopUpNotification";
            this.kbtnPopUpNotification.Size = new System.Drawing.Size(180, 25);
            this.kbtnPopUpNotification.TabIndex = 4;
            this.kbtnPopUpNotification.Values.Text = "Pop-Up Notification";
            this.kbtnPopUpNotification.Click += new System.EventHandler(this.kbtnPopUpNotification_Click);
            //
            // kbtnToastNotification
            //
            this.kbtnToastNotification.Location = new System.Drawing.Point(211, 75);
            this.kbtnToastNotification.Name = "kbtnToastNotification";
            this.kbtnToastNotification.Size = new System.Drawing.Size(180, 25);
            this.kbtnToastNotification.TabIndex = 5;
            this.kbtnToastNotification.Values.Text = "Toast Notification";
            this.kbtnToastNotification.Click += new System.EventHandler(this.kbtnToastNotification_Click);
            //
            // NotificationsExample
            //
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(404, 133);
            this.Controls.Add(this.kryptonPanel1);
            this.Name = "NotificationsExample";
            this.Text = "Notifications Examples";
            ((System.ComponentModel.ISupportInitialize)(this.kryptonPanel1)).EndInit();
            this.kryptonPanel1.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private Krypton.Toolkit.Suite.Extended.Notifications.KryptonToastNotificationPopup ktnpPopUp;
        private Krypton.Toolkit.KryptonPanel kryptonPanel1;
        private Krypton.Toolkit.KryptonButton kbtnSuccessAlert;
        private Krypton.Toolkit.KryptonButton kbtnInformationAlert;
        private Krypton.Toolkit.KryptonButton kbtnWarningAlert;
        private Krypton.Toolkit.KryptonButton kbtnErrorAlert;
        private Krypton.Toolkit.KryptonButton kbtnPopUpNotification;
        private Krypton.Toolkit.KryptonButton kbtnToastNotification;
    }
}
