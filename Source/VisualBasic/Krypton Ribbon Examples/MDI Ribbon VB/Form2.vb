#Region "BSD License"
'
' Original BSD 3-Clause License (https://github.com/ComponentFactory/Krypton/blob/master/LICENSE)
'  © Component Factory Pty Ltd, 2006 - 2016, (Version 4.5.0.0) All rights reserved.
'
'  New BSD 3-Clause License (https://github.com/Krypton-Suite/Standard-Toolkit/blob/master/LICENSE)
'  Modifications by Peter Wagner(aka Wagnerp) & Simon Coghlan(aka Smurf-IV), tobitege et al. 2017 - 2025. All rights reserved.
'
' VB.NET twin of Source\Krypton Ribbon Examples\MDI Ribbon\Form2.cs (Bastion Phase 4c).
#End Region

Imports System

Imports Krypton.Toolkit

Public Class Form2

    Protected Overrides Sub Dispose(disposing As Boolean)
        If disposing Then
            ' Remember to unhook from static event, otherwise
            ' this object cannot be garbage collected later on
            RemoveHandler KryptonManager.GlobalPaletteChanged, AddressOf OnPaletteChanged

            components?.Dispose()
        End If
        MyBase.Dispose(disposing)
    End Sub

    Private Sub Form2_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        ' Set correct initial radio button setting
        UpdateRadioButtons()

        ' Hook into changes in the global palette
        AddHandler KryptonManager.GlobalPaletteChanged, AddressOf OnPaletteChanged
    End Sub

    Private Sub radioSystem_CheckedChanged(sender As Object, e As EventArgs) Handles radioSystem.CheckedChanged
        If radioSystem.Checked Then
            kryptonManager.GlobalPaletteMode = PaletteMode.ProfessionalSystem
        End If
    End Sub

    Private Sub radioOffice2003_CheckedChanged(sender As Object, e As EventArgs) Handles radioOffice2003.CheckedChanged
        If radioOffice2003.Checked Then
            kryptonManager.GlobalPaletteMode = PaletteMode.ProfessionalOffice2003
        End If
    End Sub

    Private Sub radio2010Blue_CheckedChanged(sender As Object, e As EventArgs) Handles radio2010Blue.CheckedChanged
        If radio2010Blue.Checked Then
            kryptonManager.GlobalPaletteMode = PaletteMode.Office2010Blue
        End If
    End Sub

    Private Sub radio2010Silver_CheckedChanged(sender As Object, e As EventArgs) Handles radio2010Silver.CheckedChanged
        If radio2010Silver.Checked Then
            kryptonManager.GlobalPaletteMode = PaletteMode.Office2010Silver
        End If
    End Sub

    Private Sub radio2010Black_CheckedChanged(sender As Object, e As EventArgs) Handles radio2010Black.CheckedChanged
        If radio2010Black.Checked Then
            kryptonManager.GlobalPaletteMode = PaletteMode.Office2010Black
        End If
    End Sub

    Private Sub radioBlue_CheckedChanged(sender As Object, e As EventArgs) Handles radioBlue.CheckedChanged
        If radioBlue.Checked Then
            kryptonManager.GlobalPaletteMode = PaletteMode.Office2007Blue
        End If
    End Sub

    Private Sub radioSilver_CheckedChanged(sender As Object, e As EventArgs) Handles radioSilver.CheckedChanged
        If radioSilver.Checked Then
            kryptonManager.GlobalPaletteMode = PaletteMode.Office2007Silver
        End If
    End Sub

    Private Sub radioBlack_CheckedChanged(sender As Object, e As EventArgs) Handles radioBlack.CheckedChanged
        If radioBlack.Checked Then
            kryptonManager.GlobalPaletteMode = PaletteMode.Office2007Black
        End If
    End Sub

    Private Sub radioSparkleBlue_CheckedChanged(sender As Object, e As EventArgs) Handles radioSparkleBlue.CheckedChanged
        If radioSparkleBlue.Checked Then
            kryptonManager.GlobalPaletteMode = PaletteMode.SparkleBlue
        End If
    End Sub

    Private Sub radioSparkleOrange_CheckedChanged(sender As Object, e As EventArgs) Handles radioSparkleOrange.CheckedChanged
        If radioSparkleOrange.Checked Then
            kryptonManager.GlobalPaletteMode = PaletteMode.SparkleOrange
        End If
    End Sub

    Private Sub radioSparklePurple_CheckedChanged(sender As Object, e As EventArgs) Handles radioSparklePurple.CheckedChanged
        If radioSparklePurple.Checked Then
            kryptonManager.GlobalPaletteMode = PaletteMode.SparklePurple
        End If
    End Sub

    ' NOTE: Shadows because KryptonForm has an overridable OnPaletteChanged;
    ' the C# twin's private method hides it implicitly.
    Private Shadows Sub OnPaletteChanged(sender As Object, e As EventArgs)
        ' Update buttons to reflect the new palette setting
        UpdateRadioButtons()
    End Sub

    Private Sub UpdateRadioButtons()
        Select Case kryptonManager.GlobalPaletteMode
            Case PaletteMode.ProfessionalSystem
                radioSystem.Checked = True
            Case PaletteMode.ProfessionalOffice2003
                radioOffice2003.Checked = True
            Case PaletteMode.Office2007Blue
                radioBlue.Checked = True
            Case PaletteMode.Office2007Silver
                radioSilver.Checked = True
            Case PaletteMode.Office2007Black
                radioBlack.Checked = True
            Case PaletteMode.SparkleBlue
                radioSparkleBlue.Checked = True
            Case PaletteMode.SparkleOrange
                radioSparkleOrange.Checked = True
            Case PaletteMode.SparklePurple
                radioSparklePurple.Checked = True
            Case PaletteMode.Office2010Blue
                radio2010Blue.Checked = True
            Case PaletteMode.Office2010Silver
                radio2010Silver.Checked = True
            Case PaletteMode.Office2010Black
                radio2010Black.Checked = True
        End Select
    End Sub

End Class
