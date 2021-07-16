
namespace Hypermc
{
    partial class Form1
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
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.helpToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.githubToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.docsToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.reportABugToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.downloadNewReleaseToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.sidepanel = new System.Windows.Forms.Panel();
            this.panel1 = new System.Windows.Forms.Panel();
            this.launch_btn = new System.Windows.Forms.Button();
            this.minecraftVersionToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripMenuItem2 = new System.Windows.Forms.ToolStripMenuItem();
            this.menuStrip1.SuspendLayout();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.helpToolStripMenuItem,
            this.minecraftVersionToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(870, 24);
            this.menuStrip1.TabIndex = 0;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // helpToolStripMenuItem
            // 
            this.helpToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.githubToolStripMenuItem,
            this.docsToolStripMenuItem,
            this.reportABugToolStripMenuItem,
            this.downloadNewReleaseToolStripMenuItem});
            this.helpToolStripMenuItem.Name = "helpToolStripMenuItem";
            this.helpToolStripMenuItem.Size = new System.Drawing.Size(44, 20);
            this.helpToolStripMenuItem.Text = "Help";
            this.helpToolStripMenuItem.Click += new System.EventHandler(this.helpToolStripMenuItem_Click);
            // 
            // githubToolStripMenuItem
            // 
            this.githubToolStripMenuItem.Name = "githubToolStripMenuItem";
            this.githubToolStripMenuItem.Size = new System.Drawing.Size(192, 22);
            this.githubToolStripMenuItem.Text = "Github";
            this.githubToolStripMenuItem.Click += new System.EventHandler(this.githubToolStripMenuItem_Click);
            // 
            // docsToolStripMenuItem
            // 
            this.docsToolStripMenuItem.Name = "docsToolStripMenuItem";
            this.docsToolStripMenuItem.Size = new System.Drawing.Size(192, 22);
            this.docsToolStripMenuItem.Text = "Docs";
            this.docsToolStripMenuItem.Click += new System.EventHandler(this.docsToolStripMenuItem_Click);
            // 
            // reportABugToolStripMenuItem
            // 
            this.reportABugToolStripMenuItem.Name = "reportABugToolStripMenuItem";
            this.reportABugToolStripMenuItem.Size = new System.Drawing.Size(192, 22);
            this.reportABugToolStripMenuItem.Text = "Report a bug";
            this.reportABugToolStripMenuItem.Click += new System.EventHandler(this.reportABugToolStripMenuItem_Click);
            // 
            // downloadNewReleaseToolStripMenuItem
            // 
            this.downloadNewReleaseToolStripMenuItem.Name = "downloadNewReleaseToolStripMenuItem";
            this.downloadNewReleaseToolStripMenuItem.Size = new System.Drawing.Size(192, 22);
            this.downloadNewReleaseToolStripMenuItem.Text = "Download new release";
            this.downloadNewReleaseToolStripMenuItem.Click += new System.EventHandler(this.downloadNewReleaseToolStripMenuItem_Click);
            // 
            // sidepanel
            // 
            this.sidepanel.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.sidepanel.Dock = System.Windows.Forms.DockStyle.Left;
            this.sidepanel.Location = new System.Drawing.Point(0, 24);
            this.sidepanel.Name = "sidepanel";
            this.sidepanel.Size = new System.Drawing.Size(133, 414);
            this.sidepanel.TabIndex = 1;
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.Silver;
            this.panel1.Controls.Add(this.launch_btn);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(133, 24);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(737, 54);
            this.panel1.TabIndex = 2;
            // 
            // launch_btn
            // 
            this.launch_btn.BackgroundImage = global::Hypermc.Properties.Resources.launch1;
            this.launch_btn.Font = new System.Drawing.Font("Microsoft Yi Baiti", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.launch_btn.Location = new System.Drawing.Point(647, 0);
            this.launch_btn.Name = "launch_btn";
            this.launch_btn.Size = new System.Drawing.Size(87, 54);
            this.launch_btn.TabIndex = 0;
            this.launch_btn.Text = "Launch";
            this.launch_btn.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            this.launch_btn.UseMnemonic = false;
            this.launch_btn.UseVisualStyleBackColor = true;
            // 
            // minecraftVersionToolStripMenuItem
            // 
            this.minecraftVersionToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolStripMenuItem2});
            this.minecraftVersionToolStripMenuItem.Name = "minecraftVersionToolStripMenuItem";
            this.minecraftVersionToolStripMenuItem.Size = new System.Drawing.Size(114, 20);
            this.minecraftVersionToolStripMenuItem.Text = " Minecraft Version";
            // 
            // toolStripMenuItem2
            // 
            this.toolStripMenuItem2.Name = "toolStripMenuItem2";
            this.toolStripMenuItem2.Size = new System.Drawing.Size(180, 22);
            this.toolStripMenuItem2.Text = "1.16.5";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ButtonFace;
            this.ClientSize = new System.Drawing.Size(870, 438);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.sidepanel);
            this.Controls.Add(this.menuStrip1);
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Hypermc";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.panel1.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem helpToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem githubToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem docsToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem reportABugToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem downloadNewReleaseToolStripMenuItem;
        private System.Windows.Forms.Panel sidepanel;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Button launch_btn;
        private System.Windows.Forms.ToolStripMenuItem minecraftVersionToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem toolStripMenuItem2;
    }
}

