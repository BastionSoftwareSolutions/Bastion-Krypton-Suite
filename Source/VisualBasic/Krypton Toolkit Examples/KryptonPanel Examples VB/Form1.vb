#Region "BSD License"
'
' Original BSD 3-Clause License (https://github.com/ComponentFactory/Krypton/blob/master/LICENSE)
'  © Component Factory Pty Ltd, 2006 - 2016, (Version 4.5.0.0) All rights reserved.
'
'  New BSD 3-Clause License (https://github.com/Krypton-Suite/Standard-Toolkit/blob/master/LICENSE)
'  Modifications by Peter Wagner(aka Wagnerp) & Simon Coghlan(aka Smurf-IV), et al. 2017 - 2024. All rights reserved.
'
' VB.NET twin of Source\Krypton Toolkit Examples\KryptonPanel Examples\Form1.cs (Bastion Phase 4c).
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
        ' Setup the property grid to edit this panel
        propertyGrid.SelectedObject = New KryptonPanelProxy(panel1Office)
    End Sub

    Private Sub kryptonPanel_MouseDown(sender As Object, e As MouseEventArgs) Handles panel4Office.MouseDown,
        panel3Office.MouseDown, panel2Office.MouseDown, panel1Office.MouseDown, panel4Blue.MouseDown,
        panel3Blue.MouseDown, panel2Blue.MouseDown, panel1Blue.MouseDown, panel4Custom.MouseDown,
        panel2Custom.MouseDown, panel3Custom.MouseDown, panel1Custom.MouseDown
        ' Setup the property grid to edit this panel
        propertyGrid.SelectedObject = New KryptonPanelProxy(CType(sender, KryptonPanel))
    End Sub

    Private Sub buttonClose_Click(sender As Object, e As EventArgs) Handles buttonClose.Click
        Close()
    End Sub

End Class

Public Class KryptonPanelProxy

    Private _panel As KryptonPanel

    Public Sub New(panel As KryptonPanel)
        _panel = panel
    End Sub

    <Category("Visuals")>
    <Description("Panel style.")>
    <DefaultValue(PaletteBackStyle.PanelClient)>
    Public Property PanelBackStyle As PaletteBackStyle
        Get
            Return _panel.PanelBackStyle
        End Get
        Set(value As PaletteBackStyle)
            _panel.PanelBackStyle = value
        End Set
    End Property

    <Category("Visuals")>
    <Description("Overrides for defining common panel appearance that other states can override.")>
    Public ReadOnly Property StateCommon As PaletteBack
        Get
            Return _panel.StateCommon
        End Get
    End Property

    <Category("Visuals")>
    <Description("Overrides for defining disabled panel appearance.")>
    Public ReadOnly Property StateDisabled As PaletteBack
        Get
            Return _panel.StateDisabled
        End Get
    End Property

    <Category("Visuals")>
    <Description("Overrides for defining normal panel appearance.")>
    Public ReadOnly Property StateNormal As PaletteBack
        Get
            Return _panel.StateNormal
        End Get
    End Property

    <Category("Visuals")>
    <Description("Palette applied to drawing.")>
    <DefaultValue(PaletteMode.Global)>
    Public Property PaletteMode As PaletteMode
        Get
            Return _panel.PaletteMode
        End Get
        Set(value As PaletteMode)
            _panel.PaletteMode = value
        End Set
    End Property

    <Category("Layout")>
    <Description("The size of the control is pixels.")>
    Public Property Size As Size
        Get
            Return _panel.Size
        End Get
        Set(value As Size)
            _panel.Size = value
        End Set
    End Property

    <Category("Layout")>
    <Description("The location of the control in pixels.")>
    Public Property Location As Point
        Get
            Return _panel.Location
        End Get
        Set(value As Point)
            _panel.Location = value
        End Set
    End Property

End Class
