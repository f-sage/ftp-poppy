
namespace ftp_poppy_server
{
    partial class AboutForm
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
            this.lblTitle = new System.Windows.Forms.Label();
            this.linklblGithub = new System.Windows.Forms.LinkLabel();
            this.label1 = new System.Windows.Forms.Label();
            this.lblSubtitle = new System.Windows.Forms.Label();
            this.lblAuthor = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // lblTitle
            // 
            this.lblTitle.AutoSize = true;
            this.lblTitle.Font = new System.Drawing.Font("Candara", 25.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.lblTitle.Location = new System.Drawing.Point(12, 22);
            this.lblTitle.Name = "lblTitle";
            this.lblTitle.Size = new System.Drawing.Size(208, 53);
            this.lblTitle.TabIndex = 1;
            this.lblTitle.Text = "Ftp Poppy";
            // 
            // linklblGithub
            // 
            this.linklblGithub.AutoSize = true;
            this.linklblGithub.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.linklblGithub.Location = new System.Drawing.Point(33, 195);
            this.linklblGithub.Name = "linklblGithub";
            this.linklblGithub.Size = new System.Drawing.Size(172, 28);
            this.linklblGithub.TabIndex = 1;
            this.linklblGithub.TabStop = true;
            this.linklblGithub.Text = "Проєкт на GitHub";
            this.linklblGithub.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.linklblGithub_LinkClicked);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label1.Location = new System.Drawing.Point(276, 47);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(100, 28);
            this.label1.TabIndex = 2;
            this.label1.Text = "версія 0.1";
            // 
            // lblSubtitle
            // 
            this.lblSubtitle.AutoSize = true;
            this.lblSubtitle.Font = new System.Drawing.Font("Candara", 22.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.lblSubtitle.Location = new System.Drawing.Point(47, 75);
            this.lblSubtitle.Name = "lblSubtitle";
            this.lblSubtitle.Size = new System.Drawing.Size(118, 45);
            this.lblSubtitle.TabIndex = 0;
            this.lblSubtitle.Text = "server";
            // 
            // lblAuthor
            // 
            this.lblAuthor.AutoSize = true;
            this.lblAuthor.ForeColor = System.Drawing.SystemColors.ControlDarkDark;
            this.lblAuthor.Location = new System.Drawing.Point(33, 147);
            this.lblAuthor.Name = "lblAuthor";
            this.lblAuthor.Size = new System.Drawing.Size(237, 20);
            this.lblAuthor.TabIndex = 3;
            this.lblAuthor.Text = "Автор програми - Софія Іванова";
            // 
            // AboutForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(401, 243);
            this.Controls.Add(this.lblAuthor);
            this.Controls.Add(this.lblSubtitle);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.linklblGithub);
            this.Controls.Add(this.lblTitle);
            this.Name = "AboutForm";
            this.Text = "Про програму";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblTitle;
        private System.Windows.Forms.LinkLabel linklblGithub;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label lblSubtitle;
        private System.Windows.Forms.Label lblAuthor;
    }
}