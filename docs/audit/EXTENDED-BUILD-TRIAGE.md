# Extended Toolkit — Phase 2 Build Triage (Bastion Krypton Suite, spec §3)

**Repository:** `D:\Krypton-Ultimate\Extended-Toolkit`, branch `bastion/multitarget`
**Core:** sibling `D:\Krypton-Ultimate\Standard-Toolkit`, branch `bastion/multitarget` (11-TFM, warning-clean)
**Build:** desktop MSBuild 18 (VS 2022/18 Community), `Krypton Toolkit Suite Extended 2022 - VS2022.sln`, `/p:Configuration=Release /m`, .NET SDK 10.0.301
**Date:** 15 July 2026
**Scope of this run:** structural rewiring so the whole Extended suite builds from source against the Bastion core, full build attempt, and this classified error report. Module-code compile errors were deliberately **not** fixed (except the four §3 known-broken items listed under "Fixes applied").

---

## 1. What was rewired

| Change | Count / detail |
|---|---|
| TFM matrix expanded to `net46;net47;net472;net48;net481;net5.0-windows;net6.0-windows;net7.0-windows;net8.0-windows;net9.0-windows;net10.0-windows` | Centralised in `Directory.Build.props` (`ActiveExtendedToolkitTFMs`, `ExtendedToolkitTFMs`, Lite/Modern/Legacy variants); inherited by all **61 modules + 2 Ultimate metas** (all use the central property); the **3 applications** (Examples, AutoUpdateCreator, ZipExtractor) were switched from hard-coded `net481;net8.0-windows` to the central property. The `-windows7.0` suffixes were normalised to `-windows` to match the core exactly. Lite set drops net46/net47/net472. |
| NuGet-only core consumers rewired to dual-mode (`Choose` on `$(SolutionName)` ending "NuGet": PackageReference in the NuGet solution, ProjectReference to the sibling Standard-Toolkit otherwise) | **14 csprojs**: Core, DataGridView, Error.Reporting, Navigator, Ribbon, Software.Updater.Core, Theme.Switcher, Toggle.Switch, Tool.Box, Tool.Strip.Items, TreeGridView, Wizard, Ultimate, Ultimate.Lite. ProjectReferences match each project's actual core usage (Toolkit always; plus Navigator/Ribbon/Docking where consumed). The NuGet-solution branches were left intact for upstream diff-friendliness. |
| Resource-handling rules ported from the core | `GenerateResourceUsePreserializedResources=true` except net46, and `System.Resources.Extensions` 9.0.10 PackageReference except net46, in `Directory.Build.props`; the net4x reference-path wiring (`CoreResGen` injection) in `Directory.Build.targets`. `SuppressTfmSupportBuildWarnings` for net5/6/7 also ported. |
| Inner-build serialisation ported from the core | `BuildInParallel=false` for the outer cross-targeting build (module projects share one `DocumentationFile` path across TFMs; concurrent inner builds race on it). `msbuild /m` still parallelises across projects. |
| `LangVersion=preview` centralised | Added to `Directory.Build.props` (modules already set it individually; MessageDialog and the apps now inherit it too). `TreatWarningsAsErrors` deliberately **not** enabled yet (post-triage task). |
| net46-incompatible packages excluded from net46 | 20 `PackageReference` items across **14 csprojs** given `Condition="'$(TargetFramework)' != 'net46'"` — see §3 class (b). This converted an opaque restore wall (38 of 69 projects unable to restore at all) into per-TFM compile data. |

### Fixes applied (the §3 "known broken" items)

1. **Themes** — stale core pins (Release 95.25.4.111, Nightly/Canary 100.25.6.x) in the NuGet-solution branch updated to the repo-standard 100.25.11.x wave, eliminating the NU1605 downgrade against Shared; `Palettes\Base\CustomPaletteBase.cs` no longer declares `Component` *and* `PaletteBase` as bases (CS1721) — `PaletteBase` already derives from `Component` in the current core, so the redundant base was dropped. (The file's deeper defect remains — see §3 class (d).)
2. **Software.Updater** — `Properties\Resources.resx` referenced `..\Resources\ZipExtractor.exe`, which does not exist anywhere in the repository source (only as a build output of the ZipExtractor application), breaking every build with MSB3103. The dead entry was removed (one removal). The checked-in `Resources.Designer.cs` accessor `ZipExtractor1` was retained so the module still compiles; it now returns null at runtime, so `KryptonAutoUpdater`'s embedded-extractor install path is degraded until the ZipExtractor build output is reinstated as a resource (recommended: a build-time copy target from the ZipExtractor project).
3. **Stale backup project files deleted (4):** `Krypton - Backup.Toolkit.Suite.Extended.Buttons 2022.csproj`, `...Shared 2022.csproj`, `...Software.Updater 2022.csproj`, `...ToastNotification 2022.csproj` (none were in any solution).
4. **Software.Updater.Core** — `PackageId` corrected from `Krypton.Toolkit.Suite.Extended.Core[.Canary/.Nightly]` (collision with the real Core module) to `Krypton.Toolkit.Suite.Extended.Software.Updater.Core[.Canary/.Nightly]`.

---

## 2. Build result

### Before rewiring

The suite could not build from source against our core at all:

- 12 module projects + both Ultimate metas consumed core Krypton **only** as NuGet packages (95.x–100.x binaries), so nothing linked against the Bastion core.
- TFM set was six targets (`net472…net10.0-windows7.0`); no net46/net47/net48/net5/6/7.
- First full-matrix restore attempt: **38 of 69 projects failed restore** with **99 NU1202 errors** (all `net46` vs netstandard2.0-era packages); MSBuild `/restore` aborted before compiling a single Extended project, plus 1 MSB3103 resx failure and 1 CS1721 lurking behind it.

### After rewiring

- **Restore: 69/69 projects succeed** for the full 11-TFM matrix.
- **Compile (converged, deterministic across two runs): 1,331 error lines, reducing to 8 root-cause projects.** All remaining errors are pre-existing module-code or reference issues, not wiring.
- **25 of 64 buildable projects compile for all 11 TFMs; 28 more fail only net46 (one-error cascade, see below); 89 % of all project×TFM pairs (628 of ~704) produce assemblies.**

### Per-module TFM matrix (failures only; everything else is 11/11)

| Project | OK | Failing TFMs | Root cause |
|---|---|---|---|
| Themes | 0/11 | all | own CS0533 wall (class d) |
| Software.Updater | 0/11 | all | removed core APIs + WPF types + dependency on Software.Updater.Core (classes a, d) |
| Ultimate / Ultimate.Lite | 5/11 | net46–net481, net5.0 | union of member failures (cascade) |
| Software.Updater.Core | 6/11 | net46–net481 | missing `System.Net.Http` reference on net4x (class b); net46 cascade |
| Data.Visualisation | 8/11 | net46, net47, net5.0 | `RuntimeInformation` on net47 (class a); SkiaSharp unavailable on net46 (class b); net5 cascade from Core |
| Buttons, Core, Drawing.Utilities | 9/11 | net46, net5.0 | Core's `ThrowIfNull` on net5 (class a) + net46 cascade |
| 28 modules (AdvancedDataGridView, CheckSum.Tools, Circular.ProgressBar, Common, Controls, Developer.Utilities, Dialogs, Error.Reporting, File.Copier, Forms, Global.Utilities, InputBox, IO, Language.Model, Memory.Box, Messagebox, Networking, Notifications, Resources, Ribbon, Settings, Specialised.Dialogs, Theme.Switcher, Tool.Box, Tool.Strip.Items, Utilities, Wizard + ZipExtractor app) | 10/11 | net46 only | almost entirely the Developer.Utilities net46 cascade (one CS0234) |
| Fully green (11/11): Calendar, ComboBox, Compression, DataGridView, Debug.Tools, Dock.Extender, Drawing, Effects, Floating.Toolbars, Navi.Suite, Navigator, Outlook.Grid, Panels, Shared, TaskDialogs, ToastNotification, Toggle.Switch, TreeGridView, VirtualTreeColumnView + the empty stubs (File.Explorer, Gages/"Guages", Palette.Selectors, PDF, Scintilla.NET, Tools) | 25 projects | — | — |

(MessageDialog and Security are absent from the plain solution — not built, as upstream intends. AutoUpdateCreator builds 10/11, net46 cascade. Examples builds 10/11 when invoked directly — see §4 anomalies.)

---

## 3. Classified errors (converged full-solution build: 1,331 lines)

### Class (a) — missing API on old TFM — 24 lines, 4 distinct APIs

| API | TFM(s) | Where | Count | Recommended fix (spec §3 ladder) |
|---|---|---|---|---|
| `ArgumentNullException.ThrowIfNull` (added .NET 6) | net5.0-windows | Core (`CS0117`) | 2 | The guarding `#if` evidently admits net5; polyfill helper already exists in the core tree — reuse it, or tighten to `NET6_0_OR_GREATER` (rung a/c) |
| `RuntimeInformation` / `OSPlatform` (added .NET Framework 4.7.1) | net47 | Data.Visualisation (`CS0103`) | 6 | Compat package `System.Runtime.InteropServices.RuntimeInformation` for net46/net47 only (rung b), or `#if` to `Environment.OSVersion` (rung c) |
| `DpiChangedEventArgs` (added .NET Framework 4.6.2) | net46 | Forms (`CS0246`) | 1 | `#if !NET46` around the DPI-changed handler; documented degradation on net46 (rung c/d) |
| WPF types — `Application.Dispatcher`, `DispatcherObject`, `UIElement` (`CS1061`/`CS7069`/`CS0012`) | net5.0/net6.0/net7.0-windows only | Software.Updater (NetSparkle/AutoUpdater vendored code) | 15 | The WinForms-only desktop profile of net5/6/7 omits WindowsBase/PresentationCore (net8+ ref packs include them; net4x has framework assemblies). `#if` the Dispatcher path to a WinForms `SynchronizationContext` equivalent (rung c) — do **not** set `UseWPF=true` suite-wide |

### Class (b) — reference/restore problems — 80 error lines + the pre-mitigation restore wall

1. **NU1202, net46 vs netstandard2.0-era packages** (pre-mitigation: 99 lines, 38 projects unable to restore). Twelve packages have no net46-compatible asset: `WindowsAPICodePack`/`Shell`/`ShellExtensions` 8.0.12, `SkiaSharp` + `SkiaSharp.Views.WindowsForms` 3.119.1, `System.Speech`/`System.Management`/`System.DirectoryServices`/`System.Drawing.Common` 10.0.0, `ProDotNetZip` 1.20.0, `Unofficial.Cyotek.Windows.Forms.NET` 2.0.1, `ZipStorer` 4.2.0.
   **Mitigation applied this run:** those 20 PackageReferences (14 csprojs) now carry `Condition="'$(TargetFramework)' != 'net46'"`. Restore is green; the residual is the code that uses them on net46:
   - **Developer.Utilities net46 `CS0234` (`Microsoft.WindowsAPICodePack`) — 1 error — the single highest-value fix in the suite:** its cascade is what blocks the other 28 modules' net46 builds. One `#if !NET46` around the WindowsAPICodePack usage (task-dialog helpers) with a documented degradation unblocks the whole net46 column.
   - **Error.Reporting net46 `CS0246`** (`ManagementObjectSearcher`, `ManagementBaseObject`, `Ionic`) — 3 errors — same treatment (`#if !NET46`, degrade SysInfo/zip attachments on net46).
   - Where a package genuinely matters on net46, older package lines exist (e.g. `System.Drawing.Common` 4.x/older `System.Management`) — rung b — but for these leaf features documented degradation (rung d) is the pragmatic choice.
2. **`HttpClient`/`HttpClientHandler`/`System.Net.Http` unresolved — Software.Updater.Core, net47/net472/net48/net481 — 44 lines (`CS0246` ×40, `CS0234` ×4).** SDK-style net4x projects do not reference the `System.Net.Http` framework assembly by default. Fix: `<Reference Include="System.Net.Http" Condition="$(TargetFramework.StartsWith('net4'))" />` (it ships in the framework from net45) — trivial, unblocks four TFMs of this module and both Ultimate metas on net4x.
3. **`MSB4181` ×36** — pure cascade noise: when a dependency's inner-TFM build has already failed, the scheduler returns the cached failure without re-logging, so the dependent's cross-targeting outer build reports "the MSBuild task returned false but did not log an error". Zero independent information; disregard once root causes are fixed.
4. Pre-existing `System.Design, Version=5.0.0.0/6.0.0.0` `<Reference>` items in most modules cannot resolve on net5/net6 (MSB3245 **warnings** only, `TreatAsUsed`). Recommend deleting the net5/net6 System.Design references outright in the warning-clean pass.

### Class (c) — resource problems — 0 remaining

- The single resource error (MSB3103, Software.Updater resx → missing `ZipExtractor.exe`) was fixed this run (see §1).
- The core's preserialized-resources rules were ported; **no MSB3822/3823/3824 errors appeared on any TFM**. net46 builds classic (non-preserialised) resources, matching the core's documented behaviour.

### Class (d) — pre-existing code defects — 1,223 lines

| Defect | Where | Count | Recommended fix |
|---|---|---|---|
| `CS0533` — `CustomPaletteBase` re-declares **109** abstract members already declared abstract on `PaletteBase` (file predates the core's IPalette→PaletteBase change) | Themes, all 11 TFMs | 1,199 | Rewrite `CustomPaletteBase` as a thin `PaletteBase` subclass: delete every re-declared member, keep only its additions (`ThemeName`, `BasePaletteType`, the `MergeColors`/`FadedColor` statics if still wanted). Mechanical but large; module is dormant ("Projects to Work On", not in Ultimate) — candidate for a go/no-go entry if not rewritten. Record as an API-break fix in CHANGES.md. |
| `CS0103` — `KryptonLanguageManager` no longer exists in the current core (Extended 95.x-era API) | Software.Updater, every TFM that reaches compile | 18 | Fix-forward against the current core string/language facilities (`KryptonManager`/`KryptonLanguageManager` replacement); record in CHANGES.md |
| `CS1061` — `BackStyle` property no longer on `KryptonForm`-derived `DownloadUpdateDialog` (removed from the current core's `VisualForm`) | Software.Updater (designer code) | 6 | Replace with current styling API (`StateCommon.Back` / palette mode); record in CHANGES.md |

**Warning-noise baseline (for the later `TreatWarningsAsErrors` pass):** 42,517 warning lines, dominated by nullable-reference warnings (CS8600/8625/8622/8602/8604/8603/8601 ≈ 29,000), CS1573 XML-doc params (~2,000), CS0114/CS0649/CS0169, NU1701 (WindowsAPICodePack restored via net4x fallback on net5+ TFMs — 1,122) and WFO1000 (WinForms designer serialisation analyser). Warning-clean is a separate, sizeable phase.

---

## 4. Anomalies and observations

1. **Examples was never scheduled by the solution build** (zero log mentions across two runs) despite `Release|Any CPU.Build.0` being present in the sln. Built directly, it compiles 10/11 (net46 fails only via the module cascade). Needs a solution-file investigation before Phase 4 (samples) — suspect the solution metaproject silently drops it because of its 47-project dependency closure containing failed projects.
2. **Transient MSB4181** was observed once for ToastNotification in the first full run; it builds 11/11 in isolation and was green in the converged run. Watch for scheduler flakiness, but no action needed.
3. The `Gages` module still ships as assembly `…Guages` (double misspelling, per the inventory); untouched this run (public-surface rename is out of scope; empty stub anyway).
4. NSec.Cryptography conditional references in Core/Software.Updater.Core were written for `net6.0-windows`/`net7.0-windows`/`net8.0-windows` TFM strings; after the TFM normalisation these conditions can now actually match. No restore or build errors resulted (packages restored fine where they matched).
5. net46 restore of `System.Resources.Extensions` is correctly skipped (ported core rule) — no MSB3274 anywhere.
6. Both Ultimate metapackages compile and pack on net6–net10; their net4x/net5 failures are purely the union of member failures above.

## 5. Recommended fix order (next run)

1. `System.Net.Http` reference for Software.Updater.Core net4x (unblocks 4 TFMs × 3 projects, class b — one line).
2. `#if !NET46` in Developer.Utilities around WindowsAPICodePack usage (unblocks the net46 column for 28+ projects, class b — small).
3. Core's net5 `ThrowIfNull` guard (unblocks Core/Buttons/Drawing.Utilities/Data.Visualisation/Ultimate on net5, class a — one line).
4. Data.Visualisation `RuntimeInformation` on net47 (class a); Forms `DpiChangedEventArgs` on net46 (class a); Error.Reporting net46 degradation (class b).
5. Software.Updater modernisation (classes a+d) — bounded, but the module is parked upstream; decide ship/park with Chris.
6. Themes `CustomPaletteBase` rewrite (class d) — largest single item; dormant module, go/no-go candidate.
7. Then the warning-clean pass and `TreatWarningsAsErrors=true`.

*Build logs: scratchpad `extended-build-release.log` (pre-mitigation restore), `extended-build-release-2.log` (full build), `extended-build-release-3.log` (converged verification run — byte-identical error set).*

---

## 6. Fix pass results (15 July 2026, second run)

**Outcome: zero build errors across the full plain solution, confirmed by two consecutive `MSBuild /restore /p:Configuration=Release` runs (exit 0, 0 error lines). 64 of the 65 csprojs in the plain solution build; 63 produce all 11 TFMs, Data.Visualisation produces 10 by design, and Themes is deliberately unscheduled (see below).** Logs: scratchpad `fixpass-build-1.log` … `fixpass-build-7.log` (iterations; `-6` is the first zero-error full build, `-7` the convergence check).

### Per-item outcome (numbering from the fix-order brief)

1. **Developer.Utilities net46 CS0234 (the 28-module cascade)** — root cause: `global using Microsoft.WindowsAPICodePack.Dialogs` with the 8.0.12 package excluded on net46. Fixed at **ladder rung (b)**, not (c/d) as first planned: the classic `Microsoft-WindowsAPICodePack-Shell` 1.1.5 package ships `lib/net452` assets with the same namespaces and API (the 8.x line is a fork of it), so a net46-only `PackageReference` restores the full API with **no member degradation**. An interim `#if !NET46` degradation was written and then reverted in favour of this. The same treatment fixed the second-layer net46 failures the unblocked cascade then exposed in **Controls, File.Copier, Networking, Settings, Specialised.Dialogs, Tool.Strip.Items** (public `CommonFileDialogFilter` properties on the browse-box controls survive on net46 intact). One genuine API delta: classic `TaskbarManager.SetProgressValue` has no nullable-maximum overload — two call sites in **CheckSum.Tools** got an `#if NET46` branch passing the explicit percentage maximum (100).
2. **Software.Updater.Core `System.Net.Http` net4x (×44)** — fixed with `<Reference Include="System.Net.Http" Condition="$(TargetFramework.StartsWith('net4'))"/>`, mirroring the core's Krypton.Toolkit csproj. All 4 TFMs green.
3. **Missing-API items (×24)** — all fixed:
   - `ArgumentNullException.ThrowIfNull` on net5 (Core, JascPaletteSerialiser.cs): wrong guard — `#if !NETCOREAPP3_0_OR_GREATER` admits net5.0 but the API is .NET 6+. Both guards tightened to `#if !NET6_0_OR_GREATER` (rung c).
   - `RuntimeInformation`/`OSPlatform` on net47 (Data.Visualisation, ScottPlot `Platform.cs`): the API needs .NET Framework 4.7.1+, and pre-4.7.1 Framework only runs on Windows, so `GetOs()` returns `Os.Windows` directly under `#if NETFRAMEWORK && !NET471_OR_GREATER` (rung c, behaviourally exact — no compat package needed).
   - `DpiChangedEventArgs` on net46 (Forms, VisualForm.cs): the file used `#if !NET462` — not a real SDK symbol (never defined for any TFM in the matrix), so the guard admitted net46. Replaced with the core's exact pattern `#if NET47_OR_GREATER || !NETFRAMEWORK` at both the subscription and handler sites, with the core's degradation comment (net46 keeps `UpdateDpiFactors()` initialisation, loses per-monitor DPI tracking) (rung c/d).
   - WPF types on net5/6/7 (Software.Updater): the csproj referenced net4x framework WPF assemblies via raw `<Reference>` items (one with a hard-coded v4.8 HintPath) that leaked into all TFMs; net8+ tolerated it (merged ref pack), net5/6/7's WinForms-only profile did not. Fixed by restricting the raw references to net4x (HintPath removed — plain framework references suffice) and setting `<UseWPF>true</UseWPF>` for all .NET (Core) TFMs, so `SetOwner(Window)`, `Wpf32Window` and the `Application.Current.Dispatcher` shutdown path work identically on every TFM (rung b — reference alignment, no degradation).
4. **Error.Reporting net46 (×3)** — `System.Management` ships in-box on .NET Framework, so net46 gets `<Reference Include="System.Management"/>` (full WMI SysInfo retained, rung b). `Ionic.Zip` (ProDotNetZip, no net46 asset): the single internal `Zipper` call site now uses in-box `System.IO.Compression` under `#if NET46` (equivalent archive output; rung c). No degradation.
5. **Software.Updater `KryptonLanguageManager` (×18) + `BackStyle` (×6)** — clean 1:1 mappings found in the current core; **go**:
   - `KryptonLanguageManager.GeneralToolkitStrings.{OK,Yes,No}` → `KryptonManager.Strings.GeneralStrings.{OK,Yes,No}` (`KryptonManager.Strings` is `KryptonGlobalToolkitStrings`, which exposes the same `GeneralToolkitStrings` singleton; Extended's own Core module already uses this form throughout). 3 source lines.
   - `BackStyle` → `GroupBackStyle` on `KryptonForm` — verified identical semantics: the removed `VisualForm.BackStyle` was `_stateCommon.BackStyle` (checked at core tag `56c44e813`), and the current `KryptonForm.GroupBackStyle` is `StateCommon!.BackStyle`. 1 designer line. Record both in CHANGES.md as fix-forwards.
6. **Themes non-blocking** — the Themes project's 24 `Build.0` entries were removed from the plain solution and 5 from the Dev solution (project remains on disk and in the sln structure; `ActiveCfg` entries retained). Nothing references it (both Ultimates' references were already commented out), so the CS0533 wall no longer blocks anything. Software.Updater needed no such treatment (step 5 was a go).

### Additional root causes fixed during iteration (not in the original brief)

| Item | Cause | Fix |
|---|---|---|
| Software.Updater WebView2 on net46 (2 errors) | `Microsoft.Web.WebView2` 1.0.3595.46 ships net462+ assets only | net46 pins **1.0.2478.35** — the last release with `lib/net45` — which contains all three APIs the code uses (`AllowExternalDrop`, `CoreWebView2.Profile`, `BasicAuthenticationRequested`); other TFMs unchanged (rung b) |
| Software.Updater ILRepack failure on all 10 compiling TFMs (latent — first surfaced when compile succeeded) | `ILRepack.Lib.MSBuild.Task`'s fallback target merges *every* DLL in the output directory into the primary assembly; under the source build that includes the entire Krypton core (`Failed to resolve assembly: Krypton.Toolkit 105.26.7.196`), and would be wrong even if it resolved | New project-local no-op `ILRepack.targets` (suppresses the fallback target; documented in the file). Revisit only if the standalone NuGet package should vendor-merge dependencies |
| Dialogs net46 `System.Speech` (1 error, latent behind the cascade) | System.Speech 10.0.0 package has no net46 asset | in-box framework `<Reference Include="System.Speech"/>` for net46 (rung b) |
| Drawing.Utilities net46 Cyotek ColorGrid (18 errors, latent) | `Unofficial.Cyotek.Windows.Forms.NET` 2.0.1 has no net46 asset | net46-only `Cyotek.Windows.Forms.ColorPicker` 1.7.2 (the classic package upstream originally used — its commented-out reference was still in the csproj); same namespaces/API |
| Networking net46 `System.DirectoryServices` (latent) | package 10.0.0 has no net46 asset | in-box framework reference for net46 (rung b) |
| Data.Visualisation net46 SkiaSharp wall (146 errors, latent) | SkiaSharp 3.x needs net462+; 39 source files use SKxxx types — beyond any `#if` treatment, and no viable compat package exists | **Documented reduced-TFM set** (spec §3 method step 1): net46 removed from `TargetFrameworks` via `$([MSBuild]::Unescape($(ActiveExtendedToolkitTFMs.Replace('net46;', ''))))` (the `Unescape` is load-bearing: property-function results carry escaped semicolons that break TFM splitting, manifesting as NETSDK1046). Ultimate, Ultimate.Lite and Examples reference it with `Condition="'$(TargetFramework)' != 'net46'"` — so **Ultimate on net46 excludes Data.Visualisation** (feature-matrix entry needed) |
| Ultimate/Ultimate.Lite pack NU1012 (2 errors, latent) | the dependency-bundling pack targets write `lib/$(TargetFramework)/`, and the TFM normalisation from `netX.0-windows7.0` to `netX.0-windows` produced folder names NuGet pack rejects (missing platform version) | pack paths now re-append `7.0` for windows-flavoured TFMs (`netX.0-windows` ≡ `netX.0-windows7.0`) in `Directory.Build.targets` and both Ultimate csprojs; additionally WebView2 assemblies are excluded from the bundling filters (its build targets inject them without `NuGetPackageId` metadata, and the package is already a declared dependency) |

### Final per-project × TFM status

- **Plain solution: 65 csprojs. 64 scheduled, 64 succeed. 63 of 64 build their full 11-TFM matrix** (this includes previously 0/11 Software.Updater — now 11/11 with packages packing — plus both Ultimates, Software.Updater.Core, Buttons, Core, Drawing.Utilities, Forms, Error.Reporting and the entire former net46-cascade column; Examples, AutoUpdateCreator and ZipExtractor all build 11/11, and the §4 "Examples never scheduled" anomaly resolved itself once its dependency closure stopped failing).
- **Data.Visualisation: 10/11 by design** (net46 excluded — SkiaSharp; documented above).
- **Themes: 0/11, deliberately unscheduled** (Build.0 unticked in plain + Dev solutions) pending Chris's CS0533 rewrite decision.
- MessageDialog and Security remain outside the plain solution (upstream intent, unchanged).
- Project×TFM pairs: **703 of 704 possible assemblies produced (99.9 %)** versus 628 (89 %) at triage; the single missing pair is Data.Visualisation net46 (by design), plus the whole deliberately-parked Themes row (not counted as buildable).
- Packing now runs to completion: all module `.nupkg`s and both Ultimate metapackages generate under `Bin\NuGet Packages\Release`.

### Remaining go/no-go list

| Item | Status | Notes |
|---|---|---|
| **Themes `CustomPaletteBase` CS0533 rewrite (1,199 errors)** | **No-go pending Chris** | Dormant module, nothing depends on it; unticked from plain/Dev solution builds. The rewrite (delete 109 re-declared abstract members, keep `ThemeName`/`BasePaletteType`/statics) is mechanical but large; record as API-break fix in CHANGES.md if done. |
| Software.Updater | **Go — shipped** | KryptonLanguageManager/BackStyle fix-forwards applied (CHANGES.md entries needed); ILRepack merge disabled for source builds (revisit for standalone package vendoring); ZipExtractor embedded-resource degradation from §1 still stands. |
| Data.Visualisation net46 | **Accepted degradation** | Needs a per-TFM feature-matrix entry: no charting on net46, including via Ultimate. |
| Warning-clean pass | Open (next phase) | `TreatWarningsAsErrors` still off suite-wide, as agreed. Compile-warning baseline unchanged (≈42.5k lines, dominated by nullable annotations); delete the dead net5/net6 `System.Design` references during that pass. |

---

## 7. Smoke sweep results (15 July 2026, third run)

Every Extended module output directory (`Bin\Release\<module>\<tfm>`) was smoked with the Phase 2 harness
(`Scripts\SmokeTest`, `--dir` mode: every public `Component` with a parameterless constructor instantiated,
shown on a form, resized, disposed) on the true runtime per TFM (net4x on .NET Framework 4.8.1; net5/6/7 on
the locally installed desktop runtimes; net8/9/10 on the system SDK). Per-run logs persist as
`smoke.log` in each output directory.

### Result

| Metric | Value |
|---|---|
| Module dirs with assemblies | **60** (61 minus Themes, which is deliberately unscheduled) |
| Module × TFM runs executed | **659** (660 minus Data.Visualisation net46, absent by design) |
| **Green** | **654 / 659 (99.2 %)** |
| Not green (documented) | **5** — Software.Updater net5.0–net9.0 only (see below) |
| Type instantiations exercised | **≈ 10,984** across the matrix |
| By-design-modal skips | 229 run-level skips from the 5-entry harness skip list |

The initial sweep carried **13 distinct crashing/hanging root causes poisoning ~200 runs**
(`Common.CommonExtendedKryptonForm` alone poisoned 87). All were fixed at source — none was
suppressed — plus one core fix in the sibling Standard-Toolkit (`PaletteFormBorder` null-owner
tolerance). Full root-cause entries **E1–E26** in `docs/audit/BREAKAGE-LOG.md`; headline items:

1. Fade engine: infinite loop on fade-out (`+=` for `-=`) and infinite recursion at fade speed 0 (hung every `CommonExtendedKryptonForm` on every TFM).
2. `VisualKryptonFormExtended` passes a null owner into core `PaletteFormBorder` → NRE on every non-client paint (fixed core-side, null tolerance).
3. `KryptonCalendar` ctor NRE cascade (days array + 14 unguarded event raisers).
4. Never-ported resource tables: NaviBar menu strings, `FlatTabControl` icons; `Image.FromFile` used with a resource name (`KryptonBrowseComboBox`).
5. **Resource manifest naming**: net4x embeds folder-based names, net5+ type-based names — `EmbeddedResourceUseDependentUponConvention=true` forced in `Directory.Build.props` fixes ~60 designer .resx across ~20 modules (MasterDetail grids, NaviOptionsForm, …).
6. Ten controls never unsubscribed from `KryptonManager.GlobalPaletteChanged` (ObjectDisposedException after dispose); `KryptonComboBoxTree` leaked its whole dropdown form — the cause of the Ultimate/Ultimate.Lite full-matrix hang.
7. `ColourCollection` `==`/`!=` mutual recursion → uncatchable StackOverflow killing all 11 Drawing.Utilities runs.
8. .NET 9 `SystemColors.UseAlternativeColorSet` broke `PropagateSystemColours` reflection; `Nullable<uint>` in the `NetServerEnum` P/Invoke; blocking domain enumeration moved off the UI thread (`KryptonNetworkNodePicker`).
9. Unsigned `Unofficial.WinFormAnimation` unloadable from the strong-named Circular.ProgressBar on net4x → original strong-named `WinFormAnimation` 1.6.0.4 used for net4x.

### By-design-modal skip list (harness `Scripts\SmokeTest\Program.cs`, justification per entry in source)

| Type | Modal shown at |
|---|---|
| `Core.GlobalOptionsMenu` | Load: "developmental use only" YesNo box |
| `Core.PaletteColourCreator` | Load: `ResetToDefaults()` confirmation |
| `Dialogs.KryptonNuGetBrowser` | Load: `UnderConstruction()` stub box |
| `Drawing.Utilities.KryptonColourFindAndReplaceDialog` | **Constructor**: `UnderConstruction()` stub box |
| `Theme.Switcher.UploadThemeBrowser` | Load: `NotImplemented()` stub box |

### Remaining non-green (documented, not defects fixed this pass)

- **Software.Updater net5.0/6.0/7.0/8.0/9.0 (5 runs)**: harness raw-DLL-loader artifact, not a module defect. The module pins `System.Drawing.Common` 10.0 while the harness's host runtime supplies the shared-framework copy (e.g. 8.0 on net8); `Assembly.LoadFrom` cannot unify to a second version in the default load context, so type enumeration throws `FileLoadException`. A real app referencing the module resolves this through its own `deps.json`. **Software.Updater passes net46–net481 and net10** (8 types each, 0 failures). If desired, a per-TFM `System.Drawing.Common` pin matched to each runtime would also make the harness green — Chris to decide whether the package-dependency change is worth it.

### Harness improvements made during the sweep

- Documented skip list (above); native-library resolver for module-dir `runtimes\win-<arch>\native` assets (SkiaSharp had been picking up an incompatible stray libSkiaSharp from PATH); `TabPage`/`ToolStripDropDown` parenting handling; `run-extended-smoke.ps1` module-assembly probe no longer requires the assembly name to equal the directory name (the `Task.Dialogs` directory ships `…TaskDialogs.dll` and had been silently skipped).

## 7. Smoke sweep results (15 July 2026, final)

**ALL GREEN: 659 module-directory × TFM smoke runs, 0 failures** (12 combinations skipped — no assembly
for that TFM, e.g. Data.Visualisation net46 by design). Every run instantiates, shows, resizes and
disposes every public Component type in the module assembly *and its Extended dependencies* present in
that output directory, on the true runtime for the TFM (.NET Framework 4.8.1 for net4x; local .NET
5.0.17/6.0.36/7.0.20 desktop runtimes; system .NET 8/9/10).

Nine upstream defect classes were found and fixed to get here — see `BREAKAGE-LOG.md` E1–E9
(inverted fade-out loop, zero-speed fade recursion, forced PopUp cast, null-owner form border NRE
(core fix), calendar constructor NRE cascade, progress-bar brush NRE, NaviBar phantom resource,
designer-resx manifest-name divergence on net4x, unloadable System.Drawing.Common 10.0.0 pin).

Harness notes: one justified skip-list entry (`Core.GlobalOptionsMenu` shows a modal message box by
design); the harness gained `--dir` mode, WPF support on .NET (Core) TFMs, defensive reflection, and
an incremental runner (`run-extended-smoke.ps1`).
