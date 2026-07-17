# © Bastion Software Solutions Ltd 2026. Phase 4d sample x TFM launch matrix (spec §5.5):
# launches every sample app (C# + VB) on every TFM to an idle message loop (alive 5 s),
# then kills it. Incremental: results append to a CSV; already-passed rows are skipped.
param(
    [string] $Configuration = 'Release',
    [int] $Parallel = 5,
    [int] $AliveSeconds = 5,
    [string] $ResultsCsv = "$PSScriptRoot\sample-matrix-results.csv"
)
$ErrorActionPreference = 'Continue'
$rel = Join-Path $PSScriptRoot "Binaries\Krypton Demos\$Configuration"
$legacyDotnet = 'D:\Krypton-Ultimate\Tools\dotnet-legacy\dotnet.exe'
$tfms = 'net46','net47','net472','net48','net481','net5.0-windows','net6.0-windows','net7.0-windows','net8.0-windows','net9.0-windows','net10.0-windows'
$legacyCore = 'net5.0-windows','net6.0-windows','net7.0-windows'

$done = @{}
if (Test-Path $ResultsCsv) {
    Import-Csv $ResultsCsv | Where-Object Result -eq 'PASS' | ForEach-Object { $done["$($_.Sample)|$($_.TFM)"] = $true }
} else {
    'Sample,TFM,Result,Detail' | Set-Content $ResultsCsv -Encoding utf8
}

$queue = [System.Collections.Generic.List[object]]::new()
foreach ($tfm in $tfms) {
    $dir = Join-Path $rel $tfm
    if (-not (Test-Path $dir)) { continue }
    foreach ($exe in Get-ChildItem $dir -Filter *.exe) {
        $name = $exe.BaseName
        if ($done.ContainsKey("$name|$tfm")) { continue }
        $queue.Add([pscustomobject]@{ Name = $name; TFM = $tfm; Exe = $exe.FullName; Dir = $dir })
    }
}
"queued: $($queue.Count) runs (skipped $($done.Count) prior passes)"

$active = @()
$results = [System.Collections.Generic.List[string]]::new()
function Start-Sample($item) {
    if ($item.TFM -in $script:legacyCore) {
        $dll = [System.IO.Path]::ChangeExtension($item.Exe, '.dll')
        $p = Start-Process -FilePath $script:legacyDotnet -ArgumentList "exec `"$dll`"" -WorkingDirectory $item.Dir -PassThru -WindowStyle Minimized
    } else {
        $p = Start-Process -FilePath $item.Exe -WorkingDirectory $item.Dir -PassThru -WindowStyle Minimized
    }
    [pscustomobject]@{ Item = $item; Proc = $p; Started = Get-Date }
}

$i = 0
while ($i -lt $queue.Count -or $active.Count -gt 0) {
    while ($active.Count -lt $Parallel -and $i -lt $queue.Count) {
        $active += Start-Sample $queue[$i]; $i++
    }
    Start-Sleep -Milliseconds 500
    $still = @()
    foreach ($a in $active) {
        $age = ((Get-Date) - $a.Started).TotalSeconds
        if ($a.Proc.HasExited) {
            $code = $a.Proc.ExitCode
            $verdict = if ($code -eq 0 -and $age -ge 1) { 'PASS' } else { 'FAIL' }
            $line = "`"$($a.Item.Name)`",$($a.Item.TFM),$verdict,exited=$code after $([int]$age)s"
            $results.Add($line); Add-Content $ResultsCsv $line -Encoding utf8
            if ($verdict -eq 'FAIL') { "FAIL $($a.Item.Name) [$($a.Item.TFM)] exit=$code t=$([int]$age)s" }
        } elseif ($age -ge $AliveSeconds) {
            try { $a.Proc.Kill($true) } catch { try { $a.Proc.Kill() } catch {} }
            $line = "`"$($a.Item.Name)`",$($a.Item.TFM),PASS,alive"
            $results.Add($line); Add-Content $ResultsCsv $line -Encoding utf8
        } else {
            $still += $a
        }
    }
    $active = $still
}

$fails = @($results | Where-Object { $_ -match ',FAIL,' })
""
"this run: $($results.Count) executed, $($fails.Count) failed"
$all = Import-Csv $ResultsCsv
$pass = @($all | Where-Object Result -eq 'PASS').Count
"cumulative: $pass PASS rows in $ResultsCsv"
if ($fails.Count -gt 0) { exit 1 } else { 'SAMPLE MATRIX RUN: chunk green' }
