#Region "BSD License"
'
' Original BSD 3-Clause License (https://github.com/ComponentFactory/Krypton/blob/master/LICENSE)
'  © Component Factory Pty Ltd, 2006 - 2016, (Version 4.5.0.0) All rights reserved.
'
'  New BSD 3-Clause License (https://github.com/Krypton-Suite/Standard-Toolkit/blob/master/LICENSE)
'  Modifications by Peter Wagner(aka Wagnerp) & Simon Coghlan(aka Smurf-IV), et al. 2017 - 2024. All rights reserved.
'
' VB.NET twin of Source\Krypton Ribbon Examples\Ribbon Gallery\Form1.cs (Bastion Phase 4c).
#End Region

Imports System
Imports System.Windows.Forms

Imports Krypton.Ribbon
Imports Krypton.Toolkit

Public Class Form1

    Private Sub galleryCustom_GalleryDropMenu(sender As Object, e As GalleryDropMenuEventArgs) Handles galleryCustom.GalleryDropMenu
        Dim h As New KryptonContextMenuHeading With {
            .Text = "Customize Drop Menu"
        }

        Dim items1 As New KryptonContextMenuItems()
        Dim item1 As New KryptonContextMenuItem With {
            .Text = "Custom Entry 1"
        }
        Dim item2 As New KryptonContextMenuItem With {
            .Text = "Custom Entry 2",
            .Checked = True
        }
        items1.Items.Add(item1)
        items1.Items.Add(item2)

        Dim items2 As New KryptonContextMenuItems()
        Dim item3 As New KryptonContextMenuItem With {
            .Text = "Custom Entry 3"
        }
        Dim item4 As New KryptonContextMenuItem With {
            .Text = "Custom Entry 4",
            .CheckState = CheckState.Indeterminate
        }
        items2.Items.Add(item3)
        items2.Items.Add(item4)

        e.KryptonContextMenu.Items.Insert(0, New KryptonContextMenuSeparator())
        e.KryptonContextMenu.Items.Insert(0, items1)
        e.KryptonContextMenu.Items.Insert(0, h)
        e.KryptonContextMenu.Items.Add(New KryptonContextMenuSeparator())
        e.KryptonContextMenu.Items.Add(items2)
    End Sub

    Private Sub kryptonRibbonGroupButton1_Click(sender As Object, e As EventArgs) Handles kryptonRibbonGroupButton1.Click
        If kryptonRibbonGroupButton1.Checked Then
            kryptonManager1.GlobalPaletteMode = PaletteMode.Office2010Blue
            kryptonRibbonGroupButton2.Checked = False
            kryptonRibbonGroupButton3.Checked = False
        End If
    End Sub

    Private Sub kryptonRibbonGroupButton2_Click(sender As Object, e As EventArgs) Handles kryptonRibbonGroupButton2.Click
        If kryptonRibbonGroupButton2.Checked Then
            kryptonManager1.GlobalPaletteMode = PaletteMode.Office2007Silver
            kryptonRibbonGroupButton1.Checked = False
            kryptonRibbonGroupButton3.Checked = False
        End If
    End Sub

    Private Sub kryptonRibbonGroupButton3_Click(sender As Object, e As EventArgs) Handles kryptonRibbonGroupButton3.Click
        If kryptonRibbonGroupButton3.Checked Then
            kryptonManager1.GlobalPaletteMode = PaletteMode.SparkleOrange
            kryptonRibbonGroupButton1.Checked = False
            kryptonRibbonGroupButton2.Checked = False
        End If
    End Sub

    Private Sub kryptonContextMenuItem1_Click(sender As Object, e As EventArgs) Handles kryptonContextMenuItem1.Click
        Close()
    End Sub

End Class
