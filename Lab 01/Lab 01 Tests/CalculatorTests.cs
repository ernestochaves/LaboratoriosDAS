using System;
using Lab_01;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace Lab_01_Tests
{
    [TestClass]
    public class CalculatorTests
    {
        [TestMethod]
        public void TestMethod1()
        {
            var calc = new Calculator();
            int result = calc.Sum(1, 1);

            Assert.AreEqual(2, result);
        }
    }
}
