#region BSD License
/*
 * New (Bastion) file in a work derived from BSD-3-Clause licensed code:
 * © Component Factory Pty Ltd, 2006 - 2016. Then modifications by Peter Wagner (aka Wagnerp),
 * Simon Coghlan (aka Smurf-IV), Giduac, Ahmed Abdelhameed, Lesandro & tobitege et al. 2017 - 2026.
 * © Bastion Software Solutions Ltd 2026. All rights reserved.
 */
#endregion

using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Reflection;
using System.Windows.Forms;

namespace Bastion.Krypton.FunctionalTests
{
    /// <summary>How the recipe treats a catalogued type (spec §6.2 steps 2/3).</summary>
    public enum SweepKind
    {
        /// <summary>A control placed on a real shown KryptonForm — the full recipe.</summary>
        HostedControl,

        /// <summary>A Form-derived type — shown as its own top-level window, full recipe.</summary>
        TopLevelForm,

        /// <summary>
        /// Component-but-not-Control (or a control that cannot be parented/shown, e.g.
        /// ToolStripDropDown-derived): instantiate + dispose only, per spec §6.2 step 3.
        /// </summary>
        ComponentOnly
    }

    /// <summary>
    /// Reflects over the five core assemblies and classifies every public Component type for
    /// the functional sweep. Built once per process; consumed by NUnit TestCaseSource so every
    /// type is a separate test case (spec §6.2 preamble).
    /// </summary>
    public static class CoverageCatalogue
    {
        /// <summary>One catalogued type.</summary>
        public sealed class Entry
        {
            internal Entry(Type type, SweepKind kind, string note)
            {
                Type = type;
                Kind = kind;
                Note = note;
            }

            /// <summary>The public Component type.</summary>
            public Type Type { get; }

            /// <summary>How the recipe treats it.</summary>
            public SweepKind Kind { get; }

            /// <summary>Classification note (why ComponentOnly, etc.).</summary>
            public string Note { get; }
        }

        /// <summary>The five core assemblies, resolved through referenced anchor types.</summary>
        private static readonly Assembly[] CoreAssemblies =
        {
            typeof(global::Krypton.Toolkit.KryptonButton).Assembly,
            typeof(global::Krypton.Ribbon.KryptonRibbon).Assembly,
            typeof(global::Krypton.Navigator.KryptonNavigator).Assembly,
            typeof(global::Krypton.Workspace.KryptonWorkspace).Assembly,
            typeof(global::Krypton.Docking.KryptonDockingManager).Assembly
        };

        private static readonly Lazy<Catalogue> Built = new Lazy<Catalogue>(Build);

        private sealed class Catalogue
        {
            public List<Entry> Entries { get; } = new List<Entry>();
            public List<string> NoPublicCtor { get; } = new List<string>();
            public List<string> ObsoleteError { get; } = new List<string>();
        }

        /// <summary>All catalogued (instantiable) types.</summary>
        public static IReadOnlyList<Entry> Entries => Built.Value.Entries;

        /// <summary>
        /// Public Component types skipped because they have no public parameterless
        /// constructor (spec §6.2 step 1: "count them").
        /// </summary>
        public static IReadOnlyList<string> NoPublicCtorTypes => Built.Value.NoPublicCtor;

        /// <summary>Types skipped because they are [Obsolete(error: true)].</summary>
        public static IReadOnlyList<string> ObsoleteErrorTypes => Built.Value.ObsoleteError;

        /// <summary>Is this one of the five core assemblies?</summary>
        public static bool IsCoreAssembly(Assembly assembly) =>
            Array.IndexOf(CoreAssemblies, assembly) >= 0;

        private static Catalogue Build()
        {
            var catalogue = new Catalogue();

            foreach (Assembly assembly in CoreAssemblies)
            {
                foreach (Type type in assembly.GetExportedTypes()
                             .OrderBy(static t => t.FullName, StringComparer.Ordinal))
                {
                    if (!type.IsClass || type.IsAbstract || type.IsNested ||
                        type.ContainsGenericParameters ||
                        !typeof(Component).IsAssignableFrom(type))
                    {
                        continue;
                    }

                    if (type.GetConstructor(Type.EmptyTypes) == null)
                    {
                        // Step 1: skip types without a public parameterless ctor — counted.
                        catalogue.NoPublicCtor.Add(type.FullName!);
                        continue;
                    }

                    if (type.GetCustomAttribute<ObsoleteAttribute>() is { IsError: true })
                    {
                        catalogue.ObsoleteError.Add(type.FullName!);
                        continue;
                    }

                    catalogue.Entries.Add(Classify(type));
                }
            }

            return catalogue;
        }

        private static Entry Classify(Type type)
        {
            if (typeof(Form).IsAssignableFrom(type))
            {
                return new Entry(type, SweepKind.TopLevelForm, "Form-derived: shown as its own top-level window");
            }

            if (typeof(ToolStripDropDown).IsAssignableFrom(type))
            {
                return new Entry(type, SweepKind.ComponentOnly,
                    "ToolStripDropDown-derived: top-level control, cannot be parented to a form");
            }

            if (typeof(TabPage).IsAssignableFrom(type))
            {
                return new Entry(type, SweepKind.ComponentOnly,
                    "TabPage-derived: needs a TabControl parent");
            }

            if (typeof(Control).IsAssignableFrom(type))
            {
                return new Entry(type, SweepKind.HostedControl, "Control: full recipe on a shown KryptonForm");
            }

            return new Entry(type, SweepKind.ComponentOnly,
                "Component-but-not-Control: genuinely invisible, instantiate + dispose only (spec §6.2 step 3)");
        }
    }
}
