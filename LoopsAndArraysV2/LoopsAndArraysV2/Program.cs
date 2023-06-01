using System;
using System.Collections.Generic;

namespace InfiniteLoops
{
    class Program
    {
        static void Main()
        {
            // one-dimensional array of strings
            string[] array = new string[6] { "I", "can't", "wait", "for", "Diablo", "IV" };

            // ask the user to input some text.
            Console.Write("Enter some text: ");
            string userInput = Console.ReadLine();

            // a loop that iterates through each string in the array
            for (int i = 0; i < array.Length; i++)
            {
                array[i] += userInput;
            }

            // print each string on the array in a separate line
            foreach (string item in array)
            {
                Console.WriteLine(item);
            }

            // a fixed infinite loop that will execute properly
            bool isRunning = true;
            while (isRunning)
            {
                Console.WriteLine("This is an infinite loop. Press any key to stop.");
                Console.ReadKey();
                isRunning = false;
            }

            // comparison loop with '<' operator.
            for (int i = 0; i < array.Length; i++)
            {
                Console.WriteLine(array[i]);
            }

            // comparison loop with '<=' operator
            for (int i = 0; i <= array.Length - 1; i++)
            {
                Console.WriteLine(array[i]);
            }

            // string with list of unique items
            List<string> uniqueList = new List<string>() { "Barbarian", "Rogue", "Sorcerer", "Necromancer", "Druid" };

            // ask user for text input
            Console.Write("Enter text to search in the list: ");
            string searchText = Console.ReadLine();

            // a loop that iterates through the list and displays the index
            bool found = false;
            for (int i = 0; i < uniqueList.Count; i++)
            {
                if (string.Equals(uniqueList[i], searchText, StringComparison.OrdinalIgnoreCase))
                {
                    Console.WriteLine("Match found at index: " + i);
                    found = true;
                    break;
                }
            }

            // Tell the user if text is not in the list
            if (!found)
            {
                Console.WriteLine("Text not found in the list.");
            }

            // list of strings that has at least two identical strings in the list.
            List<string> duplicateList = new List<string> { "Barbarian", "Thief", "Sorcerer", "Necromancer", "Paladin" };

            // loop that iterates through the loop and displays the indices in the list that contain matching text.
            Console.Write("Enter text to search in the duplicate list: ");
            string searchDuplicateText = Console.ReadLine();
            List<int> matchingIndices = new List<int>();

            for (int i = 0; i < duplicateList.Count; i++)
            {
                if (string.Equals(duplicateList[i], searchDuplicateText, StringComparison.OrdinalIgnoreCase))
                {
                    matchingIndices.Add(i);
                }
            }

            // tell the user that the text is not in the list
            if (matchingIndices.Count == 0)
            {
                Console.WriteLine("Text not found in the list.");
            }
            else
            {
                foreach (int index in matchingIndices)
                {
                    Console.WriteLine("Matching index: " + index);
                }
            }

            // a list of strings that has at least two identical strings in the list.
            List<string> identicalList = new List<string>() { "Barbarian", "Rogue", "Sorcerer", "Necromancer", "Druid" };

            // foreach loop that evaluates each item in the list and displays a message showing the string and whether or not it has already appeared in the list.
            List<string> seenItems = new List<string>();

            foreach (string item in identicalList)
            {
                if (seenItems.Contains(item))
                {
                    Console.WriteLine(item + " (Already appeared in the list)");
                }
                else
                {
                    seenItems.Add(item);
                    Console.WriteLine(item);
                }
            }

            Console.ReadLine();
        }
    }
}