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
        public static Dictionary<string, string> GetProperties(string filepath)
        {
            var data = new Dictionary<string, string>();

            foreach (var row in File.ReadAllLines(filepath))
                data.Add(row.Split('=')[0], string.Join("=", row.Split('=').Skip(1).ToArray()));

            return data;
        }
    }
}
