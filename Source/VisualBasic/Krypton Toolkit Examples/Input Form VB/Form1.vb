#Region "BSD License"
'
' Original BSD 3-Clause License (https://github.com/ComponentFactory/Krypton/blob/master/LICENSE)
'  © Component Factory Pty Ltd, 2006 - 2016, (Version 4.5.0.0) All rights reserved.
'
'  New BSD 3-Clause License (https://github.com/Krypton-Suite/Standard-Toolkit/blob/master/LICENSE)
'  Modifications by Peter Wagner(aka Wagnerp) & Simon Coghlan(aka Smurf-IV), et al. 2017 - 2024. All rights reserved.
'
' VB.NET twin of Source\Krypton Toolkit Examples\Input Form\Form1.cs (Bastion Phase 4c).
#End Region

Imports System

Imports Krypton.Toolkit

Public Class Form1

    Public Sub New()
        InitializeComponent()
    End Sub

    Private Sub office2010_Click(sender As Object, e As EventArgs) Handles toolStripOffice2010.Click, office2010MenuItem.Click
        kryptonManager1.GlobalPaletteMode = PaletteMode.Office2010Blue
        toolStripOffice2010.Checked = True
        toolStripOffice2007.Checked = False
        toolStripSystem.Checked = False
        toolStripSparkle.Checked = False
        office2010MenuItem.Checked = True
        office2007MenuItem.Checked = False
        systemMenuItem.Checked = False
        sparkleMenuItem.Checked = False
    End Sub

    Private Sub office2007_Click(sender As Object, e As EventArgs) Handles toolStripOffice2007.Click, office2007MenuItem.Click
        kryptonManager1.GlobalPaletteMode = PaletteMode.Office2007Blue
        toolStripOffice2010.Checked = False
        toolStripOffice2007.Checked = True
        toolStripSystem.Checked = False
        toolStripSparkle.Checked = False
        office2010MenuItem.Checked = False
        office2007MenuItem.Checked = True
        systemMenuItem.Checked = False
        sparkleMenuItem.Checked = False
    End Sub

    Private Sub sparkle_Click(sender As Object, e As EventArgs) Handles toolStripSparkle.Click, sparkleMenuItem.Click
        kryptonManager1.GlobalPaletteMode = PaletteMode.SparkleBlue
        toolStripOffice2010.Checked = False
        toolStripOffice2007.Checked = False
        toolStripSystem.Checked = False
        toolStripSparkle.Checked = True
        office2010MenuItem.Checked = False
        office2007MenuItem.Checked = False
        systemMenuItem.Checked = False
        sparkleMenuItem.Checked = True
    End Sub

    Private Sub system_Click(sender As Object, e As EventArgs) Handles toolStripSystem.Click, systemMenuItem.Click
        kryptonManager1.GlobalPaletteMode = PaletteMode.ProfessionalSystem
        toolStripOffice2010.Checked = False
        toolStripOffice2007.Checked = False
        toolStripSystem.Checked = True
        toolStripSparkle.Checked = False
        office2010MenuItem.Checked = False
        office2007MenuItem.Checked = False
        systemMenuItem.Checked = True
        sparkleMenuItem.Checked = False
    End Sub

    Private Sub clearTelephone_Click(sender As Object, e As EventArgs) Handles clearTelephone.Click
        maskedTextBoxTelephone.Text = String.Empty
    End Sub

    Private Sub exitToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles exitToolStripMenuItem.Click, buttonCancel.Click
        Close()
    End Sub

    Private Sub buttonOK_Click(sender As Object, e As EventArgs) Handles buttonOK.Click
        Dim data As New KryptonInputBoxData() With {.Caption = textBoxName.Text}

        KryptonInputBox.Show(data)
    End Sub

End Class
