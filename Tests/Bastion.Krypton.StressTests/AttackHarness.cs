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
using System.Runtime.InteropServices;
using System.Text;
using System.Threading;
using System.Windows.Forms;

using Bastion.Krypton.UnitTests.Infrastructure;

using Krypton.Toolkit;

using NUnit.Framework;

namespace Bastion.Krypton.StressTests
{
    /// <summary>
    /// Shared plumbing for the adversarial suite (spec §6.3): the STA body wrapper (message
    /// pump + <see cref="Application.ThreadException"/> trap + global-palette reset), the
    /// exception classification that separates by-design rejections from pattern-matching
    /// defects, and the structured failure record.
    /// </summary>
    public static class AttackHarness
    {
        /// <summary>
        /// Runs an adversarial body on the STA pump thread with the reflected-WndProc
        /// exception trap installed (see BREAKAGE-LOG Phase 5b F4: on .NET Framework an
        /// exception escaping a reflected WndProc routes to Application.ThreadException and,
        /// unhandled, raises a modal dialog that presents as a hang). Any trapped thread
        /// exception is recorded as a failure. Ends by resetting the global palette.
        /// </summary>
        /// <param name="context">Name used in failure messages (usually the type under attack).</param>
        /// <param name="body">Attack body; receives the failure list to append to.</param>
        /// <param name="timeoutMs">Watchdog for the whole body (a hang is a finding).</param>
        /// <returns>The collected failures (empty when the attack found nothing).</returns>
        public static List<AttackFailure> Run(string context, Action<List<AttackFailure>> body, int timeoutMs = 120_000)
        {
            var failures = new List<AttackFailure>();
            StaMessagePump.Run(() =>
            {
                ThreadExceptionEventHandler trap = (_, e) =>
                    failures.Add(new AttackFailure("threadexception", context, "-", e.Exception));
                Application.ThreadException += trap;
                try
                {
                    body(failures);
                }
                finally
                {
                    Application.ThreadException -= trap;
                    ResetGlobalPalette();
                }
            }, timeoutMs);

            return failures;
        }

        /// <summary>Fails the test with a structured report if any failures were collected.</summary>
        public static void AssertClean(string context, List<AttackFailure> failures)
        {
            if (failures.Count > 0)
            {
                Assert.Fail(AttackFailure.Format(context, failures));
            }
        }

        /// <summary>
        /// Executes one attack action and classifies the outcome: success and by-design
        /// (graceful) rejections pass; defect-class exceptions are recorded as failures.
        /// </summary>
        public static void Attack(List<AttackFailure> failures, string stage, string member, string value, Action action)
        {
            try
            {
                action();
            }
            catch (Exception ex) when (IsGracefulRejection(ex))
            {
                // By-design rejection of an absurd value: a documented, catchable contract
                // exception is exactly the correct behaviour under attack.
            }
            catch (Exception ex)
            {
                failures.Add(new AttackFailure(stage, member, value, ex));
            }
        }

        /// <summary>
        /// The adversarial acceptance rule (spec §6.3): under attack, a control may reject the
        /// value with a contract exception — that is graceful. What it may never do is fail
        /// with a defect-class exception: NRE / index-out-of-range / arithmetic (the classic
        /// zero-size divide) / native access violations, which evidence a pattern-matching
        /// bug rather than a validated rejection.
        /// </summary>
        public static bool IsGracefulRejection(Exception ex) => !IsDefectClass(ex);

        /// <summary>Defect-class exceptions: never acceptable, whatever the input.</summary>
        public static bool IsDefectClass(Exception ex) =>
            ex is NullReferenceException
                or IndexOutOfRangeException
                or ArithmeticException // DivideByZeroException/OverflowException from unguarded layout maths
                or AccessViolationException
                or SEHException
                or ArrayTypeMismatchException
                or InvalidCastException
                or OutOfMemoryException
                or StackOverflowException;

        /// <summary>
        /// Creates the standard shown host form for a control under attack (mirrors the
        /// Phase 5b recipe host so findings are comparable).
        /// </summary>
        public static KryptonForm CreateShownHost(Control target, string caption)
        {
            var host = new KryptonForm
            {
                StartPosition = FormStartPosition.Manual,
                Location = new Point(0, 0),
                ClientSize = new Size(700, 500),
                ShowInTaskbar = false,
                Text = caption
            };
            target.Location = new Point(10, 10);
            target.Size = new Size(280, 100);
            host.Controls.Add(target);
            host.Show();
            StaMessagePump.Pump(60);
            return host;
        }

        /// <summary>
        /// GlobalPaletteMode proxies static toolkit state; attacks may have switched it —
        /// always end on the toolkit default (same rule as the Phase 5b sweep).
        /// </summary>
        public static void ResetGlobalPalette()
        {
            using var manager = new KryptonManager();
            if (manager.GlobalPaletteMode != PaletteMode.Microsoft365Blue)
            {
                manager.GlobalPaletteMode = PaletteMode.Microsoft365Blue;
            }
        }

        /// <summary>
        /// Every concrete <see cref="PaletteMode"/> that names a real theme — the storm set.
        /// <see cref="PaletteMode.Global"/> (defer-to-manager indirection) and
        /// <see cref="PaletteMode.Custom"/> (requires a custom palette instance) are not
        /// concrete themes and are excluded by design.
        /// </summary>
        public static PaletteMode[] AllConcretePaletteModes { get; } =
            Enum.GetValues(typeof(PaletteMode))
                .Cast<PaletteMode>()
                .Where(static m => m != PaletteMode.Global && m != PaletteMode.Custom)
                .ToArray();
    }

    /// <summary>One captured adversarial failure: stage + member + value + exception.</summary>
    public sealed class AttackFailure
    {
        /// <summary>Initialises a captured failure.</summary>
        public AttackFailure(string stage, string member, string value, Exception exception)
        {
            Stage = stage;
            Member = member;
            Value = value;
            Exception = exception;
        }

        /// <summary>Attack stage (e.g. "text", "size", "dispose-mid-paint").</summary>
        public string Stage { get; }

        /// <summary>Member or type under attack.</summary>
        public string Member { get; }

        /// <summary>Description of the attack value.</summary>
        public string Value { get; }

        /// <summary>The defect-class exception observed.</summary>
        public Exception Exception { get; }

        /// <summary>Formats a structured multi-failure report.</summary>
        public static string Format(string context, IReadOnlyCollection<AttackFailure> failures)
        {
            var sb = new StringBuilder();
            sb.AppendLine($"{context}: {failures.Count} adversarial failure(s):");
            foreach (AttackFailure failure in failures)
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
}
