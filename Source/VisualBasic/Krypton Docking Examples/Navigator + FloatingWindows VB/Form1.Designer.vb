' VB.NET twin of Source\Krypton Docking Examples\Navigator + FloatingWindows\Form1.Designer.cs (Bastion Phase 4c).
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
        Me.kryptonDockingManager = New Krypton.Docking.KryptonDockingManager()
        Me.kryptonManager = New Krypton.Toolkit.KryptonManager(Me.components)
        Me.kryptonPanel = New Krypton.Toolkit.KryptonPanel()
        Me.kryptonDockableNavigator = New Krypton.Docking.KryptonDockableNavigator()
        Me.imageListSmall = New System.Windows.Forms.ImageList(Me.components)
        CType(Me.kryptonPanel, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.kryptonPanel.SuspendLayout()
        CType(Me.kryptonDockableNavigator, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        Me.kryptonManager.GlobalPaletteMode = Krypton.Toolkit.PaletteMode.Office2010Blue
        Me.kryptonPanel.Controls.Add(Me.kryptonDockableNavigator)
        Me.kryptonPanel.Dock = System.Windows.Forms.DockStyle.Fill
        Me.kryptonPanel.Location = New System.Drawing.Point(0, 0)
        Me.kryptonPanel.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.kryptonPanel.Name = "kryptonPanel"
        Me.kryptonPanel.Padding = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.kryptonPanel.Size = New System.Drawing.Size(533, 336)
        Me.kryptonPanel.TabIndex = 0
        Me.kryptonDockableNavigator.Button.ButtonDisplayLogic = Krypton.Navigator.ButtonDisplayLogic.Context
        Me.kryptonDockableNavigator.Button.CloseButtonAction = Krypton.Navigator.CloseButtonAction.RemovePageAndDispose
        Me.kryptonDockableNavigator.Button.CloseButtonDisplay = Krypton.Navigator.ButtonDisplay.Hide
        Me.kryptonDockableNavigator.Button.ContextButtonAction = Krypton.Navigator.ContextButtonAction.SelectPage
        Me.kryptonDockableNavigator.Button.ContextButtonDisplay = Krypton.Navigator.ButtonDisplay.Logic
        Me.kryptonDockableNavigator.Button.ContextMenuMapImage = Krypton.Navigator.MapKryptonPageImage.Small
        Me.kryptonDockableNavigator.Button.ContextMenuMapText = Krypton.Navigator.MapKryptonPageText.TextTitle
        Me.kryptonDockableNavigator.Button.NextButtonAction = Krypton.Navigator.DirectionButtonAction.ModeAppropriateAction
        Me.kryptonDockableNavigator.Button.NextButtonDisplay = Krypton.Navigator.ButtonDisplay.Logic
        Me.kryptonDockableNavigator.Button.PreviousButtonAction = Krypton.Navigator.DirectionButtonAction.ModeAppropriateAction
        Me.kryptonDockableNavigator.Button.PreviousButtonDisplay = Krypton.Navigator.ButtonDisplay.Logic
        Me.kryptonDockableNavigator.ControlKryptonFormFeatures = False
        Me.kryptonDockableNavigator.Dock = System.Windows.Forms.DockStyle.Fill
        Me.kryptonDockableNavigator.Location = New System.Drawing.Point(4, 4)
        Me.kryptonDockableNavigator.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.kryptonDockableNavigator.Name = "kryptonDockableNavigator"
        Me.kryptonDockableNavigator.NavigatorMode = Krypton.Navigator.NavigatorMode.BarTabGroup
        Me.kryptonDockableNavigator.Owner = Nothing
        Me.kryptonDockableNavigator.PageBackStyle = Krypton.Toolkit.PaletteBackStyle.ControlClient
        Me.kryptonDockableNavigator.Size = New System.Drawing.Size(525, 328)
        Me.kryptonDockableNavigator.TabIndex = 0
        Me.imageListSmall.ImageStream = CType(resources.GetObject("imageListSmall.ImageStream"), System.Windows.Forms.ImageListStreamer)
        Me.imageListSmall.TransparentColor = System.Drawing.Color.Transparent
        Me.imageListSmall.Images.SetKeyName(0, "document_plain.png")
        Me.imageListSmall.Images.SetKeyName(1, "preferences.png")
        Me.imageListSmall.Images.SetKeyName(2, "information2.png")
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8F, 16F)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(533, 336)
        Me.Controls.Add(Me.kryptonPanel)
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.Name = "Form1"
        Me.Text = "Navigator + FloatingWindows"
        CType(Me.kryptonPanel, System.ComponentModel.ISupportInitialize).EndInit()
        Me.kryptonPanel.ResumeLayout(False)
        CType(Me.kryptonDockableNavigator, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
    End Sub

    Friend WithEvents kryptonDockingManager As Krypton.Docking.KryptonDockingManager
    Friend WithEvents kryptonManager As Krypton.Toolkit.KryptonManager
    Friend WithEvents kryptonPanel As Krypton.Toolkit.KryptonPanel
    Friend WithEvents kryptonDockableNavigator As Krypton.Docking.KryptonDockableNavigator
    Friend WithEvents imageListSmall As System.Windows.Forms.ImageList
End Class
