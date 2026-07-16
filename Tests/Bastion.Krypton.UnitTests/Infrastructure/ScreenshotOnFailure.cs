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
using System.Drawing.Imaging;
using System.IO;
using System.Text;
using System.Windows.Forms;

using NUnit.Framework;
using NUnit.Framework.Interfaces;

namespace Bastion.Krypton.UnitTests.Infrastructure
{
    /// <summary>
    /// Captures the whole (virtual) screen to the artefacts directory when a test fails
    /// (spec §6.1: "Screenshot capture on failure, artefacts saved per run").
    /// </summary>
    public static class ScreenshotOnFailure
    {
        /// <summary>
        /// Environment variable that overrides the artefacts directory; set by
        /// Tests\run-tests.ps1 to Tests\artifacts\&lt;project&gt;\&lt;tfm&gt;\screenshots.
        /// </summary>
        public const string ArtefactsDirVariable = "BASTION_TEST_ARTIFACTS";

        /// <summary>
        /// Captures the virtual screen to a PNG named after <paramref name="testName"/>.
        /// Never throws: capture problems (e.g. a headless session) must not mask the
        /// original test failure.
        /// </summary>
        /// <param name="testName">Name used for the file (sanitised).</param>
        /// <returns>The saved file path, or null if capture failed.</returns>
        public static string? TryCapture(string testName)
        {
            try
            {
                string directory = Environment.GetEnvironmentVariable(ArtefactsDirVariable) is { Length: > 0 } configured
                    ? configured
                    : Path.Combine(TestContext.CurrentContext.WorkDirectory, "screenshots");
                Directory.CreateDirectory(directory);

                string file = Path.Combine(directory,
                    $"{Sanitise(testName)}_{DateTime.Now:yyyyMMdd-HHmmss}.png");

                Rectangle bounds = SystemInformation.VirtualScreen;
                using (var bitmap = new Bitmap(Math.Max(1, bounds.Width), Math.Max(1, bounds.Height)))
                {
                    using (var graphics = Graphics.FromImage(bitmap))
                    {
                        graphics.CopyFromScreen(bounds.Location, Point.Empty, bounds.Size);
                    }

                    bitmap.Save(file, ImageFormat.Png);
                }

                TestContext.AddTestAttachment(file, "Screen captured on failure");
                return file;
            }
            catch (Exception ex)
            {
                TestContext.WriteLine($"ScreenshotOnFailure: capture failed ({ex.GetType().Name}: {ex.Message}).");
                return null;
            }
        }

        private static string Sanitise(string name)
        {
            var builder = new StringBuilder(name.Length);
            foreach (char c in name)
            {
                builder.Append(char.IsLetterOrDigit(c) || c is '-' or '_' or '.' ? c : '_');
            }

            // Keep paths comfortably under MAX_PATH.
            return builder.Length > 120 ? builder.ToString(0, 120) : builder.ToString();
        }
    }

    /// <summary>
    /// Base fixture for UI tests: a TearDown that captures the screen to the artefacts
    /// directory when the test failed.
    /// </summary>
    public abstract class UiTestBase
    {
        /// <summary>Captures a screenshot if the finishing test failed (including errors).</summary>
        [TearDown]
        public void CaptureScreenOnFailure()
        {
            ResultState result = TestContext.CurrentContext.Result.Outcome;
            if (result.Status == TestStatus.Failed)
            {
                ScreenshotOnFailure.TryCapture(TestContext.CurrentContext.Test.FullName);
            }
        }
    }
}
