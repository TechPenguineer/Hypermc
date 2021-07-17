using System;
using System.Diagnostics;
using System.Windows.Forms;
using System.IO;
using LibGit2Sharp;
using System.Linq;

namespace Hypermc
{
    public partial class MainForm : Form
    {
        static string sPath = Environment.GetFolderPath(Environment.SpecialFolder.ApplicationData);
        string path = sPath + "\\.hypermc";
        string path2 = sPath + "\\.hypermc\\git_temp";

        public MainForm()
        {
            InitializeComponent();
            Console.WriteLine("Loaded...");
        }

        private void helpToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void githubToolStripMenuItem_Click(object sender, EventArgs e) => OpenBrowser("https://github.com/TechPenguineer/Hypermc");

        private void docsToolStripMenuItem_Click(object sender, EventArgs e) => OpenBrowser("https://github.com/TechPenguineer/Hypermc/tree/main/docs");

        private void reportABugToolStripMenuItem_Click(object sender, EventArgs e) => OpenBrowser("https://github.com/TechPenguineer/Hypermc/issues/new");

        private void downloadNewReleaseToolStripMenuItem_Click(object sender, EventArgs e) => OpenBrowser("https://github.com/TechPenguineer/Hypermc/releases");

        /// <summary>
        /// Opens the default web browser to view a url
        /// </summary>
        private void OpenBrowser(string url) => Process.Start(new ProcessStartInfo("cmd", $"/c start {url}") { CreateNoWindow = true });

        public void ListDirectory(TreeView treeView, string path)
        {
            treeView.Nodes.Clear();
            var rootDirectoryInfo = new DirectoryInfo(path);
            treeView.Nodes.Add(CreateDirectoryNode(rootDirectoryInfo));
        }
        private static TreeNode CreateDirectoryNode(DirectoryInfo directoryInfo)
        {
            var directoryNode = new TreeNode(directoryInfo.Name);

            directoryNode.Nodes.AddRange(directoryInfo.GetDirectories()
                .Select(d => CreateDirectoryNode(d)).ToArray());
            directoryNode.Nodes.AddRange(directoryInfo.GetFiles()
                .Select(f => new TreeNode(f.Name)).ToArray());

            return directoryNode;
        }

        public void Form1_Load(object sender, EventArgs e)
        {
            string mod_path, version_path, version_compatible;
            string sPath = Environment.GetFolderPath(Environment.SpecialFolder.ApplicationData);
            version_compatible = "Forge 1.16.5";
            mod_path = sPath+"\\.minecraft\\mods";
            version_path = sPath+"\\.minecraft\\versions";

            Console.WriteLine(version_path);
            if (!Directory.Exists(version_path))
            {
                MessageBox.Show("Looks like you dont have Forge version 1.16.5 installed! Please make sure to install it or else this application will not work", "Incompatible Version", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else
            {
                try
                {
                    ListDirectory(currentMods, mod_path);
                }
                catch(IOException)
                {

                }
            }

        }

        private void launch_btn_Click(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void maskedTextBox1_MaskInputRejected(object sender, MaskInputRejectedEventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            string git_https = git_https_input.Text;
            try
            {
                string mod_path;
                string sPath = Environment.GetFolderPath(Environment.SpecialFolder.ApplicationData);
                mod_path = sPath + "\\.minecraft\\mods";
                string make_cmd = $"cd {mod_path} && git clone {git_https}";
                Console.WriteLine(git_https);
                Repository.Clone(git_https, mod_path);
            }
            catch(IOException)
            {
                MessageBox.Show("Git repository doesn't exist", "HyperMc", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }

        }

        private void redditToolStripMenuItem_Click(object sender, EventArgs e) => OpenBrowser("https://www.reddit.com/r/hypermc/");

        private void mod_container_Scroll(object sender, ScrollEventArgs e)
        {
        }

        private void checkedListBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void label4_Click(object sender, EventArgs e)
        {

        }

        public void copy_to_mod_folder(string sourcePath,string file_name)
        {
            string sPath = Environment.GetFolderPath(Environment.SpecialFolder.ApplicationData);
            string targetPath = sPath + "\\.minecraft\\mods";
            string sourceFile = Path.Combine(sourcePath, file_name);
            string destFile = Path.Combine(targetPath, file_name);

            File.Copy(sourceFile, destFile, true);
            Form1_Load(null, EventArgs.Empty);

        }
        private void optifine_download_Click(object sender, EventArgs e)
        {
            string path = Directory.GetCurrentDirectory();
            Console.WriteLine(path);
            copy_to_mod_folder(path2,"OptiFine_1.16.5.jar");
        }

        private void journeymap_download_Click(object sender, EventArgs e)
        {
            string path = Directory.GetCurrentDirectory();
            Console.WriteLine(path);
            copy_to_mod_folder(path2,"journeymap-1.16.5.jar");
        }

        private void reloadToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Form1_Load(null, EventArgs.Empty);
        }

        private void label5_Click(object sender, EventArgs e)
        {

        }

        private void jei_download_Click(object sender, EventArgs e)
        {
            string path = Directory.GetCurrentDirectory();
            Console.WriteLine(path);
            copy_to_mod_folder(path2,"jei_1.12.2-4.16.jar");
        }

        private void biomes_o_plenty_download_Click(object sender, EventArgs e)
        {
            string path = Directory.GetCurrentDirectory();
            Console.WriteLine(path);
            copy_to_mod_folder(path2,"BiomesOPlenty-1.16.5-universal.jar");
        }

        private void crate_download_Click(object sender, EventArgs e)
        {
            string path = Directory.GetCurrentDirectory();
            Console.WriteLine(path);
            copy_to_mod_folder(path2, "create-mc1.16.5.jar");
        }

        private void reload_btn_Click(object sender, EventArgs e)
        {
            Form1_Load(null, EventArgs.Empty);
        }

        private void versionsToolStripMenuItem_Click(object sender, EventArgs e)
        {
            string mod_path, version_path, version_compatible;
            string sPath = Environment.GetFolderPath(Environment.SpecialFolder.ApplicationData);
            version_compatible = "Forge 1.16.5";
            mod_path = sPath + "\\.minecraft\\mods";
            version_path = sPath + "\\.minecraft\\versions";

            Process.Start(version_path);
        }

        private void modsToolStripMenuItem_Click(object sender, EventArgs e)
        {
            string mod_path, version_path, version_compatible;
            string sPath = Environment.GetFolderPath(Environment.SpecialFolder.ApplicationData);
            version_compatible = "Forge 1.16.5";
            mod_path = sPath + "\\.minecraft\\mods";
            version_path = sPath + "\\.minecraft\\versions";

            Process.Start(mod_path);
        }

        private void button2_Click(object sender, EventArgs e)
        {
            DirectoryInfo di = new DirectoryInfo(path2);

            foreach(FileInfo file in di.GetFiles())
            {
                file.Delete();
            }

        }

        private void resetGitTemporariesToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void openTemporairyGitCopiesToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Process.Start(path2);
        }

        private void panel2_Paint(object sender, PaintEventArgs e)
        {

        }
    }
}
