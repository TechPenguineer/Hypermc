using ForgedCurse.Json;
using HyperMC.CurseForge;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace HyperMC
{
    public partial class MainFrame : Form
    {
        private readonly IForgeClient _forgeClient;
        private Addon[] _addons;
        public MainFrame()
        {
            InitializeComponent();
            _forgeClient = new ForgeClient();
        }
        public void FetchMods()
        {

        }

        private void OpenBrowser(string url) => Process.Start(new ProcessStartInfo(url) { UseShellExecute = true });


        private void githubToolStripMenuItem_Click(object sender, EventArgs e) => OpenBrowser("https://github.com/TechPenguineer/Hypermc");

        private async void MainFrame_Load(object sender, EventArgs e)
        {
            _addons = await _forgeClient.SearchForMod();
        }
    }
}

