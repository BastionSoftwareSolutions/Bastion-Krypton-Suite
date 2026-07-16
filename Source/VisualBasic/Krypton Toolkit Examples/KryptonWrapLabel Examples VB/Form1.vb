#Region "BSD License"
'
' Original BSD 3-Clause License (https://github.com/ComponentFactory/Krypton/blob/master/LICENSE)
'  © Component Factory Pty Ltd, 2006 - 2016, (Version 4.5.0.0) All rights reserved.
'
'  New BSD 3-Clause License (https://github.com/Krypton-Suite/Standard-Toolkit/blob/master/LICENSE)
'  Modifications by Peter Wagner(aka Wagnerp) & Simon Coghlan(aka Smurf-IV), et al. 2017 - 2024. All rights reserved.
'
' VB.NET twin of Source\Krypton Toolkit Examples\KryptonWrapLabel Examples\Form1.cs (Bastion Phase 4c).
#End Region

Imports System.Windows.Forms

Imports Krypton.Toolkit

Public Class Form1

    Public Sub New()
        InitializeComponent()
    End Sub

    Private Sub Form1_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        propertyGrid.SelectedObject = kryptonWrapLabel
    End Sub

    Private Sub buttonNormal_Click(sender As Object, e As EventArgs) Handles buttonNormal.Click
        kryptonWrapLabel.LabelStyle = LabelStyle.NormalControl
        propertyGrid.SelectedObject = kryptonWrapLabel
    End Sub

    Private Sub buttonTitle_Click(sender As Object, e As EventArgs) Handles buttonTitle.Click
        kryptonWrapLabel.LabelStyle = LabelStyle.TitleControl
        propertyGrid.SelectedObject = kryptonWrapLabel
    End Sub

    Private Sub buttonClose_Click(sender As Object, e As EventArgs) Handles buttonClose.Click
        Close()
    End Sub

    Private Sub klwlblTest_LinkClicked(sender As Object, e As LinkLabelLinkClickedEventArgs) Handles klwlblTest.LinkClicked
        KryptonMessageBox.Show("Hello world!", "Test", KryptonMessageBoxButtons.OK,
            KryptonMessageBoxIcon.Information)
    End Sub

End Class
