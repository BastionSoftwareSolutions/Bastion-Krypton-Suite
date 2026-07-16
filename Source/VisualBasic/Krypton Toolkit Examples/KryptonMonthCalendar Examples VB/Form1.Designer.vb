' VB.NET twin of Source\Krypton Toolkit Examples\KryptonMonthCalendar Examples\Form1.Designer.cs (Bastion Phase 4c).
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
        Me.buttonClose = New System.Windows.Forms.Button()
        Me.groupBox4 = New System.Windows.Forms.GroupBox()
        Me.propertyGrid = New System.Windows.Forms.PropertyGrid()
        Me.kryptonMonthCalendar1 = New Krypton.Toolkit.KryptonMonthCalendar()
        Me.kryptonManager1 = New Krypton.Toolkit.KryptonManager(Me.components)
        Me.groupBoxPalette.SuspendLayout()
        Me.groupBox4.SuspendLayout()
        Me.SuspendLayout()
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
        Me.groupBoxPalette.Location = New System.Drawing.Point(12, 426)
        Me.groupBoxPalette.Name = "groupBoxPalette"
        Me.groupBoxPalette.Size = New System.Drawing.Size(517, 107)
        Me.groupBoxPalette.TabIndex = 1
        Me.groupBoxPalette.TabStop = False
        Me.groupBoxPalette.Text = "Palette"
        Me.rbOffice2010Black.AutoSize = True
        Me.rbOffice2010Black.Location = New System.Drawing.Point(16, 74)
        Me.rbOffice2010Black.Name = "rbOffice2010Black"
        Me.rbOffice2010Black.Size = New System.Drawing.Size(115, 17)
        Me.rbOffice2010Black.TabIndex = 2
        Me.rbOffice2010Black.Text = "Office 2010 - Black"
        Me.rbOffice2010Black.UseVisualStyleBackColor = True
        Me.rbOffice2010Silver.AutoSize = True
        Me.rbOffice2010Silver.Location = New System.Drawing.Point(16, 51)
        Me.rbOffice2010Silver.Name = "rbOffice2010Silver"
        Me.rbOffice2010Silver.Size = New System.Drawing.Size(117, 17)
        Me.rbOffice2010Silver.TabIndex = 1
        Me.rbOffice2010Silver.Text = "Office 2010 - Silver"
        Me.rbOffice2010Silver.UseVisualStyleBackColor = True
        Me.rbOffice2010Blue.AutoSize = True
        Me.rbOffice2010Blue.Checked = True
        Me.rbOffice2010Blue.Location = New System.Drawing.Point(16, 28)
        Me.rbOffice2010Blue.Name = "rbOffice2010Blue"
        Me.rbOffice2010Blue.Size = New System.Drawing.Size(111, 17)
        Me.rbOffice2010Blue.TabIndex = 0
        Me.rbOffice2010Blue.TabStop = True
        Me.rbOffice2010Blue.Text = "Office 2010 - Blue"
        Me.rbOffice2010Blue.UseVisualStyleBackColor = True
        Me.rbSparklePurple.AutoSize = True
        Me.rbSparklePurple.Location = New System.Drawing.Point(295, 74)
        Me.rbSparklePurple.Name = "rbSparklePurple"
        Me.rbSparklePurple.Size = New System.Drawing.Size(100, 17)
        Me.rbSparklePurple.TabIndex = 8
        Me.rbSparklePurple.Text = "Sparkle - Purple"
        Me.rbSparklePurple.UseVisualStyleBackColor = True
        Me.rbSparkleOrange.AutoSize = True
        Me.rbSparkleOrange.Location = New System.Drawing.Point(295, 51)
        Me.rbSparkleOrange.Name = "rbSparkleOrange"
        Me.rbSparkleOrange.Size = New System.Drawing.Size(106, 17)
        Me.rbSparkleOrange.TabIndex = 7
        Me.rbSparkleOrange.Text = "Sparkle - Orange"
        Me.rbSparkleOrange.UseVisualStyleBackColor = True
        Me.rbSparkleBlue.AutoSize = True
        Me.rbSparkleBlue.Location = New System.Drawing.Point(295, 28)
        Me.rbSparkleBlue.Name = "rbSparkleBlue"
        Me.rbSparkleBlue.Size = New System.Drawing.Size(90, 17)
        Me.rbSparkleBlue.TabIndex = 6
        Me.rbSparkleBlue.Text = "Sparkle - Blue"
        Me.rbSparkleBlue.UseVisualStyleBackColor = True
        Me.rbSystem.AutoSize = True
        Me.rbSystem.Location = New System.Drawing.Point(419, 51)
        Me.rbSystem.Name = "rbSystem"
        Me.rbSystem.Size = New System.Drawing.Size(60, 17)
        Me.rbSystem.TabIndex = 10
        Me.rbSystem.Text = "System"
        Me.rbSystem.UseVisualStyleBackColor = True
        Me.rbOffice2003.AutoSize = True
        Me.rbOffice2003.Location = New System.Drawing.Point(419, 28)
        Me.rbOffice2003.Name = "rbOffice2003"
        Me.rbOffice2003.Size = New System.Drawing.Size(81, 17)
        Me.rbOffice2003.TabIndex = 9
        Me.rbOffice2003.Text = "Office 2003"
        Me.rbOffice2003.UseVisualStyleBackColor = True
        Me.rbOffice2007Black.AutoSize = True
        Me.rbOffice2007Black.Location = New System.Drawing.Point(156, 74)
        Me.rbOffice2007Black.Name = "rbOffice2007Black"
        Me.rbOffice2007Black.Size = New System.Drawing.Size(115, 17)
        Me.rbOffice2007Black.TabIndex = 5
        Me.rbOffice2007Black.Text = "Office 2007 - Black"
        Me.rbOffice2007Black.UseVisualStyleBackColor = True
        Me.rbOffice2007Silver.AutoSize = True
        Me.rbOffice2007Silver.Location = New System.Drawing.Point(156, 51)
        Me.rbOffice2007Silver.Name = "rbOffice2007Silver"
        Me.rbOffice2007Silver.Size = New System.Drawing.Size(117, 17)
        Me.rbOffice2007Silver.TabIndex = 4
        Me.rbOffice2007Silver.Text = "Office 2007 - Silver"
        Me.rbOffice2007Silver.UseVisualStyleBackColor = True
        Me.rbOffice2007Blue.AutoSize = True
        Me.rbOffice2007Blue.Location = New System.Drawing.Point(156, 28)
        Me.rbOffice2007Blue.Name = "rbOffice2007Blue"
        Me.rbOffice2007Blue.Size = New System.Drawing.Size(111, 17)
        Me.rbOffice2007Blue.TabIndex = 3
        Me.rbOffice2007Blue.Text = "Office 2007 - Blue"
        Me.rbOffice2007Blue.UseVisualStyleBackColor = True
        Me.buttonClose.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.buttonClose.DialogResult = System.Windows.Forms.DialogResult.Cancel
        Me.buttonClose.Location = New System.Drawing.Point(779, 541)
        Me.buttonClose.Name = "buttonClose"
        Me.buttonClose.Size = New System.Drawing.Size(75, 23)
        Me.buttonClose.TabIndex = 3
        Me.buttonClose.Text = "&Close"
        Me.buttonClose.UseVisualStyleBackColor = True
        Me.groupBox4.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) Or System.Windows.Forms.AnchorStyles.Left) Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.groupBox4.Controls.Add(Me.propertyGrid)
        Me.groupBox4.Location = New System.Drawing.Point(535, 12)
        Me.groupBox4.Name = "groupBox4"
        Me.groupBox4.Size = New System.Drawing.Size(319, 521)
        Me.groupBox4.TabIndex = 2
        Me.groupBox4.TabStop = False
        Me.groupBox4.Text = "Properties for KryptonMonthCalendar"
        Me.propertyGrid.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) Or System.Windows.Forms.AnchorStyles.Left) Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.propertyGrid.Location = New System.Drawing.Point(6, 19)
        Me.propertyGrid.Name = "propertyGrid"
        Me.propertyGrid.SelectedObject = Me.kryptonMonthCalendar1
        Me.propertyGrid.Size = New System.Drawing.Size(307, 496)
        Me.propertyGrid.TabIndex = 0
        Me.propertyGrid.ToolbarVisible = False
        Me.kryptonMonthCalendar1.CalendarDimensions = New System.Drawing.Size(1, 2)
        Me.kryptonMonthCalendar1.FirstDayOfWeek = System.Windows.Forms.Day.Default
        Me.kryptonMonthCalendar1.Location = New System.Drawing.Point(15, 18)
        Me.kryptonMonthCalendar1.Name = "kryptonMonthCalendar1"
        Me.kryptonMonthCalendar1.Size = New System.Drawing.Size(230, 338)
        Me.kryptonMonthCalendar1.TabIndex = 0
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6F, 13F)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(866, 574)
        Me.Controls.Add(Me.kryptonMonthCalendar1)
        Me.Controls.Add(Me.groupBoxPalette)
        Me.Controls.Add(Me.buttonClose)
        Me.Controls.Add(Me.groupBox4)
        Me.Font = New System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.MaximizeBox = False
        Me.MinimizeBox = False
        Me.MinimumSize = New System.Drawing.Size(882, 610)
        Me.Name = "Form1"
        Me.Text = "KryptonMonthCalendar Examples"
        Me.groupBoxPalette.ResumeLayout(False)
        Me.groupBoxPalette.PerformLayout()
        Me.groupBox4.ResumeLayout(False)
        Me.ResumeLayout(False)
    End Sub

    Friend WithEvents groupBoxPalette As System.Windows.Forms.GroupBox
    Friend WithEvents rbSparkleBlue As System.Windows.Forms.RadioButton
    Friend WithEvents rbSystem As System.Windows.Forms.RadioButton
    Friend WithEvents rbOffice2003 As System.Windows.Forms.RadioButton
    Friend WithEvents rbOffice2007Black As System.Windows.Forms.RadioButton
    Friend WithEvents rbOffice2007Silver As System.Windows.Forms.RadioButton
    Friend WithEvents rbOffice2007Blue As System.Windows.Forms.RadioButton
    Friend WithEvents buttonClose As System.Windows.Forms.Button
    Friend WithEvents groupBox4 As System.Windows.Forms.GroupBox
    Friend WithEvents propertyGrid As System.Windows.Forms.PropertyGrid
    Friend WithEvents rbSparklePurple As System.Windows.Forms.RadioButton
    Friend WithEvents rbSparkleOrange As System.Windows.Forms.RadioButton
    Friend WithEvents kryptonMonthCalendar1 As Krypton.Toolkit.KryptonMonthCalendar
    Friend WithEvents rbOffice2010Black As System.Windows.Forms.RadioButton
    Friend WithEvents rbOffice2010Silver As System.Windows.Forms.RadioButton
    Friend WithEvents rbOffice2010Blue As System.Windows.Forms.RadioButton
    Friend WithEvents kryptonManager1 As Krypton.Toolkit.KryptonManager
End Class
