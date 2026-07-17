' VB.NET twin of Source\Krypton Toolkit Examples\KryptonToggleSwitch Examples\Form1.Designer.cs (Bastion Phase 4c).
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
        Me.kryptonPanel1 = New Krypton.Toolkit.KryptonPanel()
        Me.kryptonPanel2 = New Krypton.Toolkit.KryptonPanel()
        Me.kryptonGroupBox1 = New Krypton.Toolkit.KryptonGroupBox()
        Me.kryptonGroupBox2 = New Krypton.Toolkit.KryptonGroupBox()
        Me.kryptonPropertyGrid1 = New Krypton.Toolkit.KryptonPropertyGrid()
        Me.kryptonPanel3 = New Krypton.Toolkit.KryptonPanel()
        Me.kryptonPanel4 = New Krypton.Toolkit.KryptonPanel()
        Me.ktsTest = New Krypton.Toolkit.KryptonToggleSwitch()
        Me.kryptonWrapLabel1 = New Krypton.Toolkit.KryptonWrapLabel()
        Me.kbtnClose = New Krypton.Toolkit.KryptonButton()
        CType(Me.kryptonPanel1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.kryptonPanel1.SuspendLayout()
        CType(Me.kryptonPanel2, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.kryptonPanel2.SuspendLayout()
        CType(Me.kryptonGroupBox1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.kryptonGroupBox1.Panel, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.kryptonGroupBox1.Panel.SuspendLayout()
        Me.kryptonGroupBox1.SuspendLayout()
        CType(Me.kryptonGroupBox2, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.kryptonGroupBox2.Panel, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.kryptonGroupBox2.Panel.SuspendLayout()
        Me.kryptonGroupBox2.SuspendLayout()
        CType(Me.kryptonPanel3, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.kryptonPanel3.SuspendLayout()
        CType(Me.kryptonPanel4, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.kryptonPanel4.SuspendLayout()
        Me.SuspendLayout()
        Me.kryptonPanel1.Controls.Add(Me.kbtnClose)
        Me.kryptonPanel1.Dock = System.Windows.Forms.DockStyle.Bottom
        Me.kryptonPanel1.Location = New System.Drawing.Point(0, 390)
        Me.kryptonPanel1.Name = "kryptonPanel1"
        Me.kryptonPanel1.PanelBackStyle = Krypton.Toolkit.PaletteBackStyle.PanelAlternate
        Me.kryptonPanel1.Size = New System.Drawing.Size(808, 50)
        Me.kryptonPanel1.TabIndex = 0
        Me.kryptonPanel2.Controls.Add(Me.kryptonGroupBox2)
        Me.kryptonPanel2.Controls.Add(Me.kryptonGroupBox1)
        Me.kryptonPanel2.Dock = System.Windows.Forms.DockStyle.Fill
        Me.kryptonPanel2.Location = New System.Drawing.Point(0, 0)
        Me.kryptonPanel2.Name = "kryptonPanel2"
        Me.kryptonPanel2.Size = New System.Drawing.Size(808, 390)
        Me.kryptonPanel2.TabIndex = 1
        Me.kryptonGroupBox1.Dock = System.Windows.Forms.DockStyle.Right
        Me.kryptonGroupBox1.Location = New System.Drawing.Point(485, 0)
        Me.kryptonGroupBox1.Panel.Controls.Add(Me.kryptonPropertyGrid1)
        Me.kryptonGroupBox1.Size = New System.Drawing.Size(323, 390)
        Me.kryptonGroupBox1.TabIndex = 0
        Me.kryptonGroupBox1.Values.Heading = "ToggleSwitch Properties"
        Me.kryptonGroupBox2.Dock = System.Windows.Forms.DockStyle.Fill
        Me.kryptonGroupBox2.Location = New System.Drawing.Point(0, 0)
        Me.kryptonGroupBox2.Panel.Controls.Add(Me.kryptonPanel4)
        Me.kryptonGroupBox2.Panel.Controls.Add(Me.kryptonPanel3)
        Me.kryptonGroupBox2.Size = New System.Drawing.Size(485, 390)
        Me.kryptonGroupBox2.TabIndex = 1
        Me.kryptonGroupBox2.Values.Heading = "ToggleSwitch"
        Me.kryptonPropertyGrid1.Dock = System.Windows.Forms.DockStyle.Fill
        Me.kryptonPropertyGrid1.Location = New System.Drawing.Point(0, 0)
        Me.kryptonPropertyGrid1.Name = "kryptonPropertyGrid1"
        Me.kryptonPropertyGrid1.Padding = New System.Windows.Forms.Padding(1)
        Me.kryptonPropertyGrid1.SelectedObject = Me.ktsTest
        Me.kryptonPropertyGrid1.Size = New System.Drawing.Size(319, 366)
        Me.kryptonPropertyGrid1.TabIndex = 0
        Me.kryptonPropertyGrid1.Text = "kryptonPropertyGrid1"
        Me.kryptonPanel3.Controls.Add(Me.kryptonWrapLabel1)
        Me.kryptonPanel3.Dock = System.Windows.Forms.DockStyle.Bottom
        Me.kryptonPanel3.Location = New System.Drawing.Point(0, 302)
        Me.kryptonPanel3.Name = "kryptonPanel3"
        Me.kryptonPanel3.Size = New System.Drawing.Size(481, 64)
        Me.kryptonPanel3.TabIndex = 0
        Me.kryptonPanel4.Controls.Add(Me.ktsTest)
        Me.kryptonPanel4.Dock = System.Windows.Forms.DockStyle.Fill
        Me.kryptonPanel4.Location = New System.Drawing.Point(0, 0)
        Me.kryptonPanel4.Name = "kryptonPanel4"
        Me.kryptonPanel4.Size = New System.Drawing.Size(481, 302)
        Me.kryptonPanel4.TabIndex = 1
        Me.ktsTest.BackColor = System.Drawing.Color.Transparent
        Me.ktsTest.Font = New System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold)
        Me.ktsTest.Location = New System.Drawing.Point(11, 14)
        Me.ktsTest.Name = "ktsTest"
        Me.ktsTest.Size = New System.Drawing.Size(452, 244)
        Me.ktsTest.TabIndex = 0
        Me.ktsTest.Text = "kryptonToggleSwitch1"
        Me.kryptonWrapLabel1.AutoSize = False
        Me.kryptonWrapLabel1.Dock = System.Windows.Forms.DockStyle.Fill
        Me.kryptonWrapLabel1.LabelStyle = Krypton.Toolkit.LabelStyle.TitleControl
        Me.kryptonWrapLabel1.Location = New System.Drawing.Point(0, 0)
        Me.kryptonWrapLabel1.Name = "kryptonWrapLabel1"
        Me.kryptonWrapLabel1.Size = New System.Drawing.Size(481, 64)
        Me.kryptonWrapLabel1.Text = "kryptonWrapLabel1"
        Me.kryptonWrapLabel1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        Me.kbtnClose.DialogResult = System.Windows.Forms.DialogResult.OK
        Me.kbtnClose.Location = New System.Drawing.Point(700, 17)
        Me.kbtnClose.Name = "kbtnClose"
        Me.kbtnClose.Size = New System.Drawing.Size(90, 25)
        Me.kbtnClose.TabIndex = 0
        Me.kbtnClose.Values.DropDownArrowColor = System.Drawing.Color.Empty
        Me.kbtnClose.Values.Text = "C&lose"
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6F, 13F)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.CancelButton = Me.kbtnClose
        Me.ClientSize = New System.Drawing.Size(808, 440)
        Me.Controls.Add(Me.kryptonPanel2)
        Me.Controls.Add(Me.kryptonPanel1)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.Fixed3D
        Me.MaximizeBox = False
        Me.Name = "Form1"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent
        Me.Text = "ToggleSwitch Example"
        CType(Me.kryptonPanel1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.kryptonPanel1.ResumeLayout(False)
        CType(Me.kryptonPanel2, System.ComponentModel.ISupportInitialize).EndInit()
        Me.kryptonPanel2.ResumeLayout(False)
        CType(Me.kryptonGroupBox1.Panel, System.ComponentModel.ISupportInitialize).EndInit()
        Me.kryptonGroupBox1.Panel.ResumeLayout(False)
        CType(Me.kryptonGroupBox1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.kryptonGroupBox1.ResumeLayout(False)
        CType(Me.kryptonGroupBox2.Panel, System.ComponentModel.ISupportInitialize).EndInit()
        Me.kryptonGroupBox2.Panel.ResumeLayout(False)
        CType(Me.kryptonGroupBox2, System.ComponentModel.ISupportInitialize).EndInit()
        Me.kryptonGroupBox2.ResumeLayout(False)
        CType(Me.kryptonPanel3, System.ComponentModel.ISupportInitialize).EndInit()
        Me.kryptonPanel3.ResumeLayout(False)
        CType(Me.kryptonPanel4, System.ComponentModel.ISupportInitialize).EndInit()
        Me.kryptonPanel4.ResumeLayout(False)
        Me.ResumeLayout(False)
    End Sub

    Friend WithEvents kryptonPanel1 As Krypton.Toolkit.KryptonPanel
    Friend WithEvents kryptonPanel2 As Krypton.Toolkit.KryptonPanel
    Friend WithEvents kryptonGroupBox1 As Krypton.Toolkit.KryptonGroupBox
    Friend WithEvents kryptonGroupBox2 As Krypton.Toolkit.KryptonGroupBox
    Friend WithEvents kryptonPropertyGrid1 As Krypton.Toolkit.KryptonPropertyGrid
    Friend WithEvents kryptonPanel3 As Krypton.Toolkit.KryptonPanel
    Friend WithEvents kryptonPanel4 As Krypton.Toolkit.KryptonPanel
    Friend WithEvents ktsTest As Krypton.Toolkit.KryptonToggleSwitch
    Friend WithEvents kryptonWrapLabel1 As Krypton.Toolkit.KryptonWrapLabel
    Friend WithEvents kbtnClose As Krypton.Toolkit.KryptonButton
End Class
