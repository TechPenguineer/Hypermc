using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Hypermc.UI.UserControls
{
	public partial class ModpackBox : UserControl
	{
		[Category("Appearance")]
		[DisplayName("Modpack Thumbnail")]
		[Description("The image to display")]
		public Image Thumbnail { get => pcb_Thumbnail.Image; set => pcb_Thumbnail.Image = value; }

		[Category("Appearance")]
		[DisplayName("Thumbnail Size Mode")]
		[Description("How to display the image")]
		public PictureBoxSizeMode SizeMode { get => pcb_Thumbnail.SizeMode; set => pcb_Thumbnail.SizeMode = value; }

		public ModpackBox()
		{
			InitializeComponent();
		}

		private void Pcb_Thumbnail_Click(object sender, EventArgs e)
		{
			OnClick(e);
		}
	}
}
