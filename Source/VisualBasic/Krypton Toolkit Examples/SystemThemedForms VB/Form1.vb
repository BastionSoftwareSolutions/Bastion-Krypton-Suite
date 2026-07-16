' *****************************************************************************
' BSD 3-Clause License (https://github.com/ComponentFactory/Krypton/blob/master/LICENSE)
'  © Component Factory Pty Ltd, 2006-2016, All rights reserved.
'  By Peter Wagner(aka Wagnerp) & Simon Coghlan(aka Smurf-IV), tobitege 2017 - 2025. All rights reserved. (https://github.com/Krypton-Suite/Standard-Toolkit)
'  Version 5.550.0  www.ComponentFactory.com
' *****************************************************************************
' VB.NET twin of Source\Krypton Toolkit Examples\SystemThemedForms\Form1.cs (Bastion Phase 4c).

Imports System.Drawing

Imports Krypton.Toolkit

Public Class Form1

    Public Sub New()
        InitializeComponent()
        ' Dynamic wiring, mirroring the C# twin (which hooks this in the constructor
        ' rather than through the designer).
        AddHandler buttonSpecAny1.Click, AddressOf ButtonSpecAny1_Click
        button4.BackColor = SystemColors.InactiveCaption
        button5.BackColor = SystemColors.ActiveCaption
        button6.BackColor = SystemColors.GradientActiveCaption
        button7.BackColor = SystemColors.GradientInactiveCaption
        button8.BackColor = SystemColors.WindowFrame
        'button9.BackColor = SystemColors.ActiveCaption
        'button10.BackColor = SystemColors.ActiveCaption
    End Sub

    Private Sub ButtonSpecAny1_Click(sender As Object, e As EventArgs)
        KryptonMessageBox.Show(Me, "FormButton Clicked")
    End Sub

    Private Sub button1_Click(sender As Object, e As EventArgs) Handles button1.Click
        Me.PaletteMode = Krypton.Toolkit.PaletteMode.ProfessionalSystem
    End Sub

    Private Sub button2_Click(sender As Object, e As EventArgs) Handles button2.Click
        Me.PaletteMode = Krypton.Toolkit.PaletteMode.Office2007Blue
    End Sub

    Private Sub button3_Click(sender As Object, e As EventArgs) Handles button3.Click
        Me.PaletteMode = Krypton.Toolkit.PaletteMode.ProfessionalOffice2003
    End Sub

End Class
