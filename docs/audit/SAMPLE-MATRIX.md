# Sample × TFM Build Matrix

**Bastion Krypton Suite — Phase 4a deliverable** (spec: `D:\Krypton-Ultimate\BASTION-KRYPTON-SPEC.md` §5, step 2/5).
Date: 2026-07-16. Repo: `D:\Krypton-Ultimate\Standard-Toolkit-Demos`, branch `bastion/multitarget`.
Phase 4d will extend this file with the scripted run (launch) results for the full sample × TFM grid.

## 1. Scope and result

All **125** C# demo projects (83 Toolkit, 12 Ribbon, 15 Navigator, 7 Workspace, 7 Docking, 1 Explorer; `SAMPLE-INVENTORY.md`) now multi-target the full Bastion matrix, identical to the core toolkit:

`net46; net47; net472; net48; net481; net5.0-windows; net6.0-windows; net7.0-windows; net8.0-windows; net9.0-windows; net10.0-windows`

| Measure | Value |
|---|---|
| Projects × TFMs attempted | 125 × 11 = **1 375** |
| Build errors | **0** |
| Per-project TFM exclusions | **0** — every demo compiles on every TFM |
| Build warnings (samples, total across all 11 TFMs) | **276** summed across the eleven per-TFM legs; a single full-matrix invocation of the master Dev solution reports **282** (a few MSB3243 resolution notices repeat per evaluation context). `TreatWarningsAsErrors` deliberately not yet enabled — Phase 4a records the count |

Canonical build: the **Dev** solution flavour (ProjectReference into the sibling `D:\Krypton-Ultimate\Standard-Toolkit` source tree, `bastion/multitarget`). The relative `..\..\..\..\Standard-Toolkit\Source\Krypton Components\*` paths resolve correctly against the sibling layout and were left unchanged. The NuGet flavour (`Krypton.*.Canary` packages, selected when the solution name ends in `Nuget`) is left intact but is not built. The master build entry point is `Source\Krypton Explorer\Krypton Explorer 2022 - Dev.sln`, which (after this phase) schedules **all** 125 sample projects plus the five core libraries. `Source\WixInstaller` is packaging, not a demo, and is untouched.

Build command per TFM leg (desktop MSBuild 18, `/nr:false`):

```
MSBuild.exe "Source\Krypton Explorer\Krypton Explorer 2022 - Dev.sln" /p:Configuration=Debug /p:TargetFramework=<tfm> /m /nr:false
```

## 2. Warning count per TFM (Debug, full sample recompile, zero from the core libraries)

| TFM | Errors | Warnings |
|---|---|---|
| net46 | 0 | 22 |
| net47 | 0 | 22 |
| net472 | 0 | 22 |
| net48 | 0 | 22 |
| net481 | 0 | 22 |
| net5.0-windows | 0 | 23 |
| net6.0-windows | 0 | 25 |
| net7.0-windows | 0 | 27 |
| net8.0-windows | 0 | 29 |
| net9.0-windows | 0 | 31 |
| net10.0-windows | 0 | 31 |
| **Total** | **0** | **276** |

Warning profile (all pre-existing demo-code quality issues, none are TFM gaps):

| Code | Count | Meaning / where |
|---|---|---|
| CS0169 | 110 | Unused private fields — almost all in `KryptonToastNotification Examples` |
| CS8618 | 66 | Non-nullable field not initialised — `KryptonToastNotification Examples` |
| CS8602 | 41 | Possible null dereference — ToastNotification, Ribbon/KryptonGallery samples |
| CS8625 | 22 | Null literal to non-nullable — ToastNotification |
| CS0618 | 11 | `KryptonThemeComboBox.KryptonCustomPalette` obsolete — `KryptonPalette Examples` |
| SYSLIB0014 | 10 | `WebClient` obsolete (net6+ only) — `Krypton Explorer` update check |
| MSB3243 | 6 | `System.Resources.Extensions` version unification notice on net5/6/7 legs |
| CS8604 | 6 | Possible null argument |
| WFO1000 | 4 | WinForms analyser: property lacks designer serialisation setting (net9/net10 only) — `External Drag To Docking`, `Custom Control using Renderers` |

Deliberate suppression (recorded per spec ground rule 6): `CheckEolTargetFramework=false` in the repo-root `Directory.Build.props` silences NETSDK1138 for the net5/6/7/9 legs (~126 repeats per leg). EOL runtimes are targeted deliberately (spec §0 "Framework lifecycle context"); the core toolkit disables the same advisory in each of its csproj files.

## 3. Central infrastructure added (`Directory.Build.props`, repo root)

1. Central `<TargetFrameworks>` list for every project; the per-csproj `net48;net8.0-windows;net9.0-windows` lines were removed (125 files, one line each).
2. **Single-TFM switch:** `/p:SampleTfm=<tfm>` collapses `TargetFrameworks` to that one TFM — the operational meaning of "use any build library and work".
3. `LangVersion=preview` (matches the core), `EmbeddedResourceUseDependentUponConvention=true` for identical manifest resource naming on every TFM (the fix the Extended repo uses).
4. Same net46 resource rules as the core (`Source\Krypton Components\Directory.Build.props`): `GenerateResourceUsePreserializedResources` and a `System.Resources.Extensions` reference on every TFM **except net46** (the package's floor is net462); net46 resources compile classically, so net46 builds under desktop MSBuild only.
5. `SuppressTfmSupportBuildWarnings` on net5/6/7 (codeless package advisory, same as the core).
6. `TreatWarningsAsErrors` **not** enabled yet, per phase instructions.

## 4. run-sample.ps1 (repo root)

`run-sample.ps1 -Sample <name> -Tfm <tfm> [-Configuration Debug|Release] [-NoLaunch]`; `run-sample.ps1 -List` enumerates the 125 sample names. Builds with `/p:SampleTfm` (restore included) and launches from the shared `Binaries\Krypton Demos\<Configuration>\<TFM>\` output:

- net4x → the built `.exe` directly;
- net5/6/7 → `D:\Krypton-Ultimate\Tools\dotnet-legacy\dotnet.exe <sample>.dll` (archived 5.0.17/6.0.36/7.0.20 desktop runtimes);
- net8+ → system `dotnet <sample>.dll`.

Launch verification (process alive after ≥ 5 s with the correct main-window title, then killed):

| Sample | net46 | net48 | net6.0-windows | net10.0-windows |
|---|---|---|---|---|
| KryptonButton Examples | PASS | — | PASS | PASS |
| Docking Persistence | PASS | — | PASS | PASS |
| Ribbon Controls | — | PASS (after fix, §5) | PASS | PASS |

## 5. Fixes applied, by category

**A. TFM bootstrap / conditional compilation (the expected Phase 4 work):**

- `Krypton Explorer\Main.cs` — two `#if NET48/NET6_0/NET8_0/NET9_0/NET10_0` chains (Palette Designer / Palette Upgrade Tool paths) had no branch for the other six TFMs and were syntax errors there; added `#else` fallbacks.
- `KryptonLinkWrapLabel Example\Program.cs` — used net6+-only `ApplicationConfiguration.Initialize()`; now `#if NET6_0_OR_GREATER` with the classic `Application.EnableVisualStyles()` bootstrap otherwise.

**B. API drift against the v105 core (failed on every TFM; the demos repo lags the core):**

- `KryptonTaskDialog Examples`, `KryptonDataGridView Examples`, `Test MessageBox Clipping` — written against the removed component-based `KryptonTaskDialog` API (`KryptonTaskDialogCommand`, `TaskDialogButtons`, static `Show`); ported to the element-based `KryptonTaskDialog` (`Heading`/`Content`/`FooterBar`/`CheckBox`/`HyperLink`/`CommandLinkButtons` elements). Note: the new API has no `Close` common button (mapped to `Cancel`) and no radio-button group (presented as a combo box selection).

**C. Latent upstream breakage found and fixed:**

- `KryptonLinkWrapLabel Example` — stray `>` made the csproj unparseable, `Program.cs` namespace didn't match `Form1`, and the project was absent from every solution: it had never been scheduled or compiled upstream.
- `KryptonToolStripMenuItem Examples` — valid project, but also scheduled by no solution.
- Both are now in `Krypton Explorer 2022 - Dev.sln` (the master Dev solution), so nothing is silently unbuilt.
- `Ribbon Controls\Form1.Designer.cs` — the five `ButtonSpecs.AddRange` calls present in the original 2017 Component Factory source were lost from the modern designer file, so `Form1_Load` crashed with `IndexOutOfRangeException` **at startup on every TFM** (found by the run-sample launch test; the app showed the WinForms unhandled-exception dialogue). Wiring restored, verified against `ComponentFactory-Krypton\Source\Krypton Ribbon Examples\Ribbon Controls\Form1.Designer.cs`.

**D. Suppressions (documented):** NETSDK1138 via `CheckEolTargetFramework=false` (see §2).

## 6. Commits

Standard-Toolkit-Demos `bastion/multitarget`:

| Commit | Subject |
|---|---|
| `24f8b626` | Bastion Phase 4a: multi-target all 125 demos across the full 11-TFM matrix |
| `0e9fb299` | Bastion Phase 4a: fix demo API drift and latent breaks surfaced by the matrix |

## 7. Known follow-ups for Phase 4d

- Scripted run of the full 125 × 11 launch grid (this file gains the pass/fail table).
- `Ribbon Gallery` / `KryptonGallery Examples` carry the same CS8602 pattern as the pre-fix `Ribbon Controls`; their `Form1_Load` paths deserve a runtime check.
- The 276 code-quality warnings (mostly `KryptonToastNotification Examples`) should be burnt down before `TreatWarningsAsErrors` is enabled for the demos tree.

## Phase 4d — launch matrix results (16 July 2026)

**2,750 launch tests (250 sample apps — 125 C# + 125 VB — x 11 TFMs): ALL PASS.** Each app was
launched on the true runtime for its TFM (net4x native, net5/6/7 via the local legacy runtimes,
net8+ system dotnet) and had to reach an idle message loop and stay alive 5 seconds.

| TFM | Pass |
|---|---|| net10.0-windows | 250/250 |
| net46 | 250/250 |
| net47 | 250/250 |
| net472 | 250/250 |
| net48 | 250/250 |
| net481 | 250/250 |
| net5.0-windows | 250/250 |
| net6.0-windows | 250/250 |
| net7.0-windows | 250/250 |
| net8.0-windows | 250/250 |
| net9.0-windows | 250/250 |
Runner: `run-sample-matrix.ps1` (incremental CSV, 5-way parallel). One defect class was found and
fixed: five VB twins crashed during `InitializeComponent` because VB `Handles` binds at
`WithEvents` field assignment, firing handlers before dependent controls exist (the C# designer
wires events afterwards) — early-return guards added, documented in-source; a repo-wide sweep
found no further currently-triggered instances of the pattern.
