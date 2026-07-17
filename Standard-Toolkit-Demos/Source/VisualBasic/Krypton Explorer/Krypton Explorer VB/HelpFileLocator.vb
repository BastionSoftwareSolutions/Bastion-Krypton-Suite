' VB.NET twin of Source\Krypton Explorer\HelpFileLocator.cs (Bastion Phase 4c).

Imports System
Imports System.Collections.Generic
Imports System.ComponentModel
Imports System.Data
Imports System.Drawing
Imports System.IO
Imports System.Linq
Imports System.Text
Imports System.Threading.Tasks
Imports System.Windows.Forms

Imports Krypton.Toolkit

Public Class HelpFileLocator

    Private _settings As New Properties.Settings()

    Public Sub New()
        InitializeComponent()
    End Sub

    Private Sub kcmdBrowseForFile_Execute(sender As Object, e As EventArgs) Handles kcmdBrowseForFile.Execute
        Dim ofd = New OpenFileDialog() With {
            .Title = "Browse for Help File:",
            .Filter = "Compiled HTML Help Files|*.chm"
        }

        If ofd.ShowDialog() = DialogResult.OK Then
            ktxtHelpFilePath.Text = Path.GetFullPath(ofd.FileName)
        End If
    End Sub

    Private Sub kbtnOk_Click(sender As Object, e As EventArgs) Handles kbtnOk.Click
        If Not String.IsNullOrEmpty(ktxtHelpFilePath.Text) Then
            _settings.HelpFileLocation = ktxtHelpFilePath.Text

            _settings.Save()
        End If
    End Sub

End Class
