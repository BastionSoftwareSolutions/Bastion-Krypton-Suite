' VB.NET twin of Source\Krypton Ribbon Examples\KryptonGallery Examples\Form1.Designer.cs (Bastion Phase 4c).
<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class Form1
    Inherits Krypton.Toolkit.KryptonForm

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
        Me.kryptonGallery1 = New Krypton.Ribbon.KryptonGallery()
        Me.kryptonGalleryRange1 = New Krypton.Ribbon.KryptonGalleryRange()
        Me.kryptonGalleryRange2 = New Krypton.Ribbon.KryptonGalleryRange()
        Me.kryptonGalleryRange3 = New Krypton.Ribbon.KryptonGalleryRange()
        Me.imageListMedium = New System.Windows.Forms.ImageList(Me.components)
        Me.imageListSmall = New System.Windows.Forms.ImageList(Me.components)
        Me.imageListLarge = New System.Windows.Forms.ImageList(Me.components)
        Me.groupBoxImages = New System.Windows.Forms.GroupBox()
        Me.radioLargeList = New System.Windows.Forms.RadioButton()
        Me.radioMediumList = New System.Windows.Forms.RadioButton()
        Me.radioSmallList = New System.Windows.Forms.RadioButton()
        Me.groupBoxSize = New System.Windows.Forms.GroupBox()
        Me.numericHeight = New System.Windows.Forms.NumericUpDown()
        Me.label2 = New System.Windows.Forms.Label()
        Me.label1 = New System.Windows.Forms.Label()
        Me.numericWidth = New System.Windows.Forms.NumericUpDown()
        Me.groupBoxSections = New System.Windows.Forms.GroupBox()
        Me.checkBoxAddCustomItems = New System.Windows.Forms.CheckBox()
        Me.checkBoxGroupImages = New System.Windows.Forms.CheckBox()
        Me.buttonClose = New System.Windows.Forms.Button()
        Me.kryptonManager1 = New Krypton.Toolkit.KryptonManager(Me.components)
        Me.groupBoxImages.SuspendLayout()
        Me.groupBoxSize.SuspendLayout()
        CType(Me.numericHeight, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.numericWidth, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.groupBoxSections.SuspendLayout()
        Me.SuspendLayout()
        Me.kryptonGallery1.AutoSize = True
        Me.kryptonGallery1.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink
        Me.kryptonGallery1.DropButtonRanges.AddRange(New Krypton.Ribbon.KryptonGalleryRange() { Me.kryptonGalleryRange1, Me.kryptonGalleryRange2, Me.kryptonGalleryRange3})
        Me.kryptonGallery1.ImageList = Me.imageListMedium
        Me.kryptonGallery1.Location = New System.Drawing.Point(178, 20)
        Me.kryptonGallery1.Name = "kryptonGallery1"
        Me.kryptonGallery1.PreferredItemSize = New System.Drawing.Size(4, 1)
        Me.kryptonGallery1.Size = New System.Drawing.Size(174, 46)
        Me.kryptonGallery1.TabIndex = 4
        Me.kryptonGalleryRange1.Heading = "Stars"
        Me.kryptonGalleryRange1.ImageIndexEnd = 4
        Me.kryptonGalleryRange1.ImageIndexStart = 0
        Me.kryptonGalleryRange2.Heading = "Arrows"
        Me.kryptonGalleryRange2.ImageIndexEnd = 12
        Me.kryptonGalleryRange2.ImageIndexStart = 5
        Me.kryptonGalleryRange3.Heading = "Users"
        Me.kryptonGalleryRange3.ImageIndexEnd = 15
        Me.kryptonGalleryRange3.ImageIndexStart = 13
        Me.imageListMedium.ImageStream = CType(resources.GetObject("imageListMedium.ImageStream"), System.Windows.Forms.ImageListStreamer)
        Me.imageListMedium.TransparentColor = System.Drawing.Color.Transparent
        Me.imageListMedium.Images.SetKeyName(0, "star_yellow.png")
        Me.imageListMedium.Images.SetKeyName(1, "star_blue.png")
        Me.imageListMedium.Images.SetKeyName(2, "star_green.png")
        Me.imageListMedium.Images.SetKeyName(3, "star_grey.png")
        Me.imageListMedium.Images.SetKeyName(4, "star_red.png")
        Me.imageListMedium.Images.SetKeyName(5, "arrow_up_green.png")
        Me.imageListMedium.Images.SetKeyName(6, "arrow_down_green.png")
        Me.imageListMedium.Images.SetKeyName(7, "arrow_left_green.png")
        Me.imageListMedium.Images.SetKeyName(8, "arrow_right_green.png")
        Me.imageListMedium.Images.SetKeyName(9, "arrow_up_blue.png")
        Me.imageListMedium.Images.SetKeyName(10, "arrow_down_blue.png")
        Me.imageListMedium.Images.SetKeyName(11, "arrow_left_blue.png")
        Me.imageListMedium.Images.SetKeyName(12, "arrow_right_blue.png")
        Me.imageListMedium.Images.SetKeyName(13, "user3.png")
        Me.imageListMedium.Images.SetKeyName(14, "user1.png")
        Me.imageListMedium.Images.SetKeyName(15, "user2.png")
        Me.imageListSmall.ImageStream = CType(resources.GetObject("imageListSmall.ImageStream"), System.Windows.Forms.ImageListStreamer)
        Me.imageListSmall.TransparentColor = System.Drawing.Color.Transparent
        Me.imageListSmall.Images.SetKeyName(0, "star_yellow.png")
        Me.imageListSmall.Images.SetKeyName(1, "star_blue.png")
        Me.imageListSmall.Images.SetKeyName(2, "star_green.png")
        Me.imageListSmall.Images.SetKeyName(3, "star_grey.png")
        Me.imageListSmall.Images.SetKeyName(4, "star_red.png")
        Me.imageListSmall.Images.SetKeyName(5, "arrow_up_green.png")
        Me.imageListSmall.Images.SetKeyName(6, "arrow_down_green.png")
        Me.imageListSmall.Images.SetKeyName(7, "arrow_left_green.png")
        Me.imageListSmall.Images.SetKeyName(8, "arrow_right_green.png")
        Me.imageListSmall.Images.SetKeyName(9, "arrow_up_blue.png")
        Me.imageListSmall.Images.SetKeyName(10, "arrow_down_blue.png")
        Me.imageListSmall.Images.SetKeyName(11, "arrow_left_blue.png")
        Me.imageListSmall.Images.SetKeyName(12, "arrow_right_blue.png")
        Me.imageListSmall.Images.SetKeyName(13, "user3.png")
        Me.imageListSmall.Images.SetKeyName(14, "user1.png")
        Me.imageListSmall.Images.SetKeyName(15, "user2.png")
        Me.imageListLarge.ImageStream = CType(resources.GetObject("imageListLarge.ImageStream"), System.Windows.Forms.ImageListStreamer)
        Me.imageListLarge.TransparentColor = System.Drawing.Color.Transparent
        Me.imageListLarge.Images.SetKeyName(0, "star_yellow.png")
        Me.imageListLarge.Images.SetKeyName(1, "star_blue.png")
        Me.imageListLarge.Images.SetKeyName(2, "star_green.png")
        Me.imageListLarge.Images.SetKeyName(3, "star_grey.png")
        Me.imageListLarge.Images.SetKeyName(4, "star_red.png")
        Me.imageListLarge.Images.SetKeyName(5, "arrow_up_green.png")
        Me.imageListLarge.Images.SetKeyName(6, "arrow_down_green.png")
        Me.imageListLarge.Images.SetKeyName(7, "arrow_left_green.png")
        Me.imageListLarge.Images.SetKeyName(8, "arrow_right_green.png")
        Me.imageListLarge.Images.SetKeyName(9, "arrow_up_blue.png")
        Me.imageListLarge.Images.SetKeyName(10, "arrow_down_blue.png")
        Me.imageListLarge.Images.SetKeyName(11, "arrow_left_blue.png")
        Me.imageListLarge.Images.SetKeyName(12, "arrow_right_blue.png")
        Me.imageListLarge.Images.SetKeyName(13, "user3.png")
        Me.imageListLarge.Images.SetKeyName(14, "user1.png")
        Me.imageListLarge.Images.SetKeyName(15, "user2.png")
        Me.groupBoxImages.Controls.Add(Me.radioLargeList)
        Me.groupBoxImages.Controls.Add(Me.radioMediumList)
        Me.groupBoxImages.Controls.Add(Me.radioSmallList)
        Me.groupBoxImages.Location = New System.Drawing.Point(13, 13)
        Me.groupBoxImages.Name = "groupBoxImages"
        Me.groupBoxImages.Size = New System.Drawing.Size(149, 114)
        Me.groupBoxImages.TabIndex = 0
        Me.groupBoxImages.TabStop = False
        Me.groupBoxImages.Text = "Gallery Images"
        Me.radioLargeList.AutoSize = True
        Me.radioLargeList.Location = New System.Drawing.Point(15, 72)
        Me.radioLargeList.Name = "radioLargeList"
        Me.radioLargeList.Size = New System.Drawing.Size(129, 21)
        Me.radioLargeList.TabIndex = 2
        Me.radioLargeList.Text = "Large Image List"
        Me.radioLargeList.UseVisualStyleBackColor = True
        Me.radioMediumList.AutoSize = True
        Me.radioMediumList.Checked = True
        Me.radioMediumList.Location = New System.Drawing.Point(15, 49)
        Me.radioMediumList.Name = "radioMediumList"
        Me.radioMediumList.Size = New System.Drawing.Size(142, 21)
        Me.radioMediumList.TabIndex = 1
        Me.radioMediumList.TabStop = True
        Me.radioMediumList.Text = "Medium Image List"
        Me.radioMediumList.UseVisualStyleBackColor = True
        Me.radioSmallList.AutoSize = True
        Me.radioSmallList.Location = New System.Drawing.Point(15, 26)
        Me.radioSmallList.Name = "radioSmallList"
        Me.radioSmallList.Size = New System.Drawing.Size(126, 21)
        Me.radioSmallList.TabIndex = 0
        Me.radioSmallList.Text = "Small Image List"
        Me.radioSmallList.UseVisualStyleBackColor = True
        Me.groupBoxSize.Controls.Add(Me.numericHeight)
        Me.groupBoxSize.Controls.Add(Me.label2)
        Me.groupBoxSize.Controls.Add(Me.label1)
        Me.groupBoxSize.Controls.Add(Me.numericWidth)
        Me.groupBoxSize.Location = New System.Drawing.Point(13, 134)
        Me.groupBoxSize.Name = "groupBoxSize"
        Me.groupBoxSize.Size = New System.Drawing.Size(149, 89)
        Me.groupBoxSize.TabIndex = 1
        Me.groupBoxSize.TabStop = False
        Me.groupBoxSize.Text = "Gallery Size"
        Me.numericHeight.Location = New System.Drawing.Point(91, 53)
        Me.numericHeight.Maximum = New Decimal(New Integer() { 6, 0, 0, 0})
        Me.numericHeight.Minimum = New Decimal(New Integer() { 1, 0, 0, 0})
        Me.numericHeight.Name = "numericHeight"
        Me.numericHeight.Size = New System.Drawing.Size(42, 24)
        Me.numericHeight.TabIndex = 3
        Me.numericHeight.Value = New Decimal(New Integer() { 1, 0, 0, 0})
        Me.label2.AutoSize = True
        Me.label2.Location = New System.Drawing.Point(9, 55)
        Me.label2.Name = "label2"
        Me.label2.Size = New System.Drawing.Size(95, 17)
        Me.label2.TabIndex = 2
        Me.label2.Text = "Height (Items)"
        Me.label1.AutoSize = True
        Me.label1.Location = New System.Drawing.Point(12, 28)
        Me.label1.Name = "label1"
        Me.label1.Size = New System.Drawing.Size(93, 17)
        Me.label1.TabIndex = 0
        Me.label1.Text = "Width (Items)"
        Me.numericWidth.Location = New System.Drawing.Point(91, 26)
        Me.numericWidth.Maximum = New Decimal(New Integer() { 6, 0, 0, 0})
        Me.numericWidth.Minimum = New Decimal(New Integer() { 1, 0, 0, 0})
        Me.numericWidth.Name = "numericWidth"
        Me.numericWidth.Size = New System.Drawing.Size(42, 24)
        Me.numericWidth.TabIndex = 1
        Me.numericWidth.Value = New Decimal(New Integer() { 4, 0, 0, 0})
        Me.groupBoxSections.Controls.Add(Me.checkBoxAddCustomItems)
        Me.groupBoxSections.Controls.Add(Me.checkBoxGroupImages)
        Me.groupBoxSections.Location = New System.Drawing.Point(13, 230)
        Me.groupBoxSections.Name = "groupBoxSections"
        Me.groupBoxSections.Size = New System.Drawing.Size(149, 91)
        Me.groupBoxSections.TabIndex = 2
        Me.groupBoxSections.TabStop = False
        Me.groupBoxSections.Text = "Gallery Drop Menu"
        Me.checkBoxAddCustomItems.AutoSize = True
        Me.checkBoxAddCustomItems.Location = New System.Drawing.Point(15, 54)
        Me.checkBoxAddCustomItems.Name = "checkBoxAddCustomItems"
        Me.checkBoxAddCustomItems.Size = New System.Drawing.Size(144, 21)
        Me.checkBoxAddCustomItems.TabIndex = 1
        Me.checkBoxAddCustomItems.Text = "Add Custom Items"
        Me.checkBoxAddCustomItems.UseVisualStyleBackColor = True
        Me.checkBoxGroupImages.AutoSize = True
        Me.checkBoxGroupImages.Checked = True
        Me.checkBoxGroupImages.CheckState = System.Windows.Forms.CheckState.Checked
        Me.checkBoxGroupImages.Location = New System.Drawing.Point(15, 31)
        Me.checkBoxGroupImages.Name = "checkBoxGroupImages"
        Me.checkBoxGroupImages.Size = New System.Drawing.Size(116, 21)
        Me.checkBoxGroupImages.TabIndex = 0
        Me.checkBoxGroupImages.Text = "Group Images"
        Me.checkBoxGroupImages.UseVisualStyleBackColor = True
        Me.buttonClose.Location = New System.Drawing.Point(13, 327)
        Me.buttonClose.Name = "buttonClose"
        Me.buttonClose.Size = New System.Drawing.Size(149, 23)
        Me.buttonClose.TabIndex = 3
        Me.buttonClose.Text = "Close"
        Me.buttonClose.UseVisualStyleBackColor = True
        Me.kryptonManager1.GlobalPaletteMode = Krypton.Toolkit.PaletteMode.SparklePurpleLightMode
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8F, 17F)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(554, 361)
        Me.Controls.Add(Me.buttonClose)
        Me.Controls.Add(Me.groupBoxSections)
        Me.Controls.Add(Me.groupBoxSize)
        Me.Controls.Add(Me.groupBoxImages)
        Me.Controls.Add(Me.kryptonGallery1)
        Me.Font = New System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.Name = "Form1"
        Me.Text = "Krypton Gallery Examples"
        Me.TransparencyKey = System.Drawing.Color.Violet
        Me.groupBoxImages.ResumeLayout(False)
        Me.groupBoxImages.PerformLayout()
        Me.groupBoxSize.ResumeLayout(False)
        Me.groupBoxSize.PerformLayout()
        CType(Me.numericHeight, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.numericWidth, System.ComponentModel.ISupportInitialize).EndInit()
        Me.groupBoxSections.ResumeLayout(False)
        Me.groupBoxSections.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()
    End Sub

    Friend WithEvents kryptonGallery1 As Krypton.Ribbon.KryptonGallery
    Friend WithEvents imageListSmall As System.Windows.Forms.ImageList
    Friend WithEvents imageListMedium As System.Windows.Forms.ImageList
    Friend WithEvents imageListLarge As System.Windows.Forms.ImageList
    Friend WithEvents groupBoxImages As System.Windows.Forms.GroupBox
    Friend WithEvents radioLargeList As System.Windows.Forms.RadioButton
    Friend WithEvents radioMediumList As System.Windows.Forms.RadioButton
    Friend WithEvents radioSmallList As System.Windows.Forms.RadioButton
    Friend WithEvents groupBoxSize As System.Windows.Forms.GroupBox
    Friend WithEvents numericHeight As System.Windows.Forms.NumericUpDown
    Friend WithEvents label2 As System.Windows.Forms.Label
    Friend WithEvents label1 As System.Windows.Forms.Label
    Friend WithEvents numericWidth As System.Windows.Forms.NumericUpDown
    Friend WithEvents kryptonGalleryRange1 As Krypton.Ribbon.KryptonGalleryRange
    Friend WithEvents kryptonGalleryRange2 As Krypton.Ribbon.KryptonGalleryRange
    Friend WithEvents kryptonGalleryRange3 As Krypton.Ribbon.KryptonGalleryRange
    Friend WithEvents groupBoxSections As System.Windows.Forms.GroupBox
    Friend WithEvents checkBoxAddCustomItems As System.Windows.Forms.CheckBox
    Friend WithEvents checkBoxGroupImages As System.Windows.Forms.CheckBox
    Friend WithEvents buttonClose As System.Windows.Forms.Button
    Friend WithEvents kryptonManager1 As Krypton.Toolkit.KryptonManager
End Class
