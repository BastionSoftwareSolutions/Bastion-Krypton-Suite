# Advanced DataGridView

> Part of the Bastion Krypton Suite — Extended Toolkit. NuGet package: `Bastion.Krypton.Extended.AdvancedDataGridView` (bundled in `Bastion.Krypton.Extended.Ultimate`).

**Assembly:** `Bastion.Krypton.Suite.Extended.AdvancedDataGridView` · **Namespace:** `Krypton.Toolkit.Suite.Extended.AdvancedDataGridView` (unchanged from upstream)

## Purpose

Provides a Krypton-themed advanced data grid with built-in column filtering and sorting, derived from the ADGV / `Zuby.AdvancedDataGridView` lineage.

## Key types

- `KryptonAdvancedDataGridView : KryptonDataGridView` — the advanced grid control with filter and sort support
- `KryptonAdvancedDataGridViewSearchToolBar : ToolStrip` — search/filter tool bar companion
- `FormCustomFilter : KryptonForm` — custom filter builder dialog

## Dependencies

Core Krypton: dual — PackageReference to `Krypton.Toolkit` (100.25.11.328) in the NuGet solution, ProjectReference to the sibling Standard-Toolkit checkout otherwise. Module references: Debug.Tools, Developer.Utilities.

## Licence notes

The files under `Controls Toolkit\` are derived from the ADGV / `Zuby.AdvancedDataGridView` project and carry the original **Microsoft Public License (Ms-PL)** header (full Ms-PL text retained). Ms-PL redistribution terms apply.

## See also

- [Extended Toolkit overview](index.md)
- [Migration from upstream](../migration-from-upstream.md)
