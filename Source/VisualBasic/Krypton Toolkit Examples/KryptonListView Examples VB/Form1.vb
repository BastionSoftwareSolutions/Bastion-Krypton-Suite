' *****************************************************************************
' BSD 3-Clause License (https://github.com/Krypton-Suite/Standard-Toolkit)
'  By Peter Wagner(aka Wagnerp) & Simon Coghlan(aka Smurf-IV) 2021 - 2024. All rights reserved.
' *****************************************************************************
' VB.NET twin of Source\Krypton Toolkit Examples\KryptonListView Examples\Form1.cs (Bastion Phase 4c).

Imports System
Imports System.Windows.Forms

Imports Krypton.Toolkit

Public Class Form1

    Public Sub New()
        InitializeComponent()
    End Sub

    Private Sub ViewTypeChanged(sender As Object, e As EventArgs) Handles rbDetails.CheckedChanged,
        rbTile.CheckedChanged, rbList.CheckedChanged, rbSmallIcon.CheckedChanged,
        rbLargIcon.CheckedChanged, rbLargIcon.Validated
        Dim rb As RadioButton = CType(sender, RadioButton)
        If Not rb.Checked Then
            Return
        End If

        Dim view As View = View.Details
        viewCheckBox.Enabled = True
        Select Case rb.Text
            Case "Large Icon"
                view = View.LargeIcon
            Case "Details"
                view = View.Details
            Case "List"
                view = View.List
            Case "Small Icon"
                view = View.SmallIcon
            Case "Tile"
                view = View.Tile
                viewCheckBox.Checked = False
                viewCheckBox.Enabled = False
        End Select
        listWinform.View = view
        Try
            listKrypton.View = view
        Catch exception As Exception
            KryptonMessageBox.Show(Me, exception.Message, "Not Supported",
                KryptonMessageBoxButtons.OK, KryptonMessageBoxIcon.Warning)
        End Try
    End Sub

    Private Sub ViewCheckBox_CheckedChanged(sender As Object, e As EventArgs) Handles viewCheckBox.CheckedChanged
        listWinform.CheckBoxes = viewCheckBox.Checked
        listKrypton.CheckBoxes = viewCheckBox.Checked
    End Sub

    Private Sub chkDisabled_CheckStateChanged(sender As Object, e As EventArgs) Handles chkDisabled.CheckStateChanged
        listWinform.Enabled = Not chkDisabled.Checked
        listKrypton.Enabled = Not chkDisabled.Checked
        kryptonTextBox1.Enabled = Not chkDisabled.Checked
    End Sub

End Class
