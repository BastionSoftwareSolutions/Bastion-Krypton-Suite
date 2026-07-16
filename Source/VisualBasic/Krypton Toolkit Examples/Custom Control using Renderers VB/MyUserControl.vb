#Region "BSD License"
'
' Original BSD 3-Clause License (https://github.com/ComponentFactory/Krypton/blob/master/LICENSE)
'  © Component Factory Pty Ltd, 2006 - 2016, (Version 4.5.0.0) All rights reserved.
'
'  New BSD 3-Clause License (https://github.com/Krypton-Suite/Standard-Toolkit/blob/master/LICENSE)
'  Modifications by Peter Wagner(aka Wagnerp) & Simon Coghlan(aka Smurf-IV), tobitege et al. 2017 - 2025. All rights reserved.
'
' VB.NET twin of Source\Krypton Toolkit Examples\Custom Control using Renderers\MyUserControl.cs (Bastion Phase 4c).
#End Region

Imports System
Imports System.Drawing
Imports System.Drawing.Drawing2D
Imports System.Windows.Forms

Imports Krypton.Toolkit

Public Class MyUserControl
    Inherits UserControl
    Implements IContentValues

    Private _orientation As VisualOrientation
    Private _mouseOver As Boolean
    Private _mouseDown As Boolean
    Private _palette As PaletteBase
    Private ReadOnly _paletteRedirect As PaletteRedirect
    Private ReadOnly _paletteBack As PaletteBackInheritRedirect
    Private ReadOnly _paletteBorder As PaletteBorderInheritRedirect
    Private ReadOnly _paletteContent As PaletteContentInheritRedirect
    Private _mementoContent As IDisposable
    Private _mementoBack1 As IDisposable
    Private _mementoBack2 As IDisposable

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

        ' Create redirection object to the base palette
        _paletteRedirect = New PaletteRedirect(_palette)

        ' Create accessor objects for the back, border and content
        _paletteBack = New PaletteBackInheritRedirect(_paletteRedirect)
        _paletteBorder = New PaletteBorderInheritRedirect(_paletteRedirect)
        _paletteContent = New PaletteContentInheritRedirect(_paletteRedirect)
    End Sub

    Public Property Orientation As VisualOrientation
        Get
            Return _orientation
        End Get
        Set(value As VisualOrientation)
            If _orientation <> value Then
                _orientation = value
                PerformLayout()
                Invalidate()
            End If
        End Set
    End Property

    Protected Overrides Sub Dispose(disposing As Boolean)
        If disposing Then
            If _mementoContent IsNot Nothing Then
                _mementoContent.Dispose()
                _mementoContent = Nothing
            End If

            If _mementoBack1 IsNot Nothing Then
                _mementoBack1.Dispose()
                _mementoBack1 = Nothing
            End If

            If _mementoBack2 IsNot Nothing Then
                _mementoBack2.Dispose()
                _mementoBack2 = Nothing
            End If

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

    Protected Overrides Sub OnLayout(e As LayoutEventArgs)
        If _palette IsNot Nothing Then
            ' We want the inner part of the control to act like a button, so
            ' we need to find the correct palette state based on if the mouse
            ' is over the control and currently being pressed down or not.
            Dim buttonState As PaletteState = GetButtonState()

            ' Create a Rectangle inset, this is where we will draw a button
            Dim innerRect As Rectangle = ClientRectangle
            innerRect.Inflate(-20, -20)

            ' Get the renderer associated with this palette
            Dim renderer As IRenderer = _palette.GetRenderer()

            ' Create a layout context used to allow the renderer to layout the content
            Using viewContext As New ViewLayoutContext(Me, renderer)
                ' Setup the appropriate style for the content
                _paletteContent.Style = PaletteContentStyle.ButtonStandalone

                ' Cleanup resources by disposing of old memento instance
                _mementoContent?.Dispose()

                ' Ask the renderer to work out how the Content values will be laid out and
                ' return a memento object that we cache for use when actually performing painting
                _mementoContent = renderer.RenderStandardContent.LayoutContent(viewContext, innerRect, _paletteContent,
                    Me, Orientation, buttonState)
            End Using
        End If

        MyBase.OnLayout(e)
    End Sub

    Protected Overrides Sub OnPaint(e As PaintEventArgs)
        If _palette IsNot Nothing Then
            ' Get the renderer associated with this palette
            Dim renderer As IRenderer = _palette.GetRenderer()

            ' Create the rendering context that is passed into all renderer calls
            Using renderContext As New RenderContext(Me, e.Graphics, e.ClipRectangle, renderer)
                '///////////////////////////////////////////////////////////////////////////////
                ' We want to draw the background of the entire control over the entire client //
                ' area. In this example we are using a background style of HeaderPrimary      //
                '///////////////////////////////////////////////////////////////////////////////
                Using path As GraphicsPath = CreateRectGraphicsPath(ClientRectangle)
                    ' Set the style we want picked up from the base palette
                    _paletteBack.Style = PaletteBackStyle.HeaderPrimary

                    ' Ask renderer to draw the background
                    _mementoBack1 = renderer.RenderStandardBack.DrawBack(renderContext, ClientRectangle, path, _paletteBack, Orientation,
                        If(Enabled, PaletteState.Normal, PaletteState.Disabled), _mementoBack1)
                End Using

                ' We want the inner part of the control to act like a button, so
                ' we need to find the correct palette state based on if the mouse
                ' is over the control if the mouse button is pressed down or not.
                Dim buttonState As PaletteState = GetButtonState()

                ' Create a Rectangle inset, this is where we will draw a button
                Dim innerRect As Rectangle = ClientRectangle
                innerRect.Inflate(-20, -20)

                ' Set the style of button we want to draw
                _paletteBack.Style = PaletteBackStyle.ButtonStandalone
                _paletteBorder.Style = PaletteBorderStyle.ButtonStandalone
                _paletteContent.Style = PaletteContentStyle.ButtonStandalone

                ' Do we need to draw the background?
                If _paletteBack.GetBackDraw(buttonState) = InheritBool.True Then
                    '//////////////////////////////////////////////////////////////////////////////
                    ' In case the border has a rounded effect we need to get the background path   //
                    ' to draw from the border part of the renderer. It will return a path that is  //
                    ' appropriate for use drawing within the border settings.                      //
                    '//////////////////////////////////////////////////////////////////////////////
                    Using path As GraphicsPath = renderer.RenderStandardBorder.GetBackPath(renderContext,
                        innerRect,
                        _paletteBorder,
                        Orientation,
                        buttonState)
                        ' Ask renderer to draw the background
                        _mementoBack2 = renderer.RenderStandardBack.DrawBack(renderContext, innerRect, path, _paletteBack,
                            Orientation, buttonState, _mementoBack2)
                    End Using
                End If

                ' Do we need to draw the border?
                If _paletteBorder.GetBorderDraw(buttonState) = InheritBool.True Then
                    ' Now we draw the border of the inner area, also in ButtonStandalone style
                    renderer.RenderStandardBorder.DrawBorder(renderContext, innerRect, _paletteBorder, Orientation, buttonState)
                End If

                ' Do we need to draw the content?
                If _paletteContent.GetContentDraw(buttonState) = InheritBool.True Then
                    ' Last of all we draw the content over the top of the border and background
                    ' Ensure memento exists before drawing content
                    If _mementoContent Is Nothing Then
                        _mementoContent = renderer.RenderStandardContent.LayoutContent(
                            New ViewLayoutContext(Me, renderer), innerRect, _paletteContent,
                            Me, Orientation, buttonState)
                    End If
                    renderer.RenderStandardContent.DrawContent(renderContext, innerRect,
                        _paletteContent, _mementoContent,
                        Orientation, buttonState, True)
                End If
            End Using
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

    Private Function CreateRectGraphicsPath(rect As Rectangle) As GraphicsPath
        Dim path As New GraphicsPath()
        path.AddRectangle(rect)
        Return path
    End Function

    Private Sub OnGlobalPaletteChanged(sender As Object, e As EventArgs)
        ' Unhook events from old palette
        If _palette IsNot Nothing Then
            RemoveHandler _palette.PalettePaint, AddressOf OnPalettePaint
        End If

        ' Cache the new PaletteBase that is the global palette
        _palette = KryptonManager.CurrentGlobalPalette
        _paletteRedirect.Target = _palette

        ' Hook into events for the new palette
        If _palette IsNot Nothing Then
            AddHandler _palette.PalettePaint, AddressOf OnPalettePaint
        End If

        ' Change of palette means we should repaint to show any changes
        Invalidate()
    End Sub

    ' Palette indicates we might need to repaint, so lets do it
    Private Sub OnPalettePaint(sender As Object, e As PaletteLayoutEventArgs)
        Invalidate()
    End Sub

#Region "IContentValues"

    Public Function GetImage(state As PaletteState) As Image Implements IContentValues.GetImage
        Return My.Resources.wizard
    End Function

    Public Function GetImageTransparentColor(state As PaletteState) As Color Implements IContentValues.GetImageTransparentColor
        Return Color.Empty
    End Function

    Public Function GetLongText() As String Implements IContentValues.GetLongText
        Return "Click me!"
    End Function

    Public Function GetShortText() As String Implements IContentValues.GetShortText
        Return String.Empty
    End Function

#End Region

End Class
