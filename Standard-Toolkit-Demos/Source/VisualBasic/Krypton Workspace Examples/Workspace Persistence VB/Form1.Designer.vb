' VB.NET twin of Source\Krypton Workspace Examples\Workspace Persistence\Form1.Designer.cs (Bastion Phase 4c).
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
        Me.buttonClearPages = New System.Windows.Forms.Button()
        Me.buttonAddPage = New System.Windows.Forms.Button()
        Me.kryptonWorkspace = New Krypton.Workspace.KryptonWorkspace()
        Me.buttonClose = New System.Windows.Forms.Button()
        Me.imageList = New System.Windows.Forms.ImageList(Me.components)
        Me.groupBox1 = New System.Windows.Forms.GroupBox()
        Me.label1 = New System.Windows.Forms.Label()
        Me.bLoadFromArray = New System.Windows.Forms.Button()
        Me.bSaveToArray = New System.Windows.Forms.Button()
        Me.groupBox2 = New System.Windows.Forms.GroupBox()
        Me.label2 = New System.Windows.Forms.Label()
        Me.bLoadFromFile = New System.Windows.Forms.Button()
        Me.bSaveToFile = New System.Windows.Forms.Button()
        Me.saveFileDialog = New System.Windows.Forms.SaveFileDialog()
        Me.openFileDialog = New System.Windows.Forms.OpenFileDialog()
        Me.kryptonManager1 = New Krypton.Toolkit.KryptonManager(Me.components)
        CType(Me.kryptonWorkspace, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.groupBox1.SuspendLayout()
        Me.groupBox2.SuspendLayout()
        Me.SuspendLayout()
        Me.buttonClearPages.Location = New System.Drawing.Point(389, 12)
        Me.buttonClearPages.Name = "buttonClearPages"
        Me.buttonClearPages.Size = New System.Drawing.Size(75, 26)
        Me.buttonClearPages.TabIndex = 3
        Me.buttonClearPages.Text = "Clear Pages"
        Me.buttonClearPages.UseVisualStyleBackColor = True
        Me.buttonAddPage.Location = New System.Drawing.Point(308, 12)
        Me.buttonAddPage.Name = "buttonAddPage"
        Me.buttonAddPage.Size = New System.Drawing.Size(75, 26)
        Me.buttonAddPage.TabIndex = 2
        Me.buttonAddPage.Text = "Add Page"
        Me.buttonAddPage.UseVisualStyleBackColor = True
        Me.kryptonWorkspace.ActivePage = Nothing
        Me.kryptonWorkspace.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) Or System.Windows.Forms.AnchorStyles.Left) Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.kryptonWorkspace.CompactFlags = CType((((Krypton.Workspace.CompactFlags.RemoveEmptyCells Or Krypton.Workspace.CompactFlags.RemoveEmptySequences) Or Krypton.Workspace.CompactFlags.PromoteLeafs) Or Krypton.Workspace.CompactFlags.AtLeastOneVisibleCell), Krypton.Workspace.CompactFlags)
        Me.kryptonWorkspace.ContainerBackStyle = Krypton.Toolkit.PaletteBackStyle.PanelClient
        Me.kryptonWorkspace.Location = New System.Drawing.Point(308, 48)
        Me.kryptonWorkspace.Name = "kryptonWorkspace"
        Me.kryptonWorkspace.Root.Orientation = System.Windows.Forms.Orientation.Horizontal
        Me.kryptonWorkspace.Root.UniqueName = "BF526855C8FB4541BF526855C8FB4541"
        Me.kryptonWorkspace.Root.WorkspaceControl = Me.kryptonWorkspace
        Me.kryptonWorkspace.SeparatorStyle = Krypton.Toolkit.SeparatorStyle.LowProfile
        Me.kryptonWorkspace.Size = New System.Drawing.Size(464, 404)
        Me.kryptonWorkspace.SplitterWidth = 5
        Me.kryptonWorkspace.TabIndex = 4
        Me.kryptonWorkspace.TabStop = True
        Me.buttonClose.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.buttonClose.Location = New System.Drawing.Point(697, 12)
        Me.buttonClose.Name = "buttonClose"
        Me.buttonClose.Size = New System.Drawing.Size(75, 26)
        Me.buttonClose.TabIndex = 5
        Me.buttonClose.Text = "Close"
        Me.buttonClose.UseVisualStyleBackColor = True
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
        Me.groupBox1.Controls.Add(Me.label1)
        Me.groupBox1.Controls.Add(Me.bLoadFromArray)
        Me.groupBox1.Controls.Add(Me.bSaveToArray)
        Me.groupBox1.Location = New System.Drawing.Point(12, 12)
        Me.groupBox1.Name = "groupBox1"
        Me.groupBox1.Size = New System.Drawing.Size(275, 183)
        Me.groupBox1.TabIndex = 0
        Me.groupBox1.TabStop = False
        Me.groupBox1.Text = "Persist to Array of Bytes"
        Me.label1.Location = New System.Drawing.Point(20, 76)
        Me.label1.Name = "label1"
        Me.label1.Size = New System.Drawing.Size(233, 99)
        Me.label1.TabIndex = 2
        Me.label1.Text = "Persisting to/from a byte array is useful when you only need to keep data for the" & " duration of your application. " & vbCrLf & vbCrLf & "Also great for persisting to and from a datab" & "ase for use between user sessions."
        Me.bLoadFromArray.Enabled = False
        Me.bLoadFromArray.Location = New System.Drawing.Point(141, 29)
        Me.bLoadFromArray.Name = "bLoadFromArray"
        Me.bLoadFromArray.Size = New System.Drawing.Size(112, 34)
        Me.bLoadFromArray.TabIndex = 1
        Me.bLoadFromArray.Text = "Load from Array"
        Me.bLoadFromArray.UseVisualStyleBackColor = True
        Me.bSaveToArray.Location = New System.Drawing.Point(23, 29)
        Me.bSaveToArray.Name = "bSaveToArray"
        Me.bSaveToArray.Size = New System.Drawing.Size(112, 34)
        Me.bSaveToArray.TabIndex = 0
        Me.bSaveToArray.Text = "Save to Array"
        Me.bSaveToArray.UseVisualStyleBackColor = True
        Me.groupBox2.Controls.Add(Me.label2)
        Me.groupBox2.Controls.Add(Me.bLoadFromFile)
        Me.groupBox2.Controls.Add(Me.bSaveToFile)
        Me.groupBox2.Location = New System.Drawing.Point(13, 202)
        Me.groupBox2.Name = "groupBox2"
        Me.groupBox2.Size = New System.Drawing.Size(275, 143)
        Me.groupBox2.TabIndex = 1
        Me.groupBox2.TabStop = False
        Me.groupBox2.Text = "Persist to File (XML)"
        Me.label2.Location = New System.Drawing.Point(21, 73)
        Me.label2.Name = "label2"
        Me.label2.Size = New System.Drawing.Size(233, 63)
        Me.label2.TabIndex = 2
        Me.label2.Text = "Using files for storage allows you to persist the layout when you application exi" & "ts in order to restore it at the next startup."
        Me.bLoadFromFile.Location = New System.Drawing.Point(142, 26)
        Me.bLoadFromFile.Name = "bLoadFromFile"
        Me.bLoadFromFile.Size = New System.Drawing.Size(112, 34)
        Me.bLoadFromFile.TabIndex = 1
        Me.bLoadFromFile.Text = "Load from File"
        Me.bLoadFromFile.UseVisualStyleBackColor = True
        Me.bSaveToFile.Location = New System.Drawing.Point(24, 26)
        Me.bSaveToFile.Name = "bSaveToFile"
        Me.bSaveToFile.Size = New System.Drawing.Size(112, 34)
        Me.bSaveToFile.TabIndex = 0
        Me.bSaveToFile.Text = "Save to File"
        Me.bSaveToFile.UseVisualStyleBackColor = True
        Me.saveFileDialog.DefaultExt = "xml"
        Me.saveFileDialog.FileName = "example.xml"
        Me.saveFileDialog.Filter = "XML files|*.xml"
        Me.saveFileDialog.Title = "Save Workspace Layout"
        Me.openFileDialog.DefaultExt = "xml"
        Me.openFileDialog.FileName = "example.xml"
        Me.openFileDialog.Filter = "XML files|*.xml"
        Me.openFileDialog.Title = "Load Workspace Layout"
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6F, 13F)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(784, 464)
        Me.Controls.Add(Me.groupBox2)
        Me.Controls.Add(Me.groupBox1)
        Me.Controls.Add(Me.buttonClose)
        Me.Controls.Add(Me.buttonClearPages)
        Me.Controls.Add(Me.buttonAddPage)
        Me.Controls.Add(Me.kryptonWorkspace)
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.MaximizeBox = False
        Me.MinimizeBox = False
        Me.MinimumSize = New System.Drawing.Size(608, 432)
        Me.Name = "Form1"
        Me.Text = "Workspace Persistence"
        CType(Me.kryptonWorkspace, System.ComponentModel.ISupportInitialize).EndInit()
        Me.groupBox1.ResumeLayout(False)
        Me.groupBox2.ResumeLayout(False)
        Me.ResumeLayout(False)
    End Sub

    Friend WithEvents buttonClearPages As System.Windows.Forms.Button
    Friend WithEvents buttonAddPage As System.Windows.Forms.Button
    Friend WithEvents kryptonWorkspace As Krypton.Workspace.KryptonWorkspace
    Friend WithEvents buttonClose As System.Windows.Forms.Button
    Friend WithEvents imageList As System.Windows.Forms.ImageList
    Friend WithEvents groupBox1 As System.Windows.Forms.GroupBox
    Friend WithEvents bLoadFromArray As System.Windows.Forms.Button
    Friend WithEvents bSaveToArray As System.Windows.Forms.Button
    Friend WithEvents label1 As System.Windows.Forms.Label
    Friend WithEvents groupBox2 As System.Windows.Forms.GroupBox
    Friend WithEvents label2 As System.Windows.Forms.Label
    Friend WithEvents bLoadFromFile As System.Windows.Forms.Button
    Friend WithEvents bSaveToFile As System.Windows.Forms.Button
    Friend WithEvents saveFileDialog As System.Windows.Forms.SaveFileDialog
    Friend WithEvents openFileDialog As System.Windows.Forms.OpenFileDialog
    Friend WithEvents kryptonManager1 As Krypton.Toolkit.KryptonManager
End Class
