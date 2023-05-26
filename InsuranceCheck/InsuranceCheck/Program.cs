using System;

namespace InsuranceCheck
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Car Insurance Approval Program");
            Console.WriteLine();

            //Applicant age input
            Console.WriteLine("What is your age?");
            int age = int.Parse(Console.ReadLine());

            //Applicant's DUI input
            Console.WriteLine("Have you ever had a DUI? (true/false)");
            bool hasDUI = bool.Parse(Console.ReadLine());

            //Speeding input
            Console.WriteLine("How many speeding tickets do you have?");
            int speedingTickets = int.Parse(Console.ReadLine());

            //Qualifications input
            bool isQualified = (age > 15) && !hasDUI && (speedingTickets <= 3);

            //Result
            Console.WriteLine();
            Console.WriteLine("Qualified for car insurance: " + isQualified);

            Console.ReadLine();
        }
    }
}
