' VB.NET twin of Source\Krypton Workspace Examples\Workspace Cell Modes\Form1.Designer.cs (Bastion Phase 4c).
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
        Me.groupBox1 = New System.Windows.Forms.GroupBox()
        Me.label1 = New System.Windows.Forms.Label()
        Me.radioOutlookMini = New System.Windows.Forms.RadioButton()
        Me.radioBarRibbonTabGroup = New System.Windows.Forms.RadioButton()
        Me.radioBarTabGroup = New System.Windows.Forms.RadioButton()
        Me.radioHeaderBarCheckButtonHeaderGroup = New System.Windows.Forms.RadioButton()
        Me.radioHeaderBarCheckButtonGroup = New System.Windows.Forms.RadioButton()
        Me.radioStackCheckButtonHeaderGroup = New System.Windows.Forms.RadioButton()
        Me.radioStackCheckButtonGroup = New System.Windows.Forms.RadioButton()
        Me.radioOutlookFull = New System.Windows.Forms.RadioButton()
        Me.radioPanel = New System.Windows.Forms.RadioButton()
        Me.radioGroup = New System.Windows.Forms.RadioButton()
        Me.radioHeaderGroup = New System.Windows.Forms.RadioButton()
        Me.radioBarCheckButtonGroupInside = New System.Windows.Forms.RadioButton()
        Me.radioBarCheckButtonGroupOutside = New System.Windows.Forms.RadioButton()
        Me.buttonClose = New System.Windows.Forms.Button()
        Me.kryptonWorkspace = New Krypton.Workspace.KryptonWorkspace()
        Me.buttonAddPage = New System.Windows.Forms.Button()
        Me.buttonClearPages = New System.Windows.Forms.Button()
        Me.imageList = New System.Windows.Forms.ImageList()
        Me.kryptonManager1 = New Krypton.Toolkit.KryptonManager()
        Me.groupBox1.SuspendLayout()
        CType(Me.kryptonWorkspace, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        Me.groupBox1.Controls.Add(Me.label1)
        Me.groupBox1.Controls.Add(Me.radioOutlookMini)
        Me.groupBox1.Controls.Add(Me.radioBarRibbonTabGroup)
        Me.groupBox1.Controls.Add(Me.radioBarTabGroup)
        Me.groupBox1.Controls.Add(Me.radioHeaderBarCheckButtonHeaderGroup)
        Me.groupBox1.Controls.Add(Me.radioHeaderBarCheckButtonGroup)
        Me.groupBox1.Controls.Add(Me.radioStackCheckButtonHeaderGroup)
        Me.groupBox1.Controls.Add(Me.radioStackCheckButtonGroup)
        Me.groupBox1.Controls.Add(Me.radioOutlookFull)
        Me.groupBox1.Controls.Add(Me.radioPanel)
        Me.groupBox1.Controls.Add(Me.radioGroup)
        Me.groupBox1.Controls.Add(Me.radioHeaderGroup)
        Me.groupBox1.Controls.Add(Me.radioBarCheckButtonGroupInside)
        Me.groupBox1.Controls.Add(Me.radioBarCheckButtonGroupOutside)
        Me.groupBox1.Location = New System.Drawing.Point(12, 12)
        Me.groupBox1.Name = "groupBox1"
        Me.groupBox1.Size = New System.Drawing.Size(259, 405)
        Me.groupBox1.TabIndex = 0
        Me.groupBox1.TabStop = False
        Me.groupBox1.Text = "Modes"
        Me.label1.Location = New System.Drawing.Point(7, 340)
        Me.label1.Name = "label1"
        Me.label1.Size = New System.Drawing.Size(246, 57)
        Me.label1.TabIndex = 13
        Me.label1.Text = "Note: TabStrip style modes have been excluded from the list as they serve no usef" & "ul " & vbCrLf & "purpose within the Workspace control."
        Me.radioOutlookMini.AutoSize = True
        Me.radioOutlookMini.Location = New System.Drawing.Point(16, 235)
        Me.radioOutlookMini.Name = "radioOutlookMini"
        Me.radioOutlookMini.Size = New System.Drawing.Size(90, 17)
        Me.radioOutlookMini.TabIndex = 9
        Me.radioOutlookMini.Text = "Outlook - Mini"
        Me.radioOutlookMini.UseVisualStyleBackColor = True
        Me.radioBarRibbonTabGroup.AutoSize = True
        Me.radioBarRibbonTabGroup.Location = New System.Drawing.Point(16, 51)
        Me.radioBarRibbonTabGroup.Name = "radioBarRibbonTabGroup"
        Me.radioBarRibbonTabGroup.Size = New System.Drawing.Size(141, 17)
        Me.radioBarRibbonTabGroup.TabIndex = 1
        Me.radioBarRibbonTabGroup.Text = "Bar - RibbonTab - Group"
        Me.radioBarRibbonTabGroup.UseVisualStyleBackColor = True
        Me.radioBarTabGroup.AutoSize = True
        Me.radioBarTabGroup.Checked = True
        Me.radioBarTabGroup.Location = New System.Drawing.Point(16, 28)
        Me.radioBarTabGroup.Name = "radioBarTabGroup"
        Me.radioBarTabGroup.Size = New System.Drawing.Size(108, 17)
        Me.radioBarTabGroup.TabIndex = 0
        Me.radioBarTabGroup.TabStop = True
        Me.radioBarTabGroup.Text = "Bar - Tab - Group"
        Me.radioBarTabGroup.UseVisualStyleBackColor = True
        Me.radioHeaderBarCheckButtonHeaderGroup.AutoSize = True
        Me.radioHeaderBarCheckButtonHeaderGroup.Location = New System.Drawing.Point(16, 143)
        Me.radioHeaderBarCheckButtonHeaderGroup.Name = "radioHeaderBarCheckButtonHeaderGroup"
        Me.radioHeaderBarCheckButtonHeaderGroup.Size = New System.Drawing.Size(221, 17)
        Me.radioHeaderBarCheckButtonHeaderGroup.TabIndex = 5
        Me.radioHeaderBarCheckButtonHeaderGroup.Text = "HeaderBar - CheckButton - HeaderGroup"
        Me.radioHeaderBarCheckButtonHeaderGroup.UseVisualStyleBackColor = True
        Me.radioHeaderBarCheckButtonGroup.AutoSize = True
        Me.radioHeaderBarCheckButtonGroup.Location = New System.Drawing.Point(16, 120)
        Me.radioHeaderBarCheckButtonGroup.Name = "radioHeaderBarCheckButtonGroup"
        Me.radioHeaderBarCheckButtonGroup.Size = New System.Drawing.Size(186, 17)
        Me.radioHeaderBarCheckButtonGroup.TabIndex = 4
        Me.radioHeaderBarCheckButtonGroup.Text = "HeaderBar - CheckButton - Group"
        Me.radioHeaderBarCheckButtonGroup.UseVisualStyleBackColor = True
        Me.radioStackCheckButtonHeaderGroup.AutoSize = True
        Me.radioStackCheckButtonHeaderGroup.Location = New System.Drawing.Point(16, 189)
        Me.radioStackCheckButtonHeaderGroup.Name = "radioStackCheckButtonHeaderGroup"
        Me.radioStackCheckButtonHeaderGroup.Size = New System.Drawing.Size(196, 17)
        Me.radioStackCheckButtonHeaderGroup.TabIndex = 7
        Me.radioStackCheckButtonHeaderGroup.Text = "Stack - CheckButton - HeaderGroup"
        Me.radioStackCheckButtonHeaderGroup.UseVisualStyleBackColor = True
        Me.radioStackCheckButtonGroup.AutoSize = True
        Me.radioStackCheckButtonGroup.Location = New System.Drawing.Point(16, 166)
        Me.radioStackCheckButtonGroup.Name = "radioStackCheckButtonGroup"
        Me.radioStackCheckButtonGroup.Size = New System.Drawing.Size(161, 17)
        Me.radioStackCheckButtonGroup.TabIndex = 6
        Me.radioStackCheckButtonGroup.Text = "Stack - CheckButton - Group"
        Me.radioStackCheckButtonGroup.UseVisualStyleBackColor = True
        Me.radioOutlookFull.AutoSize = True
        Me.radioOutlookFull.Location = New System.Drawing.Point(16, 212)
        Me.radioOutlookFull.Name = "radioOutlookFull"
        Me.radioOutlookFull.Size = New System.Drawing.Size(88, 17)
        Me.radioOutlookFull.TabIndex = 8
        Me.radioOutlookFull.Text = "Outlook - Full"
        Me.radioOutlookFull.UseVisualStyleBackColor = True
        Me.radioPanel.AutoSize = True
        Me.radioPanel.Location = New System.Drawing.Point(16, 304)
        Me.radioPanel.Name = "radioPanel"
        Me.radioPanel.Size = New System.Drawing.Size(51, 17)
        Me.radioPanel.TabIndex = 12
        Me.radioPanel.Text = "Panel"
        Me.radioPanel.UseVisualStyleBackColor = True
        Me.radioGroup.AutoSize = True
        Me.radioGroup.Location = New System.Drawing.Point(16, 281)
        Me.radioGroup.Name = "radioGroup"
        Me.radioGroup.Size = New System.Drawing.Size(54, 17)
        Me.radioGroup.TabIndex = 11
        Me.radioGroup.Text = "Group"
        Me.radioGroup.UseVisualStyleBackColor = True
        Me.radioHeaderGroup.AutoSize = True
        Me.radioHeaderGroup.Location = New System.Drawing.Point(16, 258)
        Me.radioHeaderGroup.Name = "radioHeaderGroup"
        Me.radioHeaderGroup.Size = New System.Drawing.Size(89, 17)
        Me.radioHeaderGroup.TabIndex = 10
        Me.radioHeaderGroup.Text = "HeaderGroup"
        Me.radioHeaderGroup.UseVisualStyleBackColor = True
        Me.radioBarCheckButtonGroupInside.AutoSize = True
        Me.radioBarCheckButtonGroupInside.Location = New System.Drawing.Point(16, 97)
        Me.radioBarCheckButtonGroupInside.Name = "radioBarCheckButtonGroupInside"
        Me.radioBarCheckButtonGroupInside.Size = New System.Drawing.Size(190, 17)
        Me.radioBarCheckButtonGroupInside.TabIndex = 3
        Me.radioBarCheckButtonGroupInside.Text = "Bar - CheckButton - Group - Inside"
        Me.radioBarCheckButtonGroupInside.UseVisualStyleBackColor = True
        Me.radioBarCheckButtonGroupOutside.AutoSize = True
        Me.radioBarCheckButtonGroupOutside.Location = New System.Drawing.Point(16, 74)
        Me.radioBarCheckButtonGroupOutside.Name = "radioBarCheckButtonGroupOutside"
        Me.radioBarCheckButtonGroupOutside.Size = New System.Drawing.Size(198, 17)
        Me.radioBarCheckButtonGroupOutside.TabIndex = 2
        Me.radioBarCheckButtonGroupOutside.Text = "Bar - CheckButton - Group - Outside"
        Me.radioBarCheckButtonGroupOutside.UseVisualStyleBackColor = True
        Me.buttonClose.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.buttonClose.Location = New System.Drawing.Point(687, 21)
        Me.buttonClose.Name = "buttonClose"
        Me.buttonClose.Size = New System.Drawing.Size(75, 26)
        Me.buttonClose.TabIndex = 3
        Me.buttonClose.Text = "Close"
        Me.buttonClose.UseVisualStyleBackColor = True
        Me.kryptonWorkspace.ActivePage = Nothing
        Me.kryptonWorkspace.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) Or System.Windows.Forms.AnchorStyles.Left) Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.kryptonWorkspace.CompactFlags = CType((((Krypton.Workspace.CompactFlags.RemoveEmptyCells Or Krypton.Workspace.CompactFlags.RemoveEmptySequences) Or Krypton.Workspace.CompactFlags.PromoteLeafs) Or Krypton.Workspace.CompactFlags.AtLeastOneVisibleCell), Krypton.Workspace.CompactFlags)
        Me.kryptonWorkspace.ContainerBackStyle = Krypton.Toolkit.PaletteBackStyle.PanelClient
        Me.kryptonWorkspace.Location = New System.Drawing.Point(285, 57)
        Me.kryptonWorkspace.Name = "kryptonWorkspace"
        Me.kryptonWorkspace.Root.Orientation = System.Windows.Forms.Orientation.Horizontal
        Me.kryptonWorkspace.Root.UniqueName = "EBB79296DCDD40AAF79B5D0F977EEA9A"
        Me.kryptonWorkspace.Root.WorkspaceControl = Me.kryptonWorkspace
        Me.kryptonWorkspace.SeparatorStyle = Krypton.Toolkit.SeparatorStyle.LowProfile
        Me.kryptonWorkspace.Size = New System.Drawing.Size(477, 475)
        Me.kryptonWorkspace.SplitterWidth = 5
        Me.kryptonWorkspace.TabIndex = 4
        Me.kryptonWorkspace.TabStop = True
        Me.buttonAddPage.Location = New System.Drawing.Point(285, 21)
        Me.buttonAddPage.Name = "buttonAddPage"
        Me.buttonAddPage.Size = New System.Drawing.Size(75, 26)
        Me.buttonAddPage.TabIndex = 1
        Me.buttonAddPage.Text = "Add Page"
        Me.buttonAddPage.UseVisualStyleBackColor = True
        Me.buttonClearPages.Location = New System.Drawing.Point(366, 21)
        Me.buttonClearPages.Name = "buttonClearPages"
        Me.buttonClearPages.Size = New System.Drawing.Size(75, 26)
        Me.buttonClearPages.TabIndex = 2
        Me.buttonClearPages.Text = "Clear Pages"
        Me.buttonClearPages.UseVisualStyleBackColor = True
        Me.imageList.ImageStream = CType(resources.GetObject("imageList.ImageStream"), System.Windows.Forms.ImageListStreamer)
        Me.imageList.TransparentColor = System.Drawing.Color.Transparent
        Me.imageList.Images.SetKeyName(0, "flag_bulgaria.png")
        Me.imageList.Images.SetKeyName(1, "flag_china.png")
        Me.imageList.Images.SetKeyName(2, "flag_dominica.png")
        Me.imageList.Images.SetKeyName(3, "flag_equatorial_guinea.png")
        Me.imageList.Images.SetKeyName(4, "flag_falkland_islands.png")
        Me.imageList.Images.SetKeyName(5, "flag_kenya.png")
        Me.imageList.Images.SetKeyName(6, "flag_kyrgyzstan.png")
        Me.imageList.Images.SetKeyName(7, "flag_malaysia.png")
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6F, 13F)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(774, 544)
        Me.Controls.Add(Me.buttonClearPages)
        Me.Controls.Add(Me.buttonAddPage)
        Me.Controls.Add(Me.kryptonWorkspace)
        Me.Controls.Add(Me.buttonClose)
        Me.Controls.Add(Me.groupBox1)
        Me.Font = New System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.MaximizeBox = False
        Me.MinimizeBox = False
        Me.MinimumSize = New System.Drawing.Size(558, 463)
        Me.Name = "Form1"
        Me.Text = "Workspace Cell Modes"
        Me.groupBox1.ResumeLayout(False)
        Me.groupBox1.PerformLayout()
        CType(Me.kryptonWorkspace, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
    End Sub

    Friend WithEvents groupBox1 As System.Windows.Forms.GroupBox
    Friend WithEvents radioOutlookMini As System.Windows.Forms.RadioButton
    Friend WithEvents radioBarRibbonTabGroup As System.Windows.Forms.RadioButton
    Friend WithEvents radioBarTabGroup As System.Windows.Forms.RadioButton
    Friend WithEvents radioHeaderBarCheckButtonHeaderGroup As System.Windows.Forms.RadioButton
    Friend WithEvents radioHeaderBarCheckButtonGroup As System.Windows.Forms.RadioButton
    Friend WithEvents radioStackCheckButtonHeaderGroup As System.Windows.Forms.RadioButton
    Friend WithEvents radioStackCheckButtonGroup As System.Windows.Forms.RadioButton
    Friend WithEvents radioOutlookFull As System.Windows.Forms.RadioButton
    Friend WithEvents radioPanel As System.Windows.Forms.RadioButton
    Friend WithEvents radioGroup As System.Windows.Forms.RadioButton
    Friend WithEvents radioHeaderGroup As System.Windows.Forms.RadioButton
    Friend WithEvents radioBarCheckButtonGroupInside As System.Windows.Forms.RadioButton
    Friend WithEvents radioBarCheckButtonGroupOutside As System.Windows.Forms.RadioButton
    Friend WithEvents label1 As System.Windows.Forms.Label
    Friend WithEvents buttonClose As System.Windows.Forms.Button
    Friend WithEvents kryptonWorkspace As Krypton.Workspace.KryptonWorkspace
    Friend WithEvents buttonAddPage As System.Windows.Forms.Button
    Friend WithEvents buttonClearPages As System.Windows.Forms.Button
    Friend WithEvents imageList As System.Windows.Forms.ImageList
    Friend WithEvents kryptonManager1 As Krypton.Toolkit.KryptonManager
End Class
