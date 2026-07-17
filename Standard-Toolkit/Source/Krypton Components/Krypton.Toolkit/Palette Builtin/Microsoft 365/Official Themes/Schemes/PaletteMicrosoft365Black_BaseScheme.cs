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
// Microsoft 365 "Black" colour scheme — 2026 refresh (Bastion Phase 3, spec §4.2 item 4).
//
// VARIANT MAPPING (Bastion decision): Microsoft365Black is refreshed as the real M365
// "BLACK" variant (which doubles as the system Dark Mode) — the bluish near-black
// #1C2227 frame (NOT #000000) with the #292929 ribbon card. Pre-refresh look preserved
// in docs\themes\comparisons\placeholder\Microsoft365Black.png.
//
// Provenance — every value is tagged:
//   [T] taken from docs\themes\m365-2026-colours.md ("Black variant (Dark Mode)" table,
//       source [M6] excel-black-theme.png).
//       Key values: title bar / app frame / tab row #1C2227 (28,34,39); chrome text
//       #FFFFFF primary / #DEDFE0 (222,223,224) secondary; ribbon card #292929
//       (41,41,41); control text #DEDFE0, subdued #757575 (117,117,117); selected-tab
//       underline #60BD82 (96,189,130 — the only dark-mode accent evidence, Excel);
//       formula bar / inputs #292929; header band #0A0A0A; sheet splitter #646464.
//   [D] derived — rule stated inline. Card steps: control well = card +12/channel
//       #353535 (53,53,53); separators = card +20/channel #3D3D3D (61,61,61) (the
//       2021-pass step rules applied to the [M6] card). Caption hover = card tone
//       #292929, pressed = well #353535 (hover/pressed are colour-table open item 2;
//       status bar open item 1).
//   [N] donor value from PaletteOffice2021Black_BaseScheme (2021 fidelity pass) —
//       era-neutral dark slot with no 2026-specific evidence. Grids/lists keep the
//       light canvas ("Grid canvas stays light", [M6] point 400,560); the shared M365
//       base renders dark grid text, so the [M6] #0A0A0A header band is recorded as an
//       open item for the shared base (the BlackDarkMode clone base carries it).
// =====================================================================================

namespace Krypton.Toolkit;

public sealed class PaletteMicrosoft365Black_BaseScheme : KryptonColorSchemeBase
{
    public override Color TextLabelControl                 { get; set; } = Color.FromArgb(222, 223, 224); // [T] control text #DEDFE0
    public override Color TextButtonNormal                 { get; set; } = Color.FromArgb(222, 223, 224); // [T] control text #DEDFE0
    public override Color TextButtonChecked                { get; set; } = Color.FromArgb(36, 36, 36);    // [D] checked fills come from the shared ButtonBackColor LUT (static, last-writer-wins — upstream wart, open item); every set is light for the shared base, so checked text stays dark
    public override Color ButtonNormalBorder               { get; set; } = Color.FromArgb(61, 61, 61);    // [D] separator = card +20 #3D3D3D
    public override Color ButtonNormalDefaultBorder        { get; set; } = Color.FromArgb(61, 61, 61);    // [D] #3D3D3D
    public override Color ButtonNormalBack1                { get; set; } = Color.FromArgb(53, 53, 53);    // [D] control well = card +12 #353535
    public override Color ButtonNormalBack2                { get; set; } = Color.FromArgb(53, 53, 53);    // [D] #353535
    public override Color ButtonNormalDefaultBack1         { get; set; } = Color.FromArgb(65, 65, 65);    // [D] well +12 emphasis step #414141
    public override Color ButtonNormalDefaultBack2         { get; set; } = Color.FromArgb(65, 65, 65);    // [D] #414141
    public override Color ButtonNormalNavigatorBack1       { get; set; } = Color.FromArgb(20, 20, 20);    // [N] dark navigator well
    public override Color ButtonNormalNavigatorBack2       { get; set; } = Color.FromArgb(20, 20, 20);    // [N]
    public override Color PanelClient                      { get; set; } = Color.FromArgb(41, 41, 41);    // [T] ribbon card #292929 ([M6] rect 440,215 — 88% uniform); the pipeline fills the ribbon body with PanelClient
    public override Color PanelAlternative                 { get; set; } = Color.FromArgb(28, 34, 39);    // [T] app frame #1C2227
    public override Color ControlBorder                    { get; set; } = Color.FromArgb(61, 61, 61);    // [D] separator #3D3D3D
    public override Color SeparatorHighBorder1             { get; set; } = Color.FromArgb(172, 172, 172); // [N]
    public override Color SeparatorHighBorder2             { get; set; } = Color.FromArgb(111, 111, 111); // [N]
    public override Color HeaderPrimaryBack1               { get; set; } = Color.FromArgb(28, 34, 39);    // [T] frame #1C2227
    public override Color HeaderPrimaryBack2               { get; set; } = Color.FromArgb(28, 34, 39);    // [T] frame #1C2227
    public override Color HeaderSecondaryBack1             { get; set; } = Color.FromArgb(53, 53, 53);    // [D] well #353535
    public override Color HeaderSecondaryBack2             { get; set; } = Color.FromArgb(53, 53, 53);    // [D] well #353535
    public override Color HeaderText                       { get; set; } = Color.FromArgb(222, 223, 224); // [T] secondary chrome text #DEDFE0
    public override Color StatusStripText                  { get; set; } = Color.FromArgb(222, 223, 224); // [D] #DEDFE0 (status bar open item 1)
    public override Color ButtonBorder                     { get; set; } = Color.FromArgb(236, 199, 87);  // [N] hover border — hover/pressed fills are colour-table open item 2
    public override Color SeparatorLight                   { get; set; } = Color.FromArgb(61, 61, 61);    // [D] separator #3D3D3D
    public override Color SeparatorDark                    { get; set; } = Color.FromArgb(10, 10, 10);    // [D] header band #0A0A0A
    public override Color GripLight                        { get; set; } = Color.FromArgb(61, 61, 61);    // [D] separator #3D3D3D
    public override Color GripDark                         { get; set; } = Color.FromArgb(28, 34, 39);    // [D] frame #1C2227
    public override Color ToolStripBack                    { get; set; } = Color.FromArgb(41, 41, 41);    // [D] toolbar strip merges into the card #292929
    public override Color StatusStripLight                 { get; set; } = Color.FromArgb(28, 34, 39);    // [D] frame #1C2227 (status open item 1)
    public override Color StatusStripDark                  { get; set; } = Color.FromArgb(28, 34, 39);    // [D] frame #1C2227
    public override Color ImageMargin                      { get; set; } = Color.White;                   // [N]
    public override Color ToolStripBegin                   { get; set; } = Color.FromArgb(41, 41, 41);    // [D] strip = card #292929
    public override Color ToolStripMiddle                  { get; set; } = Color.FromArgb(41, 41, 41);    // [D] #292929
    public override Color ToolStripEnd                     { get; set; } = Color.FromArgb(41, 41, 41);    // [D] #292929
    public override Color OverflowBegin                    { get; set; } = Color.FromArgb(10, 10, 10);    // [D] band #0A0A0A for overflow chrome
    public override Color OverflowMiddle                   { get; set; } = Color.FromArgb(10, 10, 10);    // [D] #0A0A0A
    public override Color OverflowEnd                      { get; set; } = Color.FromArgb(10, 10, 10);    // [D] #0A0A0A
    public override Color ToolStripBorder                  { get; set; } = Color.FromArgb(61, 61, 61);    // [D] separator #3D3D3D
    public override Color FormBorderActive                 { get; set; } = Color.FromArgb(28, 34, 39);    // [T] frame #1C2227 — active frame
    public override Color FormBorderInactive               { get; set; } = Color.FromArgb(119, 119, 119); // [N] inactive frame — colour-table open item 4
    public override Color FormBorderActiveLight            { get; set; } = Color.FromArgb(28, 34, 39);    // [T] #1C2227 (flat frame)
    public override Color FormBorderActiveDark             { get; set; } = Color.FromArgb(28, 34, 39);    // [T] #1C2227 (flat frame)
    public override Color FormBorderInactiveLight          { get; set; } = Color.FromArgb(158, 158, 158); // [N] inactive — open item 4
    public override Color FormBorderInactiveDark           { get; set; } = Color.FromArgb(158, 158, 158); // [N] inactive — open item 4
    public override Color FormBorderHeaderActive           { get; set; } = Color.FromArgb(28, 34, 39);    // [T] #1C2227 — caption merges into chrome
    public override Color FormBorderHeaderInactive         { get; set; } = Color.FromArgb(154, 154, 154); // [N] inactive — open item 4
    public override Color FormBorderHeaderActive1          { get; set; } = Color.FromArgb(28, 34, 39);    // [T] title bar #1C2227 ([M6] rect 300,55)
    public override Color FormBorderHeaderActive2          { get; set; } = Color.FromArgb(28, 34, 39);    // [T] title bar #1C2227
    public override Color FormBorderHeaderInactive1        { get; set; } = Color.FromArgb(158, 158, 158); // [N] inactive — open item 4
    public override Color FormBorderHeaderInactive2        { get; set; } = Color.FromArgb(158, 158, 158); // [N] inactive — open item 4
    public override Color FormHeaderShortActive            { get; set; } = Color.White;                   // [T] title bar text #FFFFFF
    public override Color FormHeaderShortInactive          { get; set; } = Color.FromArgb(170, 170, 170); // [D] inactive dimmed (open item 4)
    public override Color FormHeaderLongActive             { get; set; } = Color.White;                   // [T] title bar text #FFFFFF
    public override Color FormHeaderLongInactive           { get; set; } = Color.FromArgb(170, 170, 170); // [D] inactive dimmed (open item 4)
    public override Color FormButtonBorderTrack            { get; set; } = Color.FromArgb(41, 41, 41);    // [D] caption hover = card tone #292929 (hover open item 2)
    public override Color FormButtonBack1Track             { get; set; } = Color.FromArgb(41, 41, 41);    // [D] #292929
    public override Color FormButtonBack2Track             { get; set; } = Color.FromArgb(41, 41, 41);    // [D] #292929
    public override Color FormButtonBorderPressed          { get; set; } = Color.FromArgb(53, 53, 53);    // [D] pressed = well step #353535
    public override Color FormButtonBack1Pressed           { get; set; } = Color.FromArgb(53, 53, 53);    // [D] #353535
    public override Color FormButtonBack2Pressed           { get; set; } = Color.FromArgb(53, 53, 53);    // [D] #353535
    public override Color TextButtonFormNormal             { get; set; } = Color.White;                   // [T] caption glyph/text white on the dark frame
    public override Color TextButtonFormTracking           { get; set; } = Color.White;                   // [T] white on hover
    public override Color TextButtonFormPressed            { get; set; } = Color.White;                   // [T] white on pressed
    public override Color LinkNotVisitedOverrideControl    { get; set; } = Color.Blue;                    // [N]
    public override Color LinkVisitedOverrideControl       { get; set; } = Color.Purple;                  // [N]
    public override Color LinkPressedOverrideControl       { get; set; } = Color.Red;                     // [N]
    public override Color LinkNotVisitedOverridePanel      { get; set; } = Color.FromArgb(180, 210, 255); // [N] light link family on dark panels
    public override Color LinkVisitedOverridePanel         { get; set; } = Color.Violet;                  // [N]
    public override Color LinkPressedOverridePanel         { get; set; } = Color.FromArgb(255, 90, 90);   // [N]
    public override Color TextLabelPanel                   { get; set; } = Color.FromArgb(222, 223, 224); // [T] control text #DEDFE0 on dark panels
    public override Color RibbonTabTextNormal              { get; set; } = Color.White;                   // [T] tab text #FFFFFF on the #1C2227 tab row
    public override Color RibbonTabTextChecked             { get; set; } = Color.FromArgb(96, 189, 130);  // [T] selected-tab underline accent #60BD82 ([M6] col scan x=192)
    public override Color RibbonTabSelected1               { get; set; } = Color.FromArgb(41, 41, 41);    // [D] selected tab merges into the #292929 ribbon card
    public override Color RibbonTabSelected2               { get; set; } = Color.FromArgb(41, 41, 41);    // [D] card fill
    public override Color RibbonTabSelected3               { get; set; } = Color.FromArgb(41, 41, 41);    // [D] card fill
    public override Color RibbonTabSelected4               { get; set; } = Color.FromArgb(41, 41, 41);    // [D] card fill
    public override Color RibbonTabSelected5               { get; set; } = Color.FromArgb(41, 41, 41);    // [D] card fill
    public override Color RibbonTabTracking1               { get; set; } = Color.FromArgb(41, 41, 41);    // [D] tab hover = card tone #292929 (hover open item 2)
    public override Color RibbonTabTracking2               { get; set; } = Color.FromArgb(41, 41, 41);    // [D] #292929
    public override Color RibbonTabHighlight1              { get; set; } = Color.FromArgb(41, 41, 41);    // [D] mirrors RibbonTabSelected1 (flat selected look)
    public override Color RibbonTabHighlight2              { get; set; } = Color.FromArgb(41, 41, 41);    // [D] mirrors selected fill
    public override Color RibbonTabHighlight3              { get; set; } = Color.FromArgb(41, 41, 41);    // [D] mirrors selected fill
    public override Color RibbonTabHighlight4              { get; set; } = Color.FromArgb(41, 41, 41);    // [D] mirrors selected fill
    public override Color RibbonTabHighlight5              { get; set; } = Color.FromArgb(41, 41, 41);    // [D] mirrors selected fill
    public override Color RibbonTabSeparatorColor          { get; set; } = Color.FromArgb(61, 61, 61);    // [D] separator #3D3D3D — 2026 draws no tab separators
    public override Color RibbonGroupsArea1                { get; set; } = Color.FromArgb(61, 61, 61);    // [D] card edge #3D3D3D
    public override Color RibbonGroupsArea2                { get; set; } = Color.FromArgb(61, 61, 61);    // [D] group separator #3D3D3D
    public override Color RibbonGroupsArea3                { get; set; } = Color.FromArgb(61, 61, 61);    // [D] group separator #3D3D3D
    public override Color RibbonGroupsArea4                { get; set; } = Color.FromArgb(41, 41, 41);    // [T] ribbon card #292929 ([M6] rect 440,215)
    public override Color RibbonGroupsArea5                { get; set; } = Color.FromArgb(41, 41, 41);    // [T] ribbon card #292929
    public override Color RibbonGroupBorder1               { get; set; } = GlobalStaticValues.EMPTY_COLOR; // [N]
    public override Color RibbonGroupBorder2               { get; set; } = GlobalStaticValues.EMPTY_COLOR; // [N]
    public override Color RibbonGroupTitle1                { get; set; } = GlobalStaticValues.EMPTY_COLOR; // [N]
    public override Color RibbonGroupTitle2                { get; set; } = GlobalStaticValues.EMPTY_COLOR; // [N]
    public override Color RibbonGroupBorderContext1        { get; set; } = GlobalStaticValues.EMPTY_COLOR; // [N]
    public override Color RibbonGroupBorderContext2        { get; set; } = GlobalStaticValues.EMPTY_COLOR; // [N]
    public override Color RibbonGroupTitleContext1         { get; set; } = GlobalStaticValues.EMPTY_COLOR; // [N]
    public override Color RibbonGroupTitleContext2         { get; set; } = GlobalStaticValues.EMPTY_COLOR; // [N]
    public override Color RibbonGroupDialogDark            { get; set; } = Color.FromArgb(222, 223, 224); // [D] glyph = control text #DEDFE0
    public override Color RibbonGroupDialogLight           { get; set; } = Color.FromArgb(53, 53, 53);    // [D] well #353535
    public override Color RibbonGroupTitleTracking1        { get; set; } = GlobalStaticValues.EMPTY_COLOR; // [N]
    public override Color RibbonGroupTitleTracking2        { get; set; } = GlobalStaticValues.EMPTY_COLOR; // [N]
    public override Color RibbonMinimizeBarDark            { get; set; } = Color.FromArgb(10, 10, 10);    // [D] band #0A0A0A
    public override Color RibbonMinimizeBarLight           { get; set; } = Color.FromArgb(41, 41, 41);    // [D] card #292929
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
    public override Color RibbonGroupFrameBorder1          { get; set; } = Color.FromArgb(61, 61, 61);    // [D] separator #3D3D3D
    public override Color RibbonGroupFrameBorder2          { get; set; } = Color.FromArgb(61, 61, 61);    // [D] separator #3D3D3D
    public override Color RibbonGroupFrameInside1          { get; set; } = Color.FromArgb(53, 53, 53);    // [D] well #353535
    public override Color RibbonGroupFrameInside2          { get; set; } = Color.FromArgb(53, 53, 53);    // [D] well #353535
    public override Color RibbonGroupFrameInside3          { get; set; } = GlobalStaticValues.EMPTY_COLOR; // [N]
    public override Color RibbonGroupFrameInside4          { get; set; } = GlobalStaticValues.EMPTY_COLOR; // [N]
    public override Color RibbonGroupCollapsedText         { get; set; } = Color.FromArgb(222, 223, 224); // [T] control text #DEDFE0
    public override Color RibbonGroupButtonText            { get; set; } = Color.FromArgb(222, 223, 224); // [T] control text #DEDFE0
    public override Color AlternatePressedBack1            { get; set; } = Color.FromArgb(158, 163, 172); // [N]
    public override Color AlternatePressedBack2            { get; set; } = Color.FromArgb(212, 215, 216); // [N]
    public override Color AlternatePressedBorder1          { get; set; } = Color.FromArgb(124, 125, 125); // [N]
    public override Color AlternatePressedBorder2          { get; set; } = Color.FromArgb(186, 186, 186); // [N]
    public override Color FormButtonBack1Checked           { get; set; } = Color.FromArgb(41, 41, 41);    // [D] checked caption button = card tone #292929
    public override Color FormButtonBack2Checked           { get; set; } = Color.FromArgb(41, 41, 41);    // [D] #292929
    public override Color FormButtonBorderCheck            { get; set; } = Color.FromArgb(53, 53, 53);    // [D] well step #353535
    public override Color FormButtonBack1CheckTrack        { get; set; } = Color.FromArgb(53, 53, 53);    // [D] #353535
    public override Color FormButtonBack2CheckTrack        { get; set; } = Color.FromArgb(53, 53, 53);    // [D] #353535
    public override Color RibbonQATMini1                   { get; set; } = Color.FromArgb(28, 34, 39);    // [D] QAT minibar sits on the #1C2227 title bar
    public override Color RibbonQATMini2                   { get; set; } = Color.FromArgb(28, 34, 39);    // [D] #1C2227
    public override Color RibbonQATMini3                   { get; set; } = Color.FromArgb(28, 34, 39);    // [D] #1C2227
    public override Color RibbonQATMini4                   { get; set; } = Color.FromArgb(12, Color.White); // [N]
    public override Color RibbonQATMini5                   { get; set; } = Color.FromArgb(14, Color.White); // [N]
    public override Color RibbonQATMini1I                  { get; set; } = Color.FromArgb(100, 100, 100); // [N] inactive — open item 4
    public override Color RibbonQATMini2I                  { get; set; } = Color.FromArgb(170, 170, 170); // [N] inactive — open item 4
    public override Color RibbonQATMini3I                  { get; set; } = Color.FromArgb(140, 140, 140); // [N] inactive — open item 4
    public override Color RibbonQATMini4I                  { get; set; } = Color.FromArgb(12, Color.White); // [N]
    public override Color RibbonQATMini5I                  { get; set; } = Color.FromArgb(14, Color.White); // [N]
    public override Color RibbonQATFullbar1                { get; set; } = Color.FromArgb(41, 41, 41);    // [D] full QAT bar merges into the card #292929
    public override Color RibbonQATFullbar2                { get; set; } = Color.FromArgb(41, 41, 41);    // [D] #292929
    public override Color RibbonQATFullbar3                { get; set; } = Color.FromArgb(10, 10, 10);    // [T] header band #0A0A0A
    public override Color RibbonQATButtonDark              { get; set; } = Color.FromArgb(27, 27, 27);    // [N]
    public override Color RibbonQATButtonLight             { get; set; } = Color.FromArgb(117, 117, 117); // [N]
    public override Color RibbonQATOverflow1               { get; set; } = Color.FromArgb(138, 138, 138); // [N]
    public override Color RibbonQATOverflow2               { get; set; } = Color.FromArgb(45, 45, 45);    // [N]
    public override Color RibbonGroupSeparatorDark         { get; set; } = Color.FromArgb(61, 61, 61);    // [D] separator #3D3D3D
    public override Color RibbonGroupSeparatorLight        { get; set; } = GlobalStaticValues.EMPTY_COLOR; // [N]
    public override Color ButtonClusterButtonBack1         { get; set; } = Color.FromArgb(210, 217, 219); // [N]
    public override Color ButtonClusterButtonBack2         { get; set; } = Color.FromArgb(214, 222, 223); // [N]
    public override Color ButtonClusterButtonBorder1       { get; set; } = Color.FromArgb(179, 188, 191); // [N]
    public override Color ButtonClusterButtonBorder2       { get; set; } = Color.FromArgb(145, 156, 159); // [N]
    public override Color NavigatorMiniBackColor           { get; set; } = Color.FromArgb(235, 235, 235); // [N]
    public override Color GridListNormal1                  { get; set; } = Color.FromArgb(205, 205, 205); // [N] grid canvas stays light ([M6] point 400,560); shared base renders dark grid text
    public override Color GridListNormal2                  { get; set; } = Color.FromArgb(166, 166, 166); // [N]
    public override Color GridListPressed1                 { get; set; } = Color.FromArgb(166, 166, 166); // [N]
    public override Color GridListPressed2                 { get; set; } = Color.FromArgb(205, 205, 205); // [N]
    public override Color GridListSelected                 { get; set; } = Color.FromArgb(150, 150, 150); // [N]
    public override Color GridSheetColNormal1              { get; set; } = Color.FromArgb(220, 220, 220); // [N] light headers kept — [M6] #0A0A0A band is an open item for the shared base
    public override Color GridSheetColNormal2              { get; set; } = Color.FromArgb(200, 200, 200); // [N]
    public override Color GridSheetColPressed1             { get; set; } = Color.FromArgb(166, 166, 166); // [D] header pressed steps to the list-pressed tone
    public override Color GridSheetColPressed2             { get; set; } = Color.FromArgb(166, 166, 166); // [D]
    public override Color GridSheetColSelected1            { get; set; } = Color.FromArgb(91, 157, 218);  // [T] header accent (selected column) #5B9DDA ([M6] rect 270,478)
    public override Color GridSheetColSelected2            { get; set; } = Color.FromArgb(91, 157, 218);  // [T] #5B9DDA
    public override Color GridSheetRowNormal               { get; set; } = Color.FromArgb(205, 205, 205); // [N]
    public override Color GridSheetRowPressed              { get; set; } = Color.FromArgb(166, 166, 166); // [D]
    public override Color GridSheetRowSelected             { get; set; } = Color.FromArgb(100, 155, 207); // [T] row-header selected tint #649BCF ([M6] point 48,520)
    public override Color GridDataCellBorder               { get; set; } = Color.FromArgb(218, 220, 221); // [N] content canvas stays light
    public override Color GridDataCellSelected             { get; set; } = Color.FromArgb(183, 219, 255); // [N]
    public override Color InputControlTextNormal           { get; set; } = Color.FromArgb(222, 223, 224); // [T] control text #DEDFE0 (dark inputs)
    public override Color InputControlTextDisabled         { get; set; } = Color.FromArgb(128, 128, 128); // [N]
    public override Color InputControlBorderNormal         { get; set; } = Color.FromArgb(61, 61, 61);    // [D] separator #3D3D3D
    public override Color InputControlBorderDisabled       { get; set; } = Color.FromArgb(47, 47, 47);    // [D] border dimmed one step
    public override Color InputControlBackNormal           { get; set; } = Color.FromArgb(41, 41, 41);    // [T] formula bar / name box #292929 ([M6] rect 600,415)
    public override Color InputControlBackDisabled         { get; set; } = Color.FromArgb(31, 31, 31);    // [D] card −10
    public override Color InputControlBackInactive         { get; set; } = Color.FromArgb(35, 35, 35);    // [D] card −6
    public override Color InputDropDownNormal1             { get; set; } = Color.FromArgb(222, 223, 224); // [D] glyph = control text #DEDFE0
    public override Color InputDropDownNormal2             { get; set; } = Color.Transparent;             // [N]
    public override Color InputDropDownDisabled1           { get; set; } = Color.FromArgb(128, 128, 128); // [D] disabled glyph matches disabled text
    public override Color InputDropDownDisabled2           { get; set; } = Color.Transparent;             // [N]
    public override Color ContextMenuHeadingBack           { get; set; } = Color.FromArgb(240, 242, 245); // [N] context menu — colour-table open item 3 (base table renders light menus)
    public override Color ContextMenuHeadingText           { get; set; } = Color.Black;                   // [N] context menu — open item 3
    public override Color ContextMenuImageColumn           { get; set; } = Color.White;                   // [N] context menu — open item 3
    public override Color AppButtonBack1                   { get; set; } = Color.FromArgb(47, 47, 47);    // [N] backstage — open item 3
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
    public override Color RibbonGalleryBorder              { get; set; } = Color.FromArgb(61, 61, 61);    // [D] separator #3D3D3D
    public override Color RibbonGalleryBackNormal          { get; set; } = Color.FromArgb(53, 53, 53);    // [D] well #353535
    public override Color RibbonGalleryBackTracking        { get; set; } = Color.FromArgb(65, 65, 65);    // [D] well +12 hover step
    public override Color RibbonGalleryBack1               { get; set; } = Color.FromArgb(53, 53, 53);    // [D] well #353535
    public override Color RibbonGalleryBack2               { get; set; } = Color.FromArgb(41, 41, 41);    // [D] card #292929
    public override Color RibbonTabTracking3               { get; set; } = Color.FromArgb(41, 41, 41);    // [D] card tone #292929 (hover open item 2)
    public override Color RibbonTabTracking4               { get; set; } = Color.FromArgb(41, 41, 41);    // [D] #292929
    public override Color RibbonGroupBorder3               { get; set; } = Color.FromArgb(10, 10, 10);    // [D] band #0A0A0A (darker-than-body border)
    public override Color RibbonGroupBorder4               { get; set; } = Color.FromArgb(10, 10, 10);    // [D] #0A0A0A
    public override Color RibbonGroupBorder5               { get; set; } = GlobalStaticValues.EMPTY_COLOR; // [N]
    public override Color RibbonGroupTitleText             { get; set; } = Color.FromArgb(117, 117, 117); // [T] subdued text #757575
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
    public override Color TrackBarTickMarks                { get; set; } = Color.FromArgb(222, 223, 224); // [D] control text #DEDFE0
    public override Color TrackBarTopTrack                 { get; set; } = Color.FromArgb(10, 10, 10);    // [D] band #0A0A0A
    public override Color TrackBarBottomTrack              { get; set; } = Color.FromArgb(174, 174, 174); // [N]
    public override Color TrackBarFillTrack                { get; set; } = Color.FromArgb(131, 132, 132); // [N]
    public override Color TrackBarOutsidePosition          { get; set; } = Color.FromArgb(64, Color.White); // [N]
    public override Color TrackBarBorderPosition           { get; set; } = Color.FromArgb(96, 189, 130);  // [D] dark-mode accent #60BD82
}
