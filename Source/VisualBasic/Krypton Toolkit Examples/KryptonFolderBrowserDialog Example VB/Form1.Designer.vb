' VB.NET twin of Source\Krypton Toolkit Examples\KryptonFolderBrowserDialog Example\Form1.Designer.cs (Bastion Phase 4c).

<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class Form1
    Inherits Krypton.Toolkit.KryptonForm

    ''' <summary>
    '''  Required designer variable.
    ''' </summary>
    Private components As System.ComponentModel.IContainer

    ''' <summary>
    '''  Clean up any resources being used.
    ''' </summary>
    ''' <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
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

#Region "Windows Form Designer generated code"

    ''' <summary>
    '''  Required method for Designer support - do not modify
    '''  the contents of this method with the code editor.
    ''' </summary>
    <System.Diagnostics.DebuggerStepThrough()>
    Private Sub InitializeComponent()

        Me.buttonFileOpenDialog = New Krypton.Toolkit.KryptonButton()
        Me.kryptonPanel1 = New Krypton.Toolkit.KryptonPanel()
        Me.kryptonThemeComboBox1 = New Krypton.Toolkit.KryptonThemeComboBox()
        Me.kryptonLabel1 = New Krypton.Toolkit.KryptonLabel()
        Me.kryptonGroupBox2 = New Krypton.Toolkit.KryptonGroupBox()
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
        Me.kryptonGroupBox2.SuspendLayout()
        CType(Me.kryptonGroupBox1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.kryptonGroupBox1.Panel, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.kryptonGroupBox1.Panel.SuspendLayout()
        Me.kryptonGroupBox1.SuspendLayout()
        CType(Me.kryptonComboBox1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        ' buttonFileOpenDialog
        '
        Me.buttonFileOpenDialog.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.buttonFileOpenDialog.Location = New System.Drawing.Point(264, 327)
        Me.buttonFileOpenDialog.Name = "buttonFileOpenDialog"
        Me.buttonFileOpenDialog.Size = New System.Drawing.Size(307, 54)
        Me.buttonFileOpenDialog.TabIndex = 19
        Me.buttonFileOpenDialog.Values.DropDownArrowColor = System.Drawing.Color.Empty
        Me.buttonFileOpenDialog.Values.Text = "Folder Browser Dialog"
        '
        ' kryptonPanel1
        '
        Me.kryptonPanel1.Controls.Add(Me.kryptonThemeComboBox1)
        Me.kryptonPanel1.Controls.Add(Me.kryptonLabel1)
        Me.kryptonPanel1.Controls.Add(Me.kryptonGroupBox2)
        Me.kryptonPanel1.Controls.Add(Me.kryptonGroupBox1)
        Me.kryptonPanel1.Controls.Add(Me.buttonFileOpenDialog)
        Me.kryptonPanel1.Dock = System.Windows.Forms.DockStyle.Fill
        Me.kryptonPanel1.Location = New System.Drawing.Point(0, 0)
        Me.kryptonPanel1.Name = "kryptonPanel1"
        Me.kryptonPanel1.Size = New System.Drawing.Size(600, 389)
        Me.kryptonPanel1.TabIndex = 20
        '
        ' kryptonThemeComboBox1
        '
        Me.kryptonThemeComboBox1.DefaultPalette = Krypton.Toolkit.PaletteMode.Office2010Blue
        Me.kryptonThemeComboBox1.DisplayMember = "30"
        Me.kryptonThemeComboBox1.DropDownWidth = 339
        Me.kryptonThemeComboBox1.IntegralHeight = False
        Me.kryptonThemeComboBox1.Location = New System.Drawing.Point(12, 58)
        Me.kryptonThemeComboBox1.Name = "kryptonThemeComboBox1"
        Me.kryptonThemeComboBox1.Size = New System.Drawing.Size(339, 26)
        Me.kryptonThemeComboBox1.StateCommon.ComboBox.Content.TextH = Krypton.Toolkit.PaletteRelativeAlign.Near
        Me.kryptonThemeComboBox1.TabIndex = 25
        Me.kryptonThemeComboBox1.ValueMember = "30"
        '
        ' kryptonLabel1
        '
        Me.kryptonLabel1.Location = New System.Drawing.Point(12, 28)
        Me.kryptonLabel1.Name = "kryptonLabel1"
        Me.kryptonLabel1.Size = New System.Drawing.Size(68, 24)
        Me.kryptonLabel1.TabIndex = 24
        Me.kryptonLabel1.Target = Me.kryptonThemeComboBox1
        Me.kryptonLabel1.Values.Text = "&Themes:"
        '
        ' kryptonGroupBox2
        '
        Me.kryptonGroupBox2.Location = New System.Drawing.Point(372, 28)
        Me.kryptonGroupBox2.Size = New System.Drawing.Size(199, 290)
        Me.kryptonGroupBox2.TabIndex = 21
        Me.kryptonGroupBox2.Values.Heading = "Options:"
        '
        ' kryptonGroupBox1
        '
        Me.kryptonGroupBox1.Location = New System.Drawing.Point(12, 153)
        '
        ' kryptonGroupBox1.Panel
        '
        Me.kryptonGroupBox1.Panel.Controls.Add(Me.kryptonTextBox1)
        Me.kryptonGroupBox1.Panel.Controls.Add(Me.kryptonNumericUpDown1)
        Me.kryptonGroupBox1.Panel.Controls.Add(Me.kryptonButton1)
        Me.kryptonGroupBox1.Panel.Controls.Add(Me.kryptonCheckBox1)
        Me.kryptonGroupBox1.Panel.Controls.Add(Me.kryptonListBox1)
        Me.kryptonGroupBox1.Panel.Controls.Add(Me.kryptonComboBox1)
        Me.kryptonGroupBox1.Size = New System.Drawing.Size(348, 164)
        Me.kryptonGroupBox1.TabIndex = 20
        Me.kryptonGroupBox1.Values.Heading = "Style to match:"
        '
        ' kryptonTextBox1
        '
        Me.kryptonTextBox1.Location = New System.Drawing.Point(156, 29)
        Me.kryptonTextBox1.Name = "kryptonTextBox1"
        Me.kryptonTextBox1.Size = New System.Drawing.Size(134, 27)
        Me.kryptonTextBox1.TabIndex = 6
        Me.kryptonTextBox1.Text = "kryptonTextBox1"
        '
        ' kryptonNumericUpDown1
        '
        Me.kryptonNumericUpDown1.Increment = New Decimal(New Integer() { 1, 0, 0, 0})
        Me.kryptonNumericUpDown1.Location = New System.Drawing.Point(156, 98)
        Me.kryptonNumericUpDown1.Maximum = New Decimal(New Integer() { 100, 0, 0, 0})
        Me.kryptonNumericUpDown1.Minimum = New Decimal(New Integer() { 0, 0, 0, 0})
        Me.kryptonNumericUpDown1.Name = "kryptonNumericUpDown1"
        Me.kryptonNumericUpDown1.Size = New System.Drawing.Size(90, 26)
        Me.kryptonNumericUpDown1.TabIndex = 5
        Me.kryptonNumericUpDown1.Value = New Decimal(New Integer() { 0, 0, 0, 0})
        '
        ' kryptonButton1
        '
        Me.kryptonButton1.Location = New System.Drawing.Point(156, 66)
        Me.kryptonButton1.Name = "kryptonButton1"
        Me.kryptonButton1.Size = New System.Drawing.Size(134, 25)
        Me.kryptonButton1.TabIndex = 4
        Me.kryptonButton1.Values.DropDownArrowColor = System.Drawing.Color.Empty
        Me.kryptonButton1.Values.Text = "kryptonButton1"
        '
        ' kryptonCheckBox1
        '
        Me.kryptonCheckBox1.Location = New System.Drawing.Point(156, 4)
        Me.kryptonCheckBox1.Name = "kryptonCheckBox1"
        Me.kryptonCheckBox1.Size = New System.Drawing.Size(152, 24)
        Me.kryptonCheckBox1.TabIndex = 2
        Me.kryptonCheckBox1.Values.Text = "kryptonCheckBox1"
        '
        ' kryptonListBox1
        '
        Me.kryptonListBox1.Items.AddRange(New Object() { "Font 1", "Font 2", "Font 1Font 1Font 1Font 1"})
        Me.kryptonListBox1.Location = New System.Drawing.Point(4, 29)
        Me.kryptonListBox1.Name = "kryptonListBox1"
        Me.kryptonListBox1.Padding = New System.Windows.Forms.Padding(1, 2, 1, 2)
        Me.kryptonListBox1.Size = New System.Drawing.Size(120, 96)
        Me.kryptonListBox1.TabIndex = 1
        '
        ' kryptonComboBox1
        '
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
        '
        ' kryptonCheckBox2
        '
        Me.kryptonCheckBox2.Checked = True
        Me.kryptonCheckBox2.CheckState = System.Windows.Forms.CheckState.Checked
        Me.kryptonCheckBox2.Location = New System.Drawing.Point(4, 180)
        Me.kryptonCheckBox2.Name = "kryptonCheckBox2"
        Me.kryptonCheckBox2.Size = New System.Drawing.Size(143, 24)
        Me.kryptonCheckBox2.TabIndex = 6
        Me.kryptonCheckBox2.Values.Text = "Restore Directory"
        '
        ' Form1
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 16.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(600, 389)
        Me.Controls.Add(Me.kryptonPanel1)
        Me.FormTitleAlign = Krypton.Toolkit.PaletteRelativeAlign.Inherit
        Me.Name = "Form1"
        Me.SizeGripStyle = System.Windows.Forms.SizeGripStyle.Show
        Me.Text = "KryptonFolderBrowserDialog Example"
        CType(Me.kryptonPanel1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.kryptonPanel1.ResumeLayout(False)
        Me.kryptonPanel1.PerformLayout()
        CType(Me.kryptonThemeComboBox1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.kryptonGroupBox2.Panel, System.ComponentModel.ISupportInitialize).EndInit()
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

#End Region

    Private WithEvents buttonFileOpenDialog As Krypton.Toolkit.KryptonButton
    Private WithEvents kryptonPanel1 As Krypton.Toolkit.KryptonPanel
    Private WithEvents kryptonGroupBox1 As Krypton.Toolkit.KryptonGroupBox
    Private WithEvents kryptonGroupBox2 As Krypton.Toolkit.KryptonGroupBox
    Private WithEvents kryptonListBox1 As Krypton.Toolkit.KryptonListBox
    Private WithEvents kryptonComboBox1 As Krypton.Toolkit.KryptonComboBox
    Private WithEvents kryptonCheckBox1 As Krypton.Toolkit.KryptonCheckBox
    Private WithEvents kryptonTextBox1 As Krypton.Toolkit.KryptonTextBox
    Private WithEvents kryptonButton1 As Krypton.Toolkit.KryptonButton
    Private WithEvents kryptonNumericUpDown1 As Krypton.Toolkit.KryptonNumericUpDown
    Private WithEvents kryptonThemeComboBox1 As Krypton.Toolkit.KryptonThemeComboBox
    Private WithEvents kryptonLabel1 As Krypton.Toolkit.KryptonLabel
    Private WithEvents kryptonCheckBox2 As Krypton.Toolkit.KryptonCheckBox

End Class
