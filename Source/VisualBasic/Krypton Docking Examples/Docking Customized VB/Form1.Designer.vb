' VB.NET twin of Source\Krypton Docking Examples\Docking Customized\Form1.Designer.cs (Bastion Phase 4c).
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(Form1))
        Me.kryptonRibbon1 = New Krypton.Ribbon.KryptonRibbon()
        Me.kryptonRibbonTab1 = New Krypton.Ribbon.KryptonRibbonTab()
        Me.kryptonRibbonGroup2 = New Krypton.Ribbon.KryptonRibbonGroup()
        Me.kryptonRibbonGroupTriple5 = New Krypton.Ribbon.KryptonRibbonGroupTriple()
        Me.modeStackGroup = New Krypton.Ribbon.KryptonRibbonGroupButton()
        Me.modeStackHeaderGroup = New Krypton.Ribbon.KryptonRibbonGroupButton()
        Me.kryptonRibbonGroup3 = New Krypton.Ribbon.KryptonRibbonGroup()
        Me.kryptonRibbonGroupTriple3 = New Krypton.Ribbon.KryptonRibbonGroupTriple()
        Me.modeBarGroupOutside = New Krypton.Ribbon.KryptonRibbonGroupButton()
        Me.modeBarGroupInside = New Krypton.Ribbon.KryptonRibbonGroupButton()
        Me.modeTabGroup = New Krypton.Ribbon.KryptonRibbonGroupButton()
        Me.kryptonRibbonGroup5 = New Krypton.Ribbon.KryptonRibbonGroup()
        Me.kryptonRibbonGroupTriple4 = New Krypton.Ribbon.KryptonRibbonGroupTriple()
        Me.modeBarRibbonTabGroup = New Krypton.Ribbon.KryptonRibbonGroupButton()
        Me.kryptonRibbonGroup4 = New Krypton.Ribbon.KryptonRibbonGroup()
        Me.kryptonRibbonGroupTriple2 = New Krypton.Ribbon.KryptonRibbonGroupTriple()
        Me.modeHeaderBarGroup = New Krypton.Ribbon.KryptonRibbonGroupButton()
        Me.modeHeaderBarHeaderGroup = New Krypton.Ribbon.KryptonRibbonGroupButton()
        Me.kryptonRibbonGroup7 = New Krypton.Ribbon.KryptonRibbonGroup()
        Me.kryptonRibbonGroupTriple7 = New Krypton.Ribbon.KryptonRibbonGroupTriple()
        Me.modeHeaderGroupTab = New Krypton.Ribbon.KryptonRibbonGroupButton()
        Me.kryptonRibbonTab2 = New Krypton.Ribbon.KryptonRibbonTab()
        Me.kryptonRibbonGroup1 = New Krypton.Ribbon.KryptonRibbonGroup()
        Me.kryptonRibbonGroupTriple1 = New Krypton.Ribbon.KryptonRibbonGroupTriple()
        Me.colorsRandom = New Krypton.Ribbon.KryptonRibbonGroupButton()
        Me.colorsReset = New Krypton.Ribbon.KryptonRibbonGroupButton()
        Me.kryptonRibbonGroup6 = New Krypton.Ribbon.KryptonRibbonGroup()
        Me.kryptonRibbonGroupTriple6 = New Krypton.Ribbon.KryptonRibbonGroupTriple()
        Me.buttonSpecsAdd = New Krypton.Ribbon.KryptonRibbonGroupButton()
        Me.buttonSpecsClear = New Krypton.Ribbon.KryptonRibbonGroupButton()
        Me.kryptonPanel = New Krypton.Toolkit.KryptonPanel()
        Me.imageListSmall = New System.Windows.Forms.ImageList()
        Me.kryptonManager = New Krypton.Toolkit.KryptonManager()
        Me.kryptonDockableWorkspace = New Krypton.Docking.KryptonDockableWorkspace()
        Me.kryptonDockingManager = New Krypton.Docking.KryptonDockingManager()
        Me.kryptonContextMenuItem1 = New Krypton.Toolkit.KryptonContextMenuItem()
        CType(Me.kryptonRibbon1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.kryptonPanel, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.kryptonPanel.SuspendLayout()
        CType(Me.kryptonDockableWorkspace, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        Me.kryptonRibbon1.InDesignHelperMode = True
        Me.kryptonRibbon1.Name = "kryptonRibbon1"
        Me.kryptonRibbon1.RibbonFileAppButton.AppButtonImage = Nothing
        Me.kryptonRibbon1.RibbonFileAppButton.AppButtonMenuItems.AddRange(New Krypton.Toolkit.KryptonContextMenuItemBase() { Me.kryptonContextMenuItem1})
        Me.kryptonRibbon1.RibbonTabs.AddRange(New Krypton.Ribbon.KryptonRibbonTab() { Me.kryptonRibbonTab1, Me.kryptonRibbonTab2})
        Me.kryptonRibbon1.SelectedTab = Me.kryptonRibbonTab1
        Me.kryptonRibbon1.Size = New System.Drawing.Size(1101, 136)
        Me.kryptonRibbon1.TabIndex = 0
        Me.kryptonRibbonTab1.Groups.AddRange(New Krypton.Ribbon.KryptonRibbonGroup() { Me.kryptonRibbonGroup2, Me.kryptonRibbonGroup3, Me.kryptonRibbonGroup5, Me.kryptonRibbonGroup4, Me.kryptonRibbonGroup7})
        Me.kryptonRibbonTab1.KeyTip = "C"
        Me.kryptonRibbonTab1.Text = "Cell Modes"
        Me.kryptonRibbonGroup2.DialogBoxLauncher = False
        Me.kryptonRibbonGroup2.Image = CType(resources.GetObject("kryptonRibbonGroup2.Image"), System.Drawing.Image)
        Me.kryptonRibbonGroup2.Items.AddRange(New Krypton.Ribbon.KryptonRibbonGroupContainer() { Me.kryptonRibbonGroupTriple5})
        Me.kryptonRibbonGroup2.KeyTipGroup = "S"
        Me.kryptonRibbonGroup2.TextLine1 = "Stack Modes"
        Me.kryptonRibbonGroupTriple5.Items.AddRange(New Krypton.Ribbon.KryptonRibbonGroupItem() { Me.modeStackGroup, Me.modeStackHeaderGroup})
        Me.kryptonRibbonGroupTriple5.MaximumSize = Krypton.Ribbon.GroupItemSize.Medium
        Me.kryptonRibbonGroupTriple5.MinimumSize = Krypton.Ribbon.GroupItemSize.Medium
        Me.modeStackGroup.ButtonType = Krypton.Ribbon.GroupButtonType.Check
        Me.modeStackGroup.ImageLarge = CType(resources.GetObject("modeStackGroup.ImageLarge"), System.Drawing.Image)
        Me.modeStackGroup.ImageSmall = CType(resources.GetObject("modeStackGroup.ImageSmall"), System.Drawing.Image)
        Me.modeStackGroup.KeyTip = "SG"
        Me.modeStackGroup.Tag = "StackCheckButtonGroup"
        Me.modeStackGroup.TextLine1 = "Stack - Group"
        Me.modeStackHeaderGroup.ButtonType = Krypton.Ribbon.GroupButtonType.Check
        Me.modeStackHeaderGroup.ImageLarge = CType(resources.GetObject("modeStackHeaderGroup.ImageLarge"), System.Drawing.Image)
        Me.modeStackHeaderGroup.ImageSmall = CType(resources.GetObject("modeStackHeaderGroup.ImageSmall"), System.Drawing.Image)
        Me.modeStackHeaderGroup.KeyTip = "SH"
        Me.modeStackHeaderGroup.Tag = "StackCheckButtonHeaderGroup"
        Me.modeStackHeaderGroup.TextLine1 = "Stack - HeaderGroup"
        Me.kryptonRibbonGroup3.DialogBoxLauncher = False
        Me.kryptonRibbonGroup3.Image = CType(resources.GetObject("kryptonRibbonGroup3.Image"), System.Drawing.Image)
        Me.kryptonRibbonGroup3.Items.AddRange(New Krypton.Ribbon.KryptonRibbonGroupContainer() { Me.kryptonRibbonGroupTriple3})
        Me.kryptonRibbonGroup3.KeyTipGroup = "B"
        Me.kryptonRibbonGroup3.TextLine1 = "Bar Modes"
        Me.kryptonRibbonGroupTriple3.Items.AddRange(New Krypton.Ribbon.KryptonRibbonGroupItem() { Me.modeBarGroupOutside, Me.modeBarGroupInside, Me.modeTabGroup})
        Me.kryptonRibbonGroupTriple3.MaximumSize = Krypton.Ribbon.GroupItemSize.Medium
        Me.kryptonRibbonGroupTriple3.MinimumSize = Krypton.Ribbon.GroupItemSize.Medium
        Me.modeBarGroupOutside.ButtonType = Krypton.Ribbon.GroupButtonType.Check
        Me.modeBarGroupOutside.ImageLarge = CType(resources.GetObject("modeBarGroupOutside.ImageLarge"), System.Drawing.Image)
        Me.modeBarGroupOutside.ImageSmall = CType(resources.GetObject("modeBarGroupOutside.ImageSmall"), System.Drawing.Image)
        Me.modeBarGroupOutside.KeyTip = "BO"
        Me.modeBarGroupOutside.Tag = "BarCheckButtonGroupOutside"
        Me.modeBarGroupOutside.TextLine1 = "Bar - GroupOutside"
        Me.modeBarGroupInside.ButtonType = Krypton.Ribbon.GroupButtonType.Check
        Me.modeBarGroupInside.ImageLarge = CType(resources.GetObject("modeBarGroupInside.ImageLarge"), System.Drawing.Image)
        Me.modeBarGroupInside.ImageSmall = CType(resources.GetObject("modeBarGroupInside.ImageSmall"), System.Drawing.Image)
        Me.modeBarGroupInside.KeyTip = "BI"
        Me.modeBarGroupInside.Tag = "BarCheckButtonGroupInside"
        Me.modeBarGroupInside.TextLine1 = "Bar - GroupInside"
        Me.modeTabGroup.ButtonType = Krypton.Ribbon.GroupButtonType.Check
        Me.modeTabGroup.ImageLarge = CType(resources.GetObject("modeTabGroup.ImageLarge"), System.Drawing.Image)
        Me.modeTabGroup.ImageSmall = CType(resources.GetObject("modeTabGroup.ImageSmall"), System.Drawing.Image)
        Me.modeTabGroup.KeyTip = "BT"
        Me.modeTabGroup.Tag = "BarTabGroup"
        Me.modeTabGroup.TextLine1 = "Bar - TabGroup"
        Me.kryptonRibbonGroup5.DialogBoxLauncher = False
        Me.kryptonRibbonGroup5.Image = CType(resources.GetObject("kryptonRibbonGroup5.Image"), System.Drawing.Image)
        Me.kryptonRibbonGroup5.Items.AddRange(New Krypton.Ribbon.KryptonRibbonGroupContainer() { Me.kryptonRibbonGroupTriple4})
        Me.kryptonRibbonGroup5.KeyTipGroup = "R"
        Me.kryptonRibbonGroup5.TextLine1 = "BarRibbon Modes"
        Me.kryptonRibbonGroupTriple4.Items.AddRange(New Krypton.Ribbon.KryptonRibbonGroupItem() { Me.modeBarRibbonTabGroup})
        Me.kryptonRibbonGroupTriple4.MaximumSize = Krypton.Ribbon.GroupItemSize.Medium
        Me.kryptonRibbonGroupTriple4.MinimumSize = Krypton.Ribbon.GroupItemSize.Medium
        Me.modeBarRibbonTabGroup.ButtonType = Krypton.Ribbon.GroupButtonType.Check
        Me.modeBarRibbonTabGroup.ImageLarge = CType(resources.GetObject("modeBarRibbonTabGroup.ImageLarge"), System.Drawing.Image)
        Me.modeBarRibbonTabGroup.ImageSmall = CType(resources.GetObject("modeBarRibbonTabGroup.ImageSmall"), System.Drawing.Image)
        Me.modeBarRibbonTabGroup.KeyTip = "BR"
        Me.modeBarRibbonTabGroup.Tag = "BarRibbonTabGroup"
        Me.modeBarRibbonTabGroup.TextLine1 = "BarRibbon - TabGroup"
        Me.kryptonRibbonGroup4.DialogBoxLauncher = False
        Me.kryptonRibbonGroup4.Image = CType(resources.GetObject("kryptonRibbonGroup4.Image"), System.Drawing.Image)
        Me.kryptonRibbonGroup4.Items.AddRange(New Krypton.Ribbon.KryptonRibbonGroupContainer() { Me.kryptonRibbonGroupTriple2})
        Me.kryptonRibbonGroup4.KeyTipGroup = "H"
        Me.kryptonRibbonGroup4.TextLine1 = "HeaderBar Modes"
        Me.kryptonRibbonGroupTriple2.Items.AddRange(New Krypton.Ribbon.KryptonRibbonGroupItem() { Me.modeHeaderBarGroup, Me.modeHeaderBarHeaderGroup})
        Me.kryptonRibbonGroupTriple2.MaximumSize = Krypton.Ribbon.GroupItemSize.Medium
        Me.kryptonRibbonGroupTriple2.MinimumSize = Krypton.Ribbon.GroupItemSize.Medium
        Me.modeHeaderBarGroup.ButtonType = Krypton.Ribbon.GroupButtonType.Check
        Me.modeHeaderBarGroup.ImageLarge = CType(resources.GetObject("modeHeaderBarGroup.ImageLarge"), System.Drawing.Image)
        Me.modeHeaderBarGroup.ImageSmall = CType(resources.GetObject("modeHeaderBarGroup.ImageSmall"), System.Drawing.Image)
        Me.modeHeaderBarGroup.KeyTip = "HG"
        Me.modeHeaderBarGroup.Tag = "HeaderBarCheckButtonGroup"
        Me.modeHeaderBarGroup.TextLine1 = "HeaderBar - Group"
        Me.modeHeaderBarHeaderGroup.ButtonType = Krypton.Ribbon.GroupButtonType.Check
        Me.modeHeaderBarHeaderGroup.ImageLarge = CType(resources.GetObject("modeHeaderBarHeaderGroup.ImageLarge"), System.Drawing.Image)
        Me.modeHeaderBarHeaderGroup.ImageSmall = CType(resources.GetObject("modeHeaderBarHeaderGroup.ImageSmall"), System.Drawing.Image)
        Me.modeHeaderBarHeaderGroup.KeyTip = "HH"
        Me.modeHeaderBarHeaderGroup.Tag = "HeaderBarCheckButtonHeaderGroup"
        Me.modeHeaderBarHeaderGroup.TextLine1 = "HeaderBar - HeaderGroup"
        Me.kryptonRibbonGroup7.DialogBoxLauncher = False
        Me.kryptonRibbonGroup7.Items.AddRange(New Krypton.Ribbon.KryptonRibbonGroupContainer() { Me.kryptonRibbonGroupTriple7})
        Me.kryptonRibbonGroup7.TextLine1 = "HeaderGroup Modes"
        Me.kryptonRibbonGroupTriple7.Items.AddRange(New Krypton.Ribbon.KryptonRibbonGroupItem() { Me.modeHeaderGroupTab})
        Me.kryptonRibbonGroupTriple7.MaximumSize = Krypton.Ribbon.GroupItemSize.Medium
        Me.modeHeaderGroupTab.ImageSmall = CType(resources.GetObject("modeHeaderGroupTab.ImageSmall"), System.Drawing.Image)
        Me.modeHeaderGroupTab.KeyTip = "GT"
        Me.modeHeaderGroupTab.Tag = "HeaderGroupTab"
        Me.modeHeaderGroupTab.TextLine1 = "HeaderGroup - Tab"
        Me.kryptonRibbonTab2.Groups.AddRange(New Krypton.Ribbon.KryptonRibbonGroup() { Me.kryptonRibbonGroup1, Me.kryptonRibbonGroup6})
        Me.kryptonRibbonTab2.KeyTip = "A"
        Me.kryptonRibbonTab2.Text = "Actions"
        Me.kryptonRibbonGroup1.AllowCollapsed = False
        Me.kryptonRibbonGroup1.DialogBoxLauncher = False
        Me.kryptonRibbonGroup1.Items.AddRange(New Krypton.Ribbon.KryptonRibbonGroupContainer() { Me.kryptonRibbonGroupTriple1})
        Me.kryptonRibbonGroup1.KeyTipGroup = "C"
        Me.kryptonRibbonGroup1.TextLine1 = "Colors"
        Me.kryptonRibbonGroupTriple1.Items.AddRange(New Krypton.Ribbon.KryptonRibbonGroupItem() { Me.colorsRandom, Me.colorsReset})
        Me.kryptonRibbonGroupTriple1.MinimumSize = Krypton.Ribbon.GroupItemSize.Large
        Me.colorsRandom.ImageLarge = CType(resources.GetObject("colorsRandom.ImageLarge"), System.Drawing.Image)
        Me.colorsRandom.KeyTip = "R"
        Me.colorsRandom.TextLine1 = "Random"
        Me.colorsRandom.TextLine2 = "Page Colors"
        Me.colorsReset.ImageLarge = CType(resources.GetObject("colorsReset.ImageLarge"), System.Drawing.Image)
        Me.colorsReset.KeyTip = "S"
        Me.colorsReset.TextLine1 = "Reset"
        Me.colorsReset.TextLine2 = "Page Colors"
        Me.kryptonRibbonGroup6.AllowCollapsed = False
        Me.kryptonRibbonGroup6.DialogBoxLauncher = False
        Me.kryptonRibbonGroup6.Items.AddRange(New Krypton.Ribbon.KryptonRibbonGroupContainer() { Me.kryptonRibbonGroupTriple6})
        Me.kryptonRibbonGroup6.TextLine1 = "ButtonSpecs"
        Me.kryptonRibbonGroupTriple6.Items.AddRange(New Krypton.Ribbon.KryptonRibbonGroupItem() { Me.buttonSpecsAdd, Me.buttonSpecsClear})
        Me.kryptonRibbonGroupTriple6.MinimumSize = Krypton.Ribbon.GroupItemSize.Large
        Me.buttonSpecsAdd.ImageLarge = CType(resources.GetObject("buttonSpecsAdd.ImageLarge"), System.Drawing.Image)
        Me.buttonSpecsAdd.TextLine1 = "Add Page"
        Me.buttonSpecsAdd.TextLine2 = "ButtonSpecs"
        Me.buttonSpecsClear.ImageLarge = CType(resources.GetObject("buttonSpecsClear.ImageLarge"), System.Drawing.Image)
        Me.buttonSpecsClear.KeyTip = "C"
        Me.buttonSpecsClear.TextLine1 = "Clear Page"
        Me.buttonSpecsClear.TextLine2 = "ButtonSpecs"
        Me.kryptonPanel.Controls.Add(Me.kryptonDockableWorkspace)
        Me.kryptonPanel.Dock = System.Windows.Forms.DockStyle.Fill
        Me.kryptonPanel.Location = New System.Drawing.Point(0, 136)
        Me.kryptonPanel.Margin = New System.Windows.Forms.Padding(4)
        Me.kryptonPanel.Name = "kryptonPanel"
        Me.kryptonPanel.Padding = New System.Windows.Forms.Padding(4)
        Me.kryptonPanel.Size = New System.Drawing.Size(1101, 557)
        Me.kryptonPanel.TabIndex = 1
        Me.imageListSmall.ImageStream = CType(resources.GetObject("imageListSmall.ImageStream"), System.Windows.Forms.ImageListStreamer)
        Me.imageListSmall.TransparentColor = System.Drawing.Color.Transparent
        Me.imageListSmall.Images.SetKeyName(0, "document_plain.png")
        Me.imageListSmall.Images.SetKeyName(1, "preferences.png")
        Me.imageListSmall.Images.SetKeyName(2, "information2.png")
        Me.kryptonManager.GlobalPaletteMode = Krypton.Toolkit.PaletteMode.Office2010Blue
        Me.kryptonDockableWorkspace.ActivePage = Nothing
        Me.kryptonDockableWorkspace.AutoHiddenHost = False
        Me.kryptonDockableWorkspace.CompactFlags = CType(((Krypton.Workspace.CompactFlags.RemoveEmptyCells Or Krypton.Workspace.CompactFlags.RemoveEmptySequences) Or Krypton.Workspace.CompactFlags.PromoteLeafs), Krypton.Workspace.CompactFlags)
        Me.kryptonDockableWorkspace.ContainerBackStyle = Krypton.Toolkit.PaletteBackStyle.PanelClient
        Me.kryptonDockableWorkspace.Dock = System.Windows.Forms.DockStyle.Fill
        Me.kryptonDockableWorkspace.Location = New System.Drawing.Point(4, 4)
        Me.kryptonDockableWorkspace.Margin = New System.Windows.Forms.Padding(4)
        Me.kryptonDockableWorkspace.Name = "kryptonDockableWorkspace"
        Me.kryptonDockableWorkspace.Root.UniqueName = "5594893E2F2E42885594893E2F2E4288"
        Me.kryptonDockableWorkspace.Root.WorkspaceControl = Me.kryptonDockableWorkspace
        Me.kryptonDockableWorkspace.SeparatorStyle = Krypton.Toolkit.SeparatorStyle.LowProfile
        Me.kryptonDockableWorkspace.ShowMaximizeButton = False
        Me.kryptonDockableWorkspace.Size = New System.Drawing.Size(1093, 549)
        Me.kryptonDockableWorkspace.SplitterWidth = 5
        Me.kryptonDockableWorkspace.TabIndex = 0
        Me.kryptonDockableWorkspace.TabStop = True
        Me.kryptonContextMenuItem1.Text = "E&xit"
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8F, 16F)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(1101, 693)
        Me.CloseBox = False
        Me.Controls.Add(Me.kryptonPanel)
        Me.Controls.Add(Me.kryptonRibbon1)
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.Margin = New System.Windows.Forms.Padding(4)
        Me.Name = "Form1"
        Me.ShowIcon = False
        Me.Text = "Docking Customized"
        CType(Me.kryptonRibbon1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.kryptonPanel, System.ComponentModel.ISupportInitialize).EndInit()
        Me.kryptonPanel.ResumeLayout(False)
        CType(Me.kryptonDockableWorkspace, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()
    End Sub

    Friend WithEvents kryptonPanel As Krypton.Toolkit.KryptonPanel
    Friend WithEvents kryptonDockableWorkspace As Krypton.Docking.KryptonDockableWorkspace
    Friend WithEvents kryptonDockingManager As Krypton.Docking.KryptonDockingManager
    Friend WithEvents imageListSmall As System.Windows.Forms.ImageList
    Friend WithEvents kryptonManager As Krypton.Toolkit.KryptonManager
    Friend WithEvents kryptonRibbon1 As Krypton.Ribbon.KryptonRibbon
    Friend WithEvents kryptonRibbonTab1 As Krypton.Ribbon.KryptonRibbonTab
    Friend WithEvents kryptonRibbonGroup2 As Krypton.Ribbon.KryptonRibbonGroup
    Friend WithEvents kryptonRibbonGroup3 As Krypton.Ribbon.KryptonRibbonGroup
    Friend WithEvents kryptonRibbonGroup4 As Krypton.Ribbon.KryptonRibbonGroup
    Friend WithEvents kryptonRibbonGroup5 As Krypton.Ribbon.KryptonRibbonGroup
    Friend WithEvents kryptonRibbonGroupTriple2 As Krypton.Ribbon.KryptonRibbonGroupTriple
    Friend WithEvents kryptonRibbonGroupTriple3 As Krypton.Ribbon.KryptonRibbonGroupTriple
    Friend WithEvents kryptonRibbonGroupTriple4 As Krypton.Ribbon.KryptonRibbonGroupTriple
    Friend WithEvents kryptonRibbonGroupTriple5 As Krypton.Ribbon.KryptonRibbonGroupTriple
    Friend WithEvents modeHeaderBarHeaderGroup As Krypton.Ribbon.KryptonRibbonGroupButton
    Friend WithEvents modeHeaderBarGroup As Krypton.Ribbon.KryptonRibbonGroupButton
    Friend WithEvents modeTabGroup As Krypton.Ribbon.KryptonRibbonGroupButton
    Friend WithEvents modeBarGroupInside As Krypton.Ribbon.KryptonRibbonGroupButton
    Friend WithEvents modeBarGroupOutside As Krypton.Ribbon.KryptonRibbonGroupButton
    Friend WithEvents modeBarRibbonTabGroup As Krypton.Ribbon.KryptonRibbonGroupButton
    Friend WithEvents modeStackGroup As Krypton.Ribbon.KryptonRibbonGroupButton
    Friend WithEvents modeStackHeaderGroup As Krypton.Ribbon.KryptonRibbonGroupButton
    Friend WithEvents kryptonRibbonTab2 As Krypton.Ribbon.KryptonRibbonTab
    Friend WithEvents kryptonRibbonGroup1 As Krypton.Ribbon.KryptonRibbonGroup
    Friend WithEvents kryptonRibbonGroupTriple1 As Krypton.Ribbon.KryptonRibbonGroupTriple
    Friend WithEvents colorsRandom As Krypton.Ribbon.KryptonRibbonGroupButton
    Friend WithEvents colorsReset As Krypton.Ribbon.KryptonRibbonGroupButton
    Friend WithEvents kryptonRibbonGroup6 As Krypton.Ribbon.KryptonRibbonGroup
    Friend WithEvents kryptonRibbonGroupTriple6 As Krypton.Ribbon.KryptonRibbonGroupTriple
    Friend WithEvents buttonSpecsAdd As Krypton.Ribbon.KryptonRibbonGroupButton
    Friend WithEvents buttonSpecsClear As Krypton.Ribbon.KryptonRibbonGroupButton
    Friend WithEvents kryptonRibbonGroup7 As Krypton.Ribbon.KryptonRibbonGroup
    Friend WithEvents kryptonRibbonGroupTriple7 As Krypton.Ribbon.KryptonRibbonGroupTriple
    Friend WithEvents modeHeaderGroupTab As Krypton.Ribbon.KryptonRibbonGroupButton
    Friend WithEvents kryptonContextMenuItem1 As Krypton.Toolkit.KryptonContextMenuItem
End Class
