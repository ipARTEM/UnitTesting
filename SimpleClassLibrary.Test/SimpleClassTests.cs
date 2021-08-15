using Microsoft.VisualStudio.TestTools.UnitTesting;
using SimpleClassLibrary;
using System;

namespace SimpleClassLibrary.Test
{
    [TestClass]
    public class SimpleClassTests
    {
        [TestMethod()]
        public void Add_2_3_Return_5()
        {
            SimpleClass instance = new SimpleClass();
            int x = 2, y = 3, expected = 5;
            int actual = instance.Add(x, y);
            Assert.AreEqual(expected, actual);
        }

        [TestMethod()]
        public void Div_10_2_Returns_5()
        {
            SimpleClass instance = new SimpleClass();
            int x = 10, y = 2, expected = 5;
            int actual = instance.Div(x, y);
            Assert.AreEqual(expected, actual);
        }

        [TestMethod()]
        [ExpectedException(typeof (DivideByZeroException))]
        public void Div_10_0_ExceptionExpected()
        {
            SimpleClass instance = new SimpleClass();
            int x = 10, y = 0;

            int actual = instance.Div(x, y);
        }
    }
}
