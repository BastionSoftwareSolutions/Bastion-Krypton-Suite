' *****************************************************************************
' BSD 3-Clause License (https://github.com/Krypton-Suite/Standard-Toolkit)
'  By Peter Wagner(aka Wagnerp) & Simon Coghlan(aka Smurf-IV) 2022 - 2024. All rights reserved.
' *****************************************************************************
' VB.NET twin of Source\Krypton Toolkit Examples\Krypton Theme Selector\Form1.cs (Bastion Phase 4c).

Imports System.Windows.Forms

Imports Krypton.Toolkit

Public Class Form1

    Public Sub New()
        InitializeComponent()
    End Sub

    Private Sub kbtnUseListBox_Click(sender As Object, e As System.EventArgs) Handles kbtnUseListBox.Click
        Dim themeBrowserData As New KryptonThemeBrowserData() With {
            .ShowImportButton = True,
            .ShowSilentOption = True,
            .StartIndex = 0,
            .StartPosition = FormStartPosition.CenterScreen,
            .WindowTitle = String.Empty
        }

        KryptonThemeBrowser.Show(themeBrowserData)
    End Sub

End Class
