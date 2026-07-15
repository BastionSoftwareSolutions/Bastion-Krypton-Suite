# © Bastion Software Solutions Ltd 2026. Runs the Krypton smoke test on every TFM,
# using the real runtime for each (installed .NET Framework for net4x; local legacy
# runtimes for net5/6/7; system dotnet for net8/9/10). Writes a summary table.
$ErrorActionPreference = 'Continue'
$bin = Join-Path $PSScriptRoot 'bin\Release'
$legacyDotnet = 'D:\Krypton-Ultimate\Tools\dotnet-legacy\dotnet.exe'
$results = @()

$tfms = 'net46','net47','net472','net48','net481','net5.0-windows','net6.0-windows','net7.0-windows','net8.0-windows','net9.0-windows','net10.0-windows'
foreach ($tfm in $tfms) {
    $dir = Join-Path $bin $tfm
    $log = Join-Path $dir 'smoke.log'
    if ($tfm -like 'net4*') {
        $exe = Join-Path $dir 'KryptonSmokeTest.exe'
        & $exe *> $log
    } elseif ($tfm -in 'net5.0-windows','net6.0-windows','net7.0-windows') {
        & $legacyDotnet exec (Join-Path $dir 'KryptonSmokeTest.dll') *> $log
    } else {
        & dotnet exec (Join-Path $dir 'KryptonSmokeTest.dll') *> $log
    }
    $code = $LASTEXITCODE
    $summary = (Select-String -Path $log -Pattern '^Tested:' | Select-Object -First 1).Line
    $results += [pscustomobject]@{ TFM = $tfm; ExitCode = $code; Summary = $summary }
    "{0,-18} exit={1}  {2}" -f $tfm, $code, $summary
}

$fail = @($results | Where-Object ExitCode -ne 0)
""
if ($fail.Count -eq 0) { "SMOKE MATRIX: ALL $($tfms.Count) TFMs PASS" } else { "SMOKE MATRIX: $($fail.Count) TFM(s) FAILED"; exit 1 }
