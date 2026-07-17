#Region "BSD License"
'
' Original BSD 3-Clause License (https://github.com/ComponentFactory/Krypton/blob/master/LICENSE)
'  © Component Factory Pty Ltd, 2006 - 2016, (Version 4.5.0.0) All rights reserved.
'
'  New BSD 3-Clause License (https://github.com/Krypton-Suite/Standard-Toolkit/blob/master/LICENSE)
'  Modifications by Peter Wagner(aka Wagnerp) & Simon Coghlan(aka Smurf-IV), et al. 2017 - 2024. All rights reserved.
'
' VB.NET twin of Source\Krypton Docking Examples\External Drag To Docking\Form1.cs (Bastion Phase 4c).
#End Region

Imports System
Imports System.Drawing
Imports System.Windows.Forms

Imports Krypton.Docking
Imports Krypton.Navigator
Imports Krypton.Toolkit

Public Class Form1

    Private _count As Integer = 1

    Public Function NewDocument() As KryptonPage
        Return NewPage("Document ", 0, New ContentDocument())
    End Function

    Public Function NewInput() As KryptonPage
        Return NewPage("Input ", 1, New ContentInput())
    End Function

    Public Function NewPropertyGrid() As KryptonPage
        Return NewPage("Properties ", 2, New ContentPropertyGrid())
    End Function

    Public Function NewTreeView() As KryptonPage
        Return NewPage("TreeView ", 3, New ContentTreeView(Me))
    End Function

    Public Function NewPage(name As String, image As Integer, content As Control) As KryptonPage
        ' Create new page with title and image
        Dim p = New KryptonPage With {
            .Text = name & _count.ToString(),
            .TextTitle = name & _count.ToString(),
            .TextDescription = name & _count.ToString()
        }
        p.UniqueName = p.Text
        p.ImageSmall = CType(imageListSmall.Images(image), Bitmap)

        ' Add the control for display inside the page
        content.Dock = DockStyle.Fill
        p.Controls.Add(content)

        _count += 1
        Return p
    End Function

    Public ReadOnly Property DockingManager As KryptonDockingManager
        Get
            Return kryptonDockingManager
        End Get
    End Property

    Private Sub Form1_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        ' Setup docking functionality
        Dim w As KryptonDockingWorkspace = kryptonDockingManager.ManageWorkspace(kryptonDockableWorkspace)
        kryptonDockingManager.ManageControl(kryptonPanel, w)
        kryptonDockingManager.ManageFloating(Me)

        ' Add initial docking pages
        kryptonDockingManager.AddDockspace("Control", DockingEdge.Left, {NewTreeView()})
        kryptonDockingManager.AddToWorkspace("Workspace", {NewDocument()})
    End Sub

End Class
