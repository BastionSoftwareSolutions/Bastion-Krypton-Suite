' *****************************************************************************
' BSD 3-Clause License (https://github.com/Krypton-Suite/Standard-Toolkit)
'  By Peter Wagner(aka Wagnerp) & Simon Coghlan(aka Smurf-IV) 2023 - 2024. All rights reserved.
' *****************************************************************************
' VB.NET twin of Source\Krypton Toolkit Examples\KryptonPropertyGridExample\Form1.cs (Bastion Phase 4c).

Imports System
Imports System.Windows.Forms

Public Class Form1

    Private Sub SetSelectedObject(obj As Object)
        kryptonPropertyGrid1.SelectedObject = obj
        kryptonPropertyGrid2.SelectedObject = obj
    End Sub

    Private Sub kryptonButton1_Click(sender As Object, e As EventArgs) Handles kryptonButton1.Click
        SetSelectedObject(kryptonButton1)
    End Sub

    Private Sub kryptonCheckBox1_CheckedChanged(sender As Object, e As EventArgs) Handles kryptonCheckBox1.CheckedChanged
        SetSelectedObject(kryptonCheckBox1)
    End Sub

    Private Sub kryptonCheckedListBox1_Click(sender As Object, e As EventArgs) Handles kryptonCheckedListBox1.Click
        SetSelectedObject(kryptonCheckedListBox1)
    End Sub

    Private Sub kryptonDateTimePicker1_Click(sender As Object, e As EventArgs) Handles kryptonDateTimePicker1.Click
        SetSelectedObject(kryptonDateTimePicker1)
    End Sub

    Private Sub kryptonMonthCalendar1_DateChanged(sender As Object, e As DateRangeEventArgs) Handles kryptonMonthCalendar1.DateChanged
        SetSelectedObject(kryptonMonthCalendar1)
    End Sub

End Class
