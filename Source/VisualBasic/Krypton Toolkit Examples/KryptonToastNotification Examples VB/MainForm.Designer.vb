' VB.NET twin of Source\Krypton Toolkit Examples\KryptonToastNotification Examples\MainForm.Designer.cs (Bastion Phase 4c).
<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class MainForm
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(MainForm))
        Me.kryptonPanel1 = New Krypton.Toolkit.KryptonPanel()
        Me.kbtnCancel = New Krypton.Toolkit.KryptonButton()
        Me.kryptonBorderEdge1 = New Krypton.Toolkit.KryptonBorderEdge()
        Me.kryptonPanel2 = New Krypton.Toolkit.KryptonPanel()
        Me.kbtnCreateUserInputNotification = New Krypton.Toolkit.KryptonButton()
        Me.kbtnCreateBasicNotification = New Krypton.Toolkit.KryptonButton()
        CType(Me.kryptonPanel1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.kryptonPanel1.SuspendLayout()
        CType(Me.kryptonPanel2, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.kryptonPanel2.SuspendLayout()
        Me.SuspendLayout()
        Me.kryptonPanel1.Controls.Add(Me.kbtnCancel)
        Me.kryptonPanel1.Controls.Add(Me.kryptonBorderEdge1)
        Me.kryptonPanel1.Dock = System.Windows.Forms.DockStyle.Bottom
        Me.kryptonPanel1.Location = New System.Drawing.Point(0, 90)
        Me.kryptonPanel1.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.kryptonPanel1.Name = "kryptonPanel1"
        Me.kryptonPanel1.PanelBackStyle = Krypton.Toolkit.PaletteBackStyle.PanelAlternate
        Me.kryptonPanel1.Size = New System.Drawing.Size(473, 62)
        Me.kryptonPanel1.TabIndex = 0
        Me.kbtnCancel.DialogResult = System.Windows.Forms.DialogResult.Cancel
        Me.kbtnCancel.Location = New System.Drawing.Point(325, 16)
        Me.kbtnCancel.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.kbtnCancel.Name = "kbtnCancel"
        Me.kbtnCancel.Size = New System.Drawing.Size(120, 31)
        Me.kbtnCancel.TabIndex = 1
        Me.kbtnCancel.Values.DropDownArrowColor = System.Drawing.Color.Empty
        Me.kbtnCancel.Values.Text = "Cance&l"
        Me.kbtnCancel.Values.UseAsADialogButton = True
        Me.kryptonBorderEdge1.BorderStyle = Krypton.Toolkit.PaletteBorderStyle.HeaderSecondary
        Me.kryptonBorderEdge1.Dock = System.Windows.Forms.DockStyle.Top
        Me.kryptonBorderEdge1.Location = New System.Drawing.Point(0, 0)
        Me.kryptonBorderEdge1.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.kryptonBorderEdge1.Name = "kryptonBorderEdge1"
        Me.kryptonBorderEdge1.Size = New System.Drawing.Size(473, 1)
        Me.kryptonBorderEdge1.Text = "kryptonBorderEdge1"
        Me.kryptonPanel2.Controls.Add(Me.kbtnCreateUserInputNotification)
        Me.kryptonPanel2.Controls.Add(Me.kbtnCreateBasicNotification)
        Me.kryptonPanel2.Dock = System.Windows.Forms.DockStyle.Fill
        Me.kryptonPanel2.Location = New System.Drawing.Point(0, 0)
        Me.kryptonPanel2.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.kryptonPanel2.Name = "kryptonPanel2"
        Me.kryptonPanel2.Size = New System.Drawing.Size(473, 90)
        Me.kryptonPanel2.TabIndex = 1
        Me.kbtnCreateUserInputNotification.Location = New System.Drawing.Point(17, 54)
        Me.kbtnCreateUserInputNotification.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.kbtnCreateUserInputNotification.Name = "kbtnCreateUserInputNotification"
        Me.kbtnCreateUserInputNotification.Size = New System.Drawing.Size(428, 31)
        Me.kbtnCreateUserInputNotification.TabIndex = 1
        Me.kbtnCreateUserInputNotification.Values.DropDownArrowColor = System.Drawing.Color.Empty
        Me.kbtnCreateUserInputNotification.Values.Text = "Create &User Input Notification"
        Me.kbtnCreateBasicNotification.Location = New System.Drawing.Point(17, 16)
        Me.kbtnCreateBasicNotification.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.kbtnCreateBasicNotification.Name = "kbtnCreateBasicNotification"
        Me.kbtnCreateBasicNotification.Size = New System.Drawing.Size(428, 31)
        Me.kbtnCreateBasicNotification.TabIndex = 0
        Me.kbtnCreateBasicNotification.Values.DropDownArrowColor = System.Drawing.Color.Empty
        Me.kbtnCreateBasicNotification.Values.Text = "Create &Basic Notification"
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8F, 16F)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.CancelButton = Me.kbtnCancel
        Me.ClientSize = New System.Drawing.Size(473, 152)
        Me.Controls.Add(Me.kryptonPanel2)
        Me.Controls.Add(Me.kryptonPanel1)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.Fixed3D
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.MaximizeBox = False
        Me.MinimizeBox = False
        Me.Name = "MainForm"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "MainForm"
        CType(Me.kryptonPanel1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.kryptonPanel1.ResumeLayout(False)
        Me.kryptonPanel1.PerformLayout()
        CType(Me.kryptonPanel2, System.ComponentModel.ISupportInitialize).EndInit()
        Me.kryptonPanel2.ResumeLayout(False)
        Me.ResumeLayout(False)
    End Sub

    Friend WithEvents kryptonPanel1 As Krypton.Toolkit.KryptonPanel
    Friend WithEvents kryptonBorderEdge1 As Krypton.Toolkit.KryptonBorderEdge
    Friend WithEvents kryptonPanel2 As Krypton.Toolkit.KryptonPanel
    Friend WithEvents kbtnCancel As Krypton.Toolkit.KryptonButton
    Friend WithEvents kbtnCreateBasicNotification As Krypton.Toolkit.KryptonButton
    Friend WithEvents kbtnCreateUserInputNotification As Krypton.Toolkit.KryptonButton
End Class
