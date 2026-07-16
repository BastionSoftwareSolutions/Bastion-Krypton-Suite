# Breakage Log â€” bugs found by the Bastion test effort

Per spec Â§6.3: every crash/exception found is logged with repro, root cause and fix commit.
Pre-existing upstream bugs are marked **[UPSTREAM]** â€” candidates for contribution back to Krypton-Suite.

## Found during Phase 2 smoke testing (15 July 2026)

### 1. [UPSTREAM] KryptonComboBox: NullReferenceException in focus handlers during Dispose
- **Repro:** create `KryptonComboBox`, add to form, `Show()`, dispose the control. The native edit child receives `WM_SETFOCUS`/`WM_KILLFOCUS` from inside `DestroyWindow`; `OnComboBoxGotFocus`/`OnComboBoxLostFocus` dereference `_subclassEdit!`, which is already null during teardown.
- **Symptom in real apps:** unhandled `NullReferenceException` in `WndProc` on control disposal â€” with the default WinForms exception mode this appears as the modal thread-exception dialog (or a silent hang in unattended processes).
- **Affects:** all TFMs (reproduced net46/net48/net8). Present on upstream V105-LTS tip (`57824ec4`); likely interacts with the July 2026 LTS combo-box styling changes (`867fe2b99`, `feb69ef88`).
- **Fix:** null-conditional assignment in both handlers (`_subclassEdit?.Visible = â€¦`).

### 2. [UPSTREAM] Five controls: NullReferenceException in UpdateStateAndPalettes during Dispose
- **Controls:** `KryptonListView`, `KryptonListBox`, `KryptonCheckedListBox`, `KryptonTreeView`, `KryptonPropertyGrid`.
- **Repro:** as above â€” focus events fired from inside `DestroyWindow` while `Dispose` is executing. `UpdateStateAndPalettes()` guards only `!IsDisposed`, but `IsDisposed` is not set until Dispose *completes*; the palette redirect target is already detached, so `PaletteRedirect.GetBackColor1` dereferences a null `_target`.
- **Affects:** all TFMs (reproduced everywhere via `KryptonListView`, exit 0xC000041D fatal callback exception).
- **Fix:** guard extended to `!IsDisposed && !Disposing` (mirrors upstream's own pattern in `KryptonComboBox.SyncComboBoxAppearance`).

### 3. [UPSTREAM] VisualForm.MdiChildrenMinimizedAnchorBottom setter always threw
- The net8+-compiled setter assigned the base property then unconditionally threw `NotSupportedException("Please use .NET 6 or newerâ€¦")` â€” on runtimes where the feature works. Fixed while widening the guard to `NET6_0_OR_GREATER` (the API's true floor).

### 4. [UPSTREAM] MemoryExtensions.Count guarded as NET5_0_OR_GREATER
- `KryptonRichTextBox.CountColorTableEntries` used `MemoryExtensions.Count` (a .NET 8 API) behind `#if NET5_0_OR_GREATER` â€” a compile error on net5/6/7, invisible upstream because those TFMs are skipped. Guard corrected to `NET8_0_OR_GREATER`.

### 5. [UPSTREAM, minor] Public polyfills of System.Diagnostics.CodeAnalysis attributes
- `MaybeNullAttribute`/`NotNullAttribute` polyfills were `public` (unlike their `internal` siblings in the same file), shipping public `System.*` types from all five assemblies on net4x â€” CS0433 ambiguity risk for consumers referencing two Krypton assemblies. Made `internal`.

## Extended Toolkit smoke findings (15 July 2026)

Found by running the Phase 2 smoke harness (`Scripts/SmokeTest --dir` mode) over every
Extended-Toolkit module output directory Ã— 11 TFMs. All are pre-existing upstream defects.

### E1. [UPSTREAM] FadeControllerNETCoreSafe.FadeWindowOutExtended: infinite loop hangs every fading form on close
- **Repro:** show any form whose `OnFormClosing` calls `FadeWindowOutExtended` on a .NET Core 3.1+ TFM (e.g. `Common.CommonExtendedKryptonForm`, `UseFade` default true), then close it.
- **Root cause:** the fade-out loop increments instead of decrements â€” `for (_fadeOut = 90; _fadeOut >= 10; _fadeOut += 10)` â€” so the condition never turns false and the UI thread spins in `Refresh()`/`Sleep()` forever.
- **Affects:** all .NET (Core) TFMs; two identical copies of the class (Effects `Classes\Fading\FadeController.cs`, Forms `General\FadeControllerNETCoreSafe.cs`). Poisoned 87 smoke runs (`Common.dll` is in nearly every module's dependency closure).
- **Fix:** `+= 10` â†’ `-= 10` in both copies.

### E2. [UPSTREAM] FadeController.UpdateOpacity: infinite recursion when the fade speed is 0 hangs the form on Show
- **Repro:** `new CommonExtendedKryptonForm().Show()` on a net4x TFM. `OnLoad` calls `FadeController.FadeIn(this, FadeSpeed)` and `FadeSpeed` defaults to 0, so `Opacity += 0/1000` never reaches 1.0 and `UpdateOpacity()` self-recurses (with `Thread.Sleep(10)`) forever on the UI thread.
- **Affects:** net4x path of `CommonExtendedKryptonForm` (netcore path takes E1's class instead); both `FadeController` copies (Effects and Forms modules).
- **Fix:** guard at the top of `UpdateOpacity` â€” a non-positive speed applies the end state (opacity 1, or opacity 0 + Hide/Close) immediately.

### E3. [UPSTREAM] KryptonCheckBoxComboBoxListControlContainer.WndProc: forced cast of Parent to PopUp
- **Repro:** parent the control to anything that is not a `PopUp` (as the smoke harness's host form does) â€” `((Parent as PopUp)!).ProcessResizing(ref m)` throws NRE on the first window message; presented as HUNG/0xC000041D because the NRE escapes the native `WndProc` callback frame.
- **Fix:** `if (Parent is PopUp popUp && popUp.ProcessResizing(ref m))`.

### E4. [UPSTREAM] KryptonFormExtended / VisualKryptonFormExtended: NRE in core PaletteFormBorder on every non-client paint
- **Repro:** `new KryptonFormExtended().Show()`. The Forms module's vendored `VisualKryptonFormExtended` constructs the core `PaletteFormRedirect` with `ownerForm: null` (it derives from the module's own `VisualForm`, not the core's, so it has no core `VisualForm` to pass). Core `PaletteFormBorder.Draw`/`Width` dereference `_ownerForm` unguarded, so WM_NCPAINT â†’ `ViewManager.Layout` â†’ `GetBorderWidth` NREs inside `WndProc` (modal error dialog / hang / 0xC000041D in real apps).
- **Fix (core, Standard-Toolkit):** `PaletteFormBorder` tolerates a null owner â€” `Draw` falls back to `base.Draw`, `Width` skips the `RealWindowBorders` path. The Extended side is unchanged (its `null` is now a supported argument).
- Also fixed while here: `KryptonFormExtended.UseFade` setter assigned `_useBlur` instead of `_useFade` (wrong field â€” property could never be enabled).

### E5. [UPSTREAM] KryptonCalendar: three-layer NRE cascade in the constructor
- **Repro:** `new KryptonCalendar()` throws NRE on all 11 TFMs.
- **Root causes:** (1) the `HighlightRanges` setter runs `UpdateHighlights()` before `SetViewRange` has created the days array (`_days` null); (2) `CalendarRenderer.PerformItemsLayout` iterates `Calendar.Days` from the item-collection-changed path, also before the array exists; (3) all **14** event raisers (`OnItemsPositioned` et al.) invoke their event fields without a null check, so raising with no subscribers (which the constructor always does via `ItemsPositioned`) throws.
- **Fix:** null guards in `UpdateHighlights`/`PerformItemsLayout`; all 14 raisers converted to `Event?.Invoke(this, e)`.

### E6. [UPSTREAM] CircularProgressBar: NRE in RecreateBackgroundBrush before first paint
- **Repro:** add to a form and `Show()` â€” the parent's `Invalidated` event fires during handle creation, before any paint has created `_backBrush`, and `RecreateBackgroundBrush` starts with `_backBrush.Dispose()`.
- **Fix:** `_backBrush?.Dispose()` (the standard null-conditional pattern).

### E7. [UPSTREAM] NaviBar: MissingManifestResourceException from a string table that was never ported
- **Repro:** show a `NaviBar` â€” `NaviLayoutEngineOffice.InitializeMenu()` constructs `ResourceManager("NaviSuite.Properties.Resources.Text", â€¦)`, a resource from the original NaviSuite library that exists nowhere in the Extended repository (never has, per git history), so the first `GetString` throws on every TFM (presented as HUNG on net46/net47, 0xC0000005/failures elsewhere).
- **Fix:** the four menu strings ("Show More Buttons" etc.) are supplied directly; the dead `ResourceManager` is removed. Localisation of these four strings never worked, so nothing is lost.

### E8. [UPSTREAM] Designer .resx in folders: manifest-name mismatch on the net4x TFMs (MissingManifestResourceException)
- **Repro:** instantiate `DataGridView.MasterSingleDetailView`/`MasterMultiDetailView` (or ~60 other resx-paired types across ~20 modules, e.g. `Navi.Suite.NaviOptionsForm`) on any net4x TFM.
- **Root cause:** the SDK defaults `EmbeddedResourceUseDependentUponConvention` to true only for .NET Core 3.0+ targets. A designer resx in a folder (`Implementation\MasterDetailGridViewBase.resx` beside a class declared in the module *root* namespace) is therefore embedded as `<RootNamespace>.<Folder>.<Name>.resources` on net4x but `<class namespace>.<Name>.resources` on net5+; `ComponentResourceManager(typeof(T))` always looks up the type-based name, so every such form throws on net4x only.
- **Fix:** `EmbeddedResourceUseDependentUponConvention=true` forced for all TFMs in the Extended `Directory.Build.props`, making the net4x manifest names identical to net5+ (verified by dumping `GetManifestResourceNames()` per TFM before/after).

### E9. [UPSTREAM] ColourEditorControl: designer casts KryptonNumericUpDown to ISupportInitialize
- **Repro:** `new ColourEditorControl()` (Core module) throws InvalidCastException on every TFM â€” `KryptonNumericUpDown` has never implemented `ISupportInitialize` (verified against upstream 100.25.11.328 and the Bastion core); the designer file was evidently generated when the fields were WinForms `NumericUpDown` and not regenerated after the swap.
- **Fix:** the 14 meaningless Begin/EndInit casts removed.

### E10. [UPSTREAM] Ten controls never unsubscribe from KryptonManager.GlobalPaletteChanged (ObjectDisposedException after dispose)
- **Repro:** create + dispose any of the controls below, then change the global palette (e.g. instantiate `Core.DefineIndividualColoursDialog`, whose designer code sets `KryptonManager.GlobalCustomPalette`). The static event fires into the disposed control; `CommonKryptonKnobControlEnhanced`'s handler calls `CreateGraphics` â†’ ObjectDisposedException inside an event callback (0xC000041D in the harness).
- **Controls fixed** (unsubscribe `GlobalPaletteChanged` and `_palette.PalettePaint` on dispose, adding a `Dispose(bool)` override where none existed): `CommonKryptonKnobControlEnhanced` (Common), `KryptonCalendar` (Calendar), `CircularProgressBar` (Circular.ProgressBar), `KryptonFlowLayoutPanel`/`KryptonKnobControlVersion1`/`KryptonKnobControlVersion2` (Controls), `KryptonFlatTabControl`/`KryptonTabControlLite`/`SystemTabControl` (Navigator), `KryptonToolBox` (Tool.Box). (`ToolBoxTab` also subscribes but is a plain non-Component object with no dispose lifecycle and no handle-forcing handler â€” left as is.)
- This is the Extended-side twin of the core's dispose-time focus-event theme above.

### E11. [UPSTREAM] ColourUtilities.PropagateSystemColours: unfiltered reflection over SystemColors breaks on .NET 9+
- **Repro:** show `Core.CustomColours` (or any colour dialog reaching `PropagateSystemColours`) on net9/net10 â€” the method casts **every** public static property of `SystemColors` to `Color`, and .NET 9 added the `bool UseAlternativeColorSet` property â†’ InvalidCastException (Boolean â†’ Color) in the Load handler.
- **Fix:** skip properties whose `PropertyType != typeof(Color)`.

### E12. [UPSTREAM] Circular.ProgressBar: unsigned WinFormAnimation dependency unloadable on net4x
- **Repro:** touch any `CircularProgressBar` member on a net4x TFM â€” `Unofficial.WinFormAnimation` 2.0.2 ships an **unsigned** assembly (`WinFormAnimation_DotNET`), and .NET Framework refuses to load a weak-named assembly from the strong-named module (FileLoadException 0x80131044). Broken for every net4x consumer upstream too (2.0.3 is also unsigned).
- **Fix (rung b):** net4x uses the original strong-named `WinFormAnimation` 1.6.0.4 package (same author, MIT, identical type surface). Only deltas: root namespace (`WinFormAnimation` vs `WinFormAnimation_NET5`, handled by a `#if NETFRAMEWORK` global using) and the 1.6 enum spelling `KnownAnimationFunctions.Liner` (two `#if` sites). THIRD-PARTY-NOTICES updated.

### E13. [UPSTREAM] ColourCollection == operator infinite recursion (StackOverflow, whole process killed)
- **Repro:** `new ColourEditor()` (Drawing.Utilities) â€” its `RGBAColourSliderControl.CreateScale` sets `CustomColours`, whose setter does `value != _customColours`, invoking `ColourCollection.operator !=` â†’ `operator ==`, which itself used `left != null`/`right != null` **against the same overloaded operators**, recursing until the stack overflows and the process dies (uncatchable; killed all 11 TFMs).
- **Fix:** the `==` operator uses `is not null` instead of `!= null` (Drawing.Utilities copy; the Core module's copy already used `(object)left == null` and was safe).

### E14. [UPSTREAM] KryptonBrowseComboBox: Image.FromFile with a resource name (FileNotFoundException)
- **Repro:** `new KryptonBrowseComboBox()` (Dialogs) â€” the ctor did `Image.FromFile("ImageResources.Reset_16_x_16.png")`, treating an embedded-resource name as a file path, throwing FileNotFoundException on every construction.
- **Fix:** load from `Properties.Resources.Reset_16_x_16`/`Reset_32_x_32` (the sibling `KryptonRunDialog` already does).

### E15. [UPSTREAM] FlatTabControl: two never-ported resource-table lookups (MissingManifestResourceException)
- **Repro:** show a `FlatTabControl`/`KryptonFlatTabControl` (Navigator) â€” the ctor and paint path build `ResourceManager(typeof(FlatTabControl))` and fetch `TabIcons.bmp`/`CloseIcon.bmp`, images that were never ported into the assembly, so it threw on construction and again on paint.
- **Fix:** dropped the scroll-icon strip (the paint code already guards on `Images.Count != 4`) and draw the close glyph as an X cross with primitives. No resources needed.

### E16. [UPSTREAM] KryptonEnhancedToolStripProgressBar: null-forgiven palette deref (NRE)
- **Repro:** `new KryptonEnhancedToolStripProgressBar()` (Tool.Strip.Items) â€” ctor set `_palette = null` then immediately did `_palette!.ColorTable...`, NRE every time.
- **Fix:** `_palette = KryptonManager.CurrentGlobalPalette`.

### E17. [UPSTREAM] MRUOpenFileMenuItem: constructs MostRecentlyUsedFileManager with arguments its own guard rejects (ArgumentException)
- **Repro:** `new MRUOpenFileMenuItem()` (Tool.Strip.Items) â€” ctor calls `new MostRecentlyUsedFileManager(null, null, null, null)`, but that constructor throws `ArgumentException("Bad argument.")` when the parent item / app name / click handler are null (which they always are at this point).
- **Fix:** leave `_recentlyUsedFileManager` null until wired up (the one usage site already guards with `?.`).

### E18. [UPSTREAM] ComputerEnum: Nullable<uint> in a P/Invoke signature (MarshalDirectiveException)
- **Repro:** `new KryptonNetworkNodePicker()` (Networking) â†’ `ComputerEnum` ctor â†’ `NetServerEnum` P/Invoke declared `uint? servertype`; non-blittable generic types cannot be marshalled, so it threw on the first call on every TFM.
- **Fix:** the extern parameter is `uint`; the null case passes `0xFFFFFFFF` (SV_TYPE_ALL â€” no filter).

### E19. [UPSTREAM] KryptonAlertWindow: Timer.Interval set to 0 (ArgumentOutOfRangeException)
- **Repro:** show a `KryptonAlertWindow` (Notifications) constructed without an interval â€” the tick handler assigns `_tmrAlert.Interval = _interval` where `_interval` is still 0; `Timer.Interval` requires â‰¥ 1.
- **Fix:** `Interval = Math.Max(1, _interval)`.

### E20. [UPSTREAM] InternalTreeColumnView: OnLayout dereferences owner set only post-construction (NRE)
- **Repro:** `new InternalTreeColumnView()` (VirtualTreeColumnView) via its parameterless ctor â€” layout fires before the `KryptonVirtualTreeColumnView` owner and view manager are assigned (those are wired only by the second ctor), so `OnLayout` NREs.
- **Fix:** early-return from `OnLayout` when `_viewManager`/`_kryptonVirtualTreeColumnView` is null.

### E21. [UPSTREAM] KryptonOKDialogButton: unguarded event raise (NRE)
- **Repro:** set `ParentWindow` on a `KryptonOKDialogButton` (Buttons) with no `ParentWindowChanged` subscriber â€” `OnParentWindowChanged` did `ParentWindowChanged.Invoke(...)` (the sibling No/Yes/Cancel buttons already used `?.Invoke`). Surfaced through `KryptonColourPickerDialog`/`ScreenColourPickerDialog` in Drawing.Utilities once E13's StackOverflow no longer masked it.
- **Fix:** `ParentWindowChanged?.Invoke(...)`.

### E22. [UPSTREAM] KryptonTextToSpeechDialog: constructor throws where no speech engine exists (PlatformNotSupportedException)
- **Repro:** `new KryptonTextToSpeechDialog()` (Dialogs) on a machine/SKU without System.Speech support â€” the ctor's `PropagateInstalledVoicesList` constructs `SpeechSynthesizer`, which throws; it also set `SelectedIndex = 0` on an empty combo.
- **Fix:** swallow `PlatformNotSupportedException` (empty voice list) and only set `SelectedIndex` when the combo has items. The dialog is now always constructible; speech simply degrades where the OS lacks it.

### E23. [UPSTREAM] KryptonComboBoxTree leaks its dropdown KryptonTreeView â†’ later global-palette change hits a core NotImplemented modal (dialog/deadlock)
- **Repro:** only visible when many types are smoke-tested in one process (the Ultimate/Ultimate.Lite meta-packages, all 11 TFMs): after a `KryptonComboBoxTree` (ComboBox module) is created and disposed, instantiating `Core.DefineIndividualColoursDialog` (whose `InitializeComponent` sets `KryptonManager.GlobalCustomPalette`) fires `GlobalPaletteChanged` into the **leaked** core `KryptonTreeView`, whose layout asks the custom palette for a control style that routes to `KryptonCustomPaletteBase.GetPaletteControl` â†’ `DebugTools.NotImplemented` â†’ a modal `MessageBox` (presents as HUNG).
- **Root cause:** `KryptonComboBoxTree` hosts its tree view inside a private popup `Form` (`_frmTreeView`) that is **not** in the control's `Controls` collection, so disposing the combo never disposed the form or the tree view â€” leaving the tree permanently subscribed to the static `GlobalPaletteChanged`.
- **Fix:** `Dispose(bool)` override disposes `_frmTreeView`. This single fix cleared the Ultimate/Ultimate.Lite hang on all 11 TFMs. (The core's `NotImplemented`-in-a-palette-getter modal is a latent core issue exposed by the leak; not touched here.)

### E24. Smoke-harness updates (not product defects)
- **Skip list added** (`Scripts/SmokeTest/Program.cs`) for types that genuinely show modal UI by design when instantiated/shown â€” each blocks unattended automation until the 30s watchdog fires: `Core.GlobalOptionsMenu` (Load shows a "developmental use only" YesNo box), `Core.PaletteColourCreator` (Load calls `ResetToDefaults()`, which shows a "Reset Settings" confirmation), `Dialogs.KryptonNuGetBrowser` (Load shows the `UnderConstruction()` box), `Drawing.Utilities.KryptonColourFindAndReplaceDialog` (its **constructor** shows the `UnderConstruction()` box).
- **Native-library resolver** for `--dir` mode: LoadFrom'd assemblies get no deps.json/RID probing, so SkiaSharp's P/Invoke fell through to PATH and found an incompatible libSkiaSharp 88.1 (a stray copy in a .NET Reactor install directory). The harness now probes the module directory's own `runtimes\win-<arch>\native` assets first â€” matching what a real consuming app's host would do.
- **Top-level control handling**: `ToolStripDropDown`-derived items (context menus) and `TabPage`s cannot be parented to a bare host form ("Top-level control cannot be added" / "TabPage cannot be added"). The harness now create-and-disposes drop-downs and hosts tab pages in a `TabControl`.

### Harness limitation (not a product defect) â€” documented, not fixed

- **Software.Updater on net5/6/7/8**: the module is an ILRepack candidate that pins `System.Drawing.Common` 10.0. The smoke harness runs on the net8 Windows-Desktop shared framework, which ships `System.Drawing.Common` 8.0; loading the module's raw DLLs via `Assembly.LoadFrom` cannot unify to 10.0 the way a real consuming app's `deps.json` would, so type enumeration throws `FileLoadException`. **net4x Software.Updater passes (8 types, 0 failures).** This is a raw-DLL-loader artifact of the harness, not a defect in the module; a normally-referenced net8 app resolves it correctly.

### E9. [UPSTREAM] Software.Updater: System.Drawing.Common 10.0.0 pin unloadable on net5â€“net9
- **Repro:** instantiate any Software.Updater form on net5â€“net9 â€” `FileLoadException: Could not load file or assembly 'System.Drawing.Common, Version=10.0.0.0'` (those desktop runtimes ship older framework versions that cannot satisfy the 10.0.0.0 bind).
- **Fix:** PackageReference removed â€” every TFM in the matrix already gets System.Drawing from the Windows Desktop framework (net5+) or the GAC (net4x).

## Found during Phase 3 theme audit (15 July 2026)

### T1. [UPSTREAM] Nine palette modes missing from all 105 command-image switch statements
- **Repro:** set `KryptonManager.GlobalPaletteMode` to any Material (×4), VisualStudio2010Render (×4) or `Microsoft365BlackDarkModeAlternate` mode, then use an integrated-toolbar command — the `switch(PaletteMode)` default arm throws `ArgumentOutOfRangeException`.
- **Root cause:** 105 duplicated switches across 16 command files were never extended when those modes were added.
- **Disposition:** will be fixed during Phase 3 wiring (the switches must be touched for the new Bastion themes anyway; consolidation into a shared lookup is the recommended shape). Candidate for upstream contribution.

### T2. [UPSTREAM] ProfessionalOffice2003 is XP-gated
- `PaletteProfessionalOffice2003` only applies Luna colours when `Environment.OSVersion.Major < 6`; on Windows 10/11 it silently renders as the system professional palette. The Phase 3 "Office 2003 refresh" therefore reinstates the actual Luna Blue/Olive/Silver look unconditionally (with the system-palette behaviour retained under a distinct mode or documented).
## Phase 5b functional-sweep findings (16 July 2026)

Found by `Tests/Bastion.Krypton.FunctionalTests` (spec §6.2: per public Component type —
instantiate → place on a shown KryptonForm → default-render check → property sweep with
typical values → safe method sweep → dispose → handle-delta + finalizer sweep). The first
run produced 33 failing types; triage separated harness naivety (members that legitimately
need data/designer context — now on the justified skip/deny/allow lists in
`Tests/Bastion.Krypton.FunctionalTests/SweepPolicy.cs`) from the genuine defects below.

### F1. [UPSTREAM] KryptonToggleSwitch: all four public IContentValues members threw NotImplementedException
- **Repro:** call `GetImage(state)`, `GetImageTransparentColor(state)`, `GetShortText()` or
  `GetLongText()` on any `KryptonToggleSwitch` — every one threw `NotImplementedException`.
  The control declares `IContentValues` on its public surface, so any toolkit view/content
  path (or consumer code) that consumes the control as `IContentValues` crashes.
- **Affects:** all TFMs; pre-existing on upstream V105-LTS (stubs shipped with the control).
- **Fix:** benign content values matching the sibling implementations (`ViewDrawAutoHiddenTab`
  et al.): `GetImage` → `null` (the switch paints its own glyphs),
  `GetImageTransparentColor` → `Color.Empty`, `GetShortText` → `Text ?? string.Empty`,
  `GetLongText` → `string.Empty`. (`KryptonToggleSwitch.cs`, Standard-Toolkit
  `bastion/multitarget`.)

### F2. [UPSTREAM] OPEN — KryptonPage.PaletteMode / Palette setters throw OperationCanceledException
- **Repro:** set `PaletteMode` or `Palette` on any `KryptonPage` —
  `OperationCanceledException("Cannot change PaletteMode property")`.
- **Assessment:** sealing the page palette to the owning Navigator is deliberate (both
  members are `[Browsable(false)]`/`[EditorBrowsable(Never)]`), but the members remain
  public **writable** properties and the thrown type misrepresents the contract —
  `OperationCanceledException` is for cancelled operations; `NotSupportedException` is the
  correct type (generic reflection/serialisation tooling special-cases it). Changing the
  thrown type (or making the setters non-public) is an upstream-facing design call.
- **Disposition:** OPEN — members skip-listed in the sweep with a FIXME referencing this
  entry.

### F3. [UPSTREAM] OPEN, minor — Workspace StarSize.Value throws ArgumentNullException for non-null malformed input
- **Repro:** `KryptonWorkspaceCell.StarSize = "Sample"` →
  `ArgumentNullException("Value must have two values separated by a comma.")` from
  `StarSize.set_Value` — the argument is not null; the format is wrong.
  `ArgumentException`/`FormatException` would state the contract correctly.
- **Disposition:** OPEN — exception-type-only change with no behavioural urgency; the sweep
  now supplies the documented `"<width>,<height>"` notation, keeping the member covered.

### F4. Framework-only NRE in DataGridView editing controls set standalone (harness naivety, documented)
- **Repro:** on **net48/.NET Framework only**, the property sweep sets `Text` on
  `PercentageEditingControl` / `KryptonDataGridViewProgressEditingControl` (both derive from
  the framework `System.Windows.Forms.DataGridViewTextBoxEditingControl`). The framework's
  `DataGridViewTextBoxEditingControl.OnTextChanged` dereferences the (null) hosting grid →
  `NullReferenceException`, escaping a **reflected WM_COMMAND WndProc**, which on .NET
  Framework routes to a modal `ThreadExceptionDialog` and hangs the unattended run.
- **Assessment:** the NRE is in **framework code, not Krypton** — these editing controls are
  only ever created by a `DataGridView`; setting text standalone is not a real scenario.
  .NET 8 WinForms guards `OnTextChanged`, so net8 is unaffected. Classified as harness
  naivety.
- **Disposition:** (a) `Text`/`SelectedText` skip-listed on the `DataGridViewTextBoxEditingControl`
  base with justification; (b) the sweep now subscribes `Application.ThreadException` on its
  STA thread, so any future reflected-WndProc exception on Framework becomes a structured
  test failure instead of a modal-dialog hang.

### Triage notes (harness naivety, not product defects)
- Empty-collection index contracts (`GetItemHeight(1)` on empty lists, DataGridView
  scrolling indices, `RichTextBox.Find` beyond an empty document, …), documented WinForms
  pairing rules (`HoverSelection`/`HotTracking`, `AllowItemReorder`/`AllowDrop`,
  DataGridView `Custom` border styles, WebBrowser's unsupported ambient properties,
  `KryptonComboBox`'s by-design rejection of `ComboBoxStyle.Simple`) and blank-by-design
  default renders (empty panels/grids/workspaces, auto-size labels with empty text) were
  moved to the explicit, per-entry-justified lists in `SweepPolicy.cs`.
- Typical-value refinements instead of skips where a member has a value-format contract:
  `Rtf`/`SelectedRtf` (well-formed RTF), `PromptChar`/`PasswordChar` (distinct canonical
  chars), `StarSize` (`"50,50"`).

## Phase 5c adversarial findings (16 July 2026)

Source: `Tests/Bastion.Krypton.StressTests` (spec §6.3 — extreme values, null/disposal
abuse, theme-switch storm, threading misuse, RTL/scaling, ribbon/docking scale + corrupted
XML, Extended-module attacks, persistence round-trips, rapid create/destroy). Acceptance
rule: under attack a contract exception is graceful; defect-class exceptions
(NRE/index/arithmetic/cast/AV) or hangs/crashes are findings.

### A1. [UPSTREAM] KryptonCalendar: extreme view range corrupts state; next paint NREs and kills the process
- **Repro:** `KryptonCalendar.SetViewRange(DateTime.MinValue, DateTime.MinValue.AddDays(20))`
  (or any range whose week-aligned day grid falls outside DateTime's representable range) on
  a shown calendar, then paint (`DrawToBitmap`/`WM_PRINTCLIENT`). `UpdateDaysAndWeeks` had
  already committed `DaysMode = Short` and replaced `_days` with a **null-filled array**
  before `ViewStart.AddDays(-preDays…)` threw mid-loop; the rejection left the control
  corrupt, and the next paint crashed with `NullReferenceException` in
  `CalendarRenderer.OnDrawDayNameHeaders` (`_dayNameHeaderColumns` never populated). On
  .NET 8 the NRE escaping `WM_PRINTCLIENT` **took down the whole test host** — a real
  app dies the same way.
- **Affects:** all TFMs; pre-existing upstream (Extended Toolkit `Calendar` module).
- **Fix (two layers, Extended `bastion/multitarget`):**
  1. `KryptonCalendar.UpdateDaysAndWeeks` is now transactional — the range is validated and
     the day/week arrays are built into locals *before* any state (`_daysMode`, `_days`,
     `_weeks`) is committed, and a grid that cannot be represented by `DateTime` is rejected
     up front with `ArgumentOutOfRangeException` (also replacing the bare
     `throw new Exception(...)` for the existing 1..MaximumViewDays validation — narrower,
     contract-correct type; still caught by any existing `catch (Exception)`).
  2. `CalendarRenderer._dayNameHeaderColumns` initialised to `new Rectangle[7]` so a paint
     arriving before the first short-days layout pass can never dereference null
     (`KryptonCalendar.cs`, `CalendarRenderer.cs`).

### A2. [UPSTREAM] KryptonMonthCalendar: extreme Size hangs the UI thread (unbounded month layout)
- **Repro:** `KryptonMonthCalendar.Size = new Size(int.MaxValue, int.MaxValue)` on a shown
  form — never returns. `AdjustSize` computed months-to-fit straight from the raw pixel
  width (`~int.MaxValue / singleMonthWidth` ≈ millions), `CalendarDimensions` accepted it,
  and `ViewLayoutMonths.SyncMonths` set about building millions of month views; the
  recomputed pixel size also overflowed Int32 unchecked.
- **Affects:** all TFMs; pre-existing upstream.
- **Fix:** `AdjustSize` now applies the documented WinForms `MonthCalendar` contract — at
  most 12 months displayed (per-dimension clamp then product clamp) — before committing
  `CalendarDimensions` (`KryptonMonthCalendar.cs`, Standard-Toolkit `bastion/multitarget`).

### A3. [UPSTREAM] KryptonTableLayoutPanel: extreme Size crashes the process from WM_WINDOWPOSCHANGED (+ snapshot bitmap leak)
- **Repro:** set an extreme `Size` on a hosted `KryptonTableLayoutPanel` —
  `BackGroundPanel_Refreshed` fed the raw size into `new Bitmap(w, h, Format32bppRgb)`,
  whose `ArgumentException` escaped `OnSizeChanged` inside `WM_WINDOWPOSCHANGED` and took
  the whole process down (the #774 guard only caught `== 0`, not negative/absurd values).
  Additionally the snapshot bitmap was re-created on **every** resize/refresh and never
  disposed — a per-resize GDI/unmanaged-memory leak.
- **Affects:** all TFMs; pre-existing upstream.
- **Fix:** guard non-positive sizes, cap the snapshot at the virtual-screen bounds (nothing
  beyond it can become visible background), and dispose the previous snapshot on
  replacement (`KryptonTableLayoutPanel.cs`, Standard-Toolkit `bastion/multitarget`).

### A4. [UPSTREAM] KryptonForm leaks its four shadow windows when disposed without closing (4 USER handles per lifecycle)
- **Repro:** `using (var f = new KryptonForm()) { f.Show(); }` in a loop — USER handle count
  grows by exactly 4 per iteration (the rapid create/show/dispose attack: +2,000 over 500
  cycles, all five family scenarios; a long-lived process eventually hits the 10,000
  USER-object limit and dies). `ShadowManager` creates four `VisualShadowBase` WS_POPUP
  windows on `Form.Load` but destroys them only in `Form.Closing` — which never fires when
  a form is disposed without being closed (a fully legal WinForms lifecycle). Verified
  against a plain WinForms `Form` (delta 0) and a never-shown `KryptonForm` (delta 0).
- **Affects:** all TFMs; pre-existing upstream.
- **Fix:** `ShadowManager` also subscribes `Form.Disposed` and tears the shadow windows
  down there (idempotent with the Closing path) (`ShadowManager.cs`, Standard-Toolkit
  `bastion/multitarget`).

### A5. [UPSTREAM] KryptonToastNotificationPopup.Dispose silently no-ops during the appear animation (leaks the popup window; later theme change crashes)
- **Repro:** `popup.PopUp(); popup.Dispose();` while the appear animation is running.
  `Dispose(bool)` hit `if (_isAppearing) { _markedForDisposed = true; return; }` — it
  disposed nothing and **did not even call `base.Dispose`**, deferring teardown to a later
  animation tick that never comes if the message loop stops (application/thread shutdown).
  The undisposed popup form stayed subscribed to the global palette events; the next
  `KryptonManager.GlobalCustomPalette`/theme change then reached a window whose owning
  thread was gone and crashed (see A6). The toast-spam attack (150 popups disposed
  mid-animation) reproduced this deterministically.
- **Affects:** Extended Toolkit `Notifications` module, all TFMs; pre-existing upstream.
- **Fix:** `Dispose` now stops both timers, unhooks their ticks and disposes the popup
  window synchronously — Dispose must dispose; the deferred-dispose flag path is gone
  (`KryptonToastNotificationPopup.cs`, Extended-Toolkit `bastion/multitarget`).

### A6. [UPSTREAM] VisualForm.InvalidateNonClient: GDI+ "OutOfMemoryException" on a dead window handle crashes theme changes
- **Repro:** any leaked `VisualForm`-derived window whose owning thread has ended (A5 was
  one producer) + a global palette change → `Graphics.FromHwnd(Handle)` throws
  `OutOfMemoryException` (GDI+ maps a failed `GetDC` — dead HWND or DC-pool exhaustion —
  to OOM) and the theme-change notification crashes the caller.
- **Affects:** all TFMs; pre-existing upstream.
- **Fix:** `InvalidateNonClient` treats the whole acquire-region-redraw block as
  best-effort: `OutOfMemoryException` is caught and logged alongside the existing
  `InvalidOperationException` handler, and the `Graphics` is disposed in the same
  `finally` (`VisualForm.cs`, Standard-Toolkit `bastion/multitarget`).

### A7. [UPSTREAM] VisualPanel: disposing the control from inside its own Paint event crashes the process
- **Repro:** subscribe `Paint` on any `VisualPanel`-derived control (`KryptonPanel`,
  `KryptonGroup` panels, …), dispose the control inside the handler, let painting continue —
  `OnPaint` re-used the view pipeline after `base.OnPaint` without re-checking: disposal
  released the renderer and `ViewManager.Paint(Renderer!, e)` (note the null-forgiving
  operator hiding it) threw `ArgumentNullException` out of `WM_PAINT` → process death.
  `VisualContainerControlBase` re-checks disposal at exactly this point;
  `VisualPanel` did not.
- **Affects:** all TFMs; pre-existing upstream.
- **Fix:** `VisualPanel.OnPaint` re-validates `!IsDisposed && !Disposing`, `ViewManager`
  and `Renderer` after `base.OnPaint` before entering the view pipeline
  (`VisualPanel.cs`, Standard-Toolkit `bastion/multitarget`).

### A8. [UPSTREAM] SaveLayoutToArray / SaveConfigToArray / palette Export: MemoryStream.GetBuffer() ships NUL-padded XML
- **Repro:** `KryptonWorkspace.SaveLayoutToArray`, `KryptonDockingManager.SaveConfigToArray`
  and `KryptonCustomPaletteBase`'s byte-array `Export` all returned `ms.GetBuffer()` — the
  **capacity-sized** internal buffer — so the returned "XML" carries trailing `0x00`
  padding bytes. The toolkit's own loaders stop at the XML document end and mask it, but
  any strict consumer fails: parsing the array with `XmlReader`/`XmlDocument`, or writing
  the array to a file that is later parsed strictly, throws `XmlException` ("'.',
  hexadecimal value 0x00, is an invalid character"). Found by the `RibbonDockingScaleTests`
  and `SerialisationRoundTripTests` round-trip comparisons, which parse the saved arrays.
- **Affects:** all TFMs; pre-existing upstream (three copies of the same pattern).
- **Fix:** `ms.ToArray()` at all three sites (`KryptonWorkspace.cs`,
  `KryptonDockingManager.cs`, `KryptonCustomPaletteBase.cs`, Standard-Toolkit
  `bastion/multitarget`).

### A9. [UPSTREAM] OPEN — KryptonToolkitPoweredByControl: extreme sizes lay out pathologically slowly (~90 s)
- **Repro:** `control.Size = new Size(int.MaxValue, int.MaxValue)` on a shown
  `KryptonToolkitPoweredByControl` — the dock-filled `TableLayoutPanel` of AutoSize
  `KryptonWrapLabel`s hands the framework text-measure a ~2-billion-pixel wrap constraint;
  the layout **completes** but takes ~85–90 s on every TFM (measured net46/net48/net8),
  crossing the suite's 120 s per-control watchdog on net46's slower GDI path when combined
  with the 500 pt font attack (~30 s).
- **Assessment:** bounded slowness, not a hang; the cost is in framework
  `TextRenderer.MeasureText` under an absurd constraint, reached through Krypton's AutoSize
  wrap labels. A real fix means clamping the wrap-measure constraint inside
  `KryptonWrapLabel` (e.g. to the virtual-screen width) — a behavioural, upstream-facing
  design call not taken unilaterally here.
- **Disposition:** OPEN — the size stage is skip-listed for this control in
  `AdversarialPolicy.cs` with a FIXME referencing this entry; all other attack stages
  still run against it.

### A10. [UPSTREAM] OPEN — theme-switch storm (net48): working set grows ~4-5 MB per full palette cycle, unreclaimed by full GC
- **Repro:** `ThemeSwitchStormTests.EveryControlForm_ThemeStorm_25Rounds` on net48 (quiet
  machine, 12m43s): GC-settled working-set samples climbed 1469 → 1582 MB across the 25
  post-warmup rounds and were strictly monotonic across the final 10 (+40 MB), failing the
  fixture's own bounded-working-set assertion. That is ~70 KB retained per global palette
  switch (62 switches/round, 74 live controls, full `GC.Collect`×2 +
  `WaitForPendingFinalizers` every round). GDI/USER handles stayed within slack throughout
  — memory retention, not handle leakage. The identical test **passed on net8.0-windows**
  (39m34s), so the retention (or its GC visibility) is Framework-side.
- **Assessment:** attribution needs a memory-profiler/dump-diff session (candidate
  suspects: per-switch event-subscription accumulation, static palette/renderer caches
  keyed per switch, retained render surfaces). Not fixable by pattern-matching; deferred.
- **Disposition:** OPEN. Deliberately **no** FIXME skip: the endurance storm's assertion
  is the repro and the detector — skipping it would hide the only signal. The default
  3-round storm is unaffected (its window never fills) and stays green everywhere.

### Phase 5c triage notes
- The adversarial acceptance rule (contract exceptions are graceful; defect-class
  exceptions are findings) and its per-entry-justified skip-list live in
  `Tests/Bastion.Krypton.StressTests/AttackHarness.cs` / `AdversarialPolicy.cs`. Only two
  skips were needed: the 5b F4 framework editing-control `Text` NRE (same justification,
  kept TFM-uniform) and `KryptonWebBrowser` (native out-of-process ActiveX wrapper —
  mutations exercise COM interop, not Krypton code).
- **Workspace layout loaded into a fresh instance loses its pages — by design, not a
  defect** (first run of
  `SerialisationRoundTripTests.WorkspaceLayout_RoundTripsIntoFreshInstance`): a
  `KryptonPage` hosts arbitrary live controls, so the loader cannot resurrect pages from
  XML — a fresh instance must supply each page through the `RecreateLoadingPage` event
  (`KryptonWorkspace.ReadPageElement`: no subscriber + no existing page ⇒ the page is
  skipped and the emptied cells are compacted away). The test now subscribes the event —
  the documented consumer contract — and the topology round-trip holds exactly.
- **The KryptonMonthCalendar failure artefact of 16 July 14:20** (screenshot under
  `Tests\artifacts\StressTests\net8.0-windows\screenshots`) is the watchdog
  `TimeoutException` presentation of A2's unbounded-layout hang; not reproducible since
  the A2 fix (verified by repeated isolated and in-suite runs on net8/net48/net46).
- Corrupted-XML batteries (docking config, workspace layout, palette import): every
  variant (truncations, wrong root, invalid attribute values, non-XML, 10 seeded byte
  flips) either loaded tolerantly or failed with a catchable non-defect exception
  (`XmlException` et al.) — no fixes required; outcomes are printed per run.
- The theme-switch storm excludes `PaletteMode.Global`/`Custom` from the cycle by design
  (indirection / requires a palette instance); every other palette mode is cycled.
- **Endurance runs under machine contention: VSTest "test host process crashed" aborts —
  environment, not product.** Two net8 endurance attempts and one net48 attempt aborted
  with VSTest's host-crash report while this machine concurrently ran two other full
  suites (plus an orphaned 5 GB diagnostic run). Every implicated test — including the
  25-round theme storm and the 2,500-cycle Docking scenario that were in flight during
  the aborts — subsequently **passed in full** when re-run without contention, with flat
  GDI/USER handle counts (externally sampled at ~560/~206 throughout a 21-minute storm)
  and no WER/event-log crash record ever produced. Long-running endurance passes should
  be executed without concurrent suite runs; recorded here so a future abort is compared
  against this signature before being triaged as a product defect.

## Consumer-packaging findings (not bugs; for CHANGES.md and package metadata)

- On net47â€“net481, Krypton's preserialized resources require **System.Resources.Extensions** at runtime; consumers referencing raw DLLs (not NuGet) must ship it. Package dependency metadata must declare it (upstream already does).
- On net46 (Bastion-added TFM), **System.Memory** (and `System.ValueTuple`) must flow as package dependencies; System.Resources.Extensions is deliberately absent (net46 uses classic resources â€” see BUILD-LOG Phase 2 decision).

## Verification

Smoke matrix (`Scripts/SmokeTest`): 230 public Component types instantiated, shown on a form,
resized, disposed â€” per TFM, on the real runtime for that TFM (.NET Framework 4.8.1 for net4x;
locally-installed .NET 5.0.17/6.0.36/7.0.20 desktop runtimes; system .NET 8/9/10).
**Result: 11/11 TFMs Ã— 230 types, 0 failures** after the fixes above.

Extended Toolkit smoke matrix (`Scripts/SmokeTest --dir` over every module output directory):
**654 of 659 module Ã— TFM runs green (â‰ˆ11,000 type instantiations)** after the E1â€“E23 fixes;
the 5 non-green runs are Software.Updater net5.0â€“net9.0, a documented raw-DLL-loader artifact of
the harness (see E24), not module defects. Full matrix summary in
`docs/audit/EXTENDED-BUILD-TRIAGE.md` Â§7. The core `PaletteFormBorder` fix (E4) was re-verified
by a warning-clean core solution build (0 errors / 0 warnings).
