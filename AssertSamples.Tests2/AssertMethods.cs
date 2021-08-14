using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;

namespace AssertSamples.Tests2
{
    [TestClass]
    public class AssertMethods
    {
        [TestMethod]
        public void IsSqrtTest()
        {
            //arrange
            const double input = 4;
            const double expected = 2;

            //act
            double actual = MyClass.GetSqrt(input);

            // assert
            Assert.AreEqual(expected, actual, "Sqrt of {0} should have bee {1}!", input, expected);
        }

        [TestMethod]
        public void DeltaTest()
        {
            const double expected = 3.1;
            const double delta = 0.07;

            double actual = MyClass.GetSqrt(10);

            Assert.AreEqual(expected, actual, delta, "fail massage!");
        }

        [TestMethod]
        public void StringAreEqualTest()
        {
            //arrange
            const string input = "HelLO", expected = "hello";


            //act and  assert

            Assert.AreEqual(expected, input, true);



        }

        [TestMethod]
        public void StringSameTest()
        {
            string a = "Hello";
            string b = "Hello";

            //проверка равенства ссылок
            Assert.AreSame(a,b);
        }

        [TestMethod]
        public void IntegersSameTest()
        {
            int i = 100;
            int j = 100;

            //проверка равенства ссылок
            Assert.AreSame(i,j);
        }

        
    }
}
