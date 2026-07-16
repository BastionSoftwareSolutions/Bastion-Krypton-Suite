#region BSD License
/*
 * New (Bastion) file in a work derived from BSD-3-Clause licensed code:
 * © Component Factory Pty Ltd, 2006 - 2016. Then modifications by Peter Wagner (aka Wagnerp),
 * Simon Coghlan (aka Smurf-IV), Giduac, Ahmed Abdelhameed, Lesandro & tobitege et al. 2017 - 2026.
 * © Bastion Software Solutions Ltd 2026. All rights reserved.
 */
#endregion

// Extended-module attacks: net48 + net8.0-windows only (scope note in Tests\README.md).
#if BASTION_EXTENDED

using System;
using System.Collections.Generic;
using System.Drawing;
using System.Windows.Forms;

using Bastion.Krypton.UnitTests.Infrastructure;

using Krypton.Toolkit;

using Krypton.Toolkit.Suite.Extended.Notifications;

using Krypton.Toolkit.Suite.Extended.Wizard;

using NUnit.Framework;

namespace Bastion.Krypton.StressTests.Extended
{
    /// <summary>
    /// Spec §6.3 attack 7 (v1.1) — wizard navigation abuse (skip past the ends, jump to
    /// invalid pages, dispose mid-transition) and toast/notification spam (hundreds queued,
    /// hidden and disposed during their animations).
    /// </summary>
    [TestFixture]
    [Category("Adversarial")]
    public class ExtendedWizardAndToastTests : UiTestBase
    {
        // ------------------------------------------------------------------ wizard abuse

        /// <summary>Navigation abuse on a live KryptonAdvancedWizard.</summary>
        [Test]
        public void Wizard_NavigationAbuse_SkipBackAndInvalidJumps()
        {
            List<AttackFailure> failures = AttackHarness.Run("wizard-abuse", collected =>
            {
                var host = new KryptonForm
                {
                    StartPosition = FormStartPosition.Manual,
                    Location = new Point(0, 0),
                    ClientSize = new Size(700, 500),
                    ShowInTaskbar = false,
                    Text = "Bastion 5c wizard abuse"
                };
                var wizard = new KryptonAdvancedWizard { Dock = DockStyle.Fill };
                try
                {
                    for (var i = 0; i < 5; i++)
                    {
                        wizard.WizardPages.Add(new KryptonAdvancedWizardPage { HeaderTitle = $"Page {i}" });
                    }

                    host.Controls.Add(wizard);
                    host.Show();
                    StaMessagePump.Pump(120);

                    // Back before the first page, ×10.
                    AttackHarness.Attack(collected, "wizard-back", "ClickBack ×10 at page 0", "-", () =>
                    {
                        for (var i = 0; i < 10; i++)
                        {
                            wizard.ClickBack();
                            StaMessagePump.Pump(10);
                        }
                    });

                    // Next past the last page, ×10.
                    AttackHarness.Attack(collected, "wizard-next", "ClickNext ×10 past end", "-", () =>
                    {
                        for (var i = 0; i < 10; i++)
                        {
                            wizard.ClickNext();
                            StaMessagePump.Pump(10);
                        }
                    });

                    // Invalid jumps must reject gracefully.
                    AttackHarness.Attack(collected, "wizard-jump", "GoToPage(-1)", "-", () => wizard.GoToPage(-1));
                    AttackHarness.Attack(collected, "wizard-jump", "GoToPage(999)", "-", () => wizard.GoToPage(999));

                    // Rapid whiplash navigation.
                    AttackHarness.Attack(collected, "wizard-whiplash", "Next/Back ×50", "-", () =>
                    {
                        for (var i = 0; i < 50; i++)
                        {
                            wizard.ClickNext();
                            wizard.ClickBack();
                        }

                        StaMessagePump.Pump(60);
                    });
                }
                finally
                {
                    wizard.Dispose();
                    host.Dispose();
                    StaMessagePump.Pump(40);
                }
            });

            AttackHarness.AssertClean("wizard-abuse", failures);
        }

        /// <summary>Dispose the wizard from inside its own PageChanged event (mid-transition).</summary>
        [Test]
        public void Wizard_DisposedMidTransition_DoesNotCrash()
        {
            List<AttackFailure> failures = AttackHarness.Run("wizard-dispose-mid-transition", collected =>
            {
                var host = new KryptonForm
                {
                    StartPosition = FormStartPosition.Manual,
                    Location = new Point(0, 0),
                    ClientSize = new Size(700, 500),
                    ShowInTaskbar = false,
                    Text = "Bastion 5c wizard dispose mid-transition"
                };
                var wizard = new KryptonAdvancedWizard { Dock = DockStyle.Fill };
                try
                {
                    for (var i = 0; i < 4; i++)
                    {
                        wizard.WizardPages.Add(new KryptonAdvancedWizardPage { HeaderTitle = $"Page {i}" });
                    }

                    host.Controls.Add(wizard);
                    host.Show();
                    StaMessagePump.Pump(120);

                    var disposedMidTransition = false;
                    wizard.PageChanged += (_, _) =>
                    {
                        if (!disposedMidTransition)
                        {
                            disposedMidTransition = true;
                            // The attack: tear the wizard down while it is switching pages.
                            wizard.Dispose();
                        }
                    };

                    AttackHarness.Attack(collected, "wizard-dispose", "ClickNext with disposing PageChanged", "-", () =>
                    {
                        wizard.ClickNext();
                        StaMessagePump.Pump(120);
                    });
                }
                finally
                {
                    try
                    {
                        wizard.Dispose();
                    }
                    catch (Exception ex)
                    {
                        collected.Add(new AttackFailure("wizard-dispose", "Wizard.Dispose()", "-", ex));
                    }

                    host.Dispose();
                    StaMessagePump.Pump(40);
                }
            });

            AttackHarness.AssertClean("wizard-dispose-mid-transition", failures);
        }

        // ------------------------------------------------------------------ toast spam

        /// <summary>
        /// Toast spam: 150 popups queued with short animations, half hidden mid-animation,
        /// all disposed during animation. USER handles must return near baseline afterwards.
        /// </summary>
        [Test]
        public void ToastPopups_SpamHideAndDisposeDuringAnimation()
        {
            List<AttackFailure> failures = AttackHarness.Run("toast-spam", collected =>
            {
                const int ToastCount = 150;

                GC.Collect();
                GC.WaitForPendingFinalizers();
                GC.Collect();
                StaMessagePump.Pump(30);
                HandleSnapshot before = HandleCounter.Snapshot();

                var popups = new List<KryptonToastNotificationPopup>(ToastCount);
                try
                {
                    AttackHarness.Attack(collected, "toast-queue", "PopUp ×150", "-", () =>
                    {
                        for (var i = 0; i < ToastCount; i++)
                        {
                            var popup = new KryptonToastNotificationPopup
                            {
                                TitleText = $"Toast {i}",
                                ContentText = "Bastion 5c toast spam",
                                Delay = 400,
                                AnimationDuration = 120,
                                AnimationInterval = 10,
                                Size = new Size(240, 80)
                            };
                            popups.Add(popup);
                            popup.PopUp();
                            if ((i & 15) == 0)
                            {
                                StaMessagePump.Pump(5);
                            }
                        }

                        StaMessagePump.Pump(80);
                    });

                    // Hide every second popup while its show/slide animation is running.
                    AttackHarness.Attack(collected, "toast-hide", "Hide during animation ×75", "-", () =>
                    {
                        for (var i = 0; i < popups.Count; i += 2)
                        {
                            popups[i].Hide();
                        }

                        StaMessagePump.Pump(80);
                    });
                }
                finally
                {
                    // Dispose everything mid-flight — animations may still be running.
                    foreach (KryptonToastNotificationPopup popup in popups)
                    {
                        try
                        {
                            popup.Dispose();
                        }
                        catch (Exception ex)
                        {
                            collected.Add(new AttackFailure("toast-dispose", "Popup.Dispose()", "-", ex));
                        }
                    }

                    StaMessagePump.Pump(300);
                }

                GC.Collect();
                GC.WaitForPendingFinalizers();
                GC.Collect();
                StaMessagePump.Pump(100);

                try
                {
                    HandleCounter.AssertStable(before, gdiSlack: 96, userSlack: 64);
                }
                catch (AssertionException handleFailure)
                {
                    collected.Add(new AttackFailure("toast-handles", "GDI/USER", $"{ToastCount} popups", handleFailure));
                }
            }, timeoutMs: 600_000);

            AttackHarness.AssertClean("toast-spam", failures);
        }
    }
}

#endif
