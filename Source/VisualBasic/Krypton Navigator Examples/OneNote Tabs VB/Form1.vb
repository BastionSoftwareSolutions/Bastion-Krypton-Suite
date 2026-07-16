#Region "BSD License"
'
' Original BSD 3-Clause License (https://github.com/ComponentFactory/Krypton/blob/master/LICENSE)
'  © Component Factory Pty Ltd, 2006 - 2016, (Version 4.5.0.0) All rights reserved.
'
'  New BSD 3-Clause License (https://github.com/Krypton-Suite/Standard-Toolkit/blob/master/LICENSE)
'  Modifications by Peter Wagner(aka Wagnerp) & Simon Coghlan(aka Smurf-IV), et al. 2017 - 2024. All rights reserved.
'
' VB.NET twin of Source\Krypton Navigator Examples\OneNote Tabs\Form1.cs (Bastion Phase 4c).
#End Region

Imports System
Imports System.Drawing
Imports System.Windows.Forms

Imports Krypton.Navigator
Imports Krypton.Toolkit

Public Class Form1

    Private _count As Integer = 0

    ' Colors used when hot tracking over tabs
    Private _hotMain As Color = Color.FromArgb(255, 240, 200)
    Private _hotEmbedSelected As Color = Color.FromArgb(255, 241, 224)
    Private _hotEmbedTracking As Color = Color.FromArgb(255, 231, 162)

    ' 8 example titles for the tabs
    Private _titleMain As String() = New String() {"Personal", "Online",
                                                   "Books", "Travel",
                                                   "Movies", "Music",
                                                   "Recipes", "Shopping"}

    Private _titleEmbedded As String() = New String() {"Financial information", "Credit card accounts",
                                                       "Website logins", "Medical information",
                                                       "Frequent flyer points", "Activities",
                                                       "Sightseeing", "Transportation",
                                                       "Hotel information", "Trip schedule",
                                                       "Searching", "Take notes",
                                                       "Diary entry", "Bug reports",
                                                       "Release schedule", "Shared resources",
                                                       "Screen shots", "Book list"}

    ' 8 colors for when the tab is not selected
    Private _normal As Color() = New Color() {Color.FromArgb(156, 193, 182), Color.FromArgb(247, 184, 134),
                                              Color.FromArgb(217, 173, 194), Color.FromArgb(165, 194, 215),
                                              Color.FromArgb(179, 166, 190), Color.FromArgb(234, 214, 163),
                                              Color.FromArgb(246, 250, 125), Color.FromArgb(188, 168, 225)}

    ' 8 colors for when the tab is selected
    Private _select As Color() = New Color() {Color.FromArgb(200, 221, 215), Color.FromArgb(251, 216, 188),
                                              Color.FromArgb(234, 210, 221), Color.FromArgb(205, 221, 233),
                                              Color.FromArgb(213, 206, 219), Color.FromArgb(244, 232, 204),
                                              Color.FromArgb(250, 252, 183), Color.FromArgb(218, 207, 239)}

    Private Sub Form1_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        ' Start with four initial pages
        AddTopPage()
        AddTopPage()
        AddTopPage()
        AddTopPage()
    End Sub

    Private Sub buttonAdd_Click(sender As Object, e As EventArgs) Handles buttonAdd.Click
        ' Append page to end of list
        AddTopPage()

        ' Select the new page
        kryptonNavigator1.SelectedIndex = kryptonNavigator1.Pages.Count - 1

        ' Update button states
        buttonRemove.Enabled = True
        buttonClear.Enabled = True
    End Sub

    Private Sub buttonRemove_Click(sender As Object, e As EventArgs) Handles buttonRemove.Click
        ' Remove the selected page
        kryptonNavigator1.Pages.Remove(kryptonNavigator1.SelectedPage)

        ' Update button states
        buttonRemove.Enabled = (kryptonNavigator1.SelectedPage IsNot Nothing)
        buttonClear.Enabled = (kryptonNavigator1.SelectedPage IsNot Nothing)
    End Sub

    Private Sub buttonClear_Click(sender As Object, e As EventArgs) Handles buttonClear.Click
        ' Remove all pages
        kryptonNavigator1.Pages.Clear()

        ' Update button states
        buttonRemove.Enabled = False
        buttonClear.Enabled = False
    End Sub

    Private Sub AddTopPage()
        ' Create a new krypton page to be added
        Dim page = New KryptonPage()

        ' Set the page title
        page.Text = _titleMain(_count Mod _titleMain.Length)

        ' Remove the default image for the page
        page.ImageSmall = Nothing

        ' Set the padding so contained controls are indented
        page.Padding = New Padding(7)

        ' Get the colors to use for this new page
        Dim normal As Color = _normal(_count Mod _normal.Length)
        Dim [select] As Color = _select(_count Mod _select.Length)

        ' Set the page colors
        page.StateNormal.Page.Color1 = [select]
        page.StateNormal.Page.Color2 = normal
        page.StateNormal.Tab.Back.Color2 = normal
        page.StateSelected.Tab.Back.Color2 = [select]
        page.StateTracking.Tab.Back.Color2 = _hotMain
        page.StatePressed.Tab.Back.Color2 = _hotMain

        ' We want the page drawn as a gradient with colors relative to its own area
        page.StateCommon.Page.ColorAlign = PaletteRectangleAlign.Local
        page.StateCommon.Page.ColorStyle = PaletteColorStyle.Sigma

        ' We add an embedded navigator with its own pages to mimic OneNote operation
        AddEmbeddedNavigator(page)

        ' Add page to end of the navigator collection
        kryptonNavigator1.Pages.Add(page)

        ' Bump the page index to use next
        _count += 1
    End Sub

    Private Sub AddEmbeddedNavigator(page As KryptonPage)
        ' Create a navigator to embed inside the page
        Dim nav = New KryptonNavigator()

        ' We want the navigator to fill the entire page area
        nav.Dock = DockStyle.Fill

        ' Remove the close and context buttons
        nav.Button.CloseButtonDisplay = ButtonDisplay.Hide
        nav.Button.ButtonDisplayLogic = ButtonDisplayLogic.None

        ' Set the required tab and bar settings
        nav.Bar.BarOrientation = VisualOrientation.Right
        nav.Bar.ItemOrientation = ButtonOrientation.FixedTop
        nav.Bar.ItemSizing = BarItemSizing.SameWidthAndHeight
        nav.Bar.TabBorderStyle = TabBorderStyle.RoundedEqualSmall
        nav.Bar.TabStyle = TabStyle.StandardProfile

        ' Do not draw the bar area background, let parent page show through
        nav.StateCommon.Panel.Draw = InheritBool.False

        ' Use same font for all tab states and we want text aligned to near
        nav.StateCommon.Tab.Content.ShortText.Font = SystemFonts.IconTitleFont
        nav.StateCommon.Tab.Content.ShortText.TextH = PaletteRelativeAlign.Near

        ' Set the page colors
        nav.StateCommon.Tab.Content.Padding = New Padding(4)
        nav.StateNormal.Tab.Back.ColorStyle = PaletteColorStyle.Linear
        nav.StateNormal.Tab.Back.Color1 = _select(_count Mod _select.Length)
        nav.StateNormal.Tab.Back.Color2 = Color.White
        nav.StateNormal.Tab.Back.ColorAngle = 270
        nav.StateSelected.Tab.Back.ColorStyle = PaletteColorStyle.Linear
        nav.StateSelected.Tab.Back.Color2 = _hotEmbedSelected
        nav.StateSelected.Tab.Back.ColorAngle = 270
        nav.StateTracking.Tab.Back.ColorStyle = PaletteColorStyle.Solid
        nav.StateTracking.Tab.Back.Color1 = _hotEmbedTracking
        nav.StatePressed.Tab.Back.ColorStyle = PaletteColorStyle.Solid
        nav.StatePressed.Tab.Back.Color1 = _hotEmbedTracking

        ' Add a random number of pages
        Dim rand = New Random()
        Dim numPages = 3 + rand.Next(5)

        For i = 0 To numPages - 1
            nav.Pages.Add(NewEmbeddedPage(_titleEmbedded(rand.Next(_titleEmbedded.Length - 1))))
        Next

        page.Controls.Add(nav)
    End Sub

    Private Function NewEmbeddedPage(title As String) As KryptonPage
        Dim page = New KryptonPage()
        page.Text = title
        page.ImageSmall = Nothing
        Return page
    End Function

    Private Sub buttonClose_Click(sender As Object, e As EventArgs) Handles buttonClose.Click
        Close()
    End Sub

End Class
