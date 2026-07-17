# Bastion notice — Extended Toolkit

This repository is the **Extended** tree of the **Bastion Krypton Suite**, a derivative
work maintained by **Bastion Software Solutions Ltd**. It is a fork of the
[Krypton Extended Toolkit](https://github.com/Krypton-Suite/Extended-Toolkit).

## Licence

This tree remains under the **MIT Licence** (see [`LICENSE`](LICENSE)), © 2017–2024
Krypton Suite. The upstream copyright and permission notice is retained unchanged.
Bastion has **not** altered any upstream copyright or licence header. New files
introduced by this project carry a `© Bastion Software Solutions Ltd` header alongside
a note recording that the work derives from this MIT-licensed tree.

Several Extended modules embed or derive from **third-party code** under other licences
(MIT, Ms-PL and others). Those attributions are recorded in
[`THIRD-PARTY-NOTICES.md`](THIRD-PARTY-NOTICES.md) and, in fuller detail, in the umbrella
repository's `docs/audit/THIRD-PARTY-LICENCES.md`. A small number of CodeProject-derived
(CPOL) fragments are flagged there and escalated to the project owner for a
replace / remove / comply decision **before** redistribution — the `Toggle.Switch` module
and the SharpUpdate half of `Software.Updater` are, on current advice, **excluded** from
the first Bastion release.

Nothing in this notice grants, removes, or modifies any right under the MIT licence or the
third-party licences; it is descriptive only.

## What Bastion changed here (summary)

All work is on the **`bastion/multitarget`** branch, preserving full upstream history.

- **Multi-targeting** centralised to the full **11-TFM matrix** (a documented reduced set
  where a third-party dependency has no down-level asset — e.g. `Data.Visualisation` has
  no `net46` because ScottPlot/SkiaSharp do not).
- **Core references rewired** from inconsistent upstream NuGet `PackageReference` pins
  (mixtures of 95.x / 100.x, and stray 65.x/90.x backups) to a single dual-mode
  `ProjectReference` against the one Bastion core source tree.
- **~25 upstream defect classes** found and fixed (a form-hanging fade-out loop, static
  palette-event subscription leaks, a designer-resx manifest-name divergence, and more).
- **Third-party attribution restored** where upstream had stripped it (ScottPlot 5,
  AutoUpdater.NET, System.Speech reference source, Cyotek, and others).
- **Assembly names and NuGet package IDs** gain a `Bastion.Krypton.Extended.` prefix.
  **Namespaces and public type names are unchanged.**

## Where the full record lives

The definitive change record is the **umbrella repository's `CHANGES.md`**; the
third-party licence audit is `docs/audit/THIRD-PARTY-LICENCES.md` there. This repo is one
of four; see the umbrella repository's `REPO-LAYOUT.md` for the clone layout.

> Not affiliated with or endorsed by Component Factory Pty Ltd or the Krypton Suite team.
