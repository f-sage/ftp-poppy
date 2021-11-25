using FluentFTP;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Net;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Serialization;

namespace ftp_poppy_client
{
    [Serializable]
    public class ClientConnectionSettings
    {
        const string settingsFile = "settings.xml";

        [XmlAttribute("username")]
        public string Username { get; set; }
        [XmlAttribute("password")]
        public string Password { get; set; }
        [XmlAttribute("port")]
        public ushort Port { get; set; }
        [XmlAttribute("ip-address")]
        public string IP { get; set; }

        public void GetFromFile()
        {
            if (!File.Exists(settingsFile))
            {
                var stream = File.Create(settingsFile);
                stream.Close();
            }
            if (new FileInfo(settingsFile).Length == 0)
            {
                using (var filestream = new FileStream(settingsFile, FileMode.Open))
                {
                    var serializer = new XmlSerializer(typeof(ClientConnectionSettings));
                    IP = "127.0.0.1";
                    Username = "test";
                    Password = "test";
                    Port = 21;
                    serializer.Serialize(filestream, this);
                }
                // filestream.Close();
            }
            else
            {
                var serializer = new XmlSerializer(typeof(ClientConnectionSettings));
                var filestream = new FileStream(settingsFile, FileMode.Open);
                var settingsFromFile = (ClientConnectionSettings)
                                        serializer.Deserialize(filestream);
                filestream.Close();
                Username = settingsFromFile.Username;
                Password = settingsFromFile.Password;
                Port = settingsFromFile.Port;
                IP = settingsFromFile.IP;
            }
        }
        public void UpdateXml()
        {
            using (var filestream = new FileStream(settingsFile, FileMode.Open))
            {
                var serializer = new XmlSerializer(typeof(ClientConnectionSettings));
                serializer.Serialize(filestream, this);
            }
        }
    }
}
