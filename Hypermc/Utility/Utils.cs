using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Drawing;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Hypermc.UI.Views;

namespace Hypermc.Utility
{
	internal static class Utils
	{
		internal static Point PointAdd(Point a, Point b) => new(a.X + b.X, a.Y + b.Y);

		internal static Point PointSub(Point a, Point b) => new(a.X - b.X, a.Y - b.Y);

		internal static void NotImplAlert(string? what = null)
		{
			MessageBox.Show($"Not Implemented{(what is not null ? " -> " + what : string.Empty)}",
				"Error",
				MessageBoxButtons.OK,
				MessageBoxIcon.Warning,
				MessageBoxDefaultButton.Button1);
		}

		internal static void OpenBrowser(string url)
		{
			Process.Start(new ProcessStartInfo("cmd", $"/c start {url}")
			{
				CreateNoWindow = true
			});
		}

		internal static Control[] PopChildControls(Control parent)
		{
			Control[] controls = new Control[parent.Controls.Count];
			for (int i = 0; i < controls.Length; i++)
			{
				controls[i] = parent.Controls[0];
				parent.Controls.RemoveAt(0);
			}

			return controls;
		}

		internal static void ReturnChildControlsBasic(Control owner, Control parent)
		{
			parent.Controls.AddRange(PopChildControls(owner));
		}
	}
}
