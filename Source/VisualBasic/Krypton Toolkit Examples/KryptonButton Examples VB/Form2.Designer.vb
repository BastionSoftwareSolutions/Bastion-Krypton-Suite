' VB.NET twin of Source\Krypton Toolkit Examples\KryptonButton Examples\Form2.Designer.cs (Bastion Phase 4c).
<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class Form2
    Inherits System.Windows.Forms.Form

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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(Form2))
        Me.kryptonPanel1 = New Krypton.Toolkit.KryptonPanel()
        Me.kryptonButton1 = New Krypton.Toolkit.KryptonButton()
        CType(Me.kryptonPanel1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.kryptonPanel1.SuspendLayout()
        Me.SuspendLayout()
        Me.kryptonPanel1.Controls.Add(Me.kryptonButton1)
        Me.kryptonPanel1.Location = New System.Drawing.Point(130, 113)
        Me.kryptonPanel1.Margin = New System.Windows.Forms.Padding(2, 2, 2, 2)
        Me.kryptonPanel1.Name = "kryptonPanel1"
        Me.kryptonPanel1.PaletteMode = Krypton.Toolkit.PaletteMode.Office2007Black
        Me.kryptonPanel1.Size = New System.Drawing.Size(340, 140)
        Me.kryptonPanel1.TabIndex = 8
        Me.kryptonButton1.AutoSize = True
        Me.kryptonButton1.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowOnly
        Me.kryptonButton1.DialogResult = System.Windows.Forms.DialogResult.None
        Me.kryptonButton1.Location = New System.Drawing.Point(28, 2)
        Me.kryptonButton1.Margin = New System.Windows.Forms.Padding(2, 2, 2, 2)
        Me.kryptonButton1.Name = "kryptonButton1"
        Me.kryptonButton1.Orientation = Krypton.Toolkit.VisualOrientation.Top
        Me.kryptonButton1.PaletteMode = Krypton.Toolkit.PaletteMode.SparkleBlue
        Me.kryptonButton1.Size = New System.Drawing.Size(60, 58)
        Me.kryptonButton1.StateCommon.Border.ColorAlign = Krypton.Toolkit.PaletteRectangleAlign.Inherit
        Me.kryptonButton1.StateCommon.Border.ColorStyle = Krypton.Toolkit.PaletteColorStyle.Inherit
        Me.kryptonButton1.StateCommon.Border.Draw = Krypton.Toolkit.InheritBool.True
        Me.kryptonButton1.StateCommon.Border.DrawBorders = CType((((Krypton.Toolkit.PaletteDrawBorders.Top Or Krypton.Toolkit.PaletteDrawBorders.Bottom) Or Krypton.Toolkit.PaletteDrawBorders.Left) Or Krypton.Toolkit.PaletteDrawBorders.Right), Krypton.Toolkit.PaletteDrawBorders)
        Me.kryptonButton1.StateCommon.Border.GraphicsHint = Krypton.Toolkit.PaletteGraphicsHint.AntiAlias
        Me.kryptonButton1.StateCommon.Border.ImageAlign = Krypton.Toolkit.PaletteRectangleAlign.Inherit
        Me.kryptonButton1.StateCommon.Border.Rounding = 5F
        Me.kryptonButton1.StateCommon.Border.Width = 0
        Me.kryptonButton1.StateCommon.Content.Draw = Krypton.Toolkit.InheritBool.Inherit
        Me.kryptonButton1.StateCommon.Content.DrawFocus = Krypton.Toolkit.InheritBool.Inherit
        Me.kryptonButton1.StateCommon.Content.Image.Effect = Krypton.Toolkit.PaletteImageEffect.Inherit
        Me.kryptonButton1.StateCommon.Content.Image.ImageH = Krypton.Toolkit.PaletteRelativeAlign.Center
        Me.kryptonButton1.StateCommon.Content.Image.ImageV = Krypton.Toolkit.PaletteRelativeAlign.Center
        Me.kryptonButton1.StateCommon.Content.LongText.ColorAlign = Krypton.Toolkit.PaletteRectangleAlign.Inherit
        Me.kryptonButton1.StateCommon.Content.LongText.ColorStyle = Krypton.Toolkit.PaletteColorStyle.Inherit
        Me.kryptonButton1.StateCommon.Content.LongText.Hint = Krypton.Toolkit.PaletteTextHint.Inherit
        Me.kryptonButton1.StateCommon.Content.LongText.ImageAlign = Krypton.Toolkit.PaletteRectangleAlign.Inherit
        Me.kryptonButton1.StateCommon.Content.LongText.ImageStyle = Krypton.Toolkit.PaletteImageStyle.Inherit
        Me.kryptonButton1.StateCommon.Content.LongText.MultiLine = Krypton.Toolkit.InheritBool.Inherit
        Me.kryptonButton1.StateCommon.Content.LongText.MultiLineH = Krypton.Toolkit.PaletteRelativeAlign.Inherit
        Me.kryptonButton1.StateCommon.Content.LongText.Prefix = Krypton.Toolkit.PaletteTextHotkeyPrefix.Inherit
        Me.kryptonButton1.StateCommon.Content.LongText.TextH = Krypton.Toolkit.PaletteRelativeAlign.Center
        Me.kryptonButton1.StateCommon.Content.LongText.TextV = Krypton.Toolkit.PaletteRelativeAlign.Far
        Me.kryptonButton1.StateCommon.Content.LongText.Trim = Krypton.Toolkit.PaletteTextTrim.Inherit
        Me.kryptonButton1.StateCommon.Content.Padding = New System.Windows.Forms.Padding(-1)
        Me.kryptonButton1.StateCommon.Content.ShortText.ColorAlign = Krypton.Toolkit.PaletteRectangleAlign.Inherit
        Me.kryptonButton1.StateCommon.Content.ShortText.ColorStyle = Krypton.Toolkit.PaletteColorStyle.Inherit
        Me.kryptonButton1.StateCommon.Content.ShortText.Hint = Krypton.Toolkit.PaletteTextHint.Inherit
        Me.kryptonButton1.StateCommon.Content.ShortText.ImageAlign = Krypton.Toolkit.PaletteRectangleAlign.Inherit
        Me.kryptonButton1.StateCommon.Content.ShortText.ImageStyle = Krypton.Toolkit.PaletteImageStyle.Inherit
        Me.kryptonButton1.StateCommon.Content.ShortText.MultiLine = Krypton.Toolkit.InheritBool.Inherit
        Me.kryptonButton1.StateCommon.Content.ShortText.MultiLineH = Krypton.Toolkit.PaletteRelativeAlign.Inherit
        Me.kryptonButton1.StateCommon.Content.ShortText.Prefix = Krypton.Toolkit.PaletteTextHotkeyPrefix.Inherit
        Me.kryptonButton1.StateCommon.Content.ShortText.TextH = Krypton.Toolkit.PaletteRelativeAlign.Center
        Me.kryptonButton1.StateCommon.Content.ShortText.TextV = Krypton.Toolkit.PaletteRelativeAlign.Near
        Me.kryptonButton1.StateCommon.Content.ShortText.Trim = Krypton.Toolkit.PaletteTextTrim.Inherit
        Me.kryptonButton1.TabIndex = 6
        Me.kryptonButton1.Values.ExtraText = "ExtraText"
        Me.kryptonButton1.Values.Image = CType(resources.GetObject("kryptonButton1.Values.Image"), System.Drawing.Image)
        Me.kryptonButton1.Values.Text = "Text"
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6F, 13F)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(600, 366)
        Me.Controls.Add(Me.kryptonPanel1)
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.Margin = New System.Windows.Forms.Padding(2, 2, 2, 2)
        Me.Name = "Form2"
        Me.Text = "Form2"
        CType(Me.kryptonPanel1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.kryptonPanel1.ResumeLayout(False)
        Me.kryptonPanel1.PerformLayout()
        Me.ResumeLayout(False)
    End Sub

    Friend WithEvents kryptonPanel1 As Krypton.Toolkit.KryptonPanel
    Friend WithEvents kryptonButton1 As Krypton.Toolkit.KryptonButton
End Class
