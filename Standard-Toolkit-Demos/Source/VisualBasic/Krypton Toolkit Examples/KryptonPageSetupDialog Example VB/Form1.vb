' *****************************************************************************
' BSD 3-Clause License (https://github.com/Krypton-Suite/Standard-Toolkit)
'  By Peter Wagner(aka Wagnerp) & Simon Coghlan(aka Smurf-IV) 2021 - 2024. All rights reserved.
' *****************************************************************************
' VB.NET twin of Source\Krypton Toolkit Examples\KryptonPageSetupDialog Example\Form1.cs (Bastion Phase 4c).

Imports System
Imports System.Windows.Forms

Imports Krypton.Toolkit

Public Class Form1

    Public Sub New()
        InitializeComponent()
    End Sub

    ' NOTE: mirrors the C# twin, where this handler is not wired to any control in the designer.
    Private Sub FolderBrowserDialog1_HelpRequest(sender As Object, e As EventArgs)

    End Sub

    Private Sub ButtonShowFontDialog_Click(sender As Object, e As EventArgs) Handles buttonShowFontDialog.Click
        Dim kfd As New Krypton.Toolkit.KryptonFontDialog With {
            .ShowColor = chkShowColour.Checked,
            .ShowHelp = chkShowHelp.Checked,
            .AllowScriptChange = chkAllowScriptChange.Checked,
            .AllowSimulations = chkAllowSimulations.Checked,
            .AllowVectorFonts = chkAllowVectorFonts.Checked,
            .ShowApply = chkShowApply.Checked,
            .ShowEffects = chkShowEffects.Checked
        }
        If kfd.ShowDialog(Me) = DialogResult.OK Then
            KryptonMessageBox.Show(Me, kfd.Font.ToString(), "Font chosen is")
        End If
    End Sub

End Class
