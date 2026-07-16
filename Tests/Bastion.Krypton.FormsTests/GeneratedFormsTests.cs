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
using System.Windows.Forms;

using Bastion.Krypton.UnitTests.Infrastructure;

using Krypton.Toolkit;

using NUnit.Framework;

namespace Bastion.Krypton.FormsTests
{
    /// <summary>
    /// Exercises the generated family forms (spec §6.1): show each one, pump the message loop,
    /// resize, switch through four representative palettes (one per major era), dispose — and
    /// assert GDI/USER handle stability across a second full lifecycle (the first lifecycle
    /// warms the toolkit's one-off palette/font/image caches).
    /// </summary>
    [TestFixture]
    public class GeneratedFormsTests : UiTestBase
    {
        /// <summary>One palette per major era; ends on the toolkit default.</summary>
        private static readonly PaletteMode[] RepresentativePalettes =
        {
            PaletteMode.Office2010Black,
            PaletteMode.SparkleBlue,
            PaletteMode.ProfessionalSystem,
            PaletteMode.Microsoft365Blue
        };

        /// <summary>All generated family forms in this assembly.</summary>
        public static IEnumerable<Type> FamilyFormTypes =>
            typeof(GeneratedFormsTests).Assembly.GetTypes()
                .Where(static t => !t.IsAbstract &&
                                   typeof(Form).IsAssignableFrom(t) &&
                                   t.Namespace != null &&
                                   t.Namespace.EndsWith(".Generated", StringComparison.Ordinal))
                .OrderBy(static t => t.Name, StringComparer.Ordinal);

        /// <summary>The generator must have produced one form per core assembly family.</summary>
        [Test]
        public void Generator_ProducedAllFiveFamilyForms()
        {
            string[] names = FamilyFormTypes.Select(static t => t.Name).ToArray();
            Assert.That(names, Is.EquivalentTo(new[]
            {
                "DockingFamilyForm", "NavigatorFamilyForm", "RibbonFamilyForm",
                "ToolkitFamilyForm", "WorkspaceFamilyForm"
            }));
        }

        /// <summary>Show, pump, resize, palette-switch, dispose — twice; handles must be stable.</summary>
        [TestCaseSource(nameof(FamilyFormTypes))]
        public void FamilyForm_ShowResizePaletteSwitchDispose_HandlesStable(Type formType)
        {
            StaMessagePump.Run(() =>
            {
                // Warm-up lifecycle: populates the toolkit's static palette/font/image caches
                // so the measured lifecycle only sees genuine leaks.
                RunLifecycle(formType);

                HandleSnapshot before = HandleCounter.Snapshot();
                RunLifecycle(formType);

                GC.Collect();
                GC.WaitForPendingFinalizers();
                GC.Collect();
                StaMessagePump.Pump(100);

                HandleCounter.AssertStable(before, gdiSlack: 48, userSlack: 32);
            }, timeoutMs: 300_000);
        }

        private static void RunLifecycle(Type formType)
        {
            using (var manager = new KryptonManager())
            {
                try
                {
                    using (var form = (Form)Activator.CreateInstance(formType)!)
                    {
                        form.Show();
                        StaMessagePump.Pump(150);

                        form.Size = new Size(form.Width + 160, form.Height + 120);
                        StaMessagePump.Pump(100);
                        form.Size = new Size(form.Width - 240, form.Height - 200);
                        StaMessagePump.Pump(100);

                        foreach (PaletteMode mode in RepresentativePalettes)
                        {
                            manager.GlobalPaletteMode = mode;
                            StaMessagePump.Pump(120);
                        }
                    }

                    StaMessagePump.Pump(100);
                }
                finally
                {
                    // GlobalPaletteMode proxies static toolkit state — always end on the default.
                    manager.GlobalPaletteMode = PaletteMode.Microsoft365Blue;
                }
            }
        }
    }
}
