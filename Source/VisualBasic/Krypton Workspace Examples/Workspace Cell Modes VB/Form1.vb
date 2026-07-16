#Region "BSD License"
'
' Original BSD 3-Clause License (https://github.com/ComponentFactory/Krypton/blob/master/LICENSE)
'  © Component Factory Pty Ltd, 2006 - 2016, (Version 4.5.0.0) All rights reserved.
'
'  New BSD 3-Clause License (https://github.com/Krypton-Suite/Standard-Toolkit/blob/master/LICENSE)
'  Modifications by Peter Wagner(aka Wagnerp) & Simon Coghlan(aka Smurf-IV), et al. 2017 - 2024. All rights reserved.
'
' VB.NET twin of Source\Krypton Workspace Examples\Workspace Cell Modes\Form1.cs (Bastion Phase 4c).
#End Region

Imports System
Imports System.Drawing
Imports System.Windows.Forms

Imports Krypton.Navigator
Imports Krypton.Toolkit
Imports Krypton.Workspace

Public Class Form1

    Private _count As Integer = 1
    Private _mode As NavigatorMode = NavigatorMode.BarTabGroup

    Private Sub Form1_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        ' Create three cells that each contain two pages
        Dim cell1 = New KryptonWorkspaceCell()
        Dim cell2 = New KryptonWorkspaceCell()
        Dim cell3 = New KryptonWorkspaceCell()
        cell1.Pages.AddRange(New KryptonPage() {CreatePage(), CreatePage()})
        cell2.Pages.AddRange(New KryptonPage() {CreatePage(), CreatePage()})
        cell3.Pages.AddRange(New KryptonPage() {CreatePage(), CreatePage()})

        ' Create a vertical sequence that contains two of the pages
        Dim sequence = New KryptonWorkspaceSequence(Orientation.Vertical)
        sequence.Children.AddRange(New KryptonWorkspaceCell() {cell2, cell3})

        ' Remove starting contents and add a cell with a sequence
        kryptonWorkspace.Root.Children.Clear()
        kryptonWorkspace.Root.Children.Add(cell1)
        kryptonWorkspace.Root.Children.Add(sequence)
    End Sub

    Private Sub radioMode_CheckedChanged(sender As Object, e As EventArgs) Handles radioOutlookMini.CheckedChanged,
        radioBarRibbonTabGroup.CheckedChanged, radioBarTabGroup.CheckedChanged,
        radioHeaderBarCheckButtonHeaderGroup.CheckedChanged, radioHeaderBarCheckButtonGroup.CheckedChanged,
        radioStackCheckButtonHeaderGroup.CheckedChanged, radioStackCheckButtonGroup.CheckedChanged,
        radioOutlookFull.CheckedChanged, radioPanel.CheckedChanged, radioGroup.CheckedChanged,
        radioHeaderGroup.CheckedChanged, radioBarCheckButtonGroupInside.CheckedChanged,
        radioBarCheckButtonGroupOutside.CheckedChanged

        Dim mode As NavigatorMode = _mode

        ' Work out the new mode we want
        If radioBarTabGroup.Checked Then
            mode = NavigatorMode.BarTabGroup
        ElseIf radioBarRibbonTabGroup.Checked Then
            mode = NavigatorMode.BarRibbonTabGroup
        ElseIf radioBarCheckButtonGroupInside.Checked Then
            mode = NavigatorMode.BarCheckButtonGroupInside
        ElseIf radioBarCheckButtonGroupOutside.Checked Then
            mode = NavigatorMode.BarCheckButtonGroupOutside
        ElseIf radioHeaderBarCheckButtonGroup.Checked Then
            mode = NavigatorMode.HeaderBarCheckButtonGroup
        ElseIf radioHeaderBarCheckButtonHeaderGroup.Checked Then
            mode = NavigatorMode.HeaderBarCheckButtonHeaderGroup
        ElseIf radioStackCheckButtonGroup.Checked Then
            mode = NavigatorMode.StackCheckButtonGroup
        ElseIf radioStackCheckButtonHeaderGroup.Checked Then
            mode = NavigatorMode.StackCheckButtonHeaderGroup
        ElseIf radioOutlookFull.Checked Then
            mode = NavigatorMode.OutlookFull
        ElseIf radioOutlookMini.Checked Then
            mode = NavigatorMode.OutlookMini
        ElseIf radioHeaderGroup.Checked Then
            mode = NavigatorMode.HeaderGroup
        ElseIf radioGroup.Checked Then
            mode = NavigatorMode.Group
        ElseIf radioPanel.Checked Then
            mode = NavigatorMode.Panel
        End If

        UpdateCellMode(mode)
    End Sub

    Private Sub UpdateCellMode(mode As NavigatorMode)
        ' Cache new mode
        _mode = mode

        ' Update all existing cells with new mode
        Dim cell As KryptonWorkspaceCell = kryptonWorkspace.FirstCell()
        While cell IsNot Nothing
            cell.NavigatorMode = _mode
            cell = kryptonWorkspace.NextCell(cell)
        End While
    End Sub

    Private Sub kryptonWorkspace_WorkspaceCellAdding(sender As Object, e As WorkspaceCellEventArgs) Handles kryptonWorkspace.WorkspaceCellAdding
        ' Set the initial mode to match the radio button selection
        e.Cell.NavigatorMode = _mode
    End Sub

    Private Sub buttonAddPage_Click(sender As Object, e As EventArgs) Handles buttonAddPage.Click
        ' Add page to the currently active cell
        If kryptonWorkspace.ActiveCell IsNot Nothing Then
            kryptonWorkspace.ActiveCell.Pages.Add(CreatePage())
            kryptonWorkspace.ActiveCell.SelectedIndex = kryptonWorkspace.ActiveCell.Pages.Count - 1
        End If
    End Sub

    Private Sub buttonClearPages_Click(sender As Object, e As EventArgs) Handles buttonClearPages.Click
        kryptonWorkspace.Root.Children.Clear()
    End Sub

    Private Sub buttonClose_Click(sender As Object, e As EventArgs) Handles buttonClose.Click
        Close()
    End Sub

    Private Function CreatePage() As KryptonPage
        ' Give each page a unique number
        Dim pageNumber = _count.ToString()
        _count += 1

        ' Create a new page and give it a name and image
        Dim page = New KryptonPage()
        page.Text = $"P{pageNumber}"
        page.TextTitle = $"P{pageNumber} Title"
        page.TextDescription = $"P{pageNumber} Description"
        page.ImageSmall = CType(imageList.Images(_count Mod imageList.Images.Count), Bitmap)
        page.MinimumSize = New Size(200, 250)

        ' Create a rich text box with some sample text inside
        Dim rtb = New KryptonRichTextBox()
        rtb.Text =
            $"This page ({page.Text}) contains a rich text box control as example content. Your application could place anything you like here such as data entry controls, charts, data grids etc." & vbLf & vbLf & "Try dragging the page headers in order to rearrange the workspace layout."
        rtb.Dock = DockStyle.Fill
        rtb.StateCommon.Border.Draw = InheritBool.False

        ' Add rich text box as the contents of the page
        page.Padding = New Padding(5)
        page.Controls.Add(rtb)

        Return page
    End Function

End Class
