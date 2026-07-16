' VB.NET twin of Source\Krypton Toolkit Examples\KryptonWrapLabel Examples\Form1.Designer.cs (Bastion Phase 4c).
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
        Me.groupBox3 = New System.Windows.Forms.GroupBox()
        Me.propertyGrid = New System.Windows.Forms.PropertyGrid()
        Me.buttonClose = New System.Windows.Forms.Button()
        Me.groupBox1 = New System.Windows.Forms.GroupBox()
        Me.groupBox2 = New System.Windows.Forms.GroupBox()
        Me.buttonTitle = New System.Windows.Forms.Button()
        Me.buttonNormal = New System.Windows.Forms.Button()
        Me.kryptonGroupBox2 = New Krypton.Toolkit.KryptonGroupBox()
        Me.kpgLinkWrappedLabel = New Krypton.Toolkit.KryptonPropertyGrid()
        Me.klwlblTest = New Krypton.Toolkit.KryptonLinkWrapLabel()
        Me.kryptonGroupBox1 = New Krypton.Toolkit.KryptonGroupBox()
        Me.kryptonWrapLabel = New Krypton.Toolkit.KryptonWrapLabel()
        Me.groupBox3.SuspendLayout()
        Me.groupBox1.SuspendLayout()
        Me.groupBox2.SuspendLayout()
        CType(Me.kryptonGroupBox2, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.kryptonGroupBox2.Panel, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.kryptonGroupBox2.Panel.SuspendLayout()
        Me.kryptonGroupBox2.SuspendLayout()
        CType(Me.kryptonGroupBox1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.kryptonGroupBox1.Panel, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.kryptonGroupBox1.Panel.SuspendLayout()
        Me.kryptonGroupBox1.SuspendLayout()
        Me.SuspendLayout()
        Me.groupBox3.Controls.Add(Me.propertyGrid)
        Me.groupBox3.Location = New System.Drawing.Point(263, 12)
        Me.groupBox3.Name = "groupBox3"
        Me.groupBox3.Size = New System.Drawing.Size(318, 307)
        Me.groupBox3.TabIndex = 2
        Me.groupBox3.TabStop = False
        Me.groupBox3.Text = "Properties for KryptonWrapLabel"
        Me.propertyGrid.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) Or System.Windows.Forms.AnchorStyles.Left) Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.propertyGrid.HelpVisible = False
        Me.propertyGrid.Location = New System.Drawing.Point(6, 19)
        Me.propertyGrid.Name = "propertyGrid"
        Me.propertyGrid.Size = New System.Drawing.Size(306, 282)
        Me.propertyGrid.TabIndex = 0
        Me.propertyGrid.ToolbarVisible = False
        Me.buttonClose.Location = New System.Drawing.Point(500, 627)
        Me.buttonClose.Name = "buttonClose"
        Me.buttonClose.Size = New System.Drawing.Size(75, 23)
        Me.buttonClose.TabIndex = 3
        Me.buttonClose.Text = "Close"
        Me.buttonClose.UseVisualStyleBackColor = True
        Me.groupBox1.Controls.Add(Me.kryptonWrapLabel)
        Me.groupBox1.Location = New System.Drawing.Point(12, 12)
        Me.groupBox1.Name = "groupBox1"
        Me.groupBox1.Size = New System.Drawing.Size(241, 223)
        Me.groupBox1.TabIndex = 0
        Me.groupBox1.TabStop = False
        Me.groupBox1.Text = "KryptonWrapLabel"
        Me.groupBox2.Controls.Add(Me.buttonTitle)
        Me.groupBox2.Controls.Add(Me.buttonNormal)
        Me.groupBox2.Location = New System.Drawing.Point(12, 241)
        Me.groupBox2.Name = "groupBox2"
        Me.groupBox2.Size = New System.Drawing.Size(241, 78)
        Me.groupBox2.TabIndex = 1
        Me.groupBox2.TabStop = False
        Me.groupBox2.Text = "LabelStyles"
        Me.buttonTitle.Location = New System.Drawing.Point(136, 30)
        Me.buttonTitle.Name = "buttonTitle"
        Me.buttonTitle.Size = New System.Drawing.Size(75, 28)
        Me.buttonTitle.TabIndex = 1
        Me.buttonTitle.Text = "Title"
        Me.buttonTitle.UseVisualStyleBackColor = True
        Me.buttonNormal.Location = New System.Drawing.Point(32, 30)
        Me.buttonNormal.Name = "buttonNormal"
        Me.buttonNormal.Size = New System.Drawing.Size(75, 28)
        Me.buttonNormal.TabIndex = 0
        Me.buttonNormal.Text = "Normal"
        Me.buttonNormal.UseVisualStyleBackColor = True
        Me.kryptonGroupBox2.CaptionStyle = Krypton.Toolkit.LabelStyle.GroupBoxCaption
        Me.kryptonGroupBox2.GroupBackStyle = Krypton.Toolkit.PaletteBackStyle.ControlGroupBox
        Me.kryptonGroupBox2.GroupBorderStyle = Krypton.Toolkit.PaletteBorderStyle.ControlGroupBox
        Me.kryptonGroupBox2.Location = New System.Drawing.Point(269, 325)
        Me.kryptonGroupBox2.Name = "kryptonGroupBox2"
        Me.kryptonGroupBox2.Panel.Controls.Add(Me.kpgLinkWrappedLabel)
        Me.kryptonGroupBox2.Size = New System.Drawing.Size(306, 296)
        Me.kryptonGroupBox2.TabIndex = 5
        Me.kryptonGroupBox2.Values.Heading = "Properties for KryptonLinkWrapLabel"
        Me.kpgLinkWrappedLabel.Dock = System.Windows.Forms.DockStyle.Fill
        Me.kpgLinkWrappedLabel.Font = New System.Drawing.Font("Segoe UI", 9F)
        Me.kpgLinkWrappedLabel.HelpVisible = False
        Me.kpgLinkWrappedLabel.Location = New System.Drawing.Point(0, 0)
        Me.kpgLinkWrappedLabel.Name = "kpgLinkWrappedLabel"
        Me.kpgLinkWrappedLabel.SelectedObject = Me.klwlblTest
        Me.kpgLinkWrappedLabel.Size = New System.Drawing.Size(302, 272)
        Me.kpgLinkWrappedLabel.TabIndex = 0
        Me.kpgLinkWrappedLabel.ToolbarVisible = False
        Me.klwlblTest.AutoSize = False
        Me.klwlblTest.Font = New System.Drawing.Font("Segoe UI", 9F)
        Me.klwlblTest.ForeColor = System.Drawing.Color.FromArgb(CType(CType(30, Byte), Integer), CType(CType(57, Byte), Integer), CType(CType(91, Byte), Integer))
        Me.klwlblTest.LabelStyle = Krypton.Toolkit.LabelStyle.NormalControl
        Me.klwlblTest.Location = New System.Drawing.Point(11, 4)
        Me.klwlblTest.Name = "klwlblTest"
        Me.klwlblTest.Size = New System.Drawing.Size(213, 192)
        Me.klwlblTest.Text = resources.GetString("klwlblTest.Text")
        Me.kryptonGroupBox1.CaptionStyle = Krypton.Toolkit.LabelStyle.GroupBoxCaption
        Me.kryptonGroupBox1.GroupBackStyle = Krypton.Toolkit.PaletteBackStyle.ControlGroupBox
        Me.kryptonGroupBox1.GroupBorderStyle = Krypton.Toolkit.PaletteBorderStyle.ControlGroupBox
        Me.kryptonGroupBox1.Location = New System.Drawing.Point(13, 326)
        Me.kryptonGroupBox1.Name = "kryptonGroupBox1"
        Me.kryptonGroupBox1.Panel.Controls.Add(Me.klwlblTest)
        Me.kryptonGroupBox1.Size = New System.Drawing.Size(240, 240)
        Me.kryptonGroupBox1.TabIndex = 4
        Me.kryptonGroupBox1.Values.Heading = "KryptonLinkWrapLabel"
        Me.kryptonWrapLabel.AutoSize = False
        Me.kryptonWrapLabel.Font = New System.Drawing.Font("Segoe UI", 9F)
        Me.kryptonWrapLabel.ForeColor = System.Drawing.Color.FromArgb(CType(CType(30, Byte), Integer), CType(CType(57, Byte), Integer), CType(CType(91, Byte), Integer))
        Me.kryptonWrapLabel.LabelStyle = Krypton.Toolkit.LabelStyle.NormalControl
        Me.kryptonWrapLabel.Location = New System.Drawing.Point(14, 24)
        Me.kryptonWrapLabel.Name = "kryptonWrapLabel"
        Me.kryptonWrapLabel.Size = New System.Drawing.Size(213, 186)
        Me.kryptonWrapLabel.Text = resources.GetString("kryptonWrapLabel.Text")
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6F, 13F)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(592, 662)
        Me.Controls.Add(Me.kryptonGroupBox2)
        Me.Controls.Add(Me.kryptonGroupBox1)
        Me.Controls.Add(Me.groupBox2)
        Me.Controls.Add(Me.groupBox1)
        Me.Controls.Add(Me.buttonClose)
        Me.Controls.Add(Me.groupBox3)
        Me.Font = New System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.MaximizeBox = False
        Me.MinimizeBox = False
        Me.Name = "Form1"
        Me.Text = "KryptonWrapLabel Examples"
        Me.groupBox3.ResumeLayout(False)
        Me.groupBox1.ResumeLayout(False)
        Me.groupBox2.ResumeLayout(False)
        CType(Me.kryptonGroupBox2.Panel, System.ComponentModel.ISupportInitialize).EndInit()
        Me.kryptonGroupBox2.Panel.ResumeLayout(False)
        CType(Me.kryptonGroupBox2, System.ComponentModel.ISupportInitialize).EndInit()
        Me.kryptonGroupBox2.ResumeLayout(False)
        CType(Me.kryptonGroupBox1.Panel, System.ComponentModel.ISupportInitialize).EndInit()
        Me.kryptonGroupBox1.Panel.ResumeLayout(False)
        CType(Me.kryptonGroupBox1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.kryptonGroupBox1.ResumeLayout(False)
        Me.ResumeLayout(False)
    End Sub

    Friend WithEvents groupBox3 As System.Windows.Forms.GroupBox
    Friend WithEvents propertyGrid As System.Windows.Forms.PropertyGrid
    Friend WithEvents buttonClose As System.Windows.Forms.Button
    Friend WithEvents groupBox1 As System.Windows.Forms.GroupBox
    Friend WithEvents groupBox2 As System.Windows.Forms.GroupBox
    Friend WithEvents kryptonWrapLabel As Krypton.Toolkit.KryptonWrapLabel
    Friend WithEvents buttonNormal As System.Windows.Forms.Button
    Friend WithEvents buttonTitle As System.Windows.Forms.Button
    Friend WithEvents kryptonGroupBox1 As Krypton.Toolkit.KryptonGroupBox
    Friend WithEvents klwlblTest As Krypton.Toolkit.KryptonLinkWrapLabel
    Friend WithEvents kryptonGroupBox2 As Krypton.Toolkit.KryptonGroupBox
    Friend WithEvents kpgLinkWrappedLabel As Krypton.Toolkit.KryptonPropertyGrid
End Class
