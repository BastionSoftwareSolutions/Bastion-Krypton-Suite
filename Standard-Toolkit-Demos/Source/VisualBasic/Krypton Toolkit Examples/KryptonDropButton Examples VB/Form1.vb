' *****************************************************************************
' BSD 3-Clause License (https://github.com/Krypton-Suite/Standard-Toolkit)
'  By Peter Wagner(aka Wagnerp) & Simon Coghlan(aka Smurf-IV) 2021 - 2024. All rights reserved.
' *****************************************************************************

' Original BSD 3-Clause License (https://github.com/ComponentFactory/Krypton/blob/master/LICENSE)
'  © Component Factory Pty Ltd, 2006 - 2016, (Version 4.5.0.0) All rights reserved.
'
'  New BSD 3-Clause License (https://github.com/Krypton-Suite/Standard-Toolkit/blob/master/LICENSE)
'  Modifications by Peter Wagner(aka Wagnerp) & Simon Coghlan(aka Smurf-IV), et al. 2017 - 2024. All rights reserved.
'
' VB.NET twin of Source\Krypton Toolkit Examples\KryptonDropButton Examples\Form1.cs (Bastion Phase 4c).

Imports System.ComponentModel
Imports System.Drawing
Imports System.Windows.Forms

Imports Krypton.Toolkit

Public Class Form1

    Public Sub New()
        InitializeComponent()
    End Sub

    Private Sub Form1_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        ' Setup the property grid to edit this drop down
        propertyGrid.SelectedObject = New KryptonDropButtonProxy(splitterPosRight)
    End Sub

    Private Sub dropButtonEnter(sender As Object, e As EventArgs) Handles _
        splitterArrowLeft.Enter, splitterArrowRight.Enter, splitterArrowUp.Enter, splitterArrowDown.Enter,
        splitterPosBottom.Enter, splitterPosTop.Enter, splitterPosLeft.Enter, splitterPosRight.Enter,
        dropArrowLeft.Enter, dropArrowRight.Enter, dropArrowUp.Enter, dropArrowDown.Enter,
        dropPosBottom.Enter, dropPosTop.Enter, dropPosLeft.Enter, dropPosRight.Enter,
        dropCustom.Enter, splitterCustom.Enter
        ' Setup the property grid to edit this drop down
        propertyGrid.SelectedObject = New KryptonDropButtonProxy(CType(sender, KryptonDropButton))
    End Sub

    Private Sub buttonClose_Click(sender As Object, e As EventArgs) Handles buttonClose.Click
        Close()
    End Sub

End Class

Public Class KryptonDropButtonProxy

    Private _dropDown As KryptonDropButton

    Public Sub New(comboBox As KryptonDropButton)
        _dropDown = comboBox
    End Sub

    <Category("Appearance")>
    <Description("Text for display inside the control.")>
    Public Property Text() As String
        Get
            Return _dropDown.Text
        End Get
        Set(value As String)
            _dropDown.Text = value
        End Set
    End Property

    <Category("Layout")>
    <Description("The size of the control is pixels.")>
    Public Property Size() As Size
        Get
            Return _dropDown.Size
        End Get
        Set(value As Size)
            _dropDown.Size = value
        End Set
    End Property

    <Category("Layout")>
    <Description("The location of the control in pixels.")>
    Public Property Location() As Point
        Get
            Return _dropDown.Location
        End Get
        Set(value As Point)
            _dropDown.Location = value
        End Set
    End Property

    <Category("Behavior")>
    <Description("The shortcut menu to show when the user right-clicks the page.")>
    Public ReadOnly Property KryptonContextMenu() As KryptonContextMenu
        Get
            Return _dropDown.KryptonContextMenu
        End Get
    End Property

    <Category("Visuals")>
    <Description("Visual orientation of the control.")>
    Public Property ButtonOrientation() As VisualOrientation
        Get
            Return _dropDown.ButtonOrientation
        End Get
        Set(value As VisualOrientation)
            _dropDown.ButtonOrientation = value
        End Set
    End Property

    <Category("Visuals")>
    <Description("Position of the drop arrow within the button.")>
    Public Property DropDownPosition() As VisualOrientation
        Get
            Return _dropDown.DropDownPosition
        End Get
        Set(value As VisualOrientation)
            _dropDown.DropDownPosition = value
        End Set
    End Property

    <Category("Visuals")>
    <Description("Orientation of the drop arrow within the button.")>
    Public Property DropDownOrientation() As VisualOrientation
        Get
            Return _dropDown.DropDownOrientation
        End Get
        Set(value As VisualOrientation)
            _dropDown.DropDownOrientation = value
        End Set
    End Property

    <Category("Visuals")>
    <Description("Determine if button acts as a splitter or just a drop down.")>
    Public Property Splitter() As Boolean
        Get
            Return _dropDown.Splitter
        End Get
        Set(value As Boolean)
            _dropDown.Splitter = value
        End Set
    End Property

    <Category("Visuals")>
    <Description("Button style.")>
    Public Property ButtonStyle() As ButtonStyle
        Get
            Return _dropDown.ButtonStyle
        End Get
        Set(value As ButtonStyle)
            _dropDown.ButtonStyle = value
        End Set
    End Property

    <Category("Visuals")>
    <Description("Button values")>
    Public ReadOnly Property Values() As ButtonValues
        Get
            Return _dropDown.Values
        End Get
    End Property

    <Category("Visuals")>
    <Description("Overrides for defining common button appearance that other states can override.")>
    Public ReadOnly Property StateCommon() As PaletteTripleRedirect
        Get
            Return _dropDown.StateCommon
        End Get
    End Property

    <Category("Visuals")>
    <Description("Overrides for defining disabled button appearance.")>
    Public ReadOnly Property StateDisabled() As PaletteTriple
        Get
            Return _dropDown.StateDisabled
        End Get
    End Property

    <Category("Visuals")>
    <Description("Overrides for defining normal button appearance.")>
    Public ReadOnly Property StateNormal() As PaletteTriple
        Get
            Return _dropDown.StateNormal
        End Get
    End Property

    <Category("Visuals")>
    <Description("Overrides for defining hot tracking button appearance.")>
    Public ReadOnly Property StateTracking() As PaletteTriple
        Get
            Return _dropDown.StateTracking
        End Get
    End Property

    <Category("Visuals")>
    <Description("Overrides for defining pressed button appearance.")>
    Public ReadOnly Property StatePressed() As PaletteTriple
        Get
            Return _dropDown.StatePressed
        End Get
    End Property

    <Category("Visuals")>
    <Description("Overrides for defining normal button appearance when default.")>
    Public ReadOnly Property OverrideDefault() As PaletteTripleRedirect
        Get
            Return _dropDown.OverrideDefault
        End Get
    End Property

    <Category("Visuals")>
    <Description("Overrides for defining button appearance when it has focus.")>
    Public ReadOnly Property OverrideFocus() As PaletteTripleRedirect
        Get
            Return _dropDown.OverrideFocus
        End Get
    End Property

End Class
