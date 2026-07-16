# Forms

> Part of the Bastion Krypton Suite — Extended Toolkit. NuGet package: `Bastion.Krypton.Extended.Forms` (bundled in `Bastion.Krypton.Extended.Ultimate`).

**Assembly:** `Bastion.Krypton.Suite.Extended.Forms` · **Namespace:** `Krypton.Toolkit.Suite.Extended.Forms` (unchanged from upstream)

## Purpose

Extended Krypton form types (13 in total), including a slide form, transparent panels and window button specs.

## Key types (representative)

- `KryptonFormExtended : VisualKryptonFormExtended` — extended form base
- `KryptonSlideForm` — slide form
- `VisualForm : Form`, `TransparentPanel : KryptonPanel` — visual form and transparent panel
- `ButtonSpecFormWindowClose` / `Max` / `Min` — window button specs
- `VisualBlur : NativeWindow` — blur helper

## Dependencies

Core Krypton: dual — PackageReference to `Krypton.Toolkit` (100.25.11.328) in the NuGet solution, ProjectReference to the sibling Standard-Toolkit checkout otherwise. Module references: Shared.

## Licence notes

`Utilities\AllowNullAttribute.cs` is .NET Foundation code (MIT), with the original MIT header retained.

## See also

- [Extended Toolkit overview](index.md)
- [Migration from upstream](../migration-from-upstream.md)
