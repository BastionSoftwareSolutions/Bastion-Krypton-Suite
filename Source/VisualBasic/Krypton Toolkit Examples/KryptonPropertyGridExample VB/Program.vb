' *****************************************************************************
' BSD 3-Clause License (https://github.com/Krypton-Suite/Standard-Toolkit)
'  By Peter Wagner(aka Wagnerp) & Simon Coghlan(aka Smurf-IV) 2023 - 2024. All rights reserved.
' *****************************************************************************
' VB.NET twin of Source\Krypton Toolkit Examples\KryptonPropertyGridExample\Program.cs (Bastion Phase 4c).

Imports System
Imports System.Windows.Forms

Friend Module Program

    ''' <summary>
    ''' The main entry point for the application.
    ''' </summary>
    <STAThread>
    Sub Main()
        Application.EnableVisualStyles()
        ' See https://github.com/Krypton-Suite/Standard-Toolkit/issues/1109#issuecomment-1695481549:
        ' Setting the following to `true` will generate "Jagged Text" in the control
        Application.SetCompatibleTextRenderingDefault(False)
        Application.Run(New Form1())
    End Sub

End Module
