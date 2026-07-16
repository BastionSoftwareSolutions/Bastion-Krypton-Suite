# Bastion Krypton Suite — Build Log

Spec: `BASTION-KRYPTON-SPEC.md` v1.1 (15 July 2026). All times local.

---

## Phase 0 — Environment verification (15 July 2026)

**Machine:** Windows 11 Pro x64 (build 10.0.26200), drive D: ~3.3 TB free.

| Requirement | Status | Version / detail |
|---|---|---|
| Windows 10/11 x64 | ✅ | Windows 11 Pro 10.0.26200, 64-bit |
| Visual Studio 2022 17.12+ or Build Tools 2022, .NET desktop workload | ✅ (exceeded) | **Visual Studio Community 2026 18.7.2** with `Microsoft.VisualStudio.Workload.ManagedDesktop`; MSBuild 18.7.8.30822 |
| .NET SDK 10.0.x | ✅ | 10.0.301 (also 8.0.422 present) |
| .NET Framework targeting packs 4.6 / 4.7 / 4.8 / 4.8.1 | ⚠️ partial | Installed reference assemblies: v4.6, v4.6.1, v4.6.2, v4.7.2, v4.8. **Missing: 4.7, 4.7.1, 4.8.1** — per spec, use `Microsoft.NETFramework.ReferenceAssemblies` NuGet packages for all Framework TFMs (preferred anyway for CI reproducibility). No blocker.
| git | ✅ | 2.54.0.windows.1 |
| `dotnet pack` (NuGet packing) | ✅ | via .NET SDK 10.0.301 (standalone nuget.exe not installed; not required) |
| HTML Help Workshop (hhc) | ✅ | `C:\Program Files (x86)\HTML Help Workshop\hhc.exe` (not on PATH) |
| DocFX | ✅ (installed 16 Jul, Phase 6) | 2.78.5 global tool (`%USERPROFILE%\.dotnet\tools\docfx.exe`) |
| Sandcastle Help File Builder (SHFB) | ✅ (installed 16 Jul, Phase 6) | 2026.3.29.0 via MSI; `SHFBROOT=C:\Program Files (x86)\EWSoftware\Sandcastle Help File Builder\`; headless build engine (MRefBuilder + `.targets`) present — CHM builds via `msbuild *.shfbproj` |
| PDF pipeline | ✅ (installed 16 Jul, Phase 6) | **Decision: pandoc 3.10 + wkhtmltopdf 0.12.6** (Markdown→PDF via the wkhtmltopdf engine — scriptable, no LaTeX dependency). `%LOCALAPPDATA%\Pandoc\pandoc.exe`; `C:\Program Files\wkhtmltopdf\bin\wkhtmltopdf.exe` |
| Inno Setup 6 | ✅ (installed 16 Jul, for Phase 7) | ISCC at `%LOCALAPPDATA%\Programs\Inno Setup 6\ISCC.exe` |

**Full Phase 6/7 toolchain verified 16 Jul 2026.** All installed non-interactively (SHFB from its GitHub MSI; the rest via winget). Note: these live on per-user paths, not the machine PATH — `build-docs.ps1`/`pack.ps1` reference them explicitly or prepend to PATH.

**Decision:** core build/test tooling (Phases 1–5) is fully present, so the build proceeds. The four missing items are documentation/packaging tools not needed until Phases 6–7; they are flagged here so they can be installed (winget or direct download; some need admin) before those phases start. This is a recorded deviation from strict "fail fast" — nothing in Phases 1–5 depends on them.

**Note for Chris:** VS 2026 (18.x) supersedes the spec's VS2022 requirement; net6.0+ and designer work are covered. If any tool behaves differently under 18.x vs 17.x it will be recorded here.

---

## Phase 1 — Source acquisition and version audit (15 July 2026)

### Clones (full history, completed 15 Jul 2026)

| Repo | Local path | HEAD at clone |
|---|---|---|
| Krypton-Suite/Standard-Toolkit | `Standard-Toolkit\` | master @ 6bd821bf (15 Jul 2026) |
| ComponentFactory/Krypton | `ComponentFactory-Krypton\` | frozen 2017 source |
| Krypton-Suite/Standard-Toolkit-Demos | `Standard-Toolkit-Demos\` | current master |
| Krypton-Suite/Extended-Toolkit | `Extended-Toolkit\` | master @ 3c670803 (29 Nov 2025) |

### Version currency check (spec §2.3)

- **NuGet stables confirmed 15 Jul 2026:** `Krypton.Toolkit` **105.26.4.110** (20 Apr 2026) — matches spec baseline; `Krypton.Toolkit.Suite.Extended.Ultimate` **105.26.4.114** (24 Apr 2026) — *newer than the spec's baseline fact* (spec v1.1 noted a Nov 2024 90.x GitHub release; the Extended 105 line ships via NuGet without GitHub releases). Spec's "Extended lags core" risk is largely retired: both are on the 105 line, four days apart.
- **Upstream does not tag stable releases.** Versions are date-derived at build time (`105.<yy>.<M>.<dayOfYear>`); GitHub releases carry only VS templates. The stable line lives on branch **`V105-LTS`** in both repos (master is the unreleased v110 development line).
- **Baseline decision (deviation from "release tag" wording, recorded per spec §2.3):**
  - **Standard-Toolkit baseline = `origin/V105-LTS` tip `57824ec4` (15 Jul 2026).** The exact 20-Apr-2026 release snapshot is not identifiable: V105-LTS shows no commits between 31 Jan and early Jun 2026, followed by explicit "Recover … V105 source fixes" commits dated 6–7 Jun 2026 (upstream history incident; backup branches `zzz-*-20260607` exist). The current LTS tip is upstream's canonical, serviced V105 stable line — a superset of the shipped release including ~30 post-release LTS bug fixes (context-menu overflow, DPI/accessibility, docking tooltips, toggle-switch null ref, etc.). Not canary/alpha.
  - **Extended-Toolkit baseline = `origin/V105-LTS` tip `2725d8c4` (17 Jan 2026)** — this tip predates the 24 Apr build date and is therefore the **exact source** of NuGet 105.26.4.114.
- Work branches created: `bastion/multitarget` in both clones, tracking `origin/V105-LTS`.

### Upstream TFMs (baseline)

`net472;net48;net481;net8.0-windows;net9.0-windows;net10.0-windows` (confirmed in `Krypton.Toolkit 2022.csproj`; conditional on `ExcludeVs2019/2022UnsupportedTargetFrameworks` properties, default = all six).

### Baseline palette set (spec §2.7 record; feeds Phase 3 THEME-AUDIT)

**57 `PaletteMode` values** in `Krypton.Toolkit\Palette Base\PaletteMode.cs`:
- Professional: `ProfessionalSystem`, `ProfessionalOffice2003` (**Office 2003 survives** — Phase 3 gap item is refresh, not restore)
- Office 2007: Blue/Silver (each +DarkMode/+LightMode), White, Black (+DarkMode), DarkGray, LightGray — 11 variants
- Office 2010: same spread as 2007 — 11 variants
- Office 2013: White, DarkGray, LightGray — 3 variants
- Microsoft 365: Blue/Silver (each +Dark/+Light), White, Black (+DarkMode, +BlackDarkModeAlternate), DarkGray, LightGray — 12 variants
- Sparkle: Blue/Orange/Purple × (normal/Dark/Light) — 9 variants
- Visual Studio 2010: ×4 renderers (2007/2010/2013/365)
- **Material: Light, Dark, LightRipple, DarkRipple — present upstream but absent from spec §4 baseline facts; must be preserved and included in the theme audit**
- `Custom`
- Confirmed Phase 3 gaps: no distinct Office 2016, 2019, 2021/2024 palettes (M365 folds the Colorful era in, as spec expected).

### Baseline builds (as shipped, unmodified)

- **Standard-Toolkit** `Krypton Toolkit Suite 2022 - VS2022.sln`, Release: **succeeded, 0 warnings, 0 errors**, 1m43s. All five libraries × `net472;net48;net481;net8.0-windows;net9.0-windows;net10.0-windows` + TestForm. Outputs under `Standard-Toolkit\Bin\Release\<tfm>\`. Note: net481 built fine without a local 4.8.1 targeting pack (reference assemblies restored via NuGet).
- **Extended-Toolkit** `Krypton Toolkit Suite Extended 2022 - VS2022 - NuGet.sln` (the "as shipped" flavour — consumes published `Krypton.*` NuGet packages), Release:
  - **dotnet CLI build: fails (91 errors).** The MSB3822/MSB3823 class ("non-string resources require GenerateResourceUsePreserializedResources") on net4x targets is **toolchain-induced** — it disappears entirely under desktop MSBuild. Upstream builds with VS/desktop MSBuild; conclusion recorded: **Extended must be built with desktop MSBuild** (or the resx handling modernised in Phase 2 — preferred, so `dotnet build` works everywhere).
  - **Desktop MSBuild 18.7.8: 31 NuGet packages build successfully** (including `Ultimate` and `Ultimate.Lite`, stamped 105.26.7.196 by the date-derived scheme), **but three code projects fail** — pre-existing upstream defects on the V105-LTS branch, seeded into `BREAKAGE-LOG.md` scope for Phase 5 and candidates for upstream contribution:
    1. `Krypton.Toolkit.Suite.Extended.Software.Updater` — 51 errors, MSB3103: `Properties\Resources.resx` references linked resource files missing from the repository.
    2. `Krypton.Toolkit.Suite.Extended.Themes` — 24 errors: NU1605 package downgrades (project pins `Krypton.Toolkit` 95.25.4.111 while `Extended.Shared` pins 100.25.11.328) and CS1721 (`CustomPaletteBase` declares base classes `Component` **and** `PaletteBase`, which itself derives from `Component` in newer core versions).
    3. `AutoUpdateCreator` — 8 errors, CS1705/NU1605: assembly-version mismatches from the same inconsistent pinning.
    4. `Extended Toolkit API Documentation.shfbproj` — MSB4019, SHFB not installed (expected; docs project, not a library — excluded from library-build verdicts).
  - **Root defect:** Extended csprojs pin core `Krypton.*` packages **per project and inconsistently** (mixtures of 95.25.4.111 / 95.25.10.293 / 100.25.11.328 — never 105.x, despite this branch being the source of the 105.26.4.114 release). Stray `Krypton - Backup.*.csproj` files pin versions as old as 65.x. All of this is eliminated in Phase 2 by rewiring every module to `ProjectReference` against our single core source tree; the mixed-pin defect is recorded for `CHANGES.md`.
  - **Exit-criterion note:** the spec's "baseline builds clean as shipped" is met for the core Standard-Toolkit but **not achievable verbatim for Extended** — the shipped branch state does not compile fully under any local toolchain. Recorded as a deviation; the three failing modules get go/no-go entries in `EXTENDED-INVENTORY.md` triage and their fixes happen on `bastion/multitarget`.

### Audit results (full detail in `docs/audit/`)

- **`ULTIMATE-PARITY.md`** — 842 original public classes audited: **828 present by identical name (98.3 %)**; Navigator 100 %. Toolbox surface 252/255 by identical name. One genuine regression (KryptonRichTextBox ButtonSpecs, stripped upstream Dec 2024, issue #240). Nothing missing lives in Extended-Toolkit. Decision items for Chris: (1) port RichTextBox ButtonSpecs — recommended yes; (2) KryptonTaskDialog compat shim — recommended no (survives by name, elements-based rewrite); (3) Palette Designer app has no successor — separate work item, check upstream's dedicated Palette-Designer repo first.
- **`EXTENDED-INVENTORY.md`** — 61 module libraries + 2 meta-packages + 3 apps; 51 modules bundled in Ultimate. **Empty/stub or parked modules found:** File Explorer, Gages (assembly misspelt "Guages"), Palette Selectors, PDF, Scintilla.NET (zero sources), TaskDialogs, Tools (empty yet bundled!), Themes (minimal), Software.Updater (parked), Security, MessageDialog. README's under-development flags partly stale (Dock Extender, Panels, Toggle Switch are implemented and ship). "Fast Coloured TextBox" module no longer exists on this branch. **12 modules + both meta-packages lack the ProjectReference fallback and always pull core from NuGet — the concrete Phase 2 rewiring list.** Other defects: Software.Updater.Core PackageId collision; dead NSec references (TFM conditions never match); stale core pins (95.x, 90.x).
- **`EXTENDED-INVENTORY.md` licence findings (⚠️ ground-rule-2 material, action required before any redistribution):**
  - Attribution retained correctly: Outlook.Grid (JDH Software, Ms-PL), AdvancedDataGridView (Ms-PL), NetSparkle (MIT).
  - **Attribution stripped upstream:** vendored ScottPlot 5 (~344 files, licence file replaced), AutoUpdater.NET/SharpUpdate, ~340 files of System.Speech/SAPI reference source, Cyotek colour-picker-derived code, probable CPOL gGlowBox fragment.
  - Root LICENSE is MIT but `Directory.Build.targets` stamps packages `BSD-3-Clause` (upstream inconsistency).
  - Plan: full `THIRD-PARTY-LICENCES.md` audit in Phase 2 restores every attribution in our tree; the CPOL fragment (licence incompatible with simple redistribution) is escalated to Chris with options (replace / remove / comply with CPOL terms).
- **`SAMPLE-INVENTORY.md`** — 125 modern C# demos supersede the 92 originals 1:1 (verdict: use modern set). Extended has a single Examples app covering ~23 of 61 modules; **~34 non-infrastructure modules need purpose-written samples**. **VB.NET baseline is zero** — the entire VB sample set is new work in Phase 4.

### Phase 1 exit-criteria status

| Criterion | Status |
|---|---|
| Baseline builds clean as shipped (core) | ✅ 0 warnings / 0 errors, all six upstream TFMs |
| Baseline builds clean as shipped (Extended, v1.1 scope) | ⚠️ 31 packages build (desktop MSBuild); 3 projects fail from pre-existing upstream defects — recorded above, fixed in Phase 2 |
| `ULTIMATE-PARITY.md` complete | ✅ |
| `EXTENDED-INVENTORY.md` complete (v1.1) | ✅ |
| `SAMPLE-INVENTORY.md` complete | ✅ |
| `BUILD-LOG.md` updated | ✅ (this entry) |

**Deferred / carried forward:** Phase 6–7 tool installs (DocFX, SHFB, PDF pipeline, Inno Setup 6); Chris decision items (RichTextBox ButtonSpecs, TaskDialog shim, Palette Designer, stub-module go/no-go, CPOL fragment); Extended defect fixes land in Phase 2.

**Phase 1 complete — 15 July 2026.**

---

## Phase 2 — Multi-targeting expansion (started 15 July 2026)

### Core five: full matrix ✅

All five core libraries build **warning-clean (0 warnings / 0 errors)** for the full matrix:
`net46;net47;net472;net48;net481;net5.0-windows;net6.0-windows;net7.0-windows;net8.0-windows;net9.0-windows;net10.0-windows`

**Decision (spec §3):** `net472` **retained** alongside the spec's ten TFMs (11 total) for upstream diff-friendliness. `TreatWarningsAsErrors=true` now enforced suite-wide.

**API gaps found and fixed (far fewer than budgeted — upstream's code is largely down-level clean):**

| Gap | TFMs | Fix (spec ladder step) |
|---|---|---|
| `System.Resources.Extensions` has no net46-compatible version (min net462) | net46 | (d, narrow) net46 opts out of preserialized resources; classic resx compilation → **net46 builds under desktop MSBuild only**; also excluded upstream's direct net462-dll `<Reference>` on net46 |
| `System.ValueTuple` types missing | net46 | (b) `System.ValueTuple` 4.5.0 package, net46-only condition |
| `Control.DeviceDpi` absent (added net462) | net46 | (a) new `General\Net46Compat.cs`: C# 14 extension property on `Control` supplying system DPI via GDI; six bare `DeviceDpi` uses qualified with `this.` (identical semantics on all TFMs) |
| `DpiChangedEventArgs`/`DpiChanged` absent (added net47) | net46 | (c) `#if NET47_OR_GREATER \|\| !NETFRAMEWORK` (was upstream's stale `#if !NET462`). **Documented degradation:** net46 does not track per-monitor DPI changes (platform limitation of 4.6 anyway) |
| `MemoryExtensions.Count` mis-guarded upstream as `NET5_0_OR_GREATER` (API is .NET 8+) | net5/6/7 | (c) corrected to `#if NET8_0_OR_GREATER`; existing manual loop covers 5/6/7 — **genuine upstream bug**, invisible to upstream because they skip 5/6/7 |
| `ClassInterfaceType.AutoDispatch` obsolete warnings | net5/6 | existing upstream pragma guard widened from NET8+ to NET5+ |
| `[AllowNull]` on `KryptonForm.Font` guarded NET8+ but base annotation exists on all .NET (Core) TFMs | net5/6/7 | guard widened to `NET5_0_OR_GREATER` |
| `ISite.Container` annotated non-nullable in net5 ref assemblies | net5 | two design-time stub sites (`Toolkit`, `Workspace`) declared non-nullable returning `null!` (safe: stub sites, container legitimately absent) |
| Codeless "package doesn't support net5/6/7" advisory from System.Resources.Extensions buildTransitive targets | net5/6/7 | **Documented suppression** (`SuppressTfmSupportBuildWarnings=true`, those three TFMs only): the netstandard2.0 asset is used and functionally sufficient; advisory has no warning code so per-code `NoWarn` is impossible |

**Spec risk item retired early:** `Microsoft.WindowsDesktop.App.Ref` for net5/6/7 restored and compiled without issue.

### API-matrix sweep ✅ (`docs/audit/API-MATRIX.md`, generated by `Scripts/ApiMatrix`)

- Ribbon, Navigator, Workspace: **public surface identical across all 11 TFMs** (0 differences).
- Toolkit: 18 differing signatures — all deliberate platform-floor gates, several **widened from upstream's blanket net8 gate to the API's true floor** (verified against the actual `Microsoft.WindowsDesktop.App.Ref` packs): `ClientGuid` net5+, `FolderBrowserDialog` `ClientGuid`/`InitialDirectory` net6+ (`InitialDirectory` now on **every** TFM via the sub-net8 wrapper), `CheckWriteAccess` net7+, `MdiChildrenMinimizedAnchorBottom` net6+.
- Docking: 2 differences — upstream's pre-existing `#if NET10_0_OR_GREATER` swap of `OnClosing`→`OnFormClosing` (net10 removed the obsolete member).
- `MaybeNull`/`NotNull` attribute polyfills made `internal` (were `public` — CS0433 ambiguity risk; upstream inconsistency).

### Smoke instantiation matrix ✅ (`Scripts/SmokeTest`)

**11/11 TFMs × 230 public Component types: 0 failures**, each TFM on its true runtime (Framework 4.8.1; locally installed .NET 5.0.17/6.0.36/7.0.20 desktop runtimes in `Tools\dotnet-legacy\`; system 8/9/10). The suite found and fixed **six genuine upstream bugs** (dispose-time NREs in KryptonComboBox and five list/tree/grid controls, an always-throwing MDI property setter, a wrong API guard) — full detail with repro and root cause in `docs/audit/BREAKAGE-LOG.md`, all candidates for upstream contribution.

### Extended Toolkit rewiring ✅ (commit `07499bba` in Extended-Toolkit; triage in `docs/audit/EXTENDED-BUILD-TRIAGE.md`)

- 11-TFM matrix centralised in Extended's `Directory.Build.props`; `-windows7.0` suffixes normalised; 14 NuGet-only core consumers rewired to dual-mode ProjectReference; core resource rules ported; Themes/Software.Updater/PackageId defects fixed; 4 stale backup csprojs deleted; 20 net46-incompatible third-party PackageReferences conditioned out of net46 only.
- Result: restore 69/69 (was 38/69 failing); **25/64 projects build all 11 TFMs, 28 more build 10/11**; converged error set from **8 root-cause projects**.
- Notable: `Examples` app is silently never scheduled by the solution build despite Build.0 entries — flagged for Phase 4.
- Warning-clean pass deferred until errors are cleared (baseline ~42.5k warning lines, ~29k NRT).

### Third-party licence restoration ✅ (Extended commit `af34b5c7`; report `docs/audit/THIRD-PARTY-LICENCES.md`)

- Attribution restored via directory-level LICENCE/THIRD-PARTY-NOTICES files (no upstream copyright lines touched, no `.cs` edits): ScottPlot 5 (347 files, canonical MIT © Scott Harden restored), AutoUpdater.NET (MIT © RBSoft), System.Speech/SAPI reference source (338 files, .NET Foundation MIT), Cyotek (MIT), Navi.Suite (Guifreaks MIT), Circular.ProgressBar (falahati MIT).
- Package licence metadata fixed: MIT (was dormant BSD-3-Clause stamp); Outlook.Grid, AdvancedDataGridView and both Ultimate metapackages now `MIT AND MS-PL` — Bastion packaging must mirror this and ship the notices in the nupkgs.
- **Decisions needed from Chris (licence):**
  1. **gGlowBox fragment** (`ImageBoxExtended.cs` ~2878–2913): probable CPOL derivative via Cyotek's adaptation. Recommend clean-room reimplementation (~30 lines, ~1 hour).
  2. **Toggle.Switch module**: CPOL-derived at module scale (Johnny J's CodeProject control). Recommend excluding from the first Bastion release.
  3. **SharpUpdate half of Software.Updater**: upstream publishes no licence at all — attribution cannot cure it. Recommend removal (AutoUpdater.NET/NetSparkle cover the use case; module already excluded from Ultimate).
  4. AdvancedWizard (Steve Bate): no declared licence upstream — courtesy licence request, low priority.
  - Six smaller CodeProject-adapted fragments inventoried as CPOL-risk (UAC shield ×5 modules, MRU manager, ToolBox, progress-bar paint, CheckBoxComboBox, toast pop-up) — see report §6.

### Extended fix pass ✅ (Extended commit `dae9be10` + follow-ups; full detail `docs/audit/EXTENDED-BUILD-TRIAGE.md` §6)

- Zero build errors across the plain solution: 64/65 projects build (63 × all 11 TFMs; Data.Visualisation ×10 by design; `Themes` deliberately unscheduled pending Chris's go/no-go). Highlights: the net46 cascade fixed at ladder rung (b) via the classic WindowsAPICodePack package (full API, no degradation); Software.Updater WPF references aligned per TFM; `KryptonLanguageManager` drift resolved.
- Warning-clean pass deferred to a follow-up (baseline ~29k NRT warnings — tracked, not blocking).

### Extended smoke sweep ✅ (`EXTENDED-BUILD-TRIAGE.md` §7)

- **654 of 659 module-dir × TFM runs green** on true runtimes (~11,000 type instantiations); the only 5 non-green runs are Software.Updater net5–net9, a documented raw-DLL-loader artifact of the harness (`BREAKAGE-LOG.md` E24) — the module itself passes net4x and net10.
- **23 distinct upstream defects found + fixed at source** (`BREAKAGE-LOG.md` E1–E23), the standouts: an inverted fade-out loop that hung every fading form on close (all .NET Core TFMs) and a zero-speed fade recursion hanging forms on Show (net4x); a null-owner NRE in the **core** `PaletteFormBorder` (fixed in Standard-Toolkit, core solution re-verified 0 errors/0 warnings); a designer-resx manifest-name divergence breaking ~60 types on net4x (fixed suite-wide via `EmbeddedResourceUseDependentUponConvention`); static `GlobalPaletteChanged` subscription leaks in 10 controls plus the `KryptonComboBoxTree` dropdown-form leak that hung both Ultimate metas; a `ColourCollection` operator StackOverflow; the .NET 9 `SystemColors.UseAlternativeColorSet` reflection break; a `Nullable<uint>` P/Invoke; the unsigned WinFormAnimation dependency on net4x.
- 5 types genuinely show modal UI by design and sit on the harness's documented skip list (justified per entry in `Scripts/SmokeTest/Program.cs`).

### Phase 2 exit-criteria status

| Criterion (spec §3) | Status |
|---|---|
| Five core libraries compile warning-clean, all TFMs | ✅ 11 TFMs, `TreatWarningsAsErrors=true` |
| Extended modules compile, all TFMs (v1.1) | ✅ 63/64 × 11 TFMs (+1 ×10 by design); `Themes` excluded pending Chris go/no-go; warning-clean deferred (documented) |
| API matrix report | ✅ `API-MATRIX.md` — differences exactly match documented degradations |
| Smoke instantiation per TFM | ✅ core 11×230×0; Extended 654/659 runs green (5 = documented harness artifact, E24) |

**Phase 2 complete — 15 July 2026.** (Carried into Phase 3+: Extended warning-clean pass; Chris decisions listed below.)

---

## Phase 3 — Themes (15–16 July 2026)

### Audit + references + harness ✅
- `docs/audit/THEME-AUDIT.md`: 100 palette classes, 239-slot scheme architecture, complete W1–W15 wiring map (22 core files + 5 Extended), upstream fidelity-issue census. Two new upstream defects found: **T1** (nine modes missing from 105 command switches → runtime AOOR) and **T2** (Office 2003 palette XP-gated — rendered as system palette on Win10/11).
- `docs/themes/*-colours.md` (five eras) from 35 cited reference images + Microsoft's own ProfessionalColorTable source; eyedropper tooling in `Scripts/Eyedropper`.
- `Scripts/ThemeBrowser` render harness; baseline captures of all pre-existing palettes preserved in `docs/themes/comparisons/placeholder/` (the before-images for sign-off).

### Implementation ✅ (core commits `aacb27109`, `ce350c90c`, `4b146cfab`, `437bae5e1`; Extended `1803760c`)
- **14 new PaletteMode values**: Office2003 Olive/Silver; Office2016 Colorful/White/DarkGray; Office2019 Colorful/White/DarkGray/Black; Office2021 Colorful/White/DarkGray/Black; Microsoft365DarkGray (formerly an unwired upstream TODO). All wired end-to-end incl. Extended Theme Switcher; T1 fixed by a consolidated `PaletteImageSetResolver`; T2 un-gated (Luna Blue unconditional).
- **All schemes filled with provenance-tagged colours** ([T] from cited tables / [D] derived by documented rule / [N] donor-neutral), pixel-verified in captures against the tables. M365 palettes refreshed to genuine 2026 visuals (mapping: Blue→Colorful, White→White, DarkGray→Dark Gray, Black→Black/Dark Mode; companions derived coherently). **This intentionally changes the existing M365 look** — before/after pairs: `comparisons/placeholder/` vs `comparisons/m365-2026/`.
- Theme sweep: all modes capture with zero rendering exceptions; cross-era regression checks pixel-clean between passes.

### Known issues / open items
- **Static `PaletteBase._colorLut` wart** (upstream): checked-fill colours are a last-writer-wins static registry shared across palettes — instantiation-order-dependent; affects every family. Phase 5 fix candidate.
- ce350c90c's ribbon tab-row consumer shifted legacy Material Dark (by that palette's own declared value) and ~7.6k px on old M365Blue (subsumed by the refresh) — part of sign-off review.
- Microsoft365LightGray remains an unwired upstream stub (no scheme, no 2026 counterpart).
- 2003 ToolStrip/menu colour table still system-derived (Luna values documented for a later `KryptonProfessionalKCT` extension).

### Awaiting Chris (Phase 3 acceptance) — see below

---

## Phase 6 — Documentation (16 July 2026)

Toolchain installed + version-recorded in Phase 0 table above. PDF pipeline decision: **pandoc 3.10 + wkhtmltopdf 0.12.6**.

| Deliverable | Result |
|---|---|
| `CHANGES.md` (spec §7.1) | ✅ definitive change record — baseline, 11-TFM strategy, 14 new themes + M365 refresh, sample counts, ~40-defect tally, per-TFM feature matrix, degradations, dual-licence attribution, EOL warnings (commit `07faa8b`) |
| public `README.md` | ✅ what/why, install (Bastion.Krypton.* "on publication"), C#+VB quick start, theme gallery, drop-in upstream relationship, dual licence |
| DocFX site (spec §7.2) | ✅ `docs-site/` from XML comments + `docs/help/**` conceptual articles (getting-started, theming, per-family + per-Extended-module, migration note, per-TFM matrix); custom link-checker in `build-docs.ps1` |
| CHM | ✅ `Help/BastionKryptonSuite.chm` (68.8 MB) via SHFB `.shfbproj` + hhc, headless MSBuild |
| PDF | ✅ `Help/BastionKryptonSuite-Manual.pdf` (46 pp, TOC) via pandoc→wkhtmltopdf |
| XML doc coverage (`docs/audit/XMLDOC-COVERAGE.md`) | ✅ **core 87.8% types / 87.9% members** (Docking/Ribbon/Workspace ~100%, Toolkit 85%); Extended reported; project-introduced members filled at source |

All three help formats build from one repeatable `build-docs.ps1` (`-All` or per-format). Generated output git-ignored; scripts/sources/conceptual content committed (`a8755bc`). **CI note (Phase 8):** DocFX is cross-platform, but **CHM (hhc) and the SHFB/PDF steps are Windows-only** — CI builds the DocFX site; CHM/PDF need a Windows runner or manual step.

**Phase 6 complete — 16 July 2026.**

---

## Phase 5 — Testing suite (16 July 2026)

Framework: **NUnit 3.14** (reaches net46, which NUnit 4 and xUnit-STA do not). Runner mechanism:
`dotnet test` on net47–net10; self-executing **NUnitLite** console exes on net46 (tooling floor) and
net5/6/7 (testhost can't see the private legacy runtimes) — both on the true runtime. `Tests\run-tests.ps1`.

| Stage | Result |
|---|---|
| 5a — scaffolding | ✅ UnitTests, FormsTests (C#+VB, designer-generated by `FormsTestGen`), StressTests, helpers (STA pump, handle counter, screenshot-on-failure); starter regressions lock the Phase 2/3 fixes |
| 5b — functional coverage | ✅ `FunctionalTests`: spec §6.2 recipe over **243 types/TFM** (4,624 property sets + 1,462 method calls); found+fixed F1 (KryptonToggleSwitch), 2 OPEN (F2/F3) |
| 5c — adversarial | ✅ all nine §6.3 attack categories; **default green net46(189)/net48(197)/net8(197)/net10(189)**; endurance net48+net8; **8 defect classes fixed (A1–A8, incl. 3 process-killing crashes), 2 OPEN (A9/A10)** |
| 5d — matrix | ✅ **functional 44/44 across all 11 TFMs, 0 failures**; adversarial on the spec-minimum four; `docs/audit/TEST-MATRIX.md` |

Phase 5 exit criteria: functional suite green on all TFMs ✅; adversarial suite executed + all findings triaged ✅; `BREAKAGE-LOG.md` complete ✅. **Phase 5 complete — 16 July 2026.**

Defect tally across the whole test effort (Phases 2–5), counted from `BREAKAGE-LOG.md` entries: **~40 genuine upstream defect classes found and fixed** — six Phase-2 core dispose-time NREs, **Extended smoke E1–E25** (25 entries; E24 is a harness note, not a defect), two Phase-3 theme wiring bugs T1–T2, one Phase-5b (F1), eight Phase-5c A1–A8 — plus **four OPEN** design-judgement items (A9, A10, F2, F3) documented for Chris. All [UPSTREAM]-tagged as upstream-contribution candidates. (An earlier "~24" figure here under-counted the Extended smoke series; corrected 16 Jul.)

---

## Phase 4 — Samples (16 July 2026)

| Stage | Result |
|---|---|
| 4a — multi-target the demo set | ✅ 125 C# demos × 11 TFMs = **1,375 builds, 0 errors, 0 exclusions**; central props with `/p:SampleTfm=` switch; `run-sample.ps1`; fixes incl. a Ribbon demo startup crash (designer-lost ButtonSpec wiring) and two projects orphaned from every solution (Demos commits `24f8b626`, `0e9fb299`) |
| 4b — Extended module samples | ✅ Examples app extended: **16 new designer-generated forms covering 17 modules** + 6 orphaned forms registered; permanent `--smoke` hook, **46/46 forms pass**; 3 more module bugs found+fixed (Extended commit `31203dfe`) |
| 4c — VB.NET twin set | ✅ **125 idiomatic hand-ported VB twins** (9 agent batches; real .Designer.vb, Friend WithEvents/Handles, My.Resources, Handles-parity + designer statement-count audits all green), registered in the Dev solution; consolidated build **0 errors / 0 warnings** (Demos commits through `9a5c2f59`) |
| 4d — launch matrix | ✅ **2,750 launch tests (250 apps × 11 TFMs): all pass** on true runtimes; one defect class found+fixed (VB `Handles` fires during InitializeComponent — five twins guarded; commit `04f09155`); results in `SAMPLE-MATRIX.md` |

Phase 4 exit criteria: sample matrix green ✅; C#/VB parity 100% ✅ (125/125 twins); `run-sample.ps1` works ✅. **Phase 4 complete — 16 July 2026.**

### Awaiting Chris (Phase 3 acceptance)
1. **Per-theme fidelity sign-off** from the comparison images (`docs/themes/comparisons/`): office2016-2019 (7), office2021-2003 (2021 ×4 + Luna ×3), m365-2026 (11).
2. **Live-install screenshots** to close the [D]-tagged gaps: hover/pressed/disabled states, backstage, context menus, inactive title bars (all eras); 2021 Dark Gray/Black expanded ribbon; 2016 status-bar accent question; 2026 classic-Outlook accent; XP Olive/Silver caption gradients.

---

---
