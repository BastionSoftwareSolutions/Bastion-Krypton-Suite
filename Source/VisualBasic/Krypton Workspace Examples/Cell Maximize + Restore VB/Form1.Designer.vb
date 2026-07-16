' VB.NET twin of Source\Krypton Workspace Examples\Cell Maximize + Restore\Form1.Designer.cs (Bastion Phase 4c).
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
        Me.buttonClose = New System.Windows.Forms.Button()
        Me.kryptonWorkspace = New Krypton.Workspace.KryptonWorkspace()
        Me.kryptonPage2 = New Krypton.Navigator.KryptonPage()
        Me.richTextBox2 = New System.Windows.Forms.RichTextBox()
        Me.kryptonWorkspaceCell1 = New Krypton.Workspace.KryptonWorkspaceCell()
        Me.kryptonPage1 = New Krypton.Navigator.KryptonPage()
        Me.richTextBox1 = New System.Windows.Forms.RichTextBox()
        Me.kryptonWorkspaceSequence1 = New Krypton.Workspace.KryptonWorkspaceSequence()
        Me.kryptonWorkspaceCell2 = New Krypton.Workspace.KryptonWorkspaceCell()
        Me.kryptonPage3 = New Krypton.Navigator.KryptonPage()
        Me.richTextBox4 = New System.Windows.Forms.RichTextBox()
        Me.kryptonPage4 = New Krypton.Navigator.KryptonPage()
        Me.richTextBox3 = New System.Windows.Forms.RichTextBox()
        Me.kryptonWorkspaceCell3 = New Krypton.Workspace.KryptonWorkspaceCell()
        Me.kryptonPage5 = New Krypton.Navigator.KryptonPage()
        Me.richTextBox6 = New System.Windows.Forms.RichTextBox()
        Me.kryptonPage6 = New Krypton.Navigator.KryptonPage()
        Me.richTextBox5 = New System.Windows.Forms.RichTextBox()
        Me.imageList = New System.Windows.Forms.ImageList(Me.components)
        Me.kryptonManager1 = New Krypton.Toolkit.KryptonManager(Me.components)
        CType(Me.kryptonWorkspace, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.kryptonWorkspace.SuspendLayout()
        CType(Me.kryptonPage2, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.kryptonPage2.SuspendLayout()
        CType(Me.kryptonWorkspaceCell1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.kryptonWorkspaceCell1.SuspendLayout()
        CType(Me.kryptonPage1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.kryptonPage1.SuspendLayout()
        CType(Me.kryptonWorkspaceCell2, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.kryptonWorkspaceCell2.SuspendLayout()
        CType(Me.kryptonPage3, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.kryptonPage3.SuspendLayout()
        CType(Me.kryptonPage4, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.kryptonPage4.SuspendLayout()
        CType(Me.kryptonWorkspaceCell3, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.kryptonWorkspaceCell3.SuspendLayout()
        CType(Me.kryptonPage5, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.kryptonPage5.SuspendLayout()
        CType(Me.kryptonPage6, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.kryptonPage6.SuspendLayout()
        Me.SuspendLayout()
        Me.buttonClose.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.buttonClose.Location = New System.Drawing.Point(729, 586)
        Me.buttonClose.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.buttonClose.Name = "buttonClose"
        Me.buttonClose.Size = New System.Drawing.Size(100, 32)
        Me.buttonClose.TabIndex = 1
        Me.buttonClose.Text = "Close"
        Me.buttonClose.UseVisualStyleBackColor = True
        Me.kryptonWorkspace.ActivePage = Me.kryptonPage2
        Me.kryptonWorkspace.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) Or System.Windows.Forms.AnchorStyles.Left) Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.kryptonWorkspace.CompactFlags = CType((((Krypton.Workspace.CompactFlags.RemoveEmptyCells Or Krypton.Workspace.CompactFlags.RemoveEmptySequences) Or Krypton.Workspace.CompactFlags.PromoteLeafs) Or Krypton.Workspace.CompactFlags.AtLeastOneVisibleCell), Krypton.Workspace.CompactFlags)
        Me.kryptonWorkspace.ContainerBackStyle = Krypton.Toolkit.PaletteBackStyle.PanelClient
        Me.kryptonWorkspace.Location = New System.Drawing.Point(16, 15)
        Me.kryptonWorkspace.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.kryptonWorkspace.Name = "kryptonWorkspace"
        Me.kryptonWorkspace.Root.Children.AddRange(New System.ComponentModel.Component() { Me.kryptonWorkspaceCell1, Me.kryptonWorkspaceSequence1})
        Me.kryptonWorkspace.Root.UniqueName = "4364A9E9DAF34C0D4364A9E9DAF34C0D"
        Me.kryptonWorkspace.Root.WorkspaceControl = Me.kryptonWorkspace
        Me.kryptonWorkspace.SeparatorStyle = Krypton.Toolkit.SeparatorStyle.LowProfile
        Me.kryptonWorkspace.Size = New System.Drawing.Size(813, 561)
        Me.kryptonWorkspace.SplitterWidth = 5
        Me.kryptonWorkspace.TabIndex = 0
        Me.kryptonWorkspace.TabStop = True
        Me.kryptonPage2.AutoHiddenSlideSize = New System.Drawing.Size(200, 200)
        Me.kryptonPage2.Controls.Add(Me.richTextBox2)
        Me.kryptonPage2.Flags = 65534
        Me.kryptonPage2.ImageSmall = CType(resources.GetObject("kryptonPage2.ImageSmall"), System.Drawing.Bitmap)
        Me.kryptonPage2.LastVisibleSet = True
        Me.kryptonPage2.MinimumSize = New System.Drawing.Size(50, 50)
        Me.kryptonPage2.Name = "kryptonPage2"
        Me.kryptonPage2.Padding = New System.Windows.Forms.Padding(5)
        Me.kryptonPage2.Size = New System.Drawing.Size(402, 528)
        Me.kryptonPage2.Text = "Workstation"
        Me.kryptonPage2.ToolTipTitle = "Page ToolTip"
        Me.kryptonPage2.UniqueName = "B057555EE9CE421BB057555EE9CE421B"
        Me.richTextBox2.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.richTextBox2.Dock = System.Windows.Forms.DockStyle.Fill
        Me.richTextBox2.Location = New System.Drawing.Point(5, 5)
        Me.richTextBox2.Name = "richTextBox2"
        Me.richTextBox2.Size = New System.Drawing.Size(392, 518)
        Me.richTextBox2.TabIndex = 1
        Me.richTextBox2.Text = ""
        Me.kryptonWorkspaceCell1.AllowPageDrag = True
        Me.kryptonWorkspaceCell1.AllowTabFocus = False
        Me.kryptonWorkspaceCell1.Button.ButtonDisplayLogic = Krypton.Navigator.ButtonDisplayLogic.Context
        Me.kryptonWorkspaceCell1.Button.CloseButtonAction = Krypton.Navigator.CloseButtonAction.RemovePageAndDispose
        Me.kryptonWorkspaceCell1.Button.CloseButtonDisplay = Krypton.Navigator.ButtonDisplay.Logic
        Me.kryptonWorkspaceCell1.Button.ContextButtonAction = Krypton.Navigator.ContextButtonAction.SelectPage
        Me.kryptonWorkspaceCell1.Button.ContextButtonDisplay = Krypton.Navigator.ButtonDisplay.Logic
        Me.kryptonWorkspaceCell1.Button.ContextMenuMapImage = Krypton.Navigator.MapKryptonPageImage.Small
        Me.kryptonWorkspaceCell1.Button.ContextMenuMapText = Krypton.Navigator.MapKryptonPageText.TextTitle
        Me.kryptonWorkspaceCell1.Button.NextButtonAction = Krypton.Navigator.DirectionButtonAction.ModeAppropriateAction
        Me.kryptonWorkspaceCell1.Button.NextButtonDisplay = Krypton.Navigator.ButtonDisplay.Logic
        Me.kryptonWorkspaceCell1.Button.PreviousButtonAction = Krypton.Navigator.DirectionButtonAction.ModeAppropriateAction
        Me.kryptonWorkspaceCell1.Button.PreviousButtonDisplay = Krypton.Navigator.ButtonDisplay.Logic
        Me.kryptonWorkspaceCell1.ControlKryptonFormFeatures = False
        Me.kryptonWorkspaceCell1.Name = "kryptonWorkspaceCell1"
        Me.kryptonWorkspaceCell1.NavigatorMode = Krypton.Navigator.NavigatorMode.BarTabGroup
        Me.kryptonWorkspaceCell1.Owner = Nothing
        Me.kryptonWorkspaceCell1.PageBackStyle = Krypton.Toolkit.PaletteBackStyle.ControlClient
        Me.kryptonWorkspaceCell1.Pages.AddRange(New Krypton.Navigator.KryptonPage() { Me.kryptonPage1, Me.kryptonPage2})
        Me.kryptonWorkspaceCell1.SelectedIndex = 1
        Me.kryptonWorkspaceCell1.UniqueName = "B46823ED744B4A87B46823ED744B4A87"
        Me.kryptonPage1.AutoHiddenSlideSize = New System.Drawing.Size(200, 200)
        Me.kryptonPage1.Controls.Add(Me.richTextBox1)
        Me.kryptonPage1.Flags = 65534
        Me.kryptonPage1.ImageSmall = CType(resources.GetObject("kryptonPage1.ImageSmall"), System.Drawing.Bitmap)
        Me.kryptonPage1.LastVisibleSet = True
        Me.kryptonPage1.MinimumSize = New System.Drawing.Size(50, 50)
        Me.kryptonPage1.Name = "kryptonPage1"
        Me.kryptonPage1.Padding = New System.Windows.Forms.Padding(5)
        Me.kryptonPage1.Size = New System.Drawing.Size(300, 423)
        Me.kryptonPage1.Text = "Bug List"
        Me.kryptonPage1.ToolTipTitle = "Page ToolTip"
        Me.kryptonPage1.UniqueName = "38D886AD20CD402D38D886AD20CD402D"
        Me.richTextBox1.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.richTextBox1.Dock = System.Windows.Forms.DockStyle.Fill
        Me.richTextBox1.Location = New System.Drawing.Point(5, 5)
        Me.richTextBox1.Name = "richTextBox1"
        Me.richTextBox1.Size = New System.Drawing.Size(290, 413)
        Me.richTextBox1.TabIndex = 0
        Me.richTextBox1.Text = ""
        Me.kryptonWorkspaceSequence1.Children.AddRange(New System.ComponentModel.Component() { Me.kryptonWorkspaceCell2, Me.kryptonWorkspaceCell3})
        Me.kryptonWorkspaceSequence1.Orientation = System.Windows.Forms.Orientation.Vertical
        Me.kryptonWorkspaceSequence1.UniqueName = "99DF5376A7A6421599DF5376A7A64215"
        Me.kryptonWorkspaceSequence1.WorkspaceControl = Nothing
        Me.kryptonWorkspaceCell2.AllowPageDrag = True
        Me.kryptonWorkspaceCell2.AllowTabFocus = False
        Me.kryptonWorkspaceCell2.Button.ButtonDisplayLogic = Krypton.Navigator.ButtonDisplayLogic.Context
        Me.kryptonWorkspaceCell2.Button.CloseButtonAction = Krypton.Navigator.CloseButtonAction.RemovePageAndDispose
        Me.kryptonWorkspaceCell2.Button.CloseButtonDisplay = Krypton.Navigator.ButtonDisplay.Logic
        Me.kryptonWorkspaceCell2.Button.ContextButtonAction = Krypton.Navigator.ContextButtonAction.SelectPage
        Me.kryptonWorkspaceCell2.Button.ContextButtonDisplay = Krypton.Navigator.ButtonDisplay.Logic
        Me.kryptonWorkspaceCell2.Button.ContextMenuMapImage = Krypton.Navigator.MapKryptonPageImage.Small
        Me.kryptonWorkspaceCell2.Button.ContextMenuMapText = Krypton.Navigator.MapKryptonPageText.TextTitle
        Me.kryptonWorkspaceCell2.Button.NextButtonAction = Krypton.Navigator.DirectionButtonAction.ModeAppropriateAction
        Me.kryptonWorkspaceCell2.Button.NextButtonDisplay = Krypton.Navigator.ButtonDisplay.Logic
        Me.kryptonWorkspaceCell2.Button.PreviousButtonAction = Krypton.Navigator.DirectionButtonAction.ModeAppropriateAction
        Me.kryptonWorkspaceCell2.Button.PreviousButtonDisplay = Krypton.Navigator.ButtonDisplay.Logic
        Me.kryptonWorkspaceCell2.ControlKryptonFormFeatures = False
        Me.kryptonWorkspaceCell2.Name = "kryptonWorkspaceCell2"
        Me.kryptonWorkspaceCell2.NavigatorMode = Krypton.Navigator.NavigatorMode.BarTabGroup
        Me.kryptonWorkspaceCell2.Owner = Nothing
        Me.kryptonWorkspaceCell2.PageBackStyle = Krypton.Toolkit.PaletteBackStyle.ControlClient
        Me.kryptonWorkspaceCell2.Pages.AddRange(New Krypton.Navigator.KryptonPage() { Me.kryptonPage3, Me.kryptonPage4})
        Me.kryptonWorkspaceCell2.SelectedIndex = 1
        Me.kryptonWorkspaceCell2.UniqueName = "9182BBE062034D889182BBE062034D88"
        Me.kryptonPage3.AutoHiddenSlideSize = New System.Drawing.Size(200, 200)
        Me.kryptonPage3.Controls.Add(Me.richTextBox4)
        Me.kryptonPage3.Flags = 65534
        Me.kryptonPage3.ImageSmall = CType(resources.GetObject("kryptonPage3.ImageSmall"), System.Drawing.Bitmap)
        Me.kryptonPage3.LastVisibleSet = True
        Me.kryptonPage3.MinimumSize = New System.Drawing.Size(50, 50)
        Me.kryptonPage3.Name = "kryptonPage3"
        Me.kryptonPage3.Padding = New System.Windows.Forms.Padding(5)
        Me.kryptonPage3.Size = New System.Drawing.Size(301, 192)
        Me.kryptonPage3.Text = "Server List"
        Me.kryptonPage3.ToolTipTitle = "Page ToolTip"
        Me.kryptonPage3.UniqueName = "05A80B272D8C411705A80B272D8C4117"
        Me.richTextBox4.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.richTextBox4.Dock = System.Windows.Forms.DockStyle.Fill
        Me.richTextBox4.Location = New System.Drawing.Point(5, 5)
        Me.richTextBox4.Name = "richTextBox4"
        Me.richTextBox4.Size = New System.Drawing.Size(291, 182)
        Me.richTextBox4.TabIndex = 1
        Me.richTextBox4.Text = ""
        Me.kryptonPage4.AutoHiddenSlideSize = New System.Drawing.Size(200, 200)
        Me.kryptonPage4.Controls.Add(Me.richTextBox3)
        Me.kryptonPage4.Flags = 65534
        Me.kryptonPage4.ImageSmall = CType(resources.GetObject("kryptonPage4.ImageSmall"), System.Drawing.Bitmap)
        Me.kryptonPage4.LastVisibleSet = True
        Me.kryptonPage4.MinimumSize = New System.Drawing.Size(50, 50)
        Me.kryptonPage4.Name = "kryptonPage4"
        Me.kryptonPage4.Padding = New System.Windows.Forms.Padding(5)
        Me.kryptonPage4.Size = New System.Drawing.Size(402, 245)
        Me.kryptonPage4.Text = "Planets"
        Me.kryptonPage4.ToolTipTitle = "Page ToolTip"
        Me.kryptonPage4.UniqueName = "0A2FA4EB0679438E0A2FA4EB0679438E"
        Me.richTextBox3.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.richTextBox3.Dock = System.Windows.Forms.DockStyle.Fill
        Me.richTextBox3.Location = New System.Drawing.Point(5, 5)
        Me.richTextBox3.Name = "richTextBox3"
        Me.richTextBox3.Size = New System.Drawing.Size(392, 235)
        Me.richTextBox3.TabIndex = 1
        Me.richTextBox3.Text = ""
        Me.kryptonWorkspaceCell3.AllowPageDrag = True
        Me.kryptonWorkspaceCell3.AllowTabFocus = False
        Me.kryptonWorkspaceCell3.Button.ButtonDisplayLogic = Krypton.Navigator.ButtonDisplayLogic.Context
        Me.kryptonWorkspaceCell3.Button.CloseButtonAction = Krypton.Navigator.CloseButtonAction.RemovePageAndDispose
        Me.kryptonWorkspaceCell3.Button.CloseButtonDisplay = Krypton.Navigator.ButtonDisplay.Logic
        Me.kryptonWorkspaceCell3.Button.ContextButtonAction = Krypton.Navigator.ContextButtonAction.SelectPage
        Me.kryptonWorkspaceCell3.Button.ContextButtonDisplay = Krypton.Navigator.ButtonDisplay.Logic
        Me.kryptonWorkspaceCell3.Button.ContextMenuMapImage = Krypton.Navigator.MapKryptonPageImage.Small
        Me.kryptonWorkspaceCell3.Button.ContextMenuMapText = Krypton.Navigator.MapKryptonPageText.TextTitle
        Me.kryptonWorkspaceCell3.Button.NextButtonAction = Krypton.Navigator.DirectionButtonAction.ModeAppropriateAction
        Me.kryptonWorkspaceCell3.Button.NextButtonDisplay = Krypton.Navigator.ButtonDisplay.Logic
        Me.kryptonWorkspaceCell3.Button.PreviousButtonAction = Krypton.Navigator.DirectionButtonAction.ModeAppropriateAction
        Me.kryptonWorkspaceCell3.Button.PreviousButtonDisplay = Krypton.Navigator.ButtonDisplay.Logic
        Me.kryptonWorkspaceCell3.ControlKryptonFormFeatures = False
        Me.kryptonWorkspaceCell3.Name = "kryptonWorkspaceCell3"
        Me.kryptonWorkspaceCell3.NavigatorMode = Krypton.Navigator.NavigatorMode.BarTabGroup
        Me.kryptonWorkspaceCell3.Owner = Nothing
        Me.kryptonWorkspaceCell3.PageBackStyle = Krypton.Toolkit.PaletteBackStyle.ControlClient
        Me.kryptonWorkspaceCell3.Pages.AddRange(New Krypton.Navigator.KryptonPage() { Me.kryptonPage5, Me.kryptonPage6})
        Me.kryptonWorkspaceCell3.SelectedIndex = 0
        Me.kryptonWorkspaceCell3.UniqueName = "A69A2BEFC56C49EFA69A2BEFC56C49EF"
        Me.kryptonPage5.AutoHiddenSlideSize = New System.Drawing.Size(200, 200)
        Me.kryptonPage5.Controls.Add(Me.richTextBox6)
        Me.kryptonPage5.Flags = 65534
        Me.kryptonPage5.ImageSmall = CType(resources.GetObject("kryptonPage5.ImageSmall"), System.Drawing.Bitmap)
        Me.kryptonPage5.LastVisibleSet = True
        Me.kryptonPage5.MinimumSize = New System.Drawing.Size(50, 50)
        Me.kryptonPage5.Name = "kryptonPage5"
        Me.kryptonPage5.Padding = New System.Windows.Forms.Padding(5)
        Me.kryptonPage5.Size = New System.Drawing.Size(402, 245)
        Me.kryptonPage5.Text = "Dance Steps"
        Me.kryptonPage5.ToolTipTitle = "Page ToolTip"
        Me.kryptonPage5.UniqueName = "5F44CFE539EF46555F44CFE539EF4655"
        Me.richTextBox6.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.richTextBox6.Dock = System.Windows.Forms.DockStyle.Fill
        Me.richTextBox6.Location = New System.Drawing.Point(5, 5)
        Me.richTextBox6.Name = "richTextBox6"
        Me.richTextBox6.Size = New System.Drawing.Size(392, 235)
        Me.richTextBox6.TabIndex = 1
        Me.richTextBox6.Text = ""
        Me.kryptonPage6.AutoHiddenSlideSize = New System.Drawing.Size(200, 200)
        Me.kryptonPage6.Controls.Add(Me.richTextBox5)
        Me.kryptonPage6.Flags = 65534
        Me.kryptonPage6.ImageSmall = CType(resources.GetObject("kryptonPage6.ImageSmall"), System.Drawing.Bitmap)
        Me.kryptonPage6.LastVisibleSet = True
        Me.kryptonPage6.MinimumSize = New System.Drawing.Size(50, 50)
        Me.kryptonPage6.Name = "kryptonPage6"
        Me.kryptonPage6.Padding = New System.Windows.Forms.Padding(5)
        Me.kryptonPage6.Size = New System.Drawing.Size(301, 193)
        Me.kryptonPage6.Text = "Music List"
        Me.kryptonPage6.ToolTipTitle = "Page ToolTip"
        Me.kryptonPage6.UniqueName = "20C9A0DF02044CE120C9A0DF02044CE1"
        Me.richTextBox5.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.richTextBox5.Dock = System.Windows.Forms.DockStyle.Fill
        Me.richTextBox5.Location = New System.Drawing.Point(5, 5)
        Me.richTextBox5.Name = "richTextBox5"
        Me.richTextBox5.Size = New System.Drawing.Size(291, 183)
        Me.richTextBox5.TabIndex = 1
        Me.richTextBox5.Text = ""
        Me.imageList.ImageStream = CType(resources.GetObject("imageList.ImageStream"), System.Windows.Forms.ImageListStreamer)
        Me.imageList.TransparentColor = System.Drawing.Color.Magenta
        Me.imageList.Images.SetKeyName(0, "Restore.bmp")
        Me.imageList.Images.SetKeyName(1, "Maximize.bmp")
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8F, 16F)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(845, 633)
        Me.Controls.Add(Me.buttonClose)
        Me.Controls.Add(Me.kryptonWorkspace)
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.MinimumSize = New System.Drawing.Size(261, 235)
        Me.Name = "Form1"
        Me.Text = "Cell Maximize + Restore"
        CType(Me.kryptonWorkspace, System.ComponentModel.ISupportInitialize).EndInit()
        Me.kryptonWorkspace.ResumeLayout(False)
        CType(Me.kryptonPage2, System.ComponentModel.ISupportInitialize).EndInit()
        Me.kryptonPage2.ResumeLayout(False)
        CType(Me.kryptonWorkspaceCell1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.kryptonWorkspaceCell1.ResumeLayout(False)
        CType(Me.kryptonPage1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.kryptonPage1.ResumeLayout(False)
        CType(Me.kryptonWorkspaceCell2, System.ComponentModel.ISupportInitialize).EndInit()
        Me.kryptonWorkspaceCell2.ResumeLayout(False)
        CType(Me.kryptonPage3, System.ComponentModel.ISupportInitialize).EndInit()
        Me.kryptonPage3.ResumeLayout(False)
        CType(Me.kryptonPage4, System.ComponentModel.ISupportInitialize).EndInit()
        Me.kryptonPage4.ResumeLayout(False)
        CType(Me.kryptonWorkspaceCell3, System.ComponentModel.ISupportInitialize).EndInit()
        Me.kryptonWorkspaceCell3.ResumeLayout(False)
        CType(Me.kryptonPage5, System.ComponentModel.ISupportInitialize).EndInit()
        Me.kryptonPage5.ResumeLayout(False)
        CType(Me.kryptonPage6, System.ComponentModel.ISupportInitialize).EndInit()
        Me.kryptonPage6.ResumeLayout(False)
        Me.ResumeLayout(False)
    End Sub

    Friend WithEvents buttonClose As System.Windows.Forms.Button
    Friend WithEvents kryptonWorkspace As Krypton.Workspace.KryptonWorkspace
    Friend WithEvents kryptonWorkspaceCell1 As Krypton.Workspace.KryptonWorkspaceCell
    Friend WithEvents kryptonPage1 As Krypton.Navigator.KryptonPage
    Friend WithEvents kryptonPage2 As Krypton.Navigator.KryptonPage
    Friend WithEvents kryptonWorkspaceSequence1 As Krypton.Workspace.KryptonWorkspaceSequence
    Friend WithEvents kryptonWorkspaceCell2 As Krypton.Workspace.KryptonWorkspaceCell
    Friend WithEvents kryptonPage3 As Krypton.Navigator.KryptonPage
    Friend WithEvents kryptonPage4 As Krypton.Navigator.KryptonPage
    Friend WithEvents kryptonWorkspaceCell3 As Krypton.Workspace.KryptonWorkspaceCell
    Friend WithEvents kryptonPage5 As Krypton.Navigator.KryptonPage
    Friend WithEvents kryptonPage6 As Krypton.Navigator.KryptonPage
    Friend WithEvents richTextBox1 As System.Windows.Forms.RichTextBox
    Friend WithEvents richTextBox2 As System.Windows.Forms.RichTextBox
    Friend WithEvents richTextBox4 As System.Windows.Forms.RichTextBox
    Friend WithEvents richTextBox3 As System.Windows.Forms.RichTextBox
    Friend WithEvents richTextBox6 As System.Windows.Forms.RichTextBox
    Friend WithEvents richTextBox5 As System.Windows.Forms.RichTextBox
    Friend WithEvents imageList As System.Windows.Forms.ImageList
    Friend WithEvents kryptonManager1 As Krypton.Toolkit.KryptonManager
End Class
