' *****************************************************************************
' BSD 3-Clause License (https://github.com/Krypton-Suite/Standard-Toolkit)
' By Peter Wagner(aka Wagnerp) & Simon Coghlan(aka Smurf-IV), tobitege 2023 - 2025. All rights reserved.
' *****************************************************************************
' VB.NET twin of Source\Krypton Toolkit Examples\KryptonProgressbar Examples\Form1.cs (Bastion Phase 4c).

Imports System
Imports System.Windows.Forms

Imports Krypton.Toolkit

Public Class Form1

    Private Sub kryptonButton1_Click(sender As Object, e As EventArgs) Handles kryptonButton1.Click
        Close()
    End Sub

    Private Sub Form1_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        For Each value As Object In [Enum].GetValues(GetType(ProgressBarStyle))
            kcmbProgressBarStyle.Items.Add(value)
        Next

        kcmbProgressBarStyle.SelectedIndex = 1

        For Each value As Object In [Enum].GetValues(GetType(PaletteColorStyle))
            kcmbColorStyle.Items.Add(value)
        Next

        kcmbColorStyle.SelectedItem = PaletteColorStyle.GlassNormalFull

        ktrkProgressValues.Value = 75
    End Sub

    Private Sub knudHorizontal_ValueChanged(sender As Object, e As EventArgs) Handles knudHorizontal.ValueChanged
        ktrkProgressValues.Value = CInt(knudHorizontal.Value)
        pbHorizontal.Value = ktrkProgressValues.Value
        pbHorizontal2.Value = ktrkProgressValues.Value
        pbCustomColor.Value = ktrkProgressValues.Value
        pbVertical.Value = ktrkProgressValues.Value
        ProgressBarDisabled.Value = ktrkProgressValues.Value
        kryptonProgressBarToolStripItem1.Value = ktrkProgressValues.Value
    End Sub

    Private Sub kchkUseProgressValueAsText_CheckedChanged(sender As Object, e As EventArgs) Handles kchkUseProgressValueAsText.CheckedChanged
        pbHorizontal.UseValueAsText = kchkUseProgressValueAsText.Checked
        pbHorizontal2.UseValueAsText = kchkUseProgressValueAsText.Checked
        pbCustomColor.UseValueAsText = kchkUseProgressValueAsText.Checked
        pbVertical.UseValueAsText = kchkUseProgressValueAsText.Checked
        ProgressBarDisabled.UseValueAsText = kchkUseProgressValueAsText.Checked
        kryptonProgressBarToolStripItem1.UseValueAsText = kchkUseProgressValueAsText.Checked
    End Sub

    Private Sub kcbtnBackdropColor_SelectedColorChanged(sender As Object, e As ColorEventArgs) Handles kcbtnBackdropColor.SelectedColorChanged
        pbHorizontal.TextBackdropColor = e.Color
        pbHorizontal2.TextBackdropColor = e.Color
        pbCustomColor.TextBackdropColor = e.Color
        pbVertical.TextBackdropColor = e.Color
        ProgressBarDisabled.TextBackdropColor = e.Color
        kryptonProgressBarToolStripItem1.KryptonProgressBarHost.TextBackdropColor = e.Color
    End Sub

    Private Sub kchkShowTextBackdrop_CheckedChanged(sender As Object, e As EventArgs) Handles kchkShowTextBackdrop.CheckedChanged
        pbHorizontal.ShowTextBackdrop = kchkShowTextBackdrop.Checked
        pbHorizontal2.ShowTextBackdrop = kchkShowTextBackdrop.Checked
        pbCustomColor.ShowTextBackdrop = kchkShowTextBackdrop.Checked
        pbVertical.ShowTextBackdrop = kchkShowTextBackdrop.Checked
        ProgressBarDisabled.ShowTextBackdrop = kchkShowTextBackdrop.Checked
        kryptonProgressBarToolStripItem1.KryptonProgressBarHost.ShowTextBackdrop = kchkShowTextBackdrop.Checked
    End Sub

    Private Sub kcmbProgressBarStyle_SelectedIndexChanged(sender As Object, e As EventArgs) Handles kcmbProgressBarStyle.SelectedIndexChanged
        Dim newStyle = CType([Enum].Parse(GetType(ProgressBarStyle), kcmbProgressBarStyle.Text), ProgressBarStyle)
        pbHorizontal.Style = newStyle
        pbHorizontal2.Style = newStyle
        pbCustomColor.Style = newStyle
        pbVertical.Style = newStyle
        ProgressBarDisabled.Style = newStyle
        kryptonProgressBarToolStripItem1.Style = newStyle
    End Sub

    Private Sub kcmbColorStyle_SelectedIndexChanged(sender As Object, e As EventArgs) Handles kcmbColorStyle.SelectedIndexChanged
        Dim newStyle = CType([Enum].Parse(GetType(PaletteColorStyle), kcmbColorStyle.Text), PaletteColorStyle)
        pbHorizontal.ValueBackColorStyle = newStyle
        pbHorizontal2.ValueBackColorStyle = newStyle
        pbCustomColor.ValueBackColorStyle = newStyle
        pbVertical.ValueBackColorStyle = newStyle
        ProgressBarDisabled.ValueBackColorStyle = newStyle
        kryptonProgressBarToolStripItem1.KryptonProgressBarHost.ValueBackColorStyle = newStyle
    End Sub

    Private Sub kchkShowTextShadow_CheckedChanged(sender As Object, e As EventArgs) Handles kchkShowTextShadow.CheckedChanged
        pbHorizontal.ShowTextShadow = kchkShowTextShadow.Checked
        pbHorizontal2.ShowTextShadow = kchkShowTextShadow.Checked
        pbCustomColor.ShowTextShadow = kchkShowTextShadow.Checked
        pbVertical.ShowTextShadow = kchkShowTextShadow.Checked
        ProgressBarDisabled.ShowTextShadow = kchkShowTextShadow.Checked
        kryptonProgressBarToolStripItem1.KryptonProgressBarHost.ShowTextShadow = kchkShowTextShadow.Checked
    End Sub

    Private Sub ktrkProgressValues_ValueChanged(sender As Object, e As EventArgs) Handles ktrkProgressValues.ValueChanged
        pbHorizontal.Value = ktrkProgressValues.Value
        pbHorizontal2.Value = ktrkProgressValues.Value
        pbCustomColor.Value = ktrkProgressValues.Value
        knudHorizontal.Value = ktrkProgressValues.Value
        pbVertical.Value = ktrkProgressValues.Value
        ProgressBarDisabled.Value = ktrkProgressValues.Value
        kryptonProgressBarToolStripItem1.Value = ktrkProgressValues.Value
    End Sub

    Private Sub kcbtnProgressBarColour_SelectedColorChanged(sender As Object, e As ColorEventArgs) Handles kcbtnProgressBarColour.SelectedColorChanged
        pbCustomColor.StateCommon.Back.Color1 = e.Color
    End Sub

End Class
