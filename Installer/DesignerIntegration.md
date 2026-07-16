# Bastion Krypton Suite - Designer Integration Guide

This guide explains how to add the Bastion Krypton Suite controls to the Visual
Studio Toolbox and use them at design time, for both **.NET Framework** and
**.NET (Core)** WinForms projects.

> **Recommended consumption path: NuGet.** The `Bastion.Krypton.*` packages are
> the supported way to consume the suite in real projects - they wire up the
> correct per-target-framework assemblies and design-time support automatically.
> This installer exists for **offline / designer / evaluation use**: it drops the
> compiled assemblies, XML docs and PDBs on disk so you can reference them
> directly without a package feed.

## Assemblies and where they live

The installer places the class libraries under:

```
<InstallDir>\lib\<target-framework>\
```

The default `<InstallDir>` is `%LOCALAPPDATA%\Programs\Bastion Krypton Suite`
(per-user install). The target-framework folders present are:

```
net46  net47  net472  net48  net481
net5.0-windows  net6.0-windows  net7.0-windows
net8.0-windows  net9.0-windows  net10.0-windows
```

The five core control assemblies (each with matching `.xml` IntelliSense docs
and `.pdb` symbols alongside) are:

| Assembly file                     | Provides (Toolbox controls)                          |
|-----------------------------------|------------------------------------------------------|
| `Bastion.Krypton.Toolkit.dll`     | Core controls: KryptonButton, KryptonPanel, KryptonLabel, KryptonTextBox, KryptonComboBox, KryptonDataGridView, palette + theme components, etc. |
| `Bastion.Krypton.Navigator.dll`   | KryptonNavigator                                     |
| `Bastion.Krypton.Ribbon.dll`      | KryptonRibbon and ribbon components                  |
| `Bastion.Krypton.Workspace.dll`   | KryptonWorkspace                                      |
| `Bastion.Krypton.Docking.dll`     | KryptonDockingManager and docking components         |

The Extended Toolkit assemblies (`Bastion.Krypton.Extended.*.dll`) are placed
under `<InstallDir>\lib-extended\<target-framework>\`. They are shipped for
offline reference; NuGet is the recommended path for these.

## Drop-in compatibility

Assembly **file names** are prefixed `Bastion.` to avoid GAC and assembly-binding
collisions with the upstream `Krypton.*` assemblies. The **public namespaces and
type names are unchanged** (for example, the controls are still in the
`Krypton.Toolkit`, `Krypton.Navigator`, `Krypton.Ribbon`, `Krypton.Workspace`
and `Krypton.Docking` namespaces). Existing Krypton code therefore recompiles
unchanged once the assembly references are swapped - your `using Krypton.Toolkit;`
statements and control types stay exactly the same.

## Choosing the right target-framework folder

Pick the folder that matches your project's target framework:

- **.NET Framework 4.6 / 4.7 / 4.7.2 / 4.8 / 4.8.1** -> `net46` ... `net481`
- **.NET 5 / 6 / 7 / 8 / 9 / 10 (Windows)** -> `net5.0-windows` ... `net10.0-windows`

Referencing a folder that does not match your project's framework will produce
load or build errors. When in doubt, match the highest folder at or below your
project's target (e.g. a .NET 8 project uses `net8.0-windows`).

---

## A. .NET Framework projects (full Toolbox + designer support)

.NET Framework WinForms has full in-process designer support, so the controls
appear on the design surface and in the Toolbox.

1. Open your WinForms project in Visual Studio 2022.
2. Open the **Toolbox** (`View > Toolbox`).
3. Right-click anywhere in the Toolbox and choose **Add Tab** (optional) - name
   it e.g. `Bastion Krypton`.
4. Right-click inside the tab and choose **Choose Items...**.
5. On the **.NET Framework Components** tab, click **Browse...**.
6. Navigate to `<InstallDir>\lib\net48\` (or the folder matching your project's
   framework) and select:
   - `Bastion.Krypton.Toolkit.dll`
   - `Bastion.Krypton.Navigator.dll`
   - `Bastion.Krypton.Ribbon.dll`
   - `Bastion.Krypton.Workspace.dll`
   - `Bastion.Krypton.Docking.dll`
   Add them one at a time or repeat **Browse...** for each.
7. Click **OK**. The Krypton controls now appear in the Toolbox tab and can be
   dragged onto forms; the Properties window shows their design-time properties.
8. Add a project reference to the same DLLs (`Project > Add Reference > Browse`)
   so the code compiles.

The `.xml` files next to each DLL supply IntelliSense/tooltips automatically once
the DLL is referenced.

---

## B. .NET (Core) projects - .NET 5 / 6 / 7 / 8 / 9 / 10

Use the assemblies from the matching `net<x>.0-windows` folder.

1. Add references to the DLLs from `<InstallDir>\lib\net8.0-windows\` (or your
   framework's folder):
   - Either `Project > Add Project Reference > Browse...` and select the five
     `Bastion.Krypton.*.dll` files, **or** add `<Reference>` items to the
     `.csproj`:
     ```xml
     <ItemGroup>
       <Reference Include="Bastion.Krypton.Toolkit">
         <HintPath>$(LOCALAPPDATA)\Programs\Bastion Krypton Suite\lib\net8.0-windows\Bastion.Krypton.Toolkit.dll</HintPath>
       </Reference>
       <!-- repeat for Navigator, Ribbon, Workspace, Docking as needed -->
     </ItemGroup>
     ```
   The code compiles and the controls run correctly at runtime.

2. **Toolbox:** `Choose Items... > Browse...` and select the DLLs from the
   `net8.0-windows` folder, exactly as in section A step 6. The controls appear
   in the Toolbox.

3. **Design-time surface caveat (important, verified against the project spec):**
   Visual Studio's WinForms designer for **.NET 5 / 6 / 7** projects is
   effectively unavailable, and for **.NET 8+** it runs out-of-process and is
   still less capable than the .NET Framework designer. **Runtime support is the
   commitment of this suite; full visual designer support is only guaranteed on
   .NET Framework targets.** For .NET (Core) projects you can:
   - Reference and use the controls in code (fully supported at runtime), and/or
   - Design your forms in a **.NET Framework** project and reuse the generated
     designer code in the .NET project (the namespaces are identical), or
   - Use the NuGet packages, which carry the design-time assemblies where
     available.

   This limitation is a Visual Studio / .NET WinForms platform constraint, not a
   Bastion-specific one.

---

## Troubleshooting

- **"Choose Items" shows nothing after Browse:** ensure you picked a DLL from the
  folder matching your VS designer host (the .NET Framework tab needs a
  `net4x` DLL; the .NET Core designer needs a `net<x>.0-windows` DLL).
- **Controls compile but do not appear on the design surface (.NET Core):** this
  is the designer limitation described in section B step 3 - the controls still
  work at runtime.
- **Assembly load conflict with an existing `Krypton.*` install:** the Bastion
  assemblies are deliberately renamed (`Bastion.` prefix) so both can coexist;
  make sure your references point at the `Bastion.Krypton.*` files, not the
  upstream `Krypton.*` ones.

## Uninstalling

Use **Add/Remove Programs** ("Bastion Krypton Suite") or the Start Menu
**Uninstall** shortcut. The uninstaller removes all installed files under the
install directory and the Start Menu group, leaving no orphan files or registry
entries beyond the standard per-user uninstall key.
