#Region "BSD License"
'
' Original BSD 3-Clause License (https://github.com/ComponentFactory/Krypton/blob/master/LICENSE)
'  © Component Factory Pty Ltd, 2006 - 2016, (Version 4.5.0.0) All rights reserved.
'
'  New BSD 3-Clause License (https://github.com/Krypton-Suite/Standard-Toolkit/blob/master/LICENSE)
'  Modifications by Peter Wagner(aka Wagnerp) & Simon Coghlan(aka Smurf-IV), tobitege et al. 2017 - 2025. All rights reserved.
'
' VB.NET twin of Source\Krypton Toolkit Examples\KryptonColorButton Examples\Form1.cs (Bastion Phase 4c).
#End Region

Imports System
Imports System.ComponentModel
Imports System.Drawing
Imports System.Windows.Forms

Imports Krypton.Toolkit

Public Class Form1

    Private Sub Form1_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        ' Setup the property grid to edit this color button
        propertyGrid.SelectedObject = New KryptonColorButtonProxy(blueSplitter)
    End Sub

    Private Sub colorButtonEnter(sender As Object, e As EventArgs) Handles _
        blueRight.Enter, blueLeft.Enter, blueBottom.Enter, blueTop.Enter, blueDropDown.Enter, blueSplitter.Enter,
        sparkleBottom.Enter, sparkleTop.Enter, sparkleLeft.Enter, sparkleRight.Enter,
        systemRight.Enter, systemDown.Enter, systemLeft.Enter, systemUp.Enter,
        silverRight.Enter, silverDown.Enter, silverLeft.Enter, silverUp.Enter

        ' Setup the property grid to edit this color button
        propertyGrid.SelectedObject = New KryptonColorButtonProxy(DirectCast(sender, KryptonColorButton))
    End Sub

    Private Sub buttonClose_Click(sender As Object, e As EventArgs) Handles buttonClose.Click
        Close()
    End Sub

    Private Sub KryptonColorButton5_Click(sender As Object, e As EventArgs) Handles kryptonColorButton5.Click
        If KryptonMessageBox.Show(Me,
            "Do you want to perform the normal colourButtonAction ?",
            "Launch what you want",
            KryptonMessageBoxButtons.YesNo, KryptonMessageBoxIcon.Question) = DialogResult.Yes Then

            kryptonColorButton5.PerformDropDown()
        End If
    End Sub

    Private Sub blueRight_Click(sender As Object, e As EventArgs) Handles blueRight.Click
        blueRight.AddUpdateRecentColors(New Color() {
            Color.Yellow,
            Color.YellowGreen,
            Color.GreenYellow,
            Color.LightGoldenrodYellow,
            Color.LightYellow,
            Color.PaleGoldenrod,
            Color.Gold,
            Color.Goldenrod
        })
        blueRight.PerformDropDown()
    End Sub

End Class

Public Class KryptonColorButtonProxy

    Private _colorButton As KryptonColorButton

    Public Sub New(comboBox As KryptonColorButton)
        _colorButton = comboBox
    End Sub

    <Category("Appearance")>
    <Description("Text for display inside the control.")>
    Public Property Text As String
        Get
            Return _colorButton.Text
        End Get
        Set(value As String)
            _colorButton.Text = value
        End Set
    End Property

    <Category("Layout")>
    <Description("The size of the control is pixels.")>
    Public Property Size As System.Drawing.Size
        Get
            Return _colorButton.Size
        End Get
        Set(value As System.Drawing.Size)
            _colorButton.Size = value
        End Set
    End Property

    <Category("Layout")>
    <Description("The location of the control in pixels.")>
    Public Property Location As Point
        Get
            Return _colorButton.Location
        End Get
        Set(value As Point)
            _colorButton.Location = value
        End Set
    End Property

    <Category("Behavior")>
    <Description("Determine the maximum number of recent colors to store and display.")>
    Public Property MaxRecentColors As Integer
        Get
            Return _colorButton.MaxRecentColors
        End Get
        Set(value As Integer)
            _colorButton.MaxRecentColors = value
        End Set
    End Property

    <Category("Behavior")>
    <Description("Determine the visible state of the themes color set.")>
    Public Property VisibleThemes As Boolean
        Get
            Return _colorButton.VisibleThemes
        End Get
        Set(value As Boolean)
            _colorButton.VisibleThemes = value
        End Set
    End Property

    <Category("Behavior")>
    <Description("Determine the visible state of the standard color set.")>
    Public Property VisibleStandard As Boolean
        Get
            Return _colorButton.VisibleStandard
        End Get
        Set(value As Boolean)
            _colorButton.VisibleStandard = value
        End Set
    End Property

    <Category("Behavior")>
    <Description("Determine the visible state of the recent color set.")>
    Public Property VisibleRecent As Boolean
        Get
            Return _colorButton.VisibleRecent
        End Get
        Set(value As Boolean)
            _colorButton.VisibleRecent = value
        End Set
    End Property

    <Category("Behavior")>
    <Description("Determine if the 'No Color' menu item is used.")>
    Public Property VisibleNoColor As Boolean
        Get
            Return _colorButton.VisibleNoColor
        End Get
        Set(value As Boolean)
            _colorButton.VisibleNoColor = value
        End Set
    End Property

    <Category("Behavior")>
    <Description("Determine if the 'More Colors...' menu item is used.")>
    Public Property VisibleMoreColors As Boolean
        Get
            Return _colorButton.VisibleMoreColors
        End Get
        Set(value As Boolean)
            _colorButton.VisibleMoreColors = value
        End Set
    End Property

    <Category("Behavior")>
    <Description("Should recent colors be automatically updated.")>
    Public Property AutoRecentColors As Boolean
        Get
            Return _colorButton.AutoRecentColors
        End Get
        Set(value As Boolean)
            _colorButton.AutoRecentColors = value
        End Set
    End Property

    <Category("Behavior")>
    <Description("Color scheme to use for the themes color set.")>
    Public Property SchemeThemes As ColorScheme
        Get
            Return _colorButton.SchemeThemes
        End Get
        Set(value As ColorScheme)
            _colorButton.SchemeThemes = value
        End Set
    End Property

    <Category("Behavior")>
    <Description("Color scheme to use for the standard color set.")>
    Public Property SchemeStandard As ColorScheme
        Get
            Return _colorButton.SchemeStandard
        End Get
        Set(value As ColorScheme)
            _colorButton.SchemeStandard = value
        End Set
    End Property

    <Category("Appearance")>
    <Description("Selected color.")>
    Public Property SelectedColor As Color
        Get
            Return _colorButton.SelectedColor
        End Get
        Set(value As Color)
            _colorButton.SelectedColor = value
        End Set
    End Property

    <Category("Appearance")>
    <Description("Border color of selected block when selected color is empty.")>
    Public Property EmptyBorderColor As Color
        Get
            Return _colorButton.EmptyBorderColor
        End Get
        Set(value As Color)
            _colorButton.EmptyBorderColor = value
        End Set
    End Property

    <Category("Appearance")>
    <Description("Selected color drawing rectangle.")>
    Public Property SelectedRect As Rectangle
        Get
            Return _colorButton.SelectedRect
        End Get
        Set(value As Rectangle)
            _colorButton.SelectedRect = value
        End Set
    End Property

    <Category("Visuals")>
    <Description("Context menu display strings.")>
    Public ReadOnly Property Strings As PaletteColorButtonStrings
        Get
            Return _colorButton.Strings
        End Get
    End Property

    <Category("Visuals")>
    <Description("Visual orientation of the control.")>
    Public Property ButtonOrientation As VisualOrientation
        Get
            Return _colorButton.ButtonOrientation
        End Get
        Set(value As VisualOrientation)
            _colorButton.ButtonOrientation = value
        End Set
    End Property

    <Category("Visuals")>
    <Description("Position of the drop arrow within the button.")>
    Public Property DropDownPosition As VisualOrientation
        Get
            Return _colorButton.DropDownPosition
        End Get
        Set(value As VisualOrientation)
            _colorButton.DropDownPosition = value
        End Set
    End Property

    <Category("Visuals")>
    <Description("Orientation of the drop arrow within the button.")>
    Public Property DropDownOrientation As VisualOrientation
        Get
            Return _colorButton.DropDownOrientation
        End Get
        Set(value As VisualOrientation)
            _colorButton.DropDownOrientation = value
        End Set
    End Property

    <Category("Visuals")>
    <Description("Determine if button acts as a splitter or just a drop down.")>
    Public Property Splitter As Boolean
        Get
            Return _colorButton.Splitter
        End Get
        Set(value As Boolean)
            _colorButton.Splitter = value
        End Set
    End Property

    <Category("Visuals")>
    <Description("Button style.")>
    Public Property ButtonStyle As Krypton.Toolkit.ButtonStyle
        Get
            Return _colorButton.ButtonStyle
        End Get
        Set(value As Krypton.Toolkit.ButtonStyle)
            _colorButton.ButtonStyle = value
        End Set
    End Property

    <Category("Visuals")>
    <Description("Button values")>
    Public ReadOnly Property Values As ColorButtonValues
        Get
            Return _colorButton.Values
        End Get
    End Property

    <Category("Visuals")>
    <Description("Overrides for defining common button appearance that other states can override.")>
    Public ReadOnly Property StateCommon As PaletteTripleRedirect
        Get
            Return _colorButton.StateCommon
        End Get
    End Property

    <Category("Visuals")>
    <Description("Overrides for defining disabled button appearance.")>
    Public ReadOnly Property StateDisabled As PaletteTriple
        Get
            Return _colorButton.StateDisabled
        End Get
    End Property

    <Category("Visuals")>
    <Description("Overrides for defining normal button appearance.")>
    Public ReadOnly Property StateNormal As PaletteTriple
        Get
            Return _colorButton.StateNormal
        End Get
    End Property

    <Category("Visuals")>
    <Description("Overrides for defining hot tracking button appearance.")>
    Public ReadOnly Property StateTracking As PaletteTriple
        Get
            Return _colorButton.StateTracking
        End Get
    End Property

    <Category("Visuals")>
    <Description("Overrides for defining pressed button appearance.")>
    Public ReadOnly Property StatePressed As PaletteTriple
        Get
            Return _colorButton.StatePressed
        End Get
    End Property

    <Category("Visuals")>
    <Description("Overrides for defining normal button appearance when default.")>
    Public ReadOnly Property OverrideDefault As PaletteTripleRedirect
        Get
            Return _colorButton.OverrideDefault
        End Get
    End Property

    <Category("Visuals")>
    <Description("Overrides for defining button appearance when it has focus.")>
    Public ReadOnly Property OverrideFocus As PaletteTripleRedirect
        Get
            Return _colorButton.OverrideFocus
        End Get
    End Property

End Class
