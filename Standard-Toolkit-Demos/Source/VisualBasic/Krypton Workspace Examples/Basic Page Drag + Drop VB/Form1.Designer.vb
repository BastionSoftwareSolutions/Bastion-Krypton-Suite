' VB.NET twin of Source\Krypton Workspace Examples\Basic Page Drag + Drop\Form1.Designer.cs (Bastion Phase 4c).
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(Form1))
        Me.kryptonNavigator1 = New Krypton.Navigator.KryptonNavigator()
        Me.kryptonNavigator2 = New Krypton.Navigator.KryptonNavigator()
        Me.kryptonWorkspace2 = New Krypton.Workspace.KryptonWorkspace()
        Me.labelTitle = New System.Windows.Forms.Label()
        Me.groupBoxDragFeedback = New System.Windows.Forms.GroupBox()
        Me.radioRounded = New System.Windows.Forms.RadioButton()
        Me.radioSquares = New System.Windows.Forms.RadioButton()
        Me.radioBlock = New System.Windows.Forms.RadioButton()
        Me.buttonClose = New System.Windows.Forms.Button()
        Me.imageList = New System.Windows.Forms.ImageList()
        Me.kryptonWorkspace1 = New Krypton.Workspace.KryptonWorkspace()
        Me.labelNavigators = New System.Windows.Forms.Label()
        Me.labelWorkspaces = New System.Windows.Forms.Label()
        Me.kryptonManager1 = New Krypton.Toolkit.KryptonManager()
        CType(Me.kryptonNavigator1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.kryptonNavigator1.SuspendLayout()
        CType(Me.kryptonNavigator2, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.kryptonNavigator2.SuspendLayout()
        CType(Me.kryptonWorkspace2, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.groupBoxDragFeedback.SuspendLayout()
        CType(Me.kryptonWorkspace1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        Me.kryptonNavigator1.AllowPageDrag = True
        Me.kryptonNavigator1.AllowTabFocus = False
        Me.kryptonNavigator1.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowOnly
        Me.kryptonNavigator1.Button.ButtonDisplayLogic = Krypton.Navigator.ButtonDisplayLogic.Context
        Me.kryptonNavigator1.Button.CloseButtonAction = Krypton.Navigator.CloseButtonAction.RemovePageAndDispose
        Me.kryptonNavigator1.Button.CloseButtonDisplay = Krypton.Navigator.ButtonDisplay.Hide
        Me.kryptonNavigator1.Button.ContextButtonAction = Krypton.Navigator.ContextButtonAction.SelectPage
        Me.kryptonNavigator1.Button.ContextButtonDisplay = Krypton.Navigator.ButtonDisplay.Hide
        Me.kryptonNavigator1.Button.ContextMenuMapImage = Krypton.Navigator.MapKryptonPageImage.Small
        Me.kryptonNavigator1.Button.ContextMenuMapText = Krypton.Navigator.MapKryptonPageText.TextTitle
        Me.kryptonNavigator1.Button.NextButtonAction = Krypton.Navigator.DirectionButtonAction.ModeAppropriateAction
        Me.kryptonNavigator1.Button.NextButtonDisplay = Krypton.Navigator.ButtonDisplay.Logic
        Me.kryptonNavigator1.Button.PreviousButtonAction = Krypton.Navigator.DirectionButtonAction.ModeAppropriateAction
        Me.kryptonNavigator1.Button.PreviousButtonDisplay = Krypton.Navigator.ButtonDisplay.Logic
        Me.kryptonNavigator1.Group.GroupBackStyle = Krypton.Toolkit.PaletteBackStyle.ControlClient
        Me.kryptonNavigator1.Group.GroupBorderStyle = Krypton.Toolkit.PaletteBorderStyle.ControlClient
        Me.kryptonNavigator1.Header.HeaderPositionBar = Krypton.Toolkit.VisualOrientation.Top
        Me.kryptonNavigator1.Header.HeaderPositionPrimary = Krypton.Toolkit.VisualOrientation.Top
        Me.kryptonNavigator1.Header.HeaderPositionSecondary = Krypton.Toolkit.VisualOrientation.Bottom
        Me.kryptonNavigator1.Header.HeaderStyleBar = Krypton.Toolkit.HeaderStyle.Secondary
        Me.kryptonNavigator1.Header.HeaderStylePrimary = Krypton.Toolkit.HeaderStyle.Primary
        Me.kryptonNavigator1.Header.HeaderStyleSecondary = Krypton.Toolkit.HeaderStyle.Secondary
        Me.kryptonNavigator1.Location = New System.Drawing.Point(13, 70)
        Me.kryptonNavigator1.Name = "kryptonNavigator1"
        Me.kryptonNavigator1.NavigatorMode = Krypton.Navigator.NavigatorMode.BarTabGroup
        Me.kryptonNavigator1.PageBackStyle = Krypton.Toolkit.PaletteBackStyle.ControlClient
        Me.kryptonNavigator1.Panel.PanelBackStyle = Krypton.Toolkit.PaletteBackStyle.PanelClient
        Me.kryptonNavigator1.Size = New System.Drawing.Size(313, 202)
        Me.kryptonNavigator1.TabIndex = 2
        Me.kryptonNavigator1.Text = "kryptonNavigator1"
        Me.kryptonNavigator2.AllowPageDrag = True
        Me.kryptonNavigator2.AllowTabFocus = False
        Me.kryptonNavigator2.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.kryptonNavigator2.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowOnly
        Me.kryptonNavigator2.Button.ButtonDisplayLogic = Krypton.Navigator.ButtonDisplayLogic.Context
        Me.kryptonNavigator2.Button.CloseButtonAction = Krypton.Navigator.CloseButtonAction.RemovePageAndDispose
        Me.kryptonNavigator2.Button.CloseButtonDisplay = Krypton.Navigator.ButtonDisplay.Hide
        Me.kryptonNavigator2.Button.ContextButtonAction = Krypton.Navigator.ContextButtonAction.SelectPage
        Me.kryptonNavigator2.Button.ContextButtonDisplay = Krypton.Navigator.ButtonDisplay.Hide
        Me.kryptonNavigator2.Button.ContextMenuMapImage = Krypton.Navigator.MapKryptonPageImage.Small
        Me.kryptonNavigator2.Button.ContextMenuMapText = Krypton.Navigator.MapKryptonPageText.TextTitle
        Me.kryptonNavigator2.Button.NextButtonAction = Krypton.Navigator.DirectionButtonAction.ModeAppropriateAction
        Me.kryptonNavigator2.Button.NextButtonDisplay = Krypton.Navigator.ButtonDisplay.Logic
        Me.kryptonNavigator2.Button.PreviousButtonAction = Krypton.Navigator.DirectionButtonAction.ModeAppropriateAction
        Me.kryptonNavigator2.Button.PreviousButtonDisplay = Krypton.Navigator.ButtonDisplay.Logic
        Me.kryptonNavigator2.Group.GroupBackStyle = Krypton.Toolkit.PaletteBackStyle.ControlClient
        Me.kryptonNavigator2.Group.GroupBorderStyle = Krypton.Toolkit.PaletteBorderStyle.ControlClient
        Me.kryptonNavigator2.Header.HeaderPositionBar = Krypton.Toolkit.VisualOrientation.Top
        Me.kryptonNavigator2.Header.HeaderPositionPrimary = Krypton.Toolkit.VisualOrientation.Top
        Me.kryptonNavigator2.Header.HeaderPositionSecondary = Krypton.Toolkit.VisualOrientation.Bottom
        Me.kryptonNavigator2.Header.HeaderStyleBar = Krypton.Toolkit.HeaderStyle.Secondary
        Me.kryptonNavigator2.Header.HeaderStylePrimary = Krypton.Toolkit.HeaderStyle.Primary
        Me.kryptonNavigator2.Header.HeaderStyleSecondary = Krypton.Toolkit.HeaderStyle.Secondary
        Me.kryptonNavigator2.Header.HeaderVisibleSecondary = False
        Me.kryptonNavigator2.Location = New System.Drawing.Point(343, 70)
        Me.kryptonNavigator2.Name = "kryptonNavigator2"
        Me.kryptonNavigator2.NavigatorMode = Krypton.Navigator.NavigatorMode.HeaderBarCheckButtonHeaderGroup
        Me.kryptonNavigator2.PageBackStyle = Krypton.Toolkit.PaletteBackStyle.ControlClient
        Me.kryptonNavigator2.Panel.PanelBackStyle = Krypton.Toolkit.PaletteBackStyle.PanelClient
        Me.kryptonNavigator2.Size = New System.Drawing.Size(329, 202)
        Me.kryptonNavigator2.TabIndex = 3
        Me.kryptonNavigator2.Text = "kryptonNavigator1"
        Me.kryptonWorkspace2.ActivePage = Nothing
        Me.kryptonWorkspace2.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) Or System.Windows.Forms.AnchorStyles.Left) Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.kryptonWorkspace2.CompactFlags = CType((((Krypton.Workspace.CompactFlags.RemoveEmptyCells Or Krypton.Workspace.CompactFlags.RemoveEmptySequences) Or Krypton.Workspace.CompactFlags.PromoteLeafs) Or Krypton.Workspace.CompactFlags.AtLeastOneVisibleCell), Krypton.Workspace.CompactFlags)
        Me.kryptonWorkspace2.ContainerBackStyle = Krypton.Toolkit.PaletteBackStyle.PanelClient
        Me.kryptonWorkspace2.Location = New System.Drawing.Point(343, 309)
        Me.kryptonWorkspace2.Name = "kryptonWorkspace2"
        Me.kryptonWorkspace2.Root.Orientation = System.Windows.Forms.Orientation.Horizontal
        Me.kryptonWorkspace2.Root.UniqueName = "CFCD8E8D88A44257CFCD8E8D88A44257"
        Me.kryptonWorkspace2.Root.WorkspaceControl = Me.kryptonWorkspace2
        Me.kryptonWorkspace2.SeparatorStyle = Krypton.Toolkit.SeparatorStyle.LowProfile
        Me.kryptonWorkspace2.ShowMaximizeButton = False
        Me.kryptonWorkspace2.Size = New System.Drawing.Size(329, 271)
        Me.kryptonWorkspace2.SplitterWidth = 5
        Me.kryptonWorkspace2.TabIndex = 6
        Me.kryptonWorkspace2.TabStop = True
        Me.labelTitle.AutoSize = True
        Me.labelTitle.Font = New System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.labelTitle.Location = New System.Drawing.Point(12, 13)
        Me.labelTitle.Name = "labelTitle"
        Me.labelTitle.Size = New System.Drawing.Size(636, 19)
        Me.labelTitle.TabIndex = 0
        Me.labelTitle.Text = "Try dragging page headers between the Navigator and Workspace instances."
        Me.groupBoxDragFeedback.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Left), System.Windows.Forms.AnchorStyles)
        Me.groupBoxDragFeedback.Controls.Add(Me.radioRounded)
        Me.groupBoxDragFeedback.Controls.Add(Me.radioSquares)
        Me.groupBoxDragFeedback.Controls.Add(Me.radioBlock)
        Me.groupBoxDragFeedback.Location = New System.Drawing.Point(13, 592)
        Me.groupBoxDragFeedback.Name = "groupBoxDragFeedback"
        Me.groupBoxDragFeedback.Size = New System.Drawing.Size(248, 52)
        Me.groupBoxDragFeedback.TabIndex = 7
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
        Me.buttonClose.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.buttonClose.Location = New System.Drawing.Point(602, 592)
        Me.buttonClose.Name = "buttonClose"
        Me.buttonClose.Size = New System.Drawing.Size(70, 23)
        Me.buttonClose.TabIndex = 8
        Me.buttonClose.Text = "Close"
        Me.buttonClose.UseVisualStyleBackColor = True
        Me.imageList.ImageStream = CType(resources.GetObject("imageList.ImageStream"), System.Windows.Forms.ImageListStreamer)
        Me.imageList.TransparentColor = System.Drawing.Color.Transparent
        Me.imageList.Images.SetKeyName(0, "bell.png")
        Me.imageList.Images.SetKeyName(1, "box.png")
        Me.imageList.Images.SetKeyName(2, "brickwall.png")
        Me.imageList.Images.SetKeyName(3, "castle.png")
        Me.imageList.Images.SetKeyName(4, "chart.png")
        Me.imageList.Images.SetKeyName(5, "colors.png")
        Me.imageList.Images.SetKeyName(6, "cubes.png")
        Me.imageList.Images.SetKeyName(7, "pawn.png")
        Me.kryptonWorkspace1.ActivePage = Nothing
        Me.kryptonWorkspace1.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) Or System.Windows.Forms.AnchorStyles.Left), System.Windows.Forms.AnchorStyles)
        Me.kryptonWorkspace1.CompactFlags = CType((((Krypton.Workspace.CompactFlags.RemoveEmptyCells Or Krypton.Workspace.CompactFlags.RemoveEmptySequences) Or Krypton.Workspace.CompactFlags.PromoteLeafs) Or Krypton.Workspace.CompactFlags.AtLeastOneVisibleCell), Krypton.Workspace.CompactFlags)
        Me.kryptonWorkspace1.ContainerBackStyle = Krypton.Toolkit.PaletteBackStyle.PanelClient
        Me.kryptonWorkspace1.Location = New System.Drawing.Point(13, 309)
        Me.kryptonWorkspace1.Name = "kryptonWorkspace1"
        Me.kryptonWorkspace1.Root.Orientation = System.Windows.Forms.Orientation.Vertical
        Me.kryptonWorkspace1.Root.UniqueName = "E37CE04BEBFB4C1DE37CE04BEBFB4C1D"
        Me.kryptonWorkspace1.Root.WorkspaceControl = Me.kryptonWorkspace1
        Me.kryptonWorkspace1.SeparatorStyle = Krypton.Toolkit.SeparatorStyle.LowProfile
        Me.kryptonWorkspace1.ShowMaximizeButton = False
        Me.kryptonWorkspace1.Size = New System.Drawing.Size(313, 271)
        Me.kryptonWorkspace1.SplitterWidth = 5
        Me.kryptonWorkspace1.TabIndex = 5
        Me.kryptonWorkspace1.TabStop = True
        Me.labelNavigators.AutoSize = True
        Me.labelNavigators.Font = New System.Drawing.Font("Tahoma", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.labelNavigators.Location = New System.Drawing.Point(13, 46)
        Me.labelNavigators.Name = "labelNavigators"
        Me.labelNavigators.Size = New System.Drawing.Size(91, 18)
        Me.labelNavigators.TabIndex = 1
        Me.labelNavigators.Text = "Navigators"
        Me.labelWorkspaces.AutoSize = True
        Me.labelWorkspaces.Font = New System.Drawing.Font("Tahoma", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.labelWorkspaces.Location = New System.Drawing.Point(13, 284)
        Me.labelWorkspaces.Name = "labelWorkspaces"
        Me.labelWorkspaces.Size = New System.Drawing.Size(99, 18)
        Me.labelWorkspaces.TabIndex = 4
        Me.labelWorkspaces.Text = "Workspaces"
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6F, 13F)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(684, 654)
        Me.Controls.Add(Me.labelWorkspaces)
        Me.Controls.Add(Me.labelNavigators)
        Me.Controls.Add(Me.kryptonWorkspace1)
        Me.Controls.Add(Me.kryptonNavigator2)
        Me.Controls.Add(Me.kryptonWorkspace2)
        Me.Controls.Add(Me.kryptonNavigator1)
        Me.Controls.Add(Me.buttonClose)
        Me.Controls.Add(Me.groupBoxDragFeedback)
        Me.Controls.Add(Me.labelTitle)
        Me.Font = New System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.MaximizeBox = False
        Me.MinimizeBox = False
        Me.MinimumSize = New System.Drawing.Size(675, 641)
        Me.Name = "Form1"
        Me.Text = "Basic Page Drag and Drop"
        CType(Me.kryptonNavigator1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.kryptonNavigator1.ResumeLayout(False)
        CType(Me.kryptonNavigator2, System.ComponentModel.ISupportInitialize).EndInit()
        Me.kryptonNavigator2.ResumeLayout(False)
        CType(Me.kryptonWorkspace2, System.ComponentModel.ISupportInitialize).EndInit()
        Me.groupBoxDragFeedback.ResumeLayout(False)
        Me.groupBoxDragFeedback.PerformLayout()
        CType(Me.kryptonWorkspace1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()
    End Sub

    Friend WithEvents kryptonNavigator1 As Krypton.Navigator.KryptonNavigator
    Friend WithEvents kryptonNavigator2 As Krypton.Navigator.KryptonNavigator
    Friend WithEvents kryptonWorkspace2 As Krypton.Workspace.KryptonWorkspace
    Friend WithEvents labelTitle As System.Windows.Forms.Label
    Friend WithEvents groupBoxDragFeedback As System.Windows.Forms.GroupBox
    Friend WithEvents radioRounded As System.Windows.Forms.RadioButton
    Friend WithEvents radioSquares As System.Windows.Forms.RadioButton
    Friend WithEvents radioBlock As System.Windows.Forms.RadioButton
    Friend WithEvents buttonClose As System.Windows.Forms.Button
    Friend WithEvents imageList As System.Windows.Forms.ImageList
    Friend WithEvents kryptonWorkspace1 As Krypton.Workspace.KryptonWorkspace
    Friend WithEvents labelNavigators As System.Windows.Forms.Label
    Friend WithEvents labelWorkspaces As System.Windows.Forms.Label
    Friend WithEvents kryptonManager1 As Krypton.Toolkit.KryptonManager
End Class
