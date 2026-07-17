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
    [string] $OutputDir = "$PSScriptRoot\artifacts\nuget",
    [ValidateSet('Core','Extended','All')]
    [string] $Scope     = 'All',
    [switch] $Clean,
    # Desktop MSBuild is required (net46 builds under desktop MSBuild only). Leave blank to
    # auto-discover — works locally (VS18) and on CI (GitHub windows-latest via vswhere / PATH).
    [string] $MSBuildPath = ''
)

$ErrorActionPreference = 'Stop'
$root = $PSScriptRoot

# Resolve desktop MSBuild portably: explicit -MSBuildPath, then vswhere, then the local VS18
# default, then whatever setup-msbuild put on PATH.
$msbuild = $MSBuildPath
if (-not $msbuild) {
    $vswhere = "${env:ProgramFiles(x86)}\Microsoft Visual Studio\Installer\vswhere.exe"
    if (Test-Path $vswhere) {
        $msbuild = & $vswhere -latest -requires Microsoft.Component.MSBuild -find 'MSBuild\**\Bin\MSBuild.exe' 2>$null | Select-Object -First 1
    }
}
if (-not $msbuild) {
    $localVs18 = 'C:\Program Files\Microsoft Visual Studio\18\Community\MSBuild\Current\Bin\MSBuild.exe'
    if (Test-Path $localVs18) { $msbuild = $localVs18 }
}
if (-not $msbuild) { $onPath = Get-Command msbuild -ErrorAction SilentlyContinue; if ($onPath) { $msbuild = $onPath.Source } }
if (-not $msbuild -or -not (Test-Path $msbuild)) {
    throw "Desktop MSBuild not found (tried -MSBuildPath, vswhere, the VS18 default, and PATH)."
}
Write-Host "Using MSBuild: $msbuild"

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

# ---------------------------------------------------------- POST-PACK FIXUP
# The Extended.Ultimate metapackage references ~50 modules and multi-targets all
# 11 TFMs, so NuGet emits one dependency group per TFM (~601 entries, ~59 KB) - past
# nuget.org's hard 32,767-char limit on the serialized <dependencies> element, which
# rejects the push with HTTP 400. The 11 groups reduce to just 3 DISTINCT dependency
# sets, and NuGet resolves each consumer to the nearest compatible group, so we keep
# only 4 representative groups (one net4x-low, one net4.7 for net47..net481, one
# net5 for net5..net8, one net9 for net9..net10). Result: ~21 KB, well under the cap,
# functionally identical for every consumer.
function Repair-UltimateDependencies {
    param([string] $NupkgPath)
    $keep = @('.NETFramework4.6', '.NETFramework4.7', 'net5.0-windows7.0', 'net9.0-windows7.0')
    Add-Type -AssemblyName System.IO.Compression | Out-Null
    Add-Type -AssemblyName System.IO.Compression.FileSystem | Out-Null

    $zin = [System.IO.Compression.ZipFile]::OpenRead($NupkgPath)
    try {
        $nuspecEntry = $zin.Entries | Where-Object { $_.FullName -like '*.nuspec' } | Select-Object -First 1
        $nuspecName = $nuspecEntry.FullName
        $sr = New-Object System.IO.StreamReader($nuspecEntry.Open()); $nuspecXml = $sr.ReadToEnd(); $sr.Close()
    } finally { $zin.Dispose() }

    [xml]$doc = $nuspecXml
    $ns = New-Object System.Xml.XmlNamespaceManager($doc.NameTable)
    $ns.AddNamespace('n', $doc.DocumentElement.NamespaceURI)
    $deps = $doc.SelectSingleNode('//n:dependencies', $ns)
    if ($null -eq $deps) { return }
    $groups = @($deps.SelectNodes('n:group', $ns))
    if ($groups.Count -le $keep.Count -and $deps.OuterXml.Length -lt 32767) { return }  # already fine

    $removed = 0
    foreach ($g in $groups) { if ($keep -notcontains $g.targetFramework) { [void]$deps.RemoveChild($g); $removed++ } }
    if ($removed -eq 0) { return }
    if ($deps.OuterXml.Length -ge 32767) { throw "Ultimate <dependencies> still over 32767 after pruning ($($deps.OuterXml.Length))." }
    $newNuspec = $doc.OuterXml

    $tmp = "$NupkgPath.tmp"
    if (Test-Path $tmp) { Remove-Item $tmp -Force }
    $zoutStream = [System.IO.File]::Open($tmp, [System.IO.FileMode]::CreateNew)
    $zout = New-Object System.IO.Compression.ZipArchive($zoutStream, [System.IO.Compression.ZipArchiveMode]::Create)
    $zin2 = [System.IO.Compression.ZipFile]::OpenRead($NupkgPath)
    try {
        foreach ($e in $zin2.Entries) {
            $ne = $zout.CreateEntry($e.FullName, [System.IO.Compression.CompressionLevel]::Optimal)
            $os = $ne.Open()
            if ($e.FullName -eq $nuspecName) {
                $bytes = [System.Text.Encoding]::UTF8.GetBytes($newNuspec); $os.Write($bytes, 0, $bytes.Length)
            } else { $is = $e.Open(); $is.CopyTo($os); $is.Close() }
            $os.Close()
        }
    } finally { $zin2.Dispose(); $zout.Dispose(); $zoutStream.Close() }
    Move-Item $tmp $NupkgPath -Force
    Write-Host "  Repaired Ultimate metapackage: kept $($keep.Count) dependency groups (removed $removed), now $($deps.OuterXml.Length) chars." -ForegroundColor Yellow
}

Get-ChildItem $OutputDir -Filter 'Bastion.Krypton.Extended.Ultimate.*.nupkg' -ErrorAction SilentlyContinue |
    ForEach-Object { Repair-UltimateDependencies -NupkgPath $_.FullName }

Write-Host "`nDONE. Packages in: $OutputDir" -ForegroundColor Green
Get-ChildItem $OutputDir -Filter '*.nupkg' | Sort-Object Name | ForEach-Object { Write-Host "  $($_.Name)" }
