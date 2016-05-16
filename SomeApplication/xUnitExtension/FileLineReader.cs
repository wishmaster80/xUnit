using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace xUnitExtension
{
    public class FileLineReader
    {
        public IEnumerable<string> GetLines(string fileName)
        {
            var lines = new List<string>();
            using (StreamReader sr = new StreamReader(fileName))
            {                
                String line = sr.ReadLine();
                lines.Add(line);
            }
            return lines;
        }
    }
}
