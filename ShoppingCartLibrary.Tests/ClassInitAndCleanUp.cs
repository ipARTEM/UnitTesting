using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ShoppingCartLibrary.Tests
{
    [TestClass]
    public  class ClassInitAndCleanUp
    {
        private static ShoppingCart cart;

        [ClassInitialize]
        public static void ClassInitislize(TestContext context)
        {
            Debug.WriteLine("Class Initialize");
            Item item = new Item();
            item.Name = "Unit Test Video Lessons";
            item.Quantity = 100;

            cart = new ShoppingCart();
            cart.Add(item);
        }

        [ClassCleanup]
        public static void TestCleanUp()
        {
            Debug.WriteLine("Class CleanUp");
            cart.Dispose();
        }

        [TestMethod]
        public void ShopingCart_AddToCart()
        {
            int expected = cart.Items.Count + 1;
            cart.Add(new Item() { Name = "Test", Quantity = 1 });
            Assert.AreEqual(expected, cart.Count);
        }


    }
}
