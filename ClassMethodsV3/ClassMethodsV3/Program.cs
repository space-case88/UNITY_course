using System;

namespace ClassMethodsV3
{
    class Program
    {
        static void Main(string[] args)
        {
            MethodSub methodSub = new MethodSub();

            Console.Write("Enter the first number: ");
            int number1 = int.Parse(Console.ReadLine());

            Console.Write("Enter the second number (optional): ");
            string input = Console.ReadLine();

            int number2 = 0;
            if (!string.IsNullOrEmpty(input))
            {
                number2 = int.Parse(input);
            }

            int result = methodSub.PerformMathOperation(number1, number2);
            Console.WriteLine("The result of the math operation is: " + result);
        }
    }
}
