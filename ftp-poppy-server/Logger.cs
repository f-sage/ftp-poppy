using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ftp_poppy_server
{
    class Logger
    {
        TextBox textbox;
        public string Path { get; private set; }
        public bool FileLoggingEnabled { get; private set; }
        public string LogFile { get; private set; }

        public Action<string> Log; 

        public Logger(TextBox textbox)
        {
            this.textbox = textbox;
            FileLoggingEnabled = false;
            Log += writeToTextbox;
        }

        public void EnableFileLogging(string filePath)
        {
            if (File.Exists(filePath)){
                FileLoggingEnabled = true;
                LogFile = filePath;
                Log += writeToFile;
            }
        }

        delegate void SetTextCallback(string text);
        void writeToTextbox(string message)
        {
            string time = DateTime.Now.ToString("T");
            message = time + " > " + message;
            if (!string.IsNullOrEmpty(textbox.Text))
            {
                textbox.Text += "\r\n";
            }
            textbox.Text += message;
        }

        void writeToFile(string message)
        {
            throw new NotImplementedException();
        }
    }
}
