#Region "BSD License"
'
' Original BSD 3-Clause License (https://github.com/ComponentFactory/Krypton/blob/master/LICENSE)
'  © Component Factory Pty Ltd, 2006 - 2016, (Version 4.5.0.0) All rights reserved.
'
'  New BSD 3-Clause License (https://github.com/Krypton-Suite/Standard-Toolkit/blob/master/LICENSE)
'  Modifications by Peter Wagner(aka Wagnerp) & Simon Coghlan(aka Smurf-IV), et al. 2017 - 2024. All rights reserved.
'
' VB.NET twin of Source\Krypton Ribbon Examples\Quick Access Toolbar\Form1.cs (Bastion Phase 4c).
#End Region

Imports System
Imports System.Drawing

Imports Krypton.Ribbon
Imports Krypton.Toolkit

Public Class Form1

    Private _count As Integer

    Private ReadOnly _images As Image() = New Image() {My.Resources.flag_australia,
                                                       My.Resources.flag_cameroon,
                                                       My.Resources.flag_canada,
                                                       My.Resources.flag_czech_republic,
                                                       My.Resources.flag_egypt,
                                                       My.Resources.flag_france,
                                                       My.Resources.flag_hong_kong,
                                                       My.Resources.flag_italy,
                                                       My.Resources.flag_lithuania,
                                                       My.Resources.flag_new_zealand,
                                                       My.Resources.flag_peru,
                                                       My.Resources.flag_wales}

    Private ReadOnly _names As String() = New String() {"Australia", "Cameroon", "Canada",
                                                        "Czech Republic", "Egypt", "France",
                                                        "Hong Kong", "Italy", "Lithuania",
                                                        "New Zealand", "Peru", "Wales"}

    Private Sub Form1_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        buttonAdd_Click(Me, EventArgs.Empty)
        buttonAdd_Click(Me, EventArgs.Empty)
        buttonAdd_Click(Me, EventArgs.Empty)
    End Sub

    Private Sub checkSetQATPosition_CheckedButtonChanged(sender As Object, e As EventArgs) Handles checkSetQATPosition.CheckedButtonChanged
        If checkSetQATPosition.CheckedButton Is checkButtonAbove Then
            kryptonRibbon.QATLocation = QATLocation.Above
        ElseIf checkSetQATPosition.CheckedButton Is checkButtonBelow Then
            kryptonRibbon.QATLocation = QATLocation.Below
        ElseIf checkSetQATPosition.CheckedButton Is checkButtonHidden Then
            kryptonRibbon.QATLocation = QATLocation.Hidden
        End If
    End Sub

    Private Sub checkSetQATUserChange_CheckedButtonChanged(sender As Object, e As EventArgs) Handles checkSetQATUserChange.CheckedButtonChanged
        If checkSetQATUserChange.CheckedButton Is checkButtonAllowUserChanges Then
            kryptonRibbon.QATUserChange = True
        ElseIf checkSetQATUserChange.CheckedButton Is checkButtonDisallowUserChanges Then
            kryptonRibbon.QATUserChange = False
        End If
    End Sub

    Private Sub buttonAdd_Click(sender As Object, e As EventArgs) Handles buttonAdd.Click
        Dim qatButton As New KryptonRibbonQATButton With {
            .Text = _names(_count),
            .Image = _images(_count)
        }
        _count = (_count + 1) Mod 12
        kryptonRibbon.QATButtons.Add(qatButton)

        UpdateButtons()
    End Sub

    Private Sub buttonRemove_Click(sender As Object, e As EventArgs) Handles buttonRemove.Click
        If kryptonRibbon.QATButtons.Count > 0 Then
            kryptonRibbon.QATButtons.RemoveAt(0)
        End If

        UpdateButtons()
    End Sub

    Private Sub buttonClear_Click(sender As Object, e As EventArgs) Handles buttonClear.Click
        kryptonRibbon.QATButtons.Clear()
        UpdateButtons()
    End Sub

    Private Sub UpdateButtons()
        Dim enable = (kryptonRibbon.QATButtons.Count > 0)
        buttonRemove.Enabled = enable
        buttonClear.Enabled = enable
    End Sub

    Private Sub appMenu_Click(sender As Object, e As EventArgs) Handles kryptonContextMenuItem1.Click
        Close()
    End Sub

End Class
