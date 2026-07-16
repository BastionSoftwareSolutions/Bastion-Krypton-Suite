#Region "BSD License"
'
' Original BSD 3-Clause License (https://github.com/ComponentFactory/Krypton/blob/master/LICENSE)
'  © Component Factory Pty Ltd, 2006 - 2016, (Version 4.5.0.0) All rights reserved.
'
'  New BSD 3-Clause License (https://github.com/Krypton-Suite/Standard-Toolkit/blob/master/LICENSE)
'  Modifications by Peter Wagner(aka Wagnerp) & Simon Coghlan(aka Smurf-IV), et al. 2017 - 2024. All rights reserved.
'
' VB.NET twin of Source\Krypton Navigator Examples\Navigator Modes\Form1.cs (Bastion Phase 4c).
#End Region

Imports System
Imports System.Collections.Generic
Imports System.Windows.Forms

Imports Krypton.Navigator
Imports Krypton.Toolkit

Public Class Form1

    Private Class DescriptionLookup
        Inherits Dictionary(Of NavigatorMode, String)
    End Class

    Private _lookup As DescriptionLookup

    Public Sub New()
        ' Create descriptions for each of the modes
        _lookup = New DescriptionLookup From {
            {
                NavigatorMode.BarTabGroup,
                "BarTabGroup shows a set of tabs on the outside of a Group container." & vbLf & vbLf &
                "The contents of the selected page are displayed inside the Group container whilst the tab bar has a Panel style background." & vbLf & vbLf &
                "Buttons are provided on the right hand side of the bar so the user can change the selected page or remove a page from the control. " &
                "As with all bar modes, you can change the edge the bar is orientated against."
            },
            {
                NavigatorMode.BarTabOnly,
                "BarTabOnly is a tab strip style mode that does not display the contents of the selected page." & vbLf & vbLf &
                "It shows a set of tabs that allow the user to select different pages at random." & vbLf & vbLf &
                "This mode is useful when you want to provide your own separate mechanism for displaying the selected item. " &
                "By setting the AutoSize=True property on the navigator you can get the control to size appropriately."
            },
            {NavigatorMode.BarRibbonTabGroup, "BarRibbonTabGroup shows a set of ribbon styled tabs on the outside of a Group container." & vbLf & vbLf &
                                              "The contents of the selected page are displayed inside the Group container whilst the tab bar has a Panel style background." & vbLf & vbLf &
                                              "Buttons are provided on the right hand side of the bar so the user can change the selected page or remove a page from the control. " &
                                              "As with all bar modes, you can change the edge the bar is orientated against."},
            {NavigatorMode.BarRibbonTabOnly, "BarRibbonTabOnly is a tab strip style mode that does not display the contents of the selected page." & vbLf & vbLf &
                                             "It shows a set of ribbon styled tabs that allow the user to select different pages at random." & vbLf & vbLf &
                                             "This mode is useful when you want to provide your own separate mechanism for displaying the selected item. " &
                                             "By setting the AutoSize=True property on the navigator you can get the control to size appropriately."},
            {NavigatorMode.BarCheckButtonGroupOutside, "BarCheckButtonGroupOutside shows a bar of CheckButton controls on the outside of a Group container." & vbLf & vbLf &
                                                       "The contents of the selected page are displayed inside the Group container whilst the bar has a Panel style background." & vbLf & vbLf &
                                                       "Buttons are provided on the right hand side of the bar so the user can change the selected page or remove a page from the control. " &
                                                       "As with all modes that show buttons, you can customize the buttons that appear and how they function."},
            {NavigatorMode.BarCheckButtonGroupInside, "BarCheckButtonGroupInside shows a Group container that has two items inside." & vbLf & vbLf &
                                                      "Against the top edge is a bar of CheckButton controls and the rest of the space is filled with the contents of the selected page. " &
                                                      "Buttons are provided on the right hand side of the bar so the user can change the selected page or remove a page from the control." & vbLf & vbLf &
                                                      "As with all bar modes, you can change the edge the bar is orientated against."},
            {NavigatorMode.BarCheckButtonGroupOnly, "BarCheckButtonGroupOnly is a tab strip style mode that does not display the contents of the selected page." & vbLf & vbLf &
                                                    "It shows a Group style container that has a bar of CheckButton controls inside." & vbLf & vbLf &
                                                    "This mode is useful when you want to provide your own separate mechanism for displaying the selected item. " &
                                                    "By setting the AutoSize=True property on the navigator you can get the control to size appropriately."},
            {NavigatorMode.BarCheckButtonOnly, "BarCheckButtonOnly is a tab strip style mode that does not display the contents of the selected page." & vbLf & vbLf &
                                               "It shows a bar of CheckButton controls that allow the user to select different pages at random. " &
                                               "The background of the bar uses a Panel style to control the appearance." & vbLf & vbLf &
                                               "This mode is useful when you want to provide your own separate mechanism for displaying the selected item. " &
                                               "By setting the AutoSize=True property on the navigator you can get the control to size appropriately."},
            {NavigatorMode.HeaderBarCheckButtonGroup, "HeaderBarCheckButtonGroup shows a Header bar containing CheckButton controls within a Group container." & vbLf & vbLf &
                                                      "The contents of the selected page are displayed inside the Group container." & vbLf & vbLf &
                                                      "Buttons are provided on the right hand side of the bar so the user can change the selected page or remove a page from the control. " &
                                                      "As with all modes that show buttons, you can customize the buttons that appear and how they function."},
            {NavigatorMode.HeaderBarCheckButtonHeaderGroup, "HeaderBarCheckButtonHeaderGroup mode provides a Header containing CheckButton controls and two additional headers for displaying information about the currently selected page." & vbLf & vbLf &
                                                            "Buttons are provided on the primary header so the user can page the selected page or remove a page from the control." & vbLf & vbLf &
                                                            "You can customize how page details are mapped to the headers in order to show only the exact details you need in the location of your choice."},
            {NavigatorMode.HeaderBarCheckButtonOnly, "HeaderBarCheckButtonOnly is a tab strip style mode that does not display the contents of the selected page." & vbLf & vbLf &
                                                     "It shows a Header bar of CheckButton controls that allow the user to select different pages at random." & vbLf & vbLf &
                                                     "This mode is useful when you want to provide your own separate mechanism for displaying the selected item. " &
                                                     "By setting the AutoSize=True property on the navigator you can get the control to size appropriately."},
            {NavigatorMode.StackCheckButtonGroup, "StackCheckButtonGroup mode shows a set of CheckButton controls stacked within a Group container. " &
                                                  "You can choose to stack in either a vertical or horizontal orientation." & vbLf & vbLf &
                                                  "The selected page is shown immediately below the matching CheckButton but you can choose to have all the CheckButtons placed at the top or bottom."},
            {NavigatorMode.StackCheckButtonHeaderGroup, "StackCheckButtonGroup mode shows a set of CheckButton controls in conjunction with two headers for displaying information about the currently selected page." & vbLf & vbLf &
                                                        "You can choose to stack in either a vertical or horizontal orientation. " &
                                                        "The selected page is shown immediately below the matching CheckButton but you can choose to have all the CheckButtons placed at the top or bottom."},
            {NavigatorMode.OutlookFull, "OutlookFull mode mimics the expanded operation of the Microsoft Outlook 2007 selection control." & vbLf & vbLf &
                                        "A set of CheckButton controls are stacked vertically along with an overflow bar at the bottom of the control. " &
                                        "If there is not enough room to show all the stacking items then they are automatically placed on the overflow bar." & vbLf & vbLf &
                                        "The user can drag the separator to manually force CheckButton items to be removed from the stack and placed in the overflow bar and vica versa."},
            {NavigatorMode.OutlookMini, "OutlookMini mode mimics the collapsed operation of the Microsoft Outlook 2007 selection control." & vbLf & vbLf &
                                        "A set of CheckButton controls are stacked vertically to allow selection of different pages. " &
                                        "Clicking the selection button for the current page causes a popup to show with the page contents."},
            {NavigatorMode.HeaderGroup, "HeaderGroup mode provides two headers that are used to display information about the currently selected page." & vbLf & vbLf &
                                        "Buttons are provided on the primary header so the user can page the selected page or remove a page from the control." & vbLf & vbLf &
                                        "You can customize how page details are mapped to the headers in order to show only the exact details you need in the location of your choice."},
            {NavigatorMode.HeaderGroupTab, "HeaderGroupTab mode provides two headers that are used to display information about the currently selected page along with a set of tabs for page selection." & vbLf & vbLf &
                                           "Buttons are provided on the primary header so the user can page the selected page or remove a page from the control." & vbLf & vbLf &
                                           "You can customize how page details are mapped to the headers in order to show only the exact details you need in the location of your choice."},
            {NavigatorMode.Group, "The Group mode does not provide any user interface for changing the selection, it just displays the selected page inside a Group container. " &
                                  "If you need to change the selection then you must do so programmatically." & vbLf & vbLf &
                                  "This mode is useful when you want to provide your own separate mechanism for changing the selection. " &
                                  "At design time you can use a mode that allows pages to be selected so you can quickly and easily design each of the pages, then at runtime switch to the Panel mode for the sparse appearance you need."},
            {NavigatorMode.Panel, "Panel mode does not provide any user interface other than filling the entire client area with the selected page. " &
                                  "If you need to change the selection then you must do so programmatically." & vbLf & vbLf &
                                  "This mode is useful when you want to provide your own separate mechanism for changing the selection. " &
                                  "At design time you can use a mode that allows pages to be selected so you can quickly and easily design each of the pages, then at runtime switch to the Panel mode for the sparse appearance you need."}
        }

        InitializeComponent()
    End Sub

    Private Sub Form1_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        UpdateRadioButtonsFromMode()
    End Sub

    Private Sub radioMode_CheckedChanged(sender As Object, e As EventArgs) Handles _
        radioHeaderGroupTab.CheckedChanged, radioOutlookMini.CheckedChanged,
        radioBarRibbonTabOnly.CheckedChanged, radioBarRibbonTabGroup.CheckedChanged,
        radioBarTabGroup.CheckedChanged, radioBarTabOnly.CheckedChanged,
        radioHeaderBarCheckButtonOnly.CheckedChanged, radioHeaderBarCheckButtonHeaderGroup.CheckedChanged,
        radioHeaderBarCheckButtonGroup.CheckedChanged, radioStackCheckButtonHeaderGroup.CheckedChanged,
        radioStackCheckButtonGroup.CheckedChanged, radioOutlookFull.CheckedChanged,
        radioPanel.CheckedChanged, radioGroup.CheckedChanged, radioHeaderGroup.CheckedChanged,
        radioBarCheckButtonOnly.CheckedChanged, radioBarCheckButtonGroupOnly.CheckedChanged,
        radioBarCheckButtonGroupInside.CheckedChanged, radioBarCheckButtonGroupOutside.CheckedChanged

        UpdateModeFromRadioButtons()
    End Sub

    Private Sub buttonClose_Click(sender As Object, e As EventArgs) Handles buttonClose.Click
        Close()
    End Sub

    Private Sub UpdateModeFromRadioButtons()
        Dim mode = NavigatorMode.BarTabGroup

        ' Work out the new mode we want
        If radioBarTabGroup.Checked Then
            mode = NavigatorMode.BarTabGroup
        ElseIf radioBarTabOnly.Checked Then
            mode = NavigatorMode.BarTabOnly
        ElseIf radioBarRibbonTabGroup.Checked Then
            mode = NavigatorMode.BarRibbonTabGroup
        ElseIf radioBarRibbonTabOnly.Checked Then
            mode = NavigatorMode.BarRibbonTabOnly
        ElseIf radioBarCheckButtonGroupInside.Checked Then
            mode = NavigatorMode.BarCheckButtonGroupInside
        ElseIf radioBarCheckButtonGroupOutside.Checked Then
            mode = NavigatorMode.BarCheckButtonGroupOutside
        ElseIf radioBarCheckButtonGroupOnly.Checked Then
            mode = NavigatorMode.BarCheckButtonGroupOnly
        ElseIf radioBarCheckButtonOnly.Checked Then
            mode = NavigatorMode.BarCheckButtonOnly
        ElseIf radioHeaderBarCheckButtonGroup.Checked Then
            mode = NavigatorMode.HeaderBarCheckButtonGroup
        ElseIf radioHeaderBarCheckButtonHeaderGroup.Checked Then
            mode = NavigatorMode.HeaderBarCheckButtonHeaderGroup
        ElseIf radioHeaderBarCheckButtonOnly.Checked Then
            mode = NavigatorMode.HeaderBarCheckButtonOnly
        ElseIf radioStackCheckButtonGroup.Checked Then
            mode = NavigatorMode.StackCheckButtonGroup
        ElseIf radioStackCheckButtonHeaderGroup.Checked Then
            mode = NavigatorMode.StackCheckButtonHeaderGroup
        ElseIf radioOutlookFull.Checked Then
            mode = NavigatorMode.OutlookFull
        ElseIf radioOutlookMini.Checked Then
            mode = NavigatorMode.OutlookMini
        ElseIf radioHeaderGroup.Checked Then
            mode = NavigatorMode.HeaderGroup
        ElseIf radioHeaderGroupTab.Checked Then
            mode = NavigatorMode.HeaderGroupTab
        ElseIf radioGroup.Checked Then
            mode = NavigatorMode.Group
        ElseIf radioPanel.Checked Then
            mode = NavigatorMode.Panel
        End If

        ' Set the mode into the navigator itself
        kryptonNavigator1.NavigatorMode = mode

        ' Set the AutoSize to show that tabstrip functionality works
        Select Case mode
            Case NavigatorMode.BarCheckButtonGroupOnly,
                 NavigatorMode.BarCheckButtonOnly,
                 NavigatorMode.BarTabOnly,
                 NavigatorMode.HeaderBarCheckButtonOnly,
                 NavigatorMode.OutlookMini
                kryptonNavigator1.AutoSize = True
            Case Else
                kryptonNavigator1.AutoSize = False
        End Select

        ' Set mode specific properties
        Select Case mode
            Case NavigatorMode.BarRibbonTabGroup, NavigatorMode.BarRibbonTabOnly
                kryptonNavigator1.PageBackStyle = PaletteBackStyle.ControlRibbon
                kryptonNavigator1.Group.GroupBackStyle = PaletteBackStyle.ControlRibbon
                kryptonNavigator1.Group.GroupBorderStyle = PaletteBorderStyle.ControlRibbon
            Case Else
                kryptonNavigator1.PageBackStyle = PaletteBackStyle.ControlClient
                kryptonNavigator1.Group.GroupBackStyle = PaletteBackStyle.ControlClient
                kryptonNavigator1.Group.GroupBorderStyle = PaletteBorderStyle.ControlClient
        End Select

        kryptonNavigator1.Dock = If(mode = NavigatorMode.OutlookMini, DockStyle.Left, DockStyle.Top)

        ' Update the radio buttons to reflect the new mode
        UpdateRadioButtonsFromMode()
    End Sub

    Private Sub UpdateRadioButtonsFromMode()
        ' Grab the current mode of the navigator control
        Dim mode As NavigatorMode = kryptonNavigator1.NavigatorMode

        ' Update buttons to reflect the mode
        ' NOTE: Upstream quirk preserved from the C# twin - radioHeaderGroupTab is never updated here.
        radioBarTabGroup.Checked = (mode = NavigatorMode.BarTabGroup)
        radioBarTabOnly.Checked = (mode = NavigatorMode.BarTabOnly)
        radioBarRibbonTabGroup.Checked = (mode = NavigatorMode.BarRibbonTabGroup)
        radioBarRibbonTabOnly.Checked = (mode = NavigatorMode.BarRibbonTabOnly)
        radioBarCheckButtonGroupInside.Checked = (mode = NavigatorMode.BarCheckButtonGroupInside)
        radioBarCheckButtonGroupOutside.Checked = (mode = NavigatorMode.BarCheckButtonGroupOutside)
        radioBarCheckButtonGroupOnly.Checked = (mode = NavigatorMode.BarCheckButtonGroupOnly)
        radioBarCheckButtonOnly.Checked = (mode = NavigatorMode.BarCheckButtonOnly)
        radioHeaderBarCheckButtonGroup.Checked = (mode = NavigatorMode.HeaderBarCheckButtonGroup)
        radioHeaderBarCheckButtonHeaderGroup.Checked = (mode = NavigatorMode.HeaderBarCheckButtonHeaderGroup)
        radioHeaderBarCheckButtonOnly.Checked = (mode = NavigatorMode.HeaderBarCheckButtonOnly)
        radioStackCheckButtonGroup.Checked = (mode = NavigatorMode.StackCheckButtonGroup)
        radioStackCheckButtonHeaderGroup.Checked = (mode = NavigatorMode.StackCheckButtonHeaderGroup)
        radioOutlookFull.Checked = (mode = NavigatorMode.OutlookFull)
        radioOutlookMini.Checked = (mode = NavigatorMode.OutlookMini)
        radioHeaderGroup.Checked = (mode = NavigatorMode.HeaderGroup)
        radioGroup.Checked = (mode = NavigatorMode.Group)
        radioPanel.Checked = (mode = NavigatorMode.Panel)

        ' Update the description with text for the mode
        textBoxDescription.Text = _lookup(mode)
    End Sub

End Class
