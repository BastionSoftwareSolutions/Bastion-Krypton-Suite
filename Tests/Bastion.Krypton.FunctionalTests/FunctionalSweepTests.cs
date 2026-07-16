#region BSD License
/*
 * New (Bastion) file in a work derived from BSD-3-Clause licensed code:
 * © Component Factory Pty Ltd, 2006 - 2016. Then modifications by Peter Wagner (aka Wagnerp),
 * Simon Coghlan (aka Smurf-IV), Giduac, Ahmed Abdelhameed, Lesandro & tobitege et al. 2017 - 2026.
 * © Bastion Software Solutions Ltd 2026. All rights reserved.
 */
#endregion

using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Linq;
using System.Reflection;
using System.Runtime.ExceptionServices;
using System.Text;
using System.Threading;
using System.Windows.Forms;

using Bastion.Krypton.UnitTests.Infrastructure;

using Krypton.Toolkit;

using NUnit.Framework;

namespace Bastion.Krypton.FunctionalTests
{
    /// <summary>
    /// Phase 5b per-control functional coverage — the exact recipe of spec §6.2, one test case
    /// per public Component type of the five core assemblies:
    /// instantiate → place on a real shown KryptonForm → verify default render (no exception,
    /// non-empty paint) → set every public writable property to a typical value → invoke safe
    /// public methods → dispose → assert GDI/USER handle deltas within tolerance after a
    /// warm-up lifecycle → finalizer sweep at fixture end.
    /// </summary>
    [TestFixture]
    public class FunctionalSweepTests : UiTestBase
    {
        // ------------------------------------------------------------------ test cases

        /// <summary>One test case per catalogued type (spec §6.2: reflection + TestCaseSource).</summary>
        public static IEnumerable<TestCaseData> SweepCases =>
            CoverageCatalogue.Entries.Select(static e =>
                new TestCaseData(e.Type, e.Kind).SetName($"Sweep.{e.Type.FullName}"));

        /// <summary>Full recipe per type; failures are reported as one structured message.</summary>
        [TestCaseSource(nameof(SweepCases))]
        public void Type_FunctionalRecipe(Type type, SweepKind kind)
        {
            var failures = new List<SweepFailure>();

            StaMessagePump.Run(() =>
            {
                // Insurance against a modal ThreadExceptionDialog hanging the run: on .NET
                // Framework an exception escaping a *reflected* WM_COMMAND WndProc (the parent
                // form reflecting a child notification) is routed to Application.ThreadException
                // rather than propagating to our try/catch — and, unhandled, pops the modal
                // "Microsoft .NET Framework" dialog that blocks the pump forever. Subscribing a
                // handler suppresses the dialog and turns it into a structured failure instead.
                ThreadExceptionEventHandler threadExceptionHandler = (_, e) =>
                    failures.AddDistinct(new SweepFailure("threadexception", type.Name, "-", e.Exception));
                Application.ThreadException += threadExceptionHandler;
                try
                {
                    // Warm-up lifecycle: populates the toolkit's static palette/font/image
                    // caches (and any first-sweep-only caches) so the measured lifecycle
                    // below only sees genuine per-lifecycle leaks.
                    RunRecipe(type, kind, failures, recordStats: true);

                    HandleSnapshot before = HandleCounter.Snapshot();
                    RunRecipe(type, kind, failures, recordStats: false);

                    GC.Collect();
                    GC.WaitForPendingFinalizers();
                    GC.Collect();
                    StaMessagePump.Pump(80);

                    try
                    {
                        HandleCounter.AssertStable(before, gdiSlack: 48, userSlack: 32);
                    }
                    catch (AssertionException handleFailure)
                    {
                        failures.Add(new SweepFailure(
                            "handles", type.Name, "(lifecycle)", handleFailure));
                    }
                }
                finally
                {
                    Application.ThreadException -= threadExceptionHandler;
                    ResetGlobalPalette();
                }
            }, timeoutMs: 180_000);

            if (failures.Count > 0)
            {
                Assert.Fail(SweepFailure.Format(type, failures));
            }
        }

        /// <summary>The catalogue itself is part of the contract: report and sanity-check it.</summary>
        [Test]
        public void Catalogue_CoversExpectedSurface()
        {
            int hosted = CoverageCatalogue.Entries.Count(static e => e.Kind == SweepKind.HostedControl);
            int forms = CoverageCatalogue.Entries.Count(static e => e.Kind == SweepKind.TopLevelForm);
            int componentOnly = CoverageCatalogue.Entries.Count(static e => e.Kind == SweepKind.ComponentOnly);

            TestContext.Out.WriteLine($"Catalogue: {CoverageCatalogue.Entries.Count} types " +
                $"(hosted controls={hosted}, top-level forms={forms}, component-only={componentOnly}); " +
                $"no public parameterless ctor={CoverageCatalogue.NoPublicCtorTypes.Count}; " +
                $"[Obsolete(error)]={CoverageCatalogue.ObsoleteErrorTypes.Count}.");
            foreach (string name in CoverageCatalogue.NoPublicCtorTypes)
            {
                TestContext.Out.WriteLine($"  no-public-ctor: {name}");
            }

            Assert.Multiple(() =>
            {
                // The Phase 2 smoke sweep instantiated 230 types across the five assemblies;
                // the catalogue must be in that ballpark on every TFM (guards against a
                // reflection/classification regression silently emptying the sweep).
                Assert.That(CoverageCatalogue.Entries.Count, Is.GreaterThanOrEqualTo(200),
                    "Catalogue lost types — classification regression?");
                Assert.That(hosted, Is.GreaterThanOrEqualTo(60),
                    "Hosted-control catalogue lost types — classification regression?");
            });
        }

        // ------------------------------------------------------------------ finalizer sweep

        /// <summary>
        /// Spec §6.2 step 7: fixture-end finalizer sweep — GC.Collect/WaitForPendingFinalizers
        /// with a first-chance exception trap; no finalizer-thread exceptions allowed.
        /// Also dumps the sweep statistics.
        /// </summary>
        [OneTimeTearDown]
        public void FinalizerSweepAndStats()
        {
            var trapped = new List<string>();
            EventHandler<FirstChanceExceptionEventArgs> trap = (_, e) =>
            {
                try
                {
                    string stack = Environment.StackTrace;
                    if (stack.IndexOf("Finalize", StringComparison.Ordinal) >= 0)
                    {
                        lock (trapped)
                        {
                            trapped.Add($"{e.Exception.GetType().FullName}: {e.Exception.Message}\n{stack}");
                        }
                    }
                }
                catch
                {
                    // Never let the trap itself throw during first-chance dispatch.
                }
            };

            AppDomain.CurrentDomain.FirstChanceException += trap;
            try
            {
                for (int i = 0; i < 3; i++)
                {
                    GC.Collect();
                    GC.WaitForPendingFinalizers();
                }
            }
            finally
            {
                AppDomain.CurrentDomain.FirstChanceException -= trap;
            }

            SweepStats.Dump();

            if (trapped.Count > 0)
            {
                Assert.Fail(
                    $"Finalizer sweep trapped {trapped.Count} finalizer-thread exception(s):\n" +
                    string.Join("\n---\n", trapped));
            }
        }

        // ------------------------------------------------------------------ the recipe

        private static void RunRecipe(Type type, SweepKind kind, List<SweepFailure> failures, bool recordStats)
        {
            if (kind == SweepKind.ComponentOnly)
            {
                // Spec §6.2 step 3: Component-but-not-Control types (and controls that cannot
                // be parented/shown) get instantiate + dispose only.
                var component = (Component)Activator.CreateInstance(type)!;
                try
                {
                    component.Dispose();
                }
                catch (Exception ex)
                {
                    failures.AddDistinct(new SweepFailure("dispose", $"{type.Name}.Dispose()", "-", ex));
                }

                return;
            }

            var target = (Control)Activator.CreateInstance(type)!;
            Form host;
            if (kind == SweepKind.TopLevelForm)
            {
                host = (Form)target;
                host.StartPosition = FormStartPosition.Manual;
                host.Location = new Point(0, 0);
                host.ShowInTaskbar = false;
            }
            else
            {
                host = new KryptonForm
                {
                    StartPosition = FormStartPosition.Manual,
                    Location = new Point(0, 0),
                    ClientSize = new Size(700, 500),
                    ShowInTaskbar = false,
                    Text = $"Bastion FunctionalTests — {type.Name}"
                };
                target.Location = new Point(10, 10);
                target.Size = new Size(280, 100);
                host.Controls.Add(target);
            }

            try
            {
                host.Show();
                StaMessagePump.Pump(80);

                VerifyDefaultRender(target, failures);

                SweepProperties(target, failures, recordStats);
                StaMessagePump.Pump(40);

                SweepMethods(target, failures, recordStats);
                StaMessagePump.Pump(40);
            }
            finally
            {
                // Step 6: dispose the control itself (the dispose-time WndProc bugs of
                // BREAKAGE-LOG items 1-2 live exactly here), then the host.
                try
                {
                    target.Dispose();
                }
                catch (Exception ex)
                {
                    failures.AddDistinct(new SweepFailure("dispose", $"{type.Name}.Dispose()", "-", ex));
                }

                if (!ReferenceEquals(host, target))
                {
                    try
                    {
                        host.Dispose();
                    }
                    catch (Exception ex)
                    {
                        failures.AddDistinct(new SweepFailure("dispose", $"{type.Name} host.Dispose()", "-", ex));
                    }
                }

                StaMessagePump.Pump(40);
            }
        }

        // ------------------------------------------------------------------ step 3: render

        private static void VerifyDefaultRender(Control target, List<SweepFailure> failures)
        {
            Type type = target.GetType();
            if (SweepPolicy.IsNoRender(type))
            {
                return; // Justified in SweepPolicy.NoRender.
            }

            bool blankByDesign = SweepPolicy.IsBlankByDesign(type);

            try
            {
                if (target.Width <= 0 || target.Height <= 0)
                {
                    if (!blankByDesign)
                    {
                        failures.AddDistinct(new SweepFailure("render", $"{type.Name} (default render)",
                            $"bounds {target.Width}x{target.Height}",
                            new InvalidOperationException("Control laid itself out to an empty size — nothing to paint.")));
                    }

                    return;
                }

                using (var bitmap = new Bitmap(target.Width, target.Height))
                {
                    target.DrawToBitmap(bitmap, new Rectangle(0, 0, target.Width, target.Height));

                    // Blank-by-design controls: "no exception" is the whole assertion.
                    if (!blankByDesign && IsUniform(bitmap))
                    {
                        failures.AddDistinct(new SweepFailure("render", $"{type.Name} (default render)",
                            $"uniform ARGB {bitmap.GetPixel(0, 0).ToArgb():X8}",
                            new InvalidOperationException("Default render is uniformly a single colour (empty paint).")));
                    }
                }
            }
            catch (Exception ex) when (!(ex is AssertionException))
            {
                failures.AddDistinct(new SweepFailure("render", $"{type.Name}.DrawToBitmap()", "-", ex));
            }
        }

        private static bool IsUniform(Bitmap bitmap)
        {
            int first = bitmap.GetPixel(0, 0).ToArgb();
            int stepX = Math.Max(1, bitmap.Width / 48);
            int stepY = Math.Max(1, bitmap.Height / 48);
            for (int y = 0; y < bitmap.Height; y += stepY)
            {
                for (int x = 0; x < bitmap.Width; x += stepX)
                {
                    if (bitmap.GetPixel(x, y).ToArgb() != first)
                    {
                        return false;
                    }
                }
            }

            return true;
        }

        // ------------------------------------------------------------------ step 4: properties

        private static void SweepProperties(Control target, List<SweepFailure> failures, bool recordStats)
        {
            // Most-derived wins where a property hides a base one with the same name.
            IEnumerable<PropertyInfo> properties = target.GetType()
                .GetProperties(BindingFlags.Public | BindingFlags.Instance)
                .GroupBy(static p => p.Name, StringComparer.Ordinal)
                .Select(static g => g.First())
                .OrderBy(static p => p.Name, StringComparer.Ordinal);

            foreach (PropertyInfo property in properties)
            {
                if (property.GetSetMethod() == null || property.GetIndexParameters().Length != 0)
                {
                    continue;
                }

                if (property.GetCustomAttribute<ObsoleteAttribute>() != null)
                {
                    if (recordStats)
                    {
                        SweepStats.PropertiesSkippedObsolete++;
                    }

                    continue; // Spec skip-list: obsolete members.
                }

                if (SweepPolicy.SkipProperty(target, property, out _))
                {
                    if (recordStats)
                    {
                        SweepStats.PropertiesSkippedPolicy++;
                    }

                    continue;
                }

                if (!TypicalValues.TryForProperty(target, property, out object? value))
                {
                    if (recordStats)
                    {
                        SweepStats.PropertiesSkippedUnmappable++;
                    }

                    continue; // No typical value for this type — counted, not a failure.
                }

                try
                {
                    property.SetValue(target, value);

                    // Read it back where readable: no exception is the primary assertion;
                    // a strict set/get round-trip is only guaranteed for trivial members,
                    // so the getter is exercised, not compared.
                    if (property.GetGetMethod() != null)
                    {
                        _ = property.GetValue(target);
                    }

                    if (recordStats)
                    {
                        SweepStats.PropertiesSet++;
                    }
                }
                catch (Exception ex)
                {
                    failures.AddDistinct(new SweepFailure(
                        "property",
                        $"{property.DeclaringType?.Name}.{property.Name}",
                        Describe(value),
                        Unwrap(ex)));
                }
            }
        }

        // ------------------------------------------------------------------ step 5: methods

        private static void SweepMethods(Control target, List<SweepFailure> failures, bool recordStats)
        {
            IEnumerable<MethodInfo> methods = target.GetType()
                .GetMethods(BindingFlags.Public | BindingFlags.Instance)
                .Where(static m => !m.IsSpecialName && !m.ContainsGenericParameters)
                // Only methods declared by the Krypton assemblies: the inherited
                // Control/Component surface is identical for every type and exercising it
                // per-type would only re-test WinForms itself.
                .Where(static m => m.DeclaringType != null && CoverageCatalogue.IsCoreAssembly(m.DeclaringType.Assembly))
                .OrderBy(static m => m.Name, StringComparer.Ordinal);

            foreach (MethodInfo method in methods)
            {
                if (method.GetCustomAttribute<ObsoleteAttribute>() != null)
                {
                    if (recordStats)
                    {
                        SweepStats.MethodsSkippedObsolete++;
                    }

                    continue;
                }

                ParameterInfo[] parameters = method.GetParameters();
                if (parameters.Any(static p => p.ParameterType.IsByRef || p.ParameterType.IsPointer))
                {
                    if (recordStats)
                    {
                        SweepStats.MethodsSkippedUnmappable++;
                    }

                    continue; // Spec deny: methods with out/ref (or pointer) parameters.
                }

                if (SweepPolicy.DenyMethod(target, method, out _))
                {
                    if (recordStats)
                    {
                        SweepStats.MethodsSkippedPolicy++;
                    }

                    continue;
                }

                var arguments = new object?[parameters.Length];
                bool mappable = true;
                for (int i = 0; i < parameters.Length; i++)
                {
                    if (!TypicalValues.TryForType(parameters[i].ParameterType, out arguments[i]))
                    {
                        mappable = false;
                        break;
                    }
                }

                if (!mappable)
                {
                    if (recordStats)
                    {
                        SweepStats.MethodsSkippedUnmappable++;
                    }

                    continue; // Parameters beyond the safe-primitive map — counted, not a failure.
                }

                try
                {
                    method.Invoke(target, arguments);
                    if (recordStats)
                    {
                        SweepStats.MethodsInvoked++;
                    }
                }
                catch (Exception ex)
                {
                    failures.AddDistinct(new SweepFailure(
                        "method",
                        $"{method.DeclaringType?.Name}.{method.Name}({string.Join(", ", parameters.Select(static p => p.ParameterType.Name))})",
                        string.Join(", ", arguments.Select(Describe)),
                        Unwrap(ex)));
                }
            }
        }

        // ------------------------------------------------------------------ helpers

        private static Exception Unwrap(Exception ex) =>
            ex is TargetInvocationException { InnerException: { } inner } ? inner : ex;

        private static string Describe(object? value) =>
            value switch
            {
                null => "null",
                string s => $"\"{s}\"",
                Font f => $"Font({f.Name} {f.Size}pt)",
                Bitmap b => $"Bitmap({b.Width}x{b.Height})",
                _ => value.ToString() ?? value.GetType().Name
            };

        private static void ResetGlobalPalette()
        {
            // GlobalPaletteMode proxies static toolkit state; a swept KryptonThemeComboBox (or
            // similar) may have switched it — always end each type on the toolkit default.
            using (var manager = new KryptonManager())
            {
                if (manager.GlobalPaletteMode != PaletteMode.Microsoft365Blue)
                {
                    manager.GlobalPaletteMode = PaletteMode.Microsoft365Blue;
                }
            }
        }
    }

    /// <summary>
    /// One captured sweep failure: control type + member + value + exception
    /// (the structured failure message the spec's bug-hunt requires).
    /// </summary>
    internal sealed class SweepFailure
    {
        public SweepFailure(string stage, string member, string value, Exception exception)
        {
            Stage = stage;
            Member = member;
            Value = value;
            Exception = exception;
        }

        public string Stage { get; }
        public string Member { get; }
        public string Value { get; }
        public Exception Exception { get; }

        public string Key => $"{Stage}|{Member}|{Exception.GetType().Name}";

        public static string Format(Type type, IReadOnlyCollection<SweepFailure> failures)
        {
            var sb = new StringBuilder();
            sb.AppendLine($"{type.FullName}: {failures.Count} functional-sweep failure(s):");
            foreach (SweepFailure failure in failures)
            {
                sb.AppendLine($"  [{failure.Stage}] {failure.Member} = {failure.Value}");
                sb.AppendLine($"      -> {failure.Exception.GetType().FullName}: {failure.Exception.Message}");
                string? frame = failure.Exception.StackTrace?
                    .Split('\n')
                    .Select(static l => l.Trim())
                    .FirstOrDefault(static l => l.Length > 0);
                if (frame != null)
                {
                    sb.AppendLine($"         {frame}");
                }
            }

            return sb.ToString();
        }
    }

    internal static class SweepFailureListExtensions
    {
        /// <summary>Adds a failure unless the same member already failed the same way (the recipe runs twice).</summary>
        public static void AddDistinct(this List<SweepFailure> failures, SweepFailure failure)
        {
            if (!failures.Any(f => f.Key == failure.Key))
            {
                failures.Add(failure);
            }
        }
    }

    /// <summary>Sweep statistics, accumulated across the fixture and dumped at teardown.</summary>
    internal static class SweepStats
    {
        public static int PropertiesSet;
        public static int PropertiesSkippedPolicy;
        public static int PropertiesSkippedObsolete;
        public static int PropertiesSkippedUnmappable;
        public static int MethodsInvoked;
        public static int MethodsSkippedPolicy;
        public static int MethodsSkippedObsolete;
        public static int MethodsSkippedUnmappable;

        public static void Dump()
        {
            Console.WriteLine("=== Functional sweep statistics ===");
            Console.WriteLine($"Types catalogued            : {CoverageCatalogue.Entries.Count} " +
                $"(hosted={CoverageCatalogue.Entries.Count(static e => e.Kind == SweepKind.HostedControl)}, " +
                $"forms={CoverageCatalogue.Entries.Count(static e => e.Kind == SweepKind.TopLevelForm)}, " +
                $"component-only={CoverageCatalogue.Entries.Count(static e => e.Kind == SweepKind.ComponentOnly)})");
            Console.WriteLine($"Types w/o public ctor       : {CoverageCatalogue.NoPublicCtorTypes.Count}");
            Console.WriteLine($"Types [Obsolete(error)]     : {CoverageCatalogue.ObsoleteErrorTypes.Count}");
            Console.WriteLine($"Properties set              : {PropertiesSet}");
            Console.WriteLine($"Properties skipped (policy) : {PropertiesSkippedPolicy}");
            Console.WriteLine($"Properties skipped (obsolete): {PropertiesSkippedObsolete}");
            Console.WriteLine($"Properties skipped (no map) : {PropertiesSkippedUnmappable}");
            Console.WriteLine($"Methods invoked             : {MethodsInvoked}");
            Console.WriteLine($"Methods skipped (policy)    : {MethodsSkippedPolicy}");
            Console.WriteLine($"Methods skipped (obsolete)  : {MethodsSkippedObsolete}");
            Console.WriteLine($"Methods skipped (no map)    : {MethodsSkippedUnmappable}");
        }
    }
}
