// © Bastion Software Solutions Ltd 2026. Part of the Bastion Krypton Suite build tooling.
// Theme render harness (spec §4.3.4): shows a representative form — Krypton chrome, ribbon,
// common controls — under every PaletteMode and captures a true-pixel screenshot per theme
// into the given output directory. Used for the side-by-side fidelity comparisons.
//
// Usage: KryptonThemeBrowser <outputDir> [paletteNameFilter]

using System;
using System.Drawing;
using System.Drawing.Imaging;
using System.IO;
using System.Linq;
using System.Threading;
using System.Windows.Forms;
using Krypton.Navigator;
using Krypton.Ribbon;
using Krypton.Toolkit;

namespace Bastion.ThemeBrowser
{
    internal static class Program
    {
        [STAThread]
        private static int Main(string[] args)
        {
            string outDir = args.Length > 0 ? args[0] : @"D:\Krypton-Ultimate\docs\themes\comparisons\current";
            string? filter = args.Length > 1 ? args[1] : null;
            Directory.CreateDirectory(outDir);

            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            Application.SetUnhandledExceptionMode(UnhandledExceptionMode.ThrowException);

            var manager = new KryptonManager();
            using var form = BuildSampleForm();
            form.Show();
            Pump(20);

            int captured = 0, failed = 0;
            foreach (PaletteMode mode in Enum.GetValues<PaletteMode>())
            {
                if (mode is PaletteMode.Custom or PaletteMode.Global)
                {
                    continue;
                }
                if (filter is not null && !mode.ToString().Contains(filter, StringComparison.OrdinalIgnoreCase))
                {
                    continue;
                }

                try
                {
                    manager.GlobalPaletteMode = mode;
                    form.Text = $@"Bastion Krypton Theme Browser — {mode}";
                    form.Refresh();
                    Pump(15);
                    Capture(form, Path.Combine(outDir, $"{mode}.png"));
                    captured++;
                    Console.WriteLine($@"OK   {mode}");
                }
                catch (Exception ex)
                {
                    failed++;
                    Console.Error.WriteLine($@"FAIL {mode}: {ex.GetType().Name}: {ex.Message}");
                }
            }

            Console.WriteLine($@"Captured {captured} themes to {outDir}; failures: {failed}");
            return failed == 0 ? 0 : 1;
        }

        private static KryptonForm BuildSampleForm()
        {
            var form = new KryptonForm
            {
                StartPosition = FormStartPosition.Manual,
                Location = new Point(40, 40),
                Size = new Size(1000, 680),
                ShowInTaskbar = false,
                TopMost = true
            };

            // Ribbon — the centrepiece for Office-look fidelity.
            var ribbon = new KryptonRibbon();
            var tabHome = new KryptonRibbonTab { Text = @"Home" };
            var tabInsert = new KryptonRibbonTab { Text = @"Insert" };
            var tabView = new KryptonRibbonTab { Text = @"View" };
            var group1 = new KryptonRibbonGroup { TextLine1 = @"Clipboard" };
            var triple1 = new KryptonRibbonGroupTriple();
            triple1.Items.Add(new KryptonRibbonGroupButton { TextLine1 = @"Paste" });
            triple1.Items.Add(new KryptonRibbonGroupButton { TextLine1 = @"Cut" });
            triple1.Items.Add(new KryptonRibbonGroupButton { TextLine1 = @"Copy" });
            group1.Items.Add(triple1);
            var group2 = new KryptonRibbonGroup { TextLine1 = @"Font" };
            var triple2 = new KryptonRibbonGroupTriple();
            triple2.Items.Add(new KryptonRibbonGroupButton { TextLine1 = @"Bold" });
            triple2.Items.Add(new KryptonRibbonGroupButton { TextLine1 = @"Italic", Checked = true, ButtonType = GroupButtonType.Check });
            triple2.Items.Add(new KryptonRibbonGroupButton { TextLine1 = @"Underline", Enabled = false });
            group2.Items.Add(triple2);
            tabHome.Groups.AddRange(new[] { group1, group2 });
            ribbon.RibbonTabs.AddRange(new[] { tabHome, tabInsert, tabView });
            ribbon.SelectedTab = tabHome;

            // A spread of everyday controls in the client area.
            var panel = new KryptonPanel { Dock = DockStyle.Fill };
            var nav = new KryptonNavigator
            {
                Location = new Point(16, 16),
                Size = new Size(460, 420)
            };
            nav.Pages.Add(new KryptonPage { Text = @"General", TextTitle = @"General" });
            nav.Pages.Add(new KryptonPage { Text = @"Details", TextTitle = @"Details" });

            var page = nav.Pages[0];
            page.Controls.Add(new KryptonLabel { Text = @"Sample label", Location = new Point(12, 16) });
            page.Controls.Add(new KryptonTextBox { Text = @"Sample text box", Location = new Point(12, 44), Width = 200 });
            var combo = new KryptonComboBox { Location = new Point(12, 78), Width = 200 };
            combo.Items.AddRange(new object[] { "First item", "Second item" });
            combo.SelectedIndex = 0;
            page.Controls.Add(combo);
            page.Controls.Add(new KryptonCheckBox { Text = @"Checked option", Checked = true, Location = new Point(12, 112) });
            page.Controls.Add(new KryptonRadioButton { Text = @"Selected choice", Checked = true, Location = new Point(12, 140) });
            page.Controls.Add(new KryptonButton { Text = @"Standard button", Location = new Point(12, 172) });
            page.Controls.Add(new KryptonButton { Text = @"Disabled button", Enabled = false, Location = new Point(150, 172) });
            var track = new KryptonTrackBar { Location = new Point(12, 210), Width = 200, Value = 6 };
            page.Controls.Add(track);

            var headerGroup = new KryptonHeaderGroup
            {
                Location = new Point(500, 16),
                Size = new Size(440, 200),
                ValuesPrimary = { Heading = @"Header group" },
                ValuesSecondary = { Heading = @"Secondary heading" }
            };

            var listBox = new KryptonListBox { Location = new Point(500, 240), Size = new Size(200, 160) };
            listBox.Items.AddRange(new object[] { "Alpha", "Beta", "Gamma", "Delta" });
            listBox.SelectedIndex = 1;

            var grid = new KryptonDataGridView
            {
                Location = new Point(716, 240),
                Size = new Size(224, 160),
                ColumnCount = 2,
                RowCount = 4,
                AllowUserToAddRows = false
            };
            grid.Columns[0].HeaderText = @"Name";
            grid.Columns[1].HeaderText = @"Value";

            panel.Controls.AddRange(new Control[] { nav, headerGroup, listBox, grid });
            form.Controls.Add(panel);
            form.Controls.Add(ribbon);
            return form;
        }

        private static void Capture(Form form, string path)
        {
            using var bmp = new Bitmap(form.Width, form.Height, PixelFormat.Format32bppArgb);
            using (Graphics g = Graphics.FromImage(bmp))
            {
                g.CopyFromScreen(form.Location, Point.Empty, form.Size);
            }
            bmp.Save(path, ImageFormat.Png);
        }

        private static void Pump(int cycles)
        {
            for (int i = 0; i < cycles; i++)
            {
                Application.DoEvents();
                Thread.Sleep(20);
            }
        }
    }
}
