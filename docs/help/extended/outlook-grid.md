# Outlook Grid

> Part of the Bastion Krypton Suite — Extended Toolkit. NuGet package: `Bastion.Krypton.Extended.Outlook.Grid` (bundled in `Bastion.Krypton.Extended.Ultimate`).

**Assembly:** `Bastion.Krypton.Suite.Extended.Outlook.Grid` · **Namespace:** `Krypton.Toolkit.Suite.Extended.Outlook.Grid` (unchanged from upstream)

## Purpose

An Outlook-style grouping data grid (20 controls), derived from the Krypton-OutlookGrid project, with grouping, tree columns and custom format rules.

## Key types (representative)

- `KryptonOutlookGrid : KryptonDataGridView` — the Outlook-style grid
- `OutlookGridRow : DataGridViewRow` — grid row
- `KryptonOutlookGridGroupBox : UserControl` — group box
- `KryptonOutlookGridLanguageManager : Component` — language manager
- Tree, format and token column and cell types; `CustomFormatRule : KryptonForm`

## Dependencies

Core Krypton: dual — PackageReference to `Krypton.Toolkit` (100.25.11.328) in the NuGet solution, ProjectReference to the sibling Standard-Toolkit checkout otherwise. No module references.

## Licence notes

Derived from **Cocotteseb/Krypton-OutlookGrid**; around 53 files carry the original header "Copyright (C) 2013-2021 JDH Software … Microsoft Public License (Ms-PL)" (attribution retained). Ms-PL obligations apply.

## See also

- [Extended Toolkit overview](index.md)
- [Migration from upstream](../migration-from-upstream.md)
