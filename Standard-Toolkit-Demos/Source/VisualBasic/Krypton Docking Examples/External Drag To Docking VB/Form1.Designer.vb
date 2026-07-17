' VB.NET twin of Source\Krypton Docking Examples\External Drag To Docking\Form1.Designer.cs (Bastion Phase 4c).
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
        Me.kryptonManager = New Krypton.Toolkit.KryptonManager(Me.components)
        Me.kryptonPanel = New Krypton.Toolkit.KryptonPanel()
        Me.kryptonDockableWorkspace = New Krypton.Docking.KryptonDockableWorkspace()
        Me.imageListSmall = New System.Windows.Forms.ImageList(Me.components)
        Me.kryptonDockingManager = New Krypton.Docking.KryptonDockingManager()
        CType(Me.kryptonPanel, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.kryptonPanel.SuspendLayout()
        CType(Me.kryptonDockableWorkspace, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        Me.kryptonManager.GlobalPaletteMode = Krypton.Toolkit.PaletteMode.Office2010Blue
        Me.kryptonPanel.Controls.Add(Me.kryptonDockableWorkspace)
        Me.kryptonPanel.Dock = System.Windows.Forms.DockStyle.Fill
        Me.kryptonPanel.Location = New System.Drawing.Point(0, 0)
        Me.kryptonPanel.Margin = New System.Windows.Forms.Padding(4)
        Me.kryptonPanel.Name = "kryptonPanel"
        Me.kryptonPanel.Size = New System.Drawing.Size(1009, 605)
        Me.kryptonPanel.TabIndex = 0
        Me.kryptonDockableWorkspace.ActivePage = Nothing
        Me.kryptonDockableWorkspace.AutoHiddenHost = False
        Me.kryptonDockableWorkspace.CompactFlags = CType(((Krypton.Workspace.CompactFlags.RemoveEmptyCells Or Krypton.Workspace.CompactFlags.RemoveEmptySequences) Or Krypton.Workspace.CompactFlags.PromoteLeafs), Krypton.Workspace.CompactFlags)
        Me.kryptonDockableWorkspace.ContainerBackStyle = Krypton.Toolkit.PaletteBackStyle.PanelClient
        Me.kryptonDockableWorkspace.Dock = System.Windows.Forms.DockStyle.Fill
        Me.kryptonDockableWorkspace.Location = New System.Drawing.Point(0, 0)
        Me.kryptonDockableWorkspace.Margin = New System.Windows.Forms.Padding(4)
        Me.kryptonDockableWorkspace.Name = "kryptonDockableWorkspace"
        Me.kryptonDockableWorkspace.Root.UniqueName = "6C9A3354441646DC46BF0E62E96721F3"
        Me.kryptonDockableWorkspace.Root.WorkspaceControl = Me.kryptonDockableWorkspace
        Me.kryptonDockableWorkspace.SeparatorStyle = Krypton.Toolkit.SeparatorStyle.LowProfile
        Me.kryptonDockableWorkspace.ShowMaximizeButton = False
        Me.kryptonDockableWorkspace.Size = New System.Drawing.Size(1009, 605)
        Me.kryptonDockableWorkspace.SplitterWidth = 5
        Me.kryptonDockableWorkspace.TabIndex = 0
        Me.kryptonDockableWorkspace.TabStop = True
        Me.imageListSmall.ImageStream = CType(resources.GetObject("imageListSmall.ImageStream"), System.Windows.Forms.ImageListStreamer)
        Me.imageListSmall.TransparentColor = System.Drawing.Color.Transparent
        Me.imageListSmall.Images.SetKeyName(0, "document_plain.png")
        Me.imageListSmall.Images.SetKeyName(1, "preferences.png")
        Me.imageListSmall.Images.SetKeyName(2, "information2.png")
        Me.imageListSmall.Images.SetKeyName(3, "dictionary.png")
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8F, 16F)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(1009, 605)
        Me.Controls.Add(Me.kryptonPanel)
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.Margin = New System.Windows.Forms.Padding(4)
        Me.Name = "Form1"
        Me.Text = "External Drag To Docking"
        CType(Me.kryptonPanel, System.ComponentModel.ISupportInitialize).EndInit()
        Me.kryptonPanel.ResumeLayout(False)
        CType(Me.kryptonDockableWorkspace, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
    End Sub

    Friend WithEvents kryptonManager As Krypton.Toolkit.KryptonManager
    Friend WithEvents kryptonDockingManager As Krypton.Docking.KryptonDockingManager
    Friend WithEvents kryptonPanel As Krypton.Toolkit.KryptonPanel
    Friend WithEvents kryptonDockableWorkspace As Krypton.Docking.KryptonDockableWorkspace
    Friend WithEvents imageListSmall As System.Windows.Forms.ImageList
End Class
