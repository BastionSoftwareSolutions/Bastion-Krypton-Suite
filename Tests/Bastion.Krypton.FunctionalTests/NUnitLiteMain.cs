#region BSD License
/*
 * New (Bastion) file in a work derived from BSD-3-Clause licensed code:
 * © Component Factory Pty Ltd, 2006 - 2016. Then modifications by Peter Wagner (aka Wagnerp),
 * Simon Coghlan (aka Smurf-IV), Giduac, Ahmed Abdelhameed, Lesandro & tobitege et al. 2017 - 2026.
 * © Bastion Software Solutions Ltd 2026. All rights reserved.
 */
#endregion

using System;
using System.Reflection;

namespace Bastion.Krypton.FunctionalTests
{
    /// <summary>
    /// net46 entry point only. The dotnet-test tooling floor is net462, so on net46 this
    /// assembly is built as a self-executing NUnitLite console runner instead
    /// (framework decision: Tests\README.md). Exit code is the number of failed tests.
    /// </summary>
    public static class NUnitLiteMain
    {
        [STAThread]
        public static int Main(string[] args) =>
            new NUnitLite.AutoRun(typeof(NUnitLiteMain).GetTypeInfo().Assembly).Execute(args);
    }
}
