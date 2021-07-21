using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Hypermc.Utility;

namespace Hypermc.UI.Views
{
	public sealed class ControlView : IView
	{
		private Control[] _controls;

		public ControlView(Control control)
		{
			_controls = Utils.PopChildControls(control);
		}

		public event IView.ViewMessageCallback OnMessage;

		public Control[] ShowView(object? data = null)
		{
			SendMessage(IView.MSG_SHOW);
			return _controls;
		}

		public bool HideView(Control[] controls)
		{
			_controls = controls;
			SendMessage(IView.MSG_HIDE);
			return false;
		}

		public void DestroyView()
		{
		}

		private void SendMessage(int msg)
		{
			OnMessage?.Invoke(this, msg);
		}
	}
}
