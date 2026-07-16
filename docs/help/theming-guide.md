# Theming Guide

Every Krypton control paints through a **palette**. A palette is a `PaletteBase`-derived class
that answers colour, font, border and metric questions for a renderer. Selecting a palette —
globally or per control — is how you theme an application.

This guide covers the palette model, the built-in theme set, the themes Bastion adds, and how
to switch themes at runtime. Named colour tables with provenance for the Bastion-authored
themes are linked from [Themes Bastion adds](#themes-bastion-adds) below.

## The palette model

- A **`PaletteMode`** enum value names a theme (for example `Office2010Blue`,
  `Microsoft365Black`).
- A concrete **palette class** (for example `PaletteOffice2010Blue`) supplies the appearance,
  usually by deriving from a family base and reading a strongly-typed **`*_BaseScheme`** colour
  scheme.
- A **renderer** (`RenderOffice2007`, `RenderOffice2010`, `RenderOffice2013`,
  `RenderMicrosoft365`, `RenderSparkle`, `RenderProfessional`) draws using the palette's answers.
- **`KryptonManager`** owns the global palette; every control can also override it locally.

> **Ordering contract.** The `PaletteMode` enum and the `PaletteModeStrings.SupportedThemes`
> dictionary must stay in the same order — designer code uses `(int)PaletteMode.Xxx` as a
> combo-box index. New theme families are appended before `Custom`, which stays last, so
> existing ordinals never shift. Keep this in mind if you extend the palette set.

## Built-in themes

The suite ships **48 selectable built-in themes** across these families (plus `Global` and
`Custom`):

| Family | Renderer | Variants |
|---|---|---|
| Professional / System | `RenderProfessional` | System colours, Office 2003 (Luna Blue) |
| Office 2007 | `RenderOffice2007` | Blue, Silver, Black, White, plus Blue/Silver/Black Dark-Mode and Blue/Silver Light-Mode |
| Office 2010 | `RenderOffice2010` | Blue, Silver, Black, White, plus the Dark/Light-Mode spread |
| Office 2013 | `RenderOffice2013` | White (the one active 2013 theme) |
| Microsoft 365 | `RenderMicrosoft365` | Blue (default), White, Silver, Black, plus Blue/Silver/Black Dark-Mode, Blue/Silver Light-Mode and a Black Dark-Mode alternate |
| Sparkle | `RenderSparkle` | Blue, Orange, Purple, each with Dark/Light-Mode variants |

The **default theme is Microsoft 365 Blue** (`GLOBAL_DEFAULT_PALETTE_MODE`). A set of grey
variants (`*DarkGray`/`*LightGray`) and the Visual Studio 2012–2022 variants exist as classes
but are disabled in the enum upstream; they are documented in
[`docs/audit/THEME-AUDIT.md`](../audit/THEME-AUDIT.md).

## Themes Bastion adds

Bastion's Phase 3 fidelity pass fills the historical gaps in the Office timeline. Each new
palette derives from `PaletteMicrosoft365Base`/`RenderMicrosoft365` (no new renderer was
invented, per the audit) and reads a dedicated `*_BaseScheme` whose every colour slot is tagged
with its provenance:

| Theme | Palette classes | Colour table |
|---|---|---|
| **Office 2003** (extra variants) | `PaletteOffice2003Olive` (Homestead), `PaletteOffice2003Silver` | [office2003-colours.md](../themes/office2003-colours.md) |
| **Office 2016** | `PaletteOffice2016Colorful`, `PaletteOffice2016White`, `PaletteOffice2016DarkGray` | [office2016-colours.md](../themes/office2016-colours.md) |
| **Office 2019** | `PaletteOffice2019Colorful`, `PaletteOffice2019White`, `PaletteOffice2019DarkGray`, `PaletteOffice2019Black` | [office2019-colours.md](../themes/office2019-colours.md) |
| **Office 2021 / 2024** | `PaletteOffice2021Colorful`, `PaletteOffice2021White`, `PaletteOffice2021DarkGray`, `PaletteOffice2021Black` | [office2021-colours.md](../themes/office2021-colours.md) |
| **Microsoft 365 (2026 refresh)** | refreshed M365 variants | [m365-2026-colours.md](../themes/m365-2026-colours.md) |

Colour values were extracted programmatically from reference screenshots of the real Office
applications; the provenance of every reference image is recorded in
[`docs/themes/references/SOURCES.md`](../themes/references/SOURCES.md), and side-by-side
fidelity comparison images live under `docs/themes/comparisons/` in the repository.

## Selecting a theme

### Globally (whole application)

```csharp
using Krypton.Toolkit;

var manager = new KryptonManager();
manager.GlobalPaletteMode = PaletteMode.Office2019Colorful;
```

Drop a `KryptonManager` on your main form in the designer and set **GlobalPaletteMode** in the
Properties window to do the same without code.

### Per control

```csharp
kryptonButton1.PaletteMode = PaletteMode.Office2010Black;
```

### At runtime, live

Changing `GlobalPaletteMode` while forms are open re-themes them immediately. Live theme
switching across every palette — including under resize — is a mandatory stress test in the
suite, so switching is safe to expose to end users (for example through a theme picker).

## Theme pickers and the Extended Theme Switcher

Two ready-made controls enumerate the installed themes for you:

- **`KryptonThemeComboBox`** (core Toolkit) and **`KryptonRibbonGroupThemeComboBox`** (Ribbon).
- The Extended **[Theme Switcher](extended/theme-switcher.md)** module, which adds a richer
  selector plus download/upload of external theme packages.

Any new `PaletteMode` you add must also be surfaced through these enumerators — see the theme
audit for the exact list of factory, converter and helper sites that enumerate themes.
