' VB.NET twin of Source\Krypton Toolkit Examples\KryptonLabel Examples\Form1.Designer.cs (Bastion Phase 4c).
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
        Me.groupBox3 = New System.Windows.Forms.GroupBox()
        Me.propertyGrid = New System.Windows.Forms.PropertyGrid()
        Me.buttonClose = New System.Windows.Forms.Button()
        Me.groupBox1 = New System.Windows.Forms.GroupBox()
        Me.kryptonLabel1 = New Krypton.Toolkit.KryptonLabel()
        Me.label4Professional = New Krypton.Toolkit.KryptonLabel()
        Me.label3Professional = New Krypton.Toolkit.KryptonLabel()
        Me.label5Professional = New Krypton.Toolkit.KryptonLabel()
        Me.label2Professional = New Krypton.Toolkit.KryptonLabel()
        Me.label1Professional = New Krypton.Toolkit.KryptonLabel()
        Me.groupBox2 = New System.Windows.Forms.GroupBox()
        Me.label3Custom = New Krypton.Toolkit.KryptonLabel()
        Me.label2Custom = New Krypton.Toolkit.KryptonLabel()
        Me.label1Custom = New Krypton.Toolkit.KryptonLabel()
        Me.kryptonPanel1 = New Krypton.Toolkit.KryptonPanel()
        Me.kryptonWrapLabel1 = New Krypton.Toolkit.KryptonWrapLabel()
        Me.kryptonLabel2 = New Krypton.Toolkit.KryptonLabel()
        Me.kryptonManager1 = New Krypton.Toolkit.KryptonManager(Me.components)
        Me.kryptonPanel2 = New Krypton.Toolkit.KryptonPanel()
        Me.kryptonLabel3 = New Krypton.Toolkit.KryptonLabel()
        Me.groupBox3.SuspendLayout()
        Me.groupBox1.SuspendLayout()
        Me.groupBox2.SuspendLayout()
        CType(Me.kryptonPanel1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.kryptonPanel1.SuspendLayout()
        CType(Me.kryptonPanel2, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.kryptonPanel2.SuspendLayout()
        Me.SuspendLayout()
        Me.groupBox3.Controls.Add(Me.propertyGrid)
        Me.groupBox3.Location = New System.Drawing.Point(257, 12)
        Me.groupBox3.Name = "groupBox3"
        Me.groupBox3.Size = New System.Drawing.Size(322, 390)
        Me.groupBox3.TabIndex = 2
        Me.groupBox3.TabStop = False
        Me.groupBox3.Text = "Properties for Selected KryptonLabel"
        Me.propertyGrid.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) Or System.Windows.Forms.AnchorStyles.Left) Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.propertyGrid.Location = New System.Drawing.Point(6, 19)
        Me.propertyGrid.Name = "propertyGrid"
        Me.propertyGrid.Size = New System.Drawing.Size(310, 365)
        Me.propertyGrid.TabIndex = 0
        Me.propertyGrid.ToolbarVisible = False
        Me.buttonClose.Location = New System.Drawing.Point(504, 408)
        Me.buttonClose.Name = "buttonClose"
        Me.buttonClose.Size = New System.Drawing.Size(75, 23)
        Me.buttonClose.TabIndex = 3
        Me.buttonClose.Text = "Close"
        Me.buttonClose.UseVisualStyleBackColor = True
        Me.groupBox1.Controls.Add(Me.kryptonLabel1)
        Me.groupBox1.Controls.Add(Me.label4Professional)
        Me.groupBox1.Controls.Add(Me.label3Professional)
        Me.groupBox1.Controls.Add(Me.label5Professional)
        Me.groupBox1.Controls.Add(Me.label2Professional)
        Me.groupBox1.Controls.Add(Me.label1Professional)
        Me.groupBox1.Location = New System.Drawing.Point(12, 12)
        Me.groupBox1.Name = "groupBox1"
        Me.groupBox1.Size = New System.Drawing.Size(232, 193)
        Me.groupBox1.TabIndex = 0
        Me.groupBox1.TabStop = False
        Me.groupBox1.Text = "Office 2007 - Blue"
        Me.kryptonLabel1.Location = New System.Drawing.Point(168, 45)
        Me.kryptonLabel1.Name = "kryptonLabel1"
        Me.kryptonLabel1.Orientation = Krypton.Toolkit.VisualOrientation.Left
        Me.kryptonLabel1.Size = New System.Drawing.Size(24, 138)
        Me.kryptonLabel1.TabIndex = 4
        Me.kryptonLabel1.Values.ExtraText = "Left"
        Me.kryptonLabel1.Values.Image = CType(resources.GetObject("kryptonLabel1.Values.Image"), System.Drawing.Image)
        Me.kryptonLabel1.Values.Text = "Orientation"
        Me.label4Professional.Location = New System.Drawing.Point(15, 145)
        Me.label4Professional.Name = "label4Professional"
        Me.label4Professional.Orientation = Krypton.Toolkit.VisualOrientation.Bottom
        Me.label4Professional.Size = New System.Drawing.Size(161, 30)
        Me.label4Professional.TabIndex = 3
        Me.label4Professional.Values.Image = CType(resources.GetObject("label4Professional.Values.Image"), System.Drawing.Image)
        Me.label4Professional.Values.Text = "Orientation Bottom"
        Me.label3Professional.Location = New System.Drawing.Point(14, 118)
        Me.label3Professional.Name = "label3Professional"
        Me.label3Professional.Size = New System.Drawing.Size(100, 30)
        Me.label3Professional.StateCommon.ShortText.Font = New System.Drawing.Font("Microsoft Yi Baiti", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.label3Professional.TabIndex = 2
        Me.label3Professional.Values.Image = CType(resources.GetObject("label3Professional.Values.Image"), System.Drawing.Image)
        Me.label3Professional.Values.Text = "Orientation Top"
        Me.label5Professional.Location = New System.Drawing.Point(195, 45)
        Me.label5Professional.Name = "label5Professional"
        Me.label5Professional.Orientation = Krypton.Toolkit.VisualOrientation.Right
        Me.label5Professional.Size = New System.Drawing.Size(24, 149)
        Me.label5Professional.TabIndex = 5
        Me.label5Professional.Values.ExtraText = "Right"
        Me.label5Professional.Values.Image = CType(resources.GetObject("label5Professional.Values.Image"), System.Drawing.Image)
        Me.label5Professional.Values.Text = "Orientation"
        Me.label2Professional.Location = New System.Drawing.Point(14, 61)
        Me.label2Professional.Name = "label2Professional"
        Me.label2Professional.Size = New System.Drawing.Size(104, 30)
        Me.label2Professional.TabIndex = 1
        Me.label2Professional.Values.Text = "Text (Normal)"
        Me.label1Professional.LabelStyle = Krypton.Toolkit.LabelStyle.TitleControl
        Me.label1Professional.Location = New System.Drawing.Point(14, 29)
        Me.label1Professional.Name = "label1Professional"
        Me.label1Professional.Size = New System.Drawing.Size(134, 35)
        Me.label1Professional.TabIndex = 0
        Me.label1Professional.Values.Text = "Text (Title)"
        Me.groupBox2.Controls.Add(Me.label3Custom)
        Me.groupBox2.Controls.Add(Me.label2Custom)
        Me.groupBox2.Controls.Add(Me.label1Custom)
        Me.groupBox2.Location = New System.Drawing.Point(12, 211)
        Me.groupBox2.Name = "groupBox2"
        Me.groupBox2.Size = New System.Drawing.Size(232, 191)
        Me.groupBox2.TabIndex = 1
        Me.groupBox2.TabStop = False
        Me.groupBox2.Text = "Custom"
        Me.label3Custom.Location = New System.Drawing.Point(14, 125)
        Me.label3Custom.Name = "label3Custom"
        Me.label3Custom.PaletteMode = Krypton.Toolkit.PaletteMode.ProfessionalSystem
        Me.label3Custom.Size = New System.Drawing.Size(202, 65)
        Me.label3Custom.StateNormal.Image.ImageH = Krypton.Toolkit.PaletteRelativeAlign.Far
        Me.label3Custom.StateNormal.LongText.Color1 = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(192, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.label3Custom.StateNormal.LongText.Color2 = System.Drawing.Color.FromArgb(CType(CType(192, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer))
        Me.label3Custom.StateNormal.LongText.ColorAngle = 45F
        Me.label3Custom.StateNormal.LongText.ColorStyle = Krypton.Toolkit.PaletteColorStyle.Sigma
        Me.label3Custom.StateNormal.LongText.Font = New System.Drawing.Font("Verdana", 9F, CType((System.Drawing.FontStyle.Bold Or System.Drawing.FontStyle.Italic), System.Drawing.FontStyle), System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.label3Custom.StateNormal.LongText.MultiLine = Krypton.Toolkit.InheritBool.True
        Me.label3Custom.StateNormal.LongText.TextH = Krypton.Toolkit.PaletteRelativeAlign.Center
        Me.label3Custom.StateNormal.ShortText.Color1 = System.Drawing.Color.FromArgb(CType(CType(192, Byte), Integer), CType(CType(192, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.label3Custom.StateNormal.ShortText.Color2 = System.Drawing.Color.Blue
        Me.label3Custom.StateNormal.ShortText.ColorAngle = 45F
        Me.label3Custom.StateNormal.ShortText.ColorStyle = Krypton.Toolkit.PaletteColorStyle.Sigma
        Me.label3Custom.StateNormal.ShortText.Font = New System.Drawing.Font("Verdana", 14.25F, CType((System.Drawing.FontStyle.Bold Or System.Drawing.FontStyle.Italic), System.Drawing.FontStyle), System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.label3Custom.StateNormal.ShortText.TextH = Krypton.Toolkit.PaletteRelativeAlign.Near
        Me.label3Custom.TabIndex = 2
        Me.label3Custom.Values.ExtraText = "Extra Text" & vbCrLf & "Over Multi" & vbCrLf & "Lines"
        Me.label3Custom.Values.Image = My.Resources.sidebar_icon
        Me.label3Custom.Values.Text = "Multi" & vbCrLf & "Text"
        Me.label2Custom.Location = New System.Drawing.Point(14, 76)
        Me.label2Custom.Name = "label2Custom"
        Me.label2Custom.PaletteMode = Krypton.Toolkit.PaletteMode.ProfessionalSystem
        Me.label2Custom.Size = New System.Drawing.Size(215, 40)
        Me.label2Custom.StateNormal.LongText.Color1 = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.label2Custom.StateNormal.LongText.Color2 = System.Drawing.Color.White
        Me.label2Custom.StateNormal.LongText.ColorStyle = Krypton.Toolkit.PaletteColorStyle.HalfCut
        Me.label2Custom.StateNormal.LongText.Font = New System.Drawing.Font("Verdana", 9F, CType((System.Drawing.FontStyle.Bold Or System.Drawing.FontStyle.Italic), System.Drawing.FontStyle), System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.label2Custom.StateNormal.ShortText.Font = New System.Drawing.Font("Verdana", 15.75F, CType((System.Drawing.FontStyle.Bold Or System.Drawing.FontStyle.Italic), System.Drawing.FontStyle), System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.label2Custom.TabIndex = 1
        Me.label2Custom.Values.Image = CType(resources.GetObject("label2Custom.Values.Image"), System.Drawing.Image)
        Me.label2Custom.Values.Text = "Image Text"
        Me.label1Custom.Location = New System.Drawing.Point(14, 27)
        Me.label1Custom.Name = "label1Custom"
        Me.label1Custom.PaletteMode = Krypton.Toolkit.PaletteMode.ProfessionalSystem
        Me.label1Custom.Size = New System.Drawing.Size(203, 40)
        Me.label1Custom.StateNormal.LongText.Color1 = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.label1Custom.StateNormal.LongText.Color2 = System.Drawing.Color.White
        Me.label1Custom.StateNormal.LongText.ColorStyle = Krypton.Toolkit.PaletteColorStyle.HalfCut
        Me.label1Custom.StateNormal.LongText.Font = New System.Drawing.Font("Verdana", 9F, CType((System.Drawing.FontStyle.Bold Or System.Drawing.FontStyle.Italic), System.Drawing.FontStyle), System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.label1Custom.StateNormal.ShortText.Color1 = System.Drawing.Color.FromArgb(CType(CType(192, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer))
        Me.label1Custom.StateNormal.ShortText.Color2 = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(128, Byte), Integer), CType(CType(128, Byte), Integer))
        Me.label1Custom.StateNormal.ShortText.ColorStyle = Krypton.Toolkit.PaletteColorStyle.Rounded
        Me.label1Custom.StateNormal.ShortText.Font = New System.Drawing.Font("Verdana", 15.75F, CType((System.Drawing.FontStyle.Bold Or System.Drawing.FontStyle.Italic), System.Drawing.FontStyle), System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.label1Custom.TabIndex = 0
        Me.label1Custom.Values.ExtraText = "Extra Text"
        Me.label1Custom.Values.Image = CType(resources.GetObject("label1Custom.Values.Image"), System.Drawing.Image)
        Me.label1Custom.Values.Text = "Text"
        Me.kryptonPanel1.Controls.Add(Me.kryptonWrapLabel1)
        Me.kryptonPanel1.Controls.Add(Me.kryptonLabel2)
        Me.kryptonPanel1.Location = New System.Drawing.Point(12, 408)
        Me.kryptonPanel1.Name = "kryptonPanel1"
        Me.kryptonPanel1.PaletteMode = Krypton.Toolkit.PaletteMode.Office2007Black
        Me.kryptonPanel1.Size = New System.Drawing.Size(436, 112)
        Me.kryptonPanel1.TabIndex = 4
        Me.kryptonWrapLabel1.Font = New System.Drawing.Font("Segoe UI", 9F)
        Me.kryptonWrapLabel1.ForeColor = System.Drawing.Color.FromArgb(CType(CType(70, Byte), Integer), CType(CType(70, Byte), Integer), CType(CType(70, Byte), Integer))
        Me.kryptonWrapLabel1.LabelStyle = Krypton.Toolkit.LabelStyle.NormalControl
        Me.kryptonWrapLabel1.Location = New System.Drawing.Point(15, 52)
        Me.kryptonWrapLabel1.Name = "kryptonWrapLabel1"
        Me.kryptonWrapLabel1.PaletteMode = Krypton.Toolkit.PaletteMode.Office2007Black
        Me.kryptonWrapLabel1.Size = New System.Drawing.Size(420, 40)
        Me.kryptonWrapLabel1.Text = "Fix bug " & vbCrLf & "https://github.com/Krypton-Suite/Standard-Toolkit/issues/150"
        Me.kryptonLabel2.Location = New System.Drawing.Point(15, 21)
        Me.kryptonLabel2.Name = "kryptonLabel2"
        Me.kryptonLabel2.PaletteMode = Krypton.Toolkit.PaletteMode.Office2007Black
        Me.kryptonLabel2.Size = New System.Drawing.Size(109, 30)
        Me.kryptonLabel2.TabIndex = 0
        Me.kryptonLabel2.Values.Text = "kryptonLabel2"
        Me.kryptonManager1.GlobalPaletteMode = Krypton.Toolkit.PaletteMode.Office2007Blue
        Me.kryptonPanel2.Controls.Add(Me.kryptonLabel3)
        Me.kryptonPanel2.Location = New System.Drawing.Point(454, 460)
        Me.kryptonPanel2.Name = "kryptonPanel2"
        Me.kryptonPanel2.PanelBackStyle = Krypton.Toolkit.PaletteBackStyle.HeaderPrimary
        Me.kryptonPanel2.Size = New System.Drawing.Size(125, 45)
        Me.kryptonPanel2.StateCommon.Color1 = System.Drawing.Color.FromArgb(CType(CType(192, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.kryptonPanel2.StateCommon.Color2 = System.Drawing.Color.Teal
        Me.kryptonPanel2.StateCommon.ColorAngle = 45F
        Me.kryptonPanel2.TabIndex = 6
        Me.kryptonLabel3.Location = New System.Drawing.Point(10, 14)
        Me.kryptonLabel3.Name = "kryptonLabel3"
        Me.kryptonLabel3.Size = New System.Drawing.Size(109, 30)
        Me.kryptonLabel3.TabIndex = 6
        Me.kryptonLabel3.Values.Text = "kryptonLabel3"
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8F, 17F)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(591, 532)
        Me.Controls.Add(Me.kryptonPanel2)
        Me.Controls.Add(Me.kryptonPanel1)
        Me.Controls.Add(Me.groupBox2)
        Me.Controls.Add(Me.groupBox1)
        Me.Controls.Add(Me.buttonClose)
        Me.Controls.Add(Me.groupBox3)
        Me.DoubleBuffered = True
        Me.Font = New System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.MaximizeBox = False
        Me.MinimizeBox = False
        Me.Name = "Form1"
        Me.Text = "KryptonLabel Examples"
        Me.groupBox3.ResumeLayout(False)
        Me.groupBox1.ResumeLayout(False)
        Me.groupBox1.PerformLayout()
        Me.groupBox2.ResumeLayout(False)
        Me.groupBox2.PerformLayout()
        CType(Me.kryptonPanel1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.kryptonPanel1.ResumeLayout(False)
        Me.kryptonPanel1.PerformLayout()
        CType(Me.kryptonPanel2, System.ComponentModel.ISupportInitialize).EndInit()
        Me.kryptonPanel2.ResumeLayout(False)
        Me.kryptonPanel2.PerformLayout()
        Me.ResumeLayout(False)
    End Sub

    Friend WithEvents buttonClose As System.Windows.Forms.Button
    Friend WithEvents propertyGrid As System.Windows.Forms.PropertyGrid
    Friend WithEvents groupBox1 As System.Windows.Forms.GroupBox
    Friend WithEvents groupBox2 As System.Windows.Forms.GroupBox
    Friend WithEvents groupBox3 As System.Windows.Forms.GroupBox
    Friend WithEvents label1Professional As Krypton.Toolkit.KryptonLabel
    Friend WithEvents label2Professional As Krypton.Toolkit.KryptonLabel
    Friend WithEvents label3Professional As Krypton.Toolkit.KryptonLabel
    Friend WithEvents label4Professional As Krypton.Toolkit.KryptonLabel
    Friend WithEvents label5Professional As Krypton.Toolkit.KryptonLabel
    Friend WithEvents label1Custom As Krypton.Toolkit.KryptonLabel
    Friend WithEvents label2Custom As Krypton.Toolkit.KryptonLabel
    Friend WithEvents label3Custom As Krypton.Toolkit.KryptonLabel
    Friend WithEvents kryptonLabel1 As Krypton.Toolkit.KryptonLabel
    Friend WithEvents kryptonManager1 As Krypton.Toolkit.KryptonManager
    Friend WithEvents kryptonPanel1 As Krypton.Toolkit.KryptonPanel
    Friend WithEvents kryptonLabel2 As Krypton.Toolkit.KryptonLabel
    Friend WithEvents kryptonWrapLabel1 As Krypton.Toolkit.KryptonWrapLabel
    Friend WithEvents kryptonPanel2 As Krypton.Toolkit.KryptonPanel
    Friend WithEvents kryptonLabel3 As Krypton.Toolkit.KryptonLabel
End Class
