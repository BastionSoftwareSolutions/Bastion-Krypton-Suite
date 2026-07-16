' VB.NET twin of Source\Krypton Toolkit Examples\KryptonHelpIcon Examples\Form1.Designer.cs (Bastion Phase 4c).

<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class Form1
    Inherits Krypton.Toolkit.KryptonForm

    ''' <summary>
    '''  Required designer variable.
    ''' </summary>
    Private components As System.ComponentModel.IContainer

    ''' <summary>
    '''  Clean up any resources being used.
    ''' </summary>
    ''' <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
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

#Region "Windows Form Designer generated code"

    ''' <summary>
    '''  Required method for Designer support - do not modify
    '''  the contents of this method with the code editor.
    ''' </summary>
    <System.Diagnostics.DebuggerStepThrough()>
    Private Sub InitializeComponent()
        Me.components = New System.ComponentModel.Container()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(Form1))
        Me.bsHelpIcon = New Krypton.Toolkit.ButtonSpecAny()
        Me.kryptonPanel1 = New Krypton.Toolkit.KryptonPanel()
        Me.kryptonLabel1 = New Krypton.Toolkit.KryptonLabel()
        Me.kryptonThemeComboBox1 = New Krypton.Toolkit.KryptonThemeComboBox()
        Me.kryptonManager = New Krypton.Toolkit.KryptonManager(Me.components)
        CType(Me.kryptonPanel1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.kryptonPanel1.SuspendLayout()
        CType(Me.kryptonThemeComboBox1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'bsHelpIcon
        '
        Me.bsHelpIcon.Type = Krypton.Toolkit.PaletteButtonSpecStyle.FormHelp
        Me.bsHelpIcon.UniqueName = "eca54f2bd9884c1ab2f772b438fa4e8b"
        '
        'kryptonPanel1
        '
        Me.kryptonPanel1.Controls.Add(Me.kryptonLabel1)
        Me.kryptonPanel1.Controls.Add(Me.kryptonThemeComboBox1)
        Me.kryptonPanel1.Dock = System.Windows.Forms.DockStyle.Fill
        Me.kryptonPanel1.Location = New System.Drawing.Point(0, 0)
        Me.kryptonPanel1.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.kryptonPanel1.Name = "kryptonPanel1"
        Me.kryptonPanel1.Size = New System.Drawing.Size(681, 86)
        Me.kryptonPanel1.TabIndex = 0
        '
        'kryptonLabel1
        '
        Me.kryptonLabel1.LabelStyle = Krypton.Toolkit.LabelStyle.BoldControl
        Me.kryptonLabel1.Location = New System.Drawing.Point(19, 20)
        Me.kryptonLabel1.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.kryptonLabel1.Name = "kryptonLabel1"
        Me.kryptonLabel1.Size = New System.Drawing.Size(122, 24)
        Me.kryptonLabel1.TabIndex = 3
        Me.kryptonLabel1.Values.Text = "Select a theme:"
        '
        'kryptonThemeComboBox1
        '
        Me.kryptonThemeComboBox1.DefaultPalette = Krypton.Toolkit.PaletteMode.Office2007Blue
        Me.kryptonThemeComboBox1.DropDownWidth = 477
        Me.kryptonThemeComboBox1.IntegralHeight = False
        Me.kryptonThemeComboBox1.Location = New System.Drawing.Point(17, 52)
        Me.kryptonThemeComboBox1.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.kryptonThemeComboBox1.Name = "kryptonThemeComboBox1"
        Me.kryptonThemeComboBox1.Size = New System.Drawing.Size(636, 26)
        Me.kryptonThemeComboBox1.StateCommon.ComboBox.Content.TextH = Krypton.Toolkit.PaletteRelativeAlign.Near
        Me.kryptonThemeComboBox1.TabIndex = 2
        '
        'kryptonManager
        '
        Me.kryptonManager.GlobalPaletteMode = Krypton.Toolkit.PaletteMode.Office2007Blue
        '
        'Form1
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 16.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ButtonSpecs.Add(Me.bsHelpIcon)
        Me.ClientSize = New System.Drawing.Size(681, 86)
        Me.Controls.Add(Me.kryptonPanel1)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.Fixed3D
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.MaximizeBox = False
        Me.Name = "Form1"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Krypton Help Icon Example"
        CType(Me.kryptonPanel1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.kryptonPanel1.ResumeLayout(False)
        Me.kryptonPanel1.PerformLayout()
        CType(Me.kryptonThemeComboBox1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub

#End Region

    Private WithEvents bsHelpIcon As Krypton.Toolkit.ButtonSpecAny
    Private WithEvents kryptonPanel1 As Krypton.Toolkit.KryptonPanel
    Private WithEvents kryptonManager As Krypton.Toolkit.KryptonManager
    Private WithEvents kryptonLabel1 As Krypton.Toolkit.KryptonLabel
    Private WithEvents kryptonThemeComboBox1 As Krypton.Toolkit.KryptonThemeComboBox

End Class
