#Region "BSD License"
'
' Original BSD 3-Clause License (https://github.com/ComponentFactory/Krypton/blob/master/LICENSE)
'  © Component Factory Pty Ltd, 2006 - 2016, (Version 4.5.0.0) All rights reserved.
'
'  New BSD 3-Clause License (https://github.com/Krypton-Suite/Standard-Toolkit/blob/master/LICENSE)
'  Modifications by Peter Wagner(aka Wagnerp) & Simon Coghlan(aka Smurf-IV), et al. 2017 - 2024. All rights reserved.
'
' VB.NET twin of Source\Krypton Toolkit Examples\KryptonMaskedTextBox Examples\Form1.cs (Bastion Phase 4c).
#End Region

Imports System
Imports System.ComponentModel
Imports System.Drawing
Imports System.Globalization
Imports System.Windows.Forms

Imports Krypton.Toolkit

Public Class Form1

    Public Sub New()
        InitializeComponent()
    End Sub

    Private Sub Form1_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        maskedTextBox1Blue.ValidatingType = GetType(DateTime)
        maskedTextBox3Blue.ValidatingType = GetType(DateTime)
        maskedTextBox4System.ValidatingType = GetType(DateTime)
        maskedTextBox6System.ValidatingType = GetType(DateTime)

        ' Setup the property grid to edit this masked text box
        propertyGrid.SelectedObject = New KryptonMaskedTextBoxProxy(maskedTextBox1Blue)
    End Sub

    Private Sub maskedTextBox1Blue_Enter(sender As Object, e As EventArgs) Handles maskedTextBox9Custom.Enter,
        maskedTextBox8Custom.Enter, maskedTextBox7Custom.Enter, maskedTextBox6System.Enter,
        maskedTextBox5System.Enter, maskedTextBox4System.Enter, maskedTextBox3Blue.Enter,
        maskedTextBox2Blue.Enter, maskedTextBox1Blue.Enter
        ' Setup the property grid to edit this masked text box
        propertyGrid.SelectedObject = New KryptonMaskedTextBoxProxy(CType(sender, KryptonMaskedTextBox))
    End Sub

    Private Sub buttonSpecAny1_Click(sender As Object, e As EventArgs) Handles buttonSpecAny1.Click
        maskedTextBox2Blue.Text = String.Empty
    End Sub

    Private Sub buttonSpecAny3_Click(sender As Object, e As EventArgs) Handles buttonSpecAny3.Click
        maskedTextBox5System.Text = String.Empty
    End Sub

    Private Sub fixedText1_Click(sender As Object, e As EventArgs) Handles kryptonContextMenuItem1.Click
        maskedTextBox9Custom.Text = DateTime.Now.ToShortDateString()
        maskedTextBox9Custom.MaskedTextBox.Focus()
    End Sub

    Private Sub fixedText2_Click(sender As Object, e As EventArgs) Handles kryptonContextMenuItem2.Click
        maskedTextBox9Custom.Text = "01/01/1950"
        maskedTextBox9Custom.MaskedTextBox.Focus()
    End Sub

    Private Sub clear_Click(sender As Object, e As EventArgs) Handles kryptonContextMenuItem3.Click
        maskedTextBox9Custom.Text = String.Empty
        maskedTextBox9Custom.MaskedTextBox.Focus()
    End Sub

    Private Sub buttonClose_Click(sender As Object, e As EventArgs) Handles buttonClose.Click
        Close()
    End Sub

End Class

Public Class KryptonMaskedTextBoxProxy

    Private _maskedTextBox As KryptonMaskedTextBox

    Public Sub New(maskedTextBox As KryptonMaskedTextBox)
        _maskedTextBox = maskedTextBox
    End Sub

    <Category("Appearance")>
    <Description("Text for display inside the control.")>
    Public Property Text As String
        Get
            Return _maskedTextBox.Text
        End Get
        Set(value As String)
            _maskedTextBox.Text = value
        End Set
    End Property

    <Category("Visuals")>
    <Description("Determines if the control is always active or only when the mouse is over the control or has focus.")>
    Public Property AlwaysActive As Boolean
        Get
            Return _maskedTextBox.AlwaysActive
        End Get
        Set(value As Boolean)
            _maskedTextBox.AlwaysActive = value
        End Set
    End Property

    <Category("Appearance")>
    <Description("Indicates how the text should be aligned for edit controls.")>
    Public Property TextAlign As HorizontalAlignment
        Get
            Return _maskedTextBox.TextAlign
        End Get
        Set(value As HorizontalAlignment)
            _maskedTextBox.TextAlign = value
        End Set
    End Property

    <Category("Appearance")>
    <Description("Indicates the character used as the placeholder.")>
    Public Property PromptChar As Char
        Get
            Return _maskedTextBox.PromptChar
        End Get
        Set(value As Char)
            _maskedTextBox.PromptChar = value
        End Set
    End Property

    <Category("Behavior")>
    <Description("Indicates whether the prompt character is valid as input.")>
    Public Property AllowPromptAsInput As Boolean
        Get
            Return _maskedTextBox.AllowPromptAsInput
        End Get
        Set(value As Boolean)
            _maskedTextBox.AllowPromptAsInput = value
        End Set
    End Property

    <Category("Behavior")>
    <Description("Indicates whether only Ascii characters are valid as input.")>
    Public Property AsciiOnly As Boolean
        Get
            Return _maskedTextBox.AsciiOnly
        End Get
        Set(value As Boolean)
            _maskedTextBox.AsciiOnly = value
        End Set
    End Property

    <Category("Behavior")>
    <Description("Indicates whether the control will beep when an invalid character is typed.")>
    Public Property BeepOnError As Boolean
        Get
            Return _maskedTextBox.BeepOnError
        End Get
        Set(value As Boolean)
            _maskedTextBox.BeepOnError = value
        End Set
    End Property

    <Category("Behavior")>
    <Description("The culture that determines the value of the locaizable mask language separators and placeholders.")>
    Public Property Culture As CultureInfo
        Get
            Return _maskedTextBox.Culture
        End Get
        Set(value As CultureInfo)
            _maskedTextBox.Culture = value
        End Set
    End Property

    <Category("Behavior")>
    <Description("Indicates whether the text to be copied to the clipboard includes literals and/or prompt characters.")>
    Public Property CutCopyMaskFormat As MaskFormat
        Get
            Return _maskedTextBox.CutCopyMaskFormat
        End Get
        Set(value As MaskFormat)
            _maskedTextBox.CutCopyMaskFormat = value
        End Set
    End Property

    <Category("Behavior")>
    <Description("Indicates whether prompt characters are displayed when the control does not have focus.")>
    Public Property HidePromptOnLeave As Boolean
        Get
            Return _maskedTextBox.HidePromptOnLeave
        End Get
        Set(value As Boolean)
            _maskedTextBox.HidePromptOnLeave = value
        End Set
    End Property

    <Category("Behavior")>
    <Description("Indicates the masked text box input character typing mode.")>
    Public Property InsertKeyMode As InsertKeyMode
        Get
            Return _maskedTextBox.InsertKeyMode
        End Get
        Set(value As InsertKeyMode)
            _maskedTextBox.InsertKeyMode = value
        End Set
    End Property

    <Category("Behavior")>
    <Description("Sets the string governing the input allowed for the control.")>
    Public Property Mask As String
        Get
            Return _maskedTextBox.Mask
        End Get
        Set(value As String)
            _maskedTextBox.Mask = value
        End Set
    End Property

    <Category("Behavior")>
    <Description("Indicates that the selection should be hidden when the edit control loses focus.")>
    Public Property HideSelection As Boolean
        Get
            Return _maskedTextBox.HideSelection
        End Get
        Set(value As Boolean)
            _maskedTextBox.HideSelection = value
        End Set
    End Property

    <Category("Behavior")>
    <Description("Controls whether the text in the edit control can be changed or not.")>
    Public Property [ReadOnly] As Boolean
        Get
            Return _maskedTextBox.ReadOnly
        End Get
        Set(value As Boolean)
            _maskedTextBox.ReadOnly = value
        End Set
    End Property

    <Category("Behavior")>
    <Description("If true, the input is rejected whenever a character fails to comply with the mask; otherwise, characters in the text area are processed one by one as individual inputs.")>
    Public Property RejectInputOnFirstFailure As Boolean
        Get
            Return _maskedTextBox.RejectInputOnFirstFailure
        End Get
        Set(value As Boolean)
            _maskedTextBox.RejectInputOnFirstFailure = value
        End Set
    End Property

    <Category("Behavior")>
    <Description("Specifies whether to reset and skip the current position if editable, when the input characters has the same value as the prompt.")>
    Public Property ResetOnPrompt As Boolean
        Get
            Return _maskedTextBox.ResetOnPrompt
        End Get
        Set(value As Boolean)
            _maskedTextBox.ResetOnPrompt = value
        End Set
    End Property

    <Category("Behavior")>
    <Description("Specifies whether to reset and skip the current position if editable, when the input is the space character.")>
    Public Property ResetOnSpace As Boolean
        Get
            Return _maskedTextBox.ResetOnSpace
        End Get
        Set(value As Boolean)
            _maskedTextBox.ResetOnSpace = value
        End Set
    End Property

    <Category("Behavior")>
    <Description("Specifies whether to skip the current position if non-editable and the input character has the same value as the literal at that position.")>
    Public Property SkipLiterals As Boolean
        Get
            Return _maskedTextBox.SkipLiterals
        End Get
        Set(value As Boolean)
            _maskedTextBox.SkipLiterals = value
        End Set
    End Property

    <Category("Behavior")>
    <Description("Indicates whether the string returned from the Text property includes literal and/or prompt characters.")>
    Public Property TextMaskFormat As MaskFormat
        Get
            Return _maskedTextBox.TextMaskFormat
        End Get
        Set(value As MaskFormat)
            _maskedTextBox.TextMaskFormat = value
        End Set
    End Property

    <Category("Behavior")>
    <Description("Indicates whether shortcuts defined for the control are enabled.")>
    Public Property ShortcutsEnabled As Boolean
        Get
            Return _maskedTextBox.ShortcutsEnabled
        End Get
        Set(value As Boolean)
            _maskedTextBox.ShortcutsEnabled = value
        End Set
    End Property

    <Category("Behavior")>
    <Description("Indicates the character to display for password input for single-line edit controls.")>
    Public Property PasswordChar As Char
        Get
            Return _maskedTextBox.PasswordChar
        End Get
        Set(value As Char)
            _maskedTextBox.PasswordChar = value
        End Set
    End Property

    <Category("Behavior")>
    <Description("Indicates if the text in the edit control should appear as the default password character.")>
    Public Property UseSystemPasswordChar As Boolean
        Get
            Return _maskedTextBox.UseSystemPasswordChar
        End Get
        Set(value As Boolean)
            _maskedTextBox.UseSystemPasswordChar = value
        End Set
    End Property

    <Category("Visuals")>
    <Description("Input control style.")>
    Public Property InputControlStyle As InputControlStyle
        Get
            Return _maskedTextBox.InputControlStyle
        End Get
        Set(value As InputControlStyle)
            _maskedTextBox.InputControlStyle = value
        End Set
    End Property

    <Category("Visuals")>
    <Description("Should tooltips be displayed for button specs.")>
    Public Property AllowButtonSpecToolTips As Boolean
        Get
            Return _maskedTextBox.AllowButtonSpecToolTips
        End Get
        Set(value As Boolean)
            _maskedTextBox.AllowButtonSpecToolTips = value
        End Set
    End Property

    <Category("Visuals")>
    <Description("Collection of button specifications.")>
    Public ReadOnly Property ButtonSpecs As KryptonMaskedTextBox.MaskedTextBoxButtonSpecCollection
        Get
            Return _maskedTextBox.ButtonSpecs
        End Get
    End Property

    <Category("Visuals")>
    <Description("Overrides for defining common textbox appearance that other states can override.")>
    Public ReadOnly Property StateCommon As PaletteInputControlTripleRedirect
        Get
            Return _maskedTextBox.StateCommon
        End Get
    End Property

    <Category("Visuals")>
    <Description("Overrides for defining disabled textbox appearance.")>
    Public ReadOnly Property StateDisabled As PaletteInputControlTripleStates
        Get
            Return _maskedTextBox.StateDisabled
        End Get
    End Property

    <Category("Visuals")>
    <Description("Overrides for defining normal textbox appearance.")>
    Public ReadOnly Property StateNormal As PaletteInputControlTripleStates
        Get
            Return _maskedTextBox.StateNormal
        End Get
    End Property

    <Category("Visuals")>
    <Description("Overrides for defining active textbox appearance.")>
    Public ReadOnly Property StateActive As PaletteInputControlTripleStates
        Get
            Return _maskedTextBox.StateActive
        End Get
    End Property

    <Category("Layout")>
    <Description("The size of the control is pixels.")>
    Public Property Size As Size
        Get
            Return _maskedTextBox.Size
        End Get
        Set(value As Size)
            _maskedTextBox.Size = value
        End Set
    End Property

    <Category("Layout")>
    <Description("The location of the control in pixels.")>
    Public Property Location As Point
        Get
            Return _maskedTextBox.Location
        End Get
        Set(value As Point)
            _maskedTextBox.Location = value
        End Set
    End Property

End Class
