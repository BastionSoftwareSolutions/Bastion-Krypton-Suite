#region BSD License
/*
 * New (Bastion) file in a work derived from BSD-3-Clause licensed code:
 * Â© Component Factory Pty Ltd, 2006 - 2016. Then modifications by Peter Wagner (aka Wagnerp),
 * Simon Coghlan (aka Smurf-IV), Giduac, Ahmed Abdelhameed, Lesandro & tobitege et al. 2017 - 2026.
 * Â© Bastion Software Solutions Ltd 2026. All rights reserved.
 */
#endregion

using System;
using System.Collections.Generic;

namespace Bastion.Krypton.StressTests
{
    /// <summary>
    /// The adversarial suite's explicit skip-list (spec Â§6.3 rule inherited from Â§6.2: every
    /// exclusion carries a written justification). An entry matches when its type name equals
    /// the runtime type of the control under attack or any of its base types, so one entry can
    /// cover a whole derived family. Attack stages are the stage names used by the fixtures
    /// ("text", "size", "padding", "font", "null", "dispose-mid-paint", ...); "*" covers all.
    /// </summary>
    public static class AdversarialPolicy
    {
        private readonly struct SkipRule
        {
            public SkipRule(string typeName, string stage, string justification)
            {
                TypeName = typeName;
                Stage = stage;
                Justification = justification;
            }

            public string TypeName { get; }
            public string Stage { get; }
            public string Justification { get; }
        }

        private static readonly SkipRule[] Skips =
        {
            // BREAKAGE-LOG Phase 5b F4: the framework DataGridViewTextBoxEditingControl base
            // (System.Windows.Forms) dereferences the (null) hosting grid in OnTextChanged on
            // .NET Framework when the editing control is used standalone. Framework-side NRE,
            // not Krypton; the control only ever lives inside a grid. Same justification and
            // scope as the 5b skip; .NET 8 WinForms guards the path but the skip is kept
            // TFM-uniform so the attack surface is identical across the matrix.
            new SkipRule("DataGridViewTextBoxEditingControl", "text",
                "Framework editing control requires a hosting DataGridView; standalone Text mutation raises a framework-side (not Krypton) OnTextChanged NRE on .NET Framework. See BREAKAGE-LOG Phase 5b F4."),

            // KryptonToolkitPoweredByControl is a dock-filled composite of AutoSize
            // KryptonWrapLabels inside a TableLayoutPanel: an int.MaxValue size hands the
            // framework text-measure pass a ~2-billion-pixel wrap constraint and the layout
            // takes ~90 s (bounded â€” it completes; no hang), which crosses the per-control
            // watchdog on net46's slower GDI path. FIXME: OPEN in BREAKAGE-LOG Phase 5c A9 â€”
            // clamping the wrap-measure constraint in KryptonWrapLabel is an upstream-facing
            // design call.
            new SkipRule("KryptonToolkitPoweredByControl", "size",
                "Extreme sizes are laid out correctly but pathologically slowly (~90 s bounded framework wrap-measure at int.MaxValue) â€” exceeds the net46 watchdog. FIXME: OPEN, BREAKAGE-LOG Phase 5c A9."),

            // WebBrowserBase-derived (KryptonWebBrowser): the native ActiveX surface owns
            // Text/Font/RightToLeft and the managed wrappers throw NotSupportedException by
            // design â€” already covered by the graceful-rejection rule â€” but Size/Font attacks
            // additionally re-activate the out-of-process ActiveX host, which under rapid
            // mutation can raise COMExceptions from the native side that say nothing about
            // Krypton. The wrapper is framework plumbing, not Krypton paint code.
            new SkipRule("WebBrowserBase", "*",
                "Native out-of-process ActiveX host: mutations exercise the framework/COM interop wrapper, not Krypton code; native COMExceptions under rapid mutation are not Krypton findings."),
        };

        /// <summary>Should this attack stage skip this control type? (Justification returned.)</summary>
        public static bool Skip(Type controlType, string stage, out string reason)
        {
            foreach (SkipRule rule in Skips)
            {
                if ((rule.Stage == "*" || string.Equals(rule.Stage, stage, StringComparison.Ordinal)) &&
                    TypeNameMatches(controlType, rule.TypeName))
                {
                    reason = rule.Justification;
                    return true;
                }
            }

            reason = string.Empty;
            return false;
        }

        private static bool TypeNameMatches(Type type, string name)
        {
            for (Type? t = type; t != null && t != typeof(object); t = t.BaseType)
            {
                if (string.Equals(t.Name, name, StringComparison.Ordinal))
                {
                    return true;
                }
            }

            return false;
        }
    }
}
