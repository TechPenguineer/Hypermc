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
using ForgedCurse;
namespace Hypermc.UI.Dialogs
{
	public partial class CreateModpackDialog : Form
	{
		public ModpackData? Data { get; private set; }

		public CreateModpackDialog()
		{
			InitializeComponent();

			ForgeClient client = new ForgeClient();

			List<dynamic> supported_versions;
			dynamic versions = client.Minecraft.RetrieveGameVersions();
			Console.WriteLine(versions);
			cmbx_McVersion.Items.Add(versions);
		}

		private void Hbtn_Ok_Click(object sender, EventArgs e)
		{
			if (string.IsNullOrWhiteSpace(txb_Name.Text))
			{
				MessageDialog.Exclaim("Please specify a modpack name", "Warning", owner: this);
				return;
			}

			Data = new ModpackData(txb_Name.Text, Properties.Resources.DefaultModpackImage, null);
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
    }
}
