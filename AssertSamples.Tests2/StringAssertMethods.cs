using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;

namespace AssertSamples.Tests2
{
    [TestClass]
    public  class StringAssertMethods
    {
        [TestMethod]
        public void StringContainsTest()
        {
            // проверка на вхождение в строку подстроки
            StringAssert.Contains("Assert samples", "sam");
        }

        [TestMethod]
        public void StringMatchesTest()
        {

            StringAssert.Matches("123", new Regex(@"\d{3}"));
        }

        [TestMethod]
        public void StringStartdWithTest()
        {
            StringAssert.StartsWith("Hello planet", "Hello");
        }

        public void StringEnddWithTest()
        {
            StringAssert.EndsWith("Hello planet", "planet");
        }



    }
}
