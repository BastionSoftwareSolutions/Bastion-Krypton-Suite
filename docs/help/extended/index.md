# Extended Toolkit Overview

The **Extended Toolkit** is a large set of optional module libraries that build on the core
Krypton controls — around 50 modules covering data grids, calendars, wizards, dialogs, toast
notifications, data visualisation, colour tools and more. Each ships as its own NuGet package
`Bastion.Krypton.Extended.<Module>`, and the all-in-one metapackage
`Bastion.Krypton.Extended.Ultimate` bundles the full set.

> **Namespaces are unchanged from upstream** — a module keeps its
> `Krypton.Toolkit.Suite.Extended.<Module>` namespace; only the assembly and package names gain
> the `Bastion.` prefix. See the [migration note](../migration-from-upstream.md).

## Licence

The Extended Toolkit is **MIT** (© 2017–2024 Krypton Suite), distinct from the BSD-3-Clause
core. Several modules embed or derive from third-party projects under their own licences (for
example the Outlook Grid and Advanced DataGridView under Ms-PL, ScottPlot under MIT in Data
Visualisation). Where a module carries such code, its page notes it, and the full sub-audit is
in [`docs/audit/THIRD-PARTY-LICENCES.md`](../../audit/THIRD-PARTY-LICENCES.md).

## Modules by category

### Data grids and lists

- [Advanced DataGridView](advanced-datagridview.md) · [DataGridView (master/detail, custom columns)](datagridview.md)
- [Outlook Grid](outlook-grid.md) · [Tree GridView](treegridview.md) · [Virtual Tree Column View](virtualtree-columnview.md)

### Dialogs and messaging

- [Dialogs](dialogs.md) · [Specialised Dialogs](specialised-dialogs.md) · [Input Box](inputbox.md)
- [Message Box](messagebox.md) · [Memory Box](memory-box.md)
- [Notifications](notifications.md) · [Toast Notification](toast-notification.md)
- [Error Reporting](error-reporting.md)

### Controls and inputs

- [Buttons](buttons.md) · [Controls](controls.md) · [ComboBox](combobox.md)
- [Toggle Switch](toggle-switch.md) · [Circular Progress Bar](circular-progressbar.md)
- [Calendar](calendar.md) · [Tool Box](tool-box.md) · [Tool Strip Items](tool-strip-items.md)
- [Panels](panels.md) · [Floating Toolbars](floating-toolbars.md)

### Navigation and layout

- [Navigator (Extended)](navigator.md) · [Navi Suite](navi-suite.md)
- [Ribbon (Extended)](ribbon.md) · [Dock Extender](dock-extender.md)
- [Forms](forms.md) · [Wizard](wizard.md)

### Theming, drawing and visualisation

- [Theme Switcher](theme-switcher.md) · [Data Visualisation](data-visualisation.md)
- [Drawing](drawing.md) · [Drawing Utilities](drawing-utilities.md) · [Effects](effects.md)

### Files, IO and networking

- [IO](io.md) · [File Copier](file-copier.md) · [Compression](compression.md)
- [CheckSum Tools](checksum-tools.md) · [Networking](networking.md)

### Infrastructure and shared

- [Core](core.md) · [Common](common.md) · [Controls](controls.md)
- [Utilities](utilities.md) · [Global Utilities](global-utilities.md) · [Developer Utilities](developer-utilities.md)
- [Debug Tools](debug-tools.md) · [Settings](settings.md) · [Resources](resources.md)
- [Language Model](language-model.md) · [Software Updater Core](software-updater-core.md)

## Modules not included

Ten upstream module projects are **excluded** from the Ultimate set because they are empty
stubs or dormant (File Explorer, Gauges, Palette Selectors, PDF, Scintilla.NET, Security, the
full Software Updater UI, Task Dialogs, Themes, Message Dialog). Their status is recorded in
[`docs/audit/EXTENDED-INVENTORY.md`](../../audit/EXTENDED-INVENTORY.md) §4.

## See also

- [Getting started](../getting-started.md) · [Migration from upstream](../migration-from-upstream.md)
- Extended API reference: the **Extended API** section in the top navigation.
