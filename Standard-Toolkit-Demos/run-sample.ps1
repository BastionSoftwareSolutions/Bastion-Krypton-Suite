<#
.SYNOPSIS
    Builds and launches any Krypton demo sample on any of the eleven Bastion target frameworks.

.DESCRIPTION
    BSD 3-Clause License.
    New (Bastion) file in a work derived from BSD-3-Clause licensed code:
    (c) Component Factory Pty Ltd, 2006 - 2016. Then modifications by Peter Wagner (aka Wagnerp),
    Simon Coghlan (aka Smurf-IV), et al. 2017 - 2026.
    (c) Bastion Software Solutions Ltd 2026. All rights reserved.

    Uses the SampleTfm switch declared in Directory.Build.props to collapse the sample to a
    single target framework, builds it with desktop MSBuild against the sibling
    Standard-Toolkit source tree (Dev flavour, ProjectReference), then launches it:
      - net4x        : the built .exe directly
      - net5/net6/net7 : via the archived runtime host at Tools\dotnet-legacy\dotnet.exe
      - net8+        : via the system dotnet host

.EXAMPLE
    .\run-sample.ps1 -List
    .\run-sample.ps1 -Sample "Docking Persistence" -Tfm net6.0-windows
    .\run-sample.ps1 -Sample "KryptonButton Examples" -Tfm net46 -Configuration Release
#>
[CmdletBinding(DefaultParameterSetName = 'Run')]
param(
    [Parameter(ParameterSetName = 'Run', Mandatory = $true, Position = 0)]
    [string] $Sample,

    [Parameter(ParameterSetName = 'Run', Position = 1)]
    [ValidateSet('net46', 'net47', 'net472', 'net48', 'net481',
                 'net5.0-windows', 'net6.0-windows', 'net7.0-windows',
                 'net8.0-windows', 'net9.0-windows', 'net10.0-windows')]
    [string] $Tfm = 'net10.0-windows',

    [Parameter(ParameterSetName = 'Run')]
    [ValidateSet('Debug', 'Release')]
    [string] $Configuration = 'Debug',

    [Parameter(ParameterSetName = 'Run')]
    [switch] $NoLaunch,

    [Parameter(ParameterSetName = 'List', Mandatory = $true)]
    [switch] $List
)

$ErrorActionPreference = 'Stop'
$repoRoot = $PSScriptRoot
$sourceRoot = Join-Path $repoRoot 'Source'
$legacyDotnet = 'D:\Krypton-Ultimate\Tools\dotnet-legacy\dotnet.exe'

function Get-SampleProjects {
    Get-ChildItem -Path $sourceRoot -Recurse -Filter *.csproj |
        Where-Object { $_.FullName -notlike '*\WixInstaller\*' } |
        Sort-Object { $_.Directory.Name }
}

if ($List) {
    Get-SampleProjects | ForEach-Object { $_.Directory.Name }
    return
}

# Locate the sample by its folder name (exact match first, then unambiguous prefix).
$projects = Get-SampleProjects
$project = $projects | Where-Object { $_.Directory.Name -eq $Sample }
if (-not $project) {
    $project = @($projects | Where-Object { $_.Directory.Name -like "$Sample*" })
    if ($project.Count -gt 1) {
        Write-Error ("Sample name '$Sample' is ambiguous: " + (($project | ForEach-Object { $_.Directory.Name }) -join ', '))
    }
    if ($project.Count -eq 0) {
        Write-Error "No sample named '$Sample'. Use -List to enumerate sample names."
    }
    $project = $project[0]
}

# Find desktop MSBuild (VS 18, then VS 2022, then vswhere).
$msbuildCandidates = @(
    "$env:ProgramFiles\Microsoft Visual Studio\18\Community\MSBuild\Current\Bin\MSBuild.exe",
    "$env:ProgramFiles\Microsoft Visual Studio\18\Professional\MSBuild\Current\Bin\MSBuild.exe",
    "$env:ProgramFiles\Microsoft Visual Studio\18\Enterprise\MSBuild\Current\Bin\MSBuild.exe",
    "$env:ProgramFiles\Microsoft Visual Studio\2022\Community\MSBuild\Current\Bin\MSBuild.exe",
    "$env:ProgramFiles\Microsoft Visual Studio\2022\Professional\MSBuild\Current\Bin\MSBuild.exe",
    "$env:ProgramFiles\Microsoft Visual Studio\2022\Enterprise\MSBuild\Current\Bin\MSBuild.exe"
)
$msbuild = $msbuildCandidates | Where-Object { Test-Path $_ } | Select-Object -First 1
if (-not $msbuild) {
    $vswhere = "${env:ProgramFiles(x86)}\Microsoft Visual Studio\Installer\vswhere.exe"
    if (Test-Path $vswhere) {
        $msbuild = & $vswhere -latest -requires Microsoft.Component.MSBuild -find MSBuild\**\Bin\MSBuild.exe | Select-Object -First 1
    }
}
if (-not $msbuild) {
    Write-Error 'Desktop MSBuild (Visual Studio 2022/18) not found. It is required for the net46 target.'
}

Write-Host "Sample : $($project.Directory.Name)" -ForegroundColor Cyan
Write-Host "Project: $($project.FullName)"
Write-Host "TFM    : $Tfm ($Configuration)"

# Build (restore included) with the single-TFM switch from Directory.Build.props.
& $msbuild $project.FullName /restore "/p:SampleTfm=$Tfm" "/p:Configuration=$Configuration" /m /nr:false /v:m /nologo /clp:'Summary;ErrorsOnly'
if ($LASTEXITCODE -ne 0) {
    Write-Error "Build failed for '$($project.Directory.Name)' ($Tfm). See output above."
}

# Resolve the output binary: every sample's OutputPath is <repo root>\Binaries\Krypton Demos\<Configuration>\<TFM>\.
[xml] $projXml = Get-Content $project.FullName
$assemblyName = ($projXml.Project.PropertyGroup.AssemblyName | Where-Object { $_ } | Select-Object -First 1)
if (-not $assemblyName) { $assemblyName = [IO.Path]::GetFileNameWithoutExtension($project.Name) }
$binDir = Join-Path $repoRoot "Binaries\Krypton Demos\$Configuration\$Tfm"
$exePath = Join-Path $binDir "$assemblyName.exe"
$dllPath = Join-Path $binDir "$assemblyName.dll"
if (-not (Test-Path $exePath)) {
    Write-Error "Built binary not found: $exePath"
}
Write-Host "Binary : $exePath"

if ($NoLaunch) { return }

# Launch on the runtime that matches the TFM.
if ($Tfm -match '^net4') {
    $process = Start-Process -FilePath $exePath -WorkingDirectory $binDir -PassThru
}
elseif ($Tfm -in @('net5.0-windows', 'net6.0-windows', 'net7.0-windows')) {
    if (-not (Test-Path $legacyDotnet)) {
        Write-Error "Legacy runtime host not found at $legacyDotnet (required for $Tfm)."
    }
    $process = Start-Process -FilePath $legacyDotnet -ArgumentList "`"$dllPath`"" -WorkingDirectory $binDir -PassThru
}
else {
    $process = Start-Process -FilePath 'dotnet' -ArgumentList "`"$dllPath`"" -WorkingDirectory $binDir -PassThru
}

Write-Host "Launched PID $($process.Id) on $Tfm." -ForegroundColor Green
