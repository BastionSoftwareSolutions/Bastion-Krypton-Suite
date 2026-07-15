#region BSD License
/*
 * New (Bastion) file in a work derived from BSD-3-Clause licensed code:
 * © Component Factory Pty Ltd, 2006 - 2016. Then modifications by Peter Wagner (aka Wagnerp),
 * Simon Coghlan (aka Smurf-IV), Giduac, Ahmed Abdelhameed, Lesandro & tobitege et al. 2017 - 2026.
 * © Bastion Software Solutions Ltd 2026. All rights reserved.
 */
#endregion

// =====================================================================================
// Office 2021/2024 Black colour scheme (Bastion Phase 3 fidelity pass, spec §4.3).
//
// Provenance — every value is tagged:
//   [T] taken from docs\themes\office2021-colours.md ("Black variant" table; source
//       [K] powerpoint-black.jpg, reference images under
//       docs\themes\references\office2021\).
//       Key values: title bar / tab row #0A0A0A (10,10,10) — [K] rects 250,8 /
//       300,70 uniform; tab text #FFFFFF; toolbar strip (QAT/secondary bar)
//       #1F1F1F (31,31,31) — [K] rect 260,102 uniform.
//   [D] derived — rule stated inline. THE RIBBON IS COLLAPSED IN THE OFFICIAL CROP
//       (colour-table open item 1, expected #1F1F1F–#262626): the expanded-ribbon
//       interior is derived from the 2019 Black donor scheme by the rule "surface
//       tones −23/channel" — the offset between the 2021 Black toolbar strip
//       #1F1F1F [T] (the table's expected ribbon-card family) and the 2019 Black
//       ribbon #363636. Ribbon card #1F1F1F, control well #272727, separators
//       #424242, side pane #0E0E0E, hover step = strip tone #1F1F1F. Text tones
//       carried unchanged from the donor (#DADADA control text, #B4B4B4
//       secondary). ALL such slots are flagged for replacement from Chris's live
//       ribbon-pinned screenshots.
//   [N] donor value from PaletteOffice2019Black_BaseScheme — era-neutral dark slot
//       with no 2021-specific evidence.
// =====================================================================================

namespace Krypton.Toolkit;

public sealed class PaletteOffice2021Black_BaseScheme : KryptonColorSchemeBase
{
    public override Color TextLabelControl                 { get; set; } = Color.FromArgb(218, 218, 218); // [D] control text #DADADA carried from 2019 Black donor (open item 1)
    public override Color TextButtonNormal                 { get; set; } = Color.FromArgb(218, 218, 218); // [D] control text #DADADA (donor)
    public override Color TextButtonChecked                { get; set; } = Color.White;                   // [T] selected/checked text #FFFFFF
    public override Color ButtonNormalBorder               { get; set; } = Color.FromArgb(66, 66, 66);    // [D] separators — donor #595959 −23/channel = #424242
    public override Color ButtonNormalDefaultBorder        { get; set; } = Color.FromArgb(66, 66, 66);    // [D] #424242
    public override Color ButtonNormalBack1                { get; set; } = Color.FromArgb(39, 39, 39);    // [D] control well — donor #3E3E3E −23 = #272727
    public override Color ButtonNormalBack2                { get; set; } = Color.FromArgb(39, 39, 39);    // [D] #272727
    public override Color ButtonNormalDefaultBack1         { get; set; } = Color.FromArgb(51, 51, 51);    // [D] well +12 emphasis step (donor rule)
    public override Color ButtonNormalDefaultBack2         { get; set; } = Color.FromArgb(51, 51, 51);    // [D] #333333
    public override Color ButtonNormalNavigatorBack1       { get; set; } = Color.FromArgb(20, 20, 20);    // [N] donor −12 (dark navigator well)
    public override Color ButtonNormalNavigatorBack2       { get; set; } = Color.FromArgb(20, 20, 20);    // [N]
    public override Color PanelClient                      { get; set; } = Color.FromArgb(31, 31, 31);    // [D] ribbon card #1F1F1F = toolbar strip [T] (expanded ribbon not in crop — open item 1)
    public override Color PanelAlternative                 { get; set; } = Color.FromArgb(14, 14, 14);    // [D] side pane — donor #252525 −23 = #0E0E0E
    public override Color ControlBorder                    { get; set; } = Color.FromArgb(66, 66, 66);    // [D] separators #424242 (donor −23)
    public override Color SeparatorHighBorder1             { get; set; } = Color.FromArgb(172, 172, 172); // [N]
    public override Color SeparatorHighBorder2             { get; set; } = Color.FromArgb(111, 111, 111); // [N]
    public override Color HeaderPrimaryBack1               { get; set; } = Color.FromArgb(39, 39, 39);    // [D] control well #272727
    public override Color HeaderPrimaryBack2               { get; set; } = Color.FromArgb(39, 39, 39);    // [D] control well #272727
    public override Color HeaderSecondaryBack1             { get; set; } = Color.FromArgb(31, 31, 31);    // [D] ribbon #1F1F1F
    public override Color HeaderSecondaryBack2             { get; set; } = Color.FromArgb(31, 31, 31);    // [D] ribbon #1F1F1F
    public override Color HeaderText                       { get; set; } = Color.FromArgb(218, 218, 218); // [D] control text #DADADA (donor)
    public override Color StatusStripText                  { get; set; } = Color.FromArgb(180, 180, 180); // [D] secondary text #B4B4B4 (donor; status bar not in crop)
    public override Color ButtonBorder                     { get; set; } = Color.FromArgb(236, 199, 87);  // [N] hover border — hover/pressed fills are colour-table open item 3
    public override Color SeparatorLight                   { get; set; } = Color.FromArgb(66, 66, 66);    // [D] separators #424242
    public override Color SeparatorDark                    { get; set; } = Color.Black;                   // [N]
    public override Color GripLight                        { get; set; } = Color.FromArgb(66, 66, 66);    // [D] separators #424242
    public override Color GripDark                         { get; set; } = Color.FromArgb(10, 10, 10);    // [N] chrome tone
    public override Color ToolStripBack                    { get; set; } = Color.FromArgb(31, 31, 31);    // [T] toolbar strip #1F1F1F ([K] rect 260,102)
    public override Color StatusStripLight                 { get; set; } = Color.FromArgb(10, 10, 10);    // [D] chrome #0A0A0A (status bar not in crop)
    public override Color StatusStripDark                  { get; set; } = Color.FromArgb(10, 10, 10);    // [D] chrome #0A0A0A
    public override Color ImageMargin                      { get; set; } = Color.White;                   // [N]
    public override Color ToolStripBegin                   { get; set; } = Color.FromArgb(31, 31, 31);    // [T] toolbar strip #1F1F1F
    public override Color ToolStripMiddle                  { get; set; } = Color.FromArgb(31, 31, 31);    // [T] toolbar strip #1F1F1F
    public override Color ToolStripEnd                     { get; set; } = Color.FromArgb(31, 31, 31);    // [T] toolbar strip #1F1F1F
    public override Color OverflowBegin                    { get; set; } = Color.FromArgb(14, 14, 14);    // [D] side-pane tone #0E0E0E for overflow chrome
    public override Color OverflowMiddle                   { get; set; } = Color.FromArgb(14, 14, 14);    // [D] #0E0E0E
    public override Color OverflowEnd                      { get; set; } = Color.FromArgb(14, 14, 14);    // [D] #0E0E0E
    public override Color ToolStripBorder                  { get; set; } = Color.FromArgb(66, 66, 66);    // [D] separators #424242
    public override Color FormBorderActive                 { get; set; } = Color.FromArgb(10, 10, 10);    // [T] title bar #0A0A0A — active frame
    public override Color FormBorderInactive               { get; set; } = Color.FromArgb(119, 119, 119); // [N] inactive — open item 3
    public override Color FormBorderActiveLight            { get; set; } = Color.FromArgb(10, 10, 10);    // [T] #0A0A0A (flat frame)
    public override Color FormBorderActiveDark             { get; set; } = Color.FromArgb(10, 10, 10);    // [T] #0A0A0A (flat frame)
    public override Color FormBorderInactiveLight          { get; set; } = Color.FromArgb(158, 158, 158); // [N] inactive — open item 3
    public override Color FormBorderInactiveDark           { get; set; } = Color.FromArgb(158, 158, 158); // [N] inactive — open item 3
    public override Color FormBorderHeaderActive           { get; set; } = Color.FromArgb(10, 10, 10);    // [T] #0A0A0A — caption merges into tab row
    public override Color FormBorderHeaderInactive         { get; set; } = Color.FromArgb(154, 154, 154); // [N] inactive — open item 3
    public override Color FormBorderHeaderActive1          { get; set; } = Color.FromArgb(10, 10, 10);    // [T] title bar #0A0A0A ([K] rect 300,8 — 100% uniform)
    public override Color FormBorderHeaderActive2          { get; set; } = Color.FromArgb(10, 10, 10);    // [T] title bar #0A0A0A
    public override Color FormBorderHeaderInactive1        { get; set; } = Color.FromArgb(158, 158, 158); // [N] inactive — open item 3
    public override Color FormBorderHeaderInactive2        { get; set; } = Color.FromArgb(158, 158, 158); // [N] inactive — open item 3
    public override Color FormHeaderShortActive            { get; set; } = Color.White;                   // [T] chrome text white ([K] title text "Madison - PowerPoint")
    public override Color FormHeaderShortInactive          { get; set; } = Color.FromArgb(170, 170, 170); // [D] inactive dimmed toward #AAAAAA (open item 3)
    public override Color FormHeaderLongActive             { get; set; } = Color.White;                   // [T] chrome text white
    public override Color FormHeaderLongInactive           { get; set; } = Color.FromArgb(170, 170, 170); // [D] inactive dimmed
    public override Color FormButtonBorderTrack            { get; set; } = Color.FromArgb(31, 31, 31);    // [D] caption hover = strip tone #1F1F1F (open item 1)
    public override Color FormButtonBack1Track             { get; set; } = Color.FromArgb(31, 31, 31);    // [D] #1F1F1F
    public override Color FormButtonBack2Track             { get; set; } = Color.FromArgb(31, 31, 31);    // [D] #1F1F1F
    public override Color FormButtonBorderPressed          { get; set; } = Color.FromArgb(39, 39, 39);    // [D] pressed = control-well step #272727
    public override Color FormButtonBack1Pressed           { get; set; } = Color.FromArgb(39, 39, 39);    // [D] #272727
    public override Color FormButtonBack2Pressed           { get; set; } = Color.FromArgb(39, 39, 39);    // [D] #272727
    public override Color TextButtonFormNormal             { get; set; } = Color.White;                   // [T] tab/chrome text #FFFFFF
    public override Color TextButtonFormTracking           { get; set; } = Color.White;                   // [N]
    public override Color TextButtonFormPressed            { get; set; } = Color.White;                   // [N]
    public override Color LinkNotVisitedOverrideControl    { get; set; } = Color.Blue;                    // [N]
    public override Color LinkVisitedOverrideControl       { get; set; } = Color.Purple;                  // [N]
    public override Color LinkPressedOverrideControl       { get; set; } = Color.Red;                     // [N]
    public override Color LinkNotVisitedOverridePanel      { get; set; } = Color.FromArgb(180, 210, 255); // [N]
    public override Color LinkVisitedOverridePanel         { get; set; } = Color.Violet;                  // [N]
    public override Color LinkPressedOverridePanel         { get; set; } = Color.FromArgb(255, 90, 90);   // [N]
    public override Color TextLabelPanel                   { get; set; } = Color.FromArgb(218, 218, 218); // [D] control text #DADADA on dark panels (donor)
    public override Color RibbonTabTextNormal              { get; set; } = Color.White;                   // [T] tab text #FFFFFF ([K] rect 300,70 secondary population)
    public override Color RibbonTabTextChecked             { get; set; } = Color.White;                   // [T] selected tab text #FFFFFF
    public override Color RibbonTabSelected1               { get; set; } = Color.FromArgb(31, 31, 31);    // [D] selected tab merges into the #1F1F1F ribbon card (open item 1)
    public override Color RibbonTabSelected2               { get; set; } = Color.FromArgb(31, 31, 31);    // [D] #1F1F1F
    public override Color RibbonTabSelected3               { get; set; } = Color.FromArgb(31, 31, 31);    // [D] #1F1F1F
    public override Color RibbonTabSelected4               { get; set; } = Color.FromArgb(31, 31, 31);    // [D] #1F1F1F
    public override Color RibbonTabSelected5               { get; set; } = Color.FromArgb(31, 31, 31);    // [D] #1F1F1F
    public override Color RibbonTabTracking1               { get; set; } = Color.FromArgb(31, 31, 31);    // [D] tab hover = strip tone #1F1F1F (open item 1)
    public override Color RibbonTabTracking2               { get; set; } = Color.FromArgb(31, 31, 31);    // [D] #1F1F1F
    public override Color RibbonTabHighlight1              { get; set; } = Color.FromArgb(31, 31, 31);    // [D] mirrors RibbonTabSelected1
    public override Color RibbonTabHighlight2              { get; set; } = Color.FromArgb(31, 31, 31);    // [D] mirrors selected fill
    public override Color RibbonTabHighlight3              { get; set; } = Color.FromArgb(31, 31, 31);    // [D] mirrors selected fill
    public override Color RibbonTabHighlight4              { get; set; } = Color.FromArgb(31, 31, 31);    // [D] mirrors selected fill
    public override Color RibbonTabHighlight5              { get; set; } = Color.FromArgb(31, 31, 31);    // [D] mirrors selected fill
    public override Color RibbonTabSeparatorColor          { get; set; } = Color.FromArgb(66, 66, 66);    // [D] separators #424242
    public override Color RibbonGroupsArea1                { get; set; } = Color.FromArgb(31, 31, 31);    // [D] flat with ribbon (donor keeps Area1 ≈ body)
    public override Color RibbonGroupsArea2                { get; set; } = Color.FromArgb(48, 48, 48);    // [D] body +17/channel (donor offset)
    public override Color RibbonGroupsArea3                { get; set; } = Color.FromArgb(52, 52, 52);    // [D] body +21/channel (donor offset)
    public override Color RibbonGroupsArea4                { get; set; } = Color.FromArgb(31, 31, 31);    // [D] ribbon card #1F1F1F = toolbar strip [T] (open item 1, expected #1F1F1F–#262626)
    public override Color RibbonGroupsArea5                { get; set; } = Color.FromArgb(31, 31, 31);    // [D] ribbon card #1F1F1F
    public override Color RibbonGroupBorder1               { get; set; } = GlobalStaticValues.EMPTY_COLOR; // [N]
    public override Color RibbonGroupBorder2               { get; set; } = GlobalStaticValues.EMPTY_COLOR; // [N]
    public override Color RibbonGroupTitle1                { get; set; } = GlobalStaticValues.EMPTY_COLOR; // [N]
    public override Color RibbonGroupTitle2                { get; set; } = GlobalStaticValues.EMPTY_COLOR; // [N]
    public override Color RibbonGroupBorderContext1        { get; set; } = GlobalStaticValues.EMPTY_COLOR; // [N]
    public override Color RibbonGroupBorderContext2        { get; set; } = GlobalStaticValues.EMPTY_COLOR; // [N]
    public override Color RibbonGroupTitleContext1         { get; set; } = GlobalStaticValues.EMPTY_COLOR; // [N]
    public override Color RibbonGroupTitleContext2         { get; set; } = GlobalStaticValues.EMPTY_COLOR; // [N]
    public override Color RibbonGroupDialogDark            { get; set; } = Color.FromArgb(237, 237, 237); // [N]
    public override Color RibbonGroupDialogLight           { get; set; } = Color.FromArgb(123, 125, 125); // [N]
    public override Color RibbonGroupTitleTracking1        { get; set; } = GlobalStaticValues.EMPTY_COLOR; // [N]
    public override Color RibbonGroupTitleTracking2        { get; set; } = GlobalStaticValues.EMPTY_COLOR; // [N]
    public override Color RibbonMinimizeBarDark            { get; set; } = Color.FromArgb(10, 10, 10);    // [D] chrome #0A0A0A
    public override Color RibbonMinimizeBarLight           { get; set; } = Color.FromArgb(31, 31, 31);    // [D] ribbon #1F1F1F
    public override Color RibbonGroupCollapsedBorder1      { get; set; } = GlobalStaticValues.EMPTY_COLOR; // [N]
    public override Color RibbonGroupCollapsedBorder2      { get; set; } = GlobalStaticValues.EMPTY_COLOR; // [N]
    public override Color RibbonGroupCollapsedBorder3      { get; set; } = GlobalStaticValues.EMPTY_COLOR; // [N]
    public override Color RibbonGroupCollapsedBorder4      { get; set; } = GlobalStaticValues.EMPTY_COLOR; // [N]
    public override Color RibbonGroupCollapsedBack1        { get; set; } = GlobalStaticValues.EMPTY_COLOR; // [N]
    public override Color RibbonGroupCollapsedBack2        { get; set; } = GlobalStaticValues.EMPTY_COLOR; // [N]
    public override Color RibbonGroupCollapsedBack3        { get; set; } = GlobalStaticValues.EMPTY_COLOR; // [N]
    public override Color RibbonGroupCollapsedBack4        { get; set; } = GlobalStaticValues.EMPTY_COLOR; // [N]
    public override Color RibbonGroupCollapsedBorderT1     { get; set; } = GlobalStaticValues.EMPTY_COLOR; // [N]
    public override Color RibbonGroupCollapsedBorderT2     { get; set; } = GlobalStaticValues.EMPTY_COLOR; // [N]
    public override Color RibbonGroupCollapsedBorderT3     { get; set; } = GlobalStaticValues.EMPTY_COLOR; // [N]
    public override Color RibbonGroupCollapsedBorderT4     { get; set; } = GlobalStaticValues.EMPTY_COLOR; // [N]
    public override Color RibbonGroupCollapsedBackT1       { get; set; } = GlobalStaticValues.EMPTY_COLOR; // [N]
    public override Color RibbonGroupCollapsedBackT2       { get; set; } = GlobalStaticValues.EMPTY_COLOR; // [N]
    public override Color RibbonGroupCollapsedBackT3       { get; set; } = GlobalStaticValues.EMPTY_COLOR; // [N]
    public override Color RibbonGroupCollapsedBackT4       { get; set; } = GlobalStaticValues.EMPTY_COLOR; // [N]
    public override Color RibbonGroupFrameBorder1          { get; set; } = Color.FromArgb(66, 66, 66);    // [D] separators #424242
    public override Color RibbonGroupFrameBorder2          { get; set; } = Color.FromArgb(66, 66, 66);    // [D] separators #424242
    public override Color RibbonGroupFrameInside1          { get; set; } = Color.FromArgb(39, 39, 39);    // [D] control well #272727
    public override Color RibbonGroupFrameInside2          { get; set; } = Color.FromArgb(39, 39, 39);    // [D] control well #272727
    public override Color RibbonGroupFrameInside3          { get; set; } = GlobalStaticValues.EMPTY_COLOR; // [N]
    public override Color RibbonGroupFrameInside4          { get; set; } = GlobalStaticValues.EMPTY_COLOR; // [N]
    public override Color RibbonGroupCollapsedText         { get; set; } = Color.FromArgb(218, 218, 218); // [D] control text #DADADA (donor)
    public override Color RibbonGroupButtonText            { get; set; } = GlobalStaticValues.EMPTY_COLOR; // [N] missing value upstream
    public override Color AlternatePressedBack1            { get; set; } = Color.FromArgb(158, 163, 172); // [N]
    public override Color AlternatePressedBack2            { get; set; } = Color.FromArgb(212, 215, 216); // [N]
    public override Color AlternatePressedBorder1          { get; set; } = Color.FromArgb(124, 125, 125); // [N]
    public override Color AlternatePressedBorder2          { get; set; } = Color.FromArgb(186, 186, 186); // [N]
    public override Color FormButtonBack1Checked           { get; set; } = Color.FromArgb(31, 31, 31);    // [D] strip step #1F1F1F
    public override Color FormButtonBack2Checked           { get; set; } = Color.FromArgb(31, 31, 31);    // [D] #1F1F1F
    public override Color FormButtonBorderCheck            { get; set; } = Color.FromArgb(39, 39, 39);    // [D] control-well step #272727
    public override Color FormButtonBack1CheckTrack        { get; set; } = Color.FromArgb(39, 39, 39);    // [D] #272727
    public override Color FormButtonBack2CheckTrack        { get; set; } = Color.FromArgb(39, 39, 39);    // [D] #272727
    public override Color RibbonQATMini1                   { get; set; } = Color.FromArgb(10, 10, 10);    // [D] QAT minibar sits on the #0A0A0A title bar
    public override Color RibbonQATMini2                   { get; set; } = Color.FromArgb(10, 10, 10);    // [D] chrome #0A0A0A
    public override Color RibbonQATMini3                   { get; set; } = Color.FromArgb(10, 10, 10);    // [D] chrome #0A0A0A
    public override Color RibbonQATMini4                   { get; set; } = Color.FromArgb(12, Color.White); // [N]
    public override Color RibbonQATMini5                   { get; set; } = Color.FromArgb(14, Color.White); // [N]
    public override Color RibbonQATMini1I                  { get; set; } = Color.FromArgb(100, 100, 100); // [N] inactive — open item 3
    public override Color RibbonQATMini2I                  { get; set; } = Color.FromArgb(170, 170, 170); // [N] inactive — open item 3
    public override Color RibbonQATMini3I                  { get; set; } = Color.FromArgb(140, 140, 140); // [N] inactive — open item 3
    public override Color RibbonQATMini4I                  { get; set; } = Color.FromArgb(12, Color.White); // [N]
    public override Color RibbonQATMini5I                  { get; set; } = Color.FromArgb(14, Color.White); // [N]
    public override Color RibbonQATFullbar1                { get; set; } = Color.FromArgb(31, 31, 31);    // [T] toolbar strip #1F1F1F
    public override Color RibbonQATFullbar2                { get; set; } = Color.FromArgb(31, 31, 31);    // [T] toolbar strip #1F1F1F
    public override Color RibbonQATFullbar3                { get; set; } = Color.FromArgb(14, 14, 14);    // [D] side-pane tone #0E0E0E
    public override Color RibbonQATButtonDark              { get; set; } = Color.FromArgb(27, 27, 27);    // [N]
    public override Color RibbonQATButtonLight             { get; set; } = Color.FromArgb(117, 117, 117); // [N]
    public override Color RibbonQATOverflow1               { get; set; } = Color.FromArgb(138, 138, 138); // [N]
    public override Color RibbonQATOverflow2               { get; set; } = Color.FromArgb(45, 45, 45);    // [N]
    public override Color RibbonGroupSeparatorDark         { get; set; } = Color.FromArgb(66, 66, 66);    // [D] separators #424242
    public override Color RibbonGroupSeparatorLight        { get; set; } = GlobalStaticValues.EMPTY_COLOR; // [N]
    public override Color ButtonClusterButtonBack1         { get; set; } = Color.FromArgb(210, 217, 219); // [N]
    public override Color ButtonClusterButtonBack2         { get; set; } = Color.FromArgb(214, 222, 223); // [N]
    public override Color ButtonClusterButtonBorder1       { get; set; } = Color.FromArgb(179, 188, 191); // [N]
    public override Color ButtonClusterButtonBorder2       { get; set; } = Color.FromArgb(145, 156, 159); // [N]
    public override Color NavigatorMiniBackColor           { get; set; } = Color.FromArgb(235, 235, 235); // [N]
    public override Color GridListNormal1                  { get; set; } = Color.FromArgb(205, 205, 205); // [N]
    public override Color GridListNormal2                  { get; set; } = Color.FromArgb(166, 166, 166); // [N]
    public override Color GridListPressed1                 { get; set; } = Color.FromArgb(166, 166, 166); // [N]
    public override Color GridListPressed2                 { get; set; } = Color.FromArgb(205, 205, 205); // [N]
    public override Color GridListSelected                 { get; set; } = Color.FromArgb(150, 150, 150); // [N]
    public override Color GridSheetColNormal1              { get; set; } = Color.FromArgb(220, 220, 220); // [N]
    public override Color GridSheetColNormal2              { get; set; } = Color.FromArgb(200, 200, 200); // [N]
    public override Color GridSheetColPressed1             { get; set; } = Color.FromArgb(255, 223, 107); // [N]
    public override Color GridSheetColPressed2             { get; set; } = Color.FromArgb(255, 252, 230); // [N]
    public override Color GridSheetColSelected1            { get; set; } = Color.FromArgb(255, 211, 89);  // [N]
    public override Color GridSheetColSelected2            { get; set; } = Color.FromArgb(255, 239, 113); // [N]
    public override Color GridSheetRowNormal               { get; set; } = Color.FromArgb(205, 205, 205); // [N]
    public override Color GridSheetRowPressed              { get; set; } = Color.FromArgb(255, 223, 107); // [N]
    public override Color GridSheetRowSelected             { get; set; } = Color.FromArgb(245, 210, 87);  // [N]
    public override Color GridDataCellBorder               { get; set; } = Color.FromArgb(218, 220, 221); // [N] content canvas stays light
    public override Color GridDataCellSelected             { get; set; } = Color.FromArgb(183, 219, 255); // [N]
    public override Color InputControlTextNormal           { get; set; } = Color.FromArgb(218, 218, 218); // [D] control text #DADADA (donor — dark inputs)
    public override Color InputControlTextDisabled         { get; set; } = Color.FromArgb(128, 128, 128); // [N]
    public override Color InputControlBorderNormal         { get; set; } = Color.FromArgb(66, 66, 66);    // [D] separators #424242
    public override Color InputControlBorderDisabled       { get; set; } = Color.FromArgb(47, 47, 47);    // [D] border dimmed one step (donor #464646 −23)
    public override Color InputControlBackNormal           { get; set; } = Color.FromArgb(39, 39, 39);    // [D] control well #272727
    public override Color InputControlBackDisabled         { get; set; } = Color.FromArgb(25, 25, 25);    // [D] well dimmed toward ribbon tone (donor −23)
    public override Color InputControlBackInactive         { get; set; } = Color.FromArgb(31, 31, 31);    // [D] ribbon #1F1F1F
    public override Color InputDropDownNormal1             { get; set; } = Color.FromArgb(218, 218, 218); // [D] glyph = control text #DADADA
    public override Color InputDropDownNormal2             { get; set; } = Color.Transparent;             // [N]
    public override Color InputDropDownDisabled1           { get; set; } = Color.FromArgb(128, 128, 128); // [D] disabled glyph matches disabled text
    public override Color InputDropDownDisabled2           { get; set; } = Color.Transparent;             // [N]
    public override Color ContextMenuHeadingBack           { get; set; } = Color.FromArgb(240, 242, 245); // [N] context menu — colour-table open item 3
    public override Color ContextMenuHeadingText           { get; set; } = Color.Black;                   // [N] context menu — open item 3
    public override Color ContextMenuImageColumn           { get; set; } = Color.White;                   // [N] context menu — open item 3
    public override Color AppButtonBack1                   { get; set; } = Color.FromArgb(47, 47, 47);    // [N] backstage — donor −23 (open item 3)
    public override Color AppButtonBack2                   { get; set; } = Color.FromArgb(47, 47, 47);    // [N] backstage — open item 3
    public override Color AppButtonBorder                  { get; set; } = Color.FromArgb(27, 27, 27);    // [N] backstage — open item 3
    public override Color AppButtonOuter1                  { get; set; } = Color.FromArgb(47, 47, 47);    // [N] backstage — open item 3
    public override Color AppButtonOuter2                  { get; set; } = Color.FromArgb(47, 47, 47);    // [N] backstage — open item 3
    public override Color AppButtonOuter3                  { get; set; } = Color.FromArgb(47, 47, 47);    // [N] backstage — open item 3
    public override Color AppButtonInner1                  { get; set; } = GlobalStaticValues.EMPTY_COLOR; // [N]
    public override Color AppButtonInner2                  { get; set; } = Color.FromArgb(27, 27, 27);    // [N]
    public override Color AppButtonMenuDocsBack            { get; set; } = Color.White;                   // [N]
    public override Color AppButtonMenuDocsText            { get; set; } = Color.Black;                   // [N]
    public override Color SeparatorHighInternalBorder1     { get; set; } = Color.FromArgb(172, 172, 172); // [N]
    public override Color SeparatorHighInternalBorder2     { get; set; } = Color.FromArgb(111, 111, 111); // [N]
    public override Color RibbonGalleryBorder              { get; set; } = Color.FromArgb(66, 66, 66);    // [D] separators #424242
    public override Color RibbonGalleryBackNormal          { get; set; } = Color.FromArgb(39, 39, 39);    // [D] control well #272727
    public override Color RibbonGalleryBackTracking        { get; set; } = Color.FromArgb(51, 51, 51);    // [D] well +12 hover step
    public override Color RibbonGalleryBack1               { get; set; } = Color.FromArgb(39, 39, 39);    // [D] control well #272727
    public override Color RibbonGalleryBack2               { get; set; } = Color.FromArgb(31, 31, 31);    // [D] ribbon #1F1F1F
    public override Color RibbonTabTracking3               { get; set; } = Color.FromArgb(31, 31, 31);    // [D] strip tone #1F1F1F (open item 1)
    public override Color RibbonTabTracking4               { get; set; } = GlobalStaticValues.EMPTY_COLOR; // [N]
    public override Color RibbonGroupBorder3               { get; set; } = Color.FromArgb(14, 14, 14);    // [D] side-pane tone #0E0E0E (donor uses darker-than-body)
    public override Color RibbonGroupBorder4               { get; set; } = Color.FromArgb(14, 14, 14);    // [D] #0E0E0E
    public override Color RibbonGroupBorder5               { get; set; } = GlobalStaticValues.EMPTY_COLOR; // [N]
    public override Color RibbonGroupTitleText             { get; set; } = Color.FromArgb(180, 180, 180); // [D] group labels dimmer than control text — #B4B4B4 (donor)
    public override Color RibbonDropArrowLight             { get; set; } = Color.FromArgb(157, 157, 160); // [N]
    public override Color RibbonDropArrowDark              { get; set; } = Color.FromArgb(237, 237, 237); // [N]
    public override Color HeaderDockInactiveBack1          { get; set; } = Color.FromArgb(137, 137, 137); // [N]
    public override Color HeaderDockInactiveBack2          { get; set; } = Color.FromArgb(125, 125, 125); // [N]
    public override Color ButtonNavigatorBorder            { get; set; } = Color.FromArgb(46, 46, 46);    // [N]
    public override Color ButtonNavigatorText              { get; set; } = Color.White;                   // [N]
    public override Color ButtonNavigatorTrack1            { get; set; } = Color.FromArgb(76, 76, 76);    // [N]
    public override Color ButtonNavigatorTrack2            { get; set; } = Color.FromArgb(147, 147, 143); // [N]
    public override Color ButtonNavigatorPressed1          { get; set; } = Color.FromArgb(66, 66, 66);    // [N]
    public override Color ButtonNavigatorPressed2          { get; set; } = Color.FromArgb(148, 148, 143); // [N]
    public override Color ButtonNavigatorChecked1          { get; set; } = Color.FromArgb(91, 91, 91);    // [N]
    public override Color ButtonNavigatorChecked2          { get; set; } = Color.FromArgb(73, 73, 73);    // [N]
    public override Color ToolTipBottom                    { get; set; } = Color.FromArgb(201, 201, 201); // [N]
    public override Color MenuItemText                     { get; set; } = GlobalStaticValues.EMPTY_COLOR; // [N]
    public override Color MenuMarginGradientStart          { get; set; } = GlobalStaticValues.EMPTY_COLOR; // [N]
    public override Color MenuMarginGradientMiddle         { get; set; } = GlobalStaticValues.EMPTY_COLOR; // [N]
    public override Color MenuMarginGradientEnd            { get; set; } = GlobalStaticValues.EMPTY_COLOR; // [N]
    public override Color DisabledMenuItemText             { get; set; } = GlobalStaticValues.EMPTY_COLOR; // [N]
    public override Color MenuStripText                    { get; set; } = GlobalStaticValues.EMPTY_COLOR; // [N]
    public override Color TrackBarTickMarks                { get; set; } = Color.FromArgb(17, 17, 17);    // [N]
    public override Color TrackBarTopTrack                 { get; set; } = Color.FromArgb(14, 14, 14);    // [N] side-pane tone
    public override Color TrackBarBottomTrack              { get; set; } = Color.FromArgb(174, 174, 174); // [N]
    public override Color TrackBarFillTrack                { get; set; } = Color.FromArgb(131, 132, 132); // [N]
    public override Color TrackBarOutsidePosition          { get; set; } = Color.FromArgb(64, Color.White); // [N]
    public override Color TrackBarBorderPosition           { get; set; } = Color.FromArgb(12, 12, 12);    // [N]
}
