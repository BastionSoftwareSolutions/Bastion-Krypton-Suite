' VB.NET twin of Source\Krypton Toolkit Examples\Expanding HeaderGroups (DockStyle)\Form1.Designer.cs (Bastion Phase 4c).
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
        Me.toolStrip = New System.Windows.Forms.ToolStrip()
        Me.toolOffice2010 = New System.Windows.Forms.ToolStripButton()
        Me.toolOffice2007 = New System.Windows.Forms.ToolStripButton()
        Me.toolSparkle = New System.Windows.Forms.ToolStripButton()
        Me.toolSystem = New System.Windows.Forms.ToolStripButton()
        Me.toolStripContainer = New System.Windows.Forms.ToolStripContainer()
        Me.kryptonPanel1 = New Krypton.Toolkit.KryptonPanel()
        Me.groupFiller = New Krypton.Toolkit.KryptonGroup()
        Me.textBoxMainFill = New Krypton.Toolkit.KryptonTextBox()
        Me.header2Border = New Krypton.Toolkit.KryptonPanel()
        Me.header2 = New Krypton.Toolkit.KryptonHeaderGroup()
        Me.buttonSpecHeaderGroup1 = New Krypton.Toolkit.ButtonSpecHeaderGroup()
        Me.textBox3 = New Krypton.Toolkit.KryptonTextBox()
        Me.textBox2 = New Krypton.Toolkit.KryptonTextBox()
        Me.labelPosition = New Krypton.Toolkit.KryptonLabel()
        Me.labelAge = New Krypton.Toolkit.KryptonLabel()
        Me.textBox1 = New Krypton.Toolkit.KryptonTextBox()
        Me.textBoxFirstName = New Krypton.Toolkit.KryptonTextBox()
        Me.labelLastName = New Krypton.Toolkit.KryptonLabel()
        Me.labelFirstName = New Krypton.Toolkit.KryptonLabel()
        Me.header1Border = New Krypton.Toolkit.KryptonPanel()
        Me.header1 = New Krypton.Toolkit.KryptonHeaderGroup()
        Me.header1ButtonSpec = New Krypton.Toolkit.ButtonSpecHeaderGroup()
        Me.kryptonButtonPrevious = New Krypton.Toolkit.KryptonButton()
        Me.textBoxFind = New Krypton.Toolkit.KryptonTextBox()
        Me.kryptonButtonNext = New Krypton.Toolkit.KryptonButton()
        Me.labelFind = New Krypton.Toolkit.KryptonLabel()
        Me.kryptonManager = New Krypton.Toolkit.KryptonManager(Me.components)
        Me.statusStrip1 = New System.Windows.Forms.StatusStrip()
        Me.menuStrip.SuspendLayout()
        Me.toolStrip.SuspendLayout()
        Me.toolStripContainer.ContentPanel.SuspendLayout()
        Me.toolStripContainer.TopToolStripPanel.SuspendLayout()
        Me.toolStripContainer.SuspendLayout()
        CType(Me.kryptonPanel1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.kryptonPanel1.SuspendLayout()
        CType(Me.groupFiller, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.groupFiller.Panel, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.groupFiller.Panel.SuspendLayout()
        Me.groupFiller.SuspendLayout()
        CType(Me.header2Border, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.header2, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.header2.Panel, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.header2.Panel.SuspendLayout()
        Me.header2.SuspendLayout()
        CType(Me.header1Border, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.header1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.header1.Panel, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.header1.Panel.SuspendLayout()
        Me.header1.SuspendLayout()
        Me.SuspendLayout()
        '
        'menuStrip
        '
        Me.menuStrip.Font = New System.Drawing.Font("Segoe UI", 9F)
        Me.menuStrip.ImageScalingSize = New System.Drawing.Size(20, 20)
        Me.menuStrip.Items.AddRange(New System.Windows.Forms.ToolStripItem() { Me.fileToolStripMenuItem})
        Me.menuStrip.Location = New System.Drawing.Point(0, 0)
        Me.menuStrip.Name = "menuStrip"
        Me.menuStrip.Size = New System.Drawing.Size(373, 28)
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
        Me.toolStrip.Text = "toolStrip1"
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
        'toolStripContainer
        '
        '
        'toolStripContainer.ContentPanel
        '
        Me.toolStripContainer.ContentPanel.Controls.Add(Me.kryptonPanel1)
        Me.toolStripContainer.ContentPanel.Size = New System.Drawing.Size(373, 272)
        Me.toolStripContainer.Dock = System.Windows.Forms.DockStyle.Fill
        Me.toolStripContainer.Location = New System.Drawing.Point(0, 28)
        Me.toolStripContainer.Name = "toolStripContainer"
        Me.toolStripContainer.Size = New System.Drawing.Size(373, 299)
        Me.toolStripContainer.TabIndex = 1
        Me.toolStripContainer.Text = "toolStripContainer1"
        '
        'toolStripContainer.TopToolStripPanel
        '
        Me.toolStripContainer.TopToolStripPanel.Controls.Add(Me.toolStrip)
        '
        'kryptonPanel1
        '
        Me.kryptonPanel1.Controls.Add(Me.groupFiller)
        Me.kryptonPanel1.Controls.Add(Me.header2Border)
        Me.kryptonPanel1.Controls.Add(Me.header2)
        Me.kryptonPanel1.Controls.Add(Me.header1Border)
        Me.kryptonPanel1.Controls.Add(Me.header1)
        Me.kryptonPanel1.Dock = System.Windows.Forms.DockStyle.Fill
        Me.kryptonPanel1.Location = New System.Drawing.Point(0, 0)
        Me.kryptonPanel1.Name = "kryptonPanel1"
        Me.kryptonPanel1.Padding = New System.Windows.Forms.Padding(5)
        Me.kryptonPanel1.Size = New System.Drawing.Size(373, 272)
        Me.kryptonPanel1.TabIndex = 0
        '
        'groupFiller
        '
        Me.groupFiller.Dock = System.Windows.Forms.DockStyle.Fill
        Me.groupFiller.Location = New System.Drawing.Point(5, 214)
        '
        'groupFiller.Panel
        '
        Me.groupFiller.Panel.Controls.Add(Me.textBoxMainFill)
        Me.groupFiller.Panel.Padding = New System.Windows.Forms.Padding(5)
        Me.groupFiller.Size = New System.Drawing.Size(363, 53)
        Me.groupFiller.TabIndex = 2
        '
        'textBoxMainFill
        '
        Me.textBoxMainFill.Dock = System.Windows.Forms.DockStyle.Fill
        Me.textBoxMainFill.Location = New System.Drawing.Point(5, 5)
        Me.textBoxMainFill.Multiline = True
        Me.textBoxMainFill.Name = "textBoxMainFill"
        Me.textBoxMainFill.Size = New System.Drawing.Size(351, 41)
        Me.textBoxMainFill.StateCommon.Border.Draw = Krypton.Toolkit.InheritBool.False
        Me.textBoxMainFill.StateCommon.Border.DrawBorders = CType((((Krypton.Toolkit.PaletteDrawBorders.Top Or Krypton.Toolkit.PaletteDrawBorders.Bottom) Or Krypton.Toolkit.PaletteDrawBorders.Left) Or Krypton.Toolkit.PaletteDrawBorders.Right), Krypton.Toolkit.PaletteDrawBorders)
        Me.textBoxMainFill.TabIndex = 0
        Me.textBoxMainFill.Text = resources.GetString("textBoxMainFill.Text")
        '
        'header2Border
        '
        Me.header2Border.Dock = System.Windows.Forms.DockStyle.Top
        Me.header2Border.Location = New System.Drawing.Point(5, 209)
        Me.header2Border.Name = "header2Border"
        Me.header2Border.Size = New System.Drawing.Size(363, 5)
        Me.header2Border.TabIndex = 3
        '
        'header2
        '
        Me.header2.AutoSize = True
        Me.header2.ButtonSpecs.Add(Me.buttonSpecHeaderGroup1)
        Me.header2.Dock = System.Windows.Forms.DockStyle.Top
        Me.header2.GroupBackStyle = Krypton.Toolkit.PaletteBackStyle.PanelAlternate
        Me.header2.HeaderVisibleSecondary = False
        Me.header2.Location = New System.Drawing.Point(5, 97)
        '
        'header2.Panel
        '
        Me.header2.Panel.Controls.Add(Me.textBox3)
        Me.header2.Panel.Controls.Add(Me.textBox2)
        Me.header2.Panel.Controls.Add(Me.labelPosition)
        Me.header2.Panel.Controls.Add(Me.labelAge)
        Me.header2.Panel.Controls.Add(Me.textBox1)
        Me.header2.Panel.Controls.Add(Me.textBoxFirstName)
        Me.header2.Panel.Controls.Add(Me.labelLastName)
        Me.header2.Panel.Controls.Add(Me.labelFirstName)
        Me.header2.Panel.Padding = New System.Windows.Forms.Padding(10, 9, 10, 9)
        Me.header2.Size = New System.Drawing.Size(363, 112)
        Me.header2.TabIndex = 1
        Me.header2.ValuesPrimary.Heading = "User Details"
        Me.header2.ValuesPrimary.Image = CType(resources.GetObject("header2.ValuesPrimary.Image"), System.Drawing.Image)
        '
        'buttonSpecHeaderGroup1
        '
        Me.buttonSpecHeaderGroup1.Type = Krypton.Toolkit.PaletteButtonSpecStyle.ArrowUp
        Me.buttonSpecHeaderGroup1.UniqueName = "4A15006157B94C7D4A15006157B94C7D"
        '
        'textBox3
        '
        Me.textBox3.Location = New System.Drawing.Point(240, 36)
        Me.textBox3.Name = "textBox3"
        Me.textBox3.Size = New System.Drawing.Size(94, 27)
        Me.textBox3.TabIndex = 3
        Me.textBox3.Text = "Roman Emperor"
        '
        'textBox2
        '
        Me.textBox2.Location = New System.Drawing.Point(240, 10)
        Me.textBox2.Name = "textBox2"
        Me.textBox2.Size = New System.Drawing.Size(94, 27)
        Me.textBox2.TabIndex = 1
        Me.textBox2.Text = "24"
        '
        'labelPosition
        '
        Me.labelPosition.Location = New System.Drawing.Point(186, 35)
        Me.labelPosition.Name = "labelPosition"
        Me.labelPosition.Size = New System.Drawing.Size(66, 24)
        Me.labelPosition.TabIndex = 4
        Me.labelPosition.Values.Text = "Position"
        '
        'labelAge
        '
        Me.labelAge.Location = New System.Drawing.Point(185, 11)
        Me.labelAge.Name = "labelAge"
        Me.labelAge.Size = New System.Drawing.Size(39, 24)
        Me.labelAge.TabIndex = 3
        Me.labelAge.Values.Text = "Age"
        '
        'textBox1
        '
        Me.textBox1.Location = New System.Drawing.Point(82, 36)
        Me.textBox1.Name = "textBox1"
        Me.textBox1.Size = New System.Drawing.Size(89, 27)
        Me.textBox1.TabIndex = 2
        Me.textBox1.Text = "Ceaser"
        '
        'textBoxFirstName
        '
        Me.textBoxFirstName.Location = New System.Drawing.Point(82, 10)
        Me.textBoxFirstName.Name = "textBoxFirstName"
        Me.textBoxFirstName.Size = New System.Drawing.Size(89, 27)
        Me.textBoxFirstName.TabIndex = 0
        Me.textBoxFirstName.Text = "Augustus"
        '
        'labelLastName
        '
        Me.labelLastName.Location = New System.Drawing.Point(10, 35)
        Me.labelLastName.Name = "labelLastName"
        Me.labelLastName.Size = New System.Drawing.Size(83, 24)
        Me.labelLastName.TabIndex = 2
        Me.labelLastName.Values.Text = "Last Name"
        '
        'labelFirstName
        '
        Me.labelFirstName.Location = New System.Drawing.Point(10, 11)
        Me.labelFirstName.Name = "labelFirstName"
        Me.labelFirstName.Size = New System.Drawing.Size(85, 24)
        Me.labelFirstName.TabIndex = 1
        Me.labelFirstName.Values.Text = "First Name"
        '
        'header1Border
        '
        Me.header1Border.Dock = System.Windows.Forms.DockStyle.Top
        Me.header1Border.Location = New System.Drawing.Point(5, 92)
        Me.header1Border.Name = "header1Border"
        Me.header1Border.Size = New System.Drawing.Size(363, 5)
        Me.header1Border.TabIndex = 1
        '
        'header1
        '
        Me.header1.AutoSize = True
        Me.header1.ButtonSpecs.Add(Me.header1ButtonSpec)
        Me.header1.Dock = System.Windows.Forms.DockStyle.Top
        Me.header1.GroupBackStyle = Krypton.Toolkit.PaletteBackStyle.PanelAlternate
        Me.header1.HeaderVisibleSecondary = False
        Me.header1.Location = New System.Drawing.Point(5, 5)
        '
        'header1.Panel
        '
        Me.header1.Panel.Controls.Add(Me.kryptonButtonPrevious)
        Me.header1.Panel.Controls.Add(Me.textBoxFind)
        Me.header1.Panel.Controls.Add(Me.kryptonButtonNext)
        Me.header1.Panel.Controls.Add(Me.labelFind)
        Me.header1.Panel.Padding = New System.Windows.Forms.Padding(10, 9, 10, 9)
        Me.header1.Size = New System.Drawing.Size(363, 87)
        Me.header1.TabIndex = 0
        Me.header1.ValuesPrimary.Heading = "Find"
        Me.header1.ValuesPrimary.Image = CType(resources.GetObject("header1.ValuesPrimary.Image"), System.Drawing.Image)
        '
        'header1ButtonSpec
        '
        Me.header1ButtonSpec.Type = Krypton.Toolkit.PaletteButtonSpecStyle.ArrowUp
        Me.header1ButtonSpec.UniqueName = "3F21FD013FD447823F21FD013FD44782"
        '
        'kryptonButtonPrevious
        '
        Me.kryptonButtonPrevious.AutoSize = True
        Me.kryptonButtonPrevious.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink
        Me.kryptonButtonPrevious.Location = New System.Drawing.Point(232, 10)
        Me.kryptonButtonPrevious.Name = "kryptonButtonPrevious"
        Me.kryptonButtonPrevious.Size = New System.Drawing.Size(56, 28)
        Me.kryptonButtonPrevious.TabIndex = 1
        Me.kryptonButtonPrevious.Values.DropDownArrowColor = System.Drawing.Color.Empty
        Me.kryptonButtonPrevious.Values.Text = "< Prev"
        '
        'textBoxFind
        '
        Me.textBoxFind.Location = New System.Drawing.Point(47, 10)
        Me.textBoxFind.Name = "textBoxFind"
        Me.textBoxFind.Size = New System.Drawing.Size(171, 27)
        Me.textBoxFind.TabIndex = 0
        Me.textBoxFind.Text = "example string"
        '
        'kryptonButtonNext
        '
        Me.kryptonButtonNext.AutoSize = True
        Me.kryptonButtonNext.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink
        Me.kryptonButtonNext.Location = New System.Drawing.Point(287, 10)
        Me.kryptonButtonNext.Name = "kryptonButtonNext"
        Me.kryptonButtonNext.Size = New System.Drawing.Size(58, 28)
        Me.kryptonButtonNext.TabIndex = 2
        Me.kryptonButtonNext.Values.DropDownArrowColor = System.Drawing.Color.Empty
        Me.kryptonButtonNext.Values.Text = "Next >"
        '
        'labelFind
        '
        Me.labelFind.Location = New System.Drawing.Point(10, 11)
        Me.labelFind.Name = "labelFind"
        Me.labelFind.Size = New System.Drawing.Size(40, 24)
        Me.labelFind.TabIndex = 0
        Me.labelFind.Values.Text = "Text"
        '
        'kryptonManager
        '
        Me.kryptonManager.GlobalPaletteMode = Krypton.Toolkit.PaletteMode.Office2010Blue
        '
        'statusStrip1
        '
        Me.statusStrip1.Font = New System.Drawing.Font("Segoe UI", 9F)
        Me.statusStrip1.ImageScalingSize = New System.Drawing.Size(20, 20)
        Me.statusStrip1.Location = New System.Drawing.Point(0, 327)
        Me.statusStrip1.Name = "statusStrip1"
        Me.statusStrip1.RenderMode = System.Windows.Forms.ToolStripRenderMode.ManagerRenderMode
        Me.statusStrip1.Size = New System.Drawing.Size(373, 22)
        Me.statusStrip1.TabIndex = 2
        Me.statusStrip1.Text = "statusStrip1"
        '
        'Form1
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8F, 16F)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(373, 349)
        Me.Controls.Add(Me.toolStripContainer)
        Me.Controls.Add(Me.menuStrip)
        Me.Controls.Add(Me.statusStrip1)
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.MainMenuStrip = Me.menuStrip
        Me.MaximizeBox = False
        Me.MinimizeBox = False
        Me.Name = "Form1"
        Me.Text = "Expanding HeaderGroups (DockStyle)"
        Me.menuStrip.ResumeLayout(False)
        Me.menuStrip.PerformLayout()
        Me.toolStrip.ResumeLayout(False)
        Me.toolStrip.PerformLayout()
        Me.toolStripContainer.ContentPanel.ResumeLayout(False)
        Me.toolStripContainer.TopToolStripPanel.ResumeLayout(False)
        Me.toolStripContainer.TopToolStripPanel.PerformLayout()
        Me.toolStripContainer.ResumeLayout(False)
        Me.toolStripContainer.PerformLayout()
        CType(Me.kryptonPanel1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.kryptonPanel1.ResumeLayout(False)
        Me.kryptonPanel1.PerformLayout()
        CType(Me.groupFiller.Panel, System.ComponentModel.ISupportInitialize).EndInit()
        Me.groupFiller.Panel.ResumeLayout(False)
        Me.groupFiller.Panel.PerformLayout()
        CType(Me.groupFiller, System.ComponentModel.ISupportInitialize).EndInit()
        Me.groupFiller.ResumeLayout(False)
        CType(Me.header2Border, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.header2.Panel, System.ComponentModel.ISupportInitialize).EndInit()
        Me.header2.Panel.ResumeLayout(False)
        Me.header2.Panel.PerformLayout()
        CType(Me.header2, System.ComponentModel.ISupportInitialize).EndInit()
        Me.header2.ResumeLayout(False)
        CType(Me.header1Border, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.header1.Panel, System.ComponentModel.ISupportInitialize).EndInit()
        Me.header1.Panel.ResumeLayout(False)
        Me.header1.Panel.PerformLayout()
        CType(Me.header1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.header1.ResumeLayout(False)
        Me.ResumeLayout(False)
        Me.PerformLayout()
    End Sub

    Friend WithEvents menuStrip As System.Windows.Forms.MenuStrip
    Friend WithEvents toolStrip As System.Windows.Forms.ToolStrip
    Friend WithEvents toolStripContainer As System.Windows.Forms.ToolStripContainer
    Friend WithEvents kryptonManager As Krypton.Toolkit.KryptonManager
    Friend WithEvents fileToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents exitToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents menuSystem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents menuSparkle As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents toolStripSeparator1 As System.Windows.Forms.ToolStripSeparator
    Friend WithEvents toolSystem As System.Windows.Forms.ToolStripButton
    Friend WithEvents toolSparkle As System.Windows.Forms.ToolStripButton
    Friend WithEvents kryptonPanel1 As Krypton.Toolkit.KryptonPanel
    Friend WithEvents groupFiller As Krypton.Toolkit.KryptonGroup
    Friend WithEvents header2Border As Krypton.Toolkit.KryptonPanel
    Friend WithEvents header2 As Krypton.Toolkit.KryptonHeaderGroup
    Friend WithEvents buttonSpecHeaderGroup1 As Krypton.Toolkit.ButtonSpecHeaderGroup
    Friend WithEvents header1Border As Krypton.Toolkit.KryptonPanel
    Friend WithEvents header1 As Krypton.Toolkit.KryptonHeaderGroup
    Friend WithEvents header1ButtonSpec As Krypton.Toolkit.ButtonSpecHeaderGroup
    Friend WithEvents kryptonButtonNext As Krypton.Toolkit.KryptonButton
    Friend WithEvents labelFind As Krypton.Toolkit.KryptonLabel
    Friend WithEvents textBoxFind As Krypton.Toolkit.KryptonTextBox
    Friend WithEvents textBoxFirstName As Krypton.Toolkit.KryptonTextBox
    Friend WithEvents labelLastName As Krypton.Toolkit.KryptonLabel
    Friend WithEvents labelFirstName As Krypton.Toolkit.KryptonLabel
    Friend WithEvents textBoxMainFill As Krypton.Toolkit.KryptonTextBox
    Friend WithEvents textBox1 As Krypton.Toolkit.KryptonTextBox
    Friend WithEvents textBox3 As Krypton.Toolkit.KryptonTextBox
    Friend WithEvents textBox2 As Krypton.Toolkit.KryptonTextBox
    Friend WithEvents labelPosition As Krypton.Toolkit.KryptonLabel
    Friend WithEvents labelAge As Krypton.Toolkit.KryptonLabel
    Friend WithEvents kryptonButtonPrevious As Krypton.Toolkit.KryptonButton
    Friend WithEvents toolOffice2007 As System.Windows.Forms.ToolStripButton
    Friend WithEvents toolOffice2010 As System.Windows.Forms.ToolStripButton
    Friend WithEvents menuOffice2010 As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents menuOffice2007 As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents statusStrip1 As System.Windows.Forms.StatusStrip
End Class
