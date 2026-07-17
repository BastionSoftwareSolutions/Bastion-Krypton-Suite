' VB.NET twin of Source\Krypton Navigator Examples\Tab Border Styles\Form1.Designer.cs (Bastion Phase 4c).
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
        Me.groupBoxTabBorderStyles = New System.Windows.Forms.GroupBox()
        Me.radioSO = New System.Windows.Forms.RadioButton()
        Me.radioSE = New System.Windows.Forms.RadioButton()
        Me.radioON = New System.Windows.Forms.RadioButton()
        Me.radioSOB = New System.Windows.Forms.RadioButton()
        Me.radioSOF = New System.Windows.Forms.RadioButton()
        Me.radioSON = New System.Windows.Forms.RadioButton()
        Me.radioSEB = New System.Windows.Forms.RadioButton()
        Me.radioSEF = New System.Windows.Forms.RadioButton()
        Me.radioSEN = New System.Windows.Forms.RadioButton()
        Me.radioROL = New System.Windows.Forms.RadioButton()
        Me.radioROM = New System.Windows.Forms.RadioButton()
        Me.radioROS = New System.Windows.Forms.RadioButton()
        Me.radioREL = New System.Windows.Forms.RadioButton()
        Me.radioREM = New System.Windows.Forms.RadioButton()
        Me.radioRES = New System.Windows.Forms.RadioButton()
        Me.radioSOL = New System.Windows.Forms.RadioButton()
        Me.radioSOM = New System.Windows.Forms.RadioButton()
        Me.radioSOS = New System.Windows.Forms.RadioButton()
        Me.radioSEL = New System.Windows.Forms.RadioButton()
        Me.radioSEM = New System.Windows.Forms.RadioButton()
        Me.radioSES = New System.Windows.Forms.RadioButton()
        Me.kryptonNavigator = New Krypton.Navigator.KryptonNavigator()
        Me.kryptonPage1 = New Krypton.Navigator.KryptonPage()
        Me.kryptonPage2 = New Krypton.Navigator.KryptonPage()
        Me.kryptonPage3 = New Krypton.Navigator.KryptonPage()
        Me.kryptonPage4 = New Krypton.Navigator.KryptonPage()
        Me.kryptonPage5 = New Krypton.Navigator.KryptonPage()
        Me.kryptonPage6 = New Krypton.Navigator.KryptonPage()
        Me.buttonClose = New System.Windows.Forms.Button()
        Me.groupBoxTabStyles = New System.Windows.Forms.GroupBox()
        Me.radioOneNote = New System.Windows.Forms.RadioButton()
        Me.radioLP = New System.Windows.Forms.RadioButton()
        Me.radioSP = New System.Windows.Forms.RadioButton()
        Me.radioHP = New System.Windows.Forms.RadioButton()
        Me.kryptonManager1 = New Krypton.Toolkit.KryptonManager(Me.components)
        Me.groupBoxTabBorderStyles.SuspendLayout()
        CType(Me.kryptonNavigator, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.kryptonNavigator.SuspendLayout()
        CType(Me.kryptonPage1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.kryptonPage2, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.kryptonPage3, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.kryptonPage4, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.kryptonPage5, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.kryptonPage6, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.groupBoxTabStyles.SuspendLayout()
        Me.SuspendLayout()
        Me.groupBoxTabBorderStyles.Controls.Add(Me.radioSO)
        Me.groupBoxTabBorderStyles.Controls.Add(Me.radioSE)
        Me.groupBoxTabBorderStyles.Controls.Add(Me.radioON)
        Me.groupBoxTabBorderStyles.Controls.Add(Me.radioSOB)
        Me.groupBoxTabBorderStyles.Controls.Add(Me.radioSOF)
        Me.groupBoxTabBorderStyles.Controls.Add(Me.radioSON)
        Me.groupBoxTabBorderStyles.Controls.Add(Me.radioSEB)
        Me.groupBoxTabBorderStyles.Controls.Add(Me.radioSEF)
        Me.groupBoxTabBorderStyles.Controls.Add(Me.radioSEN)
        Me.groupBoxTabBorderStyles.Controls.Add(Me.radioROL)
        Me.groupBoxTabBorderStyles.Controls.Add(Me.radioROM)
        Me.groupBoxTabBorderStyles.Controls.Add(Me.radioROS)
        Me.groupBoxTabBorderStyles.Controls.Add(Me.radioREL)
        Me.groupBoxTabBorderStyles.Controls.Add(Me.radioREM)
        Me.groupBoxTabBorderStyles.Controls.Add(Me.radioRES)
        Me.groupBoxTabBorderStyles.Controls.Add(Me.radioSOL)
        Me.groupBoxTabBorderStyles.Controls.Add(Me.radioSOM)
        Me.groupBoxTabBorderStyles.Controls.Add(Me.radioSOS)
        Me.groupBoxTabBorderStyles.Controls.Add(Me.radioSEL)
        Me.groupBoxTabBorderStyles.Controls.Add(Me.radioSEM)
        Me.groupBoxTabBorderStyles.Controls.Add(Me.radioSES)
        Me.groupBoxTabBorderStyles.Location = New System.Drawing.Point(12, 12)
        Me.groupBoxTabBorderStyles.Name = "groupBoxTabBorderStyles"
        Me.groupBoxTabBorderStyles.Size = New System.Drawing.Size(596, 181)
        Me.groupBoxTabBorderStyles.TabIndex = 0
        Me.groupBoxTabBorderStyles.TabStop = False
        Me.groupBoxTabBorderStyles.Text = "Tab Border Styles"
        Me.radioSO.AutoSize = True
        Me.radioSO.Location = New System.Drawing.Point(485, 46)
        Me.radioSO.Name = "radioSO"
        Me.radioSO.Size = New System.Drawing.Size(100, 17)
        Me.radioSO.TabIndex = 19
        Me.radioSO.Tag = "SmoothOutsize"
        Me.radioSO.Text = "Smooth Outsize"
        Me.radioSO.UseVisualStyleBackColor = True
        Me.radioSE.AutoSize = True
        Me.radioSE.Location = New System.Drawing.Point(485, 23)
        Me.radioSE.Name = "radioSE"
        Me.radioSE.Size = New System.Drawing.Size(90, 17)
        Me.radioSE.TabIndex = 18
        Me.radioSE.Tag = "SmoothEqual"
        Me.radioSE.Text = "Smooth Equal"
        Me.radioSE.UseVisualStyleBackColor = True
        Me.radioON.AutoSize = True
        Me.radioON.Location = New System.Drawing.Point(485, 104)
        Me.radioON.Name = "radioON"
        Me.radioON.Size = New System.Drawing.Size(68, 17)
        Me.radioON.TabIndex = 20
        Me.radioON.Tag = "OneNote"
        Me.radioON.Text = "OneNote"
        Me.radioON.UseVisualStyleBackColor = True
        Me.radioSOB.AutoSize = True
        Me.radioSOB.Location = New System.Drawing.Point(340, 150)
        Me.radioSOB.Name = "radioSOB"
        Me.radioSOB.Size = New System.Drawing.Size(113, 17)
        Me.radioSOB.TabIndex = 17
        Me.radioSOB.Tag = "SlantOutsizeBoth"
        Me.radioSOB.Text = "Slant Outsize Both"
        Me.radioSOB.UseVisualStyleBackColor = True
        Me.radioSOF.AutoSize = True
        Me.radioSOF.Location = New System.Drawing.Point(340, 127)
        Me.radioSOF.Name = "radioSOF"
        Me.radioSOF.Size = New System.Drawing.Size(107, 17)
        Me.radioSOF.TabIndex = 16
        Me.radioSOF.Tag = "SlantOutsizeFar"
        Me.radioSOF.Text = "Slant Outsize Far"
        Me.radioSOF.UseVisualStyleBackColor = True
        Me.radioSON.AutoSize = True
        Me.radioSON.Location = New System.Drawing.Point(340, 104)
        Me.radioSON.Name = "radioSON"
        Me.radioSON.Size = New System.Drawing.Size(114, 17)
        Me.radioSON.TabIndex = 15
        Me.radioSON.Tag = "SlantOutsizeNear"
        Me.radioSON.Text = "Slant Outsize Near"
        Me.radioSON.UseVisualStyleBackColor = True
        Me.radioSEB.AutoSize = True
        Me.radioSEB.Location = New System.Drawing.Point(340, 69)
        Me.radioSEB.Name = "radioSEB"
        Me.radioSEB.Size = New System.Drawing.Size(103, 17)
        Me.radioSEB.TabIndex = 14
        Me.radioSEB.Tag = "SlantEqualBoth"
        Me.radioSEB.Text = "Slant Equal Both"
        Me.radioSEB.UseVisualStyleBackColor = True
        Me.radioSEF.AutoSize = True
        Me.radioSEF.Location = New System.Drawing.Point(340, 46)
        Me.radioSEF.Name = "radioSEF"
        Me.radioSEF.Size = New System.Drawing.Size(97, 17)
        Me.radioSEF.TabIndex = 13
        Me.radioSEF.Tag = "SlantEqualFar"
        Me.radioSEF.Text = "Slant Equal Far"
        Me.radioSEF.UseVisualStyleBackColor = True
        Me.radioSEN.AutoSize = True
        Me.radioSEN.Location = New System.Drawing.Point(340, 23)
        Me.radioSEN.Name = "radioSEN"
        Me.radioSEN.Size = New System.Drawing.Size(104, 17)
        Me.radioSEN.TabIndex = 12
        Me.radioSEN.Tag = "SlantEqualNear"
        Me.radioSEN.Text = "Slant Equal Near"
        Me.radioSEN.UseVisualStyleBackColor = True
        Me.radioROL.AutoSize = True
        Me.radioROL.Location = New System.Drawing.Point(173, 150)
        Me.radioROL.Name = "radioROL"
        Me.radioROL.Size = New System.Drawing.Size(137, 17)
        Me.radioROL.TabIndex = 11
        Me.radioROL.Tag = "RoundedOutsizeLarge"
        Me.radioROL.Text = "Rounded Outsize Large"
        Me.radioROL.UseVisualStyleBackColor = True
        Me.radioROM.AutoSize = True
        Me.radioROM.Checked = True
        Me.radioROM.Location = New System.Drawing.Point(173, 127)
        Me.radioROM.Name = "radioROM"
        Me.radioROM.Size = New System.Drawing.Size(146, 17)
        Me.radioROM.TabIndex = 10
        Me.radioROM.TabStop = True
        Me.radioROM.Tag = "RoundedOutsizeMedium"
        Me.radioROM.Text = "Rounded Outsize Medium"
        Me.radioROM.UseVisualStyleBackColor = True
        Me.radioROS.AutoSize = True
        Me.radioROS.Location = New System.Drawing.Point(173, 104)
        Me.radioROS.Name = "radioROS"
        Me.radioROS.Size = New System.Drawing.Size(134, 17)
        Me.radioROS.TabIndex = 9
        Me.radioROS.Tag = "RoundedOutsizeSmall"
        Me.radioROS.Text = "Rounded Outsize Small"
        Me.radioROS.UseVisualStyleBackColor = True
        Me.radioREL.AutoSize = True
        Me.radioREL.Location = New System.Drawing.Point(173, 69)
        Me.radioREL.Name = "radioREL"
        Me.radioREL.Size = New System.Drawing.Size(127, 17)
        Me.radioREL.TabIndex = 8
        Me.radioREL.Tag = "RoundedEqualLarge"
        Me.radioREL.Text = "Rounded Equal Large"
        Me.radioREL.UseVisualStyleBackColor = True
        Me.radioREM.AutoSize = True
        Me.radioREM.Location = New System.Drawing.Point(173, 46)
        Me.radioREM.Name = "radioREM"
        Me.radioREM.Size = New System.Drawing.Size(136, 17)
        Me.radioREM.TabIndex = 7
        Me.radioREM.Tag = "RoundedEqualMedium"
        Me.radioREM.Text = "Rounded Equal Medium"
        Me.radioREM.UseVisualStyleBackColor = True
        Me.radioRES.AutoSize = True
        Me.radioRES.Location = New System.Drawing.Point(173, 23)
        Me.radioRES.Name = "radioRES"
        Me.radioRES.Size = New System.Drawing.Size(124, 17)
        Me.radioRES.TabIndex = 6
        Me.radioRES.Tag = "RoundedEqualSmall"
        Me.radioRES.Text = "Rounded Equal Small"
        Me.radioRES.UseVisualStyleBackColor = True
        Me.radioSOL.AutoSize = True
        Me.radioSOL.Location = New System.Drawing.Point(16, 150)
        Me.radioSOL.Name = "radioSOL"
        Me.radioSOL.Size = New System.Drawing.Size(128, 17)
        Me.radioSOL.TabIndex = 5
        Me.radioSOL.Tag = "SquareOutsizeLarge"
        Me.radioSOL.Text = "Square Outsize Large"
        Me.radioSOL.UseVisualStyleBackColor = True
        Me.radioSOM.AutoSize = True
        Me.radioSOM.Location = New System.Drawing.Point(16, 127)
        Me.radioSOM.Name = "radioSOM"
        Me.radioSOM.Size = New System.Drawing.Size(137, 17)
        Me.radioSOM.TabIndex = 4
        Me.radioSOM.Tag = "SquareOutsizeMedium"
        Me.radioSOM.Text = "Square Outsize Medium"
        Me.radioSOM.UseVisualStyleBackColor = True
        Me.radioSOS.AutoSize = True
        Me.radioSOS.Location = New System.Drawing.Point(16, 104)
        Me.radioSOS.Name = "radioSOS"
        Me.radioSOS.Size = New System.Drawing.Size(125, 17)
        Me.radioSOS.TabIndex = 3
        Me.radioSOS.Tag = "SquareOutsizeSmall"
        Me.radioSOS.Text = "Square Outsize Small"
        Me.radioSOS.UseVisualStyleBackColor = True
        Me.radioSEL.AutoSize = True
        Me.radioSEL.Location = New System.Drawing.Point(16, 69)
        Me.radioSEL.Name = "radioSEL"
        Me.radioSEL.Size = New System.Drawing.Size(118, 17)
        Me.radioSEL.TabIndex = 2
        Me.radioSEL.Tag = "SquareEqualLarge"
        Me.radioSEL.Text = "Square Equal Large"
        Me.radioSEL.UseVisualStyleBackColor = True
        Me.radioSEM.AutoSize = True
        Me.radioSEM.Location = New System.Drawing.Point(16, 46)
        Me.radioSEM.Name = "radioSEM"
        Me.radioSEM.Size = New System.Drawing.Size(127, 17)
        Me.radioSEM.TabIndex = 1
        Me.radioSEM.Tag = "SquareEqualMedium"
        Me.radioSEM.Text = "Square Equal Medium"
        Me.radioSEM.UseVisualStyleBackColor = True
        Me.radioSES.AutoSize = True
        Me.radioSES.Location = New System.Drawing.Point(16, 23)
        Me.radioSES.Name = "radioSES"
        Me.radioSES.Size = New System.Drawing.Size(115, 17)
        Me.radioSES.TabIndex = 0
        Me.radioSES.Tag = "SquareEqualSmall"
        Me.radioSES.Text = "Square Equal Small"
        Me.radioSES.UseVisualStyleBackColor = True
        Me.kryptonNavigator.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) Or System.Windows.Forms.AnchorStyles.Left) Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.kryptonNavigator.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowOnly
        Me.kryptonNavigator.Button.ButtonDisplayLogic = Krypton.Navigator.ButtonDisplayLogic.None
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
        Me.kryptonNavigator.Location = New System.Drawing.Point(12, 271)
        Me.kryptonNavigator.Name = "kryptonNavigator"
        Me.kryptonNavigator.NavigatorMode = Krypton.Navigator.NavigatorMode.BarTabGroup
        Me.kryptonNavigator.PageBackStyle = Krypton.Toolkit.PaletteBackStyle.ControlClient
        Me.kryptonNavigator.Pages.AddRange(New Krypton.Navigator.KryptonPage() { Me.kryptonPage1, Me.kryptonPage2, Me.kryptonPage3, Me.kryptonPage4, Me.kryptonPage5, Me.kryptonPage6})
        Me.kryptonNavigator.Panel.PanelBackStyle = Krypton.Toolkit.PaletteBackStyle.PanelClient
        Me.kryptonNavigator.SelectedIndex = 0
        Me.kryptonNavigator.Size = New System.Drawing.Size(597, 104)
        Me.kryptonNavigator.TabIndex = 2
        Me.kryptonNavigator.Text = "kryptonNavigator1"
        Me.kryptonPage1.AutoHiddenSlideSize = New System.Drawing.Size(200, 200)
        Me.kryptonPage1.Flags = 65534
        Me.kryptonPage1.ImageLarge = CType(resources.GetObject("kryptonPage1.ImageLarge"), System.Drawing.Bitmap)
        Me.kryptonPage1.ImageMedium = CType(resources.GetObject("kryptonPage1.ImageMedium"), System.Drawing.Bitmap)
        Me.kryptonPage1.ImageSmall = CType(resources.GetObject("kryptonPage1.ImageSmall"), System.Drawing.Bitmap)
        Me.kryptonPage1.LastVisibleSet = True
        Me.kryptonPage1.MinimumSize = New System.Drawing.Size(50, 50)
        Me.kryptonPage1.Name = "kryptonPage1"
        Me.kryptonPage1.Size = New System.Drawing.Size(595, 77)
        Me.kryptonPage1.Text = "Page 1"
        Me.kryptonPage1.ToolTipTitle = "Page ToolTip"
        Me.kryptonPage1.UniqueName = "A605A21768024BACA605A21768024BAC"
        Me.kryptonPage2.AutoHiddenSlideSize = New System.Drawing.Size(200, 200)
        Me.kryptonPage2.Flags = 65534
        Me.kryptonPage2.ImageLarge = CType(resources.GetObject("kryptonPage2.ImageLarge"), System.Drawing.Bitmap)
        Me.kryptonPage2.ImageMedium = CType(resources.GetObject("kryptonPage2.ImageMedium"), System.Drawing.Bitmap)
        Me.kryptonPage2.ImageSmall = CType(resources.GetObject("kryptonPage2.ImageSmall"), System.Drawing.Bitmap)
        Me.kryptonPage2.LastVisibleSet = True
        Me.kryptonPage2.MinimumSize = New System.Drawing.Size(50, 50)
        Me.kryptonPage2.Name = "kryptonPage2"
        Me.kryptonPage2.Size = New System.Drawing.Size(595, 77)
        Me.kryptonPage2.Text = "Page 2"
        Me.kryptonPage2.ToolTipTitle = "Page ToolTip"
        Me.kryptonPage2.UniqueName = "0DD3743DCEDF48C70DD3743DCEDF48C7"
        Me.kryptonPage3.AutoHiddenSlideSize = New System.Drawing.Size(200, 200)
        Me.kryptonPage3.Flags = 65534
        Me.kryptonPage3.ImageLarge = CType(resources.GetObject("kryptonPage3.ImageLarge"), System.Drawing.Bitmap)
        Me.kryptonPage3.ImageMedium = CType(resources.GetObject("kryptonPage3.ImageMedium"), System.Drawing.Bitmap)
        Me.kryptonPage3.ImageSmall = CType(resources.GetObject("kryptonPage3.ImageSmall"), System.Drawing.Bitmap)
        Me.kryptonPage3.LastVisibleSet = True
        Me.kryptonPage3.MinimumSize = New System.Drawing.Size(50, 50)
        Me.kryptonPage3.Name = "kryptonPage3"
        Me.kryptonPage3.Size = New System.Drawing.Size(595, 77)
        Me.kryptonPage3.Text = "Page 3"
        Me.kryptonPage3.ToolTipTitle = "Page ToolTip"
        Me.kryptonPage3.UniqueName = "0BE20839F0EE48560BE20839F0EE4856"
        Me.kryptonPage4.AutoHiddenSlideSize = New System.Drawing.Size(200, 200)
        Me.kryptonPage4.Flags = 65534
        Me.kryptonPage4.ImageLarge = CType(resources.GetObject("kryptonPage4.ImageLarge"), System.Drawing.Bitmap)
        Me.kryptonPage4.ImageMedium = CType(resources.GetObject("kryptonPage4.ImageMedium"), System.Drawing.Bitmap)
        Me.kryptonPage4.ImageSmall = CType(resources.GetObject("kryptonPage4.ImageSmall"), System.Drawing.Bitmap)
        Me.kryptonPage4.LastVisibleSet = True
        Me.kryptonPage4.MinimumSize = New System.Drawing.Size(50, 50)
        Me.kryptonPage4.Name = "kryptonPage4"
        Me.kryptonPage4.Size = New System.Drawing.Size(595, 77)
        Me.kryptonPage4.Text = "Page 4"
        Me.kryptonPage4.ToolTipTitle = "Page ToolTip"
        Me.kryptonPage4.UniqueName = "86262F40276048FF86262F40276048FF"
        Me.kryptonPage5.AutoHiddenSlideSize = New System.Drawing.Size(200, 200)
        Me.kryptonPage5.Flags = 65534
        Me.kryptonPage5.ImageLarge = CType(resources.GetObject("kryptonPage5.ImageLarge"), System.Drawing.Bitmap)
        Me.kryptonPage5.ImageMedium = CType(resources.GetObject("kryptonPage5.ImageMedium"), System.Drawing.Bitmap)
        Me.kryptonPage5.ImageSmall = CType(resources.GetObject("kryptonPage5.ImageSmall"), System.Drawing.Bitmap)
        Me.kryptonPage5.LastVisibleSet = True
        Me.kryptonPage5.MinimumSize = New System.Drawing.Size(50, 50)
        Me.kryptonPage5.Name = "kryptonPage5"
        Me.kryptonPage5.Size = New System.Drawing.Size(595, 77)
        Me.kryptonPage5.Text = "Page 5"
        Me.kryptonPage5.ToolTipTitle = "Page ToolTip"
        Me.kryptonPage5.UniqueName = "398DE3D4C2F343B2398DE3D4C2F343B2"
        Me.kryptonPage6.AutoHiddenSlideSize = New System.Drawing.Size(200, 200)
        Me.kryptonPage6.Flags = 65534
        Me.kryptonPage6.ImageLarge = CType(resources.GetObject("kryptonPage6.ImageLarge"), System.Drawing.Bitmap)
        Me.kryptonPage6.ImageMedium = CType(resources.GetObject("kryptonPage6.ImageMedium"), System.Drawing.Bitmap)
        Me.kryptonPage6.ImageSmall = CType(resources.GetObject("kryptonPage6.ImageSmall"), System.Drawing.Bitmap)
        Me.kryptonPage6.LastVisibleSet = True
        Me.kryptonPage6.MinimumSize = New System.Drawing.Size(50, 50)
        Me.kryptonPage6.Name = "kryptonPage6"
        Me.kryptonPage6.Size = New System.Drawing.Size(595, 77)
        Me.kryptonPage6.Text = "Page 6"
        Me.kryptonPage6.ToolTipTitle = "Page ToolTip"
        Me.kryptonPage6.UniqueName = "140EC00B9F8A4042140EC00B9F8A4042"
        Me.buttonClose.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.buttonClose.Location = New System.Drawing.Point(534, 385)
        Me.buttonClose.Name = "buttonClose"
        Me.buttonClose.Size = New System.Drawing.Size(75, 23)
        Me.buttonClose.TabIndex = 3
        Me.buttonClose.Text = "Close"
        Me.buttonClose.UseVisualStyleBackColor = True
        Me.groupBoxTabStyles.Controls.Add(Me.radioOneNote)
        Me.groupBoxTabStyles.Controls.Add(Me.radioLP)
        Me.groupBoxTabStyles.Controls.Add(Me.radioSP)
        Me.groupBoxTabStyles.Controls.Add(Me.radioHP)
        Me.groupBoxTabStyles.Location = New System.Drawing.Point(12, 200)
        Me.groupBoxTabStyles.Name = "groupBoxTabStyles"
        Me.groupBoxTabStyles.Size = New System.Drawing.Size(595, 57)
        Me.groupBoxTabStyles.TabIndex = 1
        Me.groupBoxTabStyles.TabStop = False
        Me.groupBoxTabStyles.Text = "Tab Styles"
        Me.radioOneNote.AutoSize = True
        Me.radioOneNote.Location = New System.Drawing.Point(485, 25)
        Me.radioOneNote.Name = "radioOneNote"
        Me.radioOneNote.Size = New System.Drawing.Size(68, 17)
        Me.radioOneNote.TabIndex = 3
        Me.radioOneNote.Tag = "OneNote"
        Me.radioOneNote.Text = "OneNote"
        Me.radioOneNote.UseVisualStyleBackColor = True
        Me.radioLP.AutoSize = True
        Me.radioLP.Location = New System.Drawing.Point(340, 25)
        Me.radioLP.Name = "radioLP"
        Me.radioLP.Size = New System.Drawing.Size(77, 17)
        Me.radioLP.TabIndex = 2
        Me.radioLP.Tag = "LowProfile"
        Me.radioLP.Text = "Low Profile"
        Me.radioLP.UseVisualStyleBackColor = True
        Me.radioSP.AutoSize = True
        Me.radioSP.Location = New System.Drawing.Point(173, 25)
        Me.radioSP.Name = "radioSP"
        Me.radioSP.Size = New System.Drawing.Size(102, 17)
        Me.radioSP.TabIndex = 1
        Me.radioSP.Tag = "StandardProfile"
        Me.radioSP.Text = "Standard Profile"
        Me.radioSP.UseVisualStyleBackColor = True
        Me.radioHP.AutoSize = True
        Me.radioHP.Checked = True
        Me.radioHP.Location = New System.Drawing.Point(16, 25)
        Me.radioHP.Name = "radioHP"
        Me.radioHP.Size = New System.Drawing.Size(79, 17)
        Me.radioHP.TabIndex = 0
        Me.radioHP.TabStop = True
        Me.radioHP.Tag = "HighProfile"
        Me.radioHP.Text = "High Profile"
        Me.radioHP.UseVisualStyleBackColor = True
        Me.kryptonManager1.GlobalPaletteMode = Krypton.Toolkit.PaletteMode.ProfessionalSystem
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6F, 13F)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(619, 418)
        Me.Controls.Add(Me.groupBoxTabStyles)
        Me.Controls.Add(Me.buttonClose)
        Me.Controls.Add(Me.kryptonNavigator)
        Me.Controls.Add(Me.groupBoxTabBorderStyles)
        Me.Font = New System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.MaximizeBox = False
        Me.MinimizeBox = False
        Me.MinimumSize = New System.Drawing.Size(627, 452)
        Me.Name = "Form1"
        Me.Text = "Tab Border Styles"
        Me.groupBoxTabBorderStyles.ResumeLayout(False)
        Me.groupBoxTabBorderStyles.PerformLayout()
        CType(Me.kryptonNavigator, System.ComponentModel.ISupportInitialize).EndInit()
        Me.kryptonNavigator.ResumeLayout(False)
        CType(Me.kryptonPage1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.kryptonPage2, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.kryptonPage3, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.kryptonPage4, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.kryptonPage5, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.kryptonPage6, System.ComponentModel.ISupportInitialize).EndInit()
        Me.groupBoxTabStyles.ResumeLayout(False)
        Me.groupBoxTabStyles.PerformLayout()
        Me.ResumeLayout(False)
    End Sub

    Friend WithEvents groupBoxTabBorderStyles As System.Windows.Forms.GroupBox
    Friend WithEvents kryptonNavigator As Krypton.Navigator.KryptonNavigator
    Friend WithEvents kryptonPage1 As Krypton.Navigator.KryptonPage
    Friend WithEvents kryptonPage2 As Krypton.Navigator.KryptonPage
    Friend WithEvents radioROL As System.Windows.Forms.RadioButton
    Friend WithEvents radioROM As System.Windows.Forms.RadioButton
    Friend WithEvents radioROS As System.Windows.Forms.RadioButton
    Friend WithEvents radioREL As System.Windows.Forms.RadioButton
    Friend WithEvents radioREM As System.Windows.Forms.RadioButton
    Friend WithEvents radioRES As System.Windows.Forms.RadioButton
    Friend WithEvents radioSOL As System.Windows.Forms.RadioButton
    Friend WithEvents radioSOM As System.Windows.Forms.RadioButton
    Friend WithEvents radioSOS As System.Windows.Forms.RadioButton
    Friend WithEvents radioSEL As System.Windows.Forms.RadioButton
    Friend WithEvents radioSEM As System.Windows.Forms.RadioButton
    Friend WithEvents radioSES As System.Windows.Forms.RadioButton
    Friend WithEvents radioSO As System.Windows.Forms.RadioButton
    Friend WithEvents radioSE As System.Windows.Forms.RadioButton
    Friend WithEvents radioON As System.Windows.Forms.RadioButton
    Friend WithEvents radioSOB As System.Windows.Forms.RadioButton
    Friend WithEvents radioSOF As System.Windows.Forms.RadioButton
    Friend WithEvents radioSON As System.Windows.Forms.RadioButton
    Friend WithEvents radioSEB As System.Windows.Forms.RadioButton
    Friend WithEvents radioSEF As System.Windows.Forms.RadioButton
    Friend WithEvents radioSEN As System.Windows.Forms.RadioButton
    Friend WithEvents buttonClose As System.Windows.Forms.Button
    Friend WithEvents kryptonPage3 As Krypton.Navigator.KryptonPage
    Friend WithEvents kryptonPage4 As Krypton.Navigator.KryptonPage
    Friend WithEvents kryptonPage5 As Krypton.Navigator.KryptonPage
    Friend WithEvents kryptonPage6 As Krypton.Navigator.KryptonPage
    Friend WithEvents groupBoxTabStyles As System.Windows.Forms.GroupBox
    Friend WithEvents radioLP As System.Windows.Forms.RadioButton
    Friend WithEvents radioSP As System.Windows.Forms.RadioButton
    Friend WithEvents radioHP As System.Windows.Forms.RadioButton
    Friend WithEvents radioOneNote As System.Windows.Forms.RadioButton
    Friend WithEvents kryptonManager1 As Krypton.Toolkit.KryptonManager
End Class
