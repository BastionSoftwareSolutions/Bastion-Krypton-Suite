<#
.SYNOPSIS
    Stages the payload and builds the Bastion Krypton Suite Inno Setup installer
    (enhanced, beginner-first edition).

.DESCRIPTION
    Populates a staging tree with the shippable payload, then invokes ISCC on
    BastionKryptonSuite.iss to produce:
        artifacts\installer\Bastion Krypton Suite <version> Setup.exe

    Staged payload:
        lib\<tfm>\            Core Bastion.Krypton.* assemblies (+ XML + PDB), 11 TFMs
        lib-extended\<tfm>\   Extended Bastion.Krypton.Extended.* assemblies, 11 TFMs
        Documentation\        CHM help + PDF manual + HTML help site (html\)
        Samples\              Sample SOURCE (C# + VB.NET) + Extended examples source
        Samples-Compiled\     PRE-BUILT runnable apps (net8):
                                Demos\            Krypton Explorer + 250 sample exes
                                ExtendedExamples\ Examples.exe
                                ThemeBrowser\     KryptonThemeBrowser.exe

    NOTE on lib-extended: the extended toolkit's Bin\Release is multi-targeted.
    A single-TFM build (e.g. building the Examples app for net8 only) leaves the
    extended Bin\Release populated for net8 only. To avoid shipping a partial
    lib-extended, the script regenerates lib-extended from Bin\Release ONLY when
    that tree contains more than one TFM (a full multi-target build); otherwise it
    PRESERVES the existing staged lib-extended (from the last full extended build).
    Pass -ForceExtendedFromBin to override.

.PARAMETER Version
    Product/file version (default 1.0.0). Drives the output filename and version stamp.

.PARAMETER SkipStaging
    Reuse the existing staging tree (skip the copy step); just recompile.

.PARAMETER ForceExtendedFromBin
    Always regenerate lib-extended from Extended-Toolkit\Bin\Release, even if only
    one TFM is present (will ship a partial extended set - use only after a full
    multi-TFM extended build).

.EXAMPLE
    pwsh .\build-installer.ps1
    pwsh .\build-installer.ps1 -Version 1.0.1 -SkipStaging
#>
[CmdletBinding()]
param(
    [string]$Version = "1.0.0",
    [switch]$SkipStaging,
    [switch]$ForceExtendedFromBin
)

$ErrorActionPreference = "Stop"
$repo      = Split-Path -Parent $PSScriptRoot          # D:\Krypton-Ultimate
$installer = $PSScriptRoot
$stage     = Join-Path $repo "artifacts\installer-staging"
$outDir    = Join-Path $repo "artifacts\installer"

$coreBin      = Join-Path $repo "Standard-Toolkit\Bin\Release"
$extBin       = Join-Path $repo "Extended-Toolkit\Bin\Release"
$helpDir      = Join-Path $repo "Help"
$docsSite     = Join-Path $repo "docs-site"
$themeBrowser = Join-Path $repo "Scripts\ThemeBrowser\bin\Release\net8.0-windows"
$demosBin     = Join-Path $repo "Standard-Toolkit-Demos\Binaries\Krypton Demos\Release\net8.0-windows"
$examplesBin  = Join-Path $repo "Extended-Toolkit\Bin\Examples\Release\net8.0-windows"
$demosSrc     = Join-Path $repo "Standard-Toolkit-Demos\Source"
$extExamples  = Join-Path $repo "Extended-Toolkit\Source\Krypton Toolkit\Examples"

# Canonical 11 target frameworks.
$tfms = @(
    "net46","net47","net472","net48","net481",
    "net5.0-windows","net6.0-windows","net7.0-windows",
    "net8.0-windows","net9.0-windows","net10.0-windows"
)

# Extended modules NOT shipped pending third-party licence resolution
# (docs/audit/THIRD-PARTY-LICENCES.md 3.1-3.2).
$extExclude = @(
    "Bastion.Krypton.Extended.Toggle.Switch",
    "Bastion.Krypton.Extended.Software.Updater"   # keeps Software.Updater.Core (NetSparkle, MIT)
)

function Copy-One($src, $dstDir) {
    if (-not (Test-Path $dstDir)) { New-Item -ItemType Directory -Force -Path $dstDir | Out-Null }
    Copy-Item -LiteralPath $src -Destination $dstDir -Force
}

function Clean-Sub($name) {
    $p = Join-Path $stage $name
    if (Test-Path $p) { Remove-Item -Recurse -Force $p }
}

function Robo($src, $dst, [string[]]$extra) {
    $args = @($src, $dst, "/E", "/NFL", "/NDL", "/NJH", "/NJS", "/NP") + $extra
    & robocopy @args | Out-Null
    if ($LASTEXITCODE -ge 8) { throw "robocopy failed ($LASTEXITCODE): $src -> $dst" }
}

if (-not $SkipStaging) {
    New-Item -ItemType Directory -Force -Path $stage | Out-Null

    # ---- 1. Core libraries: lib\<tfm>\ ----
    Write-Host "==> Staging core libraries (fresh from $coreBin)"
    Clean-Sub "lib"
    foreach ($tfm in $tfms) {
        $srcTfm = Join-Path $coreBin $tfm
        if (-not (Test-Path $srcTfm)) { Write-Warning "core TFM missing: $tfm"; continue }
        $dst = Join-Path $stage "lib\$tfm"
        Get-ChildItem -LiteralPath $srcTfm -File |
            Where-Object { $_.Name -like "Bastion.Krypton.*" -and $_.Extension -in ".dll",".xml",".pdb" } |
            ForEach-Object { Copy-One $_.FullName $dst }
    }

    # ---- 2. Extended libraries: lib-extended\<tfm>\ ----
    # Only regenerate if Bin\Release is a full multi-TFM build; otherwise preserve.
    $extTfmDirs = @()
    if (Test-Path $extBin) {
        $extTfmDirs = Get-ChildItem -LiteralPath $extBin -Directory |
            ForEach-Object { Get-ChildItem -LiteralPath $_.FullName -Directory -ErrorAction SilentlyContinue } |
            Select-Object -ExpandProperty Name -Unique
    }
    $extFull = ($extTfmDirs.Count -gt 1)
    if ($ForceExtendedFromBin -or $extFull) {
        Write-Host "==> Staging extended libraries (fresh; $($extTfmDirs.Count) TFM(s) in Bin\Release)"
        Clean-Sub "lib-extended"
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
    } else {
        $keep = Join-Path $stage "lib-extended"
        if (Test-Path $keep) {
            Write-Warning "extended Bin\Release has <=1 TFM; PRESERVING existing staged lib-extended ($(( Get-ChildItem $keep -Directory).Count) TFMs). Run a full multi-TFM extended build then -ForceExtendedFromBin to regenerate."
        } else {
            throw "No staged lib-extended and extended Bin\Release is not a full multi-TFM build. Run a full extended build first."
        }
    }

    # ---- 3. Documentation: CHM + PDF + HTML help site ----
    Write-Host "==> Staging documentation (CHM + PDF + HTML site)"
    Clean-Sub "Documentation"
    $docDst = Join-Path $stage "Documentation"
    Copy-One (Join-Path $helpDir "BastionKryptonSuite.chm") $docDst
    Copy-One (Join-Path $helpDir "BastionKryptonSuite-Manual.pdf") $docDst
    if (Test-Path $docsSite) {
        Robo $docsSite (Join-Path $docDst "html") @()
    } else {
        Write-Warning "docs-site not found at $docsSite - HTML help site will be missing"
    }

    # ---- 4. Sample SOURCE ----
    Write-Host "==> Staging sample source"
    Clean-Sub "Samples"
    Robo $demosSrc (Join-Path $stage "Samples\StandardToolkit") @("/XD","bin","obj",".vs","/XF","*.user")
    if (Test-Path $extExamples) {
        Robo $extExamples (Join-Path $stage "Samples\ExtendedExamples") @("/XD","bin","obj",".vs","/XF","*.user")
    }

    # ---- 5. Pre-built runnable apps (Samples-Compiled\) ----
    Write-Host "==> Staging pre-built runnable apps"
    Clean-Sub "Samples-Compiled"
    $scDst = Join-Path $stage "Samples-Compiled"
    if (-not (Test-Path $demosBin))    { throw "Demo binaries missing: $demosBin (build the Krypton Explorer solution with /p:SampleTfm=net8.0-windows)" }
    if (-not (Test-Path $examplesBin)) { throw "Examples binaries missing: $examplesBin (build Examples.csproj for net8.0-windows)" }
    if (-not (Test-Path $themeBrowser)){ throw "Theme Browser binaries missing: $themeBrowser" }
    Robo $demosBin    (Join-Path $scDst "Demos") @()
    Robo $examplesBin (Join-Path $scDst "ExtendedExamples") @()
    Robo $themeBrowser (Join-Path $scDst "ThemeBrowser") @()
    Copy-One (Join-Path $installer "SAMPLES-COMPILED-README.txt") $scDst

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
