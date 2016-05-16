using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SomeApplication
{
    public class Employee
    {
        public string Name { get; set; }
        public int Age { get; set; }

        public override bool Equals(object obj)
        {
            if(!(obj is Employee))
                return false;

            var objToCompare = obj as Employee;

            if (objToCompare.Name == this.Name && objToCompare.Age == this.Age)
                return true;

            return false;
        }
    }
}
