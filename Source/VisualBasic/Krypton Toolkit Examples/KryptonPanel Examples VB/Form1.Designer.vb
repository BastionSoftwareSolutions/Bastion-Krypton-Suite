' VB.NET twin of Source\Krypton Toolkit Examples\KryptonPanel Examples\Form1.Designer.cs (Bastion Phase 4c).
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
        Me.groupBox4 = New System.Windows.Forms.GroupBox()
        Me.propertyGrid = New System.Windows.Forms.PropertyGrid()
        Me.buttonClose = New System.Windows.Forms.Button()
        Me.groupBox1 = New System.Windows.Forms.GroupBox()
        Me.panel4Office = New Krypton.Toolkit.KryptonPanel()
        Me.panel3Office = New Krypton.Toolkit.KryptonPanel()
        Me.panel2Office = New Krypton.Toolkit.KryptonPanel()
        Me.panel1Office = New Krypton.Toolkit.KryptonPanel()
        Me.groupBox2 = New System.Windows.Forms.GroupBox()
        Me.panel4Blue = New Krypton.Toolkit.KryptonPanel()
        Me.panel3Blue = New Krypton.Toolkit.KryptonPanel()
        Me.panel2Blue = New Krypton.Toolkit.KryptonPanel()
        Me.panel1Blue = New Krypton.Toolkit.KryptonPanel()
        Me.groupBox3 = New System.Windows.Forms.GroupBox()
        Me.panel4Custom = New Krypton.Toolkit.KryptonPanel()
        Me.panel2Custom = New Krypton.Toolkit.KryptonPanel()
        Me.panel3Custom = New Krypton.Toolkit.KryptonPanel()
        Me.panel1Custom = New Krypton.Toolkit.KryptonPanel()
        Me.groupBox4.SuspendLayout()
        Me.groupBox1.SuspendLayout()
        CType(Me.panel4Office, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.panel3Office, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.panel2Office, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.panel1Office, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.groupBox2.SuspendLayout()
        CType(Me.panel4Blue, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.panel3Blue, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.panel2Blue, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.panel1Blue, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.groupBox3.SuspendLayout()
        CType(Me.panel4Custom, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.panel2Custom, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.panel3Custom, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.panel1Custom, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        Me.groupBox4.Controls.Add(Me.propertyGrid)
        Me.groupBox4.Location = New System.Drawing.Point(267, 12)
        Me.groupBox4.Name = "groupBox4"
        Me.groupBox4.Size = New System.Drawing.Size(322, 556)
        Me.groupBox4.TabIndex = 3
        Me.groupBox4.TabStop = False
        Me.groupBox4.Text = "Properties for Selected KryptonPanel"
        Me.propertyGrid.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) Or System.Windows.Forms.AnchorStyles.Left) Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.propertyGrid.Location = New System.Drawing.Point(6, 19)
        Me.propertyGrid.Name = "propertyGrid"
        Me.propertyGrid.Size = New System.Drawing.Size(310, 531)
        Me.propertyGrid.TabIndex = 0
        Me.propertyGrid.ToolbarVisible = False
        Me.buttonClose.DialogResult = System.Windows.Forms.DialogResult.Cancel
        Me.buttonClose.Location = New System.Drawing.Point(514, 574)
        Me.buttonClose.Name = "buttonClose"
        Me.buttonClose.Size = New System.Drawing.Size(75, 23)
        Me.buttonClose.TabIndex = 4
        Me.buttonClose.Text = "&Close"
        Me.buttonClose.UseVisualStyleBackColor = True
        Me.groupBox1.Controls.Add(Me.panel4Office)
        Me.groupBox1.Controls.Add(Me.panel3Office)
        Me.groupBox1.Controls.Add(Me.panel2Office)
        Me.groupBox1.Controls.Add(Me.panel1Office)
        Me.groupBox1.Location = New System.Drawing.Point(8, 12)
        Me.groupBox1.Name = "groupBox1"
        Me.groupBox1.Size = New System.Drawing.Size(253, 144)
        Me.groupBox1.TabIndex = 0
        Me.groupBox1.TabStop = False
        Me.groupBox1.Text = "Professional - Office 2003"
        Me.panel4Office.Location = New System.Drawing.Point(138, 84)
        Me.panel4Office.Name = "panel4Office"
        Me.panel4Office.PaletteMode = Krypton.Toolkit.PaletteMode.ProfessionalOffice2003
        Me.panel4Office.PanelBackStyle = Krypton.Toolkit.PaletteBackStyle.ControlClient
        Me.panel4Office.Size = New System.Drawing.Size(100, 49)
        Me.panel4Office.TabIndex = 3
        Me.panel3Office.Location = New System.Drawing.Point(20, 84)
        Me.panel3Office.Name = "panel3Office"
        Me.panel3Office.PaletteMode = Krypton.Toolkit.PaletteMode.ProfessionalOffice2003
        Me.panel3Office.PanelBackStyle = Krypton.Toolkit.PaletteBackStyle.HeaderSecondary
        Me.panel3Office.Size = New System.Drawing.Size(100, 49)
        Me.panel3Office.TabIndex = 1
        Me.panel2Office.Location = New System.Drawing.Point(138, 29)
        Me.panel2Office.Name = "panel2Office"
        Me.panel2Office.PaletteMode = Krypton.Toolkit.PaletteMode.ProfessionalOffice2003
        Me.panel2Office.PanelBackStyle = Krypton.Toolkit.PaletteBackStyle.HeaderPrimary
        Me.panel2Office.Size = New System.Drawing.Size(100, 49)
        Me.panel2Office.TabIndex = 2
        Me.panel1Office.Location = New System.Drawing.Point(20, 29)
        Me.panel1Office.Name = "panel1Office"
        Me.panel1Office.PaletteMode = Krypton.Toolkit.PaletteMode.ProfessionalOffice2003
        Me.panel1Office.Size = New System.Drawing.Size(100, 49)
        Me.panel1Office.TabIndex = 0
        Me.groupBox2.Controls.Add(Me.panel4Blue)
        Me.groupBox2.Controls.Add(Me.panel3Blue)
        Me.groupBox2.Controls.Add(Me.panel2Blue)
        Me.groupBox2.Controls.Add(Me.panel1Blue)
        Me.groupBox2.Location = New System.Drawing.Point(8, 162)
        Me.groupBox2.Name = "groupBox2"
        Me.groupBox2.Size = New System.Drawing.Size(253, 146)
        Me.groupBox2.TabIndex = 1
        Me.groupBox2.TabStop = False
        Me.groupBox2.Text = "Office 2007 - Blue"
        Me.panel4Blue.Location = New System.Drawing.Point(138, 84)
        Me.panel4Blue.Name = "panel4Blue"
        Me.panel4Blue.PaletteMode = Krypton.Toolkit.PaletteMode.Office2007Blue
        Me.panel4Blue.PanelBackStyle = Krypton.Toolkit.PaletteBackStyle.ControlClient
        Me.panel4Blue.Size = New System.Drawing.Size(100, 49)
        Me.panel4Blue.TabIndex = 3
        Me.panel3Blue.Location = New System.Drawing.Point(20, 84)
        Me.panel3Blue.Name = "panel3Blue"
        Me.panel3Blue.PaletteMode = Krypton.Toolkit.PaletteMode.Office2007Blue
        Me.panel3Blue.PanelBackStyle = Krypton.Toolkit.PaletteBackStyle.HeaderSecondary
        Me.panel3Blue.Size = New System.Drawing.Size(100, 49)
        Me.panel3Blue.TabIndex = 1
        Me.panel2Blue.Location = New System.Drawing.Point(138, 29)
        Me.panel2Blue.Name = "panel2Blue"
        Me.panel2Blue.PaletteMode = Krypton.Toolkit.PaletteMode.Office2007Blue
        Me.panel2Blue.PanelBackStyle = Krypton.Toolkit.PaletteBackStyle.HeaderPrimary
        Me.panel2Blue.Size = New System.Drawing.Size(100, 49)
        Me.panel2Blue.TabIndex = 2
        Me.panel1Blue.Location = New System.Drawing.Point(20, 29)
        Me.panel1Blue.Name = "panel1Blue"
        Me.panel1Blue.PaletteMode = Krypton.Toolkit.PaletteMode.Office2007Blue
        Me.panel1Blue.Size = New System.Drawing.Size(100, 49)
        Me.panel1Blue.TabIndex = 0
        Me.groupBox3.Controls.Add(Me.panel4Custom)
        Me.groupBox3.Controls.Add(Me.panel2Custom)
        Me.groupBox3.Controls.Add(Me.panel3Custom)
        Me.groupBox3.Controls.Add(Me.panel1Custom)
        Me.groupBox3.Location = New System.Drawing.Point(8, 314)
        Me.groupBox3.Name = "groupBox3"
        Me.groupBox3.Size = New System.Drawing.Size(253, 254)
        Me.groupBox3.TabIndex = 2
        Me.groupBox3.TabStop = False
        Me.groupBox3.Text = "Custom Settings"
        Me.panel4Custom.Location = New System.Drawing.Point(138, 138)
        Me.panel4Custom.Name = "panel4Custom"
        Me.panel4Custom.PaletteMode = Krypton.Toolkit.PaletteMode.ProfessionalSystem
        Me.panel4Custom.Size = New System.Drawing.Size(100, 100)
        Me.panel4Custom.StateNormal.Color1 = System.Drawing.Color.White
        Me.panel4Custom.StateNormal.Color2 = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(224, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.panel4Custom.StateNormal.ColorAlign = Krypton.Toolkit.PaletteRectangleAlign.Inherit
        Me.panel4Custom.StateNormal.ColorAngle = 45F
        Me.panel4Custom.StateNormal.ColorStyle = Krypton.Toolkit.PaletteColorStyle.Sigma
        Me.panel4Custom.StateNormal.Draw = Krypton.Toolkit.InheritBool.Inherit
        Me.panel4Custom.StateNormal.GraphicsHint = Krypton.Toolkit.PaletteGraphicsHint.Inherit
        Me.panel4Custom.StateNormal.Image = CType(resources.GetObject("panel4Custom.StateNormal.Image"), System.Drawing.Image)
        Me.panel4Custom.StateNormal.ImageAlign = Krypton.Toolkit.PaletteRectangleAlign.Local
        Me.panel4Custom.StateNormal.ImageStyle = Krypton.Toolkit.PaletteImageStyle.Inherit
        Me.panel4Custom.TabIndex = 3
        Me.panel2Custom.Location = New System.Drawing.Point(138, 32)
        Me.panel2Custom.Name = "panel2Custom"
        Me.panel2Custom.PaletteMode = Krypton.Toolkit.PaletteMode.ProfessionalSystem
        Me.panel2Custom.Size = New System.Drawing.Size(100, 100)
        Me.panel2Custom.StateNormal.Color1 = System.Drawing.Color.White
        Me.panel2Custom.StateNormal.Color2 = System.Drawing.Color.Maroon
        Me.panel2Custom.StateNormal.ColorAlign = Krypton.Toolkit.PaletteRectangleAlign.Inherit
        Me.panel2Custom.StateNormal.ColorAngle = 10F
        Me.panel2Custom.StateNormal.ColorStyle = Krypton.Toolkit.PaletteColorStyle.Sigma
        Me.panel2Custom.StateNormal.Draw = Krypton.Toolkit.InheritBool.Inherit
        Me.panel2Custom.StateNormal.GraphicsHint = Krypton.Toolkit.PaletteGraphicsHint.Inherit
        Me.panel2Custom.StateNormal.ImageAlign = Krypton.Toolkit.PaletteRectangleAlign.Inherit
        Me.panel2Custom.StateNormal.ImageStyle = Krypton.Toolkit.PaletteImageStyle.Inherit
        Me.panel2Custom.TabIndex = 2
        Me.panel3Custom.Location = New System.Drawing.Point(20, 138)
        Me.panel3Custom.Name = "panel3Custom"
        Me.panel3Custom.PaletteMode = Krypton.Toolkit.PaletteMode.ProfessionalSystem
        Me.panel3Custom.Size = New System.Drawing.Size(100, 100)
        Me.panel3Custom.StateNormal.Color1 = System.Drawing.Color.White
        Me.panel3Custom.StateNormal.Color2 = System.Drawing.Color.FromArgb(CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer))
        Me.panel3Custom.StateNormal.ColorAlign = Krypton.Toolkit.PaletteRectangleAlign.Inherit
        Me.panel3Custom.StateNormal.ColorAngle = 45F
        Me.panel3Custom.StateNormal.ColorStyle = Krypton.Toolkit.PaletteColorStyle.Linear
        Me.panel3Custom.StateNormal.Draw = Krypton.Toolkit.InheritBool.Inherit
        Me.panel3Custom.StateNormal.GraphicsHint = Krypton.Toolkit.PaletteGraphicsHint.Inherit
        Me.panel3Custom.StateNormal.Image = CType(resources.GetObject("panel3Custom.StateNormal.Image"), System.Drawing.Image)
        Me.panel3Custom.StateNormal.ImageAlign = Krypton.Toolkit.PaletteRectangleAlign.Inherit
        Me.panel3Custom.StateNormal.ImageStyle = Krypton.Toolkit.PaletteImageStyle.CenterMiddle
        Me.panel3Custom.TabIndex = 1
        Me.panel1Custom.Location = New System.Drawing.Point(20, 32)
        Me.panel1Custom.Name = "panel1Custom"
        Me.panel1Custom.PaletteMode = Krypton.Toolkit.PaletteMode.ProfessionalSystem
        Me.panel1Custom.Size = New System.Drawing.Size(100, 100)
        Me.panel1Custom.StateNormal.Color1 = System.Drawing.Color.White
        Me.panel1Custom.StateNormal.Color2 = System.Drawing.Color.FromArgb(CType(CType(192, Byte), Integer), CType(CType(192, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.panel1Custom.StateNormal.ColorAlign = Krypton.Toolkit.PaletteRectangleAlign.Inherit
        Me.panel1Custom.StateNormal.ColorAngle = 60F
        Me.panel1Custom.StateNormal.ColorStyle = Krypton.Toolkit.PaletteColorStyle.Rounded
        Me.panel1Custom.StateNormal.Draw = Krypton.Toolkit.InheritBool.Inherit
        Me.panel1Custom.StateNormal.GraphicsHint = Krypton.Toolkit.PaletteGraphicsHint.Inherit
        Me.panel1Custom.StateNormal.ImageAlign = Krypton.Toolkit.PaletteRectangleAlign.Inherit
        Me.panel1Custom.StateNormal.ImageStyle = Krypton.Toolkit.PaletteImageStyle.Inherit
        Me.panel1Custom.TabIndex = 0
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6F, 13F)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(601, 607)
        Me.Controls.Add(Me.groupBox3)
        Me.Controls.Add(Me.groupBox2)
        Me.Controls.Add(Me.groupBox1)
        Me.Controls.Add(Me.buttonClose)
        Me.Controls.Add(Me.groupBox4)
        Me.Font = New System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.MaximizeBox = False
        Me.MinimizeBox = False
        Me.Name = "Form1"
        Me.Text = "KryptonPanel Examples"
        Me.groupBox4.ResumeLayout(False)
        Me.groupBox1.ResumeLayout(False)
        CType(Me.panel4Office, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.panel3Office, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.panel2Office, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.panel1Office, System.ComponentModel.ISupportInitialize).EndInit()
        Me.groupBox2.ResumeLayout(False)
        CType(Me.panel4Blue, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.panel3Blue, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.panel2Blue, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.panel1Blue, System.ComponentModel.ISupportInitialize).EndInit()
        Me.groupBox3.ResumeLayout(False)
        CType(Me.panel4Custom, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.panel2Custom, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.panel3Custom, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.panel1Custom, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
    End Sub

    Friend WithEvents buttonClose As System.Windows.Forms.Button
    Friend WithEvents propertyGrid As System.Windows.Forms.PropertyGrid
    Friend WithEvents groupBox1 As System.Windows.Forms.GroupBox
    Friend WithEvents groupBox2 As System.Windows.Forms.GroupBox
    Friend WithEvents groupBox3 As System.Windows.Forms.GroupBox
    Friend WithEvents groupBox4 As System.Windows.Forms.GroupBox
    Friend WithEvents panel1Office As Krypton.Toolkit.KryptonPanel
    Friend WithEvents panel2Office As Krypton.Toolkit.KryptonPanel
    Friend WithEvents panel3Office As Krypton.Toolkit.KryptonPanel
    Friend WithEvents panel4Office As Krypton.Toolkit.KryptonPanel
    Friend WithEvents panel1Blue As Krypton.Toolkit.KryptonPanel
    Friend WithEvents panel2Blue As Krypton.Toolkit.KryptonPanel
    Friend WithEvents panel3Blue As Krypton.Toolkit.KryptonPanel
    Friend WithEvents panel4Blue As Krypton.Toolkit.KryptonPanel
    Friend WithEvents panel1Custom As Krypton.Toolkit.KryptonPanel
    Friend WithEvents panel2Custom As Krypton.Toolkit.KryptonPanel
    Friend WithEvents panel3Custom As Krypton.Toolkit.KryptonPanel
    Friend WithEvents panel4Custom As Krypton.Toolkit.KryptonPanel
End Class
