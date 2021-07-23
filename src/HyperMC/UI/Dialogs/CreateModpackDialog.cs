using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Hypermc.Data;
using Hypermc.Utility;
using HyperMC.CurseForge;

namespace Hypermc.UI.Dialogs
{
    public partial class CreateModpackDialog : Form
    {


        private readonly IForgeClient _forgeClient;

        public ModpackData? Data { get; private set; }
        public ModpackData? DataForge { get; private set; }


        public CreateModpackDialog(IForgeClient forgeClient)
        {
            InitializeComponent();

            _forgeClient = forgeClient;
            Load += CreateModpackDialog_Load;

            List<dynamic> supported_versions;
        }

        private async void CreateModpackDialog_Load(object? sender, EventArgs e)
        {
            var versions = await _forgeClient.GetMinecraftVersions();

            Console.WriteLine(versions);
            cmbx_McVersion.DataSource = versions;
            cmbx_McVersion.DisplayMember = "VersionString";
        }





        private void Hbtn_Ok_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(txb_Name.Text))
            {
                MessageDialog.Exclaim("Please specify a modpack name", "Warning", owner: this);
                return;
            }
            if (string.IsNullOrWhiteSpace(cmbx_FmlVersion.Text))
            {
                MessageDialog.Exclaim("Please specify a Forge version", "Warning", owner: this);
                return;
            }
            if (string.IsNullOrWhiteSpace(cmbx_McVersion.Text))
            {
                MessageDialog.Exclaim("Please specify a Minecraft version", "Warning", owner: this);
                return;
            }

            Data = new ModpackData(txb_Name.Text, "", null);
            DataForge = new ModpackData(cmbx_FmlVersion.Text, "", null);
            DialogResult = DialogResult.OK;
            Close();
        }

        private void Hbtn_Cancel_Click(object sender, EventArgs e)
        {
            DialogResult = DialogResult.Cancel;
            Close();
        }

        private void cmbx_McVersion_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void cpy_right_Click(object sender, EventArgs e)
        {

        }
    }
}
