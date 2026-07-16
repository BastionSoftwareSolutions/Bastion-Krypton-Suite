#Region "BSD License"
'
' Original BSD 3-Clause License (https://github.com/ComponentFactory/Krypton/blob/master/LICENSE)
'  © Component Factory Pty Ltd, 2006 - 2016, (Version 4.5.0.0) All rights reserved.
'
'  New BSD 3-Clause License (https://github.com/Krypton-Suite/Standard-Toolkit/blob/master/LICENSE)
'  Modifications by Peter Wagner(aka Wagnerp) & Simon Coghlan(aka Smurf-IV), et al. 2017 - 2024. All rights reserved.
'
' VB.NET twin of Source\Krypton Toolkit Examples\KryptonCheckedListBox Examples\Form1.cs (Bastion Phase 4c).
#End Region

Imports System
Imports System.Windows.Forms

Imports Krypton.Toolkit

Public Class Form1

    Private _next As Integer = 1
    Private _rand As New Random()

    Private Sub Form1_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        propertyGrid.SelectedObject = kryptonCheckedListBox

        ' Add some initial entries
        kryptonCheckedListBox.Items.Add(CreateNewItem())
        kryptonCheckedListBox.Items.Add(CreateNewItem())
        kryptonCheckedListBox.Items.Add(CreateNewItem())
        kryptonCheckedListBox.Items.Add(CreateNewItem())
        kryptonCheckedListBox.Items.Add(CreateNewItem())

        ' Select the first entry
        kryptonCheckedListBox.SelectedIndex = 0
    End Sub

    Private Function CreateNewItem() As Object
        Dim item As New KryptonListItem()
        item.ShortText = $"Item {_next}"
        _next += 1
        item.LongText = $"({_rand.Next(Integer.MaxValue)})"
        item.Image = imageList.Images(_rand.Next(imageList.Images.Count - 1))
        Return item
    End Function

    Private Sub kryptonListBox_SelectedIndexChanged(sender As Object, e As EventArgs) Handles kryptonCheckedListBox.SelectedIndexChanged
        buttonInsert.Enabled = (kryptonCheckedListBox.SelectedIndex >= 0)
        buttonRemove.Enabled = (kryptonCheckedListBox.SelectedIndex >= 0)
    End Sub

    Private Sub buttonAppend_Click(sender As Object, e As EventArgs) Handles buttonAppend.Click
        kryptonCheckedListBox.Items.Add(CreateNewItem())

        ' If nothing currently selected, then select the new one
        If kryptonCheckedListBox.SelectedIndex = -1 Then
            kryptonCheckedListBox.SelectedIndex = 0
        End If
    End Sub

    Private Sub buttonInsert_Click(sender As Object, e As EventArgs) Handles buttonInsert.Click
        ' Can only insert if something is already selected
        If kryptonCheckedListBox.SelectedIndex >= 0 Then
            kryptonCheckedListBox.Items.Insert(kryptonCheckedListBox.SelectedIndex, CreateNewItem())
        End If
    End Sub

    Private Sub buttonRemove_Click(sender As Object, e As EventArgs) Handles buttonRemove.Click
        ' Can only remove if something is selected
        If kryptonCheckedListBox.SelectedIndex >= 0 Then
            ' Find the new index to select
            Dim index As Integer = kryptonCheckedListBox.SelectedIndex
            If index = (kryptonCheckedListBox.Items.Count - 1) Then
                index -= 1
            End If

            ' Remove entry
            kryptonCheckedListBox.Items.RemoveAt(kryptonCheckedListBox.SelectedIndex)

            ' Select the new item
            If index < kryptonCheckedListBox.Items.Count Then
                kryptonCheckedListBox.SelectedIndex = index
            End If
        End If
    End Sub

    Private Sub buttonClear_Click(sender As Object, e As EventArgs) Handles buttonClear.Click
        kryptonCheckedListBox.Items.Clear()
    End Sub

    Private Sub kryptonCheckSet_CheckedButtonChanged(sender As Object, e As EventArgs) Handles kryptonCheckSet.CheckedButtonChanged
        If kryptonCheckSet.CheckedButton Is check2007Blue Then
            kryptonManager1.GlobalPaletteMode = PaletteMode.Office2007Blue
        ElseIf kryptonCheckSet.CheckedButton Is check2010Blue Then
            kryptonManager1.GlobalPaletteMode = PaletteMode.Office2010Blue
        ElseIf kryptonCheckSet.CheckedButton Is checkSparkle Then
            kryptonManager1.GlobalPaletteMode = PaletteMode.SparkleBlue
        ElseIf kryptonCheckSet.CheckedButton Is checkSystem Then
            kryptonManager1.GlobalPaletteMode = PaletteMode.ProfessionalSystem
        End If
    End Sub

    Private Sub buttonClose_Click(sender As Object, e As EventArgs) Handles buttonClose.Click
        Close()
    End Sub

End Class
