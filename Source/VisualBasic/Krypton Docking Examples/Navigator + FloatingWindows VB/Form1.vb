#Region "BSD License"
'
' Original BSD 3-Clause License (https://github.com/ComponentFactory/Krypton/blob/master/LICENSE)
'  © Component Factory Pty Ltd, 2006 - 2016, (Version 4.5.0.0) All rights reserved.
'
'  New BSD 3-Clause License (https://github.com/Krypton-Suite/Standard-Toolkit/blob/master/LICENSE)
'  Modifications by Peter Wagner(aka Wagnerp) & Simon Coghlan(aka Smurf-IV), et al. 2017 - 2024. All rights reserved.
'
' VB.NET twin of Source\Krypton Docking Examples\Navigator + FloatingWindows\Form1.cs (Bastion Phase 4c).
#End Region

Imports System
Imports System.Drawing
Imports System.Windows.Forms

Imports Krypton.Docking
Imports Krypton.Navigator
Imports Krypton.Toolkit

Public Class Form1

    Private _count As Integer = 1

    Private Function NewPage(name As String, image As Integer, content As Control) As KryptonPage
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

    Private Function NewDocument() As KryptonPage
        Dim page As KryptonPage = NewPage("Document ", 0, New ContentDocument())

        ' Do not allow the document pages to be closed or made auto hidden/docked
        page.ClearFlags(KryptonPageFlags.DockingAllowAutoHidden Or
                        KryptonPageFlags.DockingAllowDocked Or
                        KryptonPageFlags.DockingAllowClose)

        Return page
    End Function

    Private Sub Form1_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        ' Setup docking functionality
        Dim n As KryptonDockingNavigator = kryptonDockingManager.ManageNavigator(kryptonDockableNavigator)
        kryptonDockingManager.ManageFloating(Me)

        ' Add initial floating window and navigator documents
        kryptonDockingManager.AddFloatingWindow("Floating", {NewDocument(), NewDocument()})
        kryptonDockingManager.AddToNavigator("Navigator", {NewDocument(), NewDocument(), NewDocument()})
    End Sub

End Class
