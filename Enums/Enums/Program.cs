using System;

namespace Enums
{
    public class Program
    {
        public enum DaysOfWeek
        {
            Monday,
            Tuesday,
            Wednesday,
            Thursday,
            Friday,
            Saturday,
            Sunday
        }
        public static void Main()
        {
            try
            {
                Console.Write("Enter the current day of the week: ");
                string input = Console.ReadLine();

                // Parsing user input to the enum
                DaysOfWeek currentDay = (DaysOfWeek)Enum.Parse(typeof(DaysOfWeek), input, true);

                // Print the current day
                Console.WriteLine("Current day: " + currentDay);
            }
            catch (Exception)
            {
                Console.WriteLine("Please enter an actual day of the week.");
            }
        }
    }
}
