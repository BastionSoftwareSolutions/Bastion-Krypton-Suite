# Bastion Krypton Suite — Full Build Specification for Claude Code

**Version:** 1.1 — 15 July 2026 (scope expanded: Extended Toolkit now fully included)
**Owner:** Chris, Bastion Software Solutions Ltd
**Executor:** Claude Code (agentic build), running on Windows
**Status:** Approved for execution

---

## 0. Mission

Produce **Bastion Krypton Suite**: an up-to-date, multi-targeted build of the Krypton Component Suite (Ultimate Edition component set — Toolkit, Ribbon, Navigator, Workspace, Docking) **plus every component of the Krypton Extended Toolkit** (`Krypton-Suite/Extended-Toolkit` — ~40 module libraries including Outlook Grid, Advanced/Tree/Standard Data Grid Views, Calendar, Wizard, Notifications/Toast, Message Box, Task Dialogs, Fast Coloured TextBox, Circular Progress Bar, Data Visualization, Theme Switcher, Ribbon extensions and the rest), based on the actively maintained Krypton-Suite Standard Toolkit, extended to compile and run on **.NET Framework 4.6 / 4.7 / 4.8** and **.NET 5 / 6 / 7 / 8 / 9 / 10**, with faithful themes for every Office release and Microsoft 365, dual-language (C# + VB.NET) samples, a full adversarial testing suite, a complete change README, help documentation in three formats (DocFX website, CHM, PDF), an Inno Setup installer, and NuGet packages under the `Bastion.Krypton.*` prefix ready for public publishing to nuget.org and GitHub.

### Decisions already made (do not revisit)

| Decision | Value |
|---|---|
| Base codebase | `Krypton-Suite/Standard-Toolkit` (current stable line, v105.x) |
| Extended Toolkit | **Fully in scope** (decision of 15 July 2026, supersedes the earlier out-of-scope ruling): every component module of `Krypton-Suite/Extended-Toolkit`, packaged as `Bastion.Krypton.Extended.<Module>` plus an all-in `Bastion.Krypton.Extended.Ultimate` metapackage |
| Completeness cross-check | Original `ComponentFactory/Krypton` (2017 Ultimate open-sourcing) |
| NuGet package ID root | `Bastion.Krypton.*` (e.g. `Bastion.Krypton.Toolkit`) |
| Help formats | DocFX static site **and** CHM (Sandcastle Help File Builder) **and** PDF manual |
| Installer | Inno Setup |
| SFTP library rule | N/A to this project — this spec has no Rebex dependency |
| Publishing | Chris publishes manually to nuget.org and GitHub; Claude Code prepares everything push-ready |

### Baseline facts (verified 15 July 2026 — re-verify at execution time)

- Active repo: https://github.com/Krypton-Suite/Standard-Toolkit — BSD-3-Clause.
- Current stable NuGet: `Krypton.Toolkit` **105.26.4.110** (20 Apr 2026). Prior stables: 100.26.1.19 (Jan 2026), 100.25.11.328 (Nov 2025), 95.25.10.293 (Oct 2025).
- Upstream TFMs at v105: `net472`, `net48`, `net481`, `net8.0-windows`, `net9.0-windows`, `net10.0-windows`. Upstream **dropped** .NET Core 3.1 and .NET 5 (release cadence), .NET 6/7 (at v90), and .NET Framework < 4.7.2 (at v100).
- Upstream palettes already include Office 2007, Office 2010, Office 2013, Microsoft 365, Sparkle, Professional and Visual Studio variants.
- Original repo: https://github.com/ComponentFactory/Krypton — frozen, .NET Framework only, BSD-3-Clause, © Component Factory Pty Ltd.
- Companion repos: `Krypton-Suite/Standard-Toolkit-Demos`, `Krypton-Suite/Extended-Toolkit`, `Krypton-Suite/Documentation`.
- Extended Toolkit: https://github.com/Krypton-Suite/Extended-Toolkit — **MIT licence** (verified 15 July 2026 from the repo LICENSE file: © 2017–2024 Krypton Suite), ~40+ module libraries shipped individually and as `Krypton.Toolkit.Suite.Extended.Ultimate` / `.Ultimate.Lite` NuGet packages. Historic TFM support is narrower than the Standard Toolkit (README documents net481 + net5–net8 era targets; "Lite" variants drop .NET Framework) — confirm the current release line and TFMs at execution time. Several modules are flagged **"Under Development"** upstream (Dock Extender, File Explorer, Gauges, Palette Selectors, Panel, Toggle Switch — re-verify the list at execution time).

### Framework lifecycle context (flag in README; user has accepted this)

.NET 5 (EOL May 2022), .NET 6 (EOL Nov 2024), .NET 7 (EOL May 2024) and .NET 9 (STS, EOL May 2026) are **out of Microsoft support**, as are .NET Framework 4.6/4.6.1 (April 2022). They are included deliberately for consumers pinned to old runtimes. .NET 8 (LTS to Nov 2026) and .NET 10 (LTS) are the supported mainline. The README and package notes must state this plainly so consumers aren't misled.

---

## 1. Ground rules for Claude Code

1. **Never guess.** If an API signature, upstream behaviour, or build error cause is unknown, read the source or documentation. Do not stub, mock, or `TODO` anything unless explicitly agreed.
2. **Licence compliance is non-negotiable.** This is now a **dual-licence project**: Standard-Toolkit and original Component Factory code are BSD-3-Clause; the Extended Toolkit is **MIT** (© 2017–2024 Krypton Suite). Retain all Component Factory Pty Ltd and Krypton Suite copyright headers and LICENSE files, per-tree; keep the MIT permission notice with all Extended-derived code; add attribution for both in README; do not imply endorsement by Component Factory or the Krypton Suite team. Do not rename copyright lines. New files added by this project carry `© Bastion Software Solutions Ltd` headers alongside a note stating which licensed tree the work derives from. **Third-party-code sub-audit (Extended Toolkit):** several Extended modules embed or derive from third-party projects (e.g. Fast Coloured TextBox derives from FastColoredTextBox, historically LGPL); before redistribution, enumerate every module's embedded third-party code and its licence in `docs/audit/THIRD-PARTY-LICENCES.md`. Any module whose licence is incompatible with closed-source consumption or with our redistribution terms is escalated to Chris with options (exclude, replace, or comply) before packaging.
3. **Do not rename namespaces or public types.** The value of this build is drop-in compatibility. `Krypton.Toolkit` namespaces stay as-is; only assembly names/package IDs gain the `Bastion.` prefix. Record this decision in the README.
4. **Preserve git history.** Start from a fork/clone of Standard-Toolkit with full history; all work on a branch (`bastion/multitarget`). Never rewrite upstream history.
5. **Every phase ends with a checkpoint commit and a written status note** appended to `BUILD-LOG.md` (what was done, what failed, what was deferred).
6. **Warning-clean builds.** `TreatWarningsAsErrors=true` per TFM is the target; where upstream noise makes that impractical, document each suppressed warning ID and why.
7. **UK English in all new prose** (README, help topics, changelog).

### Required environment (verify before Phase 1; fail fast if missing)

- Windows 10/11 x64 machine or VM. **This build cannot be completed on macOS/Linux**: .NET Framework targets, WinForms runtime tests, SHFB (CHM), and Inno Setup all need Windows.
- Visual Studio 2022 (17.12+) or Build Tools 2022 with .NET desktop workload. **VS2019 is not sufficient** — it cannot build net6.0+ projects. Note for Chris: designer work on .NET 8/10 WinForms requires VS2022.
- .NET SDK 10.0.x (builds all `netN.0-windows` TFMs down to net5.0 given targeting packs).
- .NET Framework targeting packs: 4.6, 4.7, 4.8 (and 4.8.1). Where developer packs are unavailable, use the `Microsoft.NETFramework.ReferenceAssemblies` NuGet packages — preferred anyway for CI reproducibility.
- Sandcastle Help File Builder (SHFB) + HTML Help Workshop (for CHM); DocFX (dotnet tool); a PDF pipeline (wkhtmltopdf or DocFX→pandoc — Claude Code selects and records the choice); Inno Setup 6; git; nuget CLI or `dotnet pack`.
- Verify each with a version command and record versions in `BUILD-LOG.md`.

---

## 2. Phase 1 — Source acquisition and version audit

**Goal:** a verified, current baseline plus a completeness map against the original Ultimate Edition.

1. Clone `Krypton-Suite/Standard-Toolkit` (full history). Identify the **latest stable release tag** (v105 line as of writing — confirm on the releases page and NuGet at execution time; if a newer stable exists, use it and record the delta from this spec).
2. Clone `ComponentFactory/Krypton` (original Ultimate source), `Krypton-Suite/Standard-Toolkit-Demos`, and `Krypton-Suite/Extended-Toolkit` (full history — Extended work happens on its own `bastion/multitarget` branch in that clone).
3. **Version currency check (explicit user requirement):** compare the local baseline against the current NuGet stable and the repo's master/main. If the chosen tag is older than the newest stable release, move to the newest stable. Do not build from canary/alpha unless a needed fix only exists there — if so, cherry-pick and document.
4. **Ultimate Edition completeness audit.** Enumerate every project/assembly and every public control in the original: Toolkit, Ribbon, Navigator, Workspace, Docking (and anything else present in the original `Krypton Components Suite.sln`). Map each to its Standard-Toolkit equivalent. Output `docs/audit/ULTIMATE-PARITY.md`: a table of original type → current type → status (present / renamed / superseded / missing). Anything **missing** gets a decision entry: port it, or document why not (e.g. superseded by a better replacement).
5. **Extended Toolkit audit (fully in scope as of spec v1.1).** Enumerate every module library in `Extended-Toolkit` — released and "Under Development" alike — with its controls, upstream package ID, current version, TFMs, dependencies (including inter-module and third-party), and upstream maintenance status. Output `docs/audit/EXTENDED-INVENTORY.md`. Identify the latest stable Extended release tag the same way as step 1/3 (newest stable wins). For each **"Under Development"** module: attempt a baseline build; if it builds and passes smoke tests it ships, if not it gets a documented go/no-go entry escalated to Chris (ship broken code never). Cross-reference against the Ultimate parity audit — any originally-Ultimate component living in Extended is now covered automatically.
6. Inventory upstream demo/sample projects for Phase 5 reuse; inventory the original Component Factory samples (C# and any VB.NET) for parity porting.
7. Record baseline: commit SHA, tag, NuGet versions, TFM list, palette list, control count. This becomes the "Before" column of the change README.

**Exit criteria:** baseline builds clean as shipped (upstream TFMs, unmodified) on the build machine; `ULTIMATE-PARITY.md` complete; `BUILD-LOG.md` updated.

---

## 3. Phase 2 — Multi-targeting expansion

**Goal:** every library builds for the full matrix:

`net46; net47; net48; net481; net5.0-windows; net6.0-windows; net7.0-windows; net8.0-windows; net9.0-windows; net10.0-windows`

(`net481` retained because upstream already ships it and dropping it would be a regression. `net472` may also be retained at Claude Code's discretion for upstream diff-friendliness — record the decision.)

### Method

1. Edit `<TargetFrameworks>` in each library project: the five core libraries (`Krypton.Toolkit`, `Krypton.Ribbon`, `Krypton.Navigator`, `Krypton.Workspace`, `Krypton.Docking`) **and every Extended Toolkit module library** from the Phase 1 inventory. Do the core five first (everything Extended depends on them), then Extended modules in dependency order. Build the matrix one TFM at a time, oldest first (`net46` will surface the most gaps). Extended modules were written against a narrower TFM window than the core, so expect the net46/net47 gap-fill effort to repeat there; an Extended module that genuinely cannot reach an old TFM after the full API-gap ladder below gets a documented reduced-TFM set in the feature matrix rather than a silent drop — escalate to Chris if the reduced set excludes any .NET Framework target entirely.
2. **API-gap handling, in order of preference:**
   a. Polyfill via compiler-only shims — `PolySharp` (or hand-rolled `IsExternalInit`, `required`/`init` attribute shims) for language-feature support on old TFMs. Language version stays current; most C# 10–12 features compile fine down-level.
   b. Well-known compat packages for old TFMs only: `System.ValueTuple` (net46), `System.Memory`, `Microsoft.Bcl.HashCode`, `System.Runtime.CompilerServices.Unsafe` — added conditionally per-TFM in the csproj, never for net8.0+.
   c. `#if` conditional compilation using the standard symbols (`NET46_OR_GREATER`, `NET5_0_OR_GREATER`, etc.) where behaviour genuinely differs (DPI APIs, `Control.DeviceDpi`, default-font handling, `Application.SetHighDpiMode` which does not exist pre-net5).
   d. **Feature degradation as last resort**: if a feature cannot exist on an old TFM (e.g. an API with no polyfill), compile it out with `#if` and document it in the README's per-TFM feature matrix. Never ship a silently broken member.
3. **Nullable reference types:** keep upstream's annotations; NRT is compile-time and works on all TFMs.
4. **Designer support:** keep `System.ComponentModel` designer attributes intact across TFMs. Verify the toolbox/designer assemblies load for .NET Framework (classic designer) and note that net5/6/7 designer support in VS is limited/absent — runtime support is the requirement, designer support is best-effort and must be documented per TFM.
5. **Resources and manifests:** confirm embedded resources (palette images, cursors) resolve identically on every TFM; watch for `Resources.Designer.cs` regeneration differences.
6. After each library reaches full-matrix compilation, run its unit tests (Phase 6 suite, once it exists — initially smoke: instantiate every public control per TFM in a WinForms message loop and dispose cleanly).
7. **Binary sanity:** for each TFM output, run a reflection sweep that loads the assembly and enumerates all public types/members, comparing across TFMs. Differences must exactly match the documented `#if` degradations. Save the report to `docs/audit/API-MATRIX.md`.

### Known risk items (investigate, don't assume)

- Upstream v105 code was written against net472+ — expect uses of `HashCode`, `Span<T>`, newer `string`/`Math` overloads, and net6+-only WinForms APIs behind existing `#if` blocks. Budget most of this phase's effort for net46/net47.
- net5.0-windows/net6.0/net7.0 reference packs must restore from NuGet — confirm early that `Microsoft.WindowsDesktop.App.Ref` for each old version restores in the environment.
- High-DPI behaviour differs meaningfully between .NET Framework and .NET 5+; do not "fix" differences by changing shared code paths without a per-TFM test.
- Extended Toolkit modules consume the core libraries via **NuGet `PackageReference` to `Krypton.*`** upstream. These must be rewired to `ProjectReference` (or references to our `Bastion.Krypton.*` builds) so the whole suite builds from one source tree against one core version — verify no module silently pins an older `Krypton.Toolkit` with breaking API differences.
- Extended Toolkit's release line has historically lagged the core (e.g. a 90.x Extended against a 105.x core). Building latest Extended source against latest core will surface real API breaks — fix them in the Extended tree and record each in `CHANGES.md`.

**Exit criteria:** all five core libraries compile warning-clean for all ten TFMs; every Extended module compiles warning-clean for all ten TFMs (or its documented, Chris-approved reduced set); API matrix report generated covering core and Extended; smoke instantiation passes per TFM.

---

## 4. Phase 3 — Themes: every Office version plus Microsoft 365, as faithful as possible

**Goal:** a complete, faithful palette set covering Office 2003, 2007, 2010, 2013, 2016, 2019, 2021, 2024 and current Microsoft 365, each in its genuine variant set.

### 4.1 Audit what exists

Enumerate every `PaletteMode` / palette class in the baseline (upstream ships Office 2007, 2010, 2013, Microsoft 365, Sparkle, Professional, Visual Studio variants — confirm the exact list and variants: Blue, Silver, White, Black, Dark/Light mode versions). Output `docs/audit/THEME-AUDIT.md` listing each palette, its variants, and known fidelity issues (search upstream issues for palette bug reports — link them).

### 4.2 Gap list (expected, verify in audit)

- **Office 2003** — present in the original Component Factory suite ("Professional - Office 2003"); verify it survived into Standard-Toolkit and restore/refresh if degraded.
- **Office 2016 and 2019** — the "Colorful" era look (coloured title bars per app, flat white/grey/dark-grey/black variants). Upstream folds this era into "Microsoft 365"; this project ships **distinct** Office 2016 and Office 2019 palettes.
- **Office 2021 / 2024** — the rounded-corner Fluent-influenced refresh (soft greys, subtle shadows, segoe UI Variable where available).
- **Microsoft 365 current** — refresh against the *current 2026* M365 desktop visuals, including proper Dark Mode and the White/Colorful/Dark Gray/Black office theme options.

### 4.3 Fidelity method (this is a deep-dive, not a colour guess)

1. For each target Office version, gather reference material: official Microsoft UI documentation/Fluent guidance where it exists, and high-quality screenshots of the real applications (title bar, ribbon, backstage, context menus, scrollbars, status bar, hover/pressed/disabled states).
2. Extract exact colours programmatically from reference screenshots (eyedropper script over PNG references) — build a named colour table per theme in `docs/themes/<theme>-colours.md`. Cite the source of every reference image.
3. Implement each palette as a `PaletteBase`-derived class following the existing upstream palette structure (do not invent a new palette architecture). Every `PaletteMode` enum addition must flow through the palette factory, designer enum converters, and theme-switching helpers — **including the Extended Toolkit's Theme Switcher module (and Palette Selectors, if shipped)**, which enumerate themes and must list every new palette.
4. **Faithfulness acceptance test:** for each theme, render the theme-browser test app (Phase 6) beside the reference screenshots and produce a side-by-side comparison image per theme in `docs/themes/comparisons/`. Chris signs off fidelity per theme; iterate until sign-off.
5. All themes must work on **all ten TFMs** — palette code is pure GDI+/WinForms and must not use net8+-only APIs without a down-level path.
6. Theme switching at runtime (every theme → every other theme, live, with open forms) is a mandatory stress test — see Phase 6.

**Exit criteria:** theme audit + colour tables + comparison images done; all palettes selectable in designer and at runtime on all TFMs; no rendering exceptions in the theme sweep.

---

## 5. Phase 4 — Samples: originals plus dual-language parity

**Goal:** every sample runs against **any** of the ten TFM builds, in both C# and VB.NET.

1. Collect the sample set: all original Component Factory Ultimate samples (from the 2017 repo) **plus** the current Standard-Toolkit-Demos **plus** the Extended Toolkit's demo/example projects (in-repo demos and any in companion repos — inventory in Phase 1). Every Extended module without an upstream demo gets a minimal purpose-written sample so that no shipped component is undemonstrated. De-duplicate: where a demo evolved, the modern one wins; the original is kept only if it demonstrates something the modern set lost.
2. **Multi-target every sample project** with the same ten-TFM matrix, referencing the libraries by `ProjectReference` in the source tree. Add a solution-level switch (`Directory.Build.props` property, e.g. `/p:SampleTfm=net6.0-windows`) plus a `run-sample.ps1` that builds and launches any sample on any TFM — this is what "use any build library and work" means operationally.
3. **VB.NET parity:** every C# sample gets a VB.NET twin (`Samples/CSharp/...`, `Samples/VisualBasic/...`), hand-ported (no mechanical converter output left unreviewed — converter output is acceptable as a starting point only). VB samples must be idiomatic VB.NET (WithEvents/Handles for events, My namespace where natural).
4. Samples must use **designer-generated forms** (real `.Designer.cs`/`.Designer.vb` + `InitializeComponent`), not just code-built UI, because designer serialisation of Krypton controls is itself a thing being tested.
5. Every sample must compile warning-clean and run to an idle message loop on every TFM. A scripted matrix run (sample × TFM) with pass/fail lands in `docs/audit/SAMPLE-MATRIX.md`. Samples that legitimately can't support a TFM (documented feature degradation from Phase 2) are marked N/A with the reason.

**Exit criteria:** sample matrix green (or documented N/A); C#/VB parity 100%; `run-sample.ps1` works.

---

## 6. Phase 5 — Testing suite: build it, then try to break the controls

**Goal:** a permanent test suite plus an adversarial deep-dive. This is not a checkbox phase — it is expected to find real bugs, and found bugs get fixed (or filed with full repro if fixing risks destabilising the release, at Chris's call).

### 6.1 Structure

- `Tests/Bastion.Krypton.UnitTests` — xUnit or NUnit (pick one, record why), multi-targeted across the full matrix. Runs headless where possible; WinForms tests run STA with a message pump helper.
- `Tests/Bastion.Krypton.FormsTests` — **test sample applications where every control is placed on real forms** (explicit user requirement): one generated test app per component family — **the five core families and every Extended Toolkit module** — that drops every public control onto forms via designer-style `InitializeComponent` code, shows the form, pumps messages, resizes, theme-switches, and disposes. Both a C# and a VB.NET variant of the harness exist (compiling the VB designer path matters).
- `Tests/Bastion.Krypton.StressTests` — the adversarial suite (6.3).
- Screenshot capture on failure, artefacts saved per run.

### 6.2 Functional coverage (per control, per TFM)

Instantiate → place on form → show → verify default render (no exception, non-empty paint) → set every public property to typical values → fire public methods with valid inputs → dispose → assert no leaked handles (GDI/User handle counts before/after) and no finalizer-thread exceptions.

### 6.3 Adversarial deep-dive — actively try to break the controls

For every control, systematically attack:

1. **Extreme property values:** `int.MaxValue`/`MinValue` sizes, negative padding, zero-size forms, absurd font sizes (1pt, 500pt), empty and 1MB strings, strings with RTL text, surrogate pairs, control characters, `\0`.
2. **Null and disposal abuse:** null palettes, null images, setting properties after `Dispose()`, disposing mid-paint, double-dispose, using controls whose parent form is disposed.
3. **Theme-switch storm:** switch through every palette on a form containing every control, 100 cycles, while resizing — watch for paint exceptions, handle leaks, memory growth (fail the test if working set grows unbounded across GC.Collect cycles).
4. **Threading misuse:** property sets from a non-UI thread (expect and assert the correct `InvokeRequired`/exception behaviour — the *documented* behaviour, not a crash or deadlock).
5. **DPI and display torture:** run key render tests at 96/120/144/192 DPI (PerMonitorV2 on net5+; DPI-aware manifests on Framework); RTL layout (`RightToLeft = Yes` + `RightToLeftLayout`); 8-bit/high-contrast system themes.
6. **Ribbon/Docking specific:** hundreds of ribbon tabs/groups, deeply nested docking layouts, save/load of docking + workspace layout XML round-trips (including deliberately corrupted XML — must fail gracefully, not crash), drag-drop docking automation.
7. **Extended-module specific:** Outlook Grid / Data Grid Views / Tree Grid View with 100k+ rows, grouping/sorting churn and live data mutation during paint; Fast Coloured TextBox with multi-megabyte documents, pathological regex highlighting and rapid programmatic edits; Wizard navigation abuse (skip/back/dispose mid-transition); Notifications/Toast spam (hundreds queued, dismissed during animation); Calendar with extreme date ranges and culture switches (RTL calendars, non-Gregorian cultures).
8. **Serialisation:** designer serialisation round-trip — generate a form with every control, run the designer serialiser (CodeDom), recompile the output, verify identical state.
9. **Rapid create/destroy:** 10,000 create/show/dispose cycles per control family, asserting stable handle counts.

Every crash/exception found is logged in `docs/audit/BREAKAGE-LOG.md` with repro, root cause, fix commit (or upstream issue link if pre-existing upstream and deferred). Pre-existing upstream bugs found here are a valuable by-product — record them separately so Chris can decide whether to contribute fixes upstream.

### 6.4 Matrix execution

Full functional suite on every TFM. Adversarial suite at minimum on `net46`, `net48`, `net8.0-windows`, `net10.0-windows` (oldest, Framework mainline, LTS pair); full-matrix if runtime cost allows. Record run times and pass rates in `docs/audit/TEST-MATRIX.md`.

**Exit criteria:** functional suite green on all TFMs; adversarial suite run with all findings triaged; breakage log complete.

---

## 7. Phase 6 — Documentation

### 7.1 README of all changes (explicit user requirement)

`CHANGES.md` at repo root — the definitive record, written for a developer picking up the fork:

- Baseline: upstream repo, tag/SHA, version, date.
- Every category of change with specifics: TFMs added (and the polyfill/`#if` strategy per gap), themes added/refreshed (with fidelity sources), samples ported (counts, C#/VB), bugs found and fixed (from the breakage log), features degraded per TFM, anything intentionally not done.
- Per-TFM feature matrix table.
- Attribution and licence section (BSD-3 obligations, Component Factory + Krypton Suite credit).
- Support-status warning for EOL frameworks.

Main `README.md` is the public-facing repo front page: what this fork is, why it exists, install (NuGet), quick start in C# and VB, theme gallery (comparison images), relationship to upstream, licence.

### 7.2 API help — three formats

1. **DocFX site:** generated from XML doc comments + conceptual articles (getting started, theming guide, per-component guides — core families **and every Extended module**, migration-from-upstream note). API reference covers core and Extended assemblies alike. Buildable with one script; output ready for GitHub Pages (`docs-site/`). Fix or write missing XML doc comments on all public members touched by this project; inherit upstream docs where sound.
2. **CHM:** Sandcastle Help File Builder project producing `BastionKryptonSuite.chm` from the same XML comments; verify TOC, index and working links. CHM ships in the installer.
3. **PDF manual:** developer guide (conceptual chapters + key API tables — not the full 10,000-member reference dump) rendered to `BastionKryptonSuite-Manual.pdf`. Toolchain at Claude Code's discretion; must be scripted/repeatable.

**Exit criteria:** all three outputs build from a clean clone via `build-docs.ps1`; no broken links (link-check the DocFX output); XML doc coverage report for public members included in the audit folder.

---

## 8. Phase 7 — Packaging: NuGet and Inno Setup installer

### 8.1 NuGet packages

- One package per library: `Bastion.Krypton.Toolkit`, `Bastion.Krypton.Ribbon`, `Bastion.Krypton.Navigator`, `Bastion.Krypton.Workspace`, `Bastion.Krypton.Docking`, **plus one `Bastion.Krypton.Extended.<Module>` package per Extended Toolkit module** (mirroring upstream's per-module packaging, with the `Krypton.Toolkit.Suite.Extended.` prefix replaced), **plus two metapackages: `Bastion.Krypton.Suite` (the five core libraries) and `Bastion.Krypton.Extended.Ultimate` (all Extended modules)**. Inter-package dependencies mirror project references; Extended packages depend on the `Bastion.Krypton.*` core packages, never on upstream `Krypton.*`.
- Extended package licence metadata is SPDX `MIT` (with Krypton Suite attribution); core packages remain `BSD-3-Clause`. Do not blend the two in one package.
- Each package multi-targets the full ten-TFM matrix (lib folders per TFM), with correct per-TFM dependency groups (compat packages only on old TFMs).
- Namespaces/type names unchanged (ground rule 3); assembly names prefixed `Bastion.` to avoid GAC/bind collisions with upstream `Krypton.*` assemblies — **verify designer and `licenses.licx`-style implications of the assembly rename and document them**. If the rename breaks designer toolbox registration, escalate to Chris with options before proceeding.
- Package metadata: SPDX `BSD-3-Clause`, authors/company Bastion Software Solutions Ltd, attribution to Component Factory Pty Ltd and the Krypton Suite team in the description, readme embedded, icon, SourceLink + snupkg symbols, deterministic builds, repository URL.
- Version scheme: recommend `<upstreamMajor>.<yyyy>.<Mdd>.<rev>`-style alignment with upstream (they use e.g. 105.26.4.110) **or** clean SemVer starting 1.0.0 — present both to Chris at packaging time; default SemVer 1.0.0 with upstream baseline noted in release notes.
- `dotnet pack` from a `pack.ps1`; validate each nupkg with `dotnet validate package` / NuGet Package Explorer CLI checks; test-consume each package from a scratch project per TFM before declaring done. Confirm `Bastion.Krypton.*` IDs are unclaimed on nuget.org at execution time.
- Chris does the actual `nuget push` (API key stays with him).

### 8.2 Inno Setup installer

`Bastion Krypton Suite <version> Setup.exe` installing, per-user by default:

- Compiled assemblies (all TFMs, folder per TFM), XML doc files, PDBs.
- Samples (both languages, source), pre-built sample binaries optional component.
- CHM + PDF docs; Start Menu shortcuts (docs, theme browser app, uninstall).
- A "Designer integration" readme (how to add controls to the VS toolbox for Framework and .NET projects — verified instructions, not assumed).
- Standard requirements: LICENSE display (BSD-3 + attribution), version-stamped, upgrade-in-place (same AppId GUID), silent-install support (`/VERYSILENT`), uninstaller clean (no orphan files/registry). Test install → use → upgrade → uninstall on a clean Windows VM or sandbox.
- Unsigned initially; script leaves a signtool hook for when Chris has a code-signing cert (flag: unsigned installers trip SmartScreen — note in README).

**Exit criteria:** packages validated and locally consumable per TFM; installer tested through the full lifecycle.

---

## 9. Phase 8 — GitHub publishing preparation

- Repo layout ready to push public: `Source/`, `Samples/`, `Tests/`, `docs/`, `Installer/`, `Scripts/`, LICENSE (BSD-3 with both upstream copyrights + Bastion additions), `CHANGES.md`, `README.md`, `CONTRIBUTING.md` (brief), `.gitignore`, `.editorconfig`.
- GitHub Actions workflow (`build.yml`): windows-latest, restore/build full matrix, run functional tests, pack NuGet artefacts, build DocFX. CHM/installer jobs may need self-hosted/manual steps — document what CI can't do.
- Release checklist doc for Chris: tag, GitHub Release with installer + nupkgs + notes, `nuget push` commands, GitHub Pages enablement for docs.
- Nothing is pushed by Claude Code without Chris's say-so; everything is staged locally, push-ready.

**Exit criteria:** clean clone → `build-all.ps1` → full artefact set reproduces end-to-end.

---

## 10. Master acceptance checklist

1. Baseline = newest upstream stable at execution time, verified against NuGet.
2. Ultimate Edition parity audit complete; every original component present or its absence justified in writing.
3. All five core libraries compile warning-clean on net46, net47, net48, net481, net5.0–net10.0-windows; every Extended Toolkit module compiles warning-clean on the same matrix or a documented, Chris-approved reduced set; `EXTENDED-INVENTORY.md` and `THIRD-PARTY-LICENCES.md` complete, with every "Under Development" module given a go/no-go decision.
4. API matrix across TFMs matches documented degradations exactly.
5. Themes: Office 2003, 2007, 2010, 2013, 2016, 2019, 2021/2024 and current Microsoft 365 (all variants incl. dark modes), each with colour-table provenance and side-by-side fidelity images signed off by Chris.
6. Every sample: C# + VB.NET, designer-generated forms, runs on any TFM via `run-sample.ps1`; matrix documented.
7. Test suite: functional green on all TFMs; adversarial suite executed; `BREAKAGE-LOG.md` fully triaged.
8. `CHANGES.md` complete and accurate; README public-ready.
9. DocFX site + CHM + PDF all build from script.
10. NuGet packages validated and scratch-consumed per TFM; installer lifecycle-tested.
11. BSD-3 attribution intact everywhere (core/original trees), MIT notice intact everywhere (Extended tree); no `Krypton.*` or `Krypton.Toolkit.Suite.Extended.*` package-ID or assembly-name collisions.
12. `BUILD-LOG.md` records every phase, every deferred item, every deviation from this spec.

## 11. Known risks (accepted or watched)

| Risk | Position |
|---|---|
| net46 port may hit APIs with no viable polyfill in core paint paths | Escalate with options rather than degrade silently |
| .NET 5/6/7 designer support in VS is effectively absent | Runtime support is the commitment; documented |
| VS2019 on Chris's setup can't open net6+ projects | Use VS2022 / dotnet CLI; flagged in §1 |
| Upstream moves (v110 line visible in template releases) | Baseline re-check is Phase 1 step 3; merging later upstream releases is a future task, note the strategy in CHANGES.md |
| "Krypton" trademark/goodwill | Product name "Bastion Krypton Suite" states derivation honestly; no endorsement implied; BSD-3 permits redistribution |
| EOL runtimes carry unpatched security risk for consumers | Stated prominently in README/package notes |
| Unsigned installer SmartScreen warnings | Signtool hook left ready; Chris to obtain cert if desired |
| Extended Toolkit scale (~40 modules × 10 TFMs) roughly triples build/test surface | Accepted with the v1.1 scope decision; dependency-ordered builds, matrix reports per module, and reduced-TFM escape hatch (Chris-approved) keep it tractable |
| Extended modules embedding third-party code under other licences (e.g. FastColoredTextBox lineage) | Third-party licence sub-audit in ground rule 2; incompatible modules escalated before packaging, never silently shipped |
| "Under Development" Extended modules may not build or may be unsound | Build-attempt + smoke test gate in Phase 1 step 5; go/no-go per module recorded and escalated to Chris |
| Extended source lags core API (release lines historically diverge) | Fix-forward in the Extended tree against latest core; every API-break fix recorded in CHANGES.md |

## 12. References

- Standard Toolkit repo: https://github.com/Krypton-Suite/Standard-Toolkit
- Releases: https://github.com/Krypton-Suite/Standard-Toolkit/releases
- NuGet baseline: https://www.nuget.org/packages/Krypton.Toolkit
- Extended Toolkit repo: https://github.com/Krypton-Suite/Extended-Toolkit (MIT)
- Original source: https://github.com/ComponentFactory/Krypton
- Demos: https://github.com/Krypton-Suite/Standard-Toolkit-Demos
- Upstream docs: https://github.com/Krypton-Suite/Documentation / https://krypton-suite.github.io/Standard-Toolkit-Online-Help/

---
*Spec prepared for Bastion Software Solutions Ltd. Derivative-work licence: BSD-3-Clause obligations apply to all Krypton-derived code.*
