#Region "BSD License"
'
' Original BSD 3-Clause License (https://github.com/ComponentFactory/Krypton/blob/master/LICENSE)
'  © Component Factory Pty Ltd, 2006 - 2016, (Version 4.5.0.0) All rights reserved.
'
'  New BSD 3-Clause License (https://github.com/Krypton-Suite/Standard-Toolkit/blob/master/LICENSE)
'  Modifications by Peter Wagner(aka Wagnerp) & Simon Coghlan(aka Smurf-IV), et al. 2017 - 2024. All rights reserved.
'
' VB.NET twin of Source\Krypton Navigator Examples\Orientation + Alignment\Form1.cs (Bastion Phase 4c).
#End Region

Imports System
Imports System.Drawing
Imports System.Windows.Forms

Imports Krypton.Navigator
Imports Krypton.Toolkit

Public Class Form1

    Private _updating As Boolean

    Private Sub Form1_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        UpdateControlsFromNavigator()
    End Sub

    Private Sub UpdateControlsFromNavigator()
        _updating = True

        ' Update Mode
        radioModeTabs.Checked = (kryptonNavigator1.NavigatorMode = NavigatorMode.BarTabGroup)
        radioModeRibbonTabs.Checked = (kryptonNavigator1.NavigatorMode = NavigatorMode.BarRibbonTabGroup)
        radioModesCheckButton.Checked = (kryptonNavigator1.NavigatorMode = NavigatorMode.BarCheckButtonGroupOutside)

        ' Update Bar Orientation
        radioOrientationTop.Checked = (kryptonNavigator1.Bar.BarOrientation = VisualOrientation.Top)
        radioOrientationBottom.Checked = (kryptonNavigator1.Bar.BarOrientation = VisualOrientation.Bottom)
        radioOrientationLeft.Checked = (kryptonNavigator1.Bar.BarOrientation = VisualOrientation.Left)
        radioOrientationRight.Checked = (kryptonNavigator1.Bar.BarOrientation = VisualOrientation.Right)

        ' Update Item Orientation
        radioItemAuto.Checked = (kryptonNavigator1.Bar.ItemOrientation = ButtonOrientation.Auto)
        radioItemFixedTop.Checked = (kryptonNavigator1.Bar.ItemOrientation = ButtonOrientation.FixedTop)
        radioItemFixedBottom.Checked = (kryptonNavigator1.Bar.ItemOrientation = ButtonOrientation.FixedBottom)
        radioItemFixedLeft.Checked = (kryptonNavigator1.Bar.ItemOrientation = ButtonOrientation.FixedLeft)
        radioItemFixedRight.Checked = (kryptonNavigator1.Bar.ItemOrientation = ButtonOrientation.FixedRight)

        ' Update Item Alignment
        radioItemNear.Checked = (kryptonNavigator1.Bar.ItemAlignment = RelativePositionAlign.Near)
        radioItemCenter.Checked = (kryptonNavigator1.Bar.ItemAlignment = RelativePositionAlign.Center)
        radioItemFar.Checked = (kryptonNavigator1.Bar.ItemAlignment = RelativePositionAlign.Far)

        ' Update Item Sizing
        radioSizingIndividual.Checked = (kryptonNavigator1.Bar.ItemSizing = BarItemSizing.Individual)
        radioSizingSameHeight.Checked = (kryptonNavigator1.Bar.ItemSizing = BarItemSizing.SameHeight)
        radioSizingSameWidth.Checked = (kryptonNavigator1.Bar.ItemSizing = BarItemSizing.SameWidth)
        radioSizingSameWidthHeight.Checked = (kryptonNavigator1.Bar.ItemSizing = BarItemSizing.SameWidthAndHeight)

        ' Update sizing values
        numericUpDownBarFirstItemInset.Value = kryptonNavigator1.Bar.BarFirstItemInset
        numericUpDownBarMinHeight.Value = kryptonNavigator1.Bar.BarMinimumHeight
        numericUpDownMinItemSizeX.Value = kryptonNavigator1.Bar.ItemMinimumSize.Width
        numericUpDownMinItemSizeY.Value = kryptonNavigator1.Bar.ItemMinimumSize.Height
        numericUpDownMaxItemSizeX.Value = kryptonNavigator1.Bar.ItemMaximumSize.Width
        numericUpDownMaxItemSizeY.Value = kryptonNavigator1.Bar.ItemMaximumSize.Height

        ' Set mode specific properties
        Select Case kryptonNavigator1.NavigatorMode
            Case NavigatorMode.BarRibbonTabGroup
                kryptonNavigator1.PageBackStyle = PaletteBackStyle.ControlRibbon
                kryptonNavigator1.Group.GroupBackStyle = PaletteBackStyle.ControlRibbon
                kryptonNavigator1.Group.GroupBorderStyle = PaletteBorderStyle.ControlRibbon
            Case Else
                kryptonNavigator1.PageBackStyle = PaletteBackStyle.ControlClient
                kryptonNavigator1.Group.GroupBackStyle = PaletteBackStyle.ControlClient
                kryptonNavigator1.Group.GroupBorderStyle = PaletteBorderStyle.ControlClient
        End Select

        _updating = False
    End Sub

    Private Sub radioModeTabs_CheckedChanged(sender As Object, e As EventArgs) Handles radioModeTabs.CheckedChanged
        If radioModeTabs.Checked Then
            kryptonNavigator1.NavigatorMode = NavigatorMode.BarTabGroup
            UpdateControlsFromNavigator()
        End If
    End Sub

    Private Sub radioModeRibbonTabs_CheckedChanged(sender As Object, e As EventArgs) Handles radioModeRibbonTabs.CheckedChanged
        If radioModeRibbonTabs.Checked Then
            kryptonNavigator1.NavigatorMode = NavigatorMode.BarRibbonTabGroup
            UpdateControlsFromNavigator()
        End If
    End Sub

    Private Sub radioModesCheckButton_CheckedChanged(sender As Object, e As EventArgs) Handles radioModesCheckButton.CheckedChanged
        If radioModesCheckButton.Checked Then
            kryptonNavigator1.NavigatorMode = NavigatorMode.BarCheckButtonGroupOutside
            UpdateControlsFromNavigator()
        End If
    End Sub

    Private Sub radioOrientationTop_CheckedChanged(sender As Object, e As EventArgs) Handles radioOrientationTop.CheckedChanged
        If radioOrientationTop.Checked Then
            kryptonNavigator1.Bar.BarOrientation = VisualOrientation.Top
            UpdateControlsFromNavigator()
        End If
    End Sub

    Private Sub radioOrientationBottom_CheckedChanged(sender As Object, e As EventArgs) Handles radioOrientationBottom.CheckedChanged
        If radioOrientationBottom.Checked Then
            kryptonNavigator1.Bar.BarOrientation = VisualOrientation.Bottom
            UpdateControlsFromNavigator()
        End If
    End Sub

    Private Sub radioOrientationLeft_CheckedChanged(sender As Object, e As EventArgs) Handles radioOrientationLeft.CheckedChanged
        If radioOrientationLeft.Checked Then
            kryptonNavigator1.Bar.BarOrientation = VisualOrientation.Left
            UpdateControlsFromNavigator()
        End If
    End Sub

    Private Sub radioOrientationRight_CheckedChanged(sender As Object, e As EventArgs) Handles radioOrientationRight.CheckedChanged
        If radioOrientationRight.Checked Then
            kryptonNavigator1.Bar.BarOrientation = VisualOrientation.Right
            UpdateControlsFromNavigator()
        End If
    End Sub

    Private Sub radioItemAuto_CheckedChanged(sender As Object, e As EventArgs) Handles radioItemAuto.CheckedChanged
        If radioItemAuto.Checked Then
            kryptonNavigator1.Bar.ItemOrientation = ButtonOrientation.Auto
            UpdateControlsFromNavigator()
        End If
    End Sub

    Private Sub radioItemFixedTop_CheckedChanged(sender As Object, e As EventArgs) Handles radioItemFixedTop.CheckedChanged
        If radioItemFixedTop.Checked Then
            kryptonNavigator1.Bar.ItemOrientation = ButtonOrientation.FixedTop
            UpdateControlsFromNavigator()
        End If
    End Sub

    Private Sub radioItemFixedBottom_CheckedChanged(sender As Object, e As EventArgs) Handles radioItemFixedBottom.CheckedChanged
        If radioItemFixedBottom.Checked Then
            kryptonNavigator1.Bar.ItemOrientation = ButtonOrientation.FixedBottom
            UpdateControlsFromNavigator()
        End If
    End Sub

    Private Sub radioItemFixedLeft_CheckedChanged(sender As Object, e As EventArgs) Handles radioItemFixedLeft.CheckedChanged
        If radioItemFixedLeft.Checked Then
            kryptonNavigator1.Bar.ItemOrientation = ButtonOrientation.FixedLeft
            UpdateControlsFromNavigator()
        End If
    End Sub

    Private Sub radioItemFixedRight_CheckedChanged(sender As Object, e As EventArgs) Handles radioItemFixedRight.CheckedChanged
        If radioItemFixedRight.Checked Then
            kryptonNavigator1.Bar.ItemOrientation = ButtonOrientation.FixedRight
            UpdateControlsFromNavigator()
        End If
    End Sub

    Private Sub radioItemNear_CheckedChanged(sender As Object, e As EventArgs) Handles radioItemNear.CheckedChanged
        If radioItemNear.Checked Then
            kryptonNavigator1.Bar.ItemAlignment = RelativePositionAlign.Near
            UpdateControlsFromNavigator()
        End If
    End Sub

    Private Sub radioItemCenter_CheckedChanged(sender As Object, e As EventArgs) Handles radioItemCenter.CheckedChanged
        If radioItemCenter.Checked Then
            kryptonNavigator1.Bar.ItemAlignment = RelativePositionAlign.Center
            UpdateControlsFromNavigator()
        End If
    End Sub

    Private Sub radioItemFar_CheckedChanged(sender As Object, e As EventArgs) Handles radioItemFar.CheckedChanged
        If radioItemFar.Checked Then
            kryptonNavigator1.Bar.ItemAlignment = RelativePositionAlign.Far
            UpdateControlsFromNavigator()
        End If
    End Sub

    Private Sub radioSizingIndividual_CheckedChanged(sender As Object, e As EventArgs) Handles radioSizingIndividual.CheckedChanged
        If radioSizingIndividual.Checked Then
            kryptonNavigator1.Bar.ItemSizing = BarItemSizing.Individual
            UpdateControlsFromNavigator()
        End If
    End Sub

    Private Sub radioSizingSameHeight_CheckedChanged(sender As Object, e As EventArgs) Handles radioSizingSameHeight.CheckedChanged
        If radioSizingSameHeight.Checked Then
            kryptonNavigator1.Bar.ItemSizing = BarItemSizing.SameHeight
            UpdateControlsFromNavigator()
        End If
    End Sub

    Private Sub radioSizingSameWidth_CheckedChanged(sender As Object, e As EventArgs) Handles radioSizingSameWidth.CheckedChanged
        If radioSizingSameWidth.Checked Then
            kryptonNavigator1.Bar.ItemSizing = BarItemSizing.SameWidth
            UpdateControlsFromNavigator()
        End If
    End Sub

    Private Sub radioSizingSameWidthHeight_CheckedChanged(sender As Object, e As EventArgs) Handles radioSizingSameWidthHeight.CheckedChanged
        If radioSizingSameWidthHeight.Checked Then
            kryptonNavigator1.Bar.ItemSizing = BarItemSizing.SameWidthAndHeight
            UpdateControlsFromNavigator()
        End If
    End Sub

    Private Sub numericUpDownBarMinHeight_ValueChanged(sender As Object, e As EventArgs) Handles numericUpDownBarMinHeight.ValueChanged
        If Not _updating Then
            kryptonNavigator1.Bar.BarMinimumHeight = Convert.ToInt32(numericUpDownBarMinHeight.Value)
        End If
    End Sub

    Private Sub numericUpDownMinItemSize(sender As Object, e As EventArgs) Handles _
        numericUpDownMinItemSizeY.ValueChanged, numericUpDownMinItemSizeX.ValueChanged

        If Not _updating Then
            kryptonNavigator1.Bar.ItemMinimumSize = New Size(Convert.ToInt32(numericUpDownMinItemSizeX.Value),
                                                             Convert.ToInt32(numericUpDownMinItemSizeY.Value))
        End If
    End Sub

    Private Sub numericUpDownMaxItemSize(sender As Object, e As EventArgs) Handles _
        numericUpDownMaxItemSizeY.ValueChanged, numericUpDownMaxItemSizeX.ValueChanged

        If Not _updating Then
            kryptonNavigator1.Bar.ItemMaximumSize = New Size(Convert.ToInt32(numericUpDownMaxItemSizeX.Value),
                                                             Convert.ToInt32(numericUpDownMaxItemSizeY.Value))
        End If
    End Sub

    Private Sub numericUpDownBarFirstItemInset_ValueChanged(sender As Object, e As EventArgs) Handles numericUpDownBarFirstItemInset.ValueChanged
        If Not _updating Then
            kryptonNavigator1.Bar.BarFirstItemInset = Convert.ToInt32(numericUpDownBarFirstItemInset.Value)
        End If
    End Sub

    Private Sub buttonClose_Click(sender As Object, e As EventArgs) Handles buttonClose.Click
        Close()
    End Sub

End Class
