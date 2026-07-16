# Dialogs

> Part of the Bastion Krypton Suite — Extended Toolkit. NuGet package: `Bastion.Krypton.Extended.Dialogs` (bundled in `Bastion.Krypton.Extended.Ultimate`).

**Assembly:** `Bastion.Krypton.Suite.Extended.Dialogs` · **Namespace:** `Krypton.Toolkit.Suite.Extended.Dialogs` (unchanged from upstream)

## Purpose

A collection of Krypton-themed dialogs (9 controls) for authentication, exception capture, input, NuGet browsing, properties and run commands.

## Key types

- `KryptonAuthenticationForm`, `KryptonExceptionCaptureDialog`, `KryptonInputBoxExtendedForm` — authentication, exception and input dialogs
- `KryptonNuGetBrowser`, `KryptonPropertiesForm` — NuGet browser and properties dialogs
- `KryptonRunDialog : KryptonFormExtended`, `KryptonRunDialogOptions` — run dialog and options
- `KryptonBrowseComboBox`, `KryptonSplitButton` — supporting controls

## Dependencies

Core Krypton: dual — PackageReference to `Krypton.Toolkit` (100.25.11.328) in the NuGet solution, ProjectReference to the sibling Standard-Toolkit checkout otherwise. Module references: CheckSum.Tools, Forms, Global.Utilities, Controls, Settings, Utilities, Common. Third-party packages: `System.Speech` 10.0.0, `WindowsAPICodePackShell` 8.0.12.

## See also

- [Extended Toolkit overview](index.md)
- [Migration from upstream](../migration-from-upstream.md)
