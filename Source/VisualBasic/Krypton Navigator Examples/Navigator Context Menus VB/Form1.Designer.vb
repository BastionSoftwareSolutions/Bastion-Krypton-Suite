' VB.NET twin of Source\Krypton Navigator Examples\Navigator Context Menus\Form1.Designer.cs (Bastion Phase 4c).
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
        Me.kryptonNavigator1 = New Krypton.Navigator.KryptonNavigator()
        Me.page1 = New Krypton.Navigator.KryptonPage()
        Me.kryptonLabel1 = New Krypton.Toolkit.KryptonLabel()
        Me.kcmDollar = New Krypton.Toolkit.KryptonContextMenu()
        Me.kcmHeadingDollar = New Krypton.Toolkit.KryptonContextMenuHeading()
        Me.kcmItemsDollar = New Krypton.Toolkit.KryptonContextMenuItems()
        Me.kcmDollar1 = New Krypton.Toolkit.KryptonContextMenuItem()
        Me.kcmDollar2 = New Krypton.Toolkit.KryptonContextMenuItem()
        Me.kcmDollar3 = New Krypton.Toolkit.KryptonContextMenuItem()
        Me.page2 = New Krypton.Navigator.KryptonPage()
        Me.kryptonLabel2 = New Krypton.Toolkit.KryptonLabel()
        Me.kcmEuro = New Krypton.Toolkit.KryptonContextMenu()
        Me.kcmHeadingEuro = New Krypton.Toolkit.KryptonContextMenuHeading()
        Me.kcmItemsEuro = New Krypton.Toolkit.KryptonContextMenuItems()
        Me.kcmEuro1 = New Krypton.Toolkit.KryptonContextMenuItem()
        Me.kcmEuro2 = New Krypton.Toolkit.KryptonContextMenuItem()
        Me.kcmSeparatorEuro = New Krypton.Toolkit.KryptonContextMenuSeparator()
        Me.kcmEuro3 = New Krypton.Toolkit.KryptonContextMenuItem()
        Me.kcmEuro4 = New Krypton.Toolkit.KryptonContextMenuItem()
        Me.kcmEuro5 = New Krypton.Toolkit.KryptonContextMenuItem()
        Me.page3 = New Krypton.Navigator.KryptonPage()
        Me.kryptonLabel3 = New Krypton.Toolkit.KryptonLabel()
        Me.kcmYen = New Krypton.Toolkit.KryptonContextMenu()
        Me.kcmHeadingYen = New Krypton.Toolkit.KryptonContextMenuHeading()
        Me.kcmItemsYen = New Krypton.Toolkit.KryptonContextMenuItems()
        Me.kcmYen1 = New Krypton.Toolkit.KryptonContextMenuItem()
        Me.kcmYen2 = New Krypton.Toolkit.KryptonContextMenuItem()
        Me.kcmSeparatorYen = New Krypton.Toolkit.KryptonContextMenuSeparator()
        Me.kcmHeadingYenMore = New Krypton.Toolkit.KryptonContextMenuHeading()
        Me.kcmItemsYenMore = New Krypton.Toolkit.KryptonContextMenuItems()
        Me.kcmYen3 = New Krypton.Toolkit.KryptonContextMenuItem()
        Me.kcmYen4 = New Krypton.Toolkit.KryptonContextMenuItem()
        Me.page4 = New Krypton.Navigator.KryptonPage()
        Me.kryptonLabel4 = New Krypton.Toolkit.KryptonLabel()
        Me.kcmPound = New Krypton.Toolkit.KryptonContextMenu()
        Me.kcmHeadingPound = New Krypton.Toolkit.KryptonContextMenuHeading()
        Me.kcmItemsPound = New Krypton.Toolkit.KryptonContextMenuItems()
        Me.kcmPound1 = New Krypton.Toolkit.KryptonContextMenuItem()
        Me.kcmPound2 = New Krypton.Toolkit.KryptonContextMenuItem()
        Me.kcmPound3 = New Krypton.Toolkit.KryptonContextMenuItem()
        Me.kcmSeparatorPound = New Krypton.Toolkit.KryptonContextMenuSeparator()
        Me.kcmPound4 = New Krypton.Toolkit.KryptonContextMenuItem()
        Me.kcmPound5 = New Krypton.Toolkit.KryptonContextMenuItem()
        Me.kcmPound6 = New Krypton.Toolkit.KryptonContextMenuItem()
        Me.kcmNavigator = New Krypton.Toolkit.KryptonContextMenu()
        Me.kcmHeadingNavigator = New Krypton.Toolkit.KryptonContextMenuHeading()
        Me.kcmItemsNavigator = New Krypton.Toolkit.KryptonContextMenuItems()
        Me.kcmFirst = New Krypton.Toolkit.KryptonContextMenuItem()
        Me.kcmPrevious = New Krypton.Toolkit.KryptonContextMenuItem()
        Me.kcmNext = New Krypton.Toolkit.KryptonContextMenuItem()
        Me.kcmLast = New Krypton.Toolkit.KryptonContextMenuItem()
        Me.buttonClose = New System.Windows.Forms.Button()
        Me.label1 = New System.Windows.Forms.Label()
        Me.kryptonManager1 = New Krypton.Toolkit.KryptonManager(Me.components)
        CType(Me.kryptonNavigator1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.kryptonNavigator1.SuspendLayout()
        CType(Me.page1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.page1.SuspendLayout()
        CType(Me.page2, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.page2.SuspendLayout()
        CType(Me.page3, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.page3.SuspendLayout()
        CType(Me.page4, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.page4.SuspendLayout()
        Me.SuspendLayout()
        Me.kryptonNavigator1.Button.ButtonDisplayLogic = Krypton.Navigator.ButtonDisplayLogic.None
        Me.kryptonNavigator1.Button.CloseButtonAction = Krypton.Navigator.CloseButtonAction.RemovePageAndDispose
        Me.kryptonNavigator1.Button.CloseButtonDisplay = Krypton.Navigator.ButtonDisplay.Hide
        Me.kryptonNavigator1.Button.ContextButtonAction = Krypton.Navigator.ContextButtonAction.SelectPage
        Me.kryptonNavigator1.Button.ContextButtonDisplay = Krypton.Navigator.ButtonDisplay.Logic
        Me.kryptonNavigator1.Button.ContextMenuMapImage = Krypton.Navigator.MapKryptonPageImage.Small
        Me.kryptonNavigator1.Button.ContextMenuMapText = Krypton.Navigator.MapKryptonPageText.TextTitle
        Me.kryptonNavigator1.Button.NextButtonAction = Krypton.Navigator.DirectionButtonAction.ModeAppropriateAction
        Me.kryptonNavigator1.Button.NextButtonDisplay = Krypton.Navigator.ButtonDisplay.Logic
        Me.kryptonNavigator1.Button.PreviousButtonAction = Krypton.Navigator.DirectionButtonAction.ModeAppropriateAction
        Me.kryptonNavigator1.Button.PreviousButtonDisplay = Krypton.Navigator.ButtonDisplay.Logic
        Me.kryptonNavigator1.ControlKryptonFormFeatures = False
        Me.kryptonNavigator1.Location = New System.Drawing.Point(12, 12)
        Me.kryptonNavigator1.Name = "kryptonNavigator1"
        Me.kryptonNavigator1.NavigatorMode = Krypton.Navigator.NavigatorMode.BarTabGroup
        Me.kryptonNavigator1.Owner = Nothing
        Me.kryptonNavigator1.PageBackStyle = Krypton.Toolkit.PaletteBackStyle.ControlClient
        Me.kryptonNavigator1.Pages.AddRange(New Krypton.Navigator.KryptonPage() { Me.page1, Me.page2, Me.page3, Me.page4})
        Me.kryptonNavigator1.SelectedIndex = 3
        Me.kryptonNavigator1.Size = New System.Drawing.Size(442, 146)
        Me.kryptonNavigator1.TabIndex = 0
        Me.kryptonNavigator1.Text = "kryptonNavigator1"
        Me.page1.AutoHiddenSlideSize = New System.Drawing.Size(200, 200)
        Me.page1.Controls.Add(Me.kryptonLabel1)
        Me.page1.Flags = 65534
        Me.page1.ImageSmall = CType(resources.GetObject("page1.ImageSmall"), System.Drawing.Bitmap)
        Me.page1.KryptonContextMenu = Me.kcmDollar
        Me.page1.LastVisibleSet = True
        Me.page1.MinimumSize = New System.Drawing.Size(50, 50)
        Me.page1.Name = "page1"
        Me.page1.Size = New System.Drawing.Size(300, 113)
        Me.page1.Text = "Dollar"
        Me.page1.ToolTipTitle = "Page ToolTip"
        Me.page1.UniqueName = "BB8AE01F8DCC465FBB8AE01F8DCC465F"
        Me.kryptonLabel1.Location = New System.Drawing.Point(16, 16)
        Me.kryptonLabel1.Name = "kryptonLabel1"
        Me.kryptonLabel1.Size = New System.Drawing.Size(209, 26)
        Me.kryptonLabel1.TabIndex = 0
        Me.kryptonLabel1.Values.Text = "Right-click me or the header."
        Me.kcmDollar.Items.AddRange(New Krypton.Toolkit.KryptonContextMenuItemBase() { Me.kcmHeadingDollar, Me.kcmItemsDollar})
        Me.kcmHeadingDollar.ExtraText = ""
        Me.kcmHeadingDollar.Text = "Dollar"
        Me.kcmItemsDollar.Items.AddRange(New Krypton.Toolkit.KryptonContextMenuItemBase() { Me.kcmDollar1, Me.kcmDollar2, Me.kcmDollar3})
        Me.kcmDollar1.Image = CType(resources.GetObject("kcmDollar1.Image"), System.Drawing.Image)
        Me.kcmDollar1.Text = "Dollar 1"
        Me.kcmDollar2.Image = CType(resources.GetObject("kcmDollar2.Image"), System.Drawing.Image)
        Me.kcmDollar2.Text = "Dollar 2"
        Me.kcmDollar3.Image = CType(resources.GetObject("kcmDollar3.Image"), System.Drawing.Image)
        Me.kcmDollar3.Text = "Dollar 3"
        Me.page2.AutoHiddenSlideSize = New System.Drawing.Size(200, 200)
        Me.page2.Controls.Add(Me.kryptonLabel2)
        Me.page2.Flags = 65534
        Me.page2.ImageSmall = CType(resources.GetObject("page2.ImageSmall"), System.Drawing.Bitmap)
        Me.page2.KryptonContextMenu = Me.kcmEuro
        Me.page2.LastVisibleSet = True
        Me.page2.MinimumSize = New System.Drawing.Size(50, 50)
        Me.page2.Name = "page2"
        Me.page2.Size = New System.Drawing.Size(300, 113)
        Me.page2.Text = "Euro"
        Me.page2.ToolTipTitle = "Page ToolTip"
        Me.page2.UniqueName = "C0F54949D510456CC0F54949D510456C"
        Me.kryptonLabel2.Location = New System.Drawing.Point(129, 77)
        Me.kryptonLabel2.Name = "kryptonLabel2"
        Me.kryptonLabel2.Size = New System.Drawing.Size(209, 26)
        Me.kryptonLabel2.TabIndex = 1
        Me.kryptonLabel2.Values.Text = "Right-click me or the header."
        Me.kcmEuro.Items.AddRange(New Krypton.Toolkit.KryptonContextMenuItemBase() { Me.kcmHeadingEuro, Me.kcmItemsEuro})
        Me.kcmHeadingEuro.ExtraText = ""
        Me.kcmHeadingEuro.Text = "Euro"
        Me.kcmItemsEuro.Items.AddRange(New Krypton.Toolkit.KryptonContextMenuItemBase() { Me.kcmEuro1, Me.kcmEuro2, Me.kcmSeparatorEuro, Me.kcmEuro3, Me.kcmEuro4, Me.kcmEuro5})
        Me.kcmEuro1.Image = CType(resources.GetObject("kcmEuro1.Image"), System.Drawing.Image)
        Me.kcmEuro1.Text = "Euro 1"
        Me.kcmEuro2.Image = CType(resources.GetObject("kcmEuro2.Image"), System.Drawing.Image)
        Me.kcmEuro2.Text = "Euro 2"
        Me.kcmEuro3.Image = CType(resources.GetObject("kcmEuro3.Image"), System.Drawing.Image)
        Me.kcmEuro3.Text = "Euro 3"
        Me.kcmEuro4.Image = CType(resources.GetObject("kcmEuro4.Image"), System.Drawing.Image)
        Me.kcmEuro4.Text = "Euro 4"
        Me.kcmEuro5.Image = CType(resources.GetObject("kcmEuro5.Image"), System.Drawing.Image)
        Me.kcmEuro5.Text = "Euro 5"
        Me.page3.AutoHiddenSlideSize = New System.Drawing.Size(200, 200)
        Me.page3.Controls.Add(Me.kryptonLabel3)
        Me.page3.Flags = 65534
        Me.page3.ImageSmall = CType(resources.GetObject("page3.ImageSmall"), System.Drawing.Bitmap)
        Me.page3.KryptonContextMenu = Me.kcmYen
        Me.page3.LastVisibleSet = True
        Me.page3.MinimumSize = New System.Drawing.Size(50, 50)
        Me.page3.Name = "page3"
        Me.page3.Size = New System.Drawing.Size(300, 113)
        Me.page3.Text = "Yen"
        Me.page3.ToolTipTitle = "Page ToolTip"
        Me.page3.UniqueName = "E8D9586889B94658E8D9586889B94658"
        Me.kryptonLabel3.Location = New System.Drawing.Point(73, 47)
        Me.kryptonLabel3.Name = "kryptonLabel3"
        Me.kryptonLabel3.Size = New System.Drawing.Size(209, 26)
        Me.kryptonLabel3.TabIndex = 1
        Me.kryptonLabel3.Values.Text = "Right-click me or the header."
        Me.kcmYen.Items.AddRange(New Krypton.Toolkit.KryptonContextMenuItemBase() { Me.kcmHeadingYen, Me.kcmItemsYen, Me.kcmSeparatorYen, Me.kcmHeadingYenMore, Me.kcmItemsYenMore})
        Me.kcmHeadingYen.ExtraText = ""
        Me.kcmHeadingYen.Text = "Yen"
        Me.kcmItemsYen.Items.AddRange(New Krypton.Toolkit.KryptonContextMenuItemBase() { Me.kcmYen1, Me.kcmYen2})
        Me.kcmYen1.Image = CType(resources.GetObject("kcmYen1.Image"), System.Drawing.Image)
        Me.kcmYen1.Text = "Yen 1"
        Me.kcmYen2.Image = CType(resources.GetObject("kcmYen2.Image"), System.Drawing.Image)
        Me.kcmYen2.Text = "Yen 2"
        Me.kcmHeadingYenMore.ExtraText = ""
        Me.kcmHeadingYenMore.Text = "More Yen"
        Me.kcmItemsYenMore.Items.AddRange(New Krypton.Toolkit.KryptonContextMenuItemBase() { Me.kcmYen3, Me.kcmYen4})
        Me.kcmYen3.Image = CType(resources.GetObject("kcmYen3.Image"), System.Drawing.Image)
        Me.kcmYen3.Text = "Yen 3"
        Me.kcmYen4.Image = CType(resources.GetObject("kcmYen4.Image"), System.Drawing.Image)
        Me.kcmYen4.Text = "Yen 4"
        Me.page4.AutoHiddenSlideSize = New System.Drawing.Size(200, 200)
        Me.page4.Controls.Add(Me.kryptonLabel4)
        Me.page4.Flags = 65534
        Me.page4.ImageSmall = CType(resources.GetObject("page4.ImageSmall"), System.Drawing.Bitmap)
        Me.page4.KryptonContextMenu = Me.kcmPound
        Me.page4.LastVisibleSet = True
        Me.page4.MinimumSize = New System.Drawing.Size(50, 50)
        Me.page4.Name = "page4"
        Me.page4.Size = New System.Drawing.Size(440, 113)
        Me.page4.Text = "Pound"
        Me.page4.ToolTipTitle = "Page ToolTip"
        Me.page4.UniqueName = "AB472A5702144EA7AB472A5702144EA7"
        Me.kryptonLabel4.Location = New System.Drawing.Point(129, 19)
        Me.kryptonLabel4.Name = "kryptonLabel4"
        Me.kryptonLabel4.Size = New System.Drawing.Size(209, 26)
        Me.kryptonLabel4.TabIndex = 1
        Me.kryptonLabel4.Values.Text = "Right-click me or the header."
        Me.kcmPound.Items.AddRange(New Krypton.Toolkit.KryptonContextMenuItemBase() { Me.kcmHeadingPound, Me.kcmItemsPound})
        Me.kcmHeadingPound.ExtraText = ""
        Me.kcmHeadingPound.Text = "Pound"
        Me.kcmItemsPound.Items.AddRange(New Krypton.Toolkit.KryptonContextMenuItemBase() { Me.kcmPound1, Me.kcmPound2, Me.kcmPound3, Me.kcmSeparatorPound, Me.kcmPound4, Me.kcmPound5, Me.kcmPound6})
        Me.kcmPound1.Image = CType(resources.GetObject("kcmPound1.Image"), System.Drawing.Image)
        Me.kcmPound1.Text = "Pound 1"
        Me.kcmPound2.Image = CType(resources.GetObject("kcmPound2.Image"), System.Drawing.Image)
        Me.kcmPound2.Text = "Pound 2"
        Me.kcmPound3.Image = CType(resources.GetObject("kcmPound3.Image"), System.Drawing.Image)
        Me.kcmPound3.Text = "Pound 3"
        Me.kcmSeparatorPound.Horizontal = False
        Me.kcmPound4.Image = CType(resources.GetObject("kcmPound4.Image"), System.Drawing.Image)
        Me.kcmPound4.Text = "Pound 4"
        Me.kcmPound5.Image = CType(resources.GetObject("kcmPound5.Image"), System.Drawing.Image)
        Me.kcmPound5.Text = "Pound 5"
        Me.kcmPound6.Image = CType(resources.GetObject("kcmPound6.Image"), System.Drawing.Image)
        Me.kcmPound6.Text = "Pound 6"
        Me.kcmNavigator.Items.AddRange(New Krypton.Toolkit.KryptonContextMenuItemBase() { Me.kcmHeadingNavigator, Me.kcmItemsNavigator})
        Me.kcmHeadingNavigator.ExtraText = ""
        Me.kcmHeadingNavigator.Text = "Navigator"
        Me.kcmItemsNavigator.Items.AddRange(New Krypton.Toolkit.KryptonContextMenuItemBase() { Me.kcmFirst, Me.kcmPrevious, Me.kcmNext, Me.kcmLast})
        Me.kcmFirst.Image = CType(resources.GetObject("kcmFirst.Image"), System.Drawing.Image)
        Me.kcmFirst.Text = "Move To First"
        Me.kcmPrevious.Image = CType(resources.GetObject("kcmPrevious.Image"), System.Drawing.Image)
        Me.kcmPrevious.Text = "Move Previous"
        Me.kcmNext.Image = CType(resources.GetObject("kcmNext.Image"), System.Drawing.Image)
        Me.kcmNext.Text = "Move Next"
        Me.kcmLast.Image = CType(resources.GetObject("kcmLast.Image"), System.Drawing.Image)
        Me.kcmLast.Text = "Move To Last"
        Me.buttonClose.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.buttonClose.Location = New System.Drawing.Point(379, 264)
        Me.buttonClose.Name = "buttonClose"
        Me.buttonClose.Size = New System.Drawing.Size(75, 23)
        Me.buttonClose.TabIndex = 1
        Me.buttonClose.Text = "Close"
        Me.buttonClose.UseVisualStyleBackColor = True
        Me.label1.AutoSize = True
        Me.label1.Location = New System.Drawing.Point(12, 165)
        Me.label1.Name = "label1"
        Me.label1.Size = New System.Drawing.Size(372, 102)
        Me.label1.TabIndex = 2
        Me.label1.Text = resources.GetString("label1.Text")
        Me.kryptonManager1.GlobalPaletteMode = Krypton.Toolkit.PaletteMode.ProfessionalSystem
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8F, 17F)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(462, 295)
        Me.Controls.Add(Me.label1)
        Me.Controls.Add(Me.buttonClose)
        Me.Controls.Add(Me.kryptonNavigator1)
        Me.Font = New System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.MaximizeBox = False
        Me.MinimizeBox = False
        Me.Name = "Form1"
        Me.Text = "Navigator Context Menus"
        CType(Me.kryptonNavigator1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.kryptonNavigator1.ResumeLayout(False)
        CType(Me.page1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.page1.ResumeLayout(False)
        Me.page1.PerformLayout()
        CType(Me.page2, System.ComponentModel.ISupportInitialize).EndInit()
        Me.page2.ResumeLayout(False)
        Me.page2.PerformLayout()
        CType(Me.page3, System.ComponentModel.ISupportInitialize).EndInit()
        Me.page3.ResumeLayout(False)
        Me.page3.PerformLayout()
        CType(Me.page4, System.ComponentModel.ISupportInitialize).EndInit()
        Me.page4.ResumeLayout(False)
        Me.page4.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()
    End Sub

    Friend WithEvents kryptonNavigator1 As Krypton.Navigator.KryptonNavigator
    Friend WithEvents page1 As Krypton.Navigator.KryptonPage
    Friend WithEvents page2 As Krypton.Navigator.KryptonPage
    Friend WithEvents page3 As Krypton.Navigator.KryptonPage
    Friend WithEvents page4 As Krypton.Navigator.KryptonPage
    Friend WithEvents kcmDollar As Krypton.Toolkit.KryptonContextMenu
    Friend WithEvents kcmHeadingDollar As Krypton.Toolkit.KryptonContextMenuHeading
    Friend WithEvents kcmItemsDollar As Krypton.Toolkit.KryptonContextMenuItems
    Friend WithEvents kcmDollar1 As Krypton.Toolkit.KryptonContextMenuItem
    Friend WithEvents kcmDollar2 As Krypton.Toolkit.KryptonContextMenuItem
    Friend WithEvents kcmDollar3 As Krypton.Toolkit.KryptonContextMenuItem
    Friend WithEvents kcmEuro As Krypton.Toolkit.KryptonContextMenu
    Friend WithEvents kcmHeadingEuro As Krypton.Toolkit.KryptonContextMenuHeading
    Friend WithEvents kcmItemsEuro As Krypton.Toolkit.KryptonContextMenuItems
    Friend WithEvents kcmEuro1 As Krypton.Toolkit.KryptonContextMenuItem
    Friend WithEvents kcmEuro2 As Krypton.Toolkit.KryptonContextMenuItem
    Friend WithEvents kcmEuro3 As Krypton.Toolkit.KryptonContextMenuItem
    Friend WithEvents kcmSeparatorEuro As Krypton.Toolkit.KryptonContextMenuSeparator
    Friend WithEvents kcmEuro4 As Krypton.Toolkit.KryptonContextMenuItem
    Friend WithEvents kcmEuro5 As Krypton.Toolkit.KryptonContextMenuItem
    Friend WithEvents kcmYen As Krypton.Toolkit.KryptonContextMenu
    Friend WithEvents kcmHeadingYen As Krypton.Toolkit.KryptonContextMenuHeading
    Friend WithEvents kcmItemsYen As Krypton.Toolkit.KryptonContextMenuItems
    Friend WithEvents kcmYen1 As Krypton.Toolkit.KryptonContextMenuItem
    Friend WithEvents kcmYen2 As Krypton.Toolkit.KryptonContextMenuItem
    Friend WithEvents kcmSeparatorYen As Krypton.Toolkit.KryptonContextMenuSeparator
    Friend WithEvents kcmHeadingYenMore As Krypton.Toolkit.KryptonContextMenuHeading
    Friend WithEvents kcmItemsYenMore As Krypton.Toolkit.KryptonContextMenuItems
    Friend WithEvents kcmYen3 As Krypton.Toolkit.KryptonContextMenuItem
    Friend WithEvents kcmYen4 As Krypton.Toolkit.KryptonContextMenuItem
    Friend WithEvents kcmPound As Krypton.Toolkit.KryptonContextMenu
    Friend WithEvents kcmHeadingPound As Krypton.Toolkit.KryptonContextMenuHeading
    Friend WithEvents kcmItemsPound As Krypton.Toolkit.KryptonContextMenuItems
    Friend WithEvents kcmPound1 As Krypton.Toolkit.KryptonContextMenuItem
    Friend WithEvents kcmPound2 As Krypton.Toolkit.KryptonContextMenuItem
    Friend WithEvents kcmPound3 As Krypton.Toolkit.KryptonContextMenuItem
    Friend WithEvents kcmSeparatorPound As Krypton.Toolkit.KryptonContextMenuSeparator
    Friend WithEvents kcmPound4 As Krypton.Toolkit.KryptonContextMenuItem
    Friend WithEvents kcmPound5 As Krypton.Toolkit.KryptonContextMenuItem
    Friend WithEvents kcmPound6 As Krypton.Toolkit.KryptonContextMenuItem
    Friend WithEvents kcmNavigator As Krypton.Toolkit.KryptonContextMenu
    Friend WithEvents kcmHeadingNavigator As Krypton.Toolkit.KryptonContextMenuHeading
    Friend WithEvents kcmItemsNavigator As Krypton.Toolkit.KryptonContextMenuItems
    Friend WithEvents kcmFirst As Krypton.Toolkit.KryptonContextMenuItem
    Friend WithEvents kcmPrevious As Krypton.Toolkit.KryptonContextMenuItem
    Friend WithEvents kcmNext As Krypton.Toolkit.KryptonContextMenuItem
    Friend WithEvents kcmLast As Krypton.Toolkit.KryptonContextMenuItem
    Friend WithEvents buttonClose As System.Windows.Forms.Button
    Friend WithEvents label1 As System.Windows.Forms.Label
    Friend WithEvents kryptonLabel1 As Krypton.Toolkit.KryptonLabel
    Friend WithEvents kryptonLabel2 As Krypton.Toolkit.KryptonLabel
    Friend WithEvents kryptonLabel3 As Krypton.Toolkit.KryptonLabel
    Friend WithEvents kryptonLabel4 As Krypton.Toolkit.KryptonLabel
    Friend WithEvents kryptonManager1 As Krypton.Toolkit.KryptonManager
End Class
