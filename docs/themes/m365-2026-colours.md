# Microsoft 365 (current, 2026) — Named Colour Table

Current M365 desktop visuals: evolution of the Fluent refresh with a bluish-neutral app
frame (`#E9EEF2`), white ribbon card, accent underline on the selected tab, and a proper
dark ladder. Variants: **Use system setting** (default — maps to White/Black),
**White**, **Colorful**, **Dark Gray**, **Black**. Black doubles as the Dark Mode.

Sources (see `references/SOURCES.md`) — all official Microsoft support images, lossless
PNG, sampled exactly:

- **[M1]** `word-colorful-theme.png` (845×549)
- **[M2]** `excel-colorful-theme.png` (873×617)
- **[M3]** `powerpoint-colorful-theme.png` (842×577)
- **[M4]** `powerpoint-white-theme.png` (863×632)
- **[M5]** `word-darkgray-theme.png` (848×610)
- **[M6]** `excel-black-theme.png` (874×643)
- **[M7]** `office-themes-preview.png` (variant schematic)
- **[W]** `wikipedia-word-current.png` (640×480, downscaled — low-precision corroboration for status bar only)

## App accent colours (current brand palette)

| App | Hex | Source |
|---|---|---|
| Word | `#185ABD` | [M1] title rect 300,30 200×30 — 97.5% uniform |
| Excel | `#107C41` | [M2] title rect 300,40 — 93.8% uniform |
| PowerPoint | `#C43E1C` | [M3] title rect 300,40 — 95.6% uniform |
| Outlook (new Outlook) | *N/A / not captured* | The new Outlook does not paint an accent title bar; classic-Outlook accent for 2026 not found in official imagery — open item |

Selected-tab underline shades (accent, darker on light themes / lighter on dark):

| Context | Hex | Source |
|---|---|---|
| Word, Colorful (light) | `#1651AA` | [M1] col scan x=196, rows 174–177 |
| Excel, Colorful (light) | `#0F703B` | [M2] col scan x=190, rows 177–180 |
| PowerPoint, White | `#B13719` | [M4] col scan x=207, rows 190–193 |
| Excel, Black | `#60BD82` | [M6] col scan x=192, rows 180–183 |
| Word, Dark Gray | `#AEC6F0` | [M5] col scan x=194, rows 178–181 |

## Colorful variant

| Role | Hex | Source |
|---|---|---|
| Title bar active | app accent | [M1]/[M2]/[M3] title rects |
| Title bar text | `#FFFFFF` | [M1] title rect secondary population |
| App frame / ribbon tab row | `#E9EEF2` | [M1] rect 600,125 150×20 — 100% uniform; identical in [M2]/[M3] |
| Tab text (unselected) | `#242424` | [M2]/[M3] tab row populations |
| Selected tab text + underline | app accent / underline shades above | [M1]/[M2] scans |
| Ribbon background (card) | `#FFFFFF` | [M1] rect 550,200 200×30 — 88% plus control pixels |
| Ribbon control text | `#3A3A38` | [M1]/[M4] ribbon rects |
| Secondary ribbon text / subdued icons | `#797774`–`#8A8A8A` | [M1]/[M3] ribbon rects |
| Group label text | `#555758` | [M4]/[M2] label populations |
| Group separator / card edge | `#D1D1D1` with `#DDE2E6` shadow step to frame | [M1] rect 550,200 population; [M1] point 196,183 |
| Control borders (dropdowns) | `#8A8A8A` | [M1]/[M2] rect populations |
| Document surround | `#E9EEF2` (ruler margin `#DCE0E4`, scroll gutter `#E4E4E4`) | [M1] points 30,480 / 40,250 / 10,300 |
| Status bar | `#F5F5F5`, text `#616161` band | [W] rect 300,468 150×8 (downscaled source — modal; verify at implementation) |
| Backstage / context menus / hover states | *not captured* | Open items |

## White variant

From [M4] (PowerPoint).

| Role | Hex | Source |
|---|---|---|
| Title bar / app frame / tab row | `#E9EEF2` | rects 400,60 / 600,160 — the White theme shares the neutral frame; only the accent title fill is dropped |
| Title bar text | `#3A3A38` | rect 400,60 populations |
| Ribbon card | `#FFFFFF` (`#FAFAFA` gradient edge) | rect 440,230 |
| Selected tab underline | `#B13719` (PPT) | col scan x=207 |
| Tab text | `#242424` | rect 600,160 |
| Group label text | `#555758` | rect 600,160 populations |
| Document surround | `#E9EDF2`, gutter `#DBDBDB` | points 500,450 / 30,450 |

## Dark Gray variant

From [M5] (Word).

| Role | Hex | Source |
|---|---|---|
| Title bar / app frame / tab row | `#54585A` (uniform band `#52585D`) | rects 300,55 / 600,150 / 300,440 — note the deliberate blue-grey cast |
| Outer frame edge | `#616161` | rect 300,55 population |
| Title bar / tab text | `#FFFFFF` | rects 300,55 / 600,150 |
| Ribbon background (card) | `#BDBDBD` | rect 440,215 — 90% uniform ("contrasty controls" light card on dark frame) |
| Ribbon control text | `#404040` | rect 440,215 population |
| Secondary ribbon text | `#666666` | rect 440,215 population |
| Accent elements on ribbon (Word blue) | `#244276` | rect 440,215 population |
| Selected tab underline | `#AEC6F0` | col scan x=194 |
| Document surround | `#54585A` | rect 300,440 |
| Document page | `#FFFFFF` | point 700,520 |

## Black variant (Dark Mode)

From [M6] (Excel).

| Role | Hex | Source |
|---|---|---|
| Title bar / app frame / tab row | `#1C2227` | rects 300,55 / 600,150 — note the bluish near-black, not `#000000` |
| Title bar / tab text | `#FFFFFF` primary, `#DEDFE0` secondary | rects 300,55 / 600,150 |
| Ribbon background (card) | `#292929` | rect 440,215 — 88% uniform |
| Ribbon control text | `#DEDFE0`/`#FFFFFF`; subdued `#757575` | rects 440,215 / 600,150 |
| Selected tab underline | `#60BD82` (Excel) | col scan x=192 |
| Formula bar / name box | `#292929` | rect 600,415 — uniform |
| Column/row header band | `#0A0A0A`, header text `#DADADA` | rect 270,478 |
| Header accent (selected column) | `#5B9DDA` / selection green edge `#107C41` family | rect 270,478 populations; A1 cell border visually Excel green |
| Row-header selected tint | `#649BCF` | point 48,520 |
| Grid canvas (sheet stays light) | `#FFFFFF` | point 400,560 |
| Sheet splitter / gutter | `#646464` | point 143,470 |

## Variant overview (schematic)

[M7] `office-themes-preview.png` depicts the five options in order: Use system setting
(split light/dark), White, Colorful (blue title band), Dark Gray, Black — matching the
support article's descriptions ("Colorful … identical to White theme, but with the top of
the Ribbon accented with the primary color of the current application").

## Open items

1. **Status bar** per variant — only corroborated from a downscaled Wikipedia capture
   (light `#F5F5F5`); need lossless full-window screenshots (esp. Dark Gray/Black).
2. **Hover / pressed / disabled states** — not visible in static imagery; sample from a
   live M365 install (Chris).
3. **Backstage** (all variants) and **context menus** (all variants).
4. **Inactive title bar** (all variants).
5. **Classic Outlook** accents and dark-mode chrome for 2026.
6. **Use system setting** needs no palette of its own — it switches White/Black — but the
   theme-switcher UI in Krypton should model it; note for Phase 3 implementation.
