' VB.NET twin of Source\Krypton Toolkit Examples\KryptonHeaderGroup Examples\Form1.Designer.cs (Bastion Phase 4c).

<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class Form1
    Inherits System.Windows.Forms.Form

    ''' <summary>
    '''  Required designer variable.
    ''' </summary>
    Private components As System.ComponentModel.IContainer

    ''' <summary>
    '''  Clean up any resources being used.
    ''' </summary>
    ''' <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
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

#Region "Windows Form Designer generated code"

    ''' <summary>
    '''  Required method for Designer support - do not modify
    '''  the contents of this method with the code editor.
    ''' </summary>
    <System.Diagnostics.DebuggerStepThrough()>
    Private Sub InitializeComponent()

        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(Form1))
        Me.groupBox4 = New System.Windows.Forms.GroupBox()
        Me.propertyGrid = New System.Windows.Forms.PropertyGrid()
        Me.buttonClose = New System.Windows.Forms.Button()
        Me.groupBox1 = New System.Windows.Forms.GroupBox()
        Me.headerGroup2Office = New Krypton.Toolkit.KryptonHeaderGroup()
        Me.headerGroup1Office = New Krypton.Toolkit.KryptonHeaderGroup()
        Me.buttonSpecHeaderGroup1 = New Krypton.Toolkit.ButtonSpecHeaderGroup()
        Me.headerGroup1OfficeRTB = New System.Windows.Forms.RichTextBox()
        Me.groupBox2 = New System.Windows.Forms.GroupBox()
        Me.headerGroup2Blue = New Krypton.Toolkit.KryptonHeaderGroup()
        Me.headerGroup1Blue = New Krypton.Toolkit.KryptonHeaderGroup()
        Me.buttonSpecHeaderGroup3 = New Krypton.Toolkit.ButtonSpecHeaderGroup()
        Me.richTextBox1 = New System.Windows.Forms.RichTextBox()
        Me.groupBox3 = New System.Windows.Forms.GroupBox()
        Me.headerGroup4Custom = New Krypton.Toolkit.KryptonHeaderGroup()
        Me.headerGroup3Custom = New Krypton.Toolkit.KryptonHeaderGroup()
        Me.buttonSpecHeaderGroup5 = New Krypton.Toolkit.ButtonSpecHeaderGroup()
        Me.headerGroup2Custom = New Krypton.Toolkit.KryptonHeaderGroup()
        Me.headerGroup1Custom = New Krypton.Toolkit.KryptonHeaderGroup()
        Me.groupBox4.SuspendLayout()
        Me.groupBox1.SuspendLayout()
        CType(Me.headerGroup2Office, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.headerGroup2Office.Panel, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.headerGroup2Office.SuspendLayout()
        CType(Me.headerGroup1Office, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.headerGroup1Office.Panel, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.headerGroup1Office.Panel.SuspendLayout()
        Me.headerGroup1Office.SuspendLayout()
        Me.groupBox2.SuspendLayout()
        CType(Me.headerGroup2Blue, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.headerGroup2Blue.Panel, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.headerGroup2Blue.SuspendLayout()
        CType(Me.headerGroup1Blue, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.headerGroup1Blue.Panel, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.headerGroup1Blue.Panel.SuspendLayout()
        Me.headerGroup1Blue.SuspendLayout()
        Me.groupBox3.SuspendLayout()
        CType(Me.headerGroup4Custom, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.headerGroup4Custom.Panel, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.headerGroup4Custom.SuspendLayout()
        CType(Me.headerGroup3Custom, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.headerGroup3Custom.Panel, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.headerGroup3Custom.SuspendLayout()
        CType(Me.headerGroup2Custom, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.headerGroup2Custom.Panel, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.headerGroup2Custom.SuspendLayout()
        CType(Me.headerGroup1Custom, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.headerGroup1Custom.Panel, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.headerGroup1Custom.SuspendLayout()
        Me.SuspendLayout()
        '
        ' groupBox4
        '
        Me.groupBox4.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.groupBox4.Controls.Add(Me.propertyGrid)
        Me.groupBox4.Location = New System.Drawing.Point(333, 12)
        Me.groupBox4.Name = "groupBox4"
        Me.groupBox4.Size = New System.Drawing.Size(321, 628)
        Me.groupBox4.TabIndex = 5
        Me.groupBox4.TabStop = False
        Me.groupBox4.Text = "Properties for Selected KryptonHeaderGroup"
        '
        ' propertyGrid
        '
        Me.propertyGrid.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) Or System.Windows.Forms.AnchorStyles.Left) Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.propertyGrid.Location = New System.Drawing.Point(6, 19)
        Me.propertyGrid.Name = "propertyGrid"
        Me.propertyGrid.Size = New System.Drawing.Size(309, 603)
        Me.propertyGrid.TabIndex = 3
        Me.propertyGrid.ToolbarVisible = False
        '
        ' buttonClose
        '
        Me.buttonClose.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.buttonClose.DialogResult = System.Windows.Forms.DialogResult.Cancel
        Me.buttonClose.Location = New System.Drawing.Point(580, 646)
        Me.buttonClose.Name = "buttonClose"
        Me.buttonClose.Size = New System.Drawing.Size(75, 23)
        Me.buttonClose.TabIndex = 6
        Me.buttonClose.Text = "&Close"
        Me.buttonClose.UseVisualStyleBackColor = True
        '
        ' groupBox1
        '
        Me.groupBox1.Controls.Add(Me.headerGroup2Office)
        Me.groupBox1.Controls.Add(Me.headerGroup1Office)
        Me.groupBox1.Location = New System.Drawing.Point(12, 12)
        Me.groupBox1.Name = "groupBox1"
        Me.groupBox1.Size = New System.Drawing.Size(315, 175)
        Me.groupBox1.TabIndex = 7
        Me.groupBox1.TabStop = False
        Me.groupBox1.Text = "Professional - Office 2003"
        '
        ' headerGroup2Office
        '
        Me.headerGroup2Office.HeaderPositionSecondary = Krypton.Toolkit.VisualOrientation.Top
        Me.headerGroup2Office.Location = New System.Drawing.Point(158, 28)
        Me.headerGroup2Office.Name = "headerGroup2Office"
        Me.headerGroup2Office.PaletteMode = Krypton.Toolkit.PaletteMode.ProfessionalOffice2003
        '
        ' headerGroup2Office.Panel
        '
        Me.headerGroup2Office.Size = New System.Drawing.Size(158, 129)
        Me.headerGroup2Office.StateNormal.HeaderPrimary.Content.Image.ImageH = Krypton.Toolkit.PaletteRelativeAlign.Far
        Me.headerGroup2Office.TabIndex = 1
        Me.headerGroup2Office.ValuesPrimary.Heading = "Calendar"
        Me.headerGroup2Office.ValuesPrimary.Image = CType(resources.GetObject("headerGroup2Office.ValuesPrimary.Image"), System.Drawing.Image)
        Me.headerGroup2Office.ValuesSecondary.Description = "25th December 2005"
        '
        ' headerGroup1Office
        '
        Me.headerGroup1Office.AllowButtonSpecToolTips = True
        Me.headerGroup1Office.AutoSize = True
        Me.headerGroup1Office.ButtonSpecs.Add(Me.buttonSpecHeaderGroup1)
        Me.headerGroup1Office.Location = New System.Drawing.Point(11, 28)
        Me.headerGroup1Office.Name = "headerGroup1Office"
        Me.headerGroup1Office.PaletteMode = Krypton.Toolkit.PaletteMode.ProfessionalOffice2003
        '
        ' headerGroup1Office.Panel
        '
        Me.headerGroup1Office.Panel.Controls.Add(Me.headerGroup1OfficeRTB)
        Me.headerGroup1Office.Panel.MinimumSize = New System.Drawing.Size(106, 80)
        Me.headerGroup1Office.Panel.Padding = New System.Windows.Forms.Padding(5)
        Me.headerGroup1Office.Size = New System.Drawing.Size(144, 147)
        Me.headerGroup1Office.TabIndex = 0
        '
        ' buttonSpecHeaderGroup1
        '
        Me.buttonSpecHeaderGroup1.ToolTipTitle = "Toggle the Collapsed/Expanded state"
        Me.buttonSpecHeaderGroup1.Type = Krypton.Toolkit.PaletteButtonSpecStyle.ArrowUp
        Me.buttonSpecHeaderGroup1.UniqueName = "A3F93613DE6E4171A3F93613DE6E4171"
        '
        ' headerGroup1OfficeRTB
        '
        Me.headerGroup1OfficeRTB.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.headerGroup1OfficeRTB.Dock = System.Windows.Forms.DockStyle.Fill
        Me.headerGroup1OfficeRTB.Location = New System.Drawing.Point(5, 5)
        Me.headerGroup1OfficeRTB.Name = "headerGroup1OfficeRTB"
        Me.headerGroup1OfficeRTB.Size = New System.Drawing.Size(132, 70)
        Me.headerGroup1OfficeRTB.TabIndex = 0
        Me.headerGroup1OfficeRTB.Text = "Use the arrow on the top header to see the expand and collapse in operation."
        '
        ' groupBox2
        '
        Me.groupBox2.Controls.Add(Me.headerGroup2Blue)
        Me.groupBox2.Controls.Add(Me.headerGroup1Blue)
        Me.groupBox2.Location = New System.Drawing.Point(12, 193)
        Me.groupBox2.Name = "groupBox2"
        Me.groupBox2.Size = New System.Drawing.Size(315, 175)
        Me.groupBox2.TabIndex = 8
        Me.groupBox2.TabStop = False
        Me.groupBox2.Text = "Office 2007 - Blue"
        '
        ' headerGroup2Blue
        '
        Me.headerGroup2Blue.HeaderPositionSecondary = Krypton.Toolkit.VisualOrientation.Top
        Me.headerGroup2Blue.Location = New System.Drawing.Point(158, 28)
        Me.headerGroup2Blue.Name = "headerGroup2Blue"
        Me.headerGroup2Blue.PaletteMode = Krypton.Toolkit.PaletteMode.Office2007Blue
        '
        ' headerGroup2Blue.Panel
        '
        Me.headerGroup2Blue.Size = New System.Drawing.Size(158, 134)
        Me.headerGroup2Blue.StateNormal.HeaderPrimary.Content.Image.ImageH = Krypton.Toolkit.PaletteRelativeAlign.Far
        Me.headerGroup2Blue.TabIndex = 2
        Me.headerGroup2Blue.ValuesPrimary.Heading = "Calendar"
        Me.headerGroup2Blue.ValuesPrimary.Image = CType(resources.GetObject("headerGroup2Blue.ValuesPrimary.Image"), System.Drawing.Image)
        Me.headerGroup2Blue.ValuesSecondary.Description = "25th December 2005"
        '
        ' headerGroup1Blue
        '
        Me.headerGroup1Blue.AllowButtonSpecToolTips = True
        Me.headerGroup1Blue.AutoSize = True
        Me.headerGroup1Blue.ButtonSpecs.Add(Me.buttonSpecHeaderGroup3)
        Me.headerGroup1Blue.Location = New System.Drawing.Point(11, 28)
        Me.headerGroup1Blue.Name = "headerGroup1Blue"
        Me.headerGroup1Blue.PaletteMode = Krypton.Toolkit.PaletteMode.Office2007Blue
        '
        ' headerGroup1Blue.Panel
        '
        Me.headerGroup1Blue.Panel.Controls.Add(Me.richTextBox1)
        Me.headerGroup1Blue.Panel.MinimumSize = New System.Drawing.Size(106, 80)
        Me.headerGroup1Blue.Panel.Padding = New System.Windows.Forms.Padding(5)
        Me.headerGroup1Blue.Size = New System.Drawing.Size(144, 143)
        Me.headerGroup1Blue.TabIndex = 1
        '
        ' buttonSpecHeaderGroup3
        '
        Me.buttonSpecHeaderGroup3.ToolTipTitle = "Toggle the Collapsed/Expanded state"
        Me.buttonSpecHeaderGroup3.Type = Krypton.Toolkit.PaletteButtonSpecStyle.ArrowUp
        Me.buttonSpecHeaderGroup3.UniqueName = "7C2CD73A480A44C57C2CD73A480A44C5"
        '
        ' richTextBox1
        '
        Me.richTextBox1.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.richTextBox1.Dock = System.Windows.Forms.DockStyle.Fill
        Me.richTextBox1.Location = New System.Drawing.Point(5, 5)
        Me.richTextBox1.Name = "richTextBox1"
        Me.richTextBox1.Size = New System.Drawing.Size(132, 70)
        Me.richTextBox1.TabIndex = 1
        Me.richTextBox1.Text = "Use the arrow on the top header to see the expand and collapse in operation."
        '
        ' groupBox3
        '
        Me.groupBox3.Controls.Add(Me.headerGroup4Custom)
        Me.groupBox3.Controls.Add(Me.headerGroup3Custom)
        Me.groupBox3.Controls.Add(Me.headerGroup2Custom)
        Me.groupBox3.Controls.Add(Me.headerGroup1Custom)
        Me.groupBox3.Location = New System.Drawing.Point(12, 375)
        Me.groupBox3.Name = "groupBox3"
        Me.groupBox3.Size = New System.Drawing.Size(315, 265)
        Me.groupBox3.TabIndex = 9
        Me.groupBox3.TabStop = False
        Me.groupBox3.Text = "Custom Settings"
        '
        ' headerGroup4Custom
        '
        Me.headerGroup4Custom.Location = New System.Drawing.Point(162, 148)
        Me.headerGroup4Custom.Name = "headerGroup4Custom"
        Me.headerGroup4Custom.PaletteMode = Krypton.Toolkit.PaletteMode.ProfessionalSystem
        '
        ' headerGroup4Custom.Panel
        '
        Me.headerGroup4Custom.Size = New System.Drawing.Size(137, 104)
        Me.headerGroup4Custom.StateNormal.Back.Color1 = System.Drawing.Color.FromArgb(CType(CType(90, Byte), Integer), CType(CType(125, Byte), Integer), CType(CType(222, Byte), Integer))
        Me.headerGroup4Custom.StateNormal.Back.Color2 = System.Drawing.Color.FromArgb(CType(CType(155, Byte), Integer), CType(CType(186, Byte), Integer), CType(CType(247, Byte), Integer))
        Me.headerGroup4Custom.StateNormal.Back.ColorAngle = 15.0!
        Me.headerGroup4Custom.StateNormal.Back.ColorStyle = Krypton.Toolkit.PaletteColorStyle.Sigma
        Me.headerGroup4Custom.StateNormal.Border.Color1 = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(45, Byte), Integer), CType(CType(150, Byte), Integer))
        Me.headerGroup4Custom.StateNormal.Border.DrawBorders = CType((((Krypton.Toolkit.PaletteDrawBorders.Top Or Krypton.Toolkit.PaletteDrawBorders.Bottom) Or Krypton.Toolkit.PaletteDrawBorders.Left) Or Krypton.Toolkit.PaletteDrawBorders.Right), Krypton.Toolkit.PaletteDrawBorders)
        Me.headerGroup4Custom.StateNormal.Border.Width = 1
        Me.headerGroup4Custom.StateNormal.HeaderPrimary.Back.Color1 = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(51, Byte), Integer), CType(CType(153, Byte), Integer))
        Me.headerGroup4Custom.StateNormal.HeaderPrimary.Back.ColorStyle = Krypton.Toolkit.PaletteColorStyle.Solid
        Me.headerGroup4Custom.StateNormal.HeaderPrimary.Border.Color1 = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(45, Byte), Integer), CType(CType(150, Byte), Integer))
        Me.headerGroup4Custom.StateNormal.HeaderPrimary.Border.DrawBorders = CType((((Krypton.Toolkit.PaletteDrawBorders.Top Or Krypton.Toolkit.PaletteDrawBorders.Bottom) Or Krypton.Toolkit.PaletteDrawBorders.Left) Or Krypton.Toolkit.PaletteDrawBorders.Right), Krypton.Toolkit.PaletteDrawBorders)
        Me.headerGroup4Custom.StateNormal.HeaderPrimary.Border.Width = 1
        Me.headerGroup4Custom.StateNormal.HeaderPrimary.Content.Image.ImageH = Krypton.Toolkit.PaletteRelativeAlign.Far
        Me.headerGroup4Custom.StateNormal.HeaderSecondary.Back.Color1 = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(51, Byte), Integer), CType(CType(153, Byte), Integer))
        Me.headerGroup4Custom.StateNormal.HeaderSecondary.Back.ColorStyle = Krypton.Toolkit.PaletteColorStyle.Solid
        Me.headerGroup4Custom.StateNormal.HeaderSecondary.Border.Color1 = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(45, Byte), Integer), CType(CType(150, Byte), Integer))
        Me.headerGroup4Custom.StateNormal.HeaderSecondary.Border.DrawBorders = CType((((Krypton.Toolkit.PaletteDrawBorders.Top Or Krypton.Toolkit.PaletteDrawBorders.Bottom) Or Krypton.Toolkit.PaletteDrawBorders.Left) Or Krypton.Toolkit.PaletteDrawBorders.Right), Krypton.Toolkit.PaletteDrawBorders)
        Me.headerGroup4Custom.StateNormal.HeaderSecondary.Border.Width = 1
        Me.headerGroup4Custom.StateNormal.HeaderSecondary.Content.LongText.Color1 = System.Drawing.Color.White
        Me.headerGroup4Custom.StateNormal.HeaderSecondary.Content.ShortText.Color1 = System.Drawing.Color.White
        Me.headerGroup4Custom.TabIndex = 5
        Me.headerGroup4Custom.ValuesPrimary.Heading = "Computer"
        Me.headerGroup4Custom.ValuesPrimary.Image = Global.KryptonHeaderGroupExamples.My.Resources.WinLogo
        '
        ' headerGroup3Custom
        '
        Me.headerGroup3Custom.AllowButtonSpecToolTips = True
        Me.headerGroup3Custom.ButtonSpecs.Add(Me.buttonSpecHeaderGroup5)
        Me.headerGroup3Custom.Location = New System.Drawing.Point(15, 148)
        Me.headerGroup3Custom.Name = "headerGroup3Custom"
        Me.headerGroup3Custom.PaletteMode = Krypton.Toolkit.PaletteMode.ProfessionalSystem
        '
        ' headerGroup3Custom.Panel
        '
        Me.headerGroup3Custom.Size = New System.Drawing.Size(137, 104)
        Me.headerGroup3Custom.StateCommon.HeaderPrimary.ButtonEdgeInset = 4
        Me.headerGroup3Custom.StateCommon.HeaderPrimary.ButtonPadding = New System.Windows.Forms.Padding(2, -1, 0, -1)
        Me.headerGroup3Custom.StateCommon.OverlayHeaders = Krypton.Toolkit.InheritBool.False
        Me.headerGroup3Custom.StateNormal.Back.Color1 = System.Drawing.Color.FromArgb(CType(CType(225, Byte), Integer), CType(CType(240, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.headerGroup3Custom.StateNormal.Border.Color1 = System.Drawing.Color.FromArgb(CType(CType(148, Byte), Integer), CType(CType(201, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.headerGroup3Custom.StateNormal.Border.DrawBorders = CType((((Krypton.Toolkit.PaletteDrawBorders.Top Or Krypton.Toolkit.PaletteDrawBorders.Bottom) Or Krypton.Toolkit.PaletteDrawBorders.Left) Or Krypton.Toolkit.PaletteDrawBorders.Right), Krypton.Toolkit.PaletteDrawBorders)
        Me.headerGroup3Custom.StateNormal.Border.Width = 2
        Me.headerGroup3Custom.StateNormal.HeaderPrimary.Back.Color1 = System.Drawing.Color.FromArgb(CType(CType(148, Byte), Integer), CType(CType(201, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.headerGroup3Custom.StateNormal.HeaderPrimary.Back.Color2 = System.Drawing.Color.FromArgb(CType(CType(225, Byte), Integer), CType(CType(240, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.headerGroup3Custom.StateNormal.HeaderPrimary.Back.ColorAngle = 70.0!
        Me.headerGroup3Custom.StateNormal.HeaderPrimary.Back.ColorStyle = Krypton.Toolkit.PaletteColorStyle.Rounded
        Me.headerGroup3Custom.StateNormal.HeaderPrimary.Border.Draw = Krypton.Toolkit.InheritBool.False
        Me.headerGroup3Custom.StateNormal.HeaderPrimary.Border.DrawBorders = CType((((Krypton.Toolkit.PaletteDrawBorders.Top Or Krypton.Toolkit.PaletteDrawBorders.Bottom) Or Krypton.Toolkit.PaletteDrawBorders.Left) Or Krypton.Toolkit.PaletteDrawBorders.Right), Krypton.Toolkit.PaletteDrawBorders)
        Me.headerGroup3Custom.StateNormal.HeaderPrimary.Content.ShortText.Color1 = System.Drawing.Color.Black
        Me.headerGroup3Custom.StateNormal.HeaderSecondary.Back.Color1 = System.Drawing.Color.FromArgb(CType(CType(225, Byte), Integer), CType(CType(240, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.headerGroup3Custom.StateNormal.HeaderSecondary.Back.Color2 = System.Drawing.Color.FromArgb(CType(CType(148, Byte), Integer), CType(CType(201, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.headerGroup3Custom.StateNormal.HeaderSecondary.Back.ColorAngle = 70.0!
        Me.headerGroup3Custom.StateNormal.HeaderSecondary.Back.ColorStyle = Krypton.Toolkit.PaletteColorStyle.Rounded
        Me.headerGroup3Custom.StateNormal.HeaderSecondary.Border.Draw = Krypton.Toolkit.InheritBool.False
        Me.headerGroup3Custom.StateNormal.HeaderSecondary.Border.DrawBorders = CType((((Krypton.Toolkit.PaletteDrawBorders.Top Or Krypton.Toolkit.PaletteDrawBorders.Bottom) Or Krypton.Toolkit.PaletteDrawBorders.Left) Or Krypton.Toolkit.PaletteDrawBorders.Right), Krypton.Toolkit.PaletteDrawBorders)
        Me.headerGroup3Custom.StateNormal.HeaderSecondary.Content.LongText.TextH = Krypton.Toolkit.PaletteRelativeAlign.Far
        Me.headerGroup3Custom.TabIndex = 4
        Me.headerGroup3Custom.ValuesPrimary.Heading = "Notepad"
        Me.headerGroup3Custom.ValuesPrimary.Image = CType(resources.GetObject("headerGroup3Custom.ValuesPrimary.Image"), System.Drawing.Image)
        Me.headerGroup3Custom.ValuesSecondary.Description = "c:\Temp.txt"
        '
        ' buttonSpecHeaderGroup5
        '
        Me.buttonSpecHeaderGroup5.Edge = Krypton.Toolkit.PaletteRelativeEdgeAlign.Far
        Me.buttonSpecHeaderGroup5.Style = Krypton.Toolkit.PaletteButtonStyle.ButtonSpec
        Me.buttonSpecHeaderGroup5.ToolTipTitle = "Drop down for option selection"
        Me.buttonSpecHeaderGroup5.Type = Krypton.Toolkit.PaletteButtonSpecStyle.Context
        Me.buttonSpecHeaderGroup5.UniqueName = "02BAE7AC90E9401302BAE7AC90E94013"
        '
        ' headerGroup2Custom
        '
        Me.headerGroup2Custom.Location = New System.Drawing.Point(162, 26)
        Me.headerGroup2Custom.Name = "headerGroup2Custom"
        Me.headerGroup2Custom.PaletteMode = Krypton.Toolkit.PaletteMode.ProfessionalSystem
        '
        ' headerGroup2Custom.Panel
        '
        Me.headerGroup2Custom.Size = New System.Drawing.Size(137, 111)
        Me.headerGroup2Custom.StateCommon.OverlayHeaders = Krypton.Toolkit.InheritBool.False
        Me.headerGroup2Custom.StateNormal.Back.Color1 = System.Drawing.Color.FromArgb(CType(CType(223, Byte), Integer), CType(CType(223, Byte), Integer), CType(CType(223, Byte), Integer))
        Me.headerGroup2Custom.StateNormal.Back.Color2 = System.Drawing.Color.FromArgb(CType(CType(243, Byte), Integer), CType(CType(243, Byte), Integer), CType(CType(243, Byte), Integer))
        Me.headerGroup2Custom.StateNormal.Back.ColorAngle = 180.0!
        Me.headerGroup2Custom.StateNormal.Back.ColorStyle = Krypton.Toolkit.PaletteColorStyle.Linear
        Me.headerGroup2Custom.StateNormal.Border.Color1 = System.Drawing.SystemColors.Control
        Me.headerGroup2Custom.StateNormal.Border.Draw = Krypton.Toolkit.InheritBool.True
        Me.headerGroup2Custom.StateNormal.Border.DrawBorders = CType((((Krypton.Toolkit.PaletteDrawBorders.Top Or Krypton.Toolkit.PaletteDrawBorders.Bottom) Or Krypton.Toolkit.PaletteDrawBorders.Left) Or Krypton.Toolkit.PaletteDrawBorders.Right), Krypton.Toolkit.PaletteDrawBorders)
        Me.headerGroup2Custom.StateNormal.Border.GraphicsHint = Krypton.Toolkit.PaletteGraphicsHint.AntiAlias
        Me.headerGroup2Custom.StateNormal.Border.Rounding = 11.0!
        Me.headerGroup2Custom.StateNormal.Border.Width = 1
        Me.headerGroup2Custom.StateNormal.HeaderPrimary.Back.Color1 = System.Drawing.Color.FromArgb(CType(CType(48, Byte), Integer), CType(CType(47, Byte), Integer), CType(CType(47, Byte), Integer))
        Me.headerGroup2Custom.StateNormal.HeaderPrimary.Back.Color2 = System.Drawing.Color.FromArgb(CType(CType(90, Byte), Integer), CType(CType(89, Byte), Integer), CType(CType(89, Byte), Integer))
        Me.headerGroup2Custom.StateNormal.HeaderPrimary.Back.ColorStyle = Krypton.Toolkit.PaletteColorStyle.Sigma
        Me.headerGroup2Custom.StateNormal.HeaderPrimary.Content.Padding = New System.Windows.Forms.Padding(12, 6, -1, -1)
        Me.headerGroup2Custom.StateNormal.HeaderPrimary.Content.ShortText.Font = New System.Drawing.Font("Arial", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.headerGroup2Custom.StateNormal.HeaderSecondary.Back.Color1 = System.Drawing.Color.FromArgb(CType(CType(90, Byte), Integer), CType(CType(89, Byte), Integer), CType(CType(89, Byte), Integer))
        Me.headerGroup2Custom.StateNormal.HeaderSecondary.Back.Color2 = System.Drawing.Color.FromArgb(CType(CType(48, Byte), Integer), CType(CType(47, Byte), Integer), CType(CType(47, Byte), Integer))
        Me.headerGroup2Custom.StateNormal.HeaderSecondary.Back.ColorStyle = Krypton.Toolkit.PaletteColorStyle.Sigma
        Me.headerGroup2Custom.StateNormal.HeaderSecondary.Content.LongText.Color1 = System.Drawing.Color.White
        Me.headerGroup2Custom.StateNormal.HeaderSecondary.Content.LongText.Font = New System.Drawing.Font("Arial", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.headerGroup2Custom.StateNormal.HeaderSecondary.Content.Padding = New System.Windows.Forms.Padding(12, -1, -1, 5)
        Me.headerGroup2Custom.StateNormal.HeaderSecondary.Content.ShortText.Color1 = System.Drawing.Color.White
        Me.headerGroup2Custom.TabIndex = 3
        Me.headerGroup2Custom.ValuesPrimary.Heading = "Dark Style"
        Me.headerGroup2Custom.ValuesPrimary.Image = Nothing
        '
        ' headerGroup1Custom
        '
        Me.headerGroup1Custom.Location = New System.Drawing.Point(15, 26)
        Me.headerGroup1Custom.Name = "headerGroup1Custom"
        Me.headerGroup1Custom.PaletteMode = Krypton.Toolkit.PaletteMode.ProfessionalSystem
        '
        ' headerGroup1Custom.Panel
        '
        Me.headerGroup1Custom.Size = New System.Drawing.Size(137, 111)
        Me.headerGroup1Custom.StateCommon.HeaderPrimary.HeaderPadding = New System.Windows.Forms.Padding(6, 6, 6, 0)
        Me.headerGroup1Custom.StateCommon.HeaderSecondary.HeaderPadding = New System.Windows.Forms.Padding(6, 0, 6, 6)
        Me.headerGroup1Custom.StateCommon.OverlayHeaders = Krypton.Toolkit.InheritBool.False
        Me.headerGroup1Custom.StateNormal.Border.Color1 = System.Drawing.Color.FromArgb(CType(CType(225, Byte), Integer), CType(CType(212, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.headerGroup1Custom.StateNormal.Border.ColorStyle = Krypton.Toolkit.PaletteColorStyle.Solid
        Me.headerGroup1Custom.StateNormal.Border.DrawBorders = CType((((Krypton.Toolkit.PaletteDrawBorders.Top Or Krypton.Toolkit.PaletteDrawBorders.Bottom) Or Krypton.Toolkit.PaletteDrawBorders.Left) Or Krypton.Toolkit.PaletteDrawBorders.Right), Krypton.Toolkit.PaletteDrawBorders)
        Me.headerGroup1Custom.StateNormal.Border.GraphicsHint = Krypton.Toolkit.PaletteGraphicsHint.AntiAlias
        Me.headerGroup1Custom.StateNormal.Border.Rounding = 11.0!
        Me.headerGroup1Custom.StateNormal.Border.Width = 5
        Me.headerGroup1Custom.StateNormal.HeaderPrimary.Back.Color1 = System.Drawing.Color.FromArgb(CType(CType(225, Byte), Integer), CType(CType(212, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.headerGroup1Custom.StateNormal.HeaderPrimary.Back.Color2 = System.Drawing.Color.White
        Me.headerGroup1Custom.StateNormal.HeaderPrimary.Back.GraphicsHint = Krypton.Toolkit.PaletteGraphicsHint.AntiAlias
        Me.headerGroup1Custom.StateNormal.HeaderPrimary.Border.DrawBorders = CType((((Krypton.Toolkit.PaletteDrawBorders.Top Or Krypton.Toolkit.PaletteDrawBorders.Bottom) Or Krypton.Toolkit.PaletteDrawBorders.Left) Or Krypton.Toolkit.PaletteDrawBorders.Right), Krypton.Toolkit.PaletteDrawBorders)
        Me.headerGroup1Custom.StateNormal.HeaderPrimary.Border.GraphicsHint = Krypton.Toolkit.PaletteGraphicsHint.AntiAlias
        Me.headerGroup1Custom.StateNormal.HeaderPrimary.Border.Rounding = 6.0!
        Me.headerGroup1Custom.StateNormal.HeaderPrimary.Border.Width = 0
        Me.headerGroup1Custom.StateNormal.HeaderPrimary.Content.ShortText.Color1 = System.Drawing.Color.Black
        Me.headerGroup1Custom.StateNormal.HeaderSecondary.Back.Color1 = System.Drawing.Color.White
        Me.headerGroup1Custom.StateNormal.HeaderSecondary.Back.Color2 = System.Drawing.Color.FromArgb(CType(CType(225, Byte), Integer), CType(CType(212, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.headerGroup1Custom.StateNormal.HeaderSecondary.Back.GraphicsHint = Krypton.Toolkit.PaletteGraphicsHint.AntiAlias
        Me.headerGroup1Custom.StateNormal.HeaderSecondary.Border.DrawBorders = CType((((Krypton.Toolkit.PaletteDrawBorders.Top Or Krypton.Toolkit.PaletteDrawBorders.Bottom) Or Krypton.Toolkit.PaletteDrawBorders.Left) Or Krypton.Toolkit.PaletteDrawBorders.Right), Krypton.Toolkit.PaletteDrawBorders)
        Me.headerGroup1Custom.StateNormal.HeaderSecondary.Border.GraphicsHint = Krypton.Toolkit.PaletteGraphicsHint.AntiAlias
        Me.headerGroup1Custom.StateNormal.HeaderSecondary.Border.Rounding = 6.0!
        Me.headerGroup1Custom.StateNormal.HeaderSecondary.Border.Width = 0
        Me.headerGroup1Custom.TabIndex = 2
        Me.headerGroup1Custom.ValuesPrimary.Heading = "Blogging"
        Me.headerGroup1Custom.ValuesPrimary.Image = Nothing
        Me.headerGroup1Custom.ValuesSecondary.Description = "What is a blog?"
        '
        ' Form1
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 17.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(666, 677)
        Me.Controls.Add(Me.groupBox3)
        Me.Controls.Add(Me.groupBox2)
        Me.Controls.Add(Me.groupBox1)
        Me.Controls.Add(Me.buttonClose)
        Me.Controls.Add(Me.groupBox4)
        Me.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.MaximizeBox = False
        Me.MinimizeBox = False
        Me.Name = "Form1"
        Me.Text = "KryptonHeaderGroup Examples"
        Me.groupBox4.ResumeLayout(False)
        Me.groupBox1.ResumeLayout(False)
        Me.groupBox1.PerformLayout()
        CType(Me.headerGroup2Office.Panel, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.headerGroup2Office, System.ComponentModel.ISupportInitialize).EndInit()
        Me.headerGroup2Office.ResumeLayout(False)
        CType(Me.headerGroup1Office.Panel, System.ComponentModel.ISupportInitialize).EndInit()
        Me.headerGroup1Office.Panel.ResumeLayout(False)
        CType(Me.headerGroup1Office, System.ComponentModel.ISupportInitialize).EndInit()
        Me.headerGroup1Office.ResumeLayout(False)
        Me.groupBox2.ResumeLayout(False)
        Me.groupBox2.PerformLayout()
        CType(Me.headerGroup2Blue.Panel, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.headerGroup2Blue, System.ComponentModel.ISupportInitialize).EndInit()
        Me.headerGroup2Blue.ResumeLayout(False)
        CType(Me.headerGroup1Blue.Panel, System.ComponentModel.ISupportInitialize).EndInit()
        Me.headerGroup1Blue.Panel.ResumeLayout(False)
        CType(Me.headerGroup1Blue, System.ComponentModel.ISupportInitialize).EndInit()
        Me.headerGroup1Blue.ResumeLayout(False)
        Me.groupBox3.ResumeLayout(False)
        CType(Me.headerGroup4Custom.Panel, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.headerGroup4Custom, System.ComponentModel.ISupportInitialize).EndInit()
        Me.headerGroup4Custom.ResumeLayout(False)
        CType(Me.headerGroup3Custom.Panel, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.headerGroup3Custom, System.ComponentModel.ISupportInitialize).EndInit()
        Me.headerGroup3Custom.ResumeLayout(False)
        CType(Me.headerGroup2Custom.Panel, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.headerGroup2Custom, System.ComponentModel.ISupportInitialize).EndInit()
        Me.headerGroup2Custom.ResumeLayout(False)
        CType(Me.headerGroup1Custom.Panel, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.headerGroup1Custom, System.ComponentModel.ISupportInitialize).EndInit()
        Me.headerGroup1Custom.ResumeLayout(False)
        Me.ResumeLayout(False)

    End Sub

#End Region

    Private WithEvents groupBox4 As System.Windows.Forms.GroupBox
    Private WithEvents propertyGrid As System.Windows.Forms.PropertyGrid
    Private WithEvents buttonClose As System.Windows.Forms.Button
    Private WithEvents groupBox1 As System.Windows.Forms.GroupBox
    Private WithEvents groupBox2 As System.Windows.Forms.GroupBox
    Private WithEvents headerGroup2Office As Krypton.Toolkit.KryptonHeaderGroup
    Private WithEvents headerGroup1Office As Krypton.Toolkit.KryptonHeaderGroup
    Private WithEvents headerGroup2Blue As Krypton.Toolkit.KryptonHeaderGroup
    Private WithEvents headerGroup1Blue As Krypton.Toolkit.KryptonHeaderGroup
    Private WithEvents groupBox3 As System.Windows.Forms.GroupBox
    Private WithEvents headerGroup1Custom As Krypton.Toolkit.KryptonHeaderGroup
    Private WithEvents headerGroup2Custom As Krypton.Toolkit.KryptonHeaderGroup
    Private WithEvents headerGroup4Custom As Krypton.Toolkit.KryptonHeaderGroup
    Private WithEvents headerGroup3Custom As Krypton.Toolkit.KryptonHeaderGroup
    Private WithEvents buttonSpecHeaderGroup1 As Krypton.Toolkit.ButtonSpecHeaderGroup
    Private WithEvents buttonSpecHeaderGroup3 As Krypton.Toolkit.ButtonSpecHeaderGroup
    Private WithEvents buttonSpecHeaderGroup5 As Krypton.Toolkit.ButtonSpecHeaderGroup
    Private WithEvents headerGroup1OfficeRTB As System.Windows.Forms.RichTextBox
    Private WithEvents richTextBox1 As System.Windows.Forms.RichTextBox

End Class
