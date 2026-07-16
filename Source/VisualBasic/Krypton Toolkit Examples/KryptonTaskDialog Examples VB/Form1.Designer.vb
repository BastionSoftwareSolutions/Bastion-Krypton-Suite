' VB.NET twin of Source\Krypton Toolkit Examples\KryptonTaskDialog Examples\Form1.Designer.cs (Bastion Phase 4c).
<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class Form1
    Inherits System.Windows.Forms.Form

    'Form overrides dispose to clean up the component list.
    <System.Diagnostics.DebuggerNonUserCode()>
    Protected Overrides Sub Dispose(disposing As Boolean)
        Try
            If disposing AndAlso components IsNot Nothing Then
                components.Dispose()
            End If
        Finally
            MyBase.Dispose(disposing)
        End Try
    End Sub

    'Required by the Windows Form Designer
    Private components As System.ComponentModel.IContainer

    'NOTE: The following procedure is required by the Windows Form Designer
    'It can be modified using the Windows Form Designer.
    'Do not modify it using the code editor.
    <System.Diagnostics.DebuggerStepThrough()>
    Private Sub InitializeComponent()
        Me.components = New System.ComponentModel.Container()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(Form1))
        Me.labelCaption = New System.Windows.Forms.Label()
        Me.labelMainInstructions = New System.Windows.Forms.Label()
        Me.labelContent = New System.Windows.Forms.Label()
        Me.textBoxCaption = New System.Windows.Forms.TextBox()
        Me.textBoxMainInstructions = New System.Windows.Forms.TextBox()
        Me.textBoxContent = New System.Windows.Forms.TextBox()
        Me.buttonShowTaskDialog = New System.Windows.Forms.Button()
        Me.kryptonManager = New Krypton.Toolkit.KryptonManager(Me.components)
        Me.checkBoxOK = New System.Windows.Forms.CheckBox()
        Me.checkBoxYes = New System.Windows.Forms.CheckBox()
        Me.checkBoxNo = New System.Windows.Forms.CheckBox()
        Me.checkBoxCancel = New System.Windows.Forms.CheckBox()
        Me.checkBoxClose = New System.Windows.Forms.CheckBox()
        Me.checkBoxRetry = New System.Windows.Forms.CheckBox()
        Me.groupBoxBasic = New System.Windows.Forms.GroupBox()
        Me.buttonFill = New System.Windows.Forms.Button()
        Me.comboBoxIcon = New System.Windows.Forms.ComboBox()
        Me.labelIcon = New System.Windows.Forms.Label()
        Me.groupBoxFooter = New System.Windows.Forms.GroupBox()
        Me.comboBoxFooterIcon = New System.Windows.Forms.ComboBox()
        Me.labelFooterIcon = New System.Windows.Forms.Label()
        Me.labelFooterText = New System.Windows.Forms.Label()
        Me.labelFooterHyperlink = New System.Windows.Forms.Label()
        Me.textBoxFooterText = New System.Windows.Forms.TextBox()
        Me.textBoxFooterHyperlink = New System.Windows.Forms.TextBox()
        Me.groupBoxCheckBox = New System.Windows.Forms.GroupBox()
        Me.checkBoxInitialState = New System.Windows.Forms.CheckBox()
        Me.label1 = New System.Windows.Forms.Label()
        Me.textBoxCheckBoxText = New System.Windows.Forms.TextBox()
        Me.groupBox1 = New System.Windows.Forms.GroupBox()
        Me.checkBoxCommandButtons = New System.Windows.Forms.CheckBox()
        Me.checkBoxRadioButtons = New System.Windows.Forms.CheckBox()
        Me.groupBoxPalette = New System.Windows.Forms.GroupBox()
        Me.paletteSparkleOrange = New System.Windows.Forms.RadioButton()
        Me.palette2010Black = New System.Windows.Forms.RadioButton()
        Me.palette2010Silver = New System.Windows.Forms.RadioButton()
        Me.paletteProfessional = New System.Windows.Forms.RadioButton()
        Me.palette2007Blue = New System.Windows.Forms.RadioButton()
        Me.palette2010Blue = New System.Windows.Forms.RadioButton()
        Me.groupBoxBasic.SuspendLayout()
        Me.groupBoxFooter.SuspendLayout()
        Me.groupBoxCheckBox.SuspendLayout()
        Me.groupBox1.SuspendLayout()
        Me.groupBoxPalette.SuspendLayout()
        Me.SuspendLayout()
        Me.labelCaption.AutoSize = True
        Me.labelCaption.Location = New System.Drawing.Point(23, 39)
        Me.labelCaption.Name = "labelCaption"
        Me.labelCaption.Size = New System.Drawing.Size(68, 13)
        Me.labelCaption.TabIndex = 0
        Me.labelCaption.Text = "Window Title"
        Me.labelMainInstructions.AutoSize = True
        Me.labelMainInstructions.Location = New System.Drawing.Point(-2, 68)
        Me.labelMainInstructions.Name = "labelMainInstructions"
        Me.labelMainInstructions.Size = New System.Drawing.Size(89, 13)
        Me.labelMainInstructions.TabIndex = 1
        Me.labelMainInstructions.Text = "Main Instructions"
        Me.labelContent.AutoSize = True
        Me.labelContent.Location = New System.Drawing.Point(51, 94)
        Me.labelContent.Name = "labelContent"
        Me.labelContent.Size = New System.Drawing.Size(46, 13)
        Me.labelContent.TabIndex = 2
        Me.labelContent.Text = "Content"
        Me.textBoxCaption.Location = New System.Drawing.Point(111, 36)
        Me.textBoxCaption.Name = "textBoxCaption"
        Me.textBoxCaption.Size = New System.Drawing.Size(214, 21)
        Me.textBoxCaption.TabIndex = 3
        Me.textBoxCaption.Text = "Window Title"
        Me.textBoxMainInstructions.Location = New System.Drawing.Point(111, 65)
        Me.textBoxMainInstructions.Name = "textBoxMainInstructions"
        Me.textBoxMainInstructions.Size = New System.Drawing.Size(214, 21)
        Me.textBoxMainInstructions.TabIndex = 4
        Me.textBoxMainInstructions.Text = "Main Instructions"
        Me.textBoxContent.Location = New System.Drawing.Point(111, 91)
        Me.textBoxContent.Multiline = True
        Me.textBoxContent.Name = "textBoxContent"
        Me.textBoxContent.Size = New System.Drawing.Size(214, 68)
        Me.textBoxContent.TabIndex = 5
        Me.textBoxContent.Text = "Content"
        Me.buttonShowTaskDialog.Location = New System.Drawing.Point(396, 341)
        Me.buttonShowTaskDialog.Name = "buttonShowTaskDialog"
        Me.buttonShowTaskDialog.Size = New System.Drawing.Size(254, 59)
        Me.buttonShowTaskDialog.TabIndex = 6
        Me.buttonShowTaskDialog.Text = "Show TaskDialog"
        Me.buttonShowTaskDialog.UseVisualStyleBackColor = True
        Me.kryptonManager.GlobalPaletteMode = Krypton.Toolkit.PaletteMode.Office2010Blue
        Me.checkBoxOK.AutoSize = True
        Me.checkBoxOK.Checked = True
        Me.checkBoxOK.CheckState = System.Windows.Forms.CheckState.Checked
        Me.checkBoxOK.Location = New System.Drawing.Point(115, 201)
        Me.checkBoxOK.Name = "checkBoxOK"
        Me.checkBoxOK.Size = New System.Drawing.Size(40, 17)
        Me.checkBoxOK.TabIndex = 7
        Me.checkBoxOK.Text = "OK"
        Me.checkBoxOK.UseVisualStyleBackColor = True
        Me.checkBoxYes.AutoSize = True
        Me.checkBoxYes.Location = New System.Drawing.Point(115, 224)
        Me.checkBoxYes.Name = "checkBoxYes"
        Me.checkBoxYes.Size = New System.Drawing.Size(43, 17)
        Me.checkBoxYes.TabIndex = 8
        Me.checkBoxYes.Text = "Yes"
        Me.checkBoxYes.UseVisualStyleBackColor = True
        Me.checkBoxNo.AutoSize = True
        Me.checkBoxNo.Location = New System.Drawing.Point(187, 224)
        Me.checkBoxNo.Name = "checkBoxNo"
        Me.checkBoxNo.Size = New System.Drawing.Size(39, 17)
        Me.checkBoxNo.TabIndex = 9
        Me.checkBoxNo.Text = "No"
        Me.checkBoxNo.UseVisualStyleBackColor = True
        Me.checkBoxCancel.AutoSize = True
        Me.checkBoxCancel.Checked = True
        Me.checkBoxCancel.CheckState = System.Windows.Forms.CheckState.Checked
        Me.checkBoxCancel.Location = New System.Drawing.Point(187, 201)
        Me.checkBoxCancel.Name = "checkBoxCancel"
        Me.checkBoxCancel.Size = New System.Drawing.Size(58, 17)
        Me.checkBoxCancel.TabIndex = 10
        Me.checkBoxCancel.Text = "Cancel"
        Me.checkBoxCancel.UseVisualStyleBackColor = True
        Me.checkBoxClose.AutoSize = True
        Me.checkBoxClose.Location = New System.Drawing.Point(269, 201)
        Me.checkBoxClose.Name = "checkBoxClose"
        Me.checkBoxClose.Size = New System.Drawing.Size(52, 17)
        Me.checkBoxClose.TabIndex = 11
        Me.checkBoxClose.Text = "Close"
        Me.checkBoxClose.UseVisualStyleBackColor = True
        Me.checkBoxRetry.AutoSize = True
        Me.checkBoxRetry.Location = New System.Drawing.Point(270, 224)
        Me.checkBoxRetry.Name = "checkBoxRetry"
        Me.checkBoxRetry.Size = New System.Drawing.Size(53, 17)
        Me.checkBoxRetry.TabIndex = 12
        Me.checkBoxRetry.Text = "Retry"
        Me.checkBoxRetry.UseVisualStyleBackColor = True
        Me.groupBoxBasic.Controls.Add(Me.buttonFill)
        Me.groupBoxBasic.Controls.Add(Me.comboBoxIcon)
        Me.groupBoxBasic.Controls.Add(Me.labelIcon)
        Me.groupBoxBasic.Controls.Add(Me.labelCaption)
        Me.groupBoxBasic.Controls.Add(Me.checkBoxRetry)
        Me.groupBoxBasic.Controls.Add(Me.labelMainInstructions)
        Me.groupBoxBasic.Controls.Add(Me.checkBoxClose)
        Me.groupBoxBasic.Controls.Add(Me.labelContent)
        Me.groupBoxBasic.Controls.Add(Me.checkBoxCancel)
        Me.groupBoxBasic.Controls.Add(Me.textBoxCaption)
        Me.groupBoxBasic.Controls.Add(Me.checkBoxNo)
        Me.groupBoxBasic.Controls.Add(Me.textBoxMainInstructions)
        Me.groupBoxBasic.Controls.Add(Me.checkBoxYes)
        Me.groupBoxBasic.Controls.Add(Me.textBoxContent)
        Me.groupBoxBasic.Controls.Add(Me.checkBoxOK)
        Me.groupBoxBasic.Location = New System.Drawing.Point(12, 12)
        Me.groupBoxBasic.Name = "groupBoxBasic"
        Me.groupBoxBasic.Size = New System.Drawing.Size(346, 259)
        Me.groupBoxBasic.TabIndex = 13
        Me.groupBoxBasic.TabStop = False
        Me.groupBoxBasic.Text = "Basic Settings"
        Me.buttonFill.Location = New System.Drawing.Point(64, 136)
        Me.buttonFill.Name = "buttonFill"
        Me.buttonFill.Size = New System.Drawing.Size(40, 23)
        Me.buttonFill.TabIndex = 15
        Me.buttonFill.Text = "Fill"
        Me.buttonFill.UseVisualStyleBackColor = True
        Me.comboBoxIcon.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.comboBoxIcon.FormattingEnabled = True
        Me.comboBoxIcon.Items.AddRange(New Object() { "None", "Error", "Question", "Warning", "Information"})
        Me.comboBoxIcon.Location = New System.Drawing.Point(111, 165)
        Me.comboBoxIcon.Name = "comboBoxIcon"
        Me.comboBoxIcon.Size = New System.Drawing.Size(214, 21)
        Me.comboBoxIcon.TabIndex = 14
        Me.labelIcon.AutoSize = True
        Me.labelIcon.Location = New System.Drawing.Point(77, 168)
        Me.labelIcon.Name = "labelIcon"
        Me.labelIcon.Size = New System.Drawing.Size(28, 13)
        Me.labelIcon.TabIndex = 13
        Me.labelIcon.Text = "Icon"
        Me.groupBoxFooter.Controls.Add(Me.comboBoxFooterIcon)
        Me.groupBoxFooter.Controls.Add(Me.labelFooterIcon)
        Me.groupBoxFooter.Controls.Add(Me.labelFooterText)
        Me.groupBoxFooter.Controls.Add(Me.labelFooterHyperlink)
        Me.groupBoxFooter.Controls.Add(Me.textBoxFooterText)
        Me.groupBoxFooter.Controls.Add(Me.textBoxFooterHyperlink)
        Me.groupBoxFooter.Location = New System.Drawing.Point(12, 277)
        Me.groupBoxFooter.Name = "groupBoxFooter"
        Me.groupBoxFooter.Size = New System.Drawing.Size(346, 123)
        Me.groupBoxFooter.TabIndex = 14
        Me.groupBoxFooter.TabStop = False
        Me.groupBoxFooter.Text = "Footer Settings"
        Me.comboBoxFooterIcon.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.comboBoxFooterIcon.FormattingEnabled = True
        Me.comboBoxFooterIcon.Items.AddRange(New Object() { "None", "Error", "Question", "Warning", "Information"})
        Me.comboBoxFooterIcon.Location = New System.Drawing.Point(113, 84)
        Me.comboBoxFooterIcon.Name = "comboBoxFooterIcon"
        Me.comboBoxFooterIcon.Size = New System.Drawing.Size(214, 21)
        Me.comboBoxFooterIcon.TabIndex = 10
        Me.labelFooterIcon.AutoSize = True
        Me.labelFooterIcon.Location = New System.Drawing.Point(70, 87)
        Me.labelFooterIcon.Name = "labelFooterIcon"
        Me.labelFooterIcon.Size = New System.Drawing.Size(31, 13)
        Me.labelFooterIcon.TabIndex = 9
        Me.labelFooterIcon.Text = " Icon"
        Me.labelFooterText.AutoSize = True
        Me.labelFooterText.Location = New System.Drawing.Point(73, 29)
        Me.labelFooterText.Name = "labelFooterText"
        Me.labelFooterText.Size = New System.Drawing.Size(29, 13)
        Me.labelFooterText.TabIndex = 5
        Me.labelFooterText.Text = "Text"
        Me.labelFooterHyperlink.AutoSize = True
        Me.labelFooterHyperlink.Location = New System.Drawing.Point(45, 58)
        Me.labelFooterHyperlink.Name = "labelFooterHyperlink"
        Me.labelFooterHyperlink.Size = New System.Drawing.Size(51, 13)
        Me.labelFooterHyperlink.TabIndex = 6
        Me.labelFooterHyperlink.Text = "Hyperlink"
        Me.textBoxFooterText.Location = New System.Drawing.Point(113, 26)
        Me.textBoxFooterText.Name = "textBoxFooterText"
        Me.textBoxFooterText.Size = New System.Drawing.Size(214, 21)
        Me.textBoxFooterText.TabIndex = 7
        Me.textBoxFooterText.Text = "Footer Text"
        Me.textBoxFooterHyperlink.Location = New System.Drawing.Point(113, 55)
        Me.textBoxFooterHyperlink.Name = "textBoxFooterHyperlink"
        Me.textBoxFooterHyperlink.Size = New System.Drawing.Size(214, 21)
        Me.textBoxFooterHyperlink.TabIndex = 8
        Me.textBoxFooterHyperlink.Text = "Hyperlink"
        Me.groupBoxCheckBox.Controls.Add(Me.checkBoxInitialState)
        Me.groupBoxCheckBox.Controls.Add(Me.label1)
        Me.groupBoxCheckBox.Controls.Add(Me.textBoxCheckBoxText)
        Me.groupBoxCheckBox.Location = New System.Drawing.Point(364, 12)
        Me.groupBoxCheckBox.Name = "groupBoxCheckBox"
        Me.groupBoxCheckBox.Size = New System.Drawing.Size(322, 88)
        Me.groupBoxCheckBox.TabIndex = 15
        Me.groupBoxCheckBox.TabStop = False
        Me.groupBoxCheckBox.Text = "CheckBox Settings"
        Me.checkBoxInitialState.AutoSize = True
        Me.checkBoxInitialState.Location = New System.Drawing.Point(68, 59)
        Me.checkBoxInitialState.Name = "checkBoxInitialState"
        Me.checkBoxInitialState.Size = New System.Drawing.Size(81, 17)
        Me.checkBoxInitialState.TabIndex = 10
        Me.checkBoxInitialState.Text = "Initial State"
        Me.checkBoxInitialState.UseVisualStyleBackColor = True
        Me.label1.AutoSize = True
        Me.label1.Location = New System.Drawing.Point(19, 35)
        Me.label1.Name = "label1"
        Me.label1.Size = New System.Drawing.Size(29, 13)
        Me.label1.TabIndex = 8
        Me.label1.Text = "Text"
        Me.textBoxCheckBoxText.Location = New System.Drawing.Point(68, 32)
        Me.textBoxCheckBoxText.Name = "textBoxCheckBoxText"
        Me.textBoxCheckBoxText.Size = New System.Drawing.Size(200, 21)
        Me.textBoxCheckBoxText.TabIndex = 9
        Me.textBoxCheckBoxText.Text = "CheckBox Text"
        Me.groupBox1.Controls.Add(Me.checkBoxCommandButtons)
        Me.groupBox1.Controls.Add(Me.checkBoxRadioButtons)
        Me.groupBox1.Location = New System.Drawing.Point(364, 107)
        Me.groupBox1.Name = "groupBox1"
        Me.groupBox1.Size = New System.Drawing.Size(322, 91)
        Me.groupBox1.TabIndex = 16
        Me.groupBox1.TabStop = False
        Me.groupBox1.Text = "Extra Settings"
        Me.checkBoxCommandButtons.AutoSize = True
        Me.checkBoxCommandButtons.Checked = True
        Me.checkBoxCommandButtons.CheckState = System.Windows.Forms.CheckState.Checked
        Me.checkBoxCommandButtons.Location = New System.Drawing.Point(22, 54)
        Me.checkBoxCommandButtons.Name = "checkBoxCommandButtons"
        Me.checkBoxCommandButtons.Size = New System.Drawing.Size(185, 17)
        Me.checkBoxCommandButtons.TabIndex = 12
        Me.checkBoxCommandButtons.Text = "Show Example Command Buttons"
        Me.checkBoxCommandButtons.UseVisualStyleBackColor = True
        Me.checkBoxRadioButtons.AutoSize = True
        Me.checkBoxRadioButtons.Checked = True
        Me.checkBoxRadioButtons.CheckState = System.Windows.Forms.CheckState.Checked
        Me.checkBoxRadioButtons.Location = New System.Drawing.Point(22, 31)
        Me.checkBoxRadioButtons.Name = "checkBoxRadioButtons"
        Me.checkBoxRadioButtons.Size = New System.Drawing.Size(165, 17)
        Me.checkBoxRadioButtons.TabIndex = 11
        Me.checkBoxRadioButtons.Text = "Show Example Radio Buttons"
        Me.checkBoxRadioButtons.UseVisualStyleBackColor = True
        Me.groupBoxPalette.Controls.Add(Me.paletteSparkleOrange)
        Me.groupBoxPalette.Controls.Add(Me.palette2010Black)
        Me.groupBoxPalette.Controls.Add(Me.palette2010Silver)
        Me.groupBoxPalette.Controls.Add(Me.paletteProfessional)
        Me.groupBoxPalette.Controls.Add(Me.palette2007Blue)
        Me.groupBoxPalette.Controls.Add(Me.palette2010Blue)
        Me.groupBoxPalette.Location = New System.Drawing.Point(364, 205)
        Me.groupBoxPalette.Name = "groupBoxPalette"
        Me.groupBoxPalette.Size = New System.Drawing.Size(322, 118)
        Me.groupBoxPalette.TabIndex = 17
        Me.groupBoxPalette.TabStop = False
        Me.groupBoxPalette.Text = "Palette"
        Me.paletteSparkleOrange.AutoSize = True
        Me.paletteSparkleOrange.Location = New System.Drawing.Point(171, 54)
        Me.paletteSparkleOrange.Name = "paletteSparkleOrange"
        Me.paletteSparkleOrange.Size = New System.Drawing.Size(106, 17)
        Me.paletteSparkleOrange.TabIndex = 5
        Me.paletteSparkleOrange.Text = "Sparkle - Orange"
        Me.paletteSparkleOrange.UseVisualStyleBackColor = True
        Me.palette2010Black.AutoSize = True
        Me.palette2010Black.Location = New System.Drawing.Point(22, 77)
        Me.palette2010Black.Name = "palette2010Black"
        Me.palette2010Black.Size = New System.Drawing.Size(115, 17)
        Me.palette2010Black.TabIndex = 4
        Me.palette2010Black.Text = "Office 2010 - Black"
        Me.palette2010Black.UseVisualStyleBackColor = True
        Me.palette2010Silver.AutoSize = True
        Me.palette2010Silver.Location = New System.Drawing.Point(22, 54)
        Me.palette2010Silver.Name = "palette2010Silver"
        Me.palette2010Silver.Size = New System.Drawing.Size(117, 17)
        Me.palette2010Silver.TabIndex = 3
        Me.palette2010Silver.Text = "Office 2010 - Silver"
        Me.palette2010Silver.UseVisualStyleBackColor = True
        Me.paletteProfessional.AutoSize = True
        Me.paletteProfessional.Location = New System.Drawing.Point(171, 77)
        Me.paletteProfessional.Name = "paletteProfessional"
        Me.paletteProfessional.Size = New System.Drawing.Size(83, 17)
        Me.paletteProfessional.TabIndex = 2
        Me.paletteProfessional.Text = "Professional"
        Me.paletteProfessional.UseVisualStyleBackColor = True
        Me.palette2007Blue.AutoSize = True
        Me.palette2007Blue.Location = New System.Drawing.Point(171, 31)
        Me.palette2007Blue.Name = "palette2007Blue"
        Me.palette2007Blue.Size = New System.Drawing.Size(111, 17)
        Me.palette2007Blue.TabIndex = 1
        Me.palette2007Blue.Text = "Office 2007 - Blue"
        Me.palette2007Blue.UseVisualStyleBackColor = True
        Me.palette2010Blue.AutoSize = True
        Me.palette2010Blue.Checked = True
        Me.palette2010Blue.Location = New System.Drawing.Point(22, 31)
        Me.palette2010Blue.Name = "palette2010Blue"
        Me.palette2010Blue.Size = New System.Drawing.Size(111, 17)
        Me.palette2010Blue.TabIndex = 0
        Me.palette2010Blue.TabStop = True
        Me.palette2010Blue.Text = "Office 2010 - Blue"
        Me.palette2010Blue.UseVisualStyleBackColor = True
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6F, 13F)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(704, 416)
        Me.Controls.Add(Me.groupBoxPalette)
        Me.Controls.Add(Me.groupBox1)
        Me.Controls.Add(Me.groupBoxCheckBox)
        Me.Controls.Add(Me.groupBoxFooter)
        Me.Controls.Add(Me.groupBoxBasic)
        Me.Controls.Add(Me.buttonShowTaskDialog)
        Me.Font = New System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.MaximizeBox = False
        Me.MinimizeBox = False
        Me.Name = "Form1"
        Me.Text = "KryptonTaskDialog Examples"
        Me.groupBoxBasic.ResumeLayout(False)
        Me.groupBoxBasic.PerformLayout()
        Me.groupBoxFooter.ResumeLayout(False)
        Me.groupBoxFooter.PerformLayout()
        Me.groupBoxCheckBox.ResumeLayout(False)
        Me.groupBoxCheckBox.PerformLayout()
        Me.groupBox1.ResumeLayout(False)
        Me.groupBox1.PerformLayout()
        Me.groupBoxPalette.ResumeLayout(False)
        Me.groupBoxPalette.PerformLayout()
        Me.ResumeLayout(False)
    End Sub

    Friend WithEvents labelCaption As System.Windows.Forms.Label
    Friend WithEvents labelMainInstructions As System.Windows.Forms.Label
    Friend WithEvents labelContent As System.Windows.Forms.Label
    Friend WithEvents textBoxCaption As System.Windows.Forms.TextBox
    Friend WithEvents textBoxMainInstructions As System.Windows.Forms.TextBox
    Friend WithEvents textBoxContent As System.Windows.Forms.TextBox
    Friend WithEvents buttonShowTaskDialog As System.Windows.Forms.Button
    Friend WithEvents kryptonManager As Krypton.Toolkit.KryptonManager
    Friend WithEvents checkBoxOK As System.Windows.Forms.CheckBox
    Friend WithEvents checkBoxYes As System.Windows.Forms.CheckBox
    Friend WithEvents checkBoxNo As System.Windows.Forms.CheckBox
    Friend WithEvents checkBoxCancel As System.Windows.Forms.CheckBox
    Friend WithEvents checkBoxClose As System.Windows.Forms.CheckBox
    Friend WithEvents checkBoxRetry As System.Windows.Forms.CheckBox
    Friend WithEvents groupBoxBasic As System.Windows.Forms.GroupBox
    Friend WithEvents groupBoxFooter As System.Windows.Forms.GroupBox
    Friend WithEvents labelFooterText As System.Windows.Forms.Label
    Friend WithEvents labelFooterHyperlink As System.Windows.Forms.Label
    Friend WithEvents textBoxFooterText As System.Windows.Forms.TextBox
    Friend WithEvents textBoxFooterHyperlink As System.Windows.Forms.TextBox
    Friend WithEvents labelFooterIcon As System.Windows.Forms.Label
    Friend WithEvents comboBoxIcon As System.Windows.Forms.ComboBox
    Friend WithEvents labelIcon As System.Windows.Forms.Label
    Friend WithEvents comboBoxFooterIcon As System.Windows.Forms.ComboBox
    Friend WithEvents groupBoxCheckBox As System.Windows.Forms.GroupBox
    Friend WithEvents checkBoxInitialState As System.Windows.Forms.CheckBox
    Friend WithEvents label1 As System.Windows.Forms.Label
    Friend WithEvents textBoxCheckBoxText As System.Windows.Forms.TextBox
    Friend WithEvents groupBox1 As System.Windows.Forms.GroupBox
    Friend WithEvents checkBoxCommandButtons As System.Windows.Forms.CheckBox
    Friend WithEvents checkBoxRadioButtons As System.Windows.Forms.CheckBox
    Friend WithEvents groupBoxPalette As System.Windows.Forms.GroupBox
    Friend WithEvents paletteSparkleOrange As System.Windows.Forms.RadioButton
    Friend WithEvents palette2010Black As System.Windows.Forms.RadioButton
    Friend WithEvents palette2010Silver As System.Windows.Forms.RadioButton
    Friend WithEvents paletteProfessional As System.Windows.Forms.RadioButton
    Friend WithEvents palette2007Blue As System.Windows.Forms.RadioButton
    Friend WithEvents palette2010Blue As System.Windows.Forms.RadioButton
    Friend WithEvents buttonFill As System.Windows.Forms.Button
End Class
