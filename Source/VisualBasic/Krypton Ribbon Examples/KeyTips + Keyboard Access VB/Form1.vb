#Region "BSD License"
'
' Original BSD 3-Clause License (https://github.com/ComponentFactory/Krypton/blob/master/LICENSE)
'  © Component Factory Pty Ltd, 2006 - 2016, (Version 4.5.0.0) All rights reserved.
'
'  New BSD 3-Clause License (https://github.com/Krypton-Suite/Standard-Toolkit/blob/master/LICENSE)
'  Modifications by Peter Wagner(aka Wagnerp) & Simon Coghlan(aka Smurf-IV), et al. 2017 - 2024. All rights reserved.
'
' VB.NET twin of Source\Krypton Ribbon Examples\KeyTips + Keyboard Access\Form1.cs (Bastion Phase 4c).
#End Region

Imports System
Imports System.Windows.Forms

Imports Krypton.Ribbon
Imports Krypton.Toolkit

Public Class Form1

    Private Sub Form1_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        checkSetPalette.CheckedButton = Me.buttonOffice2010Black
    End Sub

    Private Sub checkSetPalette_CheckedButtonChanged(sender As Object, e As EventArgs) Handles checkSetPalette.CheckedButtonChanged
        If checkSetPalette.CheckedButton Is buttonOffice2007Blue Then
            kryptonManager.GlobalPaletteMode = PaletteMode.Office2007Blue
        ElseIf checkSetPalette.CheckedButton Is buttonOffice2007Silver Then
            kryptonManager.GlobalPaletteMode = PaletteMode.Office2007Silver
        ElseIf checkSetPalette.CheckedButton Is buttonOffice2007Black Then
            kryptonManager.GlobalPaletteMode = PaletteMode.Office2007Black
        ElseIf checkSetPalette.CheckedButton Is buttonProfessional2003 Then
            kryptonManager.GlobalPaletteMode = PaletteMode.ProfessionalOffice2003
        ElseIf checkSetPalette.CheckedButton Is buttonProfessionalSystem Then
            kryptonManager.GlobalPaletteMode = PaletteMode.ProfessionalSystem
        ElseIf checkSetPalette.CheckedButton Is buttonSparkleBlue Then
            kryptonManager.GlobalPaletteMode = PaletteMode.SparkleBlue
        ElseIf checkSetPalette.CheckedButton Is buttonSparkleOrange Then
            kryptonManager.GlobalPaletteMode = PaletteMode.SparkleOrange
        ElseIf checkSetPalette.CheckedButton Is buttonSparklePurple Then
            kryptonManager.GlobalPaletteMode = PaletteMode.SparklePurple
        ElseIf checkSetPalette.CheckedButton Is buttonOffice2010Blue Then
            kryptonManager.GlobalPaletteMode = PaletteMode.Office2010Blue
        ElseIf checkSetPalette.CheckedButton Is buttonOffice2010Silver Then
            kryptonManager.GlobalPaletteMode = PaletteMode.Office2010Silver
        ElseIf checkSetPalette.CheckedButton Is buttonOffice2010Black Then
            kryptonManager.GlobalPaletteMode = PaletteMode.Office2010Black
        ElseIf checkSetPalette.CheckedButton Is buttonOffice365Black Then
            kryptonManager.GlobalPaletteMode = PaletteMode.Microsoft365Black
        End If
    End Sub

    Private Sub OnDialogBoxLauncherClick(sender As Object, e As EventArgs) Handles _
        groupEdit.DialogBoxLauncherClick, groupBugs.DialogBoxLauncherClick,
        groupsData.DialogBoxLauncherClick, kryptonRibbonGroup1.DialogBoxLauncherClick

        Dim group = DirectCast(sender, KryptonRibbonGroup)

        MessageBox.Show(Me,
            $"You selected the '{group.TextLine1}' group dialog box launcher.",
                        "Dialog Box Launcher")
    End Sub

    Private Sub OnQATButtonClick(sender As Object, e As EventArgs) Handles _
        qatUSA.Click, qatCanada.Click, qatGermany.Click, qatEngland.Click, qatJapan.Click,
        qatFrance.Click, qatItaly.Click, qatAustralia.Click, qatBelgium.Click, qatBahamas.Click,
        qatIndia.Click, qatSouthAfrica.Click, qatPakistan.Click, qatChina.Click, qatKenya.Click,
        qatArgentina.Click, qatBrazil.Click

        Dim button = DirectCast(sender, KryptonRibbonQATButton)

        MessageBox.Show(Me,
            $"You selected the '{button.Text}' quick access toolbar button.",
                        "QAT Button")
    End Sub

    Private Sub OnGroupButtonClick(sender As Object, e As EventArgs) Handles _
        buttonCut.Click, buttonCopy.Click, buttonPaste.Click,
        buttonBugGreen.Click, buttonBugRed.Click, buttonBugYellow.Click,
        buttonDataCopy.Click, buttonDataEdit.Click, buttonDataView.Click,
        kryptonRibbonGroupButton1.Click, kryptonRibbonGroupButton3.Click, kryptonRibbonGroupButton2.Click,
        kryptonRibbonGroupButton4.Click, kryptonRibbonGroupButton6.Click, kryptonRibbonGroupButton5.Click,
        kryptonRibbonGroupButton7.Click, kryptonRibbonGroupButton8.Click, kryptonRibbonGroupButton9.Click

        Dim button = DirectCast(sender, KryptonRibbonGroupButton)

        Dim text = button.TextLine1
        If Not String.IsNullOrEmpty(button.TextLine2) Then
            text &= $" {button.TextLine2}"
        End If

        MessageBox.Show(Me,
            $"You selected the '{text}' button.",
                        "Button")
    End Sub

    Private Sub OnGroupClusterButtonClick(sender As Object, e As EventArgs) Handles _
        kryptonRibbonGroupClusterButton1.Click, kryptonRibbonGroupClusterButton2.Click,
        kryptonRibbonGroupClusterButton3.Click, kryptonRibbonGroupClusterButton4.Click,
        kryptonRibbonGroupClusterButton5.Click, kryptonRibbonGroupClusterButton6.Click,
        kryptonRibbonGroupClusterButton7.Click, kryptonRibbonGroupClusterButton8.Click,
        kryptonRibbonGroupClusterButton9.Click, kryptonRibbonGroupClusterButton10.Click

        Dim button = DirectCast(sender, KryptonRibbonGroupClusterButton)

        MessageBox.Show(Me,
            $"You selected the '{button.TextLine}' button.",
                        "Button")
    End Sub

    Private Sub appMenu_Click(sender As Object, e As EventArgs) Handles kryptonContextMenuItem1.Click
        Close()
    End Sub

End Class
