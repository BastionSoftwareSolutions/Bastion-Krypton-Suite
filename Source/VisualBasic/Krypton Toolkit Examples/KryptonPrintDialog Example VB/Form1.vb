' *****************************************************************************
' BSD 3-Clause License (https://github.com/Krypton-Suite/Standard-Toolkit)
'  By Peter Wagner(aka Wagnerp) & Simon Coghlan(aka Smurf-IV), tobitege 2021 - 2025. All rights reserved.
' *****************************************************************************
' VB.NET twin of Source\Krypton Toolkit Examples\KryptonPrintDialog Example\Form1.cs (Bastion Phase 4c).

Imports System
Imports System.Windows.Forms

Imports Krypton.Toolkit

Public Class Form1

    Public Sub New()
        InitializeComponent()
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

    Private Sub ButtonShowFontDialog_Click(sender As Object, e As EventArgs) Handles buttonShowFontDialog.Click
        'PrintDialog
        Dim docToPrint As New System.Drawing.Printing.PrintDocument()
        AddHandler docToPrint.PrintPage, AddressOf DocToPrint_PrintPage
        ' The C# twin keeps UseEXDialog = chkUseEXDialog.Checked commented out in the
        ' initializer: currently there is not a kryptonised version.
        Dim kfd As New KryptonPrintDialog With {
            .ShowHelp = chkShowHelp.Checked,
            .AllowCurrentPage = chkAllowCurrentPage.Checked,
            .AllowPrintToFile = chkAllowPrintToFile.Checked,
            .AllowSelection = chkAllowSelection.Checked,
            .AllowSomePages = chkAllowSomePages.Checked,
            .ShowNetwork = chkShowNetwork.Checked,
            .Document = docToPrint,
            .Title = "Test Print Dialog being set",
            .ShowIcon = chkShowIcon.Checked
        }
        If kfd.ShowDialog(Me) = DialogResult.OK Then
            KryptonMessageBox.Show(Me, "Now call docToPrint.Print();")
        End If
    End Sub

    Private Sub DocToPrint_PrintPage(sender As Object, e As System.Drawing.Printing.PrintPageEventArgs)
        ' Insert code to render the page here.
        ' This code will be called when the control is drawn.

        ' The following code will render a simple
        ' message on the printed document.
        Dim text As String = "In document_PrintPage method."
        Dim printFont As New System.Drawing.Font(
            "Arial", 35, System.Drawing.FontStyle.Regular)

        ' Draw the content.
        e?.Graphics?.DrawString(text, printFont,
            System.Drawing.Brushes.Black, 10, 10)
    End Sub

End Class
