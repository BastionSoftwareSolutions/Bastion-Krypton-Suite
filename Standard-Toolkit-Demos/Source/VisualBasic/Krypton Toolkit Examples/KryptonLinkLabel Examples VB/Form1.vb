#Region "BSD License"
'
' Original BSD 3-Clause License (https://github.com/ComponentFactory/Krypton/blob/master/LICENSE)
'  © Component Factory Pty Ltd, 2006 - 2016, (Version 4.5.0.0) All rights reserved.
'
'  New BSD 3-Clause License (https://github.com/Krypton-Suite/Standard-Toolkit/blob/master/LICENSE)
'  Modifications by Peter Wagner(aka Wagnerp) & Simon Coghlan(aka Smurf-IV), et al. 2017 - 2024. All rights reserved.
'
' VB.NET twin of Source\Krypton Toolkit Examples\KryptonLinkLabel Examples\Form1.cs (Bastion Phase 4c).
#End Region

Imports System
Imports System.ComponentModel
Imports System.Drawing
Imports System.Windows.Forms

Imports Krypton.Toolkit

Public Class Form1

    Public Sub New()
        InitializeComponent()
    End Sub

    Private Sub Form1_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        ' Setup the property grid to edit this label
        propertyGrid.SelectedObject = New KryptonLinkLabelProxy(label2Professional)
    End Sub

    Private Sub kryptonLabel_MouseDown(sender As Object, e As MouseEventArgs) Handles kryptonLabel1.MouseDown,
        label4Professional.MouseDown, label3Professional.MouseDown, label5Professional.MouseDown,
        label2Professional.MouseDown, label1Professional.MouseDown, label3Custom.MouseDown,
        label2Custom.MouseDown, label1Custom.MouseDown
        ' Setup the property grid to edit this label
        propertyGrid.SelectedObject = New KryptonLinkLabelProxy(CType(sender, KryptonLinkLabel))
    End Sub

    Private Sub buttonClose_Click(sender As Object, e As EventArgs) Handles buttonClose.Click
        Close()
    End Sub

End Class

Public Class KryptonLinkLabelProxy

    Private _label As KryptonLinkLabel

    Public Sub New(label As KryptonLinkLabel)
        _label = label
    End Sub

    <Category("Visuals")>
    <Description("Label style.")>
    Public Property LabelStyle As LabelStyle
        Get
            Return _label.LabelStyle
        End Get
        Set(value As LabelStyle)
            _label.LabelStyle = value
        End Set
    End Property

    <Category("Visuals")>
    <Description("Header values")>
    Public ReadOnly Property Values As LabelValues
        Get
            Return _label.Values
        End Get
    End Property

    <Category("Visuals")>
    <Description("Overrides for defining common label appearance that other states can override.")>
    Public ReadOnly Property StateCommon As PaletteContent
        Get
            Return _label.StateCommon
        End Get
    End Property

    <Category("Visuals")>
    <Description("Overrides for defining disabled label appearance.")>
    Public ReadOnly Property StateDisabled As PaletteContent
        Get
            Return _label.StateDisabled
        End Get
    End Property

    <Category("Visuals")>
    <Description("Overrides for defining normal label appearance.")>
    Public ReadOnly Property StateNormal As PaletteContent
        Get
            Return _label.StateNormal
        End Get
    End Property

    <Category("Visuals")>
    <Description("Visual orientation of the control.")>
    Public Property Orientation As VisualOrientation
        Get
            Return _label.Orientation
        End Get
        Set(value As VisualOrientation)
            _label.Orientation = value
        End Set
    End Property

    <Category("Visuals")>
    <Description("Palette applied to drawing.")>
    Public Property PaletteMode As PaletteMode
        Get
            Return _label.PaletteMode
        End Get
        Set(value As PaletteMode)
            _label.PaletteMode = value
        End Set
    End Property

    <Category("Layout")>
    <Description("Specifies whether a control will automatically size itself to fit its contents.")>
    Public Property AutoSize As Boolean
        Get
            Return _label.AutoSize
        End Get
        Set(value As Boolean)
            _label.AutoSize = value
        End Set
    End Property

    <Category("Layout")>
    <Description("Specifies if the control grows and shrinks to fit the contents exactly.")>
    Public Property AutoSizeMode As AutoSizeMode
        Get
            Return _label.AutoSizeMode
        End Get
        Set(value As AutoSizeMode)
            _label.AutoSizeMode = value
        End Set
    End Property

    <Category("Layout")>
    <Description("The size of the control is pixels.")>
    Public Property Size As Size
        Get
            Return _label.Size
        End Get
        Set(value As Size)
            _label.Size = value
        End Set
    End Property

    <Category("Layout")>
    <Description("The location of the control in pixels.")>
    Public Property Location As Point
        Get
            Return _label.Location
        End Get
        Set(value As Point)
            _label.Location = value
        End Set
    End Property

    <Category("Behavior")>
    <Description("Indicates whether the control is enabled.")>
    Public Property Enabled As Boolean
        Get
            Return _label.Enabled
        End Get
        Set(value As Boolean)
            _label.Enabled = value
        End Set
    End Property

End Class
