# Test Matrix — Bastion Krypton Suite (Phase 5)

Generated 16 July 2026. Runner: `Tests\run-tests.ps1` (desktop MSBuild build; `dotnet test` on
net47–net10, self-executing **NUnitLite** console runners on net46 and net5/6/7 — the latter because
`dotnet test`'s testhost launches via the system muxer, which cannot see the private legacy runtimes
in `Tools\dotnet-legacy\`; the NUnitLite exes run on the true runtime instead). Framework: NUnit 3.14.

## Functional suite — every TFM (spec §6.4)

All four functional projects pass on all eleven TFMs — **44/44 runs, 0 failures.**

| Project | Purpose | Tests | net46 | net47 | net472 | net48 | net481 | net5 | net6 | net7 | net8 | net9 | net10 |
|---|---|---|---|---|---|---|---|---|---|---|---|---|---|
| UnitTests | regression locks (T1 resolver, enum↔dictionary contract, palette round-trip, 6 dispose-NRE repros) | 31 | ✅ | ✅ | ✅ | ✅ | ✅ | ✅ | ✅ | ✅ | ✅ | ✅ | ✅ |
| FormsTests (C#) | every control on generated designer forms; show/resize/theme-switch/dispose + handle stability | 6 | ✅ | ✅ | ✅ | ✅ | ✅ | ✅ | ✅ | ✅ | ✅ | ✅ | ✅ |
| FormsTests.VB | VB designer-path twin of the above | 6 | ✅ | ✅ | ✅ | ✅ | ✅ | ✅ | ✅ | ✅ | ✅ | ✅ | ✅ |
| FunctionalTests | spec §6.2 per-control recipe: instantiate → place → render → property sweep → method sweep → dispose → handle/finaliser assertions | 243 | ✅ | ✅ | ✅ | ✅ | ✅ | ✅ | ✅ | ✅ | ✅ | ✅ | ✅ |

Typical durations: UnitTests ~7–10 s/TFM; FormsTests ~21–26 s; FunctionalTests ~1m30s–1m49s.
FunctionalTests sweep stats: 4,624 properties set + 1,462 methods invoked per TFM across 243 types.

## Adversarial suite — spec-minimum TFMs (spec §6.4: net46 / net48 / net8 / net10)

StressTests, default category (`Adversarial` minus `Endurance`):

| TFM | Result | Duration |
|---|---|---|
| net46 (NUnitLite) | 189/189 ✅ | ~19 min (8 Extended-fixture cases are net48/net8-only by documented scope) |
| net48 | 197/197 ✅ | ~21 min |
| net8.0-windows | 197/197 ✅ | ~19 min |
| net10.0-windows | 189/189 ✅ | 12m48s (Extended fixtures net48/net8-only, as net46) |

Endurance category (reduced official counts — storm 25 rounds, rapid create/destroy 2,500 cycles/family;
rationale in `Tests\README.md`), one pass on net48 + net8:
- **net8: 9/9 ✅** — rapid families 2m52s–4m14s; Outlook 100k 22s; Tree 100k 5m00s; DataGrid 100k 4s; 25-round storm 39m34s.
- **net48: 8/9** — as net8 plus 1 **OPEN (A10)**: the 25-round theme-switch storm retains ~70 KB per global palette switch on .NET Framework (net8 clean; the assertion is deliberately left active as the detector).

## Defects found by the test effort (full detail in `BREAKAGE-LOG.md`)

The suite found genuine bugs, as the spec intended. **Fixed** (all [UPSTREAM], committed):

| ID | Component | Defect | Severity |
|---|---|---|---|
| F1 | KryptonToggleSwitch | all four `IContentValues` members threw `NotImplementedException` | — |
| A1 | KryptonCalendar (Ext) | non-transactional extreme view-range → process-killing paint NRE | critical |
| A2 | KryptonMonthCalendar | unbounded month layout at extreme size (hang + Int32 overflow) | critical |
| A3 | KryptonTableLayoutPanel | negative-size Bitmap crash from WM_WINDOWPOSCHANGED + snapshot GDI leak | critical |
| A4 | KryptonForm / ShadowManager | 4 USER-handle shadow-window leak per show→dispose lifecycle | high |
| A5 | KryptonToastNotificationPopup (Ext) | Dispose silently no-ops mid-animation, leaking palette-subscribed window | high |
| A6 | VisualForm.InvalidateNonClient | GDI+ OOM on dead HWND crashes theme changes | high |
| A7 | VisualPanel | dispose-inside-Paint → crash out of WM_PAINT | high |
| A8 | Save*ToArray / palette Export | `MemoryStream.GetBuffer()` ships NUL-padded XML | medium |

Plus the six Phase-2 dispose-time NRE fixes and the Phase-3 theme fixes are locked as regressions in UnitTests.

**OPEN** (documented, [UPSTREAM], design-judgement or upstream-facing):
- **A9** — KryptonToolkitPoweredByControl lays out in ~90 s (bounded, not a hang) at `int.MaxValue` size; skip-listed with FIXME (needs a wrap-measure clamp in KryptonWrapLabel).
- **A10** — net48 theme-switch storm retains ~70 KB per switch (see above).
- **F2** — KryptonPage `PaletteMode`/`Palette` setters throw `OperationCanceledException` (wrong type for a sealed property).
- **F3** — Workspace `StarSize.Value` throws `ArgumentNullException` for non-null malformed input.

## Coverage notes / honest limitations

- DPI torture is in-proc `Form.Scale`-ratio only; true per-monitor-v2 DPI variation is a CI/manifest concern (documented in `Tests\README.md`).
- Full CodeDom designer-serialisation round-trip is deferred; the achievable persistence round-trips (docking/workspace layout XML, palette export/import, corrupted-XML batteries) are implemented instead.
- Extended-module adversarial fixtures run on net48 + net8 only (dependency-closure weight), a recorded scope decision.
