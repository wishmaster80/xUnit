using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Xunit;

namespace SomeApplication.Tests
{
    public class EmployeeManagerTests
    {
        private static EmployeeManager GetEmployeeManagerForTests()
        {
            var emp = new Employee { Age = 22, Name = "Onizuka" };
            var empManager = new EmployeeManager();

            empManager.AddEmployee(emp);
            return empManager;
        }

        [Fact]
        public void TestAddingNewMembers()
        {
            var empManager = GetEmployeeManagerForTests();

            Assert.Equal(empManager.Employees.Count, 1);
        }

        [Theory]
        [InlineData(22, "Onizuka")]
        public void TestFirstItemContent(int expectedAge, string expectedName)
        {
            var empManager = GetEmployeeManagerForTests();

            var emp = new Employee {Age = expectedAge, Name = expectedName};

            Assert.Equal(empManager.Employees[0], emp);
        }

        [Fact]
        public void TestForException()
        {
            var empManager = new EmployeeManager();

            var myException = Assert.Throws<NullReferenceException>(() => empManager.RemoveEmployee(null));
        }
    }
}
