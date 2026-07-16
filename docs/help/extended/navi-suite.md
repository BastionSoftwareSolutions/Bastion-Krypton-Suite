# Navi Suite

> Part of the Bastion Krypton Suite — Extended Toolkit. NuGet package: `Bastion.Krypton.Extended.Navi.Suite` (bundled in `Bastion.Krypton.Extended.Ultimate`).

**Assembly:** `Bastion.Krypton.Suite.Extended.Navi.Suite` · **Namespace:** `Krypton.Toolkit.Suite.Extended.Navi.Suite` (unchanged from upstream)

## Purpose

An Outlook-style navigation control family (8 controls), matching the historical open-source "NaviSuite" navigation library.

## Key types

- `NaviControl` / `NaviSuiteControl : ContainerControl` — navigation controls
- `NaviControlCollection`, `NaviToolstripRenderer` — collection and renderer
- `NaviSuiteLanguageManager : Component` — language manager
- `NaviBandPopup`, `NaviOptionsForm : KryptonForm`, `PopupWindowHelper : NativeWindow`

## Dependencies

Core Krypton: dual — PackageReference to `Krypton.Toolkit` (100.25.11.328) in the NuGet solution, ProjectReference to the sibling Standard-Toolkit checkout otherwise. No module references.

## Licence notes

The `Navi*` control family matches the historical open-source "NaviSuite" Outlook-style navigation library; all headers are currently Krypton Suite MIT with no upstream attribution retained.

## See also

- [Extended Toolkit overview](index.md)
- [Migration from upstream](../migration-from-upstream.md)
