' VB.NET twin of Source\Krypton Toolkit Examples\KryptonColorButton Examples\Form1.Designer.cs (Bastion Phase 4c).
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(Form1))
        Me.buttonClose = New System.Windows.Forms.Button()
        Me.groupProperties = New System.Windows.Forms.GroupBox()
        Me.propertyGrid = New System.Windows.Forms.PropertyGrid()
        Me.groupBlue = New System.Windows.Forms.GroupBox()
        Me.blueRight = New Krypton.Toolkit.KryptonColorButton()
        Me.blueLeft = New Krypton.Toolkit.KryptonColorButton()
        Me.blueBottom = New Krypton.Toolkit.KryptonColorButton()
        Me.blueTop = New Krypton.Toolkit.KryptonColorButton()
        Me.blueDropDown = New Krypton.Toolkit.KryptonColorButton()
        Me.blueSplitter = New Krypton.Toolkit.KryptonColorButton()
        Me.group2003 = New System.Windows.Forms.GroupBox()
        Me.sparkleBottom = New Krypton.Toolkit.KryptonColorButton()
        Me.sparkleTop = New Krypton.Toolkit.KryptonColorButton()
        Me.sparkleLeft = New Krypton.Toolkit.KryptonColorButton()
        Me.sparkleRight = New Krypton.Toolkit.KryptonColorButton()
        Me.groupBox1 = New System.Windows.Forms.GroupBox()
        Me.systemRight = New Krypton.Toolkit.KryptonColorButton()
        Me.systemDown = New Krypton.Toolkit.KryptonColorButton()
        Me.systemLeft = New Krypton.Toolkit.KryptonColorButton()
        Me.systemUp = New Krypton.Toolkit.KryptonColorButton()
        Me.groupBox2 = New System.Windows.Forms.GroupBox()
        Me.silverRight = New Krypton.Toolkit.KryptonColorButton()
        Me.silverDown = New Krypton.Toolkit.KryptonColorButton()
        Me.silverLeft = New Krypton.Toolkit.KryptonColorButton()
        Me.silverUp = New Krypton.Toolkit.KryptonColorButton()
        Me.groupBox3 = New System.Windows.Forms.GroupBox()
        Me.kryptonColorButton1 = New Krypton.Toolkit.KryptonColorButton()
        Me.kryptonColorButton2 = New Krypton.Toolkit.KryptonColorButton()
        Me.kryptonColorButton3 = New Krypton.Toolkit.KryptonColorButton()
        Me.kryptonColorButton4 = New Krypton.Toolkit.KryptonColorButton()
        Me.kryptonColorButton5 = New Krypton.Toolkit.KryptonColorButton()
        Me.groupProperties.SuspendLayout()
        Me.groupBlue.SuspendLayout()
        Me.group2003.SuspendLayout()
        Me.groupBox1.SuspendLayout()
        Me.groupBox2.SuspendLayout()
        Me.groupBox3.SuspendLayout()
        Me.SuspendLayout()
        Me.buttonClose.DialogResult = System.Windows.Forms.DialogResult.Cancel
        Me.buttonClose.Location = New System.Drawing.Point(463, 519)
        Me.buttonClose.Name = "buttonClose"
        Me.buttonClose.Size = New System.Drawing.Size(95, 52)
        Me.buttonClose.TabIndex = 5
        Me.buttonClose.Text = "&Close"
        Me.buttonClose.UseVisualStyleBackColor = True
        Me.groupProperties.Controls.Add(Me.propertyGrid)
        Me.groupProperties.Location = New System.Drawing.Point(239, 12)
        Me.groupProperties.Name = "groupProperties"
        Me.groupProperties.Size = New System.Drawing.Size(319, 446)
        Me.groupProperties.TabIndex = 4
        Me.groupProperties.TabStop = False
        Me.groupProperties.Text = "Properties for Selected KryptonColorButton"
        Me.propertyGrid.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) Or System.Windows.Forms.AnchorStyles.Left) Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.propertyGrid.Location = New System.Drawing.Point(6, 19)
        Me.propertyGrid.Name = "propertyGrid"
        Me.propertyGrid.Size = New System.Drawing.Size(307, 421)
        Me.propertyGrid.TabIndex = 0
        Me.propertyGrid.ToolbarVisible = False
        Me.groupBlue.Controls.Add(Me.blueRight)
        Me.groupBlue.Controls.Add(Me.blueLeft)
        Me.groupBlue.Controls.Add(Me.blueBottom)
        Me.groupBlue.Controls.Add(Me.blueTop)
        Me.groupBlue.Controls.Add(Me.blueDropDown)
        Me.groupBlue.Controls.Add(Me.blueSplitter)
        Me.groupBlue.Location = New System.Drawing.Point(12, 12)
        Me.groupBlue.Name = "groupBlue"
        Me.groupBlue.Size = New System.Drawing.Size(221, 107)
        Me.groupBlue.TabIndex = 0
        Me.groupBlue.TabStop = False
        Me.groupBlue.Text = "Office 2007 - Blue"
        Me.blueRight.AutoRecentColors = False
        Me.blueRight.AutoSize = True
        Me.blueRight.Location = New System.Drawing.Point(174, 69)
        Me.blueRight.Name = "blueRight"
        Me.blueRight.PaletteMode = Krypton.Toolkit.PaletteMode.Office2007Blue
        Me.blueRight.SchemeStandard = Krypton.Toolkit.ColorScheme.Basic16
        Me.blueRight.SchemeThemes = Krypton.Toolkit.ColorScheme.Mono8
        Me.blueRight.SelectedColor = System.Drawing.Color.Blue
        Me.blueRight.SelectedRect = New System.Drawing.Rectangle(0, 0, 16, 16)
        Me.blueRight.Size = New System.Drawing.Size(45, 26)
        Me.blueRight.Splitter = False
        Me.blueRight.Strings.StandardColors = "Monochrome Colors"
        Me.blueRight.Strings.ThemeColors = "Basic Colors"
        Me.blueRight.TabIndex = 5
        Me.blueRight.Values.Image = CType(resources.GetObject("blueRight.Values.Image"), System.Drawing.Image)
        Me.blueRight.Values.Text = ""
        Me.blueRight.VisibleMoreColors = False
        Me.blueRight.VisibleNoColor = False
        Me.blueLeft.AutoSize = True
        Me.blueLeft.CustomColorPreviewShape = Krypton.Toolkit.KryptonColorButtonCustomColorPreviewShape.Square
        Me.blueLeft.DropDownPosition = Krypton.Toolkit.VisualOrientation.Left
        Me.blueLeft.Location = New System.Drawing.Point(133, 69)
        Me.blueLeft.Name = "blueLeft"
        Me.blueLeft.PaletteMode = Krypton.Toolkit.PaletteMode.Office2007Blue
        Me.blueLeft.SchemeStandard = Krypton.Toolkit.ColorScheme.Basic16
        Me.blueLeft.SchemeThemes = Krypton.Toolkit.ColorScheme.OfficeStandard
        Me.blueLeft.SelectedColor = System.Drawing.Color.Yellow
        Me.blueLeft.SelectedRect = New System.Drawing.Rectangle(0, 0, 16, 16)
        Me.blueLeft.Size = New System.Drawing.Size(45, 26)
        Me.blueLeft.Splitter = False
        Me.blueLeft.Strings.StandardColors = "Monochrome Colors"
        Me.blueLeft.Strings.ThemeColors = "Basic Colors"
        Me.blueLeft.TabIndex = 3
        Me.blueLeft.Values.Image = CType(resources.GetObject("blueLeft.Values.Image"), System.Drawing.Image)
        Me.blueLeft.Values.Text = ""
        Me.blueBottom.AutoSize = True
        Me.blueBottom.DropDownPosition = Krypton.Toolkit.VisualOrientation.Bottom
        Me.blueBottom.Location = New System.Drawing.Point(178, 21)
        Me.blueBottom.Name = "blueBottom"
        Me.blueBottom.PaletteMode = Krypton.Toolkit.PaletteMode.Office2007Blue
        Me.blueBottom.SchemeStandard = Krypton.Toolkit.ColorScheme.Basic16
        Me.blueBottom.SchemeThemes = Krypton.Toolkit.ColorScheme.Mono8
        Me.blueBottom.SelectedColor = System.Drawing.Color.Fuchsia
        Me.blueBottom.SelectedRect = New System.Drawing.Rectangle(0, 0, 16, 16)
        Me.blueBottom.Size = New System.Drawing.Size(34, 45)
        Me.blueBottom.Splitter = False
        Me.blueBottom.Strings.StandardColors = "Monochrome Colors"
        Me.blueBottom.Strings.ThemeColors = "Basic Colors"
        Me.blueBottom.TabIndex = 4
        Me.blueBottom.Values.Image = CType(resources.GetObject("blueBottom.Values.Image"), System.Drawing.Image)
        Me.blueBottom.Values.Text = ""
        Me.blueBottom.VisibleMoreColors = False
        Me.blueBottom.VisibleNoColor = False
        Me.blueTop.AutoSize = True
        Me.blueTop.DropDownPosition = Krypton.Toolkit.VisualOrientation.Top
        Me.blueTop.Location = New System.Drawing.Point(133, 21)
        Me.blueTop.Name = "blueTop"
        Me.blueTop.PaletteMode = Krypton.Toolkit.PaletteMode.Office2007Blue
        Me.blueTop.SchemeStandard = Krypton.Toolkit.ColorScheme.Basic16
        Me.blueTop.SchemeThemes = Krypton.Toolkit.ColorScheme.Mono8
        Me.blueTop.SelectedColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(192, Byte), Integer), CType(CType(0, Byte), Integer))
        Me.blueTop.SelectedRect = New System.Drawing.Rectangle(0, 0, 16, 16)
        Me.blueTop.Size = New System.Drawing.Size(34, 45)
        Me.blueTop.Splitter = False
        Me.blueTop.Strings.StandardColors = "Monochrome Colors"
        Me.blueTop.Strings.ThemeColors = "Basic Colors"
        Me.blueTop.TabIndex = 2
        Me.blueTop.Values.Image = My.Resources.Empty16x16
        Me.blueTop.Values.Text = ""
        Me.blueTop.VisibleMoreColors = False
        Me.blueTop.VisibleNoColor = False
        Me.blueDropDown.Location = New System.Drawing.Point(4, 60)
        Me.blueDropDown.Name = "blueDropDown"
        Me.blueDropDown.PaletteMode = Krypton.Toolkit.PaletteMode.Office2007Blue
        Me.blueDropDown.SelectedColor = System.Drawing.Color.Blue
        Me.blueDropDown.Size = New System.Drawing.Size(126, 25)
        Me.blueDropDown.Splitter = False
        Me.blueDropDown.StateCommon.Content.Image.ImageH = Krypton.Toolkit.PaletteRelativeAlign.Near
        Me.blueDropDown.StateCommon.Content.ShortText.TextH = Krypton.Toolkit.PaletteRelativeAlign.Near
        Me.blueDropDown.TabIndex = 1
        Me.blueDropDown.Values.Text = "DropDown"
        Me.blueSplitter.Location = New System.Drawing.Point(4, 29)
        Me.blueSplitter.Name = "blueSplitter"
        Me.blueSplitter.PaletteMode = Krypton.Toolkit.PaletteMode.Office2007Blue
        Me.blueSplitter.Size = New System.Drawing.Size(126, 25)
        Me.blueSplitter.StateCommon.Content.Image.ImageH = Krypton.Toolkit.PaletteRelativeAlign.Near
        Me.blueSplitter.StateCommon.Content.ShortText.TextH = Krypton.Toolkit.PaletteRelativeAlign.Near
        Me.blueSplitter.TabIndex = 0
        Me.blueSplitter.Values.Image = CType(resources.GetObject("blueSplitter.Values.Image"), System.Drawing.Image)
        Me.blueSplitter.Values.Text = "Splitter"
        Me.group2003.Controls.Add(Me.sparkleBottom)
        Me.group2003.Controls.Add(Me.sparkleTop)
        Me.group2003.Controls.Add(Me.sparkleLeft)
        Me.group2003.Controls.Add(Me.sparkleRight)
        Me.group2003.Location = New System.Drawing.Point(12, 238)
        Me.group2003.Name = "group2003"
        Me.group2003.Size = New System.Drawing.Size(221, 107)
        Me.group2003.TabIndex = 2
        Me.group2003.TabStop = False
        Me.group2003.Text = "Sparkle - Blue"
        Me.sparkleBottom.ButtonStyle = Krypton.Toolkit.ButtonStyle.Cluster
        Me.sparkleBottom.DropDownPosition = Krypton.Toolkit.VisualOrientation.Bottom
        Me.sparkleBottom.Location = New System.Drawing.Point(106, 20)
        Me.sparkleBottom.Name = "sparkleBottom"
        Me.sparkleBottom.PaletteMode = Krypton.Toolkit.PaletteMode.SparkleBlue
        Me.sparkleBottom.SelectedRect = New System.Drawing.Rectangle(0, 0, 16, 16)
        Me.sparkleBottom.Size = New System.Drawing.Size(95, 44)
        Me.sparkleBottom.StateCommon.Content.Image.ImageH = Krypton.Toolkit.PaletteRelativeAlign.Near
        Me.sparkleBottom.StateCommon.Content.Padding = New System.Windows.Forms.Padding(6, 0, 2, 0)
        Me.sparkleBottom.StateCommon.Content.ShortText.TextH = Krypton.Toolkit.PaletteRelativeAlign.Near
        Me.sparkleBottom.TabIndex = 2
        Me.sparkleBottom.Values.Text = "Bottom"
        Me.sparkleTop.ButtonStyle = Krypton.Toolkit.ButtonStyle.Cluster
        Me.sparkleTop.DropDownPosition = Krypton.Toolkit.VisualOrientation.Top
        Me.sparkleTop.Location = New System.Drawing.Point(16, 20)
        Me.sparkleTop.Name = "sparkleTop"
        Me.sparkleTop.PaletteMode = Krypton.Toolkit.PaletteMode.SparkleBlue
        Me.sparkleTop.SelectedRect = New System.Drawing.Rectangle(0, 0, 16, 16)
        Me.sparkleTop.Size = New System.Drawing.Size(83, 44)
        Me.sparkleTop.StateCommon.Content.Image.ImageH = Krypton.Toolkit.PaletteRelativeAlign.Near
        Me.sparkleTop.StateCommon.Content.Padding = New System.Windows.Forms.Padding(6, 0, 2, 0)
        Me.sparkleTop.StateCommon.Content.ShortText.TextH = Krypton.Toolkit.PaletteRelativeAlign.Near
        Me.sparkleTop.TabIndex = 0
        Me.sparkleTop.Values.Text = "Top"
        Me.sparkleLeft.ButtonStyle = Krypton.Toolkit.ButtonStyle.Cluster
        Me.sparkleLeft.DropDownPosition = Krypton.Toolkit.VisualOrientation.Left
        Me.sparkleLeft.Location = New System.Drawing.Point(16, 70)
        Me.sparkleLeft.Name = "sparkleLeft"
        Me.sparkleLeft.PaletteMode = Krypton.Toolkit.PaletteMode.SparkleBlue
        Me.sparkleLeft.SelectedRect = New System.Drawing.Rectangle(0, 0, 16, 16)
        Me.sparkleLeft.Size = New System.Drawing.Size(83, 25)
        Me.sparkleLeft.StateCommon.Content.Image.ImageH = Krypton.Toolkit.PaletteRelativeAlign.Near
        Me.sparkleLeft.StateCommon.Content.Padding = New System.Windows.Forms.Padding(6, 0, 2, 0)
        Me.sparkleLeft.StateCommon.Content.ShortText.TextH = Krypton.Toolkit.PaletteRelativeAlign.Near
        Me.sparkleLeft.TabIndex = 1
        Me.sparkleLeft.Values.Text = "Left"
        Me.sparkleRight.ButtonStyle = Krypton.Toolkit.ButtonStyle.Cluster
        Me.sparkleRight.Location = New System.Drawing.Point(106, 70)
        Me.sparkleRight.Name = "sparkleRight"
        Me.sparkleRight.PaletteMode = Krypton.Toolkit.PaletteMode.SparkleBlue
        Me.sparkleRight.SelectedRect = New System.Drawing.Rectangle(0, 0, 16, 16)
        Me.sparkleRight.Size = New System.Drawing.Size(95, 25)
        Me.sparkleRight.StateCommon.Content.Image.ImageH = Krypton.Toolkit.PaletteRelativeAlign.Near
        Me.sparkleRight.StateCommon.Content.Padding = New System.Windows.Forms.Padding(6, 0, 2, 0)
        Me.sparkleRight.StateCommon.Content.ShortText.TextH = Krypton.Toolkit.PaletteRelativeAlign.Near
        Me.sparkleRight.TabIndex = 3
        Me.sparkleRight.Values.Text = "Right"
        Me.groupBox1.Controls.Add(Me.systemRight)
        Me.groupBox1.Controls.Add(Me.systemDown)
        Me.groupBox1.Controls.Add(Me.systemLeft)
        Me.groupBox1.Controls.Add(Me.systemUp)
        Me.groupBox1.Location = New System.Drawing.Point(12, 351)
        Me.groupBox1.Name = "groupBox1"
        Me.groupBox1.Size = New System.Drawing.Size(221, 107)
        Me.groupBox1.TabIndex = 3
        Me.groupBox1.TabStop = False
        Me.groupBox1.Text = "Professional - System"
        Me.systemRight.AutoSize = True
        Me.systemRight.DropDownOrientation = Krypton.Toolkit.VisualOrientation.Right
        Me.systemRight.DropDownPosition = Krypton.Toolkit.VisualOrientation.Bottom
        Me.systemRight.Location = New System.Drawing.Point(160, 29)
        Me.systemRight.Name = "systemRight"
        Me.systemRight.PaletteMode = Krypton.Toolkit.PaletteMode.ProfessionalSystem
        Me.systemRight.SchemeThemes = Krypton.Toolkit.ColorScheme.Basic16
        Me.systemRight.SelectedColor = System.Drawing.Color.Olive
        Me.systemRight.SelectedRect = New System.Drawing.Rectangle(0, 0, 16, 16)
        Me.systemRight.Size = New System.Drawing.Size(50, 67)
        Me.systemRight.StateCommon.Content.ShortText.TextH = Krypton.Toolkit.PaletteRelativeAlign.Center
        Me.systemRight.StateCommon.Content.ShortText.TextV = Krypton.Toolkit.PaletteRelativeAlign.Near
        Me.systemRight.Strings.ThemeColors = "Basic Colors"
        Me.systemRight.TabIndex = 3
        Me.systemRight.Values.Image = CType(resources.GetObject("systemRight.Values.Image"), System.Drawing.Image)
        Me.systemRight.Values.Text = "Right"
        Me.systemRight.VisibleMoreColors = False
        Me.systemRight.VisibleNoColor = False
        Me.systemRight.VisibleStandard = False
        Me.systemDown.AutoSize = True
        Me.systemDown.DropDownPosition = Krypton.Toolkit.VisualOrientation.Bottom
        Me.systemDown.Location = New System.Drawing.Point(100, 29)
        Me.systemDown.Name = "systemDown"
        Me.systemDown.PaletteMode = Krypton.Toolkit.PaletteMode.ProfessionalSystem
        Me.systemDown.SchemeThemes = Krypton.Toolkit.ColorScheme.Basic16
        Me.systemDown.SelectedColor = System.Drawing.Color.MediumBlue
        Me.systemDown.SelectedRect = New System.Drawing.Rectangle(0, 0, 16, 16)
        Me.systemDown.Size = New System.Drawing.Size(54, 67)
        Me.systemDown.StateCommon.Content.ShortText.TextH = Krypton.Toolkit.PaletteRelativeAlign.Center
        Me.systemDown.StateCommon.Content.ShortText.TextV = Krypton.Toolkit.PaletteRelativeAlign.Near
        Me.systemDown.Strings.ThemeColors = "Basic Colors"
        Me.systemDown.TabIndex = 2
        Me.systemDown.Values.Image = CType(resources.GetObject("systemDown.Values.Image"), System.Drawing.Image)
        Me.systemDown.Values.Text = "Down"
        Me.systemDown.VisibleMoreColors = False
        Me.systemDown.VisibleNoColor = False
        Me.systemDown.VisibleStandard = False
        Me.systemLeft.AutoSize = True
        Me.systemLeft.DropDownOrientation = Krypton.Toolkit.VisualOrientation.Left
        Me.systemLeft.DropDownPosition = Krypton.Toolkit.VisualOrientation.Bottom
        Me.systemLeft.Location = New System.Drawing.Point(56, 29)
        Me.systemLeft.Name = "systemLeft"
        Me.systemLeft.PaletteMode = Krypton.Toolkit.PaletteMode.ProfessionalSystem
        Me.systemLeft.SchemeThemes = Krypton.Toolkit.ColorScheme.Basic16
        Me.systemLeft.SelectedColor = System.Drawing.Color.Gray
        Me.systemLeft.SelectedRect = New System.Drawing.Rectangle(0, 0, 16, 16)
        Me.systemLeft.Size = New System.Drawing.Size(39, 67)
        Me.systemLeft.StateCommon.Content.ShortText.TextH = Krypton.Toolkit.PaletteRelativeAlign.Center
        Me.systemLeft.StateCommon.Content.ShortText.TextV = Krypton.Toolkit.PaletteRelativeAlign.Near
        Me.systemLeft.Strings.ThemeColors = "Basic Colors"
        Me.systemLeft.TabIndex = 1
        Me.systemLeft.Values.Image = CType(resources.GetObject("systemLeft.Values.Image"), System.Drawing.Image)
        Me.systemLeft.Values.Text = "Left"
        Me.systemLeft.VisibleMoreColors = False
        Me.systemLeft.VisibleNoColor = False
        Me.systemLeft.VisibleStandard = False
        Me.systemUp.AutoSize = True
        Me.systemUp.DropDownOrientation = Krypton.Toolkit.VisualOrientation.Top
        Me.systemUp.DropDownPosition = Krypton.Toolkit.VisualOrientation.Bottom
        Me.systemUp.Location = New System.Drawing.Point(16, 29)
        Me.systemUp.Name = "systemUp"
        Me.systemUp.PaletteMode = Krypton.Toolkit.PaletteMode.ProfessionalSystem
        Me.systemUp.SchemeThemes = Krypton.Toolkit.ColorScheme.Basic16
        Me.systemUp.SelectedColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(128, Byte), Integer), CType(CType(0, Byte), Integer))
        Me.systemUp.SelectedRect = New System.Drawing.Rectangle(0, 0, 16, 16)
        Me.systemUp.Size = New System.Drawing.Size(34, 67)
        Me.systemUp.StateCommon.Content.ShortText.TextH = Krypton.Toolkit.PaletteRelativeAlign.Center
        Me.systemUp.StateCommon.Content.ShortText.TextV = Krypton.Toolkit.PaletteRelativeAlign.Near
        Me.systemUp.Strings.ThemeColors = "Basic Colors"
        Me.systemUp.TabIndex = 0
        Me.systemUp.Values.Image = My.Resources.Empty16x16
        Me.systemUp.Values.Text = "Up"
        Me.systemUp.VisibleMoreColors = False
        Me.systemUp.VisibleNoColor = False
        Me.systemUp.VisibleStandard = False
        Me.groupBox2.Controls.Add(Me.silverRight)
        Me.groupBox2.Controls.Add(Me.silverDown)
        Me.groupBox2.Controls.Add(Me.silverLeft)
        Me.groupBox2.Controls.Add(Me.silverUp)
        Me.groupBox2.Location = New System.Drawing.Point(12, 125)
        Me.groupBox2.Name = "groupBox2"
        Me.groupBox2.Size = New System.Drawing.Size(221, 107)
        Me.groupBox2.TabIndex = 1
        Me.groupBox2.TabStop = False
        Me.groupBox2.Text = "Office 2010 - Blue"
        Me.silverRight.AutoSize = True
        Me.silverRight.DropDownOrientation = Krypton.Toolkit.VisualOrientation.Right
        Me.silverRight.DropDownPosition = Krypton.Toolkit.VisualOrientation.Bottom
        Me.silverRight.Location = New System.Drawing.Point(160, 29)
        Me.silverRight.Name = "silverRight"
        Me.silverRight.PaletteMode = Krypton.Toolkit.PaletteMode.Office2010Blue
        Me.silverRight.SelectedColor = System.Drawing.Color.Olive
        Me.silverRight.SelectedRect = New System.Drawing.Rectangle(0, 0, 16, 16)
        Me.silverRight.Size = New System.Drawing.Size(48, 67)
        Me.silverRight.Splitter = False
        Me.silverRight.StateCommon.Content.ShortText.TextH = Krypton.Toolkit.PaletteRelativeAlign.Center
        Me.silverRight.StateCommon.Content.ShortText.TextV = Krypton.Toolkit.PaletteRelativeAlign.Near
        Me.silverRight.TabIndex = 3
        Me.silverRight.Values.Image = CType(resources.GetObject("silverRight.Values.Image"), System.Drawing.Image)
        Me.silverRight.Values.Text = "Right"
        Me.silverDown.AutoSize = True
        Me.silverDown.DropDownPosition = Krypton.Toolkit.VisualOrientation.Bottom
        Me.silverDown.Location = New System.Drawing.Point(100, 29)
        Me.silverDown.Name = "silverDown"
        Me.silverDown.PaletteMode = Krypton.Toolkit.PaletteMode.Office2010Blue
        Me.silverDown.SelectedColor = System.Drawing.Color.MediumBlue
        Me.silverDown.SelectedRect = New System.Drawing.Rectangle(0, 0, 16, 16)
        Me.silverDown.Size = New System.Drawing.Size(54, 67)
        Me.silverDown.Splitter = False
        Me.silverDown.StateCommon.Content.ShortText.TextH = Krypton.Toolkit.PaletteRelativeAlign.Center
        Me.silverDown.StateCommon.Content.ShortText.TextV = Krypton.Toolkit.PaletteRelativeAlign.Near
        Me.silverDown.TabIndex = 2
        Me.silverDown.Values.Image = CType(resources.GetObject("silverDown.Values.Image"), System.Drawing.Image)
        Me.silverDown.Values.Text = "Down"
        Me.silverLeft.AutoSize = True
        Me.silverLeft.DropDownOrientation = Krypton.Toolkit.VisualOrientation.Left
        Me.silverLeft.DropDownPosition = Krypton.Toolkit.VisualOrientation.Bottom
        Me.silverLeft.Location = New System.Drawing.Point(56, 29)
        Me.silverLeft.Name = "silverLeft"
        Me.silverLeft.PaletteMode = Krypton.Toolkit.PaletteMode.Office2010Blue
        Me.silverLeft.SelectedColor = System.Drawing.Color.Gray
        Me.silverLeft.SelectedRect = New System.Drawing.Rectangle(0, 0, 16, 16)
        Me.silverLeft.Size = New System.Drawing.Size(38, 67)
        Me.silverLeft.Splitter = False
        Me.silverLeft.StateCommon.Content.ShortText.TextH = Krypton.Toolkit.PaletteRelativeAlign.Center
        Me.silverLeft.StateCommon.Content.ShortText.TextV = Krypton.Toolkit.PaletteRelativeAlign.Near
        Me.silverLeft.TabIndex = 1
        Me.silverLeft.Values.Image = CType(resources.GetObject("silverLeft.Values.Image"), System.Drawing.Image)
        Me.silverLeft.Values.Text = "Left"
        Me.silverUp.AutoSize = True
        Me.silverUp.DropDownOrientation = Krypton.Toolkit.VisualOrientation.Top
        Me.silverUp.DropDownPosition = Krypton.Toolkit.VisualOrientation.Bottom
        Me.silverUp.Location = New System.Drawing.Point(16, 29)
        Me.silverUp.Name = "silverUp"
        Me.silverUp.PaletteMode = Krypton.Toolkit.PaletteMode.Office2010Blue
        Me.silverUp.SelectedColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(128, Byte), Integer), CType(CType(0, Byte), Integer))
        Me.silverUp.SelectedRect = New System.Drawing.Rectangle(0, 0, 16, 16)
        Me.silverUp.Size = New System.Drawing.Size(34, 67)
        Me.silverUp.Splitter = False
        Me.silverUp.StateCommon.Content.ShortText.TextH = Krypton.Toolkit.PaletteRelativeAlign.Center
        Me.silverUp.StateCommon.Content.ShortText.TextV = Krypton.Toolkit.PaletteRelativeAlign.Near
        Me.silverUp.TabIndex = 0
        Me.silverUp.Values.Image = My.Resources.Empty16x16
        Me.silverUp.Values.Text = "Up"
        Me.groupBox3.Controls.Add(Me.kryptonColorButton1)
        Me.groupBox3.Controls.Add(Me.kryptonColorButton2)
        Me.groupBox3.Controls.Add(Me.kryptonColorButton3)
        Me.groupBox3.Controls.Add(Me.kryptonColorButton4)
        Me.groupBox3.Location = New System.Drawing.Point(12, 460)
        Me.groupBox3.Name = "groupBox3"
        Me.groupBox3.Size = New System.Drawing.Size(364, 111)
        Me.groupBox3.TabIndex = 6
        Me.groupBox3.TabStop = False
        Me.groupBox3.Text = "Rounded Rect Layouts"
        Me.kryptonColorButton1.AutoSize = True
        Me.kryptonColorButton1.DropDownOrientation = Krypton.Toolkit.VisualOrientation.Right
        Me.kryptonColorButton1.DropDownPosition = Krypton.Toolkit.VisualOrientation.Bottom
        Me.kryptonColorButton1.Location = New System.Drawing.Point(286, 10)
        Me.kryptonColorButton1.Name = "kryptonColorButton1"
        Me.kryptonColorButton1.PaletteMode = Krypton.Toolkit.PaletteMode.Office2010Blue
        Me.kryptonColorButton1.SelectedColor = System.Drawing.Color.Olive
        Me.kryptonColorButton1.SelectedRect = New System.Drawing.Rectangle(0, 0, 20, 50)
        Me.kryptonColorButton1.Size = New System.Drawing.Size(61, 101)
        Me.kryptonColorButton1.Splitter = False
        Me.kryptonColorButton1.StateCommon.Content.ShortText.TextH = Krypton.Toolkit.PaletteRelativeAlign.Center
        Me.kryptonColorButton1.StateCommon.Content.ShortText.TextV = Krypton.Toolkit.PaletteRelativeAlign.Near
        Me.kryptonColorButton1.TabIndex = 3
        Me.kryptonColorButton1.Values.Image = CType(resources.GetObject("kryptonColorButton1.Values.Image"), System.Drawing.Image)
        Me.kryptonColorButton1.Values.RoundedCorners = 4
        Me.kryptonColorButton1.Values.Text = "Tall"
        Me.kryptonColorButton2.AutoSize = True
        Me.kryptonColorButton2.DropDownPosition = Krypton.Toolkit.VisualOrientation.Bottom
        Me.kryptonColorButton2.Location = New System.Drawing.Point(147, 29)
        Me.kryptonColorButton2.Name = "kryptonColorButton2"
        Me.kryptonColorButton2.PaletteMode = Krypton.Toolkit.PaletteMode.Office2010Blue
        Me.kryptonColorButton2.SelectedColor = System.Drawing.Color.MediumBlue
        Me.kryptonColorButton2.SelectedRect = New System.Drawing.Rectangle(0, 0, 100, 20)
        Me.kryptonColorButton2.Size = New System.Drawing.Size(133, 71)
        Me.kryptonColorButton2.Splitter = False
        Me.kryptonColorButton2.StateCommon.Content.ShortText.TextH = Krypton.Toolkit.PaletteRelativeAlign.Center
        Me.kryptonColorButton2.StateCommon.Content.ShortText.TextV = Krypton.Toolkit.PaletteRelativeAlign.Near
        Me.kryptonColorButton2.TabIndex = 2
        Me.kryptonColorButton2.Values.Image = CType(resources.GetObject("kryptonColorButton2.Values.Image"), System.Drawing.Image)
        Me.kryptonColorButton2.Values.RoundedCorners = 7
        Me.kryptonColorButton2.Values.Text = "Wide"
        Me.kryptonColorButton3.AutoSize = True
        Me.kryptonColorButton3.DropDownOrientation = Krypton.Toolkit.VisualOrientation.Left
        Me.kryptonColorButton3.DropDownPosition = Krypton.Toolkit.VisualOrientation.Bottom
        Me.kryptonColorButton3.Location = New System.Drawing.Point(76, 29)
        Me.kryptonColorButton3.Name = "kryptonColorButton3"
        Me.kryptonColorButton3.PaletteMode = Krypton.Toolkit.PaletteMode.Office2010Blue
        Me.kryptonColorButton3.SelectedColor = System.Drawing.Color.Gray
        Me.kryptonColorButton3.SelectedRect = New System.Drawing.Rectangle(0, 0, 16, 16)
        Me.kryptonColorButton3.Size = New System.Drawing.Size(65, 67)
        Me.kryptonColorButton3.Splitter = False
        Me.kryptonColorButton3.StateCommon.Content.ShortText.TextH = Krypton.Toolkit.PaletteRelativeAlign.Center
        Me.kryptonColorButton3.StateCommon.Content.ShortText.TextV = Krypton.Toolkit.PaletteRelativeAlign.Near
        Me.kryptonColorButton3.TabIndex = 1
        Me.kryptonColorButton3.Values.Image = CType(resources.GetObject("kryptonColorButton3.Values.Image"), System.Drawing.Image)
        Me.kryptonColorButton3.Values.RoundedCorners = 2
        Me.kryptonColorButton3.Values.Text = "sqauare"
        Me.kryptonColorButton4.AutoSize = True
        Me.kryptonColorButton4.DropDownOrientation = Krypton.Toolkit.VisualOrientation.Top
        Me.kryptonColorButton4.DropDownPosition = Krypton.Toolkit.VisualOrientation.Bottom
        Me.kryptonColorButton4.Location = New System.Drawing.Point(16, 29)
        Me.kryptonColorButton4.Name = "kryptonColorButton4"
        Me.kryptonColorButton4.PaletteMode = Krypton.Toolkit.PaletteMode.Office2010Blue
        Me.kryptonColorButton4.SelectedColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(128, Byte), Integer), CType(CType(0, Byte), Integer))
        Me.kryptonColorButton4.SelectedRect = New System.Drawing.Rectangle(0, 0, 16, 16)
        Me.kryptonColorButton4.Size = New System.Drawing.Size(56, 67)
        Me.kryptonColorButton4.Splitter = False
        Me.kryptonColorButton4.StateCommon.Content.ShortText.TextH = Krypton.Toolkit.PaletteRelativeAlign.Center
        Me.kryptonColorButton4.StateCommon.Content.ShortText.TextV = Krypton.Toolkit.PaletteRelativeAlign.Near
        Me.kryptonColorButton4.TabIndex = 0
        Me.kryptonColorButton4.Values.Image = My.Resources.Empty16x16
        Me.kryptonColorButton4.Values.RoundedCorners = 8
        Me.kryptonColorButton4.Values.Text = "Round"
        Me.kryptonColorButton5.Location = New System.Drawing.Point(382, 476)
        Me.kryptonColorButton5.Name = "kryptonColorButton5"
        Me.kryptonColorButton5.PaletteMode = Krypton.Toolkit.PaletteMode.Office2007Blue
        Me.kryptonColorButton5.SelectedColor = System.Drawing.Color.Blue
        Me.kryptonColorButton5.Size = New System.Drawing.Size(139, 25)
        Me.kryptonColorButton5.Splitter = False
        Me.kryptonColorButton5.StateCommon.Content.Image.ImageH = Krypton.Toolkit.PaletteRelativeAlign.Near
        Me.kryptonColorButton5.StateCommon.Content.ShortText.TextH = Krypton.Toolkit.PaletteRelativeAlign.Near
        Me.kryptonColorButton5.TabIndex = 6
        Me.kryptonColorButton5.Values.Text = "Click Override"
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8F, 17F)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(568, 576)
        Me.Controls.Add(Me.kryptonColorButton5)
        Me.Controls.Add(Me.groupBox3)
        Me.Controls.Add(Me.groupBox2)
        Me.Controls.Add(Me.groupBox1)
        Me.Controls.Add(Me.group2003)
        Me.Controls.Add(Me.groupBlue)
        Me.Controls.Add(Me.buttonClose)
        Me.Controls.Add(Me.groupProperties)
        Me.Font = New System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.MaximizeBox = False
        Me.MinimizeBox = False
        Me.Name = "Form1"
        Me.Text = "KryptonColorButton Examples"
        Me.groupProperties.ResumeLayout(False)
        Me.groupBlue.ResumeLayout(False)
        Me.groupBlue.PerformLayout()
        Me.group2003.ResumeLayout(False)
        Me.groupBox1.ResumeLayout(False)
        Me.groupBox1.PerformLayout()
        Me.groupBox2.ResumeLayout(False)
        Me.groupBox2.PerformLayout()
        Me.groupBox3.ResumeLayout(False)
        Me.groupBox3.PerformLayout()
        Me.ResumeLayout(False)
    End Sub

    Friend WithEvents buttonClose As System.Windows.Forms.Button
    Friend WithEvents groupProperties As System.Windows.Forms.GroupBox
    Friend WithEvents propertyGrid As System.Windows.Forms.PropertyGrid
    Friend WithEvents groupBlue As System.Windows.Forms.GroupBox
    Friend WithEvents blueSplitter As Krypton.Toolkit.KryptonColorButton
    Friend WithEvents blueDropDown As Krypton.Toolkit.KryptonColorButton
    Friend WithEvents blueTop As Krypton.Toolkit.KryptonColorButton
    Friend WithEvents blueRight As Krypton.Toolkit.KryptonColorButton
    Friend WithEvents blueLeft As Krypton.Toolkit.KryptonColorButton
    Friend WithEvents blueBottom As Krypton.Toolkit.KryptonColorButton
    Friend WithEvents group2003 As System.Windows.Forms.GroupBox
    Friend WithEvents sparkleRight As Krypton.Toolkit.KryptonColorButton
    Friend WithEvents groupBox1 As System.Windows.Forms.GroupBox
    Friend WithEvents groupBox2 As System.Windows.Forms.GroupBox
    Friend WithEvents silverRight As Krypton.Toolkit.KryptonColorButton
    Friend WithEvents silverDown As Krypton.Toolkit.KryptonColorButton
    Friend WithEvents silverLeft As Krypton.Toolkit.KryptonColorButton
    Friend WithEvents silverUp As Krypton.Toolkit.KryptonColorButton
    Friend WithEvents systemRight As Krypton.Toolkit.KryptonColorButton
    Friend WithEvents systemDown As Krypton.Toolkit.KryptonColorButton
    Friend WithEvents systemLeft As Krypton.Toolkit.KryptonColorButton
    Friend WithEvents systemUp As Krypton.Toolkit.KryptonColorButton
    Friend WithEvents sparkleBottom As Krypton.Toolkit.KryptonColorButton
    Friend WithEvents sparkleTop As Krypton.Toolkit.KryptonColorButton
    Friend WithEvents sparkleLeft As Krypton.Toolkit.KryptonColorButton
    Friend WithEvents groupBox3 As System.Windows.Forms.GroupBox
    Friend WithEvents kryptonColorButton1 As Krypton.Toolkit.KryptonColorButton
    Friend WithEvents kryptonColorButton2 As Krypton.Toolkit.KryptonColorButton
    Friend WithEvents kryptonColorButton3 As Krypton.Toolkit.KryptonColorButton
    Friend WithEvents kryptonColorButton4 As Krypton.Toolkit.KryptonColorButton
    Friend WithEvents kryptonColorButton5 As Krypton.Toolkit.KryptonColorButton
End Class
