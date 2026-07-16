#Region "BSD License"
'
' Original BSD 3-Clause License (https://github.com/ComponentFactory/Krypton/blob/master/LICENSE)
'  © Component Factory Pty Ltd, 2006 - 2016, (Version 4.5.0.0) All rights reserved.
'
'  New BSD 3-Clause License (https://github.com/Krypton-Suite/Standard-Toolkit/blob/master/LICENSE)
'  Modifications by Peter Wagner(aka Wagnerp) & Simon Coghlan(aka Smurf-IV), et al. 2017 - 2024. All rights reserved.
'
' VB.NET twin of Source\Krypton Docking Examples\External Drag To Docking\ContentTreeView.cs (Bastion Phase 4c).
#End Region

Imports System
Imports System.Drawing
Imports System.Windows.Forms

Imports Krypton.Docking
Imports Krypton.Navigator

Public Class ContentTreeView

    Public Sub New(form1 As Form1)
        InitializeComponent()
        treeView1.Form1 = form1
    End Sub

End Class

Public Class DraggableTreeView
    Inherits TreeView

    Private _dragging As Boolean
    Private _dragNode As TreeNode
    Private _dragRect As Rectangle

    Public Property Form1 As Form1

    Protected Overrides Sub OnMouseDown(e As MouseEventArgs)
        ' Find the tree node under the mouse point
        Dim pt = New Point(e.X, e.Y)
        Dim nodeDown As TreeNode = GetNodeAt(pt)

        ' If there is a node under the mouse
        If nodeDown IsNot Nothing Then
            ' Ensure the node is selected
            If SelectedNode IsNot nodeDown Then
                SelectedNode = nodeDown
            End If

            ' Left mouse down means we might be starting a drag operation
            If e.Button = MouseButtons.Left Then
                _dragNode = nodeDown
                _dragRect = New Rectangle(pt, Size.Empty)
                _dragRect.Inflate(SystemInformation.DragSize)
            End If
        End If

        MyBase.OnMouseDown(e)
    End Sub

    Protected Overrides Sub OnMouseUp(e As MouseEventArgs)
        _dragNode = Nothing
        MyBase.OnMouseUp(e)
    End Sub

    Protected Overrides Sub OnMouseMove(e As MouseEventArgs)
        Dim pt = New Point(e.X, e.Y)

        ' Do we need to check for a drag operation?
        If (_dragNode IsNot Nothing) AndAlso Not _dragging Then
            Dim dragPage As KryptonPage = Nothing

            ' Create the correct type of krypton page for the selected node
            Select Case _dragNode.Name
                Case "Document"
                    dragPage = Form1.NewDocument()
                Case "Property Grid"
                    dragPage = Form1.NewPropertyGrid()
                Case "Input Form"
                    dragPage = Form1.NewInput()
            End Select

            ' If we managed to create a page for dragging...
            If dragPage IsNot Nothing Then
                _dragging = True

                ' Add a floating window to the docking manager which contains the new drag page
                Dim fw As KryptonDockingFloatingWindow = Form1.DockingManager.AddFloatingWindow("Floating",
                                                                                                {dragPage},
                                                                                                New Point(MousePosition.X - pt.X, MousePosition.Y - pt.Y))

                ' DoEvents spins the message loop so that the window gets fully created and shown
                Application.DoEvents()

                ' We want to know when the drag drop operating is finished
                AddHandler Form1.DockingManager.DoDragDropEnd, AddressOf kryptonDockingManager_DoDragDropFinished
                AddHandler Form1.DockingManager.DoDragDropQuit, AddressOf kryptonDockingManager_DoDragDropFinished

                ' Drag the new floating window around
                Form1.DockingManager.DoDragDrop(MousePosition, pt, dragPage, fw)
            End If
        End If

        MyBase.OnMouseMove(e)
    End Sub

    Private Sub kryptonDockingManager_DoDragDropFinished(sender As Object, e As EventArgs)
        ' Remember to unhook from no longer needed events
        RemoveHandler Form1.DockingManager.DoDragDropEnd, AddressOf kryptonDockingManager_DoDragDropFinished
        RemoveHandler Form1.DockingManager.DoDragDropQuit, AddressOf kryptonDockingManager_DoDragDropFinished

        ' Drag has finished so set drag node back to null
        _dragNode = Nothing
        _dragging = False
    End Sub

End Class
