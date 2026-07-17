' Original BSD 3-Clause License (https://github.com/ComponentFactory/Krypton/blob/master/LICENSE)
'  © Component Factory Pty Ltd, 2006 - 2016, (Version 4.5.0.0) All rights reserved.
'
'  New BSD 3-Clause License (https://github.com/Krypton-Suite/Standard-Toolkit/blob/master/LICENSE)
'  Modifications by Peter Wagner(aka Wagnerp) & Simon Coghlan(aka Smurf-IV), et al. 2017 - 2024. All rights reserved.
'
' VB.NET twin of Source\Krypton Toolkit Examples\KryptonInputBox Examples\Form1.cs (Bastion Phase 4c).

Imports System.Drawing
Imports System.Windows.Forms

Imports Krypton.Toolkit

Public Class Form1

    Private _cueTypeface As Font

    Public Sub New()
        InitializeComponent()

        _cueTypeface = New Font("Microsoft Sans Serif", 8.0!)
    End Sub

    Private Sub kbtnCueTypeface_Click(sender As Object, e As EventArgs) Handles kbtnCueTypeface.Click
        Dim cueTypeface As New KryptonFontDialog()

        If cueTypeface.ShowDialog() = DialogResult.OK Then
            _cueTypeface = cueTypeface.Font
        End If
    End Sub

    Private Sub kbtnShow_Click(sender As Object, e As EventArgs) Handles kbtnShow.Click
        Dim data As New KryptonInputBoxData() With {
            .Caption = ktxtCaptionText.Text,
            .CueColor = kcbCueTextColour.SelectedColor,
            .CueText = ktxtCueText.Text,
            .CueTypeface = _cueTypeface,
            .DefaultResponse = ktxtDefaultResponseText.Text,
            .Owner = Me,
            .Prompt = ktxtPromptText.Text,
            .UsePasswordOption = kchkUsePasswordOption.Checked
        }

        Dim res = KryptonInputBox.Show(data)
        KryptonMessageBox.Show(Me, res, "Result was :")
    End Sub

    Private Sub Form1_Load(sender As Object, e As EventArgs) Handles MyBase.Load

    End Sub

End Class
