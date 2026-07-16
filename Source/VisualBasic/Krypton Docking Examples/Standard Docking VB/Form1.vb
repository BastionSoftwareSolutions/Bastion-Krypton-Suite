#Region "BSD License"
'
' Original BSD 3-Clause License (https://github.com/ComponentFactory/Krypton/blob/master/LICENSE)
'  © Component Factory Pty Ltd, 2006 - 2016, (Version 4.5.0.0) All rights reserved.
'
'  New BSD 3-Clause License (https://github.com/Krypton-Suite/Standard-Toolkit/blob/master/LICENSE)
'  Modifications by Peter Wagner(aka Wagnerp) & Simon Coghlan(aka Smurf-IV), et al. 2017 - 2024. All rights reserved.
'
' VB.NET twin of Source\Krypton Docking Examples\Standard Docking\Form1.cs (Bastion Phase 4c).
#End Region

Imports System
Imports System.ComponentModel
Imports System.Drawing
Imports System.Windows.Forms

Imports Krypton.Docking
Imports Krypton.Navigator
Imports Krypton.Toolkit
Imports Krypton.Workspace

Public Class Form1

    Private _count As Integer = 1
    Private _props3 As KryptonPage

    Private Function NewDocument() As KryptonPage
        Dim page As KryptonPage = NewPage("Document ", 0, New ContentDocument())

        ' Document pages cannot be docked or auto hidden
        page.ClearFlags(KryptonPageFlags.DockingAllowAutoHidden Or KryptonPageFlags.DockingAllowDocked)

        Return page
    End Function

    Private Function NewInput() As KryptonPage
        Return NewPage("Input ", 1, New ContentInput(), Nothing)
    End Function

    Private Function NewPropertyGrid() As KryptonPage
        Return NewPage("Properties ", 2, New ContentPropertyGrid(), New Size(300, 300))
    End Function

    Private Function NewPage(name As String, image As Integer, content As Control, Optional autoHiddenSizeHint As Size? = Nothing) As KryptonPage
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
        If autoHiddenSizeHint.HasValue Then
            p.AutoHiddenSlideSize = autoHiddenSizeHint.Value
        End If
        Return p
    End Function

    Private Sub Form1_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        ' Setup docking functionality
        Dim w As KryptonDockingWorkspace = kryptonDockingManager.ManageWorkspace(kryptonDockableWorkspace)
        kryptonDockingManager.ManageControl(kryptonPanel, w)
        kryptonDockingManager.ManageFloating(Me)

        ' Add initial docking pages
        kryptonDockingManager.AddToWorkspace("Workspace", {NewDocument(), NewDocument()})
        _props3 = NewPropertyGrid()
        kryptonDockingManager.AddDockspace("Control", DockingEdge.Right, {_props3, NewInput()})
        kryptonDockingManager.AddDockspace("Control", DockingEdge.Bottom, {NewInput(), NewPropertyGrid()})

        ' Set correct initial ribbon palette buttons
        UpdatePaletteButtons()
    End Sub

    Private Sub buttonDocumentSingle_Click(sender As Object, e As EventArgs) Handles buttonDocumentSingle.Click
        ' Get access to current active cell or create new cell if none are present
        Dim cell As KryptonWorkspaceCell = kryptonDockableWorkspace.ActiveCell
        If cell Is Nothing Then
            cell = New KryptonWorkspaceCell()
            kryptonDockableWorkspace.Root.Children.Add(cell)
        End If

        ' Create new document to be added into workspace
        Dim page As KryptonPage = NewDocument()
        cell.Pages.Add(page)

        ' Make the new page the selected page
        cell.SelectedPage = page
    End Sub

    Private Sub buttonDocumentTabbed_Click(sender As Object, e As EventArgs) Handles buttonDocumentTabbed.Click
        ' Add a new cell with three pages into the root sequence of the workspace
        Dim cell = New KryptonWorkspaceCell()
        cell.Pages.AddRange({NewDocument(), NewDocument(), NewDocument()})
        kryptonDockableWorkspace.Root.Children.Add(cell)
    End Sub

    Private Sub buttonFloatingSingle_Click(sender As Object, e As EventArgs) Handles buttonFloatingSingle.Click
        ' Add a new floating window with a single page
        kryptonDockingManager.AddFloatingWindow("Floating", {NewInput()})
    End Sub

    Private Sub buttonFloatingTabbed_Click(sender As Object, e As EventArgs) Handles buttonFloatingTabbed.Click
        ' Add a new floating window with two pages
        kryptonDockingManager.AddFloatingWindow("Floating", {NewPropertyGrid(), NewDocument()})
    End Sub

    Private Sub buttonFloatingComplex_Click(sender As Object, e As EventArgs) Handles buttonFloatingComplex.Click
        ' Add single page to a new floating window
        Dim window As KryptonDockingFloatingWindow = kryptonDockingManager.AddFloatingWindow("Floating",
                                                                                             {NewInput()},
                                                                                             New Size(500, 400))

        ' Create a sequence that contains two cells, with a page in each cell
        Dim seq = New KryptonWorkspaceSequence(Orientation.Vertical)
        Dim cell1 = New KryptonWorkspaceCell()
        Dim cell2 = New KryptonWorkspaceCell()
        seq.Children.AddRange(New Component() {cell1, cell2})
        cell1.Pages.Add(NewPropertyGrid())
        cell2.Pages.Add(NewDocument())

        ' Add new sequence into the floating window
        window.FloatspaceElement.FloatspaceControl.Root.Children.Add(seq)
    End Sub

    Private Sub buttonLeftAutoHidden_Click(sender As Object, e As EventArgs) Handles buttonLeftAutoHidden.Click
        ' Add new auto hidden group to left edge of the panel
        kryptonDockingManager.AddAutoHiddenGroup("Control",
            DockingEdge.Left,
            {NewInput(), NewPropertyGrid()})
    End Sub

    Private Sub buttonRightAutoHidden_Click(sender As Object, e As EventArgs) Handles buttonRightAutoHidden.Click
        ' Add new auto hidden group to right edge of the panel
        kryptonDockingManager.AddAutoHiddenGroup("Control",
            DockingEdge.Right,
            {NewInput(), NewPropertyGrid()})
    End Sub

    Private Sub buttonBottomAutoHidden_Click(sender As Object, e As EventArgs) Handles buttonBottomAutoHidden.Click
        ' Add new auto hidden group to bottom edge of the panel
        kryptonDockingManager.AddAutoHiddenGroup("Control",
            DockingEdge.Bottom,
            {NewInput(), NewPropertyGrid(), NewDocument()})
    End Sub

    Private Sub buttonLeftDockedSingle_Click(sender As Object, e As EventArgs) Handles buttonLeftDockedSingle.Click
        ' Add page to left edge of the panel
        kryptonDockingManager.AddDockspace("Control",
            DockingEdge.Left,
            {NewInput()})
    End Sub

    Private Sub buttonLeftDockedTabbed_Click(sender As Object, e As EventArgs) Handles buttonLeftDockedTabbed.Click
        ' Add three tabbed pages to left edge of the panel
        kryptonDockingManager.AddDockspace("Control",
            DockingEdge.Left,
            {NewInput(), NewPropertyGrid(), NewDocument()})
    End Sub

    Private Sub buttonLeftDockedStack_Click(sender As Object, e As EventArgs) Handles buttonLeftDockedStack.Click
        ' Add three vertical-stacked pages to left edge of the panel
        kryptonDockingManager.AddDockspace("Control",
            DockingEdge.Left,
            {NewDocument()},
            {NewDocument()},
            {NewDocument()})
    End Sub

    Private Sub buttonRightDockedSingle_Click(sender As Object, e As EventArgs) Handles buttonRightDockedSingle.Click
        ' Add page to right edge of the panel
        kryptonDockingManager.AddDockspace("Control",
            DockingEdge.Right,
            {NewInput()})
    End Sub

    Private Sub buttonTopDockedTabbed_Click(sender As Object, e As EventArgs) Handles buttonTopDockedTabbed.Click
        ' Add three tabbed pages to top edge of the panel
        kryptonDockingManager.AddDockspace("Control",
            DockingEdge.Top,
            {NewInput(), NewPropertyGrid(), NewDocument()})
    End Sub

    Private Sub buttonBottomDockedStack_Click(sender As Object, e As EventArgs) Handles buttonBottomDockedStack.Click
        ' Add three horizontal-stacked pages to bottom edge of the panel
        kryptonDockingManager.AddDockspace("Control",
            DockingEdge.Bottom,
            {NewDocument()},
            {NewDocument()},
            {NewDocument()})
    End Sub

    Private Sub buttonDeleteAll_Click(sender As Object, e As EventArgs) Handles buttonDeleteAll.Click
        kryptonDockingManager.RemoveAllPages(True)
        kryptonDockingManager.ClearAllStoredPages()
    End Sub

    Private Sub buttonDeleteDocked_Click(sender As Object, e As EventArgs) Handles buttonDeleteDocked.Click
        Dim pages = kryptonDockingManager.PagesDocked
        kryptonDockingManager.RemovePages(pages, True)
        kryptonDockingManager.ClearStoredPages(pages)
    End Sub

    Private Sub buttonDeleteAutoHidden_Click(sender As Object, e As EventArgs) Handles buttonDeleteAutoHidden.Click
        Dim pages = kryptonDockingManager.PagesAutoHidden
        kryptonDockingManager.RemovePages(pages, True)
        kryptonDockingManager.ClearStoredPages(pages)
    End Sub

    Private Sub buttonDeleteFloating_Click(sender As Object, e As EventArgs) Handles buttonDeleteFloating.Click
        Dim pages = kryptonDockingManager.PagesFloating
        kryptonDockingManager.RemovePages(pages, True)
        kryptonDockingManager.ClearStoredPages(pages)
    End Sub

    Private Sub buttonHideAll_Click(sender As Object, e As EventArgs) Handles buttonHideAll.Click
        kryptonDockingManager.HideAllPages()
    End Sub

    Private Sub buttonShowAll_Click(sender As Object, e As EventArgs) Handles buttonShowAll.Click
        kryptonDockingManager.ShowAllPages()
        kryptonDockableWorkspace.ShowAllPages()
    End Sub

    Private Sub button2010Blue_Click(sender As Object, e As EventArgs) Handles button2010Blue.Click
        kryptonManager.GlobalPaletteMode = PaletteMode.Office2010Blue
        UpdatePaletteButtons()
    End Sub

    Private Sub button2010Silver_Click(sender As Object, e As EventArgs) Handles button2010Silver.Click
        kryptonManager.GlobalPaletteMode = PaletteMode.Office2010Silver
        UpdatePaletteButtons()
    End Sub

    Private Sub button2010Black_Click(sender As Object, e As EventArgs) Handles button2010Black.Click
        kryptonManager.GlobalPaletteMode = PaletteMode.Office2010Black
        UpdatePaletteButtons()
    End Sub

    Private Sub button2007Blue_Click(sender As Object, e As EventArgs) Handles button2007Blue.Click
        kryptonManager.GlobalPaletteMode = PaletteMode.Office2007Blue
        UpdatePaletteButtons()
    End Sub

    Private Sub button2007Silver_Click(sender As Object, e As EventArgs) Handles button2007Silver.Click
        kryptonManager.GlobalPaletteMode = PaletteMode.Office2007Silver
        UpdatePaletteButtons()
    End Sub

    Private Sub button2007Black_Click(sender As Object, e As EventArgs) Handles button2007Black.Click
        kryptonManager.GlobalPaletteMode = PaletteMode.Office2007Black
        UpdatePaletteButtons()
    End Sub

    Private Sub buttonSparkleBlue_Click(sender As Object, e As EventArgs) Handles buttonSparkleBlue.Click
        kryptonManager.GlobalPaletteMode = PaletteMode.SparkleBlue
        UpdatePaletteButtons()
    End Sub

    Private Sub buttonSparkleOrange_Click(sender As Object, e As EventArgs) Handles buttonSparkleOrange.Click
        kryptonManager.GlobalPaletteMode = PaletteMode.SparkleOrange
        UpdatePaletteButtons()
    End Sub

    Private Sub buttonSparklePurple_Click(sender As Object, e As EventArgs) Handles buttonSparklePurple.Click
        kryptonManager.GlobalPaletteMode = PaletteMode.SparklePurple
        UpdatePaletteButtons()
    End Sub

    Private Sub buttonSystem_Click(sender As Object, e As EventArgs) Handles buttonSystem.Click
        kryptonManager.GlobalPaletteMode = PaletteMode.ProfessionalSystem
        UpdatePaletteButtons()
    End Sub

    Private Sub kryptonDockableWorkspace_WorkspaceCellAdding(sender As Object, e As WorkspaceCellEventArgs) Handles kryptonDockableWorkspace.WorkspaceCellAdding
        'e.Cell.Button.CloseButtonAction = CloseButtonAction.HidePage
        'e.Cell.Button.CloseButtonAction = CloseButtonAction.RemovePage
        e.Cell.Button.CloseButtonAction = CloseButtonAction.RemovePageAndDispose
    End Sub

    Private Sub UpdatePaletteButtons()
        button2010Blue.Checked = (kryptonManager.GlobalPaletteMode = PaletteMode.Office2010Blue)
        button2010Silver.Checked = (kryptonManager.GlobalPaletteMode = PaletteMode.Office2010Silver)
        button2010Black.Checked = (kryptonManager.GlobalPaletteMode = PaletteMode.Office2010Black)
        button2007Blue.Checked = (kryptonManager.GlobalPaletteMode = PaletteMode.Office2007Blue)
        button2007Silver.Checked = (kryptonManager.GlobalPaletteMode = PaletteMode.Office2007Silver)
        button2007Black.Checked = (kryptonManager.GlobalPaletteMode = PaletteMode.Office2007Black)
        buttonSparkleBlue.Checked = (kryptonManager.GlobalPaletteMode = PaletteMode.SparkleBlue)
        buttonSparkleOrange.Checked = (kryptonManager.GlobalPaletteMode = PaletteMode.SparkleOrange)
        buttonSparklePurple.Checked = (kryptonManager.GlobalPaletteMode = PaletteMode.SparklePurple)
        buttonSystem.Checked = (kryptonManager.GlobalPaletteMode = PaletteMode.ProfessionalSystem)
    End Sub

    Private Sub ribbonAppButtonExit_Click(sender As Object, e As EventArgs) Handles ribbonAppButtonExit.Click
        Close()
    End Sub

    Private Sub btnHideProps3_Click(sender As Object, e As EventArgs) Handles btnHideProps3.Click
        kryptonDockingManager.HidePage(_props3)
    End Sub

    Private Sub btnShowProps3_Click(sender As Object, e As EventArgs) Handles btnShowProps3.Click
        kryptonDockingManager.ShowPage(_props3)
    End Sub

End Class
