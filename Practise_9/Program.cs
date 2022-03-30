using System;
using ClassLibrary;
namespace Practise_9
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Departement departement = new Departement();
            Console.WriteLine("Ischinin sayini daxil edin:");
            departement.EmployeeLimit = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Ischinin maas limitini daxil edin:");
            departement.SalaryLimit = Convert.ToInt32(Console.ReadLine());
            for (int i = 0; i < departement.EmployeeLimit; i++)
            {
                Console.WriteLine("Ischinin adini daxil edin:");
                string name = Console.ReadLine();
                Console.WriteLine("Ischinin soyadini daxil edin:");
                string surname = Console.ReadLine();
                Console.WriteLine(" Ischinin maasini daxil edin:");
                int salary = Convert.ToInt32(Console.ReadLine());
                while(salary > departement.SalaryLimit)
                {
                    Console.WriteLine(" Ischinin maasi maas limitini kecir!");
                    salary = Convert.ToInt32(Console.ReadLine());
                }
                Employee employee = new Employee()
                {
                    Name = name,
                    Surname = surname,
                    Salary = salary
                };
                departement.AddEmployee(employee);
            }
            departement.GetInfoEmployees();

        }
        
    }
    
}
