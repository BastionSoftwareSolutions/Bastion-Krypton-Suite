' *****************************************************************************
' BSD 3-Clause License (https://github.com/Krypton-Suite/Standard-Toolkit)
' By Peter Wagner(aka Wagnerp) & Simon Coghlan(aka Smurf-IV), tobitege 2021 - 2025. All rights reserved.
' *****************************************************************************
' VB.NET twin of Source\Krypton Toolkit Examples\KryptonDataGridView Examples\Form2.cs (Bastion Phase 4c).

Imports Krypton.Toolkit

Public Class Form2

    Public Sub New()
        InitializeComponent()
        kryptonDataGridView1.Rows.Add("1", "Test Btn", True)

        Dim resources As New System.ComponentModel.ComponentResourceManager(GetType(Form2))

        Dim iconSpec1 As New Krypton.Toolkit.IconSpec With {
            .Alignment = Krypton.Toolkit.IconSpec.IconAlignment.Right,
            .Icon = TryCast(resources.GetObject("iconSpec1.Icon"), System.Drawing.Image)
        }

        Button.IconSpecs.Add(iconSpec1)

    End Sub

End Class
