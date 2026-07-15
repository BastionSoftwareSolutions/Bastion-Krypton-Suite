#region BSD License
/*
 * New (Bastion) file in a work derived from BSD-3-Clause licensed code:
 * © Component Factory Pty Ltd, 2006 - 2016. Then modifications by Peter Wagner (aka Wagnerp),
 * Simon Coghlan (aka Smurf-IV), Giduac, Ahmed Abdelhameed, Lesandro & tobitege et al. 2017 - 2026.
 * © Bastion Software Solutions Ltd 2026. All rights reserved.
 */
#endregion

// =====================================================================================
// Office 2021/2024 Colorful colour scheme (Bastion Phase 3 fidelity pass, spec §4.3).
//
// Provenance — every value is tagged:
//   [T] taken from docs\themes\office2021-colours.md ("App accent colours" +
//       "Colorful variant" tables; sources [J]/[K] with cross-era anchor [M],
//       reference images under docs\themes\references\office2021\).
//       Key values: accent = refreshed Word blue #185ABD (24,90,189) — [K] title
//       modal #195ABE (JPEG jitter), [J] Share button exact, [M] exact; ribbon tab
//       row #F0F0F0 (240,240,240) — NEUTRAL in 2021, the accent stays on the title
//       bar only; ribbon card #FFFFFF; app frame / document surround #F0F0F0;
//       status bar #F5F5F5 (245,245,245); tab text #262626 (38,38,38); group label
//       #666666 (102,102,102) band; group separator #E1E1E1 (225,225,225) band;
//       toolbar strip #FFFFFF ([K] powerpoint-colorful rect 260,102); Excel column
//       headers #F0F0F0; selection tint #CDE6F7 (Outlook selected item).
//   [D] derived — rule stated inline. Hover/pressed fills, backstage, context menus
//       and inactive-window colours are open items 3/4 in the colour table (not
//       visible in static imagery) and await Chris's live-install screenshots.
//       Accent companions come from the cross-era anchor [M]: hover #1651AA (22,81,
//       170 — the [M] Word underline shade of the same accent system), pressed =
//       accent 25% toward black #12448E (18,68,142; same rule as the 2019 pass).
//   [N] donor value from PaletteOffice2019Colorful_BaseScheme — era-neutral slot
//       with no 2021-specific evidence.
// =====================================================================================

namespace Krypton.Toolkit;

public sealed class PaletteOffice2021Colorful_BaseScheme : KryptonColorSchemeBase
{
    public override Color TextLabelControl                 { get; set; } = Color.FromArgb(38, 38, 38);    // [T] window text (tab-text band) #262626
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
    public override Color PanelClient                      { get; set; } = Color.White;                   // [T] ribbon card #FFFFFF — this pipeline fills the ribbon body with PanelClient (2019-pass note), so it carries the signature white card
    public override Color PanelAlternative                 { get; set; } = Color.FromArgb(240, 240, 240); // [T] app frame / document surround #F0F0F0 ([J] rect 1600,550 uniform)
    public override Color ControlBorder                    { get; set; } = Color.FromArgb(209, 209, 209); // [D] card edge #D1D1D1 from cross-era anchor [M] (2021 separators are the lighter #E1E1E1 band)
    public override Color SeparatorHighBorder1             { get; set; } = Color.FromArgb(250, 253, 255); // [N]
    public override Color SeparatorHighBorder2             { get; set; } = Color.FromArgb(227, 232, 237); // [N]
    public override Color HeaderPrimaryBack1               { get; set; } = Color.FromArgb(240, 240, 240); // [T] frame neutral #F0F0F0
    public override Color HeaderPrimaryBack2               { get; set; } = Color.FromArgb(240, 240, 240); // [T] frame neutral #F0F0F0
    public override Color HeaderSecondaryBack1             { get; set; } = Color.FromArgb(245, 245, 245); // [T] status neutral #F5F5F5
    public override Color HeaderSecondaryBack2             { get; set; } = Color.FromArgb(245, 245, 245); // [T] status neutral #F5F5F5
    public override Color HeaderText                       { get; set; } = Color.FromArgb(38, 38, 38);    // [T] window text #262626
    public override Color StatusStripText                  { get; set; } = Color.FromArgb(97, 97, 97);    // [D] status text #616161 band from cross-era anchor [M]
    public override Color ButtonBorder                     { get; set; } = Color.FromArgb(236, 199, 87);  // [N] hover border — hover/pressed fills are colour-table open item 3
    public override Color SeparatorLight                   { get; set; } = Color.FromArgb(247, 250, 252); // [N]
    public override Color SeparatorDark                    { get; set; } = Color.FromArgb(119, 123, 127); // [N]
    public override Color GripLight                        { get; set; } = Color.FromArgb(191, 191, 191); // [N]
    public override Color GripDark                         { get; set; } = Color.FromArgb(191, 191, 191); // [N]
    public override Color ToolStripBack                    { get; set; } = Color.White;                   // [T] toolbar strip #FFFFFF ([K] colorful rect 260,102 — strip merges into the white card)
    public override Color StatusStripLight                 { get; set; } = Color.FromArgb(245, 245, 245); // [T] status bar #F5F5F5 ([J] uniform, all four apps)
    public override Color StatusStripDark                  { get; set; } = Color.FromArgb(245, 245, 245); // [T] status bar #F5F5F5
    public override Color ImageMargin                      { get; set; } = Color.White;                   // [N]
    public override Color ToolStripBegin                   { get; set; } = Color.White;                   // [T] toolbar strip #FFFFFF
    public override Color ToolStripMiddle                  { get; set; } = Color.White;                   // [T] toolbar strip #FFFFFF
    public override Color ToolStripEnd                     { get; set; } = Color.White;                   // [T] toolbar strip #FFFFFF
    public override Color OverflowBegin                    { get; set; } = Color.FromArgb(209, 209, 209); // [D] card edge tone #D1D1D1 for overflow chrome
    public override Color OverflowMiddle                   { get; set; } = Color.FromArgb(209, 209, 209); // [D] #D1D1D1
    public override Color OverflowEnd                      { get; set; } = Color.FromArgb(209, 209, 209); // [D] #D1D1D1
    public override Color ToolStripBorder                  { get; set; } = Color.FromArgb(225, 225, 225); // [T] group separator band #E1E1E1
    public override Color FormBorderActive                 { get; set; } = Color.FromArgb(24, 90, 189);   // [T] app accent (Word) #185ABD — active frame
    public override Color FormBorderInactive               { get; set; } = Color.FromArgb(134, 139, 145); // [N] inactive frame — colour-table open item 3
    public override Color FormBorderActiveLight            { get; set; } = Color.FromArgb(24, 90, 189);   // [T] accent #185ABD (flat frame)
    public override Color FormBorderActiveDark             { get; set; } = Color.FromArgb(24, 90, 189);   // [T] accent #185ABD (flat frame)
    public override Color FormBorderInactiveLight          { get; set; } = Color.FromArgb(248, 247, 247); // [N] inactive — open item 3
    public override Color FormBorderInactiveDark           { get; set; } = Color.FromArgb(248, 247, 247); // [N] inactive — open item 3
    public override Color FormBorderHeaderActive           { get; set; } = Color.FromArgb(24, 90, 189);   // [T] accent #185ABD — caption merges into chrome, no divider
    public override Color FormBorderHeaderInactive         { get; set; } = Color.FromArgb(134, 139, 145); // [N] inactive — open item 3
    public override Color FormBorderHeaderActive1          { get; set; } = Color.FromArgb(24, 90, 189);   // [T] title bar active = accent #185ABD ([K]/[J]/[M])
    public override Color FormBorderHeaderActive2          { get; set; } = Color.FromArgb(24, 90, 189);   // [T] title bar active = accent #185ABD
    public override Color FormBorderHeaderInactive1        { get; set; } = Color.FromArgb(248, 247, 247); // [N] inactive — open item 3
    public override Color FormBorderHeaderInactive2        { get; set; } = Color.FromArgb(248, 247, 247); // [N] inactive — open item 3
    public override Color FormHeaderShortActive            { get; set; } = Color.White;                   // [T] title bar text #FFFFFF
    public override Color FormHeaderShortInactive          { get; set; } = Color.FromArgb(138, 138, 138); // [N] inactive — open item 3
    public override Color FormHeaderLongActive             { get; set; } = Color.White;                   // [T] title bar text #FFFFFF
    public override Color FormHeaderLongInactive           { get; set; } = Color.FromArgb(138, 138, 138); // [N] inactive — open item 3
    public override Color FormButtonBorderTrack            { get; set; } = Color.FromArgb(22, 81, 170);   // [D] caption hover = [M] darker companion #1651AA (hover open item 3)
    public override Color FormButtonBack1Track             { get; set; } = Color.FromArgb(22, 81, 170);   // [D] #1651AA ([M] darker companion)
    public override Color FormButtonBack2Track             { get; set; } = Color.FromArgb(22, 81, 170);   // [D] #1651AA ([M] darker companion)
    public override Color FormButtonBorderPressed          { get; set; } = Color.FromArgb(18, 68, 142);   // [D] pressed = accent blended 25% toward black
    public override Color FormButtonBack1Pressed           { get; set; } = Color.FromArgb(18, 68, 142);   // [D] accent 25% toward black
    public override Color FormButtonBack2Pressed           { get; set; } = Color.FromArgb(18, 68, 142);   // [D] accent 25% toward black
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
    public override Color RibbonTabTextNormal              { get; set; } = Color.FromArgb(38, 38, 38);    // [T] tab text #262626 — dark text on the NEUTRAL 2021 tab row
    public override Color RibbonTabTextChecked             { get; set; } = Color.FromArgb(24, 90, 189);   // [T] selected tab text = accent #185ABD (underline recorded as accent)
    public override Color RibbonTabSelected1               { get; set; } = Color.White;                   // [D] selected tab merges into the white ribbon card
    public override Color RibbonTabSelected2               { get; set; } = Color.White;                   // [D] white card fill
    public override Color RibbonTabSelected3               { get; set; } = Color.White;                   // [D] white card fill
    public override Color RibbonTabSelected4               { get; set; } = Color.White;                   // [D] white card fill
    public override Color RibbonTabSelected5               { get; set; } = Color.White;                   // [D] white card fill
    public override Color RibbonTabTracking1               { get; set; } = Color.FromArgb(232, 232, 232); // [D] tab hover = tab row #F0F0F0 −8/channel (hover open item 3)
    public override Color RibbonTabTracking2               { get; set; } = Color.FromArgb(232, 232, 232); // [D] #E8E8E8
    public override Color RibbonTabHighlight1              { get; set; } = Color.White;                   // [D] mirrors RibbonTabSelected1 (flat selected look)
    public override Color RibbonTabHighlight2              { get; set; } = Color.White;                   // [D] mirrors selected fill
    public override Color RibbonTabHighlight3              { get; set; } = Color.White;                   // [D] mirrors selected fill
    public override Color RibbonTabHighlight4              { get; set; } = Color.White;                   // [D] mirrors selected fill
    public override Color RibbonTabHighlight5              { get; set; } = Color.White;                   // [D] mirrors selected fill
    public override Color RibbonTabSeparatorColor          { get; set; } = Color.FromArgb(240, 240, 240); // [D] tab row #F0F0F0 — 2021 draws no tab separators
    public override Color RibbonGroupsArea1                { get; set; } = Color.FromArgb(225, 225, 225); // [T] separator band #E1E1E1 (card boundary)
    public override Color RibbonGroupsArea2                { get; set; } = Color.FromArgb(225, 225, 225); // [T] group separator #E1E1E1
    public override Color RibbonGroupsArea3                { get; set; } = Color.FromArgb(225, 225, 225); // [T] group separator #E1E1E1
    public override Color RibbonGroupsArea4                { get; set; } = Color.White;                   // [T] ribbon card #FFFFFF ([K] rect 300,176; [J] rect 300,160)
    public override Color RibbonGroupsArea5                { get; set; } = Color.White;                   // [T] ribbon card #FFFFFF
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
    public override Color RibbonMinimizeBarDark            { get; set; } = Color.FromArgb(225, 225, 225); // [T] group separator #E1E1E1
    public override Color RibbonMinimizeBarLight           { get; set; } = Color.White;                   // [T] ribbon card #FFFFFF
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
    public override Color RibbonGroupFrameBorder1          { get; set; } = Color.FromArgb(225, 225, 225); // [T] group separator #E1E1E1
    public override Color RibbonGroupFrameBorder2          { get; set; } = Color.FromArgb(225, 225, 225); // [T] group separator #E1E1E1
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
    public override Color FormButtonBack1Checked           { get; set; } = Color.FromArgb(22, 81, 170);   // [D] checked caption button = [M] darker companion #1651AA
    public override Color FormButtonBack2Checked           { get; set; } = Color.FromArgb(22, 81, 170);   // [D] #1651AA
    public override Color FormButtonBorderCheck            { get; set; } = Color.FromArgb(22, 81, 170);   // [D] #1651AA
    public override Color FormButtonBack1CheckTrack        { get; set; } = Color.FromArgb(18, 68, 142);   // [D] accent 25% toward black
    public override Color FormButtonBack2CheckTrack        { get; set; } = Color.FromArgb(18, 68, 142);   // [D] accent 25% toward black
    public override Color RibbonQATMini1                   { get; set; } = Color.FromArgb(24, 90, 189);   // [D] QAT minibar sits on the accent title bar #185ABD
    public override Color RibbonQATMini2                   { get; set; } = Color.FromArgb(24, 90, 189);   // [D] accent #185ABD
    public override Color RibbonQATMini3                   { get; set; } = Color.FromArgb(24, 90, 189);   // [D] accent #185ABD
    public override Color RibbonQATMini4                   { get; set; } = Color.FromArgb(10, Color.White); // [N]
    public override Color RibbonQATMini5                   { get; set; } = Color.FromArgb(32, Color.White); // [N]
    public override Color RibbonQATMini1I                  { get; set; } = Color.FromArgb(200, 200, 200); // [N] inactive — open item 3
    public override Color RibbonQATMini2I                  { get; set; } = Color.FromArgb(233, 234, 238); // [N] inactive — open item 3
    public override Color RibbonQATMini3I                  { get; set; } = Color.FromArgb(223, 224, 228); // [N] inactive — open item 3
    public override Color RibbonQATMini4I                  { get; set; } = Color.FromArgb(10, Color.White); // [N]
    public override Color RibbonQATMini5I                  { get; set; } = Color.FromArgb(32, Color.White); // [N]
    public override Color RibbonQATFullbar1                { get; set; } = Color.White;                   // [T] toolbar strip #FFFFFF (merges into card)
    public override Color RibbonQATFullbar2                { get; set; } = Color.White;                   // [T] toolbar strip #FFFFFF
    public override Color RibbonQATFullbar3                { get; set; } = Color.FromArgb(225, 225, 225); // [T] group separator #E1E1E1
    public override Color RibbonQATButtonDark              { get; set; } = Color.FromArgb(176, 182, 188); // [N]
    public override Color RibbonQATButtonLight             { get; set; } = Color.FromArgb(223, 223, 223); // [N]
    public override Color RibbonQATOverflow1               { get; set; } = Color.FromArgb(233, 237, 241); // [N]
    public override Color RibbonQATOverflow2               { get; set; } = Color.FromArgb(138, 144, 150); // [N]
    public override Color RibbonGroupSeparatorDark         { get; set; } = Color.FromArgb(225, 225, 225); // [T] group separator #E1E1E1
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
    public override Color GridSheetColNormal1              { get; set; } = Color.FromArgb(240, 240, 240); // [T] Excel column headers #F0F0F0 ([J] rect 2200,220)
    public override Color GridSheetColNormal2              { get; set; } = Color.FromArgb(240, 240, 240); // [T] Excel column headers #F0F0F0
    public override Color GridSheetColPressed1             { get; set; } = Color.FromArgb(225, 225, 225); // [D] header pressed — separator tone #E1E1E1 (hover open item 3)
    public override Color GridSheetColPressed2             { get; set; } = Color.FromArgb(225, 225, 225); // [D] #E1E1E1
    public override Color GridSheetColSelected1            { get; set; } = Color.FromArgb(205, 230, 247); // [T] selection tint #CDE6F7 ([J] Outlook selected item)
    public override Color GridSheetColSelected2            { get; set; } = Color.FromArgb(205, 230, 247); // [T] #CDE6F7
    public override Color GridSheetRowNormal               { get; set; } = Color.FromArgb(240, 240, 240); // [T] Excel headers #F0F0F0
    public override Color GridSheetRowPressed              { get; set; } = Color.FromArgb(225, 225, 225); // [D] #E1E1E1
    public override Color GridSheetRowSelected             { get; set; } = Color.FromArgb(205, 230, 247); // [T] #CDE6F7
    public override Color GridDataCellBorder               { get; set; } = Color.FromArgb(212, 212, 212); // [N] donor 2019 Excel grid lines #D4D4D4 (not sampled for 2021)
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
    public override Color ContextMenuHeadingBack           { get; set; } = Color.FromArgb(240, 242, 245); // [N] context menu — colour-table open item 3
    public override Color ContextMenuHeadingText           { get; set; } = Color.FromArgb(38, 38, 38);    // [T] window text #262626
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
    public override Color RibbonGalleryBorder              { get; set; } = Color.FromArgb(225, 225, 225); // [T] group separator #E1E1E1
    public override Color RibbonGalleryBackNormal          { get; set; } = Color.FromArgb(255, 255, 255); // [N]
    public override Color RibbonGalleryBackTracking        { get; set; } = Color.FromArgb(255, 255, 255); // [N]
    public override Color RibbonGalleryBack1               { get; set; } = Color.FromArgb(250, 250, 250); // [N]
    public override Color RibbonGalleryBack2               { get; set; } = Color.FromArgb(228, 231, 235); // [N]
    public override Color RibbonTabTracking3               { get; set; } = Color.FromArgb(232, 232, 232); // [D] tab hover #E8E8E8 (row −8/channel — hover open item 3)
    public override Color RibbonTabTracking4               { get; set; } = Color.FromArgb(232, 232, 232); // [D] #E8E8E8
    public override Color RibbonGroupBorder3               { get; set; } = Color.FromArgb(225, 225, 225); // [T] group separator #E1E1E1
    public override Color RibbonGroupBorder4               { get; set; } = Color.FromArgb(225, 225, 225); // [T] group separator #E1E1E1
    public override Color RibbonGroupBorder5               { get; set; } = GlobalStaticValues.EMPTY_COLOR; // [N]
    public override Color RibbonGroupTitleText             { get; set; } = Color.FromArgb(102, 102, 102); // [T] group label text #666666 band ([J]/[K] label rows)
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
    public override Color TrackBarTickMarks                { get; set; } = Color.FromArgb(38, 38, 38);    // [T] window text #262626
    public override Color TrackBarTopTrack                 { get; set; } = Color.FromArgb(166, 170, 175); // [N]
    public override Color TrackBarBottomTrack              { get; set; } = Color.FromArgb(226, 220, 235); // [N]
    public override Color TrackBarFillTrack                { get; set; } = Color.FromArgb(206, 200, 215); // [N]
    public override Color TrackBarOutsidePosition          { get; set; } = Color.FromArgb(64, Color.White); // [N]
    public override Color TrackBarBorderPosition           { get; set; } = Color.FromArgb(80, 81, 82);    // [N]
}
