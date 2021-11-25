
namespace ftp_poppy_client
{
    partial class MainFormClient
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.pnDragDrop = new System.Windows.Forms.Panel();
            this.lblDragDrop = new System.Windows.Forms.Label();
            this.menuStrip = new System.Windows.Forms.MenuStrip();
            this.tsmiSettings = new System.Windows.Forms.ToolStripMenuItem();
            this.btnConnect = new System.Windows.Forms.Button();
            this.tbLog = new System.Windows.Forms.TextBox();
            this.btnDownloadAll = new System.Windows.Forms.Button();
            this.lbTaskFiles = new System.Windows.Forms.ListBox();
            this.btnDownloadChosen = new System.Windows.Forms.Button();
            this.lbUsersFiles = new System.Windows.Forms.ListBox();
            this.lblTeachersFiles = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.btnDownloadChosenUserFiles = new System.Windows.Forms.Button();
            this.btnDownloadAllUserFiles = new System.Windows.Forms.Button();
            this.btnRefresh = new System.Windows.Forms.Button();
            this.pnDragDrop.SuspendLayout();
            this.menuStrip.SuspendLayout();
            this.SuspendLayout();
            // 
            // pnDragDrop
            // 
            this.pnDragDrop.AllowDrop = true;
            this.pnDragDrop.BackColor = System.Drawing.Color.MistyRose;
            this.pnDragDrop.Controls.Add(this.lblDragDrop);
            this.pnDragDrop.Location = new System.Drawing.Point(589, 100);
            this.pnDragDrop.Name = "pnDragDrop";
            this.pnDragDrop.Size = new System.Drawing.Size(324, 244);
            this.pnDragDrop.TabIndex = 2;
            this.pnDragDrop.DragDrop += new System.Windows.Forms.DragEventHandler(this.pnDragDrop_DragDrop);
            this.pnDragDrop.DragEnter += new System.Windows.Forms.DragEventHandler(this.pnDragDrop_DragEnter);
            this.pnDragDrop.DragOver += new System.Windows.Forms.DragEventHandler(this.pnDragDrop_DragOver);
            this.pnDragDrop.DragLeave += new System.EventHandler(this.pnDragDrop_DragLeave);
            // 
            // lblDragDrop
            // 
            this.lblDragDrop.AutoSize = true;
            this.lblDragDrop.Font = new System.Drawing.Font("Tahoma", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.lblDragDrop.ForeColor = System.Drawing.Color.Sienna;
            this.lblDragDrop.Location = new System.Drawing.Point(18, 44);
            this.lblDragDrop.MaximumSize = new System.Drawing.Size(350, 400);
            this.lblDragDrop.Name = "lblDragDrop";
            this.lblDragDrop.Size = new System.Drawing.Size(287, 144);
            this.lblDragDrop.TabIndex = 0;
            this.lblDragDrop.Text = "Перетягніть файли сюди для завантаження на сервер";
            // 
            // menuStrip
            // 
            this.menuStrip.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.menuStrip.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.tsmiSettings});
            this.menuStrip.Location = new System.Drawing.Point(0, 0);
            this.menuStrip.Name = "menuStrip";
            this.menuStrip.Size = new System.Drawing.Size(939, 28);
            this.menuStrip.TabIndex = 3;
            this.menuStrip.Text = "menuStrip1";
            // 
            // tsmiSettings
            // 
            this.tsmiSettings.Name = "tsmiSettings";
            this.tsmiSettings.Size = new System.Drawing.Size(125, 24);
            this.tsmiSettings.Text = "Налаштування";
            this.tsmiSettings.Click += new System.EventHandler(this.налаштуванняToolStripMenuItem_Click);
            // 
            // btnConnect
            // 
            this.btnConnect.Location = new System.Drawing.Point(28, 481);
            this.btnConnect.Name = "btnConnect";
            this.btnConnect.Size = new System.Drawing.Size(118, 75);
            this.btnConnect.TabIndex = 4;
            this.btnConnect.Text = "Підключитися до сервера";
            this.btnConnect.UseVisualStyleBackColor = true;
            this.btnConnect.Click += new System.EventHandler(this.btnConnect_Click);
            // 
            // tbLog
            // 
            this.tbLog.Location = new System.Drawing.Point(289, 471);
            this.tbLog.Multiline = true;
            this.tbLog.Name = "tbLog";
            this.tbLog.ReadOnly = true;
            this.tbLog.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.tbLog.Size = new System.Drawing.Size(624, 98);
            this.tbLog.TabIndex = 6;
            // 
            // btnDownloadAll
            // 
            this.btnDownloadAll.Location = new System.Drawing.Point(28, 362);
            this.btnDownloadAll.Name = "btnDownloadAll";
            this.btnDownloadAll.Size = new System.Drawing.Size(118, 75);
            this.btnDownloadAll.TabIndex = 7;
            this.btnDownloadAll.Text = "Завантажити всі файли з сервера";
            this.btnDownloadAll.UseVisualStyleBackColor = true;
            // 
            // lbTaskFiles
            // 
            this.lbTaskFiles.FormattingEnabled = true;
            this.lbTaskFiles.ItemHeight = 20;
            this.lbTaskFiles.Location = new System.Drawing.Point(28, 100);
            this.lbTaskFiles.Name = "lbTaskFiles";
            this.lbTaskFiles.Size = new System.Drawing.Size(242, 244);
            this.lbTaskFiles.TabIndex = 8;
            // 
            // btnDownloadChosen
            // 
            this.btnDownloadChosen.Location = new System.Drawing.Point(152, 362);
            this.btnDownloadChosen.Name = "btnDownloadChosen";
            this.btnDownloadChosen.Size = new System.Drawing.Size(118, 75);
            this.btnDownloadChosen.TabIndex = 9;
            this.btnDownloadChosen.Text = "Завантажити обрані файли ";
            this.btnDownloadChosen.UseVisualStyleBackColor = true;
            // 
            // lbUsersFiles
            // 
            this.lbUsersFiles.FormattingEnabled = true;
            this.lbUsersFiles.ItemHeight = 20;
            this.lbUsersFiles.Location = new System.Drawing.Point(313, 100);
            this.lbUsersFiles.Name = "lbUsersFiles";
            this.lbUsersFiles.Size = new System.Drawing.Size(242, 244);
            this.lbUsersFiles.TabIndex = 10;
            // 
            // lblTeachersFiles
            // 
            this.lblTeachersFiles.AutoSize = true;
            this.lblTeachersFiles.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.lblTeachersFiles.Location = new System.Drawing.Point(49, 53);
            this.lblTeachersFiles.Name = "lblTeachersFiles";
            this.lblTeachersFiles.Size = new System.Drawing.Size(150, 28);
            this.lblTeachersFiles.TabIndex = 11;
            this.lblTeachersFiles.Text = "Файли вчителя";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label1.Location = new System.Drawing.Point(365, 53);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(111, 28);
            this.label1.TabIndex = 12;
            this.label1.Text = "Мої файли";
            // 
            // btnDownloadChosenUserFiles
            // 
            this.btnDownloadChosenUserFiles.Location = new System.Drawing.Point(437, 362);
            this.btnDownloadChosenUserFiles.Name = "btnDownloadChosenUserFiles";
            this.btnDownloadChosenUserFiles.Size = new System.Drawing.Size(118, 75);
            this.btnDownloadChosenUserFiles.TabIndex = 14;
            this.btnDownloadChosenUserFiles.Text = "Завантажити обрані файли ";
            this.btnDownloadChosenUserFiles.UseVisualStyleBackColor = true;
            // 
            // btnDownloadAllUserFiles
            // 
            this.btnDownloadAllUserFiles.Location = new System.Drawing.Point(313, 362);
            this.btnDownloadAllUserFiles.Name = "btnDownloadAllUserFiles";
            this.btnDownloadAllUserFiles.Size = new System.Drawing.Size(118, 75);
            this.btnDownloadAllUserFiles.TabIndex = 13;
            this.btnDownloadAllUserFiles.Text = "Завантажити всі файли з сервера";
            this.btnDownloadAllUserFiles.UseVisualStyleBackColor = true;
            // 
            // btnRefresh
            // 
            this.btnRefresh.Location = new System.Drawing.Point(152, 481);
            this.btnRefresh.Name = "btnRefresh";
            this.btnRefresh.Size = new System.Drawing.Size(118, 75);
            this.btnRefresh.TabIndex = 15;
            this.btnRefresh.Text = "Оновити список файлів";
            this.btnRefresh.UseVisualStyleBackColor = true;
            this.btnRefresh.Click += new System.EventHandler(this.btnRefresh_Click);
            // 
            // MainFormClient
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(939, 575);
            this.Controls.Add(this.btnRefresh);
            this.Controls.Add(this.btnDownloadChosenUserFiles);
            this.Controls.Add(this.btnDownloadAllUserFiles);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.lblTeachersFiles);
            this.Controls.Add(this.lbUsersFiles);
            this.Controls.Add(this.btnDownloadChosen);
            this.Controls.Add(this.lbTaskFiles);
            this.Controls.Add(this.btnDownloadAll);
            this.Controls.Add(this.tbLog);
            this.Controls.Add(this.btnConnect);
            this.Controls.Add(this.pnDragDrop);
            this.Controls.Add(this.menuStrip);
            this.MainMenuStrip = this.menuStrip;
            this.Name = "MainFormClient";
            this.Text = "FtpPoppy Client";
            this.pnDragDrop.ResumeLayout(false);
            this.pnDragDrop.PerformLayout();
            this.menuStrip.ResumeLayout(false);
            this.menuStrip.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Panel pnDragDrop;
        private System.Windows.Forms.Label lblDragDrop;
        private System.Windows.Forms.MenuStrip menuStrip;
        private System.Windows.Forms.ToolStripMenuItem tsmiSettings;
        private System.Windows.Forms.Button btnConnect;
        private System.Windows.Forms.Label lblConnection;
        private System.Windows.Forms.TextBox tbLog;
        private System.Windows.Forms.Button btnDownloadAll;
        private System.Windows.Forms.ListBox lbTaskFiles;
        private System.Windows.Forms.Button btnDownloadChosen;
        private System.Windows.Forms.ListBox lbUsersFiles;
        private System.Windows.Forms.Label lblTeachersFiles;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btnDownloadChosenUserFiles;
        private System.Windows.Forms.Button btnDownloadAllUserFiles;
        private System.Windows.Forms.Button btnRefresh;
    }
}

