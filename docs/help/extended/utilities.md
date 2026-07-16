# Utilities

> Part of the Bastion Krypton Suite — Extended Toolkit. NuGet package: `Bastion.Krypton.Extended.Utilities` (bundled in `Bastion.Krypton.Extended.Ultimate`).

**Assembly:** `Bastion.Krypton.Suite.Extended.Utilities` · **Namespace:** `Krypton.Toolkit.Suite.Extended.Utilities` (unchanged from upstream)

## Purpose

A large utility module, including a vendored managed Speech API layer.

## Key types

- This is an infrastructure/helper module with no user controls.

## Dependencies

Core Krypton: dual — PackageReference to `Krypton.Toolkit` (100.25.11.328) in the NuGet solution, ProjectReference to the sibling Standard-Toolkit checkout otherwise. Module references: Developer.Utilities.

## Licence notes

`Classes\System\SAPI\**` is a large vendored managed Speech API layer derived from the .NET `System.Speech` reference source (MIT, .NET Foundation); the headers have been re-stamped with the Krypton Suite MIT header and no upstream attribution is retained. `Attributes\AllowNullAttribute.cs` is .NET Foundation code (MIT) with its header retained.

## See also

- [Extended Toolkit overview](index.md)
- [Migration from upstream](../migration-from-upstream.md)
