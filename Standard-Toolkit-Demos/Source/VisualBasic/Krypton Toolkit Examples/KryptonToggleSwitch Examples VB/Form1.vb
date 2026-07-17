' *****************************************************************************
' BSD 3-Clause License (https://github.com/Krypton-Suite/Standard-Toolkit)
'  By Peter Wagner(aka Wagnerp), Simon Coghlan(aka Smurf-IV) & Giduac 2025 - 2025. All rights reserved.
' *****************************************************************************
' VB.NET twin of Source\Krypton Toolkit Examples\KryptonToggleSwitch Examples\Form1.cs (Bastion Phase 4c).

Imports System
Imports System.Drawing
Imports System.Windows.Forms

Imports Krypton.Toolkit

Public Class Form1

    Public Sub New()
        InitializeComponent()

        Using ms As New System.IO.MemoryStream(My.Resources.Krypton)
            Icon = New Icon(ms)
        End Using
    End Sub

    Private Sub ktsTest_CheckedChanged(sender As Object, e As EventArgs) Handles ktsTest.CheckedChanged
        kryptonWrapLabel1.Text = $"Is toggle switch checked: {ktsTest.Checked}"
    End Sub

    Private Sub Form1_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        kryptonWrapLabel1.Text = $"Is toggle switch checked: {ktsTest.Checked}"
    End Sub

    Private Sub kbtnClose_Click(sender As Object, e As EventArgs) Handles kbtnClose.Click
        Application.Exit()
    End Sub

End Class
