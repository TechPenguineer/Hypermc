
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
            this.sidepanel = new System.Windows.Forms.Panel();
            this.panel1 = new System.Windows.Forms.Panel();
            this.launch_btn = new System.Windows.Forms.Button();
            this.minecraftVersionToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripMenuItem2 = new System.Windows.Forms.ToolStripMenuItem();
            this.currentMods = new System.Windows.Forms.TreeView();
            this.label1 = new System.Windows.Forms.Label();
            this.panel2 = new System.Windows.Forms.Panel();
            this.label2 = new System.Windows.Forms.Label();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.button1 = new System.Windows.Forms.Button();
            this.menuStrip1.SuspendLayout();
            this.sidepanel.SuspendLayout();
            this.panel1.SuspendLayout();
            this.panel2.SuspendLayout();
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
            this.sidepanel.Controls.Add(this.label1);
            this.sidepanel.Controls.Add(this.currentMods);
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
            this.toolStripMenuItem2.Size = new System.Drawing.Size(180, 22);
            this.toolStripMenuItem2.Text = "1.16.5";
            // 
            // currentMods
            // 
            this.currentMods.Location = new System.Drawing.Point(6, 49);
            this.currentMods.Name = "currentMods";
            this.currentMods.Size = new System.Drawing.Size(121, 353);
            this.currentMods.TabIndex = 0;
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
            // panel2
            // 
            this.panel2.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.panel2.Controls.Add(this.button1);
            this.panel2.Controls.Add(this.textBox1);
            this.panel2.Controls.Add(this.label2);
            this.panel2.Location = new System.Drawing.Point(690, 73);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(180, 365);
            this.panel2.TabIndex = 3;
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
            // textBox1
            // 
            this.textBox1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.textBox1.ForeColor = System.Drawing.SystemColors.WindowFrame;
            this.textBox1.Location = new System.Drawing.Point(0, 65);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(180, 20);
            this.textBox1.TabIndex = 1;
            this.textBox1.Text = "GIT HTTPS";
            this.textBox1.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // button1
            // 
            this.button1.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button1.Location = new System.Drawing.Point(3, 104);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(173, 38);
            this.button1.TabIndex = 2;
            this.button1.Text = "Internalize";
            this.button1.UseVisualStyleBackColor = true;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ButtonFace;
            this.ClientSize = new System.Drawing.Size(870, 438);
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
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
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
        private System.Windows.Forms.TextBox textBox1;
    }
}

