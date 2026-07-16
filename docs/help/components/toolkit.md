# Krypton Toolkit

**Assembly:** `Bastion.Krypton.Toolkit` · **Namespace:** `Krypton.Toolkit` (unchanged) ·
**Package:** `Bastion.Krypton.Toolkit`

The Toolkit is the foundation of the whole suite. It provides the themed control set, the
palette and rendering engine that every other library paints through, and the shared
infrastructure (`KryptonManager`, button specs, context menus, palettes). Every other core and
Extended library depends on it.

## Control families

- **Buttons and input** — `KryptonButton`, `KryptonCheckBox`, `KryptonRadioButton`,
  `KryptonTextBox`, `KryptonMaskedTextBox`, `KryptonRichTextBox`, `KryptonComboBox`,
  `KryptonNumericUpDown`, `KryptonDomainUpDown`, `KryptonDateTimePicker`, `KryptonTrackBar`.
- **Labels and display** — `KryptonLabel`, `KryptonLinkLabel`, `KryptonWrapLabel`,
  `KryptonGroupBox`, `KryptonSeparator`, `KryptonBorderEdge`.
- **Lists and grids** — `KryptonListBox`, `KryptonCheckedListBox`, `KryptonListView`,
  `KryptonTreeView`, `KryptonDataGridView` (with the Krypton column and cell types).
- **Containers** — `KryptonPanel`, `KryptonGroup`, `KryptonHeaderGroup`, `KryptonSplitContainer`,
  `KryptonScrollBar`.
- **Windows and dialogs** — `KryptonForm`, `KryptonMessageBox`, `KryptonInputBox`,
  `KryptonOpenFileDialog`, `KryptonSaveFileDialog`, `KryptonFolderBrowserDialog`,
  `KryptonColorDialog`, `KryptonFontDialog`, `KryptonPrintDialog`, `KryptonTaskDialog`.
- **Menus and toolbars** — `KryptonContextMenu` and its item types,
  `KryptonThemeComboBox` (a ready-made theme picker).
- **Infrastructure** — `KryptonManager` (global palette + settings), the `PaletteBase` family,
  the built-in palettes and renderers, and the `ButtonSpec` action-button system.

## Key entry points

- **`KryptonManager`** — the application-wide component. Set `GlobalPaletteMode` to theme the
  whole app; it also exposes global rendering hints and tool-tip behaviour.
- **`KryptonForm`** — the themed top-level window with a Krypton-drawn chrome and caption
  button specs.
- **`PaletteMode` / `PaletteBase`** — the theming model, covered in the
  [theming guide](../theming-guide.md).

## Minimal example

```csharp
using Krypton.Toolkit;

var form = new KryptonForm { Text = "Toolkit" };
var input = new KryptonTextBox { Location = new System.Drawing.Point(12, 12), Width = 200 };
var ok = new KryptonButton { Text = "OK", Location = new System.Drawing.Point(12, 44) };
ok.Click += (_, _) => KryptonMessageBox.Show($"You typed: {input.Text}");
form.Controls.AddRange(new System.Windows.Forms.Control[] { input, ok });
System.Windows.Forms.Application.Run(form);
```

## What Bastion adds here

The Toolkit is where Bastion's new Office 2016/2019/2021 and additional Office 2003 palettes
live (see the [theming guide](../theming-guide.md)), alongside the eleven-framework
multi-targeting. The public API is identical across frameworks except for a few file-dialog and
MDI members gated to the frameworks that provide them — see the
[feature matrix](../per-tfm-feature-matrix.md).

## See also

- [Theming guide](../theming-guide.md) · [Getting started](../getting-started.md)
- API reference: the `Krypton.Toolkit` namespace in the **API Reference** section.
