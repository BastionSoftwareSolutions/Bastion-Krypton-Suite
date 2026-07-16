' VB.NET twin of Source\Krypton Docking Examples\Standard Docking\Form1.Designer.cs (Bastion Phase 4c).
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
        Me.kryptonRibbon = New Krypton.Ribbon.KryptonRibbon()
        Me.ribbonAppButtonExit = New Krypton.Toolkit.KryptonContextMenuItem()
        Me.kryptonRibbonTab1 = New Krypton.Ribbon.KryptonRibbonTab()
        Me.groupDocked = New Krypton.Ribbon.KryptonRibbonGroup()
        Me.kryptonRibbonGroupTriple3 = New Krypton.Ribbon.KryptonRibbonGroupTriple()
        Me.buttonLeftDockedSingle = New Krypton.Ribbon.KryptonRibbonGroupButton()
        Me.buttonLeftDockedTabbed = New Krypton.Ribbon.KryptonRibbonGroupButton()
        Me.buttonLeftDockedStack = New Krypton.Ribbon.KryptonRibbonGroupButton()
        Me.kryptonRibbonGroupTriple4 = New Krypton.Ribbon.KryptonRibbonGroupTriple()
        Me.buttonRightDockedSingle = New Krypton.Ribbon.KryptonRibbonGroupButton()
        Me.buttonTopDockedTabbed = New Krypton.Ribbon.KryptonRibbonGroupButton()
        Me.buttonBottomDockedStack = New Krypton.Ribbon.KryptonRibbonGroupButton()
        Me.groupAutoHidden = New Krypton.Ribbon.KryptonRibbonGroup()
        Me.kryptonRibbonGroupTriple5 = New Krypton.Ribbon.KryptonRibbonGroupTriple()
        Me.buttonLeftAutoHidden = New Krypton.Ribbon.KryptonRibbonGroupButton()
        Me.buttonRightAutoHidden = New Krypton.Ribbon.KryptonRibbonGroupButton()
        Me.buttonBottomAutoHidden = New Krypton.Ribbon.KryptonRibbonGroupButton()
        Me.groupFloating = New Krypton.Ribbon.KryptonRibbonGroup()
        Me.kryptonRibbonGroupTriple1 = New Krypton.Ribbon.KryptonRibbonGroupTriple()
        Me.buttonFloatingSingle = New Krypton.Ribbon.KryptonRibbonGroupButton()
        Me.buttonFloatingTabbed = New Krypton.Ribbon.KryptonRibbonGroupButton()
        Me.buttonFloatingComplex = New Krypton.Ribbon.KryptonRibbonGroupButton()
        Me.groupDocument = New Krypton.Ribbon.KryptonRibbonGroup()
        Me.kryptonRibbonGroupTriple2 = New Krypton.Ribbon.KryptonRibbonGroupTriple()
        Me.buttonDocumentSingle = New Krypton.Ribbon.KryptonRibbonGroupButton()
        Me.buttonDocumentTabbed = New Krypton.Ribbon.KryptonRibbonGroupButton()
        Me.kryptonRibbonGroup1 = New Krypton.Ribbon.KryptonRibbonGroup()
        Me.kryptonRibbonGroupTriple6 = New Krypton.Ribbon.KryptonRibbonGroupTriple()
        Me.buttonDeleteAll = New Krypton.Ribbon.KryptonRibbonGroupButton()
        Me.kryptonRibbonGroupTriple7 = New Krypton.Ribbon.KryptonRibbonGroupTriple()
        Me.buttonDeleteDocked = New Krypton.Ribbon.KryptonRibbonGroupButton()
        Me.buttonDeleteAutoHidden = New Krypton.Ribbon.KryptonRibbonGroupButton()
        Me.buttonDeleteFloating = New Krypton.Ribbon.KryptonRibbonGroupButton()
        Me.kryptonRibbonGroup3 = New Krypton.Ribbon.KryptonRibbonGroup()
        Me.kryptonRibbonGroupTriple11 = New Krypton.Ribbon.KryptonRibbonGroupTriple()
        Me.buttonHideAll = New Krypton.Ribbon.KryptonRibbonGroupButton()
        Me.buttonShowAll = New Krypton.Ribbon.KryptonRibbonGroupButton()
        Me.kryptonRibbonGroupTriple13 = New Krypton.Ribbon.KryptonRibbonGroupTriple()
        Me.btnHideProps3 = New Krypton.Ribbon.KryptonRibbonGroupButton()
        Me.btnShowProps3 = New Krypton.Ribbon.KryptonRibbonGroupButton()
        Me.kryptonRibbonTab2 = New Krypton.Ribbon.KryptonRibbonTab()
        Me.kryptonRibbonGroup2 = New Krypton.Ribbon.KryptonRibbonGroup()
        Me.kryptonRibbonGroupTriple12 = New Krypton.Ribbon.KryptonRibbonGroupTriple()
        Me.button2010Blue = New Krypton.Ribbon.KryptonRibbonGroupButton()
        Me.button2010Silver = New Krypton.Ribbon.KryptonRibbonGroupButton()
        Me.button2010Black = New Krypton.Ribbon.KryptonRibbonGroupButton()
        Me.kryptonRibbonGroupSeparator1 = New Krypton.Ribbon.KryptonRibbonGroupSeparator()
        Me.kryptonRibbonGroupTriple8 = New Krypton.Ribbon.KryptonRibbonGroupTriple()
        Me.button2007Blue = New Krypton.Ribbon.KryptonRibbonGroupButton()
        Me.button2007Silver = New Krypton.Ribbon.KryptonRibbonGroupButton()
        Me.button2007Black = New Krypton.Ribbon.KryptonRibbonGroupButton()
        Me.kryptonRibbonGroupSeparator2 = New Krypton.Ribbon.KryptonRibbonGroupSeparator()
        Me.kryptonRibbonGroupTriple9 = New Krypton.Ribbon.KryptonRibbonGroupTriple()
        Me.buttonSparkleBlue = New Krypton.Ribbon.KryptonRibbonGroupButton()
        Me.buttonSparkleOrange = New Krypton.Ribbon.KryptonRibbonGroupButton()
        Me.buttonSparklePurple = New Krypton.Ribbon.KryptonRibbonGroupButton()
        Me.kryptonRibbonGroupSeparator3 = New Krypton.Ribbon.KryptonRibbonGroupSeparator()
        Me.kryptonRibbonGroupTriple10 = New Krypton.Ribbon.KryptonRibbonGroupTriple()
        Me.buttonSystem = New Krypton.Ribbon.KryptonRibbonGroupButton()
        Me.kryptonPanel = New Krypton.Toolkit.KryptonPanel()
        Me.kryptonDockableWorkspace = New Krypton.Docking.KryptonDockableWorkspace()
        Me.imageListSmall = New System.Windows.Forms.ImageList(Me.components)
        Me.kryptonManager = New Krypton.Toolkit.KryptonManager(Me.components)
        Me.kryptonDockingManager = New Krypton.Docking.KryptonDockingManager()
        CType(Me.kryptonRibbon, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.kryptonPanel, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.kryptonPanel.SuspendLayout()
        CType(Me.kryptonDockableWorkspace, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        Me.kryptonRibbon.InDesignHelperMode = True
        Me.kryptonRibbon.Name = "kryptonRibbon"
        Me.kryptonRibbon.RibbonFileAppButton.AppButtonMenuItems.AddRange(New Krypton.Toolkit.KryptonContextMenuItemBase() { Me.ribbonAppButtonExit})
        Me.kryptonRibbon.RibbonFileAppButton.AppButtonShowRecentDocs = False
        Me.kryptonRibbon.RibbonFileAppButton.AppButtonToolTipStyle = Krypton.Toolkit.LabelStyle.SuperTip
        Me.kryptonRibbon.RibbonTabs.AddRange(New Krypton.Ribbon.KryptonRibbonTab() { Me.kryptonRibbonTab1, Me.kryptonRibbonTab2})
        Me.kryptonRibbon.SelectedTab = Me.kryptonRibbonTab1
        Me.kryptonRibbon.Size = New System.Drawing.Size(1023, 136)
        Me.kryptonRibbon.TabIndex = 0
        Me.ribbonAppButtonExit.Image = CType(resources.GetObject("ribbonAppButtonExit.Image"), System.Drawing.Image)
        Me.ribbonAppButtonExit.Text = "E&xit"
        Me.kryptonRibbonTab1.Groups.AddRange(New Krypton.Ribbon.KryptonRibbonGroup() { Me.groupDocked, Me.groupAutoHidden, Me.groupFloating, Me.groupDocument, Me.kryptonRibbonGroup1, Me.kryptonRibbonGroup3})
        Me.kryptonRibbonTab1.KeyTip = "P"
        Me.kryptonRibbonTab1.Text = "Pages"
        Me.groupDocked.DialogBoxLauncher = False
        Me.groupDocked.Image = CType(resources.GetObject("groupDocked.Image"), System.Drawing.Image)
        Me.groupDocked.Items.AddRange(New Krypton.Ribbon.KryptonRibbonGroupContainer() { Me.kryptonRibbonGroupTriple3, Me.kryptonRibbonGroupTriple4})
        Me.groupDocked.KeyTipGroup = "D"
        Me.groupDocked.TextLine1 = "Docked"
        Me.kryptonRibbonGroupTriple3.Items.AddRange(New Krypton.Ribbon.KryptonRibbonGroupItem() { Me.buttonLeftDockedSingle, Me.buttonLeftDockedTabbed, Me.buttonLeftDockedStack})
        Me.kryptonRibbonGroupTriple3.MaximumSize = Krypton.Ribbon.GroupItemSize.Medium
        Me.kryptonRibbonGroupTriple3.MinimumSize = Krypton.Ribbon.GroupItemSize.Medium
        Me.buttonLeftDockedSingle.ImageSmall = CType(resources.GetObject("buttonLeftDockedSingle.ImageSmall"), System.Drawing.Image)
        Me.buttonLeftDockedSingle.KeyTip = "DLS"
        Me.buttonLeftDockedSingle.TextLine1 = "Left Single"
        Me.buttonLeftDockedTabbed.ImageSmall = CType(resources.GetObject("buttonLeftDockedTabbed.ImageSmall"), System.Drawing.Image)
        Me.buttonLeftDockedTabbed.KeyTip = "DLT"
        Me.buttonLeftDockedTabbed.TextLine1 = "Left Tabbed"
        Me.buttonLeftDockedStack.ImageSmall = CType(resources.GetObject("buttonLeftDockedStack.ImageSmall"), System.Drawing.Image)
        Me.buttonLeftDockedStack.KeyTip = "DLA"
        Me.buttonLeftDockedStack.TextLine1 = "Left Stack"
        Me.kryptonRibbonGroupTriple4.Items.AddRange(New Krypton.Ribbon.KryptonRibbonGroupItem() { Me.buttonRightDockedSingle, Me.buttonTopDockedTabbed, Me.buttonBottomDockedStack})
        Me.kryptonRibbonGroupTriple4.MaximumSize = Krypton.Ribbon.GroupItemSize.Medium
        Me.kryptonRibbonGroupTriple4.MinimumSize = Krypton.Ribbon.GroupItemSize.Medium
        Me.buttonRightDockedSingle.ImageSmall = CType(resources.GetObject("buttonRightDockedSingle.ImageSmall"), System.Drawing.Image)
        Me.buttonRightDockedSingle.KeyTip = "DR"
        Me.buttonRightDockedSingle.TextLine1 = "Right Single"
        Me.buttonTopDockedTabbed.ImageSmall = CType(resources.GetObject("buttonTopDockedTabbed.ImageSmall"), System.Drawing.Image)
        Me.buttonTopDockedTabbed.KeyTip = "DT"
        Me.buttonTopDockedTabbed.TextLine1 = "Top Tabbed"
        Me.buttonBottomDockedStack.ImageSmall = CType(resources.GetObject("buttonBottomDockedStack.ImageSmall"), System.Drawing.Image)
        Me.buttonBottomDockedStack.KeyTip = "DB"
        Me.buttonBottomDockedStack.TextLine1 = "Bottom Stack"
        Me.groupAutoHidden.DialogBoxLauncher = False
        Me.groupAutoHidden.Image = CType(resources.GetObject("groupAutoHidden.Image"), System.Drawing.Image)
        Me.groupAutoHidden.Items.AddRange(New Krypton.Ribbon.KryptonRibbonGroupContainer() { Me.kryptonRibbonGroupTriple5})
        Me.groupAutoHidden.KeyTipGroup = "A"
        Me.groupAutoHidden.TextLine1 = "AutoHidden"
        Me.kryptonRibbonGroupTriple5.Items.AddRange(New Krypton.Ribbon.KryptonRibbonGroupItem() { Me.buttonLeftAutoHidden, Me.buttonRightAutoHidden, Me.buttonBottomAutoHidden})
        Me.kryptonRibbonGroupTriple5.MaximumSize = Krypton.Ribbon.GroupItemSize.Medium
        Me.kryptonRibbonGroupTriple5.MinimumSize = Krypton.Ribbon.GroupItemSize.Medium
        Me.buttonLeftAutoHidden.ImageSmall = CType(resources.GetObject("buttonLeftAutoHidden.ImageSmall"), System.Drawing.Image)
        Me.buttonLeftAutoHidden.KeyTip = "AL"
        Me.buttonLeftAutoHidden.TextLine1 = "Left Group"
        Me.buttonRightAutoHidden.ImageSmall = CType(resources.GetObject("buttonRightAutoHidden.ImageSmall"), System.Drawing.Image)
        Me.buttonRightAutoHidden.KeyTip = "AR"
        Me.buttonRightAutoHidden.TextLine1 = "Right Group"
        Me.buttonBottomAutoHidden.ImageSmall = CType(resources.GetObject("buttonBottomAutoHidden.ImageSmall"), System.Drawing.Image)
        Me.buttonBottomAutoHidden.KeyTip = "AB"
        Me.buttonBottomAutoHidden.TextLine1 = "Bottom Group"
        Me.groupFloating.DialogBoxLauncher = False
        Me.groupFloating.Image = CType(resources.GetObject("groupFloating.Image"), System.Drawing.Image)
        Me.groupFloating.Items.AddRange(New Krypton.Ribbon.KryptonRibbonGroupContainer() { Me.kryptonRibbonGroupTriple1})
        Me.groupFloating.KeyTipGroup = "F"
        Me.groupFloating.TextLine1 = "Floating"
        Me.kryptonRibbonGroupTriple1.Items.AddRange(New Krypton.Ribbon.KryptonRibbonGroupItem() { Me.buttonFloatingSingle, Me.buttonFloatingTabbed, Me.buttonFloatingComplex})
        Me.kryptonRibbonGroupTriple1.MaximumSize = Krypton.Ribbon.GroupItemSize.Medium
        Me.kryptonRibbonGroupTriple1.MinimumSize = Krypton.Ribbon.GroupItemSize.Medium
        Me.buttonFloatingSingle.ImageSmall = CType(resources.GetObject("buttonFloatingSingle.ImageSmall"), System.Drawing.Image)
        Me.buttonFloatingSingle.KeyTip = "FS"
        Me.buttonFloatingSingle.TextLine1 = "Single"
        Me.buttonFloatingTabbed.ImageSmall = CType(resources.GetObject("buttonFloatingTabbed.ImageSmall"), System.Drawing.Image)
        Me.buttonFloatingTabbed.KeyTip = "FT"
        Me.buttonFloatingTabbed.TextLine1 = "Tabbed"
        Me.buttonFloatingComplex.ImageSmall = CType(resources.GetObject("buttonFloatingComplex.ImageSmall"), System.Drawing.Image)
        Me.buttonFloatingComplex.KeyTip = "FC"
        Me.buttonFloatingComplex.TextLine1 = "Complex"
        Me.groupDocument.DialogBoxLauncher = False
        Me.groupDocument.Image = CType(resources.GetObject("groupDocument.Image"), System.Drawing.Image)
        Me.groupDocument.Items.AddRange(New Krypton.Ribbon.KryptonRibbonGroupContainer() { Me.kryptonRibbonGroupTriple2})
        Me.groupDocument.KeyTipGroup = "T"
        Me.groupDocument.TextLine1 = "Document"
        Me.kryptonRibbonGroupTriple2.Items.AddRange(New Krypton.Ribbon.KryptonRibbonGroupItem() { Me.buttonDocumentSingle, Me.buttonDocumentTabbed})
        Me.kryptonRibbonGroupTriple2.MaximumSize = Krypton.Ribbon.GroupItemSize.Medium
        Me.kryptonRibbonGroupTriple2.MinimumSize = Krypton.Ribbon.GroupItemSize.Medium
        Me.buttonDocumentSingle.ImageSmall = CType(resources.GetObject("buttonDocumentSingle.ImageSmall"), System.Drawing.Image)
        Me.buttonDocumentSingle.KeyTip = "TS"
        Me.buttonDocumentSingle.TextLine1 = "Single"
        Me.buttonDocumentTabbed.ImageSmall = CType(resources.GetObject("buttonDocumentTabbed.ImageSmall"), System.Drawing.Image)
        Me.buttonDocumentTabbed.KeyTip = "TT"
        Me.buttonDocumentTabbed.TextLine1 = "Tabbed"
        Me.kryptonRibbonGroup1.DialogBoxLauncher = False
        Me.kryptonRibbonGroup1.Image = CType(resources.GetObject("kryptonRibbonGroup1.Image"), System.Drawing.Image)
        Me.kryptonRibbonGroup1.Items.AddRange(New Krypton.Ribbon.KryptonRibbonGroupContainer() { Me.kryptonRibbonGroupTriple6, Me.kryptonRibbonGroupTriple7})
        Me.kryptonRibbonGroup1.KeyTipGroup = "C"
        Me.kryptonRibbonGroup1.TextLine1 = "Delete"
        Me.kryptonRibbonGroupTriple6.Items.AddRange(New Krypton.Ribbon.KryptonRibbonGroupItem() { Me.buttonDeleteAll})
        Me.kryptonRibbonGroupTriple6.MinimumSize = Krypton.Ribbon.GroupItemSize.Large
        Me.buttonDeleteAll.ImageLarge = CType(resources.GetObject("buttonDeleteAll.ImageLarge"), System.Drawing.Image)
        Me.buttonDeleteAll.KeyTip = "CA"
        Me.buttonDeleteAll.TextLine1 = "All"
        Me.kryptonRibbonGroupTriple7.Items.AddRange(New Krypton.Ribbon.KryptonRibbonGroupItem() { Me.buttonDeleteDocked, Me.buttonDeleteAutoHidden, Me.buttonDeleteFloating})
        Me.kryptonRibbonGroupTriple7.MaximumSize = Krypton.Ribbon.GroupItemSize.Medium
        Me.kryptonRibbonGroupTriple7.MinimumSize = Krypton.Ribbon.GroupItemSize.Medium
        Me.buttonDeleteDocked.ImageSmall = CType(resources.GetObject("buttonDeleteDocked.ImageSmall"), System.Drawing.Image)
        Me.buttonDeleteDocked.KeyTip = "CD"
        Me.buttonDeleteDocked.TextLine1 = "Docked"
        Me.buttonDeleteAutoHidden.ImageSmall = CType(resources.GetObject("buttonDeleteAutoHidden.ImageSmall"), System.Drawing.Image)
        Me.buttonDeleteAutoHidden.KeyTip = "CH"
        Me.buttonDeleteAutoHidden.TextLine1 = "AutoHidden"
        Me.buttonDeleteFloating.ImageSmall = CType(resources.GetObject("buttonDeleteFloating.ImageSmall"), System.Drawing.Image)
        Me.buttonDeleteFloating.KeyTip = "CF"
        Me.buttonDeleteFloating.TextLine1 = "Floating"
        Me.kryptonRibbonGroup3.DialogBoxLauncher = False
        Me.kryptonRibbonGroup3.Image = CType(resources.GetObject("kryptonRibbonGroup3.Image"), System.Drawing.Image)
        Me.kryptonRibbonGroup3.Items.AddRange(New Krypton.Ribbon.KryptonRibbonGroupContainer() { Me.kryptonRibbonGroupTriple11, Me.kryptonRibbonGroupTriple13})
        Me.kryptonRibbonGroup3.KeyTipGroup = "V"
        Me.kryptonRibbonGroup3.TextLine1 = "Visibility"
        Me.kryptonRibbonGroupTriple11.Items.AddRange(New Krypton.Ribbon.KryptonRibbonGroupItem() { Me.buttonHideAll, Me.buttonShowAll})
        Me.kryptonRibbonGroupTriple11.MinimumSize = Krypton.Ribbon.GroupItemSize.Large
        Me.buttonHideAll.ImageLarge = CType(resources.GetObject("buttonHideAll.ImageLarge"), System.Drawing.Image)
        Me.buttonHideAll.KeyTip = "VH"
        Me.buttonHideAll.TextLine1 = "Hide"
        Me.buttonHideAll.TextLine2 = "All"
        Me.buttonShowAll.ImageLarge = CType(resources.GetObject("buttonShowAll.ImageLarge"), System.Drawing.Image)
        Me.buttonShowAll.KeyTip = "VS"
        Me.buttonShowAll.TextLine1 = "Show"
        Me.buttonShowAll.TextLine2 = "All"
        Me.kryptonRibbonGroupTriple13.Items.AddRange(New Krypton.Ribbon.KryptonRibbonGroupItem() { Me.btnHideProps3, Me.btnShowProps3})
        Me.btnHideProps3.TextLine1 = "Hide"
        Me.btnHideProps3.TextLine2 = "Properties 3"
        Me.btnShowProps3.TextLine1 = "Show"
        Me.btnShowProps3.TextLine2 = "Properties 3"
        Me.kryptonRibbonTab2.Groups.AddRange(New Krypton.Ribbon.KryptonRibbonGroup() { Me.kryptonRibbonGroup2})
        Me.kryptonRibbonTab2.KeyTip = "L"
        Me.kryptonRibbonTab2.Text = "Palette"
        Me.kryptonRibbonGroup2.Image = CType(resources.GetObject("kryptonRibbonGroup2.Image"), System.Drawing.Image)
        Me.kryptonRibbonGroup2.Items.AddRange(New Krypton.Ribbon.KryptonRibbonGroupContainer() { Me.kryptonRibbonGroupTriple12, Me.kryptonRibbonGroupSeparator1, Me.kryptonRibbonGroupTriple8, Me.kryptonRibbonGroupSeparator2, Me.kryptonRibbonGroupTriple9, Me.kryptonRibbonGroupSeparator3, Me.kryptonRibbonGroupTriple10})
        Me.kryptonRibbonGroup2.TextLine1 = "Palette Setting"
        Me.kryptonRibbonGroupTriple12.Items.AddRange(New Krypton.Ribbon.KryptonRibbonGroupItem() { Me.button2010Blue, Me.button2010Silver, Me.button2010Black})
        Me.kryptonRibbonGroupTriple12.MinimumSize = Krypton.Ribbon.GroupItemSize.Large
        Me.button2010Blue.ButtonType = Krypton.Ribbon.GroupButtonType.Check
        Me.button2010Blue.Checked = True
        Me.button2010Blue.ImageLarge = CType(resources.GetObject("button2010Blue.ImageLarge"), System.Drawing.Image)
        Me.button2010Blue.TextLine1 = "2010"
        Me.button2010Blue.TextLine2 = "Blue"
        Me.button2010Silver.ButtonType = Krypton.Ribbon.GroupButtonType.Check
        Me.button2010Silver.ImageLarge = CType(resources.GetObject("button2010Silver.ImageLarge"), System.Drawing.Image)
        Me.button2010Silver.TextLine1 = "2010"
        Me.button2010Silver.TextLine2 = "Silver"
        Me.button2010Black.ButtonType = Krypton.Ribbon.GroupButtonType.Check
        Me.button2010Black.ImageLarge = CType(resources.GetObject("button2010Black.ImageLarge"), System.Drawing.Image)
        Me.button2010Black.TextLine1 = "2010"
        Me.button2010Black.TextLine2 = "Black"
        Me.kryptonRibbonGroupTriple8.Items.AddRange(New Krypton.Ribbon.KryptonRibbonGroupItem() { Me.button2007Blue, Me.button2007Silver, Me.button2007Black})
        Me.kryptonRibbonGroupTriple8.MinimumSize = Krypton.Ribbon.GroupItemSize.Large
        Me.button2007Blue.ButtonType = Krypton.Ribbon.GroupButtonType.Check
        Me.button2007Blue.ImageLarge = CType(resources.GetObject("button2007Blue.ImageLarge"), System.Drawing.Image)
        Me.button2007Blue.KeyTip = "2B"
        Me.button2007Blue.TextLine1 = "2007"
        Me.button2007Blue.TextLine2 = "Blue"
        Me.button2007Silver.ButtonType = Krypton.Ribbon.GroupButtonType.Check
        Me.button2007Silver.ImageLarge = CType(resources.GetObject("button2007Silver.ImageLarge"), System.Drawing.Image)
        Me.button2007Silver.KeyTip = "2S"
        Me.button2007Silver.TextLine1 = "2007"
        Me.button2007Silver.TextLine2 = "Silver"
        Me.button2007Black.ButtonType = Krypton.Ribbon.GroupButtonType.Check
        Me.button2007Black.ImageLarge = CType(resources.GetObject("button2007Black.ImageLarge"), System.Drawing.Image)
        Me.button2007Black.KeyTip = "SL"
        Me.button2007Black.TextLine1 = "2007"
        Me.button2007Black.TextLine2 = "Black"
        Me.kryptonRibbonGroupTriple9.Items.AddRange(New Krypton.Ribbon.KryptonRibbonGroupItem() { Me.buttonSparkleBlue, Me.buttonSparkleOrange, Me.buttonSparklePurple})
        Me.kryptonRibbonGroupTriple9.MinimumSize = Krypton.Ribbon.GroupItemSize.Large
        Me.buttonSparkleBlue.ButtonType = Krypton.Ribbon.GroupButtonType.Check
        Me.buttonSparkleBlue.ImageLarge = CType(resources.GetObject("buttonSparkleBlue.ImageLarge"), System.Drawing.Image)
        Me.buttonSparkleBlue.KeyTip = "SB"
        Me.buttonSparkleBlue.TextLine1 = "Sparkle"
        Me.buttonSparkleBlue.TextLine2 = "Blue"
        Me.buttonSparkleOrange.ButtonType = Krypton.Ribbon.GroupButtonType.Check
        Me.buttonSparkleOrange.ImageLarge = CType(resources.GetObject("buttonSparkleOrange.ImageLarge"), System.Drawing.Image)
        Me.buttonSparkleOrange.KeyTip = "SO"
        Me.buttonSparkleOrange.TextLine1 = "Sparkle"
        Me.buttonSparkleOrange.TextLine2 = "Orange"
        Me.buttonSparklePurple.ButtonType = Krypton.Ribbon.GroupButtonType.Check
        Me.buttonSparklePurple.ImageLarge = CType(resources.GetObject("buttonSparklePurple.ImageLarge"), System.Drawing.Image)
        Me.buttonSparklePurple.KeyTip = "SP"
        Me.buttonSparklePurple.TextLine1 = "Sparkle"
        Me.buttonSparklePurple.TextLine2 = "Purple"
        Me.kryptonRibbonGroupTriple10.Items.AddRange(New Krypton.Ribbon.KryptonRibbonGroupItem() { Me.buttonSystem})
        Me.kryptonRibbonGroupTriple10.MinimumSize = Krypton.Ribbon.GroupItemSize.Large
        Me.buttonSystem.ButtonType = Krypton.Ribbon.GroupButtonType.Check
        Me.buttonSystem.ImageLarge = CType(resources.GetObject("buttonSystem.ImageLarge"), System.Drawing.Image)
        Me.buttonSystem.KeyTip = "SY"
        Me.buttonSystem.TextLine1 = "System"
        Me.kryptonPanel.Controls.Add(Me.kryptonDockableWorkspace)
        Me.kryptonPanel.Dock = System.Windows.Forms.DockStyle.Fill
        Me.kryptonPanel.Location = New System.Drawing.Point(0, 136)
        Me.kryptonPanel.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.kryptonPanel.Name = "kryptonPanel"
        Me.kryptonPanel.Padding = New System.Windows.Forms.Padding(7, 6, 7, 6)
        Me.kryptonPanel.Size = New System.Drawing.Size(1023, 665)
        Me.kryptonPanel.TabIndex = 1
        Me.kryptonDockableWorkspace.ActivePage = Nothing
        Me.kryptonDockableWorkspace.AutoHiddenHost = False
        Me.kryptonDockableWorkspace.CompactFlags = CType(((Krypton.Workspace.CompactFlags.RemoveEmptyCells Or Krypton.Workspace.CompactFlags.RemoveEmptySequences) Or Krypton.Workspace.CompactFlags.PromoteLeafs), Krypton.Workspace.CompactFlags)
        Me.kryptonDockableWorkspace.ContainerBackStyle = Krypton.Toolkit.PaletteBackStyle.PanelClient
        Me.kryptonDockableWorkspace.Dock = System.Windows.Forms.DockStyle.Fill
        Me.kryptonDockableWorkspace.Location = New System.Drawing.Point(7, 6)
        Me.kryptonDockableWorkspace.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.kryptonDockableWorkspace.Name = "kryptonDockableWorkspace"
        Me.kryptonDockableWorkspace.Root.UniqueName = "D51970B3EA2C496AD51970B3EA2C496A"
        Me.kryptonDockableWorkspace.Root.WorkspaceControl = Me.kryptonDockableWorkspace
        Me.kryptonDockableWorkspace.SeparatorStyle = Krypton.Toolkit.SeparatorStyle.LowProfile
        Me.kryptonDockableWorkspace.ShowMaximizeButton = False
        Me.kryptonDockableWorkspace.Size = New System.Drawing.Size(1009, 653)
        Me.kryptonDockableWorkspace.SplitterWidth = 5
        Me.kryptonDockableWorkspace.TabIndex = 0
        Me.kryptonDockableWorkspace.TabStop = True
        Me.imageListSmall.ImageStream = CType(resources.GetObject("imageListSmall.ImageStream"), System.Windows.Forms.ImageListStreamer)
        Me.imageListSmall.TransparentColor = System.Drawing.Color.Transparent
        Me.imageListSmall.Images.SetKeyName(0, "document_plain.png")
        Me.imageListSmall.Images.SetKeyName(1, "preferences.png")
        Me.imageListSmall.Images.SetKeyName(2, "information2.png")
        Me.kryptonManager.GlobalPaletteMode = Krypton.Toolkit.PaletteMode.Office2010Blue
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8F, 16F)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(1023, 801)
        Me.CloseBox = False
        Me.Controls.Add(Me.kryptonPanel)
        Me.Controls.Add(Me.kryptonRibbon)
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.Name = "Form1"
        Me.Text = "Standard Docking 2020"
        CType(Me.kryptonRibbon, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.kryptonPanel, System.ComponentModel.ISupportInitialize).EndInit()
        Me.kryptonPanel.ResumeLayout(False)
        CType(Me.kryptonDockableWorkspace, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()
    End Sub

    Friend WithEvents imageListSmall As System.Windows.Forms.ImageList
    Friend WithEvents kryptonPanel As Krypton.Toolkit.KryptonPanel
    Friend WithEvents kryptonManager As Krypton.Toolkit.KryptonManager
    Friend WithEvents ribbonAppButtonExit As Krypton.Toolkit.KryptonContextMenuItem
    Friend WithEvents kryptonDockingManager As Krypton.Docking.KryptonDockingManager
    Friend WithEvents kryptonDockableWorkspace As Krypton.Docking.KryptonDockableWorkspace
    Friend WithEvents kryptonRibbon As Krypton.Ribbon.KryptonRibbon
    Friend WithEvents kryptonRibbonTab1 As Krypton.Ribbon.KryptonRibbonTab
    Friend WithEvents groupFloating As Krypton.Ribbon.KryptonRibbonGroup
    Friend WithEvents kryptonRibbonGroupTriple1 As Krypton.Ribbon.KryptonRibbonGroupTriple
    Friend WithEvents buttonFloatingSingle As Krypton.Ribbon.KryptonRibbonGroupButton
    Friend WithEvents buttonFloatingTabbed As Krypton.Ribbon.KryptonRibbonGroupButton
    Friend WithEvents buttonFloatingComplex As Krypton.Ribbon.KryptonRibbonGroupButton
    Friend WithEvents groupDocument As Krypton.Ribbon.KryptonRibbonGroup
    Friend WithEvents kryptonRibbonGroupTriple2 As Krypton.Ribbon.KryptonRibbonGroupTriple
    Friend WithEvents buttonDocumentSingle As Krypton.Ribbon.KryptonRibbonGroupButton
    Friend WithEvents buttonDocumentTabbed As Krypton.Ribbon.KryptonRibbonGroupButton
    Friend WithEvents groupDocked As Krypton.Ribbon.KryptonRibbonGroup
    Friend WithEvents kryptonRibbonGroupTriple3 As Krypton.Ribbon.KryptonRibbonGroupTriple
    Friend WithEvents buttonLeftDockedSingle As Krypton.Ribbon.KryptonRibbonGroupButton
    Friend WithEvents buttonLeftDockedTabbed As Krypton.Ribbon.KryptonRibbonGroupButton
    Friend WithEvents buttonLeftDockedStack As Krypton.Ribbon.KryptonRibbonGroupButton
    Friend WithEvents kryptonRibbonGroupTriple4 As Krypton.Ribbon.KryptonRibbonGroupTriple
    Friend WithEvents buttonRightDockedSingle As Krypton.Ribbon.KryptonRibbonGroupButton
    Friend WithEvents buttonTopDockedTabbed As Krypton.Ribbon.KryptonRibbonGroupButton
    Friend WithEvents buttonBottomDockedStack As Krypton.Ribbon.KryptonRibbonGroupButton
    Friend WithEvents groupAutoHidden As Krypton.Ribbon.KryptonRibbonGroup
    Friend WithEvents kryptonRibbonGroupTriple5 As Krypton.Ribbon.KryptonRibbonGroupTriple
    Friend WithEvents buttonLeftAutoHidden As Krypton.Ribbon.KryptonRibbonGroupButton
    Friend WithEvents buttonRightAutoHidden As Krypton.Ribbon.KryptonRibbonGroupButton
    Friend WithEvents buttonBottomAutoHidden As Krypton.Ribbon.KryptonRibbonGroupButton
    Friend WithEvents kryptonRibbonGroup1 As Krypton.Ribbon.KryptonRibbonGroup
    Friend WithEvents kryptonRibbonGroupTriple6 As Krypton.Ribbon.KryptonRibbonGroupTriple
    Friend WithEvents buttonDeleteAll As Krypton.Ribbon.KryptonRibbonGroupButton
    Friend WithEvents kryptonRibbonGroupTriple7 As Krypton.Ribbon.KryptonRibbonGroupTriple
    Friend WithEvents buttonDeleteDocked As Krypton.Ribbon.KryptonRibbonGroupButton
    Friend WithEvents buttonDeleteAutoHidden As Krypton.Ribbon.KryptonRibbonGroupButton
    Friend WithEvents buttonDeleteFloating As Krypton.Ribbon.KryptonRibbonGroupButton
    Friend WithEvents kryptonRibbonTab2 As Krypton.Ribbon.KryptonRibbonTab
    Friend WithEvents kryptonRibbonGroup2 As Krypton.Ribbon.KryptonRibbonGroup
    Friend WithEvents kryptonRibbonGroupTriple8 As Krypton.Ribbon.KryptonRibbonGroupTriple
    Friend WithEvents button2007Blue As Krypton.Ribbon.KryptonRibbonGroupButton
    Friend WithEvents button2007Silver As Krypton.Ribbon.KryptonRibbonGroupButton
    Friend WithEvents button2007Black As Krypton.Ribbon.KryptonRibbonGroupButton
    Friend WithEvents kryptonRibbonGroupTriple9 As Krypton.Ribbon.KryptonRibbonGroupTriple
    Friend WithEvents buttonSparkleBlue As Krypton.Ribbon.KryptonRibbonGroupButton
    Friend WithEvents buttonSparkleOrange As Krypton.Ribbon.KryptonRibbonGroupButton
    Friend WithEvents buttonSparklePurple As Krypton.Ribbon.KryptonRibbonGroupButton
    Friend WithEvents kryptonRibbonGroupTriple10 As Krypton.Ribbon.KryptonRibbonGroupTriple
    Friend WithEvents buttonSystem As Krypton.Ribbon.KryptonRibbonGroupButton
    Friend WithEvents kryptonRibbonGroupSeparator1 As Krypton.Ribbon.KryptonRibbonGroupSeparator
    Friend WithEvents kryptonRibbonGroupSeparator2 As Krypton.Ribbon.KryptonRibbonGroupSeparator
    Friend WithEvents kryptonRibbonGroup3 As Krypton.Ribbon.KryptonRibbonGroup
    Friend WithEvents kryptonRibbonGroupTriple11 As Krypton.Ribbon.KryptonRibbonGroupTriple
    Friend WithEvents buttonHideAll As Krypton.Ribbon.KryptonRibbonGroupButton
    Friend WithEvents buttonShowAll As Krypton.Ribbon.KryptonRibbonGroupButton
    Friend WithEvents kryptonRibbonGroupTriple12 As Krypton.Ribbon.KryptonRibbonGroupTriple
    Friend WithEvents button2010Blue As Krypton.Ribbon.KryptonRibbonGroupButton
    Friend WithEvents button2010Silver As Krypton.Ribbon.KryptonRibbonGroupButton
    Friend WithEvents button2010Black As Krypton.Ribbon.KryptonRibbonGroupButton
    Friend WithEvents kryptonRibbonGroupSeparator3 As Krypton.Ribbon.KryptonRibbonGroupSeparator
    Friend WithEvents kryptonRibbonGroupTriple13 As Krypton.Ribbon.KryptonRibbonGroupTriple
    Friend WithEvents btnHideProps3 As Krypton.Ribbon.KryptonRibbonGroupButton
    Friend WithEvents btnShowProps3 As Krypton.Ribbon.KryptonRibbonGroupButton
End Class
