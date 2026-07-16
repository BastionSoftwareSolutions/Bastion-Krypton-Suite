' *****************************************************************************
' BSD 3-Clause License (https://github.com/Krypton-Suite/Standard-Toolkit)
'  By Peter Wagner(aka Wagnerp) & Simon Coghlan(aka Smurf-IV), tobitege 2021 - 2025. All rights reserved.
' *****************************************************************************
' VB.NET twin of Source\Krypton Toolkit Examples\KryptonColorDialog Example\Form1.cs (Bastion Phase 4c).

Imports System
Imports System.Globalization
Imports System.Windows.Forms

Imports Krypton.Toolkit

Public Class Form1

    Public Sub New()
        InitializeComponent()
        Icon = My.Resources.Krypton
    End Sub

    Private Sub Palette2010Blue_CheckedChanged(sender As Object, e As EventArgs) Handles palette2010Blue.CheckedChanged
        kryptonManager.GlobalPaletteMode = PaletteMode.Office2010Blue
    End Sub

    Private Sub Palette2010Silver_CheckedChanged(sender As Object, e As EventArgs) Handles palette2010Silver.CheckedChanged
        kryptonManager.GlobalPaletteMode = PaletteMode.Office2010Silver
    End Sub

    Private Sub Palette2010Black_CheckedChanged(sender As Object, e As EventArgs) Handles palette2010Black.CheckedChanged
        kryptonManager.GlobalPaletteMode = PaletteMode.Office2010Black
    End Sub

    Private Sub Palette2007Blue_CheckedChanged(sender As Object, e As EventArgs) Handles palette2007Blue.CheckedChanged
        kryptonManager.GlobalPaletteMode = PaletteMode.Office2007Blue
    End Sub

    Private Sub PaletteSparkleOrange_CheckedChanged(sender As Object, e As EventArgs) Handles paletteSparkleOrange.CheckedChanged
        kryptonManager.GlobalPaletteMode = PaletteMode.SparkleOrange
    End Sub

    Private Sub PaletteProfessional_CheckedChanged(sender As Object, e As EventArgs) Handles paletteProfessional.CheckedChanged
        kryptonManager.GlobalPaletteMode = PaletteMode.ProfessionalSystem
    End Sub

    Private customColors As Integer() = Array.Empty(Of Integer)()

    Private Sub ButtonShowFontDialog_Click(sender As Object, e As EventArgs) Handles buttonShowFontDialog.Click
        Dim kfd = New Krypton.Toolkit.KryptonColorDialog With {
            .AllowFullOpen = chkAllowFullOpen.Checked,
            .ShowHelp = chkShowHelp.Checked,
            .AnyColor = chkAnyColor.Checked,
            .FullOpen = chkFullOPen.Checked,
            .SolidColorOnly = chkSolidColorOnly.Checked,
            .CustomColors = customColors,
            .Title = "Test Colour Dialog being set",
            .ShowIcon = chkShowIcon.Checked,
            .ShowAlphaSlider = chkShowAlphaSlider.Checked
        } ' Note: the C# twin also carries a commented-out "Icon = Icon" initializer entry.
        If kfd.ShowDialog(Me) = DialogResult.OK Then
            KryptonMessageBox.Show(Me, kfd.Color.ToString(), "Color chosen is")
            customColors = kfd.CustomColors
        End If
    End Sub

    Private Sub kryptonTrackBar1_Validating(sender As Object, e As System.ComponentModel.CancelEventArgs)
    End Sub

    Private Sub kryptonTrackBar1_ValueChanged(sender As Object, e As EventArgs) Handles kryptonTrackBar1.ValueChanged
        kryptonLabel1.Text = kryptonTrackBar1.Value.ToString(CultureInfo.InvariantCulture)
    End Sub
    'kryptonTrackBar1.ToolTipManager

End Class
