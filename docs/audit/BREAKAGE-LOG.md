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

## Extended Toolkit smoke findings (15 July 2026)

Found by running the Phase 2 smoke harness (`Scripts/SmokeTest --dir` mode) over every
Extended-Toolkit module output directory × 11 TFMs. All are pre-existing upstream defects.

### E1. [UPSTREAM] FadeControllerNETCoreSafe.FadeWindowOutExtended: infinite loop hangs every fading form on close
- **Repro:** show any form whose `OnFormClosing` calls `FadeWindowOutExtended` on a .NET Core 3.1+ TFM (e.g. `Common.CommonExtendedKryptonForm`, `UseFade` default true), then close it.
- **Root cause:** the fade-out loop increments instead of decrements — `for (_fadeOut = 90; _fadeOut >= 10; _fadeOut += 10)` — so the condition never turns false and the UI thread spins in `Refresh()`/`Sleep()` forever.
- **Affects:** all .NET (Core) TFMs; two identical copies of the class (Effects `Classes\Fading\FadeController.cs`, Forms `General\FadeControllerNETCoreSafe.cs`). Poisoned 87 smoke runs (`Common.dll` is in nearly every module's dependency closure).
- **Fix:** `+= 10` → `-= 10` in both copies.

### E2. [UPSTREAM] FadeController.UpdateOpacity: infinite recursion when the fade speed is 0 hangs the form on Show
- **Repro:** `new CommonExtendedKryptonForm().Show()` on a net4x TFM. `OnLoad` calls `FadeController.FadeIn(this, FadeSpeed)` and `FadeSpeed` defaults to 0, so `Opacity += 0/1000` never reaches 1.0 and `UpdateOpacity()` self-recurses (with `Thread.Sleep(10)`) forever on the UI thread.
- **Affects:** net4x path of `CommonExtendedKryptonForm` (netcore path takes E1's class instead); both `FadeController` copies (Effects and Forms modules).
- **Fix:** guard at the top of `UpdateOpacity` — a non-positive speed applies the end state (opacity 1, or opacity 0 + Hide/Close) immediately.

### E3. [UPSTREAM] KryptonCheckBoxComboBoxListControlContainer.WndProc: forced cast of Parent to PopUp
- **Repro:** parent the control to anything that is not a `PopUp` (as the smoke harness's host form does) — `((Parent as PopUp)!).ProcessResizing(ref m)` throws NRE on the first window message; presented as HUNG/0xC000041D because the NRE escapes the native `WndProc` callback frame.
- **Fix:** `if (Parent is PopUp popUp && popUp.ProcessResizing(ref m))`.

### E4. [UPSTREAM] KryptonFormExtended / VisualKryptonFormExtended: NRE in core PaletteFormBorder on every non-client paint
- **Repro:** `new KryptonFormExtended().Show()`. The Forms module's vendored `VisualKryptonFormExtended` constructs the core `PaletteFormRedirect` with `ownerForm: null` (it derives from the module's own `VisualForm`, not the core's, so it has no core `VisualForm` to pass). Core `PaletteFormBorder.Draw`/`Width` dereference `_ownerForm` unguarded, so WM_NCPAINT → `ViewManager.Layout` → `GetBorderWidth` NREs inside `WndProc` (modal error dialog / hang / 0xC000041D in real apps).
- **Fix (core, Standard-Toolkit):** `PaletteFormBorder` tolerates a null owner — `Draw` falls back to `base.Draw`, `Width` skips the `RealWindowBorders` path. The Extended side is unchanged (its `null` is now a supported argument).
- Also fixed while here: `KryptonFormExtended.UseFade` setter assigned `_useBlur` instead of `_useFade` (wrong field — property could never be enabled).

### E5. [UPSTREAM] KryptonCalendar: three-layer NRE cascade in the constructor
- **Repro:** `new KryptonCalendar()` throws NRE on all 11 TFMs.
- **Root causes:** (1) the `HighlightRanges` setter runs `UpdateHighlights()` before `SetViewRange` has created the days array (`_days` null); (2) `CalendarRenderer.PerformItemsLayout` iterates `Calendar.Days` from the item-collection-changed path, also before the array exists; (3) all **14** event raisers (`OnItemsPositioned` et al.) invoke their event fields without a null check, so raising with no subscribers (which the constructor always does via `ItemsPositioned`) throws.
- **Fix:** null guards in `UpdateHighlights`/`PerformItemsLayout`; all 14 raisers converted to `Event?.Invoke(this, e)`.

### E6. [UPSTREAM] CircularProgressBar: NRE in RecreateBackgroundBrush before first paint
- **Repro:** add to a form and `Show()` — the parent's `Invalidated` event fires during handle creation, before any paint has created `_backBrush`, and `RecreateBackgroundBrush` starts with `_backBrush.Dispose()`.
- **Fix:** `_backBrush?.Dispose()` (the standard null-conditional pattern).

### E7. [UPSTREAM] NaviBar: MissingManifestResourceException from a string table that was never ported
- **Repro:** show a `NaviBar` — `NaviLayoutEngineOffice.InitializeMenu()` constructs `ResourceManager("NaviSuite.Properties.Resources.Text", …)`, a resource from the original NaviSuite library that exists nowhere in the Extended repository (never has, per git history), so the first `GetString` throws on every TFM (presented as HUNG on net46/net47, 0xC0000005/failures elsewhere).
- **Fix:** the four menu strings ("Show More Buttons" etc.) are supplied directly; the dead `ResourceManager` is removed. Localisation of these four strings never worked, so nothing is lost.

### E8. [UPSTREAM] Designer .resx in folders: manifest-name mismatch on the net4x TFMs (MissingManifestResourceException)
- **Repro:** instantiate `DataGridView.MasterSingleDetailView`/`MasterMultiDetailView` (or ~60 other resx-paired types across ~20 modules, e.g. `Navi.Suite.NaviOptionsForm`) on any net4x TFM.
- **Root cause:** the SDK defaults `EmbeddedResourceUseDependentUponConvention` to true only for .NET Core 3.0+ targets. A designer resx in a folder (`Implementation\MasterDetailGridViewBase.resx` beside a class declared in the module *root* namespace) is therefore embedded as `<RootNamespace>.<Folder>.<Name>.resources` on net4x but `<class namespace>.<Name>.resources` on net5+; `ComponentResourceManager(typeof(T))` always looks up the type-based name, so every such form throws on net4x only.
- **Fix:** `EmbeddedResourceUseDependentUponConvention=true` forced for all TFMs in the Extended `Directory.Build.props`, making the net4x manifest names identical to net5+ (verified by dumping `GetManifestResourceNames()` per TFM before/after).

### E9. [UPSTREAM] ColourEditorControl: designer casts KryptonNumericUpDown to ISupportInitialize
- **Repro:** `new ColourEditorControl()` (Core module) throws InvalidCastException on every TFM — `KryptonNumericUpDown` has never implemented `ISupportInitialize` (verified against upstream 100.25.11.328 and the Bastion core); the designer file was evidently generated when the fields were WinForms `NumericUpDown` and not regenerated after the swap.
- **Fix:** the 14 meaningless Begin/EndInit casts removed.

### E10. [UPSTREAM] Ten controls never unsubscribe from KryptonManager.GlobalPaletteChanged (ObjectDisposedException after dispose)
- **Repro:** create + dispose any of the controls below, then change the global palette (e.g. instantiate `Core.DefineIndividualColoursDialog`, whose designer code sets `KryptonManager.GlobalCustomPalette`). The static event fires into the disposed control; `CommonKryptonKnobControlEnhanced`'s handler calls `CreateGraphics` → ObjectDisposedException inside an event callback (0xC000041D in the harness).
- **Controls fixed** (unsubscribe `GlobalPaletteChanged` and `_palette.PalettePaint` on dispose, adding a `Dispose(bool)` override where none existed): `CommonKryptonKnobControlEnhanced` (Common), `KryptonCalendar` (Calendar), `CircularProgressBar` (Circular.ProgressBar), `KryptonFlowLayoutPanel`/`KryptonKnobControlVersion1`/`KryptonKnobControlVersion2` (Controls), `KryptonFlatTabControl`/`KryptonTabControlLite`/`SystemTabControl` (Navigator), `KryptonToolBox` (Tool.Box). (`ToolBoxTab` also subscribes but is a plain non-Component object with no dispose lifecycle and no handle-forcing handler — left as is.)
- This is the Extended-side twin of the core's dispose-time focus-event theme above.

### E11. [UPSTREAM] ColourUtilities.PropagateSystemColours: unfiltered reflection over SystemColors breaks on .NET 9+
- **Repro:** show `Core.CustomColours` (or any colour dialog reaching `PropagateSystemColours`) on net9/net10 — the method casts **every** public static property of `SystemColors` to `Color`, and .NET 9 added the `bool UseAlternativeColorSet` property → InvalidCastException (Boolean → Color) in the Load handler.
- **Fix:** skip properties whose `PropertyType != typeof(Color)`.

### E12. [UPSTREAM] Circular.ProgressBar: unsigned WinFormAnimation dependency unloadable on net4x
- **Repro:** touch any `CircularProgressBar` member on a net4x TFM — `Unofficial.WinFormAnimation` 2.0.2 ships an **unsigned** assembly (`WinFormAnimation_DotNET`), and .NET Framework refuses to load a weak-named assembly from the strong-named module (FileLoadException 0x80131044). Broken for every net4x consumer upstream too (2.0.3 is also unsigned).
- **Fix (rung b):** net4x uses the original strong-named `WinFormAnimation` 1.6.0.4 package (same author, MIT, identical type surface). Only deltas: root namespace (`WinFormAnimation` vs `WinFormAnimation_NET5`, handled by a `#if NETFRAMEWORK` global using) and the 1.6 enum spelling `KnownAnimationFunctions.Liner` (two `#if` sites). THIRD-PARTY-NOTICES updated.

### E13. [UPSTREAM] ColourCollection == operator infinite recursion (StackOverflow, whole process killed)
- **Repro:** `new ColourEditor()` (Drawing.Utilities) — its `RGBAColourSliderControl.CreateScale` sets `CustomColours`, whose setter does `value != _customColours`, invoking `ColourCollection.operator !=` → `operator ==`, which itself used `left != null`/`right != null` **against the same overloaded operators**, recursing until the stack overflows and the process dies (uncatchable; killed all 11 TFMs).
- **Fix:** the `==` operator uses `is not null` instead of `!= null` (Drawing.Utilities copy; the Core module's copy already used `(object)left == null` and was safe).

### E14. [UPSTREAM] KryptonBrowseComboBox: Image.FromFile with a resource name (FileNotFoundException)
- **Repro:** `new KryptonBrowseComboBox()` (Dialogs) — the ctor did `Image.FromFile("ImageResources.Reset_16_x_16.png")`, treating an embedded-resource name as a file path, throwing FileNotFoundException on every construction.
- **Fix:** load from `Properties.Resources.Reset_16_x_16`/`Reset_32_x_32` (the sibling `KryptonRunDialog` already does).

### E15. [UPSTREAM] FlatTabControl: two never-ported resource-table lookups (MissingManifestResourceException)
- **Repro:** show a `FlatTabControl`/`KryptonFlatTabControl` (Navigator) — the ctor and paint path build `ResourceManager(typeof(FlatTabControl))` and fetch `TabIcons.bmp`/`CloseIcon.bmp`, images that were never ported into the assembly, so it threw on construction and again on paint.
- **Fix:** dropped the scroll-icon strip (the paint code already guards on `Images.Count != 4`) and draw the close glyph as an X cross with primitives. No resources needed.

### E16. [UPSTREAM] KryptonEnhancedToolStripProgressBar: null-forgiven palette deref (NRE)
- **Repro:** `new KryptonEnhancedToolStripProgressBar()` (Tool.Strip.Items) — ctor set `_palette = null` then immediately did `_palette!.ColorTable...`, NRE every time.
- **Fix:** `_palette = KryptonManager.CurrentGlobalPalette`.

### E17. [UPSTREAM] MRUOpenFileMenuItem: constructs MostRecentlyUsedFileManager with arguments its own guard rejects (ArgumentException)
- **Repro:** `new MRUOpenFileMenuItem()` (Tool.Strip.Items) — ctor calls `new MostRecentlyUsedFileManager(null, null, null, null)`, but that constructor throws `ArgumentException("Bad argument.")` when the parent item / app name / click handler are null (which they always are at this point).
- **Fix:** leave `_recentlyUsedFileManager` null until wired up (the one usage site already guards with `?.`).

### E18. [UPSTREAM] ComputerEnum: Nullable<uint> in a P/Invoke signature (MarshalDirectiveException)
- **Repro:** `new KryptonNetworkNodePicker()` (Networking) → `ComputerEnum` ctor → `NetServerEnum` P/Invoke declared `uint? servertype`; non-blittable generic types cannot be marshalled, so it threw on the first call on every TFM.
- **Fix:** the extern parameter is `uint`; the null case passes `0xFFFFFFFF` (SV_TYPE_ALL — no filter).

### E19. [UPSTREAM] KryptonAlertWindow: Timer.Interval set to 0 (ArgumentOutOfRangeException)
- **Repro:** show a `KryptonAlertWindow` (Notifications) constructed without an interval — the tick handler assigns `_tmrAlert.Interval = _interval` where `_interval` is still 0; `Timer.Interval` requires ≥ 1.
- **Fix:** `Interval = Math.Max(1, _interval)`.

### E20. [UPSTREAM] InternalTreeColumnView: OnLayout dereferences owner set only post-construction (NRE)
- **Repro:** `new InternalTreeColumnView()` (VirtualTreeColumnView) via its parameterless ctor — layout fires before the `KryptonVirtualTreeColumnView` owner and view manager are assigned (those are wired only by the second ctor), so `OnLayout` NREs.
- **Fix:** early-return from `OnLayout` when `_viewManager`/`_kryptonVirtualTreeColumnView` is null.

### E21. [UPSTREAM] KryptonOKDialogButton: unguarded event raise (NRE)
- **Repro:** set `ParentWindow` on a `KryptonOKDialogButton` (Buttons) with no `ParentWindowChanged` subscriber — `OnParentWindowChanged` did `ParentWindowChanged.Invoke(...)` (the sibling No/Yes/Cancel buttons already used `?.Invoke`). Surfaced through `KryptonColourPickerDialog`/`ScreenColourPickerDialog` in Drawing.Utilities once E13's StackOverflow no longer masked it.
- **Fix:** `ParentWindowChanged?.Invoke(...)`.

### E22. [UPSTREAM] KryptonTextToSpeechDialog: constructor throws where no speech engine exists (PlatformNotSupportedException)
- **Repro:** `new KryptonTextToSpeechDialog()` (Dialogs) on a machine/SKU without System.Speech support — the ctor's `PropagateInstalledVoicesList` constructs `SpeechSynthesizer`, which throws; it also set `SelectedIndex = 0` on an empty combo.
- **Fix:** swallow `PlatformNotSupportedException` (empty voice list) and only set `SelectedIndex` when the combo has items. The dialog is now always constructible; speech simply degrades where the OS lacks it.

### E23. [UPSTREAM] KryptonComboBoxTree leaks its dropdown KryptonTreeView → later global-palette change hits a core NotImplemented modal (dialog/deadlock)
- **Repro:** only visible when many types are smoke-tested in one process (the Ultimate/Ultimate.Lite meta-packages, all 11 TFMs): after a `KryptonComboBoxTree` (ComboBox module) is created and disposed, instantiating `Core.DefineIndividualColoursDialog` (whose `InitializeComponent` sets `KryptonManager.GlobalCustomPalette`) fires `GlobalPaletteChanged` into the **leaked** core `KryptonTreeView`, whose layout asks the custom palette for a control style that routes to `KryptonCustomPaletteBase.GetPaletteControl` → `DebugTools.NotImplemented` → a modal `MessageBox` (presents as HUNG).
- **Root cause:** `KryptonComboBoxTree` hosts its tree view inside a private popup `Form` (`_frmTreeView`) that is **not** in the control's `Controls` collection, so disposing the combo never disposed the form or the tree view — leaving the tree permanently subscribed to the static `GlobalPaletteChanged`.
- **Fix:** `Dispose(bool)` override disposes `_frmTreeView`. This single fix cleared the Ultimate/Ultimate.Lite hang on all 11 TFMs. (The core's `NotImplemented`-in-a-palette-getter modal is a latent core issue exposed by the leak; not touched here.)

### E24. Smoke-harness updates (not product defects)
- **Skip list added** (`Scripts/SmokeTest/Program.cs`) for types that genuinely show modal UI by design when instantiated/shown — each blocks unattended automation until the 30s watchdog fires: `Core.GlobalOptionsMenu` (Load shows a "developmental use only" YesNo box), `Core.PaletteColourCreator` (Load calls `ResetToDefaults()`, which shows a "Reset Settings" confirmation), `Dialogs.KryptonNuGetBrowser` (Load shows the `UnderConstruction()` box), `Drawing.Utilities.KryptonColourFindAndReplaceDialog` (its **constructor** shows the `UnderConstruction()` box).
- **Native-library resolver** for `--dir` mode: LoadFrom'd assemblies get no deps.json/RID probing, so SkiaSharp's P/Invoke fell through to PATH and found an incompatible libSkiaSharp 88.1 (a stray copy in a .NET Reactor install directory). The harness now probes the module directory's own `runtimes\win-<arch>\native` assets first — matching what a real consuming app's host would do.
- **Top-level control handling**: `ToolStripDropDown`-derived items (context menus) and `TabPage`s cannot be parented to a bare host form ("Top-level control cannot be added" / "TabPage cannot be added"). The harness now create-and-disposes drop-downs and hosts tab pages in a `TabControl`.

### Harness limitation (not a product defect) — documented, not fixed

- **Software.Updater on net5/6/7/8**: the module is an ILRepack candidate that pins `System.Drawing.Common` 10.0. The smoke harness runs on the net8 Windows-Desktop shared framework, which ships `System.Drawing.Common` 8.0; loading the module's raw DLLs via `Assembly.LoadFrom` cannot unify to 10.0 the way a real consuming app's `deps.json` would, so type enumeration throws `FileLoadException`. **net4x Software.Updater passes (8 types, 0 failures).** This is a raw-DLL-loader artifact of the harness, not a defect in the module; a normally-referenced net8 app resolves it correctly.

### E9. [UPSTREAM] Software.Updater: System.Drawing.Common 10.0.0 pin unloadable on net5–net9
- **Repro:** instantiate any Software.Updater form on net5–net9 — `FileLoadException: Could not load file or assembly 'System.Drawing.Common, Version=10.0.0.0'` (those desktop runtimes ship older framework versions that cannot satisfy the 10.0.0.0 bind).
- **Fix:** PackageReference removed — every TFM in the matrix already gets System.Drawing from the Windows Desktop framework (net5+) or the GAC (net4x).

## Consumer-packaging findings (not bugs; for CHANGES.md and package metadata)

- On net47–net481, Krypton's preserialized resources require **System.Resources.Extensions** at runtime; consumers referencing raw DLLs (not NuGet) must ship it. Package dependency metadata must declare it (upstream already does).
- On net46 (Bastion-added TFM), **System.Memory** (and `System.ValueTuple`) must flow as package dependencies; System.Resources.Extensions is deliberately absent (net46 uses classic resources — see BUILD-LOG Phase 2 decision).

## Verification

Smoke matrix (`Scripts/SmokeTest`): 230 public Component types instantiated, shown on a form,
resized, disposed — per TFM, on the real runtime for that TFM (.NET Framework 4.8.1 for net4x;
locally-installed .NET 5.0.17/6.0.36/7.0.20 desktop runtimes; system .NET 8/9/10).
**Result: 11/11 TFMs × 230 types, 0 failures** after the fixes above.

Extended Toolkit smoke matrix (`Scripts/SmokeTest --dir` over every module output directory):
**654 of 659 module × TFM runs green (≈11,000 type instantiations)** after the E1–E23 fixes;
the 5 non-green runs are Software.Updater net5.0–net9.0, a documented raw-DLL-loader artifact of
the harness (see E24), not module defects. Full matrix summary in
`docs/audit/EXTENDED-BUILD-TRIAGE.md` §7. The core `PaletteFormBorder` fix (E4) was re-verified
by a warning-clean core solution build (0 errors / 0 warnings).
