<!-- © Bastion Software Solutions Ltd 2026. Operational guide — how to claim the NuGet IDs
     and reserve the Bastion.Krypton. prefix for the Bastion Krypton Suite. -->
# Publishing to nuget.org — claiming the package IDs

**Short version:** you do **not** pre-register 57 names by hand. On nuget.org an ID is
**claimed the moment you first push a package with that ID** — first push wins, and it's then
yours. Your job is therefore: (1) create the account/key, (2) push the packages (which claims
all 57 IDs at once), and (3) **reserve the `Bastion.Krypton.` prefix** so the whole namespace is
locked to you and shows the verified-owner tick.

All 57 `Bastion.Krypton.*` IDs were confirmed **unclaimed** on nuget.org at build time, so they
are available for you to take.

---

## Step 1 — nuget.org account (and, recommended, an organisation)

1. Sign in at <https://www.nuget.org> with the Microsoft/GitHub account you want to own the
   packages (the `BastionSoftwareSolutions` GitHub account is fine).
2. **Recommended:** create an **Organisation** so the packages are owned by the company, not a
   personal account — <https://www.nuget.org/organization>. Name it e.g. `BastionSoftwareSolutions`.
   You can transfer packages to it later, but starting there is tidier.

## Step 2 — create a scoped API key

1. Go to <https://www.nuget.org/account/apikeys> → **Create**.
2. **Key name:** `Bastion-Krypton-push`.
3. **Package owner:** your organisation (from Step 1) if you made one.
4. **Scopes:** tick **Push** (Push new packages *and* package versions).
5. **Glob pattern:** `Bastion.Krypton.*` — this restricts the key to only your namespace, so a
   leaked key can't touch anything else.
6. **Expiry:** the shortest that's practical (e.g. 90 days) — you can re-issue.
7. Copy the key now (it's shown once). Keep it secret — it is **not** stored in this repo.

## Step 3 — push the packages (this claims all 57 IDs)

The 57 packages + symbol packages are already built at `artifacts\nuget\` (version **1.0.0**,
licences already set: BSD-3-Clause on core, MIT on Extended, `MIT AND MS-PL` on the Ms-PL
modules and the Ultimate metapackage). To rebuild them from scratch: `pwsh .\pack.ps1 -Scope All`.

From the repo root in PowerShell:

```powershell
$key = "<PASTE-YOUR-API-KEY>"
$src = "https://api.nuget.org/v3/index.json"

# Push every package. --skip-duplicate makes re-runs safe if one fails midway.
Get-ChildItem "artifacts\nuget\*.nupkg" | ForEach-Object {
    dotnet nuget push $_.FullName --api-key $key --source $src --skip-duplicate
}
```

Notes:
- Pushing the `.nupkg` also pushes the matching `.snupkg` symbol package automatically (they sit
  beside each other in `artifacts\nuget\`).
- **Order doesn't matter.** nuget.org accepts a package even if its dependencies aren't indexed
  yet; it resolves them as they appear. (If you prefer tidy ordering: push `Bastion.Krypton.Toolkit`
  and `Bastion.Krypton.Extended.Shared`/`.Core` first, then the rest, then the two metapackages
  `Bastion.Krypton.Suite` and `Bastion.Krypton.Extended.Ultimate` last.)
- Each ID takes a few minutes to finish indexing and become installable.
- After the first package indexes, browse to `https://www.nuget.org/packages/Bastion.Krypton.Toolkit`
  to confirm it's live and the metadata/licence look right.

## Step 4 — reserve the `Bastion.Krypton.` prefix

Once at least one package is published under your account, request an **ID prefix reservation**
so nobody else can publish `Bastion.Krypton.*` and your packages get the blue verified tick.

1. Read the policy: <https://learn.microsoft.com/nuget/nuget-org/id-prefix-reservation>.
2. Apply by emailing the address on that page (currently **account@nuget.org**) from your account,
   requesting reservation of the prefix **`Bastion.Krypton.`** for your owner/organisation, and
   listing the published packages as evidence.
3. Criteria you already meet: the prefix is specific to you, the packages share consistent
   metadata (author = Bastion Software Solutions Ltd, repository URL, licence), and they're not
   impersonating another owner.

**One heads-up:** the reviewer may ask about the word **"Krypton"**, since it's the upstream
project's name. You have a clean answer — Bastion Krypton Suite is an openly-stated derivative of
the BSD-3/MIT-licensed Krypton Toolkit, the README and `CHANGES.md` credit Component Factory and
the Krypton Suite team, and no endorsement is implied. Have that ready in case they ask.

---

## The 57 package IDs (for reference)

**Core + metapackages (6):**

```
Bastion.Krypton.Toolkit
Bastion.Krypton.Ribbon
Bastion.Krypton.Navigator
Bastion.Krypton.Workspace
Bastion.Krypton.Docking
Bastion.Krypton.Suite                       (metapackage → the five core libraries)
```

**Extended modules + metapackage (51):**

```
Bastion.Krypton.Extended.AdvancedDataGridView    Bastion.Krypton.Extended.Memory.Box
Bastion.Krypton.Extended.Buttons                 Bastion.Krypton.Extended.Messagebox
Bastion.Krypton.Extended.Calendar                Bastion.Krypton.Extended.Navi.Suite
Bastion.Krypton.Extended.CheckSum.Tools          Bastion.Krypton.Extended.Navigator
Bastion.Krypton.Extended.Circular.ProgressBar    Bastion.Krypton.Extended.Networking
Bastion.Krypton.Extended.ComboBox                Bastion.Krypton.Extended.Notifications
Bastion.Krypton.Extended.Common                  Bastion.Krypton.Extended.Outlook.Grid
Bastion.Krypton.Extended.Compression             Bastion.Krypton.Extended.Panels
Bastion.Krypton.Extended.Controls                Bastion.Krypton.Extended.Resources
Bastion.Krypton.Extended.Core                    Bastion.Krypton.Extended.Ribbon
Bastion.Krypton.Extended.Data.Visualisation      Bastion.Krypton.Extended.Settings
Bastion.Krypton.Extended.DataGridView            Bastion.Krypton.Extended.Shared
Bastion.Krypton.Extended.Debug.Tools             Bastion.Krypton.Extended.Software.Updater.Core
Bastion.Krypton.Extended.Developer.Utilities     Bastion.Krypton.Extended.Specialised.Dialogs
Bastion.Krypton.Extended.Dialogs                 Bastion.Krypton.Extended.Theme.Switcher
Bastion.Krypton.Extended.Dock.Extender           Bastion.Krypton.Extended.ToastNotification
Bastion.Krypton.Extended.Drawing                 Bastion.Krypton.Extended.Tool.Box
Bastion.Krypton.Extended.Drawing.Utilities       Bastion.Krypton.Extended.Tool.Strip.Items
Bastion.Krypton.Extended.Effects                 Bastion.Krypton.Extended.Tools
Bastion.Krypton.Extended.Error.Reporting         Bastion.Krypton.Extended.TreeGridView
Bastion.Krypton.Extended.File.Copier             Bastion.Krypton.Extended.Utilities
Bastion.Krypton.Extended.Floating.Toolbars       Bastion.Krypton.Extended.VirtualTreeColumnView
Bastion.Krypton.Extended.Forms                   Bastion.Krypton.Extended.Wizard
Bastion.Krypton.Extended.Global.Utilities        Bastion.Krypton.Extended.Ultimate  (metapackage → all Extended)
Bastion.Krypton.Extended.InputBox
Bastion.Krypton.Extended.IO
Bastion.Krypton.Extended.Language.Model
```

**Not published** (removed from the suite for licence reasons — see `docs/audit/THIRD-PARTY-LICENCES.md`):
`Toggle.Switch` (CPOL) and the `SharpUpdate` half of `Software.Updater` (no upstream licence).
