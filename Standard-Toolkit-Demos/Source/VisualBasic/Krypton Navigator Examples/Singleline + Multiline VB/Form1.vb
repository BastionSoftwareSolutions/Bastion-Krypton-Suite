#Region "BSD License"
'
' Original BSD 3-Clause License (https://github.com/ComponentFactory/Krypton/blob/master/LICENSE)
'  © Component Factory Pty Ltd, 2006 - 2016, (Version 4.5.0.0) All rights reserved.
'
'  New BSD 3-Clause License (https://github.com/Krypton-Suite/Standard-Toolkit/blob/master/LICENSE)
'  Modifications by Peter Wagner(aka Wagnerp) & Simon Coghlan(aka Smurf-IV), et al. 2017 - 2024. All rights reserved.
'
' VB.NET twin of Source\Krypton Navigator Examples\Singleline + Multiline\Form1.cs (Bastion Phase 4c).
#End Region

Imports System
Imports System.Drawing
Imports System.Windows.Forms

Imports Krypton.Navigator
Imports Krypton.Toolkit

Public Class Form1

    Private _newPage As Integer = 7

    Private Sub Form1_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        UpdateControlsFromNavigator()
    End Sub

    Private Sub UpdateControlsFromNavigator()
        ' We only show the next/prev buttons when in singleline/expandline modes
        If (kryptonNavigator1.Bar.BarMultiline = BarMultiline.Singleline) OrElse
           (kryptonNavigator1.Bar.BarMultiline = BarMultiline.Expandline) Then
            kryptonNavigator1.Button.ButtonDisplayLogic = ButtonDisplayLogic.NextPrevious
        Else
            kryptonNavigator1.Button.ButtonDisplayLogic = ButtonDisplayLogic.Context
        End If

        ' Update BarMultiline setting
        radioSingleline.Checked = (kryptonNavigator1.Bar.BarMultiline = BarMultiline.Singleline)
        radioMultiline.Checked = (kryptonNavigator1.Bar.BarMultiline = BarMultiline.Multiline)
        radioExactline.Checked = (kryptonNavigator1.Bar.BarMultiline = BarMultiline.Exactline)
        radioShrinkline.Checked = (kryptonNavigator1.Bar.BarMultiline = BarMultiline.Shrinkline)
        radioExpandline.Checked = (kryptonNavigator1.Bar.BarMultiline = BarMultiline.Expandline)

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

        ' Set mode specific properties
        Select Case kryptonNavigator1.NavigatorMode
            Case NavigatorMode.BarRibbonTabGroup, NavigatorMode.BarRibbonTabOnly
                kryptonNavigator1.PageBackStyle = PaletteBackStyle.ControlRibbon
                kryptonNavigator1.Group.GroupBackStyle = PaletteBackStyle.ControlRibbon
                kryptonNavigator1.Group.GroupBorderStyle = PaletteBorderStyle.ControlRibbon
            Case Else
                kryptonNavigator1.PageBackStyle = PaletteBackStyle.ControlClient
                kryptonNavigator1.Group.GroupBackStyle = PaletteBackStyle.ControlClient
                kryptonNavigator1.Group.GroupBorderStyle = PaletteBorderStyle.ControlClient
        End Select
    End Sub

    Private Sub radioSingleline_CheckedChanged(sender As Object, e As EventArgs) Handles radioSingleline.CheckedChanged
        If radioSingleline.Checked Then
            kryptonNavigator1.Bar.BarMultiline = BarMultiline.Singleline
            UpdateControlsFromNavigator()
        End If
    End Sub

    Private Sub radioMultiline_CheckedChanged(sender As Object, e As EventArgs) Handles radioMultiline.CheckedChanged
        If radioMultiline.Checked Then
            kryptonNavigator1.Bar.BarMultiline = BarMultiline.Multiline
            UpdateControlsFromNavigator()
        End If
    End Sub

    Private Sub radioExactline_CheckedChanged(sender As Object, e As EventArgs) Handles radioExactline.CheckedChanged
        If radioExactline.Checked Then
            kryptonNavigator1.Bar.BarMultiline = BarMultiline.Exactline
            UpdateControlsFromNavigator()
        End If
    End Sub

    Private Sub radioShrinkline_CheckedChanged(sender As Object, e As EventArgs) Handles radioShrinkline.CheckedChanged
        If radioShrinkline.Checked Then
            kryptonNavigator1.Bar.BarMultiline = BarMultiline.Shrinkline
            UpdateControlsFromNavigator()
        End If
    End Sub

    Private Sub radioExpandline_CheckedChanged(sender As Object, e As EventArgs) Handles radioExpandline.CheckedChanged
        If radioExpandline.Checked Then
            kryptonNavigator1.Bar.BarMultiline = BarMultiline.Expandline
            UpdateControlsFromNavigator()
        End If
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

    Private Sub buttonAddPage_Click(sender As Object, e As EventArgs) Handles buttonAddPage.Click
        Dim newPage = New KryptonPage()
        newPage.Text = $"Page {_newPage}"
        newPage.ImageSmall = DirectCast(imageList1.Images(_newPage Mod imageList1.Images.Count), Bitmap)
        _newPage += 1
        kryptonNavigator1.Pages.Add(newPage)
    End Sub

    Private Sub buttonClearAllPages_Click(sender As Object, e As EventArgs) Handles buttonClearAllPages.Click
        kryptonNavigator1.Pages.Clear()
    End Sub

    Private Sub buttonClose_Click(sender As Object, e As EventArgs) Handles buttonClose.Click
        Close()
    End Sub

End Class
