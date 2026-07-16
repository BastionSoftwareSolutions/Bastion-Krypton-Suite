#Region "BSD License"
'
' Original BSD 3-Clause License (https://github.com/ComponentFactory/Krypton/blob/master/LICENSE)
'  © Component Factory Pty Ltd, 2006 - 2016, (Version 4.5.0.0) All rights reserved.
'
'  New BSD 3-Clause License (https://github.com/Krypton-Suite/Standard-Toolkit/blob/master/LICENSE)
'  Modifications by Peter Wagner(aka Wagnerp) & Simon Coghlan(aka Smurf-IV), et al. 2017 - 2024. All rights reserved.
'
' VB.NET twin of Source\Krypton Workspace Examples\Workspace Persistence\Form1.cs (Bastion Phase 4c).
#End Region

Imports System
Imports System.Drawing
Imports System.Windows.Forms

Imports Krypton.Navigator
Imports Krypton.Toolkit
Imports Krypton.Workspace

Public Class Form1

    Private _count As Integer = 1
    Private _byteArray As Byte()

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

    Private Sub bSaveToArray_Click(sender As Object, e As EventArgs) Handles bSaveToArray.Click
        _byteArray = kryptonWorkspace.SaveLayoutToArray()
        bLoadFromArray.Enabled = True
    End Sub

    Private Sub bLoadFromArray_Click(sender As Object, e As EventArgs) Handles bLoadFromArray.Click
        kryptonWorkspace.LoadLayoutFromArray(_byteArray)
    End Sub

    Private Sub bSaveToFile_Click(sender As Object, e As EventArgs) Handles bSaveToFile.Click
        If saveFileDialog.ShowDialog() = DialogResult.OK Then
            kryptonWorkspace.SaveLayoutToFile(saveFileDialog.FileName)
        End If
    End Sub

    Private Sub bLoadFromFile_Click(sender As Object, e As EventArgs) Handles bLoadFromFile.Click
        If openFileDialog.ShowDialog() = DialogResult.OK Then
            Try
                kryptonWorkspace.LoadLayoutFromFile(openFileDialog.FileName)
            Catch ex As Exception
                MessageBox.Show(ex.Message, "Error Loading from File")
            End Try
        End If
    End Sub

    Private Sub kryptonWorkspace_PageSaving(sender As Object, e As PageSavingEventArgs) Handles kryptonWorkspace.PageSaving
        ' Get access to the text box inside the page
        Dim rtb = CType(e.Page.Controls(0), KryptonRichTextBox)

        ' Save the text in the textbox into the per-page storage
        e.XmlWriter.WriteCData(rtb.Text)
    End Sub

    Private Sub kryptonWorkspace_PageLoading(sender As Object, e As PageLoadingEventArgs) Handles kryptonWorkspace.PageLoading
        Dim rtb As KryptonRichTextBox

        ' If a new page then it does not have any children...
        If e.Page.Controls.Count = 0 Then
            ' Add a rich text box as the child of the page
            rtb = New KryptonRichTextBox()
            rtb.Dock = DockStyle.Fill
            rtb.StateCommon.Border.Draw = InheritBool.False
            e.Page.Controls.Add(rtb)
            e.Page.Padding = New Padding(5)
        Else
            rtb = CType(e.Page.Controls(0), KryptonRichTextBox)
        End If

        ' Move past the current xml element to the child CData
        e.XmlReader.Read()

        ' Read in the stored text and use it in the rich text box
        rtb.Text = e.XmlReader.ReadContentAsString()
    End Sub

    Private Sub kryptonWorkspace_RecreateLoadingPage(sender As Object, e As RecreateLoadingPageEventArgs) Handles kryptonWorkspace.RecreateLoadingPage
        e.Page = New KryptonPage()
    End Sub

    Private Sub kryptonWorkspace_PagesUnmatched(sender As Object, e As PagesUnmatchedEventArgs) Handles kryptonWorkspace.PagesUnmatched
        For Each page As KryptonPage In e.Unmatched
            Console.WriteLine("Unmatched Page {0}", page.Text)
        Next
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
            $"This page ({page.Text}) contains a rich text box control as example content." & vbLf & vbLf & "Try saving the layout and then dragging the page headers in order to rearrange the workspace layout. Once altered you can use the load button to get back to the original state."
        rtb.Dock = DockStyle.Fill
        rtb.StateCommon.Border.Draw = InheritBool.False

        ' Add rich text box as the contents of the page
        page.Padding = New Padding(5)
        page.Controls.Add(rtb)

        Return page
    End Function

End Class
