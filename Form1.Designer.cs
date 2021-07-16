
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.helpToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.githubToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.docsToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.reportABugToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.downloadNewReleaseToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.redditToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.minecraftVersionToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripMenuItem2 = new System.Windows.Forms.ToolStripMenuItem();
            this.sidepanel = new System.Windows.Forms.Panel();
            this.label1 = new System.Windows.Forms.Label();
            this.currentMods = new System.Windows.Forms.TreeView();
            this.panel1 = new System.Windows.Forms.Panel();
            this.launch_btn = new System.Windows.Forms.Button();
            this.panel2 = new System.Windows.Forms.Panel();
            this.button1 = new System.Windows.Forms.Button();
            this.git_https_input = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.mod_container = new System.Windows.Forms.Panel();
            this.scroll_bar_vert = new System.Windows.Forms.VScrollBar();
            this.optifine_panel = new System.Windows.Forms.Panel();
            this.optifine_label = new System.Windows.Forms.Label();
            this.optifine_download = new System.Windows.Forms.Button();
            this.label3 = new System.Windows.Forms.Label();
            this.panel3 = new System.Windows.Forms.Panel();
            this.journeymap_download = new System.Windows.Forms.Button();
            this.label4 = new System.Windows.Forms.Label();
            this.menuStrip1.SuspendLayout();
            this.sidepanel.SuspendLayout();
            this.panel1.SuspendLayout();
            this.panel2.SuspendLayout();
            this.mod_container.SuspendLayout();
            this.optifine_panel.SuspendLayout();
            this.panel3.SuspendLayout();
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
            this.downloadNewReleaseToolStripMenuItem,
            this.redditToolStripMenuItem});
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
            // redditToolStripMenuItem
            // 
            this.redditToolStripMenuItem.Name = "redditToolStripMenuItem";
            this.redditToolStripMenuItem.Size = new System.Drawing.Size(192, 22);
            this.redditToolStripMenuItem.Text = "Reddit";
            this.redditToolStripMenuItem.Click += new System.EventHandler(this.redditToolStripMenuItem_Click);
            // 
            // minecraftVersionToolStripMenuItem
            // 
            this.minecraftVersionToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolStripMenuItem2});
            this.minecraftVersionToolStripMenuItem.Name = "minecraftVersionToolStripMenuItem";
            this.minecraftVersionToolStripMenuItem.Size = new System.Drawing.Size(119, 20);
            this.minecraftVersionToolStripMenuItem.Text = " Minecraft Versions";
            // 
            // toolStripMenuItem2
            // 
            this.toolStripMenuItem2.Name = "toolStripMenuItem2";
            this.toolStripMenuItem2.Size = new System.Drawing.Size(104, 22);
            this.toolStripMenuItem2.Text = "1.16.5";
            // 
            // sidepanel
            // 
            this.sidepanel.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.sidepanel.Controls.Add(this.label1);
            this.sidepanel.Controls.Add(this.currentMods);
            this.sidepanel.Dock = System.Windows.Forms.DockStyle.Left;
            this.sidepanel.Location = new System.Drawing.Point(0, 24);
            this.sidepanel.Name = "sidepanel";
            this.sidepanel.Size = new System.Drawing.Size(133, 414);
            this.sidepanel.TabIndex = 1;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Tai Le", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(-4, 20);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(137, 21);
            this.label1.TabIndex = 1;
            this.label1.Text = "Currently Installed";
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // currentMods
            // 
            this.currentMods.Location = new System.Drawing.Point(6, 49);
            this.currentMods.Name = "currentMods";
            this.currentMods.Size = new System.Drawing.Size(121, 353);
            this.currentMods.TabIndex = 0;
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.Silver;
            this.panel1.Controls.Add(this.label3);
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
            this.launch_btn.Dock = System.Windows.Forms.DockStyle.Right;
            this.launch_btn.Font = new System.Drawing.Font("Microsoft Yi Baiti", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.launch_btn.Location = new System.Drawing.Point(650, 0);
            this.launch_btn.Name = "launch_btn";
            this.launch_btn.Size = new System.Drawing.Size(87, 54);
            this.launch_btn.TabIndex = 0;
            this.launch_btn.Text = "Launch";
            this.launch_btn.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            this.launch_btn.UseMnemonic = false;
            this.launch_btn.UseVisualStyleBackColor = true;
            this.launch_btn.Click += new System.EventHandler(this.launch_btn_Click);
            // 
            // panel2
            // 
            this.panel2.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.panel2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.panel2.Controls.Add(this.button1);
            this.panel2.Controls.Add(this.git_https_input);
            this.panel2.Controls.Add(this.label2);
            this.panel2.Location = new System.Drawing.Point(690, 84);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(180, 354);
            this.panel2.TabIndex = 3;
            // 
            // button1
            // 
            this.button1.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button1.Location = new System.Drawing.Point(3, 91);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(173, 38);
            this.button1.TabIndex = 2;
            this.button1.Text = "Internalize";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // git_https_input
            // 
            this.git_https_input.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.git_https_input.ForeColor = System.Drawing.SystemColors.WindowFrame;
            this.git_https_input.Location = new System.Drawing.Point(0, 65);
            this.git_https_input.Name = "git_https_input";
            this.git_https_input.Size = new System.Drawing.Size(180, 20);
            this.git_https_input.TabIndex = 1;
            this.git_https_input.Text = "GIT HTTPS";
            this.git_https_input.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Tai Le", 18F);
            this.label2.Location = new System.Drawing.Point(18, 18);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(150, 30);
            this.label2.TabIndex = 0;
            this.label2.Text = "Install by GIT";
            // 
            // mod_container
            // 
            this.mod_container.Controls.Add(this.panel3);
            this.mod_container.Controls.Add(this.optifine_panel);
            this.mod_container.Controls.Add(this.scroll_bar_vert);
            this.mod_container.Location = new System.Drawing.Point(133, 84);
            this.mod_container.Name = "mod_container";
            this.mod_container.Size = new System.Drawing.Size(551, 351);
            this.mod_container.TabIndex = 4;
            this.mod_container.Scroll += new System.Windows.Forms.ScrollEventHandler(this.mod_container_Scroll);
            // 
            // scroll_bar_vert
            // 
            this.scroll_bar_vert.Location = new System.Drawing.Point(531, 4);
            this.scroll_bar_vert.Name = "scroll_bar_vert";
            this.scroll_bar_vert.Size = new System.Drawing.Size(20, 347);
            this.scroll_bar_vert.TabIndex = 2;
            // 
            // optifine_panel
            // 
            this.optifine_panel.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.optifine_panel.Controls.Add(this.optifine_download);
            this.optifine_panel.Controls.Add(this.optifine_label);
            this.optifine_panel.Location = new System.Drawing.Point(7, 18);
            this.optifine_panel.Name = "optifine_panel";
            this.optifine_panel.Size = new System.Drawing.Size(512, 53);
            this.optifine_panel.TabIndex = 3;
            // 
            // optifine_label
            // 
            this.optifine_label.AutoSize = true;
            this.optifine_label.Font = new System.Drawing.Font("Yu Gothic Light", 21.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.optifine_label.Location = new System.Drawing.Point(3, 0);
            this.optifine_label.Name = "optifine_label";
            this.optifine_label.Size = new System.Drawing.Size(114, 38);
            this.optifine_label.TabIndex = 0;
            this.optifine_label.Text = "Optifine";
            // 
            // optifine_download
            // 
            this.optifine_download.Font = new System.Drawing.Font("Microsoft Yi Baiti", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.optifine_download.Location = new System.Drawing.Point(356, 8);
            this.optifine_download.Name = "optifine_download";
            this.optifine_download.Size = new System.Drawing.Size(149, 33);
            this.optifine_download.TabIndex = 4;
            this.optifine_download.Text = "DOWNLOAD";
            this.optifine_download.UseVisualStyleBackColor = true;
            this.optifine_download.Click += new System.EventHandler(this.optifine_download_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F);
            this.label3.Location = new System.Drawing.Point(16, 20);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(96, 13);
            this.label3.TabIndex = 1;
            this.label3.Text = "1.16.5 Forge Mods";
            this.label3.Click += new System.EventHandler(this.label3_Click);
            // 
            // panel3
            // 
            this.panel3.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.panel3.Controls.Add(this.journeymap_download);
            this.panel3.Controls.Add(this.label4);
            this.panel3.Location = new System.Drawing.Point(7, 77);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(512, 53);
            this.panel3.TabIndex = 5;
            // 
            // journeymap_download
            // 
            this.journeymap_download.Font = new System.Drawing.Font("Microsoft Yi Baiti", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.journeymap_download.Location = new System.Drawing.Point(356, 8);
            this.journeymap_download.Name = "journeymap_download";
            this.journeymap_download.Size = new System.Drawing.Size(149, 33);
            this.journeymap_download.TabIndex = 4;
            this.journeymap_download.Text = "DOWNLOAD";
            this.journeymap_download.UseVisualStyleBackColor = true;
            this.journeymap_download.Click += new System.EventHandler(this.journeymap_download_Click);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Yu Gothic Light", 21.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(3, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(166, 38);
            this.label4.TabIndex = 0;
            this.label4.Text = "Journeymap";
            this.label4.Click += new System.EventHandler(this.label4_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ButtonFace;
            this.ClientSize = new System.Drawing.Size(870, 438);
            this.Controls.Add(this.mod_container);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.sidepanel);
            this.Controls.Add(this.menuStrip1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Hypermc";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.sidepanel.ResumeLayout(false);
            this.sidepanel.PerformLayout();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            this.mod_container.ResumeLayout(false);
            this.optifine_panel.ResumeLayout(false);
            this.optifine_panel.PerformLayout();
            this.panel3.ResumeLayout(false);
            this.panel3.PerformLayout();
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
        public System.Windows.Forms.TreeView currentMods;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button button1;
        public System.Windows.Forms.TextBox git_https_input;
        private System.Windows.Forms.ToolStripMenuItem redditToolStripMenuItem;
        private System.Windows.Forms.Panel mod_container;
        public System.Windows.Forms.VScrollBar scroll_bar_vert;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Panel optifine_panel;
        private System.Windows.Forms.Button optifine_download;
        private System.Windows.Forms.Label optifine_label;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.Button journeymap_download;
        private System.Windows.Forms.Label label4;
    }
}

