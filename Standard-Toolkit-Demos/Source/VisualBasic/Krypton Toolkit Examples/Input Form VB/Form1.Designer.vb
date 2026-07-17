' VB.NET twin of Source\Krypton Toolkit Examples\Input Form\Form1.Designer.cs (Bastion Phase 4c).
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
        Me.menuStrip1 = New System.Windows.Forms.MenuStrip()
        Me.fileToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.office2010MenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.office2007MenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.sparkleMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.systemMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.toolStripMenuItem1 = New System.Windows.Forms.ToolStripSeparator()
        Me.exitToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.toolStrip1 = New System.Windows.Forms.ToolStrip()
        Me.toolStripOffice2010 = New System.Windows.Forms.ToolStripButton()
        Me.toolStripOffice2007 = New System.Windows.Forms.ToolStripButton()
        Me.toolStripSparkle = New System.Windows.Forms.ToolStripButton()
        Me.toolStripSystem = New System.Windows.Forms.ToolStripButton()
        Me.toolStripContainer1 = New System.Windows.Forms.ToolStripContainer()
        Me.kryptonPanel1 = New Krypton.Toolkit.KryptonPanel()
        Me.tableLayoutPanel1 = New System.Windows.Forms.TableLayoutPanel()
        Me.labelName = New Krypton.Toolkit.KryptonLabel()
        Me.labelAddress = New Krypton.Toolkit.KryptonLabel()
        Me.labelTelephone = New Krypton.Toolkit.KryptonLabel()
        Me.labelStatus = New Krypton.Toolkit.KryptonLabel()
        Me.labelAge = New Krypton.Toolkit.KryptonLabel()
        Me.labelDOB = New Krypton.Toolkit.KryptonLabel()
        Me.labelGender = New Krypton.Toolkit.KryptonLabel()
        Me.labelEmployed = New Krypton.Toolkit.KryptonLabel()
        Me.textBoxName = New Krypton.Toolkit.KryptonTextBox()
        Me.richTextBoxAddress = New Krypton.Toolkit.KryptonRichTextBox()
        Me.maskedTextBoxTelephone = New Krypton.Toolkit.KryptonMaskedTextBox()
        Me.clearTelephone = New Krypton.Toolkit.ButtonSpecAny()
        Me.comboStatus = New Krypton.Toolkit.KryptonComboBox()
        Me.numericAge = New Krypton.Toolkit.KryptonNumericUpDown()
        Me.dtpDOB = New Krypton.Toolkit.KryptonDateTimePicker()
        Me.flowLayoutPanel2 = New System.Windows.Forms.FlowLayoutPanel()
        Me.radioButtonMale = New Krypton.Toolkit.KryptonRadioButton()
        Me.radioButtonFemale = New Krypton.Toolkit.KryptonRadioButton()
        Me.checkBoxEmployed = New Krypton.Toolkit.KryptonCheckBox()
        Me.flowLayoutPanel1 = New System.Windows.Forms.FlowLayoutPanel()
        Me.buttonOK = New Krypton.Toolkit.KryptonButton()
        Me.buttonCancel = New Krypton.Toolkit.KryptonButton()
        Me.kryptonManager1 = New Krypton.Toolkit.KryptonManager(Me.components)
        Me.menuStrip1.SuspendLayout()
        Me.toolStrip1.SuspendLayout()
        Me.toolStripContainer1.ContentPanel.SuspendLayout()
        Me.toolStripContainer1.TopToolStripPanel.SuspendLayout()
        Me.toolStripContainer1.SuspendLayout()
        CType(Me.kryptonPanel1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.kryptonPanel1.SuspendLayout()
        Me.tableLayoutPanel1.SuspendLayout()
        CType(Me.comboStatus, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.flowLayoutPanel2.SuspendLayout()
        Me.flowLayoutPanel1.SuspendLayout()
        Me.SuspendLayout()
        '
        'menuStrip1
        '
        Me.menuStrip1.Font = New System.Drawing.Font("Segoe UI", 9F)
        Me.menuStrip1.ImageScalingSize = New System.Drawing.Size(20, 20)
        Me.menuStrip1.Items.AddRange(New System.Windows.Forms.ToolStripItem() { Me.fileToolStripMenuItem})
        Me.menuStrip1.Location = New System.Drawing.Point(0, 0)
        Me.menuStrip1.Name = "menuStrip1"
        Me.menuStrip1.Size = New System.Drawing.Size(414, 30)
        Me.menuStrip1.TabIndex = 0
        Me.menuStrip1.Text = "menuStrip1"
        '
        'fileToolStripMenuItem
        '
        Me.fileToolStripMenuItem.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() { Me.office2010MenuItem, Me.office2007MenuItem, Me.sparkleMenuItem, Me.systemMenuItem, Me.toolStripMenuItem1, Me.exitToolStripMenuItem})
        Me.fileToolStripMenuItem.Name = "fileToolStripMenuItem"
        Me.fileToolStripMenuItem.Size = New System.Drawing.Size(46, 24)
        Me.fileToolStripMenuItem.Text = "&File"
        '
        'office2010MenuItem
        '
        Me.office2010MenuItem.Checked = True
        Me.office2010MenuItem.CheckOnClick = True
        Me.office2010MenuItem.CheckState = System.Windows.Forms.CheckState.Checked
        Me.office2010MenuItem.Name = "office2010MenuItem"
        Me.office2010MenuItem.Size = New System.Drawing.Size(211, 26)
        Me.office2010MenuItem.Text = "Office 2010 - Blue"
        '
        'office2007MenuItem
        '
        Me.office2007MenuItem.CheckOnClick = True
        Me.office2007MenuItem.Name = "office2007MenuItem"
        Me.office2007MenuItem.Size = New System.Drawing.Size(211, 26)
        Me.office2007MenuItem.Text = "Office 2007 - Blue"
        '
        'sparkleMenuItem
        '
        Me.sparkleMenuItem.Name = "sparkleMenuItem"
        Me.sparkleMenuItem.Size = New System.Drawing.Size(211, 26)
        Me.sparkleMenuItem.Text = "Sparkle - Blue"
        '
        'systemMenuItem
        '
        Me.systemMenuItem.CheckOnClick = True
        Me.systemMenuItem.Name = "systemMenuItem"
        Me.systemMenuItem.Size = New System.Drawing.Size(211, 26)
        Me.systemMenuItem.Text = "System"
        '
        'toolStripMenuItem1
        '
        Me.toolStripMenuItem1.Name = "toolStripMenuItem1"
        Me.toolStripMenuItem1.Size = New System.Drawing.Size(208, 6)
        '
        'exitToolStripMenuItem
        '
        Me.exitToolStripMenuItem.Name = "exitToolStripMenuItem"
        Me.exitToolStripMenuItem.Size = New System.Drawing.Size(211, 26)
        Me.exitToolStripMenuItem.Text = "E&xit"
        '
        'toolStrip1
        '
        Me.toolStrip1.Dock = System.Windows.Forms.DockStyle.None
        Me.toolStrip1.Font = New System.Drawing.Font("Segoe UI", 9F)
        Me.toolStrip1.ImageScalingSize = New System.Drawing.Size(20, 20)
        Me.toolStrip1.Items.AddRange(New System.Windows.Forms.ToolStripItem() { Me.toolStripOffice2010, Me.toolStripOffice2007, Me.toolStripSparkle, Me.toolStripSystem})
        Me.toolStrip1.Location = New System.Drawing.Point(4, 0)
        Me.toolStrip1.Name = "toolStrip1"
        Me.toolStrip1.Size = New System.Drawing.Size(225, 27)
        Me.toolStrip1.TabIndex = 1
        Me.toolStrip1.Text = "toolStrip1"
        '
        'toolStripOffice2010
        '
        Me.toolStripOffice2010.Checked = True
        Me.toolStripOffice2010.CheckOnClick = True
        Me.toolStripOffice2010.CheckState = System.Windows.Forms.CheckState.Checked
        Me.toolStripOffice2010.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Text
        Me.toolStripOffice2010.Image = CType(resources.GetObject("toolStripOffice2010.Image"), System.Drawing.Image)
        Me.toolStripOffice2010.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.toolStripOffice2010.Name = "toolStripOffice2010"
        Me.toolStripOffice2010.Size = New System.Drawing.Size(45, 24)
        Me.toolStripOffice2010.Text = "2010"
        '
        'toolStripOffice2007
        '
        Me.toolStripOffice2007.CheckOnClick = True
        Me.toolStripOffice2007.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Text
        Me.toolStripOffice2007.Image = CType(resources.GetObject("toolStripOffice2007.Image"), System.Drawing.Image)
        Me.toolStripOffice2007.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.toolStripOffice2007.Name = "toolStripOffice2007"
        Me.toolStripOffice2007.Size = New System.Drawing.Size(45, 24)
        Me.toolStripOffice2007.Text = "2007"
        '
        'toolStripSparkle
        '
        Me.toolStripSparkle.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Text
        Me.toolStripSparkle.Image = CType(resources.GetObject("toolStripSparkle.Image"), System.Drawing.Image)
        Me.toolStripSparkle.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.toolStripSparkle.Name = "toolStripSparkle"
        Me.toolStripSparkle.Size = New System.Drawing.Size(62, 24)
        Me.toolStripSparkle.Text = "Sparkle"
        '
        'toolStripSystem
        '
        Me.toolStripSystem.CheckOnClick = True
        Me.toolStripSystem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Text
        Me.toolStripSystem.Image = CType(resources.GetObject("toolStripSystem.Image"), System.Drawing.Image)
        Me.toolStripSystem.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.toolStripSystem.Name = "toolStripSystem"
        Me.toolStripSystem.Size = New System.Drawing.Size(60, 24)
        Me.toolStripSystem.Text = "System"
        '
        'toolStripContainer1
        '
        '
        'toolStripContainer1.ContentPanel
        '
        Me.toolStripContainer1.ContentPanel.Controls.Add(Me.kryptonPanel1)
        Me.toolStripContainer1.ContentPanel.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.toolStripContainer1.ContentPanel.Size = New System.Drawing.Size(414, 442)
        Me.toolStripContainer1.Dock = System.Windows.Forms.DockStyle.Fill
        Me.toolStripContainer1.Location = New System.Drawing.Point(0, 30)
        Me.toolStripContainer1.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.toolStripContainer1.Name = "toolStripContainer1"
        Me.toolStripContainer1.Size = New System.Drawing.Size(414, 469)
        Me.toolStripContainer1.TabIndex = 2
        Me.toolStripContainer1.Text = "toolStripContainer1"
        '
        'toolStripContainer1.TopToolStripPanel
        '
        Me.toolStripContainer1.TopToolStripPanel.Controls.Add(Me.toolStrip1)
        '
        'kryptonPanel1
        '
        Me.kryptonPanel1.Controls.Add(Me.tableLayoutPanel1)
        Me.kryptonPanel1.Dock = System.Windows.Forms.DockStyle.Fill
        Me.kryptonPanel1.Location = New System.Drawing.Point(0, 0)
        Me.kryptonPanel1.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.kryptonPanel1.Name = "kryptonPanel1"
        Me.kryptonPanel1.Padding = New System.Windows.Forms.Padding(13, 17, 13, 12)
        Me.kryptonPanel1.Size = New System.Drawing.Size(414, 442)
        Me.kryptonPanel1.TabIndex = 0
        '
        'tableLayoutPanel1
        '
        Me.tableLayoutPanel1.BackColor = System.Drawing.Color.Transparent
        Me.tableLayoutPanel1.ColumnCount = 2
        Me.tableLayoutPanel1.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle())
        Me.tableLayoutPanel1.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle())
        Me.tableLayoutPanel1.Controls.Add(Me.labelName, 0, 0)
        Me.tableLayoutPanel1.Controls.Add(Me.labelAddress, 0, 1)
        Me.tableLayoutPanel1.Controls.Add(Me.labelTelephone, 0, 2)
        Me.tableLayoutPanel1.Controls.Add(Me.labelStatus, 0, 3)
        Me.tableLayoutPanel1.Controls.Add(Me.labelAge, 0, 4)
        Me.tableLayoutPanel1.Controls.Add(Me.labelDOB, 0, 5)
        Me.tableLayoutPanel1.Controls.Add(Me.labelGender, 0, 6)
        Me.tableLayoutPanel1.Controls.Add(Me.labelEmployed, 0, 7)
        Me.tableLayoutPanel1.Controls.Add(Me.textBoxName, 1, 0)
        Me.tableLayoutPanel1.Controls.Add(Me.richTextBoxAddress, 1, 1)
        Me.tableLayoutPanel1.Controls.Add(Me.maskedTextBoxTelephone, 1, 2)
        Me.tableLayoutPanel1.Controls.Add(Me.comboStatus, 1, 3)
        Me.tableLayoutPanel1.Controls.Add(Me.numericAge, 1, 4)
        Me.tableLayoutPanel1.Controls.Add(Me.dtpDOB, 1, 5)
        Me.tableLayoutPanel1.Controls.Add(Me.flowLayoutPanel2, 1, 6)
        Me.tableLayoutPanel1.Controls.Add(Me.checkBoxEmployed, 1, 7)
        Me.tableLayoutPanel1.Controls.Add(Me.flowLayoutPanel1, 1, 8)
        Me.tableLayoutPanel1.Dock = System.Windows.Forms.DockStyle.Fill
        Me.tableLayoutPanel1.Location = New System.Drawing.Point(13, 17)
        Me.tableLayoutPanel1.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.tableLayoutPanel1.Name = "tableLayoutPanel1"
        Me.tableLayoutPanel1.RowCount = 9
        Me.tableLayoutPanel1.RowStyles.Add(New System.Windows.Forms.RowStyle())
        Me.tableLayoutPanel1.RowStyles.Add(New System.Windows.Forms.RowStyle())
        Me.tableLayoutPanel1.RowStyles.Add(New System.Windows.Forms.RowStyle())
        Me.tableLayoutPanel1.RowStyles.Add(New System.Windows.Forms.RowStyle())
        Me.tableLayoutPanel1.RowStyles.Add(New System.Windows.Forms.RowStyle())
        Me.tableLayoutPanel1.RowStyles.Add(New System.Windows.Forms.RowStyle())
        Me.tableLayoutPanel1.RowStyles.Add(New System.Windows.Forms.RowStyle())
        Me.tableLayoutPanel1.RowStyles.Add(New System.Windows.Forms.RowStyle())
        Me.tableLayoutPanel1.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 25F))
        Me.tableLayoutPanel1.Size = New System.Drawing.Size(388, 413)
        Me.tableLayoutPanel1.TabIndex = 0
        '
        'labelName
        '
        Me.labelName.Dock = System.Windows.Forms.DockStyle.Fill
        Me.labelName.Location = New System.Drawing.Point(4, 4)
        Me.labelName.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.labelName.Name = "labelName"
        Me.labelName.Size = New System.Drawing.Size(83, 27)
        Me.labelName.StateCommon.ShortText.TextH = Krypton.Toolkit.PaletteRelativeAlign.Far
        Me.labelName.TabIndex = 4
        Me.labelName.Values.Text = "Name"
        '
        'labelAddress
        '
        Me.labelAddress.Dock = System.Windows.Forms.DockStyle.Fill
        Me.labelAddress.Location = New System.Drawing.Point(4, 39)
        Me.labelAddress.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.labelAddress.Name = "labelAddress"
        Me.labelAddress.Size = New System.Drawing.Size(83, 118)
        Me.labelAddress.StateCommon.ShortText.TextH = Krypton.Toolkit.PaletteRelativeAlign.Far
        Me.labelAddress.StateCommon.ShortText.TextV = Krypton.Toolkit.PaletteRelativeAlign.Near
        Me.labelAddress.TabIndex = 5
        Me.labelAddress.Values.Text = "Address"
        '
        'labelTelephone
        '
        Me.labelTelephone.Location = New System.Drawing.Point(4, 165)
        Me.labelTelephone.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.labelTelephone.Name = "labelTelephone"
        Me.labelTelephone.Size = New System.Drawing.Size(83, 24)
        Me.labelTelephone.StateCommon.ShortText.TextH = Krypton.Toolkit.PaletteRelativeAlign.Far
        Me.labelTelephone.TabIndex = 6
        Me.labelTelephone.Values.Text = "Telephone"
        '
        'labelStatus
        '
        Me.labelStatus.Dock = System.Windows.Forms.DockStyle.Fill
        Me.labelStatus.Location = New System.Drawing.Point(4, 200)
        Me.labelStatus.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.labelStatus.Name = "labelStatus"
        Me.labelStatus.Size = New System.Drawing.Size(83, 26)
        Me.labelStatus.StateCommon.ShortText.TextH = Krypton.Toolkit.PaletteRelativeAlign.Far
        Me.labelStatus.TabIndex = 7
        Me.labelStatus.Values.Text = "Status"
        '
        'labelAge
        '
        Me.labelAge.Dock = System.Windows.Forms.DockStyle.Fill
        Me.labelAge.Location = New System.Drawing.Point(4, 234)
        Me.labelAge.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.labelAge.Name = "labelAge"
        Me.labelAge.Size = New System.Drawing.Size(83, 26)
        Me.labelAge.StateCommon.ShortText.TextH = Krypton.Toolkit.PaletteRelativeAlign.Far
        Me.labelAge.TabIndex = 13
        Me.labelAge.Values.Text = "Age"
        '
        'labelDOB
        '
        Me.labelDOB.Dock = System.Windows.Forms.DockStyle.Fill
        Me.labelDOB.Location = New System.Drawing.Point(4, 268)
        Me.labelDOB.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.labelDOB.Name = "labelDOB"
        Me.labelDOB.Size = New System.Drawing.Size(83, 25)
        Me.labelDOB.StateCommon.ShortText.TextH = Krypton.Toolkit.PaletteRelativeAlign.Far
        Me.labelDOB.TabIndex = 15
        Me.labelDOB.Values.Text = "D.O.B"
        '
        'labelGender
        '
        Me.labelGender.Dock = System.Windows.Forms.DockStyle.Fill
        Me.labelGender.Location = New System.Drawing.Point(4, 301)
        Me.labelGender.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.labelGender.Name = "labelGender"
        Me.labelGender.Size = New System.Drawing.Size(83, 24)
        Me.labelGender.StateCommon.ShortText.TextH = Krypton.Toolkit.PaletteRelativeAlign.Far
        Me.labelGender.TabIndex = 8
        Me.labelGender.Values.Text = "Gender"
        '
        'labelEmployed
        '
        Me.labelEmployed.Dock = System.Windows.Forms.DockStyle.Fill
        Me.labelEmployed.Location = New System.Drawing.Point(4, 333)
        Me.labelEmployed.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.labelEmployed.Name = "labelEmployed"
        Me.labelEmployed.Size = New System.Drawing.Size(83, 24)
        Me.labelEmployed.StateCommon.ShortText.TextH = Krypton.Toolkit.PaletteRelativeAlign.Far
        Me.labelEmployed.TabIndex = 9
        Me.labelEmployed.Values.Text = "Employed"
        '
        'textBoxName
        '
        Me.textBoxName.AlwaysActive = False
        Me.textBoxName.InputControlStyle = Krypton.Toolkit.InputControlStyle.Ribbon
        Me.textBoxName.Location = New System.Drawing.Point(95, 4)
        Me.textBoxName.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.textBoxName.Name = "textBoxName"
        Me.textBoxName.Size = New System.Drawing.Size(252, 27)
        Me.textBoxName.TabIndex = 0
        '
        'richTextBoxAddress
        '
        Me.richTextBoxAddress.AlwaysActive = False
        Me.richTextBoxAddress.InputControlStyle = Krypton.Toolkit.InputControlStyle.Ribbon
        Me.richTextBoxAddress.Location = New System.Drawing.Point(95, 39)
        Me.richTextBoxAddress.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.richTextBoxAddress.Name = "richTextBoxAddress"
        Me.richTextBoxAddress.Size = New System.Drawing.Size(252, 118)
        Me.richTextBoxAddress.TabIndex = 1
        Me.richTextBoxAddress.Text = ""
        '
        'maskedTextBoxTelephone
        '
        Me.maskedTextBoxTelephone.AlwaysActive = False
        Me.maskedTextBoxTelephone.ButtonSpecs.Add(Me.clearTelephone)
        Me.maskedTextBoxTelephone.InputControlStyle = Krypton.Toolkit.InputControlStyle.Ribbon
        Me.maskedTextBoxTelephone.Location = New System.Drawing.Point(95, 165)
        Me.maskedTextBoxTelephone.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.maskedTextBoxTelephone.Mask = "(000) 000-000"
        Me.maskedTextBoxTelephone.Name = "maskedTextBoxTelephone"
        Me.maskedTextBoxTelephone.PromptChar = "?"c
        Me.maskedTextBoxTelephone.Size = New System.Drawing.Size(173, 27)
        Me.maskedTextBoxTelephone.TabIndex = 2
        Me.maskedTextBoxTelephone.Text = "(   )    -"
        '
        'clearTelephone
        '
        Me.clearTelephone.Style = Krypton.Toolkit.PaletteButtonStyle.Standalone
        Me.clearTelephone.Type = Krypton.Toolkit.PaletteButtonSpecStyle.Close
        Me.clearTelephone.UniqueName = "C1E393B3D313481AC1E393B3D313481A"
        '
        'comboStatus
        '
        Me.comboStatus.AlwaysActive = False
        Me.comboStatus.DropDownWidth = 130
        Me.comboStatus.InputControlStyle = Krypton.Toolkit.InputControlStyle.Ribbon
        Me.comboStatus.IntegralHeight = False
        Me.comboStatus.Items.AddRange(New Object() { "Single", "Married", "Divorced", "Separated"})
        Me.comboStatus.Location = New System.Drawing.Point(95, 200)
        Me.comboStatus.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.comboStatus.Name = "comboStatus"
        Me.comboStatus.Size = New System.Drawing.Size(173, 26)
        Me.comboStatus.TabIndex = 3
        '
        'numericAge
        '
        Me.numericAge.AlwaysActive = False
        Me.numericAge.Increment = New decimal(New Integer() { 1, 0, 0, 0})
        Me.numericAge.InputControlStyle = Krypton.Toolkit.InputControlStyle.Ribbon
        Me.numericAge.Location = New System.Drawing.Point(95, 234)
        Me.numericAge.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.numericAge.Maximum = New decimal(New Integer() { 120, 0, 0, 0})
        Me.numericAge.Minimum = New decimal(New Integer() { 1, 0, 0, 0})
        Me.numericAge.Name = "numericAge"
        Me.numericAge.Size = New System.Drawing.Size(81, 26)
        Me.numericAge.TabIndex = 4
        Me.numericAge.Value = New decimal(New Integer() { 21, 0, 0, 0})
        '
        'dtpDOB
        '
        Me.dtpDOB.AlwaysActive = False
        Me.dtpDOB.CalendarTodayDate = New System.DateTime(2009, 8, 23, 0, 0, 0, 0)
        Me.dtpDOB.InputControlStyle = Krypton.Toolkit.InputControlStyle.Ribbon
        Me.dtpDOB.Location = New System.Drawing.Point(95, 268)
        Me.dtpDOB.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.dtpDOB.Name = "dtpDOB"
        Me.dtpDOB.Size = New System.Drawing.Size(248, 25)
        Me.dtpDOB.TabIndex = 5
        '
        'flowLayoutPanel2
        '
        Me.flowLayoutPanel2.AutoSize = True
        Me.flowLayoutPanel2.Controls.Add(Me.radioButtonMale)
        Me.flowLayoutPanel2.Controls.Add(Me.radioButtonFemale)
        Me.flowLayoutPanel2.Location = New System.Drawing.Point(91, 297)
        Me.flowLayoutPanel2.Margin = New System.Windows.Forms.Padding(0)
        Me.flowLayoutPanel2.Name = "flowLayoutPanel2"
        Me.flowLayoutPanel2.Size = New System.Drawing.Size(145, 32)
        Me.flowLayoutPanel2.TabIndex = 5
        '
        'radioButtonMale
        '
        Me.radioButtonMale.Location = New System.Drawing.Point(4, 4)
        Me.radioButtonMale.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.radioButtonMale.Name = "radioButtonMale"
        Me.radioButtonMale.Size = New System.Drawing.Size(57, 24)
        Me.radioButtonMale.TabIndex = 0
        Me.radioButtonMale.Values.Text = "Male"
        '
        'radioButtonFemale
        '
        Me.radioButtonFemale.Location = New System.Drawing.Point(69, 4)
        Me.radioButtonFemale.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.radioButtonFemale.Name = "radioButtonFemale"
        Me.radioButtonFemale.Size = New System.Drawing.Size(72, 24)
        Me.radioButtonFemale.TabIndex = 1
        Me.radioButtonFemale.Values.Text = "Female"
        '
        'checkBoxEmployed
        '
        Me.checkBoxEmployed.Location = New System.Drawing.Point(95, 333)
        Me.checkBoxEmployed.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.checkBoxEmployed.Name = "checkBoxEmployed"
        Me.checkBoxEmployed.Size = New System.Drawing.Size(92, 24)
        Me.checkBoxEmployed.TabIndex = 6
        Me.checkBoxEmployed.Values.Text = "Employed"
        '
        'flowLayoutPanel1
        '
        Me.flowLayoutPanel1.AutoSize = True
        Me.flowLayoutPanel1.Controls.Add(Me.buttonOK)
        Me.flowLayoutPanel1.Controls.Add(Me.buttonCancel)
        Me.flowLayoutPanel1.Location = New System.Drawing.Point(91, 361)
        Me.flowLayoutPanel1.Margin = New System.Windows.Forms.Padding(0)
        Me.flowLayoutPanel1.Name = "flowLayoutPanel1"
        Me.flowLayoutPanel1.Padding = New System.Windows.Forms.Padding(0, 8, 0, 0)
        Me.flowLayoutPanel1.Size = New System.Drawing.Size(256, 47)
        Me.flowLayoutPanel1.TabIndex = 7
        '
        'buttonOK
        '
        Me.buttonOK.DialogResult = System.Windows.Forms.DialogResult.OK
        Me.buttonOK.Location = New System.Drawing.Point(4, 12)
        Me.buttonOK.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.buttonOK.Name = "buttonOK"
        Me.buttonOK.Size = New System.Drawing.Size(120, 31)
        Me.buttonOK.TabIndex = 0
        Me.buttonOK.Values.DropDownArrowColor = System.Drawing.Color.Empty
        Me.buttonOK.Values.Text = "OK"
        '
        'buttonCancel
        '
        Me.buttonCancel.DialogResult = System.Windows.Forms.DialogResult.Cancel
        Me.buttonCancel.Location = New System.Drawing.Point(132, 12)
        Me.buttonCancel.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.buttonCancel.Name = "buttonCancel"
        Me.buttonCancel.Size = New System.Drawing.Size(120, 31)
        Me.buttonCancel.TabIndex = 1
        Me.buttonCancel.Values.DropDownArrowColor = System.Drawing.Color.Empty
        Me.buttonCancel.Values.Text = "Cancel"
        '
        'kryptonManager1
        '
        Me.kryptonManager1.GlobalPaletteMode = Krypton.Toolkit.PaletteMode.Office2010Blue
        '
        'Form1
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8F, 16F)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(414, 499)
        Me.Controls.Add(Me.toolStripContainer1)
        Me.Controls.Add(Me.menuStrip1)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.MainMenuStrip = Me.menuStrip1
        Me.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.MaximizeBox = False
        Me.MaximumSize = New System.Drawing.Size(430, 553)
        Me.MinimizeBox = False
        Me.MinimumSize = New System.Drawing.Size(430, 553)
        Me.Name = "Form1"
        Me.Text = "Input Form"
        Me.menuStrip1.ResumeLayout(False)
        Me.menuStrip1.PerformLayout()
        Me.toolStrip1.ResumeLayout(False)
        Me.toolStrip1.PerformLayout()
        Me.toolStripContainer1.ContentPanel.ResumeLayout(False)
        Me.toolStripContainer1.TopToolStripPanel.ResumeLayout(False)
        Me.toolStripContainer1.TopToolStripPanel.PerformLayout()
        Me.toolStripContainer1.ResumeLayout(False)
        Me.toolStripContainer1.PerformLayout()
        CType(Me.kryptonPanel1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.kryptonPanel1.ResumeLayout(False)
        Me.tableLayoutPanel1.ResumeLayout(False)
        Me.tableLayoutPanel1.PerformLayout()
        CType(Me.comboStatus, System.ComponentModel.ISupportInitialize).EndInit()
        Me.flowLayoutPanel2.ResumeLayout(False)
        Me.flowLayoutPanel2.PerformLayout()
        Me.flowLayoutPanel1.ResumeLayout(False)
        Me.ResumeLayout(False)
        Me.PerformLayout()
    End Sub

    Friend WithEvents menuStrip1 As System.Windows.Forms.MenuStrip
    Friend WithEvents fileToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents exitToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents toolStrip1 As System.Windows.Forms.ToolStrip
    Friend WithEvents toolStripContainer1 As System.Windows.Forms.ToolStripContainer
    Friend WithEvents kryptonPanel1 As Krypton.Toolkit.KryptonPanel
    Friend WithEvents toolStripOffice2010 As System.Windows.Forms.ToolStripButton
    Friend WithEvents toolStripOffice2007 As System.Windows.Forms.ToolStripButton
    Friend WithEvents toolStripSystem As System.Windows.Forms.ToolStripButton
    Friend WithEvents kryptonManager1 As Krypton.Toolkit.KryptonManager
    Friend WithEvents office2010MenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents office2007MenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents systemMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents toolStripMenuItem1 As System.Windows.Forms.ToolStripSeparator
    Friend WithEvents tableLayoutPanel1 As System.Windows.Forms.TableLayoutPanel
    Friend WithEvents labelName As Krypton.Toolkit.KryptonLabel
    Friend WithEvents labelAddress As Krypton.Toolkit.KryptonLabel
    Friend WithEvents textBoxName As Krypton.Toolkit.KryptonTextBox
    Friend WithEvents maskedTextBoxTelephone As Krypton.Toolkit.KryptonMaskedTextBox
    Friend WithEvents labelTelephone As Krypton.Toolkit.KryptonLabel
    Friend WithEvents comboStatus As Krypton.Toolkit.KryptonComboBox
    Friend WithEvents labelStatus As Krypton.Toolkit.KryptonLabel
    Friend WithEvents flowLayoutPanel1 As System.Windows.Forms.FlowLayoutPanel
    Friend WithEvents buttonOK As Krypton.Toolkit.KryptonButton
    Friend WithEvents buttonCancel As Krypton.Toolkit.KryptonButton
    Friend WithEvents labelEmployed As Krypton.Toolkit.KryptonLabel
    Friend WithEvents checkBoxEmployed As Krypton.Toolkit.KryptonCheckBox
    Friend WithEvents flowLayoutPanel2 As System.Windows.Forms.FlowLayoutPanel
    Friend WithEvents radioButtonMale As Krypton.Toolkit.KryptonRadioButton
    Friend WithEvents radioButtonFemale As Krypton.Toolkit.KryptonRadioButton
    Friend WithEvents labelGender As Krypton.Toolkit.KryptonLabel
    Friend WithEvents richTextBoxAddress As Krypton.Toolkit.KryptonRichTextBox
    Friend WithEvents clearTelephone As Krypton.Toolkit.ButtonSpecAny
    Friend WithEvents sparkleMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents toolStripSparkle As System.Windows.Forms.ToolStripButton
    Friend WithEvents labelAge As Krypton.Toolkit.KryptonLabel
    Friend WithEvents numericAge As Krypton.Toolkit.KryptonNumericUpDown
    Friend WithEvents dtpDOB As Krypton.Toolkit.KryptonDateTimePicker
    Friend WithEvents labelDOB As Krypton.Toolkit.KryptonLabel
End Class
