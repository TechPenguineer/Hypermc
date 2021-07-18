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
using System.Linq;
using System.IO;
using ForgedCurse;

namespace HyperMC
{
    public partial class main_frame : Form
    {
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

        }

        private void main_frame_Load(object sender, EventArgs e)
        {
            ForgeClient client = new ForgeClient();
            AddonSearchData addonSearchData = client.SearchAddons();
        }
    }
}
