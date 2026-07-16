#region BSD License
/*
 * New (Bastion) file in a work derived from BSD-3-Clause licensed code:
 * © Component Factory Pty Ltd, 2006 - 2016. Then modifications by Peter Wagner (aka Wagnerp),
 * Simon Coghlan (aka Smurf-IV), Giduac, Ahmed Abdelhameed, Lesandro & tobitege et al. 2017 - 2026.
 * © Bastion Software Solutions Ltd 2026. All rights reserved.
 */
#endregion

using System;
using System.Reflection;

using Krypton.Toolkit;

using NUnit.Framework;

namespace Bastion.Krypton.UnitTests.Regression
{
    /// <summary>
    /// Locks in the Phase 3 fix for BREAKAGE-LOG T1: the 105 duplicated command-image
    /// switches were consolidated into <c>Krypton.Toolkit.PaletteImageSetResolver</c>, whose
    /// classification must cover EVERY <see cref="PaletteMode"/> value without throwing
    /// (the old switches threw <see cref="ArgumentOutOfRangeException"/> for the Material,
    /// VisualStudio2010Render and Microsoft365BlackDarkModeAlternate modes).
    /// The resolver is internal, so it is exercised via reflection.
    /// </summary>
    [TestFixture]
    public class PaletteImageSetResolverTests
    {
        private static MethodInfo ResolveMethod()
        {
            Type? resolver = typeof(KryptonManager).Assembly.GetType("Krypton.Toolkit.PaletteImageSetResolver");
            Assert.That(resolver, Is.Not.Null,
                "Krypton.Toolkit.PaletteImageSetResolver no longer exists — the T1 consolidation has been removed or renamed.");

            MethodInfo? method = resolver!.GetMethod("GetImageSetFamily",
                BindingFlags.Static | BindingFlags.NonPublic | BindingFlags.Public);
            Assert.That(method, Is.Not.Null,
                "PaletteImageSetResolver.GetImageSetFamily is missing — the T1 consolidation has changed shape.");
            return method!;
        }

        /// <summary>Every PaletteMode value must classify without an exception.</summary>
        [Test]
        public void GetImageSetFamily_ClassifiesEveryPaletteModeWithoutThrowing()
        {
            MethodInfo method = ResolveMethod();

            foreach (PaletteMode mode in Enum.GetValues(typeof(PaletteMode)))
            {
                object? family = null;
                Assert.That(() => family = method.Invoke(null, new object[] { mode }),
                    Throws.Nothing,
                    $"PaletteImageSetResolver.GetImageSetFamily threw for PaletteMode.{mode} — the T1 regression is back.");

                // The release build compiles out the resolver's Debug.Assert default arm, so
                // additionally require the result to be a *defined* family value: an
                // unclassified mode degrading through the default arm still yields a defined
                // value, but a broken resolver returning garbage would not.
                Assert.That(family, Is.Not.Null);
                Assert.That(Enum.IsDefined(family!.GetType(), family), Is.True,
                    $"PaletteMode.{mode} classified to an undefined PaletteImageSetFamily value ({family}).");
            }
        }

        /// <summary>
        /// Spot-checks that classification of the era anchors and of the exact modes the T1
        /// switches used to crash on has not drifted (compared by family name so the internal
        /// enum type stays internal).
        /// </summary>
        [TestCase(PaletteMode.Global, "Inherit")]
        [TestCase(PaletteMode.Custom, "Custom")]
        [TestCase(PaletteMode.ProfessionalSystem, "Professional")]
        [TestCase(PaletteMode.ProfessionalOffice2003, "Office2003")]
        [TestCase(PaletteMode.Office2003Olive, "Office2003")]
        [TestCase(PaletteMode.Office2007Blue, "Office2007")]
        [TestCase(PaletteMode.Office2010Black, "Office2010")]
        [TestCase(PaletteMode.Office2013White, "Office2013")]
        [TestCase(PaletteMode.SparkleBlue, "Sparkle")]
        [TestCase(PaletteMode.Microsoft365Blue, "Microsoft365")]
        // The nine T1 crash modes:
        [TestCase(PaletteMode.MaterialLight, "Microsoft365")]
        [TestCase(PaletteMode.MaterialDark, "Microsoft365")]
        [TestCase(PaletteMode.MaterialLightRipple, "Microsoft365")]
        [TestCase(PaletteMode.MaterialDarkRipple, "Microsoft365")]
        [TestCase(PaletteMode.VisualStudio2010Render2007, "Office2007")]
        [TestCase(PaletteMode.VisualStudio2010Render2010, "Office2010")]
        [TestCase(PaletteMode.VisualStudio2010Render2013, "Office2013")]
        [TestCase(PaletteMode.VisualStudio2010Render365, "Microsoft365")]
        [TestCase(PaletteMode.Microsoft365BlackDarkModeAlternate, "Microsoft365")]
        public void GetImageSetFamily_KnownModes_MapToExpectedFamily(PaletteMode mode, string expectedFamily)
        {
            object? family = ResolveMethod().Invoke(null, new object[] { mode });
            Assert.That(family?.ToString(), Is.EqualTo(expectedFamily),
                $"PaletteMode.{mode} no longer classifies to the {expectedFamily} image-set family.");
        }
    }
}
