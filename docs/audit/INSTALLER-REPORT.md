# Bastion Krypton Suite - Inno Setup Installer Report

**Project:** Bastion Krypton Suite (spec Phase 7, §8.2)
**Toolchain:** Inno Setup 6 (compiler engine 6.7.3), `ISCC.exe`
**Built:** 2026-07-16 (UK)
**Author:** Bastion Software Solutions Ltd

---

## 1. Deliverables

| Artefact | Path |
|---|---|
| Inno Setup script | `Installer\BastionKryptonSuite.iss` |
| Build wrapper (stage + compile) | `Installer\build-installer.ps1` |
| Combined licence (BSD-3 + MIT + notices) | `Installer\LICENSE.txt` |
| Designer integration readme | `Installer\DesignerIntegration.md` |
| Post-install readme (SmartScreen note) | `Installer\README-INSTALL.txt` |
| This report | `docs\audit\INSTALLER-REPORT.md` |
| **Built installer (git-ignored)** | `artifacts\installer\Bastion Krypton Suite 1.0.0 Setup.exe` |

**Installer size:** ~360.7 MB (378,256,602 bytes). A 1.0.1 upgrade variant of the
same size was also built for the lifecycle test.

The `artifacts\` tree is git-ignored (`.gitignore` line 18: `/artifacts/`), so the
Setup.exe, the staging tree and the lifecycle-test sandbox are not committed. The
script, readmes, licence and this report are committed to `main`.

---

## 2. Fixed AppId GUID (KEEP STABLE FOR ALL FUTURE UPGRADES)

```
AppId = {{9D307380-9B7C-4DC7-A58D-75CAB5116E96}
```

This GUID identifies the product to Windows and is what makes upgrade-in-place
work (a new version installs over the old one instead of side-by-side). **It must
never change** across releases. It is hard-coded in `BastionKryptonSuite.iss`
`[Setup]` and documented here. (The doubled leading brace is Inno's required
escaping for a literal `{` in the value.)

---

## 3. Install profile

- **Per-user by default.** `PrivilegesRequired=lowest` - no administrator rights
  or UAC elevation required.
- **Default location:** `{localappdata}\Programs\Bastion Krypton Suite`
  (i.e. `%LOCALAPPDATA%\Programs\Bastion Krypton Suite`).
- `PrivilegesRequiredOverridesAllowed=dialog commandline` lets a user opt into an
  all-users install if they choose, without changing the default.
- **Registry footprint:** only Inno's standard per-user uninstall key under
  `HKCU\...\Uninstall\{AppId}_is1`. No custom `[Registry]` entries. Uninstall
  removes it, leaving no orphan keys.

---

## 4. Components and payload

| Component | Default | Contents | Destination |
|---|---|---|---|
| `libraries` (fixed) | always | 5 core `Bastion.Krypton.*` assemblies + `.xml` + `.pdb`, all 11 TFMs; plus Extended `Bastion.Krypton.Extended.*` assemblies | `{app}\lib\<tfm>\`, `{app}\lib-extended\<tfm>\` |
| `docs` | on (full/compact) | CHM help (69 MB) + PDF manual | `{app}\Documentation\` |
| `themebrowser` | on (full) | Theme Browser app, .NET 8 self-contained folder | `{app}\ThemeBrowser\` |
| `samples` | on (full) | C# + VB.NET sample **source** (build output excluded) + Extended examples source | `{app}\Samples\` |

Always installed (any component set): `DesignerIntegration.md`, `LICENSE.txt`,
`README-INSTALL.txt` at `{app}` root.

**Target frameworks shipped (11):** `net46, net47, net472, net48, net481,
net5.0-windows, net6.0-windows, net7.0-windows, net8.0-windows, net9.0-windows,
net10.0-windows`. Each core `lib\<tfm>` folder holds 15 files (5 DLL + 5 XML + 5
PDB).

**Third-party dependency DLLs:** per spec §8.2 and the task brief, the installer
ships only the `Bastion.Krypton.*` assemblies (+ XML + PDB). Third-party
dependency DLLs physically present in each module's build output are **not**
shipped - resolving those is an SDK-consumer concern, and **NuGet is the
recommended consumption path** (stated in both readmes). The installer is for
offline / designer / evaluation use.

### 4.1 Extended modules deliberately excluded (third-party licence)

Per `docs\audit\THIRD-PARTY-LICENCES.md` §3.1-3.2, two Extended modules are held
back from this release pending Chris's licence decision, and the build script
excludes them by name:

- **`Toggle.Switch`** - module-scale CPOL derivation (Johnny J, CodeProject).
- **`Software.Updater`** - contains SharpUpdate, which has **no upstream licence**
  (default all-rights-reserved). `Software.Updater.Core` (NetSparkle, MIT) is
  retained.

### 4.2 Pre-built sample binaries (spec §8.2 optional component) - NOT shipped

Spec §8.2 lists "pre-built sample binaries" as an *optional, unchecked-by-default*
component. Sample binaries were **not built** for this release, so the component
is intentionally omitted (the `[Components]` section documents this). Samples ship
as **source** via the `samples` component, which matches the spec's primary
requirement ("Samples (both languages, source)").

---

## 5. Standard requirements - status

| Requirement (§8.2) | Status | How |
|---|---|---|
| LICENSE display (BSD-3 + attribution) | Done | `LicenseFile=LICENSE.txt` - combined BSD-3 (core, with Component Factory + Krypton Suite copyright) + MIT (Extended) + Bastion attribution + third-party summary shown on the wizard licence page |
| Version-stamped | Done | `AppVersion` / `VersionInfoVersion` / `VersionInfoProductVersion` = `{#MyAppVersion}` (default 1.0.0); drives `OutputBaseFilename` |
| Upgrade-in-place (same AppId) | Done + tested | Fixed AppId; §6 lifecycle test confirms in-place upgrade |
| Silent-install (`/VERYSILENT`) | Done + tested | All lifecycle installs/upgrade/uninstall ran `/VERYSILENT /SUPPRESSMSGBOXES` |
| Uninstaller clean (no orphans) | Done + tested | `{app}`-scoped install, no custom registry; §6 confirms empty dir + no registry key after uninstall |
| Start Menu shortcuts | Done | Help (CHM), Manual (PDF), Theme Browser, Designer Integration Guide, Uninstall |
| Unsigned + signtool hook | Done | See §7 |

---

## 6. Lifecycle test (spec §8.2 - install -> use -> upgrade -> uninstall)

Run against a **clean sandbox directory** (`artifacts\installer-test\install`),
not a machine-wide location, to avoid polluting the system. Because the installer
is per-user, no admin rights were needed and every step completed in this
environment.

### Install (1.0.0) - PASS
`/VERYSILENT /SUPPRESSMSGBOXES /NORESTART /DIR=<sandbox> /LOG=... /COMPONENTS=libraries,docs,themebrowser,samples`
- Exit code **0**.
- Verified landed: `lib\` (all 11 TFMs), `lib\net8.0-windows\` with all 5
  `Bastion.Krypton.*.dll`; `lib-extended\net8.0-windows\` = 57 module DLLs
  (Toggle.Switch / Software.Updater absent, as intended); `Documentation\` (CHM +
  PDF); `ThemeBrowser\KryptonThemeBrowser.exe`; `Samples\` (StandardToolkit +
  ExtendedExamples); root readmes + `LICENSE.txt`. Total 6004 files.

### Use - PASS
A scratch **.NET 8** WinForms project (`artifacts\installer-test\consume`)
referenced the **installed** `lib\net8.0-windows\Bastion.Krypton.Toolkit.dll` by
`HintPath`, built clean (0 warnings, 0 errors), and ran:
```
Loaded: Bastion.Krypton.Toolkit v1.0.0.0
Location: ...\Bastion.Krypton.Toolkit.dll
KryptonButton.Text = Bastion
KryptonManager global palette mode: Microsoft365Blue
CONSUME-OK
```
`KryptonButton` and `KryptonManager` instantiated at runtime from the installed
assembly - the installed library is consumable.

### Upgrade (1.0.1 over 1.0.0) - PASS
Built `Setup.exe` v1.0.1 (`build-installer.ps1 -Version 1.0.1 -SkipStaging`) and
silently installed over the same directory.
- Exit code **0**.
- File count unchanged (6004 -> 6004): files **replaced**, not duplicated.
- Single uninstaller (`unins000.exe`, no `unins001`): in-place, not side-by-side.
- Exactly **one** uninstall registry key; `DisplayVersion` **1.0.0 -> 1.0.1**.
- Install directory unchanged.

### Uninstall - PASS
Ran `unins000.exe /VERYSILENT /SUPPRESSMSGBOXES /NORESTART`.
- Exit code **0**.
- Install directory **removed entirely** (0 remaining files - no orphans).
- **0** remaining uninstall registry keys.
- Start Menu group removed.

**All four steps PASS.** `/VERYSILENT` verified across install, upgrade and
uninstall.

### What still needs a real clean VM
The full lifecycle succeeded in this per-user sandbox, so nothing is *blocked*.
The following are worth a final pass on a clean Windows VM before public release,
because they cannot be exercised here:
- **SmartScreen / Mark-of-the-Web behaviour** of the unsigned Setup.exe when
  downloaded (the "Windows protected your PC" prompt) - only reproduces on a
  machine that received the file via a browser with MOTW.
- **All-users (elevated) install path** (`PrivilegesRequiredOverridesAllowed`) -
  the sandbox test used the per-user default; the elevated `{autopf}` path and
  its admin uninstall should be smoke-tested with real UAC.
- **Interactive wizard UX** (licence page rendering, component tree, Start Menu
  shortcuts launching CHM/Theme Browser) - verified structurally here via silent
  runs; a human should click through once.
- **Clean-machine consumption** without the .NET SDKs/Krypton dev tree present,
  to confirm no hidden dependency on the build environment.

---

## 7. Code-signing hook (currently UNSIGNED)

The installer ships **unsigned** for the first release. Unsigned installers trip
**Windows SmartScreen** ("Windows protected your PC" - the user must click *More
info* then *Run anyway*). This is flagged in `README-INSTALL.txt` and
`DesignerIntegration.md`.

A signtool hook is present in `BastionKryptonSuite.iss` (commented out):
```
;SignTool=signtool $f
;SignedUninstaller=yes
```
To enable signing once Chris has a code-signing certificate:
1. Define a sign tool named `signtool` - either in the IDE
   (*Tools > Configure Sign Tools...*) or on the ISCC command line
   (`/Ssigntool="C:\...\signtool.exe" sign /fd sha256 /tr <timestamp-url> /td sha256 /a $f`),
   where `$f` expands to the file being signed.
2. Uncomment the two directives above. `SignedUninstaller=yes` also signs the
   extracted uninstaller.
No other change is required; the rest of the script is signing-agnostic.

---

## 8. How to rebuild

```powershell
# Full build (stage payload + compile) -> artifacts\installer\...1.0.0 Setup.exe
pwsh Installer\build-installer.ps1

# Recompile only (reuse staged payload), e.g. an upgrade variant
pwsh Installer\build-installer.ps1 -Version 1.0.1 -SkipStaging
```
`build-installer.ps1` stages only the shippable files into
`artifacts\installer-staging\`, then invokes ISCC with
`/DMyAppVersion`, `/DStageDir`, `/DOutputDir`. Compiling the `.iss` directly
without staging first will fail on missing `Source` files - always build through
the wrapper.
