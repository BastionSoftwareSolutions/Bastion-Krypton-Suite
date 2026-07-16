# Contributing — Bastion Krypton Suite (Extended)

Thank you for your interest. This repository is the **Extended** tree of the Bastion
Krypton Suite and is **one of four repositories** (see the umbrella repo's `REPO-LAYOUT.md`).

## Before you start

- **Clone layout matters.** This repo and its siblings must sit **side by side** under a
  common parent directory — Extended modules reference the core suite by relative
  `ProjectReference` (`..\Standard-Toolkit`). Full instructions: `REPO-LAYOUT.md` in the
  umbrella repository.
- **Branch model.** Bastion work lives on **`bastion/multitarget`**, tracking upstream
  `V105-LTS`. Base changes there; never rewrite upstream history.

## Building

- **Windows only**, Visual Studio 2022 (17.12+) / Build Tools 2022 with the .NET desktop
  workload, .NET 10 SDK.
- **`net46` requires desktop MSBuild.** The plain solution
  `Source/Krypton Toolkit/Krypton Toolkit Suite Extended 2022 - VS2022.sln` builds every
  module against the sibling core tree by `ProjectReference`.
- Core references are **rewired to `ProjectReference`** — do not reintroduce upstream
  `Krypton.*` NuGet `PackageReference` pins; they caused the inconsistent-version defects
  this fork fixed.

## Third-party code — read first

Several modules embed third-party code under **MIT / Ms-PL / (historically) CPOL**. Before
adding or modifying such code, check `THIRD-PARTY-NOTICES.md` and the umbrella's
`docs/audit/THIRD-PARTY-LICENCES.md`. **Do not** add CodeProject (CPOL) or unlicensed code:
`Toggle.Switch` and the SharpUpdate half of `Software.Updater` are excluded from release
for exactly this reason.

## Standards

- **UK English**; **do not rename namespaces or public types**; **do not alter upstream
  copyright/licence headers** (add a `© Bastion Software Solutions Ltd` note on new files,
  recording the MIT derivation). Respect the existing `.editorconfig`; do not mass-reformat.

## Licence

Contributions are accepted under the repository's **MIT Licence** (`LICENSE`).
See `BASTION-NOTICE.md` for the derivation summary.
