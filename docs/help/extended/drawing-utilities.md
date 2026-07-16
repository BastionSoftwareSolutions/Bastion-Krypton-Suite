# Drawing Utilities

> Part of the Bastion Krypton Suite — Extended Toolkit. NuGet package: `Bastion.Krypton.Extended.Drawing.Utilities` (bundled in `Bastion.Krypton.Extended.Ultimate`).

**Assembly:** `Bastion.Krypton.Suite.Extended.Drawing.Utilities` · **Namespace:** `Krypton.Toolkit.Suite.Extended.Drawing.Utilities` (unchanged from upstream)

## Purpose

A rich set of colour-editing and image controls (28 in total), including colour buttons, hexadecimal and RGBA editors, a colour editor and an extended image box.

## Key types (representative)

- `KryptonColourButtonExtended : VisualSimpleBase` — extended colour button
- `ColourHexadecimalComboBox` / `ColourHexadecimalTextBox` — hexadecimal colour editors
- RGBA `KryptonLabel` / `KryptonNumericUpDown` / `KryptonTrackBar` families
- `ColourEditor : UserControl` — colour editor
- `ImageBoxExtended` — extended image box

## Dependencies

Core Krypton: dual — PackageReference to `Krypton.Toolkit` (100.25.11.328) in the NuGet solution, ProjectReference to the sibling Standard-Toolkit checkout otherwise. Module references: Buttons, Common, Controls, Core, Developer.Utilities, Floating.Toolbars, Messagebox, Shared (the most-connected module). Third-party package: `Unofficial.Cyotek.Windows.Forms.NET` 2.0.1 (a repack of the Cyotek colour-picker controls, MIT © Richard Moss).

## Licence notes

The colour-picker controls (`ColourWheelControl`, `ColourGridControl`, `ScreenColourPickerControl`, and others) are adapted from **Cyotek.Windows.Forms.ColorPicker** (MIT, © Richard Moss), acknowledged only via code comments. `ImageBoxExtended.cs` adapts the Cyotek ImageBox and the **CodeProject gGlowBox** control; the gGlowBox fragment is typically CPOL, which is worth verifying before redistribution.

## See also

- [Extended Toolkit overview](index.md)
- [Migration from upstream](../migration-from-upstream.md)
