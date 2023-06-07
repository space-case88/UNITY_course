using System;

namespace InheritanceV1
{
    class Program
    {
        static void Main(string[] args)
        {
            Employee employee = new Employee();
            employee.FirstName = "Casey";
            employee.LastName = "O'Neal";

            employee.SayName();

            //Wait for user input before closing program
            Console.ReadLine();
        }
    }
}
