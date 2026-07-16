#Region "BSD License"
'
' Original BSD 3-Clause License (https://github.com/ComponentFactory/Krypton/blob/master/LICENSE)
'  © Component Factory Pty Ltd, 2006 - 2016, (Version 4.5.0.0) All rights reserved.
'
'  New BSD 3-Clause License (https://github.com/Krypton-Suite/Standard-Toolkit/blob/master/LICENSE)
'  Modifications by Peter Wagner(aka Wagnerp) & Simon Coghlan(aka Smurf-IV), tobitege et al. 2017 - 2025. All rights reserved.
'
' VB.NET twin of Source\Krypton Toolkit Examples\KryptonSplitContainer Examples\Form1.cs (Bastion Phase 4c).
#End Region

Imports System
Imports System.ComponentModel
Imports System.Drawing
Imports System.Windows.Forms

Imports Krypton.Toolkit

Public Class Form1

    Private Sub Form1_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        ' Setup the property grid to edit this split container
        propertyGrid.SelectedObject = New KryptonSplitContainerProxy(splitContainer1Office)
    End Sub

    Private Sub splitContainer_MouseDown(sender As Object, e As MouseEventArgs) Handles _
        splitContainer1Office.MouseDown, splitContainer2Office.MouseDown,
        splitContainer1Blue.MouseDown, splitContainer2Blue.MouseDown,
        kryptonSplitContainer1.MouseDown, splitContainer1Custom.MouseDown

        ' Setup the property grid to edit this split container
        propertyGrid.SelectedObject = New KryptonSplitContainerProxy(DirectCast(sender, KryptonSplitContainer))
    End Sub

    Private Sub splitContainerPanel_MouseDown(sender As Object, e As MouseEventArgs) Handles _
        splitContainer1Office.Panel1.MouseDown, splitContainer1Office.Panel2.MouseDown,
        splitContainer2Office.Panel1.MouseDown, splitContainer2Office.Panel2.MouseDown,
        splitContainer1Blue.Panel1.MouseDown, splitContainer1Blue.Panel2.MouseDown,
        splitContainer2Blue.Panel1.MouseDown, splitContainer2Blue.Panel2.MouseDown,
        kryptonSplitContainer1.Panel1.MouseDown, kryptonSplitContainer1.Panel2.MouseDown,
        splitContainer1Custom.Panel1.MouseDown, splitContainer1Custom.Panel2.MouseDown

        Dim panel As KryptonPanel = DirectCast(sender, KryptonPanel)

        ' Setup the property grid to edit this panels parent split container
        propertyGrid.SelectedObject = New KryptonSplitContainerProxy(DirectCast(panel.Parent, KryptonSplitContainer))
    End Sub

    Private Sub splitContainerLabel_MouseDown(sender As Object, e As MouseEventArgs) Handles _
        splitContainer1OfficeLabel1.MouseDown, splitContainer1OfficeLabel2.MouseDown,
        splitContainer2OfficeLabel1.MouseDown, splitContainer2OfficeLabel2.MouseDown,
        splitContainer1SystemLabel1.MouseDown, splitContainer1SystemLabel2.MouseDown,
        splitContainer1CustomLabel1.MouseDown, splitContainer1CustomLabel2.MouseDown,
        splitContainer2CustomLabel1.MouseDown, splitContainer2CustomLabel2.MouseDown

        Dim label As KryptonLabel = DirectCast(sender, KryptonLabel)
        Dim panel As KryptonPanel = DirectCast(label.Parent, KryptonPanel)

        ' Setup the property grid to edit this panels parent split container
        propertyGrid.SelectedObject = New KryptonSplitContainerProxy(DirectCast(panel.Parent, KryptonSplitContainer))
    End Sub

    Private Sub splitContainerGroupLabel_MouseDown(sender As Object, e As MouseEventArgs) Handles _
        splitContainer2SystemLabel1.MouseDown, splitContainer2SystemLabel2.MouseDown

        Dim label As KryptonLabel = DirectCast(sender, KryptonLabel)
        Dim panel As KryptonPanel = DirectCast(label.Parent, KryptonPanel)

        ' Setup the property grid to edit this panels parent split container
        propertyGrid.SelectedObject = New KryptonSplitContainerProxy(DirectCast(panel.Parent.Parent.Parent, KryptonSplitContainer))
    End Sub

    Private Sub buttonClose_Click(sender As Object, e As EventArgs) Handles buttonClose.Click
        Close()
    End Sub

End Class

Public Class KryptonSplitContainerProxy

    Private _splitContainer As KryptonSplitContainer

    Public Sub New(splitContainer As KryptonSplitContainer)
        _splitContainer = splitContainer
    End Sub

    <Category("Visuals")>
    <Description("Container background style.")>
    <DefaultValue(PaletteBackStyle.PanelClient)>
    Public Property ContainerBackStyle As PaletteBackStyle
        Get
            Return _splitContainer.ContainerBackStyle
        End Get
        Set(value As PaletteBackStyle)
            _splitContainer.ContainerBackStyle = value
        End Set
    End Property

    <Category("Visuals")>
    <Description("Separator style.")>
    <DefaultValue(SeparatorStyle.LowProfile)>
    Public Property SeparatorStyle As SeparatorStyle
        Get
            Return _splitContainer.SeparatorStyle
        End Get
        Set(value As SeparatorStyle)
            _splitContainer.SeparatorStyle = value
        End Set
    End Property

    <Category("Visuals")>
    <Description("Overrides for defining common split container appearance that other states can override.")>
    Public ReadOnly Property StateCommon As PaletteSplitContainerRedirect
        Get
            Return _splitContainer.StateCommon
        End Get
    End Property

    <Category("Visuals")>
    <Description("Overrides for defining disabled split container appearance.")>
    Public ReadOnly Property StateDisabled As PaletteSplitContainer
        Get
            Return _splitContainer.StateDisabled
        End Get
    End Property

    <Category("Visuals")>
    <Description("Overrides for defining normal split container appearance.")>
    Public ReadOnly Property StateNormal As PaletteSplitContainer
        Get
            Return _splitContainer.StateNormal
        End Get
    End Property

    <Category("Visuals")>
    <Description("Overrides for defining hot tracking separator appearance.")>
    Public ReadOnly Property StateTracking As PaletteSeparatorPadding
        Get
            Return _splitContainer.StateTracking
        End Get
    End Property

    <Category("Visuals")>
    <Description("Overrides for defining pressed separator appearance.")>
    Public ReadOnly Property StatePressed As PaletteSeparatorPadding
        Get
            Return _splitContainer.StatePressed
        End Get
    End Property

    <Category("Layout")>
    <Description("Determines the minimum distance of pixels of the splitter from the left or top edge of Panel1.")>
    <Localizable(True)>
    <DefaultValue(25)>
    Public Property Panel1MinSize As Integer
        Get
            Return _splitContainer.Panel1MinSize
        End Get
        Set(value As Integer)
            _splitContainer.Panel1MinSize = value
        End Set
    End Property

    <Category("Layout")>
    <Description("Determines if Panel1 is collapsed.")>
    <DefaultValue(False)>
    Public Property Panel1Collapsed As Boolean
        Get
            Return _splitContainer.Panel1Collapsed
        End Get
        Set(value As Boolean)
            _splitContainer.Panel1Collapsed = value
        End Set
    End Property

    <Category("Layout")>
    <Description("Determines the minimum distance of pixels of the splitter from the right or bottom edge of Panel2.")>
    <Localizable(True)>
    <DefaultValue(25)>
    Public Property Panel2MinSize As Integer
        Get
            Return _splitContainer.Panel2MinSize
        End Get
        Set(value As Integer)
            _splitContainer.Panel2MinSize = value
        End Set
    End Property

    <Category("Layout")>
    <Description("Determines if Panel2 is collapsed.")>
    <DefaultValue(False)>
    Public Property Panel2Collapsed As Boolean
        Get
            Return _splitContainer.Panel2Collapsed
        End Get
        Set(value As Boolean)
            _splitContainer.Panel2Collapsed = value
        End Set
    End Property

    <Category("Layout")>
    <Description("Determines if the splitter is fixed.")>
    <Localizable(True)>
    <DefaultValue(False)>
    Public Property IsSplitterFixed As Boolean
        Get
            Return _splitContainer.IsSplitterFixed
        End Get
        Set(value As Boolean)
            _splitContainer.IsSplitterFixed = value
        End Set
    End Property

    <Category("Layout")>
    <Description("Indicates the panel to keep the same size when resizing.")>
    <DefaultValue(FixedPanel.None)>
    Public Property FixedPanel As FixedPanel
        Get
            Return _splitContainer.FixedPanel
        End Get
        Set(value As FixedPanel)
            _splitContainer.FixedPanel = value
        End Set
    End Property

    <Category("Layout")>
    <Description("Determines pixel distance of the splitter from the left or top edge.")>
    <Localizable(True)>
    <SettingsBindable(True)>
    <DefaultValue(50)>
    Public Property SplitterDistance As Integer
        Get
            Return _splitContainer.SplitterDistance
        End Get
        Set(value As Integer)
            _splitContainer.SplitterDistance = value
        End Set
    End Property

    <Category("Layout")>
    <Description("Determines the thickness of the splitter.")>
    <Localizable(True)>
    <DefaultValue(4)>
    Public Property SplitterWidth As Integer
        Get
            Return _splitContainer.SplitterWidth
        End Get
        Set(value As Integer)
            _splitContainer.SplitterWidth = value
        End Set
    End Property

    <Category("Layout")>
    <Description("Determines the number of pixels the splitter moves in increments.")>
    <Localizable(True)>
    <DefaultValue(1)>
    Public Property SplitterIncrement As Integer
        Get
            Return _splitContainer.SplitterIncrement
        End Get
        Set(value As Integer)
            _splitContainer.SplitterIncrement = value
        End Set
    End Property

    <Category("Behavior")>
    <Description("Determines if the splitter is vertical or horizontal.")>
    <Localizable(True)>
    <DefaultValue(Orientation.Vertical)>
    Public Property Orientation As Orientation
        Get
            Return _splitContainer.Orientation
        End Get
        Set(value As Orientation)
            _splitContainer.Orientation = value
        End Set
    End Property

    <Category("Visuals")>
    <Description("Palette applied to drawing.")>
    <DefaultValue(PaletteMode.Global)>
    Public Property PaletteMode As PaletteMode
        Get
            Return _splitContainer.PaletteMode
        End Get
        Set(value As PaletteMode)
            _splitContainer.PaletteMode = value
        End Set
    End Property

    <Category("Layout")>
    <Description("The size of the control is pixels.")>
    Public Property Size As Size
        Get
            Return _splitContainer.Size
        End Get
        Set(value As Size)
            _splitContainer.Size = value
        End Set
    End Property

    <Category("Layout")>
    <Description("The location of the control in pixels.")>
    Public Property Location As Point
        Get
            Return _splitContainer.Location
        End Get
        Set(value As Point)
            _splitContainer.Location = value
        End Set
    End Property

End Class
