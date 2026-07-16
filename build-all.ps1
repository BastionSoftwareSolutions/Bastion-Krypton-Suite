<#
.SYNOPSIS
    Bastion Krypton Suite - end-to-end orchestrator (spec §9 exit criterion:
    "clean clone -> build-all.ps1 -> full artefact set reproduces end-to-end").

    © Bastion Software Solutions Ltd 2026. New (Bastion) orchestration file in a work
    derived from BSD-3-Clause (Component Factory Pty Ltd; Krypton Suite) and MIT
    (Krypton Suite, Extended) licensed code. This script never pushes anything.

.DESCRIPTION
    Runs the whole suite across the four-repo layout (see REPO-LAYOUT.md), in order:

      0. PREFLIGHT  - verify the three sibling clones exist and the toolchain is present;
                      fail fast with actionable messages.
      1. CORE       - build the five core libraries (Standard-Toolkit) with desktop MSBuild.
      2. EXTENDED   - build the Extended modules (Extended-Toolkit plain solution).
      3. SAMPLES    - build the C#+VB demo set (Standard-Toolkit-Demos dev solutions).
      4. SMOKE      - a smoke/functional check (Tests\run-tests.ps1 FunctionalTests).
      5. PACK       - pack.ps1 (NuGet packages -> artifacts\nuget).
      6. DOCS       - build-docs.ps1 (site by default; -Docs All adds CHM+PDF).
      7. INSTALLER  - Installer\build-installer.ps1 (Inno Setup .exe).

    Idempotent: re-running rebuilds in place. Long by nature (a full 11-TFM run packs 57
    packages and builds hundreds of sample × TFM combinations); use the switches to scope it.

    net46 requires DESKTOP MSBuild (classic .resx). This script locates it via vswhere and
    uses it for the build stages; `dotnet build` alone cannot build net46.

.PARAMETER Tfm
    Restrict the BUILD stages (core/Extended/samples/smoke) to a single TFM for a fast run,
    e.g. -Tfm net8.0-windows. Default '' = the full 11-TFM matrix. PACK always emits the
    full matrix (per-package TFMs=all) regardless of this switch.

.PARAMETER PackScope   Core | Extended | All   (default All) - forwarded to pack.ps1.
.PARAMETER Docs        Site | All               (default Site) - Site is CI-friendly; All
                       adds the Windows-only CHM + PDF (needs SHFB/hhc + pandoc/wkhtmltopdf).
.PARAMETER Version     Package/installer version (default 1.0.0).
.PARAMETER SkipExtended / SkipSamples / SkipSmoke / SkipPack / SkipDocs / SkipInstaller
                       Skip the named stage. (Installer + Docs 'All' are Windows-tool-heavy;
                       CHM/PDF/installer were verified in Phases 6/7 and can be skipped in
                       routine runs.)

.EXAMPLE
    .\build-all.ps1                                   # full end-to-end (long)
.EXAMPLE
    .\build-all.ps1 -Tfm net8.0-windows -Docs Site    # fast single-TFM pass, site only
.EXAMPLE
    .\build-all.ps1 -SkipInstaller -Docs Site         # everything but the installer + CHM/PDF

.NOTES
    Co-Authored-By: Claude Fable 5 <noreply@anthropic.com>
#>
[CmdletBinding()]
param(
    [ValidateSet('', 'net46','net47','net472','net48','net481',
                 'net5.0-windows','net6.0-windows','net7.0-windows',
                 'net8.0-windows','net9.0-windows','net10.0-windows')]
    [string] $Tfm = '',

    [ValidateSet('Core','Extended','All')]
    [string] $PackScope = 'All',

    [ValidateSet('Site','All')]
    [string] $Docs = 'Site',

    [string] $Version = '1.0.0',

    [switch] $SkipExtended,
    [switch] $SkipSamples,
    [switch] $SkipSmoke,
    [switch] $SkipPack,
    [switch] $SkipDocs,
    [switch] $SkipInstaller
)

$ErrorActionPreference = 'Stop'
$root = $PSScriptRoot
Set-Location $root

$script:stageTimes = [ordered]@{}
function Write-Head([string]$t) { Write-Host "`n############## $t" -ForegroundColor Green }
function Fail([string]$m) { Write-Host "PREFLIGHT/STAGE FAILURE: $m" -ForegroundColor Red; throw $m }

# --------------------------------------------------------------- desktop MSBuild
function Find-MSBuild {
    $vswhere = Join-Path ${env:ProgramFiles(x86)} 'Microsoft Visual Studio\Installer\vswhere.exe'
    if (-not (Test-Path $vswhere)) { Fail "vswhere.exe not found ($vswhere). Install Visual Studio 2022+/Build Tools with the .NET desktop workload." }
    $msb = & $vswhere -latest -requires Microsoft.Component.MSBuild -find 'MSBuild\**\Bin\MSBuild.exe' | Select-Object -First 1
    if (-not $msb) { Fail "Desktop MSBuild not found via vswhere. Install the VS .NET desktop workload." }
    return $msb
}

# TFM-scoping: passing -p:TargetFramework=<tfm> to a solution build forces every
# multi-target project to that single TFM (fast). Empty $Tfm => full matrix.
function Tfm-Props {
    if ([string]::IsNullOrWhiteSpace($Tfm)) { return @() }
    return @("-p:TargetFramework=$Tfm")
}

function Invoke-SolutionBuild([string]$msbuild, [string]$sln, [string]$label) {
    if (-not (Test-Path $sln)) { Fail "$label solution not found: $sln" }
    Write-Head "$label - RESTORE"
    & $msbuild $sln -t:Restore -p:Configuration=Release -m -v:m @(Tfm-Props)
    if ($LASTEXITCODE -ne 0) { Fail "$label restore failed (exit $LASTEXITCODE)" }
    Write-Head "$label - BUILD (Release$(if($Tfm){" [$Tfm]"}else{' [all TFMs]'}))"
    & $msbuild $sln -t:Build -p:Configuration=Release -m -v:m -clp:Summary @(Tfm-Props)
    if ($LASTEXITCODE -ne 0) { Fail "$label build failed (exit $LASTEXITCODE)" }
}

function Time-Stage([string]$name, [scriptblock]$body) {
    $sw = [System.Diagnostics.Stopwatch]::StartNew()
    & $body
    $sw.Stop()
    $script:stageTimes[$name] = '{0:hh\:mm\:ss}' -f $sw.Elapsed
    Write-Host "[$name] done in $($script:stageTimes[$name])" -ForegroundColor Cyan
}

# =============================================================== 0. PREFLIGHT
Write-Head '0. PREFLIGHT'

$coreDir   = Join-Path $root 'Standard-Toolkit'
$extDir    = Join-Path $root 'Extended-Toolkit'
$demosDir  = Join-Path $root 'Standard-Toolkit-Demos'

$coreSln   = Join-Path $coreDir  'Source\Krypton Components\Krypton Toolkit Suite 2022 - VS2022.sln'
$extSln    = Join-Path $extDir   'Source\Krypton Toolkit\Krypton Toolkit Suite Extended 2022 - VS2022.sln'

# Sibling clones (REPO-LAYOUT.md). Core is always required; Extended/Samples only if not skipped.
if (-not (Test-Path $coreDir))  { Fail "Missing sibling clone 'Standard-Toolkit'. Clone it into $root on branch bastion/multitarget (see REPO-LAYOUT.md)." }
if (-not (Test-Path $coreSln))  { Fail "Core solution not found ($coreSln). Is the Standard-Toolkit clone complete?" }
if (-not $SkipExtended -and -not (Test-Path $extDir))   { Fail "Missing sibling clone 'Extended-Toolkit' (or pass -SkipExtended). See REPO-LAYOUT.md." }
if (-not $SkipSamples  -and -not (Test-Path $demosDir)) { Fail "Missing sibling clone 'Standard-Toolkit-Demos' (or pass -SkipSamples). See REPO-LAYOUT.md." }

# Toolchain
$msbuild = Find-MSBuild
Write-Host "Desktop MSBuild: $msbuild"
$dotnet = Get-Command dotnet -ErrorAction SilentlyContinue
if (-not $dotnet) { Fail "'dotnet' not on PATH. Install the .NET 10 SDK." }
Write-Host "dotnet SDK:      $(& dotnet --version)"

# Stage-specific tool checks (warn/fail only for stages actually requested)
if (-not $SkipPack -and -not (Test-Path (Join-Path $root 'pack.ps1'))) { Fail "pack.ps1 missing." }
if (-not $SkipDocs) {
    if (-not (Test-Path (Join-Path $root 'build-docs.ps1'))) { Fail "build-docs.ps1 missing." }
    $docfx = Join-Path $env:USERPROFILE '.dotnet\tools\docfx.exe'
    if (-not (Test-Path $docfx)) { Fail "DocFX not found ($docfx). Install: dotnet tool install --global docfx  (or pass -SkipDocs)." }
    if ($Docs -eq 'All') { Write-Host "NOTE: -Docs All builds the Windows-only CHM (SHFB/hhc) + PDF (pandoc/wkhtmltopdf); ensure those are installed (Phase 0 table) or use -Docs Site." -ForegroundColor Yellow }
}
if (-not $SkipInstaller) {
    $iss = Join-Path $root 'Installer\build-installer.ps1'
    $iscc = Join-Path $env:LOCALAPPDATA 'Programs\Inno Setup 6\ISCC.exe'
    if (-not (Test-Path $iss))  { Fail "Installer\build-installer.ps1 missing (or pass -SkipInstaller)." }
    if (-not (Test-Path $iscc)) { Write-Host "NOTE: ISCC.exe not at $iscc; build-installer.ps1 will error if Inno Setup 6 is absent. Use -SkipInstaller to skip." -ForegroundColor Yellow }
}
Write-Host "Preflight OK." -ForegroundColor Green

# =============================================================== 1. CORE
Time-Stage 'core' { Invoke-SolutionBuild $msbuild $coreSln 'CORE (Standard-Toolkit)' }

# =============================================================== 2. EXTENDED
if ($SkipExtended) { Write-Head '2. EXTENDED - skipped' }
else { Time-Stage 'extended' { Invoke-SolutionBuild $msbuild $extSln 'EXTENDED (Extended-Toolkit)' } }

# =============================================================== 3. SAMPLES
if ($SkipSamples) { Write-Head '3. SAMPLES - skipped' }
else {
    Time-Stage 'samples' {
        # Build the Release "- Dev.sln" sample solutions (they reference the source trees by
        # ProjectReference). run-sample.ps1 / run-sample-matrix.ps1 in the Demos repo drive
        # the exhaustive per-TFM launch matrix; here we compile them.
        $devSlns = Get-ChildItem -Path (Join-Path $demosDir 'Source') -Recurse -Filter '*.sln' |
            Where-Object { $_.Name -like '*Release*Dev.sln' }
        if (-not $devSlns) { Fail "No sample '*Release* Dev.sln' solutions found under $demosDir\Source." }
        foreach ($s in $devSlns) { Invoke-SolutionBuild $msbuild $s.FullName "SAMPLE: $($s.BaseName)" }
    }
}

# =============================================================== 4. SMOKE / FUNCTIONAL
if ($SkipSmoke) { Write-Head '4. SMOKE - skipped' }
else {
    Time-Stage 'smoke' {
        Write-Head '4. SMOKE / FUNCTIONAL (Tests\run-tests.ps1 FunctionalTests)'
        $smokeTfm = if ($Tfm) { $Tfm } else { 'net8.0-windows' }
        # net5/6/7 need the private legacy runtimes; if the caller pinned one of those and
        # they are absent, fall back to net8 for the smoke gate.
        if ($smokeTfm -in @('net5.0-windows','net6.0-windows','net7.0-windows') -and
            -not (Test-Path (Join-Path $root 'Tools\dotnet-legacy\dotnet.exe'))) {
            Write-Host "Legacy runtime for $smokeTfm absent; smoke gate uses net8.0-windows." -ForegroundColor Yellow
            $smokeTfm = 'net8.0-windows'
        }
        & (Join-Path $root 'Tests\run-tests.ps1') -Project FunctionalTests -Tfm $smokeTfm
        if ($LASTEXITCODE -ne 0) { Fail "Smoke/functional check failed on $smokeTfm." }
    }
}

# =============================================================== 5. PACK
if ($SkipPack) { Write-Head '5. PACK - skipped' }
else {
    Time-Stage 'pack' {
        Write-Head "5. PACK (pack.ps1 -Scope $PackScope -Version $Version)"
        & (Join-Path $root 'pack.ps1') -Scope $PackScope -Version $Version
        if ($LASTEXITCODE -ne 0 -and $LASTEXITCODE -ne $null) { Fail "pack.ps1 failed (exit $LASTEXITCODE)." }
    }
}

# =============================================================== 6. DOCS
if ($SkipDocs) { Write-Head '6. DOCS - skipped' }
else {
    Time-Stage 'docs' {
        Write-Head "6. DOCS (build-docs.ps1 -$Docs)"
        if ($Docs -eq 'All') { & (Join-Path $root 'build-docs.ps1') -All }
        else                 { & (Join-Path $root 'build-docs.ps1') -Site }
        if ($LASTEXITCODE -ne 0 -and $LASTEXITCODE -ne $null) { Fail "build-docs.ps1 failed (exit $LASTEXITCODE)." }
    }
}

# =============================================================== 7. INSTALLER
if ($SkipInstaller) { Write-Head '7. INSTALLER - skipped' }
else {
    Time-Stage 'installer' {
        Write-Head '7. INSTALLER (Installer\build-installer.ps1)'
        & (Join-Path $root 'Installer\build-installer.ps1') -Version $Version
        if ($LASTEXITCODE -ne 0 -and $LASTEXITCODE -ne $null) { Fail "build-installer.ps1 failed (exit $LASTEXITCODE)." }
    }
}

# =============================================================== SUMMARY
Write-Head 'BUILD-ALL COMPLETE'
Write-Host "TFM scope : $(if($Tfm){$Tfm}else{'all 11'})"
Write-Host "Version   : $Version"
Write-Host "Stage timings:" -ForegroundColor Cyan
$script:stageTimes.GetEnumerator() | ForEach-Object { '{0,-10} {1}' -f $_.Key, $_.Value } | ForEach-Object { Write-Host "  $_" }
Write-Host "`nArtefacts:" -ForegroundColor Cyan
Write-Host "  NuGet     : artifacts\nuget\*.nupkg"
Write-Host "  Docs site : docs-site\"
if (-not $SkipInstaller) { Write-Host "  Installer : Installer\Output\ (or as build-installer.ps1 reports)" }
Write-Host "`nNothing has been pushed. See docs\RELEASE-CHECKLIST.md for publishing." -ForegroundColor Green
