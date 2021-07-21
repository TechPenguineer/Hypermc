using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Hypermc.UI.Views
{
	public interface IView
	{
		public const int MSG_SHOW = 0x0;
		public const int MSG_HIDE = 0x1;
		public const int MSG_DESTROY = 0x2;
		public const int MSG_GO_BACK = 0x3;

		public Control[] ShowView(object? data = null);
		public bool HideView(Control[] controls);
		public void DestroyView();

		public event ViewMessageCallback OnMessage;

		public delegate void ViewMessageCallback(IView view, int message);
	}
}
