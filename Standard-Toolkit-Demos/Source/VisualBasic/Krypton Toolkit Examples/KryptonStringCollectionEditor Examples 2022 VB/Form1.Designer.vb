' VB.NET twin of Source\Krypton Toolkit Examples\KryptonStringCollectionEditor Examples 2022\Form1.Designer.cs (Bastion Phase 4c).
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
        Me.kryptonLabel6 = New Krypton.Toolkit.KryptonLabel()
        Me.ktxtHelpMessageBoxText = New Krypton.Toolkit.KryptonTextBox()
        Me.kryptonLabel5 = New Krypton.Toolkit.KryptonLabel()
        Me.ktxtHelpMessageBoxTitleText = New Krypton.Toolkit.KryptonTextBox()
        Me.kryptonLabel4 = New Krypton.Toolkit.KryptonLabel()
        Me.ktxtCancelButtonText = New Krypton.Toolkit.KryptonTextBox()
        Me.kryptonLabel3 = New Krypton.Toolkit.KryptonLabel()
        Me.ktxOKButtonText = New Krypton.Toolkit.KryptonTextBox()
        Me.kryptonLabel2 = New Krypton.Toolkit.KryptonLabel()
        Me.ktxtCueText = New Krypton.Toolkit.KryptonTextBox()
        Me.kryptonLabel1 = New Krypton.Toolkit.KryptonLabel()
        Me.ktxtHeaderText = New Krypton.Toolkit.KryptonTextBox()
        Me.kcbUseRichTextBox = New Krypton.Toolkit.KryptonCheckBox()
        Me.kbtnShow = New Krypton.Toolkit.KryptonButton()
        CType(Me.kryptonPanel1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.kryptonPanel1.SuspendLayout()
        Me.SuspendLayout()
        Me.kryptonPanel1.Controls.Add(Me.kryptonLabel6)
        Me.kryptonPanel1.Controls.Add(Me.ktxtHelpMessageBoxText)
        Me.kryptonPanel1.Controls.Add(Me.kryptonLabel5)
        Me.kryptonPanel1.Controls.Add(Me.ktxtHelpMessageBoxTitleText)
        Me.kryptonPanel1.Controls.Add(Me.kryptonLabel4)
        Me.kryptonPanel1.Controls.Add(Me.ktxtCancelButtonText)
        Me.kryptonPanel1.Controls.Add(Me.kryptonLabel3)
        Me.kryptonPanel1.Controls.Add(Me.ktxOKButtonText)
        Me.kryptonPanel1.Controls.Add(Me.kryptonLabel2)
        Me.kryptonPanel1.Controls.Add(Me.ktxtCueText)
        Me.kryptonPanel1.Controls.Add(Me.kryptonLabel1)
        Me.kryptonPanel1.Controls.Add(Me.ktxtHeaderText)
        Me.kryptonPanel1.Controls.Add(Me.kcbUseRichTextBox)
        Me.kryptonPanel1.Controls.Add(Me.kbtnShow)
        Me.kryptonPanel1.Dock = System.Windows.Forms.DockStyle.Fill
        Me.kryptonPanel1.Location = New System.Drawing.Point(0, 0)
        Me.kryptonPanel1.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.kryptonPanel1.Name = "kryptonPanel1"
        Me.kryptonPanel1.Size = New System.Drawing.Size(743, 271)
        Me.kryptonPanel1.TabIndex = 0
        Me.kryptonLabel6.LabelStyle = Krypton.Toolkit.LabelStyle.BoldControl
        Me.kryptonLabel6.Location = New System.Drawing.Point(16, 193)
        Me.kryptonLabel6.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.kryptonLabel6.Name = "kryptonLabel6"
        Me.kryptonLabel6.Size = New System.Drawing.Size(181, 24)
        Me.kryptonLabel6.TabIndex = 12
        Me.kryptonLabel6.Values.Text = "Help Messagebox Text:"
        Me.ktxtHelpMessageBoxText.Location = New System.Drawing.Point(257, 193)
        Me.ktxtHelpMessageBoxText.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.ktxtHelpMessageBoxText.Name = "ktxtHelpMessageBoxText"
        Me.ktxtHelpMessageBoxText.Size = New System.Drawing.Size(457, 27)
        Me.ktxtHelpMessageBoxText.TabIndex = 13
        Me.ktxtHelpMessageBoxText.Text = resources.GetString("ktxtHelpMessageBoxText.Text")
        Me.kryptonLabel5.LabelStyle = Krypton.Toolkit.LabelStyle.BoldControl
        Me.kryptonLabel5.Location = New System.Drawing.Point(16, 158)
        Me.kryptonLabel5.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.kryptonLabel5.Name = "kryptonLabel5"
        Me.kryptonLabel5.Size = New System.Drawing.Size(217, 24)
        Me.kryptonLabel5.TabIndex = 10
        Me.kryptonLabel5.Values.Text = "Help Messagebox Title Text:"
        Me.ktxtHelpMessageBoxTitleText.Location = New System.Drawing.Point(257, 158)
        Me.ktxtHelpMessageBoxTitleText.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.ktxtHelpMessageBoxTitleText.Name = "ktxtHelpMessageBoxTitleText"
        Me.ktxtHelpMessageBoxTitleText.Size = New System.Drawing.Size(457, 27)
        Me.ktxtHelpMessageBoxTitleText.TabIndex = 11
        Me.ktxtHelpMessageBoxTitleText.Text = "Krypton String Collection Editor Help"
        Me.kryptonLabel4.LabelStyle = Krypton.Toolkit.LabelStyle.BoldControl
        Me.kryptonLabel4.Location = New System.Drawing.Point(16, 122)
        Me.kryptonLabel4.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.kryptonLabel4.Name = "kryptonLabel4"
        Me.kryptonLabel4.Size = New System.Drawing.Size(154, 24)
        Me.kryptonLabel4.TabIndex = 8
        Me.kryptonLabel4.Values.Text = "Cancel Button Text:"
        Me.ktxtCancelButtonText.Location = New System.Drawing.Point(192, 122)
        Me.ktxtCancelButtonText.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.ktxtCancelButtonText.Name = "ktxtCancelButtonText"
        Me.ktxtCancelButtonText.Size = New System.Drawing.Size(523, 27)
        Me.ktxtCancelButtonText.TabIndex = 9
        Me.ktxtCancelButtonText.Text = "C&ancel"
        Me.kryptonLabel3.LabelStyle = Krypton.Toolkit.LabelStyle.BoldControl
        Me.kryptonLabel3.Location = New System.Drawing.Point(16, 86)
        Me.kryptonLabel3.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.kryptonLabel3.Name = "kryptonLabel3"
        Me.kryptonLabel3.Size = New System.Drawing.Size(127, 24)
        Me.kryptonLabel3.TabIndex = 6
        Me.kryptonLabel3.Values.Text = "Ok Button Text:"
        Me.ktxOKButtonText.Location = New System.Drawing.Point(161, 86)
        Me.ktxOKButtonText.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.ktxOKButtonText.Name = "ktxOKButtonText"
        Me.ktxOKButtonText.Size = New System.Drawing.Size(553, 27)
        Me.ktxOKButtonText.TabIndex = 7
        Me.ktxOKButtonText.Text = "O&K"
        Me.kryptonLabel2.LabelStyle = Krypton.Toolkit.LabelStyle.BoldControl
        Me.kryptonLabel2.Location = New System.Drawing.Point(16, 50)
        Me.kryptonLabel2.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.kryptonLabel2.Name = "kryptonLabel2"
        Me.kryptonLabel2.Size = New System.Drawing.Size(79, 24)
        Me.kryptonLabel2.TabIndex = 4
        Me.kryptonLabel2.Values.Text = "Cue Text:"
        Me.ktxtCueText.Location = New System.Drawing.Point(137, 50)
        Me.ktxtCueText.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.ktxtCueText.Name = "ktxtCueText"
        Me.ktxtCueText.Size = New System.Drawing.Size(577, 27)
        Me.ktxtCueText.TabIndex = 5
        Me.kryptonLabel1.LabelStyle = Krypton.Toolkit.LabelStyle.BoldControl
        Me.kryptonLabel1.Location = New System.Drawing.Point(16, 15)
        Me.kryptonLabel1.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.kryptonLabel1.Name = "kryptonLabel1"
        Me.kryptonLabel1.Size = New System.Drawing.Size(104, 24)
        Me.kryptonLabel1.TabIndex = 1
        Me.kryptonLabel1.Values.Text = "Header Text:"
        Me.ktxtHeaderText.Location = New System.Drawing.Point(137, 15)
        Me.ktxtHeaderText.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.ktxtHeaderText.Name = "ktxtHeaderText"
        Me.ktxtHeaderText.Size = New System.Drawing.Size(577, 27)
        Me.ktxtHeaderText.TabIndex = 2
        Me.ktxtHeaderText.Text = "Enter the strings in the collection (one per line):"
        Me.kcbUseRichTextBox.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Left), System.Windows.Forms.AnchorStyles)
        Me.kcbUseRichTextBox.Location = New System.Drawing.Point(16, 232)
        Me.kcbUseRichTextBox.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.kcbUseRichTextBox.Name = "kcbUseRichTextBox"
        Me.kcbUseRichTextBox.Size = New System.Drawing.Size(145, 24)
        Me.kcbUseRichTextBox.TabIndex = 3
        Me.kcbUseRichTextBox.Values.Text = "Use Rich &Text Box"
        Me.kbtnShow.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.kbtnShow.Location = New System.Drawing.Point(607, 225)
        Me.kbtnShow.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.kbtnShow.Name = "kbtnShow"
        Me.kbtnShow.Size = New System.Drawing.Size(120, 31)
        Me.kbtnShow.TabIndex = 0
        Me.kbtnShow.Values.DropDownArrowColor = System.Drawing.Color.Empty
        Me.kbtnShow.Values.Text = "&Show"
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8F, 16F)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(743, 271)
        Me.Controls.Add(Me.kryptonPanel1)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.Fixed3D
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.MaximizeBox = False
        Me.MinimizeBox = False
        Me.Name = "Form1"
        Me.Text = "Form1"
        CType(Me.kryptonPanel1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.kryptonPanel1.ResumeLayout(False)
        Me.kryptonPanel1.PerformLayout()
        Me.ResumeLayout(False)
    End Sub

    Friend WithEvents kryptonPanel1 As Krypton.Toolkit.KryptonPanel
    Friend WithEvents kbtnShow As Krypton.Toolkit.KryptonButton
    Friend WithEvents kryptonLabel6 As Krypton.Toolkit.KryptonLabel
    Friend WithEvents ktxtHelpMessageBoxText As Krypton.Toolkit.KryptonTextBox
    Friend WithEvents kryptonLabel5 As Krypton.Toolkit.KryptonLabel
    Friend WithEvents ktxtHelpMessageBoxTitleText As Krypton.Toolkit.KryptonTextBox
    Friend WithEvents kryptonLabel4 As Krypton.Toolkit.KryptonLabel
    Friend WithEvents ktxtCancelButtonText As Krypton.Toolkit.KryptonTextBox
    Friend WithEvents kryptonLabel3 As Krypton.Toolkit.KryptonLabel
    Friend WithEvents ktxOKButtonText As Krypton.Toolkit.KryptonTextBox
    Friend WithEvents kryptonLabel2 As Krypton.Toolkit.KryptonLabel
    Friend WithEvents ktxtCueText As Krypton.Toolkit.KryptonTextBox
    Friend WithEvents kryptonLabel1 As Krypton.Toolkit.KryptonLabel
    Friend WithEvents ktxtHeaderText As Krypton.Toolkit.KryptonTextBox
    Friend WithEvents kcbUseRichTextBox As Krypton.Toolkit.KryptonCheckBox
End Class
