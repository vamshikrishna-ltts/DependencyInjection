using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using DependencyInjection.Models;
namespace DependencyInjection.EmployeeService
{
    public class MockEmployee : IEmployee
    {
        private List<Employee> employees = new List<Employee>() {
        new Employee(){ id = 1, Name = "First Employee"},
        new Employee(){ id = 2, Name = "Second Employee"}
        };
        public List<Employee> GetEmployees()
        {
            return employees;
        }
       public Employee getEmployee(int id) {
            throw new NotImplementedException();
        }
       public   Employee AddNewEmployee(Employee employee) {
            throw new NotImplementedException();
        }

       public   void DeleteEmployee(Employee employee) {
            throw new NotImplementedException();
        }

      public  Employee EditEmployee(Employee employee) {
            throw new NotImplementedException();
        }

        public List<Employee> getEmployees()
        {
            throw new NotImplementedException();
        }
    }
}
