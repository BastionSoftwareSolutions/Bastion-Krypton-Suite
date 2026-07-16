<#
.SYNOPSIS
    Runs a Bastion Krypton Suite test project for a chosen TFM (spec §6.1/§6.4).

    © Bastion Software Solutions Ltd 2026. Part of the Bastion Krypton Suite test suite.
    New (Bastion) file in a work derived from BSD-3-Clause licensed code
    (Component Factory Pty Ltd; Krypton-Suite et al.).

.DESCRIPTION
    Builds with desktop MSBuild (foreground, /nr:false — net46 requires desktop MSBuild) and
    then runs the tests:
      - net47..net10.0-windows : dotnet test (Microsoft.NET.Test.Sdk + NUnit3TestAdapter),
                                 TRX written to Tests\artifacts\<project>\<tfm>\results.trx
      - net46                  : the project's self-executing NUnitLite console runner,
                                 NUnit3 XML written to Tests\artifacts\<project>\<tfm>\TestResult.xml
    (Framework decision and the net46 fallback mechanism: Tests\README.md.)
    Failure screenshots land in Tests\artifacts\<project>\<tfm>\screenshots.

.PARAMETER Project
    UnitTests | FormsTests | FormsTests.VB | FunctionalTests | StressTests (default UnitTests).

.PARAMETER Tfm
    Target framework moniker to run (default net8.0-windows).

.PARAMETER All
    Sweep the functional projects (UnitTests, FormsTests, FormsTests.VB, FunctionalTests)
    across all 11 TFMs and print a summary table. StressTests is excluded (run it
    explicitly: it is the long-running adversarial suite of spec §6.3).

.PARAMETER Category
    Test-category selection (spec §6.3; matters for StressTests, harmless elsewhere):
      Default   - everything except [Category("Endurance")] (the default).
      Endurance - only the extra-long endurance tests (25-round theme storm,
                  2,500 create/destroy cycles, 100k-row grids).
      All       - no category filter.

.PARAMETER NoBuild
    Skip the build step (reuse existing Release outputs).

.EXAMPLE
    .\run-tests.ps1 -Project FormsTests -Tfm net48
.EXAMPLE
    .\run-tests.ps1 -Project StressTests -Tfm net48 -Category Endurance
.EXAMPLE
    .\run-tests.ps1 -All
#>
[CmdletBinding()]
param(
    [ValidateSet('UnitTests', 'FormsTests', 'FormsTests.VB', 'FunctionalTests', 'StressTests')]
    [string]$Project = 'UnitTests',

    [ValidateSet('net46', 'net47', 'net472', 'net48', 'net481',
                 'net5.0-windows', 'net6.0-windows', 'net7.0-windows',
                 'net8.0-windows', 'net9.0-windows', 'net10.0-windows')]
    [string]$Tfm = 'net8.0-windows',

    [switch]$All,

    [ValidateSet('Default', 'Endurance', 'All')]
    [string]$Category = 'Default',

    [switch]$NoBuild
)

$ErrorActionPreference = 'Stop'
$testsRoot = Split-Path -Parent $MyInvocation.MyCommand.Path

$allTfms = @('net46', 'net47', 'net472', 'net48', 'net481',
             'net5.0-windows', 'net6.0-windows', 'net7.0-windows',
             'net8.0-windows', 'net9.0-windows', 'net10.0-windows')

$projectNames = @{
    'UnitTests'       = 'Bastion.Krypton.UnitTests'
    'FormsTests'      = 'Bastion.Krypton.FormsTests'
    'FormsTests.VB'   = 'Bastion.Krypton.FormsTests.VB'
    'FunctionalTests' = 'Bastion.Krypton.FunctionalTests'
    'StressTests'     = 'Bastion.Krypton.StressTests'
}

function Find-MSBuild {
    $vswhere = Join-Path ${env:ProgramFiles(x86)} 'Microsoft Visual Studio\Installer\vswhere.exe'
    if (-not (Test-Path $vswhere)) { throw "vswhere.exe not found at $vswhere — is Visual Studio installed?" }
    $msbuild = & $vswhere -latest -requires Microsoft.Component.MSBuild -find 'MSBuild\**\Bin\MSBuild.exe' |
        Select-Object -First 1
    if (-not $msbuild) { throw 'Desktop MSBuild not found via vswhere.' }
    return $msbuild
}

function Get-ProjectFile([string]$projectKey) {
    $name = $projectNames[$projectKey]
    $dir = Join-Path $testsRoot $name
    $file = Get-ChildItem -Path $dir -Filter "$name.*proj" | Select-Object -First 1
    if (-not $file) { throw "Project file for $projectKey not found under $dir" }
    return $file.FullName
}

$script:builtProjects = @{}
function Invoke-ProjectBuild([string]$projectKey, [string]$msbuild) {
    if ($script:builtProjects.ContainsKey($projectKey)) { return }
    $projFile = Get-ProjectFile $projectKey
    Write-Host "Building $projectKey (all TFMs, Release, desktop MSBuild)..." -ForegroundColor Cyan
    & $msbuild $projFile /restore /t:Build /p:Configuration=Release /nr:false /v:q /clp:ErrorsOnly |
        ForEach-Object { Write-Host $_ }
    if ($LASTEXITCODE -ne 0) { throw "Build failed for $projectKey (exit $LASTEXITCODE)." }
    $script:builtProjects[$projectKey] = $true
}

function Invoke-TestRun([string]$projectKey, [string]$tfm) {
    $name = $projectNames[$projectKey]
    $projFile = Get-ProjectFile $projectKey
    $artefacts = Join-Path $testsRoot "artifacts\$projectKey\$tfm"
    New-Item -ItemType Directory -Force -Path $artefacts | Out-Null
    $env:BASTION_TEST_ARTIFACTS = Join-Path $artefacts 'screenshots'

    Write-Host "Running $projectKey on $tfm (category: $Category) ..." -ForegroundColor Cyan
    $stopwatch = [System.Diagnostics.Stopwatch]::StartNew()
    $total = ''; $passed = ''; $failed = ''

    try {
        $nunitLiteTfms = @('net46', 'net5.0-windows', 'net6.0-windows', 'net7.0-windows')
        if ($tfm -in $nunitLiteTfms) {
            # NUnitLite runner mechanism: net46 (dotnet-test floor is net462) and net5/6/7
            # (dotnet test's testhost launches via the SYSTEM muxer, which cannot see the
            # private legacy runtimes — the NUnitLite exe runs on the TRUE runtime instead).
            $resultFile = Join-Path $artefacts 'TestResult.xml'
            # Category selection (spec §6.3): NUnitLite test-selection-language filter.
            $nunitArgs = @('--result', $resultFile, '--work', $artefacts)
            switch ($Category) {
                'Default'   { $nunitArgs += @('--where', 'cat != Endurance') }
                'Endurance' { $nunitArgs += @('--where', 'cat == Endurance') }
            }
            # Route runner stdout through Write-Host so it does not pollute the function's
            # pipeline output (the returned summary object must be the only pipeline item).
            if ($tfm -eq 'net46') {
                $exe = Join-Path $testsRoot "$name\bin\Release\net46\$name.exe"
                if (-not (Test-Path $exe)) { throw "net46 NUnitLite runner not found: $exe (build first)." }
                & $exe @nunitArgs | ForEach-Object { Write-Host $_ }
            }
            else {
                $legacyDotnet = 'D:\Krypton-Ultimate\Tools\dotnet-legacy\dotnet.exe'
                $dll = Join-Path $testsRoot "$name\bin\Release\$tfm\$name.dll"
                if (-not (Test-Path $dll)) { throw "$tfm NUnitLite runner not found: $dll (build first)." }
                & $legacyDotnet exec $dll @nunitArgs | ForEach-Object { Write-Host $_ }
            }
            $exit = $LASTEXITCODE
            if (Test-Path $resultFile) {
                $xml = [xml](Get-Content $resultFile)
                $total = $xml.'test-run'.total
                $passed = $xml.'test-run'.passed
                $failed = $xml.'test-run'.failed
            }
        }
        else {
            $resultFile = Join-Path $artefacts 'results.trx'
            if (Test-Path $resultFile) { Remove-Item $resultFile -Force }
            # Category selection (spec §6.3): VSTest TestCategory filter.
            $dotnetArgs = @('test', $projFile, '-f', $tfm, '-c', 'Release', '--no-build',
                            '--logger', 'trx;LogFileName=results.trx', '--results-directory', $artefacts)
            switch ($Category) {
                'Default'   { $dotnetArgs += @('--filter', 'TestCategory!=Endurance') }
                'Endurance' { $dotnetArgs += @('--filter', 'TestCategory=Endurance') }
            }
            dotnet @dotnetArgs | ForEach-Object { Write-Host $_ }
            $exit = $LASTEXITCODE
            if (Test-Path $resultFile) {
                $trx = [xml](Get-Content $resultFile)
                $counters = $trx.TestRun.ResultSummary.Counters
                $total = $counters.total
                $passed = $counters.passed
                $failed = $counters.failed
            }
        }
    }
    finally {
        Remove-Item Env:\BASTION_TEST_ARTIFACTS -ErrorAction SilentlyContinue
    }

    $stopwatch.Stop()
    return [pscustomobject]@{
        Project  = $projectKey
        Tfm      = $tfm
        Result   = if ($exit -eq 0) { 'PASS' } else { 'FAIL' }
        Total    = $total
        Passed   = $passed
        Failed   = $failed
        Duration = '{0:mm\:ss\.f}' -f $stopwatch.Elapsed
        ExitCode = $exit
    }
}

$msbuildPath = $null
if (-not $NoBuild) { $msbuildPath = Find-MSBuild }

$runs = @()
if ($All) {
    # Functional sweep: the three functional projects across all 11 TFMs (spec §6.4).
    foreach ($projectKey in @('UnitTests', 'FormsTests', 'FormsTests.VB', 'FunctionalTests')) {
        if (-not $NoBuild) { Invoke-ProjectBuild $projectKey $msbuildPath }
        foreach ($tfm in $allTfms) {
            $runs += Invoke-TestRun $projectKey $tfm
        }
    }
}
else {
    if (-not $NoBuild) { Invoke-ProjectBuild $Project $msbuildPath }
    $runs += Invoke-TestRun $Project $Tfm
}

Write-Host ''
Write-Host '=== Test run summary ===' -ForegroundColor Cyan
$runs | Format-Table Project, Tfm, Result, Total, Passed, Failed, Duration -AutoSize | Out-String | Write-Host

$failures = @($runs | Where-Object { $_.ExitCode -ne 0 })
if ($failures.Count -gt 0) {
    Write-Host "$($failures.Count) run(s) FAILED." -ForegroundColor Red
    exit 1
}
Write-Host 'All runs passed.' -ForegroundColor Green
exit 0
