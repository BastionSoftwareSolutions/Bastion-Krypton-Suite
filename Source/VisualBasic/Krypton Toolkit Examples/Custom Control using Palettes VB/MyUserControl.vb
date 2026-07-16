#Region "BSD License"
'
' Original BSD 3-Clause License (https://github.com/ComponentFactory/Krypton/blob/master/LICENSE)
'  © Component Factory Pty Ltd, 2006 - 2016, (Version 4.5.0.0) All rights reserved.
'
'  New BSD 3-Clause License (https://github.com/Krypton-Suite/Standard-Toolkit/blob/master/LICENSE)
'  Modifications by Peter Wagner(aka Wagnerp) & Simon Coghlan(aka Smurf-IV), tobitege et al. 2017 - 2025. All rights reserved.
'
' VB.NET twin of Source\Krypton Toolkit Examples\Custom Control using Palettes\MyUserControl.cs (Bastion Phase 4c).
#End Region

Imports System
Imports System.Drawing
Imports System.Drawing.Drawing2D
Imports System.Windows.Forms

Imports Krypton.Toolkit

Public Class MyUserControl
    Inherits UserControl

    Private _mouseOver As Boolean
    Private _mouseDown As Boolean
    Private _palette As PaletteBase

    Public Sub New()
        ' To remove flicker we use double buffering for drawing
        SetStyle(ControlStyles.AllPaintingInWmPaint Or
                 ControlStyles.OptimizedDoubleBuffer Or
                 ControlStyles.ResizeRedraw, True)

        ' Cache the current global palette setting
        _palette = KryptonManager.CurrentGlobalPalette

        ' Hook into palette events
        If _palette IsNot Nothing Then
            AddHandler _palette.PalettePaint, AddressOf OnPalettePaint
        End If

        ' We want to be notified whenever the global palette changes
        AddHandler KryptonManager.GlobalPaletteChanged, AddressOf OnGlobalPaletteChanged
    End Sub

    Protected Overrides Sub Dispose(disposing As Boolean)
        If disposing Then
            ' Unhook from the palette events
            If _palette IsNot Nothing Then
                RemoveHandler _palette.PalettePaint, AddressOf OnPalettePaint
                _palette = Nothing
            End If

            ' Unhook from the static events, otherwise we cannot be garbage collected
            RemoveHandler KryptonManager.GlobalPaletteChanged, AddressOf OnGlobalPaletteChanged
        End If

        MyBase.Dispose(disposing)
    End Sub

    Protected Overrides Sub OnMouseEnter(e As EventArgs)
        _mouseOver = True
        Invalidate()
        MyBase.OnMouseEnter(e)
    End Sub

    Protected Overrides Sub OnMouseDown(e As MouseEventArgs)
        _mouseDown = (e.Button = MouseButtons.Left)
        Invalidate()
        MyBase.OnMouseDown(e)
    End Sub

    Protected Overrides Sub OnMouseUp(e As MouseEventArgs)
        _mouseDown = _mouseDown AndAlso (e.Button <> MouseButtons.Left)
        Invalidate()
        MyBase.OnMouseUp(e)
    End Sub

    Protected Overrides Sub OnMouseLeave(e As EventArgs)
        _mouseOver = False
        Invalidate()
        MyBase.OnMouseLeave(e)
    End Sub

    Protected Overrides Sub OnPaint(e As PaintEventArgs)
        If _palette IsNot Nothing Then
            ' Save the original state, so any changes we make are easy to undo
            Dim state As GraphicsState = e.Graphics.Save()

            ' We want the inner part of the control to act like a button, so
            ' we need to find the correct palette state based on if the mouse
            ' is over the control and currently being pressed down or not.
            Dim buttonState As PaletteState = GetButtonState()

            '///////////////////////////////////////////////////
            ' Get the various palette details needed to draw //
            ' our fish in the various states we implement    //
            '///////////////////////////////////////////////////

            ' Get the two colors and angle used to draw the control background
            Dim backColor1 As Color = _palette.GetBackColor1(PaletteBackStyle.PanelAlternate, If(Enabled, PaletteState.Normal, PaletteState.Disabled))
            Dim backColor2 As Color = _palette.GetBackColor2(PaletteBackStyle.PanelAlternate, If(Enabled, PaletteState.Normal, PaletteState.Disabled))
            Dim backColorAngle As Single = _palette.GetBackColorAngle(PaletteBackStyle.PanelAlternate, If(Enabled, PaletteState.Normal, PaletteState.Disabled))

            ' Get the two colors and angle used to draw the fish area background
            Dim fillColor1 As Color = _palette.GetBackColor1(PaletteBackStyle.ButtonStandalone, buttonState)
            Dim fillColor2 As Color = _palette.GetBackColor2(PaletteBackStyle.ButtonStandalone, buttonState)
            Dim fillColorAngle As Single = _palette.GetBackColorAngle(PaletteBackStyle.ButtonStandalone, buttonState)

            ' Get the color used to draw the fish border
            Dim borderColor As Color = _palette.GetBorderColor1(PaletteBorderStyle.ButtonStandalone, buttonState)

            ' Get the color and font used to draw the text
            Dim textColor As Color = _palette.GetContentShortTextColor1(PaletteContentStyle.ButtonStandalone, buttonState)
            Dim textFont As Font = _palette.GetContentShortTextFont(PaletteContentStyle.ButtonStandalone, buttonState)

            '///////////////////////////////////////////////////
            ' Perform actual drawing using the palette values //
            '///////////////////////////////////////////////////

            ' Populate a graphics path to describe the shape we want to draw
            Using path As GraphicsPath = CreateFishPath()
                ' We want to anti alias the drawing for nice smooth curves
                e.Graphics.SmoothingMode = SmoothingMode.AntiAlias

                ' Fill the entire background in the control background color
                Using backBrush As New LinearGradientBrush(ClientRectangle, backColor1, backColor2, backColorAngle)
                    e.Graphics.FillRectangle(backBrush, e.ClipRectangle)
                End Using

                ' Fill the entire fish background using a gradient
                Using fillBrush As New LinearGradientBrush(ClientRectangle, fillColor1, fillColor2, fillColorAngle)
                    e.Graphics.FillPath(fillBrush, path)
                End Using

                ' Draw the fish border using a single color
                Using borderPen As New Pen(borderColor)
                    e.Graphics.DrawPath(borderPen, path)
                End Using

                ' Draw the text in about the center of the control
                Using textBrush As New SolidBrush(textColor)
                    e.Graphics.DrawString("Click me!", If(textFont, Font), textBrush, Width / 2.0F - 10, Height / 2.0F - 5)
                End Using
            End Using

            ' Put graphics back into original state before returning
            e.Graphics.Restore(state)
        End If

        MyBase.OnPaint(e)
    End Sub

    ' Find the correct state when getting button values
    Private Function GetButtonState() As PaletteState
        If Not Enabled Then
            Return PaletteState.Disabled
        End If

        If _mouseOver Then
            Return If(_mouseDown, PaletteState.Pressed, PaletteState.Tracking)
        End If

        Return PaletteState.Normal
    End Function

    Private Function CreateFishPath() As GraphicsPath
        ' The bounding box for the fish is slightly smaller than the client area
        Dim fishRect As Rectangle = ClientRectangle
        fishRect.Inflate(-5, -5)

        ' Find some lengths
        Dim w3 As Integer = Width \ 3
        Dim w6 As Integer = Width \ 6
        Dim h2 As Integer = Height \ 2
        Dim h4 As Integer = Height \ 4

        Dim fishPath As New GraphicsPath()

        ' Create the tail of the fish
        fishPath.AddLine(fishRect.Left + w6, fishRect.Bottom - h4, fishRect.Left, fishRect.Bottom)
        fishPath.AddLine(fishRect.Left, fishRect.Bottom, fishRect.Left, fishRect.Top)
        fishPath.AddLine(fishRect.Left, fishRect.Top, fishRect.Left + w6, fishRect.Top + h4)

        ' Create the curving body of the fish
        fishPath.AddCurve({New Point(fishRect.Left + w6, fishRect.Top + h4),
                           New Point(fishRect.Right - w3, fishRect.Top),
                           New Point(fishRect.Right, fishRect.Top + h2),
                           New Point(fishRect.Right - w3, fishRect.Bottom),
                           New Point(fishRect.Left + w6, fishRect.Bottom - h4)}, 0.8F)

        Return fishPath
    End Function

    Private Sub OnGlobalPaletteChanged(sender As Object, e As EventArgs)
        ' Unhook events from old palette
        If _palette IsNot Nothing Then
            RemoveHandler _palette.PalettePaint, AddressOf OnPalettePaint
        End If

        ' Cache the new PaletteBase that is the global palette
        _palette = KryptonManager.CurrentGlobalPalette

        ' Hook into events for the new palette
        If _palette IsNot Nothing Then
            AddHandler _palette.PalettePaint, AddressOf OnPalettePaint
        End If

        ' Change of palette means we should repaint to show any changes
        Invalidate()
    End Sub

    Private Sub OnPalettePaint(sender As Object, e As PaletteLayoutEventArgs)
        ' Palette indicates we might need to repaint, so lets do it
        Invalidate()
    End Sub

End Class
