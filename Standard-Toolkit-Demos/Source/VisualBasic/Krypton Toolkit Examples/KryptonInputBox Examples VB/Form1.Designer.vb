' VB.NET twin of Source\Krypton Toolkit Examples\KryptonInputBox Examples\Form1.Designer.cs (Bastion Phase 4c).

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
        Me.kryptonPanel1 = New Krypton.Toolkit.KryptonPanel()
        Me.kbtnShow = New Krypton.Toolkit.KryptonButton()
        Me.kryptonBorderEdge1 = New Krypton.Toolkit.KryptonBorderEdge()
        Me.kryptonPanel2 = New Krypton.Toolkit.KryptonPanel()
        Me.kchkUsePasswordOption = New Krypton.Toolkit.KryptonCheckBox()
        Me.kbtnCueTypeface = New Krypton.Toolkit.KryptonButton()
        Me.kcbCueTextColour = New Krypton.Toolkit.KryptonColorButton()
        Me.ktxtCueText = New Krypton.Toolkit.KryptonTextBox()
        Me.ktxtDefaultResponseText = New Krypton.Toolkit.KryptonTextBox()
        Me.ktxtCaptionText = New Krypton.Toolkit.KryptonTextBox()
        Me.ktxtPromptText = New Krypton.Toolkit.KryptonTextBox()
        Me.kryptonLabel4 = New Krypton.Toolkit.KryptonLabel()
        Me.kryptonLabel3 = New Krypton.Toolkit.KryptonLabel()
        Me.kryptonLabel2 = New Krypton.Toolkit.KryptonLabel()
        Me.kryptonLabel1 = New Krypton.Toolkit.KryptonLabel()
        Me.kryptonManager1 = New Krypton.Toolkit.KryptonManager(Me.components)
        CType(Me.kryptonPanel1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.kryptonPanel1.SuspendLayout()
        CType(Me.kryptonPanel2, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.kryptonPanel2.SuspendLayout()
        Me.SuspendLayout()
        '
        ' kryptonPanel1
        '
        Me.kryptonPanel1.Controls.Add(Me.kbtnShow)
        Me.kryptonPanel1.Controls.Add(Me.kryptonBorderEdge1)
        Me.kryptonPanel1.Dock = System.Windows.Forms.DockStyle.Bottom
        Me.kryptonPanel1.Location = New System.Drawing.Point(0, 262)
        Me.kryptonPanel1.Margin = New System.Windows.Forms.Padding(4)
        Me.kryptonPanel1.Name = "kryptonPanel1"
        Me.kryptonPanel1.Size = New System.Drawing.Size(665, 62)
        Me.kryptonPanel1.TabIndex = 1
        '
        ' kbtnShow
        '
        Me.kbtnShow.Location = New System.Drawing.Point(264, 16)
        Me.kbtnShow.Margin = New System.Windows.Forms.Padding(4)
        Me.kbtnShow.Name = "kbtnShow"
        Me.kbtnShow.Size = New System.Drawing.Size(120, 31)
        Me.kbtnShow.TabIndex = 1
        Me.kbtnShow.Values.DropDownArrowColor = System.Drawing.Color.Empty
        Me.kbtnShow.Values.Text = "&Show"
        '
        ' kryptonBorderEdge1
        '
        Me.kryptonBorderEdge1.Dock = System.Windows.Forms.DockStyle.Top
        Me.kryptonBorderEdge1.Location = New System.Drawing.Point(0, 0)
        Me.kryptonBorderEdge1.Margin = New System.Windows.Forms.Padding(4)
        Me.kryptonBorderEdge1.Name = "kryptonBorderEdge1"
        Me.kryptonBorderEdge1.Size = New System.Drawing.Size(665, 1)
        Me.kryptonBorderEdge1.Text = "kryptonBorderEdge1"
        '
        ' kryptonPanel2
        '
        Me.kryptonPanel2.Controls.Add(Me.kchkUsePasswordOption)
        Me.kryptonPanel2.Controls.Add(Me.kbtnCueTypeface)
        Me.kryptonPanel2.Controls.Add(Me.kcbCueTextColour)
        Me.kryptonPanel2.Controls.Add(Me.ktxtCueText)
        Me.kryptonPanel2.Controls.Add(Me.ktxtDefaultResponseText)
        Me.kryptonPanel2.Controls.Add(Me.ktxtCaptionText)
        Me.kryptonPanel2.Controls.Add(Me.ktxtPromptText)
        Me.kryptonPanel2.Controls.Add(Me.kryptonLabel4)
        Me.kryptonPanel2.Controls.Add(Me.kryptonLabel3)
        Me.kryptonPanel2.Controls.Add(Me.kryptonLabel2)
        Me.kryptonPanel2.Controls.Add(Me.kryptonLabel1)
        Me.kryptonPanel2.Dock = System.Windows.Forms.DockStyle.Fill
        Me.kryptonPanel2.Location = New System.Drawing.Point(0, 0)
        Me.kryptonPanel2.Margin = New System.Windows.Forms.Padding(4)
        Me.kryptonPanel2.Name = "kryptonPanel2"
        Me.kryptonPanel2.Size = New System.Drawing.Size(665, 262)
        Me.kryptonPanel2.TabIndex = 0
        '
        ' kchkUsePasswordOption
        '
        Me.kchkUsePasswordOption.Location = New System.Drawing.Point(192, 234)
        Me.kchkUsePasswordOption.Margin = New System.Windows.Forms.Padding(4)
        Me.kchkUsePasswordOption.Name = "kchkUsePasswordOption"
        Me.kchkUsePasswordOption.Size = New System.Drawing.Size(170, 24)
        Me.kchkUsePasswordOption.TabIndex = 10
        Me.kchkUsePasswordOption.Values.Text = "Use Password &Option"
        '
        ' kbtnCueTypeface
        '
        Me.kbtnCueTypeface.Location = New System.Drawing.Point(385, 195)
        Me.kbtnCueTypeface.Margin = New System.Windows.Forms.Padding(4)
        Me.kbtnCueTypeface.Name = "kbtnCueTypeface"
        Me.kbtnCueTypeface.Size = New System.Drawing.Size(120, 31)
        Me.kbtnCueTypeface.TabIndex = 9
        Me.kbtnCueTypeface.Values.DropDownArrowColor = System.Drawing.Color.Empty
        Me.kbtnCueTypeface.Values.Text = "Cue T&ypeface"
        '
        ' kcbCueTextColour
        '
        Me.kcbCueTextColour.Location = New System.Drawing.Point(192, 195)
        Me.kcbCueTextColour.Margin = New System.Windows.Forms.Padding(4)
        Me.kcbCueTextColour.Name = "kcbCueTextColour"
        Me.kcbCueTextColour.SelectedColor = System.Drawing.Color.Gray
        Me.kcbCueTextColour.Size = New System.Drawing.Size(184, 31)
        Me.kcbCueTextColour.TabIndex = 8
        Me.kcbCueTextColour.Values.Text = "C&ue Colour"
        '
        ' ktxtCueText
        '
        Me.ktxtCueText.Location = New System.Drawing.Point(179, 158)
        Me.ktxtCueText.Margin = New System.Windows.Forms.Padding(4)
        Me.ktxtCueText.Name = "ktxtCueText"
        Me.ktxtCueText.Size = New System.Drawing.Size(444, 27)
        Me.ktxtCueText.TabIndex = 7
        Me.ktxtCueText.Text = "Sample Cue Text"
        '
        ' ktxtDefaultResponseText
        '
        Me.ktxtDefaultResponseText.Location = New System.Drawing.Point(179, 122)
        Me.ktxtDefaultResponseText.Margin = New System.Windows.Forms.Padding(4)
        Me.ktxtDefaultResponseText.Name = "ktxtDefaultResponseText"
        Me.ktxtDefaultResponseText.Size = New System.Drawing.Size(444, 27)
        Me.ktxtDefaultResponseText.TabIndex = 5
        Me.ktxtDefaultResponseText.Text = "Default Response"
        '
        ' ktxtCaptionText
        '
        Me.ktxtCaptionText.Location = New System.Drawing.Point(178, 13)
        Me.ktxtCaptionText.Margin = New System.Windows.Forms.Padding(4)
        Me.ktxtCaptionText.Name = "ktxtCaptionText"
        Me.ktxtCaptionText.Size = New System.Drawing.Size(444, 27)
        Me.ktxtCaptionText.TabIndex = 1
        Me.ktxtCaptionText.Text = "Windows Title"
        '
        ' ktxtPromptText
        '
        Me.ktxtPromptText.Location = New System.Drawing.Point(178, 48)
        Me.ktxtPromptText.Margin = New System.Windows.Forms.Padding(4)
        Me.ktxtPromptText.Multiline = True
        Me.ktxtPromptText.Name = "ktxtPromptText"
        Me.ktxtPromptText.ScrollBars = System.Windows.Forms.ScrollBars.Vertical
        Me.ktxtPromptText.Size = New System.Drawing.Size(444, 66)
        Me.ktxtPromptText.TabIndex = 3
        Me.ktxtPromptText.Text = "User Prompt"
        '
        ' kryptonLabel4
        '
        Me.kryptonLabel4.Location = New System.Drawing.Point(84, 158)
        Me.kryptonLabel4.Margin = New System.Windows.Forms.Padding(4)
        Me.kryptonLabel4.Name = "kryptonLabel4"
        Me.kryptonLabel4.Size = New System.Drawing.Size(74, 24)
        Me.kryptonLabel4.TabIndex = 6
        Me.kryptonLabel4.Values.Text = "Cue &Text:"
        '
        ' kryptonLabel3
        '
        Me.kryptonLabel3.Location = New System.Drawing.Point(17, 122)
        Me.kryptonLabel3.Margin = New System.Windows.Forms.Padding(4)
        Me.kryptonLabel3.Name = "kryptonLabel3"
        Me.kryptonLabel3.Size = New System.Drawing.Size(134, 24)
        Me.kryptonLabel3.TabIndex = 4
        Me.kryptonLabel3.Values.Text = "Default &Response:"
        '
        ' kryptonLabel2
        '
        Me.kryptonLabel2.Location = New System.Drawing.Point(89, 13)
        Me.kryptonLabel2.Margin = New System.Windows.Forms.Padding(4)
        Me.kryptonLabel2.Name = "kryptonLabel2"
        Me.kryptonLabel2.Size = New System.Drawing.Size(68, 24)
        Me.kryptonLabel2.TabIndex = 0
        Me.kryptonLabel2.Values.Text = "&Caption:"
        '
        ' kryptonLabel1
        '
        Me.kryptonLabel1.Location = New System.Drawing.Point(92, 48)
        Me.kryptonLabel1.Margin = New System.Windows.Forms.Padding(4)
        Me.kryptonLabel1.Name = "kryptonLabel1"
        Me.kryptonLabel1.Size = New System.Drawing.Size(66, 24)
        Me.kryptonLabel1.TabIndex = 2
        Me.kryptonLabel1.Values.Text = "&Prompt:"
        '
        ' kryptonManager1
        '
        Me.kryptonManager1.GlobalPaletteMode = Krypton.Toolkit.PaletteMode.Office2007Blue
        '
        ' Form1
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 16.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(665, 324)
        Me.Controls.Add(Me.kryptonPanel2)
        Me.Controls.Add(Me.kryptonPanel1)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.Fixed3D
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.Margin = New System.Windows.Forms.Padding(4)
        Me.MaximizeBox = False
        Me.MinimizeBox = False
        Me.Name = "Form1"
        Me.Text = "Krypton Input Box"
        CType(Me.kryptonPanel1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.kryptonPanel1.ResumeLayout(False)
        Me.kryptonPanel1.PerformLayout()
        CType(Me.kryptonPanel2, System.ComponentModel.ISupportInitialize).EndInit()
        Me.kryptonPanel2.ResumeLayout(False)
        Me.kryptonPanel2.PerformLayout()
        Me.ResumeLayout(False)

    End Sub

#End Region

    Private WithEvents kryptonPanel1 As Krypton.Toolkit.KryptonPanel
    Private WithEvents kbtnShow As Krypton.Toolkit.KryptonButton
    Private WithEvents kryptonBorderEdge1 As Krypton.Toolkit.KryptonBorderEdge
    Private WithEvents kryptonPanel2 As Krypton.Toolkit.KryptonPanel
    Private WithEvents kbtnCueTypeface As Krypton.Toolkit.KryptonButton
    Private WithEvents kcbCueTextColour As Krypton.Toolkit.KryptonColorButton
    Private WithEvents ktxtCueText As Krypton.Toolkit.KryptonTextBox
    Private WithEvents ktxtDefaultResponseText As Krypton.Toolkit.KryptonTextBox
    Private WithEvents ktxtCaptionText As Krypton.Toolkit.KryptonTextBox
    Private WithEvents ktxtPromptText As Krypton.Toolkit.KryptonTextBox
    Private WithEvents kryptonLabel4 As Krypton.Toolkit.KryptonLabel
    Private WithEvents kryptonLabel3 As Krypton.Toolkit.KryptonLabel
    Private WithEvents kryptonLabel2 As Krypton.Toolkit.KryptonLabel
    Private WithEvents kryptonLabel1 As Krypton.Toolkit.KryptonLabel
    Private WithEvents kchkUsePasswordOption As Krypton.Toolkit.KryptonCheckBox
    Private WithEvents kryptonManager1 As Krypton.Toolkit.KryptonManager

End Class
