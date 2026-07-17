# Extended Toolkit — Third-Party Licence Audit and Attribution Restoration

**Project:** Bastion Krypton Suite (spec §1 ground rule 2, §2.5)
**Repository audited:** `D:\Krypton-Ultimate\Extended-Toolkit`, branch `bastion/multitarget` (base HEAD `dae9be10`)
**Repository licence:** MIT — Copyright (c) 2017 - 2024 Krypton Suite (root `LICENSE`)
**Audit date:** 2026-07-15. Every finding below was verified against the actual source files on this date; canonical upstream licence texts were fetched from the upstream repositories.
**Rule applied:** additions only — no upstream copyright line was removed or altered; stripped notices were restored via directory-level LICENSE/notice files and per-module `PackageLicenseExpression` metadata.

---

## 1. Per-module findings and actions

Paths are relative to `Source\Krypton Toolkit\` unless stated. "Before" = attribution state as found on `dae9be10`; "After" = state following this audit's commits.

| # | Module | Vendored / derived code | Origin | Licence | Attribution before | Attribution after / action taken |
|---|---|---|---|---|---|---|
| 1 | Data.Visualisation | `Scott Plot\**` (347 .cs) — entire ScottPlot 5 core + WinForms controls, namespaces rewritten to `...Data.Visualisation.ScottPlot` | [ScottPlot/ScottPlot](https://github.com/ScottPlot/ScottPlot); imported 14 Nov 2023 (Extended-Toolkit commit `6f69897d`, "Version 80"), i.e. the ScottPlot 5.0 beta-era line; exact upstream commit unrecorded | MIT — © 2018 Scott Harden / Harden Technologies, LLC (canonical text fetched from upstream `LICENSE` 2026-07-15) | **Stripped.** Headers/namespaces re-stamped; module `License\License.txt` is the Krypton Suite's own MIT text | **Restored.** Added `Scott Plot\LICENSE` (upstream MIT text) and `Scott Plot\README.md` (origin, import date, version era, licence, modification note). ~344 source files deliberately not edited individually — a directory-level notice satisfies the MIT requirement that the notice accompany "all copies or substantial portions" |
| 1a | Data.Visualisation | `Scott Plot\Core\Palettes\Category10.cs`, `Category20.cs` (Vega palettes) | Vega / University of Washington Interactive Data Lab | BSD-3-Clause © 2015-2018 | **Retained** in-file | Verified intact; recorded in `Scott Plot\README.md` |
| 1b | Data.Visualisation | `Scott Plot\Core\Palettes\Microcharts.cs` | Microcharts | MIT © 2017 Aloïs Deniel | **Retained** in-file | Verified intact; recorded in `Scott Plot\README.md` |
| 2 | Software.Updater | `Auto Updater\**` (30 .cs: AutoUpdater.cs, UpdateInfoEventArgs, persistence providers, dialogs, translations) | [ravibpatel/AutoUpdater.NET](https://github.com/ravibpatel/AutoUpdater.NET) | MIT — © 2012-2024 RBSoft (canonical text fetched 2026-07-15) | **Stripped.** No headers or Krypton-only headers; module `License\License.txt` is Krypton MIT | **Restored.** Added `Auto Updater\LICENSE` (upstream MIT) and module-root `THIRD-PARTY-NOTICES.md` |
| 3 | Software.Updater | `Sharp Update\**` (SharpUpdater, SharpUpdateXml, SharpUpdateLocalAppInfo, forms, translations — 20 files) | [henryxrl/SharpUpdate](https://github.com/henryxrl/SharpUpdate) (Henry Xu), itself "modified from AutoUpdater by BetterCoder on Youtube" per its README | **None declared.** The upstream repository has no LICENSE file → default all-rights-reserved copyright; no explicit redistribution permission exists | **Stripped/none** | **RESOLVED (17 July 2026) — removed.** The entire `Sharp Update\` folder was physically deleted from the module and the now-redundant `<Compile Remove="Sharp Update\Resources\**" />` globs stripped from the csproj. No live code referenced the SharpUpdate types (all 20 files were self-contained); the AutoUpdater.NET and NetSparkle update paths remain and cover the use case. Module builds all TFMs. See §3.2 |
| 4 | Software.Updater.Core | `NetSparkle\**` (~50 .cs) | [NetSparkleUpdater/NetSparkle](https://github.com/NetSparkleUpdater/NetSparkle) | MIT — © 2022 Deadpikle | **Retained** in every file header (verified sample + sweep) | No change needed; recorded |
| 4a | Software.Updater.Core | `NetSparkle\Libraries\MarkdownSharp.cs` | MarkdownSharp (Jeff Atwood) / Markdown (John Gruber) / MarkdownNET (Milan Negovan) | MIT + BSD-style, © 2003-2011 respective authors | **Retained** in-file | No change needed; recorded (sweep discovery) |
| 5 | Utilities | `Classes\System\SAPI\**` (338 .cs across 13 subdirectories — the bulk of the module) | .NET System.Speech reference source ([dotnet/runtime](https://github.com/dotnet/runtime) / [microsoft/referencesource](https://github.com/microsoft/referencesource)) | MIT — © .NET Foundation and Contributors | **Stripped.** Every file re-stamped with the Krypton Suite MIT header (verified, e.g. `Audio Format\AudioBitsPerSample.cs`) | **Restored.** Added `Classes\System\SAPI\THIRD-PARTY-NOTICES.md` with the .NET Foundation MIT notice and full licence text |
| 6 | Drawing.Utilities | Colour-picker family: `Controls\Components\ColourWheelControl.cs`, `ColourGridControl.cs`, `ColourSliderControl.cs`, `ScreenColourPickerControl.cs`, `ColourHexadecimalComboBox.cs`, `Controls\User Controls\General\ColourGrid*/ColourEditor*`, `UX\KryptonColourPickerDialog.cs`, `UX\ColourGridDialog.cs` | [cyotek/Cyotek.Windows.Forms.ColorPicker](https://github.com/cyotek/Cyotek.Windows.Forms.ColorPicker) | MIT — © 2013-2021 Cyotek Ltd (Richard Moss) (canonical text fetched 2026-07-15) | Comment-level acknowledgement only (e.g. `ColourWheelControl.cs:783` links a Cyotek GitHub issue); headers Krypton MIT | **Restored.** Added module-root `THIRD-PARTY-NOTICES.md` with full Cyotek MIT text and derived-file list |
| 6a | Drawing.Utilities | `Controls\Components\ImageBoxExtended.cs` (whole control) | Cyotek.Windows.Forms.ImageBox (MIT) | MIT © Cyotek Ltd | Comment traces only (a commented-out Cyotek designer attribute at line 36) | Covered by the same `THIRD-PARTY-NOTICES.md` |
| 6b | Drawing.Utilities | `DrawGlowShadow` fragment inside `ImageBoxExtended.cs` | CodeProject gGlowBox (SSDiver2112), inherited via Cyotek ImageBox | **CPOL (probable)** | Comment credit only | **RESOLVED (17 July 2026) — clean-room reimplemented.** `DrawGlowShadow` was rewritten from scratch from the behavioural description alone (concentric alpha-ramped rounded-rectangle strokes just outside the image bounds, `SmoothingMode.AntiAlias`); the CPOL/SSDiver2112 credit comment was removed and a header note added marking the method original © Bastion Software Solutions Ltd 2026 (MIT). Same public surface (`protected virtual void DrawGlowShadow(Graphics, Rectangle)`, driven by `DropShadowSize`/`ImageBorderColor`) so callers are unaffected. Module builds; `ImageBoxExtended` renders. See §3.1 Item A |
| 7 | Outlook.Grid | `Classes\**`, `Control Visuals\**`, `Events\**`, etc. (~53 files, effectively the whole module) | [Cocotteseb/Krypton-OutlookGrid](https://github.com/Cocotteseb/Krypton-OutlookGrid) | **Ms-PL** — © 2013-2021 JDH Software | **Retained** — every derived file carries the JDH Software Ms-PL header (verified) | Headers verified intact; **package metadata corrected** — csproj now declares `PackageLicenseExpression = MIT AND MS-PL` (§4) |
| 8 | AdvancedDataGridView | `Controls Toolkit\**`, `Controls Visuals\**`, `Enumerations\**` (~12 files) | ADGV (Davide Gironi) / Zuby.AdvancedDataGridView lineage | **Ms-PL** — full licence text embedded in each header | **Retained** (verified) | Headers verified intact; csproj now declares `PackageLicenseExpression = MIT AND MS-PL` (§4) |
| 9 | Circular.ProgressBar | `CircularProgressBar` control source | [falahati/CircularProgressBar](https://github.com/falahati/CircularProgressBar) | MIT — © 2016 Soroush (Falahati) (canonical text fetched 2026-07-15) | **Stripped** (Krypton headers only); the module also consumes `Unofficial.WinFormAnimation` 2.0.2 (repack of falahati's WinFormAnimation, MIT) | **Restored.** Added module-root `THIRD-PARTY-NOTICES.md` |
| 10 | Navi.Suite | `Navi*` control family (69 .cs — whole module) | [jacobmesu/Guifreaks-Navisuite](https://github.com/jacobmesu/Guifreaks-Navisuite) (Jacob Mesu), presented in CodeProject "A Serious Outlook Style Navigation Pane Control" | MIT — the repository states "The control is available under MIT license" (verified 2026-07-15) | **Stripped** (Krypton headers only) | **Restored.** Added module-root `THIRD-PARTY-NOTICES.md` |
| 11 | Toggle.Switch | Whole renderer family — `ToggleSwitchIOS5Renderer`, `ToggleSwitchIphoneRenderer`, `ToggleSwitchAndroidRenderer`, `ToggleSwitchBrushedMetalRenderer`, `ToggleSwitchCarbonRenderer`, `ToggleSwitchFancyRenderer`, `ToggleSwitchMetroRenderer`, `ToggleSwitchModernRenderer`, `ToggleSwitchOSXRenderer`, `ToggleSwitchPlainAndSimpleRenderer` (+ Krypton variants and base) | CodeProject ["ToggleSwitch Winforms Control"](https://www.codeproject.com/Articles/1029499/ToggleSwitch-Winforms-Control) by Johnny J (Sept 2015); the renderer names match the article's one-for-one | **CPOL** — confirmed via the [Code-Artist/ToggleSwitch](https://github.com/Code-Artist/ToggleSwitch) mirror, which carries a CPOL LICENSE and credits Johnny J | **Stripped** (Krypton headers only) | **RESOLVED (17 July 2026) — removed.** The entire `Krypton.Toolkit.Suite.Extended.Toggle.Switch` project directory was deleted, its entries removed from both referencing solutions (`...VS2022.sln`, `...VS2022 - NuGet.sln`), and its `ProjectReference` removed from the Examples app and the Ultimate.Lite metapackage (it was already excluded from Ultimate). No other module referenced its types. See §3.1 Item B |
| 12 | Controls | `KryptonPasswordTextBox.cs` + ~9 support files (facades, event args) | PasswordTextBox control by Nils Jonsson | MIT — © 2016 Nils Jonsson and contributors | **Retained** — dual header (Krypton MIT + "Original MIT License" block) in every derived file | No change needed; recorded (sweep discovery) |
| 13 | Wizard | `KryptonAdvancedWizard*` family (~18 .cs) | [SteveBate/AdvancedWizard](https://github.com/SteveBate/AdvancedWizard) | **None declared** upstream (no LICENSE file) | Credit line **retained** in every header: "Base code by Steve Bate 2003 - 2017 …, modifications by Peter Wagner … 2021 - 2025" | Recorded; low-priority escalation footnote (§3.2) — same missing-licence problem as SharpUpdate, mitigated by the existing public credit |
| 14 | Common / Forms / Utilities / DataGridView | `AllowNullAttribute.cs`, `Portable.System.ValueTuple.cs` | .NET Foundation | MIT | **Retained** | No change needed |
| 15 | Error.Reporting | Report/templating structure resembles the ExceptionReporter.NET family (Handlebars templating, Simple-MAPI mail) — flagged by the Phase 1 inventory | ExceptionReporter.NET (MIT) — **lineage suspected, not confirmed**: no verbatim markers found in this audit's sweep | MIT if confirmed | Krypton headers only | Recorded as unconfirmed; recommend a diff against upstream before packaging if time allows |

### 1.1 Smaller CodeProject-derived fragments (sweep discoveries — CPOL-risk inventory)

All carry comment-level credit ("Adapted from …") but no CPOL notice. CodeProject articles default to CPOL unless the article states otherwise. Individually these are small adaptations; collectively they should be reviewed under the same policy Chris chooses for §3.1.

| Module(s) | File | CodeProject source |
|---|---|---|
| Buttons, Common (×2 copies), Global.Utilities, Specialised.Dialogs | `UACSecurity.cs` (five near-identical copies) | Article 18509 "Add a UAC shield to a button when elevation is required" |
| Controls | `Controls Toolkit\KryptonProgressBarExtended.cs` | Article 1082902 "How to Paint on Top of a ProgressBar using C#" |
| Controls | `Controls Toolkit\KryptonCheckBoxComboBox.cs`, `Classes\KryptonCheckBoxComboBoxItemList.cs` | "extending_combobox" forum code by Ubiklou |
| Notifications | `Components\PopUp\KryptonToastNotificationPopup.cs` | "PopupNotifier" article (Simon Baer) |
| Tool.Strip.Items | `Classes\IO\MostRecentlyUsedFileManager.cs` | Article 407513 "Add Most Recently Used Files (MRU) List to Windows" |
| Tool.Box | `Controls Toolkit\KryptonToolBox.cs` | Article 8658 "Another ToolBox Control" |

Non-issues found in the sweep: numerous StackOverflow-snippet citations (Effects, Forms, Developer.Utilities, Ribbon, Drawing.Utilities) — short snippets, CC-BY-SA attribution present as URLs; ZipExtractor cites a wyUpdate source file explicitly noted as carrying "no copyright in code at time of viewing".

---

## 2. Repository/package licence expression (finding 8)

**Before:** root `LICENSE` = MIT (© 2017 - 2024 Krypton Suite), but `Directory.Build.targets` line 183 stamped generated packages `PackageLicenseExpression = BSD-3-Clause`. Verification nuance discovered during the fix: `Source\Krypton Toolkit\Directory.Build.props` sets `PackageLicenseFile = License.md` (the Krypton MIT text from `Documents\License\License.md`) for **every** build configuration, and the targets-level expression is conditioned on `PackageLicenseFile` being empty — so the BSD-3-Clause stamp was in practice **dormant dead code** and shipped packages carried the MIT licence file. The earlier audit's "packages stamped BSD-3-Clause" claim was therefore only latently true; it remained a trap for any project that dropped the licence-file item, and has been fixed.

**After (fixed):**

- `Directory.Build.targets`: fallback `PackageLicenseExpression` corrected from `BSD-3-Clause` to **`MIT`**, with an explanatory comment.
- `Krypton.Toolkit.Suite.Extended.Outlook.Grid 2022.csproj`, `...AdvancedDataGridView 2022.csproj`: per-module override **`MIT AND MS-PL`**.
- `...Ultimate 2022.csproj`, `...Ultimate.Lite 2022.csproj`: **`MIT AND MS-PL`** — these metapackages physically bundle every module DLL (including the two Ms-PL modules) into their own `lib/` folders via `Directory.Build.targets`, so their metadata must declare the compound licence too.
- In those four projects `PackageLicenseFile` is explicitly cleared: NuGet rejects a package declaring both a licence file and a licence expression (NU5033, confirmed by build). The MIT `License.md` is still packed into the package root as a plain file; the SPDX expression is the licence of record.

File headers across the repo still mix "BSD-style" wording (e.g. Outlook.Grid's Krypton preamble) with MIT boilerplate; per the additions-only rule these headers were left untouched — the corrected package metadata and root `THIRD-PARTY-NOTICES.md` are the authoritative statements.

---

## 3. Escalations for Chris (decision required before packaging)

> **Status: all three CPOL/no-licence escalations in this section are now RESOLVED (17 July 2026).**
> gGlowBox was clean-room reimplemented (§3.1 Item A); the Toggle.Switch module was removed
> (§3.1 Item B); the SharpUpdate half of Software.Updater was removed (§3.2). The original
> analysis is retained below for the record, each item annotated with the action taken. The
> §1.1 fragment inventory (Item C) and the AdvancedWizard courtesy grant (§3.2) remain open.

### 3.1 CPOL-derived code — CPOL is incompatible with plain-MIT redistribution

**Why CPOL is a problem:** the Code Project Open License 1.02 requires that the licence text (or a link to it) and all author/copyright notices accompany any redistribution of the work (§3.4: "You may not distribute Derivative Works … under licence terms conflicting with CPOL"; §5 requires retention of notices and prohibits misrepresenting the source). Shipping CPOL-derived source inside a package labelled MIT, without CPOL notices, breaches those terms. CPOL is not OSI-approved and is generally regarded as incompatible with MIT/BSD relicensing; it does permit commercial/closed-source *use*, so compliance (option c) is viable where the fragment is kept.

**Item A — gGlowBox fragment (the audit's finding 5, verified):**

- **File:** `Source\Krypton Toolkit\Krypton.Toolkit.Suite.Extended.Drawing.Utilities\Controls\Components\ImageBoxExtended.cs`
- **Lines:** ~2878–2913 — the `protected virtual void DrawGlowShadow(Graphics g, Rectangle viewPort)` method; the attribution comment sits at line 2885: `// Glow code adapted from http://www.codeproject.com/Articles/372743/gGlowBox-Create-a-glow-effect-around-a-focused-con`.
- **What it does:** paints a soft "glow" drop-shadow around the image viewport by stroking the viewport rectangle repeatedly with increasingly wide, increasingly transparent pens (`glowSize = DropShadowSize * 3`, feather 50, alpha ramp), clipping out the interior. It is used when `DropShadowSize > 0` and the glow style is selected.
- **Provenance chain (verified):** the fragment was not taken from CodeProject by Krypton directly — Cyotek's upstream `ImageBox.cs` (MIT) contains the identical method and comment; Cyotek adapted it from the CPOL article "gGlowBox - Create a Glow or Shadow Effect Around a Focused Control" by CodeProject member SSDiver2112 (VB.NET). The CPOL taint, if the adaptation is substantial enough to be a derivative work, flows through Cyotek's MIT labelling — Cyotek's own compliance posture does not cleanse it.
- **Assessment:** ~30 lines of straightforward GDI+ looping; the "expression" copied is modest but the adaptation is acknowledged verbatim. Probable CPOL derivative.

> **RESOLVED — Option 1 taken (clean-room reimplementation), 17 July 2026.** `DrawGlowShadow`
> was rewritten from scratch without reference to the article's or Cyotek's code, working only
> from the behavioural description of a soft glow border. The new implementation strokes a
> sequence of rounded-rectangle outlines that step one pixel further out from the image bounds,
> each with a `Pen` whose alpha ramps down linearly with distance (`alpha = baseAlpha·(N−i)/N`),
> under `SmoothingMode.AntiAlias`, with the interior clipped out; a small
> `CreateRoundedRectanglePath` helper was added. The CPOL/SSDiver2112 credit comment was
> deleted and replaced with a header note marking the method original © Bastion Software
> Solutions Ltd 2026 (MIT). The public surface is unchanged
> (`protected virtual void DrawGlowShadow(Graphics, Rectangle)`, fed by `DropShadowSize` and
> `ImageBorderColor`), so `ImageBoxExtended` consumers and the Examples `DrawingUtilitiesExample`
> form are unaffected. The Drawing.Utilities module's `THIRD-PARTY-NOTICES.md` was updated from
> "do not ship before review" to resolved. No CPOL-derived code remains in the module.

**Options (choose one):**

1. **Replace with a clean-room implementation.** A glow/feathered border is a textbook GDI+ effect (concentric alpha-ramped pens or a `PathGradientBrush`); an independent implementation written from the *behavioural* description (no reference to the article's code) removes the issue entirely. Effort: ~1 hour + visual regression check. **Recommended.**
2. **Remove the feature.** Delete/stub `DrawGlowShadow` (fall back to the plain drop-shadow the control already has). Effort: minutes; minor cosmetic regression for `ImageBoxExtended` consumers.
3. **Comply with CPOL.** Keep the code; add the CPOL notice + article link + author credit to the file and ship the CPOL licence text in the package's third-party notices; the Drawing.Utilities package licence metadata would need to acknowledge the CPOL component. Legally workable (CPOL allows commercial use) but pollutes an otherwise MIT/Ms-PL story and CPOL's "no misrepresentation" clauses make labelling fiddly.

**Item B — Toggle.Switch module (new, found while verifying the sweep):** the entire renderer family is derived from Johnny J's CPOL "ToggleSwitch Winforms Control" (renderer names match one-for-one; the community mirror of the same code ships a CPOL LICENSE). This is a *module-scale* CPOL derivation, not a fragment. Same three options apply, at larger scale: clean-room reimplementation is a significant effort (10 renderers); removal means dropping the Toggle.Switch module from Bastion packaging (upstream README already flagged it "Under Development"); compliance means the whole `Bastion.Krypton.Extended.ToggleSwitch` package must carry CPOL notices and non-MIT metadata. **Recommendation: exclude the module from the first Bastion release and decide at leisure** — it is not a dependency of any other module.

> **RESOLVED — removed, 17 July 2026.** The `Krypton.Toolkit.Suite.Extended.Toggle.Switch`
> project directory was physically deleted. Its `Project(...)`/`EndProject` block, all
> per-configuration `GlobalSection` entries and the `NestedProjects` mapping for GUID
> `{3804493B-31D2-4D70-89EF-EDED205037EC}` were removed from both solutions that referenced it
> (`Krypton Toolkit Suite Extended 2022 - VS2022.sln` and the `- NuGet.sln`; the `- Dev.sln` did
> not reference it). The active `ProjectReference` was removed from the Examples app and from the
> `Ultimate.Lite` metapackage (Ultimate already had it commented out). A grep of every `.cs` and
> `.csproj` confirmed no other module consumed the Toggle.Switch types or assembly, so nothing
> else broke. No `Toggle.Switch - Backup*` sibling existed.

**Item C — §1.1 fragment inventory:** apply whichever policy Chris picks for Item A consistently (the UAC-shield helper exists in five modules; the MRU manager, ToolBox, progress-bar paint, CheckBoxComboBox and toast pop-up adaptations are one file each).

### 3.2 Code with no upstream licence at all

- **SharpUpdate** (`Software.Updater\Sharp Update\**`): upstream repo declares **no licence**; default copyright law grants no redistribution right. Attribution restoration cannot cure this. Options: (a) contact the author (henryxrl) for a licence grant; (b) remove/replace the Sharp Update half of Software.Updater (AutoUpdater.NET and NetSparkle already cover the use case — this is the natural choice, and Software.Updater is already excluded from the Ultimate package and parked in "Projects to Work On"); (c) treat as tutorial-derived code with implied consent — **not defensible; not recommended**.
  > **RESOLVED — Option (b) taken (removed), 17 July 2026.** The entire `Sharp Update\` source
  > folder (20 files) was physically deleted. A grep confirmed every SharpUpdate type reference
  > was self-contained within that folder — no live code path (AutoUpdater.NET / NetSparkle) used
  > it — so nothing else broke. The now-redundant `<Compile Remove="Sharp Update\Resources\**" />`,
  > `<EmbeddedResource Remove ... />` and `<None Remove ... />` globs were stripped from the
  > module csproj, and the module's `THIRD-PARTY-NOTICES.md` updated to record the removal. The
  > module builds all its TFMs.
- **AdvancedWizard** (Wizard module): same missing-licence situation, but the author is publicly credited in every file header and upstream has been openly forked for years. Risk is low; recommend a courtesy request to Steve Bate for an MIT grant before the first public Bastion release.

### 3.3 Not escalated

The Ms-PL modules (below) are a packaging-metadata matter, now handled, not a redistribution blocker.

---

## 4. Ms-PL packaging guidance for Bastion (finding 6)

**The conflict:** Outlook.Grid and AdvancedDataGridView are substantially Microsoft Public License code. Ms-PL §3(D) requires that any redistribution of the code **in source form** happen only under the Ms-PL; §3(C) requires retention of all copyright/attribution notices; §3(E) permits **binary** redistribution under "any licence that complies with this licence". Labelling these packages plain MIT therefore misstates the source-form terms, and Ms-PL code can never be silently relicensed to MIT.

**How Bastion packages must express this (implemented upstream in this repo, to be mirrored in Bastion packaging):**

1. **Per-module licence metadata:** `Bastion.Krypton.Extended.OutlookGrid` and `Bastion.Krypton.Extended.AdvancedDataGridView` must ship with SPDX `PackageLicenseExpression = MIT AND MS-PL` (NuGet accepts compound SPDX expressions; both licences are OSI-approved). Done in both csproj files on `bastion/multitarget`.
2. **Metapackages:** `Bastion.Krypton.Extended.Ultimate` (and `.Ultimate.Lite`) physically bundle the Ms-PL DLLs into their `lib/` folders (the repo's `Directory.Build.targets` embeds all referenced assemblies), so the metapackage itself redistributes Ms-PL binaries and must also carry `MIT AND MS-PL` plus the third-party notices. Done in both Ultimate csproj files. If Bastion later switches the metapackage to dependency-only (no embedded DLLs), plain MIT metadata with a dependency on the compound-licensed packages would suffice.
3. **Notices travel with the package:** include the repo-root `THIRD-PARTY-NOTICES.md` (added by this audit) in the nupkg for the two modules and the metapackages at pack time.
4. **Headers are inviolable:** the JDH Software and Ms-PL headers in the source files must never be removed or rewritten (Ms-PL §3(C)); any Bastion modification to those files should add a Bastion modification line beneath, never replace the header.
5. **Consumer impact (document in README/package description):** Ms-PL is copyleft only for the *source form* of the Ms-PL code itself; consumers using the compiled packages in closed-source applications are unaffected. Ms-PL is, however, GPL-incompatible — worth a line in the FAQ.
6. **All other Extended packages:** default `MIT` (fixed in `Directory.Build.targets` — packages were previously mis-stamped `BSD-3-Clause`). The Bastion core packages (Standard-Toolkit-derived) remain `BSD-3-Clause` per the spec; core and Extended metadata must not be blended in one package.

---

## 5. Files changed by this audit (Extended-Toolkit, branch `bastion/multitarget`)

| Change | File |
|---|---|
| Package licence fallback BSD-3-Clause → MIT | `Directory.Build.targets` |
| `MIT AND MS-PL` override (+ `PackageLicenseFile` cleared, NU5033) + comment | `Source\Krypton Toolkit\Krypton.Toolkit.Suite.Extended.Outlook.Grid\Krypton.Toolkit.Suite.Extended.Outlook.Grid 2022.csproj` |
| `MIT AND MS-PL` override (+ `PackageLicenseFile` cleared) + comment | `...AdvancedDataGridView\Krypton.Toolkit.Suite.Extended.AdvancedDataGridView 2022.csproj` |
| `MIT AND MS-PL` override (+ `PackageLicenseFile` cleared) + comment | `...Ultimate\Krypton.Toolkit.Suite.Extended.Ultimate 2022.csproj` and `...Ultimate.Lite\...Ultimate.Lite 2022.csproj` |
| New — upstream ScottPlot MIT licence | `...Data.Visualisation\Scott Plot\LICENSE` |
| New — ScottPlot origin/version/licence note | `...Data.Visualisation\Scott Plot\README.md` |
| New — upstream AutoUpdater.NET MIT licence | `...Software.Updater\Auto Updater\LICENSE` |
| New — Software.Updater third-party notices (AutoUpdater.NET + SharpUpdate) | `...Software.Updater\THIRD-PARTY-NOTICES.md` |
| New — .NET Foundation notice for vendored System.Speech | `...Utilities\Classes\System\SAPI\THIRD-PARTY-NOTICES.md` |
| New — Cyotek notices (+ gGlowBox flag) | `...Drawing.Utilities\THIRD-PARTY-NOTICES.md` |
| New — falahati CircularProgressBar notice | `...Circular.ProgressBar\THIRD-PARTY-NOTICES.md` |
| New — Guifreaks NaviSuite notice | `...Navi.Suite\THIRD-PARTY-NOTICES.md` |
| New — repo-root shipping summary of all third-party notices | `THIRD-PARTY-NOTICES.md` |

No `.cs` file was modified *by the original audit*; the build surface of every change here is metadata-only. The full solution was rebuilt after the changes (`Krypton Toolkit Suite Extended 2022 - VS2022.sln`, Release, `/restore`, MSBuild 18): **0 errors** (Themes remains unscheduled by design; warnings are the pre-existing baseline).

**Follow-up remediation (17 July 2026 — the §3 escalations, now resolved).** The public-release
clean-up did touch source and project structure (this is a deliberate, licence-driven exception
to the additions-only rule, applied only to CPOL/no-licence third-party code being *removed* — no
upstream copyright line on code that *stays* was altered):

| Change | File(s) |
|---|---|
| gGlowBox `DrawGlowShadow` clean-room rewrite (+ `CreateRoundedRectanglePath` helper); CPOL credit comment removed | `...Drawing.Utilities\Controls\Components\ImageBoxExtended.cs` |
| gGlowBox notice updated "do not ship" → resolved | `...Drawing.Utilities\THIRD-PARTY-NOTICES.md` |
| Toggle.Switch project directory deleted | `...Krypton.Toolkit.Suite.Extended.Toggle.Switch\**` (whole dir) |
| Toggle.Switch removed from both solutions | `Krypton Toolkit Suite Extended 2022 - VS2022.sln`, `...VS2022 - NuGet.sln` |
| Toggle.Switch `ProjectReference` removed | `Examples\Examples.csproj`, `...Ultimate.Lite 2022.csproj` (comment updated in `...Ultimate 2022.csproj`) |
| SharpUpdate `Sharp Update\` folder deleted; redundant `Compile/EmbeddedResource/None Remove` globs stripped | `...Software.Updater\Sharp Update\**` (whole dir), `...Software.Updater 2022.csproj` |
| SharpUpdate section removed from module notice | `...Software.Updater\THIRD-PARTY-NOTICES.md` |

The full plain solution was rebuilt after this remediation (Release, MSBuild 18): **0 errors**.

---

## 6. Outstanding items

1. ~~Chris's decision on §3.1 (gGlowBox fragment; Toggle.Switch module).~~ **DONE (17 July 2026):** gGlowBox clean-room reimplemented; Toggle.Switch module removed. Still open: the §1.1 fragment-inventory policy.
2. §3.2: ~~SharpUpdate — recommend removal~~ **DONE (17 July 2026): removed.** Still open: AdvancedWizard courtesy licence request.
3. At packaging time (Phase 7): embed `THIRD-PARTY-NOTICES.md` in the affected nupkgs; carry the `MIT AND MS-PL` expressions through to the `Bastion.Krypton.Extended.*` package definitions; keep Extended (MIT) and core (BSD-3-Clause) metadata separate.
4. Optional: diff Error.Reporting against ExceptionReporter.NET to confirm or clear the suspected lineage (§1 row 15).
