#Region "BSD License"
'
' Original BSD 3-Clause License (https://github.com/ComponentFactory/Krypton/blob/master/LICENSE)
'  © Component Factory Pty Ltd, 2006 - 2016, (Version 4.5.0.0) All rights reserved.
'
'  New BSD 3-Clause License (https://github.com/Krypton-Suite/Standard-Toolkit/blob/master/LICENSE)
'  Modifications by Peter Wagner(aka Wagnerp) & Simon Coghlan(aka Smurf-IV), et al. 2017 - 2024. All rights reserved.
'
' VB.NET twin of Source\Krypton Ribbon Examples\Ribbon Controls\Form1.cs (Bastion Phase 4c).
#End Region

Imports System
Imports System.Drawing
Imports System.Windows.Forms

Imports Krypton.Toolkit

Public Class Form1

    Private Shared Function CreateLinkLabel(text As String) As LinkLabel
        Dim ll As New LinkLabel With {
            .BackColor = Color.Transparent,
            .Text = text
        }
        Return ll
    End Function

    Private Shared Function CreateNumericUpDown(value As Decimal) As NumericUpDown
        Dim nud As New NumericUpDown With {
            .Value = value
        }
        Return nud
    End Function

    Private Shared Function CreateProgressBar(value As Integer) As ProgressBar
        Dim pb As New ProgressBar With {
            .Value = value
        }
        Return pb
    End Function

    Private Sub Form1_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        ' Load the rich text box with RTF
        richTextBox1.RichTextBox.Rtf = "{\rtf1\ansi\ansicpg1252\deff0\deflang1033{\colortbl ;\red0\green0\blue255;\red0\green128\blue0;\red255\green0\blue0;}{\*\generator Msftedit 5.41.15.1507;}\viewkind4\uc1\pard\cf1\f0\fs20 RichTextBox\cf0  with \cf2 Multiline\cf0  set to \cf3 True\cf0 .\par}"

        ' Hook into the button spec buttons
        AddHandler textBox3.ButtonSpecs(0).Click, AddressOf OnTextBox3Clear
        AddHandler comboBox3.ButtonSpecs(0).Click, AddressOf OnComboBox3Clear
        AddHandler dateTimePicker3.ButtonSpecs(0).Click, AddressOf OnDateTimePicker3Clear
        AddHandler maskedTextBox3.ButtonSpecs(0).Click, AddressOf OnMaskedTextBox3Clear
        AddHandler numericUpDown2.ButtonSpecs(0).Click, AddressOf OnNumericUpDown2Clear

        ' Create and associate various controls
        custom9.CustomControl = CreateLinkLabel("LinkLabel Control")
        custom10.CustomControl = CreateNumericUpDown(50)
        custom11.CustomControl = CreateProgressBar(75)
    End Sub

    Private Sub OnTextBox3Clear(sender As Object, e As EventArgs)
        textBox3.Text = String.Empty
    End Sub

    Private Sub OnComboBox3Clear(sender As Object, e As EventArgs)
        comboBox3.Text = "Windows Vista"
    End Sub

    Private Sub OnMaskedTextBox3Clear(sender As Object, e As EventArgs)
        maskedTextBox3.Text = String.Empty
    End Sub

    Private Sub OnDateTimePicker3Clear(sender As Object, e As EventArgs)
        dateTimePicker3.Value = DateTime.Now
    End Sub

    Private Sub OnNumericUpDown2Clear(sender As Object, e As EventArgs)
        numericUpDown2.Value = numericUpDown2.Minimum
    End Sub

    ' NOTE: not wired to any event, mirroring the C# demo (the designer never
    ' attaches appMenu_Click there either).
    Private Sub appMenu_Click(sender As Object, e As EventArgs)
        Close()
    End Sub

    Private Sub Form1_FormClosing(sender As Object, e As FormClosingEventArgs) Handles MyBase.FormClosing
        Settings.Default.Save()
    End Sub

End Class
