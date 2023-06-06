using System;
using System.Collections.Generic;
using System.Text;

namespace ClassMethodsV3
{
    class MethodSub
    {
        public int PerformMathOperation(int num1, int num2 = 0)
        {
            int result = num1 - num2;
            return result;
        }
    }
}
