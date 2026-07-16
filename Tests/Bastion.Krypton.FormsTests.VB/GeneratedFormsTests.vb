#Region "BSD License"
' New (Bastion) file in a work derived from BSD-3-Clause licensed code:
' © Component Factory Pty Ltd, 2006 - 2016. Then modifications by Peter Wagner (aka Wagnerp),
' Simon Coghlan (aka Smurf-IV), Giduac, Ahmed Abdelhameed, Lesandro & tobitege et al. 2017 - 2026.
' © Bastion Software Solutions Ltd 2026. All rights reserved.
#End Region

Imports System.Drawing
Imports System.Windows.Forms

Imports Bastion.Krypton.UnitTests.Infrastructure

Imports Krypton.Toolkit

Imports NUnit.Framework

''' <summary>
''' VB variant of the generated-forms exercise (spec §6.1: the VB designer path must compile
''' and run). Shows each generated family form, pumps, resizes, switches through four
''' representative palettes, disposes, and asserts GDI/USER handle stability across a second
''' full lifecycle (the first warms the toolkit's one-off caches).
''' </summary>
<TestFixture>
Public Class GeneratedFormsTests
    Inherits UiTestBase

    ''' <summary>One palette per major era; ends on the toolkit default.</summary>
    Private Shared ReadOnly RepresentativePalettes As PaletteMode() =
    {
        PaletteMode.Office2010Black,
        PaletteMode.SparkleBlue,
        PaletteMode.ProfessionalSystem,
        PaletteMode.Microsoft365Blue
    }

    ''' <summary>All generated family forms in this assembly.</summary>
    Public Shared ReadOnly Iterator Property FamilyFormTypes As IEnumerable(Of Type)
        Get
            Dim types = GetType(GeneratedFormsTests).Assembly.GetTypes().
                Where(Function(t) Not t.IsAbstract AndAlso
                          GetType(Form).IsAssignableFrom(t) AndAlso
                          t.Namespace IsNot Nothing AndAlso
                          t.Namespace.EndsWith(".Generated", StringComparison.Ordinal)).
                OrderBy(Function(t) t.Name, StringComparer.Ordinal)
            For Each t As Type In types
                Yield t
            Next
        End Get
    End Property

    ''' <summary>The generator must have produced one form per core assembly family.</summary>
    <Test>
    Public Sub Generator_ProducedAllFiveFamilyForms()
        Dim names = FamilyFormTypes.Select(Function(t) t.Name).ToArray()
        Assert.That(names, [Is].EquivalentTo({
            "DockingFamilyForm", "NavigatorFamilyForm", "RibbonFamilyForm",
            "ToolkitFamilyForm", "WorkspaceFamilyForm"}))
    End Sub

    ''' <summary>Show, pump, resize, palette-switch, dispose — twice; handles must be stable.</summary>
    <TestCaseSource(NameOf(FamilyFormTypes))>
    Public Sub FamilyForm_ShowResizePaletteSwitchDispose_HandlesStable(ByVal formType As Type)
        StaMessagePump.Run(
            Sub()
                ' Warm-up lifecycle: populates the toolkit's static palette/font/image caches
                ' so the measured lifecycle only sees genuine leaks.
                RunLifecycle(formType)

                Dim before As HandleSnapshot = HandleCounter.Snapshot()
                RunLifecycle(formType)

                GC.Collect()
                GC.WaitForPendingFinalizers()
                GC.Collect()
                StaMessagePump.Pump(100)

                HandleCounter.AssertStable(before, gdiSlack:=48, userSlack:=32)
            End Sub, timeoutMs:=300000)
    End Sub

    Private Shared Sub RunLifecycle(ByVal formType As Type)
        Using manager As New KryptonManager()
            Try
                Using form As Form = DirectCast(Activator.CreateInstance(formType), Form)
                    form.Show()
                    StaMessagePump.Pump(150)

                    form.Size = New Size(form.Width + 160, form.Height + 120)
                    StaMessagePump.Pump(100)
                    form.Size = New Size(form.Width - 240, form.Height - 200)
                    StaMessagePump.Pump(100)

                    For Each mode As PaletteMode In RepresentativePalettes
                        manager.GlobalPaletteMode = mode
                        StaMessagePump.Pump(120)
                    Next
                End Using

                StaMessagePump.Pump(100)
            Finally
                ' GlobalPaletteMode proxies static toolkit state — always end on the default.
                manager.GlobalPaletteMode = PaletteMode.Microsoft365Blue
            End Try
        End Using
    End Sub

End Class
