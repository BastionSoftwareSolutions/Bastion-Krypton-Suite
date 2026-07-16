# Bastion Krypton Suite

**An up-to-date, multi-targeted build of the Krypton Component Suite for Windows Forms —
the full Standard Toolkit (Toolkit, Ribbon, Navigator, Workspace, Docking) plus every module
of the Krypton Extended Toolkit — compiled for .NET Framework 4.6–4.8.1 and .NET 5 through
.NET 10, with faithful Office and Microsoft 365 themes and dual-language (C# + VB.NET)
samples.**

Bastion Krypton Suite is a **drop-in-compatible fork**: the `Krypton.Toolkit` namespaces and
public type names are unchanged, so existing code keeps working. Only the assembly names and
NuGet package IDs gain a `Bastion.` prefix.

> **Not affiliated with or endorsed by Component Factory Pty Ltd or the Krypton Suite team.**
> "Bastion Krypton Suite" states its derivation honestly under the terms of the upstream
> BSD-3-Clause and MIT licences.

---

## Why this exists

The upstream [Krypton Standard Toolkit](https://github.com/Krypton-Suite/Standard-Toolkit)
ships for `net472`, `net48`, `net481` and the current .NET LTS/STS windows targets, and folds
the Office "Colorful" era into a single Microsoft 365 look. Bastion Krypton Suite exists to:

- **Widen the target matrix to 11 frameworks** — adding `net46`, `net47`, `net5.0`, `net6.0`
  and `net7.0` for teams pinned to older runtimes, while keeping the modern LTS targets.
- **Bring the Extended Toolkit onto one source tree** — ~60 modules building against a single
  core version instead of a patchwork of inconsistent NuGet pins.
- **Ship distinct, faithful Office themes** — Office 2003, 2016, 2019 and 2021/2024 as their
  own palettes, plus a Microsoft 365 refresh to the genuine 2026 visuals.
- **Provide 100% dual-language samples** — every C# demo has an idiomatic VB.NET twin.
- **Harden the controls** — an adversarial test suite that found and fixed ~40 pre-existing
  upstream defect classes (see [CHANGES.md](CHANGES.md)).

If you only need the modern targets and the stock theme set, upstream Krypton is excellent and
you should use it. Bastion is for the long tail of frameworks, the full Extended module set on
one tree, the expanded theme palette, and the VB parity.

---

## Installation

> **Packaging is Phase 7 and not yet published.** The package IDs below are reserved for
> publication to nuget.org; the `dotnet add package` commands work **on publication**.

Core libraries:

```
Bastion.Krypton.Toolkit
Bastion.Krypton.Ribbon
Bastion.Krypton.Navigator
Bastion.Krypton.Workspace
Bastion.Krypton.Docking
Bastion.Krypton.Suite          # metapackage — all five core libraries
```

Extended Toolkit (one package per module, plus a metapackage):

```
Bastion.Krypton.Extended.<Module>      # e.g. Bastion.Krypton.Extended.OutlookGrid
Bastion.Krypton.Extended.Ultimate      # metapackage — all Extended modules
```

```sh
# on publication
dotnet add package Bastion.Krypton.Toolkit
```

Each package multi-targets the full 11-TFM matrix, with compat dependencies
(`System.ValueTuple`, `System.Memory`) added only on the frameworks that need them.

---

## Quick start

A minimal themed form with a button, in both languages. The namespaces are the upstream ones —
this is what "drop-in compatible" means in practice.

### C#

```csharp
using System;
using System.Windows.Forms;
using Krypton.Toolkit;

internal static class Program
{
    [STAThread]
    private static void Main()
    {
        Application.EnableVisualStyles();
        Application.SetCompatibleTextRenderingDefault(false);

        // Set a theme for the whole application.
        var manager = new KryptonManager
        {
            GlobalPaletteMode = PaletteMode.Office2019Colorful
        };

        var form = new KryptonForm { Text = "Bastion Krypton Suite", ClientSize = new System.Drawing.Size(360, 160) };

        var button = new KryptonButton
        {
            Text = "Click me",
            Location = new System.Drawing.Point(120, 60)
        };
        button.Click += (_, _) => KryptonMessageBox.Show("Hello from Bastion Krypton Suite!");

        form.Controls.Add(button);
        Application.Run(form);
    }
}
```

### VB.NET

```vb
Imports System.Windows.Forms
Imports Krypton.Toolkit

Module Program
    <STAThread>
    Sub Main()
        Application.EnableVisualStyles()
        Application.SetCompatibleTextRenderingDefault(False)

        ' Set a theme for the whole application.
        Dim manager As New KryptonManager With {
            .GlobalPaletteMode = PaletteMode.Office2019Colorful
        }

        Dim form As New KryptonForm With {
            .Text = "Bastion Krypton Suite",
            .ClientSize = New Drawing.Size(360, 160)
        }

        Dim button As New KryptonButton With {
            .Text = "Click me",
            .Location = New Drawing.Point(120, 60)
        }
        AddHandler button.Click, Sub() KryptonMessageBox.Show("Hello from Bastion Krypton Suite!")

        form.Controls.Add(button)
        Application.Run(form)
    End Sub
End Module
```

Switch theme at runtime by assigning any `PaletteMode` to `KryptonManager.GlobalPaletteMode` —
open forms restyle live.

---

## Theme gallery

Bastion adds **14 new selectable themes** on top of the upstream set and refreshes Microsoft
365 to its current 2026 look. Every colour traces to a cited reference (official Microsoft
support/Learn crops and lossless application composites) — see
[`docs/themes/references/SOURCES.md`](docs/themes/references/SOURCES.md) and the per-era colour
tables in [`docs/themes/`](docs/themes/).

| Office 2016 — Colorful | Microsoft 365 — Blue (2026) | Office 2019 — Black |
|---|---|---|
| ![Office 2016 Colorful](docs/themes/comparisons/office2016-2019/Office2016Colorful.png) | ![Microsoft 365 Blue](docs/themes/comparisons/m365-2026/Microsoft365Blue.png) | ![Office 2019 Black](docs/themes/comparisons/office2016-2019/Office2019Black.png) |

The full set of new palettes:

- **Office 2003** — Olive, Silver (the Luna era; blue already shipped upstream).
- **Office 2016** — Colorful, White, Dark Gray.
- **Office 2019** — Colorful, White, Dark Gray, Black.
- **Office 2021 / 2024** — Colorful, White, Dark Gray, Black.
- **Microsoft 365** — Dark Gray (new), plus a full refresh of the existing M365 palettes to
  the genuine current visuals.

These join the upstream families still present: Professional, Office 2007, Office 2010, Office
2013, Sparkle, Visual Studio 2010 renderers and Material. Side-by-side comparison images for
every mode live under
[`docs/themes/comparisons/`](docs/themes/comparisons/) (`office2016-2019/`,
`office2021-2003/`, `m365-2026/`).

> Per-theme fidelity sign-off is still in progress; see [CHANGES.md](CHANGES.md) for status.

---

## Supported frameworks

The suite builds for **11 target frameworks**:

```
net46  net47  net472  net48  net481
net5.0-windows  net6.0-windows  net7.0-windows
net8.0-windows  net9.0-windows  net10.0-windows
```

**Framework support status — please read.** Several of these targets are included deliberately
for consumers pinned to old runtimes but are **out of Microsoft support**:

| Framework | Status |
|---|---|
| .NET Framework 4.6 / 4.6.1 | Out of support (April 2022) |
| .NET Framework 4.7–4.8.1 | Supported (component of Windows) |
| .NET 5 / 6 / 7 | Out of support |
| **.NET 8** | Supported — LTS (to November 2026) |
| .NET 9 | Out of support (STS, EOL May 2026) |
| **.NET 10** | Supported — LTS mainline |

**.NET 8 and .NET 10 are the supported mainline.** If you build on an out-of-support framework
you accept its unpatched-security risk. A few capabilities vary by framework (per-monitor DPI
tracking, certain shell-dialog APIs); the full per-TFM feature matrix is in
[CHANGES.md](CHANGES.md#6-per-tfm-feature-matrix). Note that **net46 builds under desktop
MSBuild only** (it uses classic resources).

---

## Relationship to upstream

Bastion Krypton Suite is a fork of the Krypton-Suite **V105-LTS** line (Standard Toolkit tip
`57824ec4`; Extended Toolkit tip `2725d8c4`), cross-checked against the original 2017 Component
Factory Ultimate source.

- **Drop-in compatible.** Namespaces and public type names are unchanged. Migrating from
  upstream `Krypton.*` means swapping the package/assembly references for `Bastion.Krypton.*` —
  your `using Krypton.Toolkit;` and control code stay as they are.
- **Why the assemblies are renamed.** The `Bastion.` assembly prefix avoids GAC/binding
  collisions with an upstream `Krypton.*` install side by side.
- **Upstream is the source of truth for the controls.** Every bug Bastion fixed is tagged as an
  upstream-contribution candidate in [`docs/audit/BREAKAGE-LOG.md`](docs/audit/BREAKAGE-LOG.md).

For the complete list of changes — baseline commits, the multi-targeting strategy, every theme
added, the bugs found and fixed, the per-TFM feature matrix, and everything intentionally left
undone — see **[CHANGES.md](CHANGES.md)**.

---

## Licence

**Dual-licence, mirroring upstream:**

- **Core** (Standard-Toolkit-derived + original Component Factory code): **BSD-3-Clause** —
  © Component Factory Pty Ltd, © Krypton Suite, © Bastion Software Solutions Ltd.
- **Extended Toolkit** modules: **MIT** — © 2017–2024 Krypton Suite, © Bastion Software
  Solutions Ltd.

Two Extended modules (**Outlook.Grid**, **AdvancedDataGridView**) are substantially Microsoft
Public License code and are distributed as **`MIT AND MS-PL`**; Ms-PL is copyleft only for the
source form of that code, so closed-source use of the compiled packages is unaffected (Ms-PL is
GPL-incompatible). All third-party attribution is retained and documented in
[`docs/audit/THIRD-PARTY-LICENCES.md`](docs/audit/THIRD-PARTY-LICENCES.md).

Core and Extended licence metadata are never blended in a single package. See
[CHANGES.md §9](CHANGES.md#9-attribution--licence) for full attribution.
