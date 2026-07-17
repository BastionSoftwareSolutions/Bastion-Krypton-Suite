#Region "BSD License"
'
' Original BSD 3-Clause License (https://github.com/ComponentFactory/Krypton/blob/master/LICENSE)
'  © Component Factory Pty Ltd, 2006 - 2016, (Version 4.5.0.0) All rights reserved.
'
'  New BSD 3-Clause License (https://github.com/Krypton-Suite/Standard-Toolkit/blob/master/LICENSE)
'  Modifications by Peter Wagner(aka Wagnerp) & Simon Coghlan(aka Smurf-IV), et al. 2017 - 2024. All rights reserved.
'
' VB.NET twin of Source\Krypton Navigator Examples\Popup Pages\Form1.cs (Bastion Phase 4c).
#End Region

Imports System
Imports System.Windows.Forms

Imports Krypton.Navigator
Imports Krypton.Toolkit

Public Class Form1

    Private Sub Form1_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        UpdateControlsFromNavigator()
    End Sub

    Private Sub UpdateControlsFromNavigator()
        ' Update mode control
        radioBarTabOnly.Checked = (kryptonNavigator.NavigatorMode = NavigatorMode.BarTabOnly)
        radioBarRibbonTabOnly.Checked = (kryptonNavigator.NavigatorMode = NavigatorMode.BarRibbonTabOnly)
        radioBarCheckButtonGroupOnly.Checked = (kryptonNavigator.NavigatorMode = NavigatorMode.BarCheckButtonGroupOnly)
        radioBarCheckButtonOnly.Checked = (kryptonNavigator.NavigatorMode = NavigatorMode.BarCheckButtonOnly)
        radioHeaderBarCheckButtonOnly.Checked = (kryptonNavigator.NavigatorMode = NavigatorMode.HeaderBarCheckButtonOnly)
        radioOutlookMini.Checked = (kryptonNavigator.NavigatorMode = NavigatorMode.OutlookMini)

        ' Update bar orientation controls
        radioOrientationTop.Checked = (kryptonNavigator.Bar.BarOrientation = VisualOrientation.Top)
        radioOrientationBottom.Checked = (kryptonNavigator.Bar.BarOrientation = VisualOrientation.Bottom)
        radioOrientationLeft.Checked = (kryptonNavigator.Bar.BarOrientation = VisualOrientation.Left)
        radioOrientationRight.Checked = (kryptonNavigator.Bar.BarOrientation = VisualOrientation.Right)

        ' Update popup page controls
        numericBorder.Value = kryptonNavigator.PopupPages.Border
        numericGap.Value = kryptonNavigator.PopupPages.Gap
        comboBoxElement.Text = kryptonNavigator.PopupPages.Element.ToString()
        comboBoxPosition.Text = kryptonNavigator.PopupPages.Position.ToString()
    End Sub

    Private Sub radioBarTabOnly_CheckedChanged(sender As Object, e As EventArgs) Handles radioBarTabOnly.CheckedChanged
        If radioBarTabOnly.Checked Then
            kryptonNavigator.NavigatorMode = NavigatorMode.BarTabOnly
            UpdateControlsFromNavigator()
        End If
    End Sub

    Private Sub radioBarRibbonTabOnly_CheckedChanged(sender As Object, e As EventArgs) Handles radioBarRibbonTabOnly.CheckedChanged
        If radioBarRibbonTabOnly.Checked Then
            kryptonNavigator.NavigatorMode = NavigatorMode.BarRibbonTabOnly
            UpdateControlsFromNavigator()
        End If
    End Sub

    Private Sub radioBarCheckButtonGroupOnly_CheckedChanged(sender As Object, e As EventArgs) Handles radioBarCheckButtonGroupOnly.CheckedChanged
        If radioBarCheckButtonGroupOnly.Checked Then
            kryptonNavigator.NavigatorMode = NavigatorMode.BarCheckButtonGroupOnly
            UpdateControlsFromNavigator()
        End If
    End Sub

    Private Sub radioBarCheckButtonOnly_CheckedChanged(sender As Object, e As EventArgs) Handles radioBarCheckButtonOnly.CheckedChanged
        If radioBarCheckButtonOnly.Checked Then
            kryptonNavigator.NavigatorMode = NavigatorMode.BarCheckButtonOnly
            UpdateControlsFromNavigator()
        End If
    End Sub

    Private Sub radioHeaderBarCheckButtonOnly_CheckedChanged(sender As Object, e As EventArgs) Handles radioHeaderBarCheckButtonOnly.CheckedChanged
        If radioHeaderBarCheckButtonOnly.Checked Then
            kryptonNavigator.NavigatorMode = NavigatorMode.HeaderBarCheckButtonOnly
            UpdateControlsFromNavigator()
        End If
    End Sub

    Private Sub radioOutlookMini_CheckedChanged(sender As Object, e As EventArgs) Handles radioOutlookMini.CheckedChanged
        If radioOutlookMini.Checked Then
            kryptonNavigator.NavigatorMode = NavigatorMode.OutlookMini
            UpdateControlsFromNavigator()
        End If
    End Sub

    Private Sub radioOrientationTop_CheckedChanged(sender As Object, e As EventArgs) Handles radioOrientationTop.CheckedChanged
        If radioOrientationTop.Checked Then
            kryptonNavigator.Bar.BarOrientation = VisualOrientation.Top
            kryptonNavigator.Header.HeaderPositionBar = VisualOrientation.Top
            kryptonNavigator.Dock = DockStyle.Top
            UpdateControlsFromNavigator()
        End If
    End Sub

    Private Sub radioOrientationBottom_CheckedChanged(sender As Object, e As EventArgs) Handles radioOrientationBottom.CheckedChanged
        If radioOrientationBottom.Checked Then
            kryptonNavigator.Bar.BarOrientation = VisualOrientation.Bottom
            kryptonNavigator.Header.HeaderPositionBar = VisualOrientation.Bottom
            kryptonNavigator.Dock = DockStyle.Bottom
            UpdateControlsFromNavigator()
        End If
    End Sub

    Private Sub radioOrientationLeft_CheckedChanged(sender As Object, e As EventArgs) Handles radioOrientationLeft.CheckedChanged
        If radioOrientationLeft.Checked Then
            kryptonNavigator.Bar.BarOrientation = VisualOrientation.Left
            kryptonNavigator.Header.HeaderPositionBar = VisualOrientation.Left
            kryptonNavigator.Dock = DockStyle.Left
            UpdateControlsFromNavigator()
        End If
    End Sub

    Private Sub radioOrientationRight_CheckedChanged(sender As Object, e As EventArgs) Handles radioOrientationRight.CheckedChanged
        If radioOrientationRight.Checked Then
            kryptonNavigator.Bar.BarOrientation = VisualOrientation.Right
            kryptonNavigator.Header.HeaderPositionBar = VisualOrientation.Right
            kryptonNavigator.Dock = DockStyle.Right
            UpdateControlsFromNavigator()
        End If
    End Sub

    Private Sub numericBorder_ValueChanged(sender As Object, e As EventArgs) Handles numericBorder.ValueChanged
        kryptonNavigator.PopupPages.Border = Convert.ToInt32(numericBorder.Value)
        UpdateControlsFromNavigator()
    End Sub

    Private Sub numericGap_ValueChanged(sender As Object, e As EventArgs) Handles numericGap.ValueChanged
        kryptonNavigator.PopupPages.Gap = Convert.ToInt32(numericGap.Value)
        UpdateControlsFromNavigator()
    End Sub

    Private Sub comboBoxElement_SelectedIndexChanged(sender As Object, e As EventArgs) Handles comboBoxElement.SelectedIndexChanged
        kryptonNavigator.PopupPages.Element = CType([Enum].Parse(GetType(PopupPageElement), comboBoxElement.Text), PopupPageElement)
        UpdateControlsFromNavigator()
    End Sub

    Private Sub comboBoxPosition_SelectedIndexChanged(sender As Object, e As EventArgs) Handles comboBoxPosition.SelectedIndexChanged
        kryptonNavigator.PopupPages.Position = CType([Enum].Parse(GetType(PopupPagePosition), comboBoxPosition.Text), PopupPagePosition)
        UpdateControlsFromNavigator()
    End Sub

    Private Sub buttonClose_Click(sender As Object, e As EventArgs) Handles buttonClose.Click
        Close()
    End Sub

End Class
