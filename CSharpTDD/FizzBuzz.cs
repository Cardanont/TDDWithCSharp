using System;
using System.Collections.Generic;
using System.Text;

namespace CSharpTDD
{
    public class FizzBuzz
    {
        public static string CheckFizzBuzz(int num)
        {
            if (num % 3 == 0 & num % 5 == 0)
                return "FizzBuzz";
            if (num % 3 == 0)
                return "Fizz";
            if (num % 5 == 0)
                return "Buzz";
            return "";
        }
    }
}
