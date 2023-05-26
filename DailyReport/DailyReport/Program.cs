using System;

namespace DailyReport
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("The Tech Academy");
            Console.WriteLine("Student Daily Report");
            Console.WriteLine();

            //Asking for and saving data
            Console.Write("What is your name? ");
                string name = Console.ReadLine();

            Console.Write("What course are you in? ");
                string course = Console.ReadLine();

            Console.Write("What page number? ");
                int pageNumber = Convert.ToInt32(Console.ReadLine());

            Console.Write("Do you need help with anything? Please answer \"true\" or \"false\": ");
                bool needsHelp = Convert.ToBoolean(Console.ReadLine());

            Console.Write("Were there any positive experiences you’d like to share? Please give specifics: ");
                string positiveExperiences = Console.ReadLine();

            Console.Write("Is there any other feedback you’d like to provide? Please be specific: ");
                string feedback = Console.ReadLine();

            Console.Write("How many hours did you study today? ");
            double studyHours = Convert.ToDouble(Console.ReadLine());

            Console.WriteLine();
            Console.WriteLine("Thank you for your answers. An Instructor will respond to this shortly. Have a great day!");
            Console.ReadLine();

        }
    }
}
