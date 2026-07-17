#Region "BSD License"
'
' Original BSD 3-Clause License (https://github.com/ComponentFactory/Krypton/blob/master/LICENSE)
'  © Component Factory Pty Ltd, 2006 - 2016, (Version 4.5.0.0) All rights reserved.
'
'  New BSD 3-Clause License (https://github.com/Krypton-Suite/Standard-Toolkit/blob/master/LICENSE)
'  Modifications by Peter Wagner(aka Wagnerp) & Simon Coghlan(aka Smurf-IV), et al. 2017 - 2024. All rights reserved.
'
' VB.NET twin of Source\Krypton Docking Examples\Docking Persistence\Form1.cs (Bastion Phase 4c).
' NOTE: the C# twin carries an unused 'using static System.Windows.Forms.VisualStyles.VisualStyleElement;'
'       directive; it has no VB equivalent and is omitted.
#End Region

Imports System
Imports System.Drawing
Imports System.Windows.Forms

Imports Krypton.Docking
Imports Krypton.Navigator
Imports Krypton.Toolkit

Public Class Form1

    Private _count As Integer = 1
    Private _array1 As Byte()
    Private _array2 As Byte()
    Private _array3 As Byte()

    Private Function NewDocument() As KryptonPage
        Dim page As KryptonPage = NewPage("Document ", 0, New ContentDocument())

        ' Document pages cannot be docked or auto hidden
        page.ClearFlags(KryptonPageFlags.DockingAllowAutoHidden Or KryptonPageFlags.DockingAllowDocked)

        Return page
    End Function

    Private Function NewInput() As KryptonPage
        Return NewPage("Input ", 1, New ContentInput())
    End Function

    Private Function NewPropertyGrid() As KryptonPage
        Return NewPage("Properties ", 2, New ContentPropertyGrid())
    End Function

    Private Function NewPage(name As String, image As Integer, content As Control) As KryptonPage
        ' Create new page with title and image
        Dim count = _count.ToString()
        Dim p = New KryptonPage With {
            .Text = name & count,
            .TextTitle = name & count,
            .TextDescription = name & count
        }
        p.UniqueName = p.Text
        p.ImageSmall = CType(imageListSmall.Images(image), Bitmap)

        ' Add the control for display inside the page
        content.Dock = DockStyle.Fill
        p.Controls.Add(content)

        _count += 1
        Return p
    End Function

    Private Sub Form1_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        ' Setup docking functionality
        Dim w As KryptonDockingWorkspace = kryptonDockingManager.ManageWorkspace(kryptonDockableWorkspace)
        kryptonDockingManager.ManageControl(kryptonPanel, w)
        kryptonDockingManager.ManageFloating(Me)

        ' Add docking pages
        kryptonDockingManager.AddDockspace("Control", DockingEdge.Left, {NewPropertyGrid()})
        kryptonDockingManager.AddDockspace("Control", DockingEdge.Bottom, {NewInput(), NewInput()})
        kryptonDockingManager.AddAutoHiddenGroup("Control", DockingEdge.Right, {NewPropertyGrid()})
        kryptonDockingManager.AddToWorkspace("Workspace", {NewDocument(), NewDocument(), NewDocument()})
    End Sub

    Private Sub buttonSaveArray1_Click(sender As Object, e As EventArgs) Handles buttonSaveArray1.Click
        _array1 = kryptonDockingManager.SaveConfigToArray()
        buttonLoadArray1.Enabled = True
    End Sub

    Private Sub buttonSaveArray2_Click(sender As Object, e As EventArgs) Handles buttonSaveArray2.Click
        _array2 = kryptonDockingManager.SaveConfigToArray()
        buttonLoadArray2.Enabled = True
    End Sub

    Private Sub buttonSaveArray3_Click(sender As Object, e As EventArgs) Handles buttonSaveArray3.Click
        _array3 = kryptonDockingManager.SaveConfigToArray()
        buttonLoadArray3.Enabled = True
    End Sub

    Private Sub buttonSaveFile_Click(sender As Object, e As EventArgs) Handles buttonSaveFile.Click
        If saveFileDialog.ShowDialog(Me) = DialogResult.OK Then
            kryptonDockingManager.SaveConfigToFile(saveFileDialog.FileName)
        End If
    End Sub

    Private Sub buttonLoadArray1_Click(sender As Object, e As EventArgs) Handles buttonLoadArray1.Click
        kryptonDockingManager.LoadConfigFromArray(_array1)
    End Sub

    Private Sub buttonLoadArray2_Click(sender As Object, e As EventArgs) Handles buttonLoadArray2.Click
        kryptonDockingManager.LoadConfigFromArray(_array2)
    End Sub

    Private Sub buttonLoadArray3_Click(sender As Object, e As EventArgs) Handles buttonLoadArray3.Click
        kryptonDockingManager.LoadConfigFromArray(_array3)
    End Sub

    Private Sub buttonLoadFile_Click(sender As Object, e As EventArgs) Handles buttonLoadFile.Click
        If openFileDialog.ShowDialog(Me) = DialogResult.OK Then
            kryptonDockingManager.LoadConfigFromFile(openFileDialog.FileName)
        End If
    End Sub

    Private Sub buttonHideAll_Click(sender As Object, e As EventArgs) Handles buttonHideAll.Click
        kryptonDockingManager.HideAllPages()
    End Sub

    Private Sub buttonShowAll_Click(sender As Object, e As EventArgs) Handles buttonShowAll.Click
        kryptonDockingManager.ShowAllPages()
    End Sub

    Private Sub kryptonDockingManager_GlobalSaving(sender As Object, e As DockGlobalSavingEventArgs) Handles kryptonDockingManager.GlobalSaving
        ' Example code showing how to save extra data into the global config
        e.XmlWriter.WriteStartElement("CustomGlobalData")
        e.XmlWriter.WriteAttributeString("SavedTime", DateTime.Now.ToString("u"))
        e.XmlWriter.WriteEndElement()
    End Sub

    Private Sub kryptonDockingManager_GlobalLoading(sender As Object, e As DockGlobalLoadingEventArgs) Handles kryptonDockingManager.GlobalLoading
        ' Example code showing how to reload the extra data that was saved into the global config
        e.XmlReader.Read()
        Console.WriteLine("GlobalConfig was saved at {0}", e.XmlReader.GetAttribute("SavedTime"))
        e.XmlReader.Read()
    End Sub

    Private Sub kryptonDockingManager_PageSaving(sender As Object, e As DockPageSavingEventArgs) Handles kryptonDockingManager.PageSaving
        ' Example code showing how to save extra data into the page config
        e.XmlWriter.WriteStartElement("CustomPageData")
        e.XmlWriter.WriteAttributeString("SavedMilliseconds", DateTime.Now.Millisecond.ToString())
        e.XmlWriter.WriteEndElement()
    End Sub

    Private Sub kryptonDockingManager_PageLoading(sender As Object, e As DockPageLoadingEventArgs) Handles kryptonDockingManager.PageLoading
        ' Example code showing how to reload the extra data that was saved into the page config
        e.XmlReader.Read()
        Console.WriteLine("PageConfig was saved at {0}", e.XmlReader.GetAttribute("SavedMilliseconds"))
        e.XmlReader.Read()
    End Sub

    Private Sub kryptonContextMenuItem1_Click(sender As Object, e As EventArgs) Handles kryptonContextMenuItem1.Click
        Close()
    End Sub

    Private Sub kryptonDockingManager_RecreateLoadingPage(sender As Object, e As Krypton.Workspace.RecreateLoadingPageEventArgs) Handles kryptonDockingManager.RecreateLoadingPage
        e.Page = NewDocument()
        e.Page.Text = e.UniqueName
        e.Page.TextTitle = e.UniqueName
        e.Page.TextDescription = e.UniqueName
        e.Page.Name = e.UniqueName
        e.Page.UniqueName = e.UniqueName
    End Sub

End Class
