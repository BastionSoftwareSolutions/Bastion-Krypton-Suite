' VB.NET twin of Source\Krypton Docking Examples\Docking Persistence\ContentInput.Designer.cs (Bastion Phase 4c).
<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class ContentInput
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
        Me.kryptonButton1 = New Krypton.Toolkit.KryptonButton()
        Me.kryptonNumericUpDown1 = New Krypton.Toolkit.KryptonNumericUpDown()
        Me.kryptonLabel3 = New Krypton.Toolkit.KryptonLabel()
        Me.kryptonTextBox2 = New Krypton.Toolkit.KryptonTextBox()
        Me.kryptonLabel2 = New Krypton.Toolkit.KryptonLabel()
        Me.kryptonTextBox1 = New Krypton.Toolkit.KryptonTextBox()
        Me.kryptonLabel1 = New Krypton.Toolkit.KryptonLabel()
        Me.kryptonThemeComboBox1 = New Krypton.Toolkit.KryptonThemeComboBox()
        CType(Me.kryptonPanel, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.kryptonPanel.SuspendLayout()
        CType(Me.kryptonThemeComboBox1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        Me.kryptonPanel.Controls.Add(Me.kryptonThemeComboBox1)
        Me.kryptonPanel.Controls.Add(Me.kryptonButton1)
        Me.kryptonPanel.Controls.Add(Me.kryptonNumericUpDown1)
        Me.kryptonPanel.Controls.Add(Me.kryptonLabel3)
        Me.kryptonPanel.Controls.Add(Me.kryptonTextBox2)
        Me.kryptonPanel.Controls.Add(Me.kryptonLabel2)
        Me.kryptonPanel.Controls.Add(Me.kryptonTextBox1)
        Me.kryptonPanel.Controls.Add(Me.kryptonLabel1)
        Me.kryptonPanel.Dock = System.Windows.Forms.DockStyle.Fill
        Me.kryptonPanel.Location = New System.Drawing.Point(0, 0)
        Me.kryptonPanel.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.kryptonPanel.Name = "kryptonPanel"
        Me.kryptonPanel.PanelBackStyle = Krypton.Toolkit.PaletteBackStyle.ControlClient
        Me.kryptonPanel.Size = New System.Drawing.Size(772, 190)
        Me.kryptonPanel.TabIndex = 0
        Me.kryptonButton1.Location = New System.Drawing.Point(113, 128)
        Me.kryptonButton1.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.kryptonButton1.Name = "kryptonButton1"
        Me.kryptonButton1.Size = New System.Drawing.Size(108, 31)
        Me.kryptonButton1.TabIndex = 6
        Me.kryptonButton1.Values.DropDownArrowColor = System.Drawing.Color.Empty
        Me.kryptonButton1.Values.Text = "Update"
        Me.kryptonNumericUpDown1.Increment = New Decimal(New Integer() { 1, 0, 0, 0})
        Me.kryptonNumericUpDown1.Location = New System.Drawing.Point(113, 81)
        Me.kryptonNumericUpDown1.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.kryptonNumericUpDown1.Maximum = New Decimal(New Integer() { 100, 0, 0, 0})
        Me.kryptonNumericUpDown1.Minimum = New Decimal(New Integer() { 0, 0, 0, 0})
        Me.kryptonNumericUpDown1.Name = "kryptonNumericUpDown1"
        Me.kryptonNumericUpDown1.Size = New System.Drawing.Size(108, 26)
        Me.kryptonNumericUpDown1.TabIndex = 5
        Me.kryptonNumericUpDown1.Value = New Decimal(New Integer() { 31, 0, 0, 0})
        Me.kryptonLabel3.Location = New System.Drawing.Point(60, 81)
        Me.kryptonLabel3.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.kryptonLabel3.Name = "kryptonLabel3"
        Me.kryptonLabel3.Size = New System.Drawing.Size(39, 24)
        Me.kryptonLabel3.TabIndex = 4
        Me.kryptonLabel3.Values.Text = "Age"
        Me.kryptonTextBox2.Location = New System.Drawing.Point(113, 49)
        Me.kryptonTextBox2.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.kryptonTextBox2.Name = "kryptonTextBox2"
        Me.kryptonTextBox2.Size = New System.Drawing.Size(108, 27)
        Me.kryptonTextBox2.TabIndex = 3
        Me.kryptonTextBox2.Text = "Doe"
        Me.kryptonLabel2.Location = New System.Drawing.Point(15, 49)
        Me.kryptonLabel2.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.kryptonLabel2.Name = "kryptonLabel2"
        Me.kryptonLabel2.Size = New System.Drawing.Size(83, 24)
        Me.kryptonLabel2.TabIndex = 2
        Me.kryptonLabel2.Values.Text = "Last Name"
        Me.kryptonTextBox1.Location = New System.Drawing.Point(113, 17)
        Me.kryptonTextBox1.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.kryptonTextBox1.Name = "kryptonTextBox1"
        Me.kryptonTextBox1.Size = New System.Drawing.Size(108, 27)
        Me.kryptonTextBox1.TabIndex = 1
        Me.kryptonTextBox1.Text = "John"
        Me.kryptonLabel1.Location = New System.Drawing.Point(13, 17)
        Me.kryptonLabel1.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.kryptonLabel1.Name = "kryptonLabel1"
        Me.kryptonLabel1.Size = New System.Drawing.Size(85, 24)
        Me.kryptonLabel1.TabIndex = 0
        Me.kryptonLabel1.Values.Text = "First Name"
        Me.kryptonThemeComboBox1.DefaultPalette = Krypton.Toolkit.PaletteMode.Office2010Blue
        Me.kryptonThemeComboBox1.DropDownWidth = 433
        Me.kryptonThemeComboBox1.IntegralHeight = False
        Me.kryptonThemeComboBox1.Location = New System.Drawing.Point(276, 18)
        Me.kryptonThemeComboBox1.Name = "kryptonThemeComboBox1"
        Me.kryptonThemeComboBox1.Size = New System.Drawing.Size(433, 26)
        Me.kryptonThemeComboBox1.StateCommon.ComboBox.Content.TextH = Krypton.Toolkit.PaletteRelativeAlign.Near
        Me.kryptonThemeComboBox1.TabIndex = 8
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8F, 16F)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.Controls.Add(Me.kryptonPanel)
        Me.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.Name = "ContentInput"
        Me.Size = New System.Drawing.Size(772, 190)
        CType(Me.kryptonPanel, System.ComponentModel.ISupportInitialize).EndInit()
        Me.kryptonPanel.ResumeLayout(False)
        Me.kryptonPanel.PerformLayout()
        CType(Me.kryptonThemeComboBox1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
    End Sub

    Friend WithEvents kryptonPanel As Krypton.Toolkit.KryptonPanel
    Friend WithEvents kryptonButton1 As Krypton.Toolkit.KryptonButton
    Friend WithEvents kryptonNumericUpDown1 As Krypton.Toolkit.KryptonNumericUpDown
    Friend WithEvents kryptonLabel3 As Krypton.Toolkit.KryptonLabel
    Friend WithEvents kryptonTextBox2 As Krypton.Toolkit.KryptonTextBox
    Friend WithEvents kryptonLabel2 As Krypton.Toolkit.KryptonLabel
    Friend WithEvents kryptonTextBox1 As Krypton.Toolkit.KryptonTextBox
    Friend WithEvents kryptonLabel1 As Krypton.Toolkit.KryptonLabel
    Friend WithEvents kryptonThemeComboBox1 As Krypton.Toolkit.KryptonThemeComboBox
End Class
