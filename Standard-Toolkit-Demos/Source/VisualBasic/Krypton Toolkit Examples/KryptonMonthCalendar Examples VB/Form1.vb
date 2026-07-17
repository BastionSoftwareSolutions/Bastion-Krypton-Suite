#Region "BSD License"
'
' Original BSD 3-Clause License (https://github.com/ComponentFactory/Krypton/blob/master/LICENSE)
'  © Component Factory Pty Ltd, 2006 - 2016, (Version 4.5.0.0) All rights reserved.
'
'  New BSD 3-Clause License (https://github.com/Krypton-Suite/Standard-Toolkit/blob/master/LICENSE)
'  Modifications by Peter Wagner(aka Wagnerp) & Simon Coghlan(aka Smurf-IV), et al. 2017 - 2024. All rights reserved.
'
' VB.NET twin of Source\Krypton Toolkit Examples\KryptonMonthCalendar Examples\Form1.cs (Bastion Phase 4c).
#End Region

Imports System
Imports System.Windows.Forms

Imports Krypton.Toolkit

Public Class Form1

    Public Sub New()
        InitializeComponent()
    End Sub

    Private Sub rbOffice2010Blue_CheckedChanged(sender As Object, e As EventArgs) Handles rbOffice2010Blue.CheckedChanged
        kryptonManager1.GlobalPaletteMode = PaletteMode.Office2010Blue
    End Sub

    Private Sub rbOffice2010Silver_CheckedChanged(sender As Object, e As EventArgs) Handles rbOffice2010Silver.CheckedChanged
        kryptonManager1.GlobalPaletteMode = PaletteMode.Office2010Silver
    End Sub

    Private Sub rbOffice2010Black_CheckedChanged(sender As Object, e As EventArgs) Handles rbOffice2010Black.CheckedChanged
        kryptonManager1.GlobalPaletteMode = PaletteMode.Office2010Black
    End Sub

    Private Sub rbOffice2007Blue_CheckedChanged(sender As Object, e As EventArgs) Handles rbOffice2007Blue.CheckedChanged
        kryptonManager1.GlobalPaletteMode = PaletteMode.Office2007Blue
    End Sub

    Private Sub rbOffice2007Silver_CheckedChanged(sender As Object, e As EventArgs) Handles rbOffice2007Silver.CheckedChanged
        kryptonManager1.GlobalPaletteMode = PaletteMode.Office2007Silver
    End Sub

    Private Sub rbOffice2007Black_CheckedChanged(sender As Object, e As EventArgs) Handles rbOffice2007Black.CheckedChanged
        kryptonManager1.GlobalPaletteMode = PaletteMode.Office2007Black
    End Sub

    Private Sub rbSparkleBlue_CheckedChanged(sender As Object, e As EventArgs) Handles rbSparkleBlue.CheckedChanged
        kryptonManager1.GlobalPaletteMode = PaletteMode.SparkleBlue
    End Sub

    Private Sub rbSparkleOrange_CheckedChanged(sender As Object, e As EventArgs) Handles rbSparkleOrange.CheckedChanged
        kryptonManager1.GlobalPaletteMode = PaletteMode.SparkleOrange
    End Sub

    Private Sub rbSparklePurple_CheckedChanged(sender As Object, e As EventArgs) Handles rbSparklePurple.CheckedChanged
        kryptonManager1.GlobalPaletteMode = PaletteMode.SparklePurple
    End Sub

    Private Sub rbOffice2003_CheckedChanged(sender As Object, e As EventArgs) Handles rbOffice2003.CheckedChanged
        kryptonManager1.GlobalPaletteMode = PaletteMode.ProfessionalOffice2003
    End Sub

    Private Sub rbSystem_CheckedChanged(sender As Object, e As EventArgs) Handles rbSystem.CheckedChanged
        kryptonManager1.GlobalPaletteMode = PaletteMode.ProfessionalSystem
    End Sub

    Private Sub buttonClose_Click(sender As Object, e As EventArgs) Handles buttonClose.Click
        Close()
    End Sub

End Class
