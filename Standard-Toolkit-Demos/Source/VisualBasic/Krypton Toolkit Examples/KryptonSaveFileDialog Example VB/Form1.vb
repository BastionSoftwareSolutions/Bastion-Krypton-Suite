' *****************************************************************************
' BSD 3-Clause License (https://github.com/Krypton-Suite/Standard-Toolkit)
'  By Peter Wagner(aka Wagnerp) & Simon Coghlan(aka Smurf-IV) 2020 - 2024. All rights reserved.
' *****************************************************************************
' VB.NET twin of Source\Krypton Toolkit Examples\KryptonSaveFileDialog Example\Form1.cs (Bastion Phase 4c).

Imports System
Imports System.Windows.Forms

Imports Krypton.Toolkit

Public Class Form1

    Private Sub ButtonShowFileDialog_Click(sender As Object, e As EventArgs) Handles buttonFileOpenDialog.Click
        ' AutoUpgradeEnabled, FileName, Container and CustomPlaces are not applicable here.
        Using kfd As New KryptonSaveFileDialog() With {
            .AddExtension = chkAddExtension.Checked,
            .CheckFileExists = chkCheckFileExists.Checked,
            .CheckPathExists = chkCheckPathExists.Checked,
            .DefaultExt = "PNG",
            .DereferenceLinks = chkDereferenceLinks.Checked,
            .Filter = "Image Files(*.BMP;*.JPG;*.GIF)|*.BMP;*.JPG;*.GIF",
            .FilterIndex = 0,
            .InitialDirectory = "",
            .RestoreDirectory = chkRestoreDirectory.Checked,
            .SupportMultiDottedExtensions = True,
            .Title = "Name a File to Save",
            .ValidateNames = True,
            .Icon = Me.Icon
        }
            If kfd.ShowDialog(Me) = DialogResult.OK Then
                KryptonMessageBox.Show(Me, kfd.FileName, "File chosen is")
            End If
        End Using
    End Sub

End Class
