using System;
using System.Collections.Generic;


namespace step203
{
    class Program
    {
        static void Main()
        {
            List<int> numbers = new List<int> { 10, 20, 30, 40, 50 };

            Console.Write("Enter a number to divide each element in the list by: ");
            string input = Console.ReadLine();

            int divisor;
            bool isValidNumber = int.TryParse(input, out divisor);

            try
            {
                if(isValidNumber)
                {
                    for (int i = 0; i < numbers.Count; i++)
                    {
                        int result = numbers[i] / divisor;
                        Console.WriteLine($"Result of division: {result}");
                    }
                }
                else
                {
                    throw new ArgumentException("Invalid number entered.");
                }
            }
            catch (Exception ex)
            {
                Console.WriteLine($"Error: {ex.Message}");
            }

            Console.WriteLine("Pogram execution continued after the try/catch block.");

            Console.ReadLine();
        }
    }
}
