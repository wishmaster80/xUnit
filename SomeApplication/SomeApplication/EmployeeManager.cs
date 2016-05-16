using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.AccessControl;
using System.Text;
using System.Threading.Tasks;

namespace SomeApplication
{
    public class EmployeeManager
    {
        private IEnumerable<Employee> _employees;

        public IList<Employee> Employees
        {
            get { return _employees as List<Employee>; }
        }

        public EmployeeManager()
        {
            _employees = new List<Employee>();
        }

        public void AddEmployee(Employee employee)
        {
            (_employees as IList<Employee>).Add(employee);
        }

        public void RemoveEmployee(Employee employee)
        {
            throw new NullReferenceException();
        }
    }
}
