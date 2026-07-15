# © Bastion Software Solutions Ltd 2026. Runs the smoke harness over every Extended-Toolkit
# module output directory, per TFM, on the true runtime for each TFM. Aggregates results.
$ErrorActionPreference = 'Continue'
$harnessBin = Join-Path $PSScriptRoot 'bin\Release'
$extBin = 'D:\Krypton-Ultimate\Extended-Toolkit\Bin\Release'
$legacyDotnet = 'D:\Krypton-Ultimate\Tools\dotnet-legacy\dotnet.exe'
$tfms = 'net46','net47','net472','net48','net481','net5.0-windows','net6.0-windows','net7.0-windows','net8.0-windows','net9.0-windows','net10.0-windows'
$failTable = @()
$ran = 0; $skipped = 0

foreach ($proj in Get-ChildItem $extBin -Directory | Where-Object Name -like 'Krypton.Toolkit.Suite.Extended.*') {
    foreach ($tfm in $tfms) {
        $dir = Join-Path $proj.FullName $tfm
        # The assembly name does not always match the directory name (e.g. the
        # Task.Dialogs directory carries Krypton.Toolkit.Suite.Extended.TaskDialogs.dll),
        # so probe for any Extended module assembly rather than the exact dir name.
        $dll = Join-Path $dir "$($proj.Name).dll"
        if (-not (Test-Path $dll)) {
            $dll = Get-ChildItem $dir -Filter 'Krypton.Toolkit.Suite.Extended.*.dll' -ErrorAction SilentlyContinue |
                Select-Object -First 1 -ExpandProperty FullName
        }
        if (-not $dll -or -not (Test-Path $dll)) { $skipped++; continue }
        $log = Join-Path $dir 'smoke.log'
        # Incremental: skip runs that already passed against the current binaries, so repeated
        # invocations converge on the remaining work.
        if ((Test-Path $log) -and (Get-Item $log).LastWriteTime -gt (Get-Item $dll).LastWriteTime) {
            $prev = Select-String -Path $log -Pattern '^Tested: \d+.*failures: 0' -Quiet
            if ($prev) { $ran++; continue }
        }
        if ($tfm -like 'net4*') {
            & (Join-Path $harnessBin "$tfm\KryptonSmokeTest.exe") --dir $dir *> $log
        } elseif ($tfm -in 'net5.0-windows','net6.0-windows','net7.0-windows') {
            & $legacyDotnet exec (Join-Path $harnessBin "$tfm\KryptonSmokeTest.dll") --dir $dir *> $log
        } else {
            & dotnet exec (Join-Path $harnessBin "$tfm\KryptonSmokeTest.dll") --dir $dir *> $log
        }
        $code = $LASTEXITCODE
        $ran++
        if ($code -ne 0) {
            $detail = (Select-String -Path $log -Pattern '^FAIL |^HUNG ' | Select-Object -First 3 -ExpandProperty Line) -join ' | '
            $failTable += [pscustomobject]@{ Module = $proj.Name; TFM = $tfm; Exit = $code; Detail = $detail }
            "FAIL {0} [{1}] exit={2}" -f $proj.Name, $tfm, $code
        }
    }
    "done: $($proj.Name)"
}

""
"Runs: $ran; skipped (no dll for TFM): $skipped; failing runs: $($failTable.Count)"
$failTable | Format-Table -AutoSize | Out-String -Width 300
if ($failTable.Count -gt 0) { exit 1 } else { "EXTENDED SMOKE: ALL GREEN" }
