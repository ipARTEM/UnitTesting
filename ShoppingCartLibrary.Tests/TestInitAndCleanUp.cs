using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using System.Diagnostics;

namespace ShoppingCartLibrary.Tests
{
    [TestClass]
    public class TestInitAndCleanUp
    {
        private ShoppingCart cart;
        private Item item;

        [TestInitialize]
        public void TestInitialize()
        {
            Debug.WriteLine("Начало тестирования");
            item = new Item();
            item.Name = "Юнит тестирование";
            item.Quantity = 100;

            cart = new ShoppingCart();
            cart.Add(item);
        }

        [TestCleanup]
        public void TestCleanUp()
        {
            Debug.WriteLine("Test CleanUp");
            cart.Dispose();
        }


        [TestMethod]
        public void ShopingCart_CheckOut_ContainsItem()
        {
            CollectionAssert.Contains(cart.Items, item);
        }

        [TestMethod]
        public void ShopingCart_RemoveItem_Empty()
        {
            int expected = 0;

            cart.Remove(0);

            Assert.AreEqual(expected, cart.Count);
        }
    }
}
