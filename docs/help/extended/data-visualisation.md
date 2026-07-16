# Data Visualisation

> Part of the Bastion Krypton Suite — Extended Toolkit. NuGet package: `Bastion.Krypton.Extended.Data.Visualisation` (bundled in `Bastion.Krypton.Extended.Ultimate`).

**Assembly:** `Bastion.Krypton.Suite.Extended.Data.Visualisation` · **Namespace:** `Krypton.Toolkit.Suite.Extended.Data.Visualisation` (unchanged from upstream)

## Purpose

Provides SkiaSharp-hosted plotting surfaces for charts and data visualisation, built on a vendored copy of ScottPlot 5.

## Key types

- `FormsPlot` — SkiaSharp-hosted plot surface
- `FormsPlotGL` — GL-accelerated plot surface
- `FormsPlotBase : UserControl` — shared plot-surface base

## Dependencies

Core Krypton: dual — PackageReference to `Krypton.Toolkit` (100.25.11.328) in the NuGet solution, ProjectReference to the sibling Standard-Toolkit checkout otherwise. Module references: Core. Third-party packages: `SkiaSharp` 3.119.1, `SkiaSharp.Views.WindowsForms` 3.119.1, `NETStandard.Library` 2.0.3, `System.Diagnostics.Debug` 4.3.0.

## Licence notes

The entire `Scott Plot\` directory is vendored **ScottPlot 5** source (MIT, © Scott Harden and contributors), with the namespace rewritten to `Krypton.Toolkit.Suite.Extended.Data.Visualisation.ScottPlot`. The files currently carry no upstream attribution and `License\License.txt` is the Krypton Suite MIT text; the MIT licence requires preservation of the original copyright notice.

## See also

- [Extended Toolkit overview](index.md)
- [Migration from upstream](../migration-from-upstream.md)
