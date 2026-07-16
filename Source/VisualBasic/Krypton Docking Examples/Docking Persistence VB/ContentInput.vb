#Region "BSD License"
'
' Original BSD 3-Clause License (https://github.com/ComponentFactory/Krypton/blob/master/LICENSE)
'  © Component Factory Pty Ltd, 2006 - 2016, (Version 4.5.0.0) All rights reserved.
'
'  New BSD 3-Clause License (https://github.com/Krypton-Suite/Standard-Toolkit/blob/master/LICENSE)
'  Modifications by Peter Wagner(aka Wagnerp) & Simon Coghlan(aka Smurf-IV), et al. 2017 - 2024. All rights reserved.
'
' VB.NET twin of Source\Krypton Docking Examples\Docking Persistence\ContentInput.cs (Bastion Phase 4c).
#End Region

Imports System.Windows.Forms

Public Class ContentInput

    Public Sub New()
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

End Class
