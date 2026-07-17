' VB.NET twin of Source\Krypton Toolkit Examples\KryptonCommandLinkButton Examples\Form1.Designer.cs (Bastion Phase 4c).
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
        Me.kryptonPanel1 = New Krypton.Toolkit.KryptonPanel()
        Me.kbtOk = New Krypton.Toolkit.KryptonButton()
        Me.kryptonBorderEdge1 = New Krypton.Toolkit.KryptonBorderEdge()
        Me.kryptonPanel2 = New Krypton.Toolkit.KryptonPanel()
        Me.kryptonCommandLinkButton5 = New Krypton.Toolkit.KryptonCommandLinkButton()
        Me.kryptonCommandLinkButton4 = New Krypton.Toolkit.KryptonCommandLinkButton()
        Me.kryptonCommandLinkButton3 = New Krypton.Toolkit.KryptonCommandLinkButton()
        Me.kryptonCommandLinkButton2 = New Krypton.Toolkit.KryptonCommandLinkButton()
        Me.kryptonAlternateCommandLinkButton1 = New Krypton.Toolkit.KryptonAlternateCommandLinkButton()
        Me.kryptonCommandLinkButton1 = New Krypton.Toolkit.KryptonCommandLinkButton()
        Me.kpgButtons = New Krypton.Toolkit.KryptonPropertyGrid()
        CType(Me.kryptonPanel1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.kryptonPanel1.SuspendLayout()
        CType(Me.kryptonPanel2, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.kryptonPanel2.SuspendLayout()
        Me.SuspendLayout()
        Me.kryptonPanel1.Controls.Add(Me.kbtOk)
        Me.kryptonPanel1.Controls.Add(Me.kryptonBorderEdge1)
        Me.kryptonPanel1.Dock = System.Windows.Forms.DockStyle.Bottom
        Me.kryptonPanel1.Location = New System.Drawing.Point(0, 572)
        Me.kryptonPanel1.Margin = New System.Windows.Forms.Padding(4)
        Me.kryptonPanel1.Name = "kryptonPanel1"
        Me.kryptonPanel1.PanelBackStyle = Krypton.Toolkit.PaletteBackStyle.PanelAlternate
        Me.kryptonPanel1.Size = New System.Drawing.Size(1097, 62)
        Me.kryptonPanel1.TabIndex = 0
        Me.kbtOk.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.kbtOk.DialogResult = System.Windows.Forms.DialogResult.OK
        Me.kbtOk.Location = New System.Drawing.Point(961, 16)
        Me.kbtOk.Margin = New System.Windows.Forms.Padding(4)
        Me.kbtOk.Name = "kbtOk"
        Me.kbtOk.Size = New System.Drawing.Size(120, 31)
        Me.kbtOk.TabIndex = 1
        Me.kbtOk.Values.DropDownArrowColor = System.Drawing.Color.Empty
        Me.kbtOk.Values.Text = "Ok"
        Me.kryptonBorderEdge1.BorderStyle = Krypton.Toolkit.PaletteBorderStyle.HeaderPrimary
        Me.kryptonBorderEdge1.Dock = System.Windows.Forms.DockStyle.Top
        Me.kryptonBorderEdge1.Location = New System.Drawing.Point(0, 0)
        Me.kryptonBorderEdge1.Margin = New System.Windows.Forms.Padding(4)
        Me.kryptonBorderEdge1.Name = "kryptonBorderEdge1"
        Me.kryptonBorderEdge1.Size = New System.Drawing.Size(1097, 1)
        Me.kryptonBorderEdge1.Text = "kryptonBorderEdge1"
        Me.kryptonPanel2.Controls.Add(Me.kryptonCommandLinkButton5)
        Me.kryptonPanel2.Controls.Add(Me.kryptonCommandLinkButton4)
        Me.kryptonPanel2.Controls.Add(Me.kryptonCommandLinkButton3)
        Me.kryptonPanel2.Controls.Add(Me.kryptonCommandLinkButton2)
        Me.kryptonPanel2.Controls.Add(Me.kryptonAlternateCommandLinkButton1)
        Me.kryptonPanel2.Controls.Add(Me.kryptonCommandLinkButton1)
        Me.kryptonPanel2.Controls.Add(Me.kpgButtons)
        Me.kryptonPanel2.Dock = System.Windows.Forms.DockStyle.Fill
        Me.kryptonPanel2.Location = New System.Drawing.Point(0, 0)
        Me.kryptonPanel2.Margin = New System.Windows.Forms.Padding(4)
        Me.kryptonPanel2.Name = "kryptonPanel2"
        Me.kryptonPanel2.Size = New System.Drawing.Size(1097, 572)
        Me.kryptonPanel2.TabIndex = 1
        Me.kryptonCommandLinkButton5.ButtonStyle = Krypton.Toolkit.ButtonStyle.Standalone
        Me.kryptonCommandLinkButton5.CommandLinkTextValues.Description = "What happens when the text is really long, " & vbCrLf & "and wants to go off the edge?" & vbCrLf & "Then " + "Use a Multi-line ;-)" & vbCrLf
        Me.kryptonCommandLinkButton5.CommandLinkTextValues.Heading = "&Control the World"
        Me.kryptonCommandLinkButton5.Location = New System.Drawing.Point(17, 463)
        Me.kryptonCommandLinkButton5.Margin = New System.Windows.Forms.Padding(4)
        Me.kryptonCommandLinkButton5.Name = "kryptonCommandLinkButton5"
        Me.kryptonCommandLinkButton5.OverrideFocus.Border.Draw = Krypton.Toolkit.InheritBool.True
        Me.kryptonCommandLinkButton5.OverrideFocus.Border.DrawBorders = CType((((Krypton.Toolkit.PaletteDrawBorders.Top Or Krypton.Toolkit.PaletteDrawBorders.Bottom) Or Krypton.Toolkit.PaletteDrawBorders.Left) Or Krypton.Toolkit.PaletteDrawBorders.Right), Krypton.Toolkit.PaletteDrawBorders)
        Me.kryptonCommandLinkButton5.OverrideFocus.Border.GraphicsHint = Krypton.Toolkit.PaletteGraphicsHint.AntiAlias
        Me.kryptonCommandLinkButton5.Size = New System.Drawing.Size(453, 106)
        Me.kryptonCommandLinkButton5.StateCommon.Back.Color1 = System.Drawing.SystemColors.GradientActiveCaption
        Me.kryptonCommandLinkButton5.StateCommon.Back.Color2 = System.Drawing.SystemColors.ActiveCaption
        Me.kryptonCommandLinkButton5.StateCommon.Back.GraphicsHint = Krypton.Toolkit.PaletteGraphicsHint.AntiAlias
        Me.kryptonCommandLinkButton5.StateCommon.Border.Color1 = System.Drawing.Color.FromArgb(CType(CType(192, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.kryptonCommandLinkButton5.StateCommon.Border.Draw = Krypton.Toolkit.InheritBool.True
        Me.kryptonCommandLinkButton5.StateCommon.Border.DrawBorders = CType((((Krypton.Toolkit.PaletteDrawBorders.Top Or Krypton.Toolkit.PaletteDrawBorders.Bottom) Or Krypton.Toolkit.PaletteDrawBorders.Left) Or Krypton.Toolkit.PaletteDrawBorders.Right), Krypton.Toolkit.PaletteDrawBorders)
        Me.kryptonCommandLinkButton5.StateCommon.Border.GraphicsHint = Krypton.Toolkit.PaletteGraphicsHint.AntiAlias
        Me.kryptonCommandLinkButton5.StateCommon.Border.Rounding = 6F
        Me.kryptonCommandLinkButton5.StateCommon.Border.Width = 2
        Me.kryptonCommandLinkButton5.StateCommon.Content.LongText.MultiLine = Krypton.Toolkit.InheritBool.True
        Me.kryptonCommandLinkButton5.StateCommon.Content.LongText.MultiLineH = Krypton.Toolkit.PaletteRelativeAlign.Near
        Me.kryptonCommandLinkButton5.StateCommon.Content.LongText.TextH = Krypton.Toolkit.PaletteRelativeAlign.Near
        Me.kryptonCommandLinkButton5.StateCommon.Content.LongText.TextV = Krypton.Toolkit.PaletteRelativeAlign.Far
        Me.kryptonCommandLinkButton5.StateCommon.Content.LongText.Trim = Krypton.Toolkit.PaletteTextTrim.Word
        Me.kryptonCommandLinkButton5.StateCommon.Content.ShortText.TextH = Krypton.Toolkit.PaletteRelativeAlign.Near
        Me.kryptonCommandLinkButton5.StateCommon.Content.ShortText.TextV = Krypton.Toolkit.PaletteRelativeAlign.Center
        Me.kryptonCommandLinkButton5.TabIndex = 11
        Me.kryptonCommandLinkButton4.ButtonStyle = Krypton.Toolkit.ButtonStyle.NavigatorMini
        Me.kryptonCommandLinkButton4.CommandLinkTextValues.Image = CType(resources.GetObject("kryptonCommandLinkButton4.CommandLinkImageValues.Image"), System.Drawing.Image)
        Me.kryptonCommandLinkButton4.CommandLinkTextValues.Description = " Demo the Shortcut display and rounded borders"
        Me.kryptonCommandLinkButton4.CommandLinkTextValues.Heading = "&Disabled Navigator Mini style"
        Me.kryptonCommandLinkButton4.Enabled = False
        Me.kryptonCommandLinkButton4.Location = New System.Drawing.Point(17, 388)
        Me.kryptonCommandLinkButton4.Margin = New System.Windows.Forms.Padding(4)
        Me.kryptonCommandLinkButton4.Name = "kryptonCommandLinkButton4"
        Me.kryptonCommandLinkButton4.OverrideFocus.Border.Draw = Krypton.Toolkit.InheritBool.True
        Me.kryptonCommandLinkButton4.OverrideFocus.Border.DrawBorders = CType((((Krypton.Toolkit.PaletteDrawBorders.Top Or Krypton.Toolkit.PaletteDrawBorders.Bottom) Or Krypton.Toolkit.PaletteDrawBorders.Left) Or Krypton.Toolkit.PaletteDrawBorders.Right), Krypton.Toolkit.PaletteDrawBorders)
        Me.kryptonCommandLinkButton4.OverrideFocus.Border.GraphicsHint = Krypton.Toolkit.PaletteGraphicsHint.AntiAlias
        Me.kryptonCommandLinkButton4.Size = New System.Drawing.Size(453, 68)
        Me.kryptonCommandLinkButton4.StateCommon.Border.Draw = Krypton.Toolkit.InheritBool.True
        Me.kryptonCommandLinkButton4.StateCommon.Border.DrawBorders = CType((((Krypton.Toolkit.PaletteDrawBorders.Top Or Krypton.Toolkit.PaletteDrawBorders.Bottom) Or Krypton.Toolkit.PaletteDrawBorders.Left) Or Krypton.Toolkit.PaletteDrawBorders.Right), Krypton.Toolkit.PaletteDrawBorders)
        Me.kryptonCommandLinkButton4.StateCommon.Border.GraphicsHint = Krypton.Toolkit.PaletteGraphicsHint.AntiAlias
        Me.kryptonCommandLinkButton4.StateCommon.Border.Rounding = 4F
        Me.kryptonCommandLinkButton4.StateCommon.Border.Width = 2
        Me.kryptonCommandLinkButton4.StateCommon.Content.LongText.TextH = Krypton.Toolkit.PaletteRelativeAlign.Near
        Me.kryptonCommandLinkButton4.StateCommon.Content.LongText.TextV = Krypton.Toolkit.PaletteRelativeAlign.Far
        Me.kryptonCommandLinkButton4.StateCommon.Content.ShortText.TextH = Krypton.Toolkit.PaletteRelativeAlign.Near
        Me.kryptonCommandLinkButton4.StateCommon.Content.ShortText.TextV = Krypton.Toolkit.PaletteRelativeAlign.Center
        Me.kryptonCommandLinkButton4.TabIndex = 10
        Me.kryptonCommandLinkButton3.ButtonStyle = Krypton.Toolkit.ButtonStyle.NavigatorMini
        Me.kryptonCommandLinkButton3.CommandLinkTextValues.Description = " Demo the Shortcut display and rounded borders"
        Me.kryptonCommandLinkButton3.CommandLinkTextValues.Heading = "&Navigator Mini style"
        Me.kryptonCommandLinkButton3.Location = New System.Drawing.Point(16, 304)
        Me.kryptonCommandLinkButton3.Margin = New System.Windows.Forms.Padding(4)
        Me.kryptonCommandLinkButton3.Name = "kryptonCommandLinkButton3"
        Me.kryptonCommandLinkButton3.OverrideFocus.Border.Draw = Krypton.Toolkit.InheritBool.True
        Me.kryptonCommandLinkButton3.OverrideFocus.Border.DrawBorders = CType((((Krypton.Toolkit.PaletteDrawBorders.Top Or Krypton.Toolkit.PaletteDrawBorders.Bottom) Or Krypton.Toolkit.PaletteDrawBorders.Left) Or Krypton.Toolkit.PaletteDrawBorders.Right), Krypton.Toolkit.PaletteDrawBorders)
        Me.kryptonCommandLinkButton3.OverrideFocus.Border.GraphicsHint = Krypton.Toolkit.PaletteGraphicsHint.AntiAlias
        Me.kryptonCommandLinkButton3.Size = New System.Drawing.Size(455, 75)
        Me.kryptonCommandLinkButton3.StateCommon.Border.Draw = Krypton.Toolkit.InheritBool.True
        Me.kryptonCommandLinkButton3.StateCommon.Border.DrawBorders = CType((((Krypton.Toolkit.PaletteDrawBorders.Top Or Krypton.Toolkit.PaletteDrawBorders.Bottom) Or Krypton.Toolkit.PaletteDrawBorders.Left) Or Krypton.Toolkit.PaletteDrawBorders.Right), Krypton.Toolkit.PaletteDrawBorders)
        Me.kryptonCommandLinkButton3.StateCommon.Border.GraphicsHint = Krypton.Toolkit.PaletteGraphicsHint.AntiAlias
        Me.kryptonCommandLinkButton3.StateCommon.Border.Rounding = 4F
        Me.kryptonCommandLinkButton3.StateCommon.Border.Width = 2
        Me.kryptonCommandLinkButton3.StateCommon.Content.LongText.TextH = Krypton.Toolkit.PaletteRelativeAlign.Near
        Me.kryptonCommandLinkButton3.StateCommon.Content.LongText.TextV = Krypton.Toolkit.PaletteRelativeAlign.Far
        Me.kryptonCommandLinkButton3.StateCommon.Content.ShortText.TextH = Krypton.Toolkit.PaletteRelativeAlign.Near
        Me.kryptonCommandLinkButton3.StateCommon.Content.ShortText.TextV = Krypton.Toolkit.PaletteRelativeAlign.Center
        Me.kryptonCommandLinkButton3.TabIndex = 9
        Me.kryptonCommandLinkButton2.ButtonStyle = Krypton.Toolkit.ButtonStyle.Standalone
        Me.kryptonCommandLinkButton2.CommandLinkTextValues.Description = " Here be the extra Text with some spaces"
        Me.kryptonCommandLinkButton2.CommandLinkTextValues.Heading = "Standalone Style"
        Me.kryptonCommandLinkButton2.Location = New System.Drawing.Point(16, 222)
        Me.kryptonCommandLinkButton2.Margin = New System.Windows.Forms.Padding(4)
        Me.kryptonCommandLinkButton2.Name = "kryptonCommandLinkButton2"
        Me.kryptonCommandLinkButton2.OverrideFocus.Border.Draw = Krypton.Toolkit.InheritBool.True
        Me.kryptonCommandLinkButton2.OverrideFocus.Border.DrawBorders = CType((((Krypton.Toolkit.PaletteDrawBorders.Top Or Krypton.Toolkit.PaletteDrawBorders.Bottom) Or Krypton.Toolkit.PaletteDrawBorders.Left) Or Krypton.Toolkit.PaletteDrawBorders.Right), Krypton.Toolkit.PaletteDrawBorders)
        Me.kryptonCommandLinkButton2.OverrideFocus.Border.GraphicsHint = Krypton.Toolkit.PaletteGraphicsHint.AntiAlias
        Me.kryptonCommandLinkButton2.Size = New System.Drawing.Size(455, 75)
        Me.kryptonCommandLinkButton2.StateCommon.Content.LongText.TextH = Krypton.Toolkit.PaletteRelativeAlign.Near
        Me.kryptonCommandLinkButton2.StateCommon.Content.LongText.TextV = Krypton.Toolkit.PaletteRelativeAlign.Far
        Me.kryptonCommandLinkButton2.StateCommon.Content.ShortText.TextH = Krypton.Toolkit.PaletteRelativeAlign.Near
        Me.kryptonCommandLinkButton2.StateCommon.Content.ShortText.TextV = Krypton.Toolkit.PaletteRelativeAlign.Center
        Me.kryptonCommandLinkButton2.TabIndex = 8
        Me.kryptonAlternateCommandLinkButton1.Location = New System.Drawing.Point(16, 15)
        Me.kryptonAlternateCommandLinkButton1.Margin = New System.Windows.Forms.Padding(4)
        Me.kryptonAlternateCommandLinkButton1.Name = "kryptonAlternateCommandLinkButton1"
        Me.kryptonAlternateCommandLinkButton1.Size = New System.Drawing.Size(455, 85)
        Me.kryptonAlternateCommandLinkButton1.StateCommon.Content.Image.ImageH = Krypton.Toolkit.PaletteRelativeAlign.Near
        Me.kryptonAlternateCommandLinkButton1.StateCommon.Content.Image.ImageV = Krypton.Toolkit.PaletteRelativeAlign.Center
        Me.kryptonAlternateCommandLinkButton1.StateCommon.Content.LongText.TextH = Krypton.Toolkit.PaletteRelativeAlign.Near
        Me.kryptonAlternateCommandLinkButton1.StateCommon.Content.LongText.TextV = Krypton.Toolkit.PaletteRelativeAlign.Far
        Me.kryptonAlternateCommandLinkButton1.StateCommon.Content.ShortText.TextH = Krypton.Toolkit.PaletteRelativeAlign.Near
        Me.kryptonAlternateCommandLinkButton1.StateCommon.Content.ShortText.TextV = Krypton.Toolkit.PaletteRelativeAlign.Center
        Me.kryptonAlternateCommandLinkButton1.TabIndex = 7
        Me.kryptonAlternateCommandLinkButton1.Values.DropDownArrowColor = System.Drawing.Color.Empty
        Me.kryptonAlternateCommandLinkButton1.Values.ExtraText = "Text here is forced in to the lower part of the button"
        Me.kryptonAlternateCommandLinkButton1.Values.Image = CType(resources.GetObject("kryptonAlternateCommandLinkButton1.Values.Image"), System.Drawing.Image)
        Me.kryptonAlternateCommandLinkButton1.Values.Text = "Normal Krypton Button"
        Me.kryptonCommandLinkButton1.CommandLinkTextValues.Description = "Here be the ""Note Text"""
        Me.kryptonCommandLinkButton1.CommandLinkTextValues.Heading = "Default Ext Command Link"
        Me.kryptonCommandLinkButton1.Location = New System.Drawing.Point(16, 122)
        Me.kryptonCommandLinkButton1.Margin = New System.Windows.Forms.Padding(4)
        Me.kryptonCommandLinkButton1.Name = "kryptonCommandLinkButton1"
        Me.kryptonCommandLinkButton1.OverrideFocus.Border.Draw = Krypton.Toolkit.InheritBool.True
        Me.kryptonCommandLinkButton1.OverrideFocus.Border.DrawBorders = CType((((Krypton.Toolkit.PaletteDrawBorders.Top Or Krypton.Toolkit.PaletteDrawBorders.Bottom) Or Krypton.Toolkit.PaletteDrawBorders.Left) Or Krypton.Toolkit.PaletteDrawBorders.Right), Krypton.Toolkit.PaletteDrawBorders)
        Me.kryptonCommandLinkButton1.OverrideFocus.Border.GraphicsHint = Krypton.Toolkit.PaletteGraphicsHint.AntiAlias
        Me.kryptonCommandLinkButton1.Size = New System.Drawing.Size(455, 75)
        Me.kryptonCommandLinkButton1.StateCommon.Content.LongText.TextH = Krypton.Toolkit.PaletteRelativeAlign.Near
        Me.kryptonCommandLinkButton1.StateCommon.Content.LongText.TextV = Krypton.Toolkit.PaletteRelativeAlign.Far
        Me.kryptonCommandLinkButton1.StateCommon.Content.ShortText.TextH = Krypton.Toolkit.PaletteRelativeAlign.Near
        Me.kryptonCommandLinkButton1.StateCommon.Content.ShortText.TextV = Krypton.Toolkit.PaletteRelativeAlign.Center
        Me.kryptonCommandLinkButton1.TabIndex = 6
        Me.kpgButtons.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.kpgButtons.Location = New System.Drawing.Point(535, 15)
        Me.kpgButtons.Margin = New System.Windows.Forms.Padding(4)
        Me.kpgButtons.Name = "kpgButtons"
        Me.kpgButtons.Padding = New System.Windows.Forms.Padding(1)
        Me.kpgButtons.Size = New System.Drawing.Size(547, 544)
        Me.kpgButtons.TabIndex = 0
        Me.AutoScaleDimensions = New System.Drawing.SizeF(120F, 120F)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Dpi
        Me.ClientSize = New System.Drawing.Size(1097, 634)
        Me.Controls.Add(Me.kryptonPanel2)
        Me.Controls.Add(Me.kryptonPanel1)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.Fixed3D
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.Margin = New System.Windows.Forms.Padding(4)
        Me.MaximizeBox = False
        Me.MinimizeBox = False
        Me.Name = "Form1"
        Me.Text = "Krypton Command Link Buttons"
        CType(Me.kryptonPanel1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.kryptonPanel1.ResumeLayout(False)
        Me.kryptonPanel1.PerformLayout()
        CType(Me.kryptonPanel2, System.ComponentModel.ISupportInitialize).EndInit()
        Me.kryptonPanel2.ResumeLayout(False)
        Me.ResumeLayout(False)
    End Sub

    Friend WithEvents kryptonPanel1 As Krypton.Toolkit.KryptonPanel
    Friend WithEvents kryptonBorderEdge1 As Krypton.Toolkit.KryptonBorderEdge
    Friend WithEvents kryptonPanel2 As Krypton.Toolkit.KryptonPanel
    Friend WithEvents kpgButtons As Krypton.Toolkit.KryptonPropertyGrid
    Friend WithEvents kryptonCommandLinkButton5 As Krypton.Toolkit.KryptonCommandLinkButton
    Friend WithEvents kryptonCommandLinkButton4 As Krypton.Toolkit.KryptonCommandLinkButton
    Friend WithEvents kryptonCommandLinkButton3 As Krypton.Toolkit.KryptonCommandLinkButton
    Friend WithEvents kryptonCommandLinkButton2 As Krypton.Toolkit.KryptonCommandLinkButton
    Friend WithEvents kryptonAlternateCommandLinkButton1 As Krypton.Toolkit.KryptonAlternateCommandLinkButton
    Friend WithEvents kryptonCommandLinkButton1 As Krypton.Toolkit.KryptonCommandLinkButton
    Friend WithEvents kbtOk As Krypton.Toolkit.KryptonButton
End Class
