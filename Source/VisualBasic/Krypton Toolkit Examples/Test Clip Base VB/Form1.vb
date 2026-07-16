' *****************************************************************************
' BSD 3-Clause License (https://github.com/Krypton-Suite/Standard-Toolkit)
'  By Peter Wagner(aka Wagnerp) & Simon Coghlan(aka Smurf-IV) 2017 - 2024. All rights reserved.
' *****************************************************************************
' VB.NET twin of Source\Krypton Toolkit Examples\Test Clip Base\Form1.cs (Bastion Phase 4c).

Imports System.Windows.Forms

Public Class Form1

    Public Sub New()
        InitializeComponent()
    End Sub

    ' Kept for parity with the C# twin: the handler exists there but is not wired
    ' up by the designer, so it carries no Handles clause here either.
    Private Sub kryptonLabel2_Paint(sender As Object, e As PaintEventArgs)

    End Sub

    Private Sub KryptonButton1_Click(sender As Object, e As System.EventArgs) Handles kryptonButton1.Click
        kryptonButton1.Text = "Changed"
        Using fm2 As New Form2()
            fm2.ShowDialog(Me)
        End Using
    End Sub

End Class
