# Bastion Krypton Suite — Change Record

The definitive record of what this fork changes relative to its upstream baseline, written
for a developer picking up the work. It is generated from, and cross-references, the audit
trail under [`docs/audit/`](docs/audit/) and [`docs/themes/`](docs/themes/), and the
phase-by-phase [`BUILD-LOG.md`](BUILD-LOG.md).

UK English throughout. Every number below is cited from the audit files; where the audit
trail is internally inconsistent this document says so rather than papering over it (see
[§10, Discrepancies](#10-discrepancies-found-while-cross-referencing)).

---

## 1. Baseline

Bastion Krypton Suite is a multi-targeted fork of the actively maintained **Krypton-Suite**
Standard Toolkit and Extended Toolkit, cross-checked for completeness against the original
2017 Component Factory open-sourcing. Namespaces and public type names are **unchanged** —
only assembly names and NuGet package IDs gain the `Bastion.` prefix (see
[§9, Attribution & licence](#9-attribution--licence)).

| Item | Value |
|---|---|
| Standard-Toolkit repo | [`Krypton-Suite/Standard-Toolkit`](https://github.com/Krypton-Suite/Standard-Toolkit) — BSD-3-Clause |
| Standard-Toolkit baseline | branch **`V105-LTS`**, tip **`57824ec4`** (15 July 2026); clone HEAD at acquisition `6bd821bf` |
| Standard-Toolkit NuGet reference | `Krypton.Toolkit` **105.26.4.110** (20 April 2026) |
| Extended-Toolkit repo | [`Krypton-Suite/Extended-Toolkit`](https://github.com/Krypton-Suite/Extended-Toolkit) — MIT (© 2017–2024 Krypton Suite) |
| Extended-Toolkit baseline | branch **`V105-LTS`**, tip **`2725d8c4`** (17 January 2026); clone HEAD at acquisition `3c670803` (29 November 2025) |
| Extended-Toolkit NuGet reference | `Krypton.Toolkit.Suite.Extended.Ultimate` **105.26.4.114** (24 April 2026) — the `2725d8c4` tip is the exact source of this build |
| Original completeness cross-check | [`ComponentFactory/Krypton`](https://github.com/ComponentFactory/Krypton) — frozen 2017 Ultimate source, ref `5a1e5b9`, BSD-3-Clause |
| Demo source | [`Krypton-Suite/Standard-Toolkit-Demos`](https://github.com/Krypton-Suite/Standard-Toolkit-Demos) — current master |
| Work branch (both trees) | `bastion/multitarget`, tracking `origin/V105-LTS` |

**On versioning and the choice of baseline.** Upstream does **not** tag stable releases;
versions are date-derived at build time (`<upstreamMajor>.<yy>.<M>.<dayOfYear>`, e.g.
`105.26.4.110`), and GitHub releases carry only Visual Studio templates. The serviced stable
line lives on the **`V105-LTS`** branch of both repositories (`master` is the unreleased
v110 development line). The V105-LTS tip is upstream's canonical, serviced stable line — a
superset of the shipped NuGet snapshot including post-release LTS bug fixes — and is not a
canary/alpha build. The exact 20-April-2026 release commit is not identifiable in the
upstream history (an upstream history-recovery incident on 6–7 June 2026 rewrote the branch
between the January and June commits), so the current serviced tip was taken as the baseline.
This is a recorded deviation from the spec's "release tag" wording; full detail in
[`BUILD-LOG.md`](BUILD-LOG.md) Phase 1.

**Baseline build verdicts (as shipped, unmodified).** The Standard Toolkit built clean
(0 warnings / 0 errors) across all six upstream TFMs. The Extended Toolkit does **not**
build fully as shipped under any local toolchain: 31 packages build under desktop MSBuild but
three code projects fail on pre-existing upstream defects (inconsistent per-project core
package pins mixing 95.x / 100.x / never-105.x, missing linked resources, and package
downgrades). These are fixed on `bastion/multitarget` in Phase 2 and recorded below.

---

## 2. Multi-targeting

Every core library and every Extended module now builds for **11 target frameworks**:

```
net46 ; net47 ; net472 ; net48 ; net481 ;
net5.0-windows ; net6.0-windows ; net7.0-windows ;
net8.0-windows ; net9.0-windows ; net10.0-windows
```

Upstream shipped six (`net472; net48; net481; net8.0-windows; net9.0-windows;
net10.0-windows`). Bastion adds **net46, net47, net5.0, net6.0, net7.0** as required by the
spec, and **retains net472** for upstream-diff friendliness (11 TFMs, one more than the
spec's ten — a recorded decision). `TreatWarningsAsErrors=true` is enforced suite-wide on the
core libraries.

The core five libraries (`Krypton.Toolkit`, `Krypton.Ribbon`, `Krypton.Navigator`,
`Krypton.Workspace`, `Krypton.Docking`) compile **warning-clean on all 11 TFMs**. Upstream's
v105 code proved largely down-level clean, so far fewer gaps surfaced than budgeted — almost
all of them on net46.

### 2.1 Per-gap strategy

Handled in the spec's order of preference — compiler shims first, compat packages second,
`#if` conditional compilation third, documented feature degradation only as a last resort.

| Gap | TFM(s) | Strategy | Ladder step |
|---|---|---|---|
| `System.Resources.Extensions` has no net46-compatible version (floor is net462) | net46 | net46 opts out of preserialized resources and compiles **classic** resx; the direct net462 `<Reference>` is excluded on net46 | (d) narrow degradation |
| `System.ValueTuple` types absent | net46 | `System.ValueTuple` 4.5.0 package, net46-only condition | (b) compat package |
| `System.Memory` required at runtime | net46 | flows as a net46-only package dependency | (b) compat package |
| `Control.DeviceDpi` absent (added net462) | net46 | `General\Net46Compat.cs`: a C# extension property on `Control` supplying system DPI via GDI; six bare `DeviceDpi` uses qualified with `this.` — identical semantics on every TFM | (a) shim |
| `DpiChangedEventArgs` / `DpiChanged` absent (added net47) | net46 | `#if NET47_OR_GREATER \|\| !NETFRAMEWORK` (corrects upstream's stale `#if !NET462`). **Documented degradation: net46 does not track per-monitor DPI changes** — a platform limitation of 4.6 | (c)/(d) |
| `MemoryExtensions.Count` mis-guarded as `NET5_0_OR_GREATER` (the API is .NET 8+) | net5/6/7 | corrected to `#if NET8_0_OR_GREATER`; the existing manual loop covers 5/6/7. **Genuine upstream bug**, invisible upstream because they skip 5/6/7 | (c) |
| `ClassInterfaceType.AutoDispatch` obsolete warnings | net5/6 | upstream pragma guard widened NET8+ → NET5+ | (c) |
| `[AllowNull]` on `KryptonForm.Font` over-guarded | net5/6/7 | guard widened to `NET5_0_OR_GREATER` (base annotation exists on all .NET Core TFMs) | (c) |
| `ISite.Container` annotated non-nullable in net5 ref assemblies | net5 | two design-time stub sites return `null!` (container legitimately absent) | (c) |
| Codeless "package doesn't support net5/6/7" advisory (System.Resources.Extensions `buildTransitive`) | net5/6/7 | `SuppressTfmSupportBuildWarnings=true` on those three TFMs only — the netstandard2.0 asset is used and sufficient; the advisory has no warning code so per-code `NoWarn` is impossible | documented suppression |

### 2.2 The honest net46 notes

net46 is the most constrained target and consumers should understand exactly what it costs:

- **Classic resources / desktop-MSBuild only.** net46 cannot use preserialized resources
  (`System.Resources.Extensions` floors at net462), so net46 compiles classic resx. As a
  consequence **the net46 leg builds under desktop MSBuild, not `dotnet build`.** Every other
  TFM builds under either toolchain.
- **Compat package dependencies.** net46 pulls `System.ValueTuple` (4.5.0) and `System.Memory`
  as package dependencies; these must flow through to consumers. `System.Resources.Extensions`
  is deliberately **absent** on net46 (it is a dependency on net47–net481).
- **DPI.** `Control.DeviceDpi` is supplied by a GDI-based shim (`Net46Compat.cs`), so DPI
  queries work. **Per-monitor DPI change tracking does not** — `DpiChanged`/
  `DpiChangedEventArgs` did not exist until net47, and per-monitor DPI is not a capability of
  .NET Framework 4.6 in any case.

### 2.3 Extended Toolkit rewiring

Extended modules consumed the core libraries via NuGet `PackageReference` to `Krypton.*`,
pinned **per project and inconsistently** (mixtures of 95.x / 100.x, never 105.x, plus stray
backup csprojs pinning versions as old as 65.x). Phase 2:

- centralised the 11-TFM matrix in Extended's `Directory.Build.props`, normalising the
  `-windows7.0` suffixes;
- rewired 14 NuGet-only core consumers to dual-mode `ProjectReference` against the single
  Bastion core source tree;
- ported the core resource rules (`EmbeddedResourceUseDependentUponConvention=true` for
  identical manifest names on every TFM);
- fixed the three baseline-breaking projects (Themes package downgrades + `CustomPaletteBase`
  double-base, Software.Updater, PackageId collisions);
- deleted four stale backup csprojs and conditioned 20 net46-incompatible third-party
  `PackageReference`s out of net46 only.

**Result: 63 of 64 Extended projects build all 11 TFMs** (Data.Visualisation builds 10 by
design; the `Themes` module is deliberately unscheduled pending Chris's go/no-go — see
[§8](#8-intentionally-not-done)). Warning-clean enforcement on the Extended tree is deferred
(baseline ≈ 29k nullable-reference-type warnings — tracked, not blocking).

### 2.4 API-matrix verification

A metadata-only reflection sweep (`Scripts/ApiMatrix`, report
[`docs/audit/API-MATRIX.md`](docs/audit/API-MATRIX.md)) compares the public/protected surface
across all 11 TFMs. Ribbon, Navigator and Workspace are **identical across every TFM** (0
differences). Toolkit shows **18** differing signatures and Docking **2** — every one a
deliberate platform-floor gate matching a documented degradation in the
[per-TFM feature matrix](#6-per-tfm-feature-matrix). Several gates were **widened from
upstream's blanket net8 gate to the API's true floor** (verified against the actual
`Microsoft.WindowsDesktop.App.Ref` packs) — see the matrix notes.

---

## 3. Themes

### 3.1 What was added

**14 new selectable `PaletteMode` values**, wired end-to-end (enum, display strings,
class/type converters, palette factory, image-set resolver, OS-icon buckets, all 105
integrated-toolbar command switches, and the Extended Theme Switcher):

| Family | New modes | Count |
|---|---|---|
| Office 2003 (Luna) | `Office2003Olive`, `Office2003Silver` | 2 |
| Office 2016 (Colorful era) | `Office2016Colorful`, `Office2016White`, `Office2016DarkGray` | 3 |
| Office 2019 (Colorful era incl. Black) | `Office2019Colorful`, `Office2019White`, `Office2019DarkGray`, `Office2019Black` | 4 |
| Office 2021/2024 (Fluent refresh) | `Office2021Colorful`, `Office2021White`, `Office2021DarkGray`, `Office2021Black` | 4 |
| Microsoft 365 | `Microsoft365DarkGray` (formerly an unwired upstream TODO) | 1 |
| **Total** | | **14** |

Office 2003 already survived into upstream as `ProfessionalOffice2003` (blue), so the gap was
a **refresh**, not a restore — the two new Luna variants are Olive and Silver. Upstream folds
the 2016/2019 "Colorful" era into Microsoft 365; Bastion ships them as **distinct** palettes.

### 3.2 Microsoft 365 2026 refresh

The existing Microsoft 365 palettes were **re-coloured to the genuine current (2026) M365
desktop visuals** (mapping Blue→Colorful, White→White, DarkGray→Dark Gray, Black→Black/Dark
Mode; dark/light companions derived coherently). This **intentionally changes the previous
M365 look**; before/after captures are preserved as
`docs/themes/comparisons/placeholder/` (before) vs `docs/themes/comparisons/m365-2026/`
(after).

### 3.3 Fidelity provenance

Colours were not guessed. Each theme has a named colour table under
[`docs/themes/`](docs/themes/) (`office2003-colours.md`, `office2016-colours.md`,
`office2019-colours.md`, `office2021-colours.md`, `m365-2026-colours.md`), and every value
carries a provenance tag:

- **[T]** — sampled from a cited reference image or an official source table;
- **[D]** — derived from a [T] value by a documented rule;
- **[N]** — donor-neutral (carried from an existing coherent palette).

References are enumerated with source URLs in
[`docs/themes/references/SOURCES.md`](docs/themes/references/SOURCES.md): 35 cited images
(official Microsoft support/Learn crops recovered via the Wayback Machine where the Office CDN
now 404s, plus lossless Wikipedia application composites), and Microsoft's own WinForms
`ProfessionalColorTable` source (the `InitBlueLunaColors`/`InitOliveLunaColors`/
`InitSilverLunaColors` tables) for Office 2003. Fidelity comparison images for every mode live
in `docs/themes/comparisons/{office2016-2019, office2021-2003, m365-2026}/`.

> **Fidelity sign-off is still pending Chris** — the comparison images are produced but not
> yet accepted per theme. See [§11](#11-open-items-needing-chriss-input).

### 3.4 Two upstream theme defects fixed

- **T1** — nine palette modes (four Material, four VisualStudio2010Render, and
  `Microsoft365BlackDarkModeAlternate`) were missing from all 105 duplicated
  `switch(PaletteMode)` statements across 16 command files, so selecting any of them with an
  integrated-toolbar command active threw `ArgumentOutOfRangeException` at runtime. Fixed via a
  consolidated `PaletteImageSetResolver`.
- **T2** — `ProfessionalOffice2003` only applied Luna colours when `OSVersion.Major < 6`, so on
  Windows 10/11 it silently rendered as the system professional palette. Un-gated (Luna Blue
  now unconditional).

The full theme wiring map (15 core wiring points across 22 files, plus the five independent
hard-coded Extended theme lists) is documented in
[`docs/audit/THEME-AUDIT.md`](docs/audit/THEME-AUDIT.md).

---

## 4. Samples

100% dual-language parity, from a VB baseline of **zero**.

| Deliverable | Result |
|---|---|
| C# demos multi-targeted | **125** projects × 11 TFMs = **1,375 builds, 0 errors, 0 exclusions** |
| VB.NET twins | **125** idiomatic hand-ported twins (real `.Designer.vb`, `Friend WithEvents`/`Handles`, `My.Resources`); consolidated build 0 errors / 0 warnings |
| New Extended example forms | **16** designer-generated forms covering 17 modules, plus 6 orphaned forms registered; permanent `--smoke` hook, 46/46 forms pass |
| Sample × TFM launch matrix | **2,750 launches (250 apps × 11 TFMs): all green** on true runtimes |

Every sample uses designer-generated forms (so Krypton designer serialisation is itself under
test), builds warning-clean, and reaches an idle message loop on every TFM. A
`Directory.Build.props` `/p:SampleTfm=<tfm>` switch and `run-sample.ps1` build and launch any
sample on any TFM. Full detail:
[`docs/audit/SAMPLE-INVENTORY.md`](docs/audit/SAMPLE-INVENTORY.md) and
[`docs/audit/SAMPLE-MATRIX.md`](docs/audit/SAMPLE-MATRIX.md).

Sample defects found and fixed along the way include a Ribbon demo startup crash (designer-lost
`ButtonSpec` wiring, restored against the 2017 source), two projects orphaned from every
solution, and a VB-specific class: `Handles` binds at `WithEvents` field assignment and so
fires handlers **during** `InitializeComponent`, before dependent controls exist (five twins
guarded; a repo-wide sweep found no further live instances).

---

## 5. Bugs found and fixed

The testing effort was expected to find real bugs, and did. Everything below is **pre-existing
upstream** (tagged `[UPSTREAM]` in the breakage log) and is a candidate for contribution back
to Krypton-Suite. Full repro, root cause and fix commit for each is in
[`docs/audit/BREAKAGE-LOG.md`](docs/audit/BREAKAGE-LOG.md).

### 5.1 Fixed defect classes

| Group | Where found | IDs | Count | Representative examples |
|---|---|---|---|---|
| Dispose-time NREs & wrong API guards (core) | Phase 2 smoke | items 1–5 | **6** | `KryptonComboBox` + five list/tree/grid controls NRE from focus events fired inside `DestroyWindow` during `Dispose`; the `MdiChildrenMinimizedAnchorBottom` setter that **always threw** on runtimes where it works; the `MemoryExtensions.Count` mis-guard |
| Extended-module smoke defects | Phase 2 smoke | E1–E23 | **23** | an inverted fade-out loop that **hung every fading form on close**; a zero-speed fade recursion hanging forms on Show; a null-owner NRE in the **core** `PaletteFormBorder`; a `ColourCollection` `==` operator StackOverflow that killed the whole process; the .NET 9 `SystemColors.UseAlternativeColorSet` reflection break; a `Nullable<uint>` P/Invoke; ten controls leaking `GlobalPaletteChanged` subscriptions |
| Theme wiring (core + Extended) | Phase 3 audit | T1, T2 | **2** | nine modes missing from command switches (runtime AOOR); Office 2003 XP-gated |
| Functional sweep | Phase 5b | F1 | **1** | `KryptonToggleSwitch`'s four `IContentValues` members all threw `NotImplementedException` |
| Adversarial suite | Phase 5c | A1–A8 | **8** | see below |

The eight adversarial fixes (three of them **process-killing** crashes):

- **A1** — `KryptonCalendar` extreme view-range corrupts state; the next paint NREs and takes
  down the process. Made the range update transactional.
- **A2** — `KryptonMonthCalendar` at `int.MaxValue` size hangs the UI thread building millions
  of month views (plus Int32 overflow). Clamped to the documented ≤12-month contract.
- **A3** — `KryptonTableLayoutPanel` extreme size crashes from `WM_WINDOWPOSCHANGED` via a
  negative-size `Bitmap`, plus a per-resize GDI snapshot leak. Guarded and disposed.
- **A4** — `KryptonForm`/`ShadowManager` leaks 4 USER handles per show→dispose lifecycle (a
  long-lived process eventually hits the 10,000-handle limit and dies). Tear the shadow windows
  down on `Disposed`, not only `Closing`.
- **A5** — `KryptonToastNotificationPopup.Dispose` silently no-ops during the appear animation,
  leaking a palette-subscribed window. Dispose now disposes synchronously.
- **A6** — `VisualForm.InvalidateNonClient` throws GDI+ `OutOfMemoryException` on a dead HWND
  and crashes theme changes. Made best-effort.
- **A7** — `VisualPanel` disposed from inside its own `Paint` handler crashes out of `WM_PAINT`.
  Re-validates disposal after `base.OnPaint`.
- **A8** — `SaveLayoutToArray` / `SaveConfigToArray` / palette `Export` returned
  `MemoryStream.GetBuffer()`, shipping NUL-padded "XML" that any strict `XmlReader` consumer
  rejects. Changed to `ms.ToArray()` at all three sites.

### 5.2 Headline count and the honest caveat

Grouping the above gives roughly **40 distinct fixed upstream defect classes** (6 + 23 + 2 + 1
+ 8). Note that the Phase 5 summary in [`BUILD-LOG.md`](BUILD-LOG.md) quotes a headline of
**"~24"** by counting the Extended-module smoke findings as *E1–E9* rather than the full
*E1–E23* that the breakage log actually documents; the Phase 2 log itself records "23 distinct
upstream defects" for that sweep. This document uses the fuller, breakage-log-accurate figure.
See [§10](#10-discrepancies-found-while-cross-referencing).

### 5.3 OPEN items (deferred, documented for Chris)

Four findings are genuine but are design-judgement or upstream-facing calls not taken
unilaterally:

| ID | Component | Issue | Why open |
|---|---|---|---|
| **A9** | `KryptonToolkitPoweredByControl` | at `int.MaxValue` size the AutoSize wrap-label layout **completes but takes ~85–90 s** (bounded slowness, not a hang) | a real fix means clamping the wrap-measure constraint inside `KryptonWrapLabel` — a behavioural upstream change |
| **A10** | theme-switch storm (net48 only) | working set grows ~70 KB per global palette switch, unreclaimed by full GC; **net8 is clean** | attribution needs a memory-profiler/dump-diff session; not fixable by pattern-matching. The endurance assertion is deliberately left active as the detector |
| **F2** | `KryptonPage.PaletteMode` / `Palette` setters | throw `OperationCanceledException` (wrong type — the property is deliberately sealed to the owning Navigator, but `NotSupportedException` is the correct contract) | changing the thrown type or making the setters non-public is an upstream-facing design call |
| **F3** | Workspace `StarSize.Value` | throws `ArgumentNullException` for non-null malformed input | exception-type-only change, no behavioural urgency |

---

## 6. Per-TFM feature matrix

Rows are capabilities that genuinely vary by TFM; every row corresponds to a signature in
[`API-MATRIX.md`](docs/audit/API-MATRIX.md) or a documented Phase 2 degradation. `✓` = present
/ works; `✗` = absent / degraded; a note explains the mechanism.

| Capability | net46 | net47 | net472 | net48 | net481 | net5.0 | net6.0 | net7.0 | net8.0 | net9.0 | net10.0 |
|---|:--:|:--:|:--:|:--:|:--:|:--:|:--:|:--:|:--:|:--:|:--:|
| Per-monitor DPI change tracking (`DpiChanged`/`DpiChangedEventArgs`) | ✗ | ✓ | ✓ | ✓ | ✓ | ✓ | ✓ | ✓ | ✓ | ✓ | ✓ |
| `Control.DeviceDpi` (DPI query) | ✓¹ | ✓ | ✓ | ✓ | ✓ | ✓ | ✓ | ✓ | ✓ | ✓ | ✓ |
| `Application.SetHighDpiMode` (per-app high-DPI opt-in) | ✗ | ✗ | ✗ | ✗ | ✗ | ✓ | ✓ | ✓ | ✓ | ✓ | ✓ |
| Preserialized resources (`System.Resources.Extensions`) | ✗² | ✓ | ✓ | ✓ | ✓ | ✓³ | ✓³ | ✓³ | ✓ | ✓ | ✓ |
| Shell dialog `ClientGuid` (Open/Save/FolderBrowser) | ✗ | ✗ | ✗ | ✗ | ✗ | ✓ | ✓ | ✓ | ✓ | ✓ | ✓ |
| `KryptonSaveFileDialog.CheckWriteAccess` | ✗ | ✗ | ✗ | ✗ | ✗ | ✗ | ✗ | ✓ | ✓ | ✓ | ✓ |
| `KryptonFolderBrowserDialog.InitialDirectory` | ✓⁴ | ✓⁴ | ✓⁴ | ✓⁴ | ✓⁴ | ✓⁴ | ✓ | ✓ | ✓ | ✓ | ✓ |
| `VisualForm.MdiChildrenMinimizedAnchorBottom` | ✗ | ✗ | ✗ | ✗ | ✗ | ✗ | ✓ | ✓ | ✓ | ✓ | ✓ |
| Docking close hook | OnClosing | OnClosing | OnClosing | OnClosing | OnClosing | OnClosing | OnClosing | OnClosing | OnClosing | OnClosing | OnFormClosing⁵ |
| `System.ValueTuple` / `System.Memory` needed as package deps | ✓ (dep) | ✗ | ✗ | ✗ | ✗ | ✗ | ✗ | ✗ | ✗ | ✗ | ✗ |
| Builds under `dotnet build` | ✗⁶ | ✓ | ✓ | ✓ | ✓ | ✓ | ✓ | ✓ | ✓ | ✓ | ✓ |
| Builds under desktop MSBuild | ✓ | ✓ | ✓ | ✓ | ✓ | ✓ | ✓ | ✓ | ✓ | ✓ | ✓ |

**Notes**

1. net46 obtains `Control.DeviceDpi` via the `Net46Compat.cs` GDI shim; net462+ have it natively.
2. net46 compiles **classic** resx (the preserialized-resources package floors at net462); it
   therefore needs `System.Memory`/`System.ValueTuple` as runtime dependencies and **does not**
   ship `System.Resources.Extensions`.
3. On net5/6/7 the netstandard2.0 asset of `System.Resources.Extensions` is used and is
   functionally sufficient; a codeless SDK advisory about those TFMs is deliberately suppressed.
   On net8+ resources are provided by the framework.
4. `InitialDirectory` on the folder-browser dialog was made available on **every** TFM via a
   sub-net8 wrapper (a Bastion improvement over the upstream net6+ gate); the native property
   floors at net6.
5. net10 removed the obsolete `OnClosing` override; Docking uses `OnFormClosing` there
   (upstream's own `#if NET10_0_OR_GREATER` swap).
6. net46 requires desktop MSBuild because of classic-resource compilation; every other TFM
   builds under either toolchain.

### Extended Toolkit and WPF-dependent features

The Extended Toolkit builds on all 11 TFMs except where noted: **Data.Visualisation** builds 10
TFMs by design, and the **Software.Updater** module's WPF-dependent update UI is aligned
per-TFM (WPF references conditioned by TFM). The `Themes` module is intentionally unscheduled
(see [§8](#8-intentionally-not-done)). No Extended module drops a .NET Framework target.

---

## 7. Features degraded per TFM

Every degradation is a `#if`-gated compile-out with no silently broken member.

- **net46**
  - No per-monitor DPI **change** tracking (`DpiChanged`/`DpiChangedEventArgs` — a platform
    limitation of 4.6). DPI *query* works via the shim.
  - Classic resources only; **net46 builds under desktop MSBuild only**.
  - Carries `System.ValueTuple` + `System.Memory` package dependencies.
- **net46–net481 (all .NET Framework)**
  - No shell-dialog `ClientGuid` (Open/Save/FolderBrowser).
  - No `MdiChildrenMinimizedAnchorBottom`.
- **net5.0**
  - No `MdiChildrenMinimizedAnchorBottom` (floors at net6).
  - No `SaveFileDialog.CheckWriteAccess` (floors at net7).
- **net5.0 / net6.0**
  - No `SaveFileDialog.CheckWriteAccess`.
- **net10.0**
  - Docking uses `OnFormClosing` rather than the removed obsolete `OnClosing`.

---

## 8. Intentionally not done

Deferred or descoped deliberately, with the reason and a recommendation where one exists.

| Item | Status / reason |
|---|---|
| **`Themes` Extended module** | Unscheduled in the build pending Chris's go/no-go (minimal/parked upstream: package downgrades and a `CustomPaletteBase` double-base defect). Not a dependency of any other module. |
| **`Toggle.Switch` module** | **RESOLVED (17 July 2026) — removed from the suite** for the public release. The entire renderer family derived from Johnny J's CodeProject "ToggleSwitch Winforms Control" (CPOL — incompatible with plain-MIT redistribution). The project directory was deleted, its entries removed from both referencing solutions, and its `ProjectReference` removed from the Examples app and the Ultimate.Lite metapackage. Not a dependency of any other module. |
| **`SharpUpdate` half of `Software.Updater`** | **RESOLVED (17 July 2026) — removed from the suite.** Upstream declared **no licence at all**, which attribution cannot cure. The `Sharp Update\` source folder was deleted; the AutoUpdater.NET and NetSparkle update paths remain and cover the use case. No live code referenced the removed types. |
| **gGlowBox fragment** (`ImageBoxExtended.cs`) | **RESOLVED (17 July 2026) — clean-roomed for the public release.** The ~30 lines of glow/shadow GDI+ code inherited via Cyotek from a CPOL CodeProject article were replaced with an original implementation (concentric alpha-ramped rounded-rectangle strokes) written from the behavioural description alone, © Bastion Software Solutions Ltd 2026 (MIT); the CPOL credit comment was removed. Same public surface, so `ImageBoxExtended` consumers are unaffected. |
| **`Microsoft365LightGray`** | Remains an **unwired upstream stub** (no colour scheme, no 2026 counterpart). Not shipped as a selectable mode. |
| **Warning-clean Extended build** | Deferred. `TreatWarningsAsErrors` is not yet enabled on the Extended tree (≈29k pre-existing nullable-reference-type warnings — tracked, not blocking). The core five are warning-clean. |
| **Full CodeDom designer-serialisation round-trip** | Deferred. The achievable persistence round-trips (docking/workspace layout XML, palette export/import, corrupted-XML batteries) are implemented instead. |
| **True per-monitor-v2 DPI test coverage** | The adversarial DPI torture is in-process `Form.Scale`-ratio only; genuine PerMonitorV2 variation is a CI/manifest concern, documented in `Tests/README.md`. |
| **Smaller CPOL-derived fragments** | Five UAC-shield copies, an MRU manager, a ToolBox control, a progress-bar paint, a CheckBoxComboBox and a toast pop-up are inventoried as CPOL-risk and await the same policy decision as the gGlowBox fragment. See [`THIRD-PARTY-LICENCES.md`](docs/audit/THIRD-PARTY-LICENCES.md) §1.1. |
| **AdvancedWizard licence** | No declared upstream licence, but the author (Steve Bate) is credited in every header and the code has been openly forked for years. Low risk; a courtesy MIT-grant request is recommended before the first public release. |

---

## 9. Attribution & licence

**This is a dual-licence project. Core and Extended metadata must never be blended in one
package.**

| Tree | Licence | Copyright |
|---|---|---|
| Standard-Toolkit-derived core + original Component Factory code | **BSD-3-Clause** | © Component Factory Pty Ltd; © Krypton Suite; © Bastion Software Solutions Ltd (new files) |
| Extended-Toolkit-derived modules | **MIT** | © 2017–2024 Krypton Suite; © Bastion Software Solutions Ltd (new files) |

- **Namespaces and public type names are unchanged** — `Krypton.Toolkit` etc. stay as-is for
  drop-in compatibility. Only assembly names and package IDs gain the `Bastion.` prefix.
- **Copyright headers are inviolable.** No upstream copyright line was removed or altered
  anywhere in this work; the third-party audit restored stripped attribution via
  directory-level `LICENSE`/`THIRD-PARTY-NOTICES` files and per-module SPDX metadata only, with
  no `.cs` edits.
- New files added by Bastion carry a `© Bastion Software Solutions Ltd` header and a note of
  which licensed tree the work derives from.
- Product name "Bastion Krypton Suite" states derivation honestly; **no endorsement** by
  Component Factory or the Krypton Suite team is implied.

### 9.1 Ms-PL sub-modules

Two Extended modules are substantially **Microsoft Public License** code and must carry the
compound SPDX expression **`MIT AND MS-PL`** (both in the module package and in any metapackage
that physically bundles their DLLs):

- **Outlook.Grid** — © 2013–2021 JDH Software (Ms-PL), via Cocotteseb/Krypton-OutlookGrid.
- **AdvancedDataGridView** — ADGV / Zuby.AdvancedDataGridView lineage (Ms-PL).

Ms-PL is copyleft for the **source form** of the Ms-PL code only; consumers of the compiled
packages in closed-source applications are unaffected. Ms-PL is GPL-incompatible (worth an FAQ
line).

### 9.2 Third-party notices restored (all MIT unless stated)

ScottPlot 5 (© Scott Harden — 347 files), AutoUpdater.NET (© RBSoft), the vendored
System.Speech/SAPI reference source (© .NET Foundation — 338 files), Cyotek colour-picker
family (© Cyotek Ltd), Navi.Suite (Guifreaks, Jacob Mesu), CircularProgressBar (© Falahati),
NetSparkle (© Deadpikle), MarkdownSharp, and the Vega/Microcharts palette tables (BSD-3 / MIT)
bundled in ScottPlot. Full per-module provenance, the SPDX metadata fixes, and the escalations
are in [`docs/audit/THIRD-PARTY-LICENCES.md`](docs/audit/THIRD-PARTY-LICENCES.md).

> At packaging time (Phase 7) the `THIRD-PARTY-NOTICES.md` files must be embedded in the
> affected nupkgs, and the `MIT AND MS-PL` expressions carried through to the
> `Bastion.Krypton.Extended.*` definitions.

---

## 10. Discrepancies found while cross-referencing

Recorded honestly for the next developer and for Chris:

1. **Defect-count headline.** The Phase 5 summary in `BUILD-LOG.md` says "~24 genuine upstream
   defect classes" and lists the Extended smoke findings as **E1–E9**, but `BREAKAGE-LOG.md`
   documents **E1–E23** and the Phase 2 log records "23 distinct upstream defects" for the same
   sweep. The accurate grouped total is ≈40. This document uses the breakage-log figure and
   flags the summary.
2. **Duplicate `E9` in the breakage log.** `BREAKAGE-LOG.md` has **two** entries numbered `E9`
   (the `ColourEditorControl` `ISupportInitialize` cast and, later, the Software.Updater
   `System.Drawing.Common 10.0.0` pin). Both are real, distinct defects; the numbering should be
   corrected upstream in the log.
3. **`PaletteMode` count wording.** `BUILD-LOG.md` Phase 1 records "57 PaletteMode values";
   `THEME-AUDIT.md` reconciles this precisely (48 concrete + `Custom` + 8 disabled grey variants
   whose classes exist = 57, excluding `Global`). Not an error, but the two files count
   different things and should be read together.
4. **Extended baseline version-lag risk largely retired.** The spec anticipated the Extended
   line lagging the core (e.g. a 90.x Extended against a 105.x core); in fact both baselines sit
   on the 105 line four days apart (`105.26.4.110` / `105.26.4.114`). The remaining lag was in
   the *per-project pins inside* the Extended tree, not the release line — fixed in Phase 2.

---

## 11. Open items needing Chris's input

1. **Per-theme fidelity sign-off** from the comparison images
   (`docs/themes/comparisons/{office2016-2019, office2021-2003, m365-2026}/`), plus the
   live-install screenshots that would close the `[D]`-tagged derivation gaps (hover/pressed/
   disabled states, backstage, context menus, inactive title bars).
2. **Licence escalations** (before any redistribution): **the three headline items are now
   resolved (17 July 2026)** — the gGlowBox CPOL fragment was clean-roomed, and the Toggle.Switch
   CPOL module and the SharpUpdate (no-licence) code were removed from the suite. Still open: the
   §1.1 CPOL-fragment inventory policy, and a courtesy MIT-grant request for AdvancedWizard.
3. **`Themes` Extended module** go/no-go.
4. **Package version scheme** (decided at Phase 7 packaging): clean SemVer starting `1.0.0`
   (the default, with the upstream baseline in the release notes) **or** upstream-aligned
   `<upstreamMajor>.<yyyy>.<Mdd>.<rev>`.
5. Decision items carried from Phase 1: port `KryptonRichTextBox` ButtonSpecs (the one genuine
   parity regression, recommended yes), the KryptonTaskDialog compat shim (recommended no), and
   the Palette Designer successor.

---

## 12. Framework support-status warning

The suite deliberately targets several frameworks that are **out of Microsoft support**, for
consumers pinned to old runtimes. This is stated plainly so nobody is misled:

| Framework | Status |
|---|---|
| .NET Framework 4.6 / 4.6.1 | **Out of support** (April 2022) |
| .NET Framework 4.7 / 4.7.2 / 4.8 / 4.8.1 | Supported (component of Windows) |
| .NET 5 | **Out of support** (EOL May 2022) |
| .NET 6 | **Out of support** (LTS ended November 2024) |
| .NET 7 | **Out of support** (EOL May 2024) |
| **.NET 8** | **Supported — LTS** (to November 2026) |
| .NET 9 | **Out of support** (STS, EOL May 2026) |
| **.NET 10** | **Supported — LTS mainline** |

Consumers on EOL runtimes carry unpatched-security risk that is theirs to accept. **.NET 8 and
.NET 10 are the supported mainline.**

---

*Bastion Krypton Suite — prepared for Bastion Software Solutions Ltd. Derivative-work licence:
BSD-3-Clause (core/original) and MIT (Extended) obligations apply to all Krypton-derived code.*
