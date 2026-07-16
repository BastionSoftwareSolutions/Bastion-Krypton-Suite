# Krypton Ribbon

**Assembly:** `Bastion.Krypton.Ribbon` · **Namespace:** `Krypton.Ribbon` (unchanged) ·
**Package:** `Bastion.Krypton.Ribbon`

Krypton Ribbon provides an Office-style ribbon that themes in step with the rest of the suite.
Its public API is **identical across all eleven target frameworks**.

## Structure

A ribbon is a tree of strongly-typed elements:

- **`KryptonRibbon`** — the ribbon control itself, hosting the tab collection, the application
  button/menu and the quick-access toolbar (QAT).
- **`KryptonRibbonTab`** — a tab; tabs can be grouped into context tab sets
  (`KryptonRibbonContextTabSet`) that appear only when relevant.
- **`KryptonRibbonGroup`** — a labelled group within a tab.
- **Group items** — `KryptonRibbonGroupButton`, `KryptonRibbonGroupCluster`,
  `KryptonRibbonGroupComboBox`, `KryptonRibbonGroupTextBox`, `KryptonRibbonGroupLabel`,
  `KryptonRibbonGroupGallery`, `KryptonRibbonGroupColorButton`, `KryptonRibbonGroupCheckBox`,
  `KryptonRibbonGroupRadioButton`, `KryptonRibbonGroupNumericUpDown`,
  `KryptonRibbonGroupDateTimePicker`, `KryptonRibbonGroupTrackBar`, and the layout
  triple/lines/separator containers.

## Minimal example

```csharp
using Krypton.Ribbon;
using Krypton.Toolkit;

var form = new KryptonForm { Text = "Ribbon" };
var ribbon = new KryptonRibbon();

var tab = new KryptonRibbonTab { Text = "Home" };
var group = new KryptonRibbonGroup { TextLine1 = "Clipboard" };
var paste = new KryptonRibbonGroupButton { TextLine1 = "Paste" };

group.Items.Add(paste);
tab.Groups.Add(group);
ribbon.RibbonTabs.Add(tab);
form.Controls.Add(ribbon);
System.Windows.Forms.Application.Run(form);
```

## Theming

The ribbon paints with the global palette, so `KryptonManager.GlobalPaletteMode` themes it
automatically. The Extended Toolkit adds a
[`KryptonRibbonGroupThemeComboBox`](../extended/ribbon.md) for an in-ribbon theme picker.

## See also

- [Getting started](../getting-started.md) · [Theming guide](../theming-guide.md)
- API reference: the `Krypton.Ribbon` namespace.
