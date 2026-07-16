' VB.NET twin of Source\Krypton Toolkit Examples\Expanding HeaderGroups (Splitters)\Form1.Designer.cs (Bastion Phase 4c).
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
        Me.fileToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.menuOffice2010 = New System.Windows.Forms.ToolStripMenuItem()
        Me.menuOffice2007 = New System.Windows.Forms.ToolStripMenuItem()
        Me.menuSparkle = New System.Windows.Forms.ToolStripMenuItem()
        Me.menuSystem = New System.Windows.Forms.ToolStripMenuItem()
        Me.toolStripSeparator1 = New System.Windows.Forms.ToolStripSeparator()
        Me.exitToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.toolStripContainer1 = New System.Windows.Forms.ToolStripContainer()
        Me.kryptonPanel1 = New Krypton.Toolkit.KryptonPanel()
        Me.kryptonSplitContainerHorizontal = New Krypton.Toolkit.KryptonSplitContainer()
        Me.kryptonHeaderGroupLeft = New Krypton.Toolkit.KryptonHeaderGroup()
        Me.buttonSpecLeftRight = New Krypton.Toolkit.ButtonSpecHeaderGroup()
        Me.textBoxLeft = New Krypton.Toolkit.KryptonTextBox()
        Me.kryptonSplitContainerVertical = New Krypton.Toolkit.KryptonSplitContainer()
        Me.kryptonHeaderGroupRightTop = New Krypton.Toolkit.KryptonHeaderGroup()
        Me.textBoxRightTop = New Krypton.Toolkit.KryptonTextBox()
        Me.kryptonHeaderGroupRightBottom = New Krypton.Toolkit.KryptonHeaderGroup()
        Me.buttonSpecUpDown = New Krypton.Toolkit.ButtonSpecHeaderGroup()
        Me.textBoxRightBottom = New Krypton.Toolkit.KryptonTextBox()
        Me.toolStrip = New System.Windows.Forms.ToolStrip()
        Me.toolOffice2010 = New System.Windows.Forms.ToolStripButton()
        Me.toolOffice2007 = New System.Windows.Forms.ToolStripButton()
        Me.toolSparkle = New System.Windows.Forms.ToolStripButton()
        Me.toolSystem = New System.Windows.Forms.ToolStripButton()
        Me.kryptonManager = New Krypton.Toolkit.KryptonManager(Me.components)
        Me.statusStrip1 = New System.Windows.Forms.StatusStrip()
        Me.menuStrip.SuspendLayout()
        Me.toolStripContainer1.ContentPanel.SuspendLayout()
        Me.toolStripContainer1.TopToolStripPanel.SuspendLayout()
        Me.toolStripContainer1.SuspendLayout()
        CType(Me.kryptonPanel1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.kryptonPanel1.SuspendLayout()
        CType(Me.kryptonSplitContainerHorizontal, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.kryptonSplitContainerHorizontal.Panel1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.kryptonSplitContainerHorizontal.Panel1.SuspendLayout()
        CType(Me.kryptonSplitContainerHorizontal.Panel2, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.kryptonSplitContainerHorizontal.Panel2.SuspendLayout()
        Me.kryptonSplitContainerHorizontal.SuspendLayout()
        CType(Me.kryptonHeaderGroupLeft, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.kryptonHeaderGroupLeft.Panel, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.kryptonHeaderGroupLeft.Panel.SuspendLayout()
        Me.kryptonHeaderGroupLeft.SuspendLayout()
        CType(Me.kryptonSplitContainerVertical, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.kryptonSplitContainerVertical.Panel1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.kryptonSplitContainerVertical.Panel1.SuspendLayout()
        CType(Me.kryptonSplitContainerVertical.Panel2, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.kryptonSplitContainerVertical.Panel2.SuspendLayout()
        Me.kryptonSplitContainerVertical.SuspendLayout()
        CType(Me.kryptonHeaderGroupRightTop, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.kryptonHeaderGroupRightTop.Panel, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.kryptonHeaderGroupRightTop.Panel.SuspendLayout()
        Me.kryptonHeaderGroupRightTop.SuspendLayout()
        CType(Me.kryptonHeaderGroupRightBottom, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.kryptonHeaderGroupRightBottom.Panel, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.kryptonHeaderGroupRightBottom.Panel.SuspendLayout()
        Me.kryptonHeaderGroupRightBottom.SuspendLayout()
        Me.toolStrip.SuspendLayout()
        Me.SuspendLayout()
        '
        'menuStrip
        '
        Me.menuStrip.Font = New System.Drawing.Font("Segoe UI", 9F)
        Me.menuStrip.ImageScalingSize = New System.Drawing.Size(20, 20)
        Me.menuStrip.Items.AddRange(New System.Windows.Forms.ToolStripItem() { Me.fileToolStripMenuItem})
        Me.menuStrip.Location = New System.Drawing.Point(0, 0)
        Me.menuStrip.Name = "menuStrip"
        Me.menuStrip.Size = New System.Drawing.Size(464, 28)
        Me.menuStrip.TabIndex = 0
        Me.menuStrip.Text = "menuStrip1"
        '
        'fileToolStripMenuItem
        '
        Me.fileToolStripMenuItem.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() { Me.menuOffice2010, Me.menuOffice2007, Me.menuSparkle, Me.menuSystem, Me.toolStripSeparator1, Me.exitToolStripMenuItem})
        Me.fileToolStripMenuItem.Name = "fileToolStripMenuItem"
        Me.fileToolStripMenuItem.Size = New System.Drawing.Size(46, 24)
        Me.fileToolStripMenuItem.Text = "File"
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
        'toolStripContainer1
        '
        '
        'toolStripContainer1.ContentPanel
        '
        Me.toolStripContainer1.ContentPanel.Controls.Add(Me.kryptonPanel1)
        Me.toolStripContainer1.ContentPanel.Size = New System.Drawing.Size(464, 289)
        Me.toolStripContainer1.Dock = System.Windows.Forms.DockStyle.Fill
        Me.toolStripContainer1.Location = New System.Drawing.Point(0, 28)
        Me.toolStripContainer1.Name = "toolStripContainer1"
        Me.toolStripContainer1.Size = New System.Drawing.Size(464, 316)
        Me.toolStripContainer1.TabIndex = 2
        Me.toolStripContainer1.Text = "toolStripContainer1"
        '
        'toolStripContainer1.TopToolStripPanel
        '
        Me.toolStripContainer1.TopToolStripPanel.Controls.Add(Me.toolStrip)
        '
        'kryptonPanel1
        '
        Me.kryptonPanel1.Controls.Add(Me.kryptonSplitContainerHorizontal)
        Me.kryptonPanel1.Dock = System.Windows.Forms.DockStyle.Fill
        Me.kryptonPanel1.Location = New System.Drawing.Point(0, 0)
        Me.kryptonPanel1.Name = "kryptonPanel1"
        Me.kryptonPanel1.Padding = New System.Windows.Forms.Padding(5)
        Me.kryptonPanel1.Size = New System.Drawing.Size(464, 289)
        Me.kryptonPanel1.TabIndex = 0
        '
        'kryptonSplitContainerHorizontal
        '
        Me.kryptonSplitContainerHorizontal.Cursor = System.Windows.Forms.Cursors.Default
        Me.kryptonSplitContainerHorizontal.Dock = System.Windows.Forms.DockStyle.Fill
        Me.kryptonSplitContainerHorizontal.Location = New System.Drawing.Point(5, 5)
        Me.kryptonSplitContainerHorizontal.Name = "kryptonSplitContainerHorizontal"
        '
        'kryptonSplitContainerHorizontal.Panel1
        '
        Me.kryptonSplitContainerHorizontal.Panel1.Controls.Add(Me.kryptonHeaderGroupLeft)
        Me.kryptonSplitContainerHorizontal.Panel1MinSize = 100
        '
        'kryptonSplitContainerHorizontal.Panel2
        '
        Me.kryptonSplitContainerHorizontal.Panel2.Controls.Add(Me.kryptonSplitContainerVertical)
        Me.kryptonSplitContainerHorizontal.Panel2MinSize = 100
        Me.kryptonSplitContainerHorizontal.Size = New System.Drawing.Size(454, 279)
        Me.kryptonSplitContainerHorizontal.SplitterDistance = 167
        Me.kryptonSplitContainerHorizontal.TabIndex = 0
        '
        'kryptonHeaderGroupLeft
        '
        Me.kryptonHeaderGroupLeft.ButtonSpecs.Add(Me.buttonSpecLeftRight)
        Me.kryptonHeaderGroupLeft.Dock = System.Windows.Forms.DockStyle.Fill
        Me.kryptonHeaderGroupLeft.HeaderVisibleSecondary = False
        Me.kryptonHeaderGroupLeft.Location = New System.Drawing.Point(0, 0)
        Me.kryptonHeaderGroupLeft.Name = "kryptonHeaderGroupLeft"
        '
        'kryptonHeaderGroupLeft.Panel
        '
        Me.kryptonHeaderGroupLeft.Panel.Controls.Add(Me.textBoxLeft)
        Me.kryptonHeaderGroupLeft.Panel.Padding = New System.Windows.Forms.Padding(5)
        Me.kryptonHeaderGroupLeft.Size = New System.Drawing.Size(167, 279)
        Me.kryptonHeaderGroupLeft.TabIndex = 0
        Me.kryptonHeaderGroupLeft.ValuesPrimary.Heading = "Left"
        Me.kryptonHeaderGroupLeft.ValuesPrimary.Image = Nothing
        '
        'buttonSpecLeftRight
        '
        Me.buttonSpecLeftRight.ColorMap = System.Drawing.Color.Black
        Me.buttonSpecLeftRight.Type = Krypton.Toolkit.PaletteButtonSpecStyle.ArrowLeft
        Me.buttonSpecLeftRight.UniqueName = "F83F8E4720614585F83F8E4720614585"
        '
        'textBoxLeft
        '
        Me.textBoxLeft.BackColor = System.Drawing.Color.White
        Me.textBoxLeft.Dock = System.Windows.Forms.DockStyle.Fill
        Me.textBoxLeft.Location = New System.Drawing.Point(5, 5)
        Me.textBoxLeft.Multiline = True
        Me.textBoxLeft.Name = "textBoxLeft"
        Me.textBoxLeft.ReadOnly = True
        Me.textBoxLeft.Size = New System.Drawing.Size(155, 231)
        Me.textBoxLeft.StateCommon.Border.Draw = Krypton.Toolkit.InheritBool.False
        Me.textBoxLeft.StateCommon.Border.DrawBorders = CType((((Krypton.Toolkit.PaletteDrawBorders.Top Or Krypton.Toolkit.PaletteDrawBorders.Bottom) Or Krypton.Toolkit.PaletteDrawBorders.Left) Or Krypton.Toolkit.PaletteDrawBorders.Right), Krypton.Toolkit.PaletteDrawBorders)
        Me.textBoxLeft.TabIndex = 0
        Me.textBoxLeft.Text = resources.GetString("textBoxLeft.Text")
        '
        'kryptonSplitContainerVertical
        '
        Me.kryptonSplitContainerVertical.Cursor = System.Windows.Forms.Cursors.Default
        Me.kryptonSplitContainerVertical.Dock = System.Windows.Forms.DockStyle.Fill
        Me.kryptonSplitContainerVertical.Location = New System.Drawing.Point(0, 0)
        Me.kryptonSplitContainerVertical.Name = "kryptonSplitContainerVertical"
        Me.kryptonSplitContainerVertical.Orientation = System.Windows.Forms.Orientation.Horizontal
        '
        'kryptonSplitContainerVertical.Panel1
        '
        Me.kryptonSplitContainerVertical.Panel1.Controls.Add(Me.kryptonHeaderGroupRightTop)
        Me.kryptonSplitContainerVertical.Panel1MinSize = 100
        '
        'kryptonSplitContainerVertical.Panel2
        '
        Me.kryptonSplitContainerVertical.Panel2.Controls.Add(Me.kryptonHeaderGroupRightBottom)
        Me.kryptonSplitContainerVertical.Panel2MinSize = 100
        Me.kryptonSplitContainerVertical.Size = New System.Drawing.Size(282, 279)
        Me.kryptonSplitContainerVertical.SplitterDistance = 123
        Me.kryptonSplitContainerVertical.TabIndex = 0
        '
        'kryptonHeaderGroupRightTop
        '
        Me.kryptonHeaderGroupRightTop.Dock = System.Windows.Forms.DockStyle.Fill
        Me.kryptonHeaderGroupRightTop.HeaderVisibleSecondary = False
        Me.kryptonHeaderGroupRightTop.Location = New System.Drawing.Point(0, 0)
        Me.kryptonHeaderGroupRightTop.Name = "kryptonHeaderGroupRightTop"
        '
        'kryptonHeaderGroupRightTop.Panel
        '
        Me.kryptonHeaderGroupRightTop.Panel.Controls.Add(Me.textBoxRightTop)
        Me.kryptonHeaderGroupRightTop.Panel.Padding = New System.Windows.Forms.Padding(5)
        Me.kryptonHeaderGroupRightTop.Size = New System.Drawing.Size(282, 123)
        Me.kryptonHeaderGroupRightTop.TabIndex = 0
        Me.kryptonHeaderGroupRightTop.ValuesPrimary.Heading = "Right Top"
        Me.kryptonHeaderGroupRightTop.ValuesPrimary.Image = Nothing
        '
        'textBoxRightTop
        '
        Me.textBoxRightTop.BackColor = System.Drawing.Color.White
        Me.textBoxRightTop.Dock = System.Windows.Forms.DockStyle.Fill
        Me.textBoxRightTop.Location = New System.Drawing.Point(5, 5)
        Me.textBoxRightTop.Multiline = True
        Me.textBoxRightTop.Name = "textBoxRightTop"
        Me.textBoxRightTop.ReadOnly = True
        Me.textBoxRightTop.Size = New System.Drawing.Size(270, 75)
        Me.textBoxRightTop.StateCommon.Border.Draw = Krypton.Toolkit.InheritBool.False
        Me.textBoxRightTop.StateCommon.Border.DrawBorders = CType((((Krypton.Toolkit.PaletteDrawBorders.Top Or Krypton.Toolkit.PaletteDrawBorders.Bottom) Or Krypton.Toolkit.PaletteDrawBorders.Left) Or Krypton.Toolkit.PaletteDrawBorders.Right), Krypton.Toolkit.PaletteDrawBorders)
        Me.textBoxRightTop.TabIndex = 0
        Me.textBoxRightTop.Text = "Use the arrow buttons on the headers to toggle the expanded/collapsed state." & vbCrLf & vbCrLf & "A step by step tutorial on building this kind of expanding/collapsing layout can be found in the help documentation."
        '
        'kryptonHeaderGroupRightBottom
        '
        Me.kryptonHeaderGroupRightBottom.ButtonSpecs.Add(Me.buttonSpecUpDown)
        Me.kryptonHeaderGroupRightBottom.Dock = System.Windows.Forms.DockStyle.Fill
        Me.kryptonHeaderGroupRightBottom.HeaderVisibleSecondary = False
        Me.kryptonHeaderGroupRightBottom.Location = New System.Drawing.Point(0, 0)
        Me.kryptonHeaderGroupRightBottom.Name = "kryptonHeaderGroupRightBottom"
        '
        'kryptonHeaderGroupRightBottom.Panel
        '
        Me.kryptonHeaderGroupRightBottom.Panel.Controls.Add(Me.textBoxRightBottom)
        Me.kryptonHeaderGroupRightBottom.Panel.Padding = New System.Windows.Forms.Padding(5)
        Me.kryptonHeaderGroupRightBottom.Size = New System.Drawing.Size(282, 151)
        Me.kryptonHeaderGroupRightBottom.TabIndex = 0
        Me.kryptonHeaderGroupRightBottom.ValuesPrimary.Heading = "Right Bottom"
        Me.kryptonHeaderGroupRightBottom.ValuesPrimary.Image = Nothing
        '
        'buttonSpecUpDown
        '
        Me.buttonSpecUpDown.ColorMap = System.Drawing.Color.Black
        Me.buttonSpecUpDown.Type = Krypton.Toolkit.PaletteButtonSpecStyle.ArrowDown
        Me.buttonSpecUpDown.UniqueName = "0A33A54B77ED443B0A33A54B77ED443B"
        '
        'textBoxRightBottom
        '
        Me.textBoxRightBottom.BackColor = System.Drawing.Color.White
        Me.textBoxRightBottom.Dock = System.Windows.Forms.DockStyle.Fill
        Me.textBoxRightBottom.Location = New System.Drawing.Point(5, 5)
        Me.textBoxRightBottom.Multiline = True
        Me.textBoxRightBottom.Name = "textBoxRightBottom"
        Me.textBoxRightBottom.ReadOnly = True
        Me.textBoxRightBottom.Size = New System.Drawing.Size(270, 103)
        Me.textBoxRightBottom.StateCommon.Border.Draw = Krypton.Toolkit.InheritBool.False
        Me.textBoxRightBottom.StateCommon.Border.DrawBorders = CType((((Krypton.Toolkit.PaletteDrawBorders.Top Or Krypton.Toolkit.PaletteDrawBorders.Bottom) Or Krypton.Toolkit.PaletteDrawBorders.Left) Or Krypton.Toolkit.PaletteDrawBorders.Right), Krypton.Toolkit.PaletteDrawBorders)
        Me.textBoxRightBottom.TabIndex = 0
        Me.textBoxRightBottom.Text = resources.GetString("textBoxRightBottom.Text")
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
        Me.toolStrip.TabIndex = 0
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
        'kryptonManager
        '
        Me.kryptonManager.GlobalPaletteMode = Krypton.Toolkit.PaletteMode.Office2007Blue
        '
        'statusStrip1
        '
        Me.statusStrip1.Font = New System.Drawing.Font("Segoe UI", 9F)
        Me.statusStrip1.ImageScalingSize = New System.Drawing.Size(20, 20)
        Me.statusStrip1.Location = New System.Drawing.Point(0, 344)
        Me.statusStrip1.Name = "statusStrip1"
        Me.statusStrip1.RenderMode = System.Windows.Forms.ToolStripRenderMode.ManagerRenderMode
        Me.statusStrip1.Size = New System.Drawing.Size(464, 22)
        Me.statusStrip1.TabIndex = 3
        Me.statusStrip1.Text = "statusStrip1"
        '
        'Form1
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8F, 17F)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(464, 366)
        Me.Controls.Add(Me.toolStripContainer1)
        Me.Controls.Add(Me.menuStrip)
        Me.Controls.Add(Me.statusStrip1)
        Me.Font = New System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.MainMenuStrip = Me.menuStrip
        Me.MaximizeBox = False
        Me.MinimizeBox = False
        Me.MinimumSize = New System.Drawing.Size(300, 300)
        Me.Name = "Form1"
        Me.Text = "Expanding HeaderGroups (Splitters)"
        Me.menuStrip.ResumeLayout(False)
        Me.menuStrip.PerformLayout()
        Me.toolStripContainer1.ContentPanel.ResumeLayout(False)
        Me.toolStripContainer1.TopToolStripPanel.ResumeLayout(False)
        Me.toolStripContainer1.TopToolStripPanel.PerformLayout()
        Me.toolStripContainer1.ResumeLayout(False)
        Me.toolStripContainer1.PerformLayout()
        CType(Me.kryptonPanel1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.kryptonPanel1.ResumeLayout(False)
        CType(Me.kryptonSplitContainerHorizontal.Panel1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.kryptonSplitContainerHorizontal.Panel1.ResumeLayout(False)
        CType(Me.kryptonSplitContainerHorizontal.Panel2, System.ComponentModel.ISupportInitialize).EndInit()
        Me.kryptonSplitContainerHorizontal.Panel2.ResumeLayout(False)
        CType(Me.kryptonSplitContainerHorizontal, System.ComponentModel.ISupportInitialize).EndInit()
        Me.kryptonSplitContainerHorizontal.ResumeLayout(False)
        CType(Me.kryptonHeaderGroupLeft.Panel, System.ComponentModel.ISupportInitialize).EndInit()
        Me.kryptonHeaderGroupLeft.Panel.ResumeLayout(False)
        Me.kryptonHeaderGroupLeft.Panel.PerformLayout()
        CType(Me.kryptonHeaderGroupLeft, System.ComponentModel.ISupportInitialize).EndInit()
        Me.kryptonHeaderGroupLeft.ResumeLayout(False)
        CType(Me.kryptonSplitContainerVertical.Panel1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.kryptonSplitContainerVertical.Panel1.ResumeLayout(False)
        CType(Me.kryptonSplitContainerVertical.Panel2, System.ComponentModel.ISupportInitialize).EndInit()
        Me.kryptonSplitContainerVertical.Panel2.ResumeLayout(False)
        CType(Me.kryptonSplitContainerVertical, System.ComponentModel.ISupportInitialize).EndInit()
        Me.kryptonSplitContainerVertical.ResumeLayout(False)
        CType(Me.kryptonHeaderGroupRightTop.Panel, System.ComponentModel.ISupportInitialize).EndInit()
        Me.kryptonHeaderGroupRightTop.Panel.ResumeLayout(False)
        Me.kryptonHeaderGroupRightTop.Panel.PerformLayout()
        CType(Me.kryptonHeaderGroupRightTop, System.ComponentModel.ISupportInitialize).EndInit()
        Me.kryptonHeaderGroupRightTop.ResumeLayout(False)
        CType(Me.kryptonHeaderGroupRightBottom.Panel, System.ComponentModel.ISupportInitialize).EndInit()
        Me.kryptonHeaderGroupRightBottom.Panel.ResumeLayout(False)
        Me.kryptonHeaderGroupRightBottom.Panel.PerformLayout()
        CType(Me.kryptonHeaderGroupRightBottom, System.ComponentModel.ISupportInitialize).EndInit()
        Me.kryptonHeaderGroupRightBottom.ResumeLayout(False)
        Me.toolStrip.ResumeLayout(False)
        Me.toolStrip.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()
    End Sub

    Friend WithEvents textBoxRightTop As Krypton.Toolkit.KryptonTextBox
    Friend WithEvents textBoxLeft As Krypton.Toolkit.KryptonTextBox
    Friend WithEvents textBoxRightBottom As Krypton.Toolkit.KryptonTextBox
    Friend WithEvents menuStrip As System.Windows.Forms.MenuStrip
    Friend WithEvents toolStrip As System.Windows.Forms.ToolStrip
    Friend WithEvents toolStripContainer1 As System.Windows.Forms.ToolStripContainer
    Friend WithEvents kryptonPanel1 As Krypton.Toolkit.KryptonPanel
    Friend WithEvents kryptonManager As Krypton.Toolkit.KryptonManager
    Friend WithEvents kryptonSplitContainerHorizontal As Krypton.Toolkit.KryptonSplitContainer
    Friend WithEvents kryptonHeaderGroupLeft As Krypton.Toolkit.KryptonHeaderGroup
    Friend WithEvents kryptonSplitContainerVertical As Krypton.Toolkit.KryptonSplitContainer
    Friend WithEvents kryptonHeaderGroupRightTop As Krypton.Toolkit.KryptonHeaderGroup
    Friend WithEvents kryptonHeaderGroupRightBottom As Krypton.Toolkit.KryptonHeaderGroup
    Friend WithEvents buttonSpecUpDown As Krypton.Toolkit.ButtonSpecHeaderGroup
    Friend WithEvents buttonSpecLeftRight As Krypton.Toolkit.ButtonSpecHeaderGroup
    Friend WithEvents fileToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents exitToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents menuSystem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents menuSparkle As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents toolStripSeparator1 As System.Windows.Forms.ToolStripSeparator
    Friend WithEvents toolSystem As System.Windows.Forms.ToolStripButton
    Friend WithEvents toolSparkle As System.Windows.Forms.ToolStripButton
    Friend WithEvents menuOffice2010 As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents menuOffice2007 As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents toolOffice2007 As System.Windows.Forms.ToolStripButton
    Friend WithEvents toolOffice2010 As System.Windows.Forms.ToolStripButton
    Friend WithEvents statusStrip1 As System.Windows.Forms.StatusStrip
End Class
