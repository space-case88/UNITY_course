using System;

namespace DoWhile
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("While comparison");
            WhileComparison();

            Console.WriteLine("\nDo-While comparison:");
            DoWhileComparison();

            Console.ReadLine();

        }

        static void WhileComparison()
        {
            int num = 0;

            while (num < 5)
            {
                Console.WriteLine("Number: " + num);
                num++;
            }
        }

        static void DoWhileComparison()
        {
            int num = 0;

            do
            {
                Console.WriteLine("Number: " + num);
                num++;
            } while (num < 5);
        }
    }
}
