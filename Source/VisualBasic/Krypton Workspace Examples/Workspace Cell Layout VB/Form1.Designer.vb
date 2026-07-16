' VB.NET twin of Source\Krypton Workspace Examples\Workspace Cell Layout\Form1.Designer.cs (Bastion Phase 4c).
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
        Me.kryptonWorkspace = New Krypton.Workspace.KryptonWorkspace()
        Me.groupBox1 = New System.Windows.Forms.GroupBox()
        Me.label3 = New System.Windows.Forms.Label()
        Me.label1 = New System.Windows.Forms.Label()
        Me.labelSingleCell = New System.Windows.Forms.Label()
        Me.buttonNewSequences = New System.Windows.Forms.Button()
        Me.buttonNewThreeCells = New System.Windows.Forms.Button()
        Me.buttonNewSingleCell = New System.Windows.Forms.Button()
        Me.buttonClear = New System.Windows.Forms.Button()
        Me.buttonAddPage = New System.Windows.Forms.Button()
        Me.buttonClose = New System.Windows.Forms.Button()
        Me.imageList = New System.Windows.Forms.ImageList()
        Me.groupBox2 = New System.Windows.Forms.GroupBox()
        Me.label6 = New System.Windows.Forms.Label()
        Me.label5 = New System.Windows.Forms.Label()
        Me.label4 = New System.Windows.Forms.Label()
        Me.label2 = New System.Windows.Forms.Label()
        Me.buttonApplySingleColumn = New System.Windows.Forms.Button()
        Me.buttonApplySingleRow = New System.Windows.Forms.Button()
        Me.buttonApplyGrid = New System.Windows.Forms.Button()
        Me.buttonApplySingleCell = New System.Windows.Forms.Button()
        Me.kryptonManager1 = New Krypton.Toolkit.KryptonManager()
        CType(Me.kryptonWorkspace, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.groupBox1.SuspendLayout()
        Me.groupBox2.SuspendLayout()
        Me.SuspendLayout()
        Me.kryptonWorkspace.ActivePage = Nothing
        Me.kryptonWorkspace.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) Or System.Windows.Forms.AnchorStyles.Left) Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.kryptonWorkspace.CompactFlags = CType((((Krypton.Workspace.CompactFlags.RemoveEmptyCells Or Krypton.Workspace.CompactFlags.RemoveEmptySequences) Or Krypton.Workspace.CompactFlags.PromoteLeafs) Or Krypton.Workspace.CompactFlags.AtLeastOneVisibleCell), Krypton.Workspace.CompactFlags)
        Me.kryptonWorkspace.ContainerBackStyle = Krypton.Toolkit.PaletteBackStyle.PanelClient
        Me.kryptonWorkspace.Location = New System.Drawing.Point(265, 52)
        Me.kryptonWorkspace.Name = "kryptonWorkspace"
        Me.kryptonWorkspace.Root.Orientation = System.Windows.Forms.Orientation.Horizontal
        Me.kryptonWorkspace.Root.UniqueName = "0B1488CA488E48AFC0885C55F1E201CA"
        Me.kryptonWorkspace.Root.WorkspaceControl = Me.kryptonWorkspace
        Me.kryptonWorkspace.SeparatorStyle = Krypton.Toolkit.SeparatorStyle.LowProfile
        Me.kryptonWorkspace.Size = New System.Drawing.Size(497, 463)
        Me.kryptonWorkspace.SplitterWidth = 5
        Me.kryptonWorkspace.TabIndex = 5
        Me.kryptonWorkspace.TabStop = True
        Me.groupBox1.Controls.Add(Me.label3)
        Me.groupBox1.Controls.Add(Me.label1)
        Me.groupBox1.Controls.Add(Me.labelSingleCell)
        Me.groupBox1.Controls.Add(Me.buttonNewSequences)
        Me.groupBox1.Controls.Add(Me.buttonNewThreeCells)
        Me.groupBox1.Controls.Add(Me.buttonNewSingleCell)
        Me.groupBox1.Location = New System.Drawing.Point(12, 12)
        Me.groupBox1.Name = "groupBox1"
        Me.groupBox1.Size = New System.Drawing.Size(243, 227)
        Me.groupBox1.TabIndex = 0
        Me.groupBox1.TabStop = False
        Me.groupBox1.Text = "Example Workspaces"
        Me.label3.Location = New System.Drawing.Point(14, 170)
        Me.label3.Name = "label3"
        Me.label3.Size = New System.Drawing.Size(223, 53)
        Me.label3.TabIndex = 5
        Me.label3.Text = "Creates embedded sequences. Sequences in the place of individual cells allows eve" & "n the most complex layouts to be quickly defined." & vbCrLf
        Me.label1.Location = New System.Drawing.Point(14, 115)
        Me.label1.Name = "label1"
        Me.label1.Size = New System.Drawing.Size(223, 23)
        Me.label1.TabIndex = 3
        Me.label1.Text = "Create 3 cells positioned horizontally."
        Me.labelSingleCell.Location = New System.Drawing.Point(14, 58)
        Me.labelSingleCell.Name = "labelSingleCell"
        Me.labelSingleCell.Size = New System.Drawing.Size(223, 25)
        Me.labelSingleCell.TabIndex = 1
        Me.labelSingleCell.Text = "Create a single cell with several pages."
        Me.buttonNewSequences.Location = New System.Drawing.Point(17, 141)
        Me.buttonNewSequences.Name = "buttonNewSequences"
        Me.buttonNewSequences.Size = New System.Drawing.Size(97, 26)
        Me.buttonNewSequences.TabIndex = 4
        Me.buttonNewSequences.Text = "Sequences"
        Me.buttonNewSequences.UseVisualStyleBackColor = True
        Me.buttonNewThreeCells.Location = New System.Drawing.Point(17, 86)
        Me.buttonNewThreeCells.Name = "buttonNewThreeCells"
        Me.buttonNewThreeCells.Size = New System.Drawing.Size(97, 26)
        Me.buttonNewThreeCells.TabIndex = 2
        Me.buttonNewThreeCells.Text = "Three Cells"
        Me.buttonNewThreeCells.UseVisualStyleBackColor = True
        Me.buttonNewSingleCell.Location = New System.Drawing.Point(17, 29)
        Me.buttonNewSingleCell.Name = "buttonNewSingleCell"
        Me.buttonNewSingleCell.Size = New System.Drawing.Size(97, 26)
        Me.buttonNewSingleCell.TabIndex = 0
        Me.buttonNewSingleCell.Text = "Single Cell"
        Me.buttonNewSingleCell.UseVisualStyleBackColor = True
        Me.buttonClear.Location = New System.Drawing.Point(346, 18)
        Me.buttonClear.Name = "buttonClear"
        Me.buttonClear.Size = New System.Drawing.Size(75, 26)
        Me.buttonClear.TabIndex = 3
        Me.buttonClear.Text = "Clear"
        Me.buttonClear.UseVisualStyleBackColor = True
        Me.buttonAddPage.Location = New System.Drawing.Point(265, 18)
        Me.buttonAddPage.Name = "buttonAddPage"
        Me.buttonAddPage.Size = New System.Drawing.Size(75, 26)
        Me.buttonAddPage.TabIndex = 2
        Me.buttonAddPage.Text = "Add Page"
        Me.buttonAddPage.UseVisualStyleBackColor = True
        Me.buttonClose.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.buttonClose.Location = New System.Drawing.Point(687, 18)
        Me.buttonClose.Name = "buttonClose"
        Me.buttonClose.Size = New System.Drawing.Size(75, 26)
        Me.buttonClose.TabIndex = 4
        Me.buttonClose.Text = "Close"
        Me.buttonClose.UseVisualStyleBackColor = True
        Me.imageList.ImageStream = CType(resources.GetObject("imageList.ImageStream"), System.Windows.Forms.ImageListStreamer)
        Me.imageList.TransparentColor = System.Drawing.Color.Transparent
        Me.imageList.Images.SetKeyName(0, "alarmclock.png")
        Me.imageList.Images.SetKeyName(1, "apple.png")
        Me.imageList.Images.SetKeyName(2, "banana.png")
        Me.imageList.Images.SetKeyName(3, "baseball.png")
        Me.imageList.Images.SetKeyName(4, "die_blue.png")
        Me.imageList.Images.SetKeyName(5, "flower_yellow.png")
        Me.imageList.Images.SetKeyName(6, "hammer2.png")
        Me.imageList.Images.SetKeyName(7, "judge.png")
        Me.imageList.Images.SetKeyName(8, "lemon.png")
        Me.groupBox2.Controls.Add(Me.label6)
        Me.groupBox2.Controls.Add(Me.label5)
        Me.groupBox2.Controls.Add(Me.label4)
        Me.groupBox2.Controls.Add(Me.label2)
        Me.groupBox2.Controls.Add(Me.buttonApplySingleColumn)
        Me.groupBox2.Controls.Add(Me.buttonApplySingleRow)
        Me.groupBox2.Controls.Add(Me.buttonApplyGrid)
        Me.groupBox2.Controls.Add(Me.buttonApplySingleCell)
        Me.groupBox2.Location = New System.Drawing.Point(12, 240)
        Me.groupBox2.Name = "groupBox2"
        Me.groupBox2.Size = New System.Drawing.Size(243, 276)
        Me.groupBox2.TabIndex = 1
        Me.groupBox2.TabStop = False
        Me.groupBox2.Text = "Rearrange Workspace"
        Me.label6.Location = New System.Drawing.Point(14, 232)
        Me.label6.Name = "label6"
        Me.label6.Size = New System.Drawing.Size(223, 39)
        Me.label6.TabIndex = 7
        Me.label6.Text = "One cell per page and arranged into a grid. It tries to make the grid as square a" & "s possible."
        Me.label5.Location = New System.Drawing.Point(14, 175)
        Me.label5.Name = "label5"
        Me.label5.Size = New System.Drawing.Size(223, 25)
        Me.label5.TabIndex = 5
        Me.label5.Text = "One cell per page arranged vertically."
        Me.label4.Location = New System.Drawing.Point(13, 118)
        Me.label4.Name = "label4"
        Me.label4.Size = New System.Drawing.Size(223, 25)
        Me.label4.TabIndex = 3
        Me.label4.Text = "One cell per page arranged horizontally."
        Me.label2.Location = New System.Drawing.Point(13, 61)
        Me.label2.Name = "label2"
        Me.label2.Size = New System.Drawing.Size(223, 25)
        Me.label2.TabIndex = 1
        Me.label2.Text = "Move all pages to a single cell."
        Me.buttonApplySingleColumn.Location = New System.Drawing.Point(17, 146)
        Me.buttonApplySingleColumn.Name = "buttonApplySingleColumn"
        Me.buttonApplySingleColumn.Size = New System.Drawing.Size(90, 26)
        Me.buttonApplySingleColumn.TabIndex = 4
        Me.buttonApplySingleColumn.Text = "Single Column"
        Me.buttonApplySingleColumn.UseVisualStyleBackColor = True
        Me.buttonApplySingleRow.Location = New System.Drawing.Point(16, 89)
        Me.buttonApplySingleRow.Name = "buttonApplySingleRow"
        Me.buttonApplySingleRow.Size = New System.Drawing.Size(90, 26)
        Me.buttonApplySingleRow.TabIndex = 2
        Me.buttonApplySingleRow.Text = "Single Row"
        Me.buttonApplySingleRow.UseVisualStyleBackColor = True
        Me.buttonApplyGrid.Location = New System.Drawing.Point(17, 203)
        Me.buttonApplyGrid.Name = "buttonApplyGrid"
        Me.buttonApplyGrid.Size = New System.Drawing.Size(90, 26)
        Me.buttonApplyGrid.TabIndex = 6
        Me.buttonApplyGrid.Text = "Grid"
        Me.buttonApplyGrid.UseVisualStyleBackColor = True
        Me.buttonApplySingleCell.Location = New System.Drawing.Point(16, 32)
        Me.buttonApplySingleCell.Name = "buttonApplySingleCell"
        Me.buttonApplySingleCell.Size = New System.Drawing.Size(90, 26)
        Me.buttonApplySingleCell.TabIndex = 0
        Me.buttonApplySingleCell.Text = "Single Cell"
        Me.buttonApplySingleCell.UseVisualStyleBackColor = True
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6F, 13F)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(774, 527)
        Me.Controls.Add(Me.groupBox2)
        Me.Controls.Add(Me.buttonClose)
        Me.Controls.Add(Me.buttonClear)
        Me.Controls.Add(Me.buttonAddPage)
        Me.Controls.Add(Me.groupBox1)
        Me.Controls.Add(Me.kryptonWorkspace)
        Me.Font = New System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.MaximizeBox = False
        Me.MinimizeBox = False
        Me.MinimumSize = New System.Drawing.Size(530, 563)
        Me.Name = "Form1"
        Me.Text = "Workspace Cell Layout"
        CType(Me.kryptonWorkspace, System.ComponentModel.ISupportInitialize).EndInit()
        Me.groupBox1.ResumeLayout(False)
        Me.groupBox2.ResumeLayout(False)
        Me.ResumeLayout(False)
    End Sub

    Friend WithEvents kryptonWorkspace As Krypton.Workspace.KryptonWorkspace
    Friend WithEvents groupBox1 As System.Windows.Forms.GroupBox
    Friend WithEvents buttonClear As System.Windows.Forms.Button
    Friend WithEvents buttonAddPage As System.Windows.Forms.Button
    Friend WithEvents buttonClose As System.Windows.Forms.Button
    Friend WithEvents imageList As System.Windows.Forms.ImageList
    Friend WithEvents buttonNewSingleCell As System.Windows.Forms.Button
    Friend WithEvents groupBox2 As System.Windows.Forms.GroupBox
    Friend WithEvents buttonApplyGrid As System.Windows.Forms.Button
    Friend WithEvents buttonApplySingleCell As System.Windows.Forms.Button
    Friend WithEvents buttonNewSequences As System.Windows.Forms.Button
    Friend WithEvents buttonNewThreeCells As System.Windows.Forms.Button
    Friend WithEvents buttonApplySingleColumn As System.Windows.Forms.Button
    Friend WithEvents buttonApplySingleRow As System.Windows.Forms.Button
    Friend WithEvents label3 As System.Windows.Forms.Label
    Friend WithEvents label1 As System.Windows.Forms.Label
    Friend WithEvents labelSingleCell As System.Windows.Forms.Label
    Friend WithEvents label6 As System.Windows.Forms.Label
    Friend WithEvents label5 As System.Windows.Forms.Label
    Friend WithEvents label4 As System.Windows.Forms.Label
    Friend WithEvents label2 As System.Windows.Forms.Label
    Friend WithEvents kryptonManager1 As Krypton.Toolkit.KryptonManager
End Class
