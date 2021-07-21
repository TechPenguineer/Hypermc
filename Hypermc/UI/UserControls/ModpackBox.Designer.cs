
namespace Hypermc.UI.UserControls
{
	partial class ModpackBox
	{
		/// <summary> 
		/// Required designer variable.
		/// </summary>
		private System.ComponentModel.IContainer components = null;

		/// <summary> 
		/// Clean up any resources being used.
		/// </summary>
		/// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
		protected override void Dispose(bool disposing)
		{
			if (disposing && (components != null))
			{
				components.Dispose();
			}
			base.Dispose(disposing);
		}

		#region Component Designer generated code

		/// <summary> 
		/// Required method for Designer support - do not modify 
		/// the contents of this method with the code editor.
		/// </summary>
		private void InitializeComponent()
		{
			this.pcb_Thumbnail = new System.Windows.Forms.PictureBox();
			((System.ComponentModel.ISupportInitialize)(this.pcb_Thumbnail)).BeginInit();
			this.SuspendLayout();
			// 
			// pcb_Thumbnail
			// 
			this.pcb_Thumbnail.Dock = System.Windows.Forms.DockStyle.Fill;
			this.pcb_Thumbnail.Location = new System.Drawing.Point(0, 0);
			this.pcb_Thumbnail.Name = "pcb_Thumbnail";
			this.pcb_Thumbnail.Size = new System.Drawing.Size(152, 95);
			this.pcb_Thumbnail.TabIndex = 0;
			this.pcb_Thumbnail.TabStop = false;
			this.pcb_Thumbnail.Click += new System.EventHandler(this.Pcb_Thumbnail_Click);
			// 
			// ModpackBox
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.Controls.Add(this.pcb_Thumbnail);
			this.Margin = new System.Windows.Forms.Padding(25);
			this.Name = "ModpackBox";
			this.Size = new System.Drawing.Size(152, 95);
			((System.ComponentModel.ISupportInitialize)(this.pcb_Thumbnail)).EndInit();
			this.ResumeLayout(false);

		}

		#endregion

		private System.Windows.Forms.PictureBox pcb_Thumbnail;
	}
}
