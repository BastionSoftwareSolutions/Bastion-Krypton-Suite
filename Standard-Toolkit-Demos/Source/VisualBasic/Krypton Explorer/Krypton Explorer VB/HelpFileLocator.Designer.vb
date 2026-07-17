' VB.NET twin of Source\Krypton Explorer\HelpFileLocator.Designer.cs (Bastion Phase 4c).
<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class HelpFileLocator
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(HelpFileLocator))
        Me.kryptonPanel1 = New Krypton.Toolkit.KryptonPanel()
        Me.kryptonPanel2 = New Krypton.Toolkit.KryptonPanel()
        Me.kryptonBorderEdge1 = New Krypton.Toolkit.KryptonBorderEdge()
        Me.kbtnOk = New Krypton.Toolkit.KryptonButton()
        Me.kryptonLabel1 = New Krypton.Toolkit.KryptonLabel()
        Me.ktxtHelpFilePath = New Krypton.Toolkit.KryptonTextBox()
        Me.bsaBrowse = New Krypton.Toolkit.ButtonSpecAny()
        Me.kcmdBrowseForFile = New Krypton.Toolkit.KryptonCommand()
        CType(Me.kryptonPanel1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.kryptonPanel1.SuspendLayout()
        CType(Me.kryptonPanel2, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.kryptonPanel2.SuspendLayout()
        Me.SuspendLayout()
        Me.kryptonPanel1.Controls.Add(Me.kbtnOk)
        Me.kryptonPanel1.Controls.Add(Me.kryptonBorderEdge1)
        Me.kryptonPanel1.Dock = System.Windows.Forms.DockStyle.Bottom
        Me.kryptonPanel1.Location = New System.Drawing.Point(0, 49)
        Me.kryptonPanel1.Name = "kryptonPanel1"
        Me.kryptonPanel1.PanelBackStyle = Krypton.Toolkit.PaletteBackStyle.PanelAlternate
        Me.kryptonPanel1.Size = New System.Drawing.Size(463, 50)
        Me.kryptonPanel1.TabIndex = 0
        Me.kryptonPanel2.Controls.Add(Me.ktxtHelpFilePath)
        Me.kryptonPanel2.Controls.Add(Me.kryptonLabel1)
        Me.kryptonPanel2.Dock = System.Windows.Forms.DockStyle.Fill
        Me.kryptonPanel2.Location = New System.Drawing.Point(0, 0)
        Me.kryptonPanel2.Name = "kryptonPanel2"
        Me.kryptonPanel2.Size = New System.Drawing.Size(463, 49)
        Me.kryptonPanel2.TabIndex = 1
        Me.kryptonBorderEdge1.BorderStyle = Krypton.Toolkit.PaletteBorderStyle.HeaderSecondary
        Me.kryptonBorderEdge1.Dock = System.Windows.Forms.DockStyle.Top
        Me.kryptonBorderEdge1.Location = New System.Drawing.Point(0, 0)
        Me.kryptonBorderEdge1.Name = "kryptonBorderEdge1"
        Me.kryptonBorderEdge1.Size = New System.Drawing.Size(463, 1)
        Me.kryptonBorderEdge1.Text = "kryptonBorderEdge1"
        Me.kbtnOk.AutoSize = True
        Me.kbtnOk.DialogResult = System.Windows.Forms.DialogResult.OK
        Me.kbtnOk.Location = New System.Drawing.Point(361, 13)
        Me.kbtnOk.Name = "kbtnOk"
        Me.kbtnOk.Size = New System.Drawing.Size(90, 25)
        Me.kbtnOk.TabIndex = 1
        Me.kbtnOk.Values.Text = "O&k"
        Me.kryptonLabel1.LabelStyle = Krypton.Toolkit.LabelStyle.BoldControl
        Me.kryptonLabel1.Location = New System.Drawing.Point(13, 13)
        Me.kryptonLabel1.Name = "kryptonLabel1"
        Me.kryptonLabel1.Size = New System.Drawing.Size(87, 20)
        Me.kryptonLabel1.TabIndex = 0
        Me.kryptonLabel1.Values.Text = "File Location:"
        Me.ktxtHelpFilePath.ButtonSpecs.AddRange(New Krypton.Toolkit.ButtonSpecAny() { Me.bsaBrowse})
        Me.ktxtHelpFilePath.CueHint.Padding = New System.Windows.Forms.Padding(0)
        Me.ktxtHelpFilePath.Location = New System.Drawing.Point(107, 13)
        Me.ktxtHelpFilePath.Name = "ktxtHelpFilePath"
        Me.ktxtHelpFilePath.Size = New System.Drawing.Size(344, 24)
        Me.ktxtHelpFilePath.TabIndex = 1
        Me.bsaBrowse.Enabled = Krypton.Toolkit.ButtonEnabled.True
        Me.bsaBrowse.KryptonCommand = Me.kcmdBrowseForFile
        Me.bsaBrowse.Text = "..."
        Me.bsaBrowse.UniqueName = "91ee54154bd24d56975a4c3695ed31c4"
        Me.kcmdBrowseForFile.Text = "..."
        Me.AcceptButton = Me.kbtnOk
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6F, 13F)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(463, 99)
        Me.Controls.Add(Me.kryptonPanel2)
        Me.Controls.Add(Me.kryptonPanel1)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.Fixed3D
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.MaximizeBox = False
        Me.MinimizeBox = False
        Me.Name = "HelpFileLocator"
        Me.ShowInTaskbar = False
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Locate Help File"
        CType(Me.kryptonPanel1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.kryptonPanel1.ResumeLayout(False)
        Me.kryptonPanel1.PerformLayout()
        CType(Me.kryptonPanel2, System.ComponentModel.ISupportInitialize).EndInit()
        Me.kryptonPanel2.ResumeLayout(False)
        Me.kryptonPanel2.PerformLayout()
        Me.ResumeLayout(False)
    End Sub

    Friend WithEvents kryptonPanel1 As Krypton.Toolkit.KryptonPanel
    Friend WithEvents kryptonPanel2 As Krypton.Toolkit.KryptonPanel
    Friend WithEvents kryptonBorderEdge1 As Krypton.Toolkit.KryptonBorderEdge
    Friend WithEvents kbtnOk As Krypton.Toolkit.KryptonButton
    Friend WithEvents kryptonLabel1 As Krypton.Toolkit.KryptonLabel
    Friend WithEvents ktxtHelpFilePath As Krypton.Toolkit.KryptonTextBox
    Friend WithEvents bsaBrowse As Krypton.Toolkit.ButtonSpecAny
    Friend WithEvents kcmdBrowseForFile As Krypton.Toolkit.KryptonCommand
End Class
