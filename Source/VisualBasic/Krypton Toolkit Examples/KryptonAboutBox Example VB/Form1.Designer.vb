' VB.NET twin of Source\Krypton Toolkit Examples\KryptonAboutBox Example\Form1.Designer.cs (Bastion Phase 4c).
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
        Me.kbtnShow = New Krypton.Toolkit.KryptonButton()
        Me.kbtnCancel = New Krypton.Toolkit.KryptonButton()
        Me.kryptonBorderEdge1 = New Krypton.Toolkit.KryptonBorderEdge()
        Me.kryptonPanel2 = New Krypton.Toolkit.KryptonPanel()
        Me.ktxtAssemblyLocation = New Krypton.Toolkit.KryptonTextBox()
        Me.kryptonLabel1 = New Krypton.Toolkit.KryptonLabel()
        Me.kcBrowseForAssembly = New Krypton.Toolkit.KryptonCommand()
        CType(Me.kryptonPanel1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.kryptonPanel1.SuspendLayout()
        CType(Me.kryptonPanel2, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.kryptonPanel2.SuspendLayout()
        Me.SuspendLayout()
        '
        'kryptonPanel1
        '
        Me.kryptonPanel1.Controls.Add(Me.kbtnShow)
        Me.kryptonPanel1.Controls.Add(Me.kbtnCancel)
        Me.kryptonPanel1.Controls.Add(Me.kryptonBorderEdge1)
        Me.kryptonPanel1.Dock = System.Windows.Forms.DockStyle.Bottom
        Me.kryptonPanel1.Location = New System.Drawing.Point(0, 284)
        Me.kryptonPanel1.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.kryptonPanel1.Name = "kryptonPanel1"
        Me.kryptonPanel1.PanelBackStyle = Krypton.Toolkit.PaletteBackStyle.PanelAlternate
        Me.kryptonPanel1.Size = New System.Drawing.Size(623, 62)
        Me.kryptonPanel1.TabIndex = 1
        '
        'kbtnShow
        '
        Me.kbtnShow.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.kbtnShow.Location = New System.Drawing.Point(359, 16)
        Me.kbtnShow.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.kbtnShow.Name = "kbtnShow"
        Me.kbtnShow.Size = New System.Drawing.Size(120, 31)
        Me.kbtnShow.TabIndex = 2
        Me.kbtnShow.Values.DropDownArrowColor = System.Drawing.Color.Empty
        Me.kbtnShow.Values.Text = "&Show"
        '
        'kbtnCancel
        '
        Me.kbtnCancel.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.kbtnCancel.DialogResult = System.Windows.Forms.DialogResult.Cancel
        Me.kbtnCancel.Location = New System.Drawing.Point(487, 16)
        Me.kbtnCancel.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.kbtnCancel.Name = "kbtnCancel"
        Me.kbtnCancel.Size = New System.Drawing.Size(120, 31)
        Me.kbtnCancel.TabIndex = 1
        Me.kbtnCancel.Values.DropDownArrowColor = System.Drawing.Color.Empty
        Me.kbtnCancel.Values.Text = "Ca&ncel"
        '
        'kryptonBorderEdge1
        '
        Me.kryptonBorderEdge1.Dock = System.Windows.Forms.DockStyle.Top
        Me.kryptonBorderEdge1.Location = New System.Drawing.Point(0, 0)
        Me.kryptonBorderEdge1.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.kryptonBorderEdge1.Name = "kryptonBorderEdge1"
        Me.kryptonBorderEdge1.Size = New System.Drawing.Size(623, 1)
        Me.kryptonBorderEdge1.Text = "kryptonBorderEdge1"
        '
        'kryptonPanel2
        '
        Me.kryptonPanel2.Controls.Add(Me.ktxtAssemblyLocation)
        Me.kryptonPanel2.Controls.Add(Me.kryptonLabel1)
        Me.kryptonPanel2.Dock = System.Windows.Forms.DockStyle.Fill
        Me.kryptonPanel2.Location = New System.Drawing.Point(0, 0)
        Me.kryptonPanel2.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.kryptonPanel2.Name = "kryptonPanel2"
        Me.kryptonPanel2.Size = New System.Drawing.Size(623, 284)
        Me.kryptonPanel2.TabIndex = 2
        '
        'ktxtAssemblyLocation
        '
        Me.ktxtAssemblyLocation.Location = New System.Drawing.Point(17, 49)
        Me.ktxtAssemblyLocation.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.ktxtAssemblyLocation.Name = "ktxtAssemblyLocation"
        Me.ktxtAssemblyLocation.ShowEllipsisButton = True
        Me.ktxtAssemblyLocation.Size = New System.Drawing.Size(577, 28)
        Me.ktxtAssemblyLocation.TabIndex = 1
        '
        'kryptonLabel1
        '
        Me.kryptonLabel1.LabelStyle = Krypton.Toolkit.LabelStyle.BoldControl
        Me.kryptonLabel1.Location = New System.Drawing.Point(17, 16)
        Me.kryptonLabel1.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.kryptonLabel1.Name = "kryptonLabel1"
        Me.kryptonLabel1.Size = New System.Drawing.Size(151, 24)
        Me.kryptonLabel1.TabIndex = 0
        Me.kryptonLabel1.Values.Text = "Assembly Location:"
        '
        'kcBrowseForAssembly
        '
        Me.kcBrowseForAssembly.Text = ".&.."
        '
        'Form1
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8F, 16F)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(623, 346)
        Me.Controls.Add(Me.kryptonPanel2)
        Me.Controls.Add(Me.kryptonPanel1)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.Fixed3D
        Me.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.Name = "Form1"
        Me.Text = "Form1"
        CType(Me.kryptonPanel1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.kryptonPanel1.ResumeLayout(False)
        Me.kryptonPanel1.PerformLayout()
        CType(Me.kryptonPanel2, System.ComponentModel.ISupportInitialize).EndInit()
        Me.kryptonPanel2.ResumeLayout(False)
        Me.kryptonPanel2.PerformLayout()
        Me.ResumeLayout(False)
    End Sub

    Friend WithEvents kryptonPanel1 As Krypton.Toolkit.KryptonPanel
    Friend WithEvents kbtnShow As Krypton.Toolkit.KryptonButton
    Friend WithEvents kbtnCancel As Krypton.Toolkit.KryptonButton
    Friend WithEvents kryptonBorderEdge1 As Krypton.Toolkit.KryptonBorderEdge
    Friend WithEvents kryptonPanel2 As Krypton.Toolkit.KryptonPanel
    Friend WithEvents kryptonLabel1 As Krypton.Toolkit.KryptonLabel
    Friend WithEvents ktxtAssemblyLocation As Krypton.Toolkit.KryptonTextBox
    Friend WithEvents kcBrowseForAssembly As Krypton.Toolkit.KryptonCommand
End Class
