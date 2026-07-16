' VB.NET twin of Source\Krypton Toolkit Examples\KryptonSaveFileDialog Example\Form1.Designer.cs (Bastion Phase 4c).
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
        Me.buttonFileOpenDialog = New Krypton.Toolkit.KryptonButton()
        Me.kryptonPanel1 = New Krypton.Toolkit.KryptonPanel()
        Me.kryptonThemeComboBox1 = New Krypton.Toolkit.KryptonThemeComboBox()
        Me.kryptonLabel1 = New Krypton.Toolkit.KryptonLabel()
        Me.kryptonGroupBox2 = New Krypton.Toolkit.KryptonGroupBox()
        Me.chkRestoreDirectory = New Krypton.Toolkit.KryptonCheckBox()
        Me.chkDereferenceLinks = New Krypton.Toolkit.KryptonCheckBox()
        Me.chkCheckPathExists = New Krypton.Toolkit.KryptonCheckBox()
        Me.chkCheckFileExists = New Krypton.Toolkit.KryptonCheckBox()
        Me.chkAddExtension = New Krypton.Toolkit.KryptonCheckBox()
        Me.kryptonGroupBox1 = New Krypton.Toolkit.KryptonGroupBox()
        Me.kryptonTextBox1 = New Krypton.Toolkit.KryptonTextBox()
        Me.kryptonNumericUpDown1 = New Krypton.Toolkit.KryptonNumericUpDown()
        Me.kryptonButton1 = New Krypton.Toolkit.KryptonButton()
        Me.kryptonCheckBox1 = New Krypton.Toolkit.KryptonCheckBox()
        Me.kryptonListBox1 = New Krypton.Toolkit.KryptonListBox()
        Me.kryptonComboBox1 = New Krypton.Toolkit.KryptonComboBox()
        Me.kryptonCheckBox2 = New Krypton.Toolkit.KryptonCheckBox()
        CType(Me.kryptonPanel1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.kryptonPanel1.SuspendLayout()
        CType(Me.kryptonThemeComboBox1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.kryptonGroupBox2, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.kryptonGroupBox2.Panel, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.kryptonGroupBox2.Panel.SuspendLayout()
        Me.kryptonGroupBox2.SuspendLayout()
        CType(Me.kryptonGroupBox1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.kryptonGroupBox1.Panel, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.kryptonGroupBox1.Panel.SuspendLayout()
        Me.kryptonGroupBox1.SuspendLayout()
        CType(Me.kryptonComboBox1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        Me.buttonFileOpenDialog.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.buttonFileOpenDialog.Location = New System.Drawing.Point(266, 316)
        Me.buttonFileOpenDialog.Name = "buttonFileOpenDialog"
        Me.buttonFileOpenDialog.Size = New System.Drawing.Size(307, 59)
        Me.buttonFileOpenDialog.TabIndex = 19
        Me.buttonFileOpenDialog.Values.DropDownArrowColor = System.Drawing.Color.Empty
        Me.buttonFileOpenDialog.Values.Text = "File Save Dialog"
        Me.kryptonPanel1.Controls.Add(Me.kryptonThemeComboBox1)
        Me.kryptonPanel1.Controls.Add(Me.kryptonLabel1)
        Me.kryptonPanel1.Controls.Add(Me.kryptonGroupBox2)
        Me.kryptonPanel1.Controls.Add(Me.kryptonGroupBox1)
        Me.kryptonPanel1.Controls.Add(Me.buttonFileOpenDialog)
        Me.kryptonPanel1.Dock = System.Windows.Forms.DockStyle.Fill
        Me.kryptonPanel1.Location = New System.Drawing.Point(0, 0)
        Me.kryptonPanel1.Name = "kryptonPanel1"
        Me.kryptonPanel1.Size = New System.Drawing.Size(596, 403)
        Me.kryptonPanel1.TabIndex = 20
        Me.kryptonThemeComboBox1.DefaultPalette = Krypton.Toolkit.PaletteMode.Office2007Blue
        Me.kryptonThemeComboBox1.DisplayMember = "30"
        Me.kryptonThemeComboBox1.DropDownWidth = 339
        Me.kryptonThemeComboBox1.IntegralHeight = False
        Me.kryptonThemeComboBox1.Location = New System.Drawing.Point(12, 58)
        Me.kryptonThemeComboBox1.Name = "kryptonThemeComboBox1"
        Me.kryptonThemeComboBox1.Size = New System.Drawing.Size(339, 26)
        Me.kryptonThemeComboBox1.StateCommon.ComboBox.Content.TextH = Krypton.Toolkit.PaletteRelativeAlign.Near
        Me.kryptonThemeComboBox1.TabIndex = 25
        Me.kryptonThemeComboBox1.ValueMember = "30"
        Me.kryptonLabel1.Location = New System.Drawing.Point(12, 28)
        Me.kryptonLabel1.Name = "kryptonLabel1"
        Me.kryptonLabel1.Size = New System.Drawing.Size(68, 24)
        Me.kryptonLabel1.TabIndex = 24
        Me.kryptonLabel1.Target = Me.kryptonThemeComboBox1
        Me.kryptonLabel1.Values.Text = "&Themes:"
        Me.kryptonGroupBox2.Location = New System.Drawing.Point(372, 28)
        Me.kryptonGroupBox2.Name = "kryptonGroupBox2"
        Me.kryptonGroupBox2.Panel.Controls.Add(Me.chkRestoreDirectory)
        Me.kryptonGroupBox2.Panel.Controls.Add(Me.chkDereferenceLinks)
        Me.kryptonGroupBox2.Panel.Controls.Add(Me.chkCheckPathExists)
        Me.kryptonGroupBox2.Panel.Controls.Add(Me.chkCheckFileExists)
        Me.kryptonGroupBox2.Panel.Controls.Add(Me.chkAddExtension)
        Me.kryptonGroupBox2.Size = New System.Drawing.Size(199, 289)
        Me.kryptonGroupBox2.TabIndex = 21
        Me.kryptonGroupBox2.Values.Heading = "Options:"
        Me.chkRestoreDirectory.Checked = True
        Me.chkRestoreDirectory.CheckState = System.Windows.Forms.CheckState.Checked
        Me.chkRestoreDirectory.Location = New System.Drawing.Point(4, 180)
        Me.chkRestoreDirectory.Name = "chkRestoreDirectory"
        Me.chkRestoreDirectory.Size = New System.Drawing.Size(143, 24)
        Me.chkRestoreDirectory.TabIndex = 6
        Me.chkRestoreDirectory.Values.Text = "Restore Directory"
        Me.chkDereferenceLinks.Location = New System.Drawing.Point(4, 90)
        Me.chkDereferenceLinks.Name = "chkDereferenceLinks"
        Me.chkDereferenceLinks.Size = New System.Drawing.Size(145, 24)
        Me.chkDereferenceLinks.TabIndex = 3
        Me.chkDereferenceLinks.Values.Text = "Dereference Links"
        Me.chkCheckPathExists.Location = New System.Drawing.Point(3, 60)
        Me.chkCheckPathExists.Name = "chkCheckPathExists"
        Me.chkCheckPathExists.Size = New System.Drawing.Size(142, 24)
        Me.chkCheckPathExists.TabIndex = 2
        Me.chkCheckPathExists.Values.Text = "Check Path Exists"
        Me.chkCheckFileExists.Checked = True
        Me.chkCheckFileExists.CheckState = System.Windows.Forms.CheckState.Checked
        Me.chkCheckFileExists.Location = New System.Drawing.Point(4, 30)
        Me.chkCheckFileExists.Name = "chkCheckFileExists"
        Me.chkCheckFileExists.Size = New System.Drawing.Size(134, 24)
        Me.chkCheckFileExists.TabIndex = 1
        Me.chkCheckFileExists.Values.Text = "Check File Exists"
        Me.chkAddExtension.Location = New System.Drawing.Point(4, 0)
        Me.chkAddExtension.Name = "chkAddExtension"
        Me.chkAddExtension.Size = New System.Drawing.Size(122, 24)
        Me.chkAddExtension.TabIndex = 0
        Me.chkAddExtension.Values.Text = "Add Extension"
        Me.kryptonGroupBox1.Location = New System.Drawing.Point(12, 153)
        Me.kryptonGroupBox1.Name = "kryptonGroupBox1"
        Me.kryptonGroupBox1.Panel.Controls.Add(Me.kryptonTextBox1)
        Me.kryptonGroupBox1.Panel.Controls.Add(Me.kryptonNumericUpDown1)
        Me.kryptonGroupBox1.Panel.Controls.Add(Me.kryptonButton1)
        Me.kryptonGroupBox1.Panel.Controls.Add(Me.kryptonCheckBox1)
        Me.kryptonGroupBox1.Panel.Controls.Add(Me.kryptonListBox1)
        Me.kryptonGroupBox1.Panel.Controls.Add(Me.kryptonComboBox1)
        Me.kryptonGroupBox1.Size = New System.Drawing.Size(348, 164)
        Me.kryptonGroupBox1.TabIndex = 20
        Me.kryptonGroupBox1.Values.Heading = "Style to match:"
        Me.kryptonTextBox1.Location = New System.Drawing.Point(156, 29)
        Me.kryptonTextBox1.Name = "kryptonTextBox1"
        Me.kryptonTextBox1.Size = New System.Drawing.Size(134, 27)
        Me.kryptonTextBox1.TabIndex = 6
        Me.kryptonTextBox1.Text = "kryptonTextBox1"
        Me.kryptonNumericUpDown1.Increment = New Decimal(New Integer() { 1, 0, 0, 0})
        Me.kryptonNumericUpDown1.Location = New System.Drawing.Point(156, 97)
        Me.kryptonNumericUpDown1.Maximum = New Decimal(New Integer() { 100, 0, 0, 0})
        Me.kryptonNumericUpDown1.Minimum = New Decimal(New Integer() { 0, 0, 0, 0})
        Me.kryptonNumericUpDown1.Name = "kryptonNumericUpDown1"
        Me.kryptonNumericUpDown1.Size = New System.Drawing.Size(90, 26)
        Me.kryptonNumericUpDown1.TabIndex = 5
        Me.kryptonNumericUpDown1.Value = New Decimal(New Integer() { 0, 0, 0, 0})
        Me.kryptonButton1.Location = New System.Drawing.Point(156, 65)
        Me.kryptonButton1.Name = "kryptonButton1"
        Me.kryptonButton1.Size = New System.Drawing.Size(90, 25)
        Me.kryptonButton1.TabIndex = 4
        Me.kryptonButton1.Values.DropDownArrowColor = System.Drawing.Color.Empty
        Me.kryptonButton1.Values.Text = "kryptonButton1"
        Me.kryptonCheckBox1.Location = New System.Drawing.Point(156, 4)
        Me.kryptonCheckBox1.Name = "kryptonCheckBox1"
        Me.kryptonCheckBox1.Size = New System.Drawing.Size(152, 24)
        Me.kryptonCheckBox1.TabIndex = 2
        Me.kryptonCheckBox1.Values.Text = "kryptonCheckBox1"
        Me.kryptonListBox1.Items.AddRange(New Object() { "Font 1", "Font 2", "Font 1Font 1Font 1Font 1"})
        Me.kryptonListBox1.Location = New System.Drawing.Point(4, 29)
        Me.kryptonListBox1.Name = "kryptonListBox1"
        Me.kryptonListBox1.Size = New System.Drawing.Size(120, 96)
        Me.kryptonListBox1.TabIndex = 1
        Me.kryptonComboBox1.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.kryptonComboBox1.DropDownWidth = 121
        Me.kryptonComboBox1.IntegralHeight = False
        Me.kryptonComboBox1.Items.AddRange(New Object() { "Microsoft Sans Serif"})
        Me.kryptonComboBox1.Location = New System.Drawing.Point(4, 4)
        Me.kryptonComboBox1.Name = "kryptonComboBox1"
        Me.kryptonComboBox1.Size = New System.Drawing.Size(146, 26)
        Me.kryptonComboBox1.StateCommon.ComboBox.Content.TextH = Krypton.Toolkit.PaletteRelativeAlign.Near
        Me.kryptonComboBox1.TabIndex = 0
        Me.kryptonComboBox1.Text = "Microsoft Sans Serif"
        Me.kryptonCheckBox2.Checked = True
        Me.kryptonCheckBox2.CheckState = System.Windows.Forms.CheckState.Checked
        Me.kryptonCheckBox2.Location = New System.Drawing.Point(4, 180)
        Me.kryptonCheckBox2.Name = "kryptonCheckBox2"
        Me.kryptonCheckBox2.Size = New System.Drawing.Size(143, 24)
        Me.kryptonCheckBox2.TabIndex = 6
        Me.kryptonCheckBox2.Values.Text = "Restore Directory"
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8F, 16F)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(596, 403)
        Me.Controls.Add(Me.kryptonPanel1)
        Me.FormTitleAlign = Krypton.Toolkit.PaletteRelativeAlign.Inherit
        Me.Name = "Form1"
        Me.SizeGripStyle = System.Windows.Forms.SizeGripStyle.Show
        Me.Text = "KryptonSaveFileDialog Example"
        CType(Me.kryptonPanel1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.kryptonPanel1.ResumeLayout(False)
        Me.kryptonPanel1.PerformLayout()
        CType(Me.kryptonThemeComboBox1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.kryptonGroupBox2.Panel, System.ComponentModel.ISupportInitialize).EndInit()
        Me.kryptonGroupBox2.Panel.ResumeLayout(False)
        Me.kryptonGroupBox2.Panel.PerformLayout()
        CType(Me.kryptonGroupBox2, System.ComponentModel.ISupportInitialize).EndInit()
        Me.kryptonGroupBox2.ResumeLayout(False)
        CType(Me.kryptonGroupBox1.Panel, System.ComponentModel.ISupportInitialize).EndInit()
        Me.kryptonGroupBox1.Panel.ResumeLayout(False)
        Me.kryptonGroupBox1.Panel.PerformLayout()
        CType(Me.kryptonGroupBox1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.kryptonGroupBox1.ResumeLayout(False)
        CType(Me.kryptonComboBox1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
    End Sub

    Friend WithEvents buttonFileOpenDialog As Krypton.Toolkit.KryptonButton
    Friend WithEvents kryptonPanel1 As Krypton.Toolkit.KryptonPanel
    Friend WithEvents kryptonGroupBox1 As Krypton.Toolkit.KryptonGroupBox
    Friend WithEvents kryptonGroupBox2 As Krypton.Toolkit.KryptonGroupBox
    Friend WithEvents chkAddExtension As Krypton.Toolkit.KryptonCheckBox
    Friend WithEvents chkCheckFileExists As Krypton.Toolkit.KryptonCheckBox
    Friend WithEvents chkRestoreDirectory As Krypton.Toolkit.KryptonCheckBox
    Friend WithEvents chkDereferenceLinks As Krypton.Toolkit.KryptonCheckBox
    Friend WithEvents chkCheckPathExists As Krypton.Toolkit.KryptonCheckBox
    Friend WithEvents kryptonListBox1 As Krypton.Toolkit.KryptonListBox
    Friend WithEvents kryptonComboBox1 As Krypton.Toolkit.KryptonComboBox
    Friend WithEvents kryptonCheckBox1 As Krypton.Toolkit.KryptonCheckBox
    Friend WithEvents kryptonTextBox1 As Krypton.Toolkit.KryptonTextBox
    Friend WithEvents kryptonButton1 As Krypton.Toolkit.KryptonButton
    Friend WithEvents kryptonNumericUpDown1 As Krypton.Toolkit.KryptonNumericUpDown
    Friend WithEvents kryptonThemeComboBox1 As Krypton.Toolkit.KryptonThemeComboBox
    Friend WithEvents kryptonLabel1 As Krypton.Toolkit.KryptonLabel
    Friend WithEvents kryptonCheckBox2 As Krypton.Toolkit.KryptonCheckBox
End Class
