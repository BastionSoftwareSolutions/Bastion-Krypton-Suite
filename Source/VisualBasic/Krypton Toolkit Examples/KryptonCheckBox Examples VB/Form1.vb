#Region "BSD License"
'
' Original BSD 3-Clause License (https://github.com/ComponentFactory/Krypton/blob/master/LICENSE)
'  © Component Factory Pty Ltd, 2006 - 2016, (Version 4.5.0.0) All rights reserved.
'
'  New BSD 3-Clause License (https://github.com/Krypton-Suite/Standard-Toolkit/blob/master/LICENSE)
'  Modifications by Peter Wagner(aka Wagnerp) & Simon Coghlan(aka Smurf-IV), et al. 2017 - 2024. All rights reserved.
'
' VB.NET twin of Source\Krypton Toolkit Examples\KryptonCheckBox Examples\Form1.cs (Bastion Phase 4c).
#End Region

Imports System
Imports System.ComponentModel
Imports System.Drawing
Imports System.Windows.Forms

Imports Krypton.Toolkit

Public Class Form1

    Private Sub Form1_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        propertyGrid.SelectedObject = New KryptonCheckBoxProxy(kryptonCheckBox13)
    End Sub

    Private Sub CheckButtonEnter(sender As Object, e As EventArgs) Handles _
        kryptonCheckBox1.Enter, kryptonCheckBox2.Enter, kryptonCheckBox3.Enter, kryptonCheckBox4.Enter,
        kryptonCheckBox5.Enter, kryptonCheckBox6.Enter, kryptonCheckBox7.Enter, kryptonCheckBox8.Enter,
        kryptonCheckBox9.Enter, kryptonCheckBox10.Enter, kryptonCheckBox11.Enter, kryptonCheckBox12.Enter,
        kryptonCheckBox13.Enter, kryptonCheckBox14.Enter, kryptonCheckBox15.Enter, kryptonCheckBox16.Enter

        propertyGrid.SelectedObject = New KryptonCheckBoxProxy(DirectCast(sender, KryptonCheckBox))
    End Sub

    Private Sub buttonClose_Click(sender As Object, e As EventArgs) Handles buttonClose.Click
        Close()
    End Sub

End Class

Public Class KryptonCheckBoxProxy

    Private _checkBox As KryptonCheckBox

    Public Sub New(button As KryptonCheckBox)
        _checkBox = button
    End Sub

    <Category("Appearance")>
    <Description("Indicates if the component is in the checked state.")>
    Public Property Checked As Boolean
        Get
            Return _checkBox.Checked
        End Get
        Set(value As Boolean)
            _checkBox.Checked = value
        End Set
    End Property

    <Category("Appearance")>
    <Description("Indicates the checked state of the component.")>
    Public Property CheckState As System.Windows.Forms.CheckState
        Get
            Return _checkBox.CheckState
        End Get
        Set(value As System.Windows.Forms.CheckState)
            _checkBox.CheckState = value
        End Set
    End Property

    <Category("Behavior")>
    <Description("Causes the check box to automatically change state when clicked.")>
    Public Property AutoCheck As Boolean
        Get
            Return _checkBox.AutoCheck
        End Get
        Set(value As Boolean)
            _checkBox.AutoCheck = value
        End Set
    End Property

    <Category("Behavior")>
    <Description("Indicates if the component allows three states instead of two.")>
    Public Property ThreeState As Boolean
        Get
            Return _checkBox.ThreeState
        End Get
        Set(value As Boolean)
            _checkBox.ThreeState = value
        End Set
    End Property

    <Category("Visuals")>
    <Description("Visual position of the check box.")>
    Public Overridable Property CheckPosition As VisualOrientation
        Get
            Return _checkBox.CheckPosition
        End Get
        Set(value As VisualOrientation)
            _checkBox.CheckPosition = value
        End Set
    End Property

    <Category("Visuals")>
    <Description("Image value overrides.")>
    Public ReadOnly Property Images As CheckBoxImages
        Get
            Return _checkBox.Images
        End Get
    End Property

    <Category("Visuals")>
    <Description("Label style.")>
    Public Property LabelStyle As Krypton.Toolkit.LabelStyle
        Get
            Return _checkBox.LabelStyle
        End Get
        Set(value As Krypton.Toolkit.LabelStyle)
            _checkBox.LabelStyle = value
        End Set
    End Property

    <Category("Visuals")>
    <Description("Label values")>
    Public ReadOnly Property Values As LabelValues
        Get
            Return _checkBox.Values
        End Get
    End Property

    <Category("Visuals")>
    <Description("Overrides for defining common label appearance that other states can override.")>
    Public ReadOnly Property StateCommon As PaletteContent
        Get
            Return _checkBox.StateCommon
        End Get
    End Property

    <Category("Visuals")>
    <Description("Overrides for defining disabled label appearance.")>
    Public ReadOnly Property StateDisabled As PaletteContent
        Get
            Return _checkBox.StateDisabled
        End Get
    End Property

    <Category("Visuals")>
    <Description("Overrides for defining normal label appearance.")>
    Public ReadOnly Property StateNormal As PaletteContent
        Get
            Return _checkBox.StateNormal
        End Get
    End Property

    <Category("Visuals")>
    <Description("Overrides for defining label appearance when it has focus.")>
    Public ReadOnly Property OverrideFocus As PaletteContent
        Get
            Return _checkBox.OverrideFocus
        End Get
    End Property

    <Category("Visuals")>
    <Description("Visual orientation of the control.")>
    <DefaultValue(VisualOrientation.Top)>
    Public Property Orientation As VisualOrientation
        Get
            Return _checkBox.Orientation
        End Get
        Set(value As VisualOrientation)
            _checkBox.Orientation = value
        End Set
    End Property

    <Category("Visuals")>
    <Description("Palette applied to drawing.")>
    <DefaultValue(Krypton.Toolkit.PaletteMode.Global)>
    Public Property PaletteMode As Krypton.Toolkit.PaletteMode
        Get
            Return _checkBox.PaletteMode
        End Get
        Set(value As Krypton.Toolkit.PaletteMode)
            _checkBox.PaletteMode = value
        End Set
    End Property

    <Category("Layout")>
    <Description("Specifies whether a control will automatically size itself to fit its contents.")>
    <DefaultValue(False)>
    Public Property AutoSize As Boolean
        Get
            Return _checkBox.AutoSize
        End Get
        Set(value As Boolean)
            _checkBox.AutoSize = value
        End Set
    End Property

    <Category("Layout")>
    <Description("Specifies if the control grows and shrinks to fit the contents exactly.")>
    <DefaultValue(System.Windows.Forms.AutoSizeMode.GrowOnly)>
    Public Property AutoSizeMode As System.Windows.Forms.AutoSizeMode
        Get
            Return _checkBox.AutoSizeMode
        End Get
        Set(value As System.Windows.Forms.AutoSizeMode)
            _checkBox.AutoSizeMode = value
        End Set
    End Property

    <Category("Layout")>
    <Description("The size of the control is pixels.")>
    Public Property Size As System.Drawing.Size
        Get
            Return _checkBox.Size
        End Get
        Set(value As System.Drawing.Size)
            _checkBox.Size = value
        End Set
    End Property

    <Category("Layout")>
    <Description("The location of the control in pixels.")>
    Public Property Location As Point
        Get
            Return _checkBox.Location
        End Get
        Set(value As Point)
            _checkBox.Location = value
        End Set
    End Property

    <Category("Behavior")>
    <Description("Indicates whether the control is enabled.")>
    Public Property Enabled As Boolean
        Get
            Return _checkBox.Enabled
        End Get
        Set(value As Boolean)
            _checkBox.Enabled = value
        End Set
    End Property

End Class
