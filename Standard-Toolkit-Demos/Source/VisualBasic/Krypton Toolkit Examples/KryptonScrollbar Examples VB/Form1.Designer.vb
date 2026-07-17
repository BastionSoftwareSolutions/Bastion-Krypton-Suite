' VB.NET twin of Source\Krypton Toolkit Examples\KryptonScrollbar Examples\Form1.Designer.cs (Bastion Phase 4c).
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
        Me.kryptonPanel1 = New Krypton.Toolkit.KryptonPanel()
        Me.pbVertical = New System.Windows.Forms.ProgressBar()
        Me.knudVertical = New Krypton.Toolkit.KryptonNumericUpDown()
        Me.kryptonLabel2 = New Krypton.Toolkit.KryptonLabel()
        Me.pbHorizontal = New System.Windows.Forms.ProgressBar()
        Me.knudHorizontal = New Krypton.Toolkit.KryptonNumericUpDown()
        Me.kryptonLabel1 = New Krypton.Toolkit.KryptonLabel()
        Me.ksbHorizontal = New Krypton.Toolkit.KryptonScrollBar()
        Me.ksbVertical = New Krypton.Toolkit.KryptonScrollBar()
        CType(Me.kryptonPanel1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.kryptonPanel1.SuspendLayout()
        Me.SuspendLayout()
        Me.kryptonPanel1.Controls.Add(Me.pbVertical)
        Me.kryptonPanel1.Controls.Add(Me.knudVertical)
        Me.kryptonPanel1.Controls.Add(Me.kryptonLabel2)
        Me.kryptonPanel1.Controls.Add(Me.pbHorizontal)
        Me.kryptonPanel1.Controls.Add(Me.knudHorizontal)
        Me.kryptonPanel1.Controls.Add(Me.kryptonLabel1)
        Me.kryptonPanel1.Controls.Add(Me.ksbHorizontal)
        Me.kryptonPanel1.Controls.Add(Me.ksbVertical)
        Me.kryptonPanel1.Dock = System.Windows.Forms.DockStyle.Fill
        Me.kryptonPanel1.Location = New System.Drawing.Point(0, 0)
        Me.kryptonPanel1.Name = "kryptonPanel1"
        Me.kryptonPanel1.Size = New System.Drawing.Size(425, 256)
        Me.kryptonPanel1.TabIndex = 0
        Me.pbVertical.Location = New System.Drawing.Point(39, 166)
        Me.pbVertical.Name = "pbVertical"
        Me.pbVertical.Size = New System.Drawing.Size(353, 23)
        Me.pbVertical.TabIndex = 7
        Me.knudVertical.Increment = New Decimal(New Integer() { 1, 0, 0, 0})
        Me.knudVertical.Location = New System.Drawing.Point(161, 139)
        Me.knudVertical.Maximum = New Decimal(New Integer() { 100, 0, 0, 0})
        Me.knudVertical.Minimum = New Decimal(New Integer() { 0, 0, 0, 0})
        Me.knudVertical.Name = "knudVertical"
        Me.knudVertical.Size = New System.Drawing.Size(120, 22)
        Me.knudVertical.TabIndex = 6
        Me.knudVertical.Value = New Decimal(New Integer() { 0, 0, 0, 0})
        Me.kryptonLabel2.LabelStyle = Krypton.Toolkit.LabelStyle.BoldControl
        Me.kryptonLabel2.Location = New System.Drawing.Point(39, 139)
        Me.kryptonLabel2.Name = "kryptonLabel2"
        Me.kryptonLabel2.Size = New System.Drawing.Size(94, 20)
        Me.kryptonLabel2.TabIndex = 5
        Me.kryptonLabel2.Values.Text = "Vertical Value:"
        Me.pbHorizontal.Location = New System.Drawing.Point(39, 66)
        Me.pbHorizontal.Name = "pbHorizontal"
        Me.pbHorizontal.Size = New System.Drawing.Size(353, 23)
        Me.pbHorizontal.TabIndex = 4
        Me.knudHorizontal.Increment = New Decimal(New Integer() { 1, 0, 0, 0})
        Me.knudHorizontal.Location = New System.Drawing.Point(161, 39)
        Me.knudHorizontal.Maximum = New Decimal(New Integer() { 100, 0, 0, 0})
        Me.knudHorizontal.Minimum = New Decimal(New Integer() { 0, 0, 0, 0})
        Me.knudHorizontal.Name = "knudHorizontal"
        Me.knudHorizontal.Size = New System.Drawing.Size(120, 22)
        Me.knudHorizontal.TabIndex = 3
        Me.knudHorizontal.Value = New Decimal(New Integer() { 0, 0, 0, 0})
        Me.kryptonLabel1.LabelStyle = Krypton.Toolkit.LabelStyle.BoldControl
        Me.kryptonLabel1.Location = New System.Drawing.Point(39, 39)
        Me.kryptonLabel1.Name = "kryptonLabel1"
        Me.kryptonLabel1.Size = New System.Drawing.Size(111, 20)
        Me.kryptonLabel1.TabIndex = 2
        Me.kryptonLabel1.Values.Text = "Horizontal Value:"
        Me.ksbHorizontal.BorderColor = System.Drawing.Color.FromArgb(CType(CType(93, Byte), Integer), CType(CType(140, Byte), Integer), CType(CType(201, Byte), Integer))
        Me.ksbHorizontal.DisabledBorderColor = System.Drawing.Color.Gray
        Me.ksbHorizontal.Location = New System.Drawing.Point(39, 13)
        Me.ksbHorizontal.Name = "ksbHorizontal"
        Me.ksbHorizontal.Opacity = 1D
        Me.ksbHorizontal.Orientation = Krypton.Toolkit.ScrollBarOrientation.Horizontal
        Me.ksbHorizontal.ScrollBarWidth = 353
        Me.ksbHorizontal.Size = New System.Drawing.Size(353, 19)
        Me.ksbHorizontal.TabIndex = 1
        Me.ksbVertical.BorderColor = System.Drawing.Color.FromArgb(CType(CType(93, Byte), Integer), CType(CType(140, Byte), Integer), CType(CType(201, Byte), Integer))
        Me.ksbVertical.DisabledBorderColor = System.Drawing.Color.Gray
        Me.ksbVertical.Location = New System.Drawing.Point(13, 13)
        Me.ksbVertical.Name = "ksbVertical"
        Me.ksbVertical.Opacity = 1D
        Me.ksbVertical.ScrollBarWidth = 19
        Me.ksbVertical.Size = New System.Drawing.Size(19, 231)
        Me.ksbVertical.TabIndex = 0
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6F, 13F)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(425, 256)
        Me.Controls.Add(Me.kryptonPanel1)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.Fixed3D
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.MaximizeBox = False
        Me.Name = "Form1"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Krypton ScrollBar Examples"
        CType(Me.kryptonPanel1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.kryptonPanel1.ResumeLayout(False)
        Me.kryptonPanel1.PerformLayout()
        Me.ResumeLayout(False)
    End Sub

    Friend WithEvents kryptonPanel1 As Krypton.Toolkit.KryptonPanel
    Friend WithEvents pbVertical As System.Windows.Forms.ProgressBar
    Friend WithEvents knudVertical As Krypton.Toolkit.KryptonNumericUpDown
    Friend WithEvents kryptonLabel2 As Krypton.Toolkit.KryptonLabel
    Friend WithEvents pbHorizontal As System.Windows.Forms.ProgressBar
    Friend WithEvents knudHorizontal As Krypton.Toolkit.KryptonNumericUpDown
    Friend WithEvents kryptonLabel1 As Krypton.Toolkit.KryptonLabel
    Friend WithEvents ksbHorizontal As Krypton.Toolkit.KryptonScrollBar
    Friend WithEvents ksbVertical As Krypton.Toolkit.KryptonScrollBar
End Class
