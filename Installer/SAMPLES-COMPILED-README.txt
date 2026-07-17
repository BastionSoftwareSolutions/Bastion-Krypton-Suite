Bastion Krypton Suite - Ready-to-Run Demos
==========================================

This folder contains PRE-BUILT, runnable applications so you can see the
controls and themes WITHOUT opening Visual Studio.

  Demos\            Krypton Explorer (launcher for the whole sample gallery),
                    plus 250 individual sample apps. Start with
                    "Krypton Explorer.exe".
  ThemeBrowser\     Theme Browser - flip through every built-in theme live.
                    Start "KryptonThemeBrowser.exe".
  ExtendedExamples\ Extended Toolkit showcase. Start "Examples.exe".

REQUIREMENT: .NET 8 Desktop Runtime
-----------------------------------
These apps target .NET 8 (net8.0-windows). They need the free
.NET 8 DESKTOP Runtime from Microsoft. If an app does not start, install:

    https://dotnet.microsoft.com/download/dotnet/8.0
    -> ".NET Desktop Runtime 8.x" (Windows x64)

then run the app again. The runtime is NOT bundled with this installer.

Each app folder is self-contained: the required Bastion.Krypton.*.dll
assemblies and dependencies sit alongside the .exe, so the apps run in place.
