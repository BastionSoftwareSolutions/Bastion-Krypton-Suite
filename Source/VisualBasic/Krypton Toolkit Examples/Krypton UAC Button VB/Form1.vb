' *****************************************************************************
' BSD 3-Clause License (https://github.com/Krypton-Suite/Standard-Toolkit)
'  By Peter Wagner(aka Wagnerp) & Simon Coghlan(aka Smurf-IV) 2021 - 2024. All rights reserved.
' *****************************************************************************
' VB.NET twin of Source\Krypton Toolkit Examples\Krypton UAC Button\Form1.cs (Bastion Phase 4c).

Imports System

Imports Krypton.Toolkit

Public Class Form1

    Public Sub New()
        InitializeComponent()
    End Sub

    Private Sub kchkShowUACShield_CheckedChanged(sender As Object, e As EventArgs) Handles kchkShowUACShield.CheckedChanged
        kbtnTest.Values.UseAsUACElevationButton = kchkShowUACShield.Checked
    End Sub

    Private Sub kbtnTest_Click(sender As Object, e As EventArgs) Handles kbtnTest.Click
        KryptonMessageBox.Show("UAC elevation requires developer input.", "UAC Button Example",
            KryptonMessageBoxButtons.OK, KryptonMessageBoxIcon.Shield)
    End Sub

End Class
