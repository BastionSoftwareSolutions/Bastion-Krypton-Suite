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
using System.Text;
using System.Windows.Forms;

using Bastion.Krypton.FunctionalTests;

using Bastion.Krypton.UnitTests.Infrastructure;

using Krypton.Toolkit;

using NUnit.Framework;

namespace Bastion.Krypton.StressTests
{
    /// <summary>
    /// Spec §6.3 attack 1 — extreme property values: int.MaxValue/MinValue sizes, negative
    /// padding, zero-size forms, absurd fonts (1pt/500pt), empty and 1MB strings, RTL text,
    /// surrogate pairs, control characters and embedded NUL — applied to the Text/size/
    /// padding/font members of every hosted control of the five core assemblies. A control
    /// may reject an absurd value with a contract exception (graceful); defect-class
    /// exceptions (NRE, index-out-of-range, unguarded arithmetic, AV) fail the test.
    /// </summary>
    [TestFixture]
    [Category("Adversarial")]
    public class ExtremePropertyValueTests : UiTestBase
    {
        /// <summary>The attack strings of spec §6.3.1, each with a short label for reporting.</summary>
        internal static readonly (string Label, string Value)[] AttackStrings =
        {
            ("empty", string.Empty),
            ("1MB", new string('K', 1024 * 1024)),
            ("rtl", "مرحبا שלום abc في"),
            ("surrogate-pairs", "\U0001F600\U0001D518\U0001F680 pair\U0001F469‍\U0001F4BB"),
            ("control-chars", "abc\bd\te\rf\ng"),
            ("embedded-nul", "before\0after"),
            ("nul-only", "\0"),
        };

        /// <summary>The attack sizes of spec §6.3.1.</summary>
        private static readonly (string Label, Size Value)[] AttackSizes =
        {
            ("int.MaxValue", new Size(int.MaxValue, int.MaxValue)),
            ("int.MinValue", new Size(int.MinValue, int.MinValue)),
            ("negative", new Size(-100, -100)),
            ("zero", new Size(0, 0)),
            ("mixed-extreme", new Size(int.MaxValue, 0)),
        };

        /// <summary>One test case per hosted control of the five core assemblies (reflection catalogue reuse).</summary>
        public static IEnumerable<TestCaseData> HostedControlCases =>
            CoverageCatalogue.Entries
                .Where(static e => e.Kind == SweepKind.HostedControl)
                .Select(static e => new TestCaseData(e.Type).SetName($"Extreme.{e.Type.FullName}"));

        /// <summary>Applies every §6.3.1 attack to one hosted control on a real shown form.</summary>
        [TestCaseSource(nameof(HostedControlCases))]
        public void HostedControl_SurvivesExtremePropertyValues(Type controlType)
        {
            List<AttackFailure> failures = AttackHarness.Run(controlType.FullName!, collected =>
            {
                var target = (Control)Activator.CreateInstance(controlType)!;
                KryptonForm host = AttackHarness.CreateShownHost(target, $"Bastion 5c extreme — {controlType.Name}");
                try
                {
                    AttackText(target, collected);
                    AttackSizeAndLocation(target, collected);
                    AttackPadding(target, collected);
                    AttackFonts(target, collected);

                    // The control must still be able to paint after the whole barrage.
                    AttackHarness.Attack(collected, "post-attack-render", controlType.Name, "-", () =>
                    {
                        if (target.Width > 0 && target.Height > 0 && !AdversarialPolicy.Skip(controlType, "*", out _))
                        {
                            using var bitmap = new Bitmap(target.Width, target.Height);
                            target.DrawToBitmap(bitmap, new Rectangle(0, 0, target.Width, target.Height));
                        }
                    });
                }
                finally
                {
                    SafeDispose(target, controlType.Name, collected);
                    SafeDispose(host, $"{controlType.Name} host", collected);
                    StaMessagePump.Pump(30);
                }
            });

            AttackHarness.AssertClean(controlType.FullName!, failures);
        }

        /// <summary>Spec §6.3.1 "zero-size forms": zero and negative client sizes on a shown KryptonForm.</summary>
        [Test]
        public void KryptonForm_SurvivesZeroAndNegativeSizes()
        {
            List<AttackFailure> failures = AttackHarness.Run(nameof(KryptonForm), collected =>
            {
                using var form = new KryptonForm
                {
                    StartPosition = FormStartPosition.Manual,
                    Location = new Point(0, 0),
                    ShowInTaskbar = false,
                    Text = "Bastion 5c zero-size form"
                };
                form.Controls.Add(new KryptonButton { Text = "content", Dock = DockStyle.Fill });
                form.Show();
                StaMessagePump.Pump(60);

                foreach ((string label, Size size) in AttackSizes)
                {
                    AttackHarness.Attack(collected, "form-size", "KryptonForm.Size", label, () =>
                    {
                        form.Size = size;
                        StaMessagePump.Pump(30);
                    });
                    AttackHarness.Attack(collected, "form-clientsize", "KryptonForm.ClientSize", label, () =>
                    {
                        form.ClientSize = size;
                        StaMessagePump.Pump(30);
                    });
                }

                AttackHarness.Attack(collected, "form-restore", "KryptonForm.ClientSize", "300x200", () =>
                {
                    form.ClientSize = new Size(300, 200);
                    StaMessagePump.Pump(30);
                });
            });

            AttackHarness.AssertClean(nameof(KryptonForm), failures);
        }

        // ------------------------------------------------------------------ attack stages

        private static void AttackText(Control target, List<AttackFailure> failures)
        {
            if (AdversarialPolicy.Skip(target.GetType(), "text", out _))
            {
                return; // Justified in AdversarialPolicy.
            }

            foreach ((string label, string value) in AttackStrings)
            {
                AttackHarness.Attack(failures, "text", $"{target.GetType().Name}.Text", label, () =>
                {
                    target.Text = value;
                    _ = target.Text;
                    StaMessagePump.Pump(10);
                });
            }

            // Leave a small text behind: a lingering 1MB string would make every later
            // layout/paint of this control pathologically slow and mask other findings.
            AttackHarness.Attack(failures, "text", $"{target.GetType().Name}.Text", "restore", () => target.Text = "post");
        }

        private static void AttackSizeAndLocation(Control target, List<AttackFailure> failures)
        {
            if (AdversarialPolicy.Skip(target.GetType(), "size", out _))
            {
                return;
            }

            foreach ((string label, Size size) in AttackSizes)
            {
                AttackHarness.Attack(failures, "size", $"{target.GetType().Name}.Size", label, () =>
                {
                    target.Size = size;
                    StaMessagePump.Pump(10);
                });
            }

            AttackHarness.Attack(failures, "location", $"{target.GetType().Name}.Location", "int extremes", () =>
            {
                target.Location = new Point(int.MaxValue, int.MaxValue);
                target.Location = new Point(int.MinValue, int.MinValue);
                StaMessagePump.Pump(10);
            });

            AttackHarness.Attack(failures, "size", $"{target.GetType().Name}.Size", "restore", () =>
            {
                target.Location = new Point(10, 10);
                target.Size = new Size(280, 100);
                StaMessagePump.Pump(10);
            });
        }

        private static void AttackPadding(Control target, List<AttackFailure> failures)
        {
            if (AdversarialPolicy.Skip(target.GetType(), "padding", out _))
            {
                return;
            }

            foreach ((string label, Padding value) in new[]
                     {
                         ("negative", new Padding(-10)),
                         ("very-negative", new Padding(int.MinValue / 4)),
                         ("huge", new Padding(int.MaxValue / 4)),
                         ("restore", new Padding(0)),
                     })
            {
                AttackHarness.Attack(failures, "padding", $"{target.GetType().Name}.Padding", label, () =>
                {
                    target.Padding = value;
                    StaMessagePump.Pump(10);
                });

                AttackHarness.Attack(failures, "margin", $"{target.GetType().Name}.Margin", label, () =>
                {
                    target.Margin = value;
                    StaMessagePump.Pump(5);
                });
            }
        }

        private static void AttackFonts(Control target, List<AttackFailure> failures)
        {
            if (AdversarialPolicy.Skip(target.GetType(), "font", out _))
            {
                return;
            }

            // Fonts stay alive after assignment (the control keeps the reference); the
            // finaliser reclaims them — deliberately not disposed here.
            foreach ((string label, float size) in new[] { ("1pt", 1F), ("500pt", 500F) })
            {
                AttackHarness.Attack(failures, "font", $"{target.GetType().Name}.Font", label, () =>
                {
                    target.Font = new Font(FontFamily.GenericSansSerif, size);
                    StaMessagePump.Pump(10);
                });
            }

            AttackHarness.Attack(failures, "font", $"{target.GetType().Name}.Font", "restore", () =>
            {
                target.Font = new Font("Segoe UI", 9F);
                StaMessagePump.Pump(10);
            });
        }

        private static void SafeDispose(Control control, string what, List<AttackFailure> failures)
        {
            try
            {
                control.Dispose();
            }
            catch (Exception ex)
            {
                // Disposal after an attack barrage must never throw at all.
                failures.Add(new AttackFailure("dispose", what, "-", ex));
            }
        }
    }
}
