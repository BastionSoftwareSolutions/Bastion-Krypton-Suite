#Region "BSD License"
'
' Original BSD 3-Clause License (https://github.com/ComponentFactory/Krypton/blob/master/LICENSE)
'  © Component Factory Pty Ltd, 2006 - 2016, (Version 4.5.0.0) All rights reserved.
'
'  New BSD 3-Clause License (https://github.com/Krypton-Suite/Standard-Toolkit/blob/master/LICENSE)
'  Modifications by Peter Wagner(aka Wagnerp) & Simon Coghlan(aka Smurf-IV), et al. 2017 - 2024. All rights reserved.
'
' VB.NET twin of Source\Krypton Toolkit Examples\Three Pane Application (Basic)\Form1.cs (Bastion Phase 4c).
#End Region

Imports Krypton.Toolkit

Public Class Form1

    Public Sub New()
        InitializeComponent()
    End Sub

    Private Sub kryptonOffice2010Blue_CheckedChanged(sender As Object, e As EventArgs) Handles kryptonOffice2010Blue.CheckedChanged
        If kryptonOffice2010Blue.Checked Then
            kryptonManager.GlobalPaletteMode = PaletteMode.Office2010Blue
        End If
    End Sub

    Private Sub kryptonOffice2010Silver_CheckedChanged(sender As Object, e As EventArgs) Handles kryptonOffice2010Silver.CheckedChanged
        If kryptonOffice2010Silver.Checked Then
            kryptonManager.GlobalPaletteMode = PaletteMode.Office2010Silver
        End If
    End Sub

    Private Sub kryptonOffice2010Black_CheckedChanged(sender As Object, e As EventArgs) Handles kryptonOffice2010Black.CheckedChanged
        If kryptonOffice2010Black.Checked Then
            kryptonManager.GlobalPaletteMode = PaletteMode.Office2010Black
        End If
    End Sub

    Private Sub kryptonOffice2007Blue_CheckedChanged(sender As Object, e As EventArgs) Handles kryptonOffice2007Blue.CheckedChanged
        If kryptonOffice2007Blue.Checked Then
            kryptonManager.GlobalPaletteMode = PaletteMode.Office2007Blue
        End If
    End Sub

    Private Sub kryptonOffice2007Silver_CheckedChanged(sender As Object, e As EventArgs) Handles kryptonOffice2007Silver.CheckedChanged
        If kryptonOffice2007Silver.Checked Then
            kryptonManager.GlobalPaletteMode = PaletteMode.Office2007Silver
        End If
    End Sub

    Private Sub kryptonOffice2007Black_CheckedChanged(sender As Object, e As EventArgs) Handles kryptonOffice2007Black.CheckedChanged
        If kryptonOffice2007Black.Checked Then
            kryptonManager.GlobalPaletteMode = PaletteMode.Office2007Black
        End If
    End Sub

    Private Sub kryptonOffice2003_CheckedChanged(sender As Object, e As EventArgs) Handles kryptonOffice2003.CheckedChanged
        If kryptonOffice2003.Checked Then
            kryptonManager.GlobalPaletteMode = PaletteMode.ProfessionalOffice2003
        End If
    End Sub

    Private Sub kryptonSystem_CheckedChanged(sender As Object, e As EventArgs) Handles kryptonSystem.CheckedChanged
        If kryptonSystem.Checked Then
            kryptonManager.GlobalPaletteMode = PaletteMode.ProfessionalSystem
        End If
    End Sub

    Private Sub kryptonSparkleBlue_CheckedChanged(sender As Object, e As EventArgs) Handles kryptonSparkleBlue.CheckedChanged
        If kryptonSparkleBlue.Checked Then
            kryptonManager.GlobalPaletteMode = PaletteMode.SparkleBlue
        End If
    End Sub

    Private Sub kryptonSparkleOrange_CheckedChanged(sender As Object, e As EventArgs) Handles kryptonSparkleOrange.CheckedChanged
        If kryptonSparkleOrange.Checked Then
            kryptonManager.GlobalPaletteMode = PaletteMode.SparkleOrange
        End If
    End Sub

    Private Sub kryptonSparklePurple_CheckedChanged(sender As Object, e As EventArgs) Handles kryptonSparklePurple.CheckedChanged
        If kryptonSparklePurple.Checked Then
            kryptonManager.GlobalPaletteMode = PaletteMode.SparklePurple
        End If
    End Sub

    Private Sub kryptonCustom_CheckedChanged(sender As Object, e As EventArgs) Handles kryptonCustom.CheckedChanged
        If kryptonCustom.Checked Then
            kryptonManager.GlobalCustomPalette = kryptonPaletteCustom
        End If
    End Sub

    Private Sub kryptonOffice2013White_CheckedChanged(sender As Object, e As EventArgs) Handles kryptonOffice2013White.CheckedChanged
        If kryptonOffice2013White.Checked Then
            kryptonManager.GlobalPaletteMode = PaletteMode.Office2013White
        End If
    End Sub

End Class
