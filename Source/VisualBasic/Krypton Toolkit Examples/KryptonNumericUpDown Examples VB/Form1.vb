#Region "BSD License"
'
' Original BSD 3-Clause License (https://github.com/ComponentFactory/Krypton/blob/master/LICENSE)
'  © Component Factory Pty Ltd, 2006 - 2016, (Version 4.5.0.0) All rights reserved.
'
'  New BSD 3-Clause License (https://github.com/Krypton-Suite/Standard-Toolkit/blob/master/LICENSE)
'  Modifications by Peter Wagner(aka Wagnerp) & Simon Coghlan(aka Smurf-IV), et al. 2017 - 2024. All rights reserved.
'
' VB.NET twin of Source\Krypton Toolkit Examples\KryptonNumericUpDown Examples\Form1.cs (Bastion Phase 4c).
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
        ' Setup the property grid to edit this numeric up-down control
        propertyGrid.SelectedObject = New KryptonNumericUpDownProxy(nud1)
    End Sub

    Private Sub nud_Enter(sender As Object, e As EventArgs) Handles nud1.Enter, nud2.Enter, nud3.Enter,
        nud4.Enter, nud5.Enter, nud6.Enter, nud7.Enter, nud12.Enter, nud8.Enter, nud11.Enter,
        nud9.Enter, nud10.Enter
        ' Setup the property grid to edit this numeric up-down control
        propertyGrid.SelectedObject = New KryptonNumericUpDownProxy(CType(sender, KryptonNumericUpDown))
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
        nud5.Value = nud5.Minimum
    End Sub

    Private Sub buttonSpecAny2_Click(sender As Object, e As EventArgs) Handles buttonSpecAny2.Click
        nud6.Value = nud6.Minimum
    End Sub

    Private Sub buttonSpecAny6_Click(sender As Object, e As EventArgs) Handles buttonSpecAny6.Click
        nud11.Value = nud11.Minimum
    End Sub

    Private Sub buttonSpecAny4_Click(sender As Object, e As EventArgs) Handles buttonSpecAny4.Click
        nud12.Value = nud12.Minimum
    End Sub

    Private Sub kryptonContextMenuItem1_Click(sender As Object, e As EventArgs) Handles kryptonContextMenuItem1.Click
        nud6.Value = 10D
        nud12.Value = 10D
    End Sub

    Private Sub kryptonContextMenuItem2_Click(sender As Object, e As EventArgs) Handles kryptonContextMenuItem2.Click
        nud6.Value = 20D
        nud12.Value = 20D
    End Sub

    Private Sub kryptonContextMenuItem3_Click(sender As Object, e As EventArgs) Handles kryptonContextMenuItem3.Click
        nud6.Value = 40D
        nud12.Value = 40D
    End Sub

    Private Sub kryptonContextMenuItem4_Click(sender As Object, e As EventArgs) Handles kryptonContextMenuItem4.Click
        nud6.Value = nud6.Minimum
        nud12.Value = nud12.Minimum
    End Sub

    Private Sub kryptonContextMenuItem5_Click(sender As Object, e As EventArgs) Handles kryptonContextMenuItem5.Click
        nud6.Value = nud6.Maximum
        nud12.Value = nud12.Maximum
    End Sub

    Private Sub buttonClose_Click(sender As Object, e As EventArgs) Handles buttonClose.Click
        Close()
    End Sub

End Class

Public Class KryptonNumericUpDownProxy

    Private _numericUpDown As KryptonNumericUpDown

    Public Sub New(numericUpDown As KryptonNumericUpDown)
        _numericUpDown = numericUpDown
    End Sub

    <Category("Visuals")>
    <Description("Determines if the control is always active or only when the mouse is over the control or has focus.")>
    Public Property AlwaysActive As Boolean
        Get
            Return _numericUpDown.AlwaysActive
        End Get
        Set(value As Boolean)
            _numericUpDown.AlwaysActive = value
        End Set
    End Property

    <Category("Appearance")>
    <Description("Indicates how the text should be aligned for edit controls.")>
    Public Property TextAlign As HorizontalAlignment
        Get
            Return _numericUpDown.TextAlign
        End Get
        Set(value As HorizontalAlignment)
            _numericUpDown.TextAlign = value
        End Set
    End Property

    <Category("Behavior")>
    <Description("Controls whether the text in the edit control can be changed or not.")>
    Public Property [ReadOnly] As Boolean
        Get
            Return _numericUpDown.ReadOnly
        End Get
        Set(value As Boolean)
            _numericUpDown.ReadOnly = value
        End Set
    End Property

    <Category("Visuals")>
    <Description("Input control style.")>
    Public Property InputControlStyle As InputControlStyle
        Get
            Return _numericUpDown.InputControlStyle
        End Get
        Set(value As InputControlStyle)
            _numericUpDown.InputControlStyle = value
        End Set
    End Property

    <Category("Visuals")>
    <Description("Should tooltips be displayed for button specs.")>
    Public Property AllowButtonSpecToolTips As Boolean
        Get
            Return _numericUpDown.AllowButtonSpecToolTips
        End Get
        Set(value As Boolean)
            _numericUpDown.AllowButtonSpecToolTips = value
        End Set
    End Property

    <Category("Visuals")>
    <Description("Collection of button specifications.")>
    Public ReadOnly Property ButtonSpecs As KryptonNumericUpDown.NumericUpDownButtonSpecCollection
        Get
            Return _numericUpDown.ButtonSpecs
        End Get
    End Property

    <Category("Visuals")>
    <Description("Overrides for defining common textbox appearance that other states can override.")>
    Public ReadOnly Property StateCommon As PaletteInputControlTripleRedirect
        Get
            Return _numericUpDown.StateCommon
        End Get
    End Property

    <Category("Visuals")>
    <Description("Overrides for defining disabled textbox appearance.")>
    Public ReadOnly Property StateDisabled As PaletteInputControlTripleStates
        Get
            Return _numericUpDown.StateDisabled
        End Get
    End Property

    <Category("Visuals")>
    <Description("Overrides for defining normal textbox appearance.")>
    Public ReadOnly Property StateNormal As PaletteInputControlTripleStates
        Get
            Return _numericUpDown.StateNormal
        End Get
    End Property

    <Category("Visuals")>
    <Description("Overrides for defining active textbox appearance.")>
    Public ReadOnly Property StateActive As PaletteInputControlTripleStates
        Get
            Return _numericUpDown.StateActive
        End Get
    End Property

    <Category("Layout")>
    <Description("The size of the control is pixels.")>
    Public Property Size As Size
        Get
            Return _numericUpDown.Size
        End Get
        Set(value As Size)
            _numericUpDown.Size = value
        End Set
    End Property

    <Category("Layout")>
    <Description("The location of the control in pixels.")>
    Public Property Location As Point
        Get
            Return _numericUpDown.Location
        End Get
        Set(value As Point)
            _numericUpDown.Location = value
        End Set
    End Property

    ''' <summary>
    ''' Gets or sets the number of decimal places to display.
    ''' </summary>
    <Category("Data")>
    <Description("Indicates the number of decimal places to display.")>
    Public Property DecimalPlaces As Integer
        Get
            Return _numericUpDown.DecimalPlaces
        End Get
        Set(value As Integer)
            _numericUpDown.DecimalPlaces = value
        End Set
    End Property

    ''' <summary>
    ''' Gets or sets the amount to increment or decrement one each button click.
    ''' </summary>
    <Category("Data")>
    <Description("Indicates the amount to increment or decrement one each button click.")>
    Public Property Increment As Decimal
        Get
            Return _numericUpDown.Increment
        End Get
        Set(value As Decimal)
            _numericUpDown.Increment = value
        End Set
    End Property

    ''' <summary>
    ''' Gets or sets the maximum value for the numeric up-down control.
    ''' </summary>
    <Category("Data")>
    <Description("Indicates the maximum value for the numeric up-down control.")>
    <RefreshProperties(RefreshProperties.All)>
    Public Property Maximum As Decimal
        Get
            Return _numericUpDown.Maximum
        End Get
        Set(value As Decimal)
            _numericUpDown.Maximum = value
        End Set
    End Property

    ''' <summary>
    ''' Gets or sets the minimum value for the numeric up-down control.
    ''' </summary>
    <Category("Data")>
    <Description("Indicates the minimum value for the numeric up-down control.")>
    <RefreshProperties(RefreshProperties.All)>
    Public Property Minimum As Decimal
        Get
            Return _numericUpDown.Minimum
        End Get
        Set(value As Decimal)
            _numericUpDown.Minimum = value
        End Set
    End Property

    ''' <summary>
    ''' Gets or sets whether the thousands separator wil be inserted between each three decimal digits.
    ''' </summary>
    <Category("Data")>
    <Description("Indicates whether the thousands separator wil be inserted between each three decimal digits.")>
    Public Property ThousandsSeparator As Boolean
        Get
            Return _numericUpDown.ThousandsSeparator
        End Get
        Set(value As Boolean)
            _numericUpDown.ThousandsSeparator = value
        End Set
    End Property

    ''' <summary>
    ''' Gets or sets the current value of the numeric up-down control.
    ''' </summary>
    <Category("Appearance")>
    <Description("The current value of the numeric up-down control.")>
    Public Property Value As Decimal
        Get
            Return _numericUpDown.Value
        End Get
        Set(value As Decimal)
            _numericUpDown.Value = value
        End Set
    End Property

    ''' <summary>
    ''' Gets or sets whether the numeric up-down should display its value in hexadecimal.
    ''' </summary>
    <Category("Appearance")>
    <Description("Indicates wheather the numeric up-down should display its value in hexadecimal.")>
    Public Property Hexadecimal As Boolean
        Get
            Return _numericUpDown.Hexadecimal
        End Get
        Set(value As Boolean)
            _numericUpDown.Hexadecimal = value
        End Set
    End Property

    ''' <summary>
    ''' Gets or sets whether the control accepts decimal values.
    ''' </summary>
    <Category("Behavior")>
    <Description("Indicates whether the control can accept decimal values, rather than integer values only.")>
    Public Property AllowDecimals As Boolean
        Get
            Return _numericUpDown.AllowDecimals
        End Get
        Set(value As Boolean)
            _numericUpDown.AllowDecimals = value
        End Set
    End Property

    ''' <summary>
    ''' Gets or sets whether the control displays trailing zeroes.
    ''' </summary>
    <Category("Behavior")>
    <Description("Indicates whether the control will display traling zeroes.")>
    Public Property TrailingZeroes As Boolean
        Get
            Return _numericUpDown.TrailingZeroes
        End Get
        Set(value As Boolean)
            _numericUpDown.TrailingZeroes = value
        End Set
    End Property

    ''' <summary>
    ''' Gets or sets how the up-down control will position the up down buttons relative to its text box.
    ''' </summary>
    <Category("Appearance")>
    <Description("Indicates how the up-down control will position the up down buttons relative to its text box.")>
    Public Property UpDownAlign As LeftRightAlignment
        Get
            Return _numericUpDown.UpDownAlign
        End Get
        Set(value As LeftRightAlignment)
            _numericUpDown.UpDownAlign = value
        End Set
    End Property

    ''' <summary>
    ''' Gets or sets whether the up-down control will increment and decrement the value when the UP ARROW and DOWN ARROW are used.
    ''' </summary>
    <Category("Behavior")>
    <Description("Indicates whether the up-down control will increment and decrement the value when the UP ARROW and DOWN ARROW are used.")>
    Public Property InterceptArrowKeys As Boolean
        Get
            Return _numericUpDown.InterceptArrowKeys
        End Get
        Set(value As Boolean)
            _numericUpDown.InterceptArrowKeys = value
        End Set
    End Property

    ''' <summary>
    ''' Gets and sets the up and down buttons style.
    ''' </summary>
    <Category("Visuals")>
    <Description("Up and down buttons style.")>
    Public Property UpDownButtonStyle As ButtonStyle
        Get
            Return _numericUpDown.UpDownButtonStyle
        End Get
        Set(value As ButtonStyle)
            _numericUpDown.UpDownButtonStyle = value
        End Set
    End Property

End Class
