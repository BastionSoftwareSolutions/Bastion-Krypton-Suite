' VB.NET twin of Source\Krypton Toolkit Examples\Custom Control using Renderers\Form1.Designer.cs (Bastion Phase 4c).
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
        Me.groupBoxDescription = New System.Windows.Forms.GroupBox()
        Me.textBox1 = New System.Windows.Forms.TextBox()
        Me.groupBoxCustomControl = New System.Windows.Forms.GroupBox()
        Me.radioRight = New System.Windows.Forms.RadioButton()
        Me.radioLeft = New System.Windows.Forms.RadioButton()
        Me.radioBottom = New System.Windows.Forms.RadioButton()
        Me.radioTop = New System.Windows.Forms.RadioButton()
        Me.myUserControl1 = New CustomControlUsingRenderers.MyUserControl()
        Me.checkBoxEnabled = New System.Windows.Forms.CheckBox()
        Me.groupBoxPalettes = New System.Windows.Forms.GroupBox()
        Me.buttonOffice2010Blue = New Krypton.Toolkit.KryptonCheckButton()
        Me.buttonOffice2007Blue = New Krypton.Toolkit.KryptonCheckButton()
        Me.buttonCustom = New Krypton.Toolkit.KryptonCheckButton()
        Me.buttonSparkle = New Krypton.Toolkit.KryptonCheckButton()
        Me.buttonSystem = New Krypton.Toolkit.KryptonCheckButton()
        Me.buttonClose = New System.Windows.Forms.Button()
        Me.kryptonManager = New Krypton.Toolkit.KryptonManager(Me.components)
        Me.kryptonCheckSet = New Krypton.Toolkit.KryptonCheckSet(Me.components)
        Me.kryptonPaletteCustom = New Krypton.Toolkit.KryptonCustomPaletteBase(Me.components)
        Me.groupBoxDescription.SuspendLayout()
        Me.groupBoxCustomControl.SuspendLayout()
        Me.groupBoxPalettes.SuspendLayout()
        CType(Me.kryptonCheckSet, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'groupBoxDescription
        '
        Me.groupBoxDescription.Anchor = CType(((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Left) Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.groupBoxDescription.Controls.Add(Me.textBox1)
        Me.groupBoxDescription.Location = New System.Drawing.Point(12, 267)
        Me.groupBoxDescription.Name = "groupBoxDescription"
        Me.groupBoxDescription.Padding = New System.Windows.Forms.Padding(5)
        Me.groupBoxDescription.Size = New System.Drawing.Size(430, 156)
        Me.groupBoxDescription.TabIndex = 2
        Me.groupBoxDescription.TabStop = False
        Me.groupBoxDescription.Text = "Description"
        '
        'textBox1
        '
        Me.textBox1.BackColor = System.Drawing.SystemColors.Control
        Me.textBox1.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.textBox1.Dock = System.Windows.Forms.DockStyle.Fill
        Me.textBox1.Location = New System.Drawing.Point(5, 19)
        Me.textBox1.Multiline = True
        Me.textBox1.Name = "textBox1"
        Me.textBox1.ScrollBars = System.Windows.Forms.ScrollBars.Vertical
        Me.textBox1.Size = New System.Drawing.Size(420, 132)
        Me.textBox1.TabIndex = 0
        Me.textBox1.Text = resources.GetString("textBox1.Text")
        '
        'groupBoxCustomControl
        '
        Me.groupBoxCustomControl.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) Or System.Windows.Forms.AnchorStyles.Left) Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.groupBoxCustomControl.Controls.Add(Me.radioRight)
        Me.groupBoxCustomControl.Controls.Add(Me.radioLeft)
        Me.groupBoxCustomControl.Controls.Add(Me.radioBottom)
        Me.groupBoxCustomControl.Controls.Add(Me.radioTop)
        Me.groupBoxCustomControl.Controls.Add(Me.myUserControl1)
        Me.groupBoxCustomControl.Controls.Add(Me.checkBoxEnabled)
        Me.groupBoxCustomControl.Location = New System.Drawing.Point(176, 13)
        Me.groupBoxCustomControl.Name = "groupBoxCustomControl"
        Me.groupBoxCustomControl.Size = New System.Drawing.Size(266, 247)
        Me.groupBoxCustomControl.TabIndex = 1
        Me.groupBoxCustomControl.TabStop = False
        Me.groupBoxCustomControl.Text = "MyCustomControl Instance"
        '
        'radioRight
        '
        Me.radioRight.AutoSize = True
        Me.radioRight.Location = New System.Drawing.Point(15, 100)
        Me.radioRight.Name = "radioRight"
        Me.radioRight.Size = New System.Drawing.Size(50, 17)
        Me.radioRight.TabIndex = 3
        Me.radioRight.Text = "Right"
        Me.radioRight.UseVisualStyleBackColor = True
        '
        'radioLeft
        '
        Me.radioLeft.AutoSize = True
        Me.radioLeft.Location = New System.Drawing.Point(15, 77)
        Me.radioLeft.Name = "radioLeft"
        Me.radioLeft.Size = New System.Drawing.Size(44, 17)
        Me.radioLeft.TabIndex = 2
        Me.radioLeft.Text = "Left"
        Me.radioLeft.UseVisualStyleBackColor = True
        '
        'radioBottom
        '
        Me.radioBottom.AutoSize = True
        Me.radioBottom.Location = New System.Drawing.Point(15, 54)
        Me.radioBottom.Name = "radioBottom"
        Me.radioBottom.Size = New System.Drawing.Size(59, 17)
        Me.radioBottom.TabIndex = 1
        Me.radioBottom.Text = "Bottom"
        Me.radioBottom.UseVisualStyleBackColor = True
        '
        'radioTop
        '
        Me.radioTop.AutoSize = True
        Me.radioTop.Checked = True
        Me.radioTop.Location = New System.Drawing.Point(15, 31)
        Me.radioTop.Name = "radioTop"
        Me.radioTop.Size = New System.Drawing.Size(43, 17)
        Me.radioTop.TabIndex = 0
        Me.radioTop.TabStop = True
        Me.radioTop.Text = "Top"
        Me.radioTop.UseVisualStyleBackColor = True
        '
        'myUserControl1
        '
        Me.myUserControl1.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) Or System.Windows.Forms.AnchorStyles.Left) Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.myUserControl1.Location = New System.Drawing.Point(86, 31)
        Me.myUserControl1.Name = "myUserControl1"
        Me.myUserControl1.Orientation = Krypton.Toolkit.VisualOrientation.Top
        Me.myUserControl1.Size = New System.Drawing.Size(161, 200)
        Me.myUserControl1.TabIndex = 5
        '
        'checkBoxEnabled
        '
        Me.checkBoxEnabled.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Left), System.Windows.Forms.AnchorStyles)
        Me.checkBoxEnabled.AutoSize = True
        Me.checkBoxEnabled.Checked = True
        Me.checkBoxEnabled.CheckState = System.Windows.Forms.CheckState.Checked
        Me.checkBoxEnabled.Location = New System.Drawing.Point(15, 214)
        Me.checkBoxEnabled.Name = "checkBoxEnabled"
        Me.checkBoxEnabled.Size = New System.Drawing.Size(64, 17)
        Me.checkBoxEnabled.TabIndex = 4
        Me.checkBoxEnabled.Text = "Enabled"
        Me.checkBoxEnabled.UseVisualStyleBackColor = True
        '
        'groupBoxPalettes
        '
        Me.groupBoxPalettes.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) Or System.Windows.Forms.AnchorStyles.Left), System.Windows.Forms.AnchorStyles)
        Me.groupBoxPalettes.Controls.Add(Me.buttonOffice2010Blue)
        Me.groupBoxPalettes.Controls.Add(Me.buttonOffice2007Blue)
        Me.groupBoxPalettes.Controls.Add(Me.buttonCustom)
        Me.groupBoxPalettes.Controls.Add(Me.buttonSparkle)
        Me.groupBoxPalettes.Controls.Add(Me.buttonSystem)
        Me.groupBoxPalettes.Location = New System.Drawing.Point(12, 12)
        Me.groupBoxPalettes.Name = "groupBoxPalettes"
        Me.groupBoxPalettes.Size = New System.Drawing.Size(158, 248)
        Me.groupBoxPalettes.TabIndex = 0
        Me.groupBoxPalettes.TabStop = False
        Me.groupBoxPalettes.Text = "Palettes"
        '
        'buttonOffice2010Blue
        '
        Me.buttonOffice2010Blue.AutoSize = True
        Me.buttonOffice2010Blue.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowOnly
        Me.buttonOffice2010Blue.Checked = True
        Me.buttonOffice2010Blue.DialogResult = System.Windows.Forms.DialogResult.None
        Me.buttonOffice2010Blue.Location = New System.Drawing.Point(14, 32)
        Me.buttonOffice2010Blue.Name = "buttonOffice2010Blue"
        Me.buttonOffice2010Blue.Orientation = Krypton.Toolkit.VisualOrientation.Top
        Me.buttonOffice2010Blue.Size = New System.Drawing.Size(127, 27)
        Me.buttonOffice2010Blue.TabIndex = 0
        Me.buttonOffice2010Blue.Values.Text = "Office 2010 - Blue"
        '
        'buttonOffice2007Blue
        '
        Me.buttonOffice2007Blue.AutoSize = True
        Me.buttonOffice2007Blue.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowOnly
        Me.buttonOffice2007Blue.DialogResult = System.Windows.Forms.DialogResult.None
        Me.buttonOffice2007Blue.Location = New System.Drawing.Point(14, 65)
        Me.buttonOffice2007Blue.Name = "buttonOffice2007Blue"
        Me.buttonOffice2007Blue.Orientation = Krypton.Toolkit.VisualOrientation.Top
        Me.buttonOffice2007Blue.Size = New System.Drawing.Size(127, 27)
        Me.buttonOffice2007Blue.TabIndex = 1
        Me.buttonOffice2007Blue.Values.Text = "Office 2007 - Blue"
        '
        'buttonCustom
        '
        Me.buttonCustom.AutoSize = True
        Me.buttonCustom.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowOnly
        Me.buttonCustom.DialogResult = System.Windows.Forms.DialogResult.None
        Me.buttonCustom.Location = New System.Drawing.Point(14, 164)
        Me.buttonCustom.Name = "buttonCustom"
        Me.buttonCustom.Orientation = Krypton.Toolkit.VisualOrientation.Top
        Me.buttonCustom.Size = New System.Drawing.Size(127, 27)
        Me.buttonCustom.TabIndex = 4
        Me.buttonCustom.Values.Text = "Custom"
        '
        'buttonSparkle
        '
        Me.buttonSparkle.AutoSize = True
        Me.buttonSparkle.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowOnly
        Me.buttonSparkle.DialogResult = System.Windows.Forms.DialogResult.None
        Me.buttonSparkle.Location = New System.Drawing.Point(14, 98)
        Me.buttonSparkle.Name = "buttonSparkle"
        Me.buttonSparkle.Orientation = Krypton.Toolkit.VisualOrientation.Top
        Me.buttonSparkle.Size = New System.Drawing.Size(127, 27)
        Me.buttonSparkle.TabIndex = 2
        Me.buttonSparkle.Values.Text = "Sparkle - Blue"
        '
        'buttonSystem
        '
        Me.buttonSystem.AutoSize = True
        Me.buttonSystem.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowOnly
        Me.buttonSystem.DialogResult = System.Windows.Forms.DialogResult.None
        Me.buttonSystem.Location = New System.Drawing.Point(14, 131)
        Me.buttonSystem.Name = "buttonSystem"
        Me.buttonSystem.Orientation = Krypton.Toolkit.VisualOrientation.Top
        Me.buttonSystem.Size = New System.Drawing.Size(127, 27)
        Me.buttonSystem.TabIndex = 3
        Me.buttonSystem.Values.Text = "System"
        '
        'buttonClose
        '
        Me.buttonClose.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.buttonClose.Location = New System.Drawing.Point(367, 429)
        Me.buttonClose.Name = "buttonClose"
        Me.buttonClose.Size = New System.Drawing.Size(75, 23)
        Me.buttonClose.TabIndex = 3
        Me.buttonClose.Text = "Close"
        Me.buttonClose.UseVisualStyleBackColor = True
        '
        'kryptonManager
        '
        Me.kryptonManager.GlobalPaletteMode = Krypton.Toolkit.PaletteMode.Office2007Blue
        '
        'kryptonCheckSet
        '
        Me.kryptonCheckSet.CheckButtons.Add(Me.buttonSparkle)
        Me.kryptonCheckSet.CheckButtons.Add(Me.buttonSystem)
        Me.kryptonCheckSet.CheckButtons.Add(Me.buttonCustom)
        Me.kryptonCheckSet.CheckButtons.Add(Me.buttonOffice2010Blue)
        Me.kryptonCheckSet.CheckButtons.Add(Me.buttonOffice2007Blue)
        Me.kryptonCheckSet.CheckedButton = Me.buttonOffice2010Blue
        '
        'kryptonPaletteCustom
        '
        Me.kryptonPaletteCustom.BasePaletteType = Krypton.Toolkit.BasePaletteType.Office2007
        Me.kryptonPaletteCustom.BaseRenderMode = Krypton.Toolkit.RendererMode.Inherit
        Me.kryptonPaletteCustom.ButtonStyles.ButtonStandalone.StateCheckedNormal.Back.Color1 = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(224, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.kryptonPaletteCustom.ButtonStyles.ButtonStandalone.StateCheckedNormal.Back.Color2 = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(192, Byte), Integer), CType(CType(128, Byte), Integer))
        Me.kryptonPaletteCustom.ButtonStyles.ButtonStandalone.StateCheckedNormal.Back.ColorAlign = Krypton.Toolkit.PaletteRectangleAlign.Inherit
        Me.kryptonPaletteCustom.ButtonStyles.ButtonStandalone.StateCheckedNormal.Back.ColorStyle = Krypton.Toolkit.PaletteColorStyle.Inherit
        Me.kryptonPaletteCustom.ButtonStyles.ButtonStandalone.StateCheckedNormal.Back.Draw = Krypton.Toolkit.InheritBool.Inherit
        Me.kryptonPaletteCustom.ButtonStyles.ButtonStandalone.StateCheckedNormal.Back.GraphicsHint = Krypton.Toolkit.PaletteGraphicsHint.Inherit
        Me.kryptonPaletteCustom.ButtonStyles.ButtonStandalone.StateCheckedNormal.Back.ImageAlign = Krypton.Toolkit.PaletteRectangleAlign.Inherit
        Me.kryptonPaletteCustom.ButtonStyles.ButtonStandalone.StateCheckedNormal.Back.ImageStyle = Krypton.Toolkit.PaletteImageStyle.Inherit
        Me.kryptonPaletteCustom.ButtonStyles.ButtonStandalone.StateCheckedNormal.Border.Color1 = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(128, Byte), Integer), CType(CType(0, Byte), Integer))
        Me.kryptonPaletteCustom.ButtonStyles.ButtonStandalone.StateCheckedNormal.Border.ColorAlign = Krypton.Toolkit.PaletteRectangleAlign.Inherit
        Me.kryptonPaletteCustom.ButtonStyles.ButtonStandalone.StateCheckedNormal.Border.ColorStyle = Krypton.Toolkit.PaletteColorStyle.Inherit
        Me.kryptonPaletteCustom.ButtonStyles.ButtonStandalone.StateCheckedNormal.Border.Draw = Krypton.Toolkit.InheritBool.Inherit
        Me.kryptonPaletteCustom.ButtonStyles.ButtonStandalone.StateCheckedNormal.Border.DrawBorders = CType((((Krypton.Toolkit.PaletteDrawBorders.Top Or Krypton.Toolkit.PaletteDrawBorders.Bottom) Or Krypton.Toolkit.PaletteDrawBorders.Left) Or Krypton.Toolkit.PaletteDrawBorders.Right), Krypton.Toolkit.PaletteDrawBorders)
        Me.kryptonPaletteCustom.ButtonStyles.ButtonStandalone.StateCheckedNormal.Border.GraphicsHint = Krypton.Toolkit.PaletteGraphicsHint.Inherit
        Me.kryptonPaletteCustom.ButtonStyles.ButtonStandalone.StateCheckedNormal.Border.ImageAlign = Krypton.Toolkit.PaletteRectangleAlign.Inherit
        Me.kryptonPaletteCustom.ButtonStyles.ButtonStandalone.StateCheckedPressed.Back.Color1 = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(224, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.kryptonPaletteCustom.ButtonStyles.ButtonStandalone.StateCheckedPressed.Back.Color2 = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(192, Byte), Integer), CType(CType(128, Byte), Integer))
        Me.kryptonPaletteCustom.ButtonStyles.ButtonStandalone.StateCheckedPressed.Back.ColorAlign = Krypton.Toolkit.PaletteRectangleAlign.Inherit
        Me.kryptonPaletteCustom.ButtonStyles.ButtonStandalone.StateCheckedPressed.Back.ColorStyle = Krypton.Toolkit.PaletteColorStyle.Inherit
        Me.kryptonPaletteCustom.ButtonStyles.ButtonStandalone.StateCheckedPressed.Back.Draw = Krypton.Toolkit.InheritBool.Inherit
        Me.kryptonPaletteCustom.ButtonStyles.ButtonStandalone.StateCheckedPressed.Back.GraphicsHint = Krypton.Toolkit.PaletteGraphicsHint.Inherit
        Me.kryptonPaletteCustom.ButtonStyles.ButtonStandalone.StateCheckedPressed.Back.ImageAlign = Krypton.Toolkit.PaletteRectangleAlign.Inherit
        Me.kryptonPaletteCustom.ButtonStyles.ButtonStandalone.StateCheckedPressed.Back.ImageStyle = Krypton.Toolkit.PaletteImageStyle.Inherit
        Me.kryptonPaletteCustom.ButtonStyles.ButtonStandalone.StateCheckedPressed.Border.Color1 = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(128, Byte), Integer), CType(CType(0, Byte), Integer))
        Me.kryptonPaletteCustom.ButtonStyles.ButtonStandalone.StateCheckedPressed.Border.ColorAlign = Krypton.Toolkit.PaletteRectangleAlign.Inherit
        Me.kryptonPaletteCustom.ButtonStyles.ButtonStandalone.StateCheckedPressed.Border.ColorStyle = Krypton.Toolkit.PaletteColorStyle.Inherit
        Me.kryptonPaletteCustom.ButtonStyles.ButtonStandalone.StateCheckedPressed.Border.Draw = Krypton.Toolkit.InheritBool.Inherit
        Me.kryptonPaletteCustom.ButtonStyles.ButtonStandalone.StateCheckedPressed.Border.DrawBorders = CType((((Krypton.Toolkit.PaletteDrawBorders.Top Or Krypton.Toolkit.PaletteDrawBorders.Bottom) Or Krypton.Toolkit.PaletteDrawBorders.Left) Or Krypton.Toolkit.PaletteDrawBorders.Right), Krypton.Toolkit.PaletteDrawBorders)
        Me.kryptonPaletteCustom.ButtonStyles.ButtonStandalone.StateCheckedPressed.Border.GraphicsHint = Krypton.Toolkit.PaletteGraphicsHint.Inherit
        Me.kryptonPaletteCustom.ButtonStyles.ButtonStandalone.StateCheckedPressed.Border.ImageAlign = Krypton.Toolkit.PaletteRectangleAlign.Inherit
        Me.kryptonPaletteCustom.ButtonStyles.ButtonStandalone.StateCheckedTracking.Back.Color1 = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(224, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.kryptonPaletteCustom.ButtonStyles.ButtonStandalone.StateCheckedTracking.Back.Color2 = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(192, Byte), Integer), CType(CType(128, Byte), Integer))
        Me.kryptonPaletteCustom.ButtonStyles.ButtonStandalone.StateCheckedTracking.Back.ColorAlign = Krypton.Toolkit.PaletteRectangleAlign.Inherit
        Me.kryptonPaletteCustom.ButtonStyles.ButtonStandalone.StateCheckedTracking.Back.ColorStyle = Krypton.Toolkit.PaletteColorStyle.Inherit
        Me.kryptonPaletteCustom.ButtonStyles.ButtonStandalone.StateCheckedTracking.Back.Draw = Krypton.Toolkit.InheritBool.Inherit
        Me.kryptonPaletteCustom.ButtonStyles.ButtonStandalone.StateCheckedTracking.Back.GraphicsHint = Krypton.Toolkit.PaletteGraphicsHint.Inherit
        Me.kryptonPaletteCustom.ButtonStyles.ButtonStandalone.StateCheckedTracking.Back.ImageAlign = Krypton.Toolkit.PaletteRectangleAlign.Inherit
        Me.kryptonPaletteCustom.ButtonStyles.ButtonStandalone.StateCheckedTracking.Back.ImageStyle = Krypton.Toolkit.PaletteImageStyle.Inherit
        Me.kryptonPaletteCustom.ButtonStyles.ButtonStandalone.StateCheckedTracking.Border.Color1 = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(128, Byte), Integer), CType(CType(0, Byte), Integer))
        Me.kryptonPaletteCustom.ButtonStyles.ButtonStandalone.StateCheckedTracking.Border.ColorAlign = Krypton.Toolkit.PaletteRectangleAlign.Inherit
        Me.kryptonPaletteCustom.ButtonStyles.ButtonStandalone.StateCheckedTracking.Border.ColorStyle = Krypton.Toolkit.PaletteColorStyle.Inherit
        Me.kryptonPaletteCustom.ButtonStyles.ButtonStandalone.StateCheckedTracking.Border.Draw = Krypton.Toolkit.InheritBool.Inherit
        Me.kryptonPaletteCustom.ButtonStyles.ButtonStandalone.StateCheckedTracking.Border.DrawBorders = CType((((Krypton.Toolkit.PaletteDrawBorders.Top Or Krypton.Toolkit.PaletteDrawBorders.Bottom) Or Krypton.Toolkit.PaletteDrawBorders.Left) Or Krypton.Toolkit.PaletteDrawBorders.Right), Krypton.Toolkit.PaletteDrawBorders)
        Me.kryptonPaletteCustom.ButtonStyles.ButtonStandalone.StateCheckedTracking.Border.GraphicsHint = Krypton.Toolkit.PaletteGraphicsHint.Inherit
        Me.kryptonPaletteCustom.ButtonStyles.ButtonStandalone.StateCheckedTracking.Border.ImageAlign = Krypton.Toolkit.PaletteRectangleAlign.Inherit
        Me.kryptonPaletteCustom.ButtonStyles.ButtonStandalone.StateCommon.Back.Color1 = System.Drawing.Color.FromArgb(CType(CType(192, Byte), Integer), CType(CType(192, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.kryptonPaletteCustom.ButtonStyles.ButtonStandalone.StateCommon.Back.Color2 = System.Drawing.Color.FromArgb(CType(CType(128, Byte), Integer), CType(CType(128, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.kryptonPaletteCustom.ButtonStyles.ButtonStandalone.StateCommon.Back.ColorAlign = Krypton.Toolkit.PaletteRectangleAlign.Inherit
        Me.kryptonPaletteCustom.ButtonStyles.ButtonStandalone.StateCommon.Back.ColorStyle = Krypton.Toolkit.PaletteColorStyle.HalfCut
        Me.kryptonPaletteCustom.ButtonStyles.ButtonStandalone.StateCommon.Back.Draw = Krypton.Toolkit.InheritBool.Inherit
        Me.kryptonPaletteCustom.ButtonStyles.ButtonStandalone.StateCommon.Back.GraphicsHint = Krypton.Toolkit.PaletteGraphicsHint.Inherit
        Me.kryptonPaletteCustom.ButtonStyles.ButtonStandalone.StateCommon.Back.ImageAlign = Krypton.Toolkit.PaletteRectangleAlign.Inherit
        Me.kryptonPaletteCustom.ButtonStyles.ButtonStandalone.StateCommon.Back.ImageStyle = Krypton.Toolkit.PaletteImageStyle.Inherit
        Me.kryptonPaletteCustom.ButtonStyles.ButtonStandalone.StateCommon.Border.Color1 = System.Drawing.Color.Blue
        Me.kryptonPaletteCustom.ButtonStyles.ButtonStandalone.StateCommon.Border.ColorAlign = Krypton.Toolkit.PaletteRectangleAlign.Inherit
        Me.kryptonPaletteCustom.ButtonStyles.ButtonStandalone.StateCommon.Border.ColorStyle = Krypton.Toolkit.PaletteColorStyle.Solid
        Me.kryptonPaletteCustom.ButtonStyles.ButtonStandalone.StateCommon.Border.Draw = Krypton.Toolkit.InheritBool.Inherit
        Me.kryptonPaletteCustom.ButtonStyles.ButtonStandalone.StateCommon.Border.DrawBorders = CType((((Krypton.Toolkit.PaletteDrawBorders.Top Or Krypton.Toolkit.PaletteDrawBorders.Bottom) Or Krypton.Toolkit.PaletteDrawBorders.Left) Or Krypton.Toolkit.PaletteDrawBorders.Right), Krypton.Toolkit.PaletteDrawBorders)
        Me.kryptonPaletteCustom.ButtonStyles.ButtonStandalone.StateCommon.Border.GraphicsHint = Krypton.Toolkit.PaletteGraphicsHint.AntiAlias
        Me.kryptonPaletteCustom.ButtonStyles.ButtonStandalone.StateCommon.Border.ImageAlign = Krypton.Toolkit.PaletteRectangleAlign.Inherit
        Me.kryptonPaletteCustom.ButtonStyles.ButtonStandalone.StateCommon.Border.Rounding = 12F
        Me.kryptonPaletteCustom.ButtonStyles.ButtonStandalone.StateCommon.Border.Width = 3
        Me.kryptonPaletteCustom.ButtonStyles.ButtonStandalone.StateDisabled.Back.Color1 = System.Drawing.Color.White
        Me.kryptonPaletteCustom.ButtonStyles.ButtonStandalone.StateDisabled.Back.Color2 = System.Drawing.Color.FromArgb(CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer))
        Me.kryptonPaletteCustom.ButtonStyles.ButtonStandalone.StateDisabled.Back.ColorAlign = Krypton.Toolkit.PaletteRectangleAlign.Inherit
        Me.kryptonPaletteCustom.ButtonStyles.ButtonStandalone.StateDisabled.Back.ColorStyle = Krypton.Toolkit.PaletteColorStyle.Inherit
        Me.kryptonPaletteCustom.ButtonStyles.ButtonStandalone.StateDisabled.Back.Draw = Krypton.Toolkit.InheritBool.Inherit
        Me.kryptonPaletteCustom.ButtonStyles.ButtonStandalone.StateDisabled.Back.GraphicsHint = Krypton.Toolkit.PaletteGraphicsHint.Inherit
        Me.kryptonPaletteCustom.ButtonStyles.ButtonStandalone.StateDisabled.Back.ImageAlign = Krypton.Toolkit.PaletteRectangleAlign.Inherit
        Me.kryptonPaletteCustom.ButtonStyles.ButtonStandalone.StateDisabled.Back.ImageStyle = Krypton.Toolkit.PaletteImageStyle.Inherit
        Me.kryptonPaletteCustom.ButtonStyles.ButtonStandalone.StateDisabled.Border.Color1 = System.Drawing.Color.Gray
        Me.kryptonPaletteCustom.ButtonStyles.ButtonStandalone.StateDisabled.Border.ColorAlign = Krypton.Toolkit.PaletteRectangleAlign.Inherit
        Me.kryptonPaletteCustom.ButtonStyles.ButtonStandalone.StateDisabled.Border.ColorStyle = Krypton.Toolkit.PaletteColorStyle.Inherit
        Me.kryptonPaletteCustom.ButtonStyles.ButtonStandalone.StateDisabled.Border.Draw = Krypton.Toolkit.InheritBool.Inherit
        Me.kryptonPaletteCustom.ButtonStyles.ButtonStandalone.StateDisabled.Border.DrawBorders = CType((((Krypton.Toolkit.PaletteDrawBorders.Top Or Krypton.Toolkit.PaletteDrawBorders.Bottom) Or Krypton.Toolkit.PaletteDrawBorders.Left) Or Krypton.Toolkit.PaletteDrawBorders.Right), Krypton.Toolkit.PaletteDrawBorders)
        Me.kryptonPaletteCustom.ButtonStyles.ButtonStandalone.StateDisabled.Border.GraphicsHint = Krypton.Toolkit.PaletteGraphicsHint.Inherit
        Me.kryptonPaletteCustom.ButtonStyles.ButtonStandalone.StateDisabled.Border.ImageAlign = Krypton.Toolkit.PaletteRectangleAlign.Inherit
        Me.kryptonPaletteCustom.ButtonStyles.ButtonStandalone.StatePressed.Back.Color1 = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(224, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.kryptonPaletteCustom.ButtonStyles.ButtonStandalone.StatePressed.Back.Color2 = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(192, Byte), Integer), CType(CType(128, Byte), Integer))
        Me.kryptonPaletteCustom.ButtonStyles.ButtonStandalone.StatePressed.Back.ColorAlign = Krypton.Toolkit.PaletteRectangleAlign.Inherit
        Me.kryptonPaletteCustom.ButtonStyles.ButtonStandalone.StatePressed.Back.ColorStyle = Krypton.Toolkit.PaletteColorStyle.Inherit
        Me.kryptonPaletteCustom.ButtonStyles.ButtonStandalone.StatePressed.Back.Draw = Krypton.Toolkit.InheritBool.Inherit
        Me.kryptonPaletteCustom.ButtonStyles.ButtonStandalone.StatePressed.Back.GraphicsHint = Krypton.Toolkit.PaletteGraphicsHint.Inherit
        Me.kryptonPaletteCustom.ButtonStyles.ButtonStandalone.StatePressed.Back.ImageAlign = Krypton.Toolkit.PaletteRectangleAlign.Inherit
        Me.kryptonPaletteCustom.ButtonStyles.ButtonStandalone.StatePressed.Back.ImageStyle = Krypton.Toolkit.PaletteImageStyle.Inherit
        Me.kryptonPaletteCustom.ButtonStyles.ButtonStandalone.StatePressed.Border.Color1 = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(128, Byte), Integer), CType(CType(0, Byte), Integer))
        Me.kryptonPaletteCustom.ButtonStyles.ButtonStandalone.StatePressed.Border.ColorAlign = Krypton.Toolkit.PaletteRectangleAlign.Inherit
        Me.kryptonPaletteCustom.ButtonStyles.ButtonStandalone.StatePressed.Border.ColorStyle = Krypton.Toolkit.PaletteColorStyle.Inherit
        Me.kryptonPaletteCustom.ButtonStyles.ButtonStandalone.StatePressed.Border.Draw = Krypton.Toolkit.InheritBool.Inherit
        Me.kryptonPaletteCustom.ButtonStyles.ButtonStandalone.StatePressed.Border.DrawBorders = CType((((Krypton.Toolkit.PaletteDrawBorders.Top Or Krypton.Toolkit.PaletteDrawBorders.Bottom) Or Krypton.Toolkit.PaletteDrawBorders.Left) Or Krypton.Toolkit.PaletteDrawBorders.Right), Krypton.Toolkit.PaletteDrawBorders)
        Me.kryptonPaletteCustom.ButtonStyles.ButtonStandalone.StatePressed.Border.GraphicsHint = Krypton.Toolkit.PaletteGraphicsHint.Inherit
        Me.kryptonPaletteCustom.ButtonStyles.ButtonStandalone.StatePressed.Border.ImageAlign = Krypton.Toolkit.PaletteRectangleAlign.Inherit
        Me.kryptonPaletteCustom.ButtonStyles.ButtonStandalone.StateTracking.Back.Color1 = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(192, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.kryptonPaletteCustom.ButtonStyles.ButtonStandalone.StateTracking.Back.Color2 = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(128, Byte), Integer), CType(CType(128, Byte), Integer))
        Me.kryptonPaletteCustom.ButtonStyles.ButtonStandalone.StateTracking.Back.ColorAlign = Krypton.Toolkit.PaletteRectangleAlign.Inherit
        Me.kryptonPaletteCustom.ButtonStyles.ButtonStandalone.StateTracking.Back.ColorStyle = Krypton.Toolkit.PaletteColorStyle.Inherit
        Me.kryptonPaletteCustom.ButtonStyles.ButtonStandalone.StateTracking.Back.Draw = Krypton.Toolkit.InheritBool.Inherit
        Me.kryptonPaletteCustom.ButtonStyles.ButtonStandalone.StateTracking.Back.GraphicsHint = Krypton.Toolkit.PaletteGraphicsHint.Inherit
        Me.kryptonPaletteCustom.ButtonStyles.ButtonStandalone.StateTracking.Back.ImageAlign = Krypton.Toolkit.PaletteRectangleAlign.Inherit
        Me.kryptonPaletteCustom.ButtonStyles.ButtonStandalone.StateTracking.Back.ImageStyle = Krypton.Toolkit.PaletteImageStyle.Inherit
        Me.kryptonPaletteCustom.ButtonStyles.ButtonStandalone.StateTracking.Border.Color1 = System.Drawing.Color.Red
        Me.kryptonPaletteCustom.ButtonStyles.ButtonStandalone.StateTracking.Border.ColorAlign = Krypton.Toolkit.PaletteRectangleAlign.Inherit
        Me.kryptonPaletteCustom.ButtonStyles.ButtonStandalone.StateTracking.Border.ColorStyle = Krypton.Toolkit.PaletteColorStyle.Inherit
        Me.kryptonPaletteCustom.ButtonStyles.ButtonStandalone.StateTracking.Border.Draw = Krypton.Toolkit.InheritBool.Inherit
        Me.kryptonPaletteCustom.ButtonStyles.ButtonStandalone.StateTracking.Border.DrawBorders = CType((((Krypton.Toolkit.PaletteDrawBorders.Top Or Krypton.Toolkit.PaletteDrawBorders.Bottom) Or Krypton.Toolkit.PaletteDrawBorders.Left) Or Krypton.Toolkit.PaletteDrawBorders.Right), Krypton.Toolkit.PaletteDrawBorders)
        Me.kryptonPaletteCustom.ButtonStyles.ButtonStandalone.StateTracking.Border.GraphicsHint = Krypton.Toolkit.PaletteGraphicsHint.Inherit
        Me.kryptonPaletteCustom.ButtonStyles.ButtonStandalone.StateTracking.Border.ImageAlign = Krypton.Toolkit.PaletteRectangleAlign.Inherit
        Me.kryptonPaletteCustom.HeaderStyles.HeaderPrimary.StateDisabled.Back.Color1 = System.Drawing.Color.WhiteSmoke
        Me.kryptonPaletteCustom.HeaderStyles.HeaderPrimary.StateDisabled.Back.ColorAlign = Krypton.Toolkit.PaletteRectangleAlign.Inherit
        Me.kryptonPaletteCustom.HeaderStyles.HeaderPrimary.StateDisabled.Back.ColorStyle = Krypton.Toolkit.PaletteColorStyle.Solid
        Me.kryptonPaletteCustom.HeaderStyles.HeaderPrimary.StateDisabled.Back.Draw = Krypton.Toolkit.InheritBool.Inherit
        Me.kryptonPaletteCustom.HeaderStyles.HeaderPrimary.StateDisabled.Back.GraphicsHint = Krypton.Toolkit.PaletteGraphicsHint.Inherit
        Me.kryptonPaletteCustom.HeaderStyles.HeaderPrimary.StateDisabled.Back.ImageAlign = Krypton.Toolkit.PaletteRectangleAlign.Inherit
        Me.kryptonPaletteCustom.HeaderStyles.HeaderPrimary.StateDisabled.Back.ImageStyle = Krypton.Toolkit.PaletteImageStyle.Inherit
        Me.kryptonPaletteCustom.HeaderStyles.HeaderPrimary.StateNormal.Back.Color1 = System.Drawing.Color.WhiteSmoke
        Me.kryptonPaletteCustom.HeaderStyles.HeaderPrimary.StateNormal.Back.Color2 = System.Drawing.Color.Lavender
        Me.kryptonPaletteCustom.HeaderStyles.HeaderPrimary.StateNormal.Back.ColorAlign = Krypton.Toolkit.PaletteRectangleAlign.Inherit
        Me.kryptonPaletteCustom.HeaderStyles.HeaderPrimary.StateNormal.Back.ColorAngle = 45F
        Me.kryptonPaletteCustom.HeaderStyles.HeaderPrimary.StateNormal.Back.ColorStyle = Krypton.Toolkit.PaletteColorStyle.Linear
        Me.kryptonPaletteCustom.HeaderStyles.HeaderPrimary.StateNormal.Back.Draw = Krypton.Toolkit.InheritBool.Inherit
        Me.kryptonPaletteCustom.HeaderStyles.HeaderPrimary.StateNormal.Back.GraphicsHint = Krypton.Toolkit.PaletteGraphicsHint.Inherit
        Me.kryptonPaletteCustom.HeaderStyles.HeaderPrimary.StateNormal.Back.ImageAlign = Krypton.Toolkit.PaletteRectangleAlign.Inherit
        Me.kryptonPaletteCustom.HeaderStyles.HeaderPrimary.StateNormal.Back.ImageStyle = Krypton.Toolkit.PaletteImageStyle.Inherit
        '
        'Form1
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6F, 13F)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(454, 458)
        Me.Controls.Add(Me.buttonClose)
        Me.Controls.Add(Me.groupBoxDescription)
        Me.Controls.Add(Me.groupBoxCustomControl)
        Me.Controls.Add(Me.groupBoxPalettes)
        Me.Font = New System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.MaximizeBox = False
        Me.MinimizeBox = False
        Me.MinimumSize = New System.Drawing.Size(462, 492)
        Me.Name = "Form1"
        Me.Text = "Custom Control using Renderers"
        Me.groupBoxDescription.ResumeLayout(False)
        Me.groupBoxDescription.PerformLayout()
        Me.groupBoxCustomControl.ResumeLayout(False)
        Me.groupBoxCustomControl.PerformLayout()
        Me.groupBoxPalettes.ResumeLayout(False)
        Me.groupBoxPalettes.PerformLayout()
        CType(Me.kryptonCheckSet, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
    End Sub

    Friend WithEvents groupBoxDescription As System.Windows.Forms.GroupBox
    Friend WithEvents textBox1 As System.Windows.Forms.TextBox
    Friend WithEvents groupBoxCustomControl As System.Windows.Forms.GroupBox
    Friend WithEvents checkBoxEnabled As System.Windows.Forms.CheckBox
    Friend WithEvents groupBoxPalettes As System.Windows.Forms.GroupBox
    Friend WithEvents kryptonManager As Krypton.Toolkit.KryptonManager
    Friend WithEvents kryptonCheckSet As Krypton.Toolkit.KryptonCheckSet
    Friend WithEvents buttonCustom As Krypton.Toolkit.KryptonCheckButton
    Friend WithEvents buttonSparkle As Krypton.Toolkit.KryptonCheckButton
    Friend WithEvents buttonSystem As Krypton.Toolkit.KryptonCheckButton
    Friend WithEvents buttonClose As System.Windows.Forms.Button
    Friend WithEvents myUserControl1 As MyUserControl
    Friend WithEvents radioRight As System.Windows.Forms.RadioButton
    Friend WithEvents radioLeft As System.Windows.Forms.RadioButton
    Friend WithEvents radioBottom As System.Windows.Forms.RadioButton
    Friend WithEvents radioTop As System.Windows.Forms.RadioButton
    Friend WithEvents buttonOffice2010Blue As Krypton.Toolkit.KryptonCheckButton
    Friend WithEvents buttonOffice2007Blue As Krypton.Toolkit.KryptonCheckButton
    Friend WithEvents kryptonPaletteCustom As Krypton.Toolkit.KryptonCustomPaletteBase
End Class
