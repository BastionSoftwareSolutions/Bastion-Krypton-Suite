// © Bastion Software Solutions Ltd 2026. Part of the Bastion Krypton Suite build tooling.
// Phase 2 smoke test (spec §3.6): instantiate every public control per TFM in a WinForms
// message loop and dispose cleanly. Exit code 0 = all types pass; 1 = failures (listed on stderr).

using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Reflection;
using System.Threading;
using System.Windows.Forms;

namespace Bastion.SmokeTest
{
    internal static class Program
    {
        private static readonly List<string> Failures = new List<string>();
        private static int _tested;
        private static int _skipped;

        private static volatile string _currentType = "";
        private static long _typeStartedTicks;

        [STAThread]
        private static int Main(string[] args)
        {
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            // Surface WndProc exceptions as throws instead of the modal ThreadException dialog,
            // which presents as a silent hang under automation.
            Application.SetUnhandledExceptionMode(UnhandledExceptionMode.ThrowException);

            // Watchdog: a type taking >30s means a modal dialog or deadlock — name it and abort.
            _typeStartedTicks = Environment.TickCount;
            var watchdog = new Thread(() =>
            {
                while (true)
                {
                    Thread.Sleep(1000);
                    if (_currentType.Length > 0 && Environment.TickCount - Interlocked.Read(ref _typeStartedTicks) > 30_000)
                    {
                        Console.Error.WriteLine($"HUNG {_currentType} (no completion after 30s) — aborting");
                        Console.Error.Flush();
                        Environment.Exit(3);
                    }
                }
            }) { IsBackground = true };
            watchdog.Start();

            var assemblies = new[]
            {
                typeof(Krypton.Toolkit.KryptonButton).Assembly,
                typeof(Krypton.Ribbon.KryptonRibbon).Assembly,
                typeof(Krypton.Navigator.KryptonNavigator).Assembly,
                typeof(Krypton.Workspace.KryptonWorkspace).Assembly,
                typeof(Krypton.Docking.KryptonDockingManager).Assembly
            };

            Console.WriteLine($"Runtime: {Environment.Version} | {typeof(Program).Assembly.GetCustomAttribute<System.Runtime.Versioning.TargetFrameworkAttribute>()?.FrameworkName}");

            foreach (Assembly asm in assemblies)
            {
                Console.WriteLine($"== {asm.GetName().Name} {asm.GetName().Version} ==");
                foreach (Type type in asm.GetExportedTypes().OrderBy(t => t.FullName, StringComparer.Ordinal))
                {
                    if (args.Length > 0 && type.FullName?.IndexOf(args[0], StringComparison.OrdinalIgnoreCase) < 0)
                    {
                        continue;
                    }
                    if (type.IsAbstract || type.IsGenericTypeDefinition || type.ContainsGenericParameters)
                    {
                        continue;
                    }
                    if (!typeof(Component).IsAssignableFrom(type))
                    {
                        continue;
                    }
                    ConstructorInfo? ctor = type.GetConstructor(Type.EmptyTypes);
                    if (ctor is null)
                    {
                        _skipped++;
                        continue;
                    }

                    SmokeOne(type);
                }
            }

            Console.WriteLine();
            Console.WriteLine($"Tested: {_tested}; skipped (no default ctor): {_skipped}; failures: {Failures.Count}");
            foreach (string f in Failures)
            {
                Console.Error.WriteLine($"FAIL {f}");
            }
            return Failures.Count == 0 ? 0 : 1;
        }

        private static void SmokeOne(Type type)
        {
            _tested++;
            // Per-type progress so a hang identifies its culprit in the log.
            Console.WriteLine($"BEGIN {type.FullName}");
            Console.Out.Flush();
            _currentType = type.FullName ?? type.Name;
            Interlocked.Exchange(ref _typeStartedTicks, Environment.TickCount);
            try
            {
                if (typeof(Form).IsAssignableFrom(type))
                {
                    using (var form = (Form)Activator.CreateInstance(type)!)
                    {
                        form.StartPosition = FormStartPosition.Manual;
                        form.Location = new System.Drawing.Point(-32000, -32000);
                        form.ShowInTaskbar = false;
                        form.Show();
                        Pump();
                        form.Close();
                        Pump();
                    }
                }
                else if (typeof(Control).IsAssignableFrom(type))
                {
                    using (var host = new Form())
                    {
                        host.StartPosition = FormStartPosition.Manual;
                        host.Location = new System.Drawing.Point(-32000, -32000);
                        host.ShowInTaskbar = false;
                        using (var control = (Control)Activator.CreateInstance(type)!)
                        {
                            host.Controls.Add(control);
                            host.Show();
                            Pump();
                            host.Size = new System.Drawing.Size(800, 600);
                            Pump();
                        }
                        host.Close();
                        Pump();
                    }
                }
                else
                {
                    // Non-visual component: create + dispose.
                    using ((IDisposable)Activator.CreateInstance(type)!)
                    {
                    }
                }
            }
            catch (Exception ex)
            {
                Exception root = ex;
                while (root is TargetInvocationException or TypeInitializationException && root.InnerException is not null)
                {
                    root = root.InnerException;
                }
                Failures.Add($"{type.FullName}: {root.GetType().Name}: {root.Message}");
                if (Failures.Count == 1)
                {
                    // Full detail for the first failure — later ones usually cascade from it.
                    Console.Error.WriteLine("FIRST FAILURE DETAIL:");
                    Console.Error.WriteLine(ex.ToString());
                    Console.Error.Flush();
                }
            }
            finally
            {
                _currentType = "";
            }
        }

        private static void Pump()
        {
            for (int i = 0; i < 3; i++)
            {
                Application.DoEvents();
                Thread.Sleep(10);
            }
        }
    }
}
