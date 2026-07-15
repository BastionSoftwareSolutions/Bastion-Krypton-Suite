#region BSD License
/*
 * New (Bastion) file in a work derived from BSD-3-Clause licensed code:
 * © Component Factory Pty Ltd, 2006 - 2016. Then modifications by Peter Wagner (aka Wagnerp),
 * Simon Coghlan (aka Smurf-IV), Giduac, Ahmed Abdelhameed, Lesandro & tobitege et al. 2017 - 2026.
 * © Bastion Software Solutions Ltd 2026. All rights reserved.
 */
#endregion

namespace Krypton.Toolkit;

/// <summary>
/// The era/image-set family a <see cref="PaletteMode"/> belongs to, used to select the
/// correct embedded image resources (toolbar glyphs, help icons, control-box images).
/// </summary>
/// <remarks>
/// <see cref="Sparkle"/> and <see cref="Custom"/> are kept distinct from the Office eras because
/// the historical command switches did not always give them the same images in every context
/// (e.g. Sparkle uses Office 2010 toolbar glyphs, while Custom image states use Microsoft 365
/// help icons); each consumer decides which image set those two families borrow.
/// </remarks>
internal enum PaletteImageSetFamily
{
    /// <summary>PaletteMode.Global — inherit; consumers leave the current images untouched.</summary>
    Inherit,

    /// <summary>The Professional (system-coloured) era.</summary>
    Professional,

    /// <summary>The Office 2003 era (Luna Blue/Olive/Silver).</summary>
    Office2003,

    /// <summary>The Office 2007 era.</summary>
    Office2007,

    /// <summary>The Office 2010 era.</summary>
    Office2010,

    /// <summary>The Office 2013 era.</summary>
    Office2013,

    /// <summary>The Microsoft 365 era (also used by Office 2016/2019/2021 and Material).</summary>
    Microsoft365,

    /// <summary>The Sparkle themes (historically borrow the Office 2010 image sets).</summary>
    Sparkle,

    /// <summary>PaletteMode.Custom — each consumer picks a sensible default image set.</summary>
    Custom
}

/// <summary>
/// Single, shared mapping from <see cref="PaletteMode"/> to the image-set family the mode's
/// visuals belong to. This consolidates the 105 duplicated <c>switch (PaletteMode)</c>
/// statements that previously lived in <c>KryptonCommand</c>, <c>KryptonHelpCommand</c> and the
/// 14 <c>KryptonIntegratedToolbar*Command</c> classes (BREAKAGE-LOG T1): those switches were not
/// updated when new modes were added (Material ×4, VisualStudio2010Render ×4,
/// Microsoft365BlackDarkModeAlternate), so their throwing <c>default</c> arms crashed at runtime.
/// Adding a new <see cref="PaletteMode"/> now only requires a case here.
/// </summary>
internal static class PaletteImageSetResolver
{
    /// <summary>
    /// Gets the image-set family for the given palette mode.
    /// </summary>
    /// <param name="mode">Palette mode to classify.</param>
    /// <returns>The <see cref="PaletteImageSetFamily"/> whose image resources the mode uses.</returns>
    internal static PaletteImageSetFamily GetImageSetFamily(PaletteMode mode)
    {
        switch (mode)
        {
            case PaletteMode.Global:
                return PaletteImageSetFamily.Inherit;

            case PaletteMode.ProfessionalSystem:
                return PaletteImageSetFamily.Professional;

            // Office 2003 era. Office2003Olive/Office2003Silver are the Bastion companions to
            // the Luna Blue ProfessionalOffice2003 palette.
            case PaletteMode.ProfessionalOffice2003:
            case PaletteMode.Office2003Olive:
            case PaletteMode.Office2003Silver:
                return PaletteImageSetFamily.Office2003;

            // Office 2007 era. VisualStudio2010Render2007 renders with the 2007 chrome, so it
            // takes the 2007 image set (matches KryptonManager.UpdatePaletteImages).
            case PaletteMode.Office2007Blue:
            case PaletteMode.Office2007BlueDarkMode:
            case PaletteMode.Office2007BlueLightMode:
            case PaletteMode.Office2007Silver:
            case PaletteMode.Office2007SilverDarkMode:
            case PaletteMode.Office2007SilverLightMode:
            case PaletteMode.Office2007White:
            case PaletteMode.Office2007Black:
            case PaletteMode.Office2007BlackDarkMode:
            case PaletteMode.VisualStudio2010Render2007:
                return PaletteImageSetFamily.Office2007;

            // Office 2010 era (VisualStudio2010Render2010 renders with the 2010 chrome).
            case PaletteMode.Office2010Blue:
            case PaletteMode.Office2010BlueDarkMode:
            case PaletteMode.Office2010BlueLightMode:
            case PaletteMode.Office2010Silver:
            case PaletteMode.Office2010SilverDarkMode:
            case PaletteMode.Office2010SilverLightMode:
            case PaletteMode.Office2010White:
            case PaletteMode.Office2010Black:
            case PaletteMode.Office2010BlackDarkMode:
            case PaletteMode.VisualStudio2010Render2010:
                return PaletteImageSetFamily.Office2010;

            // Office 2013 era (VisualStudio2010Render2013 renders with the 2013 chrome).
            case PaletteMode.Office2013White:
            case PaletteMode.VisualStudio2010Render2013:
                return PaletteImageSetFamily.Office2013;

            // Sparkle themes keep their own family so consumers can preserve the historical
            // choice of borrowed image set (Office 2010 glyphs).
            case PaletteMode.SparkleBlue:
            case PaletteMode.SparkleBlueDarkMode:
            case PaletteMode.SparkleBlueLightMode:
            case PaletteMode.SparkleOrange:
            case PaletteMode.SparkleOrangeDarkMode:
            case PaletteMode.SparkleOrangeLightMode:
            case PaletteMode.SparklePurple:
            case PaletteMode.SparklePurpleDarkMode:
            case PaletteMode.SparklePurpleLightMode:
                return PaletteImageSetFamily.Sparkle;

            // Microsoft 365 era. This also covers:
            // - VisualStudio2010Render365 (renders with the Microsoft 365 chrome);
            // - the four Material modes (Material currently borrows the Microsoft 365 image
            //   sets — see the in-source TODO in KryptonManager.UpdatePaletteImages);
            // - the Bastion Office 2016/2019/2021 palettes, whose closest existing image
            //   resources are the "Office 2019"/Microsoft 365 sets already used by the
            //   Microsoft 365 palettes.
            case PaletteMode.Microsoft365Black:
            case PaletteMode.Microsoft365BlackDarkMode:
            case PaletteMode.Microsoft365BlackDarkModeAlternate:
            case PaletteMode.Microsoft365Blue:
            case PaletteMode.Microsoft365DarkGray: // 2026 refresh: wired
            case PaletteMode.Microsoft365BlueDarkMode:
            case PaletteMode.Microsoft365BlueLightMode:
            case PaletteMode.Microsoft365Silver:
            case PaletteMode.Microsoft365SilverDarkMode:
            case PaletteMode.Microsoft365SilverLightMode:
            case PaletteMode.Microsoft365White:
            case PaletteMode.VisualStudio2010Render365:
            case PaletteMode.MaterialLight:
            case PaletteMode.MaterialDark:
            case PaletteMode.MaterialLightRipple:
            case PaletteMode.MaterialDarkRipple:
            case PaletteMode.Office2016Colorful:
            case PaletteMode.Office2016White:
            case PaletteMode.Office2016DarkGray:
            case PaletteMode.Office2019Colorful:
            case PaletteMode.Office2019White:
            case PaletteMode.Office2019DarkGray:
            case PaletteMode.Office2019Black:
            case PaletteMode.Office2021Colorful:
            case PaletteMode.Office2021White:
            case PaletteMode.Office2021DarkGray:
            case PaletteMode.Office2021Black:
                return PaletteImageSetFamily.Microsoft365;

            case PaletteMode.Custom:
                return PaletteImageSetFamily.Custom;

            default:
                // Deliberately non-throwing (unlike the T1 switches this replaces): a future
                // mode that has not yet been classified degrades to the Microsoft 365 era
                // image set (the toolkit default) instead of crashing at runtime.
                Debug.Assert(false, $"PaletteImageSetResolver: unclassified PaletteMode '{mode}'.");
                return PaletteImageSetFamily.Microsoft365;
        }
    }
}
