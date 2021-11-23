using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Serialization;

namespace ftp_poppy_server
{

    [XmlRoot("groups")]
    public class GroupList
    {
        public GroupList() { groups = new List<GroupPreset>(); }
        [XmlElement("group")]
        public List<GroupPreset> groups { get; set; }
    }

    [Serializable]
    public class GroupPreset
    {
        [XmlAttribute("Name")]
        public string GroupName { get; set; }

        [XmlAttribute("Directory")]
        public string GroupDirectory { get; set; }
       
        public GroupPreset()
        {

        }
        public GroupPreset(string name, string directory)
        {
            if (string.IsNullOrEmpty(name)) 
                throw new ArgumentException("Name cannot be empty.");
            if (!Directory.Exists(directory))
                throw new ArgumentException("Specified directory path is invalid");
            else{
                this.GroupDirectory = directory;
                this.GroupName = name;
            }
        }

    }
}
