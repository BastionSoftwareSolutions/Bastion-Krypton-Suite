#region BSD License
/*
 * New (Bastion) file in a work derived from BSD-3-Clause licensed code:
 * © Component Factory Pty Ltd, 2006 - 2016. Then modifications by Peter Wagner (aka Wagnerp),
 * Simon Coghlan (aka Smurf-IV), Giduac, Ahmed Abdelhameed, Lesandro & tobitege et al. 2017 - 2026.
 * © Bastion Software Solutions Ltd 2026. All rights reserved.
 */
#endregion

using System;
using System.Windows.Forms;

using Bastion.Krypton.UnitTests.Infrastructure;

using Krypton.Toolkit;

using NUnit.Framework;

namespace Bastion.Krypton.UnitTests.Regression
{
    /// <summary>
    /// Locks in the Phase 2 fixes for BREAKAGE-LOG items 1-2: disposing a focused control on a
    /// shown form used to raise NullReferenceException inside WndProc — the native child
    /// receives WM_SETFOCUS/WM_KILLFOCUS from inside DestroyWindow while teardown state is
    /// already null (KryptonComboBox: <c>_subclassEdit</c> in the focus handlers; the other
    /// five: <c>UpdateStateAndPalettes</c> guarded only by IsDisposed, which is not set until
    /// Dispose completes). StaMessagePump runs the body with thread-scoped
    /// UnhandledExceptionMode.ThrowException, so any WndProc exception fails the test instead
    /// of presenting as the modal thread-exception dialog.
    /// </summary>
    [TestFixture]
    public class DisposeWhileFocusedTests : UiTestBase
    {
        /// <summary>Create control on a shown form, focus it, dispose it — no exception.</summary>
        [TestCase(typeof(KryptonComboBox))]
        [TestCase(typeof(KryptonListView))]
        [TestCase(typeof(KryptonListBox))]
        [TestCase(typeof(KryptonCheckedListBox))]
        [TestCase(typeof(KryptonTreeView))]
        [TestCase(typeof(KryptonPropertyGrid))]
        public void DisposeWhileFocused_OnShownForm_DoesNotThrow(Type controlType)
        {
            StaMessagePump.Run(() =>
            {
                using (var form = new Form
                {
                    Text = $"DisposeWhileFocused: {controlType.Name}",
                    ShowInTaskbar = false,
                    ClientSize = new System.Drawing.Size(320, 240)
                })
                {
                    var control = (Control)Activator.CreateInstance(controlType)!;
                    control.SetBounds(8, 8, 280, 160);
                    form.Controls.Add(control);

                    form.Show();
                    StaMessagePump.Pump(100);

                    control.Focus();
                    StaMessagePump.Pump(100);
                    Assert.That(control.ContainsFocus, Is.True,
                        $"{controlType.Name} did not take focus — the repro precondition failed.");

                    // The regression: this Dispose used to throw NullReferenceException from
                    // the focus events fired inside DestroyWindow.
                    Assert.That(() => control.Dispose(), Throws.Nothing,
                        $"Disposing a focused {controlType.Name} threw — BREAKAGE-LOG item 1/2 regression.");

                    StaMessagePump.Pump(100);
                }

                StaMessagePump.Pump(50);
            });
        }
    }
}
