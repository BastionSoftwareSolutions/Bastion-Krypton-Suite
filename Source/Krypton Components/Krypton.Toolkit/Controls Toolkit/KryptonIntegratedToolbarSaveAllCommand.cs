#region BSD License
/*
 * 
 *  SaveAll BSD 3-Clause License (https://github.com/Krypton-Suite/Standard-Toolkit/blob/master/LICENSE)
 *  Modifications by Peter Wagner(aka Wagnerp) & Simon Coghlan(aka Smurf-IV), et al. 2023 - 2025. All rights reserved. 
 *  
 */
#endregion

namespace Krypton.Toolkit;

/// <summary>A <see cref="KryptonCommand"/> created specifically for the <see cref="PaletteButtonSpecStyle.SaveAll"/> button spec.</summary>
[Category(@"code")]
[ToolboxItem(false)]
//[ToolboxBitmap(typeof(KryptonHelpCommand), @"ToolboxBitmaps.KryptonHelp.bmp")]
[Description(@"For use with the 'SaveAll' ButtonSpec style.")]
[DesignerCategory(@"code")]
public class KryptonIntegratedToolbarSaveAllCommand : KryptonCommand
{
    #region Instance Fields

    private ButtonSpecAny? _saveAllButtonSpec;

    private ButtonImageStates? _imageStates;

    private Image? _activeImage;

    private Image? _disabledImage;

    private Image? _normalImage;

    private Image? _pressedImage;

    private PaletteButtonSpecStyle _style;

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

    /// <summary>Gets or sets the save all button.</summary>
    /// <value>The save all button.</value>
    [DefaultValue(null), Description(@"Access to the save all button spec.")]
    [AllowNull]
    public ButtonSpecAny? ToolBarSaveAllButton
    {
        get => _saveAllButtonSpec ?? new ButtonSpecAny();
        set { _saveAllButtonSpec = value; UpdateImage(KryptonManager.CurrentGlobalPaletteMode); }
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

    /// <summary>Initializes a new instance of the <see cref="KryptonIntegratedToolbarSaveAllCommand" /> class.</summary>
    public KryptonIntegratedToolbarSaveAllCommand()
    {
        _imageStates = new ButtonImageStates();

        _style = PaletteButtonSpecStyle.SaveAll;

        Text = KryptonManager.Strings.ToolBarStrings.SaveAll;

        UpdateButtonSpec();
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
        if (_saveAllButtonSpec != null)
        {
            _saveAllButtonSpec.ImageStates.ImageDisabled = disabledImage;

            _saveAllButtonSpec.ImageStates.ImageTracking = activeImage;

            _saveAllButtonSpec.ImageStates.ImageNormal = normalImage;

            _saveAllButtonSpec.ImageStates.ImagePressed = pressedImage;
        }
    }

    /// <summary>Updates the active image.</summary>
    /// <param name="activeImage">The active image.</param>
    private void UpdateActiveImage(Image activeImage)
    {
        _activeImage = activeImage;

        if (_saveAllButtonSpec != null)
        {
            _saveAllButtonSpec.ImageStates.ImageTracking = _activeImage;
        }
    }

    /// <summary>Updates the disabled image.</summary>
    /// <param name="disabledImage">The disabled image.</param>
    private void UpdateDisabledImage(Image? disabledImage)
    {
        _disabledImage = disabledImage;

        if (_saveAllButtonSpec != null)
        {
            _saveAllButtonSpec.ImageStates.ImageDisabled = disabledImage;
        }
    }

    /// <summary>Updates the normal image.</summary>
    /// <param name="normalImage">The normal image.</param>
    private void UpdateNormalImage(Image? normalImage)
    {
        _normalImage = normalImage;

        if (_saveAllButtonSpec != null)
        {
            _saveAllButtonSpec.ImageStates.ImageNormal = normalImage;
        }
    }

    /// <summary>Updates the pressed image.</summary>
    /// <param name="pressedImage">The pressed image.</param>
    private void UpdatePressedImage(Image? pressedImage)
    {
        _pressedImage = pressedImage;

        if (_saveAllButtonSpec != null)
        {
            _saveAllButtonSpec.ImageStates.ImagePressed = pressedImage;
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
                UpdateImage(SystemToolbarImageResources.SystemToolbarSaveAllNormal);
                break;
            case PaletteImageSetFamily.Office2003:
                UpdateImage(Office2003ToolbarImageResources.Office2003ToolbarSaveAllNormal);
                break;
            case PaletteImageSetFamily.Office2007:
                UpdateImage(Office2007ToolbarImageResources.Office2007ToolbarSaveAllNormal);
                break;
            case PaletteImageSetFamily.Office2010:
                UpdateImage(Office2010ToolbarImageResources.Office2010ToolbarSaveAllNormal);
                break;
            case PaletteImageSetFamily.Office2013:
                UpdateImage(Office2013ToolbarImageResources.Office2013ToolbarSaveAllNormal);
                break;
            case PaletteImageSetFamily.Microsoft365:
                UpdateImage(Office2019ToolbarImageResources.Office2019ToolbarSaveAllNormal);
                break;
            case PaletteImageSetFamily.Sparkle:
                UpdateImage(Office2010ToolbarImageResources.Office2010ToolbarSaveAllNormal);
                break;
            case PaletteImageSetFamily.Custom:
                UpdateImage(Office2010ToolbarImageResources.Office2010ToolbarSaveAllNormal);
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
                UpdateImage(SystemToolbarImageResources.SystemToolbarSaveAllNormal);
                break;
            case PaletteImageSetFamily.Office2003:
                UpdateImage(Office2003ToolbarImageResources.Office2003ToolbarSaveAllNormal);
                break;
            case PaletteImageSetFamily.Office2007:
                UpdateImage(Office2007ToolbarImageResources.Office2007ToolbarSaveAllNormal);
                break;
            case PaletteImageSetFamily.Office2010:
                UpdateImage(Office2010ToolbarImageResources.Office2010ToolbarSaveAllNormal);
                break;
            case PaletteImageSetFamily.Office2013:
                UpdateImage(Office2013ToolbarImageResources.Office2013ToolbarSaveAllNormal);
                break;
            case PaletteImageSetFamily.Microsoft365:
                UpdateImage(Office2019ToolbarImageResources.Office2019ToolbarSaveAllNormal);
                break;
            case PaletteImageSetFamily.Sparkle:
                UpdateImage(Office2010ToolbarImageResources.Office2010ToolbarSaveAllNormal);
                break;
            case PaletteImageSetFamily.Custom:
                UpdateImage(Office2010ToolbarImageResources.Office2010ToolbarSaveAllNormal);
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
                UpdateImage(SystemToolbarImageResources.SystemToolbarSaveAllDisabled);
                break;
            case PaletteImageSetFamily.Office2003:
                UpdateImage(Office2003ToolbarImageResources.Office2003ToolbarSaveAllDisabled);
                break;
            case PaletteImageSetFamily.Office2007:
                UpdateImage(Office2007ToolbarImageResources.Office2007ToolbarSaveAllDisabled);
                break;
            case PaletteImageSetFamily.Office2010:
                UpdateImage(Office2010ToolbarImageResources.Office2010ToolbarSaveAllDisabled);
                break;
            case PaletteImageSetFamily.Office2013:
                UpdateImage(Office2013ToolbarImageResources.Office2013ToolbarSaveAllDisabled);
                break;
            case PaletteImageSetFamily.Microsoft365:
                UpdateImage(Office2019ToolbarImageResources.Office2019ToolbarSaveAllDisabled);
                break;
            case PaletteImageSetFamily.Sparkle:
                UpdateImage(Office2010ToolbarImageResources.Office2010ToolbarSaveAllDisabled);
                break;
            case PaletteImageSetFamily.Custom:
                UpdateImage(Office2010ToolbarImageResources.Office2010ToolbarSaveAllDisabled);
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
                UpdateImage(SystemToolbarImageResources.SystemToolbarSaveAllNormal);
                break;
            case PaletteImageSetFamily.Office2003:
                UpdateImage(Office2003ToolbarImageResources.Office2003ToolbarSaveAllNormal);
                break;
            case PaletteImageSetFamily.Office2007:
                UpdateImage(Office2007ToolbarImageResources.Office2007ToolbarSaveAllNormal);
                break;
            case PaletteImageSetFamily.Office2010:
                UpdateImage(Office2010ToolbarImageResources.Office2010ToolbarSaveAllNormal);
                break;
            case PaletteImageSetFamily.Office2013:
                UpdateImage(Office2013ToolbarImageResources.Office2013ToolbarSaveAllNormal);
                break;
            case PaletteImageSetFamily.Microsoft365:
                UpdateImage(Office2019ToolbarImageResources.Office2019ToolbarSaveAllNormal);
                break;
            case PaletteImageSetFamily.Sparkle:
                UpdateImage(Office2010ToolbarImageResources.Office2010ToolbarSaveAllNormal);
                break;
            case PaletteImageSetFamily.Custom:
                UpdateImage(Office2010ToolbarImageResources.Office2010ToolbarSaveAllNormal);
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
                UpdateImage(SystemToolbarImageResources.SystemToolbarSaveAllNormal);
                break;
            case PaletteImageSetFamily.Office2003:
                UpdateImage(Office2003ToolbarImageResources.Office2003ToolbarSaveAllNormal);
                break;
            case PaletteImageSetFamily.Office2007:
                UpdateImage(Office2007ToolbarImageResources.Office2007ToolbarSaveAllNormal);
                break;
            case PaletteImageSetFamily.Office2010:
                UpdateImage(Office2010ToolbarImageResources.Office2010ToolbarSaveAllNormal);
                break;
            case PaletteImageSetFamily.Office2013:
                UpdateImage(Office2013ToolbarImageResources.Office2013ToolbarSaveAllNormal);
                break;
            case PaletteImageSetFamily.Microsoft365:
                UpdateImage(Office2019ToolbarImageResources.Office2019ToolbarSaveAllNormal);
                break;
            case PaletteImageSetFamily.Sparkle:
                UpdateImage(Office2010ToolbarImageResources.Office2010ToolbarSaveAllNormal);
                break;
            case PaletteImageSetFamily.Custom:
                UpdateImage(Office2010ToolbarImageResources.Office2010ToolbarSaveAllNormal);
                break;
        }
    }

    /// <summary>Updates the image states.</summary>
    /// <param name="mode">The mode.</param>
    /// <exception cref="System.ArgumentOutOfRangeException">mode - null</exception>
    private void UpdateImageStates(PaletteMode mode)
    {
        if (_saveAllButtonSpec != null)
        {
            // A palette mode no longer selects images directly; the shared
            // PaletteImageSetResolver maps every PaletteMode (including future ones)
            // to its image-set family (BREAKAGE-LOG T1 consolidation).
            switch (PaletteImageSetResolver.GetImageSetFamily(mode))
            {
                case PaletteImageSetFamily.Inherit:
                    break;
                case PaletteImageSetFamily.Professional:
                    AddImageStates(null, SystemToolbarImageResources.SystemToolbarSaveAllDisabled, SystemToolbarImageResources.SystemToolbarSaveAllNormal, null);
                    break;
                case PaletteImageSetFamily.Office2003:
                    AddImageStates(null, Office2003ToolbarImageResources.Office2003ToolbarSaveAllDisabled, Office2003ToolbarImageResources.Office2003ToolbarSaveAllNormal, null);
                    break;
                case PaletteImageSetFamily.Office2007:
                    AddImageStates(Office2007ToolbarImageResources.Office2007ToolbarSaveAllNormal, Office2007ToolbarImageResources.Office2007ToolbarSaveAllDisabled, Office2007ToolbarImageResources.Office2007ToolbarSaveAllNormal, Office2007ToolbarImageResources.Office2007ToolbarSaveAllNormal);
                    break;
                case PaletteImageSetFamily.Office2010:
                    AddImageStates(Office2010ToolbarImageResources.Office2010ToolbarSaveAllNormal, Office2010ToolbarImageResources.Office2010ToolbarSaveAllDisabled, Office2010ToolbarImageResources.Office2010ToolbarSaveAllNormal, Office2010ToolbarImageResources.Office2010ToolbarSaveAllNormal);
                    break;
                case PaletteImageSetFamily.Office2013:
                    AddImageStates(Office2019ToolbarImageResources.Office2019ToolbarSaveAllNormal, Office2019ToolbarImageResources.Office2019ToolbarSaveAllDisabled, Office2019ToolbarImageResources.Office2019ToolbarSaveAllNormal, Office2019ToolbarImageResources.Office2019ToolbarSaveAllNormal);
                    break;
                case PaletteImageSetFamily.Microsoft365:
                    AddImageStates(Office2019ToolbarImageResources.Office2019ToolbarSaveAllNormal, Office2019ToolbarImageResources.Office2019ToolbarSaveAllDisabled, Office2019ToolbarImageResources.Office2019ToolbarSaveAllNormal, Office2019ToolbarImageResources.Office2019ToolbarSaveAllNormal);
                    break;
                case PaletteImageSetFamily.Sparkle:
                    AddImageStates(Office2010ToolbarImageResources.Office2010ToolbarSaveAllNormal, Office2010ToolbarImageResources.Office2010ToolbarSaveAllDisabled, Office2010ToolbarImageResources.Office2010ToolbarSaveAllNormal, Office2010ToolbarImageResources.Office2010ToolbarSaveAllNormal);
                    break;
                case PaletteImageSetFamily.Custom:
                    AddImageStates(Office2019ToolbarImageResources.Office2019ToolbarSaveAllNormal, Office2019ToolbarImageResources.Office2019ToolbarSaveAllDisabled, Office2019ToolbarImageResources.Office2019ToolbarSaveAllNormal, Office2019ToolbarImageResources.Office2019ToolbarSaveAllNormal);
                    break;
            }
        }
    }

    private void UpdateButtonSpec()
    {
        if (_saveAllButtonSpec != null)
        {
            _saveAllButtonSpec.Type = _style;
        }
    }

    #endregion
}
