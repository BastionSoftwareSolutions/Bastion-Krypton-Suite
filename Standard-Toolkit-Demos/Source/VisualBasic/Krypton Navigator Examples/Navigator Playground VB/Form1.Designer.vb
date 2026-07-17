' VB.NET twin of Source\Krypton Navigator Examples\Navigator Playground\Form1.Designer.cs (Bastion Phase 4c).
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
        Me.kryptonPage1 = New Krypton.Navigator.KryptonPage()
        Me.kryptonPage2 = New Krypton.Navigator.KryptonPage()
        Me.groupBoxProperties = New System.Windows.Forms.GroupBox()
        Me.propertyGrid1 = New System.Windows.Forms.PropertyGrid()
        Me.buttonClose = New System.Windows.Forms.Button()
        Me.groupBoxPages = New System.Windows.Forms.GroupBox()
        Me.kryptonButtonEnable = New Krypton.Toolkit.KryptonButton()
        Me.kryptonButtonClear = New Krypton.Toolkit.KryptonButton()
        Me.kryptonButtonRemove = New Krypton.Toolkit.KryptonButton()
        Me.kryptonButtonAdd = New Krypton.Toolkit.KryptonButton()
        Me.imageList1 = New System.Windows.Forms.ImageList(Me.components)
        Me.kryptonManager1 = New Krypton.Toolkit.KryptonManager(Me.components)
        CType(Me.kryptonNavigator1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.kryptonNavigator1.SuspendLayout()
        CType(Me.kryptonPage1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.kryptonPage2, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.groupBoxProperties.SuspendLayout()
        Me.groupBoxPages.SuspendLayout()
        Me.SuspendLayout()
        Me.kryptonNavigator1.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) Or System.Windows.Forms.AnchorStyles.Left), System.Windows.Forms.AnchorStyles)
        Me.kryptonNavigator1.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowOnly
        Me.kryptonNavigator1.Button.ButtonDisplayLogic = Krypton.Navigator.ButtonDisplayLogic.Context
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
        Me.kryptonNavigator1.Group.GroupBackStyle = Krypton.Toolkit.PaletteBackStyle.ControlClient
        Me.kryptonNavigator1.Group.GroupBorderStyle = Krypton.Toolkit.PaletteBorderStyle.ControlClient
        Me.kryptonNavigator1.Header.HeaderPositionBar = Krypton.Toolkit.VisualOrientation.Top
        Me.kryptonNavigator1.Header.HeaderPositionPrimary = Krypton.Toolkit.VisualOrientation.Top
        Me.kryptonNavigator1.Header.HeaderPositionSecondary = Krypton.Toolkit.VisualOrientation.Bottom
        Me.kryptonNavigator1.Header.HeaderStyleBar = Krypton.Toolkit.HeaderStyle.Secondary
        Me.kryptonNavigator1.Header.HeaderStylePrimary = Krypton.Toolkit.HeaderStyle.Primary
        Me.kryptonNavigator1.Header.HeaderStyleSecondary = Krypton.Toolkit.HeaderStyle.Secondary
        Me.kryptonNavigator1.Location = New System.Drawing.Point(18, 31)
        Me.kryptonNavigator1.Name = "kryptonNavigator1"
        Me.kryptonNavigator1.NavigatorMode = Krypton.Navigator.NavigatorMode.BarTabGroup
        Me.kryptonNavigator1.PageBackStyle = Krypton.Toolkit.PaletteBackStyle.ControlClient
        Me.kryptonNavigator1.Pages.AddRange(New Krypton.Navigator.KryptonPage() { Me.kryptonPage1, Me.kryptonPage2})
        Me.kryptonNavigator1.Panel.PanelBackStyle = Krypton.Toolkit.PaletteBackStyle.PanelClient
        Me.kryptonNavigator1.SelectedIndex = 0
        Me.kryptonNavigator1.Size = New System.Drawing.Size(297, 355)
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
        Me.kryptonPage1.Size = New System.Drawing.Size(295, 329)
        Me.kryptonPage1.Text = "Page 1"
        Me.kryptonPage1.TextDescription = "Page 1 Description"
        Me.kryptonPage1.TextTitle = "Page 1 Title"
        Me.kryptonPage1.ToolTipTitle = "Page ToolTip"
        Me.kryptonPage1.UniqueName = "DA289FB3CA334928DA289FB3CA334928"
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
        Me.kryptonPage2.UniqueName = "FAFF770F50A44D94FAFF770F50A44D94"
        Me.groupBoxProperties.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) Or System.Windows.Forms.AnchorStyles.Left) Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.groupBoxProperties.Controls.Add(Me.propertyGrid1)
        Me.groupBoxProperties.Location = New System.Drawing.Point(328, 12)
        Me.groupBoxProperties.Name = "groupBoxProperties"
        Me.groupBoxProperties.Padding = New System.Windows.Forms.Padding(5)
        Me.groupBoxProperties.Size = New System.Drawing.Size(312, 464)
        Me.groupBoxProperties.TabIndex = 2
        Me.groupBoxProperties.TabStop = False
        Me.groupBoxProperties.Text = "Properties for KryptonNavigator"
        Me.propertyGrid1.Dock = System.Windows.Forms.DockStyle.Fill
        Me.propertyGrid1.Location = New System.Drawing.Point(5, 19)
        Me.propertyGrid1.Name = "propertyGrid1"
        Me.propertyGrid1.Size = New System.Drawing.Size(302, 440)
        Me.propertyGrid1.TabIndex = 0
        Me.propertyGrid1.ToolbarVisible = False
        Me.buttonClose.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.buttonClose.Location = New System.Drawing.Point(565, 485)
        Me.buttonClose.Name = "buttonClose"
        Me.buttonClose.Size = New System.Drawing.Size(75, 23)
        Me.buttonClose.TabIndex = 3
        Me.buttonClose.Text = "Close"
        Me.buttonClose.UseVisualStyleBackColor = True
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
        Me.kryptonButtonEnable.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowOnly
        Me.kryptonButtonEnable.DialogResult = System.Windows.Forms.DialogResult.None
        Me.kryptonButtonEnable.Location = New System.Drawing.Point(234, 26)
        Me.kryptonButtonEnable.Name = "kryptonButtonEnable"
        Me.kryptonButtonEnable.Orientation = Krypton.Toolkit.VisualOrientation.Top
        Me.kryptonButtonEnable.Size = New System.Drawing.Size(65, 29)
        Me.kryptonButtonEnable.TabIndex = 3
        Me.kryptonButtonEnable.Values.Text = "Enable"
        Me.kryptonButtonClear.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowOnly
        Me.kryptonButtonClear.DialogResult = System.Windows.Forms.DialogResult.None
        Me.kryptonButtonClear.Location = New System.Drawing.Point(159, 26)
        Me.kryptonButtonClear.Name = "kryptonButtonClear"
        Me.kryptonButtonClear.Orientation = Krypton.Toolkit.VisualOrientation.Top
        Me.kryptonButtonClear.Size = New System.Drawing.Size(65, 29)
        Me.kryptonButtonClear.TabIndex = 2
        Me.kryptonButtonClear.Values.Text = "Clear"
        Me.kryptonButtonRemove.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowOnly
        Me.kryptonButtonRemove.DialogResult = System.Windows.Forms.DialogResult.None
        Me.kryptonButtonRemove.Location = New System.Drawing.Point(84, 26)
        Me.kryptonButtonRemove.Name = "kryptonButtonRemove"
        Me.kryptonButtonRemove.Orientation = Krypton.Toolkit.VisualOrientation.Top
        Me.kryptonButtonRemove.Size = New System.Drawing.Size(65, 29)
        Me.kryptonButtonRemove.TabIndex = 1
        Me.kryptonButtonRemove.Values.Text = "Remove"
        Me.kryptonButtonAdd.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowOnly
        Me.kryptonButtonAdd.DialogResult = System.Windows.Forms.DialogResult.None
        Me.kryptonButtonAdd.Location = New System.Drawing.Point(9, 26)
        Me.kryptonButtonAdd.Name = "kryptonButtonAdd"
        Me.kryptonButtonAdd.Orientation = Krypton.Toolkit.VisualOrientation.Top
        Me.kryptonButtonAdd.Size = New System.Drawing.Size(65, 29)
        Me.kryptonButtonAdd.TabIndex = 0
        Me.kryptonButtonAdd.Values.Text = "Add"
        Me.imageList1.ImageStream = CType(resources.GetObject("imageList1.ImageStream"), System.Windows.Forms.ImageListStreamer)
        Me.imageList1.TransparentColor = System.Drawing.Color.Transparent
        Me.imageList1.Images.SetKeyName(0, "airmail_closed.png")
        Me.imageList1.Images.SetKeyName(1, "brickwall.png")
        Me.imageList1.Images.SetKeyName(2, "calculator.png")
        Me.imageList1.Images.SetKeyName(3, "clients.png")
        Me.imageList1.Images.SetKeyName(4, "fire.png")
        Me.imageList1.Images.SetKeyName(5, "newspaper.png")
        Me.imageList1.Images.SetKeyName(6, "robber.png")
        Me.imageList1.Images.SetKeyName(7, "virus.png")
        Me.imageList1.Images.SetKeyName(8, "web.png")
        Me.imageList1.Images.SetKeyName(9, "worm.png")
        Me.kryptonManager1.GlobalPaletteMode = Krypton.Toolkit.PaletteMode.SparkleBlue
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6F, 13F)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(652, 516)
        Me.Controls.Add(Me.groupBoxPages)
        Me.Controls.Add(Me.buttonClose)
        Me.Controls.Add(Me.groupBoxProperties)
        Me.Controls.Add(Me.kryptonNavigator1)
        Me.Font = New System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.MaximizeBox = False
        Me.MinimizeBox = False
        Me.MinimumSize = New System.Drawing.Size(530, 326)
        Me.Name = "Form1"
        Me.Text = "Navigator Playground"
        CType(Me.kryptonNavigator1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.kryptonNavigator1.ResumeLayout(False)
        CType(Me.kryptonPage1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.kryptonPage2, System.ComponentModel.ISupportInitialize).EndInit()
        Me.groupBoxProperties.ResumeLayout(False)
        Me.groupBoxPages.ResumeLayout(False)
        Me.ResumeLayout(False)
    End Sub

    Friend WithEvents kryptonNavigator1 As Krypton.Navigator.KryptonNavigator
    Friend WithEvents kryptonPage1 As Krypton.Navigator.KryptonPage
    Friend WithEvents kryptonPage2 As Krypton.Navigator.KryptonPage
    Friend WithEvents groupBoxProperties As System.Windows.Forms.GroupBox
    Friend WithEvents propertyGrid1 As System.Windows.Forms.PropertyGrid
    Friend WithEvents buttonClose As System.Windows.Forms.Button
    Friend WithEvents groupBoxPages As System.Windows.Forms.GroupBox
    Friend WithEvents kryptonButtonClear As Krypton.Toolkit.KryptonButton
    Friend WithEvents kryptonButtonRemove As Krypton.Toolkit.KryptonButton
    Friend WithEvents kryptonButtonAdd As Krypton.Toolkit.KryptonButton
    Friend WithEvents imageList1 As System.Windows.Forms.ImageList
    Friend WithEvents kryptonButtonEnable As Krypton.Toolkit.KryptonButton
    Friend WithEvents kryptonManager1 As Krypton.Toolkit.KryptonManager
End Class
