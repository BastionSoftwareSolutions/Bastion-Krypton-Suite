' *****************************************************************************
' BSD 3-Clause License (https://github.com/Krypton-Suite/Standard-Toolkit)
'  By Peter Wagner(aka Wagnerp) & Simon Coghlan(aka Smurf-IV) 2021 - 2024. All rights reserved.
' *****************************************************************************
' VB.NET twin of Source\Krypton Toolkit Examples\KryptonFontDialog Example\Form1.cs (Bastion Phase 4c).

Imports System.Drawing
Imports System.Windows.Forms

Imports Krypton.Toolkit

Public Class Form1

    Public Sub New()
        InitializeComponent()
        fontLast = Font
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

    Private Sub FolderBrowserDialog1_HelpRequest(sender As Object, e As EventArgs)

    End Sub

    Private fontLast As Font

    Private Sub ButtonShowFontDialog_Click(sender As Object, e As EventArgs) Handles buttonShowFontDialog.Click
        Dim kfd As New KryptonFontDialog With {
            .ShowColor = chkShowColour.Checked,
            .ShowHelp = chkShowHelp.Checked,
            .AllowScriptChange = chkAllowScriptChange.Checked,
            .AllowSimulations = chkAllowSimulations.Checked,
            .AllowVectorFonts = chkAllowVectorFonts.Checked,
            .ShowApply = chkShowApply.Checked,
            .ShowEffects = chkShowEffects.Checked,
            .Font = fontLast,
            .Title = "Test Font Dialog being set",
            .DisplayIsPrinterFontDescription = True,
            .DisplayExtendedColorsButton = chklShowExtendedColours.Checked,
            .ShowIcon = chkShowIcon.Checked
        }
        kfd.Color = Color.DarkOliveGreen
        If kfd.ShowDialog(Me) = DialogResult.OK Then
            KryptonMessageBox.Show(Me, kfd.Font.ToString(), "Font chosen is")
            fontLast = kfd.Font
        End If
    End Sub

    Private Sub KryptonColorButton1_SelectedColorChanged(sender As Object, e As ColorEventArgs) Handles kryptonColorButton1.SelectedColorChanged

    End Sub

End Class
