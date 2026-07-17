' VB.NET twin of Source\Krypton Navigator Examples\Navigator ToolTips\Form1.Designer.cs (Bastion Phase 4c).
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
        Me.groupBoxTooltipProperties = New System.Windows.Forms.GroupBox()
        Me.checkAllowButtonSpecTooltips = New System.Windows.Forms.CheckBox()
        Me.checkAllowPageTooltips = New System.Windows.Forms.CheckBox()
        Me.comboMapImage = New System.Windows.Forms.ComboBox()
        Me.comboMapExtraText = New System.Windows.Forms.ComboBox()
        Me.comboMapText = New System.Windows.Forms.ComboBox()
        Me.labelMapImage = New System.Windows.Forms.Label()
        Me.labelMapExtraText = New System.Windows.Forms.Label()
        Me.labelMapText = New System.Windows.Forms.Label()
        Me.panel = New System.Windows.Forms.Panel()
        Me.kryptonNavigator = New Krypton.Navigator.KryptonNavigator()
        Me.kryptonPage1 = New Krypton.Navigator.KryptonPage()
        Me.kryptonPage2 = New Krypton.Navigator.KryptonPage()
        Me.kryptonPage3 = New Krypton.Navigator.KryptonPage()
        Me.kryptonPage4 = New Krypton.Navigator.KryptonPage()
        Me.buttonClose = New System.Windows.Forms.Button()
        Me.kryptonManager1 = New Krypton.Toolkit.KryptonManager(Me.components)
        Me.groupBoxTooltipProperties.SuspendLayout()
        Me.panel.SuspendLayout()
        CType(Me.kryptonNavigator, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.kryptonNavigator.SuspendLayout()
        CType(Me.kryptonPage1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.kryptonPage2, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.kryptonPage3, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.kryptonPage4, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        Me.groupBoxTooltipProperties.Controls.Add(Me.checkAllowButtonSpecTooltips)
        Me.groupBoxTooltipProperties.Controls.Add(Me.checkAllowPageTooltips)
        Me.groupBoxTooltipProperties.Controls.Add(Me.comboMapImage)
        Me.groupBoxTooltipProperties.Controls.Add(Me.comboMapExtraText)
        Me.groupBoxTooltipProperties.Controls.Add(Me.comboMapText)
        Me.groupBoxTooltipProperties.Controls.Add(Me.labelMapImage)
        Me.groupBoxTooltipProperties.Controls.Add(Me.labelMapExtraText)
        Me.groupBoxTooltipProperties.Controls.Add(Me.labelMapText)
        Me.groupBoxTooltipProperties.Location = New System.Drawing.Point(13, 13)
        Me.groupBoxTooltipProperties.Name = "groupBoxTooltipProperties"
        Me.groupBoxTooltipProperties.Size = New System.Drawing.Size(323, 176)
        Me.groupBoxTooltipProperties.TabIndex = 1
        Me.groupBoxTooltipProperties.TabStop = False
        Me.groupBoxTooltipProperties.Text = "ToolTip Properties"
        Me.checkAllowButtonSpecTooltips.AutoSize = True
        Me.checkAllowButtonSpecTooltips.Location = New System.Drawing.Point(102, 49)
        Me.checkAllowButtonSpecTooltips.Name = "checkAllowButtonSpecTooltips"
        Me.checkAllowButtonSpecTooltips.Size = New System.Drawing.Size(154, 17)
        Me.checkAllowButtonSpecTooltips.TabIndex = 1
        Me.checkAllowButtonSpecTooltips.Text = "Allow ButtonSpec ToolTips"
        Me.checkAllowButtonSpecTooltips.UseVisualStyleBackColor = True
        Me.checkAllowPageTooltips.AutoSize = True
        Me.checkAllowPageTooltips.Location = New System.Drawing.Point(102, 25)
        Me.checkAllowPageTooltips.Name = "checkAllowPageTooltips"
        Me.checkAllowPageTooltips.Size = New System.Drawing.Size(123, 17)
        Me.checkAllowPageTooltips.TabIndex = 0
        Me.checkAllowPageTooltips.Text = "Allow Page ToolTips"
        Me.checkAllowPageTooltips.UseVisualStyleBackColor = True
        Me.comboMapImage.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.comboMapImage.FormattingEnabled = True
        Me.comboMapImage.Location = New System.Drawing.Point(102, 140)
        Me.comboMapImage.Name = "comboMapImage"
        Me.comboMapImage.Size = New System.Drawing.Size(198, 21)
        Me.comboMapImage.TabIndex = 4
        Me.comboMapExtraText.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.comboMapExtraText.FormattingEnabled = True
        Me.comboMapExtraText.Location = New System.Drawing.Point(102, 113)
        Me.comboMapExtraText.Name = "comboMapExtraText"
        Me.comboMapExtraText.Size = New System.Drawing.Size(198, 21)
        Me.comboMapExtraText.TabIndex = 3
        Me.comboMapText.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.comboMapText.FormattingEnabled = True
        Me.comboMapText.Location = New System.Drawing.Point(102, 86)
        Me.comboMapText.Name = "comboMapText"
        Me.comboMapText.Size = New System.Drawing.Size(198, 21)
        Me.comboMapText.TabIndex = 2
        Me.labelMapImage.AutoSize = True
        Me.labelMapImage.Location = New System.Drawing.Point(35, 143)
        Me.labelMapImage.Name = "labelMapImage"
        Me.labelMapImage.Size = New System.Drawing.Size(60, 13)
        Me.labelMapImage.TabIndex = 8
        Me.labelMapImage.Text = "Map Image"
        Me.labelMapExtraText.AutoSize = True
        Me.labelMapExtraText.Location = New System.Drawing.Point(16, 116)
        Me.labelMapExtraText.Name = "labelMapExtraText"
        Me.labelMapExtraText.Size = New System.Drawing.Size(79, 13)
        Me.labelMapExtraText.TabIndex = 7
        Me.labelMapExtraText.Text = "Map Extra Text"
        Me.labelMapText.AutoSize = True
        Me.labelMapText.Location = New System.Drawing.Point(43, 89)
        Me.labelMapText.Name = "labelMapText"
        Me.labelMapText.Size = New System.Drawing.Size(52, 13)
        Me.labelMapText.TabIndex = 6
        Me.labelMapText.Text = "Map Text"
        Me.panel.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) Or System.Windows.Forms.AnchorStyles.Left) Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.panel.Controls.Add(Me.kryptonNavigator)
        Me.panel.Location = New System.Drawing.Point(351, 18)
        Me.panel.Name = "panel"
        Me.panel.Size = New System.Drawing.Size(313, 171)
        Me.panel.TabIndex = 1
        Me.kryptonNavigator.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowOnly
        Me.kryptonNavigator.Button.ButtonDisplayLogic = Krypton.Navigator.ButtonDisplayLogic.Context
        Me.kryptonNavigator.Button.CloseButtonAction = Krypton.Navigator.CloseButtonAction.RemovePageAndDispose
        Me.kryptonNavigator.Button.CloseButtonDisplay = Krypton.Navigator.ButtonDisplay.Logic
        Me.kryptonNavigator.Button.ContextButtonAction = Krypton.Navigator.ContextButtonAction.SelectPage
        Me.kryptonNavigator.Button.ContextButtonDisplay = Krypton.Navigator.ButtonDisplay.Logic
        Me.kryptonNavigator.Button.ContextMenuMapImage = Krypton.Navigator.MapKryptonPageImage.Small
        Me.kryptonNavigator.Button.ContextMenuMapText = Krypton.Navigator.MapKryptonPageText.TextTitle
        Me.kryptonNavigator.Button.NextButtonAction = Krypton.Navigator.DirectionButtonAction.ModeAppropriateAction
        Me.kryptonNavigator.Button.NextButtonDisplay = Krypton.Navigator.ButtonDisplay.Logic
        Me.kryptonNavigator.Button.PreviousButtonAction = Krypton.Navigator.DirectionButtonAction.ModeAppropriateAction
        Me.kryptonNavigator.Button.PreviousButtonDisplay = Krypton.Navigator.ButtonDisplay.Logic
        Me.kryptonNavigator.Dock = System.Windows.Forms.DockStyle.Fill
        Me.kryptonNavigator.Group.GroupBackStyle = Krypton.Toolkit.PaletteBackStyle.ControlClient
        Me.kryptonNavigator.Group.GroupBorderStyle = Krypton.Toolkit.PaletteBorderStyle.ControlClient
        Me.kryptonNavigator.Header.HeaderPositionBar = Krypton.Toolkit.VisualOrientation.Top
        Me.kryptonNavigator.Header.HeaderPositionPrimary = Krypton.Toolkit.VisualOrientation.Top
        Me.kryptonNavigator.Header.HeaderPositionSecondary = Krypton.Toolkit.VisualOrientation.Bottom
        Me.kryptonNavigator.Header.HeaderStyleBar = Krypton.Toolkit.HeaderStyle.Secondary
        Me.kryptonNavigator.Header.HeaderStylePrimary = Krypton.Toolkit.HeaderStyle.Primary
        Me.kryptonNavigator.Header.HeaderStyleSecondary = Krypton.Toolkit.HeaderStyle.Secondary
        Me.kryptonNavigator.Location = New System.Drawing.Point(0, 0)
        Me.kryptonNavigator.Name = "kryptonNavigator"
        Me.kryptonNavigator.NavigatorMode = Krypton.Navigator.NavigatorMode.BarTabGroup
        Me.kryptonNavigator.PageBackStyle = Krypton.Toolkit.PaletteBackStyle.ControlClient
        Me.kryptonNavigator.Pages.AddRange(New Krypton.Navigator.KryptonPage() { Me.kryptonPage1, Me.kryptonPage2, Me.kryptonPage3, Me.kryptonPage4})
        Me.kryptonNavigator.Panel.PanelBackStyle = Krypton.Toolkit.PaletteBackStyle.PanelClient
        Me.kryptonNavigator.SelectedIndex = 0
        Me.kryptonNavigator.Size = New System.Drawing.Size(313, 171)
        Me.kryptonNavigator.TabIndex = 0
        Me.kryptonNavigator.Text = "kryptonNavigator1"
        Me.kryptonNavigator.ToolTips.AllowButtonSpecToolTips = True
        Me.kryptonNavigator.ToolTips.AllowPageToolTips = True
        Me.kryptonPage1.AutoHiddenSlideSize = New System.Drawing.Size(200, 200)
        Me.kryptonPage1.Flags = 65534
        Me.kryptonPage1.ImageLarge = CType(resources.GetObject("kryptonPage1.ImageLarge"), System.Drawing.Bitmap)
        Me.kryptonPage1.ImageMedium = CType(resources.GetObject("kryptonPage1.ImageMedium"), System.Drawing.Bitmap)
        Me.kryptonPage1.ImageSmall = CType(resources.GetObject("kryptonPage1.ImageSmall"), System.Drawing.Bitmap)
        Me.kryptonPage1.LastVisibleSet = True
        Me.kryptonPage1.MinimumSize = New System.Drawing.Size(50, 50)
        Me.kryptonPage1.Name = "kryptonPage1"
        Me.kryptonPage1.Size = New System.Drawing.Size(311, 144)
        Me.kryptonPage1.Text = "Page 1"
        Me.kryptonPage1.TextDescription = "Description of page 1"
        Me.kryptonPage1.TextTitle = "Page Title 1"
        Me.kryptonPage1.ToolTipBody = "This is a long description of " & vbCrLf & "page 1 which covers several" & vbCrLf & "lines of text."
        Me.kryptonPage1.ToolTipImage = CType(resources.GetObject("kryptonPage1.ToolTipImage"), System.Drawing.Bitmap)
        Me.kryptonPage1.ToolTipStyle = Krypton.Toolkit.LabelStyle.SuperTip
        Me.kryptonPage1.ToolTipTitle = "Page 1 SuperTip"
        Me.kryptonPage1.UniqueName = "A2A9C435C1E1424FA2A9C435C1E1424F"
        Me.kryptonPage2.AutoHiddenSlideSize = New System.Drawing.Size(200, 200)
        Me.kryptonPage2.Flags = 65534
        Me.kryptonPage2.ImageLarge = CType(resources.GetObject("kryptonPage2.ImageLarge"), System.Drawing.Bitmap)
        Me.kryptonPage2.ImageMedium = CType(resources.GetObject("kryptonPage2.ImageMedium"), System.Drawing.Bitmap)
        Me.kryptonPage2.ImageSmall = CType(resources.GetObject("kryptonPage2.ImageSmall"), System.Drawing.Bitmap)
        Me.kryptonPage2.LastVisibleSet = True
        Me.kryptonPage2.MinimumSize = New System.Drawing.Size(50, 50)
        Me.kryptonPage2.Name = "kryptonPage2"
        Me.kryptonPage2.Size = New System.Drawing.Size(304, 145)
        Me.kryptonPage2.Text = "Page 2"
        Me.kryptonPage2.TextDescription = "A description of page 2"
        Me.kryptonPage2.TextTitle = "Page Title 2"
        Me.kryptonPage2.ToolTipBody = "Information about the second page" & vbCrLf & "also covers more than a single line" & vbCrLf & "of text."
        Me.kryptonPage2.ToolTipImage = CType(resources.GetObject("kryptonPage2.ToolTipImage"), System.Drawing.Bitmap)
        Me.kryptonPage2.ToolTipStyle = Krypton.Toolkit.LabelStyle.SuperTip
        Me.kryptonPage2.ToolTipTitle = "Page 2 SuperTip"
        Me.kryptonPage2.UniqueName = "9A45A535BEE6487F9A45A535BEE6487F"
        Me.kryptonPage3.AutoHiddenSlideSize = New System.Drawing.Size(200, 200)
        Me.kryptonPage3.Flags = 65534
        Me.kryptonPage3.ImageLarge = CType(resources.GetObject("kryptonPage3.ImageLarge"), System.Drawing.Bitmap)
        Me.kryptonPage3.ImageMedium = CType(resources.GetObject("kryptonPage3.ImageMedium"), System.Drawing.Bitmap)
        Me.kryptonPage3.ImageSmall = CType(resources.GetObject("kryptonPage3.ImageSmall"), System.Drawing.Bitmap)
        Me.kryptonPage3.LastVisibleSet = True
        Me.kryptonPage3.MinimumSize = New System.Drawing.Size(50, 50)
        Me.kryptonPage3.Name = "kryptonPage3"
        Me.kryptonPage3.Size = New System.Drawing.Size(304, 145)
        Me.kryptonPage3.Text = "Page 3"
        Me.kryptonPage3.TextDescription = "The description of page 3"
        Me.kryptonPage3.TextTitle = "Page Title 3"
        Me.kryptonPage3.ToolTipTitle = "Detailed information of page 3 in a tooltip"
        Me.kryptonPage3.UniqueName = "46E548699395412546E5486993954125"
        Me.kryptonPage4.AutoHiddenSlideSize = New System.Drawing.Size(200, 200)
        Me.kryptonPage4.Flags = 65534
        Me.kryptonPage4.ImageLarge = CType(resources.GetObject("kryptonPage4.ImageLarge"), System.Drawing.Bitmap)
        Me.kryptonPage4.ImageMedium = CType(resources.GetObject("kryptonPage4.ImageMedium"), System.Drawing.Bitmap)
        Me.kryptonPage4.ImageSmall = CType(resources.GetObject("kryptonPage4.ImageSmall"), System.Drawing.Bitmap)
        Me.kryptonPage4.LastVisibleSet = True
        Me.kryptonPage4.MinimumSize = New System.Drawing.Size(50, 50)
        Me.kryptonPage4.Name = "kryptonPage4"
        Me.kryptonPage4.Size = New System.Drawing.Size(311, 145)
        Me.kryptonPage4.Text = "Page 4"
        Me.kryptonPage4.TextDescription = "Brief description of page 4"
        Me.kryptonPage4.TextTitle = "Page Title 4"
        Me.kryptonPage4.ToolTipTitle = "Explanation of what page 4 is all about"
        Me.kryptonPage4.UniqueName = "483D78EBE8814B82483D78EBE8814B82"
        Me.buttonClose.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.buttonClose.Location = New System.Drawing.Point(588, 199)
        Me.buttonClose.Name = "buttonClose"
        Me.buttonClose.Size = New System.Drawing.Size(75, 23)
        Me.buttonClose.TabIndex = 2
        Me.buttonClose.Text = "Close"
        Me.buttonClose.UseVisualStyleBackColor = True
        Me.kryptonManager1.GlobalPaletteMode = Krypton.Toolkit.PaletteMode.ProfessionalSystem
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6F, 13F)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(672, 234)
        Me.Controls.Add(Me.buttonClose)
        Me.Controls.Add(Me.panel)
        Me.Controls.Add(Me.groupBoxTooltipProperties)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.MinimumSize = New System.Drawing.Size(643, 260)
        Me.Name = "Form1"
        Me.Text = "Navigator ToolTips"
        Me.groupBoxTooltipProperties.ResumeLayout(False)
        Me.groupBoxTooltipProperties.PerformLayout()
        Me.panel.ResumeLayout(False)
        CType(Me.kryptonNavigator, System.ComponentModel.ISupportInitialize).EndInit()
        Me.kryptonNavigator.ResumeLayout(False)
        CType(Me.kryptonPage1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.kryptonPage2, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.kryptonPage3, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.kryptonPage4, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
    End Sub

    Friend WithEvents panel As System.Windows.Forms.Panel
    Friend WithEvents kryptonNavigator As Krypton.Navigator.KryptonNavigator
    Friend WithEvents kryptonPage1 As Krypton.Navigator.KryptonPage
    Friend WithEvents kryptonPage2 As Krypton.Navigator.KryptonPage
    Friend WithEvents kryptonPage3 As Krypton.Navigator.KryptonPage
    Friend WithEvents kryptonPage4 As Krypton.Navigator.KryptonPage
    Friend WithEvents groupBoxTooltipProperties As System.Windows.Forms.GroupBox
    Friend WithEvents labelMapText As System.Windows.Forms.Label
    Friend WithEvents labelMapExtraText As System.Windows.Forms.Label
    Friend WithEvents labelMapImage As System.Windows.Forms.Label
    Friend WithEvents comboMapImage As System.Windows.Forms.ComboBox
    Friend WithEvents comboMapExtraText As System.Windows.Forms.ComboBox
    Friend WithEvents comboMapText As System.Windows.Forms.ComboBox
    Friend WithEvents buttonClose As System.Windows.Forms.Button
    Friend WithEvents checkAllowButtonSpecTooltips As System.Windows.Forms.CheckBox
    Friend WithEvents checkAllowPageTooltips As System.Windows.Forms.CheckBox
    Friend WithEvents kryptonManager1 As Krypton.Toolkit.KryptonManager
End Class
