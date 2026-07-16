' VB.NET twin of Source\Krypton Navigator Examples\Outlook Mockup\Form1.Designer.cs (Bastion Phase 4c).
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
        Dim treeNode1 As System.Windows.Forms.TreeNode = New System.Windows.Forms.TreeNode("Deleted Items")
        Dim treeNode2 As System.Windows.Forms.TreeNode = New System.Windows.Forms.TreeNode("Drafts")
        Dim treeNode3 As System.Windows.Forms.TreeNode = New System.Windows.Forms.TreeNode("Family")
        Dim treeNode4 As System.Windows.Forms.TreeNode = New System.Windows.Forms.TreeNode("Friends")
        Dim treeNode5 As System.Windows.Forms.TreeNode = New System.Windows.Forms.TreeNode("Work")
        Dim treeNode6 As System.Windows.Forms.TreeNode = New System.Windows.Forms.TreeNode("Inbox", New System.Windows.Forms.TreeNode() { treeNode3, treeNode4, treeNode5})
        Dim treeNode7 As System.Windows.Forms.TreeNode = New System.Windows.Forms.TreeNode("Outbox")
        Dim treeNode8 As System.Windows.Forms.TreeNode = New System.Windows.Forms.TreeNode("Sent Items")
        Dim treeNode9 As System.Windows.Forms.TreeNode = New System.Windows.Forms.TreeNode("Drafts")
        Dim treeNode10 As System.Windows.Forms.TreeNode = New System.Windows.Forms.TreeNode("Family")
        Dim dataGridViewCellStyle1 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim dataGridViewCellStyle2 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
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
        Me.kryptonNavigatorMain = New Krypton.Navigator.KryptonNavigator()
        Me.buttonSpecExpandCollapse = New Krypton.Navigator.ButtonSpecNavigator()
        Me.kryptonPageMail = New Krypton.Navigator.KryptonPage()
        Me.treeViewMailFolders = New System.Windows.Forms.TreeView()
        Me.imageListSmall = New System.Windows.Forms.ImageList(Me.components)
        Me.panelFoldersSep = New System.Windows.Forms.Panel()
        Me.kryptonHeaderFolders = New Krypton.Toolkit.KryptonHeader()
        Me.treeViewMailFavs = New System.Windows.Forms.TreeView()
        Me.panelFavoriteSep = New System.Windows.Forms.Panel()
        Me.kryptonHeaderFavorites = New Krypton.Toolkit.KryptonHeader()
        Me.kryptonPageCalendar = New Krypton.Navigator.KryptonPage()
        Me.monthCalendar1 = New System.Windows.Forms.MonthCalendar()
        Me.kryptonPageNotes = New Krypton.Navigator.KryptonPage()
        Me.radioFriends = New Krypton.Toolkit.KryptonRadioButton()
        Me.radioFamily = New Krypton.Toolkit.KryptonRadioButton()
        Me.radioProject = New Krypton.Toolkit.KryptonRadioButton()
        Me.kryptonSplitContainerDetails = New Krypton.Toolkit.KryptonSplitContainer()
        Me.kryptonNavigatorDetails = New Krypton.Navigator.KryptonNavigator()
        Me.kryptonPageMailDetails = New Krypton.Navigator.KryptonPage()
        Me.kryptonDataGridView1 = New Krypton.Toolkit.KryptonDataGridView()
        Me.dgName = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.dgSubject = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.dgReceived = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.dgSize = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.kryptonPageCalendarDetails = New Krypton.Navigator.KryptonPage()
        Me.textBox1 = New System.Windows.Forms.TextBox()
        Me.kryptonPageNotesDetails = New Krypton.Navigator.KryptonPage()
        Me.listViewNotes = New System.Windows.Forms.ListView()
        Me.imageListLarge = New System.Windows.Forms.ImageList(Me.components)
        Me.kryptonButtonGroup = New Krypton.Toolkit.KryptonGroup()
        Me.kryptonGroupInner = New Krypton.Toolkit.KryptonGroup()
        Me.radioOffice2010Black = New Krypton.Toolkit.KryptonRadioButton()
        Me.radioOffice2010Silver = New Krypton.Toolkit.KryptonRadioButton()
        Me.radioOffice2010Blue = New Krypton.Toolkit.KryptonRadioButton()
        Me.radioSparkle = New Krypton.Toolkit.KryptonRadioButton()
        Me.radioSystem = New Krypton.Toolkit.KryptonRadioButton()
        Me.radioOffice2003 = New Krypton.Toolkit.KryptonRadioButton()
        Me.radioOffice2007Black = New Krypton.Toolkit.KryptonRadioButton()
        Me.radioOffice2007Silver = New Krypton.Toolkit.KryptonRadioButton()
        Me.radioOffice2007Blue = New Krypton.Toolkit.KryptonRadioButton()
        Me.kryptonManager = New Krypton.Toolkit.KryptonManager(Me.components)
        Me.dataSet = New System.Data.DataSet()
        Me.dtDeletedItems = New System.Data.DataTable()
        Me.dataColumn1 = New System.Data.DataColumn()
        Me.dataColumn2 = New System.Data.DataColumn()
        Me.dataColumn3 = New System.Data.DataColumn()
        Me.dataColumn4 = New System.Data.DataColumn()
        Me.dtDrafts = New System.Data.DataTable()
        Me.dataColumn5 = New System.Data.DataColumn()
        Me.dataColumn6 = New System.Data.DataColumn()
        Me.dataColumn7 = New System.Data.DataColumn()
        Me.dataColumn8 = New System.Data.DataColumn()
        Me.dtFamily = New System.Data.DataTable()
        Me.dataColumn9 = New System.Data.DataColumn()
        Me.dataColumn10 = New System.Data.DataColumn()
        Me.dataColumn11 = New System.Data.DataColumn()
        Me.dataColumn12 = New System.Data.DataColumn()
        Me.dtOutbox = New System.Data.DataTable()
        Me.dataColumn13 = New System.Data.DataColumn()
        Me.dataColumn14 = New System.Data.DataColumn()
        Me.dataColumn15 = New System.Data.DataColumn()
        Me.dataColumn16 = New System.Data.DataColumn()
        Me.dtSentItems = New System.Data.DataTable()
        Me.dataColumn17 = New System.Data.DataColumn()
        Me.dataColumn18 = New System.Data.DataColumn()
        Me.dataColumn19 = New System.Data.DataColumn()
        Me.dataColumn20 = New System.Data.DataColumn()
        Me.dtFriends = New System.Data.DataTable()
        Me.dataColumn21 = New System.Data.DataColumn()
        Me.dataColumn22 = New System.Data.DataColumn()
        Me.dataColumn23 = New System.Data.DataColumn()
        Me.dataColumn24 = New System.Data.DataColumn()
        Me.dtWork = New System.Data.DataTable()
        Me.dataColumn25 = New System.Data.DataColumn()
        Me.dataColumn26 = New System.Data.DataColumn()
        Me.dataColumn27 = New System.Data.DataColumn()
        Me.dataColumn28 = New System.Data.DataColumn()
        Me.dtInbox = New System.Data.DataTable()
        Me.dataColumn29 = New System.Data.DataColumn()
        Me.dataColumn30 = New System.Data.DataColumn()
        Me.dataColumn31 = New System.Data.DataColumn()
        Me.dataColumn32 = New System.Data.DataColumn()
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
        CType(Me.kryptonNavigatorMain, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.kryptonPageMail, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.kryptonPageMail.SuspendLayout()
        CType(Me.kryptonPageCalendar, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.kryptonPageCalendar.SuspendLayout()
        CType(Me.kryptonPageNotes, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.kryptonPageNotes.SuspendLayout()
        CType(Me.kryptonSplitContainerDetails, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.kryptonSplitContainerDetails.Panel1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.kryptonSplitContainerDetails.Panel1.SuspendLayout()
        CType(Me.kryptonSplitContainerDetails.Panel2, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.kryptonSplitContainerDetails.Panel2.SuspendLayout()
        Me.kryptonSplitContainerDetails.SuspendLayout()
        CType(Me.kryptonNavigatorDetails, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.kryptonNavigatorDetails.SuspendLayout()
        CType(Me.kryptonPageMailDetails, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.kryptonPageMailDetails.SuspendLayout()
        CType(Me.kryptonDataGridView1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.kryptonPageCalendarDetails, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.kryptonPageCalendarDetails.SuspendLayout()
        CType(Me.kryptonPageNotesDetails, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.kryptonPageNotesDetails.SuspendLayout()
        CType(Me.kryptonButtonGroup, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.kryptonButtonGroup.Panel, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.kryptonButtonGroup.Panel.SuspendLayout()
        Me.kryptonButtonGroup.SuspendLayout()
        CType(Me.kryptonGroupInner, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.kryptonGroupInner.Panel, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.kryptonGroupInner.Panel.SuspendLayout()
        Me.kryptonGroupInner.SuspendLayout()
        CType(Me.dataSet, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.dtDeletedItems, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.dtDrafts, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.dtFamily, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.dtOutbox, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.dtSentItems, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.dtFriends, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.dtWork, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.dtInbox, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        Me.menuStrip1.Font = New System.Drawing.Font("Segoe UI", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.World)
        Me.menuStrip1.ImageScalingSize = New System.Drawing.Size(20, 20)
        Me.menuStrip1.Items.AddRange(New System.Windows.Forms.ToolStripItem() { Me.fileToolStripMenuItem, Me.editToolStripMenuItem, Me.toolsToolStripMenuItem, Me.helpToolStripMenuItem})
        Me.menuStrip1.Location = New System.Drawing.Point(0, 0)
        Me.menuStrip1.Name = "menuStrip1"
        Me.menuStrip1.Size = New System.Drawing.Size(716, 28)
        Me.menuStrip1.TabIndex = 0
        Me.menuStrip1.Text = "menuStrip1"
        Me.fileToolStripMenuItem.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() { Me.newToolStripMenuItem, Me.openToolStripMenuItem, Me.toolStripSeparator, Me.saveToolStripMenuItem, Me.saveAsToolStripMenuItem, Me.toolStripSeparator1, Me.printToolStripMenuItem, Me.printPreviewToolStripMenuItem, Me.toolStripSeparator2, Me.exitToolStripMenuItem})
        Me.fileToolStripMenuItem.Name = "fileToolStripMenuItem"
        Me.fileToolStripMenuItem.Size = New System.Drawing.Size(46, 24)
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
        Me.editToolStripMenuItem.Size = New System.Drawing.Size(49, 24)
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
        Me.toolsToolStripMenuItem.Size = New System.Drawing.Size(58, 24)
        Me.toolsToolStripMenuItem.Text = "&Tools"
        Me.customizeToolStripMenuItem.Name = "customizeToolStripMenuItem"
        Me.customizeToolStripMenuItem.Size = New System.Drawing.Size(161, 26)
        Me.customizeToolStripMenuItem.Text = "&Customize"
        Me.optionsToolStripMenuItem.Name = "optionsToolStripMenuItem"
        Me.optionsToolStripMenuItem.Size = New System.Drawing.Size(161, 26)
        Me.optionsToolStripMenuItem.Text = "&Options"
        Me.helpToolStripMenuItem.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() { Me.contentsToolStripMenuItem, Me.indexToolStripMenuItem, Me.searchToolStripMenuItem, Me.toolStripSeparator5, Me.aboutToolStripMenuItem})
        Me.helpToolStripMenuItem.Name = "helpToolStripMenuItem"
        Me.helpToolStripMenuItem.Size = New System.Drawing.Size(55, 24)
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
        Me.toolStrip1.Font = New System.Drawing.Font("Segoe UI", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.World)
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
        Me.toolStripContainer1.ContentPanel.Size = New System.Drawing.Size(716, 430)
        Me.toolStripContainer1.Dock = System.Windows.Forms.DockStyle.Fill
        Me.toolStripContainer1.Location = New System.Drawing.Point(0, 28)
        Me.toolStripContainer1.Name = "toolStripContainer1"
        Me.toolStripContainer1.Size = New System.Drawing.Size(716, 457)
        Me.toolStripContainer1.TabIndex = 1
        Me.toolStripContainer1.Text = "toolStripContainer1"
        Me.toolStripContainer1.TopToolStripPanel.Controls.Add(Me.toolStrip1)
        Me.kryptonPanelMain.Controls.Add(Me.kryptonSplitContainerMain)
        Me.kryptonPanelMain.Dock = System.Windows.Forms.DockStyle.Fill
        Me.kryptonPanelMain.Location = New System.Drawing.Point(0, 0)
        Me.kryptonPanelMain.Name = "kryptonPanelMain"
        Me.kryptonPanelMain.Padding = New System.Windows.Forms.Padding(4)
        Me.kryptonPanelMain.Size = New System.Drawing.Size(716, 430)
        Me.kryptonPanelMain.TabIndex = 0
        Me.kryptonSplitContainerMain.Cursor = System.Windows.Forms.Cursors.Default
        Me.kryptonSplitContainerMain.Dock = System.Windows.Forms.DockStyle.Fill
        Me.kryptonSplitContainerMain.FixedPanel = System.Windows.Forms.FixedPanel.Panel1
        Me.kryptonSplitContainerMain.Location = New System.Drawing.Point(4, 4)
        Me.kryptonSplitContainerMain.Name = "kryptonSplitContainerMain"
        Me.kryptonSplitContainerMain.Panel1.Controls.Add(Me.kryptonNavigatorMain)
        Me.kryptonSplitContainerMain.Panel2.Controls.Add(Me.kryptonSplitContainerDetails)
        Me.kryptonSplitContainerMain.Size = New System.Drawing.Size(708, 422)
        Me.kryptonSplitContainerMain.SplitterDistance = 183
        Me.kryptonSplitContainerMain.TabIndex = 0
        Me.kryptonNavigatorMain.Button.ButtonDisplayLogic = Krypton.Navigator.ButtonDisplayLogic.None
        Me.kryptonNavigatorMain.Button.ButtonSpecs.Add(Me.buttonSpecExpandCollapse)
        Me.kryptonNavigatorMain.Button.CloseButtonAction = Krypton.Navigator.CloseButtonAction.RemovePageAndDispose
        Me.kryptonNavigatorMain.Button.CloseButtonDisplay = Krypton.Navigator.ButtonDisplay.Hide
        Me.kryptonNavigatorMain.Button.ContextButtonAction = Krypton.Navigator.ContextButtonAction.SelectPage
        Me.kryptonNavigatorMain.Button.ContextButtonDisplay = Krypton.Navigator.ButtonDisplay.Logic
        Me.kryptonNavigatorMain.Button.ContextMenuMapImage = Krypton.Navigator.MapKryptonPageImage.Small
        Me.kryptonNavigatorMain.Button.ContextMenuMapText = Krypton.Navigator.MapKryptonPageText.TextTitle
        Me.kryptonNavigatorMain.Button.NextButtonAction = Krypton.Navigator.DirectionButtonAction.ModeAppropriateAction
        Me.kryptonNavigatorMain.Button.NextButtonDisplay = Krypton.Navigator.ButtonDisplay.Logic
        Me.kryptonNavigatorMain.Button.PreviousButtonAction = Krypton.Navigator.DirectionButtonAction.ModeAppropriateAction
        Me.kryptonNavigatorMain.Button.PreviousButtonDisplay = Krypton.Navigator.ButtonDisplay.Logic
        Me.kryptonNavigatorMain.ControlKryptonFormFeatures = False
        Me.kryptonNavigatorMain.Dock = System.Windows.Forms.DockStyle.Fill
        Me.kryptonNavigatorMain.Header.HeaderPositionBar = Krypton.Toolkit.VisualOrientation.Top
        Me.kryptonNavigatorMain.Header.HeaderPositionPrimary = Krypton.Toolkit.VisualOrientation.Top
        Me.kryptonNavigatorMain.Header.HeaderPositionSecondary = Krypton.Toolkit.VisualOrientation.Bottom
        Me.kryptonNavigatorMain.Header.HeaderStyleBar = Krypton.Toolkit.HeaderStyle.Secondary
        Me.kryptonNavigatorMain.Header.HeaderStylePrimary = Krypton.Toolkit.HeaderStyle.Primary
        Me.kryptonNavigatorMain.Header.HeaderStyleSecondary = Krypton.Toolkit.HeaderStyle.Secondary
        Me.kryptonNavigatorMain.Header.HeaderValuesPrimary.MapDescription = Krypton.Navigator.MapKryptonPageText.None
        Me.kryptonNavigatorMain.Header.HeaderValuesPrimary.MapHeading = Krypton.Navigator.MapKryptonPageText.TitleText
        Me.kryptonNavigatorMain.Header.HeaderValuesPrimary.MapImage = Krypton.Navigator.MapKryptonPageImage.None
        Me.kryptonNavigatorMain.Location = New System.Drawing.Point(0, 0)
        Me.kryptonNavigatorMain.Name = "kryptonNavigatorMain"
        Me.kryptonNavigatorMain.NavigatorMode = Krypton.Navigator.NavigatorMode.OutlookFull
        Me.kryptonNavigatorMain.Owner = Nothing
        Me.kryptonNavigatorMain.PageBackStyle = Krypton.Toolkit.PaletteBackStyle.ControlClient
        Me.kryptonNavigatorMain.Pages.AddRange(New Krypton.Navigator.KryptonPage() { Me.kryptonPageMail, Me.kryptonPageCalendar, Me.kryptonPageNotes})
        Me.kryptonNavigatorMain.SelectedIndex = 0
        Me.kryptonNavigatorMain.Size = New System.Drawing.Size(183, 422)
        Me.kryptonNavigatorMain.StateCommon.CheckButton.Content.AdjacentGap = 5
        Me.kryptonNavigatorMain.TabIndex = 0
        Me.kryptonNavigatorMain.Text = "kryptonNavigator1"
        Me.buttonSpecExpandCollapse.Type = Krypton.Toolkit.PaletteButtonSpecStyle.ArrowLeft
        Me.buttonSpecExpandCollapse.TypeRestricted = Krypton.Navigator.PaletteNavButtonSpecStyle.ArrowLeft
        Me.buttonSpecExpandCollapse.UniqueName = "1B343938A2284A991B343938A2284A99"
        Me.kryptonPageMail.AutoHiddenSlideSize = New System.Drawing.Size(200, 200)
        Me.kryptonPageMail.Controls.Add(Me.treeViewMailFolders)
        Me.kryptonPageMail.Controls.Add(Me.panelFoldersSep)
        Me.kryptonPageMail.Controls.Add(Me.kryptonHeaderFolders)
        Me.kryptonPageMail.Controls.Add(Me.treeViewMailFavs)
        Me.kryptonPageMail.Controls.Add(Me.panelFavoriteSep)
        Me.kryptonPageMail.Controls.Add(Me.kryptonHeaderFavorites)
        Me.kryptonPageMail.Flags = 65534
        Me.kryptonPageMail.ImageLarge = CType(resources.GetObject("kryptonPageMail.ImageLarge"), System.Drawing.Bitmap)
        Me.kryptonPageMail.ImageMedium = CType(resources.GetObject("kryptonPageMail.ImageMedium"), System.Drawing.Bitmap)
        Me.kryptonPageMail.ImageSmall = CType(resources.GetObject("kryptonPageMail.ImageSmall"), System.Drawing.Bitmap)
        Me.kryptonPageMail.LastVisibleSet = True
        Me.kryptonPageMail.MinimumSize = New System.Drawing.Size(180, 230)
        Me.kryptonPageMail.Name = "kryptonPageMail"
        Me.kryptonPageMail.Size = New System.Drawing.Size(181, 258)
        Me.kryptonPageMail.Text = "Mail"
        Me.kryptonPageMail.TextTitle = "Mail"
        Me.kryptonPageMail.ToolTipTitle = "Page ToolTip"
        Me.kryptonPageMail.UniqueName = "6D4A539F5AB946C76D4A539F5AB946C7"
        Me.treeViewMailFolders.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.treeViewMailFolders.Dock = System.Windows.Forms.DockStyle.Fill
        Me.treeViewMailFolders.HideSelection = False
        Me.treeViewMailFolders.ImageIndex = 0
        Me.treeViewMailFolders.ImageList = Me.imageListSmall
        Me.treeViewMailFolders.Location = New System.Drawing.Point(0, 103)
        Me.treeViewMailFolders.Name = "treeViewMailFolders"
        treeNode1.Name = "nodeDeletedItems"
        treeNode1.Tag = "0"
        treeNode1.Text = "Deleted Items"
        treeNode2.Name = "nodeDrafts"
        treeNode2.Tag = "1"
        treeNode2.Text = "Drafts"
        treeNode3.Name = "nodeFamily"
        treeNode3.Tag = "3"
        treeNode3.Text = "Family"
        treeNode4.Name = "nodeFriends"
        treeNode4.Tag = "4"
        treeNode4.Text = "Friends"
        treeNode5.Name = "nodeWork"
        treeNode5.Tag = "5"
        treeNode5.Text = "Work"
        treeNode6.Name = "nodeInbox"
        treeNode6.Tag = "2"
        treeNode6.Text = "Inbox"
        treeNode7.Name = "nodeOutbox"
        treeNode7.Tag = "6"
        treeNode7.Text = "Outbox"
        treeNode8.Name = "nodeSentItems"
        treeNode8.Tag = "7"
        treeNode8.Text = "Sent Items"
        Me.treeViewMailFolders.Nodes.AddRange(New System.Windows.Forms.TreeNode() { treeNode1, treeNode2, treeNode6, treeNode7, treeNode8})
        Me.treeViewMailFolders.SelectedImageIndex = 0
        Me.treeViewMailFolders.Size = New System.Drawing.Size(181, 155)
        Me.treeViewMailFolders.TabIndex = 1
        Me.imageListSmall.ImageStream = CType(resources.GetObject("imageListSmall.ImageStream"), System.Windows.Forms.ImageListStreamer)
        Me.imageListSmall.TransparentColor = System.Drawing.Color.Magenta
        Me.imageListSmall.Images.SetKeyName(0, "VSFolder_closed.bmp")
        Me.imageListSmall.Images.SetKeyName(1, "OpendedClosed.bmp")
        Me.imageListSmall.Images.SetKeyName(2, "eps_openHS.png")
        Me.panelFoldersSep.BackColor = System.Drawing.SystemColors.Window
        Me.panelFoldersSep.Dock = System.Windows.Forms.DockStyle.Top
        Me.panelFoldersSep.Location = New System.Drawing.Point(0, 98)
        Me.panelFoldersSep.Name = "panelFoldersSep"
        Me.panelFoldersSep.Size = New System.Drawing.Size(181, 5)
        Me.panelFoldersSep.TabIndex = 5
        Me.kryptonHeaderFolders.Dock = System.Windows.Forms.DockStyle.Top
        Me.kryptonHeaderFolders.HeaderStyle = Krypton.Toolkit.HeaderStyle.Secondary
        Me.kryptonHeaderFolders.Location = New System.Drawing.Point(0, 70)
        Me.kryptonHeaderFolders.Name = "kryptonHeaderFolders"
        Me.kryptonHeaderFolders.Size = New System.Drawing.Size(181, 28)
        Me.kryptonHeaderFolders.StateCommon.Border.DrawBorders = CType((Krypton.Toolkit.PaletteDrawBorders.Top Or Krypton.Toolkit.PaletteDrawBorders.Bottom), Krypton.Toolkit.PaletteDrawBorders)
        Me.kryptonHeaderFolders.TabIndex = 2
        Me.kryptonHeaderFolders.Values.Description = ""
        Me.kryptonHeaderFolders.Values.Heading = "Mail Folders"
        Me.kryptonHeaderFolders.Values.Image = Nothing
        Me.treeViewMailFavs.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.treeViewMailFavs.Dock = System.Windows.Forms.DockStyle.Top
        Me.treeViewMailFavs.HideSelection = False
        Me.treeViewMailFavs.ImageIndex = 0
        Me.treeViewMailFavs.ImageList = Me.imageListSmall
        Me.treeViewMailFavs.Location = New System.Drawing.Point(0, 32)
        Me.treeViewMailFavs.Name = "treeViewMailFavs"
        treeNode9.Name = "nodeDrafts"
        treeNode9.Tag = "1"
        treeNode9.Text = "Drafts"
        treeNode10.Name = "nodeFamily"
        treeNode10.Tag = "3"
        treeNode10.Text = "Family"
        Me.treeViewMailFavs.Nodes.AddRange(New System.Windows.Forms.TreeNode() { treeNode9, treeNode10})
        Me.treeViewMailFavs.SelectedImageIndex = 0
        Me.treeViewMailFavs.Size = New System.Drawing.Size(181, 38)
        Me.treeViewMailFavs.TabIndex = 0
        Me.panelFavoriteSep.BackColor = System.Drawing.SystemColors.Window
        Me.panelFavoriteSep.Dock = System.Windows.Forms.DockStyle.Top
        Me.panelFavoriteSep.Location = New System.Drawing.Point(0, 27)
        Me.panelFavoriteSep.Name = "panelFavoriteSep"
        Me.panelFavoriteSep.Size = New System.Drawing.Size(181, 5)
        Me.panelFavoriteSep.TabIndex = 4
        Me.kryptonHeaderFavorites.Dock = System.Windows.Forms.DockStyle.Top
        Me.kryptonHeaderFavorites.HeaderStyle = Krypton.Toolkit.HeaderStyle.Secondary
        Me.kryptonHeaderFavorites.Location = New System.Drawing.Point(0, 0)
        Me.kryptonHeaderFavorites.Name = "kryptonHeaderFavorites"
        Me.kryptonHeaderFavorites.Size = New System.Drawing.Size(181, 27)
        Me.kryptonHeaderFavorites.StateCommon.Border.DrawBorders = Krypton.Toolkit.PaletteDrawBorders.Bottom
        Me.kryptonHeaderFavorites.TabIndex = 1
        Me.kryptonHeaderFavorites.Values.Description = ""
        Me.kryptonHeaderFavorites.Values.Heading = "Favorite Folders"
        Me.kryptonHeaderFavorites.Values.Image = Nothing
        Me.kryptonPageCalendar.AutoHiddenSlideSize = New System.Drawing.Size(200, 200)
        Me.kryptonPageCalendar.Controls.Add(Me.monthCalendar1)
        Me.kryptonPageCalendar.Flags = 65534
        Me.kryptonPageCalendar.ImageLarge = CType(resources.GetObject("kryptonPageCalendar.ImageLarge"), System.Drawing.Bitmap)
        Me.kryptonPageCalendar.ImageMedium = CType(resources.GetObject("kryptonPageCalendar.ImageMedium"), System.Drawing.Bitmap)
        Me.kryptonPageCalendar.ImageSmall = CType(resources.GetObject("kryptonPageCalendar.ImageSmall"), System.Drawing.Bitmap)
        Me.kryptonPageCalendar.LastVisibleSet = True
        Me.kryptonPageCalendar.MinimumSize = New System.Drawing.Size(190, 155)
        Me.kryptonPageCalendar.Name = "kryptonPageCalendar"
        Me.kryptonPageCalendar.Padding = New System.Windows.Forms.Padding(5)
        Me.kryptonPageCalendar.Size = New System.Drawing.Size(190, 296)
        Me.kryptonPageCalendar.Text = "Calendar"
        Me.kryptonPageCalendar.TextTitle = "Calendar"
        Me.kryptonPageCalendar.ToolTipTitle = "Page ToolTip"
        Me.kryptonPageCalendar.UniqueName = "20332D6AA91B4AF120332D6AA91B4AF1"
        Me.monthCalendar1.Location = New System.Drawing.Point(5, 5)
        Me.monthCalendar1.Name = "monthCalendar1"
        Me.monthCalendar1.ShowToday = False
        Me.monthCalendar1.ShowTodayCircle = False
        Me.monthCalendar1.TabIndex = 0
        Me.kryptonPageNotes.AutoHiddenSlideSize = New System.Drawing.Size(200, 200)
        Me.kryptonPageNotes.Controls.Add(Me.radioFriends)
        Me.kryptonPageNotes.Controls.Add(Me.radioFamily)
        Me.kryptonPageNotes.Controls.Add(Me.radioProject)
        Me.kryptonPageNotes.Flags = 65534
        Me.kryptonPageNotes.ImageLarge = CType(resources.GetObject("kryptonPageNotes.ImageLarge"), System.Drawing.Bitmap)
        Me.kryptonPageNotes.ImageMedium = CType(resources.GetObject("kryptonPageNotes.ImageMedium"), System.Drawing.Bitmap)
        Me.kryptonPageNotes.ImageSmall = CType(resources.GetObject("kryptonPageNotes.ImageSmall"), System.Drawing.Bitmap)
        Me.kryptonPageNotes.LastVisibleSet = True
        Me.kryptonPageNotes.MinimumSize = New System.Drawing.Size(50, 50)
        Me.kryptonPageNotes.Name = "kryptonPageNotes"
        Me.kryptonPageNotes.Padding = New System.Windows.Forms.Padding(20)
        Me.kryptonPageNotes.Size = New System.Drawing.Size(181, 296)
        Me.kryptonPageNotes.Text = "Notes"
        Me.kryptonPageNotes.TextTitle = "Notes"
        Me.kryptonPageNotes.ToolTipTitle = "Page ToolTip"
        Me.kryptonPageNotes.UniqueName = "F896ACB8955B498FF896ACB8955B498F"
        Me.radioFriends.Location = New System.Drawing.Point(23, 73)
        Me.radioFriends.Name = "radioFriends"
        Me.radioFriends.Size = New System.Drawing.Size(77, 26)
        Me.radioFriends.TabIndex = 8
        Me.radioFriends.Values.Text = "Friends"
        Me.radioFamily.Location = New System.Drawing.Point(23, 48)
        Me.radioFamily.Name = "radioFamily"
        Me.radioFamily.Size = New System.Drawing.Size(71, 26)
        Me.radioFamily.TabIndex = 7
        Me.radioFamily.Values.Text = "Family"
        Me.radioProject.Checked = True
        Me.radioProject.Location = New System.Drawing.Point(23, 23)
        Me.radioProject.Name = "radioProject"
        Me.radioProject.Size = New System.Drawing.Size(75, 26)
        Me.radioProject.TabIndex = 6
        Me.radioProject.Values.Text = "Project"
        Me.kryptonSplitContainerDetails.Cursor = System.Windows.Forms.Cursors.Default
        Me.kryptonSplitContainerDetails.Dock = System.Windows.Forms.DockStyle.Fill
        Me.kryptonSplitContainerDetails.Location = New System.Drawing.Point(0, 0)
        Me.kryptonSplitContainerDetails.Name = "kryptonSplitContainerDetails"
        Me.kryptonSplitContainerDetails.Orientation = System.Windows.Forms.Orientation.Horizontal
        Me.kryptonSplitContainerDetails.Panel1.Controls.Add(Me.kryptonNavigatorDetails)
        Me.kryptonSplitContainerDetails.Panel2.Controls.Add(Me.kryptonButtonGroup)
        Me.kryptonSplitContainerDetails.Size = New System.Drawing.Size(520, 422)
        Me.kryptonSplitContainerDetails.SplitterDistance = 221
        Me.kryptonSplitContainerDetails.TabIndex = 0
        Me.kryptonNavigatorDetails.Button.ButtonDisplayLogic = Krypton.Navigator.ButtonDisplayLogic.None
        Me.kryptonNavigatorDetails.Button.CloseButtonAction = Krypton.Navigator.CloseButtonAction.RemovePageAndDispose
        Me.kryptonNavigatorDetails.Button.CloseButtonDisplay = Krypton.Navigator.ButtonDisplay.Hide
        Me.kryptonNavigatorDetails.Button.ContextButtonAction = Krypton.Navigator.ContextButtonAction.SelectPage
        Me.kryptonNavigatorDetails.Button.ContextButtonDisplay = Krypton.Navigator.ButtonDisplay.Logic
        Me.kryptonNavigatorDetails.Button.ContextMenuMapImage = Krypton.Navigator.MapKryptonPageImage.Small
        Me.kryptonNavigatorDetails.Button.ContextMenuMapText = Krypton.Navigator.MapKryptonPageText.TextTitle
        Me.kryptonNavigatorDetails.Button.NextButtonAction = Krypton.Navigator.DirectionButtonAction.ModeAppropriateAction
        Me.kryptonNavigatorDetails.Button.NextButtonDisplay = Krypton.Navigator.ButtonDisplay.Logic
        Me.kryptonNavigatorDetails.Button.PreviousButtonAction = Krypton.Navigator.DirectionButtonAction.ModeAppropriateAction
        Me.kryptonNavigatorDetails.Button.PreviousButtonDisplay = Krypton.Navigator.ButtonDisplay.Logic
        Me.kryptonNavigatorDetails.ControlKryptonFormFeatures = False
        Me.kryptonNavigatorDetails.Dock = System.Windows.Forms.DockStyle.Fill
        Me.kryptonNavigatorDetails.Header.HeaderPositionBar = Krypton.Toolkit.VisualOrientation.Top
        Me.kryptonNavigatorDetails.Header.HeaderPositionPrimary = Krypton.Toolkit.VisualOrientation.Top
        Me.kryptonNavigatorDetails.Header.HeaderPositionSecondary = Krypton.Toolkit.VisualOrientation.Bottom
        Me.kryptonNavigatorDetails.Header.HeaderStyleBar = Krypton.Toolkit.HeaderStyle.Secondary
        Me.kryptonNavigatorDetails.Header.HeaderStylePrimary = Krypton.Toolkit.HeaderStyle.Primary
        Me.kryptonNavigatorDetails.Header.HeaderStyleSecondary = Krypton.Toolkit.HeaderStyle.Secondary
        Me.kryptonNavigatorDetails.Header.HeaderVisibleSecondary = False
        Me.kryptonNavigatorDetails.Location = New System.Drawing.Point(0, 0)
        Me.kryptonNavigatorDetails.Name = "kryptonNavigatorDetails"
        Me.kryptonNavigatorDetails.NavigatorMode = Krypton.Navigator.NavigatorMode.HeaderGroup
        Me.kryptonNavigatorDetails.Owner = Nothing
        Me.kryptonNavigatorDetails.PageBackStyle = Krypton.Toolkit.PaletteBackStyle.ControlClient
        Me.kryptonNavigatorDetails.Pages.AddRange(New Krypton.Navigator.KryptonPage() { Me.kryptonPageMailDetails, Me.kryptonPageCalendarDetails, Me.kryptonPageNotesDetails})
        Me.kryptonNavigatorDetails.SelectedIndex = 0
        Me.kryptonNavigatorDetails.Size = New System.Drawing.Size(520, 221)
        Me.kryptonNavigatorDetails.StateCommon.HeaderGroup.HeaderPrimary.Content.Image.ImageH = Krypton.Toolkit.PaletteRelativeAlign.Far
        Me.kryptonNavigatorDetails.TabIndex = 0
        Me.kryptonNavigatorDetails.Text = "kryptonNavigator1"
        Me.kryptonPageMailDetails.AutoHiddenSlideSize = New System.Drawing.Size(200, 200)
        Me.kryptonPageMailDetails.Controls.Add(Me.kryptonDataGridView1)
        Me.kryptonPageMailDetails.Flags = 65534
        Me.kryptonPageMailDetails.ImageLarge = CType(resources.GetObject("kryptonPageMailDetails.ImageLarge"), System.Drawing.Bitmap)
        Me.kryptonPageMailDetails.ImageMedium = CType(resources.GetObject("kryptonPageMailDetails.ImageMedium"), System.Drawing.Bitmap)
        Me.kryptonPageMailDetails.LastVisibleSet = True
        Me.kryptonPageMailDetails.MinimumSize = New System.Drawing.Size(50, 50)
        Me.kryptonPageMailDetails.Name = "kryptonPageMailDetails"
        Me.kryptonPageMailDetails.Size = New System.Drawing.Size(518, 181)
        Me.kryptonPageMailDetails.Text = "Mail"
        Me.kryptonPageMailDetails.TextTitle = "Mail"
        Me.kryptonPageMailDetails.ToolTipTitle = "Page ToolTip"
        Me.kryptonPageMailDetails.UniqueName = "2978E4C56C8641122978E4C56C864112"
        Me.kryptonDataGridView1.AllowUserToAddRows = False
        Me.kryptonDataGridView1.AllowUserToDeleteRows = False
        Me.kryptonDataGridView1.AllowUserToResizeRows = False
        Me.kryptonDataGridView1.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.kryptonDataGridView1.ColumnHeadersHeight = 36
        Me.kryptonDataGridView1.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() { Me.dgName, Me.dgSubject, Me.dgReceived, Me.dgSize})
        Me.kryptonDataGridView1.Dock = System.Windows.Forms.DockStyle.Fill
        Me.kryptonDataGridView1.GridStyles.Style = Krypton.Toolkit.DataGridViewStyle.Mixed
        Me.kryptonDataGridView1.GridStyles.StyleBackground = Krypton.Toolkit.PaletteBackStyle.ControlClient
        Me.kryptonDataGridView1.HideOuterBorders = True
        Me.kryptonDataGridView1.Location = New System.Drawing.Point(0, 0)
        Me.kryptonDataGridView1.MultiSelect = False
        Me.kryptonDataGridView1.Name = "kryptonDataGridView1"
        Me.kryptonDataGridView1.ReadOnly = True
        Me.kryptonDataGridView1.RowHeadersVisible = False
        Me.kryptonDataGridView1.RowHeadersWidth = 51
        Me.kryptonDataGridView1.RowHeadersWidthSizeMode = System.Windows.Forms.DataGridViewRowHeadersWidthSizeMode.DisableResizing
        Me.kryptonDataGridView1.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect
        Me.kryptonDataGridView1.Size = New System.Drawing.Size(518, 181)
        Me.kryptonDataGridView1.StateCommon.BackStyle = Krypton.Toolkit.PaletteBackStyle.ControlClient
        Me.kryptonDataGridView1.StateCommon.DataCell.Border.DrawBorders = Krypton.Toolkit.PaletteDrawBorders.Bottom
        Me.kryptonDataGridView1.TabIndex = 0
        Me.dgName.DataPropertyName = "Name"
        Me.dgName.HeaderText = "Name"
        Me.dgName.MinimumWidth = 100
        Me.dgName.Name = "dgName"
        Me.dgName.ReadOnly = True
        Me.dgName.Width = 125
        Me.dgSubject.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill
        Me.dgSubject.DataPropertyName = "Subject"
        Me.dgSubject.HeaderText = "Subject"
        Me.dgSubject.MinimumWidth = 100
        Me.dgSubject.Name = "dgSubject"
        Me.dgSubject.ReadOnly = True
        Me.dgReceived.DataPropertyName = "Received"
        dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft
        Me.dgReceived.DefaultCellStyle = dataGridViewCellStyle1
        Me.dgReceived.HeaderText = "Received"
        Me.dgReceived.MinimumWidth = 100
        Me.dgReceived.Name = "dgReceived"
        Me.dgReceived.ReadOnly = True
        Me.dgReceived.Width = 125
        Me.dgSize.DataPropertyName = "Size"
        dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft
        Me.dgSize.DefaultCellStyle = dataGridViewCellStyle2
        Me.dgSize.HeaderText = "Size"
        Me.dgSize.MinimumWidth = 50
        Me.dgSize.Name = "dgSize"
        Me.dgSize.ReadOnly = True
        Me.dgSize.Width = 50
        Me.kryptonPageCalendarDetails.AutoHiddenSlideSize = New System.Drawing.Size(200, 200)
        Me.kryptonPageCalendarDetails.Controls.Add(Me.textBox1)
        Me.kryptonPageCalendarDetails.Flags = 65534
        Me.kryptonPageCalendarDetails.ImageLarge = CType(resources.GetObject("kryptonPageCalendarDetails.ImageLarge"), System.Drawing.Bitmap)
        Me.kryptonPageCalendarDetails.ImageMedium = CType(resources.GetObject("kryptonPageCalendarDetails.ImageMedium"), System.Drawing.Bitmap)
        Me.kryptonPageCalendarDetails.LastVisibleSet = True
        Me.kryptonPageCalendarDetails.MinimumSize = New System.Drawing.Size(50, 50)
        Me.kryptonPageCalendarDetails.Name = "kryptonPageCalendarDetails"
        Me.kryptonPageCalendarDetails.Padding = New System.Windows.Forms.Padding(5)
        Me.kryptonPageCalendarDetails.Size = New System.Drawing.Size(514, 205)
        Me.kryptonPageCalendarDetails.Text = "Calendar"
        Me.kryptonPageCalendarDetails.TextTitle = "Calendar"
        Me.kryptonPageCalendarDetails.ToolTipTitle = "Page ToolTip"
        Me.kryptonPageCalendarDetails.UniqueName = "7E4DA62769154DBD7E4DA62769154DBD"
        Me.textBox1.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.textBox1.Dock = System.Windows.Forms.DockStyle.Fill
        Me.textBox1.Font = New System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.textBox1.Location = New System.Drawing.Point(5, 5)
        Me.textBox1.Multiline = True
        Me.textBox1.Name = "textBox1"
        Me.textBox1.ScrollBars = System.Windows.Forms.ScrollBars.Both
        Me.textBox1.Size = New System.Drawing.Size(504, 195)
        Me.textBox1.TabIndex = 0
        Me.textBox1.Text = resources.GetString("textBox1.Text")
        Me.kryptonPageNotesDetails.AutoHiddenSlideSize = New System.Drawing.Size(200, 200)
        Me.kryptonPageNotesDetails.Controls.Add(Me.listViewNotes)
        Me.kryptonPageNotesDetails.Flags = 65534
        Me.kryptonPageNotesDetails.ImageLarge = CType(resources.GetObject("kryptonPageNotesDetails.ImageLarge"), System.Drawing.Bitmap)
        Me.kryptonPageNotesDetails.ImageMedium = CType(resources.GetObject("kryptonPageNotesDetails.ImageMedium"), System.Drawing.Bitmap)
        Me.kryptonPageNotesDetails.LastVisibleSet = True
        Me.kryptonPageNotesDetails.MinimumSize = New System.Drawing.Size(50, 50)
        Me.kryptonPageNotesDetails.Name = "kryptonPageNotesDetails"
        Me.kryptonPageNotesDetails.Padding = New System.Windows.Forms.Padding(3, 6, 0, 0)
        Me.kryptonPageNotesDetails.Size = New System.Drawing.Size(514, 205)
        Me.kryptonPageNotesDetails.Text = "Notes"
        Me.kryptonPageNotesDetails.TextTitle = "Notes"
        Me.kryptonPageNotesDetails.ToolTipTitle = "Page ToolTip"
        Me.kryptonPageNotesDetails.UniqueName = "44092B31BDA3475E44092B31BDA3475E"
        Me.listViewNotes.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.listViewNotes.Dock = System.Windows.Forms.DockStyle.Fill
        Me.listViewNotes.HideSelection = False
        Me.listViewNotes.LargeImageList = Me.imageListLarge
        Me.listViewNotes.Location = New System.Drawing.Point(3, 6)
        Me.listViewNotes.Name = "listViewNotes"
        Me.listViewNotes.Size = New System.Drawing.Size(511, 199)
        Me.listViewNotes.TabIndex = 0
        Me.listViewNotes.UseCompatibleStateImageBehavior = False
        Me.imageListLarge.ImageStream = CType(resources.GetObject("imageListLarge.ImageStream"), System.Windows.Forms.ImageListStreamer)
        Me.imageListLarge.TransparentColor = System.Drawing.Color.Transparent
        Me.imageListLarge.Images.SetKeyName(0, "note.png")
        Me.kryptonButtonGroup.Dock = System.Windows.Forms.DockStyle.Fill
        Me.kryptonButtonGroup.GroupBackStyle = Krypton.Toolkit.PaletteBackStyle.PanelAlternate
        Me.kryptonButtonGroup.GroupBorderStyle = Krypton.Toolkit.PaletteBorderStyle.ControlAlternate
        Me.kryptonButtonGroup.Location = New System.Drawing.Point(0, 0)
        Me.kryptonButtonGroup.Name = "kryptonButtonGroup"
        Me.kryptonButtonGroup.Panel.Controls.Add(Me.kryptonGroupInner)
        Me.kryptonButtonGroup.Panel.Padding = New System.Windows.Forms.Padding(5)
        Me.kryptonButtonGroup.Size = New System.Drawing.Size(520, 196)
        Me.kryptonButtonGroup.TabIndex = 0
        Me.kryptonGroupInner.Dock = System.Windows.Forms.DockStyle.Fill
        Me.kryptonGroupInner.Location = New System.Drawing.Point(5, 5)
        Me.kryptonGroupInner.Name = "kryptonGroupInner"
        Me.kryptonGroupInner.Panel.Controls.Add(Me.radioOffice2010Black)
        Me.kryptonGroupInner.Panel.Controls.Add(Me.radioOffice2010Silver)
        Me.kryptonGroupInner.Panel.Controls.Add(Me.radioOffice2010Blue)
        Me.kryptonGroupInner.Panel.Controls.Add(Me.radioSparkle)
        Me.kryptonGroupInner.Panel.Controls.Add(Me.radioSystem)
        Me.kryptonGroupInner.Panel.Controls.Add(Me.radioOffice2003)
        Me.kryptonGroupInner.Panel.Controls.Add(Me.radioOffice2007Black)
        Me.kryptonGroupInner.Panel.Controls.Add(Me.radioOffice2007Silver)
        Me.kryptonGroupInner.Panel.Controls.Add(Me.radioOffice2007Blue)
        Me.kryptonGroupInner.Size = New System.Drawing.Size(508, 184)
        Me.kryptonGroupInner.TabIndex = 0
        Me.radioOffice2010Black.Location = New System.Drawing.Point(17, 68)
        Me.radioOffice2010Black.Name = "radioOffice2010Black"
        Me.radioOffice2010Black.Size = New System.Drawing.Size(155, 26)
        Me.radioOffice2010Black.TabIndex = 2
        Me.radioOffice2010Black.Values.Text = "Office 2010 - Black"
        Me.radioOffice2010Silver.Location = New System.Drawing.Point(17, 45)
        Me.radioOffice2010Silver.Name = "radioOffice2010Silver"
        Me.radioOffice2010Silver.Size = New System.Drawing.Size(157, 26)
        Me.radioOffice2010Silver.TabIndex = 1
        Me.radioOffice2010Silver.Values.Text = "Office 2010 - Silver"
        Me.radioOffice2010Blue.Checked = True
        Me.radioOffice2010Blue.Location = New System.Drawing.Point(17, 20)
        Me.radioOffice2010Blue.Name = "radioOffice2010Blue"
        Me.radioOffice2010Blue.Size = New System.Drawing.Size(149, 26)
        Me.radioOffice2010Blue.TabIndex = 0
        Me.radioOffice2010Blue.Values.Text = "Office 2010 - Blue"
        Me.radioSparkle.Location = New System.Drawing.Point(288, 44)
        Me.radioSparkle.Name = "radioSparkle"
        Me.radioSparkle.Size = New System.Drawing.Size(78, 26)
        Me.radioSparkle.TabIndex = 7
        Me.radioSparkle.Values.Text = "Sparkle"
        Me.radioSystem.Location = New System.Drawing.Point(288, 68)
        Me.radioSystem.Name = "radioSystem"
        Me.radioSystem.Size = New System.Drawing.Size(76, 26)
        Me.radioSystem.TabIndex = 8
        Me.radioSystem.Values.Text = "System"
        Me.radioOffice2003.Location = New System.Drawing.Point(288, 20)
        Me.radioOffice2003.Name = "radioOffice2003"
        Me.radioOffice2003.Size = New System.Drawing.Size(105, 26)
        Me.radioOffice2003.TabIndex = 6
        Me.radioOffice2003.Values.Text = "Office 2003"
        Me.radioOffice2007Black.Location = New System.Drawing.Point(153, 68)
        Me.radioOffice2007Black.Name = "radioOffice2007Black"
        Me.radioOffice2007Black.Size = New System.Drawing.Size(155, 26)
        Me.radioOffice2007Black.TabIndex = 5
        Me.radioOffice2007Black.Values.Text = "Office 2007 - Black"
        Me.radioOffice2007Silver.Location = New System.Drawing.Point(153, 45)
        Me.radioOffice2007Silver.Name = "radioOffice2007Silver"
        Me.radioOffice2007Silver.Size = New System.Drawing.Size(157, 26)
        Me.radioOffice2007Silver.TabIndex = 4
        Me.radioOffice2007Silver.Values.Text = "Office 2007 - Silver"
        Me.radioOffice2007Blue.Location = New System.Drawing.Point(153, 20)
        Me.radioOffice2007Blue.Name = "radioOffice2007Blue"
        Me.radioOffice2007Blue.Size = New System.Drawing.Size(149, 26)
        Me.radioOffice2007Blue.TabIndex = 3
        Me.radioOffice2007Blue.Values.Text = "Office 2007 - Blue"
        Me.kryptonManager.GlobalPaletteMode = Krypton.Toolkit.PaletteMode.ProfessionalSystem
        Me.dataSet.DataSetName = "NewDataSet"
        Me.dataSet.Tables.AddRange(New System.Data.DataTable() { Me.dtDeletedItems, Me.dtDrafts, Me.dtFamily, Me.dtOutbox, Me.dtSentItems, Me.dtFriends, Me.dtWork, Me.dtInbox})
        Me.dtDeletedItems.Columns.AddRange(New System.Data.DataColumn() { Me.dataColumn1, Me.dataColumn2, Me.dataColumn3, Me.dataColumn4})
        Me.dtDeletedItems.TableName = "Deleted Items"
        Me.dataColumn1.ColumnName = "Name"
        Me.dataColumn2.ColumnName = "Subject"
        Me.dataColumn3.ColumnName = "Received"
        Me.dataColumn4.ColumnName = "Size"
        Me.dtDrafts.Columns.AddRange(New System.Data.DataColumn() { Me.dataColumn5, Me.dataColumn6, Me.dataColumn7, Me.dataColumn8})
        Me.dtDrafts.TableName = "Drafts"
        Me.dataColumn5.ColumnName = "Name"
        Me.dataColumn6.ColumnName = "Subject"
        Me.dataColumn7.ColumnName = "Received"
        Me.dataColumn8.ColumnName = "Size"
        Me.dtFamily.Columns.AddRange(New System.Data.DataColumn() { Me.dataColumn9, Me.dataColumn10, Me.dataColumn11, Me.dataColumn12})
        Me.dtFamily.TableName = "Family"
        Me.dataColumn9.ColumnName = "Name"
        Me.dataColumn10.ColumnName = "Subject"
        Me.dataColumn11.ColumnName = "Received"
        Me.dataColumn12.ColumnName = "Size"
        Me.dtOutbox.Columns.AddRange(New System.Data.DataColumn() { Me.dataColumn13, Me.dataColumn14, Me.dataColumn15, Me.dataColumn16})
        Me.dtOutbox.TableName = "Outbox"
        Me.dataColumn13.ColumnName = "Name"
        Me.dataColumn14.ColumnName = "Subject"
        Me.dataColumn15.ColumnName = "Received"
        Me.dataColumn16.ColumnName = "Size"
        Me.dtSentItems.Columns.AddRange(New System.Data.DataColumn() { Me.dataColumn17, Me.dataColumn18, Me.dataColumn19, Me.dataColumn20})
        Me.dtSentItems.TableName = "Sent Items"
        Me.dataColumn17.ColumnName = "Name"
        Me.dataColumn18.ColumnName = "Subject"
        Me.dataColumn19.ColumnName = "Received"
        Me.dataColumn20.ColumnName = "Size"
        Me.dtFriends.Columns.AddRange(New System.Data.DataColumn() { Me.dataColumn21, Me.dataColumn22, Me.dataColumn23, Me.dataColumn24})
        Me.dtFriends.TableName = "Friends"
        Me.dataColumn21.ColumnName = "Name"
        Me.dataColumn22.ColumnName = "Subject"
        Me.dataColumn23.ColumnName = "Received"
        Me.dataColumn24.ColumnName = "Size"
        Me.dtWork.Columns.AddRange(New System.Data.DataColumn() { Me.dataColumn25, Me.dataColumn26, Me.dataColumn27, Me.dataColumn28})
        Me.dtWork.TableName = "Work"
        Me.dataColumn25.ColumnName = "Work"
        Me.dataColumn26.ColumnName = "Subject"
        Me.dataColumn27.ColumnName = "Received"
        Me.dataColumn28.ColumnName = "Size"
        Me.dtInbox.Columns.AddRange(New System.Data.DataColumn() { Me.dataColumn29, Me.dataColumn30, Me.dataColumn31, Me.dataColumn32})
        Me.dtInbox.TableName = "Inbox"
        Me.dataColumn29.ColumnName = "Name"
        Me.dataColumn30.ColumnName = "Subject"
        Me.dataColumn31.ColumnName = "Received"
        Me.dataColumn32.ColumnName = "Size"
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8F, 17F)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(716, 485)
        Me.Controls.Add(Me.toolStripContainer1)
        Me.Controls.Add(Me.menuStrip1)
        Me.Font = New System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.MainMenuStrip = Me.menuStrip1
        Me.MinimumSize = New System.Drawing.Size(417, 308)
        Me.Name = "Form1"
        Me.Text = "Outlook 2003 Mockup"
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
        CType(Me.kryptonNavigatorMain, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.kryptonPageMail, System.ComponentModel.ISupportInitialize).EndInit()
        Me.kryptonPageMail.ResumeLayout(False)
        Me.kryptonPageMail.PerformLayout()
        CType(Me.kryptonPageCalendar, System.ComponentModel.ISupportInitialize).EndInit()
        Me.kryptonPageCalendar.ResumeLayout(False)
        CType(Me.kryptonPageNotes, System.ComponentModel.ISupportInitialize).EndInit()
        Me.kryptonPageNotes.ResumeLayout(False)
        Me.kryptonPageNotes.PerformLayout()
        CType(Me.kryptonSplitContainerDetails.Panel1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.kryptonSplitContainerDetails.Panel1.ResumeLayout(False)
        CType(Me.kryptonSplitContainerDetails.Panel2, System.ComponentModel.ISupportInitialize).EndInit()
        Me.kryptonSplitContainerDetails.Panel2.ResumeLayout(False)
        CType(Me.kryptonSplitContainerDetails, System.ComponentModel.ISupportInitialize).EndInit()
        Me.kryptonSplitContainerDetails.ResumeLayout(False)
        CType(Me.kryptonNavigatorDetails, System.ComponentModel.ISupportInitialize).EndInit()
        Me.kryptonNavigatorDetails.ResumeLayout(False)
        CType(Me.kryptonPageMailDetails, System.ComponentModel.ISupportInitialize).EndInit()
        Me.kryptonPageMailDetails.ResumeLayout(False)
        CType(Me.kryptonDataGridView1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.kryptonPageCalendarDetails, System.ComponentModel.ISupportInitialize).EndInit()
        Me.kryptonPageCalendarDetails.ResumeLayout(False)
        Me.kryptonPageCalendarDetails.PerformLayout()
        CType(Me.kryptonPageNotesDetails, System.ComponentModel.ISupportInitialize).EndInit()
        Me.kryptonPageNotesDetails.ResumeLayout(False)
        CType(Me.kryptonButtonGroup.Panel, System.ComponentModel.ISupportInitialize).EndInit()
        Me.kryptonButtonGroup.Panel.ResumeLayout(False)
        CType(Me.kryptonButtonGroup, System.ComponentModel.ISupportInitialize).EndInit()
        Me.kryptonButtonGroup.ResumeLayout(False)
        CType(Me.kryptonGroupInner.Panel, System.ComponentModel.ISupportInitialize).EndInit()
        Me.kryptonGroupInner.Panel.ResumeLayout(False)
        Me.kryptonGroupInner.Panel.PerformLayout()
        CType(Me.kryptonGroupInner, System.ComponentModel.ISupportInitialize).EndInit()
        Me.kryptonGroupInner.ResumeLayout(False)
        CType(Me.dataSet, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.dtDeletedItems, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.dtDrafts, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.dtFamily, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.dtOutbox, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.dtSentItems, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.dtFriends, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.dtWork, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.dtInbox, System.ComponentModel.ISupportInitialize).EndInit()
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
    Friend WithEvents kryptonSplitContainerDetails As Krypton.Toolkit.KryptonSplitContainer
    Friend WithEvents kryptonButtonGroup As Krypton.Toolkit.KryptonGroup
    Friend WithEvents kryptonManager As Krypton.Toolkit.KryptonManager
    Friend WithEvents kryptonGroupInner As Krypton.Toolkit.KryptonGroup
    Friend WithEvents kryptonNavigatorMain As Krypton.Navigator.KryptonNavigator
    Friend WithEvents kryptonPageMail As Krypton.Navigator.KryptonPage
    Friend WithEvents kryptonPageCalendar As Krypton.Navigator.KryptonPage
    Friend WithEvents kryptonPageNotes As Krypton.Navigator.KryptonPage
    Friend WithEvents treeViewMailFolders As System.Windows.Forms.TreeView
    Friend WithEvents imageListSmall As System.Windows.Forms.ImageList
    Friend WithEvents monthCalendar1 As System.Windows.Forms.MonthCalendar
    Friend WithEvents kryptonNavigatorDetails As Krypton.Navigator.KryptonNavigator
    Friend WithEvents kryptonPageMailDetails As Krypton.Navigator.KryptonPage
    Friend WithEvents kryptonPageCalendarDetails As Krypton.Navigator.KryptonPage
    Friend WithEvents kryptonPageNotesDetails As Krypton.Navigator.KryptonPage
    Friend WithEvents listViewNotes As System.Windows.Forms.ListView
    Friend WithEvents imageListLarge As System.Windows.Forms.ImageList
    Friend WithEvents treeViewMailFavs As System.Windows.Forms.TreeView
    Friend WithEvents kryptonHeaderFolders As Krypton.Toolkit.KryptonHeader
    Friend WithEvents kryptonHeaderFavorites As Krypton.Toolkit.KryptonHeader
    Friend WithEvents panelFoldersSep As System.Windows.Forms.Panel
    Friend WithEvents panelFavoriteSep As System.Windows.Forms.Panel
    Friend WithEvents textBox1 As System.Windows.Forms.TextBox
    Friend WithEvents buttonSpecExpandCollapse As Krypton.Navigator.ButtonSpecNavigator
    Friend WithEvents radioSystem As Krypton.Toolkit.KryptonRadioButton
    Friend WithEvents radioOffice2003 As Krypton.Toolkit.KryptonRadioButton
    Friend WithEvents radioOffice2007Black As Krypton.Toolkit.KryptonRadioButton
    Friend WithEvents radioOffice2007Silver As Krypton.Toolkit.KryptonRadioButton
    Friend WithEvents radioOffice2007Blue As Krypton.Toolkit.KryptonRadioButton
    Friend WithEvents radioFriends As Krypton.Toolkit.KryptonRadioButton
    Friend WithEvents radioFamily As Krypton.Toolkit.KryptonRadioButton
    Friend WithEvents radioProject As Krypton.Toolkit.KryptonRadioButton
    Friend WithEvents kryptonDataGridView1 As Krypton.Toolkit.KryptonDataGridView
    Friend WithEvents dataSet As System.Data.DataSet
    Friend WithEvents dtDeletedItems As System.Data.DataTable
    Friend WithEvents dataColumn1 As System.Data.DataColumn
    Friend WithEvents dataColumn2 As System.Data.DataColumn
    Friend WithEvents dataColumn3 As System.Data.DataColumn
    Friend WithEvents dataColumn4 As System.Data.DataColumn
    Friend WithEvents dtDrafts As System.Data.DataTable
    Friend WithEvents dataColumn5 As System.Data.DataColumn
    Friend WithEvents dataColumn6 As System.Data.DataColumn
    Friend WithEvents dataColumn7 As System.Data.DataColumn
    Friend WithEvents dataColumn8 As System.Data.DataColumn
    Friend WithEvents dtFamily As System.Data.DataTable
    Friend WithEvents dataColumn9 As System.Data.DataColumn
    Friend WithEvents dataColumn10 As System.Data.DataColumn
    Friend WithEvents dataColumn11 As System.Data.DataColumn
    Friend WithEvents dataColumn12 As System.Data.DataColumn
    Friend WithEvents dtOutbox As System.Data.DataTable
    Friend WithEvents dataColumn13 As System.Data.DataColumn
    Friend WithEvents dataColumn14 As System.Data.DataColumn
    Friend WithEvents dataColumn15 As System.Data.DataColumn
    Friend WithEvents dataColumn16 As System.Data.DataColumn
    Friend WithEvents dtSentItems As System.Data.DataTable
    Friend WithEvents dataColumn17 As System.Data.DataColumn
    Friend WithEvents dataColumn18 As System.Data.DataColumn
    Friend WithEvents dataColumn19 As System.Data.DataColumn
    Friend WithEvents dataColumn20 As System.Data.DataColumn
    Friend WithEvents dtFriends As System.Data.DataTable
    Friend WithEvents dataColumn21 As System.Data.DataColumn
    Friend WithEvents dataColumn22 As System.Data.DataColumn
    Friend WithEvents dataColumn23 As System.Data.DataColumn
    Friend WithEvents dataColumn24 As System.Data.DataColumn
    Friend WithEvents dtWork As System.Data.DataTable
    Friend WithEvents dataColumn25 As System.Data.DataColumn
    Friend WithEvents dataColumn26 As System.Data.DataColumn
    Friend WithEvents dataColumn27 As System.Data.DataColumn
    Friend WithEvents dataColumn28 As System.Data.DataColumn
    Friend WithEvents dtInbox As System.Data.DataTable
    Friend WithEvents dataColumn29 As System.Data.DataColumn
    Friend WithEvents dataColumn30 As System.Data.DataColumn
    Friend WithEvents dataColumn31 As System.Data.DataColumn
    Friend WithEvents dataColumn32 As System.Data.DataColumn
    Friend WithEvents dgName As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents dgSubject As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents dgReceived As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents dgSize As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents radioSparkle As Krypton.Toolkit.KryptonRadioButton
    Friend WithEvents radioOffice2010Black As Krypton.Toolkit.KryptonRadioButton
    Friend WithEvents radioOffice2010Silver As Krypton.Toolkit.KryptonRadioButton
    Friend WithEvents radioOffice2010Blue As Krypton.Toolkit.KryptonRadioButton
End Class
