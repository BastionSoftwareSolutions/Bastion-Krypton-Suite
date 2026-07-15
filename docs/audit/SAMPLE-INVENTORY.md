# Sample / Demo Project Inventory

**Bastion Krypton Suite — Phase 1 audit deliverable** (spec: `D:\Krypton-Ultimate\BASTION-KRYPTON-SPEC.md` §2.6 / Phase 4).
Date: 2026-07-15. Read-only inventory of the three local clones. All paths are absolute; UK English throughout.

Repos audited:

| # | Repo | Local path | Role |
|---|------|-----------|------|
| 1 | Standard-Toolkit-Demos | `D:\Krypton-Ultimate\Standard-Toolkit-Demos` | Current maintained demo set for the Standard Toolkit |
| 2 | ComponentFactory-Krypton | `D:\Krypton-Ultimate\ComponentFactory-Krypton` | Original 2017 Component Factory Ultimate source |
| 3 | Extended-Toolkit | `D:\Krypton-Ultimate\Extended-Toolkit` | Extended modules + single combined Examples harness |

---

## 1. Repo 1 — Standard-Toolkit-Demos (modern, maintained)

- Root: `D:\Krypton-Ultimate\Standard-Toolkit-Demos\Source`
- **125 sample projects**, all **C#**, all executable WinForms apps (`WinExe`).
- Target frameworks: **`net48;net8.0-windows;net9.0-windows`** uniformly (all 125 csproj files).
- Two solution flavours per category: *Dev* (ProjectReference into `..\..\..\..\Standard-Toolkit\Source\Krypton Components\*`) and *NuGet* (`Krypton.*.Canary` packages) — see `D:\Krypton-Ultimate\Standard-Toolkit-Demos\README.md`.
- Non-sample project: `Source\WixInstaller` (MSI packaging for the compiled demos — not a demo).

### 1.1 Krypton Toolkit Examples (83 projects) — exercises `Krypton.Toolkit`

Path prefix: `D:\Krypton-Ultimate\Standard-Toolkit-Demos\Source\Krypton Toolkit Examples\<name>\<name> 2022.csproj`

| Project | Demonstrates |
|---|---|
| ButtonSpec Playground | Interactive ButtonSpec configuration on Krypton containers |
| Child Control Stack | Stacking child Krypton controls inside groups |
| Custom Control using Palettes | Building a custom control on the Krypton palette engine |
| Custom Control using Renderers | Building a custom control on the Krypton renderer engine |
| Expanding HeaderGroups (DockStyle) | Collapsible KryptonHeaderGroup layout via DockStyle |
| Expanding HeaderGroups (Splitters) | Collapsible header groups with splitters |
| Expanding HeaderGroups (Stack) | Collapsible header groups in a stack layout |
| Input Form | Simple themed data-entry form |
| IntegratedToolbarExample | Toolbar integrated into the KryptonForm title bar |
| Krypton Scrollbars | Themed scrollbar controls |
| Krypton Theme Playground | Interactive playground for all controls across themes |
| Krypton Theme Selector | KryptonThemeComboBox/ListBox theme switching |
| Krypton UAC Button | UAC-shielded button |
| KryptonAboutBox Example | KryptonAboutBox dialogue |
| KryptonAboutToolkit Example | KryptonAboutToolkit dialogue |
| KryptonBorderEdge Examples | KryptonBorderEdge control |
| KryptonBreadCrumb Examples | KryptonBreadCrumb control |
| KryptonButton Examples | KryptonButton styles/states |
| KryptonCheckBox Examples | KryptonCheckBox |
| KryptonCheckButton Examples | KryptonCheckButton |
| KryptonCheckSet Examples | KryptonCheckSet grouping |
| KryptonCheckedListBox Examples | KryptonCheckedListBox |
| KryptonColorButton Examples | KryptonColorButton |
| KryptonColorDialog Example | Themed colour dialogue |
| KryptonComboBox Examples | KryptonComboBox |
| KryptonCommand Examples | KryptonCommand action binding |
| KryptonCommandLinkButton Examples | Vista-style command-link button |
| KryptonContextMenu Examples | KryptonContextMenu item types |
| KryptonDataGridView Examples | Themed DataGridView |
| KryptonDateTimePicker Examples | KryptonDateTimePicker |
| KryptonDomainUpDown Examples | KryptonDomainUpDown |
| KryptonDropButton Examples | KryptonDropButton |
| KryptonFolderBrowserDialog Example | Themed folder-browser dialogue |
| KryptonFontDialog Example | Themed font dialogue |
| KryptonForm Examples | KryptonForm chrome/styles |
| KryptonFormFading Example | Form fade in/out effects |
| KryptonGroup Examples | KryptonGroup container |
| KryptonGroupBox Examples | KryptonGroupBox |
| KryptonHeader Examples | KryptonHeader |
| KryptonHeaderGroup Examples | KryptonHeaderGroup |
| KryptonHelpIcon Examples | Help-icon component |
| KryptonInputBox Examples | KryptonInputBox |
| KryptonLabel Examples | KryptonLabel |
| KryptonLinkLabel Examples | KryptonLinkLabel |
| KryptonLinkWrapLabel Example | Wrapping link label |
| KryptonListBox Examples | KryptonListBox |
| KryptonListView Examples | Themed ListView |
| KryptonMaskedTextBox Examples | KryptonMaskedTextBox |
| KryptonMessageBox Examples | KryptonMessageBox options |
| KryptonMonthCalendar Examples | KryptonMonthCalendar |
| KryptonNumericUpDown Examples | KryptonNumericUpDown |
| KryptonOpenFileDialog Example | Themed open-file dialogue |
| KryptonPageSetupDialog Example | Themed page-setup dialogue |
| KryptonPalette Examples | KryptonPalette create/import/export |
| KryptonPanel Examples | KryptonPanel |
| KryptonPrintDialog Example | Themed print dialogue |
| KryptonProgressbar Examples | KryptonProgressBar |
| KryptonPropertyGridExample | Themed PropertyGrid |
| KryptonRadioButton Examples | KryptonRadioButton |
| KryptonRichTextBox Examples | KryptonRichTextBox |
| KryptonSaveFileDialog Example | Themed save-file dialogue |
| KryptonScrollbar Examples | KryptonScrollbar control |
| KryptonSeparator Examples | KryptonSeparator |
| KryptonSplitContainer Examples | KryptonSplitContainer |
| KryptonStringCollectionEditor Examples 2022 | String-collection editor dialogue |
| KryptonTableLayoutPanel Examples | Themed TableLayoutPanel |
| KryptonTaskDialog Examples | KryptonTaskDialog |
| KryptonTextBox Examples | KryptonTextBox |
| KryptonToastNotification Examples | Toast notifications (core toolkit implementation) |
| KryptonToggleSwitch Examples | KryptonToggleSwitch (core toolkit implementation) |
| KryptonToolStripMenuItem Examples | Themed ToolStrip menu items |
| KryptonTrackBar Examples | KryptonTrackBar |
| KryptonTreeView Examples | KryptonTreeView |
| KryptonWebBrowser Example | Themed WebBrowser wrapper |
| KryptonWrapLabel Examples | KryptonWrapLabel |
| MDI Application | MDI parent/child theming |
| SystemThemedForms | Following the OS light/dark theme |
| Test Clip Base | Regression harness: clipping in base controls |
| Test Combo Domain Numeric | Regression harness: combo/domain/numeric up-down |
| Test MessageBox Clipping | Regression harness: MessageBox text clipping |
| Test Text Clipping | Regression harness: text clipping |
| Three Pane Application (Basic) | Classic three-pane app layout |
| Three Pane Application (Extended) | Three-pane layout with extra Krypton features |

### 1.2 Krypton Ribbon Examples (12 projects) — exercises `Krypton.Ribbon` (+ Toolkit; some + Navigator/Workspace)

Path prefix: `...\Source\Krypton Ribbon Examples\`

| Project | Demonstrates |
|---|---|
| Application Menu | Ribbon application (file) menu |
| Auto Shrinking Groups | Group resize/shrink behaviour |
| Contextual Tabs | Contextual tab groups |
| KeyTips + Keyboard Access | KeyTips and keyboard navigation |
| KryptonGallery Examples | Gallery control basics |
| MDI Ribbon | Ribbon merging in MDI |
| Outlook Mail Clone | Composite app mock-up (Ribbon + Navigator style UI) |
| Quick Access Toolbar | QAT customisation |
| Ribbon + Navigator + Workspace | Ribbon combined with Navigator and Workspace |
| Ribbon Controls | All ribbon group item types |
| Ribbon Gallery | Gallery inside ribbon groups |
| Ribbon ToolTips | Ribbon tooltip configuration |

### 1.3 Krypton Navigator Examples (15 projects) — exercises `Krypton.Navigator` (+ Toolkit)

Path prefix: `...\Source\Krypton Navigator Examples\`

| Project | Demonstrates |
|---|---|
| Basic Events | Page selection/close events |
| Expanding Pages | Expand/collapse page behaviour |
| Navigator Context Menus | Per-page context menus |
| Navigator Modes | All NavigatorMode values |
| Navigator Palettes | Per-navigator palette overrides |
| Navigator Playground | Interactive property playground |
| Navigator ToolTips | Page tooltip configuration |
| OneNote Tabs | OneNote-style tab appearance |
| Orientation + Alignment | Tab orientation and alignment |
| Outlook Mockup | Outlook-style navigation pane |
| Per-Tab Buttons | ButtonSpecs per page/tab |
| Popup Pages | Popup page display |
| Singleline + Multiline | Single vs multi-line tab layouts |
| Tab Border Styles | Tab border style gallery |
| User Page Creation | Runtime page creation by the user |

### 1.4 Krypton Workspace Examples (7 projects) — exercises `Krypton.Workspace` (+ Toolkit, Navigator)

Path prefix: `...\Source\Krypton Workspace Examples\`

| Project | Demonstrates |
|---|---|
| Advanced Page Drag + Drop | Cross-workspace drag and drop |
| Basic Page Drag + Drop | Basic page drag and drop |
| Cell Maximize + Restore | Cell maximise/restore |
| Memo Editor | Small workspace-based editor app |
| Workspace Cell Layout | Sequence/splitter cell layouts |
| Workspace Cell Modes | Cell navigator display modes |
| Workspace Persistence | Save/load workspace layout XML |

### 1.5 Krypton Docking Examples (7 projects) — exercises `Krypton.Docking` (+ Toolkit, Navigator, Workspace, Ribbon)

Path prefix: `...\Source\Krypton Docking Examples\`

| Project | Demonstrates |
|---|---|
| Docking Customized | Customising docking behaviour/appearance |
| Docking Flags | Per-page docking capability flags |
| Docking Persistence | Save/load docking layout |
| External Drag To Docking | Dragging external content into dock targets |
| Multi Control Docking | Docking arbitrary controls |
| Navigator + FloatingWindows | Navigator pages with floating windows |
| Standard Docking | Canonical VS-style docking app |

### 1.6 Other

| Project | Path | Demonstrates |
|---|---|---|
| Krypton Explorer | `...\Source\Krypton Explorer\Krypton Explorer 2022.csproj` | Launcher/browser for the compiled examples (per `README.md`) |

---

## 2. Repo 2 — ComponentFactory-Krypton (original 2017 Ultimate)

- Root: `D:\Krypton-Ultimate\ComponentFactory-Krypton\Source`
- **93 sample/tool projects**, all **C#** (old-style csproj, `TargetFrameworkVersion v4.0` — .NET Framework 4.0 — across all 99 project files including the six component libraries). **No VB.NET projects anywhere in the repo** (zero `.vbproj`).
- Samples reference the `ComponentFactory.Krypton.*` libraries in-tree. `Bin\`, `Help\`, `Images\`, `Change Lists\` contain binaries/docs, not samples.

Folder-name diff against Repo 1 shows the sample sets are **identical by name** per category (the modern repo simply appends " 2022" to csproj file names); the modern Toolkit category adds 33 new projects on top of the original 50.

| Category | Path | Count | Contents |
|---|---|---|---|
| Krypton Toolkit Examples | `...\Source\Krypton Toolkit Examples\` | 50 | Same-named subset of §1.1: ButtonSpec Playground, Child Control Stack, Custom Control using Palettes, Custom Control using Renderers, Expanding HeaderGroups (DockStyle/Splitters/Stack), Input Form, KryptonBorderEdge, KryptonBreadCrumb, KryptonButton, KryptonCheckBox, KryptonCheckButton, KryptonCheckSet, KryptonCheckedListBox, KryptonColorButton, KryptonComboBox, KryptonCommand, KryptonContextMenu, KryptonDataGridView, KryptonDateTimePicker, KryptonDomainUpDown, KryptonDropButton, KryptonForm, KryptonGroup, KryptonGroupBox, KryptonHeader, KryptonHeaderGroup, KryptonInputBox, KryptonLabel, KryptonLinkLabel, KryptonListBox, KryptonMaskedTextBox, KryptonMessageBox, KryptonMonthCalendar, KryptonNumericUpDown, KryptonPalette, KryptonPanel, KryptonRadioButton, KryptonRichTextBox, KryptonSeparator, KryptonSplitContainer, KryptonTaskDialog, KryptonTextBox, KryptonTrackBar, KryptonTreeView, KryptonWrapLabel Examples, MDI Application, Three Pane Application (Basic/Extended) |
| Krypton Ribbon Examples | `...\Source\Krypton Ribbon Examples\` | 12 | Identical names to §1.2 |
| Krypton Navigator Examples | `...\Source\Krypton Navigator Examples\` | 15 | Identical names to §1.3 |
| Krypton Workspace Examples | `...\Source\Krypton Workspace Examples\` | 7 | Identical names to §1.4 |
| Krypton Docking Examples | `...\Source\Krypton Docking Examples\` | 7 | Identical names to §1.5 |
| Krypton Explorer | `...\Source\Krypton Explorer\Krypton Explorer.csproj` | 1 | Example launcher/browser (original of §1.6) |
| **Palette Designer** | `...\Source\Palette Designer\Palette Designer.csproj` | 1 | **Standalone palette-authoring tool — no equivalent project in the modern demos repo** |

---

## 3. Repo 3 — Extended-Toolkit

- Root: `D:\Krypton-Ultimate\Extended-Toolkit\Source\Krypton Toolkit`
- **63 Extended module libraries** (`Krypton.Toolkit.Suite.Extended.*`), but only **one demo project for the whole suite**:

| Project | Path | Language | TFMs | Demonstrates |
|---|---|---|---|---|
| Examples | `D:\Krypton-Ultimate\Extended-Toolkit\Source\Krypton Toolkit\Examples\Examples.csproj` | C# | `net481;net8.0-windows` | Single WinExe menu app (`MainWindow`) with one form per demonstrated feature; references most module projects by ProjectReference plus core `Krypton.Toolkit`/`Krypton.Ribbon` |

Utility apps in the same tree that are **tools, not demos**: `AutoUpdateCreator\AutoUpdateCreator.csproj` and `ZipExtractor\ZipExtractor.csproj` (support `Software.Updater`).

### 3.1 Extended modules WITH a dedicated demo form in `Examples` (23)

| Module | Demo form(s) in `Examples` |
|---|---|
| AdvancedDataGridView | `AdvancedDataGridView.cs` |
| Buttons | `ButtonItems.cs` |
| Calendar | `CalendarItems.cs` |
| CheckSum.Tools | `CheckSumExample.cs` |
| Circular.ProgressBar | `CircularProgressBarExample.cs` |
| ComboBox | `CheckBoxComboBoxTest.cs` |
| Controls | `ExtendedControlExamples.cs`, `RadialMenuExample.cs`, `KryptonProgressBarExtendedExamples.cs` |
| Core | `CoreDialogExamples.cs`, `CoreColourDialogExamples.cs` |
| Dialogs | `DialogExamples.cs` |
| Dock.Extender | `DockExtenderExample.cs` |
| Floating.Toolbars | `FloatingMenuToolbarExampleMain.cs`, `FloatingMenuToolbarAdvancedExample.cs` |
| Forms | `KryptonFormExtended1.cs`, `KryptonFormExtended2.cs` |
| InputBox | `KryptonInputBoxExtendedExample.cs` |
| Memory.Box | `MemoryBoxExample.cs` |
| Messagebox | `MessageBoxExample.cs` |
| Navi.Suite | `NaviBarExample.cs` |
| Ribbon | `KryptonRibbonExtendedExample.cs` |
| Theme.Switcher | `ExternalThemeSelectorChooser.cs`, `ThemeTools.cs` (confirmed `using Krypton.Toolkit.Suite.Extended.Theme.Switcher`) |
| ToastNotification | `BasicToastNotificationTest.cs`, `ToastNotificationMenu.cs` |
| Tool.Box | `ToolBoxExample.cs` |
| Tool.Strip.Items | `ToolStripItems.cs` |
| TreeGridView | `TreeGridViewExample.cs`, `TreeGridViewAdvancedExample.cs`, `TreeGridViewDataSourceExample.cs` |
| Wizard | `WizardExample.cs` |

### 3.2 Modules referenced by `Examples` but with NO dedicated demo form (23)

Common, Compression, Data.Visualisation, DataGridView, Developer.Utilities, Drawing, Drawing.Utilities, Effects, Error.Reporting, File.Copier, Global.Utilities, IO, Language.Model, Navigator, Networking, Notifications, Panels, Resources, Settings, Specialised.Dialogs, Toggle.Switch, Utilities, VirtualTreeColumnView.
(Referenced in `Examples.csproj` so they load, but nothing in the UI exercises them specifically. Several — Common, Shared, Resources, Global.Utilities — are infrastructure and may not need a demo.)

### 3.3 Modules with NO demo anywhere (17) — need purpose-written samples per spec v1.1

Debug.Tools, File.Explorer (reference commented out), Gages (commented out), MessageDialog, Outlook.Grid, PDF, Palette.Selectors (commented out), Scintilla.NET, Security, Shared (infrastructure), Software.Updater (commented out), Software.Updater.Core, TaskDialogs (commented out), Themes, Tools (commented out), Ultimate (meta-package), Ultimate.Lite (meta-package).
Commented-out references in `Examples.csproj` suggest these modules currently fail to build or are under development — cross-check with `EXTENDED-INVENTORY.md` go/no-go decisions.

---

## 4. De-duplication map (spec Phase 4 rule: modern wins; keep original only if it shows something the modern set lost)

Every original sample folder name exists verbatim in the modern repo (verified by `comm`/`diff` on folder listings), so the map collapses to category level plus one exception:

| Original (ComponentFactory-Krypton) | Modern equivalent (Standard-Toolkit-Demos) | Verdict |
|---|---|---|
| Krypton Toolkit Examples (50 projects) | Same 50 names under `Source\Krypton Toolkit Examples\` (of 83) | **Use modern** — retargeted to net48/net8/net9, maintained, superset |
| Krypton Ribbon Examples (12) | Same 12 names | **Use modern** |
| Krypton Navigator Examples (15) | Same 15 names | **Use modern** |
| Krypton Workspace Examples (7) | Same 7 names | **Use modern** |
| Krypton Docking Examples (7) | Same 7 names | **Use modern** |
| Krypton Explorer | `Source\Krypton Explorer\Krypton Explorer 2022.csproj` | **Use modern** |
| **Palette Designer** (`...\Source\Palette Designer\`) | **None in any of the three clones** (nearest partial overlap: `KryptonPalette Examples`, `Krypton Theme Playground`, `Krypton Theme Selector` — none is a full palette-authoring tool) | **Original only — keep/port.** Note: Krypton-Suite maintains a separate Palette-Designer repo upstream; verify before porting the 2017 code |
| — (33 modern-only Toolkit projects, e.g. dialog wrappers, ToastNotification, ToggleSwitch, PropertyGrid, theme tools, four `Test *` clipping harnesses) | Modern only | N/A — no original to de-duplicate |

No original sample demonstrates a scenario the same-named modern one dropped (identical folder/form sets; the modern versions are the same code retargeted and maintained). The original repo therefore contributes exactly **one** unique item: Palette Designer.

---

## 5. Coverage gaps

**(a) Five core component families** (`Krypton.Toolkit`, `Krypton.Ribbon`, `Krypton.Navigator`, `Krypton.Workspace`, `Krypton.Docking`):

- **None lacks a demo** — all five are covered (83/12/15/7/7 projects respectively).
- Qualitative gap: the Ribbon, Navigator, Workspace and Docking sets are **unchanged in name/scope since 2017** — only the Toolkit set has grown. Post-2017 features in those four libraries (newer themes, dark-mode ribbon behaviour, etc.) are exercised only incidentally.

**(b) Extended modules with NO demo anywhere** (need purpose-written samples per spec v1.1): the **17 modules in §3.3**; plus the **23 modules in §3.2** that are referenced but have no dedicated demo form and should each gain one. Excluding pure infrastructure/meta packages (Common, Shared, Resources, Global.Utilities, Ultimate, Ultimate.Lite), roughly **34 modules need new sample forms/projects**.

**(c) VB.NET baseline**: **zero**. No `.vbproj` exists in any of the three clones (verified by recursive search). Every sample everywhere is C#. The spec's 100% C#/VB parity target therefore means writing the entire VB.NET sample set from scratch in Phase 4 (~125 core samples + Extended samples).

---

## 6. Summary counts

| Repo | Sample/demo projects | Language | TFMs |
|---|---|---|---|
| Standard-Toolkit-Demos | **125** (83 Toolkit, 12 Ribbon, 15 Navigator, 7 Workspace, 7 Docking, 1 Explorer) + WixInstaller (non-demo) | C# | net48; net8.0-windows; net9.0-windows |
| ComponentFactory-Krypton | **93** (50 Toolkit, 12 Ribbon, 15 Navigator, 7 Workspace, 7 Docking, 1 Explorer, 1 Palette Designer) | C# | net40 |
| Extended-Toolkit | **1** combined `Examples` app (~28 demo forms covering 23 of 63 modules) + 2 utility apps | C# | net481; net8.0-windows |
| **Total distinct samples to carry forward** | **125 modern + 1 original-only (Palette Designer) + 1 Extended Examples** = **127** | C# 127 / VB 0 | — |

**Footnote:** the main `D:\Krypton-Ultimate\Standard-Toolkit` repo (outside this audit's scope) also contains a developer smoke-test app at `Source\Krypton Components\TestForm` — worth considering when planning the Phase 4 sample tree.
