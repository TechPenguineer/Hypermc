using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Hypermc.Utility;

namespace Hypermc.UI.Views
{
	public partial class SettingView : Form, IView
	{
		public SettingView()
		{
			InitializeComponent();
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
	}
}
