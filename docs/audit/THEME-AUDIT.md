# Theme Audit — Bastion Krypton Suite Phase 3 (spec §4.1)

**Date:** 15 July 2026
**Baseline:** `Standard-Toolkit` branch `bastion/multitarget` (from `origin/V105-LTS` tip `57824ec4`); `Extended-Toolkit` branch `bastion/multitarget` (from `origin/V105-LTS` tip `2725d8c4`).
**Source root (core):** `D:\Krypton-Ultimate\Standard-Toolkit\Source\Krypton Components\Krypton.Toolkit\` — abbreviated below as `KT\`.
**Source root (Extended):** `D:\Krypton-Ultimate\Extended-Toolkit\Source\Krypton Components\` — abbreviated below as `EXT\`.

All line numbers were verified against the working tree on the date above.

---

## 0. Headline census and reconciliation with BUILD-LOG

`KT\Palette Base\PaletteMode.cs` contains **50 active enum members**: `Global = -1`, 48 concrete
theme values, and `Custom`. In addition the file carries **20 commented-out members**:

- 8 grey variants, disabled with the marker *"ToDo: Re-enable when the gray themes are completed"*:
  `Office2007DarkGray`, `Office2007LightGray` (ll. 93–105), `Office2010DarkGray`, `Office2010LightGray`
  (ll. 152–164), `Office2013DarkGray`, `Office2013LightGray` (ll. 166–178), `Microsoft365DarkGray`,
  `Microsoft365LightGray` (ll. 281–293).
- 12 Visual Studio 2012/2013/2015/2017/2019/2022 Dark/Light members (ll. 315–373), fully commented out.

**Reconciliation:** `BUILD-LOG.md` ("Baseline palette set") records "57 PaletteMode values". That
figure counts the 48 concrete values + `Custom` + the 8 disabled grey variants (whose palette *classes*
exist) = 57, and excludes `Global`. The authoritative numbers for Phase 3 are:

| Measure | Count |
|---|---|
| Active `PaletteMode` members (incl. `Global`, `Custom`) | 50 |
| Concrete, selectable built-in themes | 48 |
| Disabled grey variants (classes exist, enum commented out) | 8 |
| Disabled VS 2012–2022 variants (abstract stub classes, enum commented out) | 12 |
| Palette classes under `KT\Palette Builtin\` (excl. `*_BaseScheme`) | 100 (56 concrete themes + 12 VS stubs + 32 base classes incl. `PaletteBase`) |
| `*_BaseScheme` colour-scheme classes | 49 (+ `EmptySchemeBase`) |
| Colour slots per scheme (`SchemeBaseColors`) | 239 (indices 0–238) |

A hard ordering contract exists and is documented in-source (`PaletteMode.cs` ll. 21–31 and
`PaletteModeStrings.cs` ll. 95–102, both referencing upstream issue #1328):
**the `PaletteMode` enum and the `PaletteModeStrings.SupportedThemes` dictionary MUST stay in the
same order** — by starting the enum at `Global = -1`, each member's ordinal equals its dictionary
position. Designer code exploits this numerically (`KryptonThemeComboBoxDesigner.cs` ll. 68, 91 use
`(int)PaletteMode.Microsoft365Blue` as a combo-box `SelectedIndex`). **Consequence for Bastion: new
values must be inserted into both structures at the same position, and appending new families before
`Custom` (keeping `Custom` last) is the only safe pattern that does not shift existing ordinals.**

---

## 1. Palette class inventory

Every concrete palette class, its shared base, the `PaletteMode` value(s) it backs, its variant
family, and whether it has a strongly-typed `*_BaseScheme` class. File paths are relative to
`KT\Palette Builtin\`.

### 1.1 Professional family (renderer: `RenderProfessional`, colour table: `KryptonProfessionalKCT`)

| File | Class | Base class | PaletteMode | Variant | Scheme class |
|---|---|---|---|---|---|
| `Professional\PaletteProfessionalSystem.cs` | `PaletteProfessionalSystem` | `PaletteBase` | `ProfessionalSystem` | system colours | `PaletteProfessionalSystem_BaseScheme` (assigned to `BaseColors` at l. 231) |
| `Professional\PaletteProfessionalOffice2003.cs` | `PaletteProfessionalOffice2003` | `PaletteOffice2003Base` (declared in the same file, l. 312, itself `: PaletteBase`) | `ProfessionalOffice2003` | Office 2003 (OS-gated, see §5) | none — colours generated from system settings + 3 hard-coded Luna header pairs (`_colorsB/_colorsG/_colorsS`, ll. 26–37) |

### 1.2 Office 2007 family (renderer: `RenderOffice2007`, colour table: `KryptonColorTable2007`)

| File | Class | Base class | PaletteMode | Variant | Scheme class |
|---|---|---|---|---|---|
| `Office 2007\Official Themes\PaletteOffice2007Blue.cs` | `PaletteOffice2007Blue` | `PaletteOffice2007Base` | `Office2007Blue` | Blue | ✔ |
| `Office 2007\Official Themes\PaletteOffice2007Silver.cs` | `PaletteOffice2007Silver` | `PaletteOffice2007Base` | `Office2007Silver` | Silver | ✔ |
| `Office 2007\Official Themes\PaletteOffice2007Black.cs` | `PaletteOffice2007Black` | `PaletteOffice2007Base` | `Office2007Black` | Black | ✔ |
| `Office 2007\Non Official Themes\PaletteOffice2007White.cs` | `PaletteOffice2007White` | `PaletteOffice2007Base` | `Office2007White` | White | ✔ |
| `Office 2007\Non Official Themes\PaletteOffice2007DarkGray.cs` | `PaletteOffice2007DarkGray` | `PaletteOffice2007Base` | *(disabled)* `Office2007DarkGray` | DarkGray | ✔ |
| `Office 2007\Non Official Themes\PaletteOffice2007LightGray.cs` | `PaletteOffice2007LightGray` | `PaletteOffice2007Base` | *(disabled)* `Office2007LightGray` | LightGray | ✘ — **stub**: parameterised ctor only, no scheme, no default ctor |
| `Office 2007\Extra Themes\PaletteOffice2007BlueDarkMode.cs` | `PaletteOffice2007BlueDarkMode` | `PaletteOffice2007BlueDarkModeBase` (same file, l. 242, `: PaletteBase`) | `Office2007BlueDarkMode` | Blue / DarkMode | ✔ |
| `Office 2007\Extra Themes\PaletteOffice2007BlueLightMode.cs` | `PaletteOffice2007BlueLightMode` | `PaletteOffice2007BlueLightModeBase` (same file, l. 244) | `Office2007BlueLightMode` | Blue / LightMode | ✔ |
| `Office 2007\Extra Themes\PaletteOffice2007SilverDarkMode.cs` | `PaletteOffice2007SilverDarkMode` | `PaletteOffice2007SilverDarkModeBase` (same file, l. 223) | `Office2007SilverDarkMode` | Silver / DarkMode | ✔ |
| `Office 2007\Extra Themes\PaletteOffice2007SilverLightMode.cs` | `PaletteOffice2007SilverLightMode` | `PaletteOffice2007SilverLightModeBase` (same file, l. 223) | `Office2007SilverLightMode` | Silver / LightMode | ✔ |
| `Office 2007\Extra Themes\PaletteOffice2007BlackDarkMode.cs` | `PaletteOffice2007BlackDarkMode` | `PaletteOffice2007BlackDarkModeBase` (same file, l. 398) | `Office2007BlackDarkMode` | Black / DarkMode | ✔ |

### 1.3 Office 2010 family (renderer: `RenderOffice2010`, colour table: `KryptonColorTable2010`)

Identical spread to 2007 (11 classes). Differences only:

| File | Class | Base class | PaletteMode | Scheme |
|---|---|---|---|---|
| `Office 2010\Official Themes\PaletteOffice2010Blue.cs` | `PaletteOffice2010Blue` | `PaletteOffice2010Base` | `Office2010Blue` | ✔ |
| `Office 2010\Official Themes\PaletteOffice2010Silver.cs` | `PaletteOffice2010Silver` | `PaletteOffice2010Base` | `Office2010Silver` | ✔ |
| `Office 2010\Official Themes\PaletteOffice2010Black.cs` | `PaletteOffice2010Black` | **`PaletteOffice2010BlackBase`** (`Bases\PaletteOffice2010BlackBase.cs`, `: PaletteBase`) | `Office2010Black` | ✔ |
| `Office 2010\Non Official Themes\PaletteOffice2010White.cs` | `PaletteOffice2010White` | `PaletteOffice2010Base` | `Office2010White` | ✔ |
| `Office 2010\Non Official Themes\PaletteOffice2010DarkGray.cs` | `PaletteOffice2010DarkGray` | `PaletteOffice2010Base` | *(disabled)* | ✔ |
| `Office 2010\Non Official Themes\PaletteOffice2010LightGray.cs` | `PaletteOffice2010LightGray` | `PaletteOffice2010Base` | *(disabled)* | ✘ stub |
| `Office 2010\Extra Themes\PaletteOffice2010{Blue,Silver}{Dark,Light}Mode.cs`, `...BlackDarkMode.cs` | 5 classes | each has its own in-file `...Base : PaletteBase` (ll. 229/234/229/229/583) | `Office2010BlueDarkMode`, `Office2010BlueLightMode`, `Office2010SilverDarkMode`, `Office2010SilverLightMode`, `Office2010BlackDarkMode` | ✔ ×5 |

### 1.4 Office 2013 family (renderer: `RenderOffice2013`, colour table: `KryptonColorTable2013`)

| File | Class | Base class | PaletteMode | Scheme |
|---|---|---|---|---|
| `Office 2013\Official Themes\PaletteOffice2013White.cs` | `PaletteOffice2013White` | `PaletteOffice2013WhiteBase` (`Bases\`, `: PaletteBase`) | `Office2013White` | ✔ |
| `Office 2013\Official Themes\PaletteOffice2013DarkGray.cs` | `PaletteOffice2013DarkGray` | `PaletteOffice2013Base` (`Bases\`, `: PaletteBase`) | *(disabled)* `Office2013DarkGray` | ✔ |
| `Office 2013\Official Themes\PaletteOffice2013LightGray.cs` | `PaletteOffice2013LightGray` | `PaletteOffice2013Base` | *(disabled)* `Office2013LightGray` | ✘ stub |

The only *active* Office 2013 theme is White. The whole family effectively has one usable palette.

### 1.5 Microsoft 365 family (renderer: `RenderMicrosoft365`, colour table: `KryptonColorTable365`)

| File | Class | Base class | PaletteMode | Variant | Scheme |
|---|---|---|---|---|---|
| `Microsoft 365\Non Official Themes\PaletteMicrosoft365Blue.cs` | `PaletteMicrosoft365Blue` | `PaletteMicrosoft365Base` (`Bases\`, `: PaletteBase`) | `Microsoft365Blue` — **the toolkit-wide default theme** | Blue | ✔ |
| `Microsoft 365\Official Themes\PaletteMicrosoft365White.cs` | `PaletteMicrosoft365White` | `PaletteMicrosoft365Base` | `Microsoft365White` | White | ✔ |
| `Microsoft 365\Official Themes\PaletteMicrosoft365Silver.cs` | `PaletteMicrosoft365Silver` | `PaletteMicrosoft365Base` | `Microsoft365Silver` | Silver | ✔ |
| `Microsoft 365\Official Themes\PaletteMicrosoft365Black.cs` | `PaletteMicrosoft365Black` | `PaletteMicrosoft365Base` | `Microsoft365Black` | Black | ✔ |
| `Microsoft 365\Official Themes\PaletteMicrosoft365DarkGray.cs` | `PaletteMicrosoft365DarkGray` | `PaletteMicrosoft365Base` | *(disabled)* `Microsoft365DarkGray` | DarkGray | ✔ |
| `Microsoft 365\Official Themes\PaletteMicrosoft365LightGray.cs` | `PaletteMicrosoft365LightGray` | `PaletteMicrosoft365Base` | *(disabled)* `Microsoft365LightGray` | LightGray | ✘ stub |
| `Microsoft 365\Extra Themes\PaletteMicrosoft365BlueDarkMode.cs` | `PaletteMicrosoft365BlueDarkMode` | `PaletteMicrosoft365BlueDarkModeBase` (`Extra Themes\Bases\`, `: PaletteBase`) | `Microsoft365BlueDarkMode` | Blue / DarkMode | ✔ |
| `Microsoft 365\Extra Themes\PaletteMicrosoft365BlueLightMode.cs` | `PaletteMicrosoft365BlueLightMode` | `PaletteMicrosoft365BlueLightModeBase` | `Microsoft365BlueLightMode` | Blue / LightMode | ✔ |
| `Microsoft 365\Extra Themes\PaletteMicrosoft365SilverDarkMode.cs` | `PaletteMicrosoft365SilverDarkMode` | `PaletteMicrosoft365SilverDarkModeBase` | `Microsoft365SilverDarkMode` | Silver / DarkMode | ✔ |
| `Microsoft 365\Extra Themes\PaletteMicrosoft365SilverLightMode.cs` | `PaletteMicrosoft365SilverLightMode` | `PaletteMicrosoft365SilverLightModeBase` | `Microsoft365SilverLightMode` | Silver / LightMode | ✔ |
| `Microsoft 365\Extra Themes\PaletteMicrosoft365BlackDarkMode.cs` | `PaletteMicrosoft365BlackDarkMode` | `PaletteMicrosoft365BlackDarkModeBase` | `Microsoft365BlackDarkMode` | Black / DarkMode | ✔ |
| `Microsoft 365\Extra Themes\PaletteMicrosoft365BlackDarkModeAlternate.cs` | `PaletteMicrosoft365BlackDarkModeAlternate` | `PaletteMicrosoft365BlackDarkModeAlternateBase` | `Microsoft365BlackDarkModeAlternate` | Black / DarkMode (alt) | ✔ |

### 1.6 Sparkle family (renderer: `RenderSparkle`, colour table: `KryptonColorTableSparkle`)

| File | Class | Base class | PaletteMode | Scheme |
|---|---|---|---|---|
| `Sparkle\Official Themes\PaletteSparkle{Blue,Orange,Purple}.cs` | 3 classes | `PaletteSparkleBase` (`Base\`, `: PaletteBase`) | `SparkleBlue`, `SparkleOrange`, `SparklePurple` | ✔ ×3 |
| `Sparkle\Extra Themes\PaletteSparkleBlueDarkMode.cs` | `PaletteSparkleBlueDarkMode` | **`PaletteSparkleBlueDarkModeBase`** (`Base\`, `: PaletteBase`) | `SparkleBlueDarkMode` | ✔ |
| `Sparkle\Extra Themes\PaletteSparkleBlueLighMode.cs` *(note upstream filename typo "LighMode")* | `PaletteSparkleBlueLightMode` | `PaletteSparkleBase` | `SparkleBlueLightMode` | ✔ |
| `Sparkle\Extra Themes\PaletteSparkle{Orange,Purple}{Dark,Light}Mode.cs` | 4 classes | `PaletteSparkleBase` | `SparkleOrangeDarkMode`, `SparkleOrangeLightMode`, `SparklePurpleDarkMode`, `SparklePurpleLightMode` | ✔ ×4 |

### 1.7 Visual Studio family

| File | Class | Base class | PaletteMode | Renderer |
|---|---|---|---|---|
| `Visual Studio\Official Themes\2010\Variations\2007\PaletteVisualStudio2010Office2007Variation.cs` | `PaletteVisualStudio2010Office2007Variation` | `PaletteVisualStudio2010With2007Base` (`Base\Visual Studio 2010\Renderers\2007\`, `: PaletteBase`) | `VisualStudio2010Render2007` | `RenderVisualStudio2010With2007` / `KryptonVisualStudio2010With2007ColorTable` |
| `...\Variations\2010\PaletteVisualStudio2010Office2010Variation.cs` | `PaletteVisualStudio2010Office2010Variation` | `PaletteVisualStudio2010With2010Base` | `VisualStudio2010Render2010` | `RenderVisualStudio2010With2010` |
| `...\Variations\2013\PaletteVisualStudio2010Office2013Variation.cs` | `PaletteVisualStudio2010Office2013Variation` | `PaletteVisualStudio2010With2013Base` | `VisualStudio2010Render2013` | `RenderVisualStudio2010With2013` |
| `...\Variations\365\PaletteVisualStudio2010Microsoft365Variation.cs` | `PaletteVisualStudio2010Microsoft365Variation` | `PaletteVisualStudio2010With365Base` | `VisualStudio2010Render365` | `RenderVisualStudio2010WithMicrosoft365` |
| `Visual Studio\Official Themes\{2012,2013,2015,2017,2019,2022}\PaletteVisualStudio20XX{Dark,Light}Mode.cs` | 12 classes | `PaletteVisualStudioBase` (`Base\`, `: PaletteBase`; pairs with `RenderVisualStudio`/`KryptonColorTableVisualStudio`) | **none — all 12 enum values commented out** | n/a |

The 12 VS 2012–2022 classes are **abstract shells**: each contains only an `[Obsolete]` protected
`Color[]` constructor and a `ThemeName` assignment (e.g. `PaletteVisualStudio2012DarkMode.cs` ll. 12–20).
No schemes, no default constructors, not instantiable — placeholders for future work.

### 1.8 Material family (renderer: `RenderMaterial`)

| File | Class | Base class | PaletteMode | Scheme |
|---|---|---|---|---|
| `Material\Bases\PaletteMaterialBase.cs` | `PaletteMaterialBase` (abstract) | **`PaletteMicrosoft365Base`** — Material piggybacks on the M365 palette/table plumbing, overriding colour getters with Material token properties (`TokenSurface`/`TokenOnSurface`/`TokenOutline`/`TokenPrimary`, ll. 22–25) | — | — |
| `Material\PaletteMaterialLight.cs` | `PaletteMaterialLight` | `PaletteMaterialBase` | `MaterialLight` | `PaletteMaterialLight_BaseScheme` |
| `Material\PaletteMaterialDark.cs` | `PaletteMaterialDark` | `PaletteMaterialBase` | `MaterialDark` | `PaletteMaterialDark_BaseScheme` |
| `Material\PaletteMaterialLightRipple.cs` | `PaletteMaterialLightRipple` | `PaletteMaterialLight` — sets `RippleEffect = true` only | `MaterialLightRipple` | (inherits) |
| `Material\PaletteMaterialDarkRipple.cs` | `PaletteMaterialDarkRipple` | `PaletteMaterialDark` — sets `RippleEffect = true` only | `MaterialDarkRipple` | (inherits) |

---

## 2. Class hierarchy and the scheme mechanism (implementation guide)

### 2.1 The shared-base architecture

Everything derives from **`PaletteBase : Component`** (`KT\Palette Builtin\Base\PaletteBase.cs`,
~102 KB — declares every abstract `Get*` accessor the renderers consume, plus
`protected abstract Color[] SchemeColors { get; }` and `CopySchemeColors(Color[])` for runtime
recolouring). Between `PaletteBase` and the concrete themes sit **family base classes** that hold
all the per-family drawing logic; concrete themes are thin: they supply a colour scheme, image
assets, and a handful of overrides. The family bases as of this baseline:

| Family base | Derives from | Used by |
|---|---|---|
| `PaletteMicrosoft365Base` | `PaletteBase` | 6 M365 themes + all 4 Material themes (via `PaletteMaterialBase`) |
| 6 × `PaletteMicrosoft365<Variant>Base` | `PaletteBase` | one M365 dark/light variant each (full copies, not subclasses of `PaletteMicrosoft365Base`) |
| `PaletteOffice2007Base` | `PaletteBase` | 6 Office 2007 themes |
| 5 × in-file `PaletteOffice2007<Variant>Base` | `PaletteBase` | one 2007 dark/light variant each |
| `PaletteOffice2010Base`, `PaletteOffice2010BlackBase` | `PaletteBase` | 5 + 1 Office 2010 themes |
| 5 × in-file `PaletteOffice2010<Variant>Base` | `PaletteBase` | one 2010 dark/light variant each |
| `PaletteOffice2013Base`, `PaletteOffice2013WhiteBase` | `PaletteBase` | 2 + 1 Office 2013 themes |
| `PaletteOffice2003Base` (in `PaletteProfessionalOffice2003.cs`) | `PaletteBase` | Professional Office 2003 |
| `PaletteSparkleBase`, `PaletteSparkleBlueDarkModeBase` | `PaletteBase` | 8 + 1 Sparkle themes |
| `PaletteVisualStudioBase` | `PaletteBase` | 12 VS 2012–2022 stubs only |
| 4 × `PaletteVisualStudio2010With<Renderer>Base` | `PaletteBase` | one VS2010 variation each |
| `PaletteMaterialBase` | `PaletteMicrosoft365Base` | 4 Material themes |

**Architectural wart to be aware of:** the dark/light "Extra Themes" of 2007/2010/M365 do *not*
subclass the family base — each got a cloned per-variant base class (≈3,000–4,500 duplicated lines
each). Any base-level fix must be replicated across the clones. New Bastion families should follow
the *official* pattern (one family base, thin theme subclasses), not the clone pattern.

### 2.2 What a "scheme" is

The palette's colours live in a single flat colour array indexed by the
**`SchemeBaseColors`** enum (`KT\Palette Builtin\Enumerations\PaletteEnumerations.cs` l. 21):
**239 named slots, indices 0–238**. Slots 0–232 are general control/ribbon colours; slots 233–238
are the six TrackBar colours (`TrackBarTickMarks`…`TrackBarBorderPosition`), folded in from the
former separate `_trackBarColors` array. Ribbon colours are ordinary slots inside the same array
(e.g. `RibbonTabTextNormal = 70` … `RibbonGroupsArea4 = 88`, plus QAT/app-button slots) — **ribbon
and control colours share one scheme**; they are not separate tables. The same file also defines
auxiliary slot enums (`SchemeExtraColors`, `SchemeToolTipColors`, internal
`SchemeContextMenuColors`/`SchemeMenuStripColors`, `SchemeTrackingColors`, and per-element slot
enums such as `AppButtonNormalColor`, `ButtonBackColor`, `RibbonGroupCollapsedBack`…).

Since the V100 "strongly-typed colour scheme" migration (fully documented in
`KT\Palette Builtin\Base\README.md` — read it before writing any palette), each theme's colours are
declared as a **scheme class**:

- `KryptonColorSchemeBase` (`Base\KryptonColorSchemeBase.cs`) — abstract, exactly one writable
  `Color` auto-property per `SchemeBaseColors` value (239 properties).
- Per theme: `Schemes\Palette<Name>_BaseScheme.cs` — overrides every property with the theme's
  colours (49 such classes exist). `EmptySchemeBase` (`Base\Schemes\EmptySchemeBase.cs`) provides an
  all-`EMPTY_COLOR` starting point.
- Extension methods `ToArray()` (239-element `Color[]`) and `ToTrackBarArray()` (final 6 slots)
  convert a scheme to the legacy array layouts the render pipeline still consumes.

### 2.3 Constructor pattern (the recipe for a new palette)

Concrete theme (verified against `PaletteMicrosoft365Blue.cs` ll. 172–178):

```csharp
public PaletteMicrosoft365Blue() : base(
    new PaletteMicrosoft365Blue_BaseScheme(),   // KryptonColorSchemeBase
    _checkBoxList,                              // ImageList, 13x13 check-box strip
    _galleryButtonList,                         // ImageList, 13x7 gallery strip
    _radioButtonArray)                          // Image?[8] radio-button states
{ }
```

Family base (verified against `PaletteMicrosoft365Base.cs` ll. 219–332):

- stores the scheme in `protected readonly KryptonColorSchemeBase? BaseColors` and flattens it into
  `private readonly Color[] _ribbonColors = scheme.ToArray()` (l. 257) — the array name is historic;
  it holds *all* 239 colours;
- exposes `protected override Color[] SchemeColors => _ribbonColors` (l. 222) for the
  `PaletteBase.CopySchemeColors` runtime-update API;
- keeps a legacy `[Obsolete]` `Color[]`-taking constructor (l. 287) — scheduled for removal in V110;
  new palettes must use the scheme overload only (README "Contributing guidelines": *never pass raw
  `Color[]`*);
- lazily builds the ToolStrip/menu colour table:
  `public override KryptonColorTable ColorTable => Table ??= new KryptonColorTable365(BaseColors?.ToArray() ?? _ribbonColors, InheritBool.True, this);`
- provides thread-safe runtime mutators `SetSchemeColor`, `GetSchemeColor`, `UpdateSchemeColors`,
  `ApplyScheme` (each nulls `Table` to force colour-table regeneration);
- `Office2007/2010/2013` bases take an extra leading `string themeName` parameter and a trailing
  `Color[] trackBarColors` parameter (e.g. `PaletteOffice2007Base` ll. 216, 259) — themes pass
  `new <Scheme>().ToTrackBarArray()` there.

The concrete theme additionally supplies bitmap assets (caption-button glyphs, check-box/radio
strips, gallery strips, drop-down/context-menu arrows, integrated-toolbar icons) via static fields,
and overrides image getters (`GetButtonSpecImage`, `GetContextMenuSubMenuImage`) plus — in the M365
family — the newer ribbon hooks `GetRibbonTabRowBackgroundSolidColor`,
`GetRibbonTabRowGradientColor1`, `GetRibbonTabRowBackgroundGradientRafting*`,
`GetRibbonFileAppTab{Bottom,Top,Text}Color` (`PaletteMicrosoft365Blue.cs` ll. 329–361).

### 2.4 Renderer pairing

Each family base hard-codes its renderer via
`public override IRenderer GetRenderer() => KryptonManager.Render<Family>;`:

| Family base | `GetRenderer()` (file : line) | Renderer (all in `KT\Rendering\`) | Colour table (`KT\Palette Controls\`) |
|---|---|---|---|
| `PaletteProfessionalSystem` / `PaletteOffice2003Base` | `PaletteProfessionalSystem.cs:250` / `PaletteProfessionalOffice2003.cs:544` | `RenderProfessional` | `KryptonProfessionalKCT` (generated from system settings) |
| `PaletteOffice2007Base` | `:283` | `RenderOffice2007` | `KryptonColorTable2007` |
| `PaletteOffice2010Base` / `BlackBase` | `:332` / `:335` | `RenderOffice2010` | `KryptonColorTable2010` |
| `PaletteOffice2013Base` / `WhiteBase` | `:348` / `:316` | `RenderOffice2013` | `KryptonColorTable2013` |
| `PaletteMicrosoft365Base` + 6 variant bases | `:332` (+ ll. 285–288 in variant bases) | `RenderMicrosoft365` | `KryptonColorTable365` (a `KryptonColorTableMicrosoft365` also exists) |
| `PaletteSparkleBase` / `BlueDarkModeBase` | `:347` / `:261` | `RenderSparkle` | `KryptonColorTableSparkle` |
| `PaletteVisualStudio2010With<X>Base` | `:320/:321/:320/:320` | `RenderVisualStudio2010With<X>` | `KryptonVisualStudio2010With<X>ColorTable` |
| `PaletteVisualStudioBase` | `:322` | `RenderVisualStudio` | `KryptonColorTableVisualStudio` |
| `PaletteMaterialBase` | `:80` | `RenderMaterial` | inherits `KryptonColorTable365` via M365 base |

Renderers are exposed as lazily-created singletons on `KryptonManager` (fields
`KryptonManager.cs` ll. 124–136, properties ll. 1028–1092) and are additionally reachable through
the `RendererMode` enum (`KT\Rendering\RenderDefinitions.cs` ll. 847–914:
`Inherit`, `Sparkle`, `Office2007/2010/2013`, `Microsoft365`, `Professional`, `Standard`,
4 × `VisualStudio2010With*Renderer`, `VisualStudio`, `Material`, `Custom`) resolved by
`KryptonManager.GetRendererForMode(RendererMode)` (ll. 986–1026). The ribbon additionally asks the
palette for its shape via `GetRibbonShape()` (e.g. `PaletteMicrosoft365Base.cs:3435` returns
`PaletteRibbonShape.Microsoft365`).

**Summary for new palettes:** an Office 2016/2019/2021/2024 palette = one family base
(`: PaletteBase`, ~3,500 lines, most economically cloned from `PaletteMicrosoft365Base` or a new
shared base), one `GetRenderer()` decision (reuse `RenderMicrosoft365`, or add a `Render<New>` +
`KryptonColorTable<New>` + `RendererMode` member for genuinely different chrome), plus per theme:
a `KryptonColorSchemeBase` subclass (239 colours), an asset set, and a ~350-line theme class.

---

## 3. Wiring points for a new `PaletteMode` value (exhaustive)

Verified by following `PaletteMode.Microsoft365Blue` end-to-end. Grouped by obligation.
"§" numbers below are referenced from the tables.

### 3.1 Mandatory — the theme does not exist/work without these

| # | File (path relative to `KT\`) | Member / lines | What to add |
|---|---|---|---|
| W1 | `Palette Base\PaletteMode.cs` | enum body (ll. 36–398) | New enum member. **Position-sensitive** — must match the `SupportedThemes` dictionary index (contract at ll. 21–31); insert immediately before `Custom` unless slotting into an existing family block *and* updating every later ordinal consumer. |
| W2 | `Translations\Converters\PaletteModeStrings.cs` | `DEFAULT_PALETTE_*` consts (ll. 19–87) | New display-name constant, e.g. `@"Office 2019 - Dark Grey"`. These strings are also the palette-import XML match keys and the designer display text. |
| W3 | `Translations\Converters\PaletteModeStrings.cs` | `SupportedThemes` BiDictionary (ll. 92–174) | New `{ name, PaletteMode }` entry **at the same ordinal position as W1**. |
| W4 | `Translations\Converters\PaletteModeStrings.cs` | `IsDefault` (ll. 198–251), `Reset()` (ll. 253–360), localisable string property (ll. 362–806) | One clause + one assignment + one `public string <Name> { get; set; }` property with `[DefaultValue]`. |
| W5 | `Converters\PaletteClassTypeConverter.cs` | `_pairs` BiDictionary (ll. 20–76) | `{ PaletteMode.X, typeof(PaletteX) }` — powers `KryptonManager.GetModeForPalette` (KryptonManager.cs ll. 700–721); without it a set `GlobalCustomPalette` round-trips as `Global`. |
| W6 | `Controls Toolkit\KryptonManager.cs` | family field region (ll. 40–122; M365 block ll. 95–108) | `private static PaletteX? _paletteX;` |
| W7 | `Controls Toolkit\KryptonManager.cs` | lazy singleton properties (ll. 724–978) | `public static PaletteX PaletteX => _paletteX ??= new PaletteX();` |
| W8 | `Controls Toolkit\KryptonManager.cs` | `GetPaletteForMode(PaletteMode)` switch (ll. 571–693) | `case PaletteMode.X: return PaletteX;` — **the palette factory**. |
| W9 | `Controls Toolkit\KryptonManager.cs` | `UpdatePaletteImages(PaletteMode)` switch (ll. 1190–1269) | Case mapping the mode to a `GlobalStaticValues.<Era>ToolBarImages` set (default is a `DebugTools.NotImplemented` assert). |
| W10 | `Controls Toolkit\KryptonManager.cs` | `OnUserPreferenceChanged` (ll. 1108–1150) | Add `_paletteX?.UserPreferenceChanged();` *if* the palette derives from a family whose colours react to system-preference changes (upstream currently only calls it for a subset — 2007/2010/2013 official, Sparkle official, M365 official, VS2010, Professional). |
| W11 | `Controls Toolkit\KryptonCommand.cs` | 15 switches over `PaletteMode` (case blocks at ll. 531, 603, 675, 747, 819, 889, 961, 1033, 1105, 1177, 1249, 1321, 1393, 1465, 1537) | A case per switch. **Mandatory: the `default` arm throws `ArgumentOutOfRangeException`** (e.g. l. 540) whenever a `KryptonCommand` with an integrated-toolbar `CommandType` refreshes its image. |
| W12 | `Controls Toolkit\KryptonHelpCommand.cs` | 6 switches (ll. 219, 304, 398, 504, 610, 702) | As W11 (help-icon per era). |
| W13 | 14 files `Controls Toolkit\KryptonIntegratedToolbar<Action>Command.cs` (`New`, `Open`, `Save`, `SaveAs`, `SaveAll`, `Cut`, `Copy`, `Paste`, `Undo`, `Redo`, `PageSetup`, `PrintPreview`, `Print`, `QuickPrint`) | 6 switches per file, 84 total (e.g. `...SaveCommand.cs` ll. 217, 300, 375, 450, 525, 592) | As W11 — one case per switch, toolbar icon per era. |
| W14 | `Utilities\GraphicsExtensions.cs` | `IsVistaCompatibleTheme` (l. 590), `IsWindows7CompatibleTheme` (l. 621), `IsWindows10CompatibleTheme` (ll. 646–667) | Add the mode to exactly one of the three OS-icon-style buckets (default = XP-style icons). |
| W15 | *(new files)* `Palette Builtin\<Family>\...` | — | The palette class itself, its `Schemes\Palette<X>_BaseScheme.cs`, and (new family only) the family base — see §2.3. |

⚠ **Defect found during this audit (feeds `BREAKAGE-LOG.md` and §4):** the W11–W13 switches were
*not* updated when `Microsoft365BlackDarkModeAlternate`, the four `Material*` modes and the four
`VisualStudio2010Render*` modes were added — `grep` confirms zero occurrences of those names in
`KryptonCommand.cs`/`KryptonHelpCommand.cs`/all 14 toolbar command files. Because the `default` arm
throws, selecting any of those nine themes while a `KryptonCommand`/integrated-toolbar command is
active throws `ArgumentOutOfRangeException` at runtime. Fix in Phase 3 alongside the new palettes
(and consider collapsing the 105 duplicated switches into one shared family-classifier helper —
recorded as a Bastion refactor candidate, since spec forbids inventing new architecture only for
*palette* structure).

### 3.2 Automatic — no edit needed, but verify in the theme sweep

These all resolve through `PaletteModeStrings.SupportedThemes`, so W1–W4 light them up:

| File | Member / line | Mechanism |
|---|---|---|
| `Converters\PaletteModeConverter.cs` | ll. 18–27 | Designer/dropdown text ↔ enum via the BiDictionary. |
| `Rendering\ThemeManager.cs` | `SupportedInternalThemeNames` (l. 28), `GetThemeManagerMode` (ll. 182–187), `ApplyTheme`/`ApplyGlobalTheme` (ll. 47–117) | Public theming façade. |
| `General\CommonHelperThemeSelectors.cs` | `GetThemesArray()` (ll. 25–28), index/name helpers (ll. 104–108) | Feeds every theme-selector control. |
| `Controls Toolkit\KryptonThemeComboBox.cs` (l. 42), `KryptonThemeListBox.cs` (l. 42), `KryptonToolStripThemeComboBox.cs` (same helper via its hosted combo) | `Items.AddRange(CommonHelperThemeSelectors.GetThemesArray())` | Runtime pickers. |
| `Controls Visuals\VisualThemeBrowserForm.cs` (l. 64), `...\RTL Aware\VisualThemeBrowserFormRtlAware.cs` (l. 67) | `foreach (var themeName in ThemeManager.SupportedInternalThemeNames)` | `KryptonThemeBrowser` dialog. |
| `Krypton.Ribbon\Group Contents\KryptonRibbonGroupThemeComboBox.cs` (l. 51) | `GetThemesArray()` | Core ribbon theme picker (distinct from the Extended one, which is hard-coded — see §3.5). |
| `Controls Toolkit\KryptonCustomPaletteBase.cs` | l. 60, ll. 2747–2779 | Base-palette resolution goes through `KryptonManager.GetPaletteForMode`. |

### 3.3 Defaults and designer support (touch only when the *default* theme or ordinals change)

| File | Member / lines | Note |
|---|---|---|
| `General\GlobalStaticValues.cs` | `GLOBAL_DEFAULT_THEME_INDEX` (l. 63), `GLOBAL_DEFAULT_PALETTE_MODE` (l. 66) | Both pinned to `PaletteMode.Microsoft365Blue`. If Bastion promotes a new default (e.g. current M365), change here — everything else follows `ThemeManager.DefaultGlobalPalette`. |
| `Designers\Action Lists\KryptonManagerActionList.cs` | `GlobalPaletteMode` property (ll. 42–56), reset-to-default handler (ll. 73–75), action item (l. 104) | Smart-tag; hard-codes `PaletteMode.Microsoft365Blue` as reset target. |
| `Designers\Designers\KryptonManagerDesigner.cs` | reset verb (ll. 72, 91, 102–116) | Hard-codes `Microsoft365Blue`. |
| `Designers\Designers\KryptonThemeComboBoxDesigner.cs` | ll. 68, 91 | Uses `(int)PaletteMode.Microsoft365Blue` **as a combo-box index** — this is why the enum/dictionary ordering contract (W1/W3) is load-bearing. |
| `Controls Toolkit\KryptonManager.cs` | `GlobalPaletteMode` `[DefaultValue(PaletteMode.Microsoft365Blue)]` (l. 263) | Designer serialisation default. |

### 3.4 Conditional — only when a new *family/renderer* is introduced

| File | Member / lines | What |
|---|---|---|
| `Rendering\RenderDefinitions.cs` | `RendererMode` enum (ll. 847–914) | New member if the family gets its own renderer. |
| `Controls Toolkit\KryptonManager.cs` | renderer field (ll. 124–136), `GetRendererForMode` switch (ll. 986–1026), renderer property (ll. 1028–1092) | `Render<New>` singleton + case. |
| `Rendering\Render<New>.cs`, `Palette Controls\KryptonColorTable<New>.cs` | new files | Renderer + ToolStrip colour table. |
| `Palette Base\PaletteDefinitions.cs` / ribbon | `PaletteRibbonShape` | Only if the ribbon chrome shape differs from Office2007/2010/2013/Microsoft365/Sparkle shapes already defined. |
| `Krypton.Ribbon\View Draw\ViewDrawRibbonTab.cs` | ll. 431–432 | Fragile string test `CurrentGlobalPaletteMode.ToString().StartsWith(PaletteMode.Office2010Black.ToString())` — check any new "…Black…" mode name does not falsely match, and extend if a new dark family needs the light-text behaviour. |

Test-only (not shipped, keep green): `KT\..\TestForm\` designer files reference palette names
(`Main.Designer.cs`, `ThemeControlExamples.Designer.cs`, `PaletteViewer\PaletteViewerForm.Designer.cs`, etc.).

### 3.5 Extended Toolkit wiring (verified in `D:\Krypton-Ultimate\Extended-Toolkit`)

The Extended tree does **not** delegate theme enumeration to the core `ThemeManager` — it carries
**five independent hard-coded theme lists/switches** (mutually inconsistent: some hyphenated names,
some not, several missing whole M365/dark-mode blocks). Every new `PaletteMode` must be added to
each of these (Bastion refactor recommendation: replace all five with calls into core
`PaletteModeStrings`/`ThemeManager`, eliminating this class of drift permanently):

| # | File (relative to `EXT\`) | Members |
|---|---|---|
| E1 | `Krypton.Toolkit.Suite.Extended.Theme.Switcher\Classes\ThemeManager.cs` | `PropagateThemeList()` (ll. 40–113) and `PropagateThemeList(KryptonComboBox)` (ll. 115–263) — two hard-coded 34-name lists; `SetPaletteTheme(PaletteMode, KryptonComboBox)` (ll. 265–327) — switch mapping mode → **magic `SelectedIndex` integers** that must be renumbered; `ApplyTheme(string, KryptonManager)` (ll. 329–445) — if/else name → mode chain. Consumed by `UX\ThemeSelector.cs` (ll. 204, 278–280) and `UX\ThemeSelectorOld.cs` (l. 220). |
| E2 | `Krypton.Toolkit.Suite.Extended.Core\Classes\Theming\ThemeManager.cs` | `InitialiseThemes()` (ll. 57–124) — hard-coded 14-name list (non-hyphen style, omits M365 variants); `SwitchTheme(PaletteMode, KryptonManager)` (ll. 145–196). |
| E3 | `Krypton.Toolkit.Suite.Extended.Core\Classes\Palette\PaletteCompositionEngine.cs` | `PropagateThemes(KryptonComboBox, bool)` (ll. 763–804) and `PropagateThemes(KryptonRibbonGroupComboBox, bool)` (ll. 806–847) — two more hard-coded lists. |
| E4 | `Krypton.Toolkit.Suite.Extended.Core\Classes\Options\Theming\ThemingLogic.cs` | `InitialisePaletteCollection(ArrayList)` (ll. 53–86) and `(AutoCompleteStringCollection)` (ll. 88–121); `ChangeTheme(PaletteMode)` (ll. 157–215, contains a pre-existing duplicate-`break` defect at ll. 189–190); `GetPaletteModeAsString(PaletteMode)` (ll. 236–287). |
| E5 | `Krypton.Toolkit.Suite.Extended.Ribbon\Classes\KryptonRibbonThemeManager.cs` | `_supportedThemes` BiDictionary (ll. 38–86, ~40 hard-coded entries; in-source `TODO` admits it should use the core list); lookups at ll. 139, 171, 284. Companion `Group Contents\KryptonRibbonGroupThemeComboBox.cs` hard-codes default index `33` (ll. 52–62, 90). |
| E6 *(dormant)* | `Krypton.Toolkit.Suite.Extended.Shared\Converters\PaletteModeConverter.cs` | hard-coded `_pairs` (ll. 16–98) — entire class commented out ("TODO: Rewrite class"); only relevant if revived. |

No change needed in: `Tool.Strip.Items\Controls\General\KryptonThemeComboBox.cs` (delegates to core
`ThemeManager.ApplyTheme`, l. 72), the `Settings` module theme managers (store a single
`PaletteMode` value), and the `Palette.Selectors` / `Themes` module stubs (no enumeration code at all).

### 3.6 Wiring-point totals

- **Core, mandatory:** 15 wiring groups (W1–W15) touching **22 files** — 6 infrastructure files
  (`PaletteMode.cs`, `PaletteModeStrings.cs`, `PaletteClassTypeConverter.cs`, `KryptonManager.cs`,
  `GraphicsExtensions.cs`, + new palette/scheme files) and 16 command files carrying **105
  throwing switch statements** (15 + 6 + 84).
- **Core, conditional:** 5 designer/default files; 4+ renderer files per new family.
- **Extended:** 5 active files (E1–E5) containing 8 hard-coded lists and 5 mode switches, plus one
  dormant converter (E6).

---

## 4. Known fidelity issues (upstream issue tracker)

Sourced from the GitHub Search API against `Krypton-Suite/Standard-Toolkit` (open **and** closed;
queries covered palette/theme/colour(color)/renderer plus every family name), verified 15 July 2026.
Closed issues remain relevant to Phase 3: they show *where* each palette historically diverged from
the real product and therefore where our fidelity comparisons (spec §4.3.4) must look hardest.

### 4.1 Per-family fidelity and rendering bug history

| # | Title (exact) | Affected palette | State | Defect |
|---|---|---|---|---|
| [297](https://github.com/Krypton-Suite/Standard-Toolkit/issues/297) | [Bug]: Office 2k7 colour usages are wrong | Office 2007 (+ Sparkle) | closed | Gradient colour order ("bottom glow") reversed vs real Office 2007; fixed via PRs #1788/#1790. |
| [1661](https://github.com/Krypton-Suite/Standard-Toolkit/issues/1661) | [Bug]: Office 2k7 Dark Blue theme: Form Text is hard to read when app loses focus | Office 2007 Blue (Dark Mode) | closed | Inactive title-bar text contrast failure. |
| [372](https://github.com/Krypton-Suite/Standard-Toolkit/issues/372) | [Bug]: Office 2007 Themes last ribbon tab is not fully selectable | Office 2007 | closed | Ribbon hit-test/render defect specific to 2007 palettes. |
| [2331](https://github.com/Krypton-Suite/Standard-Toolkit/issues/2331) | [Bug]: `KryptonRibbon` lost its borders and 3D effect, becoming completely flat | Office 2010 (esp.) | closed | v90 regression in `GetRibbonBackColorStyle`; fixed via PRs #2568/#2337. |
| [1516](https://github.com/Krypton-Suite/Standard-Toolkit/issues/1516) | [Bug]: Theme Office 2010 Black Dark Mode causes a crash. | Office 2010 Black (Dark Mode) | closed | Selecting the theme crashed the app. |
| [1070](https://github.com/Krypton-Suite/Standard-Toolkit/issues/1070) | [Bug]: "PaletteOffice2010BlackDarkMode" Throws excpetion for tooltip color usage | Office 2010 Black (Dark Mode) | closed | Tooltip colour lookup threw (missing colour-table entry). |
| [809](https://github.com/Krypton-Suite/Standard-Toolkit/issues/809) | [Bug]: Office 2010 - Silver (Light Mode) - KryptonDataGridView throw exception on hover | Office 2010 Silver (Light Mode) | closed | Hover-state colour lookup threw in the grid. |
| [738](https://github.com/Krypton-Suite/Standard-Toolkit/issues/738) | [Bug]: "Office 2010 - Blue (Dark Mode)": Form title text cannot be read | Office 2010 Blue (Dark Mode) | closed | Title text/background contrast failure. |
| [678](https://github.com/Krypton-Suite/Standard-Toolkit/issues/678) | [Bug]: Dropdown list background & text colour are the same (Office 2010 - Black (Dark Mode)) | Office 2010 Black (Dark Mode) | closed | Incomplete dark mode — dropdown text invisible. |
| [433](https://github.com/Krypton-Suite/Standard-Toolkit/issues/433) | [Bug]: "Office 2010 - Black(Light Mode) does not do anything | Office 2010 Black (Light Mode) | closed | Variant not wired — selecting it had no effect (precedent for the wiring risks in §3). |
| [1787](https://github.com/Krypton-Suite/Standard-Toolkit/issues/1787) | [Bug]: Office 2k10 & 2k7 Silver (Dark Mode) Ribbon hovered button text is hard to read | Office 2007/2010 Silver (Dark Mode) | closed | Ribbon tracking text illegible in dark Silver variants. |
| [336](https://github.com/Krypton-Suite/Standard-Toolkit/issues/336) | [Bug]: "Office 2010 And 365 Minimise Icons Change Size" | Office 2010, Microsoft 365 | closed | Control-box glyph size inconsistency on hover. |
| [972](https://github.com/Krypton-Suite/Standard-Toolkit/issues/972) | [Bug]: `Office 2013` & `Microsoft 365` control box items are not 'flat' | Office 2013, Microsoft 365 | closed | Caption buttons rendered 3D instead of flat — direct fidelity divergence from the real products (fix PRs #3009/#3010/#3015; see also #971). |
| [737](https://github.com/Krypton-Suite/Standard-Toolkit/issues/737) | [Bug]: Selecting `Office 2013 - Dark Grey` for `PaletteMode` in designer causes a crash | Office 2013 Dark Grey | closed | Designer crash — part of why the grey modes are commented out today. |
| [492](https://github.com/Krypton-Suite/Standard-Toolkit/issues/492) | [ToDo]: Remove `Office 2013` due to redundancy with `Office 2013 White` theme | Office 2013 | closed | Duplicate 2013 entries consolidated to the single White palette (explains §1.4). |
| [470](https://github.com/Krypton-Suite/Standard-Toolkit/issues/470) | [Feature Request]: Include Dark/Light Gray Themes | Office 2013 Dark/Light Gray | **open** | Real-Office grey variants still missing at V105 (V110 PRs #3710/#3607 exist upstream). |
| [159](https://github.com/Krypton-Suite/Standard-Toolkit/issues/159) | [Bug]: Office 365 tracking colours are wrong | Microsoft 365 | closed | Hover/tracking colours did not match real Microsoft 365. |
| [371](https://github.com/Krypton-Suite/Standard-Toolkit/issues/371) | [Bug]: Office 365 Black theme ribbon needs better colours for disabled etc. | Microsoft 365 Black | closed | Disabled text/combos and unfocused ribbon tabs nearly invisible (fix PR #1578). |
| [515](https://github.com/Krypton-Suite/Standard-Toolkit/issues/515) | [Bug]: Office 365 Dark mode does not have enough contrast for disabled text | Microsoft 365 dark variants | closed | Systemic disabled-text contrast deficit. |
| [876](https://github.com/Krypton-Suite/Standard-Toolkit/issues/876) | [Bug]: `Office 365 - Black` does not display text correctly | Microsoft 365 Black | closed | General text colour fidelity failure. |
| [237](https://github.com/Krypton-Suite/Standard-Toolkit/issues/237) | [Bug]: Office 365 - Black (Dark mode) Messes up combo boxes | Microsoft 365 Black (Dark Mode) | closed | Combo colours broken in dark variant. |
| [1207](https://github.com/Krypton-Suite/Standard-Toolkit/issues/1207) | [Bug]: Microsoft 365 - Black (Dark Mode) Drop button is not visible | Microsoft 365 Black (Dark Mode) | closed | Drop-down glyph invisible on dark background. |
| [1689](https://github.com/Krypton-Suite/Standard-Toolkit/issues/1689) | [Bug]: MessageBox text is "Hard to read" when using MS 365 dark theme | Microsoft 365 dark variants | closed | KryptonMessageBox contrast failure. |
| [2213](https://github.com/Krypton-Suite/Standard-Toolkit/issues/2213) | [Bug]: KryptonToolstrip controls text unreadable on MS 365 White | Microsoft 365 White | closed | ToolStrip text unreadable (fix PRs #2217/#2218). |
| [19](https://github.com/Krypton-Suite/Standard-Toolkit/issues/19) | [BUG]: "Office 365 Silver" theme statusBar drag glyph, is not visible | Microsoft 365 Silver | closed | Status-bar grip invisible. |
| [1721](https://github.com/Krypton-Suite/Standard-Toolkit/issues/1721) | MS365 Black Dark Mode - Disabled Text Colours | Microsoft 365 Black (Dark Mode) | closed | Disabled text colour corrections. |
| [376](https://github.com/Krypton-Suite/Standard-Toolkit/issues/376) | [Bug]: Sparkle - ## (Dark mode) and (Light mode) do not change anything when selected | Sparkle dark/light variants | closed | Variants were no-ops — another wiring-gap precedent. |
| [1905](https://github.com/Krypton-Suite/Standard-Toolkit/issues/1905) | [Bug]: `Sparkle` Themes have an issue with the Background | Sparkle | closed | Family-wide background colour defect. |
| [1971](https://github.com/Krypton-Suite/Standard-Toolkit/issues/1971) | [Bug]: KryptonDataGridViewColumn Drop-down arrow image incorrect for Sparkle themes | Sparkle | closed | Wrong arrow glyph in grid columns (fix PRs #2419–#2421). |
| [923](https://github.com/Krypton-Suite/Standard-Toolkit/issues/923) | [Bug]: The default theme is set to `Sparkle - Blue` | Sparkle Blue | closed | Wrong default palette shipped (cf. #149, default moved from Office 2010 Blue to 365 Blue). |
| [1302](https://github.com/Krypton-Suite/Standard-Toolkit/issues/1302) | [Bug]: Font being used by "Professional" theme is pants ! | Professional / Office 2003 | closed | Wrong default font vs the real Office 2003 look. |
| [580](https://github.com/Krypton-Suite/Standard-Toolkit/issues/580) | [Bug]: No such help icon is available for `Professional` themes | Professional | closed | Missing help-button glyph. |
| [2084](https://github.com/Krypton-Suite/Standard-Toolkit/issues/2084) | [Feature Request]: "System theme" is the actual system OS theme and not a default win95 substitute | Professional System | closed | "System" rendered a Win95-style substitute rather than the real OS theme — same OS-adaptation weakness as the Office 2003 gating in §5. |

### 4.2 Cross-palette / dark-mode-wide issues

| # | Title | Scope | State | Defect |
|---|---|---|---|---|
| [638](https://github.com/Krypton-Suite/Standard-Toolkit/issues/638) | [Bug]: `ImageMarginxxx` options do not work as expected for all themes (apart from `System` and `Professional`!) | all Office/365/Sparkle families | **open** | Context-menu image-margin palette options ignored. |
| [189](https://github.com/Krypton-Suite/Standard-Toolkit/issues/189) | [Bug]: ToolStripLabels use the wrong colour for dark themes | all dark variants | closed | ToolStripLabel text not dark-adapted. |
| [1105](https://github.com/Krypton-Suite/Standard-Toolkit/issues/1105) | [Bug]: Label text colour in black themes is illegible | black/dark palettes | closed | Label ForeColor fidelity failure. |
| [590](https://github.com/Krypton-Suite/Standard-Toolkit/issues/590) | [Bug]: Button text colour in certain themes is unreadable | several palettes | closed | Button text contrast (see also #619, fixed via #1526/#1527). |
| [236](https://github.com/Krypton-Suite/Standard-Toolkit/issues/236) / [238](https://github.com/Krypton-Suite/Standard-Toolkit/issues/238) | Dark/light mode theme not applied to DataGrid / calendar backgrounds | dark/light variants | closed | Incomplete dark-mode surface coverage. |
| [1528](https://github.com/Krypton-Suite/Standard-Toolkit/issues/1528) | [Feature Request/Bug]: Tracking colours need reviewing | all palettes | closed | Systematic hover-colour review (fixed #1563/#1554). |
| [1729](https://github.com/Krypton-Suite/Standard-Toolkit/issues/1729) | [Bug]: `KryptonCustomPaletteBase` does not implement ##Tracking states | custom palettes | closed | Header tracking state ignored. |
| [3670](https://github.com/Krypton-Suite/Standard-Toolkit/issues/3670) | Bug: AppButton missing color in themes (V110) | multiple | closed | Ribbon AppButton colours unregistered in some palettes (fix #3671/#3706). |
| [1304](https://github.com/Krypton-Suite/Standard-Toolkit/issues/1304) | [Bug]: Palette color issues in v90.24.1.22 | multiple | closed | Regression release with assorted wrong colours. |
| [3101](https://github.com/Krypton-Suite/Standard-Toolkit/issues/3101) / [3103](https://github.com/Krypton-Suite/Standard-Toolkit/issues/3103) | Colours/theme name missing from exported theme XML | custom palette export | closed | Palette XML round-trip loss (relevant to our theme-sweep tests). |
| [1826](https://github.com/Krypton-Suite/Standard-Toolkit/issues/1826) | [Bug]: Input controls' EditArea focus colouring is not themed | all palettes | closed | Focus colour hard-coded, not palette-driven. |
| [1108](https://github.com/Krypton-Suite/Standard-Toolkit/issues/1108) | [Bug]: `KryptonPropertyGrid` background colour/text don't display correctly for some (most) themes | most palettes | closed | PropertyGrid colours wrong (follow-ups #1001, #1118). |
| [2894](https://github.com/Krypton-Suite/Standard-Toolkit/issues/2894) | [Bug]: Theme Switch | multiple | closed | Runtime theme switching left stale visuals ("Several theme fixes" PR #3602) — directly relevant to the Phase 6 theme-switch storm test. |
| [1976](https://github.com/Krypton-Suite/Standard-Toolkit/issues/1976) | [Bug] Theme settings for "MenuItem###" do not appear to work | all palettes | closed | MenuItem palette settings ignored (fixed V110 + V105-LTS, PRs #3626/#3623). |
| [397](https://github.com/Krypton-Suite/Standard-Toolkit/issues/397) | Normal context menu palette colours wrong | multiple | closed | Fixed on V110/V105-LTS via PRs #3628/#3622. |

### 4.3 Material themes

- Introduced only in V100 (2025) by PR [#2414](https://github.com/Krypton-Suite/Standard-Toolkit/pull/2414)
  ("first integration pass", scope limited to Material Light/Dark, "additional accents can layer on
  later"). Immediate follow-up fixes: [#2432](https://github.com/Krypton-Suite/Standard-Toolkit/pull/2432)
  (Material Dark form border invisible against dark background; grid header text black-on-dark) and
  [#2453](https://github.com/Krypton-Suite/Standard-Toolkit/pull/2453) (resize/hit-band on fixed borders).
- The parent feature request [#1022](https://github.com/Krypton-Suite/Standard-Toolkit/issues/1022)
  "[Feature Request]: New theme 'styles'" (Material + Metro, labelled `version:110`) is **still open** —
  the clearest upstream signal that Material theming is ongoing. No literal "under construction"
  marker survives in the current README/help/name strings (older Krypton-era "(Under Construction)"
  name suffixes were removed), so the incompleteness is expressed only via #1022 and the follow-up PRs.
- Local corroboration from this audit (§3.1): the four Material modes are absent from all 105
  command image switches (runtime throw), and Material borrows the M365 toolbar images with an
  in-source `TODO create our own Material images` (`KryptonManager.cs` ll. 1254–1260).

### 4.4 Visual Studio themes

- [#1083](https://github.com/Krypton-Suite/Standard-Toolkit/issues/1083) (**open**) requests real VS
  2012–2022 dark/light themes; upstream master still only ships the four VS2010 "variation" palettes,
  with the 2012–2022 name constants commented out — matching the 12 abstract stubs found in §1.7.
- [#2648](https://github.com/Krypton-Suite/Standard-Toolkit/issues/2648) (**open**) proposes
  deprecating the confusing "VS2010 (renderer variation)" naming — relevant if Bastion touches those names.

### 4.5 Open fidelity-adjacent requests and upstream context

- Open feature requests: [#436](https://github.com/Krypton-Suite/Standard-Toolkit/issues/436)
  (**Office 2021 themes** — upstream demand for exactly the spec §4.2 gap),
  [#942](https://github.com/Krypton-Suite/Standard-Toolkit/issues/942) (Office dark/light grey themes),
  [#470](https://github.com/Krypton-Suite/Standard-Toolkit/issues/470) (2013 Dark/Light Gray),
  [#1551](https://github.com/Krypton-Suite/Standard-Toolkit/issues/1551) (new dark/light mode colours),
  [#1870](https://github.com/Krypton-Suite/Standard-Toolkit/issues/1870) (cannot set/change colour table
  on `KryptonCustomPaletteBase`).
- Upstream added a "Themes Colour Checker GUI" to TestForm specifically to audit palette colour
  fidelity ([#2287](https://github.com/Krypton-Suite/Standard-Toolkit/issues/2287), PRs #2289/#2293/#2295),
  and the V100 strongly-typed scheme abstraction (PR #2294, see §2.2) was itself a response to
  systematic colour-array misalignment — both confirm the fidelity problem class this phase exists to fix.
- The nine-mode command-switch omission found in §3.1 (Material ×4, VS2010 ×4,
  `Microsoft365BlackDarkModeAlternate` → `ArgumentOutOfRangeException`) has **no matching upstream
  issue** — record in `BREAKAGE-LOG.md` as a Bastion-discovered defect and upstream-contribution candidate.

---

## 5. Gap confirmation against spec §4.2

| Spec target | Upstream status at baseline | Assessment |
|---|---|---|
| **Office 2003** | Survives as `PaletteMode.ProfessionalOffice2003` / `PaletteProfessionalOffice2003`. | **Present but effectively degraded on every supported OS.** The Office 2003 look is OS-gated: `GenerateColorTable` (`PaletteProfessionalOffice2003.cs` ll. 63–88) only applies the Luna colour schemes when `Environment.OSVersion.Version.Major < 6` (Windows XP/2003!) *and* visual styles report `NormalColor`/`HomeStead`/`Metallic`. On Windows Vista → 11 it silently falls back to `base.GenerateColorTable(true)` — i.e. it renders as the *system professional* palette, not Office 2003. Only three hard-coded colour pairs (header gradients, ll. 22–37) even exist; there is no scheme class. **Phase 3 action: build a genuine static Office 2003 palette set (Blue "Luna", Olive Green "Homestead", Silver "Metallic") as fixed schemes on the modern base pattern, keeping the legacy OS-adaptive palette for compatibility.** Matches the spec's expectation of "restore/refresh if degraded". |
| **Office 2016** | Absent. No palette class, no enum value, no scheme. The Colorful-era look is folded into "Microsoft 365". | Confirmed gap — build from scratch (per-app coloured title bar concept → a set of variants: Colorful, White, Dark Grey, Black-precursor grey). Note reusable assets exist: `Office2019ToolbarImageResources` icons are already embedded and used by the M365 palettes. |
| **Office 2019** | Absent (same as 2016; the only "2019" artefacts are the toolbar icon resources). | Confirmed gap — distinct Colorful/White/Dark Grey/Black variant set. |
| **Office 2021 / 2024** | Absent entirely. No Fluent-era rounded/soft-grey palette exists anywhere in the tree. | Confirmed gap. Note: faithful 2021/2024 rendering (rounded corners, subtle shadows, Segoe UI Variable) will also need renderer work, not just colours — plan a `Render<Fluent>`-class addition via §3.4. |
| **Microsoft 365 (current, 2026)** | 12 variants exist (10 wired + 2 grey disabled). | **Dated — approximately Office 2013/2016-era fidelity, not 2026 M365.** Evidence: (a) the *default* theme `Microsoft365Blue` sits in a folder upstream literally names `Non Official Themes`, and its scheme is gradient-heavy (`ButtonNormalBack1/Back2` two-stop gradients, gradient `PanelClient`/headers — `PaletteMicrosoft365Blue_BaseScheme.cs`) where real 2026 M365 is flat; (b) its window/caption assets are recycled Office 2010 bitmaps (`Office2010ControlBoxResources.Office2010Blue*`, `CheckBoxStrip2010Blue`, `Gallery2010`, `Office2010RadioButton*` — `PaletteMicrosoft365Blue.cs` ll. 50–166) and `Microsoft365White`/`Silver` reuse the Office 2010 *Silver* glyphs; (c) toolbar icons are the 2019 set; (d) `Microsoft365LightGray` is an unfinished stub (no scheme, no default ctor) and `Microsoft365DarkGray` is complete but disabled; (e) `Microsoft365BlackDarkModeAlternate` and the dark modes exist but the Alternate mode is missing from all command image switches (throws — §3.1) and dark-mode coverage has a long upstream bug tail (§4); (f) the "Blue/Silver" variant axis itself is an Office 2007/2010 concept — the real 2026 M365 theme options are Colorful / White / Dark Gray / Black / Use system setting. **Phase 3 action: refresh against 2026 M365 visuals with the proper variant set and true dark mode, per spec §4.2/§4.3.** |
| **Material (preserve per BUILD-LOG)** | 4 themes present (`MaterialLight/Dark` + Ripple variants), architecture piggybacks on `PaletteMicrosoft365Base` with Material token mapping; dedicated `RenderMaterial`/`KryptonMaterialRenderer`. | Functional but immature: `RippleEffect` flag exists at palette level; the nine-mode command-switch omission (§3.1) means selecting Material themes can throw with integrated toolbar commands; toolbar icons are borrowed M365 ones (`KryptonManager.cs` ll. 1254–1260, in-source `TODO create our own Material images`). Preserve, wire the missing switches, keep on the audit's watch list. |
| **Grey variants (all families)** | 8 palette classes exist; 6 have schemes (2007/2010/2013/M365 DarkGray), 4 LightGray classes are stubs; all 8 enum values commented out pending "gray themes … completed". | Decide in Phase 3: either finish (DarkGray variants are nearly done — scheme + default ctor + enum/dictionary/switch wiring) or leave disabled and document. Office 2016/2019 work will produce authentic Dark Grey values anyway — recommend finishing them as part of that effort. |
| **VS 2012–2022 (out of spec scope, recorded)** | 12 abstract stub classes + 12 commented enum values + 12 prepared display-name constants (`PaletteModeStrings.cs` ll. 71–82). | Not a spec §4.2 target; leave as upstream placeholders unless Chris directs otherwise. |

---

## 6. Recommendations carried into Phase 3 implementation

1. **Follow the official pattern** (§2.3): family base + `KryptonColorSchemeBase` scheme classes;
   never the cloned per-variant-base pattern of the "Extra Themes"; never raw `Color[]` ctors
   (removed in V110).
2. **Append new enum members before `Custom`**, updating enum and `SupportedThemes` in lock-step
   (ordering contract, §0), and add all §3.1 wiring in the same commit — the 105 throwing switches
   make partial wiring a runtime crash, not a cosmetic gap.
3. **Fix the pre-existing nine-mode switch omission** (Material ×4, VS2010 ×4,
   `Microsoft365BlackDarkModeAlternate`) before adding new modes; add a regression test that walks
   every `PaletteMode` through every `KryptonCommand.CommandType` (feeds Phase 5 theme-switch storm).
4. **Refactor the Extended Toolkit's five hard-coded lists** (§3.5) to delegate to core
   `PaletteModeStrings`/`ThemeManager` — otherwise every Bastion palette must be hand-added in six
   more places and index-renumbered (E1's `SelectedIndex` switch and E5's magic `33`).
5. New-family renderer decisions per §3.4; Office 2016/2019 can likely reuse `RenderMicrosoft365`
   chrome with new schemes, while Office 2021/2024 and the 2026 M365 refresh need rounded-corner
   renderer capability — scope that early.
6. Colour provenance per spec §4.3 goes to `docs/themes/<theme>-colours.md`; this audit deliberately
   contains mechanism only.
