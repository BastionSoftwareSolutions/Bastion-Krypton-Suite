#region BSD License
/*
 * 
 *  Copy BSD 3-Clause License (https://github.com/Krypton-Suite/Standard-Toolkit/blob/master/LICENSE)
 *  Modifications by Peter Wagner(aka Wagnerp) & Simon Coghlan(aka Smurf-IV), et al. 2023 - 2025. All rights reserved. 
 *  
 */
#endregion

namespace Krypton.Toolkit;

/// <summary>A <see cref="KryptonCommand"/> created specifically for the <see cref="PaletteButtonSpecStyle.Copy"/> button spec.</summary>
[Category(@"code")]
[ToolboxItem(false)]
//[ToolboxBitmap(typeof(KryptonHelpCommand), @"ToolboxBitmaps.KryptonHelp.bmp")]
[Description(@"For use with the 'Copy' ButtonSpec style.")]
[DesignerCategory(@"code")]
public class KryptonIntegratedToolbarCopyCommand : KryptonCommand
{
    #region Instance Fields

    private ButtonSpecAny? _copyButtonSpec;

    private ButtonImageStates? _imageStates;

    private Image? _activeImage;

    private Image? _disabledImage;

    private Image? _normalImage;

    private Image? _pressedImage;


    #endregion

    #region Public

    /// <summary>Gets or sets the copy button.</summary>
    /// <value>The copy button.</value>
    [DefaultValue(null), Description(@"Access to the copy button spec.")]
    [AllowNull]
    public ButtonSpecAny? ToolBarCopyButton
    {
        get => _copyButtonSpec ?? new ButtonSpecAny();
        set { _copyButtonSpec = value; UpdateImage(KryptonManager.CurrentGlobalPaletteMode); }
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

    /// <summary>Initializes a new instance of the <see cref="KryptonIntegratedToolbarCopyCommand" /> class.</summary>
    public KryptonIntegratedToolbarCopyCommand()
    {
        _imageStates = new ButtonImageStates();

        Text = KryptonManager.Strings.ToolBarStrings.Copy;
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
        if (_copyButtonSpec != null)
        {
            _copyButtonSpec.ImageStates.ImageDisabled = disabledImage;

            _copyButtonSpec.ImageStates.ImageTracking = activeImage ?? null;

            _copyButtonSpec.ImageStates.ImageNormal = normalImage;

            _copyButtonSpec.ImageStates.ImagePressed = pressedImage ?? null;
        }
    }

    /// <summary>Updates the active image.</summary>
    /// <param name="activeImage">The active image.</param>
    private void UpdateActiveImage(Image activeImage)
    {
        _activeImage = activeImage;

        if (_copyButtonSpec != null)
        {
            _copyButtonSpec.ImageStates.ImageTracking = _activeImage;
        }
    }

    /// <summary>Updates the disabled image.</summary>
    /// <param name="disabledImage">The disabled image.</param>
    private void UpdateDisabledImage(Image? disabledImage)
    {
        _disabledImage = disabledImage;

        if (_copyButtonSpec != null)
        {
            _copyButtonSpec.ImageStates.ImageDisabled = disabledImage;
        }
    }

    /// <summary>Updates the normal image.</summary>
    /// <param name="normalImage">The normal image.</param>
    private void UpdateNormalImage(Image? normalImage)
    {
        _normalImage = normalImage;

        if (_copyButtonSpec != null)
        {
            _copyButtonSpec.ImageStates.ImageNormal = normalImage;
        }
    }

    /// <summary>Updates the pressed image.</summary>
    /// <param name="pressedImage">The pressed image.</param>
    private void UpdatePressedImage(Image? pressedImage)
    {
        _pressedImage = pressedImage;

        if (_copyButtonSpec != null)
        {
            _copyButtonSpec.ImageStates.ImagePressed = pressedImage;
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
                UpdateImage(SystemToolbarImageResources.SystemToolbarCopyNormal);
                break;
            case PaletteImageSetFamily.Office2003:
                UpdateImage(Office2003ToolbarImageResources.Office2003ToolbarCopyNormal);
                break;
            case PaletteImageSetFamily.Office2007:
                UpdateImage(Office2007ToolbarImageResources.Office2007ToolbarCopyNormal);
                break;
            case PaletteImageSetFamily.Office2010:
                UpdateImage(Office2010ToolbarImageResources.Office2010ToolbarCopyNormal);
                break;
            case PaletteImageSetFamily.Office2013:
                UpdateImage(Office2013ToolbarImageResources.Office2013ToolbarCopyNormal);
                break;
            case PaletteImageSetFamily.Microsoft365:
                UpdateImage(Office2019ToolbarImageResources.Office2019ToolbarCopyNormal);
                break;
            case PaletteImageSetFamily.Sparkle:
                UpdateImage(Office2010ToolbarImageResources.Office2010ToolbarCopyNormal);
                break;
            case PaletteImageSetFamily.Custom:
                UpdateImage(Office2010ToolbarImageResources.Office2010ToolbarCopyNormal);
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
                UpdateActiveImage(SystemToolbarImageResources.SystemToolbarCopyNormal);
                break;
            case PaletteImageSetFamily.Office2003:
                UpdateActiveImage(Office2003ToolbarImageResources.Office2003ToolbarCopyNormal);
                break;
            case PaletteImageSetFamily.Office2007:
                UpdateActiveImage(Office2007ToolbarImageResources.Office2007ToolbarCopyNormal);
                break;
            case PaletteImageSetFamily.Office2010:
                UpdateActiveImage(Office2010ToolbarImageResources.Office2010ToolbarCopyNormal);
                break;
            case PaletteImageSetFamily.Office2013:
                UpdateActiveImage(Office2013ToolbarImageResources.Office2013ToolbarCopyNormal);
                break;
            case PaletteImageSetFamily.Microsoft365:
                UpdateActiveImage(Office2019ToolbarImageResources.Office2019ToolbarCopyNormal);
                break;
            case PaletteImageSetFamily.Sparkle:
                UpdateActiveImage(Office2010ToolbarImageResources.Office2010ToolbarCopyNormal);
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
                UpdateActiveImage(SystemToolbarImageResources.SystemToolbarCopyDisabled);
                break;
            case PaletteImageSetFamily.Office2003:
                UpdateActiveImage(Office2003ToolbarImageResources.Office2003ToolbarCopyDisabled);
                break;
            case PaletteImageSetFamily.Office2007:
                UpdateActiveImage(Office2007ToolbarImageResources.Office2007ToolbarCopyDisabled);
                break;
            case PaletteImageSetFamily.Office2010:
                UpdateActiveImage(Office2010ToolbarImageResources.Office2010ToolbarCopyDisabled);
                break;
            case PaletteImageSetFamily.Office2013:
                UpdateActiveImage(Office2013ToolbarImageResources.Office2013ToolbarCopyDisabled);
                break;
            case PaletteImageSetFamily.Microsoft365:
                UpdateActiveImage(Office2019ToolbarImageResources.Office2019ToolbarCopyDisabled);
                break;
            case PaletteImageSetFamily.Sparkle:
                UpdateActiveImage(Office2010ToolbarImageResources.Office2010ToolbarCopyDisabled);
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
                UpdateActiveImage(SystemToolbarImageResources.SystemToolbarCopyNormal);
                break;
            case PaletteImageSetFamily.Office2003:
                UpdateActiveImage(Office2003ToolbarImageResources.Office2003ToolbarCopyNormal);
                break;
            case PaletteImageSetFamily.Office2007:
                UpdateActiveImage(Office2007ToolbarImageResources.Office2007ToolbarCopyNormal);
                break;
            case PaletteImageSetFamily.Office2010:
                UpdateActiveImage(Office2010ToolbarImageResources.Office2010ToolbarCopyNormal);
                break;
            case PaletteImageSetFamily.Office2013:
                UpdateActiveImage(Office2013ToolbarImageResources.Office2013ToolbarCopyNormal);
                break;
            case PaletteImageSetFamily.Microsoft365:
                UpdateActiveImage(Office2019ToolbarImageResources.Office2019ToolbarCopyNormal);
                break;
            case PaletteImageSetFamily.Sparkle:
                UpdateActiveImage(Office2010ToolbarImageResources.Office2010ToolbarCopyNormal);
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
                UpdateActiveImage(SystemToolbarImageResources.SystemToolbarCopyNormal);
                break;
            case PaletteImageSetFamily.Office2003:
                UpdateActiveImage(Office2003ToolbarImageResources.Office2003ToolbarCopyNormal);
                break;
            case PaletteImageSetFamily.Office2007:
                UpdateActiveImage(Office2007ToolbarImageResources.Office2007ToolbarCopyNormal);
                break;
            case PaletteImageSetFamily.Office2010:
                UpdateActiveImage(Office2010ToolbarImageResources.Office2010ToolbarCopyNormal);
                break;
            case PaletteImageSetFamily.Office2013:
                UpdateActiveImage(Office2013ToolbarImageResources.Office2013ToolbarCopyNormal);
                break;
            case PaletteImageSetFamily.Microsoft365:
                UpdateActiveImage(Office2019ToolbarImageResources.Office2019ToolbarCopyNormal);
                break;
            case PaletteImageSetFamily.Sparkle:
                UpdateActiveImage(Office2010ToolbarImageResources.Office2010ToolbarCopyNormal);
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
        if (_copyButtonSpec != null)
        {
            // A palette mode no longer selects images directly; the shared
            // PaletteImageSetResolver maps every PaletteMode (including future ones)
            // to its image-set family (BREAKAGE-LOG T1 consolidation).
            switch (PaletteImageSetResolver.GetImageSetFamily(mode))
            {
                case PaletteImageSetFamily.Inherit:
                    break;
                case PaletteImageSetFamily.Professional:
                    AddImageStates(null, SystemToolbarImageResources.SystemToolbarCopyDisabled, SystemToolbarImageResources.SystemToolbarCopyNormal, null);
                    break;
                case PaletteImageSetFamily.Office2003:
                    AddImageStates(null, Office2003ToolbarImageResources.Office2003ToolbarCopyDisabled, Office2003ToolbarImageResources.Office2003ToolbarCopyNormal, null);
                    break;
                case PaletteImageSetFamily.Office2007:
                    AddImageStates(Office2007ToolbarImageResources.Office2007ToolbarCopyNormal, Office2007ToolbarImageResources.Office2007ToolbarCopyDisabled, Office2007ToolbarImageResources.Office2007ToolbarCopyNormal, Office2007ToolbarImageResources.Office2007ToolbarCopyNormal);
                    break;
                case PaletteImageSetFamily.Office2010:
                    AddImageStates(Office2010ToolbarImageResources.Office2010ToolbarCopyNormal, Office2010ToolbarImageResources.Office2010ToolbarCopyDisabled, Office2010ToolbarImageResources.Office2010ToolbarCopyNormal, Office2010ToolbarImageResources.Office2010ToolbarCopyNormal);
                    break;
                case PaletteImageSetFamily.Office2013:
                    AddImageStates(Office2019ToolbarImageResources.Office2019ToolbarCopyNormal, Office2019ToolbarImageResources.Office2019ToolbarCopyDisabled, Office2019ToolbarImageResources.Office2019ToolbarCopyNormal, Office2019ToolbarImageResources.Office2019ToolbarCopyNormal);
                    break;
                case PaletteImageSetFamily.Microsoft365:
                    AddImageStates(Office2019ToolbarImageResources.Office2019ToolbarCopyNormal, Office2019ToolbarImageResources.Office2019ToolbarCopyDisabled, Office2019ToolbarImageResources.Office2019ToolbarCopyNormal, Office2019ToolbarImageResources.Office2019ToolbarCopyNormal);
                    break;
                case PaletteImageSetFamily.Sparkle:
                    AddImageStates(Office2010ToolbarImageResources.Office2010ToolbarCopyNormal, Office2010ToolbarImageResources.Office2010ToolbarCopyDisabled, Office2010ToolbarImageResources.Office2010ToolbarCopyNormal, Office2010ToolbarImageResources.Office2010ToolbarCopyNormal);
                    break;
                case PaletteImageSetFamily.Custom:
                    AddImageStates(Office2019ToolbarImageResources.Office2019ToolbarCopyNormal, Office2019ToolbarImageResources.Office2019ToolbarCopyDisabled, Office2019ToolbarImageResources.Office2019ToolbarCopyNormal, Office2019ToolbarImageResources.Office2019ToolbarCopyNormal);
                    break;
            }
        }
    }

    #endregion
}
