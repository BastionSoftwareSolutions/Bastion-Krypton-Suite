' *****************************************************************************
' BSD 3-Clause License (https://github.com/Krypton-Suite/Standard-Toolkit)
'  By Peter Wagner(aka Wagnerp) & Simon Coghlan(aka Smurf-IV) 2021 - 2024. All rights reserved.
' *****************************************************************************
' VB.NET twin of Source\Krypton Toolkit Examples\KryptonAboutBox Example\Form1.cs (Bastion Phase 4c).

Imports System.IO
Imports System.Reflection
Imports System.Windows.Forms

Imports Krypton.Toolkit

Public Class Form1

    Public Sub New()
        InitializeComponent()
    End Sub

    Private Sub kbtnShow_Click(sender As Object, e As System.EventArgs) Handles kbtnShow.Click
        Dim currentAssembly As Assembly

        If Not String.IsNullOrEmpty(ktxtAssemblyLocation.Text) Then
            currentAssembly = Assembly.LoadFrom(ktxtAssemblyLocation.Text)
        Else
            currentAssembly = Assembly.GetExecutingAssembly()
        End If

        Dim data As New KryptonAboutBoxData() With {.CurrentAssembly = currentAssembly}

        KryptonAboutBox.Show(data)
    End Sub

    Private Sub kcBrowseForAssembly_Execute(sender As Object, e As System.EventArgs) Handles kcBrowseForAssembly.Execute
        Dim dialog As New KryptonOpenFileDialog()

        If dialog.ShowDialog() = DialogResult.OK Then
            ktxtAssemblyLocation.Text = Path.GetFullPath(dialog.FileName)
        End If
    End Sub

End Class
