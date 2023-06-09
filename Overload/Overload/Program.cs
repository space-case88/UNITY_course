using System;

namespace Overload
{
    class Program
    {
        static void Main(string[] args)
        {
            Employee emp1 = new Employee { Id = 1, Name = "John" };
            Employee emp2 = new Employee { Id = 2, Name = "Jane" };
            Employee emp3 = new Employee { Id = 1, Name = "John" };

            Console.WriteLine(emp1 == emp2);  // False
            Console.WriteLine(emp1 == emp3);  // True

            Console.WriteLine(emp1 != emp2);  // True
            Console.WriteLine(emp1 != emp3);  // False
        }
    }
}
