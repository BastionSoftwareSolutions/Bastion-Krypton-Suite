' *****************************************************************************
' BSD 3-Clause License (https://github.com/Krypton-Suite/Standard-Toolkit)
'  By Peter Wagner(aka Wagnerp) & Simon Coghlan(aka Smurf-IV), tobitege 2017 - 2025. All rights reserved.
' *****************************************************************************
' VB.NET twin of Source\Krypton Toolkit Examples\Test MessageBox Clipping\Form1.cs (Bastion Phase 4c).

Imports System.Windows.Forms

Imports Krypton.Toolkit

Public Class Form1

    Private Const SEED_TEXT As String =
        "// *****************************************************************************
// BSD 3-Clause License (https://github.com/ComponentFactory/Krypton/blob/master/LICENSE)
//  © Component Factory Pty Ltd, 2006-2016, All rights reserved.
// The software and associated documentation supplied hereunder are the
//  proprietary information of Component Factory Pty Ltd, 13 Swallows Close,
//  Mornington, Vic 3931, Australia and are supplied subject to licence terms.
//
//  Modifications by Peter Wagner(aka Wagnerp) & Simon Coghlan(aka Smurf-IV), tobitege et al. 2017 - 2025. All rights reserved. (https://github.com/Krypton-Suite/Standard-Toolkit)
//  Version 4.7.0.0  www.ComponentFactory.com
// *****************************************************************************
"

    Public Sub New()
        InitializeComponent()
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

    Private Sub kryptonCustom_CheckedChanged(sender As Object, e As EventArgs) Handles kryptonCustom.CheckedChanged
        If kryptonCustom.Checked Then
            kryptonManager.GlobalCustomPalette = kryptonPaletteCustom
        End If
    End Sub

    Private Sub kryptonOffice2013White_CheckedChanged(sender As Object, e As EventArgs) Handles kryptonOffice2013White.CheckedChanged
        If kryptonOffice2013White.Checked Then
            kryptonManager.GlobalPaletteMode = PaletteMode.Office2013White
        End If
    End Sub

    Private Sub btnSingleLines_Click(sender As Object, e As EventArgs) Handles btnSingleLines.Click
        Dim localText As String = SEED_TEXT.Replace(Environment.NewLine, "")
        MessageBox.Show(Me, localText & localText, localText)
        KryptonMessageBox.Show(Me, localText & localText, localText)
    End Sub

    Private Sub btnCarriageReturns_Click(sender As Object, e As EventArgs) Handles btnCarriageReturns.Click
        Dim localText As String = SEED_TEXT
        MessageBox.Show(Me, localText & localText, localText)
        KryptonMessageBox.Show(Me, localText & localText, localText)
    End Sub

    Private Sub btnStackTrace_Click(sender As Object, e As EventArgs) Handles btnStackTrace.Click
        Try
            InfiniteLoopIt(1)
        Catch ex As Exception
            MessageBox.Show(Me, ex.StackTrace, ex.Message)
            KryptonMessageBox.Show(Me, ex.StackTrace, ex.Message)
            ' Bastion: ported to the element-based KryptonTaskDialog API of the current core toolkit
            ' (the static KryptonTaskDialog.Show overload no longer exists).
            Using taskDialog As New KryptonTaskDialog()
                taskDialog.Dialog.Form.Text = ex.Message
                taskDialog.Heading.Text = "MinInstruction"
                taskDialog.Heading.IconType = KryptonTaskDialogIconType.ShieldError
                taskDialog.Heading.Visible = True
                taskDialog.Content.Text = ex.StackTrace
                taskDialog.Content.Visible = True
                taskDialog.FooterBar.CommonButtons.Buttons = KryptonTaskDialogCommonButtonTypes.Cancel
                taskDialog.FooterBar.CommonButtons.CancelButton = KryptonTaskDialogCommonButtonTypes.Cancel
                taskDialog.FooterBar.Visible = True
                taskDialog.ShowDialog(Me)
            End Using
        End Try
    End Sub

    ' The C# twin declares this as a local function inside btnStackTrace_Click;
    ' VB has no local functions, so the nearest idiomatic shape is a private helper.
    Private Sub InfiniteLoopIt(howDeep As Integer)
        If howDeep > 50 Then
            Throw New InsufficientExecutionStackException()
        End If

        howDeep += 1
        InfiniteLoopIt(howDeep)
    End Sub

    Private Sub btnLongTitle_Click(sender As Object, e As EventArgs) Handles btnLongTitle.Click
        Try
            Throw New InsufficientExecutionStackException()
        Catch ex As Exception
            MessageBox.Show(Me, "ex.StackTrace", ex.Message)
            KryptonMessageBox.Show(Me, "ex.StackTrace", ex.Message)
        End Try
    End Sub

    Private Sub btnLongContents_Click(sender As Object, e As EventArgs) Handles btnLongContents.Click
        Try
            Throw New InsufficientExecutionStackException()
        Catch ex As Exception
            MessageBox.Show(Me, ex.StackTrace, "ex.Message", MessageBoxButtons.OK, MessageBoxIcon.Stop)
            KryptonMessageBox.Show(Me, ex.StackTrace, "ex.Message", KryptonMessageBoxButtons.OK, KryptonMessageBoxIcon.Stop)
        End Try
    End Sub

    Private Sub btnLongTitleNoOwner_Click(sender As Object, e As EventArgs) Handles btnLongTitleNoOwner.Click
        Try
            Throw New InsufficientExecutionStackException()
        Catch ex As Exception
            MessageBox.Show("ex.StackTrace", ex.Message)
            KryptonMessageBox.Show("ex.StackTrace", ex.Message)
        End Try
    End Sub

    Private Sub btnLongContentsNoOwner_Click(sender As Object, e As EventArgs) Handles btnLongContentsNoOwner.Click
        Try
            Throw New InsufficientExecutionStackException()
        Catch ex As Exception
            MessageBox.Show(Me, ex.StackTrace, "ex.Message", MessageBoxButtons.OK, MessageBoxIcon.Stop)
            KryptonMessageBox.Show(Me, ex.StackTrace, "ex.Message", KryptonMessageBoxButtons.OK, KryptonMessageBoxIcon.Stop)
        End Try
    End Sub

End Class
