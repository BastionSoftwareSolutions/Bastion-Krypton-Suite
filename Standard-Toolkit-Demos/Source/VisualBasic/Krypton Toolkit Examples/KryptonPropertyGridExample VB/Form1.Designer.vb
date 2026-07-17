' VB.NET twin of Source\Krypton Toolkit Examples\KryptonPropertyGridExample\Form1.Designer.cs (Bastion Phase 4c).
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
        Me.kryptonPropertyGrid1 = New Krypton.Toolkit.KryptonPropertyGrid()
        Me.kryptonLabel1 = New Krypton.Toolkit.KryptonLabel()
        Me.kryptonThemeComboBox1 = New Krypton.Toolkit.KryptonThemeComboBox()
        Me.kryptonButton1 = New Krypton.Toolkit.KryptonButton()
        Me.kryptonCheckBox1 = New Krypton.Toolkit.KryptonCheckBox()
        Me.kryptonCheckedListBox1 = New Krypton.Toolkit.KryptonCheckedListBox()
        Me.kryptonDateTimePicker1 = New Krypton.Toolkit.KryptonDateTimePicker()
        Me.kryptonMonthCalendar1 = New Krypton.Toolkit.KryptonMonthCalendar()
        Me.kryptonPropertyGrid2 = New System.Windows.Forms.PropertyGrid()
        CType(Me.kryptonThemeComboBox1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        Me.kryptonPropertyGrid1.Location = New System.Drawing.Point(17, 16)
        Me.kryptonPropertyGrid1.Margin = New System.Windows.Forms.Padding(4)
        Me.kryptonPropertyGrid1.Name = "kryptonPropertyGrid1"
        Me.kryptonPropertyGrid1.Padding = New System.Windows.Forms.Padding(1)
        Me.kryptonPropertyGrid1.SelectedObject = Me
        Me.kryptonPropertyGrid1.Size = New System.Drawing.Size(475, 502)
        Me.kryptonPropertyGrid1.TabIndex = 0
        Me.kryptonLabel1.LabelStyle = Krypton.Toolkit.LabelStyle.BoldControl
        Me.kryptonLabel1.Location = New System.Drawing.Point(17, 527)
        Me.kryptonLabel1.Margin = New System.Windows.Forms.Padding(4)
        Me.kryptonLabel1.Name = "kryptonLabel1"
        Me.kryptonLabel1.Size = New System.Drawing.Size(65, 24)
        Me.kryptonLabel1.TabIndex = 1
        Me.kryptonLabel1.Values.Text = "Theme:"
        Me.kryptonThemeComboBox1.DefaultPalette = Krypton.Toolkit.PaletteMode.Microsoft365Blue
        Me.kryptonThemeComboBox1.DisplayMember = "Key"
        Me.kryptonThemeComboBox1.DropDownWidth = 296
        Me.kryptonThemeComboBox1.IntegralHeight = False
        Me.kryptonThemeComboBox1.Location = New System.Drawing.Point(97, 527)
        Me.kryptonThemeComboBox1.Margin = New System.Windows.Forms.Padding(4)
        Me.kryptonThemeComboBox1.Name = "kryptonThemeComboBox1"
        Me.kryptonThemeComboBox1.Size = New System.Drawing.Size(395, 26)
        Me.kryptonThemeComboBox1.StateCommon.ComboBox.Content.TextH = Krypton.Toolkit.PaletteRelativeAlign.Near
        Me.kryptonThemeComboBox1.TabIndex = 2
        Me.kryptonThemeComboBox1.ValueMember = "Value"
        Me.kryptonButton1.Location = New System.Drawing.Point(548, 16)
        Me.kryptonButton1.Margin = New System.Windows.Forms.Padding(4)
        Me.kryptonButton1.Name = "kryptonButton1"
        Me.kryptonButton1.Size = New System.Drawing.Size(120, 31)
        Me.kryptonButton1.TabIndex = 3
        Me.kryptonButton1.Values.DropDownArrowColor = System.Drawing.Color.Empty
        kryptonButton1.Values.Text = "Click Me"
        Me.kryptonCheckBox1.Location = New System.Drawing.Point(548, 181)
        Me.kryptonCheckBox1.Margin = New System.Windows.Forms.Padding(4)
        Me.kryptonCheckBox1.Name = "kryptonCheckBox1"
        Me.kryptonCheckBox1.Size = New System.Drawing.Size(83, 24)
        Me.kryptonCheckBox1.TabIndex = 4
        Me.kryptonCheckBox1.Values.Text = "Click Me"
        Me.kryptonCheckedListBox1.Location = New System.Drawing.Point(548, 55)
        Me.kryptonCheckedListBox1.Margin = New System.Windows.Forms.Padding(4)
        Me.kryptonCheckedListBox1.Name = "kryptonCheckedListBox1"
        Me.kryptonCheckedListBox1.Size = New System.Drawing.Size(160, 118)
        Me.kryptonCheckedListBox1.TabIndex = 5
        Me.kryptonDateTimePicker1.Location = New System.Drawing.Point(717, 22)
        Me.kryptonDateTimePicker1.Margin = New System.Windows.Forms.Padding(4)
        Me.kryptonDateTimePicker1.Name = "kryptonDateTimePicker1"
        Me.kryptonDateTimePicker1.Size = New System.Drawing.Size(227, 25)
        Me.kryptonDateTimePicker1.TabIndex = 6
        Me.kryptonMonthCalendar1.Location = New System.Drawing.Point(717, 55)
        Me.kryptonMonthCalendar1.Margin = New System.Windows.Forms.Padding(4)
        Me.kryptonMonthCalendar1.Name = "kryptonMonthCalendar1"
        Me.kryptonMonthCalendar1.Size = New System.Drawing.Size(293, 218)
        Me.kryptonMonthCalendar1.TabIndex = 7
        Me.kryptonPropertyGrid2.BackColor = System.Drawing.Color.FromArgb(CType(CType(240, Byte), Integer), CType(CType(240, Byte), Integer), CType(CType(240, Byte), Integer))
        Me.kryptonPropertyGrid2.CategoryForeColor = System.Drawing.Color.White
        Me.kryptonPropertyGrid2.CommandsBackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.kryptonPropertyGrid2.CommandsForeColor = System.Drawing.Color.Black
        Me.kryptonPropertyGrid2.Font = New System.Drawing.Font("Segoe UI", 9F)
        Me.kryptonPropertyGrid2.HelpBackColor = System.Drawing.Color.FromArgb(CType(CType(99, Byte), Integer), CType(CType(108, Byte), Integer), CType(CType(135, Byte), Integer))
        Me.kryptonPropertyGrid2.HelpForeColor = System.Drawing.Color.White
        Me.kryptonPropertyGrid2.LineColor = System.Drawing.Color.FromArgb(CType(CType(99, Byte), Integer), CType(CType(108, Byte), Integer), CType(CType(135, Byte), Integer))
        Me.kryptonPropertyGrid2.Location = New System.Drawing.Point(500, 281)
        Me.kryptonPropertyGrid2.Margin = New System.Windows.Forms.Padding(4)
        Me.kryptonPropertyGrid2.Name = "kryptonPropertyGrid2"
        Me.kryptonPropertyGrid2.SelectedObject = Me
        Me.kryptonPropertyGrid2.Size = New System.Drawing.Size(510, 291)
        Me.kryptonPropertyGrid2.TabIndex = 9
        Me.kryptonPropertyGrid2.ViewBackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.kryptonPropertyGrid2.ViewForeColor = System.Drawing.Color.Black
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8F, 16F)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(1067, 576)
        Me.Controls.Add(Me.kryptonPropertyGrid2)
        Me.Controls.Add(Me.kryptonMonthCalendar1)
        Me.Controls.Add(Me.kryptonDateTimePicker1)
        Me.Controls.Add(Me.kryptonCheckedListBox1)
        Me.Controls.Add(Me.kryptonCheckBox1)
        Me.Controls.Add(Me.kryptonButton1)
        Me.Controls.Add(Me.kryptonThemeComboBox1)
        Me.Controls.Add(Me.kryptonLabel1)
        Me.Controls.Add(Me.kryptonPropertyGrid1)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.Fixed3D
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.Margin = New System.Windows.Forms.Padding(4)
        Me.MaximizeBox = False
        Me.Name = "Form1"
        Me.Text = "Krypton Property Grid Example"
        CType(Me.kryptonThemeComboBox1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()
    End Sub

    Friend WithEvents kryptonPropertyGrid1 As Krypton.Toolkit.KryptonPropertyGrid
    Friend WithEvents kryptonLabel1 As Krypton.Toolkit.KryptonLabel
    Friend WithEvents kryptonThemeComboBox1 As Krypton.Toolkit.KryptonThemeComboBox
    Friend WithEvents kryptonButton1 As Krypton.Toolkit.KryptonButton
    Friend WithEvents kryptonCheckBox1 As Krypton.Toolkit.KryptonCheckBox
    Friend WithEvents kryptonCheckedListBox1 As Krypton.Toolkit.KryptonCheckedListBox
    Friend WithEvents kryptonDateTimePicker1 As Krypton.Toolkit.KryptonDateTimePicker
    Friend WithEvents kryptonMonthCalendar1 As Krypton.Toolkit.KryptonMonthCalendar
    Friend WithEvents kryptonPropertyGrid2 As System.Windows.Forms.PropertyGrid
End Class
