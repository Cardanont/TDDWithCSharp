using CSharpTDD;
using NUnit.Framework;
using System;
using System.Collections.Generic;
using System.Text;

namespace TDD_CSharp_Lib.Test
{
    [TestFixture]
    class RomanNumeralTests
    {
        [TestCase(1, "I")]
        [TestCase(5, "V")]
        [TestCase(10, "X")]
        [TestCase(2, "II")]
        [TestCase(4, "IV")]
        [TestCase(9, "IX")]
        [TestCase(99, "IC")]
        public void Parse(int expected, string roman)
        {
            Assert.AreEqual(expected, RomanNumeral.Parse(roman));
        }
    }
}
