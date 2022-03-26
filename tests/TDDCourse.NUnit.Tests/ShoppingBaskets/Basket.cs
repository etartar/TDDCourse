using System.Collections.Generic;
using System.Linq;

namespace TDDCourse.NUnit.Tests.ShoppingBaskets
{
    public class Basket
    {
        private readonly List<Item> _items;

        public Basket(List<Item> items)
        {
            _items = items;
        }

        public double Total => _items.Aggregate(0, (double sum, Item item) => sum += item.SubTotal());
    }
}
