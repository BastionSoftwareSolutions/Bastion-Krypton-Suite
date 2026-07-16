# Bastion notice — Standard Toolkit (core)

This repository is the **core** tree of the **Bastion Krypton Suite**, a derivative
work maintained by **Bastion Software Solutions Ltd**. It is a fork of the
[Krypton Standard Toolkit](https://github.com/Krypton-Suite/Standard-Toolkit),
which is itself descended from the original
[Component Factory Krypton](https://github.com/ComponentFactory/Krypton) suite.

## Licence

This tree remains under the **BSD 3-Clause Licence** (see [`LICENSE`](LICENSE)).
The upstream copyright lines — **Component Factory Pty Ltd** and **Krypton Suite** —
are retained unchanged. Bastion has **not** altered any upstream copyright or licence
header. New files introduced by this project carry a
`© Bastion Software Solutions Ltd` header alongside a note recording that the work
derives from this BSD-3-Clause tree.

Nothing in this notice grants, removes, or modifies any right under the BSD-3-Clause
licence; it is descriptive only.

## What Bastion changed here (summary)

All work is on the **`bastion/multitarget`** branch, preserving full upstream history
(no upstream history is rewritten).

- **Multi-targeting** expanded from the upstream 6 TFMs to **11**:
  `net46; net47; net472; net48; net481; net5.0-windows; net6.0-windows;
  net7.0-windows; net8.0-windows; net9.0-windows; net10.0-windows`.
- **14 new Office/Microsoft 365 palettes** (Office 2003 / 2016 / 2019 / 2021 eras and
  an M365 2026 refresh), wired end to end.
- **~40 genuine upstream defect classes** found and fixed during multi-targeting and
  adversarial testing (dispose-time NREs, theme-wiring bugs, a core `PaletteFormBorder`
  null-owner NRE, and more) — all tagged as upstream-contribution candidates.
- **Assembly names and NuGet package IDs** gain a `Bastion.` prefix
  (`Bastion.Krypton.Toolkit`, …). **Namespaces and public type names are unchanged**
  (`Krypton.Toolkit.*`) so the build is drop-in compatible.

## Where the full record lives

The definitive, itemised change record — every TFM gap and its fix, every theme, every
defect, the per-TFM feature matrix, and the dual-licence attribution — is in the
**umbrella repository's `CHANGES.md`**. This repo is one of four; see the umbrella
repository's `REPO-LAYOUT.md` for how the pieces fit together and how to clone them.

> Not affiliated with or endorsed by Component Factory Pty Ltd or the Krypton Suite team.
