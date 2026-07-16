#region BSD License
/*
 * New (Bastion) file in a work derived from BSD-3-Clause licensed code:
 * © Component Factory Pty Ltd, 2006 - 2016. Then modifications by Peter Wagner (aka Wagnerp),
 * Simon Coghlan (aka Smurf-IV), Giduac, Ahmed Abdelhameed, Lesandro & tobitege et al. 2017 - 2026.
 * © Bastion Software Solutions Ltd 2026. All rights reserved.
 */
#endregion

using System;
using System.Diagnostics;
using System.Runtime.ExceptionServices;
using System.Threading;
using System.Windows.Forms;

namespace Bastion.Krypton.UnitTests.Infrastructure
{
    /// <summary>
    /// Runs a test body on a dedicated STA thread with a WinForms message pump available
    /// (spec §6.1: "WinForms tests run STA with a message pump helper").
    /// </summary>
    /// <remarks>
    /// The STA thread is put into <see cref="UnhandledExceptionMode.ThrowException"/> (thread
    /// scope) before any control is created, so exceptions escaping a <c>WndProc</c> — the
    /// classic presentation of the dispose-time bugs in BREAKAGE-LOG items 1-2 — propagate as
    /// test failures instead of the modal thread-exception dialog (which presents as a hang
    /// under automation).
    /// </remarks>
    public static class StaMessagePump
    {
        /// <summary>Default timeout for an STA test body, in milliseconds.</summary>
        public const int DefaultTimeoutMs = 60_000;

        /// <summary>
        /// Runs <paramref name="body"/> on a fresh STA thread and rethrows any exception it
        /// raised on the calling (test runner) thread, preserving the original stack trace.
        /// </summary>
        /// <param name="body">Test body to execute. Use <see cref="Pump"/> inside it to run the message loop.</param>
        /// <param name="timeoutMs">Maximum time the body may take before the test fails.</param>
        /// <exception cref="TimeoutException">The body did not complete within <paramref name="timeoutMs"/>.</exception>
        public static void Run(Action body, int timeoutMs = DefaultTimeoutMs)
        {
            if (body == null)
            {
                throw new ArgumentNullException(nameof(body));
            }

            Exception? captured = null;
            using (var completed = new ManualResetEventSlim(false))
            {
                var thread = new Thread(() =>
                {
                    try
                    {
                        // Thread-scoped: surface WndProc exceptions as throws rather than the
                        // modal ThreadException dialog. Must precede any control creation.
                        Application.SetUnhandledExceptionMode(UnhandledExceptionMode.ThrowException, true);
                        body();
                    }
                    catch (Exception ex)
                    {
                        captured = ex;
                    }
                    finally
                    {
                        // ReSharper disable once AccessToDisposedClosure
                        completed.Set();
                    }
                })
                {
                    IsBackground = true,
                    Name = "Bastion STA test thread"
                };
                thread.SetApartmentState(ApartmentState.STA);
                thread.Start();

                if (!completed.Wait(timeoutMs))
                {
                    // Do not abort the thread (unsupported on .NET 5+); it is a background
                    // thread and dies with the process. Report the hang as a failure.
                    throw new TimeoutException(
                        $"STA test body did not complete within {timeoutMs} ms — likely a modal dialog or a deadlock.");
                }

                thread.Join(5_000);
            }

            if (captured != null)
            {
                ExceptionDispatchInfo.Capture(captured).Throw();
            }
        }

        /// <summary>
        /// Pumps the WinForms message loop on the current thread for at least
        /// <paramref name="durationMs"/> milliseconds (an <see cref="Application.DoEvents"/>
        /// pump utility for use inside <see cref="Run"/> bodies).
        /// </summary>
        /// <param name="durationMs">How long to keep pumping, in milliseconds.</param>
        public static void Pump(int durationMs = 50)
        {
            var stopwatch = Stopwatch.StartNew();
            do
            {
                Application.DoEvents();
                Thread.Sleep(1);
            }
            while (stopwatch.ElapsedMilliseconds < durationMs);
        }
    }
}
