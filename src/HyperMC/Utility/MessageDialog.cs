using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Hypermc.Utility
{
	internal static class MessageDialog
	{
		internal static DialogResult Exclaim(string message, string? caption = null, MessageBoxButtons buttons = MessageBoxButtons.OK, IWin32Window? owner = null)
		{
			return MessageBox.Show(owner, message, caption, buttons);
		}
	}
}
