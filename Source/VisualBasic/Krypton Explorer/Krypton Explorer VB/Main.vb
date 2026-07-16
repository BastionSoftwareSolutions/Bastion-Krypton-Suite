#Region "BSD License"
'
' Original BSD 3-Clause License (https://github.com/ComponentFactory/Krypton/blob/master/LICENSE)
'  © Component Factory Pty Ltd, 2006 - 2016, (Version 4.5.0.0) All rights reserved.
'
'  New BSD 3-Clause License (https://github.com/Krypton-Suite/Standard-Toolkit/blob/master/LICENSE)
'  Modifications by Peter Wagner(aka Wagnerp) & Simon Coghlan(aka Smurf-IV), et al. 2017 - 2024. All rights reserved.
'
' VB.NET twin of Source\Krypton Explorer\Main.cs (Bastion Phase 4c).
' NOTE (Bastion): this VB twin launches the VB twins of the other samples (assembly
'       names ending in "VB") instead of the C# builds. This is the one intentional
'       behaviour difference from the C# twin.
#End Region

Imports System
Imports System.ComponentModel
Imports System.Diagnostics
Imports System.IO
Imports System.Net
Imports System.Net.Http


'Imports System.Net.Http
Imports System.Windows.Forms

Imports Krypton.Toolkit

Imports KryptonExplorer.Properties

Public Class Main

#Region "Variables"
    Private _settings As New Settings()
    Private _documentationDownloadLocation As String
#End Region

    Public Sub New()
        InitializeComponent()

        kryptonNavigator.SelectedIndex = 0
        kryptonNavigatorToolkit.SelectedIndex = 0
    End Sub

    Private Sub Form1_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Dim fvi As FileVersionInfo =
            FileVersionInfo.GetVersionInfo(
                $"{Path.GetDirectoryName(Application.ExecutablePath)}\Krypton.Toolkit.dll")

        kcmbTheme.SelectedIndex = _settings.ThemeSelectedIndex

        Dim dateBuilt As DateTime = File.GetCreationTime(Me.GetType().Assembly.Location)
        tsslBuildDate.Text = $"Build Date: {dateBuilt.ToShortDateString()}"

        Dim currentVersion As New Version(95, dateBuilt.Year - 2000, dateBuilt.Month, dateBuilt.DayOfYear)

        tslVersion.Text = $"Krypton Explorer Version: {currentVersion} - Toolkit Version: {fvi.FileVersion}"
    End Sub

    Private Sub linkKryptonBorderEdge_LinkClicked(sender As Object, e As EventArgs) Handles linkKryptonBorderEdge.LinkClicked
        LaunchApplication("Krypton Border Edge Examples")
    End Sub

    Private Sub linkKryptonButton_LinkClicked(sender As Object, e As EventArgs) Handles linkKryptonButton.LinkClicked
        LaunchApplication("Krypton Button Examples")
    End Sub

    Private Sub linkKryptonCheckBox_LinkClicked(sender As Object, e As EventArgs) Handles linkKryptonCheckBox.LinkClicked
        LaunchApplication("Krypton CheckBox Examples")
    End Sub

    Private Sub linkKryptonCheckButton_LinkClicked(sender As Object, e As EventArgs) Handles linkKryptonCheckButton.LinkClicked
        LaunchApplication("Krypton CheckButton Examples")
    End Sub

    Private Sub linkKryptonDropButton_LinkClicked(sender As Object, e As EventArgs) Handles linkKryptonDropButton.LinkClicked
        LaunchApplication("Krypton DropButton Examples")
    End Sub

    Private Sub linkKryptonColorButton_LinkClicked(sender As Object, e As EventArgs) Handles linkKryptonColorButton.LinkClicked
        LaunchApplication("Krypton ColorButton Examples")
    End Sub

    Private Sub linkKryptonCheckSet_LinkClicked(sender As Object, e As EventArgs) Handles linkKryptonCheckSet.LinkClicked
        LaunchApplication("Krypton CheckSet Examples")
    End Sub

    Private Sub linkKryptonContextMenu_LinkClicked(sender As Object, e As EventArgs) Handles linkKryptonContextMenu.LinkClicked
        LaunchApplication("Krypton Context Menu Examples")
    End Sub

    Private Sub linkKryptonDataGridView_LinkClicked(sender As Object, e As EventArgs) Handles linkKryptonDataGridView.LinkClicked
        LaunchApplication("Krypton Data GridView Examples")
    End Sub

    Private Sub linkKryptonForm_LinkClicked(sender As Object, e As EventArgs) Handles linkKryptonForm.LinkClicked
        LaunchApplication("Krypton Form Examples")
    End Sub

    Private Sub linkKryptonGroup_LinkClicked(sender As Object, e As EventArgs) Handles linkKryptonGroup.LinkClicked
        LaunchApplication("Krypton Group Examples")
    End Sub

    Private Sub linkKryptonGroupBox_LinkClicked(sender As Object, e As EventArgs) Handles linkKryptonGroupBox.LinkClicked
        LaunchApplication("Krypton GroupBox Examples")
    End Sub

    Private Sub linkKryptonHeader_LinkClicked(sender As Object, e As EventArgs) Handles linkKryptonHeader.LinkClicked
        LaunchApplication("Krypton Header Examples")
    End Sub

    Private Sub linkKryptonHeaderGroup_LinkClicked(sender As Object, e As EventArgs) Handles linkKryptonHeaderGroup.LinkClicked
        LaunchApplication("Krypton Header Group Examples")
    End Sub

    Private Sub linkKryptonLabel_LinkClicked(sender As Object, e As EventArgs) Handles linkKryptonLabel.LinkClicked
        LaunchApplication("Krypton Label Examples")
    End Sub

    Private Sub linkKryptonWrapLabel_LinkClicked(sender As Object, e As EventArgs) Handles linkKryptonWrapLabel.LinkClicked
        LaunchApplication("Krypton Wrap Label Examples")
    End Sub

    Private Sub linkKryptonCommand_LinkClicked(sender As Object, e As EventArgs) Handles linkKryptonCommand.LinkClicked
        LaunchApplication("Krypton Command Examples")
    End Sub

    Private Sub linkKryptonLinkLabel_LinkClicked(sender As Object, e As EventArgs) Handles linkKryptonLinkLabel.LinkClicked
        LaunchApplication("Krypton Link Label Examples")
    End Sub

    Private Sub linkKryptonListBox_LinkClicked(sender As Object, e As EventArgs) Handles linkKryptonListBox.LinkClicked
        LaunchApplication("Krypton ListBox Examples")
    End Sub

    Private Sub linkKryptonCheckedListBox_LinkClicked(sender As Object, e As EventArgs) Handles linkKryptonCheckedListBox.LinkClicked
        LaunchApplication("Krypton Checked ListBox Examples")
    End Sub

    Private Sub linkKryptonMaskedTextBox_LinkClicked(sender As Object, e As EventArgs) Handles linkKryptonMaskedTextBox.LinkClicked
        LaunchApplication("Krypton Masked TextBox Examples")
    End Sub

    Private Sub linkKryptonPalette_LinkClicked(sender As Object, e As EventArgs) Handles linkKryptonPalette.LinkClicked
        LaunchApplication("Krypton Palette Examples")
    End Sub

    Private Sub linkKryptonPanel_LinkClicked(sender As Object, e As EventArgs) Handles linkKryptonPanel.LinkClicked
        LaunchApplication("Krypton Panel Examples")
    End Sub

    Private Sub linkKryptonSeparator_LinkClicked(sender As Object, e As EventArgs) Handles linkKryptonSeparator.LinkClicked
        LaunchApplication("Krypton Separator Examples")
    End Sub

    Private Sub linkKryptonRadioButton_LinkClicked(sender As Object, e As EventArgs) Handles linkKryptonRadioButton.LinkClicked
        LaunchApplication("Krypton RadioButton Examples")
    End Sub

    Private Sub linkKryptonTrackBar_LinkClicked(sender As Object, e As EventArgs) Handles linkKryptobTrackBar.LinkClicked
        LaunchApplication("Krypton TrackBar Examples")
    End Sub

    Private Sub linkKryptonSplitContainer_LinkClicked(sender As Object, e As EventArgs) Handles linkKryptonSplitContainer.LinkClicked
        LaunchApplication("Krypton Split Container Examples")
    End Sub

    Private Sub linkKryptonComboBox_LinkClicked(sender As Object, e As EventArgs) Handles linkKryptonComboBox.LinkClicked
        LaunchApplication("Krypton ComboBox Examples")
    End Sub

    Private Sub linkKryptonTextBox_LinkClicked(sender As Object, e As EventArgs) Handles linkKryptonTextBox.LinkClicked
        LaunchApplication("Krypton TextBox Examples")
    End Sub

    Private Sub linkKryptonRichTextBox_LinkClicked(sender As Object, e As EventArgs) Handles linkKryptonRichTextBox.LinkClicked
        LaunchApplication("Krypton Rich TextBox Examples")
    End Sub

    Private Sub linkKryptonNumericUpDown_LinkClicked(sender As Object, e As EventArgs) Handles linkKryptonNumericUpDown.LinkClicked
        LaunchApplication("Krypton Numeric UpDown Examples")
    End Sub

    Private Sub linkKryptonDomainUpDown_LinkClicked(sender As Object, e As EventArgs) Handles linkKryptonDomainUpDown.LinkClicked
        LaunchApplication("Krypton Domain UpDown Examples")
    End Sub

    Private Sub linkKryptonBreadCrumb_LinkClicked(sender As Object, e As EventArgs) Handles linkKryptonBreadCrumb.LinkClicked
        LaunchApplication("Krypton Bread Crumb Examples")
    End Sub

    Private Sub linkKryptonDateTimePicker_LinkClicked(sender As Object, e As EventArgs) Handles linkDateTimePicker.LinkClicked
        LaunchApplication("Krypton DateTimePicker Examples")
    End Sub

    Private Sub linkKryptonMonthCalendar_LinkClicked(sender As Object, e As EventArgs) Handles linkMonthCalendar.LinkClicked
        LaunchApplication("Krypton Month Calendar Examples")
    End Sub

    Private Sub linkKryptonInputBox_LinkClicked(sender As Object, e As EventArgs) Handles linkKryptonInputBox.LinkClicked
        LaunchApplication("Krypton InputBox Examples")
    End Sub

    Private Sub linkKryptonMessageBox_LinkClicked(sender As Object, e As EventArgs) Handles linkKryptonMessageBox.LinkClicked
        LaunchApplication("Krypton MessageBox Examples")
    End Sub

    Private Sub linkKryptonTaskDialog_LinkClicked(sender As Object, e As EventArgs) Handles linkKryptonTaskDialog.LinkClicked
        LaunchApplication("Krypton TaskDialog Examples")
    End Sub

    Private Sub linkKryptonTreeView_LinkClicked(sender As Object, e As EventArgs) Handles linkKryptonTreeView.LinkClicked
        LaunchApplication("Krypton TreeView Examples")
    End Sub

    Private Sub linkInputForm_LinkClicked(sender As Object, e As EventArgs) Handles linkInputForm.LinkClicked
        LaunchApplication("Input Form Examples")
    End Sub

    Private Sub linkThreePaneApplicationBasic_LinkClicked(sender As Object, e As EventArgs) Handles linkThreePaneApplicationBasic.LinkClicked
        LaunchApplication("Three Pane Application Basic")
    End Sub

    Private Sub linkThreePaneApplicationExtended_LinkClicked(sender As Object, e As EventArgs) Handles linkThreePaneApplicationExtended.LinkClicked
        LaunchApplication("Three Pane Application Extended")
    End Sub

    Private Sub linkMDIApplication_LinkClicked(sender As Object, e As EventArgs) Handles linkMDIApplication.LinkClicked
        LaunchApplication("MDI Application")
    End Sub

    Private Sub linkCustomControlUsingPalettes_LinkClicked(sender As Object, e As EventArgs) Handles linkCustomControlUsingPalettes.LinkClicked
        LaunchApplication("Custom Control Using Palettes")
    End Sub

    Private Sub linkCustomControlUsingRenderers_LinkClicked(sender As Object, e As EventArgs) Handles linkCustomControlUsingRenderers.LinkClicked
        LaunchApplication("Custom Control Using Renderers")
    End Sub

    Private Sub linkExpandingSplitters_LinkClicked(sender As Object, e As EventArgs) Handles linkExpandingHeaderGroupsSplitters.LinkClicked
        LaunchApplication("Expanding Header Groups Splitters Examples")
    End Sub

    Private Sub linkExpandingDockStyle_LinkClicked(sender As Object, e As EventArgs) Handles linkExpandingHeaderGroupsDockStyle.LinkClicked
        LaunchApplication("Expanding Header Groups DockStyle Examples")
    End Sub

    Private Sub linkExpandingHeaderStack_LinkClicked(sender As Object, e As EventArgs) Handles linkExpandingHeaderStack.LinkClicked
        LaunchApplication("Expanding Header Groups Stack Examples")
    End Sub

    Private Sub linkChildControlStack_LinkClicked(sender As Object, e As EventArgs) Handles linkChildControlStack.LinkClicked
        LaunchApplication("Child Control Stack")
    End Sub

    Private Sub linkLabelButtonSpecPlayground_LinkClicked(sender As Object, e As EventArgs) Handles linkLabelButtonSpecPlayground.LinkClicked
        LaunchApplication("Button Spec Playground")
    End Sub

    Private Sub linkNavigatorModes_LinkClicked(sender As Object, e As EventArgs) Handles linkNavigatorModes.LinkClicked
        LaunchApplication("Navigator Modes")
    End Sub

    Private Sub linkNavigatorPalettes_LinkClicked(sender As Object, e As EventArgs) Handles linkNavigatorPalettes.LinkClicked
        LaunchApplication("Navigator Palettes")
    End Sub

    Private Sub linkOrientationAndAlignment_LinkClicked(sender As Object, e As EventArgs) Handles linkOrientationAndAlignment.LinkClicked
        LaunchApplication("Orientation Plus Alignment")
    End Sub

    Private Sub linkSinglelineAndMultiline_LinkClicked(sender As Object, e As EventArgs) Handles linkSinglelineAndMultiline.LinkClicked
        LaunchApplication("Singleline Plus Multiline")
    End Sub

    Private Sub linkTabBorderStyles_LinkClicked(sender As Object, e As EventArgs) Handles linkTabBorderStyles.LinkClicked
        LaunchApplication("Tab Border Styles")
    End Sub

    Private Sub linkNavigatorPopupPages_LinkClicked(sender As Object, e As EventArgs) Handles linkNavigatorPopupPages.LinkClicked
        LaunchApplication("Popup Pages")
    End Sub

    Private Sub linkNavigatorPerTabButtons_LinkClicked(sender As Object, e As EventArgs) Handles linkNavigatorPerTabButtons.LinkClicked
        LaunchApplication("Per Tab Buttons")
    End Sub

    Private Sub linkNavigatorTooltips_LinkClicked(sender As Object, e As EventArgs) Handles linkNavigatorTooltips.LinkClicked
        LaunchApplication("Navigator Tool Tips")
    End Sub

    Private Sub linkNavigatorContextMenus_LinkClicked(sender As Object, e As EventArgs) Handles linkNavigatorContextMenus.LinkClicked
        LaunchApplication("Navigator Context Menus")
    End Sub

    Private Sub linkNavigatorPlayground_LinkClicked(sender As Object, e As EventArgs) Handles linkNavigatorPlayground.LinkClicked
        LaunchApplication("Navigator Playground")
    End Sub

    Private Sub linkContextualTabs_LinkClicked(sender As Object, e As EventArgs) Handles linkContextualTabs.LinkClicked
        LaunchApplication("Contextual Tabs")
    End Sub

    Private Sub linkKeyTipsTabs_LinkClicked(sender As Object, e As EventArgs) Handles linkKeyTipsTabs.LinkClicked
        LaunchApplication("Key Tips And Keyboard Access")
    End Sub

    Private Sub labelAutoShrinkingGroups_LinkClicked(sender As Object, e As EventArgs) Handles linkAutoShrinkingGroups.LinkClicked
        LaunchApplication("Auto Shrinking Groups")
    End Sub

    Private Sub labelQuickAccessToolbar_LinkClicked(sender As Object, e As EventArgs) Handles linkQuickAccessToolbar.LinkClicked
        LaunchApplication("Quick Access Toolbar")
    End Sub

    Private Sub linkRibbonGallery_LinkClicked(sender As Object, e As EventArgs) Handles linkRibbonGallery.LinkClicked
        LaunchApplication("Ribbon Gallery")
    End Sub

    Private Sub linkRibbonToolTips_LinkClicked(sender As Object, e As EventArgs) Handles linkRibbonToolTips.LinkClicked
        LaunchApplication("Ribbon Tool Tips")
    End Sub

    Private Sub linkRibbonControls_LinkClicked(sender As Object, e As EventArgs) Handles linkRibbonControls.LinkClicked
        LaunchApplication("Ribbon Controls")
    End Sub

    Private Sub linkKryptonGallery_LinkClicked(sender As Object, e As EventArgs) Handles linkKryptonGallery.LinkClicked
        LaunchApplication("Krypton Gallery Examples")
    End Sub

    Private Sub linkApplicationMenu_LinkClicked(sender As Object, e As EventArgs) Handles linkApplicationMenu.LinkClicked
        LaunchApplication("Application Menu")
    End Sub

    Private Sub linkOutlookMailClone_LinkClicked(sender As Object, e As EventArgs) Handles linkOutlookMailClone.LinkClicked
        LaunchApplication("Outlook Mail Clone")
    End Sub

    Private Sub linkRibbonAndNavigator_LinkClicked(sender As Object, e As EventArgs) Handles linkNavigatorAndRibbon.LinkClicked, linkRibbonAndNavigator.LinkClicked
        LaunchApplication("Ribbon And Navigator And Workspace")
    End Sub

    Private Sub linkMDIRibbon_LinkClicked(sender As Object, e As EventArgs) Handles linkMDIRibbon.LinkClicked
        LaunchApplication("MDI Ribbon")
    End Sub

    Private Sub linkExpandingPages_LinkClicked(sender As Object, e As EventArgs) Handles linkExpandingPages.LinkClicked
        LaunchApplication("Expanding Pages")
    End Sub

    Private Sub linkNavigatorBasicEvents_LinkClicked(sender As Object, e As EventArgs) Handles linkNavigatorBasicEvents.LinkClicked
        LaunchApplication("Basic Events")
    End Sub

    Private Sub linkNavigatorUserPageCreation_LinkClicked(sender As Object, e As EventArgs) Handles linkNavigatorUserPageCreation.LinkClicked
        LaunchApplication("User Page Creation")
    End Sub

    Private Sub linkNavigatorOneNoteTabs_LinkClicked(sender As Object, e As EventArgs) Handles linkNavigatorOneNoteTabs.LinkClicked
        LaunchApplication("OneNote Tabs")
    End Sub

    Private Sub linkNavigatorOutlookMockup_LinkClicked(sender As Object, e As EventArgs) Handles linkNavigatorOutlookMockup.LinkClicked
        LaunchApplication("Outlook Mockup")
    End Sub

    Private Sub linkWorkspaceCellModes_LinkClicked(sender As Object, e As EventArgs) Handles linkWorkspaceCellModes.LinkClicked
        LaunchApplication("Workspace Cell Modes")
    End Sub

    Private Sub linkWorkspaceCellLayout_LinkClicked(sender As Object, e As EventArgs) Handles linkWorkspaceCellLayout.LinkClicked
        LaunchApplication("Workspace Cell Layout")
    End Sub

    Private Sub linkWorkspacePersistence_LinkClicked(sender As Object, e As EventArgs) Handles linkWorkspacePersistence.LinkClicked
        LaunchApplication("Workspace Persistence")
    End Sub

    Private Sub linkCellMaximizeAndRestore_LinkClicked(sender As Object, e As EventArgs) Handles linkCellMaximizeAndRestore.LinkClicked
        LaunchApplication("Cell Maximize And Restore")
    End Sub

    Private Sub linkBasicPageDragAndDrop_LinkClicked(sender As Object, e As EventArgs) Handles linkBasicPageDragAndDrop.LinkClicked, linkBasicNavigatorDragDrop.LinkClicked
        LaunchApplication("Basic Page Drag And Drop")
    End Sub

    Private Sub linkAdvancedPageDragAndDrop_LinkClicked(sender As Object, e As EventArgs) Handles linkAdvancedPageDragAndDrop.LinkClicked, linkAdvancedNavigatorDragDrop.LinkClicked
        LaunchApplication("Advanced Page Drag And Drop")
    End Sub

    Private Sub memoEditor_Clicked(sender As Object, e As EventArgs) Handles linkWorkspaceMemoEditor.LinkClicked, linkRibbonMemoEditor.LinkClicked
        LaunchApplication("Memo Editor")
    End Sub

    Private Sub linkStandardDocking_LinkClicked(sender As Object, e As EventArgs) Handles linkStandardDocking.LinkClicked
        LaunchApplication("Standard Docking")
    End Sub

    Private Sub linkMultiControlDocking_LinkClicked(sender As Object, e As EventArgs) Handles linkMultiControlDocking.LinkClicked
        LaunchApplication("Multi Control Docking")
    End Sub

    Private Sub linkExternalDragToDocking_LinkClicked(sender As Object, e As EventArgs) Handles linkExternalDragToDocking.LinkClicked
        LaunchApplication("External Drag To Docking")
    End Sub

    Private Sub linkNavigatorAndFloatingWindows_LinkClicked(sender As Object, e As EventArgs) Handles linkNavigatorAndFloatingWindows.LinkClicked, LinkNavigatorAndFloatingWindows2.LinkClicked
        LaunchApplication("Navigator And Floating Windows")
    End Sub

    Private Sub linkDockingPersistence_LinkClicked(sender As Object, e As EventArgs) Handles linkDockingPersistence.LinkClicked
        LaunchApplication("Docking Persistence")
    End Sub

    Private Sub linkDockingFlags_LinkClicked(sender As Object, e As EventArgs) Handles linkDockingFlags.LinkClicked
        LaunchApplication("Docking Flags")
    End Sub

    Private Sub linkDockingCustomized_LinkClicked(sender As Object, e As EventArgs) Handles linkDockingCustomized.LinkClicked
        LaunchApplication("Docking Customized")
    End Sub

    Private Sub kllKryptonScrollBars_LinkClicked(sender As Object, e As EventArgs) Handles kllKryptonScrollBars.LinkClicked
        LaunchApplication("Krypton Scrollbar Examples")
    End Sub

    Private Sub kllKryptonWebBrowser_LinkClicked(sender As Object, e As EventArgs) Handles kllKryptonWebBrowser.LinkClicked
        LaunchApplication("Krypton WebBrowser Example")
    End Sub

    Private Sub kllKryptonHelpIcon_LinkClicked(sender As Object, e As EventArgs) Handles kllKryptonHelpIcon.LinkClicked
        LaunchApplication("Krypton Help Icon Examples")
    End Sub

    Private Sub LaunchApplication(exampleName As String, Optional launchVBTwin As Boolean = True)
        Try
            Cursor = Cursors.AppStarting
            ' NOTE (Bastion): the VB twin launches the "<name>VB.exe" builds of the samples.
            GlobalToolkitUtilities.LaunchProcess($".\{exampleName}{If(launchVBTwin, "VB", String.Empty)}.exe")
        Catch ex As Exception
            KryptonMessageBox.Show(Me, $"Error: {ex.Message}", "Explorer", KryptonMessageBoxButtons.OK,
                KryptonMessageBoxIcon.Error)
        Finally
            Cursor = Cursors.Default
        End Try
    End Sub

    Private Sub LaunchPaletteDesignerApplication()
        Try
            Cursor = Cursors.AppStarting

            ' NOTE: mirrors the upstream demo, which sets the cursor twice in succession.
            Cursor = Cursors.AppStarting
            Dim pathModifier = "..\Krypton Toolkit Palette "
#If NET48 Then
            pathModifier &= "net48"
#ElseIf NET6_0 Then
            pathModifier &= "net60"
#ElseIf NET8_0 Then
            pathModifier &= "net80"
#ElseIf NET9_0 Then
            pathModifier &= "net90"
#ElseIf NET10_0 Then
            pathModifier &= "net100"
#Else
            ' Bastion: no Palette Designer build ships for this TFM; probe the net48 build.
            pathModifier &= "net48"
#End If
            If File.Exists(pathModifier & "\Palette Designer.exe") Then
                LaunchApplication(pathModifier & "\Palette Designer", False)
            Else
                KryptonMessageBox.Show(Me,
                    "The Palette Designer is not currently installed. Please download the latest installation package from:" & vbLf & "https://github.com/Krypton-Suite/Theme-Palettes/releases",
                    "Application Not Installed", KryptonMessageBoxButtons.OK, KryptonMessageBoxIcon.Information)
            End If
        Catch e As Exception
            KryptonMessageBox.Show(Me, e.Message, "Explorer", KryptonMessageBoxButtons.OK, KryptonMessageBoxIcon.Error)
        Finally
            Cursor = Cursors.Default
        End Try
    End Sub

    Private Sub LaunchPaletteUpgradeToolApplication()
        Try
            Cursor = Cursors.AppStarting
            Dim pathModifier = "..\Krypton Toolkit Palette "
#If NET48 Then
            pathModifier &= "net48"
#ElseIf NET6_0 Then
            pathModifier &= "net60"
#ElseIf NET8_0 Then
            pathModifier &= "net80"
#ElseIf NET9_0 Then
            pathModifier &= "net90"
#ElseIf NET10_0 Then
            pathModifier &= "net100"
#Else
            ' Bastion: no Palette Upgrade Tool build ships for this TFM; probe the net48 build.
            pathModifier &= "net48"
#End If
            If File.Exists(pathModifier & "\Palette Upgrade Tool.exe") Then
                LaunchApplication(pathModifier & "\Palette Upgrade Tool", False)
            Else
                KryptonMessageBox.Show(Me,
                    "The Palette Upgrade Tool is not currently installed. Please download the latest installation package from:" & vbLf & "https://github.com/Krypton-Suite/Theme-Palettes/releases",
                    "Application Not Installed", KryptonMessageBoxButtons.OK, KryptonMessageBoxIcon.Information)
            End If
        Catch e As Exception
            KryptonMessageBox.Show(Me, e.Message, "Explorer", KryptonMessageBoxButtons.OK, KryptonMessageBoxIcon.Error)
        Finally
            Cursor = Cursors.Default
        End Try
    End Sub

    Private Sub DownloadFileCompleted(sender As Object, e As AsyncCompletedEventArgs)
        Try
            Dim result As DialogResult = KryptonMessageBox.Show(Me, "Download completed. Install now?",
                "Download Successful",
                KryptonMessageBoxButtons.YesNo, KryptonMessageBoxIcon.Information)

            If result = DialogResult.Yes Then
                Process.Start(_documentationDownloadLocation)
            End If
        Catch exception As Exception
            KryptonMessageBox.Show($"Error: {exception}")
        End Try
    End Sub

    Private Sub DownloadProgressChanged(sender As Object, e As DownloadProgressChangedEventArgs)
        tspbDownloadStatus.Maximum = CInt(e.TotalBytesToReceive) \ 100

        tspbDownloadStatus.Value = CInt(e.BytesReceived) \ 100
    End Sub

    Private Sub kllPropertyGrid_LinkClicked(sender As Object, e As EventArgs) Handles kllPropertyGrid.LinkClicked
        LaunchApplication("Krypton Property Grid Example")
    End Sub

    Private Sub kllblIntegratedToolbar_LinkClicked(sender As Object, e As EventArgs) Handles kllblIntegratedToolbar.LinkClicked
        LaunchApplication("Integrated Toolbar Example")
    End Sub

    Private Sub kllProgressBar_LinkClicked(sender As Object, e As EventArgs) Handles kllProgressBar.LinkClicked
        LaunchApplication("Krypton ProgressBar Examples")
    End Sub

    Private Sub kllKryptonThemeSelector_LinkClicked(sender As Object, e As EventArgs) Handles kllKryptonThemeSelector.LinkClicked
        LaunchApplication("Krypton Theme Selector")
    End Sub

    Private Sub linkKryptonColorDialog_LinkClicked(sender As Object, e As EventArgs) Handles linkKryptonColorDialog.LinkClicked
        LaunchApplication("Krypton Color Dialog Example")
    End Sub

    Private Sub linkKryptonFolderBrowser_LinkClicked(sender As Object, e As EventArgs) Handles linkKryptonFolderBrowser.LinkClicked
        LaunchApplication("KryptonFolderBrowserDialog Example")
    End Sub

    Private Sub linkKryptonFontDialog_LinkClicked(sender As Object, e As EventArgs) Handles linkKryptonFontDialog.LinkClicked
        LaunchApplication("Krypton Font Dialog Example")
    End Sub

    Private Sub linkKryptonListView_LinkClicked(sender As Object, e As EventArgs) Handles linkKryptonListView.LinkClicked
        LaunchApplication("Krypton ListView Examples")
    End Sub

    Private Sub linkKryptonOpenFileDialog_LinkClicked(sender As Object, e As EventArgs) Handles linkKryptonOpenFileDialog.LinkClicked
        LaunchApplication("KryptonOpenFileDialog Example")
    End Sub

    Private Sub linkKryptonPrintDialog_LinkClicked(sender As Object, e As EventArgs) Handles linkKryptonPrintDialog.LinkClicked
        LaunchApplication("Krypton Print Dialog Example")
    End Sub

    Private Sub linkKryptonSaveFileDialog_LinkClicked(sender As Object, e As EventArgs) Handles linkKryptonSaveFileDialog.LinkClicked
        LaunchApplication("KryptonSaveFileDialog Example")
    End Sub

    Private Sub linkKryptonStringCollector_LinkClicked(sender As Object, e As EventArgs) Handles linkKryptonStringCollector.LinkClicked
        LaunchApplication("Krypton String Collection Editor Examples")
    End Sub

    Private Sub linkKryptonTableLayout_LinkClicked(sender As Object, e As EventArgs) Handles linkKryptonTableLayout.LinkClicked
        LaunchApplication("Krypton TableLayoutPanel Examples")
    End Sub

    Private Sub klblKryptonAboutToolkit_LinkClicked(sender As Object, e As EventArgs) Handles klblKryptonAboutToolkit.LinkClicked
        LaunchApplication("Krypton About Toolkit Example")
    End Sub

    Private Sub linkKryptonCommandLinkButton_LinkClicked(sender As Object, e As EventArgs) Handles linkKryptonCommandLinkButton.LinkClicked
        LaunchApplication("Krypton Command Link Button Examples")
    End Sub

    Private Sub linkPaletteDesigner_LinkClicked(sender As Object, e As EventArgs) Handles linkPaletteDesigner.LinkClicked
        LaunchPaletteDesignerApplication()
    End Sub

    Private Sub linkPaletteUpgradeTool_LinkClicked(sender As Object, e As EventArgs) Handles linkPaletteUpgradeTool.LinkClicked
        LaunchPaletteUpgradeToolApplication()
    End Sub

    Private Sub kbtnOpenApplicationPath_Click(sender As Object, e As EventArgs) Handles kbtnOpenApplicationPath.Click
        GlobalToolkitUtilities.LaunchProcess(Application.ExecutablePath) '@"explorer.exe", @"\{Application.ExecutablePath}")
    End Sub

    ' NOTE: the C# twin declares this handler 'async' although every Await inside is commented
    '       out. VB would emit BC42356 for an Async Sub without Await (the current C# compiler
    '       no longer emits CS1998), so the Async modifier is omitted here to keep zero warnings.
    Private Sub bgwDownloadDocumentation_DoWork(sender As Object, e As DoWorkEventArgs)
        'Dim client As New HttpClient()

        Dim client As New WebClient()

        tspbDownloadStatus.Text = $"Downloading: {Path.GetFileName(_documentationDownloadLocation)}"

        If Not String.IsNullOrEmpty(_documentationDownloadLocation) Then
            'Dim downladContent = Await client.GetStreamAsync("https://tinyurl.com/mvksw89c")

            'Using fs = File.Create(_documentationDownladLocation)
            '    downladContent.CopyTo(fs)
            'End Using

            client.DownloadFile("https://tinyurl.com/mvksw89c", _documentationDownloadLocation)
        End If
    End Sub

    Private Sub bgwDownloadDocumentation_ProgressChanged(sender As Object, e As ProgressChangedEventArgs)
        tspbDownloadStatus.Value = e.ProgressPercentage
    End Sub

    Private Sub bgwDownloadDocumentation_RunWorkerCompleted(sender As Object, e As RunWorkerCompletedEventArgs)
        Dim result As DialogResult = KryptonMessageBox.Show(Me, "Download completed. Install now?", "Download Successful",
            KryptonMessageBoxButtons.YesNo, KryptonMessageBoxIcon.Information)

        If result = DialogResult.Yes Then
            Process.Start(_documentationDownloadLocation)
        End If
    End Sub

    Private Sub kbtnLaunchHelp_Click(sender As Object, e As EventArgs) Handles kbtnLaunchHelp.Click
        Try
            If Not String.IsNullOrEmpty(_settings.HelpFileLocation) Then
                If File.Exists(_settings.HelpFileLocation) Then
                    Process.Start(_settings.HelpFileLocation)
                Else
                    Dim locator = New HelpFileLocator()

                    locator.Show()
                End If
            Else
                Dim locator = New HelpFileLocator()

                locator.Show()
            End If
        Catch exc As Exception
            KryptonMessageBox.Show(Me, $"Error: {exc}", "Unexpected Error", KryptonMessageBoxButtons.OK,
                KryptonMessageBoxIcon.Error)
        End Try
    End Sub

    Private Sub kcmbTheme_SelectedIndexChanged(sender As Object, e As EventArgs) Handles kcmbTheme.SelectedIndexChanged
        _settings.ThemeSelectedIndex = kcmbTheme.SelectedIndex

        _settings.Save()
    End Sub

    Private Sub kbtnRestoreTheme_Click(sender As Object, e As EventArgs) Handles kbtnRestoreTheme.Click
        kcmbTheme.SelectedIndex = 33

        _settings.HelpFileLocation = ""

        _settings.Save()
    End Sub

    Private Sub kbtnKryptonToolkitPackage_Click(sender As Object, e As EventArgs) Handles kbtnKryptonToolkitPackage.Click
        Process.Start("https://www.nuget.org/profiles/Krypton_Suite")
    End Sub

    Private Sub kbtnViewLatestReleaseNotes_Click(sender As Object, e As EventArgs) Handles kbtnViewLatestReleaseNotes.Click
        Process.Start("https://github.com/Krypton-Suite/Standard-Toolkit/blob/master/Documents/Changelog/Changelog.md")
    End Sub

    Private Sub kbtnViewLatestCanaryReleaseNotes_Click(sender As Object, e As EventArgs) Handles kbtnViewLatestCanaryReleaseNotes.Click
        Process.Start("https://github.com/Krypton-Suite/Standard-Toolkit/blob/canary/Documents/Changelog/Changelog.md")
    End Sub

    Private Sub kbtnViewLatestNightlyReleaseNotes_Click(sender As Object, e As EventArgs) Handles kbtnViewLatestNightlyReleaseNotes.Click
        Process.Start("https://github.com/Krypton-Suite/Standard-Toolkit/blob/alpha/Documents/Changelog/Changelog.md")
    End Sub

    Private Sub kbtnDownloadLatestDocumentation_Click(sender As Object, e As EventArgs) Handles kbtnDownloadLatestDocumentation.Click
        Dim sfd As New SaveFileDialog() With {
            .Title = "Download documentation installer to:",
            .Filter = "Windows Executables|*.exe",
            .FileName = "Standard Toolkit Documentation Installer"
        }

        If sfd.ShowDialog() = DialogResult.OK Then
            Dim client As New WebClient()

            _documentationDownloadLocation = Path.GetFullPath(sfd.FileName)

            tspbDownloadStatus.Visible = True

            client.DownloadFile("https://tinyurl.com/mvksw89c", _documentationDownloadLocation)

            tspbDownloadStatus.Text = $"Downloading: {Path.GetFileName(_documentationDownloadLocation)}"

            AddHandler client.DownloadProgressChanged, AddressOf DownloadProgressChanged

            AddHandler client.DownloadFileCompleted, AddressOf DownloadFileCompleted
        End If
    End Sub

    Private Sub kryptonWorkspaceRibbonNavigator_LinkClicked(sender As Object, e As EventArgs) Handles kryptonWorkspaceRibbonNavigator.LinkClicked
        LaunchApplication("Ribbon And Navigator And Workspace")
    End Sub

    Private Sub linkKryptonToggleSwitch_LinkClicked(sender As Object, e As EventArgs) Handles linkKryptonToggleSwitch.LinkClicked
        LaunchApplication("Krypton Toggle Switch Examples")
    End Sub

End Class
