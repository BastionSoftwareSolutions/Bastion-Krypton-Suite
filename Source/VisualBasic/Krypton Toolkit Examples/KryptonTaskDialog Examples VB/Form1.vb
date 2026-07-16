#Region "BSD License"
'
' Original BSD 3-Clause License (https://github.com/ComponentFactory/Krypton/blob/master/LICENSE)
'  © Component Factory Pty Ltd, 2006 - 2016, (Version 4.5.0.0) All rights reserved.
'
'  New BSD 3-Clause License (https://github.com/Krypton-Suite/Standard-Toolkit/blob/master/LICENSE)
'  Modifications by Peter Wagner(aka Wagnerp) & Simon Coghlan(aka Smurf-IV), et al. 2017 - 2024. All rights reserved.
'
' VB.NET twin of Source\Krypton Toolkit Examples\KryptonTaskDialog Examples\Form1.cs (Bastion Phase 4c).
#End Region

Imports System
Imports System.Text
Imports System.Windows.Forms

Imports Krypton.Toolkit

Public Class Form1

    Private Sub Form1_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        comboBoxIcon.Text = "Information"
        comboBoxFooterIcon.Text = "Warning"
    End Sub

    Private Sub palette2010Blue_CheckedChanged(sender As Object, e As EventArgs) Handles palette2010Blue.CheckedChanged
        kryptonManager.GlobalPaletteMode = PaletteMode.Office2010Blue
    End Sub

    Private Sub palette2010Silver_CheckedChanged(sender As Object, e As EventArgs) Handles palette2010Silver.CheckedChanged
        kryptonManager.GlobalPaletteMode = PaletteMode.Office2010Silver
    End Sub

    Private Sub palette2010Black_CheckedChanged(sender As Object, e As EventArgs) Handles palette2010Black.CheckedChanged
        kryptonManager.GlobalPaletteMode = PaletteMode.Office2010Black
    End Sub

    Private Sub palette2007Blue_CheckedChanged(sender As Object, e As EventArgs) Handles palette2007Blue.CheckedChanged
        kryptonManager.GlobalPaletteMode = PaletteMode.Office2007Blue
    End Sub

    Private Sub paletteSparkleOrange_CheckedChanged(sender As Object, e As EventArgs) Handles paletteSparkleOrange.CheckedChanged
        kryptonManager.GlobalPaletteMode = PaletteMode.SparkleOrange
    End Sub

    Private Sub paletteProfessional_CheckedChanged(sender As Object, e As EventArgs) Handles paletteProfessional.CheckedChanged
        kryptonManager.GlobalPaletteMode = PaletteMode.ProfessionalSystem
    End Sub

    Private Sub buttonShowTaskDialog_Click(sender As Object, e As EventArgs) Handles buttonShowTaskDialog.Click
        ' Bastion: ported from the pre-v105 component-based KryptonTaskDialog API
        ' (KryptonTaskDialogCommand, TaskDialogButtons) to the element-based
        ' KryptonTaskDialog shipped by the current core toolkit.
        Dim commonButtons = KryptonTaskDialogCommonButtonTypes.None
        If checkBoxOK.Checked Then
            commonButtons = commonButtons Or KryptonTaskDialogCommonButtonTypes.OK
        End If

        If checkBoxYes.Checked Then
            commonButtons = commonButtons Or KryptonTaskDialogCommonButtonTypes.Yes
        End If

        If checkBoxNo.Checked Then
            commonButtons = commonButtons Or KryptonTaskDialogCommonButtonTypes.No
        End If

        If checkBoxCancel.Checked Then
            commonButtons = commonButtons Or KryptonTaskDialogCommonButtonTypes.Cancel
        End If

        If checkBoxClose.Checked Then
            ' The element-based dialog has no separate Close button; Cancel is the nearest equivalent.
            commonButtons = commonButtons Or KryptonTaskDialogCommonButtonTypes.Cancel
        End If

        If checkBoxRetry.Checked Then
            commonButtons = commonButtons Or KryptonTaskDialogCommonButtonTypes.Retry
        End If

        Using taskDialog As New KryptonTaskDialog()
            taskDialog.HideAllElements()

            taskDialog.Dialog.Form.Text = textBoxCaption.Text

            taskDialog.Heading.Text = textBoxMainInstructions.Text
            taskDialog.Heading.IconType = MapIcon(comboBoxIcon.Text)
            taskDialog.Heading.Visible = True

            taskDialog.Content.Text = textBoxContent.Text
            taskDialog.Content.Visible = textBoxContent.Text.Length > 0

            If checkBoxRadioButtons.Checked Then
                ' The radio button group of the old API is presented as a combo box selection.
                taskDialog.ComboBox.Items.Clear()
                taskDialog.ComboBox.Items.AddRange(New Object() {"First button", "Second option", "Third option"})
                taskDialog.ComboBox.Visible = True
            End If

            If checkBoxCommandButtons.Checked Then
                taskDialog.CommandLinkButtons.Buttons.Clear()
                For Each commandText In New String() {"Command One", "Command Two", "Command Three"}
                    Dim commandButton As New KryptonCommandLinkButton With {
                        .Text = commandText,
                        .DialogResult = DialogResult.OK
                    }
                    taskDialog.CommandLinkButtons.Buttons.Add(commandButton)
                Next

                taskDialog.CommandLinkButtons.Visible = True
            End If

            If Not String.IsNullOrEmpty(textBoxCheckBoxText.Text) Then
                taskDialog.CheckBox.Text = textBoxCheckBoxText.Text
                taskDialog.CheckBox.Checked = checkBoxInitialState.Checked
                taskDialog.CheckBox.Visible = True
            End If

            If Not String.IsNullOrEmpty(textBoxFooterHyperlink.Text) Then
                taskDialog.HyperLink.Url = textBoxFooterHyperlink.Text
                taskDialog.HyperLink.Visible = True
            End If

            taskDialog.FooterBar.CommonButtons.Buttons = commonButtons
            taskDialog.FooterBar.Footer.FootNoteText = textBoxFooterText.Text
            taskDialog.FooterBar.Footer.IconType = MapIcon(comboBoxFooterIcon.Text)
            taskDialog.FooterBar.Visible = True

            taskDialog.ShowDialog(Me)
        End Using
    End Sub

    ''' <summary>Maps the old KryptonMessageBoxIcon names shown in the UI onto the new icon set.</summary>
    Private Shared Function MapIcon(iconName As String) As KryptonTaskDialogIconType
        Select Case iconName
            Case "Information"
                Return KryptonTaskDialogIconType.ShieldInformation
            Case "Warning"
                Return KryptonTaskDialogIconType.ShieldWarning
            Case "Error", "Stop", "Hand"
                Return KryptonTaskDialogIconType.ShieldError
            Case "Question"
                Return KryptonTaskDialogIconType.ShieldHelp
            Case "Shield"
                Return KryptonTaskDialogIconType.ShieldUac
            Case "None"
                Return KryptonTaskDialogIconType.None
            Case Else
                Return KryptonTaskDialogIconType.ShieldKrypton
        End Select
    End Function

    Private Sub buttonFill_Click(sender As Object, e As EventArgs) Handles buttonFill.Click
        Dim s = "The quick brown fox jumps over the lazy dog"
        Dim e1 = New Random().Next(50, 400)
        Dim sb = New StringBuilder().Append(s)
        For i = 0 To e1 - 1
            sb.AppendFormat(vbCrLf & vbCrLf & "{0}", s)
            If i Mod 10 = 0 Then
                Dim e2 = New Random().Next(1, 10)
                For j = 0 To e2 - 1
                    sb.AppendFormat(". {0}", s)
                Next

                sb.Append(vbCrLf)
            End If
        Next
        textBoxContent.Text = sb.ToString()
    End Sub

End Class
