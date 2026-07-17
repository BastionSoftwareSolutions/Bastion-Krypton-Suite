' VB.NET twin of Source\Krypton Toolkit Examples\Three Pane Application (Extended)\Form1.Designer.cs (Bastion Phase 4c).
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
        Dim treeNode1 As System.Windows.Forms.TreeNode = New System.Windows.Forms.TreeNode("Staff reviews", 1, 1)
        Dim treeNode2 As System.Windows.Forms.TreeNode = New System.Windows.Forms.TreeNode("Job interviews", 1, 1)
        Dim treeNode3 As System.Windows.Forms.TreeNode = New System.Windows.Forms.TreeNode("Project meetings", 1, 1)
        Dim treeNode4 As System.Windows.Forms.TreeNode = New System.Windows.Forms.TreeNode("Appointments", 0, 0, New System.Windows.Forms.TreeNode() { treeNode1, treeNode2, treeNode3})
        Dim treeNode5 As System.Windows.Forms.TreeNode = New System.Windows.Forms.TreeNode("Administration", 2, 2)
        Dim treeNode6 As System.Windows.Forms.TreeNode = New System.Windows.Forms.TreeNode("Programmers", 3, 3)
        Dim treeNode7 As System.Windows.Forms.TreeNode = New System.Windows.Forms.TreeNode("Managers", 4, 4)
        Dim treeNode8 As System.Windows.Forms.TreeNode = New System.Windows.Forms.TreeNode("Employees", 0, 0, New System.Windows.Forms.TreeNode() { treeNode5, treeNode6, treeNode7})
        Dim dataGridViewCellStyle1 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim dataGridViewCellStyle2 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim dataGridViewCellStyle3 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim dataGridViewCellStyle4 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim dataGridViewCellStyle5 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim dataGridViewCellStyle6 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Me.menuStrip = New System.Windows.Forms.MenuStrip()
        Me.fileToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.loadPaletteToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.toolStripSeparator2 = New System.Windows.Forms.ToolStripSeparator()
        Me.office2010BlueToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.office2010SilverToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.office2010BlackToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.toolStripSeparator3 = New System.Windows.Forms.ToolStripSeparator()
        Me.office2007BlueToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.office2007SilverToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.office2007BlackToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.toolStripSeparator4 = New System.Windows.Forms.ToolStripSeparator()
        Me.sparkleBlueToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.sparkleOrangeToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.sparklePurpleToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.toolStripSeparator5 = New System.Windows.Forms.ToolStripSeparator()
        Me.systemToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.customToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.toolStripMenuItem1 = New System.Windows.Forms.ToolStripSeparator()
        Me.exitToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.toolsToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.readingPaneToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.panePositonToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.toolStripGeneral = New System.Windows.Forms.ToolStrip()
        Me.toolStripLoadPalette = New System.Windows.Forms.ToolStripButton()
        Me.toolStripSeparator1 = New System.Windows.Forms.ToolStripSeparator()
        Me.toolStripReadingPane = New System.Windows.Forms.ToolStripButton()
        Me.toolStripPosition = New System.Windows.Forms.ToolStripButton()
        Me.toolStripContainer1 = New System.Windows.Forms.ToolStripContainer()
        Me.kryptonPanelMain = New Krypton.Toolkit.KryptonPanel()
        Me.kryptonSplitContainerMain = New Krypton.Toolkit.KryptonSplitContainer()
        Me.kryptonHeaderGroupNavigation = New Krypton.Toolkit.KryptonHeaderGroup()
        Me.treeView = New System.Windows.Forms.TreeView()
        Me.imageList = New System.Windows.Forms.ImageList(Me.components)
        Me.kryptonSplitContainerDetails = New Krypton.Toolkit.KryptonSplitContainer()
        Me.kryptonHeaderGroupDetails = New Krypton.Toolkit.KryptonHeaderGroup()
        Me.buttonSpecPrevious = New Krypton.Toolkit.ButtonSpecHeaderGroup()
        Me.buttonSpecNext = New Krypton.Toolkit.ButtonSpecHeaderGroup()
        Me.kryptonDataGridView = New Krypton.Toolkit.KryptonDataGridView()
        Me.dgValid = New Krypton.Toolkit.KryptonDataGridViewCheckBoxColumn()
        Me.dgName = New Krypton.Toolkit.KryptonDataGridViewTextBoxColumn()
        Me.dgDescription = New Krypton.Toolkit.KryptonDataGridViewTextBoxColumn()
        Me.dgDetails = New Krypton.Toolkit.KryptonDataGridViewTextBoxColumn()
        Me.dgDepartment = New Krypton.Toolkit.KryptonDataGridViewTextBoxColumn()
        Me.dgCategory = New Krypton.Toolkit.KryptonDataGridViewTextBoxColumn()
        Me.kryptonReadingGroupOuter = New Krypton.Toolkit.KryptonGroup()
        Me.kryptonReadingLabel = New Krypton.Toolkit.KryptonLabel()
        Me.toolStrip2010 = New System.Windows.Forms.ToolStrip()
        Me.toolStripOffice2010Blue = New System.Windows.Forms.ToolStripButton()
        Me.toolStripOffice2010Silver = New System.Windows.Forms.ToolStripButton()
        Me.toolStripOffice2010Black = New System.Windows.Forms.ToolStripButton()
        Me.toolStrip2007 = New System.Windows.Forms.ToolStrip()
        Me.toolStripOffice2007Blue = New System.Windows.Forms.ToolStripButton()
        Me.toolStripOffice2007Silver = New System.Windows.Forms.ToolStripButton()
        Me.toolStripOffice2007Black = New System.Windows.Forms.ToolStripButton()
        Me.toolStripOther = New System.Windows.Forms.ToolStrip()
        Me.toolStripSystem = New System.Windows.Forms.ToolStripButton()
        Me.toolStripCustom = New System.Windows.Forms.ToolStripButton()
        Me.toolStripSparkle = New System.Windows.Forms.ToolStrip()
        Me.toolStripSparkleBlue = New System.Windows.Forms.ToolStripButton()
        Me.toolStripSparkleOrange = New System.Windows.Forms.ToolStripButton()
        Me.toolStripSparklePurple = New System.Windows.Forms.ToolStripButton()
        Me.dataSet = New System.Data.DataSet()
        Me.dataTable = New System.Data.DataTable()
        Me.colName = New System.Data.DataColumn()
        Me.colDescription = New System.Data.DataColumn()
        Me.colDetails = New System.Data.DataColumn()
        Me.colDepartment = New System.Data.DataColumn()
        Me.colCategory = New System.Data.DataColumn()
        Me.dataColumn1 = New System.Data.DataColumn()
        Me.kryptonManager = New Krypton.Toolkit.KryptonManager(Me.components)
        Me.kryptonPaletteCustom = New Krypton.Toolkit.KryptonCustomPaletteBase(Me.components)
        Me.statusStrip = New System.Windows.Forms.StatusStrip()
        Me.menuStrip.SuspendLayout()
        Me.toolStripGeneral.SuspendLayout()
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
        Me.kryptonHeaderGroupNavigation.Panel.SuspendLayout()
        Me.kryptonHeaderGroupNavigation.SuspendLayout()
        CType(Me.kryptonSplitContainerDetails, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.kryptonSplitContainerDetails.Panel1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.kryptonSplitContainerDetails.Panel1.SuspendLayout()
        CType(Me.kryptonSplitContainerDetails.Panel2, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.kryptonSplitContainerDetails.Panel2.SuspendLayout()
        Me.kryptonSplitContainerDetails.SuspendLayout()
        CType(Me.kryptonHeaderGroupDetails, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.kryptonHeaderGroupDetails.Panel, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.kryptonHeaderGroupDetails.Panel.SuspendLayout()
        Me.kryptonHeaderGroupDetails.SuspendLayout()
        CType(Me.kryptonDataGridView, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.kryptonReadingGroupOuter, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.kryptonReadingGroupOuter.Panel, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.kryptonReadingGroupOuter.Panel.SuspendLayout()
        Me.kryptonReadingGroupOuter.SuspendLayout()
        Me.toolStrip2010.SuspendLayout()
        Me.toolStrip2007.SuspendLayout()
        Me.toolStripOther.SuspendLayout()
        Me.toolStripSparkle.SuspendLayout()
        CType(Me.dataSet, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.dataTable, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        Me.menuStrip.Dock = System.Windows.Forms.DockStyle.None
        Me.menuStrip.Font = New System.Drawing.Font("Segoe UI", 9F)
        Me.menuStrip.ImageScalingSize = New System.Drawing.Size(20, 20)
        Me.menuStrip.Items.AddRange(New System.Windows.Forms.ToolStripItem() { Me.fileToolStripMenuItem, Me.toolsToolStripMenuItem})
        Me.menuStrip.Location = New System.Drawing.Point(0, 81)
        Me.menuStrip.Name = "menuStrip"
        Me.menuStrip.Size = New System.Drawing.Size(634, 28)
        Me.menuStrip.TabIndex = 0
        Me.menuStrip.Text = "menuStrip1"
        Me.fileToolStripMenuItem.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() { Me.loadPaletteToolStripMenuItem, Me.toolStripSeparator2, Me.office2010BlueToolStripMenuItem, Me.office2010SilverToolStripMenuItem, Me.office2010BlackToolStripMenuItem, Me.toolStripSeparator3, Me.office2007BlueToolStripMenuItem, Me.office2007SilverToolStripMenuItem, Me.office2007BlackToolStripMenuItem, Me.toolStripSeparator4, Me.sparkleBlueToolStripMenuItem, Me.sparkleOrangeToolStripMenuItem, Me.sparklePurpleToolStripMenuItem, Me.toolStripSeparator5, Me.systemToolStripMenuItem, Me.customToolStripMenuItem, Me.toolStripMenuItem1, Me.exitToolStripMenuItem})
        Me.fileToolStripMenuItem.Name = "fileToolStripMenuItem"
        Me.fileToolStripMenuItem.Size = New System.Drawing.Size(46, 24)
        Me.fileToolStripMenuItem.Text = "&File"
        Me.loadPaletteToolStripMenuItem.Image = CType(resources.GetObject("loadPaletteToolStripMenuItem.Image"), System.Drawing.Image)
        Me.loadPaletteToolStripMenuItem.Name = "loadPaletteToolStripMenuItem"
        Me.loadPaletteToolStripMenuItem.Size = New System.Drawing.Size(208, 26)
        Me.loadPaletteToolStripMenuItem.Text = "Load Palette"
        Me.toolStripSeparator2.Name = "toolStripSeparator2"
        Me.toolStripSeparator2.Size = New System.Drawing.Size(205, 6)
        Me.office2010BlueToolStripMenuItem.Checked = True
        Me.office2010BlueToolStripMenuItem.CheckState = System.Windows.Forms.CheckState.Checked
        Me.office2010BlueToolStripMenuItem.Name = "office2010BlueToolStripMenuItem"
        Me.office2010BlueToolStripMenuItem.Size = New System.Drawing.Size(208, 26)
        Me.office2010BlueToolStripMenuItem.Text = "Office 2010 Blue"
        Me.office2010SilverToolStripMenuItem.Name = "office2010SilverToolStripMenuItem"
        Me.office2010SilverToolStripMenuItem.Size = New System.Drawing.Size(208, 26)
        Me.office2010SilverToolStripMenuItem.Text = "Office 2010 Silver"
        Me.office2010BlackToolStripMenuItem.Name = "office2010BlackToolStripMenuItem"
        Me.office2010BlackToolStripMenuItem.Size = New System.Drawing.Size(208, 26)
        Me.office2010BlackToolStripMenuItem.Text = "Office 2010 Black"
        Me.toolStripSeparator3.Name = "toolStripSeparator3"
        Me.toolStripSeparator3.Size = New System.Drawing.Size(205, 6)
        Me.office2007BlueToolStripMenuItem.Name = "office2007BlueToolStripMenuItem"
        Me.office2007BlueToolStripMenuItem.Size = New System.Drawing.Size(208, 26)
        Me.office2007BlueToolStripMenuItem.Text = "Office 2007 Blue"
        Me.office2007SilverToolStripMenuItem.Name = "office2007SilverToolStripMenuItem"
        Me.office2007SilverToolStripMenuItem.Size = New System.Drawing.Size(208, 26)
        Me.office2007SilverToolStripMenuItem.Text = "Office 2007 Silver"
        Me.office2007SilverToolStripMenuItem.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.office2007BlackToolStripMenuItem.Name = "office2007BlackToolStripMenuItem"
        Me.office2007BlackToolStripMenuItem.Size = New System.Drawing.Size(208, 26)
        Me.office2007BlackToolStripMenuItem.Text = "Office 2007 Black"
        Me.toolStripSeparator4.Name = "toolStripSeparator4"
        Me.toolStripSeparator4.Size = New System.Drawing.Size(205, 6)
        Me.sparkleBlueToolStripMenuItem.Name = "sparkleBlueToolStripMenuItem"
        Me.sparkleBlueToolStripMenuItem.Size = New System.Drawing.Size(208, 26)
        Me.sparkleBlueToolStripMenuItem.Text = "Sparkle Blue"
        Me.sparkleOrangeToolStripMenuItem.Name = "sparkleOrangeToolStripMenuItem"
        Me.sparkleOrangeToolStripMenuItem.Size = New System.Drawing.Size(208, 26)
        Me.sparkleOrangeToolStripMenuItem.Text = "Sparkle Orange"
        Me.sparklePurpleToolStripMenuItem.Name = "sparklePurpleToolStripMenuItem"
        Me.sparklePurpleToolStripMenuItem.Size = New System.Drawing.Size(208, 26)
        Me.sparklePurpleToolStripMenuItem.Text = "Sparkle Purple"
        Me.toolStripSeparator5.Name = "toolStripSeparator5"
        Me.toolStripSeparator5.Size = New System.Drawing.Size(205, 6)
        Me.systemToolStripMenuItem.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.systemToolStripMenuItem.Name = "systemToolStripMenuItem"
        Me.systemToolStripMenuItem.Size = New System.Drawing.Size(208, 26)
        Me.systemToolStripMenuItem.Text = "System"
        Me.customToolStripMenuItem.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.customToolStripMenuItem.Name = "customToolStripMenuItem"
        Me.customToolStripMenuItem.Size = New System.Drawing.Size(208, 26)
        Me.customToolStripMenuItem.Text = "Custom"
        Me.toolStripMenuItem1.Name = "toolStripMenuItem1"
        Me.toolStripMenuItem1.Size = New System.Drawing.Size(205, 6)
        Me.exitToolStripMenuItem.Name = "exitToolStripMenuItem"
        Me.exitToolStripMenuItem.Size = New System.Drawing.Size(208, 26)
        Me.exitToolStripMenuItem.Text = "E&xit"
        Me.toolsToolStripMenuItem.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() { Me.readingPaneToolStripMenuItem, Me.panePositonToolStripMenuItem})
        Me.toolsToolStripMenuItem.Name = "toolsToolStripMenuItem"
        Me.toolsToolStripMenuItem.Size = New System.Drawing.Size(75, 24)
        Me.toolsToolStripMenuItem.Text = "&Options"
        Me.readingPaneToolStripMenuItem.Name = "readingPaneToolStripMenuItem"
        Me.readingPaneToolStripMenuItem.Size = New System.Drawing.Size(238, 26)
        Me.readingPaneToolStripMenuItem.Text = "Hide &Reading Pane"
        Me.panePositonToolStripMenuItem.Name = "panePositonToolStripMenuItem"
        Me.panePositonToolStripMenuItem.Size = New System.Drawing.Size(238, 26)
        Me.panePositonToolStripMenuItem.Text = "Reading Pane &Position"
        Me.toolStripGeneral.Dock = System.Windows.Forms.DockStyle.None
        Me.toolStripGeneral.Font = New System.Drawing.Font("Segoe UI", 9F)
        Me.toolStripGeneral.ImageScalingSize = New System.Drawing.Size(20, 20)
        Me.toolStripGeneral.Items.AddRange(New System.Windows.Forms.ToolStripItem() { Me.toolStripLoadPalette, Me.toolStripSeparator1, Me.toolStripReadingPane, Me.toolStripPosition})
        Me.toolStripGeneral.Location = New System.Drawing.Point(7, 0)
        Me.toolStripGeneral.Name = "toolStripGeneral"
        Me.toolStripGeneral.Size = New System.Drawing.Size(143, 27)
        Me.toolStripGeneral.TabIndex = 1
        Me.toolStripGeneral.Text = "toolStrip1"
        Me.toolStripLoadPalette.Image = CType(resources.GetObject("toolStripLoadPalette.Image"), System.Drawing.Image)
        Me.toolStripLoadPalette.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.toolStripLoadPalette.Name = "toolStripLoadPalette"
        Me.toolStripLoadPalette.Size = New System.Drawing.Size(66, 24)
        Me.toolStripLoadPalette.Text = "Load"
        Me.toolStripLoadPalette.ToolTipText = "Load a palette definition"
        Me.toolStripSeparator1.Name = "toolStripSeparator1"
        Me.toolStripSeparator1.Size = New System.Drawing.Size(6, 27)
        Me.toolStripReadingPane.CheckOnClick = True
        Me.toolStripReadingPane.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image
        Me.toolStripReadingPane.Image = CType(resources.GetObject("toolStripReadingPane.Image"), System.Drawing.Image)
        Me.toolStripReadingPane.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.toolStripReadingPane.Name = "toolStripReadingPane"
        Me.toolStripReadingPane.Size = New System.Drawing.Size(29, 24)
        Me.toolStripReadingPane.ToolTipText = "Show/Hide the reading pane"
        Me.toolStripPosition.CheckOnClick = True
        Me.toolStripPosition.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image
        Me.toolStripPosition.Image = CType(resources.GetObject("toolStripPosition.Image"), System.Drawing.Image)
        Me.toolStripPosition.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.toolStripPosition.Name = "toolStripPosition"
        Me.toolStripPosition.Size = New System.Drawing.Size(29, 24)
        Me.toolStripPosition.ToolTipText = "Show reading pane on right or bottom"
        Me.toolStripContainer1.ContentPanel.AutoScroll = True
        Me.toolStripContainer1.ContentPanel.Controls.Add(Me.kryptonPanelMain)
        Me.toolStripContainer1.ContentPanel.Size = New System.Drawing.Size(634, 321)
        Me.toolStripContainer1.Dock = System.Windows.Forms.DockStyle.Fill
        Me.toolStripContainer1.Location = New System.Drawing.Point(0, 0)
        Me.toolStripContainer1.Name = "toolStripContainer1"
        Me.toolStripContainer1.Size = New System.Drawing.Size(634, 457)
        Me.toolStripContainer1.TabIndex = 1
        Me.toolStripContainer1.Text = "toolStripContainer1"
        Me.toolStripContainer1.TopToolStripPanel.Controls.Add(Me.toolStrip2010)
        Me.toolStripContainer1.TopToolStripPanel.Controls.Add(Me.toolStripGeneral)
        Me.toolStripContainer1.TopToolStripPanel.Controls.Add(Me.toolStrip2007)
        Me.toolStripContainer1.TopToolStripPanel.Controls.Add(Me.toolStripSparkle)
        Me.toolStripContainer1.TopToolStripPanel.Controls.Add(Me.toolStripOther)
        Me.toolStripContainer1.TopToolStripPanel.Controls.Add(Me.menuStrip)
        Me.kryptonPanelMain.Controls.Add(Me.kryptonSplitContainerMain)
        Me.kryptonPanelMain.Dock = System.Windows.Forms.DockStyle.Fill
        Me.kryptonPanelMain.Location = New System.Drawing.Point(0, 0)
        Me.kryptonPanelMain.Name = "kryptonPanelMain"
        Me.kryptonPanelMain.Padding = New System.Windows.Forms.Padding(4)
        Me.kryptonPanelMain.Size = New System.Drawing.Size(634, 321)
        Me.kryptonPanelMain.TabIndex = 0
        Me.kryptonSplitContainerMain.Cursor = System.Windows.Forms.Cursors.Default
        Me.kryptonSplitContainerMain.Dock = System.Windows.Forms.DockStyle.Fill
        Me.kryptonSplitContainerMain.FixedPanel = System.Windows.Forms.FixedPanel.Panel1
        Me.kryptonSplitContainerMain.Location = New System.Drawing.Point(4, 4)
        Me.kryptonSplitContainerMain.Name = "kryptonSplitContainerMain"
        Me.kryptonSplitContainerMain.Panel1.Controls.Add(Me.kryptonHeaderGroupNavigation)
        Me.kryptonSplitContainerMain.Panel2.Controls.Add(Me.kryptonSplitContainerDetails)
        Me.kryptonSplitContainerMain.Size = New System.Drawing.Size(626, 313)
        Me.kryptonSplitContainerMain.SplitterDistance = 176
        Me.kryptonSplitContainerMain.TabIndex = 0
        Me.kryptonHeaderGroupNavigation.Dock = System.Windows.Forms.DockStyle.Fill
        Me.kryptonHeaderGroupNavigation.Location = New System.Drawing.Point(0, 0)
        Me.kryptonHeaderGroupNavigation.Name = "kryptonHeaderGroupNavigation"
        Me.kryptonHeaderGroupNavigation.Panel.Controls.Add(Me.treeView)
        Me.kryptonHeaderGroupNavigation.Size = New System.Drawing.Size(176, 313)
        Me.kryptonHeaderGroupNavigation.TabIndex = 0
        Me.kryptonHeaderGroupNavigation.ValuesPrimary.Heading = "Navigation"
        Me.kryptonHeaderGroupNavigation.ValuesPrimary.Image = Nothing
        Me.kryptonHeaderGroupNavigation.ValuesSecondary.Heading = "Select option"
        Me.treeView.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.treeView.Dock = System.Windows.Forms.DockStyle.Fill
        Me.treeView.HideSelection = False
        Me.treeView.ImageIndex = 0
        Me.treeView.ImageList = Me.imageList
        Me.treeView.Location = New System.Drawing.Point(0, 0)
        Me.treeView.Name = "treeView"
        treeNode1.ImageIndex = 1
        treeNode1.Name = "NodeYearlyReview"
        treeNode1.SelectedImageIndex = 1
        treeNode1.Text = "Staff reviews"
        treeNode2.ImageIndex = 1
        treeNode2.Name = "NodeCandidateInterview"
        treeNode2.SelectedImageIndex = 1
        treeNode2.Text = "Job interviews"
        treeNode3.ImageIndex = 1
        treeNode3.Name = "NodeProjectMilestone"
        treeNode3.SelectedImageIndex = 1
        treeNode3.Text = "Project meetings"
        treeNode4.ImageIndex = 0
        treeNode4.Name = "NodeAppointments"
        treeNode4.SelectedImageIndex = 0
        treeNode4.Text = "Appointments"
        treeNode5.ImageIndex = 2
        treeNode5.Name = "NodeAdministration"
        treeNode5.SelectedImageIndex = 2
        treeNode5.Text = "Administration"
        treeNode6.ImageIndex = 3
        treeNode6.Name = "Programmers"
        treeNode6.SelectedImageIndex = 3
        treeNode6.Text = "Programmers"
        treeNode7.ImageIndex = 4
        treeNode7.Name = "NodeManagers"
        treeNode7.SelectedImageIndex = 4
        treeNode7.Text = "Managers"
        treeNode8.ImageIndex = 0
        treeNode8.Name = "NodeEmployees"
        treeNode8.SelectedImageIndex = 0
        treeNode8.Text = "Employees"
        Me.treeView.Nodes.AddRange(New System.Windows.Forms.TreeNode() { treeNode4, treeNode8})
        Me.treeView.SelectedImageIndex = 0
        Me.treeView.Size = New System.Drawing.Size(174, 250)
        Me.treeView.TabIndex = 0
        Me.imageList.ImageStream = CType(resources.GetObject("imageList.ImageStream"), System.Windows.Forms.ImageListStreamer)
        Me.imageList.TransparentColor = System.Drawing.Color.Transparent
        Me.imageList.Images.SetKeyName(0, "Folder.ico")
        Me.imageList.Images.SetKeyName(1, "calendar.png")
        Me.imageList.Images.SetKeyName(2, "user2.png")
        Me.imageList.Images.SetKeyName(3, "dude1.png")
        Me.imageList.Images.SetKeyName(4, "businessman2.png")
        Me.kryptonSplitContainerDetails.Cursor = System.Windows.Forms.Cursors.Default
        Me.kryptonSplitContainerDetails.Dock = System.Windows.Forms.DockStyle.Fill
        Me.kryptonSplitContainerDetails.Location = New System.Drawing.Point(0, 0)
        Me.kryptonSplitContainerDetails.Name = "kryptonSplitContainerDetails"
        Me.kryptonSplitContainerDetails.Orientation = System.Windows.Forms.Orientation.Horizontal
        Me.kryptonSplitContainerDetails.Panel1.Controls.Add(Me.kryptonHeaderGroupDetails)
        Me.kryptonSplitContainerDetails.Panel1MinSize = 50
        Me.kryptonSplitContainerDetails.Panel2.Controls.Add(Me.kryptonReadingGroupOuter)
        Me.kryptonSplitContainerDetails.Panel2MinSize = 50
        Me.kryptonSplitContainerDetails.Size = New System.Drawing.Size(445, 313)
        Me.kryptonSplitContainerDetails.SplitterDistance = 178
        Me.kryptonSplitContainerDetails.TabIndex = 0
        Me.kryptonHeaderGroupDetails.AllowButtonSpecToolTips = True
        Me.kryptonHeaderGroupDetails.ButtonSpecs.Add(Me.buttonSpecPrevious)
        Me.kryptonHeaderGroupDetails.ButtonSpecs.Add(Me.buttonSpecNext)
        Me.kryptonHeaderGroupDetails.Dock = System.Windows.Forms.DockStyle.Fill
        Me.kryptonHeaderGroupDetails.HeaderVisibleSecondary = False
        Me.kryptonHeaderGroupDetails.Location = New System.Drawing.Point(0, 0)
        Me.kryptonHeaderGroupDetails.Name = "kryptonHeaderGroupDetails"
        Me.kryptonHeaderGroupDetails.Panel.Controls.Add(Me.kryptonDataGridView)
        Me.kryptonHeaderGroupDetails.Size = New System.Drawing.Size(445, 178)
        Me.kryptonHeaderGroupDetails.TabIndex = 0
        Me.kryptonHeaderGroupDetails.ValuesPrimary.Image = CType(resources.GetObject("kryptonHeaderGroupDetails.ValuesPrimary.Image"), System.Drawing.Image)
        Me.buttonSpecPrevious.Image = CType(resources.GetObject("buttonSpecPrevious.Image"), System.Drawing.Image)
        Me.buttonSpecPrevious.ToolTipTitle = "Move to previous selection"
        Me.buttonSpecPrevious.Type = Krypton.Toolkit.PaletteButtonSpecStyle.Previous
        Me.buttonSpecPrevious.UniqueName = "5D8BDAFE5D4E48755D8BDAFE5D4E4875"
        Me.buttonSpecNext.Image = CType(resources.GetObject("buttonSpecNext.Image"), System.Drawing.Image)
        Me.buttonSpecNext.ToolTipTitle = "Move to next selection"
        Me.buttonSpecNext.Type = Krypton.Toolkit.PaletteButtonSpecStyle.Next
        Me.buttonSpecNext.UniqueName = "8C33B0A305634EC58C33B0A305634EC5"
        Me.kryptonDataGridView.AllowUserToAddRows = False
        Me.kryptonDataGridView.AllowUserToDeleteRows = False
        Me.kryptonDataGridView.AllowUserToResizeRows = False
        Me.kryptonDataGridView.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.kryptonDataGridView.ColumnHeadersHeight = 36
        Me.kryptonDataGridView.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() { Me.dgValid, Me.dgName, Me.dgDescription, Me.dgDetails, Me.dgDepartment, Me.dgCategory})
        Me.kryptonDataGridView.Dock = System.Windows.Forms.DockStyle.Fill
        Me.kryptonDataGridView.GridStyles.Style = Krypton.Toolkit.DataGridViewStyle.Mixed
        Me.kryptonDataGridView.GridStyles.StyleBackground = Krypton.Toolkit.PaletteBackStyle.ControlClient
        Me.kryptonDataGridView.HideOuterBorders = True
        Me.kryptonDataGridView.Location = New System.Drawing.Point(0, 0)
        Me.kryptonDataGridView.MultiSelect = False
        Me.kryptonDataGridView.Name = "kryptonDataGridView"
        Me.kryptonDataGridView.ReadOnly = True
        Me.kryptonDataGridView.RowHeadersVisible = False
        Me.kryptonDataGridView.RowHeadersWidth = 51
        Me.kryptonDataGridView.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect
        Me.kryptonDataGridView.Size = New System.Drawing.Size(443, 140)
        Me.kryptonDataGridView.TabIndex = 0
        Me.dgValid.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells
        Me.dgValid.DataPropertyName = "Valid"
        dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter
        dataGridViewCellStyle1.NullValue = False
        Me.dgValid.DefaultCellStyle = dataGridViewCellStyle1
        Me.dgValid.FalseValue = Nothing
        Me.dgValid.HeaderText = "Valid"
        Me.dgValid.IndeterminateValue = Nothing
        Me.dgValid.MinimumWidth = 6
        Me.dgValid.Name = "dgValid"
        Me.dgValid.ReadOnly = True
        Me.dgValid.TrueValue = Nothing
        Me.dgValid.Width = 52
        Me.dgName.DataPropertyName = "Name"
        Me.dgName.DefaultCellStyle = dataGridViewCellStyle2
        Me.dgName.HeaderText = "Name"
        Me.dgName.MinimumWidth = 60
        Me.dgName.Name = "dgName"
        Me.dgName.ReadOnly = True
        Me.dgName.Resizable = System.Windows.Forms.DataGridViewTriState.True
        Me.dgName.Width = 120
        Me.dgDescription.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill
        Me.dgDescription.DataPropertyName = "Description"
        Me.dgDescription.DefaultCellStyle = dataGridViewCellStyle3
        Me.dgDescription.HeaderText = "Description"
        Me.dgDescription.MinimumWidth = 100
        Me.dgDescription.Name = "dgDescription"
        Me.dgDescription.ReadOnly = True
        Me.dgDescription.Resizable = System.Windows.Forms.DataGridViewTriState.True
        Me.dgDescription.Width = 270
        Me.dgDetails.DataPropertyName = "Details"
        Me.dgDetails.DefaultCellStyle = dataGridViewCellStyle4
        Me.dgDetails.HeaderText = "Details"
        Me.dgDetails.MinimumWidth = 6
        Me.dgDetails.Name = "dgDetails"
        Me.dgDetails.ReadOnly = True
        Me.dgDetails.Resizable = System.Windows.Forms.DataGridViewTriState.True
        Me.dgDetails.Visible = False
        Me.dgDetails.Width = 100
        Me.dgDepartment.DataPropertyName = "Department"
        Me.dgDepartment.DefaultCellStyle = dataGridViewCellStyle5
        Me.dgDepartment.HeaderText = "Department"
        Me.dgDepartment.MinimumWidth = 6
        Me.dgDepartment.Name = "dgDepartment"
        Me.dgDepartment.ReadOnly = True
        Me.dgDepartment.Resizable = System.Windows.Forms.DataGridViewTriState.True
        Me.dgDepartment.Visible = False
        Me.dgDepartment.Width = 100
        Me.dgCategory.DataPropertyName = "Category"
        Me.dgCategory.DefaultCellStyle = dataGridViewCellStyle6
        Me.dgCategory.HeaderText = "Category"
        Me.dgCategory.MinimumWidth = 6
        Me.dgCategory.Name = "dgCategory"
        Me.dgCategory.ReadOnly = True
        Me.dgCategory.Resizable = System.Windows.Forms.DataGridViewTriState.True
        Me.dgCategory.Visible = False
        Me.dgCategory.Width = 100
        Me.kryptonReadingGroupOuter.Dock = System.Windows.Forms.DockStyle.Fill
        Me.kryptonReadingGroupOuter.GroupBackStyle = Krypton.Toolkit.PaletteBackStyle.PanelAlternate
        Me.kryptonReadingGroupOuter.Location = New System.Drawing.Point(0, 0)
        Me.kryptonReadingGroupOuter.Name = "kryptonReadingGroupOuter"
        Me.kryptonReadingGroupOuter.Panel.Controls.Add(Me.kryptonReadingLabel)
        Me.kryptonReadingGroupOuter.Panel.Padding = New System.Windows.Forms.Padding(5)
        Me.kryptonReadingGroupOuter.Size = New System.Drawing.Size(445, 130)
        Me.kryptonReadingGroupOuter.TabIndex = 0
        Me.kryptonReadingLabel.Dock = System.Windows.Forms.DockStyle.Fill
        Me.kryptonReadingLabel.LabelStyle = Krypton.Toolkit.LabelStyle.TitlePanel
        Me.kryptonReadingLabel.Location = New System.Drawing.Point(5, 5)
        Me.kryptonReadingLabel.Name = "kryptonReadingLabel"
        Me.kryptonReadingLabel.Size = New System.Drawing.Size(433, 118)
        Me.kryptonReadingLabel.StateCommon.ShortText.MultiLine = Krypton.Toolkit.InheritBool.True
        Me.kryptonReadingLabel.StateCommon.ShortText.MultiLineH = Krypton.Toolkit.PaletteRelativeAlign.Near
        Me.kryptonReadingLabel.StateCommon.ShortText.TextH = Krypton.Toolkit.PaletteRelativeAlign.Near
        Me.kryptonReadingLabel.StateCommon.ShortText.TextV = Krypton.Toolkit.PaletteRelativeAlign.Near
        Me.kryptonReadingLabel.TabIndex = 0
        Me.kryptonReadingLabel.Values.Text = ""
        Me.toolStrip2010.Dock = System.Windows.Forms.DockStyle.None
        Me.toolStrip2010.Font = New System.Drawing.Font("Segoe UI", 9F)
        Me.toolStrip2010.ImageScalingSize = New System.Drawing.Size(20, 20)
        Me.toolStrip2010.Items.AddRange(New System.Windows.Forms.ToolStripItem() { Me.toolStripOffice2010Blue, Me.toolStripOffice2010Silver, Me.toolStripOffice2010Black})
        Me.toolStrip2010.Location = New System.Drawing.Point(264, 27)
        Me.toolStrip2010.Name = "toolStrip2010"
        Me.toolStrip2010.Size = New System.Drawing.Size(260, 27)
        Me.toolStrip2010.TabIndex = 4
        Me.toolStripOffice2010Blue.Checked = True
        Me.toolStripOffice2010Blue.CheckState = System.Windows.Forms.CheckState.Checked
        Me.toolStripOffice2010Blue.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Text
        Me.toolStripOffice2010Blue.Image = CType(resources.GetObject("toolStripOffice2010Blue.Image"), System.Drawing.Image)
        Me.toolStripOffice2010Blue.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.toolStripOffice2010Blue.Name = "toolStripOffice2010Blue"
        Me.toolStripOffice2010Blue.Size = New System.Drawing.Size(78, 24)
        Me.toolStripOffice2010Blue.Text = "2010 Blue"
        Me.toolStripOffice2010Blue.ToolTipText = "Use the built in preofessional office palette"
        Me.toolStripOffice2010Silver.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Text
        Me.toolStripOffice2010Silver.Image = CType(resources.GetObject("toolStripOffice2010Silver.Image"), System.Drawing.Image)
        Me.toolStripOffice2010Silver.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.toolStripOffice2010Silver.Name = "toolStripOffice2010Silver"
        Me.toolStripOffice2010Silver.Size = New System.Drawing.Size(85, 24)
        Me.toolStripOffice2010Silver.Text = "2010 Silver"
        Me.toolStripOffice2010Silver.ToolTipText = "Use the built in preofessional office palette"
        Me.toolStripOffice2010Black.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Text
        Me.toolStripOffice2010Black.Image = CType(resources.GetObject("toolStripOffice2010Black.Image"), System.Drawing.Image)
        Me.toolStripOffice2010Black.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.toolStripOffice2010Black.Name = "toolStripOffice2010Black"
        Me.toolStripOffice2010Black.Size = New System.Drawing.Size(84, 24)
        Me.toolStripOffice2010Black.Text = "2010 Black"
        Me.toolStripOffice2010Black.ToolTipText = "Use the built in preofessional office palette"
        Me.toolStrip2007.Dock = System.Windows.Forms.DockStyle.None
        Me.toolStrip2007.Font = New System.Drawing.Font("Segoe UI", 9F)
        Me.toolStrip2007.ImageScalingSize = New System.Drawing.Size(20, 20)
        Me.toolStrip2007.Items.AddRange(New System.Windows.Forms.ToolStripItem() { Me.toolStripOffice2007Blue, Me.toolStripOffice2007Silver, Me.toolStripOffice2007Black})
        Me.toolStrip2007.Location = New System.Drawing.Point(4, 27)
        Me.toolStrip2007.Name = "toolStrip2007"
        Me.toolStrip2007.Size = New System.Drawing.Size(260, 27)
        Me.toolStrip2007.TabIndex = 2
        Me.toolStripOffice2007Blue.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Text
        Me.toolStripOffice2007Blue.Image = CType(resources.GetObject("toolStripOffice2007Blue.Image"), System.Drawing.Image)
        Me.toolStripOffice2007Blue.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.toolStripOffice2007Blue.Name = "toolStripOffice2007Blue"
        Me.toolStripOffice2007Blue.Size = New System.Drawing.Size(78, 24)
        Me.toolStripOffice2007Blue.Text = "2007 Blue"
        Me.toolStripOffice2007Blue.ToolTipText = "Use the built in preofessional office palette"
        Me.toolStripOffice2007Silver.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Text
        Me.toolStripOffice2007Silver.Image = CType(resources.GetObject("toolStripOffice2007Silver.Image"), System.Drawing.Image)
        Me.toolStripOffice2007Silver.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.toolStripOffice2007Silver.Name = "toolStripOffice2007Silver"
        Me.toolStripOffice2007Silver.Size = New System.Drawing.Size(85, 24)
        Me.toolStripOffice2007Silver.Text = "2007 Silver"
        Me.toolStripOffice2007Silver.ToolTipText = "Use the built in preofessional office palette"
        Me.toolStripOffice2007Black.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Text
        Me.toolStripOffice2007Black.Image = CType(resources.GetObject("toolStripOffice2007Black.Image"), System.Drawing.Image)
        Me.toolStripOffice2007Black.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.toolStripOffice2007Black.Name = "toolStripOffice2007Black"
        Me.toolStripOffice2007Black.Size = New System.Drawing.Size(84, 24)
        Me.toolStripOffice2007Black.Text = "2007 Black"
        Me.toolStripOffice2007Black.ToolTipText = "Use the built in preofessional office palette"
        Me.toolStripOther.Dock = System.Windows.Forms.DockStyle.None
        Me.toolStripOther.Font = New System.Drawing.Font("Segoe UI", 9F)
        Me.toolStripOther.ImageScalingSize = New System.Drawing.Size(20, 20)
        Me.toolStripOther.Items.AddRange(New System.Windows.Forms.ToolStripItem() { Me.toolStripSystem, Me.toolStripCustom})
        Me.toolStripOther.Location = New System.Drawing.Point(14, 109)
        Me.toolStripOther.Name = "toolStripOther"
        Me.toolStripOther.Size = New System.Drawing.Size(136, 27)
        Me.toolStripOther.TabIndex = 3
        Me.toolStripSystem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Text
        Me.toolStripSystem.Image = CType(resources.GetObject("toolStripSystem.Image"), System.Drawing.Image)
        Me.toolStripSystem.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.toolStripSystem.Name = "toolStripSystem"
        Me.toolStripSystem.Size = New System.Drawing.Size(60, 24)
        Me.toolStripSystem.Text = "System"
        Me.toolStripSystem.ToolTipText = "Use the built in professional system palette"
        Me.toolStripCustom.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Text
        Me.toolStripCustom.Image = CType(resources.GetObject("toolStripCustom.Image"), System.Drawing.Image)
        Me.toolStripCustom.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.toolStripCustom.Name = "toolStripCustom"
        Me.toolStripCustom.Size = New System.Drawing.Size(63, 24)
        Me.toolStripCustom.Text = "Custom"
        Me.toolStripCustom.ToolTipText = "Use a custom palette"
        Me.toolStripSparkle.Dock = System.Windows.Forms.DockStyle.None
        Me.toolStripSparkle.Font = New System.Drawing.Font("Segoe UI", 9F)
        Me.toolStripSparkle.ImageScalingSize = New System.Drawing.Size(20, 20)
        Me.toolStripSparkle.Items.AddRange(New System.Windows.Forms.ToolStripItem() { Me.toolStripSparkleBlue, Me.toolStripSparkleOrange, Me.toolStripSparklePurple})
        Me.toolStripSparkle.Location = New System.Drawing.Point(4, 54)
        Me.toolStripSparkle.Name = "toolStripSparkle"
        Me.toolStripSparkle.Size = New System.Drawing.Size(331, 27)
        Me.toolStripSparkle.TabIndex = 5
        Me.toolStripSparkleBlue.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Text
        Me.toolStripSparkleBlue.Image = CType(resources.GetObject("toolStripSparkleBlue.Image"), System.Drawing.Image)
        Me.toolStripSparkleBlue.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.toolStripSparkleBlue.Name = "toolStripSparkleBlue"
        Me.toolStripSparkleBlue.Size = New System.Drawing.Size(95, 24)
        Me.toolStripSparkleBlue.Text = "Sparkle Blue"
        Me.toolStripSparkleOrange.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Text
        Me.toolStripSparkleOrange.Image = CType(resources.GetObject("toolStripSparkleOrange.Image"), System.Drawing.Image)
        Me.toolStripSparkleOrange.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.toolStripSparkleOrange.Name = "toolStripSparkleOrange"
        Me.toolStripSparkleOrange.Size = New System.Drawing.Size(115, 24)
        Me.toolStripSparkleOrange.Text = "Sparkle Orange"
        Me.toolStripSparklePurple.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Text
        Me.toolStripSparklePurple.Image = CType(resources.GetObject("toolStripSparklePurple.Image"), System.Drawing.Image)
        Me.toolStripSparklePurple.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.toolStripSparklePurple.Name = "toolStripSparklePurple"
        Me.toolStripSparklePurple.Size = New System.Drawing.Size(108, 24)
        Me.toolStripSparklePurple.Text = "Sparkle Purple"
        Me.dataSet.DataSetName = "NewDataSet"
        Me.dataSet.Tables.AddRange(New System.Data.DataTable() { Me.dataTable})
        Me.dataTable.Columns.AddRange(New System.Data.DataColumn() { Me.colName, Me.colDescription, Me.colDetails, Me.colDepartment, Me.colCategory, Me.dataColumn1})
        Me.dataTable.TableName = "TestTable"
        Me.colName.Caption = "Name"
        Me.colName.ColumnName = "Name"
        Me.colDescription.Caption = "Description"
        Me.colDescription.ColumnName = "Description"
        Me.colDescription.DefaultValue = ""
        Me.colDetails.ColumnName = "Details"
        Me.colDepartment.ColumnName = "Department"
        Me.colCategory.ColumnName = "Category"
        Me.dataColumn1.AllowDBNull = False
        Me.dataColumn1.ColumnName = "Valid"
        Me.dataColumn1.DataType = GetType(Boolean)
        Me.dataColumn1.DefaultValue = True
        Me.kryptonManager.GlobalPaletteMode = Krypton.Toolkit.PaletteMode.Office2007Blue
        Me.kryptonPaletteCustom.BasePaletteType = Krypton.Toolkit.BasePaletteType.Office2007
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
        Me.kryptonPaletteCustom.ControlStyles.ControlToolTip.StateCommon.Back.Color1 = System.Drawing.Color.FromArgb(CType(CType(102, Byte), Integer), CType(CType(153, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.kryptonPaletteCustom.ControlStyles.ControlToolTip.StateCommon.Back.ColorStyle = Krypton.Toolkit.PaletteColorStyle.Solid
        Me.kryptonPaletteCustom.ControlStyles.ControlToolTip.StateCommon.Border.Color1 = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(51, Byte), Integer), CType(CType(102, Byte), Integer))
        Me.kryptonPaletteCustom.ControlStyles.ControlToolTip.StateCommon.Border.ColorStyle = Krypton.Toolkit.PaletteColorStyle.Solid
        Me.kryptonPaletteCustom.ControlStyles.ControlToolTip.StateCommon.Border.DrawBorders = CType((((Krypton.Toolkit.PaletteDrawBorders.Top Or Krypton.Toolkit.PaletteDrawBorders.Bottom) Or Krypton.Toolkit.PaletteDrawBorders.Left) Or Krypton.Toolkit.PaletteDrawBorders.Right), Krypton.Toolkit.PaletteDrawBorders)
        Me.kryptonPaletteCustom.GridStyles.GridCommon.StateCommon.BackStyle = Krypton.Toolkit.PaletteBackStyle.GridBackgroundList
        Me.kryptonPaletteCustom.GridStyles.GridCommon.StateCommon.DataCell.Border.Color1 = System.Drawing.Color.Red
        Me.kryptonPaletteCustom.GridStyles.GridCommon.StateCommon.DataCell.Border.ColorStyle = Krypton.Toolkit.PaletteColorStyle.Solid
        Me.kryptonPaletteCustom.GridStyles.GridCommon.StateCommon.DataCell.Border.DrawBorders = Krypton.Toolkit.PaletteDrawBorders.None
        Me.kryptonPaletteCustom.GridStyles.GridCommon.StateCommon.DataCell.Border.Rounding = 0F
        Me.kryptonPaletteCustom.GridStyles.GridCommon.StateCommon.DataCell.Border.Width = 0
        Me.kryptonPaletteCustom.GridStyles.GridCommon.StateCommon.HeaderColumn.Back.Color1 = System.Drawing.Color.FromArgb(CType(CType(226, Byte), Integer), CType(CType(213, Byte), Integer), CType(CType(194, Byte), Integer))
        Me.kryptonPaletteCustom.GridStyles.GridCommon.StateCommon.HeaderColumn.Back.Color2 = System.Drawing.Color.White
        Me.kryptonPaletteCustom.GridStyles.GridCommon.StateCommon.HeaderColumn.Back.ColorStyle = Krypton.Toolkit.PaletteColorStyle.Linear
        Me.kryptonPaletteCustom.GridStyles.GridCommon.StateCommon.HeaderColumn.Border.Color1 = System.Drawing.Color.Red
        Me.kryptonPaletteCustom.GridStyles.GridCommon.StateCommon.HeaderColumn.Border.DrawBorders = CType((((Krypton.Toolkit.PaletteDrawBorders.Top Or Krypton.Toolkit.PaletteDrawBorders.Bottom) Or Krypton.Toolkit.PaletteDrawBorders.Left) Or Krypton.Toolkit.PaletteDrawBorders.Right), Krypton.Toolkit.PaletteDrawBorders)
        Me.kryptonPaletteCustom.GridStyles.GridCommon.StateCommon.HeaderColumn.Border.Rounding = 0F
        Me.kryptonPaletteCustom.GridStyles.GridCommon.StateCommon.HeaderColumn.Border.Width = 0
        Me.kryptonPaletteCustom.GridStyles.GridCommon.StateSelected.DataCell.Back.Color1 = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(102, Byte), Integer), CType(CType(0, Byte), Integer))
        Me.kryptonPaletteCustom.GridStyles.GridCommon.StateSelected.DataCell.Back.ColorStyle = Krypton.Toolkit.PaletteColorStyle.Solid
        Me.kryptonPaletteCustom.GridStyles.GridCommon.StateSelected.DataCell.Content.Color1 = System.Drawing.Color.White
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
        Me.kryptonPaletteCustom.HeaderStyles.HeaderCommon.StateCommon.Content.Padding = New System.Windows.Forms.Padding(10, 1, 10, 1)
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
        Me.kryptonPaletteCustom.LabelStyles.LabelToolTip.StateCommon.LongText.Color1 = System.Drawing.Color.White
        Me.kryptonPaletteCustom.LabelStyles.LabelToolTip.StateCommon.ShortText.Color1 = System.Drawing.Color.White
        Me.kryptonPaletteCustom.PanelStyles.PanelAlternate.StateCommon.Color1 = System.Drawing.Color.FromArgb(CType(CType(225, Byte), Integer), CType(CType(212, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.kryptonPaletteCustom.PanelStyles.PanelClient.StateCommon.Color1 = System.Drawing.Color.FromArgb(CType(CType(245, Byte), Integer), CType(CType(237, Byte), Integer), CType(CType(227, Byte), Integer))
        Me.kryptonPaletteCustom.PanelStyles.PanelCommon.StateCommon.ColorStyle = Krypton.Toolkit.PaletteColorStyle.Solid
        Me.kryptonPaletteCustom.ThemeName = Nothing
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
        Me.statusStrip.Font = New System.Drawing.Font("Segoe UI", 9F)
        Me.statusStrip.ImageScalingSize = New System.Drawing.Size(20, 20)
        Me.statusStrip.Location = New System.Drawing.Point(0, 457)
        Me.statusStrip.Name = "statusStrip"
        Me.statusStrip.RenderMode = System.Windows.Forms.ToolStripRenderMode.ManagerRenderMode
        Me.statusStrip.Size = New System.Drawing.Size(634, 22)
        Me.statusStrip.TabIndex = 2
        Me.statusStrip.Text = "statusStrip1"
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8F, 17F)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(634, 479)
        Me.Controls.Add(Me.toolStripContainer1)
        Me.Controls.Add(Me.statusStrip)
        Me.Font = New System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.MainMenuStrip = Me.menuStrip
        Me.MinimumSize = New System.Drawing.Size(320, 286)
        Me.Name = "Form1"
        Me.Text = "Three Pane Application (Extended)"
        Me.menuStrip.ResumeLayout(False)
        Me.menuStrip.PerformLayout()
        Me.toolStripGeneral.ResumeLayout(False)
        Me.toolStripGeneral.PerformLayout()
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
        Me.kryptonHeaderGroupNavigation.Panel.ResumeLayout(False)
        CType(Me.kryptonHeaderGroupNavigation, System.ComponentModel.ISupportInitialize).EndInit()
        Me.kryptonHeaderGroupNavigation.ResumeLayout(False)
        CType(Me.kryptonSplitContainerDetails.Panel1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.kryptonSplitContainerDetails.Panel1.ResumeLayout(False)
        CType(Me.kryptonSplitContainerDetails.Panel2, System.ComponentModel.ISupportInitialize).EndInit()
        Me.kryptonSplitContainerDetails.Panel2.ResumeLayout(False)
        CType(Me.kryptonSplitContainerDetails, System.ComponentModel.ISupportInitialize).EndInit()
        Me.kryptonSplitContainerDetails.ResumeLayout(False)
        CType(Me.kryptonHeaderGroupDetails.Panel, System.ComponentModel.ISupportInitialize).EndInit()
        Me.kryptonHeaderGroupDetails.Panel.ResumeLayout(False)
        CType(Me.kryptonHeaderGroupDetails, System.ComponentModel.ISupportInitialize).EndInit()
        Me.kryptonHeaderGroupDetails.ResumeLayout(False)
        CType(Me.kryptonDataGridView, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.kryptonReadingGroupOuter.Panel, System.ComponentModel.ISupportInitialize).EndInit()
        Me.kryptonReadingGroupOuter.Panel.ResumeLayout(False)
        Me.kryptonReadingGroupOuter.Panel.PerformLayout()
        CType(Me.kryptonReadingGroupOuter, System.ComponentModel.ISupportInitialize).EndInit()
        Me.kryptonReadingGroupOuter.ResumeLayout(False)
        Me.toolStrip2010.ResumeLayout(False)
        Me.toolStrip2010.PerformLayout()
        Me.toolStrip2007.ResumeLayout(False)
        Me.toolStrip2007.PerformLayout()
        Me.toolStripOther.ResumeLayout(False)
        Me.toolStripOther.PerformLayout()
        Me.toolStripSparkle.ResumeLayout(False)
        Me.toolStripSparkle.PerformLayout()
        CType(Me.dataSet, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.dataTable, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()
    End Sub

    Friend WithEvents menuStrip As System.Windows.Forms.MenuStrip
    Friend WithEvents fileToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents systemToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents customToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents toolStripSeparator2 As System.Windows.Forms.ToolStripSeparator
    Friend WithEvents exitToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents toolsToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents readingPaneToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents panePositonToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents toolStripGeneral As System.Windows.Forms.ToolStrip
    Friend WithEvents toolStripContainer1 As System.Windows.Forms.ToolStripContainer
    Friend WithEvents kryptonPanelMain As Krypton.Toolkit.KryptonPanel
    Friend WithEvents kryptonSplitContainerMain As Krypton.Toolkit.KryptonSplitContainer
    Friend WithEvents kryptonHeaderGroupNavigation As Krypton.Toolkit.KryptonHeaderGroup
    Friend WithEvents kryptonSplitContainerDetails As Krypton.Toolkit.KryptonSplitContainer
    Friend WithEvents kryptonHeaderGroupDetails As Krypton.Toolkit.KryptonHeaderGroup
    Friend WithEvents kryptonReadingGroupOuter As Krypton.Toolkit.KryptonGroup
    Friend WithEvents kryptonManager As Krypton.Toolkit.KryptonManager
    Friend WithEvents kryptonPaletteCustom As Krypton.Toolkit.KryptonCustomPaletteBase
    Friend WithEvents imageList As System.Windows.Forms.ImageList
    Friend WithEvents kryptonReadingLabel As Krypton.Toolkit.KryptonLabel
    Friend WithEvents loadPaletteToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents toolStripMenuItem1 As System.Windows.Forms.ToolStripSeparator
    Friend WithEvents treeView As System.Windows.Forms.TreeView
    Friend WithEvents toolStripLoadPalette As System.Windows.Forms.ToolStripButton
    Friend WithEvents toolStripSeparator1 As System.Windows.Forms.ToolStripSeparator
    Friend WithEvents buttonSpecPrevious As Krypton.Toolkit.ButtonSpecHeaderGroup
    Friend WithEvents buttonSpecNext As Krypton.Toolkit.ButtonSpecHeaderGroup
    Friend WithEvents office2007BlueToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents office2007SilverToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents office2007BlackToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents statusStrip As System.Windows.Forms.StatusStrip
    Friend WithEvents kryptonDataGridView As Krypton.Toolkit.KryptonDataGridView
    Friend WithEvents dataSet As System.Data.DataSet
    Friend WithEvents dataTable As System.Data.DataTable
    Friend WithEvents colName As System.Data.DataColumn
    Friend WithEvents colDescription As System.Data.DataColumn
    Friend WithEvents colDetails As System.Data.DataColumn
    Friend WithEvents colDepartment As System.Data.DataColumn
    Friend WithEvents colCategory As System.Data.DataColumn
    Friend WithEvents dataColumn1 As System.Data.DataColumn
    Friend WithEvents dgValid As Krypton.Toolkit.KryptonDataGridViewCheckBoxColumn
    Friend WithEvents dgName As Krypton.Toolkit.KryptonDataGridViewTextBoxColumn
    Friend WithEvents dgDescription As Krypton.Toolkit.KryptonDataGridViewTextBoxColumn
    Friend WithEvents dgDetails As Krypton.Toolkit.KryptonDataGridViewTextBoxColumn
    Friend WithEvents dgDepartment As Krypton.Toolkit.KryptonDataGridViewTextBoxColumn
    Friend WithEvents dgCategory As Krypton.Toolkit.KryptonDataGridViewTextBoxColumn
    Friend WithEvents sparklePurpleToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents toolStrip2007 As System.Windows.Forms.ToolStrip
    Friend WithEvents office2010BlueToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents office2010SilverToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents office2010BlackToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents toolStripSeparator3 As System.Windows.Forms.ToolStripSeparator
    Friend WithEvents toolStripSeparator4 As System.Windows.Forms.ToolStripSeparator
    Friend WithEvents sparkleBlueToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents sparkleOrangeToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents toolStripSeparator5 As System.Windows.Forms.ToolStripSeparator
    Friend WithEvents toolStripReadingPane As System.Windows.Forms.ToolStripButton
    Friend WithEvents toolStripPosition As System.Windows.Forms.ToolStripButton
    Friend WithEvents toolStripOffice2007Blue As System.Windows.Forms.ToolStripButton
    Friend WithEvents toolStripOffice2007Silver As System.Windows.Forms.ToolStripButton
    Friend WithEvents toolStripOffice2007Black As System.Windows.Forms.ToolStripButton
    Friend WithEvents toolStripOther As System.Windows.Forms.ToolStrip
    Friend WithEvents toolStripSystem As System.Windows.Forms.ToolStripButton
    Friend WithEvents toolStripCustom As System.Windows.Forms.ToolStripButton
    Friend WithEvents toolStrip2010 As System.Windows.Forms.ToolStrip
    Friend WithEvents toolStripOffice2010Blue As System.Windows.Forms.ToolStripButton
    Friend WithEvents toolStripOffice2010Silver As System.Windows.Forms.ToolStripButton
    Friend WithEvents toolStripOffice2010Black As System.Windows.Forms.ToolStripButton
    Friend WithEvents toolStripSparkle As System.Windows.Forms.ToolStrip
    Friend WithEvents toolStripSparkleBlue As System.Windows.Forms.ToolStripButton
    Friend WithEvents toolStripSparkleOrange As System.Windows.Forms.ToolStripButton
    Friend WithEvents toolStripSparklePurple As System.Windows.Forms.ToolStripButton
End Class
