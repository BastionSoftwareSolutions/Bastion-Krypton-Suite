' VB.NET twin of Source\Krypton Toolkit Examples\KryptonTrackBar Examples\Form1.Designer.cs (Bastion Phase 4c).
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
        Me.propertyGrid = New System.Windows.Forms.PropertyGrid()
        Me.groupBox4 = New System.Windows.Forms.GroupBox()
        Me.buttonClose = New System.Windows.Forms.Button()
        Me.groupBox1 = New System.Windows.Forms.GroupBox()
        Me.kryptonTrackBar4 = New Krypton.Toolkit.KryptonTrackBar()
        Me.kryptonTrackBar3 = New Krypton.Toolkit.KryptonTrackBar()
        Me.kryptonTrackBar2 = New Krypton.Toolkit.KryptonTrackBar()
        Me.kryptonTrackBar1 = New Krypton.Toolkit.KryptonTrackBar()
        Me.groupBox2 = New System.Windows.Forms.GroupBox()
        Me.kryptonTrackBar11 = New Krypton.Toolkit.KryptonTrackBar()
        Me.kryptonTrackBar10 = New Krypton.Toolkit.KryptonTrackBar()
        Me.kryptonTrackBar9 = New Krypton.Toolkit.KryptonTrackBar()
        Me.kryptonTrackBar5 = New Krypton.Toolkit.KryptonTrackBar()
        Me.kryptonTrackBar6 = New Krypton.Toolkit.KryptonTrackBar()
        Me.kryptonTrackBar7 = New Krypton.Toolkit.KryptonTrackBar()
        Me.kryptonTrackBar8 = New Krypton.Toolkit.KryptonTrackBar()
        Me.kryptonPanel1 = New Krypton.Toolkit.KryptonPanel()
        Me.kryptonTrackBar12 = New Krypton.Toolkit.KryptonTrackBar()
        Me.kryptonTrackBar13 = New Krypton.Toolkit.KryptonTrackBar()
        Me.kryptonTrackBar14 = New Krypton.Toolkit.KryptonTrackBar()
        Me.kryptonTrackBar15 = New Krypton.Toolkit.KryptonTrackBar()
        Me.groupBox4.SuspendLayout()
        Me.groupBox1.SuspendLayout()
        Me.groupBox2.SuspendLayout()
        CType(Me.kryptonPanel1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.kryptonPanel1.SuspendLayout()
        Me.SuspendLayout()
        Me.propertyGrid.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) Or System.Windows.Forms.AnchorStyles.Left) Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.propertyGrid.Location = New System.Drawing.Point(6, 19)
        Me.propertyGrid.Name = "propertyGrid"
        Me.propertyGrid.Size = New System.Drawing.Size(310, 497)
        Me.propertyGrid.TabIndex = 0
        Me.propertyGrid.ToolbarVisible = False
        Me.groupBox4.Controls.Add(Me.propertyGrid)
        Me.groupBox4.Location = New System.Drawing.Point(297, 12)
        Me.groupBox4.Name = "groupBox4"
        Me.groupBox4.Size = New System.Drawing.Size(322, 522)
        Me.groupBox4.TabIndex = 2
        Me.groupBox4.TabStop = False
        Me.groupBox4.Text = "Properties for Selected KryptonTrackBar"
        Me.buttonClose.DialogResult = System.Windows.Forms.DialogResult.Cancel
        Me.buttonClose.Location = New System.Drawing.Point(544, 540)
        Me.buttonClose.Name = "buttonClose"
        Me.buttonClose.Size = New System.Drawing.Size(75, 23)
        Me.buttonClose.TabIndex = 3
        Me.buttonClose.Text = "&Close"
        Me.buttonClose.UseVisualStyleBackColor = True
        Me.groupBox1.Controls.Add(Me.kryptonTrackBar4)
        Me.groupBox1.Controls.Add(Me.kryptonTrackBar3)
        Me.groupBox1.Controls.Add(Me.kryptonTrackBar2)
        Me.groupBox1.Controls.Add(Me.kryptonTrackBar1)
        Me.groupBox1.Location = New System.Drawing.Point(12, 12)
        Me.groupBox1.Name = "groupBox1"
        Me.groupBox1.Size = New System.Drawing.Size(279, 185)
        Me.groupBox1.TabIndex = 0
        Me.groupBox1.TabStop = False
        Me.groupBox1.Text = "Orientation = Horizontal"
        Me.kryptonTrackBar4.Location = New System.Drawing.Point(15, 148)
        Me.kryptonTrackBar4.Name = "kryptonTrackBar4"
        Me.kryptonTrackBar4.Orientation = System.Windows.Forms.Orientation.Horizontal
        Me.kryptonTrackBar4.PaletteMode = Krypton.Toolkit.PaletteMode.ProfessionalSystem
        Me.kryptonTrackBar4.Size = New System.Drawing.Size(250, 27)
        Me.kryptonTrackBar4.TabIndex = 3
        Me.kryptonTrackBar4.TickStyle = System.Windows.Forms.TickStyle.None
        Me.kryptonTrackBar4.TrackBarSize = Krypton.Toolkit.PaletteTrackBarSize.Large
        Me.kryptonTrackBar4.Value = 7
        Me.kryptonTrackBar4.VolumeControl = True
        Me.kryptonTrackBar3.Location = New System.Drawing.Point(15, 97)
        Me.kryptonTrackBar3.Maximum = 30
        Me.kryptonTrackBar3.Name = "kryptonTrackBar3"
        Me.kryptonTrackBar3.Orientation = System.Windows.Forms.Orientation.Horizontal
        Me.kryptonTrackBar3.PaletteMode = Krypton.Toolkit.PaletteMode.SparkleBlue
        Me.kryptonTrackBar3.Size = New System.Drawing.Size(250, 41)
        Me.kryptonTrackBar3.TabIndex = 2
        Me.kryptonTrackBar3.TickStyle = System.Windows.Forms.TickStyle.Both
        Me.kryptonTrackBar3.TrackBarSize = Krypton.Toolkit.PaletteTrackBarSize.Large
        Me.kryptonTrackBar3.Value = 15
        Me.kryptonTrackBar2.Location = New System.Drawing.Point(15, 60)
        Me.kryptonTrackBar2.Maximum = 20
        Me.kryptonTrackBar2.Name = "kryptonTrackBar2"
        Me.kryptonTrackBar2.Orientation = System.Windows.Forms.Orientation.Horizontal
        Me.kryptonTrackBar2.PaletteMode = Krypton.Toolkit.PaletteMode.Office2007Blue
        Me.kryptonTrackBar2.Size = New System.Drawing.Size(250, 27)
        Me.kryptonTrackBar2.TabIndex = 1
        Me.kryptonTrackBar2.TickStyle = System.Windows.Forms.TickStyle.TopLeft
        Me.kryptonTrackBar2.TrackBarSize = Krypton.Toolkit.PaletteTrackBarSize.Medium
        Me.kryptonTrackBar2.Value = 5
        Me.kryptonTrackBar1.Location = New System.Drawing.Point(15, 30)
        Me.kryptonTrackBar1.Name = "kryptonTrackBar1"
        Me.kryptonTrackBar1.Orientation = System.Windows.Forms.Orientation.Horizontal
        Me.kryptonTrackBar1.PaletteMode = Krypton.Toolkit.PaletteMode.Office2010Blue
        Me.kryptonTrackBar1.Size = New System.Drawing.Size(250, 20)
        Me.kryptonTrackBar1.TabIndex = 0
        Me.kryptonTrackBar1.TickStyle = System.Windows.Forms.TickStyle.BottomRight
        Me.kryptonTrackBar1.TrackBarSize = Krypton.Toolkit.PaletteTrackBarSize.Small
        Me.kryptonTrackBar1.Value = 1
        Me.groupBox2.Controls.Add(Me.kryptonTrackBar11)
        Me.groupBox2.Controls.Add(Me.kryptonTrackBar10)
        Me.groupBox2.Controls.Add(Me.kryptonTrackBar9)
        Me.groupBox2.Controls.Add(Me.kryptonTrackBar5)
        Me.groupBox2.Controls.Add(Me.kryptonTrackBar6)
        Me.groupBox2.Controls.Add(Me.kryptonTrackBar7)
        Me.groupBox2.Controls.Add(Me.kryptonTrackBar8)
        Me.groupBox2.Location = New System.Drawing.Point(12, 203)
        Me.groupBox2.Name = "groupBox2"
        Me.groupBox2.Size = New System.Drawing.Size(279, 198)
        Me.groupBox2.TabIndex = 1
        Me.groupBox2.TabStop = False
        Me.groupBox2.Text = "Orientation = Vertical"
        Me.kryptonTrackBar11.Location = New System.Drawing.Point(141, 28)
        Me.kryptonTrackBar11.Maximum = 20
        Me.kryptonTrackBar11.Name = "kryptonTrackBar11"
        Me.kryptonTrackBar11.Orientation = System.Windows.Forms.Orientation.Vertical
        Me.kryptonTrackBar11.PaletteMode = Krypton.Toolkit.PaletteMode.Office2007Silver
        Me.kryptonTrackBar11.Size = New System.Drawing.Size(27, 159)
        Me.kryptonTrackBar11.TabIndex = 4
        Me.kryptonTrackBar11.TickStyle = System.Windows.Forms.TickStyle.TopLeft
        Me.kryptonTrackBar11.TrackBarSize = Krypton.Toolkit.PaletteTrackBarSize.Medium
        Me.kryptonTrackBar11.Value = 5
        Me.kryptonTrackBar10.Location = New System.Drawing.Point(74, 28)
        Me.kryptonTrackBar10.Name = "kryptonTrackBar10"
        Me.kryptonTrackBar10.Orientation = System.Windows.Forms.Orientation.Vertical
        Me.kryptonTrackBar10.PaletteMode = Krypton.Toolkit.PaletteMode.Office2010Black
        Me.kryptonTrackBar10.Size = New System.Drawing.Size(20, 159)
        Me.kryptonTrackBar10.TabIndex = 2
        Me.kryptonTrackBar10.TickStyle = System.Windows.Forms.TickStyle.BottomRight
        Me.kryptonTrackBar10.TrackBarSize = Krypton.Toolkit.PaletteTrackBarSize.Small
        Me.kryptonTrackBar10.Value = 1
        Me.kryptonTrackBar9.Location = New System.Drawing.Point(44, 28)
        Me.kryptonTrackBar9.Name = "kryptonTrackBar9"
        Me.kryptonTrackBar9.Orientation = System.Windows.Forms.Orientation.Vertical
        Me.kryptonTrackBar9.PaletteMode = Krypton.Toolkit.PaletteMode.Office2010Silver
        Me.kryptonTrackBar9.Size = New System.Drawing.Size(20, 159)
        Me.kryptonTrackBar9.TabIndex = 1
        Me.kryptonTrackBar9.TickStyle = System.Windows.Forms.TickStyle.BottomRight
        Me.kryptonTrackBar9.TrackBarSize = Krypton.Toolkit.PaletteTrackBarSize.Small
        Me.kryptonTrackBar9.Value = 1
        Me.kryptonTrackBar5.Location = New System.Drawing.Point(238, 28)
        Me.kryptonTrackBar5.Name = "kryptonTrackBar5"
        Me.kryptonTrackBar5.Orientation = System.Windows.Forms.Orientation.Vertical
        Me.kryptonTrackBar5.PaletteMode = Krypton.Toolkit.PaletteMode.ProfessionalSystem
        Me.kryptonTrackBar5.Size = New System.Drawing.Size(27, 159)
        Me.kryptonTrackBar5.TabIndex = 7
        Me.kryptonTrackBar5.TickStyle = System.Windows.Forms.TickStyle.None
        Me.kryptonTrackBar5.TrackBarSize = Krypton.Toolkit.PaletteTrackBarSize.Large
        Me.kryptonTrackBar5.UseWaitCursor = True
        Me.kryptonTrackBar5.Value = 7
        Me.kryptonTrackBar5.VolumeControl = True
        Me.kryptonTrackBar6.Location = New System.Drawing.Point(182, 28)
        Me.kryptonTrackBar6.Maximum = 20
        Me.kryptonTrackBar6.Name = "kryptonTrackBar6"
        Me.kryptonTrackBar6.Orientation = System.Windows.Forms.Orientation.Vertical
        Me.kryptonTrackBar6.PaletteMode = Krypton.Toolkit.PaletteMode.SparkleBlue
        Me.kryptonTrackBar6.Size = New System.Drawing.Size(41, 159)
        Me.kryptonTrackBar6.TabIndex = 6
        Me.kryptonTrackBar6.TickStyle = System.Windows.Forms.TickStyle.Both
        Me.kryptonTrackBar6.TrackBarSize = Krypton.Toolkit.PaletteTrackBarSize.Large
        Me.kryptonTrackBar6.Value = 10
        Me.kryptonTrackBar7.Location = New System.Drawing.Point(105, 28)
        Me.kryptonTrackBar7.Maximum = 20
        Me.kryptonTrackBar7.Name = "kryptonTrackBar7"
        Me.kryptonTrackBar7.Orientation = System.Windows.Forms.Orientation.Vertical
        Me.kryptonTrackBar7.PaletteMode = Krypton.Toolkit.PaletteMode.Office2007Blue
        Me.kryptonTrackBar7.Size = New System.Drawing.Size(27, 159)
        Me.kryptonTrackBar7.TabIndex = 3
        Me.kryptonTrackBar7.TickStyle = System.Windows.Forms.TickStyle.TopLeft
        Me.kryptonTrackBar7.TrackBarSize = Krypton.Toolkit.PaletteTrackBarSize.Medium
        Me.kryptonTrackBar7.Value = 5
        Me.kryptonTrackBar8.Location = New System.Drawing.Point(14, 28)
        Me.kryptonTrackBar8.Name = "kryptonTrackBar8"
        Me.kryptonTrackBar8.Orientation = System.Windows.Forms.Orientation.Vertical
        Me.kryptonTrackBar8.PaletteMode = Krypton.Toolkit.PaletteMode.Office2010Blue
        Me.kryptonTrackBar8.Size = New System.Drawing.Size(20, 159)
        Me.kryptonTrackBar8.TabIndex = 0
        Me.kryptonTrackBar8.TickStyle = System.Windows.Forms.TickStyle.BottomRight
        Me.kryptonTrackBar8.TrackBarSize = Krypton.Toolkit.PaletteTrackBarSize.Small
        Me.kryptonTrackBar8.Value = 1
        Me.kryptonPanel1.Controls.Add(Me.kryptonTrackBar12)
        Me.kryptonPanel1.Controls.Add(Me.kryptonTrackBar13)
        Me.kryptonPanel1.Controls.Add(Me.kryptonTrackBar14)
        Me.kryptonPanel1.Controls.Add(Me.kryptonTrackBar15)
        Me.kryptonPanel1.Location = New System.Drawing.Point(12, 407)
        Me.kryptonPanel1.Name = "kryptonPanel1"
        Me.kryptonPanel1.Size = New System.Drawing.Size(279, 156)
        Me.kryptonPanel1.StateCommon.Color1 = System.Drawing.Color.FromArgb(CType(CType(192, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.kryptonPanel1.StateCommon.Color2 = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(64, Byte), Integer), CType(CType(0, Byte), Integer))
        Me.kryptonPanel1.StateCommon.ColorAlign = Krypton.Toolkit.PaletteRectangleAlign.Local
        Me.kryptonPanel1.StateCommon.ColorAngle = 45F
        Me.kryptonPanel1.StateCommon.ColorStyle = Krypton.Toolkit.PaletteColorStyle.GlassCenter
        Me.kryptonPanel1.StateCommon.Draw = Krypton.Toolkit.InheritBool.True
        Me.kryptonPanel1.StateCommon.GraphicsHint = Krypton.Toolkit.PaletteGraphicsHint.AntiAlias
        Me.kryptonPanel1.StateCommon.ImageAlign = Krypton.Toolkit.PaletteRectangleAlign.Inherit
        Me.kryptonPanel1.StateCommon.ImageStyle = Krypton.Toolkit.PaletteImageStyle.Inherit
        Me.kryptonPanel1.TabIndex = 4
        Me.kryptonTrackBar12.BackStyle = Krypton.Toolkit.PaletteBackStyle.ButtonStandalone
        Me.kryptonTrackBar12.DrawBackground = False
        Me.kryptonTrackBar12.Location = New System.Drawing.Point(14, 121)
        Me.kryptonTrackBar12.Name = "kryptonTrackBar12"
        Me.kryptonTrackBar12.Orientation = System.Windows.Forms.Orientation.Horizontal
        Me.kryptonTrackBar12.PaletteMode = Krypton.Toolkit.PaletteMode.ProfessionalSystem
        Me.kryptonTrackBar12.Size = New System.Drawing.Size(250, 27)
        Me.kryptonTrackBar12.TabIndex = 7
        Me.kryptonTrackBar12.TickStyle = System.Windows.Forms.TickStyle.None
        Me.kryptonTrackBar12.TrackBarSize = Krypton.Toolkit.PaletteTrackBarSize.Large
        Me.kryptonTrackBar12.Value = 7
        Me.kryptonTrackBar12.VolumeControl = True
        Me.kryptonTrackBar13.DrawBackground = False
        Me.kryptonTrackBar13.Location = New System.Drawing.Point(14, 70)
        Me.kryptonTrackBar13.Maximum = 30
        Me.kryptonTrackBar13.Name = "kryptonTrackBar13"
        Me.kryptonTrackBar13.Orientation = System.Windows.Forms.Orientation.Horizontal
        Me.kryptonTrackBar13.PaletteMode = Krypton.Toolkit.PaletteMode.SparkleBlue
        Me.kryptonTrackBar13.Size = New System.Drawing.Size(250, 41)
        Me.kryptonTrackBar13.TabIndex = 6
        Me.kryptonTrackBar13.TickStyle = System.Windows.Forms.TickStyle.Both
        Me.kryptonTrackBar13.TrackBarSize = Krypton.Toolkit.PaletteTrackBarSize.Large
        Me.kryptonTrackBar13.Value = 15
        Me.kryptonTrackBar14.DrawBackground = False
        Me.kryptonTrackBar14.Location = New System.Drawing.Point(14, 33)
        Me.kryptonTrackBar14.Maximum = 20
        Me.kryptonTrackBar14.Name = "kryptonTrackBar14"
        Me.kryptonTrackBar14.Orientation = System.Windows.Forms.Orientation.Horizontal
        Me.kryptonTrackBar14.PaletteMode = Krypton.Toolkit.PaletteMode.Office2007Blue
        Me.kryptonTrackBar14.Size = New System.Drawing.Size(250, 27)
        Me.kryptonTrackBar14.TabIndex = 5
        Me.kryptonTrackBar14.TickStyle = System.Windows.Forms.TickStyle.TopLeft
        Me.kryptonTrackBar14.TrackBarSize = Krypton.Toolkit.PaletteTrackBarSize.Medium
        Me.kryptonTrackBar14.Value = 5
        Me.kryptonTrackBar15.DrawBackground = False
        Me.kryptonTrackBar15.Location = New System.Drawing.Point(14, 3)
        Me.kryptonTrackBar15.Name = "kryptonTrackBar15"
        Me.kryptonTrackBar15.Orientation = System.Windows.Forms.Orientation.Horizontal
        Me.kryptonTrackBar15.PaletteMode = Krypton.Toolkit.PaletteMode.Office2010Blue
        Me.kryptonTrackBar15.Size = New System.Drawing.Size(250, 20)
        Me.kryptonTrackBar15.TabIndex = 4
        Me.kryptonTrackBar15.TickStyle = System.Windows.Forms.TickStyle.BottomRight
        Me.kryptonTrackBar15.TrackBarSize = Krypton.Toolkit.PaletteTrackBarSize.Small
        Me.kryptonTrackBar15.Value = 1
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8F, 17F)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(629, 590)
        Me.Controls.Add(Me.kryptonPanel1)
        Me.Controls.Add(Me.groupBox2)
        Me.Controls.Add(Me.groupBox1)
        Me.Controls.Add(Me.buttonClose)
        Me.Controls.Add(Me.groupBox4)
        Me.Font = New System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.MaximizeBox = False
        Me.MinimizeBox = False
        Me.Name = "Form1"
        Me.Text = "KryptonTrackBar Examples"
        Me.groupBox4.ResumeLayout(False)
        Me.groupBox1.ResumeLayout(False)
        Me.groupBox1.PerformLayout()
        Me.groupBox2.ResumeLayout(False)
        Me.groupBox2.PerformLayout()
        CType(Me.kryptonPanel1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.kryptonPanel1.ResumeLayout(False)
        Me.kryptonPanel1.PerformLayout()
        Me.ResumeLayout(False)
    End Sub

    Friend WithEvents propertyGrid As System.Windows.Forms.PropertyGrid
    Friend WithEvents groupBox4 As System.Windows.Forms.GroupBox
    Friend WithEvents buttonClose As System.Windows.Forms.Button
    Friend WithEvents groupBox1 As System.Windows.Forms.GroupBox
    Friend WithEvents kryptonTrackBar4 As Krypton.Toolkit.KryptonTrackBar
    Friend WithEvents kryptonTrackBar3 As Krypton.Toolkit.KryptonTrackBar
    Friend WithEvents kryptonTrackBar2 As Krypton.Toolkit.KryptonTrackBar
    Friend WithEvents kryptonTrackBar1 As Krypton.Toolkit.KryptonTrackBar
    Friend WithEvents groupBox2 As System.Windows.Forms.GroupBox
    Friend WithEvents kryptonTrackBar11 As Krypton.Toolkit.KryptonTrackBar
    Friend WithEvents kryptonTrackBar10 As Krypton.Toolkit.KryptonTrackBar
    Friend WithEvents kryptonTrackBar9 As Krypton.Toolkit.KryptonTrackBar
    Friend WithEvents kryptonTrackBar5 As Krypton.Toolkit.KryptonTrackBar
    Friend WithEvents kryptonTrackBar6 As Krypton.Toolkit.KryptonTrackBar
    Friend WithEvents kryptonTrackBar7 As Krypton.Toolkit.KryptonTrackBar
    Friend WithEvents kryptonTrackBar8 As Krypton.Toolkit.KryptonTrackBar
    Friend WithEvents kryptonPanel1 As Krypton.Toolkit.KryptonPanel
    Friend WithEvents kryptonTrackBar12 As Krypton.Toolkit.KryptonTrackBar
    Friend WithEvents kryptonTrackBar13 As Krypton.Toolkit.KryptonTrackBar
    Friend WithEvents kryptonTrackBar14 As Krypton.Toolkit.KryptonTrackBar
    Friend WithEvents kryptonTrackBar15 As Krypton.Toolkit.KryptonTrackBar
End Class
