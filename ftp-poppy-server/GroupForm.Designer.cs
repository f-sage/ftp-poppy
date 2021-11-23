
namespace ftp_poppy_server
{
    partial class GroupForm
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
            this.btnDone = new System.Windows.Forms.Button();
            this.tbGroupName = new System.Windows.Forms.TextBox();
            this.lblGroupName = new System.Windows.Forms.Label();
            this.lblGroupDir = new System.Windows.Forms.Label();
            this.tbGroupDir = new System.Windows.Forms.TextBox();
            this.btnGroupDir = new System.Windows.Forms.Button();
            this.fbdGroupDir = new System.Windows.Forms.FolderBrowserDialog();
            this.SuspendLayout();
            // 
            // btnDone
            // 
            this.btnDone.Location = new System.Drawing.Point(221, 195);
            this.btnDone.Name = "btnDone";
            this.btnDone.Size = new System.Drawing.Size(107, 40);
            this.btnDone.TabIndex = 0;
            this.btnDone.Text = "Готово";
            this.btnDone.UseVisualStyleBackColor = true;
            this.btnDone.Click += new System.EventHandler(this.btnDone_Click);
            // 
            // tbGroupName
            // 
            this.tbGroupName.Location = new System.Drawing.Point(189, 45);
            this.tbGroupName.Name = "tbGroupName";
            this.tbGroupName.Size = new System.Drawing.Size(227, 27);
            this.tbGroupName.TabIndex = 1;
            // 
            // lblGroupName
            // 
            this.lblGroupName.AutoSize = true;
            this.lblGroupName.Location = new System.Drawing.Point(56, 48);
            this.lblGroupName.Name = "lblGroupName";
            this.lblGroupName.Size = new System.Drawing.Size(95, 20);
            this.lblGroupName.TabIndex = 2;
            this.lblGroupName.Text = "Назва групи";
            // 
            // lblGroupDir
            // 
            this.lblGroupDir.AutoSize = true;
            this.lblGroupDir.Location = new System.Drawing.Point(99, 115);
            this.lblGroupDir.Name = "lblGroupDir";
            this.lblGroupDir.Size = new System.Drawing.Size(52, 20);
            this.lblGroupDir.TabIndex = 4;
            this.lblGroupDir.Text = "Папка";
            // 
            // tbGroupDir
            // 
            this.tbGroupDir.Location = new System.Drawing.Point(189, 115);
            this.tbGroupDir.Name = "tbGroupDir";
            this.tbGroupDir.Size = new System.Drawing.Size(227, 27);
            this.tbGroupDir.TabIndex = 3;
            // 
            // btnGroupDir
            // 
            this.btnGroupDir.Location = new System.Drawing.Point(439, 101);
            this.btnGroupDir.Name = "btnGroupDir";
            this.btnGroupDir.Size = new System.Drawing.Size(85, 54);
            this.btnGroupDir.TabIndex = 5;
            this.btnGroupDir.Text = "Обрати...";
            this.btnGroupDir.UseVisualStyleBackColor = true;
            this.btnGroupDir.Click += new System.EventHandler(this.btnGroupDir_Click);
            // 
            // GroupForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(550, 260);
            this.Controls.Add(this.btnGroupDir);
            this.Controls.Add(this.lblGroupDir);
            this.Controls.Add(this.tbGroupDir);
            this.Controls.Add(this.lblGroupName);
            this.Controls.Add(this.tbGroupName);
            this.Controls.Add(this.btnDone);
            this.Name = "GroupForm";
            this.Text = "Редагувати групу";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnDone;
        private System.Windows.Forms.TextBox tbGroupName;
        private System.Windows.Forms.Label lblGroupName;
        private System.Windows.Forms.Label lblGroupDir;
        private System.Windows.Forms.TextBox tbGroupDir;
        private System.Windows.Forms.Button btnGroupDir;
        private System.Windows.Forms.FolderBrowserDialog fbdGroupDir;
    }
}