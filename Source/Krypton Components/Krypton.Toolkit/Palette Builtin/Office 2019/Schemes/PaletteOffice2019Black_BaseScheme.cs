#region BSD License
/*
 * New (Bastion) file in a work derived from BSD-3-Clause licensed code:
 * © Component Factory Pty Ltd, 2006 - 2016. Then modifications by Peter Wagner (aka Wagnerp),
 * Simon Coghlan (aka Smurf-IV), Giduac, Ahmed Abdelhameed, Lesandro & tobitege et al. 2017 - 2026.
 * © Bastion Software Solutions Ltd 2026. All rights reserved.
 */
#endregion

// =====================================================================================
// Office 2019 Black colour scheme (Bastion Phase 3 fidelity pass, spec §4.3).
//
// Provenance — every value is tagged:
//   [T] taken from docs\themes\office2019-colours.md ("Black variant (new in Office
//       2019)" table; source [E] powerpoint-black.png, reference images under
//       docs\themes\references\office2019\).
//       Key values: title bar / tab row #0A0A0A (10,10,10); tab text (unselected)
//       #B4B4B4 (180,180,180); ribbon + selected tab fill #363636 (54,54,54);
//       selected tab text #FFFFFF; ribbon control text #DADADA (218,218,218);
//       secondary text / separators #595959 (89,89,89); side pane #252525
//       (37,37,37); control well #3E3E3E (62,62,62); content canvas stays #FFFFFF.
//   [D] derived — rule stated inline. Hover/pressed fills, backstage, context menus
//       and inactive-window colours are colour-table open items and await Chris's
//       live-install screenshots.
//   [N] donor value from PaletteMicrosoft365Black_BaseScheme — era-neutral dark slot
//       with no era-specific evidence (dark donor used so unlisted slots stay
//       legible on dark surfaces).
// =====================================================================================

namespace Krypton.Toolkit;

public sealed class PaletteOffice2019Black_BaseScheme : KryptonColorSchemeBase
{
    public override Color TextLabelControl                 { get; set; } = Color.FromArgb(218, 218, 218); // [T] ribbon control text #DADADA on dark fills
    public override Color TextButtonNormal                 { get; set; } = Color.FromArgb(218, 218, 218); // [T] ribbon control text #DADADA — buttons/list items are dark wells in the Black look
    public override Color TextButtonChecked                { get; set; } = Color.White;                   // [T] selected/checked text #FFFFFF
    public override Color ButtonNormalBorder               { get; set; } = Color.FromArgb(89, 89, 89);    // [T] separators #595959
    public override Color ButtonNormalDefaultBorder        { get; set; } = Color.FromArgb(89, 89, 89);    // [T] separators #595959
    public override Color ButtonNormalBack1                { get; set; } = Color.FromArgb(62, 62, 62);    // [T] control well #3E3E3E (dark buttons, per [E] Paste well)
    public override Color ButtonNormalBack2                { get; set; } = Color.FromArgb(62, 62, 62);    // [T] control well #3E3E3E
    public override Color ButtonNormalDefaultBack1         { get; set; } = Color.FromArgb(74, 74, 74);    // [D] well +12/channel (default-button emphasis)
    public override Color ButtonNormalDefaultBack2         { get; set; } = Color.FromArgb(74, 74, 74);    // [D] well +12/channel
    public override Color ButtonNormalNavigatorBack1       { get; set; } = Color.FromArgb(32, 32, 32);    // [N]
    public override Color ButtonNormalNavigatorBack2       { get; set; } = Color.FromArgb(32, 32, 32);    // [N]
    public override Color PanelClient                      { get; set; } = Color.FromArgb(54, 54, 54);    // [T] ribbon #363636 — this pipeline fills the ribbon body with PanelClient, so it carries the signature ribbon tone
    public override Color PanelAlternative                 { get; set; } = Color.FromArgb(37, 37, 37);    // [T] side pane #252525
    public override Color ControlBorder                    { get; set; } = Color.FromArgb(89, 89, 89);    // [T] separators #595959
    public override Color SeparatorHighBorder1             { get; set; } = Color.FromArgb(172, 172, 172); // [N]
    public override Color SeparatorHighBorder2             { get; set; } = Color.FromArgb(111, 111, 111); // [N]
    public override Color HeaderPrimaryBack1               { get; set; } = Color.FromArgb(62, 62, 62);    // [T] control well #3E3E3E
    public override Color HeaderPrimaryBack2               { get; set; } = Color.FromArgb(62, 62, 62);    // [T] control well #3E3E3E
    public override Color HeaderSecondaryBack1             { get; set; } = Color.FromArgb(54, 54, 54);    // [T] ribbon #363636
    public override Color HeaderSecondaryBack2             { get; set; } = Color.FromArgb(54, 54, 54);    // [T] ribbon #363636
    public override Color HeaderText                       { get; set; } = Color.FromArgb(218, 218, 218); // [T] ribbon control text #DADADA
    public override Color StatusStripText                  { get; set; } = Color.FromArgb(180, 180, 180); // [D] tab-text tone #B4B4B4 (status bar not in crop)
    public override Color ButtonBorder                     { get; set; } = Color.FromArgb(236, 199, 87);  // [N] hover border — hover/pressed fills are a colour-table open item
    public override Color SeparatorLight                   { get; set; } = Color.FromArgb(89, 89, 89);    // [T] separators #595959
    public override Color SeparatorDark                    { get; set; } = Color.Black;                   // [N]
    public override Color GripLight                        { get; set; } = Color.FromArgb(89, 89, 89);    // [T] separators #595959
    public override Color GripDark                         { get; set; } = Color.FromArgb(27, 27, 27);    // [N]
    public override Color ToolStripBack                    { get; set; } = Color.FromArgb(54, 54, 54);    // [T] ribbon #363636
    public override Color StatusStripLight                 { get; set; } = Color.FromArgb(10, 10, 10);    // [D] chrome #0A0A0A (status bar not in crop)
    public override Color StatusStripDark                  { get; set; } = Color.FromArgb(10, 10, 10);    // [D] chrome #0A0A0A
    public override Color ImageMargin                      { get; set; } = Color.White;                   // [N]
    public override Color ToolStripBegin                   { get; set; } = Color.FromArgb(54, 54, 54);    // [T] ribbon #363636
    public override Color ToolStripMiddle                  { get; set; } = Color.FromArgb(54, 54, 54);    // [T] ribbon #363636
    public override Color ToolStripEnd                     { get; set; } = Color.FromArgb(54, 54, 54);    // [T] ribbon #363636
    public override Color OverflowBegin                    { get; set; } = Color.FromArgb(37, 37, 37);    // [D] side-pane tone #252525 for overflow chrome
    public override Color OverflowMiddle                   { get; set; } = Color.FromArgb(37, 37, 37);    // [D] #252525
    public override Color OverflowEnd                      { get; set; } = Color.FromArgb(37, 37, 37);    // [D] #252525
    public override Color ToolStripBorder                  { get; set; } = Color.FromArgb(89, 89, 89);    // [T] separators #595959
    public override Color FormBorderActive                 { get; set; } = Color.FromArgb(10, 10, 10);    // [T] title bar #0A0A0A — active frame
    public override Color FormBorderInactive               { get; set; } = Color.FromArgb(119, 119, 119); // [N] inactive — open item 3
    public override Color FormBorderActiveLight            { get; set; } = Color.FromArgb(10, 10, 10);    // [T] #0A0A0A (flat frame)
    public override Color FormBorderActiveDark             { get; set; } = Color.FromArgb(10, 10, 10);    // [T] #0A0A0A (flat frame)
    public override Color FormBorderInactiveLight          { get; set; } = Color.FromArgb(158, 158, 158); // [N] inactive — open item 3
    public override Color FormBorderInactiveDark           { get; set; } = Color.FromArgb(158, 158, 158); // [N] inactive — open item 3
    public override Color FormBorderHeaderActive           { get; set; } = Color.FromArgb(10, 10, 10);    // [T] #0A0A0A — caption merges into tab row
    public override Color FormBorderHeaderInactive         { get; set; } = Color.FromArgb(154, 154, 154); // [N] inactive — open item 3
    public override Color FormBorderHeaderActive1          { get; set; } = Color.FromArgb(10, 10, 10);    // [T] title bar #0A0A0A ([E] rect 250,8)
    public override Color FormBorderHeaderActive2          { get; set; } = Color.FromArgb(10, 10, 10);    // [T] title bar #0A0A0A
    public override Color FormBorderHeaderInactive1        { get; set; } = Color.FromArgb(158, 158, 158); // [N] inactive — open item 3
    public override Color FormBorderHeaderInactive2        { get; set; } = Color.FromArgb(158, 158, 158); // [N] inactive — open item 3
    public override Color FormHeaderShortActive            { get; set; } = Color.FromArgb(180, 180, 180); // [D] tab-text tone #B4B4B4 (title text not in crop)
    public override Color FormHeaderShortInactive          { get; set; } = Color.FromArgb(128, 128, 128); // [D] inactive dimmed — tab text −52/channel
    public override Color FormHeaderLongActive             { get; set; } = Color.FromArgb(180, 180, 180); // [D] tab-text tone #B4B4B4
    public override Color FormHeaderLongInactive           { get; set; } = Color.FromArgb(128, 128, 128); // [D] inactive dimmed
    public override Color FormButtonBorderTrack            { get; set; } = Color.FromArgb(37, 37, 37);    // [D] caption hover = side-pane step #252525 (open item 1)
    public override Color FormButtonBack1Track             { get; set; } = Color.FromArgb(37, 37, 37);    // [D] #252525
    public override Color FormButtonBack2Track             { get; set; } = Color.FromArgb(37, 37, 37);    // [D] #252525
    public override Color FormButtonBorderPressed          { get; set; } = Color.FromArgb(62, 62, 62);    // [D] pressed = control-well step #3E3E3E
    public override Color FormButtonBack1Pressed           { get; set; } = Color.FromArgb(62, 62, 62);    // [D] #3E3E3E
    public override Color FormButtonBack2Pressed           { get; set; } = Color.FromArgb(62, 62, 62);    // [D] #3E3E3E
    public override Color TextButtonFormNormal             { get; set; } = Color.FromArgb(180, 180, 180); // [T] tab text #B4B4B4
    public override Color TextButtonFormTracking           { get; set; } = Color.White;                   // [N]
    public override Color TextButtonFormPressed            { get; set; } = Color.White;                   // [N]
    public override Color LinkNotVisitedOverrideControl    { get; set; } = Color.Blue;                    // [N]
    public override Color LinkVisitedOverrideControl       { get; set; } = Color.Purple;                  // [N]
    public override Color LinkPressedOverrideControl       { get; set; } = Color.Red;                     // [N]
    public override Color LinkNotVisitedOverridePanel      { get; set; } = Color.FromArgb(180, 210, 255); // [N]
    public override Color LinkVisitedOverridePanel         { get; set; } = Color.Violet;                  // [N]
    public override Color LinkPressedOverridePanel         { get; set; } = Color.FromArgb(255, 90, 90);   // [N]
    public override Color TextLabelPanel                   { get; set; } = Color.FromArgb(218, 218, 218); // [T] ribbon control text #DADADA on dark panels
    public override Color RibbonTabTextNormal              { get; set; } = Color.FromArgb(180, 180, 180); // [T] tab text (unselected) #B4B4B4
    public override Color RibbonTabTextChecked             { get; set; } = Color.White;                   // [T] selected tab text #FFFFFF
    public override Color RibbonTabSelected1               { get; set; } = Color.FromArgb(54, 54, 54);    // [T] selected tab fill #363636 — flat, borderless
    public override Color RibbonTabSelected2               { get; set; } = Color.FromArgb(54, 54, 54);    // [T] selected tab fill #363636
    public override Color RibbonTabSelected3               { get; set; } = Color.FromArgb(54, 54, 54);    // [T] selected tab fill #363636
    public override Color RibbonTabSelected4               { get; set; } = Color.FromArgb(54, 54, 54);    // [T] selected tab fill #363636
    public override Color RibbonTabSelected5               { get; set; } = Color.FromArgb(54, 54, 54);    // [T] selected tab fill #363636
    public override Color RibbonTabTracking1               { get; set; } = Color.FromArgb(37, 37, 37);    // [D] tab hover = documented #252525 step (open item 1)
    public override Color RibbonTabTracking2               { get; set; } = Color.FromArgb(37, 37, 37);    // [D] #252525
    public override Color RibbonTabHighlight1              { get; set; } = Color.FromArgb(54, 54, 54);    // [D] mirrors RibbonTabSelected1
    public override Color RibbonTabHighlight2              { get; set; } = Color.FromArgb(54, 54, 54);    // [D] mirrors selected fill
    public override Color RibbonTabHighlight3              { get; set; } = Color.FromArgb(54, 54, 54);    // [D] mirrors selected fill
    public override Color RibbonTabHighlight4              { get; set; } = Color.FromArgb(54, 54, 54);    // [D] mirrors selected fill
    public override Color RibbonTabHighlight5              { get; set; } = Color.FromArgb(54, 54, 54);    // [D] mirrors selected fill
    public override Color RibbonTabSeparatorColor          { get; set; } = Color.FromArgb(89, 89, 89);    // [T] secondary separators #595959
    public override Color RibbonGroupsArea1                { get; set; } = Color.FromArgb(54, 54, 54);    // [D] flat with ribbon (donor Black keeps Area1 ≈ body)
    public override Color RibbonGroupsArea2                { get; set; } = Color.FromArgb(71, 71, 71);    // [D] body +17/channel (donor Black offset)
    public override Color RibbonGroupsArea3                { get; set; } = Color.FromArgb(75, 75, 75);    // [D] body +21/channel (donor Black offset)
    public override Color RibbonGroupsArea4                { get; set; } = Color.FromArgb(54, 54, 54);    // [T] ribbon background #363636 ([E] rects 82,46 / 370,146)
    public override Color RibbonGroupsArea5                { get; set; } = Color.FromArgb(54, 54, 54);    // [T] ribbon background #363636
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
    public override Color RibbonMinimizeBarLight           { get; set; } = Color.FromArgb(54, 54, 54);    // [T] ribbon #363636
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
    public override Color RibbonGroupFrameBorder1          { get; set; } = Color.FromArgb(89, 89, 89);    // [T] separators #595959
    public override Color RibbonGroupFrameBorder2          { get; set; } = Color.FromArgb(89, 89, 89);    // [T] separators #595959
    public override Color RibbonGroupFrameInside1          { get; set; } = Color.FromArgb(62, 62, 62);    // [T] control well #3E3E3E ([E] point 60,79)
    public override Color RibbonGroupFrameInside2          { get; set; } = Color.FromArgb(62, 62, 62);    // [T] control well #3E3E3E
    public override Color RibbonGroupFrameInside3          { get; set; } = GlobalStaticValues.EMPTY_COLOR; // [N]
    public override Color RibbonGroupFrameInside4          { get; set; } = GlobalStaticValues.EMPTY_COLOR; // [N]
    public override Color RibbonGroupCollapsedText         { get; set; } = Color.FromArgb(218, 218, 218); // [T] ribbon control text #DADADA
    public override Color RibbonGroupButtonText            { get; set; } = GlobalStaticValues.EMPTY_COLOR; // [N] missing value upstream
    public override Color AlternatePressedBack1            { get; set; } = Color.FromArgb(158, 163, 172); // [N]
    public override Color AlternatePressedBack2            { get; set; } = Color.FromArgb(212, 215, 216); // [N]
    public override Color AlternatePressedBorder1          { get; set; } = Color.FromArgb(124, 125, 125); // [N]
    public override Color AlternatePressedBorder2          { get; set; } = Color.FromArgb(186, 186, 186); // [N]
    public override Color FormButtonBack1Checked           { get; set; } = Color.FromArgb(37, 37, 37);    // [D] side-pane step #252525
    public override Color FormButtonBack2Checked           { get; set; } = Color.FromArgb(37, 37, 37);    // [D] #252525
    public override Color FormButtonBorderCheck            { get; set; } = Color.FromArgb(62, 62, 62);    // [D] control-well step #3E3E3E
    public override Color FormButtonBack1CheckTrack        { get; set; } = Color.FromArgb(62, 62, 62);    // [D] #3E3E3E
    public override Color FormButtonBack2CheckTrack        { get; set; } = Color.FromArgb(62, 62, 62);    // [D] #3E3E3E
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
    public override Color RibbonQATFullbar1                { get; set; } = Color.FromArgb(54, 54, 54);    // [T] ribbon #363636
    public override Color RibbonQATFullbar2                { get; set; } = Color.FromArgb(54, 54, 54);    // [T] ribbon #363636
    public override Color RibbonQATFullbar3                { get; set; } = Color.FromArgb(37, 37, 37);    // [D] side-pane tone #252525
    public override Color RibbonQATButtonDark              { get; set; } = Color.FromArgb(50, 50, 50);    // [N]
    public override Color RibbonQATButtonLight             { get; set; } = Color.FromArgb(140, 140, 140); // [N]
    public override Color RibbonQATOverflow1               { get; set; } = Color.FromArgb(161, 161, 161); // [N]
    public override Color RibbonQATOverflow2               { get; set; } = Color.FromArgb(68, 68, 68);    // [N]
    public override Color RibbonGroupSeparatorDark         { get; set; } = Color.FromArgb(89, 89, 89);    // [T] separators #595959
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
    public override Color GridDataCellBorder               { get; set; } = Color.FromArgb(218, 220, 221); // [N] content canvas stays light per table
    public override Color GridDataCellSelected             { get; set; } = Color.FromArgb(183, 219, 255); // [N]
    public override Color InputControlTextNormal           { get; set; } = Color.FromArgb(218, 218, 218); // [T] ribbon control text #DADADA (dark inputs)
    public override Color InputControlTextDisabled         { get; set; } = Color.FromArgb(128, 128, 128); // [N]
    public override Color InputControlBorderNormal         { get; set; } = Color.FromArgb(89, 89, 89);    // [T] separators #595959
    public override Color InputControlBorderDisabled       { get; set; } = Color.FromArgb(70, 70, 70);    // [D] border dimmed one step below #595959
    public override Color InputControlBackNormal           { get; set; } = Color.FromArgb(62, 62, 62);    // [T] control well #3E3E3E ([E] font combo fill)
    public override Color InputControlBackDisabled         { get; set; } = Color.FromArgb(48, 48, 48);    // [D] well dimmed toward ribbon tone
    public override Color InputControlBackInactive         { get; set; } = Color.FromArgb(54, 54, 54);    // [T] ribbon #363636
    public override Color InputDropDownNormal1             { get; set; } = Color.FromArgb(218, 218, 218); // [T] glyph = control text #DADADA
    public override Color InputDropDownNormal2             { get; set; } = Color.Transparent;             // [N]
    public override Color InputDropDownDisabled1           { get; set; } = Color.FromArgb(128, 128, 128); // [D] disabled glyph matches disabled text
    public override Color InputDropDownDisabled2           { get; set; } = Color.Transparent;             // [N]
    public override Color ContextMenuHeadingBack           { get; set; } = Color.FromArgb(240, 242, 245); // [N] context menu — colour-table open item 2
    public override Color ContextMenuHeadingText           { get; set; } = Color.Black;                   // [N] context menu — open item 2
    public override Color ContextMenuImageColumn           { get; set; } = Color.White;                   // [N] context menu — open item 2
    public override Color AppButtonBack1                   { get; set; } = Color.FromArgb(70, 70, 70);    // [N] backstage — colour-table open item 2
    public override Color AppButtonBack2                   { get; set; } = Color.FromArgb(70, 70, 70);    // [N] backstage — open item 2
    public override Color AppButtonBorder                  { get; set; } = Color.FromArgb(50, 50, 50);    // [N] backstage — open item 2
    public override Color AppButtonOuter1                  { get; set; } = Color.FromArgb(70, 70, 70);    // [N] backstage — open item 2
    public override Color AppButtonOuter2                  { get; set; } = Color.FromArgb(70, 70, 70);    // [N] backstage — open item 2
    public override Color AppButtonOuter3                  { get; set; } = Color.FromArgb(70, 70, 70);    // [N] backstage — open item 2
    public override Color AppButtonInner1                  { get; set; } = GlobalStaticValues.EMPTY_COLOR; // [N]
    public override Color AppButtonInner2                  { get; set; } = Color.FromArgb(50, 50, 50);    // [N]
    public override Color AppButtonMenuDocsBack            { get; set; } = Color.White;                   // [N]
    public override Color AppButtonMenuDocsText            { get; set; } = Color.Black;                   // [N]
    public override Color SeparatorHighInternalBorder1     { get; set; } = Color.FromArgb(172, 172, 172); // [N]
    public override Color SeparatorHighInternalBorder2     { get; set; } = Color.FromArgb(111, 111, 111); // [N]
    public override Color RibbonGalleryBorder              { get; set; } = Color.FromArgb(89, 89, 89);    // [T] separators #595959
    public override Color RibbonGalleryBackNormal          { get; set; } = Color.FromArgb(62, 62, 62);    // [T] control well #3E3E3E
    public override Color RibbonGalleryBackTracking        { get; set; } = Color.FromArgb(74, 74, 74);    // [D] well +12/channel hover step
    public override Color RibbonGalleryBack1               { get; set; } = Color.FromArgb(62, 62, 62);    // [T] control well #3E3E3E
    public override Color RibbonGalleryBack2               { get; set; } = Color.FromArgb(54, 54, 54);    // [T] ribbon #363636
    public override Color RibbonTabTracking3               { get; set; } = Color.FromArgb(37, 37, 37);    // [D] documented #252525 step (open item 1)
    public override Color RibbonTabTracking4               { get; set; } = GlobalStaticValues.EMPTY_COLOR; // [N]
    public override Color RibbonGroupBorder3               { get; set; } = Color.FromArgb(37, 37, 37);    // [D] side-pane tone #252525 (donor Black uses darker-than-body)
    public override Color RibbonGroupBorder4               { get; set; } = Color.FromArgb(37, 37, 37);    // [D] #252525
    public override Color RibbonGroupBorder5               { get; set; } = GlobalStaticValues.EMPTY_COLOR; // [N]
    public override Color RibbonGroupTitleText             { get; set; } = Color.FromArgb(180, 180, 180); // [D] group labels dimmer than control text — tab-text tone #B4B4B4
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
    public override Color TrackBarTopTrack                 { get; set; } = Color.FromArgb(37, 37, 37);    // [N]
    public override Color TrackBarBottomTrack              { get; set; } = Color.FromArgb(174, 174, 174); // [N]
    public override Color TrackBarFillTrack                { get; set; } = Color.FromArgb(131, 132, 132); // [N]
    public override Color TrackBarOutsidePosition          { get; set; } = Color.FromArgb(64, Color.White); // [N]
    public override Color TrackBarBorderPosition           { get; set; } = Color.FromArgb(35, 35, 35);    // [N]
}
