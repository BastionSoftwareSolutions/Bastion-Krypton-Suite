' VB.NET twin of Source\Krypton Ribbon Examples\Ribbon ToolTips\Form1.Designer.cs (Bastion Phase 4c).
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
        Me.qatSave = New Krypton.Ribbon.KryptonRibbonQATButton()
        Me.qatUndo = New Krypton.Ribbon.KryptonRibbonQATButton()
        Me.qatRedo = New Krypton.Ribbon.KryptonRibbonQATButton()
        Me.kryptonContextMenuItem1 = New Krypton.Toolkit.KryptonContextMenuItem()
        Me.tabHome = New Krypton.Ribbon.KryptonRibbonTab()
        Me.kryptonRibbonGroup1 = New Krypton.Ribbon.KryptonRibbonGroup()
        Me.kryptonRibbonGroupTriple1 = New Krypton.Ribbon.KryptonRibbonGroupTriple()
        Me.kryptonRibbonGroupButton1 = New Krypton.Ribbon.KryptonRibbonGroupButton()
        Me.cmsPaste = New System.Windows.Forms.ContextMenuStrip(Me.components)
        Me.pasteToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.pasteSpecialToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.kryptonRibbonGroupTriple2 = New Krypton.Ribbon.KryptonRibbonGroupTriple()
        Me.kryptonRibbonGroupButton2 = New Krypton.Ribbon.KryptonRibbonGroupButton()
        Me.kryptonRibbonGroupButton3 = New Krypton.Ribbon.KryptonRibbonGroupButton()
        Me.kryptonRibbonGroupButton4 = New Krypton.Ribbon.KryptonRibbonGroupButton()
        Me.kryptonRibbonGroup2 = New Krypton.Ribbon.KryptonRibbonGroup()
        Me.kryptonRibbonGroupTriple3 = New Krypton.Ribbon.KryptonRibbonGroupTriple()
        Me.kryptonRibbonGroupButton5 = New Krypton.Ribbon.KryptonRibbonGroupButton()
        Me.kryptonRibbonGroupButton7 = New Krypton.Ribbon.KryptonRibbonGroupButton()
        Me.kryptonRibbonGroupTriple4 = New Krypton.Ribbon.KryptonRibbonGroupTriple()
        Me.kryptonRibbonGroupButton6 = New Krypton.Ribbon.KryptonRibbonGroupButton()
        Me.cmsBusinessCards = New System.Windows.Forms.ContextMenuStrip(Me.components)
        Me.otherBusinessCardsToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.kryptonRibbonGroupButton8 = New Krypton.Ribbon.KryptonRibbonGroupButton()
        Me.kryptonRibbonGroupButton9 = New Krypton.Ribbon.KryptonRibbonGroupButton()
        Me.cmsSignatures = New System.Windows.Forms.ContextMenuStrip(Me.components)
        Me.signaturesToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.kryptonRibbonGroupLines1 = New Krypton.Ribbon.KryptonRibbonGroupLines()
        Me.kryptonRibbonGroupNumericUpDown1 = New Krypton.Ribbon.KryptonRibbonGroupNumericUpDown()
        Me.kryptonRibbonGroupComboBox1 = New Krypton.Ribbon.KryptonRibbonGroupComboBox()
        Me.kryptonRibbonTab1 = New Krypton.Ribbon.KryptonRibbonTab()
        Me.kryptonPanel = New Krypton.Toolkit.KryptonPanel()
        Me.kryptonLabel = New Krypton.Toolkit.KryptonLabel()
        Me.kryptonManager = New Krypton.Toolkit.KryptonManager(Me.components)
        CType(Me.kryptonRibbon1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.cmsPaste.SuspendLayout()
        Me.cmsBusinessCards.SuspendLayout()
        Me.cmsSignatures.SuspendLayout()
        CType(Me.kryptonPanel, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.kryptonPanel.SuspendLayout()
        Me.SuspendLayout()
        Me.kryptonRibbon1.HideRibbonSize = New System.Drawing.Size(300, 150)
        Me.kryptonRibbon1.InDesignHelperMode = True
        Me.kryptonRibbon1.Name = "kryptonRibbon1"
        Me.kryptonRibbon1.QATButtons.AddRange(New System.ComponentModel.Component() { Me.qatSave, Me.qatUndo, Me.qatRedo})
        Me.kryptonRibbon1.RibbonFileAppButton.AppButtonMenuItems.AddRange(New Krypton.Toolkit.KryptonContextMenuItemBase() { Me.kryptonContextMenuItem1})
        Me.kryptonRibbon1.RibbonFileAppButton.AppButtonShowRecentDocs = False
        Me.kryptonRibbon1.RibbonFileAppButton.AppButtonToolTipBody = " Click here to open, save, or print," & vbCrLf & " and to see everything else you can" & vbCrLf & " do" & " with your document."
        Me.kryptonRibbon1.RibbonFileAppButton.AppButtonToolTipTitle = "Office Button"
        Me.kryptonRibbon1.RibbonTabs.AddRange(New Krypton.Ribbon.KryptonRibbonTab() { Me.tabHome, Me.kryptonRibbonTab1})
        Me.kryptonRibbon1.SelectedTab = Me.tabHome
        Me.kryptonRibbon1.Size = New System.Drawing.Size(1013, 136)
        Me.kryptonRibbon1.StateContextTracking.RibbonGroupArea.BackColor1 = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(192, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.kryptonRibbon1.StateContextTracking.RibbonGroupArea.BackColor2 = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(192, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.kryptonRibbon1.StateContextTracking.RibbonGroupArea.BackColor3 = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(192, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.kryptonRibbon1.StateContextTracking.RibbonGroupArea.BackColor4 = System.Drawing.Color.Empty
        Me.kryptonRibbon1.StateContextTracking.RibbonGroupArea.BackColor5 = System.Drawing.Color.Empty
        Me.kryptonRibbon1.StateContextTracking.RibbonGroupNormalTitle.BackColor1 = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(192, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.kryptonRibbon1.StateContextTracking.RibbonGroupNormalTitle.BackColor2 = System.Drawing.Color.Empty
        Me.kryptonRibbon1.StateContextTracking.RibbonGroupNormalTitle.BackColor3 = System.Drawing.Color.Empty
        Me.kryptonRibbon1.StateContextTracking.RibbonGroupNormalTitle.BackColor4 = System.Drawing.Color.Empty
        Me.kryptonRibbon1.StateContextTracking.RibbonGroupNormalTitle.BackColor5 = System.Drawing.Color.Empty
        Me.kryptonRibbon1.StateContextTracking.RibbonGroupNormalTitle.TextColor = System.Drawing.Color.Empty
        Me.kryptonRibbon1.StateContextTracking.RibbonTab.BackColor1 = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(192, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.kryptonRibbon1.StateContextTracking.RibbonTab.BackColor2 = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(192, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.kryptonRibbon1.StateContextTracking.RibbonTab.BackColor3 = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(192, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.kryptonRibbon1.StateContextTracking.RibbonTab.BackColor4 = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(192, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.kryptonRibbon1.StateContextTracking.RibbonTab.BackColor5 = System.Drawing.Color.Empty
        Me.kryptonRibbon1.StateContextTracking.RibbonTab.TextColor = System.Drawing.Color.Empty
        Me.kryptonRibbon1.StateTracking.RibbonGroupNormalTitle.BackColor1 = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(192, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.kryptonRibbon1.StateTracking.RibbonGroupNormalTitle.BackColor2 = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(192, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.kryptonRibbon1.StateTracking.RibbonGroupNormalTitle.BackColor3 = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(192, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.kryptonRibbon1.StateTracking.RibbonGroupNormalTitle.BackColor4 = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(192, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.kryptonRibbon1.StateTracking.RibbonGroupNormalTitle.BackColor5 = System.Drawing.Color.Empty
        Me.kryptonRibbon1.StateTracking.RibbonGroupNormalTitle.TextColor = System.Drawing.Color.Empty
        Me.kryptonRibbon1.TabIndex = 0
        Me.qatSave.Image = CType(resources.GetObject("qatSave.Image"), System.Drawing.Image)
        Me.qatSave.Text = "Save"
        Me.qatSave.ToolTipBody = "Save (Ctrl + S)"
        Me.qatUndo.Image = CType(resources.GetObject("qatUndo.Image"), System.Drawing.Image)
        Me.qatUndo.Text = "Undo"
        Me.qatUndo.ToolTipBody = "Undo (Ctrl + Z)"
        Me.qatRedo.Image = CType(resources.GetObject("qatRedo.Image"), System.Drawing.Image)
        Me.qatRedo.Text = "Redo"
        Me.qatRedo.ToolTipBody = "Redo (Ctrl + Y)"
        Me.kryptonContextMenuItem1.Image = CType(resources.GetObject("kryptonContextMenuItem1.Image"), System.Drawing.Image)
        Me.kryptonContextMenuItem1.Text = "E&xit"
        Me.tabHome.Groups.AddRange(New Krypton.Ribbon.KryptonRibbonGroup() { Me.kryptonRibbonGroup1, Me.kryptonRibbonGroup2})
        Me.tabHome.KeyTip = "H"
        Me.tabHome.Text = "Home"
        Me.kryptonRibbonGroup1.AllowCollapsed = False
        Me.kryptonRibbonGroup1.DialogBoxLauncher = False
        Me.kryptonRibbonGroup1.Image = CType(resources.GetObject("kryptonRibbonGroup1.Image"), System.Drawing.Image)
        Me.kryptonRibbonGroup1.Items.AddRange(New Krypton.Ribbon.KryptonRibbonGroupContainer() { Me.kryptonRibbonGroupTriple1, Me.kryptonRibbonGroupTriple2})
        Me.kryptonRibbonGroup1.KeyTipDialogLauncher = "FO"
        Me.kryptonRibbonGroup1.TextLine1 = "Clipboard"
        Me.kryptonRibbonGroupTriple1.Items.AddRange(New Krypton.Ribbon.KryptonRibbonGroupItem() { Me.kryptonRibbonGroupButton1})
        Me.kryptonRibbonGroupButton1.ButtonType = Krypton.Ribbon.GroupButtonType.Split
        Me.kryptonRibbonGroupButton1.ContextMenuStrip = Me.cmsPaste
        Me.kryptonRibbonGroupButton1.ImageLarge = CType(resources.GetObject("kryptonRibbonGroupButton1.ImageLarge"), System.Drawing.Image)
        Me.kryptonRibbonGroupButton1.ImageSmall = CType(resources.GetObject("kryptonRibbonGroupButton1.ImageSmall"), System.Drawing.Image)
        Me.kryptonRibbonGroupButton1.KeyTip = "V"
        Me.kryptonRibbonGroupButton1.ShortcutKeys = CType((System.Windows.Forms.Keys.Control Or System.Windows.Forms.Keys.V), System.Windows.Forms.Keys)
        Me.kryptonRibbonGroupButton1.TextLine1 = "Paste"
        Me.kryptonRibbonGroupButton1.ToolTipValues.Description = " Paste the contents of the" & vbCrLf & " Clipboard."
        Me.kryptonRibbonGroupButton1.ToolTipValues.EnableToolTips = True
        Me.kryptonRibbonGroupButton1.ToolTipValues.Heading = "Paste (Ctrl + V)"
        Me.cmsPaste.Font = New System.Drawing.Font("Segoe UI", 8.25F)
        Me.cmsPaste.ImageScalingSize = New System.Drawing.Size(20, 20)
        Me.cmsPaste.Items.AddRange(New System.Windows.Forms.ToolStripItem() { Me.pasteToolStripMenuItem, Me.pasteSpecialToolStripMenuItem})
        Me.cmsPaste.Name = "cmsPaste"
        Me.cmsPaste.Size = New System.Drawing.Size(157, 52)
        Me.pasteToolStripMenuItem.Name = "pasteToolStripMenuItem"
        Me.pasteToolStripMenuItem.Size = New System.Drawing.Size(156, 24)
        Me.pasteToolStripMenuItem.Text = "Paste"
        Me.pasteToolStripMenuItem.ToolTipText = "Test Tooltip"
        Me.pasteSpecialToolStripMenuItem.Name = "pasteSpecialToolStripMenuItem"
        Me.pasteSpecialToolStripMenuItem.Size = New System.Drawing.Size(156, 24)
        Me.pasteSpecialToolStripMenuItem.Text = "Paste Special"
        Me.kryptonRibbonGroupTriple2.Items.AddRange(New Krypton.Ribbon.KryptonRibbonGroupItem() { Me.kryptonRibbonGroupButton2, Me.kryptonRibbonGroupButton3, Me.kryptonRibbonGroupButton4})
        Me.kryptonRibbonGroupTriple2.MaximumSize = Krypton.Ribbon.GroupItemSize.Medium
        Me.kryptonRibbonGroupButton2.ImageLarge = CType(resources.GetObject("kryptonRibbonGroupButton2.ImageLarge"), System.Drawing.Image)
        Me.kryptonRibbonGroupButton2.ImageSmall = CType(resources.GetObject("kryptonRibbonGroupButton2.ImageSmall"), System.Drawing.Image)
        Me.kryptonRibbonGroupButton2.KeyTip = "X"
        Me.kryptonRibbonGroupButton2.ShortcutKeys = CType((System.Windows.Forms.Keys.Control Or System.Windows.Forms.Keys.X), System.Windows.Forms.Keys)
        Me.kryptonRibbonGroupButton2.TextLine1 = "Cut"
        Me.kryptonRibbonGroupButton2.ToolTipValues.Description = " Cut the selection from the" & vbCrLf & " document and put it on the" & vbCrLf & " Clipboard."
        Me.kryptonRibbonGroupButton2.ToolTipValues.EnableToolTips = True
        Me.kryptonRibbonGroupButton2.ToolTipValues.Heading = "Cut (Ctrl + X)"
        Me.kryptonRibbonGroupButton3.ImageLarge = CType(resources.GetObject("kryptonRibbonGroupButton3.ImageLarge"), System.Drawing.Image)
        Me.kryptonRibbonGroupButton3.ImageSmall = CType(resources.GetObject("kryptonRibbonGroupButton3.ImageSmall"), System.Drawing.Image)
        Me.kryptonRibbonGroupButton3.KeyTip = "C"
        Me.kryptonRibbonGroupButton3.ShortcutKeys = CType((System.Windows.Forms.Keys.Control Or System.Windows.Forms.Keys.C), System.Windows.Forms.Keys)
        Me.kryptonRibbonGroupButton3.TextLine1 = "Copy"
        Me.kryptonRibbonGroupButton3.ToolTipValues.Description = " Copy the selection and put it on" & vbCrLf & " the Clipboard."
        Me.kryptonRibbonGroupButton3.ToolTipValues.EnableToolTips = True
        Me.kryptonRibbonGroupButton3.ToolTipValues.Heading = "Copy (Ctrl + C)"
        Me.kryptonRibbonGroupButton4.ImageLarge = CType(resources.GetObject("kryptonRibbonGroupButton4.ImageLarge"), System.Drawing.Image)
        Me.kryptonRibbonGroupButton4.ImageSmall = CType(resources.GetObject("kryptonRibbonGroupButton4.ImageSmall"), System.Drawing.Image)
        Me.kryptonRibbonGroupButton4.KeyTip = "FP"
        Me.kryptonRibbonGroupButton4.TextLine1 = "Format"
        Me.kryptonRibbonGroupButton4.TextLine2 = "Painter"
        Me.kryptonRibbonGroupButton4.ToolTipValues.Description = " Copy formatting from one place" & vbCrLf & " and apply it to another." & vbCrLf & vbCrLf & " Double-click th" & "is button to apply" & vbCrLf & " the same formatting to multiple" & vbCrLf & " places in the document." & ""
        Me.kryptonRibbonGroupButton4.ToolTipValues.EnableToolTips = True
        Me.kryptonRibbonGroupButton4.ToolTipValues.Heading = "Format Painter"
        Me.kryptonRibbonGroup2.AllowCollapsed = False
        Me.kryptonRibbonGroup2.DialogBoxLauncher = False
        Me.kryptonRibbonGroup2.Image = CType(resources.GetObject("kryptonRibbonGroup2.Image"), System.Drawing.Image)
        Me.kryptonRibbonGroup2.Items.AddRange(New Krypton.Ribbon.KryptonRibbonGroupContainer() { Me.kryptonRibbonGroupTriple3, Me.kryptonRibbonGroupTriple4, Me.kryptonRibbonGroupLines1})
        Me.kryptonRibbonGroup2.KeyTipDialogLauncher = "AP"
        Me.kryptonRibbonGroup2.KeyTipGroup = "ZC"
        Me.kryptonRibbonGroup2.TextLine1 = "Include"
        Me.kryptonRibbonGroupTriple3.Items.AddRange(New Krypton.Ribbon.KryptonRibbonGroupItem() { Me.kryptonRibbonGroupButton5, Me.kryptonRibbonGroupButton7})
        Me.kryptonRibbonGroupButton5.ImageLarge = CType(resources.GetObject("kryptonRibbonGroupButton5.ImageLarge"), System.Drawing.Image)
        Me.kryptonRibbonGroupButton5.ImageSmall = CType(resources.GetObject("kryptonRibbonGroupButton5.ImageSmall"), System.Drawing.Image)
        Me.kryptonRibbonGroupButton5.KeyTip = "AF"
        Me.kryptonRibbonGroupButton5.TextLine1 = "Attach"
        Me.kryptonRibbonGroupButton5.TextLine2 = "File"
        Me.kryptonRibbonGroupButton5.ToolTipValues.Description = "Attach a file to this item."
        Me.kryptonRibbonGroupButton5.ToolTipValues.EnableToolTips = True
        Me.kryptonRibbonGroupButton5.ToolTipValues.Heading = "Attach File"
        Me.kryptonRibbonGroupButton5.ToolTipValues.Image = CType(resources.GetObject("kryptonRibbonGroupButton5.ToolTipValues.Image"), System.Drawing.Image)
        Me.kryptonRibbonGroupButton7.ImageLarge = CType(resources.GetObject("kryptonRibbonGroupButton7.ImageLarge"), System.Drawing.Image)
        Me.kryptonRibbonGroupButton7.ImageSmall = CType(resources.GetObject("kryptonRibbonGroupButton7.ImageSmall"), System.Drawing.Image)
        Me.kryptonRibbonGroupButton7.KeyTip = "AM"
        Me.kryptonRibbonGroupButton7.TextLine1 = "Attach"
        Me.kryptonRibbonGroupButton7.TextLine2 = "Item"
        Me.kryptonRibbonGroupButton7.ToolTipValues.Description = " Attach another Outlook item to" & vbCrLf & " this item."
        Me.kryptonRibbonGroupButton7.ToolTipValues.EnableToolTips = True
        Me.kryptonRibbonGroupButton7.ToolTipValues.Heading = "Attach Item"
        Me.kryptonRibbonGroupButton7.ToolTipValues.Image = CType(resources.GetObject("kryptonRibbonGroupButton7.ToolTipValues.Image"), System.Drawing.Image)
        Me.kryptonRibbonGroupTriple4.Items.AddRange(New Krypton.Ribbon.KryptonRibbonGroupItem() { Me.kryptonRibbonGroupButton6, Me.kryptonRibbonGroupButton8, Me.kryptonRibbonGroupButton9})
        Me.kryptonRibbonGroupButton6.ButtonType = Krypton.Ribbon.GroupButtonType.DropDown
        Me.kryptonRibbonGroupButton6.ContextMenuStrip = Me.cmsBusinessCards
        Me.kryptonRibbonGroupButton6.ImageLarge = CType(resources.GetObject("kryptonRibbonGroupButton6.ImageLarge"), System.Drawing.Image)
        Me.kryptonRibbonGroupButton6.ImageSmall = CType(resources.GetObject("kryptonRibbonGroupButton6.ImageSmall"), System.Drawing.Image)
        Me.kryptonRibbonGroupButton6.KeyTip = "AA"
        Me.kryptonRibbonGroupButton6.TextLine1 = "Business"
        Me.kryptonRibbonGroupButton6.TextLine2 = "Card"
        Me.kryptonRibbonGroupButton6.ToolTipValues.Description = " Attach an electronic business card" & vbCrLf & " to this message."
        Me.kryptonRibbonGroupButton6.ToolTipValues.EnableToolTips = True
        Me.kryptonRibbonGroupButton6.ToolTipValues.Heading = "Insert Business Card"
        Me.kryptonRibbonGroupButton6.ToolTipValues.Image = CType(resources.GetObject("kryptonRibbonGroupButton6.ToolTipValues.Image"), System.Drawing.Image)
        Me.cmsBusinessCards.Font = New System.Drawing.Font("Segoe UI", 8.25F)
        Me.cmsBusinessCards.ImageScalingSize = New System.Drawing.Size(20, 20)
        Me.cmsBusinessCards.Items.AddRange(New System.Windows.Forms.ToolStripItem() { Me.otherBusinessCardsToolStripMenuItem})
        Me.cmsBusinessCards.Name = "cmsBusinessCards"
        Me.cmsBusinessCards.Size = New System.Drawing.Size(219, 28)
        Me.otherBusinessCardsToolStripMenuItem.Name = "otherBusinessCardsToolStripMenuItem"
        Me.otherBusinessCardsToolStripMenuItem.Size = New System.Drawing.Size(218, 24)
        Me.otherBusinessCardsToolStripMenuItem.Text = "Other Business Cards..."
        Me.kryptonRibbonGroupButton8.ImageLarge = CType(resources.GetObject("kryptonRibbonGroupButton8.ImageLarge"), System.Drawing.Image)
        Me.kryptonRibbonGroupButton8.ImageSmall = CType(resources.GetObject("kryptonRibbonGroupButton8.ImageSmall"), System.Drawing.Image)
        Me.kryptonRibbonGroupButton8.KeyTip = "OC"
        Me.kryptonRibbonGroupButton8.TextLine1 = "Calendar"
        Me.kryptonRibbonGroupButton8.ToolTipValues.Description = " Attach your calendar information" & vbCrLf & " to this message."
        Me.kryptonRibbonGroupButton8.ToolTipValues.EnableToolTips = True
        Me.kryptonRibbonGroupButton8.ToolTipValues.Heading = "Insert Calendar"
        Me.kryptonRibbonGroupButton8.ToolTipValues.Image = CType(resources.GetObject("kryptonRibbonGroupButton8.ToolTipValues.Image"), System.Drawing.Image)
        Me.kryptonRibbonGroupButton9.ButtonType = Krypton.Ribbon.GroupButtonType.DropDown
        Me.kryptonRibbonGroupButton9.ContextMenuStrip = Me.cmsSignatures
        Me.kryptonRibbonGroupButton9.ImageLarge = CType(resources.GetObject("kryptonRibbonGroupButton9.ImageLarge"), System.Drawing.Image)
        Me.kryptonRibbonGroupButton9.ImageSmall = CType(resources.GetObject("kryptonRibbonGroupButton9.ImageSmall"), System.Drawing.Image)
        Me.kryptonRibbonGroupButton9.KeyTip = "G"
        Me.kryptonRibbonGroupButton9.TextLine1 = "Signature"
        Me.kryptonRibbonGroupButton9.ToolTipValues.Description = " Attach one of your e-mail" & vbCrLf & " signatures to this message."
        Me.kryptonRibbonGroupButton9.ToolTipValues.EnableToolTips = True
        Me.kryptonRibbonGroupButton9.ToolTipValues.Heading = "Signature"
        Me.kryptonRibbonGroupButton9.ToolTipValues.Image = CType(resources.GetObject("kryptonRibbonGroupButton9.ToolTipValues.Image"), System.Drawing.Image)
        Me.cmsSignatures.Font = New System.Drawing.Font("Segoe UI", 8.25F)
        Me.cmsSignatures.ImageScalingSize = New System.Drawing.Size(20, 20)
        Me.cmsSignatures.Items.AddRange(New System.Windows.Forms.ToolStripItem() { Me.signaturesToolStripMenuItem})
        Me.cmsSignatures.Name = "cmsSignatures"
        Me.cmsSignatures.Size = New System.Drawing.Size(152, 28)
        Me.signaturesToolStripMenuItem.Name = "signaturesToolStripMenuItem"
        Me.signaturesToolStripMenuItem.Size = New System.Drawing.Size(151, 24)
        Me.signaturesToolStripMenuItem.Text = "Signatures..."
        Me.kryptonRibbonGroupLines1.Items.AddRange(New Krypton.Ribbon.KryptonRibbonGroupItem() { Me.kryptonRibbonGroupNumericUpDown1, Me.kryptonRibbonGroupComboBox1})
        Me.kryptonRibbonGroupNumericUpDown1.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        Me.kryptonRibbonGroupNumericUpDown1.ToolTipValues.Description = "asdafdas"
        Me.kryptonRibbonGroupNumericUpDown1.ToolTipValues.EnableToolTips = True
        Me.kryptonRibbonGroupNumericUpDown1.ToolTipValues.Heading = ""
        Me.kryptonRibbonGroupComboBox1.DropDownWidth = 121
        Me.kryptonRibbonGroupComboBox1.FormattingEnabled = False
        Me.kryptonRibbonGroupComboBox1.ItemHeight = 20
        Me.kryptonRibbonGroupComboBox1.Text = "kryptonRibbonGroupComboBox1"
        Me.kryptonRibbonGroupComboBox1.ToolTipValues.EnableToolTips = True
        Me.kryptonPanel.Controls.Add(Me.kryptonLabel)
        Me.kryptonPanel.Dock = System.Windows.Forms.DockStyle.Fill
        Me.kryptonPanel.Location = New System.Drawing.Point(0, 136)
        Me.kryptonPanel.Margin = New System.Windows.Forms.Padding(4)
        Me.kryptonPanel.Name = "kryptonPanel"
        Me.kryptonPanel.Size = New System.Drawing.Size(1013, 228)
        Me.kryptonPanel.TabIndex = 1
        Me.kryptonLabel.Location = New System.Drawing.Point(16, 17)
        Me.kryptonLabel.Margin = New System.Windows.Forms.Padding(4)
        Me.kryptonLabel.Name = "kryptonLabel"
        Me.kryptonLabel.Size = New System.Drawing.Size(486, 164)
        Me.kryptonLabel.TabIndex = 0
        Me.kryptonLabel.Values.Text = resources.GetString("kryptonLabel.Values.Text")
        Me.kryptonManager.GlobalPaletteMode = Krypton.Toolkit.PaletteMode.Office2007Black
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8F, 16F)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(1013, 364)
        Me.CloseBox = False
        Me.Controls.Add(Me.kryptonPanel)
        Me.Controls.Add(Me.kryptonRibbon1)
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.Margin = New System.Windows.Forms.Padding(4)
        Me.Name = "Form1"
        Me.Text = "Ribbon ToolTips"
        CType(Me.kryptonRibbon1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.cmsPaste.ResumeLayout(False)
        Me.cmsBusinessCards.ResumeLayout(False)
        Me.cmsSignatures.ResumeLayout(False)
        CType(Me.kryptonPanel, System.ComponentModel.ISupportInitialize).EndInit()
        Me.kryptonPanel.ResumeLayout(False)
        Me.kryptonPanel.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()
    End Sub

    Friend WithEvents kryptonRibbon1 As Krypton.Ribbon.KryptonRibbon
    Friend WithEvents tabHome As Krypton.Ribbon.KryptonRibbonTab
    Friend WithEvents kryptonPanel As Krypton.Toolkit.KryptonPanel
    Friend WithEvents kryptonRibbonGroup1 As Krypton.Ribbon.KryptonRibbonGroup
    Friend WithEvents kryptonRibbonGroupTriple1 As Krypton.Ribbon.KryptonRibbonGroupTriple
    Friend WithEvents kryptonRibbonGroupButton1 As Krypton.Ribbon.KryptonRibbonGroupButton
    Friend WithEvents kryptonRibbonGroupTriple2 As Krypton.Ribbon.KryptonRibbonGroupTriple
    Friend WithEvents kryptonRibbonGroupButton2 As Krypton.Ribbon.KryptonRibbonGroupButton
    Friend WithEvents kryptonRibbonGroupButton3 As Krypton.Ribbon.KryptonRibbonGroupButton
    Friend WithEvents kryptonRibbonGroupButton4 As Krypton.Ribbon.KryptonRibbonGroupButton
    Friend WithEvents kryptonRibbonGroup2 As Krypton.Ribbon.KryptonRibbonGroup
    Friend WithEvents kryptonRibbonGroupTriple3 As Krypton.Ribbon.KryptonRibbonGroupTriple
    Friend WithEvents kryptonRibbonGroupButton5 As Krypton.Ribbon.KryptonRibbonGroupButton
    Friend WithEvents kryptonRibbonGroupButton7 As Krypton.Ribbon.KryptonRibbonGroupButton
    Friend WithEvents kryptonRibbonGroupTriple4 As Krypton.Ribbon.KryptonRibbonGroupTriple
    Friend WithEvents kryptonRibbonGroupButton6 As Krypton.Ribbon.KryptonRibbonGroupButton
    Friend WithEvents kryptonRibbonGroupButton8 As Krypton.Ribbon.KryptonRibbonGroupButton
    Friend WithEvents kryptonRibbonGroupButton9 As Krypton.Ribbon.KryptonRibbonGroupButton
    Friend WithEvents cmsPaste As System.Windows.Forms.ContextMenuStrip
    Friend WithEvents pasteToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents pasteSpecialToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents cmsBusinessCards As System.Windows.Forms.ContextMenuStrip
    Friend WithEvents otherBusinessCardsToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents cmsSignatures As System.Windows.Forms.ContextMenuStrip
    Friend WithEvents signaturesToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents qatSave As Krypton.Ribbon.KryptonRibbonQATButton
    Friend WithEvents qatUndo As Krypton.Ribbon.KryptonRibbonQATButton
    Friend WithEvents qatRedo As Krypton.Ribbon.KryptonRibbonQATButton
    Friend WithEvents kryptonLabel As Krypton.Toolkit.KryptonLabel
    Friend WithEvents kryptonManager As Krypton.Toolkit.KryptonManager
    Friend WithEvents kryptonContextMenuItem1 As Krypton.Toolkit.KryptonContextMenuItem
    Friend WithEvents kryptonRibbonGroupLines1 As Krypton.Ribbon.KryptonRibbonGroupLines
    Friend WithEvents kryptonRibbonGroupNumericUpDown1 As Krypton.Ribbon.KryptonRibbonGroupNumericUpDown
    Friend WithEvents kryptonRibbonGroupComboBox1 As Krypton.Ribbon.KryptonRibbonGroupComboBox
    Friend WithEvents kryptonRibbonTab1 As Krypton.Ribbon.KryptonRibbonTab
End Class
