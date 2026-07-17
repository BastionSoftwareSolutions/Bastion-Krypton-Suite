#region MIT License

/*
 * MIT License
 *
 * © Bastion Software Solutions Ltd. New file for the Bastion Krypton Suite,
 * a derived work from the MIT-licensed Krypton Toolkit Suite Extended
 * (Copyright (c) 2017 - 2024 Krypton Suite).
 *
 * Permission is hereby granted, free of charge, to any person obtaining a copy
 * of this software and associated documentation files (the "Software"), to deal
 * in the Software without restriction, including without limitation the rights
 * to use, copy, modify, merge, publish, distribute, sublicense, and/or sell
 * copies of the Software, and to permit persons to whom the Software is
 * furnished to do so, subject to the following conditions:
 *
 * The above copyright notice and this permission notice shall be included in all
 * copies or substantial portions of the Software.
 *
 * THE SOFTWARE IS PROVIDED "AS IS", WITHOUT WARRANTY OF ANY KIND, EXPRESS OR
 * IMPLIED, INCLUDING BUT NOT LIMITED TO THE WARRANTIES OF MERCHANTABILITY,
 * FITNESS FOR A PARTICULAR PURPOSE AND NONINFRINGEMENT. IN NO EVENT SHALL THE
 * AUTHORS OR COPYRIGHT HOLDERS BE LIABLE FOR ANY CLAIM, DAMAGES OR OTHER
 * LIABILITY, WHETHER IN AN ACTION OF CONTRACT, TORT OR OTHERWISE, ARISING FROM,
 * OUT OF OR IN CONNECTION WITH THE SOFTWARE OR THE USE OR OTHER DEALINGS IN THE
 * SOFTWARE.
 *
 */

#endregion
namespace Examples
{
    /// <summary>
    /// Regression hook behind the hidden "--smoke" command line switch: instantiates, shows
    /// and disposes every form registered with the main menu, then reports pass/fail counts.
    /// Returns a non-zero exit code when any form throws.
    /// </summary>
    internal static class SmokeTest
    {
        private sealed class SmokeCase
        {
            public SmokeCase(string name, Func<Form> factory)
            {
                Name = name;

                Factory = factory;
            }

            public string Name { get; }

            public Func<Form> Factory { get; }
        }

        /// <summary>
        /// Every form reachable from the main menu. Keep this list in step with MainWindow:
        /// when a new example form is registered there, add its factory here as well.
        /// </summary>
        private static readonly SmokeCase[] RegisteredForms =
        {
            new SmokeCase("MainWindow", () => new MainWindow()),
            new SmokeCase("ButtonItems", () => new ButtonItems()),
            new SmokeCase("ToolStripItems", () => new ToolStripItems()),
            new SmokeCase("CalendarItems", () => new CalendarItems()),
            new SmokeCase("CircularProgressBarExample", () => new CircularProgressBarExample()),
            new SmokeCase("CheckSumExample", () => new CheckSumExample()),
            new SmokeCase("ExtendedControlExamples", () => new ExtendedControlExamples()),
            new SmokeCase("MessageBoxExample", () => new MessageBoxExample()),
            new SmokeCase("FloatingMenuToolbarExampleMain", () => new FloatingMenuToolbarExampleMain()),
            new SmokeCase("KryptonFormExtended1", () => new KryptonFormExtended1()),
            new SmokeCase("DialogExamples", () => new DialogExamples()),
            new SmokeCase("KryptonInputBoxExtendedExample", () => new KryptonInputBoxExtendedExample()),
            new SmokeCase("TreeGridViewExample", () => new TreeGridViewExample()),
            new SmokeCase("TreeGridViewAdvancedExample", () => new TreeGridViewAdvancedExample()),
            new SmokeCase("AdvancedDataGridView", () => new AdvancedDataGridView()),
            new SmokeCase("DockExtenderExample", () => new DockExtenderExample()),
            new SmokeCase("ThemeTools", () => new ThemeTools()),
            new SmokeCase("KryptonRibbonExtendedExample", () => new KryptonRibbonExtendedExample()),
            new SmokeCase("MemoryBoxExample", () => new MemoryBoxExample()),
            new SmokeCase("KryptonProgressBarExtendedExamples", () => new KryptonProgressBarExtendedExamples()),
            new SmokeCase("CheckBoxComboBoxTest", () => new CheckBoxComboBoxTest()),
            new SmokeCase("ToastNotificationMenu", () => new ToastNotificationMenu()),
            new SmokeCase("RadialMenuExample", () => new RadialMenuExample()),
            new SmokeCase("WizardExample", () => new WizardExample()),
            new SmokeCase("NaviBarExample", () => new NaviBarExample()),
            new SmokeCase("ToolBoxExample", () => new ToolBoxExample()),
            new SmokeCase("CoreDialogExamples", () => new CoreDialogExamples()),
            new SmokeCase("CoreColourDialogExamples", () => new CoreColourDialogExamples()),
            new SmokeCase("ExternalThemeSelectorChooser", () => new ExternalThemeSelectorChooser()),
            new SmokeCase("ComboBoxExample", () => new ComboBoxExample()),
            new SmokeCase("CompressionKryptonFileCompressor", () => new Krypton.Toolkit.Suite.Extended.Compression.KryptonFileCompressor()),
            new SmokeCase("OutlookGridExample", () => new OutlookGridExample()),
            new SmokeCase("DataGridViewColumnsExample", () => new DataGridViewColumnsExample()),
            new SmokeCase("VirtualTreeColumnViewExample", () => new VirtualTreeColumnViewExample()),
#if !NET46
            new SmokeCase("DataVisualisationExample", () => new DataVisualisationExample()),
#endif
            new SmokeCase("DrawingUtilitiesExample", () => new DrawingUtilitiesExample()),
            new SmokeCase("ErrorReportingExample", () => new ErrorReportingExample()),
            new SmokeCase("FileCopierExample", () => new FileCopierExample()),
            new SmokeCase("IOExample", () => new IOExample()),
            new SmokeCase("NavigatorExample", () => new NavigatorExample()),
            new SmokeCase("NetworkingExample", () => new NetworkingExample()),
            new SmokeCase("NotificationsExample", () => new NotificationsExample()),
            new SmokeCase("PanelsExample", () => new PanelsExample()),
            new SmokeCase("SpecialisedDialogsExample", () => new SpecialisedDialogsExample()),
            new SmokeCase("UtilitiesExample", () => new UtilitiesExample()),
            new SmokeCase("EffectsExample", () => new EffectsExample())
        };

        /// <summary>Runs the smoke sweep. Returns 0 when every form passes; otherwise 1.</summary>
        public static int Run()
        {
            // Without this, an exception thrown inside an event handler while DoEvents pumps
            // is routed to Application.ThreadException and shows a modal ThreadExceptionDialog,
            // hanging the sweep. Throwing lets the try/catch below record a proper failure.
            Application.SetUnhandledExceptionMode(UnhandledExceptionMode.ThrowException);

            int passed = 0;

            int failed = 0;

            foreach (SmokeCase smokeCase in RegisteredForms)
            {
                try
                {
                    using (Form form = smokeCase.Factory())
                    {
                        form.Show();

                        Application.DoEvents();

                        form.Close();

                        Application.DoEvents();
                    }

                    passed++;

                    Console.WriteLine($@"PASS  {smokeCase.Name}");
                }
                catch (Exception exception)
                {
                    failed++;

                    Console.WriteLine($@"FAIL  {smokeCase.Name}: {exception.GetType().Name}: {exception.Message}");

                    Console.WriteLine(exception.StackTrace);
                }
            }

            Console.WriteLine($@"Smoke test complete: {passed} passed, {failed} failed, {RegisteredForms.Length} total.");

            return failed == 0 ? 0 : 1;
        }
    }
}
