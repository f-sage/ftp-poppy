using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Net;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using FluentFTP;

namespace ftp_poppy_client
{
    public partial class MainFormClient : Form
    {
        FtpClient ftpClient;
        FtpClient ftpAnonClient;
        ClientConnectionSettings settings;

        const string labelText_NoDragDropAtm = "Перетягніть файли сюди для завантаження на сервер";
        const string labelText_DragDropAtm = "Відпустіть, щоб завантажити файли на сервер";

        public MainFormClient()
        {
            InitializeComponent();
            settings = new ClientConnectionSettings();
            settings.GetFromFile();
            ftpClient = new FtpClient();

            tbDownloadsPath.Text = Environment.GetFolderPath(Environment.SpecialFolder.MyDocuments);
            btnConnect_Click(new object(), new EventArgs());
        }

        void ConnectToServer()
        {
            ftpClient = new FtpClient
            {
                Host = settings.IP,
                Port = settings.Port,
                Credentials = new NetworkCredential
                {
                    UserName = settings.Username,
                    Password = settings.Password
                }
            };

            ftpAnonClient = new FtpClient
            {
                Host = settings.IP,
                Port = settings.Port,
                Credentials = new NetworkCredential
                {
                    UserName = settings.Username,
                    Password = ""
                }
            };

            ftpClient.Connect();
            ftpAnonClient.Connect();
            RefreshFiles();
        }

        private void pnDragDrop_DragDrop(object sender, DragEventArgs e)
        {
            string[] files = e.Data.GetData(DataFormats.FileDrop) as string[]; // get all files dropped 
            if (files != null && files.Any())
            {
                foreach(var file in files)
                {
                    UploadFile(file);
                }
            }

            lblDragDrop.Text = labelText_NoDragDropAtm;
        }

        private void pnDragDrop_DragOver(object sender, DragEventArgs e)
        {
            if (e.Data.GetDataPresent(DataFormats.FileDrop))
                e.Effect = DragDropEffects.Link;
            else
                e.Effect = DragDropEffects.None;
        }

        private void pnDragDrop_DragEnter(object sender, DragEventArgs e)
        {
            lblDragDrop.Text = labelText_DragDropAtm;
        }

        private void pnDragDrop_DragLeave(object sender, EventArgs e)
        {
            lblDragDrop.Text = labelText_NoDragDropAtm;
        }

        private void btnConnect_Click(object sender, EventArgs e)
        {
            try { 
                ConnectToServer();
                if (ftpClient.IsAuthenticated)
                {
                    AddMessage("Підключення до сервера успішне");
                    btnConnect.Enabled = false;
                    RefreshFiles();
                }
                else
                {
                    AddMessage("Не вдалося підключитися до сервера.");
                }
            }
            catch(Exception exc)
            {
                AddMessage("Не вдалося підключитися до сервера: "+exc.Message);
                return;
            }

        }

        private void налаштуванняToolStripMenuItem_Click(object sender, EventArgs e)
        {
            new SettingsForm(settings).ShowDialog();
        }

        void UploadFile(string filePath)
        {
            string result;
            string remotePath = Path.GetFileName(filePath);
            if(ftpClient.UploadFile(filePath, remotePath) == FtpStatus.Success)
            {
                result = $"Файл \"{remotePath}\" успішно завантажено на сервер";
            }
            else {
                result = $"Не вдалось відправити на сервер файл \"{remotePath}\"";
            }
            AddMessage(result);
            RefreshFiles();
        }

        void AddMessage(string msg)
        {
            if (!string.IsNullOrEmpty(tbLog.Text))
            {
                tbLog.Text += "\r\n";
            }
            tbLog.Text += msg;
        }

        void GetFiles(FtpClient client, ListBox listBox)
        {
            client.Connect();
            FtpListItem[] files = client.GetListing("");
            foreach (var item in files)
            {
                listBox.Items.Add(item.FullName);
            }
        }

        private void btnRefresh_Click(object sender, EventArgs e)
        {
            RefreshFiles();
        }

        void RefreshFiles()
        {
            lbTaskFiles.Items.Clear();
            lbUsersFiles.Items.Clear();
            GetFiles(ftpClient, lbUsersFiles);
            GetFiles(ftpAnonClient, lbTaskFiles);
        }

        void DownloadFiles(FtpClient client, List<string> filenames)
        {
            foreach(string file in filenames)
            {
                string filename = file.TrimStart('/');
                string localPath = Path.Combine(tbDownloadsPath.Text, filename);
                FtpStatus result = client.DownloadFile(localPath, filename);   
                if (result == FtpStatus.Success)
                {
                    AddMessage($"Успішно отримано файл \"{file}\" з сервера");
                }
                else if(result == FtpStatus.Failed)
                {
                    AddMessage($"Не вдалося отримати файл \"{file}\" з сервера");
                }
            }
        }

        private void btnChangeDownloadsPath_Click(object sender, EventArgs e)
        {
            if (fbdDownloadsPath.ShowDialog() == DialogResult.OK)
            {
                tbDownloadsPath.Text = fbdDownloadsPath.SelectedPath;
            }
        }

        private void btnDownloadAllTeacherFiles_Click(object sender, EventArgs e)
        {
            List<string> filenames = lbTaskFiles.Items.Cast<string>().ToList();
            DownloadFiles(ftpAnonClient, filenames);
        }


        private void btnDownloadChosenTeacherFiles_Click(object sender, EventArgs e)
        {
            List<string> filenames = lbTaskFiles.SelectedItems.Cast<string>().ToList();
            DownloadFiles(ftpAnonClient, filenames);
        }

        private void btnDownloadAllUserFiles_Click(object sender, EventArgs e)
        {
            List<string> filenames = lbUsersFiles.Items.Cast<string>().ToList();
            DownloadFiles(ftpClient, filenames);
        }

        private void btnDownloadChosenUserFiles_Click(object sender, EventArgs e)
        {
            List<string> filenames = lbUsersFiles.SelectedItems.Cast<string>().ToList();
            DownloadFiles(ftpClient, filenames);
        }
    }
}
