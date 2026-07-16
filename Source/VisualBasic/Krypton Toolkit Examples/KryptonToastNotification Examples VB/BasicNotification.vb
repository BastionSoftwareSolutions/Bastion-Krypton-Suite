' *****************************************************************************
' BSD 3-Clause License (https://github.com/Krypton-Suite/Standard-Toolkit)
'  By Peter Wagner(aka Wagnerp) & Simon Coghlan(aka Smurf-IV) 2024 - 2024. All rights reserved.
' *****************************************************************************
' VB.NET twin of Source\Krypton Toolkit Examples\KryptonToastNotification Examples\BasicNotification.cs (Bastion Phase 4c).

Imports System
Imports System.Drawing
Imports System.Windows.Forms

Imports Krypton.Toolkit

Public Class BasicNotification

#Region "Instance Fields"

    Private _showCloseBox As Boolean
    Private _topMost As Boolean
    Private _useFade As Boolean
    Private _reportLocation As Boolean
    Private _titleAlignment As ContentAlignment
    Private _borderColor1 As Color
    Private _borderColor2 As Color
    Private _contentFont As Font
    Private _titleFont As Font
    Private _countDownSeconds As Integer
    Private _notificationIcon As KryptonToastNotificationIcon
    Private _notificationTitleText As String
    Private _notificationContentText As String

#End Region

    Private Sub Form1_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        ' Set defaults
        _showCloseBox = False
        _topMost = True
        _useFade = False
        _reportLocation = False
        _titleAlignment = ContentAlignment.MiddleCenter
        _borderColor1 = Color.Empty
        _borderColor2 = Color.Empty
        _contentFont = Nothing
        _titleFont = Nothing
        _countDownSeconds = 60
        _notificationIcon = KryptonToastNotificationIcon.Information
        _notificationTitleText = ktxtToastTitle.Text
        _notificationContentText = ktxtToastContent.Text

        kcbBorderColor1.SelectedColor = Color.Empty
        kcbBorderColor2.SelectedColor = Color.Empty

        For Each value In [Enum].GetValues(GetType(KryptonToastNotificationIcon))
            kcmbToastIcon.Items.Add(value.ToString())
        Next

        kcmbToastIcon.SelectedIndex = 8

        For Each value In [Enum].GetValues(GetType(ContentAlignment))
            kcmbToastTitleAlignment.Items.Add(value.ToString())
        Next

        kcmbToastTitleAlignment.SelectedIndex = 4
    End Sub

    Private Sub ktxtToastTitle_TextChanged(sender As Object, e As EventArgs) Handles ktxtToastTitle.TextChanged
        _notificationTitleText = ktxtToastTitle.Text
    End Sub

    Private Sub ktxtToastContent_TextChanged(sender As Object, e As EventArgs) Handles ktxtToastContent.TextChanged
        _notificationContentText = ktxtToastContent.Text
    End Sub

    Private Sub kcmbToastIcon_SelectedIndexChanged(sender As Object, e As EventArgs) Handles kcmbToastIcon.SelectedIndexChanged
        _notificationIcon = CType([Enum].Parse(GetType(KryptonToastNotificationIcon), kcmbToastIcon.Text), KryptonToastNotificationIcon)
    End Sub

    Private Sub kcmbToastTitleAlignment_SelectedIndexChanged(sender As Object, e As EventArgs) Handles kcmbToastTitleAlignment.SelectedIndexChanged
        _titleAlignment = CType([Enum].Parse(GetType(ContentAlignment), kcmbToastTitleAlignment.Text), ContentAlignment)
    End Sub

    Private Sub kbtnContentFont_Click(sender As Object, e As EventArgs) Handles kbtnContentFont.Click
        Dim contentFontDialog As New KryptonFontDialog()

        If contentFontDialog.ShowDialog() = DialogResult.OK Then
            _contentFont = contentFontDialog.Font
        End If
    End Sub

    Private Sub kbtnTitleFont_Click(sender As Object, e As EventArgs) Handles kbtnTitleFont.Click
        Dim titleFontDialog As New KryptonFontDialog()

        If titleFontDialog.ShowDialog() = DialogResult.OK Then
            _titleFont = titleFontDialog.Font
        End If
    End Sub

    Private Sub knudCountdownSeconds_ValueChanged(sender As Object, e As EventArgs) Handles knudCountdownSeconds.ValueChanged
        _countDownSeconds = CInt(knudCountdownSeconds.Value)
    End Sub

    Private Sub kbtnShow_Click(sender As Object, e As EventArgs) Handles kbtnShow.Click
        Dim notificationData As New KryptonBasicToastNotificationData() With {
            .CountDownSeconds = _countDownSeconds,
            .CustomImage = Nothing,
            .NotificationContent = _notificationContentText,
            .NotificationTitle = _notificationTitleText,
            .NotificationContentFont = _contentFont,
            .NotificationTitleFont = _titleFont,
            .NotificationIcon = _notificationIcon,
            .NotificationLocation = Nothing,
            .NotificationTitleAlignment = _titleAlignment,
            .TopMost = _topMost,
            .UseFade = _useFade,
            .ShowCloseBox = _showCloseBox,
            .ReportToastLocation = _reportLocation,
            .BorderColor1 = _borderColor1,
            .BorderColor2 = _borderColor2
        }

        If kchkShowProgressBar.Checked Then
            KryptonToastNotification.ShowBasicProgressBarNotification(notificationData)
        Else
            KryptonToastNotification.ShowBasicNotification(notificationData)
        End If
    End Sub

    Private Sub kchkUseFade_CheckedChanged(sender As Object, e As EventArgs) Handles kchkUseFade.CheckedChanged
        _useFade = kchkUseFade.Checked
    End Sub

    Private Sub kchkTopMost_CheckedChanged(sender As Object, e As EventArgs) Handles kchkTopMost.CheckedChanged
        _topMost = kchkTopMost.Checked
    End Sub

    Private Sub kchkShowCloseBox_CheckedChanged(sender As Object, e As EventArgs) Handles kchkShowCloseBox.CheckedChanged
        _showCloseBox = kchkShowCloseBox.Checked
    End Sub

    Private Sub kchkReportLocation_CheckedChanged(sender As Object, e As EventArgs) Handles kchkReportLocation.CheckedChanged
        _reportLocation = kchkReportLocation.Checked
    End Sub

End Class
