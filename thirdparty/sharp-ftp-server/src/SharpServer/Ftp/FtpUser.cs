using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Xml.Serialization;

namespace SharpServer
{
    [Serializable]
    public class FtpUser
    {
        [XmlAttribute("username")]
        public string UserName { get; set; }

        [XmlAttribute("password")]
        public string Password { get; set; }

        public string HomeDir
        {
            get
            {
                 return Path.Combine(HomeDirectory.Value, Folder);
            }
        }

        [XmlAttribute("folder")]
        public string Folder { get; set; }

        [XmlAttribute("twofactorsecret")]
        public string TwoFactorSecret { get; set; }

        [XmlIgnore]
        public bool IsAnonymous { get; set; }
    }

    //a static container for all the users retrieved from xml
    public static class FtpUserStore
    {
        static List<FtpUser> _users;
        public static List<FtpUser> Users { get { return _users; } }

        /// <summary>
        /// Adds an FtpUser to the current loaded userbase.
        /// Use Update() to same the changes to the XML file.
        /// </summary>
        /// <param name="user"></param>
        public static void AddUser(FtpUser user)
        {
            var existingUser = _users.FirstOrDefault(x=>x.UserName==user.UserName);
            if (existingUser != null)
            {
                throw new ArgumentException("User with that name already exists.");
            }
            else
            {
                _users.Add(user);
            }
        }
        public static void RemoveUser(FtpUser user)
        {
            _users.Remove(user);
        }

        /// <summary>
        /// Fills the XML file with the current user list.
        /// </summary>
        public static void Update()
        {
            XmlSerializer serializer = new XmlSerializer(_users.GetType(), 
                new XmlRootAttribute("Users"));

            using (StreamWriter w = new StreamWriter("users.xml"))
            {
                serializer.Serialize(w, _users);
                w.Close();
            }
        }

        static FtpUserStore()
        {
            _users = new List<FtpUser>();

            XmlSerializer serializer = new XmlSerializer(_users.GetType(), new XmlRootAttribute("Users"));

            if (File.Exists("users.xml"))
            {
                var streamreader = new StreamReader("users.xml");
                _users = serializer.Deserialize(streamreader) as List<FtpUser>;
                streamreader.Close();
            }
            else
            {
                //create a file!!
                _users.Add(new FtpUser
                {
                    UserName = "test",
                    Password = "test",
                    Folder = "task"
                });

                using (StreamWriter w = new StreamWriter("users.xml"))
                {
                    serializer.Serialize(w, _users);
                    w.Close();
                }
            }
        }

        public static FtpUser Validate(string username, string password)
        {
            FtpUser user = (from u in _users where u.UserName == username && u.Password == password select u).SingleOrDefault();

            if (user == null)
            {
                user = new FtpUser
                {
                    UserName = username,
                    Folder = "task",
                    IsAnonymous = true
                };
            }

            return user;
        }


        public static FtpUser Validate(string username, string password, string twoFactorCode)
        {
            FtpUser user = (from u in _users where u.UserName == username && u.Password == password select u).SingleOrDefault();

            if (TwoFactor.TimeBasedOneTimePassword.IsValid(user.TwoFactorSecret, twoFactorCode))
            {
                return user;
            }

            return null;
        }
    }
}
