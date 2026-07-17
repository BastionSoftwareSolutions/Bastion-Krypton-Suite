' Original BSD 3-Clause License (https://github.com/ComponentFactory/Krypton/blob/master/LICENSE)
'  © Component Factory Pty Ltd, 2006 - 2016, (Version 4.5.0.0) All rights reserved.
'
'  New BSD 3-Clause License (https://github.com/Krypton-Suite/Standard-Toolkit/blob/master/LICENSE)
'  Modifications by Peter Wagner(aka Wagnerp) & Simon Coghlan(aka Smurf-IV), tobitege et al. 2017 - 2025. All rights reserved.
'
' VB.NET twin of Source\Krypton Toolkit Examples\KryptonGroupBox Examples\Form1.cs (Bastion Phase 4c).

Imports System.ComponentModel
Imports System.Drawing
Imports System.Windows.Forms

Imports Krypton.Toolkit

Public Class Form1

    Public Sub New()
        InitializeComponent()
    End Sub

    Private Sub Form1_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        ' Setup the property grid to edit this header group
        propertyGrid.SelectedObject = New KryptonGroupBoxProxy(kryptonGroupBox1)
    End Sub

    Private Sub groupBox_MouseDown(sender As Object, e As MouseEventArgs) Handles kryptonGroupBox1.MouseDown, kryptonGroupBox2.MouseDown, kryptonGroupBox3.MouseDown, kryptonGroupBox4.MouseDown, kryptonGroupBox5.MouseDown, kryptonGroupBox6.MouseDown, MyBase.MouseDown
        ' Setup the property grid to edit this header group
        propertyGrid.SelectedObject = New KryptonGroupBoxProxy(CType(sender, KryptonGroupBox))
    End Sub

    Private Sub panel_MouseDown(sender As Object, e As MouseEventArgs) Handles kryptonGroupBox1.Panel.MouseDown, kryptonGroupBox2.Panel.MouseDown, kryptonGroupBox3.Panel.MouseDown, kryptonGroupBox4.Panel.MouseDown, kryptonGroupBox5.Panel.MouseDown, kryptonGroupBox6.Panel.MouseDown
        ' Setup the property grid to edit this panel parent header group
        Dim c As Control = CType(sender, Control)
        propertyGrid.SelectedObject = New KryptonGroupBoxProxy(CType(c.Parent, KryptonGroupBox))
    End Sub

    Private Sub buttonClose_Click(sender As Object, e As EventArgs) Handles buttonClose.Click
        Close()
    End Sub

End Class

Public Class KryptonGroupBoxProxy

    Private _groupBox As KryptonGroupBox

    Public Sub New(groupBox As KryptonGroupBox)
        _groupBox = groupBox
    End Sub

    <Category("Visuals")>
    <Description("Edge position of the caption.")>
    Public Property CaptionEdge() As VisualOrientation
        Get
            Return _groupBox.CaptionEdge
        End Get
        Set(value As VisualOrientation)
            _groupBox.CaptionEdge = value
        End Set
    End Property

    <Category("Visuals")>
    <Description("Orientation of the caption.")>
    Public Property CaptionOrientation() As ButtonOrientation
        Get
            Return _groupBox.CaptionOrientation
        End Get
        Set(value As ButtonOrientation)
            _groupBox.CaptionOrientation = value
        End Set
    End Property

    <Category("Visuals")>
    <Description("The percentage the caption should overlap the group area.")>
    <TypeConverter(GetType(OpacityConverter))>
    Public Property CaptionOverlap() As Double
        Get
            Return _groupBox.CaptionOverlap
        End Get
        Set(value As Double)
            _groupBox.CaptionOverlap = value
        End Set
    End Property

    <Category("Visuals")>
    <Description("Caption style.")>
    Public Property CaptionStyle() As LabelStyle
        Get
            Return _groupBox.CaptionStyle
        End Get
        Set(value As LabelStyle)
            _groupBox.CaptionStyle = value
        End Set
    End Property

    <Category("Visuals")>
    <Description("Caption visibility.")>
    Public Property CaptionVisible() As Boolean
        Get
            Return _groupBox.CaptionVisible
        End Get
        Set(value As Boolean)
            _groupBox.CaptionVisible = value
        End Set
    End Property

    <Category("Visuals")>
    <Description("Background style.")>
    Public Property GroupBackStyle() As PaletteBackStyle
        Get
            Return _groupBox.GroupBackStyle
        End Get
        Set(value As PaletteBackStyle)
            _groupBox.GroupBackStyle = value
        End Set
    End Property

    <Description("Border style.")>
    <Category("Visuals")>
    Public Property GroupBorderStyle() As PaletteBorderStyle
        Get
            Return _groupBox.GroupBorderStyle
        End Get
        Set(value As PaletteBorderStyle)
            _groupBox.GroupBorderStyle = value
        End Set
    End Property

    <Category("Appearance")>
    <Description("The internal panel that contains group content.")>
    Public ReadOnly Property Panel() As KryptonGroupPanel
        Get
            Return _groupBox.Panel
        End Get
    End Property

    <Category("Visuals")>
    <Description("Overrides for defining common header group appearance that other states can override.")>
    Public ReadOnly Property StateCommon() As PaletteGroupBoxRedirect
        Get
            Return _groupBox.StateCommon
        End Get
    End Property

    <Category("Visuals")>
    <Description("Overrides for defining disabled header group appearance.")>
    Public ReadOnly Property StateDisabled() As PaletteGroupBox
        Get
            Return _groupBox.StateDisabled
        End Get
    End Property

    <Category("Visuals")>
    <Description("Overrides for defining normal header group appearance.")>
    Public ReadOnly Property StateNormal() As PaletteGroupBox
        Get
            Return _groupBox.StateNormal
        End Get
    End Property

    <Category("Visuals")>
    <Description("Caption values")>
    Public ReadOnly Property Values() As CaptionValues
        Get
            Return _groupBox.Values
        End Get
    End Property

    <Category("Visuals")>
    <Description("Palette applied to drawing.")>
    <DefaultValue(PaletteMode.Global)>
    Public Property PaletteMode() As PaletteMode
        Get
            Return _groupBox.PaletteMode
        End Get
        Set(value As PaletteMode)
            _groupBox.PaletteMode = value
        End Set
    End Property

    <Category("Layout")>
    <Description("The size of the control is pixels.")>
    Public Property Size() As Size
        Get
            Return _groupBox.Size
        End Get
        Set(value As Size)
            _groupBox.Size = value
        End Set
    End Property

    <Category("Layout")>
    <Description("The location of the control in pixels.")>
    Public Property Location() As Point
        Get
            Return _groupBox.Location
        End Get
        Set(value As Point)
            _groupBox.Location = value
        End Set
    End Property

    <Category("Behavior")>
    <Description("Indicates whether the control is enabled.")>
    Public Property Enabled() As Boolean
        Get
            Return _groupBox.Enabled
        End Get
        Set(value As Boolean)
            _groupBox.Enabled = value
        End Set
    End Property

End Class
