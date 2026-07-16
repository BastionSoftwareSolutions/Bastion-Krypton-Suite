#Region "BSD License"
'
' Original BSD 3-Clause License (https://github.com/ComponentFactory/Krypton/blob/master/LICENSE)
'  © Component Factory Pty Ltd, 2006 - 2016, (Version 4.5.0.0) All rights reserved.
'
'  New BSD 3-Clause License (https://github.com/Krypton-Suite/Standard-Toolkit/blob/master/LICENSE)
'  Modifications by Peter Wagner(aka Wagnerp) & Simon Coghlan(aka Smurf-IV), et al. 2017 - 2024. All rights reserved.
'
' VB.NET twin of Source\Krypton Toolkit Examples\KryptonPalette Examples\Form1.cs (Bastion Phase 4c).
#End Region

Imports System
Imports System.IO
Imports System.Windows.Forms

Imports Krypton.Toolkit

Public Class Form1

    Public Sub New()
        InitializeComponent()
    End Sub

    Private Sub btnExport_Click(sender As Object, e As EventArgs) Handles btnExport.Click
        kryptonPaletteCustom.Export()

        btnExport.Enabled = False
    End Sub

    Private Sub btnImportCustomPalette_Click(sender As Object, e As EventArgs) Handles btnImportCustomPalette.Click
        Try
            kryptonPaletteCustom.Import()

            'kryptonThemeComboBox1..Manager.GlobalCustomPalette = kryptonPaletteCustom
            propertyGrid.SelectedObject = kryptonPaletteCustom

            'kryptonThemeComboBox1.Manager.GlobalPaletteMode = PaletteMode.Custom
        Catch exc As Exception
            KryptonMessageBox.Show(Me, exc.ToString())
        End Try
    End Sub

    ' NOTE: mirrors the C# twin, where this handler is not wired to any control in the designer.
    Private Sub kryptonThemeComboBox1_SelectedIndexChanged(sender As Object, e As EventArgs)
        btnExport.Enabled = (kryptonThemeComboBox1.Text = "Custom")
        If btnExport.Enabled Then
            propertyGrid.SelectedObject = kryptonPaletteCustom
        Else
            'propertyGrid.SelectedObject = New KryptonCustomPaletteBase(components) With {
            '    .BasePaletteMode = kryptonThemeComboBox1.Manager.GlobalPaletteMode
            '}
            'propertyGrid.SelectedObject = kryptonThemeComboBox1.Manager.GlobalPaletteMode
        End If
    End Sub

    ' NOTE: mirrors the C# twin, where this handler is not wired to any control in the designer.
    Private Sub button1_Click(sender As Object, e As EventArgs)
        Try
            ' Simulate loading from Stream (i.e. from application resource) by acquiring filename first
            Using kofd As New KryptonOpenFileDialog With {
                .CheckFileExists = True,
                .CheckPathExists = True,
                .DefaultExt = "xml",
                .Filter = "Palette files (*.xml)|*.xml|All files (*.*)|(*.*)",
                .Title = "Load Custom Palette"
            }
                Dim paletteFileName As String = If(kofd.ShowDialog() = DialogResult.OK,
                    kofd.FileName,
                    String.Empty)
                If String.IsNullOrWhiteSpace(paletteFileName) Then
                    Return
                End If
                kryptonPaletteCustom.ImportWithUpgrade(File.OpenRead(paletteFileName))

                'kryptonThemeComboBox1.Manager.GlobalCustomPalette = kryptonPaletteCustom
                propertyGrid.SelectedObject = New KryptonCustomPaletteBase(components)
                'kryptonThemeComboBox1.Manager.GlobalPaletteMode = PaletteMode.Custom
            End Using
        Catch exc As Exception
            KryptonMessageBox.Show(Me, exc.ToString())
        End Try
    End Sub

    ' NOTE: mirrors the C# twin, where this handler is not wired to any control in the designer.
    Private Sub Form1_OnShown(sender As Object, e As EventArgs)
        propertyGrid.SelectedObject = New KryptonCustomPaletteBase(components)
    End Sub

    ' NOTE: mirrors the C# twin, where this handler is not wired to any control in the designer.
    Private Sub button1_Click_1(sender As Object, e As EventArgs)

    End Sub

End Class
