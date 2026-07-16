#Region "BSD License"
'
' Original BSD 3-Clause License (https://github.com/ComponentFactory/Krypton/blob/master/LICENSE)
'  © Component Factory Pty Ltd, 2006 - 2016, (Version 4.5.0.0) All rights reserved.
'
'  New BSD 3-Clause License (https://github.com/Krypton-Suite/Standard-Toolkit/blob/master/LICENSE)
'  Modifications by Peter Wagner(aka Wagnerp) & Simon Coghlan(aka Smurf-IV), et al. 2017 - 2024. All rights reserved.
'
' VB.NET twin of Source\Krypton Toolkit Examples\Custom Control using Palettes\Form1.cs (Bastion Phase 4c).
#End Region

Imports System
Imports System.Windows.Forms

Imports Krypton.Toolkit

Public Class Form1

    Public Sub New()
        InitializeComponent()
    End Sub

    Private Sub kryptonCheckSet_CheckedButtonChanged(sender As Object, e As EventArgs) Handles kryptonCheckSet.CheckedButtonChanged
        ' Switch to using a different global palette
        Select Case kryptonCheckSet.CheckedIndex
            Case 0
                kryptonManager.GlobalPaletteMode = PaletteMode.SparkleBlue
            Case 1
                kryptonManager.GlobalPaletteMode = PaletteMode.ProfessionalSystem
            Case 2
                kryptonManager.GlobalCustomPalette = kryptonPaletteCustom
            Case 3
                kryptonManager.GlobalPaletteMode = PaletteMode.Office2010Blue
            Case 4
                kryptonManager.GlobalPaletteMode = PaletteMode.Office2007Blue
        End Select
    End Sub

    Private Sub checkBoxEnabled_CheckedChanged(sender As Object, e As EventArgs) Handles checkBoxEnabled.CheckedChanged
        ' Toggle the enabled state of the custom control instance
        myUserControl1.Enabled = Not myUserControl1.Enabled
    End Sub

    Private Sub buttonClose_Click(sender As Object, e As EventArgs) Handles buttonClose.Click
        Close()
    End Sub

End Class
