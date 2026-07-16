# Networking

> Part of the Bastion Krypton Suite — Extended Toolkit. NuGet package: `Bastion.Krypton.Extended.Networking` (bundled in `Bastion.Krypton.Extended.Ultimate`).

**Assembly:** `Bastion.Krypton.Suite.Extended.Networking` · **Namespace:** `Krypton.Toolkit.Suite.Extended.Networking` (unchanged from upstream)

## Purpose

Provides Krypton-themed networking dialogs (5 controls) for drive mapping, scanning, node picking and viewing.

## Key types

- `KryptonNetworkDriveOptions : KryptonForm` — network drive options
- `KryptonNetworkScanner : KryptonForm` — network scanner
- `KryptonNetworkUtility : KryptonForm` — network utility
- `KryptonNetworkNodePicker : KryptonForm`, `KryptonNodeViewer : KryptonForm`

## Dependencies

Core Krypton: dual — PackageReference to `Krypton.Toolkit` (100.25.11.328) in the NuGet solution, ProjectReference to the sibling Standard-Toolkit checkout otherwise. Module references: Common, Debug.Tools. Third-party package: `System.DirectoryServices` 10.0.0.

## See also

- [Extended Toolkit overview](index.md)
- [Migration from upstream](../migration-from-upstream.md)
