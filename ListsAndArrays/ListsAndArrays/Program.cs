using System;
using System.Collections.Generic;



    class Program
    {
        static void Main()
        {
            string[] stringArray = { "Apple", "Banana", "Orange" };
            int[] intArray = { 1, 2, 3, 4, 5 };
            List<string> stringList = new List<string> { "Cat", "Dog", "Bird" };

            Console.WriteLine("Select an index for the string array (0-2):");
            int stringIndex = Convert.ToInt32(Console.ReadLine());

            if (stringIndex >= 0 && stringIndex < stringArray.Length)
            {
                Console.WriteLine("Selected index: " + stringIndex);
                Console.WriteLine("String at index " + stringIndex + ": " + stringArray[stringIndex]);
            }

            else
            {
                Console.WriteLine("Invalid Index.");
            }

            Console.WriteLine();

            Console.WriteLine("Select an index for the string list (0-2):");
            int intIndex = Convert.ToInt32(Console.ReadLine());

            if (intIndex >= 0 && intIndex < stringList.Count)
            {
                Console.WriteLine("Selected index: " + intIndex);
                Console.WriteLine("Content at index " + intIndex + ": " + stringList[intIndex]);
            }
            else
            {
                Console.WriteLine("Invalid index. Index doesn't exist.");
            }

            Console.ReadLine();


        }
    }

