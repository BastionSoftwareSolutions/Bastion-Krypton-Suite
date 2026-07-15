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
