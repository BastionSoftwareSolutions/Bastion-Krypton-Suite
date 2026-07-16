# Buttons

> Part of the Bastion Krypton Suite — Extended Toolkit. NuGet package: `Bastion.Krypton.Extended.Buttons` (bundled in `Bastion.Krypton.Extended.Ultimate`).

**Assembly:** `Bastion.Krypton.Suite.Extended.Buttons` · **Namespace:** `Krypton.Toolkit.Suite.Extended.Buttons` (unchanged from upstream)

## Purpose

Extensions to the Krypton button controls, including command-link, split, browse, UAC and pre-configured dialog buttons.

## Key types

- `KryptonCommandLinkButton : VisualSimpleBase` and `KryptonCommandLinkVersion2` — command-link style buttons
- `KryptonSplitButton` — split button
- `KryptonBrowseButton` — file/folder browse button
- `KryptonUACButtonVersion1` / `KryptonUACButtonVersion2` — UAC shield buttons
- `KryptonOK/Cancel/Yes/NO DialogButton : KryptonButton` — pre-configured dialog buttons
- `KryptonViewButtons : UserControl`, `KryptonDialogButtonExtended` (12 controls in total)

## Dependencies

Core Krypton: dual — PackageReference to `Krypton.Toolkit` (100.25.11.328) in the NuGet solution, ProjectReference to the sibling Standard-Toolkit checkout otherwise. Module references: Debug.Tools, Developer.Utilities, Core. Third-party packages: `WindowsAPICodePackShell` and `WindowsAPICodePackShellExtensions` 8.0.12.

## See also

- [Extended Toolkit overview](index.md)
- [Migration from upstream](../migration-from-upstream.md)
