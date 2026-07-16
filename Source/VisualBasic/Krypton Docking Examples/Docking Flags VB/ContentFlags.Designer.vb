' VB.NET twin of Source\Krypton Docking Examples\Docking Flags\ContentFlags.Designer.cs (Bastion Phase 4c).
<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class ContentFlags
    Inherits System.Windows.Forms.UserControl

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
        Me.kryptonPanel = New Krypton.Toolkit.KryptonPanel()
        Me.cbNavigator = New Krypton.Toolkit.KryptonCheckBox()
        Me.cbClose = New Krypton.Toolkit.KryptonCheckBox()
        Me.cbWorkspace = New Krypton.Toolkit.KryptonCheckBox()
        Me.cbFloating = New Krypton.Toolkit.KryptonCheckBox()
        Me.cbAutoHidden = New Krypton.Toolkit.KryptonCheckBox()
        Me.cbDocked = New Krypton.Toolkit.KryptonCheckBox()
        Me.cbDropDown = New Krypton.Toolkit.KryptonCheckBox()
        CType(Me.kryptonPanel, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.kryptonPanel.SuspendLayout()
        Me.SuspendLayout()
        Me.kryptonPanel.Controls.Add(Me.cbDropDown)
        Me.kryptonPanel.Controls.Add(Me.cbNavigator)
        Me.kryptonPanel.Controls.Add(Me.cbClose)
        Me.kryptonPanel.Controls.Add(Me.cbWorkspace)
        Me.kryptonPanel.Controls.Add(Me.cbFloating)
        Me.kryptonPanel.Controls.Add(Me.cbAutoHidden)
        Me.kryptonPanel.Controls.Add(Me.cbDocked)
        Me.kryptonPanel.Dock = System.Windows.Forms.DockStyle.Fill
        Me.kryptonPanel.Location = New System.Drawing.Point(0, 0)
        Me.kryptonPanel.Name = "kryptonPanel"
        Me.kryptonPanel.PanelBackStyle = Krypton.Toolkit.PaletteBackStyle.ControlClient
        Me.kryptonPanel.Size = New System.Drawing.Size(203, 192)
        Me.kryptonPanel.TabIndex = 0
        Me.cbNavigator.Location = New System.Drawing.Point(15, 106)
        Me.cbNavigator.Name = "cbNavigator"
        Me.cbNavigator.Size = New System.Drawing.Size(111, 20)
        Me.cbNavigator.TabIndex = 4
        Me.cbNavigator.Values.Text = "Allow Navigator"
        Me.cbClose.Location = New System.Drawing.Point(15, 152)
        Me.cbClose.Name = "cbClose"
        Me.cbClose.Size = New System.Drawing.Size(87, 20)
        Me.cbClose.TabIndex = 6
        Me.cbClose.Values.Text = "Allow Close"
        Me.cbWorkspace.Location = New System.Drawing.Point(15, 83)
        Me.cbWorkspace.Name = "cbWorkspace"
        Me.cbWorkspace.Size = New System.Drawing.Size(117, 20)
        Me.cbWorkspace.TabIndex = 3
        Me.cbWorkspace.Values.Text = "Allow Workspace"
        Me.cbFloating.Location = New System.Drawing.Point(15, 60)
        Me.cbFloating.Name = "cbFloating"
        Me.cbFloating.Size = New System.Drawing.Size(101, 20)
        Me.cbFloating.TabIndex = 2
        Me.cbFloating.Values.Text = "Allow Floating"
        Me.cbAutoHidden.Location = New System.Drawing.Point(15, 37)
        Me.cbAutoHidden.Name = "cbAutoHidden"
        Me.cbAutoHidden.Size = New System.Drawing.Size(123, 20)
        Me.cbAutoHidden.TabIndex = 1
        Me.cbAutoHidden.Values.Text = "Allow AutoHidden"
        Me.cbDocked.Location = New System.Drawing.Point(15, 14)
        Me.cbDocked.Name = "cbDocked"
        Me.cbDocked.Size = New System.Drawing.Size(99, 20)
        Me.cbDocked.TabIndex = 0
        Me.cbDocked.Values.Text = "Allow Docked"
        Me.cbDropDown.Location = New System.Drawing.Point(15, 129)
        Me.cbDropDown.Name = "cbDropDown"
        Me.cbDropDown.Size = New System.Drawing.Size(116, 20)
        Me.cbDropDown.TabIndex = 5
        Me.cbDropDown.Values.Text = "Allow DropDown"
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6F, 13F)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.Controls.Add(Me.kryptonPanel)
        Me.Name = "ContentFlags"
        Me.Size = New System.Drawing.Size(203, 192)
        CType(Me.kryptonPanel, System.ComponentModel.ISupportInitialize).EndInit()
        Me.kryptonPanel.ResumeLayout(False)
        Me.kryptonPanel.PerformLayout()
        Me.ResumeLayout(False)
    End Sub

    Friend WithEvents kryptonPanel As Krypton.Toolkit.KryptonPanel
    Friend WithEvents cbClose As Krypton.Toolkit.KryptonCheckBox
    Friend WithEvents cbWorkspace As Krypton.Toolkit.KryptonCheckBox
    Friend WithEvents cbFloating As Krypton.Toolkit.KryptonCheckBox
    Friend WithEvents cbAutoHidden As Krypton.Toolkit.KryptonCheckBox
    Friend WithEvents cbDocked As Krypton.Toolkit.KryptonCheckBox
    Friend WithEvents cbNavigator As Krypton.Toolkit.KryptonCheckBox
    Friend WithEvents cbDropDown As Krypton.Toolkit.KryptonCheckBox
End Class
