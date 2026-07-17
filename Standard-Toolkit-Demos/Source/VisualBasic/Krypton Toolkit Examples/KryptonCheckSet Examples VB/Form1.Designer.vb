' VB.NET twin of Source\Krypton Toolkit Examples\KryptonCheckSet Examples\Form1.Designer.cs (Bastion Phase 4c).
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
        Me.buttonClose = New System.Windows.Forms.Button()
        Me.groupBoxSparkle = New System.Windows.Forms.GroupBox()
        Me.thetaSparkle = New Krypton.Toolkit.KryptonCheckButton()
        Me.gammaSparkle = New Krypton.Toolkit.KryptonCheckButton()
        Me.betaSparkle = New Krypton.Toolkit.KryptonCheckButton()
        Me.alphaSparkle = New Krypton.Toolkit.KryptonCheckButton()
        Me.groupBoxBlue = New System.Windows.Forms.GroupBox()
        Me.thetaSystem = New Krypton.Toolkit.KryptonCheckButton()
        Me.gammaSystem = New Krypton.Toolkit.KryptonCheckButton()
        Me.betaSystem = New Krypton.Toolkit.KryptonCheckButton()
        Me.alphaSystem = New Krypton.Toolkit.KryptonCheckButton()
        Me.kryptonCheckSetOffice = New Krypton.Toolkit.KryptonCheckSet(Me.components)
        Me.kryptonCheckSetSystem = New Krypton.Toolkit.KryptonCheckSet(Me.components)
        Me.groupBoxCustom = New System.Windows.Forms.GroupBox()
        Me.forwardCheckButton = New Krypton.Toolkit.KryptonCheckButton()
        Me.playCheckButton = New Krypton.Toolkit.KryptonCheckButton()
        Me.rewindCheckButton = New Krypton.Toolkit.KryptonCheckButton()
        Me.pauseCheckButton = New Krypton.Toolkit.KryptonCheckButton()
        Me.kryptonCheckSetCustom = New Krypton.Toolkit.KryptonCheckSet(Me.components)
        Me.groupBoxSparkle.SuspendLayout()
        Me.groupBoxBlue.SuspendLayout()
        CType(Me.kryptonCheckSetOffice, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.kryptonCheckSetSystem, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.groupBoxCustom.SuspendLayout()
        CType(Me.kryptonCheckSetCustom, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        Me.buttonClose.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.buttonClose.DialogResult = System.Windows.Forms.DialogResult.Cancel
        Me.buttonClose.Location = New System.Drawing.Point(263, 304)
        Me.buttonClose.Name = "buttonClose"
        Me.buttonClose.Size = New System.Drawing.Size(75, 23)
        Me.buttonClose.TabIndex = 3
        Me.buttonClose.Text = "&Close"
        Me.buttonClose.UseVisualStyleBackColor = True
        Me.groupBoxSparkle.Controls.Add(Me.thetaSparkle)
        Me.groupBoxSparkle.Controls.Add(Me.gammaSparkle)
        Me.groupBoxSparkle.Controls.Add(Me.betaSparkle)
        Me.groupBoxSparkle.Controls.Add(Me.alphaSparkle)
        Me.groupBoxSparkle.Location = New System.Drawing.Point(12, 12)
        Me.groupBoxSparkle.Name = "groupBoxSparkle"
        Me.groupBoxSparkle.Size = New System.Drawing.Size(326, 74)
        Me.groupBoxSparkle.TabIndex = 0
        Me.groupBoxSparkle.TabStop = False
        Me.groupBoxSparkle.Text = "Sparkle - Blue"
        Me.thetaSparkle.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowOnly
        Me.thetaSparkle.DialogResult = System.Windows.Forms.DialogResult.None
        Me.thetaSparkle.Location = New System.Drawing.Point(241, 30)
        Me.thetaSparkle.Name = "thetaSparkle"
        Me.thetaSparkle.Orientation = Krypton.Toolkit.VisualOrientation.Top
        Me.thetaSparkle.PaletteMode = Krypton.Toolkit.PaletteMode.SparkleBlue
        Me.thetaSparkle.Size = New System.Drawing.Size(69, 25)
        Me.thetaSparkle.TabIndex = 3
        Me.thetaSparkle.Values.Text = "Theta"
        Me.gammaSparkle.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowOnly
        Me.gammaSparkle.DialogResult = System.Windows.Forms.DialogResult.None
        Me.gammaSparkle.Location = New System.Drawing.Point(166, 30)
        Me.gammaSparkle.Name = "gammaSparkle"
        Me.gammaSparkle.Orientation = Krypton.Toolkit.VisualOrientation.Top
        Me.gammaSparkle.PaletteMode = Krypton.Toolkit.PaletteMode.SparkleBlue
        Me.gammaSparkle.Size = New System.Drawing.Size(69, 25)
        Me.gammaSparkle.TabIndex = 2
        Me.gammaSparkle.Values.Text = "Gamma"
        Me.betaSparkle.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowOnly
        Me.betaSparkle.DialogResult = System.Windows.Forms.DialogResult.None
        Me.betaSparkle.Location = New System.Drawing.Point(91, 30)
        Me.betaSparkle.Name = "betaSparkle"
        Me.betaSparkle.Orientation = Krypton.Toolkit.VisualOrientation.Top
        Me.betaSparkle.PaletteMode = Krypton.Toolkit.PaletteMode.SparkleBlue
        Me.betaSparkle.Size = New System.Drawing.Size(69, 25)
        Me.betaSparkle.TabIndex = 1
        Me.betaSparkle.Values.Text = "Beta"
        Me.alphaSparkle.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowOnly
        Me.alphaSparkle.Checked = True
        Me.alphaSparkle.DialogResult = System.Windows.Forms.DialogResult.None
        Me.alphaSparkle.Location = New System.Drawing.Point(16, 30)
        Me.alphaSparkle.Name = "alphaSparkle"
        Me.alphaSparkle.Orientation = Krypton.Toolkit.VisualOrientation.Top
        Me.alphaSparkle.PaletteMode = Krypton.Toolkit.PaletteMode.SparkleBlue
        Me.alphaSparkle.Size = New System.Drawing.Size(69, 25)
        Me.alphaSparkle.TabIndex = 0
        Me.alphaSparkle.Values.Text = "Alpha"
        Me.groupBoxBlue.Controls.Add(Me.thetaSystem)
        Me.groupBoxBlue.Controls.Add(Me.gammaSystem)
        Me.groupBoxBlue.Controls.Add(Me.betaSystem)
        Me.groupBoxBlue.Controls.Add(Me.alphaSystem)
        Me.groupBoxBlue.Location = New System.Drawing.Point(12, 92)
        Me.groupBoxBlue.Name = "groupBoxBlue"
        Me.groupBoxBlue.Size = New System.Drawing.Size(326, 74)
        Me.groupBoxBlue.TabIndex = 1
        Me.groupBoxBlue.TabStop = False
        Me.groupBoxBlue.Text = "Office 2007 - Blue"
        Me.thetaSystem.AutoSize = True
        Me.thetaSystem.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowOnly
        Me.thetaSystem.DialogResult = System.Windows.Forms.DialogResult.None
        Me.thetaSystem.Location = New System.Drawing.Point(241, 31)
        Me.thetaSystem.Name = "thetaSystem"
        Me.thetaSystem.Orientation = Krypton.Toolkit.VisualOrientation.Top
        Me.thetaSystem.PaletteMode = Krypton.Toolkit.PaletteMode.Office2007Blue
        Me.thetaSystem.Size = New System.Drawing.Size(69, 27)
        Me.thetaSystem.TabIndex = 3
        Me.thetaSystem.Values.Text = "Theta"
        Me.gammaSystem.AutoSize = True
        Me.gammaSystem.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowOnly
        Me.gammaSystem.DialogResult = System.Windows.Forms.DialogResult.None
        Me.gammaSystem.Location = New System.Drawing.Point(166, 31)
        Me.gammaSystem.Name = "gammaSystem"
        Me.gammaSystem.Orientation = Krypton.Toolkit.VisualOrientation.Top
        Me.gammaSystem.PaletteMode = Krypton.Toolkit.PaletteMode.Office2007Blue
        Me.gammaSystem.Size = New System.Drawing.Size(69, 27)
        Me.gammaSystem.TabIndex = 2
        Me.gammaSystem.Values.Text = "Gamma"
        Me.betaSystem.AutoSize = True
        Me.betaSystem.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowOnly
        Me.betaSystem.DialogResult = System.Windows.Forms.DialogResult.None
        Me.betaSystem.Location = New System.Drawing.Point(91, 31)
        Me.betaSystem.Name = "betaSystem"
        Me.betaSystem.Orientation = Krypton.Toolkit.VisualOrientation.Top
        Me.betaSystem.PaletteMode = Krypton.Toolkit.PaletteMode.Office2007Blue
        Me.betaSystem.Size = New System.Drawing.Size(69, 27)
        Me.betaSystem.TabIndex = 1
        Me.betaSystem.Values.Text = "Beta"
        Me.alphaSystem.AutoSize = True
        Me.alphaSystem.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowOnly
        Me.alphaSystem.Checked = True
        Me.alphaSystem.DialogResult = System.Windows.Forms.DialogResult.None
        Me.alphaSystem.Location = New System.Drawing.Point(16, 31)
        Me.alphaSystem.Name = "alphaSystem"
        Me.alphaSystem.Orientation = Krypton.Toolkit.VisualOrientation.Top
        Me.alphaSystem.PaletteMode = Krypton.Toolkit.PaletteMode.Office2007Blue
        Me.alphaSystem.Size = New System.Drawing.Size(69, 27)
        Me.alphaSystem.TabIndex = 0
        Me.alphaSystem.Values.Text = "Alpha"
        Me.kryptonCheckSetOffice.CheckButtons.Add(Me.thetaSparkle)
        Me.kryptonCheckSetOffice.CheckButtons.Add(Me.gammaSparkle)
        Me.kryptonCheckSetOffice.CheckButtons.Add(Me.betaSparkle)
        Me.kryptonCheckSetOffice.CheckButtons.Add(Me.alphaSparkle)
        Me.kryptonCheckSetOffice.CheckedButton = Me.alphaSparkle
        Me.kryptonCheckSetSystem.CheckButtons.Add(Me.thetaSystem)
        Me.kryptonCheckSetSystem.CheckButtons.Add(Me.gammaSystem)
        Me.kryptonCheckSetSystem.CheckButtons.Add(Me.betaSystem)
        Me.kryptonCheckSetSystem.CheckButtons.Add(Me.alphaSystem)
        Me.kryptonCheckSetSystem.CheckedButton = Me.alphaSystem
        Me.groupBoxCustom.Controls.Add(Me.forwardCheckButton)
        Me.groupBoxCustom.Controls.Add(Me.playCheckButton)
        Me.groupBoxCustom.Controls.Add(Me.rewindCheckButton)
        Me.groupBoxCustom.Controls.Add(Me.pauseCheckButton)
        Me.groupBoxCustom.Location = New System.Drawing.Point(12, 172)
        Me.groupBoxCustom.Name = "groupBoxCustom"
        Me.groupBoxCustom.Size = New System.Drawing.Size(326, 123)
        Me.groupBoxCustom.TabIndex = 2
        Me.groupBoxCustom.TabStop = False
        Me.groupBoxCustom.Text = "Custom Settings"
        Me.forwardCheckButton.AutoSize = True
        Me.forwardCheckButton.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowOnly
        Me.forwardCheckButton.DialogResult = System.Windows.Forms.DialogResult.None
        Me.forwardCheckButton.Location = New System.Drawing.Point(228, 30)
        Me.forwardCheckButton.Name = "forwardCheckButton"
        Me.forwardCheckButton.Orientation = Krypton.Toolkit.VisualOrientation.Top
        Me.forwardCheckButton.Size = New System.Drawing.Size(61, 75)
        Me.forwardCheckButton.StateCheckedNormal.Content.Draw = Krypton.Toolkit.InheritBool.Inherit
        Me.forwardCheckButton.StateCheckedNormal.Content.DrawFocus = Krypton.Toolkit.InheritBool.Inherit
        Me.forwardCheckButton.StateCheckedNormal.Content.Padding = New System.Windows.Forms.Padding(4, 4, 2, 2)
        Me.forwardCheckButton.StateCheckedPressed.Content.Draw = Krypton.Toolkit.InheritBool.Inherit
        Me.forwardCheckButton.StateCheckedPressed.Content.DrawFocus = Krypton.Toolkit.InheritBool.Inherit
        Me.forwardCheckButton.StateCheckedPressed.Content.Padding = New System.Windows.Forms.Padding(4, 4, 2, 2)
        Me.forwardCheckButton.StateCheckedTracking.Content.Draw = Krypton.Toolkit.InheritBool.Inherit
        Me.forwardCheckButton.StateCheckedTracking.Content.DrawFocus = Krypton.Toolkit.InheritBool.Inherit
        Me.forwardCheckButton.StateCheckedTracking.Content.Padding = New System.Windows.Forms.Padding(4, 4, 2, 2)
        Me.forwardCheckButton.StateCommon.Back.ColorAlign = Krypton.Toolkit.PaletteRectangleAlign.Inherit
        Me.forwardCheckButton.StateCommon.Back.ColorStyle = Krypton.Toolkit.PaletteColorStyle.Inherit
        Me.forwardCheckButton.StateCommon.Back.Draw = Krypton.Toolkit.InheritBool.False
        Me.forwardCheckButton.StateCommon.Back.GraphicsHint = Krypton.Toolkit.PaletteGraphicsHint.Inherit
        Me.forwardCheckButton.StateCommon.Back.ImageAlign = Krypton.Toolkit.PaletteRectangleAlign.Inherit
        Me.forwardCheckButton.StateCommon.Back.ImageStyle = Krypton.Toolkit.PaletteImageStyle.Inherit
        Me.forwardCheckButton.StateCommon.Border.ColorAlign = Krypton.Toolkit.PaletteRectangleAlign.Inherit
        Me.forwardCheckButton.StateCommon.Border.ColorStyle = Krypton.Toolkit.PaletteColorStyle.Inherit
        Me.forwardCheckButton.StateCommon.Border.Draw = Krypton.Toolkit.InheritBool.False
        Me.forwardCheckButton.StateCommon.Border.DrawBorders = CType((((Krypton.Toolkit.PaletteDrawBorders.Top Or Krypton.Toolkit.PaletteDrawBorders.Bottom) Or Krypton.Toolkit.PaletteDrawBorders.Left) Or Krypton.Toolkit.PaletteDrawBorders.Right), Krypton.Toolkit.PaletteDrawBorders)
        Me.forwardCheckButton.StateCommon.Border.GraphicsHint = Krypton.Toolkit.PaletteGraphicsHint.Inherit
        Me.forwardCheckButton.StateCommon.Border.ImageAlign = Krypton.Toolkit.PaletteRectangleAlign.Inherit
        Me.forwardCheckButton.StateCommon.Content.Draw = Krypton.Toolkit.InheritBool.Inherit
        Me.forwardCheckButton.StateCommon.Content.DrawFocus = Krypton.Toolkit.InheritBool.Inherit
        Me.forwardCheckButton.StateCommon.Content.Padding = New System.Windows.Forms.Padding(2)
        Me.forwardCheckButton.StateCommon.Content.ShortText.ColorAlign = Krypton.Toolkit.PaletteRectangleAlign.Inherit
        Me.forwardCheckButton.StateCommon.Content.ShortText.ColorStyle = Krypton.Toolkit.PaletteColorStyle.Inherit
        Me.forwardCheckButton.StateCommon.Content.ShortText.Hint = Krypton.Toolkit.PaletteTextHint.Inherit
        Me.forwardCheckButton.StateCommon.Content.ShortText.ImageAlign = Krypton.Toolkit.PaletteRectangleAlign.Inherit
        Me.forwardCheckButton.StateCommon.Content.ShortText.ImageStyle = Krypton.Toolkit.PaletteImageStyle.Inherit
        Me.forwardCheckButton.StateCommon.Content.ShortText.MultiLine = Krypton.Toolkit.InheritBool.Inherit
        Me.forwardCheckButton.StateCommon.Content.ShortText.MultiLineH = Krypton.Toolkit.PaletteRelativeAlign.Inherit
        Me.forwardCheckButton.StateCommon.Content.ShortText.Prefix = Krypton.Toolkit.PaletteTextHotkeyPrefix.Inherit
        Me.forwardCheckButton.StateCommon.Content.ShortText.TextH = Krypton.Toolkit.PaletteRelativeAlign.Inherit
        Me.forwardCheckButton.StateCommon.Content.ShortText.TextV = Krypton.Toolkit.PaletteRelativeAlign.Far
        Me.forwardCheckButton.StateCommon.Content.ShortText.Trim = Krypton.Toolkit.PaletteTextTrim.Inherit
        Me.forwardCheckButton.StatePressed.Content.Draw = Krypton.Toolkit.InheritBool.Inherit
        Me.forwardCheckButton.StatePressed.Content.DrawFocus = Krypton.Toolkit.InheritBool.Inherit
        Me.forwardCheckButton.StatePressed.Content.Padding = New System.Windows.Forms.Padding(4, 4, 2, 2)
        Me.forwardCheckButton.TabIndex = 3
        Me.forwardCheckButton.Values.Image = CType(resources.GetObject("forwardCheckButton.Values.Image"), System.Drawing.Image)
        Me.forwardCheckButton.Values.ImageStates.ImageCheckedNormal = CType(resources.GetObject("forwardCheckButton.Values.ImageStates.ImageCheckedNormal"), System.Drawing.Image)
        Me.forwardCheckButton.Values.ImageStates.ImageCheckedPressed = CType(resources.GetObject("forwardCheckButton.Values.ImageStates.ImageCheckedPressed"), System.Drawing.Image)
        Me.forwardCheckButton.Values.ImageStates.ImageCheckedTracking = CType(resources.GetObject("forwardCheckButton.Values.ImageStates.ImageCheckedTracking"), System.Drawing.Image)
        Me.forwardCheckButton.Values.ImageStates.ImagePressed = CType(resources.GetObject("forwardCheckButton.Values.ImageStates.ImagePressed"), System.Drawing.Image)
        Me.forwardCheckButton.Values.ImageStates.ImageTracking = CType(resources.GetObject("forwardCheckButton.Values.ImageStates.ImageTracking"), System.Drawing.Image)
        Me.forwardCheckButton.Values.Text = "Forward"
        Me.playCheckButton.AutoSize = True
        Me.playCheckButton.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowOnly
        Me.playCheckButton.Checked = True
        Me.playCheckButton.DialogResult = System.Windows.Forms.DialogResult.None
        Me.playCheckButton.Location = New System.Drawing.Point(168, 30)
        Me.playCheckButton.Name = "playCheckButton"
        Me.playCheckButton.Orientation = Krypton.Toolkit.VisualOrientation.Top
        Me.playCheckButton.Size = New System.Drawing.Size(60, 77)
        Me.playCheckButton.StateCheckedNormal.Content.Draw = Krypton.Toolkit.InheritBool.Inherit
        Me.playCheckButton.StateCheckedNormal.Content.DrawFocus = Krypton.Toolkit.InheritBool.Inherit
        Me.playCheckButton.StateCheckedNormal.Content.Padding = New System.Windows.Forms.Padding(4, 4, 2, 2)
        Me.playCheckButton.StateCheckedPressed.Content.Draw = Krypton.Toolkit.InheritBool.Inherit
        Me.playCheckButton.StateCheckedPressed.Content.DrawFocus = Krypton.Toolkit.InheritBool.Inherit
        Me.playCheckButton.StateCheckedPressed.Content.Padding = New System.Windows.Forms.Padding(4, 4, 2, 2)
        Me.playCheckButton.StateCheckedTracking.Content.Draw = Krypton.Toolkit.InheritBool.Inherit
        Me.playCheckButton.StateCheckedTracking.Content.DrawFocus = Krypton.Toolkit.InheritBool.Inherit
        Me.playCheckButton.StateCheckedTracking.Content.Padding = New System.Windows.Forms.Padding(4, 4, 2, 2)
        Me.playCheckButton.StateCommon.Back.ColorAlign = Krypton.Toolkit.PaletteRectangleAlign.Inherit
        Me.playCheckButton.StateCommon.Back.ColorStyle = Krypton.Toolkit.PaletteColorStyle.Inherit
        Me.playCheckButton.StateCommon.Back.Draw = Krypton.Toolkit.InheritBool.False
        Me.playCheckButton.StateCommon.Back.GraphicsHint = Krypton.Toolkit.PaletteGraphicsHint.Inherit
        Me.playCheckButton.StateCommon.Back.ImageAlign = Krypton.Toolkit.PaletteRectangleAlign.Inherit
        Me.playCheckButton.StateCommon.Back.ImageStyle = Krypton.Toolkit.PaletteImageStyle.Inherit
        Me.playCheckButton.StateCommon.Border.ColorAlign = Krypton.Toolkit.PaletteRectangleAlign.Inherit
        Me.playCheckButton.StateCommon.Border.ColorStyle = Krypton.Toolkit.PaletteColorStyle.Inherit
        Me.playCheckButton.StateCommon.Border.Draw = Krypton.Toolkit.InheritBool.False
        Me.playCheckButton.StateCommon.Border.DrawBorders = CType((((Krypton.Toolkit.PaletteDrawBorders.Top Or Krypton.Toolkit.PaletteDrawBorders.Bottom) Or Krypton.Toolkit.PaletteDrawBorders.Left) Or Krypton.Toolkit.PaletteDrawBorders.Right), Krypton.Toolkit.PaletteDrawBorders)
        Me.playCheckButton.StateCommon.Border.GraphicsHint = Krypton.Toolkit.PaletteGraphicsHint.Inherit
        Me.playCheckButton.StateCommon.Border.ImageAlign = Krypton.Toolkit.PaletteRectangleAlign.Inherit
        Me.playCheckButton.StateCommon.Content.Draw = Krypton.Toolkit.InheritBool.Inherit
        Me.playCheckButton.StateCommon.Content.DrawFocus = Krypton.Toolkit.InheritBool.Inherit
        Me.playCheckButton.StateCommon.Content.Padding = New System.Windows.Forms.Padding(2)
        Me.playCheckButton.StateCommon.Content.ShortText.ColorAlign = Krypton.Toolkit.PaletteRectangleAlign.Inherit
        Me.playCheckButton.StateCommon.Content.ShortText.ColorStyle = Krypton.Toolkit.PaletteColorStyle.Inherit
        Me.playCheckButton.StateCommon.Content.ShortText.Hint = Krypton.Toolkit.PaletteTextHint.Inherit
        Me.playCheckButton.StateCommon.Content.ShortText.ImageAlign = Krypton.Toolkit.PaletteRectangleAlign.Inherit
        Me.playCheckButton.StateCommon.Content.ShortText.ImageStyle = Krypton.Toolkit.PaletteImageStyle.Inherit
        Me.playCheckButton.StateCommon.Content.ShortText.MultiLine = Krypton.Toolkit.InheritBool.Inherit
        Me.playCheckButton.StateCommon.Content.ShortText.MultiLineH = Krypton.Toolkit.PaletteRelativeAlign.Inherit
        Me.playCheckButton.StateCommon.Content.ShortText.Prefix = Krypton.Toolkit.PaletteTextHotkeyPrefix.Inherit
        Me.playCheckButton.StateCommon.Content.ShortText.TextH = Krypton.Toolkit.PaletteRelativeAlign.Inherit
        Me.playCheckButton.StateCommon.Content.ShortText.TextV = Krypton.Toolkit.PaletteRelativeAlign.Far
        Me.playCheckButton.StateCommon.Content.ShortText.Trim = Krypton.Toolkit.PaletteTextTrim.Inherit
        Me.playCheckButton.StatePressed.Content.Draw = Krypton.Toolkit.InheritBool.Inherit
        Me.playCheckButton.StatePressed.Content.DrawFocus = Krypton.Toolkit.InheritBool.Inherit
        Me.playCheckButton.StatePressed.Content.Padding = New System.Windows.Forms.Padding(4, 4, 2, 2)
        Me.playCheckButton.TabIndex = 2
        Me.playCheckButton.Values.Image = CType(resources.GetObject("playCheckButton.Values.Image"), System.Drawing.Image)
        Me.playCheckButton.Values.ImageStates.ImageCheckedNormal = CType(resources.GetObject("playCheckButton.Values.ImageStates.ImageCheckedNormal"), System.Drawing.Image)
        Me.playCheckButton.Values.ImageStates.ImageCheckedPressed = CType(resources.GetObject("playCheckButton.Values.ImageStates.ImageCheckedPressed"), System.Drawing.Image)
        Me.playCheckButton.Values.ImageStates.ImageCheckedTracking = CType(resources.GetObject("playCheckButton.Values.ImageStates.ImageCheckedTracking"), System.Drawing.Image)
        Me.playCheckButton.Values.ImageStates.ImagePressed = CType(resources.GetObject("playCheckButton.Values.ImageStates.ImagePressed"), System.Drawing.Image)
        Me.playCheckButton.Values.ImageStates.ImageTracking = CType(resources.GetObject("playCheckButton.Values.ImageStates.ImageTracking"), System.Drawing.Image)
        Me.playCheckButton.Values.Text = "Play"
        Me.rewindCheckButton.AutoSize = True
        Me.rewindCheckButton.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowOnly
        Me.rewindCheckButton.DialogResult = System.Windows.Forms.DialogResult.None
        Me.rewindCheckButton.Location = New System.Drawing.Point(52, 30)
        Me.rewindCheckButton.Name = "rewindCheckButton"
        Me.rewindCheckButton.Orientation = Krypton.Toolkit.VisualOrientation.Top
        Me.rewindCheckButton.Size = New System.Drawing.Size(58, 75)
        Me.rewindCheckButton.StateCheckedNormal.Content.Draw = Krypton.Toolkit.InheritBool.Inherit
        Me.rewindCheckButton.StateCheckedNormal.Content.DrawFocus = Krypton.Toolkit.InheritBool.Inherit
        Me.rewindCheckButton.StateCheckedNormal.Content.Padding = New System.Windows.Forms.Padding(4, 4, 2, 2)
        Me.rewindCheckButton.StateCheckedPressed.Content.Draw = Krypton.Toolkit.InheritBool.Inherit
        Me.rewindCheckButton.StateCheckedPressed.Content.DrawFocus = Krypton.Toolkit.InheritBool.Inherit
        Me.rewindCheckButton.StateCheckedPressed.Content.Padding = New System.Windows.Forms.Padding(4, 4, 2, 2)
        Me.rewindCheckButton.StateCheckedTracking.Content.Draw = Krypton.Toolkit.InheritBool.Inherit
        Me.rewindCheckButton.StateCheckedTracking.Content.DrawFocus = Krypton.Toolkit.InheritBool.Inherit
        Me.rewindCheckButton.StateCheckedTracking.Content.Padding = New System.Windows.Forms.Padding(4, 4, 2, 2)
        Me.rewindCheckButton.StateCommon.Back.ColorAlign = Krypton.Toolkit.PaletteRectangleAlign.Inherit
        Me.rewindCheckButton.StateCommon.Back.ColorStyle = Krypton.Toolkit.PaletteColorStyle.Inherit
        Me.rewindCheckButton.StateCommon.Back.Draw = Krypton.Toolkit.InheritBool.False
        Me.rewindCheckButton.StateCommon.Back.GraphicsHint = Krypton.Toolkit.PaletteGraphicsHint.Inherit
        Me.rewindCheckButton.StateCommon.Back.ImageAlign = Krypton.Toolkit.PaletteRectangleAlign.Inherit
        Me.rewindCheckButton.StateCommon.Back.ImageStyle = Krypton.Toolkit.PaletteImageStyle.Inherit
        Me.rewindCheckButton.StateCommon.Border.ColorAlign = Krypton.Toolkit.PaletteRectangleAlign.Inherit
        Me.rewindCheckButton.StateCommon.Border.ColorStyle = Krypton.Toolkit.PaletteColorStyle.Inherit
        Me.rewindCheckButton.StateCommon.Border.Draw = Krypton.Toolkit.InheritBool.False
        Me.rewindCheckButton.StateCommon.Border.DrawBorders = CType((((Krypton.Toolkit.PaletteDrawBorders.Top Or Krypton.Toolkit.PaletteDrawBorders.Bottom) Or Krypton.Toolkit.PaletteDrawBorders.Left) Or Krypton.Toolkit.PaletteDrawBorders.Right), Krypton.Toolkit.PaletteDrawBorders)
        Me.rewindCheckButton.StateCommon.Border.GraphicsHint = Krypton.Toolkit.PaletteGraphicsHint.Inherit
        Me.rewindCheckButton.StateCommon.Border.ImageAlign = Krypton.Toolkit.PaletteRectangleAlign.Inherit
        Me.rewindCheckButton.StateCommon.Content.Draw = Krypton.Toolkit.InheritBool.Inherit
        Me.rewindCheckButton.StateCommon.Content.DrawFocus = Krypton.Toolkit.InheritBool.Inherit
        Me.rewindCheckButton.StateCommon.Content.Padding = New System.Windows.Forms.Padding(2)
        Me.rewindCheckButton.StateCommon.Content.ShortText.ColorAlign = Krypton.Toolkit.PaletteRectangleAlign.Inherit
        Me.rewindCheckButton.StateCommon.Content.ShortText.ColorStyle = Krypton.Toolkit.PaletteColorStyle.Inherit
        Me.rewindCheckButton.StateCommon.Content.ShortText.Hint = Krypton.Toolkit.PaletteTextHint.Inherit
        Me.rewindCheckButton.StateCommon.Content.ShortText.ImageAlign = Krypton.Toolkit.PaletteRectangleAlign.Inherit
        Me.rewindCheckButton.StateCommon.Content.ShortText.ImageStyle = Krypton.Toolkit.PaletteImageStyle.Inherit
        Me.rewindCheckButton.StateCommon.Content.ShortText.MultiLine = Krypton.Toolkit.InheritBool.Inherit
        Me.rewindCheckButton.StateCommon.Content.ShortText.MultiLineH = Krypton.Toolkit.PaletteRelativeAlign.Inherit
        Me.rewindCheckButton.StateCommon.Content.ShortText.Prefix = Krypton.Toolkit.PaletteTextHotkeyPrefix.Inherit
        Me.rewindCheckButton.StateCommon.Content.ShortText.TextH = Krypton.Toolkit.PaletteRelativeAlign.Inherit
        Me.rewindCheckButton.StateCommon.Content.ShortText.TextV = Krypton.Toolkit.PaletteRelativeAlign.Far
        Me.rewindCheckButton.StateCommon.Content.ShortText.Trim = Krypton.Toolkit.PaletteTextTrim.Inherit
        Me.rewindCheckButton.StatePressed.Content.Draw = Krypton.Toolkit.InheritBool.Inherit
        Me.rewindCheckButton.StatePressed.Content.DrawFocus = Krypton.Toolkit.InheritBool.Inherit
        Me.rewindCheckButton.StatePressed.Content.Padding = New System.Windows.Forms.Padding(4, 4, 2, 2)
        Me.rewindCheckButton.TabIndex = 0
        Me.rewindCheckButton.Values.Image = CType(resources.GetObject("rewindCheckButton.Values.Image"), System.Drawing.Image)
        Me.rewindCheckButton.Values.ImageStates.ImageCheckedNormal = CType(resources.GetObject("rewindCheckButton.Values.ImageStates.ImageCheckedNormal"), System.Drawing.Image)
        Me.rewindCheckButton.Values.ImageStates.ImageCheckedPressed = CType(resources.GetObject("rewindCheckButton.Values.ImageStates.ImageCheckedPressed"), System.Drawing.Image)
        Me.rewindCheckButton.Values.ImageStates.ImageCheckedTracking = CType(resources.GetObject("rewindCheckButton.Values.ImageStates.ImageCheckedTracking"), System.Drawing.Image)
        Me.rewindCheckButton.Values.ImageStates.ImagePressed = CType(resources.GetObject("rewindCheckButton.Values.ImageStates.ImagePressed"), System.Drawing.Image)
        Me.rewindCheckButton.Values.ImageStates.ImageTracking = CType(resources.GetObject("rewindCheckButton.Values.ImageStates.ImageTracking"), System.Drawing.Image)
        Me.rewindCheckButton.Values.Text = "Rewind"
        Me.pauseCheckButton.AutoSize = True
        Me.pauseCheckButton.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowOnly
        Me.pauseCheckButton.DialogResult = System.Windows.Forms.DialogResult.None
        Me.pauseCheckButton.Location = New System.Drawing.Point(110, 30)
        Me.pauseCheckButton.Name = "pauseCheckButton"
        Me.pauseCheckButton.Orientation = Krypton.Toolkit.VisualOrientation.Top
        Me.pauseCheckButton.Size = New System.Drawing.Size(58, 75)
        Me.pauseCheckButton.StateCheckedNormal.Content.Draw = Krypton.Toolkit.InheritBool.Inherit
        Me.pauseCheckButton.StateCheckedNormal.Content.DrawFocus = Krypton.Toolkit.InheritBool.Inherit
        Me.pauseCheckButton.StateCheckedNormal.Content.Padding = New System.Windows.Forms.Padding(4, 4, 2, 2)
        Me.pauseCheckButton.StateCheckedPressed.Content.Draw = Krypton.Toolkit.InheritBool.Inherit
        Me.pauseCheckButton.StateCheckedPressed.Content.DrawFocus = Krypton.Toolkit.InheritBool.Inherit
        Me.pauseCheckButton.StateCheckedPressed.Content.Padding = New System.Windows.Forms.Padding(4, 4, 2, 2)
        Me.pauseCheckButton.StateCheckedTracking.Content.Draw = Krypton.Toolkit.InheritBool.Inherit
        Me.pauseCheckButton.StateCheckedTracking.Content.DrawFocus = Krypton.Toolkit.InheritBool.Inherit
        Me.pauseCheckButton.StateCheckedTracking.Content.Padding = New System.Windows.Forms.Padding(4, 4, 2, 2)
        Me.pauseCheckButton.StateCommon.Back.ColorAlign = Krypton.Toolkit.PaletteRectangleAlign.Inherit
        Me.pauseCheckButton.StateCommon.Back.ColorStyle = Krypton.Toolkit.PaletteColorStyle.Inherit
        Me.pauseCheckButton.StateCommon.Back.Draw = Krypton.Toolkit.InheritBool.False
        Me.pauseCheckButton.StateCommon.Back.GraphicsHint = Krypton.Toolkit.PaletteGraphicsHint.Inherit
        Me.pauseCheckButton.StateCommon.Back.ImageAlign = Krypton.Toolkit.PaletteRectangleAlign.Inherit
        Me.pauseCheckButton.StateCommon.Back.ImageStyle = Krypton.Toolkit.PaletteImageStyle.Inherit
        Me.pauseCheckButton.StateCommon.Border.ColorAlign = Krypton.Toolkit.PaletteRectangleAlign.Inherit
        Me.pauseCheckButton.StateCommon.Border.ColorStyle = Krypton.Toolkit.PaletteColorStyle.Inherit
        Me.pauseCheckButton.StateCommon.Border.Draw = Krypton.Toolkit.InheritBool.False
        Me.pauseCheckButton.StateCommon.Border.DrawBorders = CType((((Krypton.Toolkit.PaletteDrawBorders.Top Or Krypton.Toolkit.PaletteDrawBorders.Bottom) Or Krypton.Toolkit.PaletteDrawBorders.Left) Or Krypton.Toolkit.PaletteDrawBorders.Right), Krypton.Toolkit.PaletteDrawBorders)
        Me.pauseCheckButton.StateCommon.Border.GraphicsHint = Krypton.Toolkit.PaletteGraphicsHint.Inherit
        Me.pauseCheckButton.StateCommon.Border.ImageAlign = Krypton.Toolkit.PaletteRectangleAlign.Inherit
        Me.pauseCheckButton.StateCommon.Content.Draw = Krypton.Toolkit.InheritBool.Inherit
        Me.pauseCheckButton.StateCommon.Content.DrawFocus = Krypton.Toolkit.InheritBool.Inherit
        Me.pauseCheckButton.StateCommon.Content.Padding = New System.Windows.Forms.Padding(2)
        Me.pauseCheckButton.StateCommon.Content.ShortText.ColorAlign = Krypton.Toolkit.PaletteRectangleAlign.Inherit
        Me.pauseCheckButton.StateCommon.Content.ShortText.ColorStyle = Krypton.Toolkit.PaletteColorStyle.Inherit
        Me.pauseCheckButton.StateCommon.Content.ShortText.Hint = Krypton.Toolkit.PaletteTextHint.Inherit
        Me.pauseCheckButton.StateCommon.Content.ShortText.ImageAlign = Krypton.Toolkit.PaletteRectangleAlign.Inherit
        Me.pauseCheckButton.StateCommon.Content.ShortText.ImageStyle = Krypton.Toolkit.PaletteImageStyle.Inherit
        Me.pauseCheckButton.StateCommon.Content.ShortText.MultiLine = Krypton.Toolkit.InheritBool.Inherit
        Me.pauseCheckButton.StateCommon.Content.ShortText.MultiLineH = Krypton.Toolkit.PaletteRelativeAlign.Inherit
        Me.pauseCheckButton.StateCommon.Content.ShortText.Prefix = Krypton.Toolkit.PaletteTextHotkeyPrefix.Inherit
        Me.pauseCheckButton.StateCommon.Content.ShortText.TextH = Krypton.Toolkit.PaletteRelativeAlign.Inherit
        Me.pauseCheckButton.StateCommon.Content.ShortText.TextV = Krypton.Toolkit.PaletteRelativeAlign.Far
        Me.pauseCheckButton.StateCommon.Content.ShortText.Trim = Krypton.Toolkit.PaletteTextTrim.Inherit
        Me.pauseCheckButton.StatePressed.Content.Draw = Krypton.Toolkit.InheritBool.Inherit
        Me.pauseCheckButton.StatePressed.Content.DrawFocus = Krypton.Toolkit.InheritBool.Inherit
        Me.pauseCheckButton.StatePressed.Content.Padding = New System.Windows.Forms.Padding(4, 4, 2, 2)
        Me.pauseCheckButton.TabIndex = 1
        Me.pauseCheckButton.Values.Image = CType(resources.GetObject("pauseCheckButton.Values.Image"), System.Drawing.Image)
        Me.pauseCheckButton.Values.ImageStates.ImageCheckedNormal = CType(resources.GetObject("pauseCheckButton.Values.ImageStates.ImageCheckedNormal"), System.Drawing.Image)
        Me.pauseCheckButton.Values.ImageStates.ImageCheckedPressed = CType(resources.GetObject("pauseCheckButton.Values.ImageStates.ImageCheckedPressed"), System.Drawing.Image)
        Me.pauseCheckButton.Values.ImageStates.ImageCheckedTracking = CType(resources.GetObject("pauseCheckButton.Values.ImageStates.ImageCheckedTracking"), System.Drawing.Image)
        Me.pauseCheckButton.Values.ImageStates.ImagePressed = CType(resources.GetObject("pauseCheckButton.Values.ImageStates.ImagePressed"), System.Drawing.Image)
        Me.pauseCheckButton.Values.ImageStates.ImageTracking = CType(resources.GetObject("pauseCheckButton.Values.ImageStates.ImageTracking"), System.Drawing.Image)
        Me.pauseCheckButton.Values.Text = "Pause"
        Me.kryptonCheckSetCustom.CheckButtons.Add(Me.forwardCheckButton)
        Me.kryptonCheckSetCustom.CheckButtons.Add(Me.playCheckButton)
        Me.kryptonCheckSetCustom.CheckButtons.Add(Me.rewindCheckButton)
        Me.kryptonCheckSetCustom.CheckButtons.Add(Me.pauseCheckButton)
        Me.kryptonCheckSetCustom.CheckedButton = Me.playCheckButton
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6F, 13F)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(350, 336)
        Me.Controls.Add(Me.groupBoxCustom)
        Me.Controls.Add(Me.groupBoxBlue)
        Me.Controls.Add(Me.groupBoxSparkle)
        Me.Controls.Add(Me.buttonClose)
        Me.Font = New System.Drawing.Font("Tahoma", 8.25F)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.MaximizeBox = False
        Me.MinimizeBox = False
        Me.Name = "Form1"
        Me.Text = "KryptonCheckSet Examples"
        Me.groupBoxSparkle.ResumeLayout(False)
        Me.groupBoxBlue.ResumeLayout(False)
        Me.groupBoxBlue.PerformLayout()
        CType(Me.kryptonCheckSetOffice, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.kryptonCheckSetSystem, System.ComponentModel.ISupportInitialize).EndInit()
        Me.groupBoxCustom.ResumeLayout(False)
        Me.groupBoxCustom.PerformLayout()
        CType(Me.kryptonCheckSetCustom, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
    End Sub

    Friend WithEvents buttonClose As System.Windows.Forms.Button
    Friend WithEvents groupBoxSparkle As System.Windows.Forms.GroupBox
    Friend WithEvents groupBoxBlue As System.Windows.Forms.GroupBox
    Friend WithEvents groupBoxCustom As System.Windows.Forms.GroupBox
    Friend WithEvents kryptonCheckSetOffice As Krypton.Toolkit.KryptonCheckSet
    Friend WithEvents kryptonCheckSetSystem As Krypton.Toolkit.KryptonCheckSet
    Friend WithEvents kryptonCheckSetCustom As Krypton.Toolkit.KryptonCheckSet
    Friend WithEvents thetaSparkle As Krypton.Toolkit.KryptonCheckButton
    Friend WithEvents gammaSparkle As Krypton.Toolkit.KryptonCheckButton
    Friend WithEvents betaSparkle As Krypton.Toolkit.KryptonCheckButton
    Friend WithEvents alphaSparkle As Krypton.Toolkit.KryptonCheckButton
    Friend WithEvents thetaSystem As Krypton.Toolkit.KryptonCheckButton
    Friend WithEvents gammaSystem As Krypton.Toolkit.KryptonCheckButton
    Friend WithEvents betaSystem As Krypton.Toolkit.KryptonCheckButton
    Friend WithEvents alphaSystem As Krypton.Toolkit.KryptonCheckButton
    Friend WithEvents forwardCheckButton As Krypton.Toolkit.KryptonCheckButton
    Friend WithEvents playCheckButton As Krypton.Toolkit.KryptonCheckButton
    Friend WithEvents rewindCheckButton As Krypton.Toolkit.KryptonCheckButton
    Friend WithEvents pauseCheckButton As Krypton.Toolkit.KryptonCheckButton
End Class
