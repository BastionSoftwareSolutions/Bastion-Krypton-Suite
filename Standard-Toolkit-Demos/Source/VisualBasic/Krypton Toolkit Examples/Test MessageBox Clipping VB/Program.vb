' *****************************************************************************
' BSD 3-Clause License (https://github.com/Krypton-Suite/Standard-Toolkit)
'  By Peter Wagner(aka Wagnerp) & Simon Coghlan(aka Smurf-IV), tobitege 2017 - 2025. All rights reserved.
' *****************************************************************************
' VB.NET twin of Source\Krypton Toolkit Examples\Test MessageBox Clipping\Program.cs (Bastion Phase 4c).

Imports System.Windows.Forms

Imports Krypton.Toolkit

Friend Module Program

    ''' <summary>
    ''' The main entry point for the application.
    ''' </summary>
    <STAThread>
    Friend Sub Main()
        Application.EnableVisualStyles()
        Application.SetCompatibleTextRenderingDefault(False)
        KryptonMessageBox.Show("Test without an owner," & vbLf & "and before KyptonManager has Loaded")
        KryptonMessageBox.Show(text:=String.Empty, "Test without no Text")
        Application.Run(New Form1())
    End Sub

End Module
