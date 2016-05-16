using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SomeApplication
{
    class Program
    {
        static void Main(string[] args)
        {
            #region Some tests

            var calc = new Calculator();

            var result = calc.Add(7, 5);

            Console.WriteLine(result == 12);

            #endregion
        }
    }
}
