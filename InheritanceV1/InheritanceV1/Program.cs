using System;

namespace InheritanceV1
{
    class Program
    {
        static void Main(string[] args)
        {
            Employee employee = new Employee();
            employee.FirstName = "Sample";
            employee.LastName = "Student";

            employee.SayName();

            //Wait for user input before closing program
            Console.ReadLine();
        }
    }
}
