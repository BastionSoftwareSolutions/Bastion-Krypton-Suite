# Third-party notices — Krypton Toolkit Suite Extended (Bastion Krypton Suite)

This repository is MIT licensed (see `LICENSE`, Copyright (c) 2017 - 2024 Krypton
Suite). Several modules embed or derive from third-party open-source code. The
table below is the shipping summary; the authoritative audit record, including
before/after attribution states and open escalations, is
`docs/audit/THIRD-PARTY-LICENCES.md` in the Bastion workspace.

Added 15 July 2026 by the Bastion Krypton Suite third-party licence audit.
Upstream copyright headers must never be removed.

| Module | Vendored / derived code | Upstream | Licence | Notice |
|---|---|---|---|---|
| Data.Visualisation | `Scott Plot\**` (~347 files) | [ScottPlot 5](https://github.com/ScottPlot/ScottPlot) | MIT © 2018 Scott Harden / Harden Technologies, LLC | `Scott Plot\LICENSE` + `Scott Plot\README.md` |
| Data.Visualisation | Vega palettes (`Category10/20.cs`) | Vega / UW Interactive Data Lab | BSD-3-Clause © 2015-2018 | in-file (retained) |
| Data.Visualisation | Microcharts palette | Microcharts | MIT © 2017 Aloïs Deniel | in-file (retained) |
| Outlook.Grid | `Classes\**` and most of the module | [Krypton-OutlookGrid](https://github.com/Cocotteseb/Krypton-OutlookGrid) | **Ms-PL** © 2013-2021 JDH Software | in-file headers (retained); package licence `MIT AND MS-PL` |
| AdvancedDataGridView | `Controls Toolkit\**` | ADGV / Zuby.AdvancedDataGridView | **Ms-PL** | in-file headers (full Ms-PL text, retained); package licence `MIT AND MS-PL` |
| Software.Updater | `Auto Updater\**` | [AutoUpdater.NET](https://github.com/ravibpatel/AutoUpdater.NET) | MIT © 2012-2024 RBSoft | `Auto Updater\LICENSE` + module `THIRD-PARTY-NOTICES.md` |
| Software.Updater | `Sharp Update\**` | [SharpUpdate](https://github.com/henryxrl/SharpUpdate) | **none declared** (escalated) | module `THIRD-PARTY-NOTICES.md` |
| Software.Updater.Core | `NetSparkle\**` | [NetSparkleUpdater](https://github.com/NetSparkleUpdater/NetSparkle) | MIT © 2022 Deadpikle | in-file headers (retained) |
| Software.Updater.Core | `NetSparkle\Libraries\MarkdownSharp.cs` | MarkdownSharp / Markdown | MIT/BSD-style © John Gruber, Milan Negovan, Jeff Atwood | in-file headers (retained) |
| Utilities | `Classes\System\SAPI\**` (338 files) | .NET System.Speech reference source | MIT © .NET Foundation and Contributors | `Classes\System\SAPI\THIRD-PARTY-NOTICES.md` |
| Drawing.Utilities | Colour-picker controls, `ImageBoxExtended.cs` | [Cyotek.Windows.Forms.ColorPicker / ImageBox](https://github.com/cyotek) | MIT © 2013-2021 Cyotek Ltd (Richard Moss) | module `THIRD-PARTY-NOTICES.md` |
| Drawing.Utilities | `DrawGlowShadow` fragment in `ImageBoxExtended.cs` | CodeProject gGlowBox (SSDiver2112), via Cyotek ImageBox | **CPOL (probable) — under review** | module `THIRD-PARTY-NOTICES.md` (escalated) |
| Circular.ProgressBar | `CircularProgressBar` control | [falahati/CircularProgressBar](https://github.com/falahati/CircularProgressBar) | MIT © 2016 Soroush Falahati | module `THIRD-PARTY-NOTICES.md` |
| Navi.Suite | `Navi*` control family | [Guifreaks NaviSuite](https://github.com/jacobmesu/Guifreaks-Navisuite) (Jacob Mesu) | MIT | module `THIRD-PARTY-NOTICES.md` |
| Toggle.Switch | `ToggleSwitch*` renderer family | CodeProject "ToggleSwitch Winforms Control" (Johnny J) | **CPOL — under review** | escalated; no notice claiming compliance yet |
| Controls | `KryptonPasswordTextBox` and support classes | PasswordTextBox control (Nils Jonsson) | MIT © 2016 Nils Jonsson and contributors | in-file headers (retained) |
| Wizard | `KryptonAdvancedWizard*` | [SteveBate/AdvancedWizard](https://github.com/SteveBate/AdvancedWizard) | none declared upstream; author credited in headers | in-file credit (retained) |
| Common / Forms / Utilities | `AllowNullAttribute.cs` | .NET Foundation | MIT | in-file headers (retained) |

Smaller CodeProject-derived fragments (UAC shield helpers, MRU file manager,
ToolBox control, progress-bar painting, CheckBoxComboBox, toast pop-up) are
inventoried, with their CPOL exposure assessment, in
`docs/audit/THIRD-PARTY-LICENCES.md`.

NuGet **package licence metadata**: packages default to `MIT`
(`Directory.Build.targets`); Outlook.Grid and AdvancedDataGridView declare
`MIT AND MS-PL` because Ms-PL requires derivative source distributions to remain
under Ms-PL and all notices to be retained.
