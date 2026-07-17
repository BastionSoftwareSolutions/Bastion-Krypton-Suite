#Region "BSD License"
'
'  New BSD 3-Clause License (https://github.com/Krypton-Suite/Standard-Toolkit/blob/master/LICENSE)
'  Modifications by Peter Wagner(aka Wagnerp) & Simon Coghlan(aka Smurf-IV), tobitege et al. 2025 - 2025. All rights reserved.
'
' VB.NET twin of Source\Krypton Toolkit Examples\KryptonToolStripMenuItem Examples\MenuToolBarStatusStripTest.cs (Bastion Phase 4c).
#End Region

Imports System.Drawing
Imports System.Windows.Forms
Imports Krypton.Toolkit

Public Class MenuToolBarStatusStripTest

    Private ReadOnly _statusStripTimer As New System.Windows.Forms.Timer()
    Private _baseStatusStripColor As Color
    Private ReadOnly _targetStatusStripColor As Color = Color.DarkOrange
    Private _animStep As Integer
    Private _animDir As Integer = 1

    Public Sub New()
        InitializeComponent()

        ' Dynamic wiring, mirroring the C# twin (which hooks these in the
        ' constructor rather than through the designer).
        _statusStripTimer.Interval = 30
        AddHandler _statusStripTimer.Tick, AddressOf StatusStripTimer_Tick

        AddHandler KryptonManager.GlobalPaletteChanged, AddressOf KryptonManager_GlobalPaletteChanged
    End Sub

    Private Sub animateStatusStripToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles animateStatusStripToolStripMenuItem.Click
        ' Animate the status strip background color between default and Orange color
        If animateStatusStripToolStripMenuItem.Checked Then
            _animStep = 0
            _animDir = 1
            _baseStatusStripColor = GetCurrentStatusStripBaseColor()
            _statusStripTimer.Start()
        Else
            _statusStripTimer.Stop()
            ' Reset to palette defaults when manually stopped
            Dim kss = TryCast(statusStrip1, Krypton.Toolkit.KryptonStatusStrip)
            If kss IsNot Nothing Then
                kss.StateCommon.Color1 = GlobalStaticValues.EMPTY_COLOR
                kss.StateCommon.Color2 = GlobalStaticValues.EMPTY_COLOR
                kss.StateCommon.ColorStyle = PaletteColorStyle.Inherit
                kss.StateCommon.ColorAngle = -1F
                kss.Invalidate()
            Else
                statusStrip1.BackColor = SystemColors.Control
            End If
        End If
    End Sub

    Private Sub StatusStripTimer_Tick(sender As Object, e As EventArgs)
        ' Fast ping-pong between base color and dark orange
        Const maxSteps As Integer = 20 ' smaller is faster
        _animStep += _animDir
        If _animStep >= maxSteps OrElse _animStep <= 0 Then
            _animDir *= -1
            If _animStep < 0 Then
                _animStep = 0
            ElseIf _animStep > maxSteps Then
                _animStep = maxSteps
            End If
        End If
        Dim t As Single = _animStep / CSng(maxSteps)
        Dim color = LerpColor(_baseStatusStripColor, _targetStatusStripColor, t)

        Dim kss = TryCast(statusStrip1, Krypton.Toolkit.KryptonStatusStrip)
        If kss IsNot Nothing Then
            ' Use per-control override path
            kss.StateCommon.ColorStyle = Krypton.Toolkit.PaletteColorStyle.Solid
            kss.StateCommon.Color1 = color
            kss.StateCommon.Color2 = GlobalStaticValues.EMPTY_COLOR
            kss.StateCommon.ColorAngle = -1F
        Else
            statusStrip1.BackColor = color
        End If
    End Sub

    Private Sub KryptonManager_GlobalPaletteChanged(sender As Object, e As EventArgs)
        ' Stop animation and reset to palette defaults
        _statusStripTimer.Stop()
        If animateStatusStripToolStripMenuItem.Checked Then
            animateStatusStripToolStripMenuItem.Checked = False
        End If

        Dim kss = TryCast(statusStrip1, Krypton.Toolkit.KryptonStatusStrip)
        If kss IsNot Nothing Then
            ' Clear per-control overrides to fall back to palette
            kss.StateCommon.Color1 = GlobalStaticValues.EMPTY_COLOR
            kss.StateCommon.Color2 = GlobalStaticValues.EMPTY_COLOR
            kss.StateCommon.ColorStyle = PaletteColorStyle.Inherit
            kss.StateCommon.ColorAngle = -1F
            kss.Invalidate()
        End If
    End Sub

    ' “Lerp” = linear interpolation. LerpColor blends between two colors by a fraction t in [0,1], per channel:
    ' - t=0 returns the start color
    ' - t=1 returns the end color
    ' - 0<t<1 returns a mix
    '
    ' Example (conceptually): result.R = a.R + (b.R - a.R) * t, same for G and B.
    Private Shared Function LerpColor(a As Color, b As Color, t As Single) As Color
        t = Math.Max(0F, Math.Min(1F, t))
        ' Widen the byte channels first: unlike C#, VB byte arithmetic does not
        ' promote to Integer, so (b.R - a.R) could otherwise overflow.
        Dim r As Integer = CInt(Math.Round(CInt(a.R) + (CInt(b.R) - CInt(a.R)) * t))
        Dim g As Integer = CInt(Math.Round(CInt(a.G) + (CInt(b.G) - CInt(a.G)) * t))
        Dim bch As Integer = CInt(Math.Round(CInt(a.B) + (CInt(b.B) - CInt(a.B)) * t))
        Return Color.FromArgb(255, r, g, bch)
    End Function

    Private Function GetCurrentStatusStripBaseColor() As Color
        ' Prefer palette ColorTable values for the current theme
        Dim ct = KryptonManager.CurrentGlobalPalette?.ColorTable
        If ct IsNot Nothing Then
            If ct.StatusStripGradientEnd <> GlobalStaticValues.EMPTY_COLOR Then
                Return ct.StatusStripGradientEnd
            End If
            If ct.StatusStripGradientBegin <> GlobalStaticValues.EMPTY_COLOR Then
                Return ct.StatusStripGradientBegin
            End If
        End If

        ' Fallbacks
        Dim kss = TryCast(statusStrip1, Krypton.Toolkit.KryptonStatusStrip)
        If kss IsNot Nothing Then
            ' Use inherited default if available
            Dim c1 = kss.StateCommon.GetBackColor1(Krypton.Toolkit.PaletteState.Normal)
            If c1 <> GlobalStaticValues.EMPTY_COLOR AndAlso Not c1.IsEmpty Then
                Return c1
            End If
        End If
        Return If(statusStrip1.BackColor.IsEmpty,
                  SystemColors.Control,
                  statusStrip1.BackColor)
    End Function

    Private Sub exitToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles exitToolStripMenuItem.Click
        Close()
    End Sub

End Class
