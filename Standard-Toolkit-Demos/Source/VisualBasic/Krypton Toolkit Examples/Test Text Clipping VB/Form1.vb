' *****************************************************************************
' BSD 3-Clause License (https://github.com/Krypton-Suite/Standard-Toolkit)
'  By Peter Wagner(aka Wagnerp) & Simon Coghlan(aka Smurf-IV) 2017 - 2024. All rights reserved.
' *****************************************************************************
' VB.NET twin of Source\Krypton Toolkit Examples\Test Text Clipping\Form1.cs (Bastion Phase 4c).

Imports System.Windows.Forms

Imports Krypton.Toolkit

Public Class Form1

    Public Sub New()
        InitializeComponent()
    End Sub

    Private Sub kryptonOffice2010Blue_CheckedChanged(sender As Object, e As EventArgs) Handles kryptonOffice2010Blue.CheckedChanged
        If kryptonOffice2010Blue.Checked Then
            kryptonManager.GlobalPaletteMode = PaletteMode.Office2010Blue
        End If
    End Sub

    Private Sub kryptonOffice2010Silver_CheckedChanged(sender As Object, e As EventArgs) Handles kryptonOffice2010Silver.CheckedChanged
        If kryptonOffice2010Silver.Checked Then
            kryptonManager.GlobalPaletteMode = PaletteMode.Office2010Silver
        End If
    End Sub

    Private Sub kryptonOffice2010Black_CheckedChanged(sender As Object, e As EventArgs) Handles kryptonOffice2010Black.CheckedChanged
        If kryptonOffice2010Black.Checked Then
            kryptonManager.GlobalPaletteMode = PaletteMode.Office2010Black
        End If
    End Sub

    Private Sub kryptonOffice2007Blue_CheckedChanged(sender As Object, e As EventArgs) Handles kryptonOffice2007Blue.CheckedChanged
        If kryptonOffice2007Blue.Checked Then
            kryptonManager.GlobalPaletteMode = PaletteMode.Office2007Blue
        End If
    End Sub

    Private Sub kryptonOffice2007Silver_CheckedChanged(sender As Object, e As EventArgs) Handles kryptonOffice2007Silver.CheckedChanged
        If kryptonOffice2007Silver.Checked Then
            kryptonManager.GlobalPaletteMode = PaletteMode.Office2007Silver
        End If
    End Sub

    Private Sub kryptonOffice2007Black_CheckedChanged(sender As Object, e As EventArgs) Handles kryptonOffice2007Black.CheckedChanged
        If kryptonOffice2007Black.Checked Then
            kryptonManager.GlobalPaletteMode = PaletteMode.Office2007Black
        End If
    End Sub

    Private Sub kryptonOffice2003_CheckedChanged(sender As Object, e As EventArgs) Handles kryptonOffice2003.CheckedChanged
        If kryptonOffice2003.Checked Then
            kryptonManager.GlobalPaletteMode = PaletteMode.ProfessionalOffice2003
        End If
    End Sub

    Private Sub kryptonSystem_CheckedChanged(sender As Object, e As EventArgs) Handles kryptonSystem.CheckedChanged
        If kryptonSystem.Checked Then
            kryptonManager.GlobalPaletteMode = PaletteMode.ProfessionalSystem
        End If
    End Sub

    Private Sub kryptonSparkleBlue_CheckedChanged(sender As Object, e As EventArgs) Handles kryptonSparkleBlue.CheckedChanged
        If kryptonSparkleBlue.Checked Then
            kryptonManager.GlobalPaletteMode = PaletteMode.SparkleBlue
        End If
    End Sub

    Private Sub kryptonSparkleOrange_CheckedChanged(sender As Object, e As EventArgs) Handles kryptonSparkleOrange.CheckedChanged
        If kryptonSparkleOrange.Checked Then
            kryptonManager.GlobalPaletteMode = PaletteMode.SparkleOrange
        End If
    End Sub

    Private Sub kryptonSparklePurple_CheckedChanged(sender As Object, e As EventArgs) Handles kryptonSparklePurple.CheckedChanged
        If kryptonSparklePurple.Checked Then
            kryptonManager.GlobalPaletteMode = PaletteMode.SparklePurple
        End If
    End Sub

    Private Sub kryptonCustom_CheckedChanged(sender As Object, e As EventArgs) Handles kryptonCustom.CheckedChanged
        If kryptonCustom.Checked Then
            kryptonManager.GlobalCustomPalette = kryptonPaletteCustom
        End If
    End Sub

    ' Overloads: Control exposes overridable OnClick/OnMouseClick with different
    ' signatures; in C# these coexist silently, VB needs the keyword.
    Private Overloads Sub OnClick(sender As Object, e As EventArgs) Handles kryptonButton1.Click, kryptonButton2.Click, kryptonCheckBox1.Click, kryptonCheckBox2.Click, kryptonCheckedListBox1.Click, kryptonCheckedListBox2.Click, kryptonHeader1.Click, kryptonHeader2.Click, kryptonHeaderGroupDetails.Click, kryptonLabel1.Click, kryptonLabel2.Click, kryptonTextBox1.Click, kryptonTextBox2.Click, kryptonTreeView1.Click, kryptonTreeView2.Click, kryptonWrapLabel1.Click, kryptonWrapLabel2.Click
        KryptonMessageBox.Show(Me, CType(sender, Control).Name, "Single click detected on ...")
    End Sub

    Private Overloads Sub OnMouseClick(sender As Object, e As MouseEventArgs) Handles kryptonTextBox1.MouseClick
        KryptonMessageBox.Show(Me, CType(sender, Control).Name, "Mouse click detected on ...")
    End Sub

    Private Sub kryptonOffice2013White_CheckedChanged(sender As Object, e As EventArgs) Handles kryptonOffice2013White.CheckedChanged
        If kryptonOffice2013White.Checked Then
            kryptonManager.GlobalPaletteMode = PaletteMode.Office2013White
        End If
    End Sub

    Private Sub InnerControl_MouseEnter(sender As Object, e As EventArgs) Handles kryptonButton2.MouseEnter, kryptonCheckBox2.MouseEnter, kryptonCheckedListBox1.TrackMouseEnter, kryptonCheckedListBox2.TrackMouseEnter, kryptonTextBox2.TrackMouseEnter, kryptonTreeView2.TrackMouseEnter
        kryptonListBox1.Items.Add($"MouseEnter- {sender}")
    End Sub

    Private Sub InnerControl_MouseLeave(sender As Object, e As EventArgs) Handles kryptonButton2.MouseLeave, kryptonCheckBox2.MouseLeave, kryptonCheckedListBox1.TrackMouseLeave, kryptonCheckedListBox2.TrackMouseLeave, kryptonTextBox2.TrackMouseLeave, kryptonTreeView2.TrackMouseLeave
        kryptonListBox1.Items.Add("MouseLeave")
    End Sub

End Class
