#Region "BSD License"
'
' Original BSD 3-Clause License (https://github.com/ComponentFactory/Krypton/blob/master/LICENSE)
'  © Component Factory Pty Ltd, 2006 - 2016, (Version 4.5.0.0) All rights reserved.
'
'  New BSD 3-Clause License (https://github.com/Krypton-Suite/Standard-Toolkit/blob/master/LICENSE)
'  Modifications by Peter Wagner(aka Wagnerp) & Simon Coghlan(aka Smurf-IV), et al. 2017 - 2024. All rights reserved.
'
' VB.NET twin of Source\Krypton Ribbon Examples\Application Menu\Form1.cs (Bastion Phase 4c).
#End Region

Imports System
Imports System.ComponentModel
Imports System.Drawing

Imports Krypton.Toolkit

Public Class Form1

    Private Sub Form1_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        checkBoxShowRecentDocs.Checked = kryptonRibbon1.RibbonFileAppButton.AppButtonShowRecentDocs
        textBoxDocsTitle.Text = KryptonManager.Strings.RibbonStrings.RecentDocuments
        textBoxMinWidth.Text = kryptonRibbon1.RibbonFileAppButton.AppButtonMinRecentSize.Width.ToString()
        textBoxMinHeight.Text = kryptonRibbon1.RibbonFileAppButton.AppButtonMinRecentSize.Height.ToString()
    End Sub

    Private Sub kryptonRibbon1_AppButtonMenuOpening(sender As Object, e As CancelEventArgs) Handles kryptonRibbon1.AppButtonMenuOpening
        kryptonRibbon1.RibbonFileAppButton.AppButtonShowRecentDocs = checkBoxShowRecentDocs.Checked
        KryptonManager.Strings.RibbonStrings.RecentDocuments = textBoxDocsTitle.Text

        Dim minWidth = Integer.Parse(textBoxMinWidth.Text)
        Dim minHeight = Integer.Parse(textBoxMinHeight.Text)
        kryptonRibbon1.RibbonFileAppButton.AppButtonMinRecentSize = New Size(minWidth, minHeight)
    End Sub

    Private Sub button2010Blue_Click(sender As Object, e As EventArgs) Handles button2010Blue.Click
        button2010Blue.Checked = True
        button2010Silver.Checked = False
        button2010Black.Checked = False
        buttonBlue.Checked = False
        buttonSilver.Checked = False
        buttonBlack.Checked = False
        button2003.Checked = False
        buttonSparkleBlue.Checked = False
        buttonSparkleOrange.Checked = False
        buttonSparklePurple.Checked = False
        buttonSystem.Checked = False
        kryptonManager1.GlobalPaletteMode = PaletteMode.Office2010Blue
    End Sub

    Private Sub button2010Silver_Click(sender As Object, e As EventArgs) Handles button2010Silver.Click
        button2010Blue.Checked = False
        button2010Silver.Checked = True
        button2010Black.Checked = False
        buttonBlue.Checked = False
        buttonSilver.Checked = False
        buttonBlack.Checked = False
        button2003.Checked = False
        buttonSparkleBlue.Checked = False
        buttonSparkleOrange.Checked = False
        buttonSparklePurple.Checked = False
        buttonSystem.Checked = False
        kryptonManager1.GlobalPaletteMode = PaletteMode.Office2010Silver
    End Sub

    Private Sub button2010Black_Click(sender As Object, e As EventArgs) Handles button2010Black.Click
        button2010Blue.Checked = False
        button2010Silver.Checked = False
        button2010Black.Checked = True
        buttonBlue.Checked = False
        buttonSilver.Checked = False
        buttonBlack.Checked = False
        button2003.Checked = False
        buttonSparkleBlue.Checked = False
        buttonSparkleOrange.Checked = False
        buttonSparklePurple.Checked = False
        buttonSystem.Checked = False
        kryptonManager1.GlobalPaletteMode = PaletteMode.Office2010Black
    End Sub

    Private Sub buttonBlue_Click(sender As Object, e As EventArgs) Handles buttonBlue.Click
        button2010Blue.Checked = False
        button2010Silver.Checked = False
        button2010Black.Checked = False
        buttonBlue.Checked = True
        buttonSilver.Checked = False
        buttonBlack.Checked = False
        button2003.Checked = False
        buttonSparkleBlue.Checked = False
        buttonSparkleOrange.Checked = False
        buttonSparklePurple.Checked = False
        buttonSystem.Checked = False
        kryptonManager1.GlobalPaletteMode = PaletteMode.Office2007Blue
    End Sub

    Private Sub buttonSilver_Click(sender As Object, e As EventArgs) Handles buttonSilver.Click
        button2010Blue.Checked = False
        button2010Silver.Checked = False
        button2010Black.Checked = False
        buttonBlue.Checked = False
        buttonSilver.Checked = True
        buttonBlack.Checked = False
        button2003.Checked = False
        buttonSparkleBlue.Checked = False
        buttonSparkleOrange.Checked = False
        buttonSparklePurple.Checked = False
        buttonSystem.Checked = False
        kryptonManager1.GlobalPaletteMode = PaletteMode.Office2007Silver
    End Sub

    Private Sub buttonBlack_Click(sender As Object, e As EventArgs) Handles buttonBlack.Click
        button2010Blue.Checked = False
        button2010Silver.Checked = False
        button2010Black.Checked = False
        buttonBlue.Checked = False
        buttonSilver.Checked = False
        buttonBlack.Checked = True
        button2003.Checked = False
        buttonSparkleBlue.Checked = False
        buttonSparkleOrange.Checked = False
        buttonSparklePurple.Checked = False
        buttonSystem.Checked = False
        kryptonManager1.GlobalPaletteMode = PaletteMode.Office2007Black
    End Sub

    Private Sub button2003_Click(sender As Object, e As EventArgs) Handles button2003.Click
        button2010Blue.Checked = False
        button2010Silver.Checked = False
        button2010Black.Checked = False
        buttonBlue.Checked = False
        buttonSilver.Checked = False
        buttonBlack.Checked = False
        button2003.Checked = True
        buttonSparkleBlue.Checked = False
        buttonSparkleOrange.Checked = False
        buttonSparklePurple.Checked = False
        buttonSystem.Checked = False
        kryptonManager1.GlobalPaletteMode = PaletteMode.ProfessionalOffice2003
    End Sub

    Private Sub buttonSparkleBlue_Click(sender As Object, e As EventArgs) Handles buttonSparkleBlue.Click
        button2010Blue.Checked = False
        button2010Silver.Checked = False
        button2010Black.Checked = False
        buttonBlue.Checked = False
        buttonSilver.Checked = False
        buttonBlack.Checked = False
        button2003.Checked = False
        buttonSparkleBlue.Checked = True
        buttonSparkleOrange.Checked = False
        buttonSparklePurple.Checked = False
        buttonSystem.Checked = False
        kryptonManager1.GlobalPaletteMode = PaletteMode.SparkleBlue
    End Sub

    Private Sub buttonSparkleOrange_Click(sender As Object, e As EventArgs) Handles buttonSparkleOrange.Click
        button2010Blue.Checked = False
        button2010Silver.Checked = False
        button2010Black.Checked = False
        buttonBlue.Checked = False
        buttonSilver.Checked = False
        buttonBlack.Checked = False
        button2003.Checked = False
        buttonSparkleBlue.Checked = False
        buttonSparkleOrange.Checked = True
        buttonSparklePurple.Checked = False
        buttonSystem.Checked = False
        kryptonManager1.GlobalPaletteMode = PaletteMode.SparkleOrange
    End Sub

    Private Sub buttonSparklePurple_Click(sender As Object, e As EventArgs) Handles buttonSparklePurple.Click
        button2010Blue.Checked = False
        button2010Silver.Checked = False
        button2010Black.Checked = False
        buttonBlue.Checked = False
        buttonSilver.Checked = False
        buttonBlack.Checked = False
        button2003.Checked = False
        buttonSparkleBlue.Checked = False
        buttonSparkleOrange.Checked = False
        buttonSparklePurple.Checked = True
        buttonSystem.Checked = False
        kryptonManager1.GlobalPaletteMode = PaletteMode.SparklePurple
    End Sub

    ' NOTE: mirrors the C# demo, which does not reset the Office 2010 buttons here.
    Private Sub buttonSystem_Click(sender As Object, e As EventArgs) Handles buttonSystem.Click
        buttonBlue.Checked = False
        buttonSilver.Checked = False
        buttonBlack.Checked = False
        button2003.Checked = False
        buttonSparkleBlue.Checked = False
        buttonSparkleOrange.Checked = False
        buttonSparklePurple.Checked = False
        buttonSystem.Checked = True
        kryptonManager1.GlobalPaletteMode = PaletteMode.ProfessionalSystem
    End Sub

End Class
