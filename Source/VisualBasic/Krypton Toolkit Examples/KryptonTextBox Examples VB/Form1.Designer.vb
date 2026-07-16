' VB.NET twin of Source\Krypton Toolkit Examples\KryptonTextBox Examples\Form1.Designer.cs (Bastion Phase 4c).
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
        Me.buttonClose = New System.Windows.Forms.Button()
        Me.groupBox4 = New System.Windows.Forms.GroupBox()
        Me.propertyGrid = New System.Windows.Forms.PropertyGrid()
        Me.groupBox3 = New System.Windows.Forms.GroupBox()
        Me.kryptonTextBox9Custom = New Krypton.Toolkit.KryptonTextBox()
        Me.buttonSpecAny2 = New Krypton.Toolkit.ButtonSpecAny()
        Me.kryptonContextMenu = New Krypton.Toolkit.KryptonContextMenu()
        Me.kryptonContextMenuItems1 = New Krypton.Toolkit.KryptonContextMenuItems()
        Me.kryptonContextMenuItem1 = New Krypton.Toolkit.KryptonContextMenuItem()
        Me.kryptonContextMenuItem2 = New Krypton.Toolkit.KryptonContextMenuItem()
        Me.kryptonContextMenuSeparator1 = New Krypton.Toolkit.KryptonContextMenuSeparator()
        Me.kryptonContextMenuItem3 = New Krypton.Toolkit.KryptonContextMenuItem()
        Me.kryptonTextBox8Custom = New Krypton.Toolkit.KryptonTextBox()
        Me.kryptonTextBox7Custom = New Krypton.Toolkit.KryptonTextBox()
        Me.groupBox1 = New System.Windows.Forms.GroupBox()
        Me.kryptonTextBox6System = New Krypton.Toolkit.KryptonTextBox()
        Me.kryptonTextBox5System = New Krypton.Toolkit.KryptonTextBox()
        Me.buttonSpecAny3 = New Krypton.Toolkit.ButtonSpecAny()
        Me.kryptonTextBox4System = New Krypton.Toolkit.KryptonTextBox()
        Me.groupBox2 = New System.Windows.Forms.GroupBox()
        Me.kryptonTextBox3Blue = New Krypton.Toolkit.KryptonTextBox()
        Me.kryptonTextBox2Blue = New Krypton.Toolkit.KryptonTextBox()
        Me.buttonSpecAny1 = New Krypton.Toolkit.ButtonSpecAny()
        Me.kryptonTextBox1Blue = New Krypton.Toolkit.KryptonTextBox()
        Me.groupBox5 = New System.Windows.Forms.GroupBox()
        Me.kryptonTextBox3 = New Krypton.Toolkit.KryptonTextBox()
        Me.kryptonTextBox4 = New Krypton.Toolkit.KryptonTextBox()
        Me.kryptonTextBox2 = New Krypton.Toolkit.KryptonTextBox()
        Me.kryptonTextBox1 = New Krypton.Toolkit.KryptonTextBox()
        Me.groupBox4.SuspendLayout()
        Me.groupBox3.SuspendLayout()
        Me.groupBox1.SuspendLayout()
        Me.groupBox2.SuspendLayout()
        Me.groupBox5.SuspendLayout()
        Me.SuspendLayout()
        Me.buttonClose.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.buttonClose.DialogResult = System.Windows.Forms.DialogResult.Cancel
        Me.buttonClose.Location = New System.Drawing.Point(707, 550)
        Me.buttonClose.Name = "buttonClose"
        Me.buttonClose.Size = New System.Drawing.Size(75, 23)
        Me.buttonClose.TabIndex = 4
        Me.buttonClose.Text = "&Close"
        Me.buttonClose.UseVisualStyleBackColor = True
        Me.groupBox4.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.groupBox4.Controls.Add(Me.propertyGrid)
        Me.groupBox4.Location = New System.Drawing.Point(460, 12)
        Me.groupBox4.Name = "groupBox4"
        Me.groupBox4.Size = New System.Drawing.Size(322, 532)
        Me.groupBox4.TabIndex = 3
        Me.groupBox4.TabStop = False
        Me.groupBox4.Text = "Properties for Selected KryptonTextBox"
        Me.propertyGrid.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) Or System.Windows.Forms.AnchorStyles.Left) Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.propertyGrid.Location = New System.Drawing.Point(6, 19)
        Me.propertyGrid.Name = "propertyGrid"
        Me.propertyGrid.Size = New System.Drawing.Size(310, 507)
        Me.propertyGrid.TabIndex = 0
        Me.propertyGrid.ToolbarVisible = False
        Me.groupBox3.Controls.Add(Me.kryptonTextBox9Custom)
        Me.groupBox3.Controls.Add(Me.kryptonTextBox8Custom)
        Me.groupBox3.Controls.Add(Me.kryptonTextBox7Custom)
        Me.groupBox3.Location = New System.Drawing.Point(12, 386)
        Me.groupBox3.Name = "groupBox3"
        Me.groupBox3.Size = New System.Drawing.Size(195, 158)
        Me.groupBox3.TabIndex = 2
        Me.groupBox3.TabStop = False
        Me.groupBox3.Text = "Custom Settings"
        Me.kryptonTextBox9Custom.ButtonSpecs.Add(Me.buttonSpecAny2)
        Me.kryptonTextBox9Custom.Location = New System.Drawing.Point(16, 115)
        Me.kryptonTextBox9Custom.Name = "kryptonTextBox9Custom"
        Me.kryptonTextBox9Custom.PaletteMode = Krypton.Toolkit.PaletteMode.Office2007Silver
        Me.kryptonTextBox9Custom.Size = New System.Drawing.Size(161, 29)
        Me.kryptonTextBox9Custom.StateCommon.Border.Color1 = System.Drawing.Color.Silver
        Me.kryptonTextBox9Custom.StateCommon.Border.Color2 = System.Drawing.Color.Gray
        Me.kryptonTextBox9Custom.StateCommon.Border.ColorAngle = 80F
        Me.kryptonTextBox9Custom.StateCommon.Border.ColorStyle = Krypton.Toolkit.PaletteColorStyle.Rounded
        Me.kryptonTextBox9Custom.StateCommon.Border.DrawBorders = CType((((Krypton.Toolkit.PaletteDrawBorders.Top Or Krypton.Toolkit.PaletteDrawBorders.Bottom) Or Krypton.Toolkit.PaletteDrawBorders.Left) Or Krypton.Toolkit.PaletteDrawBorders.Right), Krypton.Toolkit.PaletteDrawBorders)
        Me.kryptonTextBox9Custom.StateCommon.Border.GraphicsHint = Krypton.Toolkit.PaletteGraphicsHint.AntiAlias
        Me.kryptonTextBox9Custom.StateCommon.Border.Rounding = 3F
        Me.kryptonTextBox9Custom.StateCommon.Border.Width = 1
        Me.kryptonTextBox9Custom.TabIndex = 2
        Me.kryptonTextBox9Custom.Text = "Use Button"
        Me.buttonSpecAny2.KryptonContextMenu = Me.kryptonContextMenu
        Me.buttonSpecAny2.Style = Krypton.Toolkit.PaletteButtonStyle.Standalone
        Me.buttonSpecAny2.Type = Krypton.Toolkit.PaletteButtonSpecStyle.Context
        Me.buttonSpecAny2.UniqueName = "AFADF6E71C27433DAFADF6E71C27433D"
        Me.kryptonContextMenu.Items.AddRange(New Krypton.Toolkit.KryptonContextMenuItemBase() { Me.kryptonContextMenuItems1})
        Me.kryptonContextMenuItems1.Items.AddRange(New Krypton.Toolkit.KryptonContextMenuItemBase() { Me.kryptonContextMenuItem1, Me.kryptonContextMenuItem2, Me.kryptonContextMenuSeparator1, Me.kryptonContextMenuItem3})
        Me.kryptonContextMenuItem1.Text = "Fixed Text 1"
        Me.kryptonContextMenuItem2.Text = "Fixed Text 2"
        Me.kryptonContextMenuItem3.Text = "Clear"
        Me.kryptonTextBox8Custom.Location = New System.Drawing.Point(16, 72)
        Me.kryptonTextBox8Custom.Name = "kryptonTextBox8Custom"
        Me.kryptonTextBox8Custom.PaletteMode = Krypton.Toolkit.PaletteMode.ProfessionalOffice2003
        Me.kryptonTextBox8Custom.PasswordChar = "●"c
        Me.kryptonTextBox8Custom.Size = New System.Drawing.Size(161, 33)
        Me.kryptonTextBox8Custom.StateCommon.Border.DrawBorders = CType((((Krypton.Toolkit.PaletteDrawBorders.Top Or Krypton.Toolkit.PaletteDrawBorders.Bottom) Or Krypton.Toolkit.PaletteDrawBorders.Left) Or Krypton.Toolkit.PaletteDrawBorders.Right), Krypton.Toolkit.PaletteDrawBorders)
        Me.kryptonTextBox8Custom.StateCommon.Border.GraphicsHint = Krypton.Toolkit.PaletteGraphicsHint.AntiAlias
        Me.kryptonTextBox8Custom.StateCommon.Border.Rounding = 4F
        Me.kryptonTextBox8Custom.StateCommon.Border.Width = 2
        Me.kryptonTextBox8Custom.TabIndex = 1
        Me.kryptonTextBox8Custom.Text = "Password"
        Me.kryptonTextBox8Custom.UseSystemPasswordChar = True
        Me.kryptonTextBox7Custom.AlwaysActive = False
        Me.kryptonTextBox7Custom.Location = New System.Drawing.Point(16, 29)
        Me.kryptonTextBox7Custom.Name = "kryptonTextBox7Custom"
        Me.kryptonTextBox7Custom.PaletteMode = Krypton.Toolkit.PaletteMode.ProfessionalOffice2003
        Me.kryptonTextBox7Custom.Size = New System.Drawing.Size(161, 33)
        Me.kryptonTextBox7Custom.StateActive.Border.Color1 = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(128, Byte), Integer), CType(CType(0, Byte), Integer))
        Me.kryptonTextBox7Custom.StateActive.Border.DrawBorders = CType((((Krypton.Toolkit.PaletteDrawBorders.Top Or Krypton.Toolkit.PaletteDrawBorders.Bottom) Or Krypton.Toolkit.PaletteDrawBorders.Left) Or Krypton.Toolkit.PaletteDrawBorders.Right), Krypton.Toolkit.PaletteDrawBorders)
        Me.kryptonTextBox7Custom.StateCommon.Border.DrawBorders = CType((((Krypton.Toolkit.PaletteDrawBorders.Top Or Krypton.Toolkit.PaletteDrawBorders.Bottom) Or Krypton.Toolkit.PaletteDrawBorders.Left) Or Krypton.Toolkit.PaletteDrawBorders.Right), Krypton.Toolkit.PaletteDrawBorders)
        Me.kryptonTextBox7Custom.StateCommon.Border.GraphicsHint = Krypton.Toolkit.PaletteGraphicsHint.AntiAlias
        Me.kryptonTextBox7Custom.StateCommon.Border.Rounding = 4F
        Me.kryptonTextBox7Custom.StateCommon.Border.Width = 2
        Me.kryptonTextBox7Custom.TabIndex = 0
        Me.kryptonTextBox7Custom.Text = "Orange when Active"
        Me.groupBox1.Controls.Add(Me.kryptonTextBox6System)
        Me.groupBox1.Controls.Add(Me.kryptonTextBox5System)
        Me.groupBox1.Controls.Add(Me.kryptonTextBox4System)
        Me.groupBox1.Location = New System.Drawing.Point(12, 199)
        Me.groupBox1.Name = "groupBox1"
        Me.groupBox1.Size = New System.Drawing.Size(195, 181)
        Me.groupBox1.TabIndex = 1
        Me.groupBox1.TabStop = False
        Me.groupBox1.Text = "Professional - System"
        Me.kryptonTextBox6System.AlwaysActive = False
        Me.kryptonTextBox6System.InputControlStyle = Krypton.Toolkit.InputControlStyle.Ribbon
        Me.kryptonTextBox6System.Location = New System.Drawing.Point(16, 82)
        Me.kryptonTextBox6System.Multiline = True
        Me.kryptonTextBox6System.Name = "kryptonTextBox6System"
        Me.kryptonTextBox6System.PaletteMode = Krypton.Toolkit.PaletteMode.ProfessionalSystem
        Me.kryptonTextBox6System.Size = New System.Drawing.Size(161, 81)
        Me.kryptonTextBox6System.TabIndex = 2
        Me.kryptonTextBox6System.Text = "Ribbon style for use inside the Ribbon control. Also has Multiline setting set to" + " True."
        Me.kryptonTextBox5System.AllowButtonSpecToolTips = True
        Me.kryptonTextBox5System.ButtonSpecs.Add(Me.buttonSpecAny3)
        Me.kryptonTextBox5System.Location = New System.Drawing.Point(16, 55)
        Me.kryptonTextBox5System.Name = "kryptonTextBox5System"
        Me.kryptonTextBox5System.PaletteMode = Krypton.Toolkit.PaletteMode.ProfessionalSystem
        Me.kryptonTextBox5System.Size = New System.Drawing.Size(161, 27)
        Me.kryptonTextBox5System.TabIndex = 1
        Me.kryptonTextBox5System.Text = "Use Button To Clear"
        Me.buttonSpecAny3.Type = Krypton.Toolkit.PaletteButtonSpecStyle.Close
        Me.buttonSpecAny3.UniqueName = "0D0CBE484603438F0D0CBE484603438F"
        Me.kryptonTextBox4System.Location = New System.Drawing.Point(16, 29)
        Me.kryptonTextBox4System.Name = "kryptonTextBox4System"
        Me.kryptonTextBox4System.PaletteMode = Krypton.Toolkit.PaletteMode.ProfessionalSystem
        Me.kryptonTextBox4System.Size = New System.Drawing.Size(161, 27)
        Me.kryptonTextBox4System.TabIndex = 0
        Me.kryptonTextBox4System.Text = "KryptonTextBox"
        Me.groupBox2.Controls.Add(Me.kryptonTextBox3Blue)
        Me.groupBox2.Controls.Add(Me.kryptonTextBox2Blue)
        Me.groupBox2.Controls.Add(Me.kryptonTextBox1Blue)
        Me.groupBox2.Location = New System.Drawing.Point(12, 12)
        Me.groupBox2.Name = "groupBox2"
        Me.groupBox2.Size = New System.Drawing.Size(195, 181)
        Me.groupBox2.TabIndex = 0
        Me.groupBox2.TabStop = False
        Me.groupBox2.Text = "Office 2007 - Blue"
        Me.kryptonTextBox3Blue.AlwaysActive = False
        Me.kryptonTextBox3Blue.InputControlStyle = Krypton.Toolkit.InputControlStyle.Ribbon
        Me.kryptonTextBox3Blue.Location = New System.Drawing.Point(16, 87)
        Me.kryptonTextBox3Blue.Multiline = True
        Me.kryptonTextBox3Blue.Name = "kryptonTextBox3Blue"
        Me.kryptonTextBox3Blue.PaletteMode = Krypton.Toolkit.PaletteMode.Office2007Blue
        Me.kryptonTextBox3Blue.Size = New System.Drawing.Size(161, 84)
        Me.kryptonTextBox3Blue.TabIndex = 2
        Me.kryptonTextBox3Blue.Text = "Ribbon style for use inside the Ribbon control. Also has Multiline setting set to" + " True."
        Me.kryptonTextBox2Blue.AllowButtonSpecToolTips = True
        Me.kryptonTextBox2Blue.ButtonSpecs.Add(Me.buttonSpecAny1)
        Me.kryptonTextBox2Blue.Location = New System.Drawing.Point(16, 56)
        Me.kryptonTextBox2Blue.Name = "kryptonTextBox2Blue"
        Me.kryptonTextBox2Blue.PaletteMode = Krypton.Toolkit.PaletteMode.Office2007Blue
        Me.kryptonTextBox2Blue.Size = New System.Drawing.Size(161, 27)
        Me.kryptonTextBox2Blue.TabIndex = 1
        Me.kryptonTextBox2Blue.Text = "Use Button To Clear"
        Me.buttonSpecAny1.Type = Krypton.Toolkit.PaletteButtonSpecStyle.Close
        Me.buttonSpecAny1.UniqueName = "2600D6A1691343B72600D6A1691343B7"
        Me.kryptonTextBox1Blue.CueHint.Color1 = System.Drawing.Color.Gray
        Me.kryptonTextBox1Blue.CueHint.CueHintText = "Cue Hint Text"
        Me.kryptonTextBox1Blue.CueHint.Font = New System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.kryptonTextBox1Blue.CueHint.Padding = New System.Windows.Forms.Padding(0)
        Me.kryptonTextBox1Blue.CueHint.TextH = Krypton.Toolkit.PaletteRelativeAlign.Center
        Me.kryptonTextBox1Blue.Location = New System.Drawing.Point(16, 30)
        Me.kryptonTextBox1Blue.Name = "kryptonTextBox1Blue"
        Me.kryptonTextBox1Blue.PaletteMode = Krypton.Toolkit.PaletteMode.Office2007Blue
        Me.kryptonTextBox1Blue.Size = New System.Drawing.Size(161, 22)
        Me.kryptonTextBox1Blue.StateCommon.Content.Padding = New System.Windows.Forms.Padding(10, 0, 0, 0)
        Me.kryptonTextBox1Blue.TabIndex = 0
        Me.groupBox5.Controls.Add(Me.kryptonTextBox3)
        Me.groupBox5.Controls.Add(Me.kryptonTextBox4)
        Me.groupBox5.Controls.Add(Me.kryptonTextBox2)
        Me.groupBox5.Controls.Add(Me.kryptonTextBox1)
        Me.groupBox5.Location = New System.Drawing.Point(222, 12)
        Me.groupBox5.Name = "groupBox5"
        Me.groupBox5.Size = New System.Drawing.Size(223, 281)
        Me.groupBox5.TabIndex = 5
        Me.groupBox5.TabStop = False
        Me.groupBox5.Text = "Input Control Styles"
        Me.kryptonTextBox3.Enabled = False
        Me.kryptonTextBox3.InputControlStyle = Krypton.Toolkit.InputControlStyle.PanelAlternate
        Me.kryptonTextBox3.Location = New System.Drawing.Point(10, 216)
        Me.kryptonTextBox3.Multiline = True
        Me.kryptonTextBox3.Name = "kryptonTextBox3"
        Me.kryptonTextBox3.Size = New System.Drawing.Size(199, 55)
        Me.kryptonTextBox3.TabIndex = 3
        Me.kryptonTextBox3.Text = "A KryptonTextBox using the 'PanelAlternate' input control style, in a disabled st" + "ate"
        Me.kryptonTextBox4.InputControlStyle = Krypton.Toolkit.InputControlStyle.PanelAlternate
        Me.kryptonTextBox4.Location = New System.Drawing.Point(10, 148)
        Me.kryptonTextBox4.Multiline = True
        Me.kryptonTextBox4.Name = "kryptonTextBox4"
        Me.kryptonTextBox4.Size = New System.Drawing.Size(199, 55)
        Me.kryptonTextBox4.TabIndex = 2
        Me.kryptonTextBox4.Text = "A KryptonTextBox using the 'PanelAlternate' input control style"
        Me.kryptonTextBox2.Enabled = False
        Me.kryptonTextBox2.InputControlStyle = Krypton.Toolkit.InputControlStyle.PanelClient
        Me.kryptonTextBox2.Location = New System.Drawing.Point(10, 87)
        Me.kryptonTextBox2.Multiline = True
        Me.kryptonTextBox2.Name = "kryptonTextBox2"
        Me.kryptonTextBox2.Size = New System.Drawing.Size(199, 55)
        Me.kryptonTextBox2.TabIndex = 1
        Me.kryptonTextBox2.Text = "A KryptonTextBox using the 'Panel Client' input control style, in a disabled stat" + "e."
        Me.kryptonTextBox1.InputControlStyle = Krypton.Toolkit.InputControlStyle.PanelClient
        Me.kryptonTextBox1.Location = New System.Drawing.Point(10, 27)
        Me.kryptonTextBox1.Multiline = True
        Me.kryptonTextBox1.Name = "kryptonTextBox1"
        Me.kryptonTextBox1.Size = New System.Drawing.Size(199, 52)
        Me.kryptonTextBox1.TabIndex = 0
        Me.kryptonTextBox1.Text = "A KryptonTextBox using the 'Panel Client' input control style."
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8F, 17F)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(792, 580)
        Me.Controls.Add(Me.groupBox5)
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
        Me.Text = "Krypton TextBox Examples"
        Me.groupBox4.ResumeLayout(False)
        Me.groupBox3.ResumeLayout(False)
        Me.groupBox3.PerformLayout()
        Me.groupBox1.ResumeLayout(False)
        Me.groupBox1.PerformLayout()
        Me.groupBox2.ResumeLayout(False)
        Me.groupBox2.PerformLayout()
        Me.groupBox5.ResumeLayout(False)
        Me.groupBox5.PerformLayout()
        Me.ResumeLayout(False)
    End Sub

    Friend WithEvents buttonClose As System.Windows.Forms.Button
    Friend WithEvents groupBox4 As System.Windows.Forms.GroupBox
    Friend WithEvents groupBox3 As System.Windows.Forms.GroupBox
    Friend WithEvents groupBox1 As System.Windows.Forms.GroupBox
    Friend WithEvents groupBox2 As System.Windows.Forms.GroupBox
    Friend WithEvents propertyGrid As System.Windows.Forms.PropertyGrid
    Friend WithEvents kryptonTextBox3Blue As Krypton.Toolkit.KryptonTextBox
    Friend WithEvents kryptonTextBox2Blue As Krypton.Toolkit.KryptonTextBox
    Friend WithEvents kryptonTextBox1Blue As Krypton.Toolkit.KryptonTextBox
    Friend WithEvents kryptonTextBox6System As Krypton.Toolkit.KryptonTextBox
    Friend WithEvents kryptonTextBox5System As Krypton.Toolkit.KryptonTextBox
    Friend WithEvents kryptonTextBox4System As Krypton.Toolkit.KryptonTextBox
    Friend WithEvents kryptonTextBox8Custom As Krypton.Toolkit.KryptonTextBox
    Friend WithEvents kryptonTextBox7Custom As Krypton.Toolkit.KryptonTextBox
    Friend WithEvents kryptonTextBox9Custom As Krypton.Toolkit.KryptonTextBox
    Friend WithEvents buttonSpecAny2 As Krypton.Toolkit.ButtonSpecAny
    Friend WithEvents buttonSpecAny3 As Krypton.Toolkit.ButtonSpecAny
    Friend WithEvents buttonSpecAny1 As Krypton.Toolkit.ButtonSpecAny
    Friend WithEvents kryptonContextMenu As Krypton.Toolkit.KryptonContextMenu
    Friend WithEvents kryptonContextMenuItems1 As Krypton.Toolkit.KryptonContextMenuItems
    Friend WithEvents kryptonContextMenuItem1 As Krypton.Toolkit.KryptonContextMenuItem
    Friend WithEvents kryptonContextMenuItem2 As Krypton.Toolkit.KryptonContextMenuItem
    Friend WithEvents kryptonContextMenuSeparator1 As Krypton.Toolkit.KryptonContextMenuSeparator
    Friend WithEvents kryptonContextMenuItem3 As Krypton.Toolkit.KryptonContextMenuItem
    Friend WithEvents groupBox5 As System.Windows.Forms.GroupBox
    Friend WithEvents kryptonTextBox3 As Krypton.Toolkit.KryptonTextBox
    Friend WithEvents kryptonTextBox4 As Krypton.Toolkit.KryptonTextBox
    Friend WithEvents kryptonTextBox2 As Krypton.Toolkit.KryptonTextBox
    Friend WithEvents kryptonTextBox1 As Krypton.Toolkit.KryptonTextBox
End Class
