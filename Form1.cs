using System;
using System.Windows.Forms;
using System.Diagnostics;
using ForgedCurse.Utility;
using ForgedCurse.Enumeration;
using ForgedCurse;
namespace HyperMC
{
    public partial class main_frame : Form
    {

        public void fetch_mods()
        {
            ForgeClient client = new ForgeClient();

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

        }

        private void main_frame_Load(object sender, EventArgs e)
        {
            
        }
    }
}
