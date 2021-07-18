using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Diagnostics;
using LibGit2Sharp;
using ForgedCurse;
using ForgedCurse.Utility;
using System.Linq;
using System.IO;

 namespace HyperMC
{
    public partial class main_frame : Form
    {
        public void getAddonById(string id)
        {
            ForgeClient client = new ForgeClient();
            dynamic addon = client.GetAddon(id);
            Console.WriteLine(addon.Authors.First().Name);
        }
        private void OpenBrowser(string url) => Process.Start(new ProcessStartInfo("cmd", $"/c start {url}") { CreateNoWindow = true });

        public main_frame()
        {
            InitializeComponent();
        }

        private void helpToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void toolStripMenuItem1_Click(object sender, EventArgs e)
        {

        }

        private void githubToolStripMenuItem_Click(object sender, EventArgs e) => OpenBrowser("https://github.com/TechPenguineer/Hypermc");

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            string id_in = gabi_in.Text;

            getAddonById(id_in);
        }
    }
}
