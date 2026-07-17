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

<p align="center">
  <img src="docs/themes/comparisons/gallery/Office2016Colorful.png" alt="Office 2016 Colorful theme" width="32%" />
  <img src="docs/themes/comparisons/gallery/Office2019Black.png" alt="Office 2019 Black theme" width="32%" />
  <img src="docs/themes/comparisons/gallery/Microsoft365Blue.png" alt="Microsoft 365 (2026) theme" width="32%" />
</p>
<p align="center"><em>The same Krypton form — ribbon, controls and window chrome — under three of the fourteen new palettes.</em></p>

---

## At a glance

| | |
|---|---|
| **Target frameworks** | 11 — `net46` through `net10.0-windows` |
| **Libraries** | 5 core + ~50 Extended modules, one source tree |
| **Themes** | 62 palettes (14 new + a Microsoft 365 2026 refresh) |
| **Samples** | 125 C# + 125 VB.NET twins — 2,750 launch tests, all green |
| **Tests** | functional suite green on all 11 frameworks |
| **Hardening** | ~40 pre-existing upstream defect classes found and fixed |
| **Packages** | 57 NuGet packages, drop-in compatible |

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

Every screenshot below is a live render of the same representative form under that palette,
captured by the bundled Theme Browser.

**Office 2003 — Luna, restored** *(the classic look, un-gated to render on Windows 10/11)*

| Blue | Olive | Silver |
|---|---|---|
| ![Office 2003 Blue](docs/themes/comparisons/gallery/ProfessionalOffice2003.png) | ![Office 2003 Olive](docs/themes/comparisons/gallery/Office2003Olive.png) | ![Office 2003 Silver](docs/themes/comparisons/gallery/Office2003Silver.png) |

**Office 2016 — the Colorful era** *(accent-coloured title bar; distinct from Microsoft 365)*

| Colorful | White | Dark Gray |
|---|---|---|
| ![Office 2016 Colorful](docs/themes/comparisons/gallery/Office2016Colorful.png) | ![Office 2016 White](docs/themes/comparisons/gallery/Office2016White.png) | ![Office 2016 Dark Gray](docs/themes/comparisons/gallery/Office2016DarkGray.png) |

**Office 2019** *(the 2016 look refined, with the new Black variant)*

| Colorful | White | Dark Gray | Black |
|---|---|---|---|
| ![Office 2019 Colorful](docs/themes/comparisons/gallery/Office2019Colorful.png) | ![Office 2019 White](docs/themes/comparisons/gallery/Office2019White.png) | ![Office 2019 Dark Gray](docs/themes/comparisons/gallery/Office2019DarkGray.png) | ![Office 2019 Black](docs/themes/comparisons/gallery/Office2019Black.png) |

**Office 2021 / 2024 — the Fluent refresh** *(flatter; accent on the title bar only, white ribbon card)*

| Colorful | White | Dark Gray | Black |
|---|---|---|---|
| ![Office 2021 Colorful](docs/themes/comparisons/gallery/Office2021Colorful.png) | ![Office 2021 White](docs/themes/comparisons/gallery/Office2021White.png) | ![Office 2021 Dark Gray](docs/themes/comparisons/gallery/Office2021DarkGray.png) | ![Office 2021 Black](docs/themes/comparisons/gallery/Office2021Black.png) |

**Microsoft 365 — refreshed to the 2026 desktop look** *(all eleven M365 palettes remapped; Dark Gray newly selectable)*

| Colorful | Dark Gray | Black |
|---|---|---|
| ![Microsoft 365 Colorful](docs/themes/comparisons/gallery/Microsoft365Blue.png) | ![Microsoft 365 Dark Gray](docs/themes/comparisons/gallery/Microsoft365DarkGray.png) | ![Microsoft 365 Black](docs/themes/comparisons/gallery/Microsoft365Black.png) |

These join the **upstream families still present** — Professional, Office 2007, Office 2010,
Office 2013, Sparkle, Visual Studio 2010 renderers and Material — for **62 palettes in total**:

| Office 2007 — Blue | Office 2010 — Silver | Sparkle — Blue | Material — Dark |
|---|---|---|---|
| ![Office 2007 Blue](docs/themes/comparisons/gallery/Office2007Blue.png) | ![Office 2010 Silver](docs/themes/comparisons/gallery/Office2010Silver.png) | ![Sparkle Blue](docs/themes/comparisons/gallery/SparkleBlue.png) | ![Material Dark](docs/themes/comparisons/gallery/MaterialDark.png) |

Side-by-side comparisons against the real applications, and the cited colour tables for every
value, live under [`docs/themes/`](docs/themes/) — see
[`comparisons/`](docs/themes/comparisons/) and the per-era `*-colours.md` files. To browse all
62 live, run the bundled **Theme Browser** (`Scripts/ThemeBrowser`, also a Start Menu shortcut
in the installer).

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
