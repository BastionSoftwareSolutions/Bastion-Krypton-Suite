' VB.NET twin of Source\Krypton Ribbon Examples\MDI Ribbon\Form2.Designer.cs (Bastion Phase 4c).
<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class Form2
    Inherits Krypton.Toolkit.KryptonForm

    'NOTE: Dispose lives in Form2.vb (as in the C# twin, where the designer file
    'carries no Dispose override and Form2.cs unhooks a static event first).

    'Required by the Windows Form Designer
    Private components As System.ComponentModel.IContainer

    'NOTE: The following procedure is required by the Windows Form Designer
    'It can be modified using the Windows Form Designer.
    'Do not modify it using the code editor.
    <System.Diagnostics.DebuggerStepThrough()>
    Private Sub InitializeComponent()
        Me.components = New System.ComponentModel.Container()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(Form2))
        Me.kryptonPanel1 = New Krypton.Toolkit.KryptonPanel()
        Me.radio2010Black = New Krypton.Toolkit.KryptonRadioButton()
        Me.radio2010Silver = New Krypton.Toolkit.KryptonRadioButton()
        Me.radio2010Blue = New Krypton.Toolkit.KryptonRadioButton()
        Me.radioSparkleOrange = New Krypton.Toolkit.KryptonRadioButton()
        Me.radioSparklePurple = New Krypton.Toolkit.KryptonRadioButton()
        Me.radioSparkleBlue = New Krypton.Toolkit.KryptonRadioButton()
        Me.radioBlack = New Krypton.Toolkit.KryptonRadioButton()
        Me.radioSilver = New Krypton.Toolkit.KryptonRadioButton()
        Me.radioBlue = New Krypton.Toolkit.KryptonRadioButton()
        Me.radioOffice2003 = New Krypton.Toolkit.KryptonRadioButton()
        Me.radioSystem = New Krypton.Toolkit.KryptonRadioButton()
        Me.kryptonManager = New Krypton.Toolkit.KryptonManager(Me.components)
        CType(Me.kryptonPanel1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.kryptonPanel1.SuspendLayout()
        Me.SuspendLayout()
        Me.kryptonPanel1.Controls.Add(Me.radio2010Black)
        Me.kryptonPanel1.Controls.Add(Me.radio2010Silver)
        Me.kryptonPanel1.Controls.Add(Me.radio2010Blue)
        Me.kryptonPanel1.Controls.Add(Me.radioSparkleOrange)
        Me.kryptonPanel1.Controls.Add(Me.radioSparklePurple)
        Me.kryptonPanel1.Controls.Add(Me.radioSparkleBlue)
        Me.kryptonPanel1.Controls.Add(Me.radioBlack)
        Me.kryptonPanel1.Controls.Add(Me.radioSilver)
        Me.kryptonPanel1.Controls.Add(Me.radioBlue)
        Me.kryptonPanel1.Controls.Add(Me.radioOffice2003)
        Me.kryptonPanel1.Controls.Add(Me.radioSystem)
        Me.kryptonPanel1.Dock = System.Windows.Forms.DockStyle.Fill
        Me.kryptonPanel1.Location = New System.Drawing.Point(0, 0)
        Me.kryptonPanel1.Margin = New System.Windows.Forms.Padding(4)
        Me.kryptonPanel1.Name = "kryptonPanel1"
        Me.kryptonPanel1.Size = New System.Drawing.Size(576, 145)
        Me.kryptonPanel1.TabIndex = 0
        Me.radio2010Black.Location = New System.Drawing.Point(20, 80)
        Me.radio2010Black.Margin = New System.Windows.Forms.Padding(4)
        Me.radio2010Black.Name = "radio2010Black"
        Me.radio2010Black.Size = New System.Drawing.Size(151, 24)
        Me.radio2010Black.TabIndex = 2
        Me.radio2010Black.Values.Text = "Office 2010 - Black"
        Me.radio2010Silver.Location = New System.Drawing.Point(20, 50)
        Me.radio2010Silver.Margin = New System.Windows.Forms.Padding(4)
        Me.radio2010Silver.Name = "radio2010Silver"
        Me.radio2010Silver.Size = New System.Drawing.Size(153, 24)
        Me.radio2010Silver.TabIndex = 1
        Me.radio2010Silver.Values.Text = "Office 2010 - Silver"
        Me.radio2010Blue.Checked = True
        Me.radio2010Blue.Location = New System.Drawing.Point(20, 21)
        Me.radio2010Blue.Margin = New System.Windows.Forms.Padding(4)
        Me.radio2010Blue.Name = "radio2010Blue"
        Me.radio2010Blue.Size = New System.Drawing.Size(145, 24)
        Me.radio2010Blue.TabIndex = 0
        Me.radio2010Blue.Values.Text = "Office 2010 - Blue"
        Me.radioSparkleOrange.Location = New System.Drawing.Point(385, 50)
        Me.radioSparkleOrange.Margin = New System.Windows.Forms.Padding(4)
        Me.radioSparkleOrange.Name = "radioSparkleOrange"
        Me.radioSparkleOrange.Size = New System.Drawing.Size(139, 24)
        Me.radioSparkleOrange.TabIndex = 7
        Me.radioSparkleOrange.Values.Text = "Sparkle - Orange"
        Me.radioSparklePurple.Location = New System.Drawing.Point(385, 80)
        Me.radioSparklePurple.Margin = New System.Windows.Forms.Padding(4)
        Me.radioSparklePurple.Name = "radioSparklePurple"
        Me.radioSparklePurple.Size = New System.Drawing.Size(132, 24)
        Me.radioSparklePurple.TabIndex = 8
        Me.radioSparklePurple.Values.Text = "Sparkle - Purple"
        Me.radioSparkleBlue.Location = New System.Drawing.Point(385, 21)
        Me.radioSparkleBlue.Margin = New System.Windows.Forms.Padding(4)
        Me.radioSparkleBlue.Name = "radioSparkleBlue"
        Me.radioSparkleBlue.Size = New System.Drawing.Size(118, 24)
        Me.radioSparkleBlue.TabIndex = 6
        Me.radioSparkleBlue.Values.Text = "Sparkle - Blue"
        Me.radioBlack.Location = New System.Drawing.Point(200, 80)
        Me.radioBlack.Margin = New System.Windows.Forms.Padding(4)
        Me.radioBlack.Name = "radioBlack"
        Me.radioBlack.Size = New System.Drawing.Size(151, 24)
        Me.radioBlack.TabIndex = 5
        Me.radioBlack.Values.Text = "Office 2007 - Black"
        Me.radioSilver.Location = New System.Drawing.Point(200, 50)
        Me.radioSilver.Margin = New System.Windows.Forms.Padding(4)
        Me.radioSilver.Name = "radioSilver"
        Me.radioSilver.Size = New System.Drawing.Size(153, 24)
        Me.radioSilver.TabIndex = 4
        Me.radioSilver.Values.Text = "Office 2007 - Silver"
        Me.radioBlue.Location = New System.Drawing.Point(200, 21)
        Me.radioBlue.Margin = New System.Windows.Forms.Padding(4)
        Me.radioBlue.Name = "radioBlue"
        Me.radioBlue.Size = New System.Drawing.Size(145, 24)
        Me.radioBlue.TabIndex = 3
        Me.radioBlue.Values.Text = "Office 2007 - Blue"
        Me.radioOffice2003.Location = New System.Drawing.Point(20, 119)
        Me.radioOffice2003.Margin = New System.Windows.Forms.Padding(4)
        Me.radioOffice2003.Name = "radioOffice2003"
        Me.radioOffice2003.Size = New System.Drawing.Size(101, 24)
        Me.radioOffice2003.TabIndex = 9
        Me.radioOffice2003.Values.Text = "Office 2003"
        Me.radioSystem.Location = New System.Drawing.Point(200, 119)
        Me.radioSystem.Margin = New System.Windows.Forms.Padding(4)
        Me.radioSystem.Name = "radioSystem"
        Me.radioSystem.Size = New System.Drawing.Size(72, 24)
        Me.radioSystem.TabIndex = 10
        Me.radioSystem.Values.Text = "System"
        Me.kryptonManager.GlobalPaletteMode = Krypton.Toolkit.PaletteMode.Office2007Blue
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.None
        Me.ClientSize = New System.Drawing.Size(576, 145)
        Me.Controls.Add(Me.kryptonPanel1)
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.Margin = New System.Windows.Forms.Padding(4)
        Me.Name = "Form2"
        Me.Text = "Form2"
        CType(Me.kryptonPanel1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.kryptonPanel1.ResumeLayout(False)
        Me.kryptonPanel1.PerformLayout()
        Me.ResumeLayout(False)
    End Sub

    Friend WithEvents kryptonPanel1 As Krypton.Toolkit.KryptonPanel
    Friend WithEvents radioSystem As Krypton.Toolkit.KryptonRadioButton
    Friend WithEvents radioBlack As Krypton.Toolkit.KryptonRadioButton
    Friend WithEvents radioSilver As Krypton.Toolkit.KryptonRadioButton
    Friend WithEvents radioBlue As Krypton.Toolkit.KryptonRadioButton
    Friend WithEvents radioOffice2003 As Krypton.Toolkit.KryptonRadioButton
    Friend WithEvents kryptonManager As Krypton.Toolkit.KryptonManager
    Friend WithEvents radioSparkleBlue As Krypton.Toolkit.KryptonRadioButton
    Friend WithEvents radioSparkleOrange As Krypton.Toolkit.KryptonRadioButton
    Friend WithEvents radioSparklePurple As Krypton.Toolkit.KryptonRadioButton
    Friend WithEvents radio2010Black As Krypton.Toolkit.KryptonRadioButton
    Friend WithEvents radio2010Silver As Krypton.Toolkit.KryptonRadioButton
    Friend WithEvents radio2010Blue As Krypton.Toolkit.KryptonRadioButton
End Class
