#Region "BSD License"
'
' Original BSD 3-Clause License (https://github.com/ComponentFactory/Krypton/blob/master/LICENSE)
'  © Component Factory Pty Ltd, 2006 - 2016, (Version 4.5.0.0) All rights reserved.
'
'  New BSD 3-Clause License (https://github.com/Krypton-Suite/Standard-Toolkit/blob/master/LICENSE)
'  Modifications by Peter Wagner(aka Wagnerp) & Simon Coghlan(aka Smurf-IV), et al. 2017 - 2024. All rights reserved.
'
' VB.NET twin of Source\Krypton Toolkit Examples\KryptonSeparator Examples\Form1.cs (Bastion Phase 4c).
#End Region

Imports System
Imports System.ComponentModel
Imports System.Drawing
Imports System.Windows.Forms

Imports Krypton.Toolkit

Public Class Form1

    Private Sub Form1_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        propertyGrid.SelectedObject = New KryptonSeparatorProxy(kryptonSeparator1)
    End Sub

    Private Sub separator_MouseDown(sender As Object, e As MouseEventArgs) Handles _
        kryptonSeparator1.MouseDown, kryptonSeparator2.MouseDown, kryptonSeparator3.MouseDown, kryptonSeparator4.MouseDown,
        kryptonSeparator5.MouseDown, kryptonSeparator6.MouseDown, kryptonSeparator7.MouseDown, kryptonSeparator8.MouseDown

        propertyGrid.SelectedObject = New KryptonSeparatorProxy(DirectCast(sender, KryptonSeparator))
    End Sub

    Private Sub separator_MoveRect(sender As Object, e As SplitterMoveRectMenuArgs) Handles _
        kryptonSeparator1.SplitterMoveRect, kryptonSeparator2.SplitterMoveRect, kryptonSeparator3.SplitterMoveRect, kryptonSeparator4.SplitterMoveRect,
        kryptonSeparator5.SplitterMoveRect, kryptonSeparator6.SplitterMoveRect, kryptonSeparator7.SplitterMoveRect, kryptonSeparator8.SplitterMoveRect

        ' Allow the splitter to move 50 pixels in each direction
        e.MoveRect = New Rectangle(e.MoveRect.X - 50,
                                   e.MoveRect.Y - 50,
                                   e.MoveRect.Width + 100,
                                   e.MoveRect.Height + 100)

        Output($"MoveRect {e.MoveRect}")
    End Sub

    Private Sub separator_Moving(sender As Object, e As SplitterCancelEventArgs) Handles _
        kryptonSeparator1.SplitterMoving, kryptonSeparator2.SplitterMoving, kryptonSeparator3.SplitterMoving, kryptonSeparator4.SplitterMoving,
        kryptonSeparator5.SplitterMoving, kryptonSeparator6.SplitterMoving, kryptonSeparator7.SplitterMoving, kryptonSeparator8.SplitterMoving

        Output($"Moving SplitX:{e.SplitX} SplitY:{e.SplitY} MouseX:{e.MouseCursorX} MouseY:{e.MouseCursorY}")
    End Sub

    Private Sub separator_Moved(sender As Object, e As SplitterEventArgs) Handles _
        kryptonSeparator1.SplitterMoved, kryptonSeparator2.SplitterMoved, kryptonSeparator3.SplitterMoved, kryptonSeparator4.SplitterMoved,
        kryptonSeparator5.SplitterMoved, kryptonSeparator6.SplitterMoved, kryptonSeparator7.SplitterMoved, kryptonSeparator8.SplitterMoved

        Output($"Moved SplitX:{e.SplitX} SplitY:{e.SplitY}")
    End Sub

    Private Sub separator_NotMoved(sender As Object, e As EventArgs) Handles _
        kryptonSeparator1.SplitterNotMoved, kryptonSeparator2.SplitterNotMoved, kryptonSeparator3.SplitterNotMoved, kryptonSeparator4.SplitterNotMoved,
        kryptonSeparator5.SplitterNotMoved, kryptonSeparator6.SplitterNotMoved, kryptonSeparator7.SplitterNotMoved, kryptonSeparator8.SplitterNotMoved

        Output("Not Moved")
    End Sub

    Private Sub Output(str As String)
        Dim newText As String = richTextBox1.Text

        If newText.Length > 10000 Then
            newText = String.Empty
        End If

        richTextBox1.Text = str & vbLf & newText
    End Sub

    Private Sub office2010Blue_Click(sender As Object, e As EventArgs) Handles office2010Blue.Click
        kryptonManager1.GlobalPaletteMode = PaletteMode.Office2010Blue
    End Sub

    Private Sub office2010Silver_Click(sender As Object, e As EventArgs) Handles office2010Silver.Click
        kryptonManager1.GlobalPaletteMode = PaletteMode.Office2010Silver
    End Sub

    Private Sub office2010Black_Click(sender As Object, e As EventArgs) Handles office2010Black.Click
        kryptonManager1.GlobalPaletteMode = PaletteMode.Office2010Black
    End Sub

    Private Sub office2007Blue_Click(sender As Object, e As EventArgs) Handles office2007Blue.Click
        kryptonManager1.GlobalPaletteMode = PaletteMode.Office2007Blue
    End Sub

    Private Sub office2007Silver_Click(sender As Object, e As EventArgs) Handles office2007Silver.Click
        kryptonManager1.GlobalPaletteMode = PaletteMode.Office2007Silver
    End Sub

    Private Sub office2007Black_Click(sender As Object, e As EventArgs) Handles office2007Black.Click
        kryptonManager1.GlobalPaletteMode = PaletteMode.Office2007Black
    End Sub

    Private Sub sparkleBlue_Click(sender As Object, e As EventArgs) Handles sparkleBlue.Click
        kryptonManager1.GlobalPaletteMode = PaletteMode.SparkleBlue
    End Sub

    Private Sub office2003_Click(sender As Object, e As EventArgs) Handles office2003.Click
        kryptonManager1.GlobalPaletteMode = PaletteMode.ProfessionalOffice2003
    End Sub

    Private Sub system_Click(sender As Object, e As EventArgs) Handles system.Click
        kryptonManager1.GlobalPaletteMode = PaletteMode.ProfessionalSystem
    End Sub

    Private Sub buttonClose_Click(sender As Object, e As EventArgs) Handles buttonClose.Click
        Close()
    End Sub

End Class

Public Class KryptonSeparatorProxy

    Private _separator As KryptonSeparator

    Public Sub New(separator As KryptonSeparator)
        _separator = separator
    End Sub

#Region "Public"
    <Category("Visuals")>
    <Description("Separator background style.")>
    Public Property ContainerBackStyle As PaletteBackStyle
        Get
            Return _separator.ContainerBackStyle
        End Get
        Set(value As PaletteBackStyle)
            _separator.ContainerBackStyle = value
        End Set
    End Property

    <Category("Visuals")>
    <Description("Separator style.")>
    Public Property SeparatorStyle As SeparatorStyle
        Get
            Return _separator.SeparatorStyle
        End Get
        Set(value As SeparatorStyle)
            _separator.SeparatorStyle = value
        End Set
    End Property

    <Category("Visuals")>
    <Description("Overrides for defining common separator appearance that other states can override.")>
    Public ReadOnly Property StateCommon As PaletteSplitContainerRedirect
        Get
            Return _separator.StateCommon
        End Get
    End Property

    <Category("Visuals")>
    <Description("Overrides for defining disabled separator appearance.")>
    Public ReadOnly Property StateDisabled As PaletteSplitContainer
        Get
            Return _separator.StateDisabled
        End Get
    End Property

    <Category("Visuals")>
    <Description("Overrides for defining normal separator appearance.")>
    Public ReadOnly Property StateNormal As PaletteSplitContainer
        Get
            Return _separator.StateNormal
        End Get
    End Property

    <Category("Visuals")>
    <Description("Overrides for defining hot tracking separator appearance.")>
    Public ReadOnly Property StateTracking As PaletteSeparatorPadding
        Get
            Return _separator.StateTracking
        End Get
    End Property

    <Category("Visuals")>
    <Description("Overrides for defining pressed separator appearance.")>
    Public ReadOnly Property StatePressed As PaletteSeparatorPadding
        Get
            Return _separator.StatePressed
        End Get
    End Property

    <Category("Layout")>
    <Description("Determines the increment used for moving.")>
    Public Property SplitterIncrements As Integer
        Get
            Return _separator.SplitterIncrements
        End Get
        Set(value As Integer)
            _separator.SplitterIncrements = value
        End Set
    End Property

    <Category("Layout")>
    <Description("Determines if the separator is vertical or horizontal.")>
    Public Property Orientation As Orientation
        Get
            Return _separator.Orientation
        End Get
        Set(value As Orientation)
            _separator.Orientation = value
        End Set
    End Property

    <Category("Behavior")>
    <Description("Determines if the separator is allowed to notify a move.")>
    Public Property AllowMove As Boolean
        Get
            Return _separator.AllowMove
        End Get
        Set(value As Boolean)
            _separator.AllowMove = value
        End Set
    End Property

    <Category("Visuals")>
    <Description("Palette applied to drawing.")>
    <DefaultValue(PaletteMode.Global)>
    Public Property PaletteMode As PaletteMode
        Get
            Return _separator.PaletteMode
        End Get
        Set(value As PaletteMode)
            _separator.PaletteMode = value
        End Set
    End Property

    <Category("Layout")>
    <Description("The size of the control is pixels.")>
    Public Property Size As Size
        Get
            Return _separator.Size
        End Get
        Set(value As Size)
            _separator.Size = value
        End Set
    End Property

    <Category("Layout")>
    <Description("The location of the control in pixels.")>
    Public Property Location As Point
        Get
            Return _separator.Location
        End Get
        Set(value As Point)
            _separator.Location = value
        End Set
    End Property

    <Category("Behavior")>
    <Description("Indicates whether the control is enabled.")>
    Public Property Enabled As Boolean
        Get
            Return _separator.Enabled
        End Get
        Set(value As Boolean)
            _separator.Enabled = value
        End Set
    End Property
#End Region

End Class
