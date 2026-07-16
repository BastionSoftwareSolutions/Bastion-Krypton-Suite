#Region "BSD License"
'
' Original BSD 3-Clause License (https://github.com/ComponentFactory/Krypton/blob/master/LICENSE)
'  © Component Factory Pty Ltd, 2006 - 2016, (Version 4.5.0.0) All rights reserved.
'
'  New BSD 3-Clause License (https://github.com/Krypton-Suite/Standard-Toolkit/blob/master/LICENSE)
'  Modifications by Peter Wagner(aka Wagnerp) & Simon Coghlan(aka Smurf-IV), et al. 2017 - 2024. All rights reserved.
'
' VB.NET twin of Source\Krypton Docking Examples\Docking Flags\ContentFlags.cs (Bastion Phase 4c).
#End Region

Imports System
Imports System.Windows.Forms

Imports Krypton.Navigator

Public Class ContentFlags

    Private _page As KryptonPage

    Public Sub New()
        Me.New(Nothing)
    End Sub

    Public Sub New(page As KryptonPage)
        _page = page
        InitializeComponent()
    End Sub

    Private Sub kryptonPanel_MouseDown(sender As Object, e As MouseEventArgs) Handles kryptonPanel.MouseDown
        ' Only interested in left mouse down
        If e.Button = MouseButtons.Left Then
            ' If the content does not have the focus then give it focus now
            If Not ContainsFocus Then
                kryptonPanel.SelectNextControl(Me, True, True, True, False)
            End If
        End If
    End Sub

    Private Sub ContentFlags_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        ' Set checkbox controls to reflect current page flag settings
        cbDocked.Checked = _page.AreFlagsSet(KryptonPageFlags.DockingAllowDocked)
        cbAutoHidden.Checked = _page.AreFlagsSet(KryptonPageFlags.DockingAllowAutoHidden)
        cbFloating.Checked = _page.AreFlagsSet(KryptonPageFlags.DockingAllowFloating)
        cbWorkspace.Checked = _page.AreFlagsSet(KryptonPageFlags.DockingAllowWorkspace)
        cbNavigator.Checked = _page.AreFlagsSet(KryptonPageFlags.DockingAllowNavigator)
        cbDropDown.Checked = _page.AreFlagsSet(KryptonPageFlags.DockingAllowDropDown)
        cbClose.Checked = _page.AreFlagsSet(KryptonPageFlags.DockingAllowClose)
    End Sub

    Private Sub cbDocked_CheckedChanged(sender As Object, e As EventArgs) Handles cbDocked.CheckedChanged
        If cbDocked.Checked Then
            _page.SetFlags(KryptonPageFlags.DockingAllowDocked)
        Else
            _page.ClearFlags(KryptonPageFlags.DockingAllowDocked)
        End If
    End Sub

    Private Sub cbAutoHidden_CheckedChanged(sender As Object, e As EventArgs) Handles cbAutoHidden.CheckedChanged
        If cbAutoHidden.Checked Then
            _page.SetFlags(KryptonPageFlags.DockingAllowAutoHidden)
        Else
            _page.ClearFlags(KryptonPageFlags.DockingAllowAutoHidden)
        End If
    End Sub

    Private Sub cbFloating_CheckedChanged(sender As Object, e As EventArgs) Handles cbFloating.CheckedChanged
        If cbFloating.Checked Then
            _page.SetFlags(KryptonPageFlags.DockingAllowFloating)
        Else
            _page.ClearFlags(KryptonPageFlags.DockingAllowFloating)
        End If
    End Sub

    Private Sub cbWorkspace_CheckedChanged(sender As Object, e As EventArgs) Handles cbWorkspace.CheckedChanged
        If cbWorkspace.Checked Then
            _page.SetFlags(KryptonPageFlags.DockingAllowWorkspace)
        Else
            _page.ClearFlags(KryptonPageFlags.DockingAllowWorkspace)
        End If
    End Sub

    Private Sub cbNavigator_CheckedChanged(sender As Object, e As EventArgs) Handles cbNavigator.CheckedChanged
        If cbNavigator.Checked Then
            _page.SetFlags(KryptonPageFlags.DockingAllowNavigator)
        Else
            _page.ClearFlags(KryptonPageFlags.DockingAllowNavigator)
        End If
    End Sub

    Private Sub cbDropDown_CheckedChanged(sender As Object, e As EventArgs) Handles cbDropDown.CheckedChanged
        If cbDropDown.Checked Then
            _page.SetFlags(KryptonPageFlags.DockingAllowDropDown)
        Else
            _page.ClearFlags(KryptonPageFlags.DockingAllowDropDown)
        End If
    End Sub

    Private Sub cbClose_CheckedChanged(sender As Object, e As EventArgs) Handles cbClose.CheckedChanged
        If cbClose.Checked Then
            _page.SetFlags(KryptonPageFlags.DockingAllowClose)
        Else
            _page.ClearFlags(KryptonPageFlags.DockingAllowClose)
        End If
    End Sub

End Class
