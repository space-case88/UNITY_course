using System;

namespace packageCheck
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Welcome. This is Package Express. Please contain your arms and legs and follow the instructions.");

            Console.WriteLine("Please enter the package weight: ");
            int weight = Convert.ToInt32(Console.ReadLine());

            if (weight > 50)
            {
                Console.WriteLine("Package too heavy to be shipped via Package Express. Too bad for you.");
                return;
            }

            Console.Write("Please enter the package width: ");
            int width = Convert.ToInt32(Console.ReadLine());

            Console.Write("Please enter the package height: ");
            int height = Convert.ToInt32(Console.ReadLine());

            Console.Write("Please enter the package length: ");
            int length = Convert.ToInt32(Console.ReadLine());

            int dimensionsTotal = width + height + length;

            if (dimensionsTotal > 50)
            {
                Console.WriteLine("Package too big to be shipped here, you should go somewhere else. Do your research!");
                return;
            }

            int quote = (width * height * length * weight) / 100;

            Console.WriteLine("The shipping quote is $" + quote);
        }
    }
}
