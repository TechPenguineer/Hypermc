
namespace HyperMC
{
    partial class ModDisplay
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
            this.lblName = new System.Windows.Forms.Label();
            this.btnDownload = new System.Windows.Forms.Button();
            this.modImage = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.modImage)).BeginInit();
            this.SuspendLayout();
            // 
            // lblName
            // 
            this.lblName.AutoSize = true;
            this.lblName.Font = new System.Drawing.Font("Segoe UI", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.lblName.ForeColor = System.Drawing.SystemColors.Control;
            this.lblName.Location = new System.Drawing.Point(162, 15);
            this.lblName.Name = "lblName";
            this.lblName.Size = new System.Drawing.Size(135, 32);
            this.lblName.TabIndex = 0;
            this.lblName.Text = "Mod Name";
            // 
            // btnDownload
            // 
            this.btnDownload.BackColor = System.Drawing.Color.SeaGreen;
            this.btnDownload.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnDownload.Font = new System.Drawing.Font("Segoe UI", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.btnDownload.ForeColor = System.Drawing.Color.White;
            this.btnDownload.Location = new System.Drawing.Point(502, 46);
            this.btnDownload.Name = "btnDownload";
            this.btnDownload.Size = new System.Drawing.Size(224, 48);
            this.btnDownload.TabIndex = 1;
            this.btnDownload.Text = "Download";
            this.btnDownload.UseVisualStyleBackColor = false;
            // 
            // modImage
            // 
            this.modImage.Location = new System.Drawing.Point(25, 3);
            this.modImage.Name = "modImage";
            this.modImage.Size = new System.Drawing.Size(131, 131);
            this.modImage.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.modImage.TabIndex = 2;
            this.modImage.TabStop = false;
            // 
            // ModDisplay
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(71)))), ((int)(((byte)(71)))), ((int)(((byte)(71)))));
            this.Controls.Add(this.modImage);
            this.Controls.Add(this.btnDownload);
            this.Controls.Add(this.lblName);
            this.Name = "ModDisplay";
            this.Size = new System.Drawing.Size(756, 138);
            ((System.ComponentModel.ISupportInitialize)(this.modImage)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblName;
        private System.Windows.Forms.Button btnDownload;
        private System.Windows.Forms.PictureBox modImage;
    }
}
