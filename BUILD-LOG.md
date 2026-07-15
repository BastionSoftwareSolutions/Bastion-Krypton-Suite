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
| DocFX | ❌ not installed | Install as dotnet tool (`dotnet tool install -g docfx`) before Phase 6 |
| Sandcastle Help File Builder (SHFB) | ❌ not installed | Required for CHM in Phase 6 — install before Phase 6 |
| PDF pipeline (wkhtmltopdf / pandoc) | ❌ not installed | Toolchain choice deferred to Phase 6; install then |
| Inno Setup 6 | ❌ not installed | Required for Phase 7 installer — install before Phase 7 |

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

---
