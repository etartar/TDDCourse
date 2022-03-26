using NUnit.Framework;
using System.Collections.Generic;

namespace TDDCourse.NUnit.Tests.ShoppingBaskets
{
    public class BasketTest
    {
        [Test]
        public void TotalOfEmptyBasket()
        {
            Basket basket = new Basket(new List<Item>());

            Assert.AreEqual(0.0, basket.Total);
        }
        
        [Test]
        public void TotalOfSingleItem()
        {
            Basket basket = new Basket(new List<Item> { new Item(1, 100.0) });

            Assert.AreEqual(100.0, basket.Total);
        }

        [Test]
        public void TotalOfTwoItems()
        {
            Basket basket = new Basket(new List<Item>
            {
                new Item(1, 100.0),
                new Item(1, 200.0)
            });

            Assert.AreEqual(300.0, basket.Total);
        }

        [Test]
        public void TotalOfQuantityTwo()
        {
            Basket basket = new Basket(new List<Item>
            {
                new Item(2, 100.0)
            });

            Assert.AreEqual(200.0, basket.Total);
        }
    }
}
