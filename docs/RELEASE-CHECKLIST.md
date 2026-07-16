# Release checklist — Bastion Krypton Suite

Ordered steps for **Chris** to publish. Nothing here has been done by the build agent —
**nothing is pushed**. Everything is staged locally, push-ready, across the four
repositories (see `REPO-LAYOUT.md`).

> UK English throughout. The build agent never runs `git push`, never creates GitHub repos,
> never touches nuget.org. These are your steps.

---

## 0. Before you start — decisions to close

Publishing is blocked on a handful of **owner decisions** (full list in §9 below). At
minimum, confirm the **version scheme** (§9.1) and the **licence exclusions** (§9.3) before
tagging — they change what ships. The theme sign-off (§9.2) can trail the code release if
you release the libraries first and the theme gallery second, but the spec's acceptance
item 5 is not green until you sign off.

## 1. Final baseline re-check (spec §10 item 1)

The baseline was fixed at **Standard-Toolkit `V105-LTS` @ 57824ec4** and **Extended-Toolkit
`V105-LTS` @ 2725d8c4** (15 Jul 2026; see BUILD-LOG Phase 1). Before tagging, re-verify
nothing newer stable has shipped that you want to fold in:

- [ ] Check https://www.nuget.org/packages/Krypton.Toolkit for a newer stable than
      105.26.4.110, and the upstream `V105-LTS` branches for post-baseline LTS fixes.
- [ ] If you take newer upstream, merge it into `bastion/multitarget` (never rebase/rewrite
      upstream history) and re-run `./build-all.ps1`; record the delta in `CHANGES.md`.
- [ ] Confirm `Bastion.Krypton.*` package IDs are still unclaimed on nuget.org (they were
      404 at packaging time — re-check just before pushing).

## 2. Confirm a clean, reproducible build

- [ ] From a clean checkout of all four repos in the required layout, run:
      `./build-all.ps1` (or `-Docs All` to include CHM+PDF, `-SkipInstaller` to skip Inno).
      This is the spec §9 exit criterion: one command reproduces the full artefact set.
- [ ] Artefacts land in `artifacts\nuget\` (57 nupkg + 56 snupkg), `docs-site\`,
      `Help\*.chm` / `Help\*.pdf` (with `-Docs All`), and the installer via
      `Installer\build-installer.ps1`.

## 3. Push the branches (order: sources first, umbrella last)

Confirm the repo names first (§9 of `REPO-LAYOUT.md` — recommended names, your call):

- [ ] **Standard-Toolkit** → push `bastion/multitarget` (and its upstream branches, kept
      intact) to your core fork.
- [ ] **Extended-Toolkit** → push `bastion/multitarget` to your Extended fork.
- [ ] **Standard-Toolkit-Demos** → push `bastion/multitarget` to your demos fork.
- [ ] **umbrella (Krypton-Ultimate)** → push `main` to the new suite repo.
- [ ] In each source fork's **Actions settings, DISABLE the inherited upstream workflows**
      (release.yml, canary.yml, nightly.yml, repo-mirror.yml, sync-*, templates-release.yml,
      …) — they target the Krypton-Suite org's runners/secrets and will fail or spam on your
      fork. Keep only `bastion-build.yml` (core/Extended) and the umbrella's `build.yml`.
- [ ] Set the CI repo **variables** on the forks that need siblings: `CORE_REPO`, `EXT_REPO`
      (owner/name of your forks) and, if not `bastion/multitarget`, `CORE_REF` / `EXT_REF`.
      Otherwise the workflows use the placeholder defaults in the YAML.

## 4. Tag each repo

Recommended tag: **`v1.0.0`** on each repo's published branch (SemVer 1.0.0 — see §9.1).
If you adopt the upstream-aligned scheme instead, use e.g. `v105.26.7.x` consistently.

- [ ] `git tag -a v1.0.0 -m "Bastion Krypton Suite 1.0.0"` in each of the four repos (on the
      pushed commit), then `git push origin v1.0.0`.
- [ ] Keep the tag identical across all four repos so a consumer can check out one version.

## 5. GitHub Release (on the umbrella repo)

- [ ] Create a **GitHub Release** from tag `v1.0.0` on the umbrella repo.
- [ ] Release notes: summarise and **link to `CHANGES.md`** (the definitive record) and the
      per-TFM feature matrix. State the EOL-runtime warning and the drop-in-compatibility
      note (namespaces unchanged, `Bastion.` assembly/package prefix only).
- [ ] Attach the **installer**: `Bastion Krypton Suite 1.0.0 Setup.exe` (~361 MB).
- [ ] Attach the **57 nupkgs** (and optionally the 56 snupkg symbol packages) from
      `artifacts\nuget\`. (GitHub is fine as a mirror; nuget.org is the primary feed — §6.)
- [ ] Note in the release that the installer is **unsigned** (see §8, SmartScreen).

## 6. Publish to nuget.org (your API key — stays with you)

The build agent never pushes. Push the packages yourself, core first (Extended depends on
core), from `artifacts\nuget\`:

```powershell
$key  = '<YOUR_NUGET_API_KEY>'
$feed = 'https://api.nuget.org/v3/index.json'

# Push symbols alongside: nuget.org picks up the .snupkg when the .nupkg is pushed.
# Core first (BSD-3-Clause), then the Suite metapackage:
dotnet nuget push "artifacts\nuget\Bastion.Krypton.Toolkit.1.0.0.nupkg"   -k $key -s $feed
dotnet nuget push "artifacts\nuget\Bastion.Krypton.Ribbon.1.0.0.nupkg"    -k $key -s $feed
dotnet nuget push "artifacts\nuget\Bastion.Krypton.Navigator.1.0.0.nupkg" -k $key -s $feed
dotnet nuget push "artifacts\nuget\Bastion.Krypton.Workspace.1.0.0.nupkg" -k $key -s $feed
dotnet nuget push "artifacts\nuget\Bastion.Krypton.Docking.1.0.0.nupkg"   -k $key -s $feed
dotnet nuget push "artifacts\nuget\Bastion.Krypton.Suite.1.0.0.nupkg"     -k $key -s $feed

# Then every Extended module package + the Ultimate metapackage (MIT / "MIT AND MS-PL").
# Bulk-push the remainder in one go (nuget.org de-dupes already-pushed ids):
Get-ChildItem "artifacts\nuget\Bastion.Krypton.Extended.*.nupkg" |
    ForEach-Object { dotnet nuget push $_.FullName -k $key -s $feed --skip-duplicate }
```

- [ ] Verify each package page renders (readme, licence expression, icon, dependency groups)
      before announcing. The licence split must read **BSD-3-Clause** (core/Suite),
      **MIT** (most Extended), **MIT AND MS-PL** (Outlook.Grid, AdvancedDataGridView,
      Extended.Ultimate).
- [ ] `Data.Visualisation` ships **10 TFMs (no net46)** by design — that is expected, not a
      defect.

## 7. Enable GitHub Pages for the DocFX site

- [ ] Build the site: `./build-docs.ps1 -Site` → output in `docs-site\`.
- [ ] Publish it. Either: (a) let the umbrella `build.yml` `docs` job's `bastion-docs-site`
      artefact feed a Pages deploy (add a `deploy-pages` step/job when ready), or (b) push
      `docs-site\` to a `gh-pages` branch and enable **Settings → Pages → Deploy from branch
      → gh-pages /(root)**.
- [ ] Confirm the site root loads and the API + conceptual TOC resolve. (Local build reports
      3,354 pages, 0 broken links.)

## 8. Installer signing / SmartScreen

- [ ] The installer is **unsigned**. Unsigned installers trip **Windows SmartScreen**
      ("Windows protected your PC" / "unknown publisher") until reputation accrues. This is
      called out in `README.md` and `Installer\README-INSTALL.txt`.
- [ ] When you have a code-signing certificate, wire the commented **signtool hook** in
      `Installer\BastionKryptonSuite.iss` (and sign the nupkgs if desired), then rebuild.

## 9. Outstanding owner decisions (consolidated)

Carried from BUILD-LOG and `CHANGES.md` §11. **None block a technical build; several change
what ships or what "done" means.**

**9.1 Version scheme.** Default **SemVer 1.0.0** is applied (upstream 105.x baseline noted
in release notes). Alternative: upstream-aligned `105.<yy>.<M>.<rev>` via
`pack.ps1 -Version 105.26.x`. → **Confirm 1.0.0, or choose the aligned scheme before
tagging.**

**9.2 Theme fidelity sign-off (spec acceptance item 5).**
- [ ] Per-theme sign-off from the comparison images in `docs/themes/comparisons/`:
      office2016-2019 (7), office2021-2003 (2021 ×4 + Luna ×3), m365-2026 (11).
- [ ] Live-install screenshots to close the `[D]`-tagged (derived) gaps: hover/pressed/
      disabled states, backstage, context menus, inactive title bars (all eras); 2021 Dark
      Gray/Black expanded ribbon; 2016 status-bar accent; 2026 classic-Outlook accent; XP
      Olive/Silver caption gradients.

**9.3 Licence escalations (ground rule 2; `docs/audit/THIRD-PARTY-LICENCES.md`).**
- [ ] **gGlowBox fragment** (`ImageBoxExtended.cs`): probable CPOL derivative. Recommended:
      clean-room reimplementation (~30 lines, ~1 hr). **Currently still present.**
- [ ] **Toggle.Switch module** (CPOL at module scale): recommended **exclude** from first
      release. **Already excluded** from packages + installer — confirm to keep it excluded.
- [ ] **SharpUpdate half of Software.Updater** (no upstream licence at all): recommended
      **remove**. **Already excluded** — confirm.
- [ ] **AdvancedWizard** (Steve Bate, no declared licence): low-priority courtesy licence
      request.
- [ ] Six smaller CPOL-risk fragments inventoried (report §6) — review at leisure.

**9.4 Ultimate-parity decisions (`docs/audit/ULTIMATE-PARITY.md`).**
- [ ] **RichTextBox ButtonSpecs** (stripped upstream Dec 2024, issue #240): recommended
      **port back** — the one genuine parity regression.
- [ ] **KryptonTaskDialog compat shim**: recommended **no** (survives by name via the
      elements-based rewrite).
- [ ] **Palette Designer app**: no successor in this tree — separate work item; check
      upstream's dedicated Palette-Designer repo first.

**9.5 Themes module go/no-go.** The Extended `Themes` module is **deliberately unscheduled**
(pending 9.2/9.3). Confirm it stays out of 1.0.0, or schedule it once themes are signed off.

**9.6 Open test-suite design items (`docs/audit/BREAKAGE-LOG.md`).** Four **OPEN**
design-judgement items — A9, A10 (adversarial), F2, F3 (functional) — documented for your
call; none are process-killing crashes (those were all fixed).

---

*Prepared for Bastion Software Solutions Ltd. See `docs/audit/ACCEPTANCE-CHECKLIST.md` for
the spec §10 item-by-item status.*
