' VB.NET twin of Source\Krypton Toolkit Examples\KryptonBorderEdge Examples\Form1.Designer.cs (Bastion Phase 4c).
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
        Me.borderAll = New Krypton.Toolkit.KryptonButton()
        Me.borderL = New Krypton.Toolkit.KryptonButton()
        Me.borderT = New Krypton.Toolkit.KryptonButton()
        Me.borderR = New Krypton.Toolkit.KryptonButton()
        Me.borderB = New Krypton.Toolkit.KryptonButton()
        Me.borderLT = New Krypton.Toolkit.KryptonButton()
        Me.borderTR = New Krypton.Toolkit.KryptonButton()
        Me.borderBR = New Krypton.Toolkit.KryptonButton()
        Me.borderBL = New Krypton.Toolkit.KryptonButton()
        Me.borderTB = New Krypton.Toolkit.KryptonButton()
        Me.borderLR = New Krypton.Toolkit.KryptonButton()
        Me.borderNone = New Krypton.Toolkit.KryptonButton()
        Me.borderTBR = New Krypton.Toolkit.KryptonButton()
        Me.borderLRB = New Krypton.Toolkit.KryptonButton()
        Me.borderTBL = New Krypton.Toolkit.KryptonButton()
        Me.borderLRT = New Krypton.Toolkit.KryptonButton()
        Me.borderEdgeH1 = New Krypton.Toolkit.KryptonBorderEdge()
        Me.borderEdgeV = New Krypton.Toolkit.KryptonBorderEdge()
        Me.panelButtonHost = New System.Windows.Forms.Panel()
        Me.buttonEnd = New Krypton.Toolkit.KryptonCheckButton()
        Me.borderEdgeSep3 = New Krypton.Toolkit.KryptonBorderEdge()
        Me.buttonNext = New Krypton.Toolkit.KryptonCheckButton()
        Me.borderEdgeSep2 = New Krypton.Toolkit.KryptonBorderEdge()
        Me.buttonPrevious = New Krypton.Toolkit.KryptonCheckButton()
        Me.borderEdgeSep1 = New Krypton.Toolkit.KryptonBorderEdge()
        Me.buttonBegin = New Krypton.Toolkit.KryptonCheckButton()
        Me.kryptonCheckSet = New Krypton.Toolkit.KryptonCheckSet(Me.components)
        Me.groupBoxBorderEdge = New System.Windows.Forms.GroupBox()
        Me.groupBoxButtonGroup = New System.Windows.Forms.GroupBox()
        Me.groupBoxKryptonBorderEdge = New System.Windows.Forms.GroupBox()
        Me.kryptonBorderEdge4 = New Krypton.Toolkit.KryptonBorderEdge()
        Me.kryptonBorderEdge3 = New Krypton.Toolkit.KryptonBorderEdge()
        Me.kryptonBorderEdge2 = New Krypton.Toolkit.KryptonBorderEdge()
        Me.kryptonBorderEdge1 = New Krypton.Toolkit.KryptonBorderEdge()
        Me.groupBox4 = New System.Windows.Forms.GroupBox()
        Me.propertyGrid = New System.Windows.Forms.PropertyGrid()
        Me.buttonClose = New System.Windows.Forms.Button()
        Me.groupBoxPalettes = New System.Windows.Forms.GroupBox()
        Me.buttonOffice2007Blue = New System.Windows.Forms.Button()
        Me.buttonOffice2010Blue = New System.Windows.Forms.Button()
        Me.buttonSystem = New System.Windows.Forms.Button()
        Me.buttonSparkle = New System.Windows.Forms.Button()
        Me.buttonCustom = New System.Windows.Forms.Button()
        Me.kryptonManager = New Krypton.Toolkit.KryptonManager(Me.components)
        Me.kryptonPaletteOffice2007Blue = New Krypton.Toolkit.KryptonCustomPaletteBase()
        Me.kryptonPaletteOffice2010Blue = New Krypton.Toolkit.KryptonCustomPaletteBase(Me.components)
        Me.kryptonPaletteOffice2007Blue = New Krypton.Toolkit.KryptonCustomPaletteBase(Me.components)
        Me.kryptonPaletteCustom = New Krypton.Toolkit.KryptonCustomPaletteBase(Me.components)
        Me.kryptonPaletteSparkle = New Krypton.Toolkit.KryptonCustomPaletteBase(Me.components)
        Me.kryptonPaletteSystem = New Krypton.Toolkit.KryptonCustomPaletteBase(Me.components)
        Me.panelButtonHost.SuspendLayout()
        CType(Me.kryptonCheckSet, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.groupBoxBorderEdge.SuspendLayout()
        Me.groupBoxButtonGroup.SuspendLayout()
        Me.groupBoxKryptonBorderEdge.SuspendLayout()
        Me.groupBox4.SuspendLayout()
        Me.groupBoxPalettes.SuspendLayout()
        Me.SuspendLayout()
        Me.borderAll.AutoSize = True
        Me.borderAll.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink
        Me.borderAll.DialogResult = System.Windows.Forms.DialogResult.None
        Me.borderAll.Location = New System.Drawing.Point(78, 28)
        Me.borderAll.Name = "borderAll"
        Me.borderAll.Orientation = Krypton.Toolkit.VisualOrientation.Top
        Me.borderAll.Size = New System.Drawing.Size(49, 26)
        Me.borderAll.StateCommon.Border.ColorAlign = Krypton.Toolkit.PaletteRectangleAlign.Inherit
        Me.borderAll.StateCommon.Border.ColorStyle = Krypton.Toolkit.PaletteColorStyle.Inherit
        Me.borderAll.StateCommon.Border.Draw = Krypton.Toolkit.InheritBool.Inherit
        Me.borderAll.StateCommon.Border.DrawBorders = CType((((Krypton.Toolkit.PaletteDrawBorders.Top Or Krypton.Toolkit.PaletteDrawBorders.Bottom) Or Krypton.Toolkit.PaletteDrawBorders.Left) Or Krypton.Toolkit.PaletteDrawBorders.Right), Krypton.Toolkit.PaletteDrawBorders)
        Me.borderAll.StateCommon.Border.GraphicsHint = Krypton.Toolkit.PaletteGraphicsHint.AntiAlias
        Me.borderAll.StateCommon.Border.ImageAlign = Krypton.Toolkit.PaletteRectangleAlign.Inherit
        Me.borderAll.StateCommon.Border.Rounding = 5F
        Me.borderAll.TabIndex = 3
        Me.borderL.AutoSize = True
        Me.borderL.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink
        Me.borderL.DialogResult = System.Windows.Forms.DialogResult.None
        Me.borderL.Location = New System.Drawing.Point(16, 68)
        Me.borderL.Name = "borderL"
        Me.borderL.Orientation = Krypton.Toolkit.VisualOrientation.Top
        Me.borderL.Size = New System.Drawing.Size(44, 20)
        Me.borderL.StateCommon.Border.ColorAlign = Krypton.Toolkit.PaletteRectangleAlign.Inherit
        Me.borderL.StateCommon.Border.ColorStyle = Krypton.Toolkit.PaletteColorStyle.Inherit
        Me.borderL.StateCommon.Border.Draw = Krypton.Toolkit.InheritBool.Inherit
        Me.borderL.StateCommon.Border.DrawBorders = Krypton.Toolkit.PaletteDrawBorders.Left
        Me.borderL.StateCommon.Border.GraphicsHint = Krypton.Toolkit.PaletteGraphicsHint.AntiAlias
        Me.borderL.StateCommon.Border.ImageAlign = Krypton.Toolkit.PaletteRectangleAlign.Inherit
        Me.borderL.StateCommon.Border.Rounding = 5F
        Me.borderL.TabIndex = 6
        Me.borderT.AutoSize = True
        Me.borderT.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink
        Me.borderT.DialogResult = System.Windows.Forms.DialogResult.None
        Me.borderT.Location = New System.Drawing.Point(81, 67)
        Me.borderT.Name = "borderT"
        Me.borderT.Orientation = Krypton.Toolkit.VisualOrientation.Top
        Me.borderT.Size = New System.Drawing.Size(43, 21)
        Me.borderT.StateCommon.Border.ColorAlign = Krypton.Toolkit.PaletteRectangleAlign.Inherit
        Me.borderT.StateCommon.Border.ColorStyle = Krypton.Toolkit.PaletteColorStyle.Inherit
        Me.borderT.StateCommon.Border.Draw = Krypton.Toolkit.InheritBool.Inherit
        Me.borderT.StateCommon.Border.DrawBorders = Krypton.Toolkit.PaletteDrawBorders.Top
        Me.borderT.StateCommon.Border.GraphicsHint = Krypton.Toolkit.PaletteGraphicsHint.AntiAlias
        Me.borderT.StateCommon.Border.ImageAlign = Krypton.Toolkit.PaletteRectangleAlign.Inherit
        Me.borderT.StateCommon.Border.Rounding = 5F
        Me.borderT.TabIndex = 7
        Me.borderR.AutoSize = True
        Me.borderR.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink
        Me.borderR.DialogResult = System.Windows.Forms.DialogResult.None
        Me.borderR.Location = New System.Drawing.Point(141, 68)
        Me.borderR.Name = "borderR"
        Me.borderR.Orientation = Krypton.Toolkit.VisualOrientation.Top
        Me.borderR.Size = New System.Drawing.Size(44, 20)
        Me.borderR.StateCommon.Border.ColorAlign = Krypton.Toolkit.PaletteRectangleAlign.Inherit
        Me.borderR.StateCommon.Border.ColorStyle = Krypton.Toolkit.PaletteColorStyle.Inherit
        Me.borderR.StateCommon.Border.Draw = Krypton.Toolkit.InheritBool.Inherit
        Me.borderR.StateCommon.Border.DrawBorders = Krypton.Toolkit.PaletteDrawBorders.Right
        Me.borderR.StateCommon.Border.GraphicsHint = Krypton.Toolkit.PaletteGraphicsHint.AntiAlias
        Me.borderR.StateCommon.Border.ImageAlign = Krypton.Toolkit.PaletteRectangleAlign.Inherit
        Me.borderR.StateCommon.Border.Rounding = 5F
        Me.borderR.TabIndex = 8
        Me.borderB.AutoSize = True
        Me.borderB.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink
        Me.borderB.DialogResult = System.Windows.Forms.DialogResult.None
        Me.borderB.Location = New System.Drawing.Point(204, 67)
        Me.borderB.Name = "borderB"
        Me.borderB.Orientation = Krypton.Toolkit.VisualOrientation.Top
        Me.borderB.Size = New System.Drawing.Size(43, 21)
        Me.borderB.StateCommon.Border.ColorAlign = Krypton.Toolkit.PaletteRectangleAlign.Inherit
        Me.borderB.StateCommon.Border.ColorStyle = Krypton.Toolkit.PaletteColorStyle.Inherit
        Me.borderB.StateCommon.Border.Draw = Krypton.Toolkit.InheritBool.Inherit
        Me.borderB.StateCommon.Border.DrawBorders = Krypton.Toolkit.PaletteDrawBorders.Bottom
        Me.borderB.StateCommon.Border.GraphicsHint = Krypton.Toolkit.PaletteGraphicsHint.AntiAlias
        Me.borderB.StateCommon.Border.ImageAlign = Krypton.Toolkit.PaletteRectangleAlign.Inherit
        Me.borderB.StateCommon.Border.Rounding = 5F
        Me.borderB.TabIndex = 9
        Me.borderLT.AutoSize = True
        Me.borderLT.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink
        Me.borderLT.DialogResult = System.Windows.Forms.DialogResult.None
        Me.borderLT.Location = New System.Drawing.Point(15, 104)
        Me.borderLT.Name = "borderLT"
        Me.borderLT.Orientation = Krypton.Toolkit.VisualOrientation.Top
        Me.borderLT.Size = New System.Drawing.Size(46, 23)
        Me.borderLT.StateCommon.Border.ColorAlign = Krypton.Toolkit.PaletteRectangleAlign.Inherit
        Me.borderLT.StateCommon.Border.ColorStyle = Krypton.Toolkit.PaletteColorStyle.Inherit
        Me.borderLT.StateCommon.Border.Draw = Krypton.Toolkit.InheritBool.Inherit
        Me.borderLT.StateCommon.Border.DrawBorders = CType((Krypton.Toolkit.PaletteDrawBorders.Top Or Krypton.Toolkit.PaletteDrawBorders.Left), Krypton.Toolkit.PaletteDrawBorders)
        Me.borderLT.StateCommon.Border.GraphicsHint = Krypton.Toolkit.PaletteGraphicsHint.AntiAlias
        Me.borderLT.StateCommon.Border.ImageAlign = Krypton.Toolkit.PaletteRectangleAlign.Inherit
        Me.borderLT.StateCommon.Border.Rounding = 5F
        Me.borderLT.TabIndex = 10
        Me.borderTR.AutoSize = True
        Me.borderTR.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink
        Me.borderTR.DialogResult = System.Windows.Forms.DialogResult.None
        Me.borderTR.Location = New System.Drawing.Point(79, 104)
        Me.borderTR.Name = "borderTR"
        Me.borderTR.Orientation = Krypton.Toolkit.VisualOrientation.Top
        Me.borderTR.Size = New System.Drawing.Size(46, 23)
        Me.borderTR.StateCommon.Border.ColorAlign = Krypton.Toolkit.PaletteRectangleAlign.Inherit
        Me.borderTR.StateCommon.Border.ColorStyle = Krypton.Toolkit.PaletteColorStyle.Inherit
        Me.borderTR.StateCommon.Border.Draw = Krypton.Toolkit.InheritBool.Inherit
        Me.borderTR.StateCommon.Border.DrawBorders = CType((Krypton.Toolkit.PaletteDrawBorders.Top Or Krypton.Toolkit.PaletteDrawBorders.Right), Krypton.Toolkit.PaletteDrawBorders)
        Me.borderTR.StateCommon.Border.GraphicsHint = Krypton.Toolkit.PaletteGraphicsHint.AntiAlias
        Me.borderTR.StateCommon.Border.ImageAlign = Krypton.Toolkit.PaletteRectangleAlign.Inherit
        Me.borderTR.StateCommon.Border.Rounding = 5F
        Me.borderTR.TabIndex = 11
        Me.borderBR.AutoSize = True
        Me.borderBR.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink
        Me.borderBR.DialogResult = System.Windows.Forms.DialogResult.None
        Me.borderBR.Location = New System.Drawing.Point(140, 104)
        Me.borderBR.Name = "borderBR"
        Me.borderBR.Orientation = Krypton.Toolkit.VisualOrientation.Top
        Me.borderBR.Size = New System.Drawing.Size(46, 23)
        Me.borderBR.StateCommon.Border.ColorAlign = Krypton.Toolkit.PaletteRectangleAlign.Inherit
        Me.borderBR.StateCommon.Border.ColorStyle = Krypton.Toolkit.PaletteColorStyle.Inherit
        Me.borderBR.StateCommon.Border.Draw = Krypton.Toolkit.InheritBool.Inherit
        Me.borderBR.StateCommon.Border.DrawBorders = CType((Krypton.Toolkit.PaletteDrawBorders.Bottom Or Krypton.Toolkit.PaletteDrawBorders.Right), Krypton.Toolkit.PaletteDrawBorders)
        Me.borderBR.StateCommon.Border.GraphicsHint = Krypton.Toolkit.PaletteGraphicsHint.AntiAlias
        Me.borderBR.StateCommon.Border.ImageAlign = Krypton.Toolkit.PaletteRectangleAlign.Inherit
        Me.borderBR.StateCommon.Border.Rounding = 5F
        Me.borderBR.TabIndex = 12
        Me.borderBL.AutoSize = True
        Me.borderBL.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink
        Me.borderBL.DialogResult = System.Windows.Forms.DialogResult.None
        Me.borderBL.Location = New System.Drawing.Point(202, 104)
        Me.borderBL.Name = "borderBL"
        Me.borderBL.Orientation = Krypton.Toolkit.VisualOrientation.Top
        Me.borderBL.Size = New System.Drawing.Size(46, 23)
        Me.borderBL.StateCommon.Border.ColorAlign = Krypton.Toolkit.PaletteRectangleAlign.Inherit
        Me.borderBL.StateCommon.Border.ColorStyle = Krypton.Toolkit.PaletteColorStyle.Inherit
        Me.borderBL.StateCommon.Border.Draw = Krypton.Toolkit.InheritBool.Inherit
        Me.borderBL.StateCommon.Border.DrawBorders = CType((Krypton.Toolkit.PaletteDrawBorders.Bottom Or Krypton.Toolkit.PaletteDrawBorders.Left), Krypton.Toolkit.PaletteDrawBorders)
        Me.borderBL.StateCommon.Border.GraphicsHint = Krypton.Toolkit.PaletteGraphicsHint.AntiAlias
        Me.borderBL.StateCommon.Border.ImageAlign = Krypton.Toolkit.PaletteRectangleAlign.Inherit
        Me.borderBL.StateCommon.Border.Rounding = 5F
        Me.borderBL.TabIndex = 13
        Me.borderTB.AutoSize = True
        Me.borderTB.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink
        Me.borderTB.DialogResult = System.Windows.Forms.DialogResult.None
        Me.borderTB.Location = New System.Drawing.Point(142, 30)
        Me.borderTB.Name = "borderTB"
        Me.borderTB.Orientation = Krypton.Toolkit.VisualOrientation.Top
        Me.borderTB.Size = New System.Drawing.Size(43, 22)
        Me.borderTB.StateCommon.Border.ColorAlign = Krypton.Toolkit.PaletteRectangleAlign.Inherit
        Me.borderTB.StateCommon.Border.ColorStyle = Krypton.Toolkit.PaletteColorStyle.Inherit
        Me.borderTB.StateCommon.Border.Draw = Krypton.Toolkit.InheritBool.Inherit
        Me.borderTB.StateCommon.Border.DrawBorders = CType((Krypton.Toolkit.PaletteDrawBorders.Top Or Krypton.Toolkit.PaletteDrawBorders.Bottom), Krypton.Toolkit.PaletteDrawBorders)
        Me.borderTB.StateCommon.Border.GraphicsHint = Krypton.Toolkit.PaletteGraphicsHint.AntiAlias
        Me.borderTB.StateCommon.Border.ImageAlign = Krypton.Toolkit.PaletteRectangleAlign.Inherit
        Me.borderTB.StateCommon.Border.Rounding = 5F
        Me.borderTB.TabIndex = 4
        Me.borderLR.AutoSize = True
        Me.borderLR.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink
        Me.borderLR.DialogResult = System.Windows.Forms.DialogResult.None
        Me.borderLR.Location = New System.Drawing.Point(203, 31)
        Me.borderLR.Name = "borderLR"
        Me.borderLR.Orientation = Krypton.Toolkit.VisualOrientation.Top
        Me.borderLR.Size = New System.Drawing.Size(45, 20)
        Me.borderLR.StateCommon.Border.ColorAlign = Krypton.Toolkit.PaletteRectangleAlign.Inherit
        Me.borderLR.StateCommon.Border.ColorStyle = Krypton.Toolkit.PaletteColorStyle.Inherit
        Me.borderLR.StateCommon.Border.Draw = Krypton.Toolkit.InheritBool.Inherit
        Me.borderLR.StateCommon.Border.DrawBorders = CType((Krypton.Toolkit.PaletteDrawBorders.Left Or Krypton.Toolkit.PaletteDrawBorders.Right), Krypton.Toolkit.PaletteDrawBorders)
        Me.borderLR.StateCommon.Border.GraphicsHint = Krypton.Toolkit.PaletteGraphicsHint.AntiAlias
        Me.borderLR.StateCommon.Border.ImageAlign = Krypton.Toolkit.PaletteRectangleAlign.Inherit
        Me.borderLR.StateCommon.Border.Rounding = 5F
        Me.borderLR.TabIndex = 5
        Me.borderNone.AutoSize = True
        Me.borderNone.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink
        Me.borderNone.DialogResult = System.Windows.Forms.DialogResult.None
        Me.borderNone.Location = New System.Drawing.Point(17, 31)
        Me.borderNone.Name = "borderNone"
        Me.borderNone.Orientation = Krypton.Toolkit.VisualOrientation.Top
        Me.borderNone.Size = New System.Drawing.Size(43, 20)
        Me.borderNone.StateCommon.Border.ColorAlign = Krypton.Toolkit.PaletteRectangleAlign.Inherit
        Me.borderNone.StateCommon.Border.ColorStyle = Krypton.Toolkit.PaletteColorStyle.Inherit
        Me.borderNone.StateCommon.Border.Draw = Krypton.Toolkit.InheritBool.Inherit
        Me.borderNone.StateCommon.Border.DrawBorders = Krypton.Toolkit.PaletteDrawBorders.None
        Me.borderNone.StateCommon.Border.GraphicsHint = Krypton.Toolkit.PaletteGraphicsHint.AntiAlias
        Me.borderNone.StateCommon.Border.ImageAlign = Krypton.Toolkit.PaletteRectangleAlign.Inherit
        Me.borderNone.StateCommon.Border.Rounding = 5F
        Me.borderNone.TabIndex = 2
        Me.borderTBR.AutoSize = True
        Me.borderTBR.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink
        Me.borderTBR.DialogResult = System.Windows.Forms.DialogResult.None
        Me.borderTBR.Location = New System.Drawing.Point(15, 140)
        Me.borderTBR.Name = "borderTBR"
        Me.borderTBR.Orientation = Krypton.Toolkit.VisualOrientation.Top
        Me.borderTBR.Size = New System.Drawing.Size(46, 26)
        Me.borderTBR.StateCommon.Border.ColorAlign = Krypton.Toolkit.PaletteRectangleAlign.Inherit
        Me.borderTBR.StateCommon.Border.ColorStyle = Krypton.Toolkit.PaletteColorStyle.Inherit
        Me.borderTBR.StateCommon.Border.Draw = Krypton.Toolkit.InheritBool.Inherit
        Me.borderTBR.StateCommon.Border.DrawBorders = CType(((Krypton.Toolkit.PaletteDrawBorders.Top Or Krypton.Toolkit.PaletteDrawBorders.Bottom) Or Krypton.Toolkit.PaletteDrawBorders.Right), Krypton.Toolkit.PaletteDrawBorders)
        Me.borderTBR.StateCommon.Border.GraphicsHint = Krypton.Toolkit.PaletteGraphicsHint.AntiAlias
        Me.borderTBR.StateCommon.Border.ImageAlign = Krypton.Toolkit.PaletteRectangleAlign.Inherit
        Me.borderTBR.StateCommon.Border.Rounding = 5F
        Me.borderTBR.TabIndex = 14
        Me.borderLRB.AutoSize = True
        Me.borderLRB.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink
        Me.borderLRB.DialogResult = System.Windows.Forms.DialogResult.None
        Me.borderLRB.Location = New System.Drawing.Point(78, 141)
        Me.borderLRB.Name = "borderLRB"
        Me.borderLRB.Orientation = Krypton.Toolkit.VisualOrientation.Top
        Me.borderLRB.Size = New System.Drawing.Size(49, 23)
        Me.borderLRB.StateCommon.Border.ColorAlign = Krypton.Toolkit.PaletteRectangleAlign.Inherit
        Me.borderLRB.StateCommon.Border.ColorStyle = Krypton.Toolkit.PaletteColorStyle.Inherit
        Me.borderLRB.StateCommon.Border.Draw = Krypton.Toolkit.InheritBool.Inherit
        Me.borderLRB.StateCommon.Border.DrawBorders = CType(((Krypton.Toolkit.PaletteDrawBorders.Bottom Or Krypton.Toolkit.PaletteDrawBorders.Left) Or Krypton.Toolkit.PaletteDrawBorders.Right), Krypton.Toolkit.PaletteDrawBorders)
        Me.borderLRB.StateCommon.Border.GraphicsHint = Krypton.Toolkit.PaletteGraphicsHint.AntiAlias
        Me.borderLRB.StateCommon.Border.ImageAlign = Krypton.Toolkit.PaletteRectangleAlign.Inherit
        Me.borderLRB.StateCommon.Border.Rounding = 5F
        Me.borderLRB.TabIndex = 15
        Me.borderTBL.AutoSize = True
        Me.borderTBL.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink
        Me.borderTBL.DialogResult = System.Windows.Forms.DialogResult.None
        Me.borderTBL.Location = New System.Drawing.Point(140, 140)
        Me.borderTBL.Name = "borderTBL"
        Me.borderTBL.Orientation = Krypton.Toolkit.VisualOrientation.Top
        Me.borderTBL.Size = New System.Drawing.Size(46, 26)
        Me.borderTBL.StateCommon.Border.ColorAlign = Krypton.Toolkit.PaletteRectangleAlign.Inherit
        Me.borderTBL.StateCommon.Border.ColorStyle = Krypton.Toolkit.PaletteColorStyle.Inherit
        Me.borderTBL.StateCommon.Border.Draw = Krypton.Toolkit.InheritBool.Inherit
        Me.borderTBL.StateCommon.Border.DrawBorders = CType(((Krypton.Toolkit.PaletteDrawBorders.Top Or Krypton.Toolkit.PaletteDrawBorders.Bottom) Or Krypton.Toolkit.PaletteDrawBorders.Left), Krypton.Toolkit.PaletteDrawBorders)
        Me.borderTBL.StateCommon.Border.GraphicsHint = Krypton.Toolkit.PaletteGraphicsHint.AntiAlias
        Me.borderTBL.StateCommon.Border.ImageAlign = Krypton.Toolkit.PaletteRectangleAlign.Inherit
        Me.borderTBL.StateCommon.Border.Rounding = 5F
        Me.borderTBL.TabIndex = 16
        Me.borderLRT.AutoSize = True
        Me.borderLRT.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink
        Me.borderLRT.DialogResult = System.Windows.Forms.DialogResult.None
        Me.borderLRT.Location = New System.Drawing.Point(201, 141)
        Me.borderLRT.Name = "borderLRT"
        Me.borderLRT.Orientation = Krypton.Toolkit.VisualOrientation.Top
        Me.borderLRT.Size = New System.Drawing.Size(49, 23)
        Me.borderLRT.StateCommon.Border.ColorAlign = Krypton.Toolkit.PaletteRectangleAlign.Inherit
        Me.borderLRT.StateCommon.Border.ColorStyle = Krypton.Toolkit.PaletteColorStyle.Inherit
        Me.borderLRT.StateCommon.Border.Draw = Krypton.Toolkit.InheritBool.Inherit
        Me.borderLRT.StateCommon.Border.DrawBorders = CType(((Krypton.Toolkit.PaletteDrawBorders.Top Or Krypton.Toolkit.PaletteDrawBorders.Left) Or Krypton.Toolkit.PaletteDrawBorders.Right), Krypton.Toolkit.PaletteDrawBorders)
        Me.borderLRT.StateCommon.Border.GraphicsHint = Krypton.Toolkit.PaletteGraphicsHint.AntiAlias
        Me.borderLRT.StateCommon.Border.ImageAlign = Krypton.Toolkit.PaletteRectangleAlign.Inherit
        Me.borderLRT.StateCommon.Border.Rounding = 5F
        Me.borderLRT.TabIndex = 17
        Me.borderEdgeH1.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink
        Me.borderEdgeH1.BorderStyle = Krypton.Toolkit.PaletteBorderStyle.ButtonStandalone
        Me.borderEdgeH1.Location = New System.Drawing.Point(21, 29)
        Me.borderEdgeH1.Name = "borderEdgeH1"
        Me.borderEdgeH1.Orientation = System.Windows.Forms.Orientation.Horizontal
        Me.borderEdgeH1.Size = New System.Drawing.Size(75, 1)
        Me.borderEdgeH1.Text = "kryptonBorderEdge1"
        Me.borderEdgeV.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink
        Me.borderEdgeV.BorderStyle = Krypton.Toolkit.PaletteBorderStyle.ButtonStandalone
        Me.borderEdgeV.Location = New System.Drawing.Point(21, 49)
        Me.borderEdgeV.Name = "borderEdgeV"
        Me.borderEdgeV.Orientation = System.Windows.Forms.Orientation.Vertical
        Me.borderEdgeV.Size = New System.Drawing.Size(1, 50)
        Me.borderEdgeV.Text = "kryptonBorderEdge2"
        Me.panelButtonHost.AutoSize = True
        Me.panelButtonHost.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink
        Me.panelButtonHost.Controls.Add(Me.buttonEnd)
        Me.panelButtonHost.Controls.Add(Me.borderEdgeSep3)
        Me.panelButtonHost.Controls.Add(Me.buttonNext)
        Me.panelButtonHost.Controls.Add(Me.borderEdgeSep2)
        Me.panelButtonHost.Controls.Add(Me.buttonPrevious)
        Me.panelButtonHost.Controls.Add(Me.borderEdgeSep1)
        Me.panelButtonHost.Controls.Add(Me.buttonBegin)
        Me.panelButtonHost.Location = New System.Drawing.Point(18, 28)
        Me.panelButtonHost.Name = "panelButtonHost"
        Me.panelButtonHost.Size = New System.Drawing.Size(147, 42)
        Me.panelButtonHost.TabIndex = 18
        Me.buttonEnd.AutoSize = True
        Me.buttonEnd.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink
        Me.buttonEnd.DialogResult = System.Windows.Forms.DialogResult.None
        Me.buttonEnd.Dock = System.Windows.Forms.DockStyle.Fill
        Me.buttonEnd.Location = New System.Drawing.Point(109, 0)
        Me.buttonEnd.Name = "buttonEnd"
        Me.buttonEnd.Orientation = Krypton.Toolkit.VisualOrientation.Top
        Me.buttonEnd.Size = New System.Drawing.Size(38, 42)
        Me.buttonEnd.StateCommon.Border.ColorAlign = Krypton.Toolkit.PaletteRectangleAlign.Inherit
        Me.buttonEnd.StateCommon.Border.ColorStyle = Krypton.Toolkit.PaletteColorStyle.Inherit
        Me.buttonEnd.StateCommon.Border.Draw = Krypton.Toolkit.InheritBool.Inherit
        Me.buttonEnd.StateCommon.Border.DrawBorders = CType(((Krypton.Toolkit.PaletteDrawBorders.Top Or Krypton.Toolkit.PaletteDrawBorders.Bottom) Or Krypton.Toolkit.PaletteDrawBorders.Right), Krypton.Toolkit.PaletteDrawBorders)
        Me.buttonEnd.StateCommon.Border.GraphicsHint = Krypton.Toolkit.PaletteGraphicsHint.AntiAlias
        Me.buttonEnd.StateCommon.Border.ImageAlign = Krypton.Toolkit.PaletteRectangleAlign.Inherit
        Me.buttonEnd.StateCommon.Border.Rounding = 8F
        Me.buttonEnd.TabIndex = 3
        Me.buttonEnd.Values.Image = CType(resources.GetObject("buttonEnd.Values.Image"), System.Drawing.Image)
        Me.buttonEnd.Values.Text = ""
        Me.borderEdgeSep3.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink
        Me.borderEdgeSep3.BorderStyle = Krypton.Toolkit.PaletteBorderStyle.ButtonStandalone
        Me.borderEdgeSep3.Dock = System.Windows.Forms.DockStyle.Left
        Me.borderEdgeSep3.Location = New System.Drawing.Point(108, 0)
        Me.borderEdgeSep3.Name = "borderEdgeSep3"
        Me.borderEdgeSep3.Orientation = System.Windows.Forms.Orientation.Vertical
        Me.borderEdgeSep3.Size = New System.Drawing.Size(1, 42)
        Me.borderEdgeSep3.StateCommon.ColorAlign = Krypton.Toolkit.PaletteRectangleAlign.Inherit
        Me.borderEdgeSep3.StateCommon.ColorStyle = Krypton.Toolkit.PaletteColorStyle.Inherit
        Me.borderEdgeSep3.StateCommon.Draw = Krypton.Toolkit.InheritBool.Inherit
        Me.borderEdgeSep3.StateCommon.GraphicsHint = Krypton.Toolkit.PaletteGraphicsHint.None
        Me.borderEdgeSep3.StateCommon.ImageAlign = Krypton.Toolkit.PaletteRectangleAlign.Inherit
        Me.borderEdgeSep3.StateCommon.ImageStyle = Krypton.Toolkit.PaletteImageStyle.Inherit
        Me.borderEdgeSep3.Text = "kryptonBorderEdge2"
        Me.buttonNext.AutoSize = True
        Me.buttonNext.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink
        Me.buttonNext.DialogResult = System.Windows.Forms.DialogResult.None
        Me.buttonNext.Dock = System.Windows.Forms.DockStyle.Left
        Me.buttonNext.Location = New System.Drawing.Point(74, 0)
        Me.buttonNext.Name = "buttonNext"
        Me.buttonNext.Orientation = Krypton.Toolkit.VisualOrientation.Top
        Me.buttonNext.Size = New System.Drawing.Size(34, 42)
        Me.buttonNext.StateCommon.Border.ColorAlign = Krypton.Toolkit.PaletteRectangleAlign.Inherit
        Me.buttonNext.StateCommon.Border.ColorStyle = Krypton.Toolkit.PaletteColorStyle.Inherit
        Me.buttonNext.StateCommon.Border.Draw = Krypton.Toolkit.InheritBool.Inherit
        Me.buttonNext.StateCommon.Border.DrawBorders = CType((Krypton.Toolkit.PaletteDrawBorders.Top Or Krypton.Toolkit.PaletteDrawBorders.Bottom), Krypton.Toolkit.PaletteDrawBorders)
        Me.buttonNext.StateCommon.Border.GraphicsHint = Krypton.Toolkit.PaletteGraphicsHint.AntiAlias
        Me.buttonNext.StateCommon.Border.ImageAlign = Krypton.Toolkit.PaletteRectangleAlign.Inherit
        Me.buttonNext.StateCommon.Border.Rounding = 8F
        Me.buttonNext.TabIndex = 2
        Me.buttonNext.Values.Image = CType(resources.GetObject("buttonNext.Values.Image"), System.Drawing.Image)
        Me.buttonNext.Values.Text = ""
        Me.borderEdgeSep2.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink
        Me.borderEdgeSep2.BorderStyle = Krypton.Toolkit.PaletteBorderStyle.ButtonStandalone
        Me.borderEdgeSep2.Dock = System.Windows.Forms.DockStyle.Left
        Me.borderEdgeSep2.Location = New System.Drawing.Point(73, 0)
        Me.borderEdgeSep2.Name = "borderEdgeSep2"
        Me.borderEdgeSep2.Orientation = System.Windows.Forms.Orientation.Vertical
        Me.borderEdgeSep2.Size = New System.Drawing.Size(1, 42)
        Me.borderEdgeSep2.StateCommon.ColorAlign = Krypton.Toolkit.PaletteRectangleAlign.Inherit
        Me.borderEdgeSep2.StateCommon.ColorStyle = Krypton.Toolkit.PaletteColorStyle.Inherit
        Me.borderEdgeSep2.StateCommon.Draw = Krypton.Toolkit.InheritBool.Inherit
        Me.borderEdgeSep2.StateCommon.GraphicsHint = Krypton.Toolkit.PaletteGraphicsHint.None
        Me.borderEdgeSep2.StateCommon.ImageAlign = Krypton.Toolkit.PaletteRectangleAlign.Inherit
        Me.borderEdgeSep2.StateCommon.ImageStyle = Krypton.Toolkit.PaletteImageStyle.Inherit
        Me.borderEdgeSep2.Text = "kryptonBorderEdge1"
        Me.buttonPrevious.AutoSize = True
        Me.buttonPrevious.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink
        Me.buttonPrevious.DialogResult = System.Windows.Forms.DialogResult.None
        Me.buttonPrevious.Dock = System.Windows.Forms.DockStyle.Left
        Me.buttonPrevious.Location = New System.Drawing.Point(39, 0)
        Me.buttonPrevious.Name = "buttonPrevious"
        Me.buttonPrevious.Orientation = Krypton.Toolkit.VisualOrientation.Top
        Me.buttonPrevious.Size = New System.Drawing.Size(34, 42)
        Me.buttonPrevious.StateCommon.Border.ColorAlign = Krypton.Toolkit.PaletteRectangleAlign.Inherit
        Me.buttonPrevious.StateCommon.Border.ColorStyle = Krypton.Toolkit.PaletteColorStyle.Inherit
        Me.buttonPrevious.StateCommon.Border.Draw = Krypton.Toolkit.InheritBool.Inherit
        Me.buttonPrevious.StateCommon.Border.DrawBorders = CType((Krypton.Toolkit.PaletteDrawBorders.Top Or Krypton.Toolkit.PaletteDrawBorders.Bottom), Krypton.Toolkit.PaletteDrawBorders)
        Me.buttonPrevious.StateCommon.Border.GraphicsHint = Krypton.Toolkit.PaletteGraphicsHint.AntiAlias
        Me.buttonPrevious.StateCommon.Border.ImageAlign = Krypton.Toolkit.PaletteRectangleAlign.Inherit
        Me.buttonPrevious.StateCommon.Border.Rounding = 8F
        Me.buttonPrevious.TabIndex = 1
        Me.buttonPrevious.Values.Image = CType(resources.GetObject("buttonPrevious.Values.Image"), System.Drawing.Image)
        Me.buttonPrevious.Values.Text = ""
        Me.borderEdgeSep1.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink
        Me.borderEdgeSep1.BorderStyle = Krypton.Toolkit.PaletteBorderStyle.ButtonStandalone
        Me.borderEdgeSep1.Dock = System.Windows.Forms.DockStyle.Left
        Me.borderEdgeSep1.Location = New System.Drawing.Point(38, 0)
        Me.borderEdgeSep1.Name = "borderEdgeSep1"
        Me.borderEdgeSep1.Orientation = System.Windows.Forms.Orientation.Vertical
        Me.borderEdgeSep1.Size = New System.Drawing.Size(1, 42)
        Me.borderEdgeSep1.StateCommon.ColorAlign = Krypton.Toolkit.PaletteRectangleAlign.Inherit
        Me.borderEdgeSep1.StateCommon.ColorStyle = Krypton.Toolkit.PaletteColorStyle.Inherit
        Me.borderEdgeSep1.StateCommon.Draw = Krypton.Toolkit.InheritBool.Inherit
        Me.borderEdgeSep1.StateCommon.GraphicsHint = Krypton.Toolkit.PaletteGraphicsHint.None
        Me.borderEdgeSep1.StateCommon.ImageAlign = Krypton.Toolkit.PaletteRectangleAlign.Inherit
        Me.borderEdgeSep1.StateCommon.ImageStyle = Krypton.Toolkit.PaletteImageStyle.Inherit
        Me.borderEdgeSep1.Text = "kryptonBorderEdge3"
        Me.buttonBegin.AutoSize = True
        Me.buttonBegin.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink
        Me.buttonBegin.Checked = True
        Me.buttonBegin.DialogResult = System.Windows.Forms.DialogResult.None
        Me.buttonBegin.Dock = System.Windows.Forms.DockStyle.Left
        Me.buttonBegin.Location = New System.Drawing.Point(0, 0)
        Me.buttonBegin.Name = "buttonBegin"
        Me.buttonBegin.Orientation = Krypton.Toolkit.VisualOrientation.Top
        Me.buttonBegin.Size = New System.Drawing.Size(38, 42)
        Me.buttonBegin.StateCommon.Border.ColorAlign = Krypton.Toolkit.PaletteRectangleAlign.Inherit
        Me.buttonBegin.StateCommon.Border.ColorStyle = Krypton.Toolkit.PaletteColorStyle.Inherit
        Me.buttonBegin.StateCommon.Border.Draw = Krypton.Toolkit.InheritBool.Inherit
        Me.buttonBegin.StateCommon.Border.DrawBorders = CType(((Krypton.Toolkit.PaletteDrawBorders.Top Or Krypton.Toolkit.PaletteDrawBorders.Bottom) Or Krypton.Toolkit.PaletteDrawBorders.Left), Krypton.Toolkit.PaletteDrawBorders)
        Me.buttonBegin.StateCommon.Border.GraphicsHint = Krypton.Toolkit.PaletteGraphicsHint.AntiAlias
        Me.buttonBegin.StateCommon.Border.ImageAlign = Krypton.Toolkit.PaletteRectangleAlign.Inherit
        Me.buttonBegin.StateCommon.Border.Rounding = 8F
        Me.buttonBegin.TabIndex = 0
        Me.buttonBegin.Values.Image = CType(resources.GetObject("buttonBegin.Values.Image"), System.Drawing.Image)
        Me.buttonBegin.Values.Text = ""
        Me.kryptonCheckSet.CheckButtons.Add(Me.buttonEnd)
        Me.kryptonCheckSet.CheckButtons.Add(Me.buttonNext)
        Me.kryptonCheckSet.CheckButtons.Add(Me.buttonPrevious)
        Me.kryptonCheckSet.CheckButtons.Add(Me.buttonBegin)
        Me.kryptonCheckSet.CheckedButton = Me.buttonBegin
        Me.groupBoxBorderEdge.Controls.Add(Me.borderNone)
        Me.groupBoxBorderEdge.Controls.Add(Me.borderAll)
        Me.groupBoxBorderEdge.Controls.Add(Me.borderL)
        Me.groupBoxBorderEdge.Controls.Add(Me.borderT)
        Me.groupBoxBorderEdge.Controls.Add(Me.borderLRT)
        Me.groupBoxBorderEdge.Controls.Add(Me.borderR)
        Me.groupBoxBorderEdge.Controls.Add(Me.borderTBL)
        Me.groupBoxBorderEdge.Controls.Add(Me.borderB)
        Me.groupBoxBorderEdge.Controls.Add(Me.borderLRB)
        Me.groupBoxBorderEdge.Controls.Add(Me.borderLT)
        Me.groupBoxBorderEdge.Controls.Add(Me.borderTBR)
        Me.groupBoxBorderEdge.Controls.Add(Me.borderTR)
        Me.groupBoxBorderEdge.Controls.Add(Me.borderBR)
        Me.groupBoxBorderEdge.Controls.Add(Me.borderLR)
        Me.groupBoxBorderEdge.Controls.Add(Me.borderBL)
        Me.groupBoxBorderEdge.Controls.Add(Me.borderTB)
        Me.groupBoxBorderEdge.Location = New System.Drawing.Point(12, 133)
        Me.groupBoxBorderEdge.Name = "groupBoxBorderEdge"
        Me.groupBoxBorderEdge.Size = New System.Drawing.Size(355, 183)
        Me.groupBoxBorderEdge.TabIndex = 1
        Me.groupBoxBorderEdge.TabStop = False
        Me.groupBoxBorderEdge.Text = "KryptonButton with StateCommon -> Border -> DrawBorders applied"
        Me.groupBoxButtonGroup.Controls.Add(Me.panelButtonHost)
        Me.groupBoxButtonGroup.Location = New System.Drawing.Point(12, 322)
        Me.groupBoxButtonGroup.Name = "groupBoxButtonGroup"
        Me.groupBoxButtonGroup.Size = New System.Drawing.Size(355, 85)
        Me.groupBoxButtonGroup.TabIndex = 2
        Me.groupBoxButtonGroup.TabStop = False
        Me.groupBoxButtonGroup.Text = "Combine KryptonCheckButton + KryptonBorderEdge to create group"
        Me.groupBoxKryptonBorderEdge.Controls.Add(Me.kryptonBorderEdge4)
        Me.groupBoxKryptonBorderEdge.Controls.Add(Me.kryptonBorderEdge3)
        Me.groupBoxKryptonBorderEdge.Controls.Add(Me.kryptonBorderEdge2)
        Me.groupBoxKryptonBorderEdge.Controls.Add(Me.kryptonBorderEdge1)
        Me.groupBoxKryptonBorderEdge.Controls.Add(Me.borderEdgeH1)
        Me.groupBoxKryptonBorderEdge.Controls.Add(Me.borderEdgeV)
        Me.groupBoxKryptonBorderEdge.Location = New System.Drawing.Point(12, 12)
        Me.groupBoxKryptonBorderEdge.Name = "groupBoxKryptonBorderEdge"
        Me.groupBoxKryptonBorderEdge.Size = New System.Drawing.Size(355, 115)
        Me.groupBoxKryptonBorderEdge.TabIndex = 0
        Me.groupBoxKryptonBorderEdge.TabStop = False
        Me.groupBoxKryptonBorderEdge.Text = "KryptonBorderEdge Instances"
        Me.kryptonBorderEdge4.AutoSize = False
        Me.kryptonBorderEdge4.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink
        Me.kryptonBorderEdge4.BorderStyle = Krypton.Toolkit.PaletteBorderStyle.ButtonStandalone
        Me.kryptonBorderEdge4.Location = New System.Drawing.Point(199, 49)
        Me.kryptonBorderEdge4.Name = "kryptonBorderEdge4"
        Me.kryptonBorderEdge4.Orientation = System.Windows.Forms.Orientation.Vertical
        Me.kryptonBorderEdge4.Size = New System.Drawing.Size(10, 50)
        Me.kryptonBorderEdge4.Text = "kryptonBorderEdge2"
        Me.kryptonBorderEdge3.AutoSize = False
        Me.kryptonBorderEdge3.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink
        Me.kryptonBorderEdge3.BorderStyle = Krypton.Toolkit.PaletteBorderStyle.ButtonStandalone
        Me.kryptonBorderEdge3.Location = New System.Drawing.Point(113, 49)
        Me.kryptonBorderEdge3.Name = "kryptonBorderEdge3"
        Me.kryptonBorderEdge3.Orientation = System.Windows.Forms.Orientation.Vertical
        Me.kryptonBorderEdge3.Size = New System.Drawing.Size(5, 50)
        Me.kryptonBorderEdge3.Text = "kryptonBorderEdge2"
        Me.kryptonBorderEdge2.AutoSize = False
        Me.kryptonBorderEdge2.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink
        Me.kryptonBorderEdge2.BorderStyle = Krypton.Toolkit.PaletteBorderStyle.ButtonStandalone
        Me.kryptonBorderEdge2.Location = New System.Drawing.Point(199, 29)
        Me.kryptonBorderEdge2.Name = "kryptonBorderEdge2"
        Me.kryptonBorderEdge2.Orientation = System.Windows.Forms.Orientation.Horizontal
        Me.kryptonBorderEdge2.Size = New System.Drawing.Size(75, 10)
        Me.kryptonBorderEdge2.Text = "kryptonBorderEdge2"
        Me.kryptonBorderEdge1.AutoSize = False
        Me.kryptonBorderEdge1.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink
        Me.kryptonBorderEdge1.BorderStyle = Krypton.Toolkit.PaletteBorderStyle.ButtonStandalone
        Me.kryptonBorderEdge1.Location = New System.Drawing.Point(110, 29)
        Me.kryptonBorderEdge1.Name = "kryptonBorderEdge1"
        Me.kryptonBorderEdge1.Orientation = System.Windows.Forms.Orientation.Horizontal
        Me.kryptonBorderEdge1.Size = New System.Drawing.Size(75, 5)
        Me.kryptonBorderEdge1.Text = "kryptonBorderEdge1"
        Me.groupBox4.Controls.Add(Me.propertyGrid)
        Me.groupBox4.Location = New System.Drawing.Point(373, 12)
        Me.groupBox4.Name = "groupBox4"
        Me.groupBox4.Size = New System.Drawing.Size(301, 488)
        Me.groupBox4.TabIndex = 4
        Me.groupBox4.TabStop = False
        Me.groupBox4.Text = "Properties for Selection"
        Me.propertyGrid.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) Or System.Windows.Forms.AnchorStyles.Left) Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.propertyGrid.Location = New System.Drawing.Point(6, 19)
        Me.propertyGrid.Name = "propertyGrid"
        Me.propertyGrid.Size = New System.Drawing.Size(289, 463)
        Me.propertyGrid.TabIndex = 0
        Me.propertyGrid.ToolbarVisible = False
        Me.buttonClose.DialogResult = System.Windows.Forms.DialogResult.Cancel
        Me.buttonClose.Location = New System.Drawing.Point(599, 512)
        Me.buttonClose.Name = "buttonClose"
        Me.buttonClose.Size = New System.Drawing.Size(75, 23)
        Me.buttonClose.TabIndex = 5
        Me.buttonClose.Text = "&Close"
        Me.buttonClose.UseVisualStyleBackColor = True
        Me.groupBoxPalettes.Controls.Add(Me.buttonOffice2007Blue)
        Me.groupBoxPalettes.Controls.Add(Me.buttonOffice2010Blue)
        Me.groupBoxPalettes.Controls.Add(Me.buttonSystem)
        Me.groupBoxPalettes.Controls.Add(Me.buttonSparkle)
        Me.groupBoxPalettes.Controls.Add(Me.buttonCustom)
        Me.groupBoxPalettes.Location = New System.Drawing.Point(12, 413)
        Me.groupBoxPalettes.Name = "groupBoxPalettes"
        Me.groupBoxPalettes.Size = New System.Drawing.Size(355, 87)
        Me.groupBoxPalettes.TabIndex = 3
        Me.groupBoxPalettes.TabStop = False
        Me.groupBoxPalettes.Text = "Palettes"
        Me.buttonOffice2007Blue.Location = New System.Drawing.Point(25, 50)
        Me.buttonOffice2007Blue.Name = "buttonOffice2007Blue"
        Me.buttonOffice2007Blue.Size = New System.Drawing.Size(102, 25)
        Me.buttonOffice2007Blue.TabIndex = 1
        Me.buttonOffice2007Blue.Text = "Office 2007 - Blue"
        Me.buttonOffice2007Blue.UseVisualStyleBackColor = True
        Me.buttonOffice2010Blue.Location = New System.Drawing.Point(25, 21)
        Me.buttonOffice2010Blue.Name = "buttonOffice2010Blue"
        Me.buttonOffice2010Blue.Size = New System.Drawing.Size(102, 25)
        Me.buttonOffice2010Blue.TabIndex = 0
        Me.buttonOffice2010Blue.Text = "Office 2010 - Blue"
        Me.buttonOffice2010Blue.UseVisualStyleBackColor = True
        Me.buttonSystem.Location = New System.Drawing.Point(142, 50)
        Me.buttonSystem.Name = "buttonSystem"
        Me.buttonSystem.Size = New System.Drawing.Size(101, 25)
        Me.buttonSystem.TabIndex = 3
        Me.buttonSystem.Text = "System"
        Me.buttonSystem.UseVisualStyleBackColor = True
        Me.buttonSparkle.Location = New System.Drawing.Point(141, 21)
        Me.buttonSparkle.Name = "buttonSparkle"
        Me.buttonSparkle.Size = New System.Drawing.Size(102, 25)
        Me.buttonSparkle.TabIndex = 2
        Me.buttonSparkle.Text = "Sparkle - Blue"
        Me.buttonSparkle.UseVisualStyleBackColor = True
        Me.buttonCustom.Location = New System.Drawing.Point(259, 21)
        Me.buttonCustom.Name = "buttonCustom"
        Me.buttonCustom.Size = New System.Drawing.Size(75, 25)
        Me.buttonCustom.TabIndex = 4
        Me.buttonCustom.Text = "Custom"
        Me.buttonCustom.UseVisualStyleBackColor = True
        Me.kryptonPaletteOffice2007Blue.BaseRenderMode = Krypton.Toolkit.RendererMode.Inherit
        Me.kryptonManager.GlobalCustomPalette = Me.kryptonPaletteOffice2007Blue
        Me.kryptonManager.GlobalPaletteMode = Krypton.Toolkit.PaletteMode.Custom
        Me.kryptonPaletteOffice2010Blue.BaseRenderMode = Krypton.Toolkit.RendererMode.Inherit
        Me.kryptonPaletteOffice2007Blue.BasePaletteType = Krypton.Toolkit.BasePaletteType.Office2007
        Me.kryptonPaletteOffice2007Blue.BaseRenderMode = Krypton.Toolkit.RendererMode.Inherit
        Me.kryptonPaletteCustom.UseThemeFormChromeBorderWidth = Krypton.Toolkit.InheritBool.False
        Me.kryptonPaletteCustom.BaseRenderMode = Krypton.Toolkit.RendererMode.Inherit
        Me.kryptonPaletteCustom.ButtonStyles.ButtonButtonSpec.StateDisabled.Border.ColorAlign = Krypton.Toolkit.PaletteRectangleAlign.Inherit
        Me.kryptonPaletteCustom.ButtonStyles.ButtonButtonSpec.StateDisabled.Border.ColorStyle = Krypton.Toolkit.PaletteColorStyle.Inherit
        Me.kryptonPaletteCustom.ButtonStyles.ButtonButtonSpec.StateDisabled.Border.Draw = Krypton.Toolkit.InheritBool.False
        Me.kryptonPaletteCustom.ButtonStyles.ButtonButtonSpec.StateDisabled.Border.DrawBorders = CType((((Krypton.Toolkit.PaletteDrawBorders.Top Or Krypton.Toolkit.PaletteDrawBorders.Bottom) Or Krypton.Toolkit.PaletteDrawBorders.Left) Or Krypton.Toolkit.PaletteDrawBorders.Right), Krypton.Toolkit.PaletteDrawBorders)
        Me.kryptonPaletteCustom.ButtonStyles.ButtonButtonSpec.StateDisabled.Border.GraphicsHint = Krypton.Toolkit.PaletteGraphicsHint.Inherit
        Me.kryptonPaletteCustom.ButtonStyles.ButtonButtonSpec.StateDisabled.Border.ImageAlign = Krypton.Toolkit.PaletteRectangleAlign.Inherit
        Me.kryptonPaletteCustom.ButtonStyles.ButtonButtonSpec.StateNormal.Back.ColorAlign = Krypton.Toolkit.PaletteRectangleAlign.Inherit
        Me.kryptonPaletteCustom.ButtonStyles.ButtonButtonSpec.StateNormal.Back.ColorStyle = Krypton.Toolkit.PaletteColorStyle.Inherit
        Me.kryptonPaletteCustom.ButtonStyles.ButtonButtonSpec.StateNormal.Back.Draw = Krypton.Toolkit.InheritBool.False
        Me.kryptonPaletteCustom.ButtonStyles.ButtonButtonSpec.StateNormal.Back.GraphicsHint = Krypton.Toolkit.PaletteGraphicsHint.Inherit
        Me.kryptonPaletteCustom.ButtonStyles.ButtonButtonSpec.StateNormal.Back.ImageAlign = Krypton.Toolkit.PaletteRectangleAlign.Inherit
        Me.kryptonPaletteCustom.ButtonStyles.ButtonButtonSpec.StateNormal.Back.ImageStyle = Krypton.Toolkit.PaletteImageStyle.Inherit
        Me.kryptonPaletteCustom.ButtonStyles.ButtonButtonSpec.StateNormal.Border.Color1 = System.Drawing.Color.Transparent
        Me.kryptonPaletteCustom.ButtonStyles.ButtonButtonSpec.StateNormal.Border.ColorAlign = Krypton.Toolkit.PaletteRectangleAlign.Inherit
        Me.kryptonPaletteCustom.ButtonStyles.ButtonButtonSpec.StateNormal.Border.ColorStyle = Krypton.Toolkit.PaletteColorStyle.Inherit
        Me.kryptonPaletteCustom.ButtonStyles.ButtonButtonSpec.StateNormal.Border.Draw = Krypton.Toolkit.InheritBool.True
        Me.kryptonPaletteCustom.ButtonStyles.ButtonButtonSpec.StateNormal.Border.DrawBorders = CType((((Krypton.Toolkit.PaletteDrawBorders.Top Or Krypton.Toolkit.PaletteDrawBorders.Bottom) Or Krypton.Toolkit.PaletteDrawBorders.Left) Or Krypton.Toolkit.PaletteDrawBorders.Right), Krypton.Toolkit.PaletteDrawBorders)
        Me.kryptonPaletteCustom.ButtonStyles.ButtonButtonSpec.StateNormal.Border.GraphicsHint = Krypton.Toolkit.PaletteGraphicsHint.Inherit
        Me.kryptonPaletteCustom.ButtonStyles.ButtonButtonSpec.StateNormal.Border.ImageAlign = Krypton.Toolkit.PaletteRectangleAlign.Inherit
        Me.kryptonPaletteCustom.ButtonStyles.ButtonButtonSpec.StateNormal.Content.Draw = Krypton.Toolkit.InheritBool.Inherit
        Me.kryptonPaletteCustom.ButtonStyles.ButtonButtonSpec.StateNormal.Content.DrawFocus = Krypton.Toolkit.InheritBool.Inherit
        Me.kryptonPaletteCustom.ButtonStyles.ButtonButtonSpec.StateNormal.Content.LongText.Color1 = System.Drawing.Color.Black
        Me.kryptonPaletteCustom.ButtonStyles.ButtonButtonSpec.StateNormal.Content.LongText.ColorAlign = Krypton.Toolkit.PaletteRectangleAlign.Inherit
        Me.kryptonPaletteCustom.ButtonStyles.ButtonButtonSpec.StateNormal.Content.LongText.ColorStyle = Krypton.Toolkit.PaletteColorStyle.Inherit
        Me.kryptonPaletteCustom.ButtonStyles.ButtonButtonSpec.StateNormal.Content.LongText.Hint = Krypton.Toolkit.PaletteTextHint.Inherit
        Me.kryptonPaletteCustom.ButtonStyles.ButtonButtonSpec.StateNormal.Content.LongText.ImageAlign = Krypton.Toolkit.PaletteRectangleAlign.Inherit
        Me.kryptonPaletteCustom.ButtonStyles.ButtonButtonSpec.StateNormal.Content.LongText.ImageStyle = Krypton.Toolkit.PaletteImageStyle.Inherit
        Me.kryptonPaletteCustom.ButtonStyles.ButtonButtonSpec.StateNormal.Content.LongText.MultiLine = Krypton.Toolkit.InheritBool.Inherit
        Me.kryptonPaletteCustom.ButtonStyles.ButtonButtonSpec.StateNormal.Content.LongText.MultiLineH = Krypton.Toolkit.PaletteRelativeAlign.Inherit
        Me.kryptonPaletteCustom.ButtonStyles.ButtonButtonSpec.StateNormal.Content.LongText.Prefix = Krypton.Toolkit.PaletteTextHotkeyPrefix.Inherit
        Me.kryptonPaletteCustom.ButtonStyles.ButtonButtonSpec.StateNormal.Content.LongText.TextH = Krypton.Toolkit.PaletteRelativeAlign.Inherit
        Me.kryptonPaletteCustom.ButtonStyles.ButtonButtonSpec.StateNormal.Content.LongText.TextV = Krypton.Toolkit.PaletteRelativeAlign.Inherit
        Me.kryptonPaletteCustom.ButtonStyles.ButtonButtonSpec.StateNormal.Content.LongText.Trim = Krypton.Toolkit.PaletteTextTrim.Inherit
        Me.kryptonPaletteCustom.ButtonStyles.ButtonButtonSpec.StateNormal.Content.Padding = New System.Windows.Forms.Padding(3)
        Me.kryptonPaletteCustom.ButtonStyles.ButtonButtonSpec.StateNormal.Content.ShortText.Color1 = System.Drawing.Color.Black
        Me.kryptonPaletteCustom.ButtonStyles.ButtonButtonSpec.StateNormal.Content.ShortText.ColorAlign = Krypton.Toolkit.PaletteRectangleAlign.Inherit
        Me.kryptonPaletteCustom.ButtonStyles.ButtonButtonSpec.StateNormal.Content.ShortText.ColorStyle = Krypton.Toolkit.PaletteColorStyle.Inherit
        Me.kryptonPaletteCustom.ButtonStyles.ButtonButtonSpec.StateNormal.Content.ShortText.Hint = Krypton.Toolkit.PaletteTextHint.Inherit
        Me.kryptonPaletteCustom.ButtonStyles.ButtonButtonSpec.StateNormal.Content.ShortText.ImageAlign = Krypton.Toolkit.PaletteRectangleAlign.Inherit
        Me.kryptonPaletteCustom.ButtonStyles.ButtonButtonSpec.StateNormal.Content.ShortText.ImageStyle = Krypton.Toolkit.PaletteImageStyle.Inherit
        Me.kryptonPaletteCustom.ButtonStyles.ButtonButtonSpec.StateNormal.Content.ShortText.MultiLine = Krypton.Toolkit.InheritBool.Inherit
        Me.kryptonPaletteCustom.ButtonStyles.ButtonButtonSpec.StateNormal.Content.ShortText.MultiLineH = Krypton.Toolkit.PaletteRelativeAlign.Inherit
        Me.kryptonPaletteCustom.ButtonStyles.ButtonButtonSpec.StateNormal.Content.ShortText.Prefix = Krypton.Toolkit.PaletteTextHotkeyPrefix.Inherit
        Me.kryptonPaletteCustom.ButtonStyles.ButtonButtonSpec.StateNormal.Content.ShortText.TextH = Krypton.Toolkit.PaletteRelativeAlign.Inherit
        Me.kryptonPaletteCustom.ButtonStyles.ButtonButtonSpec.StateNormal.Content.ShortText.TextV = Krypton.Toolkit.PaletteRelativeAlign.Inherit
        Me.kryptonPaletteCustom.ButtonStyles.ButtonButtonSpec.StateNormal.Content.ShortText.Trim = Krypton.Toolkit.PaletteTextTrim.Inherit
        Me.kryptonPaletteCustom.ButtonStyles.ButtonCommon.StateCheckedNormal.Back.Color1 = System.Drawing.Color.FromArgb(CType(CType(192, Byte), Integer), CType(CType(64, Byte), Integer), CType(CType(0, Byte), Integer))
        Me.kryptonPaletteCustom.ButtonStyles.ButtonCommon.StateCheckedNormal.Back.ColorAlign = Krypton.Toolkit.PaletteRectangleAlign.Inherit
        Me.kryptonPaletteCustom.ButtonStyles.ButtonCommon.StateCheckedNormal.Back.ColorStyle = Krypton.Toolkit.PaletteColorStyle.Inherit
        Me.kryptonPaletteCustom.ButtonStyles.ButtonCommon.StateCheckedNormal.Back.Draw = Krypton.Toolkit.InheritBool.Inherit
        Me.kryptonPaletteCustom.ButtonStyles.ButtonCommon.StateCheckedNormal.Back.GraphicsHint = Krypton.Toolkit.PaletteGraphicsHint.Inherit
        Me.kryptonPaletteCustom.ButtonStyles.ButtonCommon.StateCheckedNormal.Back.ImageAlign = Krypton.Toolkit.PaletteRectangleAlign.Inherit
        Me.kryptonPaletteCustom.ButtonStyles.ButtonCommon.StateCheckedNormal.Back.ImageStyle = Krypton.Toolkit.PaletteImageStyle.Inherit
        Me.kryptonPaletteCustom.ButtonStyles.ButtonCommon.StateCheckedPressed.Back.Color1 = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(102, Byte), Integer), CType(CType(0, Byte), Integer))
        Me.kryptonPaletteCustom.ButtonStyles.ButtonCommon.StateCheckedPressed.Back.ColorAlign = Krypton.Toolkit.PaletteRectangleAlign.Inherit
        Me.kryptonPaletteCustom.ButtonStyles.ButtonCommon.StateCheckedPressed.Back.ColorStyle = Krypton.Toolkit.PaletteColorStyle.Inherit
        Me.kryptonPaletteCustom.ButtonStyles.ButtonCommon.StateCheckedPressed.Back.Draw = Krypton.Toolkit.InheritBool.Inherit
        Me.kryptonPaletteCustom.ButtonStyles.ButtonCommon.StateCheckedPressed.Back.GraphicsHint = Krypton.Toolkit.PaletteGraphicsHint.Inherit
        Me.kryptonPaletteCustom.ButtonStyles.ButtonCommon.StateCheckedPressed.Back.ImageAlign = Krypton.Toolkit.PaletteRectangleAlign.Inherit
        Me.kryptonPaletteCustom.ButtonStyles.ButtonCommon.StateCheckedPressed.Back.ImageStyle = Krypton.Toolkit.PaletteImageStyle.Inherit
        Me.kryptonPaletteCustom.ButtonStyles.ButtonCommon.StateCheckedPressed.Content.Draw = Krypton.Toolkit.InheritBool.Inherit
        Me.kryptonPaletteCustom.ButtonStyles.ButtonCommon.StateCheckedPressed.Content.DrawFocus = Krypton.Toolkit.InheritBool.Inherit
        Me.kryptonPaletteCustom.ButtonStyles.ButtonCommon.StateCheckedPressed.Content.Padding = New System.Windows.Forms.Padding(5, 5, 1, 1)
        Me.kryptonPaletteCustom.ButtonStyles.ButtonCommon.StateCheckedTracking.Back.Color1 = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(102, Byte), Integer), CType(CType(0, Byte), Integer))
        Me.kryptonPaletteCustom.ButtonStyles.ButtonCommon.StateCheckedTracking.Back.ColorAlign = Krypton.Toolkit.PaletteRectangleAlign.Inherit
        Me.kryptonPaletteCustom.ButtonStyles.ButtonCommon.StateCheckedTracking.Back.ColorStyle = Krypton.Toolkit.PaletteColorStyle.Inherit
        Me.kryptonPaletteCustom.ButtonStyles.ButtonCommon.StateCheckedTracking.Back.Draw = Krypton.Toolkit.InheritBool.Inherit
        Me.kryptonPaletteCustom.ButtonStyles.ButtonCommon.StateCheckedTracking.Back.GraphicsHint = Krypton.Toolkit.PaletteGraphicsHint.Inherit
        Me.kryptonPaletteCustom.ButtonStyles.ButtonCommon.StateCheckedTracking.Back.ImageAlign = Krypton.Toolkit.PaletteRectangleAlign.Inherit
        Me.kryptonPaletteCustom.ButtonStyles.ButtonCommon.StateCheckedTracking.Back.ImageStyle = Krypton.Toolkit.PaletteImageStyle.Inherit
        Me.kryptonPaletteCustom.ButtonStyles.ButtonCommon.StateCommon.Back.ColorAlign = Krypton.Toolkit.PaletteRectangleAlign.Inherit
        Me.kryptonPaletteCustom.ButtonStyles.ButtonCommon.StateCommon.Back.ColorStyle = Krypton.Toolkit.PaletteColorStyle.Solid
        Me.kryptonPaletteCustom.ButtonStyles.ButtonCommon.StateCommon.Back.Draw = Krypton.Toolkit.InheritBool.Inherit
        Me.kryptonPaletteCustom.ButtonStyles.ButtonCommon.StateCommon.Back.GraphicsHint = Krypton.Toolkit.PaletteGraphicsHint.Inherit
        Me.kryptonPaletteCustom.ButtonStyles.ButtonCommon.StateCommon.Back.ImageAlign = Krypton.Toolkit.PaletteRectangleAlign.Inherit
        Me.kryptonPaletteCustom.ButtonStyles.ButtonCommon.StateCommon.Back.ImageStyle = Krypton.Toolkit.PaletteImageStyle.Inherit
        Me.kryptonPaletteCustom.ButtonStyles.ButtonCommon.StateCommon.Border.Color1 = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(51, Byte), Integer), CType(CType(102, Byte), Integer))
        Me.kryptonPaletteCustom.ButtonStyles.ButtonCommon.StateCommon.Border.ColorAlign = Krypton.Toolkit.PaletteRectangleAlign.Inherit
        Me.kryptonPaletteCustom.ButtonStyles.ButtonCommon.StateCommon.Border.ColorStyle = Krypton.Toolkit.PaletteColorStyle.Solid
        Me.kryptonPaletteCustom.ButtonStyles.ButtonCommon.StateCommon.Border.Draw = Krypton.Toolkit.InheritBool.Inherit
        Me.kryptonPaletteCustom.ButtonStyles.ButtonCommon.StateCommon.Border.DrawBorders = CType((((Krypton.Toolkit.PaletteDrawBorders.Top Or Krypton.Toolkit.PaletteDrawBorders.Bottom) Or Krypton.Toolkit.PaletteDrawBorders.Left) Or Krypton.Toolkit.PaletteDrawBorders.Right), Krypton.Toolkit.PaletteDrawBorders)
        Me.kryptonPaletteCustom.ButtonStyles.ButtonCommon.StateCommon.Border.GraphicsHint = Krypton.Toolkit.PaletteGraphicsHint.AntiAlias
        Me.kryptonPaletteCustom.ButtonStyles.ButtonCommon.StateCommon.Border.ImageAlign = Krypton.Toolkit.PaletteRectangleAlign.Inherit
        Me.kryptonPaletteCustom.ButtonStyles.ButtonCommon.StateCommon.Border.Rounding = 3F
        Me.kryptonPaletteCustom.ButtonStyles.ButtonCommon.StateCommon.Border.Width = 3
        Me.kryptonPaletteCustom.ButtonStyles.ButtonCommon.StateCommon.Content.Draw = Krypton.Toolkit.InheritBool.Inherit
        Me.kryptonPaletteCustom.ButtonStyles.ButtonCommon.StateCommon.Content.DrawFocus = Krypton.Toolkit.InheritBool.Inherit
        Me.kryptonPaletteCustom.ButtonStyles.ButtonCommon.StateCommon.Content.LongText.Color1 = System.Drawing.Color.White
        Me.kryptonPaletteCustom.ButtonStyles.ButtonCommon.StateCommon.Content.LongText.ColorAlign = Krypton.Toolkit.PaletteRectangleAlign.Inherit
        Me.kryptonPaletteCustom.ButtonStyles.ButtonCommon.StateCommon.Content.LongText.ColorStyle = Krypton.Toolkit.PaletteColorStyle.Solid
        Me.kryptonPaletteCustom.ButtonStyles.ButtonCommon.StateCommon.Content.LongText.Hint = Krypton.Toolkit.PaletteTextHint.Inherit
        Me.kryptonPaletteCustom.ButtonStyles.ButtonCommon.StateCommon.Content.LongText.ImageAlign = Krypton.Toolkit.PaletteRectangleAlign.Inherit
        Me.kryptonPaletteCustom.ButtonStyles.ButtonCommon.StateCommon.Content.LongText.ImageStyle = Krypton.Toolkit.PaletteImageStyle.Inherit
        Me.kryptonPaletteCustom.ButtonStyles.ButtonCommon.StateCommon.Content.LongText.MultiLine = Krypton.Toolkit.InheritBool.Inherit
        Me.kryptonPaletteCustom.ButtonStyles.ButtonCommon.StateCommon.Content.LongText.MultiLineH = Krypton.Toolkit.PaletteRelativeAlign.Inherit
        Me.kryptonPaletteCustom.ButtonStyles.ButtonCommon.StateCommon.Content.LongText.Prefix = Krypton.Toolkit.PaletteTextHotkeyPrefix.Inherit
        Me.kryptonPaletteCustom.ButtonStyles.ButtonCommon.StateCommon.Content.LongText.TextH = Krypton.Toolkit.PaletteRelativeAlign.Inherit
        Me.kryptonPaletteCustom.ButtonStyles.ButtonCommon.StateCommon.Content.LongText.TextV = Krypton.Toolkit.PaletteRelativeAlign.Inherit
        Me.kryptonPaletteCustom.ButtonStyles.ButtonCommon.StateCommon.Content.LongText.Trim = Krypton.Toolkit.PaletteTextTrim.Inherit
        Me.kryptonPaletteCustom.ButtonStyles.ButtonCommon.StateCommon.Content.Padding = New System.Windows.Forms.Padding(3)
        Me.kryptonPaletteCustom.ButtonStyles.ButtonCommon.StateCommon.Content.ShortText.Color1 = System.Drawing.Color.White
        Me.kryptonPaletteCustom.ButtonStyles.ButtonCommon.StateCommon.Content.ShortText.ColorAlign = Krypton.Toolkit.PaletteRectangleAlign.Inherit
        Me.kryptonPaletteCustom.ButtonStyles.ButtonCommon.StateCommon.Content.ShortText.ColorStyle = Krypton.Toolkit.PaletteColorStyle.Solid
        Me.kryptonPaletteCustom.ButtonStyles.ButtonCommon.StateCommon.Content.ShortText.Hint = Krypton.Toolkit.PaletteTextHint.Inherit
        Me.kryptonPaletteCustom.ButtonStyles.ButtonCommon.StateCommon.Content.ShortText.ImageAlign = Krypton.Toolkit.PaletteRectangleAlign.Inherit
        Me.kryptonPaletteCustom.ButtonStyles.ButtonCommon.StateCommon.Content.ShortText.ImageStyle = Krypton.Toolkit.PaletteImageStyle.Inherit
        Me.kryptonPaletteCustom.ButtonStyles.ButtonCommon.StateCommon.Content.ShortText.MultiLine = Krypton.Toolkit.InheritBool.Inherit
        Me.kryptonPaletteCustom.ButtonStyles.ButtonCommon.StateCommon.Content.ShortText.MultiLineH = Krypton.Toolkit.PaletteRelativeAlign.Inherit
        Me.kryptonPaletteCustom.ButtonStyles.ButtonCommon.StateCommon.Content.ShortText.Prefix = Krypton.Toolkit.PaletteTextHotkeyPrefix.Inherit
        Me.kryptonPaletteCustom.ButtonStyles.ButtonCommon.StateCommon.Content.ShortText.TextH = Krypton.Toolkit.PaletteRelativeAlign.Inherit
        Me.kryptonPaletteCustom.ButtonStyles.ButtonCommon.StateCommon.Content.ShortText.TextV = Krypton.Toolkit.PaletteRelativeAlign.Inherit
        Me.kryptonPaletteCustom.ButtonStyles.ButtonCommon.StateCommon.Content.ShortText.Trim = Krypton.Toolkit.PaletteTextTrim.Inherit
        Me.kryptonPaletteCustom.ButtonStyles.ButtonCommon.StateDisabled.Border.Color1 = System.Drawing.Color.Silver
        Me.kryptonPaletteCustom.ButtonStyles.ButtonCommon.StateDisabled.Border.ColorAlign = Krypton.Toolkit.PaletteRectangleAlign.Inherit
        Me.kryptonPaletteCustom.ButtonStyles.ButtonCommon.StateDisabled.Border.ColorStyle = Krypton.Toolkit.PaletteColorStyle.Inherit
        Me.kryptonPaletteCustom.ButtonStyles.ButtonCommon.StateDisabled.Border.Draw = Krypton.Toolkit.InheritBool.Inherit
        Me.kryptonPaletteCustom.ButtonStyles.ButtonCommon.StateDisabled.Border.DrawBorders = CType((((Krypton.Toolkit.PaletteDrawBorders.Top Or Krypton.Toolkit.PaletteDrawBorders.Bottom) Or Krypton.Toolkit.PaletteDrawBorders.Left) Or Krypton.Toolkit.PaletteDrawBorders.Right), Krypton.Toolkit.PaletteDrawBorders)
        Me.kryptonPaletteCustom.ButtonStyles.ButtonCommon.StateDisabled.Border.GraphicsHint = Krypton.Toolkit.PaletteGraphicsHint.Inherit
        Me.kryptonPaletteCustom.ButtonStyles.ButtonCommon.StateDisabled.Border.ImageAlign = Krypton.Toolkit.PaletteRectangleAlign.Inherit
        Me.kryptonPaletteCustom.ButtonStyles.ButtonCommon.StateDisabled.Content.Draw = Krypton.Toolkit.InheritBool.Inherit
        Me.kryptonPaletteCustom.ButtonStyles.ButtonCommon.StateDisabled.Content.DrawFocus = Krypton.Toolkit.InheritBool.Inherit
        Me.kryptonPaletteCustom.ButtonStyles.ButtonCommon.StateDisabled.Content.LongText.Color1 = System.Drawing.Color.Silver
        Me.kryptonPaletteCustom.ButtonStyles.ButtonCommon.StateDisabled.Content.LongText.ColorAlign = Krypton.Toolkit.PaletteRectangleAlign.Inherit
        Me.kryptonPaletteCustom.ButtonStyles.ButtonCommon.StateDisabled.Content.LongText.ColorStyle = Krypton.Toolkit.PaletteColorStyle.Inherit
        Me.kryptonPaletteCustom.ButtonStyles.ButtonCommon.StateDisabled.Content.LongText.Hint = Krypton.Toolkit.PaletteTextHint.Inherit
        Me.kryptonPaletteCustom.ButtonStyles.ButtonCommon.StateDisabled.Content.LongText.ImageAlign = Krypton.Toolkit.PaletteRectangleAlign.Inherit
        Me.kryptonPaletteCustom.ButtonStyles.ButtonCommon.StateDisabled.Content.LongText.ImageStyle = Krypton.Toolkit.PaletteImageStyle.Inherit
        Me.kryptonPaletteCustom.ButtonStyles.ButtonCommon.StateDisabled.Content.LongText.MultiLine = Krypton.Toolkit.InheritBool.Inherit
        Me.kryptonPaletteCustom.ButtonStyles.ButtonCommon.StateDisabled.Content.LongText.MultiLineH = Krypton.Toolkit.PaletteRelativeAlign.Inherit
        Me.kryptonPaletteCustom.ButtonStyles.ButtonCommon.StateDisabled.Content.LongText.Prefix = Krypton.Toolkit.PaletteTextHotkeyPrefix.Inherit
        Me.kryptonPaletteCustom.ButtonStyles.ButtonCommon.StateDisabled.Content.LongText.TextH = Krypton.Toolkit.PaletteRelativeAlign.Inherit
        Me.kryptonPaletteCustom.ButtonStyles.ButtonCommon.StateDisabled.Content.LongText.TextV = Krypton.Toolkit.PaletteRelativeAlign.Inherit
        Me.kryptonPaletteCustom.ButtonStyles.ButtonCommon.StateDisabled.Content.LongText.Trim = Krypton.Toolkit.PaletteTextTrim.Inherit
        Me.kryptonPaletteCustom.ButtonStyles.ButtonCommon.StateDisabled.Content.Padding = New System.Windows.Forms.Padding(-1)
        Me.kryptonPaletteCustom.ButtonStyles.ButtonCommon.StateDisabled.Content.ShortText.Color1 = System.Drawing.Color.Silver
        Me.kryptonPaletteCustom.ButtonStyles.ButtonCommon.StateDisabled.Content.ShortText.ColorAlign = Krypton.Toolkit.PaletteRectangleAlign.Inherit
        Me.kryptonPaletteCustom.ButtonStyles.ButtonCommon.StateDisabled.Content.ShortText.ColorStyle = Krypton.Toolkit.PaletteColorStyle.Inherit
        Me.kryptonPaletteCustom.ButtonStyles.ButtonCommon.StateDisabled.Content.ShortText.Hint = Krypton.Toolkit.PaletteTextHint.Inherit
        Me.kryptonPaletteCustom.ButtonStyles.ButtonCommon.StateDisabled.Content.ShortText.ImageAlign = Krypton.Toolkit.PaletteRectangleAlign.Inherit
        Me.kryptonPaletteCustom.ButtonStyles.ButtonCommon.StateDisabled.Content.ShortText.ImageStyle = Krypton.Toolkit.PaletteImageStyle.Inherit
        Me.kryptonPaletteCustom.ButtonStyles.ButtonCommon.StateDisabled.Content.ShortText.MultiLine = Krypton.Toolkit.InheritBool.Inherit
        Me.kryptonPaletteCustom.ButtonStyles.ButtonCommon.StateDisabled.Content.ShortText.MultiLineH = Krypton.Toolkit.PaletteRelativeAlign.Inherit
        Me.kryptonPaletteCustom.ButtonStyles.ButtonCommon.StateDisabled.Content.ShortText.Prefix = Krypton.Toolkit.PaletteTextHotkeyPrefix.Inherit
        Me.kryptonPaletteCustom.ButtonStyles.ButtonCommon.StateDisabled.Content.ShortText.TextH = Krypton.Toolkit.PaletteRelativeAlign.Inherit
        Me.kryptonPaletteCustom.ButtonStyles.ButtonCommon.StateDisabled.Content.ShortText.TextV = Krypton.Toolkit.PaletteRelativeAlign.Inherit
        Me.kryptonPaletteCustom.ButtonStyles.ButtonCommon.StateDisabled.Content.ShortText.Trim = Krypton.Toolkit.PaletteTextTrim.Inherit
        Me.kryptonPaletteCustom.ButtonStyles.ButtonCommon.StateNormal.Back.Color1 = System.Drawing.Color.FromArgb(CType(CType(51, Byte), Integer), CType(CType(102, Byte), Integer), CType(CType(204, Byte), Integer))
        Me.kryptonPaletteCustom.ButtonStyles.ButtonCommon.StateNormal.Back.ColorAlign = Krypton.Toolkit.PaletteRectangleAlign.Inherit
        Me.kryptonPaletteCustom.ButtonStyles.ButtonCommon.StateNormal.Back.ColorStyle = Krypton.Toolkit.PaletteColorStyle.Inherit
        Me.kryptonPaletteCustom.ButtonStyles.ButtonCommon.StateNormal.Back.Draw = Krypton.Toolkit.InheritBool.Inherit
        Me.kryptonPaletteCustom.ButtonStyles.ButtonCommon.StateNormal.Back.GraphicsHint = Krypton.Toolkit.PaletteGraphicsHint.Inherit
        Me.kryptonPaletteCustom.ButtonStyles.ButtonCommon.StateNormal.Back.ImageAlign = Krypton.Toolkit.PaletteRectangleAlign.Inherit
        Me.kryptonPaletteCustom.ButtonStyles.ButtonCommon.StateNormal.Back.ImageStyle = Krypton.Toolkit.PaletteImageStyle.Inherit
        Me.kryptonPaletteCustom.ButtonStyles.ButtonCommon.StatePressed.Back.Color1 = System.Drawing.Color.FromArgb(CType(CType(102, Byte), Integer), CType(CType(153, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.kryptonPaletteCustom.ButtonStyles.ButtonCommon.StatePressed.Back.ColorAlign = Krypton.Toolkit.PaletteRectangleAlign.Inherit
        Me.kryptonPaletteCustom.ButtonStyles.ButtonCommon.StatePressed.Back.ColorStyle = Krypton.Toolkit.PaletteColorStyle.Inherit
        Me.kryptonPaletteCustom.ButtonStyles.ButtonCommon.StatePressed.Back.Draw = Krypton.Toolkit.InheritBool.Inherit
        Me.kryptonPaletteCustom.ButtonStyles.ButtonCommon.StatePressed.Back.GraphicsHint = Krypton.Toolkit.PaletteGraphicsHint.Inherit
        Me.kryptonPaletteCustom.ButtonStyles.ButtonCommon.StatePressed.Back.ImageAlign = Krypton.Toolkit.PaletteRectangleAlign.Inherit
        Me.kryptonPaletteCustom.ButtonStyles.ButtonCommon.StatePressed.Back.ImageStyle = Krypton.Toolkit.PaletteImageStyle.Inherit
        Me.kryptonPaletteCustom.ButtonStyles.ButtonCommon.StatePressed.Content.Draw = Krypton.Toolkit.InheritBool.Inherit
        Me.kryptonPaletteCustom.ButtonStyles.ButtonCommon.StatePressed.Content.DrawFocus = Krypton.Toolkit.InheritBool.Inherit
        Me.kryptonPaletteCustom.ButtonStyles.ButtonCommon.StatePressed.Content.Padding = New System.Windows.Forms.Padding(5, 5, 1, 1)
        Me.kryptonPaletteCustom.ButtonStyles.ButtonCommon.StateTracking.Back.Color1 = System.Drawing.Color.FromArgb(CType(CType(102, Byte), Integer), CType(CType(153, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.kryptonPaletteCustom.ButtonStyles.ButtonCommon.StateTracking.Back.ColorAlign = Krypton.Toolkit.PaletteRectangleAlign.Inherit
        Me.kryptonPaletteCustom.ButtonStyles.ButtonCommon.StateTracking.Back.ColorStyle = Krypton.Toolkit.PaletteColorStyle.Inherit
        Me.kryptonPaletteCustom.ButtonStyles.ButtonCommon.StateTracking.Back.Draw = Krypton.Toolkit.InheritBool.Inherit
        Me.kryptonPaletteCustom.ButtonStyles.ButtonCommon.StateTracking.Back.GraphicsHint = Krypton.Toolkit.PaletteGraphicsHint.Inherit
        Me.kryptonPaletteCustom.ButtonStyles.ButtonCommon.StateTracking.Back.ImageAlign = Krypton.Toolkit.PaletteRectangleAlign.Inherit
        Me.kryptonPaletteCustom.ButtonStyles.ButtonCommon.StateTracking.Back.ImageStyle = Krypton.Toolkit.PaletteImageStyle.Inherit
        Me.kryptonPaletteCustom.ButtonStyles.ButtonLowProfile.StateDisabled.Border.ColorAlign = Krypton.Toolkit.PaletteRectangleAlign.Inherit
        Me.kryptonPaletteCustom.ButtonStyles.ButtonLowProfile.StateDisabled.Border.ColorStyle = Krypton.Toolkit.PaletteColorStyle.Inherit
        Me.kryptonPaletteCustom.ButtonStyles.ButtonLowProfile.StateDisabled.Border.Draw = Krypton.Toolkit.InheritBool.False
        Me.kryptonPaletteCustom.ButtonStyles.ButtonLowProfile.StateDisabled.Border.DrawBorders = CType((((Krypton.Toolkit.PaletteDrawBorders.Top Or Krypton.Toolkit.PaletteDrawBorders.Bottom) Or Krypton.Toolkit.PaletteDrawBorders.Left) Or Krypton.Toolkit.PaletteDrawBorders.Right), Krypton.Toolkit.PaletteDrawBorders)
        Me.kryptonPaletteCustom.ButtonStyles.ButtonLowProfile.StateDisabled.Border.GraphicsHint = Krypton.Toolkit.PaletteGraphicsHint.Inherit
        Me.kryptonPaletteCustom.ButtonStyles.ButtonLowProfile.StateDisabled.Border.ImageAlign = Krypton.Toolkit.PaletteRectangleAlign.Inherit
        Me.kryptonPaletteCustom.ButtonStyles.ButtonLowProfile.StateNormal.Back.ColorAlign = Krypton.Toolkit.PaletteRectangleAlign.Inherit
        Me.kryptonPaletteCustom.ButtonStyles.ButtonLowProfile.StateNormal.Back.ColorStyle = Krypton.Toolkit.PaletteColorStyle.Inherit
        Me.kryptonPaletteCustom.ButtonStyles.ButtonLowProfile.StateNormal.Back.Draw = Krypton.Toolkit.InheritBool.False
        Me.kryptonPaletteCustom.ButtonStyles.ButtonLowProfile.StateNormal.Back.GraphicsHint = Krypton.Toolkit.PaletteGraphicsHint.Inherit
        Me.kryptonPaletteCustom.ButtonStyles.ButtonLowProfile.StateNormal.Back.ImageAlign = Krypton.Toolkit.PaletteRectangleAlign.Inherit
        Me.kryptonPaletteCustom.ButtonStyles.ButtonLowProfile.StateNormal.Back.ImageStyle = Krypton.Toolkit.PaletteImageStyle.Inherit
        Me.kryptonPaletteCustom.ButtonStyles.ButtonLowProfile.StateNormal.Border.Color1 = System.Drawing.Color.Transparent
        Me.kryptonPaletteCustom.ButtonStyles.ButtonLowProfile.StateNormal.Border.ColorAlign = Krypton.Toolkit.PaletteRectangleAlign.Inherit
        Me.kryptonPaletteCustom.ButtonStyles.ButtonLowProfile.StateNormal.Border.ColorStyle = Krypton.Toolkit.PaletteColorStyle.Inherit
        Me.kryptonPaletteCustom.ButtonStyles.ButtonLowProfile.StateNormal.Border.Draw = Krypton.Toolkit.InheritBool.True
        Me.kryptonPaletteCustom.ButtonStyles.ButtonLowProfile.StateNormal.Border.DrawBorders = CType((((Krypton.Toolkit.PaletteDrawBorders.Top Or Krypton.Toolkit.PaletteDrawBorders.Bottom) Or Krypton.Toolkit.PaletteDrawBorders.Left) Or Krypton.Toolkit.PaletteDrawBorders.Right), Krypton.Toolkit.PaletteDrawBorders)
        Me.kryptonPaletteCustom.ButtonStyles.ButtonLowProfile.StateNormal.Border.GraphicsHint = Krypton.Toolkit.PaletteGraphicsHint.Inherit
        Me.kryptonPaletteCustom.ButtonStyles.ButtonLowProfile.StateNormal.Border.ImageAlign = Krypton.Toolkit.PaletteRectangleAlign.Inherit
        Me.kryptonPaletteCustom.ButtonStyles.ButtonLowProfile.StateNormal.Content.Draw = Krypton.Toolkit.InheritBool.Inherit
        Me.kryptonPaletteCustom.ButtonStyles.ButtonLowProfile.StateNormal.Content.DrawFocus = Krypton.Toolkit.InheritBool.Inherit
        Me.kryptonPaletteCustom.ButtonStyles.ButtonLowProfile.StateNormal.Content.LongText.Color1 = System.Drawing.Color.Black
        Me.kryptonPaletteCustom.ButtonStyles.ButtonLowProfile.StateNormal.Content.LongText.ColorAlign = Krypton.Toolkit.PaletteRectangleAlign.Inherit
        Me.kryptonPaletteCustom.ButtonStyles.ButtonLowProfile.StateNormal.Content.LongText.ColorStyle = Krypton.Toolkit.PaletteColorStyle.Inherit
        Me.kryptonPaletteCustom.ButtonStyles.ButtonLowProfile.StateNormal.Content.LongText.Hint = Krypton.Toolkit.PaletteTextHint.Inherit
        Me.kryptonPaletteCustom.ButtonStyles.ButtonLowProfile.StateNormal.Content.LongText.ImageAlign = Krypton.Toolkit.PaletteRectangleAlign.Inherit
        Me.kryptonPaletteCustom.ButtonStyles.ButtonLowProfile.StateNormal.Content.LongText.ImageStyle = Krypton.Toolkit.PaletteImageStyle.Inherit
        Me.kryptonPaletteCustom.ButtonStyles.ButtonLowProfile.StateNormal.Content.LongText.MultiLine = Krypton.Toolkit.InheritBool.Inherit
        Me.kryptonPaletteCustom.ButtonStyles.ButtonLowProfile.StateNormal.Content.LongText.MultiLineH = Krypton.Toolkit.PaletteRelativeAlign.Inherit
        Me.kryptonPaletteCustom.ButtonStyles.ButtonLowProfile.StateNormal.Content.LongText.Prefix = Krypton.Toolkit.PaletteTextHotkeyPrefix.Inherit
        Me.kryptonPaletteCustom.ButtonStyles.ButtonLowProfile.StateNormal.Content.LongText.TextH = Krypton.Toolkit.PaletteRelativeAlign.Inherit
        Me.kryptonPaletteCustom.ButtonStyles.ButtonLowProfile.StateNormal.Content.LongText.TextV = Krypton.Toolkit.PaletteRelativeAlign.Inherit
        Me.kryptonPaletteCustom.ButtonStyles.ButtonLowProfile.StateNormal.Content.LongText.Trim = Krypton.Toolkit.PaletteTextTrim.Inherit
        Me.kryptonPaletteCustom.ButtonStyles.ButtonLowProfile.StateNormal.Content.Padding = New System.Windows.Forms.Padding(3)
        Me.kryptonPaletteCustom.ButtonStyles.ButtonLowProfile.StateNormal.Content.ShortText.Color1 = System.Drawing.Color.Black
        Me.kryptonPaletteCustom.ButtonStyles.ButtonLowProfile.StateNormal.Content.ShortText.ColorAlign = Krypton.Toolkit.PaletteRectangleAlign.Inherit
        Me.kryptonPaletteCustom.ButtonStyles.ButtonLowProfile.StateNormal.Content.ShortText.ColorStyle = Krypton.Toolkit.PaletteColorStyle.Inherit
        Me.kryptonPaletteCustom.ButtonStyles.ButtonLowProfile.StateNormal.Content.ShortText.Hint = Krypton.Toolkit.PaletteTextHint.Inherit
        Me.kryptonPaletteCustom.ButtonStyles.ButtonLowProfile.StateNormal.Content.ShortText.ImageAlign = Krypton.Toolkit.PaletteRectangleAlign.Inherit
        Me.kryptonPaletteCustom.ButtonStyles.ButtonLowProfile.StateNormal.Content.ShortText.ImageStyle = Krypton.Toolkit.PaletteImageStyle.Inherit
        Me.kryptonPaletteCustom.ButtonStyles.ButtonLowProfile.StateNormal.Content.ShortText.MultiLine = Krypton.Toolkit.InheritBool.Inherit
        Me.kryptonPaletteCustom.ButtonStyles.ButtonLowProfile.StateNormal.Content.ShortText.MultiLineH = Krypton.Toolkit.PaletteRelativeAlign.Inherit
        Me.kryptonPaletteCustom.ButtonStyles.ButtonLowProfile.StateNormal.Content.ShortText.Prefix = Krypton.Toolkit.PaletteTextHotkeyPrefix.Inherit
        Me.kryptonPaletteCustom.ButtonStyles.ButtonLowProfile.StateNormal.Content.ShortText.TextH = Krypton.Toolkit.PaletteRelativeAlign.Inherit
        Me.kryptonPaletteCustom.ButtonStyles.ButtonLowProfile.StateNormal.Content.ShortText.TextV = Krypton.Toolkit.PaletteRelativeAlign.Inherit
        Me.kryptonPaletteCustom.ButtonStyles.ButtonLowProfile.StateNormal.Content.ShortText.Trim = Krypton.Toolkit.PaletteTextTrim.Inherit
        Me.kryptonPaletteCustom.ButtonStyles.ButtonStandalone.OverrideDefault.Back.Color1 = System.Drawing.Color.FromArgb(CType(CType(51, Byte), Integer), CType(CType(102, Byte), Integer), CType(CType(204, Byte), Integer))
        Me.kryptonPaletteCustom.ButtonStyles.ButtonStandalone.OverrideDefault.Back.ColorAlign = Krypton.Toolkit.PaletteRectangleAlign.Inherit
        Me.kryptonPaletteCustom.ButtonStyles.ButtonStandalone.OverrideDefault.Back.ColorStyle = Krypton.Toolkit.PaletteColorStyle.Inherit
        Me.kryptonPaletteCustom.ButtonStyles.ButtonStandalone.OverrideDefault.Back.Draw = Krypton.Toolkit.InheritBool.Inherit
        Me.kryptonPaletteCustom.ButtonStyles.ButtonStandalone.OverrideDefault.Back.GraphicsHint = Krypton.Toolkit.PaletteGraphicsHint.Inherit
        Me.kryptonPaletteCustom.ButtonStyles.ButtonStandalone.OverrideDefault.Back.ImageAlign = Krypton.Toolkit.PaletteRectangleAlign.Inherit
        Me.kryptonPaletteCustom.ButtonStyles.ButtonStandalone.OverrideDefault.Back.ImageStyle = Krypton.Toolkit.PaletteImageStyle.Inherit
        Me.kryptonPaletteCustom.ButtonStyles.ButtonStandalone.StateDisabled.Back.Color1 = System.Drawing.Color.FromArgb(CType(CType(245, Byte), Integer), CType(CType(237, Byte), Integer), CType(CType(227, Byte), Integer))
        Me.kryptonPaletteCustom.ButtonStyles.ButtonStandalone.StateDisabled.Back.ColorAlign = Krypton.Toolkit.PaletteRectangleAlign.Inherit
        Me.kryptonPaletteCustom.ButtonStyles.ButtonStandalone.StateDisabled.Back.ColorStyle = Krypton.Toolkit.PaletteColorStyle.Inherit
        Me.kryptonPaletteCustom.ButtonStyles.ButtonStandalone.StateDisabled.Back.Draw = Krypton.Toolkit.InheritBool.Inherit
        Me.kryptonPaletteCustom.ButtonStyles.ButtonStandalone.StateDisabled.Back.GraphicsHint = Krypton.Toolkit.PaletteGraphicsHint.Inherit
        Me.kryptonPaletteCustom.ButtonStyles.ButtonStandalone.StateDisabled.Back.ImageAlign = Krypton.Toolkit.PaletteRectangleAlign.Inherit
        Me.kryptonPaletteCustom.ButtonStyles.ButtonStandalone.StateDisabled.Back.ImageStyle = Krypton.Toolkit.PaletteImageStyle.Inherit
        Me.kryptonPaletteCustom.ControlStyles.ControlCommon.StateCommon.Border.ColorAlign = Krypton.Toolkit.PaletteRectangleAlign.Inherit
        Me.kryptonPaletteCustom.ControlStyles.ControlCommon.StateCommon.Border.ColorStyle = Krypton.Toolkit.PaletteColorStyle.Solid
        Me.kryptonPaletteCustom.ControlStyles.ControlCommon.StateCommon.Border.Draw = Krypton.Toolkit.InheritBool.Inherit
        Me.kryptonPaletteCustom.ControlStyles.ControlCommon.StateCommon.Border.DrawBorders = CType((((Krypton.Toolkit.PaletteDrawBorders.Top Or Krypton.Toolkit.PaletteDrawBorders.Bottom) Or Krypton.Toolkit.PaletteDrawBorders.Left) Or Krypton.Toolkit.PaletteDrawBorders.Right), Krypton.Toolkit.PaletteDrawBorders)
        Me.kryptonPaletteCustom.ControlStyles.ControlCommon.StateCommon.Border.GraphicsHint = Krypton.Toolkit.PaletteGraphicsHint.AntiAlias
        Me.kryptonPaletteCustom.ControlStyles.ControlCommon.StateCommon.Border.ImageAlign = Krypton.Toolkit.PaletteRectangleAlign.Inherit
        Me.kryptonPaletteCustom.ControlStyles.ControlCommon.StateCommon.Border.Rounding = 9F
        Me.kryptonPaletteCustom.ControlStyles.ControlCommon.StateCommon.Border.Width = 3
        Me.kryptonPaletteCustom.ControlStyles.ControlCommon.StateDisabled.Border.Color1 = System.Drawing.Color.FromArgb(CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer))
        Me.kryptonPaletteCustom.ControlStyles.ControlCommon.StateDisabled.Border.ColorAlign = Krypton.Toolkit.PaletteRectangleAlign.Inherit
        Me.kryptonPaletteCustom.ControlStyles.ControlCommon.StateDisabled.Border.ColorStyle = Krypton.Toolkit.PaletteColorStyle.Inherit
        Me.kryptonPaletteCustom.ControlStyles.ControlCommon.StateDisabled.Border.Draw = Krypton.Toolkit.InheritBool.Inherit
        Me.kryptonPaletteCustom.ControlStyles.ControlCommon.StateDisabled.Border.DrawBorders = CType((((Krypton.Toolkit.PaletteDrawBorders.Top Or Krypton.Toolkit.PaletteDrawBorders.Bottom) Or Krypton.Toolkit.PaletteDrawBorders.Left) Or Krypton.Toolkit.PaletteDrawBorders.Right), Krypton.Toolkit.PaletteDrawBorders)
        Me.kryptonPaletteCustom.ControlStyles.ControlCommon.StateDisabled.Border.GraphicsHint = Krypton.Toolkit.PaletteGraphicsHint.Inherit
        Me.kryptonPaletteCustom.ControlStyles.ControlCommon.StateDisabled.Border.ImageAlign = Krypton.Toolkit.PaletteRectangleAlign.Inherit
        Me.kryptonPaletteCustom.ControlStyles.ControlCommon.StateNormal.Border.Color1 = System.Drawing.Color.FromArgb(CType(CType(225, Byte), Integer), CType(CType(212, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.kryptonPaletteCustom.ControlStyles.ControlCommon.StateNormal.Border.ColorAlign = Krypton.Toolkit.PaletteRectangleAlign.Inherit
        Me.kryptonPaletteCustom.ControlStyles.ControlCommon.StateNormal.Border.ColorStyle = Krypton.Toolkit.PaletteColorStyle.Inherit
        Me.kryptonPaletteCustom.ControlStyles.ControlCommon.StateNormal.Border.Draw = Krypton.Toolkit.InheritBool.Inherit
        Me.kryptonPaletteCustom.ControlStyles.ControlCommon.StateNormal.Border.DrawBorders = CType((((Krypton.Toolkit.PaletteDrawBorders.Top Or Krypton.Toolkit.PaletteDrawBorders.Bottom) Or Krypton.Toolkit.PaletteDrawBorders.Left) Or Krypton.Toolkit.PaletteDrawBorders.Right), Krypton.Toolkit.PaletteDrawBorders)
        Me.kryptonPaletteCustom.ControlStyles.ControlCommon.StateNormal.Border.GraphicsHint = Krypton.Toolkit.PaletteGraphicsHint.Inherit
        Me.kryptonPaletteCustom.ControlStyles.ControlCommon.StateNormal.Border.ImageAlign = Krypton.Toolkit.PaletteRectangleAlign.Inherit
        Me.kryptonPaletteCustom.HeaderGroup.StateCommon.DockActiveHeaderPadding = New System.Windows.Forms.Padding(-1)
        Me.kryptonPaletteCustom.HeaderGroup.StateCommon.DockInactiveHeaderPadding = New System.Windows.Forms.Padding(-1)
        Me.kryptonPaletteCustom.HeaderGroup.StateCommon.OverlayHeaders = Krypton.Toolkit.InheritBool.False
        Me.kryptonPaletteCustom.HeaderGroup.StateCommon.PrimaryHeaderPadding = New System.Windows.Forms.Padding(3)
        Me.kryptonPaletteCustom.HeaderGroup.StateCommon.SecondaryHeaderPadding = New System.Windows.Forms.Padding(3)
        Me.kryptonPaletteCustom.HeaderStyles.HeaderCommon.StateCommon.Back.ColorAlign = Krypton.Toolkit.PaletteRectangleAlign.Inherit
        Me.kryptonPaletteCustom.HeaderStyles.HeaderCommon.StateCommon.Back.ColorStyle = Krypton.Toolkit.PaletteColorStyle.Linear
        Me.kryptonPaletteCustom.HeaderStyles.HeaderCommon.StateCommon.Back.Draw = Krypton.Toolkit.InheritBool.Inherit
        Me.kryptonPaletteCustom.HeaderStyles.HeaderCommon.StateCommon.Back.GraphicsHint = Krypton.Toolkit.PaletteGraphicsHint.AntiAlias
        Me.kryptonPaletteCustom.HeaderStyles.HeaderCommon.StateCommon.Back.ImageAlign = Krypton.Toolkit.PaletteRectangleAlign.Inherit
        Me.kryptonPaletteCustom.HeaderStyles.HeaderCommon.StateCommon.Back.ImageStyle = Krypton.Toolkit.PaletteImageStyle.Inherit
        Me.kryptonPaletteCustom.HeaderStyles.HeaderCommon.StateCommon.Border.ColorAlign = Krypton.Toolkit.PaletteRectangleAlign.Inherit
        Me.kryptonPaletteCustom.HeaderStyles.HeaderCommon.StateCommon.Border.ColorStyle = Krypton.Toolkit.PaletteColorStyle.Inherit
        Me.kryptonPaletteCustom.HeaderStyles.HeaderCommon.StateCommon.Border.Draw = Krypton.Toolkit.InheritBool.False
        Me.kryptonPaletteCustom.HeaderStyles.HeaderCommon.StateCommon.Border.DrawBorders = CType((((Krypton.Toolkit.PaletteDrawBorders.Top Or Krypton.Toolkit.PaletteDrawBorders.Bottom) Or Krypton.Toolkit.PaletteDrawBorders.Left) Or Krypton.Toolkit.PaletteDrawBorders.Right), Krypton.Toolkit.PaletteDrawBorders)
        Me.kryptonPaletteCustom.HeaderStyles.HeaderCommon.StateCommon.Border.GraphicsHint = Krypton.Toolkit.PaletteGraphicsHint.Inherit
        Me.kryptonPaletteCustom.HeaderStyles.HeaderCommon.StateCommon.Border.ImageAlign = Krypton.Toolkit.PaletteRectangleAlign.Inherit
        Me.kryptonPaletteCustom.HeaderStyles.HeaderCommon.StateCommon.Border.Rounding = 7F
        Me.kryptonPaletteCustom.HeaderStyles.HeaderCommon.StateCommon.Border.Width = 3
        Me.kryptonPaletteCustom.HeaderStyles.HeaderCommon.StateCommon.ButtonPadding = New System.Windows.Forms.Padding(-1)
        Me.kryptonPaletteCustom.HeaderStyles.HeaderCommon.StateCommon.Content.AdjacentGap = 2
        Me.kryptonPaletteCustom.HeaderStyles.HeaderCommon.StateCommon.Content.Draw = Krypton.Toolkit.InheritBool.Inherit
        Me.kryptonPaletteCustom.HeaderStyles.HeaderCommon.StateCommon.Content.DrawFocus = Krypton.Toolkit.InheritBool.Inherit
        Me.kryptonPaletteCustom.HeaderStyles.HeaderCommon.StateCommon.Content.LongText.Color1 = System.Drawing.Color.Black
        Me.kryptonPaletteCustom.HeaderStyles.HeaderCommon.StateCommon.Content.LongText.ColorAlign = Krypton.Toolkit.PaletteRectangleAlign.Inherit
        Me.kryptonPaletteCustom.HeaderStyles.HeaderCommon.StateCommon.Content.LongText.ColorStyle = Krypton.Toolkit.PaletteColorStyle.Solid
        Me.kryptonPaletteCustom.HeaderStyles.HeaderCommon.StateCommon.Content.LongText.Hint = Krypton.Toolkit.PaletteTextHint.Inherit
        Me.kryptonPaletteCustom.HeaderStyles.HeaderCommon.StateCommon.Content.LongText.ImageAlign = Krypton.Toolkit.PaletteRectangleAlign.Inherit
        Me.kryptonPaletteCustom.HeaderStyles.HeaderCommon.StateCommon.Content.LongText.ImageStyle = Krypton.Toolkit.PaletteImageStyle.Inherit
        Me.kryptonPaletteCustom.HeaderStyles.HeaderCommon.StateCommon.Content.LongText.MultiLine = Krypton.Toolkit.InheritBool.Inherit
        Me.kryptonPaletteCustom.HeaderStyles.HeaderCommon.StateCommon.Content.LongText.MultiLineH = Krypton.Toolkit.PaletteRelativeAlign.Inherit
        Me.kryptonPaletteCustom.HeaderStyles.HeaderCommon.StateCommon.Content.LongText.Prefix = Krypton.Toolkit.PaletteTextHotkeyPrefix.Inherit
        Me.kryptonPaletteCustom.HeaderStyles.HeaderCommon.StateCommon.Content.LongText.TextH = Krypton.Toolkit.PaletteRelativeAlign.Far
        Me.kryptonPaletteCustom.HeaderStyles.HeaderCommon.StateCommon.Content.LongText.TextV = Krypton.Toolkit.PaletteRelativeAlign.Inherit
        Me.kryptonPaletteCustom.HeaderStyles.HeaderCommon.StateCommon.Content.LongText.Trim = Krypton.Toolkit.PaletteTextTrim.Inherit
        Me.kryptonPaletteCustom.HeaderStyles.HeaderCommon.StateCommon.Content.Padding = New System.Windows.Forms.Padding(10, 1, 10, 1)
        Me.kryptonPaletteCustom.HeaderStyles.HeaderCommon.StateCommon.Content.ShortText.Color1 = System.Drawing.Color.Black
        Me.kryptonPaletteCustom.HeaderStyles.HeaderCommon.StateCommon.Content.ShortText.ColorAlign = Krypton.Toolkit.PaletteRectangleAlign.Inherit
        Me.kryptonPaletteCustom.HeaderStyles.HeaderCommon.StateCommon.Content.ShortText.ColorStyle = Krypton.Toolkit.PaletteColorStyle.Solid
        Me.kryptonPaletteCustom.HeaderStyles.HeaderCommon.StateCommon.Content.ShortText.Hint = Krypton.Toolkit.PaletteTextHint.Inherit
        Me.kryptonPaletteCustom.HeaderStyles.HeaderCommon.StateCommon.Content.ShortText.ImageAlign = Krypton.Toolkit.PaletteRectangleAlign.Inherit
        Me.kryptonPaletteCustom.HeaderStyles.HeaderCommon.StateCommon.Content.ShortText.ImageStyle = Krypton.Toolkit.PaletteImageStyle.Inherit
        Me.kryptonPaletteCustom.HeaderStyles.HeaderCommon.StateCommon.Content.ShortText.MultiLine = Krypton.Toolkit.InheritBool.Inherit
        Me.kryptonPaletteCustom.HeaderStyles.HeaderCommon.StateCommon.Content.ShortText.MultiLineH = Krypton.Toolkit.PaletteRelativeAlign.Inherit
        Me.kryptonPaletteCustom.HeaderStyles.HeaderCommon.StateCommon.Content.ShortText.Prefix = Krypton.Toolkit.PaletteTextHotkeyPrefix.Inherit
        Me.kryptonPaletteCustom.HeaderStyles.HeaderCommon.StateCommon.Content.ShortText.TextH = Krypton.Toolkit.PaletteRelativeAlign.Near
        Me.kryptonPaletteCustom.HeaderStyles.HeaderCommon.StateCommon.Content.ShortText.TextV = Krypton.Toolkit.PaletteRelativeAlign.Inherit
        Me.kryptonPaletteCustom.HeaderStyles.HeaderCommon.StateCommon.Content.ShortText.Trim = Krypton.Toolkit.PaletteTextTrim.Inherit
        Me.kryptonPaletteCustom.HeaderStyles.HeaderCommon.StateDisabled.Content.Draw = Krypton.Toolkit.InheritBool.Inherit
        Me.kryptonPaletteCustom.HeaderStyles.HeaderCommon.StateDisabled.Content.DrawFocus = Krypton.Toolkit.InheritBool.Inherit
        Me.kryptonPaletteCustom.HeaderStyles.HeaderCommon.StateDisabled.Content.LongText.Color1 = System.Drawing.Color.Silver
        Me.kryptonPaletteCustom.HeaderStyles.HeaderCommon.StateDisabled.Content.LongText.ColorAlign = Krypton.Toolkit.PaletteRectangleAlign.Inherit
        Me.kryptonPaletteCustom.HeaderStyles.HeaderCommon.StateDisabled.Content.LongText.ColorStyle = Krypton.Toolkit.PaletteColorStyle.Inherit
        Me.kryptonPaletteCustom.HeaderStyles.HeaderCommon.StateDisabled.Content.LongText.Hint = Krypton.Toolkit.PaletteTextHint.Inherit
        Me.kryptonPaletteCustom.HeaderStyles.HeaderCommon.StateDisabled.Content.LongText.ImageAlign = Krypton.Toolkit.PaletteRectangleAlign.Inherit
        Me.kryptonPaletteCustom.HeaderStyles.HeaderCommon.StateDisabled.Content.LongText.ImageStyle = Krypton.Toolkit.PaletteImageStyle.Inherit
        Me.kryptonPaletteCustom.HeaderStyles.HeaderCommon.StateDisabled.Content.LongText.MultiLine = Krypton.Toolkit.InheritBool.Inherit
        Me.kryptonPaletteCustom.HeaderStyles.HeaderCommon.StateDisabled.Content.LongText.MultiLineH = Krypton.Toolkit.PaletteRelativeAlign.Inherit
        Me.kryptonPaletteCustom.HeaderStyles.HeaderCommon.StateDisabled.Content.LongText.Prefix = Krypton.Toolkit.PaletteTextHotkeyPrefix.Inherit
        Me.kryptonPaletteCustom.HeaderStyles.HeaderCommon.StateDisabled.Content.LongText.TextH = Krypton.Toolkit.PaletteRelativeAlign.Inherit
        Me.kryptonPaletteCustom.HeaderStyles.HeaderCommon.StateDisabled.Content.LongText.TextV = Krypton.Toolkit.PaletteRelativeAlign.Inherit
        Me.kryptonPaletteCustom.HeaderStyles.HeaderCommon.StateDisabled.Content.LongText.Trim = Krypton.Toolkit.PaletteTextTrim.Inherit
        Me.kryptonPaletteCustom.HeaderStyles.HeaderCommon.StateDisabled.Content.Padding = New System.Windows.Forms.Padding(-1)
        Me.kryptonPaletteCustom.HeaderStyles.HeaderCommon.StateDisabled.Content.ShortText.Color1 = System.Drawing.Color.Silver
        Me.kryptonPaletteCustom.HeaderStyles.HeaderCommon.StateDisabled.Content.ShortText.ColorAlign = Krypton.Toolkit.PaletteRectangleAlign.Inherit
        Me.kryptonPaletteCustom.HeaderStyles.HeaderCommon.StateDisabled.Content.ShortText.ColorStyle = Krypton.Toolkit.PaletteColorStyle.Inherit
        Me.kryptonPaletteCustom.HeaderStyles.HeaderCommon.StateDisabled.Content.ShortText.Hint = Krypton.Toolkit.PaletteTextHint.Inherit
        Me.kryptonPaletteCustom.HeaderStyles.HeaderCommon.StateDisabled.Content.ShortText.ImageAlign = Krypton.Toolkit.PaletteRectangleAlign.Inherit
        Me.kryptonPaletteCustom.HeaderStyles.HeaderCommon.StateDisabled.Content.ShortText.ImageStyle = Krypton.Toolkit.PaletteImageStyle.Inherit
        Me.kryptonPaletteCustom.HeaderStyles.HeaderCommon.StateDisabled.Content.ShortText.MultiLine = Krypton.Toolkit.InheritBool.Inherit
        Me.kryptonPaletteCustom.HeaderStyles.HeaderCommon.StateDisabled.Content.ShortText.MultiLineH = Krypton.Toolkit.PaletteRelativeAlign.Inherit
        Me.kryptonPaletteCustom.HeaderStyles.HeaderCommon.StateDisabled.Content.ShortText.Prefix = Krypton.Toolkit.PaletteTextHotkeyPrefix.Inherit
        Me.kryptonPaletteCustom.HeaderStyles.HeaderCommon.StateDisabled.Content.ShortText.TextH = Krypton.Toolkit.PaletteRelativeAlign.Inherit
        Me.kryptonPaletteCustom.HeaderStyles.HeaderCommon.StateDisabled.Content.ShortText.TextV = Krypton.Toolkit.PaletteRelativeAlign.Inherit
        Me.kryptonPaletteCustom.HeaderStyles.HeaderCommon.StateDisabled.Content.ShortText.Trim = Krypton.Toolkit.PaletteTextTrim.Inherit
        Me.kryptonPaletteCustom.HeaderStyles.HeaderCustom1.StateDisabled.Back.Color1 = System.Drawing.Color.FromArgb(CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer))
        Me.kryptonPaletteCustom.HeaderStyles.HeaderCustom1.StateDisabled.Back.Color2 = System.Drawing.Color.White
        Me.kryptonPaletteCustom.HeaderStyles.HeaderCustom1.StateDisabled.Back.ColorAlign = Krypton.Toolkit.PaletteRectangleAlign.Inherit
        Me.kryptonPaletteCustom.HeaderStyles.HeaderCustom1.StateDisabled.Back.ColorStyle = Krypton.Toolkit.PaletteColorStyle.Inherit
        Me.kryptonPaletteCustom.HeaderStyles.HeaderCustom1.StateDisabled.Back.Draw = Krypton.Toolkit.InheritBool.Inherit
        Me.kryptonPaletteCustom.HeaderStyles.HeaderCustom1.StateDisabled.Back.GraphicsHint = Krypton.Toolkit.PaletteGraphicsHint.Inherit
        Me.kryptonPaletteCustom.HeaderStyles.HeaderCustom1.StateDisabled.Back.ImageAlign = Krypton.Toolkit.PaletteRectangleAlign.Inherit
        Me.kryptonPaletteCustom.HeaderStyles.HeaderCustom1.StateDisabled.Back.ImageStyle = Krypton.Toolkit.PaletteImageStyle.Inherit
        Me.kryptonPaletteCustom.HeaderStyles.HeaderCustom1.StateNormal.Back.Color1 = System.Drawing.Color.FromArgb(CType(CType(226, Byte), Integer), CType(CType(213, Byte), Integer), CType(CType(194, Byte), Integer))
        Me.kryptonPaletteCustom.HeaderStyles.HeaderCustom1.StateNormal.Back.Color2 = System.Drawing.Color.White
        Me.kryptonPaletteCustom.HeaderStyles.HeaderCustom1.StateNormal.Back.ColorAlign = Krypton.Toolkit.PaletteRectangleAlign.Inherit
        Me.kryptonPaletteCustom.HeaderStyles.HeaderCustom1.StateNormal.Back.ColorStyle = Krypton.Toolkit.PaletteColorStyle.Inherit
        Me.kryptonPaletteCustom.HeaderStyles.HeaderCustom1.StateNormal.Back.Draw = Krypton.Toolkit.InheritBool.Inherit
        Me.kryptonPaletteCustom.HeaderStyles.HeaderCustom1.StateNormal.Back.GraphicsHint = Krypton.Toolkit.PaletteGraphicsHint.Inherit
        Me.kryptonPaletteCustom.HeaderStyles.HeaderCustom1.StateNormal.Back.ImageAlign = Krypton.Toolkit.PaletteRectangleAlign.Inherit
        Me.kryptonPaletteCustom.HeaderStyles.HeaderCustom1.StateNormal.Back.ImageStyle = Krypton.Toolkit.PaletteImageStyle.Inherit
        Me.kryptonPaletteCustom.HeaderStyles.HeaderCustom2.StateDisabled.Back.Color1 = System.Drawing.Color.White
        Me.kryptonPaletteCustom.HeaderStyles.HeaderCustom2.StateDisabled.Back.Color2 = System.Drawing.Color.FromArgb(CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer))
        Me.kryptonPaletteCustom.HeaderStyles.HeaderCustom2.StateDisabled.Back.ColorAlign = Krypton.Toolkit.PaletteRectangleAlign.Inherit
        Me.kryptonPaletteCustom.HeaderStyles.HeaderCustom2.StateDisabled.Back.ColorStyle = Krypton.Toolkit.PaletteColorStyle.Inherit
        Me.kryptonPaletteCustom.HeaderStyles.HeaderCustom2.StateDisabled.Back.Draw = Krypton.Toolkit.InheritBool.Inherit
        Me.kryptonPaletteCustom.HeaderStyles.HeaderCustom2.StateDisabled.Back.GraphicsHint = Krypton.Toolkit.PaletteGraphicsHint.Inherit
        Me.kryptonPaletteCustom.HeaderStyles.HeaderCustom2.StateDisabled.Back.ImageAlign = Krypton.Toolkit.PaletteRectangleAlign.Inherit
        Me.kryptonPaletteCustom.HeaderStyles.HeaderCustom2.StateDisabled.Back.ImageStyle = Krypton.Toolkit.PaletteImageStyle.Inherit
        Me.kryptonPaletteCustom.HeaderStyles.HeaderCustom2.StateNormal.Back.Color1 = System.Drawing.Color.White
        Me.kryptonPaletteCustom.HeaderStyles.HeaderCustom2.StateNormal.Back.Color2 = System.Drawing.Color.FromArgb(CType(CType(226, Byte), Integer), CType(CType(213, Byte), Integer), CType(CType(194, Byte), Integer))
        Me.kryptonPaletteCustom.HeaderStyles.HeaderCustom2.StateNormal.Back.ColorAlign = Krypton.Toolkit.PaletteRectangleAlign.Inherit
        Me.kryptonPaletteCustom.HeaderStyles.HeaderCustom2.StateNormal.Back.ColorStyle = Krypton.Toolkit.PaletteColorStyle.Inherit
        Me.kryptonPaletteCustom.HeaderStyles.HeaderCustom2.StateNormal.Back.Draw = Krypton.Toolkit.InheritBool.Inherit
        Me.kryptonPaletteCustom.HeaderStyles.HeaderCustom2.StateNormal.Back.GraphicsHint = Krypton.Toolkit.PaletteGraphicsHint.Inherit
        Me.kryptonPaletteCustom.HeaderStyles.HeaderCustom2.StateNormal.Back.ImageAlign = Krypton.Toolkit.PaletteRectangleAlign.Inherit
        Me.kryptonPaletteCustom.HeaderStyles.HeaderCustom2.StateNormal.Back.ImageStyle = Krypton.Toolkit.PaletteImageStyle.Inherit
        Me.kryptonPaletteCustom.HeaderStyles.HeaderPrimary.StateDisabled.Back.Color1 = System.Drawing.Color.FromArgb(CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer))
        Me.kryptonPaletteCustom.HeaderStyles.HeaderPrimary.StateDisabled.Back.Color2 = System.Drawing.Color.White
        Me.kryptonPaletteCustom.HeaderStyles.HeaderPrimary.StateDisabled.Back.ColorAlign = Krypton.Toolkit.PaletteRectangleAlign.Inherit
        Me.kryptonPaletteCustom.HeaderStyles.HeaderPrimary.StateDisabled.Back.ColorStyle = Krypton.Toolkit.PaletteColorStyle.Inherit
        Me.kryptonPaletteCustom.HeaderStyles.HeaderPrimary.StateDisabled.Back.Draw = Krypton.Toolkit.InheritBool.Inherit
        Me.kryptonPaletteCustom.HeaderStyles.HeaderPrimary.StateDisabled.Back.GraphicsHint = Krypton.Toolkit.PaletteGraphicsHint.Inherit
        Me.kryptonPaletteCustom.HeaderStyles.HeaderPrimary.StateDisabled.Back.ImageAlign = Krypton.Toolkit.PaletteRectangleAlign.Inherit
        Me.kryptonPaletteCustom.HeaderStyles.HeaderPrimary.StateDisabled.Back.ImageStyle = Krypton.Toolkit.PaletteImageStyle.Inherit
        Me.kryptonPaletteCustom.HeaderStyles.HeaderPrimary.StateNormal.Back.Color1 = System.Drawing.Color.FromArgb(CType(CType(226, Byte), Integer), CType(CType(213, Byte), Integer), CType(CType(194, Byte), Integer))
        Me.kryptonPaletteCustom.HeaderStyles.HeaderPrimary.StateNormal.Back.Color2 = System.Drawing.Color.White
        Me.kryptonPaletteCustom.HeaderStyles.HeaderPrimary.StateNormal.Back.ColorAlign = Krypton.Toolkit.PaletteRectangleAlign.Inherit
        Me.kryptonPaletteCustom.HeaderStyles.HeaderPrimary.StateNormal.Back.ColorStyle = Krypton.Toolkit.PaletteColorStyle.Inherit
        Me.kryptonPaletteCustom.HeaderStyles.HeaderPrimary.StateNormal.Back.Draw = Krypton.Toolkit.InheritBool.Inherit
        Me.kryptonPaletteCustom.HeaderStyles.HeaderPrimary.StateNormal.Back.GraphicsHint = Krypton.Toolkit.PaletteGraphicsHint.Inherit
        Me.kryptonPaletteCustom.HeaderStyles.HeaderPrimary.StateNormal.Back.ImageAlign = Krypton.Toolkit.PaletteRectangleAlign.Inherit
        Me.kryptonPaletteCustom.HeaderStyles.HeaderPrimary.StateNormal.Back.ImageStyle = Krypton.Toolkit.PaletteImageStyle.Inherit
        Me.kryptonPaletteCustom.HeaderStyles.HeaderSecondary.StateDisabled.Back.Color1 = System.Drawing.Color.White
        Me.kryptonPaletteCustom.HeaderStyles.HeaderSecondary.StateDisabled.Back.Color2 = System.Drawing.Color.FromArgb(CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer))
        Me.kryptonPaletteCustom.HeaderStyles.HeaderSecondary.StateDisabled.Back.ColorAlign = Krypton.Toolkit.PaletteRectangleAlign.Inherit
        Me.kryptonPaletteCustom.HeaderStyles.HeaderSecondary.StateDisabled.Back.ColorStyle = Krypton.Toolkit.PaletteColorStyle.Inherit
        Me.kryptonPaletteCustom.HeaderStyles.HeaderSecondary.StateDisabled.Back.Draw = Krypton.Toolkit.InheritBool.Inherit
        Me.kryptonPaletteCustom.HeaderStyles.HeaderSecondary.StateDisabled.Back.GraphicsHint = Krypton.Toolkit.PaletteGraphicsHint.Inherit
        Me.kryptonPaletteCustom.HeaderStyles.HeaderSecondary.StateDisabled.Back.ImageAlign = Krypton.Toolkit.PaletteRectangleAlign.Inherit
        Me.kryptonPaletteCustom.HeaderStyles.HeaderSecondary.StateDisabled.Back.ImageStyle = Krypton.Toolkit.PaletteImageStyle.Inherit
        Me.kryptonPaletteCustom.HeaderStyles.HeaderSecondary.StateNormal.Back.Color1 = System.Drawing.Color.White
        Me.kryptonPaletteCustom.HeaderStyles.HeaderSecondary.StateNormal.Back.Color2 = System.Drawing.Color.FromArgb(CType(CType(226, Byte), Integer), CType(CType(213, Byte), Integer), CType(CType(194, Byte), Integer))
        Me.kryptonPaletteCustom.HeaderStyles.HeaderSecondary.StateNormal.Back.ColorAlign = Krypton.Toolkit.PaletteRectangleAlign.Inherit
        Me.kryptonPaletteCustom.HeaderStyles.HeaderSecondary.StateNormal.Back.ColorStyle = Krypton.Toolkit.PaletteColorStyle.Inherit
        Me.kryptonPaletteCustom.HeaderStyles.HeaderSecondary.StateNormal.Back.Draw = Krypton.Toolkit.InheritBool.Inherit
        Me.kryptonPaletteCustom.HeaderStyles.HeaderSecondary.StateNormal.Back.GraphicsHint = Krypton.Toolkit.PaletteGraphicsHint.Inherit
        Me.kryptonPaletteCustom.HeaderStyles.HeaderSecondary.StateNormal.Back.ImageAlign = Krypton.Toolkit.PaletteRectangleAlign.Inherit
        Me.kryptonPaletteCustom.HeaderStyles.HeaderSecondary.StateNormal.Back.ImageStyle = Krypton.Toolkit.PaletteImageStyle.Inherit
        Me.kryptonPaletteCustom.PanelStyles.PanelAlternate.StateCommon.Color1 = System.Drawing.Color.FromArgb(CType(CType(225, Byte), Integer), CType(CType(212, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.kryptonPaletteCustom.PanelStyles.PanelAlternate.StateCommon.ColorAlign = Krypton.Toolkit.PaletteRectangleAlign.Inherit
        Me.kryptonPaletteCustom.PanelStyles.PanelAlternate.StateCommon.ColorStyle = Krypton.Toolkit.PaletteColorStyle.Inherit
        Me.kryptonPaletteCustom.PanelStyles.PanelAlternate.StateCommon.Draw = Krypton.Toolkit.InheritBool.Inherit
        Me.kryptonPaletteCustom.PanelStyles.PanelAlternate.StateCommon.GraphicsHint = Krypton.Toolkit.PaletteGraphicsHint.Inherit
        Me.kryptonPaletteCustom.PanelStyles.PanelAlternate.StateCommon.ImageAlign = Krypton.Toolkit.PaletteRectangleAlign.Inherit
        Me.kryptonPaletteCustom.PanelStyles.PanelAlternate.StateCommon.ImageStyle = Krypton.Toolkit.PaletteImageStyle.Inherit
        Me.kryptonPaletteCustom.PanelStyles.PanelClient.StateCommon.Color1 = System.Drawing.Color.FromArgb(CType(CType(245, Byte), Integer), CType(CType(237, Byte), Integer), CType(CType(227, Byte), Integer))
        Me.kryptonPaletteCustom.PanelStyles.PanelClient.StateCommon.ColorAlign = Krypton.Toolkit.PaletteRectangleAlign.Inherit
        Me.kryptonPaletteCustom.PanelStyles.PanelClient.StateCommon.ColorStyle = Krypton.Toolkit.PaletteColorStyle.Inherit
        Me.kryptonPaletteCustom.PanelStyles.PanelClient.StateCommon.Draw = Krypton.Toolkit.InheritBool.Inherit
        Me.kryptonPaletteCustom.PanelStyles.PanelClient.StateCommon.GraphicsHint = Krypton.Toolkit.PaletteGraphicsHint.Inherit
        Me.kryptonPaletteCustom.PanelStyles.PanelClient.StateCommon.ImageAlign = Krypton.Toolkit.PaletteRectangleAlign.Inherit
        Me.kryptonPaletteCustom.PanelStyles.PanelClient.StateCommon.ImageStyle = Krypton.Toolkit.PaletteImageStyle.Inherit
        Me.kryptonPaletteCustom.PanelStyles.PanelCommon.StateCommon.ColorAlign = Krypton.Toolkit.PaletteRectangleAlign.Inherit
        Me.kryptonPaletteCustom.PanelStyles.PanelCommon.StateCommon.ColorStyle = Krypton.Toolkit.PaletteColorStyle.Solid
        Me.kryptonPaletteCustom.PanelStyles.PanelCommon.StateCommon.Draw = Krypton.Toolkit.InheritBool.Inherit
        Me.kryptonPaletteCustom.PanelStyles.PanelCommon.StateCommon.GraphicsHint = Krypton.Toolkit.PaletteGraphicsHint.Inherit
        Me.kryptonPaletteCustom.PanelStyles.PanelCommon.StateCommon.ImageAlign = Krypton.Toolkit.PaletteRectangleAlign.Inherit
        Me.kryptonPaletteCustom.PanelStyles.PanelCommon.StateCommon.ImageStyle = Krypton.Toolkit.PaletteImageStyle.Inherit
        Me.kryptonPaletteCustom.PanelStyles.PanelCustom1.StateCommon.Color1 = System.Drawing.Color.FromArgb(CType(CType(245, Byte), Integer), CType(CType(237, Byte), Integer), CType(CType(227, Byte), Integer))
        Me.kryptonPaletteCustom.PanelStyles.PanelCustom1.StateCommon.ColorAlign = Krypton.Toolkit.PaletteRectangleAlign.Inherit
        Me.kryptonPaletteCustom.PanelStyles.PanelCustom1.StateCommon.ColorStyle = Krypton.Toolkit.PaletteColorStyle.Inherit
        Me.kryptonPaletteCustom.PanelStyles.PanelCustom1.StateCommon.Draw = Krypton.Toolkit.InheritBool.Inherit
        Me.kryptonPaletteCustom.PanelStyles.PanelCustom1.StateCommon.GraphicsHint = Krypton.Toolkit.PaletteGraphicsHint.Inherit
        Me.kryptonPaletteCustom.PanelStyles.PanelCustom1.StateCommon.ImageAlign = Krypton.Toolkit.PaletteRectangleAlign.Inherit
        Me.kryptonPaletteCustom.PanelStyles.PanelCustom1.StateCommon.ImageStyle = Krypton.Toolkit.PaletteImageStyle.Inherit
        Me.kryptonPaletteCustom.TabStyles.TabCommon.StateCommon.Back.ColorAlign = Krypton.Toolkit.PaletteRectangleAlign.Inherit
        Me.kryptonPaletteCustom.TabStyles.TabCommon.StateCommon.Back.ColorStyle = Krypton.Toolkit.PaletteColorStyle.Solid
        Me.kryptonPaletteCustom.TabStyles.TabCommon.StateCommon.Back.Draw = Krypton.Toolkit.InheritBool.Inherit
        Me.kryptonPaletteCustom.TabStyles.TabCommon.StateCommon.Back.GraphicsHint = Krypton.Toolkit.PaletteGraphicsHint.Inherit
        Me.kryptonPaletteCustom.TabStyles.TabCommon.StateCommon.Back.ImageAlign = Krypton.Toolkit.PaletteRectangleAlign.Inherit
        Me.kryptonPaletteCustom.TabStyles.TabCommon.StateCommon.Back.ImageStyle = Krypton.Toolkit.PaletteImageStyle.Inherit
        Me.kryptonPaletteCustom.TabStyles.TabCommon.StateCommon.Border.ColorAlign = Krypton.Toolkit.PaletteRectangleAlign.Inherit
        Me.kryptonPaletteCustom.TabStyles.TabCommon.StateCommon.Border.ColorStyle = Krypton.Toolkit.PaletteColorStyle.Inherit
        Me.kryptonPaletteCustom.TabStyles.TabCommon.StateCommon.Border.Draw = Krypton.Toolkit.InheritBool.Inherit
        Me.kryptonPaletteCustom.TabStyles.TabCommon.StateCommon.Border.DrawBorders = CType((((Krypton.Toolkit.PaletteDrawBorders.Top Or Krypton.Toolkit.PaletteDrawBorders.Bottom) Or Krypton.Toolkit.PaletteDrawBorders.Left) Or Krypton.Toolkit.PaletteDrawBorders.Right), Krypton.Toolkit.PaletteDrawBorders)
        Me.kryptonPaletteCustom.TabStyles.TabCommon.StateCommon.Border.GraphicsHint = Krypton.Toolkit.PaletteGraphicsHint.Inherit
        Me.kryptonPaletteCustom.TabStyles.TabCommon.StateCommon.Border.ImageAlign = Krypton.Toolkit.PaletteRectangleAlign.Inherit
        Me.kryptonPaletteCustom.TabStyles.TabCommon.StateCommon.Border.Width = 2
        Me.kryptonPaletteCustom.TabStyles.TabCommon.StateCommon.Content.Draw = Krypton.Toolkit.InheritBool.Inherit
        Me.kryptonPaletteCustom.TabStyles.TabCommon.StateCommon.Content.DrawFocus = Krypton.Toolkit.InheritBool.Inherit
        Me.kryptonPaletteCustom.TabStyles.TabCommon.StateCommon.Content.LongText.Color1 = System.Drawing.Color.White
        Me.kryptonPaletteCustom.TabStyles.TabCommon.StateCommon.Content.LongText.ColorAlign = Krypton.Toolkit.PaletteRectangleAlign.Inherit
        Me.kryptonPaletteCustom.TabStyles.TabCommon.StateCommon.Content.LongText.ColorStyle = Krypton.Toolkit.PaletteColorStyle.Solid
        Me.kryptonPaletteCustom.TabStyles.TabCommon.StateCommon.Content.LongText.Hint = Krypton.Toolkit.PaletteTextHint.Inherit
        Me.kryptonPaletteCustom.TabStyles.TabCommon.StateCommon.Content.LongText.ImageAlign = Krypton.Toolkit.PaletteRectangleAlign.Inherit
        Me.kryptonPaletteCustom.TabStyles.TabCommon.StateCommon.Content.LongText.ImageStyle = Krypton.Toolkit.PaletteImageStyle.Inherit
        Me.kryptonPaletteCustom.TabStyles.TabCommon.StateCommon.Content.LongText.MultiLine = Krypton.Toolkit.InheritBool.Inherit
        Me.kryptonPaletteCustom.TabStyles.TabCommon.StateCommon.Content.LongText.MultiLineH = Krypton.Toolkit.PaletteRelativeAlign.Inherit
        Me.kryptonPaletteCustom.TabStyles.TabCommon.StateCommon.Content.LongText.Prefix = Krypton.Toolkit.PaletteTextHotkeyPrefix.Inherit
        Me.kryptonPaletteCustom.TabStyles.TabCommon.StateCommon.Content.LongText.TextH = Krypton.Toolkit.PaletteRelativeAlign.Inherit
        Me.kryptonPaletteCustom.TabStyles.TabCommon.StateCommon.Content.LongText.TextV = Krypton.Toolkit.PaletteRelativeAlign.Inherit
        Me.kryptonPaletteCustom.TabStyles.TabCommon.StateCommon.Content.LongText.Trim = Krypton.Toolkit.PaletteTextTrim.Inherit
        Me.kryptonPaletteCustom.TabStyles.TabCommon.StateCommon.Content.Padding = New System.Windows.Forms.Padding(3, 5, 3, 5)
        Me.kryptonPaletteCustom.TabStyles.TabCommon.StateCommon.Content.ShortText.Color1 = System.Drawing.Color.White
        Me.kryptonPaletteCustom.TabStyles.TabCommon.StateCommon.Content.ShortText.ColorAlign = Krypton.Toolkit.PaletteRectangleAlign.Inherit
        Me.kryptonPaletteCustom.TabStyles.TabCommon.StateCommon.Content.ShortText.ColorStyle = Krypton.Toolkit.PaletteColorStyle.Solid
        Me.kryptonPaletteCustom.TabStyles.TabCommon.StateCommon.Content.ShortText.Hint = Krypton.Toolkit.PaletteTextHint.Inherit
        Me.kryptonPaletteCustom.TabStyles.TabCommon.StateCommon.Content.ShortText.ImageAlign = Krypton.Toolkit.PaletteRectangleAlign.Inherit
        Me.kryptonPaletteCustom.TabStyles.TabCommon.StateCommon.Content.ShortText.ImageStyle = Krypton.Toolkit.PaletteImageStyle.Inherit
        Me.kryptonPaletteCustom.TabStyles.TabCommon.StateCommon.Content.ShortText.MultiLine = Krypton.Toolkit.InheritBool.Inherit
        Me.kryptonPaletteCustom.TabStyles.TabCommon.StateCommon.Content.ShortText.MultiLineH = Krypton.Toolkit.PaletteRelativeAlign.Inherit
        Me.kryptonPaletteCustom.TabStyles.TabCommon.StateCommon.Content.ShortText.Prefix = Krypton.Toolkit.PaletteTextHotkeyPrefix.Inherit
        Me.kryptonPaletteCustom.TabStyles.TabCommon.StateCommon.Content.ShortText.TextH = Krypton.Toolkit.PaletteRelativeAlign.Inherit
        Me.kryptonPaletteCustom.TabStyles.TabCommon.StateCommon.Content.ShortText.TextV = Krypton.Toolkit.PaletteRelativeAlign.Inherit
        Me.kryptonPaletteCustom.TabStyles.TabCommon.StateCommon.Content.ShortText.Trim = Krypton.Toolkit.PaletteTextTrim.Inherit
        Me.kryptonPaletteCustom.TabStyles.TabCommon.StateNormal.Back.Color1 = System.Drawing.Color.FromArgb(CType(CType(51, Byte), Integer), CType(CType(102, Byte), Integer), CType(CType(204, Byte), Integer))
        Me.kryptonPaletteCustom.TabStyles.TabCommon.StateNormal.Back.Color2 = System.Drawing.Color.FromArgb(CType(CType(51, Byte), Integer), CType(CType(102, Byte), Integer), CType(CType(204, Byte), Integer))
        Me.kryptonPaletteCustom.TabStyles.TabCommon.StateNormal.Back.ColorAlign = Krypton.Toolkit.PaletteRectangleAlign.Inherit
        Me.kryptonPaletteCustom.TabStyles.TabCommon.StateNormal.Back.ColorStyle = Krypton.Toolkit.PaletteColorStyle.Solid
        Me.kryptonPaletteCustom.TabStyles.TabCommon.StateNormal.Back.Draw = Krypton.Toolkit.InheritBool.Inherit
        Me.kryptonPaletteCustom.TabStyles.TabCommon.StateNormal.Back.GraphicsHint = Krypton.Toolkit.PaletteGraphicsHint.Inherit
        Me.kryptonPaletteCustom.TabStyles.TabCommon.StateNormal.Back.ImageAlign = Krypton.Toolkit.PaletteRectangleAlign.Inherit
        Me.kryptonPaletteCustom.TabStyles.TabCommon.StateNormal.Back.ImageStyle = Krypton.Toolkit.PaletteImageStyle.Inherit
        Me.kryptonPaletteCustom.TabStyles.TabCommon.StatePressed.Back.Color1 = System.Drawing.Color.FromArgb(CType(CType(102, Byte), Integer), CType(CType(153, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.kryptonPaletteCustom.TabStyles.TabCommon.StatePressed.Back.Color2 = System.Drawing.Color.FromArgb(CType(CType(102, Byte), Integer), CType(CType(153, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.kryptonPaletteCustom.TabStyles.TabCommon.StatePressed.Back.ColorAlign = Krypton.Toolkit.PaletteRectangleAlign.Inherit
        Me.kryptonPaletteCustom.TabStyles.TabCommon.StatePressed.Back.ColorStyle = Krypton.Toolkit.PaletteColorStyle.Solid
        Me.kryptonPaletteCustom.TabStyles.TabCommon.StatePressed.Back.Draw = Krypton.Toolkit.InheritBool.Inherit
        Me.kryptonPaletteCustom.TabStyles.TabCommon.StatePressed.Back.GraphicsHint = Krypton.Toolkit.PaletteGraphicsHint.Inherit
        Me.kryptonPaletteCustom.TabStyles.TabCommon.StatePressed.Back.ImageAlign = Krypton.Toolkit.PaletteRectangleAlign.Inherit
        Me.kryptonPaletteCustom.TabStyles.TabCommon.StatePressed.Back.ImageStyle = Krypton.Toolkit.PaletteImageStyle.Inherit
        Me.kryptonPaletteCustom.TabStyles.TabCommon.StatePressed.Content.Draw = Krypton.Toolkit.InheritBool.Inherit
        Me.kryptonPaletteCustom.TabStyles.TabCommon.StatePressed.Content.DrawFocus = Krypton.Toolkit.InheritBool.Inherit
        Me.kryptonPaletteCustom.TabStyles.TabCommon.StatePressed.Content.Padding = New System.Windows.Forms.Padding(4, 6, 2, 4)
        Me.kryptonPaletteCustom.TabStyles.TabCommon.StateSelected.Back.Color1 = System.Drawing.Color.White
        Me.kryptonPaletteCustom.TabStyles.TabCommon.StateSelected.Back.Color2 = System.Drawing.Color.FromArgb(CType(CType(192, Byte), Integer), CType(CType(64, Byte), Integer), CType(CType(0, Byte), Integer))
        Me.kryptonPaletteCustom.TabStyles.TabCommon.StateSelected.Back.ColorAlign = Krypton.Toolkit.PaletteRectangleAlign.Inherit
        Me.kryptonPaletteCustom.TabStyles.TabCommon.StateSelected.Back.ColorStyle = Krypton.Toolkit.PaletteColorStyle.QuarterPhase
        Me.kryptonPaletteCustom.TabStyles.TabCommon.StateSelected.Back.Draw = Krypton.Toolkit.InheritBool.Inherit
        Me.kryptonPaletteCustom.TabStyles.TabCommon.StateSelected.Back.GraphicsHint = Krypton.Toolkit.PaletteGraphicsHint.Inherit
        Me.kryptonPaletteCustom.TabStyles.TabCommon.StateSelected.Back.ImageAlign = Krypton.Toolkit.PaletteRectangleAlign.Inherit
        Me.kryptonPaletteCustom.TabStyles.TabCommon.StateSelected.Back.ImageStyle = Krypton.Toolkit.PaletteImageStyle.Inherit
        Me.kryptonPaletteCustom.TabStyles.TabCommon.StateSelected.Border.Color1 = System.Drawing.Color.FromArgb(CType(CType(192, Byte), Integer), CType(CType(64, Byte), Integer), CType(CType(0, Byte), Integer))
        Me.kryptonPaletteCustom.TabStyles.TabCommon.StateSelected.Border.ColorAlign = Krypton.Toolkit.PaletteRectangleAlign.Inherit
        Me.kryptonPaletteCustom.TabStyles.TabCommon.StateSelected.Border.ColorStyle = Krypton.Toolkit.PaletteColorStyle.Inherit
        Me.kryptonPaletteCustom.TabStyles.TabCommon.StateSelected.Border.Draw = Krypton.Toolkit.InheritBool.Inherit
        Me.kryptonPaletteCustom.TabStyles.TabCommon.StateSelected.Border.DrawBorders = CType((((Krypton.Toolkit.PaletteDrawBorders.Top Or Krypton.Toolkit.PaletteDrawBorders.Bottom) Or Krypton.Toolkit.PaletteDrawBorders.Left) Or Krypton.Toolkit.PaletteDrawBorders.Right), Krypton.Toolkit.PaletteDrawBorders)
        Me.kryptonPaletteCustom.TabStyles.TabCommon.StateSelected.Border.GraphicsHint = Krypton.Toolkit.PaletteGraphicsHint.Inherit
        Me.kryptonPaletteCustom.TabStyles.TabCommon.StateSelected.Border.ImageAlign = Krypton.Toolkit.PaletteRectangleAlign.Inherit
        Me.kryptonPaletteCustom.TabStyles.TabCommon.StateTracking.Back.Color1 = System.Drawing.Color.FromArgb(CType(CType(102, Byte), Integer), CType(CType(153, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.kryptonPaletteCustom.TabStyles.TabCommon.StateTracking.Back.Color2 = System.Drawing.Color.FromArgb(CType(CType(102, Byte), Integer), CType(CType(153, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.kryptonPaletteCustom.TabStyles.TabCommon.StateTracking.Back.ColorAlign = Krypton.Toolkit.PaletteRectangleAlign.Inherit
        Me.kryptonPaletteCustom.TabStyles.TabCommon.StateTracking.Back.ColorStyle = Krypton.Toolkit.PaletteColorStyle.Solid
        Me.kryptonPaletteCustom.TabStyles.TabCommon.StateTracking.Back.Draw = Krypton.Toolkit.InheritBool.Inherit
        Me.kryptonPaletteCustom.TabStyles.TabCommon.StateTracking.Back.GraphicsHint = Krypton.Toolkit.PaletteGraphicsHint.Inherit
        Me.kryptonPaletteCustom.TabStyles.TabCommon.StateTracking.Back.ImageAlign = Krypton.Toolkit.PaletteRectangleAlign.Inherit
        Me.kryptonPaletteCustom.TabStyles.TabCommon.StateTracking.Back.ImageStyle = Krypton.Toolkit.PaletteImageStyle.Inherit
        Me.kryptonPaletteCustom.TabStyles.TabLowProfile.StateCommon.Content.Draw = Krypton.Toolkit.InheritBool.Inherit
        Me.kryptonPaletteCustom.TabStyles.TabLowProfile.StateCommon.Content.DrawFocus = Krypton.Toolkit.InheritBool.Inherit
        Me.kryptonPaletteCustom.TabStyles.TabLowProfile.StateCommon.Content.Padding = New System.Windows.Forms.Padding(3, 5, 3, 5)
        Me.kryptonPaletteCustom.TabStyles.TabLowProfile.StateNormal.Back.ColorAlign = Krypton.Toolkit.PaletteRectangleAlign.Inherit
        Me.kryptonPaletteCustom.TabStyles.TabLowProfile.StateNormal.Back.ColorStyle = Krypton.Toolkit.PaletteColorStyle.Inherit
        Me.kryptonPaletteCustom.TabStyles.TabLowProfile.StateNormal.Back.Draw = Krypton.Toolkit.InheritBool.False
        Me.kryptonPaletteCustom.TabStyles.TabLowProfile.StateNormal.Back.GraphicsHint = Krypton.Toolkit.PaletteGraphicsHint.Inherit
        Me.kryptonPaletteCustom.TabStyles.TabLowProfile.StateNormal.Back.ImageAlign = Krypton.Toolkit.PaletteRectangleAlign.Inherit
        Me.kryptonPaletteCustom.TabStyles.TabLowProfile.StateNormal.Back.ImageStyle = Krypton.Toolkit.PaletteImageStyle.Inherit
        Me.kryptonPaletteCustom.TabStyles.TabLowProfile.StateNormal.Content.Draw = Krypton.Toolkit.InheritBool.Inherit
        Me.kryptonPaletteCustom.TabStyles.TabLowProfile.StateNormal.Content.DrawFocus = Krypton.Toolkit.InheritBool.Inherit
        Me.kryptonPaletteCustom.TabStyles.TabLowProfile.StateNormal.Content.LongText.Color1 = System.Drawing.Color.Black
        Me.kryptonPaletteCustom.TabStyles.TabLowProfile.StateNormal.Content.LongText.ColorAlign = Krypton.Toolkit.PaletteRectangleAlign.Inherit
        Me.kryptonPaletteCustom.TabStyles.TabLowProfile.StateNormal.Content.LongText.ColorStyle = Krypton.Toolkit.PaletteColorStyle.Inherit
        Me.kryptonPaletteCustom.TabStyles.TabLowProfile.StateNormal.Content.LongText.Hint = Krypton.Toolkit.PaletteTextHint.Inherit
        Me.kryptonPaletteCustom.TabStyles.TabLowProfile.StateNormal.Content.LongText.ImageAlign = Krypton.Toolkit.PaletteRectangleAlign.Inherit
        Me.kryptonPaletteCustom.TabStyles.TabLowProfile.StateNormal.Content.LongText.ImageStyle = Krypton.Toolkit.PaletteImageStyle.Inherit
        Me.kryptonPaletteCustom.TabStyles.TabLowProfile.StateNormal.Content.LongText.MultiLine = Krypton.Toolkit.InheritBool.Inherit
        Me.kryptonPaletteCustom.TabStyles.TabLowProfile.StateNormal.Content.LongText.MultiLineH = Krypton.Toolkit.PaletteRelativeAlign.Inherit
        Me.kryptonPaletteCustom.TabStyles.TabLowProfile.StateNormal.Content.LongText.Prefix = Krypton.Toolkit.PaletteTextHotkeyPrefix.Inherit
        Me.kryptonPaletteCustom.TabStyles.TabLowProfile.StateNormal.Content.LongText.TextH = Krypton.Toolkit.PaletteRelativeAlign.Inherit
        Me.kryptonPaletteCustom.TabStyles.TabLowProfile.StateNormal.Content.LongText.TextV = Krypton.Toolkit.PaletteRelativeAlign.Inherit
        Me.kryptonPaletteCustom.TabStyles.TabLowProfile.StateNormal.Content.LongText.Trim = Krypton.Toolkit.PaletteTextTrim.Inherit
        Me.kryptonPaletteCustom.TabStyles.TabLowProfile.StateNormal.Content.Padding = New System.Windows.Forms.Padding(-1)
        Me.kryptonPaletteCustom.TabStyles.TabLowProfile.StateNormal.Content.ShortText.Color1 = System.Drawing.Color.Black
        Me.kryptonPaletteCustom.TabStyles.TabLowProfile.StateNormal.Content.ShortText.ColorAlign = Krypton.Toolkit.PaletteRectangleAlign.Inherit
        Me.kryptonPaletteCustom.TabStyles.TabLowProfile.StateNormal.Content.ShortText.ColorStyle = Krypton.Toolkit.PaletteColorStyle.Inherit
        Me.kryptonPaletteCustom.TabStyles.TabLowProfile.StateNormal.Content.ShortText.Hint = Krypton.Toolkit.PaletteTextHint.Inherit
        Me.kryptonPaletteCustom.TabStyles.TabLowProfile.StateNormal.Content.ShortText.ImageAlign = Krypton.Toolkit.PaletteRectangleAlign.Inherit
        Me.kryptonPaletteCustom.TabStyles.TabLowProfile.StateNormal.Content.ShortText.ImageStyle = Krypton.Toolkit.PaletteImageStyle.Inherit
        Me.kryptonPaletteCustom.TabStyles.TabLowProfile.StateNormal.Content.ShortText.MultiLine = Krypton.Toolkit.InheritBool.Inherit
        Me.kryptonPaletteCustom.TabStyles.TabLowProfile.StateNormal.Content.ShortText.MultiLineH = Krypton.Toolkit.PaletteRelativeAlign.Inherit
        Me.kryptonPaletteCustom.TabStyles.TabLowProfile.StateNormal.Content.ShortText.Prefix = Krypton.Toolkit.PaletteTextHotkeyPrefix.Inherit
        Me.kryptonPaletteCustom.TabStyles.TabLowProfile.StateNormal.Content.ShortText.TextH = Krypton.Toolkit.PaletteRelativeAlign.Inherit
        Me.kryptonPaletteCustom.TabStyles.TabLowProfile.StateNormal.Content.ShortText.TextV = Krypton.Toolkit.PaletteRelativeAlign.Inherit
        Me.kryptonPaletteCustom.TabStyles.TabLowProfile.StateNormal.Content.ShortText.Trim = Krypton.Toolkit.PaletteTextTrim.Inherit
        Me.kryptonPaletteCustom.TabStyles.TabLowProfile.StatePressed.Back.ColorAlign = Krypton.Toolkit.PaletteRectangleAlign.Inherit
        Me.kryptonPaletteCustom.TabStyles.TabLowProfile.StatePressed.Back.ColorStyle = Krypton.Toolkit.PaletteColorStyle.Inherit
        Me.kryptonPaletteCustom.TabStyles.TabLowProfile.StatePressed.Back.Draw = Krypton.Toolkit.InheritBool.False
        Me.kryptonPaletteCustom.TabStyles.TabLowProfile.StatePressed.Back.GraphicsHint = Krypton.Toolkit.PaletteGraphicsHint.Inherit
        Me.kryptonPaletteCustom.TabStyles.TabLowProfile.StatePressed.Back.ImageAlign = Krypton.Toolkit.PaletteRectangleAlign.Inherit
        Me.kryptonPaletteCustom.TabStyles.TabLowProfile.StatePressed.Back.ImageStyle = Krypton.Toolkit.PaletteImageStyle.Inherit
        Me.kryptonPaletteCustom.TabStyles.TabLowProfile.StatePressed.Content.Draw = Krypton.Toolkit.InheritBool.Inherit
        Me.kryptonPaletteCustom.TabStyles.TabLowProfile.StatePressed.Content.DrawFocus = Krypton.Toolkit.InheritBool.Inherit
        Me.kryptonPaletteCustom.TabStyles.TabLowProfile.StatePressed.Content.LongText.Color1 = System.Drawing.Color.Black
        Me.kryptonPaletteCustom.TabStyles.TabLowProfile.StatePressed.Content.LongText.ColorAlign = Krypton.Toolkit.PaletteRectangleAlign.Inherit
        Me.kryptonPaletteCustom.TabStyles.TabLowProfile.StatePressed.Content.LongText.ColorStyle = Krypton.Toolkit.PaletteColorStyle.Inherit
        Me.kryptonPaletteCustom.TabStyles.TabLowProfile.StatePressed.Content.LongText.Hint = Krypton.Toolkit.PaletteTextHint.Inherit
        Me.kryptonPaletteCustom.TabStyles.TabLowProfile.StatePressed.Content.LongText.ImageAlign = Krypton.Toolkit.PaletteRectangleAlign.Inherit
        Me.kryptonPaletteCustom.TabStyles.TabLowProfile.StatePressed.Content.LongText.ImageStyle = Krypton.Toolkit.PaletteImageStyle.Inherit
        Me.kryptonPaletteCustom.TabStyles.TabLowProfile.StatePressed.Content.LongText.MultiLine = Krypton.Toolkit.InheritBool.Inherit
        Me.kryptonPaletteCustom.TabStyles.TabLowProfile.StatePressed.Content.LongText.MultiLineH = Krypton.Toolkit.PaletteRelativeAlign.Inherit
        Me.kryptonPaletteCustom.TabStyles.TabLowProfile.StatePressed.Content.LongText.Prefix = Krypton.Toolkit.PaletteTextHotkeyPrefix.Inherit
        Me.kryptonPaletteCustom.TabStyles.TabLowProfile.StatePressed.Content.LongText.TextH = Krypton.Toolkit.PaletteRelativeAlign.Inherit
        Me.kryptonPaletteCustom.TabStyles.TabLowProfile.StatePressed.Content.LongText.TextV = Krypton.Toolkit.PaletteRelativeAlign.Inherit
        Me.kryptonPaletteCustom.TabStyles.TabLowProfile.StatePressed.Content.LongText.Trim = Krypton.Toolkit.PaletteTextTrim.Inherit
        Me.kryptonPaletteCustom.TabStyles.TabLowProfile.StatePressed.Content.Padding = New System.Windows.Forms.Padding(-1)
        Me.kryptonPaletteCustom.TabStyles.TabLowProfile.StatePressed.Content.ShortText.Color1 = System.Drawing.Color.Black
        Me.kryptonPaletteCustom.TabStyles.TabLowProfile.StatePressed.Content.ShortText.ColorAlign = Krypton.Toolkit.PaletteRectangleAlign.Inherit
        Me.kryptonPaletteCustom.TabStyles.TabLowProfile.StatePressed.Content.ShortText.ColorStyle = Krypton.Toolkit.PaletteColorStyle.Inherit
        Me.kryptonPaletteCustom.TabStyles.TabLowProfile.StatePressed.Content.ShortText.Hint = Krypton.Toolkit.PaletteTextHint.Inherit
        Me.kryptonPaletteCustom.TabStyles.TabLowProfile.StatePressed.Content.ShortText.ImageAlign = Krypton.Toolkit.PaletteRectangleAlign.Inherit
        Me.kryptonPaletteCustom.TabStyles.TabLowProfile.StatePressed.Content.ShortText.ImageStyle = Krypton.Toolkit.PaletteImageStyle.Inherit
        Me.kryptonPaletteCustom.TabStyles.TabLowProfile.StatePressed.Content.ShortText.MultiLine = Krypton.Toolkit.InheritBool.Inherit
        Me.kryptonPaletteCustom.TabStyles.TabLowProfile.StatePressed.Content.ShortText.MultiLineH = Krypton.Toolkit.PaletteRelativeAlign.Inherit
        Me.kryptonPaletteCustom.TabStyles.TabLowProfile.StatePressed.Content.ShortText.Prefix = Krypton.Toolkit.PaletteTextHotkeyPrefix.Inherit
        Me.kryptonPaletteCustom.TabStyles.TabLowProfile.StatePressed.Content.ShortText.TextH = Krypton.Toolkit.PaletteRelativeAlign.Inherit
        Me.kryptonPaletteCustom.TabStyles.TabLowProfile.StatePressed.Content.ShortText.TextV = Krypton.Toolkit.PaletteRelativeAlign.Inherit
        Me.kryptonPaletteCustom.TabStyles.TabLowProfile.StatePressed.Content.ShortText.Trim = Krypton.Toolkit.PaletteTextTrim.Inherit
        Me.kryptonPaletteCustom.TabStyles.TabLowProfile.StateSelected.Back.Color1 = System.Drawing.Color.FromArgb(CType(CType(192, Byte), Integer), CType(CType(64, Byte), Integer), CType(CType(0, Byte), Integer))
        Me.kryptonPaletteCustom.TabStyles.TabLowProfile.StateSelected.Back.ColorAlign = Krypton.Toolkit.PaletteRectangleAlign.Inherit
        Me.kryptonPaletteCustom.TabStyles.TabLowProfile.StateSelected.Back.ColorStyle = Krypton.Toolkit.PaletteColorStyle.Inherit
        Me.kryptonPaletteCustom.TabStyles.TabLowProfile.StateSelected.Back.Draw = Krypton.Toolkit.InheritBool.Inherit
        Me.kryptonPaletteCustom.TabStyles.TabLowProfile.StateSelected.Back.GraphicsHint = Krypton.Toolkit.PaletteGraphicsHint.Inherit
        Me.kryptonPaletteCustom.TabStyles.TabLowProfile.StateSelected.Back.ImageAlign = Krypton.Toolkit.PaletteRectangleAlign.Inherit
        Me.kryptonPaletteCustom.TabStyles.TabLowProfile.StateSelected.Back.ImageStyle = Krypton.Toolkit.PaletteImageStyle.Inherit
        Me.kryptonPaletteCustom.TabStyles.TabLowProfile.StateSelected.Border.ColorAlign = Krypton.Toolkit.PaletteRectangleAlign.Inherit
        Me.kryptonPaletteCustom.TabStyles.TabLowProfile.StateSelected.Border.ColorStyle = Krypton.Toolkit.PaletteColorStyle.Inherit
        Me.kryptonPaletteCustom.TabStyles.TabLowProfile.StateSelected.Border.Draw = Krypton.Toolkit.InheritBool.False
        Me.kryptonPaletteCustom.TabStyles.TabLowProfile.StateSelected.Border.DrawBorders = CType((((Krypton.Toolkit.PaletteDrawBorders.Top Or Krypton.Toolkit.PaletteDrawBorders.Bottom) Or Krypton.Toolkit.PaletteDrawBorders.Left) Or Krypton.Toolkit.PaletteDrawBorders.Right), Krypton.Toolkit.PaletteDrawBorders)
        Me.kryptonPaletteCustom.TabStyles.TabLowProfile.StateSelected.Border.GraphicsHint = Krypton.Toolkit.PaletteGraphicsHint.Inherit
        Me.kryptonPaletteCustom.TabStyles.TabLowProfile.StateSelected.Border.ImageAlign = Krypton.Toolkit.PaletteRectangleAlign.Inherit
        Me.kryptonPaletteCustom.TabStyles.TabLowProfile.StateTracking.Back.ColorAlign = Krypton.Toolkit.PaletteRectangleAlign.Inherit
        Me.kryptonPaletteCustom.TabStyles.TabLowProfile.StateTracking.Back.ColorStyle = Krypton.Toolkit.PaletteColorStyle.Inherit
        Me.kryptonPaletteCustom.TabStyles.TabLowProfile.StateTracking.Back.Draw = Krypton.Toolkit.InheritBool.False
        Me.kryptonPaletteCustom.TabStyles.TabLowProfile.StateTracking.Back.GraphicsHint = Krypton.Toolkit.PaletteGraphicsHint.Inherit
        Me.kryptonPaletteCustom.TabStyles.TabLowProfile.StateTracking.Back.ImageAlign = Krypton.Toolkit.PaletteRectangleAlign.Inherit
        Me.kryptonPaletteCustom.TabStyles.TabLowProfile.StateTracking.Back.ImageStyle = Krypton.Toolkit.PaletteImageStyle.Inherit
        Me.kryptonPaletteCustom.TabStyles.TabLowProfile.StateTracking.Content.Draw = Krypton.Toolkit.InheritBool.Inherit
        Me.kryptonPaletteCustom.TabStyles.TabLowProfile.StateTracking.Content.DrawFocus = Krypton.Toolkit.InheritBool.Inherit
        Me.kryptonPaletteCustom.TabStyles.TabLowProfile.StateTracking.Content.LongText.Color1 = System.Drawing.Color.Black
        Me.kryptonPaletteCustom.TabStyles.TabLowProfile.StateTracking.Content.LongText.ColorAlign = Krypton.Toolkit.PaletteRectangleAlign.Inherit
        Me.kryptonPaletteCustom.TabStyles.TabLowProfile.StateTracking.Content.LongText.ColorStyle = Krypton.Toolkit.PaletteColorStyle.Inherit
        Me.kryptonPaletteCustom.TabStyles.TabLowProfile.StateTracking.Content.LongText.Hint = Krypton.Toolkit.PaletteTextHint.Inherit
        Me.kryptonPaletteCustom.TabStyles.TabLowProfile.StateTracking.Content.LongText.ImageAlign = Krypton.Toolkit.PaletteRectangleAlign.Inherit
        Me.kryptonPaletteCustom.TabStyles.TabLowProfile.StateTracking.Content.LongText.ImageStyle = Krypton.Toolkit.PaletteImageStyle.Inherit
        Me.kryptonPaletteCustom.TabStyles.TabLowProfile.StateTracking.Content.LongText.MultiLine = Krypton.Toolkit.InheritBool.Inherit
        Me.kryptonPaletteCustom.TabStyles.TabLowProfile.StateTracking.Content.LongText.MultiLineH = Krypton.Toolkit.PaletteRelativeAlign.Inherit
        Me.kryptonPaletteCustom.TabStyles.TabLowProfile.StateTracking.Content.LongText.Prefix = Krypton.Toolkit.PaletteTextHotkeyPrefix.Inherit
        Me.kryptonPaletteCustom.TabStyles.TabLowProfile.StateTracking.Content.LongText.TextH = Krypton.Toolkit.PaletteRelativeAlign.Inherit
        Me.kryptonPaletteCustom.TabStyles.TabLowProfile.StateTracking.Content.LongText.TextV = Krypton.Toolkit.PaletteRelativeAlign.Inherit
        Me.kryptonPaletteCustom.TabStyles.TabLowProfile.StateTracking.Content.LongText.Trim = Krypton.Toolkit.PaletteTextTrim.Inherit
        Me.kryptonPaletteCustom.TabStyles.TabLowProfile.StateTracking.Content.Padding = New System.Windows.Forms.Padding(-1)
        Me.kryptonPaletteCustom.TabStyles.TabLowProfile.StateTracking.Content.ShortText.Color1 = System.Drawing.Color.Black
        Me.kryptonPaletteCustom.TabStyles.TabLowProfile.StateTracking.Content.ShortText.ColorAlign = Krypton.Toolkit.PaletteRectangleAlign.Inherit
        Me.kryptonPaletteCustom.TabStyles.TabLowProfile.StateTracking.Content.ShortText.ColorStyle = Krypton.Toolkit.PaletteColorStyle.Inherit
        Me.kryptonPaletteCustom.TabStyles.TabLowProfile.StateTracking.Content.ShortText.Hint = Krypton.Toolkit.PaletteTextHint.Inherit
        Me.kryptonPaletteCustom.TabStyles.TabLowProfile.StateTracking.Content.ShortText.ImageAlign = Krypton.Toolkit.PaletteRectangleAlign.Inherit
        Me.kryptonPaletteCustom.TabStyles.TabLowProfile.StateTracking.Content.ShortText.ImageStyle = Krypton.Toolkit.PaletteImageStyle.Inherit
        Me.kryptonPaletteCustom.TabStyles.TabLowProfile.StateTracking.Content.ShortText.MultiLine = Krypton.Toolkit.InheritBool.Inherit
        Me.kryptonPaletteCustom.TabStyles.TabLowProfile.StateTracking.Content.ShortText.MultiLineH = Krypton.Toolkit.PaletteRelativeAlign.Inherit
        Me.kryptonPaletteCustom.TabStyles.TabLowProfile.StateTracking.Content.ShortText.Prefix = Krypton.Toolkit.PaletteTextHotkeyPrefix.Inherit
        Me.kryptonPaletteCustom.TabStyles.TabLowProfile.StateTracking.Content.ShortText.TextH = Krypton.Toolkit.PaletteRelativeAlign.Inherit
        Me.kryptonPaletteCustom.TabStyles.TabLowProfile.StateTracking.Content.ShortText.TextV = Krypton.Toolkit.PaletteRelativeAlign.Inherit
        Me.kryptonPaletteCustom.TabStyles.TabLowProfile.StateTracking.Content.ShortText.Trim = Krypton.Toolkit.PaletteTextTrim.Inherit
        Me.kryptonPaletteCustom.TabStyles.TabOneNote.StateCommon.Back.ColorAlign = Krypton.Toolkit.PaletteRectangleAlign.Inherit
        Me.kryptonPaletteCustom.TabStyles.TabOneNote.StateCommon.Back.ColorStyle = Krypton.Toolkit.PaletteColorStyle.OneNote
        Me.kryptonPaletteCustom.TabStyles.TabOneNote.StateCommon.Back.Draw = Krypton.Toolkit.InheritBool.Inherit
        Me.kryptonPaletteCustom.TabStyles.TabOneNote.StateCommon.Back.GraphicsHint = Krypton.Toolkit.PaletteGraphicsHint.Inherit
        Me.kryptonPaletteCustom.TabStyles.TabOneNote.StateCommon.Back.ImageAlign = Krypton.Toolkit.PaletteRectangleAlign.Inherit
        Me.kryptonPaletteCustom.TabStyles.TabOneNote.StateCommon.Back.ImageStyle = Krypton.Toolkit.PaletteImageStyle.Inherit
        Me.kryptonPaletteCustom.TabStyles.TabOneNote.StateSelected.Back.Color1 = System.Drawing.Color.FromArgb(CType(CType(192, Byte), Integer), CType(CType(64, Byte), Integer), CType(CType(0, Byte), Integer))
        Me.kryptonPaletteCustom.TabStyles.TabOneNote.StateSelected.Back.ColorAlign = Krypton.Toolkit.PaletteRectangleAlign.Inherit
        Me.kryptonPaletteCustom.TabStyles.TabOneNote.StateSelected.Back.ColorStyle = Krypton.Toolkit.PaletteColorStyle.Inherit
        Me.kryptonPaletteCustom.TabStyles.TabOneNote.StateSelected.Back.Draw = Krypton.Toolkit.InheritBool.Inherit
        Me.kryptonPaletteCustom.TabStyles.TabOneNote.StateSelected.Back.GraphicsHint = Krypton.Toolkit.PaletteGraphicsHint.Inherit
        Me.kryptonPaletteCustom.TabStyles.TabOneNote.StateSelected.Back.ImageAlign = Krypton.Toolkit.PaletteRectangleAlign.Inherit
        Me.kryptonPaletteCustom.TabStyles.TabOneNote.StateSelected.Back.ImageStyle = Krypton.Toolkit.PaletteImageStyle.Inherit
        Me.kryptonPaletteCustom.TabStyles.TabStandardProfile.StateSelected.Back.Color1 = System.Drawing.Color.FromArgb(CType(CType(192, Byte), Integer), CType(CType(64, Byte), Integer), CType(CType(0, Byte), Integer))
        Me.kryptonPaletteCustom.TabStyles.TabStandardProfile.StateSelected.Back.ColorAlign = Krypton.Toolkit.PaletteRectangleAlign.Inherit
        Me.kryptonPaletteCustom.TabStyles.TabStandardProfile.StateSelected.Back.ColorStyle = Krypton.Toolkit.PaletteColorStyle.Solid
        Me.kryptonPaletteCustom.TabStyles.TabStandardProfile.StateSelected.Back.Draw = Krypton.Toolkit.InheritBool.Inherit
        Me.kryptonPaletteCustom.TabStyles.TabStandardProfile.StateSelected.Back.GraphicsHint = Krypton.Toolkit.PaletteGraphicsHint.Inherit
        Me.kryptonPaletteCustom.TabStyles.TabStandardProfile.StateSelected.Back.ImageAlign = Krypton.Toolkit.PaletteRectangleAlign.Inherit
        Me.kryptonPaletteCustom.TabStyles.TabStandardProfile.StateSelected.Back.ImageStyle = Krypton.Toolkit.PaletteImageStyle.Inherit
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
        Me.kryptonPaletteSparkle.BasePaletteType = Krypton.Toolkit.BasePaletteType.Sparkle
        Me.kryptonPaletteSparkle.BaseRenderMode = Krypton.Toolkit.RendererMode.Inherit
        Me.kryptonPaletteSystem.BasePaletteType = Krypton.Toolkit.BasePaletteType.Professional
        Me.kryptonPaletteSystem.BaseRenderMode = Krypton.Toolkit.RendererMode.Inherit
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6F, 13F)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(686, 547)
        Me.Controls.Add(Me.groupBoxPalettes)
        Me.Controls.Add(Me.buttonClose)
        Me.Controls.Add(Me.groupBox4)
        Me.Controls.Add(Me.groupBoxKryptonBorderEdge)
        Me.Controls.Add(Me.groupBoxButtonGroup)
        Me.Controls.Add(Me.groupBoxBorderEdge)
        Me.Font = New System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.MaximizeBox = False
        Me.MinimizeBox = False
        Me.Name = "Form1"
        Me.Text = "KryptonBorderEdge Examples"
        Me.panelButtonHost.ResumeLayout(False)
        Me.panelButtonHost.PerformLayout()
        CType(Me.kryptonCheckSet, System.ComponentModel.ISupportInitialize).EndInit()
        Me.groupBoxBorderEdge.ResumeLayout(False)
        Me.groupBoxBorderEdge.PerformLayout()
        Me.groupBoxButtonGroup.ResumeLayout(False)
        Me.groupBoxButtonGroup.PerformLayout()
        Me.groupBoxKryptonBorderEdge.ResumeLayout(False)
        Me.groupBoxKryptonBorderEdge.PerformLayout()
        Me.groupBox4.ResumeLayout(False)
        Me.groupBoxPalettes.ResumeLayout(False)
        Me.ResumeLayout(False)
    End Sub

    Friend WithEvents borderEdgeH1 As Krypton.Toolkit.KryptonBorderEdge
    Friend WithEvents borderEdgeV As Krypton.Toolkit.KryptonBorderEdge
    Friend WithEvents borderAll As Krypton.Toolkit.KryptonButton
    Friend WithEvents borderL As Krypton.Toolkit.KryptonButton
    Friend WithEvents borderT As Krypton.Toolkit.KryptonButton
    Friend WithEvents borderR As Krypton.Toolkit.KryptonButton
    Friend WithEvents borderB As Krypton.Toolkit.KryptonButton
    Friend WithEvents borderLT As Krypton.Toolkit.KryptonButton
    Friend WithEvents borderTR As Krypton.Toolkit.KryptonButton
    Friend WithEvents borderBR As Krypton.Toolkit.KryptonButton
    Friend WithEvents borderBL As Krypton.Toolkit.KryptonButton
    Friend WithEvents borderTB As Krypton.Toolkit.KryptonButton
    Friend WithEvents borderLR As Krypton.Toolkit.KryptonButton
    Friend WithEvents borderNone As Krypton.Toolkit.KryptonButton
    Friend WithEvents borderTBR As Krypton.Toolkit.KryptonButton
    Friend WithEvents borderLRB As Krypton.Toolkit.KryptonButton
    Friend WithEvents borderTBL As Krypton.Toolkit.KryptonButton
    Friend WithEvents borderLRT As Krypton.Toolkit.KryptonButton
    Friend WithEvents panelButtonHost As System.Windows.Forms.Panel
    Friend WithEvents kryptonCheckSet As Krypton.Toolkit.KryptonCheckSet
    Friend WithEvents buttonBegin As Krypton.Toolkit.KryptonCheckButton
    Friend WithEvents buttonPrevious As Krypton.Toolkit.KryptonCheckButton
    Friend WithEvents buttonNext As Krypton.Toolkit.KryptonCheckButton
    Friend WithEvents buttonEnd As Krypton.Toolkit.KryptonCheckButton
    Friend WithEvents borderEdgeSep1 As Krypton.Toolkit.KryptonBorderEdge
    Friend WithEvents borderEdgeSep2 As Krypton.Toolkit.KryptonBorderEdge
    Friend WithEvents borderEdgeSep3 As Krypton.Toolkit.KryptonBorderEdge
    Friend WithEvents groupBoxBorderEdge As System.Windows.Forms.GroupBox
    Friend WithEvents groupBoxButtonGroup As System.Windows.Forms.GroupBox
    Friend WithEvents groupBoxKryptonBorderEdge As System.Windows.Forms.GroupBox
    Friend WithEvents groupBox4 As System.Windows.Forms.GroupBox
    Friend WithEvents propertyGrid As System.Windows.Forms.PropertyGrid
    Friend WithEvents buttonClose As System.Windows.Forms.Button
    Friend WithEvents groupBoxPalettes As System.Windows.Forms.GroupBox
    Friend WithEvents buttonCustom As System.Windows.Forms.Button
    Friend WithEvents buttonSystem As System.Windows.Forms.Button
    Friend WithEvents buttonSparkle As System.Windows.Forms.Button
    Friend WithEvents kryptonManager As Krypton.Toolkit.KryptonManager
    Friend WithEvents kryptonPaletteCustom As Krypton.Toolkit.KryptonCustomPaletteBase
    Friend WithEvents kryptonPaletteSparkle As Krypton.Toolkit.KryptonCustomPaletteBase
    Friend WithEvents kryptonPaletteSystem As Krypton.Toolkit.KryptonCustomPaletteBase
    Friend WithEvents buttonOffice2010Blue As System.Windows.Forms.Button
    Friend WithEvents kryptonPaletteOffice2007Blue As Krypton.Toolkit.KryptonCustomPaletteBase
    Friend WithEvents kryptonBorderEdge4 As Krypton.Toolkit.KryptonBorderEdge
    Friend WithEvents kryptonBorderEdge3 As Krypton.Toolkit.KryptonBorderEdge
    Friend WithEvents kryptonBorderEdge2 As Krypton.Toolkit.KryptonBorderEdge
    Friend WithEvents kryptonBorderEdge1 As Krypton.Toolkit.KryptonBorderEdge
    Friend WithEvents buttonOffice2007Blue As System.Windows.Forms.Button
    Friend WithEvents kryptonPaletteOffice2010Blue As Krypton.Toolkit.KryptonCustomPaletteBase
End Class
