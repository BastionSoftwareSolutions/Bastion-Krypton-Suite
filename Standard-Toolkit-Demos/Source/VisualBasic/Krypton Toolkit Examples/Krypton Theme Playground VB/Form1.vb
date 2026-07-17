' *****************************************************************************
' BSD 3-Clause License (https://github.com/Krypton-Suite/Standard-Toolkit)
'  By Peter Wagner(aka Wagnerp) & Simon Coghlan(aka Smurf-IV) 2022 - 2024. All rights reserved.
' *****************************************************************************
' VB.NET twin of Source\Krypton Toolkit Examples\Krypton Theme Playground\Form1.cs (Bastion Phase 4c).

Imports System

Imports Krypton.Toolkit

Public Class Form1

    Public Sub New()
        InitializeComponent()
    End Sub

    Private Sub Form1_Load(sender As Object, e As EventArgs) Handles MyBase.Load

    End Sub

    Private Sub kryptonCheckedListBox1_SelectedIndexChanged(sender As Object, e As EventArgs) Handles kryptonCheckedListBox1.SelectedIndexChanged
        kpg.SelectedObject = kryptonCheckedListBox1
    End Sub

End Class
