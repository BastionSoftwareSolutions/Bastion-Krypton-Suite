' Original BSD 3-Clause License (https://github.com/ComponentFactory/Krypton/blob/master/LICENSE)
'  © Component Factory Pty Ltd, 2006 - 2016, (Version 4.5.0.0) All rights reserved.
'
'  New BSD 3-Clause License (https://github.com/Krypton-Suite/Standard-Toolkit/blob/master/LICENSE)
'  Modifications by Peter Wagner(aka Wagnerp) & Simon Coghlan(aka Smurf-IV), et al. 2017 - 2024. All rights reserved.
'
' VB.NET twin of Source\Krypton Toolkit Examples\KryptonForm Examples\Form1.cs (Bastion Phase 4c).

Imports System.ComponentModel
Imports System.Drawing
Imports System.Windows.Forms

Imports Krypton.Toolkit

Public Class Form1

    Public Sub New()
        InitializeComponent()
        'ButtonSpecClose.Enabled = False
        ButtonSpecClose.ToolTipShadow = False
    End Sub

    Private Sub kryptonCheckSetPalettes_CheckedButtonChanged(sender As Object, e As EventArgs) Handles kryptonCheckSetPalettes.CheckedButtonChanged
        ' Recalc the non client size to reflect new border style
        RecalcNonClient()

        Select Case kryptonCheckSetPalettes.CheckedIndex
            Case 0
                kryptonManager.GlobalPaletteMode = PaletteMode.Microsoft365Blue
            Case 1
                kryptonManager.GlobalPaletteMode = PaletteMode.ProfessionalSystem
            Case 2
                kryptonManager.GlobalPaletteMode = PaletteMode.Office2007Black
            Case 3
                kryptonManager.GlobalPaletteMode = PaletteMode.Office2007Silver
            Case 4
                kryptonManager.GlobalPaletteMode = PaletteMode.Office2007Blue
            Case 5
                kryptonManager.GlobalPaletteMode = PaletteMode.ProfessionalOffice2003
            Case 6
                kryptonManager.GlobalPaletteMode = PaletteMode.SparkleBlue
            Case 7
                kryptonManager.GlobalPaletteMode = PaletteMode.SparkleOrange
            Case 8
                kryptonManager.GlobalPaletteMode = PaletteMode.Office2010Black
            Case 9
                kryptonManager.GlobalPaletteMode = PaletteMode.Office2010Silver
            Case 10
                kryptonManager.GlobalPaletteMode = PaletteMode.Office2010Blue
        End Select
    End Sub

    Private Sub kryptonCheckSetStyles_CheckedButtonChanged(sender As Object, e As EventArgs) Handles kryptonCheckSetStyles.CheckedButtonChanged
        Select Case kryptonCheckSetStyles.CheckedIndex
            Case 0
                FormBorderStyle = FormBorderStyle.Sizable
            Case 1
                FormBorderStyle = FormBorderStyle.FixedToolWindow
            Case 2
                FormBorderStyle = FormBorderStyle.SizableToolWindow
            Case 3
                FormBorderStyle = FormBorderStyle.FixedDialog
            Case 4
                FormBorderStyle = FormBorderStyle.Fixed3D
            Case 5
                FormBorderStyle = FormBorderStyle.FixedSingle
            Case 6
                FormBorderStyle = FormBorderStyle.None
        End Select

        ' Recalc the non client size to reflect new border style
        RecalcNonClient()
    End Sub

    Private Sub Form1_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        ' Set correct initial checked button
        If KryptonManager.CurrentGlobalPalette Is KryptonManager.PaletteOffice2007Black Then
            kryptonCheckSetPalettes.CheckedIndex = 1
        End If

        ' Setup the property grid to edit this form
        propertyGrid.SelectedObject = New KryptonFormProxy(Me)
    End Sub

    Private Sub btnUseThemeWidths_Click(sender As Object, e As EventArgs) Handles btnUseThemeWidths.Click
        UseThemeFormChromeBorderWidth = btnUseThemeWidths.Checked
    End Sub

End Class

Public Class KryptonFormProxy

    Private _form As KryptonForm

    Public Sub New(form As KryptonForm)
        _form = form
    End Sub

    <Category("Appearance")>
    <Description("The text associated with the control.")>
    <DefaultValue("")>
    Public Property Text() As String
        Get
            Return _form.Text
        End Get
        Set(value As String)
            _form.Text = value
        End Set
    End Property

    <Category("Appearance")>
    <Description("The extra text associated with the control.")>
    <DefaultValue("")>
    Public Property TextExtra() As String
        Get
            Return _form.TextExtra
        End Get
        Set(value As String)
            _form.TextExtra = value
        End Set
    End Property

    <Category("Appearance")>
    <Description("The icon associated with the control.")>
    <DefaultValue(CType(Nothing, Object))>
    Public Property Icon() As Icon
        Get
            Return _form.Icon
        End Get
        Set(value As Icon)
            _form.Icon = value
        End Set
    End Property

    <Category("Visuals")>
    <Description("Should custom chrome be allowed for this KryptonForm instance.")>
    <DefaultValue(True)>
    Public Property UseThemeFormChromeBorderWidth() As Boolean
        Get
            Return _form.UseThemeFormChromeBorderWidth
        End Get
        Set(value As Boolean)
            _form.UseThemeFormChromeBorderWidth = value
        End Set
    End Property

    <Category("Visuals")>
    <Description("Should the form status strip be considered for merging into chrome.")>
    <DefaultValue(True)>
    Public Property AllowStatusStripMerge() As Boolean
        Get
            Return _form.AllowStatusStripMerge
        End Get
        Set(value As Boolean)
            _form.AllowStatusStripMerge = value
        End Set
    End Property

    <Category("Visuals")>
    <Description("Header style for a main form.")>
    <DefaultValue(HeaderStyle.Form)>
    Public Property HeaderStyle() As HeaderStyle
        Get
            Return _form.HeaderStyle
        End Get
        Set(value As HeaderStyle)
            _form.HeaderStyle = value
        End Set
    End Property

    <Category("Visuals")>
    <Description("The Form Title position, relative to available space")>
    <RefreshProperties(RefreshProperties.All)>
    <DefaultValue(PaletteRelativeAlign.Near)>
    Public Property FormTitleAlign() As PaletteRelativeAlign
        Get
            Return _form.FormTitleAlign
        End Get
        Set(value As PaletteRelativeAlign)
            _form.FormTitleAlign = value
        End Set
    End Property

    <Category("Visuals")>
    <Description("Chrome group border style.")>
    <DefaultValue(PaletteBorderStyle.FormMain)>
    Public Property GroupBorderStyle() As PaletteBorderStyle
        Get
            Return _form.GroupBorderStyle
        End Get
        Set(value As PaletteBorderStyle)
            _form.GroupBorderStyle = value
        End Set
    End Property

    <Category("Visuals")>
    <Description("Chrome group background style.")>
    <DefaultValue(PaletteBackStyle.FormMain)>
    Public Property GroupBackStyle() As PaletteBackStyle
        Get
            Return _form.GroupBackStyle
        End Get
        Set(value As PaletteBackStyle)
            _form.GroupBackStyle = value
        End Set
    End Property

    <Category("Visuals")>
    <Description("Overrides for defining common form appearance that other states can override.")>
    Public ReadOnly Property StateCommon() As PaletteFormRedirect
        Get
            Return _form.StateCommon
        End Get
    End Property

    <Category("Visuals")>
    <Description("Overrides for defining inactive form appearance.")>
    Public ReadOnly Property StateInactive() As PaletteForm
        Get
            Return _form.StateInactive
        End Get
    End Property

    <Category("Visuals")>
    <Description("Overrides for defining active form appearance.")>
    Public ReadOnly Property StateActive() As PaletteForm
        Get
            Return _form.StateActive
        End Get
    End Property

    <Category("Visuals")>
    <Description("Collection of button specifications.")>
    Public ReadOnly Property ButtonSpecs() As KryptonForm.FormButtonSpecCollection
        Get
            Return _form.ButtonSpecs
        End Get
    End Property

    <Category("Window Style")>
    <DefaultValue(True)>
    Public Property ControlBox() As Boolean
        Get
            Return _form.ControlBox
        End Get
        Set(value As Boolean)
            _form.ControlBox = value
        End Set
    End Property

    <Category("Window Style")>
    <DefaultValue(True)>
    Public Property MaximizeBox() As Boolean
        Get
            Return _form.MaximizeBox
        End Get
        Set(value As Boolean)
            _form.MaximizeBox = value
        End Set
    End Property

    <Category("Window Style")>
    <DefaultValue(True)>
    Public Property MinimizeBox() As Boolean
        Get
            Return _form.MinimizeBox
        End Get
        Set(value As Boolean)
            _form.MinimizeBox = value
        End Set
    End Property

    <Category("Window Style")>
    <DefaultValue(True)>
    Public Property ShowIcon() As Boolean
        Get
            Return _form.ShowIcon
        End Get
        Set(value As Boolean)
            _form.ShowIcon = value
        End Set
    End Property

End Class
