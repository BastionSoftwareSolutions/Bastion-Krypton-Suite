' Original BSD 3-Clause License (https://github.com/ComponentFactory/Krypton/blob/master/LICENSE)
'  © Component Factory Pty Ltd, 2006 - 2016, (Version 4.5.0.0) All rights reserved.
'
'  New BSD 3-Clause License (https://github.com/Krypton-Suite/Standard-Toolkit/blob/master/LICENSE)
'  Modifications by Peter Wagner(aka Wagnerp) & Simon Coghlan(aka Smurf-IV), tobitege et al. 2017 - 2025. All rights reserved.
'
' VB.NET twin of Source\Krypton Toolkit Examples\KryptonDateTimePicker Examples\Form1.cs (Bastion Phase 4c).

Imports System.ComponentModel
Imports System.Drawing
Imports System.Windows.Forms

Imports Krypton.Toolkit

Public Class Form1

    Public Sub New()
        InitializeComponent()
        Dim unused = dtpNormalLong.ViewManager
    End Sub

    Private Sub Form1_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        ' Setup the property grid to edit this date time picker control
        propertyGrid.SelectedObject = New KryptonDateTimePickerProxy(dtpNormalLong)
    End Sub

    Private Sub dtp_Enter(sender As Object, e As EventArgs) Handles _
        dtpNormalLong.Enter, dtpNormalShort.Enter, dtpNormalTime.Enter,
        dtpRibbonLong.Enter, dtpRibbonShort.Enter, dtpRibbonTime.Enter
        ' Setup the property grid to edit this date time picker control
        propertyGrid.SelectedObject = New KryptonDateTimePickerProxy(CType(sender, KryptonDateTimePicker))
    End Sub

    Private Sub rbOffice2010Blue_CheckedChanged(sender As Object, e As EventArgs) Handles rbOffice2010Blue.CheckedChanged
        kryptonPalette.BaseRenderMode = RendererMode.Microsoft365
    End Sub

    Private Sub rbOffice2010Silver_CheckedChanged(sender As Object, e As EventArgs) Handles rbOffice2010Silver.CheckedChanged
        kryptonPalette.BaseRenderMode = RendererMode.Office2010
    End Sub

    Private Sub rbOffice2010Black_CheckedChanged(sender As Object, e As EventArgs) Handles rbOffice2010Black.CheckedChanged
        kryptonPalette.BaseRenderMode = RendererMode.Office2010
    End Sub

    Private Sub rbOffice2007Blue_CheckedChanged(sender As Object, e As EventArgs) Handles rbOffice2007Blue.CheckedChanged
        kryptonPalette.BaseRenderMode = RendererMode.Office2007
    End Sub

    Private Sub rbOffice2007Silver_CheckedChanged(sender As Object, e As EventArgs) Handles rbOffice2007Silver.CheckedChanged
        kryptonPalette.BaseRenderMode = RendererMode.Office2007
    End Sub

    Private Sub rbOffice2007Black_CheckedChanged(sender As Object, e As EventArgs) Handles rbOffice2007Black.CheckedChanged
        kryptonPalette.BaseRenderMode = RendererMode.Office2007
    End Sub

    Private Sub rbSparkleBlue_CheckedChanged(sender As Object, e As EventArgs) Handles rbSparkleBlue.CheckedChanged
        kryptonPalette.BaseRenderMode = RendererMode.Sparkle
    End Sub

    Private Sub rbSparkleOrange_CheckedChanged(sender As Object, e As EventArgs) Handles rbSparkleOrange.CheckedChanged
        kryptonPalette.BaseRenderMode = RendererMode.Sparkle
    End Sub

    Private Sub rbSparklePurple_CheckedChanged(sender As Object, e As EventArgs) Handles rbSparklePurple.CheckedChanged
        kryptonPalette.BaseRenderMode = RendererMode.Sparkle
    End Sub

    Private Sub rbOffice2003_CheckedChanged(sender As Object, e As EventArgs) Handles rbOffice2003.CheckedChanged
        kryptonPalette.BaseRenderMode = RendererMode.Office2007
    End Sub

    Private Sub rbSystem_CheckedChanged(sender As Object, e As EventArgs) Handles rbSystem.CheckedChanged
        kryptonPalette.BaseRenderMode = RendererMode.Professional
    End Sub

    Private Sub buttonSpecAny1_Click(sender As Object, e As EventArgs) Handles buttonSpecAny1.Click
        dtpNormalTime.Value = DateTime.Now
    End Sub

    Private Sub buttonSpecAny2_Click(sender As Object, e As EventArgs) Handles buttonSpecAny2.Click
        dtpRibbonTime.Value = DateTime.Now
    End Sub

    Private Sub buttonClose_Click(sender As Object, e As EventArgs) Handles buttonClose.Click
        Close()
    End Sub

End Class

Public Class KryptonDateTimePickerProxy

    Private _dateTimePicker As KryptonDateTimePicker

    Public Sub New(dateTimePicker As KryptonDateTimePicker)
        _dateTimePicker = dateTimePicker
    End Sub

    <Category("Layout")>
    <Description("The size of the control is pixels.")>
    Public Property Size() As Size
        Get
            Return _dateTimePicker.Size
        End Get
        Set(value As Size)
            _dateTimePicker.Size = value
        End Set
    End Property

    <Category("Layout")>
    <Description("The location of the control in pixels.")>
    Public Property Location() As Point
        Get
            Return _dateTimePicker.Location
        End Get
        Set(value As Point)
            _dateTimePicker.Location = value
        End Set
    End Property

    ''' <summary>
    ''' Gets or sets the number of columns and rows of months displayed.
    ''' </summary>
    <Category("Visuals - MonthCalendar")>
    <Description("Specifies the number of rows and columns of months displayed.")>
    Public Property CalendarDimensions() As Size
        Get
            Return _dateTimePicker.CalendarDimensions
        End Get
        Set(value As Size)
            _dateTimePicker.CalendarDimensions = value
        End Set
    End Property

    ''' <summary>
    ''' Gets or sets the label text for todays text.
    ''' </summary>
    <Category("Visuals - MonthCalendar")>
    <Description("Text used as label for todays date.")>
    Public Property CalendarTodayText() As String
        Get
            Return _dateTimePicker.CalendarTodayText
        End Get
        Set(value As String)
            _dateTimePicker.CalendarTodayText = value
        End Set
    End Property

    ''' <summary>
    ''' First day of the week.
    ''' </summary>
    <Category("Visuals - MonthCalendar")>
    <Description("First day of the week.")>
    Public Property CalendarFirstDayOfWeek() As Day
        Get
            Return _dateTimePicker.CalendarFirstDayOfWeek
        End Get
        Set(value As Day)
            _dateTimePicker.CalendarFirstDayOfWeek = value
        End Set
    End Property

    ''' <summary>
    ''' Gets and sets if the control will display todays date.
    ''' </summary>
    <Category("Visuals - MonthCalendar")>
    <Description("Indicates whether this month calendar will display todays date.")>
    Public Property CalendarShowToday() As Boolean
        Get
            Return _dateTimePicker.CalendarShowToday
        End Get
        Set(value As Boolean)
            _dateTimePicker.CalendarShowToday = value
        End Set
    End Property

    ''' <summary>
    ''' Gets and sets if the control will circle the today date.
    ''' </summary>
    <Category("Visuals - MonthCalendar")>
    <Description("Indicates whether this month calendar will circle the today date.")>
    Public Property CalendarShowTodayCircle() As Boolean
        Get
            Return _dateTimePicker.CalendarShowTodayCircle
        End Get
        Set(value As Boolean)
            _dateTimePicker.CalendarShowTodayCircle = value
        End Set
    End Property

    ''' <summary>
    ''' Gets and sets if week numbers to the left of each row.
    ''' </summary>
    <Category("Visuals - MonthCalendar")>
    <Description("Indicates whether this month calendar will display week numbers to the left of each row.")>
    Public Property CalendarShowWeekNumbers() As Boolean
        Get
            Return _dateTimePicker.CalendarShowWeekNumbers
        End Get
        Set(value As Boolean)
            _dateTimePicker.CalendarShowWeekNumbers = value
        End Set
    End Property

    ''' <summary>
    ''' Gets or sets today's display format.
    ''' </summary>
    <Category("Visuals - MonthCalendar")>
    <Description("Today's display format.")>
    Public Property CalendarTodayFormat() As String
        Get
            Return _dateTimePicker.CalendarTodayFormat
        End Get
        Set(value As String)
            _dateTimePicker.CalendarTodayFormat = value
        End Set
    End Property

    ''' <summary>
    ''' Gets or sets today's date.
    ''' </summary>
    <Category("Visuals - MonthCalendar")>
    <Description("Today's date.")>
    Public Property CalendarTodayDate() As DateTime?
        Get
            Return _dateTimePicker.CalendarTodayDate
        End Get
        Set(value As DateTime?)
            _dateTimePicker.CalendarTodayDate = CType(value, DateTime)
        End Set
    End Property

    ''' <summary>
    ''' Gets or sets the array of DateTime objects that determines which annual days are displayed in bold.
    ''' </summary>
    <Category("Visuals - MonthCalendar")>
    <Description("Indicates which annual dates should be boldface.")>
    Public Property CalendarAnnuallyBoldedDates() As DateTime()
        Get
            Return _dateTimePicker.CalendarAnnuallyBoldedDates
        End Get
        Set(value As DateTime())
            _dateTimePicker.CalendarAnnuallyBoldedDates = value
        End Set
    End Property

    ''' <summary>
    ''' Gets or sets the array of DateTime objects that determine which monthly days to bold.
    ''' </summary>
    <Category("Visuals - MonthCalendar")>
    <Description("Indicates which monthly dates should be boldface.")>
    Public Property CalendarMonthlyBoldedDates() As DateTime()
        Get
            Return _dateTimePicker.CalendarMonthlyBoldedDates
        End Get
        Set(value As DateTime())
            _dateTimePicker.CalendarMonthlyBoldedDates = value
        End Set
    End Property

    ''' <summary>
    ''' Gets or sets the array of DateTime objects that determines which nonrecurring dates are displayed in bold.
    ''' </summary>
    <Category("Visuals - MonthCalendar")>
    <Description("Indicates which dates should be boldface.")>
    Public Property CalendarBoldedDates() As DateTime()
        Get
            Return _dateTimePicker.CalendarBoldedDates
        End Get
        Set(value As DateTime())
            _dateTimePicker.CalendarBoldedDates = value
        End Set
    End Property

    ''' <summary>
    ''' Gets or sets the alignment of the drop-down calendar on the DateTimePicker control.
    ''' </summary>
    <Category("Appearance")>
    <Description("Alignment of the drop-down calendar on the KryptonDateTimePicker control.")>
    Public Property DropDownAlign() As LeftRightAlignment
        Get
            Return _dateTimePicker.DropDownAlign
        End Get
        Set(value As LeftRightAlignment)
            _dateTimePicker.DropDownAlign = value
        End Set
    End Property

    ''' <summary>
    ''' Gets or sets the date/time value assigned to the control that can be null.
    ''' </summary>
    <Category("Appearance")>
    <Description("Property for the date/time that can be null.")>
    <RefreshProperties(RefreshProperties.All)>
    Public Property ValueNullable() As Object
        Get
            Return _dateTimePicker.ValueNullable
        End Get
        Set(value As Object)
            _dateTimePicker.ValueNullable = value
        End Set
    End Property

    ''' <summary>
    ''' Gets or sets the date/time value assigned to the control.
    ''' </summary>
    <Category("Appearance")>
    <Description("Property for the date/time.")>
    <RefreshProperties(RefreshProperties.All)>
    Public Property Value() As DateTime
        Get
            Return _dateTimePicker.Value
        End Get
        Set(value As DateTime)
            _dateTimePicker.Value = value
        End Set
    End Property

    ''' <summary>
    ''' Gets or sets the format of the date and time displayed in the control.
    ''' </summary>
    <Category("Appearance")>
    <Description("Determines whether dates and times are displayed using standard or custom formatting.")>
    <RefreshProperties(RefreshProperties.Repaint)>
    Public Property Format() As DateTimePickerFormat
        Get
            Return _dateTimePicker.Format
        End Get
        Set(value As DateTimePickerFormat)
            _dateTimePicker.Format = value
        End Set
    End Property

    ''' <summary>
    ''' Gets or sets a value indicating whether a spin button control (also known as an up-down control) is used to adjust the date/time value.
    ''' </summary>
    <Category("Appearance")>
    <Description("Indicates whether a spin box rather than a drop-down calendar is displayed for modifying the control value.")>
    <DefaultValue(False)>
    Public Property ShowUpDown() As Boolean
        Get
            Return _dateTimePicker.ShowUpDown
        End Get
        Set(value As Boolean)
            _dateTimePicker.ShowUpDown = value
        End Set
    End Property

    ''' <summary>
    ''' Specifies whether to show the check box in the exception message box.
    ''' </summary>
    <Category("Appearance")>
    <Description("Determines whether a check box is displayed in the control. When the box is unchecked, no value is selected.")>
    <DefaultValue(False)>
    Public Property ShowCheckBox() As Boolean
        Get
            Return _dateTimePicker.ShowCheckBox
        End Get
        Set(value As Boolean)
            _dateTimePicker.ShowCheckBox = value
        End Set
    End Property

    ''' <summary>
    ''' Gets or sets a value indicating whether mnemonics will fire button spec buttons.
    ''' </summary>
    <Category("Appearance")>
    <Description("Defines if mnemonic characters generate click events for button specs.")>
    <DefaultValue(True)>
    Public Property UseMnemonic() As Boolean
        Get
            Return _dateTimePicker.UseMnemonic
        End Get
        Set(value As Boolean)
            _dateTimePicker.UseMnemonic = value
        End Set
    End Property

    ''' <summary>
    ''' Gets or sets the maximum date and time that can be selected in the control.
    ''' </summary>
    <Category("Behavior")>
    <Description("Maximum allowable date.")>
    Public Property MaxDate() As DateTime
        Get
            Return _dateTimePicker.MaxDate
        End Get
        Set(value As DateTime)
            _dateTimePicker.MaxDate = value
        End Set
    End Property

    ''' <summary>
    ''' Gets or sets the minimum date and time that can be selected in the control.
    ''' </summary>
    <Category("Behavior")>
    <Description("Minimum allowable date.")>
    Public Property MinDate() As DateTime
        Get
            Return _dateTimePicker.MinDate
        End Get
        Set(value As DateTime)
            _dateTimePicker.MinDate = value
        End Set
    End Property

    ''' <summary>
    ''' Gets or sets a value indicating if the check box is checked and if the ValueNullable is DBNull or a DateTime value.
    ''' </summary>
    <Category("Behavior")>
    <Description("Determines if the check box is checked and if the ValueNullable is DBNull or a DateTime value.")>
    <RefreshProperties(RefreshProperties.All)>
    <DefaultValue(True)>
    Public Property Checked() As Boolean
        Get
            Return _dateTimePicker.Checked
        End Get
        Set(value As Boolean)
            _dateTimePicker.Checked = value
        End Set
    End Property

    ''' <summary>
    ''' Gets or sets the custom date/time format string.
    ''' </summary>
    <Category("Behavior")>
    <Description("The custom format string used to format the date and/or time displayed in the control.")>
    <DefaultValue("")>
    <RefreshProperties(RefreshProperties.Repaint)>
    Public Property CustomFormat() As String
        Get
            Return If(_dateTimePicker.CustomFormat, String.Empty)
        End Get
        Set(value As String)
            _dateTimePicker.CustomFormat = value
        End Set
    End Property

    ''' <summary>
    ''' Gets or sets the custom text used when the checked property is cleared.
    ''' </summary>
    <Category("Behavior")>
    <Description("The custom text used when the checked property is cleared.")>
    <DefaultValue("")>
    <RefreshProperties(RefreshProperties.Repaint)>
    Public Property CustomNullText() As String
        Get
            Return _dateTimePicker.CustomNullText
        End Get
        Set(value As String)
            _dateTimePicker.CustomNullText = value
        End Set
    End Property

    ''' <summary>
    ''' Gets and sets the header style for the month calendar.
    ''' </summary>
    <Category("Visuals - MonthCalendar")>
    <Description("Header style for the month calendar.")>
    Public Property CalendarHeaderStyle() As HeaderStyle
        Get
            Return _dateTimePicker.CalendarHeaderStyle
        End Get
        Set(value As HeaderStyle)
            _dateTimePicker.CalendarHeaderStyle = value
        End Set
    End Property

    ''' <summary>
    ''' Gets and sets the content style for the day entries.
    ''' </summary>
    <Category("Visuals - MonthCalendar")>
    <Description("Content style for the day entries.")>
    Public Property CalendarDayStyle() As ButtonStyle
        Get
            Return _dateTimePicker.CalendarDayStyle
        End Get
        Set(value As ButtonStyle)
            _dateTimePicker.CalendarDayStyle = value
        End Set
    End Property

    ''' <summary>
    ''' Gets and sets the content style for the day of week labels.
    ''' </summary>
    <Category("Visuals - MonthCalendar")>
    <Description("Content style for the day of week labels.")>
    Public Property CalendarDayOfWeekStyle() As ButtonStyle
        Get
            Return _dateTimePicker.CalendarDayOfWeekStyle
        End Get
        Set(value As ButtonStyle)
            _dateTimePicker.CalendarDayOfWeekStyle = value
        End Set
    End Property

    ''' <summary>
    ''' Gets or sets the palette to be applied.
    ''' </summary>
    <Category("Visuals - DateTimePicker")>
    <Description("Palette applied to drawing.")>
    <DefaultValue(PaletteMode.Global)>
    Public Property PaletteMode() As PaletteMode
        Get
            Return _dateTimePicker.PaletteMode
        End Get
        Set(value As PaletteMode)
            _dateTimePicker.PaletteMode = value
        End Set
    End Property

    ''' <summary>
    ''' Gets and sets the custom palette implementation.
    ''' </summary>
    <Category("Visuals - DateTimePicker")>
    <Description("Custom palette applied to drawing.")>
    <DefaultValue(CType(Nothing, Object))>
    Public Property Palette() As KryptonCustomPaletteBase
        Get
            Return _dateTimePicker.LocalCustomPalette
        End Get
        Set(value As KryptonCustomPaletteBase)
            _dateTimePicker.LocalCustomPalette = value
        End Set
    End Property

    ''' <summary>
    ''' Gets and sets Determines if the control is always active or only when the mouse is over the control or has focus.
    ''' </summary>
    <Category("Visuals - DateTimePicker")>
    <Description("Determines if the control is always active or only when the mouse is over the control or has focus.")>
    <DefaultValue(True)>
    Public Property AlwaysActive() As Boolean
        Get
            Return _dateTimePicker.AlwaysActive
        End Get
        Set(value As Boolean)
            _dateTimePicker.AlwaysActive = value
        End Set
    End Property

    ''' <summary>
    ''' Gets access to the checkbox value overrides.
    ''' </summary>
    <Category("Visuals - DateTimePicker")>
    <Description("CheckBox image overrides.")>
    <DesignerSerializationVisibility(DesignerSerializationVisibility.Content)>
    Public ReadOnly Property Images() As CheckBoxImages
        Get
            Return _dateTimePicker.Images
        End Get
    End Property

    ''' <summary>
    ''' Gets and sets the input control style.
    ''' </summary>
    <Category("Visuals - DateTimePicker")>
    <Description("Input control style.")>
    Public Property InputControlStyle() As InputControlStyle
        Get
            Return _dateTimePicker.InputControlStyle
        End Get
        Set(value As InputControlStyle)
            _dateTimePicker.InputControlStyle = value
        End Set
    End Property

    ''' <summary>
    ''' Gets and sets the up and down buttons style.
    ''' </summary>
    <Category("Visuals - DateTimePicker")>
    <Description("Up and down buttons style.")>
    Public Property UpDownButtonStyle() As ButtonStyle
        Get
            Return _dateTimePicker.UpDownButtonStyle
        End Get
        Set(value As ButtonStyle)
            _dateTimePicker.UpDownButtonStyle = value
        End Set
    End Property

    ''' <summary>
    ''' Gets and sets the drop button style.
    ''' </summary>
    <Category("Visuals - DateTimePicker")>
    <Description("DropButton style.")>
    Public Property DropButtonStyle() As ButtonStyle
        Get
            Return _dateTimePicker.DropButtonStyle
        End Get
        Set(value As ButtonStyle)
            _dateTimePicker.DropButtonStyle = value
        End Set
    End Property

    ''' <summary>
    ''' Gets the collection of button specifications.
    ''' </summary>
    <Category("Visuals - DateTimePicker")>
    <Description("Collection of button specifications.")>
    Public ReadOnly Property ButtonSpecs() As KryptonDateTimePicker.DateTimePickerButtonSpecCollection
        Get
            Return _dateTimePicker.ButtonSpecs
        End Get
    End Property

    ''' <summary>
    ''' Gets and sets a value indicating if tooltips should be displayed for button specs.
    ''' </summary>
    <Category("Visuals - DateTimePicker")>
    <Description("Should tooltips be displayed for button specs.")>
    <DefaultValue(False)>
    Public Property AllowButtonSpecToolTips() As Boolean
        Get
            Return _dateTimePicker.AllowButtonSpecToolTips
        End Get
        Set(value As Boolean)
            _dateTimePicker.AllowButtonSpecToolTips = value
        End Set
    End Property

    ''' <summary>
    ''' Gets access to the common date time picker appearance entries that other states can override.
    ''' </summary>
    <Category("Visuals - DateTimePicker")>
    <Description("Overrides for defining common date time picker appearance that other states can override.")>
    Public ReadOnly Property StateCommon() As PaletteInputControlTripleRedirect
        Get
            Return _dateTimePicker.StateCommon
        End Get
    End Property

    ''' <summary>
    ''' Gets access to the disabled date time picker appearance entries.
    ''' </summary>
    <Category("Visuals - DateTimePicker")>
    <Description("Overrides for defining disabled date time picker appearance.")>
    Public ReadOnly Property StateDisabled() As PaletteInputControlTripleStates
        Get
            Return _dateTimePicker.StateDisabled
        End Get
    End Property

    ''' <summary>
    ''' Gets access to the normal date time picker appearance entries.
    ''' </summary>
    <Category("Visuals - DateTimePicker")>
    <Description("Overrides for defining normal date time picker appearance.")>
    Public ReadOnly Property StateNormal() As PaletteInputControlTripleStates
        Get
            Return _dateTimePicker.StateNormal
        End Get
    End Property

    ''' <summary>
    ''' Gets access to the active date time picker appearance entries.
    ''' </summary>
    <Category("Visuals - DateTimePicker")>
    <Description("Overrides for defining active date time picker appearance.")>
    Public ReadOnly Property StateActive() As PaletteInputControlTripleStates
        Get
            Return _dateTimePicker.StateActive
        End Get
    End Property

End Class
