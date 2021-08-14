using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AssertSamples.Tests2
{
    [TestClass]
    public  class ExpectingExceptions
    {

        [ExpectedException(typeof(ArgumentNullException),"Exception was not thrown")]
        [TestMethod]
        public void MyClass_SayHello_Exception()
        {
            MyClass instance = new MyClass();
            instance.SayHello(null);
        }

        [TestMethod]
        public void MyClass_SayHello_ReturnArtem()
        {
            //arrange
            MyClass instance = new MyClass();
            string expected = "Hello Artem";

            //act
            string actual = instance.SayHello("Artem");

            Assert.AreEqual(expected, actual);

        }



    }
}
