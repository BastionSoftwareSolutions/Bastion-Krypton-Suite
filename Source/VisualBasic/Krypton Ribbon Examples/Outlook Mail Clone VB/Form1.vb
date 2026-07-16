#Region "BSD License"
'
' Original BSD 3-Clause License (https://github.com/ComponentFactory/Krypton/blob/master/LICENSE)
'  © Component Factory Pty Ltd, 2006 - 2016, (Version 4.5.0.0) All rights reserved.
'
'  New BSD 3-Clause License (https://github.com/Krypton-Suite/Standard-Toolkit/blob/master/LICENSE)
'  Modifications by Peter Wagner(aka Wagnerp) & Simon Coghlan(aka Smurf-IV), et al. 2017 - 2024. All rights reserved.
'
' VB.NET twin of Source\Krypton Ribbon Examples\Outlook Mail Clone\Form1.cs (Bastion Phase 4c).
#End Region

Imports System

Imports Krypton.Toolkit

Public Class Form1

    Public Sub New()
        InitializeComponent()
        KryptonManager.Strings.RibbonStrings.RecentDocuments = "Create New Outlook Item"
    End Sub

    Private Sub formatPlainText_Click(sender As Object, e As EventArgs) Handles formatPlainText.Click
        ' If it has become checked, then ensure other options are no
        ' longer in the checked state. If we are clicked to make unchecked
        ' then override that behavior by forcing outself back to checked.
        If formatPlainText.Checked Then
            formatHTML.Checked = False
            formatRichText.Checked = False
        Else
            formatPlainText.Checked = True
        End If
    End Sub

    Private Sub formatHTML_Click(sender As Object, e As EventArgs) Handles formatHTML.Click
        ' If it has become checked, then ensure other options are no
        ' longer in the checked state. If we are clicked to make unchecked
        ' then override that behavior by forcing outself back to checked.
        If formatHTML.Checked Then
            formatPlainText.Checked = False
            formatRichText.Checked = False
        Else
            formatHTML.Checked = True
        End If
    End Sub

    Private Sub formatRichText_Click(sender As Object, e As EventArgs) Handles formatRichText.Click
        ' If it has become checked, then ensure other options are no
        ' longer in the checked state. If we are clicked to make unchecked
        ' then override that behavior by forcing outself back to checked.
        If formatRichText.Checked Then
            formatPlainText.Checked = False
            formatHTML.Checked = False
        Else
            formatRichText.Checked = True
        End If
    End Sub

    Private Sub exitToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles exitToolStripMenuItem.Click
        Close()
    End Sub

End Class
