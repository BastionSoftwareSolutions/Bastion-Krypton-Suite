' VB.NET twin of Source\Krypton Toolkit Examples\KryptonDateTimePicker Examples\Form1.Designer.cs (Bastion Phase 4c).

<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class Form1
    Inherits System.Windows.Forms.Form

    ''' <summary>
    '''  Required designer variable.
    ''' </summary>
    Private components As System.ComponentModel.IContainer

    ''' <summary>
    '''  Clean up any resources being used.
    ''' </summary>
    ''' <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
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

#Region "Windows Form Designer generated code"

    ''' <summary>
    '''  Required method for Designer support - do not modify
    '''  the contents of this method with the code editor.
    ''' </summary>
    <System.Diagnostics.DebuggerStepThrough()>
    Private Sub InitializeComponent()

        Me.components = New System.ComponentModel.Container()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(Form1))
        Me.groupBoxPalette = New System.Windows.Forms.GroupBox()
        Me.rbOffice2010Black = New System.Windows.Forms.RadioButton()
        Me.rbOffice2010Silver = New System.Windows.Forms.RadioButton()
        Me.rbOffice2010Blue = New System.Windows.Forms.RadioButton()
        Me.rbSparklePurple = New System.Windows.Forms.RadioButton()
        Me.rbSparkleOrange = New System.Windows.Forms.RadioButton()
        Me.rbSparkleBlue = New System.Windows.Forms.RadioButton()
        Me.rbSystem = New System.Windows.Forms.RadioButton()
        Me.rbOffice2003 = New System.Windows.Forms.RadioButton()
        Me.rbOffice2007Black = New System.Windows.Forms.RadioButton()
        Me.rbOffice2007Silver = New System.Windows.Forms.RadioButton()
        Me.rbOffice2007Blue = New System.Windows.Forms.RadioButton()
        Me.groupBox4 = New System.Windows.Forms.GroupBox()
        Me.propertyGrid = New System.Windows.Forms.PropertyGrid()
        Me.buttonClose = New System.Windows.Forms.Button()
        Me.groupBoxRibbon = New System.Windows.Forms.GroupBox()
        Me.groupBoxNormal = New System.Windows.Forms.GroupBox()
        Me.dtpRibbonTime = New Krypton.Toolkit.KryptonDateTimePicker()
        Me.buttonSpecAny2 = New Krypton.Toolkit.ButtonSpecAny()
        Me.kryptonPalette = New Krypton.Toolkit.KryptonCustomPaletteBase(Me.components)
        Me.dtpRibbonShort = New Krypton.Toolkit.KryptonDateTimePicker()
        Me.dtpRibbonLong = New Krypton.Toolkit.KryptonDateTimePicker()
        Me.dtpNormalTime = New Krypton.Toolkit.KryptonDateTimePicker()
        Me.buttonSpecAny1 = New Krypton.Toolkit.ButtonSpecAny()
        Me.dtpNormalShort = New Krypton.Toolkit.KryptonDateTimePicker()
        Me.dtpNormalLong = New Krypton.Toolkit.KryptonDateTimePicker()
        Me.groupBoxPalette.SuspendLayout()
        Me.groupBox4.SuspendLayout()
        Me.groupBoxRibbon.SuspendLayout()
        Me.groupBoxNormal.SuspendLayout()
        Me.SuspendLayout()
        '
        ' groupBoxPalette
        '
        Me.groupBoxPalette.Controls.Add(Me.rbOffice2010Black)
        Me.groupBoxPalette.Controls.Add(Me.rbOffice2010Silver)
        Me.groupBoxPalette.Controls.Add(Me.rbOffice2010Blue)
        Me.groupBoxPalette.Controls.Add(Me.rbSparklePurple)
        Me.groupBoxPalette.Controls.Add(Me.rbSparkleOrange)
        Me.groupBoxPalette.Controls.Add(Me.rbSparkleBlue)
        Me.groupBoxPalette.Controls.Add(Me.rbSystem)
        Me.groupBoxPalette.Controls.Add(Me.rbOffice2003)
        Me.groupBoxPalette.Controls.Add(Me.rbOffice2007Black)
        Me.groupBoxPalette.Controls.Add(Me.rbOffice2007Silver)
        Me.groupBoxPalette.Controls.Add(Me.rbOffice2007Blue)
        Me.groupBoxPalette.Location = New System.Drawing.Point(12, 309)
        Me.groupBoxPalette.Name = "groupBoxPalette"
        Me.groupBoxPalette.Size = New System.Drawing.Size(382, 181)
        Me.groupBoxPalette.TabIndex = 3
        Me.groupBoxPalette.TabStop = False
        Me.groupBoxPalette.Text = "Palette"
        '
        ' rbOffice2010Black
        '
        Me.rbOffice2010Black.AutoSize = True
        Me.rbOffice2010Black.Location = New System.Drawing.Point(24, 72)
        Me.rbOffice2010Black.Name = "rbOffice2010Black"
        Me.rbOffice2010Black.Size = New System.Drawing.Size(143, 21)
        Me.rbOffice2010Black.TabIndex = 2
        Me.rbOffice2010Black.Text = "Office 2010 - Black"
        Me.rbOffice2010Black.UseVisualStyleBackColor = True
        '
        ' rbOffice2010Silver
        '
        Me.rbOffice2010Silver.AutoSize = True
        Me.rbOffice2010Silver.Location = New System.Drawing.Point(24, 49)
        Me.rbOffice2010Silver.Name = "rbOffice2010Silver"
        Me.rbOffice2010Silver.Size = New System.Drawing.Size(144, 21)
        Me.rbOffice2010Silver.TabIndex = 1
        Me.rbOffice2010Silver.Text = "Office 2010 - Silver"
        Me.rbOffice2010Silver.UseVisualStyleBackColor = True
        '
        ' rbOffice2010Blue
        '
        Me.rbOffice2010Blue.AutoSize = True
        Me.rbOffice2010Blue.Checked = True
        Me.rbOffice2010Blue.Location = New System.Drawing.Point(24, 26)
        Me.rbOffice2010Blue.Name = "rbOffice2010Blue"
        Me.rbOffice2010Blue.Size = New System.Drawing.Size(137, 21)
        Me.rbOffice2010Blue.TabIndex = 0
        Me.rbOffice2010Blue.TabStop = True
        Me.rbOffice2010Blue.Text = "Office 2010 - Blue"
        Me.rbOffice2010Blue.UseVisualStyleBackColor = True
        '
        ' rbSparklePurple
        '
        Me.rbSparklePurple.AutoSize = True
        Me.rbSparklePurple.Location = New System.Drawing.Point(163, 72)
        Me.rbSparklePurple.Name = "rbSparklePurple"
        Me.rbSparklePurple.Size = New System.Drawing.Size(124, 21)
        Me.rbSparklePurple.TabIndex = 8
        Me.rbSparklePurple.Text = "Sparkle - Purple"
        Me.rbSparklePurple.UseVisualStyleBackColor = True
        '
        ' rbSparkleOrange
        '
        Me.rbSparkleOrange.AutoSize = True
        Me.rbSparkleOrange.Location = New System.Drawing.Point(163, 49)
        Me.rbSparkleOrange.Name = "rbSparkleOrange"
        Me.rbSparkleOrange.Size = New System.Drawing.Size(131, 21)
        Me.rbSparkleOrange.TabIndex = 7
        Me.rbSparkleOrange.Text = "Sparkle - Orange"
        Me.rbSparkleOrange.UseVisualStyleBackColor = True
        '
        ' rbSparkleBlue
        '
        Me.rbSparkleBlue.AutoSize = True
        Me.rbSparkleBlue.Location = New System.Drawing.Point(163, 26)
        Me.rbSparkleBlue.Name = "rbSparkleBlue"
        Me.rbSparkleBlue.Size = New System.Drawing.Size(111, 21)
        Me.rbSparkleBlue.TabIndex = 6
        Me.rbSparkleBlue.Text = "Sparkle - Blue"
        Me.rbSparkleBlue.UseVisualStyleBackColor = True
        '
        ' rbSystem
        '
        Me.rbSystem.AutoSize = True
        Me.rbSystem.Location = New System.Drawing.Point(163, 127)
        Me.rbSystem.Name = "rbSystem"
        Me.rbSystem.Size = New System.Drawing.Size(75, 21)
        Me.rbSystem.TabIndex = 10
        Me.rbSystem.Text = "System"
        Me.rbSystem.UseVisualStyleBackColor = True
        '
        ' rbOffice2003
        '
        Me.rbOffice2003.AutoSize = True
        Me.rbOffice2003.Location = New System.Drawing.Point(163, 104)
        Me.rbOffice2003.Name = "rbOffice2003"
        Me.rbOffice2003.Size = New System.Drawing.Size(99, 21)
        Me.rbOffice2003.TabIndex = 9
        Me.rbOffice2003.Text = "Office 2003"
        Me.rbOffice2003.UseVisualStyleBackColor = True
        '
        ' rbOffice2007Black
        '
        Me.rbOffice2007Black.AutoSize = True
        Me.rbOffice2007Black.Location = New System.Drawing.Point(24, 150)
        Me.rbOffice2007Black.Name = "rbOffice2007Black"
        Me.rbOffice2007Black.Size = New System.Drawing.Size(143, 21)
        Me.rbOffice2007Black.TabIndex = 5
        Me.rbOffice2007Black.Text = "Office 2007 - Black"
        Me.rbOffice2007Black.UseVisualStyleBackColor = True
        '
        ' rbOffice2007Silver
        '
        Me.rbOffice2007Silver.AutoSize = True
        Me.rbOffice2007Silver.Location = New System.Drawing.Point(24, 127)
        Me.rbOffice2007Silver.Name = "rbOffice2007Silver"
        Me.rbOffice2007Silver.Size = New System.Drawing.Size(144, 21)
        Me.rbOffice2007Silver.TabIndex = 4
        Me.rbOffice2007Silver.Text = "Office 2007 - Silver"
        Me.rbOffice2007Silver.UseVisualStyleBackColor = True
        '
        ' rbOffice2007Blue
        '
        Me.rbOffice2007Blue.AutoSize = True
        Me.rbOffice2007Blue.Location = New System.Drawing.Point(24, 104)
        Me.rbOffice2007Blue.Name = "rbOffice2007Blue"
        Me.rbOffice2007Blue.Size = New System.Drawing.Size(137, 21)
        Me.rbOffice2007Blue.TabIndex = 3
        Me.rbOffice2007Blue.Text = "Office 2007 - Blue"
        Me.rbOffice2007Blue.UseVisualStyleBackColor = True
        '
        ' groupBox4
        '
        Me.groupBox4.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) Or System.Windows.Forms.AnchorStyles.Left) Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.groupBox4.Controls.Add(Me.propertyGrid)
        Me.groupBox4.Location = New System.Drawing.Point(400, 12)
        Me.groupBox4.Name = "groupBox4"
        Me.groupBox4.Size = New System.Drawing.Size(319, 478)
        Me.groupBox4.TabIndex = 4
        Me.groupBox4.TabStop = False
        Me.groupBox4.Text = "Properties for KryptonDateTimePicker"
        '
        ' propertyGrid
        '
        Me.propertyGrid.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) Or System.Windows.Forms.AnchorStyles.Left) Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.propertyGrid.Location = New System.Drawing.Point(6, 19)
        Me.propertyGrid.Name = "propertyGrid"
        Me.propertyGrid.Size = New System.Drawing.Size(307, 453)
        Me.propertyGrid.TabIndex = 0
        Me.propertyGrid.ToolbarVisible = False
        '
        ' buttonClose
        '
        Me.buttonClose.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.buttonClose.DialogResult = System.Windows.Forms.DialogResult.Cancel
        Me.buttonClose.Location = New System.Drawing.Point(644, 500)
        Me.buttonClose.Name = "buttonClose"
        Me.buttonClose.Size = New System.Drawing.Size(75, 23)
        Me.buttonClose.TabIndex = 5
        Me.buttonClose.Text = "&Close"
        Me.buttonClose.UseVisualStyleBackColor = True
        '
        ' groupBoxRibbon
        '
        Me.groupBoxRibbon.Controls.Add(Me.dtpRibbonTime)
        Me.groupBoxRibbon.Controls.Add(Me.dtpRibbonShort)
        Me.groupBoxRibbon.Controls.Add(Me.dtpRibbonLong)
        Me.groupBoxRibbon.Location = New System.Drawing.Point(12, 162)
        Me.groupBoxRibbon.Name = "groupBoxRibbon"
        Me.groupBoxRibbon.Size = New System.Drawing.Size(382, 140)
        Me.groupBoxRibbon.TabIndex = 1
        Me.groupBoxRibbon.TabStop = False
        Me.groupBoxRibbon.Text = "Ribbon Style"
        '
        ' groupBoxNormal
        '
        Me.groupBoxNormal.Controls.Add(Me.dtpNormalTime)
        Me.groupBoxNormal.Controls.Add(Me.dtpNormalShort)
        Me.groupBoxNormal.Controls.Add(Me.dtpNormalLong)
        Me.groupBoxNormal.Location = New System.Drawing.Point(12, 12)
        Me.groupBoxNormal.Name = "groupBoxNormal"
        Me.groupBoxNormal.Size = New System.Drawing.Size(382, 140)
        Me.groupBoxNormal.TabIndex = 0
        Me.groupBoxNormal.TabStop = False
        Me.groupBoxNormal.Text = "Normal Style"
        '
        ' dtpRibbonTime
        '
        Me.dtpRibbonTime.AlwaysActive = False
        Me.dtpRibbonTime.ButtonSpecs.AddRange(New Krypton.Toolkit.ButtonSpecAny() { Me.buttonSpecAny2})
        Me.dtpRibbonTime.Format = System.Windows.Forms.DateTimePickerFormat.Time
        Me.dtpRibbonTime.InputControlStyle = Krypton.Toolkit.InputControlStyle.Ribbon
        Me.dtpRibbonTime.Location = New System.Drawing.Point(24, 92)
        Me.dtpRibbonTime.Name = "dtpRibbonTime"
        Me.dtpRibbonTime.LocalCustomPalette = Me.kryptonPalette
        Me.dtpRibbonTime.PaletteMode = Krypton.Toolkit.PaletteMode.Custom
        Me.dtpRibbonTime.ShowUpDown = True
        Me.dtpRibbonTime.Size = New System.Drawing.Size(204, 25)
        Me.dtpRibbonTime.TabIndex = 2
        '
        ' buttonSpecAny2
        '
        Me.buttonSpecAny2.Style = Krypton.Toolkit.PaletteButtonStyle.Standalone
        Me.buttonSpecAny2.ToolTipStyle = Krypton.Toolkit.LabelStyle.ToolTip
        Me.buttonSpecAny2.Type = Krypton.Toolkit.PaletteButtonSpecStyle.Close
        Me.buttonSpecAny2.UniqueName = "711F5E5D57D243B7711F5E5D57D243B7"
        '
        ' kryptonPalette
        '
        Me.kryptonPalette.BasePaletteType = Krypton.Toolkit.BasePaletteType.Microsoft365
        '
        ' dtpRibbonShort
        '
        Me.dtpRibbonShort.AlwaysActive = False
        Me.dtpRibbonShort.Format = System.Windows.Forms.DateTimePickerFormat.Short
        Me.dtpRibbonShort.InputControlStyle = Krypton.Toolkit.InputControlStyle.Ribbon
        Me.dtpRibbonShort.Location = New System.Drawing.Point(24, 63)
        Me.dtpRibbonShort.Name = "dtpRibbonShort"
        Me.dtpRibbonShort.LocalCustomPalette = Me.kryptonPalette
        Me.dtpRibbonShort.PaletteMode = Krypton.Toolkit.PaletteMode.Custom
        Me.dtpRibbonShort.Size = New System.Drawing.Size(204, 25)
        Me.dtpRibbonShort.TabIndex = 1
        '
        ' dtpRibbonLong
        '
        Me.dtpRibbonLong.AlwaysActive = False
        Me.dtpRibbonLong.CustomNullText = "<Custom Text When Null>"
        Me.dtpRibbonLong.InputControlStyle = Krypton.Toolkit.InputControlStyle.Ribbon
        Me.dtpRibbonLong.Location = New System.Drawing.Point(24, 34)
        Me.dtpRibbonLong.Name = "dtpRibbonLong"
        Me.dtpRibbonLong.LocalCustomPalette = Me.kryptonPalette
        Me.dtpRibbonLong.PaletteMode = Krypton.Toolkit.PaletteMode.Custom
        Me.dtpRibbonLong.ShowCheckBox = True
        Me.dtpRibbonLong.Size = New System.Drawing.Size(204, 25)
        Me.dtpRibbonLong.TabIndex = 0
        '
        ' dtpNormalTime
        '
        Me.dtpNormalTime.ButtonSpecs.AddRange(New Krypton.Toolkit.ButtonSpecAny() { Me.buttonSpecAny1})
        Me.dtpNormalTime.Format = System.Windows.Forms.DateTimePickerFormat.Time
        Me.dtpNormalTime.Location = New System.Drawing.Point(24, 93)
        Me.dtpNormalTime.Name = "dtpNormalTime"
        Me.dtpNormalTime.LocalCustomPalette = Me.kryptonPalette
        Me.dtpNormalTime.PaletteMode = Krypton.Toolkit.PaletteMode.Custom
        Me.dtpNormalTime.ShowUpDown = True
        Me.dtpNormalTime.Size = New System.Drawing.Size(204, 25)
        Me.dtpNormalTime.TabIndex = 2
        '
        ' buttonSpecAny1
        '
        Me.buttonSpecAny1.Style = Krypton.Toolkit.PaletteButtonStyle.Standalone
        Me.buttonSpecAny1.ToolTipStyle = Krypton.Toolkit.LabelStyle.ToolTip
        Me.buttonSpecAny1.Type = Krypton.Toolkit.PaletteButtonSpecStyle.Close
        Me.buttonSpecAny1.UniqueName = "529C8C7BCFA94ED8529C8C7BCFA94ED8"
        '
        ' dtpNormalShort
        '
        Me.dtpNormalShort.Format = System.Windows.Forms.DateTimePickerFormat.Short
        Me.dtpNormalShort.Location = New System.Drawing.Point(24, 64)
        Me.dtpNormalShort.Name = "dtpNormalShort"
        Me.dtpNormalShort.LocalCustomPalette = Me.kryptonPalette
        Me.dtpNormalShort.PaletteMode = Krypton.Toolkit.PaletteMode.Custom
        Me.dtpNormalShort.Size = New System.Drawing.Size(204, 25)
        Me.dtpNormalShort.TabIndex = 1
        '
        ' dtpNormalLong
        '
        Me.dtpNormalLong.CustomNullText = "<Custom Text When Null>"
        Me.dtpNormalLong.Location = New System.Drawing.Point(24, 35)
        Me.dtpNormalLong.Name = "dtpNormalLong"
        Me.dtpNormalLong.LocalCustomPalette = Me.kryptonPalette
        Me.dtpNormalLong.PaletteMode = Krypton.Toolkit.PaletteMode.Custom
        Me.dtpNormalLong.ShowCheckBox = True
        Me.dtpNormalLong.Size = New System.Drawing.Size(204, 25)
        Me.dtpNormalLong.TabIndex = 0
        '
        ' Form1
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 17.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(729, 535)
        Me.Controls.Add(Me.groupBoxRibbon)
        Me.Controls.Add(Me.groupBoxNormal)
        Me.Controls.Add(Me.buttonClose)
        Me.Controls.Add(Me.groupBox4)
        Me.Controls.Add(Me.groupBoxPalette)
        Me.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.MaximumSize = New System.Drawing.Size(800, 700)
        Me.MinimumSize = New System.Drawing.Size(745, 573)
        Me.Name = "Form1"
        Me.Text = "KryptonDateTimePicker Examples"
        Me.groupBoxPalette.ResumeLayout(False)
        Me.groupBoxPalette.PerformLayout()
        Me.groupBox4.ResumeLayout(False)
        Me.groupBoxRibbon.ResumeLayout(False)
        Me.groupBoxNormal.ResumeLayout(False)
        Me.ResumeLayout(False)

    End Sub

#End Region

    Private WithEvents groupBoxPalette As System.Windows.Forms.GroupBox
    Private WithEvents rbSparklePurple As System.Windows.Forms.RadioButton
    Private WithEvents rbSparkleOrange As System.Windows.Forms.RadioButton
    Private WithEvents rbSparkleBlue As System.Windows.Forms.RadioButton
    Private WithEvents rbSystem As System.Windows.Forms.RadioButton
    Private WithEvents rbOffice2003 As System.Windows.Forms.RadioButton
    Private WithEvents rbOffice2007Black As System.Windows.Forms.RadioButton
    Private WithEvents rbOffice2007Silver As System.Windows.Forms.RadioButton
    Private WithEvents rbOffice2007Blue As System.Windows.Forms.RadioButton
    Private WithEvents groupBox4 As System.Windows.Forms.GroupBox
    Private WithEvents propertyGrid As System.Windows.Forms.PropertyGrid
    Private WithEvents buttonClose As System.Windows.Forms.Button
    Private WithEvents kryptonPalette As Krypton.Toolkit.KryptonCustomPaletteBase
    Private WithEvents groupBoxRibbon As System.Windows.Forms.GroupBox
    Private WithEvents groupBoxNormal As System.Windows.Forms.GroupBox
    Private WithEvents dtpRibbonTime As Krypton.Toolkit.KryptonDateTimePicker
    Private WithEvents dtpRibbonShort As Krypton.Toolkit.KryptonDateTimePicker
    Private WithEvents dtpRibbonLong As Krypton.Toolkit.KryptonDateTimePicker
    Private WithEvents dtpNormalTime As Krypton.Toolkit.KryptonDateTimePicker
    Private WithEvents dtpNormalShort As Krypton.Toolkit.KryptonDateTimePicker
    Private WithEvents dtpNormalLong As Krypton.Toolkit.KryptonDateTimePicker
    Private WithEvents buttonSpecAny2 As Krypton.Toolkit.ButtonSpecAny
    Private WithEvents buttonSpecAny1 As Krypton.Toolkit.ButtonSpecAny
    Private WithEvents rbOffice2010Black As System.Windows.Forms.RadioButton
    Private WithEvents rbOffice2010Silver As System.Windows.Forms.RadioButton
    Private WithEvents rbOffice2010Blue As System.Windows.Forms.RadioButton

End Class
