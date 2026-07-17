# Third-party notices — Krypton.Toolkit.Suite.Extended.Drawing.Utilities

This module contains controls derived from third-party open-source projects.
These notices were restored on 15 July 2026 by the Bastion Krypton Suite
third-party licence audit; previously the lineage was acknowledged only in
scattered code comments.

## Cyotek Color Picker controls — MIT

The colour-picker control family in this module is derived from
**Cyotek.Windows.Forms.ColorPicker**:

- **Origin:** <https://github.com/cyotek/Cyotek.Windows.Forms.ColorPicker>
  (see also the article series at <https://www.cyotek.com>)
- **Licence:** MIT — Copyright © 2013-2021 Cyotek Ltd (Richard Moss).
- **Derived files include (not exhaustive):**
  `Controls\Components\ColourWheelControl.cs`, `ColourGridControl.cs`,
  `ColourSliderControl.cs`, `ScreenColourPickerControl.cs`,
  `ColourHexadecimalComboBox.cs`, the `Controls\User Controls\General\ColourGrid*`
  and `ColourEditor*` user controls, and the `UX\KryptonColourPickerDialog.cs` /
  `UX\ColourGridDialog.cs` dialogs.
- The module also consumes the `Unofficial.Cyotek.Windows.Forms.NET` NuGet
  package (a repack of the same Cyotek controls, MIT).

## Cyotek ImageBox — MIT

`Controls\Components\ImageBoxExtended.cs` is derived from
**Cyotek.Windows.Forms.ImageBox**:

- **Origin:** <https://github.com/cyotek/Cyotek.Windows.Forms.ImageBox>
- **Licence:** MIT — Copyright © Cyotek Ltd (Richard Moss).

> **Resolved (17 July 2026):** the `DrawGlowShadow` method inside
> `ImageBoxExtended.cs` was previously adapted from the CodeProject article
> "gGlowBox - Create a glow effect around a focused control" by SSDiver2112
> (Code Project Open License, CPOL — incompatible with plain-MIT redistribution).
> It has been **replaced with an original clean-room implementation** written from
> the behavioural description alone (concentric alpha-ramped rounded-rectangle
> strokes), © Bastion Software Solutions Ltd 2026 (MIT). The CPOL credit comment
> has been removed. No CPOL-derived code remains in this module. See the resolved
> section of `docs/audit/THIRD-PARTY-LICENCES.md` in the Bastion workspace.

## Upstream licence text (Cyotek, MIT)

The MIT License (MIT)

Copyright © 2013-2021 Cyotek Ltd.

Permission is hereby granted, free of charge, to any person obtaining a copy
of this software and associated documentation files (the "Software"), to deal
in the Software without restriction, including without limitation the rights
to use, copy, modify, merge, publish, distribute, sublicense, and/or sell
copies of the Software, and to permit persons to whom the Software is
furnished to do so, subject to the following conditions:

The above copyright notice and this permission notice shall be included in all
copies or substantial portions of the Software.

THE SOFTWARE IS PROVIDED "AS IS", WITHOUT WARRANTY OF ANY KIND, EXPRESS OR
IMPLIED, INCLUDING BUT NOT LIMITED TO THE WARRANTIES OF MERCHANTABILITY,
FITNESS FOR A PARTICULAR PURPOSE AND NONINFRINGEMENT. IN NO EVENT SHALL THE
AUTHORS OR COPYRIGHT HOLDERS BE LIABLE FOR ANY CLAIM, DAMAGES OR OTHER
LIABILITY, WHETHER IN AN ACTION OF CONTRACT, TORT OR OTHERWISE, ARISING FROM,
OUT OF OR IN CONNECTION WITH THE SOFTWARE OR THE USE OR OTHER DEALINGS IN THE
SOFTWARE.

Krypton Suite additions in this module are MIT — Copyright (c) 2017 - 2024
Krypton Suite.
