using System;
using System.Collections.Generic;
using System.Text;

namespace CSharpTDD
{
    public class Fibonacci
    {
        public static int GetFibonacci(int num)
        {
            if (num == 0) return 0;
            if (num == 1) return 1;
            return GetFibonacci(num - 1) + GetFibonacci(num - 2);
        }
    }
}
