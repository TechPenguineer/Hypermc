using System;
using System.Diagnostics;
using System.Windows.Forms;
using System.IO;
using LibGit2Sharp;

namespace Hypermc
{
    public partial class Form1 : Form
    {
        static string sPath = Environment.GetFolderPath(Environment.SpecialFolder.ApplicationData);
        string path = sPath + "\\.hypermc";
        string path2 = sPath + "\\.hypermc\\git_temp";

        public void create_appdata_mods()
        {
            try
            {
                var directoryInfo = new DirectoryInfo(path2);
                int fileCount = directoryInfo.GetFiles().Length;

                int dirCount = directoryInfo.GetDirectories().Length;
                string command = "/c c:";
                Console.WriteLine(command);
                Directory.CreateDirectory(path);
                Directory.CreateDirectory(path2);
                if (dirCount == 0 && fileCount==0 )
                {
                    Repository.Clone("https://github.com/HyperMC-mods/mod-pack.git .", path2);
                }
                else if(fileCount > 0)
                {

                }else
                {
                    MessageBox.Show("Please go to " + path2 + " and delete the .git folder. I can not do it since I dont have admin permissions.", "HyperMC", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            } catch(Exception)
            { }
        }
        public Form1()
        {
            InitializeComponent();
            create_appdata_mods();
        }

        private void helpToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void githubToolStripMenuItem_Click(object sender, EventArgs e)
        {
            System.Diagnostics.Process.Start("https://github.com/TechPenguineer/Hypermc");
        }

        private void docsToolStripMenuItem_Click(object sender, EventArgs e)
        {
            System.Diagnostics.Process.Start("https://github.com/TechPenguineer/Hypermc/tree/main/docs");
        }

        private void reportABugToolStripMenuItem_Click(object sender, EventArgs e)
        {
            System.Diagnostics.Process.Start("https://github.com/TechPenguineer/Hypermc/issues/new");
        }

        private void downloadNewReleaseToolStripMenuItem_Click(object sender, EventArgs e)
        {
            System.Diagnostics.Process.Start("https://github.com/TechPenguineer/Hypermc/releases");
        }

        public void ListDirectory(TreeView treeView, string path)
        {
            treeView.Nodes.Clear();
            var rootDirectoryInfo = new DirectoryInfo(path);
            treeView.Nodes.Add(CreateDirectoryNode(rootDirectoryInfo));
        }
        private static TreeNode CreateDirectoryNode(DirectoryInfo directoryInfo)
        {

            var directoryNode = new TreeNode(directoryInfo.Name);
            foreach(var directory in directoryInfo.GetDirectories())
            {
                directoryNode.Nodes.Add(CreateDirectoryNode(directory));
            }
            foreach(var file in directoryInfo.GetFiles())
            {
                directoryNode.Nodes.Add(new TreeNode(file.Name));
            }
            return directoryNode;


        }

        public void Form1_Load(object sender, EventArgs e)
        {

            string mod_path, version_path, version_compatible;
            String sPath = Environment.GetFolderPath(Environment.SpecialFolder.ApplicationData);
            version_compatible = "Forge 1.16.5";
            mod_path = sPath+"\\.minecraft\\mods";
            version_path = sPath+"\\.minecraft\\versions";

            Console.WriteLine(version_path);
            if (!Directory.Exists(version_path))
            {
                MessageBox.Show("Looks like you dont have Forge version 1.16.5 installed! Please make sure to install it or else this application will not work", "Incompatible Version", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }else
            {
                try{
                ListDirectory(currentMods, mod_path);
                }catch(IOException)
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
                String sPath = Environment.GetFolderPath(Environment.SpecialFolder.ApplicationData);
                mod_path = sPath + "\\.minecraft\\mods";
                String make_cmd = "cd " + mod_path + " && " + "git clone " + git_https;
                Console.WriteLine(git_https);
                Repository.Clone(git_https, mod_path);
            }
            catch(IOException)
            {
                MessageBox.Show("Git repository doesn't exist", "HyperMc", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }

        }

        private void redditToolStripMenuItem_Click(object sender, EventArgs e)
        {
            System.Diagnostics.Process.Start("https://www.reddit.com/r/hypermc/");

        }

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
               String sPath = Environment.GetFolderPath(Environment.SpecialFolder.ApplicationData);
               string targetPath = sPath + "\\.minecraft\\mods";
               string sourceFile = System.IO.Path.Combine(sourcePath, file_name);
               string destFile = System.IO.Path.Combine(targetPath, file_name);

               System.IO.File.Copy(sourceFile, destFile, true);
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
            String sPath = Environment.GetFolderPath(Environment.SpecialFolder.ApplicationData);
            version_compatible = "Forge 1.16.5";
            mod_path = sPath + "\\.minecraft\\mods";
            version_path = sPath + "\\.minecraft\\versions";

            Process.Start(version_path);
        }

        private void modsToolStripMenuItem_Click(object sender, EventArgs e)
        {
            string mod_path, version_path, version_compatible;
            String sPath = Environment.GetFolderPath(Environment.SpecialFolder.ApplicationData);
            version_compatible = "Forge 1.16.5";
            mod_path = sPath + "\\.minecraft\\mods";
            version_path = sPath + "\\.minecraft\\versions";

            Process.Start(mod_path);
        }

        private void button2_Click(object sender, EventArgs e)
        {
            System.IO.DirectoryInfo di = new DirectoryInfo(path2);

            foreach(FileInfo file in di.GetFiles())
            {
                file.Delete();
            }

        }

        private void resetGitTemporariesToolStripMenuItem_Click(object sender, EventArgs e)
        {
            create_appdata_mods();
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
