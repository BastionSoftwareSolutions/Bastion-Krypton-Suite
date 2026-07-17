#region BSD License
/*
 * 
 * Original BSD 3-Clause License (https://github.com/ComponentFactory/Krypton/blob/master/LICENSE)
 *  © Component Factory Pty Ltd, 2006 - 2016, (Version 4.5.0.0) All rights reserved.
 * 
 *  New BSD 3-Clause License (https://github.com/Krypton-Suite/Standard-Toolkit/blob/master/LICENSE)
 *  Modifications by Peter Wagner(aka Wagnerp) & Simon Coghlan(aka Smurf-IV), et al. 2017 - 2024. All rights reserved. 
 *  
 */
#endregion

using System;
using System.Text;
using System.Windows.Forms;

using Krypton.Toolkit;

namespace KryptonTaskDialogExamples
{
    public partial class Form1 : Form
    {
        public Form1() => InitializeComponent();

        private void Form1_Load(object sender, EventArgs e)
        {
            comboBoxIcon.Text = "Information";
            comboBoxFooterIcon.Text = "Warning";
        }

        private void palette2010Blue_CheckedChanged(object sender, EventArgs e) => kryptonManager.GlobalPaletteMode = PaletteMode.Office2010Blue;

        private void palette2010Silver_CheckedChanged(object sender, EventArgs e) => kryptonManager.GlobalPaletteMode = PaletteMode.Office2010Silver;

        private void palette2010Black_CheckedChanged(object sender, EventArgs e) => kryptonManager.GlobalPaletteMode = PaletteMode.Office2010Black;

        private void palette2007Blue_CheckedChanged(object sender, EventArgs e) => kryptonManager.GlobalPaletteMode = PaletteMode.Office2007Blue;

        private void paletteSparkleOrange_CheckedChanged(object sender, EventArgs e) => kryptonManager.GlobalPaletteMode = PaletteMode.SparkleOrange;

        private void paletteProfessional_CheckedChanged(object sender, EventArgs e) => kryptonManager.GlobalPaletteMode = PaletteMode.ProfessionalSystem;

        private void buttonShowTaskDialog_Click(object sender, EventArgs e)
        {
            // Bastion: ported from the pre-v105 component-based KryptonTaskDialog API
            // (KryptonTaskDialogCommand, TaskDialogButtons) to the element-based
            // KryptonTaskDialog shipped by the current core toolkit.
            var commonButtons = KryptonTaskDialogCommonButtonTypes.None;
            if (checkBoxOK.Checked)
            {
                commonButtons |= KryptonTaskDialogCommonButtonTypes.OK;
            }

            if (checkBoxYes.Checked)
            {
                commonButtons |= KryptonTaskDialogCommonButtonTypes.Yes;
            }

            if (checkBoxNo.Checked)
            {
                commonButtons |= KryptonTaskDialogCommonButtonTypes.No;
            }

            if (checkBoxCancel.Checked)
            {
                commonButtons |= KryptonTaskDialogCommonButtonTypes.Cancel;
            }

            if (checkBoxClose.Checked)
            {
                // The element-based dialog has no separate Close button; Cancel is the nearest equivalent.
                commonButtons |= KryptonTaskDialogCommonButtonTypes.Cancel;
            }

            if (checkBoxRetry.Checked)
            {
                commonButtons |= KryptonTaskDialogCommonButtonTypes.Retry;
            }

            using (var taskDialog = new KryptonTaskDialog())
            {
                taskDialog.HideAllElements();

                taskDialog.Dialog.Form.Text = textBoxCaption.Text;

                taskDialog.Heading.Text = textBoxMainInstructions.Text;
                taskDialog.Heading.IconType = MapIcon(comboBoxIcon.Text);
                taskDialog.Heading.Visible = true;

                taskDialog.Content.Text = textBoxContent.Text;
                taskDialog.Content.Visible = textBoxContent.Text.Length > 0;

                if (checkBoxRadioButtons.Checked)
                {
                    // The radio button group of the old API is presented as a combo box selection.
                    taskDialog.ComboBox.Items.Clear();
                    taskDialog.ComboBox.Items.AddRange(new object[] { "First button", "Second option", "Third option" });
                    taskDialog.ComboBox.Visible = true;
                }

                if (checkBoxCommandButtons.Checked)
                {
                    taskDialog.CommandLinkButtons.Buttons.Clear();
                    foreach (var commandText in new[] { "Command One", "Command Two", "Command Three" })
                    {
                        var commandButton = new KryptonCommandLinkButton
                        {
                            Text = commandText,
                            DialogResult = DialogResult.OK
                        };
                        taskDialog.CommandLinkButtons.Buttons.Add(commandButton);
                    }

                    taskDialog.CommandLinkButtons.Visible = true;
                }

                if (!string.IsNullOrEmpty(textBoxCheckBoxText.Text))
                {
                    taskDialog.CheckBox.Text = textBoxCheckBoxText.Text;
                    taskDialog.CheckBox.Checked = checkBoxInitialState.Checked;
                    taskDialog.CheckBox.Visible = true;
                }

                if (!string.IsNullOrEmpty(textBoxFooterHyperlink.Text))
                {
                    taskDialog.HyperLink.Url = textBoxFooterHyperlink.Text;
                    taskDialog.HyperLink.Visible = true;
                }

                taskDialog.FooterBar.CommonButtons.Buttons = commonButtons;
                taskDialog.FooterBar.Footer.FootNoteText = textBoxFooterText.Text;
                taskDialog.FooterBar.Footer.IconType = MapIcon(comboBoxFooterIcon.Text);
                taskDialog.FooterBar.Visible = true;

                taskDialog.ShowDialog(this);
            }
        }

        /// <summary>Maps the old KryptonMessageBoxIcon names shown in the UI onto the new icon set.</summary>
        private static KryptonTaskDialogIconType MapIcon(string iconName) => iconName switch
        {
            "Information" => KryptonTaskDialogIconType.ShieldInformation,
            "Warning" => KryptonTaskDialogIconType.ShieldWarning,
            "Error" or "Stop" or "Hand" => KryptonTaskDialogIconType.ShieldError,
            "Question" => KryptonTaskDialogIconType.ShieldHelp,
            "Shield" => KryptonTaskDialogIconType.ShieldUac,
            "None" => KryptonTaskDialogIconType.None,
            _ => KryptonTaskDialogIconType.ShieldKrypton
        };

        private void buttonFill_Click(object sender, EventArgs e)
        {
            var s = "The quick brown fox jumps over the lazy dog";
            var e1 = new Random().Next(50, 400);
            var sb = new StringBuilder().Append(s);
            for (var i = 0; i < e1; ++i)
            {
                sb.AppendFormat("\r\n\r\n{0}", s);
                if (i % 10 == 0)
                {
                    var e2 = new Random().Next(1, 10);
                    for (var j = 0; j < e2; ++j)
                    {
                        sb.AppendFormat(". {0}", s);
                    }

                    sb.Append("\r\n");
                }
            }
            textBoxContent.Text = sb.ToString();
        }
    }
}
