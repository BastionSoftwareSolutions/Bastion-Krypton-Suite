' VB.NET twin of Source\Krypton Navigator Examples\Basic Events\Form1.Designer.cs (Bastion Phase 4c).
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
        Me.imageList1 = New System.Windows.Forms.ImageList(Me.components)
        Me.kryptonNavigator1 = New Krypton.Navigator.KryptonNavigator()
        Me.kryptonPage1 = New Krypton.Navigator.KryptonPage()
        Me.kryptonPage2 = New Krypton.Navigator.KryptonPage()
        Me.groupBoxPages = New System.Windows.Forms.GroupBox()
        Me.kryptonButtonEnable = New Krypton.Toolkit.KryptonButton()
        Me.kryptonButtonClear = New Krypton.Toolkit.KryptonButton()
        Me.kryptonButtonRemove = New Krypton.Toolkit.KryptonButton()
        Me.kryptonButtonAdd = New Krypton.Toolkit.KryptonButton()
        Me.groupBoxProperties = New System.Windows.Forms.GroupBox()
        Me.listBoxEvents = New System.Windows.Forms.ListBox()
        Me.buttonClose = New System.Windows.Forms.Button()
        Me.buttonClearEventList = New System.Windows.Forms.Button()
        Me.kryptonManager1 = New Krypton.Toolkit.KryptonManager(Me.components)
        CType(Me.kryptonNavigator1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.kryptonNavigator1.SuspendLayout()
        CType(Me.kryptonPage1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.kryptonPage2, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.groupBoxPages.SuspendLayout()
        Me.groupBoxProperties.SuspendLayout()
        Me.SuspendLayout()
        Me.imageList1.ImageStream = CType(resources.GetObject("imageList1.ImageStream"), System.Windows.Forms.ImageListStreamer)
        Me.imageList1.TransparentColor = System.Drawing.Color.Transparent
        Me.imageList1.Images.SetKeyName(0, "alarmclock.png")
        Me.imageList1.Images.SetKeyName(1, "apple.png")
        Me.imageList1.Images.SetKeyName(2, "banana.png")
        Me.imageList1.Images.SetKeyName(3, "basketball.png")
        Me.imageList1.Images.SetKeyName(4, "cloud_sun.png")
        Me.imageList1.Images.SetKeyName(5, "die_blue.png")
        Me.imageList1.Images.SetKeyName(6, "doctor.png")
        Me.imageList1.Images.SetKeyName(7, "flower_blue.png")
        Me.imageList1.Images.SetKeyName(8, "gear.png")
        Me.imageList1.Images.SetKeyName(9, "house.png")
        Me.kryptonNavigator1.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) Or System.Windows.Forms.AnchorStyles.Left), System.Windows.Forms.AnchorStyles)
        Me.kryptonNavigator1.Button.ButtonDisplayLogic = Krypton.Navigator.ButtonDisplayLogic.ContextNextPrevious
        Me.kryptonNavigator1.Button.CloseButtonAction = Krypton.Navigator.CloseButtonAction.RemovePageAndDispose
        Me.kryptonNavigator1.Button.CloseButtonDisplay = Krypton.Navigator.ButtonDisplay.Logic
        Me.kryptonNavigator1.Button.ContextButtonAction = Krypton.Navigator.ContextButtonAction.SelectPage
        Me.kryptonNavigator1.Button.ContextButtonDisplay = Krypton.Navigator.ButtonDisplay.Logic
        Me.kryptonNavigator1.Button.ContextMenuMapImage = Krypton.Navigator.MapKryptonPageImage.Small
        Me.kryptonNavigator1.Button.ContextMenuMapText = Krypton.Navigator.MapKryptonPageText.TextTitle
        Me.kryptonNavigator1.Button.NextButtonAction = Krypton.Navigator.DirectionButtonAction.ModeAppropriateAction
        Me.kryptonNavigator1.Button.NextButtonDisplay = Krypton.Navigator.ButtonDisplay.Logic
        Me.kryptonNavigator1.Button.PreviousButtonAction = Krypton.Navigator.DirectionButtonAction.ModeAppropriateAction
        Me.kryptonNavigator1.Button.PreviousButtonDisplay = Krypton.Navigator.ButtonDisplay.Logic
        Me.kryptonNavigator1.ControlKryptonFormFeatures = False
        Me.kryptonNavigator1.Location = New System.Drawing.Point(18, 31)
        Me.kryptonNavigator1.NavigatorMode = Krypton.Navigator.NavigatorMode.BarTabGroup
        Me.kryptonNavigator1.Owner = Nothing
        Me.kryptonNavigator1.PageBackStyle = Krypton.Toolkit.PaletteBackStyle.ControlClient
        Me.kryptonNavigator1.Pages.AddRange(New Krypton.Navigator.KryptonPage() { Me.kryptonPage1, Me.kryptonPage2})
        Me.kryptonNavigator1.SelectedIndex = 0
        Me.kryptonNavigator1.Size = New System.Drawing.Size(297, 355)
        Me.kryptonNavigator1.StateCommon.CheckButton.Content.Image.ImageH = Krypton.Toolkit.PaletteRelativeAlign.Center
        Me.kryptonNavigator1.StateCommon.CheckButton.Content.Image.ImageV = Krypton.Toolkit.PaletteRelativeAlign.Near
        Me.kryptonNavigator1.TabIndex = 0
        Me.kryptonNavigator1.Text = "kryptonNavigator1"
        Me.kryptonPage1.AutoHiddenSlideSize = New System.Drawing.Size(200, 200)
        Me.kryptonPage1.Flags = 65534
        Me.kryptonPage1.ImageLarge = CType(resources.GetObject("kryptonPage1.ImageLarge"), System.Drawing.Bitmap)
        Me.kryptonPage1.ImageMedium = CType(resources.GetObject("kryptonPage1.ImageMedium"), System.Drawing.Bitmap)
        Me.kryptonPage1.ImageSmall = CType(resources.GetObject("kryptonPage1.ImageSmall"), System.Drawing.Bitmap)
        Me.kryptonPage1.LastVisibleSet = True
        Me.kryptonPage1.MinimumSize = New System.Drawing.Size(50, 50)
        Me.kryptonPage1.Name = "kryptonPage1"
        Me.kryptonPage1.Size = New System.Drawing.Size(295, 324)
        Me.kryptonPage1.Text = "Page 1"
        Me.kryptonPage1.TextDescription = "Page 1 Description"
        Me.kryptonPage1.TextTitle = "Page 1 Title"
        Me.kryptonPage1.ToolTipTitle = "Page ToolTip"
        Me.kryptonPage1.UniqueName = "BA1D4D82F8F54F79BA1D4D82F8F54F79"
        Me.kryptonPage2.AutoHiddenSlideSize = New System.Drawing.Size(200, 200)
        Me.kryptonPage2.Flags = 65534
        Me.kryptonPage2.ImageLarge = CType(resources.GetObject("kryptonPage2.ImageLarge"), System.Drawing.Bitmap)
        Me.kryptonPage2.ImageMedium = CType(resources.GetObject("kryptonPage2.ImageMedium"), System.Drawing.Bitmap)
        Me.kryptonPage2.ImageSmall = CType(resources.GetObject("kryptonPage2.ImageSmall"), System.Drawing.Bitmap)
        Me.kryptonPage2.LastVisibleSet = True
        Me.kryptonPage2.MinimumSize = New System.Drawing.Size(50, 50)
        Me.kryptonPage2.Name = "kryptonPage2"
        Me.kryptonPage2.Size = New System.Drawing.Size(295, 329)
        Me.kryptonPage2.Text = "Page 2"
        Me.kryptonPage2.TextDescription = "Page 2 Description"
        Me.kryptonPage2.TextTitle = "Page 2 Title"
        Me.kryptonPage2.ToolTipTitle = "Page ToolTip"
        Me.kryptonPage2.UniqueName = "1FDD9B3FB1A6438C1FDD9B3FB1A6438C"
        Me.groupBoxPages.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Left), System.Windows.Forms.AnchorStyles)
        Me.groupBoxPages.Controls.Add(Me.kryptonButtonEnable)
        Me.groupBoxPages.Controls.Add(Me.kryptonButtonClear)
        Me.groupBoxPages.Controls.Add(Me.kryptonButtonRemove)
        Me.groupBoxPages.Controls.Add(Me.kryptonButtonAdd)
        Me.groupBoxPages.Location = New System.Drawing.Point(13, 407)
        Me.groupBoxPages.Name = "groupBoxPages"
        Me.groupBoxPages.Size = New System.Drawing.Size(309, 69)
        Me.groupBoxPages.TabIndex = 1
        Me.groupBoxPages.TabStop = False
        Me.groupBoxPages.Text = "Pages"
        Me.kryptonButtonEnable.Location = New System.Drawing.Point(234, 26)
        Me.kryptonButtonEnable.Name = "kryptonButtonEnable"
        Me.kryptonButtonEnable.Size = New System.Drawing.Size(65, 29)
        Me.kryptonButtonEnable.TabIndex = 4
        Me.kryptonButtonEnable.Values.DropDownArrowColor = System.Drawing.Color.Empty
        Me.kryptonButtonEnable.Values.Text = "Enable"
        Me.kryptonButtonClear.Location = New System.Drawing.Point(159, 26)
        Me.kryptonButtonClear.Name = "kryptonButtonClear"
        Me.kryptonButtonClear.Size = New System.Drawing.Size(65, 29)
        Me.kryptonButtonClear.TabIndex = 2
        Me.kryptonButtonClear.Values.DropDownArrowColor = System.Drawing.Color.Empty
        Me.kryptonButtonClear.Values.Text = "Clear"
        Me.kryptonButtonRemove.Location = New System.Drawing.Point(84, 26)
        Me.kryptonButtonRemove.Name = "kryptonButtonRemove"
        Me.kryptonButtonRemove.Size = New System.Drawing.Size(66, 29)
        Me.kryptonButtonRemove.TabIndex = 1
        Me.kryptonButtonRemove.Values.DropDownArrowColor = System.Drawing.Color.Empty
        Me.kryptonButtonRemove.Values.Text = "Remove"
        Me.kryptonButtonAdd.Location = New System.Drawing.Point(9, 26)
        Me.kryptonButtonAdd.Name = "kryptonButtonAdd"
        Me.kryptonButtonAdd.Size = New System.Drawing.Size(65, 29)
        Me.kryptonButtonAdd.TabIndex = 0
        Me.kryptonButtonAdd.Values.DropDownArrowColor = System.Drawing.Color.Empty
        Me.kryptonButtonAdd.Values.Text = "Add"
        Me.groupBoxProperties.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) Or System.Windows.Forms.AnchorStyles.Left) Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.groupBoxProperties.Controls.Add(Me.listBoxEvents)
        Me.groupBoxProperties.Location = New System.Drawing.Point(328, 12)
        Me.groupBoxProperties.Name = "groupBoxProperties"
        Me.groupBoxProperties.Padding = New System.Windows.Forms.Padding(5)
        Me.groupBoxProperties.Size = New System.Drawing.Size(325, 464)
        Me.groupBoxProperties.TabIndex = 2
        Me.groupBoxProperties.TabStop = False
        Me.groupBoxProperties.Text = "Events from KryptonNavigator"
        Me.listBoxEvents.Dock = System.Windows.Forms.DockStyle.Fill
        Me.listBoxEvents.Font = New System.Drawing.Font("Courier New", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.listBoxEvents.FormattingEnabled = True
        Me.listBoxEvents.ItemHeight = 17
        Me.listBoxEvents.Location = New System.Drawing.Point(5, 22)
        Me.listBoxEvents.Name = "listBoxEvents"
        Me.listBoxEvents.Size = New System.Drawing.Size(315, 437)
        Me.listBoxEvents.TabIndex = 0
        Me.buttonClose.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.buttonClose.Location = New System.Drawing.Point(578, 481)
        Me.buttonClose.Name = "buttonClose"
        Me.buttonClose.Size = New System.Drawing.Size(75, 27)
        Me.buttonClose.TabIndex = 4
        Me.buttonClose.Text = "Close"
        Me.buttonClose.UseVisualStyleBackColor = True
        Me.buttonClearEventList.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.buttonClearEventList.Location = New System.Drawing.Point(333, 481)
        Me.buttonClearEventList.Name = "buttonClearEventList"
        Me.buttonClearEventList.Size = New System.Drawing.Size(145, 27)
        Me.buttonClearEventList.TabIndex = 3
        Me.buttonClearEventList.Text = "Clear Event List"
        Me.buttonClearEventList.UseVisualStyleBackColor = True
        Me.kryptonManager1.GlobalPaletteMode = Krypton.Toolkit.PaletteMode.Office2010Blue
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8F, 17F)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(665, 516)
        Me.Controls.Add(Me.buttonClearEventList)
        Me.Controls.Add(Me.buttonClose)
        Me.Controls.Add(Me.groupBoxProperties)
        Me.Controls.Add(Me.groupBoxPages)
        Me.Controls.Add(Me.kryptonNavigator1)
        Me.Font = New System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.MaximizeBox = False
        Me.MinimizeBox = False
        Me.MinimumSize = New System.Drawing.Size(530, 326)
        Me.Name = "Form1"
        Me.Text = "Basic Events"
        CType(Me.kryptonNavigator1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.kryptonNavigator1.ResumeLayout(False)
        CType(Me.kryptonPage1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.kryptonPage2, System.ComponentModel.ISupportInitialize).EndInit()
        Me.groupBoxPages.ResumeLayout(False)
        Me.groupBoxProperties.ResumeLayout(False)
        Me.ResumeLayout(False)
    End Sub

    Friend WithEvents imageList1 As System.Windows.Forms.ImageList
    Friend WithEvents kryptonNavigator1 As Krypton.Navigator.KryptonNavigator
    Friend WithEvents groupBoxPages As System.Windows.Forms.GroupBox
    Friend WithEvents kryptonButtonClear As Krypton.Toolkit.KryptonButton
    Friend WithEvents kryptonButtonRemove As Krypton.Toolkit.KryptonButton
    Friend WithEvents kryptonButtonAdd As Krypton.Toolkit.KryptonButton
    Friend WithEvents groupBoxProperties As System.Windows.Forms.GroupBox
    Friend WithEvents buttonClose As System.Windows.Forms.Button
    Friend WithEvents kryptonPage1 As Krypton.Navigator.KryptonPage
    Friend WithEvents kryptonPage2 As Krypton.Navigator.KryptonPage
    Friend WithEvents listBoxEvents As System.Windows.Forms.ListBox
    Friend WithEvents buttonClearEventList As System.Windows.Forms.Button
    Friend WithEvents kryptonButtonEnable As Krypton.Toolkit.KryptonButton
    Friend WithEvents kryptonManager1 As Krypton.Toolkit.KryptonManager
End Class
