' VB.NET twin of Source\Krypton Toolkit Examples\Expanding HeaderGroups (Stack)\Form1.Designer.cs (Bastion Phase 4c).
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
        Me.menuStrip = New System.Windows.Forms.MenuStrip()
        Me.toolStripMenuItem1 = New System.Windows.Forms.ToolStripMenuItem()
        Me.menuOffice2010 = New System.Windows.Forms.ToolStripMenuItem()
        Me.menuOffice2007 = New System.Windows.Forms.ToolStripMenuItem()
        Me.menuSparkle = New System.Windows.Forms.ToolStripMenuItem()
        Me.menuSystem = New System.Windows.Forms.ToolStripMenuItem()
        Me.toolStripSeparator1 = New System.Windows.Forms.ToolStripSeparator()
        Me.exitToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.toolStrip = New System.Windows.Forms.ToolStrip()
        Me.toolOffice2010 = New System.Windows.Forms.ToolStripButton()
        Me.toolOffice2007 = New System.Windows.Forms.ToolStripButton()
        Me.toolSparkle = New System.Windows.Forms.ToolStripButton()
        Me.toolSystem = New System.Windows.Forms.ToolStripButton()
        Me.toolStripContainer1 = New System.Windows.Forms.ToolStripContainer()
        Me.kryptonPanelMain = New Krypton.Toolkit.KryptonPanel()
        Me.kryptonGroupFiller = New Krypton.Toolkit.KryptonGroup()
        Me.textBoxFiller = New Krypton.Toolkit.KryptonTextBox()
        Me.kryptonBorderEdgeBottom = New Krypton.Toolkit.KryptonBorderEdge()
        Me.kryptonHeaderBottom = New Krypton.Toolkit.KryptonHeaderGroup()
        Me.buttonSpecBottom = New Krypton.Toolkit.ButtonSpecHeaderGroup()
        Me.kryptonButtonPrevious = New Krypton.Toolkit.KryptonButton()
        Me.textBoxFind = New Krypton.Toolkit.KryptonTextBox()
        Me.kryptonButtonNext = New Krypton.Toolkit.KryptonButton()
        Me.labelFind = New Krypton.Toolkit.KryptonLabel()
        Me.kryptonBorderEdgeTop = New Krypton.Toolkit.KryptonBorderEdge()
        Me.kryptonHeaderTop = New Krypton.Toolkit.KryptonHeaderGroup()
        Me.buttonSpecHeaderGroup1 = New Krypton.Toolkit.ButtonSpecHeaderGroup()
        Me.textBox3 = New Krypton.Toolkit.KryptonTextBox()
        Me.textBox2 = New Krypton.Toolkit.KryptonTextBox()
        Me.labelPosition = New Krypton.Toolkit.KryptonLabel()
        Me.labelAge = New Krypton.Toolkit.KryptonLabel()
        Me.textBox1 = New Krypton.Toolkit.KryptonTextBox()
        Me.textBoxFirstName = New Krypton.Toolkit.KryptonTextBox()
        Me.labelLastName = New Krypton.Toolkit.KryptonLabel()
        Me.labelFirstName = New Krypton.Toolkit.KryptonLabel()
        Me.kryptonManager = New Krypton.Toolkit.KryptonManager(Me.components)
        Me.statusStrip1 = New System.Windows.Forms.StatusStrip()
        Me.menuStrip.SuspendLayout()
        Me.toolStrip.SuspendLayout()
        Me.toolStripContainer1.ContentPanel.SuspendLayout()
        Me.toolStripContainer1.TopToolStripPanel.SuspendLayout()
        Me.toolStripContainer1.SuspendLayout()
        CType(Me.kryptonPanelMain, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.kryptonPanelMain.SuspendLayout()
        CType(Me.kryptonGroupFiller, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.kryptonGroupFiller.Panel, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.kryptonGroupFiller.Panel.SuspendLayout()
        Me.kryptonGroupFiller.SuspendLayout()
        CType(Me.kryptonHeaderBottom, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.kryptonHeaderBottom.Panel, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.kryptonHeaderBottom.Panel.SuspendLayout()
        Me.kryptonHeaderBottom.SuspendLayout()
        CType(Me.kryptonHeaderTop, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.kryptonHeaderTop.Panel, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.kryptonHeaderTop.Panel.SuspendLayout()
        Me.kryptonHeaderTop.SuspendLayout()
        Me.SuspendLayout()
        '
        'menuStrip
        '
        Me.menuStrip.Font = New System.Drawing.Font("Segoe UI", 9F)
        Me.menuStrip.ImageScalingSize = New System.Drawing.Size(20, 20)
        Me.menuStrip.Items.AddRange(New System.Windows.Forms.ToolStripItem() { Me.toolStripMenuItem1})
        Me.menuStrip.Location = New System.Drawing.Point(0, 0)
        Me.menuStrip.Name = "menuStrip"
        Me.menuStrip.Size = New System.Drawing.Size(356, 28)
        Me.menuStrip.TabIndex = 0
        Me.menuStrip.Text = "menuStrip"
        '
        'toolStripMenuItem1
        '
        Me.toolStripMenuItem1.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() { Me.menuOffice2010, Me.menuOffice2007, Me.menuSparkle, Me.menuSystem, Me.toolStripSeparator1, Me.exitToolStripMenuItem})
        Me.toolStripMenuItem1.Name = "toolStripMenuItem1"
        Me.toolStripMenuItem1.Size = New System.Drawing.Size(46, 24)
        Me.toolStripMenuItem1.Text = "File"
        '
        'menuOffice2010
        '
        Me.menuOffice2010.Checked = True
        Me.menuOffice2010.CheckState = System.Windows.Forms.CheckState.Checked
        Me.menuOffice2010.Name = "menuOffice2010"
        Me.menuOffice2010.Size = New System.Drawing.Size(211, 26)
        Me.menuOffice2010.Text = "Office 2010 - Blue"
        '
        'menuOffice2007
        '
        Me.menuOffice2007.Name = "menuOffice2007"
        Me.menuOffice2007.Size = New System.Drawing.Size(211, 26)
        Me.menuOffice2007.Text = "Office 2007 - Blue"
        '
        'menuSparkle
        '
        Me.menuSparkle.Name = "menuSparkle"
        Me.menuSparkle.Size = New System.Drawing.Size(211, 26)
        Me.menuSparkle.Text = "Sparkle - Blue"
        '
        'menuSystem
        '
        Me.menuSystem.Name = "menuSystem"
        Me.menuSystem.Size = New System.Drawing.Size(211, 26)
        Me.menuSystem.Text = "System"
        '
        'toolStripSeparator1
        '
        Me.toolStripSeparator1.Name = "toolStripSeparator1"
        Me.toolStripSeparator1.Size = New System.Drawing.Size(208, 6)
        '
        'exitToolStripMenuItem
        '
        Me.exitToolStripMenuItem.Name = "exitToolStripMenuItem"
        Me.exitToolStripMenuItem.Size = New System.Drawing.Size(211, 26)
        Me.exitToolStripMenuItem.Text = "Exit"
        '
        'toolStrip
        '
        Me.toolStrip.Dock = System.Windows.Forms.DockStyle.None
        Me.toolStrip.Font = New System.Drawing.Font("Segoe UI", 9F)
        Me.toolStrip.ImageScalingSize = New System.Drawing.Size(20, 20)
        Me.toolStrip.Items.AddRange(New System.Windows.Forms.ToolStripItem() { Me.toolOffice2010, Me.toolOffice2007, Me.toolSparkle, Me.toolSystem})
        Me.toolStrip.Location = New System.Drawing.Point(4, 0)
        Me.toolStrip.Name = "toolStrip"
        Me.toolStrip.Size = New System.Drawing.Size(225, 27)
        Me.toolStrip.TabIndex = 1
        Me.toolStrip.Text = "toolStrip"
        '
        'toolOffice2010
        '
        Me.toolOffice2010.Checked = True
        Me.toolOffice2010.CheckState = System.Windows.Forms.CheckState.Checked
        Me.toolOffice2010.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Text
        Me.toolOffice2010.Image = CType(resources.GetObject("toolOffice2010.Image"), System.Drawing.Image)
        Me.toolOffice2010.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.toolOffice2010.Name = "toolOffice2010"
        Me.toolOffice2010.Size = New System.Drawing.Size(45, 24)
        Me.toolOffice2010.Text = "2010"
        '
        'toolOffice2007
        '
        Me.toolOffice2007.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Text
        Me.toolOffice2007.Image = CType(resources.GetObject("toolOffice2007.Image"), System.Drawing.Image)
        Me.toolOffice2007.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.toolOffice2007.Name = "toolOffice2007"
        Me.toolOffice2007.Size = New System.Drawing.Size(45, 24)
        Me.toolOffice2007.Text = "2007"
        '
        'toolSparkle
        '
        Me.toolSparkle.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Text
        Me.toolSparkle.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.toolSparkle.Name = "toolSparkle"
        Me.toolSparkle.Size = New System.Drawing.Size(62, 24)
        Me.toolSparkle.Text = "Sparkle"
        '
        'toolSystem
        '
        Me.toolSystem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Text
        Me.toolSystem.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.toolSystem.Name = "toolSystem"
        Me.toolSystem.Size = New System.Drawing.Size(60, 24)
        Me.toolSystem.Text = "System"
        '
        'toolStripContainer1
        '
        '
        'toolStripContainer1.ContentPanel
        '
        Me.toolStripContainer1.ContentPanel.Controls.Add(Me.kryptonPanelMain)
        Me.toolStripContainer1.ContentPanel.Size = New System.Drawing.Size(356, 275)
        Me.toolStripContainer1.Dock = System.Windows.Forms.DockStyle.Fill
        Me.toolStripContainer1.Location = New System.Drawing.Point(0, 28)
        Me.toolStripContainer1.Name = "toolStripContainer1"
        Me.toolStripContainer1.Size = New System.Drawing.Size(356, 302)
        Me.toolStripContainer1.TabIndex = 2
        Me.toolStripContainer1.Text = "toolStripContainer1"
        '
        'toolStripContainer1.TopToolStripPanel
        '
        Me.toolStripContainer1.TopToolStripPanel.Controls.Add(Me.toolStrip)
        '
        'kryptonPanelMain
        '
        Me.kryptonPanelMain.Controls.Add(Me.kryptonGroupFiller)
        Me.kryptonPanelMain.Controls.Add(Me.kryptonBorderEdgeBottom)
        Me.kryptonPanelMain.Controls.Add(Me.kryptonHeaderBottom)
        Me.kryptonPanelMain.Controls.Add(Me.kryptonBorderEdgeTop)
        Me.kryptonPanelMain.Controls.Add(Me.kryptonHeaderTop)
        Me.kryptonPanelMain.Dock = System.Windows.Forms.DockStyle.Fill
        Me.kryptonPanelMain.Location = New System.Drawing.Point(0, 0)
        Me.kryptonPanelMain.Name = "kryptonPanelMain"
        Me.kryptonPanelMain.Padding = New System.Windows.Forms.Padding(5)
        Me.kryptonPanelMain.Size = New System.Drawing.Size(356, 275)
        Me.kryptonPanelMain.TabIndex = 0
        '
        'kryptonGroupFiller
        '
        Me.kryptonGroupFiller.Dock = System.Windows.Forms.DockStyle.Fill
        Me.kryptonGroupFiller.Location = New System.Drawing.Point(5, 112)
        Me.kryptonGroupFiller.Name = "kryptonGroupFiller"
        '
        'kryptonGroupFiller.Panel
        '
        Me.kryptonGroupFiller.Panel.Controls.Add(Me.textBoxFiller)
        Me.kryptonGroupFiller.Panel.Padding = New System.Windows.Forms.Padding(3)
        Me.kryptonGroupFiller.Size = New System.Drawing.Size(346, 74)
        Me.kryptonGroupFiller.StateCommon.Border.DrawBorders = CType((Krypton.Toolkit.PaletteDrawBorders.Left Or Krypton.Toolkit.PaletteDrawBorders.Right), Krypton.Toolkit.PaletteDrawBorders)
        Me.kryptonGroupFiller.StateCommon.Border.GraphicsHint = Krypton.Toolkit.PaletteGraphicsHint.None
        Me.kryptonGroupFiller.TabIndex = 1
        '
        'textBoxFiller
        '
        Me.textBoxFiller.Dock = System.Windows.Forms.DockStyle.Fill
        Me.textBoxFiller.Location = New System.Drawing.Point(3, 3)
        Me.textBoxFiller.Multiline = True
        Me.textBoxFiller.Name = "textBoxFiller"
        Me.textBoxFiller.Size = New System.Drawing.Size(338, 68)
        Me.textBoxFiller.StateCommon.Border.Draw = Krypton.Toolkit.InheritBool.False
        Me.textBoxFiller.StateCommon.Border.DrawBorders = CType((((Krypton.Toolkit.PaletteDrawBorders.Top Or Krypton.Toolkit.PaletteDrawBorders.Bottom) Or Krypton.Toolkit.PaletteDrawBorders.Left) Or Krypton.Toolkit.PaletteDrawBorders.Right), Krypton.Toolkit.PaletteDrawBorders)
        Me.textBoxFiller.TabIndex = 0
        Me.textBoxFiller.Text = resources.GetString("textBoxFiller.Text")
        '
        'kryptonBorderEdgeBottom
        '
        Me.kryptonBorderEdgeBottom.Dock = System.Windows.Forms.DockStyle.Bottom
        Me.kryptonBorderEdgeBottom.Location = New System.Drawing.Point(5, 186)
        Me.kryptonBorderEdgeBottom.Name = "kryptonBorderEdgeBottom"
        Me.kryptonBorderEdgeBottom.Size = New System.Drawing.Size(346, 1)
        Me.kryptonBorderEdgeBottom.StateCommon.GraphicsHint = Krypton.Toolkit.PaletteGraphicsHint.None
        Me.kryptonBorderEdgeBottom.Text = "kryptonBorderEdge1"
        '
        'kryptonHeaderBottom
        '
        Me.kryptonHeaderBottom.AutoSize = True
        Me.kryptonHeaderBottom.ButtonSpecs.Add(Me.buttonSpecBottom)
        Me.kryptonHeaderBottom.CollapseTarget = Krypton.Toolkit.HeaderGroupCollapsedTarget.CollapsedToSecondary
        Me.kryptonHeaderBottom.Dock = System.Windows.Forms.DockStyle.Bottom
        Me.kryptonHeaderBottom.GroupBackStyle = Krypton.Toolkit.PaletteBackStyle.PanelAlternate
        Me.kryptonHeaderBottom.HeaderStyleSecondary = Krypton.Toolkit.HeaderStyle.Primary
        Me.kryptonHeaderBottom.HeaderVisiblePrimary = False
        Me.kryptonHeaderBottom.Location = New System.Drawing.Point(5, 187)
        Me.kryptonHeaderBottom.Name = "kryptonHeaderBottom"
        '
        'kryptonHeaderBottom.Panel
        '
        Me.kryptonHeaderBottom.Panel.Controls.Add(Me.kryptonButtonPrevious)
        Me.kryptonHeaderBottom.Panel.Controls.Add(Me.textBoxFind)
        Me.kryptonHeaderBottom.Panel.Controls.Add(Me.kryptonButtonNext)
        Me.kryptonHeaderBottom.Panel.Controls.Add(Me.labelFind)
        Me.kryptonHeaderBottom.Panel.Padding = New System.Windows.Forms.Padding(5)
        Me.kryptonHeaderBottom.Size = New System.Drawing.Size(346, 83)
        Me.kryptonHeaderBottom.StateCommon.Border.DrawBorders = CType(((Krypton.Toolkit.PaletteDrawBorders.Bottom Or Krypton.Toolkit.PaletteDrawBorders.Left) Or Krypton.Toolkit.PaletteDrawBorders.Right), Krypton.Toolkit.PaletteDrawBorders)
        Me.kryptonHeaderBottom.TabIndex = 2
        Me.kryptonHeaderBottom.ValuesPrimary.Heading = ""
        Me.kryptonHeaderBottom.ValuesPrimary.Image = Nothing
        Me.kryptonHeaderBottom.ValuesSecondary.Heading = "Bottom HeaderGroup"
        Me.kryptonHeaderBottom.ValuesSecondary.Image = CType(resources.GetObject("kryptonHeaderBottom.ValuesSecondary.Image"), System.Drawing.Image)
        '
        'buttonSpecBottom
        '
        Me.buttonSpecBottom.HeaderLocation = Krypton.Toolkit.HeaderLocation.SecondaryHeader
        Me.buttonSpecBottom.Type = Krypton.Toolkit.PaletteButtonSpecStyle.ArrowDown
        Me.buttonSpecBottom.UniqueName = "A07748CCD08E4E46A07748CCD08E4E46"
        '
        'kryptonButtonPrevious
        '
        Me.kryptonButtonPrevious.AutoSize = True
        Me.kryptonButtonPrevious.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink
        Me.kryptonButtonPrevious.Location = New System.Drawing.Point(229, 10)
        Me.kryptonButtonPrevious.Name = "kryptonButtonPrevious"
        Me.kryptonButtonPrevious.Size = New System.Drawing.Size(56, 28)
        Me.kryptonButtonPrevious.TabIndex = 5
        Me.kryptonButtonPrevious.Values.DropDownArrowColor = System.Drawing.Color.Empty
        Me.kryptonButtonPrevious.Values.Text = "< Prev"
        '
        'textBoxFind
        '
        Me.textBoxFind.Location = New System.Drawing.Point(49, 10)
        Me.textBoxFind.Name = "textBoxFind"
        Me.textBoxFind.Size = New System.Drawing.Size(171, 27)
        Me.textBoxFind.TabIndex = 4
        Me.textBoxFind.Text = "example string"
        '
        'kryptonButtonNext
        '
        Me.kryptonButtonNext.AutoSize = True
        Me.kryptonButtonNext.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink
        Me.kryptonButtonNext.Location = New System.Drawing.Point(283, 10)
        Me.kryptonButtonNext.Name = "kryptonButtonNext"
        Me.kryptonButtonNext.Size = New System.Drawing.Size(58, 28)
        Me.kryptonButtonNext.TabIndex = 6
        Me.kryptonButtonNext.Values.DropDownArrowColor = System.Drawing.Color.Empty
        Me.kryptonButtonNext.Values.Text = "Next >"
        '
        'labelFind
        '
        Me.labelFind.Location = New System.Drawing.Point(11, 11)
        Me.labelFind.Name = "labelFind"
        Me.labelFind.Size = New System.Drawing.Size(40, 24)
        Me.labelFind.TabIndex = 3
        Me.labelFind.Values.Text = "Text"
        '
        'kryptonBorderEdgeTop
        '
        Me.kryptonBorderEdgeTop.Dock = System.Windows.Forms.DockStyle.Top
        Me.kryptonBorderEdgeTop.Location = New System.Drawing.Point(5, 111)
        Me.kryptonBorderEdgeTop.Name = "kryptonBorderEdgeTop"
        Me.kryptonBorderEdgeTop.Size = New System.Drawing.Size(346, 1)
        Me.kryptonBorderEdgeTop.StateCommon.GraphicsHint = Krypton.Toolkit.PaletteGraphicsHint.None
        Me.kryptonBorderEdgeTop.Text = "kryptonBorderEdge1"
        '
        'kryptonHeaderTop
        '
        Me.kryptonHeaderTop.AutoSize = True
        Me.kryptonHeaderTop.ButtonSpecs.Add(Me.buttonSpecHeaderGroup1)
        Me.kryptonHeaderTop.Dock = System.Windows.Forms.DockStyle.Top
        Me.kryptonHeaderTop.GroupBackStyle = Krypton.Toolkit.PaletteBackStyle.PanelAlternate
        Me.kryptonHeaderTop.HeaderVisibleSecondary = False
        Me.kryptonHeaderTop.Location = New System.Drawing.Point(5, 5)
        Me.kryptonHeaderTop.Name = "kryptonHeaderTop"
        '
        'kryptonHeaderTop.Panel
        '
        Me.kryptonHeaderTop.Panel.Controls.Add(Me.textBox3)
        Me.kryptonHeaderTop.Panel.Controls.Add(Me.textBox2)
        Me.kryptonHeaderTop.Panel.Controls.Add(Me.labelPosition)
        Me.kryptonHeaderTop.Panel.Controls.Add(Me.labelAge)
        Me.kryptonHeaderTop.Panel.Controls.Add(Me.textBox1)
        Me.kryptonHeaderTop.Panel.Controls.Add(Me.textBoxFirstName)
        Me.kryptonHeaderTop.Panel.Controls.Add(Me.labelLastName)
        Me.kryptonHeaderTop.Panel.Controls.Add(Me.labelFirstName)
        Me.kryptonHeaderTop.Panel.Padding = New System.Windows.Forms.Padding(5)
        Me.kryptonHeaderTop.Size = New System.Drawing.Size(346, 106)
        Me.kryptonHeaderTop.StateCommon.Border.DrawBorders = CType(((Krypton.Toolkit.PaletteDrawBorders.Top Or Krypton.Toolkit.PaletteDrawBorders.Left) Or Krypton.Toolkit.PaletteDrawBorders.Right), Krypton.Toolkit.PaletteDrawBorders)
        Me.kryptonHeaderTop.TabIndex = 0
        Me.kryptonHeaderTop.ValuesPrimary.Heading = "Top HeaderGroup"
        Me.kryptonHeaderTop.ValuesPrimary.Image = CType(resources.GetObject("kryptonHeaderTop.ValuesPrimary.Image"), System.Drawing.Image)
        '
        'buttonSpecHeaderGroup1
        '
        Me.buttonSpecHeaderGroup1.Type = Krypton.Toolkit.PaletteButtonSpecStyle.ArrowUp
        Me.buttonSpecHeaderGroup1.UniqueName = "A07748CCD08E4E46A07748CCD08E4E46"
        '
        'textBox3
        '
        Me.textBox3.Location = New System.Drawing.Point(236, 34)
        Me.textBox3.Name = "textBox3"
        Me.textBox3.Size = New System.Drawing.Size(94, 27)
        Me.textBox3.TabIndex = 10
        Me.textBox3.Text = "Roman Emperor"
        '
        'textBox2
        '
        Me.textBox2.Location = New System.Drawing.Point(236, 7)
        Me.textBox2.Name = "textBox2"
        Me.textBox2.Size = New System.Drawing.Size(94, 27)
        Me.textBox2.TabIndex = 7
        Me.textBox2.Text = "24"
        '
        'labelPosition
        '
        Me.labelPosition.Location = New System.Drawing.Point(183, 35)
        Me.labelPosition.Name = "labelPosition"
        Me.labelPosition.Size = New System.Drawing.Size(66, 24)
        Me.labelPosition.TabIndex = 12
        Me.labelPosition.Values.Text = "Position"
        '
        'labelAge
        '
        Me.labelAge.Location = New System.Drawing.Point(182, 10)
        Me.labelAge.Name = "labelAge"
        Me.labelAge.Size = New System.Drawing.Size(39, 24)
        Me.labelAge.TabIndex = 11
        Me.labelAge.Values.Text = "Age"
        '
        'textBox1
        '
        Me.textBox1.Location = New System.Drawing.Point(81, 34)
        Me.textBox1.Name = "textBox1"
        Me.textBox1.Size = New System.Drawing.Size(89, 27)
        Me.textBox1.TabIndex = 8
        Me.textBox1.Text = "Ceaser"
        '
        'textBoxFirstName
        '
        Me.textBoxFirstName.Location = New System.Drawing.Point(81, 7)
        Me.textBoxFirstName.Name = "textBoxFirstName"
        Me.textBoxFirstName.Size = New System.Drawing.Size(89, 27)
        Me.textBoxFirstName.TabIndex = 5
        Me.textBoxFirstName.Text = "Augustus"
        '
        'labelLastName
        '
        Me.labelLastName.Location = New System.Drawing.Point(11, 35)
        Me.labelLastName.Name = "labelLastName"
        Me.labelLastName.Size = New System.Drawing.Size(83, 24)
        Me.labelLastName.TabIndex = 9
        Me.labelLastName.Values.Text = "Last Name"
        '
        'labelFirstName
        '
        Me.labelFirstName.Location = New System.Drawing.Point(11, 10)
        Me.labelFirstName.Name = "labelFirstName"
        Me.labelFirstName.Size = New System.Drawing.Size(85, 24)
        Me.labelFirstName.TabIndex = 6
        Me.labelFirstName.Values.Text = "First Name"
        '
        'kryptonManager
        '
        Me.kryptonManager.GlobalPaletteMode = Krypton.Toolkit.PaletteMode.Office2007Blue
        '
        'statusStrip1
        '
        Me.statusStrip1.Font = New System.Drawing.Font("Segoe UI", 9F)
        Me.statusStrip1.ImageScalingSize = New System.Drawing.Size(20, 20)
        Me.statusStrip1.Location = New System.Drawing.Point(0, 330)
        Me.statusStrip1.Name = "statusStrip1"
        Me.statusStrip1.RenderMode = System.Windows.Forms.ToolStripRenderMode.ManagerRenderMode
        Me.statusStrip1.Size = New System.Drawing.Size(356, 22)
        Me.statusStrip1.TabIndex = 3
        Me.statusStrip1.Text = "statusStrip1"
        '
        'Form1
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8F, 17F)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(356, 352)
        Me.Controls.Add(Me.toolStripContainer1)
        Me.Controls.Add(Me.menuStrip)
        Me.Controls.Add(Me.statusStrip1)
        Me.Font = New System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.MainMenuStrip = Me.menuStrip
        Me.MaximizeBox = False
        Me.MinimizeBox = False
        Me.MinimumSize = New System.Drawing.Size(360, 372)
        Me.Name = "Form1"
        Me.Text = "Expanding HeaderGroups (Stack)"
        Me.menuStrip.ResumeLayout(False)
        Me.menuStrip.PerformLayout()
        Me.toolStrip.ResumeLayout(False)
        Me.toolStrip.PerformLayout()
        Me.toolStripContainer1.ContentPanel.ResumeLayout(False)
        Me.toolStripContainer1.TopToolStripPanel.ResumeLayout(False)
        Me.toolStripContainer1.TopToolStripPanel.PerformLayout()
        Me.toolStripContainer1.ResumeLayout(False)
        Me.toolStripContainer1.PerformLayout()
        CType(Me.kryptonPanelMain, System.ComponentModel.ISupportInitialize).EndInit()
        Me.kryptonPanelMain.ResumeLayout(False)
        Me.kryptonPanelMain.PerformLayout()
        CType(Me.kryptonGroupFiller.Panel, System.ComponentModel.ISupportInitialize).EndInit()
        Me.kryptonGroupFiller.Panel.ResumeLayout(False)
        Me.kryptonGroupFiller.Panel.PerformLayout()
        CType(Me.kryptonGroupFiller, System.ComponentModel.ISupportInitialize).EndInit()
        Me.kryptonGroupFiller.ResumeLayout(False)
        CType(Me.kryptonHeaderBottom.Panel, System.ComponentModel.ISupportInitialize).EndInit()
        Me.kryptonHeaderBottom.Panel.ResumeLayout(False)
        Me.kryptonHeaderBottom.Panel.PerformLayout()
        CType(Me.kryptonHeaderBottom, System.ComponentModel.ISupportInitialize).EndInit()
        Me.kryptonHeaderBottom.ResumeLayout(False)
        CType(Me.kryptonHeaderTop.Panel, System.ComponentModel.ISupportInitialize).EndInit()
        Me.kryptonHeaderTop.Panel.ResumeLayout(False)
        Me.kryptonHeaderTop.Panel.PerformLayout()
        CType(Me.kryptonHeaderTop, System.ComponentModel.ISupportInitialize).EndInit()
        Me.kryptonHeaderTop.ResumeLayout(False)
        Me.ResumeLayout(False)
        Me.PerformLayout()
    End Sub

    Friend WithEvents menuStrip As System.Windows.Forms.MenuStrip
    Friend WithEvents toolStrip As System.Windows.Forms.ToolStrip
    Friend WithEvents toolStripContainer1 As System.Windows.Forms.ToolStripContainer
    Friend WithEvents kryptonPanelMain As Krypton.Toolkit.KryptonPanel
    Friend WithEvents kryptonGroupFiller As Krypton.Toolkit.KryptonGroup
    Friend WithEvents kryptonHeaderTop As Krypton.Toolkit.KryptonHeaderGroup
    Friend WithEvents buttonSpecHeaderGroup1 As Krypton.Toolkit.ButtonSpecHeaderGroup
    Friend WithEvents kryptonHeaderBottom As Krypton.Toolkit.KryptonHeaderGroup
    Friend WithEvents buttonSpecBottom As Krypton.Toolkit.ButtonSpecHeaderGroup
    Friend WithEvents textBoxFiller As Krypton.Toolkit.KryptonTextBox
    Friend WithEvents textBox3 As Krypton.Toolkit.KryptonTextBox
    Friend WithEvents textBox2 As Krypton.Toolkit.KryptonTextBox
    Friend WithEvents labelPosition As Krypton.Toolkit.KryptonLabel
    Friend WithEvents labelAge As Krypton.Toolkit.KryptonLabel
    Friend WithEvents textBox1 As Krypton.Toolkit.KryptonTextBox
    Friend WithEvents textBoxFirstName As Krypton.Toolkit.KryptonTextBox
    Friend WithEvents labelLastName As Krypton.Toolkit.KryptonLabel
    Friend WithEvents labelFirstName As Krypton.Toolkit.KryptonLabel
    Friend WithEvents kryptonButtonPrevious As Krypton.Toolkit.KryptonButton
    Friend WithEvents textBoxFind As Krypton.Toolkit.KryptonTextBox
    Friend WithEvents kryptonButtonNext As Krypton.Toolkit.KryptonButton
    Friend WithEvents labelFind As Krypton.Toolkit.KryptonLabel
    Friend WithEvents kryptonManager As Krypton.Toolkit.KryptonManager
    Friend WithEvents toolSystem As System.Windows.Forms.ToolStripButton
    Friend WithEvents toolSparkle As System.Windows.Forms.ToolStripButton
    Friend WithEvents toolStripMenuItem1 As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents menuSystem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents menuSparkle As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents toolStripSeparator1 As System.Windows.Forms.ToolStripSeparator
    Friend WithEvents exitToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents kryptonBorderEdgeBottom As Krypton.Toolkit.KryptonBorderEdge
    Friend WithEvents kryptonBorderEdgeTop As Krypton.Toolkit.KryptonBorderEdge
    Friend WithEvents menuOffice2010 As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents menuOffice2007 As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents toolOffice2010 As System.Windows.Forms.ToolStripButton
    Friend WithEvents toolOffice2007 As System.Windows.Forms.ToolStripButton
    Friend WithEvents statusStrip1 As System.Windows.Forms.StatusStrip
End Class
