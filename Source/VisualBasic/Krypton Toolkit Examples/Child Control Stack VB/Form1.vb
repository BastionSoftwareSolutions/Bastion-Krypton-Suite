#Region "BSD License"
'
' Original BSD 3-Clause License (https://github.com/ComponentFactory/Krypton/blob/master/LICENSE)
'  © Component Factory Pty Ltd, 2006 - 2016, (Version 4.5.0.0) All rights reserved.
'
'  New BSD 3-Clause License (https://github.com/Krypton-Suite/Standard-Toolkit/blob/master/LICENSE)
'  Modifications by Peter Wagner(aka Wagnerp) & Simon Coghlan(aka Smurf-IV), et al. 2017 - 2024. All rights reserved.
'
' VB.NET twin of Source\Krypton Toolkit Examples\Child Control Stack\Form1.cs (Bastion Phase 4c).
#End Region

Imports System

Imports Krypton.Toolkit

Public Class Form1

    Public Sub New()
        InitializeComponent()
    End Sub

    Private Sub Form1_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        textBoxFiller.Focus()
        textBoxFiller.SelectionStart = 0
        textBoxFiller.SelectionLength = 0
    End Sub

    Private Sub kryptonCheckSet_CheckedButtonChanged(sender As Object, e As EventArgs) Handles kryptonCheckSet.CheckedButtonChanged
        ' Put the name for the checkbutton into the header
        kryptonHeader.Values.Heading = kryptonCheckSet.CheckedButton?.Values.Text
    End Sub

    Private Sub toolOffice2010_Click(sender As Object, e As EventArgs) Handles toolOffice2010.Click, menuOffice2010.Click
        If Not toolOffice2010.Checked Then
            kryptonManager.GlobalPaletteMode = PaletteMode.Office2010Blue
            toolOffice2010.Checked = True : menuOffice2010.Checked = True
            toolOffice2007.Checked = False : menuOffice2007.Checked = False
            toolSystem.Checked = False : menuSystem.Checked = False
            toolSparkle.Checked = False : menuSparkle.Checked = False
        End If
    End Sub

    Private Sub toolOffice2007_Click(sender As Object, e As EventArgs) Handles toolOffice2007.Click, menuOffice2007.Click
        If Not toolOffice2007.Checked Then
            kryptonManager.GlobalPaletteMode = PaletteMode.Office2007Blue
            toolOffice2010.Checked = False : menuOffice2010.Checked = False
            toolOffice2007.Checked = True : menuOffice2007.Checked = True
            toolSystem.Checked = False : menuSystem.Checked = False
            toolSparkle.Checked = False : menuSparkle.Checked = False
        End If
    End Sub

    Private Sub toolSystem_Click(sender As Object, e As EventArgs) Handles toolSystem.Click, menuSystem.Click
        If Not toolSystem.Checked Then
            kryptonManager.GlobalPaletteMode = PaletteMode.ProfessionalSystem
            toolOffice2010.Checked = False : menuOffice2010.Checked = False
            toolOffice2007.Checked = False : menuOffice2007.Checked = False
            toolSystem.Checked = True : menuSystem.Checked = True
            toolSparkle.Checked = False : menuSparkle.Checked = False
        End If
    End Sub

    Private Sub toolSparkle_Click(sender As Object, e As EventArgs) Handles toolSparkle.Click, menuSparkle.Click
        If Not toolSparkle.Checked Then
            kryptonManager.GlobalPaletteMode = PaletteMode.SparkleBlue
            toolOffice2010.Checked = False : menuOffice2010.Checked = False
            toolOffice2007.Checked = False : menuOffice2007.Checked = False
            toolSystem.Checked = False : menuSystem.Checked = False
            toolSparkle.Checked = True : menuSparkle.Checked = True
        End If
    End Sub

    Private Sub exitToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles exitToolStripMenuItem.Click
        Close()
    End Sub

End Class
