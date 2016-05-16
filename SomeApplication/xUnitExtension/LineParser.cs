using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace xUnitExtension
{
    public class LineParser
    {
        public object[] ParseLine(string line)
        {
            return line.Split('|').Select(x => TryParse(x)).ToArray();
        }

        private object TryParse(string value)
        {
            var keyValue = value.Split(':');
            switch (keyValue[0])
            {
                case "int":
                    return int.Parse(keyValue[1]);
                case "string":
                    return keyValue[1];

                default:
                    return null;
            }
        }
    }
}
