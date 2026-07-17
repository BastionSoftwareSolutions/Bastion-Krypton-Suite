' *****************************************************************************
' BSD 3-Clause License (https://github.com/Krypton-Suite/Standard-Toolkit)
'  By Peter Wagner(aka Wagnerp) & Simon Coghlan(aka Smurf-IV) 2023 - 2024. All rights reserved.
' *****************************************************************************
' VB.NET twin of Source\Krypton Toolkit Examples\KryptonOpenFileDialog Example\Form1.cs (Bastion Phase 4c).

Imports System
Imports System.Windows.Forms

Imports Krypton.Toolkit

Public Class Form1

    Public Sub New()
        InitializeComponent()
    End Sub

    ' NOTE: mirrors the C# twin, where this handler is not wired to any control in the designer.
    ' The C# twin keeps these initializer entries commented out:
    '   AutoUpgradeEnabled = true (N/A), FileName = "", Container = { }, CustomPlaces = { }
    ' and notes that ReadOnlyChecked is "Get only".
    Private Sub ButtonShowFileDialog_Click(sender As Object, e As EventArgs)
        Using kfd As New KryptonOpenFileDialog With {
            .AddExtension = chkAddExtension.Checked,
            .CheckFileExists = chkCheckFileExists.Checked,
            .CheckPathExists = chkCheckPathExists.Checked,
            .DefaultExt = "PNG",
            .DereferenceLinks = chkDereferenceLinks.Checked,
            .Filter = "Image Files(*.BMP;*.JPG;*.GIF)|*.BMP;*.JPG;*.GIF",
            .FilterIndex = 0,
            .InitialDirectory = "",
            .Multiselect = chkMultiselect.Checked,
            .ReadOnlyChecked = chkReadOnlyChecked.Checked,
            .RestoreDirectory = chkRestoreDirectory.Checked,
            .SupportMultiDottedExtensions = True,
            .Title = "Select a File to Open",
            .ValidateNames = True,
            .Icon = Me.Icon
        }
            If kfd.ShowDialog(Me) = DialogResult.OK Then
                KryptonMessageBox.Show(Me, kfd.FileName, "File chosen is")
            End If
        End Using
    End Sub

End Class
