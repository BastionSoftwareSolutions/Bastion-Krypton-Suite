; ============================================================================
;  Bastion Krypton Suite - Inno Setup installer script (Phase 7, spec 8.2)
;  Toolchain: Inno Setup 6 (ISCC.exe)
;
;  Build via the wrapper:   Installer\build-installer.ps1
;  Or directly:             ISCC.exe BastionKryptonSuite.iss
;
;  Overridable defines (pass with ISCC /D<name>=<value>):
;    MyAppVersion   default 1.0.0   - product/file version, drives OutputBaseFilename
;    StageDir       default ..\artifacts\installer-staging - payload staging tree
;    OutputDir      default ..\artifacts\installer          - where Setup.exe lands
;
;  The payload is a STAGING tree populated by build-installer.ps1 (which copies
;  only the Bastion.Krypton.* assemblies + XML + PDB per TFM, docs, samples
;  source, the Theme Browser app and the readme). Compiling this .iss without
;  first running the staging step will fail on missing Source files - always
;  build through build-installer.ps1.
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
#define MyAppURL "https://github.com/Krypton-Suite/Standard-Toolkit"

[Setup]
; --- FIXED AppId. DO NOT CHANGE. Upgrade-in-place relies on this GUID being
; --- stable across every future release. Documented in docs/audit/INSTALLER-REPORT.md
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

; --- Per-user install by default: no admin rights required. Installs under the
; --- per-user Programs folder in %LOCALAPPDATA%. Users may override the folder.
PrivilegesRequired=lowest
PrivilegesRequiredOverridesAllowed=dialog commandline
DefaultDirName={localappdata}\Programs\{#MyAppName}
DefaultGroupName={#MyAppName}
DisableProgramGroupPage=yes
AllowNoIcons=yes

; --- Licence page shows the combined BSD-3 (core) + MIT (Extended) text.
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
UninstallDisplayIcon={app}\ThemeBrowser\KryptonThemeBrowser.exe

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
Name: "full";    Description: "Full installation"
Name: "compact"; Description: "Compact installation (libraries + documentation)"
Name: "custom";  Description: "Custom installation"; Flags: iscustom

[Components]
Name: "libraries";    Description: "Class libraries - all 11 target frameworks (XML docs + PDBs)"; Types: full compact custom; Flags: fixed
Name: "docs";         Description: "Documentation (CHM help + PDF manual)"; Types: full compact custom
Name: "themebrowser"; Description: "Theme Browser application (.NET 8)"; Types: full custom
Name: "samples";      Description: "Sample source code - C# and VB.NET (optional)"; Types: full custom
; NOTE: a "pre-built sample binaries" component (unchecked by default) is defined
; by spec 8.2 as optional. Sample binaries are NOT built for this release, so the
; component is intentionally omitted. Samples ship as SOURCE (see the 'samples'
; component). Documented in docs/audit/INSTALLER-REPORT.md.

[Files]
; --- Core class libraries: {app}\lib\<tfm>\  (5 assemblies x 11 TFMs, + xml + pdb)
Source: "{#StageDir}\lib\*";          DestDir: "{app}\lib";          Flags: ignoreversion recursesubdirs createallsubdirs; Components: libraries
; --- Extended Toolkit assemblies: {app}\lib-extended\<tfm>\
Source: "{#StageDir}\lib-extended\*"; DestDir: "{app}\lib-extended"; Flags: ignoreversion recursesubdirs createallsubdirs; Components: libraries
; --- Documentation
Source: "{#StageDir}\Documentation\*"; DestDir: "{app}\Documentation"; Flags: ignoreversion; Components: docs
; --- Theme Browser app (.NET 8, self-contained folder)
Source: "{#StageDir}\ThemeBrowser\*"; DestDir: "{app}\ThemeBrowser"; Flags: ignoreversion recursesubdirs createallsubdirs; Components: themebrowser
; --- Samples (SOURCE, both languages)
Source: "{#StageDir}\Samples\*";      DestDir: "{app}\Samples";      Flags: ignoreversion recursesubdirs createallsubdirs; Components: samples
; --- Always-installed docs at the app root
Source: "DesignerIntegration.md"; DestDir: "{app}"; Flags: ignoreversion
Source: "LICENSE.txt";            DestDir: "{app}"; Flags: ignoreversion
Source: "README-INSTALL.txt";     DestDir: "{app}"; Flags: ignoreversion isreadme

[Icons]
Name: "{group}\Bastion Krypton Suite Help (CHM)"; Filename: "{app}\Documentation\BastionKryptonSuite.chm"; Components: docs
Name: "{group}\Bastion Krypton Suite Manual (PDF)"; Filename: "{app}\Documentation\BastionKryptonSuite-Manual.pdf"; Components: docs
Name: "{group}\Theme Browser"; Filename: "{app}\ThemeBrowser\KryptonThemeBrowser.exe"; WorkingDir: "{app}\ThemeBrowser"; Components: themebrowser
Name: "{group}\Designer Integration Guide"; Filename: "{app}\DesignerIntegration.md"
Name: "{group}\Uninstall {#MyAppName}"; Filename: "{uninstallexe}"

[Run]
Filename: "{app}\Documentation\BastionKryptonSuite.chm"; Description: "Open the help file"; Flags: postinstall shellexec skipifsilent unchecked; Components: docs

; No [Registry] section: the only registry footprint is Inno's standard per-user
; uninstall key (auto-managed), so uninstall leaves no orphan keys.
