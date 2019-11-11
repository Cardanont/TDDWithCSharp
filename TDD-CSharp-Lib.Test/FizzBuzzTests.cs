using System;
using System.Collections.Generic;
using System.Text;
using CSharpTDD;
using NUnit.Framework;

namespace TDD_CSharp_Lib.Test
{

    [TestFixture]
    class FizzBuzzTests
    {
        [TestCase("Fizz", 3)]
        [TestCase("Fizz", 6)]
        [TestCase("Buzz", 5)]
        [TestCase("Buzz", 10)]
        [TestCase("FizzBuzz", 15)]
        [TestCase("FizzBuzz", 30)]
        [TestCase("", 7)]
        
        public void TestFizzBuzz(string expexted, int number)
        {
            Assert.AreEqual(expexted, FizzBuzz.CheckFizzBuzz(number));
        }
    }
}
