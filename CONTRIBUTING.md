# Contributing — Bastion Krypton Suite (umbrella)

Welcome. This is the **umbrella / orchestration** repository of the Bastion Krypton Suite.
It is **one of four repositories** — the umbrella plus three source trees. Read
[`REPO-LAYOUT.md`](REPO-LAYOUT.md) first; it explains the multi-repo structure and the
exact clone layout the build scripts assume.

## The four repositories

| Repository | Branch | Licence | Holds |
|---|---|---|---|
| **umbrella** (this repo) | `main` | BSD-3 (own content) | BUILD-LOG, CHANGES, README, docs/, Scripts/, Tests/, Installer/, `pack.ps1`, `build-docs.ps1`, `build-all.ps1` |
| **Standard-Toolkit** | `bastion/multitarget` | BSD-3 | the five core libraries |
| **Extended-Toolkit** | `bastion/multitarget` | MIT | the Extended modules |
| **Standard-Toolkit-Demos** | `bastion/multitarget` | BSD-3 | C# + VB samples |

The three source trees are **git-ignored inside this repo** — they are independent clones
with full upstream history, never committed here (see `.gitignore`).

## Getting a working tree

1. Clone this umbrella repo.
2. Into its **root**, clone the three source repos as siblings named exactly
   `Standard-Toolkit`, `Extended-Toolkit`, `Standard-Toolkit-Demos`, each on
   `bastion/multitarget`. (Relative project references assume these names and locations —
   `REPO-LAYOUT.md` has the copy-paste commands.)
3. From the umbrella root, run `./build-all.ps1` (see below).

## Building

- **Windows only.** Visual Studio 2022 (17.12+) or Build Tools 2022 with the .NET desktop
  workload; .NET 10 SDK. `net46` needs **desktop MSBuild** (classic `.resx`); `dotnet build`
  alone cannot build it.
- **`build-all.ps1`** orchestrates the whole suite: core 11-TFM build → Extended → samples
  → smoke/functional check → `pack.ps1` → `build-docs.ps1` → optional installer. Use
  `-SkipDocs`, `-SkipInstaller`, `-Tfm` to scope it. It preflights the sibling clones and
  the toolchain and fails with actionable messages.
- Docs: `./build-docs.ps1 -All` (site + CHM + PDF + coverage) or per-format switches.
  Packages: `./pack.ps1`. Tests: `./Tests/run-tests.ps1`.

## Standards

- **UK English** in new prose.
- **Never rewrite upstream history**; **never rename namespaces or public types**;
  **never alter upstream copyright/licence headers**. New files carry a
  `© Bastion Software Solutions Ltd` header noting which licensed tree they derive from.
- Every substantive change updates `CHANGES.md` and (for phase-level work) `BUILD-LOG.md`.
- Keep builds warning-clean; document any justified suppression with its warning ID.

## Where to make a change

Library code and samples belong in the relevant **source** repo (on `bastion/multitarget`),
not here. This umbrella repo is for orchestration, docs and cross-cutting audit records.

## Licence

The umbrella's own content is **BSD-3-Clause** ([`LICENSE`](LICENSE)); source trees keep
their own licences. See `LICENSE` for the dual-licence map.
