using CSharpTDD;
using NUnit.Framework;
using System;

namespace TDD_CSharp_Lib.Test
{
    [TestFixture]
    public class FibonacciTests
    {
        [TestCase(0, 0)]
        [TestCase(1, 1)]
        [TestCase(2, 3)]
        public void TestFibonnaci(int expected, int index)
        {
            Assert.AreEqual(expected, Fibonacci.GetFibonacci(index));
        }
    }
}
