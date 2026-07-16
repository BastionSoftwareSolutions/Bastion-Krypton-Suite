' VB.NET twin of Source\Krypton Toolkit Examples\KryptonNumericUpDown Examples\Form1.Designer.cs (Bastion Phase 4c).
<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class Form1
    Inherits System.Windows.Forms.Form

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
        Me.groupBox4 = New System.Windows.Forms.GroupBox()
        Me.propertyGrid = New System.Windows.Forms.PropertyGrid()
        Me.buttonClose = New System.Windows.Forms.Button()
        Me.nud1 = New Krypton.Toolkit.KryptonNumericUpDown()
        Me.nud2 = New Krypton.Toolkit.KryptonNumericUpDown()
        Me.nud3 = New Krypton.Toolkit.KryptonNumericUpDown()
        Me.nud4 = New Krypton.Toolkit.KryptonNumericUpDown()
        Me.kryptonManager1 = New Krypton.Toolkit.KryptonManager(Me.components)
        Me.nud5 = New Krypton.Toolkit.KryptonNumericUpDown()
        Me.buttonSpecAny1 = New Krypton.Toolkit.ButtonSpecAny()
        Me.nud6 = New Krypton.Toolkit.KryptonNumericUpDown()
        Me.buttonSpecAny2 = New Krypton.Toolkit.ButtonSpecAny()
        Me.buttonSpecAny3 = New Krypton.Toolkit.ButtonSpecAny()
        Me.kryptonContextMenu1 = New Krypton.Toolkit.KryptonContextMenu()
        Me.kryptonContextMenuHeading1 = New Krypton.Toolkit.KryptonContextMenuHeading()
        Me.kryptonContextMenuItems1 = New Krypton.Toolkit.KryptonContextMenuItems()
        Me.kryptonContextMenuItem1 = New Krypton.Toolkit.KryptonContextMenuItem()
        Me.kryptonContextMenuItem2 = New Krypton.Toolkit.KryptonContextMenuItem()
        Me.kryptonContextMenuItem3 = New Krypton.Toolkit.KryptonContextMenuItem()
        Me.kryptonContextMenuSeparator1 = New Krypton.Toolkit.KryptonContextMenuSeparator()
        Me.kryptonContextMenuHeading2 = New Krypton.Toolkit.KryptonContextMenuHeading()
        Me.kryptonContextMenuItems2 = New Krypton.Toolkit.KryptonContextMenuItems()
        Me.kryptonContextMenuItem4 = New Krypton.Toolkit.KryptonContextMenuItem()
        Me.kryptonContextMenuItem5 = New Krypton.Toolkit.KryptonContextMenuItem()
        Me.groupBox1 = New System.Windows.Forms.GroupBox()
        Me.groupBox2 = New System.Windows.Forms.GroupBox()
        Me.nud7 = New Krypton.Toolkit.KryptonNumericUpDown()
        Me.nud12 = New Krypton.Toolkit.KryptonNumericUpDown()
        Me.buttonSpecAny4 = New Krypton.Toolkit.ButtonSpecAny()
        Me.buttonSpecAny5 = New Krypton.Toolkit.ButtonSpecAny()
        Me.nud8 = New Krypton.Toolkit.KryptonNumericUpDown()
        Me.nud11 = New Krypton.Toolkit.KryptonNumericUpDown()
        Me.buttonSpecAny6 = New Krypton.Toolkit.ButtonSpecAny()
        Me.nud9 = New Krypton.Toolkit.KryptonNumericUpDown()
        Me.nud10 = New Krypton.Toolkit.KryptonNumericUpDown()
        Me.groupBox3 = New System.Windows.Forms.GroupBox()
        Me.buttonSystem = New System.Windows.Forms.Button()
        Me.buttonOffice2007Blue = New System.Windows.Forms.Button()
        Me.buttonSparkleBlue = New System.Windows.Forms.Button()
        Me.buttonOffice2010Blue = New System.Windows.Forms.Button()
        Me.groupBox4.SuspendLayout()
        Me.groupBox1.SuspendLayout()
        Me.groupBox2.SuspendLayout()
        Me.groupBox3.SuspendLayout()
        Me.SuspendLayout()
        Me.groupBox4.Controls.Add(Me.propertyGrid)
        Me.groupBox4.Location = New System.Drawing.Point(303, 14)
        Me.groupBox4.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.groupBox4.Name = "groupBox4"
        Me.groupBox4.Padding = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.groupBox4.Size = New System.Drawing.Size(322, 426)
        Me.groupBox4.TabIndex = 3
        Me.groupBox4.TabStop = False
        Me.groupBox4.Text = "Properties for Selected KryptonNumericUpDown"
        Me.propertyGrid.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) Or System.Windows.Forms.AnchorStyles.Left) Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.propertyGrid.Location = New System.Drawing.Point(6, 22)
        Me.propertyGrid.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.propertyGrid.Name = "propertyGrid"
        Me.propertyGrid.Size = New System.Drawing.Size(310, 396)
        Me.propertyGrid.TabIndex = 0
        Me.propertyGrid.ToolbarVisible = False
        Me.buttonClose.DialogResult = System.Windows.Forms.DialogResult.Cancel
        Me.buttonClose.Location = New System.Drawing.Point(550, 448)
        Me.buttonClose.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.buttonClose.Name = "buttonClose"
        Me.buttonClose.Size = New System.Drawing.Size(75, 28)
        Me.buttonClose.TabIndex = 4
        Me.buttonClose.Text = "&Close"
        Me.buttonClose.UseVisualStyleBackColor = True
        Me.nud1.Increment = New Decimal(New Integer() { 1000, 0, 0, 0})
        Me.nud1.Location = New System.Drawing.Point(21, 31)
        Me.nud1.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.nud1.Maximum = New Decimal(New Integer() { 10000, 0, 0, 0})
        Me.nud1.Minimum = New Decimal(New Integer() { 0, 0, 0, 0})
        Me.nud1.Name = "nud1"
        Me.nud1.Size = New System.Drawing.Size(76, 33)
        Me.nud1.StateCommon.Content.Font = New System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.nud1.TabIndex = 0
        Me.nud1.ThousandsSeparator = True
        Me.nud1.Value = New Decimal(New Integer() { 2000, 0, 0, 0})
        Me.nud2.Increment = New Decimal(New Integer() { 1000, 0, 0, 0})
        Me.nud2.Location = New System.Drawing.Point(21, 69)
        Me.nud2.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.nud2.Maximum = New Decimal(New Integer() { 10000, 0, 0, 0})
        Me.nud2.Minimum = New Decimal(New Integer() { 0, 0, 0, 0})
        Me.nud2.MinimumSize = New System.Drawing.Size(0, 30)
        Me.nud2.Name = "nud2"
        Me.nud2.Size = New System.Drawing.Size(76, 30)
        Me.nud2.StateCommon.Content.TextH = Krypton.Toolkit.PaletteRelativeAlign.Center
        Me.nud2.TabIndex = 1
        Me.nud2.ThousandsSeparator = True
        Me.nud2.Value = New Decimal(New Integer() { 3000, 0, 0, 0})
        Me.nud3.Increment = New Decimal(New Integer() { 1000, 0, 0, 0})
        Me.nud3.Location = New System.Drawing.Point(21, 108)
        Me.nud3.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.nud3.Maximum = New Decimal(New Integer() { 10000, 0, 0, 0})
        Me.nud3.Minimum = New Decimal(New Integer() { 0, 0, 0, 0})
        Me.nud3.Name = "nud3"
        Me.nud3.Size = New System.Drawing.Size(76, 26)
        Me.nud3.StateCommon.Content.TextH = Krypton.Toolkit.PaletteRelativeAlign.Far
        Me.nud3.TabIndex = 2
        Me.nud3.ThousandsSeparator = True
        Me.nud3.Value = New Decimal(New Integer() { 4000, 0, 0, 0})
        Me.nud4.AllowDecimals = True
        Me.nud4.DecimalPlaces = 2
        Me.nud4.Increment = New Decimal(New Integer() { 5, 0, 0, 65536})
        Me.nud4.Location = New System.Drawing.Point(138, 31)
        Me.nud4.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.nud4.Maximum = New Decimal(New Integer() { 100, 0, 0, 0})
        Me.nud4.Minimum = New Decimal(New Integer() { 0, 0, 0, 0})
        Me.nud4.Name = "nud4"
        Me.nud4.Size = New System.Drawing.Size(76, 26)
        Me.nud4.TabIndex = 3
        Me.nud4.ThousandsSeparator = True
        Me.nud4.UpDownAlign = System.Windows.Forms.LeftRightAlignment.Left
        Me.nud4.Value = New Decimal(New Integer() { 3350, 0, 0, 131072})
        Me.kryptonManager1.GlobalPaletteMode = Krypton.Toolkit.PaletteMode.Office2007Blue
        Me.nud5.AllowDecimals = True
        Me.nud5.ButtonSpecs.Add(Me.buttonSpecAny1)
        Me.nud5.DecimalPlaces = 3
        Me.nud5.Increment = New Decimal(New Integer() { 5, 0, 0, 65536})
        Me.nud5.Location = New System.Drawing.Point(138, 69)
        Me.nud5.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.nud5.Maximum = New Decimal(New Integer() { 100, 0, 0, 0})
        Me.nud5.Minimum = New Decimal(New Integer() { 0, 0, 0, 0})
        Me.nud5.Name = "nud5"
        Me.nud5.Size = New System.Drawing.Size(102, 26)
        Me.nud5.StateCommon.Content.TextH = Krypton.Toolkit.PaletteRelativeAlign.Center
        Me.nud5.TabIndex = 4
        Me.nud5.ThousandsSeparator = True
        Me.nud5.ToolTipValues.EnableToolTips = True
        Me.nud5.TrailingZeroes = False
        Me.nud5.UpDownAlign = System.Windows.Forms.LeftRightAlignment.Left
        Me.nud5.Value = New Decimal(New Integer() { 3350, 0, 0, 131072})
        Me.buttonSpecAny1.Style = Krypton.Toolkit.PaletteButtonStyle.Standalone
        Me.buttonSpecAny1.Type = Krypton.Toolkit.PaletteButtonSpecStyle.Close
        Me.buttonSpecAny1.UniqueName = "65211BA9781346D365211BA9781346D3"
        Me.nud6.AllowDecimals = True
        Me.nud6.ButtonSpecs.Add(Me.buttonSpecAny2)
        Me.nud6.ButtonSpecs.Add(Me.buttonSpecAny3)
        Me.nud6.DecimalPlaces = 4
        Me.nud6.Increment = New Decimal(New Integer() { 5, 0, 0, 65536})
        Me.nud6.Location = New System.Drawing.Point(138, 108)
        Me.nud6.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.nud6.Maximum = New Decimal(New Integer() { 100, 0, 0, 0})
        Me.nud6.Minimum = New Decimal(New Integer() { 0, 0, 0, 0})
        Me.nud6.Name = "nud6"
        Me.nud6.Size = New System.Drawing.Size(127, 26)
        Me.nud6.StateCommon.Content.TextH = Krypton.Toolkit.PaletteRelativeAlign.Far
        Me.nud6.TabIndex = 5
        Me.nud6.ThousandsSeparator = True
        Me.nud6.UpDownAlign = System.Windows.Forms.LeftRightAlignment.Left
        Me.nud6.Value = New Decimal(New Integer() { 3350, 0, 0, 131072})
        Me.buttonSpecAny2.Style = Krypton.Toolkit.PaletteButtonStyle.Standalone
        Me.buttonSpecAny2.Type = Krypton.Toolkit.PaletteButtonSpecStyle.Close
        Me.buttonSpecAny2.UniqueName = "65211BA9781346D365211BA9781346D3"
        Me.buttonSpecAny3.KryptonContextMenu = Me.kryptonContextMenu1
        Me.buttonSpecAny3.Style = Krypton.Toolkit.PaletteButtonStyle.Standalone
        Me.buttonSpecAny3.Type = Krypton.Toolkit.PaletteButtonSpecStyle.DropDown
        Me.buttonSpecAny3.UniqueName = "55BDC4B174064C5F55BDC4B174064C5F"
        Me.kryptonContextMenu1.Items.AddRange(New Krypton.Toolkit.KryptonContextMenuItemBase() { Me.kryptonContextMenuHeading1, Me.kryptonContextMenuItems1, Me.kryptonContextMenuSeparator1, Me.kryptonContextMenuHeading2, Me.kryptonContextMenuItems2})
        Me.kryptonContextMenuHeading1.ExtraText = ""
        Me.kryptonContextMenuHeading1.Text = "Fixed Values"
        Me.kryptonContextMenuItems1.Items.AddRange(New Krypton.Toolkit.KryptonContextMenuItemBase() { Me.kryptonContextMenuItem1, Me.kryptonContextMenuItem2, Me.kryptonContextMenuItem3})
        Me.kryptonContextMenuItem1.Text = "10.0000"
        Me.kryptonContextMenuItem2.Text = "20.0000"
        Me.kryptonContextMenuItem3.Text = "40.0000"
        Me.kryptonContextMenuHeading2.ExtraText = ""
        Me.kryptonContextMenuHeading2.Text = "Limits"
        Me.kryptonContextMenuItems2.Items.AddRange(New Krypton.Toolkit.KryptonContextMenuItemBase() { Me.kryptonContextMenuItem4, Me.kryptonContextMenuItem5})
        Me.kryptonContextMenuItem4.Text = "Minimum"
        Me.kryptonContextMenuItem5.Text = "Maximum"
        Me.groupBox1.Controls.Add(Me.nud1)
        Me.groupBox1.Controls.Add(Me.nud6)
        Me.groupBox1.Controls.Add(Me.nud2)
        Me.groupBox1.Controls.Add(Me.nud5)
        Me.groupBox1.Controls.Add(Me.nud3)
        Me.groupBox1.Controls.Add(Me.nud4)
        Me.groupBox1.Location = New System.Drawing.Point(12, 14)
        Me.groupBox1.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.groupBox1.Name = "groupBox1"
        Me.groupBox1.Padding = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.groupBox1.Size = New System.Drawing.Size(285, 152)
        Me.groupBox1.TabIndex = 0
        Me.groupBox1.TabStop = False
        Me.groupBox1.Text = "Normal Style"
        Me.groupBox2.Controls.Add(Me.nud7)
        Me.groupBox2.Controls.Add(Me.nud12)
        Me.groupBox2.Controls.Add(Me.nud8)
        Me.groupBox2.Controls.Add(Me.nud11)
        Me.groupBox2.Controls.Add(Me.nud9)
        Me.groupBox2.Controls.Add(Me.nud10)
        Me.groupBox2.Location = New System.Drawing.Point(12, 174)
        Me.groupBox2.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.groupBox2.Name = "groupBox2"
        Me.groupBox2.Padding = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.groupBox2.Size = New System.Drawing.Size(285, 152)
        Me.groupBox2.TabIndex = 1
        Me.groupBox2.TabStop = False
        Me.groupBox2.Text = "Ribbon Style"
        Me.nud7.AlwaysActive = False
        Me.nud7.Increment = New Decimal(New Integer() { 1000, 0, 0, 0})
        Me.nud7.InputControlStyle = Krypton.Toolkit.InputControlStyle.Ribbon
        Me.nud7.Location = New System.Drawing.Point(21, 31)
        Me.nud7.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.nud7.Maximum = New Decimal(New Integer() { 10000, 0, 0, 0})
        Me.nud7.Minimum = New Decimal(New Integer() { 0, 0, 0, 0})
        Me.nud7.Name = "nud7"
        Me.nud7.Size = New System.Drawing.Size(76, 26)
        Me.nud7.TabIndex = 0
        Me.nud7.ThousandsSeparator = True
        Me.nud7.Value = New Decimal(New Integer() { 2000, 0, 0, 0})
        Me.nud12.AllowDecimals = True
        Me.nud12.AlwaysActive = False
        Me.nud12.ButtonSpecs.Add(Me.buttonSpecAny4)
        Me.nud12.ButtonSpecs.Add(Me.buttonSpecAny5)
        Me.nud12.DecimalPlaces = 4
        Me.nud12.Increment = New Decimal(New Integer() { 5, 0, 0, 65536})
        Me.nud12.InputControlStyle = Krypton.Toolkit.InputControlStyle.Ribbon
        Me.nud12.Location = New System.Drawing.Point(138, 108)
        Me.nud12.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.nud12.Maximum = New Decimal(New Integer() { 100, 0, 0, 0})
        Me.nud12.Minimum = New Decimal(New Integer() { 0, 0, 0, 0})
        Me.nud12.Name = "nud12"
        Me.nud12.Size = New System.Drawing.Size(127, 26)
        Me.nud12.StateCommon.Content.TextH = Krypton.Toolkit.PaletteRelativeAlign.Far
        Me.nud12.TabIndex = 5
        Me.nud12.ThousandsSeparator = True
        Me.nud12.UpDownAlign = System.Windows.Forms.LeftRightAlignment.Left
        Me.nud12.Value = New Decimal(New Integer() { 3350, 0, 0, 131072})
        Me.buttonSpecAny4.Style = Krypton.Toolkit.PaletteButtonStyle.Standalone
        Me.buttonSpecAny4.Type = Krypton.Toolkit.PaletteButtonSpecStyle.Close
        Me.buttonSpecAny4.UniqueName = "65211BA9781346D365211BA9781346D3"
        Me.buttonSpecAny5.KryptonContextMenu = Me.kryptonContextMenu1
        Me.buttonSpecAny5.Style = Krypton.Toolkit.PaletteButtonStyle.Standalone
        Me.buttonSpecAny5.Type = Krypton.Toolkit.PaletteButtonSpecStyle.DropDown
        Me.buttonSpecAny5.UniqueName = "55BDC4B174064C5F55BDC4B174064C5F"
        Me.nud8.AlwaysActive = False
        Me.nud8.Increment = New Decimal(New Integer() { 1000, 0, 0, 0})
        Me.nud8.InputControlStyle = Krypton.Toolkit.InputControlStyle.Ribbon
        Me.nud8.Location = New System.Drawing.Point(21, 69)
        Me.nud8.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.nud8.Maximum = New Decimal(New Integer() { 10000, 0, 0, 0})
        Me.nud8.Minimum = New Decimal(New Integer() { 0, 0, 0, 0})
        Me.nud8.Name = "nud8"
        Me.nud8.Size = New System.Drawing.Size(76, 26)
        Me.nud8.StateCommon.Content.TextH = Krypton.Toolkit.PaletteRelativeAlign.Center
        Me.nud8.TabIndex = 1
        Me.nud8.ThousandsSeparator = True
        Me.nud8.Value = New Decimal(New Integer() { 3000, 0, 0, 0})
        Me.nud11.AllowDecimals = True
        Me.nud11.AlwaysActive = False
        Me.nud11.ButtonSpecs.Add(Me.buttonSpecAny6)
        Me.nud11.DecimalPlaces = 3
        Me.nud11.Increment = New Decimal(New Integer() { 5, 0, 0, 65536})
        Me.nud11.InputControlStyle = Krypton.Toolkit.InputControlStyle.Ribbon
        Me.nud11.Location = New System.Drawing.Point(138, 69)
        Me.nud11.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.nud11.Maximum = New Decimal(New Integer() { 100, 0, 0, 0})
        Me.nud11.Minimum = New Decimal(New Integer() { 0, 0, 0, 0})
        Me.nud11.Name = "nud11"
        Me.nud11.Size = New System.Drawing.Size(102, 26)
        Me.nud11.StateCommon.Content.TextH = Krypton.Toolkit.PaletteRelativeAlign.Center
        Me.nud11.TabIndex = 4
        Me.nud11.ThousandsSeparator = True
        Me.nud11.UpDownAlign = System.Windows.Forms.LeftRightAlignment.Left
        Me.nud11.Value = New Decimal(New Integer() { 3350, 0, 0, 131072})
        Me.buttonSpecAny6.Style = Krypton.Toolkit.PaletteButtonStyle.Standalone
        Me.buttonSpecAny6.Type = Krypton.Toolkit.PaletteButtonSpecStyle.Close
        Me.buttonSpecAny6.UniqueName = "65211BA9781346D365211BA9781346D3"
        Me.nud9.AlwaysActive = False
        Me.nud9.Increment = New Decimal(New Integer() { 1000, 0, 0, 0})
        Me.nud9.InputControlStyle = Krypton.Toolkit.InputControlStyle.Ribbon
        Me.nud9.Location = New System.Drawing.Point(21, 108)
        Me.nud9.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.nud9.Maximum = New Decimal(New Integer() { 10000, 0, 0, 0})
        Me.nud9.Minimum = New Decimal(New Integer() { 0, 0, 0, 0})
        Me.nud9.Name = "nud9"
        Me.nud9.Size = New System.Drawing.Size(76, 26)
        Me.nud9.StateCommon.Content.TextH = Krypton.Toolkit.PaletteRelativeAlign.Far
        Me.nud9.TabIndex = 2
        Me.nud9.ThousandsSeparator = True
        Me.nud9.Value = New Decimal(New Integer() { 4000, 0, 0, 0})
        Me.nud10.AllowDecimals = True
        Me.nud10.AlwaysActive = False
        Me.nud10.DecimalPlaces = 2
        Me.nud10.Increment = New Decimal(New Integer() { 5, 0, 0, 65536})
        Me.nud10.InputControlStyle = Krypton.Toolkit.InputControlStyle.Ribbon
        Me.nud10.Location = New System.Drawing.Point(138, 31)
        Me.nud10.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.nud10.Maximum = New Decimal(New Integer() { 100, 0, 0, 0})
        Me.nud10.Minimum = New Decimal(New Integer() { 0, 0, 0, 0})
        Me.nud10.Name = "nud10"
        Me.nud10.Size = New System.Drawing.Size(76, 26)
        Me.nud10.TabIndex = 3
        Me.nud10.ThousandsSeparator = True
        Me.nud10.UpDownAlign = System.Windows.Forms.LeftRightAlignment.Left
        Me.nud10.Value = New Decimal(New Integer() { 3350, 0, 0, 131072})
        Me.groupBox3.Controls.Add(Me.buttonSystem)
        Me.groupBox3.Controls.Add(Me.buttonOffice2007Blue)
        Me.groupBox3.Controls.Add(Me.buttonSparkleBlue)
        Me.groupBox3.Controls.Add(Me.buttonOffice2010Blue)
        Me.groupBox3.Location = New System.Drawing.Point(12, 334)
        Me.groupBox3.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.groupBox3.Name = "groupBox3"
        Me.groupBox3.Padding = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.groupBox3.Size = New System.Drawing.Size(285, 106)
        Me.groupBox3.TabIndex = 2
        Me.groupBox3.TabStop = False
        Me.groupBox3.Text = "Palettes"
        Me.buttonSystem.Location = New System.Drawing.Point(149, 62)
        Me.buttonSystem.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.buttonSystem.Name = "buttonSystem"
        Me.buttonSystem.Size = New System.Drawing.Size(137, 29)
        Me.buttonSystem.TabIndex = 3
        Me.buttonSystem.Text = "System"
        Me.buttonSystem.UseVisualStyleBackColor = True
        Me.buttonOffice2007Blue.Location = New System.Drawing.Point(3, 62)
        Me.buttonOffice2007Blue.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.buttonOffice2007Blue.Name = "buttonOffice2007Blue"
        Me.buttonOffice2007Blue.Size = New System.Drawing.Size(137, 29)
        Me.buttonOffice2007Blue.TabIndex = 1
        Me.buttonOffice2007Blue.Text = "Office 2007 - Blue"
        Me.buttonOffice2007Blue.UseVisualStyleBackColor = True
        Me.buttonSparkleBlue.Location = New System.Drawing.Point(149, 29)
        Me.buttonSparkleBlue.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.buttonSparkleBlue.Name = "buttonSparkleBlue"
        Me.buttonSparkleBlue.Size = New System.Drawing.Size(137, 29)
        Me.buttonSparkleBlue.TabIndex = 2
        Me.buttonSparkleBlue.Text = "Sparkle - Blue"
        Me.buttonSparkleBlue.UseVisualStyleBackColor = True
        Me.buttonOffice2010Blue.Location = New System.Drawing.Point(3, 29)
        Me.buttonOffice2010Blue.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.buttonOffice2010Blue.Name = "buttonOffice2010Blue"
        Me.buttonOffice2010Blue.Size = New System.Drawing.Size(137, 29)
        Me.buttonOffice2010Blue.TabIndex = 0
        Me.buttonOffice2010Blue.Text = "Office 2010 - Blue"
        Me.buttonOffice2010Blue.UseVisualStyleBackColor = True
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8F, 20F)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(636, 489)
        Me.Controls.Add(Me.groupBox3)
        Me.Controls.Add(Me.groupBox2)
        Me.Controls.Add(Me.groupBox1)
        Me.Controls.Add(Me.buttonClose)
        Me.Controls.Add(Me.groupBox4)
        Me.Font = New System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.MaximizeBox = False
        Me.MinimizeBox = False
        Me.Name = "Form1"
        Me.Text = "KryptonNumericUpDown Examples"
        Me.groupBox4.ResumeLayout(False)
        Me.groupBox1.ResumeLayout(False)
        Me.groupBox2.ResumeLayout(False)
        Me.groupBox3.ResumeLayout(False)
        Me.ResumeLayout(False)
    End Sub

    Friend WithEvents groupBox4 As System.Windows.Forms.GroupBox
    Friend WithEvents propertyGrid As System.Windows.Forms.PropertyGrid
    Friend WithEvents buttonClose As System.Windows.Forms.Button
    Friend WithEvents nud1 As Krypton.Toolkit.KryptonNumericUpDown
    Friend WithEvents nud2 As Krypton.Toolkit.KryptonNumericUpDown
    Friend WithEvents nud3 As Krypton.Toolkit.KryptonNumericUpDown
    Friend WithEvents nud4 As Krypton.Toolkit.KryptonNumericUpDown
    Friend WithEvents kryptonManager1 As Krypton.Toolkit.KryptonManager
    Friend WithEvents nud5 As Krypton.Toolkit.KryptonNumericUpDown
    Friend WithEvents buttonSpecAny1 As Krypton.Toolkit.ButtonSpecAny
    Friend WithEvents nud6 As Krypton.Toolkit.KryptonNumericUpDown
    Friend WithEvents buttonSpecAny2 As Krypton.Toolkit.ButtonSpecAny
    Friend WithEvents buttonSpecAny3 As Krypton.Toolkit.ButtonSpecAny
    Friend WithEvents groupBox1 As System.Windows.Forms.GroupBox
    Friend WithEvents groupBox2 As System.Windows.Forms.GroupBox
    Friend WithEvents nud7 As Krypton.Toolkit.KryptonNumericUpDown
    Friend WithEvents nud12 As Krypton.Toolkit.KryptonNumericUpDown
    Friend WithEvents buttonSpecAny4 As Krypton.Toolkit.ButtonSpecAny
    Friend WithEvents buttonSpecAny5 As Krypton.Toolkit.ButtonSpecAny
    Friend WithEvents nud8 As Krypton.Toolkit.KryptonNumericUpDown
    Friend WithEvents nud11 As Krypton.Toolkit.KryptonNumericUpDown
    Friend WithEvents buttonSpecAny6 As Krypton.Toolkit.ButtonSpecAny
    Friend WithEvents nud9 As Krypton.Toolkit.KryptonNumericUpDown
    Friend WithEvents nud10 As Krypton.Toolkit.KryptonNumericUpDown
    Friend WithEvents groupBox3 As System.Windows.Forms.GroupBox
    Friend WithEvents buttonSystem As System.Windows.Forms.Button
    Friend WithEvents buttonOffice2007Blue As System.Windows.Forms.Button
    Friend WithEvents buttonSparkleBlue As System.Windows.Forms.Button
    Friend WithEvents buttonOffice2010Blue As System.Windows.Forms.Button
    Friend WithEvents kryptonContextMenu1 As Krypton.Toolkit.KryptonContextMenu
    Friend WithEvents kryptonContextMenuHeading1 As Krypton.Toolkit.KryptonContextMenuHeading
    Friend WithEvents kryptonContextMenuItems1 As Krypton.Toolkit.KryptonContextMenuItems
    Friend WithEvents kryptonContextMenuItem1 As Krypton.Toolkit.KryptonContextMenuItem
    Friend WithEvents kryptonContextMenuItem2 As Krypton.Toolkit.KryptonContextMenuItem
    Friend WithEvents kryptonContextMenuItem3 As Krypton.Toolkit.KryptonContextMenuItem
    Friend WithEvents kryptonContextMenuSeparator1 As Krypton.Toolkit.KryptonContextMenuSeparator
    Friend WithEvents kryptonContextMenuHeading2 As Krypton.Toolkit.KryptonContextMenuHeading
    Friend WithEvents kryptonContextMenuItems2 As Krypton.Toolkit.KryptonContextMenuItems
    Friend WithEvents kryptonContextMenuItem4 As Krypton.Toolkit.KryptonContextMenuItem
    Friend WithEvents kryptonContextMenuItem5 As Krypton.Toolkit.KryptonContextMenuItem
End Class
