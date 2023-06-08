using System;

namespace AbstractClass
{
    class Program
    {
        static void Main(string[] args)
        {
            Employee employee = new Employee()
            {
                FirstName = "Sample",
                LastName = "Student"
            };

            employee.SayName();
            Console.ReadLine();
        }
    }
}
