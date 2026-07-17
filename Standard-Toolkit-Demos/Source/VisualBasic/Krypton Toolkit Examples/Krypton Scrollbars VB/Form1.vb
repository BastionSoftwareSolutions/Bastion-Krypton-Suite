' *****************************************************************************
' BSD 3-Clause License (https://github.com/Krypton-Suite/Standard-Toolkit)
'  By Peter Wagner(aka Wagnerp) & Simon Coghlan(aka Smurf-IV) 2021 - 2024. All rights reserved.
' *****************************************************************************
' VB.NET twin of Source\Krypton Toolkit Examples\Krypton Scrollbars\Form1.cs (Bastion Phase 4c).

Imports System

Imports Krypton.Toolkit

Public Class Form1

    Public Sub New()
        InitializeComponent()
    End Sub

    Private Sub Form1_Load(sender As Object, e As EventArgs) Handles MyBase.Load

    End Sub

    Private Sub ksbVertical_Scroll(sender As Object, e As System.Windows.Forms.ScrollEventArgs) Handles ksbVertical.Scroll
        knudVertical.Value = ksbVertical.Value
    End Sub

    Private Sub ksbHorizontal_Scroll(sender As Object, e As System.Windows.Forms.ScrollEventArgs) Handles ksbHorizontal.Scroll
        knudHorizontal.Value = ksbHorizontal.Value
    End Sub

    Private Sub knudVertical_ValueChanged(sender As Object, e As EventArgs) Handles knudVertical.ValueChanged
        ksbVertical.Value = CInt(knudVertical.Value)
    End Sub

    Private Sub knudHorizontal_ValueChanged(sender As Object, e As EventArgs) Handles knudHorizontal.ValueChanged
        ksbHorizontal.Value = CInt(knudHorizontal.Value)
    End Sub

End Class
