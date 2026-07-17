' VB.NET twin of Source\Krypton Navigator Examples\User Page Creation\Form1.Designer.cs (Bastion Phase 4c).
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(Form1))
        Me.kryptonNavigator1 = New Krypton.Navigator.KryptonNavigator()
        Me.kryptonAddPage = New Krypton.Navigator.KryptonPage()
        Me.groupBoxDescription = New System.Windows.Forms.GroupBox()
        Me.textBoxDescription = New System.Windows.Forms.TextBox()
        Me.buttonClose = New System.Windows.Forms.Button()
        Me.kryptonManager1 = New Krypton.Toolkit.KryptonManager()
        CType(Me.kryptonNavigator1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.kryptonNavigator1.SuspendLayout()
        CType(Me.kryptonAddPage, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.groupBoxDescription.SuspendLayout()
        Me.SuspendLayout()
        Me.kryptonNavigator1.AllowPageReorder = False
        Me.kryptonNavigator1.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) Or System.Windows.Forms.AnchorStyles.Left) Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.kryptonNavigator1.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowOnly
        Me.kryptonNavigator1.Button.ButtonDisplayLogic = Krypton.Navigator.ButtonDisplayLogic.Context
        Me.kryptonNavigator1.Button.CloseButtonAction = Krypton.Navigator.CloseButtonAction.RemovePageAndDispose
        Me.kryptonNavigator1.Button.CloseButtonDisplay = Krypton.Navigator.ButtonDisplay.ShowDisabled
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
        Me.kryptonNavigator1.Location = New System.Drawing.Point(12, 172)
        Me.kryptonNavigator1.Name = "kryptonNavigator1"
        Me.kryptonNavigator1.NavigatorMode = Krypton.Navigator.NavigatorMode.BarTabGroup
        Me.kryptonNavigator1.PageBackStyle = Krypton.Toolkit.PaletteBackStyle.ControlClient
        Me.kryptonNavigator1.Pages.AddRange(New Krypton.Navigator.KryptonPage() { Me.kryptonAddPage})
        Me.kryptonNavigator1.Panel.PanelBackStyle = Krypton.Toolkit.PaletteBackStyle.PanelClient
        Me.kryptonNavigator1.SelectedIndex = 0
        Me.kryptonNavigator1.Size = New System.Drawing.Size(430, 97)
        Me.kryptonNavigator1.TabIndex = 0
        Me.kryptonNavigator1.Text = "kryptonNavigator1"
        Me.kryptonAddPage.AutoHiddenSlideSize = New System.Drawing.Size(200, 200)
        Me.kryptonAddPage.Flags = 65534
        Me.kryptonAddPage.ImageLarge = CType(resources.GetObject("kryptonAddPage.ImageLarge"), System.Drawing.Bitmap)
        Me.kryptonAddPage.ImageMedium = CType(resources.GetObject("kryptonAddPage.ImageMedium"), System.Drawing.Bitmap)
        Me.kryptonAddPage.ImageSmall = CType(resources.GetObject("kryptonAddPage.ImageSmall"), System.Drawing.Bitmap)
        Me.kryptonAddPage.LastVisibleSet = True
        Me.kryptonAddPage.MinimumSize = New System.Drawing.Size(50, 50)
        Me.kryptonAddPage.Name = "kryptonAddPage"
        Me.kryptonAddPage.Size = New System.Drawing.Size(428, 72)
        Me.kryptonAddPage.Text = ""
        Me.kryptonAddPage.TextDescription = ""
        Me.kryptonAddPage.TextTitle = ""
        Me.kryptonAddPage.ToolTipTitle = "Page ToolTip"
        Me.kryptonAddPage.UniqueName = "006F26A780F64009006F26A780F64009"
        Me.groupBoxDescription.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.groupBoxDescription.Controls.Add(Me.textBoxDescription)
        Me.groupBoxDescription.Location = New System.Drawing.Point(12, 12)
        Me.groupBoxDescription.Name = "groupBoxDescription"
        Me.groupBoxDescription.Padding = New System.Windows.Forms.Padding(5)
        Me.groupBoxDescription.Size = New System.Drawing.Size(430, 154)
        Me.groupBoxDescription.TabIndex = 1
        Me.groupBoxDescription.TabStop = False
        Me.groupBoxDescription.Text = "Description"
        Me.textBoxDescription.BackColor = System.Drawing.SystemColors.Control
        Me.textBoxDescription.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.textBoxDescription.Dock = System.Windows.Forms.DockStyle.Fill
        Me.textBoxDescription.Location = New System.Drawing.Point(5, 19)
        Me.textBoxDescription.Multiline = True
        Me.textBoxDescription.Name = "textBoxDescription"
        Me.textBoxDescription.Size = New System.Drawing.Size(420, 130)
        Me.textBoxDescription.TabIndex = 0
        Me.textBoxDescription.Text = resources.GetString("textBoxDescription.Text")
        Me.buttonClose.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.buttonClose.Location = New System.Drawing.Point(367, 282)
        Me.buttonClose.Name = "buttonClose"
        Me.buttonClose.Size = New System.Drawing.Size(75, 23)
        Me.buttonClose.TabIndex = 4
        Me.buttonClose.Text = "Close"
        Me.buttonClose.UseVisualStyleBackColor = True
        Me.kryptonManager1.GlobalPaletteMode = Krypton.Toolkit.PaletteMode.ProfessionalSystem
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6F, 13F)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(454, 317)
        Me.Controls.Add(Me.buttonClose)
        Me.Controls.Add(Me.groupBoxDescription)
        Me.Controls.Add(Me.kryptonNavigator1)
        Me.Font = New System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.MaximizeBox = False
        Me.MinimizeBox = False
        Me.Name = "Form1"
        Me.Text = "User Page Creation"
        CType(Me.kryptonNavigator1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.kryptonNavigator1.ResumeLayout(False)
        CType(Me.kryptonAddPage, System.ComponentModel.ISupportInitialize).EndInit()
        Me.groupBoxDescription.ResumeLayout(False)
        Me.groupBoxDescription.PerformLayout()
        Me.ResumeLayout(False)
    End Sub

    Friend WithEvents kryptonNavigator1 As Krypton.Navigator.KryptonNavigator
    Friend WithEvents kryptonAddPage As Krypton.Navigator.KryptonPage
    Friend WithEvents groupBoxDescription As System.Windows.Forms.GroupBox
    Friend WithEvents textBoxDescription As System.Windows.Forms.TextBox
    Friend WithEvents buttonClose As System.Windows.Forms.Button
    Friend WithEvents kryptonManager1 As Krypton.Toolkit.KryptonManager
End Class
