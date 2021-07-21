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
using ForgedCurse;
using Hypermc.UI.Views;
using Hypermc.Utility;

namespace Hypermc
{
	public partial class HyperMcView : Form, IViewHost
	{
		private readonly ForgeClient _forge;

		public HyperMcView()
		{
			InitializeComponent();
			_forge = new ForgeClient();
		}

		private void HyperMcView_Load(object sender, EventArgs e)
		{
			_defaultView = new ControlView(pnl_MainArea);
			SetView(_defaultView);
		}

		private void Btn_DownloadAddon_Click(object sender, EventArgs e)
        {
			string idInput = "";//txb_AddonId.Text;
			if (!int.TryParse(idInput, out int id))
			{
				MessageBox.Show("Invalid Addon Identifier");
				return;
			}

			Utils.NotImplAlert(nameof(Btn_DownloadAddon_Click));
		}

		private void Panel2_Paint(object sender, PaintEventArgs e)
		{
		}

		#region Top Panel

		#region Buttons

		#region Close Button

		private void Hbtn_Close_Click(object sender, EventArgs e)
		{
			Close();
		}

		#endregion Close Button

		#region Maximize Button

		private void Hbtn_Maximize_Click(object sender, EventArgs e)
		{
			if (WindowState == FormWindowState.Maximized)
			{
				WindowState = FormWindowState.Normal;
				hbtn_Maximize.Text = "\u25A2"; // ▢
			}
			else
			{
				WindowState = FormWindowState.Maximized;
				hbtn_Maximize.Text = "\u25F1"; // ◱
			}
		}

		#endregion Maximize Button

		#region Minimize Button

		private void Hbtn_Minimize_Click(object sender, EventArgs e)
		{
			WindowState = FormWindowState.Minimized;
		}

		#endregion Minimize Button

		#region Options Button

		private void Hbtn_Options_Click(object sender, EventArgs e)
		{
			//Utils.NotImplAlert("Options Menu");
			SetView(new SettingView());
		}

		#endregion Minimize Button

		#endregion Buttons

		#endregion Top Panel

		#region View Hosting

		private IView _defaultView;
		private IView? _view;
		private IView? _viewPrev;

		public void SetView(IView view, object? data = null)
		{
			if (_view is not null)
			{
				_view.HideView(Utils.PopChildControls(pnl_MainArea));
				_view.OnMessage -= View_OnMessage;
				_viewPrev = _view;
			}

			view.OnMessage += View_OnMessage;

			_view = view;
			Control[] controls = view.ShowView(data);
			pnl_MainArea.Controls.AddRange(controls);
		}

		private void View_OnMessage(IView view, int message)
		{
			if (message == IView.MSG_GO_BACK && _viewPrev is not null)
			{
				SetView(_viewPrev, null);
			}
		}

		#endregion View Hosting
	}
}
