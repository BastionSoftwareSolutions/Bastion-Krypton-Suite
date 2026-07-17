#Region "BSD License"
'
' Original BSD 3-Clause License (https://github.com/ComponentFactory/Krypton/blob/master/LICENSE)
'  © Component Factory Pty Ltd, 2006 - 2016, (Version 4.5.0.0) All rights reserved.
'
'  New BSD 3-Clause License (https://github.com/Krypton-Suite/Standard-Toolkit/blob/master/LICENSE)
'  Modifications by Peter Wagner(aka Wagnerp) & Simon Coghlan(aka Smurf-IV), et al. 2017 - 2024. All rights reserved.
'
' VB.NET twin of Source\Krypton Ribbon Examples\Ribbon + Navigator + Workspace\Form1.cs (Bastion Phase 4c).
#End Region

Imports System

Imports Krypton.Navigator
Imports Krypton.Toolkit
Imports Krypton.Workspace

Public Class Form1

    Public Sub New()
        InitializeComponent()
        ButtonSpecClose.Enabled = False
    End Sub

    Private Sub buttonSpecExpandCollapse_Click(sender As Object, e As EventArgs) Handles buttonSpecExpandCollapse.Click
        ' Are we currently showing fully expanded?
        If navigatorOutlook.NavigatorMode = NavigatorMode.OutlookFull Then
            ' Switch to mini mode and reverse direction of arrow
            navigatorOutlook.NavigatorMode = NavigatorMode.OutlookMini
            buttonSpecExpandCollapse.TypeRestricted = PaletteNavButtonSpecStyle.ArrowRight
        Else
            ' Switch to full mode and reverse direction of arrow
            navigatorOutlook.NavigatorMode = NavigatorMode.OutlookFull
            buttonSpecExpandCollapse.TypeRestricted = PaletteNavButtonSpecStyle.ArrowLeft
        End If
    End Sub

    Private Sub radioOffice2010Blue_CheckedChanged(sender As Object, e As EventArgs) Handles radioOffice2010Blue.CheckedChanged
        If radioOffice2010Blue.Checked Then
            navigatorOutlook.DismissPopups()
            kryptonManager.GlobalPaletteMode = PaletteMode.Office2010Blue
        End If
    End Sub

    Private Sub radioOffice2010Silver_CheckedChanged(sender As Object, e As EventArgs) Handles radioOffice2010Silver.CheckedChanged
        If radioOffice2010Silver.Checked Then
            navigatorOutlook.DismissPopups()
            kryptonManager.GlobalPaletteMode = PaletteMode.Office2010Silver
        End If
    End Sub

    Private Sub radioOffice2010Black_CheckedChanged(sender As Object, e As EventArgs) Handles radioOffice2010Black.CheckedChanged
        If radioOffice2010Black.Checked Then
            navigatorOutlook.DismissPopups()
            kryptonManager.GlobalPaletteMode = PaletteMode.Office2010Black
        End If
    End Sub

    Private Sub radioOffice2007Blue_CheckedChanged(sender As Object, e As EventArgs) Handles radioOffice2007Blue.CheckedChanged
        If radioOffice2007Blue.Checked Then
            navigatorOutlook.DismissPopups()
            kryptonManager.GlobalPaletteMode = PaletteMode.Office2007Blue
        End If
    End Sub

    Private Sub radioOffice2007Silver_CheckedChanged(sender As Object, e As EventArgs) Handles radioOffice2007Silver.CheckedChanged
        If radioOffice2007Silver.Checked Then
            navigatorOutlook.DismissPopups()
            kryptonManager.GlobalPaletteMode = PaletteMode.Office2007Silver
        End If
    End Sub

    Private Sub radioOffice2007Black_CheckedChanged(sender As Object, e As EventArgs) Handles radioOffice2007Black.CheckedChanged
        If radioOffice2007Black.Checked Then
            navigatorOutlook.DismissPopups()
            kryptonManager.GlobalPaletteMode = PaletteMode.Office2007Black
        End If
    End Sub

    Private Sub radioOffice2003_CheckedChanged(sender As Object, e As EventArgs) Handles radioOffice2003.CheckedChanged
        If radioOffice2003.Checked Then
            navigatorOutlook.DismissPopups()
            kryptonManager.GlobalPaletteMode = PaletteMode.ProfessionalOffice2003
        End If
    End Sub

    Private Sub radioSparkleBlue_CheckedChanged(sender As Object, e As EventArgs) Handles radioSparkleBlue.CheckedChanged
        If radioSparkleBlue.Checked Then
            navigatorOutlook.DismissPopups()
            kryptonManager.GlobalPaletteMode = PaletteMode.SparkleBlue
        End If
    End Sub

    Private Sub radioSparkleOrange_CheckedChanged(sender As Object, e As EventArgs) Handles radioSparkleOrange.CheckedChanged
        If radioSparkleOrange.Checked Then
            navigatorOutlook.DismissPopups()
            kryptonManager.GlobalPaletteMode = PaletteMode.SparkleOrange
        End If
    End Sub

    Private Sub radioSparklePurple_CheckedChanged(sender As Object, e As EventArgs) Handles radioSparklePurple.CheckedChanged
        If radioSparklePurple.Checked Then
            navigatorOutlook.DismissPopups()
            kryptonManager.GlobalPaletteMode = PaletteMode.SparklePurple
        End If
    End Sub

    Private Sub radioSystem_CheckedChanged(sender As Object, e As EventArgs) Handles radioSystem.CheckedChanged
        If radioSystem.Checked Then
            navigatorOutlook.DismissPopups()
            kryptonManager.GlobalPaletteMode = PaletteMode.ProfessionalSystem
        End If
    End Sub

    Private Sub OnWorkspaceCellAdding(sender As Object, e As WorkspaceCellEventArgs) Handles kryptonWorkspace.WorkspaceCellAdding
        ' Remove the close and context menu buttons from the navigator cell
        e.Cell.Button.CloseButtonDisplay = ButtonDisplay.Hide
        e.Cell.Button.ContextButtonDisplay = ButtonDisplay.Hide
        e.Cell.Button.CloseButtonAction = CloseButtonAction.None

        ' Update with currently requested mode
        UpdateCell(e.Cell)
    End Sub

    Private Sub OnDocumentModeChanged(sender As Object, e As EventArgs) Handles checkSetDocMode.CheckedButtonChanged
        ' Kill any showing outlook poup page
        navigatorOutlook.DismissPopups()

        ' Update each workspace cell
        Dim cell As KryptonWorkspaceCell = kryptonWorkspace.FirstCell()
        While cell IsNot Nothing
            UpdateCell(cell)
            cell = kryptonWorkspace.NextCell(cell)
        End While
    End Sub

    Private Sub OnExit(sender As Object, e As EventArgs) Handles kryptonContextMenuItem1.Click
        Close()
    End Sub

    Private Sub UpdateCell(cell As KryptonWorkspaceCell)
        Dim newMode = NavigatorMode.BarTabGroup

        If checkSetDocMode.CheckedButton Is buttonTabs Then
            newMode = NavigatorMode.BarTabGroup
        ElseIf checkSetDocMode.CheckedButton Is buttonRibbonTabs Then
            newMode = NavigatorMode.BarRibbonTabGroup
        ElseIf checkSetDocMode.CheckedButton Is buttonCheckButtons Then
            newMode = NavigatorMode.BarCheckButtonGroupOutside
        ElseIf checkSetDocMode.CheckedButton Is buttonHeaderGroup Then
            newMode = NavigatorMode.HeaderGroup
        ElseIf checkSetDocMode.CheckedButton Is buttonHeaderBar Then
            newMode = NavigatorMode.HeaderBarCheckButtonHeaderGroup
        ElseIf checkSetDocMode.CheckedButton Is buttonStack Then
            newMode = NavigatorMode.StackCheckButtonGroup
        End If

        cell.NavigatorMode = newMode
    End Sub

End Class
