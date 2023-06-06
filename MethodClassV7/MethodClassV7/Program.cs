using System;

namespace MethodClassV7
{
    class Program
    {
        static void Main()
        {
            // instantiate class
            MyClass myObject = new MyClass();

            // User input
            Console.WriteLine("Enter a number: ");
            int userInput = Convert.ToInt32(Console.ReadLine());

            // call the method and display output
            int result = myObject.DividedByTwo(userInput);
            Console.WriteLine("Result: " + result);

            // call the method with output parameters
            int outputParam1, outputParam2;
            myObject.MethodWithOutputParams(userInput, out outputParam1, out outputParam2);
            Console.WriteLine("Output Parameter 1: " + outputParam1);
            Console.WriteLine("Output Parameter 2: " + outputParam2);

            // Overloaded method
            myObject.OverloadedMethod(userInput);
            myObject.OverloadedMethod(userInput, userInput.ToString());

            // Static class
            StaticClass.StaticMethod();
        }
    }
}
