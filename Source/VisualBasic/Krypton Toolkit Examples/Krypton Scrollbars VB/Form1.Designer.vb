' VB.NET twin of Source\Krypton Toolkit Examples\Krypton Scrollbars\Form1.Designer.cs (Bastion Phase 4c).
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
        Me.knudHorizontal = New Krypton.Toolkit.KryptonNumericUpDown()
        Me.kryptonLabel2 = New Krypton.Toolkit.KryptonLabel()
        Me.knudVertical = New Krypton.Toolkit.KryptonNumericUpDown()
        Me.kryptonLabel1 = New Krypton.Toolkit.KryptonLabel()
        Me.ksbHorizontal = New Krypton.Toolkit.KryptonScrollBar()
        Me.ksbVertical = New Krypton.Toolkit.KryptonScrollBar()
        CType(Me.kryptonPanel1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.kryptonPanel1.SuspendLayout()
        Me.SuspendLayout()
        '
        'kryptonPanel1
        '
        Me.kryptonPanel1.Controls.Add(Me.knudHorizontal)
        Me.kryptonPanel1.Controls.Add(Me.kryptonLabel2)
        Me.kryptonPanel1.Controls.Add(Me.knudVertical)
        Me.kryptonPanel1.Controls.Add(Me.kryptonLabel1)
        Me.kryptonPanel1.Controls.Add(Me.ksbHorizontal)
        Me.kryptonPanel1.Controls.Add(Me.ksbVertical)
        Me.kryptonPanel1.Dock = System.Windows.Forms.DockStyle.Fill
        Me.kryptonPanel1.Location = New System.Drawing.Point(0, 0)
        Me.kryptonPanel1.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.kryptonPanel1.Name = "kryptonPanel1"
        Me.kryptonPanel1.Size = New System.Drawing.Size(417, 266)
        Me.kryptonPanel1.TabIndex = 0
        '
        'knudHorizontal
        '
        Me.knudHorizontal.Increment = New decimal(New Integer() { 1, 0, 0, 0})
        Me.knudHorizontal.Location = New System.Drawing.Point(225, 116)
        Me.knudHorizontal.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.knudHorizontal.Maximum = New decimal(New Integer() { 100, 0, 0, 0})
        Me.knudHorizontal.Minimum = New decimal(New Integer() { 0, 0, 0, 0})
        Me.knudHorizontal.Name = "knudHorizontal"
        Me.knudHorizontal.Size = New System.Drawing.Size(160, 26)
        Me.knudHorizontal.TabIndex = 6
        Me.knudHorizontal.Value = New decimal(New Integer() { 0, 0, 0, 0})
        '
        'kryptonLabel2
        '
        Me.kryptonLabel2.LabelStyle = Krypton.Toolkit.LabelStyle.BoldControl
        Me.kryptonLabel2.Location = New System.Drawing.Point(69, 116)
        Me.kryptonLabel2.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.kryptonLabel2.Name = "kryptonLabel2"
        Me.kryptonLabel2.Size = New System.Drawing.Size(137, 26)
        Me.kryptonLabel2.TabIndex = 5
        Me.kryptonLabel2.Values.Text = "Horizontal Value:"
        '
        'knudVertical
        '
        Me.knudVertical.Increment = New decimal(New Integer() { 1, 0, 0, 0})
        Me.knudVertical.Location = New System.Drawing.Point(225, 66)
        Me.knudVertical.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.knudVertical.Maximum = New decimal(New Integer() { 100, 0, 0, 0})
        Me.knudVertical.Minimum = New decimal(New Integer() { 0, 0, 0, 0})
        Me.knudVertical.Name = "knudVertical"
        Me.knudVertical.Size = New System.Drawing.Size(160, 26)
        Me.knudVertical.TabIndex = 4
        Me.knudVertical.Value = New decimal(New Integer() { 0, 0, 0, 0})
        '
        'kryptonLabel1
        '
        Me.kryptonLabel1.LabelStyle = Krypton.Toolkit.LabelStyle.BoldControl
        Me.kryptonLabel1.Location = New System.Drawing.Point(69, 66)
        Me.kryptonLabel1.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.kryptonLabel1.Name = "kryptonLabel1"
        Me.kryptonLabel1.Size = New System.Drawing.Size(116, 26)
        Me.kryptonLabel1.TabIndex = 3
        Me.kryptonLabel1.Values.Text = "Vertical Value:"
        '
        'ksbHorizontal
        '
        Me.ksbHorizontal.BorderColor = System.Drawing.Color.FromArgb(CType(CType(93, Byte), Integer), CType(CType(140, Byte), Integer), CType(CType(201, Byte), Integer))
        Me.ksbHorizontal.DisabledBorderColor = System.Drawing.Color.Gray
        Me.ksbHorizontal.Location = New System.Drawing.Point(49, 15)
        Me.ksbHorizontal.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.ksbHorizontal.Name = "ksbHorizontal"
        Me.ksbHorizontal.Opacity = 1D
        Me.ksbHorizontal.Orientation = Krypton.Toolkit.ScrollBarOrientation.Horizontal
        Me.ksbHorizontal.ScrollBarWidth = 336
        Me.ksbHorizontal.Size = New System.Drawing.Size(336, 23)
        Me.ksbHorizontal.TabIndex = 2
        '
        'ksbVertical
        '
        Me.ksbVertical.BorderColor = System.Drawing.Color.FromArgb(CType(CType(93, Byte), Integer), CType(CType(140, Byte), Integer), CType(CType(201, Byte), Integer))
        Me.ksbVertical.DisabledBorderColor = System.Drawing.Color.Gray
        Me.ksbVertical.Location = New System.Drawing.Point(16, 15)
        Me.ksbVertical.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.ksbVertical.Name = "ksbVertical"
        Me.ksbVertical.Opacity = 1D
        Me.ksbVertical.ScrollBarWidth = 25
        Me.ksbVertical.Size = New System.Drawing.Size(25, 246)
        Me.ksbVertical.TabIndex = 1
        '
        'Form1
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8F, 16F)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(417, 266)
        Me.Controls.Add(Me.kryptonPanel1)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.Fixed3D
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.MaximizeBox = False
        Me.MinimizeBox = False
        Me.Name = "Form1"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Krypton ScrollBars"
        CType(Me.kryptonPanel1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.kryptonPanel1.ResumeLayout(False)
        Me.kryptonPanel1.PerformLayout()
        Me.ResumeLayout(False)
    End Sub

    Friend WithEvents kryptonPanel1 As Krypton.Toolkit.KryptonPanel
    Friend WithEvents knudHorizontal As Krypton.Toolkit.KryptonNumericUpDown
    Friend WithEvents kryptonLabel2 As Krypton.Toolkit.KryptonLabel
    Friend WithEvents knudVertical As Krypton.Toolkit.KryptonNumericUpDown
    Friend WithEvents kryptonLabel1 As Krypton.Toolkit.KryptonLabel
    Friend WithEvents ksbHorizontal As Krypton.Toolkit.KryptonScrollBar
    Friend WithEvents ksbVertical As Krypton.Toolkit.KryptonScrollBar
End Class
