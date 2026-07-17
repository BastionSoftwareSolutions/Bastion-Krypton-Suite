' Original BSD 3-Clause License (https://github.com/ComponentFactory/Krypton/blob/master/LICENSE)
'  © Component Factory Pty Ltd, 2006 - 2016, (Version 4.5.0.0) All rights reserved.
'
'  New BSD 3-Clause License (https://github.com/Krypton-Suite/Standard-Toolkit/blob/master/LICENSE)
'  Modifications by Peter Wagner(aka Wagnerp) & Simon Coghlan(aka Smurf-IV), tobitege et al. 2017 - 2025. All rights reserved.
'
' VB.NET twin of Source\Krypton Toolkit Examples\KryptonDomainUpDown Examples\Form1.cs (Bastion Phase 4c).

Imports System.ComponentModel
Imports System.Drawing
Imports System.Windows.Forms

Imports Krypton.Toolkit

Public Class Form1

    Public Sub New()
        InitializeComponent()
    End Sub

    Private Sub Form1_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        ' Setup the property grid to edit this domain upo-down control
        propertyGrid.SelectedObject = New KryptonDomainUpDownProxy(dud1)
    End Sub

    Private Sub dud_Enter(sender As Object, e As EventArgs) Handles _
        dud1.Enter, dud2.Enter, dud3.Enter, dud4.Enter, dud5.Enter, dud6.Enter,
        dud7.Enter, dud8.Enter, dud9.Enter, dud10.Enter, dud11.Enter, dud12.Enter
        ' Setup the property grid to edit this domain upo-down control
        propertyGrid.SelectedObject = New KryptonDomainUpDownProxy(CType(sender, KryptonDomainUpDown))
    End Sub

    Private Sub buttonOffice2010Blue_Click(sender As Object, e As EventArgs) Handles buttonOffice2010Blue.Click
        kryptonManager1.GlobalPaletteMode = PaletteMode.Office2010Blue
    End Sub

    Private Sub buttonOffice2007Blue_Click(sender As Object, e As EventArgs) Handles buttonOffice2007Blue.Click
        kryptonManager1.GlobalPaletteMode = PaletteMode.Office2007Blue
    End Sub

    Private Sub buttonSystem_Click(sender As Object, e As EventArgs) Handles buttonSystem.Click
        kryptonManager1.GlobalPaletteMode = PaletteMode.ProfessionalSystem
    End Sub

    Private Sub buttonSparkleBlue_Click(sender As Object, e As EventArgs) Handles buttonSparkleBlue.Click
        kryptonManager1.GlobalPaletteMode = PaletteMode.SparkleBlue
    End Sub

    Private Sub buttonSpecAny1_Click(sender As Object, e As EventArgs) Handles buttonSpecAny1.Click
        dud5.Text = String.Empty
    End Sub

    Private Sub buttonSpecAny2_Click(sender As Object, e As EventArgs) Handles buttonSpecAny2.Click
        dud6.Text = String.Empty
    End Sub

    Private Sub buttonSpecAny6_Click(sender As Object, e As EventArgs) Handles buttonSpecAny6.Click
        dud11.Text = String.Empty
    End Sub

    Private Sub buttonSpecAny4_Click(sender As Object, e As EventArgs) Handles buttonSpecAny4.Click
        dud12.Text = String.Empty
    End Sub

    Private Sub contextMenuClicked(sender As Object, e As EventArgs) Handles _
        kryptonContextMenuItem6.Click, kryptonContextMenuItem7.Click, kryptonContextMenuItem8.Click,
        kryptonContextMenuItem9.Click, kryptonContextMenuItem10.Click, kryptonContextMenuItem11.Click
        Dim item As KryptonContextMenuItem = CType(sender, KryptonContextMenuItem)
        dud6.Text = item.Text
        dud12.Text = item.Text
    End Sub

    Private Sub buttonClose_Click(sender As Object, e As EventArgs) Handles buttonClose.Click
        Close()
    End Sub

End Class

Public Class KryptonDomainUpDownProxy

    Private _domainUpDown As KryptonDomainUpDown

    Public Sub New(domainUpDown As KryptonDomainUpDown)
        _domainUpDown = domainUpDown
    End Sub

    <Category("Visuals")>
    <Description("Determines if the control is always active or only when the mouse is over the control or has focus.")>
    Public Property AlwaysActive() As Boolean
        Get
            Return _domainUpDown.AlwaysActive
        End Get
        Set(value As Boolean)
            _domainUpDown.AlwaysActive = value
        End Set
    End Property

    <Category("Appearance")>
    <Description("Indicates how the text should be aligned for edit controls.")>
    Public Property TextAlign() As HorizontalAlignment
        Get
            Return _domainUpDown.TextAlign
        End Get
        Set(value As HorizontalAlignment)
            _domainUpDown.TextAlign = value
        End Set
    End Property

    <Category("Behavior")>
    <Description("Controls whether the text in the edit control can be changed or not.")>
    Public Property [ReadOnly]() As Boolean
        Get
            Return _domainUpDown.ReadOnly
        End Get
        Set(value As Boolean)
            _domainUpDown.ReadOnly = value
        End Set
    End Property

    <Category("Visuals")>
    <Description("Input control style.")>
    Public Property InputControlStyle() As InputControlStyle
        Get
            Return _domainUpDown.InputControlStyle
        End Get
        Set(value As InputControlStyle)
            _domainUpDown.InputControlStyle = value
        End Set
    End Property

    <Category("Visuals")>
    <Description("Should tooltips be displayed for button specs.")>
    Public Property AllowButtonSpecToolTips() As Boolean
        Get
            Return _domainUpDown.AllowButtonSpecToolTips
        End Get
        Set(value As Boolean)
            _domainUpDown.AllowButtonSpecToolTips = value
        End Set
    End Property

    <Category("Visuals")>
    <Description("Collection of button specifications.")>
    Public ReadOnly Property ButtonSpecs() As KryptonDomainUpDown.DomainUpDownButtonSpecCollection
        Get
            Return _domainUpDown.ButtonSpecs
        End Get
    End Property

    <Category("Visuals")>
    <Description("Overrides for defining common textbox appearance that other states can override.")>
    Public ReadOnly Property StateCommon() As PaletteInputControlTripleRedirect
        Get
            Return _domainUpDown.StateCommon
        End Get
    End Property

    <Category("Visuals")>
    <Description("Overrides for defining disabled textbox appearance.")>
    Public ReadOnly Property StateDisabled() As PaletteInputControlTripleStates
        Get
            Return _domainUpDown.StateDisabled
        End Get
    End Property

    <Category("Visuals")>
    <Description("Overrides for defining normal textbox appearance.")>
    Public ReadOnly Property StateNormal() As PaletteInputControlTripleStates
        Get
            Return _domainUpDown.StateNormal
        End Get
    End Property

    <Category("Visuals")>
    <Description("Overrides for defining active textbox appearance.")>
    Public ReadOnly Property StateActive() As PaletteInputControlTripleStates
        Get
            Return _domainUpDown.StateActive
        End Get
    End Property

    <Category("Layout")>
    <Description("The size of the control is pixels.")>
    Public Property Size() As Size
        Get
            Return _domainUpDown.Size
        End Get
        Set(value As Size)
            _domainUpDown.Size = value
        End Set
    End Property

    <Category("Layout")>
    <Description("The location of the control in pixels.")>
    Public Property Location() As Point
        Get
            Return _domainUpDown.Location
        End Get
        Set(value As Point)
            _domainUpDown.Location = value
        End Set
    End Property

    ''' <summary>
    ''' Gets or sets how the up-down control will position the up down buttons relative to its text box.
    ''' </summary>
    <Category("Appearance")>
    <Description("Indicates how the up-down control will position the up down buttons relative to its text box.")>
    Public Property UpDownAlign() As LeftRightAlignment
        Get
            Return _domainUpDown.UpDownAlign
        End Get
        Set(value As LeftRightAlignment)
            _domainUpDown.UpDownAlign = value
        End Set
    End Property

    ''' <summary>
    ''' Gets or sets whether the up-down control will increment and decrement the value when the UP ARROW and DOWN ARROW are used.
    ''' </summary>
    <Category("Behavior")>
    <Description("Indicates whether the up-down control will increment and decrement the value when the UP ARROW and DOWN ARROW are used.")>
    Public Property InterceptArrowKeys() As Boolean
        Get
            Return _domainUpDown.InterceptArrowKeys
        End Get
        Set(value As Boolean)
            _domainUpDown.InterceptArrowKeys = value
        End Set
    End Property

    ''' <summary>
    ''' Gets and sets the up and down buttons style.
    ''' </summary>
    <Category("Visuals")>
    <Description("Up and down buttons style.")>
    Public Property UpDownButtonStyle() As ButtonStyle
        Get
            Return _domainUpDown.UpDownButtonStyle
        End Get
        Set(value As ButtonStyle)
            _domainUpDown.UpDownButtonStyle = value
        End Set
    End Property

    ''' <summary>
    ''' Gets or sets the text for the control.
    ''' </summary>
    <Category("Appearance")>
    <Description("Domain display text.")>
    Public Property Text() As String
        Get
            Return _domainUpDown.Text
        End Get
        Set(value As String)
            _domainUpDown.Text = value
        End Set
    End Property

    ''' <summary>
    ''' Gets or the collection of allowable items of the domain up down.
    ''' </summary>
    <Category("Data")>
    <Description("The allowable items of the domain up down.")>
    Public ReadOnly Property Items() As DomainUpDown.DomainUpDownItemCollection
        Get
            Return _domainUpDown.Items
        End Get
    End Property

End Class
