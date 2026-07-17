' VB.NET twin of Source\Krypton Navigator Examples\Navigator Palettes\Form1.Designer.cs (Bastion Phase 4c).
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
        Me.kryptonNavigator1 = New Krypton.Navigator.KryptonNavigator()
        Me.kryptonPage1 = New Krypton.Navigator.KryptonPage()
        Me.kryptonPage2 = New Krypton.Navigator.KryptonPage()
        Me.kryptonPage3 = New Krypton.Navigator.KryptonPage()
        Me.kryptonPage4 = New Krypton.Navigator.KryptonPage()
        Me.groupBoxPalettes = New System.Windows.Forms.GroupBox()
        Me.radioOffice2010Black = New System.Windows.Forms.RadioButton()
        Me.radioOffice2010Silver = New System.Windows.Forms.RadioButton()
        Me.radioOffice2010Blue = New System.Windows.Forms.RadioButton()
        Me.radioSparklePurple = New System.Windows.Forms.RadioButton()
        Me.radioSparkleOrange = New System.Windows.Forms.RadioButton()
        Me.radioSparkleBlue = New System.Windows.Forms.RadioButton()
        Me.radioOffice2007Black = New System.Windows.Forms.RadioButton()
        Me.radioOffice2007Silver = New System.Windows.Forms.RadioButton()
        Me.radioOffice2007Blue = New System.Windows.Forms.RadioButton()
        Me.radioLightweight = New System.Windows.Forms.RadioButton()
        Me.radioBlogger = New System.Windows.Forms.RadioButton()
        Me.radioOffice2003 = New System.Windows.Forms.RadioButton()
        Me.radioSystem = New System.Windows.Forms.RadioButton()
        Me.buttonClose = New System.Windows.Forms.Button()
        Me.kryptonPaletteBlogger = New Krypton.Toolkit.KryptonCustomPaletteBase(Me.components)
        Me.kryptonPaletteLightweight = New Krypton.Toolkit.KryptonCustomPaletteBase(Me.components)
        Me.kryptonManager = New Krypton.Toolkit.KryptonManager(Me.components)
        CType(Me.kryptonNavigator1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.kryptonNavigator1.SuspendLayout()
        CType(Me.kryptonPage1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.kryptonPage2, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.kryptonPage3, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.kryptonPage4, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.groupBoxPalettes.SuspendLayout()
        Me.SuspendLayout()
        Me.kryptonNavigator1.Button.ButtonDisplayLogic = Krypton.Navigator.ButtonDisplayLogic.Context
        Me.kryptonNavigator1.Button.CloseButtonAction = Krypton.Navigator.CloseButtonAction.RemovePage
        Me.kryptonNavigator1.Button.CloseButtonDisplay = Krypton.Navigator.ButtonDisplay.Logic
        Me.kryptonNavigator1.Button.ContextButtonAction = Krypton.Navigator.ContextButtonAction.SelectPage
        Me.kryptonNavigator1.Button.ContextButtonDisplay = Krypton.Navigator.ButtonDisplay.Logic
        Me.kryptonNavigator1.Button.ContextMenuMapImage = Krypton.Navigator.MapKryptonPageImage.Small
        Me.kryptonNavigator1.Button.ContextMenuMapText = Krypton.Navigator.MapKryptonPageText.TextTitle
        Me.kryptonNavigator1.Button.NextButtonAction = Krypton.Navigator.DirectionButtonAction.ModeAppropriateAction
        Me.kryptonNavigator1.Button.NextButtonDisplay = Krypton.Navigator.ButtonDisplay.Logic
        Me.kryptonNavigator1.Button.PreviousButtonAction = Krypton.Navigator.DirectionButtonAction.ModeAppropriateAction
        Me.kryptonNavigator1.Button.PreviousButtonDisplay = Krypton.Navigator.ButtonDisplay.Logic
        Me.kryptonNavigator1.ControlKryptonFormFeatures = False
        Me.kryptonNavigator1.Location = New System.Drawing.Point(236, 18)
        Me.kryptonNavigator1.Name = "kryptonNavigator1"
        Me.kryptonNavigator1.NavigatorMode = Krypton.Navigator.NavigatorMode.BarTabGroup
        Me.kryptonNavigator1.Owner = Nothing
        Me.kryptonNavigator1.PageBackStyle = Krypton.Toolkit.PaletteBackStyle.ControlClient
        Me.kryptonNavigator1.Pages.AddRange(New Krypton.Navigator.KryptonPage() { Me.kryptonPage1, Me.kryptonPage2, Me.kryptonPage3, Me.kryptonPage4})
        Me.kryptonNavigator1.PaletteMode = Krypton.Toolkit.PaletteMode.SparkleBlue
        Me.kryptonNavigator1.SelectedIndex = 0
        Me.kryptonNavigator1.Size = New System.Drawing.Size(419, 321)
        Me.kryptonNavigator1.StateCommon.CheckButton.Content.Image.ImageH = Krypton.Toolkit.PaletteRelativeAlign.Center
        Me.kryptonNavigator1.StateCommon.CheckButton.Content.Image.ImageV = Krypton.Toolkit.PaletteRelativeAlign.Near
        Me.kryptonNavigator1.StateCommon.CheckButton.Content.ShortText.TextH = Krypton.Toolkit.PaletteRelativeAlign.Center
        Me.kryptonNavigator1.StateCommon.CheckButton.Content.ShortText.TextV = Krypton.Toolkit.PaletteRelativeAlign.Far
        Me.kryptonNavigator1.TabIndex = 1
        Me.kryptonNavigator1.Text = "kryptonNavigator1"
        Me.kryptonPage1.AutoHiddenSlideSize = New System.Drawing.Size(200, 200)
        Me.kryptonPage1.Flags = 65534
        Me.kryptonPage1.ImageLarge = CType(resources.GetObject("kryptonPage1.ImageLarge"), System.Drawing.Bitmap)
        Me.kryptonPage1.ImageMedium = CType(resources.GetObject("kryptonPage1.ImageMedium"), System.Drawing.Bitmap)
        Me.kryptonPage1.ImageSmall = CType(resources.GetObject("kryptonPage1.ImageSmall"), System.Drawing.Bitmap)
        Me.kryptonPage1.LastVisibleSet = True
        Me.kryptonPage1.MinimumSize = New System.Drawing.Size(50, 50)
        Me.kryptonPage1.Name = "kryptonPage1"
        Me.kryptonPage1.Size = New System.Drawing.Size(417, 289)
        Me.kryptonPage1.Text = "Page 1"
        Me.kryptonPage1.ToolTipTitle = "Page ToolTip"
        Me.kryptonPage1.UniqueName = "D14D70B626614AABD14D70B626614AAB"
        Me.kryptonPage2.AutoHiddenSlideSize = New System.Drawing.Size(200, 200)
        Me.kryptonPage2.Flags = 65534
        Me.kryptonPage2.ImageLarge = CType(resources.GetObject("kryptonPage2.ImageLarge"), System.Drawing.Bitmap)
        Me.kryptonPage2.ImageMedium = CType(resources.GetObject("kryptonPage2.ImageMedium"), System.Drawing.Bitmap)
        Me.kryptonPage2.ImageSmall = CType(resources.GetObject("kryptonPage2.ImageSmall"), System.Drawing.Bitmap)
        Me.kryptonPage2.LastVisibleSet = True
        Me.kryptonPage2.MinimumSize = New System.Drawing.Size(50, 50)
        Me.kryptonPage2.Name = "kryptonPage2"
        Me.kryptonPage2.Size = New System.Drawing.Size(376, 222)
        Me.kryptonPage2.Text = "Page 2"
        Me.kryptonPage2.ToolTipTitle = "Page ToolTip"
        Me.kryptonPage2.UniqueName = "707E46AE53D14CCD707E46AE53D14CCD"
        Me.kryptonPage3.AutoHiddenSlideSize = New System.Drawing.Size(200, 200)
        Me.kryptonPage3.Flags = 65534
        Me.kryptonPage3.ImageLarge = CType(resources.GetObject("kryptonPage3.ImageLarge"), System.Drawing.Bitmap)
        Me.kryptonPage3.ImageMedium = CType(resources.GetObject("kryptonPage3.ImageMedium"), System.Drawing.Bitmap)
        Me.kryptonPage3.ImageSmall = CType(resources.GetObject("kryptonPage3.ImageSmall"), System.Drawing.Bitmap)
        Me.kryptonPage3.LastVisibleSet = True
        Me.kryptonPage3.MinimumSize = New System.Drawing.Size(50, 50)
        Me.kryptonPage3.Name = "kryptonPage3"
        Me.kryptonPage3.Size = New System.Drawing.Size(376, 222)
        Me.kryptonPage3.Text = "Page 3"
        Me.kryptonPage3.ToolTipTitle = "Page ToolTip"
        Me.kryptonPage3.UniqueName = "06E429CAACE4494506E429CAACE44945"
        Me.kryptonPage4.AutoHiddenSlideSize = New System.Drawing.Size(200, 200)
        Me.kryptonPage4.Flags = 65534
        Me.kryptonPage4.ImageLarge = CType(resources.GetObject("kryptonPage4.ImageLarge"), System.Drawing.Bitmap)
        Me.kryptonPage4.ImageMedium = CType(resources.GetObject("kryptonPage4.ImageMedium"), System.Drawing.Bitmap)
        Me.kryptonPage4.ImageSmall = CType(resources.GetObject("kryptonPage4.ImageSmall"), System.Drawing.Bitmap)
        Me.kryptonPage4.LastVisibleSet = True
        Me.kryptonPage4.MinimumSize = New System.Drawing.Size(50, 50)
        Me.kryptonPage4.Name = "kryptonPage4"
        Me.kryptonPage4.Size = New System.Drawing.Size(376, 222)
        Me.kryptonPage4.Text = "Page 4"
        Me.kryptonPage4.ToolTipTitle = "Page ToolTip"
        Me.kryptonPage4.UniqueName = "361135F47DDF496C361135F47DDF496C"
        Me.groupBoxPalettes.Controls.Add(Me.radioOffice2010Black)
        Me.groupBoxPalettes.Controls.Add(Me.radioOffice2010Silver)
        Me.groupBoxPalettes.Controls.Add(Me.radioOffice2010Blue)
        Me.groupBoxPalettes.Controls.Add(Me.radioSparklePurple)
        Me.groupBoxPalettes.Controls.Add(Me.radioSparkleOrange)
        Me.groupBoxPalettes.Controls.Add(Me.radioSparkleBlue)
        Me.groupBoxPalettes.Controls.Add(Me.radioOffice2007Black)
        Me.groupBoxPalettes.Controls.Add(Me.radioOffice2007Silver)
        Me.groupBoxPalettes.Controls.Add(Me.radioOffice2007Blue)
        Me.groupBoxPalettes.Controls.Add(Me.radioLightweight)
        Me.groupBoxPalettes.Controls.Add(Me.radioBlogger)
        Me.groupBoxPalettes.Controls.Add(Me.radioOffice2003)
        Me.groupBoxPalettes.Controls.Add(Me.radioSystem)
        Me.groupBoxPalettes.Location = New System.Drawing.Point(12, 12)
        Me.groupBoxPalettes.Name = "groupBoxPalettes"
        Me.groupBoxPalettes.Size = New System.Drawing.Size(207, 327)
        Me.groupBoxPalettes.TabIndex = 0
        Me.groupBoxPalettes.TabStop = False
        Me.groupBoxPalettes.Text = "Palettes"
        Me.radioOffice2010Black.AutoSize = True
        Me.radioOffice2010Black.Location = New System.Drawing.Point(15, 66)
        Me.radioOffice2010Black.Name = "radioOffice2010Black"
        Me.radioOffice2010Black.Size = New System.Drawing.Size(143, 21)
        Me.radioOffice2010Black.TabIndex = 12
        Me.radioOffice2010Black.Text = "Office 2010 - Black"
        Me.radioOffice2010Black.UseVisualStyleBackColor = True
        Me.radioOffice2010Silver.AutoSize = True
        Me.radioOffice2010Silver.Location = New System.Drawing.Point(15, 43)
        Me.radioOffice2010Silver.Name = "radioOffice2010Silver"
        Me.radioOffice2010Silver.Size = New System.Drawing.Size(144, 21)
        Me.radioOffice2010Silver.TabIndex = 11
        Me.radioOffice2010Silver.Text = "Office 2010 - Silver"
        Me.radioOffice2010Silver.UseVisualStyleBackColor = True
        Me.radioOffice2010Blue.AutoSize = True
        Me.radioOffice2010Blue.Location = New System.Drawing.Point(15, 20)
        Me.radioOffice2010Blue.Name = "radioOffice2010Blue"
        Me.radioOffice2010Blue.Size = New System.Drawing.Size(137, 21)
        Me.radioOffice2010Blue.TabIndex = 10
        Me.radioOffice2010Blue.Text = "Office 2010 - Blue"
        Me.radioOffice2010Blue.UseVisualStyleBackColor = True
        Me.radioSparklePurple.AutoSize = True
        Me.radioSparklePurple.Location = New System.Drawing.Point(15, 250)
        Me.radioSparklePurple.Name = "radioSparklePurple"
        Me.radioSparklePurple.Size = New System.Drawing.Size(124, 21)
        Me.radioSparklePurple.TabIndex = 7
        Me.radioSparklePurple.Text = "Sparkle - Purple"
        Me.radioSparklePurple.UseVisualStyleBackColor = True
        Me.radioSparkleOrange.AutoSize = True
        Me.radioSparkleOrange.Location = New System.Drawing.Point(15, 227)
        Me.radioSparkleOrange.Name = "radioSparkleOrange"
        Me.radioSparkleOrange.Size = New System.Drawing.Size(131, 21)
        Me.radioSparkleOrange.TabIndex = 6
        Me.radioSparkleOrange.Text = "Sparkle - Orange"
        Me.radioSparkleOrange.UseVisualStyleBackColor = True
        Me.radioSparkleBlue.AutoSize = True
        Me.radioSparkleBlue.Checked = True
        Me.radioSparkleBlue.Location = New System.Drawing.Point(15, 204)
        Me.radioSparkleBlue.Name = "radioSparkleBlue"
        Me.radioSparkleBlue.Size = New System.Drawing.Size(111, 21)
        Me.radioSparkleBlue.TabIndex = 5
        Me.radioSparkleBlue.TabStop = True
        Me.radioSparkleBlue.Text = "Sparkle - Blue"
        Me.radioSparkleBlue.UseVisualStyleBackColor = True
        Me.radioOffice2007Black.AutoSize = True
        Me.radioOffice2007Black.Location = New System.Drawing.Point(15, 135)
        Me.radioOffice2007Black.Name = "radioOffice2007Black"
        Me.radioOffice2007Black.Size = New System.Drawing.Size(143, 21)
        Me.radioOffice2007Black.TabIndex = 2
        Me.radioOffice2007Black.Text = "Office 2007 - Black"
        Me.radioOffice2007Black.UseVisualStyleBackColor = True
        Me.radioOffice2007Silver.AutoSize = True
        Me.radioOffice2007Silver.Location = New System.Drawing.Point(15, 112)
        Me.radioOffice2007Silver.Name = "radioOffice2007Silver"
        Me.radioOffice2007Silver.Size = New System.Drawing.Size(144, 21)
        Me.radioOffice2007Silver.TabIndex = 1
        Me.radioOffice2007Silver.Text = "Office 2007 - Silver"
        Me.radioOffice2007Silver.UseVisualStyleBackColor = True
        Me.radioOffice2007Blue.AutoSize = True
        Me.radioOffice2007Blue.Location = New System.Drawing.Point(15, 89)
        Me.radioOffice2007Blue.Name = "radioOffice2007Blue"
        Me.radioOffice2007Blue.Size = New System.Drawing.Size(137, 21)
        Me.radioOffice2007Blue.TabIndex = 0
        Me.radioOffice2007Blue.Text = "Office 2007 - Blue"
        Me.radioOffice2007Blue.UseVisualStyleBackColor = True
        Me.radioLightweight.AutoSize = True
        Me.radioLightweight.Location = New System.Drawing.Point(15, 296)
        Me.radioLightweight.Name = "radioLightweight"
        Me.radioLightweight.Size = New System.Drawing.Size(151, 21)
        Me.radioLightweight.TabIndex = 9
        Me.radioLightweight.Text = "Custom Lightweight"
        Me.radioLightweight.UseVisualStyleBackColor = True
        Me.radioBlogger.AutoSize = True
        Me.radioBlogger.Location = New System.Drawing.Point(15, 273)
        Me.radioBlogger.Name = "radioBlogger"
        Me.radioBlogger.Size = New System.Drawing.Size(127, 21)
        Me.radioBlogger.TabIndex = 8
        Me.radioBlogger.Text = "Custom Blogger"
        Me.radioBlogger.UseVisualStyleBackColor = True
        Me.radioOffice2003.AutoSize = True
        Me.radioOffice2003.Location = New System.Drawing.Point(15, 158)
        Me.radioOffice2003.Name = "radioOffice2003"
        Me.radioOffice2003.Size = New System.Drawing.Size(183, 21)
        Me.radioOffice2003.TabIndex = 3
        Me.radioOffice2003.Text = "Professional - Office 2003"
        Me.radioOffice2003.UseVisualStyleBackColor = True
        Me.radioSystem.AutoSize = True
        Me.radioSystem.Location = New System.Drawing.Point(15, 181)
        Me.radioSystem.Name = "radioSystem"
        Me.radioSystem.Size = New System.Drawing.Size(159, 21)
        Me.radioSystem.TabIndex = 4
        Me.radioSystem.Text = "Professional - System"
        Me.radioSystem.UseVisualStyleBackColor = True
        Me.buttonClose.Location = New System.Drawing.Point(579, 359)
        Me.buttonClose.Name = "buttonClose"
        Me.buttonClose.Size = New System.Drawing.Size(75, 23)
        Me.buttonClose.TabIndex = 2
        Me.buttonClose.Text = "Close"
        Me.buttonClose.UseVisualStyleBackColor = True
        Me.kryptonPaletteBlogger.BasePaletteType = Krypton.Toolkit.BasePaletteType.Professional
        Me.kryptonPaletteBlogger.ButtonStyles.ButtonButtonSpec.StateDisabled.Border.Draw = Krypton.Toolkit.InheritBool.False
        Me.kryptonPaletteBlogger.ButtonStyles.ButtonButtonSpec.StateDisabled.Border.DrawBorders = CType((((Krypton.Toolkit.PaletteDrawBorders.Top Or Krypton.Toolkit.PaletteDrawBorders.Bottom) Or Krypton.Toolkit.PaletteDrawBorders.Left) Or Krypton.Toolkit.PaletteDrawBorders.Right), Krypton.Toolkit.PaletteDrawBorders)
        Me.kryptonPaletteBlogger.ButtonStyles.ButtonButtonSpec.StateNormal.Back.Draw = Krypton.Toolkit.InheritBool.False
        Me.kryptonPaletteBlogger.ButtonStyles.ButtonButtonSpec.StateNormal.Border.Color1 = System.Drawing.Color.Transparent
        Me.kryptonPaletteBlogger.ButtonStyles.ButtonButtonSpec.StateNormal.Border.Draw = Krypton.Toolkit.InheritBool.True
        Me.kryptonPaletteBlogger.ButtonStyles.ButtonButtonSpec.StateNormal.Border.DrawBorders = CType((((Krypton.Toolkit.PaletteDrawBorders.Top Or Krypton.Toolkit.PaletteDrawBorders.Bottom) Or Krypton.Toolkit.PaletteDrawBorders.Left) Or Krypton.Toolkit.PaletteDrawBorders.Right), Krypton.Toolkit.PaletteDrawBorders)
        Me.kryptonPaletteBlogger.ButtonStyles.ButtonButtonSpec.StateNormal.Content.LongText.Color1 = System.Drawing.Color.Black
        Me.kryptonPaletteBlogger.ButtonStyles.ButtonButtonSpec.StateNormal.Content.Padding = New System.Windows.Forms.Padding(3)
        Me.kryptonPaletteBlogger.ButtonStyles.ButtonButtonSpec.StateNormal.Content.ShortText.Color1 = System.Drawing.Color.Black
        Me.kryptonPaletteBlogger.ButtonStyles.ButtonCommon.StateCheckedNormal.Back.Color1 = System.Drawing.Color.FromArgb(CType(CType(192, Byte), Integer), CType(CType(64, Byte), Integer), CType(CType(0, Byte), Integer))
        Me.kryptonPaletteBlogger.ButtonStyles.ButtonCommon.StateCheckedPressed.Back.Color1 = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(102, Byte), Integer), CType(CType(0, Byte), Integer))
        Me.kryptonPaletteBlogger.ButtonStyles.ButtonCommon.StateCheckedPressed.Content.Padding = New System.Windows.Forms.Padding(5, 5, 1, 1)
        Me.kryptonPaletteBlogger.ButtonStyles.ButtonCommon.StateCheckedTracking.Back.Color1 = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(102, Byte), Integer), CType(CType(0, Byte), Integer))
        Me.kryptonPaletteBlogger.ButtonStyles.ButtonCommon.StateCommon.Back.ColorStyle = Krypton.Toolkit.PaletteColorStyle.Solid
        Me.kryptonPaletteBlogger.ButtonStyles.ButtonCommon.StateCommon.Border.Color1 = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(51, Byte), Integer), CType(CType(102, Byte), Integer))
        Me.kryptonPaletteBlogger.ButtonStyles.ButtonCommon.StateCommon.Border.ColorStyle = Krypton.Toolkit.PaletteColorStyle.Solid
        Me.kryptonPaletteBlogger.ButtonStyles.ButtonCommon.StateCommon.Border.DrawBorders = CType((((Krypton.Toolkit.PaletteDrawBorders.Top Or Krypton.Toolkit.PaletteDrawBorders.Bottom) Or Krypton.Toolkit.PaletteDrawBorders.Left) Or Krypton.Toolkit.PaletteDrawBorders.Right), Krypton.Toolkit.PaletteDrawBorders)
        Me.kryptonPaletteBlogger.ButtonStyles.ButtonCommon.StateCommon.Border.GraphicsHint = Krypton.Toolkit.PaletteGraphicsHint.AntiAlias
        Me.kryptonPaletteBlogger.ButtonStyles.ButtonCommon.StateCommon.Border.Rounding = 3F
        Me.kryptonPaletteBlogger.ButtonStyles.ButtonCommon.StateCommon.Border.Width = 2
        Me.kryptonPaletteBlogger.ButtonStyles.ButtonCommon.StateCommon.Content.LongText.Color1 = System.Drawing.Color.White
        Me.kryptonPaletteBlogger.ButtonStyles.ButtonCommon.StateCommon.Content.LongText.ColorStyle = Krypton.Toolkit.PaletteColorStyle.Solid
        Me.kryptonPaletteBlogger.ButtonStyles.ButtonCommon.StateCommon.Content.Padding = New System.Windows.Forms.Padding(3)
        Me.kryptonPaletteBlogger.ButtonStyles.ButtonCommon.StateCommon.Content.ShortText.Color1 = System.Drawing.Color.White
        Me.kryptonPaletteBlogger.ButtonStyles.ButtonCommon.StateCommon.Content.ShortText.ColorStyle = Krypton.Toolkit.PaletteColorStyle.Solid
        Me.kryptonPaletteBlogger.ButtonStyles.ButtonCommon.StateDisabled.Border.Color1 = System.Drawing.Color.Silver
        Me.kryptonPaletteBlogger.ButtonStyles.ButtonCommon.StateDisabled.Border.DrawBorders = CType((((Krypton.Toolkit.PaletteDrawBorders.Top Or Krypton.Toolkit.PaletteDrawBorders.Bottom) Or Krypton.Toolkit.PaletteDrawBorders.Left) Or Krypton.Toolkit.PaletteDrawBorders.Right), Krypton.Toolkit.PaletteDrawBorders)
        Me.kryptonPaletteBlogger.ButtonStyles.ButtonCommon.StateDisabled.Content.LongText.Color1 = System.Drawing.Color.Silver
        Me.kryptonPaletteBlogger.ButtonStyles.ButtonCommon.StateDisabled.Content.ShortText.Color1 = System.Drawing.Color.Silver
        Me.kryptonPaletteBlogger.ButtonStyles.ButtonCommon.StateNormal.Back.Color1 = System.Drawing.Color.FromArgb(CType(CType(51, Byte), Integer), CType(CType(102, Byte), Integer), CType(CType(204, Byte), Integer))
        Me.kryptonPaletteBlogger.ButtonStyles.ButtonCommon.StatePressed.Back.Color1 = System.Drawing.Color.FromArgb(CType(CType(102, Byte), Integer), CType(CType(153, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.kryptonPaletteBlogger.ButtonStyles.ButtonCommon.StatePressed.Content.Padding = New System.Windows.Forms.Padding(5, 5, 1, 1)
        Me.kryptonPaletteBlogger.ButtonStyles.ButtonCommon.StateTracking.Back.Color1 = System.Drawing.Color.FromArgb(CType(CType(102, Byte), Integer), CType(CType(153, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.kryptonPaletteBlogger.ButtonStyles.ButtonLowProfile.StateDisabled.Border.Draw = Krypton.Toolkit.InheritBool.False
        Me.kryptonPaletteBlogger.ButtonStyles.ButtonLowProfile.StateDisabled.Border.DrawBorders = CType((((Krypton.Toolkit.PaletteDrawBorders.Top Or Krypton.Toolkit.PaletteDrawBorders.Bottom) Or Krypton.Toolkit.PaletteDrawBorders.Left) Or Krypton.Toolkit.PaletteDrawBorders.Right), Krypton.Toolkit.PaletteDrawBorders)
        Me.kryptonPaletteBlogger.ButtonStyles.ButtonLowProfile.StateNormal.Back.Draw = Krypton.Toolkit.InheritBool.False
        Me.kryptonPaletteBlogger.ButtonStyles.ButtonLowProfile.StateNormal.Border.Color1 = System.Drawing.Color.Transparent
        Me.kryptonPaletteBlogger.ButtonStyles.ButtonLowProfile.StateNormal.Border.Draw = Krypton.Toolkit.InheritBool.True
        Me.kryptonPaletteBlogger.ButtonStyles.ButtonLowProfile.StateNormal.Border.DrawBorders = CType((((Krypton.Toolkit.PaletteDrawBorders.Top Or Krypton.Toolkit.PaletteDrawBorders.Bottom) Or Krypton.Toolkit.PaletteDrawBorders.Left) Or Krypton.Toolkit.PaletteDrawBorders.Right), Krypton.Toolkit.PaletteDrawBorders)
        Me.kryptonPaletteBlogger.ButtonStyles.ButtonLowProfile.StateNormal.Content.LongText.Color1 = System.Drawing.Color.Black
        Me.kryptonPaletteBlogger.ButtonStyles.ButtonLowProfile.StateNormal.Content.Padding = New System.Windows.Forms.Padding(3)
        Me.kryptonPaletteBlogger.ButtonStyles.ButtonLowProfile.StateNormal.Content.ShortText.Color1 = System.Drawing.Color.Black
        Me.kryptonPaletteBlogger.ButtonStyles.ButtonStandalone.OverrideDefault.Back.Color1 = System.Drawing.Color.FromArgb(CType(CType(51, Byte), Integer), CType(CType(102, Byte), Integer), CType(CType(204, Byte), Integer))
        Me.kryptonPaletteBlogger.ButtonStyles.ButtonStandalone.StateDisabled.Back.Color1 = System.Drawing.Color.FromArgb(CType(CType(245, Byte), Integer), CType(CType(237, Byte), Integer), CType(CType(227, Byte), Integer))
        Me.kryptonPaletteBlogger.ControlStyles.ControlCommon.StateCommon.Border.ColorStyle = Krypton.Toolkit.PaletteColorStyle.Solid
        Me.kryptonPaletteBlogger.ControlStyles.ControlCommon.StateCommon.Border.DrawBorders = CType((((Krypton.Toolkit.PaletteDrawBorders.Top Or Krypton.Toolkit.PaletteDrawBorders.Bottom) Or Krypton.Toolkit.PaletteDrawBorders.Left) Or Krypton.Toolkit.PaletteDrawBorders.Right), Krypton.Toolkit.PaletteDrawBorders)
        Me.kryptonPaletteBlogger.ControlStyles.ControlCommon.StateCommon.Border.GraphicsHint = Krypton.Toolkit.PaletteGraphicsHint.AntiAlias
        Me.kryptonPaletteBlogger.ControlStyles.ControlCommon.StateCommon.Border.Rounding = 9F
        Me.kryptonPaletteBlogger.ControlStyles.ControlCommon.StateCommon.Border.Width = 3
        Me.kryptonPaletteBlogger.ControlStyles.ControlCommon.StateDisabled.Border.Color1 = System.Drawing.Color.FromArgb(CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer))
        Me.kryptonPaletteBlogger.ControlStyles.ControlCommon.StateDisabled.Border.DrawBorders = CType((((Krypton.Toolkit.PaletteDrawBorders.Top Or Krypton.Toolkit.PaletteDrawBorders.Bottom) Or Krypton.Toolkit.PaletteDrawBorders.Left) Or Krypton.Toolkit.PaletteDrawBorders.Right), Krypton.Toolkit.PaletteDrawBorders)
        Me.kryptonPaletteBlogger.ControlStyles.ControlCommon.StateNormal.Border.Color1 = System.Drawing.Color.FromArgb(CType(CType(225, Byte), Integer), CType(CType(212, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.kryptonPaletteBlogger.ControlStyles.ControlCommon.StateNormal.Border.DrawBorders = CType((((Krypton.Toolkit.PaletteDrawBorders.Top Or Krypton.Toolkit.PaletteDrawBorders.Bottom) Or Krypton.Toolkit.PaletteDrawBorders.Left) Or Krypton.Toolkit.PaletteDrawBorders.Right), Krypton.Toolkit.PaletteDrawBorders)
        Me.kryptonPaletteBlogger.HeaderGroup.StateCommon.OverlayHeaders = Krypton.Toolkit.InheritBool.False
        Me.kryptonPaletteBlogger.HeaderGroup.StateCommon.PrimaryHeaderPadding = New System.Windows.Forms.Padding(3)
        Me.kryptonPaletteBlogger.HeaderGroup.StateCommon.SecondaryHeaderPadding = New System.Windows.Forms.Padding(3)
        Me.kryptonPaletteBlogger.HeaderStyles.HeaderCommon.StateCommon.Back.ColorStyle = Krypton.Toolkit.PaletteColorStyle.Linear
        Me.kryptonPaletteBlogger.HeaderStyles.HeaderCommon.StateCommon.Back.GraphicsHint = Krypton.Toolkit.PaletteGraphicsHint.AntiAlias
        Me.kryptonPaletteBlogger.HeaderStyles.HeaderCommon.StateCommon.Border.Draw = Krypton.Toolkit.InheritBool.False
        Me.kryptonPaletteBlogger.HeaderStyles.HeaderCommon.StateCommon.Border.DrawBorders = CType((((Krypton.Toolkit.PaletteDrawBorders.Top Or Krypton.Toolkit.PaletteDrawBorders.Bottom) Or Krypton.Toolkit.PaletteDrawBorders.Left) Or Krypton.Toolkit.PaletteDrawBorders.Right), Krypton.Toolkit.PaletteDrawBorders)
        Me.kryptonPaletteBlogger.HeaderStyles.HeaderCommon.StateCommon.Border.Rounding = 7F
        Me.kryptonPaletteBlogger.HeaderStyles.HeaderCommon.StateCommon.Border.Width = 3
        Me.kryptonPaletteBlogger.HeaderStyles.HeaderCommon.StateCommon.Content.AdjacentGap = 2
        Me.kryptonPaletteBlogger.HeaderStyles.HeaderCommon.StateCommon.Content.LongText.Color1 = System.Drawing.Color.Black
        Me.kryptonPaletteBlogger.HeaderStyles.HeaderCommon.StateCommon.Content.LongText.ColorStyle = Krypton.Toolkit.PaletteColorStyle.Solid
        Me.kryptonPaletteBlogger.HeaderStyles.HeaderCommon.StateCommon.Content.LongText.TextH = Krypton.Toolkit.PaletteRelativeAlign.Far
        Me.kryptonPaletteBlogger.HeaderStyles.HeaderCommon.StateCommon.Content.Padding = New System.Windows.Forms.Padding(10, 1, 10, 1)
        Me.kryptonPaletteBlogger.HeaderStyles.HeaderCommon.StateCommon.Content.ShortText.Color1 = System.Drawing.Color.Black
        Me.kryptonPaletteBlogger.HeaderStyles.HeaderCommon.StateCommon.Content.ShortText.ColorStyle = Krypton.Toolkit.PaletteColorStyle.Solid
        Me.kryptonPaletteBlogger.HeaderStyles.HeaderCommon.StateCommon.Content.ShortText.TextH = Krypton.Toolkit.PaletteRelativeAlign.Near
        Me.kryptonPaletteBlogger.HeaderStyles.HeaderCommon.StateDisabled.Content.LongText.Color1 = System.Drawing.Color.Silver
        Me.kryptonPaletteBlogger.HeaderStyles.HeaderCommon.StateDisabled.Content.ShortText.Color1 = System.Drawing.Color.Silver
        Me.kryptonPaletteBlogger.HeaderStyles.HeaderCustom1.StateDisabled.Back.Color1 = System.Drawing.Color.FromArgb(CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer))
        Me.kryptonPaletteBlogger.HeaderStyles.HeaderCustom1.StateDisabled.Back.Color2 = System.Drawing.Color.White
        Me.kryptonPaletteBlogger.HeaderStyles.HeaderCustom1.StateNormal.Back.Color1 = System.Drawing.Color.FromArgb(CType(CType(226, Byte), Integer), CType(CType(213, Byte), Integer), CType(CType(194, Byte), Integer))
        Me.kryptonPaletteBlogger.HeaderStyles.HeaderCustom1.StateNormal.Back.Color2 = System.Drawing.Color.White
        Me.kryptonPaletteBlogger.HeaderStyles.HeaderCustom2.StateDisabled.Back.Color1 = System.Drawing.Color.White
        Me.kryptonPaletteBlogger.HeaderStyles.HeaderCustom2.StateDisabled.Back.Color2 = System.Drawing.Color.FromArgb(CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer))
        Me.kryptonPaletteBlogger.HeaderStyles.HeaderCustom2.StateNormal.Back.Color1 = System.Drawing.Color.White
        Me.kryptonPaletteBlogger.HeaderStyles.HeaderCustom2.StateNormal.Back.Color2 = System.Drawing.Color.FromArgb(CType(CType(226, Byte), Integer), CType(CType(213, Byte), Integer), CType(CType(194, Byte), Integer))
        Me.kryptonPaletteBlogger.HeaderStyles.HeaderPrimary.StateDisabled.Back.Color1 = System.Drawing.Color.FromArgb(CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer))
        Me.kryptonPaletteBlogger.HeaderStyles.HeaderPrimary.StateDisabled.Back.Color2 = System.Drawing.Color.White
        Me.kryptonPaletteBlogger.HeaderStyles.HeaderPrimary.StateNormal.Back.Color1 = System.Drawing.Color.FromArgb(CType(CType(226, Byte), Integer), CType(CType(213, Byte), Integer), CType(CType(194, Byte), Integer))
        Me.kryptonPaletteBlogger.HeaderStyles.HeaderPrimary.StateNormal.Back.Color2 = System.Drawing.Color.White
        Me.kryptonPaletteBlogger.HeaderStyles.HeaderSecondary.StateDisabled.Back.Color1 = System.Drawing.Color.White
        Me.kryptonPaletteBlogger.HeaderStyles.HeaderSecondary.StateDisabled.Back.Color2 = System.Drawing.Color.FromArgb(CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer))
        Me.kryptonPaletteBlogger.HeaderStyles.HeaderSecondary.StateNormal.Back.Color1 = System.Drawing.Color.White
        Me.kryptonPaletteBlogger.HeaderStyles.HeaderSecondary.StateNormal.Back.Color2 = System.Drawing.Color.FromArgb(CType(CType(226, Byte), Integer), CType(CType(213, Byte), Integer), CType(CType(194, Byte), Integer))
        Me.kryptonPaletteBlogger.PanelStyles.PanelAlternate.StateCommon.Color1 = System.Drawing.Color.FromArgb(CType(CType(225, Byte), Integer), CType(CType(212, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.kryptonPaletteBlogger.PanelStyles.PanelClient.StateCommon.Color1 = System.Drawing.Color.FromArgb(CType(CType(245, Byte), Integer), CType(CType(237, Byte), Integer), CType(CType(227, Byte), Integer))
        Me.kryptonPaletteBlogger.PanelStyles.PanelCommon.StateCommon.ColorStyle = Krypton.Toolkit.PaletteColorStyle.Solid
        Me.kryptonPaletteBlogger.PanelStyles.PanelCustom1.StateCommon.Color1 = System.Drawing.Color.FromArgb(CType(CType(245, Byte), Integer), CType(CType(237, Byte), Integer), CType(CType(227, Byte), Integer))
        Me.kryptonPaletteBlogger.TabStyles.TabCommon.StateCommon.Back.ColorStyle = Krypton.Toolkit.PaletteColorStyle.Solid
        Me.kryptonPaletteBlogger.TabStyles.TabCommon.StateCommon.Border.DrawBorders = CType((((Krypton.Toolkit.PaletteDrawBorders.Top Or Krypton.Toolkit.PaletteDrawBorders.Bottom) Or Krypton.Toolkit.PaletteDrawBorders.Left) Or Krypton.Toolkit.PaletteDrawBorders.Right), Krypton.Toolkit.PaletteDrawBorders)
        Me.kryptonPaletteBlogger.TabStyles.TabCommon.StateCommon.Border.Width = 2
        Me.kryptonPaletteBlogger.TabStyles.TabCommon.StateCommon.Content.LongText.Color1 = System.Drawing.Color.White
        Me.kryptonPaletteBlogger.TabStyles.TabCommon.StateCommon.Content.LongText.ColorStyle = Krypton.Toolkit.PaletteColorStyle.Solid
        Me.kryptonPaletteBlogger.TabStyles.TabCommon.StateCommon.Content.Padding = New System.Windows.Forms.Padding(3, 5, 3, 5)
        Me.kryptonPaletteBlogger.TabStyles.TabCommon.StateCommon.Content.ShortText.Color1 = System.Drawing.Color.White
        Me.kryptonPaletteBlogger.TabStyles.TabCommon.StateCommon.Content.ShortText.ColorStyle = Krypton.Toolkit.PaletteColorStyle.Solid
        Me.kryptonPaletteBlogger.TabStyles.TabCommon.StateNormal.Back.Color1 = System.Drawing.Color.FromArgb(CType(CType(51, Byte), Integer), CType(CType(102, Byte), Integer), CType(CType(204, Byte), Integer))
        Me.kryptonPaletteBlogger.TabStyles.TabCommon.StateNormal.Back.Color2 = System.Drawing.Color.FromArgb(CType(CType(51, Byte), Integer), CType(CType(102, Byte), Integer), CType(CType(204, Byte), Integer))
        Me.kryptonPaletteBlogger.TabStyles.TabCommon.StateNormal.Back.ColorStyle = Krypton.Toolkit.PaletteColorStyle.Solid
        Me.kryptonPaletteBlogger.TabStyles.TabCommon.StatePressed.Back.Color1 = System.Drawing.Color.FromArgb(CType(CType(102, Byte), Integer), CType(CType(153, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.kryptonPaletteBlogger.TabStyles.TabCommon.StatePressed.Back.Color2 = System.Drawing.Color.FromArgb(CType(CType(102, Byte), Integer), CType(CType(153, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.kryptonPaletteBlogger.TabStyles.TabCommon.StatePressed.Back.ColorStyle = Krypton.Toolkit.PaletteColorStyle.Solid
        Me.kryptonPaletteBlogger.TabStyles.TabCommon.StatePressed.Content.Padding = New System.Windows.Forms.Padding(4, 6, 2, 4)
        Me.kryptonPaletteBlogger.TabStyles.TabCommon.StateSelected.Back.Color1 = System.Drawing.Color.White
        Me.kryptonPaletteBlogger.TabStyles.TabCommon.StateSelected.Back.Color2 = System.Drawing.Color.FromArgb(CType(CType(192, Byte), Integer), CType(CType(64, Byte), Integer), CType(CType(0, Byte), Integer))
        Me.kryptonPaletteBlogger.TabStyles.TabCommon.StateSelected.Back.ColorStyle = Krypton.Toolkit.PaletteColorStyle.QuarterPhase
        Me.kryptonPaletteBlogger.TabStyles.TabCommon.StateSelected.Border.Color1 = System.Drawing.Color.FromArgb(CType(CType(192, Byte), Integer), CType(CType(64, Byte), Integer), CType(CType(0, Byte), Integer))
        Me.kryptonPaletteBlogger.TabStyles.TabCommon.StateSelected.Border.DrawBorders = CType((((Krypton.Toolkit.PaletteDrawBorders.Top Or Krypton.Toolkit.PaletteDrawBorders.Bottom) Or Krypton.Toolkit.PaletteDrawBorders.Left) Or Krypton.Toolkit.PaletteDrawBorders.Right), Krypton.Toolkit.PaletteDrawBorders)
        Me.kryptonPaletteBlogger.TabStyles.TabCommon.StateTracking.Back.Color1 = System.Drawing.Color.FromArgb(CType(CType(102, Byte), Integer), CType(CType(153, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.kryptonPaletteBlogger.TabStyles.TabCommon.StateTracking.Back.Color2 = System.Drawing.Color.FromArgb(CType(CType(102, Byte), Integer), CType(CType(153, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.kryptonPaletteBlogger.TabStyles.TabCommon.StateTracking.Back.ColorStyle = Krypton.Toolkit.PaletteColorStyle.Solid
        Me.kryptonPaletteBlogger.TabStyles.TabLowProfile.StateCommon.Content.Padding = New System.Windows.Forms.Padding(3, 5, 3, 5)
        Me.kryptonPaletteBlogger.TabStyles.TabLowProfile.StateNormal.Back.Draw = Krypton.Toolkit.InheritBool.False
        Me.kryptonPaletteBlogger.TabStyles.TabLowProfile.StateNormal.Content.LongText.Color1 = System.Drawing.Color.Black
        Me.kryptonPaletteBlogger.TabStyles.TabLowProfile.StateNormal.Content.ShortText.Color1 = System.Drawing.Color.Black
        Me.kryptonPaletteBlogger.TabStyles.TabLowProfile.StatePressed.Back.Draw = Krypton.Toolkit.InheritBool.False
        Me.kryptonPaletteBlogger.TabStyles.TabLowProfile.StatePressed.Content.LongText.Color1 = System.Drawing.Color.Black
        Me.kryptonPaletteBlogger.TabStyles.TabLowProfile.StatePressed.Content.ShortText.Color1 = System.Drawing.Color.Black
        Me.kryptonPaletteBlogger.TabStyles.TabLowProfile.StateSelected.Back.Color1 = System.Drawing.Color.FromArgb(CType(CType(192, Byte), Integer), CType(CType(64, Byte), Integer), CType(CType(0, Byte), Integer))
        Me.kryptonPaletteBlogger.TabStyles.TabLowProfile.StateSelected.Border.Draw = Krypton.Toolkit.InheritBool.False
        Me.kryptonPaletteBlogger.TabStyles.TabLowProfile.StateSelected.Border.DrawBorders = CType((((Krypton.Toolkit.PaletteDrawBorders.Top Or Krypton.Toolkit.PaletteDrawBorders.Bottom) Or Krypton.Toolkit.PaletteDrawBorders.Left) Or Krypton.Toolkit.PaletteDrawBorders.Right), Krypton.Toolkit.PaletteDrawBorders)
        Me.kryptonPaletteBlogger.TabStyles.TabLowProfile.StateTracking.Back.Draw = Krypton.Toolkit.InheritBool.False
        Me.kryptonPaletteBlogger.TabStyles.TabLowProfile.StateTracking.Content.LongText.Color1 = System.Drawing.Color.Black
        Me.kryptonPaletteBlogger.TabStyles.TabLowProfile.StateTracking.Content.ShortText.Color1 = System.Drawing.Color.Black
        Me.kryptonPaletteBlogger.TabStyles.TabOneNote.StateCommon.Back.ColorStyle = Krypton.Toolkit.PaletteColorStyle.OneNote
        Me.kryptonPaletteBlogger.TabStyles.TabOneNote.StateSelected.Back.Color1 = System.Drawing.Color.FromArgb(CType(CType(192, Byte), Integer), CType(CType(64, Byte), Integer), CType(CType(0, Byte), Integer))
        Me.kryptonPaletteBlogger.TabStyles.TabStandardProfile.StateSelected.Back.Color1 = System.Drawing.Color.FromArgb(CType(CType(192, Byte), Integer), CType(CType(64, Byte), Integer), CType(CType(0, Byte), Integer))
        Me.kryptonPaletteBlogger.TabStyles.TabStandardProfile.StateSelected.Back.ColorStyle = Krypton.Toolkit.PaletteColorStyle.Solid
        Me.kryptonPaletteBlogger.ThemeName = "PaletteBase"
        Me.kryptonPaletteBlogger.ToolMenuStatus.Button.ButtonCheckedGradientBegin = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(102, Byte), Integer), CType(CType(0, Byte), Integer))
        Me.kryptonPaletteBlogger.ToolMenuStatus.Button.ButtonCheckedGradientEnd = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(102, Byte), Integer), CType(CType(0, Byte), Integer))
        Me.kryptonPaletteBlogger.ToolMenuStatus.Button.ButtonCheckedGradientMiddle = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(102, Byte), Integer), CType(CType(0, Byte), Integer))
        Me.kryptonPaletteBlogger.ToolMenuStatus.Button.ButtonCheckedHighlight = System.Drawing.Color.FromArgb(CType(CType(192, Byte), Integer), CType(CType(64, Byte), Integer), CType(CType(0, Byte), Integer))
        Me.kryptonPaletteBlogger.ToolMenuStatus.Button.ButtonCheckedHighlightBorder = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(51, Byte), Integer), CType(CType(102, Byte), Integer))
        Me.kryptonPaletteBlogger.ToolMenuStatus.Button.ButtonPressedBorder = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(51, Byte), Integer), CType(CType(102, Byte), Integer))
        Me.kryptonPaletteBlogger.ToolMenuStatus.Button.ButtonPressedGradientBegin = System.Drawing.Color.FromArgb(CType(CType(192, Byte), Integer), CType(CType(64, Byte), Integer), CType(CType(0, Byte), Integer))
        Me.kryptonPaletteBlogger.ToolMenuStatus.Button.ButtonPressedGradientEnd = System.Drawing.Color.FromArgb(CType(CType(192, Byte), Integer), CType(CType(64, Byte), Integer), CType(CType(0, Byte), Integer))
        Me.kryptonPaletteBlogger.ToolMenuStatus.Button.ButtonPressedGradientMiddle = System.Drawing.Color.FromArgb(CType(CType(192, Byte), Integer), CType(CType(64, Byte), Integer), CType(CType(0, Byte), Integer))
        Me.kryptonPaletteBlogger.ToolMenuStatus.Button.ButtonPressedHighlight = System.Drawing.Color.FromArgb(CType(CType(192, Byte), Integer), CType(CType(64, Byte), Integer), CType(CType(0, Byte), Integer))
        Me.kryptonPaletteBlogger.ToolMenuStatus.Button.ButtonPressedHighlightBorder = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(51, Byte), Integer), CType(CType(102, Byte), Integer))
        Me.kryptonPaletteBlogger.ToolMenuStatus.Button.ButtonSelectedBorder = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(51, Byte), Integer), CType(CType(102, Byte), Integer))
        Me.kryptonPaletteBlogger.ToolMenuStatus.Button.ButtonSelectedGradientBegin = System.Drawing.Color.FromArgb(CType(CType(102, Byte), Integer), CType(CType(153, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.kryptonPaletteBlogger.ToolMenuStatus.Button.ButtonSelectedGradientEnd = System.Drawing.Color.FromArgb(CType(CType(102, Byte), Integer), CType(CType(153, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.kryptonPaletteBlogger.ToolMenuStatus.Button.ButtonSelectedGradientMiddle = System.Drawing.Color.FromArgb(CType(CType(102, Byte), Integer), CType(CType(153, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.kryptonPaletteBlogger.ToolMenuStatus.Button.ButtonSelectedHighlight = System.Drawing.Color.FromArgb(CType(CType(102, Byte), Integer), CType(CType(153, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.kryptonPaletteBlogger.ToolMenuStatus.Button.ButtonSelectedHighlightBorder = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(51, Byte), Integer), CType(CType(102, Byte), Integer))
        Me.kryptonPaletteBlogger.ToolMenuStatus.Button.CheckBackground = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(102, Byte), Integer), CType(CType(0, Byte), Integer))
        Me.kryptonPaletteBlogger.ToolMenuStatus.Button.CheckPressedBackground = System.Drawing.Color.FromArgb(CType(CType(192, Byte), Integer), CType(CType(64, Byte), Integer), CType(CType(0, Byte), Integer))
        Me.kryptonPaletteBlogger.ToolMenuStatus.Button.CheckSelectedBackground = System.Drawing.Color.FromArgb(CType(CType(192, Byte), Integer), CType(CType(64, Byte), Integer), CType(CType(0, Byte), Integer))
        Me.kryptonPaletteBlogger.ToolMenuStatus.Button.OverflowButtonGradientBegin = System.Drawing.Color.FromArgb(CType(CType(102, Byte), Integer), CType(CType(153, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.kryptonPaletteBlogger.ToolMenuStatus.Button.OverflowButtonGradientEnd = System.Drawing.Color.FromArgb(CType(CType(26, Byte), Integer), CType(CType(77, Byte), Integer), CType(CType(144, Byte), Integer))
        Me.kryptonPaletteBlogger.ToolMenuStatus.Button.OverflowButtonGradientMiddle = System.Drawing.Color.FromArgb(CType(CType(76, Byte), Integer), CType(CType(126, Byte), Integer), CType(CType(226, Byte), Integer))
        Me.kryptonPaletteBlogger.ToolMenuStatus.Grip.GripDark = System.Drawing.Color.FromArgb(CType(CType(72, Byte), Integer), CType(CType(133, Byte), Integer), CType(CType(215, Byte), Integer))
        Me.kryptonPaletteBlogger.ToolMenuStatus.Grip.GripLight = System.Drawing.Color.Transparent
        Me.kryptonPaletteBlogger.ToolMenuStatus.Menu.ImageMarginGradientBegin = System.Drawing.Color.FromArgb(CType(CType(102, Byte), Integer), CType(CType(153, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.kryptonPaletteBlogger.ToolMenuStatus.Menu.ImageMarginGradientEnd = System.Drawing.Color.FromArgb(CType(CType(51, Byte), Integer), CType(CType(102, Byte), Integer), CType(CType(204, Byte), Integer))
        Me.kryptonPaletteBlogger.ToolMenuStatus.Menu.ImageMarginGradientMiddle = System.Drawing.Color.FromArgb(CType(CType(76, Byte), Integer), CType(CType(126, Byte), Integer), CType(CType(226, Byte), Integer))
        Me.kryptonPaletteBlogger.ToolMenuStatus.Menu.ImageMarginRevealedGradientBegin = System.Drawing.Color.FromArgb(CType(CType(102, Byte), Integer), CType(CType(153, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.kryptonPaletteBlogger.ToolMenuStatus.Menu.ImageMarginRevealedGradientEnd = System.Drawing.Color.FromArgb(CType(CType(51, Byte), Integer), CType(CType(102, Byte), Integer), CType(CType(204, Byte), Integer))
        Me.kryptonPaletteBlogger.ToolMenuStatus.Menu.ImageMarginRevealedGradientMiddle = System.Drawing.Color.FromArgb(CType(CType(76, Byte), Integer), CType(CType(126, Byte), Integer), CType(CType(226, Byte), Integer))
        Me.kryptonPaletteBlogger.ToolMenuStatus.Menu.MenuBorder = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(51, Byte), Integer), CType(CType(102, Byte), Integer))
        Me.kryptonPaletteBlogger.ToolMenuStatus.Menu.MenuItemBorder = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(51, Byte), Integer), CType(CType(102, Byte), Integer))
        Me.kryptonPaletteBlogger.ToolMenuStatus.Menu.MenuItemPressedGradientBegin = System.Drawing.Color.FromArgb(CType(CType(102, Byte), Integer), CType(CType(153, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.kryptonPaletteBlogger.ToolMenuStatus.Menu.MenuItemPressedGradientEnd = System.Drawing.Color.FromArgb(CType(CType(51, Byte), Integer), CType(CType(102, Byte), Integer), CType(CType(204, Byte), Integer))
        Me.kryptonPaletteBlogger.ToolMenuStatus.Menu.MenuItemPressedGradientMiddle = System.Drawing.Color.FromArgb(CType(CType(51, Byte), Integer), CType(CType(102, Byte), Integer), CType(CType(204, Byte), Integer))
        Me.kryptonPaletteBlogger.ToolMenuStatus.Menu.MenuItemSelected = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(102, Byte), Integer), CType(CType(0, Byte), Integer))
        Me.kryptonPaletteBlogger.ToolMenuStatus.Menu.MenuItemSelectedGradientBegin = System.Drawing.Color.FromArgb(CType(CType(102, Byte), Integer), CType(CType(153, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.kryptonPaletteBlogger.ToolMenuStatus.Menu.MenuItemSelectedGradientEnd = System.Drawing.Color.FromArgb(CType(CType(102, Byte), Integer), CType(CType(153, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.kryptonPaletteBlogger.ToolMenuStatus.Menu.MenuItemText = System.Drawing.Color.White
        Me.kryptonPaletteBlogger.ToolMenuStatus.MenuStrip.MenuStripGradientBegin = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(51, Byte), Integer), CType(CType(102, Byte), Integer))
        Me.kryptonPaletteBlogger.ToolMenuStatus.MenuStrip.MenuStripGradientEnd = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(51, Byte), Integer), CType(CType(102, Byte), Integer))
        Me.kryptonPaletteBlogger.ToolMenuStatus.MenuStrip.MenuStripText = System.Drawing.Color.WhiteSmoke
        Me.kryptonPaletteBlogger.ToolMenuStatus.Rafting.RaftingContainerGradientBegin = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(51, Byte), Integer), CType(CType(102, Byte), Integer))
        Me.kryptonPaletteBlogger.ToolMenuStatus.Rafting.RaftingContainerGradientEnd = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(51, Byte), Integer), CType(CType(102, Byte), Integer))
        Me.kryptonPaletteBlogger.ToolMenuStatus.Separator.SeparatorDark = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(51, Byte), Integer), CType(CType(102, Byte), Integer))
        Me.kryptonPaletteBlogger.ToolMenuStatus.Separator.SeparatorLight = System.Drawing.Color.Transparent
        Me.kryptonPaletteBlogger.ToolMenuStatus.StatusStrip.StatusStripGradientBegin = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(51, Byte), Integer), CType(CType(102, Byte), Integer))
        Me.kryptonPaletteBlogger.ToolMenuStatus.StatusStrip.StatusStripGradientEnd = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(51, Byte), Integer), CType(CType(102, Byte), Integer))
        Me.kryptonPaletteBlogger.ToolMenuStatus.StatusStrip.StatusStripText = System.Drawing.Color.WhiteSmoke
        Me.kryptonPaletteBlogger.ToolMenuStatus.ToolStrip.ToolStripBorder = System.Drawing.Color.FromArgb(CType(CType(26, Byte), Integer), CType(CType(77, Byte), Integer), CType(CType(144, Byte), Integer))
        Me.kryptonPaletteBlogger.ToolMenuStatus.ToolStrip.ToolStripContentPanelGradientBegin = System.Drawing.Color.FromArgb(CType(CType(245, Byte), Integer), CType(CType(237, Byte), Integer), CType(CType(227, Byte), Integer))
        Me.kryptonPaletteBlogger.ToolMenuStatus.ToolStrip.ToolStripContentPanelGradientEnd = System.Drawing.Color.FromArgb(CType(CType(245, Byte), Integer), CType(CType(237, Byte), Integer), CType(CType(227, Byte), Integer))
        Me.kryptonPaletteBlogger.ToolMenuStatus.ToolStrip.ToolStripDropDownBackground = System.Drawing.Color.FromArgb(CType(CType(102, Byte), Integer), CType(CType(153, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.kryptonPaletteBlogger.ToolMenuStatus.ToolStrip.ToolStripGradientBegin = System.Drawing.Color.FromArgb(CType(CType(26, Byte), Integer), CType(CType(77, Byte), Integer), CType(CType(144, Byte), Integer))
        Me.kryptonPaletteBlogger.ToolMenuStatus.ToolStrip.ToolStripGradientEnd = System.Drawing.Color.FromArgb(CType(CType(26, Byte), Integer), CType(CType(77, Byte), Integer), CType(CType(144, Byte), Integer))
        Me.kryptonPaletteBlogger.ToolMenuStatus.ToolStrip.ToolStripGradientMiddle = System.Drawing.Color.FromArgb(CType(CType(26, Byte), Integer), CType(CType(77, Byte), Integer), CType(CType(144, Byte), Integer))
        Me.kryptonPaletteBlogger.ToolMenuStatus.ToolStrip.ToolStripPanelGradientBegin = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(51, Byte), Integer), CType(CType(102, Byte), Integer))
        Me.kryptonPaletteBlogger.ToolMenuStatus.ToolStrip.ToolStripPanelGradientEnd = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(51, Byte), Integer), CType(CType(102, Byte), Integer))
        Me.kryptonPaletteBlogger.ToolMenuStatus.ToolStrip.ToolStripText = System.Drawing.Color.WhiteSmoke
        Me.kryptonPaletteBlogger.ToolMenuStatus.UseRoundedEdges = Krypton.Toolkit.InheritBool.False
        Me.kryptonPaletteBlogger.UseThemeFormChromeBorderWidth = Krypton.Toolkit.InheritBool.False
        Me.kryptonPaletteLightweight.BasePaletteType = Krypton.Toolkit.BasePaletteType.Professional
        Me.kryptonPaletteLightweight.ButtonStyles.ButtonCommon.StateCommon.Border.DrawBorders = CType((((Krypton.Toolkit.PaletteDrawBorders.Top Or Krypton.Toolkit.PaletteDrawBorders.Bottom) Or Krypton.Toolkit.PaletteDrawBorders.Left) Or Krypton.Toolkit.PaletteDrawBorders.Right), Krypton.Toolkit.PaletteDrawBorders)
        Me.kryptonPaletteLightweight.ButtonStyles.ButtonCommon.StateCommon.Border.GraphicsHint = Krypton.Toolkit.PaletteGraphicsHint.AntiAlias
        Me.kryptonPaletteLightweight.ButtonStyles.ButtonCommon.StateCommon.Border.Rounding = 4F
        Me.kryptonPaletteLightweight.ButtonStyles.ButtonCommon.StateCommon.Border.Width = 1
        Me.kryptonPaletteLightweight.ButtonStyles.ButtonCommon.StateCommon.Content.LongText.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25F)
        Me.kryptonPaletteLightweight.ButtonStyles.ButtonCommon.StateCommon.Content.LongText.Hint = Krypton.Toolkit.PaletteTextHint.ClearTypeGridFit
        Me.kryptonPaletteLightweight.ButtonStyles.ButtonCommon.StateCommon.Content.ShortText.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25F)
        Me.kryptonPaletteLightweight.ButtonStyles.ButtonCommon.StateCommon.Content.ShortText.Hint = Krypton.Toolkit.PaletteTextHint.ClearTypeGridFit
        Me.kryptonPaletteLightweight.ControlStyles.ControlAlternate.StateNormal.Back.Color1 = System.Drawing.Color.FromArgb(CType(CType(237, Byte), Integer), CType(CType(245, Byte), Integer), CType(CType(251, Byte), Integer))
        Me.kryptonPaletteLightweight.ControlStyles.ControlAlternate.StateNormal.Back.Color2 = System.Drawing.Color.FromArgb(CType(CType(237, Byte), Integer), CType(CType(245, Byte), Integer), CType(CType(251, Byte), Integer))
        Me.kryptonPaletteLightweight.ControlStyles.ControlClient.StateNormal.Back.Color1 = System.Drawing.Color.FromArgb(CType(CType(253, Byte), Integer), CType(CType(252, Byte), Integer), CType(CType(240, Byte), Integer))
        Me.kryptonPaletteLightweight.ControlStyles.ControlClient.StateNormal.Back.Color2 = System.Drawing.Color.FromArgb(CType(CType(253, Byte), Integer), CType(CType(252, Byte), Integer), CType(CType(240, Byte), Integer))
        Me.kryptonPaletteLightweight.ControlStyles.ControlCommon.StateCommon.Border.Color1 = System.Drawing.Color.FromArgb(CType(CType(205, Byte), Integer), CType(CType(205, Byte), Integer), CType(CType(205, Byte), Integer))
        Me.kryptonPaletteLightweight.ControlStyles.ControlCommon.StateCommon.Border.ColorStyle = Krypton.Toolkit.PaletteColorStyle.Solid
        Me.kryptonPaletteLightweight.ControlStyles.ControlCommon.StateCommon.Border.DrawBorders = CType((((Krypton.Toolkit.PaletteDrawBorders.Top Or Krypton.Toolkit.PaletteDrawBorders.Bottom) Or Krypton.Toolkit.PaletteDrawBorders.Left) Or Krypton.Toolkit.PaletteDrawBorders.Right), Krypton.Toolkit.PaletteDrawBorders)
        Me.kryptonPaletteLightweight.ControlStyles.ControlCommon.StateCommon.Border.GraphicsHint = Krypton.Toolkit.PaletteGraphicsHint.AntiAlias
        Me.kryptonPaletteLightweight.ControlStyles.ControlCommon.StateCommon.Border.Rounding = 6F
        Me.kryptonPaletteLightweight.ControlStyles.ControlCommon.StateCommon.Border.Width = 1
        Me.kryptonPaletteLightweight.ControlStyles.ControlCommon.StateDisabled.Back.Color1 = System.Drawing.Color.WhiteSmoke
        Me.kryptonPaletteLightweight.ControlStyles.ControlCommon.StateDisabled.Back.Color2 = System.Drawing.Color.WhiteSmoke
        Me.kryptonPaletteLightweight.ControlStyles.ControlCustom1.StateNormal.Back.Color1 = System.Drawing.Color.FromArgb(CType(CType(253, Byte), Integer), CType(CType(252, Byte), Integer), CType(CType(240, Byte), Integer))
        Me.kryptonPaletteLightweight.HeaderGroup.StateCommon.OverlayHeaders = Krypton.Toolkit.InheritBool.False
        Me.kryptonPaletteLightweight.HeaderGroup.StateCommon.PrimaryHeaderPadding = New System.Windows.Forms.Padding(4, 2, 4, 2)
        Me.kryptonPaletteLightweight.HeaderGroup.StateCommon.SecondaryHeaderPadding = New System.Windows.Forms.Padding(4, 2, 4, 2)
        Me.kryptonPaletteLightweight.HeaderStyles.HeaderCommon.StateCommon.Back.Color1 = System.Drawing.Color.FromArgb(CType(CType(253, Byte), Integer), CType(CType(252, Byte), Integer), CType(CType(240, Byte), Integer))
        Me.kryptonPaletteLightweight.HeaderStyles.HeaderCommon.StateCommon.Back.ColorStyle = Krypton.Toolkit.PaletteColorStyle.Solid
        Me.kryptonPaletteLightweight.HeaderStyles.HeaderCommon.StateCommon.Border.Draw = Krypton.Toolkit.InheritBool.False
        Me.kryptonPaletteLightweight.HeaderStyles.HeaderCommon.StateCommon.Border.DrawBorders = CType((((Krypton.Toolkit.PaletteDrawBorders.Top Or Krypton.Toolkit.PaletteDrawBorders.Bottom) Or Krypton.Toolkit.PaletteDrawBorders.Left) Or Krypton.Toolkit.PaletteDrawBorders.Right), Krypton.Toolkit.PaletteDrawBorders)
        Me.kryptonPaletteLightweight.HeaderStyles.HeaderCommon.StateCommon.Content.LongText.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25F)
        Me.kryptonPaletteLightweight.HeaderStyles.HeaderCommon.StateCommon.Content.LongText.Hint = Krypton.Toolkit.PaletteTextHint.ClearTypeGridFit
        Me.kryptonPaletteLightweight.HeaderStyles.HeaderCommon.StateCommon.Content.ShortText.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25F)
        Me.kryptonPaletteLightweight.HeaderStyles.HeaderCommon.StateCommon.Content.ShortText.Hint = Krypton.Toolkit.PaletteTextHint.ClearTypeGridFit
        Me.kryptonPaletteLightweight.HeaderStyles.HeaderCommon.StateDisabled.Back.Color1 = System.Drawing.Color.WhiteSmoke
        Me.kryptonPaletteLightweight.HeaderStyles.HeaderCommon.StateDisabled.Back.ColorStyle = Krypton.Toolkit.PaletteColorStyle.Solid
        Me.kryptonPaletteLightweight.HeaderStyles.HeaderCommon.StateDisabled.Content.LongText.Color1 = System.Drawing.Color.Silver
        Me.kryptonPaletteLightweight.HeaderStyles.HeaderCommon.StateDisabled.Content.ShortText.Color1 = System.Drawing.Color.Silver
        Me.kryptonPaletteLightweight.HeaderStyles.HeaderCommon.StateNormal.Content.LongText.Color1 = System.Drawing.Color.Black
        Me.kryptonPaletteLightweight.HeaderStyles.HeaderCommon.StateNormal.Content.ShortText.Color1 = System.Drawing.Color.Black
        Me.kryptonPaletteLightweight.HeaderStyles.HeaderCommon.StateNormal.Content.ShortText.ColorStyle = Krypton.Toolkit.PaletteColorStyle.Solid
        Me.kryptonPaletteLightweight.HeaderStyles.HeaderPrimary.StateCommon.Content.ShortText.Font = New System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold)
        Me.kryptonPaletteLightweight.LabelStyles.LabelCommon.StateCommon.LongText.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25F)
        Me.kryptonPaletteLightweight.LabelStyles.LabelCommon.StateCommon.LongText.Hint = Krypton.Toolkit.PaletteTextHint.ClearTypeGridFit
        Me.kryptonPaletteLightweight.LabelStyles.LabelCommon.StateCommon.ShortText.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25F)
        Me.kryptonPaletteLightweight.LabelStyles.LabelCommon.StateCommon.ShortText.Hint = Krypton.Toolkit.PaletteTextHint.ClearTypeGridFit
        Me.kryptonPaletteLightweight.LabelStyles.LabelTitleControl.StateCommon.ShortText.Font = New System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold)
        Me.kryptonPaletteLightweight.PanelStyles.PanelAlternate.StateCommon.Color1 = System.Drawing.Color.WhiteSmoke
        Me.kryptonPaletteLightweight.PanelStyles.PanelClient.StateCommon.Color1 = System.Drawing.Color.White
        Me.kryptonPaletteLightweight.PanelStyles.PanelCommon.StateCommon.ColorStyle = Krypton.Toolkit.PaletteColorStyle.Solid
        Me.kryptonPaletteLightweight.PanelStyles.PanelCustom1.StateCommon.Color1 = System.Drawing.Color.White
        Me.kryptonPaletteLightweight.TabStyles.TabCommon.StateCommon.Border.Color1 = System.Drawing.Color.FromArgb(CType(CType(205, Byte), Integer), CType(CType(205, Byte), Integer), CType(CType(205, Byte), Integer))
        Me.kryptonPaletteLightweight.TabStyles.TabCommon.StateCommon.Border.Color2 = System.Drawing.Color.FromArgb(CType(CType(205, Byte), Integer), CType(CType(205, Byte), Integer), CType(CType(205, Byte), Integer))
        Me.kryptonPaletteLightweight.TabStyles.TabCommon.StateCommon.Border.DrawBorders = CType((((Krypton.Toolkit.PaletteDrawBorders.Top Or Krypton.Toolkit.PaletteDrawBorders.Bottom) Or Krypton.Toolkit.PaletteDrawBorders.Left) Or Krypton.Toolkit.PaletteDrawBorders.Right), Krypton.Toolkit.PaletteDrawBorders)
        Me.kryptonPaletteLightweight.TabStyles.TabCommon.StateSelected.Back.Color1 = System.Drawing.Color.FromArgb(CType(CType(253, Byte), Integer), CType(CType(252, Byte), Integer), CType(CType(240, Byte), Integer))
        Me.kryptonPaletteLightweight.TabStyles.TabCommon.StateSelected.Back.Color2 = System.Drawing.Color.FromArgb(CType(CType(253, Byte), Integer), CType(CType(252, Byte), Integer), CType(CType(240, Byte), Integer))
        Me.kryptonPaletteLightweight.TabStyles.TabHighProfile.StateSelected.Back.Color1 = System.Drawing.SystemColors.GradientInactiveCaption
        Me.kryptonPaletteLightweight.TabStyles.TabHighProfile.StateSelected.Back.ColorStyle = Krypton.Toolkit.PaletteColorStyle.QuarterPhase
        Me.kryptonPaletteLightweight.TabStyles.TabLowProfile.StateNormal.Border.Draw = Krypton.Toolkit.InheritBool.False
        Me.kryptonPaletteLightweight.TabStyles.TabLowProfile.StateNormal.Border.DrawBorders = CType((((Krypton.Toolkit.PaletteDrawBorders.Top Or Krypton.Toolkit.PaletteDrawBorders.Bottom) Or Krypton.Toolkit.PaletteDrawBorders.Left) Or Krypton.Toolkit.PaletteDrawBorders.Right), Krypton.Toolkit.PaletteDrawBorders)
        Me.kryptonPaletteLightweight.TabStyles.TabLowProfile.StateTracking.Border.Draw = Krypton.Toolkit.InheritBool.False
        Me.kryptonPaletteLightweight.TabStyles.TabLowProfile.StateTracking.Border.DrawBorders = CType((((Krypton.Toolkit.PaletteDrawBorders.Top Or Krypton.Toolkit.PaletteDrawBorders.Bottom) Or Krypton.Toolkit.PaletteDrawBorders.Left) Or Krypton.Toolkit.PaletteDrawBorders.Right), Krypton.Toolkit.PaletteDrawBorders)
        Me.kryptonPaletteLightweight.ThemeName = "PaletteBase"
        Me.kryptonPaletteLightweight.UseThemeFormChromeBorderWidth = Krypton.Toolkit.InheritBool.False
        Me.kryptonManager.GlobalPaletteMode = Krypton.Toolkit.PaletteMode.SparkleBlue
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8F, 17F)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(700, 394)
        Me.Controls.Add(Me.buttonClose)
        Me.Controls.Add(Me.groupBoxPalettes)
        Me.Controls.Add(Me.kryptonNavigator1)
        Me.Font = New System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.MaximizeBox = False
        Me.MinimizeBox = False
        Me.Name = "Form1"
        Me.Text = "Navigator Palettes"
        CType(Me.kryptonNavigator1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.kryptonNavigator1.ResumeLayout(False)
        CType(Me.kryptonPage1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.kryptonPage2, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.kryptonPage3, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.kryptonPage4, System.ComponentModel.ISupportInitialize).EndInit()
        Me.groupBoxPalettes.ResumeLayout(False)
        Me.groupBoxPalettes.PerformLayout()
        Me.ResumeLayout(False)
    End Sub

    Friend WithEvents kryptonNavigator1 As Krypton.Navigator.KryptonNavigator
    Friend WithEvents kryptonPage1 As Krypton.Navigator.KryptonPage
    Friend WithEvents kryptonPage2 As Krypton.Navigator.KryptonPage
    Friend WithEvents kryptonPage3 As Krypton.Navigator.KryptonPage
    Friend WithEvents kryptonPage4 As Krypton.Navigator.KryptonPage
    Friend WithEvents groupBoxPalettes As System.Windows.Forms.GroupBox
    Friend WithEvents radioLightweight As System.Windows.Forms.RadioButton
    Friend WithEvents radioBlogger As System.Windows.Forms.RadioButton
    Friend WithEvents radioOffice2003 As System.Windows.Forms.RadioButton
    Friend WithEvents radioSystem As System.Windows.Forms.RadioButton
    Friend WithEvents buttonClose As System.Windows.Forms.Button
    Friend WithEvents kryptonPaletteBlogger As Krypton.Toolkit.KryptonCustomPaletteBase
    Friend WithEvents kryptonPaletteLightweight As Krypton.Toolkit.KryptonCustomPaletteBase
    Friend WithEvents radioOffice2007Black As System.Windows.Forms.RadioButton
    Friend WithEvents radioOffice2007Silver As System.Windows.Forms.RadioButton
    Friend WithEvents radioOffice2007Blue As System.Windows.Forms.RadioButton
    Friend WithEvents kryptonManager As Krypton.Toolkit.KryptonManager
    Friend WithEvents radioSparkleBlue As System.Windows.Forms.RadioButton
    Friend WithEvents radioSparklePurple As System.Windows.Forms.RadioButton
    Friend WithEvents radioSparkleOrange As System.Windows.Forms.RadioButton
    Friend WithEvents radioOffice2010Black As System.Windows.Forms.RadioButton
    Friend WithEvents radioOffice2010Silver As System.Windows.Forms.RadioButton
    Friend WithEvents radioOffice2010Blue As System.Windows.Forms.RadioButton
End Class
