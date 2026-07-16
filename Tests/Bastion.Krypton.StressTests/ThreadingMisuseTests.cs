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
using System.Diagnostics;
using System.Threading;
using System.Windows.Forms;

using Bastion.Krypton.UnitTests.Infrastructure;

using Krypton.Toolkit;

using NUnit.Framework;

namespace Bastion.Krypton.StressTests
{
    /// <summary>
    /// Spec §6.3 attack 4 — threading misuse: property sets from a non-UI thread. The
    /// documented WinForms contract is asserted: with CheckForIllegalCrossThreadCalls
    /// enabled, a member that touches the window handle throws InvalidOperationException on
    /// the calling thread; a member that does not touch the handle completes benignly; and
    /// Control.Invoke marshals correctly. What is never acceptable: a crash (defect-class
    /// exception) or a deadlock (watchdog).
    /// </summary>
    [TestFixture]
    [Category("Adversarial")]
    public class ThreadingMisuseTests : UiTestBase
    {
        private const int WorkerTimeoutMs = 15_000;

        /// <summary>Representative controls whose Text path is handle-backed.</summary>
        private static readonly Type[] CrossThreadTargets =
        {
            typeof(KryptonButton),
            typeof(KryptonTextBox),
            typeof(KryptonComboBox),
            typeof(KryptonLabel),
            typeof(KryptonRichTextBox),
        };

        /// <summary>One case per representative control.</summary>
        public static IEnumerable<Type> Targets => CrossThreadTargets;

        /// <summary>
        /// Sets Text and Size from a worker thread with cross-thread checks on: each attempt
        /// must finish inside the watchdog and may only fail with the documented
        /// InvalidOperationException ("Cross-thread operation not valid").
        /// </summary>
        [TestCaseSource(nameof(Targets))]
        public void CrossThreadPropertySet_ThrowsDocumentedExceptionOrIsBenign(Type controlType)
        {
            List<AttackFailure> failures = AttackHarness.Run(controlType.FullName!, collected =>
            {
                bool previousCheck = Control.CheckForIllegalCrossThreadCalls;
                Control.CheckForIllegalCrossThreadCalls = true;
                var target = (Control)Activator.CreateInstance(controlType)!;
                KryptonForm host = AttackHarness.CreateShownHost(target, $"Bastion 5c threading — {controlType.Name}");
                try
                {
                    Assert.That(target.IsHandleCreated, Is.True, "Attack requires a live handle.");

                    RunOnWorker(collected, $"{controlType.Name}.Text", () => target.Text = "cross-thread");
                    RunOnWorker(collected, $"{controlType.Name}.Size", () => target.Size = new System.Drawing.Size(200, 60));
                    RunOnWorker(collected, $"{controlType.Name}.Enabled", () => target.Enabled = false);

                    // The control must still be usable from its own thread afterwards.
                    AttackHarness.Attack(collected, "post-cross-thread", $"{controlType.Name}.Text", "\"same-thread\"", () =>
                    {
                        target.Enabled = true;
                        target.Text = "same-thread";
                        StaMessagePump.Pump(30);
                    });
                }
                finally
                {
                    target.Dispose();
                    host.Dispose();
                    Control.CheckForIllegalCrossThreadCalls = previousCheck;
                    StaMessagePump.Pump(20);
                }
            });

            AttackHarness.AssertClean(controlType.FullName!, failures);
        }

        /// <summary>
        /// The correct consumer pattern must keep working: a worker thread marshals a Text
        /// set through Control.Invoke while the UI thread pumps — the set must land and the
        /// worker must complete without a deadlock.
        /// </summary>
        [Test]
        public void CrossThreadInvoke_MarshalsCorrectly()
        {
            List<AttackFailure> failures = AttackHarness.Run(nameof(KryptonButton), collected =>
            {
                using var target = new KryptonButton();
                KryptonForm host = AttackHarness.CreateShownHost(target, "Bastion 5c invoke marshal");
                try
                {
                    Exception? workerError = null;
                    using var done = new ManualResetEventSlim(false);
                    var worker = new Thread(() =>
                    {
                        try
                        {
                            target.Invoke((MethodInvoker)(() => target.Text = "invoked"));
                        }
                        catch (Exception ex)
                        {
                            workerError = ex;
                        }
                        finally
                        {
                            try
                            {
                                // ReSharper disable once AccessToDisposedClosure
                                done.Set();
                            }
                            catch (ObjectDisposedException)
                            {
                                // Watchdog already expired and disposed the event.
                            }
                        }
                    })
                    {
                        IsBackground = true,
                        Name = "Bastion cross-thread invoker"
                    };
                    worker.Start();

                    // Pump until the worker's Invoke has been serviced (or watchdog).
                    var stopwatch = Stopwatch.StartNew();
                    while (!done.IsSet && stopwatch.ElapsedMilliseconds < WorkerTimeoutMs)
                    {
                        StaMessagePump.Pump(10);
                    }

                    if (!done.IsSet)
                    {
                        collected.Add(new AttackFailure("invoke", "KryptonButton.Invoke", "-",
                            new TimeoutException($"Control.Invoke from a worker thread did not complete within {WorkerTimeoutMs} ms — deadlock.")));
                    }
                    else if (workerError != null)
                    {
                        collected.Add(new AttackFailure("invoke", "KryptonButton.Invoke", "-", workerError));
                    }
                    else
                    {
                        Assert.That(target.Text, Is.EqualTo("invoked"), "Marshalled property set did not land.");
                    }
                }
                finally
                {
                    host.Dispose();
                    StaMessagePump.Pump(20);
                }
            });

            AttackHarness.AssertClean(nameof(KryptonButton), failures);
        }

        // ------------------------------------------------------------------ helpers

        /// <summary>
        /// Runs one property set on a fresh worker thread. Outcomes: clean completion or the
        /// documented cross-thread InvalidOperationException pass; a defect-class exception
        /// or a watchdog expiry (deadlock) is a failure.
        /// </summary>
        private static void RunOnWorker(List<AttackFailure> failures, string member, Action set)
        {
            Exception? workerError = null;
            using var done = new ManualResetEventSlim(false);
            var worker = new Thread(() =>
            {
                try
                {
                    set();
                }
                catch (Exception ex)
                {
                    workerError = ex;
                }
                finally
                {
                    try
                    {
                        // ReSharper disable once AccessToDisposedClosure
                        done.Set();
                    }
                    catch (ObjectDisposedException)
                    {
                        // Watchdog already expired and disposed the event.
                    }
                }
            })
            {
                IsBackground = true,
                Name = "Bastion cross-thread attacker"
            };
            worker.Start();

            // Keep the UI thread pumping while the worker runs: a worker blocked on a
            // SendMessage into this thread would otherwise deadlock by construction.
            var stopwatch = Stopwatch.StartNew();
            while (!done.IsSet && stopwatch.ElapsedMilliseconds < WorkerTimeoutMs)
            {
                StaMessagePump.Pump(10);
            }

            if (!done.IsSet)
            {
                failures.Add(new AttackFailure("cross-thread", member, "-",
                    new TimeoutException($"Cross-thread property set did not complete within {WorkerTimeoutMs} ms — deadlock.")));
                return;
            }

            if (workerError is InvalidOperationException)
            {
                return; // The documented cross-thread rejection.
            }

            if (workerError != null)
            {
                failures.Add(new AttackFailure("cross-thread", member, "-", workerError));
            }
        }
    }
}
