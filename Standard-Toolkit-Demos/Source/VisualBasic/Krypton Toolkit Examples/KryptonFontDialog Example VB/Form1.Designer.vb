' VB.NET twin of Source\Krypton Toolkit Examples\KryptonFontDialog Example\Form1.Designer.cs (Bastion Phase 4c).

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
        Me.chklShowExtendedColours = New Krypton.Toolkit.KryptonCheckBox()
        Me.chkShowEffects = New Krypton.Toolkit.KryptonCheckBox()
        Me.chkShowApply = New Krypton.Toolkit.KryptonCheckBox()
        Me.chkAllowVectorFonts = New Krypton.Toolkit.KryptonCheckBox()
        Me.chkAllowSimulations = New Krypton.Toolkit.KryptonCheckBox()
        Me.chkAllowScriptChange = New Krypton.Toolkit.KryptonCheckBox()
        Me.chkShowColour = New Krypton.Toolkit.KryptonCheckBox()
        Me.chkShowHelp = New Krypton.Toolkit.KryptonCheckBox()
        Me.kryptonGroupBox1 = New Krypton.Toolkit.KryptonGroupBox()
        Me.kryptonColorButton1 = New Krypton.Toolkit.KryptonColorButton()
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
        '
        ' groupBoxPalette
        '
        Me.groupBoxPalette.Location = New System.Drawing.Point(12, 12)
        Me.groupBoxPalette.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        '
        ' groupBoxPalette.Panel
        '
        Me.groupBoxPalette.Panel.Controls.Add(Me.paletteSparkleOrange)
        Me.groupBoxPalette.Panel.Controls.Add(Me.palette2010Black)
        Me.groupBoxPalette.Panel.Controls.Add(Me.palette2010Silver)
        Me.groupBoxPalette.Panel.Controls.Add(Me.paletteProfessional)
        Me.groupBoxPalette.Panel.Controls.Add(Me.palette2007Blue)
        Me.groupBoxPalette.Panel.Controls.Add(Me.palette2010Blue)
        Me.groupBoxPalette.Size = New System.Drawing.Size(353, 135)
        Me.groupBoxPalette.TabIndex = 18
        Me.groupBoxPalette.Values.Heading = "Palette"
        '
        ' paletteSparkleOrange
        '
        Me.paletteSparkleOrange.Location = New System.Drawing.Point(184, 39)
        Me.paletteSparkleOrange.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.paletteSparkleOrange.Name = "paletteSparkleOrange"
        Me.paletteSparkleOrange.Size = New System.Drawing.Size(139, 24)
        Me.paletteSparkleOrange.TabIndex = 5
        Me.paletteSparkleOrange.Values.Text = "Sparkle - Orange"
        '
        ' palette2010Black
        '
        Me.palette2010Black.Location = New System.Drawing.Point(15, 63)
        Me.palette2010Black.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.palette2010Black.Name = "palette2010Black"
        Me.palette2010Black.Size = New System.Drawing.Size(151, 24)
        Me.palette2010Black.TabIndex = 4
        Me.palette2010Black.Values.Text = "Office 2010 - Black"
        '
        ' palette2010Silver
        '
        Me.palette2010Silver.Location = New System.Drawing.Point(15, 39)
        Me.palette2010Silver.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.palette2010Silver.Name = "palette2010Silver"
        Me.palette2010Silver.Size = New System.Drawing.Size(153, 24)
        Me.palette2010Silver.TabIndex = 3
        Me.palette2010Silver.Values.Text = "Office 2010 - Silver"
        '
        ' paletteProfessional
        '
        Me.paletteProfessional.Location = New System.Drawing.Point(184, 63)
        Me.paletteProfessional.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.paletteProfessional.Name = "paletteProfessional"
        Me.paletteProfessional.Size = New System.Drawing.Size(106, 24)
        Me.paletteProfessional.TabIndex = 2
        Me.paletteProfessional.Values.Text = "Professional"
        '
        ' palette2007Blue
        '
        Me.palette2007Blue.Location = New System.Drawing.Point(184, 17)
        Me.palette2007Blue.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.palette2007Blue.Name = "palette2007Blue"
        Me.palette2007Blue.Size = New System.Drawing.Size(145, 24)
        Me.palette2007Blue.TabIndex = 1
        Me.palette2007Blue.Values.Text = "Office 2007 - Blue"
        '
        ' palette2010Blue
        '
        Me.palette2010Blue.Checked = True
        Me.palette2010Blue.Location = New System.Drawing.Point(15, 17)
        Me.palette2010Blue.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.palette2010Blue.Name = "palette2010Blue"
        Me.palette2010Blue.Size = New System.Drawing.Size(145, 24)
        Me.palette2010Blue.TabIndex = 0
        Me.palette2010Blue.Values.Text = "Office 2010 - Blue"
        '
        ' buttonShowFontDialog
        '
        Me.buttonShowFontDialog.Location = New System.Drawing.Point(264, 322)
        Me.buttonShowFontDialog.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.buttonShowFontDialog.Name = "buttonShowFontDialog"
        Me.buttonShowFontDialog.Size = New System.Drawing.Size(307, 59)
        Me.buttonShowFontDialog.TabIndex = 19
        Me.buttonShowFontDialog.Values.DropDownArrowColor = System.Drawing.Color.Empty
        Me.buttonShowFontDialog.Values.Text = "Show FontDialog"
        '
        ' kryptonPanel1
        '
        Me.kryptonPanel1.Controls.Add(Me.kryptonGroupBox2)
        Me.kryptonPanel1.Controls.Add(Me.kryptonGroupBox1)
        Me.kryptonPanel1.Controls.Add(Me.groupBoxPalette)
        Me.kryptonPanel1.Controls.Add(Me.buttonShowFontDialog)
        Me.kryptonPanel1.Dock = System.Windows.Forms.DockStyle.Fill
        Me.kryptonPanel1.Location = New System.Drawing.Point(0, 0)
        Me.kryptonPanel1.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.kryptonPanel1.Name = "kryptonPanel1"
        Me.kryptonPanel1.Size = New System.Drawing.Size(603, 382)
        Me.kryptonPanel1.TabIndex = 20
        '
        ' kryptonGroupBox2
        '
        Me.kryptonGroupBox2.Location = New System.Drawing.Point(372, 28)
        Me.kryptonGroupBox2.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        '
        ' kryptonGroupBox2.Panel
        '
        Me.kryptonGroupBox2.Panel.Controls.Add(Me.chkShowIcon)
        Me.kryptonGroupBox2.Panel.Controls.Add(Me.chklShowExtendedColours)
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
        '
        ' chkShowIcon
        '
        Me.chkShowIcon.Location = New System.Drawing.Point(3, 235)
        Me.chkShowIcon.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.chkShowIcon.Name = "chkShowIcon"
        Me.chkShowIcon.Size = New System.Drawing.Size(95, 24)
        Me.chkShowIcon.TabIndex = 8
        Me.chkShowIcon.Values.Text = "Show Icon"
        '
        ' chklShowExtendedColours
        '
        Me.chklShowExtendedColours.Checked = True
        Me.chklShowExtendedColours.CheckState = System.Windows.Forms.CheckState.Checked
        Me.chklShowExtendedColours.Location = New System.Drawing.Point(5, 210)
        Me.chklShowExtendedColours.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.chklShowExtendedColours.Name = "chklShowExtendedColours"
        Me.chklShowExtendedColours.Size = New System.Drawing.Size(185, 24)
        Me.chklShowExtendedColours.TabIndex = 7
        Me.chklShowExtendedColours.Values.Text = "Show Extended Colours"
        '
        ' chkShowEffects
        '
        Me.chkShowEffects.Checked = True
        Me.chkShowEffects.CheckState = System.Windows.Forms.CheckState.Checked
        Me.chkShowEffects.Location = New System.Drawing.Point(4, 180)
        Me.chkShowEffects.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.chkShowEffects.Name = "chkShowEffects"
        Me.chkShowEffects.Size = New System.Drawing.Size(110, 24)
        Me.chkShowEffects.TabIndex = 6
        Me.chkShowEffects.Values.Text = "Show Effects"
        '
        ' chkShowApply
        '
        Me.chkShowApply.Location = New System.Drawing.Point(4, 150)
        Me.chkShowApply.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.chkShowApply.Name = "chkShowApply"
        Me.chkShowApply.Size = New System.Drawing.Size(105, 24)
        Me.chkShowApply.TabIndex = 5
        Me.chkShowApply.Values.Text = "Show Apply"
        '
        ' chkAllowVectorFonts
        '
        Me.chkAllowVectorFonts.Location = New System.Drawing.Point(4, 121)
        Me.chkAllowVectorFonts.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.chkAllowVectorFonts.Name = "chkAllowVectorFonts"
        Me.chkAllowVectorFonts.Size = New System.Drawing.Size(152, 24)
        Me.chkAllowVectorFonts.TabIndex = 4
        Me.chkAllowVectorFonts.Values.Text = "Allow Vector Fonts"
        '
        ' chkAllowSimulations
        '
        Me.chkAllowSimulations.Location = New System.Drawing.Point(4, 90)
        Me.chkAllowSimulations.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.chkAllowSimulations.Name = "chkAllowSimulations"
        Me.chkAllowSimulations.Size = New System.Drawing.Size(145, 24)
        Me.chkAllowSimulations.TabIndex = 3
        Me.chkAllowSimulations.Values.Text = "Allow Simulations"
        '
        ' chkAllowScriptChange
        '
        Me.chkAllowScriptChange.Location = New System.Drawing.Point(3, 60)
        Me.chkAllowScriptChange.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.chkAllowScriptChange.Name = "chkAllowScriptChange"
        Me.chkAllowScriptChange.Size = New System.Drawing.Size(161, 24)
        Me.chkAllowScriptChange.TabIndex = 2
        Me.chkAllowScriptChange.Values.Text = "Allow Script Change"
        '
        ' chkShowColour
        '
        Me.chkShowColour.Checked = True
        Me.chkShowColour.CheckState = System.Windows.Forms.CheckState.Checked
        Me.chkShowColour.Location = New System.Drawing.Point(4, 30)
        Me.chkShowColour.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.chkShowColour.Name = "chkShowColour"
        Me.chkShowColour.Size = New System.Drawing.Size(111, 24)
        Me.chkShowColour.TabIndex = 1
        Me.chkShowColour.Values.Text = "Show Colour"
        '
        ' chkShowHelp
        '
        Me.chkShowHelp.Location = New System.Drawing.Point(4, 0)
        Me.chkShowHelp.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.chkShowHelp.Name = "chkShowHelp"
        Me.chkShowHelp.Size = New System.Drawing.Size(98, 24)
        Me.chkShowHelp.TabIndex = 0
        Me.chkShowHelp.Values.Text = "Show Help"
        '
        ' kryptonGroupBox1
        '
        Me.kryptonGroupBox1.Location = New System.Drawing.Point(12, 153)
        Me.kryptonGroupBox1.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        '
        ' kryptonGroupBox1.Panel
        '
        Me.kryptonGroupBox1.Panel.Controls.Add(Me.kryptonColorButton1)
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
        ' kryptonColorButton1
        '
        Me.kryptonColorButton1.Location = New System.Drawing.Point(239, 98)
        Me.kryptonColorButton1.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.kryptonColorButton1.Name = "kryptonColorButton1"
        Me.kryptonColorButton1.SchemeStandard = Krypton.Toolkit.ColorScheme.OfficeThemes
        Me.kryptonColorButton1.SchemeThemes = Krypton.Toolkit.ColorScheme.Basic16
        Me.kryptonColorButton1.SelectedColor = System.Drawing.Color.Black
        Me.kryptonColorButton1.Size = New System.Drawing.Size(91, 25)
        Me.kryptonColorButton1.Splitter = False
        Me.kryptonColorButton1.StateCommon.Content.AdjacentGap = 3
        Me.kryptonColorButton1.StateCommon.Content.Image.ImageH = Krypton.Toolkit.PaletteRelativeAlign.Near
        Me.kryptonColorButton1.StateCommon.Content.Image.ImageV = Krypton.Toolkit.PaletteRelativeAlign.Center
        Me.kryptonColorButton1.StateCommon.Content.Padding = New System.Windows.Forms.Padding(5, 0, 0, 0)
        Me.kryptonColorButton1.StateCommon.Content.ShortText.TextH = Krypton.Toolkit.PaletteRelativeAlign.Near
        Me.kryptonColorButton1.StateCommon.Content.ShortText.TextV = Krypton.Toolkit.PaletteRelativeAlign.Center
        Me.kryptonColorButton1.TabIndex = 7
        Me.kryptonColorButton1.Values.Text = "Black"
        '
        ' kryptonTextBox1
        '
        Me.kryptonTextBox1.Location = New System.Drawing.Point(156, 30)
        Me.kryptonTextBox1.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.kryptonTextBox1.Name = "kryptonTextBox1"
        Me.kryptonTextBox1.Size = New System.Drawing.Size(133, 27)
        Me.kryptonTextBox1.TabIndex = 6
        Me.kryptonTextBox1.Text = "kryptonTextBox1"
        '
        ' kryptonNumericUpDown1
        '
        Me.kryptonNumericUpDown1.Increment = New Decimal(New Integer() { 1, 0, 0, 0})
        Me.kryptonNumericUpDown1.Location = New System.Drawing.Point(156, 97)
        Me.kryptonNumericUpDown1.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.kryptonNumericUpDown1.Maximum = New Decimal(New Integer() { 100, 0, 0, 0})
        Me.kryptonNumericUpDown1.Minimum = New Decimal(New Integer() { 0, 0, 0, 0})
        Me.kryptonNumericUpDown1.Name = "kryptonNumericUpDown1"
        Me.kryptonNumericUpDown1.Size = New System.Drawing.Size(77, 26)
        Me.kryptonNumericUpDown1.TabIndex = 5
        Me.kryptonNumericUpDown1.Value = New Decimal(New Integer() { 0, 0, 0, 0})
        '
        ' kryptonButton1
        '
        Me.kryptonButton1.Location = New System.Drawing.Point(156, 65)
        Me.kryptonButton1.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.kryptonButton1.Name = "kryptonButton1"
        Me.kryptonButton1.Size = New System.Drawing.Size(91, 25)
        Me.kryptonButton1.TabIndex = 4
        Me.kryptonButton1.Values.DropDownArrowColor = System.Drawing.Color.Empty
        Me.kryptonButton1.Values.Text = "kryptonButton1"
        '
        ' kryptonCheckBox1
        '
        Me.kryptonCheckBox1.Location = New System.Drawing.Point(156, 4)
        Me.kryptonCheckBox1.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.kryptonCheckBox1.Name = "kryptonCheckBox1"
        Me.kryptonCheckBox1.Size = New System.Drawing.Size(152, 24)
        Me.kryptonCheckBox1.TabIndex = 2
        Me.kryptonCheckBox1.Values.Text = "kryptonCheckBox1"
        '
        ' kryptonListBox1
        '
        Me.kryptonListBox1.Items.AddRange(New Object() { "Font 1", "Font 2", "Font 1Font 1Font 1Font 1"})
        Me.kryptonListBox1.Location = New System.Drawing.Point(4, 30)
        Me.kryptonListBox1.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.kryptonListBox1.Name = "kryptonListBox1"
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
        Me.kryptonComboBox1.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.kryptonComboBox1.Name = "kryptonComboBox1"
        Me.kryptonComboBox1.Size = New System.Drawing.Size(147, 26)
        Me.kryptonComboBox1.StateCommon.ComboBox.Content.TextH = Krypton.Toolkit.PaletteRelativeAlign.Near
        Me.kryptonComboBox1.TabIndex = 0
        Me.kryptonComboBox1.Text = "Microsoft Sans Serif"
        '
        ' kryptonManager
        '
        Me.kryptonManager.GlobalPaletteMode = Krypton.Toolkit.PaletteMode.Office2010Blue
        '
        ' Form1
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 16.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(603, 382)
        Me.Controls.Add(Me.kryptonPanel1)
        Me.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.Name = "Form1"
        Me.Text = "KryptonFontDialog Example"
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

#End Region

    Private WithEvents groupBoxPalette As Krypton.Toolkit.KryptonGroupBox
    Private WithEvents paletteSparkleOrange As Krypton.Toolkit.KryptonRadioButton
    Private WithEvents palette2010Black As Krypton.Toolkit.KryptonRadioButton
    Private WithEvents palette2010Silver As Krypton.Toolkit.KryptonRadioButton
    Private WithEvents paletteProfessional As Krypton.Toolkit.KryptonRadioButton
    Private WithEvents palette2007Blue As Krypton.Toolkit.KryptonRadioButton
    Private WithEvents palette2010Blue As Krypton.Toolkit.KryptonRadioButton
    Private WithEvents buttonShowFontDialog As Krypton.Toolkit.KryptonButton
    Private WithEvents kryptonPanel1 As Krypton.Toolkit.KryptonPanel
    Private WithEvents kryptonGroupBox1 As Krypton.Toolkit.KryptonGroupBox
    Private WithEvents kryptonNumericUpDown1 As Krypton.Toolkit.KryptonNumericUpDown
    Private WithEvents kryptonButton1 As Krypton.Toolkit.KryptonButton
    Private WithEvents kryptonCheckBox1 As Krypton.Toolkit.KryptonCheckBox
    Private WithEvents kryptonListBox1 As Krypton.Toolkit.KryptonListBox
    Private WithEvents kryptonComboBox1 As Krypton.Toolkit.KryptonComboBox
    Private WithEvents kryptonTextBox1 As Krypton.Toolkit.KryptonTextBox
    Private WithEvents kryptonGroupBox2 As Krypton.Toolkit.KryptonGroupBox
    Private WithEvents chkShowHelp As Krypton.Toolkit.KryptonCheckBox
    Private WithEvents chkShowColour As Krypton.Toolkit.KryptonCheckBox
    Private WithEvents chkShowEffects As Krypton.Toolkit.KryptonCheckBox
    Private WithEvents chkShowApply As Krypton.Toolkit.KryptonCheckBox
    Private WithEvents chkAllowVectorFonts As Krypton.Toolkit.KryptonCheckBox
    Private WithEvents chkAllowSimulations As Krypton.Toolkit.KryptonCheckBox
    Private WithEvents chkAllowScriptChange As Krypton.Toolkit.KryptonCheckBox
    Private WithEvents kryptonManager As Krypton.Toolkit.KryptonManager
    Private WithEvents chklShowExtendedColours As Krypton.Toolkit.KryptonCheckBox
    Private WithEvents kryptonColorButton1 As Krypton.Toolkit.KryptonColorButton
    Private WithEvents chkShowIcon As Krypton.Toolkit.KryptonCheckBox

End Class
