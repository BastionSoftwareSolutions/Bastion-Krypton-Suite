' VB.NET twin of Source\Krypton Toolkit Examples\KryptonMessageBox Examples\Form1.Designer.cs (Bastion Phase 4c).
<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class Form1
    Inherits Krypton.Toolkit.KryptonForm

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
        Me.label1 = New Krypton.Toolkit.KryptonLabel()
        Me.textBoxCaption = New Krypton.Toolkit.KryptonTextBox()
        Me.textBoxMessage = New System.Windows.Forms.TextBox()
        Me.radioButtonNone = New Krypton.Toolkit.KryptonRadioButton()
        Me.groupBoxIcon = New Krypton.Toolkit.KryptonGroupBox()
        Me.kcmbIcons = New Krypton.Toolkit.KryptonComboBox()
        Me.rbShield = New Krypton.Toolkit.KryptonRadioButton()
        Me.kradWinLogo = New Krypton.Toolkit.KryptonRadioButton()
        Me.kradQuestion = New Krypton.Toolkit.KryptonRadioButton()
        Me.kradError = New Krypton.Toolkit.KryptonRadioButton()
        Me.kradInformation = New Krypton.Toolkit.KryptonRadioButton()
        Me.kradWarning = New Krypton.Toolkit.KryptonRadioButton()
        Me.kryptonManager = New Krypton.Toolkit.KryptonManager(Me.components)
        Me.kryptonGroupBox1 = New Krypton.Toolkit.KryptonGroupBox()
        Me.kradYesNo = New Krypton.Toolkit.KryptonRadioButton()
        Me.kradCancelTryContinue = New Krypton.Toolkit.KryptonRadioButton()
        Me.kradRetryCancel = New Krypton.Toolkit.KryptonRadioButton()
        Me.kradOK = New Krypton.Toolkit.KryptonRadioButton()
        Me.kradYesNoCancel = New Krypton.Toolkit.KryptonRadioButton()
        Me.kradAbortRetryIgnore = New Krypton.Toolkit.KryptonRadioButton()
        Me.kradOKCancel = New Krypton.Toolkit.KryptonRadioButton()
        Me.kbtnShow = New Krypton.Toolkit.KryptonButton()
        Me.kryptonPanel1 = New Krypton.Toolkit.KryptonPanel()
        Me.kbtnDummyText = New Krypton.Toolkit.KryptonButton()
        Me.chkShowHelp = New Krypton.Toolkit.KryptonCheckBox()
        Me.kryptonThemeComboBox1 = New Krypton.Toolkit.KryptonThemeComboBox()
        Me.kchkRtlReading = New Krypton.Toolkit.KryptonCheckBox()
        Me.kchkRightAlign = New Krypton.Toolkit.KryptonCheckBox()
        Me.kryptonLabel1 = New Krypton.Toolkit.KryptonLabel()
        CType(Me.groupBoxIcon, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.groupBoxIcon.Panel, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.groupBoxIcon.Panel.SuspendLayout()
        Me.groupBoxIcon.SuspendLayout()
        CType(Me.kcmbIcons, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.kryptonGroupBox1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.kryptonGroupBox1.Panel, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.kryptonGroupBox1.Panel.SuspendLayout()
        Me.kryptonGroupBox1.SuspendLayout()
        CType(Me.kryptonPanel1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.kryptonPanel1.SuspendLayout()
        CType(Me.kryptonThemeComboBox1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        Me.label1.Location = New System.Drawing.Point(4, 21)
        Me.label1.Name = "label1"
        Me.label1.Size = New System.Drawing.Size(65, 24)
        Me.label1.TabIndex = 0
        Me.label1.Target = Me.textBoxCaption
        Me.label1.Values.Text = "&Caption"
        Me.textBoxCaption.CueHint.Padding = New System.Windows.Forms.Padding(0)
        Me.textBoxCaption.Location = New System.Drawing.Point(70, 21)
        Me.textBoxCaption.Name = "textBoxCaption"
        Me.textBoxCaption.Size = New System.Drawing.Size(246, 27)
        Me.textBoxCaption.TabIndex = 1
        Me.textBoxCaption.Text = "Caption"
        Me.textBoxMessage.Location = New System.Drawing.Point(70, 52)
        Me.textBoxMessage.Multiline = True
        Me.textBoxMessage.Name = "textBoxMessage"
        Me.textBoxMessage.Size = New System.Drawing.Size(246, 112)
        Me.textBoxMessage.TabIndex = 2
        Me.textBoxMessage.Text = "This is a message box!"
        Me.radioButtonNone.Location = New System.Drawing.Point(14, 3)
        Me.radioButtonNone.Name = "radioButtonNone"
        Me.radioButtonNone.Size = New System.Drawing.Size(61, 24)
        Me.radioButtonNone.TabIndex = 0
        Me.radioButtonNone.Tag = "0"
        Me.radioButtonNone.Values.Text = "&None"
        Me.groupBoxIcon.Location = New System.Drawing.Point(337, 181)
        Me.groupBoxIcon.Name = "groupBoxIcon"
        Me.groupBoxIcon.Panel.Controls.Add(Me.kcmbIcons)
        Me.groupBoxIcon.Panel.Controls.Add(Me.rbShield)
        Me.groupBoxIcon.Panel.Controls.Add(Me.kradWinLogo)
        Me.groupBoxIcon.Panel.Controls.Add(Me.kradQuestion)
        Me.groupBoxIcon.Panel.Controls.Add(Me.kradError)
        Me.groupBoxIcon.Panel.Controls.Add(Me.kradInformation)
        Me.groupBoxIcon.Panel.Controls.Add(Me.radioButtonNone)
        Me.groupBoxIcon.Panel.Controls.Add(Me.kradWarning)
        Me.groupBoxIcon.Size = New System.Drawing.Size(331, 172)
        Me.groupBoxIcon.TabIndex = 5
        Me.groupBoxIcon.Values.Heading = "Icon"
        Me.kcmbIcons.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.kcmbIcons.DropDownWidth = 298
        Me.kcmbIcons.IntegralHeight = False
        Me.kcmbIcons.Location = New System.Drawing.Point(14, 114)
        Me.kcmbIcons.Name = "kcmbIcons"
        Me.kcmbIcons.Size = New System.Drawing.Size(298, 26)
        Me.kcmbIcons.TabIndex = 7
        Me.rbShield.Location = New System.Drawing.Point(111, 29)
        Me.rbShield.Name = "rbShield"
        Me.rbShield.Size = New System.Drawing.Size(65, 24)
        Me.rbShield.TabIndex = 5
        Me.rbShield.Values.Text = "&Shield"
        Me.kradWinLogo.Location = New System.Drawing.Point(111, 53)
        Me.kradWinLogo.Name = "kradWinLogo"
        Me.kradWinLogo.Size = New System.Drawing.Size(85, 24)
        Me.kradWinLogo.TabIndex = 6
        Me.kradWinLogo.Values.Text = "Win&Logo"
        Me.kradQuestion.Location = New System.Drawing.Point(14, 53)
        Me.kradQuestion.Name = "kradQuestion"
        Me.kradQuestion.Size = New System.Drawing.Size(85, 24)
        Me.kradQuestion.TabIndex = 2
        Me.kradQuestion.Values.Text = "&Question"
        Me.kradError.Location = New System.Drawing.Point(14, 29)
        Me.kradError.Name = "kradError"
        Me.kradError.Size = New System.Drawing.Size(56, 24)
        Me.kradError.TabIndex = 1
        Me.kradError.Values.Text = "&Error"
        Me.kradInformation.Location = New System.Drawing.Point(111, 3)
        Me.kradInformation.Name = "kradInformation"
        Me.kradInformation.Size = New System.Drawing.Size(104, 24)
        Me.kradInformation.TabIndex = 4
        Me.kradInformation.Values.Text = "&Information"
        Me.kradWarning.Checked = True
        Me.kradWarning.Location = New System.Drawing.Point(14, 79)
        Me.kradWarning.Name = "kradWarning"
        Me.kradWarning.Size = New System.Drawing.Size(81, 24)
        Me.kradWarning.TabIndex = 3
        Me.kradWarning.Values.Text = "&Warning"
        Me.kryptonManager.GlobalPaletteMode = Krypton.Toolkit.PaletteMode.Office2007Blue
        Me.kryptonGroupBox1.Location = New System.Drawing.Point(4, 181)
        Me.kryptonGroupBox1.Name = "kryptonGroupBox1"
        Me.kryptonGroupBox1.Panel.Controls.Add(Me.kradYesNo)
        Me.kryptonGroupBox1.Panel.Controls.Add(Me.kradCancelTryContinue)
        Me.kryptonGroupBox1.Panel.Controls.Add(Me.kradRetryCancel)
        Me.kryptonGroupBox1.Panel.Controls.Add(Me.kradOK)
        Me.kryptonGroupBox1.Panel.Controls.Add(Me.kradYesNoCancel)
        Me.kryptonGroupBox1.Panel.Controls.Add(Me.kradAbortRetryIgnore)
        Me.kryptonGroupBox1.Panel.Controls.Add(Me.kradOKCancel)
        Me.kryptonGroupBox1.Size = New System.Drawing.Size(327, 136)
        Me.kryptonGroupBox1.TabIndex = 6
        Me.kryptonGroupBox1.Values.Heading = "Buttons"
        Me.kradYesNo.Location = New System.Drawing.Point(169, 55)
        Me.kradYesNo.Name = "kradYesNo"
        Me.kradYesNo.Size = New System.Drawing.Size(72, 24)
        Me.kradYesNo.TabIndex = 6
        Me.kradYesNo.Values.Text = "Yes No"
        Me.kradCancelTryContinue.Location = New System.Drawing.Point(14, 81)
        Me.kradCancelTryContinue.Name = "kradCancelTryContinue"
        Me.kradCancelTryContinue.Size = New System.Drawing.Size(160, 24)
        Me.kradCancelTryContinue.TabIndex = 3
        Me.kradCancelTryContinue.ToolTipValues.Description = "This option will only work if using .NET 6 or greater"
        Me.kradCancelTryContinue.ToolTipValues.EnableToolTips = True
        Me.kradCancelTryContinue.Values.Text = "Cancel Try Continue"
        Me.kradRetryCancel.Location = New System.Drawing.Point(14, 55)
        Me.kradRetryCancel.Name = "kradRetryCancel"
        Me.kradRetryCancel.Size = New System.Drawing.Size(108, 24)
        Me.kradRetryCancel.TabIndex = 2
        Me.kradRetryCancel.Values.Text = "Retry Cancel"
        Me.kradOK.Location = New System.Drawing.Point(14, 3)
        Me.kradOK.Name = "kradOK"
        Me.kradOK.Size = New System.Drawing.Size(44, 24)
        Me.kradOK.TabIndex = 0
        Me.kradOK.Values.Text = "OK"
        Me.kradYesNoCancel.Location = New System.Drawing.Point(169, 29)
        Me.kradYesNoCancel.Name = "kradYesNoCancel"
        Me.kradYesNoCancel.Size = New System.Drawing.Size(121, 24)
        Me.kradYesNoCancel.TabIndex = 5
        Me.kradYesNoCancel.Values.Text = "Yes No Cancel"
        Me.kradAbortRetryIgnore.Location = New System.Drawing.Point(169, 3)
        Me.kradAbortRetryIgnore.Name = "kradAbortRetryIgnore"
        Me.kradAbortRetryIgnore.Size = New System.Drawing.Size(151, 24)
        Me.kradAbortRetryIgnore.TabIndex = 4
        Me.kradAbortRetryIgnore.Values.Text = "Abort Retry Ignore"
        Me.kradOKCancel.Checked = True
        Me.kradOKCancel.Location = New System.Drawing.Point(14, 29)
        Me.kradOKCancel.Name = "kradOKCancel"
        Me.kradOKCancel.Size = New System.Drawing.Size(93, 24)
        Me.kradOKCancel.TabIndex = 1
        Me.kradOKCancel.Values.Text = "OK Cancel"
        Me.kbtnShow.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.kbtnShow.Location = New System.Drawing.Point(55, 375)
        Me.kbtnShow.Name = "kbtnShow"
        Me.kbtnShow.Size = New System.Drawing.Size(596, 57)
        Me.kbtnShow.TabIndex = 7
        Me.kbtnShow.Values.DropDownArrowColor = System.Drawing.Color.Empty
        Me.kbtnShow.Values.Text = "Show"
        Me.kryptonPanel1.Controls.Add(Me.kbtnDummyText)
        Me.kryptonPanel1.Controls.Add(Me.chkShowHelp)
        Me.kryptonPanel1.Controls.Add(Me.kbtnShow)
        Me.kryptonPanel1.Controls.Add(Me.kryptonThemeComboBox1)
        Me.kryptonPanel1.Controls.Add(Me.kchkRtlReading)
        Me.kryptonPanel1.Controls.Add(Me.kchkRightAlign)
        Me.kryptonPanel1.Controls.Add(Me.kryptonLabel1)
        Me.kryptonPanel1.Controls.Add(Me.label1)
        Me.kryptonPanel1.Controls.Add(Me.kryptonGroupBox1)
        Me.kryptonPanel1.Controls.Add(Me.groupBoxIcon)
        Me.kryptonPanel1.Dock = System.Windows.Forms.DockStyle.Fill
        Me.kryptonPanel1.Location = New System.Drawing.Point(0, 0)
        Me.kryptonPanel1.Name = "kryptonPanel1"
        Me.kryptonPanel1.Size = New System.Drawing.Size(694, 433)
        Me.kryptonPanel1.TabIndex = 0
        Me.kbtnDummyText.Location = New System.Drawing.Point(331, 154)
        Me.kbtnDummyText.Name = "kbtnDummyText"
        Me.kbtnDummyText.Size = New System.Drawing.Size(148, 26)
        Me.kbtnDummyText.TabIndex = 10
        Me.kbtnDummyText.Values.DropDownArrowColor = System.Drawing.Color.Empty
        Me.kbtnDummyText.Values.Text = "Insert Dummy Text"
        Me.chkShowHelp.Location = New System.Drawing.Point(331, 123)
        Me.chkShowHelp.Name = "chkShowHelp"
        Me.chkShowHelp.Size = New System.Drawing.Size(98, 24)
        Me.chkShowHelp.TabIndex = 8
        Me.chkShowHelp.Values.Text = "Show &Help"
        Me.kryptonThemeComboBox1.CueHint.Padding = New System.Windows.Forms.Padding(0)
        Me.kryptonThemeComboBox1.DefaultPalette = Krypton.Toolkit.PaletteMode.Office2007Blue
        Me.kryptonThemeComboBox1.DropDownWidth = 340
        Me.kryptonThemeComboBox1.IntegralHeight = False
        Me.kryptonThemeComboBox1.Location = New System.Drawing.Point(322, 23)
        Me.kryptonThemeComboBox1.Name = "kryptonThemeComboBox1"
        Me.kryptonThemeComboBox1.Size = New System.Drawing.Size(340, 26)
        Me.kryptonThemeComboBox1.StateCommon.ComboBox.Content.TextH = Krypton.Toolkit.PaletteRelativeAlign.Near
        Me.kryptonThemeComboBox1.TabIndex = 2
        Me.kchkRtlReading.Location = New System.Drawing.Point(331, 93)
        Me.kchkRtlReading.Name = "kchkRtlReading"
        Me.kchkRtlReading.Size = New System.Drawing.Size(241, 24)
        Me.kchkRtlReading.TabIndex = 4
        Me.kchkRtlReading.Values.Text = "MessageBoxOptions.RtlReading"
        Me.kchkRightAlign.Location = New System.Drawing.Point(331, 67)
        Me.kchkRightAlign.Name = "kchkRightAlign"
        Me.kchkRightAlign.Size = New System.Drawing.Size(238, 24)
        Me.kchkRightAlign.TabIndex = 3
        Me.kchkRightAlign.Values.Text = "MessageBoxOptions.RightAlign"
        Me.kryptonLabel1.Location = New System.Drawing.Point(3, 52)
        Me.kryptonLabel1.Name = "kryptonLabel1"
        Me.kryptonLabel1.Size = New System.Drawing.Size(72, 24)
        Me.kryptonLabel1.TabIndex = 1
        Me.kryptonLabel1.Target = Me.textBoxMessage
        Me.kryptonLabel1.Values.Text = "&Message"
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8F, 17F)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(694, 433)
        Me.Controls.Add(Me.textBoxMessage)
        Me.Controls.Add(Me.textBoxCaption)
        Me.Controls.Add(Me.kryptonPanel1)
        Me.Font = New System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.MaximizeBox = False
        Me.MinimizeBox = False
        Me.Name = "Form1"
        Me.Text = "KryptonMessageBox Examples"
        CType(Me.groupBoxIcon.Panel, System.ComponentModel.ISupportInitialize).EndInit()
        Me.groupBoxIcon.Panel.ResumeLayout(False)
        Me.groupBoxIcon.Panel.PerformLayout()
        CType(Me.groupBoxIcon, System.ComponentModel.ISupportInitialize).EndInit()
        Me.groupBoxIcon.ResumeLayout(False)
        CType(Me.kcmbIcons, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.kryptonGroupBox1.Panel, System.ComponentModel.ISupportInitialize).EndInit()
        Me.kryptonGroupBox1.Panel.ResumeLayout(False)
        Me.kryptonGroupBox1.Panel.PerformLayout()
        CType(Me.kryptonGroupBox1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.kryptonGroupBox1.ResumeLayout(False)
        CType(Me.kryptonPanel1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.kryptonPanel1.ResumeLayout(False)
        Me.kryptonPanel1.PerformLayout()
        CType(Me.kryptonThemeComboBox1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()
    End Sub

    Friend WithEvents label1 As Krypton.Toolkit.KryptonLabel
    Friend WithEvents textBoxCaption As Krypton.Toolkit.KryptonTextBox
    Friend WithEvents textBoxMessage As System.Windows.Forms.TextBox
    Friend WithEvents radioButtonNone As Krypton.Toolkit.KryptonRadioButton
    Friend WithEvents groupBoxIcon As Krypton.Toolkit.KryptonGroupBox
    Friend WithEvents kryptonManager As Krypton.Toolkit.KryptonManager
    Friend WithEvents kradWinLogo As Krypton.Toolkit.KryptonRadioButton
    Friend WithEvents kradQuestion As Krypton.Toolkit.KryptonRadioButton
    Friend WithEvents kradError As Krypton.Toolkit.KryptonRadioButton
    Friend WithEvents kradInformation As Krypton.Toolkit.KryptonRadioButton
    Friend WithEvents kradWarning As Krypton.Toolkit.KryptonRadioButton
    Friend WithEvents kryptonGroupBox1 As Krypton.Toolkit.KryptonGroupBox
    Friend WithEvents kradYesNo As Krypton.Toolkit.KryptonRadioButton
    Friend WithEvents kradCancelTryContinue As Krypton.Toolkit.KryptonRadioButton
    Friend WithEvents kradRetryCancel As Krypton.Toolkit.KryptonRadioButton
    Friend WithEvents kradOK As Krypton.Toolkit.KryptonRadioButton
    Friend WithEvents kradYesNoCancel As Krypton.Toolkit.KryptonRadioButton
    Friend WithEvents kradAbortRetryIgnore As Krypton.Toolkit.KryptonRadioButton
    Friend WithEvents kradOKCancel As Krypton.Toolkit.KryptonRadioButton
    Friend WithEvents kbtnShow As Krypton.Toolkit.KryptonButton
    Friend WithEvents kryptonPanel1 As Krypton.Toolkit.KryptonPanel
    Friend WithEvents kryptonLabel1 As Krypton.Toolkit.KryptonLabel
    Friend WithEvents kchkRtlReading As Krypton.Toolkit.KryptonCheckBox
    Friend WithEvents kchkRightAlign As Krypton.Toolkit.KryptonCheckBox
    Friend WithEvents kryptonThemeComboBox1 As Krypton.Toolkit.KryptonThemeComboBox
    Friend WithEvents rbShield As Krypton.Toolkit.KryptonRadioButton
    Friend WithEvents chkShowHelp As Krypton.Toolkit.KryptonCheckBox
    Friend WithEvents kcmbIcons As Krypton.Toolkit.KryptonComboBox
    Friend WithEvents kbtnDummyText As Krypton.Toolkit.KryptonButton
End Class
