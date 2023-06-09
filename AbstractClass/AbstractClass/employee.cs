using System;
using System.Collections.Generic;
using System.Text;

namespace AbstractClass
{
    class Employee<T> : Person, IQuittable
    {
        public List<T> Things { get; set; }

        //Override the SayName method from the base class
        public override void SayName()
        {
            Console.WriteLine($"Name: {FirstName} {LastName}");
        }

        //implement the Quit Method from the IQuittable interface
        public void Quit()
        {
            Console.WriteLine("Employee has quit the program.");
        }
    }
}
