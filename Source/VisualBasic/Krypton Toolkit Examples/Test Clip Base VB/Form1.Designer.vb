' VB.NET twin of Source\Krypton Toolkit Examples\Test Clip Base\Form1.Designer.cs (Bastion Phase 4c).
<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class Form1
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(Form1))
        Me.kryptonLabel2 = New Krypton.Toolkit.KryptonLabel()
        Me.label1 = New System.Windows.Forms.Label()
        Me.kryptonLabel1 = New Krypton.Toolkit.KryptonLabel()
        Me.kryptonLabel3 = New Krypton.Toolkit.KryptonLabel()
        Me.kryptonButton1 = New Krypton.Toolkit.KryptonButton()
        Me.SuspendLayout()
        Me.kryptonLabel2.AutoSize = False
        Me.kryptonLabel2.LabelStyle = Krypton.Toolkit.LabelStyle.TitleControl
        Me.kryptonLabel2.Location = New System.Drawing.Point(62, 122)
        Me.kryptonLabel2.Name = "kryptonLabel2"
        Me.kryptonLabel2.Size = New System.Drawing.Size(129, 14)
        Me.kryptonLabel2.TabIndex = 8
        Me.kryptonLabel2.Values.Text = "Text (¯²·»¿_)"
        Me.label1.AutoSize = True
        Me.label1.Location = New System.Drawing.Point(36, 84)
        Me.label1.Name = "label1"
        Me.label1.Size = New System.Drawing.Size(196, 13)
        Me.label1.TabIndex = 9
        Me.label1.Text = "Krypton clipped label follows below this.."
        Me.kryptonLabel1.LabelStyle = Krypton.Toolkit.LabelStyle.TitlePanel
        Me.kryptonLabel1.Location = New System.Drawing.Point(39, 29)
        Me.kryptonLabel1.Name = "kryptonLabel1"
        Me.kryptonLabel1.Size = New System.Drawing.Size(204, 29)
        Me.kryptonLabel1.TabIndex = 10
        Me.kryptonLabel1.Values.Text = "Auto Size Text (¯²·»¿_)"
        Me.kryptonLabel3.AutoSize = False
        Me.kryptonLabel3.LabelStyle = Krypton.Toolkit.LabelStyle.TitleControl
        Me.kryptonLabel3.Location = New System.Drawing.Point(81, 157)
        Me.kryptonLabel3.Name = "kryptonLabel3"
        Me.kryptonLabel3.Size = New System.Drawing.Size(81, 34)
        Me.kryptonLabel3.StateCommon.Draw = Krypton.Toolkit.InheritBool.Inherit
        Me.kryptonLabel3.StateCommon.DrawFocus = Krypton.Toolkit.InheritBool.Inherit
        Me.kryptonLabel3.StateCommon.Padding = New System.Windows.Forms.Padding(-1)
        Me.kryptonLabel3.StateCommon.ShortText.ColorAlign = Krypton.Toolkit.PaletteRectangleAlign.Inherit
        Me.kryptonLabel3.StateCommon.ShortText.ColorStyle = Krypton.Toolkit.PaletteColorStyle.Inherit
        Me.kryptonLabel3.StateCommon.ShortText.Hint = Krypton.Toolkit.PaletteTextHint.Inherit
        Me.kryptonLabel3.StateCommon.ShortText.ImageAlign = Krypton.Toolkit.PaletteRectangleAlign.Inherit
        Me.kryptonLabel3.StateCommon.ShortText.ImageStyle = Krypton.Toolkit.PaletteImageStyle.Inherit
        Me.kryptonLabel3.StateCommon.ShortText.MultiLine = Krypton.Toolkit.InheritBool.Inherit
        Me.kryptonLabel3.StateCommon.ShortText.MultiLineH = Krypton.Toolkit.PaletteRelativeAlign.Inherit
        Me.kryptonLabel3.StateCommon.ShortText.Prefix = Krypton.Toolkit.PaletteTextHotkeyPrefix.Inherit
        Me.kryptonLabel3.StateCommon.ShortText.TextH = Krypton.Toolkit.PaletteRelativeAlign.Center
        Me.kryptonLabel3.StateCommon.ShortText.TextV = Krypton.Toolkit.PaletteRelativeAlign.Center
        Me.kryptonLabel3.StateCommon.ShortText.Trim = Krypton.Toolkit.PaletteTextTrim.Character
        Me.kryptonLabel3.TabIndex = 11
        Me.kryptonLabel3.Values.Text = "Text (¯²·»¿_)"
        Me.kryptonButton1.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowOnly
        Me.kryptonButton1.DialogResult = System.Windows.Forms.DialogResult.None
        Me.kryptonButton1.Location = New System.Drawing.Point(21, 210)
        Me.kryptonButton1.Margin = New System.Windows.Forms.Padding(2, 2, 2, 2)
        Me.kryptonButton1.Name = "kryptonButton1"
        Me.kryptonButton1.Orientation = Krypton.Toolkit.VisualOrientation.Top
        Me.kryptonButton1.Size = New System.Drawing.Size(68, 20)
        Me.kryptonButton1.TabIndex = 12
        Me.kryptonButton1.Values.Text = "kryptonButton1"
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6F, 13F)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(284, 261)
        Me.Controls.Add(Me.kryptonButton1)
        Me.Controls.Add(Me.kryptonLabel3)
        Me.Controls.Add(Me.kryptonLabel1)
        Me.Controls.Add(Me.label1)
        Me.Controls.Add(Me.kryptonLabel2)
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.Name = "Form1"
        Me.Text = "Form1"
        Me.ResumeLayout(False)
        Me.PerformLayout()
    End Sub

    Friend WithEvents kryptonLabel2 As Krypton.Toolkit.KryptonLabel
    Friend WithEvents label1 As System.Windows.Forms.Label
    Friend WithEvents kryptonLabel1 As Krypton.Toolkit.KryptonLabel
    Friend WithEvents kryptonLabel3 As Krypton.Toolkit.KryptonLabel
    Friend WithEvents kryptonButton1 As Krypton.Toolkit.KryptonButton
End Class
