#Region "BSD License"
'
' Original BSD 3-Clause License (https://github.com/ComponentFactory/Krypton/blob/master/LICENSE)
'  © Component Factory Pty Ltd, 2006 - 2016, (Version 4.5.0.0) All rights reserved.
'
'  New BSD 3-Clause License (https://github.com/Krypton-Suite/Standard-Toolkit/blob/master/LICENSE)
'  Modifications by Peter Wagner(aka Wagnerp) & Simon Coghlan(aka Smurf-IV), tobitege et al. 2017 - 2025. All rights reserved.
'
' VB.NET twin of Source\Krypton Toolkit Examples\KryptonContextMenu Examples\Form1.cs (Bastion Phase 4c).
#End Region

Imports System
Imports System.Windows.Forms

Imports Krypton.Toolkit

Public Class Form1

    Private Sub Form1_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        comboBoxH.SelectedIndex = 2
        comboBoxV.SelectedIndex = 1
        kryptonThemeComboBox1.Items.Remove(kryptonThemeComboBox1.Items.Count - 1)    ' Remove the "Custom" option
        kryptonThemeComboBox1.SelectedIndex = 4
    End Sub

    Private Sub buttonShowHeadingsClick(sender As Object, e As EventArgs) Handles buttonShowHeadings.Click
        ShowMenu(buttonShowHeadings, kcmHeadings)
    End Sub

    Private Sub buttonShowSeparatorsClick(sender As Object, e As EventArgs) Handles buttonShowSeparators.Click
        ShowMenu(buttonShowSeparators, kcmSeparators)
    End Sub

    Private Sub buttonShowAlternateStyleClick(sender As Object, e As EventArgs) Handles buttonShowAlternateStyle.Click
        ShowMenu(buttonShowAlternateStyle, kcmAlternateStyle)
    End Sub

    Private Sub buttonSubMenusClick(sender As Object, e As EventArgs) Handles buttonSubMenus.Click
        ShowMenu(buttonSubMenus, kcmSubMenus)
    End Sub

    Private Sub buttonControls_Click(sender As Object, e As EventArgs) Handles buttonControls.Click
        ShowMenu(buttonControls, kcmControls)
    End Sub

    Private Sub buttonColors_Click(sender As Object, e As EventArgs) Handles buttonColors.Click
        ShowMenu(buttonColors, kcmColors)
    End Sub

    Private Sub buttonImageSelectClick(sender As Object, e As EventArgs) Handles buttonImageSelect.Click
        ShowMenu(buttonImageSelect, kcmImageSelect)
    End Sub

    Private Sub buttonCalendar_Click(sender As Object, e As EventArgs) Handles buttonCalendar.Click
        ShowMenu(buttonCalendar, kcmCalendar)
    End Sub

    Private Sub buttonShowEverythingClick(sender As Object, e As EventArgs) Handles buttonShowEverything.Click
        ShowMenu(buttonImageSelect, kcmEverything)
    End Sub

    Private Sub ShowMenu(c As Control, kcm As KryptonContextMenu)
        kcm.Show(c.RectangleToScreen(c.ClientRectangle),
                 CType([Enum].Parse(GetType(KryptonContextMenuPositionH), CStr(comboBoxH.SelectedItem)), KryptonContextMenuPositionH),
                 CType([Enum].Parse(GetType(KryptonContextMenuPositionV), CStr(comboBoxV.SelectedItem)), KryptonContextMenuPositionV))
    End Sub

End Class
