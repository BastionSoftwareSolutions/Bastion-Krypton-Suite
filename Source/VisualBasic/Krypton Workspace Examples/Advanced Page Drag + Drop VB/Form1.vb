#Region "BSD License"
'
' Original BSD 3-Clause License (https://github.com/ComponentFactory/Krypton/blob/master/LICENSE)
'  © Component Factory Pty Ltd, 2006 - 2016, (Version 4.5.0.0) All rights reserved.
'
'  New BSD 3-Clause License (https://github.com/Krypton-Suite/Standard-Toolkit/blob/master/LICENSE)
'  Modifications by Peter Wagner(aka Wagnerp) & Simon Coghlan(aka Smurf-IV), et al. 2017 - 2024. All rights reserved.
'
' VB.NET twin of Source\Krypton Workspace Examples\Advanced Page Drag + Drop\Form1.cs (Bastion Phase 4c).
#End Region

Imports System
Imports System.Drawing
Imports System.Windows.Forms

Imports Krypton.Navigator
Imports Krypton.Toolkit
Imports Krypton.Workspace

Public Class Form1

    Private _dm As DragManager

    Private Sub Form1_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        _dm = New DragManager()
        _dm.StateCommon.Feedback = PaletteDragFeedback.Rounded

        ' Add controls that are drop targets
        _dm.DragTargetProviders.Add(dragTreeView)
        _dm.DragTargetProviders.Add(kryptonNavigator)
        _dm.DragTargetProviders.Add(kryptonWorkspace)

        ' Controls that can begin drag operations
        dragTreeView.DragPageNotify = _dm
        kryptonNavigator.DragPageNotify = _dm
        kryptonWorkspace.DragPageNotify = _dm

        ' Add initial pages to the navigator and workspace
        kryptonNavigator.Pages.AddRange(New KryptonPage() {CreatePage("Canberra", 7), CreatePage("Nicosia", 8)})
        kryptonWorkspace.Root.Children.Clear()
        kryptonWorkspace.Root.Children.AddRange(New KryptonWorkspaceCell() {CreateCell("Dublin", 9, "Oslo", 10), CreateCell("Budapest", 11, "Tokyo", 12)})
    End Sub

    Private Sub radioBlock_CheckedChanged(sender As Object, e As EventArgs) Handles radioBlock.CheckedChanged
        ' NOTE (Bastion 4c): VB Handles binds at field assignment, so this handler can fire during
        ' InitializeComponent before _dm is created in Form1_Load; the C# twin wires events afterwards.
        If _dm Is Nothing Then Return
        If radioBlock.Checked Then
            _dm.StateCommon.Feedback = PaletteDragFeedback.Block
        End If
    End Sub

    Private Sub radioSquares_CheckedChanged(sender As Object, e As EventArgs) Handles radioSquares.CheckedChanged
        ' NOTE (Bastion 4c): VB Handles binds at field assignment, so this handler can fire during
        ' InitializeComponent before _dm is created in Form1_Load; the C# twin wires events afterwards.
        If _dm Is Nothing Then Return
        If radioSquares.Checked Then
            _dm.StateCommon.Feedback = PaletteDragFeedback.Square
        End If
    End Sub

    Private Sub radioRounded_CheckedChanged(sender As Object, e As EventArgs) Handles radioRounded.CheckedChanged
        ' NOTE (Bastion 4c): VB Handles binds at field assignment, so this handler can fire during
        ' InitializeComponent before _dm is created in Form1_Load; the C# twin wires events afterwards.
        If _dm Is Nothing Then Return
        If radioRounded.Checked Then
            _dm.StateCommon.Feedback = PaletteDragFeedback.Rounded
        End If
    End Sub

    Private Sub workspaceCellAdding(sender As Object, e As WorkspaceCellEventArgs) Handles kryptonWorkspace.WorkspaceCellAdding
        ' Hide the default close and context buttons, they are not relevant for this demo
        ' NOTE: mirrors the upstream demo, which assigns CloseButtonAction twice in succession.
        e.Cell.Button.CloseButtonAction = CloseButtonAction.None
        e.Cell.Button.CloseButtonAction = CloseButtonAction.RemovePage
        'e.Cell.Button.CloseButtonDisplay = ButtonDisplay.Hide
        'e.Cell.Button.ContextButtonDisplay = ButtonDisplay.Hide
    End Sub

    Private Function CreateCell(title As String, imageIndex As Integer) As KryptonWorkspaceCell
        Dim cell = New KryptonWorkspaceCell()
        cell.Pages.Add(CreatePage(title, imageIndex))
        Return cell
    End Function

    Private Function CreateCell(title1 As String, imageIndex1 As Integer,
                                title2 As String, imageIndex2 As Integer) As KryptonWorkspaceCell
        Dim cell = New KryptonWorkspaceCell()
        cell.Pages.Add(CreatePage(title1, imageIndex1))
        cell.Pages.Add(CreatePage(title2, imageIndex2))
        Return cell
    End Function

    Private Function CreatePage(title As String, imageIndex As Integer) As KryptonPage
        ' Create a new page and give it a name and image
        Dim page = New KryptonPage()
        page.Text = title
        page.TextTitle = $"{title} Title"
        page.TextDescription = $"{title} Description"
        page.ImageSmall = CType(imageList.Images(imageIndex), Bitmap)
        page.Tag = imageIndex.ToString()

        ' Create a rich text box with some sample text inside
        Dim rtb = New KryptonRichTextBox()
        rtb.Text = $"This page ({page.Text}) contains a rich text box control as example content."
        rtb.Dock = DockStyle.Fill
        rtb.StateCommon.Border.Draw = InheritBool.False

        ' Add rich text box as the contents of the page
        page.Padding = New Padding(5)
        page.Controls.Add(rtb)

        Return page
    End Function

    Private Sub buttonClose_Click(sender As Object, e As EventArgs) Handles buttonClose.Click
        Close()
    End Sub

End Class
