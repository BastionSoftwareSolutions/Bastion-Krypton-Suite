' VB.NET twin of Source\Krypton Docking Examples\Docking Persistence\Form1.Designer.cs (Bastion Phase 4c).
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
        Me.kryptonDockingManager = New Krypton.Docking.KryptonDockingManager()
        Me.imageListSmall = New System.Windows.Forms.ImageList(Me.components)
        Me.kryptonRibbon = New Krypton.Ribbon.KryptonRibbon()
        Me.kryptonContextMenuItem1 = New Krypton.Toolkit.KryptonContextMenuItem()
        Me.tabPersistence = New Krypton.Ribbon.KryptonRibbonTab()
        Me.kryptonRibbonGroup1 = New Krypton.Ribbon.KryptonRibbonGroup()
        Me.kryptonRibbonGroupTriple1 = New Krypton.Ribbon.KryptonRibbonGroupTriple()
        Me.buttonSaveArray1 = New Krypton.Ribbon.KryptonRibbonGroupButton()
        Me.buttonSaveArray2 = New Krypton.Ribbon.KryptonRibbonGroupButton()
        Me.buttonSaveArray3 = New Krypton.Ribbon.KryptonRibbonGroupButton()
        Me.kryptonRibbonGroupSeparator1 = New Krypton.Ribbon.KryptonRibbonGroupSeparator()
        Me.kryptonRibbonGroupTriple3 = New Krypton.Ribbon.KryptonRibbonGroupTriple()
        Me.buttonLoadArray1 = New Krypton.Ribbon.KryptonRibbonGroupButton()
        Me.buttonLoadArray2 = New Krypton.Ribbon.KryptonRibbonGroupButton()
        Me.buttonLoadArray3 = New Krypton.Ribbon.KryptonRibbonGroupButton()
        Me.kryptonRibbonGroup2 = New Krypton.Ribbon.KryptonRibbonGroup()
        Me.kryptonRibbonGroupTriple2 = New Krypton.Ribbon.KryptonRibbonGroupTriple()
        Me.buttonSaveFile = New Krypton.Ribbon.KryptonRibbonGroupButton()
        Me.kryptonRibbonGroupSeparator2 = New Krypton.Ribbon.KryptonRibbonGroupSeparator()
        Me.kryptonRibbonGroupTriple4 = New Krypton.Ribbon.KryptonRibbonGroupTriple()
        Me.buttonLoadFile = New Krypton.Ribbon.KryptonRibbonGroupButton()
        Me.kryptonRibbonGroup3 = New Krypton.Ribbon.KryptonRibbonGroup()
        Me.kryptonRibbonGroupTriple5 = New Krypton.Ribbon.KryptonRibbonGroupTriple()
        Me.buttonHideAll = New Krypton.Ribbon.KryptonRibbonGroupButton()
        Me.buttonShowAll = New Krypton.Ribbon.KryptonRibbonGroupButton()
        Me.kryptonPanel = New Krypton.Toolkit.KryptonPanel()
        Me.kryptonDockableWorkspace = New Krypton.Docking.KryptonDockableWorkspace()
        Me.openFileDialog = New System.Windows.Forms.OpenFileDialog()
        Me.saveFileDialog = New System.Windows.Forms.SaveFileDialog()
        Me.kryptonManager = New Krypton.Toolkit.KryptonManager(Me.components)
        CType(Me.kryptonRibbon, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.kryptonPanel, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.kryptonPanel.SuspendLayout()
        CType(Me.kryptonDockableWorkspace, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        Me.imageListSmall.ImageStream = CType(resources.GetObject("imageListSmall.ImageStream"), System.Windows.Forms.ImageListStreamer)
        Me.imageListSmall.TransparentColor = System.Drawing.Color.Transparent
        Me.imageListSmall.Images.SetKeyName(0, "document_plain.png")
        Me.imageListSmall.Images.SetKeyName(1, "preferences.png")
        Me.imageListSmall.Images.SetKeyName(2, "information2.png")
        Me.kryptonRibbon.Name = "kryptonRibbon"
        Me.kryptonRibbon.RibbonFileAppButton.AppButtonImage = Nothing
        Me.kryptonRibbon.RibbonFileAppButton.AppButtonMenuItems.AddRange(New Krypton.Toolkit.KryptonContextMenuItemBase() { Me.kryptonContextMenuItem1})
        Me.kryptonRibbon.RibbonTabs.AddRange(New Krypton.Ribbon.KryptonRibbonTab() { Me.tabPersistence})
        Me.kryptonRibbon.SelectedTab = Me.tabPersistence
        Me.kryptonRibbon.Size = New System.Drawing.Size(1057, 136)
        Me.kryptonRibbon.TabIndex = 0
        Me.kryptonContextMenuItem1.Image = CType(resources.GetObject("kryptonContextMenuItem1.Image"), System.Drawing.Image)
        Me.tabPersistence.Groups.AddRange(New Krypton.Ribbon.KryptonRibbonGroup() { Me.kryptonRibbonGroup1, Me.kryptonRibbonGroup2, Me.kryptonRibbonGroup3})
        Me.tabPersistence.Text = "Persistence"
        Me.kryptonRibbonGroup1.DialogBoxLauncher = False
        Me.kryptonRibbonGroup1.Image = CType(resources.GetObject("kryptonRibbonGroup1.Image"), System.Drawing.Image)
        Me.kryptonRibbonGroup1.Items.AddRange(New Krypton.Ribbon.KryptonRibbonGroupContainer() { Me.kryptonRibbonGroupTriple1, Me.kryptonRibbonGroupSeparator1, Me.kryptonRibbonGroupTriple3})
        Me.kryptonRibbonGroup1.KeyTipGroup = "A"
        Me.kryptonRibbonGroup1.TextLine1 = "Array Persist"
        Me.kryptonRibbonGroupTriple1.Items.AddRange(New Krypton.Ribbon.KryptonRibbonGroupItem() { Me.buttonSaveArray1, Me.buttonSaveArray2, Me.buttonSaveArray3})
        Me.kryptonRibbonGroupTriple1.MaximumSize = Krypton.Ribbon.GroupItemSize.Medium
        Me.kryptonRibbonGroupTriple1.MinimumSize = Krypton.Ribbon.GroupItemSize.Medium
        Me.buttonSaveArray1.ImageLarge = CType(resources.GetObject("buttonSaveArray1.ImageLarge"), System.Drawing.Image)
        Me.buttonSaveArray1.ImageSmall = CType(resources.GetObject("buttonSaveArray1.ImageSmall"), System.Drawing.Image)
        Me.buttonSaveArray1.KeyTip = "SA1"
        Me.buttonSaveArray1.TextLine1 = "Save Array 1"
        Me.buttonSaveArray2.ImageLarge = CType(resources.GetObject("buttonSaveArray2.ImageLarge"), System.Drawing.Image)
        Me.buttonSaveArray2.ImageSmall = CType(resources.GetObject("buttonSaveArray2.ImageSmall"), System.Drawing.Image)
        Me.buttonSaveArray2.KeyTip = "SA2"
        Me.buttonSaveArray2.TextLine1 = "Save Array 2"
        Me.buttonSaveArray3.ImageLarge = CType(resources.GetObject("buttonSaveArray3.ImageLarge"), System.Drawing.Image)
        Me.buttonSaveArray3.ImageSmall = CType(resources.GetObject("buttonSaveArray3.ImageSmall"), System.Drawing.Image)
        Me.buttonSaveArray3.KeyTip = "SA3"
        Me.buttonSaveArray3.TextLine1 = "Save Array 3"
        Me.kryptonRibbonGroupTriple3.Items.AddRange(New Krypton.Ribbon.KryptonRibbonGroupItem() { Me.buttonLoadArray1, Me.buttonLoadArray2, Me.buttonLoadArray3})
        Me.kryptonRibbonGroupTriple3.MaximumSize = Krypton.Ribbon.GroupItemSize.Medium
        Me.kryptonRibbonGroupTriple3.MinimumSize = Krypton.Ribbon.GroupItemSize.Medium
        Me.buttonLoadArray1.Enabled = False
        Me.buttonLoadArray1.ImageLarge = CType(resources.GetObject("buttonLoadArray1.ImageLarge"), System.Drawing.Image)
        Me.buttonLoadArray1.ImageSmall = CType(resources.GetObject("buttonLoadArray1.ImageSmall"), System.Drawing.Image)
        Me.buttonLoadArray1.KeyTip = "LA1"
        Me.buttonLoadArray1.TextLine1 = "Load Array 1"
        Me.buttonLoadArray2.Enabled = False
        Me.buttonLoadArray2.ImageLarge = CType(resources.GetObject("buttonLoadArray2.ImageLarge"), System.Drawing.Image)
        Me.buttonLoadArray2.ImageSmall = CType(resources.GetObject("buttonLoadArray2.ImageSmall"), System.Drawing.Image)
        Me.buttonLoadArray2.KeyTip = "LA2"
        Me.buttonLoadArray2.TextLine1 = "Load Array 2"
        Me.buttonLoadArray3.Enabled = False
        Me.buttonLoadArray3.ImageLarge = CType(resources.GetObject("buttonLoadArray3.ImageLarge"), System.Drawing.Image)
        Me.buttonLoadArray3.ImageSmall = CType(resources.GetObject("buttonLoadArray3.ImageSmall"), System.Drawing.Image)
        Me.buttonLoadArray3.KeyTip = "LA3"
        Me.buttonLoadArray3.TextLine1 = "Load Array 3"
        Me.kryptonRibbonGroup2.DialogBoxLauncher = False
        Me.kryptonRibbonGroup2.Image = CType(resources.GetObject("kryptonRibbonGroup2.Image"), System.Drawing.Image)
        Me.kryptonRibbonGroup2.Items.AddRange(New Krypton.Ribbon.KryptonRibbonGroupContainer() { Me.kryptonRibbonGroupTriple2, Me.kryptonRibbonGroupSeparator2, Me.kryptonRibbonGroupTriple4})
        Me.kryptonRibbonGroup2.TextLine1 = "File Persist"
        Me.kryptonRibbonGroupTriple2.Items.AddRange(New Krypton.Ribbon.KryptonRibbonGroupItem() { Me.buttonSaveFile})
        Me.kryptonRibbonGroupTriple2.MinimumSize = Krypton.Ribbon.GroupItemSize.Large
        Me.buttonSaveFile.ImageLarge = CType(resources.GetObject("buttonSaveFile.ImageLarge"), System.Drawing.Image)
        Me.buttonSaveFile.ImageSmall = CType(resources.GetObject("buttonSaveFile.ImageSmall"), System.Drawing.Image)
        Me.buttonSaveFile.KeyTip = "SF"
        Me.buttonSaveFile.TextLine1 = "Save"
        Me.buttonSaveFile.TextLine2 = "File"
        Me.kryptonRibbonGroupTriple4.Items.AddRange(New Krypton.Ribbon.KryptonRibbonGroupItem() { Me.buttonLoadFile})
        Me.kryptonRibbonGroupTriple4.MinimumSize = Krypton.Ribbon.GroupItemSize.Large
        Me.buttonLoadFile.ImageLarge = CType(resources.GetObject("buttonLoadFile.ImageLarge"), System.Drawing.Image)
        Me.buttonLoadFile.ImageSmall = CType(resources.GetObject("buttonLoadFile.ImageSmall"), System.Drawing.Image)
        Me.buttonLoadFile.KeyTip = "LF"
        Me.buttonLoadFile.TextLine1 = "Load"
        Me.buttonLoadFile.TextLine2 = "File"
        Me.kryptonRibbonGroup3.DialogBoxLauncher = False
        Me.kryptonRibbonGroup3.Image = CType(resources.GetObject("kryptonRibbonGroup3.Image"), System.Drawing.Image)
        Me.kryptonRibbonGroup3.Items.AddRange(New Krypton.Ribbon.KryptonRibbonGroupContainer() { Me.kryptonRibbonGroupTriple5})
        Me.kryptonRibbonGroup3.TextLine1 = "Visibility"
        Me.kryptonRibbonGroupTriple5.Items.AddRange(New Krypton.Ribbon.KryptonRibbonGroupItem() { Me.buttonHideAll, Me.buttonShowAll})
        Me.buttonHideAll.ImageLarge = CType(resources.GetObject("buttonHideAll.ImageLarge"), System.Drawing.Image)
        Me.buttonHideAll.ImageSmall = CType(resources.GetObject("buttonHideAll.ImageSmall"), System.Drawing.Image)
        Me.buttonHideAll.KeyTip = "VH"
        Me.buttonHideAll.TextLine1 = "Hide"
        Me.buttonHideAll.TextLine2 = "All"
        Me.buttonShowAll.ImageLarge = CType(resources.GetObject("buttonShowAll.ImageLarge"), System.Drawing.Image)
        Me.buttonShowAll.ImageSmall = CType(resources.GetObject("buttonShowAll.ImageSmall"), System.Drawing.Image)
        Me.buttonShowAll.KeyTip = "VS"
        Me.buttonShowAll.TextLine1 = "Show"
        Me.buttonShowAll.TextLine2 = "All"
        Me.kryptonPanel.Controls.Add(Me.kryptonDockableWorkspace)
        Me.kryptonPanel.Dock = System.Windows.Forms.DockStyle.Fill
        Me.kryptonPanel.Location = New System.Drawing.Point(0, 136)
        Me.kryptonPanel.Margin = New System.Windows.Forms.Padding(4)
        Me.kryptonPanel.Name = "kryptonPanel"
        Me.kryptonPanel.Padding = New System.Windows.Forms.Padding(4)
        Me.kryptonPanel.Size = New System.Drawing.Size(1057, 516)
        Me.kryptonPanel.TabIndex = 1
        Me.kryptonDockableWorkspace.ActivePage = Nothing
        Me.kryptonDockableWorkspace.CompactFlags = CType(((Krypton.Workspace.CompactFlags.RemoveEmptyCells Or Krypton.Workspace.CompactFlags.RemoveEmptySequences) Or Krypton.Workspace.CompactFlags.PromoteLeafs), Krypton.Workspace.CompactFlags)
        Me.kryptonDockableWorkspace.ContainerBackStyle = Krypton.Toolkit.PaletteBackStyle.PanelClient
        Me.kryptonDockableWorkspace.Dock = System.Windows.Forms.DockStyle.Fill
        Me.kryptonDockableWorkspace.Location = New System.Drawing.Point(4, 4)
        Me.kryptonDockableWorkspace.Margin = New System.Windows.Forms.Padding(4)
        Me.kryptonDockableWorkspace.Name = "kryptonDockableWorkspace"
        Me.kryptonDockableWorkspace.Root.UniqueName = "5462F66039D342065462F66039D34206"
        Me.kryptonDockableWorkspace.SeparatorStyle = Krypton.Toolkit.SeparatorStyle.LowProfile
        Me.kryptonDockableWorkspace.ShowMaximizeButton = False
        Me.kryptonDockableWorkspace.Size = New System.Drawing.Size(1049, 508)
        Me.kryptonDockableWorkspace.SplitterWidth = 5
        Me.kryptonDockableWorkspace.TabIndex = 0
        Me.kryptonDockableWorkspace.TabStop = True
        Me.openFileDialog.DefaultExt = "xml"
        Me.openFileDialog.FileName = "Config.xml"
        Me.openFileDialog.Filter = "Xml Files|*.xml|All Files|*.*"
        Me.saveFileDialog.DefaultExt = "xml"
        Me.saveFileDialog.FileName = "Config.xml"
        Me.saveFileDialog.Filter = "Xml Files|*.xml|All Files|*.*"
        Me.saveFileDialog.InitialDirectory = "c:\"
        Me.kryptonManager.GlobalPaletteMode = Krypton.Toolkit.PaletteMode.Office2010Blue
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8F, 16F)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(1057, 652)
        Me.CloseBox = False
        Me.Controls.Add(Me.kryptonPanel)
        Me.Controls.Add(Me.kryptonRibbon)
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.Margin = New System.Windows.Forms.Padding(4)
        Me.Name = "Form1"
        Me.ShowIcon = False
        Me.Text = "Docking Persistence"
        CType(Me.kryptonRibbon, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.kryptonPanel, System.ComponentModel.ISupportInitialize).EndInit()
        Me.kryptonPanel.ResumeLayout(False)
        CType(Me.kryptonDockableWorkspace, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()
    End Sub

    Friend WithEvents kryptonDockingManager As Krypton.Docking.KryptonDockingManager
    Friend WithEvents imageListSmall As System.Windows.Forms.ImageList
    Friend WithEvents kryptonRibbon As Krypton.Ribbon.KryptonRibbon
    Friend WithEvents tabPersistence As Krypton.Ribbon.KryptonRibbonTab
    Friend WithEvents kryptonRibbonGroup1 As Krypton.Ribbon.KryptonRibbonGroup
    Friend WithEvents kryptonRibbonGroupTriple1 As Krypton.Ribbon.KryptonRibbonGroupTriple
    Friend WithEvents buttonSaveArray1 As Krypton.Ribbon.KryptonRibbonGroupButton
    Friend WithEvents buttonSaveArray2 As Krypton.Ribbon.KryptonRibbonGroupButton
    Friend WithEvents kryptonRibbonGroupSeparator1 As Krypton.Ribbon.KryptonRibbonGroupSeparator
    Friend WithEvents kryptonRibbonGroupTriple2 As Krypton.Ribbon.KryptonRibbonGroupTriple
    Friend WithEvents kryptonPanel As Krypton.Toolkit.KryptonPanel
    Friend WithEvents buttonSaveArray3 As Krypton.Ribbon.KryptonRibbonGroupButton
    Friend WithEvents kryptonRibbonGroup2 As Krypton.Ribbon.KryptonRibbonGroup
    Friend WithEvents kryptonRibbonGroupTriple3 As Krypton.Ribbon.KryptonRibbonGroupTriple
    Friend WithEvents buttonLoadArray1 As Krypton.Ribbon.KryptonRibbonGroupButton
    Friend WithEvents buttonLoadArray2 As Krypton.Ribbon.KryptonRibbonGroupButton
    Friend WithEvents buttonLoadArray3 As Krypton.Ribbon.KryptonRibbonGroupButton
    Friend WithEvents kryptonRibbonGroupSeparator2 As Krypton.Ribbon.KryptonRibbonGroupSeparator
    Friend WithEvents kryptonRibbonGroupTriple4 As Krypton.Ribbon.KryptonRibbonGroupTriple
    Friend WithEvents buttonLoadFile As Krypton.Ribbon.KryptonRibbonGroupButton
    Friend WithEvents kryptonRibbonGroup3 As Krypton.Ribbon.KryptonRibbonGroup
    Friend WithEvents kryptonRibbonGroupTriple5 As Krypton.Ribbon.KryptonRibbonGroupTriple
    Friend WithEvents buttonHideAll As Krypton.Ribbon.KryptonRibbonGroupButton
    Friend WithEvents buttonShowAll As Krypton.Ribbon.KryptonRibbonGroupButton
    Friend WithEvents kryptonContextMenuItem1 As Krypton.Toolkit.KryptonContextMenuItem
    Friend WithEvents kryptonDockableWorkspace As Krypton.Docking.KryptonDockableWorkspace
    Friend WithEvents buttonSaveFile As Krypton.Ribbon.KryptonRibbonGroupButton
    Friend WithEvents openFileDialog As System.Windows.Forms.OpenFileDialog
    Friend WithEvents saveFileDialog As System.Windows.Forms.SaveFileDialog
    Friend WithEvents kryptonManager As Krypton.Toolkit.KryptonManager
End Class
