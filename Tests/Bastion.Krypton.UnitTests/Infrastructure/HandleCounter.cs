#region BSD License
/*
 * New (Bastion) file in a work derived from BSD-3-Clause licensed code:
 * © Component Factory Pty Ltd, 2006 - 2016. Then modifications by Peter Wagner (aka Wagnerp),
 * Simon Coghlan (aka Smurf-IV), Giduac, Ahmed Abdelhameed, Lesandro & tobitege et al. 2017 - 2026.
 * © Bastion Software Solutions Ltd 2026. All rights reserved.
 */
#endregion

using System;
using System.Runtime.InteropServices;

using NUnit.Framework;

namespace Bastion.Krypton.UnitTests.Infrastructure
{
    /// <summary>A point-in-time GDI/USER handle count for the current process.</summary>
    public readonly struct HandleSnapshot
    {
        /// <summary>Initialises a new snapshot.</summary>
        /// <param name="gdiHandles">GDI object count.</param>
        /// <param name="userHandles">USER object count.</param>
        public HandleSnapshot(uint gdiHandles, uint userHandles)
        {
            GdiHandles = gdiHandles;
            UserHandles = userHandles;
        }

        /// <summary>Gets the GDI object count.</summary>
        public uint GdiHandles { get; }

        /// <summary>Gets the USER object count.</summary>
        public uint UserHandles { get; }

        /// <inheritdoc />
        public override string ToString() => $"GDI={GdiHandles}, USER={UserHandles}";
    }

    /// <summary>
    /// Counts the current process's GDI and USER handles via <c>GetGuiResources</c>
    /// (spec §6.2: "assert no leaked handles (GDI/User handle counts before/after)").
    /// </summary>
    public static class HandleCounter
    {
        private const uint GR_GDIOBJECTS = 0;
        private const uint GR_USEROBJECTS = 1;

        [DllImport("user32.dll", ExactSpelling = true)]
        private static extern uint GetGuiResources(IntPtr hProcess, uint uiFlags);

        [DllImport("kernel32.dll", ExactSpelling = true)]
        private static extern IntPtr GetCurrentProcess();

        /// <summary>Takes a GDI/USER handle-count snapshot for the current process.</summary>
        public static HandleSnapshot Snapshot()
        {
            IntPtr process = GetCurrentProcess();
            return new HandleSnapshot(
                GetGuiResources(process, GR_GDIOBJECTS),
                GetGuiResources(process, GR_USEROBJECTS));
        }

        /// <summary>
        /// Asserts that the current handle counts have not grown beyond
        /// <paramref name="before"/> plus the given slack. A small slack absorbs one-off
        /// framework/theme caches (fonts, brushes, image lists) that are not leaks; genuine
        /// per-control leaks grow far beyond it.
        /// </summary>
        /// <param name="before">Baseline snapshot taken before the operation under test.</param>
        /// <param name="gdiSlack">Permitted GDI handle growth.</param>
        /// <param name="userSlack">Permitted USER handle growth.</param>
        public static void AssertStable(HandleSnapshot before, int gdiSlack = 32, int userSlack = 32)
        {
            HandleSnapshot after = Snapshot();
            Assert.Multiple(() =>
            {
                Assert.That((long)after.GdiHandles, Is.LessThanOrEqualTo((long)before.GdiHandles + gdiSlack),
                    $"GDI handle growth exceeds slack ({before} -> {after}).");
                Assert.That((long)after.UserHandles, Is.LessThanOrEqualTo((long)before.UserHandles + userSlack),
                    $"USER handle growth exceeds slack ({before} -> {after}).");
            });
        }
    }
}
