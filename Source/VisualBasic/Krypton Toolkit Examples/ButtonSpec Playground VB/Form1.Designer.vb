' VB.NET twin of Source\Krypton Toolkit Examples\ButtonSpec Playground\Form1.Designer.cs (Bastion Phase 4c).
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
        Me.components = New System.ComponentModel.Container()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(Form1))
        Me.groupBoxProperties = New System.Windows.Forms.GroupBox()
        Me.propertyGrid = New System.Windows.Forms.PropertyGrid()
        Me.kryptonHeaderGroup1 = New Krypton.Toolkit.KryptonHeaderGroup()
        Me.kryptonManager1 = New Krypton.Toolkit.KryptonManager(Me.components)
        Me.kryptonButtonAdd = New Krypton.Toolkit.KryptonButton()
        Me.kryptonButtonRemove = New Krypton.Toolkit.KryptonButton()
        Me.kryptonButtonClear = New Krypton.Toolkit.KryptonButton()
        Me.groupBoxExample = New System.Windows.Forms.GroupBox()
        Me.groupBoxButtonSpecs = New System.Windows.Forms.GroupBox()
        Me.groupBox1 = New System.Windows.Forms.GroupBox()
        Me.labelInstructions = New System.Windows.Forms.Label()
        Me.groupBoxPrimary = New System.Windows.Forms.GroupBox()
        Me.kryptonButtonBottomP = New Krypton.Toolkit.KryptonButton()
        Me.groupBox2 = New System.Windows.Forms.GroupBox()
        Me.kryptonButton1 = New Krypton.Toolkit.KryptonButton()
        Me.kryptonButton2 = New Krypton.Toolkit.KryptonButton()
        Me.kryptonButton3 = New Krypton.Toolkit.KryptonButton()
        Me.kryptonButtonTopP = New Krypton.Toolkit.KryptonButton()
        Me.kryptonButtonRightP = New Krypton.Toolkit.KryptonButton()
        Me.kryptonButtonLeftP = New Krypton.Toolkit.KryptonButton()
        Me.groupBoxSecondary = New System.Windows.Forms.GroupBox()
        Me.kryptonButtonBottomS = New Krypton.Toolkit.KryptonButton()
        Me.kryptonButtonTopS = New Krypton.Toolkit.KryptonButton()
        Me.kryptonButtonRightS = New Krypton.Toolkit.KryptonButton()
        Me.kryptonButtonLeftS = New Krypton.Toolkit.KryptonButton()
        Me.kryptonThemeComboBox1 = New Krypton.Toolkit.KryptonThemeComboBox()
        Me.groupBoxProperties.SuspendLayout()
        CType(Me.kryptonHeaderGroup1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.kryptonHeaderGroup1.Panel, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.kryptonHeaderGroup1.SuspendLayout()
        Me.groupBoxExample.SuspendLayout()
        Me.groupBoxButtonSpecs.SuspendLayout()
        Me.groupBox1.SuspendLayout()
        Me.groupBoxPrimary.SuspendLayout()
        Me.groupBox2.SuspendLayout()
        Me.groupBoxSecondary.SuspendLayout()
        CType(Me.kryptonThemeComboBox1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'groupBoxProperties
        '
        Me.groupBoxProperties.Controls.Add(Me.propertyGrid)
        Me.groupBoxProperties.Location = New System.Drawing.Point(304, 12)
        Me.groupBoxProperties.Name = "groupBoxProperties"
        Me.groupBoxProperties.Size = New System.Drawing.Size(294, 436)
        Me.groupBoxProperties.TabIndex = 2
        Me.groupBoxProperties.TabStop = False
        Me.groupBoxProperties.Text = "Properties for Selected ButtonSpec"
        '
        'propertyGrid
        '
        Me.propertyGrid.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) Or System.Windows.Forms.AnchorStyles.Left) Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.propertyGrid.Location = New System.Drawing.Point(6, 19)
        Me.propertyGrid.Name = "propertyGrid"
        Me.propertyGrid.Size = New System.Drawing.Size(282, 411)
        Me.propertyGrid.TabIndex = 0
        Me.propertyGrid.ToolbarVisible = False
        '
        'kryptonHeaderGroup1
        '
        Me.kryptonHeaderGroup1.Location = New System.Drawing.Point(11, 23)
        Me.kryptonHeaderGroup1.Size = New System.Drawing.Size(254, 165)
        Me.kryptonHeaderGroup1.TabIndex = 0
        '
        'kryptonManager1
        '
        Me.kryptonManager1.GlobalPaletteMode = Krypton.Toolkit.PaletteMode.Office2007Blue
        '
        'kryptonButtonAdd
        '
        Me.kryptonButtonAdd.AutoSize = True
        Me.kryptonButtonAdd.Location = New System.Drawing.Point(10, 25)
        Me.kryptonButtonAdd.Name = "kryptonButtonAdd"
        Me.kryptonButtonAdd.Size = New System.Drawing.Size(65, 28)
        Me.kryptonButtonAdd.TabIndex = 0
        Me.kryptonButtonAdd.Values.DropDownArrowColor = System.Drawing.Color.Empty
        Me.kryptonButtonAdd.Values.Text = "Add"
        '
        'kryptonButtonRemove
        '
        Me.kryptonButtonRemove.AutoSize = True
        Me.kryptonButtonRemove.Enabled = False
        Me.kryptonButtonRemove.Location = New System.Drawing.Point(11, 56)
        Me.kryptonButtonRemove.Name = "kryptonButtonRemove"
        Me.kryptonButtonRemove.Size = New System.Drawing.Size(67, 28)
        Me.kryptonButtonRemove.TabIndex = 1
        Me.kryptonButtonRemove.Values.DropDownArrowColor = System.Drawing.Color.Empty
        Me.kryptonButtonRemove.Values.Text = "Remove"
        '
        'kryptonButtonClear
        '
        Me.kryptonButtonClear.AutoSize = True
        Me.kryptonButtonClear.Enabled = False
        Me.kryptonButtonClear.Location = New System.Drawing.Point(11, 87)
        Me.kryptonButtonClear.Name = "kryptonButtonClear"
        Me.kryptonButtonClear.Size = New System.Drawing.Size(64, 28)
        Me.kryptonButtonClear.TabIndex = 2
        Me.kryptonButtonClear.Values.DropDownArrowColor = System.Drawing.Color.Empty
        Me.kryptonButtonClear.Values.Text = "Clear"
        '
        'groupBoxExample
        '
        Me.groupBoxExample.Controls.Add(Me.kryptonHeaderGroup1)
        Me.groupBoxExample.Location = New System.Drawing.Point(12, 12)
        Me.groupBoxExample.Name = "groupBoxExample"
        Me.groupBoxExample.Size = New System.Drawing.Size(277, 198)
        Me.groupBoxExample.TabIndex = 0
        Me.groupBoxExample.TabStop = False
        Me.groupBoxExample.Text = "Example HeaderGroup"
        '
        'groupBoxButtonSpecs
        '
        Me.groupBoxButtonSpecs.Controls.Add(Me.kryptonButtonAdd)
        Me.groupBoxButtonSpecs.Controls.Add(Me.kryptonButtonClear)
        Me.groupBoxButtonSpecs.Controls.Add(Me.kryptonButtonRemove)
        Me.groupBoxButtonSpecs.Location = New System.Drawing.Point(12, 216)
        Me.groupBoxButtonSpecs.Name = "groupBoxButtonSpecs"
        Me.groupBoxButtonSpecs.Size = New System.Drawing.Size(95, 154)
        Me.groupBoxButtonSpecs.TabIndex = 1
        Me.groupBoxButtonSpecs.TabStop = False
        Me.groupBoxButtonSpecs.Text = "ButtonSpec"
        '
        'groupBox1
        '
        Me.groupBox1.Controls.Add(Me.labelInstructions)
        Me.groupBox1.Location = New System.Drawing.Point(11, 376)
        Me.groupBox1.Name = "groupBox1"
        Me.groupBox1.Size = New System.Drawing.Size(278, 72)
        Me.groupBox1.TabIndex = 4
        Me.groupBox1.TabStop = False
        Me.groupBox1.Text = "Instructions"
        '
        'labelInstructions
        '
        Me.labelInstructions.Dock = System.Windows.Forms.DockStyle.Fill
        Me.labelInstructions.Location = New System.Drawing.Point(3, 20)
        Me.labelInstructions.Name = "labelInstructions"
        Me.labelInstructions.Size = New System.Drawing.Size(272, 49)
        Me.labelInstructions.TabIndex = 0
        Me.labelInstructions.Text = "Use the Add/Remove buttons to create/delete ButtonSpec instances.  Click the button in order to display its properties in the property window."
        '
        'groupBoxPrimary
        '
        Me.groupBoxPrimary.Controls.Add(Me.kryptonButtonBottomP)
        Me.groupBoxPrimary.Controls.Add(Me.groupBox2)
        Me.groupBoxPrimary.Controls.Add(Me.kryptonButtonTopP)
        Me.groupBoxPrimary.Controls.Add(Me.kryptonButtonRightP)
        Me.groupBoxPrimary.Controls.Add(Me.kryptonButtonLeftP)
        Me.groupBoxPrimary.Location = New System.Drawing.Point(103, 216)
        Me.groupBoxPrimary.Name = "groupBoxPrimary"
        Me.groupBoxPrimary.Size = New System.Drawing.Size(95, 154)
        Me.groupBoxPrimary.TabIndex = 3
        Me.groupBoxPrimary.TabStop = False
        Me.groupBoxPrimary.Text = "Primary"
        '
        'kryptonButtonBottomP
        '
        Me.kryptonButtonBottomP.AutoSize = True
        Me.kryptonButtonBottomP.Location = New System.Drawing.Point(11, 118)
        Me.kryptonButtonBottomP.Name = "kryptonButtonBottomP"
        Me.kryptonButtonBottomP.Size = New System.Drawing.Size(64, 28)
        Me.kryptonButtonBottomP.TabIndex = 5
        Me.kryptonButtonBottomP.Values.DropDownArrowColor = System.Drawing.Color.Empty
        Me.kryptonButtonBottomP.Values.Text = "Bottom"
        '
        'groupBox2
        '
        Me.groupBox2.Controls.Add(Me.kryptonButton1)
        Me.groupBox2.Controls.Add(Me.kryptonButton2)
        Me.groupBox2.Controls.Add(Me.kryptonButton3)
        Me.groupBox2.Location = New System.Drawing.Point(96, 0)
        Me.groupBox2.Name = "groupBox2"
        Me.groupBox2.Size = New System.Drawing.Size(90, 130)
        Me.groupBox2.TabIndex = 4
        Me.groupBox2.TabStop = False
        Me.groupBox2.Text = "Primary"
        '
        'kryptonButton1
        '
        Me.kryptonButton1.AutoSize = True
        Me.kryptonButton1.Location = New System.Drawing.Point(10, 28)
        Me.kryptonButton1.Name = "kryptonButton1"
        Me.kryptonButton1.Size = New System.Drawing.Size(65, 28)
        Me.kryptonButton1.TabIndex = 0
        Me.kryptonButton1.Values.DropDownArrowColor = System.Drawing.Color.Empty
        Me.kryptonButton1.Values.Text = "Top"
        '
        'kryptonButton2
        '
        Me.kryptonButton2.AutoSize = True
        Me.kryptonButton2.Enabled = False
        Me.kryptonButton2.Location = New System.Drawing.Point(11, 90)
        Me.kryptonButton2.Name = "kryptonButton2"
        Me.kryptonButton2.Size = New System.Drawing.Size(64, 28)
        Me.kryptonButton2.TabIndex = 2
        Me.kryptonButton2.Values.DropDownArrowColor = System.Drawing.Color.Empty
        Me.kryptonButton2.Values.Text = "Right"
        '
        'kryptonButton3
        '
        Me.kryptonButton3.AutoSize = True
        Me.kryptonButton3.Enabled = False
        Me.kryptonButton3.Location = New System.Drawing.Point(11, 59)
        Me.kryptonButton3.Name = "kryptonButton3"
        Me.kryptonButton3.Size = New System.Drawing.Size(64, 28)
        Me.kryptonButton3.TabIndex = 1
        Me.kryptonButton3.Values.DropDownArrowColor = System.Drawing.Color.Empty
        Me.kryptonButton3.Values.Text = "Left"
        '
        'kryptonButtonTopP
        '
        Me.kryptonButtonTopP.AutoSize = True
        Me.kryptonButtonTopP.Location = New System.Drawing.Point(10, 25)
        Me.kryptonButtonTopP.Name = "kryptonButtonTopP"
        Me.kryptonButtonTopP.Size = New System.Drawing.Size(65, 28)
        Me.kryptonButtonTopP.TabIndex = 0
        Me.kryptonButtonTopP.Values.DropDownArrowColor = System.Drawing.Color.Empty
        Me.kryptonButtonTopP.Values.Text = "Top"
        '
        'kryptonButtonRightP
        '
        Me.kryptonButtonRightP.AutoSize = True
        Me.kryptonButtonRightP.Location = New System.Drawing.Point(11, 87)
        Me.kryptonButtonRightP.Name = "kryptonButtonRightP"
        Me.kryptonButtonRightP.Size = New System.Drawing.Size(64, 28)
        Me.kryptonButtonRightP.TabIndex = 2
        Me.kryptonButtonRightP.Values.DropDownArrowColor = System.Drawing.Color.Empty
        Me.kryptonButtonRightP.Values.Text = "Right"
        '
        'kryptonButtonLeftP
        '
        Me.kryptonButtonLeftP.AutoSize = True
        Me.kryptonButtonLeftP.Location = New System.Drawing.Point(11, 56)
        Me.kryptonButtonLeftP.Name = "kryptonButtonLeftP"
        Me.kryptonButtonLeftP.Size = New System.Drawing.Size(64, 28)
        Me.kryptonButtonLeftP.TabIndex = 1
        Me.kryptonButtonLeftP.Values.DropDownArrowColor = System.Drawing.Color.Empty
        Me.kryptonButtonLeftP.Values.Text = "Left"
        '
        'groupBoxSecondary
        '
        Me.groupBoxSecondary.Controls.Add(Me.kryptonButtonBottomS)
        Me.groupBoxSecondary.Controls.Add(Me.kryptonButtonTopS)
        Me.groupBoxSecondary.Controls.Add(Me.kryptonButtonRightS)
        Me.groupBoxSecondary.Controls.Add(Me.kryptonButtonLeftS)
        Me.groupBoxSecondary.Location = New System.Drawing.Point(194, 216)
        Me.groupBoxSecondary.Name = "groupBoxSecondary"
        Me.groupBoxSecondary.Size = New System.Drawing.Size(95, 154)
        Me.groupBoxSecondary.TabIndex = 5
        Me.groupBoxSecondary.TabStop = False
        Me.groupBoxSecondary.Text = "Secondary"
        '
        'kryptonButtonBottomS
        '
        Me.kryptonButtonBottomS.AutoSize = True
        Me.kryptonButtonBottomS.Location = New System.Drawing.Point(11, 118)
        Me.kryptonButtonBottomS.Name = "kryptonButtonBottomS"
        Me.kryptonButtonBottomS.Size = New System.Drawing.Size(64, 28)
        Me.kryptonButtonBottomS.TabIndex = 6
        Me.kryptonButtonBottomS.Values.DropDownArrowColor = System.Drawing.Color.Empty
        Me.kryptonButtonBottomS.Values.Text = "Bottom"
        '
        'kryptonButtonTopS
        '
        Me.kryptonButtonTopS.AutoSize = True
        Me.kryptonButtonTopS.Location = New System.Drawing.Point(10, 25)
        Me.kryptonButtonTopS.Name = "kryptonButtonTopS"
        Me.kryptonButtonTopS.Size = New System.Drawing.Size(65, 28)
        Me.kryptonButtonTopS.TabIndex = 0
        Me.kryptonButtonTopS.Values.DropDownArrowColor = System.Drawing.Color.Empty
        Me.kryptonButtonTopS.Values.Text = "Top"
        '
        'kryptonButtonRightS
        '
        Me.kryptonButtonRightS.AutoSize = True
        Me.kryptonButtonRightS.Location = New System.Drawing.Point(11, 87)
        Me.kryptonButtonRightS.Name = "kryptonButtonRightS"
        Me.kryptonButtonRightS.Size = New System.Drawing.Size(64, 28)
        Me.kryptonButtonRightS.TabIndex = 2
        Me.kryptonButtonRightS.Values.DropDownArrowColor = System.Drawing.Color.Empty
        Me.kryptonButtonRightS.Values.Text = "Right"
        '
        'kryptonButtonLeftS
        '
        Me.kryptonButtonLeftS.AutoSize = True
        Me.kryptonButtonLeftS.Location = New System.Drawing.Point(11, 56)
        Me.kryptonButtonLeftS.Name = "kryptonButtonLeftS"
        Me.kryptonButtonLeftS.Size = New System.Drawing.Size(64, 28)
        Me.kryptonButtonLeftS.TabIndex = 1
        Me.kryptonButtonLeftS.Values.DropDownArrowColor = System.Drawing.Color.Empty
        Me.kryptonButtonLeftS.Values.Text = "Left"
        '
        'kryptonThemeComboBox1
        '
        Me.kryptonThemeComboBox1.DefaultPalette = Krypton.Toolkit.PaletteMode.Office2007Blue
        Me.kryptonThemeComboBox1.DropDownWidth = 278
        Me.kryptonThemeComboBox1.IntegralHeight = False
        Me.kryptonThemeComboBox1.Location = New System.Drawing.Point(11, 455)
        Me.kryptonThemeComboBox1.Name = "kryptonThemeComboBox1"
        Me.kryptonThemeComboBox1.Size = New System.Drawing.Size(278, 26)
        Me.kryptonThemeComboBox1.StateCommon.ComboBox.Content.TextH = Krypton.Toolkit.PaletteRelativeAlign.Near
        Me.kryptonThemeComboBox1.TabIndex = 6
        '
        'Form1
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8F, 17F)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(630, 496)
        Me.Controls.Add(Me.kryptonThemeComboBox1)
        Me.Controls.Add(Me.groupBoxSecondary)
        Me.Controls.Add(Me.groupBoxPrimary)
        Me.Controls.Add(Me.groupBox1)
        Me.Controls.Add(Me.groupBoxButtonSpecs)
        Me.Controls.Add(Me.groupBoxExample)
        Me.Controls.Add(Me.groupBoxProperties)
        Me.Font = New System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.MaximizeBox = False
        Me.MinimizeBox = False
        Me.Name = "Form1"
        Me.Text = "ButtonSpec Playground"
        Me.groupBoxProperties.ResumeLayout(False)
        CType(Me.kryptonHeaderGroup1.Panel, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.kryptonHeaderGroup1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.kryptonHeaderGroup1.ResumeLayout(False)
        Me.groupBoxExample.ResumeLayout(False)
        Me.groupBoxButtonSpecs.ResumeLayout(False)
        Me.groupBoxButtonSpecs.PerformLayout()
        Me.groupBox1.ResumeLayout(False)
        Me.groupBoxPrimary.ResumeLayout(False)
        Me.groupBoxPrimary.PerformLayout()
        Me.groupBox2.ResumeLayout(False)
        Me.groupBox2.PerformLayout()
        Me.groupBoxSecondary.ResumeLayout(False)
        Me.groupBoxSecondary.PerformLayout()
        CType(Me.kryptonThemeComboBox1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
    End Sub

    Friend WithEvents groupBoxProperties As System.Windows.Forms.GroupBox
    Friend WithEvents propertyGrid As System.Windows.Forms.PropertyGrid
    Friend WithEvents kryptonHeaderGroup1 As Krypton.Toolkit.KryptonHeaderGroup
    Friend WithEvents kryptonManager1 As Krypton.Toolkit.KryptonManager
    Friend WithEvents kryptonButtonAdd As Krypton.Toolkit.KryptonButton
    Friend WithEvents kryptonButtonRemove As Krypton.Toolkit.KryptonButton
    Friend WithEvents kryptonButtonClear As Krypton.Toolkit.KryptonButton
    Friend WithEvents groupBoxExample As System.Windows.Forms.GroupBox
    Friend WithEvents groupBoxButtonSpecs As System.Windows.Forms.GroupBox
    Friend WithEvents groupBox1 As System.Windows.Forms.GroupBox
    Friend WithEvents labelInstructions As System.Windows.Forms.Label
    Friend WithEvents groupBoxPrimary As System.Windows.Forms.GroupBox
    Friend WithEvents groupBox2 As System.Windows.Forms.GroupBox
    Friend WithEvents kryptonButton1 As Krypton.Toolkit.KryptonButton
    Friend WithEvents kryptonButton2 As Krypton.Toolkit.KryptonButton
    Friend WithEvents kryptonButton3 As Krypton.Toolkit.KryptonButton
    Friend WithEvents kryptonButtonTopP As Krypton.Toolkit.KryptonButton
    Friend WithEvents kryptonButtonRightP As Krypton.Toolkit.KryptonButton
    Friend WithEvents kryptonButtonLeftP As Krypton.Toolkit.KryptonButton
    Friend WithEvents kryptonButtonBottomP As Krypton.Toolkit.KryptonButton
    Friend WithEvents groupBoxSecondary As System.Windows.Forms.GroupBox
    Friend WithEvents kryptonButtonBottomS As Krypton.Toolkit.KryptonButton
    Friend WithEvents kryptonButtonTopS As Krypton.Toolkit.KryptonButton
    Friend WithEvents kryptonButtonRightS As Krypton.Toolkit.KryptonButton
    Friend WithEvents kryptonButtonLeftS As Krypton.Toolkit.KryptonButton
    Friend WithEvents kryptonThemeComboBox1 As Krypton.Toolkit.KryptonThemeComboBox
End Class
