#Region "BSD License"
'
' Original BSD 3-Clause License (https://github.com/ComponentFactory/Krypton/blob/master/LICENSE)
'  © Component Factory Pty Ltd, 2006 - 2016, (Version 4.5.0.0) All rights reserved.
'
'  New BSD 3-Clause License (https://github.com/Krypton-Suite/Standard-Toolkit/blob/master/LICENSE)
'  Modifications by Peter Wagner(aka Wagnerp) & Simon Coghlan(aka Smurf-IV), et al. 2017 - 2024. All rights reserved.
'
' VB.NET twin of Source\Krypton Navigator Examples\User Page Creation\Form1.cs (Bastion Phase 4c).
#End Region

Imports System
Imports System.Windows.Forms

Imports Krypton.Navigator
Imports Krypton.Toolkit

Public Class Form1

    Private _count As Integer = 2

    Private Sub Form1_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        ' Add the initial document page
        InsertNewPage()
    End Sub

    Private Sub kryptonNavigator1_SelectedPageChanged(sender As Object, e As EventArgs) Handles kryptonNavigator1.SelectedPageChanged
        ' If user selects the 'new page' which is the last page in the pages
        ' collection then we want to insert a new page just before the 'new page'.
        If kryptonNavigator1.SelectedIndex = (kryptonNavigator1.Pages.Count - 1) Then
            InsertNewPage()
        End If
    End Sub

    Private Sub kryptonNavigator1_CloseAction(sender As Object, e As CloseActionEventArgs) Handles kryptonNavigator1.CloseAction
        ' If deleting the last page before the 'new page' then need to switch the
        ' selection before the close actually gets processed. Otherwise removing the
        ' second to last page will causing the last 'new page' page to be selected.
        ' But that would cause a new page to be created! So manually set selection
        ' to the previous page to prevent this behavior.
        If e.Index = (kryptonNavigator1.Pages.Count - 2) Then
            kryptonNavigator1.SelectedIndex = kryptonNavigator1.Pages.Count - 3
        End If

        ' You cannot delete the last document page. As the 'new page' page at the end of
        ' the collection should always be there, we insist that 2 pages must be present. As
        ' we are now removing a page that means that if there are 3 pages then after the
        ' remove has completed we should not allow any more removes.
        If kryptonNavigator1.Pages.Count = 3 Then
            kryptonNavigator1.Button.CloseButtonDisplay = ButtonDisplay.ShowDisabled
        End If
    End Sub

    Private Sub InsertNewPage()
        ' Then create a new page
        Dim newPage = New KryptonPage()

        ' Define the name and image of the page
        newPage.Text = $"Page{_count}"
        _count += 1
        newPage.ImageSmall = My.Resources.document

        ' Insert just at second to last index, just before the 'new page' page
        kryptonNavigator1.Pages.Insert(kryptonNavigator1.Pages.Count - 1, newPage)

        ' Select the new page
        kryptonNavigator1.SelectedPage = newPage

        ' We insist that two pages are always present. As we have just added one we
        ' need to check if we now have 3 and so the close button should be allowed again.
        If kryptonNavigator1.Pages.Count = 3 Then
            kryptonNavigator1.Button.CloseButtonDisplay = ButtonDisplay.ShowEnabled
        End If
    End Sub

    Private Sub kryptonNavigator1_ContextAction(sender As Object, e As ContextActionEventArgs) Handles kryptonNavigator1.ContextAction
        ' Because the 'new page' item does not have any text we need to manually set the
        ' displayed text for 'new page' in the context menu strip, otherwise it will be blank
        Dim items = DirectCast(e.KryptonContextMenu.Items(0), KryptonContextMenuItems)
        Dim item = DirectCast(items.Items(items.Items.Count - 1), KryptonContextMenuItem)
        item.Text = "New Page"
    End Sub

    Private Sub buttonClose_Click(sender As Object, e As EventArgs) Handles buttonClose.Click
        ' NOTE: Upstream quirk preserved from the C# twin - the close button toggles the
        ' navigator mode instead of closing the form (the Close() call is commented out).
        kryptonNavigator1.NavigatorMode = NavigatorMode.BarRibbonTabGroup
        kryptonNavigator1.NavigatorMode = NavigatorMode.BarTabGroup

        'Close();
    End Sub

End Class
