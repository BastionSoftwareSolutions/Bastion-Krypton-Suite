# Bastion Krypton Suite — Developer Documentation

Bastion Krypton Suite is a multi-targeted fork of the actively maintained
[Krypton-Suite](https://github.com/Krypton-Suite/Standard-Toolkit) **Standard Toolkit** and
**Extended Toolkit**, cross-checked for completeness against the original 2017 Component
Factory open-sourcing. It provides a complete WinForms component suite — Toolkit, Ribbon,
Navigator, Workspace and Docking — plus the full Extended Toolkit module set, built for
**eleven target frameworks** from .NET Framework 4.6 to .NET 10.

> **Namespaces and public type names are unchanged.** Only assembly names and NuGet package
> IDs gain the `Bastion.` prefix, so the suite is a drop-in replacement for the upstream
> `Krypton.*` packages. See the [migration note](migration-from-upstream.md).

## Start here

| Guide | What it covers |
|---|---|
| [Getting started](getting-started.md) | Install the packages, add controls, write your first C# and VB.NET form. |
| [Theming guide](theming-guide.md) | The palette model, the built-in Office / Microsoft 365 themes, and runtime theme switching. |
| [Migration from upstream](migration-from-upstream.md) | Moving from `Krypton.*` to `Bastion.Krypton.*` — what changes and what does not. |
| [Per-TFM feature matrix](per-tfm-feature-matrix.md) | Which APIs and behaviours differ by target framework. |

## Component reference

### Core libraries

- [Krypton Toolkit](components/toolkit.md) — the foundation controls, palettes and rendering.
- [Krypton Ribbon](components/ribbon.md) — the Office-style ribbon.
- [Krypton Navigator](components/navigator.md) — tabbed and Outlook-style navigation.
- [Krypton Workspace](components/workspace.md) — resizable, dockable workspace cells.
- [Krypton Docking](components/docking.md) — Visual-Studio-style docking.

### Extended Toolkit

The Extended Toolkit adds around 50 optional module libraries — data-grid views, calendars,
wizards, toast notifications, dialogs, data visualisation and more. See the
[Extended Toolkit overview](extended/index.md) for a page per module.

## API reference

The **API Reference** and **Extended API** sections (see the top navigation) are generated
directly from the XML documentation comments of the net8.0-windows assemblies. The API surface
is near-identical across all eleven target frameworks; the handful of per-framework differences
are listed in the [feature matrix](per-tfm-feature-matrix.md).

## Licensing

Core and original Component Factory code is **BSD-3-Clause**; the Extended Toolkit is **MIT**
(© 2017–2024 Krypton Suite). New Bastion files carry a `© Bastion Software Solutions Ltd`
header noting the licensed tree they derive from. This documentation is UK English throughout.
