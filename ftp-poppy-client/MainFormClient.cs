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
using Syroot.Windows.IO;

namespace ftp_poppy_client
{
    public partial class MainFormClient : Form
    {
        FtpClient ftpClient;
       
        public MainFormClient()
        {
            InitializeComponent();
            ConnectToServer();
        }

        void ConnectToServer()
        {
            ftpClient = new FtpClient("127.0.0.1", "anonymous", "");
            ftpClient.Connect();

            string downloadsPath = new KnownFolder(KnownFolderType.Downloads).Path;
            string fileToDownload = "txtfile.txt";

            ftpClient.DownloadFile(downloadsPath, fileToDownload);
        }

        private void pnDragDrop_DragDrop(object sender, DragEventArgs e)
        {
            string[] files = e.Data.GetData(DataFormats.FileDrop) as string[]; // get all files droppeds  
            if (files != null && files.Any())
                tbFileName.Text = files.First(); //select the first one 

            lblDragDrop.Text = "Перетягніть файли сюди для завантаження";
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
            lblDragDrop.Text = "Відпустіть, щоб завантажити файли на сервер";
        }

        private void pnDragDrop_DragLeave(object sender, EventArgs e)
        {
            lblDragDrop.Text = "Перетягніть файли сюди для завантаження";
        }
    }
}
