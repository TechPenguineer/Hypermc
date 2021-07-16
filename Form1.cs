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
        public Form1()
        {
            InitializeComponent();
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


        public static void Form1_Load(object sender, EventArgs e)
        {
            string mod_path, version_path, version_compatible;
            version_compatible = "Forge 1.16.5";
            mod_path = @"%Appdata%\roaming\.minecraft\mods";
            version_path = @"%Appdata%\roaming\.minecraft\versions";

            if (!Directory.Exists(version_compatible)) 
            {
                MessageBox.Show("Looks like you dont have Forge version 1.16.5 installed! Please make sure to install it or else this application will not work", "Incompatible Version", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

        }

        private void launch_btn_Click(object sender, EventArgs e)
        {

        }
    }
}
