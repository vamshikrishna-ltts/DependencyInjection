using DependencyInjection.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace DependencyInjection.EmployeeService
{
   public interface IEmployee
    {

        List<Employee> getEmployees();

        Employee getEmployee(int id);
        Employee AddNewEmployee(Employee employee);

        void DeleteEmployee(Employee employee);

        Employee EditEmployee(Employee employee);
    }
}
