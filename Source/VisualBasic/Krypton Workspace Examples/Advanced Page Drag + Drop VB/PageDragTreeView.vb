#Region "BSD License"
'
' Original BSD 3-Clause License (https://github.com/ComponentFactory/Krypton/blob/master/LICENSE)
'  © Component Factory Pty Ltd, 2006 - 2016, (Version 4.5.0.0) All rights reserved.
'
'  New BSD 3-Clause License (https://github.com/Krypton-Suite/Standard-Toolkit/blob/master/LICENSE)
'  Modifications by Peter Wagner(aka Wagnerp) & Simon Coghlan(aka Smurf-IV), et al. 2017 - 2024. All rights reserved.
'
' VB.NET twin of Source\Krypton Workspace Examples\Advanced Page Drag + Drop\PageDragTreeView.cs (Bastion Phase 4c).
#End Region

Imports System.ComponentModel
Imports System.Drawing
Imports System.Windows.Forms

Imports Krypton.Navigator
Imports Krypton.Toolkit

''' <summary>
''' TreeView customized to work with KryptonPage drag and drop.
''' </summary>
Public Class PageDragTreeView
    Inherits TreeView
    Implements IDragTargetProvider

#Region "Classes"
    Public Class DragTargetTreeViewTransfer
        Inherits DragTarget

#Region "Instance Fields"
        Private _treeView As PageDragTreeView
#End Region

#Region "Identity"
        ''' <summary>
        ''' Initialize a new instance of the DragTargetTreeViewTransfer class.
        ''' </summary>
        ''' <param name="rect">Rectangle for hot and draw areas.</param>
        ''' <param name="treeView">Control instance for drop.</param>
        Public Sub New(rect As Rectangle, treeView As PageDragTreeView)
            MyBase.New(rect, rect, rect, DragTargetHint.Transfer, KryptonPageFlags.All)
            _treeView = treeView
        End Sub

        ''' <summary>
        ''' Release unmanaged and optionally managed resources.
        ''' </summary>
        ''' <param name="disposing">Called from Dispose method.</param>
        Protected Overrides Sub Dispose(disposing As Boolean)
            If disposing Then
                _treeView = Nothing
            End If

            MyBase.Dispose(disposing)
        End Sub
#End Region

#Region "Public"
        ''' <summary>
        ''' Is this target a match for the provided screen position.
        ''' </summary>
        ''' <param name="screenPt">Position in screen coordinates.</param>
        ''' <param name="dragEndData">Data to be dropped at destination.</param>
        ''' <returns>True if a match; otherwise false.</returns>
        Public Overrides Function IsMatch(screenPt As Point, dragEndData As PageDragEndData) As Boolean
            ' Cannot drag back to ourself
            If (dragEndData.Source IsNot Nothing) AndAlso
               (TypeOf dragEndData.Source Is PageDragTreeView) AndAlso
               (dragEndData.Source Is _treeView) Then
                Return False
            Else
                Return MyBase.IsMatch(screenPt, dragEndData)
            End If
        End Function

        ''' <summary>
        ''' Perform the drop action associated with the target.
        ''' </summary>
        ''' <param name="screenPt">Position in screen coordinates.</param>
        ''' <param name="data">Data to pass to the target to process drop.</param>
        ''' <returns>True if the drop was performed and the source can remove any pages.</returns>
        Public Overrides Function PerformDrop(screenPt As Point, data As PageDragEndData) As Boolean
            ' Create a node for each page
            For Each page As KryptonPage In data.Pages
                ' Create node and populate with page details
                Dim node = New TreeNode()
                node.Text = page.Text
                node.ImageIndex = Integer.Parse(CStr(page.Tag))
                node.SelectedImageIndex = node.ImageIndex
                node.Tag = page.Tag

                ' Add to end of root nodes
                _treeView.Nodes.Add(node)
            Next

            ' Take focus and select the last node added
            If _treeView.Nodes.Count > 0 Then
                _treeView.SelectedNode = _treeView.Nodes(_treeView.Nodes.Count - 1)
                _treeView.Select()
            End If

            Return True
        End Function
#End Region
    End Class
#End Region

#Region "Instance Fields"
    Private _movePages As Boolean
    Private _dragging As Boolean
    Private _dragNode As TreeNode
    Private _dragRect As Rectangle
    Private _dragPage As KryptonPage
    Private _dragPageNotify As IDragPageNotify
#End Region

#Region "Identity"
    ''' <summary>
    ''' Initialize a new instance of the PageDragTreeView class.
    ''' </summary>
    Public Sub New()
        _movePages = True
    End Sub
#End Region

#Region "Public"
    ''' <summary>
    ''' Determines if nodes are removed from successfully dragged away.
    ''' </summary>
    <Category("Behavior")>
    <Description("Determines if nodes are removed from successfully dragged away.")>
    <DefaultValue(True)>
    Public Property RemovePages As Boolean
        Get
            Return _movePages
        End Get
        Set(value As Boolean)
            _movePages = value
        End Set
    End Property

    ''' <summary>
    ''' Gets and sets the interface for receiving page drag notifications.
    ''' </summary>
    <Browsable(True)>
    <DesignerSerializationVisibility(DesignerSerializationVisibility.Hidden)>
    Public Property DragPageNotify As IDragPageNotify
        Get
            Return _dragPageNotify
        End Get
        Set(value As IDragPageNotify)
            _dragPageNotify = value
        End Set
    End Property

    ''' <summary>
    ''' Generate a list of drag targets that are relevant to the provided end data.
    ''' </summary>
    ''' <param name="dragEndData">Pages data being dragged.</param>
    ''' <returns>List of drag targets.</returns>
    Public Function GenerateDragTargets(dragEndData As PageDragEndData) As DragTargetList Implements IDragTargetProvider.GenerateDragTargets
        Dim targets = New DragTargetList()

        ' Generate target for the entire navigator client area
        targets.Add(New DragTargetTreeViewTransfer(RectangleToScreen(ClientRectangle), Me))

        Return targets
    End Function
#End Region

#Region "Protected"
    ''' <summary>
    ''' Raises the MouseDown event.
    ''' </summary>
    ''' <param name="e">A MouseEventArgs that contains the event data.</param>
    Protected Overrides Sub OnMouseDown(e As MouseEventArgs)
        ' Grab the node under the mouse
        Dim pt = New Point(e.X, e.Y)
        Dim nodeDown As TreeNode = GetNodeAt(pt)

        ' Try and ensure the node is selected on the mouse down
        If (nodeDown IsNot Nothing) AndAlso (SelectedNode IsNot nodeDown) Then
            SelectedNode = nodeDown
        End If

        ' Mouse down could be a prelude to a drag operation
        If e.Button = MouseButtons.Left Then
            ' Remember the node as a potential drag node
            _dragNode = nodeDown

            ' Create the rectangle that moving outside causes a drag operation
            _dragRect = New Rectangle(pt, Size.Empty)
            _dragRect.Inflate(SystemInformation.DragSize)
        End If

        MyBase.OnMouseDown(e)
    End Sub

    ''' <summary>
    ''' Raises the MouseMove event.
    ''' </summary>
    ''' <param name="e">A MouseEventArgs that contains the event data.</param>
    Protected Overrides Sub OnMouseMove(e As MouseEventArgs)
        Dim pt = New Point(e.X, e.Y)

        ' Are we monitoring for drag operations?
        If _dragNode IsNot Nothing Then
            ' If currently dragging
            If Capture AndAlso _dragging Then
                PageDragMove(pt)
            ElseIf Not _dragRect.Contains(pt) Then
                PageDragStart(pt)
            End If
        End If

        MyBase.OnMouseMove(e)
    End Sub

    ''' <summary>
    ''' Raises the MouseUp event.
    ''' </summary>
    ''' <param name="e">A MouseEventArgs that contains the event data.</param>
    Protected Overrides Sub OnMouseUp(e As MouseEventArgs)
        If _dragging Then
            If e.Button = MouseButtons.Left Then
                PageDragEnd(New Point(e.X, e.Y))
            Else
                PageDragQuit()
            End If
        End If

        ' Any released mouse menas we have ended drag monitoring
        _dragNode = Nothing

        MyBase.OnMouseUp(e)
    End Sub
#End Region

#Region "Implementation"
    Private Sub PageDragStart(pt As Point)
        If DragPageNotify IsNot Nothing Then
            ' Create a page that will be dragged
            _dragPage = New KryptonPage()
            _dragPage.Text = _dragNode.Text
            _dragPage.TextTitle = $"{_dragNode.Text} Title"
            _dragPage.TextDescription = $"{_dragNode.Text} Description"
            _dragPage.ImageSmall = CType(ImageList.Images(Integer.Parse(CStr(_dragNode.Tag))), Bitmap)
            _dragPage.Tag = _dragNode.Tag

            ' Create a rich text box with some sample text inside
            Dim rtb = New KryptonRichTextBox()
            rtb.Text = $"This page ({_dragPage.Text}) contains a rich text box control as example content."
            rtb.Dock = DockStyle.Fill
            rtb.StateCommon.Border.Draw = InheritBool.False

            ' Add rich text box as the contents of the page
            _dragPage.Padding = New Padding(5)
            _dragPage.Controls.Add(rtb)

            ' Give the notify interface a chance to reject the attempt to drag
            Dim de = New PageDragCancelEventArgs(PointToScreen(pt), Point.Empty, Me, New KryptonPage() {_dragPage})
            DragPageNotify.PageDragStart(Me, Nothing, de)

            If de.Cancel Then
                ' No longer need the temporary drag page
                _dragPage.Dispose()
                _dragPage = Nothing
            Else
                _dragging = True
                Capture = True
            End If
        End If
    End Sub

    Private Sub PageDragMove(pt As Point)
        If DragPageNotify IsNot Nothing Then
            DragPageNotify.PageDragMove(Me, New PointEventArgs(PointToScreen(pt)))
        End If
    End Sub

    Private Sub PageDragEnd(pt As Point)
        If DragPageNotify IsNot Nothing Then
            ' Let the target transfer the page across
            If DragPageNotify.PageDragEnd(Me, New PointEventArgs(PointToScreen(pt))) Then
                ' Should we remove the page that can been transferred
                If RemovePages Then
                    Nodes.Remove(_dragNode)
                End If
            End If

            ' Transfered the page to the target, so do not dispose it
            _dragPage = Nothing

            ' No longer dragging
            _dragging = False
            Capture = False
        End If
    End Sub

    Private Sub PageDragQuit()
        If DragPageNotify IsNot Nothing Then
            DragPageNotify.PageDragQuit(Me)

            ' Did not transfer the page to the target, so dispose it
            _dragPage.Dispose()
            _dragPage = Nothing

            ' No longer dragging
            _dragging = False
            Capture = False
        End If
    End Sub
#End Region

End Class
