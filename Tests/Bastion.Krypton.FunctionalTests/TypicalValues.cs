#region BSD License
/*
 * New (Bastion) file in a work derived from BSD-3-Clause licensed code:
 * © Component Factory Pty Ltd, 2006 - 2016. Then modifications by Peter Wagner (aka Wagnerp),
 * Simon Coghlan (aka Smurf-IV), Giduac, Ahmed Abdelhameed, Lesandro & tobitege et al. 2017 - 2026.
 * © Bastion Software Solutions Ltd 2026. All rights reserved.
 */
#endregion

using System;
using System.Drawing;
using System.Globalization;
using System.Reflection;
using System.Windows.Forms;

namespace Bastion.Krypton.FunctionalTests
{
    /// <summary>
    /// The "typical value by type" map of spec §6.2 step 4: string → "Sample", numerics → 1
    /// (clamped into a discoverable [Minimum, Maximum] sibling-property range), bool → toggle,
    /// enum → first non-default defined value, Color → Red, Font → a default-font clone,
    /// Image → a small generated bitmap, Padding/Size/Point → small values. Types not in the
    /// map are reported as unmappable (the caller skips and counts them).
    /// </summary>
    internal static class TypicalValues
    {
        /// <summary>
        /// Produces a typical value for a property about to be set on <paramref name="instance"/>.
        /// Uses the current property value to toggle booleans / pick a non-current enum member,
        /// and clamps numerics into a sibling <c>Minimum</c>/<c>Maximum</c> range if one exists.
        /// </summary>
        public static bool TryForProperty(object instance, PropertyInfo property, out object? value)
        {
            // Property-name-aware refinements: a handful of members have a value *format*
            // contract that the plain by-type map cannot satisfy. Refining the typical value
            // keeps the member covered instead of skip-listing it.
            switch (property.Name)
            {
                case "PasswordChar" when property.PropertyType == typeof(char):
                    value = '*'; // Canonical mask char; also avoids the by-design
                    return true; // PasswordChar == PromptChar rejection (MaskedTextBox).

                case "PromptChar" when property.PropertyType == typeof(char):
                    value = '_'; // MaskedTextBox default prompt; distinct from PasswordChar.
                    return true;

                case "Rtf" when property.PropertyType == typeof(string):
                case "SelectedRtf" when property.PropertyType == typeof(string):
                    value = @"{\rtf1\ansi Sample}"; // Must be well-formed RTF by contract.
                    return true;

                case "StarSize" when property.PropertyType == typeof(string):
                    value = "50,50"; // Workspace star-sizing notation: "<width>,<height>".
                    return true;
            }

            object? current = null;
            if (property.GetGetMethod() != null)
            {
                try
                {
                    current = property.GetValue(instance);
                }
                catch
                {
                    // A throwing getter is itself interesting, but it is the setter sweep's
                    // job to surface member defects; treat the current value as unknown here.
                    current = null;
                }
            }

            return TryCreate(property.PropertyType, instance, current, out value);
        }

        /// <summary>Produces a typical value for a bare type (method-parameter context).</summary>
        public static bool TryForType(Type type, out object? value) =>
            TryCreate(type, null, null, out value);

        private static bool TryCreate(Type type, object? instance, object? current, out object? value)
        {
            value = null;

            Type? underlying = Nullable.GetUnderlyingType(type);
            if (underlying != null)
            {
                type = underlying;
            }

            if (type == typeof(string))
            {
                value = "Sample";
                return true;
            }

            if (type == typeof(bool))
            {
                value = current is bool b ? !b : true;
                return true;
            }

            if (type == typeof(char))
            {
                value = 'A';
                return true;
            }

            if (type.IsEnum)
            {
                // First defined value that differs from the current one (spec: "first
                // non-default defined value" — exercising each member is too much).
                Array values = Enum.GetValues(type);
                if (values.Length == 0)
                {
                    return false;
                }

                foreach (object candidate in values)
                {
                    if (current == null || !candidate.Equals(current))
                    {
                        value = candidate;
                        return true;
                    }
                }

                value = values.GetValue(0);
                return true;
            }

            if (IsNumeric(type))
            {
                value = ClampedOne(type, instance);
                return true;
            }

            if (type == typeof(Color))
            {
                value = Color.Red;
                return true;
            }

            if (type == typeof(Font))
            {
                // Fresh instance per assignment: if a control takes ownership and disposes it,
                // later assignments must not receive a dead shared font.
                value = new Font("Segoe UI", 9F);
                return true;
            }

            if (type == typeof(Image) || type == typeof(Bitmap))
            {
                value = NewSmallBitmap();
                return true;
            }

            if (type == typeof(Icon))
            {
                value = new Icon(SystemIcons.Application, 16, 16);
                return true;
            }

            if (type == typeof(Padding))
            {
                value = new Padding(2);
                return true;
            }

            if (type == typeof(Size))
            {
                value = new Size(64, 32);
                return true;
            }

            if (type == typeof(SizeF))
            {
                value = new SizeF(64F, 32F);
                return true;
            }

            if (type == typeof(Point))
            {
                value = new Point(8, 8);
                return true;
            }

            if (type == typeof(PointF))
            {
                value = new PointF(8F, 8F);
                return true;
            }

            if (type == typeof(Rectangle))
            {
                value = new Rectangle(1, 1, 32, 32);
                return true;
            }

            if (type == typeof(RectangleF))
            {
                value = new RectangleF(1F, 1F, 32F, 32F);
                return true;
            }

            if (type == typeof(DateTime))
            {
                value = DateTime.Today;
                return true;
            }

            if (type == typeof(TimeSpan))
            {
                value = TimeSpan.FromSeconds(1);
                return true;
            }

            if (type == typeof(Cursor))
            {
                value = Cursors.Hand;
                return true;
            }

            return false;
        }

        private static bool IsNumeric(Type type) =>
            type == typeof(int) || type == typeof(uint) ||
            type == typeof(short) || type == typeof(ushort) ||
            type == typeof(long) || type == typeof(ulong) ||
            type == typeof(byte) || type == typeof(sbyte) ||
            type == typeof(float) || type == typeof(double) ||
            type == typeof(decimal);

        /// <summary>
        /// 1, clamped into the [Minimum, Maximum] range when the owning object exposes
        /// readable sibling properties of a comparable numeric type (spec: "int→1 within
        /// [Min,Max] if discoverable").
        /// </summary>
        private static object ClampedOne(Type numericType, object? instance)
        {
            decimal candidate = 1m;

            if (instance != null)
            {
                decimal? minimum = ReadNumericSibling(instance, "Minimum");
                decimal? maximum = ReadNumericSibling(instance, "Maximum");
                if (minimum.HasValue && candidate < minimum.Value)
                {
                    candidate = minimum.Value;
                }

                if (maximum.HasValue && candidate > maximum.Value)
                {
                    candidate = maximum.Value;
                }
            }

            return Convert.ChangeType(candidate, numericType, CultureInfo.InvariantCulture);
        }

        private static decimal? ReadNumericSibling(object instance, string name)
        {
            try
            {
                PropertyInfo? sibling = instance.GetType().GetProperty(
                    name, BindingFlags.Public | BindingFlags.Instance);
                if (sibling?.GetGetMethod() == null || !IsNumeric(sibling.PropertyType))
                {
                    return null;
                }

                object? raw = sibling.GetValue(instance);
                return raw == null
                    ? null
                    : Convert.ToDecimal(raw, CultureInfo.InvariantCulture);
            }
            catch
            {
                return null; // AmbiguousMatch / throwing getter — no clamp information.
            }
        }

        /// <summary>A small generated two-colour bitmap (spec: "Image → small generated bitmap").</summary>
        private static Bitmap NewSmallBitmap()
        {
            var bitmap = new Bitmap(16, 16);
            using (Graphics graphics = Graphics.FromImage(bitmap))
            {
                graphics.Clear(Color.CornflowerBlue);
                using (var brush = new SolidBrush(Color.OrangeRed))
                {
                    graphics.FillRectangle(brush, 4, 4, 8, 8);
                }
            }

            return bitmap;
        }
    }
}
