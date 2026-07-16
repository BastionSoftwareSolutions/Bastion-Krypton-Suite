# Floating Toolbars

> Part of the Bastion Krypton Suite — Extended Toolkit. NuGet package: `Bastion.Krypton.Extended.Floating.Toolbars` (bundled in `Bastion.Krypton.Extended.Ultimate`).

**Assembly:** `Bastion.Krypton.Suite.Extended.Floating.Toolbars` · **Namespace:** `Krypton.Toolkit.Suite.Extended.Floating.Toolbars` (unchanged from upstream)

## Purpose

Provides floatable menu strips, tool strips and their host panels and container windows (10 controls in total).

## Key types

- `FloatableMenuStrip : MenuStrip`, `FloatableToolStrip : ToolStrip` — floatable strips
- `FloatablePanelHost` / `MenuStripPanelExtended` / `ToolStripPanelExtended : ToolStripPanel` — host panels
- `FloatingContainerForm`, `ToolStripContainerWindow`, `MenuStripContainerWindow` — container windows
- Chooser forms

## Dependencies

Core Krypton: dual — PackageReference to `Krypton.Toolkit` (100.25.11.328) in the NuGet solution, ProjectReference to the sibling Standard-Toolkit checkout otherwise. No module references.

## See also

- [Extended Toolkit overview](index.md)
- [Migration from upstream](../migration-from-upstream.md)
