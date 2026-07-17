#region BSD License
/*
 * New (Bastion) file in a work derived from BSD-3-Clause licensed code:
 * © Component Factory Pty Ltd, 2006 - 2016. Then modifications by Peter Wagner (aka Wagnerp),
 * Simon Coghlan (aka Smurf-IV), Giduac, Ahmed Abdelhameed, Lesandro & tobitege et al. 2017 - 2026.
 * © Bastion Software Solutions Ltd 2026. All rights reserved.
 */
#endregion

#if NET46
using System.Runtime.InteropServices;

namespace Krypton.Toolkit;

/// <summary>
/// Compatibility shims for the net46 target only.
/// <c>Control.DeviceDpi</c> was introduced in .NET Framework 4.6.2; this extension
/// property supplies the window's DPI (system DPI on net46, which predates the
/// per-monitor-v2 WinForms support) so shared code compiles unchanged.
/// </summary>
internal static class Net46ControlCompat
{
    extension(Control control)
    {
        /// <summary>Gets the DPI of the display where the control is being shown (system DPI on net46).</summary>
        public int DeviceDpi
        {
            get
            {
                IntPtr hdc = GetDC(IntPtr.Zero);
                if (hdc != IntPtr.Zero)
                {
                    try
                    {
                        return GetDeviceCaps(hdc, LOGPIXELSY);
                    }
                    finally
                    {
                        ReleaseDC(IntPtr.Zero, hdc);
                    }
                }

                using Graphics graphics = Graphics.FromHwnd(IntPtr.Zero);
                return (int)graphics.DpiY;
            }
        }
    }

    private const int LOGPIXELSY = 90;

    [DllImport(@"user32.dll")]
    private static extern IntPtr GetDC(IntPtr hWnd);

    [DllImport(@"user32.dll")]
    private static extern int ReleaseDC(IntPtr hWnd, IntPtr hDC);

    [DllImport(@"gdi32.dll")]
    private static extern int GetDeviceCaps(IntPtr hdc, int nIndex);
}
#endif
