#Region "BSD License"
'
' Original BSD 3-Clause License (https://github.com/ComponentFactory/Krypton/blob/master/LICENSE)
'  © Component Factory Pty Ltd, 2006 - 2016, (Version 4.5.0.0) All rights reserved.
'
'  New BSD 3-Clause License (https://github.com/Krypton-Suite/Standard-Toolkit/blob/master/LICENSE)
'  Modifications by Peter Wagner(aka Wagnerp) & Simon Coghlan(aka Smurf-IV), et al. 2017 - 2024. All rights reserved.
'
' VB.NET twin of Source\Krypton Ribbon Examples\MDI Ribbon\Form1.cs (Bastion Phase 4c).
#End Region

Imports System
Imports System.Windows.Forms

Imports Krypton.Toolkit

Public Class Form1

    Private _count As Integer = 1

    Private Sub Form1_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        ' Start by creating three MDI child windows
        AddMDIChildWindow()
        AddMDIChildWindow()
        AddMDIChildWindow()
    End Sub

    Private Sub buttonNewWindow_Click(sender As Object, e As EventArgs) Handles buttonNewWindow.Click
        ' Add another MDI child window
        AddMDIChildWindow()
    End Sub

    Private Sub buttonCloseWindow_Click(sender As Object, e As EventArgs) Handles buttonCloseWindow.Click
        ' Close just the active child
        If ActiveMdiChild IsNot Nothing Then
            ActiveMdiChild.Close()
        End If
    End Sub

    Private Sub buttonCloseAllWindows_Click(sender As Object, e As EventArgs) Handles buttonCloseAllWindows.Click
        ' Keep closing active children until all gone
        While ActiveMdiChild IsNot Nothing
            ActiveMdiChild.Close()
        End While
    End Sub

    Private Sub buttonCascade_Click(sender As Object, e As EventArgs) Handles buttonCascade.Click
        LayoutMdi(MdiLayout.Cascade)
    End Sub

    Private Sub buttonTileHorizontal_Click(sender As Object, e As EventArgs) Handles buttonTileHorizontal.Click
        LayoutMdi(MdiLayout.TileHorizontal)
    End Sub

    Private Sub buttonTileVertical_Click(sender As Object, e As EventArgs) Handles buttonTileVertical.Click
        LayoutMdi(MdiLayout.TileVertical)
    End Sub

    Private Sub buttonSpecHelp_Click(sender As Object, e As EventArgs) Handles buttonSpecHelp.Click
        Dim f As New Form3()
        f.ShowDialog()
    End Sub

    Private Sub AddMDIChildWindow()
        Dim f As New Form2 With {
            .Text = $"Child {_count}",
            .MdiParent = Me
        }
        _count += 1
        f.Show()
    End Sub

    Private Sub appMenu_Click(sender As Object, e As EventArgs) Handles kryptonContextMenuItem1.Click
        Close()
    End Sub

End Class
