' VB.NET twin of Source\Krypton Ribbon Examples\Contextual Tabs\Form1.Designer.cs (Bastion Phase 4c).
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
        Me.contextDefRed = New Krypton.Ribbon.KryptonRibbonContext()
        Me.contextDefGreen = New Krypton.Ribbon.KryptonRibbonContext()
        Me.kryptonContextMenuItem1 = New Krypton.Toolkit.KryptonContextMenuItem()
        Me.tabHome = New Krypton.Ribbon.KryptonRibbonTab()
        Me.contextRed = New Krypton.Ribbon.KryptonRibbonTab()
        Me.contextGreen1 = New Krypton.Ribbon.KryptonRibbonTab()
        Me.contextGreen2 = New Krypton.Ribbon.KryptonRibbonTab()
        Me.labelOffice2007Styles = New Krypton.Toolkit.KryptonPanel()
        Me.groupOffice2007Styles = New Krypton.Toolkit.KryptonGroup()
        Me.radioOffice2010Black = New Krypton.Toolkit.KryptonRadioButton()
        Me.radioOffice2010Silver = New Krypton.Toolkit.KryptonRadioButton()
        Me.radioOffice2010Blue = New Krypton.Toolkit.KryptonRadioButton()
        Me.radioSparkleOrange = New Krypton.Toolkit.KryptonRadioButton()
        Me.radioSparklePurple = New Krypton.Toolkit.KryptonRadioButton()
        Me.radioSparkleBlue = New Krypton.Toolkit.KryptonRadioButton()
        Me.radioSystem = New Krypton.Toolkit.KryptonRadioButton()
        Me.radioOffice2003 = New Krypton.Toolkit.KryptonRadioButton()
        Me.radioOffice2007Black = New Krypton.Toolkit.KryptonRadioButton()
        Me.radioOffice2007Silver = New Krypton.Toolkit.KryptonRadioButton()
        Me.radioOffice2007Blue = New Krypton.Toolkit.KryptonRadioButton()
        Me.kryptonLabel2 = New Krypton.Toolkit.KryptonLabel()
        Me.groupAddContext = New Krypton.Toolkit.KryptonGroup()
        Me.buttonAddContext = New Krypton.Toolkit.KryptonButton()
        Me.panelContextColor = New Krypton.Toolkit.KryptonPanel()
        Me.buttonEditColor = New Krypton.Toolkit.KryptonButton()
        Me.labelContextColor = New Krypton.Toolkit.KryptonLabel()
        Me.textBoxContextTitle = New Krypton.Toolkit.KryptonTextBox()
        Me.labelContextTitle = New Krypton.Toolkit.KryptonLabel()
        Me.labelContextName = New Krypton.Toolkit.KryptonLabel()
        Me.textBoxContextName = New Krypton.Toolkit.KryptonTextBox()
        Me.kryptonLabel1 = New Krypton.Toolkit.KryptonLabel()
        Me.groupSelectedContexts = New Krypton.Toolkit.KryptonGroup()
        Me.labelSelectedContexts = New Krypton.Toolkit.KryptonLabel()
        Me.buttonSelectedApply = New Krypton.Toolkit.KryptonButton()
        Me.textBoxSelectedContexts = New Krypton.Toolkit.KryptonTextBox()
        Me.labelContextsInstructions = New Krypton.Toolkit.KryptonLabel()
        Me.colorDialog = New System.Windows.Forms.ColorDialog()
        Me.kryptonManager = New Krypton.Toolkit.KryptonManager(Me.components)
        CType(Me.kryptonRibbon, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.labelOffice2007Styles, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.labelOffice2007Styles.SuspendLayout()
        CType(Me.groupOffice2007Styles, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.groupOffice2007Styles.Panel, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.groupOffice2007Styles.Panel.SuspendLayout()
        Me.groupOffice2007Styles.SuspendLayout()
        CType(Me.groupAddContext, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.groupAddContext.Panel, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.groupAddContext.Panel.SuspendLayout()
        Me.groupAddContext.SuspendLayout()
        CType(Me.panelContextColor, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.groupSelectedContexts, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.groupSelectedContexts.Panel, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.groupSelectedContexts.Panel.SuspendLayout()
        Me.groupSelectedContexts.SuspendLayout()
        Me.SuspendLayout()
        Me.kryptonRibbon.InDesignHelperMode = True
        Me.kryptonRibbon.Name = "kryptonRibbon"
        Me.kryptonRibbon.RibbonContexts.AddRange(New Krypton.Ribbon.KryptonRibbonContext() { Me.contextDefRed, Me.contextDefGreen})
        Me.kryptonRibbon.RibbonFileAppButton.AppButtonMenuItems.AddRange(New Krypton.Toolkit.KryptonContextMenuItemBase() { Me.kryptonContextMenuItem1})
        Me.kryptonRibbon.RibbonFileAppButton.AppButtonShowRecentDocs = False
        Me.kryptonRibbon.RibbonTabs.AddRange(New Krypton.Ribbon.KryptonRibbonTab() { Me.tabHome, Me.contextRed, Me.contextGreen1, Me.contextGreen2})
        Me.kryptonRibbon.SelectedContext = "Red,Green"
        Me.kryptonRibbon.SelectedTab = Me.contextGreen1
        Me.kryptonRibbon.Size = New System.Drawing.Size(651, 136)
        Me.kryptonRibbon.StateCommon.RibbonAppButton.BackColor1 = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(128, Byte), Integer), CType(CType(0, Byte), Integer))
        Me.kryptonRibbon.StateCommon.RibbonAppButton.BackColor2 = System.Drawing.Color.Yellow
        Me.kryptonRibbon.StateCommon.RibbonAppButton.BackColor3 = System.Drawing.Color.Lime
        Me.kryptonRibbon.StateCommon.RibbonAppButton.BackColor4 = System.Drawing.Color.FromArgb(CType(CType(128, Byte), Integer), CType(CType(128, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.kryptonRibbon.StateCommon.RibbonAppButton.BackColor5 = System.Drawing.Color.Fuchsia
        Me.kryptonRibbon.TabIndex = 0
        Me.contextDefRed.ContextName = "Red"
        Me.contextDefRed.ContextTitle = "Red"
        Me.contextDefGreen.ContextColor = System.Drawing.Color.LimeGreen
        Me.contextDefGreen.ContextName = "Green"
        Me.contextDefGreen.ContextTitle = "Green"
        Me.kryptonContextMenuItem1.Image = CType(resources.GetObject("kryptonContextMenuItem1.Image"), System.Drawing.Image)
        Me.kryptonContextMenuItem1.Text = "E&xit"
        Me.tabHome.Text = "Home"
        Me.contextRed.ContextName = "Red"
        Me.contextRed.Text = "Red"
        Me.contextGreen1.ContextName = "Green"
        Me.contextGreen1.Text = "Green1"
        Me.contextGreen2.ContextName = "Green"
        Me.contextGreen2.Text = "Green2"
        Me.labelOffice2007Styles.Controls.Add(Me.groupOffice2007Styles)
        Me.labelOffice2007Styles.Controls.Add(Me.groupAddContext)
        Me.labelOffice2007Styles.Controls.Add(Me.groupSelectedContexts)
        Me.labelOffice2007Styles.Dock = System.Windows.Forms.DockStyle.Fill
        Me.labelOffice2007Styles.Location = New System.Drawing.Point(0, 136)
        Me.labelOffice2007Styles.Name = "labelOffice2007Styles"
        Me.labelOffice2007Styles.Size = New System.Drawing.Size(651, 330)
        Me.labelOffice2007Styles.TabIndex = 1
        Me.groupOffice2007Styles.GroupBackStyle = Krypton.Toolkit.PaletteBackStyle.PanelAlternate
        Me.groupOffice2007Styles.Location = New System.Drawing.Point(448, 16)
        Me.groupOffice2007Styles.Name = "groupOffice2007Styles"
        Me.groupOffice2007Styles.Panel.Controls.Add(Me.radioOffice2010Black)
        Me.groupOffice2007Styles.Panel.Controls.Add(Me.radioOffice2010Silver)
        Me.groupOffice2007Styles.Panel.Controls.Add(Me.radioOffice2010Blue)
        Me.groupOffice2007Styles.Panel.Controls.Add(Me.radioSparkleOrange)
        Me.groupOffice2007Styles.Panel.Controls.Add(Me.radioSparklePurple)
        Me.groupOffice2007Styles.Panel.Controls.Add(Me.radioSparkleBlue)
        Me.groupOffice2007Styles.Panel.Controls.Add(Me.radioSystem)
        Me.groupOffice2007Styles.Panel.Controls.Add(Me.radioOffice2003)
        Me.groupOffice2007Styles.Panel.Controls.Add(Me.radioOffice2007Black)
        Me.groupOffice2007Styles.Panel.Controls.Add(Me.radioOffice2007Silver)
        Me.groupOffice2007Styles.Panel.Controls.Add(Me.radioOffice2007Blue)
        Me.groupOffice2007Styles.Panel.Controls.Add(Me.kryptonLabel2)
        Me.groupOffice2007Styles.Size = New System.Drawing.Size(180, 305)
        Me.groupOffice2007Styles.TabIndex = 0
        Me.radioOffice2010Black.Location = New System.Drawing.Point(20, 84)
        Me.radioOffice2010Black.Name = "radioOffice2010Black"
        Me.radioOffice2010Black.Size = New System.Drawing.Size(151, 24)
        Me.radioOffice2010Black.TabIndex = 3
        Me.radioOffice2010Black.Values.Text = "Office 2010 - Black"
        Me.radioOffice2010Silver.Location = New System.Drawing.Point(20, 61)
        Me.radioOffice2010Silver.Name = "radioOffice2010Silver"
        Me.radioOffice2010Silver.Size = New System.Drawing.Size(153, 24)
        Me.radioOffice2010Silver.TabIndex = 2
        Me.radioOffice2010Silver.Values.Text = "Office 2010 - Silver"
        Me.radioOffice2010Blue.Location = New System.Drawing.Point(20, 38)
        Me.radioOffice2010Blue.Name = "radioOffice2010Blue"
        Me.radioOffice2010Blue.Size = New System.Drawing.Size(145, 24)
        Me.radioOffice2010Blue.TabIndex = 1
        Me.radioOffice2010Blue.Values.Text = "Office 2010 - Blue"
        Me.radioSparkleOrange.Location = New System.Drawing.Point(20, 222)
        Me.radioSparkleOrange.Name = "radioSparkleOrange"
        Me.radioSparkleOrange.Size = New System.Drawing.Size(139, 24)
        Me.radioSparkleOrange.TabIndex = 9
        Me.radioSparkleOrange.Values.Text = "Sparkle - Orange"
        Me.radioSparklePurple.Location = New System.Drawing.Point(20, 245)
        Me.radioSparklePurple.Name = "radioSparklePurple"
        Me.radioSparklePurple.Size = New System.Drawing.Size(132, 24)
        Me.radioSparklePurple.TabIndex = 10
        Me.radioSparklePurple.Values.Text = "Sparkle - Purple"
        Me.radioSparkleBlue.Location = New System.Drawing.Point(20, 199)
        Me.radioSparkleBlue.Name = "radioSparkleBlue"
        Me.radioSparkleBlue.Size = New System.Drawing.Size(118, 24)
        Me.radioSparkleBlue.TabIndex = 8
        Me.radioSparkleBlue.Values.Text = "Sparkle - Blue"
        Me.radioSystem.Location = New System.Drawing.Point(21, 268)
        Me.radioSystem.Name = "radioSystem"
        Me.radioSystem.Size = New System.Drawing.Size(72, 24)
        Me.radioSystem.TabIndex = 11
        Me.radioSystem.Values.Text = "System"
        Me.radioOffice2003.Location = New System.Drawing.Point(20, 176)
        Me.radioOffice2003.Name = "radioOffice2003"
        Me.radioOffice2003.Size = New System.Drawing.Size(101, 24)
        Me.radioOffice2003.TabIndex = 7
        Me.radioOffice2003.Values.Text = "Office 2003"
        Me.radioOffice2007Black.Location = New System.Drawing.Point(20, 153)
        Me.radioOffice2007Black.Name = "radioOffice2007Black"
        Me.radioOffice2007Black.Size = New System.Drawing.Size(151, 24)
        Me.radioOffice2007Black.TabIndex = 6
        Me.radioOffice2007Black.Values.Text = "Office 2007 - Black"
        Me.radioOffice2007Silver.Checked = True
        Me.radioOffice2007Silver.Location = New System.Drawing.Point(20, 130)
        Me.radioOffice2007Silver.Name = "radioOffice2007Silver"
        Me.radioOffice2007Silver.Size = New System.Drawing.Size(153, 24)
        Me.radioOffice2007Silver.TabIndex = 5
        Me.radioOffice2007Silver.Values.Text = "Office 2007 - Silver"
        Me.radioOffice2007Blue.Location = New System.Drawing.Point(20, 107)
        Me.radioOffice2007Blue.Name = "radioOffice2007Blue"
        Me.radioOffice2007Blue.Size = New System.Drawing.Size(145, 24)
        Me.radioOffice2007Blue.TabIndex = 4
        Me.radioOffice2007Blue.Values.Text = "Office 2007 - Blue"
        Me.kryptonLabel2.LabelStyle = Krypton.Toolkit.LabelStyle.TitlePanel
        Me.kryptonLabel2.Location = New System.Drawing.Point(4, 4)
        Me.kryptonLabel2.Name = "kryptonLabel2"
        Me.kryptonLabel2.Size = New System.Drawing.Size(167, 35)
        Me.kryptonLabel2.TabIndex = 0
        Me.kryptonLabel2.Values.Text = "Global Palette"
        Me.groupAddContext.GroupBackStyle = Krypton.Toolkit.PaletteBackStyle.PanelAlternate
        Me.groupAddContext.Location = New System.Drawing.Point(16, 160)
        Me.groupAddContext.Name = "groupAddContext"
        Me.groupAddContext.Panel.Controls.Add(Me.buttonAddContext)
        Me.groupAddContext.Panel.Controls.Add(Me.panelContextColor)
        Me.groupAddContext.Panel.Controls.Add(Me.buttonEditColor)
        Me.groupAddContext.Panel.Controls.Add(Me.labelContextColor)
        Me.groupAddContext.Panel.Controls.Add(Me.textBoxContextTitle)
        Me.groupAddContext.Panel.Controls.Add(Me.labelContextTitle)
        Me.groupAddContext.Panel.Controls.Add(Me.labelContextName)
        Me.groupAddContext.Panel.Controls.Add(Me.textBoxContextName)
        Me.groupAddContext.Panel.Controls.Add(Me.kryptonLabel1)
        Me.groupAddContext.Size = New System.Drawing.Size(411, 161)
        Me.groupAddContext.TabIndex = 5
        Me.buttonAddContext.AutoSize = True
        Me.buttonAddContext.Location = New System.Drawing.Point(130, 120)
        Me.buttonAddContext.Name = "buttonAddContext"
        Me.buttonAddContext.Size = New System.Drawing.Size(97, 28)
        Me.buttonAddContext.TabIndex = 10
        Me.buttonAddContext.Values.DropDownArrowColor = System.Drawing.Color.Empty
        Me.buttonAddContext.Values.Text = "Add Context"
        Me.panelContextColor.Location = New System.Drawing.Point(130, 86)
        Me.panelContextColor.Name = "panelContextColor"
        Me.panelContextColor.Size = New System.Drawing.Size(94, 23)
        Me.panelContextColor.StateCommon.Color1 = System.Drawing.Color.DodgerBlue
        Me.panelContextColor.TabIndex = 9
        Me.buttonEditColor.AutoSize = True
        Me.buttonEditColor.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink
        Me.buttonEditColor.Location = New System.Drawing.Point(231, 81)
        Me.buttonEditColor.Name = "buttonEditColor"
        Me.buttonEditColor.Size = New System.Drawing.Size(97, 28)
        Me.buttonEditColor.TabIndex = 8
        Me.buttonEditColor.Values.DropDownArrowColor = System.Drawing.Color.Empty
        Me.buttonEditColor.Values.Text = "Define Color"
        Me.labelContextColor.AutoSize = False
        Me.labelContextColor.Location = New System.Drawing.Point(9, 88)
        Me.labelContextColor.Name = "labelContextColor"
        Me.labelContextColor.Size = New System.Drawing.Size(115, 22)
        Me.labelContextColor.StateCommon.ShortText.TextH = Krypton.Toolkit.PaletteRelativeAlign.Far
        Me.labelContextColor.TabIndex = 7
        Me.labelContextColor.Values.Text = "Context Color"
        Me.textBoxContextTitle.Location = New System.Drawing.Point(130, 58)
        Me.textBoxContextTitle.Name = "textBoxContextTitle"
        Me.textBoxContextTitle.Size = New System.Drawing.Size(95, 27)
        Me.textBoxContextTitle.TabIndex = 6
        Me.textBoxContextTitle.Text = "Tools"
        Me.labelContextTitle.AutoSize = False
        Me.labelContextTitle.Location = New System.Drawing.Point(9, 63)
        Me.labelContextTitle.Name = "labelContextTitle"
        Me.labelContextTitle.Size = New System.Drawing.Size(115, 22)
        Me.labelContextTitle.StateCommon.ShortText.TextH = Krypton.Toolkit.PaletteRelativeAlign.Far
        Me.labelContextTitle.TabIndex = 5
        Me.labelContextTitle.Values.Text = "Context Title"
        Me.labelContextName.AutoSize = False
        Me.labelContextName.Location = New System.Drawing.Point(9, 38)
        Me.labelContextName.Name = "labelContextName"
        Me.labelContextName.Size = New System.Drawing.Size(115, 22)
        Me.labelContextName.StateCommon.ShortText.TextH = Krypton.Toolkit.PaletteRelativeAlign.Far
        Me.labelContextName.TabIndex = 4
        Me.labelContextName.Values.Text = "Context Name"
        Me.textBoxContextName.Location = New System.Drawing.Point(130, 33)
        Me.textBoxContextName.Name = "textBoxContextName"
        Me.textBoxContextName.Size = New System.Drawing.Size(95, 27)
        Me.textBoxContextName.TabIndex = 3
        Me.textBoxContextName.Text = "Blue"
        Me.kryptonLabel1.LabelStyle = Krypton.Toolkit.LabelStyle.TitlePanel
        Me.kryptonLabel1.Location = New System.Drawing.Point(4, 2)
        Me.kryptonLabel1.Name = "kryptonLabel1"
        Me.kryptonLabel1.Size = New System.Drawing.Size(151, 35)
        Me.kryptonLabel1.TabIndex = 2
        Me.kryptonLabel1.Values.Text = "Add Context"
        Me.groupSelectedContexts.GroupBackStyle = Krypton.Toolkit.PaletteBackStyle.PanelAlternate
        Me.groupSelectedContexts.Location = New System.Drawing.Point(16, 16)
        Me.groupSelectedContexts.Name = "groupSelectedContexts"
        Me.groupSelectedContexts.Panel.Controls.Add(Me.labelSelectedContexts)
        Me.groupSelectedContexts.Panel.Controls.Add(Me.buttonSelectedApply)
        Me.groupSelectedContexts.Panel.Controls.Add(Me.textBoxSelectedContexts)
        Me.groupSelectedContexts.Panel.Controls.Add(Me.labelContextsInstructions)
        Me.groupSelectedContexts.Size = New System.Drawing.Size(411, 129)
        Me.groupSelectedContexts.TabIndex = 4
        Me.labelSelectedContexts.LabelStyle = Krypton.Toolkit.LabelStyle.TitlePanel
        Me.labelSelectedContexts.Location = New System.Drawing.Point(4, 2)
        Me.labelSelectedContexts.Name = "labelSelectedContexts"
        Me.labelSelectedContexts.Size = New System.Drawing.Size(208, 35)
        Me.labelSelectedContexts.TabIndex = 1
        Me.labelSelectedContexts.Values.Text = "Selected Contexts"
        Me.buttonSelectedApply.AutoSize = True
        Me.buttonSelectedApply.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink
        Me.buttonSelectedApply.Location = New System.Drawing.Point(311, 35)
        Me.buttonSelectedApply.Name = "buttonSelectedApply"
        Me.buttonSelectedApply.Size = New System.Drawing.Size(51, 28)
        Me.buttonSelectedApply.TabIndex = 3
        Me.buttonSelectedApply.Values.DropDownArrowColor = System.Drawing.Color.Empty
        Me.buttonSelectedApply.Values.Text = "Apply"
        Me.textBoxSelectedContexts.Location = New System.Drawing.Point(9, 36)
        Me.textBoxSelectedContexts.Name = "textBoxSelectedContexts"
        Me.textBoxSelectedContexts.Size = New System.Drawing.Size(296, 27)
        Me.textBoxSelectedContexts.TabIndex = 0
        Me.textBoxSelectedContexts.Text = "Red,Green"
        Me.labelContextsInstructions.Location = New System.Drawing.Point(5, 64)
        Me.labelContextsInstructions.Name = "labelContextsInstructions"
        Me.labelContextsInstructions.Size = New System.Drawing.Size(395, 64)
        Me.labelContextsInstructions.TabIndex = 2
        Me.labelContextsInstructions.Values.Text = "Use a common separated list of context names and then" & vbCrLf & "press the 'Apply' button. " & "To remove all contextual tabs" & vbCrLf & "just remove all the text and press 'Apply'."
        Me.colorDialog.AnyColor = True
        Me.colorDialog.Color = System.Drawing.Color.DodgerBlue
        Me.colorDialog.FullOpen = True
        Me.colorDialog.SolidColorOnly = True
        Me.kryptonManager.GlobalPaletteMode = Krypton.Toolkit.PaletteMode.Office2007Silver
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8F, 19F)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(651, 466)
        Me.CloseBox = False
        Me.Controls.Add(Me.labelOffice2007Styles)
        Me.Controls.Add(Me.kryptonRibbon)
        Me.Font = New System.Drawing.Font("Segoe UI", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.MinimumSize = New System.Drawing.Size(602, 511)
        Me.Name = "Form1"
        Me.StateCommon.Border.Width = 4
        Me.StateCommon.Header.Content.LongText.TextH = Krypton.Toolkit.PaletteRelativeAlign.Center
        Me.StateCommon.Header.Content.ShortText.TextH = Krypton.Toolkit.PaletteRelativeAlign.Center
        Me.Text = "Contextual Tabs"
        CType(Me.kryptonRibbon, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.labelOffice2007Styles, System.ComponentModel.ISupportInitialize).EndInit()
        Me.labelOffice2007Styles.ResumeLayout(False)
        CType(Me.groupOffice2007Styles.Panel, System.ComponentModel.ISupportInitialize).EndInit()
        Me.groupOffice2007Styles.Panel.ResumeLayout(False)
        Me.groupOffice2007Styles.Panel.PerformLayout()
        CType(Me.groupOffice2007Styles, System.ComponentModel.ISupportInitialize).EndInit()
        Me.groupOffice2007Styles.ResumeLayout(False)
        CType(Me.groupAddContext.Panel, System.ComponentModel.ISupportInitialize).EndInit()
        Me.groupAddContext.Panel.ResumeLayout(False)
        Me.groupAddContext.Panel.PerformLayout()
        CType(Me.groupAddContext, System.ComponentModel.ISupportInitialize).EndInit()
        Me.groupAddContext.ResumeLayout(False)
        CType(Me.panelContextColor, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.groupSelectedContexts.Panel, System.ComponentModel.ISupportInitialize).EndInit()
        Me.groupSelectedContexts.Panel.ResumeLayout(False)
        Me.groupSelectedContexts.Panel.PerformLayout()
        CType(Me.groupSelectedContexts, System.ComponentModel.ISupportInitialize).EndInit()
        Me.groupSelectedContexts.ResumeLayout(False)
        Me.ResumeLayout(False)
        Me.PerformLayout()
    End Sub

    Friend WithEvents textBoxSelectedContexts As Krypton.Toolkit.KryptonTextBox
    Friend WithEvents textBoxContextTitle As Krypton.Toolkit.KryptonTextBox
    Friend WithEvents textBoxContextName As Krypton.Toolkit.KryptonTextBox
    Friend WithEvents kryptonRibbon As Krypton.Ribbon.KryptonRibbon
    Friend WithEvents contextDefRed As Krypton.Ribbon.KryptonRibbonContext
    Friend WithEvents contextDefGreen As Krypton.Ribbon.KryptonRibbonContext
    Friend WithEvents tabHome As Krypton.Ribbon.KryptonRibbonTab
    Friend WithEvents contextRed As Krypton.Ribbon.KryptonRibbonTab
    Friend WithEvents contextGreen1 As Krypton.Ribbon.KryptonRibbonTab
    Friend WithEvents labelOffice2007Styles As Krypton.Toolkit.KryptonPanel
    Friend WithEvents labelSelectedContexts As Krypton.Toolkit.KryptonLabel
    Friend WithEvents buttonSelectedApply As Krypton.Toolkit.KryptonButton
    Friend WithEvents labelContextsInstructions As Krypton.Toolkit.KryptonLabel
    Friend WithEvents groupAddContext As Krypton.Toolkit.KryptonGroup
    Friend WithEvents kryptonLabel1 As Krypton.Toolkit.KryptonLabel
    Friend WithEvents groupSelectedContexts As Krypton.Toolkit.KryptonGroup
    Friend WithEvents labelContextColor As Krypton.Toolkit.KryptonLabel
    Friend WithEvents labelContextTitle As Krypton.Toolkit.KryptonLabel
    Friend WithEvents labelContextName As Krypton.Toolkit.KryptonLabel
    Friend WithEvents panelContextColor As Krypton.Toolkit.KryptonPanel
    Friend WithEvents buttonEditColor As Krypton.Toolkit.KryptonButton
    Friend WithEvents buttonAddContext As Krypton.Toolkit.KryptonButton
    Friend WithEvents contextGreen2 As Krypton.Ribbon.KryptonRibbonTab
    Friend WithEvents groupOffice2007Styles As Krypton.Toolkit.KryptonGroup
    Friend WithEvents kryptonLabel2 As Krypton.Toolkit.KryptonLabel
    Friend WithEvents kryptonManager As Krypton.Toolkit.KryptonManager
    Friend WithEvents colorDialog As System.Windows.Forms.ColorDialog
    Friend WithEvents radioSystem As Krypton.Toolkit.KryptonRadioButton
    Friend WithEvents radioOffice2003 As Krypton.Toolkit.KryptonRadioButton
    Friend WithEvents radioOffice2007Black As Krypton.Toolkit.KryptonRadioButton
    Friend WithEvents radioOffice2007Silver As Krypton.Toolkit.KryptonRadioButton
    Friend WithEvents radioOffice2007Blue As Krypton.Toolkit.KryptonRadioButton
    Friend WithEvents kryptonContextMenuItem1 As Krypton.Toolkit.KryptonContextMenuItem
    Friend WithEvents radioSparkleBlue As Krypton.Toolkit.KryptonRadioButton
    Friend WithEvents radioSparkleOrange As Krypton.Toolkit.KryptonRadioButton
    Friend WithEvents radioSparklePurple As Krypton.Toolkit.KryptonRadioButton
    Friend WithEvents radioOffice2010Black As Krypton.Toolkit.KryptonRadioButton
    Friend WithEvents radioOffice2010Silver As Krypton.Toolkit.KryptonRadioButton
    Friend WithEvents radioOffice2010Blue As Krypton.Toolkit.KryptonRadioButton
End Class
