# Getting Started

This guide gets a Bastion Krypton Suite application running in C# and VB.NET.

## 1. Requirements

- **Windows.** The suite is WinForms, so it runs on Windows only. Building the .NET Framework
  legs additionally requires the relevant targeting packs; the modern `netN.0-windows` legs
  need the matching .NET SDK.
- **A supported target framework.** The suite multi-targets `net46`, `net47`, `net472`,
  `net48`, `net481`, and `net5.0`–`net10.0` (`-windows`). .NET 8 (LTS) and .NET 10 (LTS) are
  the recommended mainline; older frameworks are provided for consumers pinned to legacy
  runtimes. See the [feature matrix](per-tfm-feature-matrix.md) and the support-status note
  in the change record.

## 2. Install the packages

Bastion packages use the `Bastion.Krypton.*` prefix. Add only what you need:

```
dotnet add package Bastion.Krypton.Toolkit
dotnet add package Bastion.Krypton.Ribbon        # optional
dotnet add package Bastion.Krypton.Navigator     # optional
dotnet add package Bastion.Krypton.Workspace     # optional
dotnet add package Bastion.Krypton.Docking       # optional
```

Or take the core metapackage in one step:

```
dotnet add package Bastion.Krypton.Suite
```

For the Extended Toolkit, add an individual module (for example
`Bastion.Krypton.Extended.Outlook.Grid`) or the all-in metapackage
`Bastion.Krypton.Extended.Ultimate`. See the [Extended overview](extended/index.md).

> The **namespaces are unchanged** from upstream — you still write `using Krypton.Toolkit;`.
> Only the assembly and package names carry the `Bastion.` prefix. If you are migrating from
> the upstream `Krypton.*` packages, read the [migration note](migration-from-upstream.md).

## 3. Your first form (C#)

```csharp
using System;
using System.Windows.Forms;
using Krypton.Toolkit;

namespace HelloBastion;

internal static class Program
{
    [STAThread]
    private static void Main()
    {
        Application.EnableVisualStyles();
        Application.SetCompatibleTextRenderingDefault(false);

        var form = new KryptonForm { Text = "Hello, Bastion Krypton Suite" };

        var button = new KryptonButton
        {
            Text = "Click me",
            Location = new System.Drawing.Point(20, 20)
        };
        button.Click += (_, _) => KryptonMessageBox.Show("It works.");

        form.Controls.Add(button);
        Application.Run(form);
    }
}
```

## 4. The same form (VB.NET)

VB.NET is a first-class citizen in the suite — every sample ships a VB twin, using idiomatic
`WithEvents`/`Handles` wiring.

```vbnet
Imports System.Windows.Forms
Imports Krypton.Toolkit

Module Program
    <STAThread>
    Sub Main()
        Application.EnableVisualStyles()
        Application.SetCompatibleTextRenderingDefault(False)

        Dim form As New KryptonForm With {.Text = "Hello, Bastion Krypton Suite"}
        Dim button As New KryptonButton With {
            .Text = "Click me",
            .Location = New Drawing.Point(20, 20)
        }
        AddHandler button.Click, Sub() KryptonMessageBox.Show("It works.")

        form.Controls.Add(button)
        Application.Run(form)
    End Sub
End Module
```

## 5. Choosing a theme

The suite defaults to **Microsoft 365 Blue**. Switch the whole application to any built-in
theme with a single `KryptonManager` property:

```csharp
new KryptonManager().GlobalPaletteMode = PaletteMode.Office2010Blue;
```

See the [theming guide](theming-guide.md) for the full palette list and runtime switching.

## 6. Designer support

Krypton controls fully support the Visual Studio WinForms designer on .NET Framework and on
.NET 8/10. Designer support on .NET 5/6/7 is limited by Visual Studio itself; **runtime**
support is guaranteed on every target framework, designer support is best-effort. Because
Bastion renames assemblies, you register the `Bastion.*` assemblies in the toolbox rather than
the upstream `Krypton.*` ones — the installer's *Designer integration* readme has the steps.

## Next steps

- [Component reference: Krypton Toolkit](components/toolkit.md)
- [Theming guide](theming-guide.md)
- [Extended Toolkit overview](extended/index.md)
