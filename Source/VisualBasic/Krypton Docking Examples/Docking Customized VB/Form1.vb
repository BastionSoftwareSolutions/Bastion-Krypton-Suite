#Region "BSD License"
'
' Original BSD 3-Clause License (https://github.com/ComponentFactory/Krypton/blob/master/LICENSE)
'  © Component Factory Pty Ltd, 2006 - 2016, (Version 4.5.0.0) All rights reserved.
'
'  New BSD 3-Clause License (https://github.com/Krypton-Suite/Standard-Toolkit/blob/master/LICENSE)
'  Modifications by Peter Wagner(aka Wagnerp) & Simon Coghlan(aka Smurf-IV), et al. 2017 - 2024. All rights reserved.
'
' VB.NET twin of Source\Krypton Docking Examples\Docking Customized\Form1.cs (Bastion Phase 4c).
#End Region

Imports System
Imports System.Drawing
Imports System.Windows.Forms

Imports Krypton.Docking
Imports Krypton.Navigator
Imports Krypton.Ribbon
Imports Krypton.Toolkit
Imports Krypton.Workspace

Public Class Form1

    Private _count As Integer = 1
    Private _random As Random = New Random(DateTime.Now.Millisecond)
    Private _mode As NavigatorMode = NavigatorMode.HeaderBarCheckButtonHeaderGroup
    Private _buttonSpecStyles As PaletteButtonSpecStyle() = {PaletteButtonSpecStyle.ArrowDown, PaletteButtonSpecStyle.ArrowLeft,
                                                             PaletteButtonSpecStyle.ArrowRight, PaletteButtonSpecStyle.ArrowUp,
                                                             PaletteButtonSpecStyle.Close, PaletteButtonSpecStyle.Context,
                                                             PaletteButtonSpecStyle.DropDown}

    Private Function NewDocument() As KryptonPage
        Dim page As KryptonPage = NewPage("Document ", 0, New ContentDocument())

        ' Document pages cannot be docked or auto hidden
        page.ClearFlags(KryptonPageFlags.DockingAllowAutoHidden Or KryptonPageFlags.DockingAllowDocked)

        Return page
    End Function

    Private Function NewInput() As KryptonPage
        Return NewPage("Input ", 1, New ContentInput())
    End Function

    Private Function NewPropertyGrid() As KryptonPage
        Return NewPage("Properties ", 2, New ContentPropertyGrid())
    End Function

    Private Function NewPage(name As String, image As Integer, content As Control) As KryptonPage
        ' Create new page with title and image
        Dim p = New KryptonPage With {
            .Text = name & _count.ToString(),
            .TextTitle = name & _count.ToString(),
            .TextDescription = name & _count.ToString(),
            .ImageSmall = CType(imageListSmall.Images(image), Bitmap)
        }

        ' Add the control for display inside the page
        content.Dock = DockStyle.Fill
        p.Controls.Add(content)

        _count += 1
        Return p
    End Function

    Private Sub Form1_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        ' Setup docking functionality
        Dim w As KryptonDockingWorkspace = kryptonDockingManager.ManageWorkspace(kryptonDockableWorkspace)
        kryptonDockingManager.ManageControl(kryptonPanel, w)
        kryptonDockingManager.ManageFloating(Me)

        ' Add initial docking pages
        kryptonDockingManager.AddToWorkspace("Workspace", {NewDocument(), NewDocument()})
        kryptonDockingManager.AddDockspace("Control", DockingEdge.Right, {NewPropertyGrid(), NewInput(), NewPropertyGrid(), NewInput()})
        kryptonDockingManager.AddDockspace("Control", DockingEdge.Bottom, {NewInput(), NewPropertyGrid(), NewInput(), NewPropertyGrid()})

        UpdateModeButtons()
    End Sub

    Private Sub kryptonDockingManager_DockspaceAdding(sender As Object, e As DockspaceEventArgs) Handles kryptonDockingManager.DockspaceAdding
        ' Set all new dockspace controls to a larger than default size
        e.DockspaceControl.Size = New Size(250, 250)
    End Sub

    Private Sub kryptonDockingManager_FloatingWindowAdding(sender As Object, e As FloatingWindowEventArgs) Handles kryptonDockingManager.FloatingWindowAdding
        ' Set all new floating windows to a larger than default size
        e.FloatingWindow.ClientSize = New Size(400, 400)
    End Sub

    Private Sub kryptonDockingManager_DockspaceCellAdding(sender As Object, e As DockspaceCellEventArgs) Handles kryptonDockingManager.DockspaceCellAdding
        Console.WriteLine("DockspaceCellAdding")

        ' Set the correct appearance of the dockspace cell based on current settings
        UpdateCell(e.CellControl)
    End Sub

    Private Sub kryptonDockingManager_FloatspaceCellAdding(sender As Object, e As FloatspaceCellEventArgs) Handles kryptonDockingManager.FloatspaceCellAdding
        ' Set the correct appearance of the floatspace cell based on current settings
        UpdateCell(e.CellControl)
    End Sub

    Private Sub kryptonDockingManager_ShowPageContextMenu(sender As Object, e As ContextPageEventArgs) Handles kryptonDockingManager.ShowPageContextMenu
        ' Create a set of custom menu items
        Dim customItems = New KryptonContextMenuItems()
        Dim customSeparator = New KryptonContextMenuSeparator()
        Dim customItem1 = New KryptonContextMenuItem("Custom Item 1", AddressOf OnCustomMenuItem)
        Dim customItem2 = New KryptonContextMenuItem("Custom Item 2", AddressOf OnCustomMenuItem)
        customItem1.Tag = e.Page
        customItem2.Tag = e.Page
        customItems.Items.AddRange(New KryptonContextMenuItemBase() {customSeparator, customItem1, customItem2})

        ' Add set of custom items into the provided menu
        e.KryptonContextMenu.Items.Add(customItems)
    End Sub

    Private Sub kryptonDockingManager_ShowWorkspacePageContextMenu(sender As Object, e As ContextPageEventArgs) Handles kryptonDockingManager.ShowWorkspacePageContextMenu
        ' Create a set of custom menu items
        Dim customItems = New KryptonContextMenuItems()
        Dim customSeparator = New KryptonContextMenuSeparator()
        Dim customItem1 = New KryptonContextMenuItem("Custom Item 3", AddressOf OnCustomMenuItem)
        Dim customItem2 = New KryptonContextMenuItem("Custom Item 4", AddressOf OnCustomMenuItem)
        customItem1.Tag = e.Page
        customItem2.Tag = e.Page
        customItems.Items.AddRange(New KryptonContextMenuItemBase() {customSeparator, customItem1, customItem2})

        ' Add set of custom items into the provided menu
        e.KryptonContextMenu.Items.Add(customItems)
    End Sub

    Private Sub OnCustomMenuItem(sender As Object, e As EventArgs)
        Dim menuItem = CType(sender, KryptonContextMenuItem)
        Dim page = CType(menuItem.Tag, KryptonPage)
        MessageBox.Show($"Clicked menu option '{menuItem.Text}' for the page '{page.Text}'.", "Page Context Menu")
    End Sub

    Private Sub colorsRandom_Click(sender As Object, e As EventArgs) Handles colorsRandom.Click
        For Each page As KryptonPage In kryptonDockingManager.Pages
            page.StateNormal.Tab.Content.ShortText.Color1 = RandomColor()
            page.StateNormal.Tab.Back.Color1 = RandomColor()
            page.StateNormal.Tab.Back.ColorStyle = PaletteColorStyle.Solid

            page.StateNormal.RibbonTab.TabDraw.TextColor = RandomColor()
            page.StateNormal.RibbonTab.TabDraw.BackColor1 = RandomColor()
            page.StateNormal.RibbonTab.TabDraw.BackColor2 = RandomColor()

            page.StateNormal.CheckButton.Content.ShortText.Color1 = RandomColor()
            page.StateNormal.CheckButton.Back.Color1 = RandomColor()
            page.StateNormal.CheckButton.Back.ColorStyle = PaletteColorStyle.Solid
        Next
    End Sub

    Private Sub colorsReset_Click(sender As Object, e As EventArgs) Handles colorsReset.Click
        For Each page As KryptonPage In kryptonDockingManager.Pages
            page.StateNormal.Tab.Content.ShortText.Color1 = Color.Empty
            page.StateNormal.Tab.Back.Color1 = Color.Empty
            page.StateNormal.Tab.Back.ColorStyle = PaletteColorStyle.Inherit

            page.StateNormal.RibbonTab.TabDraw.TextColor = Color.Empty
            page.StateNormal.RibbonTab.TabDraw.BackColor1 = Color.Empty
            page.StateNormal.RibbonTab.TabDraw.BackColor2 = Color.Empty

            page.StateNormal.CheckButton.Content.ShortText.Color1 = Color.Empty
            page.StateNormal.CheckButton.Back.Color1 = Color.Empty
            page.StateNormal.CheckButton.Back.ColorStyle = PaletteColorStyle.Inherit
        Next
    End Sub

    Private Sub buttonSpecsAdd_Click(sender As Object, e As EventArgs) Handles buttonSpecsAdd.Click
        For Each page As KryptonPage In kryptonDockingManager.Pages
            ' Create a button spec and make it a random style so we get a random image
            Dim bs = New ButtonSpecAny With {
                .Type = _buttonSpecStyles(_random.Next(_buttonSpecStyles.Length))
            }
            page.ButtonSpecs.Add(bs)
        Next
    End Sub

    Private Sub buttonSpecsClear_Click(sender As Object, e As EventArgs) Handles buttonSpecsClear.Click
        For Each page As KryptonPage In kryptonDockingManager.Pages
            page.ButtonSpecs.Clear()
        Next
    End Sub

    Private Sub kryptonRibbonModeButton_Click(sender As Object, e As EventArgs) Handles modeStackGroup.Click, modeStackHeaderGroup.Click,
        modeBarGroupOutside.Click, modeBarGroupInside.Click, modeTabGroup.Click, modeBarRibbonTabGroup.Click,
        modeHeaderBarGroup.Click, modeHeaderBarHeaderGroup.Click, modeHeaderGroupTab.Click

        ' Extract the navigator mode from the tag field of the ribbon button
        Dim button = CType(sender, KryptonRibbonGroupButton)
        _mode = CType([Enum].Parse(GetType(NavigatorMode), CStr(button.Tag)), NavigatorMode)

        UpdateModeButtons()
        UpdateAllCells()
    End Sub

    Private Sub UpdateModeButtons()
        modeHeaderGroupTab.Checked = (_mode = NavigatorMode.HeaderGroupTab)
        modeHeaderBarHeaderGroup.Checked = (_mode = NavigatorMode.HeaderBarCheckButtonHeaderGroup)
        modeHeaderBarGroup.Checked = (_mode = NavigatorMode.HeaderBarCheckButtonGroup)
        modeTabGroup.Checked = (_mode = NavigatorMode.BarTabGroup)
        modeBarGroupInside.Checked = (_mode = NavigatorMode.BarCheckButtonGroupInside)
        modeBarGroupOutside.Checked = (_mode = NavigatorMode.BarCheckButtonGroupOutside)
        modeBarRibbonTabGroup.Checked = (_mode = NavigatorMode.BarRibbonTabGroup)
        modeStackGroup.Checked = (_mode = NavigatorMode.StackCheckButtonGroup)
        modeStackHeaderGroup.Checked = (_mode = NavigatorMode.StackCheckButtonHeaderGroup)
    End Sub

    Private Sub UpdateAllCells()
        For Each cell As KryptonWorkspaceCell In kryptonDockingManager.CellsDocked
            UpdateCell(cell)
        Next

        For Each cell As KryptonWorkspaceCell In kryptonDockingManager.CellsFloating
            UpdateCell(cell)
        Next
    End Sub

    Private Sub UpdateCell(cell As KryptonWorkspaceCell)
        cell.NavigatorMode = _mode
    End Sub

    Private Function RandomColor() As Color
        Return Color.FromArgb(_random.Next(255), _random.Next(255), _random.Next(255))
    End Function

    Private Sub kryptonContextMenuItem1_Click(sender As Object, e As EventArgs) Handles kryptonContextMenuItem1.Click
        Close()
    End Sub

End Class
