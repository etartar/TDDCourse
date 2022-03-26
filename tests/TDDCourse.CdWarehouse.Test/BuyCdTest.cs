using NUnit.Framework;
using TDDCourse.CdWarehouse.Concretes;
using TDDCourse.CdWarehouse.Exceptions;

namespace TDDCourse.CdWarehouse.Test
{
    public class BuyCdTest
    {
        [SetUp]
        public void Setup()
        {
        }

        [Test]
        public void EnoughStock()
        {
            CD cd = new CD(10);
            cd.Buy(1);            

            Assert.AreEqual(9, cd.StockCount);
        }

        [Test]
        public void NotEnoughStock()
        {
            CD cd = new CD(10);

            Assert.Throws<InsufficientStockException>(() => cd.Buy(11));
        }
    }
}