using SharpServer;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ftp_poppy_server
{
    public partial class UsersForm : Form
    {
        const string newUserOption = "<новий>";
        public UsersForm(bool enabled)
        {
            InitializeComponent();
            if (!enabled) this.pnUserDetails.Enabled = false;
            //put ftpusers into listbox!!
            updateListBox();
            lbUsers.SelectedItem =newUserOption;
        }

        void updateListBox()
        {
            lbUsers.Items.Clear();
            lbUsers.Items.AddRange(
              FtpUserStore.Users.Select(x => x.UserName).ToArray());
            lbUsers.Items.Add(newUserOption);
        }

        private void lbUsers_SelectedValueChanged(object sender, EventArgs e)
        {
            btnSaveChanges.Visible = true;
            btnDeleteUser.Visible = true;
            if (newUserOption == lbUsers.SelectedItem.ToString()) {
                btnDeleteUser.Visible = false;
                lblNewUser.Visible = true;
                tbUserName.Text = string.Empty;
                tbFolder.Text = string.Empty;
                tbPassword.Text = string.Empty;
                return; 
            }
            lblNewUser.Visible = false;
            //get User by name
            FtpUser user = FtpUserStore.Users.FirstOrDefault
                (x=>x.UserName==lbUsers.SelectedItem.ToString());
            //set textboxes values
            tbUserName.Text = user.UserName;
            tbFolder.Text = user.Folder;
            tbPassword.Text = user.Password;

        }

        private void btnDeleteUser_Click(object sender, EventArgs e)
        {
            if(MessageBox.Show("Дійсно видалити користувача?",
                            "Видалення", MessageBoxButtons.YesNo)==DialogResult.Yes)
            {
                FtpUserStore.RemoveUser(FtpUserStore.Users.FirstOrDefault(
                    x=>x.UserName==lbUsers.SelectedItem.ToString()));
                FtpUserStore.Update();
                updateListBox();
                lbUsers.SelectedIndex = 0;
            }
        }

        private void btnSaveChanges_Click(object sender, EventArgs e)
        {
            try
            {
                //check for everything!!!
                if (tbUserName.Text == string.Empty) {
                    throw new ArgumentException("Ім'я користувача не може бути порожнім.");
                        }

                if (tbPassword.Text == string.Empty && tbFolder.Text == string.Empty)
                {
                    throw new ArgumentException("Будь ласка, вкажіть для користувача " +
                        "або пароль, або назву особистої папки.");
                }

                var user = new FtpUser
                {
                    UserName = tbUserName.Text,
                    Password = tbPassword.Text,
                    Folder = tbFolder.Text
                };
                if (lbUsers.SelectedItem==null||lbUsers.SelectedItem.ToString() == newUserOption)
                {
                    FtpUserStore.AddUser(user);
                }
                else
                {
                    var oldUser = FtpUserStore.Users.FirstOrDefault
                        (x => x.UserName == lbUsers.SelectedItem.ToString());
                    oldUser = user;
                }

                updateListBox();
                FtpUserStore.Update();
            }
            catch(Exception exc)
            {
                MessageBox.Show(exc.Message);
            }
        }

    }
}
