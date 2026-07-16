# Tool Strip Items

> Part of the Bastion Krypton Suite — Extended Toolkit. NuGet package: `Bastion.Krypton.Extended.Tool.Strip.Items` (bundled in `Bastion.Krypton.Extended.Ultimate`).

**Assembly:** `Bastion.Krypton.Suite.Extended.Tool.Strip.Items` · **Namespace:** `Krypton.Toolkit.Suite.Extended.Tool.Strip.Items` (unchanged from upstream)

## Purpose

A large collection of Krypton-themed tool-strip and status-strip items and hosts (30 in total), including combo boxes, loading circles, MRU menus and hosted controls.

## Key types (representative)

- `KryptonToolStrip` / `KryptonEnhancedToolStrip : ToolStrip` — tool strips
- `KryptonStatusStrip : StatusStrip` — status strip
- `KryptonThemeComboBox : ToolStripComboBox` — theme combo box
- `KryptonLoadingCircle : Control` — loading circle
- Many `ToolStripControlHost` wrappers (DateTimePicker, NumericUpDown, TrackBar, BrowseBox, TextBox, Slider), MRU menu items, `ToolStripProgressBarWithValueText`

## Dependencies

Core Krypton: NuGet-only — consumed exclusively as NuGet PackageReferences to `Krypton.Toolkit` in every configuration. Module references: Debug.Tools, Global.Utilities.

## See also

- [Extended Toolkit overview](index.md)
- [Migration from upstream](../migration-from-upstream.md)
