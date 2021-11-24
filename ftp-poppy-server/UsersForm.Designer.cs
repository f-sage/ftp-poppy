
namespace ftp_poppy_server
{
    partial class UsersForm
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
            this.lbUsers = new System.Windows.Forms.ListBox();
            this.btnSaveChanges = new System.Windows.Forms.Button();
            this.tbUserName = new System.Windows.Forms.TextBox();
            this.tbPassword = new System.Windows.Forms.TextBox();
            this.tbFolder = new System.Windows.Forms.TextBox();
            this.lblUserName = new System.Windows.Forms.Label();
            this.lblPassword = new System.Windows.Forms.Label();
            this.lblFolder = new System.Windows.Forms.Label();
            this.lblFolderDescription = new System.Windows.Forms.Label();
            this.backgroundWorker1 = new System.ComponentModel.BackgroundWorker();
            this.btnDeleteUser = new System.Windows.Forms.Button();
            this.lblNewUser = new System.Windows.Forms.Label();
            this.pnUserDetails = new System.Windows.Forms.Panel();
            this.pnUserDetails.SuspendLayout();
            this.SuspendLayout();
            // 
            // lbUsers
            // 
            this.lbUsers.FormattingEnabled = true;
            this.lbUsers.ItemHeight = 20;
            this.lbUsers.Location = new System.Drawing.Point(37, 31);
            this.lbUsers.Name = "lbUsers";
            this.lbUsers.Size = new System.Drawing.Size(208, 384);
            this.lbUsers.TabIndex = 0;
            this.lbUsers.SelectedValueChanged += new System.EventHandler(this.lbUsers_SelectedValueChanged);
            // 
            // btnSaveChanges
            // 
            this.btnSaveChanges.Location = new System.Drawing.Point(289, 338);
            this.btnSaveChanges.Name = "btnSaveChanges";
            this.btnSaveChanges.Size = new System.Drawing.Size(134, 62);
            this.btnSaveChanges.TabIndex = 1;
            this.btnSaveChanges.Text = "Зберегти зміни";
            this.btnSaveChanges.UseVisualStyleBackColor = true;
            this.btnSaveChanges.Click += new System.EventHandler(this.btnSaveChanges_Click);
            // 
            // tbUserName
            // 
            this.tbUserName.Location = new System.Drawing.Point(210, 56);
            this.tbUserName.Name = "tbUserName";
            this.tbUserName.Size = new System.Drawing.Size(192, 27);
            this.tbUserName.TabIndex = 2;
            // 
            // tbPassword
            // 
            this.tbPassword.Location = new System.Drawing.Point(210, 121);
            this.tbPassword.Name = "tbPassword";
            this.tbPassword.Size = new System.Drawing.Size(192, 27);
            this.tbPassword.TabIndex = 3;
            // 
            // tbFolder
            // 
            this.tbFolder.Location = new System.Drawing.Point(210, 188);
            this.tbFolder.Name = "tbFolder";
            this.tbFolder.Size = new System.Drawing.Size(192, 27);
            this.tbFolder.TabIndex = 4;
            // 
            // lblUserName
            // 
            this.lblUserName.AutoSize = true;
            this.lblUserName.Location = new System.Drawing.Point(15, 59);
            this.lblUserName.Name = "lblUserName";
            this.lblUserName.Size = new System.Drawing.Size(125, 20);
            this.lblUserName.TabIndex = 5;
            this.lblUserName.Text = "Ім\'я користувача";
            // 
            // lblPassword
            // 
            this.lblPassword.AutoSize = true;
            this.lblPassword.Location = new System.Drawing.Point(15, 124);
            this.lblPassword.Name = "lblPassword";
            this.lblPassword.Size = new System.Drawing.Size(62, 20);
            this.lblPassword.TabIndex = 6;
            this.lblPassword.Text = "Пароль";
            // 
            // lblFolder
            // 
            this.lblFolder.AutoSize = true;
            this.lblFolder.Location = new System.Drawing.Point(15, 191);
            this.lblFolder.Name = "lblFolder";
            this.lblFolder.Size = new System.Drawing.Size(120, 20);
            this.lblFolder.TabIndex = 7;
            this.lblFolder.Text = "Особиста папка";
            // 
            // lblFolderDescription
            // 
            this.lblFolderDescription.AutoSize = true;
            this.lblFolderDescription.Location = new System.Drawing.Point(183, 218);
            this.lblFolderDescription.MaximumSize = new System.Drawing.Size(300, 0);
            this.lblFolderDescription.Name = "lblFolderDescription";
            this.lblFolderDescription.Size = new System.Drawing.Size(280, 60);
            this.lblFolderDescription.TabIndex = 8;
            this.lblFolderDescription.Text = "Назва папки, яка буде створена у головній папці спеціально для файлів цього корис" +
    "тувача.";
            // 
            // btnDeleteUser
            // 
            this.btnDeleteUser.Location = new System.Drawing.Point(25, 338);
            this.btnDeleteUser.Name = "btnDeleteUser";
            this.btnDeleteUser.Size = new System.Drawing.Size(134, 62);
            this.btnDeleteUser.TabIndex = 10;
            this.btnDeleteUser.Text = "Видалити користувача";
            this.btnDeleteUser.UseVisualStyleBackColor = true;
            this.btnDeleteUser.Visible = false;
            this.btnDeleteUser.Click += new System.EventHandler(this.btnDeleteUser_Click);
            // 
            // lblNewUser
            // 
            this.lblNewUser.AutoSize = true;
            this.lblNewUser.Location = new System.Drawing.Point(183, 19);
            this.lblNewUser.Name = "lblNewUser";
            this.lblNewUser.Size = new System.Drawing.Size(137, 20);
            this.lblNewUser.TabIndex = 11;
            this.lblNewUser.Text = "Новий користувач";
            // 
            // pnUserDetails
            // 
            this.pnUserDetails.Controls.Add(this.tbFolder);
            this.pnUserDetails.Controls.Add(this.btnDeleteUser);
            this.pnUserDetails.Controls.Add(this.btnSaveChanges);
            this.pnUserDetails.Controls.Add(this.lblNewUser);
            this.pnUserDetails.Controls.Add(this.tbUserName);
            this.pnUserDetails.Controls.Add(this.tbPassword);
            this.pnUserDetails.Controls.Add(this.lblFolderDescription);
            this.pnUserDetails.Controls.Add(this.lblUserName);
            this.pnUserDetails.Controls.Add(this.lblFolder);
            this.pnUserDetails.Controls.Add(this.lblPassword);
            this.pnUserDetails.Location = new System.Drawing.Point(287, 12);
            this.pnUserDetails.Name = "pnUserDetails";
            this.pnUserDetails.Size = new System.Drawing.Size(473, 403);
            this.pnUserDetails.TabIndex = 12;
            // 
            // UsersForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(797, 437);
            this.Controls.Add(this.pnUserDetails);
            this.Controls.Add(this.lbUsers);
            this.Name = "UsersForm";
            this.Text = "Користувачі сервера";
            this.pnUserDetails.ResumeLayout(false);
            this.pnUserDetails.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.ListBox lbUsers;
        private System.Windows.Forms.Button btnSaveChanges;
        private System.Windows.Forms.TextBox tbUserName;
        private System.Windows.Forms.TextBox tbPassword;
        private System.Windows.Forms.TextBox tbFolder;
        private System.Windows.Forms.Label lblUserName;
        private System.Windows.Forms.Label lblPassword;
        private System.Windows.Forms.Label lblFolder;
        private System.Windows.Forms.Label lblFolderDescription;
        private System.ComponentModel.BackgroundWorker backgroundWorker1;
        private System.Windows.Forms.Button btnDeleteUser;
        private System.Windows.Forms.Label lblNewUser;
        private System.Windows.Forms.Panel pnUserDetails;
    }
}