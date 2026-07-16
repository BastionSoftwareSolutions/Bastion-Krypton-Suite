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
using System.Drawing;
using System.Linq;
using System.Reflection;
using System.Windows.Forms;

using Bastion.Krypton.FunctionalTests;

using Bastion.Krypton.UnitTests.Infrastructure;

using Krypton.Toolkit;

using NUnit.Framework;

namespace Bastion.Krypton.StressTests
{
    /// <summary>
    /// Spec §6.3 attack 2 — null and disposal abuse: null palettes/images wherever the
    /// property type allows, setting properties after Dispose (ObjectDisposedException or
    /// benign — never a defect-class crash), disposing mid-paint, double-dispose, and using
    /// controls whose parent form has been disposed.
    /// </summary>
    [TestFixture]
    [Category("Adversarial")]
    public class NullAndDisposalAbuseTests : UiTestBase
    {
        /// <summary>One test case per hosted control (reflection catalogue reuse).</summary>
        public static IEnumerable<TestCaseData> HostedControlCases =>
            CoverageCatalogue.Entries
                .Where(static e => e.Kind == SweepKind.HostedControl)
                .Select(static e => new TestCaseData(e.Type).SetName($"NullDispose.{e.Type.FullName}"));

        /// <summary>
        /// Nulls into every public writable Image/Icon/PaletteBase-typed property of the
        /// hosted control while it is live on a shown form; then property sets after Dispose;
        /// then dispose-mid-paint on a fresh instance.
        /// </summary>
        [TestCaseSource(nameof(HostedControlCases))]
        public void HostedControl_SurvivesNullAndDisposalAbuse(Type controlType)
        {
            List<AttackFailure> failures = AttackHarness.Run(controlType.FullName!, collected =>
            {
                NullReferenceTypedProperties(controlType, collected);
                SetPropertiesAfterDispose(controlType, collected);
                DisposeMidPaint(controlType, collected);
            });

            AttackHarness.AssertClean(controlType.FullName!, failures);
        }

        /// <summary>
        /// Double-dispose across every catalogued type of the five core assemblies
        /// (hosted controls, forms and invisible components alike): Dispose must be
        /// idempotent — the second call may not throw anything.
        /// </summary>
        [Test]
        public void AllCataloguedTypes_DoubleDispose_IsIdempotent()
        {
            List<AttackFailure> failures = AttackHarness.Run("double-dispose", collected =>
            {
                foreach (CoverageCatalogue.Entry entry in CoverageCatalogue.Entries)
                {
                    IDisposable? instance = null;
                    try
                    {
                        instance = (IDisposable)Activator.CreateInstance(entry.Type)!;
                    }
                    catch (Exception ex)
                    {
                        collected.Add(new AttackFailure("instantiate", entry.Type.Name, "-", ex));
                        continue;
                    }

                    try
                    {
                        instance.Dispose();
                        instance.Dispose(); // The attack: second dispose must be a no-op.
                    }
                    catch (Exception ex)
                    {
                        collected.Add(new AttackFailure("double-dispose", entry.Type.Name, "-", ex));
                    }
                }
            }, timeoutMs: 180_000);

            AttackHarness.AssertClean("double-dispose", failures);
        }

        /// <summary>
        /// Using controls whose parent form has been disposed: the form is disposed out from
        /// under the control (which disposes the child with it); afterwards reading and
        /// writing members must yield ObjectDisposedException or benign behaviour — never a
        /// defect-class exception.
        /// </summary>
        [Test]
        public void HostedControls_ParentFormDisposed_MembersFailGracefully()
        {
            List<AttackFailure> failures = AttackHarness.Run("parent-disposed", collected =>
            {
                foreach (CoverageCatalogue.Entry entry in CoverageCatalogue.Entries
                             .Where(static e => e.Kind == SweepKind.HostedControl))
                {
                    Control target;
                    try
                    {
                        target = (Control)Activator.CreateInstance(entry.Type)!;
                    }
                    catch (Exception ex)
                    {
                        collected.Add(new AttackFailure("instantiate", entry.Type.Name, "-", ex));
                        continue;
                    }

                    KryptonForm host = AttackHarness.CreateShownHost(target, $"Bastion 5c parent-disposed — {entry.Type.Name}");
                    host.Dispose(); // Disposes the child control with it.
                    StaMessagePump.Pump(20);

                    AttackAfterDisposal(target, entry.Type.Name, collected);
                }
            }, timeoutMs: 300_000);

            AttackHarness.AssertClean("parent-disposed", failures);
        }

        /// <summary>
        /// Targeted null-palette abuse on the toolkit-level palette surfaces
        /// (KryptonManager global custom palette and a control-level LocalCustomPalette).
        /// </summary>
        [Test]
        public void PaletteSurfaces_AcceptOrRejectNullGracefully()
        {
            List<AttackFailure> failures = AttackHarness.Run("null-palettes", collected =>
            {
                using var manager = new KryptonManager();
                AttackHarness.Attack(collected, "null", "KryptonManager.GlobalCustomPalette", "null",
                    () => manager.GlobalCustomPalette = null);

                using var button = new KryptonButton();
                KryptonForm host = AttackHarness.CreateShownHost(button, "Bastion 5c null palette");
                try
                {
                    AttackHarness.Attack(collected, "null", "KryptonButton.LocalCustomPalette", "custom-then-null", () =>
                    {
                        using var palette = new KryptonCustomPaletteBase();
                        button.LocalCustomPalette = palette;
                        StaMessagePump.Pump(20);
                        button.LocalCustomPalette = null;
                        StaMessagePump.Pump(20);
                    });
                }
                finally
                {
                    host.Dispose();
                }
            });

            AttackHarness.AssertClean("null-palettes", failures);
        }

        // ------------------------------------------------------------------ attack stages

        private static void NullReferenceTypedProperties(Type controlType, List<AttackFailure> failures)
        {
            if (AdversarialPolicy.Skip(controlType, "null", out _))
            {
                return;
            }

            var target = (Control)Activator.CreateInstance(controlType)!;
            KryptonForm host = AttackHarness.CreateShownHost(target, $"Bastion 5c null — {controlType.Name}");
            try
            {
                IEnumerable<PropertyInfo> nullableTargets = controlType
                    .GetProperties(BindingFlags.Public | BindingFlags.Instance)
                    .Where(static p => p.GetSetMethod() != null &&
                                       p.GetIndexParameters().Length == 0 &&
                                       p.GetCustomAttribute<ObsoleteAttribute>() == null &&
                                       IsNullAttackType(p.PropertyType))
                    .GroupBy(static p => p.Name, StringComparer.Ordinal)
                    .Select(static g => g.First());

                foreach (PropertyInfo property in nullableTargets)
                {
                    AttackHarness.Attack(failures, "null", $"{controlType.Name}.{property.Name}", "null", () =>
                    {
                        try
                        {
                            property.SetValue(target, null);
                        }
                        catch (TargetInvocationException tie) when (tie.InnerException != null)
                        {
                            throw tie.InnerException;
                        }

                        if (property.GetGetMethod() != null)
                        {
                            try
                            {
                                _ = property.GetValue(target);
                            }
                            catch (TargetInvocationException tie) when (tie.InnerException != null)
                            {
                                throw tie.InnerException;
                            }
                        }
                    });
                }

                StaMessagePump.Pump(30);
            }
            finally
            {
                target.Dispose();
                host.Dispose();
                StaMessagePump.Pump(20);
            }
        }

        /// <summary>Reference types where a null set is a legitimate consumer mistake to probe.</summary>
        private static bool IsNullAttackType(Type propertyType) =>
            propertyType == typeof(Image) ||
            propertyType == typeof(Bitmap) ||
            propertyType == typeof(Icon) ||
            typeof(PaletteBase).IsAssignableFrom(propertyType);

        private static void SetPropertiesAfterDispose(Type controlType, List<AttackFailure> failures)
        {
            var target = (Control)Activator.CreateInstance(controlType)!;
            KryptonForm host = AttackHarness.CreateShownHost(target, $"Bastion 5c after-dispose — {controlType.Name}");
            try
            {
                target.Dispose();
                StaMessagePump.Pump(20);
                AttackAfterDisposal(target, controlType.Name, failures);
            }
            finally
            {
                host.Dispose();
                StaMessagePump.Pump(20);
            }
        }

        /// <summary>
        /// The post-disposal contract (spec §6.3.2): a member access on a disposed control
        /// must be benign or throw ObjectDisposedException/InvalidOperationException — never
        /// a defect-class exception. The graceful-rejection rule already encodes exactly
        /// that, so the standard Attack classification applies.
        /// </summary>
        private static void AttackAfterDisposal(Control target, string typeName, List<AttackFailure> failures)
        {
            AttackHarness.Attack(failures, "after-dispose", $"{typeName}.Text", "\"disposed\"", () =>
            {
                if (!AdversarialPolicy.Skip(target.GetType(), "text", out _))
                {
                    target.Text = "disposed";
                    _ = target.Text;
                }
            });
            AttackHarness.Attack(failures, "after-dispose", $"{typeName}.Enabled", "toggle", () =>
            {
                target.Enabled = !target.Enabled;
            });
            AttackHarness.Attack(failures, "after-dispose", $"{typeName}.Font", "9pt", () =>
            {
                target.Font = new Font("Segoe UI", 9F);
            });
            AttackHarness.Attack(failures, "after-dispose", $"{typeName}.Size", "64x32", () =>
            {
                target.Size = new Size(64, 32);
            });
            AttackHarness.Attack(failures, "after-dispose", $"{typeName}.Refresh()", "-", target.Refresh);
        }

        private static void DisposeMidPaint(Type controlType, List<AttackFailure> failures)
        {
            if (AdversarialPolicy.Skip(controlType, "dispose-mid-paint", out _) ||
                AdversarialPolicy.Skip(controlType, "*", out _))
            {
                return;
            }

            var target = (Control)Activator.CreateInstance(controlType)!;
            KryptonForm host = AttackHarness.CreateShownHost(target, $"Bastion 5c dispose-mid-paint — {controlType.Name}");
            try
            {
                var disposed = false;
                target.Paint += (_, _) =>
                {
                    if (!disposed)
                    {
                        disposed = true;
                        // The attack: dispose the control from inside its own Paint handler.
                        // Escaping exceptions surface via WndProc/ThreadException and are
                        // collected by the harness trap.
                        target.Dispose();
                    }
                };

                target.Invalidate();
                StaMessagePump.Pump(120);

                if (!disposed)
                {
                    // Some controls only repaint on demand — force a paint cycle.
                    AttackHarness.Attack(failures, "dispose-mid-paint", $"{controlType.Name}.Refresh()", "-", target.Refresh);
                    StaMessagePump.Pump(80);
                }
            }
            finally
            {
                try
                {
                    target.Dispose();
                }
                catch (Exception ex)
                {
                    failures.Add(new AttackFailure("dispose-mid-paint", $"{controlType.Name}.Dispose()", "-", ex));
                }

                host.Dispose();
                StaMessagePump.Pump(30);
            }
        }
    }
}
