# Software Updater Core

> Part of the Bastion Krypton Suite — Extended Toolkit. NuGet package: `Bastion.Krypton.Extended.Software.Updater.Core` (bundled in `Bastion.Krypton.Extended.Ultimate`).

**Assembly:** `Bastion.Krypton.Suite.Extended.Software.Updater.Core` · **Namespace:** `Krypton.Toolkit.Suite.Extended.Software.Updater.Core` (unchanged from upstream)

## Purpose

The software update engine used by the suite, built on a vendored copy of NetSparkleUpdater.

## Key types

- This is an infrastructure/helper module with no user controls (update engine).

## Dependencies

Core Krypton: NuGet-only — consumed exclusively as NuGet PackageReferences to `Krypton.Toolkit`, `Krypton.Navigator`, `Krypton.Ribbon` and `Krypton.Docking` in every configuration. Module references: Developer.Utilities. Third-party packages: `Newtonsoft.Json` 13.0.4, `Portable.BouncyCastle` 1.9.0, `WindowsAPICodePack` 8.0.12.

## Licence notes

The `NetSparkle\` directory is vendored **NetSparkleUpdater** source (MIT, © 2022 Deadpikle), with the original headers retained.

> Note: upstream, this project's csproj mistakenly declared the `Core` module's PackageId; in Bastion the package identity is `Bastion.Krypton.Extended.Software.Updater.Core`.

## See also

- [Extended Toolkit overview](index.md)
- [Migration from upstream](../migration-from-upstream.md)
