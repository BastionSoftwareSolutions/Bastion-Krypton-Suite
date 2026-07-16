#Region "BSD License"
'
' Original BSD 3-Clause License (https://github.com/ComponentFactory/Krypton/blob/master/LICENSE)
'  © Component Factory Pty Ltd, 2006 - 2016, (Version 4.5.0.0) All rights reserved.
'
'  New BSD 3-Clause License (https://github.com/Krypton-Suite/Standard-Toolkit/blob/master/LICENSE)
'  Modifications by Peter Wagner(aka Wagnerp) & Simon Coghlan(aka Smurf-IV), et al. 2017 - 2024. All rights reserved.
'
' VB.NET twin of Source\Krypton Navigator Examples\Expanding Pages\Form1.cs (Bastion Phase 4c).
#End Region

Imports System

Imports Krypton.Navigator
Imports Krypton.Toolkit

Public Class Form1

    Private Sub buttonTopArrow_Click(sender As Object, e As EventArgs) Handles buttonTopArrow.Click
        ' For the top navigator instance we will toggle the showing of
        ' the client area below the check button area. We also toggle
        ' the direction of the button spec arrow.

        If navigatorTop.NavigatorMode = NavigatorMode.HeaderBarCheckButtonGroup Then
            navigatorTop.NavigatorMode = NavigatorMode.HeaderBarCheckButtonOnly
            buttonTopArrow.TypeRestricted = PaletteNavButtonSpecStyle.ArrowDown
        Else
            navigatorTop.NavigatorMode = NavigatorMode.HeaderBarCheckButtonGroup
            buttonTopArrow.TypeRestricted = PaletteNavButtonSpecStyle.ArrowUp
        End If
    End Sub

    Private Sub buttonLeft_Click(sender As Object, e As EventArgs) Handles buttonLeft.Click
        ' For the left navigator instance we will toggle the showing of
        ' the client area to the right of the check button area. We also
        ' toggle the direction of the button spec arrow.

        If navigatorLeft.NavigatorMode = NavigatorMode.HeaderBarCheckButtonGroup Then
            navigatorLeft.NavigatorMode = NavigatorMode.HeaderBarCheckButtonOnly
            buttonLeft.TypeRestricted = PaletteNavButtonSpecStyle.ArrowRight
        Else
            navigatorLeft.NavigatorMode = NavigatorMode.HeaderBarCheckButtonGroup
            buttonLeft.TypeRestricted = PaletteNavButtonSpecStyle.ArrowLeft
        End If
    End Sub

    Private Sub kryptonPaletteButtons_Click(sender As Object, e As EventArgs) Handles _
        kryptonCheckButton7.Click, kryptonCheckButton8.Click, kryptonCheckButton9.Click,
        kryptonCheckButton5.Click, kryptonCheckButton4.Click, kryptonCheckButton3.Click,
        kryptonCheckButton2.Click, kryptonCheckButton1.Click

        ' When the user presses one of the palette buttons we need to ensure
        ' that if the containing page is showing as a popup that the popup
        ' is then removed from display. So call DismissPopupPage to remove
        ' the page from view. If the page is not showing as a popup then
        ' the call does nothing.
        navigatorLeft.DismissPopups()
    End Sub

    Private Sub kryptonPalettes_CheckedButtonChanged(sender As Object, e As EventArgs) Handles kryptonPalettes.CheckedButtonChanged
        ' Change the palette depending on the selected button
        Select Case kryptonPalettes.CheckedIndex
            Case 0
                kryptonManager1.GlobalPaletteMode = PaletteMode.Office2007Blue
            Case 1
                kryptonManager1.GlobalPaletteMode = PaletteMode.Office2007Silver
            Case 2
                kryptonManager1.GlobalPaletteMode = PaletteMode.Office2007Black
            Case 3
                kryptonManager1.GlobalPaletteMode = PaletteMode.ProfessionalSystem
            Case 4
                kryptonManager1.GlobalPaletteMode = PaletteMode.ProfessionalOffice2003
            Case 5
                kryptonManager1.GlobalPaletteMode = PaletteMode.SparkleBlue
            Case 6
                kryptonManager1.GlobalPaletteMode = PaletteMode.Office2010Black
            Case 7
                kryptonManager1.GlobalPaletteMode = PaletteMode.Office2010Silver
            Case 8
                kryptonManager1.GlobalPaletteMode = PaletteMode.Office2010Blue
        End Select
    End Sub

End Class
