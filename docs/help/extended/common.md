# Common

> Part of the Bastion Krypton Suite — Extended Toolkit. NuGet package: `Bastion.Krypton.Extended.Common` (bundled in `Bastion.Krypton.Extended.Ultimate`).

**Assembly:** `Bastion.Krypton.Suite.Extended.Common` · **Namespace:** `Krypton.Toolkit.Suite.Extended.Common` (unchanged from upstream)

## Purpose

Shared building blocks used across the Extended Toolkit, including internal message-box forms, subclassing helpers and common picture/knob controls.

## Key types

- `InternalKryptonMessageBoxExtended : KryptonForm` — internal extended message-box form
- `SubClass : NativeWindow` — window subclassing helper
- `CommonCircularPictureBox : PictureBox` — circular picture box
- `CommonKryptonKnobControlEnhanced : UserControl` — enhanced knob control
- `CommonExtendedKryptonForm : KryptonForm` — common extended form base

## Dependencies

Core Krypton: dual — PackageReference to `Krypton.Toolkit` (100.25.11.328) in the NuGet solution, ProjectReference to the sibling Standard-Toolkit checkout otherwise. Module references: Debug.Tools, Developer.Utilities, Effects, Shared.

## Licence notes

`Utilities\AllowNullAttribute.cs` is .NET Foundation code (MIT), with the original MIT header retained.

## See also

- [Extended Toolkit overview](index.md)
- [Migration from upstream](../migration-from-upstream.md)
