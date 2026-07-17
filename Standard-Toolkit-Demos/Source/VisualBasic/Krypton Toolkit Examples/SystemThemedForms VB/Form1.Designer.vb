' VB.NET twin of Source\Krypton Toolkit Examples\SystemThemedForms\Form1.Designer.cs (Bastion Phase 4c).
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
        Me.buttonSpecAny1 = New Krypton.Toolkit.ButtonSpecAny()
        Me.button1 = New System.Windows.Forms.Button()
        Me.button2 = New System.Windows.Forms.Button()
        Me.button3 = New System.Windows.Forms.Button()
        Me.button4 = New System.Windows.Forms.Button()
        Me.button5 = New System.Windows.Forms.Button()
        Me.button6 = New System.Windows.Forms.Button()
        Me.button7 = New System.Windows.Forms.Button()
        Me.button8 = New System.Windows.Forms.Button()
        Me.SuspendLayout()
        Me.buttonSpecAny1.ExtraText = "ExtraButton"
        Me.buttonSpecAny1.Text = "Button"
        Me.buttonSpecAny1.Type = Krypton.Toolkit.PaletteButtonSpecStyle.Next
        Me.buttonSpecAny1.UniqueName = "16A6E91058454CD77C97174C1594D930"
        Me.button1.Location = New System.Drawing.Point(4, 8)
        Me.button1.Name = "button1"
        Me.button1.Size = New System.Drawing.Size(292, 23)
        Me.button1.TabIndex = 0
        Me.button1.Text = "Switch to ""System- Professional"" Theme"
        Me.button1.UseVisualStyleBackColor = True
        Me.button2.Location = New System.Drawing.Point(302, 8)
        Me.button2.Name = "button2"
        Me.button2.Size = New System.Drawing.Size(292, 23)
        Me.button2.TabIndex = 1
        Me.button2.Text = "Switch to ""Office 2007 - Silver"" Theme"
        Me.button2.UseVisualStyleBackColor = True
        Me.button3.Location = New System.Drawing.Point(4, 37)
        Me.button3.Name = "button3"
        Me.button3.Size = New System.Drawing.Size(292, 23)
        Me.button3.TabIndex = 2
        Me.button3.Text = "Switch to ""Office2003- Professional"" Theme"
        Me.button3.UseVisualStyleBackColor = True
        Me.button4.Location = New System.Drawing.Point(12, 75)
        Me.button4.Name = "button4"
        Me.button4.Size = New System.Drawing.Size(284, 23)
        Me.button4.TabIndex = 4
        Me.button4.Text = "SystemColors.InactiveCaption"
        Me.button4.UseVisualStyleBackColor = True
        Me.button5.Location = New System.Drawing.Point(12, 104)
        Me.button5.Name = "button5"
        Me.button5.Size = New System.Drawing.Size(284, 23)
        Me.button5.TabIndex = 5
        Me.button5.Text = "SystemColors.ActiveCaption"
        Me.button5.UseVisualStyleBackColor = True
        Me.button6.Location = New System.Drawing.Point(12, 133)
        Me.button6.Name = "button6"
        Me.button6.Size = New System.Drawing.Size(284, 23)
        Me.button6.TabIndex = 6
        Me.button6.Text = "SystemColors.GradientActiveCaption"
        Me.button6.UseVisualStyleBackColor = True
        Me.button7.Location = New System.Drawing.Point(12, 162)
        Me.button7.Name = "button7"
        Me.button7.Size = New System.Drawing.Size(284, 23)
        Me.button7.TabIndex = 7
        Me.button7.Text = "SystemColors.GradientInactiveCaption"
        Me.button7.UseVisualStyleBackColor = True
        Me.button8.Location = New System.Drawing.Point(12, 191)
        Me.button8.Name = "button8"
        Me.button8.Size = New System.Drawing.Size(284, 23)
        Me.button8.TabIndex = 8
        Me.button8.Text = "SystemColors.WindowFrame"
        Me.button8.UseVisualStyleBackColor = True
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6F, 13F)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ButtonSpecs.AddRange(New Krypton.Toolkit.ButtonSpecAny() { Me.buttonSpecAny1})
        Me.ClientSize = New System.Drawing.Size(606, 260)
        Me.Controls.Add(Me.button8)
        Me.Controls.Add(Me.button7)
        Me.Controls.Add(Me.button6)
        Me.Controls.Add(Me.button5)
        Me.Controls.Add(Me.button4)
        Me.Controls.Add(Me.button3)
        Me.Controls.Add(Me.button2)
        Me.Controls.Add(Me.button1)
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.Name = "Form1"
        Me.PaletteMode = Krypton.Toolkit.PaletteMode.Office2007Silver
        Me.StartPosition = System.Windows.Forms.FormStartPosition.Manual
        Me.StateCommon.OverlayHeaders = Krypton.Toolkit.InheritBool.True
        Me.Text = "Test ""SystemThemed"" TitleBar Extras ->"
        Me.TextExtra = "ExtraText Here"
        Me.ResumeLayout(False)
    End Sub

    Friend WithEvents buttonSpecAny1 As Krypton.Toolkit.ButtonSpecAny
    Friend WithEvents button1 As System.Windows.Forms.Button
    Friend WithEvents button2 As System.Windows.Forms.Button
    Friend WithEvents button3 As System.Windows.Forms.Button
    Friend WithEvents button4 As System.Windows.Forms.Button
    Friend WithEvents button5 As System.Windows.Forms.Button
    Friend WithEvents button6 As System.Windows.Forms.Button
    Friend WithEvents button7 As System.Windows.Forms.Button
    Friend WithEvents button8 As System.Windows.Forms.Button
End Class
