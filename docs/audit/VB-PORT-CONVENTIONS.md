# VB.NET twin-port conventions (Phase 4c)

Authoritative conventions for every VB batch agent. Deviations require a written note in the batch report.

1. **Layout:** each C# demo `Source\<Family>\<Name>\` gets a VB twin at `Source\VisualBasic\<Family>\<Name> VB\`. Project file `<Name> VB.vbproj`.
2. **Project shape:** SDK-style, inherits the repo `Directory.Build.props` (11-TFM matrix, SampleTfm switch, resource rules). `<AssemblyName>` = C# assembly name + `VB`. `<RootNamespace>` = the C# project's namespace (files then omit `Namespace` blocks). `OptionStrict On`, `OptionExplicit On`, `OptionInfer On`. ProjectReferences identical to the C# twin's (same relative depth +1 — verify each).
3. **Hand-ported, idiomatic VB** (spec §5.3): `WithEvents` fields + `Handles` clauses for designer-wired events (not AddHandler, except dynamic wiring the C# did at runtime); `My.` namespace where natural (e.g. `My.Resources`); no mechanical converter artefacts (`Me.` spam beyond designer files, redundant casts, C#-shaped ternaries where If() reads worse).
4. **Designer files are real** (spec §5.4): `<Form>.Designer.vb` with `Partial Class`, full `InitializeComponent`, `Private WithEvents` control declarations, SuspendLayout/ResumeLayout — mirroring the C# designer structure. Copy + re-point `.resx` files (update any `$this` type references if needed).
5. **Entry point:** explicit `Module Program` + `<STAThread>` `Sub Main()` mirroring the C# `Program.cs` (including any `#If NET6_0_OR_GREATER` bootstrap guards, translated to VB `#If`).
6. **Headers:** same BSD-3 Bastion header as the C# file it twins, adapted to VB comment syntax, plus one line: `' VB.NET twin of <relative C# path> (Bastion Phase 4c).`
7. **Parity:** functional parity with the C# twin — same forms, same controls, same behaviours. UI text identical. If a C# demo uses a C#-only construct (unsafe, pointer), note it and implement the nearest VB equivalent; record in the batch report.
8. **Verification per project:** build `net48`, `net8.0-windows` and `net46` legs green (`/p:SampleTfm=`); the consolidated full-matrix pass happens after solution registration. Do not edit any `.sln` — registration is centralised.
9. **Batch report:** append to the batch's final message: projects ported, forms count, deviations, warnings introduced (target: none beyond the C# twin's own).
