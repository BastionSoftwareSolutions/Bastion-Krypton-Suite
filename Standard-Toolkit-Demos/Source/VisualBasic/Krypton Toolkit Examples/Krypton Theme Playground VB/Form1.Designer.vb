' VB.NET twin of Source\Krypton Toolkit Examples\Krypton Theme Playground\Form1.Designer.cs (Bastion Phase 4c).
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
        Dim treeNode1 As System.Windows.Forms.TreeNode = New System.Windows.Forms.TreeNode("Node4")
        Dim treeNode2 As System.Windows.Forms.TreeNode = New System.Windows.Forms.TreeNode("Node5")
        Dim treeNode3 As System.Windows.Forms.TreeNode = New System.Windows.Forms.TreeNode("Node0", New System.Windows.Forms.TreeNode() { treeNode1, treeNode2})
        Dim treeNode4 As System.Windows.Forms.TreeNode = New System.Windows.Forms.TreeNode("Node6")
        Dim treeNode5 As System.Windows.Forms.TreeNode = New System.Windows.Forms.TreeNode("Node7")
        Dim treeNode6 As System.Windows.Forms.TreeNode = New System.Windows.Forms.TreeNode("Node8")
        Dim treeNode7 As System.Windows.Forms.TreeNode = New System.Windows.Forms.TreeNode("Node1", New System.Windows.Forms.TreeNode() { treeNode4, treeNode5, treeNode6})
        Dim treeNode8 As System.Windows.Forms.TreeNode = New System.Windows.Forms.TreeNode("Node9")
        Dim treeNode9 As System.Windows.Forms.TreeNode = New System.Windows.Forms.TreeNode("Node2", New System.Windows.Forms.TreeNode() { treeNode8})
        Dim treeNode10 As System.Windows.Forms.TreeNode = New System.Windows.Forms.TreeNode("Node10")
        Dim treeNode11 As System.Windows.Forms.TreeNode = New System.Windows.Forms.TreeNode("Node11")
        Dim treeNode12 As System.Windows.Forms.TreeNode = New System.Windows.Forms.TreeNode("Node12")
        Dim treeNode13 As System.Windows.Forms.TreeNode = New System.Windows.Forms.TreeNode("Node13")
        Dim treeNode14 As System.Windows.Forms.TreeNode = New System.Windows.Forms.TreeNode("Node3", New System.Windows.Forms.TreeNode() { treeNode10, treeNode11, treeNode12, treeNode13})
        Dim listViewItem1 As System.Windows.Forms.ListViewItem = New System.Windows.Forms.ListViewItem(New String() { "1"}, -1, System.Drawing.SystemColors.ControlText, System.Drawing.SystemColors.Window, New System.Drawing.Font("Segoe UI", 9F))
        Dim listViewItem2 As System.Windows.Forms.ListViewItem = New System.Windows.Forms.ListViewItem(New String() { "2"}, -1, System.Drawing.SystemColors.ControlText, System.Drawing.SystemColors.Window, New System.Drawing.Font("Segoe UI", 9F))
        Dim listViewItem3 As System.Windows.Forms.ListViewItem = New System.Windows.Forms.ListViewItem(New String() { "3"}, -1, System.Drawing.SystemColors.ControlText, System.Drawing.SystemColors.Window, New System.Drawing.Font("Segoe UI", 9F))
        Dim listViewItem4 As System.Windows.Forms.ListViewItem = New System.Windows.Forms.ListViewItem(New String() { "4"}, -1, System.Drawing.SystemColors.ControlText, System.Drawing.SystemColors.Window, New System.Drawing.Font("Segoe UI", 9F))
        Dim listViewItem5 As System.Windows.Forms.ListViewItem = New System.Windows.Forms.ListViewItem(New String() { "5"}, -1, System.Drawing.SystemColors.ControlText, System.Drawing.SystemColors.Window, New System.Drawing.Font("Segoe UI", 9F))
        Dim listViewItem6 As System.Windows.Forms.ListViewItem = New System.Windows.Forms.ListViewItem(New String() { "6"}, -1, System.Drawing.SystemColors.ControlText, System.Drawing.SystemColors.Window, New System.Drawing.Font("Segoe UI", 9F))
        Dim listViewItem7 As System.Windows.Forms.ListViewItem = New System.Windows.Forms.ListViewItem(New String() { "7"}, -1, System.Drawing.SystemColors.ControlText, System.Drawing.SystemColors.Window, New System.Drawing.Font("Segoe UI", 9F))
        Dim listViewItem8 As System.Windows.Forms.ListViewItem = New System.Windows.Forms.ListViewItem(New String() { "8"}, -1, System.Drawing.SystemColors.ControlText, System.Drawing.SystemColors.Window, New System.Drawing.Font("Segoe UI", 9F))
        Dim listViewItem9 As System.Windows.Forms.ListViewItem = New System.Windows.Forms.ListViewItem(New String() { "9"}, -1, System.Drawing.SystemColors.ControlText, System.Drawing.SystemColors.Window, New System.Drawing.Font("Segoe UI", 9F))
        Dim listViewItem10 As System.Windows.Forms.ListViewItem = New System.Windows.Forms.ListViewItem(New String() { "10"}, -1, System.Drawing.SystemColors.ControlText, System.Drawing.SystemColors.Window, New System.Drawing.Font("Segoe UI", 9F))
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(Form1))
        Me.kryptonTreeView1 = New Krypton.Toolkit.KryptonTreeView()
        Me.kryptonTextBox1 = New Krypton.Toolkit.KryptonTextBox()
        Me.kryptonRichTextBox1 = New Krypton.Toolkit.KryptonRichTextBox()
        Me.kryptonNumericUpDown1 = New Krypton.Toolkit.KryptonNumericUpDown()
        Me.kryptonMaskedTextBox1 = New Krypton.Toolkit.KryptonMaskedTextBox()
        Me.kryptonListView1 = New Krypton.Toolkit.KryptonListView()
        Me.kryptonListBox1 = New Krypton.Toolkit.KryptonListBox()
        Me.kryptonDomainUpDown1 = New Krypton.Toolkit.KryptonDomainUpDown()
        Me.kryptonDateTimePicker1 = New Krypton.Toolkit.KryptonDateTimePicker()
        Me.kryptonComboBox1 = New Krypton.Toolkit.KryptonComboBox()
        Me.kryptonCheckedListBox1 = New Krypton.Toolkit.KryptonCheckedListBox()
        Me.kryptonButton1 = New Krypton.Toolkit.KryptonButton()
        Me.kryptonThemeComboBox1 = New Krypton.Toolkit.KryptonThemeComboBox()
        Me.toolStrip1 = New System.Windows.Forms.ToolStrip()
        Me.newToolStripButton = New System.Windows.Forms.ToolStripButton()
        Me.openToolStripButton = New System.Windows.Forms.ToolStripButton()
        Me.saveToolStripButton = New System.Windows.Forms.ToolStripButton()
        Me.printToolStripButton = New System.Windows.Forms.ToolStripButton()
        Me.toolStripSeparator = New System.Windows.Forms.ToolStripSeparator()
        Me.cutToolStripButton = New System.Windows.Forms.ToolStripButton()
        Me.copyToolStripButton = New System.Windows.Forms.ToolStripButton()
        Me.pasteToolStripButton = New System.Windows.Forms.ToolStripButton()
        Me.toolStripSeparator1 = New System.Windows.Forms.ToolStripSeparator()
        Me.helpToolStripButton = New System.Windows.Forms.ToolStripButton()
        Me.toolStripButton1 = New System.Windows.Forms.ToolStripButton()
        Me.kpg = New Krypton.Toolkit.KryptonPropertyGrid()
        Me.kryptonColorButton1 = New Krypton.Toolkit.KryptonColorButton()
        Me.kryptonPanel1 = New Krypton.Toolkit.KryptonPanel()
        CType(Me.kryptonComboBox1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.kryptonThemeComboBox1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.toolStrip1.SuspendLayout()
        CType(Me.kryptonPanel1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.kryptonPanel1.SuspendLayout()
        Me.SuspendLayout()
        '
        'kryptonTreeView1
        '
        Me.kryptonTreeView1.Location = New System.Drawing.Point(277, 356)
        Me.kryptonTreeView1.Margin = New System.Windows.Forms.Padding(4)
        Me.kryptonTreeView1.Name = "kryptonTreeView1"
        treeNode1.Name = "Node4"
        treeNode1.Text = "Node4"
        treeNode2.Name = "Node5"
        treeNode2.Text = "Node5"
        treeNode3.Name = "Node0"
        treeNode3.Text = "Node0"
        treeNode4.Name = "Node6"
        treeNode4.Text = "Node6"
        treeNode5.Name = "Node7"
        treeNode5.Text = "Node7"
        treeNode6.Name = "Node8"
        treeNode6.Text = "Node8"
        treeNode7.Name = "Node1"
        treeNode7.Text = "Node1"
        treeNode8.Name = "Node9"
        treeNode8.Text = "Node9"
        treeNode9.Name = "Node2"
        treeNode9.Text = "Node2"
        treeNode10.Name = "Node10"
        treeNode10.Text = "Node10"
        treeNode11.Name = "Node11"
        treeNode11.Text = "Node11"
        treeNode12.Name = "Node12"
        treeNode12.Text = "Node12"
        treeNode13.Name = "Node13"
        treeNode13.Text = "Node13"
        treeNode14.Name = "Node3"
        treeNode14.Text = "Node3"
        Me.kryptonTreeView1.Nodes.AddRange(New System.Windows.Forms.TreeNode() { treeNode3, treeNode7, treeNode9, treeNode14})
        Me.kryptonTreeView1.Size = New System.Drawing.Size(160, 175)
        Me.kryptonTreeView1.TabIndex = 22
        '
        'kryptonTextBox1
        '
        Me.kryptonTextBox1.Location = New System.Drawing.Point(277, 319)
        Me.kryptonTextBox1.Margin = New System.Windows.Forms.Padding(4)
        Me.kryptonTextBox1.Name = "kryptonTextBox1"
        Me.kryptonTextBox1.Size = New System.Drawing.Size(161, 27)
        Me.kryptonTextBox1.TabIndex = 21
        Me.kryptonTextBox1.Text = "kryptonTextBox1"
        '
        'kryptonRichTextBox1
        '
        Me.kryptonRichTextBox1.Location = New System.Drawing.Point(277, 192)
        Me.kryptonRichTextBox1.Margin = New System.Windows.Forms.Padding(4)
        Me.kryptonRichTextBox1.Name = "kryptonRichTextBox1"
        Me.kryptonRichTextBox1.Size = New System.Drawing.Size(161, 118)
        Me.kryptonRichTextBox1.TabIndex = 20
        Me.kryptonRichTextBox1.Text = "kryptonRichTextBox1"
        '
        'kryptonNumericUpDown1
        '
        Me.kryptonNumericUpDown1.Increment = New decimal(New Integer() { 1, 0, 0, 0})
        Me.kryptonNumericUpDown1.Location = New System.Drawing.Point(277, 156)
        Me.kryptonNumericUpDown1.Margin = New System.Windows.Forms.Padding(4)
        Me.kryptonNumericUpDown1.Maximum = New decimal(New Integer() { 100, 0, 0, 0})
        Me.kryptonNumericUpDown1.Minimum = New decimal(New Integer() { 0, 0, 0, 0})
        Me.kryptonNumericUpDown1.Name = "kryptonNumericUpDown1"
        Me.kryptonNumericUpDown1.Size = New System.Drawing.Size(160, 26)
        Me.kryptonNumericUpDown1.TabIndex = 19
        Me.kryptonNumericUpDown1.Value = New decimal(New Integer() { 0, 0, 0, 0})
        '
        'kryptonMaskedTextBox1
        '
        Me.kryptonMaskedTextBox1.Location = New System.Drawing.Point(277, 119)
        Me.kryptonMaskedTextBox1.Margin = New System.Windows.Forms.Padding(4)
        Me.kryptonMaskedTextBox1.Name = "kryptonMaskedTextBox1"
        Me.kryptonMaskedTextBox1.Size = New System.Drawing.Size(160, 27)
        Me.kryptonMaskedTextBox1.TabIndex = 18
        Me.kryptonMaskedTextBox1.Text = "kryptonMaskedTextBox1"
        '
        'kryptonListView1
        '
        Me.kryptonListView1.HideSelection = False
        Me.kryptonListView1.Items.AddRange(New System.Windows.Forms.ListViewItem() { listViewItem1, listViewItem2, listViewItem3, listViewItem4, listViewItem5, listViewItem6, listViewItem7, listViewItem8, listViewItem9, listViewItem10})
        Me.kryptonListView1.Location = New System.Drawing.Point(16, 539)
        Me.kryptonListView1.Margin = New System.Windows.Forms.Padding(4)
        Me.kryptonListView1.Name = "kryptonListView1"
        Me.kryptonListView1.Size = New System.Drawing.Size(1635, 68)
        Me.kryptonListView1.TabIndex = 17
        Me.kryptonListView1.TileSize = New System.Drawing.Size(228, 36)
        Me.kryptonListView1.View = System.Windows.Forms.View.Tile
        '
        'kryptonListBox1
        '
        Me.kryptonListBox1.Items.AddRange(New Object() { "1", "2", "3", "4", "5", "6", "7", "8", "9", "10"})
        Me.kryptonListBox1.Location = New System.Drawing.Point(16, 287)
        Me.kryptonListBox1.Margin = New System.Windows.Forms.Padding(4)
        Me.kryptonListBox1.Name = "kryptonListBox1"
        Me.kryptonListBox1.Size = New System.Drawing.Size(252, 244)
        Me.kryptonListBox1.TabIndex = 16
        '
        'kryptonDomainUpDown1
        '
        Me.kryptonDomainUpDown1.Location = New System.Drawing.Point(277, 84)
        Me.kryptonDomainUpDown1.Margin = New System.Windows.Forms.Padding(4)
        Me.kryptonDomainUpDown1.Name = "kryptonDomainUpDown1"
        Me.kryptonDomainUpDown1.Size = New System.Drawing.Size(160, 26)
        Me.kryptonDomainUpDown1.TabIndex = 15
        Me.kryptonDomainUpDown1.Text = "kryptonDomainUpDown1"
        '
        'kryptonDateTimePicker1
        '
        Me.kryptonDateTimePicker1.Location = New System.Drawing.Point(277, 49)
        Me.kryptonDateTimePicker1.Margin = New System.Windows.Forms.Padding(4)
        Me.kryptonDateTimePicker1.Name = "kryptonDateTimePicker1"
        Me.kryptonDateTimePicker1.Size = New System.Drawing.Size(161, 25)
        Me.kryptonDateTimePicker1.TabIndex = 14
        '
        'kryptonComboBox1
        '
        Me.kryptonComboBox1.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.kryptonComboBox1.DropDownWidth = 161
        Me.kryptonComboBox1.IntegralHeight = False
        Me.kryptonComboBox1.Items.AddRange(New Object() { "1", "2", "3", "4", "5", "6", "7", "8", "9", "10"})
        Me.kryptonComboBox1.Location = New System.Drawing.Point(277, 15)
        Me.kryptonComboBox1.Margin = New System.Windows.Forms.Padding(4)
        Me.kryptonComboBox1.Name = "kryptonComboBox1"
        Me.kryptonComboBox1.Size = New System.Drawing.Size(161, 26)
        Me.kryptonComboBox1.StateCommon.ComboBox.Content.TextH = Krypton.Toolkit.PaletteRelativeAlign.Near
        Me.kryptonComboBox1.TabIndex = 13
        '
        'kryptonCheckedListBox1
        '
        Me.kryptonCheckedListBox1.Items.AddRange(New Object() { "1", "2", "3", "4", "5", "6", "7", "8", "9", "10"})
        Me.kryptonCheckedListBox1.Location = New System.Drawing.Point(16, 15)
        Me.kryptonCheckedListBox1.Margin = New System.Windows.Forms.Padding(4)
        Me.kryptonCheckedListBox1.Name = "kryptonCheckedListBox1"
        Me.kryptonCheckedListBox1.Size = New System.Drawing.Size(252, 263)
        Me.kryptonCheckedListBox1.TabIndex = 12
        '
        'kryptonButton1
        '
        Me.kryptonButton1.Location = New System.Drawing.Point(1531, 624)
        Me.kryptonButton1.Margin = New System.Windows.Forms.Padding(4)
        Me.kryptonButton1.Name = "kryptonButton1"
        Me.kryptonButton1.Size = New System.Drawing.Size(120, 31)
        Me.kryptonButton1.TabIndex = 24
        Me.kryptonButton1.Values.DropDownArrowColor = System.Drawing.Color.Empty
        Me.kryptonButton1.Values.Text = "kryptonButton1"
        '
        'kryptonThemeComboBox1
        '
        Me.kryptonThemeComboBox1.DefaultPalette = Krypton.Toolkit.PaletteMode.ProfessionalSystem
        Me.kryptonThemeComboBox1.DropDownWidth = 263
        Me.kryptonThemeComboBox1.IntegralHeight = False
        Me.kryptonThemeComboBox1.Location = New System.Drawing.Point(17, 629)
        Me.kryptonThemeComboBox1.Margin = New System.Windows.Forms.Padding(4)
        Me.kryptonThemeComboBox1.Name = "kryptonThemeComboBox1"
        Me.kryptonThemeComboBox1.Size = New System.Drawing.Size(263, 26)
        Me.kryptonThemeComboBox1.StateCommon.ComboBox.Content.TextH = Krypton.Toolkit.PaletteRelativeAlign.Near
        Me.kryptonThemeComboBox1.TabIndex = 25
        '
        'toolStrip1
        '
        Me.toolStrip1.Dock = System.Windows.Forms.DockStyle.None
        Me.toolStrip1.Font = New System.Drawing.Font("Segoe UI", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.World)
        Me.toolStrip1.ImageScalingSize = New System.Drawing.Size(20, 20)
        Me.toolStrip1.Items.AddRange(New System.Windows.Forms.ToolStripItem() { Me.newToolStripButton, Me.openToolStripButton, Me.saveToolStripButton, Me.printToolStripButton, Me.toolStripSeparator, Me.cutToolStripButton, Me.copyToolStripButton, Me.pasteToolStripButton, Me.toolStripSeparator1, Me.helpToolStripButton, Me.toolStripButton1})
        Me.toolStrip1.Location = New System.Drawing.Point(471, 629)
        Me.toolStrip1.Name = "toolStrip1"
        Me.toolStrip1.Size = New System.Drawing.Size(350, 27)
        Me.toolStrip1.TabIndex = 26
        Me.toolStrip1.Text = "toolStrip1"
        '
        'newToolStripButton
        '
        Me.newToolStripButton.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image
        Me.newToolStripButton.Image = CType(resources.GetObject("newToolStripButton.Image"), System.Drawing.Image)
        Me.newToolStripButton.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.newToolStripButton.Name = "newToolStripButton"
        Me.newToolStripButton.Size = New System.Drawing.Size(29, 24)
        Me.newToolStripButton.Text = "&New"
        '
        'openToolStripButton
        '
        Me.openToolStripButton.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image
        Me.openToolStripButton.Image = CType(resources.GetObject("openToolStripButton.Image"), System.Drawing.Image)
        Me.openToolStripButton.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.openToolStripButton.Name = "openToolStripButton"
        Me.openToolStripButton.Size = New System.Drawing.Size(29, 24)
        Me.openToolStripButton.Text = "&Open"
        '
        'saveToolStripButton
        '
        Me.saveToolStripButton.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image
        Me.saveToolStripButton.Image = CType(resources.GetObject("saveToolStripButton.Image"), System.Drawing.Image)
        Me.saveToolStripButton.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.saveToolStripButton.Name = "saveToolStripButton"
        Me.saveToolStripButton.Size = New System.Drawing.Size(29, 24)
        Me.saveToolStripButton.Text = "&Save"
        '
        'printToolStripButton
        '
        Me.printToolStripButton.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image
        Me.printToolStripButton.Image = CType(resources.GetObject("printToolStripButton.Image"), System.Drawing.Image)
        Me.printToolStripButton.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.printToolStripButton.Name = "printToolStripButton"
        Me.printToolStripButton.Size = New System.Drawing.Size(29, 24)
        Me.printToolStripButton.Text = "&Print"
        '
        'toolStripSeparator
        '
        Me.toolStripSeparator.Name = "toolStripSeparator"
        Me.toolStripSeparator.Size = New System.Drawing.Size(6, 27)
        '
        'cutToolStripButton
        '
        Me.cutToolStripButton.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image
        Me.cutToolStripButton.Image = CType(resources.GetObject("cutToolStripButton.Image"), System.Drawing.Image)
        Me.cutToolStripButton.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.cutToolStripButton.Name = "cutToolStripButton"
        Me.cutToolStripButton.Size = New System.Drawing.Size(29, 24)
        Me.cutToolStripButton.Text = "C&ut"
        '
        'copyToolStripButton
        '
        Me.copyToolStripButton.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image
        Me.copyToolStripButton.Image = CType(resources.GetObject("copyToolStripButton.Image"), System.Drawing.Image)
        Me.copyToolStripButton.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.copyToolStripButton.Name = "copyToolStripButton"
        Me.copyToolStripButton.Size = New System.Drawing.Size(29, 24)
        Me.copyToolStripButton.Text = "&Copy"
        '
        'pasteToolStripButton
        '
        Me.pasteToolStripButton.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image
        Me.pasteToolStripButton.Image = CType(resources.GetObject("pasteToolStripButton.Image"), System.Drawing.Image)
        Me.pasteToolStripButton.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.pasteToolStripButton.Name = "pasteToolStripButton"
        Me.pasteToolStripButton.Size = New System.Drawing.Size(29, 24)
        Me.pasteToolStripButton.Text = "&Paste"
        '
        'toolStripSeparator1
        '
        Me.toolStripSeparator1.Name = "toolStripSeparator1"
        Me.toolStripSeparator1.Size = New System.Drawing.Size(6, 27)
        '
        'helpToolStripButton
        '
        Me.helpToolStripButton.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image
        Me.helpToolStripButton.Image = CType(resources.GetObject("helpToolStripButton.Image"), System.Drawing.Image)
        Me.helpToolStripButton.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.helpToolStripButton.Name = "helpToolStripButton"
        Me.helpToolStripButton.Size = New System.Drawing.Size(29, 24)
        Me.helpToolStripButton.Text = "He&lp"
        '
        'toolStripButton1
        '
        Me.toolStripButton1.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Text
        Me.toolStripButton1.Image = CType(resources.GetObject("toolStripButton1.Image"), System.Drawing.Image)
        Me.toolStripButton1.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.toolStripButton1.Name = "toolStripButton1"
        Me.toolStripButton1.Size = New System.Drawing.Size(93, 24)
        Me.toolStripButton1.Text = "Hello World"
        Me.toolStripButton1.TextImageRelation = System.Windows.Forms.TextImageRelation.TextBeforeImage
        '
        'kpg
        '
        Me.kpg.Location = New System.Drawing.Point(829, 15)
        Me.kpg.Margin = New System.Windows.Forms.Padding(4)
        Me.kpg.Name = "kpg"
        Me.kpg.Padding = New System.Windows.Forms.Padding(1)
        Me.kpg.SelectedObject = Me.kryptonButton1
        Me.kpg.Size = New System.Drawing.Size(821, 517)
        Me.kpg.TabIndex = 27
        '
        'kryptonColorButton1
        '
        Me.kryptonColorButton1.Location = New System.Drawing.Point(448, 64)
        Me.kryptonColorButton1.Margin = New System.Windows.Forms.Padding(4)
        Me.kryptonColorButton1.Name = "kryptonColorButton1"
        Me.kryptonColorButton1.Size = New System.Drawing.Size(261, 31)
        Me.kryptonColorButton1.TabIndex = 28
        Me.kryptonColorButton1.Values.Text = "kryptonColorButton1"
        '
        'kryptonPanel1
        '
        Me.kryptonPanel1.Controls.Add(Me.toolStrip1)
        Me.kryptonPanel1.Dock = System.Windows.Forms.DockStyle.Fill
        Me.kryptonPanel1.Location = New System.Drawing.Point(0, 0)
        Me.kryptonPanel1.Margin = New System.Windows.Forms.Padding(4)
        Me.kryptonPanel1.Name = "kryptonPanel1"
        Me.kryptonPanel1.Size = New System.Drawing.Size(1671, 656)
        Me.kryptonPanel1.TabIndex = 29
        '
        'Form1
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8F, 16F)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(1671, 656)
        Me.Controls.Add(Me.kryptonColorButton1)
        Me.Controls.Add(Me.kpg)
        Me.Controls.Add(Me.kryptonThemeComboBox1)
        Me.Controls.Add(Me.kryptonButton1)
        Me.Controls.Add(Me.kryptonTreeView1)
        Me.Controls.Add(Me.kryptonTextBox1)
        Me.Controls.Add(Me.kryptonRichTextBox1)
        Me.Controls.Add(Me.kryptonNumericUpDown1)
        Me.Controls.Add(Me.kryptonMaskedTextBox1)
        Me.Controls.Add(Me.kryptonListView1)
        Me.Controls.Add(Me.kryptonListBox1)
        Me.Controls.Add(Me.kryptonDomainUpDown1)
        Me.Controls.Add(Me.kryptonDateTimePicker1)
        Me.Controls.Add(Me.kryptonComboBox1)
        Me.Controls.Add(Me.kryptonCheckedListBox1)
        Me.Controls.Add(Me.kryptonPanel1)
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.Margin = New System.Windows.Forms.Padding(4)
        Me.Name = "Form1"
        Me.Text = "Krypton Theme Test"
        CType(Me.kryptonComboBox1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.kryptonThemeComboBox1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.toolStrip1.ResumeLayout(False)
        Me.toolStrip1.PerformLayout()
        CType(Me.kryptonPanel1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.kryptonPanel1.ResumeLayout(False)
        Me.kryptonPanel1.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()
    End Sub

    Friend WithEvents kryptonTreeView1 As Krypton.Toolkit.KryptonTreeView
    Friend WithEvents kryptonTextBox1 As Krypton.Toolkit.KryptonTextBox
    Friend WithEvents kryptonRichTextBox1 As Krypton.Toolkit.KryptonRichTextBox
    Friend WithEvents kryptonNumericUpDown1 As Krypton.Toolkit.KryptonNumericUpDown
    Friend WithEvents kryptonMaskedTextBox1 As Krypton.Toolkit.KryptonMaskedTextBox
    Friend WithEvents kryptonListView1 As Krypton.Toolkit.KryptonListView
    Friend WithEvents kryptonListBox1 As Krypton.Toolkit.KryptonListBox
    Friend WithEvents kryptonDomainUpDown1 As Krypton.Toolkit.KryptonDomainUpDown
    Friend WithEvents kryptonDateTimePicker1 As Krypton.Toolkit.KryptonDateTimePicker
    Friend WithEvents kryptonComboBox1 As Krypton.Toolkit.KryptonComboBox
    Friend WithEvents kryptonCheckedListBox1 As Krypton.Toolkit.KryptonCheckedListBox
    Friend WithEvents kryptonButton1 As Krypton.Toolkit.KryptonButton
    Friend WithEvents kryptonThemeComboBox1 As Krypton.Toolkit.KryptonThemeComboBox
    Friend WithEvents toolStrip1 As System.Windows.Forms.ToolStrip
    Friend WithEvents newToolStripButton As System.Windows.Forms.ToolStripButton
    Friend WithEvents openToolStripButton As System.Windows.Forms.ToolStripButton
    Friend WithEvents saveToolStripButton As System.Windows.Forms.ToolStripButton
    Friend WithEvents printToolStripButton As System.Windows.Forms.ToolStripButton
    Friend WithEvents toolStripSeparator As System.Windows.Forms.ToolStripSeparator
    Friend WithEvents cutToolStripButton As System.Windows.Forms.ToolStripButton
    Friend WithEvents copyToolStripButton As System.Windows.Forms.ToolStripButton
    Friend WithEvents pasteToolStripButton As System.Windows.Forms.ToolStripButton
    Friend WithEvents toolStripSeparator1 As System.Windows.Forms.ToolStripSeparator
    Friend WithEvents helpToolStripButton As System.Windows.Forms.ToolStripButton
    Friend WithEvents toolStripButton1 As System.Windows.Forms.ToolStripButton
    Friend WithEvents kpg As Krypton.Toolkit.KryptonPropertyGrid
    Friend WithEvents kryptonColorButton1 As Krypton.Toolkit.KryptonColorButton
    Friend WithEvents kryptonPanel1 As Krypton.Toolkit.KryptonPanel
End Class
