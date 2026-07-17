' VB.NET twin of Source\Krypton Ribbon Examples\MDI Ribbon\Form1.Designer.cs (Bastion Phase 4c).
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
        Me.ribbon = New Krypton.Ribbon.KryptonRibbon()
        Me.buttonSpecHelp = New Krypton.Toolkit.ButtonSpecAny()
        Me.kryptonContextMenuItem1 = New Krypton.Toolkit.KryptonContextMenuItem()
        Me.tabHome = New Krypton.Ribbon.KryptonRibbonTab()
        Me.kryptonRibbonGroup2 = New Krypton.Ribbon.KryptonRibbonGroup()
        Me.kryptonRibbonGroupTriple2 = New Krypton.Ribbon.KryptonRibbonGroupTriple()
        Me.buttonNewWindow = New Krypton.Ribbon.KryptonRibbonGroupButton()
        Me.kryptonRibbonGroupSeparator1 = New Krypton.Ribbon.KryptonRibbonGroupSeparator()
        Me.kryptonRibbonGroupTriple3 = New Krypton.Ribbon.KryptonRibbonGroupTriple()
        Me.buttonCloseWindow = New Krypton.Ribbon.KryptonRibbonGroupButton()
        Me.buttonCloseAllWindows = New Krypton.Ribbon.KryptonRibbonGroupButton()
        Me.kryptonRibbonGroup1 = New Krypton.Ribbon.KryptonRibbonGroup()
        Me.kryptonRibbonGroupTriple4 = New Krypton.Ribbon.KryptonRibbonGroupTriple()
        Me.buttonCascade = New Krypton.Ribbon.KryptonRibbonGroupButton()
        Me.buttonTileHorizontal = New Krypton.Ribbon.KryptonRibbonGroupButton()
        Me.buttonTileVertical = New Krypton.Ribbon.KryptonRibbonGroupButton()
        Me.kryptonManager1 = New Krypton.Toolkit.KryptonManager(Me.components)
        CType(Me.ribbon, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        Me.ribbon.ButtonSpecs.Add(Me.buttonSpecHelp)
        Me.ribbon.InDesignHelperMode = True
        Me.ribbon.Name = "ribbon"
        Me.ribbon.QATLocation = Krypton.Ribbon.QATLocation.Hidden
        Me.ribbon.RibbonFileAppButton.AppButtonMenuItems.AddRange(New Krypton.Toolkit.KryptonContextMenuItemBase() { Me.kryptonContextMenuItem1})
        Me.ribbon.RibbonFileAppButton.AppButtonShowRecentDocs = False
        Me.ribbon.RibbonTabs.AddRange(New Krypton.Ribbon.KryptonRibbonTab() { Me.tabHome})
        Me.ribbon.SelectedTab = Me.tabHome
        Me.ribbon.Size = New System.Drawing.Size(935, 136)
        Me.ribbon.TabIndex = 0
        Me.buttonSpecHelp.Image = CType(resources.GetObject("buttonSpecHelp.Image"), System.Drawing.Image)
        Me.buttonSpecHelp.Style = Krypton.Toolkit.PaletteButtonStyle.ButtonSpec
        Me.buttonSpecHelp.UniqueName = "06E98F3735BC4B1106E98F3735BC4B11"
        Me.kryptonContextMenuItem1.Image = CType(resources.GetObject("kryptonContextMenuItem1.Image"), System.Drawing.Image)
        Me.kryptonContextMenuItem1.Text = "E&xit"
        Me.tabHome.Groups.AddRange(New Krypton.Ribbon.KryptonRibbonGroup() { Me.kryptonRibbonGroup2, Me.kryptonRibbonGroup1})
        Me.tabHome.KeyTip = "H"
        Me.tabHome.Text = "Home"
        Me.kryptonRibbonGroup2.DialogBoxLauncher = False
        Me.kryptonRibbonGroup2.Image = CType(resources.GetObject("kryptonRibbonGroup2.Image"), System.Drawing.Image)
        Me.kryptonRibbonGroup2.Items.AddRange(New Krypton.Ribbon.KryptonRibbonGroupContainer() { Me.kryptonRibbonGroupTriple2, Me.kryptonRibbonGroupSeparator1, Me.kryptonRibbonGroupTriple3})
        Me.kryptonRibbonGroup2.KeyTipGroup = "O"
        Me.kryptonRibbonGroup2.TextLine1 = "Operations"
        Me.kryptonRibbonGroupTriple2.Items.AddRange(New Krypton.Ribbon.KryptonRibbonGroupItem() { Me.buttonNewWindow})
        Me.buttonNewWindow.ImageLarge = CType(resources.GetObject("buttonNewWindow.ImageLarge"), System.Drawing.Image)
        Me.buttonNewWindow.ImageSmall = CType(resources.GetObject("buttonNewWindow.ImageSmall"), System.Drawing.Image)
        Me.buttonNewWindow.KeyTip = "N"
        Me.buttonNewWindow.TextLine1 = "New"
        Me.buttonNewWindow.TextLine2 = "Window"
        Me.kryptonRibbonGroupTriple3.Items.AddRange(New Krypton.Ribbon.KryptonRibbonGroupItem() { Me.buttonCloseWindow, Me.buttonCloseAllWindows})
        Me.buttonCloseWindow.ImageLarge = CType(resources.GetObject("buttonCloseWindow.ImageLarge"), System.Drawing.Image)
        Me.buttonCloseWindow.ImageSmall = CType(resources.GetObject("buttonCloseWindow.ImageSmall"), System.Drawing.Image)
        Me.buttonCloseWindow.KeyTip = "X"
        Me.buttonCloseWindow.TextLine1 = "Close"
        Me.buttonCloseWindow.TextLine2 = "Window"
        Me.buttonCloseAllWindows.ImageLarge = CType(resources.GetObject("buttonCloseAllWindows.ImageLarge"), System.Drawing.Image)
        Me.buttonCloseAllWindows.ImageSmall = CType(resources.GetObject("buttonCloseAllWindows.ImageSmall"), System.Drawing.Image)
        Me.buttonCloseAllWindows.KeyTip = "A"
        Me.buttonCloseAllWindows.TextLine1 = "Close All"
        Me.buttonCloseAllWindows.TextLine2 = "Windows"
        Me.kryptonRibbonGroup1.DialogBoxLauncher = False
        Me.kryptonRibbonGroup1.Image = CType(resources.GetObject("kryptonRibbonGroup1.Image"), System.Drawing.Image)
        Me.kryptonRibbonGroup1.Items.AddRange(New Krypton.Ribbon.KryptonRibbonGroupContainer() { Me.kryptonRibbonGroupTriple4})
        Me.kryptonRibbonGroup1.KeyTipGroup = "A"
        Me.kryptonRibbonGroup1.TextLine1 = "Arrange"
        Me.kryptonRibbonGroupTriple4.Items.AddRange(New Krypton.Ribbon.KryptonRibbonGroupItem() { Me.buttonCascade, Me.buttonTileHorizontal, Me.buttonTileVertical})
        Me.buttonCascade.ImageLarge = CType(resources.GetObject("buttonCascade.ImageLarge"), System.Drawing.Image)
        Me.buttonCascade.ImageSmall = CType(resources.GetObject("buttonCascade.ImageSmall"), System.Drawing.Image)
        Me.buttonCascade.KeyTip = "C"
        Me.buttonCascade.TextLine1 = "Cascade"
        Me.buttonTileHorizontal.ImageLarge = CType(resources.GetObject("buttonTileHorizontal.ImageLarge"), System.Drawing.Image)
        Me.buttonTileHorizontal.ImageSmall = CType(resources.GetObject("buttonTileHorizontal.ImageSmall"), System.Drawing.Image)
        Me.buttonTileHorizontal.KeyTip = "H"
        Me.buttonTileHorizontal.TextLine1 = "Tile"
        Me.buttonTileHorizontal.TextLine2 = "Horizontal"
        Me.buttonTileVertical.ImageLarge = CType(resources.GetObject("buttonTileVertical.ImageLarge"), System.Drawing.Image)
        Me.buttonTileVertical.ImageSmall = CType(resources.GetObject("buttonTileVertical.ImageSmall"), System.Drawing.Image)
        Me.buttonTileVertical.KeyTip = "V"
        Me.buttonTileVertical.TextLine1 = "Tile"
        Me.buttonTileVertical.TextLine2 = "Vertical"
        Me.kryptonManager1.GlobalPaletteMode = Krypton.Toolkit.PaletteMode.Office2007Black
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8F, 16F)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(935, 611)
        Me.CloseBox = False
        Me.Controls.Add(Me.ribbon)
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.IsMdiContainer = True
        Me.Margin = New System.Windows.Forms.Padding(4)
        Me.MinimumSize = New System.Drawing.Size(461, 420)
        Me.Name = "Form1"
        Me.Text = "MDI Ribbon"
        Me.TransparencyKey = System.Drawing.Color.Empty
        CType(Me.ribbon, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()
    End Sub

    Friend WithEvents ribbon As Krypton.Ribbon.KryptonRibbon
    Friend WithEvents tabHome As Krypton.Ribbon.KryptonRibbonTab
    Friend WithEvents kryptonRibbonGroup2 As Krypton.Ribbon.KryptonRibbonGroup
    Friend WithEvents kryptonRibbonGroupTriple2 As Krypton.Ribbon.KryptonRibbonGroupTriple
    Friend WithEvents buttonNewWindow As Krypton.Ribbon.KryptonRibbonGroupButton
    Friend WithEvents kryptonRibbonGroupSeparator1 As Krypton.Ribbon.KryptonRibbonGroupSeparator
    Friend WithEvents kryptonRibbonGroupTriple3 As Krypton.Ribbon.KryptonRibbonGroupTriple
    Friend WithEvents buttonCloseWindow As Krypton.Ribbon.KryptonRibbonGroupButton
    Friend WithEvents buttonCloseAllWindows As Krypton.Ribbon.KryptonRibbonGroupButton
    Friend WithEvents kryptonRibbonGroup1 As Krypton.Ribbon.KryptonRibbonGroup
    Friend WithEvents kryptonRibbonGroupTriple4 As Krypton.Ribbon.KryptonRibbonGroupTriple
    Friend WithEvents buttonCascade As Krypton.Ribbon.KryptonRibbonGroupButton
    Friend WithEvents buttonTileHorizontal As Krypton.Ribbon.KryptonRibbonGroupButton
    Friend WithEvents buttonTileVertical As Krypton.Ribbon.KryptonRibbonGroupButton
    'NOTE: Shadows because VB is case-insensitive and KryptonForm exposes a ButtonSpecHelp property (the C# field coexists by case).
    Friend Shadows WithEvents buttonSpecHelp As Krypton.Toolkit.ButtonSpecAny
    Friend WithEvents kryptonContextMenuItem1 As Krypton.Toolkit.KryptonContextMenuItem
    Friend WithEvents kryptonManager1 As Krypton.Toolkit.KryptonManager
End Class
