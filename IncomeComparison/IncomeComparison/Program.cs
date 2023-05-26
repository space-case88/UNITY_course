using System;

namespace IncomeComparison
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Anonymous Income Comparison Program");
            Console.WriteLine();

            // Person 1
            Console.WriteLine("Person 1");
            Console.WriteLine("Enter hourly rate:");
            double person1HourlyRate = double.Parse(Console.ReadLine());
            Console.WriteLine("Enter hours worked per week:");
            double person1HoursWorked = double.Parse(Console.ReadLine());

            // Person 2
            Console.WriteLine("Person 2");
            Console.WriteLine("Enter hourly rate:");
            double person2HourlyRate = double.Parse(Console.ReadLine());
            Console.WriteLine("Enter hours worked per week:");
            double person2HoursWorked = double.Parse(Console.ReadLine());

            //Calculate annual salaries
            double person1AnnualSalary = person1HourlyRate * person1HoursWorked * 52;
            double person2AnnualSalary = person2HourlyRate * person1HoursWorked * 52;

            //Print Annual Salary
            Console.WriteLine();
            Console.WriteLine("Annual salary of person 1: " + person1AnnualSalary);
            Console.WriteLine("Annual salary of person 2: " + person2AnnualSalary);

            //Comparison of salaries
            bool person1MakesMore = person1AnnualSalary > person2AnnualSalary;

            //Print Comparison
            Console.WriteLine();
            Console.WriteLine("Does person 1 make more money than person 2? " + person1MakesMore);

            Console.ReadLine();
        }
    }
}
