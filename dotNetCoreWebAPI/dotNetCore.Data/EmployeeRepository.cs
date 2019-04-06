using dotNetCore.Entities;

using System.Collections.Generic;

namespace dotNetCore.Data
{
    public class EmployeeRepository
    {
        public IEnumerable<Employee> GetAll()
        {
            return new List<Employee>()
            {
                new Employee() { EmployeeId=1, FirstName="fName1", LastName="lName1" },
                new Employee() { EmployeeId=2, FirstName="fName2", LastName="lName2" }
            };
        }

        public Employee Get(int employeeId)
        {
            return new Employee() { EmployeeId = employeeId, FirstName = $"fName{employeeId}", LastName = $"lName{employeeId}" };
        }

        public Employee Insert(Employee employee)
        {
            return employee;
        }

        public Employee Update(Employee employee)
        {
            return employee;
        }
    }
}
