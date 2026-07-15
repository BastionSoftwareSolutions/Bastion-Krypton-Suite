# Office 2021 / 2024 — Named Colour Table (Fluent visual refresh)

The 2021 "visual refresh" (shared by Office 2021, 2024 and the M365 builds of that era):
rounded corners, soft neutral greys, white ribbon card, accent used sparingly (title bar
in Colorful, tab underline, primary buttons). Variants: **Colorful**, **White**,
**Dark Gray**, **Black**, plus **Use system setting**.

Sources (see `references/SOURCES.md`):

- **[J]** `references/office2021/wikipedia-office2021-composite.png` — Word/Excel/PowerPoint/Outlook, refreshed UI, light theme, full windows (3770×2041 PNG, lossless; light anti-aliasing from capture scaling — modal values quoted, flat regions uniform).
- **[K]** `references/office2021/*.jpg` — official Microsoft support crops (JPEG — **modal values**, jitter noted).
- Cross-era anchor: **[M]** `references/m365-2026/*-colorful-theme.png` (lossless official PNGs of the same accent system) used to canonicalise accents where [K] shows JPEG jitter.

## App accent colours (Colorful title bar; refreshed brand palette)

| App | Hex | Source |
|---|---|---|
| Word | `#185ABD` | [K] word-colorful.jpg title rect 250,10 modal `#195ABE` (JPEG jitter); [J] Share button rect 1795,54 modal `#185ABD`; [M] exact `#185ABD` |
| Excel | `#107C41` | [K] excel-colorful.jpg title rect — uniform `#107C42` (JPEG); [M] exact `#107C41` |
| PowerPoint | `#C43E1C` | [K] powerpoint-colorful.jpg title rect — uniform `#C43D1D` (JPEG); [M] exact `#C43E1C` |
| Outlook (classic) | *not captured for this era* | Open item — Outlook in [J] shows neutral chrome; the colorful Outlook accent of this era needs a live sample (expected `#0F6CBD` family) |

## Colorful variant

| Role | Hex | Source |
|---|---|---|
| Title bar active | app accent | [K] title rects |
| Title bar text | `#FFFFFF` | [K] title regions |
| Ribbon tab row background | `#F0F0F0` | [K] word-colorful rect 300,70 modal; [J] rect 300,56 modal `#F0F0F0` |
| Tab text | `#262626` band | [K] populations (JPEG) |
| Selected tab underline | app accent | [K] word-colorful col scan x=91 — underline rows read white due to JPEG smear at 1px; accent confirmed visually and by [M] era (`#1651AA` Word underline in the successor build). Record as accent, exact shade open |
| Ribbon background (card) | `#FFFFFF` | [K] rect 300,176; [J] rect 300,160 modal `#FFFFFF` |
| Ribbon group label text | `#666666`–`#7A7A7A` band | [J]/[K] label rows (anti-aliased) |
| Group separator | `#E1E1E1`–`#EAEAEA` band | [J] rect 300,160 minor populations |
| Status bar | `#F5F5F5` | [J] rects 300,1003 / 2100,1006 / 500,2026 / 2600,2026 — uniform 100% in all four apps |
| App frame / document surround | `#F0F0F0` | [J] rect 1600,550 80×60 — uniform |
| Excel column headers | `#F0F0F0` | [J] rect 2200,220 |
| Outlook selected mail item | `#CDE6F7` | [J] rect 2200,1250 — 98.6% uniform |
| Outlook command bar | `#FFFFFF` | [J] rect 2300,1112 |
| Primary action button (Share) | app accent (`#185ABD` Word) | [J] rect 1795,54 |
| Backstage / context menus | *not captured* | Open items |

## White variant

| Role | Hex | Source |
|---|---|---|
| Title bar / tab row | `#F0F0F0` | [K] powerpoint-white.jpg rects 250,10 / 300,70 (modal). Note: [J] (Windows 11 capture) reads the title band `#FAFAFA` with `#F0F0F0` frame — record `#F0F0F0` (Win10-era crop) vs `#FAFAFA` (Win11 mica-adjacent) as a build/OS difference; pick per fidelity sign-off |
| Ribbon card | `#FFFFFF` | [K]/[J] as Colorful |
| Status bar | `#F5F5F5` | [J] |
| Everything else | as Colorful minus accent title | [K] powerpoint-white.jpg |

## Dark Gray variant

From [K] `powerpoint-darkgray.jpg` (JPEG — modal values; ribbon collapsed in the crop).

| Role | Hex | Source |
|---|---|---|
| Title bar / tab row | `#2E2E2E` | rects 250,8 / 300,70 — uniform |
| Tab text | `#FFFFFF` | rect 300,70 secondary population |
| Toolbar strip (QAT/secondary bar) | `#424242` | rect 300,102 — uniform |
| Ribbon background | *not visible (collapsed)* | Open item — expected `#424242` family; confirm on live install |
| Disabled command text ("Speak", greyed) | `#7A7A7A` band | toolbar row populations |

## Black variant

From [K] `powerpoint-black.jpg` (JPEG — modal values; ribbon collapsed in the crop).

| Role | Hex | Source |
|---|---|---|
| Title bar / tab row | `#0A0A0A` | rects 250,8 / 300,70 |
| Tab text | `#FFFFFF` | rect 300,70 |
| Toolbar strip (QAT/secondary bar) | `#1F1F1F` | rect 300,102 — uniform |
| Ribbon background | *not visible (collapsed)* | Open item — expected `#1F1F1F`–`#262626`; confirm on live install |

## Open items

1. **Dark Gray / Black ribbon-expanded references** — both official crops have the ribbon
   collapsed; need live screenshots (Word or Excel, ribbon pinned) for ribbon card, group
   labels, control text and separators in the dark variants.
2. **Selected-tab underline exact shades** per app/variant (1px feature, JPEG-smeared).
3. **Hover / pressed fills**, **backstage**, **context menus**, **inactive title bar** —
   not visible in static official imagery.
4. **Classic Outlook accent** for this era.
5. White-variant title band `#F0F0F0` vs `#FAFAFA` (OS/build difference) — decide at
   fidelity sign-off.
