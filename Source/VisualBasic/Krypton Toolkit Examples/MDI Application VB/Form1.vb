#Region "BSD License"
'
' Original BSD 3-Clause License (https://github.com/ComponentFactory/Krypton/blob/master/LICENSE)
'  © Component Factory Pty Ltd, 2006 - 2016, (Version 4.5.0.0) All rights reserved.
'
'  New BSD 3-Clause License (https://github.com/Krypton-Suite/Standard-Toolkit/blob/master/LICENSE)
'  Modifications by Peter Wagner(aka Wagnerp) & Simon Coghlan(aka Smurf-IV), et al. 2017 - 2024. All rights reserved.
'
' VB.NET twin of Source\Krypton Toolkit Examples\MDI Application\Form1.cs (Bastion Phase 4c).
#End Region

Imports System.Windows.Forms

Imports Krypton.Toolkit

Public Class Form1

    Private _count As Integer = 1

    Public Sub New()
        InitializeComponent()
    End Sub

    Private Sub Form1_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        ' Start by creating three MDI child windows
        AddMDIChildWindow()
        AddMDIChildWindow()
        AddMDIChildWindow()
    End Sub

    Private Sub AddMDIChildWindow()
        Dim f As New Form2()
        f.Text = $"Child {_count}"
        _count += 1
        f.MdiParent = Me
        f.Show()
    End Sub

    Private Sub newWindowToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles newWindowToolStripMenuItem.Click, toolStripButton1.Click
        ' Add another MDI child window
        AddMDIChildWindow()
    End Sub

    Private Sub closeWindowToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles closeWindowToolStripMenuItem.Click, toolStripButton2.Click
        ' Close just the active child
        ActiveMdiChild?.Close()
    End Sub

    Private Sub closeAllWidowToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles closeAllWidowToolStripMenuItem.Click, toolStripButton3.Click
        ' Keep closing active children until all gone
        While ActiveMdiChild IsNot Nothing
            ActiveMdiChild.Close()
        End While
    End Sub

    Private Sub cascadeToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles cascadeToolStripMenuItem.Click, toolStripButton4.Click
        LayoutMdi(MdiLayout.Cascade)
    End Sub

    Private Sub tileHorizontalToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles tileHorizontalToolStripMenuItem.Click, toolStripButton5.Click
        LayoutMdi(MdiLayout.TileHorizontal)
    End Sub

    Private Sub tileVerticalToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles tileVerticalToolStripMenuItem.Click, toolStripButton6.Click
        LayoutMdi(MdiLayout.TileVertical)
    End Sub

    Private Sub exitToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles exitToolStripMenuItem.Click
        Close()
    End Sub

End Class
