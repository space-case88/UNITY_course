using System;

namespace mainMethod
{
    class Program
    {
        static void Main()
        {
            IntMethod calculator = new IntMethod();

            int result1 = calculator.Calculate(10);
            Console.WriteLine("Result 1: " + result1);

            int result2 = calculator.Calculate(7.5m);
            Console.WriteLine("Result 2: " + result2);

            int result3 = calculator.Calculate("15");
            Console.WriteLine("Result 3: " + result3);

            Console.ReadLine();
        }
    }
}
