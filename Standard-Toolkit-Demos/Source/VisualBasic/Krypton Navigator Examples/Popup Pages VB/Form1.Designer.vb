' VB.NET twin of Source\Krypton Navigator Examples\Popup Pages\Form1.Designer.cs (Bastion Phase 4c).
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(Form1))
        Me.groupBoxModes = New System.Windows.Forms.GroupBox()
        Me.radioOutlookMini = New System.Windows.Forms.RadioButton()
        Me.radioHeaderBarCheckButtonOnly = New System.Windows.Forms.RadioButton()
        Me.radioBarCheckButtonOnly = New System.Windows.Forms.RadioButton()
        Me.radioBarRibbonTabOnly = New System.Windows.Forms.RadioButton()
        Me.radioBarCheckButtonGroupOnly = New System.Windows.Forms.RadioButton()
        Me.radioBarTabOnly = New System.Windows.Forms.RadioButton()
        Me.groupBoxBarOrientation = New System.Windows.Forms.GroupBox()
        Me.radioOrientationRight = New System.Windows.Forms.RadioButton()
        Me.radioOrientationLeft = New System.Windows.Forms.RadioButton()
        Me.radioOrientationBottom = New System.Windows.Forms.RadioButton()
        Me.radioOrientationTop = New System.Windows.Forms.RadioButton()
        Me.kryptonNavigator = New Krypton.Navigator.KryptonNavigator()
        Me.kryptonPage1 = New Krypton.Navigator.KryptonPage()
        Me.button3 = New System.Windows.Forms.Button()
        Me.button4 = New System.Windows.Forms.Button()
        Me.button2 = New System.Windows.Forms.Button()
        Me.button1 = New System.Windows.Forms.Button()
        Me.kryptonPage2 = New Krypton.Navigator.KryptonPage()
        Me.listBox1 = New System.Windows.Forms.ListBox()
        Me.kryptonPage3 = New Krypton.Navigator.KryptonPage()
        Me.textBox1 = New System.Windows.Forms.TextBox()
        Me.progressBar1 = New System.Windows.Forms.ProgressBar()
        Me.groupBoxPopupPageProperties = New System.Windows.Forms.GroupBox()
        Me.comboBoxPosition = New System.Windows.Forms.ComboBox()
        Me.comboBoxElement = New System.Windows.Forms.ComboBox()
        Me.labelPosition = New System.Windows.Forms.Label()
        Me.labelElement = New System.Windows.Forms.Label()
        Me.labelGap = New System.Windows.Forms.Label()
        Me.numericGap = New System.Windows.Forms.NumericUpDown()
        Me.labelBorder = New System.Windows.Forms.Label()
        Me.numericBorder = New System.Windows.Forms.NumericUpDown()
        Me.panelHost = New System.Windows.Forms.Panel()
        Me.buttonClose = New System.Windows.Forms.Button()
        Me.kryptonManager1 = New Krypton.Toolkit.KryptonManager(Me.components)
        Me.groupBoxModes.SuspendLayout()
        Me.groupBoxBarOrientation.SuspendLayout()
        CType(Me.kryptonNavigator, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.kryptonNavigator.SuspendLayout()
        CType(Me.kryptonPage1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.kryptonPage1.SuspendLayout()
        CType(Me.kryptonPage2, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.kryptonPage2.SuspendLayout()
        CType(Me.kryptonPage3, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.kryptonPage3.SuspendLayout()
        Me.groupBoxPopupPageProperties.SuspendLayout()
        CType(Me.numericGap, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.numericBorder, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.panelHost.SuspendLayout()
        Me.SuspendLayout()
        Me.groupBoxModes.Controls.Add(Me.radioOutlookMini)
        Me.groupBoxModes.Controls.Add(Me.radioHeaderBarCheckButtonOnly)
        Me.groupBoxModes.Controls.Add(Me.radioBarCheckButtonOnly)
        Me.groupBoxModes.Controls.Add(Me.radioBarRibbonTabOnly)
        Me.groupBoxModes.Controls.Add(Me.radioBarCheckButtonGroupOnly)
        Me.groupBoxModes.Controls.Add(Me.radioBarTabOnly)
        Me.groupBoxModes.Location = New System.Drawing.Point(16, 15)
        Me.groupBoxModes.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.groupBoxModes.Name = "groupBoxModes"
        Me.groupBoxModes.Padding = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.groupBoxModes.Size = New System.Drawing.Size(273, 204)
        Me.groupBoxModes.TabIndex = 0
        Me.groupBoxModes.TabStop = False
        Me.groupBoxModes.Text = "Modes"
        Me.radioOutlookMini.AutoSize = True
        Me.radioOutlookMini.Location = New System.Drawing.Point(24, 171)
        Me.radioOutlookMini.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.radioOutlookMini.Name = "radioOutlookMini"
        Me.radioOutlookMini.Size = New System.Drawing.Size(108, 20)
        Me.radioOutlookMini.TabIndex = 5
        Me.radioOutlookMini.TabStop = True
        Me.radioOutlookMini.Text = "Outlook - Mini"
        Me.radioOutlookMini.UseVisualStyleBackColor = True
        Me.radioHeaderBarCheckButtonOnly.AutoSize = True
        Me.radioHeaderBarCheckButtonOnly.Location = New System.Drawing.Point(24, 143)
        Me.radioHeaderBarCheckButtonOnly.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.radioHeaderBarCheckButtonOnly.Name = "radioHeaderBarCheckButtonOnly"
        Me.radioHeaderBarCheckButtonOnly.Size = New System.Drawing.Size(217, 20)
        Me.radioHeaderBarCheckButtonOnly.TabIndex = 4
        Me.radioHeaderBarCheckButtonOnly.TabStop = True
        Me.radioHeaderBarCheckButtonOnly.Text = "HeaderBar - CheckButton - Only"
        Me.radioHeaderBarCheckButtonOnly.UseVisualStyleBackColor = True
        Me.radioBarCheckButtonOnly.AutoSize = True
        Me.radioBarCheckButtonOnly.Location = New System.Drawing.Point(24, 114)
        Me.radioBarCheckButtonOnly.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.radioBarCheckButtonOnly.Name = "radioBarCheckButtonOnly"
        Me.radioBarCheckButtonOnly.Size = New System.Drawing.Size(174, 20)
        Me.radioBarCheckButtonOnly.TabIndex = 3
        Me.radioBarCheckButtonOnly.TabStop = True
        Me.radioBarCheckButtonOnly.Text = "Bar - CheckButton - Only"
        Me.radioBarCheckButtonOnly.UseVisualStyleBackColor = True
        Me.radioBarRibbonTabOnly.AutoSize = True
        Me.radioBarRibbonTabOnly.Location = New System.Drawing.Point(24, 58)
        Me.radioBarRibbonTabOnly.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.radioBarRibbonTabOnly.Name = "radioBarRibbonTabOnly"
        Me.radioBarRibbonTabOnly.Size = New System.Drawing.Size(165, 20)
        Me.radioBarRibbonTabOnly.TabIndex = 1
        Me.radioBarRibbonTabOnly.TabStop = True
        Me.radioBarRibbonTabOnly.Text = "Bar - RibbonTab - Only"
        Me.radioBarRibbonTabOnly.UseVisualStyleBackColor = True
        Me.radioBarCheckButtonGroupOnly.AutoSize = True
        Me.radioBarCheckButtonGroupOnly.Location = New System.Drawing.Point(24, 86)
        Me.radioBarCheckButtonGroupOnly.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.radioBarCheckButtonGroupOnly.Name = "radioBarCheckButtonGroupOnly"
        Me.radioBarCheckButtonGroupOnly.Size = New System.Drawing.Size(218, 20)
        Me.radioBarCheckButtonGroupOnly.TabIndex = 2
        Me.radioBarCheckButtonGroupOnly.TabStop = True
        Me.radioBarCheckButtonGroupOnly.Text = "Bar - CheckButton - Group - Only"
        Me.radioBarCheckButtonGroupOnly.UseVisualStyleBackColor = True
        Me.radioBarTabOnly.AutoSize = True
        Me.radioBarTabOnly.Location = New System.Drawing.Point(24, 30)
        Me.radioBarTabOnly.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.radioBarTabOnly.Name = "radioBarTabOnly"
        Me.radioBarTabOnly.Size = New System.Drawing.Size(121, 20)
        Me.radioBarTabOnly.TabIndex = 0
        Me.radioBarTabOnly.TabStop = True
        Me.radioBarTabOnly.Text = "Bar - Tab - Only"
        Me.radioBarTabOnly.UseVisualStyleBackColor = True
        Me.groupBoxBarOrientation.Controls.Add(Me.radioOrientationRight)
        Me.groupBoxBarOrientation.Controls.Add(Me.radioOrientationLeft)
        Me.groupBoxBarOrientation.Controls.Add(Me.radioOrientationBottom)
        Me.groupBoxBarOrientation.Controls.Add(Me.radioOrientationTop)
        Me.groupBoxBarOrientation.Location = New System.Drawing.Point(16, 226)
        Me.groupBoxBarOrientation.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.groupBoxBarOrientation.Name = "groupBoxBarOrientation"
        Me.groupBoxBarOrientation.Padding = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.groupBoxBarOrientation.Size = New System.Drawing.Size(273, 148)
        Me.groupBoxBarOrientation.TabIndex = 1
        Me.groupBoxBarOrientation.TabStop = False
        Me.groupBoxBarOrientation.Text = "Bar Orientation"
        Me.radioOrientationRight.AutoSize = True
        Me.radioOrientationRight.Location = New System.Drawing.Point(24, 114)
        Me.radioOrientationRight.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.radioOrientationRight.Name = "radioOrientationRight"
        Me.radioOrientationRight.Size = New System.Drawing.Size(59, 20)
        Me.radioOrientationRight.TabIndex = 3
        Me.radioOrientationRight.TabStop = True
        Me.radioOrientationRight.Text = "Right"
        Me.radioOrientationRight.UseVisualStyleBackColor = True
        Me.radioOrientationLeft.AutoSize = True
        Me.radioOrientationLeft.Location = New System.Drawing.Point(24, 86)
        Me.radioOrientationLeft.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.radioOrientationLeft.Name = "radioOrientationLeft"
        Me.radioOrientationLeft.Size = New System.Drawing.Size(49, 20)
        Me.radioOrientationLeft.TabIndex = 2
        Me.radioOrientationLeft.TabStop = True
        Me.radioOrientationLeft.Text = "Left"
        Me.radioOrientationLeft.UseVisualStyleBackColor = True
        Me.radioOrientationBottom.AutoSize = True
        Me.radioOrientationBottom.Location = New System.Drawing.Point(24, 58)
        Me.radioOrientationBottom.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.radioOrientationBottom.Name = "radioOrientationBottom"
        Me.radioOrientationBottom.Size = New System.Drawing.Size(70, 20)
        Me.radioOrientationBottom.TabIndex = 1
        Me.radioOrientationBottom.TabStop = True
        Me.radioOrientationBottom.Text = "Bottom"
        Me.radioOrientationBottom.UseVisualStyleBackColor = True
        Me.radioOrientationTop.AutoSize = True
        Me.radioOrientationTop.Location = New System.Drawing.Point(24, 30)
        Me.radioOrientationTop.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.radioOrientationTop.Name = "radioOrientationTop"
        Me.radioOrientationTop.Size = New System.Drawing.Size(53, 20)
        Me.radioOrientationTop.TabIndex = 0
        Me.radioOrientationTop.TabStop = True
        Me.radioOrientationTop.Text = "Top"
        Me.radioOrientationTop.UseVisualStyleBackColor = True
        Me.kryptonNavigator.AutoSize = True
        Me.kryptonNavigator.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink
        Me.kryptonNavigator.Button.ButtonDisplayLogic = Krypton.Navigator.ButtonDisplayLogic.Context
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
        Me.kryptonNavigator.ControlKryptonFormFeatures = False
        Me.kryptonNavigator.Dock = System.Windows.Forms.DockStyle.Top
        Me.kryptonNavigator.Location = New System.Drawing.Point(0, 0)
        Me.kryptonNavigator.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.kryptonNavigator.Name = "kryptonNavigator"
        Me.kryptonNavigator.NavigatorMode = Krypton.Navigator.NavigatorMode.HeaderBarCheckButtonOnly
        Me.kryptonNavigator.Owner = Nothing
        Me.kryptonNavigator.PageBackStyle = Krypton.Toolkit.PaletteBackStyle.ControlClient
        Me.kryptonNavigator.Pages.AddRange(New Krypton.Navigator.KryptonPage() { Me.kryptonPage1, Me.kryptonPage2, Me.kryptonPage3})
        Me.kryptonNavigator.PopupPages.AllowPopupPages = Krypton.Navigator.PopupPageAllow.OnlyCompatibleModes
        Me.kryptonNavigator.PopupPages.Element = Krypton.Navigator.PopupPageElement.Item
        Me.kryptonNavigator.PopupPages.Position = Krypton.Navigator.PopupPagePosition.ModeAppropriate
        Me.kryptonNavigator.SelectedIndex = 2
        Me.kryptonNavigator.Size = New System.Drawing.Size(435, 36)
        Me.kryptonNavigator.TabIndex = 0
        Me.kryptonNavigator.Text = "kryptonNavigator1"
        Me.kryptonPage1.AutoHiddenSlideSize = New System.Drawing.Size(200, 200)
        Me.kryptonPage1.Controls.Add(Me.button3)
        Me.kryptonPage1.Controls.Add(Me.button4)
        Me.kryptonPage1.Controls.Add(Me.button2)
        Me.kryptonPage1.Controls.Add(Me.button1)
        Me.kryptonPage1.Flags = 65534
        Me.kryptonPage1.ImageSmall = CType(resources.GetObject("kryptonPage1.ImageSmall"), System.Drawing.Bitmap)
        Me.kryptonPage1.LastVisibleSet = True
        Me.kryptonPage1.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.kryptonPage1.MinimumSize = New System.Drawing.Size(67, 62)
        Me.kryptonPage1.Name = "kryptonPage1"
        Me.kryptonPage1.Padding = New System.Windows.Forms.Padding(20, 18, 20, 18)
        Me.kryptonPage1.Size = New System.Drawing.Size(431, 107)
        Me.kryptonPage1.Text = "First"
        Me.kryptonPage1.TextDescription = "First"
        Me.kryptonPage1.TextTitle = "First"
        Me.kryptonPage1.ToolTipTitle = "Page ToolTip"
        Me.kryptonPage1.UniqueName = "7E2C077BE4094D077E2C077BE4094D07"
        Me.button3.Location = New System.Drawing.Point(0, 0)
        Me.button3.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.button3.Name = "button3"
        Me.button3.Size = New System.Drawing.Size(100, 28)
        Me.button3.TabIndex = 3
        Me.button3.Text = "button3"
        Me.button3.UseVisualStyleBackColor = True
        Me.button4.Location = New System.Drawing.Point(0, 0)
        Me.button4.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.button4.Name = "button4"
        Me.button4.Size = New System.Drawing.Size(100, 28)
        Me.button4.TabIndex = 2
        Me.button4.Text = "button4"
        Me.button4.UseVisualStyleBackColor = True
        Me.button2.Location = New System.Drawing.Point(0, 0)
        Me.button2.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.button2.Name = "button2"
        Me.button2.Size = New System.Drawing.Size(100, 28)
        Me.button2.TabIndex = 1
        Me.button2.Text = "button2"
        Me.button2.UseVisualStyleBackColor = True
        Me.button1.Location = New System.Drawing.Point(0, 0)
        Me.button1.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.button1.Name = "button1"
        Me.button1.Size = New System.Drawing.Size(100, 28)
        Me.button1.TabIndex = 0
        Me.button1.Text = "button1"
        Me.button1.UseVisualStyleBackColor = True
        Me.kryptonPage2.AutoHiddenSlideSize = New System.Drawing.Size(200, 200)
        Me.kryptonPage2.Controls.Add(Me.listBox1)
        Me.kryptonPage2.Flags = 65534
        Me.kryptonPage2.ImageSmall = CType(resources.GetObject("kryptonPage2.ImageSmall"), System.Drawing.Bitmap)
        Me.kryptonPage2.LastVisibleSet = True
        Me.kryptonPage2.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.kryptonPage2.MinimumSize = New System.Drawing.Size(67, 62)
        Me.kryptonPage2.Name = "kryptonPage2"
        Me.kryptonPage2.Padding = New System.Windows.Forms.Padding(20, 18, 20, 18)
        Me.kryptonPage2.Size = New System.Drawing.Size(431, 144)
        Me.kryptonPage2.Text = "Second"
        Me.kryptonPage2.TextDescription = "Second"
        Me.kryptonPage2.TextTitle = "Second"
        Me.kryptonPage2.ToolTipTitle = "Page ToolTip"
        Me.kryptonPage2.UniqueName = "BFAC6C72E7814623BFAC6C72E7814623"
        Me.listBox1.FormattingEnabled = True
        Me.listBox1.ItemHeight = 16
        Me.listBox1.Items.AddRange(New Object() { "alpha", "beta", "gamma", "theta", "omega", "delta", "ohmn", "pi"})
        Me.listBox1.Location = New System.Drawing.Point(0, 0)
        Me.listBox1.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.listBox1.Name = "listBox1"
        Me.listBox1.Size = New System.Drawing.Size(159, 100)
        Me.listBox1.TabIndex = 0
        Me.kryptonPage3.AutoHiddenSlideSize = New System.Drawing.Size(200, 200)
        Me.kryptonPage3.Controls.Add(Me.textBox1)
        Me.kryptonPage3.Controls.Add(Me.progressBar1)
        Me.kryptonPage3.Flags = 65534
        Me.kryptonPage3.ImageSmall = CType(resources.GetObject("kryptonPage3.ImageSmall"), System.Drawing.Bitmap)
        Me.kryptonPage3.LastVisibleSet = True
        Me.kryptonPage3.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.kryptonPage3.MinimumSize = New System.Drawing.Size(67, 62)
        Me.kryptonPage3.Name = "kryptonPage3"
        Me.kryptonPage3.Padding = New System.Windows.Forms.Padding(20, 18, 20, 18)
        Me.kryptonPage3.Size = New System.Drawing.Size(431, 102)
        Me.kryptonPage3.Text = "Third"
        Me.kryptonPage3.TextDescription = "Third"
        Me.kryptonPage3.TextTitle = "Third"
        Me.kryptonPage3.ToolTipTitle = "Page ToolTip"
        Me.kryptonPage3.UniqueName = "FB3FA57F03934EE1FB3FA57F03934EE1"
        Me.textBox1.Location = New System.Drawing.Point(0, 0)
        Me.textBox1.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.textBox1.Name = "textBox1"
        Me.textBox1.Size = New System.Drawing.Size(132, 22)
        Me.textBox1.TabIndex = 1
        Me.textBox1.Text = "Progress"
        Me.progressBar1.Location = New System.Drawing.Point(0, 0)
        Me.progressBar1.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.progressBar1.Name = "progressBar1"
        Me.progressBar1.Size = New System.Drawing.Size(133, 28)
        Me.progressBar1.TabIndex = 0
        Me.progressBar1.Value = 75
        Me.groupBoxPopupPageProperties.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.groupBoxPopupPageProperties.Controls.Add(Me.comboBoxPosition)
        Me.groupBoxPopupPageProperties.Controls.Add(Me.comboBoxElement)
        Me.groupBoxPopupPageProperties.Controls.Add(Me.labelPosition)
        Me.groupBoxPopupPageProperties.Controls.Add(Me.labelElement)
        Me.groupBoxPopupPageProperties.Controls.Add(Me.labelGap)
        Me.groupBoxPopupPageProperties.Controls.Add(Me.numericGap)
        Me.groupBoxPopupPageProperties.Controls.Add(Me.labelBorder)
        Me.groupBoxPopupPageProperties.Controls.Add(Me.numericBorder)
        Me.groupBoxPopupPageProperties.Location = New System.Drawing.Point(751, 15)
        Me.groupBoxPopupPageProperties.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.groupBoxPopupPageProperties.Name = "groupBoxPopupPageProperties"
        Me.groupBoxPopupPageProperties.Padding = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.groupBoxPopupPageProperties.Size = New System.Drawing.Size(276, 174)
        Me.groupBoxPopupPageProperties.TabIndex = 3
        Me.groupBoxPopupPageProperties.TabStop = False
        Me.groupBoxPopupPageProperties.Text = "Popup Page Properties"
        Me.comboBoxPosition.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.comboBoxPosition.FormattingEnabled = True
        Me.comboBoxPosition.Items.AddRange(New Object() { "ModeAppropriate", "AboveNear", "AboveFar", "AboveMatch", "BelowNear", "BelowFar", "BelowMatch", "FarTop", "FarBottom", "FarMatch", "NearTop", "NearBottom", "NearMatch"})
        Me.comboBoxPosition.Location = New System.Drawing.Point(91, 132)
        Me.comboBoxPosition.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.comboBoxPosition.Name = "comboBoxPosition"
        Me.comboBoxPosition.Size = New System.Drawing.Size(160, 24)
        Me.comboBoxPosition.TabIndex = 4
        Me.comboBoxElement.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.comboBoxElement.FormattingEnabled = True
        Me.comboBoxElement.Items.AddRange(New Object() { "Item", "Navigator"})
        Me.comboBoxElement.Location = New System.Drawing.Point(91, 98)
        Me.comboBoxElement.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.comboBoxElement.Name = "comboBoxElement"
        Me.comboBoxElement.Size = New System.Drawing.Size(160, 24)
        Me.comboBoxElement.TabIndex = 3
        Me.labelPosition.AutoSize = True
        Me.labelPosition.Location = New System.Drawing.Point(23, 135)
        Me.labelPosition.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.labelPosition.Name = "labelPosition"
        Me.labelPosition.Size = New System.Drawing.Size(55, 16)
        Me.labelPosition.TabIndex = 6
        Me.labelPosition.Text = "Position"
        Me.labelElement.AutoSize = True
        Me.labelElement.Location = New System.Drawing.Point(21, 102)
        Me.labelElement.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.labelElement.Name = "labelElement"
        Me.labelElement.Size = New System.Drawing.Size(56, 16)
        Me.labelElement.TabIndex = 5
        Me.labelElement.Text = "Element"
        Me.labelGap.AutoSize = True
        Me.labelGap.Location = New System.Drawing.Point(45, 69)
        Me.labelGap.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.labelGap.Name = "labelGap"
        Me.labelGap.Size = New System.Drawing.Size(33, 16)
        Me.labelGap.TabIndex = 4
        Me.labelGap.Text = "Gap"
        Me.numericGap.Location = New System.Drawing.Point(91, 66)
        Me.numericGap.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.numericGap.Name = "numericGap"
        Me.numericGap.Size = New System.Drawing.Size(67, 22)
        Me.numericGap.TabIndex = 2
        Me.labelBorder.AutoSize = True
        Me.labelBorder.Location = New System.Drawing.Point(31, 37)
        Me.labelBorder.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.labelBorder.Name = "labelBorder"
        Me.labelBorder.Size = New System.Drawing.Size(48, 16)
        Me.labelBorder.TabIndex = 2
        Me.labelBorder.Text = "Border"
        Me.numericBorder.Location = New System.Drawing.Point(91, 34)
        Me.numericBorder.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.numericBorder.Name = "numericBorder"
        Me.numericBorder.Size = New System.Drawing.Size(67, 22)
        Me.numericBorder.TabIndex = 1
        Me.panelHost.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) Or System.Windows.Forms.AnchorStyles.Left) Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.panelHost.Controls.Add(Me.kryptonNavigator)
        Me.panelHost.Location = New System.Drawing.Point(303, 23)
        Me.panelHost.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.panelHost.Name = "panelHost"
        Me.panelHost.Size = New System.Drawing.Size(435, 344)
        Me.panelHost.TabIndex = 6
        Me.buttonClose.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.buttonClose.Location = New System.Drawing.Point(927, 339)
        Me.buttonClose.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.buttonClose.Name = "buttonClose"
        Me.buttonClose.Size = New System.Drawing.Size(100, 28)
        Me.buttonClose.TabIndex = 4
        Me.buttonClose.Text = "Close"
        Me.buttonClose.UseVisualStyleBackColor = True
        Me.kryptonManager1.GlobalPaletteMode = Krypton.Toolkit.PaletteMode.ProfessionalSystem
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8F, 16F)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(1045, 379)
        Me.Controls.Add(Me.buttonClose)
        Me.Controls.Add(Me.panelHost)
        Me.Controls.Add(Me.groupBoxPopupPageProperties)
        Me.Controls.Add(Me.groupBoxBarOrientation)
        Me.Controls.Add(Me.groupBoxModes)
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.MinimumSize = New System.Drawing.Size(1046, 424)
        Me.Name = "Form1"
        Me.Text = "Popup Pages"
        Me.groupBoxModes.ResumeLayout(False)
        Me.groupBoxModes.PerformLayout()
        Me.groupBoxBarOrientation.ResumeLayout(False)
        Me.groupBoxBarOrientation.PerformLayout()
        CType(Me.kryptonNavigator, System.ComponentModel.ISupportInitialize).EndInit()
        Me.kryptonNavigator.ResumeLayout(False)
        CType(Me.kryptonPage1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.kryptonPage1.ResumeLayout(False)
        CType(Me.kryptonPage2, System.ComponentModel.ISupportInitialize).EndInit()
        Me.kryptonPage2.ResumeLayout(False)
        CType(Me.kryptonPage3, System.ComponentModel.ISupportInitialize).EndInit()
        Me.kryptonPage3.ResumeLayout(False)
        Me.kryptonPage3.PerformLayout()
        Me.groupBoxPopupPageProperties.ResumeLayout(False)
        Me.groupBoxPopupPageProperties.PerformLayout()
        CType(Me.numericGap, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.numericBorder, System.ComponentModel.ISupportInitialize).EndInit()
        Me.panelHost.ResumeLayout(False)
        Me.panelHost.PerformLayout()
        Me.ResumeLayout(False)
    End Sub

    Friend WithEvents groupBoxModes As System.Windows.Forms.GroupBox
    Friend WithEvents radioBarRibbonTabOnly As System.Windows.Forms.RadioButton
    Friend WithEvents radioBarCheckButtonGroupOnly As System.Windows.Forms.RadioButton
    Friend WithEvents radioBarTabOnly As System.Windows.Forms.RadioButton
    Friend WithEvents groupBoxBarOrientation As System.Windows.Forms.GroupBox
    Friend WithEvents radioOrientationRight As System.Windows.Forms.RadioButton
    Friend WithEvents radioOrientationLeft As System.Windows.Forms.RadioButton
    Friend WithEvents radioOrientationBottom As System.Windows.Forms.RadioButton
    Friend WithEvents radioOrientationTop As System.Windows.Forms.RadioButton
    Friend WithEvents radioOutlookMini As System.Windows.Forms.RadioButton
    Friend WithEvents radioHeaderBarCheckButtonOnly As System.Windows.Forms.RadioButton
    Friend WithEvents radioBarCheckButtonOnly As System.Windows.Forms.RadioButton
    Friend WithEvents kryptonNavigator As Krypton.Navigator.KryptonNavigator
    Friend WithEvents kryptonPage1 As Krypton.Navigator.KryptonPage
    Friend WithEvents kryptonPage2 As Krypton.Navigator.KryptonPage
    Friend WithEvents groupBoxPopupPageProperties As System.Windows.Forms.GroupBox
    Friend WithEvents labelElement As System.Windows.Forms.Label
    Friend WithEvents labelGap As System.Windows.Forms.Label
    Friend WithEvents numericGap As System.Windows.Forms.NumericUpDown
    Friend WithEvents labelBorder As System.Windows.Forms.Label
    Friend WithEvents numericBorder As System.Windows.Forms.NumericUpDown
    Friend WithEvents comboBoxPosition As System.Windows.Forms.ComboBox
    Friend WithEvents comboBoxElement As System.Windows.Forms.ComboBox
    Friend WithEvents labelPosition As System.Windows.Forms.Label
    Friend WithEvents kryptonPage3 As Krypton.Navigator.KryptonPage
    Friend WithEvents panelHost As System.Windows.Forms.Panel
    Friend WithEvents button2 As System.Windows.Forms.Button
    Friend WithEvents button1 As System.Windows.Forms.Button
    Friend WithEvents button3 As System.Windows.Forms.Button
    Friend WithEvents button4 As System.Windows.Forms.Button
    Friend WithEvents listBox1 As System.Windows.Forms.ListBox
    Friend WithEvents textBox1 As System.Windows.Forms.TextBox
    Friend WithEvents progressBar1 As System.Windows.Forms.ProgressBar
    Friend WithEvents buttonClose As System.Windows.Forms.Button
    Friend WithEvents kryptonManager1 As Krypton.Toolkit.KryptonManager
End Class
