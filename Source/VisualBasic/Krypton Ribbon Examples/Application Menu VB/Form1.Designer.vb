' VB.NET twin of Source\Krypton Ribbon Examples\Application Menu\Form1.Designer.cs (Bastion Phase 4c).
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
        Me.kryptonRibbon1 = New Krypton.Ribbon.KryptonRibbon()
        Me.kryptonContextMenuItem1 = New Krypton.Toolkit.KryptonContextMenuItem()
        Me.kryptonContextMenuItem2 = New Krypton.Toolkit.KryptonContextMenuItem()
        Me.kryptonContextMenuItem3 = New Krypton.Toolkit.KryptonContextMenuItem()
        Me.kryptonContextMenuItem4 = New Krypton.Toolkit.KryptonContextMenuItem()
        Me.kryptonContextMenuSeparator1 = New Krypton.Toolkit.KryptonContextMenuSeparator()
        Me.kryptonContextMenuItem5 = New Krypton.Toolkit.KryptonContextMenuItem()
        Me.kryptonRibbonRecentDoc1 = New Krypton.Ribbon.KryptonRibbonRecentDoc()
        Me.kryptonRibbonRecentDoc2 = New Krypton.Ribbon.KryptonRibbonRecentDoc()
        Me.kryptonRibbonRecentDoc3 = New Krypton.Ribbon.KryptonRibbonRecentDoc()
        Me.kryptonRibbonRecentDoc4 = New Krypton.Ribbon.KryptonRibbonRecentDoc()
        Me.buttonSpecAppMenu1 = New Krypton.Ribbon.ButtonSpecAppMenu()
        Me.buttonSpecAppMenu2 = New Krypton.Ribbon.ButtonSpecAppMenu()
        Me.kryptonRibbonTab1 = New Krypton.Ribbon.KryptonRibbonTab()
        Me.kryptonRibbonGroup1 = New Krypton.Ribbon.KryptonRibbonGroup()
        Me.kryptonRibbonGroupTriple4 = New Krypton.Ribbon.KryptonRibbonGroupTriple()
        Me.button2010Blue = New Krypton.Ribbon.KryptonRibbonGroupButton()
        Me.button2010Silver = New Krypton.Ribbon.KryptonRibbonGroupButton()
        Me.button2010Black = New Krypton.Ribbon.KryptonRibbonGroupButton()
        Me.kryptonRibbonGroupSeparator3 = New Krypton.Ribbon.KryptonRibbonGroupSeparator()
        Me.kryptonRibbonGroupTriple1 = New Krypton.Ribbon.KryptonRibbonGroupTriple()
        Me.buttonBlue = New Krypton.Ribbon.KryptonRibbonGroupButton()
        Me.buttonSilver = New Krypton.Ribbon.KryptonRibbonGroupButton()
        Me.buttonBlack = New Krypton.Ribbon.KryptonRibbonGroupButton()
        Me.kryptonRibbonGroupSeparator1 = New Krypton.Ribbon.KryptonRibbonGroupSeparator()
        Me.kryptonRibbonGroupTriple3 = New Krypton.Ribbon.KryptonRibbonGroupTriple()
        Me.buttonSparkleBlue = New Krypton.Ribbon.KryptonRibbonGroupButton()
        Me.buttonSparkleOrange = New Krypton.Ribbon.KryptonRibbonGroupButton()
        Me.buttonSparklePurple = New Krypton.Ribbon.KryptonRibbonGroupButton()
        Me.kryptonRibbonGroupSeparator2 = New Krypton.Ribbon.KryptonRibbonGroupSeparator()
        Me.kryptonRibbonGroupTriple2 = New Krypton.Ribbon.KryptonRibbonGroupTriple()
        Me.button2003 = New Krypton.Ribbon.KryptonRibbonGroupButton()
        Me.buttonSystem = New Krypton.Ribbon.KryptonRibbonGroupButton()
        Me.kryptonManager1 = New Krypton.Toolkit.KryptonManager(Me.components)
        Me.kryptonPanel1 = New Krypton.Toolkit.KryptonPanel()
        Me.kryptonGroup1 = New Krypton.Toolkit.KryptonGroup()
        Me.kryptonLabel5 = New Krypton.Toolkit.KryptonLabel()
        Me.kryptonLabel4 = New Krypton.Toolkit.KryptonLabel()
        Me.checkBoxShowRecentDocs = New Krypton.Toolkit.KryptonCheckBox()
        Me.textBoxMinHeight = New Krypton.Toolkit.KryptonTextBox()
        Me.textBoxDocsTitle = New Krypton.Toolkit.KryptonTextBox()
        Me.kryptonLabel3 = New Krypton.Toolkit.KryptonLabel()
        Me.kryptonLabel1 = New Krypton.Toolkit.KryptonLabel()
        Me.kryptonLabel2 = New Krypton.Toolkit.KryptonLabel()
        Me.textBoxMinWidth = New Krypton.Toolkit.KryptonTextBox()
        Me.buttonSpecAny1 = New Krypton.Toolkit.ButtonSpecAny()
        Me.buttonSpecAny2 = New Krypton.Toolkit.ButtonSpecAny()
        CType(Me.kryptonRibbon1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.kryptonPanel1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.kryptonPanel1.SuspendLayout()
        CType(Me.kryptonGroup1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.kryptonGroup1.Panel, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.kryptonGroup1.Panel.SuspendLayout()
        Me.kryptonGroup1.SuspendLayout()
        Me.SuspendLayout()
        Me.kryptonRibbon1.InDesignHelperMode = True
        Me.kryptonRibbon1.Name = "kryptonRibbon1"
        Me.kryptonRibbon1.RibbonFileAppButton.AppButtonMenuItems.AddRange(New Krypton.Toolkit.KryptonContextMenuItemBase() { Me.kryptonContextMenuItem1, Me.kryptonContextMenuItem2, Me.kryptonContextMenuItem3, Me.kryptonContextMenuItem4, Me.kryptonContextMenuSeparator1, Me.kryptonContextMenuItem5})
        Me.kryptonRibbon1.RibbonFileAppButton.AppButtonMinRecentSize = New System.Drawing.Size(150, 150)
        Me.kryptonRibbon1.RibbonFileAppButton.AppButtonRecentDocs.AddRange(New Krypton.Ribbon.KryptonRibbonRecentDoc() { Me.kryptonRibbonRecentDoc1, Me.kryptonRibbonRecentDoc2, Me.kryptonRibbonRecentDoc3, Me.kryptonRibbonRecentDoc4})
        Me.kryptonRibbon1.RibbonFileAppButton.AppButtonSpecs.Add(Me.buttonSpecAppMenu1)
        Me.kryptonRibbon1.RibbonFileAppButton.AppButtonSpecs.Add(Me.buttonSpecAppMenu2)
        Me.kryptonRibbon1.RibbonFileAppButton.IgnoreDoubleClickClose = True
        Me.kryptonRibbon1.RibbonTabs.AddRange(New Krypton.Ribbon.KryptonRibbonTab() { Me.kryptonRibbonTab1})
        Me.kryptonRibbon1.SelectedTab = Me.kryptonRibbonTab1
        Me.kryptonRibbon1.Size = New System.Drawing.Size(531, 136)
        Me.kryptonRibbon1.TabIndex = 0
        Me.kryptonContextMenuItem1.Image = CType(resources.GetObject("kryptonContextMenuItem1.Image"), System.Drawing.Image)
        Me.kryptonContextMenuItem1.Text = "&New"
        Me.kryptonContextMenuItem2.Image = CType(resources.GetObject("kryptonContextMenuItem2.Image"), System.Drawing.Image)
        Me.kryptonContextMenuItem2.Text = "&Open"
        Me.kryptonContextMenuItem3.Image = CType(resources.GetObject("kryptonContextMenuItem3.Image"), System.Drawing.Image)
        Me.kryptonContextMenuItem3.Text = "&Save"
        Me.kryptonContextMenuItem4.Image = CType(resources.GetObject("kryptonContextMenuItem4.Image"), System.Drawing.Image)
        Me.kryptonContextMenuItem4.Text = "Save &As"
        Me.kryptonContextMenuItem5.Image = CType(resources.GetObject("kryptonContextMenuItem5.Image"), System.Drawing.Image)
        Me.kryptonContextMenuItem5.Text = "E&xit"
        Me.kryptonRibbonRecentDoc1.Text = "Change list.doc"
        Me.kryptonRibbonRecentDoc2.Text = "Birthday list.docx"
        Me.kryptonRibbonRecentDoc3.Text = "Old version.txt"
        Me.kryptonRibbonRecentDoc4.Text = "TODO.txt"
        Me.buttonSpecAppMenu1.Style = Krypton.Toolkit.PaletteButtonStyle.Standalone
        Me.buttonSpecAppMenu1.Text = "O&ptions"
        Me.buttonSpecAppMenu1.UniqueName = "9664A073DF8541B79664A073DF8541B7"
        Me.buttonSpecAppMenu2.Style = Krypton.Toolkit.PaletteButtonStyle.Standalone
        Me.buttonSpecAppMenu2.Text = "&Close"
        Me.buttonSpecAppMenu2.UniqueName = "70F15DC834C14B3070F15DC834C14B30"
        Me.kryptonRibbonTab1.Groups.AddRange(New Krypton.Ribbon.KryptonRibbonGroup() { Me.kryptonRibbonGroup1})
        Me.kryptonRibbonGroup1.AllowCollapsed = False
        Me.kryptonRibbonGroup1.Items.AddRange(New Krypton.Ribbon.KryptonRibbonGroupContainer() { Me.kryptonRibbonGroupTriple4, Me.kryptonRibbonGroupSeparator3, Me.kryptonRibbonGroupTriple1, Me.kryptonRibbonGroupSeparator1, Me.kryptonRibbonGroupTriple3, Me.kryptonRibbonGroupSeparator2, Me.kryptonRibbonGroupTriple2})
        Me.kryptonRibbonGroup1.TextLine1 = "Palettes"
        Me.kryptonRibbonGroupTriple4.Items.AddRange(New Krypton.Ribbon.KryptonRibbonGroupItem() { Me.button2010Blue, Me.button2010Silver, Me.button2010Black})
        Me.button2010Blue.ButtonType = Krypton.Ribbon.GroupButtonType.Check
        Me.button2010Blue.ImageLarge = CType(resources.GetObject("button2010Blue.ImageLarge"), System.Drawing.Image)
        Me.button2010Blue.ImageSmall = CType(resources.GetObject("button2010Blue.ImageSmall"), System.Drawing.Image)
        Me.button2010Blue.TextLine1 = "2010"
        Me.button2010Blue.TextLine2 = "Blue"
        Me.button2010Silver.ButtonType = Krypton.Ribbon.GroupButtonType.Check
        Me.button2010Silver.ImageLarge = CType(resources.GetObject("button2010Silver.ImageLarge"), System.Drawing.Image)
        Me.button2010Silver.ImageSmall = CType(resources.GetObject("button2010Silver.ImageSmall"), System.Drawing.Image)
        Me.button2010Silver.TextLine1 = "2010"
        Me.button2010Silver.TextLine2 = "Silver"
        Me.button2010Black.ButtonType = Krypton.Ribbon.GroupButtonType.Check
        Me.button2010Black.ImageLarge = CType(resources.GetObject("button2010Black.ImageLarge"), System.Drawing.Image)
        Me.button2010Black.ImageSmall = CType(resources.GetObject("button2010Black.ImageSmall"), System.Drawing.Image)
        Me.button2010Black.TextLine1 = "2010"
        Me.button2010Black.TextLine2 = "Black"
        Me.kryptonRibbonGroupTriple1.Items.AddRange(New Krypton.Ribbon.KryptonRibbonGroupItem() { Me.buttonBlue, Me.buttonSilver, Me.buttonBlack})
        Me.kryptonRibbonGroupTriple1.MinimumSize = Krypton.Ribbon.GroupItemSize.Large
        Me.buttonBlue.ButtonType = Krypton.Ribbon.GroupButtonType.Check
        Me.buttonBlue.ImageLarge = CType(resources.GetObject("buttonBlue.ImageLarge"), System.Drawing.Image)
        Me.buttonBlue.ImageSmall = CType(resources.GetObject("buttonBlue.ImageSmall"), System.Drawing.Image)
        Me.buttonBlue.TextLine1 = "2007"
        Me.buttonBlue.TextLine2 = "Blue"
        Me.buttonSilver.ButtonType = Krypton.Ribbon.GroupButtonType.Check
        Me.buttonSilver.Checked = True
        Me.buttonSilver.ImageLarge = CType(resources.GetObject("buttonSilver.ImageLarge"), System.Drawing.Image)
        Me.buttonSilver.ImageSmall = CType(resources.GetObject("buttonSilver.ImageSmall"), System.Drawing.Image)
        Me.buttonSilver.KeyTip = "S"
        Me.buttonSilver.TextLine1 = "2007"
        Me.buttonSilver.TextLine2 = "Silver"
        Me.buttonBlack.ButtonType = Krypton.Ribbon.GroupButtonType.Check
        Me.buttonBlack.ImageLarge = CType(resources.GetObject("buttonBlack.ImageLarge"), System.Drawing.Image)
        Me.buttonBlack.ImageSmall = CType(resources.GetObject("buttonBlack.ImageSmall"), System.Drawing.Image)
        Me.buttonBlack.KeyTip = "L"
        Me.buttonBlack.TextLine1 = "2007"
        Me.buttonBlack.TextLine2 = "Black"
        Me.kryptonRibbonGroupTriple3.Items.AddRange(New Krypton.Ribbon.KryptonRibbonGroupItem() { Me.buttonSparkleBlue, Me.buttonSparkleOrange, Me.buttonSparklePurple})
        Me.buttonSparkleBlue.ButtonType = Krypton.Ribbon.GroupButtonType.Check
        Me.buttonSparkleBlue.ImageLarge = CType(resources.GetObject("buttonSparkleBlue.ImageLarge"), System.Drawing.Image)
        Me.buttonSparkleBlue.ImageSmall = CType(resources.GetObject("buttonSparkleBlue.ImageSmall"), System.Drawing.Image)
        Me.buttonSparkleBlue.KeyTip = "E"
        Me.buttonSparkleBlue.TextLine1 = "Sparkle"
        Me.buttonSparkleBlue.TextLine2 = "Blue"
        Me.buttonSparkleOrange.ButtonType = Krypton.Ribbon.GroupButtonType.Check
        Me.buttonSparkleOrange.ImageLarge = CType(resources.GetObject("buttonSparkleOrange.ImageLarge"), System.Drawing.Image)
        Me.buttonSparkleOrange.ImageSmall = CType(resources.GetObject("buttonSparkleOrange.ImageSmall"), System.Drawing.Image)
        Me.buttonSparkleOrange.KeyTip = "O"
        Me.buttonSparkleOrange.TextLine1 = "Sparkle"
        Me.buttonSparkleOrange.TextLine2 = "Orange"
        Me.buttonSparklePurple.ButtonType = Krypton.Ribbon.GroupButtonType.Check
        Me.buttonSparklePurple.ImageLarge = CType(resources.GetObject("buttonSparklePurple.ImageLarge"), System.Drawing.Image)
        Me.buttonSparklePurple.ImageSmall = CType(resources.GetObject("buttonSparklePurple.ImageSmall"), System.Drawing.Image)
        Me.buttonSparklePurple.KeyTip = "P"
        Me.buttonSparklePurple.TextLine1 = "Sparkle"
        Me.buttonSparklePurple.TextLine2 = "Purple"
        Me.kryptonRibbonGroupTriple2.Items.AddRange(New Krypton.Ribbon.KryptonRibbonGroupItem() { Me.button2003, Me.buttonSystem})
        Me.button2003.ButtonType = Krypton.Ribbon.GroupButtonType.Check
        Me.button2003.ImageLarge = CType(resources.GetObject("button2003.ImageLarge"), System.Drawing.Image)
        Me.button2003.ImageSmall = CType(resources.GetObject("button2003.ImageSmall"), System.Drawing.Image)
        Me.button2003.KeyTip = "3"
        Me.button2003.TextLine1 = " 2003"
        Me.buttonSystem.ButtonType = Krypton.Ribbon.GroupButtonType.Check
        Me.buttonSystem.ImageLarge = CType(resources.GetObject("buttonSystem.ImageLarge"), System.Drawing.Image)
        Me.buttonSystem.ImageSmall = CType(resources.GetObject("buttonSystem.ImageSmall"), System.Drawing.Image)
        Me.buttonSystem.KeyTip = "S"
        Me.buttonSystem.TextLine1 = "System"
        Me.kryptonManager1.GlobalPaletteMode = Krypton.Toolkit.PaletteMode.Office2007Silver
        Me.kryptonPanel1.Controls.Add(Me.kryptonGroup1)
        Me.kryptonPanel1.Dock = System.Windows.Forms.DockStyle.Fill
        Me.kryptonPanel1.Location = New System.Drawing.Point(0, 136)
        Me.kryptonPanel1.Name = "kryptonPanel1"
        Me.kryptonPanel1.Size = New System.Drawing.Size(531, 304)
        Me.kryptonPanel1.TabIndex = 1
        Me.kryptonGroup1.GroupBackStyle = Krypton.Toolkit.PaletteBackStyle.PanelAlternate
        Me.kryptonGroup1.Location = New System.Drawing.Point(21, 23)
        Me.kryptonGroup1.Name = "kryptonGroup1"
        Me.kryptonGroup1.Panel.Controls.Add(Me.kryptonLabel5)
        Me.kryptonGroup1.Panel.Controls.Add(Me.kryptonLabel4)
        Me.kryptonGroup1.Panel.Controls.Add(Me.checkBoxShowRecentDocs)
        Me.kryptonGroup1.Panel.Controls.Add(Me.textBoxMinHeight)
        Me.kryptonGroup1.Panel.Controls.Add(Me.textBoxDocsTitle)
        Me.kryptonGroup1.Panel.Controls.Add(Me.kryptonLabel3)
        Me.kryptonGroup1.Panel.Controls.Add(Me.kryptonLabel1)
        Me.kryptonGroup1.Panel.Controls.Add(Me.kryptonLabel2)
        Me.kryptonGroup1.Panel.Controls.Add(Me.textBoxMinWidth)
        Me.kryptonGroup1.Size = New System.Drawing.Size(480, 217)
        Me.kryptonGroup1.TabIndex = 7
        Me.kryptonLabel5.Location = New System.Drawing.Point(10, 167)
        Me.kryptonLabel5.Name = "kryptonLabel5"
        Me.kryptonLabel5.Size = New System.Drawing.Size(383, 44)
        Me.kryptonLabel5.TabIndex = 8
        Me.kryptonLabel5.Values.Text = "Change settings and then press the application button" & vbCrLf & "at the top left of the rib" & "bon to see changes take effect."
        Me.kryptonLabel4.LabelStyle = Krypton.Toolkit.LabelStyle.TitlePanel
        Me.kryptonLabel4.Location = New System.Drawing.Point(4, 4)
        Me.kryptonLabel4.Name = "kryptonLabel4"
        Me.kryptonLabel4.Size = New System.Drawing.Size(232, 35)
        Me.kryptonLabel4.TabIndex = 7
        Me.kryptonLabel4.Values.Text = "Recent Doc Settings"
        Me.checkBoxShowRecentDocs.Checked = True
        Me.checkBoxShowRecentDocs.CheckState = System.Windows.Forms.CheckState.Checked
        Me.checkBoxShowRecentDocs.Location = New System.Drawing.Point(219, 133)
        Me.checkBoxShowRecentDocs.Name = "checkBoxShowRecentDocs"
        Me.checkBoxShowRecentDocs.Size = New System.Drawing.Size(186, 24)
        Me.checkBoxShowRecentDocs.TabIndex = 0
        Me.checkBoxShowRecentDocs.Values.Text = "Show Recent Docs Area"
        Me.textBoxMinHeight.Location = New System.Drawing.Point(219, 100)
        Me.textBoxMinHeight.Name = "textBoxMinHeight"
        Me.textBoxMinHeight.Size = New System.Drawing.Size(50, 27)
        Me.textBoxMinHeight.TabIndex = 6
        Me.textBoxMinHeight.Text = "kryptonTextBox3"
        Me.textBoxDocsTitle.Location = New System.Drawing.Point(219, 50)
        Me.textBoxDocsTitle.Name = "textBoxDocsTitle"
        Me.textBoxDocsTitle.Size = New System.Drawing.Size(141, 27)
        Me.textBoxDocsTitle.TabIndex = 1
        Me.textBoxDocsTitle.Text = "kryptonTextBox1"
        Me.kryptonLabel3.Location = New System.Drawing.Point(18, 100)
        Me.kryptonLabel3.Name = "kryptonLabel3"
        Me.kryptonLabel3.Size = New System.Drawing.Size(177, 24)
        Me.kryptonLabel3.TabIndex = 5
        Me.kryptonLabel3.Values.Text = "Recent Docs Min Height"
        Me.kryptonLabel1.Location = New System.Drawing.Point(53, 50)
        Me.kryptonLabel1.Name = "kryptonLabel1"
        Me.kryptonLabel1.Size = New System.Drawing.Size(129, 24)
        Me.kryptonLabel1.TabIndex = 2
        Me.kryptonLabel1.Values.Text = "Recent Docs Title"
        Me.kryptonLabel2.Location = New System.Drawing.Point(21, 75)
        Me.kryptonLabel2.Name = "kryptonLabel2"
        Me.kryptonLabel2.Size = New System.Drawing.Size(172, 24)
        Me.kryptonLabel2.TabIndex = 4
        Me.kryptonLabel2.Values.Text = "Recent Docs Min Width"
        Me.textBoxMinWidth.Location = New System.Drawing.Point(219, 75)
        Me.textBoxMinWidth.Name = "textBoxMinWidth"
        Me.textBoxMinWidth.Size = New System.Drawing.Size(50, 27)
        Me.textBoxMinWidth.TabIndex = 3
        Me.textBoxMinWidth.Text = "kryptonTextBox2"
        Me.buttonSpecAny1.Edge = Krypton.Toolkit.PaletteRelativeEdgeAlign.Near
        Me.buttonSpecAny1.Text = "LeftBS"
        Me.buttonSpecAny1.UniqueName = "9032d55c1153486497128fa04e9a4cc7"
        Me.buttonSpecAny2.Edge = Krypton.Toolkit.PaletteRelativeEdgeAlign.Far
        Me.buttonSpecAny2.Text = "RightBS"
        Me.buttonSpecAny2.UniqueName = "2dec0bdfa0a643b6843b1b4f21405ca2"
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8F, 17F)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ButtonSpecs.Add(Me.buttonSpecAny1)
        Me.ButtonSpecs.Add(Me.buttonSpecAny2)
        Me.ClientSize = New System.Drawing.Size(531, 440)
        Me.CloseBox = False
        Me.Controls.Add(Me.kryptonPanel1)
        Me.Controls.Add(Me.kryptonRibbon1)
        Me.Font = New System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.Name = "Form1"
        Me.ShowIcon = False
        Me.Text = "Application Menu"
        CType(Me.kryptonRibbon1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.kryptonPanel1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.kryptonPanel1.ResumeLayout(False)
        CType(Me.kryptonGroup1.Panel, System.ComponentModel.ISupportInitialize).EndInit()
        Me.kryptonGroup1.Panel.ResumeLayout(False)
        Me.kryptonGroup1.Panel.PerformLayout()
        CType(Me.kryptonGroup1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.kryptonGroup1.ResumeLayout(False)
        Me.ResumeLayout(False)
        Me.PerformLayout()
    End Sub

    Friend WithEvents kryptonRibbon1 As Krypton.Ribbon.KryptonRibbon
    Friend WithEvents kryptonManager1 As Krypton.Toolkit.KryptonManager
    Friend WithEvents kryptonPanel1 As Krypton.Toolkit.KryptonPanel
    Friend WithEvents checkBoxShowRecentDocs As Krypton.Toolkit.KryptonCheckBox
    Friend WithEvents kryptonLabel2 As Krypton.Toolkit.KryptonLabel
    Friend WithEvents textBoxMinWidth As Krypton.Toolkit.KryptonTextBox
    Friend WithEvents kryptonLabel1 As Krypton.Toolkit.KryptonLabel
    Friend WithEvents textBoxDocsTitle As Krypton.Toolkit.KryptonTextBox
    Friend WithEvents textBoxMinHeight As Krypton.Toolkit.KryptonTextBox
    Friend WithEvents kryptonLabel3 As Krypton.Toolkit.KryptonLabel
    Friend WithEvents kryptonRibbonRecentDoc1 As Krypton.Ribbon.KryptonRibbonRecentDoc
    Friend WithEvents kryptonRibbonRecentDoc2 As Krypton.Ribbon.KryptonRibbonRecentDoc
    Friend WithEvents kryptonRibbonRecentDoc3 As Krypton.Ribbon.KryptonRibbonRecentDoc
    Friend WithEvents kryptonRibbonRecentDoc4 As Krypton.Ribbon.KryptonRibbonRecentDoc
    Friend WithEvents kryptonContextMenuItem1 As Krypton.Toolkit.KryptonContextMenuItem
    Friend WithEvents kryptonContextMenuItem2 As Krypton.Toolkit.KryptonContextMenuItem
    Friend WithEvents kryptonContextMenuItem3 As Krypton.Toolkit.KryptonContextMenuItem
    Friend WithEvents kryptonContextMenuItem4 As Krypton.Toolkit.KryptonContextMenuItem
    Friend WithEvents kryptonContextMenuSeparator1 As Krypton.Toolkit.KryptonContextMenuSeparator
    Friend WithEvents kryptonContextMenuItem5 As Krypton.Toolkit.KryptonContextMenuItem
    Friend WithEvents buttonSpecAppMenu1 As Krypton.Ribbon.ButtonSpecAppMenu
    Friend WithEvents buttonSpecAppMenu2 As Krypton.Ribbon.ButtonSpecAppMenu
    Friend WithEvents kryptonRibbonTab1 As Krypton.Ribbon.KryptonRibbonTab
    Friend WithEvents kryptonRibbonGroup1 As Krypton.Ribbon.KryptonRibbonGroup
    Friend WithEvents kryptonRibbonGroupTriple1 As Krypton.Ribbon.KryptonRibbonGroupTriple
    Friend WithEvents buttonBlue As Krypton.Ribbon.KryptonRibbonGroupButton
    Friend WithEvents buttonSilver As Krypton.Ribbon.KryptonRibbonGroupButton
    Friend WithEvents buttonBlack As Krypton.Ribbon.KryptonRibbonGroupButton
    Friend WithEvents kryptonRibbonGroupTriple2 As Krypton.Ribbon.KryptonRibbonGroupTriple
    Friend WithEvents button2003 As Krypton.Ribbon.KryptonRibbonGroupButton
    Friend WithEvents buttonSystem As Krypton.Ribbon.KryptonRibbonGroupButton
    Friend WithEvents kryptonGroup1 As Krypton.Toolkit.KryptonGroup
    Friend WithEvents kryptonLabel5 As Krypton.Toolkit.KryptonLabel
    Friend WithEvents kryptonLabel4 As Krypton.Toolkit.KryptonLabel
    Friend WithEvents kryptonRibbonGroupSeparator1 As Krypton.Ribbon.KryptonRibbonGroupSeparator
    Friend WithEvents kryptonRibbonGroupTriple3 As Krypton.Ribbon.KryptonRibbonGroupTriple
    Friend WithEvents buttonSparkleBlue As Krypton.Ribbon.KryptonRibbonGroupButton
    Friend WithEvents buttonSparkleOrange As Krypton.Ribbon.KryptonRibbonGroupButton
    Friend WithEvents buttonSparklePurple As Krypton.Ribbon.KryptonRibbonGroupButton
    Friend WithEvents kryptonRibbonGroupSeparator2 As Krypton.Ribbon.KryptonRibbonGroupSeparator
    Friend WithEvents kryptonRibbonGroupTriple4 As Krypton.Ribbon.KryptonRibbonGroupTriple
    Friend WithEvents button2010Blue As Krypton.Ribbon.KryptonRibbonGroupButton
    Friend WithEvents button2010Silver As Krypton.Ribbon.KryptonRibbonGroupButton
    Friend WithEvents button2010Black As Krypton.Ribbon.KryptonRibbonGroupButton
    Friend WithEvents kryptonRibbonGroupSeparator3 As Krypton.Ribbon.KryptonRibbonGroupSeparator
    Friend WithEvents buttonSpecAny1 As Krypton.Toolkit.ButtonSpecAny
    Friend WithEvents buttonSpecAny2 As Krypton.Toolkit.ButtonSpecAny
End Class
