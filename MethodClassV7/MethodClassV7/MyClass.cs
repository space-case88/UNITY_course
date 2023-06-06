using System;
using System.Collections.Generic;
using System.Text;

namespace MethodClassV7
{
    class MyClass
    {
        public int DividedByTwo(int number)
        {
            return number / 2;
        }

        public void MethodWithOutputParams(int input, out int output1, out int output2)
        {
            output1 = input * 2;
            output2 = input * 3;
        }

        public void OverloadedMethod(int number)
        {
            Console.WriteLine("OverloadedMethod(int): " + (number * 2));
        }

        public void OverloadedMethod(int number, string message)
        {
            Console.WriteLine("OverloadedMethod(int, string): " + message + (number * 3));
        }
    }

    static class StaticClass
    {
        public static void StaticMethod()
        {
            Console.WriteLine("This is a static method.");
        }
    }
}
