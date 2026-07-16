#region BSD License
/*
 * New (Bastion) file in a work derived from BSD-3-Clause licensed code:
 * © Component Factory Pty Ltd, 2006 - 2016. Then modifications by Peter Wagner (aka Wagnerp),
 * Simon Coghlan (aka Smurf-IV), Giduac, Ahmed Abdelhameed, Lesandro & tobitege et al. 2017 - 2026.
 * © Bastion Software Solutions Ltd 2026. All rights reserved.
 */
#endregion

using System;

using Bastion.Krypton.UnitTests.Infrastructure;

using Krypton.Toolkit;

using NUnit.Framework;

namespace Bastion.Krypton.UnitTests.Regression
{
    /// <summary>
    /// Locks in the Phase 2/3 palette wiring: every <see cref="PaletteMode"/> value must
    /// round-trip through <see cref="KryptonManager.GlobalPaletteMode"/> set/get without an
    /// exception (on an STA thread with a live message pump — palette application touches
    /// global renderer/toolstrip state). Historically new modes crashed here when
    /// <c>KryptonManager.GetPaletteForMode</c> or downstream switches were not extended.
    /// </summary>
    [TestFixture]
    public class GlobalPaletteModeRoundTripTests : UiTestBase
    {
        /// <summary>
        /// Sets and reads back every PaletteMode value, including Global (inherit — keeps the
        /// current palette) and Custom (no custom palette assigned: the setter must still not
        /// throw and must read back as Custom).
        /// </summary>
        [Test]
        public void GlobalPaletteMode_EveryValue_RoundTripsWithoutException()
        {
            StaMessagePump.Run(() =>
            {
                using (var manager = new KryptonManager())
                {
                    try
                    {
                        foreach (PaletteMode mode in Enum.GetValues(typeof(PaletteMode)))
                        {
                            Assert.That(() => manager.GlobalPaletteMode = mode, Throws.Nothing,
                                $"Setting KryptonManager.GlobalPaletteMode = PaletteMode.{mode} threw.");
                            Assert.That(manager.GlobalPaletteMode, Is.EqualTo(mode),
                                $"PaletteMode.{mode} did not round-trip through GlobalPaletteMode set/get.");
                            StaMessagePump.Pump(10);
                        }
                    }
                    finally
                    {
                        // KryptonManager.GlobalPaletteMode proxies static toolkit state:
                        // restore the documented default so later tests start clean.
                        manager.GlobalPaletteMode = PaletteMode.Microsoft365Blue;
                    }
                }
            }, timeoutMs: 180_000);
        }
    }
}
