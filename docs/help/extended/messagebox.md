# Message Box

> Part of the Bastion Krypton Suite — Extended Toolkit. NuGet package: `Bastion.Krypton.Extended.Messagebox` (bundled in `Bastion.Krypton.Extended.Ultimate`).

**Assembly:** `Bastion.Krypton.Suite.Extended.Messagebox` · **Namespace:** `Krypton.Toolkit.Suite.Extended.Messagebox` (unchanged from upstream)

## Purpose

Provides an extended Krypton message box with a static API, manager and designer support.

## Key types

- `KryptonMessageBoxManagerTest : Component` — manager component
- `KryptonMessageBoxExtendedFormDevelopment : KryptonForm` — message-box form
- `KryptonMessageBoxConfiguratorDesigner : ControlDesigner` — designer support
- Static `KryptonMessageBoxExtended` API

## Dependencies

Core Krypton: dual — PackageReference to `Krypton.Toolkit` (100.25.11.328) in the NuGet solution, ProjectReference to the sibling Standard-Toolkit checkout otherwise. Module references: Debug.Tools, Developer.Utilities, Shared.

## See also

- [Extended Toolkit overview](index.md)
- [Migration from upstream](../migration-from-upstream.md)
