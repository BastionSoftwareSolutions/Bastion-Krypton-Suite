#Region "BSD License"
'
' Original BSD 3-Clause License (https://github.com/ComponentFactory/Krypton/blob/master/LICENSE)
'  © Component Factory Pty Ltd, 2006 - 2016, (Version 4.5.0.0) All rights reserved.
'
'  New BSD 3-Clause License (https://github.com/Krypton-Suite/Standard-Toolkit/blob/master/LICENSE)
'  Modifications by Peter Wagner(aka Wagnerp) & Simon Coghlan(aka Smurf-IV), et al. 2017 - 2024. All rights reserved.
'
' VB.NET twin of Source\Krypton Toolkit Examples\KryptonCheckButton Examples\Form1.cs (Bastion Phase 4c).
#End Region

Imports System
Imports System.ComponentModel
Imports System.Drawing
Imports System.Windows.Forms

Imports Krypton.Toolkit

Public Class Form1

    Private Sub Form1_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        ' Setup the property grid to edit this button
        propertyGrid.SelectedObject = New KryptonCheckButtonProxy(button1Sparkle)
    End Sub

    Private Sub checkButton_Enter(sender As Object, e As EventArgs) Handles _
        button1Sparkle.Enter, button2Sparkle.Enter, button3Sparkle.Enter, button5Sparkle.Enter, button6Sparkle.Enter,
        button1Custom.Enter, button2Custom.Enter, button3Custom.Enter, button4Custom.Enter, button5Custom.Enter,
        button1System.Enter, button2System.Enter, button3System.Enter, button4System.Enter, button5System.Enter, button6System.Enter

        ' Setup the property grid to edit this button
        propertyGrid.SelectedObject = New KryptonCheckButtonProxy(DirectCast(sender, KryptonCheckButton))
    End Sub

    Private Sub buttonClose_Click(sender As Object, e As EventArgs) Handles buttonClose.Click
        Close()
    End Sub

End Class

Public Class KryptonCheckButtonProxy

    Private _checkButton As KryptonCheckButton

    Public Sub New(checkButton As KryptonCheckButton)
        _checkButton = checkButton
    End Sub

    <Category("Visuals")>
    <Description("Button style.")>
    <DefaultValue(Krypton.Toolkit.ButtonStyle.Standalone)>
    Public Property ButtonStyle As Krypton.Toolkit.ButtonStyle
        Get
            Return _checkButton.ButtonStyle
        End Get
        Set(value As Krypton.Toolkit.ButtonStyle)
            _checkButton.ButtonStyle = value
        End Set
    End Property

    <Category("Visuals")>
    <Description("Button values")>
    Public ReadOnly Property Values As ButtonValues
        Get
            Return _checkButton.Values
        End Get
    End Property

    <Category("Visuals")>
    <Description("Overrides for defining common button appearance that other states can override.")>
    Public ReadOnly Property StateCommon As PaletteTripleRedirect
        Get
            Return _checkButton.StateCommon
        End Get
    End Property

    <Category("Visuals")>
    <Description("Overrides for defining disabled button appearance.")>
    Public ReadOnly Property StateDisabled As PaletteTriple
        Get
            Return _checkButton.StateDisabled
        End Get
    End Property

    <Category("Visuals")>
    <Description("Overrides for defining normal button appearance.")>
    Public ReadOnly Property StateNormal As PaletteTriple
        Get
            Return _checkButton.StateNormal
        End Get
    End Property

    <Category("Visuals")>
    <Description("Overrides for defining hot tracking button appearance.")>
    Public ReadOnly Property StateTracking As PaletteTriple
        Get
            Return _checkButton.StateTracking
        End Get
    End Property

    <Category("Visuals")>
    <Description("Overrides for defining pressed button appearance.")>
    Public ReadOnly Property StatePressed As PaletteTriple
        Get
            Return _checkButton.StatePressed
        End Get
    End Property

    <Category("Visuals")>
    <Description("Overrides for defining normal checked button appearance.")>
    Public ReadOnly Property StateCheckedNormal As PaletteTriple
        Get
            Return _checkButton.StateCheckedNormal
        End Get
    End Property

    <Category("Visuals")>
    <Description("Overrides for defining hot tracking checked button appearance.")>
    Public ReadOnly Property StateCheckedTracking As PaletteTriple
        Get
            Return _checkButton.StateCheckedTracking
        End Get
    End Property

    <Category("Visuals")>
    <Description("Overrides for defining pressed checked button appearance.")>
    Public ReadOnly Property StateCheckedPressed As PaletteTriple
        Get
            Return _checkButton.StateCheckedPressed
        End Get
    End Property

    <Category("Visuals")>
    <Description("Overrides for defining normal button appearance when default.")>
    Public ReadOnly Property OverrideDefault As PaletteTripleRedirect
        Get
            Return _checkButton.OverrideDefault
        End Get
    End Property

    <Category("Visuals")>
    <Description("Overrides for defining button appearance when it has focus.")>
    Public ReadOnly Property OverrideFocus As PaletteTripleRedirect
        Get
            Return _checkButton.OverrideFocus
        End Get
    End Property

    <Category("Visuals")>
    <Description("Visual orientation of the control.")>
    <DefaultValue(VisualOrientation.Top)>
    Public Property Orientation As VisualOrientation
        Get
            Return _checkButton.Orientation
        End Get
        Set(value As VisualOrientation)
            _checkButton.Orientation = value
        End Set
    End Property

    <Category("Visuals")>
    <Description("Palette applied to drawing.")>
    <DefaultValue(Krypton.Toolkit.PaletteMode.Global)>
    Public Property PaletteMode As Krypton.Toolkit.PaletteMode
        Get
            Return _checkButton.PaletteMode
        End Get
        Set(value As Krypton.Toolkit.PaletteMode)
            _checkButton.PaletteMode = value
        End Set
    End Property

    <Category("Layout")>
    <Description("Specifies whether a control will automatically size itself to fit its contents.")>
    <DefaultValue(False)>
    Public Property AutoSize As Boolean
        Get
            Return _checkButton.AutoSize
        End Get
        Set(value As Boolean)
            _checkButton.AutoSize = value
        End Set
    End Property

    <Category("Layout")>
    <Description("Specifies if the control grows and shrinks to fit the contents exactly.")>
    <DefaultValue(System.Windows.Forms.AutoSizeMode.GrowOnly)>
    Public Property AutoSizeMode As System.Windows.Forms.AutoSizeMode
        Get
            Return _checkButton.AutoSizeMode
        End Get
        Set(value As System.Windows.Forms.AutoSizeMode)
            _checkButton.AutoSizeMode = value
        End Set
    End Property

    <Category("Layout")>
    <Description("The size of the control is pixels.")>
    Public Property Size As System.Drawing.Size
        Get
            Return _checkButton.Size
        End Get
        Set(value As System.Drawing.Size)
            _checkButton.Size = value
        End Set
    End Property

    <Category("Layout")>
    <Description("The location of the control in pixels.")>
    Public Property Location As Point
        Get
            Return _checkButton.Location
        End Get
        Set(value As Point)
            _checkButton.Location = value
        End Set
    End Property

    <Category("Appearance")>
    <Description("Indicates whether the control is in the checked state.")>
    Public Property Checked As Boolean
        Get
            Return _checkButton.Checked
        End Get
        Set(value As Boolean)
            _checkButton.Checked = value
        End Set
    End Property

    <Category("Behavior")>
    <Description("Indicates whether the control is enabled.")>
    Public Property Enabled As Boolean
        Get
            Return _checkButton.Enabled
        End Get
        Set(value As Boolean)
            _checkButton.Enabled = value
        End Set
    End Property

End Class
