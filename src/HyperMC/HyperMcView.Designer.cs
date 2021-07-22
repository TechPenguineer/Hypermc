
using System;

namespace Hypermc
{
	public partial class HyperMcView
	{
		/// <summary>
		///  Required designer variable.
		/// </summary>
		private System.ComponentModel.IContainer components = null;

		/// <summary>
		///  Clean up any resources being used.
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
            this.dpnl_Top = new Hypermc.UI.Components.DraggablePanel();
            this.label1 = new System.Windows.Forms.Label();
            this.pcb_Icon = new System.Windows.Forms.PictureBox();
            this.tlpnl_TopButtons = new System.Windows.Forms.TableLayoutPanel();
            this.hbtn_Minimize = new Hypermc.UI.Components.HoverButton();
            this.hbtn_Close = new Hypermc.UI.Components.HoverButton();
            this.hbtn_Options = new Hypermc.UI.Components.HoverButton();
            this.hbtn_Maximize = new Hypermc.UI.Components.HoverButton();
            this.cpy_right = new System.Windows.Forms.Label();
            this.pnl_MainArea = new System.Windows.Forms.Panel();
            this.panel1 = new System.Windows.Forms.Panel();
            this.hbtn_CreateModpack = new Hypermc.UI.Components.HoverButton();
            this.flpnl_Modpacks = new System.Windows.Forms.FlowLayoutPanel();
            this.hoverButton1 = new Hypermc.UI.Components.HoverButton();
            this.dpnl_Top.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pcb_Icon)).BeginInit();
            this.tlpnl_TopButtons.SuspendLayout();
            this.pnl_MainArea.SuspendLayout();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // dpnl_Top
            // 
            this.dpnl_Top.BackColor = System.Drawing.Color.White;
            this.dpnl_Top.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.dpnl_Top.Controls.Add(this.label1);
            this.dpnl_Top.Controls.Add(this.pcb_Icon);
            this.dpnl_Top.Controls.Add(this.tlpnl_TopButtons);
            this.dpnl_Top.Dock = System.Windows.Forms.DockStyle.Top;
            this.dpnl_Top.DragControl = this;
            this.dpnl_Top.Location = new System.Drawing.Point(0, 0);
            this.dpnl_Top.Margin = new System.Windows.Forms.Padding(0);
            this.dpnl_Top.Name = "dpnl_Top";
            this.dpnl_Top.Size = new System.Drawing.Size(1082, 40);
            this.dpnl_Top.TabIndex = 2;
            // 
            // label1
            // 
            this.label1.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Tai Le", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label1.Location = new System.Drawing.Point(537, 8);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(71, 19);
            this.label1.TabIndex = 1;
            this.label1.Text = "HyperMC";
            // 
            // pcb_Icon
            // 
            this.pcb_Icon.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.pcb_Icon.Image = global::Hypermc.Properties.Resources.HyperMc32;
            this.pcb_Icon.Location = new System.Drawing.Point(11, 1);
            this.pcb_Icon.Margin = new System.Windows.Forms.Padding(0);
            this.pcb_Icon.Name = "pcb_Icon";
            this.pcb_Icon.Size = new System.Drawing.Size(31, 32);
            this.pcb_Icon.TabIndex = 2;
            this.pcb_Icon.TabStop = false;
            // 
            // tlpnl_TopButtons
            // 
            this.tlpnl_TopButtons.ColumnCount = 5;
            this.tlpnl_TopButtons.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 46F));
            this.tlpnl_TopButtons.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 76F));
            this.tlpnl_TopButtons.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 46F));
            this.tlpnl_TopButtons.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 46F));
            this.tlpnl_TopButtons.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 46F));
            this.tlpnl_TopButtons.Controls.Add(this.hbtn_Minimize, 2, 0);
            this.tlpnl_TopButtons.Controls.Add(this.hbtn_Close, 4, 0);
            this.tlpnl_TopButtons.Controls.Add(this.hbtn_Options, 0, 0);
            this.tlpnl_TopButtons.Controls.Add(this.hbtn_Maximize, 3, 0);
            this.tlpnl_TopButtons.Dock = System.Windows.Forms.DockStyle.Right;
            this.tlpnl_TopButtons.Location = new System.Drawing.Point(820, 0);
            this.tlpnl_TopButtons.Margin = new System.Windows.Forms.Padding(0);
            this.tlpnl_TopButtons.Name = "tlpnl_TopButtons";
            this.tlpnl_TopButtons.RowCount = 1;
            this.tlpnl_TopButtons.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tlpnl_TopButtons.Size = new System.Drawing.Size(260, 38);
            this.tlpnl_TopButtons.TabIndex = 0;
            // 
            // hbtn_Minimize
            // 
            this.hbtn_Minimize.Dock = System.Windows.Forms.DockStyle.Right;
            this.hbtn_Minimize.FlatAppearance.BorderSize = 0;
            this.hbtn_Minimize.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.hbtn_Minimize.Font = new System.Drawing.Font("Bahnschrift Light SemiCondensed", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.hbtn_Minimize.HoverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.hbtn_Minimize.HoverForeColor = System.Drawing.Color.Empty;
            this.hbtn_Minimize.Location = new System.Drawing.Point(125, 3);
            this.hbtn_Minimize.Name = "hbtn_Minimize";
            this.hbtn_Minimize.Size = new System.Drawing.Size(40, 32);
            this.hbtn_Minimize.TabIndex = 2;
            this.hbtn_Minimize.Text = "-";
            this.hbtn_Minimize.UseVisualStyleBackColor = true;
            this.hbtn_Minimize.Click += new System.EventHandler(this.Hbtn_Minimize_Click);
            // 
            // hbtn_Close
            // 
            this.hbtn_Close.Dock = System.Windows.Forms.DockStyle.Right;
            this.hbtn_Close.FlatAppearance.BorderSize = 0;
            this.hbtn_Close.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.hbtn_Close.Font = new System.Drawing.Font("Bahnschrift Light", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.hbtn_Close.HoverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(232)))), ((int)(((byte)(17)))), ((int)(((byte)(35)))));
            this.hbtn_Close.HoverForeColor = System.Drawing.Color.White;
            this.hbtn_Close.Location = new System.Drawing.Point(217, 3);
            this.hbtn_Close.Name = "hbtn_Close";
            this.hbtn_Close.Size = new System.Drawing.Size(40, 32);
            this.hbtn_Close.TabIndex = 0;
            this.hbtn_Close.Text = "✕";
            this.hbtn_Close.UseVisualStyleBackColor = true;
            this.hbtn_Close.Click += new System.EventHandler(this.Hbtn_Close_Click);
            // 
            // hbtn_Options
            // 
            this.hbtn_Options.Dock = System.Windows.Forms.DockStyle.Right;
            this.hbtn_Options.FlatAppearance.BorderSize = 0;
            this.hbtn_Options.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.hbtn_Options.Font = new System.Drawing.Font("Bahnschrift Light", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.hbtn_Options.HoverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.hbtn_Options.HoverForeColor = System.Drawing.Color.Empty;
            this.hbtn_Options.Location = new System.Drawing.Point(3, 3);
            this.hbtn_Options.Name = "hbtn_Options";
            this.hbtn_Options.Size = new System.Drawing.Size(40, 32);
            this.hbtn_Options.TabIndex = 3;
            this.hbtn_Options.Text = "⚙";
            this.hbtn_Options.UseVisualStyleBackColor = true;
            this.hbtn_Options.Click += new System.EventHandler(this.Hbtn_Options_Click);
            // 
            // hbtn_Maximize
            // 
            this.hbtn_Maximize.Dock = System.Windows.Forms.DockStyle.Right;
            this.hbtn_Maximize.FlatAppearance.BorderSize = 0;
            this.hbtn_Maximize.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.hbtn_Maximize.Font = new System.Drawing.Font("Bahnschrift Light", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.hbtn_Maximize.HoverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.hbtn_Maximize.HoverForeColor = System.Drawing.Color.Empty;
            this.hbtn_Maximize.Location = new System.Drawing.Point(171, 3);
            this.hbtn_Maximize.Name = "hbtn_Maximize";
            this.hbtn_Maximize.Size = new System.Drawing.Size(40, 32);
            this.hbtn_Maximize.TabIndex = 1;
            this.hbtn_Maximize.Text = "▢";
            this.hbtn_Maximize.UseVisualStyleBackColor = true;
            this.hbtn_Maximize.Click += new System.EventHandler(this.Hbtn_Maximize_Click);
            // 
            // cpy_right
            // 
            this.cpy_right.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.cpy_right.AutoSize = true;
            this.cpy_right.Font = new System.Drawing.Font("Segoe UI Light", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.cpy_right.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.cpy_right.Location = new System.Drawing.Point(9, 581);
            this.cpy_right.Name = "cpy_right";
            this.cpy_right.Size = new System.Drawing.Size(230, 13);
            this.cpy_right.TabIndex = 5;
            this.cpy_right.Text = "© 2021 - Tech Penguin INC.  All Rights Reserved";
            // 
            // pnl_MainArea
            // 
            this.pnl_MainArea.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.pnl_MainArea.Controls.Add(this.panel1);
            this.pnl_MainArea.Controls.Add(this.flpnl_Modpacks);
            this.pnl_MainArea.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pnl_MainArea.Location = new System.Drawing.Point(0, 40);
            this.pnl_MainArea.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.pnl_MainArea.Name = "pnl_MainArea";
            this.pnl_MainArea.Size = new System.Drawing.Size(1082, 604);
            this.pnl_MainArea.TabIndex = 4;
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.panel1.Controls.Add(this.hoverButton1);
            this.panel1.Controls.Add(this.hbtn_CreateModpack);
            this.panel1.Controls.Add(this.cpy_right);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Right;
            this.panel1.Location = new System.Drawing.Point(830, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(250, 602);
            this.panel1.TabIndex = 2;
            // 
            // hbtn_CreateModpack
            // 
            this.hbtn_CreateModpack.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.hbtn_CreateModpack.FlatAppearance.BorderSize = 0;
            this.hbtn_CreateModpack.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.hbtn_CreateModpack.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.hbtn_CreateModpack.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.hbtn_CreateModpack.HoverBackColor = System.Drawing.SystemColors.WindowFrame;
            this.hbtn_CreateModpack.HoverForeColor = System.Drawing.Color.Empty;
            this.hbtn_CreateModpack.Location = new System.Drawing.Point(27, 19);
            this.hbtn_CreateModpack.Name = "hbtn_CreateModpack";
            this.hbtn_CreateModpack.Size = new System.Drawing.Size(196, 59);
            this.hbtn_CreateModpack.TabIndex = 0;
            this.hbtn_CreateModpack.Text = "+ ADD MODPACK";
            this.hbtn_CreateModpack.UseVisualStyleBackColor = false;
            this.hbtn_CreateModpack.Click += new System.EventHandler(this.Hbtn_CreateModpack_Click);
            // 
            // flpnl_Modpacks
            // 
            this.flpnl_Modpacks.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left)));
            this.flpnl_Modpacks.Location = new System.Drawing.Point(-1, -1);
            this.flpnl_Modpacks.Name = "flpnl_Modpacks";
            this.flpnl_Modpacks.Padding = new System.Windows.Forms.Padding(10);
            this.flpnl_Modpacks.Size = new System.Drawing.Size(819, 542);
            this.flpnl_Modpacks.TabIndex = 1;
            // 
            // hoverButton1
            // 
            this.hoverButton1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.hoverButton1.FlatAppearance.BorderSize = 0;
            this.hoverButton1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.hoverButton1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.hoverButton1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.hoverButton1.HoverBackColor = System.Drawing.SystemColors.WindowFrame;
            this.hoverButton1.HoverForeColor = System.Drawing.Color.Empty;
            this.hoverButton1.Location = new System.Drawing.Point(27, 111);
            this.hoverButton1.Name = "hoverButton1";
            this.hoverButton1.Size = new System.Drawing.Size(196, 59);
            this.hoverButton1.TabIndex = 6;
            this.hoverButton1.Text = "Settings";
            this.hoverButton1.UseVisualStyleBackColor = false;
            // 
            // HyperMcView
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 18F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(48)))), ((int)(((byte)(43)))), ((int)(((byte)(39)))));
            this.ClientSize = new System.Drawing.Size(1082, 644);
            this.Controls.Add(this.pnl_MainArea);
            this.Controls.Add(this.dpnl_Top);
            this.Font = new System.Drawing.Font("Bahnschrift SemiBold", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Margin = new System.Windows.Forms.Padding(5, 4, 5, 4);
            this.Name = "HyperMcView";
            this.Text = "HyperMC";
            this.Load += new System.EventHandler(this.HyperMcView_Load);
            this.dpnl_Top.ResumeLayout(false);
            this.dpnl_Top.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pcb_Icon)).EndInit();
            this.tlpnl_TopButtons.ResumeLayout(false);
            this.pnl_MainArea.ResumeLayout(false);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.ResumeLayout(false);

        }

		#endregion
		private UI.Components.DraggablePanel dpnl_Top;
		private System.Windows.Forms.Panel pnl_MainArea;
		private UI.Components.HoverButton hbtn_Minimize;
		private UI.Components.HoverButton hbtn_Maximize;
		private UI.Components.HoverButton hbtn_Close;
		private UI.Components.HoverButton hbtn_Options;
		private System.Windows.Forms.TableLayoutPanel tlpnl_TopButtons;
		private System.Windows.Forms.FlowLayoutPanel flpnl_Modpacks;
		private UI.Components.HoverButton hbtn_CreateModpack;
		private System.Windows.Forms.PictureBox pcb_Icon;
		private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label cpy_right;
        private System.Windows.Forms.Panel panel1;
        private UI.Components.HoverButton hoverButton1;
    }
}

