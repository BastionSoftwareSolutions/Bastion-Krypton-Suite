' VB.NET twin of Source\Krypton Toolkit Examples\KryptonDropButton Examples\Form1.Designer.cs (Bastion Phase 4c).

<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class Form1
    Inherits System.Windows.Forms.Form

    ''' <summary>
    '''  Required designer variable.
    ''' </summary>
    Private components As System.ComponentModel.IContainer

    ''' <summary>
    '''  Clean up any resources being used.
    ''' </summary>
    ''' <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
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

#Region "Windows Form Designer generated code"

    ''' <summary>
    '''  Required method for Designer support - do not modify
    '''  the contents of this method with the code editor.
    ''' </summary>
    <System.Diagnostics.DebuggerStepThrough()>
    Private Sub InitializeComponent()

        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(Form1))
        Me.buttonClose = New System.Windows.Forms.Button()
        Me.groupProperties = New System.Windows.Forms.GroupBox()
        Me.propertyGrid = New System.Windows.Forms.PropertyGrid()
        Me.groupSplitter = New System.Windows.Forms.GroupBox()
        Me.kryptonDropButton2 = New Krypton.Toolkit.KryptonDropButton()
        Me.kcmDropDown = New Krypton.Toolkit.KryptonContextMenu()
        Me.kryptonContextMenuHeading1 = New Krypton.Toolkit.KryptonContextMenuHeading()
        Me.kryptonContextMenuItems1 = New Krypton.Toolkit.KryptonContextMenuItems()
        Me.kryptonContextMenuItem1 = New Krypton.Toolkit.KryptonContextMenuItem()
        Me.kryptonContextMenuItem2 = New Krypton.Toolkit.KryptonContextMenuItem()
        Me.kryptonContextMenuItem3 = New Krypton.Toolkit.KryptonContextMenuItem()
        Me.splitterArrowLeft = New Krypton.Toolkit.KryptonDropButton()
        Me.splitterArrowRight = New Krypton.Toolkit.KryptonDropButton()
        Me.splitterArrowUp = New Krypton.Toolkit.KryptonDropButton()
        Me.splitterArrowDown = New Krypton.Toolkit.KryptonDropButton()
        Me.splitterPosBottom = New Krypton.Toolkit.KryptonDropButton()
        Me.splitterPosTop = New Krypton.Toolkit.KryptonDropButton()
        Me.splitterPosLeft = New Krypton.Toolkit.KryptonDropButton()
        Me.splitterPosRight = New Krypton.Toolkit.KryptonDropButton()
        Me.groupDropDown = New System.Windows.Forms.GroupBox()
        Me.dropArrowLeft = New Krypton.Toolkit.KryptonDropButton()
        Me.dropArrowRight = New Krypton.Toolkit.KryptonDropButton()
        Me.dropArrowUp = New Krypton.Toolkit.KryptonDropButton()
        Me.dropArrowDown = New Krypton.Toolkit.KryptonDropButton()
        Me.dropPosBottom = New Krypton.Toolkit.KryptonDropButton()
        Me.dropPosTop = New Krypton.Toolkit.KryptonDropButton()
        Me.dropPosLeft = New Krypton.Toolkit.KryptonDropButton()
        Me.dropPosRight = New Krypton.Toolkit.KryptonDropButton()
        Me.groupCustom = New System.Windows.Forms.GroupBox()
        Me.kryptonDropButton3 = New Krypton.Toolkit.KryptonDropButton()
        Me.kcmCustom = New Krypton.Toolkit.KryptonContextMenu()
        Me.kryptonContextMenuHeading5 = New Krypton.Toolkit.KryptonContextMenuHeading()
        Me.kryptonContextMenuItems5 = New Krypton.Toolkit.KryptonContextMenuItems()
        Me.kryptonContextMenuItem13 = New Krypton.Toolkit.KryptonContextMenuItem()
        Me.kryptonContextMenuItem14 = New Krypton.Toolkit.KryptonContextMenuItem()
        Me.kryptonContextMenuItem15 = New Krypton.Toolkit.KryptonContextMenuItem()
        Me.kryptonDropButton1 = New Krypton.Toolkit.KryptonDropButton()
        Me.dropCustom = New Krypton.Toolkit.KryptonDropButton()
        Me.splitterCustom = New Krypton.Toolkit.KryptonDropButton()
        Me.groupProperties.SuspendLayout()
        Me.groupSplitter.SuspendLayout()
        Me.groupDropDown.SuspendLayout()
        Me.groupCustom.SuspendLayout()
        Me.SuspendLayout()
        '
        ' buttonClose
        '
        Me.buttonClose.DialogResult = System.Windows.Forms.DialogResult.Cancel
        Me.buttonClose.Location = New System.Drawing.Point(553, 526)
        Me.buttonClose.Name = "buttonClose"
        Me.buttonClose.Size = New System.Drawing.Size(75, 23)
        Me.buttonClose.TabIndex = 4
        Me.buttonClose.Text = "&Close"
        Me.buttonClose.UseVisualStyleBackColor = True
        '
        ' groupProperties
        '
        Me.groupProperties.Controls.Add(Me.propertyGrid)
        Me.groupProperties.Location = New System.Drawing.Point(306, 12)
        Me.groupProperties.Name = "groupProperties"
        Me.groupProperties.Size = New System.Drawing.Size(322, 508)
        Me.groupProperties.TabIndex = 3
        Me.groupProperties.TabStop = False
        Me.groupProperties.Text = "Properties for Selected KryptonDropButton"
        '
        ' propertyGrid
        '
        Me.propertyGrid.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) Or System.Windows.Forms.AnchorStyles.Left) Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.propertyGrid.Location = New System.Drawing.Point(6, 19)
        Me.propertyGrid.Name = "propertyGrid"
        Me.propertyGrid.Size = New System.Drawing.Size(310, 483)
        Me.propertyGrid.TabIndex = 0
        Me.propertyGrid.ToolbarVisible = False
        '
        ' groupSplitter
        '
        Me.groupSplitter.Controls.Add(Me.kryptonDropButton2)
        Me.groupSplitter.Controls.Add(Me.splitterArrowLeft)
        Me.groupSplitter.Controls.Add(Me.splitterArrowRight)
        Me.groupSplitter.Controls.Add(Me.splitterArrowUp)
        Me.groupSplitter.Controls.Add(Me.splitterArrowDown)
        Me.groupSplitter.Controls.Add(Me.splitterPosBottom)
        Me.groupSplitter.Controls.Add(Me.splitterPosTop)
        Me.groupSplitter.Controls.Add(Me.splitterPosLeft)
        Me.groupSplitter.Controls.Add(Me.splitterPosRight)
        Me.groupSplitter.Location = New System.Drawing.Point(12, 12)
        Me.groupSplitter.Name = "groupSplitter"
        Me.groupSplitter.Size = New System.Drawing.Size(288, 191)
        Me.groupSplitter.TabIndex = 0
        Me.groupSplitter.TabStop = False
        Me.groupSplitter.Text = "Splitter"
        '
        ' kryptonDropButton2
        '
        Me.kryptonDropButton2.DropDownOrientation = Krypton.Toolkit.VisualOrientation.Right
        Me.kryptonDropButton2.Enabled = False
        Me.kryptonDropButton2.KryptonContextMenu = Me.kcmDropDown
        Me.kryptonDropButton2.Location = New System.Drawing.Point(151, 154)
        Me.kryptonDropButton2.Name = "kryptonDropButton2"
        Me.kryptonDropButton2.PaletteMode = Krypton.Toolkit.PaletteMode.Office2010Blue
        Me.kryptonDropButton2.Size = New System.Drawing.Size(137, 31)
        Me.kryptonDropButton2.StateCommon.Content.Image.ImageH = Krypton.Toolkit.PaletteRelativeAlign.Near
        Me.kryptonDropButton2.StateCommon.Content.ShortText.TextH = Krypton.Toolkit.PaletteRelativeAlign.Near
        Me.kryptonDropButton2.TabIndex = 8
        Me.kryptonDropButton2.Values.DropDownArrowColor = System.Drawing.Color.Empty
        Me.kryptonDropButton2.Values.Image = CType(resources.GetObject("kryptonDropButton2.Values.Image"), System.Drawing.Image)
        Me.kryptonDropButton2.Values.Text = "Arrow Right"
        '
        ' kcmDropDown
        '
        Me.kcmDropDown.Items.AddRange(New Krypton.Toolkit.KryptonContextMenuItemBase() { Me.kryptonContextMenuHeading1, Me.kryptonContextMenuItems1})
        Me.kcmDropDown.PaletteMode = Krypton.Toolkit.PaletteMode.Office2007Blue
        '
        ' kryptonContextMenuHeading1
        '
        Me.kryptonContextMenuHeading1.ExtraText = ""
        Me.kryptonContextMenuHeading1.Text = ""
        '
        ' kryptonContextMenuItems1
        '
        Me.kryptonContextMenuItems1.Items.AddRange(New Krypton.Toolkit.KryptonContextMenuItemBase() { Me.kryptonContextMenuItem1, Me.kryptonContextMenuItem2, Me.kryptonContextMenuItem3})
        '
        ' kryptonContextMenuItem1
        '
        Me.kryptonContextMenuItem1.Text = "Menu Item 1"
        '
        ' kryptonContextMenuItem2
        '
        Me.kryptonContextMenuItem2.Checked = True
        Me.kryptonContextMenuItem2.CheckState = System.Windows.Forms.CheckState.Indeterminate
        Me.kryptonContextMenuItem2.Text = "Menu Item 2"
        '
        ' kryptonContextMenuItem3
        '
        Me.kryptonContextMenuItem3.Checked = True
        Me.kryptonContextMenuItem3.CheckState = System.Windows.Forms.CheckState.Checked
        Me.kryptonContextMenuItem3.Text = "Menu Item 3"
        '
        ' splitterArrowLeft
        '
        Me.splitterArrowLeft.DropDownOrientation = Krypton.Toolkit.VisualOrientation.Left
        Me.splitterArrowLeft.KryptonContextMenu = Me.kcmDropDown
        Me.splitterArrowLeft.Location = New System.Drawing.Point(151, 92)
        Me.splitterArrowLeft.Name = "splitterArrowLeft"
        Me.splitterArrowLeft.PaletteMode = Krypton.Toolkit.PaletteMode.Office2010Blue
        Me.splitterArrowLeft.Size = New System.Drawing.Size(137, 31)
        Me.splitterArrowLeft.StateCommon.Content.Image.ImageH = Krypton.Toolkit.PaletteRelativeAlign.Near
        Me.splitterArrowLeft.StateCommon.Content.ShortText.TextH = Krypton.Toolkit.PaletteRelativeAlign.Near
        Me.splitterArrowLeft.TabIndex = 6
        Me.splitterArrowLeft.Values.DropDownArrowColor = System.Drawing.Color.Empty
        Me.splitterArrowLeft.Values.Image = CType(resources.GetObject("splitterArrowLeft.Values.Image"), System.Drawing.Image)
        Me.splitterArrowLeft.Values.Text = "Arrow Left"
        '
        ' splitterArrowRight
        '
        Me.splitterArrowRight.DropDownOrientation = Krypton.Toolkit.VisualOrientation.Right
        Me.splitterArrowRight.KryptonContextMenu = Me.kcmDropDown
        Me.splitterArrowRight.Location = New System.Drawing.Point(151, 30)
        Me.splitterArrowRight.Name = "splitterArrowRight"
        Me.splitterArrowRight.PaletteMode = Krypton.Toolkit.PaletteMode.Office2010Blue
        Me.splitterArrowRight.Size = New System.Drawing.Size(137, 31)
        Me.splitterArrowRight.StateCommon.Content.Image.ImageH = Krypton.Toolkit.PaletteRelativeAlign.Near
        Me.splitterArrowRight.StateCommon.Content.ShortText.TextH = Krypton.Toolkit.PaletteRelativeAlign.Near
        Me.splitterArrowRight.TabIndex = 4
        Me.splitterArrowRight.Values.DropDownArrowColor = System.Drawing.Color.Empty
        Me.splitterArrowRight.Values.Image = CType(resources.GetObject("splitterArrowRight.Values.Image"), System.Drawing.Image)
        Me.splitterArrowRight.Values.Text = "Arrow Right"
        '
        ' splitterArrowUp
        '
        Me.splitterArrowUp.DropDownOrientation = Krypton.Toolkit.VisualOrientation.Top
        Me.splitterArrowUp.KryptonContextMenu = Me.kcmDropDown
        Me.splitterArrowUp.Location = New System.Drawing.Point(151, 123)
        Me.splitterArrowUp.Name = "splitterArrowUp"
        Me.splitterArrowUp.PaletteMode = Krypton.Toolkit.PaletteMode.Office2010Blue
        Me.splitterArrowUp.Size = New System.Drawing.Size(137, 31)
        Me.splitterArrowUp.StateCommon.Content.Image.ImageH = Krypton.Toolkit.PaletteRelativeAlign.Near
        Me.splitterArrowUp.StateCommon.Content.ShortText.TextH = Krypton.Toolkit.PaletteRelativeAlign.Near
        Me.splitterArrowUp.TabIndex = 7
        Me.splitterArrowUp.Values.DropDownArrowColor = System.Drawing.Color.Empty
        Me.splitterArrowUp.Values.Image = CType(resources.GetObject("splitterArrowUp.Values.Image"), System.Drawing.Image)
        Me.splitterArrowUp.Values.Text = "Arrow Up"
        '
        ' splitterArrowDown
        '
        Me.splitterArrowDown.KryptonContextMenu = Me.kcmDropDown
        Me.splitterArrowDown.Location = New System.Drawing.Point(151, 61)
        Me.splitterArrowDown.Name = "splitterArrowDown"
        Me.splitterArrowDown.PaletteMode = Krypton.Toolkit.PaletteMode.Office2010Blue
        Me.splitterArrowDown.Size = New System.Drawing.Size(137, 31)
        Me.splitterArrowDown.StateCommon.Content.Image.ImageH = Krypton.Toolkit.PaletteRelativeAlign.Near
        Me.splitterArrowDown.StateCommon.Content.ShortText.TextH = Krypton.Toolkit.PaletteRelativeAlign.Near
        Me.splitterArrowDown.TabIndex = 5
        Me.splitterArrowDown.Values.DropDownArrowColor = System.Drawing.Color.Empty
        Me.splitterArrowDown.Values.Image = CType(resources.GetObject("splitterArrowDown.Values.Image"), System.Drawing.Image)
        Me.splitterArrowDown.Values.Text = "Arrow Down"
        '
        ' splitterPosBottom
        '
        Me.splitterPosBottom.DropDownPosition = Krypton.Toolkit.VisualOrientation.Bottom
        Me.splitterPosBottom.KryptonContextMenu = Me.kcmDropDown
        Me.splitterPosBottom.Location = New System.Drawing.Point(13, 138)
        Me.splitterPosBottom.Name = "splitterPosBottom"
        Me.splitterPosBottom.PaletteMode = Krypton.Toolkit.PaletteMode.Office2007Blue
        Me.splitterPosBottom.Size = New System.Drawing.Size(130, 48)
        Me.splitterPosBottom.TabIndex = 3
        Me.splitterPosBottom.Values.DropDownArrowColor = System.Drawing.Color.Empty
        Me.splitterPosBottom.Values.Text = "Position Bottom"
        '
        ' splitterPosTop
        '
        Me.splitterPosTop.DropDownPosition = Krypton.Toolkit.VisualOrientation.Top
        Me.splitterPosTop.KryptonContextMenu = Me.kcmDropDown
        Me.splitterPosTop.Location = New System.Drawing.Point(13, 89)
        Me.splitterPosTop.Name = "splitterPosTop"
        Me.splitterPosTop.PaletteMode = Krypton.Toolkit.PaletteMode.Office2007Blue
        Me.splitterPosTop.Size = New System.Drawing.Size(130, 46)
        Me.splitterPosTop.TabIndex = 2
        Me.splitterPosTop.Values.DropDownArrowColor = System.Drawing.Color.Empty
        Me.splitterPosTop.Values.Text = "Position Top"
        '
        ' splitterPosLeft
        '
        Me.splitterPosLeft.DropDownPosition = Krypton.Toolkit.VisualOrientation.Left
        Me.splitterPosLeft.KryptonContextMenu = Me.kcmDropDown
        Me.splitterPosLeft.Location = New System.Drawing.Point(13, 59)
        Me.splitterPosLeft.Name = "splitterPosLeft"
        Me.splitterPosLeft.PaletteMode = Krypton.Toolkit.PaletteMode.Office2007Blue
        Me.splitterPosLeft.Size = New System.Drawing.Size(130, 25)
        Me.splitterPosLeft.TabIndex = 1
        Me.splitterPosLeft.Values.DropDownArrowColor = System.Drawing.Color.Empty
        Me.splitterPosLeft.Values.Text = "Position Left"
        '
        ' splitterPosRight
        '
        Me.splitterPosRight.KryptonContextMenu = Me.kcmDropDown
        Me.splitterPosRight.Location = New System.Drawing.Point(13, 30)
        Me.splitterPosRight.Name = "splitterPosRight"
        Me.splitterPosRight.PaletteMode = Krypton.Toolkit.PaletteMode.Office2007Blue
        Me.splitterPosRight.Size = New System.Drawing.Size(130, 25)
        Me.splitterPosRight.TabIndex = 0
        Me.splitterPosRight.Values.DropDownArrowColor = System.Drawing.Color.Empty
        Me.splitterPosRight.Values.Text = "Position Right"
        '
        ' groupDropDown
        '
        Me.groupDropDown.Controls.Add(Me.dropArrowLeft)
        Me.groupDropDown.Controls.Add(Me.dropArrowRight)
        Me.groupDropDown.Controls.Add(Me.dropArrowUp)
        Me.groupDropDown.Controls.Add(Me.dropArrowDown)
        Me.groupDropDown.Controls.Add(Me.dropPosBottom)
        Me.groupDropDown.Controls.Add(Me.dropPosTop)
        Me.groupDropDown.Controls.Add(Me.dropPosLeft)
        Me.groupDropDown.Controls.Add(Me.dropPosRight)
        Me.groupDropDown.Location = New System.Drawing.Point(12, 209)
        Me.groupDropDown.Name = "groupDropDown"
        Me.groupDropDown.Size = New System.Drawing.Size(288, 191)
        Me.groupDropDown.TabIndex = 1
        Me.groupDropDown.TabStop = False
        Me.groupDropDown.Text = "DropDown"
        '
        ' dropArrowLeft
        '
        Me.dropArrowLeft.DropDownOrientation = Krypton.Toolkit.VisualOrientation.Left
        Me.dropArrowLeft.KryptonContextMenu = Me.kcmDropDown
        Me.dropArrowLeft.Location = New System.Drawing.Point(150, 110)
        Me.dropArrowLeft.Name = "dropArrowLeft"
        Me.dropArrowLeft.PaletteMode = Krypton.Toolkit.PaletteMode.ProfessionalSystem
        Me.dropArrowLeft.Size = New System.Drawing.Size(138, 32)
        Me.dropArrowLeft.Splitter = False
        Me.dropArrowLeft.StateCommon.Content.Image.ImageH = Krypton.Toolkit.PaletteRelativeAlign.Near
        Me.dropArrowLeft.StateCommon.Content.ShortText.TextH = Krypton.Toolkit.PaletteRelativeAlign.Near
        Me.dropArrowLeft.TabIndex = 6
        Me.dropArrowLeft.Values.DropDownArrowColor = System.Drawing.Color.Empty
        Me.dropArrowLeft.Values.Image = CType(resources.GetObject("dropArrowLeft.Values.Image"), System.Drawing.Image)
        Me.dropArrowLeft.Values.Text = "Arrow Left"
        '
        ' dropArrowRight
        '
        Me.dropArrowRight.DropDownOrientation = Krypton.Toolkit.VisualOrientation.Right
        Me.dropArrowRight.KryptonContextMenu = Me.kcmDropDown
        Me.dropArrowRight.Location = New System.Drawing.Point(150, 30)
        Me.dropArrowRight.Name = "dropArrowRight"
        Me.dropArrowRight.PaletteMode = Krypton.Toolkit.PaletteMode.ProfessionalSystem
        Me.dropArrowRight.Size = New System.Drawing.Size(138, 32)
        Me.dropArrowRight.Splitter = False
        Me.dropArrowRight.StateCommon.Content.Image.ImageH = Krypton.Toolkit.PaletteRelativeAlign.Near
        Me.dropArrowRight.StateCommon.Content.ShortText.TextH = Krypton.Toolkit.PaletteRelativeAlign.Near
        Me.dropArrowRight.TabIndex = 4
        Me.dropArrowRight.Values.DropDownArrowColor = System.Drawing.Color.Empty
        Me.dropArrowRight.Values.Image = CType(resources.GetObject("dropArrowRight.Values.Image"), System.Drawing.Image)
        Me.dropArrowRight.Values.Text = "Arrow Right"
        '
        ' dropArrowUp
        '
        Me.dropArrowUp.DropDownOrientation = Krypton.Toolkit.VisualOrientation.Top
        Me.dropArrowUp.KryptonContextMenu = Me.kcmDropDown
        Me.dropArrowUp.Location = New System.Drawing.Point(149, 150)
        Me.dropArrowUp.Name = "dropArrowUp"
        Me.dropArrowUp.PaletteMode = Krypton.Toolkit.PaletteMode.ProfessionalSystem
        Me.dropArrowUp.Size = New System.Drawing.Size(138, 32)
        Me.dropArrowUp.Splitter = False
        Me.dropArrowUp.StateCommon.Content.Image.ImageH = Krypton.Toolkit.PaletteRelativeAlign.Near
        Me.dropArrowUp.StateCommon.Content.ShortText.TextH = Krypton.Toolkit.PaletteRelativeAlign.Near
        Me.dropArrowUp.TabIndex = 7
        Me.dropArrowUp.Values.DropDownArrowColor = System.Drawing.Color.Empty
        Me.dropArrowUp.Values.Image = CType(resources.GetObject("dropArrowUp.Values.Image"), System.Drawing.Image)
        Me.dropArrowUp.Values.Text = "Arrow Up"
        '
        ' dropArrowDown
        '
        Me.dropArrowDown.KryptonContextMenu = Me.kcmDropDown
        Me.dropArrowDown.Location = New System.Drawing.Point(150, 70)
        Me.dropArrowDown.Name = "dropArrowDown"
        Me.dropArrowDown.PaletteMode = Krypton.Toolkit.PaletteMode.ProfessionalSystem
        Me.dropArrowDown.Size = New System.Drawing.Size(138, 32)
        Me.dropArrowDown.Splitter = False
        Me.dropArrowDown.StateCommon.Content.Image.ImageH = Krypton.Toolkit.PaletteRelativeAlign.Near
        Me.dropArrowDown.StateCommon.Content.ShortText.TextH = Krypton.Toolkit.PaletteRelativeAlign.Near
        Me.dropArrowDown.TabIndex = 5
        Me.dropArrowDown.Values.DropDownArrowColor = System.Drawing.Color.Empty
        Me.dropArrowDown.Values.Image = CType(resources.GetObject("dropArrowDown.Values.Image"), System.Drawing.Image)
        Me.dropArrowDown.Values.Text = "Arrow Down"
        '
        ' dropPosBottom
        '
        Me.dropPosBottom.DropDownPosition = Krypton.Toolkit.VisualOrientation.Bottom
        Me.dropPosBottom.KryptonContextMenu = Me.kcmDropDown
        Me.dropPosBottom.Location = New System.Drawing.Point(11, 138)
        Me.dropPosBottom.Name = "dropPosBottom"
        Me.dropPosBottom.PaletteMode = Krypton.Toolkit.PaletteMode.ProfessionalOffice2003
        Me.dropPosBottom.Size = New System.Drawing.Size(132, 44)
        Me.dropPosBottom.Splitter = False
        Me.dropPosBottom.TabIndex = 3
        Me.dropPosBottom.Values.DropDownArrowColor = System.Drawing.Color.Empty
        Me.dropPosBottom.Values.Text = "Position Bottom"
        '
        ' dropPosTop
        '
        Me.dropPosTop.DropDownPosition = Krypton.Toolkit.VisualOrientation.Top
        Me.dropPosTop.KryptonContextMenu = Me.kcmDropDown
        Me.dropPosTop.Location = New System.Drawing.Point(11, 89)
        Me.dropPosTop.Name = "dropPosTop"
        Me.dropPosTop.PaletteMode = Krypton.Toolkit.PaletteMode.ProfessionalOffice2003
        Me.dropPosTop.Size = New System.Drawing.Size(132, 43)
        Me.dropPosTop.Splitter = False
        Me.dropPosTop.TabIndex = 2
        Me.dropPosTop.Values.DropDownArrowColor = System.Drawing.Color.Empty
        Me.dropPosTop.Values.Text = "Position Top"
        '
        ' dropPosLeft
        '
        Me.dropPosLeft.DropDownPosition = Krypton.Toolkit.VisualOrientation.Left
        Me.dropPosLeft.KryptonContextMenu = Me.kcmDropDown
        Me.dropPosLeft.Location = New System.Drawing.Point(11, 59)
        Me.dropPosLeft.Name = "dropPosLeft"
        Me.dropPosLeft.PaletteMode = Krypton.Toolkit.PaletteMode.ProfessionalOffice2003
        Me.dropPosLeft.Size = New System.Drawing.Size(132, 25)
        Me.dropPosLeft.Splitter = False
        Me.dropPosLeft.TabIndex = 1
        Me.dropPosLeft.Values.DropDownArrowColor = System.Drawing.Color.Empty
        Me.dropPosLeft.Values.Text = "Position Left"
        '
        ' dropPosRight
        '
        Me.dropPosRight.KryptonContextMenu = Me.kcmDropDown
        Me.dropPosRight.Location = New System.Drawing.Point(11, 30)
        Me.dropPosRight.Name = "dropPosRight"
        Me.dropPosRight.PaletteMode = Krypton.Toolkit.PaletteMode.ProfessionalOffice2003
        Me.dropPosRight.Size = New System.Drawing.Size(132, 25)
        Me.dropPosRight.Splitter = False
        Me.dropPosRight.TabIndex = 0
        Me.dropPosRight.Values.DropDownArrowColor = System.Drawing.Color.Empty
        Me.dropPosRight.Values.Text = "Position Right"
        '
        ' groupCustom
        '
        Me.groupCustom.Controls.Add(Me.kryptonDropButton3)
        Me.groupCustom.Controls.Add(Me.kryptonDropButton1)
        Me.groupCustom.Controls.Add(Me.dropCustom)
        Me.groupCustom.Controls.Add(Me.splitterCustom)
        Me.groupCustom.Location = New System.Drawing.Point(12, 407)
        Me.groupCustom.Name = "groupCustom"
        Me.groupCustom.Size = New System.Drawing.Size(288, 113)
        Me.groupCustom.TabIndex = 2
        Me.groupCustom.TabStop = False
        Me.groupCustom.Text = "Custom"
        '
        ' kryptonDropButton3
        '
        Me.kryptonDropButton3.DropDownPosition = Krypton.Toolkit.VisualOrientation.Bottom
        Me.kryptonDropButton3.Enabled = False
        Me.kryptonDropButton3.KryptonContextMenu = Me.kcmCustom
        Me.kryptonDropButton3.Location = New System.Drawing.Point(167, 60)
        Me.kryptonDropButton3.Name = "kryptonDropButton3"
        Me.kryptonDropButton3.OverrideDefault.Back.Color1 = System.Drawing.Color.FromArgb(CType(CType(192, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.kryptonDropButton3.OverrideDefault.Border.Color1 = System.Drawing.Color.Green
        Me.kryptonDropButton3.OverrideDefault.Border.DrawBorders = CType((((Krypton.Toolkit.PaletteDrawBorders.Top Or Krypton.Toolkit.PaletteDrawBorders.Bottom) Or Krypton.Toolkit.PaletteDrawBorders.Left) Or Krypton.Toolkit.PaletteDrawBorders.Right), Krypton.Toolkit.PaletteDrawBorders)
        Me.kryptonDropButton3.OverrideDefault.Content.ShortText.Color1 = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(64, Byte), Integer), CType(CType(0, Byte), Integer))
        Me.kryptonDropButton3.Size = New System.Drawing.Size(115, 52)
        Me.kryptonDropButton3.Splitter = False
        Me.kryptonDropButton3.StateCommon.Back.ColorStyle = Krypton.Toolkit.PaletteColorStyle.Solid
        Me.kryptonDropButton3.StateCommon.Border.ColorStyle = Krypton.Toolkit.PaletteColorStyle.Solid
        Me.kryptonDropButton3.StateCommon.Border.DrawBorders = CType((((Krypton.Toolkit.PaletteDrawBorders.Top Or Krypton.Toolkit.PaletteDrawBorders.Bottom) Or Krypton.Toolkit.PaletteDrawBorders.Left) Or Krypton.Toolkit.PaletteDrawBorders.Right), Krypton.Toolkit.PaletteDrawBorders)
        Me.kryptonDropButton3.StateCommon.Border.Rounding = 4.0!
        Me.kryptonDropButton3.StateCommon.Border.Width = 2
        Me.kryptonDropButton3.StateNormal.Back.Color1 = System.Drawing.Color.FromArgb(CType(CType(192, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.kryptonDropButton3.StateNormal.Back.ColorStyle = Krypton.Toolkit.PaletteColorStyle.Solid
        Me.kryptonDropButton3.StateNormal.Border.Color1 = System.Drawing.Color.Green
        Me.kryptonDropButton3.StateNormal.Border.DrawBorders = CType((((Krypton.Toolkit.PaletteDrawBorders.Top Or Krypton.Toolkit.PaletteDrawBorders.Bottom) Or Krypton.Toolkit.PaletteDrawBorders.Left) Or Krypton.Toolkit.PaletteDrawBorders.Right), Krypton.Toolkit.PaletteDrawBorders)
        Me.kryptonDropButton3.StateNormal.Content.ShortText.Color1 = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(64, Byte), Integer), CType(CType(0, Byte), Integer))
        Me.kryptonDropButton3.StatePressed.Back.Color1 = System.Drawing.Color.FromArgb(CType(CType(128, Byte), Integer), CType(CType(128, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.kryptonDropButton3.StatePressed.Border.Color1 = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(64, Byte), Integer))
        Me.kryptonDropButton3.StatePressed.Border.DrawBorders = CType((((Krypton.Toolkit.PaletteDrawBorders.Top Or Krypton.Toolkit.PaletteDrawBorders.Bottom) Or Krypton.Toolkit.PaletteDrawBorders.Left) Or Krypton.Toolkit.PaletteDrawBorders.Right), Krypton.Toolkit.PaletteDrawBorders)
        Me.kryptonDropButton3.StatePressed.Content.ShortText.Color1 = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(64, Byte), Integer))
        Me.kryptonDropButton3.StateTracking.Back.Color1 = System.Drawing.Color.FromArgb(CType(CType(192, Byte), Integer), CType(CType(192, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.kryptonDropButton3.StateTracking.Border.Color1 = System.Drawing.Color.Navy
        Me.kryptonDropButton3.StateTracking.Border.DrawBorders = CType((((Krypton.Toolkit.PaletteDrawBorders.Top Or Krypton.Toolkit.PaletteDrawBorders.Bottom) Or Krypton.Toolkit.PaletteDrawBorders.Left) Or Krypton.Toolkit.PaletteDrawBorders.Right), Krypton.Toolkit.PaletteDrawBorders)
        Me.kryptonDropButton3.StateTracking.Content.ShortText.Color1 = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(64, Byte), Integer))
        Me.kryptonDropButton3.TabIndex = 3
        Me.kryptonDropButton3.Values.DropDownArrowColor = System.Drawing.Color.Empty
        Me.kryptonDropButton3.Values.Text = "Disabled Drop"
        '
        ' kcmCustom
        '
        Me.kcmCustom.Items.AddRange(New Krypton.Toolkit.KryptonContextMenuItemBase() { Me.kryptonContextMenuHeading5, Me.kryptonContextMenuItems5})
        Me.kcmCustom.PaletteMode = Krypton.Toolkit.PaletteMode.ProfessionalSystem
        Me.kcmCustom.StateCommon.ControlInner.Back.Color1 = System.Drawing.Color.FromArgb(CType(CType(192, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.kcmCustom.StateCommon.ControlInner.Back.ColorStyle = Krypton.Toolkit.PaletteColorStyle.Solid
        Me.kcmCustom.StateCommon.ControlInner.Border.Color1 = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(192, Byte), Integer), CType(CType(0, Byte), Integer))
        Me.kcmCustom.StateCommon.ControlInner.Border.DrawBorders = CType((((Krypton.Toolkit.PaletteDrawBorders.Top Or Krypton.Toolkit.PaletteDrawBorders.Bottom) Or Krypton.Toolkit.PaletteDrawBorders.Left) Or Krypton.Toolkit.PaletteDrawBorders.Right), Krypton.Toolkit.PaletteDrawBorders)
        Me.kcmCustom.StateCommon.ControlInner.Border.GraphicsHint = Krypton.Toolkit.PaletteGraphicsHint.AntiAlias
        Me.kcmCustom.StateCommon.ControlInner.Border.Rounding = 4.0!
        Me.kcmCustom.StateCommon.ControlInner.Border.Width = 2
        Me.kcmCustom.StateCommon.ControlOuter.Back.Color1 = System.Drawing.Color.FromArgb(CType(CType(192, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.kcmCustom.StateCommon.ControlOuter.Back.ColorStyle = Krypton.Toolkit.PaletteColorStyle.Solid
        Me.kcmCustom.StateCommon.ControlOuter.Border.Color1 = System.Drawing.Color.Green
        Me.kcmCustom.StateCommon.ControlOuter.Border.DrawBorders = CType((((Krypton.Toolkit.PaletteDrawBorders.Top Or Krypton.Toolkit.PaletteDrawBorders.Bottom) Or Krypton.Toolkit.PaletteDrawBorders.Left) Or Krypton.Toolkit.PaletteDrawBorders.Right), Krypton.Toolkit.PaletteDrawBorders)
        Me.kcmCustom.StateCommon.ControlOuter.Border.GraphicsHint = Krypton.Toolkit.PaletteGraphicsHint.AntiAlias
        Me.kcmCustom.StateCommon.ControlOuter.Border.Rounding = 4.0!
        Me.kcmCustom.StateCommon.ControlOuter.Border.Width = 2
        Me.kcmCustom.StateCommon.Heading.Back.Color1 = System.Drawing.Color.FromArgb(CType(CType(192, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.kcmCustom.StateCommon.Heading.Back.Color2 = System.Drawing.Color.Lime
        Me.kcmCustom.StateCommon.Heading.Back.ColorStyle = Krypton.Toolkit.PaletteColorStyle.Linear
        Me.kcmCustom.StateCommon.Heading.Border.Color1 = System.Drawing.Color.Green
        Me.kcmCustom.StateCommon.Heading.Border.Color2 = System.Drawing.Color.Green
        Me.kcmCustom.StateCommon.Heading.Border.DrawBorders = Krypton.Toolkit.PaletteDrawBorders.Bottom
        Me.kcmCustom.StateCommon.Heading.Content.ShortText.Color1 = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(64, Byte), Integer), CType(CType(0, Byte), Integer))
        Me.kcmCustom.StateCommon.ItemImageColumn.Back.Color1 = System.Drawing.Color.FromArgb(CType(CType(236, Byte), Integer), CType(CType(254, Byte), Integer), CType(CType(188, Byte), Integer))
        Me.kcmCustom.StateCommon.ItemImageColumn.Back.ColorStyle = Krypton.Toolkit.PaletteColorStyle.Solid
        Me.kcmCustom.StateCommon.ItemImageColumn.Border.Color1 = System.Drawing.Color.Teal
        Me.kcmCustom.StateCommon.ItemImageColumn.Border.DrawBorders = Krypton.Toolkit.PaletteDrawBorders.None
        Me.kcmCustom.StateCommon.ItemTextStandard.ShortText.Color1 = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(64, Byte), Integer), CType(CType(0, Byte), Integer))
        '
        ' kryptonContextMenuHeading5
        '
        Me.kryptonContextMenuHeading5.ExtraText = ""
        Me.kryptonContextMenuHeading5.Text = ""
        '
        ' kryptonContextMenuItems5
        '
        Me.kryptonContextMenuItems5.Items.AddRange(New Krypton.Toolkit.KryptonContextMenuItemBase() { Me.kryptonContextMenuItem13, Me.kryptonContextMenuItem14, Me.kryptonContextMenuItem15})
        '
        ' kryptonContextMenuItem13
        '
        Me.kryptonContextMenuItem13.Text = "Menu Item 1"
        '
        ' kryptonContextMenuItem14
        '
        Me.kryptonContextMenuItem14.Checked = True
        Me.kryptonContextMenuItem14.CheckState = System.Windows.Forms.CheckState.Indeterminate
        Me.kryptonContextMenuItem14.Text = "Menu Item 2"
        '
        ' kryptonContextMenuItem15
        '
        Me.kryptonContextMenuItem15.Checked = True
        Me.kryptonContextMenuItem15.CheckState = System.Windows.Forms.CheckState.Checked
        Me.kryptonContextMenuItem15.Text = "Menu Item 3"
        '
        ' kryptonDropButton1
        '
        Me.kryptonDropButton1.Enabled = False
        Me.kryptonDropButton1.KryptonContextMenu = Me.kcmCustom
        Me.kryptonDropButton1.Location = New System.Drawing.Point(12, 60)
        Me.kryptonDropButton1.Name = "kryptonDropButton1"
        Me.kryptonDropButton1.OverrideDefault.Back.Color1 = System.Drawing.Color.FromArgb(CType(CType(192, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.kryptonDropButton1.OverrideDefault.Border.Color1 = System.Drawing.Color.Green
        Me.kryptonDropButton1.OverrideDefault.Border.DrawBorders = CType((((Krypton.Toolkit.PaletteDrawBorders.Top Or Krypton.Toolkit.PaletteDrawBorders.Bottom) Or Krypton.Toolkit.PaletteDrawBorders.Left) Or Krypton.Toolkit.PaletteDrawBorders.Right), Krypton.Toolkit.PaletteDrawBorders)
        Me.kryptonDropButton1.OverrideDefault.Content.ShortText.Color1 = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(64, Byte), Integer), CType(CType(0, Byte), Integer))
        Me.kryptonDropButton1.Size = New System.Drawing.Size(135, 30)
        Me.kryptonDropButton1.StateCommon.Back.ColorStyle = Krypton.Toolkit.PaletteColorStyle.Solid
        Me.kryptonDropButton1.StateCommon.Border.ColorStyle = Krypton.Toolkit.PaletteColorStyle.Solid
        Me.kryptonDropButton1.StateCommon.Border.DrawBorders = CType((((Krypton.Toolkit.PaletteDrawBorders.Top Or Krypton.Toolkit.PaletteDrawBorders.Bottom) Or Krypton.Toolkit.PaletteDrawBorders.Left) Or Krypton.Toolkit.PaletteDrawBorders.Right), Krypton.Toolkit.PaletteDrawBorders)
        Me.kryptonDropButton1.StateCommon.Border.Rounding = 4.0!
        Me.kryptonDropButton1.StateCommon.Border.Width = 2
        Me.kryptonDropButton1.StateNormal.Back.Color1 = System.Drawing.Color.FromArgb(CType(CType(192, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.kryptonDropButton1.StateNormal.Back.ColorStyle = Krypton.Toolkit.PaletteColorStyle.Solid
        Me.kryptonDropButton1.StateNormal.Border.Color1 = System.Drawing.Color.Green
        Me.kryptonDropButton1.StateNormal.Border.DrawBorders = CType((((Krypton.Toolkit.PaletteDrawBorders.Top Or Krypton.Toolkit.PaletteDrawBorders.Bottom) Or Krypton.Toolkit.PaletteDrawBorders.Left) Or Krypton.Toolkit.PaletteDrawBorders.Right), Krypton.Toolkit.PaletteDrawBorders)
        Me.kryptonDropButton1.StateNormal.Content.ShortText.Color1 = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(64, Byte), Integer), CType(CType(0, Byte), Integer))
        Me.kryptonDropButton1.StatePressed.Back.Color1 = System.Drawing.Color.FromArgb(CType(CType(128, Byte), Integer), CType(CType(128, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.kryptonDropButton1.StatePressed.Border.Color1 = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(64, Byte), Integer))
        Me.kryptonDropButton1.StatePressed.Border.DrawBorders = CType((((Krypton.Toolkit.PaletteDrawBorders.Top Or Krypton.Toolkit.PaletteDrawBorders.Bottom) Or Krypton.Toolkit.PaletteDrawBorders.Left) Or Krypton.Toolkit.PaletteDrawBorders.Right), Krypton.Toolkit.PaletteDrawBorders)
        Me.kryptonDropButton1.StatePressed.Content.ShortText.Color1 = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(64, Byte), Integer))
        Me.kryptonDropButton1.StateTracking.Back.Color1 = System.Drawing.Color.FromArgb(CType(CType(192, Byte), Integer), CType(CType(192, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.kryptonDropButton1.StateTracking.Border.Color1 = System.Drawing.Color.Navy
        Me.kryptonDropButton1.StateTracking.Border.DrawBorders = CType((((Krypton.Toolkit.PaletteDrawBorders.Top Or Krypton.Toolkit.PaletteDrawBorders.Bottom) Or Krypton.Toolkit.PaletteDrawBorders.Left) Or Krypton.Toolkit.PaletteDrawBorders.Right), Krypton.Toolkit.PaletteDrawBorders)
        Me.kryptonDropButton1.StateTracking.Content.ShortText.Color1 = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(64, Byte), Integer))
        Me.kryptonDropButton1.TabIndex = 2
        Me.kryptonDropButton1.Values.DropDownArrowColor = System.Drawing.Color.Empty
        Me.kryptonDropButton1.Values.Text = "Disabled Split"
        '
        ' dropCustom
        '
        Me.dropCustom.DropDownPosition = Krypton.Toolkit.VisualOrientation.Bottom
        Me.dropCustom.KryptonContextMenu = Me.kcmCustom
        Me.dropCustom.Location = New System.Drawing.Point(167, 13)
        Me.dropCustom.Name = "dropCustom"
        Me.dropCustom.OverrideDefault.Back.Color1 = System.Drawing.Color.FromArgb(CType(CType(192, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.dropCustom.OverrideDefault.Border.Color1 = System.Drawing.Color.Green
        Me.dropCustom.OverrideDefault.Border.DrawBorders = CType((((Krypton.Toolkit.PaletteDrawBorders.Top Or Krypton.Toolkit.PaletteDrawBorders.Bottom) Or Krypton.Toolkit.PaletteDrawBorders.Left) Or Krypton.Toolkit.PaletteDrawBorders.Right), Krypton.Toolkit.PaletteDrawBorders)
        Me.dropCustom.OverrideDefault.Content.ShortText.Color1 = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(64, Byte), Integer), CType(CType(0, Byte), Integer))
        Me.dropCustom.Size = New System.Drawing.Size(115, 52)
        Me.dropCustom.Splitter = False
        Me.dropCustom.StateCommon.Back.ColorStyle = Krypton.Toolkit.PaletteColorStyle.Solid
        Me.dropCustom.StateCommon.Border.ColorStyle = Krypton.Toolkit.PaletteColorStyle.Solid
        Me.dropCustom.StateCommon.Border.DrawBorders = CType((((Krypton.Toolkit.PaletteDrawBorders.Top Or Krypton.Toolkit.PaletteDrawBorders.Bottom) Or Krypton.Toolkit.PaletteDrawBorders.Left) Or Krypton.Toolkit.PaletteDrawBorders.Right), Krypton.Toolkit.PaletteDrawBorders)
        Me.dropCustom.StateCommon.Border.Rounding = 4.0!
        Me.dropCustom.StateCommon.Border.Width = 2
        Me.dropCustom.StateNormal.Back.Color1 = System.Drawing.Color.FromArgb(CType(CType(192, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.dropCustom.StateNormal.Back.ColorStyle = Krypton.Toolkit.PaletteColorStyle.Solid
        Me.dropCustom.StateNormal.Border.Color1 = System.Drawing.Color.Green
        Me.dropCustom.StateNormal.Border.DrawBorders = CType((((Krypton.Toolkit.PaletteDrawBorders.Top Or Krypton.Toolkit.PaletteDrawBorders.Bottom) Or Krypton.Toolkit.PaletteDrawBorders.Left) Or Krypton.Toolkit.PaletteDrawBorders.Right), Krypton.Toolkit.PaletteDrawBorders)
        Me.dropCustom.StateNormal.Content.ShortText.Color1 = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(64, Byte), Integer), CType(CType(0, Byte), Integer))
        Me.dropCustom.StatePressed.Back.Color1 = System.Drawing.Color.FromArgb(CType(CType(128, Byte), Integer), CType(CType(128, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.dropCustom.StatePressed.Border.Color1 = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(64, Byte), Integer))
        Me.dropCustom.StatePressed.Border.DrawBorders = CType((((Krypton.Toolkit.PaletteDrawBorders.Top Or Krypton.Toolkit.PaletteDrawBorders.Bottom) Or Krypton.Toolkit.PaletteDrawBorders.Left) Or Krypton.Toolkit.PaletteDrawBorders.Right), Krypton.Toolkit.PaletteDrawBorders)
        Me.dropCustom.StatePressed.Content.ShortText.Color1 = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(64, Byte), Integer))
        Me.dropCustom.StateTracking.Back.Color1 = System.Drawing.Color.FromArgb(CType(CType(192, Byte), Integer), CType(CType(192, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.dropCustom.StateTracking.Border.Color1 = System.Drawing.Color.Navy
        Me.dropCustom.StateTracking.Border.DrawBorders = CType((((Krypton.Toolkit.PaletteDrawBorders.Top Or Krypton.Toolkit.PaletteDrawBorders.Bottom) Or Krypton.Toolkit.PaletteDrawBorders.Left) Or Krypton.Toolkit.PaletteDrawBorders.Right), Krypton.Toolkit.PaletteDrawBorders)
        Me.dropCustom.StateTracking.Content.ShortText.Color1 = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(64, Byte), Integer))
        Me.dropCustom.TabIndex = 1
        Me.dropCustom.Values.DropDownArrowColor = System.Drawing.Color.Empty
        Me.dropCustom.Values.Text = "Custom Drop"
        '
        ' splitterCustom
        '
        Me.splitterCustom.KryptonContextMenu = Me.kcmCustom
        Me.splitterCustom.Location = New System.Drawing.Point(12, 24)
        Me.splitterCustom.Name = "splitterCustom"
        Me.splitterCustom.OverrideDefault.Back.Color1 = System.Drawing.Color.FromArgb(CType(CType(192, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.splitterCustom.OverrideDefault.Border.Color1 = System.Drawing.Color.Green
        Me.splitterCustom.OverrideDefault.Border.DrawBorders = CType((((Krypton.Toolkit.PaletteDrawBorders.Top Or Krypton.Toolkit.PaletteDrawBorders.Bottom) Or Krypton.Toolkit.PaletteDrawBorders.Left) Or Krypton.Toolkit.PaletteDrawBorders.Right), Krypton.Toolkit.PaletteDrawBorders)
        Me.splitterCustom.OverrideDefault.Content.ShortText.Color1 = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(64, Byte), Integer), CType(CType(0, Byte), Integer))
        Me.splitterCustom.Size = New System.Drawing.Size(135, 30)
        Me.splitterCustom.StateCommon.Back.ColorStyle = Krypton.Toolkit.PaletteColorStyle.Solid
        Me.splitterCustom.StateCommon.Border.ColorStyle = Krypton.Toolkit.PaletteColorStyle.Solid
        Me.splitterCustom.StateCommon.Border.DrawBorders = CType((((Krypton.Toolkit.PaletteDrawBorders.Top Or Krypton.Toolkit.PaletteDrawBorders.Bottom) Or Krypton.Toolkit.PaletteDrawBorders.Left) Or Krypton.Toolkit.PaletteDrawBorders.Right), Krypton.Toolkit.PaletteDrawBorders)
        Me.splitterCustom.StateCommon.Border.Rounding = 4.0!
        Me.splitterCustom.StateCommon.Border.Width = 2
        Me.splitterCustom.StateNormal.Back.Color1 = System.Drawing.Color.FromArgb(CType(CType(192, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.splitterCustom.StateNormal.Back.ColorStyle = Krypton.Toolkit.PaletteColorStyle.Solid
        Me.splitterCustom.StateNormal.Border.Color1 = System.Drawing.Color.Green
        Me.splitterCustom.StateNormal.Border.DrawBorders = CType((((Krypton.Toolkit.PaletteDrawBorders.Top Or Krypton.Toolkit.PaletteDrawBorders.Bottom) Or Krypton.Toolkit.PaletteDrawBorders.Left) Or Krypton.Toolkit.PaletteDrawBorders.Right), Krypton.Toolkit.PaletteDrawBorders)
        Me.splitterCustom.StateNormal.Content.ShortText.Color1 = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(64, Byte), Integer), CType(CType(0, Byte), Integer))
        Me.splitterCustom.StatePressed.Back.Color1 = System.Drawing.Color.FromArgb(CType(CType(128, Byte), Integer), CType(CType(128, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.splitterCustom.StatePressed.Border.Color1 = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(64, Byte), Integer))
        Me.splitterCustom.StatePressed.Border.DrawBorders = CType((((Krypton.Toolkit.PaletteDrawBorders.Top Or Krypton.Toolkit.PaletteDrawBorders.Bottom) Or Krypton.Toolkit.PaletteDrawBorders.Left) Or Krypton.Toolkit.PaletteDrawBorders.Right), Krypton.Toolkit.PaletteDrawBorders)
        Me.splitterCustom.StatePressed.Content.ShortText.Color1 = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(64, Byte), Integer))
        Me.splitterCustom.StateTracking.Back.Color1 = System.Drawing.Color.FromArgb(CType(CType(192, Byte), Integer), CType(CType(192, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.splitterCustom.StateTracking.Border.Color1 = System.Drawing.Color.Navy
        Me.splitterCustom.StateTracking.Border.DrawBorders = CType((((Krypton.Toolkit.PaletteDrawBorders.Top Or Krypton.Toolkit.PaletteDrawBorders.Bottom) Or Krypton.Toolkit.PaletteDrawBorders.Left) Or Krypton.Toolkit.PaletteDrawBorders.Right), Krypton.Toolkit.PaletteDrawBorders)
        Me.splitterCustom.StateTracking.Content.ShortText.Color1 = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(64, Byte), Integer))
        Me.splitterCustom.TabIndex = 0
        Me.splitterCustom.Values.DropDownArrowColor = System.Drawing.Color.Empty
        Me.splitterCustom.Values.Text = "Custom Split"
        '
        ' Form1
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 17.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(640, 561)
        Me.Controls.Add(Me.groupCustom)
        Me.Controls.Add(Me.groupDropDown)
        Me.Controls.Add(Me.groupSplitter)
        Me.Controls.Add(Me.buttonClose)
        Me.Controls.Add(Me.groupProperties)
        Me.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.MaximizeBox = False
        Me.MinimizeBox = False
        Me.Name = "Form1"
        Me.Text = "KryptonDropButton Examples"
        Me.groupProperties.ResumeLayout(False)
        Me.groupSplitter.ResumeLayout(False)
        Me.groupDropDown.ResumeLayout(False)
        Me.groupCustom.ResumeLayout(False)
        Me.ResumeLayout(False)

    End Sub

#End Region

    Private WithEvents buttonClose As System.Windows.Forms.Button
    Private WithEvents groupProperties As System.Windows.Forms.GroupBox
    Private WithEvents propertyGrid As System.Windows.Forms.PropertyGrid
    Private WithEvents groupSplitter As System.Windows.Forms.GroupBox
    Private WithEvents splitterPosBottom As Krypton.Toolkit.KryptonDropButton
    Private WithEvents splitterPosTop As Krypton.Toolkit.KryptonDropButton
    Private WithEvents splitterPosLeft As Krypton.Toolkit.KryptonDropButton
    Private WithEvents splitterPosRight As Krypton.Toolkit.KryptonDropButton
    Private WithEvents kcmDropDown As Krypton.Toolkit.KryptonContextMenu
    Private WithEvents kryptonContextMenuHeading1 As Krypton.Toolkit.KryptonContextMenuHeading
    Private WithEvents kryptonContextMenuItems1 As Krypton.Toolkit.KryptonContextMenuItems
    Private WithEvents kryptonContextMenuItem1 As Krypton.Toolkit.KryptonContextMenuItem
    Private WithEvents kryptonContextMenuItem2 As Krypton.Toolkit.KryptonContextMenuItem
    Private WithEvents kryptonContextMenuItem3 As Krypton.Toolkit.KryptonContextMenuItem
    Private WithEvents splitterArrowLeft As Krypton.Toolkit.KryptonDropButton
    Private WithEvents splitterArrowRight As Krypton.Toolkit.KryptonDropButton
    Private WithEvents splitterArrowUp As Krypton.Toolkit.KryptonDropButton
    Private WithEvents splitterArrowDown As Krypton.Toolkit.KryptonDropButton
    Private WithEvents groupDropDown As System.Windows.Forms.GroupBox
    Private WithEvents dropArrowLeft As Krypton.Toolkit.KryptonDropButton
    Private WithEvents dropArrowRight As Krypton.Toolkit.KryptonDropButton
    Private WithEvents dropArrowUp As Krypton.Toolkit.KryptonDropButton
    Private WithEvents dropArrowDown As Krypton.Toolkit.KryptonDropButton
    Private WithEvents dropPosBottom As Krypton.Toolkit.KryptonDropButton
    Private WithEvents dropPosTop As Krypton.Toolkit.KryptonDropButton
    Private WithEvents dropPosLeft As Krypton.Toolkit.KryptonDropButton
    Private WithEvents dropPosRight As Krypton.Toolkit.KryptonDropButton
    Private WithEvents groupCustom As System.Windows.Forms.GroupBox
    Private WithEvents splitterCustom As Krypton.Toolkit.KryptonDropButton
    Private WithEvents dropCustom As Krypton.Toolkit.KryptonDropButton
    Private WithEvents kcmCustom As Krypton.Toolkit.KryptonContextMenu
    Private WithEvents kryptonContextMenuHeading5 As Krypton.Toolkit.KryptonContextMenuHeading
    Private WithEvents kryptonContextMenuItems5 As Krypton.Toolkit.KryptonContextMenuItems
    Private WithEvents kryptonContextMenuItem13 As Krypton.Toolkit.KryptonContextMenuItem
    Private WithEvents kryptonContextMenuItem14 As Krypton.Toolkit.KryptonContextMenuItem
    Private WithEvents kryptonContextMenuItem15 As Krypton.Toolkit.KryptonContextMenuItem
    Private WithEvents kryptonDropButton1 As Krypton.Toolkit.KryptonDropButton
    Private WithEvents kryptonDropButton2 As Krypton.Toolkit.KryptonDropButton
    Private WithEvents kryptonDropButton3 As Krypton.Toolkit.KryptonDropButton

End Class
