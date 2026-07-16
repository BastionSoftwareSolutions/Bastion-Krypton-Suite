# Theme Switcher

> Part of the Bastion Krypton Suite — Extended Toolkit. NuGet package: `Bastion.Krypton.Extended.Theme.Switcher` (bundled in `Bastion.Krypton.Extended.Ultimate`).

**Assembly:** `Bastion.Krypton.Suite.Extended.Theme.Switcher` · **Namespace:** `Krypton.Toolkit.Suite.Extended.Theme.Switcher` (unchanged from upstream)

## Purpose

Provides theme-selection and theme-management controls (7 in total), including download and upload dialogs for external theme packages.

## Key types

- `ThemeSelector`, `ThemeSwitcherOptions` (plus `Old` variants) — theme selection and options
- `DownloadThemePackage`, `UploadThemeBrowser : KryptonForm` — theme package download/upload
- `KryptonExternalThemeSelectorForm : KryptonForm` — external theme selector

## Dependencies

Core Krypton: NuGet-only — consumed exclusively as NuGet PackageReferences to `Krypton.Toolkit` and `Krypton.Navigator` in every configuration. Module references: Debug.Tools, Developer.Utilities, Settings, Navigator. Third-party package: `WindowsAPICodePackShell` 8.0.12.

## See also

- [Extended Toolkit overview](index.md)
- [Migration from upstream](../migration-from-upstream.md)
