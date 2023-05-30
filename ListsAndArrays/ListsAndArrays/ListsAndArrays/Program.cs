using System;
using System.Collections.Generic;



    class Program
    {
        static void Main()
        {
            // Create a one-dimensional array of strings
            string[] stringArray = { "Apple", "Banana", "Orange" };

            // Create a one-dimensional array of integers
            int[] intArray = { 1, 2, 3, 4, 5 };

            // Select an index for the string array
            Console.WriteLine("Select an index for the string array (0-2):");
            int stringIndex = Convert.ToInt32(Console.ReadLine());

            // Check if the selected index is within the range of the string array
            if (stringIndex >= 0 && stringIndex < stringArray.Length)
            {
                Console.WriteLine("Selected index: " + stringIndex);
                Console.WriteLine("String at index " + stringIndex + ": " + stringArray[stringIndex]);
            }
            else
            {
                Console.WriteLine("Invalid index. Index doesn't exist.");
            }

            Console.WriteLine();

            // Select an index for the integer array
            Console.WriteLine("Select an index for the integer array (0-4):");
            int intIndex = Convert.ToInt32(Console.ReadLine());

            // Check if the selected index is within the range of the integer array
            if (intIndex >= 0 && intIndex < intArray.Length)
            {
                Console.WriteLine("Selected index: " + intIndex);
                Console.WriteLine("Integer at index " + intIndex + ": " + intArray[intIndex]);
            }
            else
            {
                Console.WriteLine("Invalid index. Index doesn't exist.");
            }

            Console.ReadLine();
        }
    }


