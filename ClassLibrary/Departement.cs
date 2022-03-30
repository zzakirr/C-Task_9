using System;
using System.Collections.Generic;
using System.Text;

namespace ClassLibrary
{
    public class Departement
    {
        public string Name;
        public int EmployeeLimit;
        public int SalaryLimit;
        public Employee[] Employees = new Employee[0];
        public void AddEmployee(Employee employee)
        {
            if(Employees.Length <= EmployeeLimit)
            {
                Array.Resize(ref Employees, Employees.Length + 1);
                Employees[Employees.Length - 1] = employee;
            }
            
        }
        public void GetInfoEmployees()
        {
            foreach (var item in Employees)
            {
                Console.WriteLine($"Name:{item.Name} Surname:{item.Surname} Salary:{item.Salary}");
            }

        }
    }
}
