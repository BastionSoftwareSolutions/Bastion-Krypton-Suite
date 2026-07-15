#region BSD License
/*
 * 
 *  New BSD 3-Clause License (https://github.com/Krypton-Suite/Standard-Toolkit/blob/master/LICENSE)
 *  Modifications by Peter Wagner (aka Wagnerp), Simon Coghlan (aka Smurf-IV), Giduac & Ahmed Abdelhameed et al. 2017 - 2025. All rights reserved.
 *  
 */
#endregion

namespace Krypton.Toolkit;

/// <summary>A <see cref="KryptonCommand"/> created specifically for the <see cref="PaletteButtonSpecStyle.FormHelp"/> button spec.</summary>
[ToolboxItem(true)]
[ToolboxBitmap(typeof(KryptonHelpCommand), @"ToolboxBitmaps.KryptonHelp.bmp")]
[Description(@"For use with the 'Help' ButtonSpec style.")]
[DesignerCategory(@"code")]
public class KryptonHelpCommand : KryptonCommand
{
    #region Instance Fields

    private ButtonSpecAny? _helpButtonSpec;

    private ButtonImageStates? _imageStates;

    private Image? _activeImage;

    private Image? _disabledImage;

    private Image? _normalImage;

    private Image? _pressedImage;

    #endregion

    #region Public

    /// <summary>Gets or sets the help button.</summary>
    /// <value>The help button.</value>
    [DefaultValue(null), Description(@"Access to the help button spec.")]
    public ButtonSpecAny? HelpButton
    {
        get => _helpButtonSpec ?? new ButtonSpecAny();
        set { _helpButtonSpec = value; UpdateImage(KryptonManager.CurrentGlobalPaletteMode); }
    }

    /* /// <summary>
     /// Gets access to the state specific images for the help button.
     /// </summary>
     [AllowNull, Category(@"Appearance"), Description(@"State specific images for the help button."), DesignerSerializationVisibility(DesignerSerializationVisibility.Hidden)]
     public ButtonImageStates? ImageStates { get => _imageStates ?? new(); set { _imageStates = value; UpdateImageStates(KryptonManager.InternalGlobalPaletteMode); } }*/

    [DesignerSerializationVisibility(DesignerSerializationVisibility.Visible)]
    public Image? ActiveImage 
    { 
        get => _activeImage; 
        private set => _activeImage = value; 
    }

    [DesignerSerializationVisibility(DesignerSerializationVisibility.Visible)]
    public Image? DisabledImage 
    { 
        get => _disabledImage; 
        private set => _disabledImage = value; 
    }

    [DesignerSerializationVisibility(DesignerSerializationVisibility.Visible)]
    public Image? NormalImage 
    { 
        get => _normalImage; 
        private set => _normalImage = value; 
    }

    [DesignerSerializationVisibility(DesignerSerializationVisibility.Visible)]
    public Image? PressedImage 
    { 
        get => _pressedImage; 
        private set => _pressedImage = value; 
    }

    #endregion

    #region Identity

    /// <summary>Initializes a new instance of the <see cref="KryptonHelpCommand" /> class.</summary>
    public KryptonHelpCommand()
    {
        _imageStates = new ButtonImageStates();

        Text = KryptonManager.Strings.ButtonSpecStyleStrings.FormHelp;
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
        if (_helpButtonSpec != null)
        {
            _helpButtonSpec.ImageStates.ImageDisabled = disabledImage;

            _helpButtonSpec.ImageStates.ImageTracking = activeImage;

            _helpButtonSpec.ImageStates.ImageNormal = normalImage;

            _helpButtonSpec.ImageStates.ImagePressed = pressedImage;
        }
    }

    /// <summary>Updates the active image.</summary>
    /// <param name="activeImage">The active image.</param>
    private void UpdateActiveImage(Image activeImage)
    {
        _activeImage = activeImage;

        if (_helpButtonSpec != null)
        {
            _helpButtonSpec.ImageStates.ImageTracking = _activeImage;
        }
    }

    /// <summary>Updates the disabled image.</summary>
    /// <param name="disabledImage">The disabled image.</param>
    private void UpdateDisabledImage(Image? disabledImage)
    {
        _disabledImage = disabledImage;

        if (_helpButtonSpec != null)
        {
            _helpButtonSpec.ImageStates.ImageDisabled = disabledImage;
        }
    }

    /// <summary>Updates the normal image.</summary>
    /// <param name="normalImage">The normal image.</param>
    private void UpdateNormalImage(Image? normalImage)
    {
        _normalImage = normalImage;

        if (_helpButtonSpec != null)
        {
            _helpButtonSpec.ImageStates.ImageNormal = normalImage;
        }
    }

    /// <summary>Updates the pressed image.</summary>
    /// <param name="pressedImage">The pressed image.</param>
    private void UpdatePressedImage(Image? pressedImage)
    {
        _pressedImage = pressedImage;

        if (_helpButtonSpec != null)
        {
            _helpButtonSpec.ImageStates.ImagePressed = pressedImage;
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
                UpdateImage(ProfessionalControlBoxResources.ProfessionalHelpIconNormal);
                break;
            case PaletteImageSetFamily.Office2003:
                UpdateImage(Office2003ControlBoxResources.Office2003HelpIconNormal);
                break;
            case PaletteImageSetFamily.Office2007:
                UpdateImage(Office2007ControlBoxResources.Office2007HelpIconNormal);
                break;
            case PaletteImageSetFamily.Office2010:
                UpdateImage(Office2010ControlBoxResources.Office2010HelpIconNormal);
                break;
            case PaletteImageSetFamily.Office2013:
                UpdateImage(Office2013ControlBoxResources.Office2013HelpNormal);
                break;
            case PaletteImageSetFamily.Microsoft365:
                UpdateImage(Microsoft365ControlBoxResources.Microsoft365HelpIconNormal);
                break;
            case PaletteImageSetFamily.Sparkle:
                UpdateImage(Office2010ControlBoxResources.Office2010HelpIconNormal);
                break;
            case PaletteImageSetFamily.Custom:
                UpdateImage(Office2010ControlBoxResources.Office2010HelpIconNormal);
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
                UpdateActiveImage(ProfessionalControlBoxResources.ProfessionalHelpIconNormal);
                break;
            case PaletteImageSetFamily.Office2003:
                UpdateActiveImage(ProfessionalControlBoxResources.ProfessionalHelpIconNormal);
                break;
            case PaletteImageSetFamily.Office2007:
                UpdateActiveImage(Office2007ControlBoxResources.Office2007HelpIconHover);
                break;
            case PaletteImageSetFamily.Office2010:
                UpdateActiveImage(Office2010ControlBoxResources.Office2010HelpIconHover);
                break;
            case PaletteImageSetFamily.Office2013:
                UpdateActiveImage(Office2013ControlBoxResources.Office2013HelpActive);
                break;
            case PaletteImageSetFamily.Microsoft365:
                UpdateActiveImage(Microsoft365ControlBoxResources.Microsoft365HelpIconHover);
                break;
            case PaletteImageSetFamily.Sparkle:
                UpdateActiveImage(Office2010ControlBoxResources.Office2010HelpIconHover);
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
                break;
            case PaletteImageSetFamily.Office2003:
                break;
            case PaletteImageSetFamily.Office2007:
                break;
            case PaletteImageSetFamily.Office2010:
                break;
            case PaletteImageSetFamily.Office2013:
                break;
            case PaletteImageSetFamily.Microsoft365:
                break;
            case PaletteImageSetFamily.Sparkle:
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
                break;
            case PaletteImageSetFamily.Office2003:
                break;
            case PaletteImageSetFamily.Office2007:
                break;
            case PaletteImageSetFamily.Office2010:
                break;
            case PaletteImageSetFamily.Office2013:
                break;
            case PaletteImageSetFamily.Microsoft365:
                break;
            case PaletteImageSetFamily.Sparkle:
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
                break;
            case PaletteImageSetFamily.Office2003:
                break;
            case PaletteImageSetFamily.Office2007:
                break;
            case PaletteImageSetFamily.Office2010:
                break;
            case PaletteImageSetFamily.Office2013:
                break;
            case PaletteImageSetFamily.Microsoft365:
                break;
            case PaletteImageSetFamily.Sparkle:
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
        if (_helpButtonSpec is not null)
        {
            // A palette mode no longer selects images directly; the shared
            // PaletteImageSetResolver maps every PaletteMode (including future ones)
            // to its image-set family (BREAKAGE-LOG T1 consolidation).
            switch (PaletteImageSetResolver.GetImageSetFamily(mode))
            {
                case PaletteImageSetFamily.Inherit:
                    break;
                case PaletteImageSetFamily.Professional:
                    AddImageStates(null, ProfessionalControlBoxResources.ProfessionalHelpIconDisabled, ProfessionalControlBoxResources.ProfessionalHelpIconNormal, null);
                    break;
                case PaletteImageSetFamily.Office2003:
                    AddImageStates(null, ProfessionalControlBoxResources.ProfessionalHelpIconDisabled, ProfessionalControlBoxResources.ProfessionalHelpIconNormal, null);
                    break;
                case PaletteImageSetFamily.Office2007:
                    AddImageStates(Office2007ControlBoxResources.Office2007HelpIconHover, Office2007ControlBoxResources.Office2007HelpIconDisabled, Office2007ControlBoxResources.Office2007HelpIconNormal, Office2007ControlBoxResources.Office2007HelpIconPressed);
                    break;
                case PaletteImageSetFamily.Office2010:
                    AddImageStates(Office2010ControlBoxResources.Office2010HelpIconHover, Office2010ControlBoxResources.Office2010HelpIconDisabled, Office2010ControlBoxResources.Office2010HelpIconNormal, Office2010ControlBoxResources.Office2010HelpIconPressed);
                    break;
                case PaletteImageSetFamily.Office2013:
                    AddImageStates(Microsoft365ControlBoxResources.Microsoft365HelpIconHover, Microsoft365ControlBoxResources.Microsoft365HelpIconDisabled, Microsoft365ControlBoxResources.Microsoft365HelpIconNormal, Microsoft365ControlBoxResources.Microsoft365HelpIconPressed);
                    break;
                case PaletteImageSetFamily.Microsoft365:
                    AddImageStates(Microsoft365ControlBoxResources.Microsoft365HelpIconHover, Microsoft365ControlBoxResources.Microsoft365HelpIconDisabled, Microsoft365ControlBoxResources.Microsoft365HelpIconNormal, Microsoft365ControlBoxResources.Microsoft365HelpIconPressed);
                    break;
                case PaletteImageSetFamily.Sparkle:
                    AddImageStates(Office2010ControlBoxResources.Office2010HelpIconHover, Office2010ControlBoxResources.Office2010HelpIconDisabled, Office2010ControlBoxResources.Office2010HelpIconNormal, Office2010ControlBoxResources.Office2010HelpIconPressed);
                    break;
                case PaletteImageSetFamily.Custom:
                    AddImageStates(Microsoft365ControlBoxResources.Microsoft365HelpIconHover, Microsoft365ControlBoxResources.Microsoft365HelpIconDisabled, Microsoft365ControlBoxResources.Microsoft365HelpIconNormal, Microsoft365ControlBoxResources.Microsoft365HelpIconPressed);
                    break;
            }
        }
    }

    #endregion

    #region Overrides

    protected override void OnPropertyChanged(PropertyChangedEventArgs e) => base.OnPropertyChanged(e);

    #endregion
}
