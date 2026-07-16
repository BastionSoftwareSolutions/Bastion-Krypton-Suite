' VB.NET twin of Source\Krypton Docking Examples\Docking Customized\ContentPropertyGrid.Designer.cs (Bastion Phase 4c).
<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class ContentPropertyGrid
    Inherits System.Windows.Forms.UserControl

    'Required by the Windows Form Designer
    Private components As System.ComponentModel.IContainer

    'NOTE: The following procedure is required by the Windows Form Designer
    'It can be modified using the Windows Form Designer.
    'Do not modify it using the code editor.
    <System.Diagnostics.DebuggerStepThrough()>
    Private Sub InitializeComponent()
        Me.propertyGrid1 = New Krypton.Toolkit.KryptonPropertyGrid()
        Me.kryptonPanel = New Krypton.Toolkit.KryptonPanel()
        CType(Me.kryptonPanel, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.kryptonPanel.SuspendLayout()
        Me.SuspendLayout()
        Me.propertyGrid1.Dock = System.Windows.Forms.DockStyle.Fill
        Me.propertyGrid1.HelpVisible = False
        Me.propertyGrid1.Location = New System.Drawing.Point(5, 5)
        Me.propertyGrid1.Name = "propertyGrid1"
        Me.propertyGrid1.SelectedObject = Me.propertyGrid1
        Me.propertyGrid1.Size = New System.Drawing.Size(233, 151)
        Me.propertyGrid1.TabIndex = 0
        Me.propertyGrid1.ToolbarVisible = False
        Me.kryptonPanel.Controls.Add(Me.propertyGrid1)
        Me.kryptonPanel.Dock = System.Windows.Forms.DockStyle.Fill
        Me.kryptonPanel.Location = New System.Drawing.Point(0, 0)
        Me.kryptonPanel.Name = "kryptonPanel"
        Me.kryptonPanel.Padding = New System.Windows.Forms.Padding(5)
        Me.kryptonPanel.PaletteMode = Krypton.Toolkit.PaletteMode.Global
        Me.kryptonPanel.PanelBackStyle = Krypton.Toolkit.PaletteBackStyle.ControlClient
        Me.kryptonPanel.Size = New System.Drawing.Size(243, 161)
        Me.kryptonPanel.TabIndex = 1
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6F, 13F)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.Controls.Add(Me.kryptonPanel)
        Me.Name = "ContentPropertyGrid"
        Me.Size = New System.Drawing.Size(243, 161)
        CType(Me.kryptonPanel, System.ComponentModel.ISupportInitialize).EndInit()
        Me.kryptonPanel.ResumeLayout(False)
        Me.ResumeLayout(False)
    End Sub

    Friend WithEvents propertyGrid1 As Krypton.Toolkit.KryptonPropertyGrid
    Friend WithEvents kryptonPanel As Krypton.Toolkit.KryptonPanel
End Class
