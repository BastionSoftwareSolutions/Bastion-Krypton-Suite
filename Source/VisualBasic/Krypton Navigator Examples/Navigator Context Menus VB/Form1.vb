#Region "BSD License"
'
' Original BSD 3-Clause License (https://github.com/ComponentFactory/Krypton/blob/master/LICENSE)
'  © Component Factory Pty Ltd, 2006 - 2016, (Version 4.5.0.0) All rights reserved.
'
'  New BSD 3-Clause License (https://github.com/Krypton-Suite/Standard-Toolkit/blob/master/LICENSE)
'  Modifications by Peter Wagner(aka Wagnerp) & Simon Coghlan(aka Smurf-IV), et al. 2017 - 2024. All rights reserved.
'
' VB.NET twin of Source\Krypton Navigator Examples\Navigator Context Menus\Form1.cs (Bastion Phase 4c).
#End Region

Imports System
Imports System.Windows.Forms

Imports Krypton.Navigator

Public Class Form1

    Private Sub kryptonNavigator1_ShowContextMenu(sender As Object, e As ShowContextMenuArgs) Handles kryptonNavigator1.ShowContextMenu
        ' Yes we want to show a context menu
        e.Cancel = False

        ' Provide the navigator specific menu
        e.KryptonContextMenu = kcmNavigator

        ' Only enable the appropriate options
        kcmFirst.Enabled = (kryptonNavigator1.SelectedIndex > 0)
        kcmPrevious.Enabled = (kryptonNavigator1.SelectedIndex > 0)
        kcmNext.Enabled = (kryptonNavigator1.SelectedIndex < (kryptonNavigator1.Pages.Count - 1))
        kcmLast.Enabled = (kryptonNavigator1.SelectedIndex < (kryptonNavigator1.Pages.Count - 1))
    End Sub

    Private Sub kcmFirst_Click(sender As Object, e As EventArgs) Handles kcmFirst.Click
        ' Move the selected page to the start of the page list
        Dim kp As KryptonPage = kryptonNavigator1.SelectedPage
        kryptonNavigator1.Pages.Remove(kp)
        kryptonNavigator1.Pages.Insert(0, kp)
        kryptonNavigator1.SelectedPage = kp
    End Sub

    Private Sub kcmPrevious_Click(sender As Object, e As EventArgs) Handles kcmPrevious.Click
        ' Move the selected page to the previous place in the page list
        Dim kp As KryptonPage = kryptonNavigator1.SelectedPage
        Dim index = kryptonNavigator1.SelectedIndex
        kryptonNavigator1.Pages.Remove(kp)
        kryptonNavigator1.Pages.Insert(index - 1, kp)
        kryptonNavigator1.SelectedPage = kp
    End Sub

    Private Sub kcmNext_Click(sender As Object, e As EventArgs) Handles kcmNext.Click
        ' Move the selected page to the next place in the list
        Dim kp As KryptonPage = kryptonNavigator1.SelectedPage
        Dim index = kryptonNavigator1.SelectedIndex
        kryptonNavigator1.Pages.Remove(kp)
        kryptonNavigator1.Pages.Insert(index + 1, kp)
        kryptonNavigator1.SelectedPage = kp
    End Sub

    Private Sub kcmLast_Click(sender As Object, e As EventArgs) Handles kcmLast.Click
        ' Move the selected page to the end of the page list
        Dim kp As KryptonPage = kryptonNavigator1.SelectedPage
        Dim index = kryptonNavigator1.SelectedIndex
        kryptonNavigator1.Pages.Remove(kp)
        kryptonNavigator1.Pages.Add(kp)
        kryptonNavigator1.SelectedPage = kp
    End Sub

    Private Sub buttonClose_Click(sender As Object, e As EventArgs) Handles buttonClose.Click
        Close()
    End Sub

End Class
