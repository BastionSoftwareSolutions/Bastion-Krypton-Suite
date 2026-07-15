# Office 2019 — Named Colour Table (Colorful era refined, incl. Black)

Variants: **Colorful** (default), **Dark Gray**, **Black** (new in 2019/Office 365),
**White**. The Colorful chrome is shared with Office 2016; 2019's differences captured
here are the lighter neutral (`#F3F3F3` vs `#F1F1F1`), the new Outlook accent
(`#106EBE`) and the Black theme.

Sources (see `references/SOURCES.md`):

- **[H]** `references/office2019/wikipedia-office2019-composite.png` — Word/Excel/PowerPoint/Outlook 2019 RTM-era, Colorful, full windows (3770×2038 PNG, **lossless — exact values**).
- **[D]** `references/office2019/word|excel|powerpoint-colorful-ribbon.png` — official Microsoft support crops (lossless PNG).
- **[E]** `references/office2019/powerpoint-white.png`, `powerpoint-darkgray.png`, `powerpoint-black.png` — official Microsoft support crops (lossless PNG).
- **[G]** `references/m365-2026/office-addins-color-schemes.png` — official Microsoft brand-scheme image.

## App accent colours

| App | Hex | Source |
|---|---|---|
| Word | `#2B579A` | [H] title rect 600,8 400×12 — exact, 94.5% of pixels; [G] swatch |
| Excel | `#217346` | [H] title rect 2600,8 — exact, 96.4%; [G] swatch |
| PowerPoint | `#B7472A` | [H] title rect 700,1042 — exact, 94.5%; [G] swatch |
| Outlook | `#106EBE` | [H] title rect 2600,1042 — exact, 93.7% (Outlook adopted the Fluent blue in this era, replacing 2016's `#0072C6`) |

## Colorful variant

| Role | Hex | Source |
|---|---|---|
| Title bar active | app accent | [H] title rects above |
| Title bar text | `#FFFFFF` | [H] title rects (secondary population) |
| Ribbon tab row background | app accent | [H] rect 300,46 200×10 |
| Ribbon tab text (unselected) | `#FFFFFF` | [H] same rect |
| Selected ribbon tab fill | `#F3F3F3` | [H] rect 80,46 20×10 (Word Home tab) |
| Selected ribbon tab text | app accent (`#2B579A` in Word) | [H] same rect |
| Ribbon background | `#F3F3F3` | [H] rect 150,146 80×8 (official 2016-era crops [D] show `#F1F1F1`; the 2019 build reads two steps lighter) |
| Ribbon group label text | `#7E7E7E` | [H] rect 150,146 |
| Group separator line | `#D2D2D2` (range `#B1B1B1` edge px) | [D] ribbon rects; [H] `#B1B1B1` population |
| Window text (ribbon controls) | `#262626` | [H] control-glyph populations |
| Disabled text | *not captured in light themes* | Open item |
| Document surround / canvas | `#E6E6E6` | [H] rect 1650,500 80×60 |
| Excel column headers | `#E6E6E6`, header text `#999999`–`#666666` | [H] rect 2300,215 |
| Excel grid lines | `#D4D4D4` | [H] rect 2300,400 80×60 |
| Status bar (all four apps) | `#F3F3F3` | [H] rects 500,1000 / 2400,1000 / 700,2022 / 2200,2022 — uniform 100% |
| Outlook selected mail item | `#CDE6F7` | carried in the shared-era composite (`references/office2016/…composite`, rect 1900,1447); same visual language |
| Backstage background/accent | *not captured* | Open item |
| Context menu | *not captured* | Open item |

## White variant

From [E] `powerpoint-white.png`.

| Role | Hex | Source |
|---|---|---|
| Title bar / tab row / ribbon / status | `#FFFFFF` | rects 250,8 / 300,42 / 370,146 |
| Tab text (unselected) | `#444444` | rect 300,42 |
| Selected tab text | app accent — PPT sampled `#D24726` | rect 82,46 |
| Group separator | `#D5D5D5` | rect 370,146 |
| Ribbon group label text | `#666666` | rect 370,146 |

## Dark Gray variant

From [E] `powerpoint-darkgray.png`.

| Role | Hex | Source |
|---|---|---|
| Title bar / tab row | `#444444` | rects 250,8 / 300,42 |
| Tab text (unselected) | `#F0F0F0` | rect 300,42 |
| Ribbon background | `#B2B2B2` | rects 82,44 / 370,140 |
| Selected tab fill / text | `#B2B2B2` / `#262626` | rect 82,44 |
| Ribbon control text | `#262626` | rect 370,140 |
| Disabled command text | `#8A8A8A`–`#9A9A9A` band | greyed Format Painter populations |
| Side pane (slide thumbnails) | `#6A6A6A` | rect 250,312 |
| Icon-strip well | `#373737` | point 71,143 |

## Black variant (new in Office 2019)

From [E] `powerpoint-black.png`.

| Role | Hex | Source |
|---|---|---|
| Title bar / tab row | `#0A0A0A` | rects 250,8 / 300,42 |
| Tab text (unselected) | `#B4B4B4` | rect 300,42 |
| Ribbon background | `#363636` | rects 82,46 / 370,146 |
| Selected tab fill / text | `#363636` / `#FFFFFF` | rect 82,46 |
| Ribbon control text | `#DADADA` | rect 370,146 |
| Secondary ribbon text / separators | `#595959` | rect 370,146 |
| Side pane (slide thumbnails) | `#252525` | point 345,250 |
| Control well (Paste area) | `#3E3E3E` | point 60,79 |
| Content canvas (slides remain light) | `#FFFFFF` | rect 180,340 |

## Open items

1. **Hover / pressed fills** for all variants — not visible in static screenshots.
2. **Backstage and context menus** — no authoritative imagery; supply from live install.
3. **Title bar inactive** — all reference windows active.
4. **Word/Excel Black and Dark Gray** full windows for verification (Microsoft published
   only PowerPoint); chrome is app-independent.
5. Outlook 2019 Colorful uses `#106EBE`: worth confirming on a live 2019 install that
   perpetual-licence 2019 (not Office 365) shipped the same accent.
