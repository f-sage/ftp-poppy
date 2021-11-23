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
using System.Xml.Serialization;
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
        public GroupList loadedGroups;
        public MainForm()
        {
            InitializeComponent();
            serverRunning = false;
            logger = new Logger(tbLog);
            logger.Log("New session: "+DateTime.Now.ToString("G"));
            loadPresets();
        }

        private void loadPresets()
        {
            const string presetsFile = "presets.xml";
            if (!File.Exists(presetsFile))
            {
                var file = File.Create(presetsFile);
                file.Close();
            }

            // Construct an instance of the XmlSerializer with the type
            // of object that is being deserialized.
            var serializer = new XmlSerializer(typeof(GroupList));
            // To read the file, create a FileStream.
            using var fileStream = new FileStream(presetsFile, FileMode.Open);
            // Call the Deserialize method and cast to the object type.
            loadedGroups = (GroupList)serializer.Deserialize(fileStream);

            cmbGroupsUpdate();
        }

        public void cmbGroupsUpdate()
        {
            cmbGroup.Items.Clear();
            cmbGroup.Items.Insert(0, string.Empty);
            cmbGroup.Items.AddRange(
               loadedGroups.groups.Select(x => x.GroupName).ToArray());
        }

        public void loadedGroupsUpdate()
        {
            const string presetsFile = "presets.xml";
            StreamWriter writer = new StreamWriter(presetsFile);
            var tmp_serializer = new XmlSerializer(typeof(GroupList));
            tmp_serializer.Serialize(writer.BaseStream, loadedGroups);
            writer.Close();
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

        private void btnAddGroup_Click(object sender, EventArgs e)
        {
            GroupForm groupForm = new GroupForm(this);
            groupForm.ShowDialog();
        }

        private void cmbGroup_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (cmbGroup.SelectedItem == "") {
                btnAddGroup.Text = "Нова група...";
                tbPath.Text = "";
            }
            else
            {
                GroupPreset gr = loadedGroups.groups.Single(
                    g => g.GroupName == (string)cmbGroup.SelectedItem);
                btnAddGroup.Text = "Редагувати";
                tbPath.Text = gr.GroupDirectory;
            }
        }
    }
}
