using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Xunit.Sdk;

namespace xUnitExtension
{
    public class FileDataAttribute : DataAttribute
    {
        private string _fileName;
        private FileLineReader _fr = new FileLineReader();
        private LineParser _lp = new LineParser();
        public FileDataAttribute(string fileName)
        {
            _fileName = fileName;
        }

        public override IEnumerable<object[]> GetData(System.Reflection.MethodInfo testMethod)
        {
           

            foreach (var line in ReadFile())
            {
                yield return line;
            }
        }

        private IEnumerable<object[]> ReadFile()
        {
            return
                _fr.GetLines(_fileName).Select(i => _lp.ParseLine(i));

        }
    }
}
