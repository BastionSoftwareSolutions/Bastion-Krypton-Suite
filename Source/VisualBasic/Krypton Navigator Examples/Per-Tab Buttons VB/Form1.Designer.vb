' VB.NET twin of Source\Krypton Navigator Examples\Per-Tab Buttons\Form1.Designer.cs (Bastion Phase 4c).
<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class Form1
    Inherits System.Windows.Forms.Form

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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(Form1))
        Me.groupBox1 = New System.Windows.Forms.GroupBox()
        Me.radioModesOutlook = New System.Windows.Forms.RadioButton()
        Me.radioModesStack = New System.Windows.Forms.RadioButton()
        Me.radioModeRibbonTabs = New System.Windows.Forms.RadioButton()
        Me.radioModesCheckButton = New System.Windows.Forms.RadioButton()
        Me.radioModeTabs = New System.Windows.Forms.RadioButton()
        Me.kryptonNavigator = New Krypton.Navigator.KryptonNavigator()
        Me.kryptonPage1 = New Krypton.Navigator.KryptonPage()
        Me.kryptonPage2 = New Krypton.Navigator.KryptonPage()
        Me.kryptonPage3 = New Krypton.Navigator.KryptonPage()
        Me.kryptonPage4 = New Krypton.Navigator.KryptonPage()
        Me.kryptonContextMenu = New Krypton.Toolkit.KryptonContextMenu()
        Me.kryptonContextMenuItems1 = New Krypton.Toolkit.KryptonContextMenuItems()
        Me.kryptonContextMenuItem1 = New Krypton.Toolkit.KryptonContextMenuItem()
        Me.kryptonContextMenuItem2 = New Krypton.Toolkit.KryptonContextMenuItem()
        Me.kryptonContextMenuItem3 = New Krypton.Toolkit.KryptonContextMenuItem()
        Me.kryptonContextMenuItem4 = New Krypton.Toolkit.KryptonContextMenuItem()
        Me.buttonClose = New System.Windows.Forms.Button()
        Me.buttonSpecAny1 = New Krypton.Toolkit.ButtonSpecAny()
        Me.groupBox2 = New System.Windows.Forms.GroupBox()
        Me.clearButtons = New System.Windows.Forms.Button()
        Me.addText = New System.Windows.Forms.Button()
        Me.addContext = New System.Windows.Forms.Button()
        Me.addArrow = New System.Windows.Forms.Button()
        Me.kryptonManager1 = New Krypton.Toolkit.KryptonManager(Me.components)
        Me.groupBox1.SuspendLayout()
        CType(Me.kryptonNavigator, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.kryptonNavigator.SuspendLayout()
        CType(Me.kryptonPage1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.kryptonPage2, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.kryptonPage3, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.kryptonPage4, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.groupBox2.SuspendLayout()
        Me.SuspendLayout()
        Me.groupBox1.Controls.Add(Me.radioModesOutlook)
        Me.groupBox1.Controls.Add(Me.radioModesStack)
        Me.groupBox1.Controls.Add(Me.radioModeRibbonTabs)
        Me.groupBox1.Controls.Add(Me.radioModesCheckButton)
        Me.groupBox1.Controls.Add(Me.radioModeTabs)
        Me.groupBox1.Location = New System.Drawing.Point(12, 12)
        Me.groupBox1.Name = "groupBox1"
        Me.groupBox1.Size = New System.Drawing.Size(148, 150)
        Me.groupBox1.TabIndex = 0
        Me.groupBox1.TabStop = False
        Me.groupBox1.Text = "Modes"
        Me.radioModesOutlook.AutoSize = True
        Me.radioModesOutlook.Location = New System.Drawing.Point(18, 116)
        Me.radioModesOutlook.Name = "radioModesOutlook"
        Me.radioModesOutlook.Size = New System.Drawing.Size(62, 17)
        Me.radioModesOutlook.TabIndex = 4
        Me.radioModesOutlook.TabStop = True
        Me.radioModesOutlook.Text = "Outlook"
        Me.radioModesOutlook.UseVisualStyleBackColor = True
        Me.radioModesStack.AutoSize = True
        Me.radioModesStack.Location = New System.Drawing.Point(18, 93)
        Me.radioModesStack.Name = "radioModesStack"
        Me.radioModesStack.Size = New System.Drawing.Size(51, 17)
        Me.radioModesStack.TabIndex = 3
        Me.radioModesStack.TabStop = True
        Me.radioModesStack.Text = "Stack"
        Me.radioModesStack.UseVisualStyleBackColor = True
        Me.radioModeRibbonTabs.AutoSize = True
        Me.radioModeRibbonTabs.Location = New System.Drawing.Point(18, 47)
        Me.radioModeRibbonTabs.Name = "radioModeRibbonTabs"
        Me.radioModeRibbonTabs.Size = New System.Drawing.Size(81, 17)
        Me.radioModeRibbonTabs.TabIndex = 1
        Me.radioModeRibbonTabs.TabStop = True
        Me.radioModeRibbonTabs.Text = "RibbonTabs"
        Me.radioModeRibbonTabs.UseVisualStyleBackColor = True
        Me.radioModesCheckButton.AutoSize = True
        Me.radioModesCheckButton.Location = New System.Drawing.Point(18, 70)
        Me.radioModesCheckButton.Name = "radioModesCheckButton"
        Me.radioModesCheckButton.Size = New System.Drawing.Size(91, 17)
        Me.radioModesCheckButton.TabIndex = 2
        Me.radioModesCheckButton.TabStop = True
        Me.radioModesCheckButton.Text = "CheckButtons"
        Me.radioModesCheckButton.UseVisualStyleBackColor = True
        Me.radioModeTabs.AutoSize = True
        Me.radioModeTabs.Location = New System.Drawing.Point(18, 24)
        Me.radioModeTabs.Name = "radioModeTabs"
        Me.radioModeTabs.Size = New System.Drawing.Size(48, 17)
        Me.radioModeTabs.TabIndex = 0
        Me.radioModeTabs.TabStop = True
        Me.radioModeTabs.Text = "Tabs"
        Me.radioModeTabs.UseVisualStyleBackColor = True
        Me.kryptonNavigator.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) Or System.Windows.Forms.AnchorStyles.Left) Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.kryptonNavigator.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowOnly
        Me.kryptonNavigator.Bar.BarMapExtraText = Krypton.Navigator.MapKryptonPageText.None
        Me.kryptonNavigator.Bar.BarMapImage = Krypton.Navigator.MapKryptonPageImage.Small
        Me.kryptonNavigator.Bar.BarMapText = Krypton.Navigator.MapKryptonPageText.TextTitle
        Me.kryptonNavigator.Bar.BarMultiline = Krypton.Navigator.BarMultiline.Singleline
        Me.kryptonNavigator.Bar.BarOrientation = Krypton.Toolkit.VisualOrientation.Top
        Me.kryptonNavigator.Bar.CheckButtonStyle = Krypton.Toolkit.ButtonStyle.Standalone
        Me.kryptonNavigator.Bar.ItemAlignment = Krypton.Toolkit.RelativePositionAlign.Near
        Me.kryptonNavigator.Bar.ItemMaximumSize = New System.Drawing.Size(2000, 200)
        Me.kryptonNavigator.Bar.ItemMinimumSize = New System.Drawing.Size(20, 20)
        Me.kryptonNavigator.Bar.ItemOrientation = Krypton.Toolkit.ButtonOrientation.Auto
        Me.kryptonNavigator.Bar.ItemSizing = Krypton.Navigator.BarItemSizing.SameHeight
        Me.kryptonNavigator.Bar.TabBorderStyle = Krypton.Toolkit.TabBorderStyle.RoundedOutsizeMedium
        Me.kryptonNavigator.Bar.TabStyle = Krypton.Toolkit.TabStyle.HighProfile
        Me.kryptonNavigator.Button.ButtonDisplayLogic = Krypton.Navigator.ButtonDisplayLogic.NextPrevious
        Me.kryptonNavigator.Button.CloseButtonAction = Krypton.Navigator.CloseButtonAction.RemovePageAndDispose
        Me.kryptonNavigator.Button.CloseButtonDisplay = Krypton.Navigator.ButtonDisplay.Hide
        Me.kryptonNavigator.Button.ContextButtonAction = Krypton.Navigator.ContextButtonAction.SelectPage
        Me.kryptonNavigator.Button.ContextButtonDisplay = Krypton.Navigator.ButtonDisplay.Logic
        Me.kryptonNavigator.Button.ContextMenuMapImage = Krypton.Navigator.MapKryptonPageImage.Small
        Me.kryptonNavigator.Button.ContextMenuMapText = Krypton.Navigator.MapKryptonPageText.TextTitle
        Me.kryptonNavigator.Button.NextButtonAction = Krypton.Navigator.DirectionButtonAction.ModeAppropriateAction
        Me.kryptonNavigator.Button.NextButtonDisplay = Krypton.Navigator.ButtonDisplay.Logic
        Me.kryptonNavigator.Button.PreviousButtonAction = Krypton.Navigator.DirectionButtonAction.ModeAppropriateAction
        Me.kryptonNavigator.Button.PreviousButtonDisplay = Krypton.Navigator.ButtonDisplay.Logic
        Me.kryptonNavigator.Group.GroupBackStyle = Krypton.Toolkit.PaletteBackStyle.ControlClient
        Me.kryptonNavigator.Group.GroupBorderStyle = Krypton.Toolkit.PaletteBorderStyle.ControlClient
        Me.kryptonNavigator.Header.HeaderPositionBar = Krypton.Toolkit.VisualOrientation.Top
        Me.kryptonNavigator.Header.HeaderPositionPrimary = Krypton.Toolkit.VisualOrientation.Top
        Me.kryptonNavigator.Header.HeaderPositionSecondary = Krypton.Toolkit.VisualOrientation.Bottom
        Me.kryptonNavigator.Header.HeaderStyleBar = Krypton.Toolkit.HeaderStyle.Secondary
        Me.kryptonNavigator.Header.HeaderStylePrimary = Krypton.Toolkit.HeaderStyle.Primary
        Me.kryptonNavigator.Header.HeaderStyleSecondary = Krypton.Toolkit.HeaderStyle.Secondary
        Me.kryptonNavigator.Location = New System.Drawing.Point(176, 21)
        Me.kryptonNavigator.Name = "kryptonNavigator"
        Me.kryptonNavigator.NavigatorMode = Krypton.Navigator.NavigatorMode.BarTabGroup
        Me.kryptonNavigator.PageBackStyle = Krypton.Toolkit.PaletteBackStyle.ControlClient
        Me.kryptonNavigator.Pages.AddRange(New Krypton.Navigator.KryptonPage() { Me.kryptonPage1, Me.kryptonPage2, Me.kryptonPage3, Me.kryptonPage4})
        Me.kryptonNavigator.Panel.PanelBackStyle = Krypton.Toolkit.PaletteBackStyle.PanelClient
        Me.kryptonNavigator.SelectedIndex = 0
        Me.kryptonNavigator.Size = New System.Drawing.Size(488, 314)
        Me.kryptonNavigator.TabIndex = 2
        Me.kryptonNavigator.Text = "kryptonNavigator1"
        Me.kryptonPage1.AutoHiddenSlideSize = New System.Drawing.Size(200, 200)
        Me.kryptonPage1.Flags = 65534
        Me.kryptonPage1.ImageSmall = CType(resources.GetObject("kryptonPage1.ImageSmall"), System.Drawing.Bitmap)
        Me.kryptonPage1.LastVisibleSet = True
        Me.kryptonPage1.MinimumSize = New System.Drawing.Size(50, 50)
        Me.kryptonPage1.Name = "kryptonPage1"
        Me.kryptonPage1.Size = New System.Drawing.Size(486, 281)
        Me.kryptonPage1.Text = "Page 1"
        Me.kryptonPage1.TextDescription = "Page 1"
        Me.kryptonPage1.TextTitle = "Page 1"
        Me.kryptonPage1.ToolTipTitle = "Page ToolTip"
        Me.kryptonPage1.UniqueName = "83EBB3EA59B0452F83EBB3EA59B0452F"
        Me.kryptonPage2.AutoHiddenSlideSize = New System.Drawing.Size(200, 200)
        Me.kryptonPage2.Flags = 65534
        Me.kryptonPage2.ImageSmall = CType(resources.GetObject("kryptonPage2.ImageSmall"), System.Drawing.Bitmap)
        Me.kryptonPage2.LastVisibleSet = True
        Me.kryptonPage2.MinimumSize = New System.Drawing.Size(50, 50)
        Me.kryptonPage2.Name = "kryptonPage2"
        Me.kryptonPage2.Size = New System.Drawing.Size(486, 281)
        Me.kryptonPage2.Text = "Two"
        Me.kryptonPage2.TextDescription = "Two"
        Me.kryptonPage2.TextTitle = "Two"
        Me.kryptonPage2.ToolTipTitle = "Page ToolTip"
        Me.kryptonPage2.UniqueName = "2DCBCC926137414E2DCBCC926137414E"
        Me.kryptonPage3.AutoHiddenSlideSize = New System.Drawing.Size(200, 200)
        Me.kryptonPage3.Flags = 65534
        Me.kryptonPage3.ImageSmall = CType(resources.GetObject("kryptonPage3.ImageSmall"), System.Drawing.Bitmap)
        Me.kryptonPage3.LastVisibleSet = True
        Me.kryptonPage3.MinimumSize = New System.Drawing.Size(50, 50)
        Me.kryptonPage3.Name = "kryptonPage3"
        Me.kryptonPage3.Size = New System.Drawing.Size(338, 302)
        Me.kryptonPage3.Text = "Page Three"
        Me.kryptonPage3.TextDescription = "Page Three"
        Me.kryptonPage3.TextTitle = "Page Three"
        Me.kryptonPage3.ToolTipTitle = "Page ToolTip"
        Me.kryptonPage3.UniqueName = "230DEF4541DE4E34230DEF4541DE4E34"
        Me.kryptonPage4.AutoHiddenSlideSize = New System.Drawing.Size(200, 200)
        Me.kryptonPage4.Flags = 65534
        Me.kryptonPage4.ImageSmall = CType(resources.GetObject("kryptonPage4.ImageSmall"), System.Drawing.Bitmap)
        Me.kryptonPage4.LastVisibleSet = True
        Me.kryptonPage4.MinimumSize = New System.Drawing.Size(50, 50)
        Me.kryptonPage4.Name = "kryptonPage4"
        Me.kryptonPage4.Size = New System.Drawing.Size(338, 302)
        Me.kryptonPage4.Text = "Page 4"
        Me.kryptonPage4.TextDescription = "Page 4"
        Me.kryptonPage4.TextTitle = "Page 4"
        Me.kryptonPage4.ToolTipTitle = "Page ToolTip"
        Me.kryptonPage4.UniqueName = "1D7E3CAE56E340031D7E3CAE56E34003"
        Me.kryptonContextMenu.Items.AddRange(New Krypton.Toolkit.KryptonContextMenuItemBase() { Me.kryptonContextMenuItems1})
        Me.kryptonContextMenuItems1.Items.AddRange(New Krypton.Toolkit.KryptonContextMenuItemBase() { Me.kryptonContextMenuItem1, Me.kryptonContextMenuItem2, Me.kryptonContextMenuItem3, Me.kryptonContextMenuItem4})
        Me.kryptonContextMenuItem1.CheckState = System.Windows.Forms.CheckState.Unchecked
        Me.kryptonContextMenuItem1.ShortcutKeys = System.Windows.Forms.Keys.None
        Me.kryptonContextMenuItem1.Text = "Menu Item"
        Me.kryptonContextMenuItem2.CheckState = System.Windows.Forms.CheckState.Unchecked
        Me.kryptonContextMenuItem2.ShortcutKeys = System.Windows.Forms.Keys.None
        Me.kryptonContextMenuItem2.Text = "Menu Item"
        Me.kryptonContextMenuItem3.CheckState = System.Windows.Forms.CheckState.Unchecked
        Me.kryptonContextMenuItem3.ShortcutKeys = System.Windows.Forms.Keys.None
        Me.kryptonContextMenuItem3.Text = "Menu Item"
        Me.kryptonContextMenuItem4.CheckState = System.Windows.Forms.CheckState.Unchecked
        Me.kryptonContextMenuItem4.ShortcutKeys = System.Windows.Forms.Keys.None
        Me.kryptonContextMenuItem4.Text = "Menu Item"
        Me.buttonClose.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.buttonClose.Location = New System.Drawing.Point(588, 348)
        Me.buttonClose.Name = "buttonClose"
        Me.buttonClose.Size = New System.Drawing.Size(75, 23)
        Me.buttonClose.TabIndex = 3
        Me.buttonClose.Text = "Close"
        Me.buttonClose.UseVisualStyleBackColor = True
        Me.buttonSpecAny1.Style = Krypton.Toolkit.PaletteButtonStyle.Standalone
        Me.buttonSpecAny1.Type = Krypton.Toolkit.PaletteButtonSpecStyle.Context
        Me.buttonSpecAny1.UniqueName = "6646CFE7A52E42FA6646CFE7A52E42FA"
        Me.groupBox2.Controls.Add(Me.clearButtons)
        Me.groupBox2.Controls.Add(Me.addText)
        Me.groupBox2.Controls.Add(Me.addContext)
        Me.groupBox2.Controls.Add(Me.addArrow)
        Me.groupBox2.Location = New System.Drawing.Point(12, 168)
        Me.groupBox2.Name = "groupBox2"
        Me.groupBox2.Size = New System.Drawing.Size(148, 167)
        Me.groupBox2.TabIndex = 1
        Me.groupBox2.TabStop = False
        Me.groupBox2.Text = "Page Buttons"
        Me.clearButtons.Location = New System.Drawing.Point(18, 125)
        Me.clearButtons.Name = "clearButtons"
        Me.clearButtons.Size = New System.Drawing.Size(103, 26)
        Me.clearButtons.TabIndex = 3
        Me.clearButtons.Text = " Clear"
        Me.clearButtons.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.clearButtons.UseVisualStyleBackColor = True
        Me.addText.Location = New System.Drawing.Point(18, 56)
        Me.addText.Name = "addText"
        Me.addText.Size = New System.Drawing.Size(103, 26)
        Me.addText.TabIndex = 2
        Me.addText.Text = " Add 'Text'"
        Me.addText.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.addText.UseVisualStyleBackColor = True
        Me.addContext.Location = New System.Drawing.Point(18, 25)
        Me.addContext.Name = "addContext"
        Me.addContext.Size = New System.Drawing.Size(103, 26)
        Me.addContext.TabIndex = 1
        Me.addContext.Text = " Add 'Context'"
        Me.addContext.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.addContext.UseVisualStyleBackColor = True
        Me.addArrow.Location = New System.Drawing.Point(18, 87)
        Me.addArrow.Name = "addArrow"
        Me.addArrow.Size = New System.Drawing.Size(103, 26)
        Me.addArrow.TabIndex = 0
        Me.addArrow.Text = " Add 'Arrow'"
        Me.addArrow.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.addArrow.UseVisualStyleBackColor = True
        Me.kryptonManager1.GlobalPaletteMode = Krypton.Toolkit.PaletteMode.ProfessionalSystem
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6F, 13F)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(680, 383)
        Me.Controls.Add(Me.groupBox2)
        Me.Controls.Add(Me.buttonClose)
        Me.Controls.Add(Me.kryptonNavigator)
        Me.Controls.Add(Me.groupBox1)
        Me.Font = New System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.MinimumSize = New System.Drawing.Size(626, 419)
        Me.Name = "Form1"
        Me.Text = "Per-Tab Buttons"
        Me.groupBox1.ResumeLayout(False)
        Me.groupBox1.PerformLayout()
        CType(Me.kryptonNavigator, System.ComponentModel.ISupportInitialize).EndInit()
        Me.kryptonNavigator.ResumeLayout(False)
        CType(Me.kryptonPage1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.kryptonPage2, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.kryptonPage3, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.kryptonPage4, System.ComponentModel.ISupportInitialize).EndInit()
        Me.groupBox2.ResumeLayout(False)
        Me.ResumeLayout(False)
    End Sub

    Friend WithEvents groupBox1 As System.Windows.Forms.GroupBox
    Friend WithEvents radioModeRibbonTabs As System.Windows.Forms.RadioButton
    Friend WithEvents radioModesCheckButton As System.Windows.Forms.RadioButton
    Friend WithEvents radioModeTabs As System.Windows.Forms.RadioButton
    Friend WithEvents kryptonNavigator As Krypton.Navigator.KryptonNavigator
    Friend WithEvents kryptonPage1 As Krypton.Navigator.KryptonPage
    Friend WithEvents kryptonPage2 As Krypton.Navigator.KryptonPage
    Friend WithEvents kryptonPage3 As Krypton.Navigator.KryptonPage
    Friend WithEvents kryptonPage4 As Krypton.Navigator.KryptonPage
    Friend WithEvents radioModesOutlook As System.Windows.Forms.RadioButton
    Friend WithEvents radioModesStack As System.Windows.Forms.RadioButton
    Friend WithEvents buttonClose As System.Windows.Forms.Button
    Friend WithEvents buttonSpecAny1 As Krypton.Toolkit.ButtonSpecAny
    Friend WithEvents kryptonContextMenu As Krypton.Toolkit.KryptonContextMenu
    Friend WithEvents kryptonContextMenuItems1 As Krypton.Toolkit.KryptonContextMenuItems
    Friend WithEvents kryptonContextMenuItem1 As Krypton.Toolkit.KryptonContextMenuItem
    Friend WithEvents kryptonContextMenuItem2 As Krypton.Toolkit.KryptonContextMenuItem
    Friend WithEvents kryptonContextMenuItem3 As Krypton.Toolkit.KryptonContextMenuItem
    Friend WithEvents kryptonContextMenuItem4 As Krypton.Toolkit.KryptonContextMenuItem
    Friend WithEvents groupBox2 As System.Windows.Forms.GroupBox
    Friend WithEvents addContext As System.Windows.Forms.Button
    Friend WithEvents addArrow As System.Windows.Forms.Button
    Friend WithEvents clearButtons As System.Windows.Forms.Button
    Friend WithEvents addText As System.Windows.Forms.Button
    Friend WithEvents kryptonManager1 As Krypton.Toolkit.KryptonManager
End Class
