' VB.NET twin of Source\Krypton Toolkit Examples\Krypton UAC Button\Form1.Designer.cs (Bastion Phase 4c).
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(Form1))
        Me.kryptonPanel1 = New Krypton.Toolkit.KryptonPanel()
        Me.kchkShowUACShield = New Krypton.Toolkit.KryptonCheckBox()
        Me.kbtnTest = New Krypton.Toolkit.KryptonButton()
        CType(Me.kryptonPanel1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.kryptonPanel1.SuspendLayout()
        Me.SuspendLayout()
        '
        'kryptonPanel1
        '
        Me.kryptonPanel1.Controls.Add(Me.kchkShowUACShield)
        Me.kryptonPanel1.Controls.Add(Me.kbtnTest)
        Me.kryptonPanel1.Dock = System.Windows.Forms.DockStyle.Fill
        Me.kryptonPanel1.Location = New System.Drawing.Point(0, 0)
        Me.kryptonPanel1.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.kryptonPanel1.Name = "kryptonPanel1"
        Me.kryptonPanel1.Size = New System.Drawing.Size(457, 44)
        Me.kryptonPanel1.TabIndex = 0
        '
        'kchkShowUACShield
        '
        Me.kchkShowUACShield.Location = New System.Drawing.Point(285, 16)
        Me.kchkShowUACShield.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.kchkShowUACShield.Name = "kchkShowUACShield"
        Me.kchkShowUACShield.Size = New System.Drawing.Size(142, 24)
        Me.kchkShowUACShield.TabIndex = 1
        Me.kchkShowUACShield.Values.Text = "&Show UAC Shield"
        '
        'kbtnTest
        '
        Me.kbtnTest.Location = New System.Drawing.Point(17, 10)
        Me.kbtnTest.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.kbtnTest.Name = "kbtnTest"
        Me.kbtnTest.Size = New System.Drawing.Size(259, 31)
        Me.kbtnTest.TabIndex = 0
        Me.kbtnTest.Values.DropDownArrowColor = System.Drawing.Color.Empty
        Me.kbtnTest.Values.Text = "Some Text"
        '
        'Form1
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8F, 16F)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(457, 44)
        Me.Controls.Add(Me.kryptonPanel1)
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.MaximizeBox = False
        Me.MinimizeBox = False
        Me.Name = "Form1"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Krypton UAC Demo"
        CType(Me.kryptonPanel1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.kryptonPanel1.ResumeLayout(False)
        Me.kryptonPanel1.PerformLayout()
        Me.ResumeLayout(False)
    End Sub

    Friend WithEvents kryptonPanel1 As Krypton.Toolkit.KryptonPanel
    Friend WithEvents kchkShowUACShield As Krypton.Toolkit.KryptonCheckBox
    Friend WithEvents kbtnTest As Krypton.Toolkit.KryptonButton
End Class
