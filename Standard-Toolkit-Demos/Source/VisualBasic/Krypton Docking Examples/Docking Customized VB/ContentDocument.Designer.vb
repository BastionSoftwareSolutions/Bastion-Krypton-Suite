' VB.NET twin of Source\Krypton Docking Examples\Docking Customized\ContentDocument.Designer.cs (Bastion Phase 4c).
<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class ContentDocument
    Inherits System.Windows.Forms.UserControl

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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(ContentDocument))
        Me.richTextBox = New Krypton.Toolkit.KryptonRichTextBox()
        Me.kryptonPanel = New Krypton.Toolkit.KryptonPanel()
        CType(Me.kryptonPanel, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.kryptonPanel.SuspendLayout()
        Me.SuspendLayout()
        Me.richTextBox.Dock = System.Windows.Forms.DockStyle.Fill
        Me.richTextBox.Location = New System.Drawing.Point(5, 5)
        Me.richTextBox.Name = "richTextBox"
        Me.richTextBox.Size = New System.Drawing.Size(142, 101)
        Me.richTextBox.StateCommon.Border.Draw = Krypton.Toolkit.InheritBool.False
        Me.richTextBox.StateCommon.Border.DrawBorders = CType((((Krypton.Toolkit.PaletteDrawBorders.Top Or Krypton.Toolkit.PaletteDrawBorders.Bottom) Or Krypton.Toolkit.PaletteDrawBorders.Left) Or Krypton.Toolkit.PaletteDrawBorders.Right), Krypton.Toolkit.PaletteDrawBorders)
        Me.richTextBox.StateCommon.Border.ImageStyle = Krypton.Toolkit.PaletteImageStyle.Inherit
        Me.richTextBox.TabIndex = 0
        Me.richTextBox.Text = resources.GetString("richTextBox.Text")
        Me.kryptonPanel.Controls.Add(Me.richTextBox)
        Me.kryptonPanel.Dock = System.Windows.Forms.DockStyle.Fill
        Me.kryptonPanel.Location = New System.Drawing.Point(0, 0)
        Me.kryptonPanel.Name = "kryptonPanel"
        Me.kryptonPanel.Padding = New System.Windows.Forms.Padding(5)
        Me.kryptonPanel.PanelBackStyle = Krypton.Toolkit.PaletteBackStyle.ControlClient
        Me.kryptonPanel.Size = New System.Drawing.Size(152, 111)
        Me.kryptonPanel.TabIndex = 1
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6F, 13F)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.Controls.Add(Me.kryptonPanel)
        Me.Name = "ContentDocument"
        Me.Size = New System.Drawing.Size(152, 111)
        CType(Me.kryptonPanel, System.ComponentModel.ISupportInitialize).EndInit()
        Me.kryptonPanel.ResumeLayout(False)
        Me.ResumeLayout(False)
    End Sub

    Friend WithEvents richTextBox As Krypton.Toolkit.KryptonRichTextBox
    Friend WithEvents kryptonPanel As Krypton.Toolkit.KryptonPanel
End Class
