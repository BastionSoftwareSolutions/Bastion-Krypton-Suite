' VB.NET twin of Source\Krypton Toolkit Examples\Krypton Theme Selector\Form1.Designer.cs (Bastion Phase 4c).
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(Form1))
        Me.kryptonPanel1 = New Krypton.Toolkit.KryptonPanel()
        Me.kbtnUseListBox = New Krypton.Toolkit.KryptonButton()
        Me.kryptonThemeComboBox1 = New Krypton.Toolkit.KryptonThemeComboBox()
        Me.kryptonLabel1 = New Krypton.Toolkit.KryptonLabel()
        CType(Me.kryptonPanel1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.kryptonPanel1.SuspendLayout()
        CType(Me.kryptonThemeComboBox1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'kryptonPanel1
        '
        Me.kryptonPanel1.Controls.Add(Me.kbtnUseListBox)
        Me.kryptonPanel1.Controls.Add(Me.kryptonThemeComboBox1)
        Me.kryptonPanel1.Controls.Add(Me.kryptonLabel1)
        Me.kryptonPanel1.Dock = System.Windows.Forms.DockStyle.Fill
        Me.kryptonPanel1.Location = New System.Drawing.Point(0, 0)
        Me.kryptonPanel1.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.kryptonPanel1.Name = "kryptonPanel1"
        Me.kryptonPanel1.Size = New System.Drawing.Size(600, 143)
        Me.kryptonPanel1.TabIndex = 0
        '
        'kbtnUseListBox
        '
        Me.kbtnUseListBox.Location = New System.Drawing.Point(17, 107)
        Me.kbtnUseListBox.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.kbtnUseListBox.Name = "kbtnUseListBox"
        Me.kbtnUseListBox.Size = New System.Drawing.Size(120, 31)
        Me.kbtnUseListBox.TabIndex = 2
        Me.kbtnUseListBox.Values.DropDownArrowColor = System.Drawing.Color.Empty
        Me.kbtnUseListBox.Values.Text = "Use ListBox"
        '
        'kryptonThemeComboBox1
        '
        Me.kryptonThemeComboBox1.DisplayMember = "Key"
        Me.kryptonThemeComboBox1.DropDownWidth = 278
        Me.kryptonThemeComboBox1.IntegralHeight = False
        Me.kryptonThemeComboBox1.Location = New System.Drawing.Point(201, 58)
        Me.kryptonThemeComboBox1.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.kryptonThemeComboBox1.Name = "kryptonThemeComboBox1"
        Me.kryptonThemeComboBox1.Size = New System.Drawing.Size(371, 28)
        Me.kryptonThemeComboBox1.StateCommon.ComboBox.Content.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.kryptonThemeComboBox1.StateCommon.ComboBox.Content.TextH = Krypton.Toolkit.PaletteRelativeAlign.Near
        Me.kryptonThemeComboBox1.TabIndex = 1
        Me.kryptonThemeComboBox1.ValueMember = "Value"
        '
        'kryptonLabel1
        '
        Me.kryptonLabel1.LabelStyle = Krypton.Toolkit.LabelStyle.BoldControl
        Me.kryptonLabel1.Location = New System.Drawing.Point(16, 59)
        Me.kryptonLabel1.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.kryptonLabel1.Name = "kryptonLabel1"
        Me.kryptonLabel1.Size = New System.Drawing.Size(164, 26)
        Me.kryptonLabel1.StateCommon.ShortText.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.kryptonLabel1.TabIndex = 0
        Me.kryptonLabel1.Values.Text = "Selected Theme:"
        '
        'Form1
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8F, 16F)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(600, 143)
        Me.Controls.Add(Me.kryptonPanel1)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.Fixed3D
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.MaximizeBox = False
        Me.MinimizeBox = False
        Me.Name = "Form1"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Krypton Theme Selector"
        CType(Me.kryptonPanel1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.kryptonPanel1.ResumeLayout(False)
        Me.kryptonPanel1.PerformLayout()
        CType(Me.kryptonThemeComboBox1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
    End Sub

    Friend WithEvents kryptonPanel1 As Krypton.Toolkit.KryptonPanel
    Friend WithEvents kryptonLabel1 As Krypton.Toolkit.KryptonLabel
    Friend WithEvents kryptonThemeComboBox1 As Krypton.Toolkit.KryptonThemeComboBox
    Friend WithEvents kbtnUseListBox As Krypton.Toolkit.KryptonButton
End Class
