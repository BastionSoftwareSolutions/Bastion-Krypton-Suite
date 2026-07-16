<#
.SYNOPSIS
    Bastion Krypton Suite - Phase 7 NuGet packaging (spec Sec 8.1).

.DESCRIPTION
    Builds Release and `dotnet pack`s (via desktop MSBuild -t:Pack, which is
    required because net46 relies on the Microsoft.NETFramework.ReferenceAssemblies
    NuGet packages and builds under desktop MSBuild only) every Bastion package to
    the artifacts feed:

      Core (BSD-3-Clause):
        Bastion.Krypton.Toolkit / Ribbon / Navigator / Workspace / Docking
        Bastion.Krypton.Suite            (metapackage -> the 5 core packages)

      Extended (MIT, or 'MIT AND MS-PL' for the Ms-PL modules + Ultimate meta):
        Bastion.Krypton.Extended.<Module> per shippable module
        Bastion.Krypton.Extended.Ultimate (metapackage -> shippable modules)

    Each package multi-targets the full 11-TFM matrix
    (net46;net47;net472;net48;net481;net5.0-windows..net10.0-windows) with correct
    per-TFM dependency groups; compat packages (System.ValueTuple/System.Memory on
    net46, System.Resources.Extensions on net47+) appear only on the TFMs needing them.

    Version scheme: default clean SemVer 1.0.0 (spec default). Upstream baseline is
    105.x, recorded in each package's release notes. Override with -Version.

.PARAMETER Version
    Package version (default 1.0.0).

.PARAMETER OutputDir
    Destination feed for the .nupkg/.snupkg (default D:\Krypton-Ultimate\artifacts\nuget).

.PARAMETER Scope
    'Core', 'Extended', or 'All' (default 'All').

.PARAMETER Clean
    Delete the output feed before packing.

.NOTES
    Chris performs the actual `nuget push`. This script never pushes.
    Co-Authored-By: Claude Fable 5 <noreply@anthropic.com>
#>
[CmdletBinding()]
param(
    [string] $Version   = '1.0.0',
    [string] $OutputDir = 'D:\Krypton-Ultimate\artifacts\nuget',
    [ValidateSet('Core','Extended','All')]
    [string] $Scope     = 'All',
    [switch] $Clean
)

$ErrorActionPreference = 'Stop'
$root = $PSScriptRoot

$msbuild = 'C:\Program Files\Microsoft Visual Studio\18\Community\MSBuild\Current\Bin\MSBuild.exe'
if (-not (Test-Path $msbuild)) { throw "Desktop MSBuild not found at: $msbuild" }

if ($Clean -and (Test-Path $OutputDir)) { Remove-Item -Recurse -Force $OutputDir }
New-Item -ItemType Directory -Force -Path $OutputDir | Out-Null
$OutputDir = (Resolve-Path $OutputDir).Path

# Shared MSBuild properties applied to every pack. BastionPack=true flips the
# packaging metadata block on in each repo (version, Bastion authors, SourceLink,
# deterministic, symbols); TreatWarningsAsErrors=false so NuGet NU5xxx advisories
# do not fail the otherwise warning-clean core build during pack.
# AssemblyVersion/FileVersion need 4 numeric parts; derive from $Version (drop any pre-release tag).
$asm4 = @(($Version -split '-')[0] -split '\.')
while ($asm4.Count -lt 4) { $asm4 += '0' }
$asmVer = ($asm4[0..3] -join '.')

$common = @(
    '-nologo','-nr:false','-m:1','-v:m','-clp:Summary',
    '-p:Configuration=Release',
    '-p:BastionPack=true',
    "-p:BastionPackageVersion=$Version",
    # Command-line -p wins over the repo targets that otherwise stamp 105.x, so
    # these force the chosen version and Bastion authorship across every package.
    "-p:Version=$Version",
    "-p:PackageVersion=$Version",
    "-p:AssemblyVersion=$asmVer",
    "-p:FileVersion=$asmVer",
    '-p:Authors=Bastion Software Solutions Ltd',
    '-p:Company=Bastion Software Solutions Ltd',
    '-p:TreatWarningsAsErrors=false',
    "-p:PackageOutputPath=$OutputDir"
)

function Invoke-Pack {
    param([string] $Project, [string[]] $ExtraProps)
    $name = Split-Path $Project -Leaf
    Write-Host "`n=== RESTORE  $name ===" -ForegroundColor Cyan
    # Separate restore: a single -t:Restore,Pack invocation evaluates imports
    # before restore regenerates them, which breaks the net46/47/481 reference-
    # assembly package imports (MSB3644). Restore first, then pack.
    & $msbuild $Project '-t:Restore' @common @ExtraProps
    if ($LASTEXITCODE -ne 0) { throw "Restore failed: $name" }
    Write-Host "=== PACK     $name ===" -ForegroundColor Cyan
    & $msbuild $Project '-t:Pack' @common @ExtraProps
    if ($LASTEXITCODE -ne 0) { throw "Pack failed: $name" }
}

# ---------------------------------------------------------------- CORE
$coreDir = Join-Path $root 'Standard-Toolkit\Source\Krypton Components'
$coreProjects = @(
    'Krypton.Toolkit\Krypton.Toolkit 2022.csproj',
    'Krypton.Ribbon\Krypton.Ribbon 2022.csproj',
    'Krypton.Navigator\Krypton.Navigator 2022.csproj',
    'Krypton.Workspace\Krypton.Workspace 2022.csproj',
    'Krypton.Docking\Krypton.Docking 2022.csproj'
)
# Metapackage lives outside 'Source\Krypton Components' (self-contained, clean deps).
$suiteMeta = Join-Path $root 'Standard-Toolkit\Packaging\Bastion.Krypton.Suite\Bastion.Krypton.Suite.csproj'
if ($Scope -in @('Core','All')) {
    Write-Host "########## CORE packages (BSD-3-Clause) -> $OutputDir" -ForegroundColor Green
    foreach ($p in $coreProjects) {
        # TFMs=all selects the full 11-TFM package id (no '.Lite' suffix).
        Invoke-Pack -Project (Join-Path $coreDir $p) -ExtraProps @('-p:TFMs=all')
    }
    # TFMs=all propagates to the metapackage's ProjectReferences so their
    # dependency ids are the full 'Bastion.Krypton.*' (not the '.Lite' variant).
    Invoke-Pack -Project $suiteMeta -ExtraProps @('-p:TFMs=all')
}

# ------------------------------------------------------------ EXTENDED
# Shippable modules = every Krypton.Toolkit.Suite.Extended.* library that the
# Extended plain solution builds, EXCLUDING the go/no-go-pending Themes and
# Toggle.Switch (CPOL) modules and the non-library tool projects. The Extended
# module csprojs carry GeneratePackageOnBuild=true, so -t:Pack emits each nupkg.
$extDir = Join-Path $root 'Extended-Toolkit\Source\Krypton Toolkit'
# NOT shipped: the go/no-go-pending modules (Themes/Toggle.Switch, CPOL/theme audit)
# plus the incomplete modules upstream deliberately excludes from the Ultimate
# metapackage (commented-out ProjectReferences) - i.e. what the shippable set omits.
# -t:Pack packs any csproj regardless of GeneratePackageOnBuild, so no such filter.
$extExclude = @(
    'Themes','Toggle.Switch',                              # go/no-go pending (THIRD-PARTY-LICENCES.md Sec 3.1 / theme audit)
    'Gages','TaskDialogs','Palette.Selectors','File.Explorer',
    'Software.Updater','Scintilla.NET','PDF',              # not referenced by the Ultimate metapackage (incomplete upstream)
    'Ultimate.Lite'                                        # lite variant of the metapackage
)
if ($Scope -in @('Extended','All')) {
    Write-Host "########## EXTENDED packages (MIT / 'MIT AND MS-PL') -> $OutputDir" -ForegroundColor Green
    $modules = Get-ChildItem -Path $extDir -Directory |
        Where-Object { $_.Name -like 'Krypton.Toolkit.Suite.Extended.*' } | Sort-Object Name
    foreach ($m in $modules) {
        $short = $m.Name -replace '^Krypton\.Toolkit\.Suite\.Extended\.',''
        if ($extExclude -contains $short) { Write-Host "  (skip) $short" -ForegroundColor Yellow; continue }
        $csproj = Get-ChildItem -Path $m.FullName -Filter '*.csproj' | Select-Object -First 1
        if ($null -eq $csproj) { continue }
        # TFMs=all so the core ProjectReferences resolve to the full
        # 'Bastion.Krypton.*' package ids (not the '.Lite' 8-TFM variant).
        try { Invoke-Pack -Project $csproj.FullName -ExtraProps @('-p:TFMs=all') }
        catch { Write-Warning "Extended module failed to pack: $short - $_" }
    }
}

Write-Host "`nDONE. Packages in: $OutputDir" -ForegroundColor Green
Get-ChildItem $OutputDir -Filter '*.nupkg' | Sort-Object Name | ForEach-Object { Write-Host "  $($_.Name)" }
