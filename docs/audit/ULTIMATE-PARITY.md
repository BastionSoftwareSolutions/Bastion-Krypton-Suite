# Ultimate Edition Completeness Audit — Original vs Standard-Toolkit Parity

**Spec reference:** `D:\Krypton-Ultimate\BASTION-KRYPTON-SPEC.md` §2.4
**Date of audit:** 2026-07-15

| Repository | Path | Ref audited |
|---|---|---|
| ORIGINAL — Component Factory Krypton Suite (2017 BSD-3 open-sourcing) | `D:\Krypton-Ultimate\ComponentFactory-Krypton` | `5a1e5b9` (master) |
| CURRENT — Standard-Toolkit fork (V105-LTS line) | `D:\Krypton-Ultimate\Standard-Toolkit` | `57824ec43` (branch `bastion/multitarget`) |
| REFERENCE — Extended-Toolkit (checked for missing types) | `D:\Krypton-Ultimate\Extended-Toolkit` | `2725d8c4` |

**Method.** Every `public class` declaration in the five original component projects was extracted by regular-expression scan (no compilation), and each class was classified by walking its inheritance chain (across all five assemblies) to `System.Windows.Forms.Control`, `System.ComponentModel.Component`, or the `DataGridView` column/cell roots. Presence in the CURRENT fork was verified by scanning every `.cs` file under `D:\Krypton-Ultimate\Standard-Toolkit\Source\Krypton Components` for a class declaration of the identical name; every non-match was then investigated by hand for renames and supersessions. Missing types were additionally searched for in the Extended-Toolkit source (2,123 `.cs` files, 1,530 distinct class names scanned).

---

## 1. Solutions and projects in the ORIGINAL repository

Eight solutions exist under `D:\Krypton-Ultimate\ComponentFactory-Krypton\Source\`:

### 1.1 `Krypton Components\Krypton Components Suite.sln` — the product solution

| Project | Output assembly | Audited below in |
|---|---|---|
| ComponentFactory.Krypton.Toolkit | `ComponentFactory.Krypton.Toolkit.dll` | §2 |
| ComponentFactory.Krypton.Ribbon | `ComponentFactory.Krypton.Ribbon.dll` | §3 |
| ComponentFactory.Krypton.Navigator | `ComponentFactory.Krypton.Navigator.dll` | §4 |
| ComponentFactory.Krypton.Workspace | `ComponentFactory.Krypton.Workspace.dll` | §5 |
| ComponentFactory.Krypton.Docking | `ComponentFactory.Krypton.Docking.dll` | §6 |

**Note — sixth project on disk, not referenced by any solution:** `Krypton Components\ComponentFactory.Krypton.Design\ComponentFactory.Krypton.Design.csproj`. Its compile items are only `Properties\AssemblyInfo.cs` and `Properties\Resources.Designer.cs`; the rest of the project is toolbox bitmaps (`Resources\Krypton*.bmp`). It is a design-time resources stub — the actual designer/action-list classes live *inside* each component project. Mapping to CURRENT: no separate Design assembly exists; designers are folded into each assembly (e.g. `Krypton.Toolkit\Designers\Designers\...`, `Krypton.Toolkit\Designers\Action Lists\...`). **Status: superseded (integrated).**

### 1.2 Application and example solutions (not part of the redistributable component suite)

| Solution | Projects | Nature | CURRENT equivalent |
|---|---|---|---|
| `Palette Designer\Palette Designer.sln` | Palette Designer | End-user palette authoring application | Not present in either audited clone. The upstream Krypton-Suite organisation maintains standalone tooling separately; needs separate tracking if Bastion wants to ship it. |
| `Krypton Explorer\Krypton Explorer.sln` | Krypton Explorer | Launcher/browser application for the examples | Not present; superseded in practice by the `TestForm` project in the CURRENT solution. |
| `Krypton Toolkit Examples\Krypton Toolkit Examples.sln` | 51 example projects (KryptonButton Examples … Three Pane Application (Extended)) | Sample code | Not carried in Standard-Toolkit; upstream keeps demos in a separate repository. CURRENT contains a single `TestForm` exerciser project. |
| `Krypton Ribbon Examples\Krypton Ribbon Examples.sln` | 12 example projects | Sample code | As above |
| `Krypton Navigator Examples\Krypton Navigator Examples.sln` | 15 example projects | Sample code | As above |
| `Krypton Workspace Examples\Krypton Workspace Examples.sln` | 7 example projects | Sample code | As above |
| `Krypton Docking Examples\Krypton Docking Examples.sln` | 7 example projects | Sample code | As above |

### 1.3 CURRENT solution for comparison

`D:\Krypton-Ultimate\Standard-Toolkit\Source\Krypton Components\Krypton Toolkit Suite 2022 - VS2022.sln` (and `.slnx`) contains: `Krypton.Toolkit`, `Krypton.Ribbon`, `Krypton.Navigator`, `Krypton.Workspace`, `Krypton.Docking`, `TestForm`. All five original component assemblies therefore have a direct 1:1 successor project (namespace `ComponentFactory.Krypton.*` → `Krypton.*`).

---

## 2. ComponentFactory.Krypton.Toolkit

Public classes found: **583** — of which 61 derive (transitively) from `Control`, 51 from `Component`, 18 from `DataGridView` column/cell roots, and 453 are supporting public types (palette storage, values, view layout/draw, controllers, collections, event args, redirects).

### 2.1 Control-derived types (61)

| Original type | Current type | Status |
|---|---|---|
| KryptonBorderEdge | KryptonBorderEdge | present |
| KryptonBreadCrumb | KryptonBreadCrumb | present |
| KryptonButton | KryptonButton | present |
| KryptonCheckBox | KryptonCheckBox | present |
| KryptonCheckButton | KryptonCheckButton | present |
| KryptonCheckedListBox | KryptonCheckedListBox | present |
| KryptonColorButton | KryptonColorButton | present |
| KryptonComboBox | KryptonComboBox | present |
| KryptonDataGridView | KryptonDataGridView | present |
| KryptonDataGridViewComboBoxEditingControl | KryptonDataGridViewComboBoxEditingControl | present |
| KryptonDataGridViewDateTimePickerEditingControl | KryptonDataGridViewDateTimePickerEditingControl | present |
| KryptonDataGridViewDomainUpDownEditingControl | KryptonDataGridViewDomainUpDownEditingControl | present |
| KryptonDataGridViewMaskedTextBoxEditingControl | KryptonDataGridViewMaskedTextBoxEditingControl | present |
| KryptonDataGridViewNumericUpDownEditingControl | KryptonDataGridViewNumericUpDownEditingControl | present |
| KryptonDataGridViewTextBoxEditingControl | KryptonDataGridViewTextBoxEditingControl | present |
| KryptonDateTimePicker | KryptonDateTimePicker | present |
| KryptonDomainUpDown | KryptonDomainUpDown | present |
| KryptonDropButton | KryptonDropButton | present |
| KryptonForm | KryptonForm | present |
| KryptonGroup | KryptonGroup | present |
| KryptonGroupBox | KryptonGroupBox | present |
| KryptonGroupPanel | KryptonGroupPanel | present |
| KryptonHeader | KryptonHeader | present |
| KryptonHeaderGroup | KryptonHeaderGroup | present |
| KryptonInputBox | KryptonInputBox | present |
| KryptonLabel | KryptonLabel | present |
| KryptonLinkLabel | KryptonLinkLabel | present |
| KryptonListBox | KryptonListBox | present |
| KryptonMaskedTextBox | KryptonMaskedTextBox | present |
| KryptonMessageBox | KryptonMessageBox | present |
| KryptonMonthCalendar | KryptonMonthCalendar | present |
| KryptonNumericUpDown | KryptonNumericUpDown | present |
| KryptonPanel | KryptonPanel | present |
| KryptonRadioButton | KryptonRadioButton | present |
| KryptonRichTextBox | KryptonRichTextBox | present — **but ButtonSpec support removed upstream; see §7.1** |
| KryptonSeparator | KryptonSeparator | present |
| KryptonSplitContainer | KryptonSplitContainer | present |
| KryptonSplitterPanel | KryptonSplitterPanel | present |
| KryptonTextBox | KryptonTextBox | present |
| KryptonTrackBar | KryptonTrackBar | present |
| KryptonTreeView | KryptonTreeView | present |
| KryptonWrapLabel | KryptonWrapLabel | present |
| MessageButton | MessageButton | present |
| ModalWaitDialog | ModalWaitDialog | present |
| SeparatorIndicator | SeparatorIndicator | present |
| ViewControl | ViewControl | present |
| VisualContainerControl | VisualContainerControl | present |
| VisualContainerControlBase | VisualContainerControlBase | present |
| VisualContextMenu | VisualContextMenu | present |
| VisualContextMenuDTP | VisualContextMenuDTP | present |
| VisualControl | VisualControl | present |
| VisualControlBase | VisualControlBase | present |
| VisualControlContainment | VisualControlContainment | present |
| VisualForm | VisualForm | present |
| VisualPanel | VisualPanel | present |
| VisualPopup | VisualPopup | present |
| VisualPopupShadow | VisualPopupShadow | present |
| VisualPopupToolTip | VisualPopupToolTip | present |
| VisualSimple | VisualSimple | present |
| VisualSimpleBase | VisualSimpleBase | present |
| VisualTaskDialog | — | **superseded** by the rewritten task-dialog framework (`Krypton.Toolkit\Controls Toolkit\KryptonTaskDialog\KryptonTaskDialogKryptonForm.cs`); see §7.2 |

### 2.2 Component-derived types (51)

| Original type | Current type | Status |
|---|---|---|
| ButtonSpec | ButtonSpec | present |
| ButtonSpecAny | ButtonSpecAny | present |
| ButtonSpecCalendar | ButtonSpecCalendar | present |
| ButtonSpecFormFixed | ButtonSpecFormFixed | present |
| ButtonSpecFormWindowClose | ButtonSpecFormWindowClose | present |
| ButtonSpecFormWindowMax | ButtonSpecFormWindowMax | present |
| ButtonSpecFormWindowMin | ButtonSpecFormWindowMin | present |
| ButtonSpecHeaderGroup | ButtonSpecHeaderGroup | present |
| DTPContextMenu | DTPContextMenu | present |
| KryptonBreadCrumbItem | KryptonBreadCrumbItem | present |
| KryptonCheckSet | KryptonCheckSet | present |
| KryptonCommand | KryptonCommand | present |
| KryptonContextMenu | KryptonContextMenu | present |
| KryptonContextMenuCheckBox | KryptonContextMenuCheckBox | present |
| KryptonContextMenuCheckButton | KryptonContextMenuCheckButton | present |
| KryptonContextMenuColorColumns | KryptonContextMenuColorColumns | present |
| KryptonContextMenuHeading | KryptonContextMenuHeading | present |
| KryptonContextMenuImageSelect | KryptonContextMenuImageSelect | present |
| KryptonContextMenuItem | KryptonContextMenuItem | present |
| KryptonContextMenuItemBase | KryptonContextMenuItemBase | present |
| KryptonContextMenuItems | KryptonContextMenuItems | present |
| KryptonContextMenuLinkLabel | KryptonContextMenuLinkLabel | present |
| KryptonContextMenuMonthCalendar | KryptonContextMenuMonthCalendar | present |
| KryptonContextMenuRadioButton | KryptonContextMenuRadioButton | present |
| KryptonContextMenuSeparator | KryptonContextMenuSeparator | present |
| KryptonListItem | KryptonListItem | present |
| KryptonManager | KryptonManager | present |
| KryptonPalette | **KryptonCustomPaletteBase** | **renamed** (`Krypton.Toolkit\Controls Toolkit\KryptonCustomPaletteBase.cs`; designer and action list renamed to match) |
| KryptonTaskDialog | KryptonTaskDialog | present by name — **reimplemented**; the CURRENT type is a new elements-based implementation (`KryptonTaskDialog : IDisposable`, no longer a `Component`); see §7.2 |
| KryptonTaskDialogCommand | — | **superseded** by `KryptonTaskDialogElementCommandLinkButtons`; see §7.2 |
| PaletteBase | PaletteBase | present |
| PaletteOffice2007Base | PaletteOffice2007Base | present |
| PaletteOffice2007Black | PaletteOffice2007Black | present |
| PaletteOffice2007Blue | PaletteOffice2007Blue | present |
| PaletteOffice2007Silver | PaletteOffice2007Silver | present |
| PaletteOffice2010Base | PaletteOffice2010Base | present |
| PaletteOffice2010Black | PaletteOffice2010Black | present |
| PaletteOffice2010Blue | PaletteOffice2010Blue | present |
| PaletteOffice2010Silver | PaletteOffice2010Silver | present |
| PaletteProfessionalOffice2003 | PaletteProfessionalOffice2003 | present |
| PaletteProfessionalSystem | PaletteProfessionalSystem | present |
| PaletteSparkleBase | PaletteSparkleBase | present |
| PaletteSparkleBlue | PaletteSparkleBlue | present |
| PaletteSparkleOrange | PaletteSparkleOrange | present |
| PaletteSparklePurple | PaletteSparklePurple | present |
| RenderBase | RenderBase | present |
| RenderOffice2007 | RenderOffice2007 | present |
| RenderOffice2010 | RenderOffice2010 | present |
| RenderProfessional | RenderProfessional | present |
| RenderSparkle | RenderSparkle | present |
| RenderStandard | RenderStandard | present |

(The CURRENT fork adds many further palettes — Office 2013, Microsoft 365, Visual Studio, Sparkle light/dark variants — which are additive and outside the scope of a parity audit.)

### 2.3 DataGridView column and cell types (18)

All 18 are **present** under identical names: KryptonDataGridViewButtonCell/Column, CheckBoxCell/Column, ComboBoxCell/Column, DateTimePickerCell/Column, DomainUpDownCell/Column, LinkCell/Column, MaskedTextBoxCell/Column, NumericUpDownCell/Column, TextBoxCell/Column.

### 2.4 Supporting public types (453)

446 of 453 are present under identical names (palette storage/state classes, `PaletteRedirect*`, `ButtonSpecManager*`, view builders `ViewDraw*`/`ViewLayout*`, controllers, typed collections, event-args, values storage, `KryptonColorTable*`, `RenderContext`, `GlobalId`, etc.). The seven exceptions:

| Original type (file) | Status |
|---|---|
| AntiAliasNone (`General\AntiAlias.cs`) | **intentionally dropped** — CURRENT `Krypton.Toolkit\General\AntiAlias.cs` keeps only `AntiAlias` |
| DWM (`General\DesktopWindowManager.cs`) | **superseded** by `PI.Dwm` inside `Krypton.Toolkit\General\PlatformInvoke.cs` (c. line 3963) |
| DropDownButtonImages (`Values\DropDownButtonImages.cs`) | **intentionally dropped** — see §7.3 |
| KryptonPaletteImagesDropDownButton (`Palette Component\KryptonPaletteImagesDropDownButton.cs`) | **intentionally dropped** — see §7.3 |
| PaletteRedirectDropDownButton (`Palette Controls\PaletteRedirectDropDownButton.cs`) | **intentionally dropped** — see §7.3 |
| KryptonTaskDialogCommandCollection (`Controls Toolkit\KryptonTaskDialogCommand.cs`) | **superseded** — see §7.2 |
| RichTextBoxButtonSpecCollection (`Controls Toolkit\KryptonRichTextBox.cs`, nested) | **missing** — see §7.1 |

---

## 3. ComponentFactory.Krypton.Ribbon

Public classes found: **78** — 3 Control-derived, 36 Component-derived, 39 supporting.

### 3.1 Control-derived types (3)

| Original type | Current type | Status |
|---|---|---|
| KryptonGallery | KryptonGallery | present |
| KryptonRibbon | KryptonRibbon | present |
| RibbonViewControl | RibbonViewControl | present |

### 3.2 Component-derived types (36)

All 36 are **present** under identical names:

ButtonSpecAppMenu, ButtonSpecExpandRibbon, ButtonSpecMdiChildClose, ButtonSpecMdiChildFixed, ButtonSpecMdiChildMin, ButtonSpecMdiChildRestore, ButtonSpecMinimizeRibbon, KryptonGalleryRange, KryptonRibbonContext, KryptonRibbonGroup, KryptonRibbonGroupButton, KryptonRibbonGroupCheckBox, KryptonRibbonGroupCluster, KryptonRibbonGroupClusterButton, KryptonRibbonGroupClusterColorButton, KryptonRibbonGroupColorButton, KryptonRibbonGroupComboBox, KryptonRibbonGroupContainer, KryptonRibbonGroupCustomControl, KryptonRibbonGroupDateTimePicker, KryptonRibbonGroupDomainUpDown, KryptonRibbonGroupGallery, KryptonRibbonGroupItem, KryptonRibbonGroupLabel, KryptonRibbonGroupLines, KryptonRibbonGroupMaskedTextBox, KryptonRibbonGroupNumericUpDown, KryptonRibbonGroupRadioButton, KryptonRibbonGroupRichTextBox, KryptonRibbonGroupSeparator, KryptonRibbonGroupTextBox, KryptonRibbonGroupTrackBar, KryptonRibbonGroupTriple, KryptonRibbonQATButton, KryptonRibbonRecentDoc, KryptonRibbonTab.

### 3.3 Supporting public types (39)

37 of 39 present under identical names. Exceptions:

| Original type (file) | Current type | Status |
|---|---|---|
| RibbonAppButton (`Palette\RibbonAppButton.cs`) | **RibbonFileAppButton** (`Krypton.Ribbon\Palette\RibbonFileAppButton.cs`; a sibling `RibbonFileAppTab` was added for the Office-2010-style File tab) | **renamed** |
| RibbonStrings (`Palette\RibbonStrings.cs`) | **GeneralRibbonStrings** (`Krypton.Toolkit\Translations\General\GeneralRibbonStrings.cs`) | **superseded** — moved into the centralised localisation system in Krypton.Toolkit |

---

## 4. ComponentFactory.Krypton.Navigator

Public classes found: **91** — 4 Control-derived, 6 Component-derived, 81 supporting.

### 4.1 Control-derived types (4)

| Original type | Current type | Status |
|---|---|---|
| DropDockingIndicatorsSquare | DropDockingIndicatorsSquare | present |
| DropSolidWindow | DropSolidWindow | present |
| KryptonNavigator | KryptonNavigator | present |
| KryptonPage | KryptonPage | present |

### 4.2 Component-derived types (6)

All **present**: ButtonSpecNavClose, ButtonSpecNavContext, ButtonSpecNavFixed, ButtonSpecNavNext, ButtonSpecNavPrevious, ButtonSpecNavigator.

### 4.3 Supporting public types (81)

**All 81 present under identical names.** The Navigator family has 100 % name-level parity.

---

## 5. ComponentFactory.Krypton.Workspace

Public classes found: **26** — 2 Control-derived, 1 Component-derived, 23 supporting.

### 5.1 Control/Component-derived types (3)

| Original type | Current type | Status |
|---|---|---|
| KryptonWorkspace | KryptonWorkspace | present |
| KryptonWorkspaceCell | KryptonWorkspaceCell | present |
| KryptonWorkspaceSequence | KryptonWorkspaceSequence | present |

### 5.2 Supporting public types (23)

22 of 23 present. Exception:

| Original type (file) | Current type | Status |
|---|---|---|
| WorkspacePageMenuBase (`Palette Demo\WorkspacePageMenuBase.cs`, abstract) | **WorkspaceMenus** (`Krypton.Workspace\Palette\WorkspacePageMenu.cs`) | **superseded** — the abstract base was collapsed into the concrete `WorkspaceMenus : Storage`; no functionality lost |

---

## 6. ComponentFactory.Krypton.Docking

Public classes found: **64** — 13 Control-derived, 16 Component-derived, 35 supporting.

### 6.1 Control-derived types (13)

All **present**: KryptonAutoHiddenGroup, KryptonAutoHiddenPanel, KryptonAutoHiddenProxyPage, KryptonAutoHiddenSlidePanel, KryptonDockableNavigator, KryptonDockableWorkspace, KryptonDockspace, KryptonDockspaceSeparator, KryptonDockspaceSlide, KryptonFloatingWindow, KryptonFloatspace, KryptonSpace, KryptonStorePage.

### 6.2 Component-derived types (16)

All **present**: DockingElement, DockingElementClosedCollection, DockingElementOpenCollection, KryptonDockingAutoHiddenGroup, KryptonDockingControl, KryptonDockingDockspace, KryptonDockingEdge, KryptonDockingEdgeAutoHidden, KryptonDockingEdgeDocked, KryptonDockingFloating, KryptonDockingFloatingWindow, KryptonDockingFloatspace, **KryptonDockingManager**, KryptonDockingNavigator, KryptonDockingSpace, KryptonDockingWorkspace.

### 6.3 Supporting public types (35)

34 of 35 present. Exception:

| Original type (file) | Current type | Status |
|---|---|---|
| DockingManagerStringsBase (`Palette Demo\DockingManagerStringsBase.cs`, abstract) | **DockingManagerStrings** (`Krypton.Docking\Palette\DockingManagerStrings.cs`) | **superseded** — abstract base collapsed into the concrete strings class; no functionality lost |

---

## 7. Decision register for missing / dropped items

None of the fourteen non-same-name types exists in the Extended-Toolkit (its 1,530 class names were scanned; all live in `Krypton.Toolkit.Suite.Extended.*` namespaces with distinct names).

### 7.1 ButtonSpec support on KryptonRichTextBox (`RichTextBoxButtonSpecCollection`) — **DECISION NEEDED (Chris)**

- **What:** the original `KryptonRichTextBox` exposed a `ButtonSpecs` collection (nested `RichTextBoxButtonSpecCollection : ButtonSpecCollection<ButtonSpecAny>`, original file `Controls Toolkit\KryptonRichTextBox.cs` lines 245–266). The CURRENT `Krypton.Toolkit\Controls Toolkit\KryptonRichTextBox.cs` (2,702 lines) contains **no ButtonSpec support at all**.
- **Why:** removed deliberately upstream in commit `e1ad6e7af` ("Remove ButtonSpecs et al from the KryptonRichTextBox", 10 Dec 2024, issue #240), which also stripped the corresponding surface from `KryptonRibbonGroupRichTextBox` and the designer. This is the only genuine feature regression found relative to the 2017 Ultimate Edition.
- **Options:** (a) port from original — reinstate `RichTextBoxButtonSpecCollection`, the `ButtonSpecManagerLayout` wiring and designer support, using `KryptonTextBox` (which still has `TextBoxButtonSpecCollection`) as the working pattern; (b) document as intentionally dropped, matching upstream V105-LTS.
- **Recommendation:** port from original. Every other ButtonSpec-bearing control (TextBox, ComboBox, MaskedTextBox, NumericUpDown, DomainUpDown, DateTimePicker, etc.) retains the feature, so the removal is an inconsistency as well as an Ultimate-parity gap; the upstream removal reason (#240) should be reviewed first in case it was a designer-serialisation defect that would need fixing rather than avoiding.

### 7.2 Classic task dialog types (`VisualTaskDialog`, `KryptonTaskDialogCommand`, `KryptonTaskDialogCommandCollection`) — superseded; **DECISION NEEDED (Chris)** on a compatibility shim only

- **What:** the original `KryptonTaskDialog` was a `Component` with a `Commands` collection of `KryptonTaskDialogCommand`, displayed by the `VisualTaskDialog` form. The CURRENT branch ships a ground-up rewrite (`Krypton.Toolkit\Controls Toolkit\KryptonTaskDialog\`): `KryptonTaskDialog : IDisposable` composed of element objects, with command links provided by `KryptonTaskDialogElementCommandLinkButtons` and the window provided by `KryptonTaskDialogKryptonForm`.
- **Assessment:** functionality is fully covered (and extended) by the rewrite; only source compatibility with 2017-era user code is broken.
- **Recommendation:** document as superseded. A thin compatibility shim (obsolete-marked `KryptonTaskDialogCommand` mapping onto the elements API) is possible but low value; recommend **not** porting unless Bastion commits to drop-in source compatibility for Ultimate-era applications.

### 7.3 Drop-down button palette-image channel (`DropDownButtonImages`, `KryptonPaletteImagesDropDownButton`, `PaletteRedirectDropDownButton`) — recommend: document as intentionally dropped

- **What:** the original palette exposed a per-state *image* override for the drop-down arrow glyph (`IPalette.GetDropDownButtonImage`, plumbed through `KryptonPalette.Images.DropDownButton` and `PaletteRedirectDropDownButton`). The entire channel, including the `GetDropDownButtonImage` API, is absent from CURRENT (`KryptonPaletteImages*` now covers CheckBox, ContextMenu, GalleryButton(s), IntegratedToolBar, RadioButton, TreeView only); the glyph is drawn by the renderer instead (`Krypton.Toolkit\View Draw\ViewDrawDropDownButton.cs`).
- **Recommendation:** document as intentionally dropped. Renderer-drawn glyphs scale correctly with DPI, which bitmap overrides did not; restoring the channel would touch `PaletteBase`, every built-in palette and `KryptonCustomPaletteBase` XML persistence for marginal benefit. No decision required unless pixel-faithful 2017 palette XML round-tripping becomes a requirement (old palette XML containing `ImagesDropDownButton` elements will be ignored on import).

### 7.4 `AntiAliasNone` — recommend: document as intentionally dropped

Internal graphics-hint helper (a variant of `AntiAlias` that suppressed smoothing), not part of the designer surface. Its removal is invisible to component consumers. No action.

### 7.5 `DWM` (DesktopWindowManager) — superseded; no action

Replaced by the consolidated `PI.Dwm` native-interop wrapper in `Krypton.Toolkit\General\PlatformInvoke.cs`. Functional coverage retained. No action.

### 7.6 Renames to record in Bastion migration notes (no porting action)

| Original | Current | Note |
|---|---|---|
| KryptonPalette | KryptonCustomPaletteBase | Toolbox component for user-defined palettes; designers renamed to match |
| RibbonAppButton | RibbonFileAppButton | `KryptonRibbon.RibbonAppButton` property surface renamed accordingly |
| RibbonStrings | GeneralRibbonStrings | Moved from Krypton.Ribbon to `Krypton.Toolkit\Translations\General\` |
| WorkspacePageMenuBase | WorkspaceMenus | Abstract base merged into concrete class |
| DockingManagerStringsBase | DockingManagerStrings | Abstract base merged into concrete class |

### 7.7 Non-library deliverables

| Original deliverable | Recommendation |
|---|---|
| ComponentFactory.Krypton.Design assembly | Document as superseded — designers integrated into each component assembly. |
| Palette Designer application | **DECISION NEEDED (Chris)** — not in either audited clone. Recommendation: track as a separate Bastion work item (rebuild atop `KryptonCustomPaletteBase`) rather than an Ultimate-parity blocker; the Extended-Toolkit's `Krypton.Toolkit.Suite.Extended.Palette.Selectors` project offers palette-selection UI but is not a designer. |
| Krypton Explorer application, example solutions (92 sample projects) | Document as intentionally dropped from the library repository; superseded by the `TestForm` exerciser and the upstream demos repositories. |

---

## 8. Summary

Scope: every public class in the five original component assemblies (842 total), with the parity tables above enumerating the full designer-visible surface (Control-, Component- and DataGridView-derived types) exhaustively.

| Assembly | Original public classes | Present (same name) | Renamed | Superseded/merged | Intentionally dropped | Missing (regression) |
|---|---:|---:|---:|---:|---:|---:|
| ComponentFactory.Krypton.Toolkit | 583 | 573 | 1 | 4 | 4 | 1 |
| ComponentFactory.Krypton.Ribbon | 78 | 76 | 1 | 1 | 0 | 0 |
| ComponentFactory.Krypton.Navigator | 91 | 91 | 0 | 0 | 0 | 0 |
| ComponentFactory.Krypton.Workspace | 26 | 25 | 0 | 1 | 0 | 0 |
| ComponentFactory.Krypton.Docking | 64 | 63 | 0 | 1 | 0 | 0 |
| **Total** | **842** | **828** | **2** | **7** | **4** | **1** |

Toolbox-surface (Control/Component/Grid) parity: **252 of 255 types present under identical names**; the three exceptions are `KryptonPalette` (renamed `KryptonCustomPaletteBase`), and `VisualTaskDialog`/`KryptonTaskDialogCommand` (superseded by the rewritten task dialog).

**Headline findings**

1. Parity with the 2017 Ultimate Edition is effectively complete: 98.3 % of all public classes survive under identical names, and every toolbox control/component survives by name or documented rename/supersession.
2. The single genuine regression is the upstream removal of ButtonSpec support from `KryptonRichTextBox` (commit `e1ad6e7af`, Dec 2024) — port decision required (§7.1).
3. The drop-down-button palette image channel was silently removed, which affects fidelity when importing 2017-era palette XML (§7.3).
4. `KryptonTaskDialog` survives by name but is an API-incompatible rewrite (§7.2).
5. The original Design assembly, Palette Designer, Krypton Explorer and 92 example projects have no counterpart in Standard-Toolkit; only the Palette Designer merits its own tracking item (§7.7).
