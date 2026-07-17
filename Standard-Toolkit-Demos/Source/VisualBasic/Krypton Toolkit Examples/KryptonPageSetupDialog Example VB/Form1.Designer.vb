' VB.NET twin of Source\Krypton Toolkit Examples\KryptonPageSetupDialog Example\Form1.Designer.cs (Bastion Phase 4c).
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
        Me.groupBoxPalette = New Krypton.Toolkit.KryptonGroupBox()
        Me.kryptonThemeComboBox1 = New Krypton.Toolkit.KryptonThemeComboBox()
        Me.buttonShowFontDialog = New Krypton.Toolkit.KryptonButton()
        Me.kryptonPanel1 = New Krypton.Toolkit.KryptonPanel()
        Me.kryptonGroupBox2 = New Krypton.Toolkit.KryptonGroupBox()
        Me.chkShowEffects = New Krypton.Toolkit.KryptonCheckBox()
        Me.chkShowApply = New Krypton.Toolkit.KryptonCheckBox()
        Me.chkAllowVectorFonts = New Krypton.Toolkit.KryptonCheckBox()
        Me.chkAllowSimulations = New Krypton.Toolkit.KryptonCheckBox()
        Me.chkAllowScriptChange = New Krypton.Toolkit.KryptonCheckBox()
        Me.chkShowColour = New Krypton.Toolkit.KryptonCheckBox()
        Me.chkShowHelp = New Krypton.Toolkit.KryptonCheckBox()
        Me.kryptonGroupBox1 = New Krypton.Toolkit.KryptonGroupBox()
        Me.kryptonTextBox1 = New Krypton.Toolkit.KryptonTextBox()
        Me.kryptonNumericUpDown1 = New Krypton.Toolkit.KryptonNumericUpDown()
        Me.kryptonButton1 = New Krypton.Toolkit.KryptonButton()
        Me.kryptonCheckBox1 = New Krypton.Toolkit.KryptonCheckBox()
        Me.kryptonListBox1 = New Krypton.Toolkit.KryptonListBox()
        Me.kryptonComboBox1 = New Krypton.Toolkit.KryptonComboBox()
        CType(Me.groupBoxPalette, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.groupBoxPalette.Panel, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.groupBoxPalette.Panel.SuspendLayout()
        Me.groupBoxPalette.SuspendLayout()
        CType(Me.kryptonThemeComboBox1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.kryptonPanel1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.kryptonPanel1.SuspendLayout()
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
        Me.groupBoxPalette.Location = New System.Drawing.Point(12, 12)
        Me.groupBoxPalette.Name = "groupBoxPalette"
        Me.groupBoxPalette.Panel.Controls.Add(Me.kryptonThemeComboBox1)
        Me.groupBoxPalette.Size = New System.Drawing.Size(353, 135)
        Me.groupBoxPalette.TabIndex = 18
        Me.groupBoxPalette.Values.Heading = "Palette"
        Me.kryptonThemeComboBox1.DefaultPalette = Krypton.Toolkit.PaletteMode.Microsoft365Blue
        Me.kryptonThemeComboBox1.DisplayMember = "Key"
        Me.kryptonThemeComboBox1.DropDownWidth = 293
        Me.kryptonThemeComboBox1.IntegralHeight = False
        Me.kryptonThemeComboBox1.Location = New System.Drawing.Point(15, 16)
        Me.kryptonThemeComboBox1.Name = "kryptonThemeComboBox1"
        Me.kryptonThemeComboBox1.Size = New System.Drawing.Size(320, 26)
        Me.kryptonThemeComboBox1.StateCommon.ComboBox.Content.TextH = Krypton.Toolkit.PaletteRelativeAlign.Near
        Me.kryptonThemeComboBox1.TabIndex = 17
        Me.kryptonThemeComboBox1.ValueMember = "Value"
        Me.buttonShowFontDialog.Location = New System.Drawing.Point(264, 323)
        Me.buttonShowFontDialog.Name = "buttonShowFontDialog"
        Me.buttonShowFontDialog.Size = New System.Drawing.Size(307, 59)
        Me.buttonShowFontDialog.TabIndex = 19
        Me.buttonShowFontDialog.Values.DropDownArrowColor = System.Drawing.Color.Empty
        Me.buttonShowFontDialog.Values.Text = "Show FontDialog"
        Me.kryptonPanel1.Controls.Add(Me.kryptonGroupBox2)
        Me.kryptonPanel1.Controls.Add(Me.kryptonGroupBox1)
        Me.kryptonPanel1.Controls.Add(Me.groupBoxPalette)
        Me.kryptonPanel1.Controls.Add(Me.buttonShowFontDialog)
        Me.kryptonPanel1.Dock = System.Windows.Forms.DockStyle.Fill
        Me.kryptonPanel1.Location = New System.Drawing.Point(0, 0)
        Me.kryptonPanel1.Name = "kryptonPanel1"
        Me.kryptonPanel1.Size = New System.Drawing.Size(614, 412)
        Me.kryptonPanel1.TabIndex = 20
        Me.kryptonGroupBox2.Location = New System.Drawing.Point(372, 28)
        Me.kryptonGroupBox2.Name = "kryptonGroupBox2"
        Me.kryptonGroupBox2.Panel.Controls.Add(Me.chkShowEffects)
        Me.kryptonGroupBox2.Panel.Controls.Add(Me.chkShowApply)
        Me.kryptonGroupBox2.Panel.Controls.Add(Me.chkAllowVectorFonts)
        Me.kryptonGroupBox2.Panel.Controls.Add(Me.chkAllowSimulations)
        Me.kryptonGroupBox2.Panel.Controls.Add(Me.chkAllowScriptChange)
        Me.kryptonGroupBox2.Panel.Controls.Add(Me.chkShowColour)
        Me.kryptonGroupBox2.Panel.Controls.Add(Me.chkShowHelp)
        Me.kryptonGroupBox2.Size = New System.Drawing.Size(199, 289)
        Me.kryptonGroupBox2.TabIndex = 21
        Me.kryptonGroupBox2.Values.Heading = "Options:"
        Me.chkShowEffects.Checked = True
        Me.chkShowEffects.CheckState = System.Windows.Forms.CheckState.Checked
        Me.chkShowEffects.Location = New System.Drawing.Point(4, 180)
        Me.chkShowEffects.Name = "chkShowEffects"
        Me.chkShowEffects.Size = New System.Drawing.Size(110, 24)
        Me.chkShowEffects.TabIndex = 6
        Me.chkShowEffects.Values.Text = "Show Effects"
        Me.chkShowApply.Location = New System.Drawing.Point(4, 150)
        Me.chkShowApply.Name = "chkShowApply"
        Me.chkShowApply.Size = New System.Drawing.Size(105, 24)
        Me.chkShowApply.TabIndex = 5
        Me.chkShowApply.Values.Text = "Show Apply"
        Me.chkAllowVectorFonts.Location = New System.Drawing.Point(4, 120)
        Me.chkAllowVectorFonts.Name = "chkAllowVectorFonts"
        Me.chkAllowVectorFonts.Size = New System.Drawing.Size(152, 24)
        Me.chkAllowVectorFonts.TabIndex = 4
        Me.chkAllowVectorFonts.Values.Text = "Allow Vector Fonts"
        Me.chkAllowSimulations.Location = New System.Drawing.Point(4, 90)
        Me.chkAllowSimulations.Name = "chkAllowSimulations"
        Me.chkAllowSimulations.Size = New System.Drawing.Size(145, 24)
        Me.chkAllowSimulations.TabIndex = 3
        Me.chkAllowSimulations.Values.Text = "Allow Simulations"
        Me.chkAllowScriptChange.Location = New System.Drawing.Point(3, 60)
        Me.chkAllowScriptChange.Name = "chkAllowScriptChange"
        Me.chkAllowScriptChange.Size = New System.Drawing.Size(161, 24)
        Me.chkAllowScriptChange.TabIndex = 2
        Me.chkAllowScriptChange.Values.Text = "Allow Script Change"
        Me.chkShowColour.Checked = True
        Me.chkShowColour.CheckState = System.Windows.Forms.CheckState.Checked
        Me.chkShowColour.Location = New System.Drawing.Point(4, 30)
        Me.chkShowColour.Name = "chkShowColour"
        Me.chkShowColour.Size = New System.Drawing.Size(111, 24)
        Me.chkShowColour.TabIndex = 1
        Me.chkShowColour.Values.Text = "Show Colour"
        Me.chkShowHelp.Location = New System.Drawing.Point(4, 0)
        Me.chkShowHelp.Name = "chkShowHelp"
        Me.chkShowHelp.Size = New System.Drawing.Size(98, 24)
        Me.chkShowHelp.TabIndex = 0
        Me.chkShowHelp.Values.Text = "Show Help"
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
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8F, 16F)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(614, 412)
        Me.Controls.Add(Me.kryptonPanel1)
        Me.Name = "Form1"
        Me.Text = "KryptonFontDialog Example"
        Me.UseThemeFormChromeBorderWidth = False
        CType(Me.groupBoxPalette.Panel, System.ComponentModel.ISupportInitialize).EndInit()
        Me.groupBoxPalette.Panel.ResumeLayout(False)
        CType(Me.groupBoxPalette, System.ComponentModel.ISupportInitialize).EndInit()
        Me.groupBoxPalette.ResumeLayout(False)
        CType(Me.kryptonThemeComboBox1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.kryptonPanel1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.kryptonPanel1.ResumeLayout(False)
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

    Friend WithEvents groupBoxPalette As Krypton.Toolkit.KryptonGroupBox
    Friend WithEvents buttonShowFontDialog As Krypton.Toolkit.KryptonButton
    Friend WithEvents kryptonPanel1 As Krypton.Toolkit.KryptonPanel
    Friend WithEvents kryptonGroupBox1 As Krypton.Toolkit.KryptonGroupBox
    Friend WithEvents kryptonNumericUpDown1 As Krypton.Toolkit.KryptonNumericUpDown
    Friend WithEvents kryptonButton1 As Krypton.Toolkit.KryptonButton
    Friend WithEvents kryptonCheckBox1 As Krypton.Toolkit.KryptonCheckBox
    Friend WithEvents kryptonListBox1 As Krypton.Toolkit.KryptonListBox
    Friend WithEvents kryptonComboBox1 As Krypton.Toolkit.KryptonComboBox
    Friend WithEvents kryptonTextBox1 As Krypton.Toolkit.KryptonTextBox
    Friend WithEvents kryptonGroupBox2 As Krypton.Toolkit.KryptonGroupBox
    Friend WithEvents chkShowHelp As Krypton.Toolkit.KryptonCheckBox
    Friend WithEvents chkShowColour As Krypton.Toolkit.KryptonCheckBox
    Friend WithEvents chkShowEffects As Krypton.Toolkit.KryptonCheckBox
    Friend WithEvents chkShowApply As Krypton.Toolkit.KryptonCheckBox
    Friend WithEvents chkAllowVectorFonts As Krypton.Toolkit.KryptonCheckBox
    Friend WithEvents chkAllowSimulations As Krypton.Toolkit.KryptonCheckBox
    Friend WithEvents chkAllowScriptChange As Krypton.Toolkit.KryptonCheckBox
    Friend WithEvents kryptonThemeComboBox1 As Krypton.Toolkit.KryptonThemeComboBox
End Class
