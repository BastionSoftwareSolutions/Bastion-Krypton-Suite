#Region "BSD License"
'
' Original BSD 3-Clause License (https://github.com/ComponentFactory/Krypton/blob/master/LICENSE)
'  © Component Factory Pty Ltd, 2006 - 2016, (Version 4.5.0.0) All rights reserved.
'
'  New BSD 3-Clause License (https://github.com/Krypton-Suite/Standard-Toolkit/blob/master/LICENSE)
'  Modifications by Peter Wagner(aka Wagnerp) & Simon Coghlan(aka Smurf-IV), et al. 2017 - 2024. All rights reserved.
'
' VB.NET twin of Source\Krypton Workspace Examples\Basic Page Drag + Drop\Form1.cs (Bastion Phase 4c).
#End Region

Imports System
Imports System.Drawing
Imports System.Windows.Forms

Imports Krypton.Navigator
Imports Krypton.Toolkit
Imports Krypton.Workspace

Public Class Form1

    Private _count As Integer
    Private _dm As DragManager

    Private Sub Form1_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        _dm = New DragManager()
        _dm.StateCommon.Feedback = PaletteDragFeedback.Rounded

        ' Both navigators and workspaces are drag targets
        _dm.DragTargetProviders.Add(kryptonNavigator1)
        _dm.DragTargetProviders.Add(kryptonNavigator2)
        _dm.DragTargetProviders.Add(kryptonWorkspace1)
        _dm.DragTargetProviders.Add(kryptonWorkspace2)

        ' Both navigators and workspaces can begin drag operations
        kryptonNavigator1.DragPageNotify = _dm
        kryptonNavigator2.DragPageNotify = _dm
        kryptonWorkspace1.DragPageNotify = _dm
        kryptonWorkspace2.DragPageNotify = _dm

        ' Add initial pages to the navigators and workspaces
        kryptonNavigator1.Pages.AddRange(New KryptonPage() {CreatePage(), CreatePage(), CreatePage()})
        kryptonNavigator2.Pages.AddRange(New KryptonPage() {CreatePage(), CreatePage(), CreatePage()})
        kryptonWorkspace1.Root.Children.AddRange(New KryptonWorkspaceCell() {CreateCell(2), CreateCell(2)})
        kryptonWorkspace2.Root.Children.AddRange(New KryptonWorkspaceCell() {CreateCell(2), CreateCell(2)})
    End Sub

    Private Sub kryptonWorkspace1_WorkspaceCellAdding(sender As Object, e As WorkspaceCellEventArgs) Handles kryptonWorkspace1.WorkspaceCellAdding
        ' Hide the buttons we do not need for this sample
        e.Cell.Button.CloseButtonDisplay = ButtonDisplay.Hide
        e.Cell.Button.ContextButtonDisplay = ButtonDisplay.Hide
    End Sub

    Private Sub kryptonWorkspace2_WorkspaceCellAdding(sender As Object, e As WorkspaceCellEventArgs) Handles kryptonWorkspace2.WorkspaceCellAdding
        ' Hide the buttons we do not need for this sample
        e.Cell.Button.CloseButtonDisplay = ButtonDisplay.Hide
        e.Cell.Button.ContextButtonDisplay = ButtonDisplay.Hide

        ' We want to provide header groups for the second workspace
        e.Cell.NavigatorMode = NavigatorMode.HeaderBarCheckButtonHeaderGroup
        e.Cell.Header.HeaderVisibleSecondary = False
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

        ' Create a rich text box with some sample text inside
        Dim rtb = New KryptonRichTextBox()
        rtb.Text =
            $"This page ({page.Text}) contains a rich text box control as example content. Your application could place anything you like here such as data entry controls, charts, data grids etc."
        rtb.Dock = DockStyle.Fill
        rtb.StateCommon.Border.Draw = InheritBool.False

        ' Add rich text box as the contents of the page
        page.Padding = New Padding(5)
        page.Controls.Add(rtb)

        Return page
    End Function

End Class
