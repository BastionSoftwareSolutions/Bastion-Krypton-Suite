# Third-party notice — vendored System.Speech reference source

The 338 C# files in this `SAPI` directory tree (Audio Format, Grammar Building,
Internal, IO, Object Tokens, Recognition, SAPI Interop, Speech, SrgsCompiler,
SrgsGrammar, SrgsParser, Synthesis, TTSEngine) are a vendored, adapted copy of the
managed **System.Speech** / Speech API (SAPI) implementation from the .NET
reference source.

- **Origin:** the .NET **System.Speech** reference source —
  <https://github.com/dotnet/runtime> (`System.Speech`) and the .NET Framework
  reference source (<https://github.com/microsoft/referencesource>).
- **Licence:** MIT — Copyright (c) .NET Foundation and Contributors.
- **Modifications:** namespaces rewritten to
  `Krypton.Toolkit.Suite.Extended.Utilities.System.*` and the code adapted to
  build within the Krypton Toolkit Suite Extended / Bastion Krypton Suite tree.

The original import re-stamped these files with the Krypton Suite's own MIT
header and did not retain the .NET Foundation notice. The MIT licence requires
the upstream copyright notice to accompany all copies or substantial portions of
the software, so this notice was restored on 15 July 2026 by the Bastion Krypton
Suite third-party licence audit (see `docs/audit/THIRD-PARTY-LICENCES.md` in the
Bastion workspace). The per-file Krypton Suite headers cover the Krypton Suite's
adaptations only.

## Upstream licence text

MIT License

Copyright (c) .NET Foundation and Contributors

All rights reserved.

Permission is hereby granted, free of charge, to any person obtaining a copy
of this software and associated documentation files (the "Software"), to deal
in the Software without restriction, including without limitation the rights
to use, copy, modify, merge, publish, distribute, sublicense, and/or sell
copies of the Software, and to permit persons to whom the Software is
furnished to do so, subject to the following conditions:

The above copyright notice and this permission notice shall be included in all
copies or substantial portions of the Software.

THE SOFTWARE IS PROVIDED "AS IS", WITHOUT WARRANTY OF ANY KIND, EXPRESS OR
IMPLIED, INCLUDING BUT NOT LIMITED TO THE WARRANTIES OF MERCHANTABILITY,
FITNESS FOR A PARTICULAR PURPOSE AND NONINFRINGEMENT. IN NO EVENT SHALL THE
AUTHORS OR COPYRIGHT HOLDERS BE LIABLE FOR ANY CLAIM, DAMAGES OR OTHER
LIABILITY, WHETHER IN AN ACTION OF CONTRACT, TORT OR OTHERWISE, ARISING FROM,
OUT OF OR IN CONNECTION WITH THE SOFTWARE OR THE USE OR OTHER DEALINGS IN THE
SOFTWARE.
