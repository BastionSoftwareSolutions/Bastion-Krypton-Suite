' VB.NET twin of Source\Krypton Toolkit Examples\KryptonToastNotification Examples\UserInputNotification.Designer.cs (Bastion Phase 4c).
<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class UserInputNotification
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(UserInputNotification))
        Me.kryptonPanel1 = New Krypton.Toolkit.KryptonPanel()
        Me.kbtnShow = New Krypton.Toolkit.KryptonButton()
        Me.kryptonBorderEdge1 = New Krypton.Toolkit.KryptonBorderEdge()
        Me.kryptonPanel2 = New Krypton.Toolkit.KryptonPanel()
        Me.kchkUseDefaultLocation = New Krypton.Toolkit.KryptonCheckBox()
        Me.knudYAxis = New Krypton.Toolkit.KryptonNumericUpDown()
        Me.kryptonLabel18 = New Krypton.Toolkit.KryptonLabel()
        Me.knudXAxis = New Krypton.Toolkit.KryptonNumericUpDown()
        Me.kryptonLabel17 = New Krypton.Toolkit.KryptonLabel()
        Me.kcmbOwner = New Krypton.Toolkit.KryptonComboBox()
        Me.kryptonLabel16 = New Krypton.Toolkit.KryptonLabel()
        Me.knudCountDownInterval = New Krypton.Toolkit.KryptonNumericUpDown()
        Me.kryptonLabel15 = New Krypton.Toolkit.KryptonLabel()
        Me.kbtnNotificationTitleFont = New Krypton.Toolkit.KryptonButton()
        Me.kbtnNotificationContentFont = New Krypton.Toolkit.KryptonButton()
        Me.kcbtnBorderColor2 = New Krypton.Toolkit.KryptonColorButton()
        Me.kcbtnBorderColor1 = New Krypton.Toolkit.KryptonColorButton()
        Me.kcmbNotificationContentAlignment = New Krypton.Toolkit.KryptonComboBox()
        Me.kcmbNotificationTitleAlignment = New Krypton.Toolkit.KryptonComboBox()
        Me.kryptonLabel14 = New Krypton.Toolkit.KryptonLabel()
        Me.kryptonLabel13 = New Krypton.Toolkit.KryptonLabel()
        Me.kcmbDoNotShowAgainOptionCheckState = New Krypton.Toolkit.KryptonComboBox()
        Me.kryptonLabel12 = New Krypton.Toolkit.KryptonLabel()
        Me.kdtpInitialDate = New Krypton.Toolkit.KryptonDateTimePicker()
        Me.kryptonLabel11 = New Krypton.Toolkit.KryptonLabel()
        Me.kdtpMinimumDate = New Krypton.Toolkit.KryptonDateTimePicker()
        Me.kryptonLabel10 = New Krypton.Toolkit.KryptonLabel()
        Me.kdtpMaximumDate = New Krypton.Toolkit.KryptonDateTimePicker()
        Me.kryptonLabel9 = New Krypton.Toolkit.KryptonLabel()
        Me.knudCountdownSeconds = New Krypton.Toolkit.KryptonNumericUpDown()
        Me.kryptonLabel8 = New Krypton.Toolkit.KryptonLabel()
        Me.kryptonGroupBox2 = New Krypton.Toolkit.KryptonGroupBox()
        Me.kchkShowWithProgressBar = New Krypton.Toolkit.KryptonCheckBox()
        Me.kchkUseRTLReading = New Krypton.Toolkit.KryptonCheckBox()
        Me.kchkIsDoNotShowAgainOptionChecked = New Krypton.Toolkit.KryptonCheckBox()
        Me.kchkUseDoNotShowAgainOptionThreeState = New Krypton.Toolkit.KryptonCheckBox()
        Me.kchkFocusOnUserInputArea = New Krypton.Toolkit.KryptonCheckBox()
        Me.kchkShowDoNotShowAgainOption = New Krypton.Toolkit.KryptonCheckBox()
        Me.kchkReportLocation = New Krypton.Toolkit.KryptonCheckBox()
        Me.kchkUseFade = New Krypton.Toolkit.KryptonCheckBox()
        Me.kchkTopMost = New Krypton.Toolkit.KryptonCheckBox()
        Me.kchkShowCloseBox = New Krypton.Toolkit.KryptonCheckBox()
        Me.krtxtItemList = New Krypton.Toolkit.KryptonRichTextBox()
        Me.kryptonLabel7 = New Krypton.Toolkit.KryptonLabel()
        Me.kcolCueColor = New Krypton.Toolkit.KryptonColorButton()
        Me.ktxtInputCueText = New Krypton.Toolkit.KryptonTextBox()
        Me.kryptonLabel6 = New Krypton.Toolkit.KryptonLabel()
        Me.kcmbDropDownStyle = New Krypton.Toolkit.KryptonComboBox()
        Me.kryptonLabel5 = New Krypton.Toolkit.KryptonLabel()
        Me.kcmbNotificationInputStyle = New Krypton.Toolkit.KryptonComboBox()
        Me.kryptonLabel4 = New Krypton.Toolkit.KryptonLabel()
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
        CType(Me.kcmbOwner, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.kcmbNotificationContentAlignment, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.kcmbNotificationTitleAlignment, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.kcmbDoNotShowAgainOptionCheckState, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.kryptonGroupBox2, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.kryptonGroupBox2.Panel, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.kryptonGroupBox2.Panel.SuspendLayout()
        Me.kryptonGroupBox2.SuspendLayout()
        CType(Me.kcmbDropDownStyle, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.kcmbNotificationInputStyle, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.kcmbToastIcon, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        Me.kryptonPanel1.Controls.Add(Me.kbtnShow)
        Me.kryptonPanel1.Controls.Add(Me.kryptonBorderEdge1)
        Me.kryptonPanel1.Dock = System.Windows.Forms.DockStyle.Bottom
        Me.kryptonPanel1.Location = New System.Drawing.Point(0, 802)
        Me.kryptonPanel1.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.kryptonPanel1.Name = "kryptonPanel1"
        Me.kryptonPanel1.PanelBackStyle = Krypton.Toolkit.PaletteBackStyle.PanelAlternate
        Me.kryptonPanel1.Size = New System.Drawing.Size(1539, 62)
        Me.kryptonPanel1.TabIndex = 0
        Me.kbtnShow.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.kbtnShow.Location = New System.Drawing.Point(1403, 16)
        Me.kbtnShow.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.kbtnShow.Name = "kbtnShow"
        Me.kbtnShow.Size = New System.Drawing.Size(120, 31)
        Me.kbtnShow.TabIndex = 1
        Me.kbtnShow.Values.DropDownArrowColor = System.Drawing.Color.Empty
        Me.kbtnShow.Values.Text = "&Show"
        Me.kryptonBorderEdge1.BorderStyle = Krypton.Toolkit.PaletteBorderStyle.HeaderSecondary
        Me.kryptonBorderEdge1.Dock = System.Windows.Forms.DockStyle.Top
        Me.kryptonBorderEdge1.Location = New System.Drawing.Point(0, 0)
        Me.kryptonBorderEdge1.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.kryptonBorderEdge1.Name = "kryptonBorderEdge1"
        Me.kryptonBorderEdge1.Size = New System.Drawing.Size(1539, 1)
        Me.kryptonBorderEdge1.Text = "kryptonBorderEdge1"
        Me.kryptonPanel2.Controls.Add(Me.kchkUseDefaultLocation)
        Me.kryptonPanel2.Controls.Add(Me.knudYAxis)
        Me.kryptonPanel2.Controls.Add(Me.kryptonLabel18)
        Me.kryptonPanel2.Controls.Add(Me.knudXAxis)
        Me.kryptonPanel2.Controls.Add(Me.kryptonLabel17)
        Me.kryptonPanel2.Controls.Add(Me.kcmbOwner)
        Me.kryptonPanel2.Controls.Add(Me.kryptonLabel16)
        Me.kryptonPanel2.Controls.Add(Me.knudCountDownInterval)
        Me.kryptonPanel2.Controls.Add(Me.kryptonLabel15)
        Me.kryptonPanel2.Controls.Add(Me.kbtnNotificationTitleFont)
        Me.kryptonPanel2.Controls.Add(Me.kbtnNotificationContentFont)
        Me.kryptonPanel2.Controls.Add(Me.kcbtnBorderColor2)
        Me.kryptonPanel2.Controls.Add(Me.kcbtnBorderColor1)
        Me.kryptonPanel2.Controls.Add(Me.kcmbNotificationContentAlignment)
        Me.kryptonPanel2.Controls.Add(Me.kcmbNotificationTitleAlignment)
        Me.kryptonPanel2.Controls.Add(Me.kryptonLabel14)
        Me.kryptonPanel2.Controls.Add(Me.kryptonLabel13)
        Me.kryptonPanel2.Controls.Add(Me.kcmbDoNotShowAgainOptionCheckState)
        Me.kryptonPanel2.Controls.Add(Me.kryptonLabel12)
        Me.kryptonPanel2.Controls.Add(Me.kdtpInitialDate)
        Me.kryptonPanel2.Controls.Add(Me.kryptonLabel11)
        Me.kryptonPanel2.Controls.Add(Me.kdtpMinimumDate)
        Me.kryptonPanel2.Controls.Add(Me.kryptonLabel10)
        Me.kryptonPanel2.Controls.Add(Me.kdtpMaximumDate)
        Me.kryptonPanel2.Controls.Add(Me.kryptonLabel9)
        Me.kryptonPanel2.Controls.Add(Me.knudCountdownSeconds)
        Me.kryptonPanel2.Controls.Add(Me.kryptonLabel8)
        Me.kryptonPanel2.Controls.Add(Me.kryptonGroupBox2)
        Me.kryptonPanel2.Controls.Add(Me.krtxtItemList)
        Me.kryptonPanel2.Controls.Add(Me.kryptonLabel7)
        Me.kryptonPanel2.Controls.Add(Me.kcolCueColor)
        Me.kryptonPanel2.Controls.Add(Me.ktxtInputCueText)
        Me.kryptonPanel2.Controls.Add(Me.kryptonLabel6)
        Me.kryptonPanel2.Controls.Add(Me.kcmbDropDownStyle)
        Me.kryptonPanel2.Controls.Add(Me.kryptonLabel5)
        Me.kryptonPanel2.Controls.Add(Me.kcmbNotificationInputStyle)
        Me.kryptonPanel2.Controls.Add(Me.kryptonLabel4)
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
        Me.kryptonPanel2.Size = New System.Drawing.Size(1539, 802)
        Me.kryptonPanel2.TabIndex = 1
        Me.kchkUseDefaultLocation.Location = New System.Drawing.Point(609, 682)
        Me.kchkUseDefaultLocation.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.kchkUseDefaultLocation.Name = "kchkUseDefaultLocation"
        Me.kchkUseDefaultLocation.Size = New System.Drawing.Size(166, 24)
        Me.kchkUseDefaultLocation.TabIndex = 46
        Me.kchkUseDefaultLocation.Values.Text = "Use Default Location"
        Me.knudYAxis.Increment = New Decimal(New Integer() { 1, 0, 0, 0})
        Me.knudYAxis.Location = New System.Drawing.Point(816, 646)
        Me.knudYAxis.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.knudYAxis.Maximum = New Decimal(New Integer() { 100, 0, 0, 0})
        Me.knudYAxis.Minimum = New Decimal(New Integer() { 0, 0, 0, 0})
        Me.knudYAxis.Name = "knudYAxis"
        Me.knudYAxis.Size = New System.Drawing.Size(160, 26)
        Me.knudYAxis.TabIndex = 45
        Me.knudYAxis.Value = New Decimal(New Integer() { 0, 0, 0, 0})
        Me.kryptonLabel18.LabelStyle = Krypton.Toolkit.LabelStyle.BoldPanel
        Me.kryptonLabel18.Location = New System.Drawing.Point(779, 646)
        Me.kryptonLabel18.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.kryptonLabel18.Name = "kryptonLabel18"
        Me.kryptonLabel18.Size = New System.Drawing.Size(25, 24)
        Me.kryptonLabel18.TabIndex = 44
        Me.kryptonLabel18.Values.Text = "Y:"
        Me.knudXAxis.Increment = New Decimal(New Integer() { 1, 0, 0, 0})
        Me.knudXAxis.Location = New System.Drawing.Point(609, 646)
        Me.knudXAxis.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.knudXAxis.Maximum = New Decimal(New Integer() { 100, 0, 0, 0})
        Me.knudXAxis.Minimum = New Decimal(New Integer() { 0, 0, 0, 0})
        Me.knudXAxis.Name = "knudXAxis"
        Me.knudXAxis.Size = New System.Drawing.Size(160, 26)
        Me.knudXAxis.TabIndex = 43
        Me.knudXAxis.Value = New Decimal(New Integer() { 0, 0, 0, 0})
        Me.kryptonLabel17.LabelStyle = Krypton.Toolkit.LabelStyle.BoldPanel
        Me.kryptonLabel17.Location = New System.Drawing.Point(497, 646)
        Me.kryptonLabel17.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.kryptonLabel17.Name = "kryptonLabel17"
        Me.kryptonLabel17.Size = New System.Drawing.Size(97, 24)
        Me.kryptonLabel17.TabIndex = 42
        Me.kryptonLabel17.Values.Text = "Location: X:"
        Me.kcmbOwner.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.kcmbOwner.DropDownWidth = 274
        Me.kcmbOwner.IntegralHeight = False
        Me.kcmbOwner.Location = New System.Drawing.Point(609, 594)
        Me.kcmbOwner.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.kcmbOwner.Name = "kcmbOwner"
        Me.kcmbOwner.Size = New System.Drawing.Size(365, 26)
        Me.kcmbOwner.StateCommon.ComboBox.Content.TextH = Krypton.Toolkit.PaletteRelativeAlign.Near
        Me.kcmbOwner.TabIndex = 41
        Me.kryptonLabel16.LabelStyle = Krypton.Toolkit.LabelStyle.BoldPanel
        Me.kryptonLabel16.Location = New System.Drawing.Point(497, 594)
        Me.kryptonLabel16.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.kryptonLabel16.Name = "kryptonLabel16"
        Me.kryptonLabel16.Size = New System.Drawing.Size(64, 24)
        Me.kryptonLabel16.TabIndex = 40
        Me.kryptonLabel16.Values.Text = "Owner:"
        Me.knudCountDownInterval.Increment = New Decimal(New Integer() { 1, 0, 0, 0})
        Me.knudCountDownInterval.Location = New System.Drawing.Point(609, 544)
        Me.knudCountDownInterval.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.knudCountDownInterval.Maximum = New Decimal(New Integer() { 5000, 0, 0, 0})
        Me.knudCountDownInterval.Minimum = New Decimal(New Integer() { 10, 0, 0, 0})
        Me.knudCountDownInterval.Name = "knudCountDownInterval"
        Me.knudCountDownInterval.Size = New System.Drawing.Size(375, 26)
        Me.knudCountDownInterval.TabIndex = 39
        Me.knudCountDownInterval.Value = New Decimal(New Integer() { 1000, 0, 0, 0})
        Me.kryptonLabel15.LabelStyle = Krypton.Toolkit.LabelStyle.BoldPanel
        Me.kryptonLabel15.Location = New System.Drawing.Point(496, 523)
        Me.kryptonLabel15.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.kryptonLabel15.Name = "kryptonLabel15"
        Me.kryptonLabel15.Size = New System.Drawing.Size(96, 64)
        Me.kryptonLabel15.TabIndex = 38
        Me.kryptonLabel15.Values.Text = "Countdown" & vbCrLf & "Timer" & vbCrLf & "Interval:"
        Me.kbtnNotificationTitleFont.Location = New System.Drawing.Point(759, 479)
        Me.kbtnNotificationTitleFont.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.kbtnNotificationTitleFont.Name = "kbtnNotificationTitleFont"
        Me.kbtnNotificationTitleFont.Size = New System.Drawing.Size(253, 31)
        Me.kbtnNotificationTitleFont.TabIndex = 37
        Me.kbtnNotificationTitleFont.Values.DropDownArrowColor = System.Drawing.Color.Empty
        Me.kbtnNotificationTitleFont.Values.Text = "Notification Title Font"
        Me.kbtnNotificationContentFont.Location = New System.Drawing.Point(497, 479)
        Me.kbtnNotificationContentFont.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.kbtnNotificationContentFont.Name = "kbtnNotificationContentFont"
        Me.kbtnNotificationContentFont.Size = New System.Drawing.Size(253, 31)
        Me.kbtnNotificationContentFont.TabIndex = 36
        Me.kbtnNotificationContentFont.Values.DropDownArrowColor = System.Drawing.Color.Empty
        Me.kbtnNotificationContentFont.Values.Text = "Notification Content Font"
        Me.kcbtnBorderColor2.CustomColorPreviewShape = Krypton.Toolkit.KryptonColorButtonCustomColorPreviewShape.Circle
        Me.kcbtnBorderColor2.EmptyBorderColor = System.Drawing.Color.Empty
        Me.kcbtnBorderColor2.Location = New System.Drawing.Point(759, 439)
        Me.kcbtnBorderColor2.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.kcbtnBorderColor2.Name = "kcbtnBorderColor2"
        Me.kcbtnBorderColor2.SelectedColor = System.Drawing.Color.Empty
        Me.kcbtnBorderColor2.Size = New System.Drawing.Size(255, 31)
        Me.kcbtnBorderColor2.Splitter = False
        Me.kcbtnBorderColor2.TabIndex = 35
        Me.kcbtnBorderColor2.Values.Image = CType(resources.GetObject("kcbtnBorderColor2.Values.Image"), System.Drawing.Image)
        Me.kcbtnBorderColor2.Values.RoundedCorners = 8
        Me.kcbtnBorderColor2.Values.Text = "Border Color 2"
        Me.kcbtnBorderColor1.CustomColorPreviewShape = Krypton.Toolkit.KryptonColorButtonCustomColorPreviewShape.Circle
        Me.kcbtnBorderColor1.EmptyBorderColor = System.Drawing.Color.Empty
        Me.kcbtnBorderColor1.Location = New System.Drawing.Point(496, 439)
        Me.kcbtnBorderColor1.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.kcbtnBorderColor1.Name = "kcbtnBorderColor1"
        Me.kcbtnBorderColor1.SelectedColor = System.Drawing.Color.Empty
        Me.kcbtnBorderColor1.Size = New System.Drawing.Size(255, 31)
        Me.kcbtnBorderColor1.Splitter = False
        Me.kcbtnBorderColor1.TabIndex = 34
        Me.kcbtnBorderColor1.Values.Image = CType(resources.GetObject("kcbtnBorderColor1.Values.Image"), System.Drawing.Image)
        Me.kcbtnBorderColor1.Values.RoundedCorners = 8
        Me.kcbtnBorderColor1.Values.Text = "Border Color 1"
        Me.kcmbNotificationContentAlignment.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.kcmbNotificationContentAlignment.DropDownWidth = 274
        Me.kcmbNotificationContentAlignment.IntegralHeight = False
        Me.kcmbNotificationContentAlignment.Location = New System.Drawing.Point(619, 377)
        Me.kcmbNotificationContentAlignment.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.kcmbNotificationContentAlignment.Name = "kcmbNotificationContentAlignment"
        Me.kcmbNotificationContentAlignment.Size = New System.Drawing.Size(365, 26)
        Me.kcmbNotificationContentAlignment.StateCommon.ComboBox.Content.TextH = Krypton.Toolkit.PaletteRelativeAlign.Near
        Me.kcmbNotificationContentAlignment.TabIndex = 33
        Me.kcmbNotificationTitleAlignment.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.kcmbNotificationTitleAlignment.DropDownWidth = 274
        Me.kcmbNotificationTitleAlignment.IntegralHeight = False
        Me.kcmbNotificationTitleAlignment.Location = New System.Drawing.Point(619, 306)
        Me.kcmbNotificationTitleAlignment.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.kcmbNotificationTitleAlignment.Name = "kcmbNotificationTitleAlignment"
        Me.kcmbNotificationTitleAlignment.Size = New System.Drawing.Size(365, 26)
        Me.kcmbNotificationTitleAlignment.StateCommon.ComboBox.Content.TextH = Krypton.Toolkit.PaletteRelativeAlign.Near
        Me.kcmbNotificationTitleAlignment.TabIndex = 32
        Me.kryptonLabel14.LabelStyle = Krypton.Toolkit.LabelStyle.BoldPanel
        Me.kryptonLabel14.Location = New System.Drawing.Point(496, 366)
        Me.kryptonLabel14.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.kryptonLabel14.Name = "kryptonLabel14"
        Me.kryptonLabel14.Size = New System.Drawing.Size(99, 64)
        Me.kryptonLabel14.TabIndex = 31
        Me.kryptonLabel14.Values.Text = "Notification" & vbCrLf & "Content" & vbCrLf & "Alignment:"
        Me.kryptonLabel13.LabelStyle = Krypton.Toolkit.LabelStyle.BoldPanel
        Me.kryptonLabel13.Location = New System.Drawing.Point(497, 294)
        Me.kryptonLabel13.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.kryptonLabel13.Name = "kryptonLabel13"
        Me.kryptonLabel13.Size = New System.Drawing.Size(99, 64)
        Me.kryptonLabel13.TabIndex = 30
        Me.kryptonLabel13.Values.Text = "Notification" & vbCrLf & "Title" & vbCrLf & "Alignment:"
        Me.kcmbDoNotShowAgainOptionCheckState.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.kcmbDoNotShowAgainOptionCheckState.DropDownWidth = 274
        Me.kcmbDoNotShowAgainOptionCheckState.IntegralHeight = False
        Me.kcmbDoNotShowAgainOptionCheckState.Location = New System.Drawing.Point(619, 220)
        Me.kcmbDoNotShowAgainOptionCheckState.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.kcmbDoNotShowAgainOptionCheckState.Name = "kcmbDoNotShowAgainOptionCheckState"
        Me.kcmbDoNotShowAgainOptionCheckState.Size = New System.Drawing.Size(365, 26)
        Me.kcmbDoNotShowAgainOptionCheckState.StateCommon.ComboBox.Content.TextH = Krypton.Toolkit.PaletteRelativeAlign.Near
        Me.kcmbDoNotShowAgainOptionCheckState.TabIndex = 29
        Me.kryptonLabel12.LabelStyle = Krypton.Toolkit.LabelStyle.BoldPanel
        Me.kryptonLabel12.Location = New System.Drawing.Point(497, 202)
        Me.kryptonLabel12.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.kryptonLabel12.Name = "kryptonLabel12"
        Me.kryptonLabel12.Size = New System.Drawing.Size(105, 84)
        Me.kryptonLabel12.TabIndex = 28
        Me.kryptonLabel12.Values.Text = """Do Not" & vbCrLf & "Show Again""" & vbCrLf & "Option" & vbCrLf & "Check State:"
        Me.kdtpInitialDate.Location = New System.Drawing.Point(117, 762)
        Me.kdtpInitialDate.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.kdtpInitialDate.Name = "kdtpInitialDate"
        Me.kdtpInitialDate.Size = New System.Drawing.Size(371, 25)
        Me.kdtpInitialDate.TabIndex = 27
        Me.kdtpInitialDate.ValueNullable = New System.DateTime(2024, 4, 20, 0, 0, 0, 0)
        Me.kryptonLabel11.LabelStyle = Krypton.Toolkit.LabelStyle.BoldPanel
        Me.kryptonLabel11.Location = New System.Drawing.Point(16, 750)
        Me.kryptonLabel11.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.kryptonLabel11.Name = "kryptonLabel11"
        Me.kryptonLabel11.Size = New System.Drawing.Size(53, 44)
        Me.kryptonLabel11.TabIndex = 26
        Me.kryptonLabel11.Values.Text = "Initial" & vbCrLf & "Date:"
        Me.kdtpMinimumDate.Location = New System.Drawing.Point(117, 710)
        Me.kdtpMinimumDate.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.kdtpMinimumDate.Name = "kdtpMinimumDate"
        Me.kdtpMinimumDate.Size = New System.Drawing.Size(371, 25)
        Me.kdtpMinimumDate.TabIndex = 25
        Me.kdtpMinimumDate.ValueNullable = New System.DateTime(1753, 1, 1, 8, 14, 0, 0)
        Me.kryptonLabel10.LabelStyle = Krypton.Toolkit.LabelStyle.BoldPanel
        Me.kryptonLabel10.Location = New System.Drawing.Point(16, 698)
        Me.kryptonLabel10.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.kryptonLabel10.Name = "kryptonLabel10"
        Me.kryptonLabel10.Size = New System.Drawing.Size(82, 44)
        Me.kryptonLabel10.TabIndex = 24
        Me.kryptonLabel10.Values.Text = "Minimum" & vbCrLf & "Date:"
        Me.kdtpMaximumDate.Location = New System.Drawing.Point(117, 658)
        Me.kdtpMaximumDate.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.kdtpMaximumDate.Name = "kdtpMaximumDate"
        Me.kdtpMaximumDate.Size = New System.Drawing.Size(371, 25)
        Me.kdtpMaximumDate.TabIndex = 23
        Me.kdtpMaximumDate.ValueNullable = New System.DateTime(9998, 12, 31, 8, 14, 0, 0)
        Me.kryptonLabel9.LabelStyle = Krypton.Toolkit.LabelStyle.BoldPanel
        Me.kryptonLabel9.Location = New System.Drawing.Point(16, 646)
        Me.kryptonLabel9.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.kryptonLabel9.Name = "kryptonLabel9"
        Me.kryptonLabel9.Size = New System.Drawing.Size(85, 44)
        Me.kryptonLabel9.TabIndex = 22
        Me.kryptonLabel9.Values.Text = "Maximum" & vbCrLf & "Date:"
        Me.knudCountdownSeconds.Increment = New Decimal(New Integer() { 1, 0, 0, 0})
        Me.knudCountdownSeconds.Location = New System.Drawing.Point(128, 603)
        Me.knudCountdownSeconds.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.knudCountdownSeconds.Maximum = New Decimal(New Integer() { 180, 0, 0, 0})
        Me.knudCountdownSeconds.Minimum = New Decimal(New Integer() { 5, 0, 0, 0})
        Me.knudCountdownSeconds.Name = "knudCountdownSeconds"
        Me.knudCountdownSeconds.Size = New System.Drawing.Size(360, 26)
        Me.knudCountdownSeconds.TabIndex = 20
        Me.knudCountdownSeconds.Value = New Decimal(New Integer() { 60, 0, 0, 0})
        Me.kryptonLabel8.LabelStyle = Krypton.Toolkit.LabelStyle.BoldPanel
        Me.kryptonLabel8.Location = New System.Drawing.Point(16, 594)
        Me.kryptonLabel8.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.kryptonLabel8.Name = "kryptonLabel8"
        Me.kryptonLabel8.Size = New System.Drawing.Size(96, 44)
        Me.kryptonLabel8.TabIndex = 19
        Me.kryptonLabel8.Values.Text = "Countdown " & vbCrLf & "Seconds:"
        Me.kryptonGroupBox2.Location = New System.Drawing.Point(496, 15)
        Me.kryptonGroupBox2.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.kryptonGroupBox2.Name = "kryptonGroupBox2"
        Me.kryptonGroupBox2.Panel.Controls.Add(Me.kchkShowWithProgressBar)
        Me.kryptonGroupBox2.Panel.Controls.Add(Me.kchkUseRTLReading)
        Me.kryptonGroupBox2.Panel.Controls.Add(Me.kchkIsDoNotShowAgainOptionChecked)
        Me.kryptonGroupBox2.Panel.Controls.Add(Me.kchkUseDoNotShowAgainOptionThreeState)
        Me.kryptonGroupBox2.Panel.Controls.Add(Me.kchkFocusOnUserInputArea)
        Me.kryptonGroupBox2.Panel.Controls.Add(Me.kchkShowDoNotShowAgainOption)
        Me.kryptonGroupBox2.Panel.Controls.Add(Me.kchkReportLocation)
        Me.kryptonGroupBox2.Panel.Controls.Add(Me.kchkUseFade)
        Me.kryptonGroupBox2.Panel.Controls.Add(Me.kchkTopMost)
        Me.kryptonGroupBox2.Panel.Controls.Add(Me.kchkShowCloseBox)
        Me.kryptonGroupBox2.Size = New System.Drawing.Size(620, 180)
        Me.kryptonGroupBox2.TabIndex = 21
        Me.kchkShowWithProgressBar.Enabled = False
        Me.kchkShowWithProgressBar.Location = New System.Drawing.Point(357, 114)
        Me.kchkShowWithProgressBar.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.kchkShowWithProgressBar.Name = "kchkShowWithProgressBar"
        Me.kchkShowWithProgressBar.Size = New System.Drawing.Size(184, 24)
        Me.kchkShowWithProgressBar.TabIndex = 24
        Me.kchkShowWithProgressBar.Values.Text = "Show with Progress Bar"
        Me.kchkUseRTLReading.Enabled = False
        Me.kchkUseRTLReading.Location = New System.Drawing.Point(379, 81)
        Me.kchkUseRTLReading.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.kchkUseRTLReading.Name = "kchkUseRTLReading"
        Me.kchkUseRTLReading.Size = New System.Drawing.Size(139, 24)
        Me.kchkUseRTLReading.TabIndex = 23
        Me.kchkUseRTLReading.Values.Text = "Use RTL Reading"
        Me.kchkIsDoNotShowAgainOptionChecked.Enabled = False
        Me.kchkIsDoNotShowAgainOptionChecked.Location = New System.Drawing.Point(21, 113)
        Me.kchkIsDoNotShowAgainOptionChecked.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.kchkIsDoNotShowAgainOptionChecked.Name = "kchkIsDoNotShowAgainOptionChecked"
        Me.kchkIsDoNotShowAgainOptionChecked.Size = New System.Drawing.Size(301, 24)
        Me.kchkIsDoNotShowAgainOptionChecked.TabIndex = 22
        Me.kchkIsDoNotShowAgainOptionChecked.Values.Text = "Is ""Do Not Show Again Option"" Checked"
        Me.kchkUseDoNotShowAgainOptionThreeState.Enabled = False
        Me.kchkUseDoNotShowAgainOptionThreeState.Location = New System.Drawing.Point(21, 81)
        Me.kchkUseDoNotShowAgainOptionThreeState.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.kchkUseDoNotShowAgainOptionThreeState.Name = "kchkUseDoNotShowAgainOptionThreeState"
        Me.kchkUseDoNotShowAgainOptionThreeState.Size = New System.Drawing.Size(334, 24)
        Me.kchkUseDoNotShowAgainOptionThreeState.TabIndex = 21
        Me.kchkUseDoNotShowAgainOptionThreeState.Values.Text = "Use ""Do Not Show Again"" Option Three State"
        Me.kchkFocusOnUserInputArea.Location = New System.Drawing.Point(21, 48)
        Me.kchkFocusOnUserInputArea.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.kchkFocusOnUserInputArea.Name = "kchkFocusOnUserInputArea"
        Me.kchkFocusOnUserInputArea.Size = New System.Drawing.Size(196, 24)
        Me.kchkFocusOnUserInputArea.TabIndex = 20
        Me.kchkFocusOnUserInputArea.Values.Text = "Focus on User Input Area"
        Me.kchkShowDoNotShowAgainOption.Enabled = False
        Me.kchkShowDoNotShowAgainOption.Location = New System.Drawing.Point(244, 48)
        Me.kchkShowDoNotShowAgainOption.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.kchkShowDoNotShowAgainOption.Name = "kchkShowDoNotShowAgainOption"
        Me.kchkShowDoNotShowAgainOption.Size = New System.Drawing.Size(265, 24)
        Me.kchkShowDoNotShowAgainOption.TabIndex = 19
        Me.kchkShowDoNotShowAgainOption.Values.Text = "Show ""Do Not Show Again"" Option"
        Me.kchkReportLocation.Location = New System.Drawing.Point(391, 16)
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
        Me.kchkTopMost.Location = New System.Drawing.Point(281, 16)
        Me.kchkTopMost.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.kchkTopMost.Name = "kchkTopMost"
        Me.kchkTopMost.Size = New System.Drawing.Size(90, 24)
        Me.kchkTopMost.TabIndex = 8
        Me.kchkTopMost.Values.Text = "Top Most"
        Me.kchkShowCloseBox.Location = New System.Drawing.Point(127, 16)
        Me.kchkShowCloseBox.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.kchkShowCloseBox.Name = "kchkShowCloseBox"
        Me.kchkShowCloseBox.Size = New System.Drawing.Size(132, 24)
        Me.kchkShowCloseBox.TabIndex = 9
        Me.kchkShowCloseBox.Values.Text = "Show Close Box"
        Me.krtxtItemList.Location = New System.Drawing.Point(112, 441)
        Me.krtxtItemList.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.krtxtItemList.Name = "krtxtItemList"
        Me.krtxtItemList.Size = New System.Drawing.Size(376, 146)
        Me.krtxtItemList.TabIndex = 20
        Me.krtxtItemList.Text = ""
        Me.kryptonLabel7.LabelStyle = Krypton.Toolkit.LabelStyle.BoldPanel
        Me.kryptonLabel7.Location = New System.Drawing.Point(16, 439)
        Me.kryptonLabel7.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.kryptonLabel7.Name = "kryptonLabel7"
        Me.kryptonLabel7.Size = New System.Drawing.Size(45, 44)
        Me.kryptonLabel7.TabIndex = 19
        Me.kryptonLabel7.Values.Text = "Item" & vbCrLf & "List:"
        Me.kcolCueColor.Location = New System.Drawing.Point(112, 401)
        Me.kcolCueColor.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.kcolCueColor.Name = "kcolCueColor"
        Me.kcolCueColor.SelectedColor = System.Drawing.Color.Gray
        Me.kcolCueColor.Size = New System.Drawing.Size(376, 31)
        Me.kcolCueColor.TabIndex = 18
        Me.kcolCueColor.Values.Image = CType(resources.GetObject("kcolCueColor.Values.Image"), System.Drawing.Image)
        Me.kcolCueColor.Values.Text = "Cue Color"
        Me.ktxtInputCueText.Location = New System.Drawing.Point(112, 364)
        Me.ktxtInputCueText.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.ktxtInputCueText.Name = "ktxtInputCueText"
        Me.ktxtInputCueText.Size = New System.Drawing.Size(376, 27)
        Me.ktxtInputCueText.TabIndex = 17
        Me.kryptonLabel6.LabelStyle = Krypton.Toolkit.LabelStyle.BoldPanel
        Me.kryptonLabel6.Location = New System.Drawing.Point(16, 358)
        Me.kryptonLabel6.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.kryptonLabel6.Name = "kryptonLabel6"
        Me.kryptonLabel6.Size = New System.Drawing.Size(51, 44)
        Me.kryptonLabel6.TabIndex = 16
        Me.kryptonLabel6.Values.Text = "Input" & vbCrLf & "Cue:"
        Me.kcmbDropDownStyle.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.kcmbDropDownStyle.DropDownWidth = 274
        Me.kcmbDropDownStyle.IntegralHeight = False
        Me.kcmbDropDownStyle.Location = New System.Drawing.Point(123, 306)
        Me.kcmbDropDownStyle.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.kcmbDropDownStyle.Name = "kcmbDropDownStyle"
        Me.kcmbDropDownStyle.Size = New System.Drawing.Size(365, 26)
        Me.kcmbDropDownStyle.StateCommon.ComboBox.Content.TextH = Krypton.Toolkit.PaletteRelativeAlign.Near
        Me.kcmbDropDownStyle.TabIndex = 15
        Me.kryptonLabel5.LabelStyle = Krypton.Toolkit.LabelStyle.BoldPanel
        Me.kryptonLabel5.Location = New System.Drawing.Point(16, 287)
        Me.kryptonLabel5.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.kryptonLabel5.Name = "kryptonLabel5"
        Me.kryptonLabel5.Size = New System.Drawing.Size(91, 64)
        Me.kryptonLabel5.TabIndex = 14
        Me.kryptonLabel5.Values.Text = "ComboBox" & vbCrLf & "DropDown" & vbCrLf & "Style:"
        Me.kcmbNotificationInputStyle.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.kcmbNotificationInputStyle.DropDownWidth = 282
        Me.kcmbNotificationInputStyle.IntegralHeight = False
        Me.kcmbNotificationInputStyle.Location = New System.Drawing.Point(112, 245)
        Me.kcmbNotificationInputStyle.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.kcmbNotificationInputStyle.Name = "kcmbNotificationInputStyle"
        Me.kcmbNotificationInputStyle.Size = New System.Drawing.Size(376, 26)
        Me.kcmbNotificationInputStyle.StateCommon.ComboBox.Content.TextH = Krypton.Toolkit.PaletteRelativeAlign.Near
        Me.kcmbNotificationInputStyle.TabIndex = 13
        Me.kryptonLabel4.LabelStyle = Krypton.Toolkit.LabelStyle.BoldPanel
        Me.kryptonLabel4.Location = New System.Drawing.Point(16, 235)
        Me.kryptonLabel4.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.kryptonLabel4.Name = "kryptonLabel4"
        Me.kryptonLabel4.Size = New System.Drawing.Size(51, 44)
        Me.kryptonLabel4.TabIndex = 12
        Me.kryptonLabel4.Values.Text = "Input" & vbCrLf & "Style:"
        Me.kcmbToastIcon.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.kcmbToastIcon.DropDownWidth = 282
        Me.kcmbToastIcon.IntegralHeight = False
        Me.kcmbToastIcon.Location = New System.Drawing.Point(112, 202)
        Me.kcmbToastIcon.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.kcmbToastIcon.Name = "kcmbToastIcon"
        Me.kcmbToastIcon.Size = New System.Drawing.Size(376, 26)
        Me.kcmbToastIcon.StateCommon.ComboBox.Content.TextH = Krypton.Toolkit.PaletteRelativeAlign.Near
        Me.kcmbToastIcon.TabIndex = 11
        Me.kryptonLabel3.LabelStyle = Krypton.Toolkit.LabelStyle.BoldPanel
        Me.kryptonLabel3.Location = New System.Drawing.Point(16, 202)
        Me.kryptonLabel3.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.kryptonLabel3.Name = "kryptonLabel3"
        Me.kryptonLabel3.Size = New System.Drawing.Size(47, 24)
        Me.kryptonLabel3.TabIndex = 10
        Me.kryptonLabel3.Values.Text = "Icon:"
        Me.ktxtToastContent.Location = New System.Drawing.Point(112, 49)
        Me.ktxtToastContent.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.ktxtToastContent.Multiline = True
        Me.ktxtToastContent.Name = "ktxtToastContent"
        Me.ktxtToastContent.Size = New System.Drawing.Size(376, 145)
        Me.ktxtToastContent.TabIndex = 9
        Me.ktxtToastContent.Text = "Put your message here..."
        Me.ktxtToastTitle.Location = New System.Drawing.Point(112, 15)
        Me.ktxtToastTitle.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.ktxtToastTitle.Name = "ktxtToastTitle"
        Me.ktxtToastTitle.Size = New System.Drawing.Size(376, 27)
        Me.ktxtToastTitle.TabIndex = 8
        Me.ktxtToastTitle.Text = "This is a test"
        Me.kryptonLabel2.LabelStyle = Krypton.Toolkit.LabelStyle.BoldPanel
        Me.kryptonLabel2.Location = New System.Drawing.Point(16, 47)
        Me.kryptonLabel2.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.kryptonLabel2.Name = "kryptonLabel2"
        Me.kryptonLabel2.Size = New System.Drawing.Size(48, 24)
        Me.kryptonLabel2.TabIndex = 7
        Me.kryptonLabel2.Values.Text = "Text:"
        Me.kryptonLabel1.LabelStyle = Krypton.Toolkit.LabelStyle.BoldPanel
        Me.kryptonLabel1.Location = New System.Drawing.Point(16, 15)
        Me.kryptonLabel1.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.kryptonLabel1.Name = "kryptonLabel1"
        Me.kryptonLabel1.Size = New System.Drawing.Size(48, 24)
        Me.kryptonLabel1.TabIndex = 6
        Me.kryptonLabel1.Values.Text = "Title:"
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8F, 16F)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(1539, 864)
        Me.Controls.Add(Me.kryptonPanel2)
        Me.Controls.Add(Me.kryptonPanel1)
        Me.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.Name = "UserInputNotification"
        Me.Text = "UserInputNotification"
        CType(Me.kryptonPanel1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.kryptonPanel1.ResumeLayout(False)
        Me.kryptonPanel1.PerformLayout()
        CType(Me.kryptonPanel2, System.ComponentModel.ISupportInitialize).EndInit()
        Me.kryptonPanel2.ResumeLayout(False)
        Me.kryptonPanel2.PerformLayout()
        CType(Me.kcmbOwner, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.kcmbNotificationContentAlignment, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.kcmbNotificationTitleAlignment, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.kcmbDoNotShowAgainOptionCheckState, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.kryptonGroupBox2.Panel, System.ComponentModel.ISupportInitialize).EndInit()
        Me.kryptonGroupBox2.Panel.ResumeLayout(False)
        Me.kryptonGroupBox2.Panel.PerformLayout()
        CType(Me.kryptonGroupBox2, System.ComponentModel.ISupportInitialize).EndInit()
        Me.kryptonGroupBox2.ResumeLayout(False)
        CType(Me.kcmbDropDownStyle, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.kcmbNotificationInputStyle, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.kcmbToastIcon, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
    End Sub

    Friend WithEvents kryptonPanel1 As Krypton.Toolkit.KryptonPanel
    Friend WithEvents kryptonBorderEdge1 As Krypton.Toolkit.KryptonBorderEdge
    Friend WithEvents kbtnShow As Krypton.Toolkit.KryptonButton
    Friend WithEvents kryptonPanel2 As Krypton.Toolkit.KryptonPanel
    Friend WithEvents kcmbToastIcon As Krypton.Toolkit.KryptonComboBox
    Friend WithEvents kryptonLabel3 As Krypton.Toolkit.KryptonLabel
    Friend WithEvents ktxtToastContent As Krypton.Toolkit.KryptonTextBox
    Friend WithEvents ktxtToastTitle As Krypton.Toolkit.KryptonTextBox
    Friend WithEvents kryptonLabel2 As Krypton.Toolkit.KryptonLabel
    Friend WithEvents kryptonLabel1 As Krypton.Toolkit.KryptonLabel
    Friend WithEvents kcmbNotificationInputStyle As Krypton.Toolkit.KryptonComboBox
    Friend WithEvents kryptonLabel4 As Krypton.Toolkit.KryptonLabel
    Friend WithEvents kcmbDropDownStyle As Krypton.Toolkit.KryptonComboBox
    Friend WithEvents kryptonLabel5 As Krypton.Toolkit.KryptonLabel
    Friend WithEvents kryptonLabel6 As Krypton.Toolkit.KryptonLabel
    Friend WithEvents ktxtInputCueText As Krypton.Toolkit.KryptonTextBox
    Friend WithEvents kcolCueColor As Krypton.Toolkit.KryptonColorButton
    Friend WithEvents kryptonLabel7 As Krypton.Toolkit.KryptonLabel
    Friend WithEvents krtxtItemList As Krypton.Toolkit.KryptonRichTextBox
    Friend WithEvents kryptonGroupBox2 As Krypton.Toolkit.KryptonGroupBox
    Friend WithEvents kchkReportLocation As Krypton.Toolkit.KryptonCheckBox
    Friend WithEvents kchkUseFade As Krypton.Toolkit.KryptonCheckBox
    Friend WithEvents kchkTopMost As Krypton.Toolkit.KryptonCheckBox
    Friend WithEvents kchkShowCloseBox As Krypton.Toolkit.KryptonCheckBox
    Friend WithEvents knudCountdownSeconds As Krypton.Toolkit.KryptonNumericUpDown
    Friend WithEvents kryptonLabel8 As Krypton.Toolkit.KryptonLabel
    Friend WithEvents kdtpInitialDate As Krypton.Toolkit.KryptonDateTimePicker
    Friend WithEvents kryptonLabel11 As Krypton.Toolkit.KryptonLabel
    Friend WithEvents kdtpMinimumDate As Krypton.Toolkit.KryptonDateTimePicker
    Friend WithEvents kryptonLabel10 As Krypton.Toolkit.KryptonLabel
    Friend WithEvents kdtpMaximumDate As Krypton.Toolkit.KryptonDateTimePicker
    Friend WithEvents kryptonLabel9 As Krypton.Toolkit.KryptonLabel
    Friend WithEvents kchkShowDoNotShowAgainOption As Krypton.Toolkit.KryptonCheckBox
    Friend WithEvents kchkFocusOnUserInputArea As Krypton.Toolkit.KryptonCheckBox
    Friend WithEvents kchkUseDoNotShowAgainOptionThreeState As Krypton.Toolkit.KryptonCheckBox
    Friend WithEvents kchkIsDoNotShowAgainOptionChecked As Krypton.Toolkit.KryptonCheckBox
    Friend WithEvents kchkUseRTLReading As Krypton.Toolkit.KryptonCheckBox
    Friend WithEvents kchkShowWithProgressBar As Krypton.Toolkit.KryptonCheckBox
    Friend WithEvents kcmbDoNotShowAgainOptionCheckState As Krypton.Toolkit.KryptonComboBox
    Friend WithEvents kryptonLabel12 As Krypton.Toolkit.KryptonLabel
    Friend WithEvents kcmbNotificationContentAlignment As Krypton.Toolkit.KryptonComboBox
    Friend WithEvents kcmbNotificationTitleAlignment As Krypton.Toolkit.KryptonComboBox
    Friend WithEvents kryptonLabel14 As Krypton.Toolkit.KryptonLabel
    Friend WithEvents kryptonLabel13 As Krypton.Toolkit.KryptonLabel
    Friend WithEvents kcbtnBorderColor2 As Krypton.Toolkit.KryptonColorButton
    Friend WithEvents kcbtnBorderColor1 As Krypton.Toolkit.KryptonColorButton
    Friend WithEvents kbtnNotificationTitleFont As Krypton.Toolkit.KryptonButton
    Friend WithEvents kbtnNotificationContentFont As Krypton.Toolkit.KryptonButton
    Friend WithEvents knudCountDownInterval As Krypton.Toolkit.KryptonNumericUpDown
    Friend WithEvents kryptonLabel15 As Krypton.Toolkit.KryptonLabel
    Friend WithEvents kcmbOwner As Krypton.Toolkit.KryptonComboBox
    Friend WithEvents kryptonLabel16 As Krypton.Toolkit.KryptonLabel
    Friend WithEvents kchkUseDefaultLocation As Krypton.Toolkit.KryptonCheckBox
    Friend WithEvents knudYAxis As Krypton.Toolkit.KryptonNumericUpDown
    Friend WithEvents kryptonLabel18 As Krypton.Toolkit.KryptonLabel
    Friend WithEvents knudXAxis As Krypton.Toolkit.KryptonNumericUpDown
    Friend WithEvents kryptonLabel17 As Krypton.Toolkit.KryptonLabel
End Class
