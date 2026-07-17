' VB.NET twin of Source\Krypton Toolkit Examples\KryptonMaskedTextBox Examples\Form1.Designer.cs (Bastion Phase 4c).
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
        Me.buttonClose = New System.Windows.Forms.Button()
        Me.groupBox4 = New System.Windows.Forms.GroupBox()
        Me.propertyGrid = New System.Windows.Forms.PropertyGrid()
        Me.groupBox3 = New System.Windows.Forms.GroupBox()
        Me.maskedTextBox9Custom = New Krypton.Toolkit.KryptonMaskedTextBox()
        Me.buttonSpecAny2 = New Krypton.Toolkit.ButtonSpecAny()
        Me.kryptonContextMenu = New Krypton.Toolkit.KryptonContextMenu()
        Me.kryptonContextMenuItems1 = New Krypton.Toolkit.KryptonContextMenuItems()
        Me.kryptonContextMenuItem1 = New Krypton.Toolkit.KryptonContextMenuItem()
        Me.kryptonContextMenuItem2 = New Krypton.Toolkit.KryptonContextMenuItem()
        Me.kryptonContextMenuSeparator1 = New Krypton.Toolkit.KryptonContextMenuSeparator()
        Me.kryptonContextMenuItem3 = New Krypton.Toolkit.KryptonContextMenuItem()
        Me.maskedTextBox8Custom = New Krypton.Toolkit.KryptonMaskedTextBox()
        Me.maskedTextBox7Custom = New Krypton.Toolkit.KryptonMaskedTextBox()
        Me.groupBox1 = New System.Windows.Forms.GroupBox()
        Me.label6 = New System.Windows.Forms.Label()
        Me.label5 = New System.Windows.Forms.Label()
        Me.label4 = New System.Windows.Forms.Label()
        Me.maskedTextBox6System = New Krypton.Toolkit.KryptonMaskedTextBox()
        Me.maskedTextBox5System = New Krypton.Toolkit.KryptonMaskedTextBox()
        Me.buttonSpecAny3 = New Krypton.Toolkit.ButtonSpecAny()
        Me.maskedTextBox4System = New Krypton.Toolkit.KryptonMaskedTextBox()
        Me.groupBox2 = New System.Windows.Forms.GroupBox()
        Me.label3 = New System.Windows.Forms.Label()
        Me.label2 = New System.Windows.Forms.Label()
        Me.label1 = New System.Windows.Forms.Label()
        Me.maskedTextBox3Blue = New Krypton.Toolkit.KryptonMaskedTextBox()
        Me.maskedTextBox2Blue = New Krypton.Toolkit.KryptonMaskedTextBox()
        Me.buttonSpecAny1 = New Krypton.Toolkit.ButtonSpecAny()
        Me.maskedTextBox1Blue = New Krypton.Toolkit.KryptonMaskedTextBox()
        Me.groupBox4.SuspendLayout()
        Me.groupBox3.SuspendLayout()
        Me.groupBox1.SuspendLayout()
        Me.groupBox2.SuspendLayout()
        Me.SuspendLayout()
        Me.buttonClose.DialogResult = System.Windows.Forms.DialogResult.Cancel
        Me.buttonClose.Location = New System.Drawing.Point(532, 464)
        Me.buttonClose.Name = "buttonClose"
        Me.buttonClose.Size = New System.Drawing.Size(75, 23)
        Me.buttonClose.TabIndex = 4
        Me.buttonClose.Text = "&Close"
        Me.buttonClose.UseVisualStyleBackColor = True
        Me.groupBox4.Controls.Add(Me.propertyGrid)
        Me.groupBox4.Location = New System.Drawing.Point(285, 12)
        Me.groupBox4.Name = "groupBox4"
        Me.groupBox4.Size = New System.Drawing.Size(322, 446)
        Me.groupBox4.TabIndex = 3
        Me.groupBox4.TabStop = False
        Me.groupBox4.Text = "Properties for Selected KryptonMaskedTextBox"
        Me.propertyGrid.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) Or System.Windows.Forms.AnchorStyles.Left) Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.propertyGrid.Location = New System.Drawing.Point(6, 19)
        Me.propertyGrid.Name = "propertyGrid"
        Me.propertyGrid.Size = New System.Drawing.Size(310, 421)
        Me.propertyGrid.TabIndex = 0
        Me.propertyGrid.ToolbarVisible = False
        Me.groupBox3.Controls.Add(Me.maskedTextBox9Custom)
        Me.groupBox3.Controls.Add(Me.maskedTextBox8Custom)
        Me.groupBox3.Controls.Add(Me.maskedTextBox7Custom)
        Me.groupBox3.Location = New System.Drawing.Point(12, 300)
        Me.groupBox3.Name = "groupBox3"
        Me.groupBox3.Size = New System.Drawing.Size(267, 158)
        Me.groupBox3.TabIndex = 2
        Me.groupBox3.TabStop = False
        Me.groupBox3.Text = "Custom Settings"
        Me.maskedTextBox9Custom.ButtonSpecs.AddRange(New Krypton.Toolkit.ButtonSpecAny() { Me.buttonSpecAny2})
        Me.maskedTextBox9Custom.CutCopyMaskFormat = System.Windows.Forms.MaskFormat.IncludeLiterals
        Me.maskedTextBox9Custom.InsertKeyMode = System.Windows.Forms.InsertKeyMode.Default
        Me.maskedTextBox9Custom.Location = New System.Drawing.Point(16, 115)
        Me.maskedTextBox9Custom.Mask = "00/00/0000"
        Me.maskedTextBox9Custom.Name = "maskedTextBox9Custom"
        Me.maskedTextBox9Custom.PaletteMode = Krypton.Toolkit.PaletteMode.Office2007Silver
        Me.maskedTextBox9Custom.PromptChar = "-"c
        Me.maskedTextBox9Custom.Size = New System.Drawing.Size(161, 25)
        Me.maskedTextBox9Custom.StateCommon.Border.Color1 = System.Drawing.Color.Silver
        Me.maskedTextBox9Custom.StateCommon.Border.Color2 = System.Drawing.Color.Gray
        Me.maskedTextBox9Custom.StateCommon.Border.ColorAlign = Krypton.Toolkit.PaletteRectangleAlign.Inherit
        Me.maskedTextBox9Custom.StateCommon.Border.ColorAngle = 80F
        Me.maskedTextBox9Custom.StateCommon.Border.ColorStyle = Krypton.Toolkit.PaletteColorStyle.Rounded
        Me.maskedTextBox9Custom.StateCommon.Border.Draw = Krypton.Toolkit.InheritBool.Inherit
        Me.maskedTextBox9Custom.StateCommon.Border.DrawBorders = CType((((Krypton.Toolkit.PaletteDrawBorders.Top Or Krypton.Toolkit.PaletteDrawBorders.Bottom) Or Krypton.Toolkit.PaletteDrawBorders.Left) Or Krypton.Toolkit.PaletteDrawBorders.Right), Krypton.Toolkit.PaletteDrawBorders)
        Me.maskedTextBox9Custom.StateCommon.Border.GraphicsHint = Krypton.Toolkit.PaletteGraphicsHint.AntiAlias
        Me.maskedTextBox9Custom.StateCommon.Border.ImageAlign = Krypton.Toolkit.PaletteRectangleAlign.Inherit
        Me.maskedTextBox9Custom.StateCommon.Border.Rounding = 3F
        Me.maskedTextBox9Custom.StateCommon.Border.Width = 1
        Me.maskedTextBox9Custom.TabIndex = 2
        Me.maskedTextBox9Custom.Text = " / /"
        Me.maskedTextBox9Custom.TextAlign = System.Windows.Forms.HorizontalAlignment.Left
        Me.maskedTextBox9Custom.TextMaskFormat = System.Windows.Forms.MaskFormat.IncludeLiterals
        Me.buttonSpecAny2.KryptonContextMenu = Me.kryptonContextMenu
        Me.buttonSpecAny2.Style = Krypton.Toolkit.PaletteButtonStyle.Standalone
        Me.buttonSpecAny2.Type = Krypton.Toolkit.PaletteButtonSpecStyle.Context
        Me.buttonSpecAny2.UniqueName = "AFADF6E71C27433DAFADF6E71C27433D"
        Me.kryptonContextMenu.Items.AddRange(New Krypton.Toolkit.KryptonContextMenuItemBase() { Me.kryptonContextMenuItems1})
        Me.kryptonContextMenuItems1.Items.AddRange(New Krypton.Toolkit.KryptonContextMenuItemBase() { Me.kryptonContextMenuItem1, Me.kryptonContextMenuItem2, Me.kryptonContextMenuSeparator1, Me.kryptonContextMenuItem3})
        Me.kryptonContextMenuItem1.CheckState = System.Windows.Forms.CheckState.Unchecked
        Me.kryptonContextMenuItem1.ShortcutKeys = System.Windows.Forms.Keys.None
        Me.kryptonContextMenuItem1.Text = "DateTime.Now"
        Me.kryptonContextMenuItem2.CheckState = System.Windows.Forms.CheckState.Unchecked
        Me.kryptonContextMenuItem2.ShortcutKeys = System.Windows.Forms.Keys.None
        Me.kryptonContextMenuItem2.Text = "Previous Date"
        Me.kryptonContextMenuItem3.CheckState = System.Windows.Forms.CheckState.Unchecked
        Me.kryptonContextMenuItem3.ShortcutKeys = System.Windows.Forms.Keys.None
        Me.kryptonContextMenuItem3.Text = "Clear"
        Me.maskedTextBox8Custom.CutCopyMaskFormat = System.Windows.Forms.MaskFormat.IncludeLiterals
        Me.maskedTextBox8Custom.InsertKeyMode = System.Windows.Forms.InsertKeyMode.Default
        Me.maskedTextBox8Custom.Location = New System.Drawing.Point(16, 72)
        Me.maskedTextBox8Custom.Name = "maskedTextBox8Custom"
        Me.maskedTextBox8Custom.PaletteMode = Krypton.Toolkit.PaletteMode.ProfessionalOffice2003
        Me.maskedTextBox8Custom.PasswordChar = "●"c
        Me.maskedTextBox8Custom.Size = New System.Drawing.Size(161, 27)
        Me.maskedTextBox8Custom.StateCommon.Border.ColorAlign = Krypton.Toolkit.PaletteRectangleAlign.Inherit
        Me.maskedTextBox8Custom.StateCommon.Border.ColorStyle = Krypton.Toolkit.PaletteColorStyle.Inherit
        Me.maskedTextBox8Custom.StateCommon.Border.Draw = Krypton.Toolkit.InheritBool.Inherit
        Me.maskedTextBox8Custom.StateCommon.Border.DrawBorders = CType((((Krypton.Toolkit.PaletteDrawBorders.Top Or Krypton.Toolkit.PaletteDrawBorders.Bottom) Or Krypton.Toolkit.PaletteDrawBorders.Left) Or Krypton.Toolkit.PaletteDrawBorders.Right), Krypton.Toolkit.PaletteDrawBorders)
        Me.maskedTextBox8Custom.StateCommon.Border.GraphicsHint = Krypton.Toolkit.PaletteGraphicsHint.AntiAlias
        Me.maskedTextBox8Custom.StateCommon.Border.ImageAlign = Krypton.Toolkit.PaletteRectangleAlign.Inherit
        Me.maskedTextBox8Custom.StateCommon.Border.Rounding = 4F
        Me.maskedTextBox8Custom.StateCommon.Border.Width = 2
        Me.maskedTextBox8Custom.TabIndex = 1
        Me.maskedTextBox8Custom.Text = "Password"
        Me.maskedTextBox8Custom.TextAlign = System.Windows.Forms.HorizontalAlignment.Left
        Me.maskedTextBox8Custom.TextMaskFormat = System.Windows.Forms.MaskFormat.IncludeLiterals
        Me.maskedTextBox8Custom.UseSystemPasswordChar = True
        Me.maskedTextBox7Custom.AlwaysActive = False
        Me.maskedTextBox7Custom.CutCopyMaskFormat = System.Windows.Forms.MaskFormat.IncludeLiterals
        Me.maskedTextBox7Custom.InsertKeyMode = System.Windows.Forms.InsertKeyMode.Default
        Me.maskedTextBox7Custom.Location = New System.Drawing.Point(16, 29)
        Me.maskedTextBox7Custom.Name = "maskedTextBox7Custom"
        Me.maskedTextBox7Custom.PaletteMode = Krypton.Toolkit.PaletteMode.ProfessionalOffice2003
        Me.maskedTextBox7Custom.Size = New System.Drawing.Size(161, 26)
        Me.maskedTextBox7Custom.StateActive.Border.Color1 = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(128, Byte), Integer), CType(CType(0, Byte), Integer))
        Me.maskedTextBox7Custom.StateActive.Border.ColorAlign = Krypton.Toolkit.PaletteRectangleAlign.Inherit
        Me.maskedTextBox7Custom.StateActive.Border.ColorStyle = Krypton.Toolkit.PaletteColorStyle.Inherit
        Me.maskedTextBox7Custom.StateActive.Border.Draw = Krypton.Toolkit.InheritBool.Inherit
        Me.maskedTextBox7Custom.StateActive.Border.DrawBorders = CType((((Krypton.Toolkit.PaletteDrawBorders.Top Or Krypton.Toolkit.PaletteDrawBorders.Bottom) Or Krypton.Toolkit.PaletteDrawBorders.Left) Or Krypton.Toolkit.PaletteDrawBorders.Right), Krypton.Toolkit.PaletteDrawBorders)
        Me.maskedTextBox7Custom.StateActive.Border.GraphicsHint = Krypton.Toolkit.PaletteGraphicsHint.Inherit
        Me.maskedTextBox7Custom.StateActive.Border.ImageAlign = Krypton.Toolkit.PaletteRectangleAlign.Inherit
        Me.maskedTextBox7Custom.StateCommon.Border.ColorAlign = Krypton.Toolkit.PaletteRectangleAlign.Inherit
        Me.maskedTextBox7Custom.StateCommon.Border.ColorStyle = Krypton.Toolkit.PaletteColorStyle.Inherit
        Me.maskedTextBox7Custom.StateCommon.Border.Draw = Krypton.Toolkit.InheritBool.Inherit
        Me.maskedTextBox7Custom.StateCommon.Border.DrawBorders = CType((((Krypton.Toolkit.PaletteDrawBorders.Top Or Krypton.Toolkit.PaletteDrawBorders.Bottom) Or Krypton.Toolkit.PaletteDrawBorders.Left) Or Krypton.Toolkit.PaletteDrawBorders.Right), Krypton.Toolkit.PaletteDrawBorders)
        Me.maskedTextBox7Custom.StateCommon.Border.GraphicsHint = Krypton.Toolkit.PaletteGraphicsHint.AntiAlias
        Me.maskedTextBox7Custom.StateCommon.Border.ImageAlign = Krypton.Toolkit.PaletteRectangleAlign.Inherit
        Me.maskedTextBox7Custom.StateCommon.Border.Rounding = 4F
        Me.maskedTextBox7Custom.StateCommon.Border.Width = 2
        Me.maskedTextBox7Custom.TabIndex = 0
        Me.maskedTextBox7Custom.Text = "Orange when Active"
        Me.maskedTextBox7Custom.TextAlign = System.Windows.Forms.HorizontalAlignment.Left
        Me.maskedTextBox7Custom.TextMaskFormat = System.Windows.Forms.MaskFormat.IncludeLiterals
        Me.groupBox1.Controls.Add(Me.label6)
        Me.groupBox1.Controls.Add(Me.label5)
        Me.groupBox1.Controls.Add(Me.label4)
        Me.groupBox1.Controls.Add(Me.maskedTextBox6System)
        Me.groupBox1.Controls.Add(Me.maskedTextBox5System)
        Me.groupBox1.Controls.Add(Me.maskedTextBox4System)
        Me.groupBox1.Location = New System.Drawing.Point(12, 156)
        Me.groupBox1.Name = "groupBox1"
        Me.groupBox1.Size = New System.Drawing.Size(267, 138)
        Me.groupBox1.TabIndex = 1
        Me.groupBox1.TabStop = False
        Me.groupBox1.Text = "Professional - System"
        Me.label6.AutoSize = True
        Me.label6.Location = New System.Drawing.Point(28, 85)
        Me.label6.Name = "label6"
        Me.label6.Size = New System.Drawing.Size(67, 13)
        Me.label6.TabIndex = 7
        Me.label6.Text = "Ribbon Style"
        Me.label5.AutoSize = True
        Me.label5.Location = New System.Drawing.Point(31, 58)
        Me.label5.Name = "label5"
        Me.label5.Size = New System.Drawing.Size(64, 13)
        Me.label5.TabIndex = 6
        Me.label5.Text = "7 Digit Mask"
        Me.label4.AutoSize = True
        Me.label4.Location = New System.Drawing.Point(9, 32)
        Me.label4.Name = "label4"
        Me.label4.Size = New System.Drawing.Size(86, 13)
        Me.label4.TabIndex = 5
        Me.label4.Text = "Short Date Mask"
        Me.maskedTextBox6System.AlwaysActive = False
        Me.maskedTextBox6System.CutCopyMaskFormat = System.Windows.Forms.MaskFormat.IncludeLiterals
        Me.maskedTextBox6System.InputControlStyle = Krypton.Toolkit.InputControlStyle.Ribbon
        Me.maskedTextBox6System.InsertKeyMode = System.Windows.Forms.InsertKeyMode.Default
        Me.maskedTextBox6System.Location = New System.Drawing.Point(136, 85)
        Me.maskedTextBox6System.Mask = "00/00/0000"
        Me.maskedTextBox6System.Name = "maskedTextBox6System"
        Me.maskedTextBox6System.PaletteMode = Krypton.Toolkit.PaletteMode.ProfessionalSystem
        Me.maskedTextBox6System.PromptChar = "?"c
        Me.maskedTextBox6System.Size = New System.Drawing.Size(76, 20)
        Me.maskedTextBox6System.TabIndex = 2
        Me.maskedTextBox6System.Text = " / /"
        Me.maskedTextBox6System.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        Me.maskedTextBox6System.TextMaskFormat = System.Windows.Forms.MaskFormat.IncludeLiterals
        Me.maskedTextBox5System.AllowButtonSpecToolTips = True
        Me.maskedTextBox5System.ButtonSpecs.AddRange(New Krypton.Toolkit.ButtonSpecAny() { Me.buttonSpecAny3})
        Me.maskedTextBox5System.CutCopyMaskFormat = System.Windows.Forms.MaskFormat.IncludeLiterals
        Me.maskedTextBox5System.InsertKeyMode = System.Windows.Forms.InsertKeyMode.Default
        Me.maskedTextBox5System.Location = New System.Drawing.Point(136, 58)
        Me.maskedTextBox5System.Mask = "0000000"
        Me.maskedTextBox5System.Name = "maskedTextBox5System"
        Me.maskedTextBox5System.PaletteMode = Krypton.Toolkit.PaletteMode.ProfessionalSystem
        Me.maskedTextBox5System.PromptChar = "-"c
        Me.maskedTextBox5System.Size = New System.Drawing.Size(76, 20)
        Me.maskedTextBox5System.TabIndex = 1
        Me.maskedTextBox5System.TextAlign = System.Windows.Forms.HorizontalAlignment.Left
        Me.maskedTextBox5System.TextMaskFormat = System.Windows.Forms.MaskFormat.IncludeLiterals
        Me.buttonSpecAny3.Type = Krypton.Toolkit.PaletteButtonSpecStyle.Close
        Me.buttonSpecAny3.UniqueName = "0D0CBE484603438F0D0CBE484603438F"
        Me.maskedTextBox4System.CutCopyMaskFormat = System.Windows.Forms.MaskFormat.IncludeLiterals
        Me.maskedTextBox4System.InsertKeyMode = System.Windows.Forms.InsertKeyMode.Default
        Me.maskedTextBox4System.Location = New System.Drawing.Point(136, 32)
        Me.maskedTextBox4System.Mask = "00/00/0000"
        Me.maskedTextBox4System.Name = "maskedTextBox4System"
        Me.maskedTextBox4System.PaletteMode = Krypton.Toolkit.PaletteMode.ProfessionalSystem
        Me.maskedTextBox4System.Size = New System.Drawing.Size(76, 21)
        Me.maskedTextBox4System.TabIndex = 0
        Me.maskedTextBox4System.Text = " / /"
        Me.maskedTextBox4System.TextAlign = System.Windows.Forms.HorizontalAlignment.Left
        Me.maskedTextBox4System.TextMaskFormat = System.Windows.Forms.MaskFormat.IncludeLiterals
        Me.groupBox2.Controls.Add(Me.label3)
        Me.groupBox2.Controls.Add(Me.label2)
        Me.groupBox2.Controls.Add(Me.label1)
        Me.groupBox2.Controls.Add(Me.maskedTextBox3Blue)
        Me.groupBox2.Controls.Add(Me.maskedTextBox2Blue)
        Me.groupBox2.Controls.Add(Me.maskedTextBox1Blue)
        Me.groupBox2.Location = New System.Drawing.Point(12, 12)
        Me.groupBox2.Name = "groupBox2"
        Me.groupBox2.Size = New System.Drawing.Size(267, 138)
        Me.groupBox2.TabIndex = 0
        Me.groupBox2.TabStop = False
        Me.groupBox2.Text = "Office 2010 - Blue"
        Me.label3.AutoSize = True
        Me.label3.Location = New System.Drawing.Point(28, 89)
        Me.label3.Name = "label3"
        Me.label3.Size = New System.Drawing.Size(67, 13)
        Me.label3.TabIndex = 6
        Me.label3.Text = "Ribbon Style"
        Me.label2.AutoSize = True
        Me.label2.Location = New System.Drawing.Point(31, 62)
        Me.label2.Name = "label2"
        Me.label2.Size = New System.Drawing.Size(64, 13)
        Me.label2.TabIndex = 5
        Me.label2.Text = "7 Digit Mask"
        Me.label1.AutoSize = True
        Me.label1.Location = New System.Drawing.Point(9, 35)
        Me.label1.Name = "label1"
        Me.label1.Size = New System.Drawing.Size(86, 13)
        Me.label1.TabIndex = 4
        Me.label1.Text = "Short Date Mask"
        Me.maskedTextBox3Blue.AlwaysActive = False
        Me.maskedTextBox3Blue.CutCopyMaskFormat = System.Windows.Forms.MaskFormat.IncludeLiterals
        Me.maskedTextBox3Blue.InputControlStyle = Krypton.Toolkit.InputControlStyle.Ribbon
        Me.maskedTextBox3Blue.InsertKeyMode = System.Windows.Forms.InsertKeyMode.Default
        Me.maskedTextBox3Blue.Location = New System.Drawing.Point(136, 79)
        Me.maskedTextBox3Blue.Mask = "00/00/0000"
        Me.maskedTextBox3Blue.Name = "maskedTextBox3Blue"
        Me.maskedTextBox3Blue.PaletteMode = Krypton.Toolkit.PaletteMode.Office2010Blue
        Me.maskedTextBox3Blue.PromptChar = "?"c
        Me.maskedTextBox3Blue.Size = New System.Drawing.Size(76, 23)
        Me.maskedTextBox3Blue.TabIndex = 2
        Me.maskedTextBox3Blue.Text = " / /"
        Me.maskedTextBox3Blue.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        Me.maskedTextBox3Blue.TextMaskFormat = System.Windows.Forms.MaskFormat.IncludeLiterals
        Me.maskedTextBox2Blue.AllowButtonSpecToolTips = True
        Me.maskedTextBox2Blue.ButtonSpecs.AddRange(New Krypton.Toolkit.ButtonSpecAny() { Me.buttonSpecAny1})
        Me.maskedTextBox2Blue.CutCopyMaskFormat = System.Windows.Forms.MaskFormat.IncludeLiterals
        Me.maskedTextBox2Blue.InsertKeyMode = System.Windows.Forms.InsertKeyMode.Default
        Me.maskedTextBox2Blue.Location = New System.Drawing.Point(136, 52)
        Me.maskedTextBox2Blue.Mask = "0000000"
        Me.maskedTextBox2Blue.Name = "maskedTextBox2Blue"
        Me.maskedTextBox2Blue.PaletteMode = Krypton.Toolkit.PaletteMode.Office2010Blue
        Me.maskedTextBox2Blue.PromptChar = "-"c
        Me.maskedTextBox2Blue.Size = New System.Drawing.Size(76, 23)
        Me.maskedTextBox2Blue.TabIndex = 1
        Me.maskedTextBox2Blue.TextAlign = System.Windows.Forms.HorizontalAlignment.Left
        Me.maskedTextBox2Blue.TextMaskFormat = System.Windows.Forms.MaskFormat.IncludeLiterals
        Me.buttonSpecAny1.Type = Krypton.Toolkit.PaletteButtonSpecStyle.Close
        Me.buttonSpecAny1.UniqueName = "2600D6A1691343B72600D6A1691343B7"
        Me.maskedTextBox1Blue.CutCopyMaskFormat = System.Windows.Forms.MaskFormat.IncludeLiterals
        Me.maskedTextBox1Blue.InsertKeyMode = System.Windows.Forms.InsertKeyMode.Default
        Me.maskedTextBox1Blue.Location = New System.Drawing.Point(136, 25)
        Me.maskedTextBox1Blue.Mask = "00/00/0000"
        Me.maskedTextBox1Blue.Name = "maskedTextBox1Blue"
        Me.maskedTextBox1Blue.PaletteMode = Krypton.Toolkit.PaletteMode.Office2010Blue
        Me.maskedTextBox1Blue.Size = New System.Drawing.Size(76, 26)
        Me.maskedTextBox1Blue.StateCommon.Content.Color1 = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(128, Byte), Integer), CType(CType(0, Byte), Integer))
        Me.maskedTextBox1Blue.StateCommon.Content.Font = New System.Drawing.Font("Segoe UI", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.maskedTextBox1Blue.TabIndex = 0
        Me.maskedTextBox1Blue.Text = " / /"
        Me.maskedTextBox1Blue.TextAlign = System.Windows.Forms.HorizontalAlignment.Left
        Me.maskedTextBox1Blue.TextMaskFormat = System.Windows.Forms.MaskFormat.IncludeLiterals
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6F, 13F)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(619, 532)
        Me.Controls.Add(Me.groupBox3)
        Me.Controls.Add(Me.groupBox1)
        Me.Controls.Add(Me.groupBox2)
        Me.Controls.Add(Me.buttonClose)
        Me.Controls.Add(Me.groupBox4)
        Me.Font = New System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.MaximizeBox = False
        Me.MinimizeBox = False
        Me.Name = "Form1"
        Me.Text = "KryptonMaskedTextBox Examples"
        Me.groupBox4.ResumeLayout(False)
        Me.groupBox3.ResumeLayout(False)
        Me.groupBox3.PerformLayout()
        Me.groupBox1.ResumeLayout(False)
        Me.groupBox1.PerformLayout()
        Me.groupBox2.ResumeLayout(False)
        Me.groupBox2.PerformLayout()
        Me.ResumeLayout(False)
    End Sub

    Friend WithEvents buttonClose As System.Windows.Forms.Button
    Friend WithEvents groupBox4 As System.Windows.Forms.GroupBox
    Friend WithEvents groupBox3 As System.Windows.Forms.GroupBox
    Friend WithEvents groupBox1 As System.Windows.Forms.GroupBox
    Friend WithEvents groupBox2 As System.Windows.Forms.GroupBox
    Friend WithEvents propertyGrid As System.Windows.Forms.PropertyGrid
    Friend WithEvents maskedTextBox3Blue As Krypton.Toolkit.KryptonMaskedTextBox
    Friend WithEvents maskedTextBox2Blue As Krypton.Toolkit.KryptonMaskedTextBox
    Friend WithEvents maskedTextBox1Blue As Krypton.Toolkit.KryptonMaskedTextBox
    Friend WithEvents maskedTextBox6System As Krypton.Toolkit.KryptonMaskedTextBox
    Friend WithEvents maskedTextBox5System As Krypton.Toolkit.KryptonMaskedTextBox
    Friend WithEvents maskedTextBox4System As Krypton.Toolkit.KryptonMaskedTextBox
    Friend WithEvents maskedTextBox8Custom As Krypton.Toolkit.KryptonMaskedTextBox
    Friend WithEvents maskedTextBox7Custom As Krypton.Toolkit.KryptonMaskedTextBox
    Friend WithEvents maskedTextBox9Custom As Krypton.Toolkit.KryptonMaskedTextBox
    Friend WithEvents buttonSpecAny2 As Krypton.Toolkit.ButtonSpecAny
    Friend WithEvents buttonSpecAny3 As Krypton.Toolkit.ButtonSpecAny
    Friend WithEvents buttonSpecAny1 As Krypton.Toolkit.ButtonSpecAny
    Friend WithEvents kryptonContextMenu As Krypton.Toolkit.KryptonContextMenu
    Friend WithEvents kryptonContextMenuItems1 As Krypton.Toolkit.KryptonContextMenuItems
    Friend WithEvents kryptonContextMenuItem1 As Krypton.Toolkit.KryptonContextMenuItem
    Friend WithEvents kryptonContextMenuItem2 As Krypton.Toolkit.KryptonContextMenuItem
    Friend WithEvents kryptonContextMenuSeparator1 As Krypton.Toolkit.KryptonContextMenuSeparator
    Friend WithEvents kryptonContextMenuItem3 As Krypton.Toolkit.KryptonContextMenuItem
    Friend WithEvents label3 As System.Windows.Forms.Label
    Friend WithEvents label2 As System.Windows.Forms.Label
    Friend WithEvents label1 As System.Windows.Forms.Label
    Friend WithEvents label6 As System.Windows.Forms.Label
    Friend WithEvents label5 As System.Windows.Forms.Label
    Friend WithEvents label4 As System.Windows.Forms.Label
End Class
