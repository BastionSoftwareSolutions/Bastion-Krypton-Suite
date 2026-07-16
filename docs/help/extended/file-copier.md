# File Copier

> Part of the Bastion Krypton Suite — Extended Toolkit. NuGet package: `Bastion.Krypton.Extended.File.Copier` (bundled in `Bastion.Krypton.Extended.Ultimate`).

**Assembly:** `Bastion.Krypton.Suite.Extended.File.Copier` · **Namespace:** `Krypton.Toolkit.Suite.Extended.File.Copier` (unchanged from upstream)

## Purpose

Provides Krypton-themed file listing, copying and monitoring controls and dialogs.

## Key types

- `KryptonFileListing : UserControl` — file listing control
- `KryptonFileCopier : KryptonForm` — file copy dialog
- `KryptonFileMonitor : KryptonForm` — file monitoring dialog

## Dependencies

Core Krypton: dual — PackageReference to `Krypton.Toolkit` (100.25.11.328) in the NuGet solution, ProjectReference to the sibling Standard-Toolkit checkout otherwise. Module references: Debug.Tools, Developer.Utilities. Third-party package: `WindowsAPICodePackShell` 8.0.12.

## See also

- [Extended Toolkit overview](index.md)
- [Migration from upstream](../migration-from-upstream.md)
