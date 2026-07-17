' Original BSD 3-Clause License (https://github.com/ComponentFactory/Krypton/blob/master/LICENSE)
'  © Component Factory Pty Ltd, 2006 - 2016, (Version 4.5.0.0) All rights reserved.
'
'  New BSD 3-Clause License (https://github.com/Krypton-Suite/Standard-Toolkit/blob/master/LICENSE)
'  Modifications by Peter Wagner(aka Wagnerp) & Simon Coghlan(aka Smurf-IV), et al. 2017 - 2024. All rights reserved.
'
' VB.NET twin of Source\Krypton Toolkit Examples\KryptonGroup Examples\Form1.cs (Bastion Phase 4c).

Imports System.ComponentModel
Imports System.Drawing
Imports System.Windows.Forms

Imports Krypton.Toolkit

Public Class Form1

    Public Sub New()
        InitializeComponent()
    End Sub

    Private Sub Form1_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        ' Setup the property grid to edit this group
        propertyGrid.SelectedObject = New KryptonGroupProxy(group1Office)
    End Sub

    Private Sub group_MouseDown(sender As Object, e As MouseEventArgs) Handles _
        group1Office.MouseDown, group2Office.MouseDown, group3Office.MouseDown, group4Office.MouseDown,
        group1System.MouseDown, group2System.MouseDown, group3System.MouseDown, group4System.MouseDown,
        group1Custom.MouseDown, group2Custom.MouseDown, group3Custom.MouseDown, group4Custom.MouseDown
        ' Setup the property grid to edit this group
        propertyGrid.SelectedObject = New KryptonGroupProxy(CType(sender, KryptonGroup))
    End Sub

    Private Sub panel_MouseDown(sender As Object, e As MouseEventArgs) Handles _
        group1Office.Panel.MouseDown, group2Office.Panel.MouseDown, group3Office.Panel.MouseDown, group4Office.Panel.MouseDown,
        group1System.Panel.MouseDown, group2System.Panel.MouseDown, group3System.Panel.MouseDown, group4System.Panel.MouseDown,
        group1Custom.Panel.MouseDown, group2Custom.Panel.MouseDown, group3Custom.Panel.MouseDown, group4Custom.Panel.MouseDown
        Dim c As Control = CType(sender, Control)

        ' Setup the property grid to edit this panel parent group
        propertyGrid.SelectedObject = New KryptonGroupProxy(CType(c.Parent, KryptonGroup))
    End Sub

    Private Sub buttonClose_Click(sender As Object, e As EventArgs) Handles buttonClose.Click
        Close()
    End Sub

End Class

Public Class KryptonGroupProxy

    Private _group As KryptonGroup

    Public Sub New(group As KryptonGroup)
        _group = group
    End Sub

    <Category("Visuals")>
    <Description("Border style.")>
    <DefaultValue(PaletteBorderStyle.ControlClient)>
    Public Property GroupBorderStyle() As PaletteBorderStyle
        Get
            Return _group.GroupBorderStyle
        End Get
        Set(value As PaletteBorderStyle)
            _group.GroupBorderStyle = value
        End Set
    End Property

    <Category("Visuals")>
    <Description("Background style.")>
    <DefaultValue(PaletteBackStyle.ControlClient)>
    Public Property GroupBackStyle() As PaletteBackStyle
        Get
            Return _group.GroupBackStyle
        End Get
        Set(value As PaletteBackStyle)
            _group.GroupBackStyle = value
        End Set
    End Property

    <Category("Visuals")>
    <Description("Overrides for defining common group appearance that other states can override.")>
    Public ReadOnly Property StateCommon() As PaletteDoubleRedirect
        Get
            Return _group.StateCommon
        End Get
    End Property

    <Category("Visuals")>
    <Description("Overrides for defining disabled group appearance.")>
    Public ReadOnly Property StateDisabled() As PaletteDouble
        Get
            Return _group.StateDisabled
        End Get
    End Property

    <Category("Visuals")>
    <Description("Overrides for defining normal group appearance.")>
    Public ReadOnly Property StateNormal() As PaletteDouble
        Get
            Return _group.StateNormal
        End Get
    End Property

    <Category("Visuals")>
    <Description("Palette applied to drawing.")>
    <DefaultValue(PaletteMode.Global)>
    Public Property PaletteMode() As PaletteMode
        Get
            Return _group.PaletteMode
        End Get
        Set(value As PaletteMode)
            _group.PaletteMode = value
        End Set
    End Property

    <Category("Layout")>
    <Description("The size of the control is pixels.")>
    Public Property Size() As Size
        Get
            Return _group.Size
        End Get
        Set(value As Size)
            _group.Size = value
        End Set
    End Property

    <Category("Layout")>
    <Description("The location of the control in pixels.")>
    Public Property Location() As Point
        Get
            Return _group.Location
        End Get
        Set(value As Point)
            _group.Location = value
        End Set
    End Property

End Class
