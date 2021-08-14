using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;

namespace UnitTesting.Tests
{
    [TestClass]
    public class CalculatorTests
    {
        [TestMethod]
        public void Sum_15and25_40returned()
        {
            // arrange
            int x = 15, y = 25, expected = 40;



            // act
            Calculator calculator = new Calculator();
            int actual = calculator.Sum(x, y);


            // assert
            Assert.AreEqual(expected, actual);
        }
    }
}
