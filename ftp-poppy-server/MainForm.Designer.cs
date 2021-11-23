﻿
namespace ftp_poppy_server
{
    partial class MainForm
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
            this.tbLog = new System.Windows.Forms.TextBox();
            this.fbdPath = new System.Windows.Forms.FolderBrowserDialog();
            this.nudPort = new System.Windows.Forms.NumericUpDown();
            this.btnStartStop = new System.Windows.Forms.Button();
            this.lblPort = new System.Windows.Forms.Label();
            this.lblPath = new System.Windows.Forms.Label();
            this.tbPath = new System.Windows.Forms.TextBox();
            this.btnPathChange = new System.Windows.Forms.Button();
            this.btnPathOpen = new System.Windows.Forms.Button();
            this.lblGroup = new System.Windows.Forms.Label();
            this.cmbGroup = new System.Windows.Forms.ComboBox();
            this.btnAddGroup = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.nudPort)).BeginInit();
            this.SuspendLayout();
            // 
            // tbLog
            // 
            this.tbLog.Location = new System.Drawing.Point(12, 401);
            this.tbLog.Multiline = true;
            this.tbLog.Name = "tbLog";
            this.tbLog.ReadOnly = true;
            this.tbLog.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.tbLog.Size = new System.Drawing.Size(821, 133);
            this.tbLog.TabIndex = 4;
            // 
            // nudPort
            // 
            this.nudPort.Location = new System.Drawing.Point(165, 181);
            this.nudPort.Maximum = new decimal(new int[] {
            65535,
            0,
            0,
            0});
            this.nudPort.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.nudPort.Name = "nudPort";
            this.nudPort.Size = new System.Drawing.Size(128, 27);
            this.nudPort.TabIndex = 1;
            this.nudPort.Value = new decimal(new int[] {
            21,
            0,
            0,
            0});
            // 
            // btnStartStop
            // 
            this.btnStartStop.Font = new System.Drawing.Font("Comic Sans MS", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.btnStartStop.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.btnStartStop.Location = new System.Drawing.Point(328, 278);
            this.btnStartStop.Name = "btnStartStop";
            this.btnStartStop.Size = new System.Drawing.Size(217, 87);
            this.btnStartStop.TabIndex = 2;
            this.btnStartStop.Text = "Запустити сервер";
            this.btnStartStop.UseVisualStyleBackColor = true;
            this.btnStartStop.Click += new System.EventHandler(this.btnStartStop_Click);
            // 
            // lblPort
            // 
            this.lblPort.AutoSize = true;
            this.lblPort.Location = new System.Drawing.Point(98, 183);
            this.lblPort.Name = "lblPort";
            this.lblPort.Size = new System.Drawing.Size(47, 20);
            this.lblPort.TabIndex = 3;
            this.lblPort.Text = "Порт:";
            // 
            // lblPath
            // 
            this.lblPath.AutoSize = true;
            this.lblPath.Location = new System.Drawing.Point(32, 134);
            this.lblPath.Name = "lblPath";
            this.lblPath.Size = new System.Drawing.Size(116, 20);
            this.lblPath.TabIndex = 4;
            this.lblPath.Text = "Шлях до папки:";
            // 
            // tbPath
            // 
            this.tbPath.Location = new System.Drawing.Point(165, 131);
            this.tbPath.Name = "tbPath";
            this.tbPath.Size = new System.Drawing.Size(335, 27);
            this.tbPath.TabIndex = 5;
            // 
            // btnPathChange
            // 
            this.btnPathChange.Location = new System.Drawing.Point(523, 119);
            this.btnPathChange.Name = "btnPathChange";
            this.btnPathChange.Size = new System.Drawing.Size(94, 50);
            this.btnPathChange.TabIndex = 6;
            this.btnPathChange.Text = "Змінити папку";
            this.btnPathChange.UseVisualStyleBackColor = true;
            this.btnPathChange.Click += new System.EventHandler(this.btnPathChange_Click);
            // 
            // btnPathOpen
            // 
            this.btnPathOpen.Location = new System.Drawing.Point(641, 119);
            this.btnPathOpen.Name = "btnPathOpen";
            this.btnPathOpen.Size = new System.Drawing.Size(94, 48);
            this.btnPathOpen.TabIndex = 7;
            this.btnPathOpen.Text = "Відкрити папку";
            this.btnPathOpen.UseVisualStyleBackColor = true;
            this.btnPathOpen.Click += new System.EventHandler(this.btnPathOpen_Click);
            // 
            // lblGroup
            // 
            this.lblGroup.AutoSize = true;
            this.lblGroup.Location = new System.Drawing.Point(32, 75);
            this.lblGroup.Name = "lblGroup";
            this.lblGroup.Size = new System.Drawing.Size(52, 20);
            this.lblGroup.TabIndex = 8;
            this.lblGroup.Text = "Група:";
            // 
            // cmbGroup
            // 
            this.cmbGroup.FormattingEnabled = true;
            this.cmbGroup.Location = new System.Drawing.Point(165, 72);
            this.cmbGroup.Name = "cmbGroup";
            this.cmbGroup.Size = new System.Drawing.Size(179, 28);
            this.cmbGroup.TabIndex = 9;
            this.cmbGroup.SelectedIndexChanged += new System.EventHandler(this.cmbGroup_SelectedIndexChanged);
            // 
            // btnAddGroup
            // 
            this.btnAddGroup.Location = new System.Drawing.Point(417, 60);
            this.btnAddGroup.Name = "btnAddGroup";
            this.btnAddGroup.Size = new System.Drawing.Size(94, 50);
            this.btnAddGroup.TabIndex = 10;
            this.btnAddGroup.Text = "Нова група...";
            this.btnAddGroup.UseVisualStyleBackColor = true;
            this.btnAddGroup.Click += new System.EventHandler(this.btnAddGroup_Click);
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(845, 546);
            this.Controls.Add(this.btnAddGroup);
            this.Controls.Add(this.cmbGroup);
            this.Controls.Add(this.lblGroup);
            this.Controls.Add(this.btnPathOpen);
            this.Controls.Add(this.btnPathChange);
            this.Controls.Add(this.tbPath);
            this.Controls.Add(this.lblPath);
            this.Controls.Add(this.lblPort);
            this.Controls.Add(this.btnStartStop);
            this.Controls.Add(this.nudPort);
            this.Controls.Add(this.tbLog);
            this.Name = "MainForm";
            this.Text = "server";
            ((System.ComponentModel.ISupportInitialize)(this.nudPort)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox tbLog;
        private System.Windows.Forms.FolderBrowserDialog fbdPath;
        private System.Windows.Forms.NumericUpDown nudPort;
        private System.Windows.Forms.Button btnStartStop;
        private System.Windows.Forms.Label lblPort;
        private System.Windows.Forms.Label lblPath;
        private System.Windows.Forms.TextBox tbPath;
        private System.Windows.Forms.Button btnPathChange;
        private System.Windows.Forms.Button btnPathOpen;
        private System.Windows.Forms.Label lblGroup;
        public System.Windows.Forms.ComboBox cmbGroup;
        private System.Windows.Forms.Button btnAddGroup;
    }
}

