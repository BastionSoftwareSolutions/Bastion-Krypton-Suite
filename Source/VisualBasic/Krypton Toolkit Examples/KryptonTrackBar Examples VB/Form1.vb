' *****************************************************************************
' BSD 3-Clause License (https://github.com/Krypton-Suite/Standard-Toolkit)
'  By Peter Wagner(aka Wagnerp) & Simon Coghlan(aka Smurf-IV) 2020 - 2024. All rights reserved.
' *****************************************************************************
' VB.NET twin of Source\Krypton Toolkit Examples\KryptonTrackBar Examples\Form1.cs (Bastion Phase 4c).

Imports System.ComponentModel
Imports System.Windows.Forms

Imports Krypton.Toolkit

Public Class Form1

    Public Sub New()
        InitializeComponent()
    End Sub

    Private Sub Form1_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        ' Setup the property grid to edit the first track bar control
        propertyGrid.SelectedObject = New KryptonTrackBarProxy(kryptonTrackBar1)
    End Sub

    Private Sub trackBar_Enter(sender As Object, e As EventArgs) Handles kryptonTrackBar1.Enter, kryptonTrackBar2.Enter, kryptonTrackBar3.Enter, kryptonTrackBar4.Enter, kryptonTrackBar5.Enter, kryptonTrackBar6.Enter, kryptonTrackBar7.Enter, kryptonTrackBar8.Enter, kryptonTrackBar9.Enter, kryptonTrackBar10.Enter, kryptonTrackBar11.Enter
        ' Setup the property grid to edit this track bar control
        propertyGrid.SelectedObject = New KryptonTrackBarProxy(CType(sender, KryptonTrackBar))
    End Sub

    Private Sub buttonClose_Click(sender As Object, e As EventArgs) Handles buttonClose.Click
        Close()
    End Sub

End Class

Public Class KryptonTrackBarProxy

    Private _trackBar As KryptonTrackBar

    Public Sub New(trackBar As KryptonTrackBar)
        _trackBar = trackBar
    End Sub

    ''' <summary>
    ''' Gets and sets the internal padding space.
    ''' </summary>
    <DefaultValue(GetType(Padding), "0,0,0,0")>
    Public Property Padding() As Padding
        Get
            Return _trackBar.Padding
        End Get
        Set(value As Padding)
            _trackBar.Padding = value
        End Set
    End Property

    ''' <summary>
    ''' Gets and sets the background style.
    ''' </summary>
    <Category("Visuals")>
    <Description("Background style.")>
    Public Property BackStyle() As PaletteBackStyle
        Get
            Return _trackBar.BackStyle
        End Get
        Set(value As PaletteBackStyle)
            _trackBar.BackStyle = value
        End Set
    End Property

    ''' <summary>
    ''' Gets and sets if the control should draw the background.
    ''' </summary>
    <Category("Visuals")>
    <Description("Draw Background (Default = true);" & vbCrLf & "Note: Does not draw correctly in designer if false.")>
    <RefreshProperties(RefreshProperties.Repaint)>
    Public Property DrawBackground() As Boolean
        Get
            Return _trackBar.DrawBackground
        End Get
        Set(value As Boolean)
            _trackBar.DrawBackground = value
        End Set
    End Property

    ''' <summary>
    ''' Gets access to the track bar appearance when it has focus.
    ''' </summary>
    <Category("Visuals")>
    <Description("Overrides for defining track bar appearance when it has focus.")>
    <DesignerSerializationVisibility(DesignerSerializationVisibility.Content)>
    Public ReadOnly Property OverrideFocus() As PaletteTrackBarRedirect
        Get
            Return _trackBar.OverrideFocus
        End Get
    End Property

    ''' <summary>
    ''' Gets access to the common trackbar appearance that other states can override.
    ''' </summary>
    <Category("Visuals")>
    <Description("Overrides for defining common trackbar appearance that other states can override.")>
    <DesignerSerializationVisibility(DesignerSerializationVisibility.Content)>
    Public ReadOnly Property StateCommon() As PaletteTrackBarRedirect
        Get
            Return _trackBar.StateCommon
        End Get
    End Property

    ''' <summary>
    ''' Gets access to the disabled trackbar appearance.
    ''' </summary>
    <Category("Visuals")>
    <Description("Overrides for defining disabled trackbar appearance.")>
    <DesignerSerializationVisibility(DesignerSerializationVisibility.Content)>
    Public ReadOnly Property StateDisabled() As PaletteTrackBarStates
        Get
            Return _trackBar.StateDisabled
        End Get
    End Property

    ''' <summary>
    ''' Gets access to the normal trackbar appearance.
    ''' </summary>
    <Category("Visuals")>
    <Description("Overrides for defining normal trackbar appearance.")>
    <DesignerSerializationVisibility(DesignerSerializationVisibility.Content)>
    Public ReadOnly Property StateNormal() As PaletteTrackBarStates
        Get
            Return _trackBar.StateNormal
        End Get
    End Property

    ''' <summary>
    ''' Gets access to the tracking trackbar appearance.
    ''' </summary>
    <Category("Visuals")>
    <Description("Overrides for defining tracking trackbar appearance.")>
    <DesignerSerializationVisibility(DesignerSerializationVisibility.Content)>
    Public ReadOnly Property StateTracking() As PaletteTrackBarPositionStates
        Get
            Return _trackBar.StateTracking
        End Get
    End Property

    ''' <summary>
    ''' Gets access to the pressed trackbar appearance.
    ''' </summary>
    <Category("Visuals")>
    <Description("Overrides for defining pressed trackbar appearance.")>
    <DesignerSerializationVisibility(DesignerSerializationVisibility.Content)>
    Public ReadOnly Property StatePressed() As PaletteTrackBarPositionStates
        Get
            Return _trackBar.StatePressed
        End Get
    End Property

    ''' <summary>
    ''' Gets and sets the size of the track bar elements.
    ''' </summary>
    <Category("Appearance")>
    <Description("Determines size of the track bar elements.")>
    <DefaultValue(PaletteTrackBarSize.Medium)>
    Public Property TrackBarSize() As PaletteTrackBarSize
        Get
            Return _trackBar.TrackBarSize
        End Get
        Set(value As PaletteTrackBarSize)
            _trackBar.TrackBarSize = value
        End Set
    End Property

    ''' <summary>
    ''' Gets or sets a value indicating how to display the tick marks on the track bar.
    ''' </summary>
    <Category("Appearance")>
    <Description("Determines where tick marks are displayed.")>
    <DefaultValue(TickStyle.BottomRight)>
    <RefreshProperties(RefreshProperties.All)>
    Public Property TickStyle() As TickStyle
        Get
            Return _trackBar.TickStyle
        End Get
        Set(value As TickStyle)
            _trackBar.TickStyle = value
        End Set
    End Property

    ''' <summary>
    ''' Gets or sets a value that specifies the delta between ticks drawn on the control.
    ''' </summary>
    <Category("Appearance")>
    <Description("Determines the frequency of tick marks.")>
    <DefaultValue(1)>
    Public Property TickFrequency() As Integer
        Get
            Return _trackBar.TickFrequency
        End Get
        Set(value As Integer)
            _trackBar.TickFrequency = value
        End Set
    End Property

    ''' <summary>
    ''' Gets or sets a value indicating the horizontal or vertical orientation of the track bar.
    ''' </summary>
    <Category("Appearance")>
    <Description("Background style.")>
    <DefaultValue(Orientation.Horizontal)>
    Public Property Orientation() As Orientation
        Get
            Return _trackBar.Orientation
        End Get
        Set(value As Orientation)
            _trackBar.Orientation = value
        End Set
    End Property

    ''' <summary>
    ''' Gets or sets the upper limit of the range this trackbar is working with.
    ''' </summary>
    <Category("Behavior")>
    <Description("Upper limit of the trackbar range.")>
    <RefreshProperties(RefreshProperties.All)>
    <DefaultValue(10)>
    Public Property Maximum() As Integer
        Get
            Return _trackBar.Maximum
        End Get
        Set(value As Integer)
            _trackBar.Maximum = value
        End Set
    End Property

    ''' <summary>
    ''' Gets or sets the lower limit of the range this trackbar is working with.
    ''' </summary>
    <Category("Behavior")>
    <Description("Lower limit of the trackbar range.")>
    <RefreshProperties(RefreshProperties.All)>
    <DefaultValue(0)>
    Public Property Minimum() As Integer
        Get
            Return _trackBar.Minimum
        End Get
        Set(value As Integer)
            _trackBar.Minimum = value
        End Set
    End Property

    ''' <summary>
    ''' Gets or sets a numeric value that represents the current position of the scroll box on the track bar.
    ''' </summary>
    <Category("Behavior")>
    <Description("Current position of the indicator within the trackbar.")>
    <DefaultValue(0)>
    Public Property Value() As Integer
        Get
            Return _trackBar.Value
        End Get
        Set(value As Integer)
            _trackBar.Value = value
        End Set
    End Property

    ''' <summary>
    ''' Gets or sets the value added to or subtracted from the Value property when the scroll box is moved a small distance.
    ''' </summary>
    <Category("Behavior")>
    <Description("Change to apply when a small change occurs.")>
    <DefaultValue(1)>
    Public Property SmallChange() As Integer
        Get
            Return _trackBar.SmallChange
        End Get
        Set(value As Integer)
            _trackBar.SmallChange = value
        End Set
    End Property

    ''' <summary>
    ''' Gets or sets a value to be added to or subtracted from the Value property when the scroll box is moved a large distance.
    ''' </summary>
    <Category("Behavior")>
    <Description("Change to apply when a large change occurs.")>
    <DefaultValue(5)>
    Public Property LargeChange() As Integer
        Get
            Return _trackBar.LargeChange
        End Get
        Set(value As Integer)
            _trackBar.LargeChange = value
        End Set
    End Property

End Class
