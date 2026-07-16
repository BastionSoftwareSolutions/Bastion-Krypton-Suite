' VB.NET twin of Source\Krypton Navigator Examples\Singleline + Multiline\Form1.Designer.cs (Bastion Phase 4c).
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
        Me.groupBox1 = New System.Windows.Forms.GroupBox()
        Me.radioModeRibbonTabs = New System.Windows.Forms.RadioButton()
        Me.radioModesCheckButton = New System.Windows.Forms.RadioButton()
        Me.radioModeTabs = New System.Windows.Forms.RadioButton()
        Me.groupBoxItemAlignment = New System.Windows.Forms.GroupBox()
        Me.radioItemFar = New System.Windows.Forms.RadioButton()
        Me.radioItemCenter = New System.Windows.Forms.RadioButton()
        Me.radioItemNear = New System.Windows.Forms.RadioButton()
        Me.groupBoxItemOrientation = New System.Windows.Forms.GroupBox()
        Me.radioItemFixedRight = New System.Windows.Forms.RadioButton()
        Me.radioItemFixedLeft = New System.Windows.Forms.RadioButton()
        Me.radioItemFixedBottom = New System.Windows.Forms.RadioButton()
        Me.radioItemFixedTop = New System.Windows.Forms.RadioButton()
        Me.radioItemAuto = New System.Windows.Forms.RadioButton()
        Me.groupBoxBarOrientation = New System.Windows.Forms.GroupBox()
        Me.radioOrientationRight = New System.Windows.Forms.RadioButton()
        Me.radioOrientationLeft = New System.Windows.Forms.RadioButton()
        Me.radioOrientationBottom = New System.Windows.Forms.RadioButton()
        Me.radioOrientationTop = New System.Windows.Forms.RadioButton()
        Me.groupBox2 = New System.Windows.Forms.GroupBox()
        Me.radioExpandline = New System.Windows.Forms.RadioButton()
        Me.radioMultiline = New System.Windows.Forms.RadioButton()
        Me.radioExactline = New System.Windows.Forms.RadioButton()
        Me.radioShrinkline = New System.Windows.Forms.RadioButton()
        Me.radioSingleline = New System.Windows.Forms.RadioButton()
        Me.buttonClose = New System.Windows.Forms.Button()
        Me.kryptonNavigator1 = New Krypton.Navigator.KryptonNavigator()
        Me.kryptonPage1 = New Krypton.Navigator.KryptonPage()
        Me.kryptonPage2 = New Krypton.Navigator.KryptonPage()
        Me.kryptonPage3 = New Krypton.Navigator.KryptonPage()
        Me.kryptonPage4 = New Krypton.Navigator.KryptonPage()
        Me.kryptonPage5 = New Krypton.Navigator.KryptonPage()
        Me.kryptonPage6 = New Krypton.Navigator.KryptonPage()
        Me.buttonAddPage = New System.Windows.Forms.Button()
        Me.buttonClearAllPages = New System.Windows.Forms.Button()
        Me.groupBoxPages = New System.Windows.Forms.GroupBox()
        Me.imageList1 = New System.Windows.Forms.ImageList(Me.components)
        Me.kryptonManager1 = New Krypton.Toolkit.KryptonManager(Me.components)
        Me.groupBox1.SuspendLayout()
        Me.groupBoxItemAlignment.SuspendLayout()
        Me.groupBoxItemOrientation.SuspendLayout()
        Me.groupBoxBarOrientation.SuspendLayout()
        Me.groupBox2.SuspendLayout()
        CType(Me.kryptonNavigator1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.kryptonNavigator1.SuspendLayout()
        CType(Me.kryptonPage1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.kryptonPage2, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.kryptonPage3, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.kryptonPage4, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.kryptonPage5, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.kryptonPage6, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.groupBoxPages.SuspendLayout()
        Me.SuspendLayout()
        Me.groupBox1.Controls.Add(Me.radioModeRibbonTabs)
        Me.groupBox1.Controls.Add(Me.radioModesCheckButton)
        Me.groupBox1.Controls.Add(Me.radioModeTabs)
        Me.groupBox1.Location = New System.Drawing.Point(13, 160)
        Me.groupBox1.Name = "groupBox1"
        Me.groupBox1.Size = New System.Drawing.Size(148, 99)
        Me.groupBox1.TabIndex = 1
        Me.groupBox1.TabStop = False
        Me.groupBox1.Text = "Modes"
        Me.radioModeRibbonTabs.AutoSize = True
        Me.radioModeRibbonTabs.Location = New System.Drawing.Point(18, 47)
        Me.radioModeRibbonTabs.Name = "radioModeRibbonTabs"
        Me.radioModeRibbonTabs.Size = New System.Drawing.Size(83, 17)
        Me.radioModeRibbonTabs.TabIndex = 1
        Me.radioModeRibbonTabs.TabStop = True
        Me.radioModeRibbonTabs.Text = "RibbonTabs"
        Me.radioModeRibbonTabs.UseVisualStyleBackColor = True
        Me.radioModesCheckButton.AutoSize = True
        Me.radioModesCheckButton.Location = New System.Drawing.Point(18, 70)
        Me.radioModesCheckButton.Name = "radioModesCheckButton"
        Me.radioModesCheckButton.Size = New System.Drawing.Size(92, 17)
        Me.radioModesCheckButton.TabIndex = 2
        Me.radioModesCheckButton.TabStop = True
        Me.radioModesCheckButton.Text = "CheckButtons"
        Me.radioModesCheckButton.UseVisualStyleBackColor = True
        Me.radioModeTabs.AutoSize = True
        Me.radioModeTabs.Location = New System.Drawing.Point(18, 24)
        Me.radioModeTabs.Name = "radioModeTabs"
        Me.radioModeTabs.Size = New System.Drawing.Size(49, 17)
        Me.radioModeTabs.TabIndex = 0
        Me.radioModeTabs.TabStop = True
        Me.radioModeTabs.Text = "Tabs"
        Me.radioModeTabs.UseVisualStyleBackColor = True
        Me.groupBoxItemAlignment.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.groupBoxItemAlignment.Controls.Add(Me.radioItemFar)
        Me.groupBoxItemAlignment.Controls.Add(Me.radioItemCenter)
        Me.groupBoxItemAlignment.Controls.Add(Me.radioItemNear)
        Me.groupBoxItemAlignment.Location = New System.Drawing.Point(531, 253)
        Me.groupBoxItemAlignment.Name = "groupBoxItemAlignment"
        Me.groupBoxItemAlignment.Size = New System.Drawing.Size(147, 99)
        Me.groupBoxItemAlignment.TabIndex = 4
        Me.groupBoxItemAlignment.TabStop = False
        Me.groupBoxItemAlignment.Text = "Item Alignment"
        Me.radioItemFar.AutoSize = True
        Me.radioItemFar.Location = New System.Drawing.Point(18, 70)
        Me.radioItemFar.Name = "radioItemFar"
        Me.radioItemFar.Size = New System.Drawing.Size(40, 17)
        Me.radioItemFar.TabIndex = 2
        Me.radioItemFar.TabStop = True
        Me.radioItemFar.Text = "Far"
        Me.radioItemFar.UseVisualStyleBackColor = True
        Me.radioItemCenter.AutoSize = True
        Me.radioItemCenter.Location = New System.Drawing.Point(18, 47)
        Me.radioItemCenter.Name = "radioItemCenter"
        Me.radioItemCenter.Size = New System.Drawing.Size(56, 17)
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
        Me.groupBoxItemOrientation.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.groupBoxItemOrientation.Controls.Add(Me.radioItemFixedRight)
        Me.groupBoxItemOrientation.Controls.Add(Me.radioItemFixedLeft)
        Me.groupBoxItemOrientation.Controls.Add(Me.radioItemFixedBottom)
        Me.groupBoxItemOrientation.Controls.Add(Me.radioItemFixedTop)
        Me.groupBoxItemOrientation.Controls.Add(Me.radioItemAuto)
        Me.groupBoxItemOrientation.Location = New System.Drawing.Point(531, 105)
        Me.groupBoxItemOrientation.Name = "groupBoxItemOrientation"
        Me.groupBoxItemOrientation.Size = New System.Drawing.Size(147, 142)
        Me.groupBoxItemOrientation.TabIndex = 3
        Me.groupBoxItemOrientation.TabStop = False
        Me.groupBoxItemOrientation.Text = "Item Orientation"
        Me.radioItemFixedRight.AutoSize = True
        Me.radioItemFixedRight.Location = New System.Drawing.Point(18, 116)
        Me.radioItemFixedRight.Name = "radioItemFixedRight"
        Me.radioItemFixedRight.Size = New System.Drawing.Size(78, 17)
        Me.radioItemFixedRight.TabIndex = 4
        Me.radioItemFixedRight.TabStop = True
        Me.radioItemFixedRight.Text = "Fixed Right"
        Me.radioItemFixedRight.UseVisualStyleBackColor = True
        Me.radioItemFixedLeft.AutoSize = True
        Me.radioItemFixedLeft.Location = New System.Drawing.Point(18, 93)
        Me.radioItemFixedLeft.Name = "radioItemFixedLeft"
        Me.radioItemFixedLeft.Size = New System.Drawing.Size(71, 17)
        Me.radioItemFixedLeft.TabIndex = 3
        Me.radioItemFixedLeft.TabStop = True
        Me.radioItemFixedLeft.Text = "Fixed Left"
        Me.radioItemFixedLeft.UseVisualStyleBackColor = True
        Me.radioItemFixedBottom.AutoSize = True
        Me.radioItemFixedBottom.Location = New System.Drawing.Point(18, 70)
        Me.radioItemFixedBottom.Name = "radioItemFixedBottom"
        Me.radioItemFixedBottom.Size = New System.Drawing.Size(86, 17)
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
        Me.radioItemAuto.Size = New System.Drawing.Size(47, 17)
        Me.radioItemAuto.TabIndex = 0
        Me.radioItemAuto.TabStop = True
        Me.radioItemAuto.Text = "Auto"
        Me.radioItemAuto.UseVisualStyleBackColor = True
        Me.groupBoxBarOrientation.Controls.Add(Me.radioOrientationRight)
        Me.groupBoxBarOrientation.Controls.Add(Me.radioOrientationLeft)
        Me.groupBoxBarOrientation.Controls.Add(Me.radioOrientationBottom)
        Me.groupBoxBarOrientation.Controls.Add(Me.radioOrientationTop)
        Me.groupBoxBarOrientation.Location = New System.Drawing.Point(13, 265)
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
        Me.radioOrientationLeft.Size = New System.Drawing.Size(43, 17)
        Me.radioOrientationLeft.TabIndex = 2
        Me.radioOrientationLeft.TabStop = True
        Me.radioOrientationLeft.Text = "Left"
        Me.radioOrientationLeft.UseVisualStyleBackColor = True
        Me.radioOrientationBottom.AutoSize = True
        Me.radioOrientationBottom.Location = New System.Drawing.Point(18, 47)
        Me.radioOrientationBottom.Name = "radioOrientationBottom"
        Me.radioOrientationBottom.Size = New System.Drawing.Size(58, 17)
        Me.radioOrientationBottom.TabIndex = 1
        Me.radioOrientationBottom.TabStop = True
        Me.radioOrientationBottom.Text = "Bottom"
        Me.radioOrientationBottom.UseVisualStyleBackColor = True
        Me.radioOrientationTop.AutoSize = True
        Me.radioOrientationTop.Location = New System.Drawing.Point(18, 24)
        Me.radioOrientationTop.Name = "radioOrientationTop"
        Me.radioOrientationTop.Size = New System.Drawing.Size(44, 17)
        Me.radioOrientationTop.TabIndex = 0
        Me.radioOrientationTop.TabStop = True
        Me.radioOrientationTop.Text = "Top"
        Me.radioOrientationTop.UseVisualStyleBackColor = True
        Me.groupBox2.Controls.Add(Me.radioExpandline)
        Me.groupBox2.Controls.Add(Me.radioMultiline)
        Me.groupBox2.Controls.Add(Me.radioExactline)
        Me.groupBox2.Controls.Add(Me.radioShrinkline)
        Me.groupBox2.Controls.Add(Me.radioSingleline)
        Me.groupBox2.Location = New System.Drawing.Point(13, 13)
        Me.groupBox2.Name = "groupBox2"
        Me.groupBox2.Size = New System.Drawing.Size(147, 141)
        Me.groupBox2.TabIndex = 0
        Me.groupBox2.TabStop = False
        Me.groupBox2.Text = "Multiline Setting"
        Me.radioExpandline.AutoSize = True
        Me.radioExpandline.Location = New System.Drawing.Point(17, 114)
        Me.radioExpandline.Name = "radioExpandline"
        Me.radioExpandline.Size = New System.Drawing.Size(77, 17)
        Me.radioExpandline.TabIndex = 4
        Me.radioExpandline.Text = "Expandline"
        Me.radioExpandline.UseVisualStyleBackColor = True
        Me.radioMultiline.AutoSize = True
        Me.radioMultiline.Location = New System.Drawing.Point(17, 45)
        Me.radioMultiline.Name = "radioMultiline"
        Me.radioMultiline.Size = New System.Drawing.Size(63, 17)
        Me.radioMultiline.TabIndex = 3
        Me.radioMultiline.Text = "Multiline"
        Me.radioMultiline.UseVisualStyleBackColor = True
        Me.radioExactline.AutoSize = True
        Me.radioExactline.Location = New System.Drawing.Point(17, 68)
        Me.radioExactline.Name = "radioExactline"
        Me.radioExactline.Size = New System.Drawing.Size(68, 17)
        Me.radioExactline.TabIndex = 2
        Me.radioExactline.Text = "Exactline"
        Me.radioExactline.UseVisualStyleBackColor = True
        Me.radioShrinkline.AutoSize = True
        Me.radioShrinkline.Location = New System.Drawing.Point(17, 91)
        Me.radioShrinkline.Name = "radioShrinkline"
        Me.radioShrinkline.Size = New System.Drawing.Size(71, 17)
        Me.radioShrinkline.TabIndex = 1
        Me.radioShrinkline.Text = "Shrinkline"
        Me.radioShrinkline.UseVisualStyleBackColor = True
        Me.radioSingleline.AutoSize = True
        Me.radioSingleline.Location = New System.Drawing.Point(17, 22)
        Me.radioSingleline.Name = "radioSingleline"
        Me.radioSingleline.Size = New System.Drawing.Size(70, 17)
        Me.radioSingleline.TabIndex = 0
        Me.radioSingleline.Text = "Singleline"
        Me.radioSingleline.UseVisualStyleBackColor = True
        Me.buttonClose.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.buttonClose.Location = New System.Drawing.Point(603, 362)
        Me.buttonClose.Name = "buttonClose"
        Me.buttonClose.Size = New System.Drawing.Size(75, 23)
        Me.buttonClose.TabIndex = 8
        Me.buttonClose.Text = "Close"
        Me.buttonClose.UseVisualStyleBackColor = True
        Me.kryptonNavigator1.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) Or System.Windows.Forms.AnchorStyles.Left) Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.kryptonNavigator1.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowOnly
        Me.kryptonNavigator1.Bar.BarMapExtraText = Krypton.Navigator.MapKryptonPageText.None
        Me.kryptonNavigator1.Bar.BarMapImage = Krypton.Navigator.MapKryptonPageImage.Small
        Me.kryptonNavigator1.Bar.BarMapText = Krypton.Navigator.MapKryptonPageText.TextTitle
        Me.kryptonNavigator1.Bar.BarMultiline = Krypton.Navigator.BarMultiline.Multiline
        Me.kryptonNavigator1.Bar.BarOrientation = Krypton.Toolkit.VisualOrientation.Top
        Me.kryptonNavigator1.Bar.CheckButtonStyle = Krypton.Toolkit.ButtonStyle.Standalone
        Me.kryptonNavigator1.Bar.ItemAlignment = Krypton.Toolkit.RelativePositionAlign.Near
        Me.kryptonNavigator1.Bar.ItemMaximumSize = New System.Drawing.Size(200, 200)
        Me.kryptonNavigator1.Bar.ItemMinimumSize = New System.Drawing.Size(20, 20)
        Me.kryptonNavigator1.Bar.ItemOrientation = Krypton.Toolkit.ButtonOrientation.Auto
        Me.kryptonNavigator1.Bar.ItemSizing = Krypton.Navigator.BarItemSizing.SameHeight
        Me.kryptonNavigator1.Bar.TabBorderStyle = Krypton.Toolkit.TabBorderStyle.RoundedEqualMedium
        Me.kryptonNavigator1.Bar.TabStyle = Krypton.Toolkit.TabStyle.HighProfile
        Me.kryptonNavigator1.Button.ButtonDisplayLogic = Krypton.Navigator.ButtonDisplayLogic.Context
        Me.kryptonNavigator1.Button.CloseButtonAction = Krypton.Navigator.CloseButtonAction.RemovePageAndDispose
        Me.kryptonNavigator1.Button.CloseButtonDisplay = Krypton.Navigator.ButtonDisplay.Logic
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
        Me.kryptonNavigator1.Location = New System.Drawing.Point(176, 19)
        Me.kryptonNavigator1.Name = "kryptonNavigator1"
        Me.kryptonNavigator1.NavigatorMode = Krypton.Navigator.NavigatorMode.BarTabGroup
        Me.kryptonNavigator1.PageBackStyle = Krypton.Toolkit.PaletteBackStyle.ControlClient
        Me.kryptonNavigator1.Pages.AddRange(New Krypton.Navigator.KryptonPage() { Me.kryptonPage1, Me.kryptonPage2, Me.kryptonPage3, Me.kryptonPage4, Me.kryptonPage5, Me.kryptonPage6})
        Me.kryptonNavigator1.Panel.PanelBackStyle = Krypton.Toolkit.PaletteBackStyle.PanelClient
        Me.kryptonNavigator1.SelectedIndex = 0
        Me.kryptonNavigator1.Size = New System.Drawing.Size(340, 366)
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
        Me.kryptonNavigator1.TabIndex = 7
        Me.kryptonNavigator1.Text = "kryptonNavigator1"
        Me.kryptonPage1.AutoHiddenSlideSize = New System.Drawing.Size(200, 200)
        Me.kryptonPage1.Flags = 65534
        Me.kryptonPage1.ImageSmall = CType(resources.GetObject("kryptonPage1.ImageSmall"), System.Drawing.Bitmap)
        Me.kryptonPage1.LastVisibleSet = True
        Me.kryptonPage1.MinimumSize = New System.Drawing.Size(50, 50)
        Me.kryptonPage1.Name = "kryptonPage1"
        Me.kryptonPage1.Size = New System.Drawing.Size(338, 302)
        Me.kryptonPage1.Text = "Page 1"
        Me.kryptonPage1.TextDescription = "Page 1"
        Me.kryptonPage1.TextTitle = "Page 1"
        Me.kryptonPage1.ToolTipTitle = "Page ToolTip"
        Me.kryptonPage1.UniqueName = "83EBB3EA59B0452F83EBB3EA59B0452F"
        Me.kryptonPage2.AutoHiddenSlideSize = New System.Drawing.Size(200, 200)
        Me.kryptonPage2.Flags = 65534
        Me.kryptonPage2.ImageSmall = CType(resources.GetObject("kryptonPage2.ImageSmall"), System.Drawing.Bitmap)
        Me.kryptonPage2.LastVisibleSet = True
        Me.kryptonPage2.MinimumSize = New System.Drawing.Size(50, 50)
        Me.kryptonPage2.Name = "kryptonPage2"
        Me.kryptonPage2.Size = New System.Drawing.Size(338, 302)
        Me.kryptonPage2.Text = "Two"
        Me.kryptonPage2.TextDescription = "Two"
        Me.kryptonPage2.TextTitle = "Two"
        Me.kryptonPage2.ToolTipTitle = "Page ToolTip"
        Me.kryptonPage2.UniqueName = "2DCBCC926137414E2DCBCC926137414E"
        Me.kryptonPage3.AutoHiddenSlideSize = New System.Drawing.Size(200, 200)
        Me.kryptonPage3.Flags = 65534
        Me.kryptonPage3.ImageSmall = CType(resources.GetObject("kryptonPage3.ImageSmall"), System.Drawing.Bitmap)
        Me.kryptonPage3.LastVisibleSet = True
        Me.kryptonPage3.MinimumSize = New System.Drawing.Size(50, 50)
        Me.kryptonPage3.Name = "kryptonPage3"
        Me.kryptonPage3.Size = New System.Drawing.Size(338, 302)
        Me.kryptonPage3.Text = "Page Three"
        Me.kryptonPage3.TextDescription = "Page Three"
        Me.kryptonPage3.TextTitle = "Page Three"
        Me.kryptonPage3.ToolTipTitle = "Page ToolTip"
        Me.kryptonPage3.UniqueName = "230DEF4541DE4E34230DEF4541DE4E34"
        Me.kryptonPage4.AutoHiddenSlideSize = New System.Drawing.Size(200, 200)
        Me.kryptonPage4.Flags = 65534
        Me.kryptonPage4.ImageSmall = CType(resources.GetObject("kryptonPage4.ImageSmall"), System.Drawing.Bitmap)
        Me.kryptonPage4.LastVisibleSet = True
        Me.kryptonPage4.MinimumSize = New System.Drawing.Size(50, 50)
        Me.kryptonPage4.Name = "kryptonPage4"
        Me.kryptonPage4.Size = New System.Drawing.Size(338, 302)
        Me.kryptonPage4.Text = "Page 4"
        Me.kryptonPage4.TextDescription = "Page 4"
        Me.kryptonPage4.TextTitle = "Page 4"
        Me.kryptonPage4.ToolTipTitle = "Page ToolTip"
        Me.kryptonPage4.UniqueName = "1D7E3CAE56E340031D7E3CAE56E34003"
        Me.kryptonPage5.AutoHiddenSlideSize = New System.Drawing.Size(200, 200)
        Me.kryptonPage5.Flags = 65534
        Me.kryptonPage5.ImageSmall = CType(resources.GetObject("kryptonPage5.ImageSmall"), System.Drawing.Bitmap)
        Me.kryptonPage5.LastVisibleSet = True
        Me.kryptonPage5.MinimumSize = New System.Drawing.Size(50, 50)
        Me.kryptonPage5.Name = "kryptonPage5"
        Me.kryptonPage5.Size = New System.Drawing.Size(338, 302)
        Me.kryptonPage5.Text = "Fifth Page"
        Me.kryptonPage5.TextDescription = "Fifth Page"
        Me.kryptonPage5.TextTitle = "Fifth Page"
        Me.kryptonPage5.ToolTipTitle = "Page ToolTip"
        Me.kryptonPage5.UniqueName = "39046C03B4E74DF239046C03B4E74DF2"
        Me.kryptonPage6.AutoHiddenSlideSize = New System.Drawing.Size(200, 200)
        Me.kryptonPage6.Flags = 65534
        Me.kryptonPage6.ImageSmall = CType(resources.GetObject("kryptonPage6.ImageSmall"), System.Drawing.Bitmap)
        Me.kryptonPage6.LastVisibleSet = True
        Me.kryptonPage6.MinimumSize = New System.Drawing.Size(50, 50)
        Me.kryptonPage6.Name = "kryptonPage6"
        Me.kryptonPage6.Size = New System.Drawing.Size(338, 302)
        Me.kryptonPage6.Text = "Page 6"
        Me.kryptonPage6.TextDescription = "Page 6"
        Me.kryptonPage6.TextTitle = "Page 6"
        Me.kryptonPage6.ToolTipTitle = "Page ToolTip"
        Me.kryptonPage6.UniqueName = "A72F1119BE1D4099A72F1119BE1D4099"
        Me.buttonAddPage.Location = New System.Drawing.Point(14, 22)
        Me.buttonAddPage.Name = "buttonAddPage"
        Me.buttonAddPage.Size = New System.Drawing.Size(101, 23)
        Me.buttonAddPage.TabIndex = 5
        Me.buttonAddPage.Text = "Add Page"
        Me.buttonAddPage.UseVisualStyleBackColor = True
        Me.buttonClearAllPages.Location = New System.Drawing.Point(14, 51)
        Me.buttonClearAllPages.Name = "buttonClearAllPages"
        Me.buttonClearAllPages.Size = New System.Drawing.Size(101, 23)
        Me.buttonClearAllPages.TabIndex = 6
        Me.buttonClearAllPages.Text = "Clear All Pages"
        Me.buttonClearAllPages.UseVisualStyleBackColor = True
        Me.groupBoxPages.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.groupBoxPages.Controls.Add(Me.buttonAddPage)
        Me.groupBoxPages.Controls.Add(Me.buttonClearAllPages)
        Me.groupBoxPages.Location = New System.Drawing.Point(531, 13)
        Me.groupBoxPages.Name = "groupBoxPages"
        Me.groupBoxPages.Size = New System.Drawing.Size(147, 86)
        Me.groupBoxPages.TabIndex = 9
        Me.groupBoxPages.TabStop = False
        Me.groupBoxPages.Text = "Pages"
        Me.imageList1.ImageStream = CType(resources.GetObject("imageList1.ImageStream"), System.Windows.Forms.ImageListStreamer)
        Me.imageList1.TransparentColor = System.Drawing.Color.Transparent
        Me.imageList1.Images.SetKeyName(0, "document_plain_red.png")
        Me.imageList1.Images.SetKeyName(1, "find.png")
        Me.imageList1.Images.SetKeyName(2, "flash_yellow.png")
        Me.imageList1.Images.SetKeyName(3, "floppy_disk.png")
        Me.imageList1.Images.SetKeyName(4, "font.png")
        Me.imageList1.Images.SetKeyName(5, "heart_broken.png")
        Me.imageList1.Images.SetKeyName(6, "lifebelt.png")
        Me.kryptonManager1.GlobalPaletteMode = Krypton.Toolkit.PaletteMode.ProfessionalSystem
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6F, 13F)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(689, 399)
        Me.Controls.Add(Me.groupBoxPages)
        Me.Controls.Add(Me.kryptonNavigator1)
        Me.Controls.Add(Me.buttonClose)
        Me.Controls.Add(Me.groupBox2)
        Me.Controls.Add(Me.groupBox1)
        Me.Controls.Add(Me.groupBoxItemAlignment)
        Me.Controls.Add(Me.groupBoxItemOrientation)
        Me.Controls.Add(Me.groupBoxBarOrientation)
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.MinimumSize = New System.Drawing.Size(697, 433)
        Me.Name = "Form1"
        Me.Text = "Singleline + Multiline"
        Me.groupBox1.ResumeLayout(False)
        Me.groupBox1.PerformLayout()
        Me.groupBoxItemAlignment.ResumeLayout(False)
        Me.groupBoxItemAlignment.PerformLayout()
        Me.groupBoxItemOrientation.ResumeLayout(False)
        Me.groupBoxItemOrientation.PerformLayout()
        Me.groupBoxBarOrientation.ResumeLayout(False)
        Me.groupBoxBarOrientation.PerformLayout()
        Me.groupBox2.ResumeLayout(False)
        Me.groupBox2.PerformLayout()
        CType(Me.kryptonNavigator1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.kryptonNavigator1.ResumeLayout(False)
        CType(Me.kryptonPage1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.kryptonPage2, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.kryptonPage3, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.kryptonPage4, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.kryptonPage5, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.kryptonPage6, System.ComponentModel.ISupportInitialize).EndInit()
        Me.groupBoxPages.ResumeLayout(False)
        Me.ResumeLayout(False)
    End Sub

    Friend WithEvents groupBox1 As System.Windows.Forms.GroupBox
    Friend WithEvents radioModesCheckButton As System.Windows.Forms.RadioButton
    Friend WithEvents radioModeTabs As System.Windows.Forms.RadioButton
    Friend WithEvents groupBoxItemAlignment As System.Windows.Forms.GroupBox
    Friend WithEvents radioItemFar As System.Windows.Forms.RadioButton
    Friend WithEvents radioItemCenter As System.Windows.Forms.RadioButton
    Friend WithEvents radioItemNear As System.Windows.Forms.RadioButton
    Friend WithEvents groupBoxItemOrientation As System.Windows.Forms.GroupBox
    Friend WithEvents radioItemFixedRight As System.Windows.Forms.RadioButton
    Friend WithEvents radioItemFixedLeft As System.Windows.Forms.RadioButton
    Friend WithEvents radioItemFixedBottom As System.Windows.Forms.RadioButton
    Friend WithEvents radioItemFixedTop As System.Windows.Forms.RadioButton
    Friend WithEvents radioItemAuto As System.Windows.Forms.RadioButton
    Friend WithEvents groupBoxBarOrientation As System.Windows.Forms.GroupBox
    Friend WithEvents radioOrientationRight As System.Windows.Forms.RadioButton
    Friend WithEvents radioOrientationLeft As System.Windows.Forms.RadioButton
    Friend WithEvents radioOrientationBottom As System.Windows.Forms.RadioButton
    Friend WithEvents radioOrientationTop As System.Windows.Forms.RadioButton
    Friend WithEvents groupBox2 As System.Windows.Forms.GroupBox
    Friend WithEvents radioExactline As System.Windows.Forms.RadioButton
    Friend WithEvents radioShrinkline As System.Windows.Forms.RadioButton
    Friend WithEvents radioSingleline As System.Windows.Forms.RadioButton
    Friend WithEvents buttonClose As System.Windows.Forms.Button
    Friend WithEvents kryptonNavigator1 As Krypton.Navigator.KryptonNavigator
    Friend WithEvents kryptonPage1 As Krypton.Navigator.KryptonPage
    Friend WithEvents kryptonPage2 As Krypton.Navigator.KryptonPage
    Friend WithEvents kryptonPage3 As Krypton.Navigator.KryptonPage
    Friend WithEvents kryptonPage4 As Krypton.Navigator.KryptonPage
    Friend WithEvents kryptonPage5 As Krypton.Navigator.KryptonPage
    Friend WithEvents kryptonPage6 As Krypton.Navigator.KryptonPage
    Friend WithEvents buttonAddPage As System.Windows.Forms.Button
    Friend WithEvents buttonClearAllPages As System.Windows.Forms.Button
    Friend WithEvents radioModeRibbonTabs As System.Windows.Forms.RadioButton
    Friend WithEvents radioExpandline As System.Windows.Forms.RadioButton
    Friend WithEvents radioMultiline As System.Windows.Forms.RadioButton
    Friend WithEvents groupBoxPages As System.Windows.Forms.GroupBox
    Friend WithEvents imageList1 As System.Windows.Forms.ImageList
    Friend WithEvents kryptonManager1 As Krypton.Toolkit.KryptonManager
End Class
