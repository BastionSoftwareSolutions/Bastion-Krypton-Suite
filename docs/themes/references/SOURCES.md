# Theme Reference Image Sources — Bastion Krypton Suite Phase 3

Compiled 15 July 2026. Every reference file in `docs/themes/references/<theme>/` is listed
here with its source URL, page title and what it depicts. All colour values in the
`docs/themes/*-colours.md` tables trace either to a pixel sample from one of these files
(via `Scripts/Eyedropper/Get-PixelColour.ps1`) or to a cited official source file.

Wikipedia-hosted application screenshots are non-free (fair-use) content; they are held
here strictly as internal colour-fidelity references, not for redistribution.

**Note on dead CDN links:** the era-specific Microsoft support images were originally
served from `https://support.content.office.net/en-us/media/<guid>.png`. That CDN now
redirects to `cxcs.cdn.office.net` and returns 404 (verified 15 July 2026), so those
files were recovered from the Wayback Machine using
`http://web.archive.org/web/<timestamp>im_/<original-url>` — the `im_` form serves the
archived original bytes unmodified.

---

## m365-2026 — current Microsoft 365 desktop visuals

Primary page: **"Change the look and feel of Microsoft 365"**, Microsoft Support,
https://support.microsoft.com/en-us/office/change-the-look-and-feel-of-microsoft-365-63e65e1c-08d4-4dea-820e-335f54672310
(fetched live 15 July 2026; image GUID URLs resolved via the Wayback snapshot of
30 April 2026 because the live page lazy-loads images client-side). Images are served
live from `https://support.microsoft.com/images/en-us/<guid>` (verified HTTP 200).

| File | Source URL | Depicts |
|---|---|---|
| `word-colorful-theme.png` | https://support.microsoft.com/images/en-us/cfdd715b-d173-4df6-aa49-494840753e82 | Word, Colorful theme — title bar (#185ABD), tab row, ribbon, ruler, document edge (845×549 PNG) |
| `excel-colorful-theme.png` | https://support.microsoft.com/images/en-us/ba79cd20-ef93-4df9-860f-181326752f96 | Excel, Colorful theme — title bar (#107C41), tab row, ribbon (873×617 PNG) |
| `powerpoint-colorful-theme.png` | https://support.microsoft.com/images/en-us/c04d5459-9aa9-44e3-8773-f00a3a4ce58b | PowerPoint, Colorful theme — title bar (#C43E1C), tab row, ribbon (842×577 PNG) |
| `powerpoint-white-theme.png` | https://support.microsoft.com/images/en-us/416020d4-d8ce-41c0-9b6e-c4e94b937475 | PowerPoint, White theme — all-light chrome, accent tab underline, slide pane (863×632 PNG) |
| `word-darkgray-theme.png` | https://support.microsoft.com/images/en-us/d9cfea1e-2860-41b7-985d-973634437dbf | Word, Dark Gray theme — dark frame, light ribbon card, ruler, document surround (848×610 PNG) |
| `excel-black-theme.png` | https://support.microsoft.com/images/en-us/c8dc02a4-dae6-44cc-8e91-10646225a594 | Excel, Black theme — near-black frame, dark ribbon card, formula bar, grid headers (874×643 PNG) |
| `office-themes-preview.png` | https://support.microsoft.com/images/en-us/d3e6db09-85d9-4b02-adc0-806910d1b1ac | Schematic preview strip of the five theme options: Use system setting / White / Colorful / Dark Gray / Black (2286×289 PNG) |
| `theme-selections-dropdown.png` | https://support.microsoft.com/images/en-us/baceb78c-4c86-41d3-8aed-4fc28fa28ed0 | The Office Theme dropdown listing the five options (270×159 PNG) |
| `office-addins-color-schemes.png` | https://learn.microsoft.com/en-us/office/dev/add-ins/images/office-addins-color-schemes.png from **"Color guidelines for Office Add-ins"**, https://learn.microsoft.com/en-us/office/dev/add-ins/design/add-in-color | Official Microsoft image of the Office/Excel/Word/PowerPoint brand colour schemes — sampled Word #2B579A, Excel #217346, PowerPoint #B7472A (classic-era brand swatches) |
| `wikipedia-word-current.png` | https://upload.wikimedia.org/wikipedia/en/c/c6/Microsoft_Word.png — file page https://en.wikipedia.org/wiki/File:Microsoft_Word.png (article "Microsoft Word") | Full current Word window incl. status bar (640×480, downscaled — low-precision corroboration only) |
| `wikipedia-excel-current.png` | https://upload.wikimedia.org/wikipedia/en/9/94/Microsoft_Excel.png — https://en.wikipedia.org/wiki/File:Microsoft_Excel.png | Full current Excel window (640×480, downscaled) |
| `wikipedia-powerpoint-current.png` | https://upload.wikimedia.org/wikipedia/en/7/75/Microsoft_PowerPoint.png — https://en.wikipedia.org/wiki/File:Microsoft_PowerPoint.png | Full current PowerPoint window (640×480, downscaled) |

## office2021 — Office 2021/2024 visual refresh

Primary page: **"Change the look and feel of Office"** (same article GUID as above), as it
stood on 1 June 2022 — Wayback snapshot
http://web.archive.org/web/20220601062156/https://support.microsoft.com/en-us/office/change-the-look-and-feel-of-office-63e65e1c-08d4-4dea-820e-335f54672310
Original CDN URLs dead; archived copies via `web.archive.org/web/20220601062156im_/<url>`.
These are JPEGs — colour values from them are recorded as modal values.

| File | Original source URL | Depicts |
|---|---|---|
| `word-colorful.jpg` | https://support.content.office.net/en-us/media/4efbb592-9af5-4737-8abc-1d400d886650.jpg | Word 2021, Colorful — #185ABD title bar, light tab row, white ribbon (472×200) |
| `excel-colorful.jpg` | https://support.content.office.net/en-us/media/49ecda98-a993-4b14-a32e-700fa6364370.jpg | Excel 2021, Colorful — #107C41 title bar (472×199) |
| `powerpoint-colorful.jpg` | https://support.content.office.net/en-us/media/7f02cd96-1394-4e52-9ab3-a2c591f89e20.jpg | PowerPoint 2021, Colorful — #C43E1C title bar (472×200) |
| `powerpoint-white.jpg` | https://support.content.office.net/en-us/media/81f29957-4bf7-4119-9668-d2ffa43c911b.jpg | PowerPoint 2021, White theme (534×534) |
| `powerpoint-darkgray.jpg` | https://support.content.office.net/en-us/media/1545d64c-d7c0-4ccf-ba3b-7366554693fe.jpg | PowerPoint 2021, Dark Gray theme (534×534) |
| `powerpoint-black.jpg` | https://support.content.office.net/en-us/media/1deee7f6-ccd1-411f-901b-72e34152eba1.jpg | PowerPoint 2021, Black theme (534×534) |
| `settings-theme.jpg` | https://support.content.office.net/en-us/media/309f6ba8-776c-4560-a67c-af3c3feb8946.jpg | Office 2021 theme settings dialogue (413×259) |
| `wikipedia-office2021-composite.png` | https://upload.wikimedia.org/wikipedia/en/f/fb/Microsoft_Office_2021_(new_UI).png — https://en.wikipedia.org/wiki/File:Microsoft_Office_2021_(new_UI).png (article "Microsoft Office 2021") | Word, Excel, PowerPoint and Outlook 2021 (refreshed UI), light theme, full windows incl. status bars (3770×2041 PNG, lossless) |

## office2019 — Office 2019 (Colorful era, incl. Black)

Primary page: same support article as it stood on 12 November 2020 — Wayback snapshot
http://web.archive.org/web/20201112024144/https://support.microsoft.com/en-us/office/change-the-look-and-feel-of-office-63e65e1c-08d4-4dea-820e-335f54672310
Original CDN URLs dead; archived copies via `web.archive.org/web/20201112024144im_/<url>`.
(Microsoft's alt text names the app UI "2016"; the imagery shows the shared 2016/2019
Colorful-era chrome, and the Black theme shown shipped with Office 2019 / Office 365.)

| File | Original source URL | Depicts |
|---|---|---|
| `word-colorful-ribbon.png` | https://support.content.office.net/en-us/media/5d08a9d7-3a43-4cbd-a5b4-457b18110ad0.png | Word colorful ribbon crop — accent title/tab band over #F1F1F1 ribbon (454×154 PNG) |
| `excel-colorful-ribbon.png` | https://support.content.office.net/en-us/media/bfd01b06-8e82-485d-9c03-d6685f105096.png | Excel colorful ribbon crop (454×154 PNG) |
| `powerpoint-colorful-ribbon.png` | https://support.content.office.net/en-us/media/efbd7b5a-4fd3-4382-84e9-cf0a3e495fed.png | PowerPoint colorful ribbon crop (453×154 PNG) |
| `powerpoint-darkgray.png` | https://support.content.office.net/en-us/media/f9861e77-8804-4c1d-8e81-8c86376cd3dc.png | PowerPoint, Dark Gray theme — title #444444, ribbon #B2B2B2, incl. disabled Format Painter (506×483 PNG) |
| `powerpoint-black.png` | https://support.content.office.net/en-us/media/03d8b796-f1a2-4d6f-9abf-dc48b019f6b2.png | PowerPoint, Black theme — title #0A0A0A, ribbon #363636 (507×484 PNG) |
| `powerpoint-white.png` | https://support.content.office.net/en-us/media/bbc8906a-29da-41e8-b0d8-1ea9750e3639.png | PowerPoint, White theme — all-white chrome, accent tab text (512×441 PNG) |
| `theme-options-dropdown.png` | https://support.content.office.net/en-us/media/efd8f266-acd8-4bbf-9eea-927fb8646748.png | Office Theme options dropdown, PowerPoint (Colorful / Dark Gray / Black / White) (352×169 PNG) |
| `wikipedia-office2019-composite.png` | https://upload.wikimedia.org/wikipedia/en/d/d4/Microsoft_Office_2019_-_Word,_Excel,_Outlook,_PowerPoint.png — https://en.wikipedia.org/wiki/File:Microsoft_Office_2019_-_Word,_Excel,_Outlook,_PowerPoint.png (article "Microsoft Office 2019") | Word, Excel, PowerPoint, Outlook 2019, Colorful theme, full windows incl. status bars (3770×2038 PNG, lossless — the exact-value primary reference for 2019) |

## office2016 — Office 2016 (Colorful era)

Primary page: **"Change the Office theme"**, Microsoft Support (support.office.com), as it
stood on 17 November 2017 — Wayback snapshot
http://web.archive.org/web/20171117155013/https://support.office.com/en-us/article/change-the-office-theme-b2098f8a-aac8-4646-9cf0-7c91d1284da6
Original CDN URLs dead; archived copies via `web.archive.org/web/20171117155013im_/<url>`.

| File | Original source URL | Depicts |
|---|---|---|
| `theme-dropdown-2016.png` | https://support.content.office.net/en-us/media/4a547d4d-4764-41dd-8f74-9567c031a03c.png | "Choose a different Office Theme" dropdown, Office 2016 (Colorful / Dark Gray / White) (234×191 PNG) |
| `white-theme-2016.png` | https://support.content.office.net/en-us/media/f2233c58-d4f5-44fa-8a98-cb508ecd71a2.png | Outlook (2013-style chrome), White Office theme — FILE tab #0072C6 accent fill (325×456 PNG) |
| `lightgray-theme-2013era.png` | https://support.content.office.net/en-us/media/ed1ade22-591b-46bf-9c33-5f7359659657.png | Outlook, Light Gray theme — an Office 2013 legacy variant, kept for completeness (325×456 PNG) |
| `darkgray-theme-2016.png` | https://support.content.office.net/en-us/media/94d47b11-6364-4462-814d-44dd5bdba137.png | Outlook, Dark Gray Office theme (2013-style chrome) (325×456 PNG) |
| `wikipedia-office2016-composite.png` | https://upload.wikimedia.org/wikipedia/en/5/54/Microsoft_Office_2016_Screenshots.png — https://en.wikipedia.org/wiki/File:Microsoft_Office_2016_Screenshots.png (article "Microsoft Office 2016") | Word, Excel, PowerPoint, Outlook 2016 (mid-2015 preview build), Colorful theme, full windows incl. status bars (2963×1954 PNG; appears rescaled — flat fills exact, edges anti-aliased) |

The three Office 2019-era colorful ribbon crops (see office2019 above) also serve as
official 2016-era references: the Colorful chrome is shared between 2016 and 2019.

## office2003 — Office 2003 (Luna era)

| File | Source URL | Depicts |
|---|---|---|
| `wikipedia-office2003-screenshot.png` | https://upload.wikimedia.org/wikipedia/en/5/54/Office2003_screenshot.PNG — https://en.wikipedia.org/wiki/File:Office2003_screenshot.PNG (article "Microsoft Office 2003") | Word, Excel, PowerPoint and Outlook 2003 on Windows XP Luna Blue — title bars, menu bars, toolbars, task panes, status bars, Outlook navigation pane (1920×1080 PNG, 1:1 pixels — primary sampling reference) |
| `ProfessionalColorTable-dotnet-winforms.cs` | https://raw.githubusercontent.com/dotnet/winforms/main/src/System.Windows.Forms/System/Windows/Forms/Controls/ToolStrips/ProfessionalColorTable.cs (repo https://github.com/dotnet/winforms, MIT) | Microsoft's own WinForms reproduction of the Office 2003 command-bar colours: `InitBlueLunaColors`, `InitOliveLunaColors`, `InitSilverLunaColors`, `InitRoyaleColors` — exact RGB tables for toolbar gradients, menus, hover/pressed/checked fills, disabled text, separators |

Note: the retired referencesource.microsoft.com site now redirects to GitHub, and the
public `microsoft/referencesource` repo does not include System.Windows.Forms; the
actively maintained `dotnet/winforms` repository retains the identical Luna tables and is
the citable source.

## Pages consulted but not harvested for pixels

- "The new look of Office", Microsoft Support — https://support.microsoft.com/en-us/office/the-new-look-of-office-a6cdf19a-b2bd-4be1-9515-d74a37aa59bf (describes the 2021 visual refresh).
- "Visual refresh of Office apps for Windows", Microsoft 365 Insider blog — https://techcommunity.microsoft.com/blog/microsoft365insiderblog/visual-refresh-of-office-apps-for-windows/4213124 (JavaScript-rendered; images not retrievable non-interactively — candidate for manual capture).
- "Color guidelines for Office Add-ins", Microsoft Learn — https://learn.microsoft.com/en-us/office/dev/add-ins/design/add-in-color (source of `office-addins-color-schemes.png`; confirms the four Windows UI themes plus Use system setting).
