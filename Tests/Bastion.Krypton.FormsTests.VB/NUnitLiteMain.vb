#Region "BSD License"
' New (Bastion) file in a work derived from BSD-3-Clause licensed code:
' © Component Factory Pty Ltd, 2006 - 2016. Then modifications by Peter Wagner (aka Wagnerp),
' Simon Coghlan (aka Smurf-IV), Giduac, Ahmed Abdelhameed, Lesandro & tobitege et al. 2017 - 2026.
' © Bastion Software Solutions Ltd 2026. All rights reserved.
#End Region

Imports System.Reflection

''' <summary>
''' net46 entry point only — self-executing NUnitLite console runner (the dotnet-test tooling
''' floor is net462; framework decision: Tests\README.md).
''' </summary>
Public Module NUnitLiteMain

    <STAThread>
    Public Function Main(ByVal args As String()) As Integer
        Return New NUnitLite.AutoRun(GetType(NUnitLiteMain).GetTypeInfo().Assembly).Execute(args)
    End Function

End Module
