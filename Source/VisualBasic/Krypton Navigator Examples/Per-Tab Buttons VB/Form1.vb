#Region "BSD License"
'
' Original BSD 3-Clause License (https://github.com/ComponentFactory/Krypton/blob/master/LICENSE)
'  © Component Factory Pty Ltd, 2006 - 2016, (Version 4.5.0.0) All rights reserved.
'
'  New BSD 3-Clause License (https://github.com/Krypton-Suite/Standard-Toolkit/blob/master/LICENSE)
'  Modifications by Peter Wagner(aka Wagnerp) & Simon Coghlan(aka Smurf-IV), et al. 2017 - 2024. All rights reserved.
'
' VB.NET twin of Source\Krypton Navigator Examples\Per-Tab Buttons\Form1.cs (Bastion Phase 4c).
#End Region

Imports System
Imports System.Windows.Forms

Imports Krypton.Navigator
Imports Krypton.Toolkit

Public Class Form1

    Private Sub Form1_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        addContext_Click(Me, EventArgs.Empty)
        kryptonNavigator.SelectedIndex = 1
        addArrow_Click(Me, EventArgs.Empty)
        kryptonNavigator.SelectedIndex = 2
        addText_Click(Me, EventArgs.Empty)
        kryptonNavigator.SelectedIndex = 0

        UpdateControlsFromNavigator()
    End Sub

    Private Sub UpdateControlsFromNavigator()
        ' Update Mode
        radioModeTabs.Checked = (kryptonNavigator.NavigatorMode = NavigatorMode.BarTabGroup)
        radioModeRibbonTabs.Checked = (kryptonNavigator.NavigatorMode = NavigatorMode.BarRibbonTabGroup)
        radioModesCheckButton.Checked = (kryptonNavigator.NavigatorMode = NavigatorMode.BarCheckButtonGroupOutside)
        radioModesStack.Checked = (kryptonNavigator.NavigatorMode = NavigatorMode.StackCheckButtonGroup)
        radioModesOutlook.Checked = (kryptonNavigator.NavigatorMode = NavigatorMode.OutlookFull)

        ' Set mode specific properties
        Select Case kryptonNavigator.NavigatorMode
            Case NavigatorMode.BarRibbonTabGroup, NavigatorMode.BarRibbonTabOnly
                kryptonNavigator.PageBackStyle = PaletteBackStyle.ControlRibbon
                kryptonNavigator.Group.GroupBackStyle = PaletteBackStyle.ControlRibbon
                kryptonNavigator.Group.GroupBorderStyle = PaletteBorderStyle.ControlRibbon
            Case Else
                kryptonNavigator.PageBackStyle = PaletteBackStyle.ControlClient
                kryptonNavigator.Group.GroupBackStyle = PaletteBackStyle.ControlClient
                kryptonNavigator.Group.GroupBorderStyle = PaletteBorderStyle.ControlClient
        End Select
    End Sub

    Private Sub radioModeTabs_CheckedChanged(sender As Object, e As EventArgs) Handles radioModeTabs.CheckedChanged
        If radioModeTabs.Checked Then
            kryptonNavigator.NavigatorMode = NavigatorMode.BarTabGroup
            UpdateControlsFromNavigator()
        End If
    End Sub

    Private Sub radioModeRibbonTabs_CheckedChanged(sender As Object, e As EventArgs) Handles radioModeRibbonTabs.CheckedChanged
        If radioModeRibbonTabs.Checked Then
            kryptonNavigator.NavigatorMode = NavigatorMode.BarRibbonTabGroup
            UpdateControlsFromNavigator()
        End If
    End Sub

    Private Sub radioModesCheckButton_CheckedChanged(sender As Object, e As EventArgs) Handles radioModesCheckButton.CheckedChanged
        If radioModesCheckButton.Checked Then
            kryptonNavigator.NavigatorMode = NavigatorMode.BarCheckButtonGroupOutside
            UpdateControlsFromNavigator()
        End If
    End Sub

    Private Sub radioModesStack_CheckedChanged(sender As Object, e As EventArgs) Handles radioModesStack.CheckedChanged
        If radioModesStack.Checked Then
            kryptonNavigator.NavigatorMode = NavigatorMode.StackCheckButtonGroup
            UpdateControlsFromNavigator()
        End If
    End Sub

    Private Sub radioModesOutlook_CheckedChanged(sender As Object, e As EventArgs) Handles radioModesOutlook.CheckedChanged
        If radioModesOutlook.Checked Then
            kryptonNavigator.NavigatorMode = NavigatorMode.OutlookFull
            UpdateControlsFromNavigator()
        End If
    End Sub

    Private Sub addContext_Click(sender As Object, e As EventArgs) Handles addContext.Click
        If kryptonNavigator.SelectedPage IsNot Nothing Then
            Dim bsa = New ButtonSpecAny()
            bsa.Type = PaletteButtonSpecStyle.Context
            bsa.Style = PaletteButtonStyle.Standalone
            bsa.KryptonContextMenu = kryptonContextMenu
            bsa.Tag = kryptonNavigator.SelectedPage
            bsa.Orientation = PaletteButtonOrientation.FixedLeft
            kryptonNavigator.SelectedPage.ButtonSpecs.Add(bsa)
        End If
    End Sub

    Private Sub addText_Click(sender As Object, e As EventArgs) Handles addText.Click
        If kryptonNavigator.SelectedPage IsNot Nothing Then
            Dim bsa = New ButtonSpecAny()
            bsa.Style = PaletteButtonStyle.Standalone
            bsa.Text = DateTime.Now.Millisecond.ToString()
            bsa.Tag = kryptonNavigator.SelectedPage
            kryptonNavigator.SelectedPage.ButtonSpecs.Add(bsa)
        End If
    End Sub

    Private Sub addArrow_Click(sender As Object, e As EventArgs) Handles addArrow.Click
        If kryptonNavigator.SelectedPage IsNot Nothing Then
            Dim bsa = New ButtonSpecAny()
            bsa.Style = PaletteButtonStyle.Alternate
            bsa.Type = PaletteButtonSpecStyle.ArrowRight
            bsa.Tag = kryptonNavigator.SelectedPage
            kryptonNavigator.SelectedPage.ButtonSpecs.Add(bsa)
        End If
    End Sub

    Private Sub clearButtons_Click(sender As Object, e As EventArgs) Handles clearButtons.Click
        If kryptonNavigator.SelectedPage IsNot Nothing Then
            kryptonNavigator.SelectedPage.ButtonSpecs.Clear()
        End If
    End Sub

    Private Sub buttonClose_Click(sender As Object, e As EventArgs) Handles buttonClose.Click
        Close()
    End Sub

End Class
