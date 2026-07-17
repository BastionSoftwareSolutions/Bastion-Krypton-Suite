#Region "BSD License"
'
' Original BSD 3-Clause License (https://github.com/ComponentFactory/Krypton/blob/master/LICENSE)
'  © Component Factory Pty Ltd, 2006 - 2016, (Version 4.5.0.0) All rights reserved.
'
'  New BSD 3-Clause License (https://github.com/Krypton-Suite/Standard-Toolkit/blob/master/LICENSE)
'  Modifications by Peter Wagner(aka Wagnerp) & Simon Coghlan(aka Smurf-IV), et al. 2017 - 2024. All rights reserved.
'
' VB.NET twin of Source\Krypton Toolkit Examples\KryptonBorderEdge Examples\Form1.cs (Bastion Phase 4c).
#End Region

Imports System
Imports System.Drawing
Imports System.Windows.Forms
Imports System.ComponentModel
Imports Krypton.Toolkit

Public Class Form1

    Private Sub Form1_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        ' Setup the property grid to edit this border edge
        propertyGrid.SelectedObject = New KryptonBorderEdgeProxy(borderEdgeH1)
    End Sub

    Private Sub buttonOffice2010Blue_Click(sender As Object, e As EventArgs) Handles buttonOffice2010Blue.Click
        kryptonManager.GlobalCustomPalette = kryptonPaletteOffice2010Blue
        propertyGrid.SelectedObject = kryptonPaletteOffice2010Blue
    End Sub

    Private Sub buttonOffice2007Blue_Click(sender As Object, e As EventArgs) Handles buttonOffice2007Blue.Click
        kryptonManager.GlobalCustomPalette = kryptonPaletteOffice2007Blue
        propertyGrid.SelectedObject = kryptonPaletteOffice2007Blue
    End Sub

    Private Sub buttonSparkle_Click(sender As Object, e As EventArgs) Handles buttonSparkle.Click
        kryptonManager.GlobalCustomPalette = kryptonPaletteSparkle
        propertyGrid.SelectedObject = kryptonPaletteSparkle
    End Sub

    Private Sub buttonSystem_Click(sender As Object, e As EventArgs) Handles buttonSystem.Click
        kryptonManager.GlobalCustomPalette = kryptonPaletteSystem
        propertyGrid.SelectedObject = kryptonPaletteSystem
    End Sub

    Private Sub buttonCustom_Click(sender As Object, e As EventArgs) Handles buttonCustom.Click
        kryptonManager.GlobalCustomPalette = kryptonPaletteCustom
        propertyGrid.SelectedObject = kryptonPaletteCustom
    End Sub

    Private Sub button_Enter(sender As Object, e As EventArgs) Handles _
        borderAll.Enter, borderL.Enter, borderT.Enter, borderR.Enter, borderB.Enter,
        borderLT.Enter, borderTR.Enter, borderBR.Enter, borderBL.Enter, borderTB.Enter,
        borderLR.Enter, borderNone.Enter, borderTBR.Enter, borderLRB.Enter, borderTBL.Enter, borderLRT.Enter

        ' Setup the property grid to edit this button
        propertyGrid.SelectedObject = New KryptonButtonProxy(DirectCast(sender, KryptonButton))
    End Sub

    Private Sub checkButton_Enter(sender As Object, e As EventArgs) Handles buttonEnd.Enter, buttonNext.Enter, buttonPrevious.Enter, buttonBegin.Enter
        ' Setup the property grid to edit this check button
        propertyGrid.SelectedObject = New KryptonCheckButtonProxy(DirectCast(sender, KryptonCheckButton))
    End Sub

    Private Sub borderEdge_MouseDown(sender As Object, e As MouseEventArgs) Handles _
        borderEdgeH1.MouseDown, borderEdgeV.MouseDown, borderEdgeSep3.MouseDown, borderEdgeSep2.MouseDown, borderEdgeSep1.MouseDown

        ' Setup the property grid to edit this border edge
        propertyGrid.SelectedObject = New KryptonBorderEdgeProxy(DirectCast(sender, KryptonBorderEdge))
    End Sub

    Private Sub buttonClose_Click(sender As Object, e As EventArgs) Handles buttonClose.Click
        Close()
    End Sub

End Class

Public Class KryptonButtonProxy

    Private _button As KryptonButton

    Public Sub New(button As KryptonButton)
        _button = button
    End Sub

    <Category("Visuals")>
    <Description("Button style.")>
    <DefaultValue(Krypton.Toolkit.ButtonStyle.Standalone)>
    Public Property ButtonStyle As Krypton.Toolkit.ButtonStyle
        Get
            Return _button.ButtonStyle
        End Get
        Set(value As Krypton.Toolkit.ButtonStyle)
            _button.ButtonStyle = value
        End Set
    End Property

    <Category("Visuals")>
    <Description("Button values")>
    Public ReadOnly Property Values As ButtonValues
        Get
            Return _button.Values
        End Get
    End Property

    <Category("Visuals")>
    <Description("Overrides for defining common button appearance that other states can override.")>
    Public ReadOnly Property StateCommon As PaletteTripleRedirect
        Get
            Return _button.StateCommon
        End Get
    End Property

    <Category("Visuals")>
    <Description("Overrides for defining disabled button appearance.")>
    Public ReadOnly Property StateDisabled As PaletteTriple
        Get
            Return _button.StateDisabled
        End Get
    End Property

    <Category("Visuals")>
    <Description("Overrides for defining normal button appearance.")>
    Public ReadOnly Property StateNormal As PaletteTriple
        Get
            Return _button.StateNormal
        End Get
    End Property

    <Category("Visuals")>
    <Description("Overrides for defining hot tracking button appearance.")>
    Public ReadOnly Property StateTracking As PaletteTriple
        Get
            Return _button.StateTracking
        End Get
    End Property

    <Category("Visuals")>
    <Description("Overrides for defining pressed button appearance.")>
    Public ReadOnly Property StatePressed As PaletteTriple
        Get
            Return _button.StatePressed
        End Get
    End Property

    <Category("Visuals")>
    <Description("Overrides for defining normal button appearance when default.")>
    Public ReadOnly Property OverrideDefault As PaletteTripleRedirect
        Get
            Return _button.OverrideDefault
        End Get
    End Property

    <Category("Visuals")>
    <Description("Overrides for defining button appearance when it has focus.")>
    Public ReadOnly Property OverrideFocus As PaletteTripleRedirect
        Get
            Return _button.OverrideFocus
        End Get
    End Property

    <Category("Visuals")>
    <Description("Visual orientation of the control.")>
    <DefaultValue(VisualOrientation.Top)>
    Public Property Orientation As VisualOrientation
        Get
            Return _button.Orientation
        End Get
        Set(value As VisualOrientation)
            _button.Orientation = value
        End Set
    End Property

    <Category("Visuals")>
    <Description("Palette applied to drawing.")>
    <DefaultValue(Krypton.Toolkit.PaletteMode.Global)>
    Public Property PaletteMode As Krypton.Toolkit.PaletteMode
        Get
            Return _button.PaletteMode
        End Get
        Set(value As Krypton.Toolkit.PaletteMode)
            _button.PaletteMode = value
        End Set
    End Property

    <Category("Layout")>
    <Description("Specifies whether a control will automatically size itself to fit its contents.")>
    <DefaultValue(False)>
    Public Property AutoSize As Boolean
        Get
            Return _button.AutoSize
        End Get
        Set(value As Boolean)
            _button.AutoSize = value
        End Set
    End Property

    <Category("Layout")>
    <Description("Specifies if the control grows and shrinks to fit the contents exactly.")>
    <DefaultValue(System.Windows.Forms.AutoSizeMode.GrowOnly)>
    Public Property AutoSizeMode As System.Windows.Forms.AutoSizeMode
        Get
            Return _button.AutoSizeMode
        End Get
        Set(value As System.Windows.Forms.AutoSizeMode)
            _button.AutoSizeMode = value
        End Set
    End Property

    <Category("Layout")>
    <Description("The size of the control is pixels.")>
    Public Property Size As System.Drawing.Size
        Get
            Return _button.Size
        End Get
        Set(value As System.Drawing.Size)
            _button.Size = value
        End Set
    End Property

    <Category("Layout")>
    <Description("The location of the control in pixels.")>
    Public Property Location As Point
        Get
            Return _button.Location
        End Get
        Set(value As Point)
            _button.Location = value
        End Set
    End Property

    <Category("Behavior")>
    <Description("Indicates whether the control is enabled.")>
    Public Property Enabled As Boolean
        Get
            Return _button.Enabled
        End Get
        Set(value As Boolean)
            _button.Enabled = value
        End Set
    End Property

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

Public Class KryptonBorderEdgeProxy

    Private _borderEdge As KryptonBorderEdge

    Public Sub New(borderEdge As KryptonBorderEdge)
        _borderEdge = borderEdge
    End Sub

    <Category("Visuals")>
    <Description("Border style.")>
    <DefaultValue(PaletteBorderStyle.ControlClient)>
    Public Property BorderStyle As PaletteBorderStyle
        Get
            Return _borderEdge.BorderStyle
        End Get
        Set(value As PaletteBorderStyle)
            _borderEdge.BorderStyle = value
        End Set
    End Property

    <Category("Visuals")>
    <Description("Overrides for defining common border edge appearance that other states can override.")>
    Public ReadOnly Property StateCommon As PaletteBorderEdgeRedirect
        Get
            Return _borderEdge.StateCommon
        End Get
    End Property

    <Category("Visuals")>
    <Description("Overrides for defining disabled border edge appearance.")>
    Public ReadOnly Property StateDisabled As PaletteBorderEdge
        Get
            Return _borderEdge.StateDisabled
        End Get
    End Property

    <Category("Visuals")>
    <Description("Overrides for defining normal border edge appearance.")>
    Public ReadOnly Property StateNormal As PaletteBorderEdge
        Get
            Return _borderEdge.StateNormal
        End Get
    End Property

    <Category("Visuals")>
    <Description("Visual orientation of the control.")>
    <DefaultValue(System.Windows.Forms.Orientation.Horizontal)>
    Public Property Orientation As System.Windows.Forms.Orientation
        Get
            Return _borderEdge.Orientation
        End Get
        Set(value As System.Windows.Forms.Orientation)
            _borderEdge.Orientation = value
        End Set
    End Property

    <Category("Visuals")>
    <Description("Palette applied to drawing.")>
    <DefaultValue(Krypton.Toolkit.PaletteMode.Global)>
    Public Property PaletteMode As Krypton.Toolkit.PaletteMode
        Get
            Return _borderEdge.PaletteMode
        End Get
        Set(value As Krypton.Toolkit.PaletteMode)
            _borderEdge.PaletteMode = value
        End Set
    End Property

    <Category("Layout")>
    <Description("Specifies whether a control will automatically size itself to fit its contents.")>
    <DefaultValue(False)>
    Public Property AutoSize As Boolean
        Get
            Return _borderEdge.AutoSize
        End Get
        Set(value As Boolean)
            _borderEdge.AutoSize = value
        End Set
    End Property

    <Category("Layout")>
    <Description("Specifies if the control grows and shrinks to fit the contents exactly.")>
    <DefaultValue(System.Windows.Forms.AutoSizeMode.GrowOnly)>
    Public Property AutoSizeMode As System.Windows.Forms.AutoSizeMode
        Get
            Return _borderEdge.AutoSizeMode
        End Get
        Set(value As System.Windows.Forms.AutoSizeMode)
            _borderEdge.AutoSizeMode = value
        End Set
    End Property

    <Category("Layout")>
    <Description("The size of the control is pixels.")>
    Public Property Size As System.Drawing.Size
        Get
            Return _borderEdge.Size
        End Get
        Set(value As System.Drawing.Size)
            _borderEdge.Size = value
        End Set
    End Property

    <Category("Layout")>
    <Description("The location of the control in pixels.")>
    Public Property Location As Point
        Get
            Return _borderEdge.Location
        End Get
        Set(value As Point)
            _borderEdge.Location = value
        End Set
    End Property

    <Category("Behavior")>
    <Description("Indicates whether the control is enabled.")>
    Public Property Enabled As Boolean
        Get
            Return _borderEdge.Enabled
        End Get
        Set(value As Boolean)
            _borderEdge.Enabled = value
        End Set
    End Property

End Class
