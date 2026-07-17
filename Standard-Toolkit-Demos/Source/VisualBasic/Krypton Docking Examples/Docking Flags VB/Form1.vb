#Region "BSD License"
'
' Original BSD 3-Clause License (https://github.com/ComponentFactory/Krypton/blob/master/LICENSE)
'  © Component Factory Pty Ltd, 2006 - 2016, (Version 4.5.0.0) All rights reserved.
'
'  New BSD 3-Clause License (https://github.com/Krypton-Suite/Standard-Toolkit/blob/master/LICENSE)
'  Modifications by Peter Wagner(aka Wagnerp) & Simon Coghlan(aka Smurf-IV), et al. 2017 - 2024. All rights reserved.
'
' VB.NET twin of Source\Krypton Docking Examples\Docking Flags\Form1.cs (Bastion Phase 4c).
#End Region

Imports System
Imports System.Drawing
Imports System.Windows.Forms

Imports Krypton.Docking
Imports Krypton.Navigator
Imports Krypton.Toolkit

Public Class Form1

    Private _count As Integer = 1

    Private Function NewDocument() As KryptonPage
        ' Create new page with title and image
        Dim p = New KryptonPage With {
            .Text = $"Document {_count}"
        }
        p.TextTitle = p.Text
        p.TextDescription = p.Text
        p.UniqueName = p.Text
        p.ImageSmall = CType(imageListSmall.Images(0), Bitmap)

        ' Add the control for display inside the page
        Dim contentDoc = New ContentDocument With {
            .Dock = DockStyle.Fill
        }
        p.Controls.Add(contentDoc)

        _count += 1
        Return p
    End Function

    Private Function NewFlags() As KryptonPage
        ' Create new page with title and image
        Dim p = New KryptonPage With {
            .Text = $"Flags {_count}"
        }
        p.TextTitle = p.Text
        p.TextDescription = p.Text
        p.UniqueName = p.Text
        p.ImageSmall = CType(imageListSmall.Images(1), Bitmap)

        ' Add the control for display inside the page
        Dim contentFlags = New ContentFlags(p) With {
            .Dock = DockStyle.Fill
        }
        p.Controls.Add(contentFlags)

        _count += 1
        Return p
    End Function

    Private Sub Form1_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        ' Setup docking functionality
        Dim w As KryptonDockingWorkspace = kryptonDockingManager.ManageWorkspace(kryptonDockableWorkspace)
        kryptonDockingManager.ManageControl(kryptonPanel, w)
        kryptonDockingManager.ManageFloating(Me)

        ' Add docking pages
        kryptonDockingManager.AddDockspace("Control", DockingEdge.Left, {NewFlags(), NewFlags()})
        kryptonDockingManager.AddDockspace("Control", DockingEdge.Bottom, {NewDocument()})
        kryptonDockingManager.AddToWorkspace("Workspace", {NewFlags(), NewFlags()})
    End Sub

End Class
