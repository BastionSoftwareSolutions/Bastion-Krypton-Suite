' *****************************************************************************
' BSD 3-Clause License (https://github.com/Krypton-Suite/Standard-Toolkit)
'  By Peter Wagner(aka Wagnerp) & Simon Coghlan(aka Smurf-IV) 2024 - 2024. All rights reserved.
' *****************************************************************************
' VB.NET twin of Source\Krypton Toolkit Examples\KryptonToastNotification Examples\MainForm.cs (Bastion Phase 4c).

Imports System
Imports System.Windows.Forms

Imports Krypton.Toolkit

Public Class MainForm

    Private Sub kbtnCreateBasicNotification_Click(sender As Object, e As EventArgs) Handles kbtnCreateBasicNotification.Click
        Dim basicNotification As New BasicNotification()

        basicNotification.Show()
    End Sub

    Private Sub kbtnCreateUserInputNotification_Click(sender As Object, e As EventArgs) Handles kbtnCreateUserInputNotification.Click
        Dim userInputNotification As New UserInputNotification()

        userInputNotification.Show()
    End Sub

    Private Sub kbtnCancel_Click(sender As Object, e As EventArgs) Handles kbtnCancel.Click
        Application.Exit()
    End Sub

End Class
