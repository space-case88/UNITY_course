﻿using System;
using System.Collections.Generic;
using System.Text;

namespace AbstractClass
{
    class Employee : Person
    {
        public override void SayName()
        {
            Console.WriteLine($"Name: {FirstName} {LastName}");
        }
    }
}
