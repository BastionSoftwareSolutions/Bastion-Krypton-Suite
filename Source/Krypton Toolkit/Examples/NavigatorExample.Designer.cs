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
    partial class NavigatorExample
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
            this.obNavigation = new Krypton.Toolkit.Suite.Extended.Navigator.OutlookBar();
            this.obbMail = new Krypton.Toolkit.Suite.Extended.Navigator.OutlookBarButton();
            this.obbCalendar = new Krypton.Toolkit.Suite.Extended.Navigator.OutlookBarButton();
            this.obbContacts = new Krypton.Toolkit.Suite.Extended.Navigator.OutlookBarButton();
            this.kneEditor = new Krypton.Toolkit.Suite.Extended.Navigator.KryptonNavigatorEditor();
            this.kryptonPage1 = new Krypton.Navigator.KryptonPage();
            this.kryptonPage2 = new Krypton.Navigator.KryptonPage();
            ((System.ComponentModel.ISupportInitialize)(this.kneEditor)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.kryptonPage1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.kryptonPage2)).BeginInit();
            this.SuspendLayout();
            //
            // obNavigation
            //
            // Note: the OutlookBar manages its own Height while painting, so it must not be
            // side-docked (a docked height fights the control's own sizing in a repaint loop).
            this.obNavigation.Location = new System.Drawing.Point(0, 0);
            this.obNavigation.Name = "obNavigation";
            this.obNavigation.Size = new System.Drawing.Size(140, 150);
            this.obNavigation.TabIndex = 0;
            this.obNavigation.Buttons.Add(this.obbMail);
            this.obNavigation.Buttons.Add(this.obbCalendar);
            this.obNavigation.Buttons.Add(this.obbContacts);
            this.obNavigation.ButtonClicked += new Krypton.Toolkit.Suite.Extended.Navigator.OutlookBar.ButtonClickedEventHandler(this.obNavigation_ButtonClicked);
            //
            // obbMail
            //
            this.obbMail.Text = "Mail";
            //
            // obbCalendar
            //
            this.obbCalendar.Text = "Calendar";
            //
            // obbContacts
            //
            this.obbContacts.Text = "Contacts";
            //
            // kneEditor
            //
            this.kneEditor.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)
            | System.Windows.Forms.AnchorStyles.Left)
            | System.Windows.Forms.AnchorStyles.Right)));
            this.kneEditor.Location = new System.Drawing.Point(140, 0);
            this.kneEditor.Name = "kneEditor";
            this.kneEditor.Pages.AddRange(new Krypton.Navigator.KryptonPage[] {
            this.kryptonPage1,
            this.kryptonPage2});
            this.kneEditor.SelectedIndex = 0;
            this.kneEditor.Size = new System.Drawing.Size(444, 361);
            this.kneEditor.TabIndex = 1;
            //
            // kryptonPage1
            //
            this.kryptonPage1.AutoHiddenSlideSize = new System.Drawing.Size(200, 200);
            this.kryptonPage1.Name = "kryptonPage1";
            this.kryptonPage1.Text = "Notes 1";
            this.kryptonPage1.UniqueName = "NavigatorExamplePage1";
            //
            // kryptonPage2
            //
            this.kryptonPage2.AutoHiddenSlideSize = new System.Drawing.Size(200, 200);
            this.kryptonPage2.Name = "kryptonPage2";
            this.kryptonPage2.Text = "Notes 2";
            this.kryptonPage2.UniqueName = "NavigatorExamplePage2";
            //
            // NavigatorExample
            //
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(584, 361);
            this.Controls.Add(this.kneEditor);
            this.Controls.Add(this.obNavigation);
            this.Name = "NavigatorExample";
            this.Text = "Navigator Example";
            ((System.ComponentModel.ISupportInitialize)(this.kneEditor)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.kryptonPage1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.kryptonPage2)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private Krypton.Toolkit.Suite.Extended.Navigator.OutlookBar obNavigation;
        private Krypton.Toolkit.Suite.Extended.Navigator.OutlookBarButton obbMail;
        private Krypton.Toolkit.Suite.Extended.Navigator.OutlookBarButton obbCalendar;
        private Krypton.Toolkit.Suite.Extended.Navigator.OutlookBarButton obbContacts;
        private Krypton.Toolkit.Suite.Extended.Navigator.KryptonNavigatorEditor kneEditor;
        private Krypton.Navigator.KryptonPage kryptonPage1;
        private Krypton.Navigator.KryptonPage kryptonPage2;
    }
}
