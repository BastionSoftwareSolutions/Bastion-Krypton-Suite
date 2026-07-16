#region BSD License
/*
 * New (Bastion) file in a work derived from BSD-3-Clause licensed code:
 * © Component Factory Pty Ltd, 2006 - 2016. Then modifications by Peter Wagner (aka Wagnerp),
 * Simon Coghlan (aka Smurf-IV), Giduac, Ahmed Abdelhameed, Lesandro & tobitege et al. 2017 - 2026.
 * © Bastion Software Solutions Ltd 2026. All rights reserved.
 */
#endregion

// =====================================================================================
// Office 2019 Colorful colour scheme (Bastion Phase 3 fidelity pass, spec §4.3).
//
// Provenance — every value is tagged:
//   [T] taken from docs\themes\office2019-colours.md ("App accent colours" +
//       "Colorful variant" tables; sources [H]/[D]/[E]/[G], reference images under
//       docs\themes\references\office2019\).
//       Key values: accent = Word blue #2B579A (43,87,154) — [H] title rect exact
//       (the later Fluent Word blue #185ABD arrived with the post-2019 M365 refresh
//       and is NOT in the 2019 table); accent hover/darker companion #2C4B7A
//       (44,75,122) from [G]; ribbon/status #F3F3F3 (243,243,243) — one step lighter
//       than 2016's #F1F1F1; window text #262626; group label #7E7E7E; group
//       separator #D2D2D2 (edge px #B1B1B1); document surround #E6E6E6; Excel grid
//       lines #D4D4D4.
//   [D] derived — rule stated inline. Hover/pressed fills, backstage, context menus
//       and inactive-window colours are open items in the colour table (not visible
//       in static screenshots) and await Chris's live-install screenshots.
//   [N] donor value from PaletteMicrosoft365White_BaseScheme — era-neutral slot with
//       no era-specific evidence.
// =====================================================================================

namespace Krypton.Toolkit;

/// <summary>
/// Provides the colour scheme values that back the Office 2019 Colorful theme (Bastion Phase 3 fidelity pass).
/// </summary>
public sealed class PaletteOffice2019Colorful_BaseScheme : KryptonColorSchemeBase
{
    public override Color TextLabelControl                 { get; set; } = Color.FromArgb(38, 38, 38);    // [T] window text (ribbon controls) #262626
    public override Color TextButtonNormal                 { get; set; } = Color.FromArgb(38, 38, 38);    // [T] window text #262626
    public override Color TextButtonChecked                { get; set; } = Color.FromArgb(38, 38, 38);    // [T] window text #262626
    public override Color ButtonNormalBorder               { get; set; } = Color.FromArgb(170, 170, 170); // [N]
    public override Color ButtonNormalDefaultBorder        { get; set; } = Color.FromArgb(170, 170, 170); // [N]
    public override Color ButtonNormalBack1                { get; set; } = Color.FromArgb(253, 253, 253); // [N]
    public override Color ButtonNormalBack2                { get; set; } = Color.FromArgb(253, 253, 253); // [N]
    public override Color ButtonNormalDefaultBack1         { get; set; } = Color.FromArgb(235, 235, 235); // [N]
    public override Color ButtonNormalDefaultBack2         { get; set; } = Color.FromArgb(195, 195, 195); // [N]
    public override Color ButtonNormalNavigatorBack1       { get; set; } = Color.FromArgb(207, 212, 218); // [N]
    public override Color ButtonNormalNavigatorBack2       { get; set; } = Color.FromArgb(207, 212, 218); // [N]
    public override Color PanelClient                      { get; set; } = Color.FromArgb(243, 243, 243); // [T] ribbon/chrome neutral #F3F3F3
    public override Color PanelAlternative                 { get; set; } = Color.FromArgb(230, 230, 230); // [T] document surround #E6E6E6
    public override Color ControlBorder                    { get; set; } = Color.FromArgb(177, 177, 177); // [T] separator edge px #B1B1B1
    public override Color SeparatorHighBorder1             { get; set; } = Color.FromArgb(250, 253, 255); // [N]
    public override Color SeparatorHighBorder2             { get; set; } = Color.FromArgb(227, 232, 237); // [N]
    public override Color HeaderPrimaryBack1               { get; set; } = Color.FromArgb(243, 243, 243); // [T] chrome neutral #F3F3F3
    public override Color HeaderPrimaryBack2               { get; set; } = Color.FromArgb(243, 243, 243); // [T] chrome neutral #F3F3F3
    public override Color HeaderSecondaryBack1             { get; set; } = Color.FromArgb(230, 230, 230); // [T] document surround #E6E6E6
    public override Color HeaderSecondaryBack2             { get; set; } = Color.FromArgb(230, 230, 230); // [T] document surround #E6E6E6
    public override Color HeaderText                       { get; set; } = Color.FromArgb(38, 38, 38);    // [T] window text #262626
    public override Color StatusStripText                  { get; set; } = Color.FromArgb(81, 80, 80);    // [T] status text #515050 (2016 table, shared-era composite)
    public override Color ButtonBorder                     { get; set; } = Color.FromArgb(236, 199, 87);  // [N] hover border — hover/pressed fills are a colour-table open item
    public override Color SeparatorLight                   { get; set; } = Color.FromArgb(247, 250, 252); // [N]
    public override Color SeparatorDark                    { get; set; } = Color.FromArgb(119, 123, 127); // [N]
    public override Color GripLight                        { get; set; } = Color.FromArgb(191, 191, 191); // [N]
    public override Color GripDark                         { get; set; } = Color.FromArgb(191, 191, 191); // [N]
    public override Color ToolStripBack                    { get; set; } = Color.FromArgb(243, 243, 243); // [T] chrome neutral #F3F3F3
    public override Color StatusStripLight                 { get; set; } = Color.FromArgb(243, 243, 243); // [T] status bar #F3F3F3 ([H] uniform, all four apps)
    public override Color StatusStripDark                  { get; set; } = Color.FromArgb(243, 243, 243); // [T] status bar #F3F3F3
    public override Color ImageMargin                      { get; set; } = Color.White;                   // [N]
    public override Color ToolStripBegin                   { get; set; } = Color.FromArgb(243, 243, 243); // [T] chrome neutral #F3F3F3
    public override Color ToolStripMiddle                  { get; set; } = Color.FromArgb(243, 243, 243); // [T] chrome neutral #F3F3F3
    public override Color ToolStripEnd                     { get; set; } = Color.FromArgb(243, 243, 243); // [T] chrome neutral #F3F3F3
    public override Color OverflowBegin                    { get; set; } = Color.FromArgb(177, 177, 177); // [D] separator edge tone #B1B1B1 for overflow chrome
    public override Color OverflowMiddle                   { get; set; } = Color.FromArgb(177, 177, 177); // [D] #B1B1B1
    public override Color OverflowEnd                      { get; set; } = Color.FromArgb(177, 177, 177); // [D] #B1B1B1
    public override Color ToolStripBorder                  { get; set; } = Color.FromArgb(177, 177, 177); // [T] separator edge px #B1B1B1
    public override Color FormBorderActive                 { get; set; } = Color.FromArgb(43, 87, 154);   // [T] app accent (Word) #2B579A — active frame
    public override Color FormBorderInactive               { get; set; } = Color.FromArgb(134, 139, 145); // [N] inactive frame — colour-table open item 3
    public override Color FormBorderActiveLight            { get; set; } = Color.FromArgb(43, 87, 154);   // [T] accent #2B579A (flat frame)
    public override Color FormBorderActiveDark             { get; set; } = Color.FromArgb(43, 87, 154);   // [T] accent #2B579A (flat frame)
    public override Color FormBorderInactiveLight          { get; set; } = Color.FromArgb(248, 247, 247); // [N] inactive — open item 3
    public override Color FormBorderInactiveDark           { get; set; } = Color.FromArgb(248, 247, 247); // [N] inactive — open item 3
    public override Color FormBorderHeaderActive           { get; set; } = Color.FromArgb(43, 87, 154);   // [T] accent #2B579A — caption merges into tab row, no divider
    public override Color FormBorderHeaderInactive         { get; set; } = Color.FromArgb(134, 139, 145); // [N] inactive — open item 3
    public override Color FormBorderHeaderActive1          { get; set; } = Color.FromArgb(43, 87, 154);   // [T] title bar active = accent #2B579A ([H] exact)
    public override Color FormBorderHeaderActive2          { get; set; } = Color.FromArgb(43, 87, 154);   // [T] title bar active = accent #2B579A
    public override Color FormBorderHeaderInactive1        { get; set; } = Color.FromArgb(248, 247, 247); // [N] inactive — open item 3
    public override Color FormBorderHeaderInactive2        { get; set; } = Color.FromArgb(248, 247, 247); // [N] inactive — open item 3
    public override Color FormHeaderShortActive            { get; set; } = Color.White;                   // [T] title bar text #FFFFFF
    public override Color FormHeaderShortInactive          { get; set; } = Color.FromArgb(138, 138, 138); // [N] inactive — open item 3
    public override Color FormHeaderLongActive             { get; set; } = Color.White;                   // [T] title bar text #FFFFFF
    public override Color FormHeaderLongInactive           { get; set; } = Color.FromArgb(138, 138, 138); // [N] inactive — open item 3
    public override Color FormButtonBorderTrack            { get; set; } = Color.FromArgb(44, 75, 122);   // [D] caption hover = [G] darker companion #2C4B7A (hover open item 1)
    public override Color FormButtonBack1Track             { get; set; } = Color.FromArgb(44, 75, 122);   // [D] #2C4B7A ([G] darker companion)
    public override Color FormButtonBack2Track             { get; set; } = Color.FromArgb(44, 75, 122);   // [D] #2C4B7A ([G] darker companion)
    public override Color FormButtonBorderPressed          { get; set; } = Color.FromArgb(32, 65, 116);   // [D] pressed = accent blended 25% toward black
    public override Color FormButtonBack1Pressed           { get; set; } = Color.FromArgb(32, 65, 116);   // [D] accent 25% toward black
    public override Color FormButtonBack2Pressed           { get; set; } = Color.FromArgb(32, 65, 116);   // [D] accent 25% toward black
    public override Color TextButtonFormNormal             { get; set; } = Color.White;                   // [T] caption glyph/text white on accent
    public override Color TextButtonFormTracking           { get; set; } = Color.White;                   // [T] white on accent hover
    public override Color TextButtonFormPressed            { get; set; } = Color.White;                   // [T] white on accent pressed
    public override Color LinkNotVisitedOverrideControl    { get; set; } = Color.Blue;                    // [N]
    public override Color LinkVisitedOverrideControl       { get; set; } = Color.Purple;                  // [N]
    public override Color LinkPressedOverrideControl       { get; set; } = Color.Red;                     // [N]
    public override Color LinkNotVisitedOverridePanel      { get; set; } = Color.Blue;                    // [N]
    public override Color LinkVisitedOverridePanel         { get; set; } = Color.Purple;                  // [N]
    public override Color LinkPressedOverridePanel         { get; set; } = Color.Red;                     // [N]
    public override Color TextLabelPanel                   { get; set; } = Color.FromArgb(38, 38, 38);    // [T] window text #262626
    public override Color RibbonTabTextNormal              { get; set; } = Color.White;                   // [T] ribbon tab text (unselected) white on accent row
    public override Color RibbonTabTextChecked             { get; set; } = Color.FromArgb(43, 87, 154);   // [T] selected ribbon tab text = accent #2B579A
    public override Color RibbonTabSelected1               { get; set; } = Color.FromArgb(243, 243, 243); // [T] selected tab fill #F3F3F3 — flat, borderless
    public override Color RibbonTabSelected2               { get; set; } = Color.FromArgb(243, 243, 243); // [T] selected tab fill #F3F3F3
    public override Color RibbonTabSelected3               { get; set; } = Color.FromArgb(243, 243, 243); // [T] selected tab fill #F3F3F3
    public override Color RibbonTabSelected4               { get; set; } = Color.FromArgb(243, 243, 243); // [T] selected tab fill #F3F3F3
    public override Color RibbonTabSelected5               { get; set; } = Color.FromArgb(243, 243, 243); // [T] selected tab fill #F3F3F3
    public override Color RibbonTabTracking1               { get; set; } = Color.FromArgb(44, 75, 122);   // [D] tab hover on accent row = [G] darker companion #2C4B7A (open item 1)
    public override Color RibbonTabTracking2               { get; set; } = Color.FromArgb(44, 75, 122);   // [D] #2C4B7A ([G] darker companion)
    public override Color RibbonTabHighlight1              { get; set; } = Color.FromArgb(243, 243, 243); // [D] mirrors RibbonTabSelected1 (flat selected look)
    public override Color RibbonTabHighlight2              { get; set; } = Color.FromArgb(243, 243, 243); // [D] mirrors selected fill
    public override Color RibbonTabHighlight3              { get; set; } = Color.FromArgb(243, 243, 243); // [D] mirrors selected fill
    public override Color RibbonTabHighlight4              { get; set; } = Color.FromArgb(243, 243, 243); // [D] mirrors selected fill
    public override Color RibbonTabHighlight5              { get; set; } = Color.FromArgb(243, 243, 243); // [D] mirrors selected fill
    public override Color RibbonTabSeparatorColor          { get; set; } = Color.FromArgb(43, 87, 154);   // [D] accent — 2019 draws no tab separators on the accent row
    public override Color RibbonGroupsArea1                { get; set; } = Color.FromArgb(177, 177, 177); // [T] separator edge px #B1B1B1 (ribbon boundary)
    public override Color RibbonGroupsArea2                { get; set; } = Color.FromArgb(210, 210, 210); // [T] group separator line #D2D2D2
    public override Color RibbonGroupsArea3                { get; set; } = Color.FromArgb(210, 210, 210); // [T] group separator line #D2D2D2
    public override Color RibbonGroupsArea4                { get; set; } = Color.FromArgb(243, 243, 243); // [T] ribbon background #F3F3F3 ([H] rect 150,146)
    public override Color RibbonGroupsArea5                { get; set; } = Color.FromArgb(243, 243, 243); // [T] ribbon background #F3F3F3
    public override Color RibbonGroupBorder1               { get; set; } = GlobalStaticValues.EMPTY_COLOR; // [N]
    public override Color RibbonGroupBorder2               { get; set; } = GlobalStaticValues.EMPTY_COLOR; // [N]
    public override Color RibbonGroupTitle1                { get; set; } = GlobalStaticValues.EMPTY_COLOR; // [N]
    public override Color RibbonGroupTitle2                { get; set; } = GlobalStaticValues.EMPTY_COLOR; // [N]
    public override Color RibbonGroupBorderContext1        { get; set; } = GlobalStaticValues.EMPTY_COLOR; // [N]
    public override Color RibbonGroupBorderContext2        { get; set; } = GlobalStaticValues.EMPTY_COLOR; // [N]
    public override Color RibbonGroupTitleContext1         { get; set; } = GlobalStaticValues.EMPTY_COLOR; // [N]
    public override Color RibbonGroupTitleContext2         { get; set; } = GlobalStaticValues.EMPTY_COLOR; // [N]
    public override Color RibbonGroupDialogDark            { get; set; } = Color.FromArgb(102, 109, 124); // [N]
    public override Color RibbonGroupDialogLight           { get; set; } = Color.FromArgb(240, 240, 240); // [N]
    public override Color RibbonGroupTitleTracking1        { get; set; } = GlobalStaticValues.EMPTY_COLOR; // [N]
    public override Color RibbonGroupTitleTracking2        { get; set; } = GlobalStaticValues.EMPTY_COLOR; // [N]
    public override Color RibbonMinimizeBarDark            { get; set; } = Color.FromArgb(210, 210, 210); // [T] group separator #D2D2D2
    public override Color RibbonMinimizeBarLight           { get; set; } = Color.FromArgb(243, 243, 243); // [T] ribbon background #F3F3F3
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
    public override Color RibbonGroupFrameBorder1          { get; set; } = Color.FromArgb(210, 210, 210); // [T] group separator line #D2D2D2
    public override Color RibbonGroupFrameBorder2          { get; set; } = Color.FromArgb(210, 210, 210); // [T] group separator line #D2D2D2
    public override Color RibbonGroupFrameInside1          { get; set; } = Color.FromArgb(254, 254, 254); // [N]
    public override Color RibbonGroupFrameInside2          { get; set; } = Color.FromArgb(254, 254, 254); // [N]
    public override Color RibbonGroupFrameInside3          { get; set; } = GlobalStaticValues.EMPTY_COLOR; // [N]
    public override Color RibbonGroupFrameInside4          { get; set; } = GlobalStaticValues.EMPTY_COLOR; // [N]
    public override Color RibbonGroupCollapsedText         { get; set; } = Color.FromArgb(38, 38, 38);    // [T] window text #262626
    public override Color RibbonGroupButtonText            { get; set; } = GlobalStaticValues.EMPTY_COLOR; // [N] missing value upstream
    public override Color AlternatePressedBack1            { get; set; } = Color.FromArgb(179, 185, 195); // [N]
    public override Color AlternatePressedBack2            { get; set; } = Color.FromArgb(216, 224, 224); // [N]
    public override Color AlternatePressedBorder1          { get; set; } = Color.FromArgb(125, 125, 125); // [N]
    public override Color AlternatePressedBorder2          { get; set; } = Color.FromArgb(186, 186, 186); // [N]
    public override Color FormButtonBack1Checked           { get; set; } = Color.FromArgb(44, 75, 122);   // [D] checked caption button = [G] darker companion #2C4B7A
    public override Color FormButtonBack2Checked           { get; set; } = Color.FromArgb(44, 75, 122);   // [D] #2C4B7A
    public override Color FormButtonBorderCheck            { get; set; } = Color.FromArgb(44, 75, 122);   // [D] #2C4B7A
    public override Color FormButtonBack1CheckTrack        { get; set; } = Color.FromArgb(32, 65, 116);   // [D] accent 25% toward black
    public override Color FormButtonBack2CheckTrack        { get; set; } = Color.FromArgb(32, 65, 116);   // [D] accent 25% toward black
    public override Color RibbonQATMini1                   { get; set; } = Color.FromArgb(43, 87, 154);   // [D] QAT minibar sits on the accent title bar #2B579A
    public override Color RibbonQATMini2                   { get; set; } = Color.FromArgb(43, 87, 154);   // [D] accent #2B579A
    public override Color RibbonQATMini3                   { get; set; } = Color.FromArgb(43, 87, 154);   // [D] accent #2B579A
    public override Color RibbonQATMini4                   { get; set; } = Color.FromArgb(10, Color.White); // [N]
    public override Color RibbonQATMini5                   { get; set; } = Color.FromArgb(32, Color.White); // [N]
    public override Color RibbonQATMini1I                  { get; set; } = Color.FromArgb(200, 200, 200); // [N] inactive — open item 3
    public override Color RibbonQATMini2I                  { get; set; } = Color.FromArgb(233, 234, 238); // [N] inactive — open item 3
    public override Color RibbonQATMini3I                  { get; set; } = Color.FromArgb(223, 224, 228); // [N] inactive — open item 3
    public override Color RibbonQATMini4I                  { get; set; } = Color.FromArgb(10, Color.White); // [N]
    public override Color RibbonQATMini5I                  { get; set; } = Color.FromArgb(32, Color.White); // [N]
    public override Color RibbonQATFullbar1                { get; set; } = Color.FromArgb(243, 243, 243); // [T] chrome neutral #F3F3F3
    public override Color RibbonQATFullbar2                { get; set; } = Color.FromArgb(243, 243, 243); // [T] chrome neutral #F3F3F3
    public override Color RibbonQATFullbar3                { get; set; } = Color.FromArgb(177, 177, 177); // [T] separator edge px #B1B1B1
    public override Color RibbonQATButtonDark              { get; set; } = Color.FromArgb(176, 182, 188); // [N]
    public override Color RibbonQATButtonLight             { get; set; } = Color.FromArgb(223, 223, 223); // [N]
    public override Color RibbonQATOverflow1               { get; set; } = Color.FromArgb(233, 237, 241); // [N]
    public override Color RibbonQATOverflow2               { get; set; } = Color.FromArgb(138, 144, 150); // [N]
    public override Color RibbonGroupSeparatorDark         { get; set; } = Color.FromArgb(210, 210, 210); // [T] group separator #D2D2D2
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
    public override Color GridSheetColNormal1              { get; set; } = Color.FromArgb(230, 230, 230); // [T] Excel column headers #E6E6E6
    public override Color GridSheetColNormal2              { get; set; } = Color.FromArgb(230, 230, 230); // [T] Excel column headers #E6E6E6
    public override Color GridSheetColPressed1             { get; set; } = Color.FromArgb(210, 210, 210); // [D] header pressed — separator tone #D2D2D2 (hover open item 1)
    public override Color GridSheetColPressed2             { get; set; } = Color.FromArgb(210, 210, 210); // [D] #D2D2D2
    public override Color GridSheetColSelected1            { get; set; } = Color.FromArgb(205, 230, 247); // [T] selection tint #CDE6F7 (shared-era Outlook selected item)
    public override Color GridSheetColSelected2            { get; set; } = Color.FromArgb(205, 230, 247); // [T] #CDE6F7
    public override Color GridSheetRowNormal               { get; set; } = Color.FromArgb(230, 230, 230); // [T] Excel headers #E6E6E6
    public override Color GridSheetRowPressed              { get; set; } = Color.FromArgb(210, 210, 210); // [D] #D2D2D2
    public override Color GridSheetRowSelected             { get; set; } = Color.FromArgb(205, 230, 247); // [T] #CDE6F7
    public override Color GridDataCellBorder               { get; set; } = Color.FromArgb(212, 212, 212); // [T] Excel grid lines #D4D4D4
    public override Color GridDataCellSelected             { get; set; } = Color.FromArgb(205, 230, 247); // [T] selection tint #CDE6F7
    public override Color InputControlTextNormal           { get; set; } = Color.FromArgb(38, 38, 38);    // [T] window text #262626
    public override Color InputControlTextDisabled         { get; set; } = Color.FromArgb(168, 168, 168); // [N] light-theme disabled text — colour-table open item
    public override Color InputControlBorderNormal         { get; set; } = Color.FromArgb(212, 214, 217); // [N]
    public override Color InputControlBorderDisabled       { get; set; } = Color.FromArgb(187, 187, 187); // [N]
    public override Color InputControlBackNormal           { get; set; } = Color.FromArgb(255, 255, 255); // [N]
    public override Color InputControlBackDisabled         { get; set; } = Color.FromArgb(240, 240, 240); // [N]
    public override Color InputControlBackInactive         { get; set; } = Color.FromArgb(247, 247, 247); // [N]
    public override Color InputDropDownNormal1             { get; set; } = Color.Black;                   // [N]
    public override Color InputDropDownNormal2             { get; set; } = Color.Transparent;             // [N]
    public override Color InputDropDownDisabled1           { get; set; } = Color.FromArgb(172, 168, 153); // [N]
    public override Color InputDropDownDisabled2           { get; set; } = Color.Transparent;             // [N]
    public override Color ContextMenuHeadingBack           { get; set; } = Color.FromArgb(240, 242, 245); // [N] context menu — colour-table open item 2
    public override Color ContextMenuHeadingText           { get; set; } = Color.FromArgb(38, 38, 38);    // [T] window text #262626
    public override Color ContextMenuImageColumn           { get; set; } = Color.White;                   // [N] context menu — open item 2
    public override Color AppButtonBack1                   { get; set; } = Color.FromArgb(224, 227, 231); // [N] backstage — colour-table open item 2
    public override Color AppButtonBack2                   { get; set; } = Color.FromArgb(224, 227, 231); // [N] backstage — open item 2
    public override Color AppButtonBorder                  { get; set; } = Color.FromArgb(135, 140, 146); // [N] backstage — open item 2
    public override Color AppButtonOuter1                  { get; set; } = Color.FromArgb(224, 227, 231); // [N] backstage — open item 2
    public override Color AppButtonOuter2                  { get; set; } = Color.FromArgb(224, 227, 231); // [N] backstage — open item 2
    public override Color AppButtonOuter3                  { get; set; } = Color.FromArgb(224, 227, 231); // [N] backstage — open item 2
    public override Color AppButtonInner1                  { get; set; } = GlobalStaticValues.EMPTY_COLOR; // [N]
    public override Color AppButtonInner2                  { get; set; } = Color.FromArgb(135, 140, 146); // [N]
    public override Color AppButtonMenuDocsBack            { get; set; } = Color.White;                   // [N]
    public override Color AppButtonMenuDocsText            { get; set; } = Color.Black;                   // [N]
    public override Color SeparatorHighInternalBorder1     { get; set; } = Color.FromArgb(250, 253, 255); // [N]
    public override Color SeparatorHighInternalBorder2     { get; set; } = Color.FromArgb(227, 232, 237); // [N]
    public override Color RibbonGalleryBorder              { get; set; } = Color.FromArgb(210, 210, 210); // [T] group separator #D2D2D2
    public override Color RibbonGalleryBackNormal          { get; set; } = Color.FromArgb(255, 255, 255); // [N]
    public override Color RibbonGalleryBackTracking        { get; set; } = Color.FromArgb(255, 255, 255); // [N]
    public override Color RibbonGalleryBack1               { get; set; } = Color.FromArgb(250, 250, 250); // [N]
    public override Color RibbonGalleryBack2               { get; set; } = Color.FromArgb(228, 231, 235); // [N]
    public override Color RibbonTabTracking3               { get; set; } = Color.FromArgb(44, 75, 122);   // [D] #2C4B7A ([G] darker companion — hover open item 1)
    public override Color RibbonTabTracking4               { get; set; } = Color.FromArgb(44, 75, 122);   // [D] #2C4B7A
    public override Color RibbonGroupBorder3               { get; set; } = Color.FromArgb(210, 210, 210); // [T] group separator #D2D2D2
    public override Color RibbonGroupBorder4               { get; set; } = Color.FromArgb(210, 210, 210); // [T] group separator #D2D2D2
    public override Color RibbonGroupBorder5               { get; set; } = GlobalStaticValues.EMPTY_COLOR; // [N]
    public override Color RibbonGroupTitleText             { get; set; } = Color.FromArgb(126, 126, 126); // [T] ribbon group label text #7E7E7E ([H] rect 150,146)
    public override Color RibbonDropArrowLight             { get; set; } = Color.FromArgb(151, 156, 163); // [N]
    public override Color RibbonDropArrowDark              { get; set; } = Color.FromArgb(99, 59, 59);    // [N]
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
    public override Color TrackBarTickMarks                { get; set; } = Color.FromArgb(38, 38, 38);    // [T] window text #262626 (donor Color.Red was a stray)
    public override Color TrackBarTopTrack                 { get; set; } = Color.FromArgb(166, 170, 175); // [N]
    public override Color TrackBarBottomTrack              { get; set; } = Color.FromArgb(226, 220, 235); // [N]
    public override Color TrackBarFillTrack                { get; set; } = Color.FromArgb(206, 200, 215); // [N]
    public override Color TrackBarOutsidePosition          { get; set; } = Color.FromArgb(64, Color.White); // [N]
    public override Color TrackBarBorderPosition           { get; set; } = Color.FromArgb(80, 81, 82);    // [N]
}
