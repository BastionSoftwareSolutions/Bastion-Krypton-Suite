#Region "BSD License"
'
' Original BSD 3-Clause License (https://github.com/ComponentFactory/Krypton/blob/master/LICENSE)
'  © Component Factory Pty Ltd, 2006 - 2016, (Version 4.5.0.0) All rights reserved.
'
'  New BSD 3-Clause License (https://github.com/Krypton-Suite/Standard-Toolkit/blob/master/LICENSE)
'  Modifications by Peter Wagner(aka Wagnerp) & Simon Coghlan(aka Smurf-IV), et al. 2017 - 2024. All rights reserved.
'
' VB.NET twin of Source\Krypton Navigator Examples\Navigator ToolTips\Form1.cs (Bastion Phase 4c).
#End Region

Imports System
Imports System.Windows.Forms

Imports Krypton.Navigator

Public Class Form1

    Private _textConv As New MapKryptonPageTextConverter()
    Private _imageConv As New MapKryptonPageImageConverter()

    Private Sub Form1_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        ' NOTE: Upstream quirk preserved from the C# twin - a converter is created and discarded here.
        Dim unused As New MapKryptonPageImageConverter()

        ' Populate the text/extra text mapping combo boxes
        For Each value As MapKryptonPageText In [Enum].GetValues(GetType(MapKryptonPageText))
            comboMapText.Items.Add(_textConv.ConvertToInvariantString(value))
            comboMapExtraText.Items.Add(_textConv.ConvertToInvariantString(value))
        Next

        ' Populate the image mapping combo box
        For Each value As MapKryptonPageImage In [Enum].GetValues(GetType(MapKryptonPageImage))
            comboMapImage.Items.Add(_imageConv.ConvertToInvariantString(value))
        Next

        ' Update with current navigator settings
        checkAllowPageTooltips.Checked = kryptonNavigator.ToolTips.AllowPageToolTips
        checkAllowButtonSpecTooltips.Checked = kryptonNavigator.ToolTips.AllowButtonSpecToolTips
        comboMapText.Text = _textConv.ConvertToInvariantString(kryptonNavigator.ToolTips.MapText)
        comboMapExtraText.Text = _textConv.ConvertToInvariantString(kryptonNavigator.ToolTips.MapExtraText)
        comboMapImage.Text = _imageConv.ConvertToInvariantString(kryptonNavigator.ToolTips.MapImage)
    End Sub

    Private Sub checkAllowPageTooltips_CheckedChanged(sender As Object, e As EventArgs) Handles checkAllowPageTooltips.CheckedChanged
        kryptonNavigator.ToolTips.AllowPageToolTips = checkAllowPageTooltips.Checked
    End Sub

    Private Sub checkAllowButtonSpecTooltips_CheckedChanged(sender As Object, e As EventArgs) Handles checkAllowButtonSpecTooltips.CheckedChanged
        kryptonNavigator.ToolTips.AllowButtonSpecToolTips = checkAllowButtonSpecTooltips.Checked
    End Sub

    Private Sub comboMapText_SelectedIndexChanged(sender As Object, e As EventArgs) Handles comboMapText.SelectedIndexChanged
        kryptonNavigator.ToolTips.MapText = CType(_textConv.ConvertFromInvariantString(comboMapText.Text), MapKryptonPageText)
    End Sub

    Private Sub comboMapExtraText_SelectedIndexChanged(sender As Object, e As EventArgs) Handles comboMapExtraText.SelectedIndexChanged
        kryptonNavigator.ToolTips.MapExtraText = CType(_textConv.ConvertFromInvariantString(comboMapExtraText.Text), MapKryptonPageText)
    End Sub

    Private Sub comboMapImage_SelectedIndexChanged(sender As Object, e As EventArgs) Handles comboMapImage.SelectedIndexChanged
        kryptonNavigator.ToolTips.MapImage = CType(_imageConv.ConvertFromInvariantString(comboMapImage.Text), MapKryptonPageImage)
    End Sub

    Private Sub buttonClose_Click(sender As Object, e As EventArgs) Handles buttonClose.Click
        Close()
    End Sub

End Class
