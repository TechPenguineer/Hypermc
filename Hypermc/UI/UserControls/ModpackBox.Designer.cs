
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
			this.lbl_Name = new System.Windows.Forms.Label();
			((System.ComponentModel.ISupportInitialize)(this.pcb_Thumbnail)).BeginInit();
			this.SuspendLayout();
			// 
			// pcb_Thumbnail
			// 
			this.pcb_Thumbnail.Dock = System.Windows.Forms.DockStyle.Top;
			this.pcb_Thumbnail.Location = new System.Drawing.Point(0, 0);
			this.pcb_Thumbnail.Name = "pcb_Thumbnail";
			this.pcb_Thumbnail.Size = new System.Drawing.Size(190, 100);
			this.pcb_Thumbnail.TabIndex = 0;
			this.pcb_Thumbnail.TabStop = false;
			this.pcb_Thumbnail.Click += new System.EventHandler(this.Pcb_Thumbnail_Click);
			// 
			// lbl_Name
			// 
			this.lbl_Name.Dock = System.Windows.Forms.DockStyle.Fill;
			this.lbl_Name.Font = new System.Drawing.Font("Segoe UI Semilight", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
			this.lbl_Name.ForeColor = System.Drawing.Color.White;
			this.lbl_Name.Location = new System.Drawing.Point(0, 100);
			this.lbl_Name.Name = "lbl_Name";
			this.lbl_Name.Size = new System.Drawing.Size(190, 27);
			this.lbl_Name.TabIndex = 1;
			this.lbl_Name.Text = "#NAME";
			this.lbl_Name.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
			// 
			// ModpackBox
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
			this.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
			this.Controls.Add(this.lbl_Name);
			this.Controls.Add(this.pcb_Thumbnail);
			this.Margin = new System.Windows.Forms.Padding(25);
			this.Name = "ModpackBox";
			this.Size = new System.Drawing.Size(190, 127);
			((System.ComponentModel.ISupportInitialize)(this.pcb_Thumbnail)).EndInit();
			this.ResumeLayout(false);

		}

		#endregion

		private System.Windows.Forms.PictureBox pcb_Thumbnail;
		private System.Windows.Forms.Label lbl_Name;
	}
}
