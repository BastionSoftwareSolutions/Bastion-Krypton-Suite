# Get-PixelColour.ps1 — Bastion Krypton Suite theme research eyedropper.
# Samples exact pixel colours from reference screenshots (PNG/JPEG).
#
# Usage:
#   # Sample individual points:
#   .\Get-PixelColour.ps1 -Image ref.png -Points "10,10; 200,15; 40,300"
#
#   # Modal colour of a rectangle (x,y,w,h) — robust against JPEG noise/gradients.
#   # Reports the most frequent colour, its share, and the min/max per channel:
#   .\Get-PixelColour.ps1 -Image ref.png -Rect "50,5,200,20"
#
#   # Scan a horizontal row (y) or vertical column (x) and report colour runs —
#   # useful for locating boundaries between UI regions:
#   .\Get-PixelColour.ps1 -Image ref.png -ScanRow 12
#   .\Get-PixelColour.ps1 -Image ref.png -ScanCol 30
#
# Output is text: "x,y  #RRGGBB  (r,g,b)" per point, or a modal summary per rect.

param(
    [Parameter(Mandatory = $true)][string]$Image,
    [string]$Points,
    [string]$Rect,
    [int]$ScanRow = -1,
    [int]$ScanCol = -1,
    [int]$MinRun = 4   # minimum run length reported by scans
)

Add-Type -AssemblyName System.Drawing

$path = (Resolve-Path $Image).Path
$bmp = New-Object System.Drawing.Bitmap($path)
try {
    Write-Output ("Image: {0}  ({1}x{2})" -f $path, $bmp.Width, $bmp.Height)

    function Format-Colour([System.Drawing.Color]$c) {
        "#{0:X2}{1:X2}{2:X2}  ({3},{4},{5})" -f $c.R, $c.G, $c.B, $c.R, $c.G, $c.B
    }

    if ($Points) {
        foreach ($pt in ($Points -split ';')) {
            $xy = $pt.Trim() -split ','
            $x = [int]$xy[0].Trim(); $y = [int]$xy[1].Trim()
            if ($x -ge $bmp.Width -or $y -ge $bmp.Height) {
                Write-Output ("{0},{1}  OUT OF RANGE" -f $x, $y); continue
            }
            $c = $bmp.GetPixel($x, $y)
            Write-Output ("{0},{1}  {2}" -f $x, $y, (Format-Colour $c))
        }
    }

    if ($Rect) {
        $r = ($Rect -split ',') | ForEach-Object { [int]$_.Trim() }
        $x0 = $r[0]; $y0 = $r[1]; $w = $r[2]; $h = $r[3]
        $x1 = [Math]::Min($x0 + $w, $bmp.Width) - 1
        $y1 = [Math]::Min($y0 + $h, $bmp.Height) - 1
        $counts = @{}
        $minR = 255; $minG = 255; $minB = 255; $maxR = 0; $maxG = 0; $maxB = 0
        $n = 0
        for ($y = $y0; $y -le $y1; $y++) {
            for ($x = $x0; $x -le $x1; $x++) {
                $c = $bmp.GetPixel($x, $y)
                $key = "#{0:X2}{1:X2}{2:X2}" -f $c.R, $c.G, $c.B
                if ($counts.ContainsKey($key)) { $counts[$key]++ } else { $counts[$key] = 1 }
                if ($c.R -lt $minR) { $minR = $c.R }; if ($c.R -gt $maxR) { $maxR = $c.R }
                if ($c.G -lt $minG) { $minG = $c.G }; if ($c.G -gt $maxG) { $maxG = $c.G }
                if ($c.B -lt $minB) { $minB = $c.B }; if ($c.B -gt $maxB) { $maxB = $c.B }
                $n++
            }
        }
        Write-Output ("Rect {0},{1} {2}x{3}  ({4} px, {5} distinct colours)" -f $x0, $y0, $w, $h, $n, $counts.Count)
        $top = $counts.GetEnumerator() | Sort-Object Value -Descending | Select-Object -First 5
        foreach ($e in $top) {
            Write-Output ("  {0}  x{1}  ({2:P1})" -f $e.Key, $e.Value, ($e.Value / $n))
        }
        Write-Output ("  channel range: R {0}-{1}  G {2}-{3}  B {4}-{5}" -f $minR, $maxR, $minG, $maxG, $minB, $maxB)
    }

    if ($ScanRow -ge 0 -or $ScanCol -ge 0) {
        $run = $null; $runStart = 0; $runLen = 0
        $limit = if ($ScanRow -ge 0) { $bmp.Width } else { $bmp.Height }
        $emit = {
            param($key, $start, $len)
            if ($len -ge $MinRun) { Write-Output ("  {0}..{1}  ({2} px)  {3}" -f $start, ($start + $len - 1), $len, $key) }
        }
        if ($ScanRow -ge 0) { Write-Output ("Row y={0}:" -f $ScanRow) } else { Write-Output ("Col x={0}:" -f $ScanCol) }
        for ($i = 0; $i -lt $limit; $i++) {
            $c = if ($ScanRow -ge 0) { $bmp.GetPixel($i, $ScanRow) } else { $bmp.GetPixel($ScanCol, $i) }
            $key = "#{0:X2}{1:X2}{2:X2}" -f $c.R, $c.G, $c.B
            if ($key -eq $run) { $runLen++ }
            else {
                if ($run) { & $emit $run $runStart $runLen }
                $run = $key; $runStart = $i; $runLen = 1
            }
        }
        if ($run) { & $emit $run $runStart $runLen }
    }
}
finally {
    $bmp.Dispose()
}
