' Original BSD 3-Clause License (https://github.com/ComponentFactory/Krypton/blob/master/LICENSE)
'  © Component Factory Pty Ltd, 2006 - 2016, (Version 4.5.0.0) All rights reserved.
'
'  New BSD 3-Clause License (https://github.com/Krypton-Suite/Standard-Toolkit/blob/master/LICENSE)
'  Modifications by Peter Wagner(aka Wagnerp) & Simon Coghlan(aka Smurf-IV), et al. 2017 - 2024. All rights reserved.
'
' VB.NET twin of Source\Krypton Toolkit Examples\KryptonHeader Examples\Form1.cs (Bastion Phase 4c).

Imports System.ComponentModel
Imports System.Drawing
Imports System.Windows.Forms

Imports Krypton.Toolkit

Public Class Form1

    Public Sub New()
        InitializeComponent()
    End Sub

    Private Sub Form1_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        ' Setup the property grid to edit this header
        propertyGrid.SelectedObject = New KryptonHeaderProxy(office1)
    End Sub

    Private Sub header_MouseDown(sender As Object, e As MouseEventArgs) Handles _
        office1.MouseDown, office2.MouseDown, office3.MouseDown, office4.MouseDown, office5.MouseDown, office6.MouseDown,
        blue1.MouseDown, blue2.MouseDown, blue3.MouseDown, blue4.MouseDown, blue5.MouseDown, blue6.MouseDown,
        custom1.MouseDown, custom2.MouseDown, custom3.MouseDown
        ' Setup the property grid to edit this header
        propertyGrid.SelectedObject = New KryptonHeaderProxy(CType(sender, KryptonHeader))
    End Sub

    Private Sub buttonClose_Click(sender As Object, e As EventArgs) Handles buttonClose.Click
        Close()
    End Sub

End Class

Public Class KryptonHeaderProxy

    Private _header As KryptonHeader

    Public Sub New(header As KryptonHeader)
        _header = header
    End Sub

    <Category("Visuals")>
    <Description("Should tooltips be displayed for button specs.")>
    <DefaultValue(False)>
    Public Property AllowButtonSpecToolTips() As Boolean
        Get
            Return _header.AllowButtonSpecToolTips
        End Get
        Set(value As Boolean)
            _header.AllowButtonSpecToolTips = value
        End Set
    End Property

    <Category("Visuals")>
    <Description("Header style.")>
    <DefaultValue(HeaderStyle.Primary)>
    Public Property HeaderStyle() As HeaderStyle
        Get
            Return _header.HeaderStyle
        End Get
        Set(value As HeaderStyle)
            _header.HeaderStyle = value
        End Set
    End Property

    <Category("Visuals")>
    <Description("Header values")>
    Public ReadOnly Property Values() As HeaderValues
        Get
            Return _header.Values
        End Get
    End Property

    <Category("Visuals")>
    <Description("Overrides for defining common header appearance that other states can override.")>
    Public ReadOnly Property StateCommon() As PaletteTripleRedirect
        Get
            Return _header.StateCommon
        End Get
    End Property

    <Category("Visuals")>
    <Description("Overrides for defining disabled header appearance.")>
    Public ReadOnly Property StateDisabled() As PaletteTriple
        Get
            Return _header.StateDisabled
        End Get
    End Property

    <Category("Visuals")>
    <Description("Overrides for defining normal header appearance.")>
    Public ReadOnly Property StateNormal() As PaletteTriple
        Get
            Return _header.StateNormal
        End Get
    End Property

    <Category("Visuals")>
    <Description("Collection of button specifications.")>
    Public ReadOnly Property ButtonSpecs() As KryptonHeader.HeaderButtonSpecCollection
        Get
            Return _header.ButtonSpecs
        End Get
    End Property

    <Category("Visuals")>
    <Description("Visual orientation of the control.")>
    <DefaultValue(VisualOrientation.Top)>
    Public Property Orientation() As VisualOrientation
        Get
            Return _header.Orientation
        End Get
        Set(value As VisualOrientation)
            _header.Orientation = value
        End Set
    End Property

    <Category("Visuals")>
    <Description("Palette applied to drawing.")>
    <DefaultValue(PaletteMode.Global)>
    Public Property PaletteMode() As PaletteMode
        Get
            Return _header.PaletteMode
        End Get
        Set(value As PaletteMode)
            _header.PaletteMode = value
        End Set
    End Property

    <Category("Layout")>
    <Description("Specifies whether a control will automatically size itself to fit its contents.")>
    <DefaultValue(False)>
    Public Property AutoSize() As Boolean
        Get
            Return _header.AutoSize
        End Get
        Set(value As Boolean)
            _header.AutoSize = value
        End Set
    End Property

    <Category("Layout")>
    <Description("Specifies if the control grows and shrinks to fit the contents exactly.")>
    <DefaultValue(AutoSizeMode.GrowOnly)>
    Public Property AutoSizeMode() As AutoSizeMode
        Get
            Return _header.AutoSizeMode
        End Get
        Set(value As AutoSizeMode)
            _header.AutoSizeMode = value
        End Set
    End Property

    <Category("Layout")>
    <Description("The size of the control is pixels.")>
    Public Property Size() As Size
        Get
            Return _header.Size
        End Get
        Set(value As Size)
            _header.Size = value
        End Set
    End Property

    <Category("Layout")>
    <Description("The location of the control in pixels.")>
    Public Property Location() As Point
        Get
            Return _header.Location
        End Get
        Set(value As Point)
            _header.Location = value
        End Set
    End Property

    <Category("Behavior")>
    <Description("Indicates whether the control is enabled.")>
    Public Property Enabled() As Boolean
        Get
            Return _header.Enabled
        End Get
        Set(value As Boolean)
            _header.Enabled = value
        End Set
    End Property

End Class
