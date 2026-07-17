' VB.NET twin of Source\Krypton Toolkit Examples\Three Pane Application (Basic)\Form1.Designer.cs (Bastion Phase 4c).
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
        Me.menuStrip1 = New System.Windows.Forms.MenuStrip()
        Me.fileToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.newToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.openToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.toolStripSeparator = New System.Windows.Forms.ToolStripSeparator()
        Me.saveToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.saveAsToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.toolStripSeparator1 = New System.Windows.Forms.ToolStripSeparator()
        Me.printToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.printPreviewToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.toolStripSeparator2 = New System.Windows.Forms.ToolStripSeparator()
        Me.exitToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.editToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.undoToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.redoToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.toolStripSeparator3 = New System.Windows.Forms.ToolStripSeparator()
        Me.cutToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.copyToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.pasteToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.toolStripSeparator4 = New System.Windows.Forms.ToolStripSeparator()
        Me.selectAllToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.toolsToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.customizeToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.optionsToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.helpToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.contentsToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.indexToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.searchToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.toolStripSeparator5 = New System.Windows.Forms.ToolStripSeparator()
        Me.aboutToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.toolStrip1 = New System.Windows.Forms.ToolStrip()
        Me.newToolStripButton = New System.Windows.Forms.ToolStripButton()
        Me.openToolStripButton = New System.Windows.Forms.ToolStripButton()
        Me.saveToolStripButton = New System.Windows.Forms.ToolStripButton()
        Me.printToolStripButton = New System.Windows.Forms.ToolStripButton()
        Me.toolStripSeparator6 = New System.Windows.Forms.ToolStripSeparator()
        Me.cutToolStripButton = New System.Windows.Forms.ToolStripButton()
        Me.copyToolStripButton = New System.Windows.Forms.ToolStripButton()
        Me.pasteToolStripButton = New System.Windows.Forms.ToolStripButton()
        Me.toolStripSeparator7 = New System.Windows.Forms.ToolStripSeparator()
        Me.helpToolStripButton = New System.Windows.Forms.ToolStripButton()
        Me.toolStripContainer1 = New System.Windows.Forms.ToolStripContainer()
        Me.kryptonPanelMain = New Krypton.Toolkit.KryptonPanel()
        Me.kryptonSplitContainerMain = New Krypton.Toolkit.KryptonSplitContainer()
        Me.kryptonHeaderGroupNavigation = New Krypton.Toolkit.KryptonHeaderGroup()
        Me.kryptonSplitContainerDetails = New Krypton.Toolkit.KryptonSplitContainer()
        Me.kryptonHeaderGroupDetails = New Krypton.Toolkit.KryptonHeaderGroup()
        Me.kryptonButtonGroup = New Krypton.Toolkit.KryptonGroup()
        Me.kryptonGroup1 = New Krypton.Toolkit.KryptonGroup()
        Me.kryptonOffice2010Black = New Krypton.Toolkit.KryptonRadioButton()
        Me.kryptonSparkleOrange = New Krypton.Toolkit.KryptonRadioButton()
        Me.kryptonOffice2010Blue = New Krypton.Toolkit.KryptonRadioButton()
        Me.kryptonOffice2010Silver = New Krypton.Toolkit.KryptonRadioButton()
        Me.kryptonSparklePurple = New Krypton.Toolkit.KryptonRadioButton()
        Me.kryptonSparkleBlue = New Krypton.Toolkit.KryptonRadioButton()
        Me.kryptonCustom = New Krypton.Toolkit.KryptonRadioButton()
        Me.kryptonSystem = New Krypton.Toolkit.KryptonRadioButton()
        Me.kryptonOffice2003 = New Krypton.Toolkit.KryptonRadioButton()
        Me.kryptonOffice2007Black = New Krypton.Toolkit.KryptonRadioButton()
        Me.kryptonOffice2007Silver = New Krypton.Toolkit.KryptonRadioButton()
        Me.kryptonOffice2007Blue = New Krypton.Toolkit.KryptonRadioButton()
        Me.kryptonOffice2013White = New Krypton.Toolkit.KryptonRadioButton()
        Me.kryptonManager = New Krypton.Toolkit.KryptonManager(Me.components)
        Me.kryptonPaletteCustom = New Krypton.Toolkit.KryptonCustomPaletteBase(Me.components)
        Me.statusStrip1 = New System.Windows.Forms.StatusStrip()
        Me.kryptonRadioButton1 = New Krypton.Toolkit.KryptonRadioButton()
        Me.kryptonRadioButton2 = New Krypton.Toolkit.KryptonRadioButton()
        Me.menuStrip1.SuspendLayout()
        Me.toolStrip1.SuspendLayout()
        Me.toolStripContainer1.ContentPanel.SuspendLayout()
        Me.toolStripContainer1.TopToolStripPanel.SuspendLayout()
        Me.toolStripContainer1.SuspendLayout()
        CType(Me.kryptonPanelMain, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.kryptonPanelMain.SuspendLayout()
        CType(Me.kryptonSplitContainerMain, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.kryptonSplitContainerMain.Panel1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.kryptonSplitContainerMain.Panel1.SuspendLayout()
        CType(Me.kryptonSplitContainerMain.Panel2, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.kryptonSplitContainerMain.Panel2.SuspendLayout()
        Me.kryptonSplitContainerMain.SuspendLayout()
        CType(Me.kryptonHeaderGroupNavigation, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.kryptonHeaderGroupNavigation.Panel, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.kryptonHeaderGroupNavigation.SuspendLayout()
        CType(Me.kryptonSplitContainerDetails, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.kryptonSplitContainerDetails.Panel1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.kryptonSplitContainerDetails.Panel1.SuspendLayout()
        CType(Me.kryptonSplitContainerDetails.Panel2, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.kryptonSplitContainerDetails.Panel2.SuspendLayout()
        Me.kryptonSplitContainerDetails.SuspendLayout()
        CType(Me.kryptonHeaderGroupDetails, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.kryptonHeaderGroupDetails.Panel, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.kryptonHeaderGroupDetails.SuspendLayout()
        CType(Me.kryptonButtonGroup, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.kryptonButtonGroup.Panel, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.kryptonButtonGroup.Panel.SuspendLayout()
        Me.kryptonButtonGroup.SuspendLayout()
        CType(Me.kryptonGroup1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.kryptonGroup1.Panel, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.kryptonGroup1.Panel.SuspendLayout()
        Me.kryptonGroup1.SuspendLayout()
        Me.SuspendLayout()
        Me.menuStrip1.Font = New System.Drawing.Font("Segoe UI", 9F)
        Me.menuStrip1.ImageScalingSize = New System.Drawing.Size(20, 20)
        Me.menuStrip1.Items.AddRange(New System.Windows.Forms.ToolStripItem() { Me.fileToolStripMenuItem, Me.editToolStripMenuItem, Me.toolsToolStripMenuItem, Me.helpToolStripMenuItem})
        Me.menuStrip1.Location = New System.Drawing.Point(0, 0)
        Me.menuStrip1.Name = "menuStrip1"
        Me.menuStrip1.Size = New System.Drawing.Size(459, 30)
        Me.menuStrip1.TabIndex = 0
        Me.menuStrip1.Text = "menuStrip1"
        Me.fileToolStripMenuItem.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() { Me.newToolStripMenuItem, Me.openToolStripMenuItem, Me.toolStripSeparator, Me.saveToolStripMenuItem, Me.saveAsToolStripMenuItem, Me.toolStripSeparator1, Me.printToolStripMenuItem, Me.printPreviewToolStripMenuItem, Me.toolStripSeparator2, Me.exitToolStripMenuItem})
        Me.fileToolStripMenuItem.Name = "fileToolStripMenuItem"
        Me.fileToolStripMenuItem.Size = New System.Drawing.Size(46, 26)
        Me.fileToolStripMenuItem.Text = "&File"
        Me.newToolStripMenuItem.Image = CType(resources.GetObject("newToolStripMenuItem.Image"), System.Drawing.Image)
        Me.newToolStripMenuItem.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.newToolStripMenuItem.Name = "newToolStripMenuItem"
        Me.newToolStripMenuItem.ShortcutKeys = CType((System.Windows.Forms.Keys.Control Or System.Windows.Forms.Keys.N), System.Windows.Forms.Keys)
        Me.newToolStripMenuItem.Size = New System.Drawing.Size(181, 26)
        Me.newToolStripMenuItem.Text = "&New"
        Me.openToolStripMenuItem.Image = CType(resources.GetObject("openToolStripMenuItem.Image"), System.Drawing.Image)
        Me.openToolStripMenuItem.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.openToolStripMenuItem.Name = "openToolStripMenuItem"
        Me.openToolStripMenuItem.ShortcutKeys = CType((System.Windows.Forms.Keys.Control Or System.Windows.Forms.Keys.O), System.Windows.Forms.Keys)
        Me.openToolStripMenuItem.Size = New System.Drawing.Size(181, 26)
        Me.openToolStripMenuItem.Text = "&Open"
        Me.toolStripSeparator.Name = "toolStripSeparator"
        Me.toolStripSeparator.Size = New System.Drawing.Size(178, 6)
        Me.saveToolStripMenuItem.Image = CType(resources.GetObject("saveToolStripMenuItem.Image"), System.Drawing.Image)
        Me.saveToolStripMenuItem.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.saveToolStripMenuItem.Name = "saveToolStripMenuItem"
        Me.saveToolStripMenuItem.ShortcutKeys = CType((System.Windows.Forms.Keys.Control Or System.Windows.Forms.Keys.S), System.Windows.Forms.Keys)
        Me.saveToolStripMenuItem.Size = New System.Drawing.Size(181, 26)
        Me.saveToolStripMenuItem.Text = "&Save"
        Me.saveAsToolStripMenuItem.Name = "saveAsToolStripMenuItem"
        Me.saveAsToolStripMenuItem.Size = New System.Drawing.Size(181, 26)
        Me.saveAsToolStripMenuItem.Text = "Save &As"
        Me.toolStripSeparator1.Name = "toolStripSeparator1"
        Me.toolStripSeparator1.Size = New System.Drawing.Size(178, 6)
        Me.printToolStripMenuItem.Image = CType(resources.GetObject("printToolStripMenuItem.Image"), System.Drawing.Image)
        Me.printToolStripMenuItem.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.printToolStripMenuItem.Name = "printToolStripMenuItem"
        Me.printToolStripMenuItem.ShortcutKeys = CType((System.Windows.Forms.Keys.Control Or System.Windows.Forms.Keys.P), System.Windows.Forms.Keys)
        Me.printToolStripMenuItem.Size = New System.Drawing.Size(181, 26)
        Me.printToolStripMenuItem.Text = "&Print"
        Me.printPreviewToolStripMenuItem.Image = CType(resources.GetObject("printPreviewToolStripMenuItem.Image"), System.Drawing.Image)
        Me.printPreviewToolStripMenuItem.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.printPreviewToolStripMenuItem.Name = "printPreviewToolStripMenuItem"
        Me.printPreviewToolStripMenuItem.Size = New System.Drawing.Size(181, 26)
        Me.printPreviewToolStripMenuItem.Text = "Print Pre&view"
        Me.toolStripSeparator2.Name = "toolStripSeparator2"
        Me.toolStripSeparator2.Size = New System.Drawing.Size(178, 6)
        Me.exitToolStripMenuItem.Name = "exitToolStripMenuItem"
        Me.exitToolStripMenuItem.Size = New System.Drawing.Size(181, 26)
        Me.exitToolStripMenuItem.Text = "E&xit"
        Me.editToolStripMenuItem.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() { Me.undoToolStripMenuItem, Me.redoToolStripMenuItem, Me.toolStripSeparator3, Me.cutToolStripMenuItem, Me.copyToolStripMenuItem, Me.pasteToolStripMenuItem, Me.toolStripSeparator4, Me.selectAllToolStripMenuItem})
        Me.editToolStripMenuItem.Name = "editToolStripMenuItem"
        Me.editToolStripMenuItem.Size = New System.Drawing.Size(49, 26)
        Me.editToolStripMenuItem.Text = "&Edit"
        Me.undoToolStripMenuItem.Name = "undoToolStripMenuItem"
        Me.undoToolStripMenuItem.ShortcutKeys = CType((System.Windows.Forms.Keys.Control Or System.Windows.Forms.Keys.Z), System.Windows.Forms.Keys)
        Me.undoToolStripMenuItem.Size = New System.Drawing.Size(179, 26)
        Me.undoToolStripMenuItem.Text = "&Undo"
        Me.redoToolStripMenuItem.Name = "redoToolStripMenuItem"
        Me.redoToolStripMenuItem.ShortcutKeys = CType((System.Windows.Forms.Keys.Control Or System.Windows.Forms.Keys.Y), System.Windows.Forms.Keys)
        Me.redoToolStripMenuItem.Size = New System.Drawing.Size(179, 26)
        Me.redoToolStripMenuItem.Text = "&Redo"
        Me.toolStripSeparator3.Name = "toolStripSeparator3"
        Me.toolStripSeparator3.Size = New System.Drawing.Size(176, 6)
        Me.cutToolStripMenuItem.Image = CType(resources.GetObject("cutToolStripMenuItem.Image"), System.Drawing.Image)
        Me.cutToolStripMenuItem.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.cutToolStripMenuItem.Name = "cutToolStripMenuItem"
        Me.cutToolStripMenuItem.ShortcutKeys = CType((System.Windows.Forms.Keys.Control Or System.Windows.Forms.Keys.X), System.Windows.Forms.Keys)
        Me.cutToolStripMenuItem.Size = New System.Drawing.Size(179, 26)
        Me.cutToolStripMenuItem.Text = "Cu&t"
        Me.copyToolStripMenuItem.Image = CType(resources.GetObject("copyToolStripMenuItem.Image"), System.Drawing.Image)
        Me.copyToolStripMenuItem.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.copyToolStripMenuItem.Name = "copyToolStripMenuItem"
        Me.copyToolStripMenuItem.ShortcutKeys = CType((System.Windows.Forms.Keys.Control Or System.Windows.Forms.Keys.C), System.Windows.Forms.Keys)
        Me.copyToolStripMenuItem.Size = New System.Drawing.Size(179, 26)
        Me.copyToolStripMenuItem.Text = "&Copy"
        Me.pasteToolStripMenuItem.Image = CType(resources.GetObject("pasteToolStripMenuItem.Image"), System.Drawing.Image)
        Me.pasteToolStripMenuItem.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.pasteToolStripMenuItem.Name = "pasteToolStripMenuItem"
        Me.pasteToolStripMenuItem.ShortcutKeys = CType((System.Windows.Forms.Keys.Control Or System.Windows.Forms.Keys.V), System.Windows.Forms.Keys)
        Me.pasteToolStripMenuItem.Size = New System.Drawing.Size(179, 26)
        Me.pasteToolStripMenuItem.Text = "&Paste"
        Me.toolStripSeparator4.Name = "toolStripSeparator4"
        Me.toolStripSeparator4.Size = New System.Drawing.Size(176, 6)
        Me.selectAllToolStripMenuItem.Name = "selectAllToolStripMenuItem"
        Me.selectAllToolStripMenuItem.Size = New System.Drawing.Size(179, 26)
        Me.selectAllToolStripMenuItem.Text = "Select &All"
        Me.toolsToolStripMenuItem.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() { Me.customizeToolStripMenuItem, Me.optionsToolStripMenuItem})
        Me.toolsToolStripMenuItem.Name = "toolsToolStripMenuItem"
        Me.toolsToolStripMenuItem.Size = New System.Drawing.Size(58, 26)
        Me.toolsToolStripMenuItem.Text = "&Tools"
        Me.customizeToolStripMenuItem.Name = "customizeToolStripMenuItem"
        Me.customizeToolStripMenuItem.Size = New System.Drawing.Size(161, 26)
        Me.customizeToolStripMenuItem.Text = "&Customize"
        Me.optionsToolStripMenuItem.Name = "optionsToolStripMenuItem"
        Me.optionsToolStripMenuItem.Size = New System.Drawing.Size(161, 26)
        Me.optionsToolStripMenuItem.Text = "&Options"
        Me.helpToolStripMenuItem.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() { Me.contentsToolStripMenuItem, Me.indexToolStripMenuItem, Me.searchToolStripMenuItem, Me.toolStripSeparator5, Me.aboutToolStripMenuItem})
        Me.helpToolStripMenuItem.Name = "helpToolStripMenuItem"
        Me.helpToolStripMenuItem.Size = New System.Drawing.Size(55, 26)
        Me.helpToolStripMenuItem.Text = "&Help"
        Me.contentsToolStripMenuItem.Name = "contentsToolStripMenuItem"
        Me.contentsToolStripMenuItem.Size = New System.Drawing.Size(150, 26)
        Me.contentsToolStripMenuItem.Text = "&Contents"
        Me.indexToolStripMenuItem.Name = "indexToolStripMenuItem"
        Me.indexToolStripMenuItem.Size = New System.Drawing.Size(150, 26)
        Me.indexToolStripMenuItem.Text = "&Index"
        Me.searchToolStripMenuItem.Name = "searchToolStripMenuItem"
        Me.searchToolStripMenuItem.Size = New System.Drawing.Size(150, 26)
        Me.searchToolStripMenuItem.Text = "&Search"
        Me.toolStripSeparator5.Name = "toolStripSeparator5"
        Me.toolStripSeparator5.Size = New System.Drawing.Size(147, 6)
        Me.aboutToolStripMenuItem.Name = "aboutToolStripMenuItem"
        Me.aboutToolStripMenuItem.Size = New System.Drawing.Size(150, 26)
        Me.aboutToolStripMenuItem.Text = "&About..."
        Me.toolStrip1.Dock = System.Windows.Forms.DockStyle.None
        Me.toolStrip1.Font = New System.Drawing.Font("Segoe UI", 9F)
        Me.toolStrip1.ImageScalingSize = New System.Drawing.Size(20, 20)
        Me.toolStrip1.Items.AddRange(New System.Windows.Forms.ToolStripItem() { Me.newToolStripButton, Me.openToolStripButton, Me.saveToolStripButton, Me.printToolStripButton, Me.toolStripSeparator6, Me.cutToolStripButton, Me.copyToolStripButton, Me.pasteToolStripButton, Me.toolStripSeparator7, Me.helpToolStripButton})
        Me.toolStrip1.Location = New System.Drawing.Point(4, 0)
        Me.toolStrip1.Name = "toolStrip1"
        Me.toolStrip1.Size = New System.Drawing.Size(257, 27)
        Me.toolStrip1.TabIndex = 1
        Me.toolStrip1.Text = "toolStrip1"
        Me.newToolStripButton.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image
        Me.newToolStripButton.Image = CType(resources.GetObject("newToolStripButton.Image"), System.Drawing.Image)
        Me.newToolStripButton.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.newToolStripButton.Name = "newToolStripButton"
        Me.newToolStripButton.Size = New System.Drawing.Size(29, 24)
        Me.newToolStripButton.Text = "&New"
        Me.openToolStripButton.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image
        Me.openToolStripButton.Image = CType(resources.GetObject("openToolStripButton.Image"), System.Drawing.Image)
        Me.openToolStripButton.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.openToolStripButton.Name = "openToolStripButton"
        Me.openToolStripButton.Size = New System.Drawing.Size(29, 24)
        Me.openToolStripButton.Text = "&Open"
        Me.saveToolStripButton.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image
        Me.saveToolStripButton.Image = CType(resources.GetObject("saveToolStripButton.Image"), System.Drawing.Image)
        Me.saveToolStripButton.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.saveToolStripButton.Name = "saveToolStripButton"
        Me.saveToolStripButton.Size = New System.Drawing.Size(29, 24)
        Me.saveToolStripButton.Text = "&Save"
        Me.printToolStripButton.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image
        Me.printToolStripButton.Image = CType(resources.GetObject("printToolStripButton.Image"), System.Drawing.Image)
        Me.printToolStripButton.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.printToolStripButton.Name = "printToolStripButton"
        Me.printToolStripButton.Size = New System.Drawing.Size(29, 24)
        Me.printToolStripButton.Text = "&Print"
        Me.toolStripSeparator6.Name = "toolStripSeparator6"
        Me.toolStripSeparator6.Size = New System.Drawing.Size(6, 27)
        Me.cutToolStripButton.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image
        Me.cutToolStripButton.Image = CType(resources.GetObject("cutToolStripButton.Image"), System.Drawing.Image)
        Me.cutToolStripButton.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.cutToolStripButton.Name = "cutToolStripButton"
        Me.cutToolStripButton.Size = New System.Drawing.Size(29, 24)
        Me.cutToolStripButton.Text = "C&ut"
        Me.copyToolStripButton.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image
        Me.copyToolStripButton.Image = CType(resources.GetObject("copyToolStripButton.Image"), System.Drawing.Image)
        Me.copyToolStripButton.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.copyToolStripButton.Name = "copyToolStripButton"
        Me.copyToolStripButton.Size = New System.Drawing.Size(29, 24)
        Me.copyToolStripButton.Text = "&Copy"
        Me.pasteToolStripButton.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image
        Me.pasteToolStripButton.Image = CType(resources.GetObject("pasteToolStripButton.Image"), System.Drawing.Image)
        Me.pasteToolStripButton.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.pasteToolStripButton.Name = "pasteToolStripButton"
        Me.pasteToolStripButton.Size = New System.Drawing.Size(29, 24)
        Me.pasteToolStripButton.Text = "&Paste"
        Me.toolStripSeparator7.Name = "toolStripSeparator7"
        Me.toolStripSeparator7.Size = New System.Drawing.Size(6, 27)
        Me.helpToolStripButton.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image
        Me.helpToolStripButton.Image = CType(resources.GetObject("helpToolStripButton.Image"), System.Drawing.Image)
        Me.helpToolStripButton.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.helpToolStripButton.Name = "helpToolStripButton"
        Me.helpToolStripButton.Size = New System.Drawing.Size(29, 24)
        Me.helpToolStripButton.Text = "He&lp"
        Me.toolStripContainer1.ContentPanel.Controls.Add(Me.kryptonPanelMain)
        Me.toolStripContainer1.ContentPanel.Size = New System.Drawing.Size(459, 347)
        Me.toolStripContainer1.Dock = System.Windows.Forms.DockStyle.Fill
        Me.toolStripContainer1.Location = New System.Drawing.Point(0, 30)
        Me.toolStripContainer1.Name = "toolStripContainer1"
        Me.toolStripContainer1.Size = New System.Drawing.Size(459, 374)
        Me.toolStripContainer1.TabIndex = 1
        Me.toolStripContainer1.Text = "toolStripContainer1"
        Me.toolStripContainer1.TopToolStripPanel.Controls.Add(Me.toolStrip1)
        Me.kryptonPanelMain.Controls.Add(Me.kryptonSplitContainerMain)
        Me.kryptonPanelMain.Dock = System.Windows.Forms.DockStyle.Fill
        Me.kryptonPanelMain.Location = New System.Drawing.Point(0, 0)
        Me.kryptonPanelMain.Name = "kryptonPanelMain"
        Me.kryptonPanelMain.Padding = New System.Windows.Forms.Padding(4)
        Me.kryptonPanelMain.Size = New System.Drawing.Size(459, 347)
        Me.kryptonPanelMain.TabIndex = 0
        Me.kryptonSplitContainerMain.Cursor = System.Windows.Forms.Cursors.Default
        Me.kryptonSplitContainerMain.Dock = System.Windows.Forms.DockStyle.Fill
        Me.kryptonSplitContainerMain.Location = New System.Drawing.Point(4, 4)
        Me.kryptonSplitContainerMain.Panel1.Controls.Add(Me.kryptonHeaderGroupNavigation)
        Me.kryptonSplitContainerMain.Panel2.Controls.Add(Me.kryptonSplitContainerDetails)
        Me.kryptonSplitContainerMain.Size = New System.Drawing.Size(451, 339)
        Me.kryptonSplitContainerMain.SplitterDistance = 127
        Me.kryptonSplitContainerMain.TabIndex = 0
        Me.kryptonHeaderGroupNavigation.Dock = System.Windows.Forms.DockStyle.Fill
        Me.kryptonHeaderGroupNavigation.Location = New System.Drawing.Point(0, 0)
        Me.kryptonHeaderGroupNavigation.Size = New System.Drawing.Size(127, 339)
        Me.kryptonHeaderGroupNavigation.TabIndex = 0
        Me.kryptonHeaderGroupNavigation.ValuesPrimary.Image = Nothing
        Me.kryptonSplitContainerDetails.Cursor = System.Windows.Forms.Cursors.Default
        Me.kryptonSplitContainerDetails.Dock = System.Windows.Forms.DockStyle.Fill
        Me.kryptonSplitContainerDetails.Location = New System.Drawing.Point(0, 0)
        Me.kryptonSplitContainerDetails.Orientation = System.Windows.Forms.Orientation.Horizontal
        Me.kryptonSplitContainerDetails.Panel1.Controls.Add(Me.kryptonHeaderGroupDetails)
        Me.kryptonSplitContainerDetails.Panel2.Controls.Add(Me.kryptonButtonGroup)
        Me.kryptonSplitContainerDetails.Size = New System.Drawing.Size(319, 339)
        Me.kryptonSplitContainerDetails.SplitterDistance = 146
        Me.kryptonSplitContainerDetails.TabIndex = 0
        Me.kryptonHeaderGroupDetails.Dock = System.Windows.Forms.DockStyle.Fill
        Me.kryptonHeaderGroupDetails.HeaderVisibleSecondary = False
        Me.kryptonHeaderGroupDetails.Location = New System.Drawing.Point(0, 0)
        Me.kryptonHeaderGroupDetails.Size = New System.Drawing.Size(319, 146)
        Me.kryptonHeaderGroupDetails.StateNormal.HeaderPrimary.Content.Image.ImageH = Krypton.Toolkit.PaletteRelativeAlign.Far
        Me.kryptonHeaderGroupDetails.TabIndex = 0
        Me.kryptonHeaderGroupDetails.ValuesPrimary.Image = CType(resources.GetObject("kryptonHeaderGroupDetails.ValuesPrimary.Image"), System.Drawing.Image)
        Me.kryptonButtonGroup.Dock = System.Windows.Forms.DockStyle.Fill
        Me.kryptonButtonGroup.GroupBackStyle = Krypton.Toolkit.PaletteBackStyle.ControlAlternate
        Me.kryptonButtonGroup.GroupBorderStyle = Krypton.Toolkit.PaletteBorderStyle.ControlAlternate
        Me.kryptonButtonGroup.Location = New System.Drawing.Point(0, 0)
        Me.kryptonButtonGroup.Panel.Controls.Add(Me.kryptonGroup1)
        Me.kryptonButtonGroup.Size = New System.Drawing.Size(319, 188)
        Me.kryptonButtonGroup.StateCommon.Back.Color1 = System.Drawing.SystemColors.AppWorkspace
        Me.kryptonButtonGroup.StateCommon.Back.ColorAngle = 45F
        Me.kryptonButtonGroup.StateCommon.Back.ColorStyle = Krypton.Toolkit.PaletteColorStyle.Solid
        Me.kryptonButtonGroup.TabIndex = 0
        Me.kryptonGroup1.Dock = System.Windows.Forms.DockStyle.Fill
        Me.kryptonGroup1.Location = New System.Drawing.Point(0, 0)
        Me.kryptonGroup1.Panel.Controls.Add(Me.kryptonOffice2010Black)
        Me.kryptonGroup1.Panel.Controls.Add(Me.kryptonSparkleOrange)
        Me.kryptonGroup1.Panel.Controls.Add(Me.kryptonOffice2010Blue)
        Me.kryptonGroup1.Panel.Controls.Add(Me.kryptonOffice2010Silver)
        Me.kryptonGroup1.Panel.Controls.Add(Me.kryptonSparklePurple)
        Me.kryptonGroup1.Panel.Controls.Add(Me.kryptonSparkleBlue)
        Me.kryptonGroup1.Panel.Controls.Add(Me.kryptonCustom)
        Me.kryptonGroup1.Panel.Controls.Add(Me.kryptonSystem)
        Me.kryptonGroup1.Panel.Controls.Add(Me.kryptonOffice2003)
        Me.kryptonGroup1.Panel.Controls.Add(Me.kryptonOffice2007Black)
        Me.kryptonGroup1.Panel.Controls.Add(Me.kryptonOffice2007Silver)
        Me.kryptonGroup1.Panel.Controls.Add(Me.kryptonOffice2007Blue)
        Me.kryptonGroup1.Panel.Controls.Add(Me.kryptonOffice2013White)
        Me.kryptonGroup1.Size = New System.Drawing.Size(317, 186)
        Me.kryptonGroup1.TabIndex = 0
        Me.kryptonOffice2010Black.Location = New System.Drawing.Point(13, 62)
        Me.kryptonOffice2010Black.Name = "kryptonOffice2010Black"
        Me.kryptonOffice2010Black.Size = New System.Drawing.Size(151, 24)
        Me.kryptonOffice2010Black.TabIndex = 2
        Me.kryptonOffice2010Black.Values.Text = "Office 2010 - Black"
        Me.kryptonSparkleOrange.Location = New System.Drawing.Point(13, 123)
        Me.kryptonSparkleOrange.Name = "kryptonSparkleOrange"
        Me.kryptonSparkleOrange.Size = New System.Drawing.Size(139, 24)
        Me.kryptonSparkleOrange.TabIndex = 7
        Me.kryptonSparkleOrange.Values.Text = "Sparkle - Orange"
        Me.kryptonOffice2010Blue.Checked = True
        Me.kryptonOffice2010Blue.Location = New System.Drawing.Point(13, 15)
        Me.kryptonOffice2010Blue.Name = "kryptonOffice2010Blue"
        Me.kryptonOffice2010Blue.Size = New System.Drawing.Size(145, 24)
        Me.kryptonOffice2010Blue.TabIndex = 0
        Me.kryptonOffice2010Blue.Values.Text = "Office 2010 - Blue"
        Me.kryptonOffice2010Silver.Location = New System.Drawing.Point(13, 39)
        Me.kryptonOffice2010Silver.Name = "kryptonOffice2010Silver"
        Me.kryptonOffice2010Silver.Size = New System.Drawing.Size(153, 24)
        Me.kryptonOffice2010Silver.TabIndex = 1
        Me.kryptonOffice2010Silver.Values.Text = "Office 2010 - Silver"
        Me.kryptonSparklePurple.Location = New System.Drawing.Point(13, 145)
        Me.kryptonSparklePurple.Name = "kryptonSparklePurple"
        Me.kryptonSparklePurple.Size = New System.Drawing.Size(132, 24)
        Me.kryptonSparklePurple.TabIndex = 8
        Me.kryptonSparklePurple.Values.Text = "Sparkle - Purple"
        Me.kryptonSparkleBlue.Location = New System.Drawing.Point(13, 103)
        Me.kryptonSparkleBlue.Name = "kryptonSparkleBlue"
        Me.kryptonSparkleBlue.Size = New System.Drawing.Size(118, 24)
        Me.kryptonSparkleBlue.TabIndex = 6
        Me.kryptonSparkleBlue.Values.Text = "Sparkle - Blue"
        Me.kryptonCustom.Location = New System.Drawing.Point(147, 122)
        Me.kryptonCustom.Name = "kryptonCustom"
        Me.kryptonCustom.Size = New System.Drawing.Size(76, 24)
        Me.kryptonCustom.TabIndex = 11
        Me.kryptonCustom.Values.Text = "Custom"
        Me.kryptonSystem.Location = New System.Drawing.Point(147, 101)
        Me.kryptonSystem.Name = "kryptonSystem"
        Me.kryptonSystem.Size = New System.Drawing.Size(72, 24)
        Me.kryptonSystem.TabIndex = 10
        Me.kryptonSystem.Values.Text = "System"
        Me.kryptonOffice2003.Location = New System.Drawing.Point(147, 80)
        Me.kryptonOffice2003.Name = "kryptonOffice2003"
        Me.kryptonOffice2003.Size = New System.Drawing.Size(101, 24)
        Me.kryptonOffice2003.TabIndex = 9
        Me.kryptonOffice2003.Values.Text = "Office 2003"
        Me.kryptonOffice2007Black.Location = New System.Drawing.Point(147, 62)
        Me.kryptonOffice2007Black.Name = "kryptonOffice2007Black"
        Me.kryptonOffice2007Black.Size = New System.Drawing.Size(151, 24)
        Me.kryptonOffice2007Black.TabIndex = 5
        Me.kryptonOffice2007Black.Values.Text = "Office 2007 - Black"
        Me.kryptonOffice2007Silver.Location = New System.Drawing.Point(147, 39)
        Me.kryptonOffice2007Silver.Name = "kryptonOffice2007Silver"
        Me.kryptonOffice2007Silver.Size = New System.Drawing.Size(153, 24)
        Me.kryptonOffice2007Silver.TabIndex = 4
        Me.kryptonOffice2007Silver.Values.Text = "Office 2007 - Silver"
        Me.kryptonOffice2007Blue.Location = New System.Drawing.Point(147, 15)
        Me.kryptonOffice2007Blue.Name = "kryptonOffice2007Blue"
        Me.kryptonOffice2007Blue.Size = New System.Drawing.Size(145, 24)
        Me.kryptonOffice2007Blue.TabIndex = 3
        Me.kryptonOffice2007Blue.Values.Text = "Office 2007 - Blue"
        Me.kryptonOffice2013White.Location = New System.Drawing.Point(12, 80)
        Me.kryptonOffice2013White.Name = "kryptonOffice2013White"
        Me.kryptonOffice2013White.Size = New System.Drawing.Size(156, 24)
        Me.kryptonOffice2013White.TabIndex = 4
        Me.kryptonOffice2013White.Values.Text = "Office 2013 - White"
        Me.kryptonManager.GlobalPaletteMode = Krypton.Toolkit.PaletteMode.Office2007Blue
        Me.kryptonPaletteCustom.ButtonStyles.ButtonButtonSpec.StateDisabled.Border.Draw = Krypton.Toolkit.InheritBool.False
        Me.kryptonPaletteCustom.ButtonStyles.ButtonButtonSpec.StateDisabled.Border.DrawBorders = CType((((Krypton.Toolkit.PaletteDrawBorders.Top Or Krypton.Toolkit.PaletteDrawBorders.Bottom) Or Krypton.Toolkit.PaletteDrawBorders.Left) Or Krypton.Toolkit.PaletteDrawBorders.Right), Krypton.Toolkit.PaletteDrawBorders)
        Me.kryptonPaletteCustom.ButtonStyles.ButtonButtonSpec.StateNormal.Back.Draw = Krypton.Toolkit.InheritBool.False
        Me.kryptonPaletteCustom.ButtonStyles.ButtonButtonSpec.StateNormal.Border.Color1 = System.Drawing.Color.Transparent
        Me.kryptonPaletteCustom.ButtonStyles.ButtonButtonSpec.StateNormal.Border.Draw = Krypton.Toolkit.InheritBool.True
        Me.kryptonPaletteCustom.ButtonStyles.ButtonButtonSpec.StateNormal.Border.DrawBorders = CType((((Krypton.Toolkit.PaletteDrawBorders.Top Or Krypton.Toolkit.PaletteDrawBorders.Bottom) Or Krypton.Toolkit.PaletteDrawBorders.Left) Or Krypton.Toolkit.PaletteDrawBorders.Right), Krypton.Toolkit.PaletteDrawBorders)
        Me.kryptonPaletteCustom.ButtonStyles.ButtonButtonSpec.StateNormal.Content.LongText.Color1 = System.Drawing.Color.Black
        Me.kryptonPaletteCustom.ButtonStyles.ButtonButtonSpec.StateNormal.Content.Padding = New System.Windows.Forms.Padding(3)
        Me.kryptonPaletteCustom.ButtonStyles.ButtonButtonSpec.StateNormal.Content.ShortText.Color1 = System.Drawing.Color.Black
        Me.kryptonPaletteCustom.ButtonStyles.ButtonCommon.StateCheckedNormal.Back.Color1 = System.Drawing.Color.FromArgb(CType(CType(192, Byte), Integer), CType(CType(64, Byte), Integer), CType(CType(0, Byte), Integer))
        Me.kryptonPaletteCustom.ButtonStyles.ButtonCommon.StateCheckedPressed.Back.Color1 = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(102, Byte), Integer), CType(CType(0, Byte), Integer))
        Me.kryptonPaletteCustom.ButtonStyles.ButtonCommon.StateCheckedPressed.Content.Padding = New System.Windows.Forms.Padding(5, 5, 1, 1)
        Me.kryptonPaletteCustom.ButtonStyles.ButtonCommon.StateCheckedTracking.Back.Color1 = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(102, Byte), Integer), CType(CType(0, Byte), Integer))
        Me.kryptonPaletteCustom.ButtonStyles.ButtonCommon.StateCommon.Back.ColorStyle = Krypton.Toolkit.PaletteColorStyle.Solid
        Me.kryptonPaletteCustom.ButtonStyles.ButtonCommon.StateCommon.Border.Color1 = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(51, Byte), Integer), CType(CType(102, Byte), Integer))
        Me.kryptonPaletteCustom.ButtonStyles.ButtonCommon.StateCommon.Border.ColorStyle = Krypton.Toolkit.PaletteColorStyle.Solid
        Me.kryptonPaletteCustom.ButtonStyles.ButtonCommon.StateCommon.Border.DrawBorders = CType((((Krypton.Toolkit.PaletteDrawBorders.Top Or Krypton.Toolkit.PaletteDrawBorders.Bottom) Or Krypton.Toolkit.PaletteDrawBorders.Left) Or Krypton.Toolkit.PaletteDrawBorders.Right), Krypton.Toolkit.PaletteDrawBorders)
        Me.kryptonPaletteCustom.ButtonStyles.ButtonCommon.StateCommon.Border.GraphicsHint = Krypton.Toolkit.PaletteGraphicsHint.AntiAlias
        Me.kryptonPaletteCustom.ButtonStyles.ButtonCommon.StateCommon.Border.Rounding = 3F
        Me.kryptonPaletteCustom.ButtonStyles.ButtonCommon.StateCommon.Border.Width = 2
        Me.kryptonPaletteCustom.ButtonStyles.ButtonCommon.StateCommon.Content.LongText.Color1 = System.Drawing.Color.White
        Me.kryptonPaletteCustom.ButtonStyles.ButtonCommon.StateCommon.Content.LongText.ColorStyle = Krypton.Toolkit.PaletteColorStyle.Solid
        Me.kryptonPaletteCustom.ButtonStyles.ButtonCommon.StateCommon.Content.Padding = New System.Windows.Forms.Padding(3)
        Me.kryptonPaletteCustom.ButtonStyles.ButtonCommon.StateCommon.Content.ShortText.Color1 = System.Drawing.Color.White
        Me.kryptonPaletteCustom.ButtonStyles.ButtonCommon.StateCommon.Content.ShortText.ColorStyle = Krypton.Toolkit.PaletteColorStyle.Solid
        Me.kryptonPaletteCustom.ButtonStyles.ButtonCommon.StateDisabled.Border.Color1 = System.Drawing.Color.Silver
        Me.kryptonPaletteCustom.ButtonStyles.ButtonCommon.StateDisabled.Border.DrawBorders = CType((((Krypton.Toolkit.PaletteDrawBorders.Top Or Krypton.Toolkit.PaletteDrawBorders.Bottom) Or Krypton.Toolkit.PaletteDrawBorders.Left) Or Krypton.Toolkit.PaletteDrawBorders.Right), Krypton.Toolkit.PaletteDrawBorders)
        Me.kryptonPaletteCustom.ButtonStyles.ButtonCommon.StateDisabled.Content.LongText.Color1 = System.Drawing.Color.Silver
        Me.kryptonPaletteCustom.ButtonStyles.ButtonCommon.StateDisabled.Content.ShortText.Color1 = System.Drawing.Color.Silver
        Me.kryptonPaletteCustom.ButtonStyles.ButtonCommon.StateNormal.Back.Color1 = System.Drawing.Color.FromArgb(CType(CType(51, Byte), Integer), CType(CType(102, Byte), Integer), CType(CType(204, Byte), Integer))
        Me.kryptonPaletteCustom.ButtonStyles.ButtonCommon.StatePressed.Back.Color1 = System.Drawing.Color.FromArgb(CType(CType(102, Byte), Integer), CType(CType(153, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.kryptonPaletteCustom.ButtonStyles.ButtonCommon.StatePressed.Content.Padding = New System.Windows.Forms.Padding(5, 5, 1, 1)
        Me.kryptonPaletteCustom.ButtonStyles.ButtonCommon.StateTracking.Back.Color1 = System.Drawing.Color.FromArgb(CType(CType(102, Byte), Integer), CType(CType(153, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.kryptonPaletteCustom.ButtonStyles.ButtonLowProfile.StateDisabled.Border.Draw = Krypton.Toolkit.InheritBool.False
        Me.kryptonPaletteCustom.ButtonStyles.ButtonLowProfile.StateDisabled.Border.DrawBorders = CType((((Krypton.Toolkit.PaletteDrawBorders.Top Or Krypton.Toolkit.PaletteDrawBorders.Bottom) Or Krypton.Toolkit.PaletteDrawBorders.Left) Or Krypton.Toolkit.PaletteDrawBorders.Right), Krypton.Toolkit.PaletteDrawBorders)
        Me.kryptonPaletteCustom.ButtonStyles.ButtonLowProfile.StateNormal.Back.Draw = Krypton.Toolkit.InheritBool.False
        Me.kryptonPaletteCustom.ButtonStyles.ButtonLowProfile.StateNormal.Border.Color1 = System.Drawing.Color.Transparent
        Me.kryptonPaletteCustom.ButtonStyles.ButtonLowProfile.StateNormal.Border.Draw = Krypton.Toolkit.InheritBool.True
        Me.kryptonPaletteCustom.ButtonStyles.ButtonLowProfile.StateNormal.Border.DrawBorders = CType((((Krypton.Toolkit.PaletteDrawBorders.Top Or Krypton.Toolkit.PaletteDrawBorders.Bottom) Or Krypton.Toolkit.PaletteDrawBorders.Left) Or Krypton.Toolkit.PaletteDrawBorders.Right), Krypton.Toolkit.PaletteDrawBorders)
        Me.kryptonPaletteCustom.ButtonStyles.ButtonLowProfile.StateNormal.Content.LongText.Color1 = System.Drawing.Color.Black
        Me.kryptonPaletteCustom.ButtonStyles.ButtonLowProfile.StateNormal.Content.Padding = New System.Windows.Forms.Padding(3)
        Me.kryptonPaletteCustom.ButtonStyles.ButtonLowProfile.StateNormal.Content.ShortText.Color1 = System.Drawing.Color.Black
        Me.kryptonPaletteCustom.ButtonStyles.ButtonStandalone.OverrideDefault.Back.Color1 = System.Drawing.Color.FromArgb(CType(CType(51, Byte), Integer), CType(CType(102, Byte), Integer), CType(CType(204, Byte), Integer))
        Me.kryptonPaletteCustom.ButtonStyles.ButtonStandalone.StateDisabled.Back.Color1 = System.Drawing.Color.FromArgb(CType(CType(245, Byte), Integer), CType(CType(237, Byte), Integer), CType(CType(227, Byte), Integer))
        Me.kryptonPaletteCustom.ControlStyles.ControlCommon.StateCommon.Border.ColorStyle = Krypton.Toolkit.PaletteColorStyle.Solid
        Me.kryptonPaletteCustom.ControlStyles.ControlCommon.StateCommon.Border.DrawBorders = CType((((Krypton.Toolkit.PaletteDrawBorders.Top Or Krypton.Toolkit.PaletteDrawBorders.Bottom) Or Krypton.Toolkit.PaletteDrawBorders.Left) Or Krypton.Toolkit.PaletteDrawBorders.Right), Krypton.Toolkit.PaletteDrawBorders)
        Me.kryptonPaletteCustom.ControlStyles.ControlCommon.StateCommon.Border.GraphicsHint = Krypton.Toolkit.PaletteGraphicsHint.AntiAlias
        Me.kryptonPaletteCustom.ControlStyles.ControlCommon.StateCommon.Border.Rounding = 9F
        Me.kryptonPaletteCustom.ControlStyles.ControlCommon.StateCommon.Border.Width = 3
        Me.kryptonPaletteCustom.ControlStyles.ControlCommon.StateDisabled.Border.Color1 = System.Drawing.Color.FromArgb(CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer))
        Me.kryptonPaletteCustom.ControlStyles.ControlCommon.StateDisabled.Border.DrawBorders = CType((((Krypton.Toolkit.PaletteDrawBorders.Top Or Krypton.Toolkit.PaletteDrawBorders.Bottom) Or Krypton.Toolkit.PaletteDrawBorders.Left) Or Krypton.Toolkit.PaletteDrawBorders.Right), Krypton.Toolkit.PaletteDrawBorders)
        Me.kryptonPaletteCustom.ControlStyles.ControlCommon.StateNormal.Border.Color1 = System.Drawing.Color.FromArgb(CType(CType(225, Byte), Integer), CType(CType(212, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.kryptonPaletteCustom.ControlStyles.ControlCommon.StateNormal.Border.DrawBorders = CType((((Krypton.Toolkit.PaletteDrawBorders.Top Or Krypton.Toolkit.PaletteDrawBorders.Bottom) Or Krypton.Toolkit.PaletteDrawBorders.Left) Or Krypton.Toolkit.PaletteDrawBorders.Right), Krypton.Toolkit.PaletteDrawBorders)
        Me.kryptonPaletteCustom.HeaderGroup.StateCommon.OverlayHeaders = Krypton.Toolkit.InheritBool.False
        Me.kryptonPaletteCustom.HeaderGroup.StateCommon.PrimaryHeaderPadding = New System.Windows.Forms.Padding(3)
        Me.kryptonPaletteCustom.HeaderGroup.StateCommon.SecondaryHeaderPadding = New System.Windows.Forms.Padding(3)
        Me.kryptonPaletteCustom.HeaderStyles.HeaderCommon.StateCommon.Back.ColorStyle = Krypton.Toolkit.PaletteColorStyle.Linear
        Me.kryptonPaletteCustom.HeaderStyles.HeaderCommon.StateCommon.Back.GraphicsHint = Krypton.Toolkit.PaletteGraphicsHint.AntiAlias
        Me.kryptonPaletteCustom.HeaderStyles.HeaderCommon.StateCommon.Border.Draw = Krypton.Toolkit.InheritBool.False
        Me.kryptonPaletteCustom.HeaderStyles.HeaderCommon.StateCommon.Border.DrawBorders = CType((((Krypton.Toolkit.PaletteDrawBorders.Top Or Krypton.Toolkit.PaletteDrawBorders.Bottom) Or Krypton.Toolkit.PaletteDrawBorders.Left) Or Krypton.Toolkit.PaletteDrawBorders.Right), Krypton.Toolkit.PaletteDrawBorders)
        Me.kryptonPaletteCustom.HeaderStyles.HeaderCommon.StateCommon.Border.Rounding = 7F
        Me.kryptonPaletteCustom.HeaderStyles.HeaderCommon.StateCommon.Border.Width = 3
        Me.kryptonPaletteCustom.HeaderStyles.HeaderCommon.StateCommon.Content.AdjacentGap = 2
        Me.kryptonPaletteCustom.HeaderStyles.HeaderCommon.StateCommon.Content.LongText.Color1 = System.Drawing.Color.Black
        Me.kryptonPaletteCustom.HeaderStyles.HeaderCommon.StateCommon.Content.LongText.ColorStyle = Krypton.Toolkit.PaletteColorStyle.Solid
        Me.kryptonPaletteCustom.HeaderStyles.HeaderCommon.StateCommon.Content.LongText.TextH = Krypton.Toolkit.PaletteRelativeAlign.Far
        Me.kryptonPaletteCustom.HeaderStyles.HeaderCommon.StateCommon.Content.Padding = New System.Windows.Forms.Padding(10, 2, 10, 2)
        Me.kryptonPaletteCustom.HeaderStyles.HeaderCommon.StateCommon.Content.ShortText.Color1 = System.Drawing.Color.Black
        Me.kryptonPaletteCustom.HeaderStyles.HeaderCommon.StateCommon.Content.ShortText.ColorStyle = Krypton.Toolkit.PaletteColorStyle.Solid
        Me.kryptonPaletteCustom.HeaderStyles.HeaderCommon.StateCommon.Content.ShortText.TextH = Krypton.Toolkit.PaletteRelativeAlign.Near
        Me.kryptonPaletteCustom.HeaderStyles.HeaderCommon.StateDisabled.Content.LongText.Color1 = System.Drawing.Color.Silver
        Me.kryptonPaletteCustom.HeaderStyles.HeaderCommon.StateDisabled.Content.ShortText.Color1 = System.Drawing.Color.Silver
        Me.kryptonPaletteCustom.HeaderStyles.HeaderPrimary.StateDisabled.Back.Color1 = System.Drawing.Color.FromArgb(CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer))
        Me.kryptonPaletteCustom.HeaderStyles.HeaderPrimary.StateDisabled.Back.Color2 = System.Drawing.Color.White
        Me.kryptonPaletteCustom.HeaderStyles.HeaderPrimary.StateNormal.Back.Color1 = System.Drawing.Color.FromArgb(CType(CType(226, Byte), Integer), CType(CType(213, Byte), Integer), CType(CType(194, Byte), Integer))
        Me.kryptonPaletteCustom.HeaderStyles.HeaderPrimary.StateNormal.Back.Color2 = System.Drawing.Color.White
        Me.kryptonPaletteCustom.HeaderStyles.HeaderSecondary.StateDisabled.Back.Color1 = System.Drawing.Color.White
        Me.kryptonPaletteCustom.HeaderStyles.HeaderSecondary.StateDisabled.Back.Color2 = System.Drawing.Color.FromArgb(CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer))
        Me.kryptonPaletteCustom.HeaderStyles.HeaderSecondary.StateNormal.Back.Color1 = System.Drawing.Color.White
        Me.kryptonPaletteCustom.HeaderStyles.HeaderSecondary.StateNormal.Back.Color2 = System.Drawing.Color.FromArgb(CType(CType(226, Byte), Integer), CType(CType(213, Byte), Integer), CType(CType(194, Byte), Integer))
        Me.kryptonPaletteCustom.PanelStyles.PanelAlternate.StateCommon.Color1 = System.Drawing.Color.FromArgb(CType(CType(225, Byte), Integer), CType(CType(212, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.kryptonPaletteCustom.PanelStyles.PanelClient.StateCommon.Color1 = System.Drawing.Color.FromArgb(CType(CType(245, Byte), Integer), CType(CType(237, Byte), Integer), CType(CType(227, Byte), Integer))
        Me.kryptonPaletteCustom.PanelStyles.PanelCommon.StateCommon.ColorStyle = Krypton.Toolkit.PaletteColorStyle.Solid
        Me.kryptonPaletteCustom.ToolMenuStatus.Button.ButtonCheckedGradientBegin = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(102, Byte), Integer), CType(CType(0, Byte), Integer))
        Me.kryptonPaletteCustom.ToolMenuStatus.Button.ButtonCheckedGradientEnd = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(102, Byte), Integer), CType(CType(0, Byte), Integer))
        Me.kryptonPaletteCustom.ToolMenuStatus.Button.ButtonCheckedGradientMiddle = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(102, Byte), Integer), CType(CType(0, Byte), Integer))
        Me.kryptonPaletteCustom.ToolMenuStatus.Button.ButtonCheckedHighlight = System.Drawing.Color.FromArgb(CType(CType(192, Byte), Integer), CType(CType(64, Byte), Integer), CType(CType(0, Byte), Integer))
        Me.kryptonPaletteCustom.ToolMenuStatus.Button.ButtonCheckedHighlightBorder = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(51, Byte), Integer), CType(CType(102, Byte), Integer))
        Me.kryptonPaletteCustom.ToolMenuStatus.Button.ButtonPressedBorder = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(51, Byte), Integer), CType(CType(102, Byte), Integer))
        Me.kryptonPaletteCustom.ToolMenuStatus.Button.ButtonPressedGradientBegin = System.Drawing.Color.FromArgb(CType(CType(192, Byte), Integer), CType(CType(64, Byte), Integer), CType(CType(0, Byte), Integer))
        Me.kryptonPaletteCustom.ToolMenuStatus.Button.ButtonPressedGradientEnd = System.Drawing.Color.FromArgb(CType(CType(192, Byte), Integer), CType(CType(64, Byte), Integer), CType(CType(0, Byte), Integer))
        Me.kryptonPaletteCustom.ToolMenuStatus.Button.ButtonPressedGradientMiddle = System.Drawing.Color.FromArgb(CType(CType(192, Byte), Integer), CType(CType(64, Byte), Integer), CType(CType(0, Byte), Integer))
        Me.kryptonPaletteCustom.ToolMenuStatus.Button.ButtonPressedHighlight = System.Drawing.Color.FromArgb(CType(CType(192, Byte), Integer), CType(CType(64, Byte), Integer), CType(CType(0, Byte), Integer))
        Me.kryptonPaletteCustom.ToolMenuStatus.Button.ButtonPressedHighlightBorder = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(51, Byte), Integer), CType(CType(102, Byte), Integer))
        Me.kryptonPaletteCustom.ToolMenuStatus.Button.ButtonSelectedBorder = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(51, Byte), Integer), CType(CType(102, Byte), Integer))
        Me.kryptonPaletteCustom.ToolMenuStatus.Button.ButtonSelectedGradientBegin = System.Drawing.Color.FromArgb(CType(CType(102, Byte), Integer), CType(CType(153, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.kryptonPaletteCustom.ToolMenuStatus.Button.ButtonSelectedGradientEnd = System.Drawing.Color.FromArgb(CType(CType(102, Byte), Integer), CType(CType(153, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.kryptonPaletteCustom.ToolMenuStatus.Button.ButtonSelectedGradientMiddle = System.Drawing.Color.FromArgb(CType(CType(102, Byte), Integer), CType(CType(153, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.kryptonPaletteCustom.ToolMenuStatus.Button.ButtonSelectedHighlight = System.Drawing.Color.FromArgb(CType(CType(102, Byte), Integer), CType(CType(153, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.kryptonPaletteCustom.ToolMenuStatus.Button.ButtonSelectedHighlightBorder = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(51, Byte), Integer), CType(CType(102, Byte), Integer))
        Me.kryptonPaletteCustom.ToolMenuStatus.Button.CheckBackground = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(102, Byte), Integer), CType(CType(0, Byte), Integer))
        Me.kryptonPaletteCustom.ToolMenuStatus.Button.CheckPressedBackground = System.Drawing.Color.FromArgb(CType(CType(192, Byte), Integer), CType(CType(64, Byte), Integer), CType(CType(0, Byte), Integer))
        Me.kryptonPaletteCustom.ToolMenuStatus.Button.CheckSelectedBackground = System.Drawing.Color.FromArgb(CType(CType(192, Byte), Integer), CType(CType(64, Byte), Integer), CType(CType(0, Byte), Integer))
        Me.kryptonPaletteCustom.ToolMenuStatus.Button.OverflowButtonGradientBegin = System.Drawing.Color.FromArgb(CType(CType(102, Byte), Integer), CType(CType(153, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.kryptonPaletteCustom.ToolMenuStatus.Button.OverflowButtonGradientEnd = System.Drawing.Color.FromArgb(CType(CType(26, Byte), Integer), CType(CType(77, Byte), Integer), CType(CType(144, Byte), Integer))
        Me.kryptonPaletteCustom.ToolMenuStatus.Button.OverflowButtonGradientMiddle = System.Drawing.Color.FromArgb(CType(CType(76, Byte), Integer), CType(CType(126, Byte), Integer), CType(CType(226, Byte), Integer))
        Me.kryptonPaletteCustom.ToolMenuStatus.Grip.GripDark = System.Drawing.Color.FromArgb(CType(CType(72, Byte), Integer), CType(CType(133, Byte), Integer), CType(CType(215, Byte), Integer))
        Me.kryptonPaletteCustom.ToolMenuStatus.Grip.GripLight = System.Drawing.Color.Transparent
        Me.kryptonPaletteCustom.ToolMenuStatus.Menu.ImageMarginGradientBegin = System.Drawing.Color.FromArgb(CType(CType(102, Byte), Integer), CType(CType(153, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.kryptonPaletteCustom.ToolMenuStatus.Menu.ImageMarginGradientEnd = System.Drawing.Color.FromArgb(CType(CType(51, Byte), Integer), CType(CType(102, Byte), Integer), CType(CType(204, Byte), Integer))
        Me.kryptonPaletteCustom.ToolMenuStatus.Menu.ImageMarginGradientMiddle = System.Drawing.Color.FromArgb(CType(CType(76, Byte), Integer), CType(CType(126, Byte), Integer), CType(CType(226, Byte), Integer))
        Me.kryptonPaletteCustom.ToolMenuStatus.Menu.ImageMarginRevealedGradientBegin = System.Drawing.Color.FromArgb(CType(CType(102, Byte), Integer), CType(CType(153, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.kryptonPaletteCustom.ToolMenuStatus.Menu.ImageMarginRevealedGradientEnd = System.Drawing.Color.FromArgb(CType(CType(51, Byte), Integer), CType(CType(102, Byte), Integer), CType(CType(204, Byte), Integer))
        Me.kryptonPaletteCustom.ToolMenuStatus.Menu.ImageMarginRevealedGradientMiddle = System.Drawing.Color.FromArgb(CType(CType(76, Byte), Integer), CType(CType(126, Byte), Integer), CType(CType(226, Byte), Integer))
        Me.kryptonPaletteCustom.ToolMenuStatus.Menu.MenuBorder = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(51, Byte), Integer), CType(CType(102, Byte), Integer))
        Me.kryptonPaletteCustom.ToolMenuStatus.Menu.MenuItemBorder = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(51, Byte), Integer), CType(CType(102, Byte), Integer))
        Me.kryptonPaletteCustom.ToolMenuStatus.Menu.MenuItemPressedGradientBegin = System.Drawing.Color.FromArgb(CType(CType(102, Byte), Integer), CType(CType(153, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.kryptonPaletteCustom.ToolMenuStatus.Menu.MenuItemPressedGradientEnd = System.Drawing.Color.FromArgb(CType(CType(51, Byte), Integer), CType(CType(102, Byte), Integer), CType(CType(204, Byte), Integer))
        Me.kryptonPaletteCustom.ToolMenuStatus.Menu.MenuItemPressedGradientMiddle = System.Drawing.Color.FromArgb(CType(CType(51, Byte), Integer), CType(CType(102, Byte), Integer), CType(CType(204, Byte), Integer))
        Me.kryptonPaletteCustom.ToolMenuStatus.Menu.MenuItemSelected = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(102, Byte), Integer), CType(CType(0, Byte), Integer))
        Me.kryptonPaletteCustom.ToolMenuStatus.Menu.MenuItemSelectedGradientBegin = System.Drawing.Color.FromArgb(CType(CType(102, Byte), Integer), CType(CType(153, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.kryptonPaletteCustom.ToolMenuStatus.Menu.MenuItemSelectedGradientEnd = System.Drawing.Color.FromArgb(CType(CType(102, Byte), Integer), CType(CType(153, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.kryptonPaletteCustom.ToolMenuStatus.Menu.MenuItemText = System.Drawing.Color.White
        Me.kryptonPaletteCustom.ToolMenuStatus.MenuStrip.MenuStripGradientBegin = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(51, Byte), Integer), CType(CType(102, Byte), Integer))
        Me.kryptonPaletteCustom.ToolMenuStatus.MenuStrip.MenuStripGradientEnd = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(51, Byte), Integer), CType(CType(102, Byte), Integer))
        Me.kryptonPaletteCustom.ToolMenuStatus.MenuStrip.MenuStripText = System.Drawing.Color.WhiteSmoke
        Me.kryptonPaletteCustom.ToolMenuStatus.Rafting.RaftingContainerGradientBegin = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(51, Byte), Integer), CType(CType(102, Byte), Integer))
        Me.kryptonPaletteCustom.ToolMenuStatus.Rafting.RaftingContainerGradientEnd = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(51, Byte), Integer), CType(CType(102, Byte), Integer))
        Me.kryptonPaletteCustom.ToolMenuStatus.Separator.SeparatorDark = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(51, Byte), Integer), CType(CType(102, Byte), Integer))
        Me.kryptonPaletteCustom.ToolMenuStatus.Separator.SeparatorLight = System.Drawing.Color.Transparent
        Me.kryptonPaletteCustom.ToolMenuStatus.StatusStrip.StatusStripGradientBegin = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(51, Byte), Integer), CType(CType(102, Byte), Integer))
        Me.kryptonPaletteCustom.ToolMenuStatus.StatusStrip.StatusStripGradientEnd = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(51, Byte), Integer), CType(CType(102, Byte), Integer))
        Me.kryptonPaletteCustom.ToolMenuStatus.StatusStrip.StatusStripText = System.Drawing.Color.WhiteSmoke
        Me.kryptonPaletteCustom.ToolMenuStatus.ToolStrip.ToolStripBorder = System.Drawing.Color.FromArgb(CType(CType(26, Byte), Integer), CType(CType(77, Byte), Integer), CType(CType(144, Byte), Integer))
        Me.kryptonPaletteCustom.ToolMenuStatus.ToolStrip.ToolStripContentPanelGradientBegin = System.Drawing.Color.FromArgb(CType(CType(245, Byte), Integer), CType(CType(237, Byte), Integer), CType(CType(227, Byte), Integer))
        Me.kryptonPaletteCustom.ToolMenuStatus.ToolStrip.ToolStripContentPanelGradientEnd = System.Drawing.Color.FromArgb(CType(CType(245, Byte), Integer), CType(CType(237, Byte), Integer), CType(CType(227, Byte), Integer))
        Me.kryptonPaletteCustom.ToolMenuStatus.ToolStrip.ToolStripDropDownBackground = System.Drawing.Color.FromArgb(CType(CType(102, Byte), Integer), CType(CType(153, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.kryptonPaletteCustom.ToolMenuStatus.ToolStrip.ToolStripGradientBegin = System.Drawing.Color.FromArgb(CType(CType(26, Byte), Integer), CType(CType(77, Byte), Integer), CType(CType(144, Byte), Integer))
        Me.kryptonPaletteCustom.ToolMenuStatus.ToolStrip.ToolStripGradientEnd = System.Drawing.Color.FromArgb(CType(CType(26, Byte), Integer), CType(CType(77, Byte), Integer), CType(CType(144, Byte), Integer))
        Me.kryptonPaletteCustom.ToolMenuStatus.ToolStrip.ToolStripGradientMiddle = System.Drawing.Color.FromArgb(CType(CType(26, Byte), Integer), CType(CType(77, Byte), Integer), CType(CType(144, Byte), Integer))
        Me.kryptonPaletteCustom.ToolMenuStatus.ToolStrip.ToolStripPanelGradientBegin = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(51, Byte), Integer), CType(CType(102, Byte), Integer))
        Me.kryptonPaletteCustom.ToolMenuStatus.ToolStrip.ToolStripPanelGradientEnd = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(51, Byte), Integer), CType(CType(102, Byte), Integer))
        Me.kryptonPaletteCustom.ToolMenuStatus.ToolStrip.ToolStripText = System.Drawing.Color.WhiteSmoke
        Me.kryptonPaletteCustom.ToolMenuStatus.UseRoundedEdges = Krypton.Toolkit.InheritBool.False
        Me.kryptonPaletteCustom.UseThemeFormChromeBorderWidth = Krypton.Toolkit.InheritBool.False
        Me.statusStrip1.Font = New System.Drawing.Font("Segoe UI", 9F)
        Me.statusStrip1.ImageScalingSize = New System.Drawing.Size(20, 20)
        Me.statusStrip1.Location = New System.Drawing.Point(0, 404)
        Me.statusStrip1.Name = "statusStrip1"
        Me.statusStrip1.RenderMode = System.Windows.Forms.ToolStripRenderMode.ManagerRenderMode
        Me.statusStrip1.Size = New System.Drawing.Size(459, 24)
        Me.statusStrip1.TabIndex = 2
        Me.statusStrip1.Text = "statusStrip1"
        Me.kryptonRadioButton1.Location = New System.Drawing.Point(13, 66)
        Me.kryptonRadioButton1.Name = "kryptonRadioButton1"
        Me.kryptonRadioButton1.Size = New System.Drawing.Size(125, 20)
        Me.kryptonRadioButton1.TabIndex = 2
        Me.kryptonRadioButton1.Values.Text = "Office 2010 - Black"
        Me.kryptonRadioButton2.Location = New System.Drawing.Point(13, 41)
        Me.kryptonRadioButton2.Name = "kryptonRadioButton2"
        Me.kryptonRadioButton2.Size = New System.Drawing.Size(126, 20)
        Me.kryptonRadioButton2.TabIndex = 1
        Me.kryptonRadioButton2.Values.Text = "Office 2010 - Silver"
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8F, 16F)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(459, 428)
        Me.Controls.Add(Me.toolStripContainer1)
        Me.Controls.Add(Me.menuStrip1)
        Me.Controls.Add(Me.statusStrip1)
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.MainMenuStrip = Me.menuStrip1
        Me.MinimumSize = New System.Drawing.Size(459, 482)
        Me.Name = "Form1"
        Me.Text = "Three Pane Application (Basic)"
        Me.menuStrip1.ResumeLayout(False)
        Me.menuStrip1.PerformLayout()
        Me.toolStrip1.ResumeLayout(False)
        Me.toolStrip1.PerformLayout()
        Me.toolStripContainer1.ContentPanel.ResumeLayout(False)
        Me.toolStripContainer1.TopToolStripPanel.ResumeLayout(False)
        Me.toolStripContainer1.TopToolStripPanel.PerformLayout()
        Me.toolStripContainer1.ResumeLayout(False)
        Me.toolStripContainer1.PerformLayout()
        CType(Me.kryptonPanelMain, System.ComponentModel.ISupportInitialize).EndInit()
        Me.kryptonPanelMain.ResumeLayout(False)
        CType(Me.kryptonSplitContainerMain.Panel1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.kryptonSplitContainerMain.Panel1.ResumeLayout(False)
        CType(Me.kryptonSplitContainerMain.Panel2, System.ComponentModel.ISupportInitialize).EndInit()
        Me.kryptonSplitContainerMain.Panel2.ResumeLayout(False)
        CType(Me.kryptonSplitContainerMain, System.ComponentModel.ISupportInitialize).EndInit()
        Me.kryptonSplitContainerMain.ResumeLayout(False)
        CType(Me.kryptonHeaderGroupNavigation.Panel, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.kryptonHeaderGroupNavigation, System.ComponentModel.ISupportInitialize).EndInit()
        Me.kryptonHeaderGroupNavigation.ResumeLayout(False)
        CType(Me.kryptonSplitContainerDetails.Panel1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.kryptonSplitContainerDetails.Panel1.ResumeLayout(False)
        CType(Me.kryptonSplitContainerDetails.Panel2, System.ComponentModel.ISupportInitialize).EndInit()
        Me.kryptonSplitContainerDetails.Panel2.ResumeLayout(False)
        CType(Me.kryptonSplitContainerDetails, System.ComponentModel.ISupportInitialize).EndInit()
        Me.kryptonSplitContainerDetails.ResumeLayout(False)
        CType(Me.kryptonHeaderGroupDetails.Panel, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.kryptonHeaderGroupDetails, System.ComponentModel.ISupportInitialize).EndInit()
        Me.kryptonHeaderGroupDetails.ResumeLayout(False)
        CType(Me.kryptonButtonGroup.Panel, System.ComponentModel.ISupportInitialize).EndInit()
        Me.kryptonButtonGroup.Panel.ResumeLayout(False)
        CType(Me.kryptonButtonGroup, System.ComponentModel.ISupportInitialize).EndInit()
        Me.kryptonButtonGroup.ResumeLayout(False)
        CType(Me.kryptonGroup1.Panel, System.ComponentModel.ISupportInitialize).EndInit()
        Me.kryptonGroup1.Panel.ResumeLayout(False)
        Me.kryptonGroup1.Panel.PerformLayout()
        CType(Me.kryptonGroup1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.kryptonGroup1.ResumeLayout(False)
        Me.ResumeLayout(False)
        Me.PerformLayout()
    End Sub

    Friend WithEvents menuStrip1 As System.Windows.Forms.MenuStrip
    Friend WithEvents fileToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents newToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents openToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents toolStripSeparator As System.Windows.Forms.ToolStripSeparator
    Friend WithEvents saveToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents saveAsToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents toolStripSeparator1 As System.Windows.Forms.ToolStripSeparator
    Friend WithEvents printToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents printPreviewToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents toolStripSeparator2 As System.Windows.Forms.ToolStripSeparator
    Friend WithEvents exitToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents editToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents undoToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents redoToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents toolStripSeparator3 As System.Windows.Forms.ToolStripSeparator
    Friend WithEvents cutToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents copyToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents pasteToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents toolStripSeparator4 As System.Windows.Forms.ToolStripSeparator
    Friend WithEvents selectAllToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents toolsToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents customizeToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents optionsToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents helpToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents contentsToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents indexToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents searchToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents toolStripSeparator5 As System.Windows.Forms.ToolStripSeparator
    Friend WithEvents aboutToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents toolStrip1 As System.Windows.Forms.ToolStrip
    Friend WithEvents newToolStripButton As System.Windows.Forms.ToolStripButton
    Friend WithEvents openToolStripButton As System.Windows.Forms.ToolStripButton
    Friend WithEvents saveToolStripButton As System.Windows.Forms.ToolStripButton
    Friend WithEvents printToolStripButton As System.Windows.Forms.ToolStripButton
    Friend WithEvents toolStripSeparator6 As System.Windows.Forms.ToolStripSeparator
    Friend WithEvents cutToolStripButton As System.Windows.Forms.ToolStripButton
    Friend WithEvents copyToolStripButton As System.Windows.Forms.ToolStripButton
    Friend WithEvents pasteToolStripButton As System.Windows.Forms.ToolStripButton
    Friend WithEvents toolStripSeparator7 As System.Windows.Forms.ToolStripSeparator
    Friend WithEvents helpToolStripButton As System.Windows.Forms.ToolStripButton
    Friend WithEvents toolStripContainer1 As System.Windows.Forms.ToolStripContainer
    Friend WithEvents kryptonPanelMain As Krypton.Toolkit.KryptonPanel
    Friend WithEvents kryptonSplitContainerMain As Krypton.Toolkit.KryptonSplitContainer
    Friend WithEvents kryptonHeaderGroupNavigation As Krypton.Toolkit.KryptonHeaderGroup
    Friend WithEvents kryptonSplitContainerDetails As Krypton.Toolkit.KryptonSplitContainer
    Friend WithEvents kryptonHeaderGroupDetails As Krypton.Toolkit.KryptonHeaderGroup
    Friend WithEvents kryptonButtonGroup As Krypton.Toolkit.KryptonGroup
    Friend WithEvents kryptonManager As Krypton.Toolkit.KryptonManager
    Friend WithEvents kryptonPaletteCustom As Krypton.Toolkit.KryptonCustomPaletteBase
    Friend WithEvents kryptonGroup1 As Krypton.Toolkit.KryptonGroup
    Friend WithEvents statusStrip1 As System.Windows.Forms.StatusStrip
    Friend WithEvents kryptonOffice2007Black As Krypton.Toolkit.KryptonRadioButton
    Friend WithEvents kryptonOffice2007Silver As Krypton.Toolkit.KryptonRadioButton
    Friend WithEvents kryptonOffice2007Blue As Krypton.Toolkit.KryptonRadioButton
    Friend WithEvents kryptonOffice2003 As Krypton.Toolkit.KryptonRadioButton
    Friend WithEvents kryptonCustom As Krypton.Toolkit.KryptonRadioButton
    Friend WithEvents kryptonSystem As Krypton.Toolkit.KryptonRadioButton
    Friend WithEvents kryptonSparkleBlue As Krypton.Toolkit.KryptonRadioButton
    Friend WithEvents kryptonSparkleOrange As Krypton.Toolkit.KryptonRadioButton
    Friend WithEvents kryptonSparklePurple As Krypton.Toolkit.KryptonRadioButton
    Friend WithEvents kryptonOffice2010Black As Krypton.Toolkit.KryptonRadioButton
    Friend WithEvents kryptonOffice2010Blue As Krypton.Toolkit.KryptonRadioButton
    Friend WithEvents kryptonOffice2010Silver As Krypton.Toolkit.KryptonRadioButton
    Friend WithEvents kryptonRadioButton1 As Krypton.Toolkit.KryptonRadioButton
    Friend WithEvents kryptonRadioButton2 As Krypton.Toolkit.KryptonRadioButton
    Friend WithEvents kryptonOffice2013White As Krypton.Toolkit.KryptonRadioButton
End Class
