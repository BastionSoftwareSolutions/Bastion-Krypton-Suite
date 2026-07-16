# Assembly Rename Investigation — `Krypton.*` → `Bastion.Krypton.*`

**Phase 7 (Packaging) pre-work — the load-bearing design decision before packaging.**
Owner: Chris, Bastion Software Solutions Ltd · Executor: Claude Code · Date: 2026-07-16
Spec references: §8.1 (NuGet packaging), ground rule 3 (no namespace/type renames), §3.4 (designer best-effort).

---

## 0. Verdict (read this first)

**CLEAN — proceed. No escalation to Chris required.**

The rename is mechanically trivial and drop-in-safe. Renaming **only the assembly file** (`<AssemblyName>`)
while leaving `<RootNamespace>`, all namespaces, and all public type names as `Krypton.Toolkit.*` was
proved end-to-end on the Toolkit library plus its full designer surface:

- All five core libraries build **0 warnings / 0 errors** on `net8.0-windows` against the renamed
  `Bastion.Krypton.Toolkit.dll` (desktop MSBuild 18.7.8, foreground, `-nr:false`).
- A runtime probe (loads the renamed assemblies, instantiates 8 controls across all 5 libraries,
  drives `TypeDescriptor` editor/converter resolution) **PASSED** — see §3.
- The Toolkit rename on its own required **zero** source fixes.

The mass rename (all five core assemblies + every Extended module) needs a **small, fully-enumerated
fix surface** — **2 live attribute strings + 3 `InternalsVisibleTo` names** that are load-bearing,
plus 5 cosmetic `Dependency` hints and Bastion's own consumer/tooling DLL-path references. All are
listed in §4 with exact file:line locations.

Licensing (`licenses.licx` / `LicenseProvider`) is **not applicable** — Krypton uses no component
licensing (§5). Designer toolbox bitmap resolution is **unaffected** (§2).

---

## 1. The rename mechanism (what was done in the PoC)

On `Krypton.Toolkit 2022.csproj` only:

```diff
  <RootNamespace>Krypton.Toolkit</RootNamespace>
- <AssemblyName>Krypton.Toolkit</AssemblyName>
+ <AssemblyName>Bastion.Krypton.Toolkit</AssemblyName>
```

Result: output file `Bin\Release\net8.0-windows\Bastion.Krypton.Toolkit.dll`, whose **internal
assembly identity, all namespaces, and all public types remain `Krypton.Toolkit.*`**. Consumers keep
writing `using Krypton.Toolkit;` unchanged — only the physical file/reference name changes.

### Why the usual breakage vectors do NOT bite

| Vector | Finding | Status |
|---|---|---|
| Other 4 libs reference Toolkit | All via `<ProjectReference>` — output filename follows the project automatically. Ribbon/Navigator/Workspace/Docking all rebuilt 0/0 against the renamed DLL. | Safe |
| `InternalsVisibleTo` (Toolkit grants to Navigator, Ribbon) | Names the **consumer** assemblies, which were **not** renamed in the PoC, so the grants stayed valid and Ribbon/Navigator still compiled against Toolkit internals. Uses full `PublicKey=` (not token) + same `StrongKrypton.snk`, so the key half is rename-invariant. | Safe (PoC); fix names on full rename — §4.B |
| `[assembly: AssemblyTitle]` etc. | `GenerateAssemblyInfo=true` — the SDK derives `AssemblyTitle`/`AssemblyProduct` from `$(AssemblyName)`. This is cosmetic metadata; it does not affect binding. No hand-written `AssemblyInfo.cs` hard-codes the name. | Safe |
| `.snk` strong naming | `SignAssembly=True`, `AssemblyOriginatorKeyFile=StrongKrypton.snk` unchanged. The signed identity's **name** changes (expected — that is the whole point, to avoid GAC/bind collisions with upstream `Krypton.*`); the **public key/token** is unchanged. Nothing hard-codes a name+token pair in code. | Safe |
| resx / embedded-resource manifest names | Manifest names derive from **`RootNamespace`** (`Krypton.Toolkit`), not `AssemblyName`. Probe confirmed **179/179** Toolkit manifest resources still start `Krypton.Toolkit`. | Safe — verified |
| `Assembly.Load("Krypton.Toolkit")` / hard-coded `"Krypton.Toolkit.dll"` in code | **None live.** Only one commented-out `Assembly.LoadFile(...\Krypton.Toolkit.dll)` (`VisualAboutBoxForm.cs:340`). No `Assembly.Load` by simple name, no assembly-qualified `Type.GetType` over Krypton assemblies. | Safe |
| `Assembly.GetExecutingAssembly().GetName().Name` | Used only to **display** the assembly name in the About-box grid (`KryptonAboutBoxUtilities.cs:263`). After rename it correctly reads `Bastion.Krypton.Toolkit`. Cosmetic, not a break. | Safe |
| `GetManifestResourceStream("Krypton.Navigator.Resources.BlueUp.bmp")` (Navigator) | Uses the **namespace-derived** resource name, not the assembly name. Unaffected. | Safe |

---

## 2. Designer / toolbox implications

- **`[ToolboxBitmap(typeof(T), "Name")]`** resolves the bitmap from the type's assembly using a
  resource name built from the type's **namespace** (`Krypton.Toolkit.*`) — not the assembly simple
  name. Because manifest resource names track `RootNamespace` (verified 179/179), toolbox-bitmap
  resolution is unaffected by the file rename.
- **Assembly-qualified attribute strings** (`[Designer("...T, Krypton.X")]`, `[Editor("...T, Krypton.X")]`,
  `[TypeConverter("...T, Krypton.X")]`) are the ONLY real breakage risk: each embeds the OLD assembly
  simple name and fails to resolve once that assembly is renamed. A full-suite sweep for
  `, Krypton.(Toolkit|Ribbon|Navigator|Workspace|Docking)"` found **only 3 occurrences, 2 of them live**:

  | # | File:line | Attribute | Names assembly |
  |---|---|---|---|
  | 1 | `Krypton.Workspace\Controls Workspace\KryptonWorkspaceSequence.cs:126` | `[Editor(@"Krypton.Workspace.KryptonWorkspaceCollectionEditor, Krypton.Workspace", typeof(UITypeEditor))]` | Krypton.Workspace (self) |
  | 2 | `Krypton.Ribbon\Palette\RibbonFileAppButton.cs:149` | `[Editor(@"Krypton.Ribbon.KryptonRibbonRecentDocCollectionEditor, Krypton.Ribbon", typeof(UITypeEditor))]` | Krypton.Ribbon (self) |
  | — | `Krypton.Toolkit\Controls Toolkit\KryptonComboBox.cs:25` | `//[Designer(@"...KryptonContextMenuDesigner, Krypton.Toolkit")]` — **commented out** | (none) |

  Both live strings **self-reference their own assembly**. Every other `[Designer]`/`[Editor]`/
  `[TypeConverter]` in the suite already uses `typeof(...)`, which bakes in the type's metadata token
  and is **assembly-name-agnostic** — those need no change.
- **No live `[Designer(...)]` or `[TypeConverter(...)]` assembly-qualified strings exist** anywhere in
  the five libraries.
- **resx-embedded assembly-qualified type refs** all point at `System.*` framework assemblies
  (`System.Drawing`, `System.Windows.Forms`) — never at a `Krypton.*` assembly. Unaffected.
- **VS toolbox registration** (dragging controls into the VS toolbox) keys off the assembly **file** a
  consumer adds — they add `Bastion.Krypton.Toolkit.dll` and controls appear under their unchanged type
  names. Per spec §3.4 this is a documented, best-effort, VS-side concern; the rename breaks none of the
  metadata that drives it.

---

## 3. PoC verification (build + runtime)

**Build (desktop MSBuild 18.7.8, `-nr:false`, `-m:1`, Release, `net8.0-windows`):**

| Project | Output | Result |
|---|---|---|
| Krypton.Toolkit (renamed) | `Bastion.Krypton.Toolkit.dll` | 0 warn / 0 err |
| Krypton.Ribbon | `Krypton.Ribbon.dll` (consumes renamed Toolkit internals) | 0 warn / 0 err |
| Krypton.Navigator | `Krypton.Navigator.dll` (consumes renamed Toolkit internals) | 0 warn / 0 err |
| Krypton.Workspace | `Krypton.Workspace.dll` | 0 warn / 0 err |
| Krypton.Docking | `Krypton.Docking.dll` | 0 warn / 0 err |

**Runtime designer-surface probe** (`net8.0-windows` WinExe, references the 5 built DLLs by path;
its own `using Krypton.Toolkit;` compiled unchanged — proving drop-in **source** compat). Output:

```
Toolkit assembly simple name : Bastion.Krypton.Toolkit
KryptonButton namespace       : Krypton.Toolkit
Manifest resources total=179, starting 'Krypton.Toolkit'=179
Instantiated + shown 8 controls across all 5 libs; KryptonForm handle=True
TypeDescriptor.GetConverter non-null for 8/8 controls
Property editors resolved (incl. assembly-qualified [Editor] strings): 108 over 996 properties
KryptonWorkspaceSequence type found: True
  editor resolved: Children -> Krypton.Workspace.KryptonWorkspaceCollectionEditor
Krypton-namespaced editors resolved on KryptonWorkspaceSequence: 1
RESULT: PASS   (exit 0)
```

The final two lines are the decisive designer proof: `TypeDescriptor.GetEditor` **successfully resolved
the assembly-qualified `[Editor(..., Krypton.Workspace)]` string** to
`Krypton.Workspace.KryptonWorkspaceCollectionEditor`. This works here because Workspace was **not**
renamed — which is exactly why that string (and the Ribbon one) MUST be updated when their assemblies
are renamed in the mass step (§4.A). The probe thus proves both that the mechanism is sound **and**
pinpoints the precise strings that would otherwise silently fail the VS designer after a full rename.

---

## 4. Fix surface for the mass rename (exact, enumerated)

### A. Load-bearing: assembly-qualified attribute strings — **2 files, 2 strings**
Break when the named assembly is renamed. **Recommended fix: convert to `typeof(...)`** (both editor
types live in the same assembly and are accessible), which is assembly-name-agnostic and never needs
touching again. Fallback: update the embedded name to `Bastion.Krypton.X`.
1. `Krypton.Workspace\Controls Workspace\KryptonWorkspaceSequence.cs:126`
2. `Krypton.Ribbon\Palette\RibbonFileAppButton.cs:149`

### B. Load-bearing: `InternalsVisibleTo` simple names — **2 files, 3 attributes**
Update the **simple name** only (the `PublicKey=` half is unchanged; same `.snk`):
1. `Krypton.Toolkit\Global\GlobalDeclarations.cs:103` → `Bastion.Krypton.Navigator, PublicKey=…`
2. `Krypton.Toolkit\Global\GlobalDeclarations.cs:104` → `Bastion.Krypton.Ribbon, PublicKey=…`
3. `Krypton.Ribbon\Global\GlobalDeclarations.cs:46` → `Bastion.Krypton.Toolkit, PublicKey=…`

> In the Toolkit-only PoC none of these needed changing (the grants name the *consumers*, which kept
> their names) — confirmed by the clean 0/0 dependent builds. They only become load-bearing once the
> **granted-to** assemblies are themselves renamed.

### C. Cosmetic / non-load-bearing: `[assembly: Dependency(...)]` hints — **4 files, 5 attributes**
`System.Runtime.AssemblyName.DependencyAttribute` is a legacy loader hint, **ignored by the modern CLR
for binding**. In the PoC these still named the now-nonexistent `Krypton.Toolkit` yet all four
dependents built and the probe ran — proving they are inert. Update for tidiness during the rename:
- `Krypton.Docking\Global\GlobalDeclarations.cs:43` (`Krypton.Toolkit`)
- `Krypton.Navigator\Global\GlobalDeclarations.cs:40` (`Krypton.Toolkit`)
- `Krypton.Workspace\Global\GlobalDeclarations.cs:40, 41` (`Krypton.Toolkit`, `Krypton.Navigator`)
- `Krypton.Ribbon\Global\GlobalDeclarations.cs:42` (`Krypton.Toolkit`)

### D. Cosmetic: commented / display-only
- `Krypton.Toolkit\Controls Visuals\VisualAboutBoxForm.cs:340` — commented `…\Krypton.Toolkit.dll` string. Optional tidy.
- `KryptonAboutBoxUtilities.cs:263` — displays the runtime assembly name; auto-correct after rename, no edit.

### E. Bastion's own consumers / tooling (NOT upstream source; handle in the packaging task)
Anything that references the core DLLs by **file path** must be repointed to `Bastion.Krypton.*.dll`:
- `Scripts\ThemeBrowser\ThemeBrowser.csproj` (`<Reference><HintPath>…Krypton.Toolkit.dll</HintPath>` etc.)
- `Scripts\SmokeTest\…`, `Scripts\ApiMatrix\…`, and any pack/build scripts and the `.sln` packaging paths.
  (These are why a *partial* rename must not be left in the tree — see §6.)

### Fix-surface totals
| Category | Files | Occurrences | Load-bearing? |
|---|---|---|---|
| Assembly-qualified `[Editor]` strings | 2 | 2 | **Yes** |
| `InternalsVisibleTo` names | 2 | 3 | **Yes** (on full rename) |
| `[assembly: Dependency]` hints | 4 | 5 | No (cosmetic) |
| Commented / display-only | 2 | 2 | No |
| Bastion tooling DLL-path refs | ≥3 | — | Yes (tooling only) |

**Total load-bearing source edits for the five-library rename: 5** (2 editor strings + 3 IVT names).

---

## 5. Licensing (`licenses.licx` / `LicenseProvider`) — N/A, confirmed

- **No `.licx` files** anywhere in the tree.
- **No `[LicenseProvider]`, `LicenseManager.Validate`, `RuntimeLicenseContext`, or `License` field** usage.
- The only `LicenseManager` references are `LicenseManager.UsageMode == LicenseUsageMode.Designtime`
  (`ShadowManager.cs`, `CommonHelper.cs`, `DesignModeHelper.cs`) — the standard WinForms **design-mode
  detection** idiom, which is assembly-name-agnostic and unaffected by the rename.

Krypton is BSD-3 and ships no component licensing, so the spec's `licenses.licx` concern is closed as
not-applicable. The `licenses.licx` mechanism (had it existed) embeds assembly-qualified type names and
*would* have needed updating — recorded here for completeness in case an Extended module introduces one.

---

## 6. Recommended mechanism

1. **Set `<AssemblyName>` explicitly per library** — `Bastion.Krypton.Toolkit`, `Bastion.Krypton.Ribbon`,
   `Bastion.Krypton.Navigator`, `Bastion.Krypton.Workspace`, `Bastion.Krypton.Docking` (and
   `Bastion.Krypton.Extended.<Module>` per Extended module). Five deliberate, greppable, auditable edits.
   Leave `<RootNamespace>` and `<PackageId>`… note: `<PackageId>` also becomes `Bastion.Krypton.*` per §8.1.
   *(Alternative considered: compute centrally in a `Directory.Build.targets` as
   `<AssemblyName>Bastion.$(RootNamespace)</AssemblyName>` after `RootNamespace` is set. Works, but would
   also rename non-shipping projects like `TestForm`, and is less obvious in review — prefer the explicit
   per-project form.)*
2. **Make the 2 assembly-qualified `[Editor]` strings assembly-agnostic** by switching them to
   `typeof(KryptonWorkspaceCollectionEditor)` / `typeof(KryptonRibbonRecentDocCollectionEditor)` (§4.A) —
   so they survive this and any future rename with no maintenance.
3. **Update the 3 `InternalsVisibleTo` simple names** to `Bastion.Krypton.*` (§4.B), keeping the
   `PublicKey=` value verbatim.
4. **Update the 5 `Dependency` hints** for tidiness (§4.C) — non-blocking.
5. **Repoint Bastion tooling DLL-path references** (§4.E) as part of the same atomic change.
6. Do the rename **all-at-once for the whole suite** (core + Extended) so the tree never sits in a
   half-renamed state where some DLLs are `Bastion.Krypton.*` and consumers still reference `Krypton.*`.

No `#if`, no polyfill, no per-TFM special-casing — the rename is TFM-independent.

---

## 7. State left in the repo

- **Standard-Toolkit (`bastion/multitarget`): reverted to original — no changes kept.** The PoC edit to
  `Krypton.Toolkit 2022.csproj` was `git checkout`-reverted; `git status` is clean. Toolkit was rebuilt so
  `Bin\Release\net8.0-windows\Krypton.Toolkit.dll` is restored; the stray `Bastion.Krypton.Toolkit.*`
  build artifacts and the probe result file were removed from `Bin`. **The mass rename remains an
  unstarted, clean, deliberate step for the packaging task** — as instructed, and because leaving only
  Toolkit renamed would break the existing ThemeBrowser/SmokeTest DLL-path references (§4.E).
- **Workspace (`main`): this document added** (`docs/audit/ASSEMBLY-RENAME.md`) and committed.
- The PoC probe project lives only in the session scratchpad (not committed).

## 8. Escalation to Chris

**None required.** The rename is clean; the fix surface is 5 load-bearing source edits plus tooling
path updates, all enumerated above. Proceed with the mass rename during Phase 7 packaging using the §6
mechanism. (For awareness, per spec §3.4/§8.2: VS *toolbox* registration remains a documented,
best-effort, consumer-side concern — the rename does not regress it, but the installer's "Designer
integration" readme should reference the `Bastion.Krypton.*.dll` filenames.)
