' VB.NET twin of Source\Krypton Toolkit Examples\MDI Application\Form2.Designer.cs (Bastion Phase 4c).
<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class Form2
    Inherits Krypton.Toolkit.KryptonForm

    'NOTE: Dispose lives in Form2.vb, mirroring the C# twin (it must unhook
    'the static KryptonManager.GlobalPaletteChanged event before disposing).

    'Required by the Windows Form Designer
    Private components As System.ComponentModel.IContainer

    'NOTE: The following procedure is required by the Windows Form Designer
    'It can be modified using the Windows Form Designer.
    'Do not modify it using the code editor.
    <System.Diagnostics.DebuggerStepThrough()>
    Private Sub InitializeComponent()
        Me.components = New System.ComponentModel.Container()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(Form2))
        Me.radio2007Blue = New Krypton.Toolkit.KryptonRadioButton()
        Me.radioOffice2003 = New Krypton.Toolkit.KryptonRadioButton()
        Me.radioSystem = New Krypton.Toolkit.KryptonRadioButton()
        Me.radio2007Black = New Krypton.Toolkit.KryptonRadioButton()
        Me.kryptonPanel1 = New Krypton.Toolkit.KryptonPanel()
        Me.radio2010Black = New Krypton.Toolkit.KryptonRadioButton()
        Me.radio2010Silver = New Krypton.Toolkit.KryptonRadioButton()
        Me.radio2010Blue = New Krypton.Toolkit.KryptonRadioButton()
        Me.radioSparkleOrange = New Krypton.Toolkit.KryptonRadioButton()
        Me.radioSparklePurple = New Krypton.Toolkit.KryptonRadioButton()
        Me.radioSparkleBlue = New Krypton.Toolkit.KryptonRadioButton()
        Me.radio2007Silver = New Krypton.Toolkit.KryptonRadioButton()
        Me.kryptonManager = New Krypton.Toolkit.KryptonManager(Me.components)
        CType(Me.kryptonPanel1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.kryptonPanel1.SuspendLayout()
        Me.SuspendLayout()
        Me.radio2007Blue.Location = New System.Drawing.Point(195, 18)
        Me.radio2007Blue.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.radio2007Blue.Name = "radio2007Blue"
        Me.radio2007Blue.Size = New System.Drawing.Size(145, 24)
        Me.radio2007Blue.TabIndex = 3
        Me.radio2007Blue.Values.Text = "Office 2007 - Blue"
        Me.radioOffice2003.Location = New System.Drawing.Point(195, 124)
        Me.radioOffice2003.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.radioOffice2003.Name = "radioOffice2003"
        Me.radioOffice2003.Size = New System.Drawing.Size(101, 24)
        Me.radioOffice2003.TabIndex = 9
        Me.radioOffice2003.Values.Text = "Office 2003"
        Me.radioSystem.Location = New System.Drawing.Point(195, 155)
        Me.radioSystem.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.radioSystem.Name = "radioSystem"
        Me.radioSystem.Size = New System.Drawing.Size(72, 24)
        Me.radioSystem.TabIndex = 10
        Me.radioSystem.Values.Text = "System"
        Me.radio2007Black.Location = New System.Drawing.Point(195, 80)
        Me.radio2007Black.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.radio2007Black.Name = "radio2007Black"
        Me.radio2007Black.Size = New System.Drawing.Size(151, 24)
        Me.radio2007Black.TabIndex = 5
        Me.radio2007Black.Values.Text = "Office 2007 - Black"
        Me.kryptonPanel1.Controls.Add(Me.radio2010Black)
        Me.kryptonPanel1.Controls.Add(Me.radio2010Silver)
        Me.kryptonPanel1.Controls.Add(Me.radio2010Blue)
        Me.kryptonPanel1.Controls.Add(Me.radioSparkleOrange)
        Me.kryptonPanel1.Controls.Add(Me.radioSparklePurple)
        Me.kryptonPanel1.Controls.Add(Me.radioSparkleBlue)
        Me.kryptonPanel1.Controls.Add(Me.radio2007Black)
        Me.kryptonPanel1.Controls.Add(Me.radio2007Silver)
        Me.kryptonPanel1.Controls.Add(Me.radio2007Blue)
        Me.kryptonPanel1.Controls.Add(Me.radioOffice2003)
        Me.kryptonPanel1.Controls.Add(Me.radioSystem)
        Me.kryptonPanel1.Dock = System.Windows.Forms.DockStyle.Fill
        Me.kryptonPanel1.Location = New System.Drawing.Point(0, 0)
        Me.kryptonPanel1.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.kryptonPanel1.Name = "kryptonPanel1"
        Me.kryptonPanel1.Size = New System.Drawing.Size(412, 227)
        Me.kryptonPanel1.TabIndex = 0
        Me.radio2010Black.Location = New System.Drawing.Point(19, 80)
        Me.radio2010Black.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.radio2010Black.Name = "radio2010Black"
        Me.radio2010Black.Size = New System.Drawing.Size(151, 24)
        Me.radio2010Black.TabIndex = 2
        Me.radio2010Black.Values.Text = "Office 2010 - Black"
        Me.radio2010Silver.Location = New System.Drawing.Point(19, 49)
        Me.radio2010Silver.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.radio2010Silver.Name = "radio2010Silver"
        Me.radio2010Silver.Size = New System.Drawing.Size(153, 24)
        Me.radio2010Silver.TabIndex = 1
        Me.radio2010Silver.Values.Text = "Office 2010 - Silver"
        Me.radio2010Blue.Checked = True
        Me.radio2010Blue.Location = New System.Drawing.Point(19, 18)
        Me.radio2010Blue.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.radio2010Blue.Name = "radio2010Blue"
        Me.radio2010Blue.Size = New System.Drawing.Size(145, 24)
        Me.radio2010Blue.TabIndex = 0
        Me.radio2010Blue.Values.Text = "Office 2010 - Blue"
        Me.radioSparkleOrange.Location = New System.Drawing.Point(19, 155)
        Me.radioSparkleOrange.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.radioSparkleOrange.Name = "radioSparkleOrange"
        Me.radioSparkleOrange.Size = New System.Drawing.Size(139, 24)
        Me.radioSparkleOrange.TabIndex = 7
        Me.radioSparkleOrange.Values.Text = "Sparkle - Orange"
        Me.radioSparklePurple.Location = New System.Drawing.Point(19, 186)
        Me.radioSparklePurple.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.radioSparklePurple.Name = "radioSparklePurple"
        Me.radioSparklePurple.Size = New System.Drawing.Size(132, 24)
        Me.radioSparklePurple.TabIndex = 8
        Me.radioSparklePurple.Values.Text = "Sparkle - Purple"
        Me.radioSparkleBlue.Location = New System.Drawing.Point(19, 124)
        Me.radioSparkleBlue.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.radioSparkleBlue.Name = "radioSparkleBlue"
        Me.radioSparkleBlue.Size = New System.Drawing.Size(118, 24)
        Me.radioSparkleBlue.TabIndex = 6
        Me.radioSparkleBlue.Values.Text = "Sparkle - Blue"
        Me.radio2007Silver.Location = New System.Drawing.Point(195, 49)
        Me.radio2007Silver.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.radio2007Silver.Name = "radio2007Silver"
        Me.radio2007Silver.Size = New System.Drawing.Size(153, 24)
        Me.radio2007Silver.TabIndex = 4
        Me.radio2007Silver.Values.Text = "Office 2007 - Silver"
        Me.kryptonManager.GlobalPaletteMode = Krypton.Toolkit.PaletteMode.SparkleBlue
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8F, 16F)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(412, 227)
        Me.Controls.Add(Me.kryptonPanel1)
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.Name = "Form2"
        Me.Text = "Form2"
        CType(Me.kryptonPanel1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.kryptonPanel1.ResumeLayout(False)
        Me.kryptonPanel1.PerformLayout()
        Me.ResumeLayout(False)
    End Sub

    Friend WithEvents radio2007Blue As Krypton.Toolkit.KryptonRadioButton
    Friend WithEvents radioOffice2003 As Krypton.Toolkit.KryptonRadioButton
    Friend WithEvents radioSystem As Krypton.Toolkit.KryptonRadioButton
    Friend WithEvents radio2007Black As Krypton.Toolkit.KryptonRadioButton
    Friend WithEvents kryptonPanel1 As Krypton.Toolkit.KryptonPanel
    Friend WithEvents radio2007Silver As Krypton.Toolkit.KryptonRadioButton
    Friend WithEvents kryptonManager As Krypton.Toolkit.KryptonManager
    Friend WithEvents radioSparkleBlue As Krypton.Toolkit.KryptonRadioButton
    Friend WithEvents radioSparkleOrange As Krypton.Toolkit.KryptonRadioButton
    Friend WithEvents radioSparklePurple As Krypton.Toolkit.KryptonRadioButton
    Friend WithEvents radio2010Black As Krypton.Toolkit.KryptonRadioButton
    Friend WithEvents radio2010Silver As Krypton.Toolkit.KryptonRadioButton
    Friend WithEvents radio2010Blue As Krypton.Toolkit.KryptonRadioButton
End Class
