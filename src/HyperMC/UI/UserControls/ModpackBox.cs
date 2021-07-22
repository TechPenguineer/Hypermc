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

		[Browsable(false)]
		new public string Name {
			get {
				return base.Name;
			}
			set {
				base.Name = value;
				lbl_Name.Text = value;
				lbl_forge_version.Text = $"Forge Version: TBD";
			}
		}

		/*[Category("Appearance")]
		[DisplayName("Modpack Name")]
		[Description("The name of the modpack")]
		public string? ModpackName { get; set; }*/

		public ModpackBox()
		{
			InitializeComponent();
		}

		private void Pcb_Thumbnail_Click(object sender, EventArgs e)
		{
			OnClick(e);
		}

        private void lbl_Name_Click(object sender, EventArgs e)
        {

        }

        private void lbl_Name_Click_1(object sender, EventArgs e)
        {

        }
    }
}
