' *****************************************************************************
' BSD 3-Clause License (https://github.com/Krypton-Suite/Standard-Toolkit)
'  By Peter Wagner(aka Wagnerp) & Simon Coghlan(aka Smurf-IV) 2024 - 2024. All rights reserved.
' *****************************************************************************
' VB.NET twin of Source\Krypton Toolkit Examples\KryptonToastNotification Examples\UserInputNotification.cs (Bastion Phase 4c).
' Bastion: the C# twin declares ten additional private fields that are never
' referenced anywhere (CS0169/CS8618 noise); they are intentionally not
' reproduced here.

Imports System
Imports System.Collections
Imports System.Drawing
Imports System.Windows.Forms

Imports Krypton.Toolkit

Public Class UserInputNotification

#Region "Instance Fields"

    ''' <summary>Gets or sets the use fade.</summary>
    Private _useFade As Boolean

    ''' <summary>Gets or sets the top most.</summary>
    Private _topMost As Boolean?

    ''' <summary>Gets or sets the show close box.</summary>
    Private _showCloseBox As Boolean?

    ''' <summary>Gets or sets the show do not show again option.</summary>
    Private _showDoNotShowAgainOption As Boolean?

    ''' <summary>Gets or sets the state of the use do not show again option three.</summary>
    Private _useDoNotShowAgainOptionThreeState As Boolean?

    ''' <summary>Gets or sets the do not show again option checked value.</summary>
    Private _isDoNotShowAgainOptionChecked As Boolean

    ''' <summary>Gets or sets the report toast location. Use this for development purposes only.</summary>
    Private _reportToastLocation As Boolean

    ''' <summary>Gets or sets a value indicating whether [use RTL reading].</summary>
    Private _useRtlReading As Boolean

    ''' <summary>Gets or sets the state of the do not show again option check.</summary>
    Private _doNotShowAgainOptionCheckState As CheckState?

    ''' <summary>Gets or sets the focus on user input area.</summary>
    Private _focusOnUserInputArea As Boolean?

    ''' <summary>Gets or sets the notification title alignment.</summary>
    Private _notificationTitleAlignment As ContentAlignment?

    ''' <summary>Gets or sets the user input ComboBox style.</summary>
    Private _userInputComboBoxStyle As ComboBoxStyle?

    ''' <summary>Gets or sets the first border color.</summary>
    Private _borderColor1 As Color?

    ''' <summary>Gets or sets the second border color.</summary>
    Private _borderColor2 As Color?

    ''' <summary>Gets or sets the minimum date time value.</summary>
    Private _minimumDateTimeValue As DateTime?

    ''' <summary>Gets or sets the maximum date time value.</summary>
    Private _maximumDateTimeValue As DateTime?

    ''' <summary>Gets or sets the initial date time value.</summary>
    Private _initialDateTimeValue As DateTime?

    ''' <summary>Gets or sets the notification content font.</summary>
    Private _notificationContentFont As Font

    ''' <summary>Gets or sets the notification title font.</summary>
    Private _notificationTitleFont As Font

    ''' <summary>Gets or sets the count-down seconds.</summary>
    Private _countDownSeconds As Integer?

    ''' <summary>Gets or sets the count-down timer interval.</summary>
    Private _countDownTimerInterval As Integer?

    ''' <summary>Gets or sets the content of the notification.</summary>
    Private _notificationContent As String

    ''' <summary>Gets or sets the notification title.</summary>
    Private _notificationTitle As String

    ''' <summary>Gets or sets the toast host.</summary>
    Private _toastHost As IWin32Window

    ''' <summary>Gets or sets the notification icon.</summary>
    Private _notificationIcon As KryptonToastNotificationIcon?

    ''' <summary>Gets or sets the type of the notification input area.</summary>
    Private _notificationInputAreaType As KryptonToastNotificationInputAreaType?

    ''' <summary>Gets or sets the toast notification cue text.</summary>
    Private _toastNotificationCueText As String

    ''' <summary>Gets or sets the user input list.</summary>
    Private _userInputList As ArrayList

    ''' <summary>Gets or sets the color of the toast notification cue.</summary>
    Private _toastNotificationCueColor As Color?

    ''' <summary>Gets or sets the drop-down style.</summary>
    Private _dropDownStyle As ComboBoxStyle?

#End Region

#Region "Identity"

    Public Sub New()
        InitializeComponent()

        Setup()
    End Sub

#End Region

#Region "Implementation"

    Private Sub Setup()
        For Each item As Object In [Enum].GetValues(GetType(ComboBoxStyle))
            kcmbDropDownStyle.Items.Add(item)
        Next

        kcmbDropDownStyle.SelectedIndex = 0

        For Each icon As Object In [Enum].GetValues(GetType(KryptonToastNotificationIcon))
            kcmbToastIcon.Items.Add(icon)
        Next

        kcmbToastIcon.SelectedIndex = 0

        For Each value As Object In [Enum].GetValues(GetType(KryptonToastNotificationInputAreaType))
            kcmbNotificationInputStyle.Items.Add(value)
        Next

        For Each state As Object In [Enum].GetValues(GetType(CheckState))
            kcmbDoNotShowAgainOptionCheckState.Items.Add(state)
        Next

        kcmbDoNotShowAgainOptionCheckState.SelectedIndex = 0

        For Each alignment As Object In [Enum].GetValues(GetType(ContentAlignment))
            kcmbNotificationContentAlignment.Items.Add(alignment)

            kcmbNotificationTitleAlignment.Items.Add(alignment)
        Next

        For Each control As Object In Controls
            kcmbOwner.Items.Add(control)
        Next

        kcmbNotificationContentAlignment.SelectedIndex = 0

        kcmbNotificationTitleAlignment.SelectedIndex = 0

        kcmbNotificationInputStyle.SelectedIndex = 0

        kdtpInitialDate.Value = DateTime.Now

        kdtpMaximumDate.Value = DateTime.MaxValue

        kdtpMinimumDate.Value = DateTime.MinValue

        knudXAxis.Maximum = Screen.PrimaryScreen.WorkingArea.Height

        knudYAxis.Maximum = Screen.PrimaryScreen.WorkingArea.Width
    End Sub

    Private Function CreateUserInputList() As ArrayList
        _userInputList = New ArrayList(krtxtItemList.Lines)

        Return _userInputList
    End Function

    Private Function GetLocation() As Point
        Return New Point(Convert.ToInt32(knudXAxis.Value), Convert.ToInt32(knudYAxis.Value))
    End Function

    Private Sub ktxtToastTitle_TextChanged(sender As Object, e As EventArgs) Handles ktxtToastTitle.TextChanged
        _notificationTitle = ktxtToastTitle.Text
    End Sub

    Private Sub ktxtToastContent_TextChanged(sender As Object, e As EventArgs) Handles ktxtToastContent.TextChanged
        _notificationContent = ktxtToastContent.Text
    End Sub

    Private Sub kcmbToastIcon_SelectedIndexChanged(sender As Object, e As EventArgs) Handles kcmbToastIcon.SelectedIndexChanged
        _notificationIcon = CType([Enum].Parse(GetType(KryptonToastNotificationIcon), kcmbToastIcon.Text), KryptonToastNotificationIcon)
    End Sub

    Private Sub kcmbNotificationInputStyle_SelectedIndexChanged(sender As Object, e As EventArgs) Handles kcmbNotificationInputStyle.SelectedIndexChanged
        _notificationInputAreaType = CType([Enum].Parse(GetType(KryptonToastNotificationInputAreaType),
                                                        kcmbNotificationInputStyle.Text), KryptonToastNotificationInputAreaType)
    End Sub

    Private Sub kcmbDropDownStyle_SelectedIndexChanged(sender As Object, e As EventArgs) Handles kcmbDropDownStyle.SelectedIndexChanged
        _dropDownStyle = CType([Enum].Parse(GetType(ComboBoxStyle), kcmbDropDownStyle.Text), ComboBoxStyle)

        _userInputComboBoxStyle = CType([Enum].Parse(GetType(ComboBoxStyle), kcmbDropDownStyle.Text), ComboBoxStyle)
    End Sub

    Private Sub ktxtInputCueText_TextChanged(sender As Object, e As EventArgs) Handles ktxtInputCueText.TextChanged
        _toastNotificationCueText = ktxtInputCueText.Text
    End Sub

    Private Sub kcolCueColor_SelectedColorChanged(sender As Object, e As ColorEventArgs) Handles kcolCueColor.SelectedColorChanged
        _toastNotificationCueColor = kcolCueColor.SelectedColor
    End Sub

    Private Sub krtxtItemList_TextChanged(sender As Object, e As EventArgs) Handles krtxtItemList.TextChanged
        'For Each line As String In krtxtItemList.Lines
        '    _comboBoxItems.Add(line)
        'Next
    End Sub

    Private Sub kchkUseFade_CheckedChanged(sender As Object, e As EventArgs) Handles kchkUseFade.CheckedChanged
        _useFade = kchkUseFade.Checked
    End Sub

    Private Sub kchkShowCloseBox_CheckedChanged(sender As Object, e As EventArgs) Handles kchkShowCloseBox.CheckedChanged
        _showCloseBox = kchkShowCloseBox.Checked
    End Sub

    Private Sub kchkReportLocation_CheckedChanged(sender As Object, e As EventArgs) Handles kchkReportLocation.CheckedChanged
        _reportToastLocation = kchkReportLocation.Checked
    End Sub

    Private Sub knudCountdownSeconds_ValueChanged(sender As Object, e As EventArgs) Handles knudCountdownSeconds.ValueChanged
        _countDownSeconds = Convert.ToInt32(knudCountdownSeconds.Value)
    End Sub

    Private Sub kdtpMaximumDate_ValueChanged(sender As Object, e As EventArgs) Handles kdtpMaximumDate.ValueChanged
        _maximumDateTimeValue = kdtpMaximumDate.Value
    End Sub

    Private Sub kdtpMinimumDate_ValueChanged(sender As Object, e As EventArgs) Handles kdtpMinimumDate.ValueChanged
        _minimumDateTimeValue = kdtpMinimumDate.Value
    End Sub

    Private Sub kdtpInitialDate_ValueChanged(sender As Object, e As EventArgs) Handles kdtpInitialDate.ValueChanged
        _initialDateTimeValue = kdtpInitialDate.Value
    End Sub

    Private Sub kchkTopMost_CheckedChanged(sender As Object, e As EventArgs) Handles kchkTopMost.CheckedChanged
        _topMost = kchkTopMost.Checked
    End Sub

    Private Sub kchkShowDoNotShowAgainOption_CheckedChanged(sender As Object, e As EventArgs) Handles kchkShowDoNotShowAgainOption.CheckedChanged
        _showDoNotShowAgainOption = kchkShowDoNotShowAgainOption.Checked
    End Sub

    Private Sub kchkFocusOnUserInputArea_CheckedChanged(sender As Object, e As EventArgs) Handles kchkFocusOnUserInputArea.CheckedChanged
        _focusOnUserInputArea = kchkFocusOnUserInputArea.Checked
    End Sub

    Private Sub kchkUseDoNotShowAgainOptionThreeState_CheckedChanged(sender As Object, e As EventArgs) Handles kchkUseDoNotShowAgainOptionThreeState.CheckedChanged
        _useDoNotShowAgainOptionThreeState = kchkUseDoNotShowAgainOptionThreeState.Checked
    End Sub

    Private Sub kchkIsDoNotShowAgainOptionChecked_CheckedChanged(sender As Object, e As EventArgs) Handles kchkIsDoNotShowAgainOptionChecked.CheckedChanged
        _isDoNotShowAgainOptionChecked = kchkIsDoNotShowAgainOptionChecked.Checked
    End Sub

    Private Sub kchkUseRTLReading_CheckedChanged(sender As Object, e As EventArgs) Handles kchkUseRTLReading.CheckedChanged
        _useRtlReading = kchkUseRTLReading.Checked
    End Sub

    Private Sub kcmbDoNotShowAgainOptionCheckState_SelectedIndexChanged(sender As Object, e As EventArgs) Handles kcmbDoNotShowAgainOptionCheckState.SelectedIndexChanged
        _doNotShowAgainOptionCheckState = CType([Enum].Parse(GetType(CheckState), kcmbDoNotShowAgainOptionCheckState.Text), CheckState)
    End Sub

#End Region

    Private Sub kcmbNotificationTitleAlignment_SelectedIndexChanged(sender As Object, e As EventArgs) Handles kcmbNotificationTitleAlignment.SelectedIndexChanged
        _notificationTitleAlignment = CType([Enum].Parse(GetType(ContentAlignment), kcmbNotificationTitleAlignment.Text), ContentAlignment)
    End Sub

    Private Sub kcmbNotificationContentAlignment_SelectedIndexChanged(sender As Object, e As EventArgs) Handles kcmbNotificationContentAlignment.SelectedIndexChanged

    End Sub

    Private Sub kcbtnBorderColor1_SelectedColorChanged(sender As Object, e As ColorEventArgs) Handles kcbtnBorderColor1.SelectedColorChanged
        _borderColor1 = kcbtnBorderColor1.SelectedColor
    End Sub

    Private Sub kcbtnBorderColor2_SelectedColorChanged(sender As Object, e As ColorEventArgs) Handles kcbtnBorderColor2.SelectedColorChanged
        _borderColor2 = kcbtnBorderColor2.SelectedColor
    End Sub

    Private Sub kbtnNotificationContentFont_Click(sender As Object, e As EventArgs) Handles kbtnNotificationContentFont.Click
        Dim contentFontDialog As New KryptonFontDialog() With {
            .Font = New Font("Segoe UI", 9.0F),
            .ShowColor = False
        }

        If contentFontDialog.ShowDialog() = DialogResult.OK Then
            _notificationContentFont = contentFontDialog.Font
        End If
    End Sub

    Private Sub kbtnNotificationTitleFont_Click(sender As Object, e As EventArgs) Handles kbtnNotificationTitleFont.Click
        Dim titleFontDialog As New KryptonFontDialog() With {
            .Font = New Font("Segoe UI", 13.5F, FontStyle.Bold),
            .ShowColor = False
        }

        If titleFontDialog.ShowDialog() = DialogResult.OK Then
            _notificationTitleFont = titleFontDialog.Font
        End If
    End Sub

    Private Sub knudCountDownInterval_ValueChanged(sender As Object, e As EventArgs) Handles knudCountDownInterval.ValueChanged
        _countDownTimerInterval = Convert.ToInt32(knudCountDownInterval.Value)
    End Sub

    Private Sub kcmbOwner_SelectedIndexChanged(sender As Object, e As EventArgs) Handles kcmbOwner.SelectedIndexChanged
        _toastHost = Me 'DirectCast(kcmbOwner.Text, IWin32Window)
    End Sub

    Private Sub kbtnShow_Click(sender As Object, e As EventArgs) Handles kbtnShow.Click
        Dim notificationData As New KryptonUserInputToastNotificationData()

        If kchkShowWithProgressBar.Checked Then
            KryptonToastNotification.ShowNotificationWithProgressBar(notificationData)
        Else
            KryptonToastNotification.ShowNotification(notificationData)
        End If
    End Sub

    Private Sub kchkUseDefaultLocation_CheckedChanged(sender As Object, e As EventArgs) Handles kchkUseDefaultLocation.CheckedChanged
        If kchkUseDefaultLocation.Checked Then
            knudXAxis.Value = Screen.PrimaryScreen.WorkingArea.Height - 5

            knudYAxis.Value = Screen.PrimaryScreen.WorkingArea.Width - 5
        End If
    End Sub

End Class
