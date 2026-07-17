' VB.NET twin of Source\Krypton Toolkit Examples\KryptonFormFading Example\Form1.Designer.cs (Bastion Phase 4c).

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
        Me.kryptonPanel1 = New Krypton.Toolkit.KryptonPanel()
        Me.kbtnTest = New Krypton.Toolkit.KryptonButton()
        Me.kryptonPropertyGrid1 = New Krypton.Toolkit.KryptonPropertyGrid()
        CType(Me.kryptonPanel1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.kryptonPanel1.SuspendLayout()
        Me.SuspendLayout()
        '
        'kryptonPanel1
        '
        Me.kryptonPanel1.Controls.Add(Me.kbtnTest)
        Me.kryptonPanel1.Controls.Add(Me.kryptonPropertyGrid1)
        Me.kryptonPanel1.Dock = System.Windows.Forms.DockStyle.Fill
        Me.kryptonPanel1.Location = New System.Drawing.Point(0, 0)
        Me.kryptonPanel1.Margin = New System.Windows.Forms.Padding(4)
        Me.kryptonPanel1.Name = "kryptonPanel1"
        Me.kryptonPanel1.Size = New System.Drawing.Size(1079, 512)
        Me.kryptonPanel1.TabIndex = 0
        '
        'kbtnTest
        '
        Me.kbtnTest.Location = New System.Drawing.Point(479, 16)
        Me.kbtnTest.Margin = New System.Windows.Forms.Padding(4)
        Me.kbtnTest.Name = "kbtnTest"
        Me.kbtnTest.Size = New System.Drawing.Size(120, 31)
        Me.kbtnTest.TabIndex = 1
        Me.kbtnTest.Values.DropDownArrowColor = System.Drawing.Color.Empty
        Me.kbtnTest.Values.Text = "Test"
        '
        'kryptonPropertyGrid1
        '
        Me.kryptonPropertyGrid1.Location = New System.Drawing.Point(17, 16)
        Me.kryptonPropertyGrid1.Margin = New System.Windows.Forms.Padding(4)
        Me.kryptonPropertyGrid1.Name = "kryptonPropertyGrid1"
        Me.kryptonPropertyGrid1.Padding = New System.Windows.Forms.Padding(1)
        Me.kryptonPropertyGrid1.SelectedObject = Me
        Me.kryptonPropertyGrid1.Size = New System.Drawing.Size(452, 523)
        Me.kryptonPropertyGrid1.TabIndex = 0
        '
        'Form1
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 16.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(1079, 512)
        Me.Controls.Add(Me.kryptonPanel1)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle
        Me.Margin = New System.Windows.Forms.Padding(4)
        Me.MaximizeBox = False
        Me.MinimizeBox = False
        Me.Name = "Form1"
        Me.Text = "Krypton Form Fading Example"
        CType(Me.kryptonPanel1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.kryptonPanel1.ResumeLayout(False)
        Me.ResumeLayout(False)

    End Sub

#End Region

    Private WithEvents kryptonPanel1 As Krypton.Toolkit.KryptonPanel
    Private WithEvents kryptonPropertyGrid1 As Krypton.Toolkit.KryptonPropertyGrid
    Private WithEvents kbtnTest As Krypton.Toolkit.KryptonButton

End Class
