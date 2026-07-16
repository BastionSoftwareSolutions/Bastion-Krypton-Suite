# Notifications

> Part of the Bastion Krypton Suite — Extended Toolkit. NuGet package: `Bastion.Krypton.Extended.Notifications` (bundled in `Bastion.Krypton.Extended.Ultimate`).

**Assembly:** `Bastion.Krypton.Suite.Extended.Notifications` · **Namespace:** `Krypton.Toolkit.Suite.Extended.Notifications` (unchanged from upstream)

## Purpose

Provides toast, alert and pop-up notification controls (7 in total) with a managing component.

## Key types

- `KryptonToastNotificationManager` / `KryptonToastNotificationPopup : Component` — notification manager and pop-up
- `KryptonAlertWindow`, `KryptonPopUpNotificationWindow` — alert and pop-up windows
- `KryptonToastNotificationVersion1` / `KryptonToastNotificationVersion2 : KryptonForm` — toast notification forms
- `InternalKryptonButtonPanel : UserControl` — internal button panel

## Dependencies

Core Krypton: dual — PackageReference to `Krypton.Toolkit` (100.25.11.328) in the NuGet solution, ProjectReference to the sibling Standard-Toolkit checkout otherwise. Module references: Debug.Tools, Developer.Utilities.

## See also

- [Extended Toolkit overview](index.md)
- [Migration from upstream](../migration-from-upstream.md)
