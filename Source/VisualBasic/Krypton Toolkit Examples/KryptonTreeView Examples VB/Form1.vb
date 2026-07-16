' *****************************************************************************
' BSD 3-Clause License (https://github.com/ComponentFactory/Krypton/blob/master/LICENSE)
'  © Component Factory Pty Ltd, 2006-2016, All rights reserved.
'  By Peter Wagner(aka Wagnerp) & Simon Coghlan(aka Smurf-IV) 2017 - 2024. All rights reserved. (https://github.com/Krypton-Suite/Standard-Toolkit)
'  Version 5.550.0  www.ComponentFactory.com
' *****************************************************************************
' VB.NET twin of Source\Krypton Toolkit Examples\KryptonTreeView Examples\Form1.cs (Bastion Phase 4c).

Imports System.Windows.Forms

Imports Krypton.Toolkit

Public Class Form1

    Private _next As Integer = 1
    Private _rand As New Random()

    Public Sub New()
        InitializeComponent()

        buttonAppend_Click(Nothing, EventArgs.Empty)
        buttonInsert_Click(Nothing, EventArgs.Empty)
        buttonInsert_Click(Nothing, EventArgs.Empty)
        buttonInsert_Click(Nothing, EventArgs.Empty)
        kryptonTreeView.SelectedNode = Nothing
        buttonAppend_Click(Nothing, EventArgs.Empty)
        buttonInsert_Click(Nothing, EventArgs.Empty)
        buttonInsert_Click(Nothing, EventArgs.Empty)
        kryptonTreeView.SelectedNode = Nothing
        buttonAppend_Click(Nothing, EventArgs.Empty)
        buttonInsert_Click(Nothing, EventArgs.Empty)
        kryptonTreeView.SelectedNode = Nothing
        buttonAppend_Click(Nothing, EventArgs.Empty)
        buttonAppend_Click(Nothing, EventArgs.Empty)
    End Sub

    Private Function CreateNewItem() As KryptonTreeNode
        Dim item As New KryptonTreeNode With {
            .Text = $"Item {_next}",
            .ImageIndex = _rand.Next(imageList.Images.Count - 1)
        }
        _next += 1
        item.SelectedImageIndex = item.ImageIndex
        Return item
    End Function

    Private Sub buttonAppend_Click(sender As Object, e As EventArgs) Handles buttonAppend.Click
        Dim node As TreeNode = CreateNewItem()
        kryptonTreeView.Nodes.Add(node)

        ' If nothing currently selected, then select the new one
        kryptonTreeView.SelectedNode = node
    End Sub

    Private Sub buttonInsert_Click(sender As Object, e As EventArgs) Handles buttonInsert.Click
        ' Can only insert if something is already selected
        If kryptonTreeView.SelectedNode IsNot Nothing Then
            kryptonTreeView.SelectedNode.Nodes.Add(CreateNewItem())
            kryptonTreeView.SelectedNode.Expand()
        Else
            buttonAppend_Click(Nothing, EventArgs.Empty)
        End If
    End Sub

    Private Sub buttonRemove_Click(sender As Object, e As EventArgs) Handles buttonRemove.Click
        ' Can only remove if something is selected
        If kryptonTreeView.SelectedNode IsNot Nothing Then
            If kryptonTreeView.SelectedNode.Parent IsNot Nothing Then
                kryptonTreeView.SelectedNode.Parent.Nodes.Remove(kryptonTreeView.SelectedNode)
            Else
                kryptonTreeView.Nodes.Remove(kryptonTreeView.SelectedNode)
            End If
        End If
    End Sub

    Private Sub buttonClear_Click(sender As Object, e As EventArgs) Handles buttonClear.Click
        kryptonTreeView.Nodes.Clear()
    End Sub

    Private Sub kryptonCheckSet_CheckedButtonChanged(sender As Object, e As EventArgs) Handles kryptonCheckSet.CheckedButtonChanged
        If kryptonCheckSet.CheckedButton Is check2007Blue Then
            kryptonManager1.GlobalPaletteMode = PaletteMode.Office2007Blue
        ElseIf kryptonCheckSet.CheckedButton Is check2010Blue Then
            kryptonManager1.GlobalPaletteMode = PaletteMode.Office2010Blue
        ElseIf kryptonCheckSet.CheckedButton Is checkSparkle Then
            kryptonManager1.GlobalPaletteMode = PaletteMode.SparkleBlue
        ElseIf kryptonCheckSet.CheckedButton Is checkSystem Then
            kryptonManager1.GlobalPaletteMode = PaletteMode.ProfessionalSystem
        End If
    End Sub

    Private Sub buttonClose_Click(sender As Object, e As EventArgs) Handles buttonClose.Click
        Close()
    End Sub

    Private Sub BtnToggleNodeCheckBox_Click(sender As Object, e As EventArgs) Handles btnToggleNodeCheckBox.Click
        Dim kryptonNode = TryCast(kryptonTreeView.SelectedNode, KryptonTreeNode)
        If kryptonNode IsNot Nothing Then
            kryptonNode.IsCheckBoxVisible = Not kryptonNode.IsCheckBoxVisible
        End If
    End Sub

    Private Sub KryptonTreeView_BeforeCheck(sender As Object, e As TreeViewCancelEventArgs) Handles kryptonTreeView.BeforeCheck
        Dim kryptonNode = TryCast(kryptonTreeView.SelectedNode, KryptonTreeNode)
        If kryptonNode IsNot Nothing Then
            ' If the CheckBox is hidden then prevent the checking change event
            e.Cancel = Not kryptonNode.IsCheckBoxVisible
        End If
    End Sub

End Class
