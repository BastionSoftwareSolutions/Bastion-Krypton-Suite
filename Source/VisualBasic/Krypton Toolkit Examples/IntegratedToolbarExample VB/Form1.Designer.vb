' VB.NET twin of Source\Krypton Toolkit Examples\IntegratedToolbarExample\Form1.Designer.cs (Bastion Phase 4c).
<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class Form1
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
        Me.kryptonPanel1 = New Krypton.Toolkit.KryptonPanel()
        Me.kryptonLabel1 = New Krypton.Toolkit.KryptonLabel()
        Me.kryptonThemeComboBox1 = New Krypton.Toolkit.KryptonThemeComboBox()
        Me.bsNew = New Krypton.Toolkit.ButtonSpecAny()
        Me.bsOpen = New Krypton.Toolkit.ButtonSpecAny()
        Me.bsSave = New Krypton.Toolkit.ButtonSpecAny()
        Me.bsSaveAs = New Krypton.Toolkit.ButtonSpecAny()
        Me.bsCut = New Krypton.Toolkit.ButtonSpecAny()
        Me.bsCopy = New Krypton.Toolkit.ButtonSpecAny()
        Me.bsPaste = New Krypton.Toolkit.ButtonSpecAny()
        Me.bsUndo = New Krypton.Toolkit.ButtonSpecAny()
        Me.bsRedo = New Krypton.Toolkit.ButtonSpecAny()
        Me.buttonSpecAny1 = New Krypton.Toolkit.ButtonSpecAny()
        Me.buttonSpecAny2 = New Krypton.Toolkit.ButtonSpecAny()
        Me.buttonSpecAny3 = New Krypton.Toolkit.ButtonSpecAny()
        Me.buttonSpecAny4 = New Krypton.Toolkit.ButtonSpecAny()
        CType(Me.kryptonPanel1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.kryptonPanel1.SuspendLayout()
        CType(Me.kryptonThemeComboBox1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'kryptonPanel1
        '
        Me.kryptonPanel1.Controls.Add(Me.kryptonLabel1)
        Me.kryptonPanel1.Controls.Add(Me.kryptonThemeComboBox1)
        Me.kryptonPanel1.Dock = System.Windows.Forms.DockStyle.Fill
        Me.kryptonPanel1.Location = New System.Drawing.Point(0, 0)
        Me.kryptonPanel1.Name = "kryptonPanel1"
        Me.kryptonPanel1.Size = New System.Drawing.Size(502, 78)
        Me.kryptonPanel1.TabIndex = 1
        '
        'kryptonLabel1
        '
        Me.kryptonLabel1.LabelStyle = Krypton.Toolkit.LabelStyle.BoldControl
        Me.kryptonLabel1.Location = New System.Drawing.Point(13, 13)
        Me.kryptonLabel1.Name = "kryptonLabel1"
        Me.kryptonLabel1.Size = New System.Drawing.Size(99, 20)
        Me.kryptonLabel1.TabIndex = 1
        Me.kryptonLabel1.Values.Text = "Select a theme:"
        '
        'kryptonThemeComboBox1
        '
        Me.kryptonThemeComboBox1.DropDownWidth = 477
        Me.kryptonThemeComboBox1.IntegralHeight = False
        Me.kryptonThemeComboBox1.Location = New System.Drawing.Point(12, 39)
        Me.kryptonThemeComboBox1.Name = "kryptonThemeComboBox1"
        Me.kryptonThemeComboBox1.Size = New System.Drawing.Size(477, 21)
        Me.kryptonThemeComboBox1.StateCommon.ComboBox.Content.TextH = Krypton.Toolkit.PaletteRelativeAlign.Near
        Me.kryptonThemeComboBox1.TabIndex = 0
        '
        'bsNew
        '
        Me.bsNew.Type = Krypton.Toolkit.PaletteButtonSpecStyle.New
        Me.bsNew.UniqueName = "5bb4d0dbd09c4b93b18c3fa718de9e13"
        '
        'bsOpen
        '
        Me.bsOpen.Type = Krypton.Toolkit.PaletteButtonSpecStyle.Open
        Me.bsOpen.UniqueName = "854fc76fe0ca423194cacf6c3ce3e713"
        '
        'bsSave
        '
        Me.bsSave.Type = Krypton.Toolkit.PaletteButtonSpecStyle.Save
        Me.bsSave.UniqueName = "2f9ade8185cc45a3bc0bef093f9a1b01"
        '
        'bsSaveAs
        '
        Me.bsSaveAs.Type = Krypton.Toolkit.PaletteButtonSpecStyle.SaveAs
        Me.bsSaveAs.UniqueName = "0b6d01fc58d24d7c8767aa858d4ea6d8"
        '
        'bsCut
        '
        Me.bsCut.Type = Krypton.Toolkit.PaletteButtonSpecStyle.Cut
        Me.bsCut.UniqueName = "19c1beb980364e6794a713fa6ef99844"
        '
        'bsCopy
        '
        Me.bsCopy.Type = Krypton.Toolkit.PaletteButtonSpecStyle.Copy
        Me.bsCopy.UniqueName = "69065a8a4dbd4d4388a31311fb5f4084"
        '
        'bsPaste
        '
        Me.bsPaste.Type = Krypton.Toolkit.PaletteButtonSpecStyle.Paste
        Me.bsPaste.UniqueName = "1aa6c2a04d71415f98a981ce431fa7f3"
        '
        'bsUndo
        '
        Me.bsUndo.Type = Krypton.Toolkit.PaletteButtonSpecStyle.Undo
        Me.bsUndo.UniqueName = "77803245e5f1461c9f7d4efe14dbd3ad"
        '
        'bsRedo
        '
        Me.bsRedo.Type = Krypton.Toolkit.PaletteButtonSpecStyle.Redo
        Me.bsRedo.UniqueName = "3ae1531e1f524ebf954d4e14dbe77421"
        '
        'buttonSpecAny1
        '
        Me.buttonSpecAny1.Type = Krypton.Toolkit.PaletteButtonSpecStyle.PageSetup
        Me.buttonSpecAny1.UniqueName = "9b31b3d22d574a10bc81c9f3cba770c6"
        '
        'buttonSpecAny2
        '
        Me.buttonSpecAny2.Type = Krypton.Toolkit.PaletteButtonSpecStyle.PrintPreview
        Me.buttonSpecAny2.UniqueName = "69d756be05a84a54ab1dcde7d88c8329"
        '
        'buttonSpecAny3
        '
        Me.buttonSpecAny3.Type = Krypton.Toolkit.PaletteButtonSpecStyle.Print
        Me.buttonSpecAny3.UniqueName = "56b504ff170b4f628a030a78305db67e"
        '
        'buttonSpecAny4
        '
        Me.buttonSpecAny4.Type = Krypton.Toolkit.PaletteButtonSpecStyle.QuickPrint
        Me.buttonSpecAny4.UniqueName = "b046cdcdba06405e977ecaf351f61e29"
        '
        'Form1
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6F, 13F)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ButtonSpecs.AddRange(New Krypton.Toolkit.ButtonSpecAny() { Me.bsNew, Me.bsOpen, Me.bsSave, Me.bsSaveAs, Me.bsCut, Me.bsCopy, Me.bsPaste, Me.bsUndo, Me.bsRedo, Me.buttonSpecAny1, Me.buttonSpecAny2, Me.buttonSpecAny3, Me.buttonSpecAny4})
        Me.ClientSize = New System.Drawing.Size(502, 78)
        Me.Controls.Add(Me.kryptonPanel1)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.Fixed3D
        Me.MaximizeBox = False
        Me.Name = "Form1"
        Me.ShowIcon = False
        Me.Text = "Integrated Toolbar Example"
        Me.Controls.SetChildIndex(Me.kryptonPanel1, 0)
        CType(Me.kryptonPanel1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.kryptonPanel1.ResumeLayout(False)
        Me.kryptonPanel1.PerformLayout()
        CType(Me.kryptonThemeComboBox1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
    End Sub

    Friend WithEvents kryptonPanel1 As Krypton.Toolkit.KryptonPanel
    Friend WithEvents kryptonThemeComboBox1 As Krypton.Toolkit.KryptonThemeComboBox
    Friend WithEvents kryptonLabel1 As Krypton.Toolkit.KryptonLabel
    Friend WithEvents bsNew As Krypton.Toolkit.ButtonSpecAny
    Friend WithEvents bsOpen As Krypton.Toolkit.ButtonSpecAny
    Friend WithEvents bsSave As Krypton.Toolkit.ButtonSpecAny
    Friend WithEvents bsSaveAs As Krypton.Toolkit.ButtonSpecAny
    Friend WithEvents bsCut As Krypton.Toolkit.ButtonSpecAny
    Friend WithEvents bsCopy As Krypton.Toolkit.ButtonSpecAny
    Friend WithEvents bsPaste As Krypton.Toolkit.ButtonSpecAny
    Friend WithEvents bsUndo As Krypton.Toolkit.ButtonSpecAny
    Friend WithEvents bsRedo As Krypton.Toolkit.ButtonSpecAny
    Friend WithEvents buttonSpecAny1 As Krypton.Toolkit.ButtonSpecAny
    Friend WithEvents buttonSpecAny2 As Krypton.Toolkit.ButtonSpecAny
    Friend WithEvents buttonSpecAny3 As Krypton.Toolkit.ButtonSpecAny
    Friend WithEvents buttonSpecAny4 As Krypton.Toolkit.ButtonSpecAny
End Class
