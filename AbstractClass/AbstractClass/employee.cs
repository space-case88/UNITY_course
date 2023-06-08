using System;
using System.Collections.Generic;
using System.Text;

namespace AbstractClass
{
    class Employee : Person, IQuittable
    {
        public override void SayName()
        {
            Console.WriteLine($"Name: {FirstName} {LastName}");
        }

        public void Quit()
        {
            Console.WriteLine("Employee has quit the program.");
        }
    }
}
