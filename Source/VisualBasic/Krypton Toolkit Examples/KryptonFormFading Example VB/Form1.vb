' *****************************************************************************
' BSD 3-Clause License (https://github.com/Krypton-Suite/Standard-Toolkit)
'  By Peter Wagner(aka Wagnerp) & Simon Coghlan(aka Smurf-IV) 2023 - 2024. All rights reserved.
' *****************************************************************************
' VB.NET twin of Source\Krypton Toolkit Examples\KryptonFormFading Example\Form1.cs (Bastion Phase 4c).

Public Class Form1

    Public Sub New()
        InitializeComponent()
    End Sub

    Private Sub kbtnTest_Click(sender As Object, e As EventArgs) Handles kbtnTest.Click
        Dim testForm As New Form2()

        'testForm.FadeValues.Owner = testForm

        'testForm.FadeValues.FadeDuration = FadeValues.FadeDuration

        'testForm.FadeValues.FadeSpeed = FadeValues.FadeSpeed

        'testForm.FadeValues.FadeSpeedChoice = FadeValues.FadeSpeedChoice

        'testForm.FadeValues.FadingEnabled = FadeValues.FadingEnabled

        'testForm.FadeValues.ShouldCloseOnFadeOut = FadeValues.ShouldCloseOnFadeOut

        testForm.ShowDialog()
    End Sub

End Class
