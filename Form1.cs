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

        public void get_env_var()
        {
            string path;
            path = @"%Appdata%\roaming\.minecraft\mods";
            Environment.SetEnvironmentVariable("HyperMc", path);
        }
        private void Form1_Load(object sender, EventArgs e)
        {
            string getEnv = Environment.GetEnvironmentVariable("HyperMc");
            Console.WriteLine(getEnv);
        }

        private void launch_btn_Click(object sender, EventArgs e)
        {

        }
    }
}
