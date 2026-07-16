' VB.NET twin of Source\Krypton Toolkit Examples\KryptonComboBox Examples\Form1.Designer.cs (Bastion Phase 4c).
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
        Me.groupBox2 = New System.Windows.Forms.GroupBox()
        Me.kryptonComboBox3Blue = New Krypton.Toolkit.KryptonComboBox()
        Me.kryptonComboBox2Blue = New Krypton.Toolkit.KryptonComboBox()
        Me.buttonSpecAny1 = New Krypton.Toolkit.ButtonSpecAny()
        Me.kryptonComboBox1Blue = New Krypton.Toolkit.KryptonComboBox()
        Me.groupBox1 = New System.Windows.Forms.GroupBox()
        Me.kryptonComboBox6System = New Krypton.Toolkit.KryptonComboBox()
        Me.kryptonComboBox5System = New Krypton.Toolkit.KryptonComboBox()
        Me.buttonSpecAny2 = New Krypton.Toolkit.ButtonSpecAny()
        Me.kryptonComboBox4System = New Krypton.Toolkit.KryptonComboBox()
        Me.groupBox3 = New System.Windows.Forms.GroupBox()
        Me.kryptonComboBox8Custom = New Krypton.Toolkit.KryptonComboBox()
        Me.buttonSpecAny3 = New Krypton.Toolkit.ButtonSpecAny()
        Me.buttonSpecAny4 = New Krypton.Toolkit.ButtonSpecAny()
        Me.kryptonComboBox7Custom = New Krypton.Toolkit.KryptonComboBox()
        Me.groupBox4.SuspendLayout()
        Me.groupBox2.SuspendLayout()
        CType(Me.kryptonComboBox3Blue, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.kryptonComboBox2Blue, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.kryptonComboBox1Blue, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.groupBox1.SuspendLayout()
        CType(Me.kryptonComboBox6System, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.kryptonComboBox5System, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.kryptonComboBox4System, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.groupBox3.SuspendLayout()
        CType(Me.kryptonComboBox8Custom, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.kryptonComboBox7Custom, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        Me.buttonClose.DialogResult = System.Windows.Forms.DialogResult.Cancel
        Me.buttonClose.Location = New System.Drawing.Point(466, 408)
        Me.buttonClose.Name = "buttonClose"
        Me.buttonClose.Size = New System.Drawing.Size(75, 23)
        Me.buttonClose.TabIndex = 4
        Me.buttonClose.Text = "&Close"
        Me.buttonClose.UseVisualStyleBackColor = True
        Me.groupBox4.Controls.Add(Me.propertyGrid)
        Me.groupBox4.Location = New System.Drawing.Point(219, 12)
        Me.groupBox4.Name = "groupBox4"
        Me.groupBox4.Size = New System.Drawing.Size(322, 390)
        Me.groupBox4.TabIndex = 3
        Me.groupBox4.TabStop = False
        Me.groupBox4.Text = "Properties for Selected KryptonComboBox"
        Me.propertyGrid.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) Or System.Windows.Forms.AnchorStyles.Left) Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.propertyGrid.Location = New System.Drawing.Point(9, 19)
        Me.propertyGrid.Name = "propertyGrid"
        Me.propertyGrid.Size = New System.Drawing.Size(310, 365)
        Me.propertyGrid.TabIndex = 0
        Me.propertyGrid.ToolbarVisible = False
        Me.groupBox2.Controls.Add(Me.kryptonComboBox3Blue)
        Me.groupBox2.Controls.Add(Me.kryptonComboBox2Blue)
        Me.groupBox2.Controls.Add(Me.kryptonComboBox1Blue)
        Me.groupBox2.Location = New System.Drawing.Point(12, 12)
        Me.groupBox2.Name = "groupBox2"
        Me.groupBox2.Size = New System.Drawing.Size(201, 126)
        Me.groupBox2.TabIndex = 0
        Me.groupBox2.TabStop = False
        Me.groupBox2.Text = "Office 2010 - Blue"
        Me.kryptonComboBox3Blue.AlwaysActive = False
        Me.kryptonComboBox3Blue.CueHint.Padding = New System.Windows.Forms.Padding(0)
        Me.kryptonComboBox3Blue.DropDownWidth = 169
        Me.kryptonComboBox3Blue.InputControlStyle = Krypton.Toolkit.InputControlStyle.Ribbon
        Me.kryptonComboBox3Blue.IntegralHeight = False
        Me.kryptonComboBox3Blue.Items.AddRange(New Object() { "one", "two", "three", "four", "five", "six"})
        Me.kryptonComboBox3Blue.Location = New System.Drawing.Point(16, 88)
        Me.kryptonComboBox3Blue.Name = "kryptonComboBox3Blue"
        Me.kryptonComboBox3Blue.PaletteMode = Krypton.Toolkit.PaletteMode.Office2010Blue
        Me.kryptonComboBox3Blue.Size = New System.Drawing.Size(169, 28)
        Me.kryptonComboBox3Blue.StateCommon.ComboBox.Border.DrawBorders = CType((((Krypton.Toolkit.PaletteDrawBorders.Top Or Krypton.Toolkit.PaletteDrawBorders.Bottom) Or Krypton.Toolkit.PaletteDrawBorders.Left) Or Krypton.Toolkit.PaletteDrawBorders.Right), Krypton.Toolkit.PaletteDrawBorders)
        Me.kryptonComboBox3Blue.StateCommon.ComboBox.Border.Rounding = 4F
        Me.kryptonComboBox3Blue.StateDisabled.ComboBox.Back.Color1 = System.Drawing.Color.Silver
        Me.kryptonComboBox3Blue.StateDisabled.ComboBox.Content.Color1 = System.Drawing.Color.Red
        Me.kryptonComboBox3Blue.TabIndex = 0
        Me.kryptonComboBox3Blue.Text = "ribbon style"
        Me.kryptonComboBox2Blue.ButtonSpecs.Add(Me.buttonSpecAny1)
        Me.kryptonComboBox2Blue.CueHint.Padding = New System.Windows.Forms.Padding(0)
        Me.kryptonComboBox2Blue.DropDownWidth = 169
        Me.kryptonComboBox2Blue.IntegralHeight = False
        Me.kryptonComboBox2Blue.Items.AddRange(New Object() { "one", "two", "three", "four", "five", "six"})
        Me.kryptonComboBox2Blue.Location = New System.Drawing.Point(16, 57)
        Me.kryptonComboBox2Blue.Name = "kryptonComboBox2Blue"
        Me.kryptonComboBox2Blue.PaletteMode = Krypton.Toolkit.PaletteMode.Office2010Blue
        Me.kryptonComboBox2Blue.Size = New System.Drawing.Size(169, 28)
        Me.kryptonComboBox2Blue.StateCommon.ComboBox.Border.DrawBorders = CType((((Krypton.Toolkit.PaletteDrawBorders.Top Or Krypton.Toolkit.PaletteDrawBorders.Bottom) Or Krypton.Toolkit.PaletteDrawBorders.Left) Or Krypton.Toolkit.PaletteDrawBorders.Right), Krypton.Toolkit.PaletteDrawBorders)
        Me.kryptonComboBox2Blue.StateCommon.ComboBox.Border.Rounding = 3F
        Me.kryptonComboBox2Blue.TabIndex = 1
        Me.kryptonComboBox2Blue.Text = "clear with button"
        Me.buttonSpecAny1.Edge = Krypton.Toolkit.PaletteRelativeEdgeAlign.Near
        Me.buttonSpecAny1.Type = Krypton.Toolkit.PaletteButtonSpecStyle.Close
        Me.buttonSpecAny1.UniqueName = "37524C52AC4E48FE37524C52AC4E48FE"
        Me.kryptonComboBox1Blue.CueHint.Color1 = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(192, Byte), Integer), CType(CType(128, Byte), Integer))
        Me.kryptonComboBox1Blue.CueHint.CueHintText = "Cue Hint Text"
        Me.kryptonComboBox1Blue.CueHint.Font = New System.Drawing.Font("Tahoma", 10.2F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.kryptonComboBox1Blue.CueHint.Hint = Krypton.Toolkit.PaletteTextHint.SingleBitPerPixel
        Me.kryptonComboBox1Blue.CueHint.Padding = New System.Windows.Forms.Padding(0)
        Me.kryptonComboBox1Blue.CueHint.TextH = Krypton.Toolkit.PaletteRelativeAlign.Center
        Me.kryptonComboBox1Blue.DropDownWidth = 169
        Me.kryptonComboBox1Blue.IntegralHeight = False
        Me.kryptonComboBox1Blue.Items.AddRange(New Object() { "one", "two", "three", "four", "five", "six"})
        Me.kryptonComboBox1Blue.Location = New System.Drawing.Point(16, 27)
        Me.kryptonComboBox1Blue.Name = "kryptonComboBox1Blue"
        Me.kryptonComboBox1Blue.PaletteMode = Krypton.Toolkit.PaletteMode.Office2010Blue
        Me.kryptonComboBox1Blue.Size = New System.Drawing.Size(169, 28)
        Me.kryptonComboBox1Blue.StateCommon.ComboBox.Border.DrawBorders = CType((((Krypton.Toolkit.PaletteDrawBorders.Top Or Krypton.Toolkit.PaletteDrawBorders.Bottom) Or Krypton.Toolkit.PaletteDrawBorders.Left) Or Krypton.Toolkit.PaletteDrawBorders.Right), Krypton.Toolkit.PaletteDrawBorders)
        Me.kryptonComboBox1Blue.StateCommon.ComboBox.Border.Rounding = 2F
        Me.kryptonComboBox1Blue.TabIndex = 0
        Me.groupBox1.Controls.Add(Me.kryptonComboBox6System)
        Me.groupBox1.Controls.Add(Me.kryptonComboBox5System)
        Me.groupBox1.Controls.Add(Me.kryptonComboBox4System)
        Me.groupBox1.Location = New System.Drawing.Point(12, 144)
        Me.groupBox1.Name = "groupBox1"
        Me.groupBox1.Size = New System.Drawing.Size(201, 126)
        Me.groupBox1.TabIndex = 1
        Me.groupBox1.TabStop = False
        Me.groupBox1.Text = "Professional - System"
        Me.kryptonComboBox6System.AlwaysActive = False
        Me.kryptonComboBox6System.CueHint.Padding = New System.Windows.Forms.Padding(0)
        Me.kryptonComboBox6System.DropDownWidth = 169
        Me.kryptonComboBox6System.InputControlStyle = Krypton.Toolkit.InputControlStyle.Ribbon
        Me.kryptonComboBox6System.IntegralHeight = False
        Me.kryptonComboBox6System.Items.AddRange(New Object() { "one", "two", "three", "four", "five", "six"})
        Me.kryptonComboBox6System.Location = New System.Drawing.Point(16, 90)
        Me.kryptonComboBox6System.Name = "kryptonComboBox6System"
        Me.kryptonComboBox6System.PaletteMode = Krypton.Toolkit.PaletteMode.ProfessionalSystem
        Me.kryptonComboBox6System.Size = New System.Drawing.Size(169, 30)
        Me.kryptonComboBox6System.StateCommon.ComboBox.Border.DrawBorders = CType((((Krypton.Toolkit.PaletteDrawBorders.Top Or Krypton.Toolkit.PaletteDrawBorders.Bottom) Or Krypton.Toolkit.PaletteDrawBorders.Left) Or Krypton.Toolkit.PaletteDrawBorders.Right), Krypton.Toolkit.PaletteDrawBorders)
        Me.kryptonComboBox6System.StateCommon.ComboBox.Border.Rounding = 7F
        Me.kryptonComboBox6System.StateCommon.ComboBox.Content.TextH = Krypton.Toolkit.PaletteRelativeAlign.Near
        Me.kryptonComboBox6System.TabIndex = 2
        Me.kryptonComboBox6System.Text = "ribbon style"
        Me.kryptonComboBox5System.ButtonSpecs.Add(Me.buttonSpecAny2)
        Me.kryptonComboBox5System.CueHint.Padding = New System.Windows.Forms.Padding(0)
        Me.kryptonComboBox5System.DropDownWidth = 169
        Me.kryptonComboBox5System.IntegralHeight = False
        Me.kryptonComboBox5System.Items.AddRange(New Object() { "one", "two", "three", "four", "five", "six"})
        Me.kryptonComboBox5System.Location = New System.Drawing.Point(16, 58)
        Me.kryptonComboBox5System.Name = "kryptonComboBox5System"
        Me.kryptonComboBox5System.PaletteMode = Krypton.Toolkit.PaletteMode.ProfessionalSystem
        Me.kryptonComboBox5System.Size = New System.Drawing.Size(169, 30)
        Me.kryptonComboBox5System.StateCommon.ComboBox.Border.DrawBorders = CType((((Krypton.Toolkit.PaletteDrawBorders.Top Or Krypton.Toolkit.PaletteDrawBorders.Bottom) Or Krypton.Toolkit.PaletteDrawBorders.Left) Or Krypton.Toolkit.PaletteDrawBorders.Right), Krypton.Toolkit.PaletteDrawBorders)
        Me.kryptonComboBox5System.StateCommon.ComboBox.Border.Rounding = 6F
        Me.kryptonComboBox5System.StateCommon.ComboBox.Content.TextH = Krypton.Toolkit.PaletteRelativeAlign.Near
        Me.kryptonComboBox5System.StateCommon.Item.Content.ShortText.Hint = Krypton.Toolkit.PaletteTextHint.AntiAlias
        Me.kryptonComboBox5System.TabIndex = 0
        Me.kryptonComboBox5System.Text = "clear with button"
        Me.buttonSpecAny2.Edge = Krypton.Toolkit.PaletteRelativeEdgeAlign.Near
        Me.buttonSpecAny2.Style = Krypton.Toolkit.PaletteButtonStyle.ButtonSpec
        Me.buttonSpecAny2.Type = Krypton.Toolkit.PaletteButtonSpecStyle.Close
        Me.buttonSpecAny2.UniqueName = "37524C52AC4E48FE37524C52AC4E48FE"
        Me.kryptonComboBox4System.CueHint.Padding = New System.Windows.Forms.Padding(0)
        Me.kryptonComboBox4System.DropDownWidth = 169
        Me.kryptonComboBox4System.IntegralHeight = False
        Me.kryptonComboBox4System.Items.AddRange(New Object() { "one", "two", "three", "four", "five", "six"})
        Me.kryptonComboBox4System.Location = New System.Drawing.Point(16, 27)
        Me.kryptonComboBox4System.Name = "kryptonComboBox4System"
        Me.kryptonComboBox4System.PaletteMode = Krypton.Toolkit.PaletteMode.ProfessionalSystem
        Me.kryptonComboBox4System.Size = New System.Drawing.Size(169, 30)
        Me.kryptonComboBox4System.StateCommon.ComboBox.Border.DrawBorders = CType((((Krypton.Toolkit.PaletteDrawBorders.Top Or Krypton.Toolkit.PaletteDrawBorders.Bottom) Or Krypton.Toolkit.PaletteDrawBorders.Left) Or Krypton.Toolkit.PaletteDrawBorders.Right), Krypton.Toolkit.PaletteDrawBorders)
        Me.kryptonComboBox4System.StateCommon.ComboBox.Border.Rounding = 5F
        Me.kryptonComboBox4System.StateCommon.ComboBox.Content.TextH = Krypton.Toolkit.PaletteRelativeAlign.Near
        Me.kryptonComboBox4System.TabIndex = 0
        Me.kryptonComboBox4System.Text = "normal"
        Me.groupBox3.Controls.Add(Me.kryptonComboBox8Custom)
        Me.groupBox3.Controls.Add(Me.kryptonComboBox7Custom)
        Me.groupBox3.Location = New System.Drawing.Point(12, 276)
        Me.groupBox3.Name = "groupBox3"
        Me.groupBox3.Size = New System.Drawing.Size(201, 126)
        Me.groupBox3.TabIndex = 2
        Me.groupBox3.TabStop = False
        Me.groupBox3.Text = "Custom Settings"
        Me.kryptonComboBox8Custom.ButtonSpecs.Add(Me.buttonSpecAny3)
        Me.kryptonComboBox8Custom.ButtonSpecs.Add(Me.buttonSpecAny4)
        Me.kryptonComboBox8Custom.CueHint.Color1 = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(128, Byte), Integer), CType(CType(0, Byte), Integer))
        Me.kryptonComboBox8Custom.CueHint.CueHintText = "Cue Hint Text"
        Me.kryptonComboBox8Custom.CueHint.Font = New System.Drawing.Font("Tahoma", 10.2F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.kryptonComboBox8Custom.CueHint.Padding = New System.Windows.Forms.Padding(0)
        Me.kryptonComboBox8Custom.CueHint.TextH = Krypton.Toolkit.PaletteRelativeAlign.Center
        Me.kryptonComboBox8Custom.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.kryptonComboBox8Custom.DropDownWidth = 179
        Me.kryptonComboBox8Custom.IntegralHeight = False
        Me.kryptonComboBox8Custom.Items.AddRange(New Object() { "one", "two", "three", "four", "five", "six"})
        Me.kryptonComboBox8Custom.Location = New System.Drawing.Point(9, 69)
        Me.kryptonComboBox8Custom.Name = "kryptonComboBox8Custom"
        Me.kryptonComboBox8Custom.PaletteMode = Krypton.Toolkit.PaletteMode.ProfessionalSystem
        Me.kryptonComboBox8Custom.Size = New System.Drawing.Size(182, 28)
        Me.kryptonComboBox8Custom.StateCommon.ComboBox.Border.DrawBorders = CType((((Krypton.Toolkit.PaletteDrawBorders.Top Or Krypton.Toolkit.PaletteDrawBorders.Bottom) Or Krypton.Toolkit.PaletteDrawBorders.Left) Or Krypton.Toolkit.PaletteDrawBorders.Right), Krypton.Toolkit.PaletteDrawBorders)
        Me.kryptonComboBox8Custom.StateCommon.ComboBox.Border.GraphicsHint = Krypton.Toolkit.PaletteGraphicsHint.AntiAlias
        Me.kryptonComboBox8Custom.StateCommon.ComboBox.Border.Rounding = 2F
        Me.kryptonComboBox8Custom.StateCommon.ComboBox.Content.TextH = Krypton.Toolkit.PaletteRelativeAlign.Near
        Me.kryptonComboBox8Custom.TabIndex = 0
        Me.buttonSpecAny3.Style = Krypton.Toolkit.PaletteButtonStyle.Standalone
        Me.buttonSpecAny3.Type = Krypton.Toolkit.PaletteButtonSpecStyle.ArrowLeft
        Me.buttonSpecAny3.UniqueName = "43801810E6F9413243801810E6F94132"
        Me.buttonSpecAny4.Style = Krypton.Toolkit.PaletteButtonStyle.Standalone
        Me.buttonSpecAny4.Type = Krypton.Toolkit.PaletteButtonSpecStyle.ArrowRight
        Me.buttonSpecAny4.UniqueName = "0CDF070A67D6473D0CDF070A67D6473D"
        Me.kryptonComboBox7Custom.CueHint.Padding = New System.Windows.Forms.Padding(0)
        Me.kryptonComboBox7Custom.DropDownWidth = 169
        Me.kryptonComboBox7Custom.IntegralHeight = False
        Me.kryptonComboBox7Custom.Items.AddRange(New Object() { "one", "two", "three", "four", "five", "six"})
        Me.kryptonComboBox7Custom.Location = New System.Drawing.Point(16, 30)
        Me.kryptonComboBox7Custom.Name = "kryptonComboBox7Custom"
        Me.kryptonComboBox7Custom.PaletteMode = Krypton.Toolkit.PaletteMode.Office2007Black
        Me.kryptonComboBox7Custom.Size = New System.Drawing.Size(169, 32)
        Me.kryptonComboBox7Custom.StateCommon.ComboBox.Border.DrawBorders = CType((((Krypton.Toolkit.PaletteDrawBorders.Top Or Krypton.Toolkit.PaletteDrawBorders.Bottom) Or Krypton.Toolkit.PaletteDrawBorders.Left) Or Krypton.Toolkit.PaletteDrawBorders.Right), Krypton.Toolkit.PaletteDrawBorders)
        Me.kryptonComboBox7Custom.StateCommon.ComboBox.Border.GraphicsHint = Krypton.Toolkit.PaletteGraphicsHint.AntiAlias
        Me.kryptonComboBox7Custom.StateCommon.ComboBox.Border.Rounding = 10F
        Me.kryptonComboBox7Custom.StateCommon.ComboBox.Content.TextH = Krypton.Toolkit.PaletteRelativeAlign.Center
        Me.kryptonComboBox7Custom.TabIndex = 0
        Me.kryptonComboBox7Custom.Text = "centered"
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8F, 17F)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(550, 440)
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
        Me.Text = "KryptonComboBox Examples"
        Me.groupBox4.ResumeLayout(False)
        Me.groupBox2.ResumeLayout(False)
        CType(Me.kryptonComboBox3Blue, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.kryptonComboBox2Blue, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.kryptonComboBox1Blue, System.ComponentModel.ISupportInitialize).EndInit()
        Me.groupBox1.ResumeLayout(False)
        CType(Me.kryptonComboBox6System, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.kryptonComboBox5System, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.kryptonComboBox4System, System.ComponentModel.ISupportInitialize).EndInit()
        Me.groupBox3.ResumeLayout(False)
        CType(Me.kryptonComboBox8Custom, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.kryptonComboBox7Custom, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
    End Sub

    Friend WithEvents buttonClose As System.Windows.Forms.Button
    Friend WithEvents groupBox4 As System.Windows.Forms.GroupBox
    Friend WithEvents propertyGrid As System.Windows.Forms.PropertyGrid
    Friend WithEvents groupBox2 As System.Windows.Forms.GroupBox
    Friend WithEvents groupBox1 As System.Windows.Forms.GroupBox
    Friend WithEvents groupBox3 As System.Windows.Forms.GroupBox
    Friend WithEvents kryptonComboBox1Blue As Krypton.Toolkit.KryptonComboBox
    Friend WithEvents kryptonComboBox3Blue As Krypton.Toolkit.KryptonComboBox
    Friend WithEvents kryptonComboBox2Blue As Krypton.Toolkit.KryptonComboBox
    Friend WithEvents buttonSpecAny1 As Krypton.Toolkit.ButtonSpecAny
    Friend WithEvents kryptonComboBox6System As Krypton.Toolkit.KryptonComboBox
    Friend WithEvents kryptonComboBox5System As Krypton.Toolkit.KryptonComboBox
    Friend WithEvents buttonSpecAny2 As Krypton.Toolkit.ButtonSpecAny
    Friend WithEvents kryptonComboBox4System As Krypton.Toolkit.KryptonComboBox
    Friend WithEvents kryptonComboBox7Custom As Krypton.Toolkit.KryptonComboBox
    Friend WithEvents kryptonComboBox8Custom As Krypton.Toolkit.KryptonComboBox
    Friend WithEvents buttonSpecAny3 As Krypton.Toolkit.ButtonSpecAny
    Friend WithEvents buttonSpecAny4 As Krypton.Toolkit.ButtonSpecAny
End Class
