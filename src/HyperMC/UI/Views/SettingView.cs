using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Hypermc.Settings;
using Hypermc.Utility;

namespace Hypermc.UI.Views
{
	public partial class SettingView : Form, IView
	{
        private readonly IUserSettings _settings;

        public SettingView(IUserSettings settings)
		{
			InitializeComponent();
            _settings = settings;
			game_path.Text = settings.MinecraftPath;
			modPackPath.Text = settings.ModPacksPath;
        }

		public event IView.ViewMessageCallback OnMessage;

		public Control[] ShowView(object? _ = null)
		{
			SendMessage(IView.MSG_SHOW);
			return Utils.PopChildControls(this);
		}

		public bool HideView(Control[] controls)
		{
			Controls.AddRange(controls);
			SendMessage(IView.MSG_HIDE);

			return true;
		}

		public void DestroyView()
		{
			SendMessage(IView.MSG_DESTROY);
			Close();
		}

		private void SendMessage(int msg)
		{
			OnMessage?.Invoke(this, msg);
		}

		private void Hbtn_Back_Click(object sender, EventArgs e)
		{
			SendMessage(IView.MSG_GO_BACK);
			Hide();
		}

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void pnl_AlignPanel_Paint(object sender, PaintEventArgs e)
        {

        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
