' *****************************************************************************
' BSD 3-Clause License (https://github.com/Krypton-Suite/Standard-Toolkit)
'  By Peter Wagner(aka Wagnerp) & Simon Coghlan(aka Smurf-IV) 2021 - 2024. All rights reserved.
' *****************************************************************************
' VB.NET twin of Source\Krypton Toolkit Examples\KryptonAboutToolkit Example\Form1.cs (Bastion Phase 4c).

Imports System
Imports System.Windows.Forms

Imports Krypton.Toolkit

Public Class Form1

    Private _toolkitType As ToolkitSupportType

    Public Sub New()
        InitializeComponent()

        _toolkitType = ToolkitSupportType.Stable
    End Sub

    Private Sub kbtnCancel_Click(sender As Object, e As EventArgs) Handles kbtnCancel.Click
        Close()
    End Sub

    Private Sub kbtnShow_Click(sender As Object, e As EventArgs) Handles kbtnShow.Click
        Dim data As New KryptonAboutToolkitData()

        data.CurrentThemeText = ktxtCurrentThemeText.Text

        data.DiscordText = ktxtJoinDiscordText.Text

        data.HeaderText = ktxtAboutText.Text

        data.GeneralInformationLearnMoreText = ktxtLearnMoreText.Text

        data.GeneralInformationLicenseText = ktxtLicenseText.Text

        data.GeneralInformationWelcomeText = ktxtWelcomeText.Text

        data.RepositoryInformationText = ktxtRepositoryInformationText.Text

        data.DownloadDemosText = ktxtDownloadDemosText.Text

        data.DownloadDocumentationText = ktxtDownloadDocumentationText.Text

        data.FileNameColumnHeaderText = ktxtFileNameColumnHeaderText.Text

        data.VersionColumnHeaderText = ktxtVersionColumnHeaderText.Text

        data.ToolBarDeveloperInformationText = ktxtToolBarDeveloperInformationText.Text

        data.ToolBarDiscordText = ktxtToolBarDiscordText.Text

        data.ToolBarDeveloperInformationText = ktxtToolBarDeveloperInformationText.Text

        data.ToolBarGeneralInformationText = ktxtToolBarGeneralInformationText.Text

        data.ToolBarVersionInformationText = ktxtToolBarVersionInformationText.Text

        data.ShowDeveloperInformationButton = kcbShowDeveloperInformationButton.Checked

        data.ShowDiscordButton = kcbShowDiscordButton.Checked

        data.ShowSystemInformationButton = kcbShowSystemInformationButton.Checked

        data.ShowThemeOptions = kcbShowThemeOptions.Checked

        data.ShowVersionInformationButton = kcbShowVersionInformationButton.Checked

        data.ToolkitSupportType = _toolkitType

        data.DiscordLinkArea = New LinkArea(CInt(knumLinkAreaDiscordStart.Value), CInt(knumLinkAreaDiscordEnd.Value))

        data.DocumentationLinkArea = New LinkArea(CInt(knumLinkAreaDownloadDocumentationStart.Value), CInt(knumLinkAreaDownloadDocumentationEnd.Value))

        data.DownloadDemosLinkArea = New LinkArea(CInt(knumLinkAreaDownloadDemosStart.Value), CInt(knumLinkAreaDowenloadDemosEnd.Value))

        data.LearnMoreLinkArea = New LinkArea(CInt(knumLinkAreaLearnMoreStart.Value), CInt(knumLinkAreaLearnMoreEnd.Value))

        data.RepositoryInformationLinkArea = New LinkArea(CInt(knumLinkAreaRepositoryInformationStart.Value), CInt(knumLinkAreaRepositoryInformationEnd.Value))

        'KryptonAboutBox.Show(data)
    End Sub

    Private Sub ToolkitType_CheckedChanged(sender As Object, e As EventArgs) Handles krbStable.CheckedChanged, krbNightly.CheckedChanged, krbCanary.CheckedChanged
        If krbCanary.Checked Then
            _toolkitType = ToolkitSupportType.Canary
        End If

        If krbNightly.Checked Then
            _toolkitType = ToolkitSupportType.Nightly
        End If

        If krbStable.Checked Then
            _toolkitType = ToolkitSupportType.Stable
        End If
    End Sub

End Class
