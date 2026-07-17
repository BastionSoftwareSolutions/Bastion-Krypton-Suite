' VB.NET twin of Source\Krypton Docking Examples\Multi Control Docking\Form1.Designer.cs (Bastion Phase 4c).
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
        Me.kryptonLabel2 = New Krypton.Toolkit.KryptonLabel()
        Me.kryptonLabel1 = New Krypton.Toolkit.KryptonLabel()
        Me.kryptonPanel3 = New Krypton.Toolkit.KryptonPanel()
        Me.kryptonPanel2 = New Krypton.Toolkit.KryptonPanel()
        Me.kryptonDockingManager = New Krypton.Docking.KryptonDockingManager()
        Me.imageListSmall = New System.Windows.Forms.ImageList(Me.components)
        Me.kryptonManager = New Krypton.Toolkit.KryptonManager(Me.components)
        CType(Me.kryptonPanel3, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.kryptonPanel2, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        Me.kryptonLabel2.LabelStyle = Krypton.Toolkit.LabelStyle.TitlePanel
        Me.kryptonLabel2.Location = New System.Drawing.Point(443, 12)
        Me.kryptonLabel2.Name = "kryptonLabel2"
        Me.kryptonLabel2.Size = New System.Drawing.Size(153, 29)
        Me.kryptonLabel2.TabIndex = 3
        Me.kryptonLabel2.Values.Text = "Docking Panel 2"
        Me.kryptonLabel1.LabelStyle = Krypton.Toolkit.LabelStyle.TitlePanel
        Me.kryptonLabel1.Location = New System.Drawing.Point(12, 12)
        Me.kryptonLabel1.Name = "kryptonLabel1"
        Me.kryptonLabel1.Size = New System.Drawing.Size(153, 29)
        Me.kryptonLabel1.TabIndex = 2
        Me.kryptonLabel1.Values.Text = "Docking Panel 1"
        Me.kryptonPanel3.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) Or System.Windows.Forms.AnchorStyles.Left) Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.kryptonPanel3.Location = New System.Drawing.Point(443, 47)
        Me.kryptonPanel3.Name = "kryptonPanel3"
        Me.kryptonPanel3.Size = New System.Drawing.Size(400, 407)
        Me.kryptonPanel3.TabIndex = 1
        Me.kryptonPanel2.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) Or System.Windows.Forms.AnchorStyles.Left), System.Windows.Forms.AnchorStyles)
        Me.kryptonPanel2.Location = New System.Drawing.Point(12, 47)
        Me.kryptonPanel2.Name = "kryptonPanel2"
        Me.kryptonPanel2.Size = New System.Drawing.Size(400, 407)
        Me.kryptonPanel2.TabIndex = 0
        Me.kryptonDockingManager.DefaultCloseRequest = Krypton.Docking.DockingCloseRequest.HidePage
        Me.imageListSmall.ImageStream = CType(resources.GetObject("imageListSmall.ImageStream"), System.Windows.Forms.ImageListStreamer)
        Me.imageListSmall.TransparentColor = System.Drawing.Color.Transparent
        Me.imageListSmall.Images.SetKeyName(0, "document_plain.png")
        Me.imageListSmall.Images.SetKeyName(1, "preferences.png")
        Me.imageListSmall.Images.SetKeyName(2, "information2.png")
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6F, 13F)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(855, 466)
        Me.Controls.Add(Me.kryptonPanel3)
        Me.Controls.Add(Me.kryptonLabel2)
        Me.Controls.Add(Me.kryptonLabel1)
        Me.Controls.Add(Me.kryptonPanel2)
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.MinimumSize = New System.Drawing.Size(700, 330)
        Me.Name = "Form1"
        Me.Text = "Multi Control Docking"
        CType(Me.kryptonPanel3, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.kryptonPanel2, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()
    End Sub

    Friend WithEvents kryptonPanel3 As Krypton.Toolkit.KryptonPanel
    Friend WithEvents kryptonPanel2 As Krypton.Toolkit.KryptonPanel
    Friend WithEvents kryptonLabel2 As Krypton.Toolkit.KryptonLabel
    Friend WithEvents kryptonLabel1 As Krypton.Toolkit.KryptonLabel
    Friend WithEvents kryptonDockingManager As Krypton.Docking.KryptonDockingManager
    Friend WithEvents imageListSmall As System.Windows.Forms.ImageList
    Friend WithEvents kryptonManager As Krypton.Toolkit.KryptonManager
End Class
