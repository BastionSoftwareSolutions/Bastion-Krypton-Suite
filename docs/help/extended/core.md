# Core

> Part of the Bastion Krypton Suite — Extended Toolkit. NuGet package: `Bastion.Krypton.Extended.Core` (bundled in `Bastion.Krypton.Extended.Ultimate`).

**Assembly:** `Bastion.Krypton.Suite.Extended.Core` · **Namespace:** `Krypton.Toolkit.Suite.Extended.Core` (unchanged from upstream)

## Purpose

Core infrastructure for the Extended Toolkit, including colour-editing and palette tooling used by other modules (28 controls in total).

## Key types (representative)

- `VisualControlBaseExtended : Control` — extended visual control base
- `ColourEditorManager : Component` — colour-editing manager
- `ColourGridControl` / `ColourSliderControl` / `ColourWheelControl` / `ScreenColourPickerControl : Control` — colour picker controls
- Palette and colour dialogs (`KryptonForm`-based): `PaletteColourCreator`, `PaletteFileEditor`, `ColourMixer`, `SystemInformationWindow`, `KryptonFadeForm`

## Dependencies

Core Krypton: NuGet-only — consumed exclusively as NuGet PackageReferences to `Krypton.Toolkit`, `Krypton.Navigator`, `Krypton.Ribbon` and `Krypton.Docking` (100.25.11.328) in every configuration. Module references: Controls, Global.Utilities, Settings, Shared. Third-party packages: `Newtonsoft.Json` 13.0.4, `Portable.BouncyCastle` 1.9.0, `WindowsAPICodePack` 8.0.12.

## See also

- [Extended Toolkit overview](index.md)
- [Migration from upstream](../migration-from-upstream.md)
