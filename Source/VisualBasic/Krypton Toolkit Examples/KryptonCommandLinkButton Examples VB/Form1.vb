' *****************************************************************************
' BSD 3-Clause License (https://github.com/Krypton-Suite/Standard-Toolkit)
'  By Peter Wagner(aka Wagnerp) & Simon Coghlan(aka Smurf-IV) 2023 - 2024. All rights reserved.
' *****************************************************************************
' VB.NET twin of Source\Krypton Toolkit Examples\KryptonCommandLinkButton Examples\Form1.cs (Bastion Phase 4c).

Imports System

Imports Krypton.Toolkit

Public Class Form1

    Private Sub Form1_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        kpgButtons.SelectedObject = kryptonAlternateCommandLinkButton1
    End Sub

    Private Sub kryptonAlternateCommandLinkButton1_Click(sender As Object, e As EventArgs) Handles kryptonAlternateCommandLinkButton1.Click
        kpgButtons.SelectedObject = kryptonAlternateCommandLinkButton1
    End Sub

    Private Sub kryptonCommandLinkButton1_Click(sender As Object, e As EventArgs) Handles kryptonCommandLinkButton1.Click
        kpgButtons.SelectedObject = kryptonCommandLinkButton1
    End Sub

    Private Sub kryptonCommandLinkButton2_Click(sender As Object, e As EventArgs) Handles kryptonCommandLinkButton2.Click
        kpgButtons.SelectedObject = kryptonCommandLinkButton2
    End Sub

    Private Sub kryptonCommandLinkButton3_Click(sender As Object, e As EventArgs) Handles kryptonCommandLinkButton3.Click
        kpgButtons.SelectedObject = kryptonCommandLinkButton3
    End Sub

    Private Sub kryptonCommandLinkButton4_Click(sender As Object, e As EventArgs) Handles kryptonCommandLinkButton4.Click
        kpgButtons.SelectedObject = kryptonCommandLinkButton4
    End Sub

    Private Sub kryptonCommandLinkButton5_Click(sender As Object, e As EventArgs) Handles kryptonCommandLinkButton5.Click
        kpgButtons.SelectedObject = kryptonCommandLinkButton5
    End Sub

    Private Sub kbtOk_Click(sender As Object, e As EventArgs) Handles kbtOk.Click
        Close()
    End Sub

End Class
