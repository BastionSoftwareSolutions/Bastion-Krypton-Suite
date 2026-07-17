' VB.NET twin of Source\Krypton Toolkit Examples\KryptonCommand Examples\Form1.Designer.cs (Bastion Phase 4c).
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
        Me.buttonClose = New System.Windows.Forms.Button()
        Me.groupBoxProperties = New System.Windows.Forms.GroupBox()
        Me.propertyGrid = New System.Windows.Forms.PropertyGrid()
        Me.kryptonCommand = New Krypton.Toolkit.KryptonCommand()
        Me.groupBoxControls = New System.Windows.Forms.GroupBox()
        Me.kryptonDropButton1 = New Krypton.Toolkit.KryptonDropButton()
        Me.kryptonHeader1 = New Krypton.Toolkit.KryptonHeader()
        Me.buttonSpecAny1 = New Krypton.Toolkit.ButtonSpecAny()
        Me.kryptonColorButton1 = New Krypton.Toolkit.KryptonColorButton()
        Me.kryptonLinkLabel1 = New Krypton.Toolkit.KryptonLinkLabel()
        Me.kryptonLabel1 = New Krypton.Toolkit.KryptonLabel()
        Me.kryptonCheckBox1 = New Krypton.Toolkit.KryptonCheckBox()
        Me.kryptonCheckButton1 = New Krypton.Toolkit.KryptonCheckButton()
        Me.kryptonButton1 = New Krypton.Toolkit.KryptonButton()
        Me.buttonAttach = New System.Windows.Forms.Button()
        Me.buttonUnattach = New System.Windows.Forms.Button()
        Me.groupBoxProperties.SuspendLayout()
        Me.groupBoxControls.SuspendLayout()
        Me.SuspendLayout()
        Me.buttonClose.DialogResult = System.Windows.Forms.DialogResult.Cancel
        Me.buttonClose.Location = New System.Drawing.Point(360, 514)
        Me.buttonClose.Name = "buttonClose"
        Me.buttonClose.Size = New System.Drawing.Size(75, 26)
        Me.buttonClose.TabIndex = 2
        Me.buttonClose.Text = "Close"
        Me.buttonClose.UseVisualStyleBackColor = True
        Me.groupBoxProperties.Controls.Add(Me.propertyGrid)
        Me.groupBoxProperties.Location = New System.Drawing.Point(13, 13)
        Me.groupBoxProperties.Name = "groupBoxProperties"
        Me.groupBoxProperties.Padding = New System.Windows.Forms.Padding(10)
        Me.groupBoxProperties.Size = New System.Drawing.Size(422, 259)
        Me.groupBoxProperties.TabIndex = 3
        Me.groupBoxProperties.TabStop = False
        Me.groupBoxProperties.Text = "Properties for KryptonCommand"
        Me.propertyGrid.Dock = System.Windows.Forms.DockStyle.Fill
        Me.propertyGrid.HelpVisible = False
        Me.propertyGrid.Location = New System.Drawing.Point(10, 24)
        Me.propertyGrid.Name = "propertyGrid"
        Me.propertyGrid.SelectedObject = Me.kryptonCommand
        Me.propertyGrid.Size = New System.Drawing.Size(402, 225)
        Me.propertyGrid.TabIndex = 0
        Me.propertyGrid.ToolbarVisible = False
        Me.kryptonCommand.Checked = True
        Me.kryptonCommand.CheckState = System.Windows.Forms.CheckState.Indeterminate
        Me.kryptonCommand.ExtraText = "Extra"
        Me.kryptonCommand.ImageLarge = CType(resources.GetObject("kryptonCommand.ImageLarge"), System.Drawing.Image)
        Me.kryptonCommand.ImageSmall = CType(resources.GetObject("kryptonCommand.ImageSmall"), System.Drawing.Image)
        Me.kryptonCommand.Text = "Text"
        Me.groupBoxControls.Controls.Add(Me.kryptonDropButton1)
        Me.groupBoxControls.Controls.Add(Me.kryptonHeader1)
        Me.groupBoxControls.Controls.Add(Me.kryptonColorButton1)
        Me.groupBoxControls.Controls.Add(Me.kryptonLinkLabel1)
        Me.groupBoxControls.Controls.Add(Me.kryptonLabel1)
        Me.groupBoxControls.Controls.Add(Me.kryptonCheckBox1)
        Me.groupBoxControls.Controls.Add(Me.kryptonCheckButton1)
        Me.groupBoxControls.Controls.Add(Me.kryptonButton1)
        Me.groupBoxControls.Location = New System.Drawing.Point(13, 279)
        Me.groupBoxControls.Name = "groupBoxControls"
        Me.groupBoxControls.Size = New System.Drawing.Size(422, 225)
        Me.groupBoxControls.TabIndex = 4
        Me.groupBoxControls.TabStop = False
        Me.groupBoxControls.Text = "Controls attached to KryptonCommand"
        Me.kryptonDropButton1.AutoSize = True
        Me.kryptonDropButton1.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowOnly
        Me.kryptonDropButton1.ButtonOrientation = Krypton.Toolkit.VisualOrientation.Top
        Me.kryptonDropButton1.DialogResult = System.Windows.Forms.DialogResult.None
        Me.kryptonDropButton1.DropDownOrientation = Krypton.Toolkit.VisualOrientation.Bottom
        Me.kryptonDropButton1.DropDownPosition = Krypton.Toolkit.VisualOrientation.Right
        Me.kryptonDropButton1.Location = New System.Drawing.Point(19, 103)
        Me.kryptonDropButton1.Name = "kryptonDropButton1"
        Me.kryptonDropButton1.Size = New System.Drawing.Size(136, 25)
        Me.kryptonDropButton1.TabIndex = 2
        Me.kryptonDropButton1.Values.Text = "DropButton"
        Me.kryptonHeader1.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowOnly
        Me.kryptonHeader1.ButtonSpecs.AddRange(New Krypton.Toolkit.ButtonSpecAny() { Me.buttonSpecAny1})
        Me.kryptonHeader1.Location = New System.Drawing.Point(19, 165)
        Me.kryptonHeader1.Name = "kryptonHeader1"
        Me.kryptonHeader1.Orientation = Krypton.Toolkit.VisualOrientation.Top
        Me.kryptonHeader1.Size = New System.Drawing.Size(170, 31)
        Me.kryptonHeader1.TabIndex = 4
        Me.kryptonHeader1.Values.Description = ""
        Me.kryptonHeader1.Values.Heading = "Header"
        Me.buttonSpecAny1.Text = "ButtonSpec"
        Me.buttonSpecAny1.UniqueName = "BC4FEDE1ECC34E64BC4FEDE1ECC34E64"
        Me.kryptonColorButton1.AutoSize = True
        Me.kryptonColorButton1.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowOnly
        Me.kryptonColorButton1.ButtonOrientation = Krypton.Toolkit.VisualOrientation.Top
        Me.kryptonColorButton1.DialogResult = System.Windows.Forms.DialogResult.None
        Me.kryptonColorButton1.DropDownOrientation = Krypton.Toolkit.VisualOrientation.Bottom
        Me.kryptonColorButton1.DropDownPosition = Krypton.Toolkit.VisualOrientation.Right
        Me.kryptonColorButton1.EmptyBorderColor = System.Drawing.Color.DarkGray
        Me.kryptonColorButton1.Location = New System.Drawing.Point(19, 134)
        Me.kryptonColorButton1.Name = "kryptonColorButton1"
        Me.kryptonColorButton1.SchemeStandard = Krypton.Toolkit.ColorScheme.OfficeStandard
        Me.kryptonColorButton1.SchemeThemes = Krypton.Toolkit.ColorScheme.OfficeThemes
        Me.kryptonColorButton1.SelectedColor = System.Drawing.Color.Red
        Me.kryptonColorButton1.SelectedRect = New System.Drawing.Rectangle(0, 12, 16, 4)
        Me.kryptonColorButton1.Size = New System.Drawing.Size(136, 25)
        Me.kryptonColorButton1.TabIndex = 3
        Me.kryptonColorButton1.Values.Text = "ColorButton"
        Me.kryptonLinkLabel1.Location = New System.Drawing.Point(256, 72)
        Me.kryptonLinkLabel1.Name = "kryptonLinkLabel1"
        Me.kryptonLinkLabel1.Size = New System.Drawing.Size(61, 20)
        Me.kryptonLinkLabel1.TabIndex = 6
        Me.kryptonLinkLabel1.Values.Text = "LinkLabel"
        Me.kryptonLabel1.Location = New System.Drawing.Point(256, 41)
        Me.kryptonLabel1.Name = "kryptonLabel1"
        Me.kryptonLabel1.Size = New System.Drawing.Size(39, 20)
        Me.kryptonLabel1.TabIndex = 5
        Me.kryptonCheckBox1.CheckPosition = Krypton.Toolkit.VisualOrientation.Left
        Me.kryptonCheckBox1.CheckState = System.Windows.Forms.CheckState.Unchecked
        Me.kryptonCheckBox1.Location = New System.Drawing.Point(261, 103)
        Me.kryptonCheckBox1.Name = "kryptonCheckBox1"
        Me.kryptonCheckBox1.Orientation = Krypton.Toolkit.VisualOrientation.Top
        Me.kryptonCheckBox1.Size = New System.Drawing.Size(76, 20)
        Me.kryptonCheckBox1.TabIndex = 7
        Me.kryptonCheckBox1.Values.Text = "CheckBox"
        Me.kryptonCheckButton1.AutoSize = True
        Me.kryptonCheckButton1.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowOnly
        Me.kryptonCheckButton1.DialogResult = System.Windows.Forms.DialogResult.None
        Me.kryptonCheckButton1.Location = New System.Drawing.Point(19, 72)
        Me.kryptonCheckButton1.Name = "kryptonCheckButton1"
        Me.kryptonCheckButton1.Orientation = Krypton.Toolkit.VisualOrientation.Top
        Me.kryptonCheckButton1.Size = New System.Drawing.Size(122, 25)
        Me.kryptonCheckButton1.TabIndex = 1
        Me.kryptonCheckButton1.Values.Text = "CheckButton"
        Me.kryptonButton1.AutoSize = True
        Me.kryptonButton1.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowOnly
        Me.kryptonButton1.DialogResult = System.Windows.Forms.DialogResult.None
        Me.kryptonButton1.Location = New System.Drawing.Point(19, 41)
        Me.kryptonButton1.Name = "kryptonButton1"
        Me.kryptonButton1.Orientation = Krypton.Toolkit.VisualOrientation.Top
        Me.kryptonButton1.Size = New System.Drawing.Size(122, 25)
        Me.kryptonButton1.TabIndex = 0
        Me.buttonAttach.Location = New System.Drawing.Point(13, 514)
        Me.buttonAttach.Name = "buttonAttach"
        Me.buttonAttach.Size = New System.Drawing.Size(159, 26)
        Me.buttonAttach.TabIndex = 0
        Me.buttonAttach.Text = "Attach KryptonCommand"
        Me.buttonAttach.UseVisualStyleBackColor = True
        Me.buttonUnattach.Location = New System.Drawing.Point(178, 514)
        Me.buttonUnattach.Name = "buttonUnattach"
        Me.buttonUnattach.Size = New System.Drawing.Size(75, 26)
        Me.buttonUnattach.TabIndex = 1
        Me.buttonUnattach.Text = "Unattach"
        Me.buttonUnattach.UseVisualStyleBackColor = True
        Me.AcceptButton = Me.buttonAttach
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6F, 13F)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.CancelButton = Me.buttonClose
        Me.ClientSize = New System.Drawing.Size(446, 553)
        Me.Controls.Add(Me.buttonUnattach)
        Me.Controls.Add(Me.buttonAttach)
        Me.Controls.Add(Me.groupBoxControls)
        Me.Controls.Add(Me.groupBoxProperties)
        Me.Controls.Add(Me.buttonClose)
        Me.Font = New System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.MaximizeBox = False
        Me.MinimizeBox = False
        Me.Name = "Form1"
        Me.Text = "KryptonCommand Examples"
        Me.groupBoxProperties.ResumeLayout(False)
        Me.groupBoxControls.ResumeLayout(False)
        Me.groupBoxControls.PerformLayout()
        Me.ResumeLayout(False)
    End Sub

    Friend WithEvents buttonClose As System.Windows.Forms.Button
    Friend WithEvents groupBoxProperties As System.Windows.Forms.GroupBox
    Friend WithEvents propertyGrid As System.Windows.Forms.PropertyGrid
    Friend WithEvents groupBoxControls As System.Windows.Forms.GroupBox
    Friend WithEvents kryptonLinkLabel1 As Krypton.Toolkit.KryptonLinkLabel
    Friend WithEvents kryptonLabel1 As Krypton.Toolkit.KryptonLabel
    Friend WithEvents kryptonCheckBox1 As Krypton.Toolkit.KryptonCheckBox
    Friend WithEvents kryptonCheckButton1 As Krypton.Toolkit.KryptonCheckButton
    Friend WithEvents kryptonButton1 As Krypton.Toolkit.KryptonButton
    Friend WithEvents kryptonCommand As Krypton.Toolkit.KryptonCommand
    Friend WithEvents kryptonDropButton1 As Krypton.Toolkit.KryptonDropButton
    Friend WithEvents kryptonHeader1 As Krypton.Toolkit.KryptonHeader
    Friend WithEvents kryptonColorButton1 As Krypton.Toolkit.KryptonColorButton
    Friend WithEvents buttonSpecAny1 As Krypton.Toolkit.ButtonSpecAny
    Friend WithEvents buttonAttach As System.Windows.Forms.Button
    Friend WithEvents buttonUnattach As System.Windows.Forms.Button
End Class
