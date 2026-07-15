# Breakage Log — bugs found by the Bastion test effort

Per spec §6.3: every crash/exception found is logged with repro, root cause and fix commit.
Pre-existing upstream bugs are marked **[UPSTREAM]** — candidates for contribution back to Krypton-Suite.

## Found during Phase 2 smoke testing (15 July 2026)

### 1. [UPSTREAM] KryptonComboBox: NullReferenceException in focus handlers during Dispose
- **Repro:** create `KryptonComboBox`, add to form, `Show()`, dispose the control. The native edit child receives `WM_SETFOCUS`/`WM_KILLFOCUS` from inside `DestroyWindow`; `OnComboBoxGotFocus`/`OnComboBoxLostFocus` dereference `_subclassEdit!`, which is already null during teardown.
- **Symptom in real apps:** unhandled `NullReferenceException` in `WndProc` on control disposal — with the default WinForms exception mode this appears as the modal thread-exception dialog (or a silent hang in unattended processes).
- **Affects:** all TFMs (reproduced net46/net48/net8). Present on upstream V105-LTS tip (`57824ec4`); likely interacts with the July 2026 LTS combo-box styling changes (`867fe2b99`, `feb69ef88`).
- **Fix:** null-conditional assignment in both handlers (`_subclassEdit?.Visible = …`).

### 2. [UPSTREAM] Five controls: NullReferenceException in UpdateStateAndPalettes during Dispose
- **Controls:** `KryptonListView`, `KryptonListBox`, `KryptonCheckedListBox`, `KryptonTreeView`, `KryptonPropertyGrid`.
- **Repro:** as above — focus events fired from inside `DestroyWindow` while `Dispose` is executing. `UpdateStateAndPalettes()` guards only `!IsDisposed`, but `IsDisposed` is not set until Dispose *completes*; the palette redirect target is already detached, so `PaletteRedirect.GetBackColor1` dereferences a null `_target`.
- **Affects:** all TFMs (reproduced everywhere via `KryptonListView`, exit 0xC000041D fatal callback exception).
- **Fix:** guard extended to `!IsDisposed && !Disposing` (mirrors upstream's own pattern in `KryptonComboBox.SyncComboBoxAppearance`).

### 3. [UPSTREAM] VisualForm.MdiChildrenMinimizedAnchorBottom setter always threw
- The net8+-compiled setter assigned the base property then unconditionally threw `NotSupportedException("Please use .NET 6 or newer…")` — on runtimes where the feature works. Fixed while widening the guard to `NET6_0_OR_GREATER` (the API's true floor).

### 4. [UPSTREAM] MemoryExtensions.Count guarded as NET5_0_OR_GREATER
- `KryptonRichTextBox.CountColorTableEntries` used `MemoryExtensions.Count` (a .NET 8 API) behind `#if NET5_0_OR_GREATER` — a compile error on net5/6/7, invisible upstream because those TFMs are skipped. Guard corrected to `NET8_0_OR_GREATER`.

### 5. [UPSTREAM, minor] Public polyfills of System.Diagnostics.CodeAnalysis attributes
- `MaybeNullAttribute`/`NotNullAttribute` polyfills were `public` (unlike their `internal` siblings in the same file), shipping public `System.*` types from all five assemblies on net4x — CS0433 ambiguity risk for consumers referencing two Krypton assemblies. Made `internal`.

## Consumer-packaging findings (not bugs; for CHANGES.md and package metadata)

- On net47–net481, Krypton's preserialized resources require **System.Resources.Extensions** at runtime; consumers referencing raw DLLs (not NuGet) must ship it. Package dependency metadata must declare it (upstream already does).
- On net46 (Bastion-added TFM), **System.Memory** (and `System.ValueTuple`) must flow as package dependencies; System.Resources.Extensions is deliberately absent (net46 uses classic resources — see BUILD-LOG Phase 2 decision).

## Verification

Smoke matrix (`Scripts/SmokeTest`): 230 public Component types instantiated, shown on a form,
resized, disposed — per TFM, on the real runtime for that TFM (.NET Framework 4.8.1 for net4x;
locally-installed .NET 5.0.17/6.0.36/7.0.20 desktop runtimes; system .NET 8/9/10).
**Result: 11/11 TFMs × 230 types, 0 failures** after the fixes above.
