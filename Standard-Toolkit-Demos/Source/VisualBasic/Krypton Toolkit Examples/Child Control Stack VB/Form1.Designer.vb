' VB.NET twin of Source\Krypton Toolkit Examples\Child Control Stack\Form1.Designer.cs (Bastion Phase 4c).
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
        Me.toolStrip = New System.Windows.Forms.ToolStrip()
        Me.toolOffice2010 = New System.Windows.Forms.ToolStripButton()
        Me.toolOffice2007 = New System.Windows.Forms.ToolStripButton()
        Me.toolSparkle = New System.Windows.Forms.ToolStripButton()
        Me.toolSystem = New System.Windows.Forms.ToolStripButton()
        Me.menuStrip = New System.Windows.Forms.MenuStrip()
        Me.toolStripMenuItem1 = New System.Windows.Forms.ToolStripMenuItem()
        Me.menuOffice2010 = New System.Windows.Forms.ToolStripMenuItem()
        Me.menuOffice2007 = New System.Windows.Forms.ToolStripMenuItem()
        Me.menuSparkle = New System.Windows.Forms.ToolStripMenuItem()
        Me.menuSystem = New System.Windows.Forms.ToolStripMenuItem()
        Me.toolStripSeparator1 = New System.Windows.Forms.ToolStripSeparator()
        Me.exitToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.toolStripContainer1 = New System.Windows.Forms.ToolStripContainer()
        Me.kryptonPanelMain = New Krypton.Toolkit.KryptonPanel()
        Me.kryptonGroupMain = New Krypton.Toolkit.KryptonGroup()
        Me.textBoxFiller = New Krypton.Toolkit.KryptonTextBox()
        Me.kryptonBorderEdge5 = New Krypton.Toolkit.KryptonBorderEdge()
        Me.kryptonHeader = New Krypton.Toolkit.KryptonHeader()
        Me.kryptonBorderEdge4 = New Krypton.Toolkit.KryptonBorderEdge()
        Me.kryptonCheckButton4 = New Krypton.Toolkit.KryptonCheckButton()
        Me.kryptonBorderEdge3 = New Krypton.Toolkit.KryptonBorderEdge()
        Me.kryptonCheckButton3 = New Krypton.Toolkit.KryptonCheckButton()
        Me.kryptonBorderEdge2 = New Krypton.Toolkit.KryptonBorderEdge()
        Me.kryptonCheckButton2 = New Krypton.Toolkit.KryptonCheckButton()
        Me.kryptonBorderEdge1 = New Krypton.Toolkit.KryptonBorderEdge()
        Me.kryptonCheckButton1 = New Krypton.Toolkit.KryptonCheckButton()
        Me.kryptonCheckSet = New Krypton.Toolkit.KryptonCheckSet(Me.components)
        Me.kryptonManager = New Krypton.Toolkit.KryptonManager(Me.components)
        Me.toolStrip.SuspendLayout()
        Me.menuStrip.SuspendLayout()
        Me.toolStripContainer1.ContentPanel.SuspendLayout()
        Me.toolStripContainer1.TopToolStripPanel.SuspendLayout()
        Me.toolStripContainer1.SuspendLayout()
        CType(Me.kryptonPanelMain, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.kryptonPanelMain.SuspendLayout()
        CType(Me.kryptonGroupMain, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.kryptonGroupMain.Panel, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.kryptonGroupMain.Panel.SuspendLayout()
        Me.kryptonGroupMain.SuspendLayout()
        CType(Me.kryptonCheckSet, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
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
        Me.toolStrip.TabIndex = 3
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
        Me.toolSystem.ImageTransparentColor = System.Drawing.Color.YellowGreen
        Me.toolSystem.Name = "toolSystem"
        Me.toolSystem.Size = New System.Drawing.Size(60, 24)
        Me.toolSystem.Text = "System"
        '
        'menuStrip
        '
        Me.menuStrip.Font = New System.Drawing.Font("Segoe UI", 9F)
        Me.menuStrip.ImageScalingSize = New System.Drawing.Size(20, 20)
        Me.menuStrip.Items.AddRange(New System.Windows.Forms.ToolStripItem() { Me.toolStripMenuItem1})
        Me.menuStrip.Location = New System.Drawing.Point(0, 0)
        Me.menuStrip.Name = "menuStrip"
        Me.menuStrip.Size = New System.Drawing.Size(330, 28)
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
        'toolStripContainer1
        '
        '
        'toolStripContainer1.ContentPanel
        '
        Me.toolStripContainer1.ContentPanel.Controls.Add(Me.kryptonPanelMain)
        Me.toolStripContainer1.ContentPanel.Size = New System.Drawing.Size(330, 221)
        Me.toolStripContainer1.Dock = System.Windows.Forms.DockStyle.Fill
        Me.toolStripContainer1.Location = New System.Drawing.Point(0, 28)
        Me.toolStripContainer1.Name = "toolStripContainer1"
        Me.toolStripContainer1.Size = New System.Drawing.Size(330, 248)
        Me.toolStripContainer1.TabIndex = 4
        Me.toolStripContainer1.Text = "toolStripContainer1"
        '
        'toolStripContainer1.TopToolStripPanel
        '
        Me.toolStripContainer1.TopToolStripPanel.Controls.Add(Me.toolStrip)
        '
        'kryptonPanelMain
        '
        Me.kryptonPanelMain.Controls.Add(Me.kryptonGroupMain)
        Me.kryptonPanelMain.Dock = System.Windows.Forms.DockStyle.Fill
        Me.kryptonPanelMain.Location = New System.Drawing.Point(0, 0)
        Me.kryptonPanelMain.Name = "kryptonPanelMain"
        Me.kryptonPanelMain.Padding = New System.Windows.Forms.Padding(5)
        Me.kryptonPanelMain.Size = New System.Drawing.Size(330, 221)
        Me.kryptonPanelMain.TabIndex = 0
        '
        'kryptonGroupMain
        '
        Me.kryptonGroupMain.Dock = System.Windows.Forms.DockStyle.Fill
        Me.kryptonGroupMain.Location = New System.Drawing.Point(5, 5)
        '
        'kryptonGroupMain.Panel
        '
        Me.kryptonGroupMain.Panel.Controls.Add(Me.textBoxFiller)
        Me.kryptonGroupMain.Panel.Controls.Add(Me.kryptonBorderEdge5)
        Me.kryptonGroupMain.Panel.Controls.Add(Me.kryptonHeader)
        Me.kryptonGroupMain.Panel.Controls.Add(Me.kryptonBorderEdge4)
        Me.kryptonGroupMain.Panel.Controls.Add(Me.kryptonCheckButton4)
        Me.kryptonGroupMain.Panel.Controls.Add(Me.kryptonBorderEdge3)
        Me.kryptonGroupMain.Panel.Controls.Add(Me.kryptonCheckButton3)
        Me.kryptonGroupMain.Panel.Controls.Add(Me.kryptonBorderEdge2)
        Me.kryptonGroupMain.Panel.Controls.Add(Me.kryptonCheckButton2)
        Me.kryptonGroupMain.Panel.Controls.Add(Me.kryptonBorderEdge1)
        Me.kryptonGroupMain.Panel.Controls.Add(Me.kryptonCheckButton1)
        Me.kryptonGroupMain.Size = New System.Drawing.Size(320, 211)
        Me.kryptonGroupMain.TabIndex = 0
        '
        'textBoxFiller
        '
        Me.textBoxFiller.Dock = System.Windows.Forms.DockStyle.Fill
        Me.textBoxFiller.Location = New System.Drawing.Point(0, 36)
        Me.textBoxFiller.Multiline = True
        Me.textBoxFiller.Name = "textBoxFiller"
        Me.textBoxFiller.Size = New System.Drawing.Size(318, 73)
        Me.textBoxFiller.StateCommon.Border.Draw = Krypton.Toolkit.InheritBool.False
        Me.textBoxFiller.StateCommon.Border.DrawBorders = CType((((Krypton.Toolkit.PaletteDrawBorders.Top Or Krypton.Toolkit.PaletteDrawBorders.Bottom) Or Krypton.Toolkit.PaletteDrawBorders.Left) Or Krypton.Toolkit.PaletteDrawBorders.Right), Krypton.Toolkit.PaletteDrawBorders)
        Me.textBoxFiller.TabIndex = 0
        Me.textBoxFiller.Text = resources.GetString("textBoxFiller.Text")
        '
        'kryptonBorderEdge5
        '
        Me.kryptonBorderEdge5.Dock = System.Windows.Forms.DockStyle.Top
        Me.kryptonBorderEdge5.Location = New System.Drawing.Point(0, 35)
        Me.kryptonBorderEdge5.Name = "kryptonBorderEdge5"
        Me.kryptonBorderEdge5.Size = New System.Drawing.Size(318, 1)
        Me.kryptonBorderEdge5.Text = "kryptonBorderEdge5"
        '
        'kryptonHeader
        '
        Me.kryptonHeader.Dock = System.Windows.Forms.DockStyle.Top
        Me.kryptonHeader.Location = New System.Drawing.Point(0, 0)
        Me.kryptonHeader.Name = "kryptonHeader"
        Me.kryptonHeader.Size = New System.Drawing.Size(318, 35)
        Me.kryptonHeader.StateCommon.Border.DrawBorders = Krypton.Toolkit.PaletteDrawBorders.None
        Me.kryptonHeader.TabIndex = 5
        Me.kryptonHeader.Values.Description = ""
        Me.kryptonHeader.Values.Heading = "Calendar"
        Me.kryptonHeader.Values.Image = Nothing
        '
        'kryptonBorderEdge4
        '
        Me.kryptonBorderEdge4.Dock = System.Windows.Forms.DockStyle.Bottom
        Me.kryptonBorderEdge4.Location = New System.Drawing.Point(0, 109)
        Me.kryptonBorderEdge4.Name = "kryptonBorderEdge4"
        Me.kryptonBorderEdge4.Size = New System.Drawing.Size(318, 1)
        Me.kryptonBorderEdge4.Text = "kryptonBorderEdge4"
        '
        'kryptonCheckButton4
        '
        Me.kryptonCheckButton4.Dock = System.Windows.Forms.DockStyle.Bottom
        Me.kryptonCheckButton4.Location = New System.Drawing.Point(0, 110)
        Me.kryptonCheckButton4.Name = "kryptonCheckButton4"
        Me.kryptonCheckButton4.Size = New System.Drawing.Size(318, 24)
        Me.kryptonCheckButton4.StateCommon.Border.DrawBorders = Krypton.Toolkit.PaletteDrawBorders.None
        Me.kryptonCheckButton4.StateCommon.Content.Image.ImageH = Krypton.Toolkit.PaletteRelativeAlign.Near
        Me.kryptonCheckButton4.StateCommon.Content.Image.ImageV = Krypton.Toolkit.PaletteRelativeAlign.Center
        Me.kryptonCheckButton4.StateCommon.Content.LongText.TextH = Krypton.Toolkit.PaletteRelativeAlign.Far
        Me.kryptonCheckButton4.StateCommon.Content.LongText.TextV = Krypton.Toolkit.PaletteRelativeAlign.Center
        Me.kryptonCheckButton4.StateCommon.Content.ShortText.TextH = Krypton.Toolkit.PaletteRelativeAlign.Near
        Me.kryptonCheckButton4.StateCommon.Content.ShortText.TextV = Krypton.Toolkit.PaletteRelativeAlign.Center
        Me.kryptonCheckButton4.TabIndex = 2
        Me.kryptonCheckButton4.Values.DropDownArrowColor = System.Drawing.Color.Empty
        Me.kryptonCheckButton4.Values.Image = CType(resources.GetObject("kryptonCheckButton4.Values.Image"), System.Drawing.Image)
        Me.kryptonCheckButton4.Values.Text = "Tasks"
        '
        'kryptonBorderEdge3
        '
        Me.kryptonBorderEdge3.Dock = System.Windows.Forms.DockStyle.Bottom
        Me.kryptonBorderEdge3.Location = New System.Drawing.Point(0, 134)
        Me.kryptonBorderEdge3.Name = "kryptonBorderEdge3"
        Me.kryptonBorderEdge3.Size = New System.Drawing.Size(318, 1)
        Me.kryptonBorderEdge3.Text = "kryptonBorderEdge3"
        '
        'kryptonCheckButton3
        '
        Me.kryptonCheckButton3.Dock = System.Windows.Forms.DockStyle.Bottom
        Me.kryptonCheckButton3.Location = New System.Drawing.Point(0, 135)
        Me.kryptonCheckButton3.Name = "kryptonCheckButton3"
        Me.kryptonCheckButton3.Size = New System.Drawing.Size(318, 24)
        Me.kryptonCheckButton3.StateCommon.Border.DrawBorders = Krypton.Toolkit.PaletteDrawBorders.None
        Me.kryptonCheckButton3.StateCommon.Content.Image.ImageH = Krypton.Toolkit.PaletteRelativeAlign.Near
        Me.kryptonCheckButton3.StateCommon.Content.Image.ImageV = Krypton.Toolkit.PaletteRelativeAlign.Center
        Me.kryptonCheckButton3.StateCommon.Content.LongText.TextH = Krypton.Toolkit.PaletteRelativeAlign.Far
        Me.kryptonCheckButton3.StateCommon.Content.LongText.TextV = Krypton.Toolkit.PaletteRelativeAlign.Center
        Me.kryptonCheckButton3.StateCommon.Content.ShortText.TextH = Krypton.Toolkit.PaletteRelativeAlign.Near
        Me.kryptonCheckButton3.StateCommon.Content.ShortText.TextV = Krypton.Toolkit.PaletteRelativeAlign.Center
        Me.kryptonCheckButton3.TabIndex = 3
        Me.kryptonCheckButton3.Values.DropDownArrowColor = System.Drawing.Color.Empty
        Me.kryptonCheckButton3.Values.Image = CType(resources.GetObject("kryptonCheckButton3.Values.Image"), System.Drawing.Image)
        Me.kryptonCheckButton3.Values.Text = "Mail"
        '
        'kryptonBorderEdge2
        '
        Me.kryptonBorderEdge2.Dock = System.Windows.Forms.DockStyle.Bottom
        Me.kryptonBorderEdge2.Location = New System.Drawing.Point(0, 159)
        Me.kryptonBorderEdge2.Name = "kryptonBorderEdge2"
        Me.kryptonBorderEdge2.Size = New System.Drawing.Size(318, 1)
        Me.kryptonBorderEdge2.Text = "kryptonBorderEdge2"
        '
        'kryptonCheckButton2
        '
        Me.kryptonCheckButton2.Checked = True
        Me.kryptonCheckButton2.Dock = System.Windows.Forms.DockStyle.Bottom
        Me.kryptonCheckButton2.Location = New System.Drawing.Point(0, 160)
        Me.kryptonCheckButton2.Name = "kryptonCheckButton2"
        Me.kryptonCheckButton2.Size = New System.Drawing.Size(318, 24)
        Me.kryptonCheckButton2.StateCommon.Border.DrawBorders = Krypton.Toolkit.PaletteDrawBorders.None
        Me.kryptonCheckButton2.StateCommon.Content.Image.ImageH = Krypton.Toolkit.PaletteRelativeAlign.Near
        Me.kryptonCheckButton2.StateCommon.Content.Image.ImageV = Krypton.Toolkit.PaletteRelativeAlign.Center
        Me.kryptonCheckButton2.StateCommon.Content.LongText.TextH = Krypton.Toolkit.PaletteRelativeAlign.Far
        Me.kryptonCheckButton2.StateCommon.Content.LongText.TextV = Krypton.Toolkit.PaletteRelativeAlign.Center
        Me.kryptonCheckButton2.StateCommon.Content.ShortText.TextH = Krypton.Toolkit.PaletteRelativeAlign.Near
        Me.kryptonCheckButton2.StateCommon.Content.ShortText.TextV = Krypton.Toolkit.PaletteRelativeAlign.Center
        Me.kryptonCheckButton2.TabIndex = 4
        Me.kryptonCheckButton2.Values.DropDownArrowColor = System.Drawing.Color.Empty
        Me.kryptonCheckButton2.Values.Image = CType(resources.GetObject("kryptonCheckButton2.Values.Image"), System.Drawing.Image)
        Me.kryptonCheckButton2.Values.Text = "Calendar"
        '
        'kryptonBorderEdge1
        '
        Me.kryptonBorderEdge1.Dock = System.Windows.Forms.DockStyle.Bottom
        Me.kryptonBorderEdge1.Location = New System.Drawing.Point(0, 184)
        Me.kryptonBorderEdge1.Name = "kryptonBorderEdge1"
        Me.kryptonBorderEdge1.Size = New System.Drawing.Size(318, 1)
        Me.kryptonBorderEdge1.Text = "kryptonBorderEdge1"
        '
        'kryptonCheckButton1
        '
        Me.kryptonCheckButton1.Dock = System.Windows.Forms.DockStyle.Bottom
        Me.kryptonCheckButton1.Location = New System.Drawing.Point(0, 185)
        Me.kryptonCheckButton1.Name = "kryptonCheckButton1"
        Me.kryptonCheckButton1.Size = New System.Drawing.Size(318, 24)
        Me.kryptonCheckButton1.StateCommon.Border.DrawBorders = Krypton.Toolkit.PaletteDrawBorders.None
        Me.kryptonCheckButton1.StateCommon.Content.Image.ImageH = Krypton.Toolkit.PaletteRelativeAlign.Near
        Me.kryptonCheckButton1.StateCommon.Content.Image.ImageV = Krypton.Toolkit.PaletteRelativeAlign.Center
        Me.kryptonCheckButton1.StateCommon.Content.LongText.TextH = Krypton.Toolkit.PaletteRelativeAlign.Far
        Me.kryptonCheckButton1.StateCommon.Content.LongText.TextV = Krypton.Toolkit.PaletteRelativeAlign.Center
        Me.kryptonCheckButton1.StateCommon.Content.ShortText.TextH = Krypton.Toolkit.PaletteRelativeAlign.Near
        Me.kryptonCheckButton1.StateCommon.Content.ShortText.TextV = Krypton.Toolkit.PaletteRelativeAlign.Center
        Me.kryptonCheckButton1.TabIndex = 5
        Me.kryptonCheckButton1.Values.DropDownArrowColor = System.Drawing.Color.Empty
        Me.kryptonCheckButton1.Values.Image = CType(resources.GetObject("kryptonCheckButton1.Values.Image"), System.Drawing.Image)
        Me.kryptonCheckButton1.Values.Text = "Notes"
        '
        'kryptonCheckSet
        '
        Me.kryptonCheckSet.CheckButtons.Add(Me.kryptonCheckButton1)
        Me.kryptonCheckSet.CheckButtons.Add(Me.kryptonCheckButton2)
        Me.kryptonCheckSet.CheckButtons.Add(Me.kryptonCheckButton3)
        Me.kryptonCheckSet.CheckButtons.Add(Me.kryptonCheckButton4)
        Me.kryptonCheckSet.CheckedButton = Me.kryptonCheckButton2
        '
        'kryptonManager
        '
        Me.kryptonManager.GlobalPaletteMode = Krypton.Toolkit.PaletteMode.Office2007Blue
        '
        'Form1
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8F, 16F)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(330, 276)
        Me.Controls.Add(Me.toolStripContainer1)
        Me.Controls.Add(Me.menuStrip)
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.MaximizeBox = False
        Me.MinimizeBox = False
        Me.MinimumSize = New System.Drawing.Size(257, 330)
        Me.Name = "Form1"
        Me.Text = "Child Control Stack"
        Me.toolStrip.ResumeLayout(False)
        Me.toolStrip.PerformLayout()
        Me.menuStrip.ResumeLayout(False)
        Me.menuStrip.PerformLayout()
        Me.toolStripContainer1.ContentPanel.ResumeLayout(False)
        Me.toolStripContainer1.TopToolStripPanel.ResumeLayout(False)
        Me.toolStripContainer1.TopToolStripPanel.PerformLayout()
        Me.toolStripContainer1.ResumeLayout(False)
        Me.toolStripContainer1.PerformLayout()
        CType(Me.kryptonPanelMain, System.ComponentModel.ISupportInitialize).EndInit()
        Me.kryptonPanelMain.ResumeLayout(False)
        CType(Me.kryptonGroupMain.Panel, System.ComponentModel.ISupportInitialize).EndInit()
        Me.kryptonGroupMain.Panel.ResumeLayout(False)
        Me.kryptonGroupMain.Panel.PerformLayout()
        CType(Me.kryptonGroupMain, System.ComponentModel.ISupportInitialize).EndInit()
        Me.kryptonGroupMain.ResumeLayout(False)
        CType(Me.kryptonCheckSet, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()
    End Sub

    Friend WithEvents toolStrip As System.Windows.Forms.ToolStrip
    Friend WithEvents toolSystem As System.Windows.Forms.ToolStripButton
    Friend WithEvents toolSparkle As System.Windows.Forms.ToolStripButton
    Friend WithEvents menuStrip As System.Windows.Forms.MenuStrip
    Friend WithEvents toolStripMenuItem1 As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents menuSystem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents menuSparkle As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents toolStripSeparator1 As System.Windows.Forms.ToolStripSeparator
    Friend WithEvents exitToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents toolStripContainer1 As System.Windows.Forms.ToolStripContainer
    Friend WithEvents kryptonPanelMain As Krypton.Toolkit.KryptonPanel
    Friend WithEvents kryptonGroupMain As Krypton.Toolkit.KryptonGroup
    Friend WithEvents kryptonBorderEdge4 As Krypton.Toolkit.KryptonBorderEdge
    Friend WithEvents kryptonCheckButton4 As Krypton.Toolkit.KryptonCheckButton
    Friend WithEvents kryptonBorderEdge3 As Krypton.Toolkit.KryptonBorderEdge
    Friend WithEvents kryptonCheckButton3 As Krypton.Toolkit.KryptonCheckButton
    Friend WithEvents kryptonBorderEdge2 As Krypton.Toolkit.KryptonBorderEdge
    Friend WithEvents kryptonCheckButton2 As Krypton.Toolkit.KryptonCheckButton
    Friend WithEvents kryptonBorderEdge1 As Krypton.Toolkit.KryptonBorderEdge
    Friend WithEvents kryptonCheckButton1 As Krypton.Toolkit.KryptonCheckButton
    Friend WithEvents kryptonCheckSet As Krypton.Toolkit.KryptonCheckSet
    Friend WithEvents kryptonBorderEdge5 As Krypton.Toolkit.KryptonBorderEdge
    Friend WithEvents kryptonHeader As Krypton.Toolkit.KryptonHeader
    Friend WithEvents kryptonManager As Krypton.Toolkit.KryptonManager
    Friend WithEvents textBoxFiller As Krypton.Toolkit.KryptonTextBox
    Friend WithEvents toolOffice2010 As System.Windows.Forms.ToolStripButton
    Friend WithEvents toolOffice2007 As System.Windows.Forms.ToolStripButton
    Friend WithEvents menuOffice2010 As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents menuOffice2007 As System.Windows.Forms.ToolStripMenuItem
End Class
