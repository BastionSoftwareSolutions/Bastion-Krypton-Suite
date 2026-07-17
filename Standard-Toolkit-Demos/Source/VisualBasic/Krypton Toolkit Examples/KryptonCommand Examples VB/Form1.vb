#Region "BSD License"
'
' Original BSD 3-Clause License (https://github.com/ComponentFactory/Krypton/blob/master/LICENSE)
'  © Component Factory Pty Ltd, 2006 - 2016, (Version 4.5.0.0) All rights reserved.
'
'  New BSD 3-Clause License (https://github.com/Krypton-Suite/Standard-Toolkit/blob/master/LICENSE)
'  Modifications by Peter Wagner(aka Wagnerp) & Simon Coghlan(aka Smurf-IV), tobitege et al. 2017 - 2025. All rights reserved.
'
' VB.NET twin of Source\Krypton Toolkit Examples\KryptonCommand Examples\Form1.cs (Bastion Phase 4c).
#End Region

Imports System
Imports System.Windows.Forms

Imports Krypton.Toolkit

Public Class Form1

    Private Sub buttonAttach_Click(sender As Object, e As EventArgs) Handles buttonAttach.Click
        AssignCommand(kryptonCommand)
    End Sub

    Private Sub buttonUnattach_Click(sender As Object, e As EventArgs) Handles buttonUnattach.Click
        AssignCommand(Nothing)
    End Sub

    Private Sub AssignCommand(command As KryptonCommand)
        buttonSpecAny1.KryptonCommand = command
        kryptonButton1.KryptonCommand = command
        kryptonCheckButton1.KryptonCommand = command
        kryptonDropButton1.KryptonCommand = command
        kryptonColorButton1.KryptonCommand = command
        kryptonLabel1.KryptonCommand = command
        kryptonLinkLabel1.KryptonCommand = command
        kryptonCheckBox1.KryptonCommand = command
    End Sub

    Private Sub buttonClose_Click(sender As Object, e As EventArgs) Handles buttonClose.Click
        Close()
    End Sub

End Class
