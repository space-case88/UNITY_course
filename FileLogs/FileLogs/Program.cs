using System;
using System.IO;

namespace FileLogs
{
    class Program
    {
        static void Main()
        {
            Console.WriteLine("Enter a number:");
            string userInput = Console.ReadLine();

            // Write the number to a text file
            string filePath = @"C:\Users\casey\GitHub\TxtLogs\log.txt";
            File.WriteAllText(filePath, userInput);

            Console.WriteLine("Number logged to file successfully!");

            // Read the contents of the text file
            string fileContent = File.ReadAllText(filePath);

            Console.WriteLine("Contents of the text file:");
            Console.WriteLine(fileContent);
        }
    }
}
