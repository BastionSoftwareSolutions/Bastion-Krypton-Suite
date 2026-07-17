' VB.NET twin of Source\Krypton Workspace Examples\Advanced Page Drag + Drop\Form1.Designer.cs (Bastion Phase 4c).
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
        Dim treeNode1 As System.Windows.Forms.TreeNode = New System.Windows.Forms.TreeNode("London", 0, 0)
        Dim treeNode2 As System.Windows.Forms.TreeNode = New System.Windows.Forms.TreeNode("Paris", 1, 1)
        Dim treeNode3 As System.Windows.Forms.TreeNode = New System.Windows.Forms.TreeNode("Madrid", 2, 2)
        Dim treeNode4 As System.Windows.Forms.TreeNode = New System.Windows.Forms.TreeNode("Lisbon", 3, 3)
        Dim treeNode5 As System.Windows.Forms.TreeNode = New System.Windows.Forms.TreeNode("Rome", 4, 4)
        Dim treeNode6 As System.Windows.Forms.TreeNode = New System.Windows.Forms.TreeNode("Berlin", 5, 5)
        Dim treeNode7 As System.Windows.Forms.TreeNode = New System.Windows.Forms.TreeNode("Vienna", 6, 6)
        Me.kryptonWorkspace = New Krypton.Workspace.KryptonWorkspace()
        Me.imageList = New System.Windows.Forms.ImageList(Me.components)
        Me.dragTreeView = New AdvancedPageDragAndDrop.PageDragTreeView()
        Me.labelTitle = New System.Windows.Forms.Label()
        Me.labelTreeView = New System.Windows.Forms.Label()
        Me.groupBoxDragFeedback = New System.Windows.Forms.GroupBox()
        Me.radioRounded = New System.Windows.Forms.RadioButton()
        Me.radioSquares = New System.Windows.Forms.RadioButton()
        Me.radioBlock = New System.Windows.Forms.RadioButton()
        Me.labelWorkspaces = New System.Windows.Forms.Label()
        Me.buttonClose = New System.Windows.Forms.Button()
        Me.labelNavigators = New System.Windows.Forms.Label()
        Me.kryptonNavigator = New Krypton.Navigator.KryptonNavigator()
        Me.kryptonManager1 = New Krypton.Toolkit.KryptonManager(Me.components)
        CType(Me.kryptonWorkspace, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.groupBoxDragFeedback.SuspendLayout()
        CType(Me.kryptonNavigator, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.kryptonNavigator.SuspendLayout()
        Me.SuspendLayout()
        Me.kryptonWorkspace.ActivePage = Nothing
        Me.kryptonWorkspace.CompactFlags = CType((((Krypton.Workspace.CompactFlags.RemoveEmptyCells Or Krypton.Workspace.CompactFlags.RemoveEmptySequences) Or Krypton.Workspace.CompactFlags.PromoteLeafs) Or Krypton.Workspace.CompactFlags.AtLeastOneVisibleCell), Krypton.Workspace.CompactFlags)
        Me.kryptonWorkspace.ContainerBackStyle = Krypton.Toolkit.PaletteBackStyle.PanelClient
        Me.kryptonWorkspace.Location = New System.Drawing.Point(466, 74)
        Me.kryptonWorkspace.Name = "kryptonWorkspace"
        Me.kryptonWorkspace.Root.Orientation = System.Windows.Forms.Orientation.Vertical
        Me.kryptonWorkspace.Root.UniqueName = "18D7B2B1649347B418D7B2B1649347B4"
        Me.kryptonWorkspace.Root.WorkspaceControl = Me.kryptonWorkspace
        Me.kryptonWorkspace.SeparatorStyle = Krypton.Toolkit.SeparatorStyle.LowProfile
        Me.kryptonWorkspace.ShowMaximizeButton = False
        Me.kryptonWorkspace.Size = New System.Drawing.Size(333, 250)
        Me.kryptonWorkspace.SplitterWidth = 5
        Me.kryptonWorkspace.TabIndex = 2
        Me.kryptonWorkspace.TabStop = True
        Me.imageList.ImageStream = CType(resources.GetObject("imageList.ImageStream"), System.Windows.Forms.ImageListStreamer)
        Me.imageList.TransparentColor = System.Drawing.Color.Transparent
        Me.imageList.Images.SetKeyName(0, "flag_great_britain.png")
        Me.imageList.Images.SetKeyName(1, "flag_france.png")
        Me.imageList.Images.SetKeyName(2, "flag_spain.png")
        Me.imageList.Images.SetKeyName(3, "flag_portugal.png")
        Me.imageList.Images.SetKeyName(4, "flag_italy.png")
        Me.imageList.Images.SetKeyName(5, "flag_germany.png")
        Me.imageList.Images.SetKeyName(6, "flag_austria.png")
        Me.imageList.Images.SetKeyName(7, "flag_australia.png")
        Me.imageList.Images.SetKeyName(8, "flag_cyprus.png")
        Me.imageList.Images.SetKeyName(9, "flag_ireland.png")
        Me.imageList.Images.SetKeyName(10, "flag_norway.png")
        Me.imageList.Images.SetKeyName(11, "flag_hungary.png")
        Me.imageList.Images.SetKeyName(12, "flag_japan.png")
        Me.dragTreeView.ImageIndex = 0
        Me.dragTreeView.ImageList = Me.imageList
        Me.dragTreeView.Location = New System.Drawing.Point(13, 74)
        Me.dragTreeView.Name = "dragTreeView"
        treeNode1.ImageIndex = 0
        treeNode1.Name = "nodeLondon"
        treeNode1.SelectedImageIndex = 0
        treeNode1.Tag = "0"
        treeNode1.Text = "London"
        treeNode2.ImageIndex = 1
        treeNode2.Name = "nodeParis"
        treeNode2.SelectedImageIndex = 1
        treeNode2.Tag = "1"
        treeNode2.Text = "Paris"
        treeNode3.ImageIndex = 2
        treeNode3.Name = "nodeMadrid"
        treeNode3.SelectedImageIndex = 2
        treeNode3.Tag = "2"
        treeNode3.Text = "Madrid"
        treeNode4.ImageIndex = 3
        treeNode4.Name = "modeLisbon"
        treeNode4.SelectedImageIndex = 3
        treeNode4.Tag = "3"
        treeNode4.Text = "Lisbon"
        treeNode5.ImageIndex = 4
        treeNode5.Name = "nodeRome"
        treeNode5.SelectedImageIndex = 4
        treeNode5.Tag = "4"
        treeNode5.Text = "Rome"
        treeNode6.ImageIndex = 5
        treeNode6.Name = "nodeBerlin"
        treeNode6.SelectedImageIndex = 5
        treeNode6.Tag = "5"
        treeNode6.Text = "Berlin"
        treeNode7.ImageIndex = 6
        treeNode7.Name = "nodeVienna"
        treeNode7.SelectedImageIndex = 6
        treeNode7.Tag = "6"
        treeNode7.Text = "Vienna"
        Me.dragTreeView.Nodes.AddRange(New System.Windows.Forms.TreeNode() { treeNode1, treeNode2, treeNode3, treeNode4, treeNode5, treeNode6, treeNode7})
        Me.dragTreeView.SelectedImageIndex = 0
        Me.dragTreeView.Size = New System.Drawing.Size(134, 250)
        Me.dragTreeView.TabIndex = 1
        Me.labelTitle.AutoSize = True
        Me.labelTitle.Font = New System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.labelTitle.Location = New System.Drawing.Point(12, 13)
        Me.labelTitle.Name = "labelTitle"
        Me.labelTitle.Size = New System.Drawing.Size(661, 19)
        Me.labelTitle.TabIndex = 3
        Me.labelTitle.Text = "Try dragging TreeView nodes to the Navigator/Workspace and then back again." & vbCrLf
        Me.labelTreeView.AutoSize = True
        Me.labelTreeView.Font = New System.Drawing.Font("Tahoma", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.labelTreeView.Location = New System.Drawing.Point(13, 50)
        Me.labelTreeView.Name = "labelTreeView"
        Me.labelTreeView.Size = New System.Drawing.Size(79, 18)
        Me.labelTreeView.TabIndex = 4
        Me.labelTreeView.Text = "TreeView"
        Me.groupBoxDragFeedback.Controls.Add(Me.radioRounded)
        Me.groupBoxDragFeedback.Controls.Add(Me.radioSquares)
        Me.groupBoxDragFeedback.Controls.Add(Me.radioBlock)
        Me.groupBoxDragFeedback.Location = New System.Drawing.Point(13, 339)
        Me.groupBoxDragFeedback.Name = "groupBoxDragFeedback"
        Me.groupBoxDragFeedback.Size = New System.Drawing.Size(248, 52)
        Me.groupBoxDragFeedback.TabIndex = 8
        Me.groupBoxDragFeedback.TabStop = False
        Me.groupBoxDragFeedback.Text = "Drag Feedback"
        Me.radioRounded.AutoSize = True
        Me.radioRounded.Checked = True
        Me.radioRounded.Location = New System.Drawing.Point(162, 22)
        Me.radioRounded.Name = "radioRounded"
        Me.radioRounded.Size = New System.Drawing.Size(68, 17)
        Me.radioRounded.TabIndex = 2
        Me.radioRounded.TabStop = True
        Me.radioRounded.Text = "Rounded"
        Me.radioRounded.UseVisualStyleBackColor = True
        Me.radioSquares.AutoSize = True
        Me.radioSquares.Location = New System.Drawing.Point(83, 22)
        Me.radioSquares.Name = "radioSquares"
        Me.radioSquares.Size = New System.Drawing.Size(64, 17)
        Me.radioSquares.TabIndex = 1
        Me.radioSquares.Text = "Squares"
        Me.radioSquares.UseVisualStyleBackColor = True
        Me.radioBlock.AutoSize = True
        Me.radioBlock.Location = New System.Drawing.Point(18, 22)
        Me.radioBlock.Name = "radioBlock"
        Me.radioBlock.Size = New System.Drawing.Size(49, 17)
        Me.radioBlock.TabIndex = 0
        Me.radioBlock.Text = "Block"
        Me.radioBlock.UseVisualStyleBackColor = True
        Me.labelWorkspaces.AutoSize = True
        Me.labelWorkspaces.Font = New System.Drawing.Font("Tahoma", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.labelWorkspaces.Location = New System.Drawing.Point(463, 50)
        Me.labelWorkspaces.Name = "labelWorkspaces"
        Me.labelWorkspaces.Size = New System.Drawing.Size(91, 18)
        Me.labelWorkspaces.TabIndex = 9
        Me.labelWorkspaces.Text = "Workspace"
        Me.buttonClose.Location = New System.Drawing.Point(729, 339)
        Me.buttonClose.Name = "buttonClose"
        Me.buttonClose.Size = New System.Drawing.Size(70, 23)
        Me.buttonClose.TabIndex = 10
        Me.buttonClose.Text = "Close"
        Me.buttonClose.UseVisualStyleBackColor = True
        Me.labelNavigators.AutoSize = True
        Me.labelNavigators.Font = New System.Drawing.Font("Tahoma", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.labelNavigators.Location = New System.Drawing.Point(162, 50)
        Me.labelNavigators.Name = "labelNavigators"
        Me.labelNavigators.Size = New System.Drawing.Size(83, 18)
        Me.labelNavigators.TabIndex = 11
        Me.labelNavigators.Text = "Navigator"
        Me.kryptonNavigator.AllowPageDrag = True
        Me.kryptonNavigator.AllowTabFocus = False
        Me.kryptonNavigator.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowOnly
        Me.kryptonNavigator.Button.ButtonDisplayLogic = Krypton.Navigator.ButtonDisplayLogic.Context
        Me.kryptonNavigator.Button.CloseButtonAction = Krypton.Navigator.CloseButtonAction.RemovePageAndDispose
        Me.kryptonNavigator.Button.CloseButtonDisplay = Krypton.Navigator.ButtonDisplay.Hide
        Me.kryptonNavigator.Button.ContextButtonAction = Krypton.Navigator.ContextButtonAction.SelectPage
        Me.kryptonNavigator.Button.ContextButtonDisplay = Krypton.Navigator.ButtonDisplay.Hide
        Me.kryptonNavigator.Button.ContextMenuMapImage = Krypton.Navigator.MapKryptonPageImage.Small
        Me.kryptonNavigator.Button.ContextMenuMapText = Krypton.Navigator.MapKryptonPageText.TextTitle
        Me.kryptonNavigator.Button.NextButtonAction = Krypton.Navigator.DirectionButtonAction.ModeAppropriateAction
        Me.kryptonNavigator.Button.NextButtonDisplay = Krypton.Navigator.ButtonDisplay.Logic
        Me.kryptonNavigator.Button.PreviousButtonAction = Krypton.Navigator.DirectionButtonAction.ModeAppropriateAction
        Me.kryptonNavigator.Button.PreviousButtonDisplay = Krypton.Navigator.ButtonDisplay.Logic
        Me.kryptonNavigator.Group.GroupBackStyle = Krypton.Toolkit.PaletteBackStyle.ControlClient
        Me.kryptonNavigator.Group.GroupBorderStyle = Krypton.Toolkit.PaletteBorderStyle.ControlClient
        Me.kryptonNavigator.Header.HeaderPositionBar = Krypton.Toolkit.VisualOrientation.Top
        Me.kryptonNavigator.Header.HeaderPositionPrimary = Krypton.Toolkit.VisualOrientation.Top
        Me.kryptonNavigator.Header.HeaderPositionSecondary = Krypton.Toolkit.VisualOrientation.Bottom
        Me.kryptonNavigator.Header.HeaderStyleBar = Krypton.Toolkit.HeaderStyle.Secondary
        Me.kryptonNavigator.Header.HeaderStylePrimary = Krypton.Toolkit.HeaderStyle.Primary
        Me.kryptonNavigator.Header.HeaderStyleSecondary = Krypton.Toolkit.HeaderStyle.Secondary
        Me.kryptonNavigator.Location = New System.Drawing.Point(165, 74)
        Me.kryptonNavigator.Name = "kryptonNavigator"
        Me.kryptonNavigator.NavigatorMode = Krypton.Navigator.NavigatorMode.BarTabGroup
        Me.kryptonNavigator.PageBackStyle = Krypton.Toolkit.PaletteBackStyle.ControlClient
        Me.kryptonNavigator.Panel.PanelBackStyle = Krypton.Toolkit.PaletteBackStyle.PanelClient
        Me.kryptonNavigator.Size = New System.Drawing.Size(285, 250)
        Me.kryptonNavigator.TabIndex = 12
        Me.kryptonNavigator.Text = "kryptonNavigator1"
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6F, 13F)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(810, 399)
        Me.Controls.Add(Me.kryptonNavigator)
        Me.Controls.Add(Me.labelNavigators)
        Me.Controls.Add(Me.buttonClose)
        Me.Controls.Add(Me.labelWorkspaces)
        Me.Controls.Add(Me.groupBoxDragFeedback)
        Me.Controls.Add(Me.labelTreeView)
        Me.Controls.Add(Me.labelTitle)
        Me.Controls.Add(Me.kryptonWorkspace)
        Me.Controls.Add(Me.dragTreeView)
        Me.Font = New System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.MaximizeBox = False
        Me.MinimizeBox = False
        Me.Name = "Form1"
        Me.Text = "Advanced Page Drag and Drop"
        CType(Me.kryptonWorkspace, System.ComponentModel.ISupportInitialize).EndInit()
        Me.groupBoxDragFeedback.ResumeLayout(False)
        Me.groupBoxDragFeedback.PerformLayout()
        CType(Me.kryptonNavigator, System.ComponentModel.ISupportInitialize).EndInit()
        Me.kryptonNavigator.ResumeLayout(False)
        Me.ResumeLayout(False)
        Me.PerformLayout()
    End Sub

    Friend WithEvents dragTreeView As PageDragTreeView
    Friend WithEvents kryptonWorkspace As Krypton.Workspace.KryptonWorkspace
    Friend WithEvents kryptonNavigator As Krypton.Navigator.KryptonNavigator
    Friend WithEvents imageList As System.Windows.Forms.ImageList
    Friend WithEvents labelTitle As System.Windows.Forms.Label
    Friend WithEvents labelTreeView As System.Windows.Forms.Label
    Friend WithEvents groupBoxDragFeedback As System.Windows.Forms.GroupBox
    Friend WithEvents radioRounded As System.Windows.Forms.RadioButton
    Friend WithEvents radioSquares As System.Windows.Forms.RadioButton
    Friend WithEvents radioBlock As System.Windows.Forms.RadioButton
    Friend WithEvents labelWorkspaces As System.Windows.Forms.Label
    Friend WithEvents labelNavigators As System.Windows.Forms.Label
    Friend WithEvents buttonClose As System.Windows.Forms.Button
    Friend WithEvents kryptonManager1 As Krypton.Toolkit.KryptonManager
End Class
