# Krypton Navigator

**Assembly:** `Bastion.Krypton.Navigator` · **Namespace:** `Krypton.Navigator` (unchanged) ·
**Package:** `Bastion.Krypton.Navigator`

Krypton Navigator is a multi-page container control — a themed, highly configurable superset of
`TabControl`. Its public API is **identical across all eleven target frameworks**.

## Core types

- **`KryptonNavigator`** — the container; holds a collection of `KryptonPage` objects.
- **`KryptonPage`** — a single page, with its own header text, image and button specs.
- **`NavigatorMode`** — chooses the visual style: bar-tab (top/bottom/left/right), header-bar,
  header-group, Outlook (full and mini), stack, and check-button variants.

The control exposes deep palette sub-objects (bar, group, header, page, panel, tooltips) so the
appearance of each region can be themed independently; these are surfaced through the
`Navigator*` palette classes.

## Minimal example

```csharp
using Krypton.Navigator;
using Krypton.Toolkit;

var form = new KryptonForm { Text = "Navigator" };
var nav = new KryptonNavigator { Dock = System.Windows.Forms.DockStyle.Fill };

var page1 = new KryptonPage { Text = "General", TextTitle = "General" };
var page2 = new KryptonPage { Text = "Advanced", TextTitle = "Advanced" };

nav.Pages.AddRange(new[] { page1, page2 });
form.Controls.Add(nav);
System.Windows.Forms.Application.Run(form);
```

## Choosing a mode

```csharp
nav.NavigatorMode = NavigatorMode.OutlookFull;   // Outlook-style navigation pane
```

## See also

- [Krypton Workspace](workspace.md) and [Krypton Docking](docking.md) build on the same page
  model for multi-document layouts.
- API reference: the `Krypton.Navigator` namespace.
