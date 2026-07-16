# Per-TFM Feature Matrix

The suite multi-targets **eleven** frameworks. The public API surface is near-identical across
all of them: a metadata sweep of the five core libraries finds only **20 differing signatures**
in total, every one a deliberate platform-floor gate. This page lists them. Full data is in
[`docs/audit/API-MATRIX.md`](../audit/API-MATRIX.md); the per-gap engineering strategy is in
`CHANGES.md` §2 at the repository root.

## Supported target frameworks

| TFM | Runtime status (2026) | Notes |
|---|---|---|
| `net46` | .NET Framework 4.6 — EOL | Most constrained; see below. |
| `net47` | .NET Framework 4.7 — EOL | |
| `net472` | .NET Framework 4.7.2 | Retained for upstream-diff friendliness. |
| `net48` | .NET Framework 4.8 | |
| `net481` | .NET Framework 4.8.1 | |
| `net5.0-windows` | .NET 5 — EOL | Included for pinned consumers. |
| `net6.0-windows` | .NET 6 — EOL | |
| `net7.0-windows` | .NET 7 — EOL | |
| `net8.0-windows` | **.NET 8 — LTS** | Recommended mainline; the canonical documentation source. |
| `net9.0-windows` | .NET 9 — EOL May 2026 | |
| `net10.0-windows` | **.NET 10 — LTS** | Recommended mainline. |

## API differences by framework

These public members exist only on the frameworks whose base class library provides the
underlying capability. On other frameworks the member is simply absent — there is no silent
stub.

### Krypton.Toolkit (18 signatures)

| Member | Available on | Reason |
|---|---|---|
| `KryptonOpenFileDialog.ClientGuid`, `KryptonSaveFileDialog.ClientGuid`, `KryptonFolderBrowserDialog.ClientGuid`, `ShellDialogWrapper.ClientGuid` | net5.0-windows and later | `FileDialog.ClientGuid` was added to WinForms in .NET 5. |
| `KryptonSaveFileDialog.CheckWriteAccess` | net7.0-windows and later | `FileDialog.CheckWriteAccess` was added in .NET 7. |
| `VisualForm.MdiChildrenMinimizedAnchorBottom` | net6.0-windows and later | `Form.MdiChildrenMinimizedAnchorBottom` semantics available from .NET 6. |

(Each property is counted with its getter and setter, giving 18 signatures in total.)

### Krypton.Docking (2 signatures)

| Member | Available on | Reason |
|---|---|---|
| `KryptonFloatingWindow.OnClosing` | net46 – net9.0-windows | On net10 the framework's form-closing hook changed name. |
| `KryptonFloatingWindow.OnFormClosing` | net10.0-windows only | Replaces `OnClosing` on net10. |

### Krypton.Ribbon, Krypton.Navigator, Krypton.Workspace

**No differences** — the public surface is identical on every target framework.

## Behavioural notes for `net46`

`net46` is the oldest target and costs the most to support. Consumers should understand:

- **Build toolchain.** The net46 leg compiles under **desktop MSBuild only**, not `dotnet
  build`, because it cannot use preserialized resources (`System.Resources.Extensions` floors
  at net462) and so compiles classic `.resx`. Every other leg builds under either toolchain.
- **Compat dependencies.** net46 pulls `System.ValueTuple` (4.5.0) and `System.Memory` as
  package dependencies, which flow through to consumers. These are **not** added on net47+.
- **DPI.** `Control.DeviceDpi` is supplied by a GDI-based shim, so DPI queries work.
  **Per-monitor DPI change tracking does not** — `DpiChanged`/`DpiChangedEventArgs` did not
  exist until net47, and per-monitor DPI is not a capability of .NET Framework 4.6. This is the
  only functional degradation on net46.

## Extended Toolkit framework coverage

Extended modules build the same eleven-framework matrix as the core, with two documented
exceptions recorded in `CHANGES.md` §2.3:

- **Data.Visualisation** builds ten of the eleven (it depends on SkiaSharp, which does not offer
  a net46 asset).
- The dormant **Themes** module is deliberately unscheduled pending a go/no-go decision.

## See also

- [API matrix (raw data)](../audit/API-MATRIX.md)
- The change record `CHANGES.md` at the repository root
- [Migration from upstream](migration-from-upstream.md)
