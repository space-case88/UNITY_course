using System;
using System.Collections.Generic;
using System.Text;

namespace mainMethod
{
    class IntMethod
    {
        public int Calculate(int number)
        {
            int result = (int)(number * 2);
            return result;
        }

        public int Calculate(decimal number)
        {
            int result = (int)(number + 3);
            return result;
        }
        public int Calculate(string number)
        {
            int parsedNumber;
            bool success = int.TryParse(number, out parsedNumber);

            if (success)
            {
                int result = parsedNumber - 5;
                return result;
            }
            else
            {
                Console.WriteLine("Invalid input. Unable to convert the string to an integer.");
                return 0;
            }
        }
    }
}
