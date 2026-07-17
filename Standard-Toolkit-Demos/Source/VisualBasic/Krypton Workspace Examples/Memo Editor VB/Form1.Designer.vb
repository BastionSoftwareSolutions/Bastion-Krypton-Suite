' VB.NET twin of Source\Krypton Workspace Examples\Memo Editor\Form1.Designer.cs (Bastion Phase 4c).
<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class MemoEditorForm
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
        Me.kryptonRibbon = New Krypton.Ribbon.KryptonRibbon()
        Me.appButtonNewMemo = New Krypton.Toolkit.KryptonContextMenuItem()
        Me.appButtonOpenMemo = New Krypton.Toolkit.KryptonContextMenuItem()
        Me.appButtonSep1 = New Krypton.Toolkit.KryptonContextMenuSeparator()
        Me.appButtonSaveMemo = New Krypton.Toolkit.KryptonContextMenuItem()
        Me.appButtonSaveAsMemo = New Krypton.Toolkit.KryptonContextMenuItem()
        Me.appButtonSaveAllMemo = New Krypton.Toolkit.KryptonContextMenuItem()
        Me.appButtonSep2 = New Krypton.Toolkit.KryptonContextMenuSeparator()
        Me.appButtonCloseMemo = New Krypton.Toolkit.KryptonContextMenuItem()
        Me.appButtonCloseAllMemo = New Krypton.Toolkit.KryptonContextMenuItem()
        Me.buttonSpecExit = New Krypton.Ribbon.ButtonSpecAppMenu()
        Me.ribbonTabMemo = New Krypton.Ribbon.KryptonRibbonTab()
        Me.kryptonRibbonGroup1 = New Krypton.Ribbon.KryptonRibbonGroup()
        Me.kryptonRibbonGroupTriple1 = New Krypton.Ribbon.KryptonRibbonGroupTriple()
        Me.buttonNewMemo = New Krypton.Ribbon.KryptonRibbonGroupButton()
        Me.buttonOpenMemo = New Krypton.Ribbon.KryptonRibbonGroupButton()
        Me.kryptonRibbonGroupSeparator1 = New Krypton.Ribbon.KryptonRibbonGroupSeparator()
        Me.kryptonRibbonGroupTriple3 = New Krypton.Ribbon.KryptonRibbonGroupTriple()
        Me.buttonSaveMemo = New Krypton.Ribbon.KryptonRibbonGroupButton()
        Me.buttonSaveAsMemo = New Krypton.Ribbon.KryptonRibbonGroupButton()
        Me.buttonSaveAllMemo = New Krypton.Ribbon.KryptonRibbonGroupButton()
        Me.kryptonRibbonGroupSeparator2 = New Krypton.Ribbon.KryptonRibbonGroupSeparator()
        Me.kryptonRibbonGroupTriple4 = New Krypton.Ribbon.KryptonRibbonGroupTriple()
        Me.buttonCloseMemo = New Krypton.Ribbon.KryptonRibbonGroupButton()
        Me.buttonCloseAllMemo = New Krypton.Ribbon.KryptonRibbonGroupButton()
        Me.kryptonRibbonGroup2 = New Krypton.Ribbon.KryptonRibbonGroup()
        Me.kryptonRibbonGroupTriple2 = New Krypton.Ribbon.KryptonRibbonGroupTriple()
        Me.buttonSingleGroupArrange = New Krypton.Ribbon.KryptonRibbonGroupButton()
        Me.kryptonRibbonGroupTriple5 = New Krypton.Ribbon.KryptonRibbonGroupTriple()
        Me.buttonGridArrange = New Krypton.Ribbon.KryptonRibbonGroupButton()
        Me.buttonVerticalArrange = New Krypton.Ribbon.KryptonRibbonGroupButton()
        Me.buttonHorizontalArrange = New Krypton.Ribbon.KryptonRibbonGroupButton()
        Me.kryptonRibbonGroup3 = New Krypton.Ribbon.KryptonRibbonGroup()
        Me.kryptonRibbonGroupTriple6 = New Krypton.Ribbon.KryptonRibbonGroupTriple()
        Me.buttonReadMe = New Krypton.Ribbon.KryptonRibbonGroupButton()
        Me.buttonShortcuts = New Krypton.Ribbon.KryptonRibbonGroupButton()
        Me.buttonPersistence = New Krypton.Ribbon.KryptonRibbonGroupButton()
        Me.ribbonTabAppearance = New Krypton.Ribbon.KryptonRibbonTab()
        Me.kryptonRibbonGroup4 = New Krypton.Ribbon.KryptonRibbonGroup()
        Me.kryptonRibbonGroupTriple12 = New Krypton.Ribbon.KryptonRibbonGroupTriple()
        Me.button2010Blue = New Krypton.Ribbon.KryptonRibbonGroupButton()
        Me.button2010Silver = New Krypton.Ribbon.KryptonRibbonGroupButton()
        Me.button2010Black = New Krypton.Ribbon.KryptonRibbonGroupButton()
        Me.kryptonRibbonGroupTriple7 = New Krypton.Ribbon.KryptonRibbonGroupTriple()
        Me.button2007Blue = New Krypton.Ribbon.KryptonRibbonGroupButton()
        Me.button2007Silver = New Krypton.Ribbon.KryptonRibbonGroupButton()
        Me.button2007Black = New Krypton.Ribbon.KryptonRibbonGroupButton()
        Me.kryptonRibbonGroupTriple8 = New Krypton.Ribbon.KryptonRibbonGroupTriple()
        Me.buttonSparkleBlue = New Krypton.Ribbon.KryptonRibbonGroupButton()
        Me.buttonSparkleOrange = New Krypton.Ribbon.KryptonRibbonGroupButton()
        Me.buttonSparklePurple = New Krypton.Ribbon.KryptonRibbonGroupButton()
        Me.kryptonRibbonGroupTriple9 = New Krypton.Ribbon.KryptonRibbonGroupTriple()
        Me.buttonSystem = New Krypton.Ribbon.KryptonRibbonGroupButton()
        Me.button2003 = New Krypton.Ribbon.KryptonRibbonGroupButton()
        Me.kryptonRibbonGroup5 = New Krypton.Ribbon.KryptonRibbonGroup()
        Me.kryptonRibbonGroupTriple10 = New Krypton.Ribbon.KryptonRibbonGroupTriple()
        Me.buttonTabs = New Krypton.Ribbon.KryptonRibbonGroupButton()
        Me.buttonRibbonTabs = New Krypton.Ribbon.KryptonRibbonGroupButton()
        Me.buttonButtons = New Krypton.Ribbon.KryptonRibbonGroupButton()
        Me.kryptonRibbonGroupTriple11 = New Krypton.Ribbon.KryptonRibbonGroupTriple()
        Me.buttonHeader = New Krypton.Ribbon.KryptonRibbonGroupButton()
        Me.buttonHeaderButtons = New Krypton.Ribbon.KryptonRibbonGroupButton()
        Me.buttonStack = New Krypton.Ribbon.KryptonRibbonGroupButton()
        Me.kryptonPanel1 = New Krypton.Toolkit.KryptonPanel()
        Me.kryptonWorkspace = New Krypton.Workspace.KryptonWorkspace()
        Me.imageList32 = New System.Windows.Forms.ImageList(Me.components)
        Me.openFileDialog = New System.Windows.Forms.OpenFileDialog()
        Me.saveFileDialog = New System.Windows.Forms.SaveFileDialog()
        Me.kryptonManager = New Krypton.Toolkit.KryptonManager(Me.components)
        CType(Me.kryptonRibbon, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.kryptonPanel1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.kryptonPanel1.SuspendLayout()
        CType(Me.kryptonWorkspace, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        Me.kryptonRibbon.InDesignHelperMode = True
        Me.kryptonRibbon.Name = "kryptonRibbon"
        Me.kryptonRibbon.RibbonFileAppButton.AppButtonMaxRecentSize = New System.Drawing.Size(250, 200)
        Me.kryptonRibbon.RibbonFileAppButton.AppButtonMenuItems.AddRange(New Krypton.Toolkit.KryptonContextMenuItemBase() { Me.appButtonNewMemo, Me.appButtonOpenMemo, Me.appButtonSep1, Me.appButtonSaveMemo, Me.appButtonSaveAsMemo, Me.appButtonSaveAllMemo, Me.appButtonSep2, Me.appButtonCloseMemo, Me.appButtonCloseAllMemo})
        Me.kryptonRibbon.RibbonFileAppButton.AppButtonMinRecentSize = New System.Drawing.Size(150, 200)
        Me.kryptonRibbon.RibbonFileAppButton.AppButtonSpecs.Add(Me.buttonSpecExit)
        Me.kryptonRibbon.RibbonTabs.AddRange(New Krypton.Ribbon.KryptonRibbonTab() { Me.ribbonTabMemo, Me.ribbonTabAppearance})
        Me.kryptonRibbon.SelectedTab = Me.ribbonTabMemo
        Me.kryptonRibbon.Size = New System.Drawing.Size(783, 136)
        Me.kryptonRibbon.TabIndex = 0
        Me.appButtonNewMemo.Text = "&New"
        Me.appButtonOpenMemo.Text = "&Open"
        Me.appButtonSaveMemo.Text = "&Save"
        Me.appButtonSaveAsMemo.Text = "Save &As..."
        Me.appButtonSaveAllMemo.Text = "Save A&ll"
        Me.appButtonCloseMemo.Image = My.Resources.close24
        Me.appButtonCloseMemo.Text = "&Close"
        Me.appButtonCloseAllMemo.Image = My.Resources.closeAll24
        Me.appButtonCloseAllMemo.Text = "Clos&e All"
        Me.buttonSpecExit.Style = Krypton.Toolkit.PaletteButtonStyle.Alternate
        Me.buttonSpecExit.Text = "Exit"
        Me.buttonSpecExit.UniqueName = "24B4BB79AD0B474C24B4BB79AD0B474C"
        Me.ribbonTabMemo.Groups.AddRange(New Krypton.Ribbon.KryptonRibbonGroup() { Me.kryptonRibbonGroup1, Me.kryptonRibbonGroup2, Me.kryptonRibbonGroup3})
        Me.ribbonTabMemo.KeyTip = "M"
        Me.ribbonTabMemo.Text = "Memo"
        Me.kryptonRibbonGroup1.DialogBoxLauncher = False
        Me.kryptonRibbonGroup1.Items.AddRange(New Krypton.Ribbon.KryptonRibbonGroupContainer() { Me.kryptonRibbonGroupTriple1, Me.kryptonRibbonGroupSeparator1, Me.kryptonRibbonGroupTriple3, Me.kryptonRibbonGroupSeparator2, Me.kryptonRibbonGroupTriple4})
        Me.kryptonRibbonGroup1.TextLine1 = "Memos"
        Me.kryptonRibbonGroupTriple1.Items.AddRange(New Krypton.Ribbon.KryptonRibbonGroupItem() { Me.buttonNewMemo, Me.buttonOpenMemo})
        Me.buttonNewMemo.KeyTip = "N"
        Me.buttonNewMemo.ShortcutKeys = CType((System.Windows.Forms.Keys.Control Or System.Windows.Forms.Keys.N), System.Windows.Forms.Keys)
        Me.buttonNewMemo.TextLine1 = "New"
        Me.buttonOpenMemo.KeyTip = "O"
        Me.buttonOpenMemo.ShortcutKeys = CType((System.Windows.Forms.Keys.Control Or System.Windows.Forms.Keys.O), System.Windows.Forms.Keys)
        Me.buttonOpenMemo.TextLine1 = "Open"
        Me.kryptonRibbonGroupTriple3.Items.AddRange(New Krypton.Ribbon.KryptonRibbonGroupItem() { Me.buttonSaveMemo, Me.buttonSaveAsMemo, Me.buttonSaveAllMemo})
        Me.buttonSaveMemo.KeyTip = "S"
        Me.buttonSaveMemo.ShortcutKeys = CType((System.Windows.Forms.Keys.Control Or System.Windows.Forms.Keys.S), System.Windows.Forms.Keys)
        Me.buttonSaveMemo.TextLine1 = "Save"
        Me.buttonSaveAsMemo.KeyTip = "A"
        Me.buttonSaveAsMemo.TextLine1 = "Save"
        Me.buttonSaveAsMemo.TextLine2 = "As"
        Me.buttonSaveAllMemo.KeyTip = "L"
        Me.buttonSaveAllMemo.ShortcutKeys = CType(((System.Windows.Forms.Keys.Control Or System.Windows.Forms.Keys.Shift) Or System.Windows.Forms.Keys.S), System.Windows.Forms.Keys)
        Me.buttonSaveAllMemo.TextLine1 = "Save"
        Me.buttonSaveAllMemo.TextLine2 = "All"
        Me.kryptonRibbonGroupTriple4.Items.AddRange(New Krypton.Ribbon.KryptonRibbonGroupItem() { Me.buttonCloseMemo, Me.buttonCloseAllMemo})
        Me.buttonCloseMemo.KeyTip = "C"
        Me.buttonCloseMemo.TextLine1 = "Close"
        Me.buttonCloseAllMemo.KeyTip = "E"
        Me.buttonCloseAllMemo.TextLine1 = "Close"
        Me.buttonCloseAllMemo.TextLine2 = "All"
        Me.kryptonRibbonGroup2.DialogBoxLauncher = False
        Me.kryptonRibbonGroup2.Items.AddRange(New Krypton.Ribbon.KryptonRibbonGroupContainer() { Me.kryptonRibbonGroupTriple2, Me.kryptonRibbonGroupTriple5})
        Me.kryptonRibbonGroup2.TextLine1 = "Arrange"
        Me.kryptonRibbonGroupTriple2.Items.AddRange(New Krypton.Ribbon.KryptonRibbonGroupItem() { Me.buttonSingleGroupArrange})
        Me.kryptonRibbonGroupTriple2.MinimumSize = Krypton.Ribbon.GroupItemSize.Large
        Me.buttonSingleGroupArrange.KeyTip = "T"
        Me.buttonSingleGroupArrange.ShortcutKeys = CType(((System.Windows.Forms.Keys.Control Or System.Windows.Forms.Keys.Shift) Or System.Windows.Forms.Keys.T), System.Windows.Forms.Keys)
        Me.buttonSingleGroupArrange.TextLine1 = "Single"
        Me.buttonSingleGroupArrange.TextLine2 = "Group"
        Me.kryptonRibbonGroupTriple5.Items.AddRange(New Krypton.Ribbon.KryptonRibbonGroupItem() { Me.buttonGridArrange, Me.buttonVerticalArrange, Me.buttonHorizontalArrange})
        Me.kryptonRibbonGroupTriple5.MaximumSize = Krypton.Ribbon.GroupItemSize.Medium
        Me.buttonGridArrange.KeyTip = "G"
        Me.buttonGridArrange.ShortcutKeys = CType(((System.Windows.Forms.Keys.Control Or System.Windows.Forms.Keys.Shift) Or System.Windows.Forms.Keys.G), System.Windows.Forms.Keys)
        Me.buttonGridArrange.TextLine1 = "Grid"
        Me.buttonVerticalArrange.KeyTip = "V"
        Me.buttonVerticalArrange.TextLine1 = "Vertical"
        Me.buttonHorizontalArrange.KeyTip = "H"
        Me.buttonHorizontalArrange.TextLine1 = "Horizontal"
        Me.kryptonRibbonGroup3.DialogBoxLauncher = False
        Me.kryptonRibbonGroup3.Items.AddRange(New Krypton.Ribbon.KryptonRibbonGroupContainer() { Me.kryptonRibbonGroupTriple6})
        Me.kryptonRibbonGroup3.TextLine1 = "Predefined"
        Me.kryptonRibbonGroupTriple6.Items.AddRange(New Krypton.Ribbon.KryptonRibbonGroupItem() { Me.buttonReadMe, Me.buttonShortcuts, Me.buttonPersistence})
        Me.kryptonRibbonGroupTriple6.MaximumSize = Krypton.Ribbon.GroupItemSize.Medium
        Me.kryptonRibbonGroupTriple6.MinimumSize = Krypton.Ribbon.GroupItemSize.Medium
        Me.buttonReadMe.ImageLarge = Nothing
        Me.buttonReadMe.TextLine1 = "ReadMe"
        Me.buttonShortcuts.ImageLarge = Nothing
        Me.buttonShortcuts.TextLine1 = "Shortcuts"
        Me.buttonPersistence.KeyTip = "P"
        Me.buttonPersistence.TextLine1 = "Persistence"
        Me.ribbonTabAppearance.Groups.AddRange(New Krypton.Ribbon.KryptonRibbonGroup() { Me.kryptonRibbonGroup4, Me.kryptonRibbonGroup5})
        Me.ribbonTabAppearance.KeyTip = "A"
        Me.ribbonTabAppearance.Text = "Appearance"
        Me.kryptonRibbonGroup4.DialogBoxLauncher = False
        Me.kryptonRibbonGroup4.Items.AddRange(New Krypton.Ribbon.KryptonRibbonGroupContainer() { Me.kryptonRibbonGroupTriple12, Me.kryptonRibbonGroupTriple7, Me.kryptonRibbonGroupTriple8, Me.kryptonRibbonGroupTriple9})
        Me.kryptonRibbonGroup4.KeyTipGroup = "P"
        Me.kryptonRibbonGroup4.TextLine1 = "Palette"
        Me.kryptonRibbonGroupTriple12.Items.AddRange(New Krypton.Ribbon.KryptonRibbonGroupItem() { Me.button2010Blue, Me.button2010Silver, Me.button2010Black})
        Me.kryptonRibbonGroupTriple12.MaximumSize = Krypton.Ribbon.GroupItemSize.Medium
        Me.kryptonRibbonGroupTriple12.MinimumSize = Krypton.Ribbon.GroupItemSize.Medium
        Me.button2010Blue.ButtonType = Krypton.Ribbon.GroupButtonType.Check
        Me.button2010Blue.Checked = True
        Me.button2010Blue.Tag = "Office 2010 - Blue"
        Me.button2010Blue.TextLine1 = "2010 Blue"
        Me.button2010Silver.ButtonType = Krypton.Ribbon.GroupButtonType.Check
        Me.button2010Silver.Tag = "Office 2010 - Silver"
        Me.button2010Silver.TextLine1 = "2010 Silver"
        Me.button2010Black.ButtonType = Krypton.Ribbon.GroupButtonType.Check
        Me.button2010Black.Tag = "Office 2010 - Black"
        Me.button2010Black.TextLine1 = "2010 Black"
        Me.kryptonRibbonGroupTriple7.Items.AddRange(New Krypton.Ribbon.KryptonRibbonGroupItem() { Me.button2007Blue, Me.button2007Silver, Me.button2007Black})
        Me.kryptonRibbonGroupTriple7.MaximumSize = Krypton.Ribbon.GroupItemSize.Medium
        Me.kryptonRibbonGroupTriple7.MinimumSize = Krypton.Ribbon.GroupItemSize.Medium
        Me.button2007Blue.ButtonType = Krypton.Ribbon.GroupButtonType.Check
        Me.button2007Blue.KeyTip = "2B"
        Me.button2007Blue.Tag = "Office 2007 - Blue"
        Me.button2007Blue.TextLine1 = "2007"
        Me.button2007Blue.TextLine2 = "Blue"
        Me.button2007Silver.ButtonType = Krypton.Ribbon.GroupButtonType.Check
        Me.button2007Silver.KeyTip = "2S"
        Me.button2007Silver.Tag = "Office 2007 - Silver"
        Me.button2007Silver.TextLine1 = "2007"
        Me.button2007Silver.TextLine2 = "Silver"
        Me.button2007Black.ButtonType = Krypton.Ribbon.GroupButtonType.Check
        Me.button2007Black.KeyTip = "2L"
        Me.button2007Black.Tag = "Office 2007 - Black"
        Me.button2007Black.TextLine1 = "2007"
        Me.button2007Black.TextLine2 = "Black"
        Me.kryptonRibbonGroupTriple8.Items.AddRange(New Krypton.Ribbon.KryptonRibbonGroupItem() { Me.buttonSparkleBlue, Me.buttonSparkleOrange, Me.buttonSparklePurple})
        Me.kryptonRibbonGroupTriple8.MaximumSize = Krypton.Ribbon.GroupItemSize.Medium
        Me.kryptonRibbonGroupTriple8.MinimumSize = Krypton.Ribbon.GroupItemSize.Medium
        Me.buttonSparkleBlue.ButtonType = Krypton.Ribbon.GroupButtonType.Check
        Me.buttonSparkleBlue.KeyTip = "SB"
        Me.buttonSparkleBlue.Tag = "Sparkle - Blue"
        Me.buttonSparkleBlue.TextLine1 = "Sparkle"
        Me.buttonSparkleBlue.TextLine2 = "Blue"
        Me.buttonSparkleOrange.ButtonType = Krypton.Ribbon.GroupButtonType.Check
        Me.buttonSparkleOrange.KeyTip = "SO"
        Me.buttonSparkleOrange.Tag = "Sparkle - Orange"
        Me.buttonSparkleOrange.TextLine1 = "Sparkle"
        Me.buttonSparkleOrange.TextLine2 = "Orange"
        Me.buttonSparklePurple.ButtonType = Krypton.Ribbon.GroupButtonType.Check
        Me.buttonSparklePurple.KeyTip = "SP"
        Me.buttonSparklePurple.Tag = "Sparkle - Purple"
        Me.buttonSparklePurple.TextLine1 = "Sparkle"
        Me.buttonSparklePurple.TextLine2 = "Purple"
        Me.kryptonRibbonGroupTriple9.Items.AddRange(New Krypton.Ribbon.KryptonRibbonGroupItem() { Me.buttonSystem, Me.button2003})
        Me.kryptonRibbonGroupTriple9.MaximumSize = Krypton.Ribbon.GroupItemSize.Medium
        Me.kryptonRibbonGroupTriple9.MinimumSize = Krypton.Ribbon.GroupItemSize.Medium
        Me.buttonSystem.ButtonType = Krypton.Ribbon.GroupButtonType.Check
        Me.buttonSystem.KeyTip = "Y"
        Me.buttonSystem.Tag = "Professional - System"
        Me.buttonSystem.TextLine1 = "System"
        Me.button2003.ButtonType = Krypton.Ribbon.GroupButtonType.Check
        Me.button2003.KeyTip = "3"
        Me.button2003.Tag = "Professional - Office 2003"
        Me.button2003.TextLine1 = "2003"
        Me.kryptonRibbonGroup5.DialogBoxLauncher = False
        Me.kryptonRibbonGroup5.Items.AddRange(New Krypton.Ribbon.KryptonRibbonGroupContainer() { Me.kryptonRibbonGroupTriple10, Me.kryptonRibbonGroupTriple11})
        Me.kryptonRibbonGroup5.TextLine1 = "Grouping"
        Me.kryptonRibbonGroupTriple10.Items.AddRange(New Krypton.Ribbon.KryptonRibbonGroupItem() { Me.buttonTabs, Me.buttonRibbonTabs, Me.buttonButtons})
        Me.kryptonRibbonGroupTriple10.MaximumSize = Krypton.Ribbon.GroupItemSize.Medium
        Me.kryptonRibbonGroupTriple10.MinimumSize = Krypton.Ribbon.GroupItemSize.Medium
        Me.buttonTabs.ButtonType = Krypton.Ribbon.GroupButtonType.Check
        Me.buttonTabs.ImageSmall = My.Resources.Tabs
        Me.buttonTabs.KeyTip = "T"
        Me.buttonTabs.Tag = "BarTabGroup"
        Me.buttonTabs.TextLine1 = "Tabs"
        Me.buttonRibbonTabs.ButtonType = Krypton.Ribbon.GroupButtonType.Check
        Me.buttonRibbonTabs.ImageSmall = My.Resources.Tabs
        Me.buttonRibbonTabs.KeyTip = "R"
        Me.buttonRibbonTabs.Tag = "BarRibbonTabGroup"
        Me.buttonRibbonTabs.TextLine1 = "Ribbon Tabs"
        Me.buttonButtons.ButtonType = Krypton.Ribbon.GroupButtonType.Check
        Me.buttonButtons.ImageSmall = My.Resources.Tabs
        Me.buttonButtons.Tag = "BarCheckButtonGroupOutside"
        Me.buttonButtons.TextLine1 = "Buttons"
        Me.kryptonRibbonGroupTriple11.Items.AddRange(New Krypton.Ribbon.KryptonRibbonGroupItem() { Me.buttonHeader, Me.buttonHeaderButtons, Me.buttonStack})
        Me.kryptonRibbonGroupTriple11.MaximumSize = Krypton.Ribbon.GroupItemSize.Medium
        Me.kryptonRibbonGroupTriple11.MinimumSize = Krypton.Ribbon.GroupItemSize.Medium
        Me.buttonHeader.ButtonType = Krypton.Ribbon.GroupButtonType.Check
        Me.buttonHeader.ImageSmall = My.Resources.Tabs
        Me.buttonHeader.KeyTip = "H"
        Me.buttonHeader.Tag = "HeaderGroup"
        Me.buttonHeader.TextLine1 = "Header"
        Me.buttonHeaderButtons.ButtonType = Krypton.Ribbon.GroupButtonType.Check
        Me.buttonHeaderButtons.ImageSmall = My.Resources.Tabs
        Me.buttonHeaderButtons.KeyTip = "D"
        Me.buttonHeaderButtons.Tag = "HeaderBarCheckButtonHeaderGroup"
        Me.buttonHeaderButtons.TextLine1 = "Header Buttons"
        Me.buttonStack.ButtonType = Krypton.Ribbon.GroupButtonType.Check
        Me.buttonStack.ImageSmall = My.Resources.Tabs
        Me.buttonStack.KeyTip = "Y"
        Me.buttonStack.Tag = "StackCheckButtonGroup"
        Me.buttonStack.TextLine1 = "Stack"
        Me.kryptonPanel1.Controls.Add(Me.kryptonWorkspace)
        Me.kryptonPanel1.Dock = System.Windows.Forms.DockStyle.Fill
        Me.kryptonPanel1.Location = New System.Drawing.Point(0, 136)
        Me.kryptonPanel1.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.kryptonPanel1.Name = "kryptonPanel1"
        Me.kryptonPanel1.Padding = New System.Windows.Forms.Padding(7, 6, 7, 6)
        Me.kryptonPanel1.Size = New System.Drawing.Size(783, 421)
        Me.kryptonPanel1.TabIndex = 1
        Me.kryptonWorkspace.ActivePage = Nothing
        Me.kryptonWorkspace.CompactFlags = CType((((Krypton.Workspace.CompactFlags.RemoveEmptyCells Or Krypton.Workspace.CompactFlags.RemoveEmptySequences) Or Krypton.Workspace.CompactFlags.PromoteLeafs) Or Krypton.Workspace.CompactFlags.AtLeastOneVisibleCell), Krypton.Workspace.CompactFlags)
        Me.kryptonWorkspace.ContainerBackStyle = Krypton.Toolkit.PaletteBackStyle.PanelClient
        Me.kryptonWorkspace.Dock = System.Windows.Forms.DockStyle.Fill
        Me.kryptonWorkspace.Location = New System.Drawing.Point(7, 6)
        Me.kryptonWorkspace.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.kryptonWorkspace.Name = "kryptonWorkspace"
        Me.kryptonWorkspace.Root.UniqueName = "95EF19B665334EE77CBA364F49E3EB38"
        Me.kryptonWorkspace.Root.WorkspaceControl = Me.kryptonWorkspace
        Me.kryptonWorkspace.SeparatorStyle = Krypton.Toolkit.SeparatorStyle.HighProfile
        Me.kryptonWorkspace.Size = New System.Drawing.Size(769, 409)
        Me.kryptonWorkspace.SplitterWidth = 5
        Me.kryptonWorkspace.TabIndex = 1
        Me.kryptonWorkspace.TabStop = True
        Me.imageList32.ColorDepth = System.Windows.Forms.ColorDepth.Depth8Bit
        Me.imageList32.ImageSize = New System.Drawing.Size(16, 16)
        Me.imageList32.TransparentColor = System.Drawing.Color.Magenta
        Me.openFileDialog.DefaultExt = "txt"
        Me.openFileDialog.FileName = "*.txt"
        Me.openFileDialog.Filter = "Memo files|*.txt|All files|*.*"
        Me.openFileDialog.Multiselect = True
        Me.saveFileDialog.DefaultExt = "txt"
        Me.saveFileDialog.Filter = "Memo files|*.txt|All files|*.*"
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8F, 16F)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(783, 557)
        Me.CloseBox = False
        Me.Controls.Add(Me.kryptonPanel1)
        Me.Controls.Add(Me.kryptonRibbon)
        Me.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.MinimumSize = New System.Drawing.Size(646, 499)
        Me.Name = "MemoEditorForm"
        Me.Text = "Memo Editor"
        CType(Me.kryptonRibbon, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.kryptonPanel1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.kryptonPanel1.ResumeLayout(False)
        CType(Me.kryptonWorkspace, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()
    End Sub

    Friend WithEvents kryptonRibbon As Krypton.Ribbon.KryptonRibbon
    Friend WithEvents kryptonPanel1 As Krypton.Toolkit.KryptonPanel
    Friend WithEvents kryptonWorkspace As Krypton.Workspace.KryptonWorkspace
    Friend WithEvents ribbonTabMemo As Krypton.Ribbon.KryptonRibbonTab
    Friend WithEvents kryptonRibbonGroup1 As Krypton.Ribbon.KryptonRibbonGroup
    Friend WithEvents kryptonRibbonGroupTriple1 As Krypton.Ribbon.KryptonRibbonGroupTriple
    Friend WithEvents buttonNewMemo As Krypton.Ribbon.KryptonRibbonGroupButton
    Friend WithEvents buttonOpenMemo As Krypton.Ribbon.KryptonRibbonGroupButton
    Friend WithEvents kryptonRibbonGroupSeparator1 As Krypton.Ribbon.KryptonRibbonGroupSeparator
    Friend WithEvents kryptonRibbonGroupTriple3 As Krypton.Ribbon.KryptonRibbonGroupTriple
    Friend WithEvents buttonSaveMemo As Krypton.Ribbon.KryptonRibbonGroupButton
    Friend WithEvents buttonSaveAsMemo As Krypton.Ribbon.KryptonRibbonGroupButton
    Friend WithEvents buttonSaveAllMemo As Krypton.Ribbon.KryptonRibbonGroupButton
    Friend WithEvents kryptonRibbonGroupTriple4 As Krypton.Ribbon.KryptonRibbonGroupTriple
    Friend WithEvents buttonCloseMemo As Krypton.Ribbon.KryptonRibbonGroupButton
    Friend WithEvents buttonCloseAllMemo As Krypton.Ribbon.KryptonRibbonGroupButton
    Friend WithEvents kryptonRibbonGroupSeparator2 As Krypton.Ribbon.KryptonRibbonGroupSeparator
    Friend WithEvents imageList32 As System.Windows.Forms.ImageList
    Friend WithEvents openFileDialog As System.Windows.Forms.OpenFileDialog
    Friend WithEvents saveFileDialog As System.Windows.Forms.SaveFileDialog
    Friend WithEvents kryptonRibbonGroup2 As Krypton.Ribbon.KryptonRibbonGroup
    Friend WithEvents kryptonRibbonGroupTriple2 As Krypton.Ribbon.KryptonRibbonGroupTriple
    Friend WithEvents buttonSingleGroupArrange As Krypton.Ribbon.KryptonRibbonGroupButton
    Friend WithEvents kryptonRibbonGroupTriple5 As Krypton.Ribbon.KryptonRibbonGroupTriple
    Friend WithEvents buttonGridArrange As Krypton.Ribbon.KryptonRibbonGroupButton
    Friend WithEvents buttonVerticalArrange As Krypton.Ribbon.KryptonRibbonGroupButton
    Friend WithEvents buttonHorizontalArrange As Krypton.Ribbon.KryptonRibbonGroupButton
    Friend WithEvents kryptonRibbonGroup3 As Krypton.Ribbon.KryptonRibbonGroup
    Friend WithEvents kryptonRibbonGroupTriple6 As Krypton.Ribbon.KryptonRibbonGroupTriple
    Friend WithEvents buttonReadMe As Krypton.Ribbon.KryptonRibbonGroupButton
    Friend WithEvents buttonShortcuts As Krypton.Ribbon.KryptonRibbonGroupButton
    Friend WithEvents appButtonNewMemo As Krypton.Toolkit.KryptonContextMenuItem
    Friend WithEvents appButtonOpenMemo As Krypton.Toolkit.KryptonContextMenuItem
    Friend WithEvents appButtonSep1 As Krypton.Toolkit.KryptonContextMenuSeparator
    Friend WithEvents appButtonSaveMemo As Krypton.Toolkit.KryptonContextMenuItem
    Friend WithEvents appButtonSaveAsMemo As Krypton.Toolkit.KryptonContextMenuItem
    Friend WithEvents appButtonSaveAllMemo As Krypton.Toolkit.KryptonContextMenuItem
    Friend WithEvents appButtonSep2 As Krypton.Toolkit.KryptonContextMenuSeparator
    Friend WithEvents appButtonCloseMemo As Krypton.Toolkit.KryptonContextMenuItem
    Friend WithEvents appButtonCloseAllMemo As Krypton.Toolkit.KryptonContextMenuItem
    Friend WithEvents buttonSpecExit As Krypton.Ribbon.ButtonSpecAppMenu
    Friend WithEvents ribbonTabAppearance As Krypton.Ribbon.KryptonRibbonTab
    Friend WithEvents kryptonRibbonGroup4 As Krypton.Ribbon.KryptonRibbonGroup
    Friend WithEvents kryptonRibbonGroupTriple7 As Krypton.Ribbon.KryptonRibbonGroupTriple
    Friend WithEvents button2007Blue As Krypton.Ribbon.KryptonRibbonGroupButton
    Friend WithEvents button2007Silver As Krypton.Ribbon.KryptonRibbonGroupButton
    Friend WithEvents button2007Black As Krypton.Ribbon.KryptonRibbonGroupButton
    Friend WithEvents kryptonRibbonGroupTriple8 As Krypton.Ribbon.KryptonRibbonGroupTriple
    Friend WithEvents buttonSparkleBlue As Krypton.Ribbon.KryptonRibbonGroupButton
    Friend WithEvents buttonSparkleOrange As Krypton.Ribbon.KryptonRibbonGroupButton
    Friend WithEvents buttonSparklePurple As Krypton.Ribbon.KryptonRibbonGroupButton
    Friend WithEvents kryptonRibbonGroupTriple9 As Krypton.Ribbon.KryptonRibbonGroupTriple
    Friend WithEvents buttonSystem As Krypton.Ribbon.KryptonRibbonGroupButton
    Friend WithEvents button2003 As Krypton.Ribbon.KryptonRibbonGroupButton
    Friend WithEvents kryptonManager As Krypton.Toolkit.KryptonManager
    Friend WithEvents kryptonRibbonGroup5 As Krypton.Ribbon.KryptonRibbonGroup
    Friend WithEvents kryptonRibbonGroupTriple10 As Krypton.Ribbon.KryptonRibbonGroupTriple
    Friend WithEvents buttonTabs As Krypton.Ribbon.KryptonRibbonGroupButton
    Friend WithEvents buttonRibbonTabs As Krypton.Ribbon.KryptonRibbonGroupButton
    Friend WithEvents buttonButtons As Krypton.Ribbon.KryptonRibbonGroupButton
    Friend WithEvents kryptonRibbonGroupTriple11 As Krypton.Ribbon.KryptonRibbonGroupTriple
    Friend WithEvents buttonHeader As Krypton.Ribbon.KryptonRibbonGroupButton
    Friend WithEvents buttonHeaderButtons As Krypton.Ribbon.KryptonRibbonGroupButton
    Friend WithEvents buttonStack As Krypton.Ribbon.KryptonRibbonGroupButton
    Friend WithEvents buttonPersistence As Krypton.Ribbon.KryptonRibbonGroupButton
    Friend WithEvents kryptonRibbonGroupTriple12 As Krypton.Ribbon.KryptonRibbonGroupTriple
    Friend WithEvents button2010Blue As Krypton.Ribbon.KryptonRibbonGroupButton
    Friend WithEvents button2010Silver As Krypton.Ribbon.KryptonRibbonGroupButton
    Friend WithEvents button2010Black As Krypton.Ribbon.KryptonRibbonGroupButton
End Class
