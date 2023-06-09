using System;
using System.Collections.Generic;
using System.Text;

namespace Overload
{
    public class Employee
    {
        public int Id { get; set; }
        public string Name { get; set; }

        public static bool operator ==(Employee emp1, Employee emp2)
        {
            return emp1.Id == emp2.Id;
        }

        public static bool operator !=(Employee emp1, Employee emp2)
        {
            return emp1.Id != emp2.Id;
        }
    }
}
