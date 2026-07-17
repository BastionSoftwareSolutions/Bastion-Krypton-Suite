' VB.NET twin of Source\Krypton Toolkit Examples\KryptonDataGridView Examples\Form2.Designer.cs (Bastion Phase 4c).

<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class Form2
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

        Dim dataGridViewCellStyle1 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim dataGridViewCellStyle2 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim iconSpec1 As Krypton.Toolkit.IconSpec = New Krypton.Toolkit.IconSpec()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(Form2))
        Me.kryptonPanel1 = New Krypton.Toolkit.KryptonPanel()
        Me.kryptonDataGridView1 = New Krypton.Toolkit.KryptonDataGridView()
        Me.ID = New Krypton.Toolkit.KryptonDataGridViewTextBoxColumn()
        Me.Button = New Krypton.Toolkit.KryptonDataGridViewButtonColumn()
        Me.CheckBox = New Krypton.Toolkit.KryptonDataGridViewCheckBoxColumn()
        CType(Me.kryptonPanel1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.kryptonPanel1.SuspendLayout()
        CType(Me.kryptonDataGridView1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        ' kryptonPanel1
        '
        Me.kryptonPanel1.Controls.Add(Me.kryptonDataGridView1)
        Me.kryptonPanel1.Dock = System.Windows.Forms.DockStyle.Fill
        Me.kryptonPanel1.Location = New System.Drawing.Point(0, 0)
        Me.kryptonPanel1.Name = "kryptonPanel1"
        Me.kryptonPanel1.Size = New System.Drawing.Size(602, 443)
        Me.kryptonPanel1.TabIndex = 0
        '
        ' kryptonDataGridView1
        '
        Me.kryptonDataGridView1.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.kryptonDataGridView1.ColumnHeadersHeight = 36
        Me.kryptonDataGridView1.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() { Me.ID, Me.Button, Me.CheckBox})
        Me.kryptonDataGridView1.Location = New System.Drawing.Point(40, 44)
        Me.kryptonDataGridView1.Name = "kryptonDataGridView1"
        Me.kryptonDataGridView1.RowHeadersWidth = 51
        Me.kryptonDataGridView1.RowTemplate.Height = 24
        Me.kryptonDataGridView1.Size = New System.Drawing.Size(525, 245)
        Me.kryptonDataGridView1.TabIndex = 0
        '
        ' ID
        '
        Me.ID.DefaultCellStyle = dataGridViewCellStyle1
        Me.ID.HeaderText = "ID"
        Me.ID.MinimumWidth = 6
        Me.ID.Name = "ID"
        Me.ID.Width = 125
        '
        ' Button
        '
        Me.Button.HeaderText = "Button"
        Me.Button.MinimumWidth = 6
        Me.Button.Name = "Button"
        Me.Button.Width = 125
        '
        ' CheckBox
        '
        dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter
        dataGridViewCellStyle2.NullValue = False
        Me.CheckBox.DefaultCellStyle = dataGridViewCellStyle2
        Me.CheckBox.FalseValue = Nothing
        Me.CheckBox.HeaderText = "Checkbox"
        iconSpec1.Alignment = Krypton.Toolkit.IconSpec.IconAlignment.Right
        iconSpec1.Icon = CType(resources.GetObject("iconSpec1.Icon"), System.Drawing.Image)
        Me.CheckBox.IconSpecs.Add(iconSpec1)
        Me.CheckBox.IndeterminateValue = Nothing
        Me.CheckBox.MinimumWidth = 6
        Me.CheckBox.Name = "CheckBox"
        Me.CheckBox.TrueValue = Nothing
        Me.CheckBox.Width = 125
        '
        ' Form2
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 16.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(602, 443)
        Me.Controls.Add(Me.kryptonPanel1)
        Me.MaximumSize = New System.Drawing.Size(800, 700)
        Me.Name = "Form2"
        Me.Text = "Form2"
        CType(Me.kryptonPanel1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.kryptonPanel1.ResumeLayout(False)
        CType(Me.kryptonDataGridView1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub

#End Region

    Private WithEvents kryptonPanel1 As Krypton.Toolkit.KryptonPanel
    Private WithEvents kryptonDataGridView1 As Krypton.Toolkit.KryptonDataGridView
    Private WithEvents ID As Krypton.Toolkit.KryptonDataGridViewTextBoxColumn
    Private WithEvents Button As Krypton.Toolkit.KryptonDataGridViewButtonColumn
    Private WithEvents CheckBox As Krypton.Toolkit.KryptonDataGridViewCheckBoxColumn

End Class
