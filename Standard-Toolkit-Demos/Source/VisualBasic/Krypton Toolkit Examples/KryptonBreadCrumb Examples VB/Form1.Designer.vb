' VB.NET twin of Source\Krypton Toolkit Examples\KryptonBreadCrumb Examples\Form1.Designer.cs (Bastion Phase 4c).
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
        Dim treeNode1 As System.Windows.Forms.TreeNode = New System.Windows.Forms.TreeNode("Alpha")
        Dim treeNode2 As System.Windows.Forms.TreeNode = New System.Windows.Forms.TreeNode("Up", New System.Windows.Forms.TreeNode() { treeNode1})
        Dim treeNode3 As System.Windows.Forms.TreeNode = New System.Windows.Forms.TreeNode("Beta")
        Dim treeNode4 As System.Windows.Forms.TreeNode = New System.Windows.Forms.TreeNode("Down", New System.Windows.Forms.TreeNode() { treeNode3})
        Dim treeNode5 As System.Windows.Forms.TreeNode = New System.Windows.Forms.TreeNode("Red", New System.Windows.Forms.TreeNode() { treeNode2, treeNode4})
        Dim treeNode6 As System.Windows.Forms.TreeNode = New System.Windows.Forms.TreeNode("Left")
        Dim treeNode7 As System.Windows.Forms.TreeNode = New System.Windows.Forms.TreeNode("Right")
        Dim treeNode8 As System.Windows.Forms.TreeNode = New System.Windows.Forms.TreeNode("Green", New System.Windows.Forms.TreeNode() { treeNode6, treeNode7})
        Dim treeNode9 As System.Windows.Forms.TreeNode = New System.Windows.Forms.TreeNode("Top", New System.Windows.Forms.TreeNode() { treeNode5, treeNode8})
        Dim treeNode10 As System.Windows.Forms.TreeNode = New System.Windows.Forms.TreeNode("Gamma")
        Dim treeNode11 As System.Windows.Forms.TreeNode = New System.Windows.Forms.TreeNode("Fast", New System.Windows.Forms.TreeNode() { treeNode10})
        Dim treeNode12 As System.Windows.Forms.TreeNode = New System.Windows.Forms.TreeNode("Theta")
        Dim treeNode13 As System.Windows.Forms.TreeNode = New System.Windows.Forms.TreeNode("Slow", New System.Windows.Forms.TreeNode() { treeNode12})
        Dim treeNode14 As System.Windows.Forms.TreeNode = New System.Windows.Forms.TreeNode("Tall", New System.Windows.Forms.TreeNode() { treeNode11, treeNode13})
        Dim treeNode15 As System.Windows.Forms.TreeNode = New System.Windows.Forms.TreeNode("Omega")
        Dim treeNode16 As System.Windows.Forms.TreeNode = New System.Windows.Forms.TreeNode("Strong", New System.Windows.Forms.TreeNode() { treeNode15})
        Dim treeNode17 As System.Windows.Forms.TreeNode = New System.Windows.Forms.TreeNode("Delta")
        Dim treeNode18 As System.Windows.Forms.TreeNode = New System.Windows.Forms.TreeNode("Weak", New System.Windows.Forms.TreeNode() { treeNode17})
        Dim treeNode19 As System.Windows.Forms.TreeNode = New System.Windows.Forms.TreeNode("Short", New System.Windows.Forms.TreeNode() { treeNode16, treeNode18})
        Dim treeNode20 As System.Windows.Forms.TreeNode = New System.Windows.Forms.TreeNode("Bottom", New System.Windows.Forms.TreeNode() { treeNode14, treeNode19})
        Dim treeNode21 As System.Windows.Forms.TreeNode = New System.Windows.Forms.TreeNode("Root", New System.Windows.Forms.TreeNode() { treeNode9, treeNode20})
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(Form1))
        Me.groupBox1 = New System.Windows.Forms.GroupBox()
        Me.groupBox4 = New System.Windows.Forms.GroupBox()
        Me.propertyGrid = New System.Windows.Forms.PropertyGrid()
        Me.buttonClose = New System.Windows.Forms.Button()
        Me.groupBox2 = New System.Windows.Forms.GroupBox()
        Me.treeView1 = New System.Windows.Forms.TreeView()
        Me.kryptonBreadCrumb4 = New Krypton.Toolkit.KryptonBreadCrumb()
        Me.kryptonBreadCrumbItem124 = New Krypton.Toolkit.KryptonBreadCrumbItem()
        Me.kryptonBreadCrumbItem125 = New Krypton.Toolkit.KryptonBreadCrumbItem()
        Me.kryptonBreadCrumbItem126 = New Krypton.Toolkit.KryptonBreadCrumbItem()
        Me.kryptonBreadCrumbItem127 = New Krypton.Toolkit.KryptonBreadCrumbItem()
        Me.kryptonBreadCrumbItem128 = New Krypton.Toolkit.KryptonBreadCrumbItem()
        Me.kryptonBreadCrumbItem129 = New Krypton.Toolkit.KryptonBreadCrumbItem()
        Me.kryptonBreadCrumbItem130 = New Krypton.Toolkit.KryptonBreadCrumbItem()
        Me.kryptonBreadCrumbItem131 = New Krypton.Toolkit.KryptonBreadCrumbItem()
        Me.kryptonBreadCrumbItem132 = New Krypton.Toolkit.KryptonBreadCrumbItem()
        Me.kryptonBreadCrumbItem133 = New Krypton.Toolkit.KryptonBreadCrumbItem()
        Me.kryptonBreadCrumbItem134 = New Krypton.Toolkit.KryptonBreadCrumbItem()
        Me.kryptonBreadCrumbItem135 = New Krypton.Toolkit.KryptonBreadCrumbItem()
        Me.kryptonBreadCrumbItem136 = New Krypton.Toolkit.KryptonBreadCrumbItem()
        Me.kryptonBreadCrumbItem137 = New Krypton.Toolkit.KryptonBreadCrumbItem()
        Me.kryptonBreadCrumbItem138 = New Krypton.Toolkit.KryptonBreadCrumbItem()
        Me.kryptonBreadCrumbItem139 = New Krypton.Toolkit.KryptonBreadCrumbItem()
        Me.kryptonBreadCrumbItem140 = New Krypton.Toolkit.KryptonBreadCrumbItem()
        Me.kryptonBreadCrumbItem141 = New Krypton.Toolkit.KryptonBreadCrumbItem()
        Me.kryptonBreadCrumbItem142 = New Krypton.Toolkit.KryptonBreadCrumbItem()
        Me.kryptonBreadCrumbItem143 = New Krypton.Toolkit.KryptonBreadCrumbItem()
        Me.kryptonBreadCrumb3 = New Krypton.Toolkit.KryptonBreadCrumb()
        Me.buttonSpecAny2 = New Krypton.Toolkit.ButtonSpecAny()
        Me.kryptonContextMenu1 = New Krypton.Toolkit.KryptonContextMenu()
        Me.kryptonContextMenuHeading1 = New Krypton.Toolkit.KryptonContextMenuHeading()
        Me.kryptonContextMenuItems1 = New Krypton.Toolkit.KryptonContextMenuItems()
        Me.menuSpider = New Krypton.Toolkit.KryptonContextMenuItem()
        Me.menuKangeroo = New Krypton.Toolkit.KryptonContextMenuItem()
        Me.menuFern = New Krypton.Toolkit.KryptonContextMenuItem()
        Me.kryptonBreadCrumbItem42 = New Krypton.Toolkit.KryptonBreadCrumbItem()
        Me.kryptonBreadCrumbItem43 = New Krypton.Toolkit.KryptonBreadCrumbItem()
        Me.kryptonBreadCrumbItem44 = New Krypton.Toolkit.KryptonBreadCrumbItem()
        Me.kryptonBreadCrumbItem45 = New Krypton.Toolkit.KryptonBreadCrumbItem()
        Me.kryptonBreadCrumbItem46 = New Krypton.Toolkit.KryptonBreadCrumbItem()
        Me.kryptonBreadCrumbItem47 = New Krypton.Toolkit.KryptonBreadCrumbItem()
        Me.kryptonBreadCrumbItem48 = New Krypton.Toolkit.KryptonBreadCrumbItem()
        Me.kryptonBreadCrumbItem49 = New Krypton.Toolkit.KryptonBreadCrumbItem()
        Me.kryptonBreadCrumbItem50 = New Krypton.Toolkit.KryptonBreadCrumbItem()
        Me.kryptonBreadCrumbItem51 = New Krypton.Toolkit.KryptonBreadCrumbItem()
        Me.kryptonBreadCrumbItem52 = New Krypton.Toolkit.KryptonBreadCrumbItem()
        Me.kryptonBreadCrumbItem53 = New Krypton.Toolkit.KryptonBreadCrumbItem()
        Me.kryptonBreadCrumbItem54 = New Krypton.Toolkit.KryptonBreadCrumbItem()
        Me.kryptonBreadCrumbItem55 = New Krypton.Toolkit.KryptonBreadCrumbItem()
        Me.kryptonBreadCrumbItem56 = New Krypton.Toolkit.KryptonBreadCrumbItem()
        Me.kryptonBreadCrumbItem57 = New Krypton.Toolkit.KryptonBreadCrumbItem()
        Me.kryptonBreadCrumbItem58 = New Krypton.Toolkit.KryptonBreadCrumbItem()
        Me.kryptonBreadCrumbItem59 = New Krypton.Toolkit.KryptonBreadCrumbItem()
        Me.kryptonBreadCrumbItem60 = New Krypton.Toolkit.KryptonBreadCrumbItem()
        Me.kryptonBreadCrumbItem61 = New Krypton.Toolkit.KryptonBreadCrumbItem()
        Me.kryptonBreadCrumbItem62 = New Krypton.Toolkit.KryptonBreadCrumbItem()
        Me.kryptonBreadCrumbItem63 = New Krypton.Toolkit.KryptonBreadCrumbItem()
        Me.kryptonBreadCrumbItem64 = New Krypton.Toolkit.KryptonBreadCrumbItem()
        Me.kryptonBreadCrumbItem65 = New Krypton.Toolkit.KryptonBreadCrumbItem()
        Me.kryptonBreadCrumbItem66 = New Krypton.Toolkit.KryptonBreadCrumbItem()
        Me.kryptonBreadCrumbItem67 = New Krypton.Toolkit.KryptonBreadCrumbItem()
        Me.kryptonBreadCrumbItem68 = New Krypton.Toolkit.KryptonBreadCrumbItem()
        Me.kryptonBreadCrumbItem69 = New Krypton.Toolkit.KryptonBreadCrumbItem()
        Me.kryptonBreadCrumbItem70 = New Krypton.Toolkit.KryptonBreadCrumbItem()
        Me.kryptonBreadCrumbItem71 = New Krypton.Toolkit.KryptonBreadCrumbItem()
        Me.kryptonBreadCrumbItem72 = New Krypton.Toolkit.KryptonBreadCrumbItem()
        Me.kryptonBreadCrumbItem73 = New Krypton.Toolkit.KryptonBreadCrumbItem()
        Me.kryptonBreadCrumbItem74 = New Krypton.Toolkit.KryptonBreadCrumbItem()
        Me.kryptonBreadCrumbItem75 = New Krypton.Toolkit.KryptonBreadCrumbItem()
        Me.kryptonBreadCrumbItem76 = New Krypton.Toolkit.KryptonBreadCrumbItem()
        Me.kryptonBreadCrumbItem77 = New Krypton.Toolkit.KryptonBreadCrumbItem()
        Me.kryptonBreadCrumbItem78 = New Krypton.Toolkit.KryptonBreadCrumbItem()
        Me.kryptonBreadCrumbItem79 = New Krypton.Toolkit.KryptonBreadCrumbItem()
        Me.kryptonBreadCrumbItem80 = New Krypton.Toolkit.KryptonBreadCrumbItem()
        Me.kryptonBreadCrumbItem81 = New Krypton.Toolkit.KryptonBreadCrumbItem()
        Me.kryptonBreadCrumbItem82 = New Krypton.Toolkit.KryptonBreadCrumbItem()
        Me.kryptonBreadCrumb2 = New Krypton.Toolkit.KryptonBreadCrumb()
        Me.buttonSpecAny1 = New Krypton.Toolkit.ButtonSpecAny()
        Me.kryptonBreadCrumbItem83 = New Krypton.Toolkit.KryptonBreadCrumbItem()
        Me.kryptonBreadCrumbItem84 = New Krypton.Toolkit.KryptonBreadCrumbItem()
        Me.kryptonBreadCrumbItem85 = New Krypton.Toolkit.KryptonBreadCrumbItem()
        Me.kryptonBreadCrumbItem86 = New Krypton.Toolkit.KryptonBreadCrumbItem()
        Me.kryptonBreadCrumbItem87 = New Krypton.Toolkit.KryptonBreadCrumbItem()
        Me.kryptonBreadCrumbItem88 = New Krypton.Toolkit.KryptonBreadCrumbItem()
        Me.kryptonBreadCrumbItem89 = New Krypton.Toolkit.KryptonBreadCrumbItem()
        Me.kryptonBreadCrumbItem90 = New Krypton.Toolkit.KryptonBreadCrumbItem()
        Me.kryptonBreadCrumbItem91 = New Krypton.Toolkit.KryptonBreadCrumbItem()
        Me.kryptonBreadCrumbItem92 = New Krypton.Toolkit.KryptonBreadCrumbItem()
        Me.kryptonBreadCrumbItem93 = New Krypton.Toolkit.KryptonBreadCrumbItem()
        Me.kryptonBreadCrumbItem94 = New Krypton.Toolkit.KryptonBreadCrumbItem()
        Me.kryptonBreadCrumbItem95 = New Krypton.Toolkit.KryptonBreadCrumbItem()
        Me.kryptonBreadCrumbItem96 = New Krypton.Toolkit.KryptonBreadCrumbItem()
        Me.kryptonBreadCrumbItem97 = New Krypton.Toolkit.KryptonBreadCrumbItem()
        Me.kryptonBreadCrumbItem98 = New Krypton.Toolkit.KryptonBreadCrumbItem()
        Me.kryptonBreadCrumbItem99 = New Krypton.Toolkit.KryptonBreadCrumbItem()
        Me.kryptonBreadCrumbItem100 = New Krypton.Toolkit.KryptonBreadCrumbItem()
        Me.kryptonBreadCrumbItem101 = New Krypton.Toolkit.KryptonBreadCrumbItem()
        Me.kryptonBreadCrumbItem102 = New Krypton.Toolkit.KryptonBreadCrumbItem()
        Me.kryptonBreadCrumbItem103 = New Krypton.Toolkit.KryptonBreadCrumbItem()
        Me.kryptonBreadCrumbItem104 = New Krypton.Toolkit.KryptonBreadCrumbItem()
        Me.kryptonBreadCrumbItem105 = New Krypton.Toolkit.KryptonBreadCrumbItem()
        Me.kryptonBreadCrumbItem106 = New Krypton.Toolkit.KryptonBreadCrumbItem()
        Me.kryptonBreadCrumbItem107 = New Krypton.Toolkit.KryptonBreadCrumbItem()
        Me.kryptonBreadCrumbItem108 = New Krypton.Toolkit.KryptonBreadCrumbItem()
        Me.kryptonBreadCrumbItem109 = New Krypton.Toolkit.KryptonBreadCrumbItem()
        Me.kryptonBreadCrumbItem110 = New Krypton.Toolkit.KryptonBreadCrumbItem()
        Me.kryptonBreadCrumbItem111 = New Krypton.Toolkit.KryptonBreadCrumbItem()
        Me.kryptonBreadCrumbItem112 = New Krypton.Toolkit.KryptonBreadCrumbItem()
        Me.kryptonBreadCrumbItem113 = New Krypton.Toolkit.KryptonBreadCrumbItem()
        Me.kryptonBreadCrumbItem114 = New Krypton.Toolkit.KryptonBreadCrumbItem()
        Me.kryptonBreadCrumbItem115 = New Krypton.Toolkit.KryptonBreadCrumbItem()
        Me.kryptonBreadCrumbItem116 = New Krypton.Toolkit.KryptonBreadCrumbItem()
        Me.kryptonBreadCrumbItem117 = New Krypton.Toolkit.KryptonBreadCrumbItem()
        Me.kryptonBreadCrumbItem118 = New Krypton.Toolkit.KryptonBreadCrumbItem()
        Me.kryptonBreadCrumbItem119 = New Krypton.Toolkit.KryptonBreadCrumbItem()
        Me.kryptonBreadCrumbItem120 = New Krypton.Toolkit.KryptonBreadCrumbItem()
        Me.kryptonBreadCrumbItem121 = New Krypton.Toolkit.KryptonBreadCrumbItem()
        Me.kryptonBreadCrumbItem122 = New Krypton.Toolkit.KryptonBreadCrumbItem()
        Me.kryptonBreadCrumbItem123 = New Krypton.Toolkit.KryptonBreadCrumbItem()
        Me.kryptonBreadCrumb1 = New Krypton.Toolkit.KryptonBreadCrumb()
        Me.kryptonBreadCrumbItem1 = New Krypton.Toolkit.KryptonBreadCrumbItem()
        Me.kryptonBreadCrumbItem2 = New Krypton.Toolkit.KryptonBreadCrumbItem()
        Me.kryptonBreadCrumbItem3 = New Krypton.Toolkit.KryptonBreadCrumbItem()
        Me.kryptonBreadCrumbItem4 = New Krypton.Toolkit.KryptonBreadCrumbItem()
        Me.kryptonBreadCrumbItem5 = New Krypton.Toolkit.KryptonBreadCrumbItem()
        Me.kryptonBreadCrumbItem6 = New Krypton.Toolkit.KryptonBreadCrumbItem()
        Me.kryptonBreadCrumbItem7 = New Krypton.Toolkit.KryptonBreadCrumbItem()
        Me.kryptonBreadCrumbItem8 = New Krypton.Toolkit.KryptonBreadCrumbItem()
        Me.kryptonBreadCrumbItem9 = New Krypton.Toolkit.KryptonBreadCrumbItem()
        Me.kryptonBreadCrumbItem10 = New Krypton.Toolkit.KryptonBreadCrumbItem()
        Me.kryptonBreadCrumbItem11 = New Krypton.Toolkit.KryptonBreadCrumbItem()
        Me.kryptonBreadCrumbItem12 = New Krypton.Toolkit.KryptonBreadCrumbItem()
        Me.kryptonBreadCrumbItem13 = New Krypton.Toolkit.KryptonBreadCrumbItem()
        Me.kryptonBreadCrumbItem14 = New Krypton.Toolkit.KryptonBreadCrumbItem()
        Me.kryptonBreadCrumbItem15 = New Krypton.Toolkit.KryptonBreadCrumbItem()
        Me.kryptonBreadCrumbItem16 = New Krypton.Toolkit.KryptonBreadCrumbItem()
        Me.kryptonBreadCrumbItem17 = New Krypton.Toolkit.KryptonBreadCrumbItem()
        Me.kryptonBreadCrumbItem18 = New Krypton.Toolkit.KryptonBreadCrumbItem()
        Me.kryptonBreadCrumbItem19 = New Krypton.Toolkit.KryptonBreadCrumbItem()
        Me.kryptonBreadCrumbItem20 = New Krypton.Toolkit.KryptonBreadCrumbItem()
        Me.kryptonBreadCrumbItem21 = New Krypton.Toolkit.KryptonBreadCrumbItem()
        Me.kryptonBreadCrumbItem22 = New Krypton.Toolkit.KryptonBreadCrumbItem()
        Me.kryptonBreadCrumbItem23 = New Krypton.Toolkit.KryptonBreadCrumbItem()
        Me.kryptonBreadCrumbItem24 = New Krypton.Toolkit.KryptonBreadCrumbItem()
        Me.kryptonBreadCrumbItem25 = New Krypton.Toolkit.KryptonBreadCrumbItem()
        Me.kryptonBreadCrumbItem26 = New Krypton.Toolkit.KryptonBreadCrumbItem()
        Me.kryptonBreadCrumbItem27 = New Krypton.Toolkit.KryptonBreadCrumbItem()
        Me.kryptonBreadCrumbItem28 = New Krypton.Toolkit.KryptonBreadCrumbItem()
        Me.kryptonBreadCrumbItem29 = New Krypton.Toolkit.KryptonBreadCrumbItem()
        Me.kryptonBreadCrumbItem30 = New Krypton.Toolkit.KryptonBreadCrumbItem()
        Me.kryptonBreadCrumbItem31 = New Krypton.Toolkit.KryptonBreadCrumbItem()
        Me.kryptonBreadCrumbItem32 = New Krypton.Toolkit.KryptonBreadCrumbItem()
        Me.kryptonBreadCrumbItem33 = New Krypton.Toolkit.KryptonBreadCrumbItem()
        Me.kryptonBreadCrumbItem34 = New Krypton.Toolkit.KryptonBreadCrumbItem()
        Me.kryptonBreadCrumbItem35 = New Krypton.Toolkit.KryptonBreadCrumbItem()
        Me.kryptonBreadCrumbItem36 = New Krypton.Toolkit.KryptonBreadCrumbItem()
        Me.kryptonBreadCrumbItem37 = New Krypton.Toolkit.KryptonBreadCrumbItem()
        Me.kryptonBreadCrumbItem38 = New Krypton.Toolkit.KryptonBreadCrumbItem()
        Me.kryptonBreadCrumbItem39 = New Krypton.Toolkit.KryptonBreadCrumbItem()
        Me.kryptonBreadCrumbItem40 = New Krypton.Toolkit.KryptonBreadCrumbItem()
        Me.kryptonBreadCrumbItem41 = New Krypton.Toolkit.KryptonBreadCrumbItem()
        Me.groupBox1.SuspendLayout()
        Me.groupBox4.SuspendLayout()
        Me.groupBox2.SuspendLayout()
        CType(Me.kryptonBreadCrumb4, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.kryptonBreadCrumb3, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.kryptonBreadCrumb2, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.kryptonBreadCrumb1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        Me.groupBox1.Controls.Add(Me.kryptonBreadCrumb3)
        Me.groupBox1.Controls.Add(Me.kryptonBreadCrumb2)
        Me.groupBox1.Controls.Add(Me.kryptonBreadCrumb1)
        Me.groupBox1.Location = New System.Drawing.Point(13, 13)
        Me.groupBox1.Name = "groupBox1"
        Me.groupBox1.Size = New System.Drawing.Size(442, 147)
        Me.groupBox1.TabIndex = 0
        Me.groupBox1.TabStop = False
        Me.groupBox1.Text = "Simple Examples"
        Me.groupBox4.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) Or System.Windows.Forms.AnchorStyles.Left) Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.groupBox4.Controls.Add(Me.propertyGrid)
        Me.groupBox4.Location = New System.Drawing.Point(461, 13)
        Me.groupBox4.Name = "groupBox4"
        Me.groupBox4.Size = New System.Drawing.Size(301, 488)
        Me.groupBox4.TabIndex = 2
        Me.groupBox4.TabStop = False
        Me.groupBox4.Text = "Properties for Selection"
        Me.propertyGrid.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) Or System.Windows.Forms.AnchorStyles.Left) Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.propertyGrid.Location = New System.Drawing.Point(6, 19)
        Me.propertyGrid.Name = "propertyGrid"
        Me.propertyGrid.Size = New System.Drawing.Size(289, 463)
        Me.propertyGrid.TabIndex = 0
        Me.propertyGrid.ToolbarVisible = False
        Me.buttonClose.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.buttonClose.DialogResult = System.Windows.Forms.DialogResult.Cancel
        Me.buttonClose.Location = New System.Drawing.Point(688, 511)
        Me.buttonClose.Name = "buttonClose"
        Me.buttonClose.Size = New System.Drawing.Size(75, 23)
        Me.buttonClose.TabIndex = 3
        Me.buttonClose.Text = "&Close"
        Me.buttonClose.UseVisualStyleBackColor = True
        Me.groupBox2.Controls.Add(Me.kryptonBreadCrumb4)
        Me.groupBox2.Controls.Add(Me.treeView1)
        Me.groupBox2.Location = New System.Drawing.Point(13, 167)
        Me.groupBox2.Name = "groupBox2"
        Me.groupBox2.Size = New System.Drawing.Size(442, 334)
        Me.groupBox2.TabIndex = 1
        Me.groupBox2.TabStop = False
        Me.groupBox2.Text = "Sync with TreeControl"
        Me.treeView1.HideSelection = False
        Me.treeView1.Location = New System.Drawing.Point(20, 82)
        Me.treeView1.Name = "treeView1"
        treeNode1.Name = "Node18"
        treeNode1.Text = "Alpha"
        treeNode2.Name = "Node12"
        treeNode2.Text = "Up"
        treeNode3.Name = "Node19"
        treeNode3.Text = "Beta"
        treeNode4.Name = "Node13"
        treeNode4.Text = "Down"
        treeNode5.Name = "Node2"
        treeNode5.Text = "Red"
        treeNode6.Name = "Node14"
        treeNode6.Text = "Left"
        treeNode7.Name = "Node15"
        treeNode7.Text = "Right"
        treeNode8.Name = "Node3"
        treeNode8.Text = "Green"
        treeNode9.Name = "Node0"
        treeNode9.Text = "Top"
        treeNode10.Name = "Node20"
        treeNode10.Text = "Gamma"
        treeNode11.Name = "Node7"
        treeNode11.Text = "Fast"
        treeNode12.Name = "Node21"
        treeNode12.Text = "Theta"
        treeNode13.Name = "Node8"
        treeNode13.Text = "Slow"
        treeNode14.Name = "Node5"
        treeNode14.Text = "Tall"
        treeNode15.Name = "Node22"
        treeNode15.Text = "Omega"
        treeNode16.Name = "Node9"
        treeNode16.Text = "Strong"
        treeNode17.Name = "Node23"
        treeNode17.Text = "Delta"
        treeNode18.Name = "Node11"
        treeNode18.Text = "Weak"
        treeNode19.Name = "Node6"
        treeNode19.Text = "Short"
        treeNode20.Name = "Node1"
        treeNode20.Text = "Bottom"
        treeNode21.Name = "Node0"
        treeNode21.Text = "Root"
        Me.treeView1.Nodes.AddRange(New System.Windows.Forms.TreeNode() { treeNode21})
        Me.treeView1.Size = New System.Drawing.Size(402, 234)
        Me.treeView1.TabIndex = 1
        Me.kryptonBreadCrumb4.AutoSize = False
        Me.kryptonBreadCrumb4.ControlBorderStyle = Krypton.Toolkit.PaletteBorderStyle.ControlClient
        Me.kryptonBreadCrumb4.Location = New System.Drawing.Point(20, 38)
        Me.kryptonBreadCrumb4.Name = "kryptonBreadCrumb4"
        Me.kryptonBreadCrumb4.RootItem.Items.AddRange(New Krypton.Toolkit.KryptonBreadCrumbItem() { Me.kryptonBreadCrumbItem124, Me.kryptonBreadCrumbItem133})
        Me.kryptonBreadCrumb4.RootItem.ShortText = "Root"
        Me.kryptonBreadCrumb4.SelectedItem = Me.kryptonBreadCrumb4.RootItem
        Me.kryptonBreadCrumb4.Size = New System.Drawing.Size(402, 27)
        Me.kryptonBreadCrumb4.TabIndex = 0
        Me.kryptonBreadCrumbItem124.Items.AddRange(New Krypton.Toolkit.KryptonBreadCrumbItem() { Me.kryptonBreadCrumbItem125, Me.kryptonBreadCrumbItem130})
        Me.kryptonBreadCrumbItem124.ShortText = "Top"
        Me.kryptonBreadCrumbItem125.Items.AddRange(New Krypton.Toolkit.KryptonBreadCrumbItem() { Me.kryptonBreadCrumbItem126, Me.kryptonBreadCrumbItem128})
        Me.kryptonBreadCrumbItem125.ShortText = "Red"
        Me.kryptonBreadCrumbItem126.Items.AddRange(New Krypton.Toolkit.KryptonBreadCrumbItem() { Me.kryptonBreadCrumbItem127})
        Me.kryptonBreadCrumbItem126.ShortText = "Up"
        Me.kryptonBreadCrumbItem127.ShortText = "Alpha"
        Me.kryptonBreadCrumbItem128.Items.AddRange(New Krypton.Toolkit.KryptonBreadCrumbItem() { Me.kryptonBreadCrumbItem129})
        Me.kryptonBreadCrumbItem128.ShortText = "Down"
        Me.kryptonBreadCrumbItem129.ShortText = "Beta"
        Me.kryptonBreadCrumbItem130.Items.AddRange(New Krypton.Toolkit.KryptonBreadCrumbItem() { Me.kryptonBreadCrumbItem131, Me.kryptonBreadCrumbItem132})
        Me.kryptonBreadCrumbItem130.ShortText = "Green"
        Me.kryptonBreadCrumbItem131.ShortText = "Left"
        Me.kryptonBreadCrumbItem132.ShortText = "Right"
        Me.kryptonBreadCrumbItem133.Items.AddRange(New Krypton.Toolkit.KryptonBreadCrumbItem() { Me.kryptonBreadCrumbItem134, Me.kryptonBreadCrumbItem139})
        Me.kryptonBreadCrumbItem133.ShortText = "Bottom"
        Me.kryptonBreadCrumbItem134.Items.AddRange(New Krypton.Toolkit.KryptonBreadCrumbItem() { Me.kryptonBreadCrumbItem135, Me.kryptonBreadCrumbItem137})
        Me.kryptonBreadCrumbItem134.ShortText = "Tall"
        Me.kryptonBreadCrumbItem135.Items.AddRange(New Krypton.Toolkit.KryptonBreadCrumbItem() { Me.kryptonBreadCrumbItem136})
        Me.kryptonBreadCrumbItem135.ShortText = "Fast"
        Me.kryptonBreadCrumbItem136.ShortText = "Gamma"
        Me.kryptonBreadCrumbItem137.Items.AddRange(New Krypton.Toolkit.KryptonBreadCrumbItem() { Me.kryptonBreadCrumbItem138})
        Me.kryptonBreadCrumbItem137.ShortText = "Slow"
        Me.kryptonBreadCrumbItem138.ShortText = "Theta"
        Me.kryptonBreadCrumbItem139.Items.AddRange(New Krypton.Toolkit.KryptonBreadCrumbItem() { Me.kryptonBreadCrumbItem140, Me.kryptonBreadCrumbItem142})
        Me.kryptonBreadCrumbItem139.ShortText = "Short"
        Me.kryptonBreadCrumbItem140.Items.AddRange(New Krypton.Toolkit.KryptonBreadCrumbItem() { Me.kryptonBreadCrumbItem141})
        Me.kryptonBreadCrumbItem140.ShortText = "Strong"
        Me.kryptonBreadCrumbItem141.ShortText = "Omega"
        Me.kryptonBreadCrumbItem142.Items.AddRange(New Krypton.Toolkit.KryptonBreadCrumbItem() { Me.kryptonBreadCrumbItem143})
        Me.kryptonBreadCrumbItem142.ShortText = "Weak"
        Me.kryptonBreadCrumbItem143.ShortText = "Delta"
        Me.kryptonBreadCrumb3.AutoSize = False
        Me.kryptonBreadCrumb3.ButtonSpecs.Add(Me.buttonSpecAny2)
        Me.kryptonBreadCrumb3.ControlBorderStyle = Krypton.Toolkit.PaletteBorderStyle.ControlClient
        Me.kryptonBreadCrumb3.Location = New System.Drawing.Point(20, 101)
        Me.kryptonBreadCrumb3.Name = "kryptonBreadCrumb3"
        Me.kryptonBreadCrumb3.PaletteMode = Krypton.Toolkit.PaletteMode.SparkleBlue
        Me.kryptonBreadCrumb3.RootItem.Items.AddRange(New Krypton.Toolkit.KryptonBreadCrumbItem() { Me.kryptonBreadCrumbItem42, Me.kryptonBreadCrumbItem78})
        Me.kryptonBreadCrumb3.RootItem.ShortText = "Root"
        Me.kryptonBreadCrumb3.SelectedItem = Me.kryptonBreadCrumb3.RootItem
        Me.kryptonBreadCrumb3.Size = New System.Drawing.Size(402, 27)
        Me.kryptonBreadCrumb3.TabIndex = 2
        Me.buttonSpecAny2.KryptonContextMenu = Me.kryptonContextMenu1
        Me.buttonSpecAny2.Style = Krypton.Toolkit.PaletteButtonStyle.Inherit
        Me.buttonSpecAny2.ToolTipStyle = Krypton.Toolkit.LabelStyle.ToolTip
        Me.buttonSpecAny2.Type = Krypton.Toolkit.PaletteButtonSpecStyle.DropDown
        Me.buttonSpecAny2.UniqueName = "BF2ABC476E114B81BF2ABC476E114B81"
        Me.kryptonContextMenu1.Items.AddRange(New Krypton.Toolkit.KryptonContextMenuItemBase() { Me.kryptonContextMenuHeading1, Me.kryptonContextMenuItems1})
        Me.kryptonContextMenuHeading1.ExtraText = ""
        Me.kryptonContextMenuHeading1.Text = "Shortcuts"
        Me.kryptonContextMenuItems1.Items.AddRange(New Krypton.Toolkit.KryptonContextMenuItemBase() { Me.menuSpider, Me.menuKangeroo, Me.menuFern})
        Me.menuSpider.Text = "Spider"
        Me.menuKangeroo.Text = "Kangeroo"
        Me.menuFern.Text = "Fern"
        Me.kryptonBreadCrumbItem42.Items.AddRange(New Krypton.Toolkit.KryptonBreadCrumbItem() { Me.kryptonBreadCrumbItem43, Me.kryptonBreadCrumbItem61})
        Me.kryptonBreadCrumbItem42.ShortText = "Animals"
        Me.kryptonBreadCrumbItem43.Items.AddRange(New Krypton.Toolkit.KryptonBreadCrumbItem() { Me.kryptonBreadCrumbItem44, Me.kryptonBreadCrumbItem48, Me.kryptonBreadCrumbItem52, Me.kryptonBreadCrumbItem56})
        Me.kryptonBreadCrumbItem43.ShortText = "Vertebrates"
        Me.kryptonBreadCrumbItem44.Items.AddRange(New Krypton.Toolkit.KryptonBreadCrumbItem() { Me.kryptonBreadCrumbItem45, Me.kryptonBreadCrumbItem46, Me.kryptonBreadCrumbItem47})
        Me.kryptonBreadCrumbItem44.ShortText = "Fish"
        Me.kryptonBreadCrumbItem45.ShortText = "Shark"
        Me.kryptonBreadCrumbItem46.ShortText = "Seahorse"
        Me.kryptonBreadCrumbItem47.ShortText = "Salmon"
        Me.kryptonBreadCrumbItem48.Items.AddRange(New Krypton.Toolkit.KryptonBreadCrumbItem() { Me.kryptonBreadCrumbItem49, Me.kryptonBreadCrumbItem50, Me.kryptonBreadCrumbItem51})
        Me.kryptonBreadCrumbItem48.ShortText = "Reptiles"
        Me.kryptonBreadCrumbItem49.ShortText = "Python"
        Me.kryptonBreadCrumbItem50.ShortText = "Chameleon"
        Me.kryptonBreadCrumbItem51.ShortText = "Crocodile"
        Me.kryptonBreadCrumbItem52.Items.AddRange(New Krypton.Toolkit.KryptonBreadCrumbItem() { Me.kryptonBreadCrumbItem53, Me.kryptonBreadCrumbItem54, Me.kryptonBreadCrumbItem55})
        Me.kryptonBreadCrumbItem52.ShortText = "Marsupials"
        Me.kryptonBreadCrumbItem53.ShortText = "Wombat"
        Me.kryptonBreadCrumbItem54.ShortText = "Koala"
        Me.kryptonBreadCrumbItem55.ShortText = "Kangaroo"
        Me.kryptonBreadCrumbItem56.Items.AddRange(New Krypton.Toolkit.KryptonBreadCrumbItem() { Me.kryptonBreadCrumbItem57, Me.kryptonBreadCrumbItem58, Me.kryptonBreadCrumbItem59, Me.kryptonBreadCrumbItem60})
        Me.kryptonBreadCrumbItem56.ShortText = "Primates"
        Me.kryptonBreadCrumbItem57.ShortText = "Monkey"
        Me.kryptonBreadCrumbItem58.ShortText = "Gorilla"
        Me.kryptonBreadCrumbItem59.ShortText = "Chimpanzee"
        Me.kryptonBreadCrumbItem60.ShortText = "Baboon"
        Me.kryptonBreadCrumbItem61.Items.AddRange(New Krypton.Toolkit.KryptonBreadCrumbItem() { Me.kryptonBreadCrumbItem62, Me.kryptonBreadCrumbItem66, Me.kryptonBreadCrumbItem70, Me.kryptonBreadCrumbItem74})
        Me.kryptonBreadCrumbItem61.ShortText = "Invertebrates"
        Me.kryptonBreadCrumbItem62.Items.AddRange(New Krypton.Toolkit.KryptonBreadCrumbItem() { Me.kryptonBreadCrumbItem63, Me.kryptonBreadCrumbItem64, Me.kryptonBreadCrumbItem65})
        Me.kryptonBreadCrumbItem62.ShortText = "Mollusks"
        Me.kryptonBreadCrumbItem63.ShortText = "Slug"
        Me.kryptonBreadCrumbItem64.ShortText = "Snail"
        Me.kryptonBreadCrumbItem65.ShortText = "Squid"
        Me.kryptonBreadCrumbItem66.Items.AddRange(New Krypton.Toolkit.KryptonBreadCrumbItem() { Me.kryptonBreadCrumbItem67, Me.kryptonBreadCrumbItem68, Me.kryptonBreadCrumbItem69})
        Me.kryptonBreadCrumbItem66.ShortText = "Crustaceans"
        Me.kryptonBreadCrumbItem67.ShortText = "Crab"
        Me.kryptonBreadCrumbItem68.ShortText = "Lobster"
        Me.kryptonBreadCrumbItem69.ShortText = "Barnacle"
        Me.kryptonBreadCrumbItem70.Items.AddRange(New Krypton.Toolkit.KryptonBreadCrumbItem() { Me.kryptonBreadCrumbItem71, Me.kryptonBreadCrumbItem72, Me.kryptonBreadCrumbItem73})
        Me.kryptonBreadCrumbItem70.ShortText = "Arachnids"
        Me.kryptonBreadCrumbItem71.ShortText = "Scorpion"
        Me.kryptonBreadCrumbItem72.ShortText = "Spider"
        Me.kryptonBreadCrumbItem73.ShortText = "Tick"
        Me.kryptonBreadCrumbItem74.Items.AddRange(New Krypton.Toolkit.KryptonBreadCrumbItem() { Me.kryptonBreadCrumbItem75, Me.kryptonBreadCrumbItem76, Me.kryptonBreadCrumbItem77})
        Me.kryptonBreadCrumbItem74.ShortText = "Insects"
        Me.kryptonBreadCrumbItem75.ShortText = "Butterfly"
        Me.kryptonBreadCrumbItem76.ShortText = "Fly"
        Me.kryptonBreadCrumbItem77.ShortText = "Moth"
        Me.kryptonBreadCrumbItem78.Items.AddRange(New Krypton.Toolkit.KryptonBreadCrumbItem() { Me.kryptonBreadCrumbItem79})
        Me.kryptonBreadCrumbItem78.ShortText = "Plants"
        Me.kryptonBreadCrumbItem79.Items.AddRange(New Krypton.Toolkit.KryptonBreadCrumbItem() { Me.kryptonBreadCrumbItem80, Me.kryptonBreadCrumbItem81, Me.kryptonBreadCrumbItem82})
        Me.kryptonBreadCrumbItem79.ShortText = "Seedless"
        Me.kryptonBreadCrumbItem80.ShortText = "Fern"
        Me.kryptonBreadCrumbItem81.ShortText = "Horsetail"
        Me.kryptonBreadCrumbItem82.ShortText = "Club Moss"
        Me.kryptonBreadCrumb2.AutoSize = False
        Me.kryptonBreadCrumb2.ButtonSpecs.Add(Me.buttonSpecAny1)
        Me.kryptonBreadCrumb2.ControlBorderStyle = Krypton.Toolkit.PaletteBorderStyle.ControlClient
        Me.kryptonBreadCrumb2.Location = New System.Drawing.Point(20, 64)
        Me.kryptonBreadCrumb2.Name = "kryptonBreadCrumb2"
        Me.kryptonBreadCrumb2.PaletteMode = Krypton.Toolkit.PaletteMode.Office2010Blue
        Me.kryptonBreadCrumb2.RootItem.Items.AddRange(New Krypton.Toolkit.KryptonBreadCrumbItem() { Me.kryptonBreadCrumbItem83, Me.kryptonBreadCrumbItem119})
        Me.kryptonBreadCrumb2.RootItem.ShortText = "Root"
        Me.kryptonBreadCrumb2.SelectedItem = Me.kryptonBreadCrumb2.RootItem
        Me.kryptonBreadCrumb2.Size = New System.Drawing.Size(402, 27)
        Me.kryptonBreadCrumb2.StateTracking.BreadCrumb.Border.Color1 = System.Drawing.Color.Fuchsia
        Me.kryptonBreadCrumb2.StateTracking.BreadCrumb.Border.DrawBorders = CType((((Krypton.Toolkit.PaletteDrawBorders.Top Or Krypton.Toolkit.PaletteDrawBorders.Bottom) Or Krypton.Toolkit.PaletteDrawBorders.Left) Or Krypton.Toolkit.PaletteDrawBorders.Right), Krypton.Toolkit.PaletteDrawBorders)
        Me.kryptonBreadCrumb2.StateTracking.BreadCrumb.Border.ImageStyle = Krypton.Toolkit.PaletteImageStyle.Inherit
        Me.kryptonBreadCrumb2.TabIndex = 1
        Me.buttonSpecAny1.KryptonContextMenu = Me.kryptonContextMenu1
        Me.buttonSpecAny1.ShowDrop = True
        Me.buttonSpecAny1.Style = Krypton.Toolkit.PaletteButtonStyle.Standalone
        Me.buttonSpecAny1.ToolTipStyle = Krypton.Toolkit.LabelStyle.ToolTip
        Me.buttonSpecAny1.Type = Krypton.Toolkit.PaletteButtonSpecStyle.Undo
        Me.buttonSpecAny1.UniqueName = "DD50F0F9917A4145DD50F0F9917A4145"
        Me.kryptonBreadCrumbItem83.Items.AddRange(New Krypton.Toolkit.KryptonBreadCrumbItem() { Me.kryptonBreadCrumbItem84, Me.kryptonBreadCrumbItem102})
        Me.kryptonBreadCrumbItem83.ShortText = "Animals"
        Me.kryptonBreadCrumbItem84.Items.AddRange(New Krypton.Toolkit.KryptonBreadCrumbItem() { Me.kryptonBreadCrumbItem85, Me.kryptonBreadCrumbItem89, Me.kryptonBreadCrumbItem93, Me.kryptonBreadCrumbItem97})
        Me.kryptonBreadCrumbItem84.ShortText = "Vertebrates"
        Me.kryptonBreadCrumbItem85.Items.AddRange(New Krypton.Toolkit.KryptonBreadCrumbItem() { Me.kryptonBreadCrumbItem86, Me.kryptonBreadCrumbItem87, Me.kryptonBreadCrumbItem88})
        Me.kryptonBreadCrumbItem85.ShortText = "Fish"
        Me.kryptonBreadCrumbItem86.ShortText = "Shark"
        Me.kryptonBreadCrumbItem87.ShortText = "Seahorse"
        Me.kryptonBreadCrumbItem88.ShortText = "Salmon"
        Me.kryptonBreadCrumbItem89.Items.AddRange(New Krypton.Toolkit.KryptonBreadCrumbItem() { Me.kryptonBreadCrumbItem90, Me.kryptonBreadCrumbItem91, Me.kryptonBreadCrumbItem92})
        Me.kryptonBreadCrumbItem89.ShortText = "Reptiles"
        Me.kryptonBreadCrumbItem90.ShortText = "Python"
        Me.kryptonBreadCrumbItem91.ShortText = "Chameleon"
        Me.kryptonBreadCrumbItem92.ShortText = "Crocodile"
        Me.kryptonBreadCrumbItem93.Items.AddRange(New Krypton.Toolkit.KryptonBreadCrumbItem() { Me.kryptonBreadCrumbItem94, Me.kryptonBreadCrumbItem95, Me.kryptonBreadCrumbItem96})
        Me.kryptonBreadCrumbItem93.ShortText = "Marsupials"
        Me.kryptonBreadCrumbItem94.ShortText = "Wombat"
        Me.kryptonBreadCrumbItem95.ShortText = "Koala"
        Me.kryptonBreadCrumbItem96.ShortText = "Kangaroo"
        Me.kryptonBreadCrumbItem97.Items.AddRange(New Krypton.Toolkit.KryptonBreadCrumbItem() { Me.kryptonBreadCrumbItem98, Me.kryptonBreadCrumbItem99, Me.kryptonBreadCrumbItem100, Me.kryptonBreadCrumbItem101})
        Me.kryptonBreadCrumbItem97.ShortText = "Primates"
        Me.kryptonBreadCrumbItem98.ShortText = "Monkey"
        Me.kryptonBreadCrumbItem99.ShortText = "Gorilla"
        Me.kryptonBreadCrumbItem100.ShortText = "Chimpanzee"
        Me.kryptonBreadCrumbItem101.ShortText = "Baboon"
        Me.kryptonBreadCrumbItem102.Items.AddRange(New Krypton.Toolkit.KryptonBreadCrumbItem() { Me.kryptonBreadCrumbItem103, Me.kryptonBreadCrumbItem107, Me.kryptonBreadCrumbItem111, Me.kryptonBreadCrumbItem115})
        Me.kryptonBreadCrumbItem102.ShortText = "Invertebrates"
        Me.kryptonBreadCrumbItem103.Items.AddRange(New Krypton.Toolkit.KryptonBreadCrumbItem() { Me.kryptonBreadCrumbItem104, Me.kryptonBreadCrumbItem105, Me.kryptonBreadCrumbItem106})
        Me.kryptonBreadCrumbItem103.ShortText = "Mollusks"
        Me.kryptonBreadCrumbItem104.ShortText = "Slug"
        Me.kryptonBreadCrumbItem105.ShortText = "Snail"
        Me.kryptonBreadCrumbItem106.ShortText = "Squid"
        Me.kryptonBreadCrumbItem107.Items.AddRange(New Krypton.Toolkit.KryptonBreadCrumbItem() { Me.kryptonBreadCrumbItem108, Me.kryptonBreadCrumbItem109, Me.kryptonBreadCrumbItem110})
        Me.kryptonBreadCrumbItem107.ShortText = "Crustaceans"
        Me.kryptonBreadCrumbItem108.ShortText = "Crab"
        Me.kryptonBreadCrumbItem109.ShortText = "Lobster"
        Me.kryptonBreadCrumbItem110.ShortText = "Barnacle"
        Me.kryptonBreadCrumbItem111.Items.AddRange(New Krypton.Toolkit.KryptonBreadCrumbItem() { Me.kryptonBreadCrumbItem112, Me.kryptonBreadCrumbItem113, Me.kryptonBreadCrumbItem114})
        Me.kryptonBreadCrumbItem111.ShortText = "Arachnids"
        Me.kryptonBreadCrumbItem112.ShortText = "Scorpion"
        Me.kryptonBreadCrumbItem113.ShortText = "Spider"
        Me.kryptonBreadCrumbItem114.ShortText = "Tick"
        Me.kryptonBreadCrumbItem115.Items.AddRange(New Krypton.Toolkit.KryptonBreadCrumbItem() { Me.kryptonBreadCrumbItem116, Me.kryptonBreadCrumbItem117, Me.kryptonBreadCrumbItem118})
        Me.kryptonBreadCrumbItem115.ShortText = "Insects"
        Me.kryptonBreadCrumbItem116.ShortText = "Butterfly"
        Me.kryptonBreadCrumbItem117.ShortText = "Fly"
        Me.kryptonBreadCrumbItem118.ShortText = "Moth"
        Me.kryptonBreadCrumbItem119.Items.AddRange(New Krypton.Toolkit.KryptonBreadCrumbItem() { Me.kryptonBreadCrumbItem120})
        Me.kryptonBreadCrumbItem119.ShortText = "Plants"
        Me.kryptonBreadCrumbItem120.Items.AddRange(New Krypton.Toolkit.KryptonBreadCrumbItem() { Me.kryptonBreadCrumbItem121, Me.kryptonBreadCrumbItem122, Me.kryptonBreadCrumbItem123})
        Me.kryptonBreadCrumbItem120.ShortText = "Seedless"
        Me.kryptonBreadCrumbItem121.ShortText = "Fern"
        Me.kryptonBreadCrumbItem122.ShortText = "Horsetail"
        Me.kryptonBreadCrumbItem123.ShortText = "Club Moss"
        Me.kryptonBreadCrumb1.AutoSize = False
        Me.kryptonBreadCrumb1.ControlBorderStyle = Krypton.Toolkit.PaletteBorderStyle.ControlClient
        Me.kryptonBreadCrumb1.Location = New System.Drawing.Point(20, 27)
        Me.kryptonBreadCrumb1.Name = "kryptonBreadCrumb1"
        Me.kryptonBreadCrumb1.PaletteMode = Krypton.Toolkit.PaletteMode.ProfessionalSystem
        Me.kryptonBreadCrumb1.RootItem.Items.AddRange(New Krypton.Toolkit.KryptonBreadCrumbItem() { Me.kryptonBreadCrumbItem1, Me.kryptonBreadCrumbItem37})
        Me.kryptonBreadCrumb1.RootItem.ShortText = "Root"
        Me.kryptonBreadCrumb1.SelectedItem = Me.kryptonBreadCrumb1.RootItem
        Me.kryptonBreadCrumb1.Size = New System.Drawing.Size(402, 27)
        Me.kryptonBreadCrumb1.TabIndex = 0
        Me.kryptonBreadCrumbItem1.Items.AddRange(New Krypton.Toolkit.KryptonBreadCrumbItem() { Me.kryptonBreadCrumbItem2, Me.kryptonBreadCrumbItem20})
        Me.kryptonBreadCrumbItem1.ShortText = "Animals"
        Me.kryptonBreadCrumbItem2.Items.AddRange(New Krypton.Toolkit.KryptonBreadCrumbItem() { Me.kryptonBreadCrumbItem3, Me.kryptonBreadCrumbItem7, Me.kryptonBreadCrumbItem11, Me.kryptonBreadCrumbItem15})
        Me.kryptonBreadCrumbItem2.ShortText = "Vertebrates"
        Me.kryptonBreadCrumbItem3.Items.AddRange(New Krypton.Toolkit.KryptonBreadCrumbItem() { Me.kryptonBreadCrumbItem4, Me.kryptonBreadCrumbItem5, Me.kryptonBreadCrumbItem6})
        Me.kryptonBreadCrumbItem3.ShortText = "Fish"
        Me.kryptonBreadCrumbItem4.ShortText = "Shark"
        Me.kryptonBreadCrumbItem5.ShortText = "Seahorse"
        Me.kryptonBreadCrumbItem6.ShortText = "Salmon"
        Me.kryptonBreadCrumbItem7.Items.AddRange(New Krypton.Toolkit.KryptonBreadCrumbItem() { Me.kryptonBreadCrumbItem8, Me.kryptonBreadCrumbItem9, Me.kryptonBreadCrumbItem10})
        Me.kryptonBreadCrumbItem7.ShortText = "Reptiles"
        Me.kryptonBreadCrumbItem8.ShortText = "Python"
        Me.kryptonBreadCrumbItem9.ShortText = "Chameleon"
        Me.kryptonBreadCrumbItem10.ShortText = "Crocodile"
        Me.kryptonBreadCrumbItem11.Items.AddRange(New Krypton.Toolkit.KryptonBreadCrumbItem() { Me.kryptonBreadCrumbItem12, Me.kryptonBreadCrumbItem13, Me.kryptonBreadCrumbItem14})
        Me.kryptonBreadCrumbItem11.ShortText = "Marsupials"
        Me.kryptonBreadCrumbItem12.ShortText = "Wombat"
        Me.kryptonBreadCrumbItem13.ShortText = "Koala"
        Me.kryptonBreadCrumbItem14.ShortText = "Kangaroo"
        Me.kryptonBreadCrumbItem15.Items.AddRange(New Krypton.Toolkit.KryptonBreadCrumbItem() { Me.kryptonBreadCrumbItem16, Me.kryptonBreadCrumbItem17, Me.kryptonBreadCrumbItem18, Me.kryptonBreadCrumbItem19})
        Me.kryptonBreadCrumbItem15.ShortText = "Primates"
        Me.kryptonBreadCrumbItem16.ShortText = "Monkey"
        Me.kryptonBreadCrumbItem17.ShortText = "Gorilla"
        Me.kryptonBreadCrumbItem18.ShortText = "Chimpanzee"
        Me.kryptonBreadCrumbItem19.ShortText = "Baboon"
        Me.kryptonBreadCrumbItem20.Items.AddRange(New Krypton.Toolkit.KryptonBreadCrumbItem() { Me.kryptonBreadCrumbItem21, Me.kryptonBreadCrumbItem25, Me.kryptonBreadCrumbItem29, Me.kryptonBreadCrumbItem33})
        Me.kryptonBreadCrumbItem20.ShortText = "Invertebrates"
        Me.kryptonBreadCrumbItem21.Items.AddRange(New Krypton.Toolkit.KryptonBreadCrumbItem() { Me.kryptonBreadCrumbItem22, Me.kryptonBreadCrumbItem23, Me.kryptonBreadCrumbItem24})
        Me.kryptonBreadCrumbItem21.ShortText = "Mollusks"
        Me.kryptonBreadCrumbItem22.ShortText = "Slug"
        Me.kryptonBreadCrumbItem23.ShortText = "Snail"
        Me.kryptonBreadCrumbItem24.ShortText = "Squid"
        Me.kryptonBreadCrumbItem25.Items.AddRange(New Krypton.Toolkit.KryptonBreadCrumbItem() { Me.kryptonBreadCrumbItem26, Me.kryptonBreadCrumbItem27, Me.kryptonBreadCrumbItem28})
        Me.kryptonBreadCrumbItem25.ShortText = "Crustaceans"
        Me.kryptonBreadCrumbItem26.ShortText = "Crab"
        Me.kryptonBreadCrumbItem27.ShortText = "Lobster"
        Me.kryptonBreadCrumbItem28.ShortText = "Barnacle"
        Me.kryptonBreadCrumbItem29.Items.AddRange(New Krypton.Toolkit.KryptonBreadCrumbItem() { Me.kryptonBreadCrumbItem30, Me.kryptonBreadCrumbItem31, Me.kryptonBreadCrumbItem32})
        Me.kryptonBreadCrumbItem29.ShortText = "Arachnids"
        Me.kryptonBreadCrumbItem30.ShortText = "Scorpion"
        Me.kryptonBreadCrumbItem31.ShortText = "Spider"
        Me.kryptonBreadCrumbItem32.ShortText = "Tick"
        Me.kryptonBreadCrumbItem33.Items.AddRange(New Krypton.Toolkit.KryptonBreadCrumbItem() { Me.kryptonBreadCrumbItem34, Me.kryptonBreadCrumbItem35, Me.kryptonBreadCrumbItem36})
        Me.kryptonBreadCrumbItem33.ShortText = "Insects"
        Me.kryptonBreadCrumbItem34.ShortText = "Butterfly"
        Me.kryptonBreadCrumbItem35.ShortText = "Fly"
        Me.kryptonBreadCrumbItem36.ShortText = "Moth"
        Me.kryptonBreadCrumbItem37.Items.AddRange(New Krypton.Toolkit.KryptonBreadCrumbItem() { Me.kryptonBreadCrumbItem38})
        Me.kryptonBreadCrumbItem37.ShortText = "Plants"
        Me.kryptonBreadCrumbItem38.Items.AddRange(New Krypton.Toolkit.KryptonBreadCrumbItem() { Me.kryptonBreadCrumbItem39, Me.kryptonBreadCrumbItem40, Me.kryptonBreadCrumbItem41})
        Me.kryptonBreadCrumbItem38.ShortText = "Seedless"
        Me.kryptonBreadCrumbItem39.ShortText = "Fern"
        Me.kryptonBreadCrumbItem40.ShortText = "Horsetail"
        Me.kryptonBreadCrumbItem41.ShortText = "Club Moss"
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8F, 17F)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(775, 546)
        Me.Controls.Add(Me.groupBox2)
        Me.Controls.Add(Me.buttonClose)
        Me.Controls.Add(Me.groupBox4)
        Me.Controls.Add(Me.groupBox1)
        Me.Font = New System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.MaximizeBox = False
        Me.MinimizeBox = False
        Me.Name = "Form1"
        Me.Text = "KryptonBreadCrumb Examples"
        Me.groupBox1.ResumeLayout(False)
        Me.groupBox4.ResumeLayout(False)
        Me.groupBox2.ResumeLayout(False)
        CType(Me.kryptonBreadCrumb4, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.kryptonBreadCrumb3, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.kryptonBreadCrumb2, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.kryptonBreadCrumb1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
    End Sub

    Friend WithEvents kryptonBreadCrumb1 As Krypton.Toolkit.KryptonBreadCrumb
    Friend WithEvents groupBox1 As System.Windows.Forms.GroupBox
    Friend WithEvents kryptonBreadCrumb3 As Krypton.Toolkit.KryptonBreadCrumb
    Friend WithEvents kryptonBreadCrumb2 As Krypton.Toolkit.KryptonBreadCrumb
    Friend WithEvents buttonSpecAny1 As Krypton.Toolkit.ButtonSpecAny
    Friend WithEvents buttonSpecAny2 As Krypton.Toolkit.ButtonSpecAny
    Friend WithEvents kryptonContextMenu1 As Krypton.Toolkit.KryptonContextMenu
    Friend WithEvents kryptonContextMenuHeading1 As Krypton.Toolkit.KryptonContextMenuHeading
    Friend WithEvents kryptonContextMenuItems1 As Krypton.Toolkit.KryptonContextMenuItems
    Friend WithEvents menuSpider As Krypton.Toolkit.KryptonContextMenuItem
    Friend WithEvents menuKangeroo As Krypton.Toolkit.KryptonContextMenuItem
    Friend WithEvents menuFern As Krypton.Toolkit.KryptonContextMenuItem
    Friend WithEvents groupBox4 As System.Windows.Forms.GroupBox
    Friend WithEvents propertyGrid As System.Windows.Forms.PropertyGrid
    Friend WithEvents buttonClose As System.Windows.Forms.Button
    Friend WithEvents groupBox2 As System.Windows.Forms.GroupBox
    Friend WithEvents kryptonBreadCrumb4 As Krypton.Toolkit.KryptonBreadCrumb
    Friend WithEvents treeView1 As System.Windows.Forms.TreeView
    Friend WithEvents kryptonBreadCrumbItem1 As Krypton.Toolkit.KryptonBreadCrumbItem
    Friend WithEvents kryptonBreadCrumbItem2 As Krypton.Toolkit.KryptonBreadCrumbItem
    Friend WithEvents kryptonBreadCrumbItem3 As Krypton.Toolkit.KryptonBreadCrumbItem
    Friend WithEvents kryptonBreadCrumbItem4 As Krypton.Toolkit.KryptonBreadCrumbItem
    Friend WithEvents kryptonBreadCrumbItem5 As Krypton.Toolkit.KryptonBreadCrumbItem
    Friend WithEvents kryptonBreadCrumbItem6 As Krypton.Toolkit.KryptonBreadCrumbItem
    Friend WithEvents kryptonBreadCrumbItem7 As Krypton.Toolkit.KryptonBreadCrumbItem
    Friend WithEvents kryptonBreadCrumbItem8 As Krypton.Toolkit.KryptonBreadCrumbItem
    Friend WithEvents kryptonBreadCrumbItem9 As Krypton.Toolkit.KryptonBreadCrumbItem
    Friend WithEvents kryptonBreadCrumbItem10 As Krypton.Toolkit.KryptonBreadCrumbItem
    Friend WithEvents kryptonBreadCrumbItem11 As Krypton.Toolkit.KryptonBreadCrumbItem
    Friend WithEvents kryptonBreadCrumbItem12 As Krypton.Toolkit.KryptonBreadCrumbItem
    Friend WithEvents kryptonBreadCrumbItem13 As Krypton.Toolkit.KryptonBreadCrumbItem
    Friend WithEvents kryptonBreadCrumbItem14 As Krypton.Toolkit.KryptonBreadCrumbItem
    Friend WithEvents kryptonBreadCrumbItem15 As Krypton.Toolkit.KryptonBreadCrumbItem
    Friend WithEvents kryptonBreadCrumbItem16 As Krypton.Toolkit.KryptonBreadCrumbItem
    Friend WithEvents kryptonBreadCrumbItem17 As Krypton.Toolkit.KryptonBreadCrumbItem
    Friend WithEvents kryptonBreadCrumbItem18 As Krypton.Toolkit.KryptonBreadCrumbItem
    Friend WithEvents kryptonBreadCrumbItem19 As Krypton.Toolkit.KryptonBreadCrumbItem
    Friend WithEvents kryptonBreadCrumbItem20 As Krypton.Toolkit.KryptonBreadCrumbItem
    Friend WithEvents kryptonBreadCrumbItem21 As Krypton.Toolkit.KryptonBreadCrumbItem
    Friend WithEvents kryptonBreadCrumbItem22 As Krypton.Toolkit.KryptonBreadCrumbItem
    Friend WithEvents kryptonBreadCrumbItem23 As Krypton.Toolkit.KryptonBreadCrumbItem
    Friend WithEvents kryptonBreadCrumbItem24 As Krypton.Toolkit.KryptonBreadCrumbItem
    Friend WithEvents kryptonBreadCrumbItem25 As Krypton.Toolkit.KryptonBreadCrumbItem
    Friend WithEvents kryptonBreadCrumbItem26 As Krypton.Toolkit.KryptonBreadCrumbItem
    Friend WithEvents kryptonBreadCrumbItem27 As Krypton.Toolkit.KryptonBreadCrumbItem
    Friend WithEvents kryptonBreadCrumbItem28 As Krypton.Toolkit.KryptonBreadCrumbItem
    Friend WithEvents kryptonBreadCrumbItem29 As Krypton.Toolkit.KryptonBreadCrumbItem
    Friend WithEvents kryptonBreadCrumbItem30 As Krypton.Toolkit.KryptonBreadCrumbItem
    Friend WithEvents kryptonBreadCrumbItem31 As Krypton.Toolkit.KryptonBreadCrumbItem
    Friend WithEvents kryptonBreadCrumbItem32 As Krypton.Toolkit.KryptonBreadCrumbItem
    Friend WithEvents kryptonBreadCrumbItem33 As Krypton.Toolkit.KryptonBreadCrumbItem
    Friend WithEvents kryptonBreadCrumbItem34 As Krypton.Toolkit.KryptonBreadCrumbItem
    Friend WithEvents kryptonBreadCrumbItem35 As Krypton.Toolkit.KryptonBreadCrumbItem
    Friend WithEvents kryptonBreadCrumbItem36 As Krypton.Toolkit.KryptonBreadCrumbItem
    Friend WithEvents kryptonBreadCrumbItem37 As Krypton.Toolkit.KryptonBreadCrumbItem
    Friend WithEvents kryptonBreadCrumbItem38 As Krypton.Toolkit.KryptonBreadCrumbItem
    Friend WithEvents kryptonBreadCrumbItem39 As Krypton.Toolkit.KryptonBreadCrumbItem
    Friend WithEvents kryptonBreadCrumbItem40 As Krypton.Toolkit.KryptonBreadCrumbItem
    Friend WithEvents kryptonBreadCrumbItem41 As Krypton.Toolkit.KryptonBreadCrumbItem
    Friend WithEvents kryptonBreadCrumbItem42 As Krypton.Toolkit.KryptonBreadCrumbItem
    Friend WithEvents kryptonBreadCrumbItem43 As Krypton.Toolkit.KryptonBreadCrumbItem
    Friend WithEvents kryptonBreadCrumbItem44 As Krypton.Toolkit.KryptonBreadCrumbItem
    Friend WithEvents kryptonBreadCrumbItem45 As Krypton.Toolkit.KryptonBreadCrumbItem
    Friend WithEvents kryptonBreadCrumbItem46 As Krypton.Toolkit.KryptonBreadCrumbItem
    Friend WithEvents kryptonBreadCrumbItem47 As Krypton.Toolkit.KryptonBreadCrumbItem
    Friend WithEvents kryptonBreadCrumbItem48 As Krypton.Toolkit.KryptonBreadCrumbItem
    Friend WithEvents kryptonBreadCrumbItem49 As Krypton.Toolkit.KryptonBreadCrumbItem
    Friend WithEvents kryptonBreadCrumbItem50 As Krypton.Toolkit.KryptonBreadCrumbItem
    Friend WithEvents kryptonBreadCrumbItem51 As Krypton.Toolkit.KryptonBreadCrumbItem
    Friend WithEvents kryptonBreadCrumbItem52 As Krypton.Toolkit.KryptonBreadCrumbItem
    Friend WithEvents kryptonBreadCrumbItem53 As Krypton.Toolkit.KryptonBreadCrumbItem
    Friend WithEvents kryptonBreadCrumbItem54 As Krypton.Toolkit.KryptonBreadCrumbItem
    Friend WithEvents kryptonBreadCrumbItem55 As Krypton.Toolkit.KryptonBreadCrumbItem
    Friend WithEvents kryptonBreadCrumbItem56 As Krypton.Toolkit.KryptonBreadCrumbItem
    Friend WithEvents kryptonBreadCrumbItem57 As Krypton.Toolkit.KryptonBreadCrumbItem
    Friend WithEvents kryptonBreadCrumbItem58 As Krypton.Toolkit.KryptonBreadCrumbItem
    Friend WithEvents kryptonBreadCrumbItem59 As Krypton.Toolkit.KryptonBreadCrumbItem
    Friend WithEvents kryptonBreadCrumbItem60 As Krypton.Toolkit.KryptonBreadCrumbItem
    Friend WithEvents kryptonBreadCrumbItem61 As Krypton.Toolkit.KryptonBreadCrumbItem
    Friend WithEvents kryptonBreadCrumbItem62 As Krypton.Toolkit.KryptonBreadCrumbItem
    Friend WithEvents kryptonBreadCrumbItem63 As Krypton.Toolkit.KryptonBreadCrumbItem
    Friend WithEvents kryptonBreadCrumbItem64 As Krypton.Toolkit.KryptonBreadCrumbItem
    Friend WithEvents kryptonBreadCrumbItem65 As Krypton.Toolkit.KryptonBreadCrumbItem
    Friend WithEvents kryptonBreadCrumbItem66 As Krypton.Toolkit.KryptonBreadCrumbItem
    Friend WithEvents kryptonBreadCrumbItem67 As Krypton.Toolkit.KryptonBreadCrumbItem
    Friend WithEvents kryptonBreadCrumbItem68 As Krypton.Toolkit.KryptonBreadCrumbItem
    Friend WithEvents kryptonBreadCrumbItem69 As Krypton.Toolkit.KryptonBreadCrumbItem
    Friend WithEvents kryptonBreadCrumbItem70 As Krypton.Toolkit.KryptonBreadCrumbItem
    Friend WithEvents kryptonBreadCrumbItem71 As Krypton.Toolkit.KryptonBreadCrumbItem
    Friend WithEvents kryptonBreadCrumbItem72 As Krypton.Toolkit.KryptonBreadCrumbItem
    Friend WithEvents kryptonBreadCrumbItem73 As Krypton.Toolkit.KryptonBreadCrumbItem
    Friend WithEvents kryptonBreadCrumbItem74 As Krypton.Toolkit.KryptonBreadCrumbItem
    Friend WithEvents kryptonBreadCrumbItem75 As Krypton.Toolkit.KryptonBreadCrumbItem
    Friend WithEvents kryptonBreadCrumbItem76 As Krypton.Toolkit.KryptonBreadCrumbItem
    Friend WithEvents kryptonBreadCrumbItem77 As Krypton.Toolkit.KryptonBreadCrumbItem
    Friend WithEvents kryptonBreadCrumbItem78 As Krypton.Toolkit.KryptonBreadCrumbItem
    Friend WithEvents kryptonBreadCrumbItem79 As Krypton.Toolkit.KryptonBreadCrumbItem
    Friend WithEvents kryptonBreadCrumbItem80 As Krypton.Toolkit.KryptonBreadCrumbItem
    Friend WithEvents kryptonBreadCrumbItem81 As Krypton.Toolkit.KryptonBreadCrumbItem
    Friend WithEvents kryptonBreadCrumbItem82 As Krypton.Toolkit.KryptonBreadCrumbItem
    Friend WithEvents kryptonBreadCrumbItem83 As Krypton.Toolkit.KryptonBreadCrumbItem
    Friend WithEvents kryptonBreadCrumbItem84 As Krypton.Toolkit.KryptonBreadCrumbItem
    Friend WithEvents kryptonBreadCrumbItem85 As Krypton.Toolkit.KryptonBreadCrumbItem
    Friend WithEvents kryptonBreadCrumbItem86 As Krypton.Toolkit.KryptonBreadCrumbItem
    Friend WithEvents kryptonBreadCrumbItem87 As Krypton.Toolkit.KryptonBreadCrumbItem
    Friend WithEvents kryptonBreadCrumbItem88 As Krypton.Toolkit.KryptonBreadCrumbItem
    Friend WithEvents kryptonBreadCrumbItem89 As Krypton.Toolkit.KryptonBreadCrumbItem
    Friend WithEvents kryptonBreadCrumbItem90 As Krypton.Toolkit.KryptonBreadCrumbItem
    Friend WithEvents kryptonBreadCrumbItem91 As Krypton.Toolkit.KryptonBreadCrumbItem
    Friend WithEvents kryptonBreadCrumbItem92 As Krypton.Toolkit.KryptonBreadCrumbItem
    Friend WithEvents kryptonBreadCrumbItem93 As Krypton.Toolkit.KryptonBreadCrumbItem
    Friend WithEvents kryptonBreadCrumbItem94 As Krypton.Toolkit.KryptonBreadCrumbItem
    Friend WithEvents kryptonBreadCrumbItem95 As Krypton.Toolkit.KryptonBreadCrumbItem
    Friend WithEvents kryptonBreadCrumbItem96 As Krypton.Toolkit.KryptonBreadCrumbItem
    Friend WithEvents kryptonBreadCrumbItem97 As Krypton.Toolkit.KryptonBreadCrumbItem
    Friend WithEvents kryptonBreadCrumbItem98 As Krypton.Toolkit.KryptonBreadCrumbItem
    Friend WithEvents kryptonBreadCrumbItem99 As Krypton.Toolkit.KryptonBreadCrumbItem
    Friend WithEvents kryptonBreadCrumbItem100 As Krypton.Toolkit.KryptonBreadCrumbItem
    Friend WithEvents kryptonBreadCrumbItem101 As Krypton.Toolkit.KryptonBreadCrumbItem
    Friend WithEvents kryptonBreadCrumbItem102 As Krypton.Toolkit.KryptonBreadCrumbItem
    Friend WithEvents kryptonBreadCrumbItem103 As Krypton.Toolkit.KryptonBreadCrumbItem
    Friend WithEvents kryptonBreadCrumbItem104 As Krypton.Toolkit.KryptonBreadCrumbItem
    Friend WithEvents kryptonBreadCrumbItem105 As Krypton.Toolkit.KryptonBreadCrumbItem
    Friend WithEvents kryptonBreadCrumbItem106 As Krypton.Toolkit.KryptonBreadCrumbItem
    Friend WithEvents kryptonBreadCrumbItem107 As Krypton.Toolkit.KryptonBreadCrumbItem
    Friend WithEvents kryptonBreadCrumbItem108 As Krypton.Toolkit.KryptonBreadCrumbItem
    Friend WithEvents kryptonBreadCrumbItem109 As Krypton.Toolkit.KryptonBreadCrumbItem
    Friend WithEvents kryptonBreadCrumbItem110 As Krypton.Toolkit.KryptonBreadCrumbItem
    Friend WithEvents kryptonBreadCrumbItem111 As Krypton.Toolkit.KryptonBreadCrumbItem
    Friend WithEvents kryptonBreadCrumbItem112 As Krypton.Toolkit.KryptonBreadCrumbItem
    Friend WithEvents kryptonBreadCrumbItem113 As Krypton.Toolkit.KryptonBreadCrumbItem
    Friend WithEvents kryptonBreadCrumbItem114 As Krypton.Toolkit.KryptonBreadCrumbItem
    Friend WithEvents kryptonBreadCrumbItem115 As Krypton.Toolkit.KryptonBreadCrumbItem
    Friend WithEvents kryptonBreadCrumbItem116 As Krypton.Toolkit.KryptonBreadCrumbItem
    Friend WithEvents kryptonBreadCrumbItem117 As Krypton.Toolkit.KryptonBreadCrumbItem
    Friend WithEvents kryptonBreadCrumbItem118 As Krypton.Toolkit.KryptonBreadCrumbItem
    Friend WithEvents kryptonBreadCrumbItem119 As Krypton.Toolkit.KryptonBreadCrumbItem
    Friend WithEvents kryptonBreadCrumbItem120 As Krypton.Toolkit.KryptonBreadCrumbItem
    Friend WithEvents kryptonBreadCrumbItem121 As Krypton.Toolkit.KryptonBreadCrumbItem
    Friend WithEvents kryptonBreadCrumbItem122 As Krypton.Toolkit.KryptonBreadCrumbItem
    Friend WithEvents kryptonBreadCrumbItem123 As Krypton.Toolkit.KryptonBreadCrumbItem
    Friend WithEvents kryptonBreadCrumbItem124 As Krypton.Toolkit.KryptonBreadCrumbItem
    Friend WithEvents kryptonBreadCrumbItem125 As Krypton.Toolkit.KryptonBreadCrumbItem
    Friend WithEvents kryptonBreadCrumbItem126 As Krypton.Toolkit.KryptonBreadCrumbItem
    Friend WithEvents kryptonBreadCrumbItem127 As Krypton.Toolkit.KryptonBreadCrumbItem
    Friend WithEvents kryptonBreadCrumbItem128 As Krypton.Toolkit.KryptonBreadCrumbItem
    Friend WithEvents kryptonBreadCrumbItem129 As Krypton.Toolkit.KryptonBreadCrumbItem
    Friend WithEvents kryptonBreadCrumbItem130 As Krypton.Toolkit.KryptonBreadCrumbItem
    Friend WithEvents kryptonBreadCrumbItem131 As Krypton.Toolkit.KryptonBreadCrumbItem
    Friend WithEvents kryptonBreadCrumbItem132 As Krypton.Toolkit.KryptonBreadCrumbItem
    Friend WithEvents kryptonBreadCrumbItem133 As Krypton.Toolkit.KryptonBreadCrumbItem
    Friend WithEvents kryptonBreadCrumbItem134 As Krypton.Toolkit.KryptonBreadCrumbItem
    Friend WithEvents kryptonBreadCrumbItem135 As Krypton.Toolkit.KryptonBreadCrumbItem
    Friend WithEvents kryptonBreadCrumbItem136 As Krypton.Toolkit.KryptonBreadCrumbItem
    Friend WithEvents kryptonBreadCrumbItem137 As Krypton.Toolkit.KryptonBreadCrumbItem
    Friend WithEvents kryptonBreadCrumbItem138 As Krypton.Toolkit.KryptonBreadCrumbItem
    Friend WithEvents kryptonBreadCrumbItem139 As Krypton.Toolkit.KryptonBreadCrumbItem
    Friend WithEvents kryptonBreadCrumbItem140 As Krypton.Toolkit.KryptonBreadCrumbItem
    Friend WithEvents kryptonBreadCrumbItem141 As Krypton.Toolkit.KryptonBreadCrumbItem
    Friend WithEvents kryptonBreadCrumbItem142 As Krypton.Toolkit.KryptonBreadCrumbItem
    Friend WithEvents kryptonBreadCrumbItem143 As Krypton.Toolkit.KryptonBreadCrumbItem
End Class
