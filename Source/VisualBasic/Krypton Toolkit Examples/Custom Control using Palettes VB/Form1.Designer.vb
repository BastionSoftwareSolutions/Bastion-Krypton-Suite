' VB.NET twin of Source\Krypton Toolkit Examples\Custom Control using Palettes\Form1.Designer.cs (Bastion Phase 4c).
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
        Me.kryptonManager = New Krypton.Toolkit.KryptonManager(Me.components)
        Me.buttonSparkle = New Krypton.Toolkit.KryptonCheckButton()
        Me.buttonSystem = New Krypton.Toolkit.KryptonCheckButton()
        Me.kryptonCheckSet = New Krypton.Toolkit.KryptonCheckSet(Me.components)
        Me.buttonCustom = New Krypton.Toolkit.KryptonCheckButton()
        Me.buttonOffice2010Blue = New Krypton.Toolkit.KryptonCheckButton()
        Me.buttonOffice2007Blue = New Krypton.Toolkit.KryptonCheckButton()
        Me.groupBoxPalettes = New System.Windows.Forms.GroupBox()
        Me.groupBoxCustomControl = New System.Windows.Forms.GroupBox()
        Me.checkBoxEnabled = New System.Windows.Forms.CheckBox()
        Me.myUserControl1 = New CustomControlUsingPalettes.MyUserControl()
        Me.groupBoxDescription = New System.Windows.Forms.GroupBox()
        Me.textBox1 = New System.Windows.Forms.TextBox()
        Me.buttonClose = New System.Windows.Forms.Button()
        Me.kryptonPaletteCustom = New Krypton.Toolkit.KryptonCustomPaletteBase(Me.components)
        CType(Me.kryptonCheckSet, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.groupBoxPalettes.SuspendLayout()
        Me.groupBoxCustomControl.SuspendLayout()
        Me.groupBoxDescription.SuspendLayout()
        Me.SuspendLayout()
        '
        'kryptonManager
        '
        Me.kryptonManager.GlobalPaletteMode = Krypton.Toolkit.PaletteMode.Office2007Blue
        '
        'buttonSparkle
        '
        Me.buttonSparkle.AutoSize = True
        Me.buttonSparkle.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowOnly
        Me.buttonSparkle.DialogResult = System.Windows.Forms.DialogResult.None
        Me.buttonSparkle.Location = New System.Drawing.Point(20, 98)
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
        Me.buttonSystem.Location = New System.Drawing.Point(20, 131)
        Me.buttonSystem.Name = "buttonSystem"
        Me.buttonSystem.Orientation = Krypton.Toolkit.VisualOrientation.Top
        Me.buttonSystem.Size = New System.Drawing.Size(127, 27)
        Me.buttonSystem.TabIndex = 3
        Me.buttonSystem.Values.Text = "System"
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
        'buttonCustom
        '
        Me.buttonCustom.AutoSize = True
        Me.buttonCustom.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowOnly
        Me.buttonCustom.DialogResult = System.Windows.Forms.DialogResult.None
        Me.buttonCustom.Location = New System.Drawing.Point(20, 164)
        Me.buttonCustom.Name = "buttonCustom"
        Me.buttonCustom.Orientation = Krypton.Toolkit.VisualOrientation.Top
        Me.buttonCustom.Size = New System.Drawing.Size(127, 27)
        Me.buttonCustom.TabIndex = 4
        Me.buttonCustom.Values.Text = "Custom"
        '
        'buttonOffice2010Blue
        '
        Me.buttonOffice2010Blue.AutoSize = True
        Me.buttonOffice2010Blue.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowOnly
        Me.buttonOffice2010Blue.Checked = True
        Me.buttonOffice2010Blue.DialogResult = System.Windows.Forms.DialogResult.None
        Me.buttonOffice2010Blue.Location = New System.Drawing.Point(20, 32)
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
        Me.buttonOffice2007Blue.Location = New System.Drawing.Point(20, 65)
        Me.buttonOffice2007Blue.Name = "buttonOffice2007Blue"
        Me.buttonOffice2007Blue.Orientation = Krypton.Toolkit.VisualOrientation.Top
        Me.buttonOffice2007Blue.Size = New System.Drawing.Size(127, 27)
        Me.buttonOffice2007Blue.TabIndex = 1
        Me.buttonOffice2007Blue.Values.Text = "Office 2007 - Blue"
        '
        'groupBoxPalettes
        '
        Me.groupBoxPalettes.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) Or System.Windows.Forms.AnchorStyles.Left), System.Windows.Forms.AnchorStyles)
        Me.groupBoxPalettes.Controls.Add(Me.buttonOffice2010Blue)
        Me.groupBoxPalettes.Controls.Add(Me.buttonSystem)
        Me.groupBoxPalettes.Controls.Add(Me.buttonOffice2007Blue)
        Me.groupBoxPalettes.Controls.Add(Me.buttonCustom)
        Me.groupBoxPalettes.Controls.Add(Me.buttonSparkle)
        Me.groupBoxPalettes.Location = New System.Drawing.Point(12, 12)
        Me.groupBoxPalettes.Name = "groupBoxPalettes"
        Me.groupBoxPalettes.Size = New System.Drawing.Size(170, 222)
        Me.groupBoxPalettes.TabIndex = 0
        Me.groupBoxPalettes.TabStop = False
        Me.groupBoxPalettes.Text = "Palettes"
        '
        'groupBoxCustomControl
        '
        Me.groupBoxCustomControl.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) Or System.Windows.Forms.AnchorStyles.Left) Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.groupBoxCustomControl.Controls.Add(Me.checkBoxEnabled)
        Me.groupBoxCustomControl.Controls.Add(Me.myUserControl1)
        Me.groupBoxCustomControl.Location = New System.Drawing.Point(188, 13)
        Me.groupBoxCustomControl.Name = "groupBoxCustomControl"
        Me.groupBoxCustomControl.Size = New System.Drawing.Size(262, 221)
        Me.groupBoxCustomControl.TabIndex = 1
        Me.groupBoxCustomControl.TabStop = False
        Me.groupBoxCustomControl.Text = "MyCustomControl Instance"
        '
        'checkBoxEnabled
        '
        Me.checkBoxEnabled.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Left), System.Windows.Forms.AnchorStyles)
        Me.checkBoxEnabled.AutoSize = True
        Me.checkBoxEnabled.Checked = True
        Me.checkBoxEnabled.CheckState = System.Windows.Forms.CheckState.Checked
        Me.checkBoxEnabled.Location = New System.Drawing.Point(15, 190)
        Me.checkBoxEnabled.Name = "checkBoxEnabled"
        Me.checkBoxEnabled.Size = New System.Drawing.Size(64, 17)
        Me.checkBoxEnabled.TabIndex = 1
        Me.checkBoxEnabled.Text = "Enabled"
        Me.checkBoxEnabled.UseVisualStyleBackColor = True
        '
        'myUserControl1
        '
        Me.myUserControl1.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) Or System.Windows.Forms.AnchorStyles.Left) Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.myUserControl1.Location = New System.Drawing.Point(15, 31)
        Me.myUserControl1.Name = "myUserControl1"
        Me.myUserControl1.Size = New System.Drawing.Size(228, 148)
        Me.myUserControl1.TabIndex = 0
        '
        'groupBoxDescription
        '
        Me.groupBoxDescription.Anchor = CType(((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Left) Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.groupBoxDescription.Controls.Add(Me.textBox1)
        Me.groupBoxDescription.Location = New System.Drawing.Point(12, 241)
        Me.groupBoxDescription.Name = "groupBoxDescription"
        Me.groupBoxDescription.Padding = New System.Windows.Forms.Padding(5)
        Me.groupBoxDescription.Size = New System.Drawing.Size(438, 156)
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
        Me.textBox1.Size = New System.Drawing.Size(428, 132)
        Me.textBox1.TabIndex = 0
        Me.textBox1.Text = resources.GetString("textBox1.Text")
        '
        'buttonClose
        '
        Me.buttonClose.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.buttonClose.Location = New System.Drawing.Point(375, 403)
        Me.buttonClose.Name = "buttonClose"
        Me.buttonClose.Size = New System.Drawing.Size(75, 23)
        Me.buttonClose.TabIndex = 3
        Me.buttonClose.Text = "Close"
        Me.buttonClose.UseVisualStyleBackColor = True
        '
        'kryptonPaletteCustom
        '
        Me.kryptonPaletteCustom.BaseRenderMode = Krypton.Toolkit.RendererMode.Inherit
        Me.kryptonPaletteCustom.ButtonStyles.ButtonStandalone.StateCheckedNormal.Back.Color1 = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(128, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.kryptonPaletteCustom.ButtonStyles.ButtonStandalone.StateCheckedNormal.Back.Color2 = System.Drawing.Color.Fuchsia
        Me.kryptonPaletteCustom.ButtonStyles.ButtonStandalone.StateCheckedNormal.Back.ColorAlign = Krypton.Toolkit.PaletteRectangleAlign.Inherit
        Me.kryptonPaletteCustom.ButtonStyles.ButtonStandalone.StateCheckedNormal.Back.ColorStyle = Krypton.Toolkit.PaletteColorStyle.Inherit
        Me.kryptonPaletteCustom.ButtonStyles.ButtonStandalone.StateCheckedNormal.Back.Draw = Krypton.Toolkit.InheritBool.Inherit
        Me.kryptonPaletteCustom.ButtonStyles.ButtonStandalone.StateCheckedNormal.Back.GraphicsHint = Krypton.Toolkit.PaletteGraphicsHint.Inherit
        Me.kryptonPaletteCustom.ButtonStyles.ButtonStandalone.StateCheckedNormal.Back.ImageAlign = Krypton.Toolkit.PaletteRectangleAlign.Inherit
        Me.kryptonPaletteCustom.ButtonStyles.ButtonStandalone.StateCheckedNormal.Back.ImageStyle = Krypton.Toolkit.PaletteImageStyle.Inherit
        Me.kryptonPaletteCustom.ButtonStyles.ButtonStandalone.StateCheckedNormal.Border.Color1 = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(192, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.kryptonPaletteCustom.ButtonStyles.ButtonStandalone.StateCheckedNormal.Border.ColorAlign = Krypton.Toolkit.PaletteRectangleAlign.Inherit
        Me.kryptonPaletteCustom.ButtonStyles.ButtonStandalone.StateCheckedNormal.Border.ColorStyle = Krypton.Toolkit.PaletteColorStyle.Inherit
        Me.kryptonPaletteCustom.ButtonStyles.ButtonStandalone.StateCheckedNormal.Border.Draw = Krypton.Toolkit.InheritBool.Inherit
        Me.kryptonPaletteCustom.ButtonStyles.ButtonStandalone.StateCheckedNormal.Border.DrawBorders = CType((((Krypton.Toolkit.PaletteDrawBorders.Top Or Krypton.Toolkit.PaletteDrawBorders.Bottom) Or Krypton.Toolkit.PaletteDrawBorders.Left) Or Krypton.Toolkit.PaletteDrawBorders.Right), Krypton.Toolkit.PaletteDrawBorders)
        Me.kryptonPaletteCustom.ButtonStyles.ButtonStandalone.StateCheckedNormal.Border.GraphicsHint = Krypton.Toolkit.PaletteGraphicsHint.Inherit
        Me.kryptonPaletteCustom.ButtonStyles.ButtonStandalone.StateCheckedNormal.Border.ImageAlign = Krypton.Toolkit.PaletteRectangleAlign.Inherit
        Me.kryptonPaletteCustom.ButtonStyles.ButtonStandalone.StateCheckedNormal.Content.Draw = Krypton.Toolkit.InheritBool.Inherit
        Me.kryptonPaletteCustom.ButtonStyles.ButtonStandalone.StateCheckedNormal.Content.DrawFocus = Krypton.Toolkit.InheritBool.Inherit
        Me.kryptonPaletteCustom.ButtonStyles.ButtonStandalone.StateCheckedNormal.Content.Padding = New System.Windows.Forms.Padding(-1)
        Me.kryptonPaletteCustom.ButtonStyles.ButtonStandalone.StateCheckedNormal.Content.ShortText.Color1 = System.Drawing.Color.White
        Me.kryptonPaletteCustom.ButtonStyles.ButtonStandalone.StateCheckedNormal.Content.ShortText.ColorAlign = Krypton.Toolkit.PaletteRectangleAlign.Inherit
        Me.kryptonPaletteCustom.ButtonStyles.ButtonStandalone.StateCheckedNormal.Content.ShortText.ColorStyle = Krypton.Toolkit.PaletteColorStyle.Inherit
        Me.kryptonPaletteCustom.ButtonStyles.ButtonStandalone.StateCheckedNormal.Content.ShortText.Font = New System.Drawing.Font("Berlin Sans FB", 9F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.kryptonPaletteCustom.ButtonStyles.ButtonStandalone.StateCheckedNormal.Content.ShortText.Hint = Krypton.Toolkit.PaletteTextHint.Inherit
        Me.kryptonPaletteCustom.ButtonStyles.ButtonStandalone.StateCheckedNormal.Content.ShortText.ImageAlign = Krypton.Toolkit.PaletteRectangleAlign.Inherit
        Me.kryptonPaletteCustom.ButtonStyles.ButtonStandalone.StateCheckedNormal.Content.ShortText.ImageStyle = Krypton.Toolkit.PaletteImageStyle.Inherit
        Me.kryptonPaletteCustom.ButtonStyles.ButtonStandalone.StateCheckedNormal.Content.ShortText.MultiLine = Krypton.Toolkit.InheritBool.Inherit
        Me.kryptonPaletteCustom.ButtonStyles.ButtonStandalone.StateCheckedNormal.Content.ShortText.MultiLineH = Krypton.Toolkit.PaletteRelativeAlign.Inherit
        Me.kryptonPaletteCustom.ButtonStyles.ButtonStandalone.StateCheckedNormal.Content.ShortText.Prefix = Krypton.Toolkit.PaletteTextHotkeyPrefix.Inherit
        Me.kryptonPaletteCustom.ButtonStyles.ButtonStandalone.StateCheckedNormal.Content.ShortText.TextH = Krypton.Toolkit.PaletteRelativeAlign.Inherit
        Me.kryptonPaletteCustom.ButtonStyles.ButtonStandalone.StateCheckedNormal.Content.ShortText.TextV = Krypton.Toolkit.PaletteRelativeAlign.Inherit
        Me.kryptonPaletteCustom.ButtonStyles.ButtonStandalone.StateCheckedNormal.Content.ShortText.Trim = Krypton.Toolkit.PaletteTextTrim.Inherit
        Me.kryptonPaletteCustom.ButtonStyles.ButtonStandalone.StateCheckedPressed.Back.Color1 = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(128, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.kryptonPaletteCustom.ButtonStyles.ButtonStandalone.StateCheckedPressed.Back.Color2 = System.Drawing.Color.Fuchsia
        Me.kryptonPaletteCustom.ButtonStyles.ButtonStandalone.StateCheckedPressed.Back.ColorAlign = Krypton.Toolkit.PaletteRectangleAlign.Inherit
        Me.kryptonPaletteCustom.ButtonStyles.ButtonStandalone.StateCheckedPressed.Back.ColorStyle = Krypton.Toolkit.PaletteColorStyle.Inherit
        Me.kryptonPaletteCustom.ButtonStyles.ButtonStandalone.StateCheckedPressed.Back.Draw = Krypton.Toolkit.InheritBool.Inherit
        Me.kryptonPaletteCustom.ButtonStyles.ButtonStandalone.StateCheckedPressed.Back.GraphicsHint = Krypton.Toolkit.PaletteGraphicsHint.Inherit
        Me.kryptonPaletteCustom.ButtonStyles.ButtonStandalone.StateCheckedPressed.Back.ImageAlign = Krypton.Toolkit.PaletteRectangleAlign.Inherit
        Me.kryptonPaletteCustom.ButtonStyles.ButtonStandalone.StateCheckedPressed.Back.ImageStyle = Krypton.Toolkit.PaletteImageStyle.Inherit
        Me.kryptonPaletteCustom.ButtonStyles.ButtonStandalone.StateCheckedPressed.Border.Color1 = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(192, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.kryptonPaletteCustom.ButtonStyles.ButtonStandalone.StateCheckedPressed.Border.ColorAlign = Krypton.Toolkit.PaletteRectangleAlign.Inherit
        Me.kryptonPaletteCustom.ButtonStyles.ButtonStandalone.StateCheckedPressed.Border.ColorStyle = Krypton.Toolkit.PaletteColorStyle.Inherit
        Me.kryptonPaletteCustom.ButtonStyles.ButtonStandalone.StateCheckedPressed.Border.Draw = Krypton.Toolkit.InheritBool.Inherit
        Me.kryptonPaletteCustom.ButtonStyles.ButtonStandalone.StateCheckedPressed.Border.DrawBorders = CType((((Krypton.Toolkit.PaletteDrawBorders.Top Or Krypton.Toolkit.PaletteDrawBorders.Bottom) Or Krypton.Toolkit.PaletteDrawBorders.Left) Or Krypton.Toolkit.PaletteDrawBorders.Right), Krypton.Toolkit.PaletteDrawBorders)
        Me.kryptonPaletteCustom.ButtonStyles.ButtonStandalone.StateCheckedPressed.Border.GraphicsHint = Krypton.Toolkit.PaletteGraphicsHint.Inherit
        Me.kryptonPaletteCustom.ButtonStyles.ButtonStandalone.StateCheckedPressed.Border.ImageAlign = Krypton.Toolkit.PaletteRectangleAlign.Inherit
        Me.kryptonPaletteCustom.ButtonStyles.ButtonStandalone.StateCheckedPressed.Content.Draw = Krypton.Toolkit.InheritBool.Inherit
        Me.kryptonPaletteCustom.ButtonStyles.ButtonStandalone.StateCheckedPressed.Content.DrawFocus = Krypton.Toolkit.InheritBool.Inherit
        Me.kryptonPaletteCustom.ButtonStyles.ButtonStandalone.StateCheckedPressed.Content.Padding = New System.Windows.Forms.Padding(-1)
        Me.kryptonPaletteCustom.ButtonStyles.ButtonStandalone.StateCheckedPressed.Content.ShortText.Color1 = System.Drawing.Color.White
        Me.kryptonPaletteCustom.ButtonStyles.ButtonStandalone.StateCheckedPressed.Content.ShortText.ColorAlign = Krypton.Toolkit.PaletteRectangleAlign.Inherit
        Me.kryptonPaletteCustom.ButtonStyles.ButtonStandalone.StateCheckedPressed.Content.ShortText.ColorStyle = Krypton.Toolkit.PaletteColorStyle.Inherit
        Me.kryptonPaletteCustom.ButtonStyles.ButtonStandalone.StateCheckedPressed.Content.ShortText.Font = New System.Drawing.Font("Berlin Sans FB", 9F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.kryptonPaletteCustom.ButtonStyles.ButtonStandalone.StateCheckedPressed.Content.ShortText.Hint = Krypton.Toolkit.PaletteTextHint.Inherit
        Me.kryptonPaletteCustom.ButtonStyles.ButtonStandalone.StateCheckedPressed.Content.ShortText.ImageAlign = Krypton.Toolkit.PaletteRectangleAlign.Inherit
        Me.kryptonPaletteCustom.ButtonStyles.ButtonStandalone.StateCheckedPressed.Content.ShortText.ImageStyle = Krypton.Toolkit.PaletteImageStyle.Inherit
        Me.kryptonPaletteCustom.ButtonStyles.ButtonStandalone.StateCheckedPressed.Content.ShortText.MultiLine = Krypton.Toolkit.InheritBool.Inherit
        Me.kryptonPaletteCustom.ButtonStyles.ButtonStandalone.StateCheckedPressed.Content.ShortText.MultiLineH = Krypton.Toolkit.PaletteRelativeAlign.Inherit
        Me.kryptonPaletteCustom.ButtonStyles.ButtonStandalone.StateCheckedPressed.Content.ShortText.Prefix = Krypton.Toolkit.PaletteTextHotkeyPrefix.Inherit
        Me.kryptonPaletteCustom.ButtonStyles.ButtonStandalone.StateCheckedPressed.Content.ShortText.TextH = Krypton.Toolkit.PaletteRelativeAlign.Inherit
        Me.kryptonPaletteCustom.ButtonStyles.ButtonStandalone.StateCheckedPressed.Content.ShortText.TextV = Krypton.Toolkit.PaletteRelativeAlign.Inherit
        Me.kryptonPaletteCustom.ButtonStyles.ButtonStandalone.StateCheckedPressed.Content.ShortText.Trim = Krypton.Toolkit.PaletteTextTrim.Inherit
        Me.kryptonPaletteCustom.ButtonStyles.ButtonStandalone.StateCheckedTracking.Back.Color1 = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(128, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.kryptonPaletteCustom.ButtonStyles.ButtonStandalone.StateCheckedTracking.Back.Color2 = System.Drawing.Color.Fuchsia
        Me.kryptonPaletteCustom.ButtonStyles.ButtonStandalone.StateCheckedTracking.Back.ColorAlign = Krypton.Toolkit.PaletteRectangleAlign.Inherit
        Me.kryptonPaletteCustom.ButtonStyles.ButtonStandalone.StateCheckedTracking.Back.ColorStyle = Krypton.Toolkit.PaletteColorStyle.Inherit
        Me.kryptonPaletteCustom.ButtonStyles.ButtonStandalone.StateCheckedTracking.Back.Draw = Krypton.Toolkit.InheritBool.Inherit
        Me.kryptonPaletteCustom.ButtonStyles.ButtonStandalone.StateCheckedTracking.Back.GraphicsHint = Krypton.Toolkit.PaletteGraphicsHint.Inherit
        Me.kryptonPaletteCustom.ButtonStyles.ButtonStandalone.StateCheckedTracking.Back.ImageAlign = Krypton.Toolkit.PaletteRectangleAlign.Inherit
        Me.kryptonPaletteCustom.ButtonStyles.ButtonStandalone.StateCheckedTracking.Back.ImageStyle = Krypton.Toolkit.PaletteImageStyle.Inherit
        Me.kryptonPaletteCustom.ButtonStyles.ButtonStandalone.StateCheckedTracking.Border.Color1 = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(192, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.kryptonPaletteCustom.ButtonStyles.ButtonStandalone.StateCheckedTracking.Border.ColorAlign = Krypton.Toolkit.PaletteRectangleAlign.Inherit
        Me.kryptonPaletteCustom.ButtonStyles.ButtonStandalone.StateCheckedTracking.Border.ColorStyle = Krypton.Toolkit.PaletteColorStyle.Inherit
        Me.kryptonPaletteCustom.ButtonStyles.ButtonStandalone.StateCheckedTracking.Border.Draw = Krypton.Toolkit.InheritBool.Inherit
        Me.kryptonPaletteCustom.ButtonStyles.ButtonStandalone.StateCheckedTracking.Border.DrawBorders = CType((((Krypton.Toolkit.PaletteDrawBorders.Top Or Krypton.Toolkit.PaletteDrawBorders.Bottom) Or Krypton.Toolkit.PaletteDrawBorders.Left) Or Krypton.Toolkit.PaletteDrawBorders.Right), Krypton.Toolkit.PaletteDrawBorders)
        Me.kryptonPaletteCustom.ButtonStyles.ButtonStandalone.StateCheckedTracking.Border.GraphicsHint = Krypton.Toolkit.PaletteGraphicsHint.Inherit
        Me.kryptonPaletteCustom.ButtonStyles.ButtonStandalone.StateCheckedTracking.Border.ImageAlign = Krypton.Toolkit.PaletteRectangleAlign.Inherit
        Me.kryptonPaletteCustom.ButtonStyles.ButtonStandalone.StateCheckedTracking.Content.Draw = Krypton.Toolkit.InheritBool.Inherit
        Me.kryptonPaletteCustom.ButtonStyles.ButtonStandalone.StateCheckedTracking.Content.DrawFocus = Krypton.Toolkit.InheritBool.Inherit
        Me.kryptonPaletteCustom.ButtonStyles.ButtonStandalone.StateCheckedTracking.Content.Padding = New System.Windows.Forms.Padding(-1)
        Me.kryptonPaletteCustom.ButtonStyles.ButtonStandalone.StateCheckedTracking.Content.ShortText.Color1 = System.Drawing.Color.White
        Me.kryptonPaletteCustom.ButtonStyles.ButtonStandalone.StateCheckedTracking.Content.ShortText.ColorAlign = Krypton.Toolkit.PaletteRectangleAlign.Inherit
        Me.kryptonPaletteCustom.ButtonStyles.ButtonStandalone.StateCheckedTracking.Content.ShortText.ColorStyle = Krypton.Toolkit.PaletteColorStyle.Inherit
        Me.kryptonPaletteCustom.ButtonStyles.ButtonStandalone.StateCheckedTracking.Content.ShortText.Font = New System.Drawing.Font("Berlin Sans FB", 9F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.kryptonPaletteCustom.ButtonStyles.ButtonStandalone.StateCheckedTracking.Content.ShortText.Hint = Krypton.Toolkit.PaletteTextHint.Inherit
        Me.kryptonPaletteCustom.ButtonStyles.ButtonStandalone.StateCheckedTracking.Content.ShortText.ImageAlign = Krypton.Toolkit.PaletteRectangleAlign.Inherit
        Me.kryptonPaletteCustom.ButtonStyles.ButtonStandalone.StateCheckedTracking.Content.ShortText.ImageStyle = Krypton.Toolkit.PaletteImageStyle.Inherit
        Me.kryptonPaletteCustom.ButtonStyles.ButtonStandalone.StateCheckedTracking.Content.ShortText.MultiLine = Krypton.Toolkit.InheritBool.Inherit
        Me.kryptonPaletteCustom.ButtonStyles.ButtonStandalone.StateCheckedTracking.Content.ShortText.MultiLineH = Krypton.Toolkit.PaletteRelativeAlign.Inherit
        Me.kryptonPaletteCustom.ButtonStyles.ButtonStandalone.StateCheckedTracking.Content.ShortText.Prefix = Krypton.Toolkit.PaletteTextHotkeyPrefix.Inherit
        Me.kryptonPaletteCustom.ButtonStyles.ButtonStandalone.StateCheckedTracking.Content.ShortText.TextH = Krypton.Toolkit.PaletteRelativeAlign.Inherit
        Me.kryptonPaletteCustom.ButtonStyles.ButtonStandalone.StateCheckedTracking.Content.ShortText.TextV = Krypton.Toolkit.PaletteRelativeAlign.Inherit
        Me.kryptonPaletteCustom.ButtonStyles.ButtonStandalone.StateCheckedTracking.Content.ShortText.Trim = Krypton.Toolkit.PaletteTextTrim.Inherit
        Me.kryptonPaletteCustom.ButtonStyles.ButtonStandalone.StateCommon.Back.ColorAlign = Krypton.Toolkit.PaletteRectangleAlign.Inherit
        Me.kryptonPaletteCustom.ButtonStyles.ButtonStandalone.StateCommon.Back.ColorAngle = 60F
        Me.kryptonPaletteCustom.ButtonStyles.ButtonStandalone.StateCommon.Back.ColorStyle = Krypton.Toolkit.PaletteColorStyle.Inherit
        Me.kryptonPaletteCustom.ButtonStyles.ButtonStandalone.StateCommon.Back.Draw = Krypton.Toolkit.InheritBool.Inherit
        Me.kryptonPaletteCustom.ButtonStyles.ButtonStandalone.StateCommon.Back.GraphicsHint = Krypton.Toolkit.PaletteGraphicsHint.Inherit
        Me.kryptonPaletteCustom.ButtonStyles.ButtonStandalone.StateCommon.Back.ImageAlign = Krypton.Toolkit.PaletteRectangleAlign.Inherit
        Me.kryptonPaletteCustom.ButtonStyles.ButtonStandalone.StateCommon.Back.ImageStyle = Krypton.Toolkit.PaletteImageStyle.Inherit
        Me.kryptonPaletteCustom.ButtonStyles.ButtonStandalone.StateDisabled.Back.Color1 = System.Drawing.Color.Gray
        Me.kryptonPaletteCustom.ButtonStyles.ButtonStandalone.StateDisabled.Back.Color2 = System.Drawing.Color.Black
        Me.kryptonPaletteCustom.ButtonStyles.ButtonStandalone.StateDisabled.Back.ColorAlign = Krypton.Toolkit.PaletteRectangleAlign.Inherit
        Me.kryptonPaletteCustom.ButtonStyles.ButtonStandalone.StateDisabled.Back.ColorStyle = Krypton.Toolkit.PaletteColorStyle.Inherit
        Me.kryptonPaletteCustom.ButtonStyles.ButtonStandalone.StateDisabled.Back.Draw = Krypton.Toolkit.InheritBool.Inherit
        Me.kryptonPaletteCustom.ButtonStyles.ButtonStandalone.StateDisabled.Back.GraphicsHint = Krypton.Toolkit.PaletteGraphicsHint.Inherit
        Me.kryptonPaletteCustom.ButtonStyles.ButtonStandalone.StateDisabled.Back.ImageAlign = Krypton.Toolkit.PaletteRectangleAlign.Inherit
        Me.kryptonPaletteCustom.ButtonStyles.ButtonStandalone.StateDisabled.Back.ImageStyle = Krypton.Toolkit.PaletteImageStyle.Inherit
        Me.kryptonPaletteCustom.ButtonStyles.ButtonStandalone.StateDisabled.Border.Color1 = System.Drawing.Color.Black
        Me.kryptonPaletteCustom.ButtonStyles.ButtonStandalone.StateDisabled.Border.ColorAlign = Krypton.Toolkit.PaletteRectangleAlign.Inherit
        Me.kryptonPaletteCustom.ButtonStyles.ButtonStandalone.StateDisabled.Border.ColorStyle = Krypton.Toolkit.PaletteColorStyle.Inherit
        Me.kryptonPaletteCustom.ButtonStyles.ButtonStandalone.StateDisabled.Border.Draw = Krypton.Toolkit.InheritBool.Inherit
        Me.kryptonPaletteCustom.ButtonStyles.ButtonStandalone.StateDisabled.Border.DrawBorders = CType((((Krypton.Toolkit.PaletteDrawBorders.Top Or Krypton.Toolkit.PaletteDrawBorders.Bottom) Or Krypton.Toolkit.PaletteDrawBorders.Left) Or Krypton.Toolkit.PaletteDrawBorders.Right), Krypton.Toolkit.PaletteDrawBorders)
        Me.kryptonPaletteCustom.ButtonStyles.ButtonStandalone.StateDisabled.Border.GraphicsHint = Krypton.Toolkit.PaletteGraphicsHint.Inherit
        Me.kryptonPaletteCustom.ButtonStyles.ButtonStandalone.StateDisabled.Border.ImageAlign = Krypton.Toolkit.PaletteRectangleAlign.Inherit
        Me.kryptonPaletteCustom.ButtonStyles.ButtonStandalone.StateDisabled.Content.Draw = Krypton.Toolkit.InheritBool.Inherit
        Me.kryptonPaletteCustom.ButtonStyles.ButtonStandalone.StateDisabled.Content.DrawFocus = Krypton.Toolkit.InheritBool.Inherit
        Me.kryptonPaletteCustom.ButtonStyles.ButtonStandalone.StateDisabled.Content.Padding = New System.Windows.Forms.Padding(-1)
        Me.kryptonPaletteCustom.ButtonStyles.ButtonStandalone.StateDisabled.Content.ShortText.Color1 = System.Drawing.Color.Gainsboro
        Me.kryptonPaletteCustom.ButtonStyles.ButtonStandalone.StateDisabled.Content.ShortText.ColorAlign = Krypton.Toolkit.PaletteRectangleAlign.Inherit
        Me.kryptonPaletteCustom.ButtonStyles.ButtonStandalone.StateDisabled.Content.ShortText.ColorStyle = Krypton.Toolkit.PaletteColorStyle.Inherit
        Me.kryptonPaletteCustom.ButtonStyles.ButtonStandalone.StateDisabled.Content.ShortText.Hint = Krypton.Toolkit.PaletteTextHint.Inherit
        Me.kryptonPaletteCustom.ButtonStyles.ButtonStandalone.StateDisabled.Content.ShortText.ImageAlign = Krypton.Toolkit.PaletteRectangleAlign.Inherit
        Me.kryptonPaletteCustom.ButtonStyles.ButtonStandalone.StateDisabled.Content.ShortText.ImageStyle = Krypton.Toolkit.PaletteImageStyle.Inherit
        Me.kryptonPaletteCustom.ButtonStyles.ButtonStandalone.StateDisabled.Content.ShortText.MultiLine = Krypton.Toolkit.InheritBool.Inherit
        Me.kryptonPaletteCustom.ButtonStyles.ButtonStandalone.StateDisabled.Content.ShortText.MultiLineH = Krypton.Toolkit.PaletteRelativeAlign.Inherit
        Me.kryptonPaletteCustom.ButtonStyles.ButtonStandalone.StateDisabled.Content.ShortText.Prefix = Krypton.Toolkit.PaletteTextHotkeyPrefix.Inherit
        Me.kryptonPaletteCustom.ButtonStyles.ButtonStandalone.StateDisabled.Content.ShortText.TextH = Krypton.Toolkit.PaletteRelativeAlign.Inherit
        Me.kryptonPaletteCustom.ButtonStyles.ButtonStandalone.StateDisabled.Content.ShortText.TextV = Krypton.Toolkit.PaletteRelativeAlign.Inherit
        Me.kryptonPaletteCustom.ButtonStyles.ButtonStandalone.StateDisabled.Content.ShortText.Trim = Krypton.Toolkit.PaletteTextTrim.Inherit
        Me.kryptonPaletteCustom.ButtonStyles.ButtonStandalone.StateNormal.Back.Color1 = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(128, Byte), Integer))
        Me.kryptonPaletteCustom.ButtonStyles.ButtonStandalone.StateNormal.Back.Color2 = System.Drawing.Color.Yellow
        Me.kryptonPaletteCustom.ButtonStyles.ButtonStandalone.StateNormal.Back.ColorAlign = Krypton.Toolkit.PaletteRectangleAlign.Inherit
        Me.kryptonPaletteCustom.ButtonStyles.ButtonStandalone.StateNormal.Back.ColorStyle = Krypton.Toolkit.PaletteColorStyle.Inherit
        Me.kryptonPaletteCustom.ButtonStyles.ButtonStandalone.StateNormal.Back.Draw = Krypton.Toolkit.InheritBool.Inherit
        Me.kryptonPaletteCustom.ButtonStyles.ButtonStandalone.StateNormal.Back.GraphicsHint = Krypton.Toolkit.PaletteGraphicsHint.Inherit
        Me.kryptonPaletteCustom.ButtonStyles.ButtonStandalone.StateNormal.Back.ImageAlign = Krypton.Toolkit.PaletteRectangleAlign.Inherit
        Me.kryptonPaletteCustom.ButtonStyles.ButtonStandalone.StateNormal.Back.ImageStyle = Krypton.Toolkit.PaletteImageStyle.Inherit
        Me.kryptonPaletteCustom.ButtonStyles.ButtonStandalone.StateNormal.Border.Color1 = System.Drawing.Color.Olive
        Me.kryptonPaletteCustom.ButtonStyles.ButtonStandalone.StateNormal.Border.ColorAlign = Krypton.Toolkit.PaletteRectangleAlign.Inherit
        Me.kryptonPaletteCustom.ButtonStyles.ButtonStandalone.StateNormal.Border.ColorStyle = Krypton.Toolkit.PaletteColorStyle.Inherit
        Me.kryptonPaletteCustom.ButtonStyles.ButtonStandalone.StateNormal.Border.Draw = Krypton.Toolkit.InheritBool.Inherit
        Me.kryptonPaletteCustom.ButtonStyles.ButtonStandalone.StateNormal.Border.DrawBorders = CType((((Krypton.Toolkit.PaletteDrawBorders.Top Or Krypton.Toolkit.PaletteDrawBorders.Bottom) Or Krypton.Toolkit.PaletteDrawBorders.Left) Or Krypton.Toolkit.PaletteDrawBorders.Right), Krypton.Toolkit.PaletteDrawBorders)
        Me.kryptonPaletteCustom.ButtonStyles.ButtonStandalone.StateNormal.Border.GraphicsHint = Krypton.Toolkit.PaletteGraphicsHint.Inherit
        Me.kryptonPaletteCustom.ButtonStyles.ButtonStandalone.StateNormal.Border.ImageAlign = Krypton.Toolkit.PaletteRectangleAlign.Inherit
        Me.kryptonPaletteCustom.ButtonStyles.ButtonStandalone.StateNormal.Content.Draw = Krypton.Toolkit.InheritBool.Inherit
        Me.kryptonPaletteCustom.ButtonStyles.ButtonStandalone.StateNormal.Content.DrawFocus = Krypton.Toolkit.InheritBool.Inherit
        Me.kryptonPaletteCustom.ButtonStyles.ButtonStandalone.StateNormal.Content.Padding = New System.Windows.Forms.Padding(-1)
        Me.kryptonPaletteCustom.ButtonStyles.ButtonStandalone.StateNormal.Content.ShortText.ColorAlign = Krypton.Toolkit.PaletteRectangleAlign.Inherit
        Me.kryptonPaletteCustom.ButtonStyles.ButtonStandalone.StateNormal.Content.ShortText.ColorStyle = Krypton.Toolkit.PaletteColorStyle.Inherit
        Me.kryptonPaletteCustom.ButtonStyles.ButtonStandalone.StateNormal.Content.ShortText.Font = New System.Drawing.Font("Berlin Sans FB", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.kryptonPaletteCustom.ButtonStyles.ButtonStandalone.StateNormal.Content.ShortText.Hint = Krypton.Toolkit.PaletteTextHint.Inherit
        Me.kryptonPaletteCustom.ButtonStyles.ButtonStandalone.StateNormal.Content.ShortText.ImageAlign = Krypton.Toolkit.PaletteRectangleAlign.Inherit
        Me.kryptonPaletteCustom.ButtonStyles.ButtonStandalone.StateNormal.Content.ShortText.ImageStyle = Krypton.Toolkit.PaletteImageStyle.Inherit
        Me.kryptonPaletteCustom.ButtonStyles.ButtonStandalone.StateNormal.Content.ShortText.MultiLine = Krypton.Toolkit.InheritBool.Inherit
        Me.kryptonPaletteCustom.ButtonStyles.ButtonStandalone.StateNormal.Content.ShortText.MultiLineH = Krypton.Toolkit.PaletteRelativeAlign.Inherit
        Me.kryptonPaletteCustom.ButtonStyles.ButtonStandalone.StateNormal.Content.ShortText.Prefix = Krypton.Toolkit.PaletteTextHotkeyPrefix.Inherit
        Me.kryptonPaletteCustom.ButtonStyles.ButtonStandalone.StateNormal.Content.ShortText.TextH = Krypton.Toolkit.PaletteRelativeAlign.Inherit
        Me.kryptonPaletteCustom.ButtonStyles.ButtonStandalone.StateNormal.Content.ShortText.TextV = Krypton.Toolkit.PaletteRelativeAlign.Inherit
        Me.kryptonPaletteCustom.ButtonStyles.ButtonStandalone.StateNormal.Content.ShortText.Trim = Krypton.Toolkit.PaletteTextTrim.Inherit
        Me.kryptonPaletteCustom.ButtonStyles.ButtonStandalone.StatePressed.Back.Color1 = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(128, Byte), Integer), CType(CType(128, Byte), Integer))
        Me.kryptonPaletteCustom.ButtonStyles.ButtonStandalone.StatePressed.Back.Color2 = System.Drawing.Color.Red
        Me.kryptonPaletteCustom.ButtonStyles.ButtonStandalone.StatePressed.Back.ColorAlign = Krypton.Toolkit.PaletteRectangleAlign.Inherit
        Me.kryptonPaletteCustom.ButtonStyles.ButtonStandalone.StatePressed.Back.ColorStyle = Krypton.Toolkit.PaletteColorStyle.Inherit
        Me.kryptonPaletteCustom.ButtonStyles.ButtonStandalone.StatePressed.Back.Draw = Krypton.Toolkit.InheritBool.Inherit
        Me.kryptonPaletteCustom.ButtonStyles.ButtonStandalone.StatePressed.Back.GraphicsHint = Krypton.Toolkit.PaletteGraphicsHint.Inherit
        Me.kryptonPaletteCustom.ButtonStyles.ButtonStandalone.StatePressed.Back.ImageAlign = Krypton.Toolkit.PaletteRectangleAlign.Inherit
        Me.kryptonPaletteCustom.ButtonStyles.ButtonStandalone.StatePressed.Back.ImageStyle = Krypton.Toolkit.PaletteImageStyle.Inherit
        Me.kryptonPaletteCustom.ButtonStyles.ButtonStandalone.StatePressed.Border.Color1 = System.Drawing.Color.FromArgb(CType(CType(192, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer))
        Me.kryptonPaletteCustom.ButtonStyles.ButtonStandalone.StatePressed.Border.ColorAlign = Krypton.Toolkit.PaletteRectangleAlign.Inherit
        Me.kryptonPaletteCustom.ButtonStyles.ButtonStandalone.StatePressed.Border.ColorStyle = Krypton.Toolkit.PaletteColorStyle.Inherit
        Me.kryptonPaletteCustom.ButtonStyles.ButtonStandalone.StatePressed.Border.Draw = Krypton.Toolkit.InheritBool.Inherit
        Me.kryptonPaletteCustom.ButtonStyles.ButtonStandalone.StatePressed.Border.DrawBorders = CType((((Krypton.Toolkit.PaletteDrawBorders.Top Or Krypton.Toolkit.PaletteDrawBorders.Bottom) Or Krypton.Toolkit.PaletteDrawBorders.Left) Or Krypton.Toolkit.PaletteDrawBorders.Right), Krypton.Toolkit.PaletteDrawBorders)
        Me.kryptonPaletteCustom.ButtonStyles.ButtonStandalone.StatePressed.Border.GraphicsHint = Krypton.Toolkit.PaletteGraphicsHint.Inherit
        Me.kryptonPaletteCustom.ButtonStyles.ButtonStandalone.StatePressed.Border.ImageAlign = Krypton.Toolkit.PaletteRectangleAlign.Inherit
        Me.kryptonPaletteCustom.ButtonStyles.ButtonStandalone.StatePressed.Content.Draw = Krypton.Toolkit.InheritBool.Inherit
        Me.kryptonPaletteCustom.ButtonStyles.ButtonStandalone.StatePressed.Content.DrawFocus = Krypton.Toolkit.InheritBool.Inherit
        Me.kryptonPaletteCustom.ButtonStyles.ButtonStandalone.StatePressed.Content.Padding = New System.Windows.Forms.Padding(-1)
        Me.kryptonPaletteCustom.ButtonStyles.ButtonStandalone.StatePressed.Content.ShortText.Color1 = System.Drawing.Color.White
        Me.kryptonPaletteCustom.ButtonStyles.ButtonStandalone.StatePressed.Content.ShortText.ColorAlign = Krypton.Toolkit.PaletteRectangleAlign.Inherit
        Me.kryptonPaletteCustom.ButtonStyles.ButtonStandalone.StatePressed.Content.ShortText.ColorStyle = Krypton.Toolkit.PaletteColorStyle.Inherit
        Me.kryptonPaletteCustom.ButtonStyles.ButtonStandalone.StatePressed.Content.ShortText.Font = New System.Drawing.Font("Berlin Sans FB", 9F, CType((System.Drawing.FontStyle.Bold Or System.Drawing.FontStyle.Italic), System.Drawing.FontStyle), System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.kryptonPaletteCustom.ButtonStyles.ButtonStandalone.StatePressed.Content.ShortText.Hint = Krypton.Toolkit.PaletteTextHint.Inherit
        Me.kryptonPaletteCustom.ButtonStyles.ButtonStandalone.StatePressed.Content.ShortText.ImageAlign = Krypton.Toolkit.PaletteRectangleAlign.Inherit
        Me.kryptonPaletteCustom.ButtonStyles.ButtonStandalone.StatePressed.Content.ShortText.ImageStyle = Krypton.Toolkit.PaletteImageStyle.Inherit
        Me.kryptonPaletteCustom.ButtonStyles.ButtonStandalone.StatePressed.Content.ShortText.MultiLine = Krypton.Toolkit.InheritBool.Inherit
        Me.kryptonPaletteCustom.ButtonStyles.ButtonStandalone.StatePressed.Content.ShortText.MultiLineH = Krypton.Toolkit.PaletteRelativeAlign.Inherit
        Me.kryptonPaletteCustom.ButtonStyles.ButtonStandalone.StatePressed.Content.ShortText.Prefix = Krypton.Toolkit.PaletteTextHotkeyPrefix.Inherit
        Me.kryptonPaletteCustom.ButtonStyles.ButtonStandalone.StatePressed.Content.ShortText.TextH = Krypton.Toolkit.PaletteRelativeAlign.Inherit
        Me.kryptonPaletteCustom.ButtonStyles.ButtonStandalone.StatePressed.Content.ShortText.TextV = Krypton.Toolkit.PaletteRelativeAlign.Inherit
        Me.kryptonPaletteCustom.ButtonStyles.ButtonStandalone.StatePressed.Content.ShortText.Trim = Krypton.Toolkit.PaletteTextTrim.Inherit
        Me.kryptonPaletteCustom.ButtonStyles.ButtonStandalone.StateTracking.Back.Color1 = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(192, Byte), Integer), CType(CType(128, Byte), Integer))
        Me.kryptonPaletteCustom.ButtonStyles.ButtonStandalone.StateTracking.Back.Color2 = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(128, Byte), Integer), CType(CType(0, Byte), Integer))
        Me.kryptonPaletteCustom.ButtonStyles.ButtonStandalone.StateTracking.Back.ColorAlign = Krypton.Toolkit.PaletteRectangleAlign.Inherit
        Me.kryptonPaletteCustom.ButtonStyles.ButtonStandalone.StateTracking.Back.ColorStyle = Krypton.Toolkit.PaletteColorStyle.Inherit
        Me.kryptonPaletteCustom.ButtonStyles.ButtonStandalone.StateTracking.Back.Draw = Krypton.Toolkit.InheritBool.Inherit
        Me.kryptonPaletteCustom.ButtonStyles.ButtonStandalone.StateTracking.Back.GraphicsHint = Krypton.Toolkit.PaletteGraphicsHint.Inherit
        Me.kryptonPaletteCustom.ButtonStyles.ButtonStandalone.StateTracking.Back.ImageAlign = Krypton.Toolkit.PaletteRectangleAlign.Inherit
        Me.kryptonPaletteCustom.ButtonStyles.ButtonStandalone.StateTracking.Back.ImageStyle = Krypton.Toolkit.PaletteImageStyle.Inherit
        Me.kryptonPaletteCustom.ButtonStyles.ButtonStandalone.StateTracking.Border.Color1 = System.Drawing.Color.FromArgb(CType(CType(192, Byte), Integer), CType(CType(64, Byte), Integer), CType(CType(0, Byte), Integer))
        Me.kryptonPaletteCustom.ButtonStyles.ButtonStandalone.StateTracking.Border.ColorAlign = Krypton.Toolkit.PaletteRectangleAlign.Inherit
        Me.kryptonPaletteCustom.ButtonStyles.ButtonStandalone.StateTracking.Border.ColorStyle = Krypton.Toolkit.PaletteColorStyle.Inherit
        Me.kryptonPaletteCustom.ButtonStyles.ButtonStandalone.StateTracking.Border.Draw = Krypton.Toolkit.InheritBool.Inherit
        Me.kryptonPaletteCustom.ButtonStyles.ButtonStandalone.StateTracking.Border.DrawBorders = CType((((Krypton.Toolkit.PaletteDrawBorders.Top Or Krypton.Toolkit.PaletteDrawBorders.Bottom) Or Krypton.Toolkit.PaletteDrawBorders.Left) Or Krypton.Toolkit.PaletteDrawBorders.Right), Krypton.Toolkit.PaletteDrawBorders)
        Me.kryptonPaletteCustom.ButtonStyles.ButtonStandalone.StateTracking.Border.GraphicsHint = Krypton.Toolkit.PaletteGraphicsHint.Inherit
        Me.kryptonPaletteCustom.ButtonStyles.ButtonStandalone.StateTracking.Border.ImageAlign = Krypton.Toolkit.PaletteRectangleAlign.Inherit
        Me.kryptonPaletteCustom.ButtonStyles.ButtonStandalone.StateTracking.Content.Draw = Krypton.Toolkit.InheritBool.Inherit
        Me.kryptonPaletteCustom.ButtonStyles.ButtonStandalone.StateTracking.Content.DrawFocus = Krypton.Toolkit.InheritBool.Inherit
        Me.kryptonPaletteCustom.ButtonStyles.ButtonStandalone.StateTracking.Content.Padding = New System.Windows.Forms.Padding(-1)
        Me.kryptonPaletteCustom.ButtonStyles.ButtonStandalone.StateTracking.Content.ShortText.ColorAlign = Krypton.Toolkit.PaletteRectangleAlign.Inherit
        Me.kryptonPaletteCustom.ButtonStyles.ButtonStandalone.StateTracking.Content.ShortText.ColorStyle = Krypton.Toolkit.PaletteColorStyle.Inherit
        Me.kryptonPaletteCustom.ButtonStyles.ButtonStandalone.StateTracking.Content.ShortText.Font = New System.Drawing.Font("Berlin Sans FB", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.kryptonPaletteCustom.ButtonStyles.ButtonStandalone.StateTracking.Content.ShortText.Hint = Krypton.Toolkit.PaletteTextHint.Inherit
        Me.kryptonPaletteCustom.ButtonStyles.ButtonStandalone.StateTracking.Content.ShortText.ImageAlign = Krypton.Toolkit.PaletteRectangleAlign.Inherit
        Me.kryptonPaletteCustom.ButtonStyles.ButtonStandalone.StateTracking.Content.ShortText.ImageStyle = Krypton.Toolkit.PaletteImageStyle.Inherit
        Me.kryptonPaletteCustom.ButtonStyles.ButtonStandalone.StateTracking.Content.ShortText.MultiLine = Krypton.Toolkit.InheritBool.Inherit
        Me.kryptonPaletteCustom.ButtonStyles.ButtonStandalone.StateTracking.Content.ShortText.MultiLineH = Krypton.Toolkit.PaletteRelativeAlign.Inherit
        Me.kryptonPaletteCustom.ButtonStyles.ButtonStandalone.StateTracking.Content.ShortText.Prefix = Krypton.Toolkit.PaletteTextHotkeyPrefix.Inherit
        Me.kryptonPaletteCustom.ButtonStyles.ButtonStandalone.StateTracking.Content.ShortText.TextH = Krypton.Toolkit.PaletteRelativeAlign.Inherit
        Me.kryptonPaletteCustom.ButtonStyles.ButtonStandalone.StateTracking.Content.ShortText.TextV = Krypton.Toolkit.PaletteRelativeAlign.Inherit
        Me.kryptonPaletteCustom.ButtonStyles.ButtonStandalone.StateTracking.Content.ShortText.Trim = Krypton.Toolkit.PaletteTextTrim.Inherit
        Me.kryptonPaletteCustom.PanelStyles.PanelAlternate.StateDisabled.Color1 = System.Drawing.Color.FromArgb(CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer))
        Me.kryptonPaletteCustom.PanelStyles.PanelAlternate.StateDisabled.Color2 = System.Drawing.Color.FromArgb(CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer))
        Me.kryptonPaletteCustom.PanelStyles.PanelAlternate.StateDisabled.ColorAlign = Krypton.Toolkit.PaletteRectangleAlign.Inherit
        Me.kryptonPaletteCustom.PanelStyles.PanelAlternate.StateDisabled.ColorStyle = Krypton.Toolkit.PaletteColorStyle.Inherit
        Me.kryptonPaletteCustom.PanelStyles.PanelAlternate.StateDisabled.Draw = Krypton.Toolkit.InheritBool.Inherit
        Me.kryptonPaletteCustom.PanelStyles.PanelAlternate.StateDisabled.GraphicsHint = Krypton.Toolkit.PaletteGraphicsHint.Inherit
        Me.kryptonPaletteCustom.PanelStyles.PanelAlternate.StateDisabled.ImageAlign = Krypton.Toolkit.PaletteRectangleAlign.Inherit
        Me.kryptonPaletteCustom.PanelStyles.PanelAlternate.StateDisabled.ImageStyle = Krypton.Toolkit.PaletteImageStyle.Inherit
        Me.kryptonPaletteCustom.PanelStyles.PanelAlternate.StateNormal.Color1 = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(192, Byte), Integer), CType(CType(0, Byte), Integer))
        Me.kryptonPaletteCustom.PanelStyles.PanelAlternate.StateNormal.Color2 = System.Drawing.Color.GreenYellow
        Me.kryptonPaletteCustom.PanelStyles.PanelAlternate.StateNormal.ColorAlign = Krypton.Toolkit.PaletteRectangleAlign.Inherit
        Me.kryptonPaletteCustom.PanelStyles.PanelAlternate.StateNormal.ColorStyle = Krypton.Toolkit.PaletteColorStyle.Inherit
        Me.kryptonPaletteCustom.PanelStyles.PanelAlternate.StateNormal.Draw = Krypton.Toolkit.InheritBool.Inherit
        Me.kryptonPaletteCustom.PanelStyles.PanelAlternate.StateNormal.GraphicsHint = Krypton.Toolkit.PaletteGraphicsHint.Inherit
        Me.kryptonPaletteCustom.PanelStyles.PanelAlternate.StateNormal.ImageAlign = Krypton.Toolkit.PaletteRectangleAlign.Inherit
        Me.kryptonPaletteCustom.PanelStyles.PanelAlternate.StateNormal.ImageStyle = Krypton.Toolkit.PaletteImageStyle.Inherit
        '
        'Form1
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6F, 13F)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(462, 432)
        Me.Controls.Add(Me.buttonClose)
        Me.Controls.Add(Me.groupBoxDescription)
        Me.Controls.Add(Me.groupBoxCustomControl)
        Me.Controls.Add(Me.groupBoxPalettes)
        Me.Font = New System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.MaximizeBox = False
        Me.MinimizeBox = False
        Me.MinimumSize = New System.Drawing.Size(432, 466)
        Me.Name = "Form1"
        Me.Text = "Custom Control using Palettes"
        CType(Me.kryptonCheckSet, System.ComponentModel.ISupportInitialize).EndInit()
        Me.groupBoxPalettes.ResumeLayout(False)
        Me.groupBoxPalettes.PerformLayout()
        Me.groupBoxCustomControl.ResumeLayout(False)
        Me.groupBoxCustomControl.PerformLayout()
        Me.groupBoxDescription.ResumeLayout(False)
        Me.groupBoxDescription.PerformLayout()
        Me.ResumeLayout(False)
    End Sub

    Friend WithEvents myUserControl1 As MyUserControl
    Friend WithEvents kryptonManager As Krypton.Toolkit.KryptonManager
    Friend WithEvents buttonSparkle As Krypton.Toolkit.KryptonCheckButton
    Friend WithEvents buttonSystem As Krypton.Toolkit.KryptonCheckButton
    Friend WithEvents kryptonCheckSet As Krypton.Toolkit.KryptonCheckSet
    Friend WithEvents groupBoxPalettes As System.Windows.Forms.GroupBox
    Friend WithEvents groupBoxCustomControl As System.Windows.Forms.GroupBox
    Friend WithEvents groupBoxDescription As System.Windows.Forms.GroupBox
    Friend WithEvents buttonClose As System.Windows.Forms.Button
    Friend WithEvents checkBoxEnabled As System.Windows.Forms.CheckBox
    Friend WithEvents kryptonPaletteCustom As Krypton.Toolkit.KryptonCustomPaletteBase
    Friend WithEvents buttonCustom As Krypton.Toolkit.KryptonCheckButton
    Friend WithEvents textBox1 As System.Windows.Forms.TextBox
    Friend WithEvents buttonOffice2010Blue As Krypton.Toolkit.KryptonCheckButton
    Friend WithEvents buttonOffice2007Blue As Krypton.Toolkit.KryptonCheckButton
End Class
