# Circular ProgressBar

> Part of the Bastion Krypton Suite — Extended Toolkit. NuGet package: `Bastion.Krypton.Extended.Circular.ProgressBar` (bundled in `Bastion.Krypton.Extended.Ultimate`).

**Assembly:** `Bastion.Krypton.Suite.Extended.Circular.ProgressBar` · **Namespace:** `Krypton.Toolkit.Suite.Extended.Circular.ProgressBar` (unchanged from upstream)

## Purpose

Provides a circular (radial) progress-bar control with animation support.

## Key types

- `CircularProgressBar` — circular progress-bar control (partial class deriving via a custom base under `Controls\`)

## Dependencies

Core Krypton: dual — PackageReference to `Krypton.Toolkit` (100.25.11.328) in the NuGet solution, ProjectReference to the sibling Standard-Toolkit checkout otherwise. Module references: Debug.Tools, Developer.Utilities. Third-party package: `Unofficial.WinFormAnimation` 2.0.2 (a repack of Soroush Falahati's WinFormAnimation, MIT).

## Licence notes

The control lineage matches Falahati's `CircularProgressBar` (MIT), and the animation dependency is consumed as the `Unofficial.WinFormAnimation` NuGet repack (MIT). No upstream attribution is currently present in the control source.

## See also

- [Extended Toolkit overview](index.md)
- [Migration from upstream](../migration-from-upstream.md)
