# Contributing — Bastion Krypton Suite (samples)

Thank you for your interest. This repository is the **samples** tree of the Bastion Krypton
Suite and is **one of four repositories** (see the umbrella repo's `REPO-LAYOUT.md`).

## Before you start

- **Clone layout matters.** This repo and its siblings must sit **side by side** under a
  common parent directory — samples reference the core/Extended libraries by relative
  `ProjectReference`. Full instructions: `REPO-LAYOUT.md` in the umbrella repository.
- **Branch model.** Bastion work lives on **`bastion/multitarget`**. Base changes there;
  never rewrite upstream history.

## Building and running

- **Windows only**, Visual Studio 2022 (17.12+) / Build Tools 2022, .NET 10 SDK.
  `net46` needs desktop MSBuild.
- `run-sample.ps1` builds and launches any sample on any of the 11 TFMs
  (`/p:SampleTfm=<tfm>`). `run-sample-matrix.ps1` runs the full launch matrix.

## Standards for samples

- **Every C# sample has a VB.NET twin** and vice versa — keep parity when adding samples.
- Use **designer-generated forms** (real `.Designer.cs` / `.Designer.vb` +
  `InitializeComponent`), not code-only UI — designer serialisation is itself under test.
- VB samples must be **idiomatic VB.NET** (`WithEvents`/`Handles`, `My` namespace where
  natural); reviewed converter output only, never raw machine output.
- **UK English**; **do not rename namespaces or public types**; **do not alter upstream
  copyright/licence headers** (new files: `© Bastion Software Solutions Ltd`, BSD-3-Clause
  derivation). Respect the existing `.editorconfig`; do not mass-reformat.

## Licence

Contributions are accepted under the repository's **BSD 3-Clause Licence** (`LICENSE`).
See `BASTION-NOTICE.md` for the derivation summary.
