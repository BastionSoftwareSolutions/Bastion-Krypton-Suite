' VB.NET twin of Source\Krypton Toolkit Examples\KryptonTreeView Examples\Form1.Designer.cs (Bastion Phase 4c).
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
        Me.buttonClose = New System.Windows.Forms.Button()
        Me.groupBox = New System.Windows.Forms.GroupBox()
        Me.propertyGrid = New System.Windows.Forms.PropertyGrid()
        Me.kryptonTreeView = New Krypton.Toolkit.KryptonTreeView()
        Me.imageList = New System.Windows.Forms.ImageList(Me.components)
        Me.kryptonContextMenu1 = New Krypton.Toolkit.KryptonContextMenu()
        Me.kryptonContextMenuHeading1 = New Krypton.Toolkit.KryptonContextMenuHeading()
        Me.kryptonContextMenuMonthCalendar1 = New Krypton.Toolkit.KryptonContextMenuMonthCalendar()
        Me.kryptonContextMenuItems1 = New Krypton.Toolkit.KryptonContextMenuItems()
        Me.kryptonContextMenuItem1 = New Krypton.Toolkit.KryptonContextMenuItem()
        Me.kryptonContextMenuItems2 = New Krypton.Toolkit.KryptonContextMenuItems()
        Me.kryptonContextMenuHeading2 = New Krypton.Toolkit.KryptonContextMenuHeading()
        Me.kryptonContextMenuCheckBox1 = New Krypton.Toolkit.KryptonContextMenuCheckBox()
        Me.kryptonContextMenuCheckButton1 = New Krypton.Toolkit.KryptonContextMenuCheckButton()
        Me.kryptonContextMenuRadioButton1 = New Krypton.Toolkit.KryptonContextMenuRadioButton()
        Me.kryptonContextMenuLinkLabel1 = New Krypton.Toolkit.KryptonContextMenuLinkLabel()
        Me.kryptonContextMenuColorColumns1 = New Krypton.Toolkit.KryptonContextMenuColorColumns()
        Me.kryptonContextMenuImageSelect1 = New Krypton.Toolkit.KryptonContextMenuImageSelect()
        Me.kryptonContextMenuSeparator1 = New Krypton.Toolkit.KryptonContextMenuSeparator()
        Me.contextMenuStrip1 = New System.Windows.Forms.ContextMenuStrip(Me.components)
        Me.toolStripMenuItem1 = New System.Windows.Forms.ToolStripMenuItem()
        Me.toolStripComboBoxA = New System.Windows.Forms.ToolStripComboBox()
        Me.toolStripSeparator1 = New System.Windows.Forms.ToolStripSeparator()
        Me.toolStripSeparator2 = New System.Windows.Forms.ToolStripSeparator()
        Me.groupBox1 = New System.Windows.Forms.GroupBox()
        Me.checkSystem = New Krypton.Toolkit.KryptonCheckButton()
        Me.checkSparkle = New Krypton.Toolkit.KryptonCheckButton()
        Me.check2010Blue = New Krypton.Toolkit.KryptonCheckButton()
        Me.check2007Blue = New Krypton.Toolkit.KryptonCheckButton()
        Me.buttonAppend = New Krypton.Toolkit.KryptonButton()
        Me.buttonInsert = New Krypton.Toolkit.KryptonButton()
        Me.buttonClear = New Krypton.Toolkit.KryptonButton()
        Me.buttonRemove = New Krypton.Toolkit.KryptonButton()
        Me.kryptonManager1 = New Krypton.Toolkit.KryptonManager(Me.components)
        Me.kryptonCheckSet = New Krypton.Toolkit.KryptonCheckSet(Me.components)
        Me.kryptonContextMenuItem2 = New Krypton.Toolkit.KryptonContextMenuItem()
        Me.btnToggleNodeCheckBox = New Krypton.Toolkit.KryptonButton()
        Me.groupBox.SuspendLayout()
        Me.contextMenuStrip1.SuspendLayout()
        Me.groupBox1.SuspendLayout()
        CType(Me.kryptonCheckSet, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        Me.buttonClose.DialogResult = System.Windows.Forms.DialogResult.Cancel
        Me.buttonClose.Location = New System.Drawing.Point(667, 631)
        Me.buttonClose.Margin = New System.Windows.Forms.Padding(4)
        Me.buttonClose.Name = "buttonClose"
        Me.buttonClose.Size = New System.Drawing.Size(100, 28)
        Me.buttonClose.TabIndex = 5
        Me.buttonClose.Text = "&Close"
        Me.buttonClose.UseVisualStyleBackColor = True
        Me.groupBox.Controls.Add(Me.propertyGrid)
        Me.groupBox.Location = New System.Drawing.Point(380, 15)
        Me.groupBox.Margin = New System.Windows.Forms.Padding(4)
        Me.groupBox.Name = "groupBox"
        Me.groupBox.Padding = New System.Windows.Forms.Padding(4)
        Me.groupBox.Size = New System.Drawing.Size(387, 609)
        Me.groupBox.TabIndex = 4
        Me.groupBox.TabStop = False
        Me.groupBox.Text = "Properties for Selected KryptonTreeView"
        Me.propertyGrid.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) Or System.Windows.Forms.AnchorStyles.Left) Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.propertyGrid.Location = New System.Drawing.Point(8, 23)
        Me.propertyGrid.Margin = New System.Windows.Forms.Padding(4)
        Me.propertyGrid.Name = "propertyGrid"
        Me.propertyGrid.SelectedObject = Me.kryptonTreeView
        Me.propertyGrid.Size = New System.Drawing.Size(371, 581)
        Me.propertyGrid.TabIndex = 0
        Me.propertyGrid.ToolbarVisible = False
        Me.kryptonTreeView.CheckBoxes = True
        Me.kryptonTreeView.HideSelection = False
        Me.kryptonTreeView.HotTracking = True
        Me.kryptonTreeView.ImageIndex = 3
        Me.kryptonTreeView.ImageList = Me.imageList
        Me.kryptonTreeView.KryptonContextMenu = Me.kryptonContextMenu1
        Me.kryptonTreeView.Location = New System.Drawing.Point(17, 38)
        Me.kryptonTreeView.Margin = New System.Windows.Forms.Padding(4)
        Me.kryptonTreeView.MultiSelect = True
        Me.kryptonTreeView.Name = "kryptonTreeView"
        Me.kryptonTreeView.SelectedImageIndex = 3
        Me.kryptonTreeView.Size = New System.Drawing.Size(340, 319)
        Me.kryptonTreeView.StateCheckedMultiSelect.Node.Back.Color1 = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(192, Byte), Integer), CType(CType(0, Byte), Integer))
        Me.kryptonTreeView.StateCommon.Node.Border.DrawBorders = CType((((Krypton.Toolkit.PaletteDrawBorders.Top Or Krypton.Toolkit.PaletteDrawBorders.Bottom) Or Krypton.Toolkit.PaletteDrawBorders.Left) Or Krypton.Toolkit.PaletteDrawBorders.Right), Krypton.Toolkit.PaletteDrawBorders)
        Me.kryptonTreeView.StateCommon.Node.Border.Rounding = -10F
        Me.kryptonTreeView.TabIndex = 6
        Me.imageList.ImageStream = CType(resources.GetObject("imageList.ImageStream"), System.Windows.Forms.ImageListStreamer)
        Me.imageList.TransparentColor = System.Drawing.Color.Transparent
        Me.imageList.Images.SetKeyName(0, "flag_bahamas.png")
        Me.imageList.Images.SetKeyName(1, "flag_china.png")
        Me.imageList.Images.SetKeyName(2, "flag_ecuador.png")
        Me.imageList.Images.SetKeyName(3, "flag_england.png")
        Me.imageList.Images.SetKeyName(4, "flag_france.png")
        Me.imageList.Images.SetKeyName(5, "flag_greece.png")
        Me.imageList.Images.SetKeyName(6, "flag_netherlands.png")
        Me.imageList.Images.SetKeyName(7, "flag_poland.png")
        Me.kryptonContextMenu1.Items.AddRange(New Krypton.Toolkit.KryptonContextMenuItemBase() { Me.kryptonContextMenuHeading1, Me.kryptonContextMenuMonthCalendar1, Me.kryptonContextMenuItems1, Me.kryptonContextMenuCheckBox1, Me.kryptonContextMenuCheckButton1, Me.kryptonContextMenuRadioButton1, Me.kryptonContextMenuLinkLabel1, Me.kryptonContextMenuColorColumns1, Me.kryptonContextMenuImageSelect1, Me.kryptonContextMenuSeparator1})
        Me.kryptonContextMenuHeading1.ExtraText = ""
        Me.kryptonContextMenuItems1.Items.AddRange(New Krypton.Toolkit.KryptonContextMenuItemBase() { Me.kryptonContextMenuItem1})
        Me.kryptonContextMenuItem1.Items.AddRange(New Krypton.Toolkit.KryptonContextMenuItemBase() { Me.kryptonContextMenuItems2, Me.kryptonContextMenuHeading2})
        Me.kryptonContextMenuItem1.Text = "Menu Item"
        Me.kryptonContextMenuHeading2.ExtraText = ""
        Me.kryptonContextMenuCheckBox1.ExtraText = "extra"
        Me.kryptonContextMenuCheckBox1.LabelStyle = Krypton.Toolkit.LabelStyle.NormalControl
        Me.kryptonContextMenuCheckButton1.ExtraText = "extra"
        Me.kryptonContextMenuCheckButton1.Text = "CheckButton"
        Me.kryptonContextMenuRadioButton1.ExtraText = "extra"
        Me.kryptonContextMenuRadioButton1.LabelStyle = Krypton.Toolkit.LabelStyle.NormalControl
        Me.kryptonContextMenuLinkLabel1.ExtraText = "extra"
        Me.kryptonContextMenuLinkLabel1.LabelStyle = Krypton.Toolkit.LabelStyle.NormalControl
        Me.kryptonContextMenuColorColumns1.SelectedColor = System.Drawing.Color.Empty
        Me.kryptonContextMenuImageSelect1.ImageIndexEnd = 0
        Me.kryptonContextMenuImageSelect1.ImageIndexStart = 5
        Me.kryptonContextMenuImageSelect1.ImageList = Me.imageList
        Me.contextMenuStrip1.Font = New System.Drawing.Font("Segoe UI", 9F)
        Me.contextMenuStrip1.ImageScalingSize = New System.Drawing.Size(20, 20)
        Me.contextMenuStrip1.Items.AddRange(New System.Windows.Forms.ToolStripItem() { Me.toolStripMenuItem1, Me.toolStripComboBoxA, Me.toolStripSeparator1, Me.toolStripSeparator2})
        Me.contextMenuStrip1.Name = "contextMenuStrip1"
        Me.contextMenuStrip1.Size = New System.Drawing.Size(212, 72)
        Me.toolStripMenuItem1.Name = "toolStripMenuItem1"
        Me.toolStripMenuItem1.Size = New System.Drawing.Size(211, 24)
        Me.toolStripMenuItem1.Text = "toolStripMenuItem1"
        Me.toolStripComboBoxA.Items.AddRange(New Object() { "rew"})
        Me.toolStripComboBoxA.Name = "toolStripComboBoxA"
        Me.toolStripComboBoxA.Size = New System.Drawing.Size(121, 28)
        Me.toolStripSeparator1.Name = "toolStripSeparator1"
        Me.toolStripSeparator1.Size = New System.Drawing.Size(208, 6)
        Me.toolStripSeparator2.Name = "toolStripSeparator2"
        Me.toolStripSeparator2.Size = New System.Drawing.Size(208, 6)
        Me.groupBox1.Controls.Add(Me.checkSystem)
        Me.groupBox1.Controls.Add(Me.checkSparkle)
        Me.groupBox1.Controls.Add(Me.check2010Blue)
        Me.groupBox1.Controls.Add(Me.check2007Blue)
        Me.groupBox1.Controls.Add(Me.buttonAppend)
        Me.groupBox1.Controls.Add(Me.buttonInsert)
        Me.groupBox1.Controls.Add(Me.buttonClear)
        Me.groupBox1.Controls.Add(Me.buttonRemove)
        Me.groupBox1.Location = New System.Drawing.Point(17, 417)
        Me.groupBox1.Margin = New System.Windows.Forms.Padding(4)
        Me.groupBox1.Name = "groupBox1"
        Me.groupBox1.Padding = New System.Windows.Forms.Padding(4)
        Me.groupBox1.Size = New System.Drawing.Size(340, 207)
        Me.groupBox1.TabIndex = 7
        Me.groupBox1.TabStop = False
        Me.groupBox1.Text = "Actions"
        Me.checkSystem.AutoSize = True
        Me.checkSystem.Location = New System.Drawing.Point(167, 155)
        Me.checkSystem.Margin = New System.Windows.Forms.Padding(4)
        Me.checkSystem.Name = "checkSystem"
        Me.checkSystem.Size = New System.Drawing.Size(151, 34)
        Me.checkSystem.TabIndex = 7
        Me.checkSystem.Values.Text = "System"
        Me.checkSparkle.AutoSize = True
        Me.checkSparkle.Location = New System.Drawing.Point(167, 114)
        Me.checkSparkle.Margin = New System.Windows.Forms.Padding(4)
        Me.checkSparkle.Name = "checkSparkle"
        Me.checkSparkle.Size = New System.Drawing.Size(151, 34)
        Me.checkSparkle.TabIndex = 6
        Me.checkSparkle.Values.Text = "Sparkle - Blue"
        Me.check2010Blue.AutoSize = True
        Me.check2010Blue.Checked = True
        Me.check2010Blue.Location = New System.Drawing.Point(167, 38)
        Me.check2010Blue.Margin = New System.Windows.Forms.Padding(4)
        Me.check2010Blue.Name = "check2010Blue"
        Me.check2010Blue.Size = New System.Drawing.Size(177, 34)
        Me.check2010Blue.TabIndex = 5
        Me.check2010Blue.Values.Text = "Office 2010 - Blue"
        Me.check2007Blue.AutoSize = True
        Me.check2007Blue.Location = New System.Drawing.Point(167, 76)
        Me.check2007Blue.Margin = New System.Windows.Forms.Padding(4)
        Me.check2007Blue.Name = "check2007Blue"
        Me.check2007Blue.Size = New System.Drawing.Size(177, 34)
        Me.check2007Blue.TabIndex = 4
        Me.check2007Blue.Values.Text = "Office 2007 - Blue"
        Me.buttonAppend.AutoSize = True
        Me.buttonAppend.Location = New System.Drawing.Point(25, 37)
        Me.buttonAppend.Margin = New System.Windows.Forms.Padding(4)
        Me.buttonAppend.Name = "buttonAppend"
        Me.buttonAppend.Size = New System.Drawing.Size(120, 34)
        Me.buttonAppend.TabIndex = 0
        Me.buttonAppend.Values.Text = "Append"
        Me.buttonInsert.AutoSize = True
        Me.buttonInsert.Location = New System.Drawing.Point(25, 76)
        Me.buttonInsert.Margin = New System.Windows.Forms.Padding(4)
        Me.buttonInsert.Name = "buttonInsert"
        Me.buttonInsert.Size = New System.Drawing.Size(120, 34)
        Me.buttonInsert.TabIndex = 1
        Me.buttonInsert.Values.Text = "Insert"
        Me.buttonClear.AutoSize = True
        Me.buttonClear.Location = New System.Drawing.Point(25, 155)
        Me.buttonClear.Margin = New System.Windows.Forms.Padding(4)
        Me.buttonClear.Name = "buttonClear"
        Me.buttonClear.Size = New System.Drawing.Size(120, 34)
        Me.buttonClear.TabIndex = 3
        Me.buttonClear.Values.Text = "Clear"
        Me.buttonRemove.AutoSize = True
        Me.buttonRemove.Location = New System.Drawing.Point(25, 116)
        Me.buttonRemove.Margin = New System.Windows.Forms.Padding(4)
        Me.buttonRemove.Name = "buttonRemove"
        Me.buttonRemove.Size = New System.Drawing.Size(120, 34)
        Me.buttonRemove.TabIndex = 2
        Me.buttonRemove.Values.Text = "Remove"
        Me.kryptonManager1.GlobalPaletteMode = Krypton.Toolkit.PaletteMode.Office2010Blue
        Me.kryptonCheckSet.CheckButtons.Add(Me.checkSystem)
        Me.kryptonCheckSet.CheckButtons.Add(Me.checkSparkle)
        Me.kryptonCheckSet.CheckButtons.Add(Me.check2010Blue)
        Me.kryptonCheckSet.CheckButtons.Add(Me.check2007Blue)
        Me.kryptonCheckSet.CheckedButton = Me.check2010Blue
        Me.kryptonContextMenuItem2.Text = "Menu Item"
        Me.btnToggleNodeCheckBox.AutoSize = True
        Me.btnToggleNodeCheckBox.Location = New System.Drawing.Point(17, 379)
        Me.btnToggleNodeCheckBox.Margin = New System.Windows.Forms.Padding(4)
        Me.btnToggleNodeCheckBox.Name = "btnToggleNodeCheckBox"
        Me.btnToggleNodeCheckBox.Size = New System.Drawing.Size(184, 31)
        Me.btnToggleNodeCheckBox.TabIndex = 8
        Me.btnToggleNodeCheckBox.Values.Text = "Toggle Node CheckBox"
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8F, 16F)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(792, 682)
        Me.Controls.Add(Me.btnToggleNodeCheckBox)
        Me.Controls.Add(Me.groupBox1)
        Me.Controls.Add(Me.kryptonTreeView)
        Me.Controls.Add(Me.buttonClose)
        Me.Controls.Add(Me.groupBox)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.Margin = New System.Windows.Forms.Padding(4)
        Me.MaximizeBox = False
        Me.MinimizeBox = False
        Me.Name = "Form1"
        Me.Text = "KryptonTreeView Examples"
        Me.groupBox.ResumeLayout(False)
        Me.contextMenuStrip1.ResumeLayout(False)
        Me.groupBox1.ResumeLayout(False)
        Me.groupBox1.PerformLayout()
        CType(Me.kryptonCheckSet, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()
    End Sub

    Friend WithEvents buttonClose As System.Windows.Forms.Button
    Friend WithEvents groupBox As System.Windows.Forms.GroupBox
    Friend WithEvents propertyGrid As System.Windows.Forms.PropertyGrid
    Friend WithEvents kryptonTreeView As Krypton.Toolkit.KryptonTreeView
    Friend WithEvents groupBox1 As System.Windows.Forms.GroupBox
    Friend WithEvents checkSystem As Krypton.Toolkit.KryptonCheckButton
    Friend WithEvents checkSparkle As Krypton.Toolkit.KryptonCheckButton
    Friend WithEvents check2010Blue As Krypton.Toolkit.KryptonCheckButton
    Friend WithEvents check2007Blue As Krypton.Toolkit.KryptonCheckButton
    Friend WithEvents buttonAppend As Krypton.Toolkit.KryptonButton
    Friend WithEvents buttonInsert As Krypton.Toolkit.KryptonButton
    Friend WithEvents buttonClear As Krypton.Toolkit.KryptonButton
    Friend WithEvents buttonRemove As Krypton.Toolkit.KryptonButton
    Friend WithEvents kryptonManager1 As Krypton.Toolkit.KryptonManager
    Friend WithEvents kryptonCheckSet As Krypton.Toolkit.KryptonCheckSet
    Friend WithEvents imageList As System.Windows.Forms.ImageList
    Friend WithEvents kryptonContextMenu1 As Krypton.Toolkit.KryptonContextMenu
    Friend WithEvents kryptonContextMenuHeading1 As Krypton.Toolkit.KryptonContextMenuHeading
    Friend WithEvents kryptonContextMenuItems1 As Krypton.Toolkit.KryptonContextMenuItems
    Friend WithEvents kryptonContextMenuItem1 As Krypton.Toolkit.KryptonContextMenuItem
    Friend WithEvents kryptonContextMenuCheckBox1 As Krypton.Toolkit.KryptonContextMenuCheckBox
    Friend WithEvents kryptonContextMenuCheckButton1 As Krypton.Toolkit.KryptonContextMenuCheckButton
    Friend WithEvents kryptonContextMenuRadioButton1 As Krypton.Toolkit.KryptonContextMenuRadioButton
    Friend WithEvents kryptonContextMenuLinkLabel1 As Krypton.Toolkit.KryptonContextMenuLinkLabel
    Friend WithEvents kryptonContextMenuColorColumns1 As Krypton.Toolkit.KryptonContextMenuColorColumns
    Friend WithEvents kryptonContextMenuImageSelect1 As Krypton.Toolkit.KryptonContextMenuImageSelect
    Friend WithEvents contextMenuStrip1 As System.Windows.Forms.ContextMenuStrip
    Friend WithEvents toolStripMenuItem1 As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents toolStripComboBoxA As System.Windows.Forms.ToolStripComboBox
    Friend WithEvents toolStripSeparator1 As System.Windows.Forms.ToolStripSeparator
    Friend WithEvents toolStripSeparator2 As System.Windows.Forms.ToolStripSeparator
    Friend WithEvents kryptonContextMenuSeparator1 As Krypton.Toolkit.KryptonContextMenuSeparator
    Friend WithEvents kryptonContextMenuItems2 As Krypton.Toolkit.KryptonContextMenuItems
    Friend WithEvents kryptonContextMenuHeading2 As Krypton.Toolkit.KryptonContextMenuHeading
    Friend WithEvents kryptonContextMenuItem2 As Krypton.Toolkit.KryptonContextMenuItem
    Friend WithEvents kryptonContextMenuMonthCalendar1 As Krypton.Toolkit.KryptonContextMenuMonthCalendar
    Friend WithEvents btnToggleNodeCheckBox As Krypton.Toolkit.KryptonButton
End Class
