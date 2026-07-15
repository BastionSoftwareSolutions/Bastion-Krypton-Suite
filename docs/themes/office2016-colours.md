# Office 2016 — Named Colour Table (Colorful era)

Variants shipped by Office 2016 at launch: **Colorful** (default), **Dark Gray**,
**White**. (**Black did not exist in Office 2016** — it arrived with Office 2019 /
Office 365 in late 2018. **Light Gray** is an Office 2013 legacy option that the shared
support article still documented; noted below for completeness but not a 2016 variant.)

Sources (see `references/SOURCES.md`):

- **[C]** `references/office2016/wikipedia-office2016-composite.png` — Word/Excel/PowerPoint/Outlook 2016, Colorful, full windows (2963×1954 PNG; mid-2015 preview build, rescaled — flat fills reliable, ±1/channel jitter on some regions).
- **[D]** `references/office2019/word|excel|powerpoint-colorful-ribbon.png` — official Microsoft support crops of the shared 2016/2019 Colorful ribbon (lossless PNG).
- **[E]** `references/office2019/powerpoint-white.png`, `powerpoint-darkgray.png` — official Microsoft support crops; alt text explicitly says "PowerPoint 2016 with the … theme applied" (lossless PNG).
- **[F]** `references/office2016/white-theme-2016.png`, `darkgray-theme-2016.png`, `lightgray-theme-2013era.png` — official support crops (Outlook, 2013-style chrome; used only for roles stable across 2013→2016).
- **[G]** `references/m365-2026/office-addins-color-schemes.png` — official Microsoft brand-scheme image (Learn, "Color guidelines for Office Add-ins").
- **[H]** `references/office2019/wikipedia-office2019-composite.png` — lossless 2019 composite used to pin exact brand hexes where [C] shows rescale jitter.

## App accent colours (Colorful title bar / File button / brand)

| App | Hex | Source |
|---|---|---|
| Word | `#2B579A` | [G] Word swatch (43,87,154); [C] File tab rect 62,80 exact `#2B579A`; [C] title bar modal `#2A579A` (rescale jitter); [H] exact `#2B579A` |
| Excel | `#217346` | [G] Excel swatch (33,115,70); [H] exact `#217346`; [C]/[D] modal `#227447` (jitter) |
| PowerPoint | `#B7472A` | [G] PowerPoint swatch (183,71,42); [C] exact `#B7472A`; [D] exact `#B7472A` |
| Outlook | `#0072C6` | [F] white-theme FILE tab fill exact `#0072C6`; [C] title bar modal `#0173C7` (jitter) |

Darker companion swatches in [G] (used by Microsoft for hover/darker accents):
Word `#2C4B7A`, Excel `#255E3F` (sampled at swatch footer strips).

## Colorful variant

| Role | Hex | Source |
|---|---|---|
| Title bar active | app accent (above) | [C] rects 500,48 / 1900,48 / 500,1012 / 2150,1012 |
| Ribbon tab row background | app accent (continues from title bar) | [C] rect 500,80 200×12 |
| Ribbon tab text (unselected) | `#FFFFFF` | [C] same rect, secondary population |
| Selected ribbon tab fill | `#F1F1F1` (same as ribbon) | [C] rect 122,80 26×10 (Home tab) |
| Selected ribbon tab text | app accent (`#2B579A` in Word) | [C] same rect |
| Ribbon background | `#F1F1F1` | [C] rect 90,175 60×8; [D] rect 250,100 80×10 in all three official crops |
| Ribbon group label text | `#666666` | [C] rect 90,175 (secondary population) |
| Group separator line | `#D0D0D0` | [C]/[D] separator populations in ribbon rects |
| Ribbon bottom border | `#C6C6C6`–`#D0D0D0` | [C] col scan x=300 (boundary row 190–203 region) |
| Window/ribbon control text | `#262626`–`#333333` | [C] ribbon text populations; [F] tab text `#444444` |
| Disabled text | *not captured for 2016* | Open item (2019 Dark Gray reference [E] shows disabled Format Painter; light-theme disabled state needs a live screenshot) |
| Document surround (Word/Excel canvas) | `#E6E6E6` | [C] rect 1650,500 (2019 twin), rect 700,350 in [C] |
| Excel column headers | `#E6E6E6` | [C] rect 1600,240 |
| Status bar | `#F1F1F1`, text `#515050` | [C] rects 300,888 / 1650,888 / 400,1848 / 1700,1852 — **see open item 1** |
| Outlook selected mail item | `#CDE6F7` | [C] rect 1900,1447 |
| Outlook selected/hover folder row | `#E1E1E1` | [C] rect 1630,1402 |
| Backstage background/accent | *not captured* | Open item — no backstage screenshot found in official sources |
| Context menu | *not captured* | Open item |

## White variant

Sampled from [E] `powerpoint-white.png` (2016-era chrome) and [F] `white-theme-2016.png`.

| Role | Hex | Source |
|---|---|---|
| Title bar / tab row / ribbon | `#FFFFFF` throughout | [E] rects 250,8 / 300,42 / 370,146 |
| Tab text (unselected) | `#444444` | [E] rect 300,42 |
| Selected tab text | app accent — PPT sampled `#D24726` | [E] rect 82,46 (note: the White theme uses the 2013-era PowerPoint red `#D24726`, not `#B7472A`) |
| Group separator | `#D5D5D5`–`#DBDBDB` | [E] rect 370,146 |
| Ribbon group label text | `#666666` | [E] rect 370,146 |
| Outlook accent elements (FILE tab) | `#0072C6` | [F] rect 20,38 |
| Pane hover/selected row (Outlook) | `#E1E1E1` / `#FCFCFC` | [F] rect 60,368 |

## Dark Gray variant

Sampled from [E] `powerpoint-darkgray.png` (2016-era chrome per Microsoft alt text) and
[F] `darkgray-theme-2016.png`.

| Role | Hex | Source |
|---|---|---|
| Title bar / tab row | `#444444` | [E] rects 250,8 / 300,42 |
| Tab text (unselected) | `#F0F0F0` | [E] rect 300,42 |
| Ribbon background | `#B2B2B2` | [E] rects 82,44 / 370,140 |
| Selected tab fill / text | `#B2B2B2` / `#262626` | [E] rect 82,44 |
| Ribbon text | `#262626` | [E] rect 370,140 |
| Disabled command text | `#8A8A8A`–`#9A9A9A` (Format Painter, greyed) | [E] populations around 100,120 — JPEG-free but anti-aliased; modal band recorded |
| Slide/side pane background | `#6A6A6A` | [E] rect 250,312 |
| Darker chrome wells (icon strip) | `#373737` | [E] point 71,143 |
| Pane backgrounds (Outlook lists) | `#DEDEDE` | [F] rects 200,8 / 60,250 |
| FILE tab fill (Outlook) | `#333333` | [F] rect 20,38 |
| Selected folder row | `#F2F2F2` with accent link text `#2A8DD4` | [F] rect 60,368 |

## Light Gray (2013 legacy, reference only)

| Role | Hex | Source |
|---|---|---|
| Pane/chrome background | `#F1F1F1` | [F] lightgray rects 200,8 / 60,250 |
| FILE tab fill (Outlook) | `#0067B0` | [F] rect 20,38 |
| Selected row | `#E1E1E1` | [F] rect 60,368 |

## Open items (for Chris / live-install screenshots)

1. **Status bar in Colorful** — [C] (mid-2015 preview build) shows a neutral `#F1F1F1`
   status bar in all four apps, and the 2019 composite confirms neutral for that era; but
   RTM-era Office 2016 screenshots elsewhere commonly show the status bar filled with the
   app accent. Needs confirmation from a real Office 2016 install before implementation.
2. **Hover / pressed button fills** — static screenshots cannot show them; sample from a
   live install (expected: light grey `#D5D5D5`-family hover on light themes, accent-tint
   hover on the tab row).
3. **Backstage** (accent left rail + white content in this era) and **context menus** —
   no authoritative imagery found; supply screenshots.
4. **Title bar inactive** — all reference windows are active.
5. Word/Excel-specific Dark Gray and White full windows (only PowerPoint/Outlook were
   published by Microsoft) — chrome is app-independent, so this is verification only.
