#region BSD License
/*
 * 
 * Original BSD 3-Clause License (https://github.com/ComponentFactory/Krypton/blob/master/LICENSE)
 *  © Component Factory Pty Ltd, 2006 - 2016, All rights reserved.
 * 
 *  New BSD 3-Clause License (https://github.com/Krypton-Suite/Standard-Toolkit/blob/master/LICENSE)
 *  Modifications by Peter Wagner (aka Wagnerp), Simon Coghlan (aka Smurf-IV), Giduac & Ahmed Abdelhameed et al. 2017 - 2025. All rights reserved.
 *  
 *  Modified: Monday 12th April, 2021 @ 18:00 GMT
 *
 */
#endregion

namespace Krypton.Ribbon;

/// <summary>
/// Draws the ribbon background panel.
/// </summary>
internal class ViewDrawRibbonPanel : ViewDrawPanel
{
    #region Static Fields

    private const int EDGE_GAP = 1;

    #endregion

    #region Instance Fields
    private readonly KryptonRibbon _ribbon;
    private readonly NeedPaintHandler _paintDelegate;
    private readonly Blend _compBlend;

    private readonly IPaletteRibbonGeneral _palette;

    #endregion

    #region Identity
    /// <summary>
    /// Initialize a new instance of the ViewDrawRibbonPanel class.
    /// </summary>
    /// <param name="ribbon">Reference to owning ribbon instance.</param>
    /// <param name="paletteBack">Reference to palette for obtaining background colors.</param>
    /// <param name="paintDelegate">Delegate for generating repaints.</param>
    /// <param name="palette">Source for palette values.</param>
    public ViewDrawRibbonPanel(KryptonRibbon ribbon,
        IPaletteBack paletteBack,
        NeedPaintHandler paintDelegate,
        IPaletteRibbonGeneral palette)
        : base(paletteBack)
    {
        _ribbon = ribbon;
        _paintDelegate = paintDelegate;
        _palette = palette;

        _compBlend = new Blend
        {
            //_compBlend.Positions = new float[] { 0.0f, 0.4f, 1.0f };
            //_compBlend.Factors = new float[] { 0.0f, 0.87f, 1.0f };
            Positions = [0.0f, 0.2f, 0.4f, 0.6f, 0.8f, 1.0f],
            Factors = [0.0f, 0.10f, 0.25f, 0.50f, 0.70f, 0.80f]
        };
    }
    #endregion

    #region Paint

    /// <summary>
    /// Perform rendering before child elements are rendered.
    /// </summary>
    /// <param name="context">Rendering context.</param>
    public override void RenderBefore([DisallowNull] RenderContext context)
    {
        // Draw the panel background (PanelClient style) as normal
        base.RenderBefore(context!);

        // Bastion Phase 3 (spec §4.3): honour the palette-declared solid tab-row background.
        // The Office 2016/2019 Colorful/DarkGray/Black looks colour the ribbon tab row
        // independently of PanelClient (accent title bar continuing behind the tabs), which the
        // palettes declare via IPaletteRibbonGeneral.GetRibbonTabRowBackgroundSolidColor. Before
        // this the value had no consumer and the tab row always showed the PanelClient fill.
        // EMPTY_COLOR (returned by the pre-2013 era palettes) keeps the legacy behaviour, and
        // every built-in M365-era palette declares the same value as its PanelClient, so this
        // paints identically for existing themes.
        Color tabRowColor = _palette.GetRibbonTabRowBackgroundSolidColor(PaletteState.Normal);
        if (tabRowColor != GlobalStaticValues.EMPTY_COLOR)
        {
            Rectangle tabsRect = _ribbon.TabsArea?.ClientRectangle ?? Rectangle.Empty;
            if (tabsRect is { Width: > 0, Height: > 0 })
            {
                using var fillBrush = new SolidBrush(tabRowColor);
                context.Graphics.FillRectangle(fillBrush, tabsRect);
            }
        }
    }

    #endregion
}