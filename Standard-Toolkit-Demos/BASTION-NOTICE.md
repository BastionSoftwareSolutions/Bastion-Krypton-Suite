# Bastion notice — Toolkit Demos / Samples

This repository is the **samples** tree of the **Bastion Krypton Suite**, a derivative
work maintained by **Bastion Software Solutions Ltd**. It is a fork of the
[Krypton Standard Toolkit Demos](https://github.com/Krypton-Suite/Standard-Toolkit-Demos).

## Licence

This tree remains under the **BSD 3-Clause Licence** (see [`LICENSE`](LICENSE)),
© 2020–2025 Krypton Suite. The upstream copyright line is retained unchanged. Bastion has
**not** altered any upstream copyright or licence header. New files introduced by this
project carry a `© Bastion Software Solutions Ltd` header alongside a note recording that
the work derives from this BSD-3-Clause tree.

Nothing in this notice grants, removes, or modifies any right under the BSD-3-Clause
licence; it is descriptive only.

## What Bastion changed here (summary)

All work is on the **`bastion/multitarget`** branch, preserving full upstream history.

- **125 C# demos** multi-targeted across the full **11-TFM matrix** and referencing the
  Bastion core/Extended libraries by `ProjectReference`.
- **125 idiomatic hand-ported VB.NET twins** — the entire VB sample set is new work
  (upstream shipped none), with real `.Designer.vb` and `Friend WithEvents`/`Handles`
  wiring so the VB designer path is exercised.
- **New Extended-module sample forms** so no shipped component is undemonstrated.
- A **launch matrix** of 250 apps × 11 TFMs, all passing on their true runtimes;
  `run-sample.ps1` builds and launches any sample on any TFM.

## Where the full record lives

The definitive change record is the **umbrella repository's `CHANGES.md`** and the sample
matrix is `docs/audit/SAMPLE-MATRIX.md` there. This repo is one of four; see the umbrella
repository's `REPO-LAYOUT.md` for the clone layout.

> Not affiliated with or endorsed by Component Factory Pty Ltd or the Krypton Suite team.
