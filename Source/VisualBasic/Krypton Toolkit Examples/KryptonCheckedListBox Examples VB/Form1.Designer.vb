' VB.NET twin of Source\Krypton Toolkit Examples\KryptonCheckedListBox Examples\Form1.Designer.cs (Bastion Phase 4c).
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
        Me.groupBox1 = New System.Windows.Forms.GroupBox()
        Me.checkSystem = New Krypton.Toolkit.KryptonCheckButton()
        Me.check2010Blue = New Krypton.Toolkit.KryptonCheckButton()
        Me.checkSparkle = New Krypton.Toolkit.KryptonCheckButton()
        Me.check2007Blue = New Krypton.Toolkit.KryptonCheckButton()
        Me.buttonAppend = New Krypton.Toolkit.KryptonButton()
        Me.buttonInsert = New Krypton.Toolkit.KryptonButton()
        Me.buttonClear = New Krypton.Toolkit.KryptonButton()
        Me.buttonRemove = New Krypton.Toolkit.KryptonButton()
        Me.kryptonCheckedListBox = New Krypton.Toolkit.KryptonCheckedListBox()
        Me.buttonClose = New System.Windows.Forms.Button()
        Me.groupBox3 = New System.Windows.Forms.GroupBox()
        Me.propertyGrid = New System.Windows.Forms.PropertyGrid()
        Me.imageList = New System.Windows.Forms.ImageList(Me.components)
        Me.kryptonCheckSet = New Krypton.Toolkit.KryptonCheckSet(Me.components)
        Me.kryptonManager1 = New Krypton.Toolkit.KryptonManager(Me.components)
        Me.kryptonPaletteOffice2007Blue = New Krypton.Toolkit.KryptonCustomPaletteBase()
        Me.groupBox1.SuspendLayout()
        Me.groupBox3.SuspendLayout()
        CType(Me.kryptonCheckSet, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        Me.groupBox1.Controls.Add(Me.checkSystem)
        Me.groupBox1.Controls.Add(Me.check2010Blue)
        Me.groupBox1.Controls.Add(Me.checkSparkle)
        Me.groupBox1.Controls.Add(Me.check2007Blue)
        Me.groupBox1.Controls.Add(Me.buttonAppend)
        Me.groupBox1.Controls.Add(Me.buttonInsert)
        Me.groupBox1.Controls.Add(Me.buttonClear)
        Me.groupBox1.Controls.Add(Me.buttonRemove)
        Me.groupBox1.Location = New System.Drawing.Point(12, 234)
        Me.groupBox1.Name = "groupBox1"
        Me.groupBox1.Size = New System.Drawing.Size(249, 168)
        Me.groupBox1.TabIndex = 5
        Me.groupBox1.TabStop = False
        Me.groupBox1.Text = "Actions"
        Me.checkSystem.AutoSize = True
        Me.checkSystem.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowOnly
        Me.checkSystem.DialogResult = System.Windows.Forms.DialogResult.None
        Me.checkSystem.Location = New System.Drawing.Point(125, 126)
        Me.checkSystem.Name = "checkSystem"
        Me.checkSystem.Orientation = Krypton.Toolkit.VisualOrientation.Top
        Me.checkSystem.Size = New System.Drawing.Size(113, 25)
        Me.checkSystem.TabIndex = 7
        Me.checkSystem.Values.Text = "System"
        Me.check2010Blue.AutoSize = True
        Me.check2010Blue.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowOnly
        Me.check2010Blue.Checked = True
        Me.check2010Blue.DialogResult = System.Windows.Forms.DialogResult.None
        Me.check2010Blue.Location = New System.Drawing.Point(125, 31)
        Me.check2010Blue.Name = "check2010Blue"
        Me.check2010Blue.Orientation = Krypton.Toolkit.VisualOrientation.Top
        Me.check2010Blue.Size = New System.Drawing.Size(113, 25)
        Me.check2010Blue.TabIndex = 5
        Me.check2010Blue.Values.Text = "Office 2010 - Blue"
        Me.checkSparkle.AutoSize = True
        Me.checkSparkle.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowOnly
        Me.checkSparkle.DialogResult = System.Windows.Forms.DialogResult.None
        Me.checkSparkle.Location = New System.Drawing.Point(125, 94)
        Me.checkSparkle.Name = "checkSparkle"
        Me.checkSparkle.Orientation = Krypton.Toolkit.VisualOrientation.Top
        Me.checkSparkle.Size = New System.Drawing.Size(113, 25)
        Me.checkSparkle.TabIndex = 6
        Me.checkSparkle.Values.Text = "Sparkle - Blue"
        Me.check2007Blue.AutoSize = True
        Me.check2007Blue.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowOnly
        Me.check2007Blue.DialogResult = System.Windows.Forms.DialogResult.None
        Me.check2007Blue.Location = New System.Drawing.Point(125, 62)
        Me.check2007Blue.Name = "check2007Blue"
        Me.check2007Blue.Orientation = Krypton.Toolkit.VisualOrientation.Top
        Me.check2007Blue.Size = New System.Drawing.Size(113, 25)
        Me.check2007Blue.TabIndex = 4
        Me.check2007Blue.Values.Text = "Office 2007 - Blue"
        Me.buttonAppend.AutoSize = True
        Me.buttonAppend.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowOnly
        Me.buttonAppend.DialogResult = System.Windows.Forms.DialogResult.None
        Me.buttonAppend.Location = New System.Drawing.Point(19, 30)
        Me.buttonAppend.Name = "buttonAppend"
        Me.buttonAppend.Orientation = Krypton.Toolkit.VisualOrientation.Top
        Me.buttonAppend.Size = New System.Drawing.Size(90, 25)
        Me.buttonAppend.TabIndex = 0
        Me.buttonAppend.Values.Text = "Append"
        Me.buttonInsert.AutoSize = True
        Me.buttonInsert.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowOnly
        Me.buttonInsert.DialogResult = System.Windows.Forms.DialogResult.None
        Me.buttonInsert.Location = New System.Drawing.Point(19, 62)
        Me.buttonInsert.Name = "buttonInsert"
        Me.buttonInsert.Orientation = Krypton.Toolkit.VisualOrientation.Top
        Me.buttonInsert.Size = New System.Drawing.Size(90, 25)
        Me.buttonInsert.TabIndex = 1
        Me.buttonInsert.Values.Text = "Insert"
        Me.buttonClear.AutoSize = True
        Me.buttonClear.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowOnly
        Me.buttonClear.DialogResult = System.Windows.Forms.DialogResult.None
        Me.buttonClear.Location = New System.Drawing.Point(19, 126)
        Me.buttonClear.Name = "buttonClear"
        Me.buttonClear.Orientation = Krypton.Toolkit.VisualOrientation.Top
        Me.buttonClear.Size = New System.Drawing.Size(90, 25)
        Me.buttonClear.TabIndex = 3
        Me.buttonClear.Values.Text = "Clear"
        Me.buttonRemove.AutoSize = True
        Me.buttonRemove.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowOnly
        Me.buttonRemove.DialogResult = System.Windows.Forms.DialogResult.None
        Me.buttonRemove.Location = New System.Drawing.Point(19, 94)
        Me.buttonRemove.Name = "buttonRemove"
        Me.buttonRemove.Orientation = Krypton.Toolkit.VisualOrientation.Top
        Me.buttonRemove.Size = New System.Drawing.Size(90, 25)
        Me.buttonRemove.TabIndex = 2
        Me.buttonRemove.Values.Text = "Remove"
        Me.kryptonCheckedListBox.Location = New System.Drawing.Point(23, 24)
        Me.kryptonCheckedListBox.Name = "kryptonCheckedListBox"
        Me.kryptonCheckedListBox.Padding = New System.Windows.Forms.Padding(1)
        Me.kryptonCheckedListBox.SelectionMode = Krypton.Toolkit.CheckedSelectionMode.One
        Me.kryptonCheckedListBox.Size = New System.Drawing.Size(227, 192)
        Me.kryptonCheckedListBox.TabIndex = 4
        Me.buttonClose.Location = New System.Drawing.Point(493, 408)
        Me.buttonClose.Name = "buttonClose"
        Me.buttonClose.Size = New System.Drawing.Size(75, 23)
        Me.buttonClose.TabIndex = 7
        Me.buttonClose.Text = "Close"
        Me.buttonClose.UseVisualStyleBackColor = True
        Me.groupBox3.Controls.Add(Me.propertyGrid)
        Me.groupBox3.Location = New System.Drawing.Point(273, 12)
        Me.groupBox3.Name = "groupBox3"
        Me.groupBox3.Size = New System.Drawing.Size(295, 390)
        Me.groupBox3.TabIndex = 6
        Me.groupBox3.TabStop = False
        Me.groupBox3.Text = "Properties for KryptonCheckedListBox"
        Me.propertyGrid.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) Or System.Windows.Forms.AnchorStyles.Left) Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.propertyGrid.Location = New System.Drawing.Point(6, 19)
        Me.propertyGrid.Name = "propertyGrid"
        Me.propertyGrid.Size = New System.Drawing.Size(283, 365)
        Me.propertyGrid.TabIndex = 0
        Me.propertyGrid.ToolbarVisible = False
        Me.imageList.ImageStream = CType(resources.GetObject("imageList.ImageStream"), System.Windows.Forms.ImageListStreamer)
        Me.imageList.TransparentColor = System.Drawing.Color.Transparent
        Me.imageList.Images.SetKeyName(0, "atom.png")
        Me.imageList.Images.SetKeyName(1, "battery.png")
        Me.imageList.Images.SetKeyName(2, "cloud_sun.png")
        Me.imageList.Images.SetKeyName(3, "die_red.png")
        Me.imageList.Images.SetKeyName(4, "flower_white.png")
        Me.imageList.Images.SetKeyName(5, "package.png")
        Me.imageList.Images.SetKeyName(6, "pill_red.png")
        Me.imageList.Images.SetKeyName(7, "potion_red.png")
        Me.imageList.Images.SetKeyName(8, "pylon.png")
        Me.imageList.Images.SetKeyName(9, "scales.png")
        Me.imageList.Images.SetKeyName(10, "sun.png")
        Me.imageList.Images.SetKeyName(11, "surgeon2.png")
        Me.imageList.Images.SetKeyName(12, "target.png")
        Me.imageList.Images.SetKeyName(13, "tree.png")
        Me.imageList.Images.SetKeyName(14, "users2.png")
        Me.imageList.Images.SetKeyName(15, "woman.png")
        Me.imageList.Images.SetKeyName(16, "airplane.png")
        Me.imageList.Images.SetKeyName(17, "alarmclock.png")
        Me.imageList.Images.SetKeyName(18, "army_knife.png")
        Me.kryptonCheckSet.CheckButtons.Add(Me.check2007Blue)
        Me.kryptonCheckSet.CheckButtons.Add(Me.check2010Blue)
        Me.kryptonCheckSet.CheckButtons.Add(Me.checkSparkle)
        Me.kryptonCheckSet.CheckButtons.Add(Me.checkSystem)
        Me.kryptonCheckSet.CheckedButton = Me.check2010Blue
        Me.kryptonPaletteOffice2007Blue.BaseRenderMode = Krypton.Toolkit.RendererMode.Inherit
        Me.kryptonManager1.GlobalCustomPalette = Me.kryptonPaletteOffice2007Blue
        Me.kryptonManager1.GlobalPaletteMode = Krypton.Toolkit.PaletteMode.Custom
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6F, 13F)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(575, 438)
        Me.Controls.Add(Me.groupBox1)
        Me.Controls.Add(Me.kryptonCheckedListBox)
        Me.Controls.Add(Me.buttonClose)
        Me.Controls.Add(Me.groupBox3)
        Me.Font = New System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.MaximizeBox = False
        Me.MinimizeBox = False
        Me.Name = "Form1"
        Me.Text = "KryptonCheckedListBox Examples"
        Me.groupBox1.ResumeLayout(False)
        Me.groupBox1.PerformLayout()
        Me.groupBox3.ResumeLayout(False)
        CType(Me.kryptonCheckSet, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
    End Sub

    Friend WithEvents groupBox1 As System.Windows.Forms.GroupBox
    Friend WithEvents checkSystem As Krypton.Toolkit.KryptonCheckButton
    Friend WithEvents checkSparkle As Krypton.Toolkit.KryptonCheckButton
    Friend WithEvents check2010Blue As Krypton.Toolkit.KryptonCheckButton
    Friend WithEvents check2007Blue As Krypton.Toolkit.KryptonCheckButton
    Friend WithEvents buttonAppend As Krypton.Toolkit.KryptonButton
    Friend WithEvents buttonInsert As Krypton.Toolkit.KryptonButton
    Friend WithEvents buttonClear As Krypton.Toolkit.KryptonButton
    Friend WithEvents buttonRemove As Krypton.Toolkit.KryptonButton
    Friend WithEvents kryptonCheckedListBox As Krypton.Toolkit.KryptonCheckedListBox
    Friend WithEvents buttonClose As System.Windows.Forms.Button
    Friend WithEvents groupBox3 As System.Windows.Forms.GroupBox
    Friend WithEvents propertyGrid As System.Windows.Forms.PropertyGrid
    Friend WithEvents imageList As System.Windows.Forms.ImageList
    Friend WithEvents kryptonCheckSet As Krypton.Toolkit.KryptonCheckSet
    Friend WithEvents kryptonManager1 As Krypton.Toolkit.KryptonManager
    Friend WithEvents kryptonPaletteOffice2007Blue As Krypton.Toolkit.KryptonCustomPaletteBase
End Class
