' *****************************************************************************
' BSD 3-Clause License (https://github.com/Krypton-Suite/Standard-Toolkit)
'  By Peter Wagner(aka Wagnerp) & Simon Coghlan(aka Smurf-IV), tobitege 2021 - 2025. All rights reserved.
' *****************************************************************************
' VB.NET twin of Source\Krypton Toolkit Examples\KryptonHelpIcon Examples\Form1.cs (Bastion Phase 4c).

Imports Krypton.Toolkit

Public Class Form1

    Public Sub New()
        InitializeComponent()
    End Sub

    Private Sub BsHelpIcon_Click(sender As Object, e As EventArgs) Handles bsHelpIcon.Click
        KryptonMessageBox.Show("You have requested help... Please enter your code here.", "Help Demo",
            KryptonMessageBoxButtons.OK, KryptonMessageBoxIcon.Information)
    End Sub

    Private Sub Form1_Load(sender As Object, e As EventArgs) Handles MyBase.Load
    End Sub

End Class
