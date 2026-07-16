' VB.NET twin of Source\Krypton Toolkit Examples\KryptonProgressbar Examples\Form1.Designer.cs (Bastion Phase 4c).
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
        Me.kchkShowTextShadow = New Krypton.Toolkit.KryptonCheckBox()
        Me.kryptonLabel3 = New Krypton.Toolkit.KryptonLabel()
        Me.kcbtnProgressBarColour = New Krypton.Toolkit.KryptonColorButton()
        Me.kcmbProgressBarStyle = New Krypton.Toolkit.KryptonComboBox()
        Me.klblColorStyle = New Krypton.Toolkit.KryptonLabel()
        Me.kcmbColorStyle = New Krypton.Toolkit.KryptonComboBox()
        Me.kchkShowTextBackdrop = New Krypton.Toolkit.KryptonCheckBox()
        Me.kcbtnBackdropColor = New Krypton.Toolkit.KryptonColorButton()
        Me.kchkUseProgressValueAsText = New Krypton.Toolkit.KryptonCheckBox()
        Me.kryptonLabel2 = New Krypton.Toolkit.KryptonLabel()
        Me.ktrkProgressValues = New Krypton.Toolkit.KryptonTrackBar()
        Me.ProgressBarDisabled = New Krypton.Toolkit.KryptonProgressBar()
        Me.kryptonButton1 = New Krypton.Toolkit.KryptonButton()
        Me.kryptonThemeComboBox1 = New Krypton.Toolkit.KryptonThemeComboBox()
        Me.pbVertical = New Krypton.Toolkit.KryptonProgressBar()
        Me.pbCustomColor = New Krypton.Toolkit.KryptonProgressBar()
        Me.pbHorizontal2 = New Krypton.Toolkit.KryptonProgressBar()
        Me.pbHorizontal = New Krypton.Toolkit.KryptonProgressBar()
        Me.knudHorizontal = New Krypton.Toolkit.KryptonNumericUpDown()
        Me.kryptonLabel1 = New Krypton.Toolkit.KryptonLabel()
        Me.kryptonManager1 = New Krypton.Toolkit.KryptonManager(Me.components)
        Me.statusStrip1 = New System.Windows.Forms.StatusStrip()
        Me.kryptonProgressBarToolStripItem1 = New Krypton.Toolkit.KryptonProgressBarToolStripItem()
        CType(Me.kryptonPanel1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.kryptonPanel1.SuspendLayout()
        CType(Me.kcmbProgressBarStyle, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.kcmbColorStyle, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.kryptonThemeComboBox1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.statusStrip1.SuspendLayout()
        Me.SuspendLayout()
        Me.kryptonPanel1.Controls.Add(Me.kchkShowTextShadow)
        Me.kryptonPanel1.Controls.Add(Me.kryptonLabel3)
        Me.kryptonPanel1.Controls.Add(Me.kcbtnProgressBarColour)
        Me.kryptonPanel1.Controls.Add(Me.kcmbProgressBarStyle)
        Me.kryptonPanel1.Controls.Add(Me.klblColorStyle)
        Me.kryptonPanel1.Controls.Add(Me.kcmbColorStyle)
        Me.kryptonPanel1.Controls.Add(Me.kchkShowTextBackdrop)
        Me.kryptonPanel1.Controls.Add(Me.kcbtnBackdropColor)
        Me.kryptonPanel1.Controls.Add(Me.kchkUseProgressValueAsText)
        Me.kryptonPanel1.Controls.Add(Me.kryptonLabel2)
        Me.kryptonPanel1.Controls.Add(Me.ktrkProgressValues)
        Me.kryptonPanel1.Controls.Add(Me.ProgressBarDisabled)
        Me.kryptonPanel1.Controls.Add(Me.kryptonButton1)
        Me.kryptonPanel1.Controls.Add(Me.kryptonThemeComboBox1)
        Me.kryptonPanel1.Controls.Add(Me.pbVertical)
        Me.kryptonPanel1.Controls.Add(Me.pbCustomColor)
        Me.kryptonPanel1.Controls.Add(Me.pbHorizontal2)
        Me.kryptonPanel1.Controls.Add(Me.pbHorizontal)
        Me.kryptonPanel1.Controls.Add(Me.knudHorizontal)
        Me.kryptonPanel1.Controls.Add(Me.kryptonLabel1)
        Me.kryptonPanel1.Dock = System.Windows.Forms.DockStyle.Fill
        Me.kryptonPanel1.Location = New System.Drawing.Point(0, 0)
        Me.kryptonPanel1.Name = "kryptonPanel1"
        Me.kryptonPanel1.Size = New System.Drawing.Size(799, 422)
        Me.kryptonPanel1.TabIndex = 0
        Me.kchkShowTextShadow.Location = New System.Drawing.Point(43, 307)
        Me.kchkShowTextShadow.Name = "kchkShowTextShadow"
        Me.kchkShowTextShadow.Size = New System.Drawing.Size(131, 21)
        Me.kchkShowTextShadow.TabIndex = 33
        Me.kchkShowTextShadow.Values.Text = "Show text shadow"
        Me.kryptonLabel3.Location = New System.Drawing.Point(262, 239)
        Me.kryptonLabel3.Name = "kryptonLabel3"
        Me.kryptonLabel3.Size = New System.Drawing.Size(94, 21)
        Me.kryptonLabel3.TabIndex = 32
        Me.kryptonLabel3.Values.Text = "Progress Style"
        Me.kcbtnProgressBarColour.CustomColorPreviewShape = Krypton.Toolkit.KryptonColorButtonCustomColorPreviewShape.Circle
        Me.kcbtnProgressBarColour.Location = New System.Drawing.Point(43, 265)
        Me.kcbtnProgressBarColour.Name = "kcbtnProgressBarColour"
        Me.kcbtnProgressBarColour.SelectedColor = System.Drawing.Color.Green
        Me.kcbtnProgressBarColour.Size = New System.Drawing.Size(177, 25)
        Me.kcbtnProgressBarColour.TabIndex = 27
        Me.kcbtnProgressBarColour.Values.Image = CType(resources.GetObject("kcbtnProgressBarColour.Values.Image"), System.Drawing.Image)
        Me.kcbtnProgressBarColour.Values.RoundedCorners = 8
        Me.kcbtnProgressBarColour.Values.Text = "Custom Color"
        Me.kcmbProgressBarStyle.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.kcmbProgressBarStyle.DropDownWidth = 261
        Me.kcmbProgressBarStyle.IntegralHeight = False
        Me.kcmbProgressBarStyle.Location = New System.Drawing.Point(373, 237)
        Me.kcmbProgressBarStyle.Name = "kcmbProgressBarStyle"
        Me.kcmbProgressBarStyle.Size = New System.Drawing.Size(179, 24)
        Me.kcmbProgressBarStyle.StateCommon.ComboBox.Content.TextH = Krypton.Toolkit.PaletteRelativeAlign.Near
        Me.kcmbProgressBarStyle.TabIndex = 26
        Me.klblColorStyle.Location = New System.Drawing.Point(262, 266)
        Me.klblColorStyle.Name = "klblColorStyle"
        Me.klblColorStyle.Size = New System.Drawing.Size(75, 21)
        Me.klblColorStyle.TabIndex = 28
        Me.klblColorStyle.Values.Text = "Color Style"
        Me.kcmbColorStyle.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.kcmbColorStyle.DropDownWidth = 179
        Me.kcmbColorStyle.IntegralHeight = False
        Me.kcmbColorStyle.Location = New System.Drawing.Point(373, 265)
        Me.kcmbColorStyle.Name = "kcmbColorStyle"
        Me.kcmbColorStyle.Size = New System.Drawing.Size(179, 24)
        Me.kcmbColorStyle.StateCommon.ComboBox.Content.TextH = Krypton.Toolkit.PaletteRelativeAlign.Near
        Me.kcmbColorStyle.TabIndex = 29
        Me.kchkShowTextBackdrop.Location = New System.Drawing.Point(43, 333)
        Me.kchkShowTextBackdrop.Name = "kchkShowTextBackdrop"
        Me.kchkShowTextBackdrop.Size = New System.Drawing.Size(141, 21)
        Me.kchkShowTextBackdrop.TabIndex = 30
        Me.kchkShowTextBackdrop.Values.Text = "Show text backdrop"
        Me.kcbtnBackdropColor.CustomColorPreviewShape = Krypton.Toolkit.KryptonColorButtonCustomColorPreviewShape.Circle
        Me.kcbtnBackdropColor.Location = New System.Drawing.Point(43, 359)
        Me.kcbtnBackdropColor.Name = "kcbtnBackdropColor"
        Me.kcbtnBackdropColor.SelectedColor = System.Drawing.Color.WhiteSmoke
        Me.kcbtnBackdropColor.Size = New System.Drawing.Size(177, 25)
        Me.kcbtnBackdropColor.TabIndex = 31
        Me.kcbtnBackdropColor.Values.Image = CType(resources.GetObject("kcbtnBackdropColor.Values.Image"), System.Drawing.Image)
        Me.kcbtnBackdropColor.Values.RoundedCorners = 8
        Me.kcbtnBackdropColor.Values.Text = "Text Backdrop Colour"
        Me.kchkUseProgressValueAsText.Checked = True
        Me.kchkUseProgressValueAsText.CheckState = System.Windows.Forms.CheckState.Checked
        Me.kchkUseProgressValueAsText.Location = New System.Drawing.Point(43, 239)
        Me.kchkUseProgressValueAsText.Name = "kchkUseProgressValueAsText"
        Me.kchkUseProgressValueAsText.Size = New System.Drawing.Size(177, 21)
        Me.kchkUseProgressValueAsText.TabIndex = 25
        Me.kchkUseProgressValueAsText.Values.Text = "Use progress value as text"
        Me.kryptonLabel2.LabelStyle = Krypton.Toolkit.LabelStyle.BoldPanel
        Me.kryptonLabel2.Location = New System.Drawing.Point(43, 12)
        Me.kryptonLabel2.Name = "kryptonLabel2"
        Me.kryptonLabel2.Size = New System.Drawing.Size(57, 21)
        Me.kryptonLabel2.TabIndex = 15
        Me.kryptonLabel2.Values.Text = "Theme:"
        Me.ktrkProgressValues.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.ktrkProgressValues.Location = New System.Drawing.Point(187, 37)
        Me.ktrkProgressValues.Maximum = 100
        Me.ktrkProgressValues.Name = "ktrkProgressValues"
        Me.ktrkProgressValues.Size = New System.Drawing.Size(590, 33)
        Me.ktrkProgressValues.TabIndex = 14
        Me.ktrkProgressValues.TickStyle = System.Windows.Forms.TickStyle.Both
        Me.ProgressBarDisabled.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.ProgressBarDisabled.Enabled = False
        Me.ProgressBarDisabled.Location = New System.Drawing.Point(43, 203)
        Me.ProgressBarDisabled.Name = "ProgressBarDisabled"
        Me.ProgressBarDisabled.RightToLeft = System.Windows.Forms.RightToLeft.Yes
        Me.ProgressBarDisabled.Size = New System.Drawing.Size(738, 23)
        Me.ProgressBarDisabled.StateCommon.Back.Color1 = System.Drawing.Color.FromArgb(CType(CType(192, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer))
        Me.ProgressBarDisabled.StateCommon.Border.DrawBorders = CType((((Krypton.Toolkit.PaletteDrawBorders.Top Or Krypton.Toolkit.PaletteDrawBorders.Bottom) Or Krypton.Toolkit.PaletteDrawBorders.Left) Or Krypton.Toolkit.PaletteDrawBorders.Right), Krypton.Toolkit.PaletteDrawBorders)
        Me.ProgressBarDisabled.StateCommon.Border.Rounding = 10F
        Me.ProgressBarDisabled.TabIndex = 12
        Me.ProgressBarDisabled.Text = "Disabled (RTL)"
        Me.ProgressBarDisabled.TextBackdropColor = System.Drawing.Color.Empty
        Me.ProgressBarDisabled.TextShadowColor = System.Drawing.Color.Empty
        Me.ProgressBarDisabled.Value = 75
        Me.ProgressBarDisabled.Values.Text = "Disabled (RTL)"
        Me.kryptonButton1.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.kryptonButton1.DialogResult = System.Windows.Forms.DialogResult.OK
        Me.kryptonButton1.Location = New System.Drawing.Point(704, 357)
        Me.kryptonButton1.Margin = New System.Windows.Forms.Padding(2)
        Me.kryptonButton1.Name = "kryptonButton1"
        Me.kryptonButton1.Size = New System.Drawing.Size(73, 29)
        Me.kryptonButton1.StateCommon.Back.Color1 = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.kryptonButton1.StateCommon.Border.DrawBorders = CType((((Krypton.Toolkit.PaletteDrawBorders.Top Or Krypton.Toolkit.PaletteDrawBorders.Bottom) Or Krypton.Toolkit.PaletteDrawBorders.Left) Or Krypton.Toolkit.PaletteDrawBorders.Right), Krypton.Toolkit.PaletteDrawBorders)
        Me.kryptonButton1.StateCommon.Border.Rounding = 10F
        Me.kryptonButton1.TabIndex = 11
        Me.kryptonButton1.Values.DropDownArrowColor = System.Drawing.Color.Empty
        Me.kryptonButton1.Values.Text = "&Close"
        Me.kryptonThemeComboBox1.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.kryptonThemeComboBox1.DefaultPalette = Krypton.Toolkit.PaletteMode.Office2007Blue
        Me.kryptonThemeComboBox1.DisplayMember = "Key"
        Me.kryptonThemeComboBox1.DropDownWidth = 321
        Me.kryptonThemeComboBox1.IntegralHeight = False
        Me.kryptonThemeComboBox1.Location = New System.Drawing.Point(104, 10)
        Me.kryptonThemeComboBox1.Margin = New System.Windows.Forms.Padding(2)
        Me.kryptonThemeComboBox1.Name = "kryptonThemeComboBox1"
        Me.kryptonThemeComboBox1.Size = New System.Drawing.Size(677, 24)
        Me.kryptonThemeComboBox1.StateCommon.ComboBox.Content.TextH = Krypton.Toolkit.PaletteRelativeAlign.Near
        Me.kryptonThemeComboBox1.TabIndex = 10
        Me.kryptonThemeComboBox1.ValueMember = "Value"
        Me.pbVertical.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) Or System.Windows.Forms.AnchorStyles.Left), System.Windows.Forms.AnchorStyles)
        Me.pbVertical.Location = New System.Drawing.Point(10, 10)
        Me.pbVertical.Margin = New System.Windows.Forms.Padding(2)
        Me.pbVertical.Name = "pbVertical"
        Me.pbVertical.Orientation = Krypton.Toolkit.VisualOrientation.Left
        Me.pbVertical.Size = New System.Drawing.Size(24, 376)
        Me.pbVertical.Style = System.Windows.Forms.ProgressBarStyle.Marquee
        Me.pbVertical.TabIndex = 9
        Me.pbVertical.Text = "75%"
        Me.pbVertical.TextBackdropColor = System.Drawing.Color.Empty
        Me.pbVertical.TextShadowColor = System.Drawing.Color.Empty
        Me.pbVertical.UseValueAsText = True
        Me.pbVertical.Value = 75
        Me.pbVertical.Values.Text = "75%"
        Me.pbCustomColor.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.pbCustomColor.Location = New System.Drawing.Point(43, 165)
        Me.pbCustomColor.Name = "pbCustomColor"
        Me.pbCustomColor.Size = New System.Drawing.Size(738, 23)
        Me.pbCustomColor.StateCommon.Back.Color1 = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(192, Byte), Integer), CType(CType(0, Byte), Integer))
        Me.pbCustomColor.StateCommon.Border.DrawBorders = CType((((Krypton.Toolkit.PaletteDrawBorders.Top Or Krypton.Toolkit.PaletteDrawBorders.Bottom) Or Krypton.Toolkit.PaletteDrawBorders.Left) Or Krypton.Toolkit.PaletteDrawBorders.Right), Krypton.Toolkit.PaletteDrawBorders)
        Me.pbCustomColor.StateCommon.Border.Rounding = 10F
        Me.pbCustomColor.Style = System.Windows.Forms.ProgressBarStyle.Blocks
        Me.pbCustomColor.TabIndex = 8
        Me.pbCustomColor.Text = "75%"
        Me.pbCustomColor.TextBackdropColor = System.Drawing.Color.Empty
        Me.pbCustomColor.TextShadowColor = System.Drawing.Color.Empty
        Me.pbCustomColor.UseValueAsText = True
        Me.pbCustomColor.Value = 75
        Me.pbCustomColor.Values.ExtraText = " (Custom Color)"
        Me.pbCustomColor.Values.Text = "75%"
        Me.pbHorizontal2.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.pbHorizontal2.Location = New System.Drawing.Point(43, 130)
        Me.pbHorizontal2.Name = "pbHorizontal2"
        Me.pbHorizontal2.Size = New System.Drawing.Size(738, 23)
        Me.pbHorizontal2.StateCommon.Back.Color1 = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(224, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.pbHorizontal2.Style = System.Windows.Forms.ProgressBarStyle.Marquee
        Me.pbHorizontal2.TabIndex = 7
        Me.pbHorizontal2.Text = "75%"
        Me.pbHorizontal2.TextBackdropColor = System.Drawing.Color.Empty
        Me.pbHorizontal2.TextShadowColor = System.Drawing.Color.Empty
        Me.pbHorizontal2.UseValueAsText = True
        Me.pbHorizontal2.Value = 75
        Me.pbHorizontal2.Values.Text = "75%"
        Me.pbHorizontal.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.pbHorizontal.Location = New System.Drawing.Point(43, 79)
        Me.pbHorizontal.Name = "pbHorizontal"
        Me.pbHorizontal.Size = New System.Drawing.Size(738, 45)
        Me.pbHorizontal.StateCommon.Back.Color1 = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(128, Byte), Integer))
        Me.pbHorizontal.StateCommon.Back.Draw = Krypton.Toolkit.InheritBool.True
        Me.pbHorizontal.TabIndex = 4
        Me.pbHorizontal.Text = "75%"
        Me.pbHorizontal.TextBackdropColor = System.Drawing.Color.Empty
        Me.pbHorizontal.TextShadowColor = System.Drawing.Color.Empty
        Me.pbHorizontal.UseValueAsText = True
        Me.pbHorizontal.Value = 75
        Me.pbHorizontal.Values.ExtraText = "of 100"
        Me.pbHorizontal.Values.Text = "75%"
        Me.knudHorizontal.Increment = New Decimal(New Integer() { 1, 0, 0, 0})
        Me.knudHorizontal.Location = New System.Drawing.Point(104, 41)
        Me.knudHorizontal.Maximum = New Decimal(New Integer() { 100, 0, 0, 0})
        Me.knudHorizontal.Minimum = New Decimal(New Integer() { 0, 0, 0, 0})
        Me.knudHorizontal.Name = "knudHorizontal"
        Me.knudHorizontal.Size = New System.Drawing.Size(71, 24)
        Me.knudHorizontal.TabIndex = 3
        Me.knudHorizontal.Value = New Decimal(New Integer() { 0, 0, 0, 0})
        Me.kryptonLabel1.LabelStyle = Krypton.Toolkit.LabelStyle.BoldPanel
        Me.kryptonLabel1.Location = New System.Drawing.Point(43, 43)
        Me.kryptonLabel1.Name = "kryptonLabel1"
        Me.kryptonLabel1.Size = New System.Drawing.Size(50, 21)
        Me.kryptonLabel1.TabIndex = 2
        Me.kryptonLabel1.Values.Text = "Value:"
        Me.kryptonManager1.BaseFont = New System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.kryptonManager1.GlobalPaletteMode = Krypton.Toolkit.PaletteMode.Office2007Blue
        Me.kryptonManager1.ToolkitStrings.MessageBoxStrings.LessDetails = "L&ess Details..."
        Me.kryptonManager1.ToolkitStrings.MessageBoxStrings.MoreDetails = "&More Details..."
        Me.statusStrip1.Font = New System.Drawing.Font("Segoe UI", 9F)
        Me.statusStrip1.ImageScalingSize = New System.Drawing.Size(20, 20)
        Me.statusStrip1.Items.AddRange(New System.Windows.Forms.ToolStripItem() { Me.kryptonProgressBarToolStripItem1})
        Me.statusStrip1.Location = New System.Drawing.Point(0, 398)
        Me.statusStrip1.Name = "statusStrip1"
        Me.statusStrip1.RenderMode = System.Windows.Forms.ToolStripRenderMode.ManagerRenderMode
        Me.statusStrip1.Size = New System.Drawing.Size(799, 24)
        Me.statusStrip1.TabIndex = 1
        Me.statusStrip1.Text = "statusStrip1"
        Me.kryptonProgressBarToolStripItem1.Name = "kryptonProgressBarToolStripItem1"
        Me.kryptonProgressBarToolStripItem1.StateCommon.Back.Color1 = System.Drawing.Color.Green
        Me.kryptonProgressBarToolStripItem1.StateDisabled.Back.ColorStyle = Krypton.Toolkit.PaletteColorStyle.OneNote
        Me.kryptonProgressBarToolStripItem1.StateNormal.Back.ColorStyle = Krypton.Toolkit.PaletteColorStyle.OneNote
        Me.kryptonProgressBarToolStripItem1.Text = "0%"
        Me.kryptonProgressBarToolStripItem1.UseValueAsText = True
        Me.kryptonProgressBarToolStripItem1.Values.Text = "0%"
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6F, 13F)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(799, 422)
        Me.Controls.Add(Me.statusStrip1)
        Me.Controls.Add(Me.kryptonPanel1)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow
        Me.MaximizeBox = False
        Me.Name = "Form1"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Krypton ProgressBar Examples"
        CType(Me.kryptonPanel1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.kryptonPanel1.ResumeLayout(False)
        Me.kryptonPanel1.PerformLayout()
        CType(Me.kcmbProgressBarStyle, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.kcmbColorStyle, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.kryptonThemeComboBox1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.statusStrip1.ResumeLayout(False)
        Me.statusStrip1.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()
    End Sub

    Friend WithEvents kryptonPanel1 As Krypton.Toolkit.KryptonPanel
    Friend WithEvents pbHorizontal2 As Krypton.Toolkit.KryptonProgressBar
    Friend WithEvents pbHorizontal As Krypton.Toolkit.KryptonProgressBar
    Friend WithEvents knudHorizontal As Krypton.Toolkit.KryptonNumericUpDown
    Friend WithEvents kryptonLabel1 As Krypton.Toolkit.KryptonLabel
    Friend WithEvents pbCustomColor As Krypton.Toolkit.KryptonProgressBar
    Friend WithEvents pbVertical As Krypton.Toolkit.KryptonProgressBar
    Friend WithEvents kryptonThemeComboBox1 As Krypton.Toolkit.KryptonThemeComboBox
    Friend WithEvents kryptonManager1 As Krypton.Toolkit.KryptonManager
    Friend WithEvents kryptonButton1 As Krypton.Toolkit.KryptonButton
    Friend WithEvents ProgressBarDisabled As Krypton.Toolkit.KryptonProgressBar
    Friend WithEvents statusStrip1 As System.Windows.Forms.StatusStrip
    Friend WithEvents kryptonProgressBarToolStripItem1 As Krypton.Toolkit.KryptonProgressBarToolStripItem
    Friend WithEvents kryptonLabel2 As Krypton.Toolkit.KryptonLabel
    Friend WithEvents ktrkProgressValues As Krypton.Toolkit.KryptonTrackBar
    Friend WithEvents kchkShowTextShadow As Krypton.Toolkit.KryptonCheckBox
    Friend WithEvents kryptonLabel3 As Krypton.Toolkit.KryptonLabel
    Friend WithEvents kcbtnProgressBarColour As Krypton.Toolkit.KryptonColorButton
    Friend WithEvents kcmbProgressBarStyle As Krypton.Toolkit.KryptonComboBox
    Friend WithEvents klblColorStyle As Krypton.Toolkit.KryptonLabel
    Friend WithEvents kcmbColorStyle As Krypton.Toolkit.KryptonComboBox
    Friend WithEvents kchkShowTextBackdrop As Krypton.Toolkit.KryptonCheckBox
    Friend WithEvents kcbtnBackdropColor As Krypton.Toolkit.KryptonColorButton
    Friend WithEvents kchkUseProgressValueAsText As Krypton.Toolkit.KryptonCheckBox
End Class
