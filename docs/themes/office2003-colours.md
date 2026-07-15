# Office 2003 — Named Colour Table (Luna era)

Purpose: refresh of the existing `PaletteProfessionalOffice2003`
(`Standard-Toolkit\Source\Krypton Components\Krypton.Toolkit\Palette Builtin\Professional\PaletteProfessionalOffice2003.cs`).

Variants: **Blue (Luna "NormalColor")**, **Olive (Luna "Homestead")**, **Silver (Luna
"Metallic")**. Office 2003 adapts to the Windows XP visual style; there is no dark mode.

Sources (see `references/SOURCES.md` for full provenance):

- **[A]** `references/office2003/wikipedia-office2003-screenshot.png` — Word/Excel/PowerPoint/Outlook 2003 on XP Luna Blue, 1920×1080, 1:1 pixels. Sampled with `Scripts/Eyedropper/Get-PixelColour.ps1`.
- **[B]** `references/office2003/ProfessionalColorTable-dotnet-winforms.cs` — Microsoft's WinForms `ProfessionalColorTable` (dotnet/winforms), functions `InitBlueLunaColors` / `InitOliveLunaColors` / `InitSilverLunaColors`. Official Microsoft reproduction of the Office 2003 command-bar palette; values quoted exactly.

## Blue (Luna NormalColor) — primary variant

| Role | Hex | Source |
|---|---|---|
| Title bar active, top edge | `#0058EE` | [A] col scan x=500, row 0 (PowerPoint active caption) |
| Title bar active, core fill | `#0054E3`–`#0055E5` | [A] col scan x=500, rows 7–16 (modal `#0055E5`) |
| Title bar active, lower sheen | `#026AFE` | [A] col scan x=500, rows 22–25 |
| Title bar active, bottom edge | `#0043CF` | [A] col scan x=500, row 29 |
| Title bar text | `#FFFFFF` | [B] `msocbvcrCBTitleText` (255,255,255); visually confirmed in [A] |
| Title bar inactive | *not captured* | Open item — no inactive window in [A]; needs a screenshot from a live XP/VM session |
| Menu bar band (behind menus) | `#A6C4F6` (range `#A3C2F5`–`#A9C6F6`) | [A] rect 1050,38 150×8 (Word menu bar) |
| Menu bar gradient (official) | `#9EBEF5` → `#C4DAFA` | [B] `msocbvcrCBGradMainMenuHorzBegin/End` (158,190,245 → 196,218,250) |
| Toolbar gradient top | `#E3EFFF` | [B] `msocbvcrCBGradVertBegin` (227,239,255) |
| Toolbar gradient middle | `#CBE1FC` | [B] `msocbvcrCBGradVertMiddle` (203,225,252) |
| Toolbar gradient bottom | `#7BA4E0` | [B] `msocbvcrCBGradVertEnd` (123,164,224) — [A] toolbar rect 1050,60 sampled the same ramp, modal `#D5E7FD` mid-tone |
| Command-bar background | `#C4DBF9` | [B] `msocbvcrCBBkgd` (196,219,249) |
| Button hover fill | `#FFEEC2` | [B] `msocbvcrCBCtlBkgdMouseOver` (255,238,194); gradient `#FFFFDE→#FFE1AC→#FFCB88` (`msocbvcrCBGradMouseOverBegin/Middle/End`) |
| Button pressed fill | `#FE803E` | [B] `msocbvcrCBCtlBkgdMouseDown` (254,128,62); gradient `#FE803E→#FFB16D→#FFDF9A` (`msocbvcrCBGradMouseDownBegin/Middle/End`) |
| Button checked/selected fill | `#FFC06F` | [B] `msocbvcrCBCtlBkgdSelected` (255,192,111); gradient `#FFDF9A→#FFC374→#FFA64C` (`msocbvcrCBGradSelectedBegin/Middle/End`) |
| Hover/pressed/selected border | `#000080` | [B] `msocbvcrCBCtlBdrMouseOver/MouseDown/Selected` (0,0,128) |
| Window text | `#000000` | [B] `msocbvcrCBCtlText` (0,0,0) |
| Disabled text | `#8D8D8D` | [B] `msocbvcrCBCtlTextDisabled` (141,141,141) |
| Context/dropdown menu background | `#F6F6F6` | [B] `msocbvcrCBMenuBkgd` (246,246,246) |
| Context menu outer border | `#002D96` | [B] `msocbvcrCBMenuBdrOuter` (0,45,150) |
| Context menu icon column | `#CBE1FC` | [B] `msocbvcrCBMenuIconBkgd` (203,225,252) |
| Context menu highlight | `#FFEEC2` fill, `#000080` border | [B] hover values above (Office 2003 menus reuse the toolbar hover style) |
| Menu shadow | `#5F82EA` | [B] `msocbvcrCBMenuShadow` (95,130,234) |
| Group/toolbar separator line | `#6A8CCB` with light side `#F1F9FF` | [B] `msocbvcrCBSplitterLine` (106,140,203) / `msocbvcrCBSplitterLineLight` (241,249,255) |
| Drag handle dots | `#274176` | [B] `msocbvcrCBDragHandle` (39,65,118) |
| Floating toolbar title | `#2A66C9` | [B] `msocbvcrCBTitleBkgd` (42,102,201) |
| Docked toolbar outer border | `#C4CDDA` | [B] `msocbvcrCBBdrOuterDocked` (196,205,218) |
| Status bar / control face | `#ECE9D8` | [A] rect 1100,520 150×8 (Word status bar — the Luna 3-D face colour) |
| Excel column-header face | `#EFEBDE` | [A] rect 1100,646 80×8; border `#7E7D68` same rect |
| Sheet-tab strip | `#ECE9D8` | [A] rect 1100,1041 100×8 |
| Task pane background | `#FFFFFF` body with `#D4E5FA`–`#D8E8FC` gradient bands | [A] rect 1800,300 60×40 ("Getting Started" pane) |
| Task pane / control border | `#7F9DB9` | [A] same rect (the XP field border) |
| Outlook nav selected button | `#F2AD3B` → `#F5C058` gradient | [A] rect 40,902 80×8 ("Mail" button, orange selected state) |
| Disabled icon dark/light | `#617AAC` / `#E9ECF2` | [B] `msocbvcrCBIconDisabledDark/Light` (97,122,172 / 233,236,242) |

There is no ribbon, backstage or accent-per-app in Office 2003; those roles are N/A.

## Olive (Luna Homestead) — from [B] `InitOliveLunaColors`

| Role | Hex | Source (KnownColors key) |
|---|---|---|
| Command-bar background | `#D1DEAD` | `msocbvcrCBBkgd` (209,222,173) |
| Menu bar gradient | `#D9D9A7` → `#F2F1E4` | `msocbvcrCBGradMainMenuHorzBegin/End` |
| Toolbar gradient | `#FFFFED` → `#B5C48F` | `msocbvcrCBGradVertBegin/End` |
| Floating toolbar title | `#74865E` | `msocbvcrCBTitleBkgd` (116,134,94) |
| Menu background / outer border | `#F4F4EE` / `#758D5E` | `msocbvcrCBMenuBkgd` / `msocbvcrCBMenuBdrOuter` |
| Separator line | `#608058` | `msocbvcrCBSplitterLine` (96,128,88) |
| Hover / pressed / checked fills | `#FFEEC2` / `#FE803E` / `#FFC06F` | identical to Blue — shared across Luna schemes |
| Disabled text | `#8D8D8D` | `msocbvcrCBCtlTextDisabled` |

## Silver (Luna Metallic) — from [B] `InitSilverLunaColors`

| Role | Hex | Source (KnownColors key) |
|---|---|---|
| Command-bar background | `#DBDAE4` | `msocbvcrCBBkgd` (219,218,228) |
| Menu bar gradient | `#D7D7E5` → `#F3F3F7` | `msocbvcrCBGradMainMenuHorzBegin/End` |
| Toolbar gradient | `#F9F9FF` → `#9391B0` | `msocbvcrCBGradVertBegin/End` |
| Floating toolbar title | `#7A7999` | `msocbvcrCBTitleBkgd` (122,121,153) |
| Menu background / outer border | `#FDFAFF` / `#7C7C94` | `msocbvcrCBMenuBkgd` / `msocbvcrCBMenuBdrOuter` |
| Separator line | `#6E6D8F` | `msocbvcrCBSplitterLine` (110,109,143) |
| Hover / pressed / checked fills | `#FFEEC2` / `#FE803E` / `#FFC06F` | identical to Blue |
| Disabled text | `#8D8D8D` | `msocbvcrCBCtlTextDisabled` |

## Open items

1. **Inactive title bar** (all three schemes) — needs a screenshot with an inactive window, or values read from an XP VM (`GetSysColor(COLOR_INACTIVECAPTION)` under each Luna scheme).
2. **Olive/Silver full-window screenshots** — command-bar colours are covered exactly by [B], but title-bar gradients and status bars under the Homestead/Metallic system schemes were not sampled from imagery. Chris can supply XP VM screenshots if pixel confirmation is wanted.
3. `InitRoyaleColors` (Media Center "Royale" scheme) also exists in [B] if a fourth variant is ever wanted.
