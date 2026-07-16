#Region "BSD License"
'
' Original BSD 3-Clause License (https://github.com/ComponentFactory/Krypton/blob/master/LICENSE)
'  © Component Factory Pty Ltd, 2006 - 2016, (Version 4.5.0.0) All rights reserved.
'
'  New BSD 3-Clause License (https://github.com/Krypton-Suite/Standard-Toolkit/blob/master/LICENSE)
'  Modifications by Peter Wagner(aka Wagnerp) & Simon Coghlan(aka Smurf-IV), et al. 2017 - 2024. All rights reserved.
'
' VB.NET twin of Source\Krypton Toolkit Examples\KryptonRichTextBox Examples\Form1.cs (Bastion Phase 4c).
#End Region

Imports System
Imports System.ComponentModel
Imports System.Drawing
Imports System.Windows.Forms

Imports Krypton.Toolkit

Public Class Form1

    Private Sub Form1_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        ' Load the RTF into the controls
        kryptonRichTextBox3Blue.Rtf = My.Resources.Document
        kryptonRichTextBox6System.Rtf = My.Resources.Document

        ' Setup the property grid to edit this rich text box
        propertyGrid.SelectedObject = New KryptonRichTextBoxProxy(kryptonRichTextBox1Blue)
        buttonSpecAny1.Values.Image = kryptonRichTextBox2Blue.Redirector.GetButtonSpecImage(PaletteButtonSpecStyle.Undo, PaletteState.Normal)
        buttonSpecAny2.Values.Image = kryptonRichTextBox2Blue.Redirector.GetButtonSpecImage(PaletteButtonSpecStyle.Close, PaletteState.Normal)
        buttonSpecAny3.Values.Image = kryptonRichTextBox2Blue.Redirector.GetButtonSpecImage(PaletteButtonSpecStyle.Cut, PaletteState.Normal)
    End Sub

    ' kryptonRichTextBox7Custom is a local of InitializeComponent (as in the C#
    ' designer), so its Enter event is wired there via AddHandler instead.
    Private Sub kryptonRichTextBox1Blue_Enter(sender As Object, e As EventArgs) Handles _
        kryptonRichTextBox1Blue.Enter, kryptonRichTextBox2Blue.Enter, kryptonRichTextBox3Blue.Enter,
        kryptonRichTextBox4System.Enter, kryptonRichTextBox5System.Enter, kryptonRichTextBox6System.Enter,
        kryptonRichTextBox9Custom.Enter

        ' Setup the property grid to edit this rich text box
        propertyGrid.SelectedObject = New KryptonRichTextBoxProxy(DirectCast(sender, KryptonRichTextBox))
    End Sub

    Private Sub buttonSpecAny1_Click(sender As Object, e As EventArgs) Handles buttonSpecAny1.Click
        kryptonRichTextBox2Blue.Text = String.Empty
    End Sub

    Private Sub buttonSpecAny3_Click(sender As Object, e As EventArgs) Handles buttonSpecAny3.Click
        kryptonRichTextBox5System.Text = String.Empty
    End Sub

    Private Sub fixedText1_Click(sender As Object, e As EventArgs) Handles kryptonContextMenuItem1.Click
        kryptonRichTextBox9Custom.Text = "Fixed Text 1"
        kryptonRichTextBox9Custom.RichTextBox.Focus()
    End Sub

    Private Sub fixedText2_Click(sender As Object, e As EventArgs) Handles kryptonContextMenuItem2.Click
        kryptonRichTextBox9Custom.Text = "Fixed Text 2"
        kryptonRichTextBox9Custom.RichTextBox.Focus()
    End Sub

    Private Sub clear_Click(sender As Object, e As EventArgs) Handles buttonSpecAny2.Click, kryptonContextMenuItem3.Click
        kryptonRichTextBox9Custom.Clear()
        kryptonRichTextBox9Custom.RichTextBox.Focus()
    End Sub

    Private Sub buttonClose_Click(sender As Object, e As EventArgs) Handles buttonClose.Click
        Close()
    End Sub

End Class

Public Class KryptonRichTextBoxProxy

    Private _richTextBox As KryptonRichTextBox

    Public Sub New(textBox As KryptonRichTextBox)
        _richTextBox = textBox
    End Sub

    <Category("Appearance")>
    <Description("Text for display inside the control.")>
    Public Property Text As String
        Get
            Return _richTextBox.Text
        End Get
        Set(value As String)
            _richTextBox.Text = value
        End Set
    End Property

    <Category("Visuals")>
    <Description("Determines if the control is always active or only when the mouse is over the control or has focus.")>
    Public Property AlwaysActive As Boolean
        Get
            Return _richTextBox.AlwaysActive
        End Get
        Set(value As Boolean)
            _richTextBox.AlwaysActive = value
        End Set
    End Property

    <Category("Appearance")>
    <Description("Indicates, for multiline edit controls, which scroll bars will be shown for this control.")>
    Public Property ScrollBars As RichTextBoxScrollBars
        Get
            Return _richTextBox.ScrollBars
        End Get
        Set(value As RichTextBoxScrollBars)
            _richTextBox.ScrollBars = value
        End Set
    End Property

    <Category("Behavior")>
    <Description("Indicates if lines are automatically word-wrapped for multiline edit controls.")>
    Public Property WordWrap As Boolean
        Get
            Return _richTextBox.WordWrap
        End Get
        Set(value As Boolean)
            _richTextBox.WordWrap = value
        End Set
    End Property

    <Category("Behavior")>
    <Description("Control whether the text in the control can span more than one line.")>
    Public Property Multiline As Boolean
        Get
            Return _richTextBox.Multiline
        End Get
        Set(value As Boolean)
            _richTextBox.Multiline = value
        End Set
    End Property

    <Category("Behavior")>
    <Description("Defines the right margin dimensions.")>
    Public Property RightMargin As Integer
        Get
            Return _richTextBox.RightMargin
        End Get
        Set(value As Integer)
            _richTextBox.RightMargin = value
        End Set
    End Property

    <Category("Behavior")>
    <Description("Turns on/off the selection margin.")>
    Public Property ShowSelectionMargin As Boolean
        Get
            Return _richTextBox.ShowSelectionMargin
        End Get
        Set(value As Boolean)
            _richTextBox.ShowSelectionMargin = value
        End Set
    End Property

    <Category("Behavior")>
    <Description("Defines the current scaling factor of the KryptonRichTextBox display; 1.0 is normal viewing.")>
    Public Property ZoomFactor As Single
        Get
            Return _richTextBox.ZoomFactor
        End Get
        Set(value As Single)
            _richTextBox.ZoomFactor = value
        End Set
    End Property

    <Category("Behavior")>
    <Description("Indicates if tab characters are accepted as input for multiline edit controls.")>
    Public Property AcceptsTab As Boolean
        Get
            Return _richTextBox.AcceptsTab
        End Get
        Set(value As Boolean)
            _richTextBox.AcceptsTab = value
        End Set
    End Property

    <Category("Behavior")>
    <Description("Indicates that the selection should be hidden when the edit control loses focus.")>
    Public Property HideSelection As Boolean
        Get
            Return _richTextBox.HideSelection
        End Get
        Set(value As Boolean)
            _richTextBox.HideSelection = value
        End Set
    End Property

    <Category("Behavior")>
    <Description("Specifies the maximum number of characters that can be entered into the edit control.")>
    Public Property MaxLength As Integer
        Get
            Return _richTextBox.MaxLength
        End Get
        Set(value As Integer)
            _richTextBox.MaxLength = value
        End Set
    End Property

    <Category("Behavior")>
    <Description("Turns on/off automatic word selection.")>
    Public Property AutoWordSelection As Boolean
        Get
            Return _richTextBox.AutoWordSelection
        End Get
        Set(value As Boolean)
            _richTextBox.AutoWordSelection = value
        End Set
    End Property

    <Category("Behavior")>
    <Description("Defines the indent for bullets in the control.")>
    Public Property BulletIndent As Integer
        Get
            Return _richTextBox.BulletIndent
        End Get
        Set(value As Integer)
            _richTextBox.BulletIndent = value
        End Set
    End Property

    <Category("Behavior")>
    <Description("Indicates whether URLs are automatically formatted as links.")>
    Public Property DetectUrls As Boolean
        Get
            Return _richTextBox.DetectUrls
        End Get
        Set(value As Boolean)
            _richTextBox.DetectUrls = value
        End Set
    End Property

    <Category("Behavior")>
    <Description("Controls whether the text in the edit control can be changed or not.")>
    Public Property [ReadOnly] As Boolean
        Get
            Return _richTextBox.ReadOnly
        End Get
        Set(value As Boolean)
            _richTextBox.ReadOnly = value
        End Set
    End Property

    <Category("Visuals")>
    <Description("Input control style.")>
    Public Property InputControlStyle As InputControlStyle
        Get
            Return _richTextBox.InputControlStyle
        End Get
        Set(value As InputControlStyle)
            _richTextBox.InputControlStyle = value
        End Set
    End Property

    <Category("Visuals")>
    <Description("Overrides for defining common textbox appearance that other states can override.")>
    Public ReadOnly Property StateCommon As PaletteInputControlTripleRedirect
        Get
            Return _richTextBox.StateCommon
        End Get
    End Property

    <Category("Visuals")>
    <Description("Overrides for defining disabled textbox appearance.")>
    Public ReadOnly Property StateDisabled As PaletteInputControlTripleStates
        Get
            Return _richTextBox.StateDisabled
        End Get
    End Property

    <Category("Visuals")>
    <Description("Overrides for defining normal textbox appearance.")>
    Public ReadOnly Property StateNormal As PaletteInputControlTripleStates
        Get
            Return _richTextBox.StateNormal
        End Get
    End Property

    <Category("Visuals")>
    <Description("Overrides for defining active textbox appearance.")>
    Public ReadOnly Property StateActive As PaletteInputControlTripleStates
        Get
            Return _richTextBox.StateActive
        End Get
    End Property

    <Category("Layout")>
    <Description("The size of the control is pixels.")>
    Public Property Size As Size
        Get
            Return _richTextBox.Size
        End Get
        Set(value As Size)
            _richTextBox.Size = value
        End Set
    End Property

    <Category("Layout")>
    <Description("The location of the control in pixels.")>
    Public Property Location As Point
        Get
            Return _richTextBox.Location
        End Get
        Set(value As Point)
            _richTextBox.Location = value
        End Set
    End Property

End Class
