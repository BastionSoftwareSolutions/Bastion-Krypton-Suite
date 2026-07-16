#Region "BSD License"
'
' Original BSD 3-Clause License (https://github.com/ComponentFactory/Krypton/blob/master/LICENSE)
'  © Component Factory Pty Ltd, 2006 - 2016, (Version 4.5.0.0) All rights reserved.
'
'  New BSD 3-Clause License (https://github.com/Krypton-Suite/Standard-Toolkit/blob/master/LICENSE)
'  Modifications by Peter Wagner(aka Wagnerp) & Simon Coghlan(aka Smurf-IV), et al. 2017 - 2024. All rights reserved.
'
' VB.NET twin of Source\Krypton Navigator Examples\Tab Border Styles\Form1.cs (Bastion Phase 4c).
#End Region

Imports System
Imports System.Windows.Forms

Imports Krypton.Toolkit

Public Class Form1

    Private Sub tabBorderStyles_CheckedChanged(sender As Object, e As EventArgs) Handles _
        radioSO.CheckedChanged, radioSE.CheckedChanged, radioON.CheckedChanged,
        radioSOB.CheckedChanged, radioSOF.CheckedChanged, radioSON.CheckedChanged,
        radioSEB.CheckedChanged, radioSEF.CheckedChanged, radioSEN.CheckedChanged,
        radioROL.CheckedChanged, radioROM.CheckedChanged, radioROS.CheckedChanged,
        radioREL.CheckedChanged, radioREM.CheckedChanged, radioRES.CheckedChanged,
        radioSOL.CheckedChanged, radioSOM.CheckedChanged, radioSOS.CheckedChanged,
        radioSEL.CheckedChanged, radioSEM.CheckedChanged, radioSES.CheckedChanged

        ' Cast to correct type
        Dim rb = DirectCast(sender, RadioButton)

        If rb.Checked Then
            Dim enumVal = CType([Enum].Parse(GetType(TabBorderStyle), rb.Tag.ToString()), TabBorderStyle)
            kryptonNavigator.Bar.TabBorderStyle = enumVal
        End If
    End Sub

    Private Sub tabStyles_CheckedChanged(sender As Object, e As EventArgs) Handles _
        radioOneNote.CheckedChanged, radioLP.CheckedChanged, radioSP.CheckedChanged, radioHP.CheckedChanged

        ' Cast to correct type
        Dim rb = DirectCast(sender, RadioButton)

        If rb.Checked Then
            Dim enumVal = CType([Enum].Parse(GetType(TabStyle), rb.Tag.ToString()), TabStyle)
            kryptonNavigator.Bar.TabStyle = enumVal
        End If
    End Sub

    Private Sub buttonClose_Click(sender As Object, e As EventArgs) Handles buttonClose.Click
        Close()
    End Sub

End Class
