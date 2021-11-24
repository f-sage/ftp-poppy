using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.IO;

namespace SharpServer
{
   public static class HomeDirectory
    {
        private static string _value;
        public static string Value{
            get { return _value; }
            set
            {
                if (value != string.Empty&&!Directory.Exists(value)) {
                    throw new ArgumentException("Invalid path for a root folder");
                }
                _value = value;
            }
        }

    }
}
