# Migration from Upstream Krypton

Bastion Krypton Suite is a drop-in fork of the Krypton-Suite Standard and Extended Toolkits.
Migrating an existing application is deliberately low-friction. The authoritative,
fully-cited record of every change is `CHANGES.md` at the repository root; this page is the
short version for someone porting code.

## What does *not* change

- **Namespaces are identical.** You keep `using Krypton.Toolkit;`,
  `using Krypton.Toolkit.Suite.Extended.Outlook.Grid;` and so on. No source edits to `using`
  directives are required.
- **Public type names are identical.** `KryptonButton`, `KryptonRibbon`, `KryptonManager`,
  `KryptonOutlookGrid` — every public type keeps its name and signature.
- **Behaviour and rendering are the same** on the frameworks upstream already supported; the
  public API surface is verified identical across all target frameworks bar a handful of
  documented, framework-floor-gated members (see the [feature matrix](per-tfm-feature-matrix.md)).

## What changes

| Aspect | Upstream | Bastion |
|---|---|---|
| NuGet package IDs | `Krypton.Toolkit`, `Krypton.Ribbon`, … | `Bastion.Krypton.Toolkit`, `Bastion.Krypton.Ribbon`, … |
| Extended package IDs | `Krypton.Toolkit.Suite.Extended.<Module>` | `Bastion.Krypton.Extended.<Module>` |
| Metapackages | `Krypton.Toolkit.Suite.Extended.Ultimate` | `Bastion.Krypton.Suite` (core), `Bastion.Krypton.Extended.Ultimate` (Extended) |
| Assembly file names | `Krypton.Toolkit.dll`, … | `Bastion.Krypton.Toolkit.dll`, … (namespaces inside unchanged) |
| Target frameworks | six (`net472`–`net481`, `net8`–`net10`) | **eleven** (`net46`, `net47`, `net472`, `net48`, `net481`, `net5.0`–`net10.0`-windows) |

The assemblies are renamed with the `Bastion.` prefix specifically so they do **not** collide
with upstream `Krypton.*` assemblies in the GAC or in binding — you can have both installed.

## Steps to migrate

1. **Swap the package references.** Replace each `Krypton.*` / `Krypton.Toolkit.Suite.Extended.*`
   `PackageReference` with its `Bastion.*` equivalent. Nothing else in the project file needs to
   change to keep building on your current framework.
2. **Rebuild.** Source code compiles unchanged because the namespaces and types are the same.
3. **Re-register designer toolbox items** (design-time only). Because the assembly file names
   changed, remove the old `Krypton.*` toolbox entries and add the `Bastion.Krypton.*`
   assemblies. The installer ships a *Designer integration* readme with the exact steps for
   Framework and .NET projects.
4. **(Optional) widen your target frameworks.** If you were blocked on an older runtime, you can
   now target `net46`–`net7.0` as well. Read the per-framework notes first.

## Things to know

- **`net46` is the most constrained target.** It compiles under desktop MSBuild only (classic
  resources), pulls `System.ValueTuple` and `System.Memory` as compat dependencies, and does
  not track per-monitor DPI changes (a .NET Framework 4.6 platform limitation). Details in the
  [feature matrix](per-tfm-feature-matrix.md) and `CHANGES.md` §2.
- **EOL frameworks.** .NET 5/6/7/9 and .NET Framework 4.6/4.6.1 are out of Microsoft support and
  are included deliberately for pinned consumers. Prefer .NET 8 or .NET 10 for new work.
- **Licensing.** Core packages remain BSD-3-Clause; Extended packages are MIT (© 2017–2024
  Krypton Suite). Attribution to Component Factory Pty Ltd and the Krypton Suite team is
  retained throughout. See `CHANGES.md` §9.
- **Upstream relationship.** Bastion tracks the upstream **V105-LTS** line. Merging newer
  upstream releases is a future task; the strategy is recorded in `CHANGES.md`.

## See also

- The change record `CHANGES.md` at the repository root
- [Per-TFM feature matrix](per-tfm-feature-matrix.md)
- [Getting started](getting-started.md)
