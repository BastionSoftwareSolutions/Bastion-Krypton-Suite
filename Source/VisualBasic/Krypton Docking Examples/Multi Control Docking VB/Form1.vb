#Region "BSD License"
'
' Original BSD 3-Clause License (https://github.com/ComponentFactory/Krypton/blob/master/LICENSE)
'  © Component Factory Pty Ltd, 2006 - 2016, (Version 4.5.0.0) All rights reserved.
'
'  New BSD 3-Clause License (https://github.com/Krypton-Suite/Standard-Toolkit/blob/master/LICENSE)
'  Modifications by Peter Wagner(aka Wagnerp) & Simon Coghlan(aka Smurf-IV), et al. 2017 - 2024. All rights reserved.
'
' VB.NET twin of Source\Krypton Docking Examples\Multi Control Docking\Form1.cs (Bastion Phase 4c).
#End Region

Imports System
Imports System.Drawing
Imports System.Windows.Forms

Imports Krypton.Docking
Imports Krypton.Navigator

Public Class Form1

    Private _count As Integer = 1

    Private Function NewInput() As KryptonPage
        Return NewPage("Input ", 1, New ContentInput())
    End Function

    Private Function NewPage(name As String, image As Integer, content As Control) As KryptonPage
        ' Create new page with title and image
        Dim p = New KryptonPage With {
            .Text = name & _count.ToString(),
            .TextTitle = name & _count.ToString(),
            .TextDescription = name & _count.ToString(),
            .ImageSmall = CType(imageListSmall.Images(image), Bitmap)
        }

        ' Add the control for display inside the page
        content.Dock = DockStyle.Fill
        p.Controls.Add(content)
        p.MinimumSize = content.MinimumSize

        _count += 1
        Return p
    End Function

    Private Sub Form1_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        ' Add docking to the two panels and allow floating windows
        kryptonDockingManager.ManageControl("Control1", kryptonPanel2)
        kryptonDockingManager.ManageControl("Control2", kryptonPanel3)
        kryptonDockingManager.ManageFloating(Me)

        ' Add docking pages
        kryptonDockingManager.AddDockspace("Control1", DockingEdge.Left, {NewInput(), NewInput()})
        kryptonDockingManager.AddDockspace("Control1", DockingEdge.Bottom, {NewInput(), NewInput()})
        kryptonDockingManager.AddDockspace("Control2", DockingEdge.Bottom, {NewInput(), NewInput()})
        kryptonDockingManager.AddAutoHiddenGroup("Control2", DockingEdge.Right, {NewInput(), NewInput()})
    End Sub

End Class
