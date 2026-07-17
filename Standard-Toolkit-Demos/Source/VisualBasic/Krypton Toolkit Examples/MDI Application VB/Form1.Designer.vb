' VB.NET twin of Source\Krypton Toolkit Examples\MDI Application\Form1.Designer.cs (Bastion Phase 4c).
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
        Me.menuStrip1 = New System.Windows.Forms.MenuStrip()
        Me.fileToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.newWindowToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.toolStripMenuItem1 = New System.Windows.Forms.ToolStripSeparator()
        Me.closeWindowToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.closeAllWidowToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.toolStripMenuItem2 = New System.Windows.Forms.ToolStripSeparator()
        Me.exitToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.layoutToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.cascadeToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.tileVerticalToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.tileHorizontalToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.toolStrip1 = New System.Windows.Forms.ToolStrip()
        Me.toolStripButton1 = New System.Windows.Forms.ToolStripButton()
        Me.toolStripSeparator1 = New System.Windows.Forms.ToolStripSeparator()
        Me.toolStripButton2 = New System.Windows.Forms.ToolStripButton()
        Me.toolStripButton3 = New System.Windows.Forms.ToolStripButton()
        Me.toolStripSeparator2 = New System.Windows.Forms.ToolStripSeparator()
        Me.toolStripButton4 = New System.Windows.Forms.ToolStripButton()
        Me.toolStripButton6 = New System.Windows.Forms.ToolStripButton()
        Me.toolStripButton5 = New System.Windows.Forms.ToolStripButton()
        Me.kryptonManager1 = New Krypton.Toolkit.KryptonManager(Me.components)
        Me.menuStrip1.SuspendLayout()
        Me.toolStrip1.SuspendLayout()
        Me.SuspendLayout()
        Me.menuStrip1.Font = New System.Drawing.Font("Segoe UI", 9F)
        Me.menuStrip1.Items.AddRange(New System.Windows.Forms.ToolStripItem() { Me.fileToolStripMenuItem, Me.layoutToolStripMenuItem})
        Me.menuStrip1.Location = New System.Drawing.Point(0, 0)
        Me.menuStrip1.Name = "menuStrip1"
        Me.menuStrip1.Size = New System.Drawing.Size(534, 24)
        Me.menuStrip1.TabIndex = 1
        Me.menuStrip1.Text = "menuStrip1"
        Me.fileToolStripMenuItem.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() { Me.newWindowToolStripMenuItem, Me.toolStripMenuItem1, Me.closeWindowToolStripMenuItem, Me.closeAllWidowToolStripMenuItem, Me.toolStripMenuItem2, Me.exitToolStripMenuItem})
        Me.fileToolStripMenuItem.Name = "fileToolStripMenuItem"
        Me.fileToolStripMenuItem.Size = New System.Drawing.Size(37, 20)
        Me.fileToolStripMenuItem.Text = "File"
        Me.newWindowToolStripMenuItem.Image = CType(resources.GetObject("newWindowToolStripMenuItem.Image"), System.Drawing.Image)
        Me.newWindowToolStripMenuItem.Name = "newWindowToolStripMenuItem"
        Me.newWindowToolStripMenuItem.Size = New System.Drawing.Size(172, 22)
        Me.newWindowToolStripMenuItem.Text = "New Window"
        Me.toolStripMenuItem1.Name = "toolStripMenuItem1"
        Me.toolStripMenuItem1.Size = New System.Drawing.Size(169, 6)
        Me.closeWindowToolStripMenuItem.Image = CType(resources.GetObject("closeWindowToolStripMenuItem.Image"), System.Drawing.Image)
        Me.closeWindowToolStripMenuItem.Name = "closeWindowToolStripMenuItem"
        Me.closeWindowToolStripMenuItem.Size = New System.Drawing.Size(172, 22)
        Me.closeWindowToolStripMenuItem.Text = "Close Window"
        Me.closeAllWidowToolStripMenuItem.Name = "closeAllWidowToolStripMenuItem"
        Me.closeAllWidowToolStripMenuItem.Size = New System.Drawing.Size(172, 22)
        Me.closeAllWidowToolStripMenuItem.Text = "Close All Windows"
        Me.toolStripMenuItem2.Name = "toolStripMenuItem2"
        Me.toolStripMenuItem2.Size = New System.Drawing.Size(169, 6)
        Me.exitToolStripMenuItem.Name = "exitToolStripMenuItem"
        Me.exitToolStripMenuItem.Size = New System.Drawing.Size(172, 22)
        Me.exitToolStripMenuItem.Text = "Exit"
        Me.layoutToolStripMenuItem.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() { Me.cascadeToolStripMenuItem, Me.tileVerticalToolStripMenuItem, Me.tileHorizontalToolStripMenuItem})
        Me.layoutToolStripMenuItem.Name = "layoutToolStripMenuItem"
        Me.layoutToolStripMenuItem.Size = New System.Drawing.Size(55, 20)
        Me.layoutToolStripMenuItem.Text = "Layout"
        Me.cascadeToolStripMenuItem.Image = CType(resources.GetObject("cascadeToolStripMenuItem.Image"), System.Drawing.Image)
        Me.cascadeToolStripMenuItem.Name = "cascadeToolStripMenuItem"
        Me.cascadeToolStripMenuItem.Size = New System.Drawing.Size(150, 22)
        Me.cascadeToolStripMenuItem.Text = "Cascade"
        Me.tileVerticalToolStripMenuItem.Image = CType(resources.GetObject("tileVerticalToolStripMenuItem.Image"), System.Drawing.Image)
        Me.tileVerticalToolStripMenuItem.Name = "tileVerticalToolStripMenuItem"
        Me.tileVerticalToolStripMenuItem.Size = New System.Drawing.Size(150, 22)
        Me.tileVerticalToolStripMenuItem.Text = "Tile Horizontal"
        Me.tileHorizontalToolStripMenuItem.Image = CType(resources.GetObject("tileHorizontalToolStripMenuItem.Image"), System.Drawing.Image)
        Me.tileHorizontalToolStripMenuItem.Name = "tileHorizontalToolStripMenuItem"
        Me.tileHorizontalToolStripMenuItem.Size = New System.Drawing.Size(150, 22)
        Me.tileHorizontalToolStripMenuItem.Text = "Tile Vertical"
        Me.toolStrip1.Font = New System.Drawing.Font("Segoe UI", 9F)
        Me.toolStrip1.Items.AddRange(New System.Windows.Forms.ToolStripItem() { Me.toolStripButton1, Me.toolStripSeparator1, Me.toolStripButton2, Me.toolStripButton3, Me.toolStripSeparator2, Me.toolStripButton4, Me.toolStripButton6, Me.toolStripButton5})
        Me.toolStrip1.Location = New System.Drawing.Point(0, 24)
        Me.toolStrip1.Name = "toolStrip1"
        Me.toolStrip1.Size = New System.Drawing.Size(534, 25)
        Me.toolStrip1.TabIndex = 2
        Me.toolStrip1.Text = "toolStrip1"
        Me.toolStripButton1.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image
        Me.toolStripButton1.Image = CType(resources.GetObject("toolStripButton1.Image"), System.Drawing.Image)
        Me.toolStripButton1.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.toolStripButton1.Name = "toolStripButton1"
        Me.toolStripButton1.Size = New System.Drawing.Size(23, 22)
        Me.toolStripButton1.Text = "toolStripButton1"
        Me.toolStripButton1.ToolTipText = "New Window"
        Me.toolStripSeparator1.Name = "toolStripSeparator1"
        Me.toolStripSeparator1.Size = New System.Drawing.Size(6, 25)
        Me.toolStripButton2.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image
        Me.toolStripButton2.Image = CType(resources.GetObject("toolStripButton2.Image"), System.Drawing.Image)
        Me.toolStripButton2.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.toolStripButton2.Name = "toolStripButton2"
        Me.toolStripButton2.Size = New System.Drawing.Size(23, 22)
        Me.toolStripButton2.Text = "toolStripButton2"
        Me.toolStripButton2.ToolTipText = "Close Window"
        Me.toolStripButton3.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image
        Me.toolStripButton3.Image = CType(resources.GetObject("toolStripButton3.Image"), System.Drawing.Image)
        Me.toolStripButton3.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.toolStripButton3.Name = "toolStripButton3"
        Me.toolStripButton3.Size = New System.Drawing.Size(23, 22)
        Me.toolStripButton3.Text = "toolStripButton3"
        Me.toolStripButton3.ToolTipText = "Close All Windows"
        Me.toolStripSeparator2.Name = "toolStripSeparator2"
        Me.toolStripSeparator2.Size = New System.Drawing.Size(6, 25)
        Me.toolStripButton4.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image
        Me.toolStripButton4.Image = CType(resources.GetObject("toolStripButton4.Image"), System.Drawing.Image)
        Me.toolStripButton4.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.toolStripButton4.Name = "toolStripButton4"
        Me.toolStripButton4.Size = New System.Drawing.Size(23, 22)
        Me.toolStripButton4.Text = "toolStripButton4"
        Me.toolStripButton4.ToolTipText = "Cascade"
        Me.toolStripButton6.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image
        Me.toolStripButton6.Image = CType(resources.GetObject("toolStripButton6.Image"), System.Drawing.Image)
        Me.toolStripButton6.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.toolStripButton6.Name = "toolStripButton6"
        Me.toolStripButton6.Size = New System.Drawing.Size(23, 22)
        Me.toolStripButton6.Text = "toolStripButton6"
        Me.toolStripButton6.ToolTipText = "Tile Horizontal"
        Me.toolStripButton5.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image
        Me.toolStripButton5.Image = CType(resources.GetObject("toolStripButton5.Image"), System.Drawing.Image)
        Me.toolStripButton5.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.toolStripButton5.Name = "toolStripButton5"
        Me.toolStripButton5.Size = New System.Drawing.Size(23, 22)
        Me.toolStripButton5.Text = "toolStripButton5"
        Me.toolStripButton5.ToolTipText = "Tile Vertical"
        Me.kryptonManager1.GlobalPaletteMode = Krypton.Toolkit.PaletteMode.SparkleBlue
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6F, 13F)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(534, 421)
        Me.Controls.Add(Me.toolStrip1)
        Me.Controls.Add(Me.menuStrip1)
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.IsMdiContainer = True
        Me.MainMenuStrip = Me.menuStrip1
        Me.Name = "Form1"
        Me.Text = "MDI Application"
        Me.menuStrip1.ResumeLayout(False)
        Me.menuStrip1.PerformLayout()
        Me.toolStrip1.ResumeLayout(False)
        Me.toolStrip1.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()
    End Sub

    Friend WithEvents menuStrip1 As System.Windows.Forms.MenuStrip
    Friend WithEvents toolStrip1 As System.Windows.Forms.ToolStrip
    Friend WithEvents fileToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents layoutToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents newWindowToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents toolStripMenuItem1 As System.Windows.Forms.ToolStripSeparator
    Friend WithEvents closeWindowToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents closeAllWidowToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents toolStripMenuItem2 As System.Windows.Forms.ToolStripSeparator
    Friend WithEvents exitToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents cascadeToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents tileHorizontalToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents tileVerticalToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents toolStripButton1 As System.Windows.Forms.ToolStripButton
    Friend WithEvents toolStripSeparator1 As System.Windows.Forms.ToolStripSeparator
    Friend WithEvents toolStripButton2 As System.Windows.Forms.ToolStripButton
    Friend WithEvents toolStripButton3 As System.Windows.Forms.ToolStripButton
    Friend WithEvents toolStripSeparator2 As System.Windows.Forms.ToolStripSeparator
    Friend WithEvents toolStripButton4 As System.Windows.Forms.ToolStripButton
    Friend WithEvents toolStripButton5 As System.Windows.Forms.ToolStripButton
    Friend WithEvents toolStripButton6 As System.Windows.Forms.ToolStripButton
    Friend WithEvents kryptonManager1 As Krypton.Toolkit.KryptonManager
End Class
