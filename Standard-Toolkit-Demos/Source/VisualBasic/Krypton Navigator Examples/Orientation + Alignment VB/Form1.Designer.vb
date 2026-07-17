' VB.NET twin of Source\Krypton Navigator Examples\Orientation + Alignment\Form1.Designer.cs (Bastion Phase 4c).
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
        Me.groupBoxBarOrientation = New System.Windows.Forms.GroupBox()
        Me.radioOrientationRight = New System.Windows.Forms.RadioButton()
        Me.radioOrientationLeft = New System.Windows.Forms.RadioButton()
        Me.radioOrientationBottom = New System.Windows.Forms.RadioButton()
        Me.radioOrientationTop = New System.Windows.Forms.RadioButton()
        Me.groupBoxItemOrientation = New System.Windows.Forms.GroupBox()
        Me.radioItemFixedRight = New System.Windows.Forms.RadioButton()
        Me.radioItemFixedLeft = New System.Windows.Forms.RadioButton()
        Me.radioItemFixedBottom = New System.Windows.Forms.RadioButton()
        Me.radioItemFixedTop = New System.Windows.Forms.RadioButton()
        Me.radioItemAuto = New System.Windows.Forms.RadioButton()
        Me.groupBoxItemAlignment = New System.Windows.Forms.GroupBox()
        Me.radioItemFar = New System.Windows.Forms.RadioButton()
        Me.radioItemCenter = New System.Windows.Forms.RadioButton()
        Me.radioItemNear = New System.Windows.Forms.RadioButton()
        Me.groupBoxItemSizing = New System.Windows.Forms.GroupBox()
        Me.radioSizingSameWidthHeight = New System.Windows.Forms.RadioButton()
        Me.radioSizingSameWidth = New System.Windows.Forms.RadioButton()
        Me.radioSizingSameHeight = New System.Windows.Forms.RadioButton()
        Me.radioSizingIndividual = New System.Windows.Forms.RadioButton()
        Me.groupBoxItemSizes = New System.Windows.Forms.GroupBox()
        Me.numericUpDownBarFirstItemInset = New System.Windows.Forms.NumericUpDown()
        Me.label2 = New System.Windows.Forms.Label()
        Me.labelMaxSizeComma = New System.Windows.Forms.Label()
        Me.labelMinSizeComma = New System.Windows.Forms.Label()
        Me.numericUpDownMaxItemSizeY = New System.Windows.Forms.NumericUpDown()
        Me.numericUpDownMinItemSizeY = New System.Windows.Forms.NumericUpDown()
        Me.numericUpDownBarMinHeight = New System.Windows.Forms.NumericUpDown()
        Me.label1 = New System.Windows.Forms.Label()
        Me.numericUpDownMaxItemSizeX = New System.Windows.Forms.NumericUpDown()
        Me.labelMaxItemSize = New System.Windows.Forms.Label()
        Me.labelMinItemSize = New System.Windows.Forms.Label()
        Me.numericUpDownMinItemSizeX = New System.Windows.Forms.NumericUpDown()
        Me.buttonClose = New System.Windows.Forms.Button()
        Me.groupBox1 = New System.Windows.Forms.GroupBox()
        Me.radioModeRibbonTabs = New System.Windows.Forms.RadioButton()
        Me.radioModesCheckButton = New System.Windows.Forms.RadioButton()
        Me.radioModeTabs = New System.Windows.Forms.RadioButton()
        Me.kryptonManager1 = New Krypton.Toolkit.KryptonManager(Me.components)
        CType(Me.kryptonNavigator1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.kryptonNavigator1.SuspendLayout()
        CType(Me.kryptonPage1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.kryptonPage2, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.kryptonPage3, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.kryptonPage4, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.groupBoxBarOrientation.SuspendLayout()
        Me.groupBoxItemOrientation.SuspendLayout()
        Me.groupBoxItemAlignment.SuspendLayout()
        Me.groupBoxItemSizing.SuspendLayout()
        Me.groupBoxItemSizes.SuspendLayout()
        CType(Me.numericUpDownBarFirstItemInset, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.numericUpDownMaxItemSizeY, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.numericUpDownMinItemSizeY, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.numericUpDownBarMinHeight, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.numericUpDownMaxItemSizeX, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.numericUpDownMinItemSizeX, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.groupBox1.SuspendLayout()
        Me.SuspendLayout()
        Me.kryptonNavigator1.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) Or System.Windows.Forms.AnchorStyles.Left) Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.kryptonNavigator1.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowOnly
        Me.kryptonNavigator1.Bar.BarMapExtraText = Krypton.Navigator.MapKryptonPageText.None
        Me.kryptonNavigator1.Bar.BarMapImage = Krypton.Navigator.MapKryptonPageImage.Small
        Me.kryptonNavigator1.Bar.BarMapText = Krypton.Navigator.MapKryptonPageText.TextTitle
        Me.kryptonNavigator1.Bar.BarMultiline = Krypton.Navigator.BarMultiline.Singleline
        Me.kryptonNavigator1.Bar.BarOrientation = Krypton.Toolkit.VisualOrientation.Top
        Me.kryptonNavigator1.Bar.CheckButtonStyle = Krypton.Toolkit.ButtonStyle.Standalone
        Me.kryptonNavigator1.Bar.ItemAlignment = Krypton.Toolkit.RelativePositionAlign.Near
        Me.kryptonNavigator1.Bar.ItemMaximumSize = New System.Drawing.Size(200, 200)
        Me.kryptonNavigator1.Bar.ItemMinimumSize = New System.Drawing.Size(20, 20)
        Me.kryptonNavigator1.Bar.ItemOrientation = Krypton.Toolkit.ButtonOrientation.Auto
        Me.kryptonNavigator1.Bar.ItemSizing = Krypton.Navigator.BarItemSizing.SameHeight
        Me.kryptonNavigator1.Bar.TabBorderStyle = Krypton.Toolkit.TabBorderStyle.RoundedEqualMedium
        Me.kryptonNavigator1.Bar.TabStyle = Krypton.Toolkit.TabStyle.HighProfile
        Me.kryptonNavigator1.Button.ButtonDisplayLogic = Krypton.Navigator.ButtonDisplayLogic.None
        Me.kryptonNavigator1.Button.CloseButtonAction = Krypton.Navigator.CloseButtonAction.RemovePageAndDispose
        Me.kryptonNavigator1.Button.CloseButtonDisplay = Krypton.Navigator.ButtonDisplay.Hide
        Me.kryptonNavigator1.Button.ContextButtonAction = Krypton.Navigator.ContextButtonAction.SelectPage
        Me.kryptonNavigator1.Button.ContextButtonDisplay = Krypton.Navigator.ButtonDisplay.Logic
        Me.kryptonNavigator1.Button.ContextMenuMapImage = Krypton.Navigator.MapKryptonPageImage.Small
        Me.kryptonNavigator1.Button.ContextMenuMapText = Krypton.Navigator.MapKryptonPageText.TextTitle
        Me.kryptonNavigator1.Button.NextButtonAction = Krypton.Navigator.DirectionButtonAction.ModeAppropriateAction
        Me.kryptonNavigator1.Button.NextButtonDisplay = Krypton.Navigator.ButtonDisplay.Logic
        Me.kryptonNavigator1.Button.PreviousButtonAction = Krypton.Navigator.DirectionButtonAction.ModeAppropriateAction
        Me.kryptonNavigator1.Button.PreviousButtonDisplay = Krypton.Navigator.ButtonDisplay.Logic
        Me.kryptonNavigator1.Group.GroupBackStyle = Krypton.Toolkit.PaletteBackStyle.ControlClient
        Me.kryptonNavigator1.Group.GroupBorderStyle = Krypton.Toolkit.PaletteBorderStyle.ControlClient
        Me.kryptonNavigator1.Header.HeaderPositionBar = Krypton.Toolkit.VisualOrientation.Top
        Me.kryptonNavigator1.Header.HeaderPositionPrimary = Krypton.Toolkit.VisualOrientation.Top
        Me.kryptonNavigator1.Header.HeaderPositionSecondary = Krypton.Toolkit.VisualOrientation.Bottom
        Me.kryptonNavigator1.Header.HeaderStyleBar = Krypton.Toolkit.HeaderStyle.Secondary
        Me.kryptonNavigator1.Header.HeaderStylePrimary = Krypton.Toolkit.HeaderStyle.Primary
        Me.kryptonNavigator1.Header.HeaderStyleSecondary = Krypton.Toolkit.HeaderStyle.Secondary
        Me.kryptonNavigator1.Location = New System.Drawing.Point(166, 18)
        Me.kryptonNavigator1.Name = "kryptonNavigator1"
        Me.kryptonNavigator1.NavigatorMode = Krypton.Navigator.NavigatorMode.BarTabGroup
        Me.kryptonNavigator1.PageBackStyle = Krypton.Toolkit.PaletteBackStyle.ControlClient
        Me.kryptonNavigator1.Pages.AddRange(New Krypton.Navigator.KryptonPage() { Me.kryptonPage1, Me.kryptonPage2, Me.kryptonPage3, Me.kryptonPage4})
        Me.kryptonNavigator1.Panel.PanelBackStyle = Krypton.Toolkit.PaletteBackStyle.PanelClient
        Me.kryptonNavigator1.SelectedIndex = 3
        Me.kryptonNavigator1.Size = New System.Drawing.Size(383, 338)
        Me.kryptonNavigator1.StateCommon.CheckButton.Content.Draw = Krypton.Toolkit.InheritBool.Inherit
        Me.kryptonNavigator1.StateCommon.CheckButton.Content.DrawFocus = Krypton.Toolkit.InheritBool.Inherit
        Me.kryptonNavigator1.StateCommon.CheckButton.Content.Image.Effect = Krypton.Toolkit.PaletteImageEffect.Inherit
        Me.kryptonNavigator1.StateCommon.CheckButton.Content.Image.ImageH = Krypton.Toolkit.PaletteRelativeAlign.Center
        Me.kryptonNavigator1.StateCommon.CheckButton.Content.Image.ImageV = Krypton.Toolkit.PaletteRelativeAlign.Center
        Me.kryptonNavigator1.StateCommon.CheckButton.Content.Padding = New System.Windows.Forms.Padding(-1)
        Me.kryptonNavigator1.StateCommon.CheckButton.Content.ShortText.ColorAlign = Krypton.Toolkit.PaletteRectangleAlign.Inherit
        Me.kryptonNavigator1.StateCommon.CheckButton.Content.ShortText.ColorStyle = Krypton.Toolkit.PaletteColorStyle.Inherit
        Me.kryptonNavigator1.StateCommon.CheckButton.Content.ShortText.Hint = Krypton.Toolkit.PaletteTextHint.Inherit
        Me.kryptonNavigator1.StateCommon.CheckButton.Content.ShortText.ImageAlign = Krypton.Toolkit.PaletteRectangleAlign.Inherit
        Me.kryptonNavigator1.StateCommon.CheckButton.Content.ShortText.ImageStyle = Krypton.Toolkit.PaletteImageStyle.Inherit
        Me.kryptonNavigator1.StateCommon.CheckButton.Content.ShortText.MultiLine = Krypton.Toolkit.InheritBool.Inherit
        Me.kryptonNavigator1.StateCommon.CheckButton.Content.ShortText.MultiLineH = Krypton.Toolkit.PaletteRelativeAlign.Inherit
        Me.kryptonNavigator1.StateCommon.CheckButton.Content.ShortText.Prefix = Krypton.Toolkit.PaletteTextHotkeyPrefix.Inherit
        Me.kryptonNavigator1.StateCommon.CheckButton.Content.ShortText.TextH = Krypton.Toolkit.PaletteRelativeAlign.Center
        Me.kryptonNavigator1.StateCommon.CheckButton.Content.ShortText.TextV = Krypton.Toolkit.PaletteRelativeAlign.Far
        Me.kryptonNavigator1.StateCommon.CheckButton.Content.ShortText.Trim = Krypton.Toolkit.PaletteTextTrim.Inherit
        Me.kryptonNavigator1.TabIndex = 0
        Me.kryptonNavigator1.Text = "kryptonNavigator1"
        Me.kryptonPage1.AutoHiddenSlideSize = New System.Drawing.Size(200, 200)
        Me.kryptonPage1.Flags = 65534
        Me.kryptonPage1.ImageLarge = CType(resources.GetObject("kryptonPage1.ImageLarge"), System.Drawing.Bitmap)
        Me.kryptonPage1.ImageMedium = CType(resources.GetObject("kryptonPage1.ImageMedium"), System.Drawing.Bitmap)
        Me.kryptonPage1.ImageSmall = CType(resources.GetObject("kryptonPage1.ImageSmall"), System.Drawing.Bitmap)
        Me.kryptonPage1.LastVisibleSet = True
        Me.kryptonPage1.MinimumSize = New System.Drawing.Size(50, 50)
        Me.kryptonPage1.Name = "kryptonPage1"
        Me.kryptonPage1.Size = New System.Drawing.Size(381, 298)
        Me.kryptonPage1.Text = "One"
        Me.kryptonPage1.ToolTipTitle = "Page ToolTip"
        Me.kryptonPage1.UniqueName = "D9FC21A91AC9495DD9FC21A91AC9495D"
        Me.kryptonPage2.AutoHiddenSlideSize = New System.Drawing.Size(200, 200)
        Me.kryptonPage2.Flags = 65534
        Me.kryptonPage2.ImageLarge = CType(resources.GetObject("kryptonPage2.ImageLarge"), System.Drawing.Bitmap)
        Me.kryptonPage2.ImageMedium = CType(resources.GetObject("kryptonPage2.ImageMedium"), System.Drawing.Bitmap)
        Me.kryptonPage2.ImageSmall = CType(resources.GetObject("kryptonPage2.ImageSmall"), System.Drawing.Bitmap)
        Me.kryptonPage2.LastVisibleSet = True
        Me.kryptonPage2.MinimumSize = New System.Drawing.Size(50, 50)
        Me.kryptonPage2.Name = "kryptonPage2"
        Me.kryptonPage2.Size = New System.Drawing.Size(381, 298)
        Me.kryptonPage2.Text = "Second Page"
        Me.kryptonPage2.ToolTipTitle = "Page ToolTip"
        Me.kryptonPage2.UniqueName = "3FE5A65E0C4647C33FE5A65E0C4647C3"
        Me.kryptonPage3.AutoHiddenSlideSize = New System.Drawing.Size(200, 200)
        Me.kryptonPage3.Flags = 65534
        Me.kryptonPage3.ImageLarge = CType(resources.GetObject("kryptonPage3.ImageLarge"), System.Drawing.Bitmap)
        Me.kryptonPage3.ImageMedium = CType(resources.GetObject("kryptonPage3.ImageMedium"), System.Drawing.Bitmap)
        Me.kryptonPage3.ImageSmall = CType(resources.GetObject("kryptonPage3.ImageSmall"), System.Drawing.Bitmap)
        Me.kryptonPage3.LastVisibleSet = True
        Me.kryptonPage3.MinimumSize = New System.Drawing.Size(50, 50)
        Me.kryptonPage3.Name = "kryptonPage3"
        Me.kryptonPage3.Size = New System.Drawing.Size(381, 298)
        Me.kryptonPage3.Text = "3"
        Me.kryptonPage3.ToolTipTitle = "Page ToolTip"
        Me.kryptonPage3.UniqueName = "20FA2E1F5BF246EC20FA2E1F5BF246EC"
        Me.kryptonPage4.AutoHiddenSlideSize = New System.Drawing.Size(200, 200)
        Me.kryptonPage4.Flags = 65534
        Me.kryptonPage4.ImageLarge = CType(resources.GetObject("kryptonPage4.ImageLarge"), System.Drawing.Bitmap)
        Me.kryptonPage4.ImageMedium = CType(resources.GetObject("kryptonPage4.ImageMedium"), System.Drawing.Bitmap)
        Me.kryptonPage4.ImageSmall = CType(resources.GetObject("kryptonPage4.ImageSmall"), System.Drawing.Bitmap)
        Me.kryptonPage4.LastVisibleSet = True
        Me.kryptonPage4.MinimumSize = New System.Drawing.Size(50, 50)
        Me.kryptonPage4.Name = "kryptonPage4"
        Me.kryptonPage4.Size = New System.Drawing.Size(381, 298)
        Me.kryptonPage4.Text = "Omega"
        Me.kryptonPage4.ToolTipTitle = "Page ToolTip"
        Me.kryptonPage4.UniqueName = "C6345925E3CD40F0C6345925E3CD40F0"
        Me.groupBoxBarOrientation.Controls.Add(Me.radioOrientationRight)
        Me.groupBoxBarOrientation.Controls.Add(Me.radioOrientationLeft)
        Me.groupBoxBarOrientation.Controls.Add(Me.radioOrientationBottom)
        Me.groupBoxBarOrientation.Controls.Add(Me.radioOrientationTop)
        Me.groupBoxBarOrientation.Location = New System.Drawing.Point(12, 114)
        Me.groupBoxBarOrientation.Name = "groupBoxBarOrientation"
        Me.groupBoxBarOrientation.Size = New System.Drawing.Size(147, 120)
        Me.groupBoxBarOrientation.TabIndex = 2
        Me.groupBoxBarOrientation.TabStop = False
        Me.groupBoxBarOrientation.Text = "Bar Orientation"
        Me.radioOrientationRight.AutoSize = True
        Me.radioOrientationRight.Location = New System.Drawing.Point(18, 93)
        Me.radioOrientationRight.Name = "radioOrientationRight"
        Me.radioOrientationRight.Size = New System.Drawing.Size(50, 17)
        Me.radioOrientationRight.TabIndex = 3
        Me.radioOrientationRight.TabStop = True
        Me.radioOrientationRight.Text = "Right"
        Me.radioOrientationRight.UseVisualStyleBackColor = True
        Me.radioOrientationLeft.AutoSize = True
        Me.radioOrientationLeft.Location = New System.Drawing.Point(18, 70)
        Me.radioOrientationLeft.Name = "radioOrientationLeft"
        Me.radioOrientationLeft.Size = New System.Drawing.Size(44, 17)
        Me.radioOrientationLeft.TabIndex = 2
        Me.radioOrientationLeft.TabStop = True
        Me.radioOrientationLeft.Text = "Left"
        Me.radioOrientationLeft.UseVisualStyleBackColor = True
        Me.radioOrientationBottom.AutoSize = True
        Me.radioOrientationBottom.Location = New System.Drawing.Point(18, 47)
        Me.radioOrientationBottom.Name = "radioOrientationBottom"
        Me.radioOrientationBottom.Size = New System.Drawing.Size(59, 17)
        Me.radioOrientationBottom.TabIndex = 1
        Me.radioOrientationBottom.TabStop = True
        Me.radioOrientationBottom.Text = "Bottom"
        Me.radioOrientationBottom.UseVisualStyleBackColor = True
        Me.radioOrientationTop.AutoSize = True
        Me.radioOrientationTop.Location = New System.Drawing.Point(18, 24)
        Me.radioOrientationTop.Name = "radioOrientationTop"
        Me.radioOrientationTop.Size = New System.Drawing.Size(43, 17)
        Me.radioOrientationTop.TabIndex = 0
        Me.radioOrientationTop.TabStop = True
        Me.radioOrientationTop.Text = "Top"
        Me.radioOrientationTop.UseVisualStyleBackColor = True
        Me.groupBoxItemOrientation.Controls.Add(Me.radioItemFixedRight)
        Me.groupBoxItemOrientation.Controls.Add(Me.radioItemFixedLeft)
        Me.groupBoxItemOrientation.Controls.Add(Me.radioItemFixedBottom)
        Me.groupBoxItemOrientation.Controls.Add(Me.radioItemFixedTop)
        Me.groupBoxItemOrientation.Controls.Add(Me.radioItemAuto)
        Me.groupBoxItemOrientation.Location = New System.Drawing.Point(12, 240)
        Me.groupBoxItemOrientation.Name = "groupBoxItemOrientation"
        Me.groupBoxItemOrientation.Size = New System.Drawing.Size(147, 142)
        Me.groupBoxItemOrientation.TabIndex = 3
        Me.groupBoxItemOrientation.TabStop = False
        Me.groupBoxItemOrientation.Text = "Item Orientation"
        Me.radioItemFixedRight.AutoSize = True
        Me.radioItemFixedRight.Location = New System.Drawing.Point(18, 116)
        Me.radioItemFixedRight.Name = "radioItemFixedRight"
        Me.radioItemFixedRight.Size = New System.Drawing.Size(79, 17)
        Me.radioItemFixedRight.TabIndex = 4
        Me.radioItemFixedRight.TabStop = True
        Me.radioItemFixedRight.Text = "Fixed Right"
        Me.radioItemFixedRight.UseVisualStyleBackColor = True
        Me.radioItemFixedLeft.AutoSize = True
        Me.radioItemFixedLeft.Location = New System.Drawing.Point(18, 93)
        Me.radioItemFixedLeft.Name = "radioItemFixedLeft"
        Me.radioItemFixedLeft.Size = New System.Drawing.Size(73, 17)
        Me.radioItemFixedLeft.TabIndex = 3
        Me.radioItemFixedLeft.TabStop = True
        Me.radioItemFixedLeft.Text = "Fixed Left"
        Me.radioItemFixedLeft.UseVisualStyleBackColor = True
        Me.radioItemFixedBottom.AutoSize = True
        Me.radioItemFixedBottom.Location = New System.Drawing.Point(18, 70)
        Me.radioItemFixedBottom.Name = "radioItemFixedBottom"
        Me.radioItemFixedBottom.Size = New System.Drawing.Size(88, 17)
        Me.radioItemFixedBottom.TabIndex = 2
        Me.radioItemFixedBottom.TabStop = True
        Me.radioItemFixedBottom.Text = "Fixed Bottom"
        Me.radioItemFixedBottom.UseVisualStyleBackColor = True
        Me.radioItemFixedTop.AutoSize = True
        Me.radioItemFixedTop.Location = New System.Drawing.Point(18, 47)
        Me.radioItemFixedTop.Name = "radioItemFixedTop"
        Me.radioItemFixedTop.Size = New System.Drawing.Size(72, 17)
        Me.radioItemFixedTop.TabIndex = 1
        Me.radioItemFixedTop.TabStop = True
        Me.radioItemFixedTop.Text = "Fixed Top"
        Me.radioItemFixedTop.UseVisualStyleBackColor = True
        Me.radioItemAuto.AutoSize = True
        Me.radioItemAuto.Location = New System.Drawing.Point(18, 24)
        Me.radioItemAuto.Name = "radioItemAuto"
        Me.radioItemAuto.Size = New System.Drawing.Size(48, 17)
        Me.radioItemAuto.TabIndex = 0
        Me.radioItemAuto.TabStop = True
        Me.radioItemAuto.Text = "Auto"
        Me.radioItemAuto.UseVisualStyleBackColor = True
        Me.groupBoxItemAlignment.Controls.Add(Me.radioItemFar)
        Me.groupBoxItemAlignment.Controls.Add(Me.radioItemCenter)
        Me.groupBoxItemAlignment.Controls.Add(Me.radioItemNear)
        Me.groupBoxItemAlignment.Location = New System.Drawing.Point(13, 387)
        Me.groupBoxItemAlignment.Name = "groupBoxItemAlignment"
        Me.groupBoxItemAlignment.Size = New System.Drawing.Size(147, 96)
        Me.groupBoxItemAlignment.TabIndex = 4
        Me.groupBoxItemAlignment.TabStop = False
        Me.groupBoxItemAlignment.Text = "Item Alignment"
        Me.radioItemFar.AutoSize = True
        Me.radioItemFar.Location = New System.Drawing.Point(18, 70)
        Me.radioItemFar.Name = "radioItemFar"
        Me.radioItemFar.Size = New System.Drawing.Size(41, 17)
        Me.radioItemFar.TabIndex = 2
        Me.radioItemFar.TabStop = True
        Me.radioItemFar.Text = "Far"
        Me.radioItemFar.UseVisualStyleBackColor = True
        Me.radioItemCenter.AutoSize = True
        Me.radioItemCenter.Location = New System.Drawing.Point(18, 47)
        Me.radioItemCenter.Name = "radioItemCenter"
        Me.radioItemCenter.Size = New System.Drawing.Size(58, 17)
        Me.radioItemCenter.TabIndex = 1
        Me.radioItemCenter.TabStop = True
        Me.radioItemCenter.Text = "Center"
        Me.radioItemCenter.UseVisualStyleBackColor = True
        Me.radioItemNear.AutoSize = True
        Me.radioItemNear.Location = New System.Drawing.Point(18, 24)
        Me.radioItemNear.Name = "radioItemNear"
        Me.radioItemNear.Size = New System.Drawing.Size(48, 17)
        Me.radioItemNear.TabIndex = 0
        Me.radioItemNear.TabStop = True
        Me.radioItemNear.Text = "Near"
        Me.radioItemNear.UseVisualStyleBackColor = True
        Me.groupBoxItemSizing.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Left), System.Windows.Forms.AnchorStyles)
        Me.groupBoxItemSizing.Controls.Add(Me.radioSizingSameWidthHeight)
        Me.groupBoxItemSizing.Controls.Add(Me.radioSizingSameWidth)
        Me.groupBoxItemSizing.Controls.Add(Me.radioSizingSameHeight)
        Me.groupBoxItemSizing.Controls.Add(Me.radioSizingIndividual)
        Me.groupBoxItemSizing.Location = New System.Drawing.Point(166, 363)
        Me.groupBoxItemSizing.Name = "groupBoxItemSizing"
        Me.groupBoxItemSizing.Size = New System.Drawing.Size(167, 120)
        Me.groupBoxItemSizing.TabIndex = 5
        Me.groupBoxItemSizing.TabStop = False
        Me.groupBoxItemSizing.Text = "Item Sizing"
        Me.radioSizingSameWidthHeight.AutoSize = True
        Me.radioSizingSameWidthHeight.Location = New System.Drawing.Point(18, 93)
        Me.radioSizingSameWidthHeight.Name = "radioSizingSameWidthHeight"
        Me.radioSizingSameWidthHeight.Size = New System.Drawing.Size(140, 17)
        Me.radioSizingSameWidthHeight.TabIndex = 3
        Me.radioSizingSameWidthHeight.TabStop = True
        Me.radioSizingSameWidthHeight.Text = "All Same Width & Height"
        Me.radioSizingSameWidthHeight.UseMnemonic = False
        Me.radioSizingSameWidthHeight.UseVisualStyleBackColor = True
        Me.radioSizingSameWidth.AutoSize = True
        Me.radioSizingSameWidth.Location = New System.Drawing.Point(18, 70)
        Me.radioSizingSameWidth.Name = "radioSizingSameWidth"
        Me.radioSizingSameWidth.Size = New System.Drawing.Size(96, 17)
        Me.radioSizingSameWidth.TabIndex = 2
        Me.radioSizingSameWidth.TabStop = True
        Me.radioSizingSameWidth.Text = "All Same Width"
        Me.radioSizingSameWidth.UseVisualStyleBackColor = True
        Me.radioSizingSameHeight.AutoSize = True
        Me.radioSizingSameHeight.Location = New System.Drawing.Point(18, 47)
        Me.radioSizingSameHeight.Name = "radioSizingSameHeight"
        Me.radioSizingSameHeight.Size = New System.Drawing.Size(99, 17)
        Me.radioSizingSameHeight.TabIndex = 1
        Me.radioSizingSameHeight.TabStop = True
        Me.radioSizingSameHeight.Text = "All Same Height"
        Me.radioSizingSameHeight.UseVisualStyleBackColor = True
        Me.radioSizingIndividual.AutoSize = True
        Me.radioSizingIndividual.Location = New System.Drawing.Point(18, 24)
        Me.radioSizingIndividual.Name = "radioSizingIndividual"
        Me.radioSizingIndividual.Size = New System.Drawing.Size(101, 17)
        Me.radioSizingIndividual.TabIndex = 0
        Me.radioSizingIndividual.TabStop = True
        Me.radioSizingIndividual.Text = "Individual Sizing"
        Me.radioSizingIndividual.UseVisualStyleBackColor = True
        Me.groupBoxItemSizes.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Left), System.Windows.Forms.AnchorStyles)
        Me.groupBoxItemSizes.Controls.Add(Me.numericUpDownBarFirstItemInset)
        Me.groupBoxItemSizes.Controls.Add(Me.label2)
        Me.groupBoxItemSizes.Controls.Add(Me.labelMaxSizeComma)
        Me.groupBoxItemSizes.Controls.Add(Me.labelMinSizeComma)
        Me.groupBoxItemSizes.Controls.Add(Me.numericUpDownMaxItemSizeY)
        Me.groupBoxItemSizes.Controls.Add(Me.numericUpDownMinItemSizeY)
        Me.groupBoxItemSizes.Controls.Add(Me.numericUpDownBarMinHeight)
        Me.groupBoxItemSizes.Controls.Add(Me.label1)
        Me.groupBoxItemSizes.Controls.Add(Me.numericUpDownMaxItemSizeX)
        Me.groupBoxItemSizes.Controls.Add(Me.labelMaxItemSize)
        Me.groupBoxItemSizes.Controls.Add(Me.labelMinItemSize)
        Me.groupBoxItemSizes.Controls.Add(Me.numericUpDownMinItemSizeX)
        Me.groupBoxItemSizes.Location = New System.Drawing.Point(340, 363)
        Me.groupBoxItemSizes.Name = "groupBoxItemSizes"
        Me.groupBoxItemSizes.Size = New System.Drawing.Size(209, 120)
        Me.groupBoxItemSizes.TabIndex = 6
        Me.groupBoxItemSizes.TabStop = False
        Me.groupBoxItemSizes.Text = "Sizing"
        Me.numericUpDownBarFirstItemInset.Increment = New Decimal(New Integer() { 5, 0, 0, 0})
        Me.numericUpDownBarFirstItemInset.Location = New System.Drawing.Point(85, 22)
        Me.numericUpDownBarFirstItemInset.Maximum = New Decimal(New Integer() { 200, 0, 0, 0})
        Me.numericUpDownBarFirstItemInset.Name = "numericUpDownBarFirstItemInset"
        Me.numericUpDownBarFirstItemInset.Size = New System.Drawing.Size(110, 21)
        Me.numericUpDownBarFirstItemInset.TabIndex = 11
        Me.numericUpDownBarFirstItemInset.Value = New Decimal(New Integer() { 1, 0, 0, 0})
        Me.label2.AutoSize = True
        Me.label2.Location = New System.Drawing.Point(6, 26)
        Me.label2.Name = "label2"
        Me.label2.Size = New System.Drawing.Size(72, 13)
        Me.label2.TabIndex = 10
        Me.label2.Text = "Bar First Item"
        Me.labelMaxSizeComma.AutoSize = True
        Me.labelMaxSizeComma.Location = New System.Drawing.Point(134, 99)
        Me.labelMaxSizeComma.Name = "labelMaxSizeComma"
        Me.labelMaxSizeComma.Size = New System.Drawing.Size(11, 13)
        Me.labelMaxSizeComma.TabIndex = 9
        Me.labelMaxSizeComma.Text = ","
        Me.labelMinSizeComma.AutoSize = True
        Me.labelMinSizeComma.Location = New System.Drawing.Point(135, 76)
        Me.labelMinSizeComma.Name = "labelMinSizeComma"
        Me.labelMinSizeComma.Size = New System.Drawing.Size(11, 13)
        Me.labelMinSizeComma.TabIndex = 8
        Me.labelMinSizeComma.Text = ","
        Me.numericUpDownMaxItemSizeY.Increment = New Decimal(New Integer() { 5, 0, 0, 0})
        Me.numericUpDownMaxItemSizeY.Location = New System.Drawing.Point(148, 91)
        Me.numericUpDownMaxItemSizeY.Maximum = New Decimal(New Integer() { 200, 0, 0, 0})
        Me.numericUpDownMaxItemSizeY.Minimum = New Decimal(New Integer() { 1, 0, 0, 0})
        Me.numericUpDownMaxItemSizeY.Name = "numericUpDownMaxItemSizeY"
        Me.numericUpDownMaxItemSizeY.Size = New System.Drawing.Size(47, 21)
        Me.numericUpDownMaxItemSizeY.TabIndex = 7
        Me.numericUpDownMaxItemSizeY.Value = New Decimal(New Integer() { 1, 0, 0, 0})
        Me.numericUpDownMinItemSizeY.Increment = New Decimal(New Integer() { 5, 0, 0, 0})
        Me.numericUpDownMinItemSizeY.Location = New System.Drawing.Point(148, 68)
        Me.numericUpDownMinItemSizeY.Maximum = New Decimal(New Integer() { 200, 0, 0, 0})
        Me.numericUpDownMinItemSizeY.Minimum = New Decimal(New Integer() { 1, 0, 0, 0})
        Me.numericUpDownMinItemSizeY.Name = "numericUpDownMinItemSizeY"
        Me.numericUpDownMinItemSizeY.Size = New System.Drawing.Size(47, 21)
        Me.numericUpDownMinItemSizeY.TabIndex = 6
        Me.numericUpDownMinItemSizeY.Value = New Decimal(New Integer() { 1, 0, 0, 0})
        Me.numericUpDownBarMinHeight.Increment = New Decimal(New Integer() { 5, 0, 0, 0})
        Me.numericUpDownBarMinHeight.Location = New System.Drawing.Point(85, 45)
        Me.numericUpDownBarMinHeight.Maximum = New Decimal(New Integer() { 200, 0, 0, 0})
        Me.numericUpDownBarMinHeight.Minimum = New Decimal(New Integer() { 1, 0, 0, 0})
        Me.numericUpDownBarMinHeight.Name = "numericUpDownBarMinHeight"
        Me.numericUpDownBarMinHeight.Size = New System.Drawing.Size(110, 21)
        Me.numericUpDownBarMinHeight.TabIndex = 5
        Me.numericUpDownBarMinHeight.Value = New Decimal(New Integer() { 1, 0, 0, 0})
        Me.label1.AutoSize = True
        Me.label1.Location = New System.Drawing.Point(6, 49)
        Me.label1.Name = "label1"
        Me.label1.Size = New System.Drawing.Size(76, 13)
        Me.label1.TabIndex = 4
        Me.label1.Text = "Bar Min Height"
        Me.numericUpDownMaxItemSizeX.Increment = New Decimal(New Integer() { 5, 0, 0, 0})
        Me.numericUpDownMaxItemSizeX.Location = New System.Drawing.Point(85, 91)
        Me.numericUpDownMaxItemSizeX.Maximum = New Decimal(New Integer() { 200, 0, 0, 0})
        Me.numericUpDownMaxItemSizeX.Minimum = New Decimal(New Integer() { 1, 0, 0, 0})
        Me.numericUpDownMaxItemSizeX.Name = "numericUpDownMaxItemSizeX"
        Me.numericUpDownMaxItemSizeX.Size = New System.Drawing.Size(47, 21)
        Me.numericUpDownMaxItemSizeX.TabIndex = 3
        Me.numericUpDownMaxItemSizeX.Value = New Decimal(New Integer() { 1, 0, 0, 0})
        Me.labelMaxItemSize.AutoSize = True
        Me.labelMaxItemSize.Location = New System.Drawing.Point(8, 95)
        Me.labelMaxItemSize.Name = "labelMaxItemSize"
        Me.labelMaxItemSize.Size = New System.Drawing.Size(74, 13)
        Me.labelMaxItemSize.TabIndex = 2
        Me.labelMaxItemSize.Text = "Item Max Size"
        Me.labelMinItemSize.AutoSize = True
        Me.labelMinItemSize.Location = New System.Drawing.Point(12, 72)
        Me.labelMinItemSize.Name = "labelMinItemSize"
        Me.labelMinItemSize.Size = New System.Drawing.Size(70, 13)
        Me.labelMinItemSize.TabIndex = 1
        Me.labelMinItemSize.Text = "Item Min Size"
        Me.numericUpDownMinItemSizeX.Increment = New Decimal(New Integer() { 5, 0, 0, 0})
        Me.numericUpDownMinItemSizeX.Location = New System.Drawing.Point(85, 68)
        Me.numericUpDownMinItemSizeX.Maximum = New Decimal(New Integer() { 200, 0, 0, 0})
        Me.numericUpDownMinItemSizeX.Minimum = New Decimal(New Integer() { 1, 0, 0, 0})
        Me.numericUpDownMinItemSizeX.Name = "numericUpDownMinItemSizeX"
        Me.numericUpDownMinItemSizeX.Size = New System.Drawing.Size(47, 21)
        Me.numericUpDownMinItemSizeX.TabIndex = 0
        Me.numericUpDownMinItemSizeX.Value = New Decimal(New Integer() { 1, 0, 0, 0})
        Me.buttonClose.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Left), System.Windows.Forms.AnchorStyles)
        Me.buttonClose.Location = New System.Drawing.Point(473, 489)
        Me.buttonClose.Name = "buttonClose"
        Me.buttonClose.Size = New System.Drawing.Size(75, 23)
        Me.buttonClose.TabIndex = 7
        Me.buttonClose.Text = "Close"
        Me.buttonClose.UseVisualStyleBackColor = True
        Me.groupBox1.Controls.Add(Me.radioModeRibbonTabs)
        Me.groupBox1.Controls.Add(Me.radioModesCheckButton)
        Me.groupBox1.Controls.Add(Me.radioModeTabs)
        Me.groupBox1.Location = New System.Drawing.Point(12, 7)
        Me.groupBox1.Name = "groupBox1"
        Me.groupBox1.Size = New System.Drawing.Size(148, 101)
        Me.groupBox1.TabIndex = 1
        Me.groupBox1.TabStop = False
        Me.groupBox1.Text = "Modes"
        Me.radioModeRibbonTabs.AutoSize = True
        Me.radioModeRibbonTabs.Location = New System.Drawing.Point(18, 47)
        Me.radioModeRibbonTabs.Name = "radioModeRibbonTabs"
        Me.radioModeRibbonTabs.Size = New System.Drawing.Size(81, 17)
        Me.radioModeRibbonTabs.TabIndex = 1
        Me.radioModeRibbonTabs.TabStop = True
        Me.radioModeRibbonTabs.Text = "RibbonTabs"
        Me.radioModeRibbonTabs.UseVisualStyleBackColor = True
        Me.radioModesCheckButton.AutoSize = True
        Me.radioModesCheckButton.Location = New System.Drawing.Point(18, 70)
        Me.radioModesCheckButton.Name = "radioModesCheckButton"
        Me.radioModesCheckButton.Size = New System.Drawing.Size(91, 17)
        Me.radioModesCheckButton.TabIndex = 2
        Me.radioModesCheckButton.TabStop = True
        Me.radioModesCheckButton.Text = "CheckButtons"
        Me.radioModesCheckButton.UseVisualStyleBackColor = True
        Me.radioModeTabs.AutoSize = True
        Me.radioModeTabs.Location = New System.Drawing.Point(18, 24)
        Me.radioModeTabs.Name = "radioModeTabs"
        Me.radioModeTabs.Size = New System.Drawing.Size(48, 17)
        Me.radioModeTabs.TabIndex = 0
        Me.radioModeTabs.TabStop = True
        Me.radioModeTabs.Text = "Tabs"
        Me.radioModeTabs.UseVisualStyleBackColor = True
        Me.kryptonManager1.GlobalPaletteMode = Krypton.Toolkit.PaletteMode.ProfessionalSystem
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6F, 13F)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(561, 518)
        Me.Controls.Add(Me.groupBox1)
        Me.Controls.Add(Me.buttonClose)
        Me.Controls.Add(Me.groupBoxItemSizes)
        Me.Controls.Add(Me.groupBoxItemSizing)
        Me.Controls.Add(Me.groupBoxItemAlignment)
        Me.Controls.Add(Me.groupBoxItemOrientation)
        Me.Controls.Add(Me.groupBoxBarOrientation)
        Me.Controls.Add(Me.kryptonNavigator1)
        Me.Font = New System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.MaximizeBox = False
        Me.MinimizeBox = False
        Me.MinimumSize = New System.Drawing.Size(569, 552)
        Me.Name = "Form1"
        Me.Text = "Orientation + Alignment"
        CType(Me.kryptonNavigator1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.kryptonNavigator1.ResumeLayout(False)
        CType(Me.kryptonPage1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.kryptonPage2, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.kryptonPage3, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.kryptonPage4, System.ComponentModel.ISupportInitialize).EndInit()
        Me.groupBoxBarOrientation.ResumeLayout(False)
        Me.groupBoxBarOrientation.PerformLayout()
        Me.groupBoxItemOrientation.ResumeLayout(False)
        Me.groupBoxItemOrientation.PerformLayout()
        Me.groupBoxItemAlignment.ResumeLayout(False)
        Me.groupBoxItemAlignment.PerformLayout()
        Me.groupBoxItemSizing.ResumeLayout(False)
        Me.groupBoxItemSizing.PerformLayout()
        Me.groupBoxItemSizes.ResumeLayout(False)
        Me.groupBoxItemSizes.PerformLayout()
        CType(Me.numericUpDownBarFirstItemInset, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.numericUpDownMaxItemSizeY, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.numericUpDownMinItemSizeY, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.numericUpDownBarMinHeight, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.numericUpDownMaxItemSizeX, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.numericUpDownMinItemSizeX, System.ComponentModel.ISupportInitialize).EndInit()
        Me.groupBox1.ResumeLayout(False)
        Me.groupBox1.PerformLayout()
        Me.ResumeLayout(False)
    End Sub

    Friend WithEvents kryptonNavigator1 As Krypton.Navigator.KryptonNavigator
    Friend WithEvents kryptonPage1 As Krypton.Navigator.KryptonPage
    Friend WithEvents groupBoxBarOrientation As System.Windows.Forms.GroupBox
    Friend WithEvents radioOrientationRight As System.Windows.Forms.RadioButton
    Friend WithEvents radioOrientationLeft As System.Windows.Forms.RadioButton
    Friend WithEvents radioOrientationBottom As System.Windows.Forms.RadioButton
    Friend WithEvents radioOrientationTop As System.Windows.Forms.RadioButton
    Friend WithEvents groupBoxItemOrientation As System.Windows.Forms.GroupBox
    Friend WithEvents radioItemFixedRight As System.Windows.Forms.RadioButton
    Friend WithEvents radioItemFixedLeft As System.Windows.Forms.RadioButton
    Friend WithEvents radioItemFixedBottom As System.Windows.Forms.RadioButton
    Friend WithEvents radioItemFixedTop As System.Windows.Forms.RadioButton
    Friend WithEvents radioItemAuto As System.Windows.Forms.RadioButton
    Friend WithEvents groupBoxItemAlignment As System.Windows.Forms.GroupBox
    Friend WithEvents radioItemFar As System.Windows.Forms.RadioButton
    Friend WithEvents radioItemCenter As System.Windows.Forms.RadioButton
    Friend WithEvents radioItemNear As System.Windows.Forms.RadioButton
    Friend WithEvents groupBoxItemSizing As System.Windows.Forms.GroupBox
    Friend WithEvents radioSizingSameWidthHeight As System.Windows.Forms.RadioButton
    Friend WithEvents radioSizingSameWidth As System.Windows.Forms.RadioButton
    Friend WithEvents radioSizingSameHeight As System.Windows.Forms.RadioButton
    Friend WithEvents radioSizingIndividual As System.Windows.Forms.RadioButton
    Friend WithEvents groupBoxItemSizes As System.Windows.Forms.GroupBox
    Friend WithEvents numericUpDownMaxItemSizeX As System.Windows.Forms.NumericUpDown
    Friend WithEvents labelMaxItemSize As System.Windows.Forms.Label
    Friend WithEvents labelMinItemSize As System.Windows.Forms.Label
    Friend WithEvents numericUpDownMinItemSizeX As System.Windows.Forms.NumericUpDown
    Friend WithEvents buttonClose As System.Windows.Forms.Button
    Friend WithEvents kryptonPage2 As Krypton.Navigator.KryptonPage
    Friend WithEvents kryptonPage3 As Krypton.Navigator.KryptonPage
    Friend WithEvents kryptonPage4 As Krypton.Navigator.KryptonPage
    Friend WithEvents numericUpDownBarMinHeight As System.Windows.Forms.NumericUpDown
    Friend WithEvents label1 As System.Windows.Forms.Label
    Friend WithEvents labelMaxSizeComma As System.Windows.Forms.Label
    Friend WithEvents labelMinSizeComma As System.Windows.Forms.Label
    Friend WithEvents numericUpDownMaxItemSizeY As System.Windows.Forms.NumericUpDown
    Friend WithEvents numericUpDownMinItemSizeY As System.Windows.Forms.NumericUpDown
    Friend WithEvents groupBox1 As System.Windows.Forms.GroupBox
    Friend WithEvents radioModesCheckButton As System.Windows.Forms.RadioButton
    Friend WithEvents radioModeTabs As System.Windows.Forms.RadioButton
    Friend WithEvents kryptonManager1 As Krypton.Toolkit.KryptonManager
    Friend WithEvents numericUpDownBarFirstItemInset As System.Windows.Forms.NumericUpDown
    Friend WithEvents label2 As System.Windows.Forms.Label
    Friend WithEvents radioModeRibbonTabs As System.Windows.Forms.RadioButton
End Class
