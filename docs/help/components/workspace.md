# Krypton Workspace

**Assembly:** `Bastion.Krypton.Workspace` · **Namespace:** `Krypton.Workspace` (unchanged) ·
**Package:** `Bastion.Krypton.Workspace`

Krypton Workspace arranges pages into a tree of resizable, user-rearrangeable cells — the kind
of split, tabbed document area found in IDEs. It builds on Navigator's page model. Its public
API is **identical across all eleven target frameworks**.

## Core types

- **`KryptonWorkspace`** — the root control; hosts a hierarchy of sequences and cells.
- **`KryptonWorkspaceSequence`** — a horizontal or vertical arrangement of children, each with a
  star-sizing weight.
- **`KryptonWorkspaceCell`** — a leaf that shows one or more `KryptonPage` objects as tabs
  (a `KryptonNavigator` under the hood).

Users can drag page tabs between cells, split cells, and resize sequences; the layout can be
saved and restored as XML.

## Minimal example

```csharp
using Krypton.Workspace;
using Krypton.Navigator;
using Krypton.Toolkit;

var form = new KryptonForm { Text = "Workspace" };
var workspace = new KryptonWorkspace { Dock = System.Windows.Forms.DockStyle.Fill };

var cell = new KryptonWorkspaceCell();
cell.Pages.Add(new KryptonPage { Text = "Document 1" });
cell.Pages.Add(new KryptonPage { Text = "Document 2" });
workspace.Root.Children.Add(cell);

form.Controls.Add(workspace);
System.Windows.Forms.Application.Run(form);
```

## Persistence

```csharp
workspace.SaveLayoutToXml("layout.xml");
workspace.LoadLayoutFromXml("layout.xml");
```

Layout round-trips (including deliberately corrupted XML) are part of the suite's adversarial
test set, so load failures degrade gracefully rather than crashing.

## See also

- [Krypton Docking](docking.md) layers dockable panels on top of a workspace.
- API reference: the `Krypton.Workspace` namespace.
