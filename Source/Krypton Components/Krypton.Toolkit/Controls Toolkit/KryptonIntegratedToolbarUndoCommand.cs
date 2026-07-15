#region BSD License
/*
 * 
 *  Undo BSD 3-Clause License (https://github.com/Krypton-Suite/Standard-Toolkit/blob/master/LICENSE)
 *  Modifications by Peter Wagner(aka Wagnerp) & Simon Coghlan(aka Smurf-IV), et al. 2023 - 2025. All rights reserved. 
 *  
 */
#endregion

namespace Krypton.Toolkit;

/// <summary>A <see cref="KryptonCommand"/> created specifically for the <see cref="PaletteButtonSpecStyle.Undo"/> button spec.</summary>
[Category(@"code")]
[ToolboxItem(false)]
//[ToolboxBitmap(typeof(KryptonHelpCommand), @"ToolboxBitmaps.KryptonHelp.bmp")]
[Description(@"For use with the 'Undo' ButtonSpec style.")]
[DesignerCategory(@"code")]
public class KryptonIntegratedToolbarUndoCommand : KryptonCommand
{
    #region Instance Fields

    private ButtonSpecAny? _undoButtonSpec;

    private ButtonImageStates? _imageStates;

    private Image? _activeImage;

    private Image? _disabledImage;

    private Image? _normalImage;

    private Image? _pressedImage;

    #endregion

    #region Public

    /// <summary>Gets or sets the undo button.</summary>
    /// <value>The undo button.</value>
    [DefaultValue(null), Description(@"Access to the undo button spec.")]
    [AllowNull]
    public ButtonSpecAny? ToolBarUndoButton
    {
        get => _undoButtonSpec ?? new ButtonSpecAny();
        set { _undoButtonSpec = value; UpdateImage(KryptonManager.CurrentGlobalPaletteMode); }
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

    /// <summary>Initializes a new instance of the <see cref="KryptonIntegratedToolbarUndoCommand" /> class.</summary>
    public KryptonIntegratedToolbarUndoCommand()
    {
        _imageStates = new ButtonImageStates();

        Text = KryptonManager.Strings.ToolBarStrings.Undo;
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
        if (_undoButtonSpec != null)
        {
            _undoButtonSpec.ImageStates.ImageDisabled = disabledImage;

            _undoButtonSpec.ImageStates.ImageTracking = activeImage;

            _undoButtonSpec.ImageStates.ImageNormal = normalImage;

            _undoButtonSpec.ImageStates.ImagePressed = pressedImage;
        }
    }

    /// <summary>Updates the active image.</summary>
    /// <param name="activeImage">The active image.</param>
    private void UpdateActiveImage(Image activeImage)
    {
        _activeImage = activeImage;

        if (_undoButtonSpec != null)
        {
            _undoButtonSpec.ImageStates.ImageTracking = _activeImage;
        }
    }

    /// <summary>Updates the disabled image.</summary>
    /// <param name="disabledImage">The disabled image.</param>
    private void UpdateDisabledImage(Image? disabledImage)
    {
        _disabledImage = disabledImage;

        if (_undoButtonSpec != null)
        {
            _undoButtonSpec.ImageStates.ImageDisabled = disabledImage;
        }
    }

    /// <summary>Updates the normal image.</summary>
    /// <param name="normalImage">The normal image.</param>
    private void UpdateNormalImage(Image? normalImage)
    {
        _normalImage = normalImage;

        if (_undoButtonSpec != null)
        {
            _undoButtonSpec.ImageStates.ImageNormal = normalImage;
        }
    }

    /// <summary>Updates the pressed image.</summary>
    /// <param name="pressedImage">The pressed image.</param>
    private void UpdatePressedImage(Image? pressedImage)
    {
        _pressedImage = pressedImage;

        if (_undoButtonSpec != null)
        {
            _undoButtonSpec.ImageStates.ImagePressed = pressedImage;
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
                UpdateImage(SystemToolbarImageResources.SystemToolbarUndoNormal);
                break;
            case PaletteImageSetFamily.Office2003:
                UpdateImage(Office2003ToolbarImageResources.Office2003ToolbarUndoNormal);
                break;
            case PaletteImageSetFamily.Office2007:
                UpdateImage(Office2007ToolbarImageResources.Office2007ToolbarUndoNormal);
                break;
            case PaletteImageSetFamily.Office2010:
                UpdateImage(Office2010ToolbarImageResources.Office2010ToolbarUndoNormal);
                break;
            case PaletteImageSetFamily.Office2013:
                UpdateImage(Office2013ToolbarImageResources.Office2013ToolbarUndoNormal);
                break;
            case PaletteImageSetFamily.Microsoft365:
                UpdateImage(Office2019ToolbarImageResources.Office2019ToolbarUndoNormal);
                break;
            case PaletteImageSetFamily.Sparkle:
                UpdateImage(Office2010ToolbarImageResources.Office2010ToolbarUndoNormal);
                break;
            case PaletteImageSetFamily.Custom:
                UpdateImage(Office2010ToolbarImageResources.Office2010ToolbarUndoNormal);
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
                UpdateImage(SystemToolbarImageResources.SystemToolbarUndoNormal);
                break;
            case PaletteImageSetFamily.Office2003:
                UpdateImage(Office2003ToolbarImageResources.Office2003ToolbarUndoNormal);
                break;
            case PaletteImageSetFamily.Office2007:
                UpdateImage(Office2007ToolbarImageResources.Office2007ToolbarUndoNormal);
                break;
            case PaletteImageSetFamily.Office2010:
                UpdateImage(Office2010ToolbarImageResources.Office2010ToolbarUndoNormal);
                break;
            case PaletteImageSetFamily.Office2013:
                UpdateImage(Office2013ToolbarImageResources.Office2013ToolbarUndoNormal);
                break;
            case PaletteImageSetFamily.Microsoft365:
                UpdateImage(Office2019ToolbarImageResources.Office2019ToolbarUndoNormal);
                break;
            case PaletteImageSetFamily.Sparkle:
                UpdateImage(Office2010ToolbarImageResources.Office2010ToolbarUndoNormal);
                break;
            case PaletteImageSetFamily.Custom:
                UpdateImage(Office2010ToolbarImageResources.Office2010ToolbarUndoNormal);
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
                UpdateImage(SystemToolbarImageResources.SystemToolbarUndoDisabled);
                break;
            case PaletteImageSetFamily.Office2003:
                UpdateImage(Office2003ToolbarImageResources.Office2003ToolbarUndoDisabled);
                break;
            case PaletteImageSetFamily.Office2007:
                UpdateImage(Office2007ToolbarImageResources.Office2007ToolbarUndoDisabled);
                break;
            case PaletteImageSetFamily.Office2010:
                UpdateImage(Office2010ToolbarImageResources.Office2010ToolbarUndoDisabled);
                break;
            case PaletteImageSetFamily.Office2013:
                UpdateImage(Office2013ToolbarImageResources.Office2013ToolbarUndoDisabled);
                break;
            case PaletteImageSetFamily.Microsoft365:
                UpdateImage(Office2019ToolbarImageResources.Office2019ToolbarUndoDisabled);
                break;
            case PaletteImageSetFamily.Sparkle:
                UpdateImage(Office2010ToolbarImageResources.Office2010ToolbarUndoDisabled);
                break;
            case PaletteImageSetFamily.Custom:
                UpdateImage(Office2010ToolbarImageResources.Office2010ToolbarUndoDisabled);
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
                UpdateImage(SystemToolbarImageResources.SystemToolbarUndoNormal);
                break;
            case PaletteImageSetFamily.Office2003:
                UpdateImage(Office2003ToolbarImageResources.Office2003ToolbarUndoNormal);
                break;
            case PaletteImageSetFamily.Office2007:
                UpdateImage(Office2007ToolbarImageResources.Office2007ToolbarUndoNormal);
                break;
            case PaletteImageSetFamily.Office2010:
                UpdateImage(Office2010ToolbarImageResources.Office2010ToolbarUndoNormal);
                break;
            case PaletteImageSetFamily.Office2013:
                UpdateImage(Office2013ToolbarImageResources.Office2013ToolbarUndoNormal);
                break;
            case PaletteImageSetFamily.Microsoft365:
                UpdateImage(Office2019ToolbarImageResources.Office2019ToolbarUndoNormal);
                break;
            case PaletteImageSetFamily.Sparkle:
                UpdateImage(Office2010ToolbarImageResources.Office2010ToolbarUndoNormal);
                break;
            case PaletteImageSetFamily.Custom:
                UpdateImage(Office2010ToolbarImageResources.Office2010ToolbarUndoNormal);
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
                UpdateImage(SystemToolbarImageResources.SystemToolbarUndoNormal);
                break;
            case PaletteImageSetFamily.Office2003:
                UpdateImage(Office2003ToolbarImageResources.Office2003ToolbarUndoNormal);
                break;
            case PaletteImageSetFamily.Office2007:
                UpdateImage(Office2007ToolbarImageResources.Office2007ToolbarUndoNormal);
                break;
            case PaletteImageSetFamily.Office2010:
                UpdateImage(Office2010ToolbarImageResources.Office2010ToolbarUndoNormal);
                break;
            case PaletteImageSetFamily.Office2013:
                UpdateImage(Office2013ToolbarImageResources.Office2013ToolbarUndoNormal);
                break;
            case PaletteImageSetFamily.Microsoft365:
                UpdateImage(Office2019ToolbarImageResources.Office2019ToolbarUndoNormal);
                break;
            case PaletteImageSetFamily.Sparkle:
                UpdateImage(Office2010ToolbarImageResources.Office2010ToolbarUndoNormal);
                break;
            case PaletteImageSetFamily.Custom:
                UpdateImage(Office2010ToolbarImageResources.Office2010ToolbarUndoNormal);
                break;
        }
    }

    /// <summary>Updates the image states.</summary>
    /// <param name="mode">The mode.</param>
    /// <exception cref="System.ArgumentOutOfRangeException">mode - null</exception>
    private void UpdateImageStates(PaletteMode mode)
    {
        if (_undoButtonSpec != null)
        {
            // A palette mode no longer selects images directly; the shared
            // PaletteImageSetResolver maps every PaletteMode (including future ones)
            // to its image-set family (BREAKAGE-LOG T1 consolidation).
            switch (PaletteImageSetResolver.GetImageSetFamily(mode))
            {
                case PaletteImageSetFamily.Inherit:
                    break;
                case PaletteImageSetFamily.Professional:
                    AddImageStates(null, SystemToolbarImageResources.SystemToolbarUndoDisabled, SystemToolbarImageResources.SystemToolbarUndoNormal, null);
                    break;
                case PaletteImageSetFamily.Office2003:
                    AddImageStates(null, Office2003ToolbarImageResources.Office2003ToolbarUndoDisabled, Office2003ToolbarImageResources.Office2003ToolbarUndoNormal, null);
                    break;
                case PaletteImageSetFamily.Office2007:
                    AddImageStates(Office2007ToolbarImageResources.Office2007ToolbarUndoNormal, Office2007ToolbarImageResources.Office2007ToolbarUndoDisabled, Office2007ToolbarImageResources.Office2007ToolbarUndoNormal, Office2007ToolbarImageResources.Office2007ToolbarUndoNormal);
                    break;
                case PaletteImageSetFamily.Office2010:
                    AddImageStates(Office2010ToolbarImageResources.Office2010ToolbarUndoNormal, Office2010ToolbarImageResources.Office2010ToolbarUndoDisabled, Office2010ToolbarImageResources.Office2010ToolbarUndoNormal, Office2010ToolbarImageResources.Office2010ToolbarUndoNormal);
                    break;
                case PaletteImageSetFamily.Office2013:
                    AddImageStates(Office2019ToolbarImageResources.Office2019ToolbarUndoNormal, Office2019ToolbarImageResources.Office2019ToolbarUndoDisabled, Office2019ToolbarImageResources.Office2019ToolbarUndoNormal, Office2019ToolbarImageResources.Office2019ToolbarUndoNormal);
                    break;
                case PaletteImageSetFamily.Microsoft365:
                    AddImageStates(Office2019ToolbarImageResources.Office2019ToolbarUndoNormal, Office2019ToolbarImageResources.Office2019ToolbarUndoDisabled, Office2019ToolbarImageResources.Office2019ToolbarUndoNormal, Office2019ToolbarImageResources.Office2019ToolbarUndoNormal);
                    break;
                case PaletteImageSetFamily.Sparkle:
                    AddImageStates(Office2010ToolbarImageResources.Office2010ToolbarUndoNormal, Office2010ToolbarImageResources.Office2010ToolbarUndoDisabled, Office2010ToolbarImageResources.Office2010ToolbarUndoNormal, Office2010ToolbarImageResources.Office2010ToolbarUndoNormal);
                    break;
                case PaletteImageSetFamily.Custom:
                    AddImageStates(Office2019ToolbarImageResources.Office2019ToolbarUndoNormal, Office2019ToolbarImageResources.Office2019ToolbarUndoDisabled, Office2019ToolbarImageResources.Office2019ToolbarUndoNormal, Office2019ToolbarImageResources.Office2019ToolbarUndoNormal);
                    break;
            }
        }
    }

    #endregion
}
