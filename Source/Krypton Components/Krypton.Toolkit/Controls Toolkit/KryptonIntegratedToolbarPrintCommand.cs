#region BSD License
/*
 * 
 *  Print BSD 3-Clause License (https://github.com/Krypton-Suite/Standard-Toolkit/blob/master/LICENSE)
 *  Modifications by Peter Wagner(aka Wagnerp) & Simon Coghlan(aka Smurf-IV), et al. 2023 - 2025. All rights reserved. 
 *  
 */
#endregion

namespace Krypton.Toolkit;

/// <summary>A <see cref="KryptonCommand"/> created specifically for the <see cref="PaletteButtonSpecStyle.Print"/> button spec.</summary>
[Category(@"code")]
[ToolboxItem(false)]
//[ToolboxBitmap(typeof(KryptonHelpCommand), @"ToolboxBitmaps.KryptonHelp.bmp")]
[Description(@"For use with the 'Print' ButtonSpec style.")]
[DesignerCategory(@"code")]
public class KryptonIntegratedToolbarPrintCommand : KryptonCommand
{
    #region Instance Fields

    private ButtonSpecAny? _printButtonSpec;

    private PaletteButtonSpecStyle _style;

    private ButtonImageStates? _imageStates;

    private Image? _activeImage;

    private Image? _disabledImage;

    private Image? _normalImage;

    private Image? _pressedImage;

    #endregion

    #region Public

    /// <summary>Gets the button spec style.</summary>
    /// <value>The button spec style.</value>
    [DesignerSerializationVisibility(DesignerSerializationVisibility.Hidden)]
    public PaletteButtonSpecStyle ButtonSpecStyle 
    { 
        get => _style; 
        private set 
        { 
            _style = value; 
            UpdateButtonSpec(); 
        } 
    }

    /// <summary>Gets or sets the print button.</summary>
    /// <value>The print button.</value>
    [DefaultValue(null), Description(@"Access to the print button spec.")]
    [AllowNull]
    public ButtonSpecAny? ToolBarPrintButton
    {
        get => _printButtonSpec ?? new ButtonSpecAny();
        set { _printButtonSpec = value; UpdateImage(KryptonManager.CurrentGlobalPaletteMode); UpdateButtonSpec(); }
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

    /// <summary>Initializes a new instance of the <see cref="KryptonIntegratedToolbarPrintCommand" /> class.</summary>
    public KryptonIntegratedToolbarPrintCommand()
    {
        _imageStates = new ButtonImageStates();

        _style = PaletteButtonSpecStyle.Print;

        _printButtonSpec = null;

        Text = KryptonManager.Strings.ToolBarStrings.Print;
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
        if (_printButtonSpec != null)
        {
            _printButtonSpec.ImageStates.ImageDisabled = disabledImage;

            _printButtonSpec.ImageStates.ImageTracking = activeImage;

            _printButtonSpec.ImageStates.ImageNormal = normalImage;

            _printButtonSpec.ImageStates.ImagePressed = pressedImage;
        }
    }

    /// <summary>Updates the active image.</summary>
    /// <param name="activeImage">The active image.</param>
    private void UpdateActiveImage(Image activeImage)
    {
        _activeImage = activeImage;

        if (_printButtonSpec != null)
        {
            _printButtonSpec.ImageStates.ImageTracking = _activeImage;
        }
    }

    /// <summary>Updates the disabled image.</summary>
    /// <param name="disabledImage">The disabled image.</param>
    private void UpdateDisabledImage(Image? disabledImage)
    {
        _disabledImage = disabledImage;

        if (_printButtonSpec != null)
        {
            _printButtonSpec.ImageStates.ImageDisabled = disabledImage;
        }
    }

    /// <summary>Updates the normal image.</summary>
    /// <param name="normalImage">The normal image.</param>
    private void UpdateNormalImage(Image? normalImage)
    {
        _normalImage = normalImage;

        if (_printButtonSpec != null)
        {
            _printButtonSpec.ImageStates.ImageNormal = normalImage;
        }
    }

    /// <summary>Updates the pressed image.</summary>
    /// <param name="pressedImage">The pressed image.</param>
    private void UpdatePressedImage(Image? pressedImage)
    {
        _pressedImage = pressedImage;

        if (_printButtonSpec != null)
        {
            _printButtonSpec.ImageStates.ImagePressed = pressedImage;
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
                UpdateImage(SystemToolbarImageResources.SystemToolbarPrintNormal);
                break;
            case PaletteImageSetFamily.Office2003:
                UpdateImage(Office2003ToolbarImageResources.Office2003ToolbarPrintNormal);
                break;
            case PaletteImageSetFamily.Office2007:
                UpdateImage(Office2007ToolbarImageResources.Office2007ToolbarPrintNormal);
                break;
            case PaletteImageSetFamily.Office2010:
                UpdateImage(Office2010ToolbarImageResources.Office2010ToolbarPrintNormal);
                break;
            case PaletteImageSetFamily.Office2013:
                UpdateImage(Office2013ToolbarImageResources.Office2013ToolbarPrintNormal);
                break;
            case PaletteImageSetFamily.Microsoft365:
                UpdateImage(Office2019ToolbarImageResources.Office2019ToolbarPrintNormal);
                break;
            case PaletteImageSetFamily.Sparkle:
                UpdateImage(Office2010ToolbarImageResources.Office2010ToolbarPrintNormal);
                break;
            case PaletteImageSetFamily.Custom:
                UpdateImage(Office2010ToolbarImageResources.Office2010ToolbarPrintNormal);
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
                UpdateActiveImage(SystemToolbarImageResources.SystemToolbarPrintNormal);
                break;
            case PaletteImageSetFamily.Office2003:
                UpdateActiveImage(Office2003ToolbarImageResources.Office2003ToolbarPrintNormal);
                break;
            case PaletteImageSetFamily.Office2007:
                UpdateActiveImage(Office2007ToolbarImageResources.Office2007ToolbarPrintNormal);
                break;
            case PaletteImageSetFamily.Office2010:
                UpdateActiveImage(Office2010ToolbarImageResources.Office2010ToolbarPrintNormal);
                break;
            case PaletteImageSetFamily.Office2013:
                UpdateActiveImage(Office2013ToolbarImageResources.Office2013ToolbarPrintNormal);
                break;
            case PaletteImageSetFamily.Microsoft365:
                UpdateActiveImage(Office2019ToolbarImageResources.Office2019ToolbarPrintNormal);
                break;
            case PaletteImageSetFamily.Sparkle:
                UpdateActiveImage(Office2010ToolbarImageResources.Office2010ToolbarPrintNormal);
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
                UpdateActiveImage(SystemToolbarImageResources.SystemToolbarPrintDisabled);
                break;
            case PaletteImageSetFamily.Office2003:
                UpdateActiveImage(Office2003ToolbarImageResources.Office2003ToolbarPrintDisabled);
                break;
            case PaletteImageSetFamily.Office2007:
                UpdateActiveImage(Office2007ToolbarImageResources.Office2007ToolbarPrintDisabled);
                break;
            case PaletteImageSetFamily.Office2010:
                UpdateActiveImage(Office2010ToolbarImageResources.Office2010ToolbarPrintDisabled);
                break;
            case PaletteImageSetFamily.Office2013:
                UpdateActiveImage(Office2013ToolbarImageResources.Office2013ToolbarPrintDisabled);
                break;
            case PaletteImageSetFamily.Microsoft365:
                UpdateActiveImage(Office2019ToolbarImageResources.Office2019ToolbarPrintDisabled);
                break;
            case PaletteImageSetFamily.Sparkle:
                UpdateActiveImage(Office2010ToolbarImageResources.Office2010ToolbarPrintDisabled);
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
                UpdateActiveImage(SystemToolbarImageResources.SystemToolbarPrintNormal);
                break;
            case PaletteImageSetFamily.Office2003:
                UpdateActiveImage(Office2003ToolbarImageResources.Office2003ToolbarPrintNormal);
                break;
            case PaletteImageSetFamily.Office2007:
                UpdateActiveImage(Office2007ToolbarImageResources.Office2007ToolbarPrintNormal);
                break;
            case PaletteImageSetFamily.Office2010:
                UpdateActiveImage(Office2010ToolbarImageResources.Office2010ToolbarPrintNormal);
                break;
            case PaletteImageSetFamily.Office2013:
                UpdateActiveImage(Office2013ToolbarImageResources.Office2013ToolbarPrintNormal);
                break;
            case PaletteImageSetFamily.Microsoft365:
                UpdateActiveImage(Office2019ToolbarImageResources.Office2019ToolbarPrintNormal);
                break;
            case PaletteImageSetFamily.Sparkle:
                UpdateActiveImage(Office2010ToolbarImageResources.Office2010ToolbarPrintNormal);
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
                UpdateActiveImage(SystemToolbarImageResources.SystemToolbarPrintNormal);
                break;
            case PaletteImageSetFamily.Office2003:
                UpdateActiveImage(Office2003ToolbarImageResources.Office2003ToolbarPrintNormal);
                break;
            case PaletteImageSetFamily.Office2007:
                UpdateActiveImage(Office2007ToolbarImageResources.Office2007ToolbarPrintNormal);
                break;
            case PaletteImageSetFamily.Office2010:
                UpdateActiveImage(Office2010ToolbarImageResources.Office2010ToolbarPrintNormal);
                break;
            case PaletteImageSetFamily.Office2013:
                UpdateActiveImage(Office2013ToolbarImageResources.Office2013ToolbarPrintNormal);
                break;
            case PaletteImageSetFamily.Microsoft365:
                UpdateActiveImage(Office2019ToolbarImageResources.Office2019ToolbarPrintNormal);
                break;
            case PaletteImageSetFamily.Sparkle:
                UpdateActiveImage(Office2010ToolbarImageResources.Office2010ToolbarPrintNormal);
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
        if (_printButtonSpec != null)
        {
            // A palette mode no longer selects images directly; the shared
            // PaletteImageSetResolver maps every PaletteMode (including future ones)
            // to its image-set family (BREAKAGE-LOG T1 consolidation).
            switch (PaletteImageSetResolver.GetImageSetFamily(mode))
            {
                case PaletteImageSetFamily.Inherit:
                    break;
                case PaletteImageSetFamily.Professional:
                    AddImageStates(null, SystemToolbarImageResources.SystemToolbarPrintDisabled, SystemToolbarImageResources.SystemToolbarPrintNormal, null);
                    break;
                case PaletteImageSetFamily.Office2003:
                    AddImageStates(null, Office2003ToolbarImageResources.Office2003ToolbarPrintDisabled, Office2003ToolbarImageResources.Office2003ToolbarPrintNormal, null);
                    break;
                case PaletteImageSetFamily.Office2007:
                    AddImageStates(Office2007ToolbarImageResources.Office2007ToolbarPrintNormal, Office2007ToolbarImageResources.Office2007ToolbarPrintDisabled, Office2007ToolbarImageResources.Office2007ToolbarPrintNormal, Office2007ToolbarImageResources.Office2007ToolbarPrintNormal);
                    break;
                case PaletteImageSetFamily.Office2010:
                    AddImageStates(Office2010ToolbarImageResources.Office2010ToolbarPrintNormal, Office2010ToolbarImageResources.Office2010ToolbarPrintDisabled, Office2010ToolbarImageResources.Office2010ToolbarPrintNormal, Office2010ToolbarImageResources.Office2010ToolbarPrintNormal);
                    break;
                case PaletteImageSetFamily.Office2013:
                    AddImageStates(Office2019ToolbarImageResources.Office2019ToolbarPrintNormal, Office2019ToolbarImageResources.Office2019ToolbarPrintDisabled, Office2019ToolbarImageResources.Office2019ToolbarPrintNormal, Office2019ToolbarImageResources.Office2019ToolbarPrintNormal);
                    break;
                case PaletteImageSetFamily.Microsoft365:
                    AddImageStates(Office2019ToolbarImageResources.Office2019ToolbarPrintNormal, Office2019ToolbarImageResources.Office2019ToolbarPrintDisabled, Office2019ToolbarImageResources.Office2019ToolbarPrintNormal, Office2019ToolbarImageResources.Office2019ToolbarPrintNormal);
                    break;
                case PaletteImageSetFamily.Sparkle:
                    AddImageStates(Office2010ToolbarImageResources.Office2010ToolbarPrintNormal, Office2010ToolbarImageResources.Office2010ToolbarPrintDisabled, Office2010ToolbarImageResources.Office2010ToolbarPrintNormal, Office2010ToolbarImageResources.Office2010ToolbarPrintNormal);
                    break;
                case PaletteImageSetFamily.Custom:
                    AddImageStates(Office2019ToolbarImageResources.Office2019ToolbarPrintNormal, Office2019ToolbarImageResources.Office2019ToolbarPrintDisabled, Office2019ToolbarImageResources.Office2019ToolbarPrintNormal, Office2019ToolbarImageResources.Office2019ToolbarPrintNormal);
                    break;
            }
        }
    }

    private void UpdateButtonSpec()
    {
        if (_printButtonSpec != null)
        {
            _printButtonSpec.Type = _style;
        }
    }

    #endregion
}
