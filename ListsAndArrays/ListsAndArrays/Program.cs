using System;
using System.Collections.Generic;


namespace ListsAndArrays
{
    class Program
    {
        static void Main()
        {
            // One-dimensional array of strings
            string[] stringArray = { "Apple", "Banana", "Orange", "Grape", "Mango" };

            // One-dimensional array of integers
            int[] intArray = { 10, 20, 30, 40, 50 };

            // List of strings
            List<string> stringList = new List<string> { "John", "Jane", "Alice", "Bob", "Mike" };

            Console.WriteLine("Select an index to display a string from the Array: ");
            int stringIndex = Convert.ToInt32(Console.ReadLine());

            //Check if the selected index is within the bounds of the array
            if (stringIndex >= 0 && stringIndex < stringArray.Length)
            {
                Console.WriteLine("String at index {0}: {1}", stringIndex, stringArray[stringIndex]);
            }
            else
            {
                Console.WriteLine("Index out of range.");
            }

            Console.WriteLine("Select an index to display an integer from the Array: ");
            int intIndex = Convert.ToInt32(Console.ReadLine());

            // Check if the selected index is within the bounds of the Array.
            if (intIndex >= 0 && intIndex < intArray.Length)
            {
                Console.WriteLine("Integer at index {0}: {1}", intIndex, intArray[intIndex]);
            }
            else
            {
                Console.WriteLine("Index out of range.");
            }

            Console.WriteLine("Select an index to display a string from the List: ");
            int listIndex = Convert.ToInt32(Console.ReadLine());

            // Check if the selected index is within the bounds of the List.
            if (listIndex >= 0 && listIndex < stringList.Count)
            {
                Console.WriteLine("String at index {0}: {1}", listIndex, stringList[listIndex]);
            }
            else
            {
                Console.WriteLine("Index out of range.");
            }

            Console.ReadLine();
        }
    }
}

