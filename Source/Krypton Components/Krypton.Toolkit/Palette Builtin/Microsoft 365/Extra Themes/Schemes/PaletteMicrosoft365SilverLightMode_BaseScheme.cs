#region BSD License
/*
 *
 *  New BSD 3-Clause License (https://github.com/Krypton-Suite/Standard-Toolkit/blob/master/LICENSE)
 *  Modifications by Peter Wagner (aka Wagnerp), Simon Coghlan (aka Smurf-IV), Giduac, Ahmed Abdelhameed, tobitege et al. 2025 - 2025. All rights reserved.
 *  Microsoft 365 (2026) refresh © Bastion Software Solutions Ltd 2026. All rights reserved.
 *
 */
#endregion

// =====================================================================================
// Microsoft 365 "Silver Light Mode" colour scheme — 2026 refresh (Bastion Phase 3,
// spec §4.2 item 4).
//
// VARIANT MAPPING (Bastion decision): no real-2026 counterpart; kept as a Krypton
// convenience DERIVED from the refreshed Silver: the cool #DCE0E4 frame is swapped for
// the plain (cast-free) #E4E4E4 scroll-gutter neutral of the 2026 ladder — the
// "lightest, flattest" companion. All other values are Silver's (themselves derived
// from the real "White" mapping). Pre-refresh look preserved in
// docs\themes\comparisons\placeholder\Microsoft365SilverLightMode.png.
//
// Provenance tags: [T] = value identical to a docs\themes\m365-2026-colours.md table
// value; [D] = derived (rule inline or the frame-swap rule above); [N] = donor value
// from the 2021 fidelity pass with no 2026-specific evidence.
// =====================================================================================

namespace Krypton.Toolkit;

public sealed class PaletteMicrosoft365SilverLightMode_BaseScheme : KryptonColorSchemeBase
{
    public override Color TextLabelControl                 { get; set; } = Color.FromArgb(36, 36, 36);    // [T] window/tab text #242424
    public override Color TextButtonNormal                 { get; set; } = Color.FromArgb(36, 36, 36);    // [T] window text #242424
    public override Color TextButtonChecked                { get; set; } = Color.FromArgb(36, 36, 36);    // [T] window text #242424
    public override Color ButtonNormalBorder               { get; set; } = Color.FromArgb(138, 138, 138); // [T] control border #8A8A8A
    public override Color ButtonNormalDefaultBorder        { get; set; } = Color.FromArgb(138, 138, 138); // [T] control border #8A8A8A
    public override Color ButtonNormalBack1                { get; set; } = Color.White;                   // [D] flat controls merge into the white card
    public override Color ButtonNormalBack2                { get; set; } = Color.White;                   // [D] white card
    public override Color ButtonNormalDefaultBack1         { get; set; } = Color.White;                   // [D] white card
    public override Color ButtonNormalDefaultBack2         { get; set; } = Color.FromArgb(209, 209, 209); // [D] separator tone #D1D1D1 emphasises the default button
    public override Color ButtonNormalNavigatorBack1       { get; set; } = Color.FromArgb(207, 212, 218); // [N]
    public override Color ButtonNormalNavigatorBack2       { get; set; } = Color.FromArgb(207, 212, 218); // [N]
    public override Color PanelClient                      { get; set; } = Color.White;                   // [T] ribbon card #FFFFFF — the pipeline fills the ribbon body with PanelClient (2019-pass note)
    public override Color PanelAlternative                 { get; set; } = Color.FromArgb(228, 228, 228); // [D] document surround #E9EDF2/#E4E4E4 family
    public override Color ControlBorder                    { get; set; } = Color.FromArgb(209, 209, 209); // [T] group separator / card edge #D1D1D1
    public override Color SeparatorHighBorder1             { get; set; } = Color.FromArgb(250, 253, 255); // [N]
    public override Color SeparatorHighBorder2             { get; set; } = Color.FromArgb(227, 232, 237); // [N]
    public override Color HeaderPrimaryBack1               { get; set; } = Color.FromArgb(228, 228, 228); // [D] frame neutral #E4E4E4
    public override Color HeaderPrimaryBack2               { get; set; } = Color.FromArgb(228, 228, 228); // [D] frame neutral #E4E4E4
    public override Color HeaderSecondaryBack1             { get; set; } = Color.FromArgb(245, 245, 245); // [T] status neutral #F5F5F5
    public override Color HeaderSecondaryBack2             { get; set; } = Color.FromArgb(245, 245, 245); // [T] status neutral #F5F5F5
    public override Color HeaderText                       { get; set; } = Color.FromArgb(36, 36, 36);    // [T] window text #242424
    public override Color StatusStripText                  { get; set; } = Color.FromArgb(97, 97, 97);    // [T] status text #616161 band ([W], verify open item 1)
    public override Color ButtonBorder                     { get; set; } = Color.FromArgb(236, 199, 87);  // [N] hover border — hover/pressed fills are colour-table open item 2
    public override Color SeparatorLight                   { get; set; } = Color.FromArgb(247, 250, 252); // [N]
    public override Color SeparatorDark                    { get; set; } = Color.FromArgb(119, 123, 127); // [N]
    public override Color GripLight                        { get; set; } = Color.FromArgb(191, 191, 191); // [N]
    public override Color GripDark                         { get; set; } = Color.FromArgb(191, 191, 191); // [N]
    public override Color ToolStripBack                    { get; set; } = Color.White;                   // [D] toolbar strip merges into the white card (2021-pass rule)
    public override Color StatusStripLight                 { get; set; } = Color.FromArgb(245, 245, 245); // [T] status bar #F5F5F5
    public override Color StatusStripDark                  { get; set; } = Color.FromArgb(245, 245, 245); // [T] status bar #F5F5F5
    public override Color ImageMargin                      { get; set; } = Color.White;                   // [N]
    public override Color ToolStripBegin                   { get; set; } = Color.White;                   // [D] strip = white card
    public override Color ToolStripMiddle                  { get; set; } = Color.White;                   // [D] strip = white card
    public override Color ToolStripEnd                     { get; set; } = Color.White;                   // [D] strip = white card
    public override Color OverflowBegin                    { get; set; } = Color.FromArgb(209, 209, 209); // [D] card edge #D1D1D1 for overflow chrome
    public override Color OverflowMiddle                   { get; set; } = Color.FromArgb(209, 209, 209); // [D] #D1D1D1
    public override Color OverflowEnd                      { get; set; } = Color.FromArgb(209, 209, 209); // [D] #D1D1D1
    public override Color ToolStripBorder                  { get; set; } = Color.FromArgb(209, 209, 209); // [T] group separator #D1D1D1
    public override Color FormBorderActive                 { get; set; } = Color.FromArgb(228, 228, 228); // [D] flat neutral frame #E4E4E4 — no accent in White
    public override Color FormBorderInactive               { get; set; } = Color.FromArgb(134, 139, 145); // [N] inactive frame — colour-table open item 4
    public override Color FormBorderActiveLight            { get; set; } = Color.FromArgb(228, 228, 228); // [D] #E4E4E4 (flat frame)
    public override Color FormBorderActiveDark             { get; set; } = Color.FromArgb(228, 228, 228); // [D] #E4E4E4 (flat frame)
    public override Color FormBorderInactiveLight          { get; set; } = Color.FromArgb(248, 247, 247); // [N] inactive — open item 4
    public override Color FormBorderInactiveDark           { get; set; } = Color.FromArgb(248, 247, 247); // [N] inactive — open item 4
    public override Color FormBorderHeaderActive           { get; set; } = Color.FromArgb(228, 228, 228); // [D] #E4E4E4 — caption merges into chrome
    public override Color FormBorderHeaderInactive         { get; set; } = Color.FromArgb(134, 139, 145); // [N] inactive — open item 4
    public override Color FormBorderHeaderActive1          { get; set; } = Color.FromArgb(228, 228, 228); // [D] title bar #E4E4E4
    public override Color FormBorderHeaderActive2          { get; set; } = Color.FromArgb(228, 228, 228); // [D] title bar #E4E4E4
    public override Color FormBorderHeaderInactive1        { get; set; } = Color.FromArgb(248, 247, 247); // [N] inactive — open item 4
    public override Color FormBorderHeaderInactive2        { get; set; } = Color.FromArgb(248, 247, 247); // [N] inactive — open item 4
    public override Color FormHeaderShortActive            { get; set; } = Color.FromArgb(58, 58, 56);    // [T] title bar text #3A3A38 ([M4] rect 400,60 populations)
    public override Color FormHeaderShortInactive          { get; set; } = Color.FromArgb(138, 138, 138); // [N] inactive — open item 4
    public override Color FormHeaderLongActive             { get; set; } = Color.FromArgb(58, 58, 56);    // [T] title bar text #3A3A38
    public override Color FormHeaderLongInactive           { get; set; } = Color.FromArgb(138, 138, 138); // [N] inactive — open item 4
    public override Color FormButtonBorderTrack            { get; set; } = Color.FromArgb(209, 209, 209); // [D] caption hover = separator tone #D1D1D1 (hover open item 2)
    public override Color FormButtonBack1Track             { get; set; } = Color.FromArgb(209, 209, 209); // [D] #D1D1D1
    public override Color FormButtonBack2Track             { get; set; } = Color.FromArgb(209, 209, 209); // [D] #D1D1D1
    public override Color FormButtonBorderPressed          { get; set; } = Color.FromArgb(197, 201, 205); // [D] pressed = frame −23 step #C5C9CD
    public override Color FormButtonBack1Pressed           { get; set; } = Color.FromArgb(197, 201, 205); // [D] #C5C9CD
    public override Color FormButtonBack2Pressed           { get; set; } = Color.FromArgb(197, 201, 205); // [D] #C5C9CD
    public override Color TextButtonFormNormal             { get; set; } = Color.FromArgb(58, 58, 56);    // [T] caption glyph/text #3A3A38 on neutral frame
    public override Color TextButtonFormTracking           { get; set; } = Color.FromArgb(58, 58, 56);    // [T] #3A3A38 on neutral hover
    public override Color TextButtonFormPressed            { get; set; } = Color.FromArgb(58, 58, 56);    // [T] #3A3A38 on neutral pressed
    public override Color LinkNotVisitedOverrideControl    { get; set; } = Color.Blue;                    // [N]
    public override Color LinkVisitedOverrideControl       { get; set; } = Color.Purple;                  // [N]
    public override Color LinkPressedOverrideControl       { get; set; } = Color.Red;                     // [N]
    public override Color LinkNotVisitedOverridePanel      { get; set; } = Color.Blue;                    // [N]
    public override Color LinkVisitedOverridePanel         { get; set; } = Color.Purple;                  // [N]
    public override Color LinkPressedOverridePanel         { get; set; } = Color.Red;                     // [N]
    public override Color TextLabelPanel                   { get; set; } = Color.FromArgb(36, 36, 36);    // [T] window text #242424
    public override Color RibbonTabTextNormal              { get; set; } = Color.FromArgb(36, 36, 36);    // [T] tab text #242424 on the neutral #E9EEF2 tab row
    public override Color RibbonTabTextChecked             { get; set; } = Color.FromArgb(22, 81, 170);   // [D] canonical Word accent companion #1651AA ([M4]'s #B13719 is PPT's app accent)
    public override Color RibbonTabSelected1               { get; set; } = Color.White;                   // [D] selected tab merges into the white ribbon card
    public override Color RibbonTabSelected2               { get; set; } = Color.White;                   // [D] white card fill
    public override Color RibbonTabSelected3               { get; set; } = Color.White;                   // [D] white card fill
    public override Color RibbonTabSelected4               { get; set; } = Color.White;                   // [D] white card fill
    public override Color RibbonTabSelected5               { get; set; } = Color.White;                   // [D] white card fill
    public override Color RibbonTabTracking1               { get; set; } = Color.FromArgb(209, 209, 209); // [D] tab hover = separator tone #D1D1D1 (hover open item 2)
    public override Color RibbonTabTracking2               { get; set; } = Color.FromArgb(209, 209, 209); // [D] #D1D1D1
    public override Color RibbonTabHighlight1              { get; set; } = Color.White;                   // [D] mirrors RibbonTabSelected1 (flat selected look)
    public override Color RibbonTabHighlight2              { get; set; } = Color.White;                   // [D] mirrors selected fill
    public override Color RibbonTabHighlight3              { get; set; } = Color.White;                   // [D] mirrors selected fill
    public override Color RibbonTabHighlight4              { get; set; } = Color.White;                   // [D] mirrors selected fill
    public override Color RibbonTabHighlight5              { get; set; } = Color.White;                   // [D] mirrors selected fill
    public override Color RibbonTabSeparatorColor          { get; set; } = Color.FromArgb(228, 228, 228); // [D] tab row #E4E4E4 — 2026 draws no tab separators
    public override Color RibbonGroupsArea1                { get; set; } = Color.FromArgb(209, 209, 209); // [T] card edge #D1D1D1
    public override Color RibbonGroupsArea2                { get; set; } = Color.FromArgb(209, 209, 209); // [T] group separator #D1D1D1
    public override Color RibbonGroupsArea3                { get; set; } = Color.FromArgb(209, 209, 209); // [T] group separator #D1D1D1
    public override Color RibbonGroupsArea4                { get; set; } = Color.White;                   // [T] ribbon card #FFFFFF ([M4] rect 440,230)
    public override Color RibbonGroupsArea5                { get; set; } = Color.FromArgb(250, 250, 250); // [T] card gradient edge #FAFAFA ([M4])
    public override Color RibbonGroupBorder1               { get; set; } = GlobalStaticValues.EMPTY_COLOR; // [N]
    public override Color RibbonGroupBorder2               { get; set; } = GlobalStaticValues.EMPTY_COLOR; // [N]
    public override Color RibbonGroupTitle1                { get; set; } = GlobalStaticValues.EMPTY_COLOR; // [N]
    public override Color RibbonGroupTitle2                { get; set; } = GlobalStaticValues.EMPTY_COLOR; // [N]
    public override Color RibbonGroupBorderContext1        { get; set; } = GlobalStaticValues.EMPTY_COLOR; // [N]
    public override Color RibbonGroupBorderContext2        { get; set; } = GlobalStaticValues.EMPTY_COLOR; // [N]
    public override Color RibbonGroupTitleContext1         { get; set; } = GlobalStaticValues.EMPTY_COLOR; // [N]
    public override Color RibbonGroupTitleContext2         { get; set; } = GlobalStaticValues.EMPTY_COLOR; // [N]
    public override Color RibbonGroupDialogDark            { get; set; } = Color.FromArgb(102, 109, 124); // [N]
    public override Color RibbonGroupDialogLight           { get; set; } = Color.FromArgb(228, 228, 228); // [D] frame neutral #E4E4E4
    public override Color RibbonGroupTitleTracking1        { get; set; } = GlobalStaticValues.EMPTY_COLOR; // [N]
    public override Color RibbonGroupTitleTracking2        { get; set; } = GlobalStaticValues.EMPTY_COLOR; // [N]
    public override Color RibbonMinimizeBarDark            { get; set; } = Color.FromArgb(209, 209, 209); // [T] group separator #D1D1D1
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
    public override Color RibbonGroupFrameBorder1          { get; set; } = Color.FromArgb(209, 209, 209); // [T] group separator #D1D1D1
    public override Color RibbonGroupFrameBorder2          { get; set; } = Color.FromArgb(209, 209, 209); // [T] group separator #D1D1D1
    public override Color RibbonGroupFrameInside1          { get; set; } = Color.FromArgb(254, 254, 254); // [N]
    public override Color RibbonGroupFrameInside2          { get; set; } = Color.FromArgb(254, 254, 254); // [N]
    public override Color RibbonGroupFrameInside3          { get; set; } = GlobalStaticValues.EMPTY_COLOR; // [N]
    public override Color RibbonGroupFrameInside4          { get; set; } = GlobalStaticValues.EMPTY_COLOR; // [N]
    public override Color RibbonGroupCollapsedText         { get; set; } = Color.FromArgb(36, 36, 36);    // [T] window text #242424
    public override Color RibbonGroupButtonText            { get; set; } = Color.FromArgb(58, 58, 56);    // [T] ribbon control text #3A3A38
    public override Color AlternatePressedBack1            { get; set; } = Color.FromArgb(179, 185, 195); // [N]
    public override Color AlternatePressedBack2            { get; set; } = Color.FromArgb(216, 224, 224); // [N]
    public override Color AlternatePressedBorder1          { get; set; } = Color.FromArgb(125, 125, 125); // [N]
    public override Color AlternatePressedBorder2          { get; set; } = Color.FromArgb(186, 186, 186); // [N]
    public override Color FormButtonBack1Checked           { get; set; } = Color.FromArgb(197, 201, 205); // [D] checked caption button = frame −23 step #C5C9CD
    public override Color FormButtonBack2Checked           { get; set; } = Color.FromArgb(197, 201, 205); // [D] #C5C9CD
    public override Color FormButtonBorderCheck            { get; set; } = Color.FromArgb(197, 201, 205); // [D] #C5C9CD
    public override Color FormButtonBack1CheckTrack        { get; set; } = Color.FromArgb(209, 209, 209); // [D] check-hover steps to separator tone #D1D1D1
    public override Color FormButtonBack2CheckTrack        { get; set; } = Color.FromArgb(209, 209, 209); // [D] #D1D1D1
    public override Color RibbonQATMini1                   { get; set; } = Color.FromArgb(228, 228, 228); // [D] QAT minibar sits on the neutral title bar #E4E4E4
    public override Color RibbonQATMini2                   { get; set; } = Color.FromArgb(228, 228, 228); // [D] #E4E4E4
    public override Color RibbonQATMini3                   { get; set; } = Color.FromArgb(228, 228, 228); // [D] #E4E4E4
    public override Color RibbonQATMini4                   { get; set; } = Color.FromArgb(10, Color.White); // [N]
    public override Color RibbonQATMini5                   { get; set; } = Color.FromArgb(32, Color.White); // [N]
    public override Color RibbonQATMini1I                  { get; set; } = Color.FromArgb(200, 200, 200); // [N] inactive — open item 4
    public override Color RibbonQATMini2I                  { get; set; } = Color.FromArgb(233, 234, 238); // [N] inactive — open item 4
    public override Color RibbonQATMini3I                  { get; set; } = Color.FromArgb(223, 224, 228); // [N] inactive — open item 4
    public override Color RibbonQATMini4I                  { get; set; } = Color.FromArgb(10, Color.White); // [N]
    public override Color RibbonQATMini5I                  { get; set; } = Color.FromArgb(32, Color.White); // [N]
    public override Color RibbonQATFullbar1                { get; set; } = Color.White;                   // [D] full QAT bar merges into the white card
    public override Color RibbonQATFullbar2                { get; set; } = Color.White;                   // [D] white card
    public override Color RibbonQATFullbar3                { get; set; } = Color.FromArgb(209, 209, 209); // [T] group separator #D1D1D1
    public override Color RibbonQATButtonDark              { get; set; } = Color.FromArgb(176, 182, 188); // [N]
    public override Color RibbonQATButtonLight             { get; set; } = Color.FromArgb(223, 223, 223); // [N]
    public override Color RibbonQATOverflow1               { get; set; } = Color.FromArgb(233, 237, 241); // [N]
    public override Color RibbonQATOverflow2               { get; set; } = Color.FromArgb(138, 144, 150); // [N]
    public override Color RibbonGroupSeparatorDark         { get; set; } = Color.FromArgb(209, 209, 209); // [T] group separator #D1D1D1
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
    public override Color GridSheetColNormal1              { get; set; } = Color.FromArgb(228, 228, 228); // [D] grid headers take the frame neutral #E4E4E4
    public override Color GridSheetColNormal2              { get; set; } = Color.FromArgb(228, 228, 228); // [D] #E4E4E4
    public override Color GridSheetColPressed1             { get; set; } = Color.FromArgb(197, 201, 205); // [D] header pressed = frame −23 step #C5C9CD (hover open item 2)
    public override Color GridSheetColPressed2             { get; set; } = Color.FromArgb(197, 201, 205); // [D] #C5C9CD
    public override Color GridSheetColSelected1            { get; set; } = Color.FromArgb(205, 230, 247); // [N] selection tint #CDE6F7 (2021 donor; no 2026 sample)
    public override Color GridSheetColSelected2            { get; set; } = Color.FromArgb(205, 230, 247); // [N] #CDE6F7
    public override Color GridSheetRowNormal               { get; set; } = Color.FromArgb(228, 228, 228); // [D] frame neutral #E4E4E4
    public override Color GridSheetRowPressed              { get; set; } = Color.FromArgb(197, 201, 205); // [D] #C5C9CD
    public override Color GridSheetRowSelected             { get; set; } = Color.FromArgb(205, 230, 247); // [N] #CDE6F7
    public override Color GridDataCellBorder               { get; set; } = Color.FromArgb(212, 212, 212); // [N] donor grid lines #D4D4D4 family (not sampled for 2026)
    public override Color GridDataCellSelected             { get; set; } = Color.FromArgb(205, 230, 247); // [N] selection tint #CDE6F7
    public override Color InputControlTextNormal           { get; set; } = Color.FromArgb(58, 58, 56);    // [T] ribbon control text #3A3A38
    public override Color InputControlTextDisabled         { get; set; } = Color.FromArgb(168, 168, 168); // [N] light-theme disabled text — colour-table open item
    public override Color InputControlBorderNormal         { get; set; } = Color.FromArgb(138, 138, 138); // [T] control border #8A8A8A
    public override Color InputControlBorderDisabled       { get; set; } = Color.FromArgb(187, 187, 187); // [N]
    public override Color InputControlBackNormal           { get; set; } = Color.FromArgb(255, 255, 255); // [T] inputs stay white on the white card
    public override Color InputControlBackDisabled         { get; set; } = Color.FromArgb(240, 240, 240); // [N]
    public override Color InputControlBackInactive         { get; set; } = Color.FromArgb(247, 247, 247); // [N]
    public override Color InputDropDownNormal1             { get; set; } = Color.Black;                   // [N]
    public override Color InputDropDownNormal2             { get; set; } = Color.Transparent;             // [N]
    public override Color InputDropDownDisabled1           { get; set; } = Color.FromArgb(172, 168, 153); // [N]
    public override Color InputDropDownDisabled2           { get; set; } = Color.Transparent;             // [N]
    public override Color ContextMenuHeadingBack           { get; set; } = Color.FromArgb(240, 242, 245); // [N] context menu — colour-table open item 3
    public override Color ContextMenuHeadingText           { get; set; } = Color.FromArgb(36, 36, 36);    // [T] window text #242424
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
    public override Color RibbonGalleryBorder              { get; set; } = Color.FromArgb(209, 209, 209); // [T] group separator #D1D1D1
    public override Color RibbonGalleryBackNormal          { get; set; } = Color.FromArgb(255, 255, 255); // [D] gallery well = white card
    public override Color RibbonGalleryBackTracking        { get; set; } = Color.FromArgb(255, 255, 255); // [N]
    public override Color RibbonGalleryBack1               { get; set; } = Color.FromArgb(250, 250, 250); // [N]
    public override Color RibbonGalleryBack2               { get; set; } = Color.FromArgb(228, 231, 235); // [N]
    public override Color RibbonTabTracking3               { get; set; } = Color.FromArgb(209, 209, 209); // [D] tab hover = separator tone #D1D1D1 (hover open item 2)
    public override Color RibbonTabTracking4               { get; set; } = Color.FromArgb(209, 209, 209); // [D] #D1D1D1
    public override Color RibbonGroupBorder3               { get; set; } = Color.FromArgb(209, 209, 209); // [T] group separator #D1D1D1
    public override Color RibbonGroupBorder4               { get; set; } = Color.FromArgb(209, 209, 209); // [T] group separator #D1D1D1
    public override Color RibbonGroupBorder5               { get; set; } = GlobalStaticValues.EMPTY_COLOR; // [N]
    public override Color RibbonGroupTitleText             { get; set; } = Color.FromArgb(85, 87, 88);    // [T] group label text #555758 ([M4] label populations)
    public override Color RibbonDropArrowLight             { get; set; } = Color.FromArgb(151, 156, 163); // [N]
    public override Color RibbonDropArrowDark              { get; set; } = Color.FromArgb(58, 58, 56);    // [D] glyph = ribbon control text #3A3A38
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
    public override Color TrackBarTickMarks                { get; set; } = Color.FromArgb(36, 36, 36);    // [T] window text #242424
    public override Color TrackBarTopTrack                 { get; set; } = Color.FromArgb(166, 170, 175); // [N]
    public override Color TrackBarBottomTrack              { get; set; } = Color.FromArgb(185, 207, 235); // [D] accent 70% toward white
    public override Color TrackBarFillTrack                { get; set; } = Color.FromArgb(140, 173, 222); // [D] accent 50% toward white
    public override Color TrackBarOutsidePosition          { get; set; } = Color.FromArgb(64, Color.White); // [N]
    public override Color TrackBarBorderPosition           { get; set; } = Color.FromArgb(22, 81, 170);   // [D] accent companion #1651AA
}
