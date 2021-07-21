
namespace Hypermc.UI.Views
{
	partial class SettingView
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

		#region Windows Form Designer generated code

		/// <summary>
		/// Required method for Designer support - do not modify
		/// the contents of this method with the code editor.
		/// </summary>
		private void InitializeComponent()
		{
            this.pnl_AlignPanel = new System.Windows.Forms.Panel();
            this.hbtn_Back = new Hypermc.UI.Components.HoverButton();
            this.lbl_Options = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            this.label1 = new System.Windows.Forms.Label();
            this.game_path = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.pnl_AlignPanel.SuspendLayout();
            this.SuspendLayout();
            // 
            // pnl_AlignPanel
            // 
            this.pnl_AlignPanel.BackColor = System.Drawing.Color.White;
            this.pnl_AlignPanel.Controls.Add(this.label2);
            this.pnl_AlignPanel.Controls.Add(this.game_path);
            this.pnl_AlignPanel.Controls.Add(this.label1);
            this.pnl_AlignPanel.Controls.Add(this.panel1);
            this.pnl_AlignPanel.Controls.Add(this.hbtn_Back);
            this.pnl_AlignPanel.Controls.Add(this.lbl_Options);
            this.pnl_AlignPanel.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pnl_AlignPanel.Location = new System.Drawing.Point(0, 0);
            this.pnl_AlignPanel.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.pnl_AlignPanel.Name = "pnl_AlignPanel";
            this.pnl_AlignPanel.Size = new System.Drawing.Size(1237, 816);
            this.pnl_AlignPanel.TabIndex = 0;
            this.pnl_AlignPanel.Paint += new System.Windows.Forms.PaintEventHandler(this.pnl_AlignPanel_Paint);
            // 
            // hbtn_Back
            // 
            this.hbtn_Back.BackColor = System.Drawing.Color.White;
            this.hbtn_Back.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.hbtn_Back.HoverBackColor = System.Drawing.Color.Empty;
            this.hbtn_Back.HoverForeColor = System.Drawing.Color.Empty;
            this.hbtn_Back.Location = new System.Drawing.Point(3, 4);
            this.hbtn_Back.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.hbtn_Back.Name = "hbtn_Back";
            this.hbtn_Back.Size = new System.Drawing.Size(86, 31);
            this.hbtn_Back.TabIndex = 1;
            this.hbtn_Back.Text = "<-";
            this.hbtn_Back.UseVisualStyleBackColor = false;
            this.hbtn_Back.Click += new System.EventHandler(this.Hbtn_Back_Click);
            // 
            // lbl_Options
            // 
            this.lbl_Options.AutoSize = true;
            this.lbl_Options.Font = new System.Drawing.Font("Bahnschrift Light SemiCondensed", 18F, System.Drawing.FontStyle.Underline, System.Drawing.GraphicsUnit.Point);
            this.lbl_Options.Location = new System.Drawing.Point(482, 34);
            this.lbl_Options.Name = "lbl_Options";
            this.lbl_Options.Size = new System.Drawing.Size(215, 36);
            this.lbl_Options.TabIndex = 0;
            this.lbl_Options.Text = "HyperMC Options";
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.DimGray;
            this.panel1.Location = new System.Drawing.Point(251, 90);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(662, 10);
            this.panel1.TabIndex = 2;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Bahnschrift Light SemiCondensed", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label1.Location = new System.Drawing.Point(251, 121);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(81, 36);
            this.label1.TabIndex = 3;
            this.label1.Text = "Paths";
            // 
            // game_path
            // 
            this.game_path.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.game_path.Location = new System.Drawing.Point(439, 160);
            this.game_path.Name = "game_path";
            this.game_path.Size = new System.Drawing.Size(474, 27);
            this.game_path.TabIndex = 4;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Bahnschrift Light SemiCondensed", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label2.Location = new System.Drawing.Point(352, 151);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(81, 36);
            this.label2.TabIndex = 5;
            this.label2.Text = "Game";
            this.label2.Click += new System.EventHandler(this.label2_Click);
            // 
            // SettingView
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1237, 816);
            this.Controls.Add(this.pnl_AlignPanel);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.Name = "SettingView";
            this.Text = "SettingView";
            this.pnl_AlignPanel.ResumeLayout(false);
            this.pnl_AlignPanel.PerformLayout();
            this.ResumeLayout(false);

		}

		#endregion

		private System.Windows.Forms.Panel pnl_AlignPanel;
		private System.Windows.Forms.Label lbl_Options;
		private Components.HoverButton hbtn_Back;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Panel panel1;
        public System.Windows.Forms.TextBox game_path;
    }
}