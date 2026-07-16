#Region "BSD License"
'
' Original BSD 3-Clause License (https://github.com/ComponentFactory/Krypton/blob/master/LICENSE)
'  © Component Factory Pty Ltd, 2006 - 2016, (Version 4.5.0.0) All rights reserved.
'
'  New BSD 3-Clause License (https://github.com/Krypton-Suite/Standard-Toolkit/blob/master/LICENSE)
'  Modifications by Peter Wagner(aka Wagnerp) & Simon Coghlan(aka Smurf-IV), et al. 2017 - 2024. All rights reserved.
'
' VB.NET twin of Source\Krypton Docking Examples\External Drag To Docking\ContentPropertyGrid.cs (Bastion Phase 4c).
#End Region

Imports System
Imports System.Drawing
Imports System.Windows.Forms

Imports Krypton.Toolkit

Public Class ContentPropertyGrid

    Public Sub New()
        InitializeComponent()
    End Sub

    ''' <summary>
    ''' Clean up any resources being used.
    ''' </summary>
    ''' <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
    Protected Overrides Sub Dispose(disposing As Boolean)
        ' Unhook from events so this control can be garbage collected
        RemoveHandler KryptonManager.GlobalPaletteChanged, AddressOf OnGlobalPaletteChanged

        If disposing Then
            components?.Dispose()
        End If
        MyBase.Dispose(disposing)
    End Sub

    Private Sub ContentPropertyGrid_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        ' Hook into global palette changes
        AddHandler KryptonManager.GlobalPaletteChanged, AddressOf OnGlobalPaletteChanged

        ' Set correct initial font for the property grid
        OnGlobalPaletteChanged(Nothing, EventArgs.Empty)
    End Sub

    Private Sub OnGlobalPaletteChanged(sender As Object, e As EventArgs)
        ' Use the current font from the global palette
        Dim palette = KryptonManager.CurrentGlobalPalette
        Dim font As Font = palette.GetContentShortTextFont(PaletteContentStyle.LabelNormalControl, PaletteState.Normal)
        propertyGrid1.Font = font
    End Sub

End Class
