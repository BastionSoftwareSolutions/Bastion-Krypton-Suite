# Bastion Krypton Suite - Inno Setup Installer Report

**Project:** Bastion Krypton Suite (Enhanced, beginner-first installer)
**Toolchain:** Inno Setup 6 (`ISCC.exe`), Desktop MSBuild 18.7
**Built:** 2026-07-17 (UK)
**Author:** Bastion Software Solutions Ltd

---

## 1. Deliverables

| Artefact | Path |
|---|---|
| Inno Setup script | `Installer\BastionKryptonSuite.iss` |
| Build wrapper (stage + compile) | `Installer\build-installer.ps1` |
| Combined licence (BSD-3 + MIT + notices) | `Installer\LICENSE.txt` |
| Beginner Getting Started guide | `Installer\GettingStarted.html` |
| Ready-to-run demos readme (.NET 8 note) | `Installer\SAMPLES-COMPILED-README.txt` |
| Designer integration readme | `Installer\DesignerIntegration.md` |
| Post-install readme (SmartScreen note) | `Installer\README-INSTALL.txt` |
| This report | `docs\audit\INSTALLER-REPORT.md` |
| **Built installer (git-ignored)** | `artifacts\installer\Bastion Krypton Suite 1.0.0 Setup.exe` |

**Installer size:** **270.4 MB (283,552,698 bytes)** for `Bastion Krypton Suite
1.0.0 Setup.exe`. Staged raw payload ≈ **1.2 GB**, compressed with solid
LZMA2/max.

### Which Setup.exe is the real one, and the size note
The only file now in `artifacts\installer\` is the enhanced **1.0.0** build above.
A previous Phase 7 `...1.0.1 Setup.exe` (378 MB) was the *superseded* per-user
build (no sample binaries, no HTML help site) and has been deleted to avoid
confusion. The enhanced installer bundles **much more** (the 250 demo binaries +
the 234 MB HTML help site) yet is **smaller** than the old one, because its
payload is dominated by highly-compressible content: the HTML site is text
(~10:1), and the pre-built app folders contain many byte-identical copies of the
same `Bastion.Krypton.*.dll` assemblies that also live under `lib\` and
`lib-extended\`. Solid LZMA2 deduplicates those repeats across the whole archive,
so a 1.2 GB raw payload collapses to 270 MB (≈4.4:1) versus the old build's
645 MB → 378 MB (≈1.7:1).

The `artifacts\` tree is git-ignored, so the Setup.exe, staging tree and the
lifecycle-test sandbox are not committed. The `.iss`, scripts, readmes, licence,
Getting Started page and this report are committed to `main`.

---

## 2. Fixed AppId GUID (KEEP STABLE FOR ALL FUTURE UPGRADES)

```
AppId = {{9D307380-9B7C-4DC7-A58D-75CAB5116E96}
```

Unchanged from Phase 7. This GUID identifies the product to Windows and drives
upgrade-in-place; it **must never change** across releases. (The doubled leading
brace is Inno's required escaping for a literal `{`.)

**Scope change vs Phase 7:** the install moved from **per-user** to **per-machine
(Program Files)** — see §3. Because the AppId is unchanged, a per-machine install
upgrades cleanly. Note the one-off caveat that a machine still carrying the old
per-user 1.0.0 in `%LOCALAPPDATA%` would see the new per-machine copy in Program
Files rather than an in-place overwrite of the per-user tree; the recommended path
for existing users is to uninstall the old per-user copy once.

---

## 3. Install profile (STANDARD location)

- **Per-machine.** `PrivilegesRequired=admin` — the installer elevates via UAC.
- **Default location:** `{autopf}\Bastion Krypton Suite`
  (i.e. `C:\Program Files\Bastion Krypton Suite`).
- **Registry footprint:** only Inno's standard per-machine uninstall key under
  `HKLM\...\Uninstall\{AppId}_is1`. No custom `[Registry]` entries; uninstall
  removes it, leaving no orphan keys.

---

## 4. Components and payload

Default (Full) selection installs everything. `samples_bin` — the beginner
"just run it" path — is **checked by default**.

| Component | Default | Contents | Destination |
|---|---|---|---|
| `libraries` (fixed) | always | 5 core `Bastion.Krypton.*` assemblies + `.xml` + `.pdb`, all 11 TFMs; plus Extended `Bastion.Krypton.Extended.*` assemblies | `{app}\lib\<tfm>\`, `{app}\lib-extended\<tfm>\` |
| `samples_bin` | **on** | Pre-built runnable apps (.NET 8): Krypton Explorer + 250 demo EXEs, Extended `Examples.exe`, Theme Browser — each a self-contained folder | `{app}\Samples-Compiled\{Demos,ExtendedExamples,ThemeBrowser}\` |
| `docs` | on | CHM help + PDF manual + **HTML help site** | `{app}\Documentation\` and `{app}\Documentation\html\` |
| `samples_src` | on (full) | C# + VB.NET sample **source** + Extended examples source | `{app}\Samples\{StandardToolkit,ExtendedExamples}\` |

Always installed: `GettingStarted.html`, `DesignerIntegration.md`, `LICENSE.txt`,
`README-INSTALL.txt` at `{app}` root; `SAMPLES-COMPILED-README.txt` under
`Samples-Compiled\`.

**Target frameworks shipped (11):** `net46, net47, net472, net48, net481,
net5.0-windows … net10.0-windows`. Each `lib\<tfm>` holds the 5 core assemblies
(DLL + XML + PDB).

### 4.1 Pre-built binaries — how they were produced (Step 1)
- **Demos:** built `Krypton Explorer 2022 - Dev.sln` with
  `/p:SampleTfm=net8.0-windows` (Release) via Desktop MSBuild — 263-project
  solution, **0 errors**, ~2m46s. Output:
  `Standard-Toolkit-Demos\Binaries\Krypton Demos\Release\net8.0-windows\`
  = the **Krypton Explorer** launcher + **250** sample EXEs, all referencing the
  renamed `Bastion.Krypton.*.dll` (co-located so they run standalone).
- **Extended Examples:** built `Examples.csproj` with
  `/p:ActiveExtendedToolkitTFMs=net8.0-windows` → `Examples.exe`
  (`Extended-Toolkit\Bin\Examples\Release\net8.0-windows\`, 82 DLLs alongside).
- **Theme Browser:** `Scripts\ThemeBrowser\bin\Release\net8.0-windows\`
  `KryptonThemeBrowser.exe` (references `Bastion.Krypton.*.dll`).

Each app folder is self-contained (its `Bastion.Krypton.*` + dependency DLLs sit
next to the EXE), so a beginner can double-click and see the controls/themes with
no Visual Studio. **Requires the free .NET 8 Desktop Runtime** — not bundled;
`SAMPLES-COMPILED-README.txt`, `GettingStarted.html` and `README-INSTALL.txt` all
point to <https://dotnet.microsoft.com/download/dotnet/8.0>.

### 4.2 lib-extended sourcing note
`build-installer.ps1` regenerates `lib-extended\` from
`Extended-Toolkit\Bin\Release` only when that tree is a full multi-TFM build;
otherwise it **preserves** the existing staged `lib-extended\` (11 TFMs from the
last full extended build). This prevents a single-TFM Examples build (which leaves
`Bin\Release` at net8 only) from shipping a partial extended set. Pass
`-ForceExtendedFromBin` to override after a full multi-TFM extended build.

### 4.3 Extended modules deliberately excluded (third-party licence)
Per `docs\audit\THIRD-PARTY-LICENCES.md` §3.1–3.2, `Toggle.Switch` (CPOL) and
`Software.Updater` (contains SharpUpdate, no upstream licence) are held back;
`Software.Updater.Core` (NetSparkle, MIT) is retained.

---

## 5. Licence display, Start Menu, misc

- **Licence shown during install:** `LicenseFile=LICENSE.txt` renders the combined
  **BSD-3-Clause (core, Component Factory + Krypton Suite copyright) + MIT
  (Extended) + Bastion attribution + third-party notices** on the wizard licence
  page. `LICENSE.txt` is also installed to `{app}`.
- **Start Menu group (`{group}`) — beginner-first set (9 icons):**
  1. Krypton Explorer (Browse Demos) → the demo launcher EXE
  2. Theme Browser → `KryptonThemeBrowser.exe`
  3. Extended Toolkit Examples → `Examples.exe`
  4. Help (CHM)
  5. Online-style Help (HTML) → `Documentation\html\index.html`
  6. Developer Manual (PDF)
  7. Getting Started → `{app}\GettingStarted.html`
  8. **Bastion Krypton Suite Folder → `{app}`** (opens the install folder in
     Explorer — the explicit user request)
  9. Uninstall Bastion Krypton Suite
- Version-stamped (`AppVersion` / `VersionInfoVersion` = 1.0.0), upgrade-in-place
  (fixed AppId), `/VERYSILENT` supported, no custom registry, signtool hook
  present but commented (unsigned; SmartScreen note in the readmes).

---

## 6. Lifecycle test (clean sandbox — no real Program Files)

Run against `artifacts\installer-test\install` via `/DIR=` to avoid polluting
Program Files. The environment shell was elevated, so the per-machine (admin)
Setup.exe ran without an interactive UAC prompt.

### Install — PASS
`Setup.exe /VERYSILENT /SUPPRESSMSGBOXES /NORESTART /DIR=<sandbox> /LOG=...`
(default = Full: all four components)
- Exit code **0**. **11,249** files installed.
- Verified present:
  - `lib\` **11 TFMs**; `lib\net8.0-windows\` has all **5** `Bastion.Krypton.*.dll`.
  - `lib-extended\` **11 TFMs**.
  - `Documentation\`: **CHM + PDF + `html\index.html`** (HTML help site).
  - `Samples-Compiled\Demos\Krypton Explorer.exe` + **250** demo EXEs;
    `ExtendedExamples\Examples.exe`; `ThemeBrowser\KryptonThemeBrowser.exe`.
  - `Samples\StandardToolkit` + `Samples\ExtendedExamples` (source).
  - `LICENSE.txt`, `GettingStarted.html`, `DesignerIntegration.md`,
    `Samples-Compiled\SAMPLES-COMPILED-README.txt`.

### Ready-to-run demos LAUNCH — PASS
Each app was started from the **installed** folder, confirmed alive after 5s, then
terminated:
- **Krypton Explorer** — PASS (process alive 5s).
- **Theme Browser** — PASS (process alive 5s).
- **Extended Examples** — PASS (process alive 5s).
(The machine has .NET Desktop Runtime 8.0.28 installed.)

### Start Menu / folder shortcut — PASS
All **9** `.lnk` files created in the common Start Menu group. The **"Bastion
Krypton Suite Folder"** shortcut resolves to `{app}`
(`...\installer-test\install`) — i.e. it opens the install directory in Explorer.
The "Krypton Explorer (Browse Demos)" shortcut resolves to the launcher EXE.

### Uninstall — PASS
`unins000.exe /VERYSILENT /SUPPRESSMSGBOXES /NORESTART`
- Exit code **0**. Install directory **removed entirely** (0 remaining files).
- Start Menu group **removed**. **0** remaining uninstall registry keys.

**All lifecycle steps PASS**, including the demo EXEs actually launching.

### What still needs a real admin VM
The sandbox `/DIR` install exercised the admin/per-machine path with an already
elevated shell. A final pass on a clean Windows VM is still worth doing for:
- **Interactive UAC elevation** of the unsigned Setup.exe from a non-elevated
  session (the consent prompt itself).
- **SmartScreen / Mark-of-the-Web** ("Windows protected your PC") for the unsigned
  Setup.exe downloaded via a browser.
- **Real `C:\Program Files` install + admin uninstall**, and the interactive
  wizard UX (licence page rendering, component tree, shortcuts launching).
- **Clean-machine run without the .NET 8 Desktop Runtime**, to confirm the readme
  guidance surfaces correctly when a demo cannot start.

---

## 7. Code-signing hook (currently UNSIGNED)

Ships **unsigned** for the first release (trips SmartScreen — *More info* →
*Run anyway*; flagged in the readmes). Hook present but commented in the `.iss`:
```
;SignTool=signtool $f
;SignedUninstaller=yes
```
Enable by defining a `signtool` command (IDE *Tools > Configure Sign Tools…* or
`/Ssigntool=...` on the ISCC line, `$f` = file being signed) and uncommenting.

---

## 8. How to rebuild

```powershell
# 1. Build the runnable binaries (once, per release):
#    Demos:
& $msbuild "Standard-Toolkit-Demos\Source\Krypton Explorer\Krypton Explorer 2022 - Dev.sln" `
    /p:Configuration=Release /p:SampleTfm=net8.0-windows /m /nr:false /restore
#    Extended Examples:
& $msbuild "Extended-Toolkit\Source\Krypton Toolkit\Examples\Examples.csproj" `
    /p:Configuration=Release /p:ActiveExtendedToolkitTFMs=net8.0-windows /m /nr:false /restore

# 2. Stage payload + compile installer:
pwsh Installer\build-installer.ps1                    # -> ...1.0.0 Setup.exe
pwsh Installer\build-installer.ps1 -Version 1.0.1 -SkipStaging   # recompile only
```
`build-installer.ps1` stages `lib`, `lib-extended`, `Documentation` (CHM + PDF +
HTML site), `Samples` (source) and `Samples-Compiled` (the runnable apps), then
invokes ISCC with `/DMyAppVersion`, `/DStageDir`, `/DOutputDir`. Always build
through the wrapper (a bare `.iss` compile fails on missing staged Source files).
