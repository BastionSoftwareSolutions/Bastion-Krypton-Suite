; ============================================================================
;  Bastion Krypton Suite - Inno Setup installer script (Enhanced, beginner-first)
;  Toolchain: Inno Setup 6 (ISCC.exe)
;
;  Build via the wrapper:   Installer\build-installer.ps1
;  Or directly:             ISCC.exe BastionKryptonSuite.iss  (needs a staged tree)
;
;  Overridable defines (pass with ISCC /D<name>=<value>):
;    MyAppVersion   default 1.0.0   - product/file version, drives OutputBaseFilename
;    StageDir       default ..\artifacts\installer-staging - payload staging tree
;    OutputDir      default ..\artifacts\installer          - where Setup.exe lands
;
;  The payload is a STAGING tree populated by build-installer.ps1. It copies the
;  Bastion.Krypton.* assemblies (+ XML + PDB) per TFM, the docs (CHM + PDF + HTML
;  help site), the sample SOURCE, and the PRE-BUILT runnable apps (Krypton
;  Explorer + 250 demos, the Extended Examples, and the Theme Browser).
;  Compiling this .iss without staging first will fail on missing Source files -
;  always build through build-installer.ps1.
; ============================================================================

#ifndef MyAppVersion
  #define MyAppVersion "1.0.0"
#endif
#ifndef StageDir
  #define StageDir "..\artifacts\installer-staging"
#endif
#ifndef OutputDir
  #define OutputDir "..\artifacts\installer"
#endif

#define MyAppName "Bastion Krypton Suite"
#define MyAppPublisher "Bastion Software Solutions Ltd"
#define MyAppURL "https://github.com/BastionSoftwareSolutions/Bastion-Krypton-Suite"

[Setup]
; --- FIXED AppId. DO NOT CHANGE. Upgrade-in-place relies on this GUID being
; --- stable across every future release. Documented in docs/audit/INSTALLER-REPORT.md
; --- NOTE: scope changed from per-user (Phase 7) to per-machine (Program Files);
; --- the shared AppId means a per-machine install upgrades cleanly over the old key.
AppId={{9D307380-9B7C-4DC7-A58D-75CAB5116E96}
AppName={#MyAppName}
AppVersion={#MyAppVersion}
AppVerName={#MyAppName} {#MyAppVersion}
AppPublisher={#MyAppPublisher}
AppPublisherURL={#MyAppURL}
AppSupportURL={#MyAppURL}
AppUpdatesURL={#MyAppURL}
VersionInfoVersion={#MyAppVersion}
VersionInfoProductVersion={#MyAppVersion}
VersionInfoCompany={#MyAppPublisher}
VersionInfoProductName={#MyAppName}
VersionInfoDescription={#MyAppName} Setup

; --- STANDARD (per-machine) install: Program Files, requires administrator.
PrivilegesRequired=admin
DefaultDirName={autopf}\{#MyAppName}
DefaultGroupName={#MyAppName}
DisableProgramGroupPage=yes
AllowNoIcons=yes

; --- Licence page shows the combined BSD-3 (core) + MIT (Extended) + attribution
; --- + third-party notices during the install.
LicenseFile=LICENSE.txt
InfoAfterFile=README-INSTALL.txt

; --- Output
OutputDir={#OutputDir}
OutputBaseFilename=Bastion Krypton Suite {#MyAppVersion} Setup
Compression=lzma2/max
SolidCompression=yes
WizardStyle=modern

; --- Uninstall
UninstallDisplayName={#MyAppName} {#MyAppVersion}
UninstallDisplayIcon={app}\Samples-Compiled\Demos\Krypton Explorer.exe

; ----------------------------------------------------------------------------
; CODE-SIGNING HOOK (currently UNSIGNED)
; The installer ships unsigned initially, which trips Windows SmartScreen
; ("Windows protected your PC" - click More info > Run anyway). To sign:
;   1. Register a SignTool in the IDE (Tools > Configure Sign Tools...) OR pass
;      /Ssigntool=... on the ISCC command line, defining a command named
;      "signtool" that expands $f to the file being signed, e.g.:
;        signtool=\"C:\path\to\signtool.exe\" sign /fd sha256 /tr http://timestamp.digicert.com /td sha256 /a $f
;   2. Uncomment the two directives below.
; This signs both the installer and (SignedUninstaller) the extracted uninstaller.
; ----------------------------------------------------------------------------
;SignTool=signtool $f
;SignedUninstaller=yes

[Languages]
Name: "english"; MessagesFile: "compiler:Default.isl"

[Types]
Name: "full";    Description: "Full installation (everything - recommended)"
Name: "compact"; Description: "Compact (libraries, ready-to-run demos and documentation)"
Name: "custom";  Description: "Custom installation"; Flags: iscustom

[Components]
Name: "libraries";   Description: "Class libraries - all 11 target frameworks (needed to build your own apps)"; Types: full compact custom; Flags: fixed
Name: "samples_bin"; Description: "Ready-to-run demos - Krypton Explorer, Theme Browser and Extended Examples (no Visual Studio needed; requires the free .NET 8 Desktop Runtime)"; Types: full compact
Name: "docs";        Description: "Documentation - CHM help, PDF manual and the HTML help site"; Types: full compact
Name: "samples_src"; Description: "Sample SOURCE code - C# and VB.NET projects to open and study in Visual Studio"; Types: full

[Files]
; --- Core class libraries: {app}\lib\<tfm>\  (5 assemblies x 11 TFMs, + xml + pdb)
Source: "{#StageDir}\lib\*";           DestDir: "{app}\lib";           Flags: ignoreversion recursesubdirs createallsubdirs; Components: libraries
; --- Extended Toolkit assemblies: {app}\lib-extended\<tfm>\
Source: "{#StageDir}\lib-extended\*";  DestDir: "{app}\lib-extended";  Flags: ignoreversion recursesubdirs createallsubdirs; Components: libraries

; --- Documentation: CHM + PDF + HTML help site ({app}\Documentation\html\)
Source: "{#StageDir}\Documentation\*";  DestDir: "{app}\Documentation"; Flags: ignoreversion recursesubdirs createallsubdirs; Components: docs

; --- Pre-built runnable apps (self-contained, .NET 8): {app}\Samples-Compiled\
Source: "{#StageDir}\Samples-Compiled\*"; DestDir: "{app}\Samples-Compiled"; Flags: ignoreversion recursesubdirs createallsubdirs; Components: samples_bin

; --- Sample SOURCE (C# + VB.NET): {app}\Samples\
Source: "{#StageDir}\Samples\*";        DestDir: "{app}\Samples";      Flags: ignoreversion recursesubdirs createallsubdirs; Components: samples_src

; --- Always installed at the app root
Source: "GettingStarted.html";    DestDir: "{app}"; Flags: ignoreversion
Source: "DesignerIntegration.md"; DestDir: "{app}"; Flags: ignoreversion
Source: "LICENSE.txt";            DestDir: "{app}"; Flags: ignoreversion
Source: "README-INSTALL.txt";     DestDir: "{app}"; Flags: ignoreversion isreadme

[Icons]
; --- Beginner-first: the runnable apps come first ---
Name: "{group}\Krypton Explorer (Browse Demos)"; Filename: "{app}\Samples-Compiled\Demos\Krypton Explorer.exe"; WorkingDir: "{app}\Samples-Compiled\Demos"; Components: samples_bin
Name: "{group}\Theme Browser"; Filename: "{app}\Samples-Compiled\ThemeBrowser\KryptonThemeBrowser.exe"; WorkingDir: "{app}\Samples-Compiled\ThemeBrowser"; Components: samples_bin
Name: "{group}\Extended Toolkit Examples"; Filename: "{app}\Samples-Compiled\ExtendedExamples\Examples.exe"; WorkingDir: "{app}\Samples-Compiled\ExtendedExamples"; Components: samples_bin
; --- Help / docs ---
Name: "{group}\Help (CHM)"; Filename: "{app}\Documentation\BastionKryptonSuite.chm"; Components: docs
Name: "{group}\Online-style Help (HTML)"; Filename: "{app}\Documentation\html\index.html"; Components: docs
Name: "{group}\Developer Manual (PDF)"; Filename: "{app}\Documentation\BastionKryptonSuite-Manual.pdf"; Components: docs
; --- Always present ---
Name: "{group}\Getting Started"; Filename: "{app}\GettingStarted.html"
; --- Explicit user request: a shortcut that opens the install folder in Explorer ---
Name: "{group}\Bastion Krypton Suite Folder"; Filename: "{app}"
Name: "{group}\Uninstall {#MyAppName}"; Filename: "{uninstallexe}"

[Run]
; --- Offer to launch the demo browser or open Getting Started after install ---
Filename: "{app}\Samples-Compiled\Demos\Krypton Explorer.exe"; Description: "Launch Krypton Explorer (browse the demos)"; WorkingDir: "{app}\Samples-Compiled\Demos"; Flags: postinstall nowait skipifsilent unchecked; Components: samples_bin
Filename: "{app}\GettingStarted.html"; Description: "Open the Getting Started guide"; Flags: postinstall shellexec skipifsilent unchecked

; No [Registry] section: the only registry footprint is Inno's standard
; per-machine uninstall key (auto-managed), so uninstall leaves no orphan keys.
