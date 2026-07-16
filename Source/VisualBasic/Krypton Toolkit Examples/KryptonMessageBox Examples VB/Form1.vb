#Region "BSD License"
'
' Original BSD 3-Clause License (https://github.com/ComponentFactory/Krypton/blob/master/LICENSE)
'  © Component Factory Pty Ltd, 2006 - 2016, (Version 4.5.0.0) All rights reserved.
'
'  New BSD 3-Clause License (https://github.com/Krypton-Suite/Standard-Toolkit/blob/master/LICENSE)
'  Modifications by Peter Wagner(aka Wagnerp) & Simon Coghlan(aka Smurf-IV), tobitege et al. 2017 - 2025. All rights reserved.
'
' VB.NET twin of Source\Krypton Toolkit Examples\KryptonMessageBox Examples\Form1.cs (Bastion Phase 4c).
#End Region

Imports System
Imports System.Drawing
Imports System.Windows.Forms

Imports Krypton.Toolkit

Public Class Form1

    Private Const SEED_TEXT As String =
        "// *****************************************************************************" & vbCrLf &
        "// BSD 3-Clause License (https://github.com/ComponentFactory/Krypton/blob/master/LICENSE)" & vbCrLf &
        "//  © Component Factory Pty Ltd, 2006-2016, All rights reserved." & vbCrLf &
        "// The software and associated documentation supplied hereunder are the " & vbCrLf &
        "//  proprietary information of Component Factory Pty Ltd, 13 Swallows Close, " & vbCrLf &
        "//  Mornington, Vic 3931, Australia and are supplied subject to licence terms." & vbCrLf &
        "// " & vbCrLf &
        "//  Modifications by Peter Wagner(aka Wagnerp) & Simon Coghlan(aka Smurf-IV) 2017 - 2024. All rights reserved. (https://github.com/Krypton-Suite/Standard-Toolkit)" & vbCrLf &
        "//  Version 4.7.0.0  www.ComponentFactory.com" & vbCrLf &
        "// *****************************************************************************" & vbCrLf

    Private _mbIcon As MessageBoxIcon = MessageBoxIcon.Warning
    Private _kmbIcon As KryptonMessageBoxIcon = KryptonMessageBoxIcon.Warning
    Private _mbButtons As KryptonMessageBoxButtons = KryptonMessageBoxButtons.OKCancel
    Private _options As MessageBoxOptions = CType(0, MessageBoxOptions)

    Public Sub New()
        InitializeComponent()

        ' Handle the HelpRequested event for the following message.
        AddHandler HelpRequested, AddressOf Form1_HelpRequested   ' https://github.com/Krypton-Suite/Standard-Toolkit/issues/868
    End Sub

    Private Sub icon_CheckedChanged(sender As Object, e As EventArgs) Handles radioButtonNone.CheckedChanged,
        rbShield.CheckedChanged, kradWinLogo.CheckedChanged, kradQuestion.CheckedChanged,
        kradError.CheckedChanged, kradInformation.CheckedChanged, kradWarning.CheckedChanged
        If radioButtonNone.Checked Then
            _mbIcon = MessageBoxIcon.None
            _kmbIcon = KryptonMessageBoxIcon.None
        ElseIf kradError.Checked Then
            _mbIcon = MessageBoxIcon.Error
            _kmbIcon = KryptonMessageBoxIcon.Error
        ElseIf kradQuestion.Checked Then
            _mbIcon = MessageBoxIcon.Question
            _kmbIcon = KryptonMessageBoxIcon.Question
        ElseIf kradWarning.Checked Then
            _mbIcon = MessageBoxIcon.Warning
            _kmbIcon = KryptonMessageBoxIcon.Warning
        ElseIf kradInformation.Checked Then
            _mbIcon = MessageBoxIcon.Information
            _kmbIcon = KryptonMessageBoxIcon.Information
        ElseIf rbShield.Checked Then
            _mbIcon = MessageBoxIcon.None
            _kmbIcon = KryptonMessageBoxIcon.Shield
        ElseIf Not kradWinLogo.Checked Then
            _mbIcon = MessageBoxIcon.None
            _kmbIcon = KryptonMessageBoxIcon.WindowsLogo
        End If
    End Sub

    Private Sub buttons_CheckedChanged(sender As Object, e As EventArgs) Handles kradYesNo.CheckedChanged,
        kradCancelTryContinue.CheckedChanged, kradRetryCancel.CheckedChanged, kradOK.CheckedChanged,
        kradYesNoCancel.CheckedChanged, kradAbortRetryIgnore.CheckedChanged, kradOKCancel.CheckedChanged
        If kradOK.Checked Then
            _mbButtons = KryptonMessageBoxButtons.OK
        ElseIf kradOKCancel.Checked Then
            _mbButtons = KryptonMessageBoxButtons.OKCancel
        ElseIf kradRetryCancel.Checked Then
            _mbButtons = KryptonMessageBoxButtons.RetryCancel
        ElseIf kradAbortRetryIgnore.Checked Then
            _mbButtons = KryptonMessageBoxButtons.AbortRetryIgnore
        ElseIf kradYesNo.Checked Then
            _mbButtons = KryptonMessageBoxButtons.YesNo
        ElseIf kradYesNoCancel.Checked Then
            _mbButtons = KryptonMessageBoxButtons.YesNoCancel
        ElseIf kradCancelTryContinue.Checked Then
            _mbButtons = KryptonMessageBoxButtons.CancelTryContinue
        End If
    End Sub

    Private Sub ChkRightAlign_CheckedChanged(sender As Object, e As EventArgs) Handles MyBase.Click
        If kchkRightAlign.Checked Then
            _options = _options Or MessageBoxOptions.RightAlign
        Else
            _options = _options And Not MessageBoxOptions.RightAlign
        End If
    End Sub

    Private Sub ChkRtlReading_CheckedChanged(sender As Object, e As EventArgs) Handles kchkRtlReading.Click
        If kchkRtlReading.Checked Then
            _options = _options Or MessageBoxOptions.RtlReading
        Else
            _options = _options And Not MessageBoxOptions.RtlReading
        End If
    End Sub

    Private Sub kbtnShow_Click(sender As Object, e As EventArgs) Handles kbtnShow.Click
        ' Bastion: the C# twin excludes CancelTryContinue from the WinForms MessageBox call with an
        ' inline #if !NET6_0_OR_GREATER inside the condition; VB #If blocks are line based, so the
        ' same condition is built up here instead.
        Dim showWinFormsMessageBox As Boolean = Not kradWinLogo.Checked AndAlso Not rbShield.Checked
#If Not NET6_0_OR_GREATER Then
        showWinFormsMessageBox = showWinFormsMessageBox AndAlso Not kradCancelTryContinue.Checked
#End If

        If showWinFormsMessageBox Then
            If chkShowHelp.Checked Then
                MessageBox.Show(textBoxMessage.Text, textBoxCaption.Text,
                    CType(_mbButtons, MessageBoxButtons),
                    _mbIcon, MessageBoxDefaultButton.Button1,
                    _options,
                    chkShowHelp.Checked)
            Else
                MessageBox.Show(Me, textBoxMessage.Text, textBoxCaption.Text,
                    CType(_mbButtons, MessageBoxButtons),
                    _mbIcon, MessageBoxDefaultButton.Button1,
                    _options)
            End If
        End If

        Dim res = KryptonMessageBox.Show(Me, textBoxMessage.Text, textBoxCaption.Text,
                    _mbButtons,
                    displayHelpButton:=chkShowHelp.Checked,
                    _kmbIcon, KryptonMessageBoxDefaultButton.Button1,
                    options:=_options)

        textBoxMessage.Text = $"Krypton DialogResult = {res}"
    End Sub

    ''' <summary>
    ''' Based on code from https://learn.microsoft.com/en-us/dotnet/api/system.windows.forms.messagebox.show?view=windowsdesktop-7.0#system-windows-forms-messagebox-show(system-string-system-string-system-windows-forms-messageboxbuttons-system-windows-forms-messageboxicon-system-windows-forms-messageboxdefaultbutton-system-windows-forms-messageboxoptions-system-boolean)
    ''' </summary>
    ''' <param name="sender"></param>
    ''' <param name="hlpEvent"></param>
    Private Sub Form1_HelpRequested(sender As Object, hlpEvent As HelpEventArgs)
        ' Create a custom Help window in response to the HelpRequested event.
        Using helpForm As New Form With {
            .StartPosition = FormStartPosition.Manual,
            .Size = New Size(200, 400),
            .DesktopLocation = New Point(DesktopBounds.X + Size.Width, DesktopBounds.Top),
            .Text = "Help Form"
        }
            ' Create a label to contain the Help text.
            Dim helpLabel As New Label()

            ' Add the label to the form and set its text.
            helpForm.Controls.Add(helpLabel)
            helpLabel.Dock = DockStyle.Fill

            If sender IsNot Nothing Then
                ' Use the sender parameter to identify the context of the Help request.
                ' The parameter must be cast to the Control type to get the Tag property.
                Dim senderControl As Control = CType(sender, Control)

                helpLabel.Text = $"Help information shown in response to user action on the '{CStr(senderControl.Tag)}' message."
            End If

            ' Set the Help form to be owned by the main form. This helps
            ' to ensure that the Help form is disposed of.
            AddOwnedForm(helpForm)

            ' Show the custom Help window.
            helpForm.Show()

            ' Indicate that the HelpRequested event is handled.
            hlpEvent.Handled = True
        End Using
    End Sub

    Private Sub Form1_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        For Each value As String In [Enum].GetNames(GetType(KryptonMessageBoxIcon))
            kcmbIcons.Items.Add(value)
        Next
    End Sub

    Private Sub kcmbIcons_SelectedIndexChanged(sender As Object, e As EventArgs) Handles kcmbIcons.SelectedIndexChanged
        _kmbIcon = CType([Enum].Parse(GetType(KryptonMessageBoxIcon), kcmbIcons.Text), KryptonMessageBoxIcon)
    End Sub

    Private Sub kbtnDummyText_Click(sender As Object, e As EventArgs) Handles kbtnDummyText.Click
        textBoxMessage.Text = String.Empty

        textBoxMessage.Text = SEED_TEXT
    End Sub

End Class
