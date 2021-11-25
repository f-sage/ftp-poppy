using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Net;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ftp_poppy_client
{
    public partial class SettingsForm : Form
    {
        ClientConnectionSettings settingsToChange;
        public SettingsForm(ClientConnectionSettings settings)
        {
            InitializeComponent();
            settingsToChange = settings;
            if (settingsToChange != null)
            {
                tbUsername.Text = settings.Username;
                tbPassword.Text = settings.Password;
                tbIPAddress.Text = settings.IP;
                nudPort.Value = settings.Port;
            }
        }

        private void btnCancelChanges_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void btnSaveChanges_Click(object sender, EventArgs e)
        {
            //validate everything!!!!!!!
            try {
                if (tbUsername.Text == string.Empty) 
                    throw new ArgumentException("Ім'я користувача не може бути порожнім");
                //this method requires a IPaddress out argument which i don't need
                IPAddress address; 
                if (!IPAddress.TryParse((ReadOnlySpan<char>)tbIPAddress.Text, out address))
                    throw new ArgumentException("Ім'я користувача не може бути порожнім");
            }
            catch(Exception exc)
            {
                MessageBox.Show(exc.Message);
                return;
            }
            settingsToChange = new ClientConnectionSettings
            {
                Username = tbUsername.Text,
                Password = tbPassword.Text,
                IP = tbIPAddress.Text,
                Port = (ushort)nudPort.Value
            };
            settingsToChange.UpdateXml();
        }
    }
}
