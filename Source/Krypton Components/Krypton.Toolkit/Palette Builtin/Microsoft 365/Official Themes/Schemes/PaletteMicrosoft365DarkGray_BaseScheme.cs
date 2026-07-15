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
// Microsoft 365 "Dark Gray" colour scheme — 2026 refresh (Bastion Phase 3, spec §4.2
// item 4).
//
// VARIANT MAPPING (Bastion decision): Microsoft365DarkGray is refreshed as the real
// M365 "DARK GRAY" variant — the deliberately blue-grey #54585A frame with the
// "contrasty controls" LIGHT #BDBDBD ribbon card. This palette was upstream TODO
// (never dispatched by KryptonManager); the 2026 refresh completes and wires it, so
// there is no placeholder capture — the mapping table records it as newly reachable.
//
// Provenance — every value is tagged:
//   [T] taken from docs\themes\m365-2026-colours.md ("Dark Gray variant" table,
//       source [M5] word-darkgray-theme.png).
//       Key values: title bar / app frame / tab row #54585A (84,88,90) with the
//       uniform band #52585D; outer frame edge #616161 (97,97,97); title/tab text
//       #FFFFFF; ribbon card #BDBDBD (189,189,189); ribbon control text #404040
//       (64,64,64); secondary text #666666 (102,102,102); on-ribbon accent (Word)
//       #244276 (36,66,118); selected-tab underline #AEC6F0 (174,198,240); document
//       page #FFFFFF.
//   [D] derived — rule stated inline. Card steps: control well = card +12/channel
//       #C9C9C9 (201,201,201); separators = card −24/channel #A5A5A5 (165,165,165)
//       (the 2021-pass step rules applied to the [M5] card). Frame steps: hover =
//       edge tone #616161; pressed = frame −10 #4A4D4F. The selected-tab accent uses
//       the on-ribbon #244276 (readable on the light card) rather than the #AEC6F0
//       underline, which is an on-frame tint. Status bar and hover/pressed states are
//       colour-table open items 1/2 (await Chris's live screenshots).
//   [N] donor value from the 2021-pass schemes (Colorful for light-canvas slots,
//       Black for dark-chrome slots) — era-neutral slot with no 2026-specific
//       evidence. Grids/lists keep a light canvas ("Grid canvas stays light", [M5]
//       document page white).
// =====================================================================================

namespace Krypton.Toolkit;

public sealed class PaletteMicrosoft365DarkGray_BaseScheme : KryptonColorSchemeBase
{
    public override Color TextLabelControl                 { get; set; } = Color.FromArgb(64, 64, 64);    // [T] ribbon control text #404040 (labels sit on the #BDBDBD card)
    public override Color TextButtonNormal                 { get; set; } = Color.FromArgb(64, 64, 64);    // [T] control text #404040
    public override Color TextButtonChecked                { get; set; } = Color.FromArgb(64, 64, 64);    // [T] control text #404040
    public override Color ButtonNormalBorder               { get; set; } = Color.FromArgb(138, 138, 138); // [D] control border #8A8A8A carried from the light variants (controls on the light card)
    public override Color ButtonNormalDefaultBorder        { get; set; } = Color.FromArgb(138, 138, 138); // [D] #8A8A8A
    public override Color ButtonNormalBack1                { get; set; } = Color.FromArgb(201, 201, 201); // [D] control well = card +12 #C9C9C9
    public override Color ButtonNormalBack2                { get; set; } = Color.FromArgb(201, 201, 201); // [D] #C9C9C9
    public override Color ButtonNormalDefaultBack1         { get; set; } = Color.FromArgb(201, 201, 201); // [D] control well #C9C9C9
    public override Color ButtonNormalDefaultBack2         { get; set; } = Color.FromArgb(165, 165, 165); // [D] separator step #A5A5A5 emphasises the default button
    public override Color ButtonNormalNavigatorBack1       { get; set; } = Color.FromArgb(207, 212, 218); // [N]
    public override Color ButtonNormalNavigatorBack2       { get; set; } = Color.FromArgb(207, 212, 218); // [N]
    public override Color PanelClient                      { get; set; } = Color.FromArgb(189, 189, 189); // [T] ribbon card #BDBDBD ([M5] rect 440,215 — 90% uniform)
    public override Color PanelAlternative                 { get; set; } = Color.FromArgb(84, 88, 90);    // [T] app frame / document surround #54585A
    public override Color ControlBorder                    { get; set; } = Color.FromArgb(165, 165, 165); // [D] separator = card −24 #A5A5A5
    public override Color SeparatorHighBorder1             { get; set; } = Color.FromArgb(172, 172, 172); // [N]
    public override Color SeparatorHighBorder2             { get; set; } = Color.FromArgb(111, 111, 111); // [N]
    public override Color HeaderPrimaryBack1               { get; set; } = Color.FromArgb(84, 88, 90);    // [T] frame #54585A
    public override Color HeaderPrimaryBack2               { get; set; } = Color.FromArgb(84, 88, 90);    // [T] frame #54585A
    public override Color HeaderSecondaryBack1             { get; set; } = Color.FromArgb(97, 97, 97);    // [T] outer frame edge #616161
    public override Color HeaderSecondaryBack2             { get; set; } = Color.FromArgb(97, 97, 97);    // [T] edge #616161
    public override Color HeaderText                       { get; set; } = Color.White;                   // [T] chrome text #FFFFFF
    public override Color StatusStripText                  { get; set; } = Color.White;                   // [D] status bar not captured (open item 1) — frame carries white text
    public override Color ButtonBorder                     { get; set; } = Color.FromArgb(236, 199, 87);  // [N] hover border — hover/pressed fills are colour-table open item 2
    public override Color SeparatorLight                   { get; set; } = Color.FromArgb(201, 201, 201); // [D] well #C9C9C9
    public override Color SeparatorDark                    { get; set; } = Color.FromArgb(84, 88, 90);    // [D] frame #54585A
    public override Color GripLight                        { get; set; } = Color.FromArgb(201, 201, 201); // [D] well #C9C9C9
    public override Color GripDark                         { get; set; } = Color.FromArgb(97, 97, 97);    // [D] edge #616161
    public override Color ToolStripBack                    { get; set; } = Color.FromArgb(189, 189, 189); // [D] toolbar strip merges into the card #BDBDBD
    public override Color StatusStripLight                 { get; set; } = Color.FromArgb(84, 88, 90);    // [D] frame #54585A (status open item 1)
    public override Color StatusStripDark                  { get; set; } = Color.FromArgb(84, 88, 90);    // [D] frame #54585A
    public override Color ImageMargin                      { get; set; } = Color.White;                   // [N]
    public override Color ToolStripBegin                   { get; set; } = Color.FromArgb(189, 189, 189); // [D] strip = card #BDBDBD
    public override Color ToolStripMiddle                  { get; set; } = Color.FromArgb(189, 189, 189); // [D] #BDBDBD
    public override Color ToolStripEnd                     { get; set; } = Color.FromArgb(189, 189, 189); // [D] #BDBDBD
    public override Color OverflowBegin                    { get; set; } = Color.FromArgb(165, 165, 165); // [D] separator #A5A5A5 for overflow chrome
    public override Color OverflowMiddle                   { get; set; } = Color.FromArgb(165, 165, 165); // [D] #A5A5A5
    public override Color OverflowEnd                      { get; set; } = Color.FromArgb(165, 165, 165); // [D] #A5A5A5
    public override Color ToolStripBorder                  { get; set; } = Color.FromArgb(165, 165, 165); // [D] separator #A5A5A5
    public override Color FormBorderActive                 { get; set; } = Color.FromArgb(97, 97, 97);    // [T] outer frame edge #616161
    public override Color FormBorderInactive               { get; set; } = Color.FromArgb(134, 139, 145); // [N] inactive frame — colour-table open item 4
    public override Color FormBorderActiveLight            { get; set; } = Color.FromArgb(84, 88, 90);    // [T] frame #54585A (flat frame)
    public override Color FormBorderActiveDark             { get; set; } = Color.FromArgb(84, 88, 90);    // [T] frame #54585A (flat frame)
    public override Color FormBorderInactiveLight          { get; set; } = Color.FromArgb(158, 158, 158); // [N] inactive — open item 4
    public override Color FormBorderInactiveDark           { get; set; } = Color.FromArgb(158, 158, 158); // [N] inactive — open item 4
    public override Color FormBorderHeaderActive           { get; set; } = Color.FromArgb(97, 97, 97);    // [T] edge #616161 — caption merges into chrome
    public override Color FormBorderHeaderInactive         { get; set; } = Color.FromArgb(154, 154, 154); // [N] inactive — open item 4
    public override Color FormBorderHeaderActive1          { get; set; } = Color.FromArgb(84, 88, 90);    // [T] title bar #54585A ([M5] rect 300,55)
    public override Color FormBorderHeaderActive2          { get; set; } = Color.FromArgb(84, 88, 90);    // [T] title bar #54585A
    public override Color FormBorderHeaderInactive1        { get; set; } = Color.FromArgb(158, 158, 158); // [N] inactive — open item 4
    public override Color FormBorderHeaderInactive2        { get; set; } = Color.FromArgb(158, 158, 158); // [N] inactive — open item 4
    public override Color FormHeaderShortActive            { get; set; } = Color.White;                   // [T] title bar text #FFFFFF
    public override Color FormHeaderShortInactive          { get; set; } = Color.FromArgb(211, 211, 211); // [D] inactive dimmed (open item 4)
    public override Color FormHeaderLongActive             { get; set; } = Color.White;                   // [T] title bar text #FFFFFF
    public override Color FormHeaderLongInactive           { get; set; } = Color.FromArgb(211, 211, 211); // [D] inactive dimmed (open item 4)
    public override Color FormButtonBorderTrack            { get; set; } = Color.FromArgb(97, 97, 97);    // [D] caption hover = edge tone #616161 (hover open item 2)
    public override Color FormButtonBack1Track             { get; set; } = Color.FromArgb(97, 97, 97);    // [D] #616161
    public override Color FormButtonBack2Track             { get; set; } = Color.FromArgb(97, 97, 97);    // [D] #616161
    public override Color FormButtonBorderPressed          { get; set; } = Color.FromArgb(74, 77, 79);    // [D] pressed = frame −10 #4A4D4F
    public override Color FormButtonBack1Pressed           { get; set; } = Color.FromArgb(74, 77, 79);    // [D] #4A4D4F
    public override Color FormButtonBack2Pressed           { get; set; } = Color.FromArgb(74, 77, 79);    // [D] #4A4D4F
    public override Color TextButtonFormNormal             { get; set; } = Color.White;                   // [T] caption glyph/text white on the dark frame
    public override Color TextButtonFormTracking           { get; set; } = Color.White;                   // [T] white on frame hover
    public override Color TextButtonFormPressed            { get; set; } = Color.White;                   // [T] white on frame pressed
    public override Color LinkNotVisitedOverrideControl    { get; set; } = Color.Blue;                    // [N]
    public override Color LinkVisitedOverrideControl       { get; set; } = Color.Purple;                  // [N]
    public override Color LinkPressedOverrideControl       { get; set; } = Color.Red;                     // [N]
    public override Color LinkNotVisitedOverridePanel      { get; set; } = Color.Blue;                    // [N] panels are the light #BDBDBD card
    public override Color LinkVisitedOverridePanel         { get; set; } = Color.Purple;                  // [N]
    public override Color LinkPressedOverridePanel         { get; set; } = Color.Red;                     // [N]
    public override Color TextLabelPanel                   { get; set; } = Color.FromArgb(64, 64, 64);    // [T] control text #404040 on the light card
    public override Color RibbonTabTextNormal              { get; set; } = Color.White;                   // [T] tab text #FFFFFF on the #54585A tab row
    public override Color RibbonTabTextChecked             { get; set; } = Color.FromArgb(36, 66, 118);   // [T] on-ribbon accent #244276 (readable on the light card; #AEC6F0 is the on-frame underline tint)
    public override Color RibbonTabSelected1               { get; set; } = Color.FromArgb(189, 189, 189); // [D] selected tab merges into the #BDBDBD ribbon card
    public override Color RibbonTabSelected2               { get; set; } = Color.FromArgb(189, 189, 189); // [D] card fill
    public override Color RibbonTabSelected3               { get; set; } = Color.FromArgb(189, 189, 189); // [D] card fill
    public override Color RibbonTabSelected4               { get; set; } = Color.FromArgb(189, 189, 189); // [D] card fill
    public override Color RibbonTabSelected5               { get; set; } = Color.FromArgb(189, 189, 189); // [D] card fill
    public override Color RibbonTabTracking1               { get; set; } = Color.FromArgb(97, 97, 97);    // [D] tab hover = edge tone #616161 (hover open item 2)
    public override Color RibbonTabTracking2               { get; set; } = Color.FromArgb(97, 97, 97);    // [D] #616161
    public override Color RibbonTabHighlight1              { get; set; } = Color.FromArgb(189, 189, 189); // [D] mirrors RibbonTabSelected1 (flat selected look)
    public override Color RibbonTabHighlight2              { get; set; } = Color.FromArgb(189, 189, 189); // [D] mirrors selected fill
    public override Color RibbonTabHighlight3              { get; set; } = Color.FromArgb(189, 189, 189); // [D] mirrors selected fill
    public override Color RibbonTabHighlight4              { get; set; } = Color.FromArgb(189, 189, 189); // [D] mirrors selected fill
    public override Color RibbonTabHighlight5              { get; set; } = Color.FromArgb(189, 189, 189); // [D] mirrors selected fill
    public override Color RibbonTabSeparatorColor          { get; set; } = Color.FromArgb(84, 88, 90);    // [D] tab row #54585A — 2026 draws no tab separators
    public override Color RibbonGroupsArea1                { get; set; } = Color.FromArgb(165, 165, 165); // [D] card edge #A5A5A5
    public override Color RibbonGroupsArea2                { get; set; } = Color.FromArgb(165, 165, 165); // [D] group separator #A5A5A5
    public override Color RibbonGroupsArea3                { get; set; } = Color.FromArgb(165, 165, 165); // [D] group separator #A5A5A5
    public override Color RibbonGroupsArea4                { get; set; } = Color.FromArgb(189, 189, 189); // [T] ribbon card #BDBDBD ([M5] rect 440,215)
    public override Color RibbonGroupsArea5                { get; set; } = Color.FromArgb(189, 189, 189); // [T] ribbon card #BDBDBD
    public override Color RibbonGroupBorder1               { get; set; } = GlobalStaticValues.EMPTY_COLOR; // [N]
    public override Color RibbonGroupBorder2               { get; set; } = GlobalStaticValues.EMPTY_COLOR; // [N]
    public override Color RibbonGroupTitle1                { get; set; } = GlobalStaticValues.EMPTY_COLOR; // [N]
    public override Color RibbonGroupTitle2                { get; set; } = GlobalStaticValues.EMPTY_COLOR; // [N]
    public override Color RibbonGroupBorderContext1        { get; set; } = GlobalStaticValues.EMPTY_COLOR; // [N]
    public override Color RibbonGroupBorderContext2        { get; set; } = GlobalStaticValues.EMPTY_COLOR; // [N]
    public override Color RibbonGroupTitleContext1         { get; set; } = GlobalStaticValues.EMPTY_COLOR; // [N]
    public override Color RibbonGroupTitleContext2         { get; set; } = GlobalStaticValues.EMPTY_COLOR; // [N]
    public override Color RibbonGroupDialogDark            { get; set; } = Color.FromArgb(64, 64, 64);    // [D] glyph = control text #404040
    public override Color RibbonGroupDialogLight           { get; set; } = Color.FromArgb(201, 201, 201); // [D] well #C9C9C9
    public override Color RibbonGroupTitleTracking1        { get; set; } = GlobalStaticValues.EMPTY_COLOR; // [N]
    public override Color RibbonGroupTitleTracking2        { get; set; } = GlobalStaticValues.EMPTY_COLOR; // [N]
    public override Color RibbonMinimizeBarDark            { get; set; } = Color.FromArgb(165, 165, 165); // [D] separator #A5A5A5
    public override Color RibbonMinimizeBarLight           { get; set; } = Color.FromArgb(189, 189, 189); // [D] card #BDBDBD
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
    public override Color RibbonGroupCollapsedBackT2       { get; set; } = Color.FromArgb(201, 201, 201); // [D] well #C9C9C9
    public override Color RibbonGroupCollapsedBackT3       { get; set; } = Color.FromArgb(195, 195, 195); // [D] card ladder step
    public override Color RibbonGroupCollapsedBackT4       { get; set; } = Color.FromArgb(189, 189, 189); // [D] card #BDBDBD
    public override Color RibbonGroupFrameBorder1          { get; set; } = Color.FromArgb(165, 165, 165); // [D] separator #A5A5A5
    public override Color RibbonGroupFrameBorder2          { get; set; } = Color.FromArgb(165, 165, 165); // [D] separator #A5A5A5
    public override Color RibbonGroupFrameInside1          { get; set; } = Color.FromArgb(201, 201, 201); // [D] well #C9C9C9
    public override Color RibbonGroupFrameInside2          { get; set; } = Color.FromArgb(201, 201, 201); // [D] well #C9C9C9
    public override Color RibbonGroupFrameInside3          { get; set; } = GlobalStaticValues.EMPTY_COLOR; // [N]
    public override Color RibbonGroupFrameInside4          { get; set; } = GlobalStaticValues.EMPTY_COLOR; // [N]
    public override Color RibbonGroupCollapsedText         { get; set; } = Color.FromArgb(64, 64, 64);    // [T] control text #404040
    public override Color RibbonGroupButtonText            { get; set; } = Color.FromArgb(64, 64, 64);    // [T] control text #404040
    public override Color AlternatePressedBack1            { get; set; } = Color.FromArgb(179, 185, 195); // [N]
    public override Color AlternatePressedBack2            { get; set; } = Color.FromArgb(216, 224, 224); // [N]
    public override Color AlternatePressedBorder1          { get; set; } = Color.FromArgb(125, 125, 125); // [N]
    public override Color AlternatePressedBorder2          { get; set; } = Color.FromArgb(186, 186, 186); // [N]
    public override Color FormButtonBack1Checked           { get; set; } = Color.FromArgb(97, 97, 97);    // [D] checked caption button = edge tone #616161
    public override Color FormButtonBack2Checked           { get; set; } = Color.FromArgb(97, 97, 97);    // [D] #616161
    public override Color FormButtonBorderCheck            { get; set; } = Color.FromArgb(97, 97, 97);    // [D] #616161
    public override Color FormButtonBack1CheckTrack        { get; set; } = Color.FromArgb(74, 77, 79);    // [D] check-hover = frame −10 #4A4D4F
    public override Color FormButtonBack2CheckTrack        { get; set; } = Color.FromArgb(74, 77, 79);    // [D] #4A4D4F
    public override Color RibbonQATMini1                   { get; set; } = Color.FromArgb(84, 88, 90);    // [D] QAT minibar sits on the #54585A title bar
    public override Color RibbonQATMini2                   { get; set; } = Color.FromArgb(84, 88, 90);    // [D] #54585A
    public override Color RibbonQATMini3                   { get; set; } = Color.FromArgb(84, 88, 90);    // [D] #54585A
    public override Color RibbonQATMini4                   { get; set; } = Color.FromArgb(10, Color.White); // [N]
    public override Color RibbonQATMini5                   { get; set; } = Color.FromArgb(32, Color.White); // [N]
    public override Color RibbonQATMini1I                  { get; set; } = Color.FromArgb(200, 200, 200); // [N] inactive — open item 4
    public override Color RibbonQATMini2I                  { get; set; } = Color.FromArgb(233, 234, 238); // [N] inactive — open item 4
    public override Color RibbonQATMini3I                  { get; set; } = Color.FromArgb(223, 224, 228); // [N] inactive — open item 4
    public override Color RibbonQATMini4I                  { get; set; } = Color.FromArgb(10, Color.White); // [N]
    public override Color RibbonQATMini5I                  { get; set; } = Color.FromArgb(32, Color.White); // [N]
    public override Color RibbonQATFullbar1                { get; set; } = Color.FromArgb(189, 189, 189); // [D] full QAT bar merges into the card #BDBDBD
    public override Color RibbonQATFullbar2                { get; set; } = Color.FromArgb(189, 189, 189); // [D] #BDBDBD
    public override Color RibbonQATFullbar3                { get; set; } = Color.FromArgb(165, 165, 165); // [D] separator #A5A5A5
    public override Color RibbonQATButtonDark              { get; set; } = Color.FromArgb(176, 182, 188); // [N]
    public override Color RibbonQATButtonLight             { get; set; } = Color.FromArgb(223, 223, 223); // [N]
    public override Color RibbonQATOverflow1               { get; set; } = Color.FromArgb(233, 237, 241); // [N]
    public override Color RibbonQATOverflow2               { get; set; } = Color.FromArgb(138, 144, 150); // [N]
    public override Color RibbonGroupSeparatorDark         { get; set; } = Color.FromArgb(165, 165, 165); // [D] separator #A5A5A5
    public override Color RibbonGroupSeparatorLight        { get; set; } = GlobalStaticValues.EMPTY_COLOR; // [N]
    public override Color ButtonClusterButtonBack1         { get; set; } = Color.FromArgb(231, 234, 238); // [N]
    public override Color ButtonClusterButtonBack2         { get; set; } = Color.FromArgb(241, 243, 243); // [N]
    public override Color ButtonClusterButtonBorder1       { get; set; } = Color.FromArgb(197, 198, 199); // [N]
    public override Color ButtonClusterButtonBorder2       { get; set; } = Color.FromArgb(157, 158, 159); // [N]
    public override Color NavigatorMiniBackColor           { get; set; } = Color.FromArgb(238, 238, 244); // [N]
    public override Color GridListNormal1                  { get; set; } = Color.White;                   // [N] grid canvas stays light ([M5] document page white)
    public override Color GridListNormal2                  { get; set; } = Color.White;                   // [N]
    public override Color GridListPressed1                 { get; set; } = Color.FromArgb(203, 207, 212); // [N]
    public override Color GridListPressed2                 { get; set; } = Color.White;                   // [N]
    public override Color GridListSelected                 { get; set; } = Color.FromArgb(186, 189, 194); // [N]
    public override Color GridSheetColNormal1              { get; set; } = Color.FromArgb(201, 201, 201); // [D] grid headers take the well tone #C9C9C9
    public override Color GridSheetColNormal2              { get; set; } = Color.FromArgb(201, 201, 201); // [D] #C9C9C9
    public override Color GridSheetColPressed1             { get; set; } = Color.FromArgb(165, 165, 165); // [D] header pressed = separator #A5A5A5 (hover open item 2)
    public override Color GridSheetColPressed2             { get; set; } = Color.FromArgb(165, 165, 165); // [D] #A5A5A5
    public override Color GridSheetColSelected1            { get; set; } = Color.FromArgb(174, 198, 240); // [T] accent tint #AEC6F0 ([M5] underline shade) as selection
    public override Color GridSheetColSelected2            { get; set; } = Color.FromArgb(174, 198, 240); // [T] #AEC6F0
    public override Color GridSheetRowNormal               { get; set; } = Color.FromArgb(201, 201, 201); // [D] well #C9C9C9
    public override Color GridSheetRowPressed              { get; set; } = Color.FromArgb(165, 165, 165); // [D] #A5A5A5
    public override Color GridSheetRowSelected             { get; set; } = Color.FromArgb(174, 198, 240); // [T] #AEC6F0
    public override Color GridDataCellBorder               { get; set; } = Color.FromArgb(212, 212, 212); // [N] donor grid lines (not sampled for 2026)
    public override Color GridDataCellSelected             { get; set; } = Color.FromArgb(174, 198, 240); // [D] accent tint #AEC6F0
    public override Color InputControlTextNormal           { get; set; } = Color.FromArgb(64, 64, 64);    // [T] control text #404040
    public override Color InputControlTextDisabled         { get; set; } = Color.FromArgb(139, 139, 139); // [D] disabled dimmed midway to the card
    public override Color InputControlBorderNormal         { get; set; } = Color.FromArgb(138, 138, 138); // [D] control border #8A8A8A (light-variant tone on the light card)
    public override Color InputControlBorderDisabled       { get; set; } = Color.FromArgb(165, 165, 165); // [D] separator #A5A5A5
    public override Color InputControlBackNormal           { get; set; } = Color.White;                   // [D] inputs stay white ([M5] document page #FFFFFF)
    public override Color InputControlBackDisabled         { get; set; } = Color.FromArgb(189, 189, 189); // [D] card #BDBDBD
    public override Color InputControlBackInactive         { get; set; } = Color.FromArgb(201, 201, 201); // [D] well #C9C9C9
    public override Color InputDropDownNormal1             { get; set; } = Color.FromArgb(64, 64, 64);    // [D] glyph = control text #404040
    public override Color InputDropDownNormal2             { get; set; } = Color.Transparent;             // [N]
    public override Color InputDropDownDisabled1           { get; set; } = Color.FromArgb(139, 139, 139); // [D] disabled glyph matches disabled text
    public override Color InputDropDownDisabled2           { get; set; } = Color.Transparent;             // [N]
    public override Color ContextMenuHeadingBack           { get; set; } = Color.FromArgb(240, 242, 245); // [N] context menu — colour-table open item 3
    public override Color ContextMenuHeadingText           { get; set; } = Color.FromArgb(64, 64, 64);    // [D] control text #404040
    public override Color ContextMenuImageColumn           { get; set; } = Color.FromArgb(239, 239, 239); // [N] context menu — open item 3
    public override Color AppButtonBack1                   { get; set; } = Color.FromArgb(201, 201, 201); // [D] backstage takes the well tone #C9C9C9 (open item 3)
    public override Color AppButtonBack2                   { get; set; } = Color.FromArgb(201, 201, 201); // [D] #C9C9C9 — open item 3
    public override Color AppButtonBorder                  { get; set; } = Color.FromArgb(138, 138, 138); // [D] #8A8A8A — open item 3
    public override Color AppButtonOuter1                  { get; set; } = Color.FromArgb(201, 201, 201); // [D] #C9C9C9 — open item 3
    public override Color AppButtonOuter2                  { get; set; } = Color.FromArgb(201, 201, 201); // [D] #C9C9C9 — open item 3
    public override Color AppButtonOuter3                  { get; set; } = Color.FromArgb(201, 201, 201); // [D] #C9C9C9 — open item 3
    public override Color AppButtonInner1                  { get; set; } = GlobalStaticValues.EMPTY_COLOR; // [N]
    public override Color AppButtonInner2                  { get; set; } = Color.FromArgb(138, 138, 138); // [D] #8A8A8A
    public override Color AppButtonMenuDocsBack            { get; set; } = Color.White;                   // [N]
    public override Color AppButtonMenuDocsText            { get; set; } = Color.Black;                   // [N]
    public override Color SeparatorHighInternalBorder1     { get; set; } = Color.FromArgb(172, 172, 172); // [N]
    public override Color SeparatorHighInternalBorder2     { get; set; } = Color.FromArgb(111, 111, 111); // [N]
    public override Color RibbonGalleryBorder              { get; set; } = Color.FromArgb(165, 165, 165); // [D] separator #A5A5A5
    public override Color RibbonGalleryBackNormal          { get; set; } = Color.White;                   // [D] gallery well stays light
    public override Color RibbonGalleryBackTracking        { get; set; } = Color.FromArgb(201, 201, 201); // [D] well #C9C9C9
    public override Color RibbonGalleryBack1               { get; set; } = Color.FromArgb(201, 201, 201); // [D] well #C9C9C9
    public override Color RibbonGalleryBack2               { get; set; } = Color.FromArgb(189, 189, 189); // [D] card #BDBDBD
    public override Color RibbonTabTracking3               { get; set; } = Color.FromArgb(97, 97, 97);    // [D] tab hover = edge tone #616161 (hover open item 2)
    public override Color RibbonTabTracking4               { get; set; } = Color.FromArgb(97, 97, 97);    // [D] #616161
    public override Color RibbonGroupBorder3               { get; set; } = Color.FromArgb(165, 165, 165); // [D] separator #A5A5A5
    public override Color RibbonGroupBorder4               { get; set; } = Color.FromArgb(165, 165, 165); // [D] separator #A5A5A5
    public override Color RibbonGroupBorder5               { get; set; } = GlobalStaticValues.EMPTY_COLOR; // [N]
    public override Color RibbonGroupTitleText             { get; set; } = Color.FromArgb(102, 102, 102); // [T] secondary text #666666 ([M5] rect 440,215 population)
    public override Color RibbonDropArrowLight             { get; set; } = Color.FromArgb(151, 156, 163); // [N]
    public override Color RibbonDropArrowDark              { get; set; } = Color.FromArgb(64, 64, 64);    // [D] glyph = control text #404040
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
    public override Color TrackBarTickMarks                { get; set; } = Color.FromArgb(64, 64, 64);    // [T] control text #404040
    public override Color TrackBarTopTrack                 { get; set; } = Color.FromArgb(165, 165, 165); // [D] separator #A5A5A5
    public override Color TrackBarBottomTrack              { get; set; } = Color.FromArgb(201, 201, 201); // [D] well #C9C9C9
    public override Color TrackBarFillTrack                { get; set; } = Color.FromArgb(146, 161, 187); // [D] on-ribbon accent #244276 blended 50% toward the card
    public override Color TrackBarOutsidePosition          { get; set; } = Color.FromArgb(64, Color.White); // [N]
    public override Color TrackBarBorderPosition           { get; set; } = Color.FromArgb(36, 66, 118);   // [D] on-ribbon accent #244276
}
