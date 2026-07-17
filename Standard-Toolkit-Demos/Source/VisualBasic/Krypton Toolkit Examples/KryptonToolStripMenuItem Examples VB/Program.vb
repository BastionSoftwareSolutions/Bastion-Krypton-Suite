' *****************************************************************************
' BSD 3-Clause License (https://github.com/Krypton-Suite/Standard-Toolkit)
' By Peter Wagner(aka Wagnerp), Simon Coghlan(aka Smurf-IV), tobitege 2025 - 2025. All rights reserved.
' *****************************************************************************
' VB.NET twin of Source\Krypton Toolkit Examples\KryptonToolStripMenuItem Examples\Program.cs (Bastion Phase 4c).

Imports System.Windows.Forms

Friend Module Program

    ''' <summary>
    ''' The main entry point for the application.
    ''' </summary>
    <STAThread>
    Friend Sub Main()
        ' To customize application configuration such as set high DPI settings or default font,
        ' see https://aka.ms/applicationconfiguration.
        Application.EnableVisualStyles()
        Application.SetCompatibleTextRenderingDefault(False)
        Application.Run(New MenuToolBarStatusStripTest())
    End Sub

End Module
