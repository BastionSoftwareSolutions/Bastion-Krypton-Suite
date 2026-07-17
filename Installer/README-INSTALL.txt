Bastion Krypton Suite 1.0.0
===========================

Thank you for installing the Bastion Krypton Suite.

NEW TO THIS? Start with the Start Menu shortcut "Getting Started", or just run
"Krypton Explorer (Browse Demos)" and "Theme Browser" to see the controls live.

WHAT WAS INSTALLED (into Program Files by default)
--------------------------------------------------
  lib\<tfm>\            Core class libraries (5 assemblies) for all 11 target
                       frameworks, with XML docs and PDB symbols alongside.
  lib-extended\<tfm>\  Extended Toolkit assemblies (Bastion.Krypton.Extended.*),
                       for offline reference.
  Documentation\       CHM help file, PDF manual, and the HTML help site (html\).
  Samples-Compiled\    READY-TO-RUN apps (.NET 8, if selected): Krypton Explorer +
                       250 demos, Extended Examples, and the Theme Browser.
  Samples\             C# and VB.NET sample SOURCE (if selected).
  GettingStarted.html  Friendly first-run guide for beginners.
  DesignerIntegration.md   How to add the controls to the Visual Studio Toolbox.
  LICENSE.txt          Combined BSD-3 (core) + MIT (Extended) licence + notices.

.NET 8 DESKTOP RUNTIME (for the ready-to-run demos)
---------------------------------------------------
The apps in Samples-Compiled need the free .NET 8 Desktop Runtime. If a demo
does not start, install it from https://dotnet.microsoft.com/download/dotnet/8.0
(".NET Desktop Runtime 8.x", Windows x64), then try again. It is not bundled.

RECOMMENDED CONSUMPTION PATH: NuGet
-----------------------------------
For real projects, reference the Bastion.Krypton.* NuGet packages. This
installer is intended for OFFLINE / DESIGNER / EVALUATION use - it drops the
compiled assemblies on disk so you can reference them without a package feed.

GETTING STARTED
---------------
See DesignerIntegration.md for step-by-step Toolbox instructions for both
.NET Framework and .NET (Core) projects. Namespaces are unchanged from the
upstream Krypton Suite, so existing code recompiles by swapping the references.

UNSIGNED INSTALLER / SMARTSCREEN
--------------------------------
This installer is currently UNSIGNED. Windows SmartScreen may show a
"Windows protected your PC" warning when you run it. To proceed, click
"More info" then "Run anyway". This is expected for an unsigned installer and
will disappear once the installer is code-signed. See INSTALLER-REPORT.md for
how signing is enabled (a SignTool hook is already present in the build script).

SILENT INSTALL
--------------
  "Bastion Krypton Suite 1.0.0 Setup.exe" /VERYSILENT /NORESTART
Optionally add /DIR="C:\path\to\install" and /LOG="C:\path\to\log.txt".

UNINSTALL
---------
Use Add/Remove Programs, or the Start Menu "Uninstall Bastion Krypton Suite"
shortcut. All installed files are removed cleanly.
