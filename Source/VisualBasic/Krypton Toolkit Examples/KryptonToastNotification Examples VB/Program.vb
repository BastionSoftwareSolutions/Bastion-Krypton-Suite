' *****************************************************************************
' BSD 3-Clause License (https://github.com/Krypton-Suite/Standard-Toolkit)
'  By Peter Wagner(aka Wagnerp) & Simon Coghlan(aka Smurf-IV) 2024 - 2024. All rights reserved.
' *****************************************************************************
' VB.NET twin of Source\Krypton Toolkit Examples\KryptonToastNotification Examples\Program.cs (Bastion Phase 4c).

Imports System
Imports System.Windows.Forms

Friend Module Program

    ''' <summary>
    ''' The main entry point for the application.
    ''' </summary>
    <STAThread>
    Sub Main()
        ' To customize application configuration such as set high DPI settings or default font,
        ' see https://aka.ms/applicationconfiguration.
        Application.EnableVisualStyles()
        Application.SetCompatibleTextRenderingDefault(False)
        Application.Run(New MainForm())
    End Sub

End Module
