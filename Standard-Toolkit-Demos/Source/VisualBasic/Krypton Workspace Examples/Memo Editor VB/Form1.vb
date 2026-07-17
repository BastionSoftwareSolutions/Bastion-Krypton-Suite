#Region "BSD License"
'
' Original BSD 3-Clause License (https://github.com/ComponentFactory/Krypton/blob/master/LICENSE)
'  © Component Factory Pty Ltd, 2006 - 2016, (Version 4.5.0.0) All rights reserved.
'
'  New BSD 3-Clause License (https://github.com/Krypton-Suite/Standard-Toolkit/blob/master/LICENSE)
'  Modifications by Peter Wagner(aka Wagnerp) & Simon Coghlan(aka Smurf-IV), et al. 2017 - 2024. All rights reserved.
'
' VB.NET twin of Source\Krypton Workspace Examples\Memo Editor\Form1.cs (Bastion Phase 4c).
#End Region

Imports System
Imports System.Collections.Generic
Imports System.IO
Imports System.Windows.Forms

Imports Krypton.Navigator
Imports Krypton.Ribbon
Imports Krypton.Toolkit
Imports Krypton.Workspace

Imports Microsoft.Win32

Public Class MemoEditorForm

#Region "Static Fields"
    Private Shared ReadOnly _maxRecentDocs As Integer = 9
    Private Shared ReadOnly _memoEditorPath As String = "Software\Component Factory\Krypton\MemoEditor"
#End Region

#Region "Instance Fields"
    Private _count As Integer = 1
    Private _cellMode As NavigatorMode
    Private _paletteButtons As KryptonRibbonGroupButton()
    Private _groupingButtons As KryptonRibbonGroupButton()
#End Region

#Region "Identity"
    Public Sub New()
        InitializeComponent()

        _paletteButtons = New KryptonRibbonGroupButton() {button2010Blue, button2010Silver, button2010Black,
                                                          button2007Blue, button2007Silver, button2007Black,
                                                          buttonSparkleBlue, buttonSparkleOrange, buttonSparklePurple,
                                                          buttonSystem, button2003}

        _groupingButtons = New KryptonRibbonGroupButton() {buttonTabs, buttonRibbonTabs, buttonButtons,
                                                           buttonHeader, buttonHeaderButtons, buttonStack}

        _cellMode = NavigatorMode.BarTabGroup
    End Sub
#End Region

#Region "Form Event Handlers"
    Private Sub MemoEditorForm1_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        ' Try and open the saved settings for memo editor
        Dim memoEditorSettings As RegistryKey = Registry.CurrentUser.OpenSubKey(_memoEditorPath)
        If memoEditorSettings IsNot Nothing Then
            Try
                ' Look for each of the maximum number of entries
                For i = 1 To _maxRecentDocs
                    ' If we managed to get an entry
                    Dim filename = TryCast(memoEditorSettings.GetValue(i.ToString()), String)
                    If Not String.IsNullOrEmpty(filename) Then
                        Dim recentDoc = New KryptonRibbonRecentDoc()
                        AddHandler recentDoc.Click, New EventHandler(AddressOf buttonRecentFile_Clicked)
                        recentDoc.Text = filename

                        ' Add to end of the recent docs collection
                        kryptonRibbon.RibbonFileAppButton.AppButtonRecentDocs.Add(recentDoc)
                    End If
                Next
            Catch
            End Try

            Try
                ' Restore the global palette selected previously
                'Dim globalPalette = TryCast(memoEditorSettings.GetValue("GlobalPalette"), String)
                'If Not String.IsNullOrEmpty(globalPalette) Then
                '    kryptonManager.GlobalPaletteMode = CType([Enum].Parse(GetType(PaletteModeManager), globalPalette), PaletteModeManager)
                'End If

                ' Restore the cell mode selected previously
                Dim cellMode = TryCast(memoEditorSettings.GetValue("CellMode"), String)
                If Not String.IsNullOrEmpty(cellMode) Then
                    _cellMode = CType([Enum].Parse(GetType(NavigatorMode), cellMode), NavigatorMode)
                End If
            Catch
            End Try

            memoEditorSettings.Close()
        End If

        ' Add the three predefined memos as content
        buttonReadMe_Click(Nothing, EventArgs.Empty)
        buttonShortcuts_Click(Nothing, EventArgs.Empty)
        buttonPersistence_Click(Nothing, EventArgs.Empty)

        ' Organize them
        buttonGridArrange_Click(Nothing, EventArgs.Empty)

        ' Make the first cell the selected one
        kryptonWorkspace.ActiveCell = kryptonWorkspace.FirstCell()

        UpdateCellsFromGrouping()
        UpdateButtonsFromGrouping()
        UpdateButtonsFromPalette()
        UpdateApplicationTitle()
        UpdateOptions()
    End Sub

    Private Sub MemoEditorForm_FormClosing(sender As Object, e As FormClosingEventArgs) Handles MyBase.FormClosing
        kryptonWorkspace.SuspendLayout()

        ' Search each cell in turn
        Dim cell As KryptonWorkspaceCell = kryptonWorkspace.FirstCell()
        While cell IsNot Nothing
            ' Close each page within the cell (unless it returns the operation has been cancelled)
            For i = cell.Pages.Count - 1 To 0 Step -1
                If CloseMemoPage(cell.Pages(i)) Then
                    kryptonWorkspace.ResumeLayout()
                    e.Cancel = True
                    Return
                End If
            Next

            cell = kryptonWorkspace.NextCell(cell)
        End While

        kryptonWorkspace.ResumeLayout()
    End Sub

    Private Sub MemoEditorForm_FormClosed(sender As Object, e As FormClosedEventArgs) Handles MyBase.FormClosed
        ' Try and open the saved settings for memo editor
        Dim memoEditorSettings As RegistryKey = Registry.CurrentUser.OpenSubKey(_memoEditorPath, True)

        ' If it does not already exist then create it now
        If memoEditorSettings Is Nothing Then
            memoEditorSettings = Registry.CurrentUser.CreateSubKey(_memoEditorPath)
        End If

        ' If we managed to get hold of a valid registry key...
        If memoEditorSettings IsNot Nothing Then
            ' Clear out the existing recent docs contents
            For i = 1 To _maxRecentDocs
                memoEditorSettings.SetValue(i.ToString(), String.Empty, RegistryValueKind.String)
            Next

            ' Set the value for each existing entry
            For i = 0 To kryptonRibbon.RibbonFileAppButton.AppButtonRecentDocs.Count - 1
                memoEditorSettings.SetValue((i + 1).ToString(), kryptonRibbon.RibbonFileAppButton.AppButtonRecentDocs(i).Text, RegistryValueKind.String)
            Next

            ' Save the global palette setting and cell mode
            memoEditorSettings.SetValue("GlobalPalette", kryptonManager.GlobalPaletteMode.ToString(), RegistryValueKind.String)
            memoEditorSettings.SetValue("CellMode", _cellMode.ToString(), RegistryValueKind.String)
            memoEditorSettings.Close()
        End If
    End Sub
#End Region

#Region "Ribbon Event Handlers"
    Private Sub buttonNewMemo_Click(sender As Object, e As EventArgs) Handles appButtonNewMemo.Click, buttonNewMemo.Click
        AddNewMemo()
    End Sub

    Private Sub buttonOpenMemo_Click(sender As Object, e As EventArgs) Handles appButtonOpenMemo.Click, buttonOpenMemo.Click
        ' Did the user select at least one file?
        If openFileDialog.ShowDialog(Me) = DialogResult.OK Then
            ' Get the list of open filenames
            Dim filenames = GetOpenFilenames()

            ' Try and open each file selected in the open dialog box
            For Each file In openFileDialog.FileNames
                ' Only interested in files that are not already loaded
                If filenames.BinarySearch(file) < 0 Then
                    ' Load the file contents and add as a new tab
                    Dim fileInfo = New FileInfo(file)
                    If fileInfo.Exists Then
                        Using reader = New StreamReader(file)
                            AddNewMemo(fileInfo.Name, fileInfo.FullName, reader.ReadToEnd())
                        End Using
                    End If
                End If
            Next
        End If
    End Sub

    Private Sub buttonSaveMemo_Click(sender As Object, e As EventArgs) Handles appButtonSaveMemo.Click, buttonSaveMemo.Click
        ' Save memo at the current page
        If kryptonWorkspace.ActivePage IsNot Nothing Then
            SaveMemoPage(kryptonWorkspace.ActivePage)
        End If
    End Sub

    Private Sub buttonSaveAsMemo_Click(sender As Object, e As EventArgs) Handles appButtonSaveAsMemo.Click, buttonSaveAsMemo.Click
        ' 'Save As' memo at the current page
        If kryptonWorkspace.ActivePage IsNot Nothing Then
            SaveAsMemoPage(kryptonWorkspace.ActivePage)
        End If
    End Sub

    Private Sub buttonSaveAllMemo_Click(sender As Object, e As EventArgs) Handles appButtonSaveAllMemo.Click, buttonSaveAllMemo.Click
        ' Search each cell in turn
        Dim cell As KryptonWorkspaceCell = kryptonWorkspace.FirstCell()
        While cell IsNot Nothing
            ' Save each page within the cell
            For Each page As KryptonPage In cell.Pages
                ' Save the memo in the page
                SaveMemoPage(page)
            Next

            cell = kryptonWorkspace.NextCell(cell)
        End While
    End Sub

    Private Sub buttonCloseMemo_Click(sender As Object, e As EventArgs) Handles appButtonCloseMemo.Click, buttonCloseMemo.Click
        ' Close memo at the current page
        If kryptonWorkspace.ActivePage IsNot Nothing Then
            CloseMemoPage(kryptonWorkspace.ActivePage)
        End If
    End Sub

    Private Sub buttonCloseAllMemo_Click(sender As Object, e As EventArgs) Handles appButtonCloseAllMemo.Click, buttonCloseAllMemo.Click
        kryptonWorkspace.SuspendLayout()

        ' Search each cell in turn
        Dim cell As KryptonWorkspaceCell = kryptonWorkspace.FirstCell()
        While cell IsNot Nothing
            ' Close each page within the cell (unless it returns the operation has been cancelled)
            For i = cell.Pages.Count - 1 To 0 Step -1
                If CloseMemoPage(cell.Pages(i)) Then
                    kryptonWorkspace.ResumeLayout()
                    Return
                End If
            Next

            cell = kryptonWorkspace.NextCell(cell)
        End While

        kryptonWorkspace.ResumeLayout()
    End Sub

    Private Sub buttonSingleGroupArrange_Click(sender As Object, e As EventArgs) Handles buttonSingleGroupArrange.Click
        ' Move all the pages into a single cell
        kryptonWorkspace.ApplySingleCell()
    End Sub

    Private Sub buttonGridArrange_Click(sender As Object, e As EventArgs) Handles buttonGridArrange.Click
        ' Arrange pages into a grid with one page per cell
        kryptonWorkspace.ApplyGridPages(False)
    End Sub

    Private Sub buttonVerticalArrange_Click(sender As Object, e As EventArgs) Handles buttonVerticalArrange.Click
        ' Vertical list is the same as arranging in a vertical grid of 1 element per row
        kryptonWorkspace.ApplyGridPages(False, Orientation.Vertical, 1)
    End Sub

    Private Sub buttonHorizontalArrange_Click(sender As Object, e As EventArgs) Handles buttonHorizontalArrange.Click
        ' Horizontal list is the same as arranging in a horizontal grid of 1 element per column
        kryptonWorkspace.ApplyGridPages(False, Orientation.Horizontal, 1)
    End Sub

    Private Sub buttonReadMe_Click(sender As Object, e As EventArgs) Handles buttonReadMe.Click
        If Not SelectExistingPage("ReadMe") Then
            ' Add a predefined memo with some read me instructions
            AddNewMemo("ReadMe",
                       "Memo Editor uses the Krypton Workspace to organize the document area of the application." & vbLf & vbLf &
                       "Drag the document headers around the workspace to rearrange the layout." & vbLf & vbLf &
                       "Right-click the document headers to access extra workspace options.")
        End If
    End Sub

    Private Sub buttonShortcuts_Click(sender As Object, e As EventArgs) Handles buttonShortcuts.Click
        If Not SelectExistingPage("Shortcuts") Then
            ' Add a predefined memo with a list of the shortcuts
            AddNewMemo("Shortcuts",
                       "Ctrl + Tab" & vbTab & "Focus Next Tab" & vbLf &
                       "Ctrl + Shift + Tab" & vbTab & "Focus Previous Tab" & vbLf & vbLf &
                       "Ctrl + N" & vbTab & vbTab & "New" & vbLf &
                       "Ctrl + O" & vbTab & vbTab & "Open" & vbLf &
                       "Ctrl + S" & vbTab & vbTab & "Save" & vbLf &
                       "Ctrl + Shift + S" & vbTab & "Save All" & vbLf &
                       "Ctrl + Shift + C" & vbTab & "Close" & vbLf & vbLf &
                       "Ctrl + Shift + T" & vbTab & "Single Group Arrange" & vbLf &
                       "Ctrl + Shift + G" & vbTab & "Grid Arrange" & vbLf & vbLf &
                       "Ctrl + Shift + N" & vbTab & "Move Tab to Next Group" & vbLf &
                       "Ctrl + Shift + P" & vbTab & "Move Tab to Previous Group" & vbLf &
                       "Ctrl + Shift + V" & vbTab & "Split Vertical" & vbLf &
                       "Ctrl + Shift + H" & vbTab & "Split Horizontal" & vbLf &
                       "Ctrl + Shift + R" & vbTab & "Rebalance" & vbLf)
        End If
    End Sub

    Private Sub buttonPersistence_Click(sender As Object, e As EventArgs) Handles buttonPersistence.Click
        If Not SelectExistingPage("Persistence") Then
            ' Add a predefined memo with some read me instructions
            AddNewMemo("Persistence",
                       "On exit the list of recent documents is saved into the registry along with the selected palette and selected grouping mode." &
                       "This makes it easy to carry on from where you left off.")
        End If
    End Sub

    Private Function SelectExistingPage(filename As String) As Boolean
        ' Get the list of open filenames
        Dim page As KryptonPage = GetPageForFilename(filename)
        If page IsNot Nothing Then
            ' Select the page and we are done
            Dim cell As KryptonWorkspaceCell = kryptonWorkspace.CellForPage(page)
            cell.SelectedPage = page
            kryptonWorkspace.ActiveCell = cell
            Return True
        End If

        Return False
    End Function

    Private Sub buttonPalette_Clicked(sender As Object, e As EventArgs) Handles button2010Blue.Click, button2010Silver.Click,
        button2010Black.Click, button2007Blue.Click, button2007Silver.Click, button2007Black.Click,
        buttonSparkleBlue.Click, buttonSparkleOrange.Click, buttonSparklePurple.Click, buttonSystem.Click, button2003.Click

        ' The tag property of the button is the enum string value of the palette we want
        Dim button = CType(sender, KryptonRibbonGroupButton)
        kryptonManager.GlobalPaletteMode = ThemeManager.GetThemeManagerMode(CStr(button.Tag))
        UpdateButtonsFromPalette()
    End Sub

    Private Sub buttonGrouping_Click(sender As Object, e As EventArgs) Handles buttonTabs.Click, buttonRibbonTabs.Click,
        buttonButtons.Click, buttonHeader.Click, buttonHeaderButtons.Click, buttonStack.Click

        ' Cache the new mode setting
        Dim button = CType(sender, KryptonRibbonGroupButton)
        _cellMode = CType([Enum].Parse(GetType(NavigatorMode), CStr(button.Tag)), NavigatorMode)
        UpdateCellsFromGrouping()
        UpdateButtonsFromGrouping()
    End Sub

    Private Sub buttonRecentFile_Clicked(sender As Object, e As EventArgs)
        ' Always remove the selected entry, we only put it back if we find it is valid
        Dim recentDoc = CType(sender, KryptonRibbonRecentDoc)
        kryptonRibbon.RibbonFileAppButton.AppButtonRecentDocs.Remove(recentDoc)

        ' Get the existing page that contains the selected filename
        Dim page As KryptonPage = GetPageForFilename(recentDoc.Text)
        If page IsNot Nothing Then
            ' Make this the top most 'recent doc' entry
            kryptonRibbon.RibbonFileAppButton.AppButtonRecentDocs.Insert(0, recentDoc)

            ' Select the page and we are done
            Dim cell As KryptonWorkspaceCell = kryptonWorkspace.CellForPage(page)
            cell.SelectedPage = page
            kryptonWorkspace.ActiveCell = cell
            Return
        End If

        ' If we get here then we need to try and load the document
        Dim fileInfo = New FileInfo(recentDoc.Text)
        If fileInfo.Exists Then
            Using reader = New StreamReader(fileInfo.FullName)
                ' Make this the top most 'recent doc' entry
                kryptonRibbon.RibbonFileAppButton.AppButtonRecentDocs.Insert(0, recentDoc)

                ' Add contents of the file as a new page associated with the file
                AddNewMemo(fileInfo.Name, fileInfo.FullName, reader.ReadToEnd())
            End Using
        End If
    End Sub

    Private Sub buttonSpecExit_Click(sender As Object, e As EventArgs) Handles buttonSpecExit.Click
        Close()
    End Sub
#End Region

#Region "Workspace Event Handlers"
    Private Sub kryptonWorkspace_WorkspaceCellAdding(sender As Object, e As WorkspaceCellEventArgs) Handles kryptonWorkspace.WorkspaceCellAdding
        ' Do not show any navigator level buttons
        'e.Cell.Button.CloseButtonDisplay = ButtonDisplay.Hide
        'e.Cell.Button.ButtonDisplayLogic = ButtonDisplayLogic.None
        e.Cell.Button.CloseButtonAction = CloseButtonAction.RemovePageAndDispose

        ' Do not need the secondary header for header modes
        e.Cell.Header.HeaderVisibleSecondary = False
    End Sub

    Private Sub kryptonWorkspace_ActivePageChanged(sender As Object, e As ActivePageChangedEventArgs) Handles kryptonWorkspace.ActivePageChanged
        ' Change in active page requires we update button/form state
        UpdateApplicationTitle()
        UpdateOptions()
    End Sub

    Private Sub kryptonWorkspace_ActiveCellChanged(sender As Object, e As ActiveCellChangedEventArgs) Handles kryptonWorkspace.ActiveCellChanged
        ' Ensure all but the newly selected cell have a lower profile appearance
        Dim cell As KryptonWorkspaceCell = kryptonWorkspace.FirstCell()
        While cell IsNot Nothing
            If e.NewCell IsNot cell Then
                cell.Bar.TabStyle = TabStyle.StandardProfile
            End If

            cell = kryptonWorkspace.NextCell(cell)
        End While

        ' Ensure the newly selected cell has a higher profile appearance
        If e.NewCell IsNot Nothing Then
            e.NewCell.Bar.TabStyle = TabStyle.HighProfile
        End If
    End Sub

    Private Sub kryptonCell_PageCloseAction(sender As Object, e As CloseActionEventArgs)
        ' Tell the cell instance to not perform any actions with the page, we will remove it if we need to
        ' NOTE: mirrors the upstream demo, which assigns e.Action twice in succession and never wires this handler.
        e.Action = CloseButtonAction.None
        e.Action = CloseButtonAction.RemovePageAndDispose

        ' Use our own routine to close the page, so user is asked to save changes if required
        CloseMemoPage(e.Item)
    End Sub
#End Region

#Region "RichTextBox Event Handlers"
    Private Sub kryptonRichTextBox_TextChanged(sender As Object, e As EventArgs)
        ' Find the page from the sender reference
        Dim rtb = CType(sender, KryptonRichTextBox)
        Dim page = CType(rtb.Tag, KryptonPage)

        ' If the page is not already marked as modified
        If Not page.Text.EndsWith("*") Then
            ' Mark as modified by adding a star to end of text name
            page.Text = $"{page.Text}*"
            page.TextTitle = $"{page.TextTitle}*"
            page.TextDescription = $"{page.TextDescription}*"

            ' Change in page requires we update button/form state
            UpdateApplicationTitle()
            UpdateOptions()
        End If
    End Sub
#End Region

#Region "Implementation"
    Private Function CreateNewMemo() As KryptonPage
        ' Create what we hope is a unique name for the new memo
        Dim name = $"Untitled{_count}"
        _count += 1
        Return CreateNewMemo(name, name, String.Empty, False)
    End Function

    Private Function CreateNewMemo(text As String,
                                   description As String,
                                   memo As String,
                                   loaded As Boolean) As KryptonPage
        ' Define page name and images
        Dim page = New KryptonPage()
        page.Text = text
        page.TextTitle = description
        page.TextDescription = description
        page.ImageSmall = My.Resources.note16
        page.ImageMedium = My.Resources.note24
        page.ImageLarge = My.Resources.note32

        ' Place border between page and internal controls
        page.Padding = New Padding(5)

        ' Use the tag to remember if the page was loaded or is new
        page.Tag = loaded

        ' Create a close button for the page
        Dim bsa = New ButtonSpecAny()
        bsa.Tag = page
        bsa.Type = PaletteButtonSpecStyle.Close
        AddHandler bsa.Click, New EventHandler(AddressOf OnClosePage)
        page.ButtonSpecs.Add(bsa)

        ' We use the rich text box as the memo editor
        Dim rtb = New KryptonRichTextBox()
        rtb.StateCommon.Border.Draw = InheritBool.False
        rtb.Dock = DockStyle.Fill
        rtb.Text = memo
        rtb.Tag = page

        ' Need to know when the user makes a change to the memo text
        AddHandler rtb.TextChanged, New EventHandler(AddressOf kryptonRichTextBox_TextChanged)

        ' Add rich text box as content
        page.Controls.Add(rtb)

        Return page
    End Function

    Private Sub OnClosePage(sender As Object, e As EventArgs)
        ' Find the page this button is contained within
        Dim bsa = CType(sender, ButtonSpecAny)

        ' Close the page
        CloseMemoPage(CType(bsa.Tag, KryptonPage))
    End Sub

    Private Sub AddNewMemo()
        ' Create a new blank memo page
        Dim newPage As KryptonPage = CreateNewMemo()

        ' Add page into the currently active workspace cell
        kryptonWorkspace.ActiveCell.Pages.Add(newPage)
        kryptonWorkspace.ActiveCell.SelectedPage = newPage
    End Sub

    Private Sub AddNewMemo(name As String, memo As String)
        AddNewMemo(name, name, memo, False)
    End Sub

    Private Sub AddNewMemo(name As String, path As String, memo As String)
        AddNewMemo(name, path, memo, True)
    End Sub

    Private Sub AddNewMemo(name As String, path As String, memo As String, loaded As Boolean)
        ' Create a new blank memo page
        Dim newPage As KryptonPage = CreateNewMemo(name, path, memo, loaded)

        ' Add page into the currently active workspace cell
        kryptonWorkspace.ActiveCell.Pages.Add(newPage)
        kryptonWorkspace.ActiveCell.SelectedPage = newPage

        ' Is the new memo loaded from a file?
        If loaded Then
            AddRecentFile(path)
        End If
    End Sub

    Private Sub SaveMemoPage(page As KryptonPage)
        ' We must have a page to actually save
        If page IsNot Nothing Then
            ' If the page is not associated with a file then 'Save As'
            If Not CBool(page.Tag) Then
                SaveAsMemoPage(page)
            Else
                ' The page must be dirty and so in need of saving
                If page.Text.EndsWith("*") Then
                    ' Get access to the contained rich text box
                    Dim rtb = CType(page.Controls(0), KryptonRichTextBox)

                    ' Write out the contents to the file
                    Dim fileInfo = New FileInfo(page.TextDescription.TrimEnd("*"c))
                    Using fileStream = New FileStream(fileInfo.FullName, FileMode.Create, FileAccess.Write)
                        Using streamWriter = New StreamWriter(fileStream)
                            streamWriter.Write(rtb.Text)
                        End Using
                    End Using

                    ' Remove the dirty flag on the file
                    page.Text = page.Text.TrimEnd("*"c)
                    page.TextTitle = page.TextTitle.TrimEnd("*"c)
                    page.TextDescription = page.TextDescription.TrimEnd("*"c)

                    UpdateApplicationTitle()
                    UpdateOptions()
                End If
            End If
        End If
    End Sub

    Private Sub SaveAsMemoPage(page As KryptonPage)
        ' We must have a page to actually save
        If page IsNot Nothing Then
            ' Set the directory/filename into the dialog box
            Dim extractInfo = New FileInfo(page.TextDescription.TrimEnd("*"c))
            saveFileDialog.FileName = extractInfo.Name
            ' NOTE: mirrors the upstream demo, which only assigns InitialDirectory when DirectoryName is empty.
            If String.IsNullOrEmpty(extractInfo.DirectoryName) Then
                saveFileDialog.InitialDirectory = extractInfo.DirectoryName
            End If

            ' If the user entered a valid filename for saving
            If saveFileDialog.ShowDialog(Me) = DialogResult.OK Then
                ' Get access to the contained rich text box
                Dim rtb = CType(page.Controls(0), KryptonRichTextBox)

                ' Write out the contents to the file
                Dim fileInfo = New FileInfo(saveFileDialog.FileName)
                Using fileStream As FileStream = fileInfo.OpenWrite()
                    Using streamWriter = New StreamWriter(fileStream)
                        streamWriter.Write(rtb.Text)
                    End Using
                End Using

                ' Remove the dirty flag on the file
                page.Text = fileInfo.Name
                page.TextTitle = fileInfo.Name
                page.TextDescription = fileInfo.FullName

                ' Mark the page as associated with a file
                page.Tag = True

                ' Add the new filename to the recent docs list
                AddRecentFile(fileInfo.FullName)

                UpdateApplicationTitle()
                UpdateOptions()
            End If
        End If
    End Sub

    Private Function CloseMemoPage(page As KryptonPage) As Boolean
        ' We must have a page to actually close
        If page IsNot Nothing Then
            ' If the page is dirty then we need to ask if it should be saved
            If page.Text.EndsWith("*") Then
                Select Case MessageBox.Show($"Do you want to save changes to '{page.Text.TrimEnd("*"c)}' ?",
                                            "Memo Editor", MessageBoxButtons.YesNoCancel)
                    Case DialogResult.Cancel
                        ' Returning true indicates the operation was cancelled
                        Return True
                    Case DialogResult.Yes
                        SaveMemoPage(page)
                    Case DialogResult.No
                End Select
            End If

            ' Remove the page from the containing cell
            Dim cell As KryptonWorkspaceCell = kryptonWorkspace.CellForPage(page)
            cell.Pages.Remove(page)
            page.Dispose()

            UpdateApplicationTitle()
            UpdateOptions()
        End If

        ' Returning false indicates the operation was not cancelled
        Return False
    End Function

    Private Function GetOpenFilenames() As List(Of String)
        Dim filenames = New List(Of String)()

        ' Scan all cells
        Dim cell As KryptonWorkspaceCell = kryptonWorkspace.FirstCell()
        While cell IsNot Nothing
            ' Scan all pages in the cell
            For Each page As KryptonPage In cell.Pages
                ' If the contents come from a file
                If CBool(page.Tag) Then
                    filenames.Add(page.TextDescription.TrimEnd("*"c))
                End If
            Next

            cell = kryptonWorkspace.NextCell(cell)
        End While

        Return filenames
    End Function

    Private Function GetPageForFilename(filename As String) As KryptonPage
        ' Scan all cells
        Dim cell As KryptonWorkspaceCell = kryptonWorkspace.FirstCell()
        While cell IsNot Nothing
            ' Scan all pages in the cell
            For Each page As KryptonPage In cell.Pages
                ' Look for the matching filename
                If page.TextDescription.TrimEnd("*"c).Equals(filename) Then
                    Return page
                End If
            Next

            cell = kryptonWorkspace.NextCell(cell)
        End While

        Return Nothing
    End Function

    Private Sub AddRecentFile(filename As String)
        ' Search for an existing entry for that filename
        Dim recentDoc As KryptonRibbonRecentDoc = Nothing
        For Each entry As KryptonRibbonRecentDoc In kryptonRibbon.RibbonFileAppButton.AppButtonRecentDocs
            If entry.Text.Equals(filename) Then
                recentDoc = entry
                Exit For
            End If
        Next

        ' If no existing entry then create a new one
        If recentDoc Is Nothing Then
            recentDoc = New KryptonRibbonRecentDoc()
            AddHandler recentDoc.Click, New EventHandler(AddressOf buttonRecentFile_Clicked)
            recentDoc.Text = filename
        End If

        ' Remove entry from current list and insert at the top
        kryptonRibbon.RibbonFileAppButton.AppButtonRecentDocs.Remove(recentDoc)
        kryptonRibbon.RibbonFileAppButton.AppButtonRecentDocs.Insert(0, recentDoc)

        ' Restrict list to just 9 entries
        If kryptonRibbon.RibbonFileAppButton.AppButtonRecentDocs.Count > _maxRecentDocs Then
            For i = kryptonRibbon.RibbonFileAppButton.AppButtonRecentDocs.Count To _maxRecentDocs + 1 Step -1
                kryptonRibbon.RibbonFileAppButton.AppButtonRecentDocs.RemoveAt(kryptonRibbon.RibbonFileAppButton.AppButtonRecentDocs.Count - 1)
            Next
        End If
    End Sub

    Private Sub UpdateCellsFromGrouping()
        Dim cell As KryptonWorkspaceCell = kryptonWorkspace.FirstCell()
        While cell IsNot Nothing
            cell.NavigatorMode = _cellMode
            cell = kryptonWorkspace.NextCell(cell)
        End While
    End Sub

    Private Sub UpdateButtonsFromGrouping()
        ' Get the string representation of the cell mode
        Dim cellMode = _cellMode.ToString()

        ' Check the palette button that matches the cell mode
        For Each button As KryptonRibbonGroupButton In _groupingButtons
            button.Checked = button.Tag.ToString().Equals(cellMode)
        Next
    End Sub

    Private Sub UpdateButtonsFromPalette()
        ' Get the string representation of the global palette
        Dim mode = kryptonManager.GlobalPaletteMode.ToString()

        ' Check the palette button that matches the global palette
        For Each button As KryptonRibbonGroupButton In _paletteButtons
            button.Checked = button.Tag.ToString().Equals(mode)
        Next
    End Sub

    Private Sub UpdateApplicationTitle()
        ' Always prefix with application name
        Dim title = "Memo Editor"

        ' If we have an active page then append that memo name
        If kryptonWorkspace.ActivePage IsNot Nothing Then
            title &= $" - {kryptonWorkspace.ActivePage.TextDescription}"
        End If

        Text = title
    End Sub

    Private Sub UpdateOptions()
        Dim activePage = (kryptonWorkspace.ActivePage IsNot Nothing)
        buttonSaveMemo.Enabled = activePage
        appButtonSaveMemo.Enabled = buttonSaveMemo.Enabled
        buttonSaveAsMemo.Enabled = activePage
        appButtonSaveAsMemo.Enabled = buttonSaveAsMemo.Enabled
        buttonSaveAllMemo.Enabled = activePage
        appButtonSaveAllMemo.Enabled = buttonSaveAllMemo.Enabled
        buttonCloseMemo.Enabled = activePage
        appButtonCloseMemo.Enabled = buttonCloseMemo.Enabled
        buttonCloseAllMemo.Enabled = activePage
        appButtonCloseAllMemo.Enabled = buttonCloseAllMemo.Enabled
    End Sub
#End Region

End Class
