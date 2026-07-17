' Original BSD 3-Clause License (https://github.com/ComponentFactory/Krypton/blob/master/LICENSE)
' © Component Factory Pty Ltd, 2006 - 2016, (Version 4.5.0.0) All rights reserved.
'
' New BSD 3-Clause License (https://github.com/Krypton-Suite/Standard-Toolkit/blob/master/LICENSE)
' Modifications by Peter Wagner(aka Wagnerp) & Simon Coghlan(aka Smurf-IV), tobitege et al. 2017 - 2025. All rights reserved.
'
' VB.NET twin of Source\Krypton Toolkit Examples\KryptonDataGridView Examples\Form1.cs (Bastion Phase 4c).

Imports System.ComponentModel
Imports System.Drawing
Imports System.Windows.Forms

Imports Krypton.Toolkit

Public Class Form1

    Public Sub New()
        InitializeComponent()
    End Sub

    Private Sub Form1_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        kryptonDataGridView1.BorderStyle = BorderStyle.Fixed3D
        For Each column As DataGridViewColumn In kryptonDataGridView1.Columns
            column.SortMode = DataGridViewColumnSortMode.Automatic
        Next
        ' Create richer test data for display
        dtTestData.Rows.Clear()

        Dim rand As New Random()
        Dim titles = {"Mr", "Mrs", "Miss", "Ms"}
        Dim statuses = {"Single", "Married", "Divorced", "Separated"}
        Dim firstNames = {"Mark", "Mary", "Mandy", "Mercy", "Michael", "Marge", "Alex", "Jordan", "Taylor", "Sam", "Chris", "Pat", "Morgan", "Jamie", "Robin", "Avery", "Casey", "Drew", "Elliot", "Harper", "Riley", "Quinn", "Skyler", "Cameron", "Logan", "Parker", "Reese", "Rowan", "Sage", "Dakota"}
        Dim lastNames = {"Smith", "Johnson", "Williams", "Brown", "Jones", "Miller", "Davis", "Wilson", "Moore", "Taylor", "Anderson", "Thomas", "Jackson", "White", "Harris", "Martin", "Thompson", "Garcia", "Martinez", "Robinson", "Clark", "Rodriguez", "Lewis", "Lee", "Walker", "Hall", "Allen", "Young", "King", "Wright"}

        For i As Integer = 0 To 499
            Dim [date] As DateTime = DateTime.Now.Date.AddDays(rand.Next(-365, 366))
            Dim title As String = titles(rand.Next(titles.Length))
            Dim first As String = firstNames(rand.Next(firstNames.Length))
            Dim last As String = lastNames(rand.Next(lastNames.Length))
            Dim name As String = $"{first} {last}"

            ' Add some multi-line and long-text variations
            If i Mod 50 = 0 Then
                name = $"{first}{vbCrLf}Single{vbCrLf}Married"
            ElseIf i Mod 33 = 0 Then
                name = $"{first} has a really long name normally, and this should wrap around the cell to demonstrate multiline behavior"
            End If

            Dim phone As String = $"({rand.Next(1, 100):00}) {rand.Next(0, 10000):0000}-{rand.Next(0, 10000):0000}"
            Dim status As String = statuses(rand.Next(statuses.Length))
            Dim age As Integer = rand.Next(18, 90)
            Dim flag As Boolean = rand.Next(2) = 0

            dtTestData.Rows.Add([date], title, name, phone, status, age, "Press!", flag)
        Next

        ' Show selected data grid properties in the property grid
        propertyGrid.SelectedObject = New KryptonDataGridViewProxy(kryptonDataGridView1)
    End Sub

    Private Sub rbStyleList_CheckedChanged(sender As Object, e As EventArgs) Handles rbStyleList.CheckedChanged
        kryptonDataGridView1.GridStyles.Style = DataGridViewStyle.List
    End Sub

    Private Sub rbStyleSheet_CheckedChanged(sender As Object, e As EventArgs) Handles rbStyleSheet.CheckedChanged
        kryptonDataGridView1.GridStyles.Style = DataGridViewStyle.Sheet
    End Sub

    Private Sub rbStyleCustom_CheckedChanged(sender As Object, e As EventArgs) Handles rbStyleCustom.CheckedChanged
        kryptonDataGridView1.GridStyles.Style = DataGridViewStyle.Custom1
    End Sub

    Private Sub buttonRandomCellColors_Click(sender As Object, e As EventArgs) Handles buttonRandomCellColors.Click
        Dim rand As New Random()
        For i As Integer = 0 To kryptonDataGridView1.Rows.Count - 1
            For j As Integer = 0 To kryptonDataGridView1.ColumnCount - 1
                Dim foreColor As Color = Color.FromArgb(rand.Next(256), rand.Next(256), rand.Next(256))
                Dim backColor As Color = Color.FromArgb(rand.Next(256), rand.Next(256), rand.Next(256))

                kryptonDataGridView1.Rows(i).Cells(j).Style.BackColor = foreColor
                kryptonDataGridView1.Rows(i).Cells(j).Style.ForeColor = backColor
            Next
        Next
    End Sub

    Private Sub buttonClearCellColors_Click(sender As Object, e As EventArgs) Handles buttonClearCellColors.Click
        For i As Integer = 0 To kryptonDataGridView1.Rows.Count - 1
            For j As Integer = 0 To kryptonDataGridView1.ColumnCount - 1
                kryptonDataGridView1.Rows(i).Cells(j).Style.BackColor = Color.Empty
                kryptonDataGridView1.Rows(i).Cells(j).Style.ForeColor = Color.Empty
            Next
        Next
    End Sub

    Private Sub BtnForm2_Click(sender As Object, e As EventArgs) Handles btnForm2.Click
        Using dlg As New Form2()
            dlg.ShowDialog(Me)
        End Using
    End Sub

    Private Sub kryptonDataGridView1_CellToolTipTextNeeded(sender As Object, e As DataGridViewCellToolTipTextNeededEventArgs) Handles kryptonDataGridView1.CellToolTipTextNeeded
        ' intentionally empty
    End Sub

    Private Shared Function Format(value As Object) As String
        Return If(value Is Nothing OrElse TypeOf value Is DBNull, String.Empty, If(Convert.ToString(value), String.Empty))
    End Function

    Private Sub kryptonDataGridView1_CellContentClick(sender As Object, e As DataGridViewCellEventArgs) Handles kryptonDataGridView1.CellContentClick
        If e.RowIndex < 0 OrElse kryptonDataGridView1.Columns(e.ColumnIndex) IsNot colButton Then
            Return
        End If

        Dim row = kryptonDataGridView1.Rows(e.RowIndex)

        Dim dateValue As Object = row.Cells(colDateTime.Index).Value
        Dim dateText As String = If(TypeOf dateValue Is DateTime, CType(dateValue, DateTime).ToShortDateString(), Format(dateValue))
        Dim title As String = Format(row.Cells(colComboBox.Index).Value)
        Dim name As String = Format(row.Cells(colTextBox.Index).Value)
        Dim phone As String = Format(row.Cells(colMaskedTextBox.Index).Value)
        Dim status As String = Format(row.Cells(colDomainUpDown.Index).Value)
        Dim ageText As String = Format(row.Cells(colNumericUpDown.Index).Value)

        Dim flagValue As Object = row.Cells(colCheckBox.Index).Value
        Dim flagText As String
        If TypeOf flagValue Is Boolean Then
            flagText = If(CBool(flagValue), "Yes", "No")
        Else
            flagText = If(String.IsNullOrWhiteSpace(Format(flagValue)), "No", Format(flagValue))
        End If

        Dim mainInstruction As String = If(String.IsNullOrWhiteSpace(name),
            "Person Details",
            $"{title} {name}".Trim())

        Dim content As String =
            $"Date: {dateText}" & vbCrLf &
            $"Phone: {phone}" & vbCrLf &
            $"Status: {status}" & vbCrLf &
            $"Age: {ageText}" & vbCrLf &
            $"Subscribed: {flagText}"

        ' Bastion: ported to the element-based KryptonTaskDialog API of the current core toolkit.
        Using dialog As New KryptonTaskDialog()
            dialog.Dialog.Form.Text = "Info Card"
            dialog.Heading.Text = mainInstruction
            dialog.Heading.IconType = KryptonTaskDialogIconType.ShieldInformation
            dialog.Heading.Visible = True
            dialog.Content.Text = content
            dialog.Content.Visible = True
            dialog.FooterBar.CommonButtons.Buttons = KryptonTaskDialogCommonButtonTypes.OK
            dialog.FooterBar.CommonButtons.AcceptButton = KryptonTaskDialogCommonButtonTypes.OK
            dialog.FooterBar.Visible = True
            dialog.ShowDialog(Me)
        End Using
    End Sub

End Class

Public Class KryptonDataGridViewProxy

    Private _grid As KryptonDataGridView

    Public Sub New(grid As KryptonDataGridView)
        _grid = grid
    End Sub

    <Category("Appearance")>
    <Description("The height, in pixels, of the column headers row.")>
    Public Property ColumnHeadersHeight() As Integer
        Get
            Return _grid.ColumnHeadersHeight
        End Get
        Set(value As Integer)
            _grid.ColumnHeadersHeight = value
        End Set
    End Property

    <Category("Appearance")>
    <Description("Indicates whether the column headers row is displayed.")>
    Public Property ColumnHeadersVisible() As Boolean
        Get
            Return _grid.ColumnHeadersVisible
        End Get
        Set(value As Boolean)
            _grid.ColumnHeadersVisible = value
        End Set
    End Property

    <Category("Appearance")>
    <Description("Indicates whether the column that contains row headers is displayed.")>
    Public Property RowHeadersVisible() As Boolean
        Get
            Return _grid.RowHeadersVisible
        End Get
        Set(value As Boolean)
            _grid.RowHeadersVisible = value
        End Set
    End Property

    <Category("Appearance")>
    <Description("Indicates whether to show cell errors.")>
    Public Property ShowCellErrors() As Boolean
        Get
            Return _grid.ShowCellErrors
        End Get
        Set(value As Boolean)
            _grid.ShowCellErrors = value
        End Set
    End Property

    <Category("Appearance")>
    <Description("Indicates whether or not ToolTips will show when the mouse pointer pauses on a cell.")>
    Public Property ShowCellToolTips() As Boolean
        Get
            Return _grid.ShowCellToolTips
        End Get
        Set(value As Boolean)
            _grid.ShowCellToolTips = value
        End Set
    End Property

    <Category("Appearance")>
    <Description("Indicates whether or not the editing glyph is visible in the row header of the cell being edited.")>
    Public Property ShowEditingIcon() As Boolean
        Get
            Return _grid.ShowEditingIcon
        End Get
        Set(value As Boolean)
            _grid.ShowEditingIcon = value
        End Set
    End Property

    <Category("Appearance")>
    <Description("Indicates whether row headers will display error glyphs for each row that contains a data entry error.")>
    Public Property ShowRowErrors() As Boolean
        Get
            Return _grid.ShowRowErrors
        End Get
        Set(value As Boolean)
            _grid.ShowRowErrors = value
        End Set
    End Property

    <Category("Behavior")>
    <Description("Indicates whether the option to add rows is displayed to the user.")>
    Public Property AllowUserToAddRows() As Boolean
        Get
            Return _grid.AllowUserToAddRows
        End Get
        Set(value As Boolean)
            _grid.AllowUserToAddRows = value
        End Set
    End Property

    <Category("Behavior")>
    <Description("Indicates whether the user is allowed to delete rows from the DataGridView.")>
    Public Property AllowUserToDeleteRows() As Boolean
        Get
            Return _grid.AllowUserToDeleteRows
        End Get
        Set(value As Boolean)
            _grid.AllowUserToDeleteRows = value
        End Set
    End Property

    <Category("Behavior")>
    <Description("Indicates whether manual column repositioning is enabled.")>
    Public Property AllowUserToOrderColumns() As Boolean
        Get
            Return _grid.AllowUserToOrderColumns
        End Get
        Set(value As Boolean)
            _grid.AllowUserToOrderColumns = value
        End Set
    End Property

    <Category("Behavior")>
    <Description("Indicates whether users can resize columns.")>
    Public Property AllowUserToResizeColumns() As Boolean
        Get
            Return _grid.AllowUserToResizeColumns
        End Get
        Set(value As Boolean)
            _grid.AllowUserToResizeColumns = value
        End Set
    End Property

    <Category("Behavior")>
    <Description("Indicates whether users can resize rows.")>
    Public Property AllowUserToResizeRows() As Boolean
        Get
            Return _grid.AllowUserToResizeRows
        End Get
        Set(value As Boolean)
            _grid.AllowUserToResizeRows = value
        End Set
    End Property

    <Category("Behavior")>
    <Description("Determines the behavior for adjusting the column headers height.")>
    Public Property ColumnHeadersHeightSizeMode() As DataGridViewColumnHeadersHeightSizeMode
        Get
            Return _grid.ColumnHeadersHeightSizeMode
        End Get
        Set(value As DataGridViewColumnHeadersHeightSizeMode)
            _grid.ColumnHeadersHeightSizeMode = value
        End Set
    End Property

    <Category("Behavior")>
    <Description("Identifies the mode that determines the cell editing is started.")>
    Public Property EditMode() As DataGridViewEditMode
        Get
            Return _grid.EditMode
        End Get
        Set(value As DataGridViewEditMode)
            _grid.EditMode = value
        End Set
    End Property

    <Category("Behavior")>
    <Description("Indicates whether the user is allowed to selected more than one cell, row or column of hte DataGridView at a time.")>
    Public Property MultiSelect() As Boolean
        Get
            Return _grid.MultiSelect
        End Get
        Set(value As Boolean)
            _grid.MultiSelect = value
        End Set
    End Property

    <Category("Behavior")>
    <Description("Indicates whether the user can edit the cells of the DataGridView control.")>
    Public Property [ReadOnly]() As Boolean
        Get
            Return _grid.ReadOnly
        End Get
        Set(value As Boolean)
            _grid.ReadOnly = value
        End Set
    End Property

    <Category("Behavior")>
    <Description("Determine the behavior for adjusting the row headers width.")>
    Public Property RowHeadersWidthSizeMode() As DataGridViewRowHeadersWidthSizeMode
        Get
            Return _grid.RowHeadersWidthSizeMode
        End Get
        Set(value As DataGridViewRowHeadersWidthSizeMode)
            _grid.RowHeadersWidthSizeMode = value
        End Set
    End Property

    <Category("Behavior")>
    <Description("Indicates how the cells of the DataGridView can be selected.")>
    Public Property SelectionMode() As DataGridViewSelectionMode
        Get
            Return _grid.SelectionMode
        End Get
        Set(value As DataGridViewSelectionMode)
            _grid.SelectionMode = value
        End Set
    End Property

    <Category("Behavior")>
    <Description("Indicates whether the TAB key moves the focus to the next control in the tab order rather than moving focus to the next cell in the control.")>
    Public Property StandardTab() As Boolean
        Get
            Return _grid.StandardTab
        End Get
        Set(value As Boolean)
            _grid.StandardTab = value
        End Set
    End Property

    <Category("Layout")>
    <Description("Determines the auto size mode for the visible columns.")>
    Public Property AutoSizeColumnsMode() As DataGridViewAutoSizeColumnsMode
        Get
            Return _grid.AutoSizeColumnsMode
        End Get
        Set(value As DataGridViewAutoSizeColumnsMode)
            _grid.AutoSizeColumnsMode = value
        End Set
    End Property

    <Category("Layout")>
    <Description("Determines the auto size mode for the visible rows.")>
    Public Property AutoSizeRowsMode() As DataGridViewAutoSizeRowsMode
        Get
            Return _grid.AutoSizeRowsMode
        End Get
        Set(value As DataGridViewAutoSizeRowsMode)
            _grid.AutoSizeRowsMode = value
        End Set
    End Property

    <Category("Layout")>
    <Description("The width, in pixels, of the column that contains the row headers.")>
    Public Property RowHeadersWidth() As Integer
        Get
            Return _grid.RowHeadersWidth
        End Get
        Set(value As Integer)
            _grid.RowHeadersWidth = value
        End Set
    End Property

    <Category("Layout")>
    <Description("The type of scrollbars to display.")>
    Public Property ScrollBars() As ScrollBars
        Get
            Return _grid.ScrollBars
        End Get
        Set(value As ScrollBars)
            _grid.ScrollBars = value
        End Set
    End Property

    <Category("Visuals")>
    <Description("Determine if the outer borders of the grid cells are drawn.")>
    Public Property HideOuterBorders() As Boolean
        Get
            Return _grid.HideOuterBorders
        End Get
        Set(value As Boolean)
            _grid.HideOuterBorders = value
        End Set
    End Property

    <Category("Visuals")>
    <Description("Overrides for defining common data grid view appearance that other states can override.")>
    Public ReadOnly Property StateCommon() As PaletteDataGridViewRedirect
        Get
            Return _grid.StateCommon
        End Get
    End Property

    <Category("Visuals")>
    <Description("Overrides for defining disabled data grid view appearance.")>
    Public ReadOnly Property StateDisabled() As PaletteDataGridViewAll
        Get
            Return _grid.StateDisabled
        End Get
    End Property

    <Category("Visuals")>
    <Description("Overrides for defining normal data grid view appearance.")>
    Public ReadOnly Property StateNormal() As PaletteDataGridViewAll
        Get
            Return _grid.StateNormal
        End Get
    End Property

    <Category("Visuals")>
    <Description("Overrides for defining tracking data grid view appearance.")>
    Public ReadOnly Property StateTracking() As PaletteDataGridViewHeaders
        Get
            Return _grid.StateTracking
        End Get
    End Property

    <Category("Visuals")>
    <Description("Overrides for defining pressed data grid view appearance.")>
    Public ReadOnly Property StatePressed() As PaletteDataGridViewHeaders
        Get
            Return _grid.StatePressed
        End Get
    End Property

    <Category("Visuals")>
    <Description("Overrides for defining selected data grid view appearance.")>
    Public ReadOnly Property StateSelected() As PaletteDataGridViewCells
        Get
            Return _grid.StateSelected
        End Get
    End Property

    <Category("Visuals")>
    <Description("Set of grid styles.")>
    Public ReadOnly Property GridStyles() As DataGridViewStyles
        Get
            Return _grid.GridStyles
        End Get
    End Property

    <Category("Visuals")>
    <Description("Palette applied to drawing.")>
    Public Property PaletteMode() As PaletteMode
        Get
            Return _grid.PaletteMode
        End Get
        Set(value As PaletteMode)
            _grid.PaletteMode = value
        End Set
    End Property

    <Category("Layout")>
    <Description("The size of the control is pixels.")>
    Public Property Size() As Size
        Get
            Return _grid.Size
        End Get
        Set(value As Size)
            _grid.Size = value
        End Set
    End Property

    <Category("Layout")>
    <Description("The location of the control in pixels.")>
    Public Property Location() As Point
        Get
            Return _grid.Location
        End Get
        Set(value As Point)
            _grid.Location = value
        End Set
    End Property

    <Category("Behavior")>
    <Description("Indicates whether the control is enabled.")>
    Public Property Enabled() As Boolean
        Get
            Return _grid.Enabled
        End Get
        Set(value As Boolean)
            _grid.Enabled = value
        End Set
    End Property

End Class
