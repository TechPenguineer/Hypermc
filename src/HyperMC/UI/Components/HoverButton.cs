using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Diagnostics;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Hypermc.UI.Components
{
	public class HoverButton : Button
	{
		private Color? _beforeForeColor;
		private Color? _beforeBackColor;

		[Category("Appearance")]
		[DisplayName("Hover Background Color")]
		[Description("Changes the buttons background color to this when hovered on with cursor")]
		public Color HoverBackColor { get; set; }

		[Category("Appearance")]
		[DisplayName("Hover Foreground Color")]
		[Description("Changes the buttons foreground color to this when hovered on with cursor")]
		public Color HoverForeColor { get; set; }

		public HoverButton()
		{
			FlatStyle = FlatStyle.Flat;
			FlatAppearance.BorderSize = 0;
		}

		protected override void OnMouseEnter(EventArgs e)
		{
			base.OnMouseEnter(e);

			if (HoverForeColor != default)
			{
				_beforeForeColor = ForeColor;
				ForeColor = HoverForeColor;
			}

			if (HoverBackColor != default)
			{
				_beforeBackColor = BackColor;
				BackColor = HoverBackColor;
			}
		}

		protected override void OnMouseLeave(EventArgs e)
		{
			base.OnMouseLeave(e);

			if (_beforeForeColor.HasValue)
			{
				ForeColor = _beforeForeColor.Value;
				_beforeForeColor = null;
			}
			if (_beforeBackColor.HasValue)
			{
				BackColor = _beforeBackColor.Value;
				_beforeBackColor = null;
			}
		}
	}
}
