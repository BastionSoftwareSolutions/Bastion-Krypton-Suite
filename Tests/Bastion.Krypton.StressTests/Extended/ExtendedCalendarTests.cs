#region BSD License
/*
 * New (Bastion) file in a work derived from BSD-3-Clause licensed code:
 * © Component Factory Pty Ltd, 2006 - 2016. Then modifications by Peter Wagner (aka Wagnerp),
 * Simon Coghlan (aka Smurf-IV), Giduac, Ahmed Abdelhameed, Lesandro & tobitege et al. 2017 - 2026.
 * © Bastion Software Solutions Ltd 2026. All rights reserved.
 */
#endregion

// Extended-module attacks: net48 + net8.0-windows only (scope note in Tests\README.md).
#if BASTION_EXTENDED

using System;
using System.Collections.Generic;
using System.Drawing;
using System.Globalization;
using System.Threading;
using System.Windows.Forms;

using Bastion.Krypton.UnitTests.Infrastructure;

using Krypton.Toolkit;

using Krypton.Toolkit.Suite.Extended.Calendar;

using NUnit.Framework;

namespace Bastion.Krypton.StressTests.Extended
{
    /// <summary>
    /// Spec §6.3 attack 7 (v1.1) — KryptonCalendar torture: extreme view/selection date
    /// ranges (DateTime.MinValue/MaxValue edges, inverted ranges) and culture switches
    /// including RTL and non-Gregorian default calendars (ar-SA Umm al-Qura, fa-IR Persian,
    /// th-TH Buddhist, he-IL Hebrew locale).
    /// </summary>
    [TestFixture]
    [Category("Adversarial")]
    public class ExtendedCalendarTests : UiTestBase
    {
        /// <summary>Extreme and inverted date ranges must reject gracefully, never crash.</summary>
        [Test]
        public void Calendar_ExtremeDateRanges_RejectGracefullyOrRender()
        {
            List<AttackFailure> failures = AttackHarness.Run("calendar-dates", collected =>
            {
                WithShownCalendar(collected, calendar =>
                {
                    (string Label, DateTime Start, DateTime End)[] ranges =
                    {
                        ("min-edge", DateTime.MinValue, DateTime.MinValue.AddDays(20)),
                        ("max-edge", DateTime.MaxValue.AddDays(-20), DateTime.MaxValue),
                        ("inverted", new DateTime(2026, 7, 20), new DateTime(2026, 7, 1)),
                        ("single-tick", new DateTime(2026, 7, 15), new DateTime(2026, 7, 15)),
                        ("normal", new DateTime(2026, 7, 1), new DateTime(2026, 7, 28)),
                    };

                    foreach ((string label, DateTime start, DateTime end) in ranges)
                    {
                        AttackHarness.Attack(collected, "calendar-range", "SetViewRange", label, () =>
                        {
                            calendar.SetViewRange(start, end);
                            StaMessagePump.Pump(60);
                        });

                        RenderNoThrow(calendar, $"calendar-render-{label}", collected);
                    }

                    AttackHarness.Attack(collected, "calendar-selection", "SelectionStart/End extremes", "-", () =>
                    {
                        calendar.SelectionStart = DateTime.MinValue;
                        calendar.SelectionEnd = DateTime.MaxValue;
                        StaMessagePump.Pump(40);
                    });
                });
            }, timeoutMs: 300_000);

            AttackHarness.AssertClean("calendar-dates", failures);
        }

        /// <summary>
        /// Culture switch torture: the calendar is created, ranged and painted under RTL and
        /// non-Gregorian-default cultures; the thread culture is always restored.
        /// </summary>
        [Test]
        public void Calendar_CultureSwitches_RtlAndNonGregorian()
        {
            List<AttackFailure> failures = AttackHarness.Run("calendar-cultures", collected =>
            {
                CultureInfo originalCulture = Thread.CurrentThread.CurrentCulture;
                CultureInfo originalUiCulture = Thread.CurrentThread.CurrentUICulture;
                try
                {
                    foreach (string cultureName in new[] { "ar-SA", "he-IL", "fa-IR", "th-TH", "ja-JP" })
                    {
                        string captured = cultureName;
                        AttackHarness.Attack(collected, "calendar-culture", "culture lifecycle", captured, () =>
                        {
                            var culture = CultureInfo.GetCultureInfo(captured);
                            Thread.CurrentThread.CurrentCulture = culture;
                            Thread.CurrentThread.CurrentUICulture = culture;

                            WithShownCalendar(collected, calendar =>
                            {
                                if (culture.TextInfo.IsRightToLeft)
                                {
                                    calendar.RightToLeft = RightToLeft.Yes;
                                }

                                calendar.SetViewRange(new DateTime(2026, 7, 1), new DateTime(2026, 7, 28));
                                StaMessagePump.Pump(60);
                                RenderNoThrow(calendar, $"calendar-culture-render-{captured}", collected);
                            });
                        });
                    }
                }
                finally
                {
                    Thread.CurrentThread.CurrentCulture = originalCulture;
                    Thread.CurrentThread.CurrentUICulture = originalUiCulture;
                }
            }, timeoutMs: 300_000);

            AttackHarness.AssertClean("calendar-cultures", failures);
        }

        // ------------------------------------------------------------------ helpers

        private static void WithShownCalendar(List<AttackFailure> failures, Action<KryptonCalendar> action)
        {
            var host = new KryptonForm
            {
                StartPosition = FormStartPosition.Manual,
                Location = new Point(0, 0),
                ClientSize = new Size(900, 650),
                ShowInTaskbar = false,
                Text = "Bastion 5c calendar torture"
            };
            var calendar = new KryptonCalendar { Dock = DockStyle.Fill };
            try
            {
                host.Controls.Add(calendar);
                host.Show();
                StaMessagePump.Pump(100);
                action(calendar);
            }
            catch (Exception ex) when (!(ex is AssertionException))
            {
                failures.Add(new AttackFailure("calendar-scenario", "build/run", "-", ex));
            }
            finally
            {
                calendar.Dispose();
                host.Dispose();
                StaMessagePump.Pump(50);
            }
        }

        private static void RenderNoThrow(Control target, string stage, List<AttackFailure> failures)
        {
            AttackHarness.Attack(failures, stage, $"{target.GetType().Name}.DrawToBitmap", "-", () =>
            {
                if (target.Width > 0 && target.Height > 0)
                {
                    using var bitmap = new Bitmap(target.Width, target.Height);
                    target.DrawToBitmap(bitmap, new Rectangle(0, 0, target.Width, target.Height));
                }
            });
        }
    }
}

#endif
