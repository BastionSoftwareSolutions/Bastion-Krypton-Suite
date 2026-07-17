' Original BSD 3-Clause License (https://github.com/ComponentFactory/Krypton/blob/master/LICENSE)
'  © Component Factory Pty Ltd, 2006 - 2016, (Version 4.5.0.0) All rights reserved.
'
'  New BSD 3-Clause License (https://github.com/Krypton-Suite/Standard-Toolkit/blob/master/LICENSE)
'  Modifications by Peter Wagner(aka Wagnerp) & Simon Coghlan(aka Smurf-IV), et al. 2017 - 2024. All rights reserved.
'
' VB.NET twin of Source\Krypton Toolkit Examples\KryptonHeaderGroup Examples\Form1.cs (Bastion Phase 4c).

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
        propertyGrid.SelectedObject = New KryptonHeaderGroupProxy(headerGroup1Office)
    End Sub

    Private Sub headerGroup_MouseDown(sender As Object, e As MouseEventArgs) Handles _
        headerGroup1Office.MouseDown, headerGroup2Office.MouseDown,
        headerGroup1Blue.MouseDown, headerGroup2Blue.MouseDown,
        headerGroup1Custom.MouseDown, headerGroup2Custom.MouseDown, headerGroup3Custom.MouseDown, headerGroup4Custom.MouseDown
        ' Setup the property grid to edit this header group
        propertyGrid.SelectedObject = New KryptonHeaderGroupProxy(CType(sender, KryptonHeaderGroup))
    End Sub

    Private Sub panel_MouseDown(sender As Object, e As MouseEventArgs) Handles _
        headerGroup1Office.Panel.MouseDown, headerGroup2Office.Panel.MouseDown,
        headerGroup1Blue.Panel.MouseDown, headerGroup2Blue.Panel.MouseDown,
        headerGroup1Custom.Panel.MouseDown, headerGroup2Custom.Panel.MouseDown, headerGroup3Custom.Panel.MouseDown, headerGroup4Custom.Panel.MouseDown
        Dim c As Control = CType(sender, Control)

        ' Setup the property grid to edit this panel parent header group
        propertyGrid.SelectedObject = New KryptonHeaderGroupProxy(CType(c.Parent, KryptonHeaderGroup))
    End Sub

    Private Sub rtb_MouseDown(sender As Object, e As MouseEventArgs) Handles headerGroup1OfficeRTB.MouseDown, richTextBox1.MouseDown
        Dim c As Control = CType(sender, Control)

        ' Setup the property grid to edit this richt text box parent header group
        propertyGrid.SelectedObject = New KryptonHeaderGroupProxy(CType(c.Parent.Parent, KryptonHeaderGroup))
    End Sub

    Private Sub buttonClose_Click(sender As Object, e As EventArgs) Handles buttonClose.Click
        Close()
    End Sub

End Class

Public Class KryptonHeaderGroupProxy

    Private _headerGroup As KryptonHeaderGroup

    Public Sub New(headerGroup As KryptonHeaderGroup)
        _headerGroup = headerGroup
    End Sub

    <Category("Visuals")>
    <Description("Should tooltips be displayed for button specs.")>
    <DefaultValue(False)>
    Public Property AllowButtonSpecToolTips() As Boolean
        Get
            Return _headerGroup.AllowButtonSpecToolTips
        End Get
        Set(value As Boolean)
            _headerGroup.AllowButtonSpecToolTips = value
        End Set
    End Property

    <Category("Visuals")>
    <Description("Clicking an arrow button spec should toggle collapse state.")>
    <DefaultValue(True)>
    Public Property AutoCollapseArrow() As Boolean
        Get
            Return _headerGroup.AutoCollapseArrow
        End Get
        Set(value As Boolean)
            _headerGroup.AutoCollapseArrow = value
        End Set
    End Property

    <Category("Visuals")>
    <Description("Specifies if the appearance is collapsed.")>
    <DefaultValue(False)>
    Public Property Collapsed() As Boolean
        Get
            Return _headerGroup.Collapsed
        End Get
        Set(value As Boolean)
            _headerGroup.Collapsed = value
        End Set
    End Property

    <Category("Visuals")>
    <Description("Specifies how to collapsed the appearance when entering collapse mode.")>
    <DefaultValue(HeaderGroupCollapsedTarget.CollapsedToPrimary)>
    Public Property CollapseTarget() As HeaderGroupCollapsedTarget
        Get
            Return _headerGroup.CollapseTarget
        End Get
        Set(value As HeaderGroupCollapsedTarget)
            _headerGroup.CollapseTarget = value
        End Set
    End Property

    <Category("Visuals")>
    <Description("Border style.")>
    <DefaultValue(PaletteBorderStyle.ControlClient)>
    Public Property GroupBorderStyle() As PaletteBorderStyle
        Get
            Return _headerGroup.GroupBorderStyle
        End Get
        Set(value As PaletteBorderStyle)
            _headerGroup.GroupBorderStyle = value
        End Set
    End Property

    ''' <summary>
    ''' Gets and sets the background style.
    ''' </summary>
    <Category("Visuals")>
    <Description("Background style.")>
    <DefaultValue(PaletteBackStyle.ControlClient)>
    Public Property GroupBackStyle() As PaletteBackStyle
        Get
            Return _headerGroup.GroupBackStyle
        End Get
        Set(value As PaletteBackStyle)
            _headerGroup.GroupBackStyle = value
        End Set
    End Property

    <Category("Visuals")>
    <Description("Primary header style.")>
    <DefaultValue(HeaderStyle.Primary)>
    Public Property HeaderStylePrimary() As HeaderStyle
        Get
            Return _headerGroup.HeaderStylePrimary
        End Get
        Set(value As HeaderStyle)
            _headerGroup.HeaderStylePrimary = value
        End Set
    End Property

    <Category("Visuals")>
    <Description("Secondary header style.")>
    <DefaultValue(HeaderStyle.Secondary)>
    Public Property HeaderStyleSecondary() As HeaderStyle
        Get
            Return _headerGroup.HeaderStyleSecondary
        End Get
        Set(value As HeaderStyle)
            _headerGroup.HeaderStyleSecondary = value
        End Set
    End Property

    <Category("Visuals")>
    <Description("Edge position of the primary header.")>
    <DefaultValue(VisualOrientation.Top)>
    Public Property HeaderPositionPrimary() As VisualOrientation
        Get
            Return _headerGroup.HeaderPositionPrimary
        End Get
        Set(value As VisualOrientation)
            _headerGroup.HeaderPositionPrimary = value
        End Set
    End Property

    <Category("Visuals")>
    <Description("Edge position of the secondary header.")>
    <DefaultValue(VisualOrientation.Bottom)>
    Public Property HeaderPositionSecondary() As VisualOrientation
        Get
            Return _headerGroup.HeaderPositionSecondary
        End Get
        Set(value As VisualOrientation)
            _headerGroup.HeaderPositionSecondary = value
        End Set
    End Property

    <Category("Visuals")>
    <Description("Primary header visibility.")>
    <DefaultValue(True)>
    Public Property HeaderVisiblePrimary() As Boolean
        Get
            Return _headerGroup.HeaderVisiblePrimary
        End Get
        Set(value As Boolean)
            _headerGroup.HeaderVisiblePrimary = value
        End Set
    End Property

    <Category("Visuals")>
    <Description("Secondary header visibility.")>
    <DefaultValue(True)>
    Public Property HeaderVisibleSecondary() As Boolean
        Get
            Return _headerGroup.HeaderVisibleSecondary
        End Get
        Set(value As Boolean)
            _headerGroup.HeaderVisibleSecondary = value
        End Set
    End Property

    <Category("Visuals")>
    <Description("Overrides for defining common header group appearance that other states can override.")>
    Public ReadOnly Property StateCommon() As PaletteHeaderGroupRedirect
        Get
            Return _headerGroup.StateCommon
        End Get
    End Property

    <Category("Visuals")>
    <Description("Overrides for defining disabled header group appearance.")>
    Public ReadOnly Property StateDisabled() As PaletteHeaderGroup
        Get
            Return _headerGroup.StateDisabled
        End Get
    End Property

    <Category("Visuals")>
    <Description("Overrides for defining normal header group appearance.")>
    Public ReadOnly Property StateNormal() As PaletteHeaderGroup
        Get
            Return _headerGroup.StateNormal
        End Get
    End Property

    <Category("Visuals")>
    <Description("Collection of button specifications.")>
    Public ReadOnly Property ButtonSpecs() As KryptonHeaderGroup.HeaderGroupButtonSpecCollection
        Get
            Return _headerGroup.ButtonSpecs
        End Get
    End Property

    <Category("Visuals")>
    <Description("Primary header values")>
    Public ReadOnly Property ValuesPrimary() As HeaderGroupValuesPrimary
        Get
            Return _headerGroup.ValuesPrimary
        End Get
    End Property

    <Category("Visuals")>
    <Description("Secondary header values")>
    Public ReadOnly Property ValuesSecondary() As HeaderGroupValuesSecondary
        Get
            Return _headerGroup.ValuesSecondary
        End Get
    End Property

    <Category("Visuals")>
    <Description("Palette applied to drawing.")>
    <DefaultValue(PaletteMode.Global)>
    Public Property PaletteMode() As PaletteMode
        Get
            Return _headerGroup.PaletteMode
        End Get
        Set(value As PaletteMode)
            _headerGroup.PaletteMode = value
        End Set
    End Property

    <Category("Layout")>
    <Description("The size of the control is pixels.")>
    Public Property Size() As Size
        Get
            Return _headerGroup.Size
        End Get
        Set(value As Size)
            _headerGroup.Size = value
        End Set
    End Property

    <Category("Layout")>
    <Description("The location of the control in pixels.")>
    Public Property Location() As Point
        Get
            Return _headerGroup.Location
        End Get
        Set(value As Point)
            _headerGroup.Location = value
        End Set
    End Property

    <Category("Behavior")>
    <Description("Indicates whether the control is enabled.")>
    Public Property Enabled() As Boolean
        Get
            Return _headerGroup.Enabled
        End Get
        Set(value As Boolean)
            _headerGroup.Enabled = value
        End Set
    End Property

End Class
