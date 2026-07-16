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
using System.Windows.Forms;

using Bastion.Krypton.UnitTests.Infrastructure;

using Krypton.Toolkit;

using NUnit.Framework;

namespace Bastion.Krypton.StressTests
{
    /// <summary>
    /// Spec §6.3 attack 5 — DPI and RTL torture, scoped to what a single test process can
    /// honestly cover. RTL: key controls rendered under RightToLeft=Yes plus
    /// RightToLeftLayout=true (mirrored window). DPI: process-level DPI awareness is fixed
    /// at CLR start and cannot be varied in-proc, so the achievable in-proc equivalent is
    /// exercised instead: the WinForms scaling pipeline (Control.Scale with the 125%/150%/
    /// 200% DPI ratios) applied to a live Krypton form. True multi-DPI/manifest coverage is
    /// a Phase 5d/CI concern — see Tests\README.md for the scope note.
    /// </summary>
    [TestFixture]
    [Category("Adversarial")]
    public class RtlAndDpiTests : UiTestBase
    {
        /// <summary>Key controls of spec §6.3.5 — one per major render family.</summary>
        private static readonly Type[] KeyControlTypes =
        {
            typeof(KryptonButton),
            typeof(KryptonLabel),
            typeof(KryptonTextBox),
            typeof(KryptonComboBox),
            typeof(KryptonCheckBox),
            typeof(KryptonRadioButton),
            typeof(KryptonDataGridView),
            typeof(KryptonHeaderGroup),
            typeof(KryptonMonthCalendar),
            typeof(KryptonPanel),
            typeof(global::Krypton.Navigator.KryptonNavigator),
            typeof(global::Krypton.Ribbon.KryptonRibbon),
            typeof(global::Krypton.Workspace.KryptonWorkspace),
        };

        /// <summary>One case per key control.</summary>
        public static IEnumerable<Type> KeyControls => KeyControlTypes;

        /// <summary>
        /// RTL torture: the control lives on a mirrored (RightToLeft=Yes +
        /// RightToLeftLayout=true) shown form, with RTL text where Text applies, is painted,
        /// resized and painted again — no defect-class exception allowed anywhere.
        /// </summary>
        [TestCaseSource(nameof(KeyControls))]
        public void KeyControl_RendersUnderRtlMirroredLayout(Type controlType)
        {
            List<AttackFailure> failures = AttackHarness.Run(controlType.FullName!, collected =>
            {
                var host = new KryptonForm
                {
                    StartPosition = FormStartPosition.Manual,
                    Location = new Point(0, 0),
                    ClientSize = new Size(700, 500),
                    ShowInTaskbar = false,
                    RightToLeft = RightToLeft.Yes,
                    RightToLeftLayout = true,
                    Text = "Bastion 5c RTL — اختبار בדיקה"
                };
                var target = (Control)Activator.CreateInstance(controlType)!;
                try
                {
                    target.Location = new Point(10, 10);
                    target.Size = new Size(400, 300);
                    AttackHarness.Attack(collected, "rtl", $"{controlType.Name}.RightToLeft", "Yes",
                        () => target.RightToLeft = RightToLeft.Yes);
                    host.Controls.Add(target);
                    host.Show();
                    StaMessagePump.Pump(80);

                    AttackHarness.Attack(collected, "rtl-text", $"{controlType.Name}.Text", "rtl string",
                        () => target.Text = "نص عربي וטקסט עברי");
                    StaMessagePump.Pump(40);

                    RenderNoThrow(target, "rtl-render", collected);

                    AttackHarness.Attack(collected, "rtl-resize", "host.Size", "900x620", () =>
                    {
                        host.Size = new Size(900, 620);
                        StaMessagePump.Pump(40);
                    });

                    RenderNoThrow(target, "rtl-render-after-resize", collected);
                }
                finally
                {
                    target.Dispose();
                    host.Dispose();
                    StaMessagePump.Pump(30);
                }
            });

            AttackHarness.AssertClean(controlType.FullName!, failures);
        }

        /// <summary>
        /// In-proc DPI-scaling equivalent: a KryptonForm hosting the key controls is pushed
        /// through the WinForms scaling pipeline at the 120/144/192-DPI ratios (1.25/1.5/2.0)
        /// and painted at each step — the same layout maths a real DPI change drives.
        /// </summary>
        [TestCase(1.25f, TestName = "ScalePipeline.120dpi")]
        [TestCase(1.50f, TestName = "ScalePipeline.144dpi")]
        [TestCase(2.00f, TestName = "ScalePipeline.192dpi")]
        public void KeyControls_SurviveScalingPipeline(float factor)
        {
            List<AttackFailure> failures = AttackHarness.Run($"scale-{factor:0.00}", collected =>
            {
                var host = new KryptonForm
                {
                    StartPosition = FormStartPosition.Manual,
                    Location = new Point(0, 0),
                    ClientSize = new Size(760, 520),
                    ShowInTaskbar = false,
                    Text = $"Bastion 5c scale x{factor:0.00}"
                };
                try
                {
                    var y = 8;
                    foreach (Type type in KeyControlTypes)
                    {
                        AttackHarness.Attack(collected, "scale-build", type.Name, "-", () =>
                        {
                            var control = (Control)Activator.CreateInstance(type)!;
                            control.Location = new Point(8, y);
                            control.Size = new Size(200, 32);
                            host.Controls.Add(control);
                        });
                        y += 36;
                    }

                    host.Show();
                    StaMessagePump.Pump(120);

                    AttackHarness.Attack(collected, "scale", "Form.Scale", $"x{factor:0.00}", () =>
                    {
                        host.Scale(new SizeF(factor, factor));
                        StaMessagePump.Pump(80);
                    });

                    foreach (Control control in host.Controls)
                    {
                        RenderNoThrow(control, $"scale-render-x{factor:0.00}", collected);
                    }

                    // And back down again (the round trip is where rounding bugs live).
                    AttackHarness.Attack(collected, "scale", "Form.Scale", $"x{1F / factor:0.000}", () =>
                    {
                        host.Scale(new SizeF(1F / factor, 1F / factor));
                        StaMessagePump.Pump(80);
                    });
                }
                finally
                {
                    host.Dispose();
                    StaMessagePump.Pump(30);
                }
            });

            AttackHarness.AssertClean($"scale-{factor:0.00}", failures);
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
