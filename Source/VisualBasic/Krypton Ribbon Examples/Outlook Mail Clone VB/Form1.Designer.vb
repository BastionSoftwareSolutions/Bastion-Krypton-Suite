' VB.NET twin of Source\Krypton Ribbon Examples\Outlook Mail Clone\Form1.Designer.cs (Bastion Phase 4c).
<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class Form1
    Inherits Krypton.Toolkit.KryptonForm

    'Form overrides dispose to clean up the component list.
    <System.Diagnostics.DebuggerNonUserCode()>
    Protected Overrides Sub Dispose(disposing As Boolean)
        Try
            If disposing AndAlso components IsNot Nothing Then
                components.Dispose()
            End If
        Finally
            MyBase.Dispose(disposing)
        End Try
    End Sub

    'Required by the Windows Form Designer
    Private components As System.ComponentModel.IContainer

    'NOTE: The following procedure is required by the Windows Form Designer
    'It can be modified using the Windows Form Designer.
    'Do not modify it using the code editor.
    <System.Diagnostics.DebuggerStepThrough()>
    Private Sub InitializeComponent()
        Me.components = New System.ComponentModel.Container()
        Me.panelFill = New Krypton.Toolkit.KryptonPanel()
        Me.tableLayout = New System.Windows.Forms.TableLayoutPanel()
        Me.kryptonLabel1 = New Krypton.Toolkit.KryptonLabel()
        Me.kryptonButton2 = New Krypton.Toolkit.KryptonButton()
        Me.richTextBoxMessage = New Krypton.Toolkit.KryptonRichTextBox()
        Me.richTextBoxSubject = New Krypton.Toolkit.KryptonRichTextBox()
        Me.richTextBoxCc = New Krypton.Toolkit.KryptonRichTextBox()
        Me.richTextBoxTo = New Krypton.Toolkit.KryptonRichTextBox()
        Me.kryptonButton1 = New Krypton.Toolkit.KryptonButton()
        Me.cmsPaste = New Krypton.Toolkit.KryptonContextMenu()
        Me.cmsPasteItems = New Krypton.Toolkit.KryptonContextMenuItems()
        Me.pasteToolStripMenuItem = New Krypton.Toolkit.KryptonContextMenuItem()
        Me.pasteSpecialToolStripMenuItem = New Krypton.Toolkit.KryptonContextMenuItem()
        Me.saveToolStripMenuItem = New Krypton.Toolkit.KryptonContextMenuItem()
        Me.forwardToolStripMenuItem = New Krypton.Toolkit.KryptonContextMenuItem()
        Me.deleteToolStripMenuItem = New Krypton.Toolkit.KryptonContextMenuItem()
        Me.toolStripMenuItem5 = New Krypton.Toolkit.KryptonContextMenuSeparator()
        Me.exitToolStripMenuItem = New Krypton.Toolkit.KryptonContextMenuItem()
        Me.cmsBusinessCards = New Krypton.Toolkit.KryptonContextMenu()
        Me.cmsBusinessCardsItems = New Krypton.Toolkit.KryptonContextMenuItems()
        Me.otherBusinessCardsToolStripMenuItem = New Krypton.Toolkit.KryptonContextMenuItem()
        Me.cmsSignatures = New Krypton.Toolkit.KryptonContextMenu()
        Me.cmsSignaturesItems = New Krypton.Toolkit.KryptonContextMenuItems()
        Me.signaturesToolStripMenuItem = New Krypton.Toolkit.KryptonContextMenuItem()
        Me.cmsFollowUp = New Krypton.Toolkit.KryptonContextMenu()
        Me.cmsFollowUpItems = New Krypton.Toolkit.KryptonContextMenuItems()
        Me.todayToolStripMenuItem1 = New Krypton.Toolkit.KryptonContextMenuItem()
        Me.tomorrowToolStripMenuItem1 = New Krypton.Toolkit.KryptonContextMenuItem()
        Me.thisWeekToolStripMenuItem1 = New Krypton.Toolkit.KryptonContextMenuItem()
        Me.nextWeekToolStripMenuItem1 = New Krypton.Toolkit.KryptonContextMenuItem()
        Me.noDateToolStripMenuItem1 = New Krypton.Toolkit.KryptonContextMenuItem()
        Me.customToolStripMenuItem1 = New Krypton.Toolkit.KryptonContextMenuItem()
        Me.kryptonContextMenuSeparator2 = New Krypton.Toolkit.KryptonContextMenuSeparator()
        Me.addReminderToolStripMenuItem1 = New Krypton.Toolkit.KryptonContextMenuItem()
        Me.clearFlagToolStripMenuItem1 = New Krypton.Toolkit.KryptonContextMenuItem()
        Me.kryptonContextMenuSeparator1 = New Krypton.Toolkit.KryptonContextMenuSeparator()
        Me.flagForRecipientsToolStripMenuItem1 = New Krypton.Toolkit.KryptonContextMenuItem()
        Me.toolStripMenuItem3 = New Krypton.Toolkit.KryptonContextMenuSeparator()
        Me.toolStripMenuItem4 = New Krypton.Toolkit.KryptonContextMenuSeparator()
        Me.cmsSpelling = New Krypton.Toolkit.KryptonContextMenu()
        Me.cmsSpellingItems = New Krypton.Toolkit.KryptonContextMenuItems()
        Me.spellingGrammerToolStripMenuItem = New Krypton.Toolkit.KryptonContextMenuItem()
        Me.researchToolStripMenuItem = New Krypton.Toolkit.KryptonContextMenuItem()
        Me.thesaoursToolStripMenuItem = New Krypton.Toolkit.KryptonContextMenuItem()
        Me.translateToolStripMenuItem = New Krypton.Toolkit.KryptonContextMenuItem()
        Me.translationScreentipToolStripMenuItem = New Krypton.Toolkit.KryptonContextMenuItem()
        Me.setLanguageToolStripMenuItem = New Krypton.Toolkit.KryptonContextMenuItem()
        Me.wordCountToolStripMenuItem = New Krypton.Toolkit.KryptonContextMenuItem()
        Me.clearFlagToolStripMenuItem = New Krypton.Toolkit.KryptonContextMenuItem()
        Me.flagForRecipientsToolStripMenuItem = New Krypton.Toolkit.KryptonContextMenuItem()
        Me.toolStripMenuItem1 = New Krypton.Toolkit.KryptonContextMenuSeparator()
        Me.toolStripMenuItem2 = New Krypton.Toolkit.KryptonContextMenuSeparator()
        Me.cmsFormPublish = New Krypton.Toolkit.KryptonContextMenu()
        Me.cmsFormPublishItems = New Krypton.Toolkit.KryptonContextMenuItems()
        Me.publishFormToolStripMenuItem = New Krypton.Toolkit.KryptonContextMenuItem()
        Me.publishFormAsToolStripMenuItem = New Krypton.Toolkit.KryptonContextMenuItem()
        Me.cmsTable = New Krypton.Toolkit.KryptonContextMenu()
        Me.cmsTableItems = New Krypton.Toolkit.KryptonContextMenuItems()
        Me.insertTableToolStripMenuItem = New Krypton.Toolkit.KryptonContextMenuItem()
        Me.drawTableToolStripMenuItem = New Krypton.Toolkit.KryptonContextMenuItem()
        Me.convertTextToTableToolStripMenuItem = New Krypton.Toolkit.KryptonContextMenuItem()
        Me.excelSpreadsheetToolStripMenuItem = New Krypton.Toolkit.KryptonContextMenuItem()
        Me.quickTablesToolStripMenuItem = New Krypton.Toolkit.KryptonContextMenuItem()
        Me.cmsTextBox = New Krypton.Toolkit.KryptonContextMenu()
        Me.cmsTextBoxItems = New Krypton.Toolkit.KryptonContextMenuItems()
        Me.drawTextBoxToolStripMenuItem = New Krypton.Toolkit.KryptonContextMenuItem()
        Me.saveSelectionToTextBoxGalleryToolStripMenuItem = New Krypton.Toolkit.KryptonContextMenuItem()
        Me.cmsDropCap = New Krypton.Toolkit.KryptonContextMenu()
        Me.cmsDropCapItems = New Krypton.Toolkit.KryptonContextMenuItems()
        Me.dropCapOptionsToolStripMenuItem = New Krypton.Toolkit.KryptonContextMenuItem()
        Me.cmsEquation = New Krypton.Toolkit.KryptonContextMenu()
        Me.cmsEquationItems = New Krypton.Toolkit.KryptonContextMenuItems()
        Me.insertNewEquationToolStripMenuItem = New Krypton.Toolkit.KryptonContextMenuItem()
        Me.saveTextTToolStripMenuItem = New Krypton.Toolkit.KryptonContextMenuItem()
        Me.cmsQuickParts = New Krypton.Toolkit.KryptonContextMenu()
        Me.cmsQuickPartsItems = New Krypton.Toolkit.KryptonContextMenuItems()
        Me.saveSelectionToQuickPartsGalleryToolStripMenuItem = New Krypton.Toolkit.KryptonContextMenuItem()
        Me.cmsSymbol = New Krypton.Toolkit.KryptonContextMenu()
        Me.cmsSymbolItems = New Krypton.Toolkit.KryptonContextMenuItems()
        Me.moreSymbolsToolStripMenuItem = New Krypton.Toolkit.KryptonContextMenuItem()
        Me.cmsShapes = New Krypton.Toolkit.KryptonContextMenu()
        Me.cmsShapesItems = New Krypton.Toolkit.KryptonContextMenuItems()
        Me.newDrawingCanvasToolStripMenuItem = New Krypton.Toolkit.KryptonContextMenuItem()
        Me.cmsThemes = New Krypton.Toolkit.KryptonContextMenu()
        Me.cmsThemesItems = New Krypton.Toolkit.KryptonContextMenuItems()
        Me.resetToThemeFromTemplateToolStripMenuItem = New Krypton.Toolkit.KryptonContextMenuItem()
        Me.moreThemesOnMicrosoftOfficeToolStripMenuItem = New Krypton.Toolkit.KryptonContextMenuItem()
        Me.browseForThemesToolStripMenuItem = New Krypton.Toolkit.KryptonContextMenuItem()
        Me.saveCurrentThemeToolStripMenuItem = New Krypton.Toolkit.KryptonContextMenuItem()
        Me.cmsPageColor = New Krypton.Toolkit.KryptonContextMenu()
        Me.cmsPageColorItems = New Krypton.Toolkit.KryptonContextMenuItems()
        Me.noColorToolStripMenuItem = New Krypton.Toolkit.KryptonContextMenuItem()
        Me.kryptonContextMenuSeparator3 = New Krypton.Toolkit.KryptonContextMenuSeparator()
        Me.moreColorsToolStripMenuItem = New Krypton.Toolkit.KryptonContextMenuItem()
        Me.fillEffectsToolStripMenuItem = New Krypton.Toolkit.KryptonContextMenuItem()
        Me.toolStripMenuItem6 = New Krypton.Toolkit.KryptonContextMenuSeparator()
        Me.cmsUseVotingButtons = New Krypton.Toolkit.KryptonContextMenu()
        Me.cmsUseVotingButtonsItems = New Krypton.Toolkit.KryptonContextMenuItems()
        Me.approveRejectToolStripMenuItem = New Krypton.Toolkit.KryptonContextMenuItem()
        Me.yesNoToolStripMenuItem = New Krypton.Toolkit.KryptonContextMenuItem()
        Me.yesNoMaybeToolStripMenuItem = New Krypton.Toolkit.KryptonContextMenuItem()
        Me.kryptonContextMenuSeparator10 = New Krypton.Toolkit.KryptonContextMenuSeparator()
        Me.customToolStripMenuItem2 = New Krypton.Toolkit.KryptonContextMenuItem()
        Me.toolStripMenuItem7 = New Krypton.Toolkit.KryptonContextMenuSeparator()
        Me.cmsSaveSentItem = New Krypton.Toolkit.KryptonContextMenu()
        Me.cmsSaveSentItemItems = New Krypton.Toolkit.KryptonContextMenuItems()
        Me.otherFolderToolStripMenuItem = New Krypton.Toolkit.KryptonContextMenuItem()
        Me.kryptonContextMenuSeparator4 = New Krypton.Toolkit.KryptonContextMenuSeparator()
        Me.useDefaultFolderToolStripMenuItem = New Krypton.Toolkit.KryptonContextMenuItem()
        Me.dotNotSaveToolStripMenuItem = New Krypton.Toolkit.KryptonContextMenuItem()
        Me.toolStripMenuItem8 = New Krypton.Toolkit.KryptonContextMenuSeparator()
        Me.cmsChangeCase = New Krypton.Toolkit.KryptonContextMenu()
        Me.cmsChangeCaseItems = New Krypton.Toolkit.KryptonContextMenuItems()
        Me.sentenceCaseToolStripMenuItem = New Krypton.Toolkit.KryptonContextMenuItem()
        Me.lowercaseToolStripMenuItem = New Krypton.Toolkit.KryptonContextMenuItem()
        Me.uPPERCASEToolStripMenuItem = New Krypton.Toolkit.KryptonContextMenuItem()
        Me.capitalizeEachWordToolStripMenuItem = New Krypton.Toolkit.KryptonContextMenuItem()
        Me.tOGGLECASEToolStripMenuItem = New Krypton.Toolkit.KryptonContextMenuItem()
        Me.cmsSpacing = New Krypton.Toolkit.KryptonContextMenu()
        Me.cmsSpacingItems = New Krypton.Toolkit.KryptonContextMenuItems()
        Me.singleSpacingToolStripMenuItem = New Krypton.Toolkit.KryptonContextMenuItem()
        Me.spacingToolStripMenuItem = New Krypton.Toolkit.KryptonContextMenuItem()
        Me.doubleSpacingToolStripMenuItem = New Krypton.Toolkit.KryptonContextMenuItem()
        Me.paragraphToolStripMenuItem = New Krypton.Toolkit.KryptonContextMenuItem()
        Me.cmsBottomBorder = New Krypton.Toolkit.KryptonContextMenu()
        Me.cmsBottomBorderItems = New Krypton.Toolkit.KryptonContextMenuItems()
        Me.bottomBorderToolStripMenuItem = New Krypton.Toolkit.KryptonContextMenuItem()
        Me.topBorderToolStripMenuItem = New Krypton.Toolkit.KryptonContextMenuItem()
        Me.leftBorderToolStripMenuItem = New Krypton.Toolkit.KryptonContextMenuItem()
        Me.rightBorderToolStripMenuItem = New Krypton.Toolkit.KryptonContextMenuItem()
        Me.kryptonContextMenuSeparator6 = New Krypton.Toolkit.KryptonContextMenuSeparator()
        Me.noBorderToolStripMenuItem = New Krypton.Toolkit.KryptonContextMenuItem()
        Me.allBordersToolStripMenuItem = New Krypton.Toolkit.KryptonContextMenuItem()
        Me.outsideBordersToolStripMenuItem = New Krypton.Toolkit.KryptonContextMenuItem()
        Me.insideBordersToolStripMenuItem = New Krypton.Toolkit.KryptonContextMenuItem()
        Me.kryptonContextMenuSeparator7 = New Krypton.Toolkit.KryptonContextMenuSeparator()
        Me.insideHorizontalBorderToolStripMenuItem = New Krypton.Toolkit.KryptonContextMenuItem()
        Me.insideVerticalBorderToolStripMenuItem = New Krypton.Toolkit.KryptonContextMenuItem()
        Me.diagonalDownBorderToolStripMenuItem = New Krypton.Toolkit.KryptonContextMenuItem()
        Me.diagonalUpBorderToolStripMenuItem = New Krypton.Toolkit.KryptonContextMenuItem()
        Me.kryptonContextMenuSeparator8 = New Krypton.Toolkit.KryptonContextMenuSeparator()
        Me.horizontalLineToolStripMenuItem = New Krypton.Toolkit.KryptonContextMenuItem()
        Me.kryptonContextMenuSeparator9 = New Krypton.Toolkit.KryptonContextMenuSeparator()
        Me.drawTableToolStripMenuItem1 = New Krypton.Toolkit.KryptonContextMenuItem()
        Me.viewGridlinesToolStripMenuItem = New Krypton.Toolkit.KryptonContextMenuItem()
        Me.bordersAndShadingToolStripMenuItem = New Krypton.Toolkit.KryptonContextMenuItem()
        Me.toolStripMenuItem9 = New Krypton.Toolkit.KryptonContextMenuSeparator()
        Me.toolStripMenuItem10 = New Krypton.Toolkit.KryptonContextMenuSeparator()
        Me.toolStripMenuItem11 = New Krypton.Toolkit.KryptonContextMenuSeparator()
        Me.toolStripMenuItem12 = New Krypton.Toolkit.KryptonContextMenuSeparator()
        Me.cmsChangeStyles = New Krypton.Toolkit.KryptonContextMenu()
        Me.cmsChangeStylesItems = New Krypton.Toolkit.KryptonContextMenuItems()
        Me.styleSetToolStripMenuItem = New Krypton.Toolkit.KryptonContextMenuItem()
        Me.colorsToolStripMenuItem = New Krypton.Toolkit.KryptonContextMenuItem()
        Me.fontsToolStripMenuItem = New Krypton.Toolkit.KryptonContextMenuItem()
        Me.kryptonContextMenuSeparator5 = New Krypton.Toolkit.KryptonContextMenuSeparator()
        Me.setAsDefaultToolStripMenuItem = New Krypton.Toolkit.KryptonContextMenuItem()
        Me.toolStripMenuItem13 = New Krypton.Toolkit.KryptonContextMenuSeparator()
        Me.cmsQuickStyles = New Krypton.Toolkit.KryptonContextMenu()
        Me.cmsQuickStylesItems = New Krypton.Toolkit.KryptonContextMenuItems()
        Me.saveSelectionAsNewStyleToolStripMenuItem = New Krypton.Toolkit.KryptonContextMenuItem()
        Me.clearFormattingToolStripMenuItem = New Krypton.Toolkit.KryptonContextMenuItem()
        Me.applyStylesToolStripMenuItem = New Krypton.Toolkit.KryptonContextMenuItem()
        Me.cmsFind = New Krypton.Toolkit.KryptonContextMenu()
        Me.cmsFindItems = New Krypton.Toolkit.KryptonContextMenuItems()
        Me.findToolStripMenuItem = New Krypton.Toolkit.KryptonContextMenuItem()
        Me.goToToolStripMenuItem = New Krypton.Toolkit.KryptonContextMenuItem()
        Me.cmsSelect = New Krypton.Toolkit.KryptonContextMenu()
        Me.cmsSelectItems = New Krypton.Toolkit.KryptonContextMenuItems()
        Me.selectAllToolStripMenuItem = New Krypton.Toolkit.KryptonContextMenuItem()
        Me.selectObjectsToolStripMenuItem = New Krypton.Toolkit.KryptonContextMenuItem()
        Me.selectTextWithSimilarFormattingToolStripMenuItem = New Krypton.Toolkit.KryptonContextMenuItem()
        Me.kryptonRibbon = New Krypton.Ribbon.KryptonRibbon()
        Me.buttonSpecHelp = New Krypton.Toolkit.ButtonSpecAny()
        Me.qatSave = New Krypton.Ribbon.KryptonRibbonQATButton()
        Me.qatUndo = New Krypton.Ribbon.KryptonRibbonQATButton()
        Me.qatRedo = New Krypton.Ribbon.KryptonRibbonQATButton()
        Me.qatQuickPrint = New Krypton.Ribbon.KryptonRibbonQATButton()
        Me.qatForward = New Krypton.Ribbon.KryptonRibbonQATButton()
        Me.qatDelete = New Krypton.Ribbon.KryptonRibbonQATButton()
        Me.kryptonContextMenuItem1 = New Krypton.Toolkit.KryptonContextMenuItem()
        Me.kryptonContextMenuItem2 = New Krypton.Toolkit.KryptonContextMenuItem()
        Me.kryptonContextMenuSeparator11 = New Krypton.Toolkit.KryptonContextMenuSeparator()
        Me.kryptonContextMenuItem3 = New Krypton.Toolkit.KryptonContextMenuItem()
        Me.kryptonContextMenuItem4 = New Krypton.Toolkit.KryptonContextMenuItem()
        Me.kryptonContextMenuItems1 = New Krypton.Toolkit.KryptonContextMenuItems()
        Me.kryptonContextMenuHeading1 = New Krypton.Toolkit.KryptonContextMenuHeading()
        Me.kryptonContextMenuItem10 = New Krypton.Toolkit.KryptonContextMenuItem()
        Me.kryptonContextMenuItem5 = New Krypton.Toolkit.KryptonContextMenuItem()
        Me.kryptonContextMenuItem6 = New Krypton.Toolkit.KryptonContextMenuItem()
        Me.kryptonContextMenuSeparator13 = New Krypton.Toolkit.KryptonContextMenuSeparator()
        Me.kryptonContextMenuItem7 = New Krypton.Toolkit.KryptonContextMenuItem()
        Me.kryptonContextMenuItems2 = New Krypton.Toolkit.KryptonContextMenuItems()
        Me.kryptonContextMenuHeading2 = New Krypton.Toolkit.KryptonContextMenuHeading()
        Me.kryptonContextMenuItem11 = New Krypton.Toolkit.KryptonContextMenuItem()
        Me.kryptonContextMenuItem12 = New Krypton.Toolkit.KryptonContextMenuItem()
        Me.kryptonContextMenuItem13 = New Krypton.Toolkit.KryptonContextMenuItem()
        Me.kryptonContextMenuItem14 = New Krypton.Toolkit.KryptonContextMenuItem()
        Me.kryptonContextMenuSeparator15 = New Krypton.Toolkit.KryptonContextMenuSeparator()
        Me.kryptonContextMenuItems3 = New Krypton.Toolkit.KryptonContextMenuItems()
        Me.kryptonContextMenuHeading3 = New Krypton.Toolkit.KryptonContextMenuHeading()
        Me.kryptonContextMenuItem15 = New Krypton.Toolkit.KryptonContextMenuItem()
        Me.kryptonContextMenuSeparator12 = New Krypton.Toolkit.KryptonContextMenuSeparator()
        Me.kryptonContextMenuItem8 = New Krypton.Toolkit.KryptonContextMenuItem()
        Me.kryptonContextMenuItem9 = New Krypton.Toolkit.KryptonContextMenuItem()
        Me.kryptonRibbonRecentDoc1 = New Krypton.Ribbon.KryptonRibbonRecentDoc()
        Me.kryptonRibbonRecentDoc2 = New Krypton.Ribbon.KryptonRibbonRecentDoc()
        Me.kryptonRibbonRecentDoc3 = New Krypton.Ribbon.KryptonRibbonRecentDoc()
        Me.kryptonRibbonRecentDoc4 = New Krypton.Ribbon.KryptonRibbonRecentDoc()
        Me.kryptonRibbonRecentDoc5 = New Krypton.Ribbon.KryptonRibbonRecentDoc()
        Me.kryptonRibbonRecentDoc6 = New Krypton.Ribbon.KryptonRibbonRecentDoc()
        Me.kryptonRibbonRecentDoc7 = New Krypton.Ribbon.KryptonRibbonRecentDoc()
        Me.kryptonRibbonRecentDoc8 = New Krypton.Ribbon.KryptonRibbonRecentDoc()
        Me.buttonSpecAppMenu1 = New Krypton.Ribbon.ButtonSpecAppMenu()
        Me.tabMessage = New Krypton.Ribbon.KryptonRibbonTab()
        Me.groupClipboard = New Krypton.Ribbon.KryptonRibbonGroup()
        Me.clipboard1 = New Krypton.Ribbon.KryptonRibbonGroupTriple()
        Me.clipboardPaste = New Krypton.Ribbon.KryptonRibbonGroupButton()
        Me.clipboard2 = New Krypton.Ribbon.KryptonRibbonGroupTriple()
        Me.clipboardCut = New Krypton.Ribbon.KryptonRibbonGroupButton()
        Me.clipboardCopy = New Krypton.Ribbon.KryptonRibbonGroupButton()
        Me.clipboardFormatPainter = New Krypton.Ribbon.KryptonRibbonGroupButton()
        Me.groupBasicText = New Krypton.Ribbon.KryptonRibbonGroup()
        Me.basicTextLines = New Krypton.Ribbon.KryptonRibbonGroupLines()
        Me.basicTextFont = New Krypton.Ribbon.KryptonRibbonGroupCluster()
        Me.basicTextFontLarger = New Krypton.Ribbon.KryptonRibbonGroupClusterButton()
        Me.basicTextFontSmaller = New Krypton.Ribbon.KryptonRibbonGroupClusterButton()
        Me.basicTextBullet = New Krypton.Ribbon.KryptonRibbonGroupCluster()
        Me.basicTextBulletPoints = New Krypton.Ribbon.KryptonRibbonGroupClusterButton()
        Me.basicTextBulletNumbers = New Krypton.Ribbon.KryptonRibbonGroupClusterButton()
        Me.basicTextRubout = New Krypton.Ribbon.KryptonRibbonGroupCluster()
        Me.basicTextRuboutButton = New Krypton.Ribbon.KryptonRibbonGroupClusterButton()
        Me.basicTextStyle = New Krypton.Ribbon.KryptonRibbonGroupCluster()
        Me.basicTextStyleBold = New Krypton.Ribbon.KryptonRibbonGroupClusterButton()
        Me.basicTextStyleItalic = New Krypton.Ribbon.KryptonRibbonGroupClusterButton()
        Me.basicTextStyleUnderline = New Krypton.Ribbon.KryptonRibbonGroupClusterButton()
        Me.basicTextColors = New Krypton.Ribbon.KryptonRibbonGroupCluster()
        Me.basicTextColorBack = New Krypton.Ribbon.KryptonRibbonGroupClusterColorButton()
        Me.basicTextColorText = New Krypton.Ribbon.KryptonRibbonGroupClusterColorButton()
        Me.basicTextAlignment = New Krypton.Ribbon.KryptonRibbonGroupCluster()
        Me.basicTextAlignLeft = New Krypton.Ribbon.KryptonRibbonGroupClusterButton()
        Me.basicTextAlignCenter = New Krypton.Ribbon.KryptonRibbonGroupClusterButton()
        Me.basicTextAlignRight = New Krypton.Ribbon.KryptonRibbonGroupClusterButton()
        Me.basicTextTab = New Krypton.Ribbon.KryptonRibbonGroupCluster()
        Me.basicTextTabLeft = New Krypton.Ribbon.KryptonRibbonGroupClusterButton()
        Me.basicTextTabRight = New Krypton.Ribbon.KryptonRibbonGroupClusterButton()
        Me.groupNames = New Krypton.Ribbon.KryptonRibbonGroup()
        Me.namesGroup = New Krypton.Ribbon.KryptonRibbonGroupTriple()
        Me.namesAddressBook = New Krypton.Ribbon.KryptonRibbonGroupButton()
        Me.namesCheckNames = New Krypton.Ribbon.KryptonRibbonGroupButton()
        Me.groupMessageInclude = New Krypton.Ribbon.KryptonRibbonGroup()
        Me.includeTriple1 = New Krypton.Ribbon.KryptonRibbonGroupTriple()
        Me.includeAttachFile = New Krypton.Ribbon.KryptonRibbonGroupButton()
        Me.includeAttachItem = New Krypton.Ribbon.KryptonRibbonGroupButton()
        Me.includeSignature = New Krypton.Ribbon.KryptonRibbonGroupButton()
        Me.includeTriple2 = New Krypton.Ribbon.KryptonRibbonGroupTriple()
        Me.groupOptions = New Krypton.Ribbon.KryptonRibbonGroup()
        Me.optionsTripleFollowup = New Krypton.Ribbon.KryptonRibbonGroupTriple()
        Me.optionsFollowUp = New Krypton.Ribbon.KryptonRibbonGroupButton()
        Me.optionsHighImportance = New Krypton.Ribbon.KryptonRibbonGroupButton()
        Me.optionsLowImportance = New Krypton.Ribbon.KryptonRibbonGroupButton()
        Me.groupZoom = New Krypton.Ribbon.KryptonRibbonGroup()
        Me.proofingTriple = New Krypton.Ribbon.KryptonRibbonGroupTriple()
        Me.zoomMessageZoom = New Krypton.Ribbon.KryptonRibbonGroupButton()
        Me.tabInsert = New Krypton.Ribbon.KryptonRibbonTab()
        Me.groupInsertInclude = New Krypton.Ribbon.KryptonRibbonGroup()
        Me.kryptonRibbonGroupTriple4 = New Krypton.Ribbon.KryptonRibbonGroupTriple()
        Me.includeInsertAttachFile = New Krypton.Ribbon.KryptonRibbonGroupButton()
        Me.includeInsertAttachItem = New Krypton.Ribbon.KryptonRibbonGroupButton()
        Me.kryptonRibbonGroupTriple5 = New Krypton.Ribbon.KryptonRibbonGroupTriple()
        Me.includeInsertBusinessCard = New Krypton.Ribbon.KryptonRibbonGroupButton()
        Me.includeInsertCalendar = New Krypton.Ribbon.KryptonRibbonGroupButton()
        Me.includeInsertSignature = New Krypton.Ribbon.KryptonRibbonGroupButton()
        Me.groupTables = New Krypton.Ribbon.KryptonRibbonGroup()
        Me.kryptonRibbonGroupTriple3 = New Krypton.Ribbon.KryptonRibbonGroupTriple()
        Me.tablesTable = New Krypton.Ribbon.KryptonRibbonGroupButton()
        Me.groupInsertIllustrations = New Krypton.Ribbon.KryptonRibbonGroup()
        Me.kryptonRibbonGroupTriple6 = New Krypton.Ribbon.KryptonRibbonGroupTriple()
        Me.illustrationsPicture = New Krypton.Ribbon.KryptonRibbonGroupButton()
        Me.illustrationsClipArt = New Krypton.Ribbon.KryptonRibbonGroupButton()
        Me.kryptonRibbonGroupTriple7 = New Krypton.Ribbon.KryptonRibbonGroupTriple()
        Me.illustrationsShapes = New Krypton.Ribbon.KryptonRibbonGroupButton()
        Me.illustrationsSmartArt = New Krypton.Ribbon.KryptonRibbonGroupButton()
        Me.illustrationsChart = New Krypton.Ribbon.KryptonRibbonGroupButton()
        Me.groupLinks = New Krypton.Ribbon.KryptonRibbonGroup()
        Me.kryptonRibbonGroupTriple2 = New Krypton.Ribbon.KryptonRibbonGroupTriple()
        Me.linksHyperlink = New Krypton.Ribbon.KryptonRibbonGroupButton()
        Me.linksBookmark = New Krypton.Ribbon.KryptonRibbonGroupButton()
        Me.groupText = New Krypton.Ribbon.KryptonRibbonGroup()
        Me.kryptonRibbonGroupTriple8 = New Krypton.Ribbon.KryptonRibbonGroupTriple()
        Me.textTextBox = New Krypton.Ribbon.KryptonRibbonGroupButton()
        Me.textQuickParts = New Krypton.Ribbon.KryptonRibbonGroupButton()
        Me.textWordArt = New Krypton.Ribbon.KryptonRibbonGroupButton()
        Me.kryptonRibbonGroupTriple9 = New Krypton.Ribbon.KryptonRibbonGroupTriple()
        Me.textDropCap = New Krypton.Ribbon.KryptonRibbonGroupButton()
        Me.textDateAndTime = New Krypton.Ribbon.KryptonRibbonGroupButton()
        Me.textObject = New Krypton.Ribbon.KryptonRibbonGroupButton()
        Me.groupSymbols = New Krypton.Ribbon.KryptonRibbonGroup()
        Me.kryptonRibbonGroupTriple1 = New Krypton.Ribbon.KryptonRibbonGroupTriple()
        Me.symbolsEquation = New Krypton.Ribbon.KryptonRibbonGroupButton()
        Me.symbolSymbol = New Krypton.Ribbon.KryptonRibbonGroupButton()
        Me.symbolHorizontalLine = New Krypton.Ribbon.KryptonRibbonGroupButton()
        Me.tabOptions = New Krypton.Ribbon.KryptonRibbonTab()
        Me.groupOptionsThemes = New Krypton.Ribbon.KryptonRibbonGroup()
        Me.kryptonRibbonGroupTriple10 = New Krypton.Ribbon.KryptonRibbonGroupTriple()
        Me.themesTheme = New Krypton.Ribbon.KryptonRibbonGroupButton()
        Me.kryptonRibbonGroupTriple11 = New Krypton.Ribbon.KryptonRibbonGroupTriple()
        Me.themesColors = New Krypton.Ribbon.KryptonRibbonGroupButton()
        Me.themesFonts = New Krypton.Ribbon.KryptonRibbonGroupButton()
        Me.themesEffects = New Krypton.Ribbon.KryptonRibbonGroupButton()
        Me.kryptonRibbonGroupSeparator1 = New Krypton.Ribbon.KryptonRibbonGroupSeparator()
        Me.kryptonRibbonGroupTriple12 = New Krypton.Ribbon.KryptonRibbonGroupTriple()
        Me.themesPageColor = New Krypton.Ribbon.KryptonRibbonGroupButton()
        Me.kryptonRibbonGroupThemeComboBox1 = New Krypton.Ribbon.KryptonRibbonGroupThemeComboBox()
        Me.groupFields = New Krypton.Ribbon.KryptonRibbonGroup()
        Me.kryptonRibbonGroupTriple13 = New Krypton.Ribbon.KryptonRibbonGroupTriple()
        Me.fieldsShowBcc = New Krypton.Ribbon.KryptonRibbonGroupButton()
        Me.fieldsShowFrom = New Krypton.Ribbon.KryptonRibbonGroupButton()
        Me.groupFormat = New Krypton.Ribbon.KryptonRibbonGroup()
        Me.kryptonRibbonGroupTriple14 = New Krypton.Ribbon.KryptonRibbonGroupTriple()
        Me.formatPlainText = New Krypton.Ribbon.KryptonRibbonGroupButton()
        Me.formatHTML = New Krypton.Ribbon.KryptonRibbonGroupButton()
        Me.formatRichText = New Krypton.Ribbon.KryptonRibbonGroupButton()
        Me.groupTracking = New Krypton.Ribbon.KryptonRibbonGroup()
        Me.kryptonRibbonGroupTriple15 = New Krypton.Ribbon.KryptonRibbonGroupTriple()
        Me.trackingUseVotingButtons = New Krypton.Ribbon.KryptonRibbonGroupButton()
        Me.kryptonRibbonGroupLines3 = New Krypton.Ribbon.KryptonRibbonGroupLines()
        Me.kryptonRibbonGroupCheckBox1 = New Krypton.Ribbon.KryptonRibbonGroupCheckBox()
        Me.kryptonRibbonGroupCheckBox2 = New Krypton.Ribbon.KryptonRibbonGroupCheckBox()
        Me.groupMoreOptions = New Krypton.Ribbon.KryptonRibbonGroup()
        Me.kryptonRibbonGroupTriple16 = New Krypton.Ribbon.KryptonRibbonGroupTriple()
        Me.moreOptionsSaveSentItem = New Krypton.Ribbon.KryptonRibbonGroupButton()
        Me.moreOptionsDelayDelivery = New Krypton.Ribbon.KryptonRibbonGroupButton()
        Me.moreOptionsDirectRepliesTo = New Krypton.Ribbon.KryptonRibbonGroupButton()
        Me.tabFormatText = New Krypton.Ribbon.KryptonRibbonTab()
        Me.groupFormatClipboard = New Krypton.Ribbon.KryptonRibbonGroup()
        Me.kryptonRibbonGroupTriple17 = New Krypton.Ribbon.KryptonRibbonGroupTriple()
        Me.formatClipboardPaste = New Krypton.Ribbon.KryptonRibbonGroupButton()
        Me.kryptonRibbonGroupTriple18 = New Krypton.Ribbon.KryptonRibbonGroupTriple()
        Me.formatClipboardCut = New Krypton.Ribbon.KryptonRibbonGroupButton()
        Me.formatClipboardCopy = New Krypton.Ribbon.KryptonRibbonGroupButton()
        Me.formatClipboardFormatPainter = New Krypton.Ribbon.KryptonRibbonGroupButton()
        Me.groupFormatFont = New Krypton.Ribbon.KryptonRibbonGroup()
        Me.kryptonRibbonGroupLines1 = New Krypton.Ribbon.KryptonRibbonGroupLines()
        Me.kryptonRibbonGroupCluster1 = New Krypton.Ribbon.KryptonRibbonGroupCluster()
        Me.fontGrowFont = New Krypton.Ribbon.KryptonRibbonGroupClusterButton()
        Me.fontShrinkFont = New Krypton.Ribbon.KryptonRibbonGroupClusterButton()
        Me.kryptonRibbonGroupCluster2 = New Krypton.Ribbon.KryptonRibbonGroupCluster()
        Me.fontTextClear = New Krypton.Ribbon.KryptonRibbonGroupClusterButton()
        Me.kryptonRibbonGroupCluster4 = New Krypton.Ribbon.KryptonRibbonGroupCluster()
        Me.fontTextBackColor = New Krypton.Ribbon.KryptonRibbonGroupClusterButton()
        Me.textFontColor = New Krypton.Ribbon.KryptonRibbonGroupClusterButton()
        Me.kryptonRibbonGroupCluster3 = New Krypton.Ribbon.KryptonRibbonGroupCluster()
        Me.fontBold = New Krypton.Ribbon.KryptonRibbonGroupClusterButton()
        Me.fontItalic = New Krypton.Ribbon.KryptonRibbonGroupClusterButton()
        Me.fontUnderline = New Krypton.Ribbon.KryptonRibbonGroupClusterButton()
        Me.fontStrikethrough = New Krypton.Ribbon.KryptonRibbonGroupClusterButton()
        Me.fontSubscript = New Krypton.Ribbon.KryptonRibbonGroupClusterButton()
        Me.fontSuperscript = New Krypton.Ribbon.KryptonRibbonGroupClusterButton()
        Me.fontChangeCase = New Krypton.Ribbon.KryptonRibbonGroupClusterButton()
        Me.groupFormatParagraph = New Krypton.Ribbon.KryptonRibbonGroup()
        Me.kryptonRibbonGroupLines2 = New Krypton.Ribbon.KryptonRibbonGroupLines()
        Me.kryptonRibbonGroupCluster5 = New Krypton.Ribbon.KryptonRibbonGroupCluster()
        Me.fontBullets = New Krypton.Ribbon.KryptonRibbonGroupClusterButton()
        Me.fontNumbers = New Krypton.Ribbon.KryptonRibbonGroupClusterButton()
        Me.fontMultilevel = New Krypton.Ribbon.KryptonRibbonGroupClusterButton()
        Me.kryptonRibbonGroupCluster6 = New Krypton.Ribbon.KryptonRibbonGroupCluster()
        Me.fontDecreaseIndent = New Krypton.Ribbon.KryptonRibbonGroupClusterButton()
        Me.fontIncreaseIndent = New Krypton.Ribbon.KryptonRibbonGroupClusterButton()
        Me.kryptonRibbonGroupCluster7 = New Krypton.Ribbon.KryptonRibbonGroupCluster()
        Me.fontSort = New Krypton.Ribbon.KryptonRibbonGroupClusterButton()
        Me.kryptonRibbonGroupCluster8 = New Krypton.Ribbon.KryptonRibbonGroupCluster()
        Me.fontMarkers = New Krypton.Ribbon.KryptonRibbonGroupClusterButton()
        Me.kryptonRibbonGroupCluster9 = New Krypton.Ribbon.KryptonRibbonGroupCluster()
        Me.fontJustifyLeft = New Krypton.Ribbon.KryptonRibbonGroupClusterButton()
        Me.fontJustifyCenter = New Krypton.Ribbon.KryptonRibbonGroupClusterButton()
        Me.fontJustifyRight = New Krypton.Ribbon.KryptonRibbonGroupClusterButton()
        Me.fontJustify = New Krypton.Ribbon.KryptonRibbonGroupClusterButton()
        Me.kryptonRibbonGroupCluster10 = New Krypton.Ribbon.KryptonRibbonGroupCluster()
        Me.fontSpacing = New Krypton.Ribbon.KryptonRibbonGroupClusterButton()
        Me.kryptonRibbonGroupCluster11 = New Krypton.Ribbon.KryptonRibbonGroupCluster()
        Me.fontShading = New Krypton.Ribbon.KryptonRibbonGroupClusterButton()
        Me.fontBottomBorder = New Krypton.Ribbon.KryptonRibbonGroupClusterButton()
        Me.groupFormatStyles = New Krypton.Ribbon.KryptonRibbonGroup()
        Me.kryptonRibbonGroupTriple19 = New Krypton.Ribbon.KryptonRibbonGroupTriple()
        Me.stylesChangeStyles = New Krypton.Ribbon.KryptonRibbonGroupButton()
        Me.groupFormatZoom = New Krypton.Ribbon.KryptonRibbonGroup()
        Me.kryptonRibbonGroupTriple20 = New Krypton.Ribbon.KryptonRibbonGroupTriple()
        Me.zoomZoom = New Krypton.Ribbon.KryptonRibbonGroupButton()
        Me.groupFormatEditing = New Krypton.Ribbon.KryptonRibbonGroup()
        Me.kryptonRibbonGroupTriple21 = New Krypton.Ribbon.KryptonRibbonGroupTriple()
        Me.kryptonRibbonGroupButton4 = New Krypton.Ribbon.KryptonRibbonGroupButton()
        Me.kryptonRibbonGroupButton5 = New Krypton.Ribbon.KryptonRibbonGroupButton()
        Me.kryptonRibbonGroupButton6 = New Krypton.Ribbon.KryptonRibbonGroupButton()
        Me.tabDeveloper = New Krypton.Ribbon.KryptonRibbonTab()
        Me.developerCode = New Krypton.Ribbon.KryptonRibbonGroup()
        Me.developerCodeTriple = New Krypton.Ribbon.KryptonRibbonGroupTriple()
        Me.developerCodeVB = New Krypton.Ribbon.KryptonRibbonGroupButton()
        Me.developerCodeMacros = New Krypton.Ribbon.KryptonRibbonGroupButton()
        Me.developerForm = New Krypton.Ribbon.KryptonRibbonGroup()
        Me.developerFormTriple = New Krypton.Ribbon.KryptonRibbonGroupTriple()
        Me.developerFormDesignThis = New Krypton.Ribbon.KryptonRibbonGroupButton()
        Me.developerFormDesignA = New Krypton.Ribbon.KryptonRibbonGroupButton()
        Me.developerFormPublish = New Krypton.Ribbon.KryptonRibbonGroupButton()
        Me.todayToolStripMenuItem = New Krypton.Toolkit.KryptonContextMenuItem()
        Me.tomorrowToolStripMenuItem = New Krypton.Toolkit.KryptonContextMenuItem()
        Me.thisWeekToolStripMenuItem = New Krypton.Toolkit.KryptonContextMenuItem()
        Me.nextWeekToolStripMenuItem = New Krypton.Toolkit.KryptonContextMenuItem()
        Me.noDateToolStripMenuItem = New Krypton.Toolkit.KryptonContextMenuItem()
        Me.customToolStripMenuItem = New Krypton.Toolkit.KryptonContextMenuItem()
        Me.addReminderToolStripMenuItem = New Krypton.Toolkit.KryptonContextMenuItem()
        Me.kryptonManager1 = New Krypton.Toolkit.KryptonManager(Me.components)
        Me.kryptonRibbonGroupCustomControl1 = New Krypton.Ribbon.KryptonRibbonGroupCustomControl()
        CType(Me.panelFill, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.panelFill.SuspendLayout()
        Me.tableLayout.SuspendLayout()
        CType(Me.kryptonRibbon, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        Me.panelFill.Controls.Add(Me.tableLayout)
        Me.panelFill.Dock = System.Windows.Forms.DockStyle.Fill
        Me.panelFill.Location = New System.Drawing.Point(0, 136)
        Me.panelFill.Name = "panelFill"
        Me.panelFill.Padding = New System.Windows.Forms.Padding(7)
        Me.panelFill.Size = New System.Drawing.Size(869, 392)
        Me.panelFill.TabIndex = 0
        Me.tableLayout.AutoSize = True
        Me.tableLayout.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink
        Me.tableLayout.BackColor = System.Drawing.Color.Transparent
        Me.tableLayout.ColumnCount = 2
        Me.tableLayout.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle())
        Me.tableLayout.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F))
        Me.tableLayout.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 20F))
        Me.tableLayout.Controls.Add(Me.kryptonLabel1, 0, 2)
        Me.tableLayout.Controls.Add(Me.kryptonButton2, 0, 1)
        Me.tableLayout.Controls.Add(Me.richTextBoxMessage, 0, 3)
        Me.tableLayout.Controls.Add(Me.richTextBoxSubject, 1, 2)
        Me.tableLayout.Controls.Add(Me.richTextBoxCc, 1, 1)
        Me.tableLayout.Controls.Add(Me.richTextBoxTo, 1, 0)
        Me.tableLayout.Controls.Add(Me.kryptonButton1, 0, 0)
        Me.tableLayout.Dock = System.Windows.Forms.DockStyle.Fill
        Me.tableLayout.GrowStyle = System.Windows.Forms.TableLayoutPanelGrowStyle.FixedSize
        Me.tableLayout.Location = New System.Drawing.Point(7, 7)
        Me.tableLayout.Margin = New System.Windows.Forms.Padding(1)
        Me.tableLayout.Name = "tableLayout"
        Me.tableLayout.RowCount = 4
        Me.tableLayout.RowStyles.Add(New System.Windows.Forms.RowStyle())
        Me.tableLayout.RowStyles.Add(New System.Windows.Forms.RowStyle())
        Me.tableLayout.RowStyles.Add(New System.Windows.Forms.RowStyle())
        Me.tableLayout.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 200F))
        Me.tableLayout.Size = New System.Drawing.Size(855, 378)
        Me.tableLayout.TabIndex = 0
        Me.kryptonLabel1.Dock = System.Windows.Forms.DockStyle.Fill
        Me.kryptonLabel1.Location = New System.Drawing.Point(3, 65)
        Me.kryptonLabel1.Name = "kryptonLabel1"
        Me.kryptonLabel1.Size = New System.Drawing.Size(65, 24)
        Me.kryptonLabel1.TabIndex = 2
        Me.kryptonLabel1.Values.Text = "Subject:"
        Me.kryptonButton2.Location = New System.Drawing.Point(3, 34)
        Me.kryptonButton2.Name = "kryptonButton2"
        Me.kryptonButton2.Size = New System.Drawing.Size(50, 25)
        Me.kryptonButton2.TabIndex = 1
        Me.kryptonButton2.Values.DropDownArrowColor = System.Drawing.Color.Empty
        Me.kryptonButton2.Values.Text = "Cc..."
        Me.richTextBoxMessage.AcceptsTab = True
        Me.richTextBoxMessage.AutoSize = True
        Me.tableLayout.SetColumnSpan(Me.richTextBoxMessage, 2)
        Me.richTextBoxMessage.Dock = System.Windows.Forms.DockStyle.Fill
        Me.richTextBoxMessage.Font = New System.Drawing.Font("Calibri", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.richTextBoxMessage.Location = New System.Drawing.Point(3, 95)
        Me.richTextBoxMessage.Name = "richTextBoxMessage"
        Me.richTextBoxMessage.Size = New System.Drawing.Size(849, 280)
        Me.richTextBoxMessage.TabIndex = 6
        Me.richTextBoxMessage.Text = ""
        Me.richTextBoxSubject.AutoSize = True
        Me.richTextBoxSubject.Dock = System.Windows.Forms.DockStyle.Fill
        Me.richTextBoxSubject.Font = New System.Drawing.Font("Calibri", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.richTextBoxSubject.Location = New System.Drawing.Point(74, 65)
        Me.richTextBoxSubject.Multiline = False
        Me.richTextBoxSubject.Name = "richTextBoxSubject"
        Me.richTextBoxSubject.Size = New System.Drawing.Size(778, 24)
        Me.richTextBoxSubject.TabIndex = 5
        Me.richTextBoxSubject.Text = "Outlook Mail Clone"
        Me.richTextBoxCc.AutoSize = True
        Me.richTextBoxCc.Dock = System.Windows.Forms.DockStyle.Fill
        Me.richTextBoxCc.Font = New System.Drawing.Font("Calibri", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.richTextBoxCc.Location = New System.Drawing.Point(74, 34)
        Me.richTextBoxCc.Multiline = False
        Me.richTextBoxCc.Name = "richTextBoxCc"
        Me.richTextBoxCc.Size = New System.Drawing.Size(778, 25)
        Me.richTextBoxCc.TabIndex = 4
        Me.richTextBoxCc.Text = ""
        Me.richTextBoxTo.AutoSize = True
        Me.richTextBoxTo.Dock = System.Windows.Forms.DockStyle.Fill
        Me.richTextBoxTo.Font = New System.Drawing.Font("Calibri", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.richTextBoxTo.Location = New System.Drawing.Point(74, 3)
        Me.richTextBoxTo.Multiline = False
        Me.richTextBoxTo.Name = "richTextBoxTo"
        Me.richTextBoxTo.Size = New System.Drawing.Size(778, 25)
        Me.richTextBoxTo.TabIndex = 3
        Me.richTextBoxTo.Text = "friend@megacorp.com"
        Me.kryptonButton1.Location = New System.Drawing.Point(3, 3)
        Me.kryptonButton1.Name = "kryptonButton1"
        Me.kryptonButton1.Size = New System.Drawing.Size(50, 25)
        Me.kryptonButton1.TabIndex = 0
        Me.kryptonButton1.Values.DropDownArrowColor = System.Drawing.Color.Empty
        Me.kryptonButton1.Values.Text = "To..."
        Me.cmsPaste.Items.AddRange(New Krypton.Toolkit.KryptonContextMenuItemBase() { Me.cmsPasteItems})
        Me.cmsPasteItems.Items.AddRange(New Krypton.Toolkit.KryptonContextMenuItemBase() { Me.pasteToolStripMenuItem, Me.pasteSpecialToolStripMenuItem})
        Me.pasteToolStripMenuItem.Image = My.Resources.ClipboardPasteSmall
        Me.pasteToolStripMenuItem.Text = "Paste"
        Me.pasteSpecialToolStripMenuItem.Image = My.Resources.ClipboardPasteSpecial
        Me.pasteSpecialToolStripMenuItem.Text = "Paste Special"
        Me.saveToolStripMenuItem.Image = My.Resources.QATSaveSmall
        Me.saveToolStripMenuItem.Text = "Save"
        Me.forwardToolStripMenuItem.Image = My.Resources.QATForwardSmall
        Me.forwardToolStripMenuItem.Text = "Forward"
        Me.deleteToolStripMenuItem.Image = My.Resources.QATDeleteSmall
        Me.deleteToolStripMenuItem.Text = "Delete"
        Me.exitToolStripMenuItem.Text = "Exit"
        Me.cmsBusinessCards.Items.AddRange(New Krypton.Toolkit.KryptonContextMenuItemBase() { Me.cmsBusinessCardsItems})
        Me.cmsBusinessCardsItems.Items.AddRange(New Krypton.Toolkit.KryptonContextMenuItemBase() { Me.otherBusinessCardsToolStripMenuItem})
        Me.otherBusinessCardsToolStripMenuItem.Text = "Other Business Cards..."
        Me.cmsSignatures.Items.AddRange(New Krypton.Toolkit.KryptonContextMenuItemBase() { Me.cmsSignaturesItems})
        Me.cmsSignaturesItems.Items.AddRange(New Krypton.Toolkit.KryptonContextMenuItemBase() { Me.signaturesToolStripMenuItem})
        Me.signaturesToolStripMenuItem.Text = "Signatures..."
        Me.cmsFollowUp.Items.AddRange(New Krypton.Toolkit.KryptonContextMenuItemBase() { Me.cmsFollowUpItems})
        Me.cmsFollowUpItems.Items.AddRange(New Krypton.Toolkit.KryptonContextMenuItemBase() { Me.todayToolStripMenuItem1, Me.tomorrowToolStripMenuItem1, Me.thisWeekToolStripMenuItem1, Me.nextWeekToolStripMenuItem1, Me.noDateToolStripMenuItem1, Me.customToolStripMenuItem1, Me.kryptonContextMenuSeparator2, Me.addReminderToolStripMenuItem1, Me.clearFlagToolStripMenuItem1, Me.kryptonContextMenuSeparator1, Me.flagForRecipientsToolStripMenuItem1})
        Me.todayToolStripMenuItem1.Image = My.Resources.OptionsToday
        Me.todayToolStripMenuItem1.Text = "Today"
        Me.tomorrowToolStripMenuItem1.Image = My.Resources.OptionsTomorrow
        Me.tomorrowToolStripMenuItem1.Text = "Tomorrow"
        Me.thisWeekToolStripMenuItem1.Image = My.Resources.OptionsWeek
        Me.thisWeekToolStripMenuItem1.Text = "This Week"
        Me.nextWeekToolStripMenuItem1.Image = My.Resources.OptionsWeek
        Me.nextWeekToolStripMenuItem1.Text = "Next Week"
        Me.noDateToolStripMenuItem1.Image = My.Resources.OptionsToday
        Me.noDateToolStripMenuItem1.Text = "No Date"
        Me.customToolStripMenuItem1.Image = My.Resources.OptionsToday
        Me.customToolStripMenuItem1.Text = "Custom..."
        Me.addReminderToolStripMenuItem1.Image = My.Resources.OptionsReminder
        Me.addReminderToolStripMenuItem1.Text = "Add Reminder..."
        Me.clearFlagToolStripMenuItem1.Text = "Clear Flag"
        Me.flagForRecipientsToolStripMenuItem1.Text = "Flag For Recipients..."
        Me.cmsSpelling.Items.AddRange(New Krypton.Toolkit.KryptonContextMenuItemBase() { Me.cmsSpellingItems})
        Me.cmsSpellingItems.Items.AddRange(New Krypton.Toolkit.KryptonContextMenuItemBase() { Me.spellingGrammerToolStripMenuItem, Me.researchToolStripMenuItem, Me.thesaoursToolStripMenuItem, Me.translateToolStripMenuItem, Me.translationScreentipToolStripMenuItem, Me.setLanguageToolStripMenuItem, Me.wordCountToolStripMenuItem, Me.clearFlagToolStripMenuItem, Me.flagForRecipientsToolStripMenuItem})
        Me.spellingGrammerToolStripMenuItem.Image = My.Resources.ProofingSpellingSmall
        Me.spellingGrammerToolStripMenuItem.Text = "Spelling & Grammar"
        Me.researchToolStripMenuItem.Image = My.Resources.ProofingResearchSmall
        Me.researchToolStripMenuItem.Text = "Research..."
        Me.thesaoursToolStripMenuItem.Image = My.Resources.ProofingThesaurusSmall
        Me.thesaoursToolStripMenuItem.Text = "Thesaurus..."
        Me.translateToolStripMenuItem.Image = My.Resources.ProofingTranslateSmall
        Me.translateToolStripMenuItem.Text = "Translate..."
        Me.translationScreentipToolStripMenuItem.Image = My.Resources.ProofingTransScreentipSmall
        Me.translationScreentipToolStripMenuItem.Text = "Translation Screentip..."
        Me.setLanguageToolStripMenuItem.Image = My.Resources.ProofingSetLanguageSmall
        Me.setLanguageToolStripMenuItem.Text = "Set Language..."
        Me.wordCountToolStripMenuItem.Image = My.Resources.ProofingWordCountSmall
        Me.wordCountToolStripMenuItem.Text = "Word Count..."
        Me.clearFlagToolStripMenuItem.Text = "Clear Flag"
        Me.flagForRecipientsToolStripMenuItem.Text = "Flag for Recipients..."
        Me.cmsFormPublish.Items.AddRange(New Krypton.Toolkit.KryptonContextMenuItemBase() { Me.cmsFormPublishItems})
        Me.cmsFormPublishItems.Items.AddRange(New Krypton.Toolkit.KryptonContextMenuItemBase() { Me.publishFormToolStripMenuItem, Me.publishFormAsToolStripMenuItem})
        Me.publishFormToolStripMenuItem.Image = My.Resources.FormPublishSmall
        Me.publishFormToolStripMenuItem.Text = "Publish Form"
        Me.publishFormAsToolStripMenuItem.Text = "Publish Form As..."
        Me.cmsTable.Items.AddRange(New Krypton.Toolkit.KryptonContextMenuItemBase() { Me.cmsTableItems})
        Me.cmsTableItems.Items.AddRange(New Krypton.Toolkit.KryptonContextMenuItemBase() { Me.insertTableToolStripMenuItem, Me.drawTableToolStripMenuItem, Me.convertTextToTableToolStripMenuItem, Me.excelSpreadsheetToolStripMenuItem, Me.quickTablesToolStripMenuItem})
        Me.insertTableToolStripMenuItem.Image = My.Resources.TableSmall
        Me.insertTableToolStripMenuItem.Text = "Insert Table..."
        Me.drawTableToolStripMenuItem.Image = My.Resources.TableDrawSmall
        Me.drawTableToolStripMenuItem.Text = "Draw Table"
        Me.convertTextToTableToolStripMenuItem.Text = "Convert Text to Table..."
        Me.excelSpreadsheetToolStripMenuItem.Image = My.Resources.ExcelSpreadsheetSmall
        Me.excelSpreadsheetToolStripMenuItem.Text = "Excel Spreadsheet"
        Me.quickTablesToolStripMenuItem.Image = My.Resources.TableSmall
        Me.quickTablesToolStripMenuItem.Text = "Quick Tables"
        Me.cmsTextBox.Items.AddRange(New Krypton.Toolkit.KryptonContextMenuItemBase() { Me.cmsTextBoxItems})
        Me.cmsTextBoxItems.Items.AddRange(New Krypton.Toolkit.KryptonContextMenuItemBase() { Me.drawTextBoxToolStripMenuItem, Me.saveSelectionToTextBoxGalleryToolStripMenuItem})
        Me.drawTextBoxToolStripMenuItem.Image = My.Resources.TextBoxSmall
        Me.drawTextBoxToolStripMenuItem.Text = "Draw Text Box"
        Me.saveSelectionToTextBoxGalleryToolStripMenuItem.Text = "Save Selection to Text Box Gallery"
        Me.cmsDropCap.Items.AddRange(New Krypton.Toolkit.KryptonContextMenuItemBase() { Me.cmsDropCapItems})
        Me.cmsDropCapItems.Items.AddRange(New Krypton.Toolkit.KryptonContextMenuItemBase() { Me.dropCapOptionsToolStripMenuItem})
        Me.dropCapOptionsToolStripMenuItem.Image = My.Resources.DropCapSmall
        Me.dropCapOptionsToolStripMenuItem.Text = "Drop Cap Options..."
        Me.cmsEquation.Items.AddRange(New Krypton.Toolkit.KryptonContextMenuItemBase() { Me.cmsEquationItems})
        Me.cmsEquationItems.Items.AddRange(New Krypton.Toolkit.KryptonContextMenuItemBase() { Me.insertNewEquationToolStripMenuItem, Me.saveTextTToolStripMenuItem})
        Me.insertNewEquationToolStripMenuItem.Image = My.Resources.EquationSmall
        Me.insertNewEquationToolStripMenuItem.Text = "Insert New Equation"
        Me.saveTextTToolStripMenuItem.Text = "Save Selection to Equation Gallery..."
        Me.cmsQuickParts.Items.AddRange(New Krypton.Toolkit.KryptonContextMenuItemBase() { Me.cmsQuickPartsItems})
        Me.cmsQuickPartsItems.Items.AddRange(New Krypton.Toolkit.KryptonContextMenuItemBase() { Me.saveSelectionToQuickPartsGalleryToolStripMenuItem})
        Me.saveSelectionToQuickPartsGalleryToolStripMenuItem.Text = "Save Selection to Quick Parts Gallery..."
        Me.cmsSymbol.Items.AddRange(New Krypton.Toolkit.KryptonContextMenuItemBase() { Me.cmsSymbolItems})
        Me.cmsSymbolItems.Items.AddRange(New Krypton.Toolkit.KryptonContextMenuItemBase() { Me.moreSymbolsToolStripMenuItem})
        Me.moreSymbolsToolStripMenuItem.Image = My.Resources.SymbolSmall
        Me.moreSymbolsToolStripMenuItem.Text = "More Symbols..."
        Me.cmsShapes.Items.AddRange(New Krypton.Toolkit.KryptonContextMenuItemBase() { Me.cmsShapesItems})
        Me.cmsShapesItems.Items.AddRange(New Krypton.Toolkit.KryptonContextMenuItemBase() { Me.newDrawingCanvasToolStripMenuItem})
        Me.newDrawingCanvasToolStripMenuItem.Image = My.Resources.DrawingCanvasSmall
        Me.newDrawingCanvasToolStripMenuItem.Text = "New Drawing Canvas"
        Me.cmsThemes.Items.AddRange(New Krypton.Toolkit.KryptonContextMenuItemBase() { Me.cmsThemesItems})
        Me.cmsThemesItems.Items.AddRange(New Krypton.Toolkit.KryptonContextMenuItemBase() { Me.resetToThemeFromTemplateToolStripMenuItem, Me.moreThemesOnMicrosoftOfficeToolStripMenuItem, Me.browseForThemesToolStripMenuItem, Me.saveCurrentThemeToolStripMenuItem})
        Me.resetToThemeFromTemplateToolStripMenuItem.Text = "Reset to Theme from Template"
        Me.moreThemesOnMicrosoftOfficeToolStripMenuItem.Text = "More Themes on Microsoft Office"
        Me.browseForThemesToolStripMenuItem.Image = My.Resources.BrowseThemesSmall
        Me.browseForThemesToolStripMenuItem.Text = "Browse for Themes..."
        Me.saveCurrentThemeToolStripMenuItem.Image = My.Resources.SaveThemesSmall
        Me.saveCurrentThemeToolStripMenuItem.Text = "Save Current Theme..."
        Me.cmsPageColor.Items.AddRange(New Krypton.Toolkit.KryptonContextMenuItemBase() { Me.cmsPageColorItems})
        Me.cmsPageColorItems.Items.AddRange(New Krypton.Toolkit.KryptonContextMenuItemBase() { Me.noColorToolStripMenuItem, Me.kryptonContextMenuSeparator3, Me.moreColorsToolStripMenuItem, Me.fillEffectsToolStripMenuItem})
        Me.noColorToolStripMenuItem.Text = "No Color"
        Me.moreColorsToolStripMenuItem.Text = "More Colors..."
        Me.fillEffectsToolStripMenuItem.Text = "Fill Effects..."
        Me.cmsUseVotingButtons.Items.AddRange(New Krypton.Toolkit.KryptonContextMenuItemBase() { Me.cmsUseVotingButtonsItems})
        Me.cmsUseVotingButtonsItems.Items.AddRange(New Krypton.Toolkit.KryptonContextMenuItemBase() { Me.approveRejectToolStripMenuItem, Me.yesNoToolStripMenuItem, Me.yesNoMaybeToolStripMenuItem, Me.kryptonContextMenuSeparator10, Me.customToolStripMenuItem2})
        Me.approveRejectToolStripMenuItem.Text = "Approve; Reject"
        Me.yesNoToolStripMenuItem.Text = "Yes; No"
        Me.yesNoMaybeToolStripMenuItem.Text = "Yes; No; Maybe"
        Me.customToolStripMenuItem2.Text = "Custom..."
        Me.cmsSaveSentItem.Items.AddRange(New Krypton.Toolkit.KryptonContextMenuItemBase() { Me.cmsSaveSentItemItems})
        Me.cmsSaveSentItemItems.Items.AddRange(New Krypton.Toolkit.KryptonContextMenuItemBase() { Me.otherFolderToolStripMenuItem, Me.kryptonContextMenuSeparator4, Me.useDefaultFolderToolStripMenuItem, Me.dotNotSaveToolStripMenuItem})
        Me.otherFolderToolStripMenuItem.Image = My.Resources.OtherFolderSmall
        Me.otherFolderToolStripMenuItem.Text = "Other Folder..."
        Me.useDefaultFolderToolStripMenuItem.Checked = True
        Me.useDefaultFolderToolStripMenuItem.CheckState = System.Windows.Forms.CheckState.Checked
        Me.useDefaultFolderToolStripMenuItem.Text = "Use Default Folder"
        Me.dotNotSaveToolStripMenuItem.Text = "Dot Not Save"
        Me.cmsChangeCase.Items.AddRange(New Krypton.Toolkit.KryptonContextMenuItemBase() { Me.cmsChangeCaseItems})
        Me.cmsChangeCaseItems.Items.AddRange(New Krypton.Toolkit.KryptonContextMenuItemBase() { Me.sentenceCaseToolStripMenuItem, Me.lowercaseToolStripMenuItem, Me.uPPERCASEToolStripMenuItem, Me.capitalizeEachWordToolStripMenuItem, Me.tOGGLECASEToolStripMenuItem})
        Me.sentenceCaseToolStripMenuItem.Text = "Sentence case."
        Me.lowercaseToolStripMenuItem.Text = "lowercase"
        Me.uPPERCASEToolStripMenuItem.Text = "UPPERCASE"
        Me.capitalizeEachWordToolStripMenuItem.Text = "Capitalize Each Word"
        Me.tOGGLECASEToolStripMenuItem.Text = "tOGGLE cASE"
        Me.cmsSpacing.Items.AddRange(New Krypton.Toolkit.KryptonContextMenuItemBase() { Me.cmsSpacingItems})
        Me.cmsSpacingItems.Items.AddRange(New Krypton.Toolkit.KryptonContextMenuItemBase() { Me.singleSpacingToolStripMenuItem, Me.spacingToolStripMenuItem, Me.doubleSpacingToolStripMenuItem, Me.paragraphToolStripMenuItem})
        Me.singleSpacingToolStripMenuItem.Image = My.Resources.SpacingOne
        Me.singleSpacingToolStripMenuItem.Text = "Single Spacing"
        Me.spacingToolStripMenuItem.Image = My.Resources.SpacingOneHalf
        Me.spacingToolStripMenuItem.Text = "1.5 Spacing"
        Me.doubleSpacingToolStripMenuItem.Image = My.Resources.SpacingDouble
        Me.doubleSpacingToolStripMenuItem.Text = "Double Spacing"
        Me.paragraphToolStripMenuItem.Image = My.Resources.SpacingParagraph
        Me.paragraphToolStripMenuItem.Text = "Paragraph..."
        Me.cmsBottomBorder.Items.AddRange(New Krypton.Toolkit.KryptonContextMenuItemBase() { Me.cmsBottomBorderItems})
        Me.cmsBottomBorderItems.Items.AddRange(New Krypton.Toolkit.KryptonContextMenuItemBase() { Me.bottomBorderToolStripMenuItem, Me.topBorderToolStripMenuItem, Me.leftBorderToolStripMenuItem, Me.rightBorderToolStripMenuItem, Me.kryptonContextMenuSeparator6, Me.noBorderToolStripMenuItem, Me.allBordersToolStripMenuItem, Me.outsideBordersToolStripMenuItem, Me.insideBordersToolStripMenuItem, Me.kryptonContextMenuSeparator7, Me.insideHorizontalBorderToolStripMenuItem, Me.insideVerticalBorderToolStripMenuItem, Me.diagonalDownBorderToolStripMenuItem, Me.diagonalUpBorderToolStripMenuItem, Me.kryptonContextMenuSeparator8, Me.horizontalLineToolStripMenuItem, Me.kryptonContextMenuSeparator9, Me.drawTableToolStripMenuItem1, Me.viewGridlinesToolStripMenuItem, Me.bordersAndShadingToolStripMenuItem})
        Me.bottomBorderToolStripMenuItem.Image = My.Resources.BottomBorder
        Me.bottomBorderToolStripMenuItem.Text = "Bottom Border"
        Me.topBorderToolStripMenuItem.Image = My.Resources.TopBorder
        Me.topBorderToolStripMenuItem.Text = "Top Border"
        Me.leftBorderToolStripMenuItem.Image = My.Resources.LeftBorder
        Me.leftBorderToolStripMenuItem.Text = "Left Border"
        Me.rightBorderToolStripMenuItem.Image = My.Resources.RightBorder
        Me.rightBorderToolStripMenuItem.Text = "Right Border"
        Me.noBorderToolStripMenuItem.Image = My.Resources.NoBorder
        Me.noBorderToolStripMenuItem.Text = "No Border"
        Me.allBordersToolStripMenuItem.Image = My.Resources.AllBorder
        Me.allBordersToolStripMenuItem.Text = "All Borders"
        Me.outsideBordersToolStripMenuItem.Image = My.Resources.OutsideBorder
        Me.outsideBordersToolStripMenuItem.Text = "Outside Borders"
        Me.insideBordersToolStripMenuItem.Image = My.Resources.InsideBorder
        Me.insideBordersToolStripMenuItem.Text = "Inside Borders"
        Me.insideHorizontalBorderToolStripMenuItem.Image = My.Resources.InsideHorzBorder
        Me.insideHorizontalBorderToolStripMenuItem.Text = "Inside Horizontal Border"
        Me.insideVerticalBorderToolStripMenuItem.Image = My.Resources.InsideVertBorder
        Me.insideVerticalBorderToolStripMenuItem.Text = "Inside Vertical Border"
        Me.diagonalDownBorderToolStripMenuItem.Image = My.Resources.DiagonalDownBorder
        Me.diagonalDownBorderToolStripMenuItem.Text = "Diagonal Down Border"
        Me.diagonalUpBorderToolStripMenuItem.Image = My.Resources.DiagonalUpBorder
        Me.diagonalUpBorderToolStripMenuItem.Text = "Diagonal Up Border"
        Me.horizontalLineToolStripMenuItem.Image = My.Resources.HorizontalLineSmall
        Me.horizontalLineToolStripMenuItem.Text = "Horizontal Line"
        Me.drawTableToolStripMenuItem1.Image = My.Resources.TableDrawSmall
        Me.drawTableToolStripMenuItem1.Text = "Draw Table"
        Me.viewGridlinesToolStripMenuItem.Image = My.Resources.ViewGridlines
        Me.viewGridlinesToolStripMenuItem.Text = "View Gridlines"
        Me.bordersAndShadingToolStripMenuItem.Image = My.Resources.BordersAndShading
        Me.bordersAndShadingToolStripMenuItem.Text = "Borders and Shading..."
        Me.cmsChangeStyles.Items.AddRange(New Krypton.Toolkit.KryptonContextMenuItemBase() { Me.cmsChangeStylesItems})
        Me.cmsChangeStylesItems.Items.AddRange(New Krypton.Toolkit.KryptonContextMenuItemBase() { Me.styleSetToolStripMenuItem, Me.colorsToolStripMenuItem, Me.fontsToolStripMenuItem, Me.kryptonContextMenuSeparator5, Me.setAsDefaultToolStripMenuItem})
        Me.styleSetToolStripMenuItem.Image = My.Resources.StyleSet
        Me.styleSetToolStripMenuItem.Text = "Style Set"
        Me.colorsToolStripMenuItem.Image = My.Resources.ColorsSmall
        Me.colorsToolStripMenuItem.Text = "Colors"
        Me.fontsToolStripMenuItem.Image = My.Resources.FontsSmall
        Me.fontsToolStripMenuItem.Text = "Fonts"
        Me.setAsDefaultToolStripMenuItem.Text = "Set as Default"
        Me.cmsQuickStyles.Items.AddRange(New Krypton.Toolkit.KryptonContextMenuItemBase() { Me.cmsQuickStylesItems})
        Me.cmsQuickStylesItems.Items.AddRange(New Krypton.Toolkit.KryptonContextMenuItemBase() { Me.saveSelectionAsNewStyleToolStripMenuItem, Me.clearFormattingToolStripMenuItem, Me.applyStylesToolStripMenuItem})
        Me.saveSelectionAsNewStyleToolStripMenuItem.Text = "Save Selection as New Quick Style"
        Me.clearFormattingToolStripMenuItem.Image = My.Resources.TextRubout
        Me.clearFormattingToolStripMenuItem.Text = "Clear Formatting"
        Me.applyStylesToolStripMenuItem.Image = My.Resources.ApplyStyles
        Me.applyStylesToolStripMenuItem.Text = "Apply Styles..."
        Me.cmsFind.Items.AddRange(New Krypton.Toolkit.KryptonContextMenuItemBase() { Me.cmsFindItems})
        Me.cmsFindItems.Items.AddRange(New Krypton.Toolkit.KryptonContextMenuItemBase() { Me.findToolStripMenuItem, Me.goToToolStripMenuItem})
        Me.findToolStripMenuItem.Image = My.Resources.FindSmall
        Me.findToolStripMenuItem.Text = "Find..."
        Me.goToToolStripMenuItem.Text = "Go To..."
        Me.cmsSelect.Items.AddRange(New Krypton.Toolkit.KryptonContextMenuItemBase() { Me.cmsSelectItems})
        Me.cmsSelectItems.Items.AddRange(New Krypton.Toolkit.KryptonContextMenuItemBase() { Me.selectAllToolStripMenuItem, Me.selectObjectsToolStripMenuItem, Me.selectTextWithSimilarFormattingToolStripMenuItem})
        Me.selectAllToolStripMenuItem.Text = "Select All"
        Me.selectObjectsToolStripMenuItem.Image = My.Resources.SelectSmall
        Me.selectObjectsToolStripMenuItem.Text = "Select Objects"
        Me.selectTextWithSimilarFormattingToolStripMenuItem.Text = "Select Text with Similar Formatting"
        Me.kryptonRibbon.ButtonSpecs.Add(Me.buttonSpecHelp)
        Me.kryptonRibbon.InDesignHelperMode = True
        Me.kryptonRibbon.Name = "kryptonRibbon"
        Me.kryptonRibbon.QATButtons.AddRange(New System.ComponentModel.Component() { Me.qatSave, Me.qatUndo, Me.qatRedo, Me.qatQuickPrint, Me.qatForward, Me.qatDelete})
        Me.kryptonRibbon.RibbonFileAppButton.AppButtonImage = My.Resources.Main_Icon_64_x_64
        Me.kryptonRibbon.RibbonFileAppButton.AppButtonMenuItems.AddRange(New Krypton.Toolkit.KryptonContextMenuItemBase() { Me.kryptonContextMenuItem1, Me.kryptonContextMenuItem2, Me.kryptonContextMenuSeparator11, Me.kryptonContextMenuItem3, Me.kryptonContextMenuItem4, Me.kryptonContextMenuItem5, Me.kryptonContextMenuItem6, Me.kryptonContextMenuSeparator13, Me.kryptonContextMenuItem7, Me.kryptonContextMenuSeparator12, Me.kryptonContextMenuItem8, Me.kryptonContextMenuItem9})
        Me.kryptonRibbon.RibbonFileAppButton.AppButtonMinRecentSize = New System.Drawing.Size(300, 250)
        Me.kryptonRibbon.RibbonFileAppButton.AppButtonRecentDocs.AddRange(New Krypton.Ribbon.KryptonRibbonRecentDoc() { Me.kryptonRibbonRecentDoc1, Me.kryptonRibbonRecentDoc2, Me.kryptonRibbonRecentDoc3, Me.kryptonRibbonRecentDoc4, Me.kryptonRibbonRecentDoc5, Me.kryptonRibbonRecentDoc6, Me.kryptonRibbonRecentDoc7, Me.kryptonRibbonRecentDoc8})
        Me.kryptonRibbon.RibbonFileAppButton.AppButtonSpecs.Add(Me.buttonSpecAppMenu1)
        Me.kryptonRibbon.RibbonFileAppButton.FormCloseBoxVisible = True
        Me.kryptonRibbon.RibbonTabs.AddRange(New Krypton.Ribbon.KryptonRibbonTab() { Me.tabMessage, Me.tabInsert, Me.tabOptions, Me.tabFormatText, Me.tabDeveloper})
        Me.kryptonRibbon.SelectedTab = Me.tabOptions
        Me.kryptonRibbon.Size = New System.Drawing.Size(869, 136)
        Me.kryptonRibbon.TabIndex = 0
        Me.buttonSpecHelp.Image = My.Resources.HelpSmall
        Me.buttonSpecHelp.UniqueName = "E0D28D217A1E48CEE0D28D217A1E48CE"
        Me.qatSave.Image = My.Resources.QATSaveSmall
        Me.qatSave.Text = "Save"
        Me.qatUndo.Image = My.Resources.QATUndoSmall
        Me.qatUndo.Text = "Undo"
        Me.qatRedo.Image = My.Resources.QATRedoSmall
        Me.qatRedo.Text = "Redo"
        Me.qatQuickPrint.Image = My.Resources.QATQuickPrintSmall
        Me.qatQuickPrint.Text = "Quick Print"
        Me.qatForward.Image = My.Resources.QATForwardSmall
        Me.qatForward.Text = "Forward"
        Me.qatForward.Visible = False
        Me.qatDelete.Image = My.Resources.QATDeleteSmall
        Me.qatDelete.Text = "Delete"
        Me.qatDelete.Visible = False
        Me.kryptonContextMenuItem1.Image = My.Resources.AppMenuNewMailMessage
        Me.kryptonContextMenuItem1.Text = "&New Mail Message"
        Me.kryptonContextMenuItem2.Image = My.Resources.AppMenuSendMessage
        Me.kryptonContextMenuItem2.Text = "S&end"
        Me.kryptonContextMenuItem3.Image = My.Resources.AppMenuSave
        Me.kryptonContextMenuItem3.Text = "&Save"
        Me.kryptonContextMenuItem4.Image = My.Resources.AppMenuSaveAs
        Me.kryptonContextMenuItem4.Items.AddRange(New Krypton.Toolkit.KryptonContextMenuItemBase() { Me.kryptonContextMenuItems1})
        Me.kryptonContextMenuItem4.SplitSubMenu = True
        Me.kryptonContextMenuItem4.Text = "Save &As"
        Me.kryptonContextMenuItems1.ImageColumn = False
        Me.kryptonContextMenuItems1.Items.AddRange(New Krypton.Toolkit.KryptonContextMenuItemBase() { Me.kryptonContextMenuHeading1, Me.kryptonContextMenuItem10})
        Me.kryptonContextMenuItems1.StandardStyle = False
        Me.kryptonContextMenuHeading1.Text = "Save in another format"
        Me.kryptonContextMenuItem10.ExtraText = "Save a copy of the item to your computer" & vbCrLf & "in one of several formats."
        Me.kryptonContextMenuItem10.Image = My.Resources.AppMenuSaveAs
        Me.kryptonContextMenuItem10.Text = "Save &As"
        Me.kryptonContextMenuItem5.Image = My.Resources.AppMenuDelete
        Me.kryptonContextMenuItem5.Text = "&Delete"
        Me.kryptonContextMenuItem6.Image = My.Resources.AppMenuMove
        Me.kryptonContextMenuItem6.Text = "&Move"
        Me.kryptonContextMenuItem7.Image = My.Resources.AppMenuPrint
        Me.kryptonContextMenuItem7.Items.AddRange(New Krypton.Toolkit.KryptonContextMenuItemBase() { Me.kryptonContextMenuItems2, Me.kryptonContextMenuSeparator15, Me.kryptonContextMenuItems3})
        Me.kryptonContextMenuItem7.SplitSubMenu = True
        Me.kryptonContextMenuItem7.Text = "&Print"
        Me.kryptonContextMenuItems2.ImageColumn = False
        Me.kryptonContextMenuItems2.Items.AddRange(New Krypton.Toolkit.KryptonContextMenuItemBase() { Me.kryptonContextMenuHeading2, Me.kryptonContextMenuItem11, Me.kryptonContextMenuItem12, Me.kryptonContextMenuItem13, Me.kryptonContextMenuItem14})
        Me.kryptonContextMenuItems2.StandardStyle = False
        Me.kryptonContextMenuHeading2.Text = "Preview and print"
        Me.kryptonContextMenuItem11.ExtraText = "Select a printer, number of copies, and" & vbCrLf & "other printing options before printing."
        Me.kryptonContextMenuItem11.Image = My.Resources.AppMenuPrint
        Me.kryptonContextMenuItem11.Text = "&Print"
        Me.kryptonContextMenuItem12.ExtraText = "Send the item directly to the default printer" & vbCrLf & "without making changes."
        Me.kryptonContextMenuItem12.Image = My.Resources.AppMenuQuickPrint
        Me.kryptonContextMenuItem12.Text = "&Quick Print"
        Me.kryptonContextMenuItem13.ExtraText = "Preview and make changes to pages before" & vbCrLf & "printing."
        Me.kryptonContextMenuItem13.Image = My.Resources.AppMenuPrintPreview
        Me.kryptonContextMenuItem13.Text = "Print Pre&view"
        Me.kryptonContextMenuItem14.ExtraText = "Change how an item prints by creating" & vbCrLf & "your own print styles."
        Me.kryptonContextMenuItem14.Image = My.Resources.AppMenuPrintStyles
        Me.kryptonContextMenuItem14.Text = "Define Print &Styles"
        Me.kryptonContextMenuItems3.ImageColumn = False
        Me.kryptonContextMenuItems3.Items.AddRange(New Krypton.Toolkit.KryptonContextMenuItemBase() { Me.kryptonContextMenuHeading3, Me.kryptonContextMenuItem15})
        Me.kryptonContextMenuItems3.StandardStyle = False
        Me.kryptonContextMenuHeading3.Text = "Page Setup"
        Me.kryptonContextMenuItem15.Image = My.Resources.AppMenuMemoStyle
        Me.kryptonContextMenuItem15.Text = "Memo Style"
        Me.kryptonContextMenuItem8.Image = My.Resources.AppMenuProperties
        Me.kryptonContextMenuItem8.Text = "Pr&operties"
        Me.kryptonContextMenuItem9.Image = My.Resources.AppMenuClose
        Me.kryptonContextMenuItem9.Text = "&Close"
        Me.kryptonRibbonRecentDoc1.Text = "Mail Message"
        Me.kryptonRibbonRecentDoc2.Text = "Appointment"
        Me.kryptonRibbonRecentDoc3.Text = "Meeting Request"
        Me.kryptonRibbonRecentDoc4.Text = "Contact"
        Me.kryptonRibbonRecentDoc5.Text = "Distribution List"
        Me.kryptonRibbonRecentDoc6.Text = "Task"
        Me.kryptonRibbonRecentDoc7.Text = "Note"
        Me.kryptonRibbonRecentDoc8.Text = "Choose Form"
        Me.buttonSpecAppMenu1.Style = Krypton.Toolkit.PaletteButtonStyle.Standalone
        Me.buttonSpecAppMenu1.Text = "Editor Opt&ions"
        Me.buttonSpecAppMenu1.UniqueName = "79F5426EC683477979F5426EC6834779"
        Me.tabMessage.Groups.AddRange(New Krypton.Ribbon.KryptonRibbonGroup() { Me.groupClipboard, Me.groupBasicText, Me.groupNames, Me.groupMessageInclude, Me.groupOptions, Me.groupZoom})
        Me.tabMessage.KeyTip = "H"
        Me.tabMessage.Text = "Message"
        Me.groupClipboard.AllowCollapsed = False
        Me.groupClipboard.Image = Nothing
        Me.groupClipboard.Items.AddRange(New Krypton.Ribbon.KryptonRibbonGroupContainer() { Me.clipboard1, Me.clipboard2})
        Me.groupClipboard.KeyTipDialogLauncher = "FO"
        Me.groupClipboard.TextLine1 = "Clipboard"
        Me.clipboard1.Items.AddRange(New Krypton.Ribbon.KryptonRibbonGroupItem() { Me.clipboardPaste})
        Me.clipboard1.MinimumSize = Krypton.Ribbon.GroupItemSize.Large
        Me.clipboardPaste.ButtonType = Krypton.Ribbon.GroupButtonType.Split
        Me.clipboardPaste.ImageLarge = My.Resources.ClipboardPaste
        Me.clipboardPaste.ImageSmall = Nothing
        Me.clipboardPaste.KeyTip = "V"
        Me.clipboardPaste.KryptonContextMenu = Me.cmsPaste
        Me.clipboardPaste.TextLine1 = "Paste"
        Me.clipboard2.Items.AddRange(New Krypton.Ribbon.KryptonRibbonGroupItem() { Me.clipboardCut, Me.clipboardCopy, Me.clipboardFormatPainter})
        Me.clipboard2.MaximumSize = Krypton.Ribbon.GroupItemSize.Medium
        Me.clipboardCut.ImageLarge = Nothing
        Me.clipboardCut.ImageSmall = My.Resources.ClipboardCut
        Me.clipboardCut.KeyTip = "X"
        Me.clipboardCut.TextLine1 = "Cut"
        Me.clipboardCopy.ImageLarge = Nothing
        Me.clipboardCopy.ImageSmall = My.Resources.ClipboardCopy
        Me.clipboardCopy.KeyTip = "C"
        Me.clipboardCopy.TextLine1 = "Copy"
        Me.clipboardFormatPainter.ImageLarge = Nothing
        Me.clipboardFormatPainter.ImageSmall = My.Resources.ClipboardFormatPainter
        Me.clipboardFormatPainter.KeyTip = "FP"
        Me.clipboardFormatPainter.TextLine1 = "Format"
        Me.clipboardFormatPainter.TextLine2 = "Painter"
        Me.groupBasicText.Image = My.Resources.TextColor
        Me.groupBasicText.Items.AddRange(New Krypton.Ribbon.KryptonRibbonGroupContainer() { Me.basicTextLines})
        Me.groupBasicText.KeyTipDialogLauncher = "FN"
        Me.groupBasicText.KeyTipGroup = "ZB"
        Me.groupBasicText.TextLine1 = "Basic"
        Me.groupBasicText.TextLine2 = "Text"
        Me.basicTextLines.Items.AddRange(New Krypton.Ribbon.KryptonRibbonGroupItem() { Me.basicTextFont, Me.basicTextBullet, Me.basicTextRubout, Me.basicTextStyle, Me.basicTextColors, Me.basicTextAlignment, Me.basicTextTab})
        Me.basicTextFont.Items.AddRange(New Krypton.Ribbon.KryptonRibbonGroupItem() { Me.basicTextFontLarger, Me.basicTextFontSmaller})
        Me.basicTextFontLarger.ImageSmall = My.Resources.TextFontLarger
        Me.basicTextFontLarger.KeyTip = "FG"
        Me.basicTextFontSmaller.ImageSmall = My.Resources.TextFontSmaller
        Me.basicTextFontSmaller.KeyTip = "FK"
        Me.basicTextBullet.Items.AddRange(New Krypton.Ribbon.KryptonRibbonGroupItem() { Me.basicTextBulletPoints, Me.basicTextBulletNumbers})
        Me.basicTextBulletPoints.ImageSmall = My.Resources.TextBulletPoints
        Me.basicTextBulletPoints.KeyTip = "U"
        Me.basicTextBulletNumbers.ImageSmall = My.Resources.TextBulletNumbers
        Me.basicTextBulletNumbers.KeyTip = "N"
        Me.basicTextRubout.Items.AddRange(New Krypton.Ribbon.KryptonRibbonGroupItem() { Me.basicTextRuboutButton})
        Me.basicTextRuboutButton.ImageSmall = My.Resources.TextRubout
        Me.basicTextRuboutButton.KeyTip = "E"
        Me.basicTextStyle.Items.AddRange(New Krypton.Ribbon.KryptonRibbonGroupItem() { Me.basicTextStyleBold, Me.basicTextStyleItalic, Me.basicTextStyleUnderline})
        Me.basicTextStyleBold.ButtonType = Krypton.Ribbon.GroupButtonType.Check
        Me.basicTextStyleBold.ImageSmall = My.Resources.TextBold
        Me.basicTextStyleBold.KeyTip = "1"
        Me.basicTextStyleItalic.ButtonType = Krypton.Ribbon.GroupButtonType.Check
        Me.basicTextStyleItalic.ImageSmall = My.Resources.TextItalics
        Me.basicTextStyleItalic.KeyTip = "2"
        Me.basicTextStyleUnderline.ButtonType = Krypton.Ribbon.GroupButtonType.Check
        Me.basicTextStyleUnderline.ImageSmall = My.Resources.TextUnderline
        Me.basicTextStyleUnderline.KeyTip = "3"
        Me.basicTextColors.Items.AddRange(New Krypton.Ribbon.KryptonRibbonGroupItem() { Me.basicTextColorBack, Me.basicTextColorText})
        Me.basicTextColorBack.ImageSmall = My.Resources.TextBackColor
        Me.basicTextColorBack.KeyTip = "I"
        Me.basicTextColorBack.RecentColors = New System.Drawing.Color(-1) {}
        Me.basicTextColorBack.SchemeStandard = Krypton.Toolkit.ColorScheme.Basic16
        Me.basicTextColorBack.SelectedColor = System.Drawing.Color.Yellow
        Me.basicTextColorBack.VisibleMoreColors = False
        Me.basicTextColorBack.VisibleThemes = False
        Me.basicTextColorText.ImageSmall = My.Resources.TextColor
        Me.basicTextColorText.KeyTip = "FC"
        Me.basicTextColorText.RecentColors = New System.Drawing.Color(-1) {}
        Me.basicTextColorText.SelectedColor = System.Drawing.Color.Black
        Me.basicTextColorText.VisibleNoColor = False
        Me.basicTextAlignment.Items.AddRange(New Krypton.Ribbon.KryptonRibbonGroupItem() { Me.basicTextAlignLeft, Me.basicTextAlignCenter, Me.basicTextAlignRight})
        Me.basicTextAlignLeft.ImageSmall = My.Resources.TextAlignLeft
        Me.basicTextAlignLeft.KeyTip = "AL"
        Me.basicTextAlignCenter.ImageSmall = My.Resources.TextAlignCenter
        Me.basicTextAlignCenter.KeyTip = "AC"
        Me.basicTextAlignRight.ImageSmall = My.Resources.TextAlignRight
        Me.basicTextAlignRight.KeyTip = "AR"
        Me.basicTextTab.Items.AddRange(New Krypton.Ribbon.KryptonRibbonGroupItem() { Me.basicTextTabLeft, Me.basicTextTabRight})
        Me.basicTextTabLeft.ImageSmall = My.Resources.TextTabLeft
        Me.basicTextTabLeft.KeyTip = "AO"
        Me.basicTextTabRight.ImageSmall = My.Resources.TextTabRight
        Me.basicTextTabRight.KeyTip = "AI"
        Me.groupNames.DialogBoxLauncher = False
        Me.groupNames.Image = My.Resources.NamesGroup
        Me.groupNames.Items.AddRange(New Krypton.Ribbon.KryptonRibbonGroupContainer() { Me.namesGroup})
        Me.groupNames.KeyTipGroup = "ZN"
        Me.groupNames.TextLine1 = "Names"
        Me.namesGroup.Items.AddRange(New Krypton.Ribbon.KryptonRibbonGroupItem() { Me.namesAddressBook, Me.namesCheckNames})
        Me.namesGroup.MinimumSize = Krypton.Ribbon.GroupItemSize.Large
        Me.namesAddressBook.ImageLarge = My.Resources.NamesAddressBook
        Me.namesAddressBook.ImageSmall = Nothing
        Me.namesAddressBook.KeyTip = "AB"
        Me.namesAddressBook.TextLine1 = "Address"
        Me.namesAddressBook.TextLine2 = "Book"
        Me.namesCheckNames.ImageLarge = My.Resources.NamesCheckNames
        Me.namesCheckNames.ImageSmall = Nothing
        Me.namesCheckNames.KeyTip = "M"
        Me.namesCheckNames.TextLine1 = "Check"
        Me.namesCheckNames.TextLine2 = "Names"
        Me.groupMessageInclude.Image = Nothing
        Me.groupMessageInclude.Items.AddRange(New Krypton.Ribbon.KryptonRibbonGroupContainer() { Me.includeTriple1, Me.includeTriple2})
        Me.groupMessageInclude.KeyTipDialogLauncher = "AP"
        Me.groupMessageInclude.KeyTipGroup = "ZC"
        Me.groupMessageInclude.TextLine1 = "Include"
        Me.includeTriple1.Items.AddRange(New Krypton.Ribbon.KryptonRibbonGroupItem() { Me.includeAttachFile, Me.includeAttachItem, Me.includeSignature})
        Me.includeAttachFile.ImageLarge = My.Resources.IncludeAttachFile
        Me.includeAttachFile.ImageSmall = My.Resources.IncludeAttachFileSmall
        Me.includeAttachFile.KeyTip = "AF"
        Me.includeAttachFile.TextLine1 = "Attach"
        Me.includeAttachFile.TextLine2 = "File"
        Me.includeAttachItem.ImageLarge = My.Resources.IncludeAttachItem
        Me.includeAttachItem.ImageSmall = My.Resources.IncludeAttachItemSmall
        Me.includeAttachItem.KeyTip = "AM"
        Me.includeAttachItem.TextLine1 = "Attach"
        Me.includeAttachItem.TextLine2 = "Item"
        Me.includeSignature.ButtonType = Krypton.Ribbon.GroupButtonType.DropDown
        Me.includeSignature.ImageLarge = My.Resources.IncludeSignature
        Me.includeSignature.ImageSmall = My.Resources.IncludeSignatureSmall
        Me.includeSignature.KeyTip = "G"
        Me.includeSignature.KryptonContextMenu = Me.cmsSignatures
        Me.includeSignature.TextLine1 = "Signature"
        Me.groupOptions.Image = My.Resources.OptionsFollowUpSmall
        Me.groupOptions.Items.AddRange(New Krypton.Ribbon.KryptonRibbonGroupContainer() { Me.optionsTripleFollowup})
        Me.groupOptions.KeyTipDialogLauncher = "OP"
        Me.groupOptions.KeyTipGroup = "ZO"
        Me.groupOptions.TextLine1 = "Tags"
        Me.optionsTripleFollowup.Items.AddRange(New Krypton.Ribbon.KryptonRibbonGroupItem() { Me.optionsFollowUp, Me.optionsHighImportance, Me.optionsLowImportance})
        Me.optionsTripleFollowup.MaximumSize = Krypton.Ribbon.GroupItemSize.Medium
        Me.optionsTripleFollowup.MinimumSize = Krypton.Ribbon.GroupItemSize.Medium
        Me.optionsFollowUp.ButtonType = Krypton.Ribbon.GroupButtonType.DropDown
        Me.optionsFollowUp.ImageLarge = My.Resources.OptionsFollowUp
        Me.optionsFollowUp.ImageSmall = My.Resources.FollowUp1
        Me.optionsFollowUp.KeyTip = "W"
        Me.optionsFollowUp.KryptonContextMenu = Me.cmsFollowUp
        Me.optionsFollowUp.TextLine1 = "Follow"
        Me.optionsFollowUp.TextLine2 = "Up"
        Me.optionsHighImportance.ImageLarge = Nothing
        Me.optionsHighImportance.ImageSmall = My.Resources.OptionsHighImportance
        Me.optionsHighImportance.KeyTip = "H"
        Me.optionsHighImportance.TextLine1 = "High"
        Me.optionsHighImportance.TextLine2 = "Importance"
        Me.optionsLowImportance.ImageLarge = Nothing
        Me.optionsLowImportance.ImageSmall = My.Resources.OptionsLowImportance
        Me.optionsLowImportance.KeyTip = "L"
        Me.optionsLowImportance.TextLine1 = "Low"
        Me.optionsLowImportance.TextLine2 = "Importance"
        Me.groupZoom.AllowCollapsed = False
        Me.groupZoom.DialogBoxLauncher = False
        Me.groupZoom.Image = Nothing
        Me.groupZoom.Items.AddRange(New Krypton.Ribbon.KryptonRibbonGroupContainer() { Me.proofingTriple})
        Me.groupZoom.KeyTipGroup = "Q"
        Me.groupZoom.TextLine1 = "Zoom"
        Me.proofingTriple.Items.AddRange(New Krypton.Ribbon.KryptonRibbonGroupItem() { Me.zoomMessageZoom})
        Me.proofingTriple.MinimumSize = Krypton.Ribbon.GroupItemSize.Large
        Me.zoomMessageZoom.ImageLarge = My.Resources.ZoomLarge
        Me.zoomMessageZoom.ImageSmall = Nothing
        Me.zoomMessageZoom.KeyTip = "Q"
        Me.zoomMessageZoom.TextLine1 = "Zoom"
        Me.tabInsert.Groups.AddRange(New Krypton.Ribbon.KryptonRibbonGroup() { Me.groupInsertInclude, Me.groupTables, Me.groupInsertIllustrations, Me.groupLinks, Me.groupText, Me.groupSymbols})
        Me.tabInsert.KeyTip = "N"
        Me.tabInsert.Text = "Insert"
        Me.groupInsertInclude.AllowCollapsed = False
        Me.groupInsertInclude.Image = Nothing
        Me.groupInsertInclude.Items.AddRange(New Krypton.Ribbon.KryptonRibbonGroupContainer() { Me.kryptonRibbonGroupTriple4, Me.kryptonRibbonGroupTriple5})
        Me.groupInsertInclude.KeyTipDialogLauncher = "AP"
        Me.groupInsertInclude.TextLine1 = "Include"
        Me.kryptonRibbonGroupTriple4.Items.AddRange(New Krypton.Ribbon.KryptonRibbonGroupItem() { Me.includeInsertAttachFile, Me.includeInsertAttachItem})
        Me.includeInsertAttachFile.ImageLarge = My.Resources.IncludeAttachFile
        Me.includeInsertAttachFile.ImageSmall = My.Resources.IncludeAttachFileSmall
        Me.includeInsertAttachFile.KeyTip = "AF"
        Me.includeInsertAttachFile.TextLine1 = "Attach"
        Me.includeInsertAttachFile.TextLine2 = "File"
        Me.includeInsertAttachItem.ImageLarge = My.Resources.IncludeAttachItem
        Me.includeInsertAttachItem.ImageSmall = My.Resources.IncludeAttachItemSmall
        Me.includeInsertAttachItem.KeyTip = "AM"
        Me.includeInsertAttachItem.TextLine1 = "Attach"
        Me.includeInsertAttachItem.TextLine2 = "Item"
        Me.kryptonRibbonGroupTriple5.Items.AddRange(New Krypton.Ribbon.KryptonRibbonGroupItem() { Me.includeInsertBusinessCard, Me.includeInsertCalendar, Me.includeInsertSignature})
        Me.includeInsertBusinessCard.ButtonType = Krypton.Ribbon.GroupButtonType.DropDown
        Me.includeInsertBusinessCard.ImageLarge = My.Resources.IncludeBusinessCard
        Me.includeInsertBusinessCard.ImageSmall = My.Resources.IncludeBusinessCardSmall
        Me.includeInsertBusinessCard.KeyTip = "AA"
        Me.includeInsertBusinessCard.KryptonContextMenu = Me.cmsBusinessCards
        Me.includeInsertBusinessCard.TextLine1 = "Business"
        Me.includeInsertBusinessCard.TextLine2 = "Card"
        Me.includeInsertCalendar.ImageLarge = My.Resources.IncludeCalendar
        Me.includeInsertCalendar.ImageSmall = My.Resources.IncludeCalendarSmall
        Me.includeInsertCalendar.KeyTip = "OC"
        Me.includeInsertCalendar.TextLine1 = "Calendar"
        Me.includeInsertSignature.ButtonType = Krypton.Ribbon.GroupButtonType.DropDown
        Me.includeInsertSignature.ImageLarge = My.Resources.IncludeSignature
        Me.includeInsertSignature.ImageSmall = My.Resources.IncludeSignatureSmall
        Me.includeInsertSignature.KeyTip = "G"
        Me.includeInsertSignature.KryptonContextMenu = Me.cmsSignatures
        Me.includeInsertSignature.TextLine1 = "Signature"
        Me.groupTables.AllowCollapsed = False
        Me.groupTables.DialogBoxLauncher = False
        Me.groupTables.Image = Nothing
        Me.groupTables.Items.AddRange(New Krypton.Ribbon.KryptonRibbonGroupContainer() { Me.kryptonRibbonGroupTriple3})
        Me.groupTables.TextLine1 = "Tables"
        Me.kryptonRibbonGroupTriple3.Items.AddRange(New Krypton.Ribbon.KryptonRibbonGroupItem() { Me.tablesTable})
        Me.kryptonRibbonGroupTriple3.MinimumSize = Krypton.Ribbon.GroupItemSize.Large
        Me.tablesTable.ButtonType = Krypton.Ribbon.GroupButtonType.DropDown
        Me.tablesTable.ImageLarge = My.Resources.TablesLarge
        Me.tablesTable.ImageSmall = Nothing
        Me.tablesTable.KryptonContextMenu = Me.cmsTable
        Me.tablesTable.TextLine1 = "Table"
        Me.groupInsertIllustrations.AllowCollapsed = False
        Me.groupInsertIllustrations.DialogBoxLauncher = False
        Me.groupInsertIllustrations.Image = Nothing
        Me.groupInsertIllustrations.Items.AddRange(New Krypton.Ribbon.KryptonRibbonGroupContainer() { Me.kryptonRibbonGroupTriple6, Me.kryptonRibbonGroupTriple7})
        Me.groupInsertIllustrations.TextLine1 = "Illustrations"
        Me.kryptonRibbonGroupTriple6.Items.AddRange(New Krypton.Ribbon.KryptonRibbonGroupItem() { Me.illustrationsPicture, Me.illustrationsClipArt})
        Me.kryptonRibbonGroupTriple6.MinimumSize = Krypton.Ribbon.GroupItemSize.Large
        Me.illustrationsPicture.ImageLarge = My.Resources.PicturesLarge
        Me.illustrationsPicture.ImageSmall = Nothing
        Me.illustrationsPicture.KeyTip = "P"
        Me.illustrationsPicture.TextLine1 = "Picture"
        Me.illustrationsClipArt.ImageLarge = My.Resources.ClipArtLarge
        Me.illustrationsClipArt.ImageSmall = Nothing
        Me.illustrationsClipArt.KeyTip = "F"
        Me.illustrationsClipArt.TextLine1 = "Clip"
        Me.illustrationsClipArt.TextLine2 = "Art"
        Me.kryptonRibbonGroupTriple7.Items.AddRange(New Krypton.Ribbon.KryptonRibbonGroupItem() { Me.illustrationsShapes, Me.illustrationsSmartArt, Me.illustrationsChart})
        Me.illustrationsShapes.ButtonType = Krypton.Ribbon.GroupButtonType.DropDown
        Me.illustrationsShapes.ImageLarge = My.Resources.ShapesLarge
        Me.illustrationsShapes.ImageSmall = My.Resources.ShapesSmall
        Me.illustrationsShapes.KeyTip = "SH"
        Me.illustrationsShapes.KryptonContextMenu = Me.cmsShapes
        Me.illustrationsShapes.TextLine1 = "Shapes"
        Me.illustrationsSmartArt.ImageLarge = My.Resources.SmartArtLarge
        Me.illustrationsSmartArt.ImageSmall = My.Resources.SmartArtSmall
        Me.illustrationsSmartArt.KeyTip = "M"
        Me.illustrationsSmartArt.TextLine1 = "SmartArt"
        Me.illustrationsChart.ImageLarge = My.Resources.ChartLarge
        Me.illustrationsChart.ImageSmall = My.Resources.ChartSmall
        Me.illustrationsChart.KeyTip = "C"
        Me.illustrationsChart.TextLine1 = "Chart"
        Me.groupLinks.DialogBoxLauncher = False
        Me.groupLinks.Image = My.Resources.HyperlinkSmall
        Me.groupLinks.Items.AddRange(New Krypton.Ribbon.KryptonRibbonGroupContainer() { Me.kryptonRibbonGroupTriple2})
        Me.groupLinks.KeyTipGroup = "ZL"
        Me.groupLinks.TextLine1 = "Links"
        Me.kryptonRibbonGroupTriple2.Items.AddRange(New Krypton.Ribbon.KryptonRibbonGroupItem() { Me.linksHyperlink, Me.linksBookmark})
        Me.kryptonRibbonGroupTriple2.MinimumSize = Krypton.Ribbon.GroupItemSize.Medium
        Me.linksHyperlink.ImageLarge = My.Resources.HyperlinkLarge
        Me.linksHyperlink.ImageSmall = My.Resources.HyperlinkSmall
        Me.linksHyperlink.KeyTip = "I"
        Me.linksHyperlink.TextLine1 = "Hyperlink"
        Me.linksBookmark.ImageLarge = My.Resources.BookmarkLarge
        Me.linksBookmark.ImageSmall = My.Resources.BookmarkSmall
        Me.linksBookmark.KeyTip = "K"
        Me.linksBookmark.TextLine1 = "Bookmark"
        Me.groupText.DialogBoxLauncher = False
        Me.groupText.Image = My.Resources.WordArtSmall
        Me.groupText.Items.AddRange(New Krypton.Ribbon.KryptonRibbonGroupContainer() { Me.kryptonRibbonGroupTriple8, Me.kryptonRibbonGroupTriple9})
        Me.groupText.KeyTipGroup = "ZT"
        Me.groupText.TextLine1 = "Text"
        Me.kryptonRibbonGroupTriple8.Items.AddRange(New Krypton.Ribbon.KryptonRibbonGroupItem() { Me.textTextBox, Me.textQuickParts, Me.textWordArt})
        Me.kryptonRibbonGroupTriple8.MinimumSize = Krypton.Ribbon.GroupItemSize.Medium
        Me.textTextBox.ButtonType = Krypton.Ribbon.GroupButtonType.DropDown
        Me.textTextBox.ImageLarge = My.Resources.TextBoxLarge
        Me.textTextBox.ImageSmall = My.Resources.TextBoxSmall
        Me.textTextBox.KeyTip = "X"
        Me.textTextBox.KryptonContextMenu = Me.cmsTextBox
        Me.textTextBox.TextLine1 = "Text"
        Me.textTextBox.TextLine2 = "Box"
        Me.textQuickParts.ButtonType = Krypton.Ribbon.GroupButtonType.DropDown
        Me.textQuickParts.ImageLarge = My.Resources.QuickPartsLarge
        Me.textQuickParts.ImageSmall = My.Resources.QuickPartsSmall
        Me.textQuickParts.KeyTip = "Q"
        Me.textQuickParts.KryptonContextMenu = Me.cmsQuickParts
        Me.textQuickParts.TextLine1 = "Quick"
        Me.textQuickParts.TextLine2 = "Parts"
        Me.textWordArt.ImageLarge = My.Resources.WordArtLarge
        Me.textWordArt.ImageSmall = My.Resources.WordArtSmall
        Me.textWordArt.KeyTip = "W"
        Me.textWordArt.TextLine1 = "WordArt"
        Me.kryptonRibbonGroupTriple9.Items.AddRange(New Krypton.Ribbon.KryptonRibbonGroupItem() { Me.textDropCap, Me.textDateAndTime, Me.textObject})
        Me.kryptonRibbonGroupTriple9.MaximumSize = Krypton.Ribbon.GroupItemSize.Medium
        Me.textDropCap.ButtonType = Krypton.Ribbon.GroupButtonType.DropDown
        Me.textDropCap.ImageLarge = Nothing
        Me.textDropCap.ImageSmall = My.Resources.DropCapSmall
        Me.textDropCap.KeyTip = "RC"
        Me.textDropCap.KryptonContextMenu = Me.cmsDropCap
        Me.textDropCap.TextLine1 = "Drop"
        Me.textDropCap.TextLine2 = "Cap"
        Me.textDateAndTime.ImageLarge = Nothing
        Me.textDateAndTime.ImageSmall = My.Resources.DateTimeSmall
        Me.textDateAndTime.KeyTip = "D"
        Me.textDateAndTime.TextLine1 = "Date &"
        Me.textDateAndTime.TextLine2 = "Time"
        Me.textObject.ImageLarge = Nothing
        Me.textObject.ImageSmall = My.Resources.ObjectSmall
        Me.textObject.KeyTip = "J"
        Me.textObject.TextLine1 = "Object"
        Me.groupSymbols.DialogBoxLauncher = False
        Me.groupSymbols.Image = My.Resources.EquationSmall
        Me.groupSymbols.Items.AddRange(New Krypton.Ribbon.KryptonRibbonGroupContainer() { Me.kryptonRibbonGroupTriple1})
        Me.groupSymbols.KeyTipGroup = "ZS"
        Me.groupSymbols.TextLine1 = "Symbols"
        Me.kryptonRibbonGroupTriple1.Items.AddRange(New Krypton.Ribbon.KryptonRibbonGroupItem() { Me.symbolsEquation, Me.symbolSymbol, Me.symbolHorizontalLine})
        Me.kryptonRibbonGroupTriple1.MinimumSize = Krypton.Ribbon.GroupItemSize.Medium
        Me.symbolsEquation.ButtonType = Krypton.Ribbon.GroupButtonType.DropDown
        Me.symbolsEquation.ImageLarge = My.Resources.EquationLarge
        Me.symbolsEquation.ImageSmall = My.Resources.EquationSmall
        Me.symbolsEquation.KeyTip = "E"
        Me.symbolsEquation.KryptonContextMenu = Me.cmsEquation
        Me.symbolsEquation.TextLine1 = "Equation"
        Me.symbolSymbol.ButtonType = Krypton.Ribbon.GroupButtonType.DropDown
        Me.symbolSymbol.ImageLarge = My.Resources.SymbolLarge
        Me.symbolSymbol.ImageSmall = My.Resources.SymbolSmall
        Me.symbolSymbol.KeyTip = "U"
        Me.symbolSymbol.KryptonContextMenu = Me.cmsSymbol
        Me.symbolSymbol.TextLine1 = "Symbol"
        Me.symbolHorizontalLine.ImageLarge = My.Resources.HorizontalLineLarge
        Me.symbolHorizontalLine.ImageSmall = My.Resources.HorizontalLineSmall
        Me.symbolHorizontalLine.KeyTip = "H"
        Me.symbolHorizontalLine.TextLine1 = "Horizontal"
        Me.symbolHorizontalLine.TextLine2 = "Line"
        Me.tabOptions.Groups.AddRange(New Krypton.Ribbon.KryptonRibbonGroup() { Me.groupOptionsThemes, Me.groupFields, Me.groupFormat, Me.groupTracking, Me.groupMoreOptions})
        Me.tabOptions.KeyTip = "P"
        Me.tabOptions.Text = "Options"
        Me.groupOptionsThemes.DialogBoxLauncher = False
        Me.groupOptionsThemes.Image = My.Resources.ThemesSmall
        Me.groupOptionsThemes.Items.AddRange(New Krypton.Ribbon.KryptonRibbonGroupContainer() { Me.kryptonRibbonGroupTriple10, Me.kryptonRibbonGroupTriple11, Me.kryptonRibbonGroupSeparator1, Me.kryptonRibbonGroupTriple12})
        Me.groupOptionsThemes.KeyTipGroup = "ZT"
        Me.groupOptionsThemes.TextLine1 = "Themes"
        Me.kryptonRibbonGroupTriple10.Items.AddRange(New Krypton.Ribbon.KryptonRibbonGroupItem() { Me.themesTheme})
        Me.kryptonRibbonGroupTriple10.MinimumSize = Krypton.Ribbon.GroupItemSize.Large
        Me.themesTheme.ButtonType = Krypton.Ribbon.GroupButtonType.DropDown
        Me.themesTheme.ImageLarge = My.Resources.ThemesLarge
        Me.themesTheme.ImageSmall = Nothing
        Me.themesTheme.KeyTip = "TH"
        Me.themesTheme.KryptonContextMenu = Me.cmsThemes
        Me.themesTheme.TextLine1 = "Themes"
        Me.kryptonRibbonGroupTriple11.Items.AddRange(New Krypton.Ribbon.KryptonRibbonGroupItem() { Me.themesColors, Me.themesFonts, Me.themesEffects})
        Me.kryptonRibbonGroupTriple11.MaximumSize = Krypton.Ribbon.GroupItemSize.Medium
        Me.themesColors.ImageLarge = Nothing
        Me.themesColors.ImageSmall = My.Resources.ColorsSmall
        Me.themesColors.KeyTip = "TC"
        Me.themesColors.TextLine1 = "Colors"
        Me.themesFonts.ImageLarge = Nothing
        Me.themesFonts.ImageSmall = My.Resources.FontsSmall
        Me.themesFonts.KeyTip = "TF"
        Me.themesFonts.TextLine1 = "Fonts"
        Me.themesEffects.ImageLarge = Nothing
        Me.themesEffects.ImageSmall = My.Resources.EffectsSmall
        Me.themesEffects.KeyTip = "TE"
        Me.themesEffects.TextLine1 = "Effects"
        Me.kryptonRibbonGroupTriple12.Items.AddRange(New Krypton.Ribbon.KryptonRibbonGroupItem() { Me.themesPageColor, Me.kryptonRibbonGroupThemeComboBox1})
        Me.kryptonRibbonGroupTriple12.MinimumSize = Krypton.Ribbon.GroupItemSize.Large
        Me.themesPageColor.ButtonType = Krypton.Ribbon.GroupButtonType.DropDown
        Me.themesPageColor.ImageLarge = My.Resources.PageColorLarge
        Me.themesPageColor.ImageSmall = Nothing
        Me.themesPageColor.KeyTip = "PC"
        Me.themesPageColor.KryptonContextMenu = Me.cmsPageColor
        Me.themesPageColor.TextLine1 = "Page"
        Me.themesPageColor.TextLine2 = "Color"
        Me.kryptonRibbonGroupThemeComboBox1.DefaultPalette = Krypton.Toolkit.PaletteMode.Office2007Black
        Me.kryptonRibbonGroupThemeComboBox1.DisplayMember = "Key"
        Me.kryptonRibbonGroupThemeComboBox1.DropDownHeight = 300
        Me.kryptonRibbonGroupThemeComboBox1.DropDownWidth = 350
        Me.kryptonRibbonGroupThemeComboBox1.FormattingEnabled = False
        Me.kryptonRibbonGroupThemeComboBox1.ItemHeight = 20
        Me.kryptonRibbonGroupThemeComboBox1.ValueMember = "Value"
        Me.groupFields.DialogBoxLauncher = False
        Me.groupFields.Image = My.Resources.FieldsSmall
        Me.groupFields.Items.AddRange(New Krypton.Ribbon.KryptonRibbonGroupContainer() { Me.kryptonRibbonGroupTriple13})
        Me.groupFields.KeyTipGroup = "ZF"
        Me.groupFields.TextLine1 = "Fields"
        Me.kryptonRibbonGroupTriple13.Items.AddRange(New Krypton.Ribbon.KryptonRibbonGroupItem() { Me.fieldsShowBcc, Me.fieldsShowFrom})
        Me.kryptonRibbonGroupTriple13.MinimumSize = Krypton.Ribbon.GroupItemSize.Large
        Me.fieldsShowBcc.ButtonType = Krypton.Ribbon.GroupButtonType.Check
        Me.fieldsShowBcc.ImageLarge = My.Resources.ShowBccLarge
        Me.fieldsShowBcc.ImageSmall = Nothing
        Me.fieldsShowBcc.TextLine1 = "Bcc"
        Me.fieldsShowFrom.ButtonType = Krypton.Ribbon.GroupButtonType.Check
        Me.fieldsShowFrom.ImageLarge = My.Resources.ShowFromLarge
        Me.fieldsShowFrom.ImageSmall = Nothing
        Me.fieldsShowFrom.KeyTip = "F"
        Me.fieldsShowFrom.TextLine1 = "From"
        Me.groupFormat.AllowCollapsed = False
        Me.groupFormat.DialogBoxLauncher = False
        Me.groupFormat.Image = Nothing
        Me.groupFormat.Items.AddRange(New Krypton.Ribbon.KryptonRibbonGroupContainer() { Me.kryptonRibbonGroupTriple14})
        Me.groupFormat.TextLine1 = "Format"
        Me.kryptonRibbonGroupTriple14.Items.AddRange(New Krypton.Ribbon.KryptonRibbonGroupItem() { Me.formatPlainText, Me.formatHTML, Me.formatRichText})
        Me.kryptonRibbonGroupTriple14.MaximumSize = Krypton.Ribbon.GroupItemSize.Medium
        Me.kryptonRibbonGroupTriple14.MinimumSize = Krypton.Ribbon.GroupItemSize.Medium
        Me.formatPlainText.ButtonType = Krypton.Ribbon.GroupButtonType.Check
        Me.formatPlainText.ImageLarge = Nothing
        Me.formatPlainText.ImageSmall = My.Resources.PlainTextSmall
        Me.formatPlainText.KeyTip = "L"
        Me.formatPlainText.TextLine1 = "Plain"
        Me.formatPlainText.TextLine2 = "Text"
        Me.formatHTML.ButtonType = Krypton.Ribbon.GroupButtonType.Check
        Me.formatHTML.Checked = True
        Me.formatHTML.ImageLarge = Nothing
        Me.formatHTML.ImageSmall = My.Resources.HTMLSmall
        Me.formatHTML.KeyTip = "H"
        Me.formatHTML.TextLine1 = "HTML"
        Me.formatRichText.ButtonType = Krypton.Ribbon.GroupButtonType.Check
        Me.formatRichText.ImageLarge = Nothing
        Me.formatRichText.ImageSmall = My.Resources.RichTextSmall
        Me.formatRichText.KeyTip = "R"
        Me.formatRichText.TextLine1 = "Rich"
        Me.formatRichText.TextLine2 = "Text"
        Me.groupTracking.Image = My.Resources.TrackingSmall
        Me.groupTracking.Items.AddRange(New Krypton.Ribbon.KryptonRibbonGroupContainer() { Me.kryptonRibbonGroupTriple15, Me.kryptonRibbonGroupLines3})
        Me.groupTracking.KeyTipDialogLauncher = "OP"
        Me.groupTracking.KeyTipGroup = "ZK"
        Me.groupTracking.TextLine1 = "Tracking"
        Me.kryptonRibbonGroupTriple15.Items.AddRange(New Krypton.Ribbon.KryptonRibbonGroupItem() { Me.trackingUseVotingButtons})
        Me.kryptonRibbonGroupTriple15.MinimumSize = Krypton.Ribbon.GroupItemSize.Large
        Me.trackingUseVotingButtons.ButtonType = Krypton.Ribbon.GroupButtonType.DropDown
        Me.trackingUseVotingButtons.ImageLarge = My.Resources.UseVotingButtonsLarge
        Me.trackingUseVotingButtons.ImageSmall = Nothing
        Me.trackingUseVotingButtons.KeyTip = "V"
        Me.trackingUseVotingButtons.KryptonContextMenu = Me.cmsUseVotingButtons
        Me.trackingUseVotingButtons.TextLine1 = "Use Voting"
        Me.trackingUseVotingButtons.TextLine2 = "Buttons"
        Me.kryptonRibbonGroupLines3.Items.AddRange(New Krypton.Ribbon.KryptonRibbonGroupItem() { Me.kryptonRibbonGroupCheckBox1, Me.kryptonRibbonGroupCheckBox2})
        Me.kryptonRibbonGroupLines3.MinimumSize = Krypton.Ribbon.GroupItemSize.Large
        Me.kryptonRibbonGroupCheckBox1.TextLine1 = "Request a Delivery Receipt"
        Me.kryptonRibbonGroupCheckBox2.TextLine1 = "Request a Read Receipt"
        Me.groupMoreOptions.Image = My.Resources.MoreOptionsSmall
        Me.groupMoreOptions.Items.AddRange(New Krypton.Ribbon.KryptonRibbonGroupContainer() { Me.kryptonRibbonGroupTriple16})
        Me.groupMoreOptions.KeyTipDialogLauncher = "OP"
        Me.groupMoreOptions.KeyTipGroup = "ZP"
        Me.groupMoreOptions.TextLine1 = "More"
        Me.groupMoreOptions.TextLine2 = "Options"
        Me.kryptonRibbonGroupTriple16.Items.AddRange(New Krypton.Ribbon.KryptonRibbonGroupItem() { Me.moreOptionsSaveSentItem, Me.moreOptionsDelayDelivery, Me.moreOptionsDirectRepliesTo})
        Me.kryptonRibbonGroupTriple16.MinimumSize = Krypton.Ribbon.GroupItemSize.Medium
        Me.moreOptionsSaveSentItem.ButtonType = Krypton.Ribbon.GroupButtonType.DropDown
        Me.moreOptionsSaveSentItem.ImageLarge = My.Resources.SaveSentItemLarge
        Me.moreOptionsSaveSentItem.ImageSmall = My.Resources.MoreOptionsSmall
        Me.moreOptionsSaveSentItem.KeyTip = "S"
        Me.moreOptionsSaveSentItem.KryptonContextMenu = Me.cmsSaveSentItem
        Me.moreOptionsSaveSentItem.TextLine1 = "Save Sent"
        Me.moreOptionsSaveSentItem.TextLine2 = "Item"
        Me.moreOptionsDelayDelivery.ButtonType = Krypton.Ribbon.GroupButtonType.Check
        Me.moreOptionsDelayDelivery.ImageLarge = My.Resources.DelayDeliveryLarge
        Me.moreOptionsDelayDelivery.ImageSmall = My.Resources.DelayDeliverySmall
        Me.moreOptionsDelayDelivery.KeyTip = "D"
        Me.moreOptionsDelayDelivery.TextLine1 = "Delay"
        Me.moreOptionsDelayDelivery.TextLine2 = "Delivery"
        Me.moreOptionsDirectRepliesTo.ButtonType = Krypton.Ribbon.GroupButtonType.Check
        Me.moreOptionsDirectRepliesTo.ImageLarge = My.Resources.DirectRepliesToLarge
        Me.moreOptionsDirectRepliesTo.ImageSmall = My.Resources.DrawingCanvasSmall
        Me.moreOptionsDirectRepliesTo.KeyTip = "I"
        Me.moreOptionsDirectRepliesTo.TextLine1 = "Direct"
        Me.moreOptionsDirectRepliesTo.TextLine2 = "Replies To"
        Me.tabFormatText.Groups.AddRange(New Krypton.Ribbon.KryptonRibbonGroup() { Me.groupFormatClipboard, Me.groupFormatFont, Me.groupFormatParagraph, Me.groupFormatStyles, Me.groupFormatZoom, Me.groupFormatEditing})
        Me.tabFormatText.KeyTip = "O"
        Me.tabFormatText.Text = "Format Text"
        Me.groupFormatClipboard.AllowCollapsed = False
        Me.groupFormatClipboard.Image = My.Resources.ClipboardPasteSmall
        Me.groupFormatClipboard.Items.AddRange(New Krypton.Ribbon.KryptonRibbonGroupContainer() { Me.kryptonRibbonGroupTriple17, Me.kryptonRibbonGroupTriple18})
        Me.groupFormatClipboard.KeyTipDialogLauncher = "FO"
        Me.groupFormatClipboard.TextLine1 = "Clipboard"
        Me.kryptonRibbonGroupTriple17.Items.AddRange(New Krypton.Ribbon.KryptonRibbonGroupItem() { Me.formatClipboardPaste})
        Me.kryptonRibbonGroupTriple17.MinimumSize = Krypton.Ribbon.GroupItemSize.Large
        Me.formatClipboardPaste.ButtonType = Krypton.Ribbon.GroupButtonType.Split
        Me.formatClipboardPaste.ImageLarge = My.Resources.ClipboardPaste
        Me.formatClipboardPaste.ImageSmall = Nothing
        Me.formatClipboardPaste.KeyTip = "V"
        Me.formatClipboardPaste.KryptonContextMenu = Me.cmsPaste
        Me.formatClipboardPaste.TextLine1 = "Paste"
        Me.kryptonRibbonGroupTriple18.Items.AddRange(New Krypton.Ribbon.KryptonRibbonGroupItem() { Me.formatClipboardCut, Me.formatClipboardCopy, Me.formatClipboardFormatPainter})
        Me.kryptonRibbonGroupTriple18.MaximumSize = Krypton.Ribbon.GroupItemSize.Medium
        Me.formatClipboardCut.ImageLarge = Nothing
        Me.formatClipboardCut.ImageSmall = My.Resources.ClipboardCut
        Me.formatClipboardCut.KeyTip = "X"
        Me.formatClipboardCut.TextLine1 = "Cut"
        Me.formatClipboardCopy.ImageLarge = Nothing
        Me.formatClipboardCopy.ImageSmall = My.Resources.ClipboardCopy
        Me.formatClipboardCopy.KeyTip = "C"
        Me.formatClipboardCopy.TextLine1 = "Copy"
        Me.formatClipboardFormatPainter.ImageLarge = Nothing
        Me.formatClipboardFormatPainter.ImageSmall = My.Resources.ClipboardFormatPainter
        Me.formatClipboardFormatPainter.KeyTip = "FP"
        Me.formatClipboardFormatPainter.TextLine1 = "Format"
        Me.formatClipboardFormatPainter.TextLine2 = "Painter"
        Me.groupFormatFont.Image = My.Resources.TextColor
        Me.groupFormatFont.Items.AddRange(New Krypton.Ribbon.KryptonRibbonGroupContainer() { Me.kryptonRibbonGroupLines1})
        Me.groupFormatFont.KeyTipDialogLauncher = "FN"
        Me.groupFormatFont.KeyTipGroup = "ZF"
        Me.groupFormatFont.TextLine1 = "Font"
        Me.kryptonRibbonGroupLines1.Items.AddRange(New Krypton.Ribbon.KryptonRibbonGroupItem() { Me.kryptonRibbonGroupCluster1, Me.kryptonRibbonGroupCluster2, Me.kryptonRibbonGroupCluster4, Me.kryptonRibbonGroupCluster3})
        Me.kryptonRibbonGroupCluster1.Items.AddRange(New Krypton.Ribbon.KryptonRibbonGroupItem() { Me.fontGrowFont, Me.fontShrinkFont})
        Me.fontGrowFont.ImageSmall = My.Resources.TextFontLarger
        Me.fontGrowFont.KeyTip = "FG"
        Me.fontShrinkFont.ImageSmall = My.Resources.TextFontSmaller
        Me.fontShrinkFont.KeyTip = "FK"
        Me.kryptonRibbonGroupCluster2.Items.AddRange(New Krypton.Ribbon.KryptonRibbonGroupItem() { Me.fontTextClear})
        Me.fontTextClear.ImageSmall = My.Resources.TextRubout
        Me.fontTextClear.KeyTip = "E"
        Me.kryptonRibbonGroupCluster4.Items.AddRange(New Krypton.Ribbon.KryptonRibbonGroupItem() { Me.fontTextBackColor, Me.textFontColor})
        Me.fontTextBackColor.ImageSmall = My.Resources.TextBackColor
        Me.fontTextBackColor.KeyTip = "I"
        Me.textFontColor.ImageSmall = My.Resources.TextColor
        Me.textFontColor.KeyTip = "FC"
        Me.kryptonRibbonGroupCluster3.Items.AddRange(New Krypton.Ribbon.KryptonRibbonGroupItem() { Me.fontBold, Me.fontItalic, Me.fontUnderline, Me.fontStrikethrough, Me.fontSubscript, Me.fontSuperscript, Me.fontChangeCase})
        Me.fontBold.ImageSmall = My.Resources.TextBold
        Me.fontBold.KeyTip = "1"
        Me.fontItalic.ImageSmall = My.Resources.TextItalics
        Me.fontItalic.KeyTip = "2"
        Me.fontUnderline.ImageSmall = My.Resources.TextUnderline
        Me.fontUnderline.KeyTip = "3"
        Me.fontStrikethrough.ImageSmall = My.Resources.TextStrikeout
        Me.fontStrikethrough.KeyTip = "4"
        Me.fontSubscript.ImageSmall = My.Resources.TextSubscript
        Me.fontSubscript.KeyTip = "5"
        Me.fontSuperscript.ImageSmall = My.Resources.TextSuperscript
        Me.fontSuperscript.KeyTip = "6"
        Me.fontChangeCase.ButtonType = Krypton.Ribbon.GroupButtonType.DropDown
        Me.fontChangeCase.ImageSmall = My.Resources.TextChangeCase
        Me.fontChangeCase.KeyTip = "7"
        Me.fontChangeCase.KryptonContextMenu = Me.cmsChangeCase
        Me.groupFormatParagraph.Image = My.Resources.TextAlignCenter
        Me.groupFormatParagraph.Items.AddRange(New Krypton.Ribbon.KryptonRibbonGroupContainer() { Me.kryptonRibbonGroupLines2})
        Me.groupFormatParagraph.KeyTipDialogLauncher = "PG"
        Me.groupFormatParagraph.KeyTipGroup = "ZP"
        Me.groupFormatParagraph.TextLine1 = "Paragraph"
        Me.kryptonRibbonGroupLines2.Items.AddRange(New Krypton.Ribbon.KryptonRibbonGroupItem() { Me.kryptonRibbonGroupCluster5, Me.kryptonRibbonGroupCluster6, Me.kryptonRibbonGroupCluster7, Me.kryptonRibbonGroupCluster8, Me.kryptonRibbonGroupCluster9, Me.kryptonRibbonGroupCluster10, Me.kryptonRibbonGroupCluster11})
        Me.kryptonRibbonGroupCluster5.Items.AddRange(New Krypton.Ribbon.KryptonRibbonGroupItem() { Me.fontBullets, Me.fontNumbers, Me.fontMultilevel})
        Me.fontBullets.ImageSmall = My.Resources.TextBulletPoints
        Me.fontBullets.KeyTip = "U"
        Me.fontNumbers.ImageSmall = My.Resources.TextBulletNumbers
        Me.fontNumbers.KeyTip = "N"
        Me.fontMultilevel.ImageSmall = My.Resources.MultiLevelList
        Me.fontMultilevel.KeyTip = "M"
        Me.kryptonRibbonGroupCluster6.Items.AddRange(New Krypton.Ribbon.KryptonRibbonGroupItem() { Me.fontDecreaseIndent, Me.fontIncreaseIndent})
        Me.fontDecreaseIndent.ImageSmall = My.Resources.TextTabLeft
        Me.fontDecreaseIndent.KeyTip = "AO"
        Me.fontIncreaseIndent.ImageSmall = My.Resources.TextTabRight
        Me.fontIncreaseIndent.KeyTip = "AI"
        Me.kryptonRibbonGroupCluster7.Items.AddRange(New Krypton.Ribbon.KryptonRibbonGroupItem() { Me.fontSort})
        Me.fontSort.ImageSmall = My.Resources.SortAscending
        Me.fontSort.KeyTip = "SO"
        Me.kryptonRibbonGroupCluster8.Items.AddRange(New Krypton.Ribbon.KryptonRibbonGroupItem() { Me.fontMarkers})
        Me.fontMarkers.ImageSmall = My.Resources.TextShowHideMarkup
        Me.fontMarkers.KeyTip = "8"
        Me.kryptonRibbonGroupCluster9.Items.AddRange(New Krypton.Ribbon.KryptonRibbonGroupItem() { Me.fontJustifyLeft, Me.fontJustifyCenter, Me.fontJustifyRight, Me.fontJustify})
        Me.fontJustifyLeft.ImageSmall = My.Resources.TextAlignLeft
        Me.fontJustifyLeft.KeyTip = "AL"
        Me.fontJustifyCenter.ImageSmall = My.Resources.TextAlignCenter
        Me.fontJustifyCenter.KeyTip = "AC"
        Me.fontJustifyRight.ImageSmall = My.Resources.TextAlignRight
        Me.fontJustifyRight.KeyTip = "AR"
        Me.fontJustify.ImageSmall = My.Resources.TextJustify
        Me.fontJustify.KeyTip = "AJ"
        Me.kryptonRibbonGroupCluster10.Items.AddRange(New Krypton.Ribbon.KryptonRibbonGroupItem() { Me.fontSpacing})
        Me.fontSpacing.ButtonType = Krypton.Ribbon.GroupButtonType.DropDown
        Me.fontSpacing.ImageSmall = My.Resources.LineSpacing
        Me.fontSpacing.KeyTip = "K"
        Me.fontSpacing.KryptonContextMenu = Me.cmsSpacing
        Me.kryptonRibbonGroupCluster11.Items.AddRange(New Krypton.Ribbon.KryptonRibbonGroupItem() { Me.fontShading, Me.fontBottomBorder})
        Me.fontShading.ImageSmall = My.Resources.Shading
        Me.fontShading.KeyTip = "H"
        Me.fontBottomBorder.ButtonType = Krypton.Ribbon.GroupButtonType.Split
        Me.fontBottomBorder.ImageSmall = My.Resources.BottomBorder
        Me.fontBottomBorder.KryptonContextMenu = Me.cmsBottomBorder
        Me.groupFormatStyles.AllowCollapsed = False
        Me.groupFormatStyles.Image = Nothing
        Me.groupFormatStyles.Items.AddRange(New Krypton.Ribbon.KryptonRibbonGroupContainer() { Me.kryptonRibbonGroupTriple19})
        Me.groupFormatStyles.KeyTipDialogLauncher = "FY"
        Me.groupFormatStyles.TextLine1 = "Styles"
        Me.kryptonRibbonGroupTriple19.Items.AddRange(New Krypton.Ribbon.KryptonRibbonGroupItem() { Me.stylesChangeStyles})
        Me.kryptonRibbonGroupTriple19.MinimumSize = Krypton.Ribbon.GroupItemSize.Large
        Me.stylesChangeStyles.ButtonType = Krypton.Ribbon.GroupButtonType.DropDown
        Me.stylesChangeStyles.ImageLarge = My.Resources.ChangeStyles
        Me.stylesChangeStyles.ImageSmall = Nothing
        Me.stylesChangeStyles.KeyTip = "G"
        Me.stylesChangeStyles.KryptonContextMenu = Me.cmsChangeStyles
        Me.stylesChangeStyles.TextLine1 = "Change"
        Me.stylesChangeStyles.TextLine2 = "Styles"
        Me.groupFormatZoom.AllowCollapsed = False
        Me.groupFormatZoom.DialogBoxLauncher = False
        Me.groupFormatZoom.Image = Nothing
        Me.groupFormatZoom.Items.AddRange(New Krypton.Ribbon.KryptonRibbonGroupContainer() { Me.kryptonRibbonGroupTriple20})
        Me.groupFormatZoom.TextLine1 = "Zoom"
        Me.kryptonRibbonGroupTriple20.Items.AddRange(New Krypton.Ribbon.KryptonRibbonGroupItem() { Me.zoomZoom})
        Me.kryptonRibbonGroupTriple20.MinimumSize = Krypton.Ribbon.GroupItemSize.Large
        Me.zoomZoom.ImageLarge = My.Resources.ZoomLarge
        Me.zoomZoom.ImageSmall = Nothing
        Me.zoomZoom.KeyTip = "Q"
        Me.zoomZoom.TextLine1 = "Zoom"
        Me.groupFormatEditing.DialogBoxLauncher = False
        Me.groupFormatEditing.Image = My.Resources.FindSmall
        Me.groupFormatEditing.Items.AddRange(New Krypton.Ribbon.KryptonRibbonGroupContainer() { Me.kryptonRibbonGroupTriple21})
        Me.groupFormatEditing.KeyTipGroup = "ZN"
        Me.groupFormatEditing.TextLine1 = "Editing"
        Me.kryptonRibbonGroupTriple21.Items.AddRange(New Krypton.Ribbon.KryptonRibbonGroupItem() { Me.kryptonRibbonGroupButton4, Me.kryptonRibbonGroupButton5, Me.kryptonRibbonGroupButton6})
        Me.kryptonRibbonGroupTriple21.MaximumSize = Krypton.Ribbon.GroupItemSize.Medium
        Me.kryptonRibbonGroupTriple21.MinimumSize = Krypton.Ribbon.GroupItemSize.Medium
        Me.kryptonRibbonGroupButton4.ButtonType = Krypton.Ribbon.GroupButtonType.Split
        Me.kryptonRibbonGroupButton4.ImageLarge = Nothing
        Me.kryptonRibbonGroupButton4.ImageSmall = My.Resources.FindSmall
        Me.kryptonRibbonGroupButton4.KeyTip = "FD"
        Me.kryptonRibbonGroupButton4.KryptonContextMenu = Me.cmsFind
        Me.kryptonRibbonGroupButton4.TextLine1 = "Find"
        Me.kryptonRibbonGroupButton5.ImageLarge = Nothing
        Me.kryptonRibbonGroupButton5.ImageSmall = My.Resources.FindReplaceSmall
        Me.kryptonRibbonGroupButton5.KeyTip = "R"
        Me.kryptonRibbonGroupButton5.TextLine1 = "Replace"
        Me.kryptonRibbonGroupButton6.ButtonType = Krypton.Ribbon.GroupButtonType.DropDown
        Me.kryptonRibbonGroupButton6.ImageLarge = Nothing
        Me.kryptonRibbonGroupButton6.ImageSmall = My.Resources.SelectSmall
        Me.kryptonRibbonGroupButton6.KeyTip = "SL"
        Me.kryptonRibbonGroupButton6.KryptonContextMenu = Me.cmsSelect
        Me.kryptonRibbonGroupButton6.TextLine1 = "Select"
        Me.tabDeveloper.Groups.AddRange(New Krypton.Ribbon.KryptonRibbonGroup() { Me.developerCode, Me.developerForm})
        Me.tabDeveloper.KeyTip = "L"
        Me.tabDeveloper.Text = "Developer"
        Me.developerCode.AllowCollapsed = False
        Me.developerCode.DialogBoxLauncher = False
        Me.developerCode.Image = Nothing
        Me.developerCode.Items.AddRange(New Krypton.Ribbon.KryptonRibbonGroupContainer() { Me.developerCodeTriple})
        Me.developerCode.TextLine1 = "Code"
        Me.developerCodeTriple.Items.AddRange(New Krypton.Ribbon.KryptonRibbonGroupItem() { Me.developerCodeVB, Me.developerCodeMacros})
        Me.developerCodeTriple.MinimumSize = Krypton.Ribbon.GroupItemSize.Large
        Me.developerCodeVB.ImageLarge = My.Resources.CodeVisualBasic
        Me.developerCodeVB.ImageSmall = Nothing
        Me.developerCodeVB.KeyTip = "V"
        Me.developerCodeVB.TextLine1 = "Visual"
        Me.developerCodeVB.TextLine2 = "Basic"
        Me.developerCodeMacros.ImageLarge = My.Resources.CodeMacros
        Me.developerCodeMacros.ImageSmall = Nothing
        Me.developerCodeMacros.KeyTip = "PM"
        Me.developerCodeMacros.TextLine1 = "Macros"
        Me.developerForm.AllowCollapsed = False
        Me.developerForm.DialogBoxLauncher = False
        Me.developerForm.Image = Nothing
        Me.developerForm.Items.AddRange(New Krypton.Ribbon.KryptonRibbonGroupContainer() { Me.developerFormTriple})
        Me.developerForm.TextLine1 = "Form"
        Me.developerFormTriple.Items.AddRange(New Krypton.Ribbon.KryptonRibbonGroupItem() { Me.developerFormDesignThis, Me.developerFormDesignA, Me.developerFormPublish})
        Me.developerFormTriple.MinimumSize = Krypton.Ribbon.GroupItemSize.Large
        Me.developerFormDesignThis.ImageLarge = My.Resources.FormDesignThisForm
        Me.developerFormDesignThis.ImageSmall = Nothing
        Me.developerFormDesignThis.KeyTip = "D"
        Me.developerFormDesignThis.TextLine1 = "Design"
        Me.developerFormDesignThis.TextLine2 = "This Form"
        Me.developerFormDesignA.ImageLarge = My.Resources.FormDesignAForm
        Me.developerFormDesignA.ImageSmall = Nothing
        Me.developerFormDesignA.KeyTip = "O"
        Me.developerFormDesignA.TextLine1 = "Design"
        Me.developerFormDesignA.TextLine2 = "a Form"
        Me.developerFormPublish.ButtonType = Krypton.Ribbon.GroupButtonType.DropDown
        Me.developerFormPublish.ImageLarge = My.Resources.FormPublish
        Me.developerFormPublish.ImageSmall = Nothing
        Me.developerFormPublish.KryptonContextMenu = Me.cmsFormPublish
        Me.developerFormPublish.TextLine1 = "Publish"
        Me.todayToolStripMenuItem.Image = My.Resources.OptionsReminder
        Me.todayToolStripMenuItem.Text = "Today"
        Me.tomorrowToolStripMenuItem.Image = My.Resources.OptionsTomorrow
        Me.tomorrowToolStripMenuItem.Text = "Tomorrow"
        Me.thisWeekToolStripMenuItem.Image = My.Resources.OptionsWeek
        Me.thisWeekToolStripMenuItem.Text = "This Week"
        Me.nextWeekToolStripMenuItem.Image = My.Resources.OptionsWeek
        Me.nextWeekToolStripMenuItem.Text = "Next Week"
        Me.noDateToolStripMenuItem.Image = My.Resources.OptionsFollowUpSmall
        Me.noDateToolStripMenuItem.Text = "No Date"
        Me.customToolStripMenuItem.Image = My.Resources.OptionsFollowUpSmall
        Me.customToolStripMenuItem.Text = "Custom..."
        Me.addReminderToolStripMenuItem.Image = My.Resources.OptionsReminder
        Me.addReminderToolStripMenuItem.Text = "Add Reminder..."
        Me.kryptonManager1.GlobalPaletteMode = Krypton.Toolkit.PaletteMode.Office2007Black
        Me.kryptonRibbonGroupCustomControl1.CustomControl = Nothing
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8F, 19F)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(869, 528)
        Me.Controls.Add(Me.panelFill)
        Me.Controls.Add(Me.kryptonRibbon)
        Me.Font = New System.Drawing.Font("Segoe UI", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Name = "Form1"
        Me.StateCommon.Header.Content.LongText.TextH = Krypton.Toolkit.PaletteRelativeAlign.Center
        Me.StateCommon.Header.Content.ShortText.TextH = Krypton.Toolkit.PaletteRelativeAlign.Center
        Me.Text = "Outlook Mail Clone"
        CType(Me.panelFill, System.ComponentModel.ISupportInitialize).EndInit()
        Me.panelFill.ResumeLayout(False)
        Me.panelFill.PerformLayout()
        Me.tableLayout.ResumeLayout(False)
        Me.tableLayout.PerformLayout()
        CType(Me.kryptonRibbon, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()
    End Sub

    Friend WithEvents kryptonRibbon As Krypton.Ribbon.KryptonRibbon
    Friend WithEvents tabMessage As Krypton.Ribbon.KryptonRibbonTab
    Friend WithEvents panelFill As Krypton.Toolkit.KryptonPanel
    Friend WithEvents groupClipboard As Krypton.Ribbon.KryptonRibbonGroup
    Friend WithEvents groupBasicText As Krypton.Ribbon.KryptonRibbonGroup
    Friend WithEvents groupNames As Krypton.Ribbon.KryptonRibbonGroup
    Friend WithEvents groupMessageInclude As Krypton.Ribbon.KryptonRibbonGroup
    Friend WithEvents groupOptions As Krypton.Ribbon.KryptonRibbonGroup
    Friend WithEvents groupZoom As Krypton.Ribbon.KryptonRibbonGroup
    Friend WithEvents tabInsert As Krypton.Ribbon.KryptonRibbonTab
    Friend WithEvents tabOptions As Krypton.Ribbon.KryptonRibbonTab
    Friend WithEvents tabFormatText As Krypton.Ribbon.KryptonRibbonTab
    Friend WithEvents tabDeveloper As Krypton.Ribbon.KryptonRibbonTab
    Friend WithEvents tableLayout As System.Windows.Forms.TableLayoutPanel
    Friend WithEvents richTextBoxSubject As Krypton.Toolkit.KryptonRichTextBox
    Friend WithEvents richTextBoxCc As Krypton.Toolkit.KryptonRichTextBox
    Friend WithEvents richTextBoxTo As Krypton.Toolkit.KryptonRichTextBox
    Friend WithEvents clipboard1 As Krypton.Ribbon.KryptonRibbonGroupTriple
    Friend WithEvents clipboardPaste As Krypton.Ribbon.KryptonRibbonGroupButton
    Friend WithEvents clipboard2 As Krypton.Ribbon.KryptonRibbonGroupTriple
    Friend WithEvents clipboardCut As Krypton.Ribbon.KryptonRibbonGroupButton
    Friend WithEvents clipboardCopy As Krypton.Ribbon.KryptonRibbonGroupButton
    Friend WithEvents clipboardFormatPainter As Krypton.Ribbon.KryptonRibbonGroupButton
    Friend WithEvents cmsPaste As Krypton.Toolkit.KryptonContextMenu
    Friend WithEvents pasteToolStripMenuItem As Krypton.Toolkit.KryptonContextMenuItem
    Friend WithEvents pasteSpecialToolStripMenuItem As Krypton.Toolkit.KryptonContextMenuItem
    Friend WithEvents basicTextLines As Krypton.Ribbon.KryptonRibbonGroupLines
    Friend WithEvents basicTextFont As Krypton.Ribbon.KryptonRibbonGroupCluster
    Friend WithEvents basicTextFontLarger As Krypton.Ribbon.KryptonRibbonGroupClusterButton
    Friend WithEvents basicTextFontSmaller As Krypton.Ribbon.KryptonRibbonGroupClusterButton
    Friend WithEvents basicTextBullet As Krypton.Ribbon.KryptonRibbonGroupCluster
    Friend WithEvents basicTextBulletPoints As Krypton.Ribbon.KryptonRibbonGroupClusterButton
    Friend WithEvents basicTextBulletNumbers As Krypton.Ribbon.KryptonRibbonGroupClusterButton
    Friend WithEvents basicTextRubout As Krypton.Ribbon.KryptonRibbonGroupCluster
    Friend WithEvents basicTextRuboutButton As Krypton.Ribbon.KryptonRibbonGroupClusterButton
    Friend WithEvents basicTextStyle As Krypton.Ribbon.KryptonRibbonGroupCluster
    Friend WithEvents basicTextStyleBold As Krypton.Ribbon.KryptonRibbonGroupClusterButton
    Friend WithEvents basicTextStyleItalic As Krypton.Ribbon.KryptonRibbonGroupClusterButton
    Friend WithEvents basicTextStyleUnderline As Krypton.Ribbon.KryptonRibbonGroupClusterButton
    Friend WithEvents basicTextColors As Krypton.Ribbon.KryptonRibbonGroupCluster
    Friend WithEvents basicTextColorBack As Krypton.Ribbon.KryptonRibbonGroupClusterColorButton
    Friend WithEvents basicTextColorText As Krypton.Ribbon.KryptonRibbonGroupClusterColorButton
    Friend WithEvents basicTextAlignment As Krypton.Ribbon.KryptonRibbonGroupCluster
    Friend WithEvents basicTextAlignLeft As Krypton.Ribbon.KryptonRibbonGroupClusterButton
    Friend WithEvents basicTextAlignCenter As Krypton.Ribbon.KryptonRibbonGroupClusterButton
    Friend WithEvents basicTextAlignRight As Krypton.Ribbon.KryptonRibbonGroupClusterButton
    Friend WithEvents basicTextTab As Krypton.Ribbon.KryptonRibbonGroupCluster
    Friend WithEvents basicTextTabLeft As Krypton.Ribbon.KryptonRibbonGroupClusterButton
    Friend WithEvents basicTextTabRight As Krypton.Ribbon.KryptonRibbonGroupClusterButton
    Friend WithEvents namesGroup As Krypton.Ribbon.KryptonRibbonGroupTriple
    Friend WithEvents namesAddressBook As Krypton.Ribbon.KryptonRibbonGroupButton
    Friend WithEvents namesCheckNames As Krypton.Ribbon.KryptonRibbonGroupButton
    Friend WithEvents includeTriple1 As Krypton.Ribbon.KryptonRibbonGroupTriple
    Friend WithEvents includeAttachFile As Krypton.Ribbon.KryptonRibbonGroupButton
    Friend WithEvents includeAttachItem As Krypton.Ribbon.KryptonRibbonGroupButton
    Friend WithEvents includeTriple2 As Krypton.Ribbon.KryptonRibbonGroupTriple
    Friend WithEvents optionsTripleFollowup As Krypton.Ribbon.KryptonRibbonGroupTriple
    Friend WithEvents optionsFollowUp As Krypton.Ribbon.KryptonRibbonGroupButton
    Friend WithEvents proofingTriple As Krypton.Ribbon.KryptonRibbonGroupTriple
    Friend WithEvents zoomMessageZoom As Krypton.Ribbon.KryptonRibbonGroupButton
    Friend WithEvents cmsBusinessCards As Krypton.Toolkit.KryptonContextMenu
    Friend WithEvents otherBusinessCardsToolStripMenuItem As Krypton.Toolkit.KryptonContextMenuItem
    Friend WithEvents cmsSignatures As Krypton.Toolkit.KryptonContextMenu
    Friend WithEvents signaturesToolStripMenuItem As Krypton.Toolkit.KryptonContextMenuItem
    Friend WithEvents cmsFollowUp As Krypton.Toolkit.KryptonContextMenu
    Friend WithEvents todayToolStripMenuItem As Krypton.Toolkit.KryptonContextMenuItem
    Friend WithEvents tomorrowToolStripMenuItem As Krypton.Toolkit.KryptonContextMenuItem
    Friend WithEvents thisWeekToolStripMenuItem As Krypton.Toolkit.KryptonContextMenuItem
    Friend WithEvents nextWeekToolStripMenuItem As Krypton.Toolkit.KryptonContextMenuItem
    Friend WithEvents noDateToolStripMenuItem As Krypton.Toolkit.KryptonContextMenuItem
    Friend WithEvents customToolStripMenuItem As Krypton.Toolkit.KryptonContextMenuItem
    Friend WithEvents toolStripMenuItem1 As Krypton.Toolkit.KryptonContextMenuSeparator
    Friend WithEvents addReminderToolStripMenuItem As Krypton.Toolkit.KryptonContextMenuItem
    Friend WithEvents clearFlagToolStripMenuItem As Krypton.Toolkit.KryptonContextMenuItem
    Friend WithEvents toolStripMenuItem2 As Krypton.Toolkit.KryptonContextMenuSeparator
    Friend WithEvents flagForRecipientsToolStripMenuItem As Krypton.Toolkit.KryptonContextMenuItem
    Friend WithEvents cmsSpelling As Krypton.Toolkit.KryptonContextMenu
    Friend WithEvents spellingGrammerToolStripMenuItem As Krypton.Toolkit.KryptonContextMenuItem
    Friend WithEvents researchToolStripMenuItem As Krypton.Toolkit.KryptonContextMenuItem
    Friend WithEvents thesaoursToolStripMenuItem As Krypton.Toolkit.KryptonContextMenuItem
    Friend WithEvents translateToolStripMenuItem As Krypton.Toolkit.KryptonContextMenuItem
    Friend WithEvents translationScreentipToolStripMenuItem As Krypton.Toolkit.KryptonContextMenuItem
    Friend WithEvents setLanguageToolStripMenuItem As Krypton.Toolkit.KryptonContextMenuItem
    Friend WithEvents wordCountToolStripMenuItem As Krypton.Toolkit.KryptonContextMenuItem
    Friend WithEvents todayToolStripMenuItem1 As Krypton.Toolkit.KryptonContextMenuItem
    Friend WithEvents tomorrowToolStripMenuItem1 As Krypton.Toolkit.KryptonContextMenuItem
    Friend WithEvents thisWeekToolStripMenuItem1 As Krypton.Toolkit.KryptonContextMenuItem
    Friend WithEvents nextWeekToolStripMenuItem1 As Krypton.Toolkit.KryptonContextMenuItem
    Friend WithEvents noDateToolStripMenuItem1 As Krypton.Toolkit.KryptonContextMenuItem
    Friend WithEvents customToolStripMenuItem1 As Krypton.Toolkit.KryptonContextMenuItem
    Friend WithEvents toolStripMenuItem3 As Krypton.Toolkit.KryptonContextMenuSeparator
    Friend WithEvents addReminderToolStripMenuItem1 As Krypton.Toolkit.KryptonContextMenuItem
    Friend WithEvents clearFlagToolStripMenuItem1 As Krypton.Toolkit.KryptonContextMenuItem
    Friend WithEvents toolStripMenuItem4 As Krypton.Toolkit.KryptonContextMenuSeparator
    Friend WithEvents flagForRecipientsToolStripMenuItem1 As Krypton.Toolkit.KryptonContextMenuItem
    Friend WithEvents saveToolStripMenuItem As Krypton.Toolkit.KryptonContextMenuItem
    Friend WithEvents forwardToolStripMenuItem As Krypton.Toolkit.KryptonContextMenuItem
    Friend WithEvents deleteToolStripMenuItem As Krypton.Toolkit.KryptonContextMenuItem
    Friend WithEvents toolStripMenuItem5 As Krypton.Toolkit.KryptonContextMenuSeparator
    Friend WithEvents exitToolStripMenuItem As Krypton.Toolkit.KryptonContextMenuItem
    Friend WithEvents qatSave As Krypton.Ribbon.KryptonRibbonQATButton
    Friend WithEvents qatUndo As Krypton.Ribbon.KryptonRibbonQATButton
    Friend WithEvents qatRedo As Krypton.Ribbon.KryptonRibbonQATButton
    Friend WithEvents qatQuickPrint As Krypton.Ribbon.KryptonRibbonQATButton
    Friend WithEvents qatForward As Krypton.Ribbon.KryptonRibbonQATButton
    Friend WithEvents qatDelete As Krypton.Ribbon.KryptonRibbonQATButton
    Friend WithEvents developerCode As Krypton.Ribbon.KryptonRibbonGroup
    Friend WithEvents developerCodeTriple As Krypton.Ribbon.KryptonRibbonGroupTriple
    Friend WithEvents developerCodeVB As Krypton.Ribbon.KryptonRibbonGroupButton
    Friend WithEvents developerCodeMacros As Krypton.Ribbon.KryptonRibbonGroupButton
    Friend WithEvents developerForm As Krypton.Ribbon.KryptonRibbonGroup
    Friend WithEvents developerFormTriple As Krypton.Ribbon.KryptonRibbonGroupTriple
    Friend WithEvents developerFormDesignThis As Krypton.Ribbon.KryptonRibbonGroupButton
    Friend WithEvents developerFormDesignA As Krypton.Ribbon.KryptonRibbonGroupButton
    Friend WithEvents developerFormPublish As Krypton.Ribbon.KryptonRibbonGroupButton
    Friend WithEvents cmsFormPublish As Krypton.Toolkit.KryptonContextMenu
    Friend WithEvents publishFormToolStripMenuItem As Krypton.Toolkit.KryptonContextMenuItem
    Friend WithEvents publishFormAsToolStripMenuItem As Krypton.Toolkit.KryptonContextMenuItem
    Friend WithEvents groupInsertInclude As Krypton.Ribbon.KryptonRibbonGroup
    Friend WithEvents groupTables As Krypton.Ribbon.KryptonRibbonGroup
    Friend WithEvents groupInsertIllustrations As Krypton.Ribbon.KryptonRibbonGroup
    Friend WithEvents groupLinks As Krypton.Ribbon.KryptonRibbonGroup
    Friend WithEvents groupText As Krypton.Ribbon.KryptonRibbonGroup
    Friend WithEvents groupSymbols As Krypton.Ribbon.KryptonRibbonGroup
    Friend WithEvents kryptonRibbonGroupTriple4 As Krypton.Ribbon.KryptonRibbonGroupTriple
    Friend WithEvents includeInsertAttachFile As Krypton.Ribbon.KryptonRibbonGroupButton
    Friend WithEvents includeInsertAttachItem As Krypton.Ribbon.KryptonRibbonGroupButton
    Friend WithEvents kryptonRibbonGroupTriple5 As Krypton.Ribbon.KryptonRibbonGroupTriple
    Friend WithEvents includeInsertBusinessCard As Krypton.Ribbon.KryptonRibbonGroupButton
    Friend WithEvents includeInsertCalendar As Krypton.Ribbon.KryptonRibbonGroupButton
    Friend WithEvents includeInsertSignature As Krypton.Ribbon.KryptonRibbonGroupButton
    Friend WithEvents kryptonRibbonGroupTriple3 As Krypton.Ribbon.KryptonRibbonGroupTriple
    Friend WithEvents tablesTable As Krypton.Ribbon.KryptonRibbonGroupButton
    Friend WithEvents kryptonRibbonGroupTriple6 As Krypton.Ribbon.KryptonRibbonGroupTriple
    Friend WithEvents illustrationsPicture As Krypton.Ribbon.KryptonRibbonGroupButton
    Friend WithEvents illustrationsClipArt As Krypton.Ribbon.KryptonRibbonGroupButton
    Friend WithEvents kryptonRibbonGroupTriple7 As Krypton.Ribbon.KryptonRibbonGroupTriple
    Friend WithEvents illustrationsShapes As Krypton.Ribbon.KryptonRibbonGroupButton
    Friend WithEvents illustrationsSmartArt As Krypton.Ribbon.KryptonRibbonGroupButton
    Friend WithEvents illustrationsChart As Krypton.Ribbon.KryptonRibbonGroupButton
    Friend WithEvents kryptonRibbonGroupTriple2 As Krypton.Ribbon.KryptonRibbonGroupTriple
    Friend WithEvents linksHyperlink As Krypton.Ribbon.KryptonRibbonGroupButton
    Friend WithEvents linksBookmark As Krypton.Ribbon.KryptonRibbonGroupButton
    Friend WithEvents kryptonRibbonGroupTriple8 As Krypton.Ribbon.KryptonRibbonGroupTriple
    Friend WithEvents textTextBox As Krypton.Ribbon.KryptonRibbonGroupButton
    Friend WithEvents textQuickParts As Krypton.Ribbon.KryptonRibbonGroupButton
    Friend WithEvents textWordArt As Krypton.Ribbon.KryptonRibbonGroupButton
    Friend WithEvents kryptonRibbonGroupTriple9 As Krypton.Ribbon.KryptonRibbonGroupTriple
    Friend WithEvents textDropCap As Krypton.Ribbon.KryptonRibbonGroupButton
    Friend WithEvents textDateAndTime As Krypton.Ribbon.KryptonRibbonGroupButton
    Friend WithEvents textObject As Krypton.Ribbon.KryptonRibbonGroupButton
    Friend WithEvents kryptonRibbonGroupTriple1 As Krypton.Ribbon.KryptonRibbonGroupTriple
    Friend WithEvents symbolsEquation As Krypton.Ribbon.KryptonRibbonGroupButton
    Friend WithEvents symbolSymbol As Krypton.Ribbon.KryptonRibbonGroupButton
    Friend WithEvents symbolHorizontalLine As Krypton.Ribbon.KryptonRibbonGroupButton
    Friend WithEvents cmsTable As Krypton.Toolkit.KryptonContextMenu
    Friend WithEvents insertTableToolStripMenuItem As Krypton.Toolkit.KryptonContextMenuItem
    Friend WithEvents drawTableToolStripMenuItem As Krypton.Toolkit.KryptonContextMenuItem
    Friend WithEvents convertTextToTableToolStripMenuItem As Krypton.Toolkit.KryptonContextMenuItem
    Friend WithEvents excelSpreadsheetToolStripMenuItem As Krypton.Toolkit.KryptonContextMenuItem
    Friend WithEvents quickTablesToolStripMenuItem As Krypton.Toolkit.KryptonContextMenuItem
    Friend WithEvents cmsTextBox As Krypton.Toolkit.KryptonContextMenu
    Friend WithEvents drawTextBoxToolStripMenuItem As Krypton.Toolkit.KryptonContextMenuItem
    Friend WithEvents saveSelectionToTextBoxGalleryToolStripMenuItem As Krypton.Toolkit.KryptonContextMenuItem
    Friend WithEvents cmsQuickParts As Krypton.Toolkit.KryptonContextMenu
    Friend WithEvents saveSelectionToQuickPartsGalleryToolStripMenuItem As Krypton.Toolkit.KryptonContextMenuItem
    Friend WithEvents cmsDropCap As Krypton.Toolkit.KryptonContextMenu
    Friend WithEvents dropCapOptionsToolStripMenuItem As Krypton.Toolkit.KryptonContextMenuItem
    Friend WithEvents cmsEquation As Krypton.Toolkit.KryptonContextMenu
    Friend WithEvents insertNewEquationToolStripMenuItem As Krypton.Toolkit.KryptonContextMenuItem
    Friend WithEvents saveTextTToolStripMenuItem As Krypton.Toolkit.KryptonContextMenuItem
    Friend WithEvents cmsSymbol As Krypton.Toolkit.KryptonContextMenu
    Friend WithEvents moreSymbolsToolStripMenuItem As Krypton.Toolkit.KryptonContextMenuItem
    Friend WithEvents cmsShapes As Krypton.Toolkit.KryptonContextMenu
    Friend WithEvents newDrawingCanvasToolStripMenuItem As Krypton.Toolkit.KryptonContextMenuItem
    'NOTE: Shadows because VB is case-insensitive and KryptonForm exposes a ButtonSpecHelp property (the C# field coexists by case).
    Friend Shadows WithEvents buttonSpecHelp As Krypton.Toolkit.ButtonSpecAny
    Friend WithEvents groupOptionsThemes As Krypton.Ribbon.KryptonRibbonGroup
    Friend WithEvents kryptonRibbonGroupTriple10 As Krypton.Ribbon.KryptonRibbonGroupTriple
    Friend WithEvents themesTheme As Krypton.Ribbon.KryptonRibbonGroupButton
    Friend WithEvents kryptonRibbonGroupTriple11 As Krypton.Ribbon.KryptonRibbonGroupTriple
    Friend WithEvents themesColors As Krypton.Ribbon.KryptonRibbonGroupButton
    Friend WithEvents themesFonts As Krypton.Ribbon.KryptonRibbonGroupButton
    Friend WithEvents themesEffects As Krypton.Ribbon.KryptonRibbonGroupButton
    Friend WithEvents kryptonRibbonGroupSeparator1 As Krypton.Ribbon.KryptonRibbonGroupSeparator
    Friend WithEvents kryptonRibbonGroupTriple12 As Krypton.Ribbon.KryptonRibbonGroupTriple
    Friend WithEvents themesPageColor As Krypton.Ribbon.KryptonRibbonGroupButton
    Friend WithEvents groupFields As Krypton.Ribbon.KryptonRibbonGroup
    Friend WithEvents kryptonRibbonGroupTriple13 As Krypton.Ribbon.KryptonRibbonGroupTriple
    Friend WithEvents fieldsShowBcc As Krypton.Ribbon.KryptonRibbonGroupButton
    Friend WithEvents fieldsShowFrom As Krypton.Ribbon.KryptonRibbonGroupButton
    Friend WithEvents groupFormat As Krypton.Ribbon.KryptonRibbonGroup
    Friend WithEvents kryptonRibbonGroupTriple14 As Krypton.Ribbon.KryptonRibbonGroupTriple
    Friend WithEvents formatPlainText As Krypton.Ribbon.KryptonRibbonGroupButton
    Friend WithEvents formatHTML As Krypton.Ribbon.KryptonRibbonGroupButton
    Friend WithEvents formatRichText As Krypton.Ribbon.KryptonRibbonGroupButton
    Friend WithEvents groupTracking As Krypton.Ribbon.KryptonRibbonGroup
    Friend WithEvents kryptonRibbonGroupTriple15 As Krypton.Ribbon.KryptonRibbonGroupTriple
    Friend WithEvents trackingUseVotingButtons As Krypton.Ribbon.KryptonRibbonGroupButton
    Friend WithEvents groupMoreOptions As Krypton.Ribbon.KryptonRibbonGroup
    Friend WithEvents kryptonRibbonGroupTriple16 As Krypton.Ribbon.KryptonRibbonGroupTriple
    Friend WithEvents moreOptionsSaveSentItem As Krypton.Ribbon.KryptonRibbonGroupButton
    Friend WithEvents moreOptionsDelayDelivery As Krypton.Ribbon.KryptonRibbonGroupButton
    Friend WithEvents moreOptionsDirectRepliesTo As Krypton.Ribbon.KryptonRibbonGroupButton
    Friend WithEvents cmsThemes As Krypton.Toolkit.KryptonContextMenu
    Friend WithEvents resetToThemeFromTemplateToolStripMenuItem As Krypton.Toolkit.KryptonContextMenuItem
    Friend WithEvents moreThemesOnMicrosoftOfficeToolStripMenuItem As Krypton.Toolkit.KryptonContextMenuItem
    Friend WithEvents browseForThemesToolStripMenuItem As Krypton.Toolkit.KryptonContextMenuItem
    Friend WithEvents saveCurrentThemeToolStripMenuItem As Krypton.Toolkit.KryptonContextMenuItem
    Friend WithEvents cmsPageColor As Krypton.Toolkit.KryptonContextMenu
    Friend WithEvents noColorToolStripMenuItem As Krypton.Toolkit.KryptonContextMenuItem
    Friend WithEvents toolStripMenuItem6 As Krypton.Toolkit.KryptonContextMenuSeparator
    Friend WithEvents moreColorsToolStripMenuItem As Krypton.Toolkit.KryptonContextMenuItem
    Friend WithEvents fillEffectsToolStripMenuItem As Krypton.Toolkit.KryptonContextMenuItem
    Friend WithEvents cmsUseVotingButtons As Krypton.Toolkit.KryptonContextMenu
    Friend WithEvents approveRejectToolStripMenuItem As Krypton.Toolkit.KryptonContextMenuItem
    Friend WithEvents yesNoToolStripMenuItem As Krypton.Toolkit.KryptonContextMenuItem
    Friend WithEvents yesNoMaybeToolStripMenuItem As Krypton.Toolkit.KryptonContextMenuItem
    Friend WithEvents toolStripMenuItem7 As Krypton.Toolkit.KryptonContextMenuSeparator
    Friend WithEvents customToolStripMenuItem2 As Krypton.Toolkit.KryptonContextMenuItem
    Friend WithEvents cmsSaveSentItem As Krypton.Toolkit.KryptonContextMenu
    Friend WithEvents otherFolderToolStripMenuItem As Krypton.Toolkit.KryptonContextMenuItem
    Friend WithEvents toolStripMenuItem8 As Krypton.Toolkit.KryptonContextMenuSeparator
    Friend WithEvents useDefaultFolderToolStripMenuItem As Krypton.Toolkit.KryptonContextMenuItem
    Friend WithEvents dotNotSaveToolStripMenuItem As Krypton.Toolkit.KryptonContextMenuItem
    Friend WithEvents groupFormatClipboard As Krypton.Ribbon.KryptonRibbonGroup
    Friend WithEvents groupFormatFont As Krypton.Ribbon.KryptonRibbonGroup
    Friend WithEvents groupFormatParagraph As Krypton.Ribbon.KryptonRibbonGroup
    Friend WithEvents groupFormatStyles As Krypton.Ribbon.KryptonRibbonGroup
    Friend WithEvents groupFormatZoom As Krypton.Ribbon.KryptonRibbonGroup
    Friend WithEvents groupFormatEditing As Krypton.Ribbon.KryptonRibbonGroup
    Friend WithEvents kryptonRibbonGroupTriple17 As Krypton.Ribbon.KryptonRibbonGroupTriple
    Friend WithEvents formatClipboardPaste As Krypton.Ribbon.KryptonRibbonGroupButton
    Friend WithEvents kryptonRibbonGroupTriple18 As Krypton.Ribbon.KryptonRibbonGroupTriple
    Friend WithEvents formatClipboardCut As Krypton.Ribbon.KryptonRibbonGroupButton
    Friend WithEvents formatClipboardCopy As Krypton.Ribbon.KryptonRibbonGroupButton
    Friend WithEvents formatClipboardFormatPainter As Krypton.Ribbon.KryptonRibbonGroupButton
    Friend WithEvents kryptonRibbonGroupLines1 As Krypton.Ribbon.KryptonRibbonGroupLines
    Friend WithEvents kryptonRibbonGroupCluster1 As Krypton.Ribbon.KryptonRibbonGroupCluster
    Friend WithEvents fontGrowFont As Krypton.Ribbon.KryptonRibbonGroupClusterButton
    Friend WithEvents fontShrinkFont As Krypton.Ribbon.KryptonRibbonGroupClusterButton
    Friend WithEvents kryptonRibbonGroupCluster2 As Krypton.Ribbon.KryptonRibbonGroupCluster
    Friend WithEvents fontTextClear As Krypton.Ribbon.KryptonRibbonGroupClusterButton
    Friend WithEvents kryptonRibbonGroupCluster3 As Krypton.Ribbon.KryptonRibbonGroupCluster
    Friend WithEvents fontBold As Krypton.Ribbon.KryptonRibbonGroupClusterButton
    Friend WithEvents fontItalic As Krypton.Ribbon.KryptonRibbonGroupClusterButton
    Friend WithEvents fontUnderline As Krypton.Ribbon.KryptonRibbonGroupClusterButton
    Friend WithEvents fontStrikethrough As Krypton.Ribbon.KryptonRibbonGroupClusterButton
    Friend WithEvents fontSubscript As Krypton.Ribbon.KryptonRibbonGroupClusterButton
    Friend WithEvents fontSuperscript As Krypton.Ribbon.KryptonRibbonGroupClusterButton
    Friend WithEvents fontChangeCase As Krypton.Ribbon.KryptonRibbonGroupClusterButton
    Friend WithEvents kryptonRibbonGroupCluster4 As Krypton.Ribbon.KryptonRibbonGroupCluster
    Friend WithEvents fontTextBackColor As Krypton.Ribbon.KryptonRibbonGroupClusterButton
    Friend WithEvents textFontColor As Krypton.Ribbon.KryptonRibbonGroupClusterButton
    Friend WithEvents kryptonRibbonGroupLines2 As Krypton.Ribbon.KryptonRibbonGroupLines
    Friend WithEvents kryptonRibbonGroupCluster5 As Krypton.Ribbon.KryptonRibbonGroupCluster
    Friend WithEvents fontBullets As Krypton.Ribbon.KryptonRibbonGroupClusterButton
    Friend WithEvents fontNumbers As Krypton.Ribbon.KryptonRibbonGroupClusterButton
    Friend WithEvents fontMultilevel As Krypton.Ribbon.KryptonRibbonGroupClusterButton
    Friend WithEvents kryptonRibbonGroupCluster6 As Krypton.Ribbon.KryptonRibbonGroupCluster
    Friend WithEvents fontDecreaseIndent As Krypton.Ribbon.KryptonRibbonGroupClusterButton
    Friend WithEvents fontIncreaseIndent As Krypton.Ribbon.KryptonRibbonGroupClusterButton
    Friend WithEvents kryptonRibbonGroupCluster7 As Krypton.Ribbon.KryptonRibbonGroupCluster
    Friend WithEvents fontSort As Krypton.Ribbon.KryptonRibbonGroupClusterButton
    Friend WithEvents kryptonRibbonGroupCluster8 As Krypton.Ribbon.KryptonRibbonGroupCluster
    Friend WithEvents fontMarkers As Krypton.Ribbon.KryptonRibbonGroupClusterButton
    Friend WithEvents kryptonRibbonGroupCluster9 As Krypton.Ribbon.KryptonRibbonGroupCluster
    Friend WithEvents fontJustifyLeft As Krypton.Ribbon.KryptonRibbonGroupClusterButton
    Friend WithEvents fontJustifyCenter As Krypton.Ribbon.KryptonRibbonGroupClusterButton
    Friend WithEvents fontJustifyRight As Krypton.Ribbon.KryptonRibbonGroupClusterButton
    Friend WithEvents fontJustify As Krypton.Ribbon.KryptonRibbonGroupClusterButton
    Friend WithEvents kryptonRibbonGroupCluster10 As Krypton.Ribbon.KryptonRibbonGroupCluster
    Friend WithEvents fontSpacing As Krypton.Ribbon.KryptonRibbonGroupClusterButton
    Friend WithEvents kryptonRibbonGroupCluster11 As Krypton.Ribbon.KryptonRibbonGroupCluster
    Friend WithEvents fontShading As Krypton.Ribbon.KryptonRibbonGroupClusterButton
    Friend WithEvents fontBottomBorder As Krypton.Ribbon.KryptonRibbonGroupClusterButton
    Friend WithEvents kryptonRibbonGroupTriple19 As Krypton.Ribbon.KryptonRibbonGroupTriple
    Friend WithEvents stylesChangeStyles As Krypton.Ribbon.KryptonRibbonGroupButton
    Friend WithEvents kryptonRibbonGroupTriple20 As Krypton.Ribbon.KryptonRibbonGroupTriple
    Friend WithEvents zoomZoom As Krypton.Ribbon.KryptonRibbonGroupButton
    Friend WithEvents kryptonRibbonGroupTriple21 As Krypton.Ribbon.KryptonRibbonGroupTriple
    Friend WithEvents kryptonRibbonGroupButton4 As Krypton.Ribbon.KryptonRibbonGroupButton
    Friend WithEvents kryptonRibbonGroupButton5 As Krypton.Ribbon.KryptonRibbonGroupButton
    Friend WithEvents kryptonRibbonGroupButton6 As Krypton.Ribbon.KryptonRibbonGroupButton
    Friend WithEvents cmsChangeCase As Krypton.Toolkit.KryptonContextMenu
    Friend WithEvents sentenceCaseToolStripMenuItem As Krypton.Toolkit.KryptonContextMenuItem
    Friend WithEvents lowercaseToolStripMenuItem As Krypton.Toolkit.KryptonContextMenuItem
    Friend WithEvents uPPERCASEToolStripMenuItem As Krypton.Toolkit.KryptonContextMenuItem
    Friend WithEvents capitalizeEachWordToolStripMenuItem As Krypton.Toolkit.KryptonContextMenuItem
    Friend WithEvents tOGGLECASEToolStripMenuItem As Krypton.Toolkit.KryptonContextMenuItem
    Friend WithEvents cmsSpacing As Krypton.Toolkit.KryptonContextMenu
    Friend WithEvents singleSpacingToolStripMenuItem As Krypton.Toolkit.KryptonContextMenuItem
    Friend WithEvents spacingToolStripMenuItem As Krypton.Toolkit.KryptonContextMenuItem
    Friend WithEvents doubleSpacingToolStripMenuItem As Krypton.Toolkit.KryptonContextMenuItem
    Friend WithEvents paragraphToolStripMenuItem As Krypton.Toolkit.KryptonContextMenuItem
    Friend WithEvents cmsBottomBorder As Krypton.Toolkit.KryptonContextMenu
    Friend WithEvents bottomBorderToolStripMenuItem As Krypton.Toolkit.KryptonContextMenuItem
    Friend WithEvents topBorderToolStripMenuItem As Krypton.Toolkit.KryptonContextMenuItem
    Friend WithEvents leftBorderToolStripMenuItem As Krypton.Toolkit.KryptonContextMenuItem
    Friend WithEvents rightBorderToolStripMenuItem As Krypton.Toolkit.KryptonContextMenuItem
    Friend WithEvents toolStripMenuItem9 As Krypton.Toolkit.KryptonContextMenuSeparator
    Friend WithEvents noBorderToolStripMenuItem As Krypton.Toolkit.KryptonContextMenuItem
    Friend WithEvents allBordersToolStripMenuItem As Krypton.Toolkit.KryptonContextMenuItem
    Friend WithEvents outsideBordersToolStripMenuItem As Krypton.Toolkit.KryptonContextMenuItem
    Friend WithEvents insideBordersToolStripMenuItem As Krypton.Toolkit.KryptonContextMenuItem
    Friend WithEvents toolStripMenuItem10 As Krypton.Toolkit.KryptonContextMenuSeparator
    Friend WithEvents insideHorizontalBorderToolStripMenuItem As Krypton.Toolkit.KryptonContextMenuItem
    Friend WithEvents insideVerticalBorderToolStripMenuItem As Krypton.Toolkit.KryptonContextMenuItem
    Friend WithEvents diagonalDownBorderToolStripMenuItem As Krypton.Toolkit.KryptonContextMenuItem
    Friend WithEvents diagonalUpBorderToolStripMenuItem As Krypton.Toolkit.KryptonContextMenuItem
    Friend WithEvents toolStripMenuItem11 As Krypton.Toolkit.KryptonContextMenuSeparator
    Friend WithEvents horizontalLineToolStripMenuItem As Krypton.Toolkit.KryptonContextMenuItem
    Friend WithEvents toolStripMenuItem12 As Krypton.Toolkit.KryptonContextMenuSeparator
    Friend WithEvents drawTableToolStripMenuItem1 As Krypton.Toolkit.KryptonContextMenuItem
    Friend WithEvents viewGridlinesToolStripMenuItem As Krypton.Toolkit.KryptonContextMenuItem
    Friend WithEvents bordersAndShadingToolStripMenuItem As Krypton.Toolkit.KryptonContextMenuItem
    Friend WithEvents cmsChangeStyles As Krypton.Toolkit.KryptonContextMenu
    Friend WithEvents styleSetToolStripMenuItem As Krypton.Toolkit.KryptonContextMenuItem
    Friend WithEvents colorsToolStripMenuItem As Krypton.Toolkit.KryptonContextMenuItem
    Friend WithEvents fontsToolStripMenuItem As Krypton.Toolkit.KryptonContextMenuItem
    Friend WithEvents toolStripMenuItem13 As Krypton.Toolkit.KryptonContextMenuSeparator
    Friend WithEvents setAsDefaultToolStripMenuItem As Krypton.Toolkit.KryptonContextMenuItem
    Friend WithEvents cmsQuickStyles As Krypton.Toolkit.KryptonContextMenu
    Friend WithEvents saveSelectionAsNewStyleToolStripMenuItem As Krypton.Toolkit.KryptonContextMenuItem
    Friend WithEvents clearFormattingToolStripMenuItem As Krypton.Toolkit.KryptonContextMenuItem
    Friend WithEvents applyStylesToolStripMenuItem As Krypton.Toolkit.KryptonContextMenuItem
    Friend WithEvents cmsFind As Krypton.Toolkit.KryptonContextMenu
    Friend WithEvents findToolStripMenuItem As Krypton.Toolkit.KryptonContextMenuItem
    Friend WithEvents goToToolStripMenuItem As Krypton.Toolkit.KryptonContextMenuItem
    Friend WithEvents cmsSelect As Krypton.Toolkit.KryptonContextMenu
    Friend WithEvents selectAllToolStripMenuItem As Krypton.Toolkit.KryptonContextMenuItem
    Friend WithEvents selectObjectsToolStripMenuItem As Krypton.Toolkit.KryptonContextMenuItem
    Friend WithEvents selectTextWithSimilarFormattingToolStripMenuItem As Krypton.Toolkit.KryptonContextMenuItem
    Friend WithEvents cmsPasteItems As Krypton.Toolkit.KryptonContextMenuItems
    Friend WithEvents cmsBusinessCardsItems As Krypton.Toolkit.KryptonContextMenuItems
    Friend WithEvents cmsSymbolItems As Krypton.Toolkit.KryptonContextMenuItems
    Friend WithEvents cmsChangeCaseItems As Krypton.Toolkit.KryptonContextMenuItems
    Friend WithEvents cmsSpacingItems As Krypton.Toolkit.KryptonContextMenuItems
    Friend WithEvents cmsBottomBorderItems As Krypton.Toolkit.KryptonContextMenuItems
    Friend WithEvents cmsChangeStylesItems As Krypton.Toolkit.KryptonContextMenuItems
    Friend WithEvents cmsQuickStylesItems As Krypton.Toolkit.KryptonContextMenuItems
    Friend WithEvents cmsFindItems As Krypton.Toolkit.KryptonContextMenuItems
    Friend WithEvents cmsSelectItems As Krypton.Toolkit.KryptonContextMenuItems
    Friend WithEvents cmsSignaturesItems As Krypton.Toolkit.KryptonContextMenuItems
    Friend WithEvents cmsFormPublishItems As Krypton.Toolkit.KryptonContextMenuItems
    Friend WithEvents cmsTableItems As Krypton.Toolkit.KryptonContextMenuItems
    Friend WithEvents cmsTextBoxItems As Krypton.Toolkit.KryptonContextMenuItems
    Friend WithEvents cmsDropCapItems As Krypton.Toolkit.KryptonContextMenuItems
    Friend WithEvents cmsEquationItems As Krypton.Toolkit.KryptonContextMenuItems
    Friend WithEvents cmsQuickPartsItems As Krypton.Toolkit.KryptonContextMenuItems
    Friend WithEvents cmsShapesItems As Krypton.Toolkit.KryptonContextMenuItems
    Friend WithEvents cmsThemesItems As Krypton.Toolkit.KryptonContextMenuItems
    Friend WithEvents cmsPageColorItems As Krypton.Toolkit.KryptonContextMenuItems
    Friend WithEvents cmsUseVotingButtonsItems As Krypton.Toolkit.KryptonContextMenuItems
    Friend WithEvents cmsSaveSentItemItems As Krypton.Toolkit.KryptonContextMenuItems
    Friend WithEvents cmsFollowUpItems As Krypton.Toolkit.KryptonContextMenuItems
    Friend WithEvents cmsSpellingItems As Krypton.Toolkit.KryptonContextMenuItems
    Friend WithEvents kryptonContextMenuSeparator2 As Krypton.Toolkit.KryptonContextMenuSeparator
    Friend WithEvents kryptonContextMenuSeparator1 As Krypton.Toolkit.KryptonContextMenuSeparator
    Friend WithEvents kryptonContextMenuSeparator3 As Krypton.Toolkit.KryptonContextMenuSeparator
    Friend WithEvents kryptonContextMenuSeparator4 As Krypton.Toolkit.KryptonContextMenuSeparator
    Friend WithEvents kryptonRibbonGroupLines3 As Krypton.Ribbon.KryptonRibbonGroupLines
    Friend WithEvents kryptonRibbonGroupCheckBox1 As Krypton.Ribbon.KryptonRibbonGroupCheckBox
    Friend WithEvents kryptonRibbonGroupCheckBox2 As Krypton.Ribbon.KryptonRibbonGroupCheckBox
    Friend WithEvents kryptonContextMenuSeparator6 As Krypton.Toolkit.KryptonContextMenuSeparator
    Friend WithEvents kryptonContextMenuSeparator7 As Krypton.Toolkit.KryptonContextMenuSeparator
    Friend WithEvents kryptonContextMenuSeparator8 As Krypton.Toolkit.KryptonContextMenuSeparator
    Friend WithEvents kryptonContextMenuSeparator5 As Krypton.Toolkit.KryptonContextMenuSeparator
    Friend WithEvents kryptonContextMenuSeparator9 As Krypton.Toolkit.KryptonContextMenuSeparator
    Friend WithEvents kryptonContextMenuSeparator10 As Krypton.Toolkit.KryptonContextMenuSeparator
    Friend WithEvents kryptonContextMenuItem1 As Krypton.Toolkit.KryptonContextMenuItem
    Friend WithEvents kryptonContextMenuItem2 As Krypton.Toolkit.KryptonContextMenuItem
    Friend WithEvents kryptonContextMenuSeparator11 As Krypton.Toolkit.KryptonContextMenuSeparator
    Friend WithEvents kryptonContextMenuItem3 As Krypton.Toolkit.KryptonContextMenuItem
    Friend WithEvents kryptonContextMenuItem4 As Krypton.Toolkit.KryptonContextMenuItem
    Friend WithEvents kryptonContextMenuItem5 As Krypton.Toolkit.KryptonContextMenuItem
    Friend WithEvents kryptonContextMenuItem6 As Krypton.Toolkit.KryptonContextMenuItem
    Friend WithEvents kryptonContextMenuItem7 As Krypton.Toolkit.KryptonContextMenuItem
    Friend WithEvents kryptonContextMenuSeparator12 As Krypton.Toolkit.KryptonContextMenuSeparator
    Friend WithEvents kryptonContextMenuItem8 As Krypton.Toolkit.KryptonContextMenuItem
    Friend WithEvents kryptonContextMenuItem9 As Krypton.Toolkit.KryptonContextMenuItem
    Friend WithEvents kryptonContextMenuSeparator13 As Krypton.Toolkit.KryptonContextMenuSeparator
    Friend WithEvents kryptonRibbonRecentDoc1 As Krypton.Ribbon.KryptonRibbonRecentDoc
    Friend WithEvents kryptonRibbonRecentDoc2 As Krypton.Ribbon.KryptonRibbonRecentDoc
    Friend WithEvents kryptonRibbonRecentDoc3 As Krypton.Ribbon.KryptonRibbonRecentDoc
    Friend WithEvents kryptonRibbonRecentDoc4 As Krypton.Ribbon.KryptonRibbonRecentDoc
    Friend WithEvents kryptonRibbonRecentDoc5 As Krypton.Ribbon.KryptonRibbonRecentDoc
    Friend WithEvents kryptonRibbonRecentDoc6 As Krypton.Ribbon.KryptonRibbonRecentDoc
    Friend WithEvents kryptonRibbonRecentDoc7 As Krypton.Ribbon.KryptonRibbonRecentDoc
    Friend WithEvents kryptonRibbonRecentDoc8 As Krypton.Ribbon.KryptonRibbonRecentDoc
    Friend WithEvents buttonSpecAppMenu1 As Krypton.Ribbon.ButtonSpecAppMenu
    Friend WithEvents kryptonContextMenuItems1 As Krypton.Toolkit.KryptonContextMenuItems
    Friend WithEvents kryptonContextMenuHeading1 As Krypton.Toolkit.KryptonContextMenuHeading
    Friend WithEvents kryptonContextMenuItem10 As Krypton.Toolkit.KryptonContextMenuItem
    Friend WithEvents kryptonContextMenuItems2 As Krypton.Toolkit.KryptonContextMenuItems
    Friend WithEvents kryptonContextMenuHeading2 As Krypton.Toolkit.KryptonContextMenuHeading
    Friend WithEvents kryptonContextMenuItem11 As Krypton.Toolkit.KryptonContextMenuItem
    Friend WithEvents kryptonContextMenuItem12 As Krypton.Toolkit.KryptonContextMenuItem
    Friend WithEvents kryptonContextMenuItem13 As Krypton.Toolkit.KryptonContextMenuItem
    Friend WithEvents kryptonContextMenuItem14 As Krypton.Toolkit.KryptonContextMenuItem
    Friend WithEvents kryptonContextMenuSeparator15 As Krypton.Toolkit.KryptonContextMenuSeparator
    Friend WithEvents kryptonContextMenuItems3 As Krypton.Toolkit.KryptonContextMenuItems
    Friend WithEvents kryptonContextMenuHeading3 As Krypton.Toolkit.KryptonContextMenuHeading
    Friend WithEvents kryptonContextMenuItem15 As Krypton.Toolkit.KryptonContextMenuItem
    Friend WithEvents kryptonManager1 As Krypton.Toolkit.KryptonManager
    Friend WithEvents richTextBoxMessage As Krypton.Toolkit.KryptonRichTextBox
    Friend WithEvents includeSignature As Krypton.Ribbon.KryptonRibbonGroupButton
    Friend WithEvents kryptonLabel1 As Krypton.Toolkit.KryptonLabel
    Friend WithEvents kryptonButton2 As Krypton.Toolkit.KryptonButton
    Friend WithEvents kryptonButton1 As Krypton.Toolkit.KryptonButton
    Friend WithEvents optionsHighImportance As Krypton.Ribbon.KryptonRibbonGroupButton
    Friend WithEvents optionsLowImportance As Krypton.Ribbon.KryptonRibbonGroupButton
    Friend WithEvents kryptonRibbonGroupCustomControl1 As Krypton.Ribbon.KryptonRibbonGroupCustomControl
    Friend WithEvents kryptonRibbonGroupThemeComboBox1 As Krypton.Ribbon.KryptonRibbonGroupThemeComboBox
End Class
