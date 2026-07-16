<#
.SYNOPSIS
    Stages the payload and builds the Bastion Krypton Suite Inno Setup installer.

.DESCRIPTION
    Phase 7 / spec 8.2. Populates a clean staging tree with only the shippable
    Bastion.Krypton.* assemblies (+ XML + PDB) per target framework, the docs,
    the Theme Browser app, and the sample SOURCE, then invokes ISCC on
    BastionKryptonSuite.iss to produce:
        artifacts\installer\Bastion Krypton Suite <version> Setup.exe

.PARAMETER Version
    Product/file version (default 1.0.0). Drives the output filename and version
    stamp. Pass 1.0.1 to build the upgrade variant used by the lifecycle test.

.PARAMETER SkipStaging
    Reuse an existing staging tree (skip the copy step); just recompile.

.EXAMPLE
    pwsh .\build-installer.ps1
    pwsh .\build-installer.ps1 -Version 1.0.1
#>
[CmdletBinding()]
param(
    [string]$Version = "1.0.0",
    [switch]$SkipStaging
)

$ErrorActionPreference = "Stop"
$repo      = Split-Path -Parent $PSScriptRoot          # D:\Krypton-Ultimate
$installer = $PSScriptRoot
$stage     = Join-Path $repo "artifacts\installer-staging"
$outDir    = Join-Path $repo "artifacts\installer"

$coreBin      = Join-Path $repo "Standard-Toolkit\Bin\Release"
$extBin       = Join-Path $repo "Extended-Toolkit\Bin\Release"
$helpDir      = Join-Path $repo "Help"
$themeBrowser = Join-Path $repo "Scripts\ThemeBrowser\bin\Release\net8.0-windows"
$demosSrc     = Join-Path $repo "Standard-Toolkit-Demos\Source"
$extExamples  = Join-Path $repo "Extended-Toolkit\Source\Krypton Toolkit\Examples"

# Canonical 11 target frameworks (aligns extended libs to the core TFM set;
# the extended tree also contains *-windows7.0 duplicates which we skip).
$tfms = @(
    "net46","net47","net472","net48","net481",
    "net5.0-windows","net6.0-windows","net7.0-windows",
    "net8.0-windows","net9.0-windows","net10.0-windows"
)

# Extended modules NOT shipped pending third-party licence resolution
# (docs/audit/THIRD-PARTY-LICENCES.md 3.1-3.2):
#   Toggle.Switch    - module-scale CPOL derivation
#   Software.Updater - contains SharpUpdate (no upstream licence)
$extExclude = @(
    "Bastion.Krypton.Extended.Toggle.Switch",
    "Bastion.Krypton.Extended.Software.Updater"   # keeps Software.Updater.Core (NetSparkle, MIT)
)

function Copy-One($src, $dstDir) {
    if (-not (Test-Path $dstDir)) { New-Item -ItemType Directory -Force -Path $dstDir | Out-Null }
    Copy-Item -LiteralPath $src -Destination $dstDir -Force
}

if (-not $SkipStaging) {
    Write-Host "==> Cleaning staging tree: $stage"
    if (Test-Path $stage) { Remove-Item -Recurse -Force $stage }
    New-Item -ItemType Directory -Force -Path $stage | Out-Null

    # ---- 1. Core libraries: lib\<tfm>\  (Bastion.Krypton.*.dll/.xml/.pdb) ----
    Write-Host "==> Staging core libraries"
    foreach ($tfm in $tfms) {
        $srcTfm = Join-Path $coreBin $tfm
        if (-not (Test-Path $srcTfm)) { Write-Warning "core TFM missing: $tfm"; continue }
        $dst = Join-Path $stage "lib\$tfm"
        Get-ChildItem -LiteralPath $srcTfm -File |
            Where-Object { $_.Name -like "Bastion.Krypton.*" -and $_.Extension -in ".dll",".xml",".pdb" } |
            ForEach-Object { Copy-One $_.FullName $dst }
    }

    # ---- 2. Extended libraries: lib-extended\<tfm>\  (dedupe by filename) ----
    Write-Host "==> Staging extended libraries"
    foreach ($tfm in $tfms) {
        $dst = Join-Path $stage "lib-extended\$tfm"
        $seen = @{}
        Get-ChildItem -LiteralPath $extBin -Directory | ForEach-Object {
            $modTfm = Join-Path $_.FullName $tfm
            if (-not (Test-Path $modTfm)) { return }
            Get-ChildItem -LiteralPath $modTfm -File |
                Where-Object {
                    ($_.Name -like "Bastion.Krypton.Extended.*" -and $_.Extension -in ".dll",".pdb") -or
                    ($_.Name -like "Krypton.Toolkit.Suite.Extended.*" -and $_.Extension -eq ".xml")
                } |
                ForEach-Object {
                    $base = $_.BaseName
                    # apply exclusions on the Bastion assembly base name
                    $excluded = $false
                    foreach ($ex in $extExclude) {
                        $exXml = $ex -replace '^Bastion\.Krypton\.Extended\.','Krypton.Toolkit.Suite.Extended.'
                        if ($_.Name -like "$ex.*" -or $_.Name -like "$exXml.*") { $excluded = $true; break }
                    }
                    if ($excluded) { return }
                    if (-not $seen.ContainsKey($_.Name)) {
                        $seen[$_.Name] = $true
                        Copy-One $_.FullName $dst
                    }
                }
        }
    }

    # ---- 3. Documentation ----
    Write-Host "==> Staging documentation"
    $docDst = Join-Path $stage "Documentation"
    Copy-One (Join-Path $helpDir "BastionKryptonSuite.chm") $docDst
    Copy-One (Join-Path $helpDir "BastionKryptonSuite-Manual.pdf") $docDst

    # ---- 4. Theme Browser app (.NET 8) ----
    Write-Host "==> Staging Theme Browser app"
    $tbDst = Join-Path $stage "ThemeBrowser"
    robocopy $themeBrowser $tbDst /E /NFL /NDL /NJH /NJS /NP | Out-Null
    if ($LASTEXITCODE -ge 8) { throw "robocopy ThemeBrowser failed ($LASTEXITCODE)" }

    # ---- 5. Samples (SOURCE, both languages; exclude build output) ----
    Write-Host "==> Staging sample source"
    $smpDst = Join-Path $stage "Samples\StandardToolkit"
    robocopy $demosSrc $smpDst /E /XD bin obj .vs /XF *.user /NFL /NDL /NJH /NJS /NP | Out-Null
    if ($LASTEXITCODE -ge 8) { throw "robocopy samples failed ($LASTEXITCODE)" }
    if (Test-Path $extExamples) {
        $extDst = Join-Path $stage "Samples\ExtendedExamples"
        robocopy $extExamples $extDst /E /XD bin obj .vs /XF *.user /NFL /NDL /NJH /NJS /NP | Out-Null
        if ($LASTEXITCODE -ge 8) { throw "robocopy extended examples failed ($LASTEXITCODE)" }
    }

    Write-Host "==> Staging complete."
}

# ---- Compile with ISCC ----
$iscc = Join-Path $env:LOCALAPPDATA "Programs\Inno Setup 6\ISCC.exe"
if (-not (Test-Path $iscc)) { throw "ISCC.exe not found at $iscc" }
if (-not (Test-Path $outDir)) { New-Item -ItemType Directory -Force -Path $outDir | Out-Null }

$iss = Join-Path $installer "BastionKryptonSuite.iss"
Write-Host "==> Compiling installer (v$Version)"
& $iscc "/DMyAppVersion=$Version" "/DStageDir=$stage" "/DOutputDir=$outDir" $iss
if ($LASTEXITCODE -ne 0) { throw "ISCC failed ($LASTEXITCODE)" }

$setup = Join-Path $outDir "Bastion Krypton Suite $Version Setup.exe"
if (Test-Path $setup) {
    $sizeMB = [math]::Round((Get-Item $setup).Length / 1MB, 1)
    Write-Host "==> SUCCESS: $setup  ($sizeMB MB)"
} else {
    throw "Expected output not found: $setup"
}
