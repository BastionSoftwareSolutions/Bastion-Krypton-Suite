' VB.NET twin of Source\Krypton Toolkit Examples\KryptonListBox Examples\Form1.Designer.cs (Bastion Phase 4c).
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
        Me.buttonClose = New System.Windows.Forms.Button()
        Me.groupBox3 = New System.Windows.Forms.GroupBox()
        Me.propertyGrid = New System.Windows.Forms.PropertyGrid()
        Me.kryptonListBox = New Krypton.Toolkit.KryptonListBox()
        Me.buttonAppend = New Krypton.Toolkit.KryptonButton()
        Me.buttonClear = New Krypton.Toolkit.KryptonButton()
        Me.buttonRemove = New Krypton.Toolkit.KryptonButton()
        Me.buttonInsert = New Krypton.Toolkit.KryptonButton()
        Me.groupBox1 = New System.Windows.Forms.GroupBox()
        Me.checkSystem = New Krypton.Toolkit.KryptonCheckButton()
        Me.checkSparkle = New Krypton.Toolkit.KryptonCheckButton()
        Me.check2010Blue = New Krypton.Toolkit.KryptonCheckButton()
        Me.check2007Blue = New Krypton.Toolkit.KryptonCheckButton()
        Me.imageList = New System.Windows.Forms.ImageList(Me.components)
        Me.kryptonCheckSet = New Krypton.Toolkit.KryptonCheckSet(Me.components)
        Me.kryptonManager1 = New Krypton.Toolkit.KryptonManager(Me.components)
        Me.groupBox3.SuspendLayout()
        Me.groupBox1.SuspendLayout()
        CType(Me.kryptonCheckSet, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        Me.buttonClose.Location = New System.Drawing.Point(493, 408)
        Me.buttonClose.Name = "buttonClose"
        Me.buttonClose.Size = New System.Drawing.Size(75, 23)
        Me.buttonClose.TabIndex = 3
        Me.buttonClose.Text = "Close"
        Me.buttonClose.UseVisualStyleBackColor = True
        Me.groupBox3.Controls.Add(Me.propertyGrid)
        Me.groupBox3.Location = New System.Drawing.Point(273, 12)
        Me.groupBox3.Name = "groupBox3"
        Me.groupBox3.Size = New System.Drawing.Size(295, 390)
        Me.groupBox3.TabIndex = 2
        Me.groupBox3.TabStop = False
        Me.groupBox3.Text = "Properties for KryptonListBox"
        Me.propertyGrid.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) Or System.Windows.Forms.AnchorStyles.Left) Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.propertyGrid.Location = New System.Drawing.Point(6, 19)
        Me.propertyGrid.Name = "propertyGrid"
        Me.propertyGrid.Size = New System.Drawing.Size(283, 365)
        Me.propertyGrid.TabIndex = 0
        Me.propertyGrid.ToolbarVisible = False
        Me.kryptonListBox.Location = New System.Drawing.Point(23, 24)
        Me.kryptonListBox.Name = "kryptonListBox"
        Me.kryptonListBox.Size = New System.Drawing.Size(227, 192)
        Me.kryptonListBox.TabIndex = 0
        Me.buttonAppend.AutoSize = True
        Me.buttonAppend.Location = New System.Drawing.Point(19, 30)
        Me.buttonAppend.Name = "buttonAppend"
        Me.buttonAppend.Size = New System.Drawing.Size(90, 25)
        Me.buttonAppend.TabIndex = 0
        Me.buttonAppend.Values.Text = "Append"
        Me.buttonClear.AutoSize = True
        Me.buttonClear.Location = New System.Drawing.Point(19, 126)
        Me.buttonClear.Name = "buttonClear"
        Me.buttonClear.Size = New System.Drawing.Size(90, 25)
        Me.buttonClear.TabIndex = 3
        Me.buttonClear.Values.Text = "Clear"
        Me.buttonRemove.AutoSize = True
        Me.buttonRemove.Location = New System.Drawing.Point(19, 94)
        Me.buttonRemove.Name = "buttonRemove"
        Me.buttonRemove.Size = New System.Drawing.Size(90, 25)
        Me.buttonRemove.TabIndex = 2
        Me.buttonRemove.Values.Text = "Remove"
        Me.buttonInsert.AutoSize = True
        Me.buttonInsert.Location = New System.Drawing.Point(19, 62)
        Me.buttonInsert.Name = "buttonInsert"
        Me.buttonInsert.Size = New System.Drawing.Size(90, 25)
        Me.buttonInsert.TabIndex = 1
        Me.buttonInsert.Values.Text = "Insert"
        Me.groupBox1.Controls.Add(Me.checkSystem)
        Me.groupBox1.Controls.Add(Me.checkSparkle)
        Me.groupBox1.Controls.Add(Me.check2010Blue)
        Me.groupBox1.Controls.Add(Me.check2007Blue)
        Me.groupBox1.Controls.Add(Me.buttonAppend)
        Me.groupBox1.Controls.Add(Me.buttonInsert)
        Me.groupBox1.Controls.Add(Me.buttonClear)
        Me.groupBox1.Controls.Add(Me.buttonRemove)
        Me.groupBox1.Location = New System.Drawing.Point(12, 234)
        Me.groupBox1.Name = "groupBox1"
        Me.groupBox1.Size = New System.Drawing.Size(249, 168)
        Me.groupBox1.TabIndex = 1
        Me.groupBox1.TabStop = False
        Me.groupBox1.Text = "Actions"
        Me.checkSystem.AutoSize = True
        Me.checkSystem.Location = New System.Drawing.Point(125, 126)
        Me.checkSystem.Name = "checkSystem"
        Me.checkSystem.Size = New System.Drawing.Size(113, 25)
        Me.checkSystem.TabIndex = 7
        Me.checkSystem.Values.Text = "System"
        Me.checkSparkle.AutoSize = True
        Me.checkSparkle.Location = New System.Drawing.Point(125, 93)
        Me.checkSparkle.Name = "checkSparkle"
        Me.checkSparkle.Size = New System.Drawing.Size(113, 25)
        Me.checkSparkle.TabIndex = 6
        Me.checkSparkle.Values.Text = "Sparkle - Blue"
        Me.check2010Blue.AutoSize = True
        Me.check2010Blue.Checked = True
        Me.check2010Blue.Location = New System.Drawing.Point(125, 31)
        Me.check2010Blue.Name = "check2010Blue"
        Me.check2010Blue.Size = New System.Drawing.Size(113, 25)
        Me.check2010Blue.TabIndex = 5
        Me.check2010Blue.Values.Text = "Office 2010 - Black"
        Me.check2007Blue.AutoSize = True
        Me.check2007Blue.Location = New System.Drawing.Point(125, 62)
        Me.check2007Blue.Name = "check2007Blue"
        Me.check2007Blue.Size = New System.Drawing.Size(113, 25)
        Me.check2007Blue.TabIndex = 4
        Me.check2007Blue.Values.Text = "Office 2007 - Blue"
        Me.imageList.ImageStream = CType(resources.GetObject("imageList.ImageStream"), System.Windows.Forms.ImageListStreamer)
        Me.imageList.TransparentColor = System.Drawing.Color.Transparent
        Me.imageList.Images.SetKeyName(0, "document_plain.png")
        Me.imageList.Images.SetKeyName(1, "document_plain_blue.png")
        Me.imageList.Images.SetKeyName(2, "document_plain_green.png")
        Me.imageList.Images.SetKeyName(3, "document_plain_red.png")
        Me.imageList.Images.SetKeyName(4, "document_plain_yellow.png")
        Me.imageList.Images.SetKeyName(5, "star_blue.png")
        Me.imageList.Images.SetKeyName(6, "star_green.png")
        Me.imageList.Images.SetKeyName(7, "star_grey.png")
        Me.imageList.Images.SetKeyName(8, "star_red.png")
        Me.imageList.Images.SetKeyName(9, "star_yellow.png")
        Me.imageList.Images.SetKeyName(10, "telephone.png")
        Me.imageList.Images.SetKeyName(11, "telephone2.png")
        Me.imageList.Images.SetKeyName(12, "thought.png")
        Me.imageList.Images.SetKeyName(13, "alarmclock.png")
        Me.imageList.Images.SetKeyName(14, "apple.png")
        Me.imageList.Images.SetKeyName(15, "banana.png")
        Me.imageList.Images.SetKeyName(16, "basketball.png")
        Me.imageList.Images.SetKeyName(17, "binocular.png")
        Me.imageList.Images.SetKeyName(18, "clock2.png")
        Me.kryptonCheckSet.CheckButtons.Add(Me.check2007Blue)
        Me.kryptonCheckSet.CheckButtons.Add(Me.check2010Blue)
        Me.kryptonCheckSet.CheckButtons.Add(Me.checkSparkle)
        Me.kryptonCheckSet.CheckButtons.Add(Me.checkSystem)
        Me.kryptonCheckSet.CheckedButton = Me.check2010Blue
        Me.kryptonManager1.GlobalPaletteMode = Krypton.Toolkit.PaletteMode.Office2010Blue
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6F, 13F)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(575, 438)
        Me.Controls.Add(Me.groupBox1)
        Me.Controls.Add(Me.kryptonListBox)
        Me.Controls.Add(Me.buttonClose)
        Me.Controls.Add(Me.groupBox3)
        Me.Font = New System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.MaximizeBox = False
        Me.MinimizeBox = False
        Me.Name = "Form1"
        Me.Text = "KryptonListBox Examples"
        Me.groupBox3.ResumeLayout(False)
        Me.groupBox1.ResumeLayout(False)
        Me.groupBox1.PerformLayout()
        CType(Me.kryptonCheckSet, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
    End Sub

    Friend WithEvents buttonClose As System.Windows.Forms.Button
    Friend WithEvents groupBox3 As System.Windows.Forms.GroupBox
    Friend WithEvents propertyGrid As System.Windows.Forms.PropertyGrid
    Friend WithEvents kryptonListBox As Krypton.Toolkit.KryptonListBox
    Friend WithEvents buttonAppend As Krypton.Toolkit.KryptonButton
    Friend WithEvents buttonClear As Krypton.Toolkit.KryptonButton
    Friend WithEvents buttonRemove As Krypton.Toolkit.KryptonButton
    Friend WithEvents buttonInsert As Krypton.Toolkit.KryptonButton
    Friend WithEvents groupBox1 As System.Windows.Forms.GroupBox
    Friend WithEvents imageList As System.Windows.Forms.ImageList
    Friend WithEvents checkSystem As Krypton.Toolkit.KryptonCheckButton
    Friend WithEvents checkSparkle As Krypton.Toolkit.KryptonCheckButton
    Friend WithEvents check2010Blue As Krypton.Toolkit.KryptonCheckButton
    Friend WithEvents check2007Blue As Krypton.Toolkit.KryptonCheckButton
    Friend WithEvents kryptonCheckSet As Krypton.Toolkit.KryptonCheckSet
    Friend WithEvents kryptonManager1 As Krypton.Toolkit.KryptonManager
End Class
