using Microsoft.Win32;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;
using System.Collections;


namespace Hypermc
{
    public partial class Form1 : Form
    {
        public void create_appdata_mods()
        {
            String sPath = Environment.GetFolderPath(Environment.SpecialFolder.ApplicationData);
            var process = new System.Diagnostics.Process();
            var startInfo = new System.Diagnostics.ProcessStartInfo
            {
                WindowStyle = System.Diagnostics.ProcessWindowStyle.Normal,
                FileName = "cmd.exe",
                RedirectStandardInput = true,
                UseShellExecute = false
            };

            process.StartInfo = startInfo;
            process.Start();
            process.StandardInput.WriteLine("cd " + sPath + " && mkdir Hypermc && cd Hypermc && git clone https://github.com/HyperMC-mods/mod-pack.git");

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
                Process.Start("git", make_cmd);
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
            copy_to_mod_folder("../../mods/","OptiFine_1.16.5.jar");
        }

        private void journeymap_download_Click(object sender, EventArgs e)
        {
            string path = Directory.GetCurrentDirectory();
            Console.WriteLine(path);
            copy_to_mod_folder("../../mods/","journeymap-1.16.5.jar");
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
            copy_to_mod_folder("../../mods/","jei_1.12.2-4.16.jar");
        }

        private void biomes_o_plenty_download_Click(object sender, EventArgs e)
        {
            string path = Directory.GetCurrentDirectory();
            Console.WriteLine(path);
            copy_to_mod_folder("../../mods/","BiomesOPlenty-1.16.5-universal.jar");
        }

        private void crate_download_Click(object sender, EventArgs e)
        {
            string path = Directory.GetCurrentDirectory();
            Console.WriteLine(path);
            copy_to_mod_folder("../../mods/", "create-mc1.16.5.jar");
        }

        private void reload_btn_Click(object sender, EventArgs e)
        {
            Form1_Load(null, EventArgs.Empty);
        }
    }
}
