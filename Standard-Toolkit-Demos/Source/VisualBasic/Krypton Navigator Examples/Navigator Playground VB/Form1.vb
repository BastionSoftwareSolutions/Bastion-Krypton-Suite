#Region "BSD License"
'
' Original BSD 3-Clause License (https://github.com/ComponentFactory/Krypton/blob/master/LICENSE)
'  © Component Factory Pty Ltd, 2006 - 2016, (Version 4.5.0.0) All rights reserved.
'
'  New BSD 3-Clause License (https://github.com/Krypton-Suite/Standard-Toolkit/blob/master/LICENSE)
'  Modifications by Peter Wagner(aka Wagnerp) & Simon Coghlan(aka Smurf-IV), et al. 2017 - 2024. All rights reserved.
'
' VB.NET twin of Source\Krypton Navigator Examples\Navigator Playground\Form1.cs (Bastion Phase 4c).
#End Region

Imports System
Imports System.ComponentModel
Imports System.Drawing
Imports System.Windows.Forms

Imports Krypton.Navigator
Imports Krypton.Toolkit

Public Class Form1

    Private _count As Integer = 3

    Public Sub New()
        InitializeComponent()

        ' Monitor changes in the pages collection (runtime wiring, mirroring the C# twin)
        AddHandler kryptonNavigator1.Pages.Inserted, New TypedHandler(Of KryptonPage)(AddressOf OnPageInsertRemove)
        AddHandler kryptonNavigator1.Pages.Removed, New TypedHandler(Of KryptonPage)(AddressOf OnPageInsertRemove)
        AddHandler kryptonNavigator1.Pages.Cleared, New EventHandler(AddressOf OnPagesCleared)
    End Sub

    Private Sub Form1_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        ' Use the proxy to expose just the interesting properties of the navigator
        propertyGrid1.SelectedObject = New KryptonNavigatorProxy(kryptonNavigator1)

        ' Set initial state of the buttons
        UpdateButtonState()
    End Sub

    Private Sub kryptonButtonAdd_Click(sender As Object, e As EventArgs) Handles kryptonButtonAdd.Click
        ' Create a new krypton page
        Dim newPage = New KryptonPage()

        ' Populate with text and image
        newPage.Text = $"Page {_count}"
        newPage.TextTitle = $"Page {_count} Title"
        newPage.TextDescription = $"Page {_count} Description"
        newPage.ImageSmall = DirectCast(imageList1.Images(_count Mod imageList1.Images.Count), Bitmap)
        _count += 1

        ' Append to end of the pages collection
        kryptonNavigator1.Pages.Add(newPage)

        ' Select the new page
        kryptonNavigator1.SelectedPage = newPage
    End Sub

    Private Sub kryptonButtonRemove_Click(sender As Object, e As EventArgs) Handles kryptonButtonRemove.Click
        kryptonNavigator1.Pages.Remove(kryptonNavigator1.SelectedPage)
    End Sub

    Private Sub kryptonButtonClear_Click(sender As Object, e As EventArgs) Handles kryptonButtonClear.Click
        kryptonNavigator1.Pages.Clear()
    End Sub

    Private Sub kryptonButtonEnable_Click(sender As Object, e As EventArgs) Handles kryptonButtonEnable.Click
        kryptonNavigator1.SelectedPage.Enabled = Not kryptonNavigator1.SelectedPage.Enabled
        UpdateButtonState()
    End Sub

    Private Sub kryptonNavigator1_SelectedPageChanged(sender As Object, e As EventArgs) Handles kryptonNavigator1.SelectedPageChanged
        UpdateButtonState()
    End Sub

    Private Sub OnPagesCleared(sender As Object, e As EventArgs)
        UpdateButtonState()
    End Sub

    Private Sub OnPageInsertRemove(sender As Object, e As TypedCollectionEventArgs(Of KryptonPage))
        UpdateButtonState()
    End Sub

    Private Sub UpdateButtonState()
        ' Can only remove if a page is selected
        kryptonButtonRemove.Enabled = (kryptonNavigator1.SelectedPage IsNot Nothing)

        ' Can only clear if there is at least one page in collection
        kryptonButtonClear.Enabled = (kryptonNavigator1.Pages.Count > 0)

        ' Can only change enabled state if a button is selected
        kryptonButtonEnable.Enabled = (kryptonNavigator1.SelectedPage IsNot Nothing)

        ' Only update the enabled button text if the button is itself enabled
        If kryptonButtonEnable.Enabled Then
            ' Give text to indicate the enabled state will be toggled
            If kryptonNavigator1.SelectedPage.Enabled Then
                kryptonButtonEnable.Text = "Disable"
            Else
                kryptonButtonEnable.Text = "Enable"
            End If
        End If
    End Sub

    Private Sub buttonClose_Click(sender As Object, e As EventArgs) Handles buttonClose.Click
        Close()
    End Sub

End Class

Public Class KryptonNavigatorProxy

    Private _navigator As KryptonNavigator

    Public Sub New(navigator As KryptonNavigator)
        _navigator = navigator
    End Sub

    <Category("Visuals"),
     Description("Palette applied to drawing."),
     DefaultValue(GetType(PaletteMode), "Global")>
    Public Property PaletteMode() As PaletteMode
        Get
            Return _navigator.PaletteMode
        End Get
        Set(value As PaletteMode)
            _navigator.PaletteMode = value
        End Set
    End Property

    <Category("Layout"),
     Description("Specifies whether a control will automatically size itself to fit its contents."),
     DefaultValue(False)>
    Public Property AutoSize() As Boolean
        Get
            Return _navigator.AutoSize
        End Get
        Set(value As Boolean)
            _navigator.AutoSize = value
        End Set
    End Property

    <Category("Layout"),
     Description("Specifies if the control grows and shrinks to fit the contents exactly."),
     DefaultValue(GetType(AutoSizeMode), "GrowOnly")>
    Public Property AutoSizeMode() As AutoSizeMode
        Get
            Return _navigator.AutoSizeMode
        End Get
        Set(value As AutoSizeMode)
            _navigator.AutoSizeMode = value
        End Set
    End Property

    <Category("Behavior"),
     Description("Indicates whether the control is enabled."),
     DefaultValue(True)>
    Public Property Enabled() As Boolean
        Get
            Return _navigator.Enabled
        End Get
        Set(value As Boolean)
            _navigator.Enabled = value
        End Set
    End Property

    <Category("Visuals"),
     Description("Collection of pages in the navigator control.")>
    Public ReadOnly Property Pages() As KryptonPageCollection
        Get
            Return _navigator.Pages
        End Get
    End Property

    <Category("Visuals (Modes)"),
     Description("Overrides for defining bar settings.")>
    Public ReadOnly Property Bar() As NavigatorBar
        Get
            Return _navigator.Bar
        End Get
    End Property

    <Category("Visuals (Modes)"),
     Description("Button specifications and fixed button logic.")>
    Public ReadOnly Property Button() As NavigatorButton
        Get
            Return _navigator.Button
        End Get
    End Property

    <Category("Visuals (Modes)"),
     Description("Overrides for defining group settings.")>
    Public ReadOnly Property Group() As NavigatorGroup
        Get
            Return _navigator.Group
        End Get
    End Property

    <Category("Visuals (Modes)"),
     Description("Overrides for defining header settings.")>
    Public ReadOnly Property Header() As NavigatorHeader
        Get
            Return _navigator.Header
        End Get
    End Property

    <Category("Visuals (Modes)"),
     Description("Overrides for defining panel settings.")>
    Public ReadOnly Property Panel() As NavigatorPanel
        Get
            Return _navigator.Panel
        End Get
    End Property

    <Category("Visuals"),
     Description("Overrides for defining common navigator appearance.")>
    Public ReadOnly Property StateCommon() As PaletteNavigatorRedirect
        Get
            Return _navigator.StateCommon
        End Get
    End Property

    <Category("Visuals"),
     Description("Overrides for defining disabled navigator appearance.")>
    Public ReadOnly Property StateDisabled() As PaletteNavigator
        Get
            Return _navigator.StateDisabled
        End Get
    End Property

    <Category("Visuals"),
     Description("Overrides for defining normal navigator appearance.")>
    Public ReadOnly Property StateNormal() As PaletteNavigator
        Get
            Return _navigator.StateNormal
        End Get
    End Property

    <Category("Visuals"),
     Description("Overrides for defining tracking navigator appearance.")>
    Public ReadOnly Property StateTracking() As PaletteNavigatorOther
        Get
            Return _navigator.StateTracking
        End Get
    End Property

    <Category("Visuals"),
     Description("Overrides for defining pressed navigator appearance.")>
    Public ReadOnly Property StatePressed() As PaletteNavigatorOther
        Get
            Return _navigator.StatePressed
        End Get
    End Property

    <Category("Visuals"),
     Description("Overrides for defining selected navigator appearance.")>
    Public ReadOnly Property StateSelected() As PaletteNavigatorOther
        Get
            Return _navigator.StateSelected
        End Get
    End Property

    <Category("Visuals"),
     Description("Overrides for defining focus navigator appearance.")>
    Public ReadOnly Property OverrideFocus() As PaletteNavigatorOtherRedirect
        Get
            Return _navigator.OverrideFocus
        End Get
    End Property

    <Category("Visuals"),
     Description("Display mode of the control instance."),
     DefaultValue(GetType(NavigatorMode), "Bar - CheckButton - Group - Outside")>
    Public Property NavigatorMode() As NavigatorMode
        Get
            Return _navigator.NavigatorMode
        End Get
        Set(value As NavigatorMode)
            _navigator.NavigatorMode = value
        End Set
    End Property

    <Category("Visuals"),
     Description("Page back style."),
     DefaultValue(GetType(PaletteBackStyle), "ControlClient")>
    Public Property PageBackStyle() As PaletteBackStyle
        Get
            Return _navigator.PageBackStyle
        End Get
        Set(value As PaletteBackStyle)
            _navigator.PageBackStyle = value
        End Set
    End Property

End Class
