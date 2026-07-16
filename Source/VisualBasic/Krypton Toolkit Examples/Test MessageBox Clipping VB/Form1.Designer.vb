' VB.NET twin of Source\Krypton Toolkit Examples\Test MessageBox Clipping\Form1.Designer.cs (Bastion Phase 4c).
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
        Me.kryptonPanel1 = New Krypton.Toolkit.KryptonPanel()
        Me.btnLongContentsNoOwner = New Krypton.Toolkit.KryptonButton()
        Me.btnLongTitleNoOwner = New Krypton.Toolkit.KryptonButton()
        Me.btnLongContents = New Krypton.Toolkit.KryptonButton()
        Me.btnLongTitle = New Krypton.Toolkit.KryptonButton()
        Me.btnStackTrace = New Krypton.Toolkit.KryptonButton()
        Me.btnCarriageReturns = New Krypton.Toolkit.KryptonButton()
        Me.btnSingleLines = New Krypton.Toolkit.KryptonButton()
        Me.kryptonGroup1 = New Krypton.Toolkit.KryptonGroup()
        Me.kryptonOffice2010Black = New Krypton.Toolkit.KryptonRadioButton()
        Me.kryptonSparkleOrange = New Krypton.Toolkit.KryptonRadioButton()
        Me.kryptonOffice2010Blue = New Krypton.Toolkit.KryptonRadioButton()
        Me.kryptonOffice2010Silver = New Krypton.Toolkit.KryptonRadioButton()
        Me.kryptonOffice2013White = New Krypton.Toolkit.KryptonRadioButton()
        Me.kryptonSparklePurple = New Krypton.Toolkit.KryptonRadioButton()
        Me.kryptonSparkleBlue = New Krypton.Toolkit.KryptonRadioButton()
        Me.kryptonCustom = New Krypton.Toolkit.KryptonRadioButton()
        Me.kryptonSystem = New Krypton.Toolkit.KryptonRadioButton()
        Me.kryptonOffice2003 = New Krypton.Toolkit.KryptonRadioButton()
        Me.kryptonOffice2007Black = New Krypton.Toolkit.KryptonRadioButton()
        Me.kryptonOffice2007Silver = New Krypton.Toolkit.KryptonRadioButton()
        Me.kryptonOffice2007Blue = New Krypton.Toolkit.KryptonRadioButton()
        Me.kryptonManager = New Krypton.Toolkit.KryptonManager(Me.components)
        Me.kryptonPaletteCustom = New Krypton.Toolkit.KryptonCustomPaletteBase(Me.components)
        Me.toolTip1 = New System.Windows.Forms.ToolTip(Me.components)
        CType(Me.kryptonPanel1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.kryptonPanel1.SuspendLayout()
        CType(Me.kryptonGroup1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.kryptonGroup1.Panel, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.kryptonGroup1.Panel.SuspendLayout()
        Me.kryptonGroup1.SuspendLayout()
        Me.SuspendLayout()
        Me.kryptonPanel1.Controls.Add(Me.btnLongContentsNoOwner)
        Me.kryptonPanel1.Controls.Add(Me.btnLongTitleNoOwner)
        Me.kryptonPanel1.Controls.Add(Me.btnLongContents)
        Me.kryptonPanel1.Controls.Add(Me.btnLongTitle)
        Me.kryptonPanel1.Controls.Add(Me.btnStackTrace)
        Me.kryptonPanel1.Controls.Add(Me.btnCarriageReturns)
        Me.kryptonPanel1.Controls.Add(Me.btnSingleLines)
        Me.kryptonPanel1.Controls.Add(Me.kryptonGroup1)
        Me.kryptonPanel1.Dock = System.Windows.Forms.DockStyle.Fill
        Me.kryptonPanel1.Location = New System.Drawing.Point(0, 0)
        Me.kryptonPanel1.Name = "kryptonPanel1"
        Me.kryptonPanel1.Size = New System.Drawing.Size(715, 457)
        Me.kryptonPanel1.TabIndex = 0
        Me.toolTip1.SetToolTip(Me.kryptonPanel1, "sadsdafdffg")
        Me.btnLongContentsNoOwner.Location = New System.Drawing.Point(147, 103)
        Me.btnLongContentsNoOwner.Name = "btnLongContentsNoOwner"
        Me.btnLongContentsNoOwner.Size = New System.Drawing.Size(190, 25)
        Me.btnLongContentsNoOwner.TabIndex = 8
        Me.btnLongContentsNoOwner.Values.DropDownArrowColor = System.Drawing.Color.Empty
        Me.btnLongContentsNoOwner.Values.Text = "Long Contents - No Owner"
        Me.btnLongTitleNoOwner.Location = New System.Drawing.Point(147, 58)
        Me.btnLongTitleNoOwner.Name = "btnLongTitleNoOwner"
        Me.btnLongTitleNoOwner.Size = New System.Drawing.Size(190, 25)
        Me.btnLongTitleNoOwner.TabIndex = 7
        Me.btnLongTitleNoOwner.Values.DropDownArrowColor = System.Drawing.Color.Empty
        Me.btnLongTitleNoOwner.Values.Text = "Long Title - No Owner"
        Me.btnLongContents.Location = New System.Drawing.Point(13, 103)
        Me.btnLongContents.Name = "btnLongContents"
        Me.btnLongContents.Size = New System.Drawing.Size(121, 25)
        Me.btnLongContents.TabIndex = 6
        Me.btnLongContents.Values.DropDownArrowColor = System.Drawing.Color.Empty
        Me.btnLongContents.Values.Text = "Long Contents"
        Me.btnLongTitle.Location = New System.Drawing.Point(13, 58)
        Me.btnLongTitle.Name = "btnLongTitle"
        Me.btnLongTitle.Size = New System.Drawing.Size(121, 25)
        Me.btnLongTitle.TabIndex = 5
        Me.btnLongTitle.Values.DropDownArrowColor = System.Drawing.Color.Empty
        Me.btnLongTitle.Values.Text = "Long Title"
        Me.btnStackTrace.Location = New System.Drawing.Point(295, 12)
        Me.btnStackTrace.Name = "btnStackTrace"
        Me.btnStackTrace.Size = New System.Drawing.Size(219, 25)
        Me.btnStackTrace.TabIndex = 4
        Me.btnStackTrace.Values.DropDownArrowColor = System.Drawing.Color.Empty
        Me.btnStackTrace.Values.Text = "Exception Stack Trace"
        Me.btnCarriageReturns.Location = New System.Drawing.Point(142, 13)
        Me.btnCarriageReturns.Name = "btnCarriageReturns"
        Me.btnCarriageReturns.Size = New System.Drawing.Size(133, 25)
        Me.btnCarriageReturns.TabIndex = 3
        Me.btnCarriageReturns.Values.DropDownArrowColor = System.Drawing.Color.Empty
        Me.btnCarriageReturns.Values.Text = "Carriage Returns"
        Me.btnSingleLines.Location = New System.Drawing.Point(13, 13)
        Me.btnSingleLines.Name = "btnSingleLines"
        Me.btnSingleLines.Size = New System.Drawing.Size(121, 25)
        Me.btnSingleLines.TabIndex = 2
        Me.btnSingleLines.Values.DropDownArrowColor = System.Drawing.Color.Empty
        Me.btnSingleLines.Values.Text = "Single Lines"
        Me.kryptonGroup1.Dock = System.Windows.Forms.DockStyle.Bottom
        Me.kryptonGroup1.Location = New System.Drawing.Point(0, 370)
        Me.kryptonGroup1.Name = "kryptonGroup1"
        Me.kryptonGroup1.Panel.Controls.Add(Me.kryptonOffice2010Black)
        Me.kryptonGroup1.Panel.Controls.Add(Me.kryptonSparkleOrange)
        Me.kryptonGroup1.Panel.Controls.Add(Me.kryptonOffice2010Blue)
        Me.kryptonGroup1.Panel.Controls.Add(Me.kryptonOffice2010Silver)
        Me.kryptonGroup1.Panel.Controls.Add(Me.kryptonOffice2013White)
        Me.kryptonGroup1.Panel.Controls.Add(Me.kryptonSparklePurple)
        Me.kryptonGroup1.Panel.Controls.Add(Me.kryptonSparkleBlue)
        Me.kryptonGroup1.Panel.Controls.Add(Me.kryptonCustom)
        Me.kryptonGroup1.Panel.Controls.Add(Me.kryptonSystem)
        Me.kryptonGroup1.Panel.Controls.Add(Me.kryptonOffice2003)
        Me.kryptonGroup1.Panel.Controls.Add(Me.kryptonOffice2007Black)
        Me.kryptonGroup1.Panel.Controls.Add(Me.kryptonOffice2007Silver)
        Me.kryptonGroup1.Panel.Controls.Add(Me.kryptonOffice2007Blue)
        Me.kryptonGroup1.Size = New System.Drawing.Size(715, 87)
        Me.kryptonGroup1.TabIndex = 1
        Me.kryptonOffice2010Black.Location = New System.Drawing.Point(7, 60)
        Me.kryptonOffice2010Black.Name = "kryptonOffice2010Black"
        Me.kryptonOffice2010Black.Size = New System.Drawing.Size(151, 24)
        Me.kryptonOffice2010Black.TabIndex = 2
        Me.kryptonOffice2010Black.Values.Text = "Office 2010 - Black"
        Me.kryptonSparkleOrange.Location = New System.Drawing.Point(294, 35)
        Me.kryptonSparkleOrange.Name = "kryptonSparkleOrange"
        Me.kryptonSparkleOrange.Size = New System.Drawing.Size(139, 24)
        Me.kryptonSparkleOrange.TabIndex = 7
        Me.kryptonSparkleOrange.Values.Text = "Sparkle - Orange"
        Me.kryptonOffice2010Blue.Checked = True
        Me.kryptonOffice2010Blue.Location = New System.Drawing.Point(7, 10)
        Me.kryptonOffice2010Blue.Name = "kryptonOffice2010Blue"
        Me.kryptonOffice2010Blue.Size = New System.Drawing.Size(145, 24)
        Me.kryptonOffice2010Blue.TabIndex = 0
        Me.kryptonOffice2010Blue.Values.Text = "Office 2010 - Blue"
        Me.kryptonOffice2010Silver.Location = New System.Drawing.Point(7, 35)
        Me.kryptonOffice2010Silver.Name = "kryptonOffice2010Silver"
        Me.kryptonOffice2010Silver.Size = New System.Drawing.Size(153, 24)
        Me.kryptonOffice2010Silver.TabIndex = 1
        Me.kryptonOffice2010Silver.Values.Text = "Office 2010 - Silver"
        Me.kryptonOffice2013White.Location = New System.Drawing.Point(531, 10)
        Me.kryptonOffice2013White.Name = "kryptonOffice2013White"
        Me.kryptonOffice2013White.Size = New System.Drawing.Size(156, 24)
        Me.kryptonOffice2013White.TabIndex = 22
        Me.kryptonOffice2013White.Values.Text = "Office 2013 - White"
        Me.kryptonSparklePurple.Location = New System.Drawing.Point(294, 60)
        Me.kryptonSparklePurple.Name = "kryptonSparklePurple"
        Me.kryptonSparklePurple.Size = New System.Drawing.Size(132, 24)
        Me.kryptonSparklePurple.TabIndex = 8
        Me.kryptonSparklePurple.Values.Text = "Sparkle - Purple"
        Me.kryptonSparkleBlue.Location = New System.Drawing.Point(294, 10)
        Me.kryptonSparkleBlue.Name = "kryptonSparkleBlue"
        Me.kryptonSparkleBlue.Size = New System.Drawing.Size(118, 24)
        Me.kryptonSparkleBlue.TabIndex = 6
        Me.kryptonSparkleBlue.Values.Text = "Sparkle - Blue"
        Me.kryptonCustom.Location = New System.Drawing.Point(428, 60)
        Me.kryptonCustom.Name = "kryptonCustom"
        Me.kryptonCustom.Size = New System.Drawing.Size(76, 24)
        Me.kryptonCustom.TabIndex = 11
        Me.kryptonCustom.Values.Text = "Custom"
        Me.kryptonSystem.Location = New System.Drawing.Point(428, 35)
        Me.kryptonSystem.Name = "kryptonSystem"
        Me.kryptonSystem.Size = New System.Drawing.Size(72, 24)
        Me.kryptonSystem.TabIndex = 10
        Me.kryptonSystem.Values.Text = "System"
        Me.kryptonOffice2003.Location = New System.Drawing.Point(428, 10)
        Me.kryptonOffice2003.Name = "kryptonOffice2003"
        Me.kryptonOffice2003.Size = New System.Drawing.Size(101, 24)
        Me.kryptonOffice2003.TabIndex = 9
        Me.kryptonOffice2003.Values.Text = "Office 2003"
        Me.kryptonOffice2007Black.Location = New System.Drawing.Point(141, 60)
        Me.kryptonOffice2007Black.Name = "kryptonOffice2007Black"
        Me.kryptonOffice2007Black.Size = New System.Drawing.Size(151, 24)
        Me.kryptonOffice2007Black.TabIndex = 5
        Me.kryptonOffice2007Black.Values.Text = "Office 2007 - Black"
        Me.kryptonOffice2007Silver.Location = New System.Drawing.Point(141, 35)
        Me.kryptonOffice2007Silver.Name = "kryptonOffice2007Silver"
        Me.kryptonOffice2007Silver.Size = New System.Drawing.Size(153, 24)
        Me.kryptonOffice2007Silver.TabIndex = 4
        Me.kryptonOffice2007Silver.Values.Text = "Office 2007 - Silver"
        Me.kryptonOffice2007Blue.Location = New System.Drawing.Point(141, 10)
        Me.kryptonOffice2007Blue.Name = "kryptonOffice2007Blue"
        Me.kryptonOffice2007Blue.Size = New System.Drawing.Size(145, 24)
        Me.kryptonOffice2007Blue.TabIndex = 3
        Me.kryptonOffice2007Blue.Values.Text = "Office 2007 - Blue"
        Me.kryptonManager.GlobalPaletteMode = Krypton.Toolkit.PaletteMode.Office2010Blue
        Me.kryptonPaletteCustom.BasePaletteType = Krypton.Toolkit.BasePaletteType.Professional
        Me.kryptonPaletteCustom.ButtonStyles.ButtonButtonSpec.StateDisabled.Border.Draw = Krypton.Toolkit.InheritBool.False
        Me.kryptonPaletteCustom.ButtonStyles.ButtonButtonSpec.StateDisabled.Border.DrawBorders = CType((((Krypton.Toolkit.PaletteDrawBorders.Top Or Krypton.Toolkit.PaletteDrawBorders.Bottom) Or Krypton.Toolkit.PaletteDrawBorders.Left) Or Krypton.Toolkit.PaletteDrawBorders.Right), Krypton.Toolkit.PaletteDrawBorders)
        Me.kryptonPaletteCustom.ButtonStyles.ButtonButtonSpec.StateNormal.Back.Draw = Krypton.Toolkit.InheritBool.False
        Me.kryptonPaletteCustom.ButtonStyles.ButtonButtonSpec.StateNormal.Border.Color1 = System.Drawing.Color.Transparent
        Me.kryptonPaletteCustom.ButtonStyles.ButtonButtonSpec.StateNormal.Border.Draw = Krypton.Toolkit.InheritBool.True
        Me.kryptonPaletteCustom.ButtonStyles.ButtonButtonSpec.StateNormal.Border.DrawBorders = CType((((Krypton.Toolkit.PaletteDrawBorders.Top Or Krypton.Toolkit.PaletteDrawBorders.Bottom) Or Krypton.Toolkit.PaletteDrawBorders.Left) Or Krypton.Toolkit.PaletteDrawBorders.Right), Krypton.Toolkit.PaletteDrawBorders)
        Me.kryptonPaletteCustom.ButtonStyles.ButtonButtonSpec.StateNormal.Content.LongText.Color1 = System.Drawing.Color.Black
        Me.kryptonPaletteCustom.ButtonStyles.ButtonButtonSpec.StateNormal.Content.Padding = New System.Windows.Forms.Padding(3)
        Me.kryptonPaletteCustom.ButtonStyles.ButtonButtonSpec.StateNormal.Content.ShortText.Color1 = System.Drawing.Color.Black
        Me.kryptonPaletteCustom.ButtonStyles.ButtonCommon.StateCheckedNormal.Back.Color1 = System.Drawing.Color.FromArgb(CType(CType(192, Byte), Integer), CType(CType(64, Byte), Integer), CType(CType(0, Byte), Integer))
        Me.kryptonPaletteCustom.ButtonStyles.ButtonCommon.StateCheckedPressed.Back.Color1 = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(102, Byte), Integer), CType(CType(0, Byte), Integer))
        Me.kryptonPaletteCustom.ButtonStyles.ButtonCommon.StateCheckedPressed.Content.Padding = New System.Windows.Forms.Padding(5, 5, 1, 1)
        Me.kryptonPaletteCustom.ButtonStyles.ButtonCommon.StateCheckedTracking.Back.Color1 = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(102, Byte), Integer), CType(CType(0, Byte), Integer))
        Me.kryptonPaletteCustom.ButtonStyles.ButtonCommon.StateCommon.Back.ColorStyle = Krypton.Toolkit.PaletteColorStyle.Solid
        Me.kryptonPaletteCustom.ButtonStyles.ButtonCommon.StateCommon.Border.Color1 = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(51, Byte), Integer), CType(CType(102, Byte), Integer))
        Me.kryptonPaletteCustom.ButtonStyles.ButtonCommon.StateCommon.Border.ColorStyle = Krypton.Toolkit.PaletteColorStyle.Solid
        Me.kryptonPaletteCustom.ButtonStyles.ButtonCommon.StateCommon.Border.DrawBorders = CType((((Krypton.Toolkit.PaletteDrawBorders.Top Or Krypton.Toolkit.PaletteDrawBorders.Bottom) Or Krypton.Toolkit.PaletteDrawBorders.Left) Or Krypton.Toolkit.PaletteDrawBorders.Right), Krypton.Toolkit.PaletteDrawBorders)
        Me.kryptonPaletteCustom.ButtonStyles.ButtonCommon.StateCommon.Border.GraphicsHint = Krypton.Toolkit.PaletteGraphicsHint.AntiAlias
        Me.kryptonPaletteCustom.ButtonStyles.ButtonCommon.StateCommon.Border.Rounding = 3F
        Me.kryptonPaletteCustom.ButtonStyles.ButtonCommon.StateCommon.Border.Width = 2
        Me.kryptonPaletteCustom.ButtonStyles.ButtonCommon.StateCommon.Content.LongText.Color1 = System.Drawing.Color.White
        Me.kryptonPaletteCustom.ButtonStyles.ButtonCommon.StateCommon.Content.LongText.ColorStyle = Krypton.Toolkit.PaletteColorStyle.Solid
        Me.kryptonPaletteCustom.ButtonStyles.ButtonCommon.StateCommon.Content.Padding = New System.Windows.Forms.Padding(3)
        Me.kryptonPaletteCustom.ButtonStyles.ButtonCommon.StateCommon.Content.ShortText.Color1 = System.Drawing.Color.White
        Me.kryptonPaletteCustom.ButtonStyles.ButtonCommon.StateCommon.Content.ShortText.ColorStyle = Krypton.Toolkit.PaletteColorStyle.Solid
        Me.kryptonPaletteCustom.ButtonStyles.ButtonCommon.StateDisabled.Border.Color1 = System.Drawing.Color.Silver
        Me.kryptonPaletteCustom.ButtonStyles.ButtonCommon.StateDisabled.Border.DrawBorders = CType((((Krypton.Toolkit.PaletteDrawBorders.Top Or Krypton.Toolkit.PaletteDrawBorders.Bottom) Or Krypton.Toolkit.PaletteDrawBorders.Left) Or Krypton.Toolkit.PaletteDrawBorders.Right), Krypton.Toolkit.PaletteDrawBorders)
        Me.kryptonPaletteCustom.ButtonStyles.ButtonCommon.StateDisabled.Content.LongText.Color1 = System.Drawing.Color.Silver
        Me.kryptonPaletteCustom.ButtonStyles.ButtonCommon.StateDisabled.Content.ShortText.Color1 = System.Drawing.Color.Silver
        Me.kryptonPaletteCustom.ButtonStyles.ButtonCommon.StateNormal.Back.Color1 = System.Drawing.Color.FromArgb(CType(CType(51, Byte), Integer), CType(CType(102, Byte), Integer), CType(CType(204, Byte), Integer))
        Me.kryptonPaletteCustom.ButtonStyles.ButtonCommon.StatePressed.Back.Color1 = System.Drawing.Color.FromArgb(CType(CType(102, Byte), Integer), CType(CType(153, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.kryptonPaletteCustom.ButtonStyles.ButtonCommon.StatePressed.Content.Padding = New System.Windows.Forms.Padding(5, 5, 1, 1)
        Me.kryptonPaletteCustom.ButtonStyles.ButtonCommon.StateTracking.Back.Color1 = System.Drawing.Color.FromArgb(CType(CType(102, Byte), Integer), CType(CType(153, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.kryptonPaletteCustom.ButtonStyles.ButtonLowProfile.StateDisabled.Border.Draw = Krypton.Toolkit.InheritBool.False
        Me.kryptonPaletteCustom.ButtonStyles.ButtonLowProfile.StateDisabled.Border.DrawBorders = CType((((Krypton.Toolkit.PaletteDrawBorders.Top Or Krypton.Toolkit.PaletteDrawBorders.Bottom) Or Krypton.Toolkit.PaletteDrawBorders.Left) Or Krypton.Toolkit.PaletteDrawBorders.Right), Krypton.Toolkit.PaletteDrawBorders)
        Me.kryptonPaletteCustom.ButtonStyles.ButtonLowProfile.StateNormal.Back.Draw = Krypton.Toolkit.InheritBool.False
        Me.kryptonPaletteCustom.ButtonStyles.ButtonLowProfile.StateNormal.Border.Color1 = System.Drawing.Color.Transparent
        Me.kryptonPaletteCustom.ButtonStyles.ButtonLowProfile.StateNormal.Border.Draw = Krypton.Toolkit.InheritBool.True
        Me.kryptonPaletteCustom.ButtonStyles.ButtonLowProfile.StateNormal.Border.DrawBorders = CType((((Krypton.Toolkit.PaletteDrawBorders.Top Or Krypton.Toolkit.PaletteDrawBorders.Bottom) Or Krypton.Toolkit.PaletteDrawBorders.Left) Or Krypton.Toolkit.PaletteDrawBorders.Right), Krypton.Toolkit.PaletteDrawBorders)
        Me.kryptonPaletteCustom.ButtonStyles.ButtonLowProfile.StateNormal.Content.LongText.Color1 = System.Drawing.Color.Black
        Me.kryptonPaletteCustom.ButtonStyles.ButtonLowProfile.StateNormal.Content.Padding = New System.Windows.Forms.Padding(3)
        Me.kryptonPaletteCustom.ButtonStyles.ButtonLowProfile.StateNormal.Content.ShortText.Color1 = System.Drawing.Color.Black
        Me.kryptonPaletteCustom.ButtonStyles.ButtonStandalone.OverrideDefault.Back.Color1 = System.Drawing.Color.FromArgb(CType(CType(51, Byte), Integer), CType(CType(102, Byte), Integer), CType(CType(204, Byte), Integer))
        Me.kryptonPaletteCustom.ButtonStyles.ButtonStandalone.StateDisabled.Back.Color1 = System.Drawing.Color.FromArgb(CType(CType(245, Byte), Integer), CType(CType(237, Byte), Integer), CType(CType(227, Byte), Integer))
        Me.kryptonPaletteCustom.ControlStyles.ControlCommon.StateCommon.Border.ColorStyle = Krypton.Toolkit.PaletteColorStyle.Solid
        Me.kryptonPaletteCustom.ControlStyles.ControlCommon.StateCommon.Border.DrawBorders = CType((((Krypton.Toolkit.PaletteDrawBorders.Top Or Krypton.Toolkit.PaletteDrawBorders.Bottom) Or Krypton.Toolkit.PaletteDrawBorders.Left) Or Krypton.Toolkit.PaletteDrawBorders.Right), Krypton.Toolkit.PaletteDrawBorders)
        Me.kryptonPaletteCustom.ControlStyles.ControlCommon.StateCommon.Border.GraphicsHint = Krypton.Toolkit.PaletteGraphicsHint.AntiAlias
        Me.kryptonPaletteCustom.ControlStyles.ControlCommon.StateCommon.Border.Rounding = 9F
        Me.kryptonPaletteCustom.ControlStyles.ControlCommon.StateCommon.Border.Width = 3
        Me.kryptonPaletteCustom.ControlStyles.ControlCommon.StateDisabled.Border.Color1 = System.Drawing.Color.FromArgb(CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer))
        Me.kryptonPaletteCustom.ControlStyles.ControlCommon.StateDisabled.Border.DrawBorders = CType((((Krypton.Toolkit.PaletteDrawBorders.Top Or Krypton.Toolkit.PaletteDrawBorders.Bottom) Or Krypton.Toolkit.PaletteDrawBorders.Left) Or Krypton.Toolkit.PaletteDrawBorders.Right), Krypton.Toolkit.PaletteDrawBorders)
        Me.kryptonPaletteCustom.ControlStyles.ControlCommon.StateNormal.Border.Color1 = System.Drawing.Color.FromArgb(CType(CType(225, Byte), Integer), CType(CType(212, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.kryptonPaletteCustom.ControlStyles.ControlCommon.StateNormal.Border.DrawBorders = CType((((Krypton.Toolkit.PaletteDrawBorders.Top Or Krypton.Toolkit.PaletteDrawBorders.Bottom) Or Krypton.Toolkit.PaletteDrawBorders.Left) Or Krypton.Toolkit.PaletteDrawBorders.Right), Krypton.Toolkit.PaletteDrawBorders)
        Me.kryptonPaletteCustom.HeaderGroup.StateCommon.OverlayHeaders = Krypton.Toolkit.InheritBool.False
        Me.kryptonPaletteCustom.HeaderGroup.StateCommon.PrimaryHeaderPadding = New System.Windows.Forms.Padding(3)
        Me.kryptonPaletteCustom.HeaderGroup.StateCommon.SecondaryHeaderPadding = New System.Windows.Forms.Padding(3)
        Me.kryptonPaletteCustom.HeaderStyles.HeaderCommon.StateCommon.Back.ColorStyle = Krypton.Toolkit.PaletteColorStyle.Linear
        Me.kryptonPaletteCustom.HeaderStyles.HeaderCommon.StateCommon.Back.GraphicsHint = Krypton.Toolkit.PaletteGraphicsHint.AntiAlias
        Me.kryptonPaletteCustom.HeaderStyles.HeaderCommon.StateCommon.Border.Draw = Krypton.Toolkit.InheritBool.False
        Me.kryptonPaletteCustom.HeaderStyles.HeaderCommon.StateCommon.Border.DrawBorders = CType((((Krypton.Toolkit.PaletteDrawBorders.Top Or Krypton.Toolkit.PaletteDrawBorders.Bottom) Or Krypton.Toolkit.PaletteDrawBorders.Left) Or Krypton.Toolkit.PaletteDrawBorders.Right), Krypton.Toolkit.PaletteDrawBorders)
        Me.kryptonPaletteCustom.HeaderStyles.HeaderCommon.StateCommon.Border.Rounding = 7F
        Me.kryptonPaletteCustom.HeaderStyles.HeaderCommon.StateCommon.Border.Width = 3
        Me.kryptonPaletteCustom.HeaderStyles.HeaderCommon.StateCommon.Content.AdjacentGap = 2
        Me.kryptonPaletteCustom.HeaderStyles.HeaderCommon.StateCommon.Content.LongText.Color1 = System.Drawing.Color.Black
        Me.kryptonPaletteCustom.HeaderStyles.HeaderCommon.StateCommon.Content.LongText.ColorStyle = Krypton.Toolkit.PaletteColorStyle.Solid
        Me.kryptonPaletteCustom.HeaderStyles.HeaderCommon.StateCommon.Content.LongText.TextH = Krypton.Toolkit.PaletteRelativeAlign.Far
        Me.kryptonPaletteCustom.HeaderStyles.HeaderCommon.StateCommon.Content.Padding = New System.Windows.Forms.Padding(10, 2, 10, 2)
        Me.kryptonPaletteCustom.HeaderStyles.HeaderCommon.StateCommon.Content.ShortText.Color1 = System.Drawing.Color.Black
        Me.kryptonPaletteCustom.HeaderStyles.HeaderCommon.StateCommon.Content.ShortText.ColorStyle = Krypton.Toolkit.PaletteColorStyle.Solid
        Me.kryptonPaletteCustom.HeaderStyles.HeaderCommon.StateCommon.Content.ShortText.TextH = Krypton.Toolkit.PaletteRelativeAlign.Near
        Me.kryptonPaletteCustom.HeaderStyles.HeaderCommon.StateDisabled.Content.LongText.Color1 = System.Drawing.Color.Silver
        Me.kryptonPaletteCustom.HeaderStyles.HeaderCommon.StateDisabled.Content.ShortText.Color1 = System.Drawing.Color.Silver
        Me.kryptonPaletteCustom.HeaderStyles.HeaderPrimary.StateDisabled.Back.Color1 = System.Drawing.Color.FromArgb(CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer))
        Me.kryptonPaletteCustom.HeaderStyles.HeaderPrimary.StateDisabled.Back.Color2 = System.Drawing.Color.White
        Me.kryptonPaletteCustom.HeaderStyles.HeaderPrimary.StateNormal.Back.Color1 = System.Drawing.Color.FromArgb(CType(CType(226, Byte), Integer), CType(CType(213, Byte), Integer), CType(CType(194, Byte), Integer))
        Me.kryptonPaletteCustom.HeaderStyles.HeaderPrimary.StateNormal.Back.Color2 = System.Drawing.Color.White
        Me.kryptonPaletteCustom.HeaderStyles.HeaderSecondary.StateDisabled.Back.Color1 = System.Drawing.Color.White
        Me.kryptonPaletteCustom.HeaderStyles.HeaderSecondary.StateDisabled.Back.Color2 = System.Drawing.Color.FromArgb(CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer))
        Me.kryptonPaletteCustom.HeaderStyles.HeaderSecondary.StateNormal.Back.Color1 = System.Drawing.Color.White
        Me.kryptonPaletteCustom.HeaderStyles.HeaderSecondary.StateNormal.Back.Color2 = System.Drawing.Color.FromArgb(CType(CType(226, Byte), Integer), CType(CType(213, Byte), Integer), CType(CType(194, Byte), Integer))
        Me.kryptonPaletteCustom.PanelStyles.PanelAlternate.StateCommon.Color1 = System.Drawing.Color.FromArgb(CType(CType(225, Byte), Integer), CType(CType(212, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.kryptonPaletteCustom.PanelStyles.PanelClient.StateCommon.Color1 = System.Drawing.Color.FromArgb(CType(CType(245, Byte), Integer), CType(CType(237, Byte), Integer), CType(CType(227, Byte), Integer))
        Me.kryptonPaletteCustom.PanelStyles.PanelCommon.StateCommon.ColorStyle = Krypton.Toolkit.PaletteColorStyle.Solid
        Me.kryptonPaletteCustom.ThemeName = "PaletteBase"
        Me.kryptonPaletteCustom.ToolMenuStatus.Button.ButtonCheckedGradientBegin = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(102, Byte), Integer), CType(CType(0, Byte), Integer))
        Me.kryptonPaletteCustom.ToolMenuStatus.Button.ButtonCheckedGradientEnd = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(102, Byte), Integer), CType(CType(0, Byte), Integer))
        Me.kryptonPaletteCustom.ToolMenuStatus.Button.ButtonCheckedGradientMiddle = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(102, Byte), Integer), CType(CType(0, Byte), Integer))
        Me.kryptonPaletteCustom.ToolMenuStatus.Button.ButtonCheckedHighlight = System.Drawing.Color.FromArgb(CType(CType(192, Byte), Integer), CType(CType(64, Byte), Integer), CType(CType(0, Byte), Integer))
        Me.kryptonPaletteCustom.ToolMenuStatus.Button.ButtonCheckedHighlightBorder = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(51, Byte), Integer), CType(CType(102, Byte), Integer))
        Me.kryptonPaletteCustom.ToolMenuStatus.Button.ButtonPressedBorder = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(51, Byte), Integer), CType(CType(102, Byte), Integer))
        Me.kryptonPaletteCustom.ToolMenuStatus.Button.ButtonPressedGradientBegin = System.Drawing.Color.FromArgb(CType(CType(192, Byte), Integer), CType(CType(64, Byte), Integer), CType(CType(0, Byte), Integer))
        Me.kryptonPaletteCustom.ToolMenuStatus.Button.ButtonPressedGradientEnd = System.Drawing.Color.FromArgb(CType(CType(192, Byte), Integer), CType(CType(64, Byte), Integer), CType(CType(0, Byte), Integer))
        Me.kryptonPaletteCustom.ToolMenuStatus.Button.ButtonPressedGradientMiddle = System.Drawing.Color.FromArgb(CType(CType(192, Byte), Integer), CType(CType(64, Byte), Integer), CType(CType(0, Byte), Integer))
        Me.kryptonPaletteCustom.ToolMenuStatus.Button.ButtonPressedHighlight = System.Drawing.Color.FromArgb(CType(CType(192, Byte), Integer), CType(CType(64, Byte), Integer), CType(CType(0, Byte), Integer))
        Me.kryptonPaletteCustom.ToolMenuStatus.Button.ButtonPressedHighlightBorder = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(51, Byte), Integer), CType(CType(102, Byte), Integer))
        Me.kryptonPaletteCustom.ToolMenuStatus.Button.ButtonSelectedBorder = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(51, Byte), Integer), CType(CType(102, Byte), Integer))
        Me.kryptonPaletteCustom.ToolMenuStatus.Button.ButtonSelectedGradientBegin = System.Drawing.Color.FromArgb(CType(CType(102, Byte), Integer), CType(CType(153, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.kryptonPaletteCustom.ToolMenuStatus.Button.ButtonSelectedGradientEnd = System.Drawing.Color.FromArgb(CType(CType(102, Byte), Integer), CType(CType(153, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.kryptonPaletteCustom.ToolMenuStatus.Button.ButtonSelectedGradientMiddle = System.Drawing.Color.FromArgb(CType(CType(102, Byte), Integer), CType(CType(153, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.kryptonPaletteCustom.ToolMenuStatus.Button.ButtonSelectedHighlight = System.Drawing.Color.FromArgb(CType(CType(102, Byte), Integer), CType(CType(153, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.kryptonPaletteCustom.ToolMenuStatus.Button.ButtonSelectedHighlightBorder = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(51, Byte), Integer), CType(CType(102, Byte), Integer))
        Me.kryptonPaletteCustom.ToolMenuStatus.Button.CheckBackground = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(102, Byte), Integer), CType(CType(0, Byte), Integer))
        Me.kryptonPaletteCustom.ToolMenuStatus.Button.CheckPressedBackground = System.Drawing.Color.FromArgb(CType(CType(192, Byte), Integer), CType(CType(64, Byte), Integer), CType(CType(0, Byte), Integer))
        Me.kryptonPaletteCustom.ToolMenuStatus.Button.CheckSelectedBackground = System.Drawing.Color.FromArgb(CType(CType(192, Byte), Integer), CType(CType(64, Byte), Integer), CType(CType(0, Byte), Integer))
        Me.kryptonPaletteCustom.ToolMenuStatus.Button.OverflowButtonGradientBegin = System.Drawing.Color.FromArgb(CType(CType(102, Byte), Integer), CType(CType(153, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.kryptonPaletteCustom.ToolMenuStatus.Button.OverflowButtonGradientEnd = System.Drawing.Color.FromArgb(CType(CType(26, Byte), Integer), CType(CType(77, Byte), Integer), CType(CType(144, Byte), Integer))
        Me.kryptonPaletteCustom.ToolMenuStatus.Button.OverflowButtonGradientMiddle = System.Drawing.Color.FromArgb(CType(CType(76, Byte), Integer), CType(CType(126, Byte), Integer), CType(CType(226, Byte), Integer))
        Me.kryptonPaletteCustom.ToolMenuStatus.Grip.GripDark = System.Drawing.Color.FromArgb(CType(CType(72, Byte), Integer), CType(CType(133, Byte), Integer), CType(CType(215, Byte), Integer))
        Me.kryptonPaletteCustom.ToolMenuStatus.Grip.GripLight = System.Drawing.Color.Transparent
        Me.kryptonPaletteCustom.ToolMenuStatus.Menu.ImageMarginGradientBegin = System.Drawing.Color.FromArgb(CType(CType(102, Byte), Integer), CType(CType(153, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.kryptonPaletteCustom.ToolMenuStatus.Menu.ImageMarginGradientEnd = System.Drawing.Color.FromArgb(CType(CType(51, Byte), Integer), CType(CType(102, Byte), Integer), CType(CType(204, Byte), Integer))
        Me.kryptonPaletteCustom.ToolMenuStatus.Menu.ImageMarginGradientMiddle = System.Drawing.Color.FromArgb(CType(CType(76, Byte), Integer), CType(CType(126, Byte), Integer), CType(CType(226, Byte), Integer))
        Me.kryptonPaletteCustom.ToolMenuStatus.Menu.ImageMarginRevealedGradientBegin = System.Drawing.Color.FromArgb(CType(CType(102, Byte), Integer), CType(CType(153, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.kryptonPaletteCustom.ToolMenuStatus.Menu.ImageMarginRevealedGradientEnd = System.Drawing.Color.FromArgb(CType(CType(51, Byte), Integer), CType(CType(102, Byte), Integer), CType(CType(204, Byte), Integer))
        Me.kryptonPaletteCustom.ToolMenuStatus.Menu.ImageMarginRevealedGradientMiddle = System.Drawing.Color.FromArgb(CType(CType(76, Byte), Integer), CType(CType(126, Byte), Integer), CType(CType(226, Byte), Integer))
        Me.kryptonPaletteCustom.ToolMenuStatus.Menu.MenuBorder = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(51, Byte), Integer), CType(CType(102, Byte), Integer))
        Me.kryptonPaletteCustom.ToolMenuStatus.Menu.MenuItemBorder = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(51, Byte), Integer), CType(CType(102, Byte), Integer))
        Me.kryptonPaletteCustom.ToolMenuStatus.Menu.MenuItemPressedGradientBegin = System.Drawing.Color.FromArgb(CType(CType(102, Byte), Integer), CType(CType(153, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.kryptonPaletteCustom.ToolMenuStatus.Menu.MenuItemPressedGradientEnd = System.Drawing.Color.FromArgb(CType(CType(51, Byte), Integer), CType(CType(102, Byte), Integer), CType(CType(204, Byte), Integer))
        Me.kryptonPaletteCustom.ToolMenuStatus.Menu.MenuItemPressedGradientMiddle = System.Drawing.Color.FromArgb(CType(CType(51, Byte), Integer), CType(CType(102, Byte), Integer), CType(CType(204, Byte), Integer))
        Me.kryptonPaletteCustom.ToolMenuStatus.Menu.MenuItemSelected = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(102, Byte), Integer), CType(CType(0, Byte), Integer))
        Me.kryptonPaletteCustom.ToolMenuStatus.Menu.MenuItemSelectedGradientBegin = System.Drawing.Color.FromArgb(CType(CType(102, Byte), Integer), CType(CType(153, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.kryptonPaletteCustom.ToolMenuStatus.Menu.MenuItemSelectedGradientEnd = System.Drawing.Color.FromArgb(CType(CType(102, Byte), Integer), CType(CType(153, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.kryptonPaletteCustom.ToolMenuStatus.Menu.MenuItemText = System.Drawing.Color.White
        Me.kryptonPaletteCustom.ToolMenuStatus.MenuStrip.MenuStripGradientBegin = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(51, Byte), Integer), CType(CType(102, Byte), Integer))
        Me.kryptonPaletteCustom.ToolMenuStatus.MenuStrip.MenuStripGradientEnd = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(51, Byte), Integer), CType(CType(102, Byte), Integer))
        Me.kryptonPaletteCustom.ToolMenuStatus.MenuStrip.MenuStripText = System.Drawing.Color.WhiteSmoke
        Me.kryptonPaletteCustom.ToolMenuStatus.Rafting.RaftingContainerGradientBegin = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(51, Byte), Integer), CType(CType(102, Byte), Integer))
        Me.kryptonPaletteCustom.ToolMenuStatus.Rafting.RaftingContainerGradientEnd = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(51, Byte), Integer), CType(CType(102, Byte), Integer))
        Me.kryptonPaletteCustom.ToolMenuStatus.Separator.SeparatorDark = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(51, Byte), Integer), CType(CType(102, Byte), Integer))
        Me.kryptonPaletteCustom.ToolMenuStatus.Separator.SeparatorLight = System.Drawing.Color.Transparent
        Me.kryptonPaletteCustom.ToolMenuStatus.StatusStrip.StatusStripGradientBegin = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(51, Byte), Integer), CType(CType(102, Byte), Integer))
        Me.kryptonPaletteCustom.ToolMenuStatus.StatusStrip.StatusStripGradientEnd = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(51, Byte), Integer), CType(CType(102, Byte), Integer))
        Me.kryptonPaletteCustom.ToolMenuStatus.StatusStrip.StatusStripText = System.Drawing.Color.WhiteSmoke
        Me.kryptonPaletteCustom.ToolMenuStatus.ToolStrip.ToolStripBorder = System.Drawing.Color.FromArgb(CType(CType(26, Byte), Integer), CType(CType(77, Byte), Integer), CType(CType(144, Byte), Integer))
        Me.kryptonPaletteCustom.ToolMenuStatus.ToolStrip.ToolStripContentPanelGradientBegin = System.Drawing.Color.FromArgb(CType(CType(245, Byte), Integer), CType(CType(237, Byte), Integer), CType(CType(227, Byte), Integer))
        Me.kryptonPaletteCustom.ToolMenuStatus.ToolStrip.ToolStripContentPanelGradientEnd = System.Drawing.Color.FromArgb(CType(CType(245, Byte), Integer), CType(CType(237, Byte), Integer), CType(CType(227, Byte), Integer))
        Me.kryptonPaletteCustom.ToolMenuStatus.ToolStrip.ToolStripDropDownBackground = System.Drawing.Color.FromArgb(CType(CType(102, Byte), Integer), CType(CType(153, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.kryptonPaletteCustom.ToolMenuStatus.ToolStrip.ToolStripGradientBegin = System.Drawing.Color.FromArgb(CType(CType(26, Byte), Integer), CType(CType(77, Byte), Integer), CType(CType(144, Byte), Integer))
        Me.kryptonPaletteCustom.ToolMenuStatus.ToolStrip.ToolStripGradientEnd = System.Drawing.Color.FromArgb(CType(CType(26, Byte), Integer), CType(CType(77, Byte), Integer), CType(CType(144, Byte), Integer))
        Me.kryptonPaletteCustom.ToolMenuStatus.ToolStrip.ToolStripGradientMiddle = System.Drawing.Color.FromArgb(CType(CType(26, Byte), Integer), CType(CType(77, Byte), Integer), CType(CType(144, Byte), Integer))
        Me.kryptonPaletteCustom.ToolMenuStatus.ToolStrip.ToolStripPanelGradientBegin = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(51, Byte), Integer), CType(CType(102, Byte), Integer))
        Me.kryptonPaletteCustom.ToolMenuStatus.ToolStrip.ToolStripPanelGradientEnd = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(51, Byte), Integer), CType(CType(102, Byte), Integer))
        Me.kryptonPaletteCustom.ToolMenuStatus.ToolStrip.ToolStripText = System.Drawing.Color.WhiteSmoke
        Me.kryptonPaletteCustom.ToolMenuStatus.UseRoundedEdges = Krypton.Toolkit.InheritBool.False
        Me.kryptonPaletteCustom.UseThemeFormChromeBorderWidth = Krypton.Toolkit.InheritBool.False
        Me.toolTip1.ToolTipTitle = "sadsf"
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8F, 17F)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(715, 457)
        Me.Controls.Add(Me.kryptonPanel1)
        Me.Font = New System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.Name = "Form1"
        Me.Text = "Test MessageBox Clipping - Normal Followed by Krypton"
        CType(Me.kryptonPanel1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.kryptonPanel1.ResumeLayout(False)
        CType(Me.kryptonGroup1.Panel, System.ComponentModel.ISupportInitialize).EndInit()
        Me.kryptonGroup1.Panel.ResumeLayout(False)
        Me.kryptonGroup1.Panel.PerformLayout()
        CType(Me.kryptonGroup1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.kryptonGroup1.ResumeLayout(False)
        Me.ResumeLayout(False)
    End Sub

    Friend WithEvents kryptonPanel1 As Krypton.Toolkit.KryptonPanel
    Friend WithEvents kryptonManager As Krypton.Toolkit.KryptonManager
    Friend WithEvents kryptonGroup1 As Krypton.Toolkit.KryptonGroup
    Friend WithEvents kryptonOffice2010Black As Krypton.Toolkit.KryptonRadioButton
    Friend WithEvents kryptonSparkleOrange As Krypton.Toolkit.KryptonRadioButton
    Friend WithEvents kryptonOffice2010Blue As Krypton.Toolkit.KryptonRadioButton
    Friend WithEvents kryptonOffice2010Silver As Krypton.Toolkit.KryptonRadioButton
    Friend WithEvents kryptonOffice2013White As Krypton.Toolkit.KryptonRadioButton
    Friend WithEvents kryptonSparklePurple As Krypton.Toolkit.KryptonRadioButton
    Friend WithEvents kryptonSparkleBlue As Krypton.Toolkit.KryptonRadioButton
    Friend WithEvents kryptonCustom As Krypton.Toolkit.KryptonRadioButton
    Friend WithEvents kryptonSystem As Krypton.Toolkit.KryptonRadioButton
    Friend WithEvents kryptonOffice2003 As Krypton.Toolkit.KryptonRadioButton
    Friend WithEvents kryptonOffice2007Black As Krypton.Toolkit.KryptonRadioButton
    Friend WithEvents kryptonOffice2007Silver As Krypton.Toolkit.KryptonRadioButton
    Friend WithEvents kryptonOffice2007Blue As Krypton.Toolkit.KryptonRadioButton
    Friend WithEvents kryptonPaletteCustom As Krypton.Toolkit.KryptonCustomPaletteBase
    Friend WithEvents btnSingleLines As Krypton.Toolkit.KryptonButton
    Friend WithEvents btnCarriageReturns As Krypton.Toolkit.KryptonButton
    Friend WithEvents btnStackTrace As Krypton.Toolkit.KryptonButton
    Friend WithEvents btnLongContents As Krypton.Toolkit.KryptonButton
    Friend WithEvents btnLongTitle As Krypton.Toolkit.KryptonButton
    Friend WithEvents btnLongTitleNoOwner As Krypton.Toolkit.KryptonButton
    Friend WithEvents btnLongContentsNoOwner As Krypton.Toolkit.KryptonButton
    Friend WithEvents toolTip1 As System.Windows.Forms.ToolTip
End Class
