# Contributing — Bastion Krypton Suite (core)

Thank you for your interest. This repository is the **core** tree of the Bastion Krypton
Suite and is **one of four repositories** (see the umbrella repo's `REPO-LAYOUT.md`).

## Before you start

- **Clone layout matters.** This repo and its siblings must sit **side by side** under a
  common parent directory, because project references and HintPaths across the suite are
  relative (`..\Standard-Toolkit`, `..\Extended-Toolkit`, …). Clone the umbrella and the
  three source repos into the same parent folder. Full instructions: `REPO-LAYOUT.md` in
  the umbrella repository.
- **Branch model.** Bastion work lives on **`bastion/multitarget`**, which tracks upstream
  `V105-LTS`. Base your changes on `bastion/multitarget` and open PRs against it. Never
  rewrite upstream history; upstream branches are preserved for future merges.

## Building

- **Windows only.** You need Visual Studio 2022 (17.12+) or Build Tools 2022 with the
  .NET desktop workload, the .NET 10 SDK, and the .NET Framework reference-assembly NuGet
  packages (restored automatically).
- **`net46` requires desktop MSBuild** (classic `.resx` handling); `dotnet build` alone
  cannot build the `net46` target. Use `msbuild` or Visual Studio for a full-matrix build,
  or the umbrella repo's `build-all.ps1`.
- Build the core solution: `Source/Krypton Components/Krypton Toolkit Suite 2022 - VS2022.sln`.

## Standards

- **UK English** in new prose.
- **Do not rename namespaces or public types** — drop-in compatibility is the whole point.
  Assembly names / package IDs carry the `Bastion.` prefix; type names stay `Krypton.*`.
- **Do not alter upstream copyright or licence headers.** New files get a
  `© Bastion Software Solutions Ltd` header noting the BSD-3-Clause derivation.
- Respect the existing `.editorconfig` (under `Source/`); do **not** mass-reformat.
- Aim for **warning-clean** builds (`TreatWarningsAsErrors=true` is enforced); document any
  justified suppression with its warning ID.

## Licence

Contributions are accepted under the repository's **BSD 3-Clause Licence** (`LICENSE`).
See `BASTION-NOTICE.md` for the derivation summary.
