# Error Reporting

> Part of the Bastion Krypton Suite — Extended Toolkit. NuGet package: `Bastion.Krypton.Extended.Error.Reporting` (bundled in `Bastion.Krypton.Extended.Ultimate`).

**Assembly:** `Bastion.Krypton.Suite.Extended.Error.Reporting` · **Namespace:** `Krypton.Toolkit.Suite.Extended.Error.Reporting` (unchanged from upstream)

## Purpose

Provides an exception-reporting dialog with report templating and MAPI mail support; its structure matches the open-source ExceptionReporter.NET family.

## Key types

- `ExceptionReportView : KryptonForm` — exception report dialog (plus many non-control report classes)

## Dependencies

Core Krypton: NuGet-only — consumed exclusively as NuGet PackageReferences to `Krypton.Toolkit` and `Krypton.Navigator` in every configuration. No module references. Third-party packages: `Handlebars.Net` 2.1.6, `ProDotNetZip` 1.20.0, `Simple-MAPI.NET` 1.2.1, `System.Management` 10.0.0.

## See also

- [Extended Toolkit overview](index.md)
- [Migration from upstream](../migration-from-upstream.md)
