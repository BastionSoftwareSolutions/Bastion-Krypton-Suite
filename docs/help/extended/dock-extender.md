# Dock Extender

> Part of the Bastion Krypton Suite — Extended Toolkit. NuGet package: `Bastion.Krypton.Extended.Dock.Extender` (bundled in `Bastion.Krypton.Extended.Ultimate`).

**Assembly:** `Bastion.Krypton.Suite.Extended.Dock.Extender` · **Namespace:** `Krypton.Toolkit.Suite.Extended.Dock.Extender` (unchanged from upstream)

## Purpose

Adds floating and overlay window behaviour to Krypton forms. A small but functional implementation (the historical "Under Development" flag appears stale).

## Key types

- `KryptonFloatableForm : KryptonForm` — floatable form
- `KryptonOverlayForm : KryptonForm` — overlay form
- Supporting `DockExtender` logic classes

## Dependencies

Core Krypton: dual — PackageReference to `Krypton.Toolkit` (100.25.11.328) in the NuGet solution, ProjectReference to the sibling Standard-Toolkit checkout otherwise. No module references.

## See also

- [Extended Toolkit overview](index.md)
- [Migration from upstream](../migration-from-upstream.md)
