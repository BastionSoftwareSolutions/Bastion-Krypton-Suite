' *****************************************************************************
' BSD 3-Clause License (https://github.com/Krypton-Suite/Standard-Toolkit)
'  By Peter Wagner(aka Wagnerp) & Simon Coghlan(aka Smurf-IV) 2021 - 2024. All rights reserved.
' *****************************************************************************
' VB.NET twin of Source\Krypton Toolkit Examples\KryptonWebBrowser Example\Form1.cs (Bastion Phase 4c).

Imports Krypton.Toolkit

Public Class Form1

    Public Sub New()
        InitializeComponent()
        webBrowser1.DocumentText = "<div contenteditable=""true"">Standard Form WebBrowser.<br/> This is in Editable mode</div>"
        webBrowser2.DocumentText = "<div contenteditable=""true"">Krypton WebBrowser.<br/> This is in Editable mode with a Krypton context menu</div>"

        kcmbTheme.Text = ThemeManager.ReturnPaletteModeAsString(kryptonManager1.GlobalPaletteMode)
    End Sub

    Private Sub KcmbTheme_SelectedValueChanged(sender As Object, e As System.EventArgs) Handles kcmbTheme.SelectedValueChanged
        ThemeManager.ApplyTheme(kcmbTheme.Text, kryptonManager1)
    End Sub

End Class
