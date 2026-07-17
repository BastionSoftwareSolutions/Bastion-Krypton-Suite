#Region "BSD License"
'
' Original BSD 3-Clause License (https://github.com/ComponentFactory/Krypton/blob/master/LICENSE)
'  © Component Factory Pty Ltd, 2006 - 2016, (Version 4.5.0.0) All rights reserved.
'
'  New BSD 3-Clause License (https://github.com/Krypton-Suite/Standard-Toolkit/blob/master/LICENSE)
'  Modifications by Peter Wagner(aka Wagnerp) & Simon Coghlan(aka Smurf-IV), et al. 2017 - 2024. All rights reserved.
'
' VB.NET twin of Source\Krypton Toolkit Examples\ButtonSpec Playground\Form1.cs (Bastion Phase 4c).
#End Region

Imports System
Imports System.Windows.Forms

Imports Krypton.Toolkit

Public Class Form1

    Public Sub New()
        InitializeComponent()
        kryptonButtonAdd_Click(Me, EventArgs.Empty)
    End Sub

    Private Sub kryptonButtonAdd_Click(sender As Object, e As EventArgs) Handles kryptonButtonAdd.Click
        ' Create a new button spec entry
        Dim spec As New ButtonSpecHeaderGroup()
        spec.Type = PaletteButtonSpecStyle.Close

        ' Need to know when button is selected
        AddHandler spec.Click, AddressOf OnButtonSelected

        ' Add to end of the collection of button specs
        kryptonHeaderGroup1.ButtonSpecs.Add(spec)

        ' Make it the selected button spec
        propertyGrid.SelectedObject = spec

        UpdateActionButtons()
    End Sub

    Private Sub kryptonButtonRemove_Click(sender As Object, e As EventArgs) Handles kryptonButtonRemove.Click
        ' Get access to the selected button spec
        Dim spec = TryCast(propertyGrid.SelectedObject, ButtonSpecHeaderGroup)
        If spec IsNot Nothing Then
            ' Remove just the selected button spec
            kryptonHeaderGroup1.ButtonSpecs.Remove(spec)

            ' Nothing selected in the property grid
            propertyGrid.SelectedObject = Nothing

            UpdateActionButtons()
        End If
    End Sub

    Private Sub kryptonButtonClear_Click(sender As Object, e As EventArgs) Handles kryptonButtonClear.Click
        ' Remove all the button specifications
        kryptonHeaderGroup1.ButtonSpecs.Clear()

        ' Nothing selected in the property grid
        propertyGrid.SelectedObject = Nothing

        UpdateActionButtons()
    End Sub

    Private Sub kryptonButtonTopP_Click(sender As Object, e As EventArgs) Handles kryptonButtonTopP.Click
        kryptonHeaderGroup1.HeaderPositionPrimary = VisualOrientation.Top
    End Sub

    Private Sub kryptonButtonLeftP_Click(sender As Object, e As EventArgs) Handles kryptonButtonLeftP.Click
        kryptonHeaderGroup1.HeaderPositionPrimary = VisualOrientation.Left
    End Sub

    Private Sub kryptonButtonRightP_Click(sender As Object, e As EventArgs) Handles kryptonButtonRightP.Click
        kryptonHeaderGroup1.HeaderPositionPrimary = VisualOrientation.Right
    End Sub

    Private Sub kryptonButtonBottomP_Click(sender As Object, e As EventArgs) Handles kryptonButtonBottomP.Click
        kryptonHeaderGroup1.HeaderPositionPrimary = VisualOrientation.Bottom
    End Sub

    Private Sub kryptonButtonTopS_Click(sender As Object, e As EventArgs) Handles kryptonButtonTopS.Click
        kryptonHeaderGroup1.HeaderPositionSecondary = VisualOrientation.Top
    End Sub

    Private Sub kryptonButtonLeftS_Click(sender As Object, e As EventArgs) Handles kryptonButtonLeftS.Click
        kryptonHeaderGroup1.HeaderPositionSecondary = VisualOrientation.Left
    End Sub

    Private Sub kryptonButtonRightS_Click(sender As Object, e As EventArgs) Handles kryptonButtonRightS.Click
        kryptonHeaderGroup1.HeaderPositionSecondary = VisualOrientation.Right
    End Sub

    Private Sub kryptonButtonBottomS_Click(sender As Object, e As EventArgs) Handles kryptonButtonBottomS.Click
        kryptonHeaderGroup1.HeaderPositionSecondary = VisualOrientation.Bottom
    End Sub

    Private Sub OnButtonSelected(sender As Object, e As EventArgs)
        ' Cast to correct type
        Dim spec = DirectCast(sender, ButtonSpecHeaderGroup)

        ' Make it the selected button spec
        propertyGrid.SelectedObject = spec

        UpdateActionButtons()
    End Sub

    Private Sub UpdateActionButtons()
        kryptonButtonRemove.Enabled = propertyGrid.SelectedObject IsNot Nothing
        kryptonButtonClear.Enabled = kryptonHeaderGroup1.ButtonSpecs.Count > 0
    End Sub

End Class
