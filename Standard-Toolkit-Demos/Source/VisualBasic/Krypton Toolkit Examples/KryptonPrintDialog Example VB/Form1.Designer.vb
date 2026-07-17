' VB.NET twin of Source\Krypton Toolkit Examples\KryptonPrintDialog Example\Form1.Designer.cs (Bastion Phase 4c).
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
        Me.groupBoxPalette = New Krypton.Toolkit.KryptonGroupBox()
        Me.paletteSparkleOrange = New Krypton.Toolkit.KryptonRadioButton()
        Me.palette2010Black = New Krypton.Toolkit.KryptonRadioButton()
        Me.palette2010Silver = New Krypton.Toolkit.KryptonRadioButton()
        Me.paletteProfessional = New Krypton.Toolkit.KryptonRadioButton()
        Me.palette2007Blue = New Krypton.Toolkit.KryptonRadioButton()
        Me.palette2010Blue = New Krypton.Toolkit.KryptonRadioButton()
        Me.buttonShowFontDialog = New Krypton.Toolkit.KryptonButton()
        Me.kryptonPanel1 = New Krypton.Toolkit.KryptonPanel()
        Me.kryptonGroupBox2 = New Krypton.Toolkit.KryptonGroupBox()
        Me.chkShowIcon = New Krypton.Toolkit.KryptonCheckBox()
        Me.chkUseEXDialog = New Krypton.Toolkit.KryptonCheckBox()
        Me.chkShowNetwork = New Krypton.Toolkit.KryptonCheckBox()
        Me.chkAllowSomePages = New Krypton.Toolkit.KryptonCheckBox()
        Me.chkAllowSelection = New Krypton.Toolkit.KryptonCheckBox()
        Me.chkAllowPrintToFile = New Krypton.Toolkit.KryptonCheckBox()
        Me.chkAllowCurrentPage = New Krypton.Toolkit.KryptonCheckBox()
        Me.chkShowHelp = New Krypton.Toolkit.KryptonCheckBox()
        Me.kryptonGroupBox1 = New Krypton.Toolkit.KryptonGroupBox()
        Me.kryptonTextBox1 = New Krypton.Toolkit.KryptonTextBox()
        Me.kryptonNumericUpDown1 = New Krypton.Toolkit.KryptonNumericUpDown()
        Me.kryptonButton1 = New Krypton.Toolkit.KryptonButton()
        Me.kryptonCheckBox1 = New Krypton.Toolkit.KryptonCheckBox()
        Me.kryptonListBox1 = New Krypton.Toolkit.KryptonListBox()
        Me.kryptonComboBox1 = New Krypton.Toolkit.KryptonComboBox()
        Me.kryptonManager = New Krypton.Toolkit.KryptonManager(Me.components)
        CType(Me.groupBoxPalette, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.groupBoxPalette.Panel, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.groupBoxPalette.Panel.SuspendLayout()
        Me.groupBoxPalette.SuspendLayout()
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
        Me.groupBoxPalette.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.groupBoxPalette.Name = "groupBoxPalette"
        Me.groupBoxPalette.Panel.Controls.Add(Me.paletteSparkleOrange)
        Me.groupBoxPalette.Panel.Controls.Add(Me.palette2010Black)
        Me.groupBoxPalette.Panel.Controls.Add(Me.palette2010Silver)
        Me.groupBoxPalette.Panel.Controls.Add(Me.paletteProfessional)
        Me.groupBoxPalette.Panel.Controls.Add(Me.palette2007Blue)
        Me.groupBoxPalette.Panel.Controls.Add(Me.palette2010Blue)
        Me.groupBoxPalette.Size = New System.Drawing.Size(353, 135)
        Me.groupBoxPalette.TabIndex = 18
        Me.groupBoxPalette.Values.Heading = "Palette"
        Me.paletteSparkleOrange.Location = New System.Drawing.Point(184, 39)
        Me.paletteSparkleOrange.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.paletteSparkleOrange.Name = "paletteSparkleOrange"
        Me.paletteSparkleOrange.Size = New System.Drawing.Size(139, 24)
        Me.paletteSparkleOrange.TabIndex = 5
        Me.paletteSparkleOrange.Values.Text = "Sparkle - Orange"
        Me.palette2010Black.Location = New System.Drawing.Point(15, 63)
        Me.palette2010Black.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.palette2010Black.Name = "palette2010Black"
        Me.palette2010Black.Size = New System.Drawing.Size(151, 24)
        Me.palette2010Black.TabIndex = 4
        Me.palette2010Black.Values.Text = "Office 2010 - Black"
        Me.palette2010Silver.Location = New System.Drawing.Point(15, 39)
        Me.palette2010Silver.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.palette2010Silver.Name = "palette2010Silver"
        Me.palette2010Silver.Size = New System.Drawing.Size(153, 24)
        Me.palette2010Silver.TabIndex = 3
        Me.palette2010Silver.Values.Text = "Office 2010 - Silver"
        Me.paletteProfessional.Location = New System.Drawing.Point(184, 63)
        Me.paletteProfessional.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.paletteProfessional.Name = "paletteProfessional"
        Me.paletteProfessional.Size = New System.Drawing.Size(106, 24)
        Me.paletteProfessional.TabIndex = 2
        Me.paletteProfessional.Values.Text = "Professional"
        Me.palette2007Blue.Location = New System.Drawing.Point(184, 17)
        Me.palette2007Blue.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.palette2007Blue.Name = "palette2007Blue"
        Me.palette2007Blue.Size = New System.Drawing.Size(145, 24)
        Me.palette2007Blue.TabIndex = 1
        Me.palette2007Blue.Values.Text = "Office 2007 - Blue"
        Me.palette2010Blue.Checked = True
        Me.palette2010Blue.Location = New System.Drawing.Point(15, 17)
        Me.palette2010Blue.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.palette2010Blue.Name = "palette2010Blue"
        Me.palette2010Blue.Size = New System.Drawing.Size(145, 24)
        Me.palette2010Blue.TabIndex = 0
        Me.palette2010Blue.Values.Text = "Office 2010 - Blue"
        Me.buttonShowFontDialog.Location = New System.Drawing.Point(264, 322)
        Me.buttonShowFontDialog.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.buttonShowFontDialog.Name = "buttonShowFontDialog"
        Me.buttonShowFontDialog.Size = New System.Drawing.Size(307, 59)
        Me.buttonShowFontDialog.TabIndex = 19
        Me.buttonShowFontDialog.Values.DropDownArrowColor = System.Drawing.Color.Empty
        Me.buttonShowFontDialog.Values.Text = "Show PrintDialog"
        Me.kryptonPanel1.Controls.Add(Me.kryptonGroupBox2)
        Me.kryptonPanel1.Controls.Add(Me.kryptonGroupBox1)
        Me.kryptonPanel1.Controls.Add(Me.groupBoxPalette)
        Me.kryptonPanel1.Controls.Add(Me.buttonShowFontDialog)
        Me.kryptonPanel1.Dock = System.Windows.Forms.DockStyle.Fill
        Me.kryptonPanel1.Location = New System.Drawing.Point(0, 0)
        Me.kryptonPanel1.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.kryptonPanel1.Name = "kryptonPanel1"
        Me.kryptonPanel1.Size = New System.Drawing.Size(599, 396)
        Me.kryptonPanel1.TabIndex = 20
        Me.kryptonGroupBox2.Location = New System.Drawing.Point(372, 28)
        Me.kryptonGroupBox2.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.kryptonGroupBox2.Name = "kryptonGroupBox2"
        Me.kryptonGroupBox2.Panel.Controls.Add(Me.chkShowIcon)
        Me.kryptonGroupBox2.Panel.Controls.Add(Me.chkUseEXDialog)
        Me.kryptonGroupBox2.Panel.Controls.Add(Me.chkShowNetwork)
        Me.kryptonGroupBox2.Panel.Controls.Add(Me.chkAllowSomePages)
        Me.kryptonGroupBox2.Panel.Controls.Add(Me.chkAllowSelection)
        Me.kryptonGroupBox2.Panel.Controls.Add(Me.chkAllowPrintToFile)
        Me.kryptonGroupBox2.Panel.Controls.Add(Me.chkAllowCurrentPage)
        Me.kryptonGroupBox2.Panel.Controls.Add(Me.chkShowHelp)
        Me.kryptonGroupBox2.Size = New System.Drawing.Size(199, 289)
        Me.kryptonGroupBox2.TabIndex = 21
        Me.kryptonGroupBox2.Values.Heading = "Options:"
        Me.chkShowIcon.Location = New System.Drawing.Point(20, 219)
        Me.chkShowIcon.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.chkShowIcon.Name = "chkShowIcon"
        Me.chkShowIcon.Size = New System.Drawing.Size(95, 24)
        Me.chkShowIcon.TabIndex = 6
        Me.chkShowIcon.Values.Text = "Show Icon"
        Me.chkUseEXDialog.Location = New System.Drawing.Point(20, -1)
        Me.chkUseEXDialog.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.chkUseEXDialog.Name = "chkUseEXDialog"
        Me.chkUseEXDialog.Size = New System.Drawing.Size(111, 24)
        Me.chkUseEXDialog.TabIndex = 0
        Me.chkUseEXDialog.Values.Text = "UseEXDialog"
        Me.chkShowNetwork.Location = New System.Drawing.Point(20, 31)
        Me.chkShowNetwork.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.chkShowNetwork.Name = "chkShowNetwork"
        Me.chkShowNetwork.Size = New System.Drawing.Size(124, 24)
        Me.chkShowNetwork.TabIndex = 1
        Me.chkShowNetwork.Values.Text = "Show Network"
        Me.chkAllowSomePages.Location = New System.Drawing.Point(20, 63)
        Me.chkAllowSomePages.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.chkAllowSomePages.Name = "chkAllowSomePages"
        Me.chkAllowSomePages.Size = New System.Drawing.Size(150, 24)
        Me.chkAllowSomePages.TabIndex = 2
        Me.chkAllowSomePages.Values.Text = "Allow Some Pages"
        Me.chkAllowSelection.Location = New System.Drawing.Point(20, 95)
        Me.chkAllowSelection.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.chkAllowSelection.Name = "chkAllowSelection"
        Me.chkAllowSelection.Size = New System.Drawing.Size(128, 24)
        Me.chkAllowSelection.TabIndex = 3
        Me.chkAllowSelection.Values.Text = "Allow Selection"
        Me.chkAllowPrintToFile.Location = New System.Drawing.Point(20, 127)
        Me.chkAllowPrintToFile.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.chkAllowPrintToFile.Name = "chkAllowPrintToFile"
        Me.chkAllowPrintToFile.Size = New System.Drawing.Size(147, 24)
        Me.chkAllowPrintToFile.TabIndex = 4
        Me.chkAllowPrintToFile.Values.Text = "Allow Print To File"
        Me.chkAllowCurrentPage.Location = New System.Drawing.Point(20, 159)
        Me.chkAllowCurrentPage.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.chkAllowCurrentPage.Name = "chkAllowCurrentPage"
        Me.chkAllowCurrentPage.Size = New System.Drawing.Size(155, 24)
        Me.chkAllowCurrentPage.TabIndex = 5
        Me.chkAllowCurrentPage.Values.Text = "Allow Current Page"
        Me.chkShowHelp.Location = New System.Drawing.Point(20, 190)
        Me.chkShowHelp.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.chkShowHelp.Name = "chkShowHelp"
        Me.chkShowHelp.Size = New System.Drawing.Size(98, 24)
        Me.chkShowHelp.TabIndex = 0
        Me.chkShowHelp.Values.Text = "Show Help"
        Me.kryptonGroupBox1.Location = New System.Drawing.Point(12, 153)
        Me.kryptonGroupBox1.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
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
        Me.kryptonTextBox1.Location = New System.Drawing.Point(156, 30)
        Me.kryptonTextBox1.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.kryptonTextBox1.Name = "kryptonTextBox1"
        Me.kryptonTextBox1.Size = New System.Drawing.Size(133, 27)
        Me.kryptonTextBox1.TabIndex = 6
        Me.kryptonTextBox1.Text = "kryptonTextBox1"
        Me.kryptonNumericUpDown1.Increment = New Decimal(New Integer() { 1, 0, 0, 0})
        Me.kryptonNumericUpDown1.Location = New System.Drawing.Point(156, 97)
        Me.kryptonNumericUpDown1.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.kryptonNumericUpDown1.Maximum = New Decimal(New Integer() { 100, 0, 0, 0})
        Me.kryptonNumericUpDown1.Minimum = New Decimal(New Integer() { 0, 0, 0, 0})
        Me.kryptonNumericUpDown1.Name = "kryptonNumericUpDown1"
        Me.kryptonNumericUpDown1.Size = New System.Drawing.Size(91, 26)
        Me.kryptonNumericUpDown1.TabIndex = 5
        Me.kryptonNumericUpDown1.Value = New Decimal(New Integer() { 0, 0, 0, 0})
        Me.kryptonButton1.Location = New System.Drawing.Point(156, 65)
        Me.kryptonButton1.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.kryptonButton1.Name = "kryptonButton1"
        Me.kryptonButton1.Size = New System.Drawing.Size(91, 25)
        Me.kryptonButton1.TabIndex = 4
        Me.kryptonButton1.Values.DropDownArrowColor = System.Drawing.Color.Empty
        Me.kryptonButton1.Values.Text = "kryptonButton1"
        Me.kryptonCheckBox1.Location = New System.Drawing.Point(156, 4)
        Me.kryptonCheckBox1.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.kryptonCheckBox1.Name = "kryptonCheckBox1"
        Me.kryptonCheckBox1.Size = New System.Drawing.Size(152, 24)
        Me.kryptonCheckBox1.TabIndex = 2
        Me.kryptonCheckBox1.Values.Text = "kryptonCheckBox1"
        Me.kryptonListBox1.Items.AddRange(New Object() { "Font 1", "Font 2", "Font 1Font 1Font 1Font 1"})
        Me.kryptonListBox1.Location = New System.Drawing.Point(4, 30)
        Me.kryptonListBox1.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.kryptonListBox1.Name = "kryptonListBox1"
        Me.kryptonListBox1.Size = New System.Drawing.Size(120, 96)
        Me.kryptonListBox1.TabIndex = 1
        Me.kryptonComboBox1.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.kryptonComboBox1.DropDownWidth = 121
        Me.kryptonComboBox1.IntegralHeight = False
        Me.kryptonComboBox1.Items.AddRange(New Object() { "Microsoft Sans Serif"})
        Me.kryptonComboBox1.Location = New System.Drawing.Point(4, 4)
        Me.kryptonComboBox1.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.kryptonComboBox1.Name = "kryptonComboBox1"
        Me.kryptonComboBox1.Size = New System.Drawing.Size(147, 26)
        Me.kryptonComboBox1.StateCommon.ComboBox.Content.TextH = Krypton.Toolkit.PaletteRelativeAlign.Near
        Me.kryptonComboBox1.TabIndex = 0
        Me.kryptonComboBox1.Text = "Microsoft Sans Serif"
        Me.kryptonManager.GlobalPaletteMode = Krypton.Toolkit.PaletteMode.Office2007Blue
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8F, 16F)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(599, 396)
        Me.Controls.Add(Me.kryptonPanel1)
        Me.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.Name = "Form1"
        Me.Text = "KryptonPrintDialog Example"
        CType(Me.groupBoxPalette.Panel, System.ComponentModel.ISupportInitialize).EndInit()
        Me.groupBoxPalette.Panel.ResumeLayout(False)
        Me.groupBoxPalette.Panel.PerformLayout()
        CType(Me.groupBoxPalette, System.ComponentModel.ISupportInitialize).EndInit()
        Me.groupBoxPalette.ResumeLayout(False)
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
    Friend WithEvents paletteSparkleOrange As Krypton.Toolkit.KryptonRadioButton
    Friend WithEvents palette2010Black As Krypton.Toolkit.KryptonRadioButton
    Friend WithEvents palette2010Silver As Krypton.Toolkit.KryptonRadioButton
    Friend WithEvents paletteProfessional As Krypton.Toolkit.KryptonRadioButton
    Friend WithEvents palette2007Blue As Krypton.Toolkit.KryptonRadioButton
    Friend WithEvents palette2010Blue As Krypton.Toolkit.KryptonRadioButton
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
    Friend WithEvents chkAllowCurrentPage As Krypton.Toolkit.KryptonCheckBox
    Friend WithEvents chkUseEXDialog As Krypton.Toolkit.KryptonCheckBox
    Friend WithEvents chkShowNetwork As Krypton.Toolkit.KryptonCheckBox
    Friend WithEvents chkAllowSomePages As Krypton.Toolkit.KryptonCheckBox
    Friend WithEvents chkAllowSelection As Krypton.Toolkit.KryptonCheckBox
    Friend WithEvents chkAllowPrintToFile As Krypton.Toolkit.KryptonCheckBox
    Friend WithEvents kryptonManager As Krypton.Toolkit.KryptonManager
    Friend WithEvents chkShowIcon As Krypton.Toolkit.KryptonCheckBox
End Class
