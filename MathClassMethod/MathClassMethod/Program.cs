using System;

namespace MathClassMethod
{
    class Program
    {
        static void Main()
        {
            Console.Write("Enter a number: ");
            int userInput = int.Parse(Console.ReadLine());

            MClass mathOperations = new MClass();

            int result1 = mathOperations.AddOne(userInput);
            Console.WriteLine($"Result 1: {result1}");

            int result2 = mathOperations.MultiplyByTwo(userInput);
            Console.WriteLine($"Result 2: {result2}");

            int result3 = mathOperations.Square(userInput);
            Console.WriteLine($"Result 3: {result3}");

            Console.ReadLine();
        }
    }
}
