using System;

namespace StructExercise
{
    public struct Number
    {
        public decimal Amount { get; set; }
    }
    class Program
    {
        public static void Main()
        {
            Number number = new Number();
            number.Amount = 10.5m;

            Console.WriteLine("Number amount: " + number.Amount);
        }
    }
}
