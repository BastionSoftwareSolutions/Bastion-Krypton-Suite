#Region "BSD License"
'
' Original BSD 3-Clause License (https://github.com/ComponentFactory/Krypton/blob/master/LICENSE)
'  © Component Factory Pty Ltd, 2006 - 2016, (Version 4.5.0.0) All rights reserved.
'
'  New BSD 3-Clause License (https://github.com/Krypton-Suite/Standard-Toolkit/blob/master/LICENSE)
'  Modifications by Peter Wagner(aka Wagnerp) & Simon Coghlan(aka Smurf-IV), et al. 2017 - 2024. All rights reserved.
'
' VB.NET twin of Source\Krypton Workspace Examples\Cell Maximize + Restore\Form1.cs (Bastion Phase 4c).
#End Region

Imports System
Imports System.Windows.Forms

Imports Krypton.Navigator
Imports Krypton.Toolkit
Imports Krypton.Workspace

Public Class Form1

    Private _pageText As String = "{\rtf1\ansi\ansicpg1252\deff0\deflang3081{\fonttbl{\f0\fnil\fcharset0 Segoe UI;}{\f1\fswiss\fcharset0 Arial;}}
{\colortbl ;\red0\green128\blue128;}\viewkind4\uc1\pard\cf1\f0\fs24\b\fs22 Double Click\cf0\b0\fs18\par
Use the mouse to double click the tab headers and toggle between the maximized and restored mode for the cell that contains that clicked page.\par\par
\cf1\b\fs22 Context Menu\cf0\b0\fs18\par
Right-click the tab header and use the context menu option to toggle between maximized modes.\par\par
\cf1\b\fs22 Keyboard Shortcut\cf0\b0\fs18\par
Use the keyboard shortcut \i Ctrl + Shift + M\i0  to toggle maximized mode.\par\par
\cf1\b\fs22 Maximize/Restore Buttons\cf0\b0\fs18\par
A custom \i ButtonSpec \i0 has been added to the tabs area that can be clicked to toggle maximized modes.\f1\fs20\par}"

    Private Sub Form1_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        ' Define help text within each page
        richTextBox1.Rtf = _pageText
        richTextBox2.Rtf = _pageText
        richTextBox3.Rtf = _pageText
        richTextBox4.Rtf = _pageText
        richTextBox5.Rtf = _pageText
        richTextBox6.Rtf = _pageText
    End Sub

    Private Sub kryptonWorkspace_WorkspaceCellAdding(sender As Object, e As WorkspaceCellEventArgs) Handles kryptonWorkspace.WorkspaceCellAdding
        ' When adding a new cell we need to default the tabs style
        e.Cell.Bar.TabStyle = TabStyle.OneNote

        ' Remove the standard buttons bar buttons
        e.Cell.Button.CloseButtonDisplay = ButtonDisplay.Hide
        e.Cell.Button.ButtonDisplayLogic = ButtonDisplayLogic.None

        ' Generate event whenever a tab is double clicked
        AddHandler e.Cell.TabDoubleClicked, New EventHandler(Of KryptonPageEventArgs)(AddressOf OnTabDoubleClicked)
    End Sub

    Private Sub kryptonWorkspace_ActiveCellChanged(sender As Object, e As ActiveCellChangedEventArgs) Handles kryptonWorkspace.ActiveCellChanged
        If e.OldCell IsNot Nothing Then
            e.OldCell.Bar.TabStyle = TabStyle.OneNote
        End If

        If e.NewCell IsNot Nothing Then
            e.NewCell.Bar.TabStyle = TabStyle.HighProfile
        End If
    End Sub

    Private Sub OnTabDoubleClicked(sender As Object, e As KryptonPageEventArgs)
        ' Find the cell that has this page
        Dim cell As KryptonWorkspaceCell = kryptonWorkspace.CellForPage(e.Item)

        ' Toggle maximized state
        If kryptonWorkspace.MaximizedCell Is Nothing Then
            kryptonWorkspace.MaximizedCell = cell
        Else
            kryptonWorkspace.MaximizedCell = Nothing
        End If
    End Sub

    Private Sub buttonClose_Click(sender As Object, e As EventArgs) Handles buttonClose.Click
        Close()
    End Sub

End Class
