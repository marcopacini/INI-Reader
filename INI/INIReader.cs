using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace INI
{
    public class INIReader
    {
        private Dictionary<string, string> properties;

        public INIReader()
        {
            this.properties = new Dictionary<string, string>();
        }

        public INIReader(string filepath)
        {
            properties = INIReader.GetProperties(filepath);
        }

        public string getProperty(string key)
        {
            return properties[key];
        }

        public void setProperty(string key, string value)
        {
            properties[key] = value;
        }

        /* Static Methods */
        public static Dictionary<string, string> GetProperties(string filepath)
        {
            var data = new Dictionary<string, string>();

            foreach (var row in File.ReadAllLines(filepath))
                data.Add(row.Split('=')[0], string.Join("=", row.Split('=').Skip(1).ToArray()));

            return data;
        }           
    }
}
