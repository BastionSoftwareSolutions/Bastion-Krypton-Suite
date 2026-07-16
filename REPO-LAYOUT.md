# Repository layout — Bastion Krypton Suite

The Bastion Krypton Suite is **not one repository**. It is **four** git repositories: an
umbrella (orchestration) repo plus three source trees, each a fork that **preserves full
upstream history**. This document explains why, what lives where, and exactly how to lay
the clones out on disk so the build works.

> **Why four repos and not a monorepo?** Ground rule 4 of the build spec requires upstream
> git history to be preserved and never rewritten. Flattening the three upstream forks into
> one tree would destroy that history. The correct publishing model is therefore
> **fork-per-repo (history intact) + an umbrella repo that references them** — reconciling
> spec §9's single-repo "Source/Samples/Tests/… in one repo" ideal with the multi-repo
> reality. See "Recommended GitHub model" below.

## The four repositories

| # | Repository (local dir) | Branch | Licence | Upstream origin | Contents |
|---|---|---|---|---|---|
| 1 | **umbrella** — `Krypton-Ultimate` | `main` | BSD-3 (own content) | — (new) | Orchestration: `BUILD-LOG.md`, `CHANGES.md`, `README.md`, `LICENSE`, `CONTRIBUTING.md`, `REPO-LAYOUT.md`, `.gitignore`, `.editorconfig`, `docs/` (audit + help + themes), `Scripts/`, `Tests/`, `Installer/`, `pack.ps1`, `build-docs.ps1`, `build-all.ps1`, `docfx.json`, `.github/workflows/build.yml` |
| 2 | **Standard-Toolkit** | `bastion/multitarget` | BSD-3 | [Krypton-Suite/Standard-Toolkit](https://github.com/Krypton-Suite/Standard-Toolkit) | The five core libraries (Toolkit, Ribbon, Navigator, Workspace, Docking) + `Packaging/Bastion.Krypton.Suite` metapackage + `.github/workflows/bastion-build.yml` |
| 3 | **Extended-Toolkit** | `bastion/multitarget` | MIT | [Krypton-Suite/Extended-Toolkit](https://github.com/Krypton-Suite/Extended-Toolkit) | ~60 Extended module libraries + the Ultimate metapackage + `.github/workflows/bastion-build.yml` |
| 4 | **Standard-Toolkit-Demos** | `bastion/multitarget` | BSD-3 | [Krypton-Suite/Standard-Toolkit-Demos](https://github.com/Krypton-Suite/Standard-Toolkit-Demos) | 125 C# + 125 VB samples, `run-sample.ps1` |

(A fifth clone, `ComponentFactory-Krypton`, is the frozen 2017 original used only for the
parity audit. It is **not** published and **not** required to build; it is git-ignored here.)

## On-disk layout (this is load-bearing)

The three source trees are cloned **into the umbrella repo's root as siblings** and are
**git-ignored** there (see `.gitignore`). Cross-tree references are **relative** and assume
exactly this layout:

- The umbrella's scripts resolve `"$RepoRoot\Standard-Toolkit\..."`,
  `"$RepoRoot\Extended-Toolkit\..."` (see `pack.ps1`, `build-docs.ps1`, `build-all.ps1`).
- The umbrella's tests reference core assemblies via
  `Tests\..\Standard-Toolkit\Bin\Release\<tfm>\Bastion.Krypton.*.dll` (HintPath).
- Extended modules reference core via `..\..\..\..\Standard-Toolkit\Source\Krypton Components\...`
  (`ProjectReference`) — i.e. the dir that contains `Extended-Toolkit` must also contain
  `Standard-Toolkit`.

```
Krypton-Ultimate/                 <- umbrella repo (git: main)
├─ BUILD-LOG.md, CHANGES.md, README.md, LICENSE, CONTRIBUTING.md, REPO-LAYOUT.md
├─ pack.ps1, build-docs.ps1, build-all.ps1, docfx.json, .editorconfig, .gitignore
├─ Scripts/  Tests/  Installer/  docs/  Help/  .github/workflows/build.yml
│
├─ Standard-Toolkit/             <- repo #2 (git: bastion/multitarget)  [git-ignored here]
├─ Extended-Toolkit/             <- repo #3 (git: bastion/multitarget)  [git-ignored here]
├─ Standard-Toolkit-Demos/       <- repo #4 (git: bastion/multitarget)  [git-ignored here]
└─ ComponentFactory-Krypton/     <- audit-only frozen original           [git-ignored here]
```

Do **not** rename the source directories; the relative references above break if you do.

## Fresh-clone recipe

Replace the placeholder URLs with Chris's confirmed repo URLs (see below), then:

```powershell
# 1. the umbrella
git clone <umbrella-url> Krypton-Ultimate
cd Krypton-Ultimate

# 2. the three source trees, as siblings inside the umbrella root, on bastion/multitarget
git clone -b bastion/multitarget <core-url>      Standard-Toolkit
git clone -b bastion/multitarget <extended-url>  Extended-Toolkit
git clone -b bastion/multitarget <demos-url>     Standard-Toolkit-Demos

# 3. build everything
./build-all.ps1                 # or: ./build-all.ps1 -SkipDocs -SkipInstaller
```

## Recommended GitHub model (for Chris to confirm)

Publish **four repositories under one GitHub org**, each source repo pushed as a fork so its
upstream history and the fork relationship are visible. Suggested org **`Bastion-Software`**
and repo names (all **recommendations** — confirm or change before pushing):

| Local | Suggested GitHub repo | Push as |
|---|---|---|
| `Krypton-Ultimate` (umbrella) | `Bastion-Software/bastion-krypton-suite` | new repo |
| `Standard-Toolkit` | `Bastion-Software/bastion-krypton-standard-toolkit` | fork of Krypton-Suite/Standard-Toolkit |
| `Extended-Toolkit` | `Bastion-Software/bastion-krypton-extended-toolkit` | fork of Krypton-Suite/Extended-Toolkit |
| `Standard-Toolkit-Demos` | `Bastion-Software/bastion-krypton-toolkit-demos` | fork of Krypton-Suite/Standard-Toolkit-Demos |

The CI workflows read the sibling repo coordinates from repo **variables** (`CORE_REPO`,
`EXT_REPO`, `CORE_REF`, `EXT_REF`); set these to the confirmed names, or edit the
placeholder defaults in the workflow files. Whatever names are chosen, keep the umbrella's
`README.md` and this file in step with them.

> Alternative considered and rejected: a single flattened monorepo. It would satisfy spec
> §9's wording but violate ground rule 4 (upstream history) and lose the fork relationship
> that makes upstream-contribution and future rebases tractable. The four-repo model is the
> recommendation.
