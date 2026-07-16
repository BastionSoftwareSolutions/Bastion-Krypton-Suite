' VB.NET twin of Source\Krypton Ribbon Examples\Quick Access Toolbar\Form1.Designer.cs (Bastion Phase 4c).
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
        Me.kryptonRibbon = New Krypton.Ribbon.KryptonRibbon()
        Me.kryptonContextMenuItem1 = New Krypton.Toolkit.KryptonContextMenuItem()
        Me.tabHome = New Krypton.Ribbon.KryptonRibbonTab()
        Me.kryptonManager = New Krypton.Toolkit.KryptonManager(Me.components)
        Me.panelFill = New Krypton.Toolkit.KryptonPanel()
        Me.kryptonGroup2 = New Krypton.Toolkit.KryptonGroup()
        Me.buttonClear = New Krypton.Toolkit.KryptonButton()
        Me.buttonRemove = New Krypton.Toolkit.KryptonButton()
        Me.buttonAdd = New Krypton.Toolkit.KryptonButton()
        Me.labelQATButtons = New Krypton.Toolkit.KryptonLabel()
        Me.kryptonGroup1 = New Krypton.Toolkit.KryptonGroup()
        Me.checkButtonDisallowUserChanges = New Krypton.Toolkit.KryptonCheckButton()
        Me.checkButtonAllowUserChanges = New Krypton.Toolkit.KryptonCheckButton()
        Me.labelQATUserChange = New Krypton.Toolkit.KryptonLabel()
        Me.groupQATLocation = New Krypton.Toolkit.KryptonGroup()
        Me.checkButtonHidden = New Krypton.Toolkit.KryptonCheckButton()
        Me.checkButtonBelow = New Krypton.Toolkit.KryptonCheckButton()
        Me.checkButtonAbove = New Krypton.Toolkit.KryptonCheckButton()
        Me.labelQATLocation = New Krypton.Toolkit.KryptonLabel()
        Me.checkSetQATPosition = New Krypton.Toolkit.KryptonCheckSet(Me.components)
        Me.checkSetQATUserChange = New Krypton.Toolkit.KryptonCheckSet(Me.components)
        Me.kryptonCheckButton1 = New Krypton.Toolkit.KryptonCheckButton()
        Me.kryptonCheckButton2 = New Krypton.Toolkit.KryptonCheckButton()
        Me.kryptonCheckButton3 = New Krypton.Toolkit.KryptonCheckButton()
        Me.kryptonLabel1 = New Krypton.Toolkit.KryptonLabel()
        CType(Me.kryptonRibbon, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.panelFill, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.panelFill.SuspendLayout()
        CType(Me.kryptonGroup2, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.kryptonGroup2.Panel, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.kryptonGroup2.Panel.SuspendLayout()
        Me.kryptonGroup2.SuspendLayout()
        CType(Me.kryptonGroup1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.kryptonGroup1.Panel, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.kryptonGroup1.Panel.SuspendLayout()
        Me.kryptonGroup1.SuspendLayout()
        CType(Me.groupQATLocation, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.groupQATLocation.Panel, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.groupQATLocation.Panel.SuspendLayout()
        Me.groupQATLocation.SuspendLayout()
        CType(Me.checkSetQATPosition, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.checkSetQATUserChange, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        Me.kryptonRibbon.InDesignHelperMode = True
        Me.kryptonRibbon.Name = "kryptonRibbon"
        Me.kryptonRibbon.RibbonFileAppButton.AppButtonMenuItems.AddRange(New Krypton.Toolkit.KryptonContextMenuItemBase() { Me.kryptonContextMenuItem1})
        Me.kryptonRibbon.RibbonFileAppButton.AppButtonShowRecentDocs = False
        Me.kryptonRibbon.RibbonTabs.AddRange(New Krypton.Ribbon.KryptonRibbonTab() { Me.tabHome})
        Me.kryptonRibbon.SelectedTab = Me.tabHome
        Me.kryptonRibbon.Size = New System.Drawing.Size(516, 136)
        Me.kryptonRibbon.TabIndex = 0
        Me.kryptonContextMenuItem1.Image = CType(resources.GetObject("kryptonContextMenuItem1.Image"), System.Drawing.Image)
        Me.kryptonContextMenuItem1.Text = "E&xit"
        Me.tabHome.Text = "Home"
        Me.kryptonManager.GlobalPaletteMode = Krypton.Toolkit.PaletteMode.Office2007Black
        Me.panelFill.Controls.Add(Me.kryptonGroup2)
        Me.panelFill.Controls.Add(Me.kryptonGroup1)
        Me.panelFill.Controls.Add(Me.groupQATLocation)
        Me.panelFill.Dock = System.Windows.Forms.DockStyle.Fill
        Me.panelFill.Location = New System.Drawing.Point(0, 136)
        Me.panelFill.Margin = New System.Windows.Forms.Padding(4)
        Me.panelFill.Name = "panelFill"
        Me.panelFill.Size = New System.Drawing.Size(516, 368)
        Me.panelFill.TabIndex = 1
        Me.kryptonGroup2.GroupBackStyle = Krypton.Toolkit.PaletteBackStyle.PanelAlternate
        Me.kryptonGroup2.Location = New System.Drawing.Point(16, 214)
        Me.kryptonGroup2.Margin = New System.Windows.Forms.Padding(4)
        Me.kryptonGroup2.Name = "kryptonGroup2"
        Me.kryptonGroup2.Panel.Controls.Add(Me.buttonClear)
        Me.kryptonGroup2.Panel.Controls.Add(Me.buttonRemove)
        Me.kryptonGroup2.Panel.Controls.Add(Me.buttonAdd)
        Me.kryptonGroup2.Panel.Controls.Add(Me.labelQATButtons)
        Me.kryptonGroup2.Size = New System.Drawing.Size(431, 100)
        Me.kryptonGroup2.TabIndex = 7
        Me.buttonClear.Location = New System.Drawing.Point(284, 49)
        Me.buttonClear.Margin = New System.Windows.Forms.Padding(4)
        Me.buttonClear.Name = "buttonClear"
        Me.buttonClear.Size = New System.Drawing.Size(120, 31)
        Me.buttonClear.TabIndex = 4
        Me.buttonClear.Values.DropDownArrowColor = System.Drawing.Color.Empty
        Me.buttonClear.Values.Text = "Clear"
        Me.buttonRemove.Location = New System.Drawing.Point(155, 49)
        Me.buttonRemove.Margin = New System.Windows.Forms.Padding(4)
        Me.buttonRemove.Name = "buttonRemove"
        Me.buttonRemove.Size = New System.Drawing.Size(120, 31)
        Me.buttonRemove.TabIndex = 3
        Me.buttonRemove.Values.DropDownArrowColor = System.Drawing.Color.Empty
        Me.buttonRemove.Values.Text = "Remove"
        Me.buttonAdd.Location = New System.Drawing.Point(27, 49)
        Me.buttonAdd.Margin = New System.Windows.Forms.Padding(4)
        Me.buttonAdd.Name = "buttonAdd"
        Me.buttonAdd.Size = New System.Drawing.Size(120, 31)
        Me.buttonAdd.TabIndex = 2
        Me.buttonAdd.Values.DropDownArrowColor = System.Drawing.Color.Empty
        Me.buttonAdd.Values.Text = "Add"
        Me.labelQATButtons.LabelStyle = Krypton.Toolkit.LabelStyle.TitlePanel
        Me.labelQATButtons.Location = New System.Drawing.Point(5, 5)
        Me.labelQATButtons.Margin = New System.Windows.Forms.Padding(4)
        Me.labelQATButtons.Name = "labelQATButtons"
        Me.labelQATButtons.Size = New System.Drawing.Size(153, 35)
        Me.labelQATButtons.TabIndex = 1
        Me.labelQATButtons.Values.Text = "QAT Buttons"
        Me.kryptonGroup1.GroupBackStyle = Krypton.Toolkit.PaletteBackStyle.PanelAlternate
        Me.kryptonGroup1.Location = New System.Drawing.Point(212, 20)
        Me.kryptonGroup1.Margin = New System.Windows.Forms.Padding(4)
        Me.kryptonGroup1.Name = "kryptonGroup1"
        Me.kryptonGroup1.Panel.Controls.Add(Me.checkButtonDisallowUserChanges)
        Me.kryptonGroup1.Panel.Controls.Add(Me.checkButtonAllowUserChanges)
        Me.kryptonGroup1.Panel.Controls.Add(Me.labelQATUserChange)
        Me.kryptonGroup1.Size = New System.Drawing.Size(235, 175)
        Me.kryptonGroup1.TabIndex = 6
        Me.checkButtonDisallowUserChanges.Location = New System.Drawing.Point(21, 101)
        Me.checkButtonDisallowUserChanges.Margin = New System.Windows.Forms.Padding(4)
        Me.checkButtonDisallowUserChanges.Name = "checkButtonDisallowUserChanges"
        Me.checkButtonDisallowUserChanges.Size = New System.Drawing.Size(187, 31)
        Me.checkButtonDisallowUserChanges.TabIndex = 3
        Me.checkButtonDisallowUserChanges.Values.DropDownArrowColor = System.Drawing.Color.Empty
        Me.checkButtonDisallowUserChanges.Values.Text = "Disallow User Changes"
        Me.checkButtonAllowUserChanges.Checked = True
        Me.checkButtonAllowUserChanges.Location = New System.Drawing.Point(21, 63)
        Me.checkButtonAllowUserChanges.Margin = New System.Windows.Forms.Padding(4)
        Me.checkButtonAllowUserChanges.Name = "checkButtonAllowUserChanges"
        Me.checkButtonAllowUserChanges.Size = New System.Drawing.Size(187, 31)
        Me.checkButtonAllowUserChanges.TabIndex = 2
        Me.checkButtonAllowUserChanges.Values.DropDownArrowColor = System.Drawing.Color.Empty
        Me.checkButtonAllowUserChanges.Values.Text = "Allow User Changes"
        Me.labelQATUserChange.LabelStyle = Krypton.Toolkit.LabelStyle.TitlePanel
        Me.labelQATUserChange.Location = New System.Drawing.Point(5, 5)
        Me.labelQATUserChange.Margin = New System.Windows.Forms.Padding(4)
        Me.labelQATUserChange.Name = "labelQATUserChange"
        Me.labelQATUserChange.Size = New System.Drawing.Size(205, 35)
        Me.labelQATUserChange.TabIndex = 1
        Me.labelQATUserChange.Values.Text = "QAT User Change"
        Me.groupQATLocation.GroupBackStyle = Krypton.Toolkit.PaletteBackStyle.PanelAlternate
        Me.groupQATLocation.Location = New System.Drawing.Point(16, 20)
        Me.groupQATLocation.Margin = New System.Windows.Forms.Padding(4)
        Me.groupQATLocation.Name = "groupQATLocation"
        Me.groupQATLocation.Panel.Controls.Add(Me.checkButtonHidden)
        Me.groupQATLocation.Panel.Controls.Add(Me.checkButtonBelow)
        Me.groupQATLocation.Panel.Controls.Add(Me.checkButtonAbove)
        Me.groupQATLocation.Panel.Controls.Add(Me.labelQATLocation)
        Me.groupQATLocation.Size = New System.Drawing.Size(176, 175)
        Me.groupQATLocation.TabIndex = 5
        Me.checkButtonHidden.Location = New System.Drawing.Point(27, 124)
        Me.checkButtonHidden.Margin = New System.Windows.Forms.Padding(4)
        Me.checkButtonHidden.Name = "checkButtonHidden"
        Me.checkButtonHidden.Size = New System.Drawing.Size(120, 31)
        Me.checkButtonHidden.TabIndex = 4
        Me.checkButtonHidden.Values.DropDownArrowColor = System.Drawing.Color.Empty
        Me.checkButtonHidden.Values.Text = "Hidden"
        Me.checkButtonBelow.Location = New System.Drawing.Point(27, 86)
        Me.checkButtonBelow.Margin = New System.Windows.Forms.Padding(4)
        Me.checkButtonBelow.Name = "checkButtonBelow"
        Me.checkButtonBelow.Size = New System.Drawing.Size(120, 31)
        Me.checkButtonBelow.TabIndex = 3
        Me.checkButtonBelow.Values.DropDownArrowColor = System.Drawing.Color.Empty
        Me.checkButtonBelow.Values.Text = "Below"
        Me.checkButtonAbove.Checked = True
        Me.checkButtonAbove.Location = New System.Drawing.Point(27, 48)
        Me.checkButtonAbove.Margin = New System.Windows.Forms.Padding(4)
        Me.checkButtonAbove.Name = "checkButtonAbove"
        Me.checkButtonAbove.Size = New System.Drawing.Size(120, 31)
        Me.checkButtonAbove.TabIndex = 2
        Me.checkButtonAbove.Values.DropDownArrowColor = System.Drawing.Color.Empty
        Me.checkButtonAbove.Values.Text = "Above"
        Me.labelQATLocation.LabelStyle = Krypton.Toolkit.LabelStyle.TitlePanel
        Me.labelQATLocation.Location = New System.Drawing.Point(5, 5)
        Me.labelQATLocation.Margin = New System.Windows.Forms.Padding(4)
        Me.labelQATLocation.Name = "labelQATLocation"
        Me.labelQATLocation.Size = New System.Drawing.Size(161, 35)
        Me.labelQATLocation.TabIndex = 1
        Me.labelQATLocation.Values.Text = "QAT Location"
        Me.checkSetQATPosition.CheckButtons.Add(Me.checkButtonAbove)
        Me.checkSetQATPosition.CheckButtons.Add(Me.checkButtonBelow)
        Me.checkSetQATPosition.CheckButtons.Add(Me.checkButtonHidden)
        Me.checkSetQATPosition.CheckedButton = Me.checkButtonAbove
        Me.checkSetQATUserChange.CheckButtons.Add(Me.checkButtonDisallowUserChanges)
        Me.checkSetQATUserChange.CheckButtons.Add(Me.checkButtonAllowUserChanges)
        Me.checkSetQATUserChange.CheckedButton = Me.checkButtonAllowUserChanges
        Me.kryptonCheckButton1.Location = New System.Drawing.Point(20, 101)
        Me.kryptonCheckButton1.Name = "kryptonCheckButton1"
        Me.kryptonCheckButton1.Size = New System.Drawing.Size(90, 25)
        Me.kryptonCheckButton1.TabIndex = 4
        Me.kryptonCheckButton1.Values.DropDownArrowColor = System.Drawing.Color.Empty
        Me.kryptonCheckButton1.Values.Text = "Hidden"
        Me.kryptonCheckButton2.Location = New System.Drawing.Point(20, 70)
        Me.kryptonCheckButton2.Name = "kryptonCheckButton2"
        Me.kryptonCheckButton2.Size = New System.Drawing.Size(90, 25)
        Me.kryptonCheckButton2.TabIndex = 3
        Me.kryptonCheckButton2.Values.DropDownArrowColor = System.Drawing.Color.Empty
        Me.kryptonCheckButton2.Values.Text = "Below"
        Me.kryptonCheckButton3.Checked = True
        Me.kryptonCheckButton3.Location = New System.Drawing.Point(20, 39)
        Me.kryptonCheckButton3.Name = "kryptonCheckButton3"
        Me.kryptonCheckButton3.Size = New System.Drawing.Size(90, 25)
        Me.kryptonCheckButton3.TabIndex = 2
        Me.kryptonCheckButton3.Values.DropDownArrowColor = System.Drawing.Color.Empty
        Me.kryptonCheckButton3.Values.Text = "Above"
        Me.kryptonLabel1.LabelStyle = Krypton.Toolkit.LabelStyle.TitlePanel
        Me.kryptonLabel1.Location = New System.Drawing.Point(4, 4)
        Me.kryptonLabel1.Name = "kryptonLabel1"
        Me.kryptonLabel1.Size = New System.Drawing.Size(123, 27)
        Me.kryptonLabel1.TabIndex = 1
        Me.kryptonLabel1.Values.Text = "QAT Location"
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8F, 16F)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(516, 504)
        Me.CloseBox = False
        Me.Controls.Add(Me.panelFill)
        Me.Controls.Add(Me.kryptonRibbon)
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.Margin = New System.Windows.Forms.Padding(4)
        Me.MinimumSize = New System.Drawing.Size(505, 537)
        Me.Name = "Form1"
        Me.Text = "Quick Access Toolbar"
        CType(Me.kryptonRibbon, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.panelFill, System.ComponentModel.ISupportInitialize).EndInit()
        Me.panelFill.ResumeLayout(False)
        CType(Me.kryptonGroup2.Panel, System.ComponentModel.ISupportInitialize).EndInit()
        Me.kryptonGroup2.Panel.ResumeLayout(False)
        Me.kryptonGroup2.Panel.PerformLayout()
        CType(Me.kryptonGroup2, System.ComponentModel.ISupportInitialize).EndInit()
        Me.kryptonGroup2.ResumeLayout(False)
        CType(Me.kryptonGroup1.Panel, System.ComponentModel.ISupportInitialize).EndInit()
        Me.kryptonGroup1.Panel.ResumeLayout(False)
        Me.kryptonGroup1.Panel.PerformLayout()
        CType(Me.kryptonGroup1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.kryptonGroup1.ResumeLayout(False)
        CType(Me.groupQATLocation.Panel, System.ComponentModel.ISupportInitialize).EndInit()
        Me.groupQATLocation.Panel.ResumeLayout(False)
        Me.groupQATLocation.Panel.PerformLayout()
        CType(Me.groupQATLocation, System.ComponentModel.ISupportInitialize).EndInit()
        Me.groupQATLocation.ResumeLayout(False)
        CType(Me.checkSetQATPosition, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.checkSetQATUserChange, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()
    End Sub

    Friend WithEvents kryptonRibbon As Krypton.Ribbon.KryptonRibbon
    Friend WithEvents tabHome As Krypton.Ribbon.KryptonRibbonTab
    Friend WithEvents kryptonManager As Krypton.Toolkit.KryptonManager
    Friend WithEvents panelFill As Krypton.Toolkit.KryptonPanel
    Friend WithEvents checkSetQATPosition As Krypton.Toolkit.KryptonCheckSet
    Friend WithEvents groupQATLocation As Krypton.Toolkit.KryptonGroup
    Friend WithEvents labelQATLocation As Krypton.Toolkit.KryptonLabel
    Friend WithEvents checkButtonHidden As Krypton.Toolkit.KryptonCheckButton
    Friend WithEvents checkButtonBelow As Krypton.Toolkit.KryptonCheckButton
    Friend WithEvents checkButtonAbove As Krypton.Toolkit.KryptonCheckButton
    Friend WithEvents kryptonGroup1 As Krypton.Toolkit.KryptonGroup
    Friend WithEvents checkButtonDisallowUserChanges As Krypton.Toolkit.KryptonCheckButton
    Friend WithEvents checkButtonAllowUserChanges As Krypton.Toolkit.KryptonCheckButton
    Friend WithEvents labelQATUserChange As Krypton.Toolkit.KryptonLabel
    Friend WithEvents checkSetQATUserChange As Krypton.Toolkit.KryptonCheckSet
    Friend WithEvents kryptonGroup2 As Krypton.Toolkit.KryptonGroup
    Friend WithEvents buttonClear As Krypton.Toolkit.KryptonButton
    Friend WithEvents buttonRemove As Krypton.Toolkit.KryptonButton
    Friend WithEvents buttonAdd As Krypton.Toolkit.KryptonButton
    Friend WithEvents labelQATButtons As Krypton.Toolkit.KryptonLabel
    Friend WithEvents kryptonCheckButton1 As Krypton.Toolkit.KryptonCheckButton
    Friend WithEvents kryptonCheckButton2 As Krypton.Toolkit.KryptonCheckButton
    Friend WithEvents kryptonCheckButton3 As Krypton.Toolkit.KryptonCheckButton
    Friend WithEvents kryptonLabel1 As Krypton.Toolkit.KryptonLabel
    Friend WithEvents kryptonContextMenuItem1 As Krypton.Toolkit.KryptonContextMenuItem
End Class
