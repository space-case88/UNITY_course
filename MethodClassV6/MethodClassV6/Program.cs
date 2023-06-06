using System;

namespace MethodClassV6
{
    class Program
    {
        static void Main(string[] args)
        {
            MyClass myObject = new MyClass();
            myObject.MyMethod(5, 10);
            myObject.MyMethod(firstNumber: 7, secondNumber: 15);

            Console.ReadLine(); 
        }
    }
}
