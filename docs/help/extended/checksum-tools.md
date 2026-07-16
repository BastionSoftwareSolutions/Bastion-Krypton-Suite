# Checksum Tools

> Part of the Bastion Krypton Suite — Extended Toolkit. NuGet package: `Bastion.Krypton.Extended.CheckSum.Tools` (bundled in `Bastion.Krypton.Extended.Ultimate`).

**Assembly:** `Bastion.Krypton.Suite.Extended.CheckSum.Tools` · **Namespace:** `Krypton.Toolkit.Suite.Extended.CheckSum.Tools` (unchanged from upstream)

## Purpose

Provides Krypton-themed dialogs for computing and verifying file checksums.

## Key types

- `KryptonBrowseBox : KryptonTextBox` — file-path browse box
- `KryptonComputeFileCheckSum : KryptonForm` — compute a file checksum
- `KryptonVerifyFileCheckSum : KryptonForm` — verify a file checksum
- `...Old` variants of the compute/verify forms

## Dependencies

Core Krypton: dual — PackageReference to `Krypton.Toolkit` (100.25.11.328) in the NuGet solution, ProjectReference to the sibling Standard-Toolkit checkout otherwise. Module references: Debug.Tools, Controls, Developer.Utilities.

## See also

- [Extended Toolkit overview](index.md)
- [Migration from upstream](../migration-from-upstream.md)
