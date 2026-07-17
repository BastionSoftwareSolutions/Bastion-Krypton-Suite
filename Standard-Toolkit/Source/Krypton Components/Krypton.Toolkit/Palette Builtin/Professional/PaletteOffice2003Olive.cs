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
/// Provides the Office 2003 Olive Green ("Homestead") appearance — the companion to the
/// Luna Blue look supplied by <see cref="PaletteProfessionalOffice2003"/>.
/// </summary>
public class PaletteOffice2003Olive : PaletteProfessionalOffice2003
{
    #region Static Fields
    // [T] office2003-colours.md [B] InitOliveLunaColors: msocbvcrOLKFolderbarLight/Dark
    // (175,192,130 / 96,119,66). The upstream End value (99,122,69) was off by a few
    // channels from Microsoft's table — corrected in the Phase 3 fidelity pass.
    // (See the BREAKAGE-LOG T2 note in PaletteProfessionalOffice2003.GenerateColorTable.)
    private static readonly Color[] _colorsOlive =
    [
        Color.FromArgb(175, 192, 130),   // Header1Begin — msocbvcrOLKFolderbarLight
        Color.FromArgb( 96, 119,  66) // Header1End — msocbvcrOLKFolderbarDark
    ];
    #endregion

    #region Identity
    /// <summary>
    /// Initialize a new instance of the PaletteOffice2003Olive class.
    /// </summary>
    public PaletteOffice2003Olive()
        : base(new PaletteOffice2003Olive_BaseScheme())
    {
        ThemeName = nameof(PaletteOffice2003Olive);
    }
    #endregion

    #region Header Colors
    /// <inheritdoc />
    protected override Color[] HeaderColors => _colorsOlive;
    #endregion
}
