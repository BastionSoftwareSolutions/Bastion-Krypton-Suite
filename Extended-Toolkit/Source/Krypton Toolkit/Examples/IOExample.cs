#region MIT License

/*
 * MIT License
 *
 * © Bastion Software Solutions Ltd. New file for the Bastion Krypton Suite,
 * a derived work from the MIT-licensed Krypton Toolkit Suite Extended
 * (Copyright (c) 2017 - 2024 Krypton Suite).
 *
 * Permission is hereby granted, free of charge, to any person obtaining a copy
 * of this software and associated documentation files (the "Software"), to deal
 * in the Software without restriction, including without limitation the rights
 * to use, copy, modify, merge, publish, distribute, sublicense, and/or sell
 * copies of the Software, and to permit persons to whom the Software is
 * furnished to do so, subject to the following conditions:
 *
 * The above copyright notice and this permission notice shall be included in all
 * copies or substantial portions of the Software.
 *
 * THE SOFTWARE IS PROVIDED "AS IS", WITHOUT WARRANTY OF ANY KIND, EXPRESS OR
 * IMPLIED, INCLUDING BUT NOT LIMITED TO THE WARRANTIES OF MERCHANTABILITY,
 * FITNESS FOR A PARTICULAR PURPOSE AND NONINFRINGEMENT. IN NO EVENT SHALL THE
 * AUTHORS OR COPYRIGHT HOLDERS BE LIABLE FOR ANY CLAIM, DAMAGES OR OTHER
 * LIABILITY, WHETHER IN AN ACTION OF CONTRACT, TORT OR OTHERWISE, ARISING FROM,
 * OUT OF OR IN CONNECTION WITH THE SOFTWARE OR THE USE OR OTHER DEALINGS IN THE
 * SOFTWARE.
 *
 */

#endregion
using Krypton.Toolkit.Suite.Extended.IO;

namespace Examples
{
    /// <summary>Demonstrates the IO module: KryptonFileSystemTreeView and KryptonSystemInformation.</summary>
    public partial class IOExample : KryptonForm
    {
        public IOExample()
        {
            InitializeComponent();
        }

        private void IOExample_Load(object sender, EventArgs e)
        {
            // The control captures the machine's drives at construction; the sample turns
            // that list into ready-drive nodes with their top-level directories.
            foreach (var drive in kfstvFileSystem.Drives)
            {
                if (!drive.IsReady)
                {
                    continue;
                }

                var driveNode = kfstvFileSystem.Nodes.Add($"{drive.Name} ({drive.DriveType})");

                try
                {
                    foreach (var directory in drive.RootDirectory.GetDirectories())
                    {
                        driveNode.Nodes.Add(directory.Name);
                    }
                }
                catch (UnauthorizedAccessException)
                {
                    // Skip directories the current user may not enumerate.
                }
                catch (IOException)
                {
                    // Skip drives that stop responding while being enumerated.
                }
            }
        }

        private void kbtnSystemInformation_Click(object sender, EventArgs e)
        {
            new KryptonSystemInformation().Show();
        }
    }
}
