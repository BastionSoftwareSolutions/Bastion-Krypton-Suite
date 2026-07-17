# Third-party notice — vendored ScottPlot 5 source

Everything under this `Scott Plot` directory is vendored **ScottPlot 5** source code.

- **Origin:** ScottPlot — <https://scottplot.net> / <https://github.com/ScottPlot/ScottPlot>
- **Version:** the ScottPlot 5.0 (beta-era) line. The code was imported into the
  Extended Toolkit on 14 November 2023 (upstream Extended-Toolkit commit `6f69897d`,
  "Version 80"); the exact upstream ScottPlot commit was not recorded at import time.
- **Licence:** MIT — Copyright (c) 2018 Scott Harden / Harden Technologies, LLC.
  See the `LICENSE` file in this directory for the full text.
- **Modifications:** the namespaces were rewritten to
  `Krypton.Toolkit.Suite.Extended.Data.Visualisation.ScottPlot` and the code has been
  adapted to build within the Krypton Toolkit Suite Extended / Bastion Krypton Suite
  source tree. All other rights and notices of the upstream authors remain in force.

## History of this notice

The original import replaced the ScottPlot copyright notice with the Krypton Suite's
own MIT text (see `..\License\License.txt`, which covers the Krypton Suite additions).
The MIT licence requires the *upstream* copyright notice to accompany all copies or
substantial portions of the software, so this notice and the accompanying `LICENSE`
file were restored on 15 July 2026 as part of the Bastion Krypton Suite third-party
licence audit (see `docs/audit/THIRD-PARTY-LICENCES.md` in the Bastion workspace).

## Embedded notices retained in individual files

- `Core\Palettes\Category10.cs` and `Core\Palettes\Category20.cs` embed colour
  palettes from Vega — BSD-3-Clause, Copyright (c) 2015-2018, University of
  Washington Interactive Data Lab (notice retained in-file).
- `Core\Palettes\Microcharts.cs` embeds a palette from Microcharts — MIT,
  Copyright (c) 2017 Aloïs Deniel (notice retained in-file).
