' VB.NET twin of Source\Krypton Toolkit Examples\KryptonDataGridView Examples\Form1.Designer.cs (Bastion Phase 4c).

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

        Me.components = New System.ComponentModel.Container()
        Dim dataGridViewCellStyle1 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim dataGridViewCellStyle2 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(Form1))
        Me.groupBox4 = New System.Windows.Forms.GroupBox()
        Me.propertyGrid = New System.Windows.Forms.PropertyGrid()
        Me.dataSet = New System.Data.DataSet()
        Me.dtTestData = New System.Data.DataTable()
        Me.dataDateTime = New System.Data.DataColumn()
        Me.dataComboBox = New System.Data.DataColumn()
        Me.dataTextBox = New System.Data.DataColumn()
        Me.dataMaskedTextBox = New System.Data.DataColumn()
        Me.dataDomainUpDown = New System.Data.DataColumn()
        Me.dataNumericUpDown = New System.Data.DataColumn()
        Me.dataButton = New System.Data.DataColumn()
        Me.dataCheckBox = New System.Data.DataColumn()
        Me.rbStyleList = New System.Windows.Forms.RadioButton()
        Me.groupBoxGridStyle = New System.Windows.Forms.GroupBox()
        Me.rbStyleCustom = New System.Windows.Forms.RadioButton()
        Me.rbStyleSheet = New System.Windows.Forms.RadioButton()
        Me.groupBox1 = New System.Windows.Forms.GroupBox()
        Me.buttonClearCellColors = New Krypton.Toolkit.KryptonButton()
        Me.buttonRandomCellColors = New Krypton.Toolkit.KryptonButton()
        Me.btnForm2 = New System.Windows.Forms.Button()
        Me.kryptonLabel1 = New Krypton.Toolkit.KryptonLabel()
        Me.kryptonDataGridView1 = New Krypton.Toolkit.KryptonDataGridView()
        Me.kryptonContextMenu1 = New Krypton.Toolkit.KryptonContextMenu()
        Me.kryptonContextMenuItems1 = New Krypton.Toolkit.KryptonContextMenuItems()
        Me.kryptonContextMenuHeading1 = New Krypton.Toolkit.KryptonContextMenuHeading()
        Me.kryptonContextMenuSeparator1 = New Krypton.Toolkit.KryptonContextMenuSeparator()
        Me.kryptonContextMenuCheckBox1 = New Krypton.Toolkit.KryptonContextMenuCheckBox()
        Me.kryptonContextMenuCheckButton1 = New Krypton.Toolkit.KryptonContextMenuCheckButton()
        Me.kryptonContextMenuRadioButton1 = New Krypton.Toolkit.KryptonContextMenuRadioButton()
        Me.kryptonContextMenuLinkLabel1 = New Krypton.Toolkit.KryptonContextMenuLinkLabel()
        Me.kryptonContextMenuColorColumns1 = New Krypton.Toolkit.KryptonContextMenuColorColumns()
        Me.kryptonContextMenuImageSelect1 = New Krypton.Toolkit.KryptonContextMenuImageSelect()
        Me.kryptonContextMenuMonthCalendar1 = New Krypton.Toolkit.KryptonContextMenuMonthCalendar()
        Me.kryptonPalette = New Krypton.Toolkit.KryptonCustomPaletteBase(Me.components)
        Me.kryptonManager = New Krypton.Toolkit.KryptonManager(Me.components)
        Me.kryptonThemeListBox1 = New Krypton.Toolkit.KryptonThemeListBox()
        Me.colDateTime = New Krypton.Toolkit.KryptonDataGridViewDateTimePickerColumn()
        Me.colComboBox = New Krypton.Toolkit.KryptonDataGridViewComboBoxColumn()
        Me.colTextBox = New Krypton.Toolkit.KryptonDataGridViewTextBoxColumn()
        Me.colMaskedTextBox = New Krypton.Toolkit.KryptonDataGridViewMaskedTextBoxColumn()
        Me.colDomainUpDown = New Krypton.Toolkit.KryptonDataGridViewDomainUpDownColumn()
        Me.colNumericUpDown = New Krypton.Toolkit.KryptonDataGridViewNumericUpDownColumn()
        Me.colButton = New Krypton.Toolkit.KryptonDataGridViewButtonColumn()
        Me.colCheckBox = New Krypton.Toolkit.KryptonDataGridViewCheckBoxColumn()
        Me.groupBox4.SuspendLayout()
        CType(Me.dataSet, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.dtTestData, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.groupBoxGridStyle.SuspendLayout()
        Me.groupBox1.SuspendLayout()
        CType(Me.kryptonDataGridView1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        ' groupBox4
        '
        Me.groupBox4.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.groupBox4.Controls.Add(Me.propertyGrid)
        Me.groupBox4.Location = New System.Drawing.Point(888, 12)
        Me.groupBox4.Name = "groupBox4"
        Me.groupBox4.Size = New System.Drawing.Size(336, 473)
        Me.groupBox4.TabIndex = 3
        Me.groupBox4.TabStop = False
        Me.groupBox4.Text = "Properties for KryptonDataGridView"
        '
        ' propertyGrid
        '
        Me.propertyGrid.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) Or System.Windows.Forms.AnchorStyles.Left) Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.propertyGrid.Location = New System.Drawing.Point(3, 20)
        Me.propertyGrid.Name = "propertyGrid"
        Me.propertyGrid.Size = New System.Drawing.Size(330, 450)
        Me.propertyGrid.TabIndex = 0
        Me.propertyGrid.ToolbarVisible = False
        '
        ' dataSet
        '
        Me.dataSet.DataSetName = "NewDataSet"
        Me.dataSet.Tables.AddRange(New System.Data.DataTable() { Me.dtTestData})
        '
        ' dtTestData
        '
        Me.dtTestData.Columns.AddRange(New System.Data.DataColumn() { Me.dataDateTime, Me.dataComboBox, Me.dataTextBox, Me.dataMaskedTextBox, Me.dataDomainUpDown, Me.dataNumericUpDown, Me.dataButton, Me.dataCheckBox})
        Me.dtTestData.TableName = "TestData"
        '
        ' dataDateTime
        '
        Me.dataDateTime.Caption = "DateTime"
        Me.dataDateTime.ColumnName = "DateTime"
        Me.dataDateTime.DataType = GetType(System.DateTime)
        '
        ' dataComboBox
        '
        Me.dataComboBox.Caption = "ComboBox"
        Me.dataComboBox.ColumnName = "ComboBox"
        '
        ' dataTextBox
        '
        Me.dataTextBox.Caption = "TextBox"
        Me.dataTextBox.ColumnName = "TextBox"
        '
        ' dataMaskedTextBox
        '
        Me.dataMaskedTextBox.Caption = "MaskedTextBox"
        Me.dataMaskedTextBox.ColumnName = "MaskedTextBox"
        '
        ' dataDomainUpDown
        '
        Me.dataDomainUpDown.Caption = "DomainUpDown"
        Me.dataDomainUpDown.ColumnName = "DomainUpDown"
        '
        ' dataNumericUpDown
        '
        Me.dataNumericUpDown.Caption = "NumericUpDown"
        Me.dataNumericUpDown.ColumnName = "NumericUpDown"
        Me.dataNumericUpDown.DataType = GetType(Decimal)
        '
        ' dataButton
        '
        Me.dataButton.Caption = "Button"
        Me.dataButton.ColumnName = "Button"
        '
        ' dataCheckBox
        '
        Me.dataCheckBox.Caption = "CheckBox"
        Me.dataCheckBox.ColumnName = "CheckBox"
        Me.dataCheckBox.DataType = GetType(Boolean)
        '
        ' rbStyleList
        '
        Me.rbStyleList.AutoSize = True
        Me.rbStyleList.Checked = True
        Me.rbStyleList.Location = New System.Drawing.Point(18, 26)
        Me.rbStyleList.Name = "rbStyleList"
        Me.rbStyleList.Size = New System.Drawing.Size(41, 17)
        Me.rbStyleList.TabIndex = 0
        Me.rbStyleList.TabStop = True
        Me.rbStyleList.Text = "List"
        Me.rbStyleList.UseVisualStyleBackColor = True
        '
        ' groupBoxGridStyle
        '
        Me.groupBoxGridStyle.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Left), System.Windows.Forms.AnchorStyles)
        Me.groupBoxGridStyle.Controls.Add(Me.rbStyleCustom)
        Me.groupBoxGridStyle.Controls.Add(Me.rbStyleSheet)
        Me.groupBoxGridStyle.Controls.Add(Me.rbStyleList)
        Me.groupBoxGridStyle.Location = New System.Drawing.Point(12, 278)
        Me.groupBoxGridStyle.Name = "groupBoxGridStyle"
        Me.groupBoxGridStyle.Size = New System.Drawing.Size(91, 204)
        Me.groupBoxGridStyle.TabIndex = 2
        Me.groupBoxGridStyle.TabStop = False
        Me.groupBoxGridStyle.Text = "GridStyle"
        '
        ' rbStyleCustom
        '
        Me.rbStyleCustom.AutoSize = True
        Me.rbStyleCustom.Location = New System.Drawing.Point(18, 72)
        Me.rbStyleCustom.Name = "rbStyleCustom"
        Me.rbStyleCustom.Size = New System.Drawing.Size(61, 17)
        Me.rbStyleCustom.TabIndex = 2
        Me.rbStyleCustom.Text = "Custom"
        Me.rbStyleCustom.UseVisualStyleBackColor = True
        '
        ' rbStyleSheet
        '
        Me.rbStyleSheet.AutoSize = True
        Me.rbStyleSheet.Location = New System.Drawing.Point(18, 49)
        Me.rbStyleSheet.Name = "rbStyleSheet"
        Me.rbStyleSheet.Size = New System.Drawing.Size(53, 17)
        Me.rbStyleSheet.TabIndex = 1
        Me.rbStyleSheet.Text = "Sheet"
        Me.rbStyleSheet.UseVisualStyleBackColor = True
        '
        ' groupBox1
        '
        Me.groupBox1.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Left), System.Windows.Forms.AnchorStyles)
        Me.groupBox1.Controls.Add(Me.buttonClearCellColors)
        Me.groupBox1.Controls.Add(Me.buttonRandomCellColors)
        Me.groupBox1.Location = New System.Drawing.Point(109, 279)
        Me.groupBox1.Name = "groupBox1"
        Me.groupBox1.Size = New System.Drawing.Size(175, 203)
        Me.groupBox1.TabIndex = 5
        Me.groupBox1.TabStop = False
        Me.groupBox1.Text = "Operations"
        '
        ' buttonClearCellColors
        '
        Me.buttonClearCellColors.Location = New System.Drawing.Point(12, 60)
        Me.buttonClearCellColors.Name = "buttonClearCellColors"
        Me.buttonClearCellColors.Size = New System.Drawing.Size(154, 29)
        Me.buttonClearCellColors.TabIndex = 1
        Me.buttonClearCellColors.Values.DropDownArrowColor = System.Drawing.Color.Empty
        Me.buttonClearCellColors.Values.Text = "Clear Cell Colors"
        '
        ' buttonRandomCellColors
        '
        Me.buttonRandomCellColors.Location = New System.Drawing.Point(13, 26)
        Me.buttonRandomCellColors.Name = "buttonRandomCellColors"
        Me.buttonRandomCellColors.Size = New System.Drawing.Size(153, 29)
        Me.buttonRandomCellColors.TabIndex = 0
        Me.buttonRandomCellColors.Values.DropDownArrowColor = System.Drawing.Color.Empty
        Me.buttonRandomCellColors.Values.Text = "Random Cell Colors"
        '
        ' btnForm2
        '
        Me.btnForm2.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.btnForm2.DialogResult = System.Windows.Forms.DialogResult.Cancel
        Me.btnForm2.Location = New System.Drawing.Point(577, 452)
        Me.btnForm2.Name = "btnForm2"
        Me.btnForm2.Size = New System.Drawing.Size(308, 30)
        Me.btnForm2.TabIndex = 7
        Me.btnForm2.Text = "&Open Programatic Populate"
        Me.btnForm2.UseVisualStyleBackColor = True
        '
        ' kryptonLabel1
        '
        Me.kryptonLabel1.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.kryptonLabel1.Location = New System.Drawing.Point(643, 279)
        Me.kryptonLabel1.Name = "kryptonLabel1"
        Me.kryptonLabel1.Size = New System.Drawing.Size(239, 20)
        Me.kryptonLabel1.TabIndex = 6
        Me.kryptonLabel1.Values.Text = "Right-click grid for Krypton Context Menu"
        '
        ' kryptonDataGridView1
        '
        Me.kryptonDataGridView1.AllowUserToOrderColumns = True
        Me.kryptonDataGridView1.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) Or System.Windows.Forms.AnchorStyles.Left) Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.kryptonDataGridView1.AutoGenerateColumns = False
        Me.kryptonDataGridView1.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill
        Me.kryptonDataGridView1.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.kryptonDataGridView1.ColumnHeadersHeight = 36
        Me.kryptonDataGridView1.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() { Me.colDateTime, Me.colComboBox, Me.colTextBox, Me.colMaskedTextBox, Me.colDomainUpDown, Me.colNumericUpDown, Me.colButton, Me.colCheckBox})
        Me.kryptonDataGridView1.DataMember = "TestData"
        Me.kryptonDataGridView1.DataSource = Me.dataSet
        Me.kryptonDataGridView1.GridStyles.Style = Krypton.Toolkit.DataGridViewStyle.Mixed
        Me.kryptonDataGridView1.KryptonContextMenu = Me.kryptonContextMenu1
        Me.kryptonDataGridView1.Location = New System.Drawing.Point(12, 12)
        Me.kryptonDataGridView1.Name = "kryptonDataGridView1"
        Me.kryptonDataGridView1.RowHeadersWidth = 51
        Me.kryptonDataGridView1.Size = New System.Drawing.Size(870, 252)
        Me.kryptonDataGridView1.TabIndex = 0
        '
        ' kryptonContextMenu1
        '
        Me.kryptonContextMenu1.Items.AddRange(New Krypton.Toolkit.KryptonContextMenuItemBase() { Me.kryptonContextMenuItems1, Me.kryptonContextMenuHeading1, Me.kryptonContextMenuSeparator1, Me.kryptonContextMenuCheckBox1, Me.kryptonContextMenuCheckButton1, Me.kryptonContextMenuRadioButton1, Me.kryptonContextMenuLinkLabel1, Me.kryptonContextMenuColorColumns1, Me.kryptonContextMenuImageSelect1, Me.kryptonContextMenuMonthCalendar1})
        '
        ' kryptonContextMenuRadioButton1
        '
        Me.kryptonContextMenuRadioButton1.LabelStyle = Krypton.Toolkit.LabelStyle.NormalControl
        '
        ' kryptonContextMenuLinkLabel1
        '
        Me.kryptonContextMenuLinkLabel1.LabelStyle = Krypton.Toolkit.LabelStyle.NormalControl
        '
        ' kryptonContextMenuColorColumns1
        '
        Me.kryptonContextMenuColorColumns1.SelectedColor = System.Drawing.Color.Empty
        '
        ' kryptonPalette
        '
        Me.kryptonPalette.GridStyles.GridCustom1.StateCommon.Background.Color1 = System.Drawing.Color.FromArgb(CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer))
        Me.kryptonPalette.GridStyles.GridCustom1.StateCommon.Background.ColorStyle = Krypton.Toolkit.PaletteColorStyle.Solid
        Me.kryptonPalette.GridStyles.GridCustom1.StateCommon.BackStyle = Krypton.Toolkit.PaletteBackStyle.GridBackgroundList
        Me.kryptonPalette.GridStyles.GridCustom1.StateNormal.DataCell.Back.Color1 = System.Drawing.Color.Gray
        Me.kryptonPalette.GridStyles.GridCustom1.StateNormal.DataCell.Border.Color1 = System.Drawing.Color.Black
        Me.kryptonPalette.GridStyles.GridCustom1.StateNormal.DataCell.Border.Color2 = System.Drawing.Color.Black
        Me.kryptonPalette.GridStyles.GridCustom1.StateNormal.DataCell.Border.DrawBorders = CType((((Krypton.Toolkit.PaletteDrawBorders.Top Or Krypton.Toolkit.PaletteDrawBorders.Bottom) Or Krypton.Toolkit.PaletteDrawBorders.Left) Or Krypton.Toolkit.PaletteDrawBorders.Right), Krypton.Toolkit.PaletteDrawBorders)
        Me.kryptonPalette.GridStyles.GridCustom1.StateNormal.DataCell.Content.Color1 = System.Drawing.Color.White
        Me.kryptonPalette.GridStyles.GridCustom1.StateNormal.DataCell.Content.Color2 = System.Drawing.Color.White
        Me.kryptonPalette.GridStyles.GridCustom1.StateNormal.HeaderColumn.Back.Color1 = System.Drawing.Color.FromArgb(CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer))
        Me.kryptonPalette.GridStyles.GridCustom1.StateNormal.HeaderColumn.Back.Color2 = System.Drawing.Color.Silver
        Me.kryptonPalette.GridStyles.GridCustom1.StateNormal.HeaderColumn.Back.ColorStyle = Krypton.Toolkit.PaletteColorStyle.Rounded
        Me.kryptonPalette.GridStyles.GridCustom1.StateNormal.HeaderColumn.Border.Color1 = System.Drawing.Color.Black
        Me.kryptonPalette.GridStyles.GridCustom1.StateNormal.HeaderColumn.Border.Color2 = System.Drawing.Color.Black
        Me.kryptonPalette.GridStyles.GridCustom1.StateNormal.HeaderColumn.Border.DrawBorders = CType((((Krypton.Toolkit.PaletteDrawBorders.Top Or Krypton.Toolkit.PaletteDrawBorders.Bottom) Or Krypton.Toolkit.PaletteDrawBorders.Left) Or Krypton.Toolkit.PaletteDrawBorders.Right), Krypton.Toolkit.PaletteDrawBorders)
        Me.kryptonPalette.GridStyles.GridCustom1.StateNormal.HeaderColumn.Content.Color1 = System.Drawing.Color.Black
        Me.kryptonPalette.GridStyles.GridCustom1.StateNormal.HeaderRow.Back.Color1 = System.Drawing.Color.FromArgb(CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer))
        Me.kryptonPalette.GridStyles.GridCustom1.StateNormal.HeaderRow.Back.Color2 = System.Drawing.Color.Silver
        Me.kryptonPalette.GridStyles.GridCustom1.StateNormal.HeaderRow.Back.ColorStyle = Krypton.Toolkit.PaletteColorStyle.Rounded
        Me.kryptonPalette.GridStyles.GridCustom1.StateNormal.HeaderRow.Border.Color1 = System.Drawing.Color.Black
        Me.kryptonPalette.GridStyles.GridCustom1.StateNormal.HeaderRow.Border.Color2 = System.Drawing.Color.Black
        Me.kryptonPalette.GridStyles.GridCustom1.StateNormal.HeaderRow.Border.DrawBorders = CType((((Krypton.Toolkit.PaletteDrawBorders.Top Or Krypton.Toolkit.PaletteDrawBorders.Bottom) Or Krypton.Toolkit.PaletteDrawBorders.Left) Or Krypton.Toolkit.PaletteDrawBorders.Right), Krypton.Toolkit.PaletteDrawBorders)
        Me.kryptonPalette.GridStyles.GridCustom1.StateNormal.HeaderRow.Content.Color1 = System.Drawing.Color.Black
        Me.kryptonPalette.GridStyles.GridCustom1.StateNormal.HeaderRow.Content.Color2 = System.Drawing.Color.Black
        Me.kryptonPalette.GridStyles.GridCustom1.StatePressed.HeaderColumn.Back.Color1 = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(192, Byte), Integer), CType(CType(128, Byte), Integer))
        Me.kryptonPalette.GridStyles.GridCustom1.StatePressed.HeaderColumn.Back.ColorStyle = Krypton.Toolkit.PaletteColorStyle.Solid
        Me.kryptonPalette.GridStyles.GridCustom1.StatePressed.HeaderColumn.Border.Color1 = System.Drawing.Color.Black
        Me.kryptonPalette.GridStyles.GridCustom1.StatePressed.HeaderColumn.Border.DrawBorders = CType((((Krypton.Toolkit.PaletteDrawBorders.Top Or Krypton.Toolkit.PaletteDrawBorders.Bottom) Or Krypton.Toolkit.PaletteDrawBorders.Left) Or Krypton.Toolkit.PaletteDrawBorders.Right), Krypton.Toolkit.PaletteDrawBorders)
        Me.kryptonPalette.GridStyles.GridCustom1.StatePressed.HeaderColumn.Content.Color1 = System.Drawing.Color.Black
        Me.kryptonPalette.GridStyles.GridCustom1.StatePressed.HeaderRow.Back.Color1 = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(192, Byte), Integer), CType(CType(128, Byte), Integer))
        Me.kryptonPalette.GridStyles.GridCustom1.StatePressed.HeaderRow.Back.ColorStyle = Krypton.Toolkit.PaletteColorStyle.Solid
        Me.kryptonPalette.GridStyles.GridCustom1.StatePressed.HeaderRow.Border.Color1 = System.Drawing.Color.Black
        Me.kryptonPalette.GridStyles.GridCustom1.StatePressed.HeaderRow.Border.DrawBorders = CType((((Krypton.Toolkit.PaletteDrawBorders.Top Or Krypton.Toolkit.PaletteDrawBorders.Bottom) Or Krypton.Toolkit.PaletteDrawBorders.Left) Or Krypton.Toolkit.PaletteDrawBorders.Right), Krypton.Toolkit.PaletteDrawBorders)
        Me.kryptonPalette.GridStyles.GridCustom1.StatePressed.HeaderRow.Content.Color1 = System.Drawing.Color.Black
        Me.kryptonPalette.GridStyles.GridCustom1.StateSelected.DataCell.Back.Color1 = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(224, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.kryptonPalette.GridStyles.GridCustom1.StateSelected.DataCell.Back.Color2 = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(192, Byte), Integer), CType(CType(128, Byte), Integer))
        Me.kryptonPalette.GridStyles.GridCustom1.StateSelected.DataCell.Border.Color1 = System.Drawing.Color.Black
        Me.kryptonPalette.GridStyles.GridCustom1.StateSelected.DataCell.Border.DrawBorders = CType((((Krypton.Toolkit.PaletteDrawBorders.Top Or Krypton.Toolkit.PaletteDrawBorders.Bottom) Or Krypton.Toolkit.PaletteDrawBorders.Left) Or Krypton.Toolkit.PaletteDrawBorders.Right), Krypton.Toolkit.PaletteDrawBorders)
        Me.kryptonPalette.GridStyles.GridCustom1.StateSelected.DataCell.Content.Color1 = System.Drawing.Color.Black
        Me.kryptonPalette.GridStyles.GridCustom1.StateSelected.HeaderColumn.Back.Color1 = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(224, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.kryptonPalette.GridStyles.GridCustom1.StateSelected.HeaderColumn.Back.Color2 = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(128, Byte), Integer), CType(CType(0, Byte), Integer))
        Me.kryptonPalette.GridStyles.GridCustom1.StateSelected.HeaderColumn.Back.ColorStyle = Krypton.Toolkit.PaletteColorStyle.Rounded
        Me.kryptonPalette.GridStyles.GridCustom1.StateSelected.HeaderColumn.Border.Color1 = System.Drawing.Color.Black
        Me.kryptonPalette.GridStyles.GridCustom1.StateSelected.HeaderColumn.Border.DrawBorders = CType((((Krypton.Toolkit.PaletteDrawBorders.Top Or Krypton.Toolkit.PaletteDrawBorders.Bottom) Or Krypton.Toolkit.PaletteDrawBorders.Left) Or Krypton.Toolkit.PaletteDrawBorders.Right), Krypton.Toolkit.PaletteDrawBorders)
        Me.kryptonPalette.GridStyles.GridCustom1.StateSelected.HeaderColumn.Content.Color1 = System.Drawing.Color.Black
        Me.kryptonPalette.GridStyles.GridCustom1.StateSelected.HeaderRow.Back.Color1 = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(224, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.kryptonPalette.GridStyles.GridCustom1.StateSelected.HeaderRow.Back.Color2 = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(192, Byte), Integer), CType(CType(128, Byte), Integer))
        Me.kryptonPalette.GridStyles.GridCustom1.StateSelected.HeaderRow.Back.ColorStyle = Krypton.Toolkit.PaletteColorStyle.Rounded
        Me.kryptonPalette.GridStyles.GridCustom1.StateSelected.HeaderRow.Border.Color1 = System.Drawing.Color.Black
        Me.kryptonPalette.GridStyles.GridCustom1.StateSelected.HeaderRow.Border.DrawBorders = CType((((Krypton.Toolkit.PaletteDrawBorders.Top Or Krypton.Toolkit.PaletteDrawBorders.Bottom) Or Krypton.Toolkit.PaletteDrawBorders.Left) Or Krypton.Toolkit.PaletteDrawBorders.Right), Krypton.Toolkit.PaletteDrawBorders)
        Me.kryptonPalette.GridStyles.GridCustom1.StateSelected.HeaderRow.Content.Color1 = System.Drawing.Color.Black
        Me.kryptonPalette.GridStyles.GridCustom1.StateTracking.HeaderColumn.Back.Color1 = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(224, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.kryptonPalette.GridStyles.GridCustom1.StateTracking.HeaderColumn.Back.Color2 = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(224, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.kryptonPalette.GridStyles.GridCustom1.StateTracking.HeaderColumn.Back.ColorStyle = Krypton.Toolkit.PaletteColorStyle.Solid
        Me.kryptonPalette.GridStyles.GridCustom1.StateTracking.HeaderColumn.Border.Color1 = System.Drawing.Color.Black
        Me.kryptonPalette.GridStyles.GridCustom1.StateTracking.HeaderColumn.Border.DrawBorders = CType((((Krypton.Toolkit.PaletteDrawBorders.Top Or Krypton.Toolkit.PaletteDrawBorders.Bottom) Or Krypton.Toolkit.PaletteDrawBorders.Left) Or Krypton.Toolkit.PaletteDrawBorders.Right), Krypton.Toolkit.PaletteDrawBorders)
        Me.kryptonPalette.GridStyles.GridCustom1.StateTracking.HeaderColumn.Content.Color1 = System.Drawing.Color.Black
        Me.kryptonPalette.GridStyles.GridCustom1.StateTracking.HeaderRow.Back.Color1 = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(224, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.kryptonPalette.GridStyles.GridCustom1.StateTracking.HeaderRow.Back.ColorStyle = Krypton.Toolkit.PaletteColorStyle.Solid
        Me.kryptonPalette.GridStyles.GridCustom1.StateTracking.HeaderRow.Border.Color1 = System.Drawing.Color.Black
        Me.kryptonPalette.GridStyles.GridCustom1.StateTracking.HeaderRow.Border.DrawBorders = CType((((Krypton.Toolkit.PaletteDrawBorders.Top Or Krypton.Toolkit.PaletteDrawBorders.Bottom) Or Krypton.Toolkit.PaletteDrawBorders.Left) Or Krypton.Toolkit.PaletteDrawBorders.Right), Krypton.Toolkit.PaletteDrawBorders)
        Me.kryptonPalette.GridStyles.GridCustom1.StateTracking.HeaderRow.Content.Color1 = System.Drawing.Color.Black
        Me.kryptonPalette.UseThemeFormChromeBorderWidth = Krypton.Toolkit.InheritBool.True
        '
        ' kryptonManager
        '
        Me.kryptonManager.GlobalCustomPalette = Me.kryptonPalette
        Me.kryptonManager.GlobalPaletteMode = Krypton.Toolkit.PaletteMode.Custom
        Me.kryptonManager.ToolkitStrings.MessageBoxStrings.LessDetails = "L&ess Details..."
        Me.kryptonManager.ToolkitStrings.MessageBoxStrings.MoreDetails = "&More Details..."
        '
        ' kryptonThemeListBox1
        '
        Me.kryptonThemeListBox1.Anchor = CType(((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Left) Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.kryptonThemeListBox1.Location = New System.Drawing.Point(290, 279)
        Me.kryptonThemeListBox1.Name = "kryptonThemeListBox1"
        Me.kryptonThemeListBox1.Size = New System.Drawing.Size(281, 203)
        Me.kryptonThemeListBox1.TabIndex = 8
        '
        ' colDateTime
        '
        Me.colDateTime.Checked = False
        Me.colDateTime.CustomFormat = "yyyy-MM-dd"
        Me.colDateTime.DataPropertyName = "DateTime"
        dataGridViewCellStyle1.NullValue = Nothing
        Me.colDateTime.DefaultCellStyle = dataGridViewCellStyle1
        Me.colDateTime.FillWeight = 162.8603!
        Me.colDateTime.Format = System.Windows.Forms.DateTimePickerFormat.Custom
        Me.colDateTime.HeaderText = "DateTime"
        Me.colDateTime.MinimumWidth = 6
        Me.colDateTime.Name = "colDateTime"
        Me.colDateTime.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Automatic
        Me.colDateTime.ToolTipText = "Datetime Tool tip text"
        '
        ' colComboBox
        '
        Me.colComboBox.DataPropertyName = "ComboBox"
        Me.colComboBox.DropDownWidth = 121
        Me.colComboBox.HeaderText = "ComboBox"
        Me.colComboBox.Items.Add("Mr")
        Me.colComboBox.Items.Add("Mrs")
        Me.colComboBox.Items.Add("Miss")
        Me.colComboBox.Items.Add("Ms")
        Me.colComboBox.MinimumWidth = 6
        Me.colComboBox.Name = "colComboBox"
        '
        ' colTextBox
        '
        Me.colTextBox.DataPropertyName = "TextBox"
        Me.colTextBox.DefaultCellStyle.WrapMode = System.Windows.Forms.DataGridViewTriState.True
        Me.colTextBox.HeaderText = "TextBox"
        Me.colTextBox.MinimumWidth = 100
        Me.colTextBox.Multiline = True
        Me.colTextBox.Name = "colTextBox"
        '
        ' colMaskedTextBox
        '
        Me.colMaskedTextBox.DataPropertyName = "MaskedTextBox"
        Me.colMaskedTextBox.HeaderText = "MaskedTextBox"
        Me.colMaskedTextBox.Mask = "(99) 9999-9999"
        Me.colMaskedTextBox.MinimumWidth = 6
        Me.colMaskedTextBox.Name = "colMaskedTextBox"
        '
        ' colDomainUpDown
        '
        Me.colDomainUpDown.DataPropertyName = "DomainUpDown"
        Me.colDomainUpDown.HeaderText = "DomainUpDown"
        Me.colDomainUpDown.Items.AddRange(New String() { "Single", "Married", "Divorced", "Separated"})
        Me.colDomainUpDown.MinimumWidth = 6
        Me.colDomainUpDown.Name = "colDomainUpDown"
        '
        ' colNumericUpDown
        '
        Me.colNumericUpDown.AllowDecimals = False
        Me.colNumericUpDown.DataPropertyName = "NumericUpDown"
        Me.colNumericUpDown.HeaderText = "NumericUpDown"
        Me.colNumericUpDown.MinimumWidth = 6
        Me.colNumericUpDown.Name = "colNumericUpDown"
        '
        ' colButton
        '
        Me.colButton.DataPropertyName = "Button"
        Me.colButton.HeaderText = "Button"
        Me.colButton.MinimumWidth = 6
        Me.colButton.Name = "colButton"
        Me.colButton.Text = "Press!"
        Me.colButton.UseColumnTextForButtonValue = True
        '
        ' colCheckBox
        '
        Me.colCheckBox.DataPropertyName = "CheckBox"
        dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter
        dataGridViewCellStyle2.NullValue = False
        Me.colCheckBox.DefaultCellStyle = dataGridViewCellStyle2
        Me.colCheckBox.FalseValue = Nothing
        Me.colCheckBox.HeaderText = "CheckBox"
        Me.colCheckBox.IndeterminateValue = Nothing
        Me.colCheckBox.MinimumWidth = 6
        Me.colCheckBox.Name = "colCheckBox"
        Me.colCheckBox.TrueValue = Nothing
        '
        ' Form1
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(1238, 505)
        Me.Controls.Add(Me.kryptonThemeListBox1)
        Me.Controls.Add(Me.btnForm2)
        Me.Controls.Add(Me.kryptonLabel1)
        Me.Controls.Add(Me.groupBox1)
        Me.Controls.Add(Me.groupBoxGridStyle)
        Me.Controls.Add(Me.kryptonDataGridView1)
        Me.Controls.Add(Me.groupBox4)
        Me.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.MaximizeBox = False
        Me.MinimizeBox = False
        Me.MinimumSize = New System.Drawing.Size(1254, 544)
        Me.Name = "Form1"
        Me.Text = "KryptonDataGridView Examples"
        Me.groupBox4.ResumeLayout(False)
        CType(Me.dataSet, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.dtTestData, System.ComponentModel.ISupportInitialize).EndInit()
        Me.groupBoxGridStyle.ResumeLayout(False)
        Me.groupBoxGridStyle.PerformLayout()
        Me.groupBox1.ResumeLayout(False)
        CType(Me.kryptonDataGridView1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

#End Region

    Private WithEvents groupBox4 As System.Windows.Forms.GroupBox
    Private WithEvents propertyGrid As System.Windows.Forms.PropertyGrid
    Private WithEvents kryptonDataGridView1 As Krypton.Toolkit.KryptonDataGridView
    Private WithEvents rbStyleList As System.Windows.Forms.RadioButton
    Private WithEvents groupBoxGridStyle As System.Windows.Forms.GroupBox
    Private WithEvents rbStyleCustom As System.Windows.Forms.RadioButton
    Private WithEvents rbStyleSheet As System.Windows.Forms.RadioButton
    Private WithEvents dataSet As System.Data.DataSet
    Private WithEvents dtTestData As System.Data.DataTable
    Private WithEvents kryptonPalette As Krypton.Toolkit.KryptonCustomPaletteBase
    Private WithEvents kryptonManager As Krypton.Toolkit.KryptonManager
    Private WithEvents groupBox1 As System.Windows.Forms.GroupBox
    Private WithEvents buttonRandomCellColors As Krypton.Toolkit.KryptonButton
    Private WithEvents buttonClearCellColors As Krypton.Toolkit.KryptonButton
    Private WithEvents dataDateTime As System.Data.DataColumn
    Private WithEvents dataComboBox As System.Data.DataColumn
    Private WithEvents dataTextBox As System.Data.DataColumn
    Private WithEvents dataMaskedTextBox As System.Data.DataColumn
    Private WithEvents dataDomainUpDown As System.Data.DataColumn
    Private WithEvents dataNumericUpDown As System.Data.DataColumn
    Private WithEvents dataButton As System.Data.DataColumn
    Private WithEvents dataCheckBox As System.Data.DataColumn
    Private WithEvents kryptonContextMenu1 As Krypton.Toolkit.KryptonContextMenu
    Private WithEvents kryptonContextMenuItems1 As Krypton.Toolkit.KryptonContextMenuItems
    Private WithEvents kryptonContextMenuHeading1 As Krypton.Toolkit.KryptonContextMenuHeading
    Private WithEvents kryptonContextMenuSeparator1 As Krypton.Toolkit.KryptonContextMenuSeparator
    Private WithEvents kryptonContextMenuCheckBox1 As Krypton.Toolkit.KryptonContextMenuCheckBox
    Private WithEvents kryptonContextMenuCheckButton1 As Krypton.Toolkit.KryptonContextMenuCheckButton
    Private WithEvents kryptonContextMenuRadioButton1 As Krypton.Toolkit.KryptonContextMenuRadioButton
    Private WithEvents kryptonContextMenuLinkLabel1 As Krypton.Toolkit.KryptonContextMenuLinkLabel
    Private WithEvents kryptonContextMenuColorColumns1 As Krypton.Toolkit.KryptonContextMenuColorColumns
    Private WithEvents kryptonContextMenuImageSelect1 As Krypton.Toolkit.KryptonContextMenuImageSelect
    Private WithEvents kryptonContextMenuMonthCalendar1 As Krypton.Toolkit.KryptonContextMenuMonthCalendar
    Private WithEvents kryptonLabel1 As Krypton.Toolkit.KryptonLabel
    Private WithEvents btnForm2 As System.Windows.Forms.Button
    Private WithEvents kryptonThemeListBox1 As Krypton.Toolkit.KryptonThemeListBox
    Private WithEvents colDateTime As Krypton.Toolkit.KryptonDataGridViewDateTimePickerColumn
    Private WithEvents colComboBox As Krypton.Toolkit.KryptonDataGridViewComboBoxColumn
    Private WithEvents colTextBox As Krypton.Toolkit.KryptonDataGridViewTextBoxColumn
    Private WithEvents colMaskedTextBox As Krypton.Toolkit.KryptonDataGridViewMaskedTextBoxColumn
    Private WithEvents colDomainUpDown As Krypton.Toolkit.KryptonDataGridViewDomainUpDownColumn
    Private WithEvents colNumericUpDown As Krypton.Toolkit.KryptonDataGridViewNumericUpDownColumn
    Private WithEvents colButton As Krypton.Toolkit.KryptonDataGridViewButtonColumn
    Private WithEvents colCheckBox As Krypton.Toolkit.KryptonDataGridViewCheckBoxColumn

End Class
