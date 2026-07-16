# InputBox

> Part of the Bastion Krypton Suite — Extended Toolkit. NuGet package: `Bastion.Krypton.Extended.InputBox` (bundled in `Bastion.Krypton.Extended.Ultimate`).

**Assembly:** `Bastion.Krypton.Suite.Extended.InputBox` · **Namespace:** `Krypton.Toolkit.Suite.Extended.InputBox` (unchanged from upstream)

## Purpose

Provides an extended Krypton input box with manager components and supporting forms (6 controls in total).

## Key types

- `KryptonInputBoxExtendedManager` / `KryptonInputBoxExtendedAlternateManager : Component` — manager components
- `KryptonInputBoxExtendedForm` / `KryptonInputBoxExtendedAlternateForm` / `KryptonInputBoxExtendedFormTest : KryptonForm` — input box forms
- `InternalKryptonBorderedLabel` — internal bordered label

## Dependencies

Core Krypton: dual — PackageReference to `Krypton.Toolkit` (100.25.11.328) in the NuGet solution, ProjectReference to the sibling Standard-Toolkit checkout otherwise. Module references: Settings, Shared.

## See also

- [Extended Toolkit overview](index.md)
- [Migration from upstream](../migration-from-upstream.md)
