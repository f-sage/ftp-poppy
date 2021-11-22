using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using SharpServer;
using SharpServer.Ftp;

namespace ftp_poppy_server
{
    public partial class MainForm : Form
    {
        Logger logger;
        FileSystemWatcher fileWatcher;
        FtpServer ftpServer;
        bool serverRunning;
        public MainForm()
        {
            InitializeComponent();
            serverRunning = false;
            logger = new Logger(tbLog);
            logger.Log("New session: "+DateTime.Now.ToString("G"));
        }

        private void btnPathChange_Click(object sender, EventArgs e)
        {
            if (fbdPath.ShowDialog() == DialogResult.OK)
            {
                tbPath.Text = fbdPath.SelectedPath;
                logger.Log("New server folder path: " + fbdPath.SelectedPath);
            }
        }

        private void btnPathOpen_Click(object sender, EventArgs e)
        {
            string folderPath = tbPath.Text;
            if (string.IsNullOrEmpty(folderPath)) {
                MessageBox.Show("Шлях до папки порожній.");
                return;
            }
            if (Directory.Exists(folderPath))
            {
                ProcessStartInfo startInfo = new ProcessStartInfo
                {
                    Arguments = folderPath,
                    FileName = "explorer.exe"
                };
                Process.Start(startInfo);
            }
            else{
                MessageBox.Show(string.Format("Помилка. Такої директорії не існує:\r\n{0}", folderPath));
            }
        }

        private void btnStartStop_Click(object sender, EventArgs e)
        {
            if (!serverRunning)
            {
                //Start:
                //run server
                try
                {
                    RunServer();
                }
                catch(Exception exc)
                {
                    MessageBox.Show(exc.Message);
                    return;
                }
                //block settings pane if successful
                //change text
                btnStartStop.Text = "Закрити сервер";
            }
            else
            {
                //Stop:              
                //stop server
                StopServer();
                //enable settings pane if successful
                //change text
                btnStartStop.Text = "Запустити сервер";
            }
        }

        void RunServer()
        {
            //logger.Log("Attempt to run the server");
            //pass directory path and port to server
            ushort port = (ushort)nudPort.Value;
            string folderPath = tbPath.Text;
            if (string.IsNullOrEmpty(folderPath))
            {
                throw new DirectoryNotFoundException("Шлях до папки не може бути порожнім.");
            }
            if (Directory.Exists(folderPath))
            {
                SetupFileWatcher(folderPath);
                ftpServer = new FtpServer(port);
                
            }
            else
            {
                throw new DirectoryNotFoundException($"Такої директорії не існує:\r\n{folderPath}");
            }
            //RUN
            ftpServer.Start();
            logger.Log($"Server is running. Directory: \"{ folderPath}\"; port: {port}");
            serverRunning = true;
        }
        void StopServer()
        {
            //logger.Log("Stopping the server");
            ftpServer.Stop();
            logger.Log("Server stopped");
            fileWatcher = null;
            serverRunning = false;
        }

        void SetupFileWatcher(string folderPath)
        {
            fileWatcher = new FileSystemWatcher(folderPath);

            fileWatcher.NotifyFilter =
                                  //NotifyFilters.Attributes
                                  //      | NotifyFilters.CreationTime
                                  NotifyFilters.DirectoryName
                                 | NotifyFilters.FileName;
                               //  | NotifyFilters.LastAccess
                              //   | NotifyFilters.LastWrite
                              //   | NotifyFilters.Security;
                                // | NotifyFilters.Size;

            fileWatcher.Created += OnCreated;
            fileWatcher.Deleted += OnDeleted;
            fileWatcher.Changed += OnChanged;
            fileWatcher.Renamed += OnRenamed;


          //  fileWatcher.Filter = "*.txt";
            fileWatcher.IncludeSubdirectories = true;
            fileWatcher.EnableRaisingEvents = true;
        }
        delegate void SetLogCallback(object sender, FileSystemEventArgs e);

        private void OnCreated(object sender, FileSystemEventArgs e)
        {
            if (this.tbLog.InvokeRequired)
            {
                SetLogCallback d = new SetLogCallback(OnCreated);
                this.Invoke(d, new object[] { sender, e });
            }
            else
            {
                string objectType = Directory.Exists(e.FullPath) ? "folder" : "file";
                string value = $"New {objectType}: {e.Name}";
                logger.Log(value);
            }
        }

        private void OnDeleted(object sender, FileSystemEventArgs e)
        {
            if (this.tbLog.InvokeRequired)
            {
                SetLogCallback d = new SetLogCallback(OnDeleted);
                this.Invoke(d, new object[] { sender, e });
            }
            else
            {
                string objectType = Directory.Exists(e.FullPath) ? "Folder" : "File";
                string value = $"{objectType} deleted: {e.Name}";
                logger.Log(value);
            }
        }

        private void OnChanged(object sender, FileSystemEventArgs e)
        {
            if (this.tbLog.InvokeRequired)
            {
                SetLogCallback d = new SetLogCallback(OnChanged);
                this.Invoke(d, new object[] { sender, e });
            }
            else
            {
                string objectType = Directory.Exists(e.FullPath) ? "Folder" : "File";
                string value = $"{objectType} changed: {e.Name}";
                logger.Log(value);
            }
        }

        private void OnRenamed(object sender, FileSystemEventArgs e)
        {
            if (this.tbLog.InvokeRequired)
            {
                SetLogCallback d = new SetLogCallback(OnRenamed);
                this.Invoke(d, new object[] { sender, e });
            }
            else
            {
                string objectType =Directory.Exists(e.FullPath)?"Folder" :"File";
                string value = $"{objectType} renamed: {e.Name}";
                logger.Log(value);
            }
        }
    }
}
