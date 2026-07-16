#Region "BSD License"
'
' Original BSD 3-Clause License (https://github.com/ComponentFactory/Krypton/blob/master/LICENSE)
'  © Component Factory Pty Ltd, 2006 - 2016, (Version 4.5.0.0) All rights reserved.
'
'  New BSD 3-Clause License (https://github.com/Krypton-Suite/Standard-Toolkit/blob/master/LICENSE)
'  Modifications by Peter Wagner(aka Wagnerp) & Simon Coghlan(aka Smurf-IV), et al. 2017 - 2024. All rights reserved.
'
' VB.NET twin of Source\Krypton Ribbon Examples\Contextual Tabs\Form1.cs (Bastion Phase 4c).
#End Region

Imports System
Imports System.Windows.Forms

Imports Krypton.Ribbon
Imports Krypton.Toolkit

Public Class Form1

    Private Sub buttonSelectedApply_Click(sender As Object, e As EventArgs) Handles buttonSelectedApply.Click
        ' Update ribbon with new context value
        kryptonRibbon.SelectedContext = textBoxSelectedContexts.Text
    End Sub

    Private Sub textBoxSelectedContexts_KeyDown(sender As Object, e As KeyEventArgs) Handles textBoxSelectedContexts.KeyDown
        ' Pressing enter in text box is same as pressing the apply button
        If e.KeyCode = Keys.Enter Then
            buttonSelectedApply_Click(buttonSelectedApply, EventArgs.Empty)
        End If
    End Sub

    Private Sub buttonEditColor_Click(sender As Object, e As EventArgs) Handles buttonEditColor.Click
        ' Let user change the color definition
        Using kcd As New KryptonColorDialog()

            kcd.AllowFullOpen = True

            If kcd.ShowDialog() = DialogResult.OK Then
                ' Update the Displayed color feedback
                panelContextColor.StateCommon.Color1 = kcd.Color
            End If
        End Using
    End Sub

    Private Sub buttonAddContext_Click(sender As Object, e As EventArgs) Handles buttonAddContext.Click
        ' Create a new context that uses the information specified
        Dim newContext As New KryptonRibbonContext With {
            .ContextName = textBoxContextName.Text,
            .ContextTitle = textBoxContextTitle.Text,
            .ContextColor = panelContextColor.StateCommon.Color1
        }
        kryptonRibbon.RibbonContexts.Add(newContext)

        ' Create a new ribbon page that specifies the new context name
        Dim newTab As New KryptonRibbonTab With {
            .ContextName = newContext.ContextName
        }
        kryptonRibbon.RibbonTabs.Add(newTab)

        ' Update the selected context name on the form and control so it shows
        Dim newSelectedContext = textBoxSelectedContexts.Text
        If newSelectedContext.Length > 0 Then
            newSelectedContext &= ","
        End If

        newSelectedContext &= newContext.ContextName
        textBoxSelectedContexts.Text = newSelectedContext
        kryptonRibbon.SelectedContext = newSelectedContext
    End Sub

    Private Sub radioOffice2010Blue_CheckedChanged(sender As Object, e As EventArgs) Handles radioOffice2010Blue.CheckedChanged
        If radioOffice2010Blue.Checked Then
            kryptonManager.GlobalPaletteMode = PaletteMode.Office2010Blue
        End If
    End Sub

    Private Sub radioOffice2010Silver_CheckedChanged(sender As Object, e As EventArgs) Handles radioOffice2010Silver.CheckedChanged
        If radioOffice2010Silver.Checked Then
            kryptonManager.GlobalPaletteMode = PaletteMode.Office2010Silver
        End If
    End Sub

    Private Sub radioOffice2010Black_CheckedChanged(sender As Object, e As EventArgs) Handles radioOffice2010Black.CheckedChanged
        If radioOffice2010Black.Checked Then
            kryptonManager.GlobalPaletteMode = PaletteMode.Office2010Black
        End If
    End Sub

    Private Sub radioOffice2007Blue_CheckedChanged(sender As Object, e As EventArgs) Handles radioOffice2007Blue.CheckedChanged
        If radioOffice2007Blue.Checked Then
            kryptonManager.GlobalPaletteMode = PaletteMode.Office2007Blue
        End If
    End Sub

    Private Sub radioOffice2007Silver_CheckedChanged(sender As Object, e As EventArgs) Handles radioOffice2007Silver.CheckedChanged
        If radioOffice2007Silver.Checked Then
            kryptonManager.GlobalPaletteMode = PaletteMode.Office2007Silver
        End If
    End Sub

    Private Sub radioOffice2007Black_CheckedChanged(sender As Object, e As EventArgs) Handles radioOffice2007Black.CheckedChanged
        If radioOffice2007Black.Checked Then
            kryptonManager.GlobalPaletteMode = PaletteMode.Office2007Black
        End If
    End Sub

    Private Sub radioOffice2003_CheckedChanged(sender As Object, e As EventArgs) Handles radioOffice2003.CheckedChanged
        If radioOffice2003.Checked Then
            kryptonManager.GlobalPaletteMode = PaletteMode.ProfessionalOffice2003
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

    Private Sub radioSystem_CheckedChanged(sender As Object, e As EventArgs) Handles radioSystem.CheckedChanged
        If radioSystem.Checked Then
            kryptonManager.GlobalPaletteMode = PaletteMode.ProfessionalSystem
        End If
    End Sub

    Private Sub appMenu_Click(sender As Object, e As EventArgs) Handles kryptonContextMenuItem1.Click
        Close()
    End Sub

End Class
