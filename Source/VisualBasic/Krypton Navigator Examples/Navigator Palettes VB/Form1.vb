#Region "BSD License"
'
' Original BSD 3-Clause License (https://github.com/ComponentFactory/Krypton/blob/master/LICENSE)
'  © Component Factory Pty Ltd, 2006 - 2016, (Version 4.5.0.0) All rights reserved.
'
'  New BSD 3-Clause License (https://github.com/Krypton-Suite/Standard-Toolkit/blob/master/LICENSE)
'  Modifications by Peter Wagner(aka Wagnerp) & Simon Coghlan(aka Smurf-IV), et al. 2017 - 2024. All rights reserved.
'
' VB.NET twin of Source\Krypton Navigator Examples\Navigator Palettes\Form1.cs (Bastion Phase 4c).
#End Region

Imports System
Imports System.Windows.Forms

Imports Krypton.Toolkit

Public Class Form1

    Private Sub Form1_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        UpdateFromNavigator()
    End Sub

    Private Sub radioOffice2010Blue_CheckedChanged(sender As Object, e As EventArgs) Handles radioOffice2010Blue.CheckedChanged
        If radioOffice2010Blue.Checked Then
            radioOffice2010Silver.Checked = False
            radioOffice2010Black.Checked = False
            radioOffice2007Blue.Checked = False
            radioOffice2007Silver.Checked = False
            radioOffice2007Black.Checked = False
            radioOffice2003.Checked = False
            radioSparkleBlue.Checked = False
            radioSparkleOrange.Checked = False
            radioSparklePurple.Checked = False
            radioBlogger.Checked = False
            radioLightweight.Checked = False
            kryptonNavigator1.PaletteMode = PaletteMode.Office2010Blue
            UpdateFromNavigator()
        End If
    End Sub

    Private Sub radioOffice2010Silver_CheckedChanged(sender As Object, e As EventArgs) Handles radioOffice2010Silver.CheckedChanged
        If radioOffice2010Silver.Checked Then
            radioOffice2010Blue.Checked = False
            radioOffice2010Black.Checked = False
            radioOffice2007Blue.Checked = False
            radioOffice2007Silver.Checked = False
            radioOffice2007Black.Checked = False
            radioOffice2003.Checked = False
            radioSparkleBlue.Checked = False
            radioSparkleOrange.Checked = False
            radioSparklePurple.Checked = False
            radioBlogger.Checked = False
            radioLightweight.Checked = False
            kryptonNavigator1.PaletteMode = PaletteMode.Office2010Silver
            UpdateFromNavigator()
        End If
    End Sub

    Private Sub radioOffice2010Black_CheckedChanged(sender As Object, e As EventArgs) Handles radioOffice2010Black.CheckedChanged
        If radioOffice2010Black.Checked Then
            radioOffice2010Blue.Checked = False
            radioOffice2010Silver.Checked = False
            radioOffice2007Blue.Checked = False
            radioOffice2007Silver.Checked = False
            radioOffice2007Black.Checked = False
            radioOffice2003.Checked = False
            radioSparkleBlue.Checked = False
            radioSparkleOrange.Checked = False
            radioSparklePurple.Checked = False
            radioBlogger.Checked = False
            radioLightweight.Checked = False
            kryptonNavigator1.PaletteMode = PaletteMode.Office2010Black
            UpdateFromNavigator()
        End If
    End Sub

    Private Sub radioOffice2007Blue_CheckedChanged(sender As Object, e As EventArgs) Handles radioOffice2007Blue.CheckedChanged
        If radioOffice2007Blue.Checked Then
            radioOffice2010Blue.Checked = False
            radioOffice2010Silver.Checked = False
            radioOffice2010Black.Checked = False
            radioOffice2007Silver.Checked = False
            radioOffice2007Black.Checked = False
            radioOffice2003.Checked = False
            radioSparkleBlue.Checked = False
            radioSparkleOrange.Checked = False
            radioSparklePurple.Checked = False
            radioBlogger.Checked = False
            radioLightweight.Checked = False
            kryptonNavigator1.PaletteMode = PaletteMode.Office2007Blue
            UpdateFromNavigator()
        End If
    End Sub

    Private Sub radioOffice2007Silver_CheckedChanged(sender As Object, e As EventArgs) Handles radioOffice2007Silver.CheckedChanged
        If radioOffice2007Silver.Checked Then
            radioOffice2010Blue.Checked = False
            radioOffice2010Silver.Checked = False
            radioOffice2010Black.Checked = False
            radioOffice2007Blue.Checked = False
            radioOffice2007Black.Checked = False
            radioOffice2003.Checked = False
            radioSparkleBlue.Checked = False
            radioSparkleOrange.Checked = False
            radioSparklePurple.Checked = False
            radioBlogger.Checked = False
            radioLightweight.Checked = False
            kryptonNavigator1.PaletteMode = PaletteMode.Office2007Silver
            UpdateFromNavigator()
        End If
    End Sub

    Private Sub radioOffice2007Black_CheckedChanged(sender As Object, e As EventArgs) Handles radioOffice2007Black.CheckedChanged
        If radioOffice2007Black.Checked Then
            radioOffice2010Blue.Checked = False
            radioOffice2010Silver.Checked = False
            radioOffice2010Black.Checked = False
            radioOffice2007Blue.Checked = False
            radioOffice2007Silver.Checked = False
            radioOffice2003.Checked = False
            radioSparkleBlue.Checked = False
            radioSparkleOrange.Checked = False
            radioSparklePurple.Checked = False
            radioBlogger.Checked = False
            radioLightweight.Checked = False
            kryptonNavigator1.PaletteMode = PaletteMode.Office2007Black
            UpdateFromNavigator()
        End If
    End Sub

    Private Sub radioSystem_CheckedChanged(sender As Object, e As EventArgs) Handles radioSystem.CheckedChanged
        If radioSystem.Checked Then
            radioOffice2010Blue.Checked = False
            radioOffice2010Silver.Checked = False
            radioOffice2010Black.Checked = False
            radioOffice2007Blue.Checked = False
            radioOffice2007Silver.Checked = False
            radioOffice2007Black.Checked = False
            radioOffice2003.Checked = False
            radioSparkleBlue.Checked = False
            radioSparkleOrange.Checked = False
            radioSparklePurple.Checked = False
            radioBlogger.Checked = False
            radioLightweight.Checked = False
            kryptonNavigator1.PaletteMode = PaletteMode.ProfessionalSystem
            UpdateFromNavigator()
        End If
    End Sub

    Private Sub radioOffice2003_CheckedChanged(sender As Object, e As EventArgs) Handles radioOffice2003.CheckedChanged
        If radioOffice2003.Checked Then
            radioOffice2010Blue.Checked = False
            radioOffice2010Silver.Checked = False
            radioOffice2010Black.Checked = False
            radioOffice2007Blue.Checked = False
            radioOffice2007Silver.Checked = False
            radioOffice2007Black.Checked = False
            radioSystem.Checked = False
            radioSparkleBlue.Checked = False
            radioSparkleOrange.Checked = False
            radioSparklePurple.Checked = False
            radioBlogger.Checked = False
            radioLightweight.Checked = False
            kryptonNavigator1.PaletteMode = PaletteMode.ProfessionalOffice2003
            UpdateFromNavigator()
        End If
    End Sub

    Private Sub radioSparkleBlue_CheckedChanged(sender As Object, e As EventArgs) Handles radioSparkleBlue.CheckedChanged
        If radioSparkleBlue.Checked Then
            radioOffice2010Blue.Checked = False
            radioOffice2010Silver.Checked = False
            radioOffice2010Black.Checked = False
            radioOffice2007Blue.Checked = False
            radioOffice2007Silver.Checked = False
            radioOffice2007Black.Checked = False
            radioSystem.Checked = False
            radioSparkleOrange.Checked = False
            radioSparklePurple.Checked = False
            radioBlogger.Checked = False
            radioLightweight.Checked = False
            radioOffice2003.Checked = False
            kryptonNavigator1.PaletteMode = PaletteMode.SparkleBlue
            UpdateFromNavigator()
        End If
    End Sub

    Private Sub radioSparkleOrange_CheckedChanged(sender As Object, e As EventArgs) Handles radioSparkleOrange.CheckedChanged
        If radioSparkleOrange.Checked Then
            radioOffice2010Blue.Checked = False
            radioOffice2010Silver.Checked = False
            radioOffice2010Black.Checked = False
            radioOffice2007Blue.Checked = False
            radioOffice2007Silver.Checked = False
            radioOffice2007Black.Checked = False
            radioSystem.Checked = False
            radioSparkleBlue.Checked = False
            radioSparklePurple.Checked = False
            radioBlogger.Checked = False
            radioLightweight.Checked = False
            radioOffice2003.Checked = False
            kryptonNavigator1.PaletteMode = PaletteMode.SparkleOrange
            UpdateFromNavigator()
        End If
    End Sub

    Private Sub radioSparklePurple_CheckedChanged(sender As Object, e As EventArgs) Handles radioSparklePurple.CheckedChanged
        If radioSparklePurple.Checked Then
            radioOffice2010Blue.Checked = False
            radioOffice2010Silver.Checked = False
            radioOffice2010Black.Checked = False
            radioOffice2007Blue.Checked = False
            radioOffice2007Silver.Checked = False
            radioOffice2007Black.Checked = False
            radioSystem.Checked = False
            radioBlogger.Checked = False
            radioSparkleBlue.Checked = False
            radioSparkleOrange.Checked = False
            radioLightweight.Checked = False
            radioOffice2003.Checked = False
            kryptonNavigator1.PaletteMode = PaletteMode.SparklePurple
            UpdateFromNavigator()
        End If
    End Sub

    Private Sub radioBlogger_CheckedChanged(sender As Object, e As EventArgs) Handles radioBlogger.CheckedChanged
        If radioBlogger.Checked Then
            radioOffice2010Blue.Checked = False
            radioOffice2010Silver.Checked = False
            radioOffice2010Black.Checked = False
            radioOffice2007Blue.Checked = False
            radioOffice2007Silver.Checked = False
            radioOffice2007Black.Checked = False
            radioSystem.Checked = False
            radioOffice2003.Checked = False
            radioSparkleBlue.Checked = False
            radioSparkleOrange.Checked = False
            radioSparklePurple.Checked = False
            radioLightweight.Checked = False
            kryptonNavigator1.LocalCustomPalette = kryptonPaletteBlogger
            UpdateFromNavigator()
        End If
    End Sub

    Private Sub radioLightweight_CheckedChanged(sender As Object, e As EventArgs) Handles radioLightweight.CheckedChanged
        If radioLightweight.Checked Then
            radioOffice2010Blue.Checked = False
            radioOffice2010Silver.Checked = False
            radioOffice2010Black.Checked = False
            radioOffice2007Blue.Checked = False
            radioOffice2007Silver.Checked = False
            radioOffice2007Black.Checked = False
            radioSystem.Checked = False
            radioSparkleBlue.Checked = False
            radioSparkleOrange.Checked = False
            radioSparklePurple.Checked = False
            radioBlogger.Checked = False
            kryptonNavigator1.LocalCustomPalette = kryptonPaletteLightweight
            UpdateFromNavigator()
        End If
    End Sub

    Private Sub buttonClose_Click(sender As Object, e As EventArgs) Handles buttonClose.Click
        Close()
    End Sub

    Private Sub UpdateFromNavigator()
        Select Case kryptonNavigator1.PaletteMode
            Case PaletteMode.ProfessionalSystem
                radioSystem.Checked = True
            Case PaletteMode.Global, PaletteMode.ProfessionalOffice2003
                radioOffice2003.Checked = True
            Case PaletteMode.Custom
                If kryptonNavigator1.LocalCustomPalette Is kryptonPaletteBlogger Then
                    radioBlogger.Checked = True
                ElseIf kryptonNavigator1.LocalCustomPalette Is kryptonPaletteLightweight Then
                    radioLightweight.Checked = True
                End If
        End Select
    End Sub

End Class
