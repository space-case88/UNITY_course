using System;

namespace StringsArrays2
{
    class Program
    {
        static void Main()
        {
            //Define the array of strings
            string[] stringsArray = new string[7];

            //Ask user for input
            Console.WriteLine("Enter some text:");
            string userInput = Console.ReadLine();

            //Add user's text input to the end of each string
            for (int i = 0; i < stringsArray.Length; i++)
            {
                stringsArray[i] = stringsArray[i] + userInput;
            }

            //Print each string in the array on a seperate line
            foreach (string str in stringsArray)
            {
                Console.WriteLine(str);
            }

            while (true)
            {
                Console.WriteLine("This is an infinite loop. Press any key to exit.");
                Console.ReadLine();
                break;  //adding a break to exit the loop
            }

            int counter1 = 0;
            while (counter1 < 5)
            {
                Console.WriteLine("Loop with < comparison operator. Counter: " + counter1);
                counter1++;
            }

            // Infinite loop with <= comparison
            int counter2 = 0;
            do
            {
                Console.WriteLine("Loop with <= comparison. Counter: " + counter2);
            } while (counter2 <= 5);

            Console.ReadLine();
        }
    }
}
