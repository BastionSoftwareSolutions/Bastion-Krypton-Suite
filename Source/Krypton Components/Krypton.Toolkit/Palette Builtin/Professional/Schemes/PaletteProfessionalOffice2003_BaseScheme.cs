#region BSD License
/*
 * New (Bastion) file in a work derived from BSD-3-Clause licensed code:
 * © Component Factory Pty Ltd, 2006 - 2016. Then modifications by Peter Wagner (aka Wagnerp),
 * Simon Coghlan (aka Smurf-IV), Giduac, Ahmed Abdelhameed, Lesandro & tobitege et al. 2017 - 2026.
 * © Bastion Software Solutions Ltd 2026. All rights reserved.
 */
#endregion

// =====================================================================================
// Office 2003 Blue (Luna "NormalColor") colour scheme (Bastion Phase 3 fidelity
// pass, §4.3). Fixes the fidelity gap found when spot-verifying the un-gated
// ProfessionalOffice2003 palette against the [A] four-app reference screenshot:
// the palette previously fed the ribbon/QAT/app-button slots from the SYSTEM
// scheme (PaletteProfessionalSystem_BaseScheme), so nothing above the header
// gradient actually looked like Office 2003.
//
// Provenance — every value is tagged:
//   [T] taken from docs\themes\office2003-colours.md ("Blue (Luna NormalColor)"
//       table). Sources: [B] = Microsoft's own ProfessionalColorTable
//       (docs\themes\references\office2003\ProfessionalColorTable-dotnet-winforms.cs,
//       InitBlueLunaColors) — exact msocbvcr* values quoted by KnownColors key;
//       [A] = wikipedia-office2003-screenshot.png (1920×1080, 1:1) pixel samples
//       (caption gradient #0055E5/#026AFE/#0043CF, status/control face #ECE9D8,
//       Excel headers #EFEBDE, field border #7F9DB9 — the latter two coincide with
//       [B] msocbvcrGDHeaderCellBkgd / msocbvcrWPCtlBdr exactly).
//   [D] derived — rule stated inline. Office 2003 has no ribbon: ribbon slots are
//       adapted from the [B] command-bar/menu/task-pane roles. Inactive-window
//       colours are colour-table open item 1 (task-pane inactive title stands in).
//   [N] donor value from PaletteProfessionalSystem_BaseScheme — slot not consumed
//       by the Professional pipeline / no Luna mapping.
//
// NOTE: the Professional palette generates most non-ribbon colours from system
// settings at runtime; this scheme feeds the ribbon/QAT/app-button/gallery slots
// (read via BaseColors) and documents the full Luna value set for the rest.
// =====================================================================================

namespace Krypton.Toolkit;

public sealed class PaletteProfessionalOffice2003_BaseScheme : KryptonColorSchemeBase
{
    public override Color TextLabelControl                 { get; set; } = Color.Black;                   // [T] msocbvcrCBCtlText (0,0,0)
    public override Color TextButtonNormal                 { get; set; } = Color.Black;                   // [T] msocbvcrCBCtlText
    public override Color TextButtonChecked                { get; set; } = Color.Black;                   // [T] msocbvcrCBCtlTextMouseDown (0,0,0)
    public override Color ButtonNormalBorder               { get; set; } = Color.FromArgb(127, 157, 185); // [T] msocbvcrWPCtlBdr (127,157,185; [A] XP field border #7F9DB9)
    public override Color ButtonNormalDefaultBorder        { get; set; } = Color.Black;                   // [T] msocbvcrWPCtlBdrDefault (0,0,0)
    public override Color ButtonNormalBack1                { get; set; } = Color.FromArgb(227, 239, 255); // [T] msocbvcrCBGradVertBegin (227,239,255)
    public override Color ButtonNormalBack2                { get; set; } = Color.FromArgb(227, 239, 255); // [T] toolbar gradient top
    public override Color ButtonNormalDefaultBack1         { get; set; } = Color.FromArgb(227, 239, 255); // [D] toolbar gradient begin
    public override Color ButtonNormalDefaultBack2         { get; set; } = Color.FromArgb(203, 225, 252); // [T] msocbvcrCBGradVertMiddle (203,225,252)
    public override Color ButtonNormalNavigatorBack1       { get; set; } = Color.FromArgb(186, 211, 245); // [T] msocbvcrDocTabBkgd (186,211,245)
    public override Color ButtonNormalNavigatorBack2       { get; set; } = Color.FromArgb(186, 211, 245); // [T] msocbvcrDocTabBkgd
    public override Color PanelClient                      { get; set; } = Color.FromArgb(236, 233, 216); // [T] msocbvcrPlacesBarBkgd (236,233,216) — the Luna 3-D face ([A] status bar #ECE9D8)
    public override Color PanelAlternative                 { get; set; } = Color.FromArgb(221, 236, 254); // [T] msocbvcrWPBkgd (221,236,254) — task pane
    public override Color ControlBorder                    { get; set; } = Color.FromArgb(127, 157, 185); // [T] msocbvcrWPCtlBdr ([A] #7F9DB9)
    public override Color SeparatorHighBorder1             { get; set; } = Color.FromArgb(241, 249, 255); // [T] msocbvcrCBSplitterLineLight (241,249,255)
    public override Color SeparatorHighBorder2             { get; set; } = Color.FromArgb(106, 140, 203); // [T] msocbvcrCBSplitterLine (106,140,203)
    public override Color HeaderPrimaryBack1               { get; set; } = Color.FromArgb(89, 135, 214);  // [T] msocbvcrOLKFolderbarLight (89,135,214)
    public override Color HeaderPrimaryBack2               { get; set; } = Color.FromArgb(0, 53, 145);    // [T] msocbvcrOLKFolderbarDark (0,53,145)
    public override Color HeaderSecondaryBack1             { get; set; } = Color.FromArgb(123, 164, 224); // [T] msocbvcrWPTitleBkgdActive (123,164,224)
    public override Color HeaderSecondaryBack2             { get; set; } = Color.FromArgb(123, 164, 224); // [T] msocbvcrWPTitleBkgdActive
    public override Color HeaderText                       { get; set; } = Color.Black;                   // [T] msocbvcrWPTitleTextActive (0,0,0)
    public override Color StatusStripText                  { get; set; } = Color.Black;                   // [T] msocbvcrCBCtlText
    public override Color ButtonBorder                     { get; set; } = Color.FromArgb(0, 0, 128);     // [T] msocbvcrCBCtlBdrMouseOver (0,0,128)
    public override Color SeparatorLight                   { get; set; } = Color.FromArgb(241, 249, 255); // [T] splitter light side
    public override Color SeparatorDark                    { get; set; } = Color.FromArgb(106, 140, 203); // [T] splitter line
    public override Color GripLight                        { get; set; } = Color.White;                   // [T] msocbvcrCBDragHandleShadow (255,255,255)
    public override Color GripDark                         { get; set; } = Color.FromArgb(39, 65, 118);   // [T] msocbvcrCBDragHandle (39,65,118)
    public override Color ToolStripBack                    { get; set; } = Color.FromArgb(196, 219, 249); // [T] msocbvcrCBBkgd (196,219,249) — command-bar background
    public override Color StatusStripLight                 { get; set; } = Color.FromArgb(236, 233, 216); // [T] Luna 3-D face ([A] status bar #ECE9D8)
    public override Color StatusStripDark                  { get; set; } = Color.FromArgb(236, 233, 216); // [T] Luna 3-D face
    public override Color ImageMargin                      { get; set; } = Color.FromArgb(203, 225, 252); // [T] msocbvcrCBMenuIconBkgd (203,225,252)
    public override Color ToolStripBegin                   { get; set; } = Color.FromArgb(227, 239, 255); // [T] msocbvcrCBGradVertBegin
    public override Color ToolStripMiddle                  { get; set; } = Color.FromArgb(203, 225, 252); // [T] msocbvcrCBGradVertMiddle
    public override Color ToolStripEnd                     { get; set; } = Color.FromArgb(123, 164, 224); // [T] msocbvcrCBGradVertEnd (123,164,224)
    public override Color OverflowBegin                    { get; set; } = Color.FromArgb(127, 177, 250); // [T] msocbvcrCBGradOptionsBegin (127,177,250)
    public override Color OverflowMiddle                   { get; set; } = Color.FromArgb(82, 127, 208);  // [T] msocbvcrCBGradOptionsMiddle (82,127,208)
    public override Color OverflowEnd                      { get; set; } = Color.FromArgb(0, 53, 145);    // [T] msocbvcrCBGradOptionsEnd (0,53,145)
    public override Color ToolStripBorder                  { get; set; } = Color.FromArgb(196, 205, 218); // [T] msocbvcrCBBdrOuterDocked (196,205,218)
    public override Color FormBorderActive                 { get; set; } = Color.FromArgb(0, 85, 229);    // [T] [A] caption core #0055E5 (col scan x=500 modal)
    public override Color FormBorderInactive               { get; set; } = Color.FromArgb(148, 187, 239); // [D] msocbvcrWPTitleBkgdInactive stand-in (open item 1)
    public override Color FormBorderActiveLight            { get; set; } = Color.FromArgb(2, 106, 254);   // [T] [A] caption lower sheen #026AFE
    public override Color FormBorderActiveDark             { get; set; } = Color.FromArgb(0, 67, 207);    // [T] [A] caption bottom edge #0043CF
    public override Color FormBorderInactiveLight          { get; set; } = Color.FromArgb(148, 187, 239); // [D] inactive stand-in (open item 1)
    public override Color FormBorderInactiveDark           { get; set; } = Color.FromArgb(148, 187, 239); // [D] inactive stand-in
    public override Color FormBorderHeaderActive           { get; set; } = Color.FromArgb(0, 85, 229);    // [T] [A] caption core #0055E5
    public override Color FormBorderHeaderInactive         { get; set; } = Color.FromArgb(148, 187, 239); // [D] inactive stand-in
    public override Color FormBorderHeaderActive1          { get; set; } = Color.FromArgb(0, 85, 229);    // [T] [A] caption core #0055E5
    public override Color FormBorderHeaderActive2          { get; set; } = Color.FromArgb(2, 106, 254);   // [T] [A] caption lower sheen #026AFE
    public override Color FormBorderHeaderInactive1        { get; set; } = Color.FromArgb(148, 187, 239); // [D] inactive stand-in (open item 1)
    public override Color FormBorderHeaderInactive2        { get; set; } = Color.FromArgb(148, 187, 239); // [D] inactive stand-in
    public override Color FormHeaderShortActive            { get; set; } = Color.White;                   // [T] msocbvcrCBTitleText (255,255,255; visually confirmed in [A])
    public override Color FormHeaderShortInactive          { get; set; } = Color.White;                   // [D] XP keeps white caption text when inactive (open item 1)
    public override Color FormHeaderLongActive             { get; set; } = Color.White;                   // [T] title text white
    public override Color FormHeaderLongInactive           { get; set; } = Color.White;                   // [D] white (open item 1)
    public override Color FormButtonBorderTrack            { get; set; } = Color.FromArgb(0, 0, 128);     // [T] hover border msocbvcrCBCtlBdrMouseOver
    public override Color FormButtonBack1Track             { get; set; } = Color.FromArgb(255, 238, 194); // [T] hover fill msocbvcrCBCtlBkgdMouseOver (255,238,194)
    public override Color FormButtonBack2Track             { get; set; } = Color.FromArgb(255, 238, 194); // [T] hover fill #FFEEC2
    public override Color FormButtonBorderPressed          { get; set; } = Color.FromArgb(0, 0, 128);     // [T] msocbvcrCBCtlBdrMouseDown
    public override Color FormButtonBack1Pressed           { get; set; } = Color.FromArgb(254, 128, 62);  // [T] pressed fill msocbvcrCBCtlBkgdMouseDown (254,128,62)
    public override Color FormButtonBack2Pressed           { get; set; } = Color.FromArgb(254, 128, 62);  // [T] pressed fill #FE803E
    public override Color TextButtonFormNormal             { get; set; } = Color.White;                   // [T] title text white
    public override Color TextButtonFormTracking           { get; set; } = Color.Black;                   // [T] msocbvcrCBCtlTextMouseOver (0,0,0) on the orange hover fill
    public override Color TextButtonFormPressed            { get; set; } = Color.Black;                   // [T] msocbvcrCBCtlTextMouseDown
    public override Color LinkNotVisitedOverrideControl    { get; set; } = Color.FromArgb(0, 61, 178);    // [T] msocbvcrHyperlink (0,61,178)
    public override Color LinkVisitedOverrideControl       { get; set; } = Color.FromArgb(170, 0, 170);   // [T] msocbvcrHyperlinkFollowed (170,0,170)
    public override Color LinkPressedOverrideControl       { get; set; } = Color.Red;                     // [N]
    public override Color LinkNotVisitedOverridePanel      { get; set; } = Color.FromArgb(0, 61, 178);    // [T] msocbvcrHyperlink
    public override Color LinkVisitedOverridePanel         { get; set; } = Color.FromArgb(170, 0, 170);   // [T] msocbvcrHyperlinkFollowed
    public override Color LinkPressedOverridePanel         { get; set; } = Color.Red;                     // [N]
    public override Color TextLabelPanel                   { get; set; } = Color.Black;                   // [T] msocbvcrCBCtlText
    public override Color RibbonTabTextNormal              { get; set; } = Color.Black;                   // [T] msocbvcrCBCtlText (no ribbon in 2003 — command-bar text)
    public override Color RibbonTabTextChecked             { get; set; } = Color.Black;                   // [T] msocbvcrDocTabTextSelected (0,0,0)
    public override Color RibbonTabSelected1               { get; set; } = Color.FromArgb(0, 45, 150);    // [D] selected tab edge = msocbvcrCBMenuBdrOuter (0,45,150)
    public override Color RibbonTabSelected2               { get; set; } = Color.FromArgb(246, 246, 246); // [D] selected tab fill = msocbvcrCBMenuBkgd (246,246,246) — open-menu surface
    public override Color RibbonTabSelected3               { get; set; } = Color.FromArgb(246, 246, 246); // [D] menu surface
    public override Color RibbonTabSelected4               { get; set; } = Color.FromArgb(246, 246, 246); // [D] menu surface
    public override Color RibbonTabSelected5               { get; set; } = Color.FromArgb(0, 0, 0, 0);    // [N]
    public override Color RibbonTabTracking1               { get; set; } = Color.FromArgb(255, 238, 194); // [T] hover fill #FFEEC2 (shared Luna)
    public override Color RibbonTabTracking2               { get; set; } = Color.FromArgb(255, 255, 222); // [T] msocbvcrCBGradMouseOverBegin (255,255,222)
    public override Color RibbonTabHighlight1              { get; set; } = Color.FromArgb(196, 255, 223, 154); // [D] alpha-196 of gradSelectedBegin (donor pattern)
    public override Color RibbonTabHighlight2              { get; set; } = Color.FromArgb(255, 223, 154); // [T] msocbvcrCBGradSelectedBegin (255,223,154)
    public override Color RibbonTabHighlight3              { get; set; } = Color.FromArgb(255, 166, 76);  // [T] msocbvcrCBGradSelectedEnd (255,166,76)
    public override Color RibbonTabHighlight4              { get; set; } = Color.FromArgb(255, 166, 76);  // [T] gradSelectedEnd
    public override Color RibbonTabHighlight5              { get; set; } = Color.FromArgb(255, 223, 154); // [T] gradSelectedBegin
    public override Color RibbonTabSeparatorColor          { get; set; } = Color.FromArgb(106, 140, 203); // [T] msocbvcrCBSplitterLine
    public override Color RibbonGroupsArea1                { get; set; } = Color.FromArgb(196, 205, 218); // [T] msocbvcrCBBdrOuterDocked — area border
    public override Color RibbonGroupsArea2                { get; set; } = Color.FromArgb(106, 140, 203); // [D] splitter line as inner border
    public override Color RibbonGroupsArea3                { get; set; } = Color.FromArgb(241, 249, 255); // [D] splitter light side
    public override Color RibbonGroupsArea4                { get; set; } = Color.FromArgb(196, 219, 249); // [T] msocbvcrCBBkgd — command-bar background as groups area
    public override Color RibbonGroupsArea5                { get; set; } = Color.FromArgb(196, 219, 249); // [T] msocbvcrCBBkgd
    public override Color RibbonGroupBorder1               { get; set; } = Color.FromArgb(128, 255, 255, 255); // [N]
    public override Color RibbonGroupBorder2               { get; set; } = Color.FromArgb(196, 255, 255, 255); // [N]
    public override Color RibbonGroupTitle1                { get; set; } = Color.FromArgb(123, 164, 224); // [D] msocbvcrWPTitleBkgdActive — pane title
    public override Color RibbonGroupTitle2                { get; set; } = Color.FromArgb(123, 164, 224); // [D] pane title
    public override Color RibbonGroupBorderContext1        { get; set; } = Color.FromArgb(128, 255, 255, 255); // [N]
    public override Color RibbonGroupBorderContext2        { get; set; } = Color.FromArgb(196, 255, 255, 255); // [N]
    public override Color RibbonGroupTitleContext1         { get; set; } = Color.FromArgb(123, 164, 224); // [D] pane title
    public override Color RibbonGroupTitleContext2         { get; set; } = Color.FromArgb(123, 164, 224); // [D] pane title
    public override Color RibbonGroupDialogDark            { get; set; } = Color.FromArgb(104, 0, 0, 0);  // [N] glyph alpha tones
    public override Color RibbonGroupDialogLight           { get; set; } = Color.FromArgb(72, 0, 0, 0);   // [N]
    public override Color RibbonGroupTitleTracking1        { get; set; } = Color.FromArgb(255, 238, 194); // [D] hover fill #FFEEC2
    public override Color RibbonGroupTitleTracking2        { get; set; } = Color.FromArgb(255, 238, 194); // [D] hover fill
    public override Color RibbonMinimizeBarDark            { get; set; } = Color.FromArgb(123, 164, 224); // [D] toolbar gradient end
    public override Color RibbonMinimizeBarLight           { get; set; } = Color.FromArgb(227, 239, 255); // [D] toolbar gradient begin
    public override Color RibbonGroupCollapsedBorder1      { get; set; } = Color.FromArgb(128, 255, 255, 255); // [N]
    public override Color RibbonGroupCollapsedBorder2      { get; set; } = Color.FromArgb(196, 255, 255, 255); // [N]
    public override Color RibbonGroupCollapsedBorder3      { get; set; } = Color.FromArgb(221, 236, 254); // [D] task-pane surface
    public override Color RibbonGroupCollapsedBorder4      { get; set; } = Color.FromArgb(106, 140, 203); // [D] splitter line
    public override Color RibbonGroupCollapsedBack1        { get; set; } = Color.FromArgb(227, 239, 255); // [D] toolbar gradient begin
    public override Color RibbonGroupCollapsedBack2        { get; set; } = Color.FromArgb(203, 225, 252); // [D] toolbar gradient middle
    public override Color RibbonGroupCollapsedBack3        { get; set; } = Color.FromArgb(203, 225, 252); // [D] toolbar gradient middle
    public override Color RibbonGroupCollapsedBack4        { get; set; } = Color.FromArgb(123, 164, 224); // [D] toolbar gradient end
    public override Color RibbonGroupCollapsedBorderT1     { get; set; } = Color.FromArgb(0, 0, 128);     // [D] hover border (tracking)
    public override Color RibbonGroupCollapsedBorderT2     { get; set; } = Color.FromArgb(0, 0, 128);     // [D] hover border
    public override Color RibbonGroupCollapsedBorderT3     { get; set; } = Color.FromArgb(0, 0, 128);     // [D] hover border
    public override Color RibbonGroupCollapsedBorderT4     { get; set; } = Color.FromArgb(0, 0, 128);     // [D] hover border
    public override Color RibbonGroupCollapsedBackT1       { get; set; } = Color.FromArgb(255, 255, 222); // [T] msocbvcrCBGradMouseOverBegin
    public override Color RibbonGroupCollapsedBackT2       { get; set; } = Color.FromArgb(255, 225, 172); // [T] msocbvcrCBGradMouseOverMiddle (255,225,172)
    public override Color RibbonGroupCollapsedBackT3       { get; set; } = Color.FromArgb(255, 225, 172); // [T] hover gradient middle
    public override Color RibbonGroupCollapsedBackT4       { get; set; } = Color.FromArgb(255, 203, 136); // [T] msocbvcrCBGradMouseOverEnd (255,203,136)
    public override Color RibbonGroupFrameBorder1          { get; set; } = Color.FromArgb(127, 157, 185); // [D] msocbvcrWPCtlBdr — pane control border
    public override Color RibbonGroupFrameBorder2          { get; set; } = Color.FromArgb(127, 157, 185); // [D] pane control border
    public override Color RibbonGroupFrameInside1          { get; set; } = Color.FromArgb(221, 236, 254); // [D] msocbvcrWPBkgd — task-pane surface
    public override Color RibbonGroupFrameInside2          { get; set; } = Color.FromArgb(221, 236, 254); // [D] task-pane surface
    public override Color RibbonGroupFrameInside3          { get; set; } = Color.FromArgb(0, 0, 0, 0);    // [N]
    public override Color RibbonGroupFrameInside4          { get; set; } = Color.FromArgb(0, 0, 0, 0);    // [N]
    public override Color RibbonGroupCollapsedText         { get; set; } = Color.Black;                   // [T] msocbvcrCBCtlText
    public override Color RibbonGroupButtonText            { get; set; } = Color.Black;                   // [T] msocbvcrCBCtlText
    public override Color AlternatePressedBack1            { get; set; } = Color.FromArgb(254, 128, 62);  // [T] msocbvcrCBGradMouseDownBegin (254,128,62)
    public override Color AlternatePressedBack2            { get; set; } = Color.FromArgb(255, 177, 109); // [T] msocbvcrCBGradMouseDownMiddle (255,177,109)
    public override Color AlternatePressedBorder1          { get; set; } = Color.FromArgb(0, 0, 128);     // [T] msocbvcrCBCtlBdrMouseDown
    public override Color AlternatePressedBorder2          { get; set; } = Color.FromArgb(0, 0, 128);     // [T] pressed border
    public override Color FormButtonBack1Checked           { get; set; } = Color.FromArgb(255, 192, 111); // [T] checked fill msocbvcrCBCtlBkgdSelected (255,192,111)
    public override Color FormButtonBack2Checked           { get; set; } = Color.FromArgb(255, 195, 116); // [T] msocbvcrCBGradSelectedMiddle (255,195,116)
    public override Color FormButtonBorderCheck            { get; set; } = Color.FromArgb(0, 0, 128);     // [T] msocbvcrCBCtlBdrSelected
    public override Color FormButtonBack1CheckTrack        { get; set; } = Color.FromArgb(254, 128, 62);  // [T] msocbvcrCBCtlBkgdSelectedMouseOver (254,128,62)
    public override Color FormButtonBack2CheckTrack        { get; set; } = Color.FromArgb(254, 128, 62);  // [T] checked-hover fill
    public override Color RibbonQATMini1                   { get; set; } = Color.FromArgb(196, 205, 218); // [D] docked outer border
    public override Color RibbonQATMini2                   { get; set; } = Color.FromArgb(227, 239, 255); // [D] toolbar gradient begin
    public override Color RibbonQATMini3                   { get; set; } = Color.FromArgb(203, 225, 252); // [D] toolbar gradient middle
    public override Color RibbonQATMini4                   { get; set; } = Color.FromArgb(32, 255, 255, 255); // [N]
    public override Color RibbonQATMini5                   { get; set; } = Color.FromArgb(32, 255, 255, 255); // [N]
    public override Color RibbonQATMini1I                  { get; set; } = Color.FromArgb(196, 205, 218); // [D] as active (inactive not captured — open item 1)
    public override Color RibbonQATMini2I                  { get; set; } = Color.FromArgb(227, 239, 255); // [D] as active
    public override Color RibbonQATMini3I                  { get; set; } = Color.FromArgb(203, 225, 252); // [D] as active
    public override Color RibbonQATMini4I                  { get; set; } = Color.FromArgb(32, 255, 255, 255); // [N]
    public override Color RibbonQATMini5I                  { get; set; } = Color.FromArgb(32, 255, 255, 255); // [N]
    public override Color RibbonQATFullbar1                { get; set; } = Color.FromArgb(203, 225, 252); // [D] toolbar gradient middle
    public override Color RibbonQATFullbar2                { get; set; } = Color.FromArgb(123, 164, 224); // [D] toolbar gradient end
    public override Color RibbonQATFullbar3                { get; set; } = Color.FromArgb(196, 205, 218); // [D] docked outer border
    public override Color RibbonQATButtonDark              { get; set; } = Color.FromArgb(39, 65, 118);   // [D] drag-handle tone
    public override Color RibbonQATButtonLight             { get; set; } = Color.FromArgb(241, 249, 255); // [D] splitter light side
    public override Color RibbonQATOverflow1               { get; set; } = Color.FromArgb(203, 225, 252); // [D] toolbar gradient middle
    public override Color RibbonQATOverflow2               { get; set; } = Color.FromArgb(106, 140, 203); // [D] splitter line
    public override Color RibbonGroupSeparatorDark         { get; set; } = Color.FromArgb(106, 140, 203); // [T] msocbvcrCBSplitterLine
    public override Color RibbonGroupSeparatorLight        { get; set; } = Color.FromArgb(241, 249, 255); // [T] msocbvcrCBSplitterLineLight
    public override Color ButtonClusterButtonBack1         { get; set; } = Color.FromArgb(227, 239, 255); // [D] toolbar gradient begin
    public override Color ButtonClusterButtonBack2         { get; set; } = Color.FromArgb(203, 225, 252); // [D] toolbar gradient middle
    public override Color ButtonClusterButtonBorder1       { get; set; } = Color.FromArgb(127, 157, 185); // [D] pane control border
    public override Color ButtonClusterButtonBorder2       { get; set; } = Color.FromArgb(106, 140, 203); // [D] splitter line
    public override Color NavigatorMiniBackColor           { get; set; } = Color.FromArgb(221, 236, 254); // [D] task-pane surface
    public override Color GridListNormal1                  { get; set; } = Color.FromArgb(239, 235, 222); // [T] msocbvcrGDHeaderCellBkgd (239,235,222; [A] Excel headers #EFEBDE)
    public override Color GridListNormal2                  { get; set; } = Color.FromArgb(239, 235, 222); // [T] header cell
    public override Color GridListPressed1                 { get; set; } = Color.FromArgb(255, 223, 154); // [D] gradSelectedBegin
    public override Color GridListPressed2                 { get; set; } = Color.FromArgb(255, 166, 76);  // [D] gradSelectedEnd
    public override Color GridListSelected                 { get; set; } = Color.FromArgb(255, 192, 111); // [T] msocbvcrGDHeaderCellBkgdSelected (255,192,111)
    public override Color GridSheetColNormal1              { get; set; } = Color.FromArgb(239, 235, 222); // [T] header cell ([A] #EFEBDE, border #7E7D68)
    public override Color GridSheetColNormal2              { get; set; } = Color.FromArgb(239, 235, 222); // [T] header cell
    public override Color GridSheetColPressed1             { get; set; } = Color.FromArgb(255, 223, 154); // [D] gradSelectedBegin
    public override Color GridSheetColPressed2             { get; set; } = Color.FromArgb(255, 166, 76);  // [D] gradSelectedEnd
    public override Color GridSheetColSelected1            { get; set; } = Color.FromArgb(255, 192, 111); // [T] header cell selected
    public override Color GridSheetColSelected2            { get; set; } = Color.FromArgb(255, 192, 111); // [T] header cell selected
    public override Color GridSheetRowNormal               { get; set; } = Color.FromArgb(239, 235, 222); // [T] header cell
    public override Color GridSheetRowPressed              { get; set; } = Color.FromArgb(255, 223, 154); // [D] gradSelectedBegin
    public override Color GridSheetRowSelected             { get; set; } = Color.FromArgb(255, 192, 111); // [T] header cell selected
    public override Color GridDataCellBorder               { get; set; } = Color.FromArgb(234, 233, 225); // [T] msocbvcrOLKGridlines (234,233,225)
    public override Color GridDataCellSelected             { get; set; } = Color.FromArgb(255, 192, 111); // [D] checked fill #FFC06F
    public override Color InputControlTextNormal           { get; set; } = Color.Black;                   // [T] msocbvcrCBCtlText
    public override Color InputControlTextDisabled         { get; set; } = Color.FromArgb(141, 141, 141); // [T] msocbvcrCBCtlTextDisabled (141,141,141)
    public override Color InputControlBorderNormal         { get; set; } = Color.FromArgb(127, 157, 185); // [T] msocbvcrWPCtlBdr ([A] XP field border #7F9DB9)
    public override Color InputControlBorderDisabled       { get; set; } = Color.FromArgb(128, 128, 128); // [T] msocbvcrWPCtlBdrDisabled (128,128,128)
    public override Color InputControlBackNormal           { get; set; } = Color.White;                   // [T] window
    public override Color InputControlBackDisabled         { get; set; } = Color.FromArgb(222, 222, 222); // [T] msocbvcrWPCtlBkgdDisabled (222,222,222)
    public override Color InputControlBackInactive         { get; set; } = Color.FromArgb(251, 251, 248); // [T] msocbvcrScrollbarBkgd (251,251,248)
    public override Color InputDropDownNormal1             { get; set; } = Color.Black;                   // [T] msocbvcrCBMenuSplitArrow (0,0,0)
    public override Color InputDropDownNormal2             { get; set; } = Color.Transparent;             // [N]
    public override Color InputDropDownDisabled1           { get; set; } = Color.FromArgb(172, 168, 153); // [T] msocbvcrWPTextDisabled (172,168,153)
    public override Color InputDropDownDisabled2           { get; set; } = Color.Transparent;             // [N]
    public override Color ContextMenuHeadingBack           { get; set; } = Color.FromArgb(227, 239, 255); // [T] msocbvcrCBGradMenuTitleBkgdBegin (227,239,255)
    public override Color ContextMenuHeadingText           { get; set; } = Color.Black;                   // [T] msocbvcrCBMenuCtlText (0,0,0)
    public override Color ContextMenuImageColumn           { get; set; } = Color.FromArgb(203, 225, 252); // [T] msocbvcrCBMenuIconBkgd (203,225,252)
    public override Color AppButtonBack1                   { get; set; } = Color.FromArgb(246, 246, 246); // [D] msocbvcrCBMenuBkgd — app-menu surface
    public override Color AppButtonBack2                   { get; set; } = Color.FromArgb(196, 219, 249); // [D] command-bar background
    public override Color AppButtonBorder                  { get; set; } = Color.FromArgb(0, 45, 150);    // [T] msocbvcrCBMenuBdrOuter (0,45,150)
    public override Color AppButtonOuter1                  { get; set; } = Color.FromArgb(123, 164, 224); // [D] msocbvcrCBGradMenuTitleBkgdEnd (123,164,224)
    public override Color AppButtonOuter2                  { get; set; } = Color.FromArgb(123, 164, 224); // [D] menu title gradient end
    public override Color AppButtonOuter3                  { get; set; } = Color.FromArgb(227, 239, 255); // [D] msocbvcrCBGradMenuTitleBkgdBegin
    public override Color AppButtonInner1                  { get; set; } = Color.FromArgb(241, 249, 255); // [D] splitter light side
    public override Color AppButtonInner2                  { get; set; } = Color.FromArgb(0, 45, 150);    // [D] menu outer border
    public override Color AppButtonMenuDocsBack            { get; set; } = Color.FromArgb(246, 246, 246); // [T] msocbvcrCBMenuBkgd
    public override Color AppButtonMenuDocsText            { get; set; } = Color.Black;                   // [T] msocbvcrCBMenuCtlText
    public override Color SeparatorHighInternalBorder1     { get; set; } = Color.FromArgb(241, 249, 255); // [D] splitter light side
    public override Color SeparatorHighInternalBorder2     { get; set; } = Color.FromArgb(106, 140, 203); // [D] splitter line
    public override Color RibbonGalleryBorder              { get; set; } = Color.FromArgb(127, 157, 185); // [D] pane control border
    public override Color RibbonGalleryBackNormal          { get; set; } = Color.White;                   // [D] window surface
    public override Color RibbonGalleryBackTracking        { get; set; } = Color.FromArgb(255, 238, 194); // [T] hover fill #FFEEC2
    public override Color RibbonGalleryBack1               { get; set; } = Color.FromArgb(227, 239, 255); // [D] toolbar gradient begin
    public override Color RibbonGalleryBack2               { get; set; } = Color.FromArgb(203, 225, 252); // [D] toolbar gradient middle
    public override Color RibbonTabTracking3               { get; set; } = Color.FromArgb(255, 225, 172); // [T] msocbvcrCBGradMouseOverMiddle
    public override Color RibbonTabTracking4               { get; set; } = Color.FromArgb(255, 203, 136); // [T] msocbvcrCBGradMouseOverEnd
    public override Color RibbonGroupBorder3               { get; set; } = Color.FromArgb(106, 140, 203); // [D] splitter line
    public override Color RibbonGroupBorder4               { get; set; } = Color.FromArgb(241, 249, 255); // [D] splitter light side
    public override Color RibbonGroupBorder5               { get; set; } = Color.FromArgb(251, 251, 248); // [D] msocbvcrScrollbarBkgd
    public override Color RibbonGroupTitleText             { get; set; } = Color.FromArgb(152, 0, 0, 0);  // [N] donor alpha-black label tone
    public override Color RibbonDropArrowLight             { get; set; } = Color.FromArgb(241, 249, 255); // [D] splitter light side
    public override Color RibbonDropArrowDark              { get; set; } = Color.FromArgb(39, 65, 118);   // [D] drag-handle tone
    public override Color HeaderDockInactiveBack1          { get; set; } = Color.FromArgb(148, 187, 239); // [D] msocbvcrWPTitleBkgdInactive (148,187,239)
    public override Color HeaderDockInactiveBack2          { get; set; } = Color.FromArgb(148, 187, 239); // [D] pane title inactive
    public override Color ButtonNavigatorBorder            { get; set; } = Color.FromArgb(196, 205, 218); // [D] docked outer border
    public override Color ButtonNavigatorText              { get; set; } = Color.Black;                   // [T] msocbvcrCBCtlText
    public override Color ButtonNavigatorTrack1            { get; set; } = Color.FromArgb(255, 255, 222); // [T] hover gradient begin
    public override Color ButtonNavigatorTrack2            { get; set; } = Color.FromArgb(255, 238, 194); // [T] hover fill #FFEEC2
    public override Color ButtonNavigatorPressed1          { get; set; } = Color.FromArgb(254, 128, 62);  // [T] pressed fill #FE803E
    public override Color ButtonNavigatorPressed2          { get; set; } = Color.FromArgb(255, 177, 109); // [T] pressed gradient middle
    public override Color ButtonNavigatorChecked1          { get; set; } = Color.FromArgb(255, 223, 154); // [T] gradSelectedBegin
    public override Color ButtonNavigatorChecked2          { get; set; } = Color.FromArgb(255, 166, 76);  // [T] gradSelectedEnd
    public override Color ToolTipBottom                    { get; set; } = Color.FromArgb(255, 255, 204); // [T] msocbvcrWPInfoTipBkgd (255,255,204)
    public override Color MenuItemText                     { get; set; } = GlobalStaticValues.EMPTY_COLOR; // [N]
    public override Color MenuMarginGradientStart          { get; set; } = GlobalStaticValues.EMPTY_COLOR; // [N]
    public override Color MenuMarginGradientMiddle         { get; set; } = GlobalStaticValues.EMPTY_COLOR; // [N]
    public override Color MenuMarginGradientEnd            { get; set; } = GlobalStaticValues.EMPTY_COLOR; // [N]
    public override Color DisabledMenuItemText             { get; set; } = GlobalStaticValues.EMPTY_COLOR; // [N]
    public override Color MenuStripText                    { get; set; } = GlobalStaticValues.EMPTY_COLOR; // [N]
    public override Color TrackBarTickMarks                { get; set; } = GlobalStaticValues.EMPTY_COLOR; // [N]
    public override Color TrackBarTopTrack                 { get; set; } = GlobalStaticValues.EMPTY_COLOR; // [N]
    public override Color TrackBarBottomTrack              { get; set; } = GlobalStaticValues.EMPTY_COLOR; // [N]
    public override Color TrackBarFillTrack                { get; set; } = GlobalStaticValues.EMPTY_COLOR; // [N]
    public override Color TrackBarOutsidePosition          { get; set; } = GlobalStaticValues.EMPTY_COLOR; // [N]
    public override Color TrackBarBorderPosition           { get; set; } = GlobalStaticValues.EMPTY_COLOR; // [N]
}
