# Bastion Krypton Suite — test suite (spec §6)

© Bastion Software Solutions Ltd 2026. New (Bastion) work in a repository derived from
BSD-3-Clause licensed code (Component Factory Pty Ltd; Krypton-Suite et al.).

Phase 5a scaffolding: the permanent test-suite structure of spec §6.1. Phase 5b adds
`Bastion.Krypton.FunctionalTests` (per-control functional coverage, spec §6.2). Phase 5c
fills `Bastion.Krypton.StressTests` with the adversarial suite (§6.3); the full-matrix
sweep is Phase 5d.

## Framework decision

**NUnit 3.14.0 + NUnit3TestAdapter 4.6.0 + Microsoft.NET.Test.Sdk 17.14.1**, chosen over:

- **NUnit 4.x** — its minimum .NET Framework target is net462; this suite must run on net46
  (the Bastion-added TFM floor).
- **xUnit** — has no in-box STA support; WinForms tests need STA + a message pump, and xUnit
  requires a third-party package (`Xunit.StaFact`) to get it. NUnit needs nothing extra: the
  suite runs its WinForms bodies through its own `StaMessagePump` helper regardless of runner
  threading.

Package restore and a warning-clean build were verified for this exact package set on **all
11 TFMs** (`net46;net47;net472;net48;net481;net5.0-windows;net6.0-windows;net7.0-windows;net8.0-windows;net9.0-windows;net10.0-windows`).

### net46 runner mechanism (verified fallback)

`Microsoft.NET.Test.Sdk` 17.x and `NUnit3TestAdapter` 4.x both floor at **net462** — they do
not restore for net46. Therefore:

- **net47 … net10.0-windows** run through `dotnet test` (VSTest + NUnit3TestAdapter), TRX
  results.
- **net46** builds as a **self-executing NUnitLite 3.14.0 console runner**
  (`OutputType=Exe` + an `NUnitLiteMain` entry point compiled only for net46;
  `bin\Release\net46\<project>.exe`). Results are NUnit3 XML (`TestResult.xml`) — NUnitLite
  cannot write TRX. Exit code = number of failed tests.

Both mechanisms are wired into `run-tests.ps1`, which picks the right one per TFM.

### Other build decisions

- **Desktop MSBuild** builds the projects (`run-tests.ps1` locates it via `vswhere`,
  always `/nr:false`); consistent with the Phase 2 finding that net46 targets build under
  desktop MSBuild. Test runs use `dotnet test --no-build` against those outputs.
- net5/6/7 are EOL and gated by `Microsoft.NET.Test.Sdk`/the 9.x runtime packages with a
  "doesn't support" build error/warning; supporting them is an explicit Bastion goal, so
  `SuppressTfmSupportBuildErrors`/`SuppressTfmSupportBuildWarnings` are set for exactly those
  TFMs in `Directory.Build.props`.
- `TreatWarningsAsErrors=true` everywhere; the five core assemblies are referenced per-TFM
  from `..\Standard-Toolkit\Bin\Release\<tfm>\` (the SmokeTest pattern, including the net46
  `System.ValueTuple`/`System.Memory` and net47+ `System.Resources.Extensions` handling).

## Layout

| Project | Purpose |
|---|---|
| `Bastion.Krypton.UnitTests` | Regression/unit tests + the shared UI test infrastructure (`Infrastructure\`: `StaMessagePump`, `HandleCounter`, `ScreenshotOnFailure`/`UiTestBase`). Referenced by the other test projects for those helpers. |
| `Bastion.Krypton.FormsTests` | C# generated family forms — every instantiable public control of the five core assemblies on real forms via designer-style `InitializeComponent` code — shown, pumped, resized, palette-switched, disposed, handle-stability asserted. |
| `Bastion.Krypton.FormsTests.VB` | The VB.NET variant of the same (the VB designer path must compile and run). |
| `Bastion.Krypton.FunctionalTests` | Phase 5b per-control functional coverage (spec §6.2): reflection + `TestCaseSource` — one test case per public `Component` type of the five core assemblies. See below. |
| `Bastion.Krypton.StressTests` | Phase 5c adversarial suite (spec §6.3) — see the dedicated section below. |
| `Tools\FormsTestGen` | Generator for the `Generated\` form sources (see below). |
| `run-tests.ps1` | Build + run a project × TFM; `-All` sweeps the functional projects across all 11 TFMs and prints a summary table. |
| `artifacts\<project>\<tfm>\` | TRX / NUnit3 XML results and failure screenshots (git-ignored). |

## Starter regression tests (lock in the Phase 2/3 fixes)

- `PaletteImageSetResolverTests` — every `PaletteMode` classifies without an exception, plus
  spot-checks of the nine modes the old duplicated switches crashed on (BREAKAGE-LOG T1).
- `PaletteModeContractTests` — the `PaletteMode` enum ↔ `PaletteModeStrings.SupportedThemes`
  positional ordering contract (upstream #1328): same member set, position i ⇔ enum value i,
  contiguous values, `Custom` last.
- `GlobalPaletteModeRoundTripTests` — every `PaletteMode` round-trips through
  `KryptonManager.GlobalPaletteMode` set/get without exception (STA + message pump).
- `DisposeWhileFocusedTests` — the six dispose-time NRE bugs from BREAKAGE-LOG items 1-2:
  `KryptonComboBox`, `KryptonListView`, `KryptonListBox`, `KryptonCheckedListBox`,
  `KryptonTreeView`, `KryptonPropertyGrid` created on a shown form, focused, then disposed —
  no exception (the STA thread runs with thread-scoped
  `UnhandledExceptionMode.ThrowException`, so WndProc exceptions fail the test).

KryptonCalendar/CircularProgressBar/fade regressions (BREAKAGE-LOG E-series) are
Extended-Toolkit scope and deliberately not here — this suite references the core assemblies
only.

## FunctionalTests (Phase 5b — spec §6.2)

The exact §6.2 recipe, per public `Component` type, discovered by reflection at run time
(no generated source) with NUnit `TestCaseSource` so every type is a separate test case:

1. **Instantiate** — types without a public parameterless ctor are skipped and counted.
2. **Place on a real shown `KryptonForm`**, pump. `Form`-derived types are shown as their own
   top-level window; `Component`-but-not-`Control` types (and top-level controls such as
   `ToolStripDropDown`-derived ones) get instantiate + dispose only, per the spec.
3. **Verify default render** — `DrawToBitmap`, assert no exception and a non-uniform paint.
   Blank-by-design controls (empty panels, image-less picture box, empty grids/workspaces,
   auto-size labels with empty text, the ActiveX web browser) are on an explicit allow-list
   in `SweepPolicy.cs`, each entry with a justification; for those "no exception" is the
   assertion.
4. **Property sweep** — every public writable instance property set to a typical value by
   type (`TypicalValues.cs`: string→"Sample", numerics→1 clamped into a sibling
   Minimum/Maximum range, bool→toggle, enum→first non-default member, Color→Red, Font/Image
   → fresh instances, plus a few per-name format contracts such as `Rtf` and `StarSize`);
   read back where readable. Skip-list (`SweepPolicy.cs`, justified per entry): designer
   context (`Site`, `WindowTarget`), topology hazards (`Parent`, `TopLevel`, `MdiParent`),
   data-dependent members (`SelectedIndex` …) and documented by-design setter rejections.
5. **Method sweep** — public instance methods declared by the Krypton assemblies whose
   parameters are all mappable safe primitives. Deny-list with justifications: the
   Dispose/Close/Hide/Show families, `*Dialog*`, `Print*`, clipboard verbs, `*File*` I/O,
   out/ref parameters, and empty-collection index contracts.
6. **Dispose**, pump, assert **GDI/USER handle deltas** within tolerance across a second
   full lifecycle (the first lifecycle warms static palette/font/image caches).
7. **Finalizer sweep at fixture end** — `GC.Collect`/`WaitForPendingFinalizers` under a
   first-chance exception trap filtered to finalizer frames; any finalizer-thread exception
   fails the fixture.

Sweep statistics (types by kind, properties set/skipped, methods invoked/skipped) are
printed at fixture teardown. Failures carry a structured message: control type + member +
value + exception. Findings triage: BREAKAGE-LOG.md "Phase 5b functional-sweep findings".

## StressTests (Phase 5c — spec §6.3, the adversarial suite)

One fixture per §6.3 attack category. Shared plumbing in `AttackHarness.cs`: STA body wrapper
(message pump + `Application.ThreadException` trap + global-palette reset + watchdog), the
structured `AttackFailure` record, and the **acceptance rule**: under attack a control may
reject an absurd value with a contract exception (Argument*/Format/NotSupported/
ObjectDisposed/InvalidOperation — *graceful*), but defect-class exceptions (NRE,
index-out-of-range, unguarded arithmetic, invalid casts, access violations) always fail.
Justified per-entry exclusions live in `AdversarialPolicy.cs` (same rule as 5b's
`SweepPolicy`).

| §6.3 | Fixture | Attack |
|---|---|---|
| 1 | `ExtremePropertyValueTests` | Text/size/location/padding/font extremes (`int.MaxValue`/`MinValue`, negatives, zero, 1pt/500pt fonts, empty + 1MB strings, RTL, surrogate pairs, control chars, embedded NUL) against every hosted control (5b catalogue reuse) + zero/negative-size `KryptonForm`. |
| 2 | `NullAndDisposalAbuseTests` | Null into every Image/Icon/PaletteBase-typed writable property; property sets after `Dispose` (ObjectDisposedException or benign); dispose-mid-paint (from inside the control's own `Paint`); double-dispose over the whole catalogue; members of controls whose parent form was disposed; null global/local custom palettes. |
| 3 | `ThemeSwitchStormTests` | One form hosting **every** hosted control; all concrete palette modes cycled while resizing; asserts no paint exceptions, stable GDI/USER handles, and a bounded working set (fails when the last 10 GC-settled samples grow strictly monotonically by a material amount). 3 rounds default; **25 rounds `[Category("Endurance")]`** (reduced spec figure — see the endurance decision record below). `Global`/`Custom` are excluded from the cycle by design (indirection / needs a palette instance). |
| 4 | `ThreadingMisuseTests` | Property sets from a worker thread with `CheckForIllegalCrossThreadCalls=true` — asserts the *documented* behaviour (cross-thread `InvalidOperationException` or benign completion), watchdog against deadlock; plus the correct `Control.Invoke` marshalling pattern. |
| 5 | `RtlAndDpiTests` | Key controls under `RightToLeft=Yes` + `RightToLeftLayout=true` with RTL text, rendered and resized; the WinForms scaling pipeline (`Form.Scale`) at the 120/144/192-DPI ratios with renders and a scale-back round-trip. **Honest scope note:** process DPI awareness is fixed at CLR start — real 96/120/144/192-DPI runs and PerMonitorV2 manifest variants cannot be varied in-proc and belong to the Phase 5d/CI matrix (per-DPI-context child processes). |
| 6 | `RibbonDockingScaleTests` | 300 ribbon tabs × groups with selection sweep + minimise toggle; 12-level nested workspace; docking config (4 edges + auto-hidden + floating + workspace fillers) save→load→re-save with page-universe comparison; **corrupted XML battery** (truncations, wrong root, invalid attribute values, not-XML, 10 seeded byte-flip variants, seed 12345) against the docking and workspace loaders — must fail gracefully (catchable), never defect-class/hang. |
| 7 | Extended fixtures (below) | Outlook/Tree/Data grids at scale, wizard abuse, toast spam, calendar torture. |
| 8 | `SerialisationRoundTripTests` | Persistence-API round-trips: custom palette Export→Import→re-Export stability (volatile date metadata normalised), workspace layout into a **fresh** instance with a topology signature comparison, plus the corruption battery against the palette importer. **Honest scope note:** the full CodeDom designer-serialisation round-trip is deferred — it requires the designer host/loader stack (`IDesignerHost`, `CodeDomComponentSerializationService`) plus a compile step, which is a VS integration scenario that cannot be executed faithfully headless across 11 TFMs. The components' own XML persistence APIs above are the runtime-reachable serialisation surface. |
| 9 | `RapidCreateDestroyTests` | Create/show/dispose cycles per family (Toolkit/Ribbon/Navigator/Workspace/Docking), handle-stability asserted after GC settle. **500 cycles default; 2,500 `[Category("Endurance")]`** (reduced spec figure — see the endurance decision record below). |

### Categories and selection

Every 5c fixture is `[Category("Adversarial")]`; the extra-long variants are additionally
`[Category("Endurance")]`. `run-tests.ps1 -Category` selects:

```powershell
Tests\run-tests.ps1 -Project StressTests -Tfm net48                       # Default: everything except Endurance
Tests\run-tests.ps1 -Project StressTests -Tfm net48 -Category Endurance   # only the endurance tests
Tests\run-tests.ps1 -Project StressTests -Tfm net48 -Category All         # both
```

(net46 maps the filter to NUnitLite `--where "cat != Endurance"` / `--where "cat == Endurance"`.)

### Endurance figures — decision record (Phase 5c)

Two spec §6.3 endurance counts were reduced after measuring real costs on the reference
machine (figures below); the endurance variants remain far beyond the always-run smoke
counts and keep their assertion power:

- **Theme storm: 100 → 25 rounds.** One round (62 palette switches + resize + full GC)
  costs ~25 s on net8 / ~55 s on net48, so 100 rounds (~45/~90 min) exceeds the net48
  test watchdog itself. 25 rounds (1,550 switches) still exercises the 10-sample
  working-set leak window 2.5× over.
- **Rapid create/destroy: 10,000 → 2,500 cycles per family.** Measured 53–133 ms/cycle
  means 10,000 cycles cost 9–22 min per family (≈55–85 min per TFM) for no additional
  assertion power: at 2,500 cycles any leak of one handle per ~39 cycles still breaches
  the 64-handle slack (the `ShadowManager` leak this fixture caught was 4 per cycle and
  fails inside the 500-cycle smoke variant).

The Extended 100k-row/node grid endurance variants are unchanged.

### Extended-module scope (spec v1.1 §6.3.7) — decision record

The Extended fixtures (`Extended\*.cs`: `KryptonOutlookGrid` 10k/100k rows + grouping churn +
row mutation inside `Paint`; `KryptonTreeGridView` 10k/100k nested nodes + expand/collapse
churn; the DataGridView module's rating/percentage cell types at scale + sort churn + paint
mutation; `KryptonAdvancedWizard` navigation abuse incl. dispose inside `PageChanged`;
`KryptonToastNotificationPopup` spam (150 queued, hidden/disposed mid-animation, handle
check); `KryptonCalendar` extreme date ranges + RTL/non-Gregorian culture switches) are
compiled **only for net48 + net8.0-windows** (`BASTION_EXTENDED`), referencing the module
DLLs from `Extended-Toolkit\Bin\Release\<module>\<tfm>\`.

Rationale: the modules' dependency closures (Shared/Debug.Tools/Developer.Utilities +
WindowsAPICodePack native-shell interop + per-TFM facade sets) would have to be wired and
kept green for all 11 TFMs to buy no additional attack coverage — the module code is
TFM-uniform C# and the Extended smoke matrix already proves per-TFM loadability. net48 +
net8.0-windows are the Framework/modern mainline pair (§6.4). The Master/Detail composite
views of the DataGridView module need designer-bound master-detail DataSets and are not
attacked headless; the module's cell/column types are. Toast attacks use the
Notifications module's `KryptonToastNotificationPopup` (a component with a real
animate/dismiss lifecycle); the ToastNotification module's static show-helpers are modal
UI and unsuited to unattended runs.

## Generated forms (FormsTestGen)

`Tools\FormsTestGen` reflects over the five core assemblies (net8.0-windows leg), groups
public `Component` types by assembly, and emits one designer-style form per family — real
fields, `SuspendLayout`/`ResumeLayout`, grid layout for controls, sited fields for
non-control components — in both C# and VB. Skipped (recorded in each file's banner):
Form-/ToolStripDropDown-/TabPage-derived types, which cannot be parented to a plain form.

Generated code is **committed**; regenerate rather than hand-edit:

```powershell
dotnet run --project Tests\Tools\FormsTestGen
```

Current output (net8.0-windows leg):

| Family | Controls on form | Non-control components | Skipped |
|---|---:|---:|---:|
| Krypton.Toolkit | 63 | 131 | 5 (Form-derived) |
| Krypton.Ribbon | 2 | 29 | 0 |
| Krypton.Navigator | 2 | 1 | 0 |
| Krypton.Workspace | 2 | 1 | 0 |
| Krypton.Docking | 5 | 1 | 0 |

## Running

```powershell
# One project × TFM (default: UnitTests × net8.0-windows)
Tests\run-tests.ps1 -Project FormsTests -Tfm net48

# net46 goes through the NUnitLite exe automatically
Tests\run-tests.ps1 -Project UnitTests -Tfm net46

# Sweep the three functional projects across all 11 TFMs (Phase 5d)
Tests\run-tests.ps1 -All
```

## Phase 5a verification (16 July 2026)

All four projects build warning-clean for all 11 TFMs (desktop MSBuild 18.7.8, `/nr:false`).
Runs (all green):

| Project | net46 | net48 | net8.0-windows |
|---|---|---|---|
| UnitTests | 31/31 | 31/31 | 31/31 |
| FormsTests | 6/6 | 6/6 | 6/6 |
| FormsTests.VB | 6/6 | 6/6 | 6/6 |
| StressTests (placeholder) | 1/1 | — | 1/1 |
