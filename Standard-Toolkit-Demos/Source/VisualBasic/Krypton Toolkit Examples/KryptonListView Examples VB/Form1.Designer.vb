' VB.NET twin of Source\Krypton Toolkit Examples\KryptonListView Examples\Form1.Designer.cs (Bastion Phase 4c).
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
        Dim listViewGroup1 As System.Windows.Forms.ListViewGroup = New System.Windows.Forms.ListViewGroup("ListViewGroup", System.Windows.Forms.HorizontalAlignment.Left)
        Dim listViewItem1 As System.Windows.Forms.ListViewItem = New System.Windows.Forms.ListViewItem(New String() { "Cat with areally long text to see what happens"}, 1, System.Drawing.SystemColors.ControlText, System.Drawing.SystemColors.Window, New System.Drawing.Font("Segoe UI", 9F))
        Dim listViewItem2 As System.Windows.Forms.ListViewItem = New System.Windows.Forms.ListViewItem(New String() { "Dog "}, 2, System.Drawing.SystemColors.ControlText, System.Drawing.SystemColors.Window, New System.Drawing.Font("Segoe UI", 9F))
        Dim listViewItem3 As System.Windows.Forms.ListViewItem = New System.Windows.Forms.ListViewItem(New String() { "Mouse "}, 3, System.Drawing.SystemColors.ControlText, System.Drawing.SystemColors.Window, New System.Drawing.Font("Segoe UI", 9F))
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(Form1))
        Dim listViewGroup2 As System.Windows.Forms.ListViewGroup = New System.Windows.Forms.ListViewGroup("ListViewGroup", System.Windows.Forms.HorizontalAlignment.Left)
        Dim listViewItem4 As System.Windows.Forms.ListViewItem = New System.Windows.Forms.ListViewItem(New String() { "Cat with areally long text to see what happens", "Sub Item 1"}, 1)
        Dim listViewItem5 As System.Windows.Forms.ListViewItem = New System.Windows.Forms.ListViewItem("Dog", 2)
        Dim listViewItem6 As System.Windows.Forms.ListViewItem = New System.Windows.Forms.ListViewItem("Mouse", 3)
        Me.kryptonPanel1 = New Krypton.Toolkit.KryptonPanel()
        Me.kryptonThemeComboBox1 = New Krypton.Toolkit.KryptonThemeComboBox()
        Me.chkDisabled = New Krypton.Toolkit.KryptonCheckBox()
        Me.viewCheckBox = New Krypton.Toolkit.KryptonCheckBox()
        Me.groupBox3 = New Krypton.Toolkit.KryptonGroupBox()
        Me.kryptonTextBox1 = New Krypton.Toolkit.KryptonTextBox()
        Me.listKrypton = New Krypton.Toolkit.KryptonListView()
        Me.imageList2 = New System.Windows.Forms.ImageList(Me.components)
        Me.imageList1 = New System.Windows.Forms.ImageList(Me.components)
        Me.groupBox2 = New System.Windows.Forms.GroupBox()
        Me.rbDetails = New System.Windows.Forms.RadioButton()
        Me.rbTile = New System.Windows.Forms.RadioButton()
        Me.rbList = New System.Windows.Forms.RadioButton()
        Me.rbSmallIcon = New System.Windows.Forms.RadioButton()
        Me.rbLargIcon = New System.Windows.Forms.RadioButton()
        Me.groupBox1 = New System.Windows.Forms.GroupBox()
        Me.listWinform = New System.Windows.Forms.ListView()
        CType(Me.kryptonPanel1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.kryptonPanel1.SuspendLayout()
        CType(Me.kryptonThemeComboBox1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.groupBox3, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.groupBox3.Panel, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.groupBox3.Panel.SuspendLayout()
        Me.groupBox3.SuspendLayout()
        Me.groupBox2.SuspendLayout()
        Me.groupBox1.SuspendLayout()
        Me.SuspendLayout()
        Me.kryptonPanel1.Controls.Add(Me.kryptonThemeComboBox1)
        Me.kryptonPanel1.Controls.Add(Me.chkDisabled)
        Me.kryptonPanel1.Controls.Add(Me.viewCheckBox)
        Me.kryptonPanel1.Controls.Add(Me.groupBox3)
        Me.kryptonPanel1.Controls.Add(Me.groupBox2)
        Me.kryptonPanel1.Controls.Add(Me.groupBox1)
        Me.kryptonPanel1.Dock = System.Windows.Forms.DockStyle.Fill
        Me.kryptonPanel1.Location = New System.Drawing.Point(0, 0)
        Me.kryptonPanel1.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.kryptonPanel1.Name = "kryptonPanel1"
        Me.kryptonPanel1.Size = New System.Drawing.Size(972, 411)
        Me.kryptonPanel1.TabIndex = 0
        Me.kryptonThemeComboBox1.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Left), System.Windows.Forms.AnchorStyles)
        Me.kryptonThemeComboBox1.DefaultPalette = Krypton.Toolkit.PaletteMode.ProfessionalSystem
        Me.kryptonThemeComboBox1.DropDownWidth = 121
        Me.kryptonThemeComboBox1.IntegralHeight = False
        Me.kryptonThemeComboBox1.Location = New System.Drawing.Point(744, 375)
        Me.kryptonThemeComboBox1.Name = "kryptonThemeComboBox1"
        Me.kryptonThemeComboBox1.Size = New System.Drawing.Size(211, 26)
        Me.kryptonThemeComboBox1.StateCommon.ComboBox.Content.TextH = Krypton.Toolkit.PaletteRelativeAlign.Near
        Me.kryptonThemeComboBox1.TabIndex = 8
        Me.chkDisabled.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Left), System.Windows.Forms.AnchorStyles)
        Me.chkDisabled.Location = New System.Drawing.Point(652, 376)
        Me.chkDisabled.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.chkDisabled.Name = "chkDisabled"
        Me.chkDisabled.Size = New System.Drawing.Size(86, 26)
        Me.chkDisabled.TabIndex = 7
        Me.chkDisabled.Values.Text = "Disabled"
        Me.viewCheckBox.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Left), System.Windows.Forms.AnchorStyles)
        Me.viewCheckBox.Location = New System.Drawing.Point(552, 376)
        Me.viewCheckBox.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.viewCheckBox.Name = "viewCheckBox"
        Me.viewCheckBox.Size = New System.Drawing.Size(94, 26)
        Me.viewCheckBox.TabIndex = 6
        Me.viewCheckBox.Values.Text = "CheckBox"
        Me.groupBox3.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) Or System.Windows.Forms.AnchorStyles.Left) Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.groupBox3.Location = New System.Drawing.Point(504, 5)
        Me.groupBox3.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.groupBox3.Panel.Controls.Add(Me.kryptonTextBox1)
        Me.groupBox3.Panel.Controls.Add(Me.listKrypton)
        Me.groupBox3.Size = New System.Drawing.Size(465, 363)
        Me.groupBox3.TabIndex = 1
        Me.groupBox3.Values.Heading = "Krypton ListView"
        Me.kryptonTextBox1.Dock = System.Windows.Forms.DockStyle.Bottom
        Me.kryptonTextBox1.Location = New System.Drawing.Point(0, 308)
        Me.kryptonTextBox1.Name = "kryptonTextBox1"
        Me.kryptonTextBox1.Size = New System.Drawing.Size(461, 27)
        Me.kryptonTextBox1.TabIndex = 1
        Me.kryptonTextBox1.Text = "kryptonTextBox1"
        Me.listKrypton.Activation = System.Windows.Forms.ItemActivation.OneClick
        Me.listKrypton.Dock = System.Windows.Forms.DockStyle.Fill
        Me.listKrypton.FullRowSelect = True
        Me.listKrypton.GridLines = True
        listViewGroup1.Header = "ListViewGroup"
        listViewGroup1.Name = "listViewGroup1"
        Me.listKrypton.Groups.AddRange(New System.Windows.Forms.ListViewGroup() { listViewGroup1})
        Me.listKrypton.HideSelection = False
        Me.listKrypton.HotTracking = True
        Me.listKrypton.HoverSelection = True
        listViewItem1.StateImageIndex = 0
        listViewItem2.StateImageIndex = 0
        listViewItem3.StateImageIndex = 0
        Me.listKrypton.Items.AddRange(New System.Windows.Forms.ListViewItem() { listViewItem1, listViewItem2, listViewItem3})
        Me.listKrypton.LargeImageList = Me.imageList2
        Me.listKrypton.Location = New System.Drawing.Point(0, 0)
        Me.listKrypton.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.listKrypton.Name = "listKrypton"
        Me.listKrypton.Size = New System.Drawing.Size(461, 335)
        Me.listKrypton.SmallImageList = Me.imageList1
        Me.listKrypton.TabIndex = 0
        Me.imageList2.ImageStream = CType(resources.GetObject("imageList2.ImageStream"), System.Windows.Forms.ImageListStreamer)
        Me.imageList2.TransparentColor = System.Drawing.Color.Transparent
        Me.imageList2.Images.SetKeyName(0, "AppMenuClose.png")
        Me.imageList2.Images.SetKeyName(1, "AppMenuMemoStyle.PNG")
        Me.imageList2.Images.SetKeyName(2, "AppMenuMove.png")
        Me.imageList2.Images.SetKeyName(3, "AppMenuNewMailMessage.png")
        Me.imageList1.ImageStream = CType(resources.GetObject("imageList1.ImageStream"), System.Windows.Forms.ImageListStreamer)
        Me.imageList1.TransparentColor = System.Drawing.Color.Transparent
        Me.imageList1.Images.SetKeyName(0, "AppMenuClose.png")
        Me.imageList1.Images.SetKeyName(1, "AppMenuMemoStyle.PNG")
        Me.imageList1.Images.SetKeyName(2, "AppMenuMove.png")
        Me.imageList1.Images.SetKeyName(3, "AppMenuNewMailMessage.png")
        Me.groupBox2.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Left), System.Windows.Forms.AnchorStyles)
        Me.groupBox2.Controls.Add(Me.rbDetails)
        Me.groupBox2.Controls.Add(Me.rbTile)
        Me.groupBox2.Controls.Add(Me.rbList)
        Me.groupBox2.Controls.Add(Me.rbSmallIcon)
        Me.groupBox2.Controls.Add(Me.rbLargIcon)
        Me.groupBox2.Location = New System.Drawing.Point(13, 369)
        Me.groupBox2.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.groupBox2.Name = "groupBox2"
        Me.groupBox2.Padding = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.groupBox2.Size = New System.Drawing.Size(533, 36)
        Me.groupBox2.TabIndex = 1
        Me.groupBox2.TabStop = False
        Me.groupBox2.Text = "View Type"
        Me.rbDetails.AutoSize = True
        Me.rbDetails.Location = New System.Drawing.Point(431, 12)
        Me.rbDetails.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.rbDetails.Name = "rbDetails"
        Me.rbDetails.Size = New System.Drawing.Size(70, 20)
        Me.rbDetails.TabIndex = 4
        Me.rbDetails.Text = "Details"
        Me.rbDetails.UseVisualStyleBackColor = True
        Me.rbTile.AutoSize = True
        Me.rbTile.Location = New System.Drawing.Point(355, 11)
        Me.rbTile.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.rbTile.Name = "rbTile"
        Me.rbTile.Size = New System.Drawing.Size(51, 20)
        Me.rbTile.TabIndex = 3
        Me.rbTile.Text = "Tile"
        Me.rbTile.UseVisualStyleBackColor = True
        Me.rbList.AutoSize = True
        Me.rbList.Location = New System.Drawing.Point(239, 15)
        Me.rbList.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.rbList.Name = "rbList"
        Me.rbList.Size = New System.Drawing.Size(48, 20)
        Me.rbList.TabIndex = 2
        Me.rbList.Text = "List"
        Me.rbList.UseVisualStyleBackColor = True
        Me.rbSmallIcon.AutoSize = True
        Me.rbSmallIcon.Location = New System.Drawing.Point(123, 14)
        Me.rbSmallIcon.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.rbSmallIcon.Name = "rbSmallIcon"
        Me.rbSmallIcon.Size = New System.Drawing.Size(90, 20)
        Me.rbSmallIcon.TabIndex = 1
        Me.rbSmallIcon.Text = "Small Icon"
        Me.rbSmallIcon.UseVisualStyleBackColor = True
        Me.rbLargIcon.AutoSize = True
        Me.rbLargIcon.Checked = True
        Me.rbLargIcon.Location = New System.Drawing.Point(7, 14)
        Me.rbLargIcon.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.rbLargIcon.Name = "rbLargIcon"
        Me.rbLargIcon.Size = New System.Drawing.Size(91, 20)
        Me.rbLargIcon.TabIndex = 0
        Me.rbLargIcon.TabStop = True
        Me.rbLargIcon.Text = "Large Icon"
        Me.rbLargIcon.UseVisualStyleBackColor = True
        Me.groupBox1.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) Or System.Windows.Forms.AnchorStyles.Left) Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.groupBox1.Controls.Add(Me.listWinform)
        Me.groupBox1.Location = New System.Drawing.Point(13, 14)
        Me.groupBox1.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.groupBox1.Name = "groupBox1"
        Me.groupBox1.Padding = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.groupBox1.Size = New System.Drawing.Size(487, 355)
        Me.groupBox1.TabIndex = 0
        Me.groupBox1.TabStop = False
        Me.groupBox1.Text = "Winform ListView"
        Me.listWinform.Activation = System.Windows.Forms.ItemActivation.OneClick
        Me.listWinform.Dock = System.Windows.Forms.DockStyle.Fill
        Me.listWinform.Font = New System.Drawing.Font("Segoe UI", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.listWinform.FullRowSelect = True
        Me.listWinform.GridLines = True
        listViewGroup2.Header = "ListViewGroup"
        listViewGroup2.Name = "listViewGroup1"
        Me.listWinform.Groups.AddRange(New System.Windows.Forms.ListViewGroup() { listViewGroup2})
        Me.listWinform.HideSelection = False
        Me.listWinform.HotTracking = True
        Me.listWinform.HoverSelection = True
        listViewItem4.Group = listViewGroup2
        listViewItem4.StateImageIndex = 0
        listViewItem5.StateImageIndex = 0
        listViewItem6.StateImageIndex = 0
        Me.listWinform.Items.AddRange(New System.Windows.Forms.ListViewItem() { listViewItem4, listViewItem5, listViewItem6})
        Me.listWinform.LargeImageList = Me.imageList2
        Me.listWinform.Location = New System.Drawing.Point(3, 17)
        Me.listWinform.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.listWinform.Name = "listWinform"
        Me.listWinform.Size = New System.Drawing.Size(481, 336)
        Me.listWinform.SmallImageList = Me.imageList1
        Me.listWinform.TabIndex = 0
        Me.listWinform.UseCompatibleStateImageBehavior = False
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8F, 16F)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(972, 411)
        Me.Controls.Add(Me.kryptonPanel1)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle
        Me.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.Name = "Form1"
        Me.Text = "ListView Example"
        CType(Me.kryptonPanel1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.kryptonPanel1.ResumeLayout(False)
        Me.kryptonPanel1.PerformLayout()
        CType(Me.kryptonThemeComboBox1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.groupBox3.Panel, System.ComponentModel.ISupportInitialize).EndInit()
        Me.groupBox3.Panel.ResumeLayout(False)
        Me.groupBox3.Panel.PerformLayout()
        CType(Me.groupBox3, System.ComponentModel.ISupportInitialize).EndInit()
        Me.groupBox3.ResumeLayout(False)
        Me.groupBox2.ResumeLayout(False)
        Me.groupBox2.PerformLayout()
        Me.groupBox1.ResumeLayout(False)
        Me.ResumeLayout(False)
    End Sub

    Friend WithEvents kryptonPanel1 As Krypton.Toolkit.KryptonPanel
    Friend WithEvents groupBox1 As System.Windows.Forms.GroupBox
    Friend WithEvents listWinform As System.Windows.Forms.ListView
    Friend WithEvents imageList1 As System.Windows.Forms.ImageList
    Friend WithEvents groupBox3 As Krypton.Toolkit.KryptonGroupBox
    Friend WithEvents groupBox2 As System.Windows.Forms.GroupBox
    Friend WithEvents rbTile As System.Windows.Forms.RadioButton
    Friend WithEvents rbList As System.Windows.Forms.RadioButton
    Friend WithEvents rbSmallIcon As System.Windows.Forms.RadioButton
    Friend WithEvents rbLargIcon As System.Windows.Forms.RadioButton
    Friend WithEvents viewCheckBox As Krypton.Toolkit.KryptonCheckBox
    Friend WithEvents rbDetails As System.Windows.Forms.RadioButton
    Friend WithEvents listKrypton As Krypton.Toolkit.KryptonListView
    Friend WithEvents imageList2 As System.Windows.Forms.ImageList
    Friend WithEvents chkDisabled As Krypton.Toolkit.KryptonCheckBox
    Friend WithEvents kryptonTextBox1 As Krypton.Toolkit.KryptonTextBox
    Friend WithEvents kryptonThemeComboBox1 As Krypton.Toolkit.KryptonThemeComboBox
End Class
