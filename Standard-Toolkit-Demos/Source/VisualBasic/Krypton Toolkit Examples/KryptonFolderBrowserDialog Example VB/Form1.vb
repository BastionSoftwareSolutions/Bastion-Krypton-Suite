' *****************************************************************************
' BSD 3-Clause License (https://github.com/Krypton-Suite/Standard-Toolkit)
'  By Peter Wagner(aka Wagnerp) & Simon Coghlan(aka Smurf-IV) 2021 - 2024. All rights reserved.
' *****************************************************************************
' VB.NET twin of Source\Krypton Toolkit Examples\KryptonFolderBrowserDialog Example\Form1.cs (Bastion Phase 4c).

Imports System.Windows.Forms

Imports Krypton.Toolkit

Public Class Form1

    Public Sub New()
        InitializeComponent()
    End Sub

    Private Sub ButtonShowFileDialog_Click(sender As Object, e As EventArgs) Handles buttonFileOpenDialog.Click
        ' RootFolder =
        ' SelectedPath =
        Using kfd As New KryptonFolderBrowserDialog() With {
            .Icon = Me.Icon,
            .Title = "Select a folder to use"
        }
            If kfd.ShowDialog(Me) = DialogResult.OK Then
                KryptonMessageBox.Show(Me, kfd.SelectedPath, "Directory chosen is")
            End If
        End Using
    End Sub

End Class
