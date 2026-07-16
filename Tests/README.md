# Bastion Krypton Suite — test suite (spec §6)

© Bastion Software Solutions Ltd 2026. New (Bastion) work in a repository derived from
BSD-3-Clause licensed code (Component Factory Pty Ltd; Krypton-Suite et al.).

Phase 5a scaffolding: the permanent test-suite structure of spec §6.1. The adversarial
content (§6.3) lands in Phase 5c; the full-matrix sweep is Phase 5d.

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
| `Bastion.Krypton.StressTests` | Adversarial suite shell (§6.3) — helpers wired, one harness smoke test. Content lands in Phase 5c. |
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
