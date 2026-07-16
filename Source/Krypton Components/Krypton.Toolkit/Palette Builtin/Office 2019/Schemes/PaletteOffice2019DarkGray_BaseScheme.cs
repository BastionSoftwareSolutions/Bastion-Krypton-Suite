#region BSD License
/*
 * New (Bastion) file in a work derived from BSD-3-Clause licensed code:
 * © Component Factory Pty Ltd, 2006 - 2016. Then modifications by Peter Wagner (aka Wagnerp),
 * Simon Coghlan (aka Smurf-IV), Giduac, Ahmed Abdelhameed, Lesandro & tobitege et al. 2017 - 2026.
 * © Bastion Software Solutions Ltd 2026. All rights reserved.
 */
#endregion

// =====================================================================================
// Office 2019 Dark Gray colour scheme (Bastion Phase 3 fidelity pass, spec §4.3).
//
// Provenance — every value is tagged:
//   [T] taken from docs\themes\office2019-colours.md ("Dark Gray variant" table;
//       source [E] powerpoint-darkgray.png, reference images under
//       docs\themes\references\office2019; pane/FILE-tab/selected-row/link values
//       carried from the shared-era 2016 [F] darkgray-theme crop, per
//       docs\themes\office2016-colours.md).
//       Key values: title bar / tab row #444444 (68,68,68); tab text #F0F0F0
//       (240,240,240); ribbon #B2B2B2 (178,178,178); ribbon/selected-tab text
//       #262626 (38,38,38); disabled text #8A8A8A–#9A9A9A; pane backgrounds #DEDEDE
//       (222,222,222); side pane #6A6A6A (106,106,106); icon-strip well #373737;
//       FILE tab fill #333333 (51,51,51); accent link #2A8DD4 (42,141,212).
//   [D] derived — rule stated inline. Hover/pressed fills, backstage, context menus,
//       status bar and inactive-window colours are colour-table open items and await
//       Chris's live-install screenshots.
//   [N] donor value from PaletteMicrosoft365White_BaseScheme — era-neutral slot with
//       no era-specific evidence (the M365 DarkGray scheme was not used as donor
//       because it carries incomplete/EMPTY ribbon slots).
// =====================================================================================

namespace Krypton.Toolkit;

/// <summary>
/// Provides the colour scheme values that back the Office 2019 Dark Gray theme (Bastion Phase 3 fidelity pass).
/// </summary>
public sealed class PaletteOffice2019DarkGray_BaseScheme : KryptonColorSchemeBase
{
    public override Color TextLabelControl                 { get; set; } = Color.FromArgb(38, 38, 38);    // [T] ribbon control text #262626
    public override Color TextButtonNormal                 { get; set; } = Color.FromArgb(38, 38, 38);    // [T] ribbon control text #262626
    public override Color TextButtonChecked                { get; set; } = Color.FromArgb(38, 38, 38);    // [T] ribbon control text #262626
    public override Color ButtonNormalBorder               { get; set; } = Color.FromArgb(154, 154, 154); // [D] mid-grey border — disabled band top #9A9A9A
    public override Color ButtonNormalDefaultBorder        { get; set; } = Color.FromArgb(154, 154, 154); // [D] #9A9A9A
    public override Color ButtonNormalBack1                { get; set; } = Color.FromArgb(253, 253, 253); // [N]
    public override Color ButtonNormalBack2                { get; set; } = Color.FromArgb(253, 253, 253); // [N]
    public override Color ButtonNormalDefaultBack1         { get; set; } = Color.FromArgb(235, 235, 235); // [N]
    public override Color ButtonNormalDefaultBack2         { get; set; } = Color.FromArgb(195, 195, 195); // [N]
    public override Color ButtonNormalNavigatorBack1       { get; set; } = Color.FromArgb(207, 212, 218); // [N]
    public override Color ButtonNormalNavigatorBack2       { get; set; } = Color.FromArgb(207, 212, 218); // [N]
    public override Color PanelClient                      { get; set; } = Color.FromArgb(178, 178, 178); // [T] ribbon #B2B2B2 — this pipeline fills the ribbon body with PanelClient, so it carries the signature ribbon tone
    public override Color PanelAlternative                 { get; set; } = Color.FromArgb(222, 222, 222); // [T] pane backgrounds #DEDEDE ([F])
    public override Color ControlBorder                    { get; set; } = Color.FromArgb(154, 154, 154); // [D] mid-grey border — disabled band top #9A9A9A
    public override Color SeparatorHighBorder1             { get; set; } = Color.FromArgb(250, 253, 255); // [N]
    public override Color SeparatorHighBorder2             { get; set; } = Color.FromArgb(227, 232, 237); // [N]
    public override Color HeaderPrimaryBack1               { get; set; } = Color.FromArgb(222, 222, 222); // [T] pane background #DEDEDE
    public override Color HeaderPrimaryBack2               { get; set; } = Color.FromArgb(222, 222, 222); // [T] pane background #DEDEDE
    public override Color HeaderSecondaryBack1             { get; set; } = Color.FromArgb(178, 178, 178); // [T] ribbon #B2B2B2
    public override Color HeaderSecondaryBack2             { get; set; } = Color.FromArgb(178, 178, 178); // [T] ribbon #B2B2B2
    public override Color HeaderText                       { get; set; } = Color.FromArgb(38, 38, 38);    // [T] ribbon text #262626
    public override Color StatusStripText                  { get; set; } = Color.FromArgb(240, 240, 240); // [D] tab-text tone #F0F0F0 on dark status (status not captured)
    public override Color ButtonBorder                     { get; set; } = Color.FromArgb(236, 199, 87);  // [N] hover border — hover/pressed fills are a colour-table open item
    public override Color SeparatorLight                   { get; set; } = Color.FromArgb(222, 222, 222); // [T] pane #DEDEDE
    public override Color SeparatorDark                    { get; set; } = Color.FromArgb(106, 106, 106); // [T] side pane #6A6A6A
    public override Color GripLight                        { get; set; } = Color.FromArgb(191, 191, 191); // [N]
    public override Color GripDark                         { get; set; } = Color.FromArgb(138, 138, 138); // [T] disabled band #8A8A8A
    public override Color ToolStripBack                    { get; set; } = Color.FromArgb(178, 178, 178); // [T] ribbon #B2B2B2
    public override Color StatusStripLight                 { get; set; } = Color.FromArgb(68, 68, 68);    // [D] chrome tone #444444 (status not captured; RTM may use accent)
    public override Color StatusStripDark                  { get; set; } = Color.FromArgb(68, 68, 68);    // [D] chrome tone #444444
    public override Color ImageMargin                      { get; set; } = Color.White;                   // [N]
    public override Color ToolStripBegin                   { get; set; } = Color.FromArgb(178, 178, 178); // [T] ribbon #B2B2B2
    public override Color ToolStripMiddle                  { get; set; } = Color.FromArgb(178, 178, 178); // [T] ribbon #B2B2B2
    public override Color ToolStripEnd                     { get; set; } = Color.FromArgb(178, 178, 178); // [T] ribbon #B2B2B2
    public override Color OverflowBegin                    { get; set; } = Color.FromArgb(135, 135, 135); // [D] ribbon −43/channel (donor White body→border offset)
    public override Color OverflowMiddle                   { get; set; } = Color.FromArgb(135, 135, 135); // [D] ribbon −43/channel
    public override Color OverflowEnd                      { get; set; } = Color.FromArgb(135, 135, 135); // [D] ribbon −43/channel
    public override Color ToolStripBorder                  { get; set; } = Color.FromArgb(135, 135, 135); // [D] ribbon −43/channel
    public override Color FormBorderActive                 { get; set; } = Color.FromArgb(68, 68, 68);    // [T] title bar #444444 — active frame
    public override Color FormBorderInactive               { get; set; } = Color.FromArgb(134, 139, 145); // [N] inactive — open item 4
    public override Color FormBorderActiveLight            { get; set; } = Color.FromArgb(68, 68, 68);    // [T] #444444 (flat frame)
    public override Color FormBorderActiveDark             { get; set; } = Color.FromArgb(68, 68, 68);    // [T] #444444 (flat frame)
    public override Color FormBorderInactiveLight          { get; set; } = Color.FromArgb(248, 247, 247); // [N] inactive — open item 4
    public override Color FormBorderInactiveDark           { get; set; } = Color.FromArgb(248, 247, 247); // [N] inactive — open item 4
    public override Color FormBorderHeaderActive           { get; set; } = Color.FromArgb(68, 68, 68);    // [T] #444444 — caption merges into tab row
    public override Color FormBorderHeaderInactive         { get; set; } = Color.FromArgb(134, 139, 145); // [N] inactive — open item 4
    public override Color FormBorderHeaderActive1          { get; set; } = Color.FromArgb(68, 68, 68);    // [T] title bar #444444 ([E] rect 250,8)
    public override Color FormBorderHeaderActive2          { get; set; } = Color.FromArgb(68, 68, 68);    // [T] title bar #444444
    public override Color FormBorderHeaderInactive1        { get; set; } = Color.FromArgb(248, 247, 247); // [N] inactive — open item 4
    public override Color FormBorderHeaderInactive2        { get; set; } = Color.FromArgb(248, 247, 247); // [N] inactive — open item 4
    public override Color FormHeaderShortActive            { get; set; } = Color.FromArgb(240, 240, 240); // [T] tab text #F0F0F0 on dark chrome
    public override Color FormHeaderShortInactive          { get; set; } = Color.FromArgb(138, 138, 138); // [N] inactive — open item 4
    public override Color FormHeaderLongActive             { get; set; } = Color.FromArgb(240, 240, 240); // [T] tab text #F0F0F0
    public override Color FormHeaderLongInactive           { get; set; } = Color.FromArgb(138, 138, 138); // [N] inactive — open item 4
    public override Color FormButtonBorderTrack            { get; set; } = Color.FromArgb(86, 86, 86);    // [D] caption hover = chrome +18/channel (open item 2)
    public override Color FormButtonBack1Track             { get; set; } = Color.FromArgb(86, 86, 86);    // [D] chrome +18/channel
    public override Color FormButtonBack2Track             { get; set; } = Color.FromArgb(86, 86, 86);    // [D] chrome +18/channel
    public override Color FormButtonBorderPressed          { get; set; } = Color.FromArgb(51, 51, 51);    // [T] FILE tab fill #333333 as pressed step
    public override Color FormButtonBack1Pressed           { get; set; } = Color.FromArgb(51, 51, 51);    // [T] #333333
    public override Color FormButtonBack2Pressed           { get; set; } = Color.FromArgb(51, 51, 51);    // [T] #333333
    public override Color TextButtonFormNormal             { get; set; } = Color.FromArgb(240, 240, 240); // [T] tab text #F0F0F0
    public override Color TextButtonFormTracking           { get; set; } = Color.FromArgb(240, 240, 240); // [T] tab text #F0F0F0
    public override Color TextButtonFormPressed            { get; set; } = Color.FromArgb(240, 240, 240); // [T] tab text #F0F0F0
    public override Color LinkNotVisitedOverrideControl    { get; set; } = Color.Blue;                    // [N]
    public override Color LinkVisitedOverrideControl       { get; set; } = Color.Purple;                  // [N]
    public override Color LinkPressedOverrideControl       { get; set; } = Color.Red;                     // [N]
    public override Color LinkNotVisitedOverridePanel      { get; set; } = Color.FromArgb(42, 141, 212);  // [T] accent link #2A8DD4 ([F] selected folder row)
    public override Color LinkVisitedOverridePanel         { get; set; } = Color.Purple;                  // [N]
    public override Color LinkPressedOverridePanel         { get; set; } = Color.Red;                     // [N]
    public override Color TextLabelPanel                   { get; set; } = Color.FromArgb(38, 38, 38);    // [T] text #262626 on #DEDEDE panes
    public override Color RibbonTabTextNormal              { get; set; } = Color.FromArgb(240, 240, 240); // [T] tab text (unselected) #F0F0F0
    public override Color RibbonTabTextChecked             { get; set; } = Color.FromArgb(38, 38, 38);    // [T] selected tab text #262626
    public override Color RibbonTabSelected1               { get; set; } = Color.FromArgb(178, 178, 178); // [T] selected tab fill #B2B2B2 — flat, borderless
    public override Color RibbonTabSelected2               { get; set; } = Color.FromArgb(178, 178, 178); // [T] selected tab fill #B2B2B2
    public override Color RibbonTabSelected3               { get; set; } = Color.FromArgb(178, 178, 178); // [T] selected tab fill #B2B2B2
    public override Color RibbonTabSelected4               { get; set; } = Color.FromArgb(178, 178, 178); // [T] selected tab fill #B2B2B2
    public override Color RibbonTabSelected5               { get; set; } = Color.FromArgb(178, 178, 178); // [T] selected tab fill #B2B2B2
    public override Color RibbonTabTracking1               { get; set; } = Color.FromArgb(86, 86, 86);    // [D] tab hover = chrome +18/channel (open item 2)
    public override Color RibbonTabTracking2               { get; set; } = Color.FromArgb(86, 86, 86);    // [D] chrome +18/channel
    public override Color RibbonTabHighlight1              { get; set; } = Color.FromArgb(178, 178, 178); // [D] mirrors RibbonTabSelected1
    public override Color RibbonTabHighlight2              { get; set; } = Color.FromArgb(178, 178, 178); // [D] mirrors selected fill
    public override Color RibbonTabHighlight3              { get; set; } = Color.FromArgb(178, 178, 178); // [D] mirrors selected fill
    public override Color RibbonTabHighlight4              { get; set; } = Color.FromArgb(178, 178, 178); // [D] mirrors selected fill
    public override Color RibbonTabHighlight5              { get; set; } = Color.FromArgb(178, 178, 178); // [D] mirrors selected fill
    public override Color RibbonTabSeparatorColor          { get; set; } = Color.FromArgb(68, 68, 68);    // [D] chrome #444444 — no visible tab separators
    public override Color RibbonGroupsArea1                { get; set; } = Color.FromArgb(135, 135, 135); // [D] ribbon −43/channel (donor White body→border offset)
    public override Color RibbonGroupsArea2                { get; set; } = Color.FromArgb(135, 135, 135); // [D] ribbon −43/channel
    public override Color RibbonGroupsArea3                { get; set; } = Color.FromArgb(154, 154, 154); // [D] disabled band top #9A9A9A as inner border
    public override Color RibbonGroupsArea4                { get; set; } = Color.FromArgb(178, 178, 178); // [T] ribbon background #B2B2B2 ([E] rects 82,44 / 370,140)
    public override Color RibbonGroupsArea5                { get; set; } = Color.FromArgb(178, 178, 178); // [T] ribbon background #B2B2B2
    public override Color RibbonGroupBorder1               { get; set; } = GlobalStaticValues.EMPTY_COLOR; // [N]
    public override Color RibbonGroupBorder2               { get; set; } = GlobalStaticValues.EMPTY_COLOR; // [N]
    public override Color RibbonGroupTitle1                { get; set; } = GlobalStaticValues.EMPTY_COLOR; // [N]
    public override Color RibbonGroupTitle2                { get; set; } = GlobalStaticValues.EMPTY_COLOR; // [N]
    public override Color RibbonGroupBorderContext1        { get; set; } = GlobalStaticValues.EMPTY_COLOR; // [N]
    public override Color RibbonGroupBorderContext2        { get; set; } = GlobalStaticValues.EMPTY_COLOR; // [N]
    public override Color RibbonGroupTitleContext1         { get; set; } = GlobalStaticValues.EMPTY_COLOR; // [N]
    public override Color RibbonGroupTitleContext2         { get; set; } = GlobalStaticValues.EMPTY_COLOR; // [N]
    public override Color RibbonGroupDialogDark            { get; set; } = Color.FromArgb(55, 55, 55);    // [T] icon-strip well #373737
    public override Color RibbonGroupDialogLight           { get; set; } = Color.FromArgb(178, 178, 178); // [T] ribbon #B2B2B2
    public override Color RibbonGroupTitleTracking1        { get; set; } = GlobalStaticValues.EMPTY_COLOR; // [N]
    public override Color RibbonGroupTitleTracking2        { get; set; } = GlobalStaticValues.EMPTY_COLOR; // [N]
    public override Color RibbonMinimizeBarDark            { get; set; } = Color.FromArgb(135, 135, 135); // [D] ribbon −43/channel
    public override Color RibbonMinimizeBarLight           { get; set; } = Color.FromArgb(178, 178, 178); // [T] ribbon #B2B2B2
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
    public override Color RibbonGroupCollapsedBackT2       { get; set; } = Color.FromArgb(242, 244, 247); // [N]
    public override Color RibbonGroupCollapsedBackT3       { get; set; } = Color.FromArgb(238, 241, 245); // [N]
    public override Color RibbonGroupCollapsedBackT4       { get; set; } = Color.FromArgb(234, 235, 235); // [N]
    public override Color RibbonGroupFrameBorder1          { get; set; } = Color.FromArgb(154, 154, 154); // [D] disabled band top #9A9A9A as frame border
    public override Color RibbonGroupFrameBorder2          { get; set; } = Color.FromArgb(154, 154, 154); // [D] #9A9A9A
    public override Color RibbonGroupFrameInside1          { get; set; } = Color.FromArgb(187, 187, 187); // [D] ribbon +9/channel (subtle inner well)
    public override Color RibbonGroupFrameInside2          { get; set; } = Color.FromArgb(187, 187, 187); // [D] ribbon +9/channel
    public override Color RibbonGroupFrameInside3          { get; set; } = GlobalStaticValues.EMPTY_COLOR; // [N]
    public override Color RibbonGroupFrameInside4          { get; set; } = GlobalStaticValues.EMPTY_COLOR; // [N]
    public override Color RibbonGroupCollapsedText         { get; set; } = Color.FromArgb(38, 38, 38);    // [T] ribbon text #262626
    public override Color RibbonGroupButtonText            { get; set; } = GlobalStaticValues.EMPTY_COLOR; // [N] missing value upstream
    public override Color AlternatePressedBack1            { get; set; } = Color.FromArgb(179, 185, 195); // [N]
    public override Color AlternatePressedBack2            { get; set; } = Color.FromArgb(216, 224, 224); // [N]
    public override Color AlternatePressedBorder1          { get; set; } = Color.FromArgb(125, 125, 125); // [N]
    public override Color AlternatePressedBorder2          { get; set; } = Color.FromArgb(186, 186, 186); // [N]
    public override Color FormButtonBack1Checked           { get; set; } = Color.FromArgb(86, 86, 86);    // [D] chrome +18/channel
    public override Color FormButtonBack2Checked           { get; set; } = Color.FromArgb(86, 86, 86);    // [D] chrome +18/channel
    public override Color FormButtonBorderCheck            { get; set; } = Color.FromArgb(86, 86, 86);    // [D] chrome +18/channel
    public override Color FormButtonBack1CheckTrack        { get; set; } = Color.FromArgb(51, 51, 51);    // [T] FILE fill #333333
    public override Color FormButtonBack2CheckTrack        { get; set; } = Color.FromArgb(51, 51, 51);    // [T] FILE fill #333333
    public override Color RibbonQATMini1                   { get; set; } = Color.FromArgb(68, 68, 68);    // [D] QAT minibar sits on the #444444 title bar
    public override Color RibbonQATMini2                   { get; set; } = Color.FromArgb(68, 68, 68);    // [D] chrome #444444
    public override Color RibbonQATMini3                   { get; set; } = Color.FromArgb(68, 68, 68);    // [D] chrome #444444
    public override Color RibbonQATMini4                   { get; set; } = Color.FromArgb(10, Color.White); // [N]
    public override Color RibbonQATMini5                   { get; set; } = Color.FromArgb(32, Color.White); // [N]
    public override Color RibbonQATMini1I                  { get; set; } = Color.FromArgb(200, 200, 200); // [N] inactive — open item 4
    public override Color RibbonQATMini2I                  { get; set; } = Color.FromArgb(233, 234, 238); // [N] inactive — open item 4
    public override Color RibbonQATMini3I                  { get; set; } = Color.FromArgb(223, 224, 228); // [N] inactive — open item 4
    public override Color RibbonQATMini4I                  { get; set; } = Color.FromArgb(10, Color.White); // [N]
    public override Color RibbonQATMini5I                  { get; set; } = Color.FromArgb(32, Color.White); // [N]
    public override Color RibbonQATFullbar1                { get; set; } = Color.FromArgb(178, 178, 178); // [T] ribbon #B2B2B2
    public override Color RibbonQATFullbar2                { get; set; } = Color.FromArgb(178, 178, 178); // [T] ribbon #B2B2B2
    public override Color RibbonQATFullbar3                { get; set; } = Color.FromArgb(135, 135, 135); // [D] ribbon −43/channel
    public override Color RibbonQATButtonDark              { get; set; } = Color.FromArgb(106, 106, 106); // [T] side pane #6A6A6A as dark glyph tone
    public override Color RibbonQATButtonLight             { get; set; } = Color.FromArgb(222, 222, 222); // [T] pane #DEDEDE as light glyph tone
    public override Color RibbonQATOverflow1               { get; set; } = Color.FromArgb(233, 237, 241); // [N]
    public override Color RibbonQATOverflow2               { get; set; } = Color.FromArgb(138, 144, 150); // [N]
    public override Color RibbonGroupSeparatorDark         { get; set; } = Color.FromArgb(154, 154, 154); // [D] disabled band top #9A9A9A as separator
    public override Color RibbonGroupSeparatorLight        { get; set; } = GlobalStaticValues.EMPTY_COLOR; // [N]
    public override Color ButtonClusterButtonBack1         { get; set; } = Color.FromArgb(231, 234, 238); // [N]
    public override Color ButtonClusterButtonBack2         { get; set; } = Color.FromArgb(241, 243, 243); // [N]
    public override Color ButtonClusterButtonBorder1       { get; set; } = Color.FromArgb(197, 198, 199); // [N]
    public override Color ButtonClusterButtonBorder2       { get; set; } = Color.FromArgb(157, 158, 159); // [N]
    public override Color NavigatorMiniBackColor           { get; set; } = Color.FromArgb(238, 238, 244); // [N]
    public override Color GridListNormal1                  { get; set; } = Color.White;                   // [N]
    public override Color GridListNormal2                  { get; set; } = Color.White;                   // [N]
    public override Color GridListPressed1                 { get; set; } = Color.FromArgb(203, 207, 212); // [N]
    public override Color GridListPressed2                 { get; set; } = Color.White;                   // [N]
    public override Color GridListSelected                 { get; set; } = Color.FromArgb(186, 189, 194); // [N]
    public override Color GridSheetColNormal1              { get; set; } = Color.FromArgb(222, 222, 222); // [T] pane #DEDEDE as header fill
    public override Color GridSheetColNormal2              { get; set; } = Color.FromArgb(222, 222, 222); // [T] pane #DEDEDE
    public override Color GridSheetColPressed1             { get; set; } = Color.FromArgb(178, 178, 178); // [D] ribbon tone #B2B2B2 as pressed header
    public override Color GridSheetColPressed2             { get; set; } = Color.FromArgb(178, 178, 178); // [D] #B2B2B2
    public override Color GridSheetColSelected1            { get; set; } = Color.FromArgb(242, 242, 242); // [T] selected row #F2F2F2 ([F])
    public override Color GridSheetColSelected2            { get; set; } = Color.FromArgb(242, 242, 242); // [T] #F2F2F2
    public override Color GridSheetRowNormal               { get; set; } = Color.FromArgb(222, 222, 222); // [T] pane #DEDEDE
    public override Color GridSheetRowPressed              { get; set; } = Color.FromArgb(178, 178, 178); // [D] #B2B2B2
    public override Color GridSheetRowSelected             { get; set; } = Color.FromArgb(242, 242, 242); // [T] #F2F2F2
    public override Color GridDataCellBorder               { get; set; } = Color.FromArgb(191, 191, 191); // [D] pane −31/channel grid line
    public override Color GridDataCellSelected             { get; set; } = Color.FromArgb(205, 230, 247); // [N]
    public override Color InputControlTextNormal           { get; set; } = Color.FromArgb(38, 38, 38);    // [T] text #262626
    public override Color InputControlTextDisabled         { get; set; } = Color.FromArgb(138, 138, 138); // [T] disabled command text #8A8A8A
    public override Color InputControlBorderNormal         { get; set; } = Color.FromArgb(154, 154, 154); // [D] mid-grey border #9A9A9A
    public override Color InputControlBorderDisabled       { get; set; } = Color.FromArgb(187, 187, 187); // [N]
    public override Color InputControlBackNormal           { get; set; } = Color.FromArgb(255, 255, 255); // [N]
    public override Color InputControlBackDisabled         { get; set; } = Color.FromArgb(240, 240, 240); // [N]
    public override Color InputControlBackInactive         { get; set; } = Color.FromArgb(247, 247, 247); // [N]
    public override Color InputDropDownNormal1             { get; set; } = Color.Black;                   // [N]
    public override Color InputDropDownNormal2             { get; set; } = Color.Transparent;             // [N]
    public override Color InputDropDownDisabled1           { get; set; } = Color.FromArgb(172, 168, 153); // [N]
    public override Color InputDropDownDisabled2           { get; set; } = Color.Transparent;             // [N]
    public override Color ContextMenuHeadingBack           { get; set; } = Color.FromArgb(240, 242, 245); // [N] context menu — colour-table open item 3
    public override Color ContextMenuHeadingText           { get; set; } = Color.FromArgb(38, 38, 38);    // [T] text #262626
    public override Color ContextMenuImageColumn           { get; set; } = Color.White;                   // [N] context menu — open item 3
    public override Color AppButtonBack1                   { get; set; } = Color.FromArgb(224, 227, 231); // [N] backstage — colour-table open item 3
    public override Color AppButtonBack2                   { get; set; } = Color.FromArgb(224, 227, 231); // [N] backstage — open item 3
    public override Color AppButtonBorder                  { get; set; } = Color.FromArgb(135, 140, 146); // [N] backstage — open item 3
    public override Color AppButtonOuter1                  { get; set; } = Color.FromArgb(224, 227, 231); // [N] backstage — open item 3
    public override Color AppButtonOuter2                  { get; set; } = Color.FromArgb(224, 227, 231); // [N] backstage — open item 3
    public override Color AppButtonOuter3                  { get; set; } = Color.FromArgb(224, 227, 231); // [N] backstage — open item 3
    public override Color AppButtonInner1                  { get; set; } = GlobalStaticValues.EMPTY_COLOR; // [N]
    public override Color AppButtonInner2                  { get; set; } = Color.FromArgb(135, 140, 146); // [N]
    public override Color AppButtonMenuDocsBack            { get; set; } = Color.White;                   // [N]
    public override Color AppButtonMenuDocsText            { get; set; } = Color.Black;                   // [N]
    public override Color SeparatorHighInternalBorder1     { get; set; } = Color.FromArgb(250, 253, 255); // [N]
    public override Color SeparatorHighInternalBorder2     { get; set; } = Color.FromArgb(227, 232, 237); // [N]
    public override Color RibbonGalleryBorder              { get; set; } = Color.FromArgb(154, 154, 154); // [D] mid-grey border #9A9A9A
    public override Color RibbonGalleryBackNormal          { get; set; } = Color.FromArgb(187, 187, 187); // [D] ribbon +9/channel gallery well
    public override Color RibbonGalleryBackTracking        { get; set; } = Color.FromArgb(198, 198, 198); // [D] gallery well +11
    public override Color RibbonGalleryBack1               { get; set; } = Color.FromArgb(187, 187, 187); // [D] gallery well
    public override Color RibbonGalleryBack2               { get; set; } = Color.FromArgb(178, 178, 178); // [T] ribbon #B2B2B2
    public override Color RibbonTabTracking3               { get; set; } = Color.FromArgb(86, 86, 86);    // [D] chrome +18/channel (open item 2)
    public override Color RibbonTabTracking4               { get; set; } = Color.FromArgb(86, 86, 86);    // [D] chrome +18/channel
    public override Color RibbonGroupBorder3               { get; set; } = Color.FromArgb(154, 154, 154); // [D] mid-grey border #9A9A9A
    public override Color RibbonGroupBorder4               { get; set; } = Color.FromArgb(154, 154, 154); // [D] #9A9A9A
    public override Color RibbonGroupBorder5               { get; set; } = GlobalStaticValues.EMPTY_COLOR; // [N]
    public override Color RibbonGroupTitleText             { get; set; } = Color.FromArgb(38, 38, 38);    // [T] ribbon text #262626 (group labels)
    public override Color RibbonDropArrowLight             { get; set; } = Color.FromArgb(151, 156, 163); // [N]
    public override Color RibbonDropArrowDark              { get; set; } = Color.FromArgb(55, 55, 55);    // [T] icon-strip well #373737
    public override Color HeaderDockInactiveBack1          { get; set; } = Color.FromArgb(237, 242, 248); // [N]
    public override Color HeaderDockInactiveBack2          { get; set; } = Color.FromArgb(207, 213, 220); // [N]
    public override Color ButtonNavigatorBorder            { get; set; } = Color.FromArgb(161, 169, 179); // [N]
    public override Color ButtonNavigatorText              { get; set; } = Color.Black;                   // [N]
    public override Color ButtonNavigatorTrack1            { get; set; } = Color.FromArgb(207, 213, 220); // [N]
    public override Color ButtonNavigatorTrack2            { get; set; } = Color.FromArgb(232, 234, 238); // [N]
    public override Color ButtonNavigatorPressed1          { get; set; } = Color.FromArgb(191, 196, 202); // [N]
    public override Color ButtonNavigatorPressed2          { get; set; } = Color.FromArgb(225, 226, 230); // [N]
    public override Color ButtonNavigatorChecked1          { get; set; } = Color.FromArgb(222, 227, 234); // [N]
    public override Color ButtonNavigatorChecked2          { get; set; } = Color.FromArgb(206, 214, 221); // [N]
    public override Color ToolTipBottom                    { get; set; } = Color.FromArgb(221, 221, 221); // [N]
    public override Color MenuItemText                     { get; set; } = GlobalStaticValues.EMPTY_COLOR; // [N]
    public override Color MenuMarginGradientStart          { get; set; } = GlobalStaticValues.EMPTY_COLOR; // [N]
    public override Color MenuMarginGradientMiddle         { get; set; } = GlobalStaticValues.EMPTY_COLOR; // [N]
    public override Color MenuMarginGradientEnd            { get; set; } = GlobalStaticValues.EMPTY_COLOR; // [N]
    public override Color DisabledMenuItemText             { get; set; } = GlobalStaticValues.EMPTY_COLOR; // [N]
    public override Color MenuStripText                    { get; set; } = GlobalStaticValues.EMPTY_COLOR; // [N]
    public override Color TrackBarTickMarks                { get; set; } = Color.FromArgb(38, 38, 38);    // [T] text #262626 (donor Color.Red was a stray)
    public override Color TrackBarTopTrack                 { get; set; } = Color.FromArgb(166, 170, 175); // [N]
    public override Color TrackBarBottomTrack              { get; set; } = Color.FromArgb(226, 220, 235); // [N]
    public override Color TrackBarFillTrack                { get; set; } = Color.FromArgb(206, 200, 215); // [N]
    public override Color TrackBarOutsidePosition          { get; set; } = Color.FromArgb(64, Color.White); // [N]
    public override Color TrackBarBorderPosition           { get; set; } = Color.FromArgb(80, 81, 82);    // [N]
}
