#region BSD License
/*
 * New (Bastion) file in a work derived from BSD-3-Clause licensed code:
 * © Component Factory Pty Ltd, 2006 - 2016. Then modifications by Peter Wagner (aka Wagnerp),
 * Simon Coghlan (aka Smurf-IV), Giduac, Ahmed Abdelhameed, Lesandro & tobitege et al. 2017 - 2026.
 * © Bastion Software Solutions Ltd 2026. All rights reserved.
 */
#endregion

// FormsTestGen (spec §6.1): reflects over the five core Krypton assemblies (net8.0-windows leg),
// groups public Component types by assembly (family) and emits designer-style form classes —
// C# into Tests\Bastion.Krypton.FormsTests\Generated and VB into
// Tests\Bastion.Krypton.FormsTests.VB\Generated. One form per family; every instantiable public
// control laid out in a grid via InitializeComponent-style code (real fields,
// SuspendLayout/ResumeLayout); non-control components as sited fields. Generated code is
// committed — regenerate with: dotnet run --project Tests\Tools\FormsTestGen

using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.IO;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Windows.Forms;

namespace Bastion.Krypton.FormsTestGen
{
    internal sealed record CatalogueEntry(Type Type, string FieldName, bool IsControl, bool HasContainerCtor);

    internal sealed record FamilyCatalogue(
        string FamilyName,
        string AssemblyName,
        List<CatalogueEntry> Controls,
        List<CatalogueEntry> Components,
        List<string> Skipped);

    internal static class Program
    {
        private const int Columns = 4;
        private const int CellWidth = 280;
        private const int CellHeight = 100;
        private const int SpacingX = 12;
        private const int SpacingY = 12;

        private static readonly string[] CoreAssemblies =
        {
            "Krypton.Toolkit", "Krypton.Ribbon", "Krypton.Navigator", "Krypton.Workspace", "Krypton.Docking"
        };

        private static int Main(string[] args)
        {
            try
            {
                string repoRoot = FindRepoRoot();
                string binDir = GetArg(args, "--bin")
                    ?? Path.Combine(repoRoot, "Standard-Toolkit", "Bin", "Release", "net8.0-windows");
                string outCs = GetArg(args, "--out-cs")
                    ?? Path.Combine(repoRoot, "Tests", "Bastion.Krypton.FormsTests", "Generated");
                string outVb = GetArg(args, "--out-vb")
                    ?? Path.Combine(repoRoot, "Tests", "Bastion.Krypton.FormsTests.VB", "Generated");

                Console.WriteLine($"FormsTestGen: reflecting over {binDir}");
                Directory.CreateDirectory(outCs);
                Directory.CreateDirectory(outVb);

                foreach (string name in CoreAssemblies)
                {
                    var assembly = Assembly.LoadFrom(Path.Combine(binDir, name + ".dll"));
                    FamilyCatalogue catalogue = BuildCatalogue(assembly);

                    string csFile = Path.Combine(outCs, catalogue.FamilyName + "FamilyForm.cs");
                    string vbFile = Path.Combine(outVb, catalogue.FamilyName + "FamilyForm.vb");
                    File.WriteAllText(csFile, EmitCSharp(catalogue), new UTF8Encoding(false));
                    File.WriteAllText(vbFile, EmitVisualBasic(catalogue), new UTF8Encoding(false));

                    Console.WriteLine(
                        $"  {catalogue.FamilyName,-10} controls={catalogue.Controls.Count,3}  components={catalogue.Components.Count,3}  skipped={catalogue.Skipped.Count,2}");
                    foreach (string skip in catalogue.Skipped)
                    {
                        Console.WriteLine($"      skipped: {skip}");
                    }
                }

                Console.WriteLine("FormsTestGen: done.");
                return 0;
            }
            catch (Exception ex)
            {
                Console.Error.WriteLine($"FormsTestGen failed: {ex}");
                return 1;
            }
        }

        private static string? GetArg(string[] args, string name)
        {
            int index = Array.IndexOf(args, name);
            return index >= 0 && index + 1 < args.Length ? args[index + 1] : null;
        }

        private static string FindRepoRoot()
        {
            var dir = new DirectoryInfo(AppContext.BaseDirectory);
            while (dir != null)
            {
                if (File.Exists(Path.Combine(dir.FullName, "BASTION-KRYPTON-SPEC.md")))
                {
                    return dir.FullName;
                }

                dir = dir.Parent;
            }

            throw new InvalidOperationException(
                "Could not locate the Krypton-Ultimate repo root (BASTION-KRYPTON-SPEC.md) above " + AppContext.BaseDirectory);
        }

        private static FamilyCatalogue BuildCatalogue(Assembly assembly)
        {
            string familyName = assembly.GetName().Name!.Split('.').Last();
            var controls = new List<CatalogueEntry>();
            var components = new List<CatalogueEntry>();
            var skipped = new List<string>();

            foreach (Type type in assembly.GetExportedTypes().OrderBy(static t => t.FullName, StringComparer.Ordinal))
            {
                if (!type.IsClass || type.IsAbstract || type.IsNested || type.ContainsGenericParameters ||
                    !typeof(Component).IsAssignableFrom(type))
                {
                    continue;
                }

                if (type.GetConstructor(Type.EmptyTypes) == null)
                {
                    continue; // Not instantiable via designer-style code.
                }

                if (type.GetCustomAttribute<ObsoleteAttribute>() is { IsError: true })
                {
                    skipped.Add($"{type.FullName} ([Obsolete] error)");
                    continue;
                }

                // Top-level windows and controls that reject a plain form as parent cannot be
                // dropped onto the family form (same classification the Phase 2 smoke harness
                // arrived at empirically).
                if (typeof(Form).IsAssignableFrom(type))
                {
                    skipped.Add($"{type.FullName} (Form-derived: top-level window)");
                    continue;
                }

                if (typeof(ToolStripDropDown).IsAssignableFrom(type))
                {
                    skipped.Add($"{type.FullName} (ToolStripDropDown-derived: top-level control)");
                    continue;
                }

                if (typeof(TabPage).IsAssignableFrom(type))
                {
                    skipped.Add($"{type.FullName} (TabPage-derived: needs a TabControl parent)");
                    continue;
                }

                bool isControl = typeof(Control).IsAssignableFrom(type);
                bool hasContainerCtor = type.GetConstructor(new[] { typeof(IContainer) }) != null;
                string fieldName = char.ToLowerInvariant(type.Name[0]) + type.Name.Substring(1) + "1";
                var entry = new CatalogueEntry(type, fieldName, isControl, hasContainerCtor);
                (isControl ? controls : components).Add(entry);
            }

            return new FamilyCatalogue(familyName, assembly.GetName().Name!, controls, components, skipped);
        }

        private static (int Width, int Height) FormClientSize() => (Columns * (CellWidth + SpacingX) + SpacingX + 40, 820);

        private static (int X, int Y) CellLocation(int ordinal)
        {
            int col = ordinal % Columns;
            int row = ordinal / Columns;
            return (SpacingX + col * (CellWidth + SpacingX), SpacingY + row * (CellHeight + SpacingY));
        }

        private static string Banner(FamilyCatalogue c, string commentToken)
        {
            var sb = new StringBuilder();
            sb.AppendLine($"{commentToken} <auto-generated>");
            sb.AppendLine($"{commentToken}     GENERATED by FormsTestGen — regenerate, do not hand-edit.");
            sb.AppendLine($"{commentToken}     Regenerate with: dotnet run --project Tests\\Tools\\FormsTestGen");
            sb.AppendLine($"{commentToken}");
            sb.AppendLine($"{commentToken}     Family: {c.AssemblyName} (reflected over the net8.0-windows leg).");
            sb.AppendLine($"{commentToken}     {c.Controls.Count} controls placed on the form; {c.Components.Count} non-control components as sited fields.");
            if (c.Skipped.Count > 0)
            {
                sb.AppendLine($"{commentToken}     Skipped (cannot be parented to a form):");
                foreach (string skip in c.Skipped)
                {
                    sb.AppendLine($"{commentToken}       - {skip}");
                }
            }

            sb.AppendLine($"{commentToken}");
            sb.AppendLine($"{commentToken}     © Bastion Software Solutions Ltd 2026. New (Bastion) file in a work derived from");
            sb.AppendLine($"{commentToken}     BSD-3-Clause licensed code (Component Factory Pty Ltd; Krypton-Suite et al.).");
            sb.AppendLine($"{commentToken} </auto-generated>");
            return sb.ToString();
        }

        private static string EmitCSharp(FamilyCatalogue c)
        {
            var sb = new StringBuilder();
            var (clientW, clientH) = FormClientSize();
            string formName = c.FamilyName + "FamilyForm";

            sb.Append(Banner(c, "//"));
            sb.AppendLine();
            sb.AppendLine("#nullable disable");
            sb.AppendLine("#pragma warning disable 612, 618 // designer-style code may reference [Obsolete] members");
            sb.AppendLine();
            sb.AppendLine("namespace Bastion.Krypton.FormsTests.Generated");
            sb.AppendLine("{");
            sb.AppendLine($"    /// <summary>Every instantiable public control of {c.AssemblyName} on one form (spec §6.1).</summary>");
            sb.AppendLine($"    public class {formName} : global::Krypton.Toolkit.KryptonForm");
            sb.AppendLine("    {");
            sb.AppendLine("        private System.ComponentModel.IContainer components;");
            sb.AppendLine();

            foreach (CatalogueEntry e in c.Controls.Concat(c.Components))
            {
                sb.AppendLine($"        private global::{e.Type.FullName} {e.FieldName};");
            }

            sb.AppendLine();
            sb.AppendLine($"        public {formName}()");
            sb.AppendLine("        {");
            sb.AppendLine("            InitializeComponent();");
            sb.AppendLine("        }");
            sb.AppendLine();
            sb.AppendLine("        protected override void Dispose(bool disposing)");
            sb.AppendLine("        {");
            sb.AppendLine("            if (disposing && (this.components != null))");
            sb.AppendLine("            {");
            sb.AppendLine("                this.components.Dispose();");
            sb.AppendLine("            }");
            sb.AppendLine("            base.Dispose(disposing);");
            sb.AppendLine("        }");
            sb.AppendLine();
            sb.AppendLine("        private void InitializeComponent()");
            sb.AppendLine("        {");
            sb.AppendLine("            this.components = new System.ComponentModel.Container();");

            foreach (CatalogueEntry e in c.Controls)
            {
                sb.AppendLine($"            this.{e.FieldName} = new global::{e.Type.FullName}();");
            }

            foreach (CatalogueEntry e in c.Components)
            {
                sb.AppendLine(e.HasContainerCtor
                    ? $"            this.{e.FieldName} = new global::{e.Type.FullName}(this.components);"
                    : $"            this.{e.FieldName} = new global::{e.Type.FullName}();");
            }

            sb.AppendLine("            this.SuspendLayout();");

            int tabIndex = 0;
            foreach (CatalogueEntry e in c.Controls)
            {
                var (x, y) = CellLocation(tabIndex);
                sb.AppendLine("            //");
                sb.AppendLine($"            // {e.FieldName}");
                sb.AppendLine("            //");
                sb.AppendLine($"            this.{e.FieldName}.Location = new System.Drawing.Point({x}, {y});");
                sb.AppendLine($"            this.{e.FieldName}.Name = \"{e.FieldName}\";");
                sb.AppendLine($"            this.{e.FieldName}.Size = new System.Drawing.Size({CellWidth}, {CellHeight});");
                sb.AppendLine($"            this.{e.FieldName}.TabIndex = {tabIndex};");
                sb.AppendLine($"            this.Controls.Add(this.{e.FieldName});");
                tabIndex++;
            }

            foreach (CatalogueEntry e in c.Components.Where(static e => !e.HasContainerCtor))
            {
                sb.AppendLine("            //");
                sb.AppendLine($"            // {e.FieldName} (non-control component; sited for disposal)");
                sb.AppendLine("            //");
                sb.AppendLine($"            this.components.Add(this.{e.FieldName});");
            }

            sb.AppendLine("            //");
            sb.AppendLine($"            // {formName}");
            sb.AppendLine("            //");
            sb.AppendLine("            this.AutoScroll = true;");
            sb.AppendLine($"            this.ClientSize = new System.Drawing.Size({clientW}, {clientH});");
            sb.AppendLine($"            this.Name = \"{formName}\";");
            sb.AppendLine("            this.ShowInTaskbar = false;");
            sb.AppendLine($"            this.Text = \"Bastion FormsTests — {c.AssemblyName} family (generated)\";");
            sb.AppendLine("            this.ResumeLayout(false);");
            sb.AppendLine("        }");
            sb.AppendLine("    }");
            sb.AppendLine("}");
            return sb.ToString();
        }

        private static string EmitVisualBasic(FamilyCatalogue c)
        {
            var sb = new StringBuilder();
            var (clientW, clientH) = FormClientSize();
            string formName = c.FamilyName + "FamilyForm";

            sb.Append(Banner(c, "'"));
            sb.AppendLine();
            sb.AppendLine("#Disable Warning BC40000, BC40008 ' designer-style code may reference Obsolete members");
            sb.AppendLine();
            sb.AppendLine("Namespace Generated");
            sb.AppendLine();
            sb.AppendLine($"    ''' <summary>Every instantiable public control of {c.AssemblyName} on one form (spec §6.1).</summary>");
            sb.AppendLine($"    Public Class {formName}");
            sb.AppendLine("        Inherits Global.Krypton.Toolkit.KryptonForm");
            sb.AppendLine();
            sb.AppendLine("        Private components As System.ComponentModel.IContainer");
            sb.AppendLine();

            foreach (CatalogueEntry e in c.Controls.Concat(c.Components))
            {
                sb.AppendLine($"        Private {e.FieldName} As Global.{e.Type.FullName}");
            }

            sb.AppendLine();
            sb.AppendLine("        Public Sub New()");
            sb.AppendLine("            InitializeComponent()");
            sb.AppendLine("        End Sub");
            sb.AppendLine();
            sb.AppendLine("        Protected Overrides Sub Dispose(ByVal disposing As Boolean)");
            sb.AppendLine("            If disposing AndAlso (Me.components IsNot Nothing) Then");
            sb.AppendLine("                Me.components.Dispose()");
            sb.AppendLine("            End If");
            sb.AppendLine("            MyBase.Dispose(disposing)");
            sb.AppendLine("        End Sub");
            sb.AppendLine();
            sb.AppendLine("        Private Sub InitializeComponent()");
            sb.AppendLine("            Me.components = New System.ComponentModel.Container()");

            foreach (CatalogueEntry e in c.Controls)
            {
                sb.AppendLine($"            Me.{e.FieldName} = New Global.{e.Type.FullName}()");
            }

            foreach (CatalogueEntry e in c.Components)
            {
                sb.AppendLine(e.HasContainerCtor
                    ? $"            Me.{e.FieldName} = New Global.{e.Type.FullName}(Me.components)"
                    : $"            Me.{e.FieldName} = New Global.{e.Type.FullName}()");
            }

            sb.AppendLine("            Me.SuspendLayout()");

            int tabIndex = 0;
            foreach (CatalogueEntry e in c.Controls)
            {
                var (x, y) = CellLocation(tabIndex);
                sb.AppendLine("            '");
                sb.AppendLine($"            ' {e.FieldName}");
                sb.AppendLine("            '");
                sb.AppendLine($"            Me.{e.FieldName}.Location = New System.Drawing.Point({x}, {y})");
                sb.AppendLine($"            Me.{e.FieldName}.Name = \"{e.FieldName}\"");
                sb.AppendLine($"            Me.{e.FieldName}.Size = New System.Drawing.Size({CellWidth}, {CellHeight})");
                sb.AppendLine($"            Me.{e.FieldName}.TabIndex = {tabIndex}");
                sb.AppendLine($"            Me.Controls.Add(Me.{e.FieldName})");
                tabIndex++;
            }

            foreach (CatalogueEntry e in c.Components.Where(static e => !e.HasContainerCtor))
            {
                sb.AppendLine("            '");
                sb.AppendLine($"            ' {e.FieldName} (non-control component; sited for disposal)");
                sb.AppendLine("            '");
                sb.AppendLine($"            Me.components.Add(Me.{e.FieldName})");
            }

            sb.AppendLine("            '");
            sb.AppendLine($"            ' {formName}");
            sb.AppendLine("            '");
            sb.AppendLine("            Me.AutoScroll = True");
            sb.AppendLine($"            Me.ClientSize = New System.Drawing.Size({clientW}, {clientH})");
            sb.AppendLine($"            Me.Name = \"{formName}\"");
            sb.AppendLine("            Me.ShowInTaskbar = False");
            sb.AppendLine($"            Me.Text = \"Bastion FormsTests — {c.AssemblyName} family (generated)\"");
            sb.AppendLine("            Me.ResumeLayout(False)");
            sb.AppendLine("        End Sub");
            sb.AppendLine();
            sb.AppendLine("    End Class");
            sb.AppendLine();
            sb.AppendLine("End Namespace");
            return sb.ToString();
        }
    }
}
