' VB.NET twin of Source\Krypton Navigator Examples\Navigator Modes\Form1.Designer.cs (Bastion Phase 4c).
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
        Me.radioHeaderGroupTab = New System.Windows.Forms.RadioButton()
        Me.radioOutlookMini = New System.Windows.Forms.RadioButton()
        Me.radioBarRibbonTabOnly = New System.Windows.Forms.RadioButton()
        Me.radioBarRibbonTabGroup = New System.Windows.Forms.RadioButton()
        Me.radioBarTabGroup = New System.Windows.Forms.RadioButton()
        Me.radioBarTabOnly = New System.Windows.Forms.RadioButton()
        Me.radioHeaderBarCheckButtonOnly = New System.Windows.Forms.RadioButton()
        Me.radioHeaderBarCheckButtonHeaderGroup = New System.Windows.Forms.RadioButton()
        Me.radioHeaderBarCheckButtonGroup = New System.Windows.Forms.RadioButton()
        Me.radioStackCheckButtonHeaderGroup = New System.Windows.Forms.RadioButton()
        Me.radioStackCheckButtonGroup = New System.Windows.Forms.RadioButton()
        Me.radioOutlookFull = New System.Windows.Forms.RadioButton()
        Me.radioPanel = New System.Windows.Forms.RadioButton()
        Me.radioGroup = New System.Windows.Forms.RadioButton()
        Me.radioHeaderGroup = New System.Windows.Forms.RadioButton()
        Me.radioBarCheckButtonOnly = New System.Windows.Forms.RadioButton()
        Me.radioBarCheckButtonGroupOnly = New System.Windows.Forms.RadioButton()
        Me.radioBarCheckButtonGroupInside = New System.Windows.Forms.RadioButton()
        Me.radioBarCheckButtonGroupOutside = New System.Windows.Forms.RadioButton()
        Me.kryptonNavigator1 = New Krypton.Navigator.KryptonNavigator()
        Me.kryptonPage1 = New Krypton.Navigator.KryptonPage()
        Me.button3 = New System.Windows.Forms.Button()
        Me.button2 = New System.Windows.Forms.Button()
        Me.button1 = New System.Windows.Forms.Button()
        Me.buttonPage1 = New System.Windows.Forms.Button()
        Me.kryptonPage2 = New Krypton.Navigator.KryptonPage()
        Me.label2 = New System.Windows.Forms.Label()
        Me.label1 = New System.Windows.Forms.Label()
        Me.labelPage2 = New System.Windows.Forms.Label()
        Me.kryptonPage3 = New Krypton.Navigator.KryptonPage()
        Me.comboBox1 = New System.Windows.Forms.ComboBox()
        Me.comboBoxPage3 = New System.Windows.Forms.ComboBox()
        Me.kryptonPage4 = New Krypton.Navigator.KryptonPage()
        Me.textBox1 = New System.Windows.Forms.TextBox()
        Me.textBoxPage4 = New System.Windows.Forms.TextBox()
        Me.buttonClose = New System.Windows.Forms.Button()
        Me.groupBox2 = New System.Windows.Forms.GroupBox()
        Me.textBoxDescription = New System.Windows.Forms.RichTextBox()
        Me.panelWithNav = New System.Windows.Forms.Panel()
        Me.kryptonManager1 = New Krypton.Toolkit.KryptonManager(Me.components)
        Me.groupBox1.SuspendLayout()
        CType(Me.kryptonNavigator1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.kryptonNavigator1.SuspendLayout()
        CType(Me.kryptonPage1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.kryptonPage1.SuspendLayout()
        CType(Me.kryptonPage2, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.kryptonPage2.SuspendLayout()
        CType(Me.kryptonPage3, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.kryptonPage3.SuspendLayout()
        CType(Me.kryptonPage4, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.kryptonPage4.SuspendLayout()
        Me.groupBox2.SuspendLayout()
        Me.panelWithNav.SuspendLayout()
        Me.SuspendLayout()
        Me.groupBox1.Controls.Add(Me.radioHeaderGroupTab)
        Me.groupBox1.Controls.Add(Me.radioOutlookMini)
        Me.groupBox1.Controls.Add(Me.radioBarRibbonTabOnly)
        Me.groupBox1.Controls.Add(Me.radioBarRibbonTabGroup)
        Me.groupBox1.Controls.Add(Me.radioBarTabGroup)
        Me.groupBox1.Controls.Add(Me.radioBarTabOnly)
        Me.groupBox1.Controls.Add(Me.radioHeaderBarCheckButtonOnly)
        Me.groupBox1.Controls.Add(Me.radioHeaderBarCheckButtonHeaderGroup)
        Me.groupBox1.Controls.Add(Me.radioHeaderBarCheckButtonGroup)
        Me.groupBox1.Controls.Add(Me.radioStackCheckButtonHeaderGroup)
        Me.groupBox1.Controls.Add(Me.radioStackCheckButtonGroup)
        Me.groupBox1.Controls.Add(Me.radioOutlookFull)
        Me.groupBox1.Controls.Add(Me.radioPanel)
        Me.groupBox1.Controls.Add(Me.radioGroup)
        Me.groupBox1.Controls.Add(Me.radioHeaderGroup)
        Me.groupBox1.Controls.Add(Me.radioBarCheckButtonOnly)
        Me.groupBox1.Controls.Add(Me.radioBarCheckButtonGroupOnly)
        Me.groupBox1.Controls.Add(Me.radioBarCheckButtonGroupInside)
        Me.groupBox1.Controls.Add(Me.radioBarCheckButtonGroupOutside)
        Me.groupBox1.Location = New System.Drawing.Point(12, 12)
        Me.groupBox1.Name = "groupBox1"
        Me.groupBox1.Size = New System.Drawing.Size(287, 455)
        Me.groupBox1.TabIndex = 0
        Me.groupBox1.TabStop = False
        Me.groupBox1.Text = "Modes"
        Me.radioHeaderGroupTab.AutoSize = True
        Me.radioHeaderGroupTab.Location = New System.Drawing.Point(16, 377)
        Me.radioHeaderGroupTab.Name = "radioHeaderGroupTab"
        Me.radioHeaderGroupTab.Size = New System.Drawing.Size(146, 21)
        Me.radioHeaderGroupTab.TabIndex = 16
        Me.radioHeaderGroupTab.TabStop = True
        Me.radioHeaderGroupTab.Text = "HeaderGroup - Tab"
        Me.radioHeaderGroupTab.UseVisualStyleBackColor = True
        Me.radioOutlookMini.AutoSize = True
        Me.radioOutlookMini.Location = New System.Drawing.Point(16, 333)
        Me.radioOutlookMini.Name = "radioOutlookMini"
        Me.radioOutlookMini.Size = New System.Drawing.Size(112, 21)
        Me.radioOutlookMini.TabIndex = 14
        Me.radioOutlookMini.TabStop = True
        Me.radioOutlookMini.Text = "Outlook - Mini"
        Me.radioOutlookMini.UseVisualStyleBackColor = True
        Me.radioBarRibbonTabOnly.AutoSize = True
        Me.radioBarRibbonTabOnly.Location = New System.Drawing.Point(16, 91)
        Me.radioBarRibbonTabOnly.Name = "radioBarRibbonTabOnly"
        Me.radioBarRibbonTabOnly.Size = New System.Drawing.Size(169, 21)
        Me.radioBarRibbonTabOnly.TabIndex = 3
        Me.radioBarRibbonTabOnly.TabStop = True
        Me.radioBarRibbonTabOnly.Text = "Bar - RibbonTab - Only"
        Me.radioBarRibbonTabOnly.UseVisualStyleBackColor = True
        Me.radioBarRibbonTabGroup.AutoSize = True
        Me.radioBarRibbonTabGroup.Location = New System.Drawing.Point(16, 69)
        Me.radioBarRibbonTabGroup.Name = "radioBarRibbonTabGroup"
        Me.radioBarRibbonTabGroup.Size = New System.Drawing.Size(179, 21)
        Me.radioBarRibbonTabGroup.TabIndex = 2
        Me.radioBarRibbonTabGroup.TabStop = True
        Me.radioBarRibbonTabGroup.Text = "Bar - RibbonTab - Group"
        Me.radioBarRibbonTabGroup.UseVisualStyleBackColor = True
        Me.radioBarTabGroup.AutoSize = True
        Me.radioBarTabGroup.Location = New System.Drawing.Point(16, 25)
        Me.radioBarTabGroup.Name = "radioBarTabGroup"
        Me.radioBarTabGroup.Size = New System.Drawing.Size(136, 21)
        Me.radioBarTabGroup.TabIndex = 0
        Me.radioBarTabGroup.TabStop = True
        Me.radioBarTabGroup.Text = "Bar - Tab - Group"
        Me.radioBarTabGroup.UseVisualStyleBackColor = True
        Me.radioBarTabOnly.AutoSize = True
        Me.radioBarTabOnly.Location = New System.Drawing.Point(16, 47)
        Me.radioBarTabOnly.Name = "radioBarTabOnly"
        Me.radioBarTabOnly.Size = New System.Drawing.Size(126, 21)
        Me.radioBarTabOnly.TabIndex = 1
        Me.radioBarTabOnly.TabStop = True
        Me.radioBarTabOnly.Text = "Bar - Tab - Only"
        Me.radioBarTabOnly.UseVisualStyleBackColor = True
        Me.radioHeaderBarCheckButtonOnly.AutoSize = True
        Me.radioHeaderBarCheckButtonOnly.Location = New System.Drawing.Point(16, 245)
        Me.radioHeaderBarCheckButtonOnly.Name = "radioHeaderBarCheckButtonOnly"
        Me.radioHeaderBarCheckButtonOnly.Size = New System.Drawing.Size(226, 21)
        Me.radioHeaderBarCheckButtonOnly.TabIndex = 10
        Me.radioHeaderBarCheckButtonOnly.TabStop = True
        Me.radioHeaderBarCheckButtonOnly.Text = "HeaderBar - CheckButton - Only"
        Me.radioHeaderBarCheckButtonOnly.UseVisualStyleBackColor = True
        Me.radioHeaderBarCheckButtonHeaderGroup.AutoSize = True
        Me.radioHeaderBarCheckButtonHeaderGroup.Location = New System.Drawing.Point(16, 223)
        Me.radioHeaderBarCheckButtonHeaderGroup.Name = "radioHeaderBarCheckButtonHeaderGroup"
        Me.radioHeaderBarCheckButtonHeaderGroup.Size = New System.Drawing.Size(279, 21)
        Me.radioHeaderBarCheckButtonHeaderGroup.TabIndex = 9
        Me.radioHeaderBarCheckButtonHeaderGroup.TabStop = True
        Me.radioHeaderBarCheckButtonHeaderGroup.Text = "HeaderBar - CheckButton - HeaderGroup"
        Me.radioHeaderBarCheckButtonHeaderGroup.UseVisualStyleBackColor = True
        Me.radioHeaderBarCheckButtonGroup.AutoSize = True
        Me.radioHeaderBarCheckButtonGroup.Location = New System.Drawing.Point(16, 201)
        Me.radioHeaderBarCheckButtonGroup.Name = "radioHeaderBarCheckButtonGroup"
        Me.radioHeaderBarCheckButtonGroup.Size = New System.Drawing.Size(236, 21)
        Me.radioHeaderBarCheckButtonGroup.TabIndex = 8
        Me.radioHeaderBarCheckButtonGroup.TabStop = True
        Me.radioHeaderBarCheckButtonGroup.Text = "HeaderBar - CheckButton - Group"
        Me.radioHeaderBarCheckButtonGroup.UseVisualStyleBackColor = True
        Me.radioStackCheckButtonHeaderGroup.AutoSize = True
        Me.radioStackCheckButtonHeaderGroup.Location = New System.Drawing.Point(16, 289)
        Me.radioStackCheckButtonHeaderGroup.Name = "radioStackCheckButtonHeaderGroup"
        Me.radioStackCheckButtonHeaderGroup.Size = New System.Drawing.Size(250, 21)
        Me.radioStackCheckButtonHeaderGroup.TabIndex = 12
        Me.radioStackCheckButtonHeaderGroup.TabStop = True
        Me.radioStackCheckButtonHeaderGroup.Text = "Stack - CheckButton - HeaderGroup"
        Me.radioStackCheckButtonHeaderGroup.UseVisualStyleBackColor = True
        Me.radioStackCheckButtonGroup.AutoSize = True
        Me.radioStackCheckButtonGroup.Location = New System.Drawing.Point(16, 267)
        Me.radioStackCheckButtonGroup.Name = "radioStackCheckButtonGroup"
        Me.radioStackCheckButtonGroup.Size = New System.Drawing.Size(207, 21)
        Me.radioStackCheckButtonGroup.TabIndex = 11
        Me.radioStackCheckButtonGroup.TabStop = True
        Me.radioStackCheckButtonGroup.Text = "Stack - CheckButton - Group"
        Me.radioStackCheckButtonGroup.UseVisualStyleBackColor = True
        Me.radioOutlookFull.AutoSize = True
        Me.radioOutlookFull.Location = New System.Drawing.Point(16, 311)
        Me.radioOutlookFull.Name = "radioOutlookFull"
        Me.radioOutlookFull.Size = New System.Drawing.Size(109, 21)
        Me.radioOutlookFull.TabIndex = 13
        Me.radioOutlookFull.TabStop = True
        Me.radioOutlookFull.Text = "Outlook - Full"
        Me.radioOutlookFull.UseVisualStyleBackColor = True
        Me.radioPanel.AutoSize = True
        Me.radioPanel.Location = New System.Drawing.Point(16, 421)
        Me.radioPanel.Name = "radioPanel"
        Me.radioPanel.Size = New System.Drawing.Size(61, 21)
        Me.radioPanel.TabIndex = 18
        Me.radioPanel.TabStop = True
        Me.radioPanel.Text = "Panel"
        Me.radioPanel.UseVisualStyleBackColor = True
        Me.radioGroup.AutoSize = True
        Me.radioGroup.Location = New System.Drawing.Point(16, 399)
        Me.radioGroup.Name = "radioGroup"
        Me.radioGroup.Size = New System.Drawing.Size(67, 21)
        Me.radioGroup.TabIndex = 17
        Me.radioGroup.TabStop = True
        Me.radioGroup.Text = "Group"
        Me.radioGroup.UseVisualStyleBackColor = True
        Me.radioHeaderGroup.AutoSize = True
        Me.radioHeaderGroup.Location = New System.Drawing.Point(16, 355)
        Me.radioHeaderGroup.Name = "radioHeaderGroup"
        Me.radioHeaderGroup.Size = New System.Drawing.Size(110, 21)
        Me.radioHeaderGroup.TabIndex = 15
        Me.radioHeaderGroup.TabStop = True
        Me.radioHeaderGroup.Text = "HeaderGroup"
        Me.radioHeaderGroup.UseVisualStyleBackColor = True
        Me.radioBarCheckButtonOnly.AutoSize = True
        Me.radioBarCheckButtonOnly.Location = New System.Drawing.Point(16, 179)
        Me.radioBarCheckButtonOnly.Name = "radioBarCheckButtonOnly"
        Me.radioBarCheckButtonOnly.Size = New System.Drawing.Size(183, 21)
        Me.radioBarCheckButtonOnly.TabIndex = 7
        Me.radioBarCheckButtonOnly.TabStop = True
        Me.radioBarCheckButtonOnly.Text = "Bar - CheckButton - Only"
        Me.radioBarCheckButtonOnly.UseVisualStyleBackColor = True
        Me.radioBarCheckButtonGroupOnly.AutoSize = True
        Me.radioBarCheckButtonGroupOnly.Location = New System.Drawing.Point(16, 157)
        Me.radioBarCheckButtonGroupOnly.Name = "radioBarCheckButtonGroupOnly"
        Me.radioBarCheckButtonGroupOnly.Size = New System.Drawing.Size(234, 21)
        Me.radioBarCheckButtonGroupOnly.TabIndex = 6
        Me.radioBarCheckButtonGroupOnly.TabStop = True
        Me.radioBarCheckButtonGroupOnly.Text = "Bar - CheckButton - Group - Only"
        Me.radioBarCheckButtonGroupOnly.UseVisualStyleBackColor = True
        Me.radioBarCheckButtonGroupInside.AutoSize = True
        Me.radioBarCheckButtonGroupInside.Location = New System.Drawing.Point(16, 135)
        Me.radioBarCheckButtonGroupInside.Name = "radioBarCheckButtonGroupInside"
        Me.radioBarCheckButtonGroupInside.Size = New System.Drawing.Size(241, 21)
        Me.radioBarCheckButtonGroupInside.TabIndex = 5
        Me.radioBarCheckButtonGroupInside.TabStop = True
        Me.radioBarCheckButtonGroupInside.Text = "Bar - CheckButton - Group - Inside"
        Me.radioBarCheckButtonGroupInside.UseVisualStyleBackColor = True
        Me.radioBarCheckButtonGroupOutside.AutoSize = True
        Me.radioBarCheckButtonGroupOutside.Location = New System.Drawing.Point(16, 113)
        Me.radioBarCheckButtonGroupOutside.Name = "radioBarCheckButtonGroupOutside"
        Me.radioBarCheckButtonGroupOutside.Size = New System.Drawing.Size(252, 21)
        Me.radioBarCheckButtonGroupOutside.TabIndex = 4
        Me.radioBarCheckButtonGroupOutside.TabStop = True
        Me.radioBarCheckButtonGroupOutside.Text = "Bar - CheckButton - Group - Outside"
        Me.radioBarCheckButtonGroupOutside.UseVisualStyleBackColor = True
        Me.kryptonNavigator1.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink
        Me.kryptonNavigator1.Button.ButtonDisplayLogic = Krypton.Navigator.ButtonDisplayLogic.Context
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
        Me.kryptonNavigator1.ControlKryptonFormFeatures = False
        Me.kryptonNavigator1.Dock = System.Windows.Forms.DockStyle.Top
        Me.kryptonNavigator1.Header.HeaderPositionBar = Krypton.Toolkit.VisualOrientation.Top
        Me.kryptonNavigator1.Header.HeaderPositionPrimary = Krypton.Toolkit.VisualOrientation.Top
        Me.kryptonNavigator1.Header.HeaderPositionSecondary = Krypton.Toolkit.VisualOrientation.Bottom
        Me.kryptonNavigator1.Header.HeaderStyleBar = Krypton.Toolkit.HeaderStyle.Secondary
        Me.kryptonNavigator1.Header.HeaderStylePrimary = Krypton.Toolkit.HeaderStyle.Primary
        Me.kryptonNavigator1.Header.HeaderStyleSecondary = Krypton.Toolkit.HeaderStyle.Secondary
        Me.kryptonNavigator1.Header.HeaderValuesPrimary.MapDescription = Krypton.Navigator.MapKryptonPageText.None
        Me.kryptonNavigator1.Header.HeaderValuesPrimary.MapHeading = Krypton.Navigator.MapKryptonPageText.TitleText
        Me.kryptonNavigator1.Header.HeaderValuesPrimary.MapImage = Krypton.Navigator.MapKryptonPageImage.MediumSmall
        Me.kryptonNavigator1.Location = New System.Drawing.Point(0, 0)
        Me.kryptonNavigator1.Name = "kryptonNavigator1"
        Me.kryptonNavigator1.NavigatorMode = Krypton.Navigator.NavigatorMode.BarTabGroup
        Me.kryptonNavigator1.Owner = Nothing
        Me.kryptonNavigator1.PageBackStyle = Krypton.Toolkit.PaletteBackStyle.ControlClient
        Me.kryptonNavigator1.Pages.AddRange(New Krypton.Navigator.KryptonPage() { Me.kryptonPage1, Me.kryptonPage2, Me.kryptonPage3, Me.kryptonPage4})
        Me.kryptonNavigator1.PopupPages.AllowPopupPages = Krypton.Navigator.PopupPageAllow.OnlyCompatibleModes
        Me.kryptonNavigator1.PopupPages.Element = Krypton.Navigator.PopupPageElement.Item
        Me.kryptonNavigator1.PopupPages.Position = Krypton.Navigator.PopupPagePosition.ModeAppropriate
        Me.kryptonNavigator1.SelectedIndex = 3
        Me.kryptonNavigator1.Size = New System.Drawing.Size(329, 265)
        Me.kryptonNavigator1.Stack.BorderEdgeStyle = Krypton.Toolkit.PaletteBorderStyle.ControlClient
        Me.kryptonNavigator1.Stack.CheckButtonStyle = Krypton.Toolkit.ButtonStyle.NavigatorStack
        Me.kryptonNavigator1.Stack.ItemOrientation = Krypton.Toolkit.ButtonOrientation.Auto
        Me.kryptonNavigator1.Stack.StackAlignment = Krypton.Toolkit.RelativePositionAlign.Far
        Me.kryptonNavigator1.Stack.StackMapExtraText = Krypton.Navigator.MapKryptonPageText.None
        Me.kryptonNavigator1.Stack.StackMapImage = Krypton.Navigator.MapKryptonPageImage.Small
        Me.kryptonNavigator1.Stack.StackMapText = Krypton.Navigator.MapKryptonPageText.TextTitle
        Me.kryptonNavigator1.Stack.StackOrientation = System.Windows.Forms.Orientation.Vertical
        Me.kryptonNavigator1.TabIndex = 0
        Me.kryptonNavigator1.Text = "kryptonNavigator1"
        Me.kryptonPage1.AutoHiddenSlideSize = New System.Drawing.Size(200, 200)
        Me.kryptonPage1.Controls.Add(Me.button3)
        Me.kryptonPage1.Controls.Add(Me.button2)
        Me.kryptonPage1.Controls.Add(Me.button1)
        Me.kryptonPage1.Controls.Add(Me.buttonPage1)
        Me.kryptonPage1.Flags = 65535
        Me.kryptonPage1.ImageLarge = CType(resources.GetObject("kryptonPage1.ImageLarge"), System.Drawing.Bitmap)
        Me.kryptonPage1.ImageMedium = CType(resources.GetObject("kryptonPage1.ImageMedium"), System.Drawing.Bitmap)
        Me.kryptonPage1.ImageSmall = CType(resources.GetObject("kryptonPage1.ImageSmall"), System.Drawing.Bitmap)
        Me.kryptonPage1.LastVisibleSet = True
        Me.kryptonPage1.MinimumSize = New System.Drawing.Size(50, 50)
        Me.kryptonPage1.Name = "kryptonPage1"
        Me.kryptonPage1.Padding = New System.Windows.Forms.Padding(15)
        Me.kryptonPage1.Size = New System.Drawing.Size(327, 234)
        Me.kryptonPage1.Text = "Page 1"
        Me.kryptonPage1.TextDescription = "Page 1 Description"
        Me.kryptonPage1.TextTitle = "Page 1 Title"
        Me.kryptonPage1.ToolTipTitle = "Page ToolTip"
        Me.kryptonPage1.UniqueName = "1D382D54791F410B1D382D54791F410B"
        Me.button3.Location = New System.Drawing.Point(121, 45)
        Me.button3.Name = "button3"
        Me.button3.Size = New System.Drawing.Size(100, 28)
        Me.button3.TabIndex = 3
        Me.button3.Text = "Page 1 Button"
        Me.button3.UseVisualStyleBackColor = True
        Me.button2.Location = New System.Drawing.Point(121, 15)
        Me.button2.Name = "button2"
        Me.button2.Size = New System.Drawing.Size(100, 28)
        Me.button2.TabIndex = 2
        Me.button2.Text = "Page 1 Button"
        Me.button2.UseVisualStyleBackColor = True
        Me.button1.Location = New System.Drawing.Point(15, 45)
        Me.button1.Name = "button1"
        Me.button1.Size = New System.Drawing.Size(100, 28)
        Me.button1.TabIndex = 1
        Me.button1.Text = "Page 1 Button"
        Me.button1.UseVisualStyleBackColor = True
        Me.buttonPage1.Location = New System.Drawing.Point(15, 15)
        Me.buttonPage1.Name = "buttonPage1"
        Me.buttonPage1.Size = New System.Drawing.Size(100, 28)
        Me.buttonPage1.TabIndex = 0
        Me.buttonPage1.Text = "Page 1 Button"
        Me.buttonPage1.UseVisualStyleBackColor = True
        Me.kryptonPage2.AutoHiddenSlideSize = New System.Drawing.Size(200, 200)
        Me.kryptonPage2.Controls.Add(Me.label2)
        Me.kryptonPage2.Controls.Add(Me.label1)
        Me.kryptonPage2.Controls.Add(Me.labelPage2)
        Me.kryptonPage2.Flags = 65535
        Me.kryptonPage2.ImageLarge = CType(resources.GetObject("kryptonPage2.ImageLarge"), System.Drawing.Bitmap)
        Me.kryptonPage2.ImageMedium = CType(resources.GetObject("kryptonPage2.ImageMedium"), System.Drawing.Bitmap)
        Me.kryptonPage2.ImageSmall = CType(resources.GetObject("kryptonPage2.ImageSmall"), System.Drawing.Bitmap)
        Me.kryptonPage2.LastVisibleSet = True
        Me.kryptonPage2.MinimumSize = New System.Drawing.Size(50, 50)
        Me.kryptonPage2.Name = "kryptonPage2"
        Me.kryptonPage2.Padding = New System.Windows.Forms.Padding(20)
        Me.kryptonPage2.Size = New System.Drawing.Size(327, 238)
        Me.kryptonPage2.Text = "Page 2"
        Me.kryptonPage2.TextDescription = "Page 2 Description"
        Me.kryptonPage2.TextTitle = "Page 2 Title"
        Me.kryptonPage2.ToolTipTitle = "Page ToolTip"
        Me.kryptonPage2.UniqueName = "D27AA26C602E434CD27AA26C602E434C"
        Me.label2.AutoSize = True
        Me.label2.BackColor = System.Drawing.Color.Transparent
        Me.label2.Location = New System.Drawing.Point(20, 68)
        Me.label2.Name = "label2"
        Me.label2.Size = New System.Drawing.Size(85, 17)
        Me.label2.TabIndex = 2
        Me.label2.Text = "Page 2 Label"
        Me.label1.AutoSize = True
        Me.label1.BackColor = System.Drawing.Color.Transparent
        Me.label1.Location = New System.Drawing.Point(20, 45)
        Me.label1.Name = "label1"
        Me.label1.Size = New System.Drawing.Size(85, 17)
        Me.label1.TabIndex = 1
        Me.label1.Text = "Page 2 Label"
        Me.labelPage2.AutoSize = True
        Me.labelPage2.BackColor = System.Drawing.Color.Transparent
        Me.labelPage2.Location = New System.Drawing.Point(20, 20)
        Me.labelPage2.Name = "labelPage2"
        Me.labelPage2.Size = New System.Drawing.Size(85, 17)
        Me.labelPage2.TabIndex = 0
        Me.labelPage2.Text = "Page 2 Label"
        Me.kryptonPage3.AutoHiddenSlideSize = New System.Drawing.Size(200, 200)
        Me.kryptonPage3.Controls.Add(Me.comboBox1)
        Me.kryptonPage3.Controls.Add(Me.comboBoxPage3)
        Me.kryptonPage3.Flags = 65535
        Me.kryptonPage3.ImageLarge = CType(resources.GetObject("kryptonPage3.ImageLarge"), System.Drawing.Bitmap)
        Me.kryptonPage3.ImageMedium = CType(resources.GetObject("kryptonPage3.ImageMedium"), System.Drawing.Bitmap)
        Me.kryptonPage3.ImageSmall = CType(resources.GetObject("kryptonPage3.ImageSmall"), System.Drawing.Bitmap)
        Me.kryptonPage3.LastVisibleSet = True
        Me.kryptonPage3.MinimumSize = New System.Drawing.Size(50, 50)
        Me.kryptonPage3.Name = "kryptonPage3"
        Me.kryptonPage3.Padding = New System.Windows.Forms.Padding(20)
        Me.kryptonPage3.Size = New System.Drawing.Size(327, 238)
        Me.kryptonPage3.Text = "Page 3"
        Me.kryptonPage3.TextDescription = "Page 3 Description"
        Me.kryptonPage3.TextTitle = "Page 3 Title"
        Me.kryptonPage3.ToolTipTitle = "Page ToolTip"
        Me.kryptonPage3.UniqueName = "868F5B555E11408E868F5B555E11408E"
        Me.comboBox1.FormattingEnabled = True
        Me.comboBox1.Items.AddRange(New Object() { "One", "Two", "Three", "Four"})
        Me.comboBox1.Location = New System.Drawing.Point(20, 47)
        Me.comboBox1.Name = "comboBox1"
        Me.comboBox1.Size = New System.Drawing.Size(129, 25)
        Me.comboBox1.TabIndex = 1
        Me.comboBox1.Text = "Page 4 ComboBox"
        Me.comboBoxPage3.FormattingEnabled = True
        Me.comboBoxPage3.Items.AddRange(New Object() { "One", "Two", "Three", "Four"})
        Me.comboBoxPage3.Location = New System.Drawing.Point(20, 20)
        Me.comboBoxPage3.Name = "comboBoxPage3"
        Me.comboBoxPage3.Size = New System.Drawing.Size(129, 25)
        Me.comboBoxPage3.TabIndex = 0
        Me.comboBoxPage3.Text = "Page 4 ComboBox"
        Me.kryptonPage4.AutoHiddenSlideSize = New System.Drawing.Size(200, 200)
        Me.kryptonPage4.Controls.Add(Me.textBox1)
        Me.kryptonPage4.Controls.Add(Me.textBoxPage4)
        Me.kryptonPage4.Flags = 65535
        Me.kryptonPage4.ImageLarge = CType(resources.GetObject("kryptonPage4.ImageLarge"), System.Drawing.Bitmap)
        Me.kryptonPage4.ImageMedium = CType(resources.GetObject("kryptonPage4.ImageMedium"), System.Drawing.Bitmap)
        Me.kryptonPage4.ImageSmall = CType(resources.GetObject("kryptonPage4.ImageSmall"), System.Drawing.Bitmap)
        Me.kryptonPage4.LastVisibleSet = True
        Me.kryptonPage4.MinimumSize = New System.Drawing.Size(50, 50)
        Me.kryptonPage4.Name = "kryptonPage4"
        Me.kryptonPage4.Padding = New System.Windows.Forms.Padding(20)
        Me.kryptonPage4.Size = New System.Drawing.Size(327, 234)
        Me.kryptonPage4.Text = "Page 4"
        Me.kryptonPage4.TextDescription = "Page 4 Description"
        Me.kryptonPage4.TextTitle = "Page 4 Title"
        Me.kryptonPage4.ToolTipTitle = "Page ToolTip"
        Me.kryptonPage4.UniqueName = "5F53C2C849EF4A225F53C2C849EF4A22"
        Me.textBox1.BackColor = System.Drawing.SystemColors.Info
        Me.textBox1.Location = New System.Drawing.Point(20, 67)
        Me.textBox1.Multiline = True
        Me.textBox1.Name = "textBox1"
        Me.textBox1.Size = New System.Drawing.Size(117, 40)
        Me.textBox1.TabIndex = 1
        Me.textBox1.Text = "Page 4 TextBox"
        Me.textBoxPage4.BackColor = System.Drawing.SystemColors.Info
        Me.textBoxPage4.Location = New System.Drawing.Point(20, 20)
        Me.textBoxPage4.Multiline = True
        Me.textBoxPage4.Name = "textBoxPage4"
        Me.textBoxPage4.Size = New System.Drawing.Size(117, 40)
        Me.textBoxPage4.TabIndex = 0
        Me.textBoxPage4.Text = "Page 4 TextBox"
        Me.buttonClose.Location = New System.Drawing.Point(557, 473)
        Me.buttonClose.Name = "buttonClose"
        Me.buttonClose.Size = New System.Drawing.Size(75, 23)
        Me.buttonClose.TabIndex = 2
        Me.buttonClose.Text = "Close"
        Me.buttonClose.UseVisualStyleBackColor = True
        Me.groupBox2.Controls.Add(Me.textBoxDescription)
        Me.groupBox2.Location = New System.Drawing.Point(304, 290)
        Me.groupBox2.Name = "groupBox2"
        Me.groupBox2.Padding = New System.Windows.Forms.Padding(5)
        Me.groupBox2.Size = New System.Drawing.Size(329, 177)
        Me.groupBox2.TabIndex = 1
        Me.groupBox2.TabStop = False
        Me.groupBox2.Text = "Mode Description"
        Me.textBoxDescription.BackColor = System.Drawing.SystemColors.Control
        Me.textBoxDescription.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.textBoxDescription.Dock = System.Windows.Forms.DockStyle.Fill
        Me.textBoxDescription.Location = New System.Drawing.Point(5, 22)
        Me.textBoxDescription.Name = "textBoxDescription"
        Me.textBoxDescription.Size = New System.Drawing.Size(319, 150)
        Me.textBoxDescription.TabIndex = 0
        Me.textBoxDescription.Text = ""
        Me.panelWithNav.Controls.Add(Me.kryptonNavigator1)
        Me.panelWithNav.Location = New System.Drawing.Point(304, 13)
        Me.panelWithNav.Name = "panelWithNav"
        Me.panelWithNav.Size = New System.Drawing.Size(329, 265)
        Me.panelWithNav.TabIndex = 4
        Me.kryptonManager1.GlobalPaletteMode = Krypton.Toolkit.PaletteMode.ProfessionalSystem
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8F, 17F)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(661, 508)
        Me.Controls.Add(Me.panelWithNav)
        Me.Controls.Add(Me.groupBox2)
        Me.Controls.Add(Me.buttonClose)
        Me.Controls.Add(Me.groupBox1)
        Me.Font = New System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.MaximizeBox = False
        Me.MinimizeBox = False
        Me.Name = "Form1"
        Me.Text = "Navigator Modes"
        Me.groupBox1.ResumeLayout(False)
        Me.groupBox1.PerformLayout()
        CType(Me.kryptonNavigator1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.kryptonNavigator1.ResumeLayout(False)
        CType(Me.kryptonPage1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.kryptonPage1.ResumeLayout(False)
        CType(Me.kryptonPage2, System.ComponentModel.ISupportInitialize).EndInit()
        Me.kryptonPage2.ResumeLayout(False)
        Me.kryptonPage2.PerformLayout()
        CType(Me.kryptonPage3, System.ComponentModel.ISupportInitialize).EndInit()
        Me.kryptonPage3.ResumeLayout(False)
        CType(Me.kryptonPage4, System.ComponentModel.ISupportInitialize).EndInit()
        Me.kryptonPage4.ResumeLayout(False)
        Me.kryptonPage4.PerformLayout()
        Me.groupBox2.ResumeLayout(False)
        Me.panelWithNav.ResumeLayout(False)
        Me.ResumeLayout(False)
    End Sub

    Friend WithEvents kryptonNavigator1 As Krypton.Navigator.KryptonNavigator
    Friend WithEvents kryptonPage1 As Krypton.Navigator.KryptonPage
    Friend WithEvents kryptonPage2 As Krypton.Navigator.KryptonPage
    Friend WithEvents groupBox1 As System.Windows.Forms.GroupBox
    Friend WithEvents radioPanel As System.Windows.Forms.RadioButton
    Friend WithEvents radioGroup As System.Windows.Forms.RadioButton
    Friend WithEvents radioHeaderGroup As System.Windows.Forms.RadioButton
    Friend WithEvents radioBarCheckButtonOnly As System.Windows.Forms.RadioButton
    Friend WithEvents radioBarCheckButtonGroupOnly As System.Windows.Forms.RadioButton
    Friend WithEvents radioBarCheckButtonGroupInside As System.Windows.Forms.RadioButton
    Friend WithEvents radioBarCheckButtonGroupOutside As System.Windows.Forms.RadioButton
    Friend WithEvents buttonClose As System.Windows.Forms.Button
    Friend WithEvents kryptonPage3 As Krypton.Navigator.KryptonPage
    Friend WithEvents kryptonPage4 As Krypton.Navigator.KryptonPage
    Friend WithEvents groupBox2 As System.Windows.Forms.GroupBox
    Friend WithEvents textBoxDescription As System.Windows.Forms.RichTextBox
    Friend WithEvents buttonPage1 As System.Windows.Forms.Button
    Friend WithEvents labelPage2 As System.Windows.Forms.Label
    Friend WithEvents comboBoxPage3 As System.Windows.Forms.ComboBox
    Friend WithEvents textBoxPage4 As System.Windows.Forms.TextBox
    Friend WithEvents radioStackCheckButtonHeaderGroup As System.Windows.Forms.RadioButton
    Friend WithEvents radioStackCheckButtonGroup As System.Windows.Forms.RadioButton
    Friend WithEvents radioOutlookFull As System.Windows.Forms.RadioButton
    Friend WithEvents radioBarTabGroup As System.Windows.Forms.RadioButton
    Friend WithEvents radioBarTabOnly As System.Windows.Forms.RadioButton
    Friend WithEvents radioHeaderBarCheckButtonOnly As System.Windows.Forms.RadioButton
    Friend WithEvents radioHeaderBarCheckButtonHeaderGroup As System.Windows.Forms.RadioButton
    Friend WithEvents radioHeaderBarCheckButtonGroup As System.Windows.Forms.RadioButton
    Friend WithEvents panelWithNav As System.Windows.Forms.Panel
    Friend WithEvents radioBarRibbonTabOnly As System.Windows.Forms.RadioButton
    Friend WithEvents radioBarRibbonTabGroup As System.Windows.Forms.RadioButton
    Friend WithEvents radioOutlookMini As System.Windows.Forms.RadioButton
    Friend WithEvents button3 As System.Windows.Forms.Button
    Friend WithEvents button2 As System.Windows.Forms.Button
    Friend WithEvents button1 As System.Windows.Forms.Button
    Friend WithEvents label2 As System.Windows.Forms.Label
    Friend WithEvents label1 As System.Windows.Forms.Label
    Friend WithEvents comboBox1 As System.Windows.Forms.ComboBox
    Friend WithEvents textBox1 As System.Windows.Forms.TextBox
    Friend WithEvents radioHeaderGroupTab As System.Windows.Forms.RadioButton
    Friend WithEvents kryptonManager1 As Krypton.Toolkit.KryptonManager
End Class
