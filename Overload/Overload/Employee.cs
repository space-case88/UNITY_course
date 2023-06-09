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
            if (ReferenceEquals(emp1, emp2))
                return true;

            if (ReferenceEquals(emp1, null) || ReferenceEquals(emp2, null))
                return false;

            return emp1.Id == emp2.Id;
        }

        public static bool operator !=(Employee emp1, Employee emp2)
        {
            return !(emp1 == emp2);
        }

        public override bool Equals(object obj)
        {
            if (obj == null || GetType() != obj.GetType())
                return false;

            Employee other = (Employee)obj;
            return Id == other.Id;
        }

        public override int GetHashCode()
        {
            return Id.GetHashCode();
        }
    }
}
