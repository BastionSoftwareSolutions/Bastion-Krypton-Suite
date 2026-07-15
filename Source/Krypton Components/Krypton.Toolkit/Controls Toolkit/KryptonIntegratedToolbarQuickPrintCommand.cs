#region BSD License
/*
 * 
 *  QuickPrint BSD 3-Clause License (https://github.com/Krypton-Suite/Standard-Toolkit/blob/master/LICENSE)
 *  Modifications by Peter Wagner(aka Wagnerp) & Simon Coghlan(aka Smurf-IV), et al. 2023 - 2025. All rights reserved. 
 *  
 */
#endregion

namespace Krypton.Toolkit;

/// <summary>A <see cref="KryptonCommand"/> created specifically for the <see cref="PaletteButtonSpecStyle.QuickPrint"/> button spec.</summary>
[Category(@"code")]
[ToolboxItem(false)]
//[ToolboxBitmap(typeof(KryptonHelpCommand), @"ToolboxBitmaps.KryptonHelp.bmp")]
[Description(@"For use with the 'QuickPrint' ButtonSpec style.")]
[DesignerCategory(@"code")]
public class KryptonIntegratedToolbarQuickPrintCommand : KryptonCommand
{
    #region Instance Fields

    private ButtonSpecAny? _quickPrintButtonSpec;

    private ButtonImageStates? _imageStates;

    private Image? _activeImage;

    private Image? _disabledImage;

    private Image? _normalImage;

    private Image? _pressedImage;

    #endregion

    #region Public

    /// <summary>Gets or sets the quick print button.</summary>
    /// <value>The quick print button.</value>
    [DefaultValue(null), Description(@"Access to the quick print button spec.")]
    [AllowNull]
    public ButtonSpecAny? ToolBarQuickPrintButton
    {
        get => _quickPrintButtonSpec ?? new ButtonSpecAny();
        set { _quickPrintButtonSpec = value; UpdateImage(KryptonManager.CurrentGlobalPaletteMode); }
    }

    /// <summary>Gets the active image.</summary>
    /// <value>The active image.</value>
    [DesignerSerializationVisibility(DesignerSerializationVisibility.Visible)]
    public Image? ActiveImage { get => _activeImage; private set => _activeImage = value; }

    /// <summary>Gets the disabled image.</summary>
    /// <value>The disabled image.</value>
    [DesignerSerializationVisibility(DesignerSerializationVisibility.Visible)]
    public Image? DisabledImage { get => _disabledImage; private set => _disabledImage = value; }

    /// <summary>Gets the normal image.</summary>
    /// <value>The normal image.</value>
    [DesignerSerializationVisibility(DesignerSerializationVisibility.Visible)]
    public Image? NormalImage { get => _normalImage; private set => _normalImage = value; }

    /// <summary>Gets the pressed image.</summary>
    /// <value>The pressed image.</value>
    [DesignerSerializationVisibility(DesignerSerializationVisibility.Visible)]
    public Image? PressedImage { get => _pressedImage; private set => _pressedImage = value; }

    #endregion

    #region Identity

    /// <summary>Initializes a new instance of the <see cref="KryptonIntegratedToolbarQuickPrintCommand" /> class.</summary>
    public KryptonIntegratedToolbarQuickPrintCommand()
    {
        _imageStates = new ButtonImageStates();

        Text = KryptonManager.Strings.ToolBarStrings.QuickPrint;
    }

    #endregion

    #region Implementation

    /// <summary>Updates the image.</summary>
    /// <param name="helpImage">The help image.</param>
    private void UpdateImage(Image? helpImage) => ImageSmall = helpImage;

    /// <summary>Adds the image states.</summary>
    /// <param name="activeImage">The active image.</param>
    /// <param name="disabledImage">The disabled image.</param>
    /// <param name="normalImage">The normal image.</param>
    /// <param name="pressedImage">The pressed image.</param>
    private void AddImageStates(Image? activeImage, Image? disabledImage, Image? normalImage, Image? pressedImage)
    {
        if (_quickPrintButtonSpec != null)
        {
            _quickPrintButtonSpec.ImageStates.ImageDisabled = disabledImage;

            _quickPrintButtonSpec.ImageStates.ImageTracking = activeImage;

            _quickPrintButtonSpec.ImageStates.ImageNormal = normalImage;

            _quickPrintButtonSpec.ImageStates.ImagePressed = pressedImage;
        }
    }

    /// <summary>Updates the active image.</summary>
    /// <param name="activeImage">The active image.</param>
    private void UpdateActiveImage(Image activeImage)
    {
        _activeImage = activeImage;

        if (_quickPrintButtonSpec != null)
        {
            _quickPrintButtonSpec.ImageStates.ImageTracking = _activeImage;
        }
    }

    /// <summary>Updates the disabled image.</summary>
    /// <param name="disabledImage">The disabled image.</param>
    private void UpdateDisabledImage(Image? disabledImage)
    {
        _disabledImage = disabledImage;

        if (_quickPrintButtonSpec != null)
        {
            _quickPrintButtonSpec.ImageStates.ImageDisabled = disabledImage;
        }
    }

    /// <summary>Updates the normal image.</summary>
    /// <param name="normalImage">The normal image.</param>
    private void UpdateNormalImage(Image? normalImage)
    {
        _normalImage = normalImage;

        if (_quickPrintButtonSpec != null)
        {
            _quickPrintButtonSpec.ImageStates.ImageNormal = normalImage;
        }
    }

    /// <summary>Updates the pressed image.</summary>
    /// <param name="pressedImage">The pressed image.</param>
    private void UpdatePressedImage(Image? pressedImage)
    {
        _pressedImage = pressedImage;

        if (_quickPrintButtonSpec != null)
        {
            _quickPrintButtonSpec.ImageStates.ImagePressed = pressedImage;
        }
    }

    /// <summary>Updates the image.</summary>
    /// <param name="mode">The mode.</param>
    /// <exception cref="System.ArgumentOutOfRangeException">mode - null</exception>
    private void UpdateImage(PaletteMode mode)
    {

        // A palette mode no longer selects images directly; the shared
        // PaletteImageSetResolver maps every PaletteMode (including future ones)
        // to its image-set family (BREAKAGE-LOG T1 consolidation).
        switch (PaletteImageSetResolver.GetImageSetFamily(mode))
        {
            case PaletteImageSetFamily.Inherit:
                break;
            case PaletteImageSetFamily.Professional:
                UpdateImage(GenericToolbarImageResources.GenericQuickPrint);
                break;
            case PaletteImageSetFamily.Office2003:
                UpdateImage(GenericToolbarImageResources.GenericQuickPrint);
                break;
            case PaletteImageSetFamily.Office2007:
                UpdateImage(Office2007ToolbarImageResources.Office2007ToolbarQuickPrintNormal);
                break;
            case PaletteImageSetFamily.Office2010:
                UpdateImage(Office2010ToolbarImageResources.Office2010ToolbarQuickPrintNormal);
                break;
            case PaletteImageSetFamily.Office2013:
                UpdateImage(Office2013ToolbarImageResources.Office2013ToolbarQuickPrintNormal);
                break;
            case PaletteImageSetFamily.Microsoft365:
                UpdateImage(Office2019ToolbarImageResources.Office2019ToolbarQuickPrintNormal);
                break;
            case PaletteImageSetFamily.Sparkle:
                UpdateImage(Office2010ToolbarImageResources.Office2010ToolbarQuickPrintNormal);
                break;
            case PaletteImageSetFamily.Custom:
                UpdateImage(Office2010ToolbarImageResources.Office2010ToolbarQuickPrintNormal);
                break;
        }

        UpdateActiveImage(mode);

        UpdateDisabledImage(mode);

        UpdateNormalImage(mode);

        UpdatePressedImage(mode);
    }

    /// <summary>Updates the active image.</summary>
    /// <param name="mode">The mode.</param>
    /// <exception cref="System.ArgumentOutOfRangeException">mode - null</exception>
    private void UpdateActiveImage(PaletteMode mode)
    {
        // A palette mode no longer selects images directly; the shared
        // PaletteImageSetResolver maps every PaletteMode (including future ones)
        // to its image-set family (BREAKAGE-LOG T1 consolidation).
        switch (PaletteImageSetResolver.GetImageSetFamily(mode))
        {
            case PaletteImageSetFamily.Inherit:
                break;
            case PaletteImageSetFamily.Professional:
                UpdateActiveImage(GenericToolbarImageResources.GenericQuickPrint);
                break;
            case PaletteImageSetFamily.Office2003:
                UpdateActiveImage(GenericToolbarImageResources.GenericQuickPrint);
                break;
            case PaletteImageSetFamily.Office2007:
                UpdateActiveImage(Office2007ToolbarImageResources.Office2007ToolbarQuickPrintNormal);
                break;
            case PaletteImageSetFamily.Office2010:
                UpdateActiveImage(Office2010ToolbarImageResources.Office2010ToolbarQuickPrintNormal);
                break;
            case PaletteImageSetFamily.Office2013:
                UpdateActiveImage(Office2013ToolbarImageResources.Office2013ToolbarQuickPrintNormal);
                break;
            case PaletteImageSetFamily.Microsoft365:
                UpdateActiveImage(Office2019ToolbarImageResources.Office2019ToolbarQuickPrintNormal);
                break;
            case PaletteImageSetFamily.Sparkle:
                UpdateActiveImage(Office2010ToolbarImageResources.Office2010ToolbarQuickPrintNormal);
                break;
            case PaletteImageSetFamily.Custom:
                break;
        }
    }

    /// <summary>Updates the disabled image.</summary>
    /// <param name="mode">The mode.</param>
    /// <exception cref="System.ArgumentOutOfRangeException">mode - null</exception>
    private void UpdateDisabledImage(PaletteMode mode)
    {
        // A palette mode no longer selects images directly; the shared
        // PaletteImageSetResolver maps every PaletteMode (including future ones)
        // to its image-set family (BREAKAGE-LOG T1 consolidation).
        switch (PaletteImageSetResolver.GetImageSetFamily(mode))
        {
            case PaletteImageSetFamily.Inherit:
                break;
            case PaletteImageSetFamily.Professional:
                UpdateActiveImage(GenericToolbarImageResources.GenericQuickPrint);
                break;
            case PaletteImageSetFamily.Office2003:
                UpdateActiveImage(GenericToolbarImageResources.GenericQuickPrint);
                break;
            case PaletteImageSetFamily.Office2007:
                UpdateActiveImage(Office2007ToolbarImageResources.Office2007ToolbarQuickPrintDisabled);
                break;
            case PaletteImageSetFamily.Office2010:
                UpdateActiveImage(Office2010ToolbarImageResources.Office2010ToolbarQuickPrintDisabled);
                break;
            case PaletteImageSetFamily.Office2013:
                UpdateActiveImage(Office2013ToolbarImageResources.Office2013ToolbarQuickPrintDisabled);
                break;
            case PaletteImageSetFamily.Microsoft365:
                UpdateActiveImage(Office2019ToolbarImageResources.Office2019ToolbarQuickPrintDisabled);
                break;
            case PaletteImageSetFamily.Sparkle:
                UpdateActiveImage(Office2010ToolbarImageResources.Office2010ToolbarQuickPrintDisabled);
                break;
            case PaletteImageSetFamily.Custom:
                break;
        }
    }

    /// <summary>Updates the normal image.</summary>
    /// <param name="mode">The mode.</param>
    /// <exception cref="System.ArgumentOutOfRangeException">mode - null</exception>
    private void UpdateNormalImage(PaletteMode mode)
    {
        // A palette mode no longer selects images directly; the shared
        // PaletteImageSetResolver maps every PaletteMode (including future ones)
        // to its image-set family (BREAKAGE-LOG T1 consolidation).
        switch (PaletteImageSetResolver.GetImageSetFamily(mode))
        {
            case PaletteImageSetFamily.Inherit:
                break;
            case PaletteImageSetFamily.Professional:
                UpdateActiveImage(GenericToolbarImageResources.GenericQuickPrint);
                break;
            case PaletteImageSetFamily.Office2003:
                UpdateActiveImage(GenericToolbarImageResources.GenericQuickPrint);
                break;
            case PaletteImageSetFamily.Office2007:
                UpdateActiveImage(Office2007ToolbarImageResources.Office2007ToolbarQuickPrintNormal);
                break;
            case PaletteImageSetFamily.Office2010:
                UpdateActiveImage(Office2010ToolbarImageResources.Office2010ToolbarQuickPrintNormal);
                break;
            case PaletteImageSetFamily.Office2013:
                UpdateActiveImage(Office2013ToolbarImageResources.Office2013ToolbarQuickPrintNormal);
                break;
            case PaletteImageSetFamily.Microsoft365:
                UpdateActiveImage(Office2019ToolbarImageResources.Office2019ToolbarQuickPrintNormal);
                break;
            case PaletteImageSetFamily.Sparkle:
                UpdateActiveImage(Office2010ToolbarImageResources.Office2010ToolbarQuickPrintNormal);
                break;
            case PaletteImageSetFamily.Custom:
                break;
        }
    }

    /// <summary>Updates the pressed image.</summary>
    /// <param name="mode">The mode.</param>
    /// <exception cref="System.ArgumentOutOfRangeException">mode - null</exception>
    private void UpdatePressedImage(PaletteMode mode)
    {
        // A palette mode no longer selects images directly; the shared
        // PaletteImageSetResolver maps every PaletteMode (including future ones)
        // to its image-set family (BREAKAGE-LOG T1 consolidation).
        switch (PaletteImageSetResolver.GetImageSetFamily(mode))
        {
            case PaletteImageSetFamily.Inherit:
                break;
            case PaletteImageSetFamily.Professional:
                UpdateActiveImage(GenericToolbarImageResources.GenericQuickPrint);
                break;
            case PaletteImageSetFamily.Office2003:
                UpdateActiveImage(GenericToolbarImageResources.GenericQuickPrint);
                break;
            case PaletteImageSetFamily.Office2007:
                UpdateActiveImage(Office2007ToolbarImageResources.Office2007ToolbarQuickPrintNormal);
                break;
            case PaletteImageSetFamily.Office2010:
                UpdateActiveImage(Office2010ToolbarImageResources.Office2010ToolbarQuickPrintNormal);
                break;
            case PaletteImageSetFamily.Office2013:
                UpdateActiveImage(Office2013ToolbarImageResources.Office2013ToolbarQuickPrintNormal);
                break;
            case PaletteImageSetFamily.Microsoft365:
                UpdateActiveImage(Office2010ToolbarImageResources.Office2010ToolbarQuickPrintNormal);
                break;
            case PaletteImageSetFamily.Sparkle:
                UpdateActiveImage(Office2010ToolbarImageResources.Office2010ToolbarQuickPrintNormal);
                break;
            case PaletteImageSetFamily.Custom:
                break;
        }
    }

    /// <summary>Updates the image states.</summary>
    /// <param name="mode">The mode.</param>
    /// <exception cref="System.ArgumentOutOfRangeException">mode - null</exception>
    private void UpdateImageStates(PaletteMode mode)
    {
        if (_quickPrintButtonSpec != null)
        {
            // A palette mode no longer selects images directly; the shared
            // PaletteImageSetResolver maps every PaletteMode (including future ones)
            // to its image-set family (BREAKAGE-LOG T1 consolidation).
            switch (PaletteImageSetResolver.GetImageSetFamily(mode))
            {
                case PaletteImageSetFamily.Inherit:
                    break;
                case PaletteImageSetFamily.Professional:
                    AddImageStates(null, GenericToolbarImageResources.GenericQuickPrint, GenericToolbarImageResources.GenericQuickPrint, null);
                    break;
                case PaletteImageSetFamily.Office2003:
                    AddImageStates(null, GenericToolbarImageResources.GenericQuickPrint, GenericToolbarImageResources.GenericQuickPrint, null);
                    break;
                case PaletteImageSetFamily.Office2007:
                    AddImageStates(Office2007ToolbarImageResources.Office2007ToolbarQuickPrintNormal, Office2007ToolbarImageResources.Office2007ToolbarQuickPrintDisabled, Office2007ToolbarImageResources.Office2007ToolbarQuickPrintNormal, Office2007ToolbarImageResources.Office2007ToolbarQuickPrintNormal);
                    break;
                case PaletteImageSetFamily.Office2010:
                    AddImageStates(Office2010ToolbarImageResources.Office2010ToolbarQuickPrintNormal, Office2010ToolbarImageResources.Office2010ToolbarQuickPrintDisabled, Office2010ToolbarImageResources.Office2010ToolbarQuickPrintNormal, Office2010ToolbarImageResources.Office2010ToolbarQuickPrintNormal);
                    break;
                case PaletteImageSetFamily.Office2013:
                    AddImageStates(Office2019ToolbarImageResources.Office2019ToolbarQuickPrintNormal, Office2019ToolbarImageResources.Office2019ToolbarQuickPrintDisabled, Office2019ToolbarImageResources.Office2019ToolbarQuickPrintNormal, Office2019ToolbarImageResources.Office2019ToolbarQuickPrintNormal);
                    break;
                case PaletteImageSetFamily.Microsoft365:
                    AddImageStates(Office2019ToolbarImageResources.Office2019ToolbarQuickPrintNormal, Office2019ToolbarImageResources.Office2019ToolbarQuickPrintDisabled, Office2019ToolbarImageResources.Office2019ToolbarQuickPrintNormal, Office2019ToolbarImageResources.Office2019ToolbarQuickPrintNormal);
                    break;
                case PaletteImageSetFamily.Sparkle:
                    AddImageStates(Office2010ToolbarImageResources.Office2010ToolbarQuickPrintNormal, Office2010ToolbarImageResources.Office2010ToolbarQuickPrintDisabled, Office2010ToolbarImageResources.Office2010ToolbarQuickPrintNormal, Office2010ToolbarImageResources.Office2010ToolbarQuickPrintNormal);
                    break;
                case PaletteImageSetFamily.Custom:
                    AddImageStates(Office2019ToolbarImageResources.Office2019ToolbarQuickPrintNormal, Office2019ToolbarImageResources.Office2019ToolbarQuickPrintDisabled, Office2019ToolbarImageResources.Office2019ToolbarQuickPrintNormal, Office2019ToolbarImageResources.Office2019ToolbarQuickPrintNormal);
                    break;
            }
        }
    }

    #endregion
}
