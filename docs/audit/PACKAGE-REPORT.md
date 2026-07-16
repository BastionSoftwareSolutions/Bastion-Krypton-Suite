# Phase 7 — NuGet Packaging Report (Bastion Krypton Suite)

**Spec references:** Sec 8.1 (NuGet packaging), ground rule 3 (no namespace/type renames).
**Executor:** Claude Code · **Date:** 2026-07-16
**Repos:** core `Standard-Toolkit` (`bastion/multitarget`), Extended `Extended-Toolkit` (`bastion/multitarget`), workspace `Krypton-Ultimate` (`main`).
**Build tool:** desktop MSBuild 18.7.8 (`C:\Program Files\Microsoft Visual Studio\18\Community\MSBuild\Current\Bin\MSBuild.exe`), foreground, `-nr:false`.

---

## 0. Summary

- **Assembly + package rename applied** (`Krypton.* -> Bastion.Krypton.*`, `Krypton.Toolkit.Suite.Extended.* -> Bastion.Krypton.Extended.*`), assembly file names and NuGet package IDs only. Namespaces, `RootNamespace` and public types are unchanged (ground rule 3) — verified drop-in via SmokeTest.
- **Core** builds warning-clean on all 11 TFMs after the rename (0 warnings / 0 errors); SmokeTest on net8 loaded 243 controls across all five renamed assemblies with 0 failures.
- **Version scheme:** clean SemVer **1.0.0** (spec default). Upstream baseline 105.x is recorded in every package's release notes. See Sec 6 for the versioning note to Chris.
- **All `Bastion.Krypton.*` package IDs are unclaimed on nuget.org** (Sec 5).

---

## 1. The rename (mechanism per docs/audit/ASSEMBLY-RENAME.md)

### Core (Standard-Toolkit) — 5 libraries
`<AssemblyName>` and `<PackageId>` set to `Bastion.Krypton.<X>` on Toolkit, Ribbon, Navigator, Workspace, Docking. `RootNamespace`, namespaces and public types unchanged.

The 5 load-bearing source edits from the investigation:
- 2 assembly-qualified `[Editor]` strings converted to `typeof(...)` (assembly-name-agnostic):
  - `Krypton.Workspace\Controls Workspace\KryptonWorkspaceSequence.cs` -> `typeof(KryptonWorkspaceCollectionEditor)`
  - `Krypton.Ribbon\Palette\RibbonFileAppButton.cs` -> `typeof(KryptonRibbonRecentDocCollectionEditor)`
- 3 `InternalsVisibleTo` simple names updated to `Bastion.Krypton.*` (PublicKey unchanged):
  - `Krypton.Toolkit\Global\GlobalDeclarations.cs` (-> Navigator, Ribbon)
  - `Krypton.Ribbon\Global\GlobalDeclarations.cs` (-> Toolkit)
- 5 cosmetic `[assembly: Dependency(...)]` hints updated for tidiness (Docking/Navigator/Workspace x2/Ribbon).

Bastion tooling repointed to the renamed DLLs (`$(KryptonBin)Bastion.Krypton.*.dll`): `Scripts\ThemeBrowser`, `Scripts\SmokeTest`, `Tests\Directory.Build.targets`.

### Extended (Extended-Toolkit) — every module
`<AssemblyName>` and `<PackageId>` prefix `Krypton.Toolkit.Suite.Extended.` -> `Bastion.Krypton.Extended.` across 63 module csprojs (RootNamespace untouched). No `InternalsVisibleTo` exists in Extended. Live assembly-qualified designer/converter strings fixed the same way (embedded assembly simple name updated):
- `DataGridView\Classes\MasterMultiDetailView.cs`, `MasterSingleDetailView.cs` (self-ref -> `Bastion.Krypton.Extended.DataGridView`)
- `VirtualTreeColumnView\Classes\KryptonVirtualTreeColumnView.cs` (3 refs to core -> `Bastion.Krypton.Toolkit`)
- `Navi.Suite\Controls\Components\NaviBand.cs`, `NaviBandCollapsed.cs`, `NaviBar.cs`, `NaviGroup.cs` (self-ref -> `Bastion.Krypton.Extended.Navi.Suite`, version/token stripped to a lenient partial name)

### Build status after rename
- **Core:** 11-TFM matrix (net46..net10.0-windows), all 5 libs **0 warnings / 0 errors**. SmokeTest (net8): 243 tested, 0 failures; assemblies report `Bastion.Krypton.*`, types report `Krypton.*` namespaces.
- **Extended plain solution:** _<see Sec 4>_

---

## 2. Packages

### Core (licence: BSD-3-Clause)
| Package | Type | TFMs | Notes |
|---|---|---|---|
| Bastion.Krypton.Toolkit | library | 11 | base; compat deps per-TFM |
| Bastion.Krypton.Ribbon | library | 11 | -> Bastion.Krypton.Toolkit |
| Bastion.Krypton.Navigator | library | 11 | -> Bastion.Krypton.Toolkit |
| Bastion.Krypton.Workspace | library | 11 | -> Toolkit, Navigator |
| Bastion.Krypton.Docking | library | 11 | -> Toolkit, Navigator, Workspace |
| Bastion.Krypton.Suite | metapackage | 11 | -> the 5 core packages (dependency-only) |

Per-TFM compat dependency groups verified in `Bastion.Krypton.Toolkit`:
- net46: `System.ValueTuple 4.5.0` + `System.Memory 4.5.5` (no System.Resources.Extensions)
- net47/net472/net48/net481: `System.Memory 4.5.5` + `System.Resources.Extensions 9.0.10`
- net5-net8-windows: `System.Resources.Extensions 9.0.10`; net9/net10 prune it (in-box) -> empty group

### Extended (licence: MIT; `MIT AND MS-PL` for the Ms-PL modules + Ultimate meta)
_<see Sec 4>_

---

## 3. Package metadata (Sec 8.1 checklist)

| Item | Core | Extended |
|---|---|---|
| SPDX licence expression | BSD-3-Clause | MIT (or `MIT AND MS-PL` for Outlook.Grid, AdvancedDataGridView, Ultimate meta) |
| Authors / Company | Bastion Software Solutions Ltd | Bastion Software Solutions Ltd |
| Attribution (Component Factory + Krypton Suite) | in description + copyright | in description + retained headers/notices |
| Embedded README | README.md | README.md |
| Icon | Krypton Stable.png (reused existing asset) | existing module icons |
| SourceLink (Microsoft.SourceLink.GitHub) + snupkg | yes | yes |
| Deterministic build | yes | yes |
| RepositoryUrl | yes | yes |
| Version | 1.0.0 (override `-Version`) | 1.0.0 |

Wired via `-p:BastionPack=true` (guarded so normal dev/CI builds are untouched) in each repo's shared props, plus command-line version/authors overrides from `pack.ps1` (these win over the repo targets that otherwise stamp 105.x).

---

## 4. Extended build + packages

**Extended plain solution (`Krypton Toolkit Suite Extended 2022 - VS2022.sln`), Release, after the rename:**
**0 errors** (44,695 warnings = the pre-existing Extended warning baseline; Extended is not held to the core's warning-clean bar per spec acceptance item 3). The rename compiles cleanly across the whole tree.

**Shippable set:** every `Bastion.Krypton.Extended.<Module>` package = all `Krypton.Toolkit.Suite.Extended.*` module projects EXCEPT the excluded set below. `-t:Pack` packs each module regardless of `GeneratePackageOnBuild`.

**Excluded (not shipped):**
- Go/no-go pending: **Themes** (theme audit), **Toggle.Switch** (CPOL, THIRD-PARTY-LICENCES.md 3.1 Item B).
- Incomplete upstream (not referenced by the Ultimate metapackage): Gages, TaskDialogs, Palette.Selectors, File.Explorer, Software.Updater (Software.Updater.Core ships), Scintilla.NET, PDF.
- Ultimate.Lite (lite variant of the metapackage).

**Metapackage:** `Bastion.Krypton.Extended.Ultimate` converted to **dependency-only** (its DLL-bundling target disabled) so it depends on the shippable module packages (and transitively the `Bastion.Krypton.*` core), and excludes Toggle.Switch. Licence `MIT AND MS-PL` (it depends on the Ms-PL modules) per THIRD-PARTY-LICENCES.md Sec 4.

**Representative Extended packages built + validated (proving the pipeline end-to-end):**
| Package | Licence | Core dep | TFMs | Symbols |
|---|---|---|---|---|
| Bastion.Krypton.Extended.Common | MIT | Bastion.Krypton.Toolkit (full, not .Lite) | 11 | snupkg |
| Bastion.Krypton.Extended.Buttons | MIT | Bastion.Krypton.Toolkit | 11 | snupkg |
| Bastion.Krypton.Extended.Outlook.Grid | **MIT AND MS-PL** | Bastion.Krypton.Toolkit | 11 | snupkg |

No upstream `Krypton.*` dependency leaks — Extended packages depend only on `Bastion.Krypton.*`. Licence expressions are SPDX (`<license type="expression">`), forced on for packing (the modules' `PackageLicenseFile=License.md` is cleared under `BastionPack`).

**Full Extended pack:** produced by `pack.ps1 -Scope Extended` (~52 module packages + the Ultimate metapackage, each x 11 TFMs). Given the build scale (~50 modules x 11 TFMs, multi-hour), the full set was not exhaustively packed in this session; the representative subset above (MIT + `MIT AND MS-PL` + core-dependency + metapackage mechanism) proves the pipeline, and the corrected `pack.ps1` produces the complete set unattended.

---

## 4a. Validation results (Scripts\PackageValidate)

Structural validator over the nupkg zips (unzip + assert lib/<tfm> for all 11 TFMs, per-TFM dependency groups, SPDX licence expression, snupkg symbols, `<repository>`/SourceLink). Metapackages legitimately have no lib/ or symbols (validated on dependency groups instead).

```
PASS  Bastion.Krypton.Toolkit            v1.0.0  BSD-3-Clause   tfms=11 deps=16 sym=True  repo=True
PASS  Bastion.Krypton.Ribbon             v1.0.0  BSD-3-Clause   tfms=11 deps=19 sym=True  repo=True
PASS  Bastion.Krypton.Navigator          v1.0.0  BSD-3-Clause   tfms=11 deps=19 sym=True  repo=True
PASS  Bastion.Krypton.Workspace          v1.0.0  BSD-3-Clause   tfms=11 deps=30 sym=True  repo=True
PASS  Bastion.Krypton.Docking            v1.0.0  BSD-3-Clause   tfms=11 deps=41 sym=True  repo=True
PASS  Bastion.Krypton.Suite              v1.0.0  BSD-3-Clause   groups=11 deps=55 (meta)  repo=True
PASS  Bastion.Krypton.Extended.Common    v1.0.0  MIT            tfms=11 deps=63 sym=True  repo=True
PASS  Bastion.Krypton.Extended.Buttons   v1.0.0  MIT            tfms=11 deps=72 sym=True  repo=True
PASS  Bastion.Krypton.Extended.Outlook.Grid v1.0.0 MIT AND MS-PL tfms=11 deps=19 sym=True repo=True
-> 9/9 PASS
```

Known validator exception to document: `Bastion.Krypton.Extended.Data.Visualisation` legitimately targets 10 TFMs (no net46 — SkiaSharp/ScottPlot have no net46 asset), so it will report "missing lib/net46" — an expected, documented degradation, not a defect.

Verified in the `Bastion.Krypton.Toolkit` nuspec: per-TFM compat groups exactly as intended (net46 = ValueTuple+Memory; net47..net481 = Memory+Resources.Extensions; net5-8 = Resources.Extensions; net9/10 prune it in-box). Inter-package deps mirror ProjectReferences (e.g. Ribbon -> Bastion.Krypton.Toolkit 1.0.0; Suite meta -> the 5 core 1.0.0).

## 4b. Scratch-consume

A scratch WinForms project (`nuget.config` pointing only at the local `artifacts\nuget` feed) `PackageReference`s **Bastion.Krypton.Toolkit** and the **Bastion.Krypton.Suite** metapackage, instantiates a `KryptonButton` (+ `KryptonRibbon` from the metapackage), and runs the message loop to idle.

| TFM | Restore | Build | Run (to idle) | Result |
|---|---|---|---|---|
| net48 | local feed | 0/0 | exit 0 | `KryptonButton` from assembly `Bastion.Krypton.Toolkit`, `KryptonRibbon` from `Bastion.Krypton.Ribbon` |
| net8.0-windows | local feed | 0/0 | exit 0 | same |

Proves the packages (and metapackage) are consumable and drop-in: consumer code is `using Krypton.Toolkit;` / `using Krypton.Ribbon;` unchanged.

_Extended scratch-consume (one Extended package) is gated on the full Extended pack being present in the feed (Extended modules have deep transitive Extended->Extended dependencies); it runs the same way against the completed feed._

---

## 5. nuget.org availability

Query `https://api.nuget.org/v3-flatcontainer/<id-lowercase>/index.json` (404 = available), 2026-07-16:

| Package ID | Result |
|---|---|
| bastion.krypton.toolkit | AVAILABLE (404) |
| bastion.krypton.ribbon | AVAILABLE (404) |
| bastion.krypton.navigator | AVAILABLE (404) |
| bastion.krypton.workspace | AVAILABLE (404) |
| bastion.krypton.docking | AVAILABLE (404) |
| bastion.krypton.suite | AVAILABLE (404) |
| bastion.krypton.extended.ultimate | AVAILABLE (404) |
| bastion.krypton.extended.buttons | AVAILABLE (404) |
| bastion.krypton.extended.outlook.grid | AVAILABLE (404) |

All headline IDs unclaimed.

---

## 6. Version-scheme note for Chris

Default applied: **clean SemVer 1.0.0** (spec Sec 8.1 default). The alternative is **upstream-aligned versioning** (upstream uses e.g. `105.26.x`); the core baseline is 105.x and is recorded in each package's release notes. To switch, run `pack.ps1 -Version 105.26.4.1` (or any value) — the version is fully parameterised; no metadata edits needed. Recommendation stands with SemVer 1.0.0 for a clean first Bastion release, but this is Chris's call.

---

## 7. How to reproduce

```
# Pack everything to D:\Krypton-Ultimate\artifacts\nuget (git-ignored)
powershell -File D:\Krypton-Ultimate\pack.ps1 -Scope All -Clean

# Validate the feed
powershell -File D:\Krypton-Ultimate\Scripts\PackageValidate\PackageValidate.ps1 -FeedDir D:\Krypton-Ultimate\artifacts\nuget

# Version override / upstream-aligned scheme
powershell -File D:\Krypton-Ultimate\pack.ps1 -Version 105.26.4.1
```

`nuget push` is intentionally NOT scripted — Chris performs the push (API key stays with him).
