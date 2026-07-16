' VB.NET twin of Source\Krypton Ribbon Examples\MDI Ribbon\Form3.Designer.cs (Bastion Phase 4c).
<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class Form3
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(Form3))
        Me.kryptonPanel1 = New Krypton.Toolkit.KryptonPanel()
        Me.labelMessage = New Krypton.Toolkit.KryptonLabel()
        Me.buttonOK = New Krypton.Toolkit.KryptonButton()
        CType(Me.kryptonPanel1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.kryptonPanel1.SuspendLayout()
        Me.SuspendLayout()
        Me.kryptonPanel1.Controls.Add(Me.labelMessage)
        Me.kryptonPanel1.Controls.Add(Me.buttonOK)
        Me.kryptonPanel1.Dock = System.Windows.Forms.DockStyle.Fill
        Me.kryptonPanel1.Location = New System.Drawing.Point(0, 0)
        Me.kryptonPanel1.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.kryptonPanel1.Name = "kryptonPanel1"
        Me.kryptonPanel1.Size = New System.Drawing.Size(351, 98)
        Me.kryptonPanel1.TabIndex = 0
        Me.labelMessage.Location = New System.Drawing.Point(20, 16)
        Me.labelMessage.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.labelMessage.Name = "labelMessage"
        Me.labelMessage.Size = New System.Drawing.Size(294, 24)
        Me.labelMessage.TabIndex = 1
        Me.labelMessage.Values.Text = "This is where you would show some help!"
        Me.buttonOK.DialogResult = System.Windows.Forms.DialogResult.Cancel
        Me.buttonOK.Location = New System.Drawing.Point(119, 59)
        Me.buttonOK.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.buttonOK.Name = "buttonOK"
        Me.buttonOK.Size = New System.Drawing.Size(89, 31)
        Me.buttonOK.TabIndex = 0
        Me.buttonOK.Values.DropDownArrowColor = System.Drawing.Color.Empty
        Me.buttonOK.Values.Text = "OK"
        Me.AcceptButton = Me.buttonOK
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8F, 16F)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.CancelButton = Me.buttonOK
        Me.ClientSize = New System.Drawing.Size(351, 98)
        Me.Controls.Add(Me.kryptonPanel1)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.MaximizeBox = False
        Me.MinimizeBox = False
        Me.Name = "Form3"
        Me.ShowInTaskbar = False
        Me.SizeGripStyle = System.Windows.Forms.SizeGripStyle.Hide
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent
        Me.Text = "Help"
        CType(Me.kryptonPanel1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.kryptonPanel1.ResumeLayout(False)
        Me.kryptonPanel1.PerformLayout()
        Me.ResumeLayout(False)
    End Sub

    Friend WithEvents kryptonPanel1 As Krypton.Toolkit.KryptonPanel
    Friend WithEvents labelMessage As Krypton.Toolkit.KryptonLabel
    Friend WithEvents buttonOK As Krypton.Toolkit.KryptonButton
End Class
