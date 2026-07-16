# Krypton Docking

**Assembly:** `Bastion.Krypton.Docking` · **Namespace:** `Krypton.Docking` (unchanged) ·
**Package:** `Bastion.Krypton.Docking`

Krypton Docking provides Visual-Studio-style docking: dockable and auto-hide panels around a
central document workspace, floating tool windows, and full layout persistence. It builds on
Workspace and Navigator.

The public API is identical across frameworks except for a single form-closing hook whose name
tracks the WinForms base class: `KryptonFloatingWindow.OnClosing` on net46–net9, replaced by
`OnFormClosing` on net10 (see the [feature matrix](../per-tfm-feature-matrix.md)).

## Core types

- **`KryptonDockingManager`** — the orchestrator. You add dockspaces, floating windows and
  auto-hide groups through it, and it manages drag-drop docking and layout save/load.
- **`KryptonDockableWorkspace`** — the central document region.
- **`KryptonDockableNavigator`** — a dockable multi-page region.
- **Docking elements** — dockspaces, edges, floating windows and auto-hide groups, exposed as a
  `KryptonDockingXxx` element tree.

## Minimal example

```csharp
using Krypton.Docking;
using Krypton.Workspace;
using Krypton.Toolkit;

var form = new KryptonForm { Text = "Docking" };

var workspace = new KryptonDockableWorkspace { Dock = System.Windows.Forms.DockStyle.Fill };
form.Controls.Add(workspace);

var manager = new KryptonDockingManager();
manager.ManageWorkspace(workspace);
manager.ManageControl(form);

// Dock a tool window to the left edge.
var page = new KryptonPage { Text = "Solution Explorer", UniqueName = "explorer" };
manager.AddDockspace("Left", System.Windows.Forms.DockingEdge.Left, new[] { page });

System.Windows.Forms.Application.Run(form);
```

## Persistence

```csharp
manager.SaveConfigToFile("dock-layout.xml");
manager.LoadConfigFromFile("dock-layout.xml");
```

Corrupted-XML and deeply-nested-layout handling are covered by the suite's stress tests.

## See also

- [Krypton Workspace](workspace.md) · [Krypton Navigator](navigator.md)
- API reference: the `Krypton.Docking` namespace.
