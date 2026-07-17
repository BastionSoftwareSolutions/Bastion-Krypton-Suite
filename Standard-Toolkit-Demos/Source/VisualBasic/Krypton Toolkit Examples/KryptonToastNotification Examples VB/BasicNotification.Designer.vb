' VB.NET twin of Source\Krypton Toolkit Examples\KryptonToastNotification Examples\BasicNotification.Designer.cs (Bastion Phase 4c).
<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class BasicNotification
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(BasicNotification))
        Me.kryptonPanel1 = New Krypton.Toolkit.KryptonPanel()
        Me.kbtnShow = New Krypton.Toolkit.KryptonButton()
        Me.kryptonBorderEdge1 = New Krypton.Toolkit.KryptonBorderEdge()
        Me.kryptonPanel2 = New Krypton.Toolkit.KryptonPanel()
        Me.kcbBorderColor2 = New Krypton.Toolkit.KryptonColorButton()
        Me.kcbBorderColor1 = New Krypton.Toolkit.KryptonColorButton()
        Me.kryptonGroupBox2 = New Krypton.Toolkit.KryptonGroupBox()
        Me.kchkReportLocation = New Krypton.Toolkit.KryptonCheckBox()
        Me.kchkUseFade = New Krypton.Toolkit.KryptonCheckBox()
        Me.kchkTopMost = New Krypton.Toolkit.KryptonCheckBox()
        Me.kchkShowProgressBar = New Krypton.Toolkit.KryptonCheckBox()
        Me.kchkShowCloseBox = New Krypton.Toolkit.KryptonCheckBox()
        Me.kryptonGroupBox1 = New Krypton.Toolkit.KryptonGroupBox()
        Me.kcmbToastTitleAlignment = New Krypton.Toolkit.KryptonComboBox()
        Me.knudCountdownSeconds = New Krypton.Toolkit.KryptonNumericUpDown()
        Me.kryptonLabel5 = New Krypton.Toolkit.KryptonLabel()
        Me.kbtnTitleFont = New Krypton.Toolkit.KryptonButton()
        Me.kbtnContentFont = New Krypton.Toolkit.KryptonButton()
        Me.kryptonLabel4 = New Krypton.Toolkit.KryptonLabel()
        Me.ktxtCustomToastIconPath = New Krypton.Toolkit.KryptonTextBox()
        Me.kcmbToastIcon = New Krypton.Toolkit.KryptonComboBox()
        Me.kryptonLabel3 = New Krypton.Toolkit.KryptonLabel()
        Me.ktxtToastContent = New Krypton.Toolkit.KryptonTextBox()
        Me.ktxtToastTitle = New Krypton.Toolkit.KryptonTextBox()
        Me.kryptonLabel2 = New Krypton.Toolkit.KryptonLabel()
        Me.kryptonLabel1 = New Krypton.Toolkit.KryptonLabel()
        CType(Me.kryptonPanel1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.kryptonPanel1.SuspendLayout()
        CType(Me.kryptonPanel2, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.kryptonPanel2.SuspendLayout()
        CType(Me.kryptonGroupBox2, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.kryptonGroupBox2.Panel, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.kryptonGroupBox2.Panel.SuspendLayout()
        Me.kryptonGroupBox2.SuspendLayout()
        CType(Me.kryptonGroupBox1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.kryptonGroupBox1.Panel, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.kryptonGroupBox1.SuspendLayout()
        CType(Me.kcmbToastTitleAlignment, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.kcmbToastIcon, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        Me.kryptonPanel1.Controls.Add(Me.kbtnShow)
        Me.kryptonPanel1.Controls.Add(Me.kryptonBorderEdge1)
        Me.kryptonPanel1.Dock = System.Windows.Forms.DockStyle.Bottom
        Me.kryptonPanel1.Location = New System.Drawing.Point(0, 506)
        Me.kryptonPanel1.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.kryptonPanel1.Name = "kryptonPanel1"
        Me.kryptonPanel1.PanelBackStyle = Krypton.Toolkit.PaletteBackStyle.PanelAlternate
        Me.kryptonPanel1.Size = New System.Drawing.Size(1105, 62)
        Me.kryptonPanel1.TabIndex = 1
        Me.kbtnShow.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.kbtnShow.Location = New System.Drawing.Point(969, 16)
        Me.kbtnShow.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.kbtnShow.Name = "kbtnShow"
        Me.kbtnShow.Size = New System.Drawing.Size(120, 31)
        Me.kbtnShow.TabIndex = 1
        Me.kbtnShow.Values.DropDownArrowColor = System.Drawing.Color.Empty
        Me.kbtnShow.Values.Text = "Show"
        Me.kryptonBorderEdge1.BorderStyle = Krypton.Toolkit.PaletteBorderStyle.HeaderPrimary
        Me.kryptonBorderEdge1.Dock = System.Windows.Forms.DockStyle.Top
        Me.kryptonBorderEdge1.Location = New System.Drawing.Point(0, 0)
        Me.kryptonBorderEdge1.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.kryptonBorderEdge1.Name = "kryptonBorderEdge1"
        Me.kryptonBorderEdge1.Size = New System.Drawing.Size(1105, 1)
        Me.kryptonBorderEdge1.Text = "kryptonBorderEdge1"
        Me.kryptonPanel2.Controls.Add(Me.kcbBorderColor2)
        Me.kryptonPanel2.Controls.Add(Me.kcbBorderColor1)
        Me.kryptonPanel2.Controls.Add(Me.kryptonGroupBox2)
        Me.kryptonPanel2.Controls.Add(Me.kryptonGroupBox1)
        Me.kryptonPanel2.Controls.Add(Me.kcmbToastTitleAlignment)
        Me.kryptonPanel2.Controls.Add(Me.knudCountdownSeconds)
        Me.kryptonPanel2.Controls.Add(Me.kryptonLabel5)
        Me.kryptonPanel2.Controls.Add(Me.kbtnTitleFont)
        Me.kryptonPanel2.Controls.Add(Me.kbtnContentFont)
        Me.kryptonPanel2.Controls.Add(Me.kryptonLabel4)
        Me.kryptonPanel2.Controls.Add(Me.ktxtCustomToastIconPath)
        Me.kryptonPanel2.Controls.Add(Me.kcmbToastIcon)
        Me.kryptonPanel2.Controls.Add(Me.kryptonLabel3)
        Me.kryptonPanel2.Controls.Add(Me.ktxtToastContent)
        Me.kryptonPanel2.Controls.Add(Me.ktxtToastTitle)
        Me.kryptonPanel2.Controls.Add(Me.kryptonLabel2)
        Me.kryptonPanel2.Controls.Add(Me.kryptonLabel1)
        Me.kryptonPanel2.Dock = System.Windows.Forms.DockStyle.Fill
        Me.kryptonPanel2.Location = New System.Drawing.Point(0, 0)
        Me.kryptonPanel2.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.kryptonPanel2.Name = "kryptonPanel2"
        Me.kryptonPanel2.Size = New System.Drawing.Size(1105, 506)
        Me.kryptonPanel2.TabIndex = 2
        Me.kcbBorderColor2.CustomColorPreviewShape = Krypton.Toolkit.KryptonColorButtonCustomColorPreviewShape.Circle
        Me.kcbBorderColor2.Location = New System.Drawing.Point(251, 390)
        Me.kcbBorderColor2.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.kcbBorderColor2.Name = "kcbBorderColor2"
        Me.kcbBorderColor2.Size = New System.Drawing.Size(228, 31)
        Me.kcbBorderColor2.TabIndex = 21
        Me.kcbBorderColor2.Values.Image = CType(resources.GetObject("kcbBorderColor2.Values.Image"), System.Drawing.Image)
        Me.kcbBorderColor2.Values.RoundedCorners = 8
        Me.kcbBorderColor2.Values.Text = "Border Color 2"
        Me.kcbBorderColor1.CustomColorPreviewShape = Krypton.Toolkit.KryptonColorButtonCustomColorPreviewShape.Circle
        Me.kcbBorderColor1.Location = New System.Drawing.Point(16, 390)
        Me.kcbBorderColor1.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.kcbBorderColor1.Name = "kcbBorderColor1"
        Me.kcbBorderColor1.Size = New System.Drawing.Size(228, 31)
        Me.kcbBorderColor1.TabIndex = 20
        Me.kcbBorderColor1.Values.Image = CType(resources.GetObject("kcbBorderColor1.Values.Image"), System.Drawing.Image)
        Me.kcbBorderColor1.Values.RoundedCorners = 8
        Me.kcbBorderColor1.Values.Text = "Border Color 1"
        Me.kryptonGroupBox2.Location = New System.Drawing.Point(488, 209)
        Me.kryptonGroupBox2.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.kryptonGroupBox2.Name = "kryptonGroupBox2"
        Me.kryptonGroupBox2.Panel.Controls.Add(Me.kchkReportLocation)
        Me.kryptonGroupBox2.Panel.Controls.Add(Me.kchkUseFade)
        Me.kryptonGroupBox2.Panel.Controls.Add(Me.kchkTopMost)
        Me.kryptonGroupBox2.Panel.Controls.Add(Me.kchkShowProgressBar)
        Me.kryptonGroupBox2.Panel.Controls.Add(Me.kchkShowCloseBox)
        Me.kryptonGroupBox2.Size = New System.Drawing.Size(587, 114)
        Me.kryptonGroupBox2.TabIndex = 19
        Me.kchkReportLocation.Location = New System.Drawing.Point(157, 49)
        Me.kchkReportLocation.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.kchkReportLocation.Name = "kchkReportLocation"
        Me.kchkReportLocation.Size = New System.Drawing.Size(174, 24)
        Me.kchkReportLocation.TabIndex = 18
        Me.kchkReportLocation.Values.Text = "Report Toast Location"
        Me.kchkUseFade.Location = New System.Drawing.Point(21, 16)
        Me.kchkUseFade.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.kchkUseFade.Name = "kchkUseFade"
        Me.kchkUseFade.Size = New System.Drawing.Size(87, 24)
        Me.kchkUseFade.TabIndex = 7
        Me.kchkUseFade.Values.Text = "Use Fade"
        Me.kchkTopMost.Checked = True
        Me.kchkTopMost.CheckState = System.Windows.Forms.CheckState.Checked
        Me.kchkTopMost.Location = New System.Drawing.Point(21, 49)
        Me.kchkTopMost.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.kchkTopMost.Name = "kchkTopMost"
        Me.kchkTopMost.Size = New System.Drawing.Size(90, 24)
        Me.kchkTopMost.TabIndex = 8
        Me.kchkTopMost.Values.Text = "Top Most"
        Me.kchkShowProgressBar.Location = New System.Drawing.Point(157, 16)
        Me.kchkShowProgressBar.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.kchkShowProgressBar.Name = "kchkShowProgressBar"
        Me.kchkShowProgressBar.Size = New System.Drawing.Size(151, 24)
        Me.kchkShowProgressBar.TabIndex = 17
        Me.kchkShowProgressBar.Values.Text = "Show Progress Bar"
        Me.kchkShowCloseBox.Location = New System.Drawing.Point(332, 16)
        Me.kchkShowCloseBox.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.kchkShowCloseBox.Name = "kchkShowCloseBox"
        Me.kchkShowCloseBox.Size = New System.Drawing.Size(132, 24)
        Me.kchkShowCloseBox.TabIndex = 9
        Me.kchkShowCloseBox.Values.Text = "Show Close Box"
        Me.kryptonGroupBox1.Location = New System.Drawing.Point(488, 16)
        Me.kryptonGroupBox1.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.kryptonGroupBox1.Name = "kryptonGroupBox1"
        Me.kryptonGroupBox1.Size = New System.Drawing.Size(587, 185)
        Me.kryptonGroupBox1.TabIndex = 18
        Me.kcmbToastTitleAlignment.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.kcmbToastTitleAlignment.DropDownWidth = 244
        Me.kcmbToastTitleAlignment.IntegralHeight = False
        Me.kcmbToastTitleAlignment.Location = New System.Drawing.Point(153, 272)
        Me.kcmbToastTitleAlignment.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.kcmbToastTitleAlignment.Name = "kcmbToastTitleAlignment"
        Me.kcmbToastTitleAlignment.Size = New System.Drawing.Size(325, 26)
        Me.kcmbToastTitleAlignment.StateCommon.ComboBox.Content.TextH = Krypton.Toolkit.PaletteRelativeAlign.Near
        Me.kcmbToastTitleAlignment.TabIndex = 16
        Me.knudCountdownSeconds.Increment = New Decimal(New Integer() { 1, 0, 0, 0})
        Me.knudCountdownSeconds.Location = New System.Drawing.Point(256, 356)
        Me.knudCountdownSeconds.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.knudCountdownSeconds.Maximum = New Decimal(New Integer() { 180, 0, 0, 0})
        Me.knudCountdownSeconds.Minimum = New Decimal(New Integer() { 5, 0, 0, 0})
        Me.knudCountdownSeconds.Name = "knudCountdownSeconds"
        Me.knudCountdownSeconds.Size = New System.Drawing.Size(160, 26)
        Me.knudCountdownSeconds.TabIndex = 15
        Me.knudCountdownSeconds.Value = New Decimal(New Integer() { 60, 0, 0, 0})
        Me.kryptonLabel5.LabelStyle = Krypton.Toolkit.LabelStyle.BoldPanel
        Me.kryptonLabel5.Location = New System.Drawing.Point(17, 356)
        Me.kryptonLabel5.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.kryptonLabel5.Name = "kryptonLabel5"
        Me.kryptonLabel5.Size = New System.Drawing.Size(164, 24)
        Me.kryptonLabel5.TabIndex = 14
        Me.kryptonLabel5.Values.Text = "Countdown Seconds:"
        Me.kbtnTitleFont.AutoSize = True
        Me.kbtnTitleFont.Location = New System.Drawing.Point(277, 318)
        Me.kbtnTitleFont.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.kbtnTitleFont.Name = "kbtnTitleFont"
        Me.kbtnTitleFont.Size = New System.Drawing.Size(156, 34)
        Me.kbtnTitleFont.TabIndex = 13
        Me.kbtnTitleFont.Values.DropDownArrowColor = System.Drawing.Color.Empty
        Me.kbtnTitleFont.Values.Text = "Title Font"
        Me.kbtnContentFont.AutoSize = True
        Me.kbtnContentFont.Location = New System.Drawing.Point(113, 318)
        Me.kbtnContentFont.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.kbtnContentFont.Name = "kbtnContentFont"
        Me.kbtnContentFont.Size = New System.Drawing.Size(156, 34)
        Me.kbtnContentFont.TabIndex = 12
        Me.kbtnContentFont.Values.DropDownArrowColor = System.Drawing.Color.Empty
        Me.kbtnContentFont.Values.Text = "Content Font"
        Me.kryptonLabel4.LabelStyle = Krypton.Toolkit.LabelStyle.BoldPanel
        Me.kryptonLabel4.Location = New System.Drawing.Point(17, 272)
        Me.kryptonLabel4.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.kryptonLabel4.Name = "kryptonLabel4"
        Me.kryptonLabel4.Size = New System.Drawing.Size(129, 24)
        Me.kryptonLabel4.TabIndex = 10
        Me.kryptonLabel4.Values.Text = "Title Alignment:"
        Me.ktxtCustomToastIconPath.Enabled = False
        Me.ktxtCustomToastIconPath.Location = New System.Drawing.Point(113, 235)
        Me.ktxtCustomToastIconPath.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.ktxtCustomToastIconPath.Name = "ktxtCustomToastIconPath"
        Me.ktxtCustomToastIconPath.ShowEllipsisButton = True
        Me.ktxtCustomToastIconPath.Size = New System.Drawing.Size(365, 30)
        Me.ktxtCustomToastIconPath.TabIndex = 6
        Me.kcmbToastIcon.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.kcmbToastIcon.DropDownWidth = 274
        Me.kcmbToastIcon.IntegralHeight = False
        Me.kcmbToastIcon.Location = New System.Drawing.Point(113, 203)
        Me.kcmbToastIcon.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.kcmbToastIcon.Name = "kcmbToastIcon"
        Me.kcmbToastIcon.Size = New System.Drawing.Size(365, 26)
        Me.kcmbToastIcon.StateCommon.ComboBox.Content.TextH = Krypton.Toolkit.PaletteRelativeAlign.Near
        Me.kcmbToastIcon.TabIndex = 5
        Me.kryptonLabel3.LabelStyle = Krypton.Toolkit.LabelStyle.BoldPanel
        Me.kryptonLabel3.Location = New System.Drawing.Point(17, 203)
        Me.kryptonLabel3.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.kryptonLabel3.Name = "kryptonLabel3"
        Me.kryptonLabel3.Size = New System.Drawing.Size(47, 24)
        Me.kryptonLabel3.TabIndex = 4
        Me.kryptonLabel3.Values.Text = "Icon:"
        Me.ktxtToastContent.Location = New System.Drawing.Point(113, 50)
        Me.ktxtToastContent.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.ktxtToastContent.Multiline = True
        Me.ktxtToastContent.Name = "ktxtToastContent"
        Me.ktxtToastContent.Size = New System.Drawing.Size(365, 145)
        Me.ktxtToastContent.TabIndex = 3
        Me.ktxtToastContent.Text = "Put your message here..."
        Me.ktxtToastTitle.Location = New System.Drawing.Point(113, 16)
        Me.ktxtToastTitle.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.ktxtToastTitle.Name = "ktxtToastTitle"
        Me.ktxtToastTitle.Size = New System.Drawing.Size(365, 27)
        Me.ktxtToastTitle.TabIndex = 2
        Me.ktxtToastTitle.Text = "This is a test"
        Me.kryptonLabel2.LabelStyle = Krypton.Toolkit.LabelStyle.BoldPanel
        Me.kryptonLabel2.Location = New System.Drawing.Point(17, 48)
        Me.kryptonLabel2.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.kryptonLabel2.Name = "kryptonLabel2"
        Me.kryptonLabel2.Size = New System.Drawing.Size(48, 24)
        Me.kryptonLabel2.TabIndex = 1
        Me.kryptonLabel2.Values.Text = "Text:"
        Me.kryptonLabel1.LabelStyle = Krypton.Toolkit.LabelStyle.BoldPanel
        Me.kryptonLabel1.Location = New System.Drawing.Point(17, 16)
        Me.kryptonLabel1.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.kryptonLabel1.Name = "kryptonLabel1"
        Me.kryptonLabel1.Size = New System.Drawing.Size(48, 24)
        Me.kryptonLabel1.TabIndex = 0
        Me.kryptonLabel1.Values.Text = "Title:"
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8F, 16F)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(1105, 568)
        Me.Controls.Add(Me.kryptonPanel2)
        Me.Controls.Add(Me.kryptonPanel1)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.Fixed3D
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.MaximizeBox = False
        Me.MinimizeBox = False
        Me.Name = "BasicNotification"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Krypton Toast Notification"
        CType(Me.kryptonPanel1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.kryptonPanel1.ResumeLayout(False)
        Me.kryptonPanel1.PerformLayout()
        CType(Me.kryptonPanel2, System.ComponentModel.ISupportInitialize).EndInit()
        Me.kryptonPanel2.ResumeLayout(False)
        Me.kryptonPanel2.PerformLayout()
        CType(Me.kryptonGroupBox2.Panel, System.ComponentModel.ISupportInitialize).EndInit()
        Me.kryptonGroupBox2.Panel.ResumeLayout(False)
        Me.kryptonGroupBox2.Panel.PerformLayout()
        CType(Me.kryptonGroupBox2, System.ComponentModel.ISupportInitialize).EndInit()
        Me.kryptonGroupBox2.ResumeLayout(False)
        CType(Me.kryptonGroupBox1.Panel, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.kryptonGroupBox1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.kryptonGroupBox1.ResumeLayout(False)
        CType(Me.kcmbToastTitleAlignment, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.kcmbToastIcon, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
    End Sub

    Friend WithEvents kryptonPanel1 As Krypton.Toolkit.KryptonPanel
    Friend WithEvents kbtnShow As Krypton.Toolkit.KryptonButton
    Friend WithEvents kryptonBorderEdge1 As Krypton.Toolkit.KryptonBorderEdge
    Friend WithEvents kryptonPanel2 As Krypton.Toolkit.KryptonPanel
    Friend WithEvents kchkShowProgressBar As Krypton.Toolkit.KryptonCheckBox
    Friend WithEvents kcmbToastTitleAlignment As Krypton.Toolkit.KryptonComboBox
    Friend WithEvents knudCountdownSeconds As Krypton.Toolkit.KryptonNumericUpDown
    Friend WithEvents kryptonLabel5 As Krypton.Toolkit.KryptonLabel
    Friend WithEvents kbtnTitleFont As Krypton.Toolkit.KryptonButton
    Friend WithEvents kbtnContentFont As Krypton.Toolkit.KryptonButton
    Friend WithEvents kryptonLabel4 As Krypton.Toolkit.KryptonLabel
    Friend WithEvents kchkShowCloseBox As Krypton.Toolkit.KryptonCheckBox
    Friend WithEvents kchkTopMost As Krypton.Toolkit.KryptonCheckBox
    Friend WithEvents kchkUseFade As Krypton.Toolkit.KryptonCheckBox
    Friend WithEvents ktxtCustomToastIconPath As Krypton.Toolkit.KryptonTextBox
    Friend WithEvents kcmbToastIcon As Krypton.Toolkit.KryptonComboBox
    Friend WithEvents kryptonLabel3 As Krypton.Toolkit.KryptonLabel
    Friend WithEvents ktxtToastContent As Krypton.Toolkit.KryptonTextBox
    Friend WithEvents ktxtToastTitle As Krypton.Toolkit.KryptonTextBox
    Friend WithEvents kryptonLabel2 As Krypton.Toolkit.KryptonLabel
    Friend WithEvents kryptonLabel1 As Krypton.Toolkit.KryptonLabel
    Friend WithEvents kryptonGroupBox1 As Krypton.Toolkit.KryptonGroupBox
    Friend WithEvents kryptonGroupBox2 As Krypton.Toolkit.KryptonGroupBox
    Friend WithEvents kcbBorderColor1 As Krypton.Toolkit.KryptonColorButton
    Friend WithEvents kcbBorderColor2 As Krypton.Toolkit.KryptonColorButton
    Friend WithEvents kchkReportLocation As Krypton.Toolkit.KryptonCheckBox
End Class
