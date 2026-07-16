#Region "BSD License"
'
' Original BSD 3-Clause License (https://github.com/ComponentFactory/Krypton/blob/master/LICENSE)
'  © Component Factory Pty Ltd, 2006 - 2016, (Version 4.5.0.0) All rights reserved.
'
'  New BSD 3-Clause License (https://github.com/Krypton-Suite/Standard-Toolkit/blob/master/LICENSE)
'  Modifications by Peter Wagner(aka Wagnerp) & Simon Coghlan(aka Smurf-IV), et al. 2017 - 2024. All rights reserved.
'
' VB.NET twin of Source\Krypton Workspace Examples\Workspace Cell Layout\Form1.cs (Bastion Phase 4c).
#End Region

Imports System
Imports System.Drawing
Imports System.Windows.Forms

Imports Krypton.Navigator
Imports Krypton.Toolkit
Imports Krypton.Workspace

Public Class Form1

    Private _count As Integer = 1

    Private Sub Form1_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        ' Initial appearance is same as clicking the 'New Three Cells' button
        buttonNewThreeCells_Click(buttonNewThreeCells, e)
    End Sub

    Private Sub kryptonWorkspace_WorkspaceCellAdding(sender As Object, e As WorkspaceCellEventArgs) Handles kryptonWorkspace.WorkspaceCellAdding
        ' Remove the context menu from the tabs bar, as it is not relevant to this sample
        e.Cell.Button.ContextButtonDisplay = ButtonDisplay.Hide
    End Sub

    Private Sub buttonNewSingleCell_Click(sender As Object, e As EventArgs) Handles buttonNewSingleCell.Click
        ' Remove all existing workspace content
        kryptonWorkspace.Root.Children.Clear()

        ' Add a single cell that has three pages
        kryptonWorkspace.Root.Children.Add(CreateCell(6))
    End Sub

    Private Sub buttonNewThreeCells_Click(sender As Object, e As EventArgs) Handles buttonNewThreeCells.Click
        ' Remove all existing workspace content
        kryptonWorkspace.Root.Children.Clear()

        ' Add three cells that have two pages each
        kryptonWorkspace.Root.Children.Add(CreateCell(2))
        kryptonWorkspace.Root.Children.Add(CreateCell(2))
        kryptonWorkspace.Root.Children.Add(CreateCell(2))

        ' We want the root cells to be layed out horizontally
        kryptonWorkspace.Root.Orientation = Orientation.Horizontal
    End Sub

    Private Sub buttonNewSequences_Click(sender As Object, e As EventArgs) Handles buttonNewSequences.Click
        ' Remove all existing workspace content
        kryptonWorkspace.Root.Children.Clear()

        ' Create a horizontal sequence with two cells
        Dim sequence2 = New KryptonWorkspaceSequence(Orientation.Horizontal)
        sequence2.Children.Add(CreateCell())
        sequence2.Children.Add(CreateCell())
        sequence2.Children.Add(CreateCell())

        ' Create a vertical sequence with two cells and the horizontal sequence
        Dim sequence1 = New KryptonWorkspaceSequence(Orientation.Vertical)
        sequence1.Children.Add(CreateCell(2, "25*,25*"))
        sequence1.Children.Add(CreateCell(2, "25*,25*"))
        sequence1.Children.Add(sequence2)

        ' Root contains two cells and the vertical sequence
        kryptonWorkspace.Root.Children.Add(CreateCell(1, "25*,25*"))
        kryptonWorkspace.Root.Children.Add(CreateCell(1, "25*,25*"))
        kryptonWorkspace.Root.Children.Add(sequence1)

        ' We want the root cells to be layed out horizontally
        kryptonWorkspace.Root.Orientation = Orientation.Horizontal
    End Sub

    Private Sub buttonApplySingleCell_Click(sender As Object, e As EventArgs) Handles buttonApplySingleCell.Click
        ' Move all pages into a single cell
        kryptonWorkspace.ApplySingleCell()
    End Sub

    Private Sub buttonApplySingleRow_Click(sender As Object, e As EventArgs) Handles buttonApplySingleRow.Click
        kryptonWorkspace.ApplyGridPages(False, Orientation.Horizontal, 1)
    End Sub

    Private Sub buttonApplySingleColumn_Click(sender As Object, e As EventArgs) Handles buttonApplySingleColumn.Click
        kryptonWorkspace.ApplyGridPages(False, Orientation.Vertical, 1)
    End Sub

    Private Sub buttonApplyGrid_Click(sender As Object, e As EventArgs) Handles buttonApplyGrid.Click
        ' Create a grid with one cell per page
        kryptonWorkspace.ApplyGridPages()
    End Sub

    Private Sub buttonAddPage_Click(sender As Object, e As EventArgs) Handles buttonAddPage.Click
        ' Add page to the currently active cell
        If kryptonWorkspace.ActiveCell IsNot Nothing Then
            kryptonWorkspace.ActiveCell.Pages.Add(CreatePage())
            kryptonWorkspace.ActiveCell.SelectedIndex = kryptonWorkspace.ActiveCell.Pages.Count - 1
        End If
    End Sub

    Private Sub buttonClear_Click(sender As Object, e As EventArgs) Handles buttonClear.Click
        ' Remove everything from the workspace
        kryptonWorkspace.Root.Children.Clear()
    End Sub

    Private Sub buttonClose_Click(sender As Object, e As EventArgs) Handles buttonClose.Click
        Close()
    End Sub

    Private Function CreateCell() As KryptonWorkspaceCell
        Return CreateCell(1)
    End Function

    Private Function CreateCell(numPages As Integer) As KryptonWorkspaceCell
        Return CreateCell(numPages, String.Empty)
    End Function

    Private Function CreateCell(numPages As Integer, starSize As String) As KryptonWorkspaceCell
        ' Create new cell instance
        Dim cell = New KryptonWorkspaceCell()

        ' Do we need to set the star sizing value?
        If Not String.IsNullOrEmpty(starSize) Then
            cell.StarSize = starSize
        End If

        ' Add requested number of pages
        For i = 0 To numPages - 1
            cell.Pages.Add(CreatePage())
        Next

        Return cell
    End Function

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

    Private Sub button1_Click(sender As Object, e As EventArgs)
        ' Create a grid with one cell per page
        ' NOTE: mirrors the upstream demo, where this handler is not wired to any control.
        kryptonWorkspace.ApplyGridPages(True, Orientation.Horizontal)
    End Sub

End Class
