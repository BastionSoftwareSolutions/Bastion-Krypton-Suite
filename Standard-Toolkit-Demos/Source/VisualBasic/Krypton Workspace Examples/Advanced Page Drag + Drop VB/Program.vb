'
'  © Component Factory Pty Ltd, 2006 - 2016. All rights reserved.
'	The software and associated documentation supplied hereunder are the
'  proprietary information of Component Factory Pty Ltd, PO Box 1504,
'  Glen Waverley, Vic 3150, Australia and are supplied subject to licence terms.
'
'  Modifications by Peter Wagner(aka Wagnerp) & Simon Coghlan(aka Smurf-IV) 2017 - 2024. All rights reserved. (https://github.com/Krypton-Suite/Standard-Toolkit)
'  Version 5.550.0 	www.ComponentFactory.com
' *****************************************************************************
' VB.NET twin of Source\Krypton Workspace Examples\Advanced Page Drag + Drop\Program.cs (Bastion Phase 4c).

Imports System
Imports System.Windows.Forms

Friend Module Program

    ''' <summary>
    ''' The main entry point for the application.
    ''' </summary>
    <STAThread>
    Sub Main()
        Application.EnableVisualStyles()
        Application.SetCompatibleTextRenderingDefault(False)
        Application.Run(New Form1())
    End Sub

End Module
