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
using System.Linq;

using Krypton.Toolkit;

using NUnit.Framework;

namespace Bastion.Krypton.UnitTests.Regression
{
    /// <summary>
    /// Locks in the upstream #1328 contract: "IT IS MANDATORY TO KEEP THE PALETTEMODE ENUM AND
    /// THE DICTIONARY IN THE SAME ORDER". <see cref="PaletteMode"/> starts at Global = -1 so
    /// every following member's numeric value equals its position in
    /// <c>PaletteModeStrings.SupportedThemes</c>; theme selectors index one collection with
    /// ordinals from the other. The Bastion Phase 3 modes were appended before Custom to keep
    /// this true — these tests fail if either side is ever reordered or extended inconsistently.
    /// </summary>
    [TestFixture]
    public class PaletteModeContractTests
    {
        private static PaletteMode[] EnumValuesExcludingGlobal() =>
            Enum.GetValues(typeof(PaletteMode))
                .Cast<PaletteMode>()
                .Where(static m => m != PaletteMode.Global)
                .OrderBy(static m => (int)m)
                .ToArray();

        /// <summary>The dictionary must contain exactly the enum members (minus Global).</summary>
        [Test]
        public void SupportedThemes_ContainsEveryPaletteModeExceptGlobal_ExactlyOnce()
        {
            PaletteMode[] enumValues = EnumValuesExcludingGlobal();
            var mapped = PaletteModeStrings.SupportedThemesMap.Values.ToList();

            Assert.Multiple(() =>
            {
                Assert.That(mapped, Is.Unique, "SupportedThemes maps two names to the same PaletteMode.");
                Assert.That(mapped, Is.EquivalentTo(enumValues),
                    "SupportedThemes and the PaletteMode enum no longer describe the same set of themes.");
            });
        }

        /// <summary>
        /// Positional contract: the i-th dictionary entry must be the PaletteMode whose numeric
        /// value is i (reflection over both sides, positional match).
        /// </summary>
        [Test]
        public void SupportedThemes_OrderMatchesPaletteModeOrdinals()
        {
            var pairs = PaletteModeStrings.SupportedThemesMap.ToArray();
            for (int i = 0; i < pairs.Length; i++)
            {
                Assert.That((int)pairs[i].Value, Is.EqualTo(i),
                    $"SupportedThemes position {i} holds PaletteMode.{pairs[i].Value} (value {(int)pairs[i].Value}) — " +
                    "the enum <-> dictionary positional contract (#1328) is broken. " +
                    "New modes must be appended before Custom on BOTH sides, in the same order.");
            }
        }

        /// <summary>
        /// The enum itself must be gap-free from 0..N so ordinal indexing cannot skip values
        /// (Global = -1 excluded by design).
        /// </summary>
        [Test]
        public void PaletteMode_ValuesAreContiguousFromZero()
        {
            PaletteMode[] enumValues = EnumValuesExcludingGlobal();
            for (int i = 0; i < enumValues.Length; i++)
            {
                Assert.That((int)enumValues[i], Is.EqualTo(i),
                    $"PaletteMode.{enumValues[i]} has value {(int)enumValues[i]}, expected {i} — the enum has gaps or reordering.");
            }

            Assert.That(enumValues[enumValues.Length - 1], Is.EqualTo(PaletteMode.Custom),
                "PaletteMode.Custom must remain the last member — new modes are appended before it.");
        }

        /// <summary>
        /// The name list exposed to theme selectors must enumerate in the same order as the
        /// name-to-mode map (both views are driven by the same underlying dictionary).
        /// </summary>
        [Test]
        public void SupportedInternalThemeNames_MatchesMapOrder()
        {
            ICollection<string> names = PaletteModeStrings.SupportedInternalThemeNames;
            string[] mapKeys = PaletteModeStrings.SupportedThemesMap.Keys.ToArray();

            Assert.That(names.ToArray(), Is.EqualTo(mapKeys),
                "SupportedInternalThemeNames and SupportedThemesMap enumerate in different orders.");
        }
    }
}
