#Region "BSD License"
'
' Original BSD 3-Clause License (https://github.com/ComponentFactory/Krypton/blob/master/LICENSE)
'  © Component Factory Pty Ltd, 2006 - 2016, (Version 4.5.0.0) All rights reserved.
'
'  New BSD 3-Clause License (https://github.com/Krypton-Suite/Standard-Toolkit/blob/master/LICENSE)
'  Modifications by Peter Wagner(aka Wagnerp) & Simon Coghlan(aka Smurf-IV), et al. 2017 - 2024. All rights reserved.
'
' VB.NET twin of Source\Krypton Navigator Examples\Basic Events\Form1.cs (Bastion Phase 4c).
#End Region

Imports System
Imports System.Drawing
Imports System.Windows.Forms

Imports Krypton.Navigator
Imports Krypton.Toolkit

Public Class Form1

    Private _count As Integer = 3

    Public Sub New()
        InitializeComponent()

        ' Monitor changes in the pages collection (runtime wiring, mirroring the C# twin)
        AddHandler kryptonNavigator1.Pages.Inserted, New TypedHandler(Of KryptonPage)(AddressOf OnPageInsertRemove)
        AddHandler kryptonNavigator1.Pages.Removed, New TypedHandler(Of KryptonPage)(AddressOf OnPageInsertRemove)
        AddHandler kryptonNavigator1.Pages.Cleared, New EventHandler(AddressOf OnPagesCleared)
    End Sub

    Private Sub Form1_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        ' Set initial state of the buttons
        UpdateButtonState()
    End Sub

    Private Sub kryptonButtonAdd_Click(sender As Object, e As EventArgs) Handles kryptonButtonAdd.Click
        ' Create a new krypton page
        Dim newPage = New KryptonPage()

        ' Populate with text and image
        newPage.Text = $"Page {_count}"
        newPage.TextTitle = $"Page {_count} Title"
        newPage.TextDescription = $"Page {_count} Description"
        newPage.ImageSmall = DirectCast(imageList1.Images(_count Mod imageList1.Images.Count), Bitmap)
        _count += 1

        ' Append to end of the pages collection
        kryptonNavigator1.Pages.Add(newPage)

        ' Select the new page
        kryptonNavigator1.SelectedPage = newPage
    End Sub

    Private Sub kryptonButtonRemove_Click(sender As Object, e As EventArgs) Handles kryptonButtonRemove.Click
        kryptonNavigator1.Pages.Remove(kryptonNavigator1.SelectedPage)
    End Sub

    Private Sub kryptonButtonClear_Click(sender As Object, e As EventArgs) Handles kryptonButtonClear.Click
        kryptonNavigator1.Pages.Clear()
    End Sub

    Private Sub kryptonButtonEnable_Click(sender As Object, e As EventArgs) Handles kryptonButtonEnable.Click
        kryptonNavigator1.SelectedPage.Enabled = Not kryptonNavigator1.SelectedPage.Enabled
        UpdateButtonState()
    End Sub

    Private Sub OnPagesCleared(sender As Object, e As EventArgs)
        UpdateButtonState()
    End Sub

    Private Sub OnPageInsertRemove(sender As Object, e As TypedCollectionEventArgs(Of KryptonPage))
        UpdateButtonState()
    End Sub

    Private Sub UpdateButtonState()
        ' Can only remove if a page is selected
        kryptonButtonRemove.Enabled = (kryptonNavigator1.SelectedPage IsNot Nothing)

        ' Can only clear if there is at least one page in collection
        kryptonButtonClear.Enabled = (kryptonNavigator1.Pages.Count > 0)

        ' Can only change enabled state if a button is selected
        kryptonButtonEnable.Enabled = (kryptonNavigator1.SelectedPage IsNot Nothing)

        ' Only update the enabled button text if the button is itself enabled
        If kryptonButtonEnable.Enabled Then
            ' Give text to indicate the enabled state will be toggled
            If kryptonNavigator1.SelectedPage.Enabled Then
                kryptonButtonEnable.Text = "Disable"
            Else
                kryptonButtonEnable.Text = "Enable"
            End If
        End If
    End Sub

    Private Sub kryptonNavigator1_Deselected(sender As Object, e As KryptonPageEventArgs) Handles kryptonNavigator1.Deselected
        AddOutput($"Deselected {vbTab}{vbTab} '{e.Item.Text}'")
    End Sub

    Private Sub kryptonNavigator1_Deselecting(sender As Object, e As KryptonPageCancelEventArgs) Handles kryptonNavigator1.Deselecting
        AddOutput($"Deselecting {vbTab}{vbTab} '{e.Item.Text}'")
    End Sub

    Private Sub kryptonNavigator1_Selected(sender As Object, e As KryptonPageEventArgs) Handles kryptonNavigator1.Selected
        AddOutput($"Selected {vbTab}{vbTab} '{e.Item.Text}'")
    End Sub

    Private Sub kryptonNavigator1_Selecting(sender As Object, e As KryptonPageCancelEventArgs) Handles kryptonNavigator1.Selecting
        AddOutput($"Selecting {vbTab}{vbTab} '{e.Item.Text}'")
    End Sub

    Private Sub kryptonNavigator1_SelectedPageChanged(sender As Object, e As EventArgs) Handles kryptonNavigator1.SelectedPageChanged
        If kryptonNavigator1.SelectedPage Is Nothing Then
            AddOutput($"SelectedPageChanged {vbTab} (null)")
        Else
            AddOutput($"SelectedPageChanged {vbTab} '{kryptonNavigator1.SelectedPage.Text}'")
        End If

        UpdateButtonState()
    End Sub

    Private Sub kryptonNavigator1_CloseAction(sender As Object, e As CloseActionEventArgs) Handles kryptonNavigator1.CloseAction
        AddOutput("CloseAction")
    End Sub

    Private Sub kryptonNavigator1_ContextAction(sender As Object, e As ContextActionEventArgs) Handles kryptonNavigator1.ContextAction
        AddOutput("ContextAction")
    End Sub

    Private Sub kryptonNavigator1_NextAction(sender As Object, e As DirectionActionEventArgs) Handles kryptonNavigator1.NextAction
        AddOutput("NextAction")
    End Sub

    Private Sub kryptonNavigator1_PreviousAction(sender As Object, e As DirectionActionEventArgs) Handles kryptonNavigator1.PreviousAction
        AddOutput("PreviousAction")
    End Sub

    Private Sub buttonClearEventList_Click(sender As Object, e As EventArgs) Handles buttonClearEventList.Click
        listBoxEvents.Items.Clear()
    End Sub

    Private Sub AddOutput(output As String)
        listBoxEvents.Items.Add(output)
    End Sub

    Private Sub buttonClose_Click(sender As Object, e As EventArgs) Handles buttonClose.Click
        Close()
    End Sub

End Class
