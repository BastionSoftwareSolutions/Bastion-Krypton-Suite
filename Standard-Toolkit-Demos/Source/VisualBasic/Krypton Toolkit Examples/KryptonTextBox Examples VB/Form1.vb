#Region "BSD License"
'
' Original BSD 3-Clause License (https://github.com/ComponentFactory/Krypton/blob/master/LICENSE)
'  © Component Factory Pty Ltd, 2006 - 2016, (Version 4.5.0.0) All rights reserved.
'
'  New BSD 3-Clause License (https://github.com/Krypton-Suite/Standard-Toolkit/blob/master/LICENSE)
'  Modifications by Peter Wagner(aka Wagnerp) & Simon Coghlan(aka Smurf-IV), et al. 2017 - 2024. All rights reserved.
'
' VB.NET twin of Source\Krypton Toolkit Examples\KryptonTextBox Examples\Form1.cs (Bastion Phase 4c).
#End Region

Imports System
Imports System.ComponentModel
Imports System.Drawing
Imports System.Windows.Forms

Imports Krypton.Toolkit

Public Class Form1

    Private Sub Form1_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        ' Setup the property grid to edit this text box
        propertyGrid.SelectedObject = New KryptonTextBoxProxy(kryptonTextBox1Blue)
    End Sub

    Private Sub kryptonTextBox1Blue_Enter(sender As Object, e As EventArgs) Handles _
        kryptonTextBox1Blue.Enter, kryptonTextBox2Blue.Enter, kryptonTextBox3Blue.Enter,
        kryptonTextBox4System.Enter, kryptonTextBox5System.Enter, kryptonTextBox6System.Enter,
        kryptonTextBox7Custom.Enter, kryptonTextBox8Custom.Enter, kryptonTextBox9Custom.Enter

        ' Setup the property grid to edit this text box
        propertyGrid.SelectedObject = New KryptonTextBoxProxy(DirectCast(sender, KryptonTextBox))
    End Sub

    Private Sub buttonSpecAny1_Click(sender As Object, e As EventArgs) Handles buttonSpecAny1.Click
        kryptonTextBox2Blue.Text = String.Empty
    End Sub

    Private Sub buttonSpecAny3_Click(sender As Object, e As EventArgs) Handles buttonSpecAny3.Click
        kryptonTextBox5System.Text = String.Empty
    End Sub

    Private Sub fixedText1_Click(sender As Object, e As EventArgs) Handles kryptonContextMenuItem1.Click
        kryptonTextBox9Custom.Text = "Fixed Text 1"
        kryptonTextBox9Custom.TextBox.Focus()
    End Sub

    Private Sub fixedText2_Click(sender As Object, e As EventArgs) Handles kryptonContextMenuItem2.Click
        kryptonTextBox9Custom.Text = "Fixed Text 2"
        kryptonTextBox9Custom.TextBox.Focus()
    End Sub

    Private Sub clear_Click(sender As Object, e As EventArgs) Handles kryptonContextMenuItem3.Click
        kryptonTextBox9Custom.Text = String.Empty
        kryptonTextBox9Custom.TextBox.Focus()
    End Sub

    Private Sub buttonClose_Click(sender As Object, e As EventArgs) Handles buttonClose.Click
        Close()
    End Sub

End Class

Public Class KryptonTextBoxProxy

    Private _textBox As KryptonTextBox

    Public Sub New(textBox As KryptonTextBox)
        _textBox = textBox
    End Sub

    <Category("Appearance")>
    <Description("Text for display inside the control.")>
    Public Property Text As String
        Get
            Return _textBox.Text
        End Get
        Set(value As String)
            _textBox.Text = value
        End Set
    End Property

    <Category("Visuals")>
    <Description("Determines if the control is always active or only when the mouse is over the control or has focus.")>
    Public Property AlwaysActive As Boolean
        Get
            Return _textBox.AlwaysActive
        End Get
        Set(value As Boolean)
            _textBox.AlwaysActive = value
        End Set
    End Property

    <Category("Appearance")>
    <Description("Indicates, for multiline edit controls, which scroll bars will be shown for this control.")>
    Public Property ScrollBars As ScrollBars
        Get
            Return _textBox.ScrollBars
        End Get
        Set(value As ScrollBars)
            _textBox.ScrollBars = value
        End Set
    End Property

    <Category("Appearance")>
    <Description("Indicates how the text should be aligned for edit controls.")>
    Public Property TextAlign As HorizontalAlignment
        Get
            Return _textBox.TextAlign
        End Get
        Set(value As HorizontalAlignment)
            _textBox.TextAlign = value
        End Set
    End Property

    <Category("Behavior")>
    <Description("Indicates if lines are automatically word-wrapped for multiline edit controls.")>
    Public Property WordWrap As Boolean
        Get
            Return _textBox.WordWrap
        End Get
        Set(value As Boolean)
            _textBox.WordWrap = value
        End Set
    End Property

    <Category("Behavior")>
    <Description("Control whether the text in the control can span more than one line.")>
    Public Property Multiline As Boolean
        Get
            Return _textBox.Multiline
        End Get
        Set(value As Boolean)
            _textBox.Multiline = value
        End Set
    End Property

    <Category("Behavior")>
    <Description("Indicates if return characters are accepted as input for multiline edit controls.")>
    Public Property AcceptsReturn As Boolean
        Get
            Return _textBox.AcceptsReturn
        End Get
        Set(value As Boolean)
            _textBox.AcceptsReturn = value
        End Set
    End Property

    <Category("Behavior")>
    <Description("Indicates if tab characters are accepted as input for multiline edit controls.")>
    Public Property AcceptsTab As Boolean
        Get
            Return _textBox.AcceptsTab
        End Get
        Set(value As Boolean)
            _textBox.AcceptsTab = value
        End Set
    End Property

    <Category("Behavior")>
    <Description("Indicates if all the characters should be left alone or converted to uppercase or lowercase.")>
    Public Property CharacterCasing As CharacterCasing
        Get
            Return _textBox.CharacterCasing
        End Get
        Set(value As CharacterCasing)
            _textBox.CharacterCasing = value
        End Set
    End Property

    <Category("Behavior")>
    <Description("Indicates that the selection should be hidden when the edit control loses focus.")>
    Public Property HideSelection As Boolean
        Get
            Return _textBox.HideSelection
        End Get
        Set(value As Boolean)
            _textBox.HideSelection = value
        End Set
    End Property

    <Category("Behavior")>
    <Description("Specifies the maximum number of characters that can be entered into the edit control.")>
    Public Property MaxLength As Integer
        Get
            Return _textBox.MaxLength
        End Get
        Set(value As Integer)
            _textBox.MaxLength = value
        End Set
    End Property

    <Category("Behavior")>
    <Description("Controls whether the text in the edit control can be changed or not.")>
    Public Property [ReadOnly] As Boolean
        Get
            Return _textBox.ReadOnly
        End Get
        Set(value As Boolean)
            _textBox.ReadOnly = value
        End Set
    End Property

    <Category("Behavior")>
    <Description("Indicates the character to display for password input for single-line edit controls.")>
    Public Property PasswordChar As Char
        Get
            Return _textBox.PasswordChar
        End Get
        Set(value As Char)
            _textBox.PasswordChar = value
        End Set
    End Property

    <Category("Behavior")>
    <Description("Indicates if the text in the edit control should appear as the default password character.")>
    Public Property UseSystemPasswordChar As Boolean
        Get
            Return _textBox.UseSystemPasswordChar
        End Get
        Set(value As Boolean)
            _textBox.UseSystemPasswordChar = value
        End Set
    End Property

    <Category("Visuals")>
    <Description("Input control style.")>
    Public Property InputControlStyle As InputControlStyle
        Get
            Return _textBox.InputControlStyle
        End Get
        Set(value As InputControlStyle)
            _textBox.InputControlStyle = value
        End Set
    End Property

    <Category("Visuals")>
    <Description("Should tooltips be displayed for button specs.")>
    Public Property AllowButtonSpecToolTips As Boolean
        Get
            Return _textBox.AllowButtonSpecToolTips
        End Get
        Set(value As Boolean)
            _textBox.AllowButtonSpecToolTips = value
        End Set
    End Property

    <Category("Visuals")>
    <Description("Collection of button specifications.")>
    Public ReadOnly Property ButtonSpecs As KryptonTextBox.TextBoxButtonSpecCollection
        Get
            Return _textBox.ButtonSpecs
        End Get
    End Property

    <Category("Visuals")>
    <Description("Initialize a new instance of the PaletteCueHintText class.")>
    Public ReadOnly Property CueHintText As PaletteCueHintText
        Get
            Return _textBox.CueHint
        End Get
    End Property

    <Category("Visuals")>
    <Description("Overrides for defining common textbox appearance that other states can override.")>
    Public ReadOnly Property StateCommon As PaletteInputControlTripleRedirect
        Get
            Return _textBox.StateCommon
        End Get
    End Property

    <Category("Visuals")>
    <Description("Overrides for defining disabled textbox appearance.")>
    Public ReadOnly Property StateDisabled As PaletteInputControlTripleStates
        Get
            Return _textBox.StateDisabled
        End Get
    End Property

    <Category("Visuals")>
    <Description("Overrides for defining normal textbox appearance.")>
    Public ReadOnly Property StateNormal As PaletteInputControlTripleStates
        Get
            Return _textBox.StateNormal
        End Get
    End Property

    <Category("Visuals")>
    <Description("Overrides for defining active textbox appearance.")>
    Public ReadOnly Property StateActive As PaletteInputControlTripleStates
        Get
            Return _textBox.StateActive
        End Get
    End Property

    <Category("Layout")>
    <Description("The size of the control is pixels.")>
    Public Property Size As Size
        Get
            Return _textBox.Size
        End Get
        Set(value As Size)
            _textBox.Size = value
        End Set
    End Property

    <Category("Layout")>
    <Description("The location of the control in pixels.")>
    Public Property Location As Point
        Get
            Return _textBox.Location
        End Get
        Set(value As Point)
            _textBox.Location = value
        End Set
    End Property

End Class
