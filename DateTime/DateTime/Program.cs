using System;
using System.IO;

namespace DateTimeExample
{
    class Program
    {
        static void Main()
        {
            // Print the current date and time
            Console.WriteLine("Current date and time: " + DateTime.Now);

            // User number input
            Console.Write("Enter a number: ");
            string input = Console.ReadLine();

            int hours;
            if (int.TryParse(input, out hours))
            {
                // Calculates the future date and time
                DateTime futureTime = DateTime.Now.AddHours(hours);
                // Print the future
                Console.WriteLine("In {0} hours, it will be: {1}", hours, futureTime);
            }
            else
            {
                Console.WriteLine("Invalid input. Please enter a valid number.");
            }

            Console.ReadLine();
        }
    }
}
