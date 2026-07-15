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
/// Provides the Office 2003 Silver ("Metallic") appearance — the companion to the
/// Luna Blue look supplied by <see cref="PaletteProfessionalOffice2003"/>.
/// </summary>
public class PaletteOffice2003Silver : PaletteProfessionalOffice2003
{
    #region Static Fields
    // The Metallic header gradient pair upstream previously only used on Windows XP
    // (see the BREAKAGE-LOG T2 note in PaletteProfessionalOffice2003.GenerateColorTable).
    private static readonly Color[] _colorsSilver =
    [
        Color.FromArgb(168, 167, 191),   // Header1Begin
        Color.FromArgb(113, 112, 145) // Header1End
    ];
    #endregion

    #region Identity
    /// <summary>
    /// Initialize a new instance of the PaletteOffice2003Silver class.
    /// </summary>
    public PaletteOffice2003Silver()
        : base(new PaletteOffice2003Silver_BaseScheme())
    {
        ThemeName = nameof(PaletteOffice2003Silver);
    }
    #endregion

    #region Header Colors
    /// <inheritdoc />
    protected override Color[] HeaderColors => _colorsSilver;
    #endregion
}
