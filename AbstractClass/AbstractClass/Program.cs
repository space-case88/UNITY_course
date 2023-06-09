using System;
using System.Collections.Generic;

namespace AbstractClass
{
    class Program
    {
        static void Main(string[] args)
        {
            Employee<string> employee1 = new Employee<string>()
            {
                FirstName = "Sample",
                LastName = "Student",
                Things = new List<string> { "Thing 1", "Thing 2", "Thing 3" }
            };

            Employee<int> employee2 = new Employee<int>()
            {
                FirstName = "John",
                LastName = "Snow",
                Things = new List<int> { 1, 2, 3, 4, 5 }
            };

            employee1.SayName();
            Console.WriteLine("Things: ");
            foreach (var thing in employee1.Things)
            {
                Console.WriteLine(thing);
            }

            employee2.SayName();
            Console.WriteLine("Things: ");
            foreach (var thing in employee2.Things)
            {
                Console.WriteLine(thing);
            }

            IQuittable quittableEmployee = employee1;
            quittableEmployee.Quit();

            Console.ReadLine();
        }
    }
}
