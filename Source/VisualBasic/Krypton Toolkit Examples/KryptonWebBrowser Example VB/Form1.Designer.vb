' VB.NET twin of Source\Krypton Toolkit Examples\KryptonWebBrowser Example\Form1.Designer.cs (Bastion Phase 4c).
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
        Me.components = New System.ComponentModel.Container()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(Form1))
        Me.webBrowser1 = New System.Windows.Forms.WebBrowser()
        Me.contextMenuStrip1 = New System.Windows.Forms.ContextMenuStrip(Me.components)
        Me.toolStripMenuItem1 = New System.Windows.Forms.ToolStripMenuItem()
        Me.toolStripMenuItem2 = New System.Windows.Forms.ToolStripMenuItem()
        Me.webBrowser2 = New Krypton.Toolkit.KryptonWebBrowser()
        Me.kryptonContextMenu1 = New Krypton.Toolkit.KryptonContextMenu()
        Me.kryptonContextMenuHeading1 = New Krypton.Toolkit.KryptonContextMenuHeading()
        Me.kryptonContextMenuCheckButton1 = New Krypton.Toolkit.KryptonContextMenuCheckButton()
        Me.kryptonContextMenuCheckButton2 = New Krypton.Toolkit.KryptonContextMenuCheckButton()
        Me.kcmbTheme = New Krypton.Toolkit.KryptonComboBox()
        Me.kryptonManager1 = New Krypton.Toolkit.KryptonManager(Me.components)
        Me.tableLayoutPanel1 = New System.Windows.Forms.TableLayoutPanel()
        Me.kryptonPanel2 = New Krypton.Toolkit.KryptonPanel()
        Me.kryptonLabel1 = New Krypton.Toolkit.KryptonLabel()
        Me.kryptonRichTextBox1 = New Krypton.Toolkit.KryptonRichTextBox()
        Me.buttonSpecAny1 = New Krypton.Toolkit.ButtonSpecAny()
        Me.buttonSpecAny2 = New Krypton.Toolkit.ButtonSpecAny()
        Me.richTextBox1 = New System.Windows.Forms.RichTextBox()
        Me.kryptonPanel1 = New Krypton.Toolkit.KryptonPanel()
        Me.contextMenuStrip1.SuspendLayout()
        CType(Me.kcmbTheme, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.tableLayoutPanel1.SuspendLayout()
        CType(Me.kryptonPanel2, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.kryptonPanel2.SuspendLayout()
        CType(Me.kryptonPanel1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.kryptonPanel1.SuspendLayout()
        Me.SuspendLayout()
        Me.webBrowser1.ContextMenuStrip = Me.contextMenuStrip1
        Me.webBrowser1.Dock = System.Windows.Forms.DockStyle.Fill
        Me.webBrowser1.IsWebBrowserContextMenuEnabled = False
        Me.webBrowser1.Location = New System.Drawing.Point(3, 271)
        Me.webBrowser1.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.webBrowser1.MinimumSize = New System.Drawing.Size(20, 20)
        Me.webBrowser1.Name = "webBrowser1"
        Me.webBrowser1.Size = New System.Drawing.Size(481, 227)
        Me.webBrowser1.TabIndex = 0
        Me.contextMenuStrip1.Font = New System.Drawing.Font("Segoe UI", 9F)
        Me.contextMenuStrip1.ImageScalingSize = New System.Drawing.Size(20, 20)
        Me.contextMenuStrip1.Items.AddRange(New System.Windows.Forms.ToolStripItem() { Me.toolStripMenuItem1, Me.toolStripMenuItem2})
        Me.contextMenuStrip1.Name = "contextMenuStrip1"
        Me.contextMenuStrip1.Size = New System.Drawing.Size(212, 52)
        Me.toolStripMenuItem1.Name = "toolStripMenuItem1"
        Me.toolStripMenuItem1.Size = New System.Drawing.Size(211, 24)
        Me.toolStripMenuItem1.Text = "toolStripMenuItem1"
        Me.toolStripMenuItem2.Name = "toolStripMenuItem2"
        Me.toolStripMenuItem2.Size = New System.Drawing.Size(211, 24)
        Me.toolStripMenuItem2.Text = "toolStripMenuItem2"
        Me.webBrowser2.Dock = System.Windows.Forms.DockStyle.Fill
        Me.webBrowser2.IsWebBrowserContextMenuEnabled = False
        Me.webBrowser2.KryptonContextMenu = Me.kryptonContextMenu1
        Me.webBrowser2.Location = New System.Drawing.Point(490, 271)
        Me.webBrowser2.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.webBrowser2.MinimumSize = New System.Drawing.Size(20, 20)
        Me.webBrowser2.Name = "webBrowser2"
        Me.webBrowser2.Size = New System.Drawing.Size(482, 227)
        Me.webBrowser2.TabIndex = 1
        Me.kryptonContextMenu1.Items.AddRange(New Krypton.Toolkit.KryptonContextMenuItemBase() { Me.kryptonContextMenuHeading1, Me.kryptonContextMenuCheckButton1, Me.kryptonContextMenuCheckButton2})
        Me.kryptonContextMenuHeading1.ExtraText = ""
        Me.kryptonContextMenuHeading1.Text = ""
        Me.kryptonContextMenuCheckButton1.Text = "CheckButton"
        Me.kryptonContextMenuCheckButton2.Text = "CheckButton"
        Me.kcmbTheme.DropDownWidth = 218
        Me.kcmbTheme.IntegralHeight = False
        Me.kcmbTheme.Location = New System.Drawing.Point(3, 2)
        Me.kcmbTheme.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.kcmbTheme.Name = "kcmbTheme"
        Me.kcmbTheme.Size = New System.Drawing.Size(219, 26)
        Me.kcmbTheme.StateCommon.ComboBox.Content.TextH = Krypton.Toolkit.PaletteRelativeAlign.Near
        Me.kcmbTheme.TabIndex = 2
        Me.kcmbTheme.Text = "kryptonComboBox1"
        Me.kryptonManager1.GlobalPaletteMode = Krypton.Toolkit.PaletteMode.SparkleBlue
        Me.tableLayoutPanel1.BackColor = System.Drawing.Color.Transparent
        Me.tableLayoutPanel1.ColumnCount = 2
        Me.tableLayoutPanel1.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F))
        Me.tableLayoutPanel1.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F))
        Me.tableLayoutPanel1.Controls.Add(Me.webBrowser1, 0, 2)
        Me.tableLayoutPanel1.Controls.Add(Me.webBrowser2, 1, 2)
        Me.tableLayoutPanel1.Controls.Add(Me.kryptonPanel2, 0, 0)
        Me.tableLayoutPanel1.Controls.Add(Me.kryptonRichTextBox1, 1, 1)
        Me.tableLayoutPanel1.Controls.Add(Me.richTextBox1, 0, 1)
        Me.tableLayoutPanel1.Dock = System.Windows.Forms.DockStyle.Fill
        Me.tableLayoutPanel1.Location = New System.Drawing.Point(0, 0)
        Me.tableLayoutPanel1.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.tableLayoutPanel1.Name = "tableLayoutPanel1"
        Me.tableLayoutPanel1.RowCount = 3
        Me.tableLayoutPanel1.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 39F))
        Me.tableLayoutPanel1.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F))
        Me.tableLayoutPanel1.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F))
        Me.tableLayoutPanel1.Size = New System.Drawing.Size(975, 500)
        Me.tableLayoutPanel1.TabIndex = 3
        Me.tableLayoutPanel1.SetColumnSpan(Me.kryptonPanel2, 2)
        Me.kryptonPanel2.Controls.Add(Me.kryptonLabel1)
        Me.kryptonPanel2.Controls.Add(Me.kcmbTheme)
        Me.kryptonPanel2.Dock = System.Windows.Forms.DockStyle.Fill
        Me.kryptonPanel2.Location = New System.Drawing.Point(3, 2)
        Me.kryptonPanel2.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.kryptonPanel2.Name = "kryptonPanel2"
        Me.kryptonPanel2.Size = New System.Drawing.Size(969, 35)
        Me.kryptonPanel2.TabIndex = 3
        Me.kryptonLabel1.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.kryptonLabel1.Location = New System.Drawing.Point(369, 2)
        Me.kryptonLabel1.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.kryptonLabel1.Name = "kryptonLabel1"
        Me.kryptonLabel1.Size = New System.Drawing.Size(237, 24)
        Me.kryptonLabel1.TabIndex = 3
        Me.kryptonLabel1.Values.Text = "Left = Winform | Right = Krypton"
        Me.kryptonRichTextBox1.Dock = System.Windows.Forms.DockStyle.Fill
        Me.kryptonRichTextBox1.KryptonContextMenu = Me.kryptonContextMenu1
        Me.kryptonRichTextBox1.Location = New System.Drawing.Point(490, 41)
        Me.kryptonRichTextBox1.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.kryptonRichTextBox1.Name = "kryptonRichTextBox1"
        Me.kryptonRichTextBox1.Size = New System.Drawing.Size(482, 226)
        Me.kryptonRichTextBox1.TabIndex = 4
        Me.kryptonRichTextBox1.Text = "kryptonRichTextBox1"
        Me.kryptonRichTextBox1.ToolTipValues.EnableToolTips = True
        Me.kryptonRichTextBox1.ToolTipValues.Heading = "Right click in each area"
        Me.kryptonRichTextBox1.ToolTipValues.ToolTipPosition.PlacementMode = Krypton.Toolkit.PlacementMode.Relative
        Me.buttonSpecAny1.Edge = Krypton.Toolkit.PaletteRelativeEdgeAlign.Far
        Me.buttonSpecAny1.Type = Krypton.Toolkit.PaletteButtonSpecStyle.FormMin
        Me.buttonSpecAny1.UniqueName = "dd412874d51045e685c06bf93bf1cf38"
        Me.buttonSpecAny2.Edge = Krypton.Toolkit.PaletteRelativeEdgeAlign.Far
        Me.buttonSpecAny2.Type = Krypton.Toolkit.PaletteButtonSpecStyle.FormMax
        Me.buttonSpecAny2.UniqueName = "17c416590cf64a3599cbbb3aea002abb"
        Me.richTextBox1.ContextMenuStrip = Me.contextMenuStrip1
        Me.richTextBox1.Dock = System.Windows.Forms.DockStyle.Fill
        Me.richTextBox1.Location = New System.Drawing.Point(3, 41)
        Me.richTextBox1.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.richTextBox1.Name = "richTextBox1"
        Me.richTextBox1.Size = New System.Drawing.Size(481, 226)
        Me.richTextBox1.TabIndex = 5
        Me.richTextBox1.Text = "Winform Rich Text Box"
        Me.kryptonPanel1.Controls.Add(Me.tableLayoutPanel1)
        Me.kryptonPanel1.Dock = System.Windows.Forms.DockStyle.Fill
        Me.kryptonPanel1.Location = New System.Drawing.Point(0, 0)
        Me.kryptonPanel1.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.kryptonPanel1.Name = "kryptonPanel1"
        Me.kryptonPanel1.Size = New System.Drawing.Size(975, 500)
        Me.kryptonPanel1.TabIndex = 3
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8F, 16F)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(975, 500)
        Me.Controls.Add(Me.kryptonPanel1)
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.Name = "Form1"
        Me.Text = "Comparison between Winform and Krypton controls"
        Me.contextMenuStrip1.ResumeLayout(False)
        CType(Me.kcmbTheme, System.ComponentModel.ISupportInitialize).EndInit()
        Me.tableLayoutPanel1.ResumeLayout(False)
        CType(Me.kryptonPanel2, System.ComponentModel.ISupportInitialize).EndInit()
        Me.kryptonPanel2.ResumeLayout(False)
        Me.kryptonPanel2.PerformLayout()
        CType(Me.kryptonPanel1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.kryptonPanel1.ResumeLayout(False)
        Me.ResumeLayout(False)
    End Sub

    Friend WithEvents webBrowser1 As System.Windows.Forms.WebBrowser
    Friend WithEvents webBrowser2 As Krypton.Toolkit.KryptonWebBrowser
    Friend WithEvents kcmbTheme As Krypton.Toolkit.KryptonComboBox
    Friend WithEvents kryptonManager1 As Krypton.Toolkit.KryptonManager
    Friend WithEvents tableLayoutPanel1 As System.Windows.Forms.TableLayoutPanel
    Friend WithEvents kryptonPanel2 As Krypton.Toolkit.KryptonPanel
    Friend WithEvents kryptonLabel1 As Krypton.Toolkit.KryptonLabel
    Friend WithEvents kryptonRichTextBox1 As Krypton.Toolkit.KryptonRichTextBox
    Friend WithEvents richTextBox1 As System.Windows.Forms.RichTextBox
    Friend WithEvents kryptonPanel1 As Krypton.Toolkit.KryptonPanel
    Friend WithEvents buttonSpecAny1 As Krypton.Toolkit.ButtonSpecAny
    Friend WithEvents buttonSpecAny2 As Krypton.Toolkit.ButtonSpecAny
    Friend WithEvents kryptonContextMenu1 As Krypton.Toolkit.KryptonContextMenu
    Friend WithEvents kryptonContextMenuHeading1 As Krypton.Toolkit.KryptonContextMenuHeading
    Friend WithEvents kryptonContextMenuCheckButton1 As Krypton.Toolkit.KryptonContextMenuCheckButton
    Friend WithEvents kryptonContextMenuCheckButton2 As Krypton.Toolkit.KryptonContextMenuCheckButton
    Friend WithEvents contextMenuStrip1 As System.Windows.Forms.ContextMenuStrip
    Friend WithEvents toolStripMenuItem1 As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents toolStripMenuItem2 As System.Windows.Forms.ToolStripMenuItem
End Class
