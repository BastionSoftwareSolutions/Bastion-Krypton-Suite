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

        // Types that GENUINELY show modal UI by design when instantiated and shown — not
        // defects, so they cannot be smoke-tested unattended. Keep this list minimal and
        // justify every entry.
        private static readonly HashSet<string> ByDesignModal = new HashSet<string>(StringComparer.Ordinal)
        {
            // Its Load handler opens a modal KryptonMessageBox ("This is for developmental
            // use only. Do you want to continue?") by design — blocks the harness for 30s
            // per run until the watchdog fires.
            "Krypton.Toolkit.Suite.Extended.Core.GlobalOptionsMenu",

            // Its Load handler calls AllMergedColourSettingsManager.ResetToDefaults(),
            // which opens a modal "Reset Settings" confirmation by design.
            "Krypton.Toolkit.Suite.Extended.Core.PaletteColourCreator",

            // Under-construction stub: its Load handler shows the modal
            // ApplicationUtilities.UnderConstruction() message box by design.
            "Krypton.Toolkit.Suite.Extended.Dialogs.KryptonNuGetBrowser",

            // Under-construction stub: its CONSTRUCTOR shows the modal
            // ApplicationUtilities.UnderConstruction() message box by design.
            "Krypton.Toolkit.Suite.Extended.Drawing.Utilities.KryptonColourFindAndReplaceDialog",

            // Not-implemented stub: its Load handler shows the modal
            // DebugUtilities.NotImplemented() message box by design.
            "Krypton.Toolkit.Suite.Extended.Theme.Switcher.UploadThemeBrowser"
        };

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

            // Default mode: the five core assemblies. "--dir <path>" mode: load every
            // Krypton.Toolkit.Suite.Extended.*.dll from the given directory (an Extended
            // per-project output dir, which carries its full dependency closure).
            string? moduleDir = null;
            var positional = new List<string>();
            for (int i = 0; i < args.Length; i++)
            {
                if (args[i] == "--dir" && i + 1 < args.Length)
                {
                    moduleDir = args[++i];
                }
                else
                {
                    positional.Add(args[i]);
                }
            }
            args = positional.ToArray();

            Assembly[] assemblies;
            if (moduleDir is null)
            {
                assemblies = new[]
                {
                    typeof(Krypton.Toolkit.KryptonButton).Assembly,
                    typeof(Krypton.Ribbon.KryptonRibbon).Assembly,
                    typeof(Krypton.Navigator.KryptonNavigator).Assembly,
                    typeof(Krypton.Workspace.KryptonWorkspace).Assembly,
                    typeof(Krypton.Docking.KryptonDockingManager).Assembly
                };
            }
            else
            {
                // Resolve any stragglers (and core assemblies) from the module directory itself.
                AppDomain.CurrentDomain.AssemblyResolve += (_, e) =>
                {
                    try
                    {
                        string candidate = System.IO.Path.Combine(moduleDir, new AssemblyName(e.Name).Name + ".dll");
                        return System.IO.File.Exists(candidate) ? Assembly.LoadFrom(candidate) : null;
                    }
                    catch
                    {
                        // Not a loadable managed assembly (native dll, wrong-framework facade, …) —
                        // decline and let the default resolution continue.
                        return null;
                    }
                };
#if !NETFRAMEWORK
                // LoadFrom'd assemblies get no deps.json/RID-based native probing, so a
                // P/Invoke (e.g. SkiaSharp's libSkiaSharp) would fall through to PATH —
                // which can carry an incompatible copy. Probe the module directory's own
                // native assets first, as an app referencing the module would.
                string nativeDir = System.IO.Path.Combine(moduleDir, "runtimes",
                    $"win-{System.Runtime.InteropServices.RuntimeInformation.ProcessArchitecture}".ToLowerInvariant(),
                    "native");
                AppDomain.CurrentDomain.AssemblyLoad += (_, e) =>
                {
                    Assembly loaded = e.LoadedAssembly;
                    if (loaded.IsDynamic ||
                        !loaded.Location.StartsWith(moduleDir, StringComparison.OrdinalIgnoreCase))
                    {
                        return;
                    }
                    try
                    {
                        System.Runtime.InteropServices.NativeLibrary.SetDllImportResolver(loaded, (name, _, _) =>
                        {
                            string file = name.EndsWith(".dll", StringComparison.OrdinalIgnoreCase) ? name : name + ".dll";
                            foreach (string dir in new[] { moduleDir, nativeDir })
                            {
                                string candidate = System.IO.Path.Combine(dir, file);
                                if (System.IO.File.Exists(candidate))
                                {
                                    return System.Runtime.InteropServices.NativeLibrary.Load(candidate);
                                }
                            }
                            return IntPtr.Zero;
                        });
                    }
                    catch (InvalidOperationException)
                    {
                        // A resolver is already registered for this assembly.
                    }
                };
#endif
                assemblies = System.IO.Directory
                    .GetFiles(moduleDir, "Krypton.Toolkit.Suite.Extended.*.dll")
                    .Select(Assembly.LoadFrom)
                    .ToArray();
                if (assemblies.Length == 0)
                {
                    Console.WriteLine($"No Extended module assemblies in {moduleDir} — nothing to test.");
                    return 0;
                }
            }

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
                    ConstructorInfo? ctor;
                    try
                    {
                        ctor = type.GetConstructor(Type.EmptyTypes);
                    }
                    catch (Exception ex)
                    {
                        // Reflecting over the type pulled in an unresolvable dependency — a harness
                        // environment limit, not a control defect. Record and continue.
                        Failures.Add($"{type.FullName}: [reflection] {ex.GetType().Name}: {ex.Message}");
                        continue;
                    }
                    if (ctor is null)
                    {
                        _skipped++;
                        continue;
                    }
                    if (type.FullName is not null && ByDesignModal.Contains(type.FullName))
                    {
                        Console.WriteLine($"SKIP {type.FullName} (by-design modal UI — see skip list)");
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
                            if (control is ToolStripDropDown)
                            {
                                // Top-level popup window (context menus etc.): rejects
                                // parenting with "Top-level control cannot be added" —
                                // create + dispose is all unattended smoke can exercise.
                            }
                            else if (control is TabPage tabPage)
                            {
                                // TabPages may only be parented to a TabControl.
                                var tabs = new TabControl();
                                host.Controls.Add(tabs);
                                tabs.TabPages.Add(tabPage);
                            }
                            else
                            {
                                host.Controls.Add(control);
                            }
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
