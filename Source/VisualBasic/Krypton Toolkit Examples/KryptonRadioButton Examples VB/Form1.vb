#Region "BSD License"
'
' Original BSD 3-Clause License (https://github.com/ComponentFactory/Krypton/blob/master/LICENSE)
'  © Component Factory Pty Ltd, 2006 - 2016, (Version 4.5.0.0) All rights reserved.
'
'  New BSD 3-Clause License (https://github.com/Krypton-Suite/Standard-Toolkit/blob/master/LICENSE)
'  Modifications by Peter Wagner(aka Wagnerp) & Simon Coghlan(aka Smurf-IV), et al. 2017 - 2024. All rights reserved.
'
' VB.NET twin of Source\Krypton Toolkit Examples\KryptonRadioButton Examples\Form1.cs (Bastion Phase 4c).
#End Region

Imports System
Imports System.ComponentModel
Imports System.Drawing
Imports System.Windows.Forms

Imports Krypton.Toolkit

Public Class Form1

    Private Sub Form1_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        propertyGrid.SelectedObject = New KryptonRadioButtonProxy(kryptonRadioButton12)
    End Sub

    Private Sub RadioButtonEnter(sender As Object, e As EventArgs) Handles _
        kryptonRadioButton1.Enter, kryptonRadioButton2.Enter, kryptonRadioButton3.Enter, kryptonRadioButton4.Enter, kryptonRadioButton5.Enter,
        kryptonRadioButton6.Enter, kryptonRadioButton7.Enter, kryptonRadioButton8.Enter, kryptonRadioButton9.Enter, kryptonRadioButton10.Enter,
        kryptonRadioButton11.Enter, kryptonRadioButton12.Enter, kryptonRadioButton13.Enter, kryptonRadioButton14.Enter, kryptonRadioButton15.Enter

        propertyGrid.SelectedObject = New KryptonRadioButtonProxy(DirectCast(sender, KryptonRadioButton))
    End Sub

    Private Sub buttonClose_Click(sender As Object, e As EventArgs) Handles buttonClose.Click
        Close()
    End Sub

End Class

Public Class KryptonRadioButtonProxy

    Private _radioButton As KryptonRadioButton

    Public Sub New(checkBox As KryptonRadioButton)
        _radioButton = checkBox
    End Sub

    <Category("Appearance")>
    <Description("Indicates if the component is in the checked state.")>
    Public Property Checked As Boolean
        Get
            Return _radioButton.Checked
        End Get
        Set(value As Boolean)
            _radioButton.Checked = value
        End Set
    End Property

    <Category("Behavior")>
    <Description("Causes the check box to automatically change state when clicked.")>
    Public Property AutoCheck As Boolean
        Get
            Return _radioButton.AutoCheck
        End Get
        Set(value As Boolean)
            _radioButton.AutoCheck = value
        End Set
    End Property

    <Category("Visuals")>
    <Description("Visual position of the check box.")>
    Public Overridable Property CheckPosition As VisualOrientation
        Get
            Return _radioButton.CheckPosition
        End Get
        Set(value As VisualOrientation)
            _radioButton.CheckPosition = value
        End Set
    End Property

    <Category("Visuals")>
    <Description("Image value overrides.")>
    Public ReadOnly Property Images As RadioButtonImages
        Get
            Return _radioButton.Images
        End Get
    End Property

    <Category("Visuals")>
    <Description("Label style.")>
    Public Property LabelStyle As LabelStyle
        Get
            Return _radioButton.LabelStyle
        End Get
        Set(value As LabelStyle)
            _radioButton.LabelStyle = value
        End Set
    End Property

    <Category("Visuals")>
    <Description("Label values")>
    Public ReadOnly Property Values As LabelValues
        Get
            Return _radioButton.Values
        End Get
    End Property

    <Category("Visuals")>
    <Description("Overrides for defining common label appearance that other states can override.")>
    Public ReadOnly Property StateCommon As PaletteContent
        Get
            Return _radioButton.StateCommon
        End Get
    End Property

    <Category("Visuals")>
    <Description("Overrides for defining disabled label appearance.")>
    Public ReadOnly Property StateDisabled As PaletteContent
        Get
            Return _radioButton.StateDisabled
        End Get
    End Property

    <Category("Visuals")>
    <Description("Overrides for defining normal label appearance.")>
    Public ReadOnly Property StateNormal As PaletteContent
        Get
            Return _radioButton.StateNormal
        End Get
    End Property

    <Category("Visuals")>
    <Description("Overrides for defining label appearance when it has focus.")>
    Public ReadOnly Property OverrideFocus As PaletteContent
        Get
            Return _radioButton.OverrideFocus
        End Get
    End Property

    <Category("Visuals")>
    <Description("Visual orientation of the control.")>
    <DefaultValue(VisualOrientation.Top)>
    Public Property Orientation As VisualOrientation
        Get
            Return _radioButton.Orientation
        End Get
        Set(value As VisualOrientation)
            _radioButton.Orientation = value
        End Set
    End Property

    <Category("Visuals")>
    <Description("Palette applied to drawing.")>
    <DefaultValue(PaletteMode.Global)>
    Public Property PaletteMode As PaletteMode
        Get
            Return _radioButton.PaletteMode
        End Get
        Set(value As PaletteMode)
            _radioButton.PaletteMode = value
        End Set
    End Property

    <Category("Layout")>
    <Description("Specifies whether a control will automatically size itself to fit its contents.")>
    <DefaultValue(False)>
    Public Property AutoSize As Boolean
        Get
            Return _radioButton.AutoSize
        End Get
        Set(value As Boolean)
            _radioButton.AutoSize = value
        End Set
    End Property

    <Category("Layout")>
    <Description("Specifies if the control grows and shrinks to fit the contents exactly.")>
    <DefaultValue(AutoSizeMode.GrowOnly)>
    Public Property AutoSizeMode As AutoSizeMode
        Get
            Return _radioButton.AutoSizeMode
        End Get
        Set(value As AutoSizeMode)
            _radioButton.AutoSizeMode = value
        End Set
    End Property

    <Category("Layout")>
    <Description("The size of the control is pixels.")>
    Public Property Size As Size
        Get
            Return _radioButton.Size
        End Get
        Set(value As Size)
            _radioButton.Size = value
        End Set
    End Property

    <Category("Layout")>
    <Description("The location of the control in pixels.")>
    Public Property Location As Point
        Get
            Return _radioButton.Location
        End Get
        Set(value As Point)
            _radioButton.Location = value
        End Set
    End Property

    <Category("Behavior")>
    <Description("Indicates whether the control is enabled.")>
    Public Property Enabled As Boolean
        Get
            Return _radioButton.Enabled
        End Get
        Set(value As Boolean)
            _radioButton.Enabled = value
        End Set
    End Property

End Class
