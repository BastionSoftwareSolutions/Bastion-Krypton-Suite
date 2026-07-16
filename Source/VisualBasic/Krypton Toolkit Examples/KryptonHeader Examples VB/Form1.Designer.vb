' VB.NET twin of Source\Krypton Toolkit Examples\KryptonHeader Examples\Form1.Designer.cs (Bastion Phase 4c).

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

        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(Form1))
        Me.groupBox4 = New System.Windows.Forms.GroupBox()
        Me.propertyGrid = New System.Windows.Forms.PropertyGrid()
        Me.buttonClose = New System.Windows.Forms.Button()
        Me.groupBox1 = New System.Windows.Forms.GroupBox()
        Me.office6 = New Krypton.Toolkit.KryptonHeader()
        Me.buttonSpecUp = New Krypton.Toolkit.ButtonSpecAny()
        Me.buttonSpecDown = New Krypton.Toolkit.ButtonSpecAny()
        Me.office5 = New Krypton.Toolkit.KryptonHeader()
        Me.office4 = New Krypton.Toolkit.KryptonHeader()
        Me.office2 = New Krypton.Toolkit.KryptonHeader()
        Me.office1 = New Krypton.Toolkit.KryptonHeader()
        Me.office3 = New Krypton.Toolkit.KryptonHeader()
        Me.groupBox2 = New System.Windows.Forms.GroupBox()
        Me.blue6 = New Krypton.Toolkit.KryptonHeader()
        Me.blue5 = New Krypton.Toolkit.KryptonHeader()
        Me.blue4 = New Krypton.Toolkit.KryptonHeader()
        Me.blue2 = New Krypton.Toolkit.KryptonHeader()
        Me.blue1 = New Krypton.Toolkit.KryptonHeader()
        Me.blue3 = New Krypton.Toolkit.KryptonHeader()
        Me.groupBox3 = New System.Windows.Forms.GroupBox()
        Me.custom3 = New Krypton.Toolkit.KryptonHeader()
        Me.custom1 = New Krypton.Toolkit.KryptonHeader()
        Me.custom2 = New Krypton.Toolkit.KryptonHeader()
        Me.groupBox4.SuspendLayout()
        Me.groupBox1.SuspendLayout()
        Me.groupBox2.SuspendLayout()
        Me.groupBox3.SuspendLayout()
        Me.SuspendLayout()
        '
        ' groupBox4
        '
        Me.groupBox4.Controls.Add(Me.propertyGrid)
        Me.groupBox4.Location = New System.Drawing.Point(306, 12)
        Me.groupBox4.Name = "groupBox4"
        Me.groupBox4.Size = New System.Drawing.Size(322, 616)
        Me.groupBox4.TabIndex = 3
        Me.groupBox4.TabStop = False
        Me.groupBox4.Text = "Properties for Selected KryptonHeader"
        '
        ' propertyGrid
        '
        Me.propertyGrid.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) Or System.Windows.Forms.AnchorStyles.Left) Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.propertyGrid.Location = New System.Drawing.Point(6, 19)
        Me.propertyGrid.Name = "propertyGrid"
        Me.propertyGrid.Size = New System.Drawing.Size(310, 591)
        Me.propertyGrid.TabIndex = 0
        Me.propertyGrid.ToolbarVisible = False
        '
        ' buttonClose
        '
        Me.buttonClose.DialogResult = System.Windows.Forms.DialogResult.Cancel
        Me.buttonClose.Location = New System.Drawing.Point(553, 634)
        Me.buttonClose.Name = "buttonClose"
        Me.buttonClose.Size = New System.Drawing.Size(75, 23)
        Me.buttonClose.TabIndex = 4
        Me.buttonClose.Text = "&Close"
        Me.buttonClose.UseVisualStyleBackColor = True
        '
        ' groupBox1
        '
        Me.groupBox1.Controls.Add(Me.office6)
        Me.groupBox1.Controls.Add(Me.office5)
        Me.groupBox1.Controls.Add(Me.office4)
        Me.groupBox1.Controls.Add(Me.office2)
        Me.groupBox1.Controls.Add(Me.office1)
        Me.groupBox1.Controls.Add(Me.office3)
        Me.groupBox1.Location = New System.Drawing.Point(6, 12)
        Me.groupBox1.Name = "groupBox1"
        Me.groupBox1.Size = New System.Drawing.Size(294, 214)
        Me.groupBox1.TabIndex = 0
        Me.groupBox1.TabStop = False
        Me.groupBox1.Text = "Sparkle - Blue"
        '
        ' office6
        '
        Me.office6.AllowButtonSpecToolTips = True
        Me.office6.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowOnly
        Me.office6.ButtonSpecs.Add(Me.buttonSpecUp)
        Me.office6.ButtonSpecs.Add(Me.buttonSpecDown)
        Me.office6.HeaderStyle = Krypton.Toolkit.HeaderStyle.Secondary
        Me.office6.Location = New System.Drawing.Point(98, 155)
        Me.office6.Name = "office6"
        Me.office6.PaletteMode = Krypton.Toolkit.PaletteMode.SparkleBlue
        Me.office6.Size = New System.Drawing.Size(176, 34)
        Me.office6.TabIndex = 5
        Me.office6.Values.Description = ""
        Me.office6.Values.Heading = "Sort"
        Me.office6.Values.Image = Nothing
        '
        ' buttonSpecUp
        '
        Me.buttonSpecUp.Checked = Krypton.Toolkit.ButtonCheckState.Checked
        Me.buttonSpecUp.ToolTipTitle = "Sort in Descending Order"
        Me.buttonSpecUp.UniqueName = "406C13856FEF4CA3406C13856FEF4CA3"
        '
        ' buttonSpecDown
        '
        Me.buttonSpecDown.Checked = Krypton.Toolkit.ButtonCheckState.Unchecked
        Me.buttonSpecDown.ToolTipTitle = "Sort in Ascending Order"
        Me.buttonSpecDown.UniqueName = "BE9A34366DE6465CBE9A34366DE6465C"
        '
        ' office5
        '
        Me.office5.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowOnly
        Me.office5.Location = New System.Drawing.Point(98, 121)
        Me.office5.Name = "office5"
        Me.office5.PaletteMode = Krypton.Toolkit.PaletteMode.SparkleBlue
        Me.office5.Size = New System.Drawing.Size(176, 39)
        Me.office5.TabIndex = 4
        Me.office5.Values.Description = ""
        Me.office5.Values.Heading = "Buttons"
        Me.office5.Values.Image = Nothing
        '
        ' office4
        '
        Me.office4.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowOnly
        Me.office4.HeaderStyle = Krypton.Toolkit.HeaderStyle.Secondary
        Me.office4.Location = New System.Drawing.Point(98, 57)
        Me.office4.Name = "office4"
        Me.office4.PaletteMode = Krypton.Toolkit.PaletteMode.SparkleBlue
        Me.office4.Size = New System.Drawing.Size(176, 28)
        Me.office4.StateCommon.Content.Image.ImageH = Krypton.Toolkit.PaletteRelativeAlign.Far
        Me.office4.TabIndex = 3
        Me.office4.Values.Description = ""
        Me.office4.Values.Heading = "Secondary"
        '
        ' office2
        '
        Me.office2.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowOnly
        Me.office2.Location = New System.Drawing.Point(50, 23)
        Me.office2.Name = "office2"
        Me.office2.Orientation = Krypton.Toolkit.VisualOrientation.Right
        Me.office2.PaletteMode = Krypton.Toolkit.PaletteMode.SparkleBlue
        Me.office2.Size = New System.Drawing.Size(39, 206)
        Me.office2.TabIndex = 1
        Me.office2.Values.Description = "Right"
        Me.office2.Values.Heading = "Orientation"
        '
        ' office1
        '
        Me.office1.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowOnly
        Me.office1.Location = New System.Drawing.Point(16, 23)
        Me.office1.Name = "office1"
        Me.office1.Orientation = Krypton.Toolkit.VisualOrientation.Left
        Me.office1.PaletteMode = Krypton.Toolkit.PaletteMode.SparkleBlue
        Me.office1.Size = New System.Drawing.Size(39, 194)
        Me.office1.TabIndex = 0
        Me.office1.Values.Description = "Left"
        Me.office1.Values.Heading = "Orientation"
        '
        ' office3
        '
        Me.office3.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowOnly
        Me.office3.Location = New System.Drawing.Point(98, 23)
        Me.office3.Name = "office3"
        Me.office3.PaletteMode = Krypton.Toolkit.PaletteMode.SparkleBlue
        Me.office3.Size = New System.Drawing.Size(176, 39)
        Me.office3.StateCommon.Content.Image.ImageH = Krypton.Toolkit.PaletteRelativeAlign.Far
        Me.office3.TabIndex = 2
        Me.office3.Values.Description = ""
        Me.office3.Values.Heading = "Primary"
        '
        ' groupBox2
        '
        Me.groupBox2.Controls.Add(Me.blue6)
        Me.groupBox2.Controls.Add(Me.blue5)
        Me.groupBox2.Controls.Add(Me.blue4)
        Me.groupBox2.Controls.Add(Me.blue2)
        Me.groupBox2.Controls.Add(Me.blue1)
        Me.groupBox2.Controls.Add(Me.blue3)
        Me.groupBox2.Location = New System.Drawing.Point(6, 232)
        Me.groupBox2.Name = "groupBox2"
        Me.groupBox2.Size = New System.Drawing.Size(294, 219)
        Me.groupBox2.TabIndex = 0
        Me.groupBox2.TabStop = False
        Me.groupBox2.Text = "Office 2010 - Blue"
        '
        ' blue6
        '
        Me.blue6.AllowButtonSpecToolTips = True
        Me.blue6.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowOnly
        Me.blue6.ButtonSpecs.Add(Me.buttonSpecUp)
        Me.blue6.ButtonSpecs.Add(Me.buttonSpecDown)
        Me.blue6.HeaderStyle = Krypton.Toolkit.HeaderStyle.Secondary
        Me.blue6.Location = New System.Drawing.Point(98, 155)
        Me.blue6.Name = "blue6"
        Me.blue6.PaletteMode = Krypton.Toolkit.PaletteMode.Office2010Blue
        Me.blue6.Size = New System.Drawing.Size(176, 36)
        Me.blue6.TabIndex = 5
        Me.blue6.Values.Description = ""
        Me.blue6.Values.Heading = "Sort"
        Me.blue6.Values.Image = Nothing
        '
        ' blue5
        '
        Me.blue5.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowOnly
        Me.blue5.Location = New System.Drawing.Point(98, 117)
        Me.blue5.Name = "blue5"
        Me.blue5.PaletteMode = Krypton.Toolkit.PaletteMode.Office2010Blue
        Me.blue5.Size = New System.Drawing.Size(176, 37)
        Me.blue5.TabIndex = 4
        Me.blue5.Values.Description = ""
        Me.blue5.Values.Heading = "Buttons"
        Me.blue5.Values.Image = Nothing
        '
        ' blue4
        '
        Me.blue4.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowOnly
        Me.blue4.HeaderStyle = Krypton.Toolkit.HeaderStyle.Secondary
        Me.blue4.Location = New System.Drawing.Point(98, 61)
        Me.blue4.Name = "blue4"
        Me.blue4.PaletteMode = Krypton.Toolkit.PaletteMode.Office2010Blue
        Me.blue4.Size = New System.Drawing.Size(176, 26)
        Me.blue4.StateCommon.Content.Image.ImageH = Krypton.Toolkit.PaletteRelativeAlign.Far
        Me.blue4.TabIndex = 3
        Me.blue4.Values.Description = ""
        Me.blue4.Values.Heading = "Secondary"
        '
        ' blue2
        '
        Me.blue2.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowOnly
        Me.blue2.Location = New System.Drawing.Point(53, 23)
        Me.blue2.Name = "blue2"
        Me.blue2.Orientation = Krypton.Toolkit.VisualOrientation.Right
        Me.blue2.PaletteMode = Krypton.Toolkit.PaletteMode.Office2010Blue
        Me.blue2.Size = New System.Drawing.Size(37, 205)
        Me.blue2.TabIndex = 1
        Me.blue2.Values.Description = "Right"
        Me.blue2.Values.Heading = "Orientation"
        '
        ' blue1
        '
        Me.blue1.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowOnly
        Me.blue1.Location = New System.Drawing.Point(16, 23)
        Me.blue1.Name = "blue1"
        Me.blue1.Orientation = Krypton.Toolkit.VisualOrientation.Left
        Me.blue1.PaletteMode = Krypton.Toolkit.PaletteMode.Office2010Blue
        Me.blue1.Size = New System.Drawing.Size(37, 193)
        Me.blue1.TabIndex = 0
        Me.blue1.Values.Description = "Left"
        Me.blue1.Values.Heading = "Orientation"
        '
        ' blue3
        '
        Me.blue3.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowOnly
        Me.blue3.Location = New System.Drawing.Point(98, 23)
        Me.blue3.Name = "blue3"
        Me.blue3.PaletteMode = Krypton.Toolkit.PaletteMode.Office2010Blue
        Me.blue3.Size = New System.Drawing.Size(176, 37)
        Me.blue3.StateCommon.Content.Image.ImageH = Krypton.Toolkit.PaletteRelativeAlign.Far
        Me.blue3.TabIndex = 2
        Me.blue3.Values.Description = ""
        Me.blue3.Values.Heading = "Primary"
        '
        ' groupBox3
        '
        Me.groupBox3.Controls.Add(Me.custom3)
        Me.groupBox3.Controls.Add(Me.custom1)
        Me.groupBox3.Controls.Add(Me.custom2)
        Me.groupBox3.Location = New System.Drawing.Point(6, 457)
        Me.groupBox3.Name = "groupBox3"
        Me.groupBox3.Size = New System.Drawing.Size(294, 171)
        Me.groupBox3.TabIndex = 2
        Me.groupBox3.TabStop = False
        Me.groupBox3.Text = "Custom Settings"
        '
        ' custom3
        '
        Me.custom3.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowOnly
        Me.custom3.Location = New System.Drawing.Point(16, 114)
        Me.custom3.Name = "custom3"
        Me.custom3.PaletteMode = Krypton.Toolkit.PaletteMode.ProfessionalOffice2003
        Me.custom3.Size = New System.Drawing.Size(258, 43)
        Me.custom3.StateCommon.Back.ColorStyle = Krypton.Toolkit.PaletteColorStyle.HalfCut
        Me.custom3.StateCommon.Border.ColorStyle = Krypton.Toolkit.PaletteColorStyle.HalfCut
        Me.custom3.StateCommon.Border.DrawBorders = CType((((Krypton.Toolkit.PaletteDrawBorders.Top Or Krypton.Toolkit.PaletteDrawBorders.Bottom) Or Krypton.Toolkit.PaletteDrawBorders.Left) Or Krypton.Toolkit.PaletteDrawBorders.Right), Krypton.Toolkit.PaletteDrawBorders)
        Me.custom3.StateCommon.Border.GraphicsHint = Krypton.Toolkit.PaletteGraphicsHint.AntiAlias
        Me.custom3.StateCommon.Border.Rounding = 2.0!
        Me.custom3.StateCommon.Border.Width = 2
        Me.custom3.StateCommon.Content.Image.ImageH = Krypton.Toolkit.PaletteRelativeAlign.Far
        Me.custom3.TabIndex = 2
        Me.custom3.Values.Description = ""
        Me.custom3.Values.Heading = "Primary"
        '
        ' custom1
        '
        Me.custom1.Location = New System.Drawing.Point(16, 23)
        Me.custom1.Name = "custom1"
        Me.custom1.PaletteMode = Krypton.Toolkit.PaletteMode.ProfessionalSystem
        Me.custom1.Size = New System.Drawing.Size(182, 51)
        Me.custom1.StateNormal.Back.Image = Global.KryptonHeaderExamples.My.Resources.pageBg
        Me.custom1.StateNormal.Border.Color1 = System.Drawing.Color.FromArgb(CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer))
        Me.custom1.StateNormal.Border.DrawBorders = CType((((Krypton.Toolkit.PaletteDrawBorders.Top Or Krypton.Toolkit.PaletteDrawBorders.Bottom) Or Krypton.Toolkit.PaletteDrawBorders.Left) Or Krypton.Toolkit.PaletteDrawBorders.Right), Krypton.Toolkit.PaletteDrawBorders)
        Me.custom1.StateNormal.Border.GraphicsHint = Krypton.Toolkit.PaletteGraphicsHint.AntiAlias
        Me.custom1.StateNormal.Border.Rounding = 15.0!
        Me.custom1.StateNormal.Border.Width = 2
        Me.custom1.StateNormal.Content.ShortText.TextH = Krypton.Toolkit.PaletteRelativeAlign.Far
        Me.custom1.TabIndex = 0
        Me.custom1.Values.Description = ""
        Me.custom1.Values.Heading = "Image Effect"
        '
        ' custom2
        '
        Me.custom2.Location = New System.Drawing.Point(16, 72)
        Me.custom2.Name = "custom2"
        Me.custom2.PaletteMode = Krypton.Toolkit.PaletteMode.ProfessionalSystem
        Me.custom2.Size = New System.Drawing.Size(127, 37)
        Me.custom2.StateNormal.Back.Color1 = System.Drawing.SystemColors.InactiveCaptionText
        Me.custom2.StateNormal.Back.Color2 = System.Drawing.SystemColors.InactiveCaption
        Me.custom2.StateNormal.Back.GraphicsHint = Krypton.Toolkit.PaletteGraphicsHint.AntiAlias
        Me.custom2.StateNormal.Border.Color1 = System.Drawing.SystemColors.GradientInactiveCaption
        Me.custom2.StateNormal.Border.Color2 = System.Drawing.SystemColors.InactiveCaption
        Me.custom2.StateNormal.Border.ColorStyle = Krypton.Toolkit.PaletteColorStyle.Sigma
        Me.custom2.StateNormal.Border.Draw = Krypton.Toolkit.InheritBool.False
        Me.custom2.StateNormal.Border.DrawBorders = CType((((Krypton.Toolkit.PaletteDrawBorders.Top Or Krypton.Toolkit.PaletteDrawBorders.Bottom) Or Krypton.Toolkit.PaletteDrawBorders.Left) Or Krypton.Toolkit.PaletteDrawBorders.Right), Krypton.Toolkit.PaletteDrawBorders)
        Me.custom2.StateNormal.Border.GraphicsHint = Krypton.Toolkit.PaletteGraphicsHint.AntiAlias
        Me.custom2.StateNormal.Border.Rounding = 7.0!
        Me.custom2.StateNormal.Border.Width = 3
        Me.custom2.StateNormal.Content.Image.ImageH = Krypton.Toolkit.PaletteRelativeAlign.Far
        Me.custom2.StateNormal.Content.ShortText.Color1 = System.Drawing.Color.Black
        Me.custom2.TabIndex = 1
        Me.custom2.Values.Description = ""
        Me.custom2.Values.Heading = "Calendar"
        '
        ' Form1
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 17.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(638, 669)
        Me.Controls.Add(Me.groupBox3)
        Me.Controls.Add(Me.groupBox2)
        Me.Controls.Add(Me.groupBox1)
        Me.Controls.Add(Me.buttonClose)
        Me.Controls.Add(Me.groupBox4)
        Me.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog
        Me.MaximizeBox = False
        Me.MinimizeBox = False
        Me.Name = "Form1"
        Me.Text = "KryptonHeader Examples"
        Me.groupBox4.ResumeLayout(False)
        Me.groupBox1.ResumeLayout(False)
        Me.groupBox1.PerformLayout()
        Me.groupBox2.ResumeLayout(False)
        Me.groupBox2.PerformLayout()
        Me.groupBox3.ResumeLayout(False)
        Me.groupBox3.PerformLayout()
        Me.ResumeLayout(False)

    End Sub

#End Region

    Private WithEvents buttonClose As System.Windows.Forms.Button
    Private WithEvents propertyGrid As System.Windows.Forms.PropertyGrid
    Private WithEvents groupBox1 As System.Windows.Forms.GroupBox
    Private WithEvents groupBox2 As System.Windows.Forms.GroupBox
    Private WithEvents groupBox3 As System.Windows.Forms.GroupBox
    Private WithEvents groupBox4 As System.Windows.Forms.GroupBox
    Private WithEvents office3 As Krypton.Toolkit.KryptonHeader
    Private WithEvents office2 As Krypton.Toolkit.KryptonHeader
    Private WithEvents office1 As Krypton.Toolkit.KryptonHeader
    Private WithEvents custom2 As Krypton.Toolkit.KryptonHeader
    Private WithEvents custom1 As Krypton.Toolkit.KryptonHeader
    Private WithEvents office4 As Krypton.Toolkit.KryptonHeader
    Private WithEvents office5 As Krypton.Toolkit.KryptonHeader
    Private WithEvents office6 As Krypton.Toolkit.KryptonHeader
    Private WithEvents buttonSpecUp As Krypton.Toolkit.ButtonSpecAny
    Private WithEvents buttonSpecDown As Krypton.Toolkit.ButtonSpecAny
    Private WithEvents blue6 As Krypton.Toolkit.KryptonHeader
    Private WithEvents blue5 As Krypton.Toolkit.KryptonHeader
    Private WithEvents blue4 As Krypton.Toolkit.KryptonHeader
    Private WithEvents blue2 As Krypton.Toolkit.KryptonHeader
    Private WithEvents blue1 As Krypton.Toolkit.KryptonHeader
    Private WithEvents blue3 As Krypton.Toolkit.KryptonHeader
    Private WithEvents custom3 As Krypton.Toolkit.KryptonHeader

End Class
