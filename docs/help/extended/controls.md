# Controls

> Part of the Bastion Krypton Suite — Extended Toolkit. NuGet package: `Bastion.Krypton.Extended.Controls` (bundled in `Bastion.Krypton.Extended.Ultimate`).

**Assembly:** `Bastion.Krypton.Suite.Extended.Controls` · **Namespace:** `Krypton.Toolkit.Suite.Extended.Controls` (unchanged from upstream)

## Purpose

A broad collection of extended Krypton controls (24 in total) covering combo boxes, knobs, labels, text boxes, progress bars, radial menus, star ratings and validation.

## Key types (representative)

- `KryptonPopUpComboBox`, `KryptonCheckBoxComboBox` — extended combo boxes
- `KryptonKnobControlVersion1` / `KryptonKnobControlVersion2 : UserControl` — knob controls
- `KryptonMarqueeLabel`, `KryptonPasswordTextBox`, `KryptonRichTextBoxExtended` — labels and text boxes
- `KryptonProgressBarExtended : ProgressBar` — extended progress bar
- `KryptonRadialMenu : UserControl`, `KryptonStarRatingControl : Panel`, `KryptonValidationBox`
- `PopUp : ToolStripDropDown` — pop-up host

## Dependencies

Core Krypton: dual — PackageReference to `Krypton.Toolkit` (100.25.11.328) in the NuGet solution, ProjectReference to the sibling Standard-Toolkit checkout otherwise. Module references: Debug.Tools, Developer.Utilities, Drawing.

## See also

- [Extended Toolkit overview](index.md)
- [Migration from upstream](../migration-from-upstream.md)
