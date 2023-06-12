using System;
using System.Collections.Generic;
using System.Linq;

namespace LambdaExpression
{
    class Program
    {
        static void Main()
        {
            List<Employee> employees = new List<Employee>()
            {
                new Employee { FirstName = "Joe", LastName = "Shmoe", Id = 1 },
                new Employee { FirstName = "Jon", LastName = "Snow", Id = 2 },
                new Employee { FirstName = "Jane", LastName = "Poe", Id = 3 },
                new Employee { FirstName = "Joe", LastName = "Flow", Id = 4 },
                new Employee { FirstName = "Michael", LastName = "Stoe", Id = 5 },
                new Employee { FirstName = "Jessica", LastName = "Slow", Id = 6 },
                new Employee { FirstName = "Joe", LastName = "Hoe", Id = 7 },
                new Employee { FirstName = "Emily", LastName = "Toe", Id = 8 },
                new Employee { FirstName = "Daniel", LastName = "Go", Id = 9 },
                new Employee { FirstName = "Sarah", LastName = "Doe", Id = 10 }
            };

            //Using a foreach loop to find the two 'Joes'
            List<Employee> joes1 = new List<Employee>();
            foreach (Employee employee in employees)
            {
                if (employee.FirstName == "Joe")
                {
                    joes1.Add(employee);
                }
            }

            Console.WriteLine("Employees with first name \"Joe\" (using foreach loop):");
            foreach (Employee joe in joes1)
            {
                Console.WriteLine($"{joe.FirstName} {joe.LastName}, Id: {joe.Id}");
            }

            //Using lambda to find the Joes
            List<Employee> joes2 = employees.Where(employee => employee.FirstName == "Joe").ToList();

            Console.WriteLine("\nEmployees with first name \"Joe\" (using lambda expression):");
            foreach (Employee joe in joes2)
            {
                Console.WriteLine($"{joe.FirstName} {joe.LastName}, Id: {joe.Id}");
            }

            //Using lambda to find employees with ID greater than 5
            List<Employee> employeesWithIdGreaterThan5 = employees.Where(employee => employee.Id > 5).ToList();

            Console.WriteLine("\nEmployees with Id greater than 5 (using lambda expression):");
            foreach (Employee employee in employeesWithIdGreaterThan5)
            {
                Console.WriteLine($"{employee.FirstName} {employee.LastName}, Id: {employee.Id}");
            }
        }
    }
}
