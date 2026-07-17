' VB.NET twin of Source\Krypton Ribbon Examples\Ribbon Gallery\Form1.Designer.cs (Bastion Phase 4c).
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
        Me.kryptonRibbon = New Krypton.Ribbon.KryptonRibbon()
        Me.kryptonContextMenuItem1 = New Krypton.Toolkit.KryptonContextMenuItem()
        Me.kryptonRibbonTab1 = New Krypton.Ribbon.KryptonRibbonTab()
        Me.kryptonRibbonGroup1 = New Krypton.Ribbon.KryptonRibbonGroup()
        Me.kryptonRibbonGroupTriple1 = New Krypton.Ribbon.KryptonRibbonGroupTriple()
        Me.kryptonRibbonGroupButton1 = New Krypton.Ribbon.KryptonRibbonGroupButton()
        Me.kryptonRibbonGroupButton2 = New Krypton.Ribbon.KryptonRibbonGroupButton()
        Me.kryptonRibbonGroupButton3 = New Krypton.Ribbon.KryptonRibbonGroupButton()
        Me.kryptonRibbonGroup2 = New Krypton.Ribbon.KryptonRibbonGroup()
        Me.galleryNormal = New Krypton.Ribbon.KryptonRibbonGroupGallery()
        Me.imageList1 = New System.Windows.Forms.ImageList(Me.components)
        Me.galleryRanges = New Krypton.Ribbon.KryptonRibbonGroupGallery()
        Me.kryptonGalleryRange5 = New Krypton.Ribbon.KryptonGalleryRange()
        Me.kryptonGalleryRange6 = New Krypton.Ribbon.KryptonGalleryRange()
        Me.kryptonGalleryRange7 = New Krypton.Ribbon.KryptonGalleryRange()
        Me.galleryCustom = New Krypton.Ribbon.KryptonRibbonGroupGallery()
        Me.kryptonGalleryRange1 = New Krypton.Ribbon.KryptonGalleryRange()
        Me.kryptonGalleryRange2 = New Krypton.Ribbon.KryptonGalleryRange()
        Me.kryptonGalleryRange3 = New Krypton.Ribbon.KryptonGalleryRange()
        Me.kryptonGalleryRange4 = New Krypton.Ribbon.KryptonGalleryRange()
        Me.kryptonFillPanel = New Krypton.Toolkit.KryptonPanel()
        Me.kryptonPanel1 = New Krypton.Toolkit.KryptonPanel()
        Me.kryptonLabelExplain = New Krypton.Toolkit.KryptonLabel()
        Me.kryptonLabelTitle = New Krypton.Toolkit.KryptonLabel()
        Me.kryptonManager1 = New Krypton.Toolkit.KryptonManager(Me.components)
        CType(Me.kryptonRibbon, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.kryptonFillPanel, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.kryptonFillPanel.SuspendLayout()
        CType(Me.kryptonPanel1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.kryptonPanel1.SuspendLayout()
        Me.SuspendLayout()
        Me.kryptonRibbon.HideRibbonSize = New System.Drawing.Size(100, 100)
        Me.kryptonRibbon.InDesignHelperMode = True
        Me.kryptonRibbon.Name = "kryptonRibbon"
        Me.kryptonRibbon.RibbonFileAppButton.AppButtonMenuItems.AddRange(New Krypton.Toolkit.KryptonContextMenuItemBase() { Me.kryptonContextMenuItem1})
        Me.kryptonRibbon.RibbonFileAppButton.AppButtonShowRecentDocs = False
        Me.kryptonRibbon.RibbonTabs.AddRange(New Krypton.Ribbon.KryptonRibbonTab() { Me.kryptonRibbonTab1})
        Me.kryptonRibbon.SelectedTab = Me.kryptonRibbonTab1
        Me.kryptonRibbon.Size = New System.Drawing.Size(805, 136)
        Me.kryptonRibbon.TabIndex = 0
        Me.kryptonContextMenuItem1.Image = CType(resources.GetObject("kryptonContextMenuItem1.Image"), System.Drawing.Image)
        Me.kryptonContextMenuItem1.Text = "E&xit"
        Me.kryptonRibbonTab1.Groups.AddRange(New Krypton.Ribbon.KryptonRibbonGroup() { Me.kryptonRibbonGroup1, Me.kryptonRibbonGroup2})
        Me.kryptonRibbonGroup1.AllowCollapsed = False
        Me.kryptonRibbonGroup1.Image = CType(resources.GetObject("kryptonRibbonGroup1.Image"), System.Drawing.Image)
        Me.kryptonRibbonGroup1.Items.AddRange(New Krypton.Ribbon.KryptonRibbonGroupContainer() { Me.kryptonRibbonGroupTriple1})
        Me.kryptonRibbonGroup1.KeyTipGroup = "P"
        Me.kryptonRibbonGroup1.TextLine1 = "Palettes"
        Me.kryptonRibbonGroupTriple1.Items.AddRange(New Krypton.Ribbon.KryptonRibbonGroupItem() { Me.kryptonRibbonGroupButton1, Me.kryptonRibbonGroupButton2, Me.kryptonRibbonGroupButton3})
        Me.kryptonRibbonGroupTriple1.MaximumSize = Krypton.Ribbon.GroupItemSize.Medium
        Me.kryptonRibbonGroupTriple1.MinimumSize = Krypton.Ribbon.GroupItemSize.Medium
        Me.kryptonRibbonGroupButton1.ButtonType = Krypton.Ribbon.GroupButtonType.Check
        Me.kryptonRibbonGroupButton1.ImageSmall = CType(resources.GetObject("kryptonRibbonGroupButton1.ImageSmall"), System.Drawing.Image)
        Me.kryptonRibbonGroupButton1.TextLine1 = "Office 2010"
        Me.kryptonRibbonGroupButton1.TextLine2 = "Blue"
        Me.kryptonRibbonGroupButton2.ButtonType = Krypton.Ribbon.GroupButtonType.Check
        Me.kryptonRibbonGroupButton2.Checked = True
        Me.kryptonRibbonGroupButton2.ImageSmall = CType(resources.GetObject("kryptonRibbonGroupButton2.ImageSmall"), System.Drawing.Image)
        Me.kryptonRibbonGroupButton2.TextLine1 = "Office 2007"
        Me.kryptonRibbonGroupButton2.TextLine2 = "Silver"
        Me.kryptonRibbonGroupButton3.ButtonType = Krypton.Ribbon.GroupButtonType.Check
        Me.kryptonRibbonGroupButton3.ImageSmall = CType(resources.GetObject("kryptonRibbonGroupButton3.ImageSmall"), System.Drawing.Image)
        Me.kryptonRibbonGroupButton3.TextLine1 = "Sparkle Orange"
        Me.kryptonRibbonGroup2.Image = CType(resources.GetObject("kryptonRibbonGroup2.Image"), System.Drawing.Image)
        Me.kryptonRibbonGroup2.Items.AddRange(New Krypton.Ribbon.KryptonRibbonGroupContainer() { Me.galleryNormal, Me.galleryRanges, Me.galleryCustom})
        Me.kryptonRibbonGroup2.TextLine1 = "Galleries"
        Me.galleryNormal.DropButtonItemWidth = 6
        Me.galleryNormal.ImageLarge = CType(resources.GetObject("galleryNormal.ImageLarge"), System.Drawing.Image)
        Me.galleryNormal.ImageList = Me.imageList1
        Me.imageList1.ImageStream = CType(resources.GetObject("imageList1.ImageStream"), System.Windows.Forms.ImageListStreamer)
        Me.imageList1.TransparentColor = System.Drawing.Color.Transparent
        Me.imageList1.Images.SetKeyName(0, "flag_australia.png")
        Me.imageList1.Images.SetKeyName(1, "flag_bahamas.png")
        Me.imageList1.Images.SetKeyName(2, "flag_belgium.png")
        Me.imageList1.Images.SetKeyName(3, "flag_brazil.png")
        Me.imageList1.Images.SetKeyName(4, "flag_canada.png")
        Me.imageList1.Images.SetKeyName(5, "flag_england.png")
        Me.imageList1.Images.SetKeyName(6, "flag_germany.png")
        Me.imageList1.Images.SetKeyName(7, "flag_jamaica.png")
        Me.imageList1.Images.SetKeyName(8, "flag_norway.png")
        Me.imageList1.Images.SetKeyName(9, "flag_scotland.png")
        Me.imageList1.Images.SetKeyName(10, "flag_south_africa.png")
        Me.imageList1.Images.SetKeyName(11, "flag_spain.png")
        Me.imageList1.Images.SetKeyName(12, "flag_switzerland.png")
        Me.imageList1.Images.SetKeyName(13, "flag_united_kingdom.png")
        Me.imageList1.Images.SetKeyName(14, "flag_usa.png")
        Me.imageList1.Images.SetKeyName(15, "flag_wales.png")
        Me.galleryRanges.DropButtonItemWidth = 6
        Me.galleryRanges.DropButtonRanges.AddRange(New Krypton.Ribbon.KryptonGalleryRange() { Me.kryptonGalleryRange5, Me.kryptonGalleryRange6, Me.kryptonGalleryRange7})
        Me.galleryRanges.ImageLarge = CType(resources.GetObject("galleryRanges.ImageLarge"), System.Drawing.Image)
        Me.galleryRanges.ImageList = Me.imageList1
        Me.galleryRanges.KeyTip = "Y"
        Me.kryptonGalleryRange5.Heading = "Users"
        Me.kryptonGalleryRange5.ImageIndexEnd = 5
        Me.kryptonGalleryRange5.ImageIndexStart = 0
        Me.kryptonGalleryRange6.Heading = "Managers"
        Me.kryptonGalleryRange6.ImageIndexEnd = 11
        Me.kryptonGalleryRange6.ImageIndexStart = 6
        Me.kryptonGalleryRange7.Heading = "Others"
        Me.kryptonGalleryRange7.ImageIndexEnd = 15
        Me.kryptonGalleryRange7.ImageIndexStart = 12
        Me.galleryCustom.DropButtonItemWidth = 6
        Me.galleryCustom.ImageLarge = CType(resources.GetObject("galleryCustom.ImageLarge"), System.Drawing.Image)
        Me.galleryCustom.ImageList = Me.imageList1
        Me.galleryCustom.KeyTip = "Z"
        Me.kryptonGalleryRange1.Heading = "Group 1"
        Me.kryptonGalleryRange1.ImageIndexEnd = 4
        Me.kryptonGalleryRange1.ImageIndexStart = 0
        Me.kryptonGalleryRange2.Heading = "Group 2"
        Me.kryptonGalleryRange2.ImageIndexEnd = 9
        Me.kryptonGalleryRange2.ImageIndexStart = 5
        Me.kryptonGalleryRange3.Heading = "Group 3"
        Me.kryptonGalleryRange3.ImageIndexEnd = 14
        Me.kryptonGalleryRange3.ImageIndexStart = 10
        Me.kryptonGalleryRange4.Heading = "Group 4"
        Me.kryptonGalleryRange4.ImageIndexEnd = 20
        Me.kryptonGalleryRange4.ImageIndexStart = 15
        Me.kryptonFillPanel.Controls.Add(Me.kryptonPanel1)
        Me.kryptonFillPanel.Dock = System.Windows.Forms.DockStyle.Fill
        Me.kryptonFillPanel.Location = New System.Drawing.Point(0, 136)
        Me.kryptonFillPanel.Name = "kryptonFillPanel"
        Me.kryptonFillPanel.Size = New System.Drawing.Size(805, 134)
        Me.kryptonFillPanel.TabIndex = 1
        Me.kryptonPanel1.Controls.Add(Me.kryptonLabelExplain)
        Me.kryptonPanel1.Controls.Add(Me.kryptonLabelTitle)
        Me.kryptonPanel1.Location = New System.Drawing.Point(16, 16)
        Me.kryptonPanel1.Name = "kryptonPanel1"
        Me.kryptonPanel1.PanelBackStyle = Krypton.Toolkit.PaletteBackStyle.PanelAlternate
        Me.kryptonPanel1.Size = New System.Drawing.Size(476, 101)
        Me.kryptonPanel1.TabIndex = 0
        Me.kryptonLabelExplain.Location = New System.Drawing.Point(8, 36)
        Me.kryptonLabelExplain.Name = "kryptonLabelExplain"
        Me.kryptonLabelExplain.Size = New System.Drawing.Size(411, 66)
        Me.kryptonLabelExplain.TabIndex = 1
        Me.kryptonLabelExplain.Values.Text = "The Left gallery shows a standard drop down of all images." & vbCrLf & "The Middle gallery pr" & "ovides grouping in the drop down." & vbCrLf & "The Right gallery customizes the drop down me" & "nu." & vbCrLf
        Me.kryptonLabelTitle.LabelStyle = Krypton.Toolkit.LabelStyle.TitlePanel
        Me.kryptonLabelTitle.Location = New System.Drawing.Point(8, 8)
        Me.kryptonLabelTitle.Name = "kryptonLabelTitle"
        Me.kryptonLabelTitle.Size = New System.Drawing.Size(107, 37)
        Me.kryptonLabelTitle.TabIndex = 0
        Me.kryptonLabelTitle.Values.Text = "Galleries"
        Me.kryptonManager1.GlobalPaletteMode = Krypton.Toolkit.PaletteMode.ProfessionalSystem
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8F, 17F)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(805, 270)
        Me.CloseBox = False
        Me.Controls.Add(Me.kryptonFillPanel)
        Me.Controls.Add(Me.kryptonRibbon)
        Me.Font = New System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.MinimumSize = New System.Drawing.Size(381, 322)
        Me.Name = "Form1"
        Me.Text = "Ribbon Gallery"
        CType(Me.kryptonRibbon, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.kryptonFillPanel, System.ComponentModel.ISupportInitialize).EndInit()
        Me.kryptonFillPanel.ResumeLayout(False)
        CType(Me.kryptonPanel1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.kryptonPanel1.ResumeLayout(False)
        Me.kryptonPanel1.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()
    End Sub

    Friend WithEvents kryptonRibbon As Krypton.Ribbon.KryptonRibbon
    Friend WithEvents kryptonRibbonTab1 As Krypton.Ribbon.KryptonRibbonTab
    Friend WithEvents kryptonRibbonGroup1 As Krypton.Ribbon.KryptonRibbonGroup
    Friend WithEvents kryptonFillPanel As Krypton.Toolkit.KryptonPanel
    Friend WithEvents kryptonRibbonGroupTriple1 As Krypton.Ribbon.KryptonRibbonGroupTriple
    Friend WithEvents kryptonRibbonGroupButton1 As Krypton.Ribbon.KryptonRibbonGroupButton
    Friend WithEvents kryptonRibbonGroupButton2 As Krypton.Ribbon.KryptonRibbonGroupButton
    Friend WithEvents kryptonRibbonGroupButton3 As Krypton.Ribbon.KryptonRibbonGroupButton
    Friend WithEvents imageList1 As System.Windows.Forms.ImageList
    Friend WithEvents kryptonRibbonGroup2 As Krypton.Ribbon.KryptonRibbonGroup
    Friend WithEvents kryptonGalleryRange1 As Krypton.Ribbon.KryptonGalleryRange
    Friend WithEvents kryptonGalleryRange2 As Krypton.Ribbon.KryptonGalleryRange
    Friend WithEvents kryptonGalleryRange3 As Krypton.Ribbon.KryptonGalleryRange
    Friend WithEvents kryptonGalleryRange4 As Krypton.Ribbon.KryptonGalleryRange
    Friend WithEvents kryptonManager1 As Krypton.Toolkit.KryptonManager
    Friend WithEvents kryptonContextMenuItem1 As Krypton.Toolkit.KryptonContextMenuItem
    Friend WithEvents galleryNormal As Krypton.Ribbon.KryptonRibbonGroupGallery
    Friend WithEvents galleryRanges As Krypton.Ribbon.KryptonRibbonGroupGallery
    Friend WithEvents kryptonGalleryRange5 As Krypton.Ribbon.KryptonGalleryRange
    Friend WithEvents kryptonGalleryRange6 As Krypton.Ribbon.KryptonGalleryRange
    Friend WithEvents kryptonGalleryRange7 As Krypton.Ribbon.KryptonGalleryRange
    Friend WithEvents galleryCustom As Krypton.Ribbon.KryptonRibbonGroupGallery
    Friend WithEvents kryptonPanel1 As Krypton.Toolkit.KryptonPanel
    Friend WithEvents kryptonLabelExplain As Krypton.Toolkit.KryptonLabel
    Friend WithEvents kryptonLabelTitle As Krypton.Toolkit.KryptonLabel
End Class
