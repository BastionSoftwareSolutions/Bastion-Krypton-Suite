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
using System.Reflection;

namespace Bastion.Krypton.FunctionalTests
{
    /// <summary>
    /// The explicit allow/skip/deny lists of spec §6.2, every entry with a written
    /// justification. Three lists:
    /// <list type="bullet">
    /// <item><b>Property skip-list</b> — properties never set by the sweep (designer context,
    /// interop plumbing, data-dependent semantics, test-topology hazards).</item>
    /// <item><b>Method deny-list</b> — methods never invoked (dispose family, modal UI,
    /// visibility ordering hazards, machine-global side effects).</item>
    /// <item><b>Blank-by-design allow-list</b> — controls whose default render is legitimately
    /// a single uniform colour (or cannot be captured by DrawToBitmap at all): the render
    /// check asserts "no exception" instead of non-blankness for these.</item>
    /// </list>
    /// A list entry matches when its type name equals the runtime type of the instance under
    /// test, any of its base types, or the member's declaring type ("*" matches every type) —
    /// so a single entry can cover a member inherited by a whole family.
    /// </summary>
    internal static class SweepPolicy
    {
        private readonly struct MemberRule
        {
            public MemberRule(string typeName, string memberName, string justification)
            {
                TypeName = typeName;
                MemberName = memberName;
                Justification = justification;
            }

            public string TypeName { get; }
            public string MemberName { get; }
            public string Justification { get; }
        }

        // ------------------------------------------------------------------ properties

        private static readonly MemberRule[] PropertySkips =
        {
            // Designer/interop plumbing (spec-mandated skips).
            new MemberRule("*", "Site",
                "Requires designer/container siting context (ISite); meaningless at runtime."),
            new MemberRule("*", "WindowTarget",
                "IWindowTarget interop plumbing consumed by the designer/runtime internals."),

            // Test-topology hazards: these change the control's relationship to the test host.
            new MemberRule("*", "Parent",
                "Reparents the control off the shown test host mid-sweep."),
            new MemberRule("*", "TopLevel",
                "Setting true on a parented control throws by design (top-level ordering)."),
            new MemberRule("*", "MdiParent",
                "Requires an MDI-container parent-form relationship the harness does not build."),

            // Grid editing controls (PercentageEditingControl, KryptonDataGridViewProgress-
            // EditingControl) derive from the framework DataGridViewTextBoxEditingControl and
            // only ever live inside a DataGridView. Setting their text raises the framework's
            // OnTextChanged, which dereferences the (null) hosting grid — a framework-side NRE
            // (System.Windows.Forms code, not Krypton) that on .NET Framework escapes a
            // reflected WM_COMMAND WndProc. Not a real-world standalone scenario; skip the
            // text-changing members. (net48-only: .NET 8 WinForms guards OnTextChanged.)
            new MemberRule("DataGridViewTextBoxEditingControl", "Text",
                "Framework editing control requires a hosting DataGridView; standalone Text set raises a framework-side OnTextChanged NRE."),
            new MemberRule("DataGridViewTextBoxEditingControl", "SelectedText",
                "Framework editing control requires a hosting DataGridView; standalone SelectedText set raises a framework-side OnTextChanged NRE."),

            // Data-dependent semantics: valid only once the Items/data collections are filled.
            new MemberRule("*", "SelectedIndex",
                "Indexes the (empty) Items collection; setting 1 with no items throws by design."),
            new MemberRule("*", "SplitterDistance",
                "Constrained by Panel1MinSize/Panel2MinSize; the typical value 1 is below the designed minimum by contract."),
            new MemberRule("DataGridView", "FirstDisplayedScrollingColumnIndex",
                "Indexes the (empty) Columns collection; throws by design with no columns."),
            new MemberRule("DataGridView", "FirstDisplayedScrollingRowIndex",
                "Indexes the (empty) Rows collection; throws by design with no rows."),

            // Documented by-design setter rejections (the typical value hits a value or a
            // property pairing the base control rejects by contract).
            new MemberRule("KryptonComboBox", "DropDownStyle",
                "KryptonComboBox documents that ComboBoxStyle.Simple is unsupported and rejects it by design (first non-default enum member)."),
            new MemberRule("DataGridView", "CellBorderStyle",
                "DataGridViewCellBorderStyle.Custom (the first enum member) is reserved for internal use; the setter rejects it by design."),
            new MemberRule("DataGridView", "ColumnHeadersBorderStyle",
                "DataGridViewHeaderBorderStyle.Custom is reserved for internal use; the setter rejects it by design."),
            new MemberRule("DataGridView", "RowHeadersBorderStyle",
                "DataGridViewHeaderBorderStyle.Custom is reserved for internal use; the setter rejects it by design."),
            new MemberRule("DataGridView", "ColumnHeadersHeight",
                "Documented minimum is 4 (not discoverable via a Minimum property); 1 is rejected by design."),
            new MemberRule("DataGridView", "RowHeadersWidth",
                "Documented minimum is 4 (not discoverable via a Minimum property); 1 is rejected by design."),
            new MemberRule("DataGridView", "ColumnHeadersVisible",
                "Cannot be false while a column auto-sizes from its header — a documented pairing rule with the default AutoSizeMode."),
            new MemberRule("DataGridView", "RowHeadersVisible",
                "Cannot be false while the grid auto-sizes using row headers — a documented pairing rule with the default AutoSizeMode."),
            new MemberRule("KryptonListView", "HoverSelection",
                "Cannot be false while HotTracking is true — a documented pairing rule; the sweep sets HotTracking=true first (alphabetical)."),
            new MemberRule("ToolStrip", "AllowItemReorder",
                "Cannot be true while AllowDrop is true — a documented pairing rule; the sweep sets AllowDrop=true first (alphabetical)."),
            new MemberRule("ToolStrip", "AutoScroll",
                "ToolStrip does not support AutoScroll; the setter throws NotSupportedException by design."),
            new MemberRule("ToolStrip", "AutoScrollMinSize",
                "Routes to the AutoScroll setter, which ToolStrip rejects by design."),
            new MemberRule("ToolStrip", "AutoScrollMargin",
                "Routes to the AutoScroll setter, which ToolStrip rejects by design."),
            new MemberRule("ToolStrip", "RenderMode",
                "ToolStripRenderMode.Custom (the first enum member) can only be reached via the Renderer property; the setter rejects it by design."),
            new MemberRule("KryptonComboBox", "AutoCompleteMode",
                "Only AutoCompleteMode.None is allowed while DropDownStyle is DropDownList with a non-ListItems source (KryptonThemeComboBox default) — a documented pairing rule."),

            // WebBrowserBase rejects most ambient control properties by design (the native
            // ActiveX surface owns them); each setter throws NotSupportedException.
            new MemberRule("WebBrowserBase", "AllowDrop",
                "WebBrowser does not support AllowDrop (use AllowWebBrowserDrop); setter throws by design."),
            new MemberRule("WebBrowserBase", "BackgroundImage",
                "WebBrowser does not support BackgroundImage; setter throws by design."),
            new MemberRule("WebBrowserBase", "BackgroundImageLayout",
                "WebBrowser does not support BackgroundImageLayout; setter throws by design."),
            new MemberRule("WebBrowserBase", "Cursor",
                "WebBrowser does not support Cursor; setter throws by design."),
            new MemberRule("WebBrowserBase", "Enabled",
                "WebBrowser does not support Enabled; setter throws by design."),
            new MemberRule("WebBrowserBase", "RightToLeft",
                "WebBrowser does not support RightToLeft; setter throws by design."),
            new MemberRule("WebBrowserBase", "Text",
                "WebBrowser does not support Text; setter throws by design."),
            new MemberRule("WebBrowserBase", "UseWaitCursor",
                "WebBrowser does not support UseWaitCursor; setter throws by design."),

            // KryptonPage deliberately seals its palette to the owning Navigator: the members
            // are hidden ([Browsable(false)], [EditorBrowsable(Never)]) and the setters always
            // throw. FIXME (BREAKAGE-LOG Phase 5b, OPEN): they throw OperationCanceledException,
            // which misrepresents the contract — NotSupportedException would be correct; whether
            // to change the thrown type is an upstream-facing design call.
            new MemberRule("KryptonPage", "PaletteMode",
                "Deliberately unsettable (page palette follows the owning Navigator); hidden from designer; always throws. FIXME: wrong exception type — logged OPEN in BREAKAGE-LOG."),
            new MemberRule("KryptonPage", "Palette",
                "Deliberately unsettable (page palette follows the owning Navigator); hidden from designer; always throws. FIXME: wrong exception type — logged OPEN in BREAKAGE-LOG."),
        };

        // ------------------------------------------------------------------ methods

        /// <summary>Exact method names never invoked, with justifications.</summary>
        private static readonly Dictionary<string, string> MethodDenyNames =
            new Dictionary<string, string>(StringComparer.Ordinal)
            {
                // Spec deny: the recipe's step 6 owns disposal; never dispose mid-sweep.
                ["Dispose"] = "Dispose-family mid-sweep (spec deny-list); step 6 owns disposal.",
                // Spec deny: Hide/Close ordering hazards.
                ["Hide"] = "Hide/Close ordering hazard (spec deny-list); render/dispose steps assume a visible control.",
                ["Show"] = "Visibility ordering hazard; several overloads take owner/location and pop top-level UI.",
                // Machine-global side effects.
                ["Cut"] = "Mutates the interactive user's clipboard (machine-global side effect).",
                ["Copy"] = "Mutates the interactive user's clipboard (machine-global side effect).",
                ["Paste"] = "Reads/consumes the interactive user's clipboard (machine-global side effect).",
            };

        /// <summary>Method-name prefixes never invoked.</summary>
        private static readonly Dictionary<string, string> MethodDenyPrefixes =
            new Dictionary<string, string>(StringComparer.Ordinal)
            {
                ["Show"] = "Show* methods raise top-level/modal UI (ShowDialog, ShowContextMenu, ShowPopup...) — blocks the unattended run (spec deny-list).",
                ["Print"] = "Print* methods spool a job to the default printer (machine-global side effect).",
            };

        /// <summary>Method-name substrings never invoked.</summary>
        private static readonly Dictionary<string, string> MethodDenySubstrings =
            new Dictionary<string, string>(StringComparer.Ordinal)
            {
                ["Dialog"] = "*Dialog* methods raise modal UI — blocks the unattended run (spec deny-list).",
                ["Close"] = "*Close* methods are Hide/Close ordering hazards (spec deny-list).",
                ["File"] = "*File* methods read/write the filesystem (side effect; loads throw FileNotFound by design without a fixture file).",
            };

        /// <summary>Per-type method denies, with justifications.</summary>
        private static readonly MemberRule[] MethodDenies =
        {
            // Index-parameter methods over the (empty) Items/Columns/Rows collections: the
            // typical value 1 is out of range *by design* until data is present. Denied on the
            // declaring type so one entry covers the whole derived family.
            new MemberRule("KryptonListBox", "GetItemHeight",
                "Indexes the empty Items collection; ArgumentOutOfRange by design without data."),
            new MemberRule("KryptonListBox", "GetItemRectangle",
                "Indexes the empty Items collection; ArgumentOutOfRange by design without data."),
            new MemberRule("KryptonListBox", "GetSelected",
                "Indexes the empty Items collection; ArgumentOutOfRange by design without data."),
            new MemberRule("KryptonListBox", "SetSelected",
                "Indexes the empty Items collection (and rejects SelectionMode.None, which the sweep sets); throws by design without data."),
            new MemberRule("KryptonCheckedListBox", "GetItemHeight",
                "Indexes the empty Items collection; ArgumentOutOfRange by design without data."),
            new MemberRule("KryptonCheckedListBox", "GetItemRectangle",
                "Indexes the empty Items collection; ArgumentOutOfRange by design without data."),
            new MemberRule("KryptonCheckedListBox", "GetSelected",
                "Indexes the empty Items collection; ArgumentOutOfRange by design without data."),
            new MemberRule("KryptonCheckedListBox", "SetSelected",
                "Indexes the empty Items collection; ArgumentOutOfRange by design without data."),
            new MemberRule("KryptonComboBox", "GetItemHeight",
                "Indexes the empty Items collection; ArgumentOutOfRange by design without data."),
            new MemberRule("KryptonCheckedListBox", "GetItemCheckState",
                "Indexes the empty Items collection; ArgumentOutOfRange by design without data."),
            new MemberRule("KryptonCheckedListBox", "GetItemChecked",
                "Indexes the empty Items collection; ArgumentOutOfRange by design without data."),
            new MemberRule("KryptonCheckedListBox", "SetItemCheckState",
                "Indexes the empty Items collection; ArgumentOutOfRange by design without data."),
            new MemberRule("KryptonCheckedListBox", "SetItemChecked",
                "Indexes the empty Items collection; ArgumentOutOfRange by design without data."),
            new MemberRule("KryptonListView", "AutoResizeColumn",
                "Indexes the empty Columns collection; ArgumentOutOfRange by design without data."),
            new MemberRule("KryptonListView", "EnsureVisible",
                "Indexes the empty Items collection; ArgumentOutOfRange by design without data."),
            new MemberRule("KryptonListView", "FindItemWithText",
                "startIndex indexes the empty Items collection; ArgumentOutOfRange by design without data."),
            new MemberRule("KryptonListView", "FindNearestItem",
                "Only supported in SmallIcon/LargeIcon view (a documented view-mode contract); the sweep's View may be Details."),
            new MemberRule("KryptonListView", "GetItemRect",
                "Indexes the empty Items collection; ArgumentOutOfRange by design without data."),
            new MemberRule("KryptonListView", "RedrawItems",
                "Indexes the empty Items collection; ArgumentOutOfRange by design without data."),
            new MemberRule("KryptonRichTextBox", "Find",
                "start=1 exceeds the empty document's valid range (0..0); ArgumentOutOfRange by design without text."),
            new MemberRule("KryptonPropertyGrid", "RefreshTabs",
                "Only PropertyTabScope.Component/Document are permitted (Static/Global are reserved); the first enum member is rejected by design."),
        };

        // ------------------------------------------------------------------ render allow-list

        /// <summary>
        /// Blank-by-design controls: assert "no exception" instead of non-blankness
        /// (spec §6.2 step 3). Key = type name; value = justification.
        /// </summary>
        private static readonly Dictionary<string, string> BlankByDesign =
            new Dictionary<string, string>(StringComparer.Ordinal)
            {
                ["KryptonPanel"] = "An empty panel is a single-colour fill by design (the spec's canonical example).",
                ["KryptonSeparator"] = "A splitter/separator bar renders as a uniform bar by design until it hosts a splitter interaction.",
                ["KryptonBorderEdge"] = "A one-pixel-style border strip: a single border colour is its entire visual by design.",
                ["KryptonWebBrowser"] = "Native ActiveX WebBrowser surface; DrawToBitmap cannot capture out-of-process content — blank white by mechanism.",
                ["HScrollSkin"] = "A scrollbar-skinning wrapper panel: with no scrollable child hosted it is an empty panel fill by design.",
                ["VScrollSkin"] = "A scrollbar-skinning wrapper panel: with no scrollable child hosted it is an empty panel fill by design.",
                ["KryptonButtonPanel"] = "A panel intended to receive dialog buttons; empty by default, so a single-colour fill by design.",
                ["KryptonTableLayoutPanel"] = "An empty layout panel: nothing but the backdrop fill until cells are populated, by design.",
                ["KryptonSplitContainer"] = "Two empty panels and a same-coloured splitter bar: uniform until the panels have content, by design.",
                ["KryptonPictureBox"] = "No Image assigned by default: paints only the backdrop fill by design.",
                ["KryptonDataGridView"] = "With no columns or rows the grid paints only its background brush (headers need at least one column), by design.",
                ["KryptonDataGridViewTextBoxEditingControl"] = "A borderless text-area editing control (meant to live inside a grid cell): blank white surface by design.",
                ["KryptonDataGridViewCustomEditingControl"] = "A borderless text-area editing control (meant to live inside a grid cell): blank white surface by design.",
                ["KryptonDataGridViewMaskedTextBoxEditingControl"] = "A borderless text-area editing control (meant to live inside a grid cell): blank white surface by design.",
                ["KryptonWrapLabel"] = "AutoSize label with an empty default Text: zero-width, no pixels to paint by design.",
                ["KryptonLinkWrapLabel"] = "AutoSize label with an empty default Text: zero-width, no pixels to paint by design.",
                ["KryptonPage"] = "A navigator page is an empty client surface until it hosts content: single-colour fill by design.",
                ["KryptonDockableWorkspace"] = "An empty workspace surface (no cells/pages docked yet): single-colour fill by design.",
                ["KryptonDockspace"] = "An empty docking surface (no pages docked yet): single-colour fill by design.",
                ["KryptonDockspaceSlide"] = "An empty auto-hidden slide-out docking surface: single-colour fill by design.",
                ["KryptonFloatspace"] = "An empty floating-window docking surface: single-colour fill by design.",
            };

        /// <summary>
        /// Controls for which DrawToBitmap itself must not be attempted, with justification.
        /// </summary>
        private static readonly Dictionary<string, string> NoRender =
            new Dictionary<string, string>(StringComparer.Ordinal)
            {
                // (populated from empirical findings; keep each entry justified)
            };

        // ------------------------------------------------------------------ evaluation

        /// <summary>Should the property sweep skip this property? (Justification returned.)</summary>
        public static bool SkipProperty(object instance, PropertyInfo property, out string reason) =>
            Matches(PropertySkips, instance, property.Name, property.DeclaringType, out reason);

        /// <summary>Should the method sweep skip this method? (Justification returned.)</summary>
        public static bool DenyMethod(object instance, MethodInfo method, out string reason)
        {
            if (MethodDenyNames.TryGetValue(method.Name, out string? byName))
            {
                reason = byName;
                return true;
            }

            foreach (KeyValuePair<string, string> prefix in MethodDenyPrefixes)
            {
                if (method.Name.StartsWith(prefix.Key, StringComparison.Ordinal))
                {
                    reason = prefix.Value;
                    return true;
                }
            }

            foreach (KeyValuePair<string, string> substring in MethodDenySubstrings)
            {
                if (method.Name.IndexOf(substring.Key, StringComparison.Ordinal) >= 0)
                {
                    reason = substring.Value;
                    return true;
                }
            }

            return Matches(MethodDenies, instance, method.Name, method.DeclaringType, out reason);
        }

        /// <summary>Is this control's default render legitimately uniform?</summary>
        public static bool IsBlankByDesign(Type type) => MatchesTypeMap(BlankByDesign, type);

        /// <summary>Must DrawToBitmap be skipped entirely for this control?</summary>
        public static bool IsNoRender(Type type) => MatchesTypeMap(NoRender, type);

        private static bool MatchesTypeMap(Dictionary<string, string> map, Type type)
        {
            for (Type? t = type; t != null && t != typeof(object); t = t.BaseType)
            {
                if (map.ContainsKey(t.Name))
                {
                    return true;
                }
            }

            return false;
        }

        private static bool Matches(
            MemberRule[] rules, object instance, string memberName, Type? declaringType, out string reason)
        {
            foreach (MemberRule rule in rules)
            {
                if (!string.Equals(rule.MemberName, memberName, StringComparison.Ordinal))
                {
                    continue;
                }

                if (rule.TypeName == "*" ||
                    TypeNameMatches(instance.GetType(), rule.TypeName) ||
                    (declaringType != null && string.Equals(declaringType.Name, rule.TypeName, StringComparison.Ordinal)))
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
