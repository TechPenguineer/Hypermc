
namespace Hypermc.UI.Dialogs
{
	partial class CreateModpackDialog
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
            this.txb_Name = new System.Windows.Forms.TextBox();
            this.pnl_AlignPanel = new System.Windows.Forms.Panel();
            this.cmbx_FmlVersion = new System.Windows.Forms.ComboBox();
            this.cmbx_McVersion = new System.Windows.Forms.ComboBox();
            this.lbl_FmlVersion = new System.Windows.Forms.Label();
            this.lbl_McVersion = new System.Windows.Forms.Label();
            this.lbl_Name = new System.Windows.Forms.Label();
            this.hbtn_Cancel = new Hypermc.UI.Components.HoverButton();
            this.hbtn_Ok = new Hypermc.UI.Components.HoverButton();
            this.lbl_Caption = new System.Windows.Forms.Label();
            this.pnl_Top = new System.Windows.Forms.Panel();
            this.pnl_AlignPanel.SuspendLayout();
            this.pnl_Top.SuspendLayout();
            this.SuspendLayout();
            // 
            // txb_Name
            // 
            this.txb_Name.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.txb_Name.Font = new System.Drawing.Font("Segoe UI Light", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.txb_Name.Location = new System.Drawing.Point(217, 136);
            this.txb_Name.Margin = new System.Windows.Forms.Padding(5, 6, 5, 6);
            this.txb_Name.Name = "txb_Name";
            this.txb_Name.Size = new System.Drawing.Size(331, 42);
            this.txb_Name.TabIndex = 0;
            // 
            // pnl_AlignPanel
            // 
            this.pnl_AlignPanel.BackColor = System.Drawing.Color.DimGray;
            this.pnl_AlignPanel.Controls.Add(this.cmbx_FmlVersion);
            this.pnl_AlignPanel.Controls.Add(this.cmbx_McVersion);
            this.pnl_AlignPanel.Controls.Add(this.lbl_FmlVersion);
            this.pnl_AlignPanel.Controls.Add(this.lbl_McVersion);
            this.pnl_AlignPanel.Controls.Add(this.lbl_Name);
            this.pnl_AlignPanel.Controls.Add(this.hbtn_Cancel);
            this.pnl_AlignPanel.Controls.Add(this.hbtn_Ok);
            this.pnl_AlignPanel.Controls.Add(this.txb_Name);
            this.pnl_AlignPanel.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pnl_AlignPanel.Font = new System.Drawing.Font("Segoe UI Light", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.pnl_AlignPanel.Location = new System.Drawing.Point(0, 0);
            this.pnl_AlignPanel.Margin = new System.Windows.Forms.Padding(5, 6, 5, 6);
            this.pnl_AlignPanel.Name = "pnl_AlignPanel";
            this.pnl_AlignPanel.Padding = new System.Windows.Forms.Padding(16, 0, 0, 0);
            this.pnl_AlignPanel.Size = new System.Drawing.Size(598, 430);
            this.pnl_AlignPanel.TabIndex = 1;
            // 
            // cmbx_FmlVersion
            // 
            this.cmbx_FmlVersion.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.cmbx_FmlVersion.FormattingEnabled = true;
            this.cmbx_FmlVersion.Location = new System.Drawing.Point(217, 238);
            this.cmbx_FmlVersion.Name = "cmbx_FmlVersion";
            this.cmbx_FmlVersion.Size = new System.Drawing.Size(331, 44);
            this.cmbx_FmlVersion.TabIndex = 3;
            // 
            // cmbx_McVersion
            // 
            this.cmbx_McVersion.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.cmbx_McVersion.FormattingEnabled = true;
            this.cmbx_McVersion.Location = new System.Drawing.Point(217, 187);
            this.cmbx_McVersion.Name = "cmbx_McVersion";
            this.cmbx_McVersion.Size = new System.Drawing.Size(331, 44);
            this.cmbx_McVersion.TabIndex = 3;
            this.cmbx_McVersion.SelectedIndexChanged += new System.EventHandler(this.cmbx_McVersion_SelectedIndexChanged);
            // 
            // lbl_FmlVersion
            // 
            this.lbl_FmlVersion.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.lbl_FmlVersion.AutoSize = true;
            this.lbl_FmlVersion.Location = new System.Drawing.Point(0, 238);
            this.lbl_FmlVersion.Name = "lbl_FmlVersion";
            this.lbl_FmlVersion.Size = new System.Drawing.Size(170, 37);
            this.lbl_FmlVersion.TabIndex = 2;
            this.lbl_FmlVersion.Text = "Forge Version";
            // 
            // lbl_McVersion
            // 
            this.lbl_McVersion.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.lbl_McVersion.AutoSize = true;
            this.lbl_McVersion.Location = new System.Drawing.Point(0, 190);
            this.lbl_McVersion.Name = "lbl_McVersion";
            this.lbl_McVersion.Size = new System.Drawing.Size(211, 37);
            this.lbl_McVersion.TabIndex = 2;
            this.lbl_McVersion.Text = "Minecraft Version";
            // 
            // lbl_Name
            // 
            this.lbl_Name.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.lbl_Name.AutoSize = true;
            this.lbl_Name.Font = new System.Drawing.Font("Segoe UI Light", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.lbl_Name.Location = new System.Drawing.Point(0, 139);
            this.lbl_Name.Name = "lbl_Name";
            this.lbl_Name.Size = new System.Drawing.Size(196, 37);
            this.lbl_Name.TabIndex = 2;
            this.lbl_Name.Text = "Modpack Name";
            // 
            // hbtn_Cancel
            // 
            this.hbtn_Cancel.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.hbtn_Cancel.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.hbtn_Cancel.HoverBackColor = System.Drawing.Color.Empty;
            this.hbtn_Cancel.HoverForeColor = System.Drawing.Color.Empty;
            this.hbtn_Cancel.Location = new System.Drawing.Point(12, 376);
            this.hbtn_Cancel.Name = "hbtn_Cancel";
            this.hbtn_Cancel.Size = new System.Drawing.Size(103, 42);
            this.hbtn_Cancel.TabIndex = 1;
            this.hbtn_Cancel.Text = "Cancel";
            this.hbtn_Cancel.UseVisualStyleBackColor = true;
            this.hbtn_Cancel.Click += new System.EventHandler(this.Hbtn_Cancel_Click);
            // 
            // hbtn_Ok
            // 
            this.hbtn_Ok.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.hbtn_Ok.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.hbtn_Ok.HoverBackColor = System.Drawing.Color.Empty;
            this.hbtn_Ok.HoverForeColor = System.Drawing.Color.Empty;
            this.hbtn_Ok.Location = new System.Drawing.Point(483, 376);
            this.hbtn_Ok.Name = "hbtn_Ok";
            this.hbtn_Ok.Size = new System.Drawing.Size(103, 42);
            this.hbtn_Ok.TabIndex = 1;
            this.hbtn_Ok.Text = "OK";
            this.hbtn_Ok.UseVisualStyleBackColor = true;
            this.hbtn_Ok.Click += new System.EventHandler(this.Hbtn_Ok_Click);
            // 
            // lbl_Caption
            // 
            this.lbl_Caption.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.lbl_Caption.AutoSize = true;
            this.lbl_Caption.Font = new System.Drawing.Font("Segoe UI Semilight", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.lbl_Caption.Location = new System.Drawing.Point(21, 11);
            this.lbl_Caption.Margin = new System.Windows.Forms.Padding(5, 0, 5, 0);
            this.lbl_Caption.Name = "lbl_Caption";
            this.lbl_Caption.Size = new System.Drawing.Size(236, 37);
            this.lbl_Caption.TabIndex = 1;
            this.lbl_Caption.Text = "Add new Modpack";
            // 
            // pnl_Top
            // 
            this.pnl_Top.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.pnl_Top.Controls.Add(this.lbl_Caption);
            this.pnl_Top.Dock = System.Windows.Forms.DockStyle.Top;
            this.pnl_Top.Font = new System.Drawing.Font("Segoe UI Semilight", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.pnl_Top.Location = new System.Drawing.Point(0, 0);
            this.pnl_Top.Margin = new System.Windows.Forms.Padding(5, 6, 5, 6);
            this.pnl_Top.Name = "pnl_Top";
            this.pnl_Top.Size = new System.Drawing.Size(598, 53);
            this.pnl_Top.TabIndex = 2;
            // 
            // CreateModpackDialog
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(14F, 36F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.DimGray;
            this.ClientSize = new System.Drawing.Size(598, 430);
            this.Controls.Add(this.pnl_Top);
            this.Controls.Add(this.pnl_AlignPanel);
            this.Font = new System.Drawing.Font("Segoe UI Light", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.ForeColor = System.Drawing.Color.White;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Margin = new System.Windows.Forms.Padding(5, 6, 5, 6);
            this.Name = "CreateModpackDialog";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "CreateModpackDialog";
            this.pnl_AlignPanel.ResumeLayout(false);
            this.pnl_AlignPanel.PerformLayout();
            this.pnl_Top.ResumeLayout(false);
            this.pnl_Top.PerformLayout();
            this.ResumeLayout(false);

		}

		#endregion

		private System.Windows.Forms.TextBox txb_Name;
		private System.Windows.Forms.Panel pnl_AlignPanel;
		private System.Windows.Forms.Label lbl_Name;
		private Components.HoverButton hbtn_Cancel;
		private Components.HoverButton hbtn_Ok;
		private System.Windows.Forms.Label lbl_Caption;
		private System.Windows.Forms.Panel pnl_Top;
		private System.Windows.Forms.ComboBox cmbx_FmlVersion;
		private System.Windows.Forms.ComboBox cmbx_McVersion;
		private System.Windows.Forms.Label lbl_FmlVersion;
		private System.Windows.Forms.Label lbl_McVersion;
	}
}