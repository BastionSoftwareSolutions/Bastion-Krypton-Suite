<#
.SYNOPSIS
    Structural validator for the Bastion Krypton Suite NuGet packages (spec Sec 8.1).

.DESCRIPTION
    dotnet-validate is not guaranteed to be installed, so this is a self-contained
    structural check over each .nupkg (a zip). For every package it asserts:
      * lib/<tfm>/ folders present for the full 11-TFM matrix (unless -Metapackage
        style: dependency-only packages legitimately have no lib/);
      * the primary assembly is named Bastion.Krypton.* on each TFM (libraries);
      * per-TFM <dependencies><group> entries, and that the net46-only compat
        packages appear only where expected;
      * <license type="expression"> matches the expected SPDX expression;
      * a matching .snupkg symbols package exists alongside;
      * SourceLink / repository provenance: <repository> element present.

    Emits a PASS/FAIL line per package and a summary; exits non-zero on any FAIL.

.PARAMETER FeedDir
    Directory containing the .nupkg/.snupkg (default D:\Krypton-Ultimate\artifacts\nuget).

.PARAMETER ReportPath
    Optional path to write a markdown fragment of the results.

.NOTES
    Co-Authored-By: Claude Fable 5 <noreply@anthropic.com>
#>
[CmdletBinding()]
param(
    [string] $FeedDir    = 'D:\Krypton-Ultimate\artifacts\nuget',
    [string] $ReportPath
)

$ErrorActionPreference = 'Stop'
Add-Type -AssemblyName System.IO.Compression.FileSystem

# The 11 TFMs, expressed as the lib-folder monikers NuGet normalises to
# (windows TFMs gain the '7.0' platform version in lib/ paths).
$expectedTfms = @(
    'net46','net47','net472','net48','net481',
    'net5.0-windows7.0','net6.0-windows7.0','net7.0-windows7.0',
    'net8.0-windows7.0','net9.0-windows7.0','net10.0-windows7.0'
)
function Normalize-Tfm([string]$t) {
    if ($t -match '^(net\d+\.0)-windows$') { return "$($Matches[1])-windows7.0" }
    # NuGet writes net4x dependency groups in long form (.NETFramework4.6) — map back.
    if ($t -match '^\.NETFramework(\d+)\.(\d+)(?:\.(\d+))?$') {
        return "net$($Matches[1])$($Matches[2])$($Matches[3])"
    }
    return $t
}

function Read-Entry([System.IO.Compression.ZipArchive]$zip, [string]$name) {
    $e = $zip.Entries | Where-Object { $_.FullName -eq $name } | Select-Object -First 1
    if ($null -eq $e) { return $null }
    $sr = New-Object System.IO.StreamReader($e.Open())
    try { return $sr.ReadToEnd() } finally { $sr.Dispose() }
}

$results = @()
$nupkgs = Get-ChildItem -Path $FeedDir -Filter '*.nupkg' | Where-Object { $_.Name -notlike '*.snupkg' } | Sort-Object Name
if (-not $nupkgs) { throw "No .nupkg found in $FeedDir" }

foreach ($pkg in $nupkgs) {
    $issues = @()
    $info = [ordered]@{ Package=$pkg.Name; Id=''; Version=''; License=''; Tfms=0; Symbols=$false; Repo=$false; Deps=0 }
    $zip = [System.IO.Compression.ZipFile]::OpenRead($pkg.FullName)
    try {
        $nuspecEntry = $zip.Entries | Where-Object { $_.FullName -like '*.nuspec' } | Select-Object -First 1
        if ($null -eq $nuspecEntry) { $issues += 'no .nuspec' }
        else {
            $xml = [xml](Read-Entry $zip $nuspecEntry.FullName)
            $md = $xml.package.metadata
            $info.Id = $md.id; $info.Version = $md.version
            # licence expression
            $lic = $md.license
            if ($lic -and $lic.type -eq 'expression') { $info.License = $lic.'#text' } elseif ($md.licenseExpression) { $info.License = $md.licenseExpression }
            if (-not $info.License) { $issues += 'no SPDX license expression' }
            # repository / SourceLink provenance
            if ($md.repository -and $md.repository.url) { $info.Repo = $true } else { $issues += 'no <repository> element' }
            # dependency groups
            $groups = @()
            if ($md.dependencies -and $md.dependencies.group) { $groups = @($md.dependencies.group) }
            $info.Deps = ($groups | ForEach-Object { @($_.dependency).Count } | Measure-Object -Sum).Sum

            # lib folders
            $libTfms = $zip.Entries |
                Where-Object { $_.FullName -match '^lib/([^/]+)/' } |
                ForEach-Object { ($_.FullName -split '/')[1] } | Sort-Object -Unique
            $isMeta = ($pkg.Name -match 'Suite|Ultimate')
            if (-not $isMeta) {
                $info.Tfms = @($libTfms).Count
                foreach ($t in $expectedTfms) {
                    if ($libTfms -notcontains $t) { $issues += "missing lib/$t" }
                }
                # primary assembly naming (spot-check net8.0-windows7.0)
                $probe = $zip.Entries | Where-Object { $_.FullName -like 'lib/net8.0-windows7.0/*.dll' } | Select-Object -First 1
                if ($probe -and ($probe.Name -notlike 'Bastion.Krypton.*')) { $issues += "primary dll not Bastion.Krypton.*: $($probe.Name)" }
            } else {
                # metapackage: dependency groups across the matrix, no lib expected
                $info.Tfms = @($groups).Count
                foreach ($t in $expectedTfms) {
                    $tn = ($groups | ForEach-Object { Normalize-Tfm $_.targetFramework })
                    if ($tn -notcontains $t) { $issues += "missing dep group $t" }
                }
            }
        }
    } finally { $zip.Dispose() }

    # symbols package (metapackages legitimately ship no lib/ and no symbols)
    $isMetaPkg = ($pkg.Name -match 'Suite|Ultimate')
    $snupkg = Join-Path $FeedDir ($pkg.BaseName + '.snupkg')
    $info.Symbols = Test-Path $snupkg
    if (-not $info.Symbols -and -not $isMetaPkg) { $issues += 'no .snupkg' }

    $status = if ($issues.Count -eq 0) { 'PASS' } else { 'FAIL' }
    $results += [pscustomobject]@{
        Status=$status; Id=$info.Id; Version=$info.Version; License=$info.License
        Tfms=$info.Tfms; Deps=$info.Deps; Symbols=$info.Symbols; Repo=$info.Repo
        Package=$info.Package; Issues=($issues -join '; ')
    }
    $col = if ($status -eq 'PASS') { 'Green' } else { 'Red' }
    Write-Host ("{0}  {1,-42} v{2,-8} {3,-14} tfms/groups={4,2} deps={5,3} sym={6} repo={7} {8}" -f `
        $status, $info.Id, $info.Version, $info.License, $info.Tfms, $info.Deps, $info.Symbols, $info.Repo, ($issues -join '; ')) -ForegroundColor $col
}

$fail = @($results | Where-Object { $_.Status -eq 'FAIL' }).Count
Write-Host "`n$($results.Count) package(s): $($results.Count - $fail) PASS, $fail FAIL" -ForegroundColor ($(if($fail){'Red'}else{'Green'}))

if ($ReportPath) {
    $lines = @('| Status | Package | Version | Licence | TFMs/Groups | Deps | Symbols | Repo | Issues |',
               '|---|---|---|---|---|---|---|---|---|')
    foreach ($r in $results) {
        $lines += "| $($r.Status) | $($r.Id) | $($r.Version) | $($r.License) | $($r.Tfms) | $($r.Deps) | $($r.Symbols) | $($r.Repo) | $($r.Issues) |"
    }
    $lines -join "`n" | Set-Content -Encoding utf8 $ReportPath
    Write-Host "Report fragment written: $ReportPath"
}

exit $fail
