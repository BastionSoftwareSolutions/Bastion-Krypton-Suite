# Extended Toolkit — Module Inventory (Bastion Krypton Suite §2.5)

**Repository:** `D:\Krypton-Ultimate\Extended-Toolkit` (Krypton-Suite/Extended-Toolkit)
**Branch:** `bastion/multitarget` (V105-LTS line; HEAD `2725d8c4` — "Merge pull request #570 from Krypton-Suite/V105-LTS-version-bump")
**Source of NuGet package:** `Krypton.Toolkit.Suite.Extended.Ultimate` 105.26.4.114
**Audit date:** 2026-07-15. Read-only audit; nothing in the clone was modified.

---

## 1. Repository layout and shared build configuration

All module projects live under `D:\Krypton-Ultimate\Extended-Toolkit\Source\Krypton Toolkit\`, one directory per module, with project files named `Krypton.Toolkit.Suite.Extended.<Module> 2022.csproj` (one exception: `Krypton.Toolkit.Suite.Extended.MessageDialog.csproj`, no " 2022" suffix).

**Project count:** 66 non-backup `.csproj` files in total:

- **61 module library projects** (`Krypton.Toolkit.Suite.Extended.*`, excluding the two Ultimate meta-packages)
- **2 meta-package projects**: `Krypton.Toolkit.Suite.Extended.Ultimate` and `...Ultimate.Lite`
- **3 application projects** (not modules): `AutoUpdateCreator\AutoUpdateCreator.csproj`, `Examples\Examples.csproj`, `ZipExtractor\ZipExtractor.csproj`
- Additionally, **3 stale backup project files** are checked in and should be pruned in Bastion: `Krypton - Backup.Toolkit.Suite.Extended.Buttons 2022.csproj`, `Krypton - Backup.Toolkit.Suite.Extended.Shared 2022.csproj`, `Krypton - Backup.Toolkit.Suite.Extended.Software.Updater 2022.csproj`, plus `Krypton - Backup.Toolkit.Suite.Extended.ToastNotification 2022.csproj` (4 files; ToastNotification's included).

### 1.1 Target frameworks (shared)

`D:\Krypton-Ultimate\Extended-Toolkit\Directory.Build.props` defines centralised TFMs, selected by build configuration via a `Choose` block:

| Property | TFMs |
|---|---|
| `ActiveExtendedToolkitTFMs` (Release/Debug/Canary/Nightly) | `net472;net48;net481;net8.0-windows7.0;net9.0-windows7.0;net10.0-windows7.0` |
| `ActiveExtendedToolkitTFMs` (ReleaseLite/CanaryLite/NightlyLite) | `net48;net481;net8.0-windows7.0;net9.0-windows7.0;net10.0-windows7.0` (drops net472) |
| `ExtendedToolkitTFMs` (static "full" list) | same six TFMs as full |

**Every module project sets `<TargetFrameworks>$(ActiveExtendedToolkitTFMs)</TargetFrameworks>`** (inside a redundant `Choose` whose `When` and `Otherwise` branches are identical). The single outlier is **MessageDialog**, which uses the static `$(ExtendedToolkitTFMs)` — same six TFMs, but not Lite-aware. The three applications hard-code `net481;net8.0-windows`.

Versioning is date-derived in `Directory.Build.props`: `105.<yy>.<MM>.<dayOfYear>` (hence 105.26.4.114 = built 2026, April, day 114), with `-beta`/`-alpha` suffixes for Canary/Nightly.

`D:\Krypton-Ultimate\Extended-Toolkit\Directory.Build.targets` makes every package self-contained: `CopyLocalLockFileAssemblies`, `IncludeReferencedProjects`, and custom targets (`CopyProjectReferencesToPackage`, `IncludeReferencedProjectInPackage`) that bundle all non-framework referenced DLLs into `lib/<tfm>/` of each nupkg. It also sets default package metadata and — notably — `PackageLicenseExpression = BSD-3-Clause`, **while the repo-root `LICENSE` file is MIT** ("Copyright (c) 2017 - 2024 Krypton Suite") and most source headers say MIT or "BSD-style". This licence inconsistency should be resolved in Bastion.

`D:\Krypton-Ultimate\Extended-Toolkit\Build.proj` orchestrates: Restore → Build (main sln) → BuildNuGet (NuGet sln) → BuildUltimate (the two Ultimate csproj) → Pack (packs only Ultimate + Ultimate.Lite).

### 1.2 Solutions

Directory: `D:\Krypton-Ultimate\Extended-Toolkit\Source\Krypton Toolkit\`

| Solution | Purpose | Notes |
|---|---|---|
| `Krypton Toolkit Suite Extended 2022 - VS2022.sln` | Main/dev build | Includes `Krypton.Toolkit 2022.csproj` from the **sibling Standard-Toolkit checkout** (`..\..\..\Standard-Toolkit\...`). Contains the "Projects to Work On" solution folder (see §5). Does **not** contain MessageDialog or Security. |
| `Krypton Toolkit Suite Extended 2022 - VS2022 - NuGet.sln` | Package build | Same set plus MessageDialog, Security, and the SHFB documentation project; no Standard-Toolkit project — core comes from NuGet (see §2). |
| `Krypton Toolkit Suite Extended 2022 - VS2022 - Dev.sln` | Developer convenience | 49 project entries, includes five Standard-Toolkit component projects (Toolkit, Navigator, Ribbon, Workspace, Docking) by relative path. |
| `... - NuGet.slnx` | slnx mirror of the NuGet solution | |

### 1.3 How modules reference the core Krypton Toolkit (critical for Phase 2 rewiring)

Each module csproj contains a `Choose` keyed on **`'$(SolutionName.Endswith(`NuGet`))'`**:

- **Solution name ends in "NuGet"** → `PackageReference` to core Krypton packages, per configuration:
  - Nightly → `Krypton.Toolkit.Nightly` **100.25.11.318-alpha**
  - Canary → `Krypton.Toolkit.Canary` **100.25.11.318-beta**
  - Release → `Krypton.Toolkit` **100.25.11.328**
  - Otherwise (Debug etc.) → `Krypton.Toolkit` **95.25.10.293**
- **Any other solution** → `ProjectReference` to `..\..\..\..\Standard-Toolkit\Source\Krypton Components\Krypton.Toolkit\Krypton.Toolkit 2022.csproj` — i.e. the repo **assumes a sibling `Standard-Toolkit` clone** (which exists in this workspace at `D:\Krypton-Ultimate\Standard-Toolkit`).

**However, 12 module projects + the 2 Ultimate meta-packages have NO Standard-Toolkit ProjectReference fallback at all — they consume core Krypton exclusively via NuGet in every solution/configuration** (their `Choose` covers Release/Lite/Signed/etc. variants instead). These are the primary rewiring targets:

| Project (NuGet-only core consumers) | Core packages referenced (Release / others) |
|---|---|
| `Krypton.Toolkit.Suite.Extended.Core` | Toolkit, Navigator, Ribbon, Docking 100.25.11.328; `.Lite` 90.25.2.55; `.Signed`/`.Signed.Lite` 65.22.6.152; fallback 95.25.10.293 |
| `Krypton.Toolkit.Suite.Extended.DataGridView` | Toolkit (same version matrix) |
| `Krypton.Toolkit.Suite.Extended.Error.Reporting` | Toolkit + Navigator (same matrix) |
| `Krypton.Toolkit.Suite.Extended.Navigator` | Toolkit + Navigator (same matrix) |
| `Krypton.Toolkit.Suite.Extended.Ribbon` | Toolkit + Ribbon (same matrix) |
| `Krypton.Toolkit.Suite.Extended.Software.Updater.Core` | Toolkit, Navigator, Ribbon, Docking (same matrix) |
| `Krypton.Toolkit.Suite.Extended.Theme.Switcher` | Toolkit + Navigator (same matrix) |
| `Krypton.Toolkit.Suite.Extended.Toggle.Switch` | Toolkit (same matrix) |
| `Krypton.Toolkit.Suite.Extended.Tool.Box` | Toolkit (same matrix) |
| `Krypton.Toolkit.Suite.Extended.Tool.Strip.Items` | Toolkit (same matrix) |
| `Krypton.Toolkit.Suite.Extended.TreeGridView` | Toolkit (same matrix) |
| `Krypton.Toolkit.Suite.Extended.Wizard` | Toolkit (same matrix) |
| `Krypton.Toolkit.Suite.Extended.Ultimate` / `.Ultimate.Lite` | Toolkit, Navigator, Ribbon, Docking 100.25.11.328 (+ Nightly/Canary variants; fallback 95.25.10.293) |

All other modules use the dual-mode pattern (NuGet in the NuGet solution, ProjectReference otherwise). `Krypton.Toolkit.Suite.Extended.Debug.Tools` references **no** core Krypton at all.

**Stale core versions** (modules not kept in step with the 100.25.11.x wave — all are dormant/under-development, see §5): File.Explorer, Gages, PDF, Scintilla.NET, Software.Updater, TaskDialogs, Themes and the AutoUpdateCreator app pin Release `Krypton.Toolkit` **95.25.4.111** (Nightly 100.25.6.167-alpha, Canary 100.25.6.171-beta). Security pins Nightly **90.23.12.345-alpha** / Canary **90.23.11.326-beta**; PDF pins Nightly **90.23.12.345-alpha**.

### 1.4 Package identity pattern

Every module declares configuration-dependent `PackageId`s: `<AssemblyName>` for Release/Debug, `<AssemblyName>.Canary` for Canary, `<AssemblyName>.Nightly` for Nightly (Lite builds get `.Lite` suffixes via the build scripts). **Release PackageId == AssemblyName == RootNamespace for every module**, with one exception: the *Gages* project directory is `Krypton.Toolkit.Suite.Extended.Gages`, but its assembly, namespace and package ID are the (differently misspelt) **`Krypton.Toolkit.Suite.Extended.Guages`**. `Software.Updater.Core`'s csproj mistakenly declares `PackageId` `Krypton.Toolkit.Suite.Extended.Core[.Canary/.Nightly]` — a copy/paste error that collides with the real Core module (mitigated only by `GeneratePackageOnBuild=False`).

All projects sign with a per-project `StrongKrypton.snk`, use `LangVersion=preview`, `UseWindowsForms=true`, and `Nullable=enable` (mostly).

---

## 2. Per-module inventory

Conventions for this section (to avoid repetition):

- **Path** is relative to `D:\Krypton-Ultimate\Extended-Toolkit\Source\Krypton Toolkit\`.
- **TFMs** = the shared six-TFM set (§1.1) unless stated.
- **Package ID** = Release ID (Canary/Nightly/Lite variants per §1.4).
- **Core ref** = "dual" (PackageReference `Krypton.Toolkit` 100.25.11.328 in NuGet solution / ProjectReference to Standard-Toolkit otherwise), "NuGet-only" (§1.3 table), "stale-dual" (dual but pinned 95.25.4.111), or "none".
- **Ultimate** = referenced by both `Ultimate 2022.csproj` and `Ultimate.Lite 2022.csproj` (their reference lists are identical).
- **.cs count** = non-obj/bin C# files, a proxy for maturity.
- Control lists are complete where short; marked *(representative)* where trimmed.

### 2.1 Shared/infrastructure modules

#### Krypton.Toolkit.Suite.Extended.Shared
- Path: `Krypton.Toolkit.Suite.Extended.Shared\Krypton.Toolkit.Suite.Extended.Shared 2022.csproj`; assembly/package `Krypton.Toolkit.Suite.Extended.Shared`. 16 .cs.
- Purpose: re-implements Standard-Toolkit internals that are inaccessible outside it.
- Deps: core ref dual; no module refs; no third-party. `GeneratePackageOnBuild=False`.
- Controls: none (helper APIs).
- Status: solution folder "Shared"; in Ultimate: **yes**.

#### Krypton.Toolkit.Suite.Extended.Debug.Tools
- Path: `Krypton.Toolkit.Suite.Extended.Debug.Tools\Krypton.Toolkit.Suite.Extended.Debug.Tools 2022.csproj`. 2 .cs.
- Deps: **no core Krypton reference at all**; no module refs; no packages. `GeneratePackageOnBuild=False`.
- Controls: none (exception/debug helpers). Referenced by almost every other module.
- Status: "Main" folder; in Ultimate: **yes**.

#### Krypton.Toolkit.Suite.Extended.Developer.Utilities
- Path: `Krypton.Toolkit.Suite.Extended.Developer.Utilities\...Developer.Utilities 2022.csproj`. 12 .cs.
- Deps: core dual; ProjectReference → Shared; PackageReference `WindowsAPICodePackShell` 8.0.12. `GeneratePackageOnBuild=False`.
- Controls: `KryptonDeveloperDebugConsole : KryptonForm`.
- Status: "Shared" folder; in Ultimate: **yes**.

#### Krypton.Toolkit.Suite.Extended.Common
- Path: `Krypton.Toolkit.Suite.Extended.Common\...Common 2022.csproj`. 58 .cs.
- Deps: core dual; PRs → Debug.Tools, Developer.Utilities, Effects, Shared.
- Third-party: `Utilities\AllowNullAttribute.cs` is .NET Foundation code (MIT header retained).
- Controls: `InternalKryptonMessageBoxExtended : KryptonForm`, `SubClass : NativeWindow`, `CommonCircularPictureBox : PictureBox`, `CommonKryptonKnobControlEnhanced : UserControl`, `CommonExtendedKryptonForm : KryptonForm`.
- Status: "Shared"; in Ultimate: **yes**.

#### Krypton.Toolkit.Suite.Extended.Core
- Path: `Krypton.Toolkit.Suite.Extended.Core\...Core 2022.csproj`. 135 .cs.
- Deps: core **NuGet-only** (Toolkit+Navigator+Ribbon+Docking); PRs → Controls, Global.Utilities, Settings, Shared; packages `Newtonsoft.Json` 13.0.4, `Portable.BouncyCastle` 1.9.0, `WindowsAPICodePack` 8.0.12, plus **dead conditional** `NSec.Cryptography` refs for net6.0/net7.0/net8.0-windows (24.4.0 / 23.9.0-preview.3 / 25.4.0 — the net6/net7 conditions can never fire with current TFMs, and net8 TFM is `net8.0-windows7.0`, so none match). `GeneratePackageOnBuild=False` despite the Core package existing upstream.
- Controls *(representative of 28)*: `VisualControlBaseExtended : Control`, `ColourEditorManager : Component`, `ColourGridControl/ColourSliderControl/ColourWheelControl/ScreenColourPickerControl : Control`, many `KryptonForm` palette/colour dialogs (`PaletteColourCreator`, `PaletteFileEditor`, `ColourMixer`, `SystemInformationWindow`, `KryptonFadeForm`, …).
- Status: "Shared"; in Ultimate: **yes**.

#### Krypton.Toolkit.Suite.Extended.Drawing
- Path: `Krypton.Toolkit.Suite.Extended.Drawing\...Drawing 2022.csproj`. 4 .cs. Base drawing utilities.
- Deps: core dual; no module refs. `GeneratePackageOnBuild=False`. Controls: none.
- Status: "Shared"; in Ultimate: **yes**.

#### Krypton.Toolkit.Suite.Extended.Effects
- Path: `Krypton.Toolkit.Suite.Extended.Effects\...Effects 2022.csproj`. 7 .cs.
- Deps: core dual; no module refs. `GeneratePackageOnBuild=False`.
- Controls: `FadeManager : Component`.
- Status: "Shared"; in Ultimate: **yes**.

#### Krypton.Toolkit.Suite.Extended.Global.Utilities
- Path: `Krypton.Toolkit.Suite.Extended.Global.Utilities\...Global.Utilities 2022.csproj`. 10 .cs.
- Deps: core dual; PRs → Debug.Tools, Developer.Utilities. `GeneratePackageOnBuild=False`. Controls: none.
- Status: "Shared"; in Ultimate: **yes**.

#### Krypton.Toolkit.Suite.Extended.Language.Model
- Path: `Krypton.Toolkit.Suite.Extended.Language.Model\...Language.Model 2022.csproj`. 5 .cs.
- Deps: core dual; PRs → Debug.Tools, Developer.Utilities. `GeneratePackageOnBuild=False`. Controls: none (language/translation model classes for button controls).
- Status: "Shared"; in Ultimate: **yes**.

#### Krypton.Toolkit.Suite.Extended.Resources
- Path: `Krypton.Toolkit.Suite.Extended.Resources\...Resources 2022.csproj`. 2 .cs (global resources).
- Deps: core dual; PR → Settings. `GeneratePackageOnBuild=False`. Controls: none.
- Status: "Shared"; in Ultimate: **yes**.

#### Krypton.Toolkit.Suite.Extended.Settings
- Path: `Krypton.Toolkit.Suite.Extended.Settings\...Settings 2022.csproj`. 75 .cs (settings wrapper classes).
- Deps: core dual; PRs → Common, Debug.Tools, Global.Utilities, Shared; package `WindowsAPICodePack` 8.0.12. `GeneratePackageOnBuild=False`. Controls: none.
- Status: "Shared"; in Ultimate: **yes**.

#### Krypton.Toolkit.Suite.Extended.Tools
- Path: `Krypton.Toolkit.Suite.Extended.Tools\...Tools 2022.csproj`. **1 .cs (`Globals/GlobalDeclarations.cs` only — empty stub)**.
- Deps: core dual; no module refs. `GeneratePackageOnBuild=False`. Controls: none.
- Status: solution folder **"Projects to Work On"**; in Ultimate: **yes** (referenced despite being empty).

#### Krypton.Toolkit.Suite.Extended.Utilities
- Path: `Krypton.Toolkit.Suite.Extended.Utilities\...Utilities 2022.csproj`. **340 .cs**.
- Deps: core dual; PR → Developer.Utilities. `GeneratePackageOnBuild=False`.
- Third-party: `Classes\System\SAPI\**` is a large vendored managed Speech API layer clearly derived from .NET `System.Speech` reference source (MIT, .NET Foundation) — **headers re-stamped with the Krypton Suite MIT header; no upstream attribution retained** (e.g. `Classes\System\SAPI\Audio Format\AudioBitsPerSample.cs`). Also `Attributes\AllowNullAttribute.cs` (.NET Foundation MIT, header retained).
- Controls: none.
- Status: "Shared"; in Ultimate: **yes**.

### 2.2 Control/component modules

#### Krypton.Toolkit.Suite.Extended.AdvancedDataGridView
- Path: `Krypton.Toolkit.Suite.Extended.AdvancedDataGridView\...AdvancedDataGridView 2022.csproj`. 15 .cs.
- Deps: core dual; PRs → Debug.Tools, Developer.Utilities.
- Third-party: derived from the ADGV / `Zuby.AdvancedDataGridView` lineage — files under `Controls Toolkit\` carry the original **Microsoft Public License (Ms-PL)** header (e.g. `Controls Toolkit\KryptonAdvancedDataGridView.cs` line 4).
- Controls: `KryptonAdvancedDataGridView : KryptonDataGridView`, `KryptonAdvancedDataGridViewSearchToolBar : ToolStrip`, `FormCustomFilter : KryptonForm`.
- Status: "Main"; in Ultimate: **yes**.

#### Krypton.Toolkit.Suite.Extended.Buttons
- Path: `Krypton.Toolkit.Suite.Extended.Buttons\...Buttons 2022.csproj`. 35 .cs.
- Deps: core dual; PRs → Debug.Tools, Developer.Utilities, Core; packages `WindowsAPICodePackShell` + `WindowsAPICodePackShellExtensions` 8.0.12.
- Controls (12): `KryptonCommandLinkButton : VisualSimpleBase`, `KryptonCommandLinkVersion2`, `KryptonSplitButton`, `KryptonBrowseButton`, `KryptonUACButtonVersion1/2`, `KryptonOK/Cancel/Yes/NO DialogButton : KryptonButton`, `KryptonViewButtons : UserControl`, `KryptonDialogButtonExtended`.
- Status: "Main"; in Ultimate: **yes**. (Backup csproj present in directory.)

#### Krypton.Toolkit.Suite.Extended.Calendar
- Path: `Krypton.Toolkit.Suite.Extended.Calendar\...Calendar 2022.csproj`. 39 .cs.
- Deps: core dual; no module refs.
- Controls: `KryptonCalendar : ScrollableControl`, `KryptonCalendarTextBox : KryptonTextBox` (+ renderer/item classes).
- Status: "Main"; in Ultimate: **yes**.

#### Krypton.Toolkit.Suite.Extended.CheckSum.Tools
- Path: `Krypton.Toolkit.Suite.Extended.CheckSum.Tools\...CheckSum.Tools 2022.csproj`. 15 .cs.
- Deps: core dual; PRs → Debug.Tools, Controls, Developer.Utilities.
- Controls: `KryptonBrowseBox : KryptonTextBox`, `KryptonComputeFileCheckSum`, `KryptonVerifyFileCheckSum` (+ `...Old` variants) : KryptonForm.
- Status: "Main"; in Ultimate: **yes**.

#### Krypton.Toolkit.Suite.Extended.Circular.ProgressBar
- Path: `Krypton.Toolkit.Suite.Extended.Circular.ProgressBar\...Circular.ProgressBar 2022.csproj`. 3 .cs + `Readme.md`.
- Deps: core dual; PRs → Debug.Tools, Developer.Utilities; package `Unofficial.WinFormAnimation` 2.0.2 (repack of Soroush Falahati's WinFormAnimation, MIT). The control lineage matches falahati's `CircularProgressBar` (MIT) but no upstream attribution is present.
- Controls: `CircularProgressBar` (partial class; not caught by base-class grep — derives via custom base in `Controls\`).
- Status: "Main"; in Ultimate: **yes**.

#### Krypton.Toolkit.Suite.Extended.ComboBox
- Path: `Krypton.Toolkit.Suite.Extended.ComboBox\...ComboBox 2022.csproj`. 4 .cs.
- Deps: core dual; no module refs.
- Controls: `KryptonComboBoxTree : Control`, `KryptonEnumerationComboBox : KryptonComboBox`.
- Status: "Main"; in Ultimate: **yes**.

#### Krypton.Toolkit.Suite.Extended.Compression
- Path: `Krypton.Toolkit.Suite.Extended.Compression\...Compression 2022.csproj`. 3 .cs.
- Deps: core dual; no module refs.
- Controls: `KryptonFileCompressor : KryptonForm`.
- Status: "Main"; in Ultimate: **yes**.

#### Krypton.Toolkit.Suite.Extended.Controls
- Path: `Krypton.Toolkit.Suite.Extended.Controls\...Controls 2022.csproj`. 52 .cs.
- Deps: core dual; PRs → Debug.Tools, Developer.Utilities, Drawing.
- Controls *(representative of 24)*: `KryptonPopUpComboBox`, `KryptonCheckBoxComboBox`, `KryptonKnobControlVersion1/2 : UserControl`, `KryptonMarqueeLabel`, `KryptonPasswordTextBox`, `KryptonProgressBarExtended : ProgressBar`, `KryptonRadialMenu : UserControl`, `KryptonRichTextBoxExtended`, `KryptonStarRatingControl : Panel`, `KryptonValidationBox`, `PopUp : ToolStripDropDown`.
- Status: "Main"; in Ultimate: **yes**.

#### Krypton.Toolkit.Suite.Extended.Data.Visualisation
- Path: `Krypton.Toolkit.Suite.Extended.Data.Visualisation\...Data.Visualisation 2022.csproj`. **348 .cs**.
- Deps: core dual; PR → Core; packages `SkiaSharp` 3.119.1, `SkiaSharp.Views.WindowsForms` 3.119.1, `NETStandard.Library` 2.0.3, `System.Diagnostics.Debug` 4.3.0.
- Third-party: **entire `Scott Plot\` directory is vendored ScottPlot 5 source** (namespace rewritten to `Krypton.Toolkit.Suite.Extended.Data.Visualisation.ScottPlot`). ScottPlot upstream is MIT (© Scott Harden and contributors), **but the files carry no upstream attribution and `License\License.txt` is the Krypton Suite MIT text** — licence-audit flag: MIT requires preservation of the original copyright notice.
- Controls: `FormsPlot`, `FormsPlotGL`, `FormsPlotBase : UserControl` (SkiaSharp-hosted plot surfaces).
- Status: "Main"; in Ultimate: **yes**.

#### Krypton.Toolkit.Suite.Extended.DataGridView
- Path: `Krypton.Toolkit.Suite.Extended.DataGridView\...DataGridView 2022.csproj`. 27 .cs.
- Deps: core **NuGet-only**; no module refs.
- Controls *(representative of 17)*: `SingleDetailView`, `MasterDetailGridViewBase : KryptonDataGridView`; column/cell types `KryptonDataGridViewBinary/Formatting/Percentage/Rating/TextAndImage/Token/TokenList Column+Cell`.
- Status: "Main"; in Ultimate: **yes**.

#### Krypton.Toolkit.Suite.Extended.Dialogs
- Path: `Krypton.Toolkit.Suite.Extended.Dialogs\...Dialogs 2022.csproj`. 32 .cs.
- Deps: core dual; PRs → CheckSum.Tools, Forms, Global.Utilities, Controls, Settings, Utilities, Common; packages `System.Speech` 10.0.0, `WindowsAPICodePackShell` 8.0.12.
- Controls (9): `KryptonAuthenticationForm`, `KryptonExceptionCaptureDialog`, `KryptonInputBoxExtendedForm`, `KryptonNuGetBrowser`, `KryptonPropertiesForm`, `KryptonRunDialog : KryptonFormExtended`, `KryptonRunDialogOptions` (all KryptonForm-based), `KryptonBrowseComboBox`, `KryptonSplitButton`.
- Status: "Main"; in Ultimate: **yes**.

#### Krypton.Toolkit.Suite.Extended.Dock.Extender  *(README: "Under Development")*
- Path: `Krypton.Toolkit.Suite.Extended.Dock.Extender\...Dock.Extender 2022.csproj`. 9 .cs.
- Deps: core dual; no module refs.
- Controls: `KryptonFloatableForm : KryptonForm`, `KryptonOverlayForm : KryptonForm` (+ `DockExtender` logic classes).
- Status: solution folder **"Main"** (not "Projects to Work On"); in Ultimate: **yes**. Small but real implementation — the README flag looks stale, though maturity is low.

#### Krypton.Toolkit.Suite.Extended.Drawing.Utilities
- Path: `Krypton.Toolkit.Suite.Extended.Drawing.Utilities\...Drawing.Utilities 2022.csproj`. 92 .cs.
- Deps: core dual; PRs → Buttons, Common, Controls, Core, Developer.Utilities, Floating.Toolbars, Messagebox, Shared (the most-connected module); package `Unofficial.Cyotek.Windows.Forms.NET` 2.0.1 (repack of Cyotek colour-picker controls, MIT © Richard Moss).
- Third-party: colour-picker controls (`ColourWheelControl`, `ColourGridControl`, `ScreenColourPickerControl`, etc.) are adapted from **Cyotek.Windows.Forms.ColorPicker** (MIT) — acknowledged only via code comments (`Controls\Components\ColourWheelControl.cs:783`); `ImageBoxExtended.cs` adapts Cyotek ImageBox and **CodeProject gGlowBox** (`Controls\Components\ImageBoxExtended.cs:2885`; CodeProject content is typically CPOL — worth verifying before redistribution).
- Controls *(representative of 28)*: `KryptonColourButtonExtended : VisualSimpleBase`, `ColourHexadecimalComboBox/TextBox`, RGBA `KryptonLabel`/`KryptonNumericUpDown`/`KryptonTrackBar` families, `ColourEditor : UserControl`, `ImageBoxExtended`.
- Status: "Shared"; in Ultimate: **yes**.

#### Krypton.Toolkit.Suite.Extended.Error.Reporting
- Path: `Krypton.Toolkit.Suite.Extended.Error.Reporting\...Error.Reporting 2022.csproj`. 64 .cs.
- Deps: core **NuGet-only** (Toolkit + Navigator); no module refs; packages `Handlebars.Net` 2.1.6, `ProDotNetZip` 1.20.0, `Simple-MAPI.NET` 1.2.1, `System.Management` 10.0.0.
- Third-party lineage: structure matches the open-source ExceptionReporter.NET family (templating with Handlebars, MAPI mail); headers are Krypton BSD/MIT only.
- Controls: `ExceptionReportView : KryptonForm` (+ many non-control report classes).
- Status: "Main"; in Ultimate: **yes**.

#### Krypton.Toolkit.Suite.Extended.File.Explorer  *(README: "Under Development")*
- Path: `Krypton.Toolkit.Suite.Extended.File.Explorer\...File.Explorer 2022.csproj`. **1 .cs (GlobalDeclarations stub) — no implementation**.
- Deps: core **stale-dual** (Release pin 95.25.4.111).
- Controls: none.
- Status: solution folder **"Projects to Work On"**; in Ultimate: **no**. Confirmed under development (effectively empty).

#### Krypton.Toolkit.Suite.Extended.File.Copier
- Path: `Krypton.Toolkit.Suite.Extended.File.Copier\...File.Copier 2022.csproj`. 11 .cs.
- Deps: core dual; PRs → Debug.Tools, Developer.Utilities; package `WindowsAPICodePackShell` 8.0.12.
- Controls: `KryptonFileListing : UserControl`, `KryptonFileCopier : KryptonForm`, `KryptonFileMonitor : KryptonForm`.
- Status: "Main"; in Ultimate: **yes**.

#### Krypton.Toolkit.Suite.Extended.Floating.Toolbars
- Path: `Krypton.Toolkit.Suite.Extended.Floating.Toolbars\...Floating.Toolbars 2022.csproj`. 18 .cs.
- Deps: core dual; no module refs.
- Controls (10): `FloatableMenuStrip : MenuStrip`, `FloatableToolStrip : ToolStrip`, `FloatablePanelHost/MenuStripPanelExtended/ToolStripPanelExtended : ToolStripPanel`, `FloatingContainerForm`, `ToolStripContainerWindow`, `MenuStripContainerWindow`, chooser forms.
- Status: "Main"; in Ultimate: **yes**.

#### Krypton.Toolkit.Suite.Extended.Forms
- Path: `Krypton.Toolkit.Suite.Extended.Forms\...Forms 2022.csproj`. 42 .cs.
- Deps: core dual; PR → Shared. Third-party: `Utilities\AllowNullAttribute.cs` (.NET Foundation MIT, header retained).
- Controls *(representative of 13)*: `KryptonFormExtended : VisualKryptonFormExtended`, `KryptonSlideForm`, `VisualForm : Form`, `TransparentPanel : KryptonPanel`, `ButtonSpecFormWindowClose/Max/Min`, `VisualBlur : NativeWindow`.
- Status: "Main"; in Ultimate: **yes**.

#### Krypton.Toolkit.Suite.Extended.Gages  *(README: "Under Development" as "Gages")*
- Path: `Krypton.Toolkit.Suite.Extended.Gages\...Gages 2022.csproj`. **1 .cs (GlobalDeclarations stub)**.
- Assembly/namespace/package: **`Krypton.Toolkit.Suite.Extended.Guages`** (misspelt, differs from directory spelling "Gages" and the English "Gauges").
- Deps: core **stale-dual** (95.25.4.111). Controls: none.
- Status: **"Projects to Work On"**; in Ultimate: **no**. Confirmed under development (empty).

#### Krypton.Toolkit.Suite.Extended.InputBox
- Path: `Krypton.Toolkit.Suite.Extended.InputBox\...InputBox 2022.csproj`. 23 .cs.
- Deps: core dual; PRs → Settings, Shared.
- Controls (6): `KryptonInputBoxExtendedManager`/`...AlternateManager : Component`, `KryptonInputBoxExtendedForm`/`...AlternateForm`/`...FormTest : KryptonForm`, `InternalKryptonBorderedLabel`.
- Status: "Main" ("Generate Packages" sub-folder); in Ultimate: **yes**.

#### Krypton.Toolkit.Suite.Extended.IO
- Path: `Krypton.Toolkit.Suite.Extended.IO\...IO 2022.csproj`. 8 .cs.
- Deps: core dual; PRs → Debug.Tools, Developer.Utilities.
- Controls: `KryptonFileListBox : KryptonListBox`, `KryptonFileSystemTreeView : KryptonTreeView`, `KryptonSystemInformation : KryptonForm`.
- Status: "Main"; in Ultimate: **yes**.

#### Krypton.Toolkit.Suite.Extended.Memory.Box
- Path: `Krypton.Toolkit.Suite.Extended.Memory.Box\...Memory.Box 2022.csproj`. 7 .cs.
- Deps: core dual; PR → Common. Controls: dialog implemented via Common's forms (no direct Control subclass).
- Status: "Main"; in Ultimate: **yes**.

#### Krypton.Toolkit.Suite.Extended.Messagebox
- Path: `Krypton.Toolkit.Suite.Extended.Messagebox\...Messagebox 2022.csproj`. 23 .cs.
- Deps: core dual; PRs → Debug.Tools, Developer.Utilities, Shared.
- Controls: `KryptonMessageBoxManagerTest : Component`, `KryptonMessageBoxExtendedFormDevelopment : KryptonForm`, `KryptonMessageBoxConfiguratorDesigner : ControlDesigner` (+ static `KryptonMessageBoxExtended` API).
- Status: "Main"; in Ultimate: **yes**.

#### Krypton.Toolkit.Suite.Extended.MessageDialog
- Path: `Krypton.Toolkit.Suite.Extended.MessageDialog\Krypton.Toolkit.Suite.Extended.MessageDialog.csproj` (no " 2022" suffix). 4 .cs.
- TFMs: `$(ExtendedToolkitTFMs)` (static full list — only project not using the configuration-aware property).
- Deps: core dual; no module refs.
- Controls: `VisualMessageDialogForm : Form`, `VisualMessageDialogRtlAwareForm : Form`.
- Status: **only in the NuGet solution** (`... - NuGet.sln`), absent from the main solution; in Ultimate: **no**. Appears to be new/in-progress work.

#### Krypton.Toolkit.Suite.Extended.Navi.Suite
- Path: `Krypton.Toolkit.Suite.Extended.Navi.Suite\...Navi.Suite 2022.csproj`. 69 .cs.
- Deps: core dual; no module refs.
- Third-party lineage: the `Navi*` control family matches the historical open-source "NaviSuite" Outlook-style navigation library; all headers are Krypton Suite MIT with no upstream attribution retained.
- Controls (8): `NaviControl`/`NaviSuiteControl : ContainerControl`, `NaviControlCollection`, `NaviToolstripRenderer`, `NaviSuiteLanguageManager : Component`, `NaviBandPopup`, `NaviOptionsForm : KryptonForm`, `PopupWindowHelper : NativeWindow`.
- Status: "Main"; in Ultimate: **yes**.

#### Krypton.Toolkit.Suite.Extended.Navigator
- Path: `Krypton.Toolkit.Suite.Extended.Navigator\...Navigator 2022.csproj`. 24 .cs.
- Deps: core **NuGet-only** (Toolkit + Navigator); PR → Drawing.
- Controls: `KryptonNavigatorButton : KryptonButton`, `KryptonNavigatorEditor : KryptonNavigator`, `OutlookBar : Control`, `OutlookBarNavigationPaneOptions : KryptonForm`, `CustomButton : Button`.
- Status: "Main"; in Ultimate: **yes**.

#### Krypton.Toolkit.Suite.Extended.Networking
- Path: `Krypton.Toolkit.Suite.Extended.Networking\...Networking 2022.csproj`. 22 .cs.
- Deps: core dual; PRs → Common, Debug.Tools; package `System.DirectoryServices` 10.0.0.
- Controls (5): `KryptonNetworkDriveOptions`, `KryptonNetworkScanner`, `KryptonNetworkUtility`, `KryptonNetworkNodePicker`, `KryptonNodeViewer` (all KryptonForm).
- Status: "Main"; in Ultimate: **yes**.

#### Krypton.Toolkit.Suite.Extended.Notifications
- Path: `Krypton.Toolkit.Suite.Extended.Notifications\...Notifications 2022.csproj`. 27 .cs.
- Deps: core dual; PRs → Debug.Tools, Developer.Utilities.
- Controls (7): `KryptonToastNotificationManager`/`KryptonToastNotificationPopup : Component`, `KryptonAlertWindow`, `KryptonPopUpNotificationWindow`, `KryptonToastNotificationVersion1/2 : KryptonForm`, `InternalKryptonButtonPanel : UserControl`.
- Status: "Main"; in Ultimate: **yes**.

#### Krypton.Toolkit.Suite.Extended.Outlook.Grid
- Path: `Krypton.Toolkit.Suite.Extended.Outlook.Grid\...Outlook.Grid 2022.csproj`. 60 .cs.
- Deps: core dual; no module refs.
- Third-party: derived from **Cocotteseb/Krypton-OutlookGrid** — ~53 files carry the original header "Copyright (C) 2013-2021 JDH Software … Microsoft Public License (Ms-PL)" (e.g. `Classes\Custom Columns\DataGridViewPercentageCell.cs`). Attribution retained. Ms-PL obligations apply.
- Controls *(representative of 20)*: `KryptonOutlookGrid : KryptonDataGridView`, `OutlookGridRow : DataGridViewRow`, `KryptonOutlookGridGroupBox : UserControl`, `KryptonOutlookGridLanguageManager : Component`, tree/format/token column+cell types, `CustomFormatRule : KryptonForm`.
- Status: "Main" (root of sln); in Ultimate: **yes**.

#### Krypton.Toolkit.Suite.Extended.Palette.Selectors  *(README: "Under Development")*
- Path: `Krypton.Toolkit.Suite.Extended.Palette.Selectors\...Palette.Selectors 2022.csproj`. **1 .cs (GlobalDeclarations stub)**.
- Deps: core **stale-dual** (95.25.4.111). Controls: none.
- Status: **"Projects to Work On"**; in Ultimate: **no**. Confirmed under development (empty).

#### Krypton.Toolkit.Suite.Extended.Panels  *(README lists "Panel" as "Under Development")*
- Path: `Krypton.Toolkit.Suite.Extended.Panels\...Panels 2022.csproj`. 3 .cs.
- Deps: core dual; no module refs.
- Controls: `KryptonPanelExtended : KryptonPanel`, `KryptonButtonPanel : UserControl`.
- Status: solution folder **"Main"** ("Generate Packages"); in Ultimate: **yes**. Minimal but implemented — README flag partially stale.

#### Krypton.Toolkit.Suite.Extended.PDF
- Path: `Krypton.Toolkit.Suite.Extended.PDF\...PDF 2022.csproj`. **1 .cs (`Class1.cs` placeholder)**.
- Deps: core **stale-dual** (Release 95.25.4.111, Nightly 90.23.12.345-alpha). Controls: none.
- Status: **"Projects to Work On"**; in Ultimate: **no**. Empty stub; not flagged in the README table (README has no PDF row) — additional dormant module.

#### Krypton.Toolkit.Suite.Extended.Ribbon
- Path: `Krypton.Toolkit.Suite.Extended.Ribbon\...Ribbon 2022.csproj`. 6 .cs.
- Deps: core **NuGet-only** (Toolkit + Ribbon); PRs → Debug.Tools, Developer.Utilities.
- Controls: `KryptonRibbonGroupThemeComboBox : KryptonRibbonGroupComboBox`.
- Status: "Main"; in Ultimate: **yes**.

#### Krypton.Toolkit.Suite.Extended.Scintilla.NET
- Path: `Krypton.Toolkit.Suite.Extended.Scintilla.NET\...Scintilla.NET 2022.csproj`. **0 .cs — completely empty project**.
- Deps: core **stale-dual** (95.25.4.111). Controls: none.
- Status: **"Projects to Work On"**; in Ultimate: **no**. Placeholder for a future ScintillaNET wrapper.

#### Krypton.Toolkit.Suite.Extended.Security
- Path: `Krypton.Toolkit.Suite.Extended.Security\...Security 2022.csproj`. **1 .cs (`Class1.cs` placeholder)**.
- Deps: core NuGet refs with the **oldest pins in the repo** (Nightly 90.23.12.345-alpha, Canary 90.23.11.326-beta; Release 100.25.11.328).
- Status: **only in the NuGet solution**, absent from the main solution; in Ultimate: **no**. Empty stub.

#### Krypton.Toolkit.Suite.Extended.Software.Updater
- Path: `Krypton.Toolkit.Suite.Extended.Software.Updater\...Software.Updater 2022.csproj`. 49 .cs.
- Deps: core **stale-dual** (95.25.4.111); PRs → Common, Developer.Utilities, Software.Updater.Core; packages `System.Drawing.Common` 10.0.0, `ILRepack.Lib.MSBuild.Task` 2.0.44.1, `Microsoft.Web.WebView2` 1.0.3595.46, `System.Net.Http` 4.3.4, `ZipStorer` 4.2.0.
- Third-party: `Auto Updater\` is an adaptation of **AutoUpdater.NET** (upstream MIT © RBSoft/Ravi Patel) and `Sharp Update\` of the **SharpUpdate** sample — both **re-stamped with Krypton headers or no header; no upstream attribution retained** (licence-audit flag).
- Controls (8): `AutoUpdaterLanguageManager`/`SharpUpdateLanguageManager : Component`, `DownloadUpdateDialog`, `RemindLaterForm`, `UpdateDialog`, `SharpUpdateAcceptForm`, `SharpUpdateDownloadForm`, `SharpUpdateInfoForm` (KryptonForm).
- Status: **"Projects to Work On"**; in Ultimate: **no** (only its `.Core` sibling is bundled). (Backup csproj present in directory.)

#### Krypton.Toolkit.Suite.Extended.Software.Updater.Core
- Path: `Krypton.Toolkit.Suite.Extended.Software.Updater.Core\...Software.Updater.Core 2022.csproj`. 49 .cs.
- Deps: core **NuGet-only** (Toolkit, Navigator, Ribbon, Docking); PR → Developer.Utilities; packages `Newtonsoft.Json` 13.0.4, `Portable.BouncyCastle` 1.9.0, `WindowsAPICodePack` 8.0.12, dead-conditional `NSec.Cryptography` (as per Core).
- **PackageId bug:** declares `Krypton.Toolkit.Suite.Extended.Core[.Canary/.Nightly]` — collides with the real Core module. `GeneratePackageOnBuild=False`.
- Third-party: `NetSparkle\` is vendored **NetSparkleUpdater** source — headers retained: "Copyright(c) 2022 Deadpikle" (MIT) (e.g. `NetSparkle\AppCastHandlers\XMLAppCast.cs`).
- Controls: none (update engine).
- Status: "Shared"; in Ultimate: **yes**.

#### Krypton.Toolkit.Suite.Extended.Specialised.Dialogs
- Path: `Krypton.Toolkit.Suite.Extended.Specialised.Dialogs\...Specialised.Dialogs 2022.csproj`. 15 .cs.
- Deps: core dual; PRs → Debug.Tools, Global.Utilities, Common.
- Controls: `KryptonUACButton : KryptonButton`, `KryptonRunDialog : KryptonForm`.
- Status: "Main"; in Ultimate: **yes**.

#### Krypton.Toolkit.Suite.Extended.TaskDialogs
- Path: `Krypton.Toolkit.Suite.Extended.TaskDialogs\...TaskDialogs 2022.csproj`. **1 .cs (GlobalDeclarations stub)**.
- Deps: core **stale-dual** (95.25.4.111). Controls: none.
- Status: **"Projects to Work On"**; in Ultimate: **no**. Empty stub (not flagged in README).

#### Krypton.Toolkit.Suite.Extended.Theme.Switcher
- Path: `Krypton.Toolkit.Suite.Extended.Theme.Switcher\...Theme.Switcher 2022.csproj`. 16 .cs.
- Deps: core **NuGet-only** (Toolkit + Navigator); PRs → Debug.Tools, Developer.Utilities, Settings, Navigator; package `WindowsAPICodePackShell` 8.0.12.
- Controls (7): `ThemeSelector`, `ThemeSwitcherOptions` (+ `Old` variants), `DownloadThemePackage`, `KryptonExternalThemeSelectorForm`, `UploadThemeBrowser` (KryptonForm).
- Status: "Main"; in Ultimate: **yes**.

#### Krypton.Toolkit.Suite.Extended.Themes
- Path: `Krypton.Toolkit.Suite.Extended.Themes\...Themes 2022.csproj`. 2 .cs.
- Deps: core **stale-dual** (95.25.4.111); PR → Shared.
- Controls: `CustomPaletteBase : Component`.
- Status: **"Projects to Work On"**; in Ultimate: **no**. Minimal/dormant.

#### Krypton.Toolkit.Suite.Extended.ToastNotification
- Path: `Krypton.Toolkit.Suite.Extended.ToastNotification\...ToastNotification 2022.csproj`. 8 .cs.
- Deps: core dual; no module refs; packages `WindowsAPICodePackShell` + `WindowsAPICodePackShellExtensions` 8.0.12.
- Description is a copy/paste of the Buttons text ("holds extensions to the KryptonButton controls") — metadata bug.
- Controls: builder/definition classes (no direct Control subclass detected).
- Status: "Main" (root of sln); in Ultimate: **yes**. (Backup csproj present in directory.)

#### Krypton.Toolkit.Suite.Extended.Toggle.Switch  *(README: "Under Development")*
- Path: `Krypton.Toolkit.Suite.Extended.Toggle.Switch\...Toggle.Switch 2022.csproj`. 33 .cs.
- Deps: core **NuGet-only**; no module refs.
- Controls: `KryptonToggleSwitchVersion1 : Control`, `KryptonToggleSwitchVersion2 : Control` + a full renderer family (`ToggleSwitchRendererBase` and style renderers). Lineage matches the classic CodeProject/JohanH "ToggleSwitch" control; headers are Krypton MIT only.
- Status: solution folder **"Main"**; in Ultimate: **yes**. Substantially implemented — README flag stale.

#### Krypton.Toolkit.Suite.Extended.Tool.Box
- Path: `Krypton.Toolkit.Suite.Extended.Tool.Box\...Tool.Box 2022.csproj`. 15 .cs.
- Deps: core **NuGet-only**; PRs → Debug.Tools, Developer.Utilities.
- Controls: `KryptonToolBox : UserControl`.
- Status: "Main"; in Ultimate: **yes**.

#### Krypton.Toolkit.Suite.Extended.Tool.Strip.Items
- Path: `Krypton.Toolkit.Suite.Extended.Tool.Strip.Items\...Tool.Strip.Items 2022.csproj`. 39 .cs.
- Deps: core **NuGet-only**; PRs → Debug.Tools, Global.Utilities.
- Controls *(representative of 30)*: `KryptonToolStrip`/`KryptonEnhancedToolStrip : ToolStrip`, `KryptonStatusStrip : StatusStrip`, `KryptonThemeComboBox : ToolStripComboBox`, `KryptonLoadingCircle : Control`, many `ToolStripControlHost` wrappers (DateTimePicker, NumericUpDown, TrackBar, BrowseBox, TextBox, Slider), MRU menu items, `ToolStripProgressBarWithValueText`.
- Status: "Main"; in Ultimate: **yes**.

#### Krypton.Toolkit.Suite.Extended.TreeGridView
- Path: `Krypton.Toolkit.Suite.Extended.TreeGridView\...TreeGridView 2022.csproj`. 15 .cs.
- Deps: core **NuGet-only**; no module refs.
- Controls: `KryptonTreeGridView : KryptonDataGridView`, `KryptonTreeGridNodeRow : DataGridViewRow`, `KryptonTreeGridCell`, `KryptonTreeGridColumn`.
- Status: "Main"; in Ultimate: **yes**.

#### Krypton.Toolkit.Suite.Extended.VirtualTreeColumnView
- Path: `Krypton.Toolkit.Suite.Extended.VirtualTreeColumnView\...VirtualTreeColumnView 2022.csproj`. 9 .cs.
- Deps: core dual; PR → Shared.
- Controls: `KryptonVirtualTreeColumnView : VisualSimpleBase`, `InternalTreeColumnView : UserControl`.
- Status: "Main" ("Miscellaneous"); in Ultimate: **yes**.

#### Krypton.Toolkit.Suite.Extended.Wizard
- Path: `Krypton.Toolkit.Suite.Extended.Wizard\...Wizard 2022.csproj`. 18 .cs.
- Deps: core **NuGet-only**; PRs → Debug.Tools, Developer.Utilities.
- Controls: `KryptonAdvancedWizard : UserControl`, `KryptonAdvancedWizardPage : KryptonPanel` (+ designers `DesignTimeWizard`, `RuntimeWizard`).
- Status: "Main"; in Ultimate: **yes**.

### 2.3 Meta-packages

#### Krypton.Toolkit.Suite.Extended.Ultimate
- Path: `Krypton.Toolkit.Suite.Extended.Ultimate\Krypton.Toolkit.Suite.Extended.Ultimate 2022.csproj`. `GeneratePackageOnBuild=True`; PackageIds `...Ultimate` / `.Canary` / `.Nightly`.
- References **51 module projects** (all of §2.1 and §2.2 except the ten listed in §4.2) plus core `Krypton.Toolkit/Navigator/Ribbon/Docking` 100.25.11.328 from NuGet. Directory.Build.targets bundles every referenced assembly into the nupkg — this is the "all-in-one" DLL set consumed as `Krypton.Toolkit.Suite.Extended.Ultimate` 105.26.4.114.

#### Krypton.Toolkit.Suite.Extended.Ultimate.Lite
- Path: `Krypton.Toolkit.Suite.Extended.Ultimate.Lite\...Ultimate.Lite 2022.csproj`. Identical 51-project reference list; intended for the Lite TFM set (drops net472).

### 2.4 Applications (not packaged)

| Project | Path | TFMs | Notes |
|---|---|---|---|
| Examples | `Examples\Examples.csproj` | net481;net8.0-windows | WinExe; references 47 module projects + `System.Data.SQLite.Core` 1.0.119; also stale `Reference` to an ADGV obj-path DLL. |
| AutoUpdateCreator | `AutoUpdateCreator\AutoUpdateCreator.csproj` | net481;net8.0-windows | WinExe; PR → Wizard; stale core pins (95.25.4.111). |
| ZipExtractor | `ZipExtractor\ZipExtractor.csproj` | net481;net8.0-windows | WinExe; PRs → Debug.Tools, Developer.Utilities; `Portable.BouncyCastle`, `System.IO.Compression` 4.3.0, `System.Private.Uri` 4.3.2, NSec 25.4.0 (net8.0-windows condition). |

---

## 3. Third-party / vendored source and licences

| Module | Vendored source | Upstream / licence | Attribution state |
|---|---|---|---|
| Data.Visualisation | `Scott Plot\**` (~344 files) | **ScottPlot 5** — MIT (© Scott Harden & contributors) | **Not retained** — headers/namespace rewritten to Krypton; `License\License.txt` is Krypton's own MIT. **Action: restore upstream MIT notice.** |
| Outlook.Grid | `Classes\**` (~53 files) | **Krypton-OutlookGrid** (Cocotteseb / JDH Software) — **Ms-PL** | Retained in file headers. Ms-PL redistribution terms apply. |
| AdvancedDataGridView | `Controls Toolkit\**` (~12 files) | **ADGV / Zuby.AdvancedDataGridView** — **Ms-PL** | Retained (full Ms-PL text in headers). |
| Software.Updater.Core | `NetSparkle\**` | **NetSparkleUpdater** — MIT (© 2022 Deadpikle) | Retained in headers. |
| Software.Updater | `Auto Updater\**`, `Sharp Update\**` | **AutoUpdater.NET** (MIT, © RBSoft) and **SharpUpdate** | **Not retained** — Krypton headers or none. **Action: verify and restore.** |
| Utilities | `Classes\System\SAPI\**` (bulk of 340 files) | .NET **System.Speech** reference source — MIT (.NET Foundation) | **Not retained** — re-stamped Krypton MIT. **Action: restore .NET Foundation notice.** |
| Drawing.Utilities | Colour-picker controls; `ImageBoxExtended.cs` | **Cyotek.Windows.Forms.ColorPicker** / **ImageBox** — MIT (© Richard Moss); gGlowBox — CodeProject (likely **CPOL**) | Comment-level acknowledgement only. CPOL fragment needs review. |
| Common / Forms / Utilities | `AllowNullAttribute.cs` | .NET Foundation — MIT | Retained. |
| Toggle.Switch | whole control family | CodeProject "ToggleSwitch" lineage (JohanH) | Not attributed (headers Krypton MIT). |
| Navi.Suite | whole control family | historical open-source "NaviSuite" navigation library | Not attributed (headers Krypton MIT). |
| Circular.ProgressBar | control + `Unofficial.WinFormAnimation` 2.0.2 pkg | falahati **CircularProgressBar**/**WinFormAnimation** — MIT | Consumed as NuGet repack; control source not attributed. |

Third-party **NuGet packages** (binary dependencies, exact versions): `WindowsAPICodePack`/`Shell`/`ShellExtensions` 8.0.12 (Buttons, ToastNotification, Core, Settings, Developer.Utilities, Dialogs, File.Copier, Theme.Switcher, Software.Updater.Core); `Newtonsoft.Json` 13.0.4 and `Portable.BouncyCastle` 1.9.0 (Core, Software.Updater.Core, ZipExtractor); `NSec.Cryptography` 24.4.0/23.9.0-preview.3/25.4.0 (dead TFM conditions in Core and Software.Updater.Core; live 25.4.0 in ZipExtractor); `SkiaSharp` + `SkiaSharp.Views.WindowsForms` 3.119.1 and `NETStandard.Library` 2.0.3 (Data.Visualisation); `Unofficial.Cyotek.Windows.Forms.NET` 2.0.1 (Drawing.Utilities); `Unofficial.WinFormAnimation` 2.0.2 (Circular.ProgressBar); `Handlebars.Net` 2.1.6, `ProDotNetZip` 1.20.0, `Simple-MAPI.NET` 1.2.1, `System.Management` 10.0.0 (Error.Reporting); `System.Speech` 10.0.0 (Dialogs); `System.DirectoryServices` 10.0.0 (Networking); `Microsoft.Web.WebView2` 1.0.3595.46, `ZipStorer` 4.2.0, `ILRepack.Lib.MSBuild.Task` 2.0.44.1, `System.Net.Http` 4.3.4, `System.Drawing.Common` 10.0.0 (Software.Updater); `System.Data.SQLite.Core` 1.0.119 (Examples).

Also flagged: repo root `LICENSE` = MIT, but `Directory.Build.targets` stamps packages `PackageLicenseExpression=BSD-3-Clause`, and file headers mix "BSD-style" and MIT boilerplate.

---

## 4. Status: Ultimate membership and under-development modules

### 4.1 "Under Development" verification (README historical flags)

README (`D:\Krypton-Ultimate\Extended-Toolkit\README.md`, Modules table) flags six modules. Actual state on `bastion/multitarget`:

| README flag | Project exists? | Actual state | In "Projects to Work On" sln folder? | In Ultimate? |
|---|---|---|---|---|
| Dock Extender | Yes (`...Dock.Extender`) | Implemented but small (9 .cs, 2 forms + DockExtender logic) | No — "Main" | **Yes** |
| File Explorer | Yes (`...File.Explorer`) | **Empty stub** (1 .cs, GlobalDeclarations only) | **Yes** | No |
| Gauges | Yes (`...Gages`, assembly `...Guages`) | **Empty stub** (1 .cs) | **Yes** | No |
| Palette Selectors | Yes (`...Palette.Selectors`) | **Empty stub** (1 .cs) | **Yes** | No |
| Panel | Yes (`...Panels`) | Minimal but implemented (2 controls) | No — "Main" | **Yes** |
| Toggle Switch | Yes (`...Toggle.Switch`) | Substantially implemented (33 .cs, 2 controls + renderers) | No — "Main" | **Yes** |

**Additional under-development/dormant modules found in-source** (all in the "Projects to Work On" solution folder unless noted, all excluded from Ultimate): **PDF** (1-file stub), **Scintilla.NET** (0 source files), **TaskDialogs** (1-file stub), **Themes** (2 .cs, minimal), **Tools** (1-file stub — yet still referenced by Ultimate), **Software.Updater** (functional but parked in "Projects to Work On"; only `.Core` ships in Ultimate), **Security** (1-file stub; NuGet sln only), **MessageDialog** (4 .cs; NuGet sln only). The README's "Fast Coloured TextBox" module **no longer exists** on this branch (no project, zero source references).

### 4.2 Ultimate package membership

**Included (51 projects):** Core, Common, Shared, Developer.Utilities, Global.Utilities, Utilities, Tools, CheckSum.Tools, Drawing, Drawing.Utilities, Effects, Settings, Resources, Language.Model, Controls, Buttons, ComboBox, Toggle.Switch, Circular.ProgressBar, Panels, DataGridView, AdvancedDataGridView, TreeGridView, VirtualTreeColumnView, Outlook.Grid, Data.Visualisation, Dialogs, Specialised.Dialogs, InputBox, Messagebox, ToastNotification, Notifications, Navigator, Navi.Suite, Wizard, Ribbon, Floating.Toolbars, Tool.Strip.Items, Tool.Box, Dock.Extender, Theme.Switcher, Forms, Calendar, IO, File.Copier, Compression, Networking, Software.Updater.Core, Error.Reporting, Debug.Tools, Memory.Box.

**Excluded (10 module projects):** File.Explorer, Gages, Palette.Selectors, PDF, Scintilla.NET, Security, Software.Updater (full), TaskDialogs, Themes, MessageDialog.

---

## 5. Dependency-order build list (Phase 2)

Topological levels computed from inter-module `ProjectReference`s (each level depends only on earlier levels; the Standard-Toolkit core — Krypton.Toolkit, and where needed Navigator/Ribbon/Docking — must be built before Level 0). No cycles were detected.

**Level 0** (no inter-module deps): Debug.Tools, Shared, Drawing, Effects, Calendar, ComboBox, Compression, DataGridView, Dock.Extender, Error.Reporting, Floating.Toolbars, Navi.Suite, Outlook.Grid, Panels, ToastNotification, Toggle.Switch, TreeGridView, MessageDialog; *(stubs, if built)* File.Explorer, Gages, Palette.Selectors, PDF, Scintilla.NET, Security, TaskDialogs, Tools.

**Level 1:** Developer.Utilities, Forms, Navigator, Themes, VirtualTreeColumnView.

**Level 2:** AdvancedDataGridView, Circular.ProgressBar, Common, Controls, File.Copier, Global.Utilities, IO, Language.Model, Messagebox, Notifications, Ribbon, Software.Updater.Core, Tool.Box, Utilities, Wizard.

**Level 3:** CheckSum.Tools, Memory.Box, Networking, Settings, Software.Updater, Specialised.Dialogs, Tool.Strip.Items.

**Level 4:** Core, Dialogs, InputBox, Resources, Theme.Switcher.

**Level 5:** Buttons, Data.Visualisation.

**Level 6:** Drawing.Utilities.

**Level 7:** Ultimate, Ultimate.Lite.

*(Applications last: Examples, AutoUpdateCreator, ZipExtractor.)*

Key edges driving the ordering: nearly everything → Debug.Tools/Developer.Utilities/Shared; Settings → Common → Effects/Shared; Core → Controls + Global.Utilities + Settings + Shared; Buttons → Core; Data.Visualisation → Core; Drawing.Utilities → Buttons + Core + Common + Controls + Floating.Toolbars + Messagebox; Dialogs → CheckSum.Tools + Forms + Utilities + Common + Controls + Settings + Global.Utilities; Theme.Switcher → Navigator + Settings.

---

## 6. Summary tables

### 6.1 Headline counts

| Metric | Count |
|---|---|
| Module library projects | **61** |
| Meta-package projects (Ultimate, Ultimate.Lite) | 2 |
| Application projects | 3 |
| Stale backup csproj files | 4 |
| Modules bundled in Ultimate/Ultimate.Lite | **51** |
| Modules excluded from Ultimate | 10 |
| Empty/stub modules (≤1 source file) | 8 (File.Explorer, Gages, Palette.Selectors, PDF, Scintilla.NET, Security, TaskDialogs, Tools) |
| Modules in "Projects to Work On" sln folder | 9 (the above minus Security, plus Themes, Software.Updater) |
| Modules with vendored third-party source | 8+ (see §3) |
| Modules that consume core Krypton **only** via NuGet (rewiring needed) | **12** modules + 2 meta-packages (§1.3) |

### 6.2 Third-party licence summary

| Licence | Where | Risk note |
|---|---|---|
| Ms-PL | Outlook.Grid, AdvancedDataGridView (vendored) | Attribution retained; Ms-PL is not MIT/BSD-compatible for relicensing — keep headers. |
| MIT (attribution retained) | NetSparkle (Software.Updater.Core), .NET Foundation attribute files | Compliant. |
| MIT (attribution stripped) | **ScottPlot** (Data.Visualisation), **AutoUpdater.NET/SharpUpdate** (Software.Updater), **System.Speech reference source** (Utilities), Cyotek-derived controls (Drawing.Utilities), Toggle.Switch, Navi.Suite, Circular.ProgressBar lineages | **Non-compliant with MIT attribution clause — restore upstream notices in Bastion.** |
| CPOL (probable) | gGlowBox fragment in `Drawing.Utilities\Controls\Components\ImageBoxExtended.cs` | CPOL is incompatible with MIT/BSD redistribution — review/replace. |
| Repo licence mismatch | Root `LICENSE` = MIT vs `Directory.Build.targets` `PackageLicenseExpression=BSD-3-Clause` | Pick one and align headers. |

### 6.3 Modules referencing core Krypton via NuGet (Release versions)

| Version pin | Modules |
|---|---|
| 100.25.11.328 (current wave) | All maintained modules (NuGet-solution branch) + the 12 NuGet-only projects + Ultimate/Ultimate.Lite |
| 95.25.4.111 (stale) | File.Explorer, Gages, PDF, Scintilla.NET, Software.Updater, TaskDialogs, Themes, AutoUpdateCreator |
| 90.23.x pre-release (very stale) | Security (Nightly/Canary), PDF (Nightly) |
| 95.25.10.293 | Fallback ("Otherwise") branch in every dual-mode project |
| 90.25.2.55 `.Lite` / 65.22.6.152 `.Signed[.Lite]` | Lite/Signed configuration branches of the NuGet-only projects (legacy channels) |

### 6.4 Notable anomalies

1. `Gages` module ships as assembly/package **`Guages`** (double misspelling; README says "Gages", English is "Gauges").
2. `Software.Updater.Core` declares the **PackageId of the Core module** (copy/paste bug).
3. `ToastNotification` csproj Description is a copy of the Buttons description.
4. `NSec.Cryptography` PackageReferences in Core/Software.Updater.Core are conditioned on `net6.0-windows`/`net7.0-windows`/`net8.0-windows` — none of which match the actual TFMs (`net8.0-windows7.0` etc.), so they never resolve.
5. `Tools` is an empty stub yet is referenced by (and bundled into) Ultimate; conversely the functional `Software.Updater` is excluded.
6. Examples.csproj carries a stale direct `<Reference>` to `AdvancedDataGridView\obj\Nightly\net462\...dll`.
7. The dual-mode core referencing hardwires a **sibling-directory Standard-Toolkit checkout** (`..\..\..\..\Standard-Toolkit\...`) — matches the Bastion workspace layout, and is the natural seam for Phase 2's all-ProjectReference rewiring.
8. csproj descriptions claim support ".NET Framework 4.6.2 - 4.8.1" but the lowest actual TFM is net472.
