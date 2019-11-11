using System;
using System.Collections.Generic;
using System.Text;

namespace CSharpTDD
{
    public class RomanNumeral
    {
        public static Dictionary<char, int> map =
            new Dictionary<char, int>()
        {
            {'I', 1 },
            {'V', 5 },
            {'X', 10 },
            {'L', 50 },
            {'C', 100 },
            {'D', 500 },
            {'M', 1000 }
        };

        public static int Parse(string roman)
        {
            return map[roman[0]];
        }
    }
}
