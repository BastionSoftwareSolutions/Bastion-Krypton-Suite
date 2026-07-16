#region BSD License
/*
 * New (Bastion) file in a work derived from BSD-3-Clause licensed code:
 * © Component Factory Pty Ltd, 2006 - 2016. Then modifications by Peter Wagner (aka Wagnerp),
 * Simon Coghlan (aka Smurf-IV), Giduac, Ahmed Abdelhameed, Lesandro & tobitege et al. 2017 - 2026.
 * © Bastion Software Solutions Ltd 2026. All rights reserved.
 */
#endregion

using System.Windows.Forms;

using Bastion.Krypton.UnitTests.Infrastructure;

using Krypton.Toolkit;

using NUnit.Framework;

namespace Bastion.Krypton.StressTests
{
    /// <summary>
    /// Placeholder proving the stress harness runs on every TFM: STA message pump, handle
    /// counting, screenshot-on-failure plumbing and the Krypton references are all wired.
    /// The adversarial suites (spec §6.3) land here in Phase 5c.
    /// </summary>
    [TestFixture]
    public class HarnessSmokeTest : UiTestBase
    {
        /// <summary>End-to-end harness check: show a Krypton control, pump, dispose, count handles.</summary>
        [Test]
        public void Harness_StaPumpHandleCounterAndKryptonReferences_AreOperational()
        {
            StaMessagePump.Run(() =>
            {
                HandleSnapshot before = HandleCounter.Snapshot();
                Assert.That(before.UserHandles, Is.GreaterThan(0u), "USER handle count should be non-zero in a GUI process.");

                using (var form = new Form { ShowInTaskbar = false })
                using (var button = new KryptonButton { Text = "Stress harness placeholder" })
                {
                    form.Controls.Add(button);
                    form.Show();
                    StaMessagePump.Pump(100);

                    Assert.That(button.IsHandleCreated, Is.True, "The Krypton control should have a live handle on the shown form.");
                }

                StaMessagePump.Pump(50);
            });
        }
    }
}
