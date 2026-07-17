#Region "BSD License"
'
' Original BSD 3-Clause License (https://github.com/ComponentFactory/Krypton/blob/master/LICENSE)
'  © Component Factory Pty Ltd, 2006 - 2016, (Version 4.5.0.0) All rights reserved.
'
'  New BSD 3-Clause License (https://github.com/Krypton-Suite/Standard-Toolkit/blob/master/LICENSE)
'  Modifications by Peter Wagner(aka Wagnerp) & Simon Coghlan(aka Smurf-IV), et al. 2017 - 2024. All rights reserved.
'
' VB.NET twin of Source\Krypton Ribbon Examples\KryptonGallery Examples\Form1.cs (Bastion Phase 4c).
#End Region

Imports System
Imports System.Drawing
Imports System.Windows.Forms

Imports Krypton.Ribbon
Imports Krypton.Toolkit

Public Class Form1

    Private Sub radioSmallList_CheckedChanged(sender As Object, e As EventArgs) Handles radioSmallList.CheckedChanged
        If radioSmallList.Checked Then
            kryptonGallery1.ImageList = imageListSmall
        End If
    End Sub

    Private Sub radioMediumList_CheckedChanged(sender As Object, e As EventArgs) Handles radioMediumList.CheckedChanged
        If radioMediumList.Checked Then
            kryptonGallery1.ImageList = imageListMedium
        End If
    End Sub

    Private Sub radioLargeList_CheckedChanged(sender As Object, e As EventArgs) Handles radioLargeList.CheckedChanged
        If radioLargeList.Checked Then
            kryptonGallery1.ImageList = imageListLarge
        End If
    End Sub

    ' NOTE: the C# twin uses a `with` expression on the Size struct; VB has no
    ' equivalent, so the new Size is constructed explicitly.
    Private Sub numericWidth_ValueChanged(sender As Object, e As EventArgs) Handles numericWidth.ValueChanged
        kryptonGallery1.PreferredItemSize = New Size(Convert.ToInt32(numericWidth.Value), kryptonGallery1.PreferredItemSize.Height)
    End Sub

    Private Sub numericHeight_ValueChanged(sender As Object, e As EventArgs) Handles numericHeight.ValueChanged
        kryptonGallery1.PreferredItemSize = New Size(kryptonGallery1.PreferredItemSize.Width, Convert.ToInt32(numericHeight.Value))
    End Sub

    Private Sub checkBoxGroupImages_CheckedChanged(sender As Object, e As EventArgs) Handles checkBoxGroupImages.CheckedChanged
        kryptonGallery1.DropButtonRanges.Clear()
        If checkBoxGroupImages.Checked Then
            kryptonGallery1.DropButtonRanges.Add(kryptonGalleryRange1)
            kryptonGallery1.DropButtonRanges.Add(kryptonGalleryRange2)
            kryptonGallery1.DropButtonRanges.Add(kryptonGalleryRange3)
        End If
    End Sub

    Private Sub kryptonGallery1_GalleryDropMenu(sender As Object, e As GalleryDropMenuEventArgs) Handles kryptonGallery1.GalleryDropMenu
        If checkBoxAddCustomItems.Checked Then
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
        End If
    End Sub

    Private Sub buttonClose_Click(sender As Object, e As EventArgs) Handles buttonClose.Click
        Close()
    End Sub

End Class
